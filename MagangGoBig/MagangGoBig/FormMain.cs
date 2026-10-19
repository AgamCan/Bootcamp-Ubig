using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MagangGoBig
{
    public partial class FormMain : Form
    {
        MagangGoBIGEntities db = new MagangGoBIGEntities();
        private int? idDipilih = null;
        public FormMain()
        {
            InitializeComponent();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void UpdateWaktu()
        {
            lblWaktu.Text = $"Waktu : " +
                $"{DateTime.Now.ToString("HH':'mm dd MMMM yyyy", new CultureInfo("id-ID"))}";
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            UpdateWaktu();
        }

        private void LoadData()
        {
            db = new MagangGoBIGEntities();
            string kataCari = txtCari.Text.Trim();
            pesertaBindingSource.DataSource = db.Peserta.
                Where(x => x.NamaLengkap.Contains(kataCari)).ToList();
        }

        private void txtCari_TextChanged(object sender, EventArgs e)
        {
            LoadData();
        }

        private Color AmbilWarna(Peserta p)
        {
            DateTime hariIni = DateTime.Today;

            if (p.MasukMagang.Date > hariIni) return Color.Blue;     
            if (p.AkhirMagang.Date < hariIni) return Color.Red;   
            if ((p.AkhirMagang.Date - hariIni).TotalDays <= 30) return Color.Green;   
            if ((hariIni - p.MasukMagang.Date).TotalDays <= 30) return Color.Purple;  

            return Color.Empty;
        }

        private void dgvPeserta_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.RowIndex < 0) return;

            if (dgvPeserta.Rows[e.RowIndex].DataBoundItem is Peserta p)
            {
                Color warna = AmbilWarna(p);
                if (!warna.IsEmpty)
                {
                    e.CellStyle.BackColor = warna;
                    e.CellStyle.ForeColor = Color.White;
                }
            }
        }

        private void dgvPeserta_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            if (dgvPeserta.Rows[e.RowIndex].DataBoundItem is Peserta p)
            {
                idDipilih = p.IdPeserta;
                txtNamaLengkap.Text = p.NamaLengkap;
                txtSekolah.Text = p.Sekolah;
                dtpTanggalLahir.Value = p.TanggalLahir;
                dtpMasukMagang.Value= p.MasukMagang;
                dtpAkhirMagang.Value = p.AkhirMagang;
            }
        }

        private void dgvPeserta_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            if (dgvPeserta.Rows[e.RowIndex].DataBoundItem is Peserta p)
            {
                if (e.ColumnIndex == colDetail.Index)
                {
                    FormDetail detail = new FormDetail(p.IdPeserta);
                    detail.ShowDialog(this);
                }

                if (e.ColumnIndex == colNilai.Index)
                {
                    FormNilai nilai = new FormNilai(p.IdPeserta);
                    nilai.ShowDialog(this);
                }
            }
        }

        private bool ValidasiInput(int idAbaikan)
        {
            string nama = txtNamaLengkap.Text.Trim();

            if (string.IsNullOrWhiteSpace(nama))
            {
                MessageBox.Show("Nama lengkap tidak boleh kosong!", "Peringatan",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNamaLengkap.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtSekolah.Text))
            {
                MessageBox.Show("Sekolah tidak boleh kosong!", "Peringatan",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtSekolah.Focus();
                return false;
            }

            DateTime masuk = dtpMasukMagang.Value.Date;
            DateTime akhir = dtpAkhirMagang.Value.Date;

            if (masuk == akhir)
            {
                MessageBox.Show("Masuk Magang dan Akhir Magang tidak boleh sama!", "Peringatan",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (akhir < masuk)
            {
                MessageBox.Show("Akhir Magang tidak boleh lebih kecil dari Masuk Magang!", "Peringatan",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            bool namaSudahAda = db.Peserta.Any(p => p.NamaLengkap == nama && p.IdPeserta != idAbaikan);
            if (namaSudahAda)
            {
                MessageBox.Show("Peserta dengan nama \"" + nama + "\" sudah ada!", "Peringatan",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNamaLengkap.Focus();
                return false;
            }

            return true;
        }

        private void ResetForm()
        {
            txtNamaLengkap.Clear();
            txtSekolah.Clear();
            dtpTanggalLahir.Value = DateTime.Today;
            dtpMasukMagang.Value = DateTime.Today;
            dtpAkhirMagang.Value = DateTime.Today;
            idDipilih = null;
        }

        private void btnTambah_Click(object sender, EventArgs e)
        {
            if (!ValidasiInput(0)) return;

            try
            {
                Peserta pesertaBaru = new Peserta
                {
                    NamaLengkap = txtNamaLengkap.Text.Trim(),
                    Sekolah = txtSekolah.Text.Trim(),
                    TanggalLahir = dtpTanggalLahir.Value.Date,
                    MasukMagang = dtpMasukMagang.Value.Date,
                    AkhirMagang = dtpAkhirMagang.Value.Date
                };

                db.Peserta.Add(pesertaBaru);
                db.SaveChanges();

                MessageBox.Show("Peserta baru berhasil ditambahkan", "Berhasil!",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                ResetForm();
                LoadData();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error :{ex.Message}");
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (idDipilih == null)
            {
                MessageBox.Show("Klik salah satu baris peserta di tabel terlebih dahulu!", "Peringatan",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int id = idDipilih.Value;
            if (!ValidasiInput(id)) return;

            try
            {
                var peserta = db.Peserta.FirstOrDefault(p => p.IdPeserta == id);

                if (peserta != null)
                {
                    peserta.NamaLengkap = txtNamaLengkap.Text.Trim();
                    peserta.Sekolah = txtSekolah.Text.Trim();
                    peserta.TanggalLahir = dtpTanggalLahir.Value.Date;
                    peserta.MasukMagang = dtpMasukMagang.Value.Date;
                    peserta.AkhirMagang = dtpAkhirMagang.Value.Date;

                    db.SaveChanges();

                    MessageBox.Show("Data peserta berhasil diperbarui!", "Berhasil",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);

                    ResetForm();
                    LoadData();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error : {ex.Message}");
            }
        }

        private void btnHapus_Click(object sender, EventArgs e)
        {
            if (idDipilih == null)
            {
                MessageBox.Show("Klik salah satu baris peserta di tabel terlebih dahulu!", "Peringatan",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int id = idDipilih.Value;

            try
            {
                var peserta = db.Peserta.FirstOrDefault(p => p.IdPeserta == id);
                if (peserta == null) return;

                var konfirmasi = MessageBox.Show(
                    "Apakah kamu yakin ingin menghapus peserta \"" + peserta.NamaLengkap + "\"?",
                    "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (konfirmasi != DialogResult.Yes) return;

                db.Peserta.Remove(peserta);
                db.SaveChanges();

                MessageBox.Show("Peserta berhasil dihapus!", "Berhasil",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                ResetForm();
                LoadData();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
    }
}
