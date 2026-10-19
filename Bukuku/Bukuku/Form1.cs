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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string usernmae = textBox1.Text.Trim();
            string password = textBox2.Text;

            if (string.IsNullOrEmpty(usernmae) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Username atau password tidak boleh kosong", "PERINGATAN!",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (usernmae == "admin" && password == "admin123")
            {
                Form2 main = new Form2();
                this.Hide();
                main.ShowDialog();
            }
            else
            {
                MessageBox.Show("Login Gagal", "ERROR!",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
