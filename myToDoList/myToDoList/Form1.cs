using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace myToDoList
{
    public partial class Form1 : Form
    {
        MyTodoListDBEntities db = new MyTodoListDBEntities();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void LoadData()
        {
            db = new MyTodoListDBEntities();
            tugasBindingSource.DataSource = db.Tugas.ToList();
        }

        private void btnTambah_Click(object sender, EventArgs e)
        {
            string namaTugas = txtTugas.Text.Trim();

            var cekDuplikat = db.Tugas.Any(t => t.NamaTugas == namaTugas);
            if (cekDuplikat)
            {
                MessageBox.Show("Nama Tugas tidak boleh sama", "Peringtatan!",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            
            if (string.IsNullOrWhiteSpace(namaTugas))
            {
                MessageBox.Show("Field tugas tidak boleh kosong!", "Peringatan",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTugas.Focus();
                return;
            }

            try
            {
                Tugas tugasBaru = new Tugas { 
                    NamaTugas =namaTugas,
                    Selesai = false
                };

                db.Tugas.Add(tugasBaru);
                db.SaveChanges();

                MessageBox.Show("Tugas berhasil ditambahkan1", "Berhasil",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                txtTugas.Clear();
                LoadData();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btnSelesai_Click(object sender, EventArgs e)
        {
            if (dgvTugas.CurrentRow == null ||
                !(dgvTugas.CurrentRow.DataBoundItem is Tugas tugasDipilih))
            {
                MessageBox.Show("Pilih tugas terlebih dahulu!", "Peringatan",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                var tugas = db.Tugas.FirstOrDefault(t => t.ID == tugasDipilih.ID);
                if (tugas != null)
                {
                    tugas.Selesai = !tugas.Selesai;
                    db.SaveChanges();

                    dgvTugas.Refresh();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btnHapus_Click(object sender, EventArgs e)
        {
            if (dgvTugas.CurrentRow == null ||
                !(dgvTugas.CurrentRow.DataBoundItem is Tugas tugasDipilih))
            {
                MessageBox.Show("Pilih tugas yang ingin dihapus!", "Peringatan",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var pesan = MessageBox.Show(
                "Apakah kamu yakin ingin menghapus tugas \"" + tugasDipilih.NamaTugas + "\"?",
                "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (pesan != DialogResult.Yes) return;

            try
            {
                var tugasHapus = db.Tugas.FirstOrDefault(t => t.ID == tugasDipilih.ID);

                if (tugasHapus != null)
                {
                    db.Tugas.Remove(tugasHapus);
                    db.SaveChanges();

                    MessageBox.Show("Tugas berhasil dihapus!", "Berhasil",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);

                    LoadData();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
    }
}
