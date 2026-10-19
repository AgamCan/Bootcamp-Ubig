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
    public partial class FormLogin : Form
    {
        MagangGoBIGEntities db = new MagangGoBIGEntities();
        public FormLogin()
        {
            InitializeComponent();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            txtPassword.UseSystemPasswordChar = !checkBox1.Checked;
        }

        private void CLearField()
        {
            txtPassword.Clear();
            txtUsername.Clear();
            txtPassword.Focus();
            txtUsername.Focus();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text.Trim();

            if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("Username dan password tidak boleh kosong", "peringatan",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var user = db.Pengguna.FirstOrDefault(p => p.Username == username && p.Password == password);
            try
            {
                if (user != null)
                {
                    FormMain formMain = new FormMain();
                    formMain.FormClosed += (s, args) => Application.Exit();
                    formMain.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Username atau password salah", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    CLearField();
                    return;
                }
            }
            catch  (Exception ex)
            {
                MessageBox.Show("Error" + ex.Message);
            }
        }

        private void FormLogin_Load(object sender, EventArgs e)
        {

        }
    }
}
