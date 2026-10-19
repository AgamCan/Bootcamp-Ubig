using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bukuku
{
    public partial class Form2 : Form
    {
        DataTable tabelBuku = new DataTable();
        public Form2()
        {
            InitializeComponent();
            dgvBuku.CellFormatting += DgvBuku_CellFormatting;
        }

        private void DgvBuku_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.RowIndex < 0) return;

            DataRowView baris = dgvBuku.Rows[e.RowIndex].DataBoundItem as DataRowView;
            if (baris == null) return;

            int sisa = (int)baris["SisaHalaman"];

            if (sisa == 0)
            {
                e.CellStyle.BackColor = Color.Green;
                e.CellStyle.ForeColor = Color.White;

                if (dgvBuku.Columns[e.ColumnIndex].Name == "SisaHalaman")
                {
                    e.Value = "Tamat";
                    e.FormattingApplied = true;
                }
            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            tabelBuku.Columns.Add("Judul", typeof(string));
            tabelBuku.Columns.Add("Penulis", typeof(string));
            tabelBuku.Columns.Add("Bahasa", typeof(string));
            tabelBuku.Columns.Add("TotalHalaman", typeof(int));
            tabelBuku.Columns.Add("HalamanDibaca", typeof(int));
            tabelBuku.Columns.Add("SisaHalaman", typeof(int), "TotalHalaman - HalamanDibaca");

            tabelBuku.Rows.Add("Laskar Pelangi", "Andrea Hirata", "Indonesia", 529, 529);
            tabelBuku.Rows.Add("Bumi", "Tere Liye", "Indonesia", 440, 120);
            tabelBuku.Rows.Add("Atomic Habits", "James Clear", "Inggris", 320, 320);

            dgvBuku.DataSource = tabelBuku;
            dgvBuku.Columns["TotalHalaman"].HeaderText = "Total Halaman";
            dgvBuku.Columns["HalamanDibaca"].HeaderText = "Halaman Dibaca";
            dgvBuku.Columns["SisaHalaman"].HeaderText = "Sisa Halaman";

            UpdateInfo();
        }

        private void UpdateInfo()
        {
            int totalDibaca = 0;
            int totalBelumDibaca = 0;

            foreach (DataRow baris in tabelBuku.Rows)
            {
                totalDibaca += (int)baris["HalamanDibaca"];
                totalBelumDibaca += (int)baris["SisaHalaman"];
            }

            lblTotalBuku.Text = "Total Buku: " + tabelBuku.Rows.Count;
            lblTotalDibaca.Text = "Total Halaman Dibaca: " + totalDibaca;
            lblTotalBelumDibaca.Text = "Total Halaman Belum Dibaca: " + totalBelumDibaca;
        }

        private void btnTambah_Click(object sender, EventArgs e)
        {
            string judul = txtJudul.Text.Trim();
            string penulis = txtPenulis.Text.Trim();
            string bahasa = txtBahasa.Text.Trim();
            int total = (int)nudTotalHalaman.Value;
            int dibaca = (int)nudHalamanDibaca.Value;

            if (judul == "")
            {
                MessageBox.Show("Judul tidak boleh kosong!", "Peringatan",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtJudul.Focus();
                return;
            }

            if (penulis == "")
            {
                MessageBox.Show("Penulis tidak boleh kosong!", "Peringatan",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtPenulis.Focus();
                return;
            }

            if (bahasa == "")
            {
                MessageBox.Show("Bahasa tidak boleh kosong!", "Peringatan",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtBahasa.Focus();
                return;
            }

            if (total == 0)
            {
                MessageBox.Show("Total halaman harus lebih dari 0!", "Peringatan",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                nudTotalHalaman.Focus();
                return;
            }

            if (dibaca > total)
            {
                MessageBox.Show("Halaman dibaca tidak boleh lebih besar dari total halaman!", "Peringatan",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                nudHalamanDibaca.Focus();
                return;
            }

            tabelBuku.Rows.Add(judul, penulis, bahasa, total, dibaca);

            txtJudul.Clear();
            txtPenulis.Clear();
            txtBahasa.Clear();
            nudTotalHalaman.Value = 0;
            nudHalamanDibaca.Value = 0;
            txtJudul.Focus();

            UpdateInfo();
        }

        private void btnHapus_Click(object sender, EventArgs e)
        {
            if (dgvBuku.CurrentRow == null)
            {
                MessageBox.Show("Pilih buku yang ingin dihapus terlebih dahulu!", "Peringatan",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DataRowView baris = (DataRowView)dgvBuku.CurrentRow.DataBoundItem;
            string judul = baris["Judul"].ToString();

            DialogResult konfirmasi = MessageBox.Show(
                "Apakah kamu yakin ingin menghapus buku \"" + judul + "\"?",
                "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (konfirmasi == DialogResult.Yes)
            {
                tabelBuku.Rows.Remove(baris.Row);
                UpdateInfo();
            }
        }
    }
}
