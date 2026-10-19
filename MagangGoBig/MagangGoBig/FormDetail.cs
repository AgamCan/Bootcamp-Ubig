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
    public partial class FormDetail : Form
    {
        MagangGoBIGEntities db = new MagangGoBIGEntities();
        private int idPeserta;
        public FormDetail(int idPeserta)
        {
            InitializeComponent();
            this.idPeserta = idPeserta;
        }

        private void FormDetail_Load(object sender, EventArgs e)
        {
            CultureInfo idID = new CultureInfo("id-ID");
            var peserta = db.Peserta.FirstOrDefault(p => p.IdPeserta == idPeserta);

            if (peserta == null) return;

            label1.Text = $"Id Peserta: {peserta.IdPeserta}";
            label2.Text = $"Nama Lengkap: {peserta.NamaLengkap}";
            label3.Text = $"Tanggal Lahir: {peserta.TanggalLahir.ToString("d MMMM yyyy", idID)}";
            label4.Text = $"Sekolah: {peserta.Sekolah}";
            label5.Text = $"Masuk Magang: {peserta.MasukMagang.ToString("d MMMM yyyy", idID)}";
            label6.Text = $"Akhir Magang: {peserta.AkhirMagang.ToString("d MMMM yyyy", idID)}";
        }
    }
}
