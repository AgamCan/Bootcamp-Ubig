using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MagangGoBI_
{
    public partial class Form1 : Form
    {
        private readonly MagangGoBIGEntities db = new MagangGoBIGEntities();
        public Form1()  
        {
            InitializeComponent();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            textBox2.UseSystemPasswordChar = !checkBox1.Checked;
        }

        private void Clear()
        {
            textBox1.Clear();
            textBox2.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string username = textBox1.Text;
            string password = textBox2.Text;

            if(string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("Username dan password tidak boleh kosong");
                Clear();
                return;
            }

            try
            {
                var user = db.Pengguna.FirstOrDefault(x => x.Username == username && x.Password == password);

                if (user != null)
                {
                    Form2 main = new Form2();
                    main.FormClosed += (s, args) => Application.Exit();
                    main.ShowDialog();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Login gagal!");
                    Clear();
                }
            }catch(Exception ex)
            {
                MessageBox.Show("Error :" +  ex.Message);
            }
        }
    }
}
