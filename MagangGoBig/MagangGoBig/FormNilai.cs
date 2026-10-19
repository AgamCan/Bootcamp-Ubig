using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MagangGoBig
{
    public partial class FormNilai : Form
    {
        MagangGoBIGEntities db = new MagangGoBIGEntities();
        private int idPeserta;
        public FormNilai(int idPeserta)
        {
            InitializeComponent();
            this.idPeserta = idPeserta;
        }

        private void FormNilai_Load(object sender, EventArgs e)
        {
            LoadData();
            SetModeUbah(false);
        }

        private void LoadData()
        {
            db = new MagangGoBIGEntities();
            var peserta = db.Peserta.FirstOrDefault(p => p.IdPeserta == idPeserta);

            lblNama.Text = $"Nama Lengkap: {peserta.NamaLengkap}";

            var nilai = peserta.NilaiPeserta;
            nudDisiplin.Value = nilai == null ? 0 : nilai.Disiplin;
            nudInisiatif.Value = nilai == null ? 0 : nilai.Inisiatif;
            nudKomunikasi.Value = nilai == null ? 0 : nilai.Komunikasi;
            nudKreativitas.Value = nilai == null ? 0 : nilai.Kreativitas;
            nudProblemSolving.Value = nilai == null ? 0 : nilai.ProblemSolving;
            nudTanggungJawab.Value = nilai == null ? 0 : nilai.TanggungJawab;
        }

        private void SetModeUbah(bool ubah)
        {
            nudDisiplin.Enabled = ubah;
            nudInisiatif.Enabled = ubah;
            nudKomunikasi.Enabled = ubah;
            nudKreativitas.Enabled = ubah;
            nudProblemSolving.Enabled = ubah;
            nudTanggungJawab.Enabled = ubah;

            btnUbah.Enabled = !ubah;
            btnSimpan.Enabled = ubah;
            btnBatal.Enabled = ubah;
        }

        private int HitungIdStatus(double rataRata)
        {
            if (rataRata >= 85) return 1;
            if (rataRata >= 70) return 2;
            if (rataRata >= 60) return 3;
            return 4;
        }

        private void btnUbah_Click(object sender, EventArgs e)
        {
            SetModeUbah(true);
        }

        private void btnSimpan_Click(object sender, EventArgs e)
        {
            try
            {
                var peserta = db.Peserta.FirstOrDefault(p => p.IdPeserta == idPeserta);
                var nilai = peserta.NilaiPeserta;

                if (nilai == null)
                {
                    nilai = new NilaiPeserta();
                    db.NilaiPeserta.Add(nilai);
                    peserta.NilaiPeserta = nilai;
                }

                nilai.Disiplin = (int)nudDisiplin.Value;
                nilai.Inisiatif = (int)nudInisiatif.Value;
                nilai.Komunikasi = (int)nudKomunikasi.Value;
                nilai.Kreativitas = (int)nudKreativitas.Value;
                nilai.ProblemSolving = (int)nudProblemSolving.Value;
                nilai.TanggungJawab = (int)nudTanggungJawab.Value;

                double rataRata = (nilai.Disiplin + nilai.Inisiatif + nilai.Komunikasi +
                                   nilai.Kreativitas + nilai.ProblemSolving + nilai.TanggungJawab) / 6.0;
                nilai.IdStatusNilaiPeserta = HitungIdStatus(rataRata);

                db.SaveChanges();

                MessageBox.Show("Nilai berhasil disimpan!", "Berhasil",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                SetModeUbah(false);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btnBatal_Click(object sender, EventArgs e)
        {
            LoadData();
            SetModeUbah(false);
        }
    }
}
