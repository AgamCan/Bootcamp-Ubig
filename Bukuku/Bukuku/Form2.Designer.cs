namespace Bukuku
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgvBuku = new System.Windows.Forms.DataGridView();
            this.btnTambah = new System.Windows.Forms.Button();
            this.btnHapus = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtJudul = new System.Windows.Forms.TextBox();
            this.txtPenulis = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBahasa = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.nudTotalHalaman = new System.Windows.Forms.NumericUpDown();
            this.nudHalamanDibaca = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.lblTotalBuku = new System.Windows.Forms.Label();
            this.lblTotalDibaca = new System.Windows.Forms.Label();
            this.lblTotalBelumDibaca = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBuku)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudTotalHalaman)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudHalamanDibaca)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvBuku
            // 
            this.dgvBuku.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBuku.Location = new System.Drawing.Point(12, 12);
            this.dgvBuku.Name = "dgvBuku";
            this.dgvBuku.RowHeadersWidth = 51;
            this.dgvBuku.RowTemplate.Height = 24;
            this.dgvBuku.Size = new System.Drawing.Size(987, 273);
            this.dgvBuku.TabIndex = 0;
            // 
            // btnTambah
            // 
            this.btnTambah.Location = new System.Drawing.Point(12, 291);
            this.btnTambah.Name = "btnTambah";
            this.btnTambah.Size = new System.Drawing.Size(123, 37);
            this.btnTambah.TabIndex = 1;
            this.btnTambah.Text = "Tambah";
            this.btnTambah.UseVisualStyleBackColor = true;
            this.btnTambah.Click += new System.EventHandler(this.btnTambah_Click);
            // 
            // btnHapus
            // 
            this.btnHapus.Location = new System.Drawing.Point(12, 334);
            this.btnHapus.Name = "btnHapus";
            this.btnHapus.Size = new System.Drawing.Size(123, 37);
            this.btnHapus.TabIndex = 2;
            this.btnHapus.Text = "Hapus";
            this.btnHapus.UseVisualStyleBackColor = true;
            this.btnHapus.Click += new System.EventHandler(this.btnHapus_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(174, 291);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Judul";
            // 
            // txtJudul
            // 
            this.txtJudul.Location = new System.Drawing.Point(177, 310);
            this.txtJudul.Name = "txtJudul";
            this.txtJudul.Size = new System.Drawing.Size(199, 22);
            this.txtJudul.TabIndex = 4;
            // 
            // txtPenulis
            // 
            this.txtPenulis.Location = new System.Drawing.Point(177, 359);
            this.txtPenulis.Name = "txtPenulis";
            this.txtPenulis.Size = new System.Drawing.Size(199, 22);
            this.txtPenulis.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(174, 340);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "Penulis";
            // 
            // txtBahasa
            // 
            this.txtBahasa.Location = new System.Drawing.Point(177, 413);
            this.txtBahasa.Name = "txtBahasa";
            this.txtBahasa.Size = new System.Drawing.Size(199, 22);
            this.txtBahasa.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(174, 394);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 16);
            this.label3.TabIndex = 7;
            this.label3.Text = "Bahasa";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(484, 291);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 16);
            this.label4.TabIndex = 9;
            this.label4.Text = "Total halaman";
            // 
            // nudTotalHalaman
            // 
            this.nudTotalHalaman.Location = new System.Drawing.Point(487, 309);
            this.nudTotalHalaman.Name = "nudTotalHalaman";
            this.nudTotalHalaman.Size = new System.Drawing.Size(200, 22);
            this.nudTotalHalaman.TabIndex = 10;
            // 
            // nudHalamanDibaca
            // 
            this.nudHalamanDibaca.Location = new System.Drawing.Point(487, 359);
            this.nudHalamanDibaca.Name = "nudHalamanDibaca";
            this.nudHalamanDibaca.Size = new System.Drawing.Size(200, 22);
            this.nudHalamanDibaca.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(484, 341);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(175, 16);
            this.label5.TabIndex = 11;
            this.label5.Text = "Halaman yang telah di baca";
            // 
            // lblTotalBuku
            // 
            this.lblTotalBuku.AutoSize = true;
            this.lblTotalBuku.Location = new System.Drawing.Point(760, 292);
            this.lblTotalBuku.Name = "lblTotalBuku";
            this.lblTotalBuku.Size = new System.Drawing.Size(44, 16);
            this.lblTotalBuku.TabIndex = 13;
            this.lblTotalBuku.Text = "label6";
            // 
            // lblTotalDibaca
            // 
            this.lblTotalDibaca.AutoSize = true;
            this.lblTotalDibaca.Location = new System.Drawing.Point(760, 341);
            this.lblTotalDibaca.Name = "lblTotalDibaca";
            this.lblTotalDibaca.Size = new System.Drawing.Size(44, 16);
            this.lblTotalDibaca.TabIndex = 14;
            this.lblTotalDibaca.Text = "label7";
            // 
            // lblTotalBelumDibaca
            // 
            this.lblTotalBelumDibaca.AutoSize = true;
            this.lblTotalBelumDibaca.Location = new System.Drawing.Point(760, 394);
            this.lblTotalBelumDibaca.Name = "lblTotalBelumDibaca";
            this.lblTotalBelumDibaca.Size = new System.Drawing.Size(44, 16);
            this.lblTotalBelumDibaca.TabIndex = 15;
            this.lblTotalBelumDibaca.Text = "label8";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1011, 472);
            this.Controls.Add(this.lblTotalBelumDibaca);
            this.Controls.Add(this.lblTotalDibaca);
            this.Controls.Add(this.lblTotalBuku);
            this.Controls.Add(this.nudHalamanDibaca);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.nudTotalHalaman);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtBahasa);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtPenulis);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtJudul);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnHapus);
            this.Controls.Add(this.btnTambah);
            this.Controls.Add(this.dgvBuku);
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBuku)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudTotalHalaman)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudHalamanDibaca)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvBuku;
        private System.Windows.Forms.Button btnTambah;
        private System.Windows.Forms.Button btnHapus;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtJudul;
        private System.Windows.Forms.TextBox txtPenulis;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtBahasa;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown nudTotalHalaman;
        private System.Windows.Forms.NumericUpDown nudHalamanDibaca;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblTotalBuku;
        private System.Windows.Forms.Label lblTotalDibaca;
        private System.Windows.Forms.Label lblTotalBelumDibaca;
    }
}