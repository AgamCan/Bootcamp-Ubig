namespace MagangGoBig
{
    partial class FormMain
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
            this.components = new System.ComponentModel.Container();
            this.lblWaktu = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCari = new System.Windows.Forms.TextBox();
            this.dgvPeserta = new System.Windows.Forms.DataGridView();
            this.colDetail = new System.Windows.Forms.DataGridViewButtonColumn();
            this.colNilai = new System.Windows.Forms.DataGridViewButtonColumn();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.txtNamaLengkap = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnTambah = new System.Windows.Forms.Button();
            this.btnHapus = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.txtSekolah = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dtpTanggalLahir = new System.Windows.Forms.DateTimePicker();
            this.dtpAkhirMagang = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.dtpMasukMagang = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.idPesertaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.namaLengkapDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sekolahDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pesertaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPeserta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pesertaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // lblWaktu
            // 
            this.lblWaktu.AutoSize = true;
            this.lblWaktu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWaktu.Location = new System.Drawing.Point(12, 9);
            this.lblWaktu.Name = "lblWaktu";
            this.lblWaktu.Size = new System.Drawing.Size(24, 20);
            this.lblWaktu.TabIndex = 0;
            this.lblWaktu.Text = "...";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Cari :";
            // 
            // txtCari
            // 
            this.txtCari.Location = new System.Drawing.Point(73, 61);
            this.txtCari.Name = "txtCari";
            this.txtCari.Size = new System.Drawing.Size(243, 22);
            this.txtCari.TabIndex = 2;
            this.txtCari.TextChanged += new System.EventHandler(this.txtCari_TextChanged);
            // 
            // dgvPeserta
            // 
            this.dgvPeserta.AllowUserToAddRows = false;
            this.dgvPeserta.AllowUserToDeleteRows = false;
            this.dgvPeserta.AutoGenerateColumns = false;
            this.dgvPeserta.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPeserta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPeserta.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idPesertaDataGridViewTextBoxColumn,
            this.namaLengkapDataGridViewTextBoxColumn,
            this.sekolahDataGridViewTextBoxColumn,
            this.colDetail,
            this.colNilai});
            this.dgvPeserta.DataSource = this.pesertaBindingSource;
            this.dgvPeserta.Location = new System.Drawing.Point(16, 99);
            this.dgvPeserta.Name = "dgvPeserta";
            this.dgvPeserta.RowHeadersWidth = 51;
            this.dgvPeserta.RowTemplate.Height = 24;
            this.dgvPeserta.Size = new System.Drawing.Size(763, 235);
            this.dgvPeserta.TabIndex = 3;
            this.dgvPeserta.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPeserta_CellClick);
            this.dgvPeserta.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPeserta_CellContentClick);
            this.dgvPeserta.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvPeserta_CellFormatting);
            // 
            // colDetail
            // 
            this.colDetail.HeaderText = "";
            this.colDetail.MinimumWidth = 6;
            this.colDetail.Name = "colDetail";
            this.colDetail.Text = "Detail";
            this.colDetail.UseColumnTextForButtonValue = true;
            // 
            // colNilai
            // 
            this.colNilai.HeaderText = "";
            this.colNilai.MinimumWidth = 6;
            this.colNilai.Name = "colNilai";
            this.colNilai.Text = "Nilai";
            this.colNilai.UseColumnTextForButtonValue = true;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // txtNamaLengkap
            // 
            this.txtNamaLengkap.Location = new System.Drawing.Point(281, 340);
            this.txtNamaLengkap.Name = "txtNamaLengkap";
            this.txtNamaLengkap.Size = new System.Drawing.Size(262, 22);
            this.txtNamaLengkap.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(156, 343);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Nama Lengkap :";
            // 
            // btnTambah
            // 
            this.btnTambah.Location = new System.Drawing.Point(29, 340);
            this.btnTambah.Name = "btnTambah";
            this.btnTambah.Size = new System.Drawing.Size(103, 34);
            this.btnTambah.TabIndex = 6;
            this.btnTambah.Text = "Tambah";
            this.btnTambah.UseVisualStyleBackColor = true;
            this.btnTambah.Click += new System.EventHandler(this.btnTambah_Click);
            // 
            // btnHapus
            // 
            this.btnHapus.Location = new System.Drawing.Point(29, 380);
            this.btnHapus.Name = "btnHapus";
            this.btnHapus.Size = new System.Drawing.Size(103, 34);
            this.btnHapus.TabIndex = 7;
            this.btnHapus.Text = "Hapus";
            this.btnHapus.UseVisualStyleBackColor = true;
            this.btnHapus.Click += new System.EventHandler(this.btnHapus_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(29, 420);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(103, 34);
            this.btnEdit.TabIndex = 8;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // txtSekolah
            // 
            this.txtSekolah.Location = new System.Drawing.Point(281, 368);
            this.txtSekolah.Name = "txtSekolah";
            this.txtSekolah.Size = new System.Drawing.Size(262, 22);
            this.txtSekolah.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(156, 371);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 16);
            this.label3.TabIndex = 9;
            this.label3.Text = "Sekolah :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(156, 402);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 16);
            this.label4.TabIndex = 11;
            this.label4.Text = "Tanggal Lahir :";
            // 
            // dtpTanggalLahir
            // 
            this.dtpTanggalLahir.Location = new System.Drawing.Point(281, 399);
            this.dtpTanggalLahir.Name = "dtpTanggalLahir";
            this.dtpTanggalLahir.Size = new System.Drawing.Size(262, 22);
            this.dtpTanggalLahir.TabIndex = 12;
            // 
            // dtpAkhirMagang
            // 
            this.dtpAkhirMagang.Location = new System.Drawing.Point(281, 427);
            this.dtpAkhirMagang.Name = "dtpAkhirMagang";
            this.dtpAkhirMagang.Size = new System.Drawing.Size(262, 22);
            this.dtpAkhirMagang.TabIndex = 14;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(156, 430);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(96, 16);
            this.label5.TabIndex = 13;
            this.label5.Text = "Akhir Magang :";
            // 
            // dtpMasukMagang
            // 
            this.dtpMasukMagang.Location = new System.Drawing.Point(281, 455);
            this.dtpMasukMagang.Name = "dtpMasukMagang";
            this.dtpMasukMagang.Size = new System.Drawing.Size(262, 22);
            this.dtpMasukMagang.TabIndex = 16;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(156, 458);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(106, 16);
            this.label6.TabIndex = 15;
            this.label6.Text = "Masuk Magang :";
            // 
            // idPesertaDataGridViewTextBoxColumn
            // 
            this.idPesertaDataGridViewTextBoxColumn.DataPropertyName = "IdPeserta";
            this.idPesertaDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idPesertaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idPesertaDataGridViewTextBoxColumn.Name = "idPesertaDataGridViewTextBoxColumn";
            // 
            // namaLengkapDataGridViewTextBoxColumn
            // 
            this.namaLengkapDataGridViewTextBoxColumn.DataPropertyName = "NamaLengkap";
            this.namaLengkapDataGridViewTextBoxColumn.HeaderText = "NamaLengkap";
            this.namaLengkapDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.namaLengkapDataGridViewTextBoxColumn.Name = "namaLengkapDataGridViewTextBoxColumn";
            // 
            // sekolahDataGridViewTextBoxColumn
            // 
            this.sekolahDataGridViewTextBoxColumn.DataPropertyName = "Sekolah";
            this.sekolahDataGridViewTextBoxColumn.HeaderText = "Sekolah";
            this.sekolahDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.sekolahDataGridViewTextBoxColumn.Name = "sekolahDataGridViewTextBoxColumn";
            // 
            // pesertaBindingSource
            // 
            this.pesertaBindingSource.DataSource = typeof(MagangGoBig.Peserta);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(791, 525);
            this.Controls.Add(this.dtpMasukMagang);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dtpAkhirMagang);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dtpTanggalLahir);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtSekolah);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnHapus);
            this.Controls.Add(this.btnTambah);
            this.Controls.Add(this.txtNamaLengkap);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgvPeserta);
            this.Controls.Add(this.txtCari);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblWaktu);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormMain";
            this.Load += new System.EventHandler(this.FormMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPeserta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pesertaBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblWaktu;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCari;
        private System.Windows.Forms.DataGridView dgvPeserta;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.BindingSource pesertaBindingSource;
        private System.Windows.Forms.TextBox txtNamaLengkap;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnTambah;
        private System.Windows.Forms.Button btnHapus;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.TextBox txtSekolah;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtpTanggalLahir;
        private System.Windows.Forms.DateTimePicker dtpAkhirMagang;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dtpMasukMagang;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridViewTextBoxColumn idPesertaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn namaLengkapDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sekolahDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewButtonColumn colDetail;
        private System.Windows.Forms.DataGridViewButtonColumn colNilai;
    }
}