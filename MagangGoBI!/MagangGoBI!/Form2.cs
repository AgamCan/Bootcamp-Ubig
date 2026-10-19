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

namespace MagangGoBI_
{
    public partial class Form2 : Form
    {
        MagangGoBIGEntities db = new MagangGoBIGEntities();
        private int? idDipilih = null;
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            LoadData();
            dataGridView1.CellFormatting += DataGridView1_CellFormatting;
        }

        private void DataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.RowIndex < 0) return;

            if (dataGridView1.Rows[e.RowIndex].DataBoundItem is Peserta p)
            {
                Color warna = AmbilWarna(p);
                if (!warna.IsEmpty)
                {
                    e.CellStyle.BackColor = warna;
                    e.CellStyle.ForeColor = Color.White;
                }
            }
        }

        private void UpdateWaktu()
        {
            label1.Text = "Waktu :" + 
                DateTime.Now.ToString("HH':'mm dd MMMM yyyy", new CultureInfo("id-ID"));
        }

        private void LoadData()
        {
            db = new MagangGoBIGEntities();
            string kataCari = textBox1.Text.Trim();
            pesertaBindingSource.DataSource = db.Peserta.Where(p => p.NamaLengkap.Contains(kataCari)).ToList();
        }

        private void timerWaktu_Tick_Tick(object sender, EventArgs e)
        {
            UpdateWaktu();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            if (dataGridView1.Rows[e.RowIndex].DataBoundItem is Peserta p)
            {
                idDipilih = p.IdPeserta;
                textBox2.Text = p.NamaLengkap;
                textBox3.Text = p.Sekolah;
                dateTimePicker1.Value = p.TanggalLahir;
                dateTimePicker2.Value = p.AkhirMagang;
                dateTimePicker3.Value = p.MasukMagang;
            }

            if (e.ColumnIndex == DetailCol.Index)
            {
                Form4 formDetail = new Form4(p.IdPeserta);
                formDetail.ShowDialog(this);
            }
            else if (e.ColumnIndex == NilaiCol.Index)
            {
                Form3 formNilai = new Form3(p.IdPeserta);
                formNilai.ShowDialog(this);
            }
        }
    }
}
