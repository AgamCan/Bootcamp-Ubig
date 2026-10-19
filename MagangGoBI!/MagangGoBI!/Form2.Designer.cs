namespace MagangGoBI_
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.pesertaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.dateTimePicker3 = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.timerWaktu_Tick = new System.Windows.Forms.Timer(this.components);
            this.idPesertaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.namaLengkapDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tanggalLahirDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sekolahDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.masukMagangDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.akhirMagangDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idNilaiPesertaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nilaiPesertaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DetailCol = new System.Windows.Forms.DataGridViewButtonColumn();
            this.NilaiCol = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pesertaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "label1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Cari :";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(72, 59);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(300, 22);
            this.textBox1.TabIndex = 2;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idPesertaDataGridViewTextBoxColumn,
            this.namaLengkapDataGridViewTextBoxColumn,
            this.tanggalLahirDataGridViewTextBoxColumn,
            this.sekolahDataGridViewTextBoxColumn,
            this.masukMagangDataGridViewTextBoxColumn,
            this.akhirMagangDataGridViewTextBoxColumn,
            this.idNilaiPesertaDataGridViewTextBoxColumn,
            this.nilaiPesertaDataGridViewTextBoxColumn,
            this.DetailCol,
            this.NilaiCol});
            this.dataGridView1.DataSource = this.pesertaBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(15, 87);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(731, 206);
            this.dataGridView1.TabIndex = 3;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // pesertaBindingSource
            // 
            this.pesertaBindingSource.DataSource = typeof(MagangGoBI_.Peserta);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(15, 299);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(104, 37);
            this.button1.TabIndex = 4;
            this.button1.Text = "Tambah";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(15, 342);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(104, 37);
            this.button2.TabIndex = 5;
            this.button2.Text = "Hapus";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(15, 385);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(104, 37);
            this.button3.TabIndex = 6;
            this.button3.Text = "Edit";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(152, 311);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 16);
            this.label3.TabIndex = 7;
            this.label3.Text = "Nama Lengkap :";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(298, 309);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(313, 22);
            this.textBox2.TabIndex = 8;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(298, 337);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(313, 22);
            this.textBox3.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(152, 339);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 16);
            this.label4.TabIndex = 9;
            this.label4.Text = "Sekolah :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(152, 373);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(96, 16);
            this.label5.TabIndex = 11;
            this.label5.Text = "Tanggal Lahir :";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(298, 373);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(313, 22);
            this.dateTimePicker1.TabIndex = 12;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(298, 401);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(313, 22);
            this.dateTimePicker2.TabIndex = 14;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(152, 401);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(96, 16);
            this.label6.TabIndex = 13;
            this.label6.Text = "Akhir Magang :";
            // 
            // dateTimePicker3
            // 
            this.dateTimePicker3.Location = new System.Drawing.Point(298, 429);
            this.dateTimePicker3.Name = "dateTimePicker3";
            this.dateTimePicker3.Size = new System.Drawing.Size(313, 22);
            this.dateTimePicker3.TabIndex = 16;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(152, 429);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(100, 16);
            this.label7.TabIndex = 15;
            this.label7.Text = "Masuk Magang";
            // 
            // timerWaktu_Tick
            // 
            this.timerWaktu_Tick.Interval = 1000;
            this.timerWaktu_Tick.Tick += new System.EventHandler(this.timerWaktu_Tick_Tick);
            // 
            // idPesertaDataGridViewTextBoxColumn
            // 
            this.idPesertaDataGridViewTextBoxColumn.DataPropertyName = "IdPeserta";
            this.idPesertaDataGridViewTextBoxColumn.HeaderText = "ID";
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
            // tanggalLahirDataGridViewTextBoxColumn
            // 
            this.tanggalLahirDataGridViewTextBoxColumn.DataPropertyName = "TanggalLahir";
            this.tanggalLahirDataGridViewTextBoxColumn.HeaderText = "TanggalLahir";
            this.tanggalLahirDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.tanggalLahirDataGridViewTextBoxColumn.Name = "tanggalLahirDataGridViewTextBoxColumn";
            this.tanggalLahirDataGridViewTextBoxColumn.Visible = false;
            // 
            // sekolahDataGridViewTextBoxColumn
            // 
            this.sekolahDataGridViewTextBoxColumn.DataPropertyName = "Sekolah";
            this.sekolahDataGridViewTextBoxColumn.HeaderText = "Sekolah";
            this.sekolahDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.sekolahDataGridViewTextBoxColumn.Name = "sekolahDataGridViewTextBoxColumn";
            // 
            // masukMagangDataGridViewTextBoxColumn
            // 
            this.masukMagangDataGridViewTextBoxColumn.DataPropertyName = "MasukMagang";
            this.masukMagangDataGridViewTextBoxColumn.HeaderText = "MasukMagang";
            this.masukMagangDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.masukMagangDataGridViewTextBoxColumn.Name = "masukMagangDataGridViewTextBoxColumn";
            this.masukMagangDataGridViewTextBoxColumn.Visible = false;
            // 
            // akhirMagangDataGridViewTextBoxColumn
            // 
            this.akhirMagangDataGridViewTextBoxColumn.DataPropertyName = "AkhirMagang";
            this.akhirMagangDataGridViewTextBoxColumn.HeaderText = "AkhirMagang";
            this.akhirMagangDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.akhirMagangDataGridViewTextBoxColumn.Name = "akhirMagangDataGridViewTextBoxColumn";
            this.akhirMagangDataGridViewTextBoxColumn.Visible = false;
            // 
            // idNilaiPesertaDataGridViewTextBoxColumn
            // 
            this.idNilaiPesertaDataGridViewTextBoxColumn.DataPropertyName = "IdNilaiPeserta";
            this.idNilaiPesertaDataGridViewTextBoxColumn.HeaderText = "IdNilaiPeserta";
            this.idNilaiPesertaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idNilaiPesertaDataGridViewTextBoxColumn.Name = "idNilaiPesertaDataGridViewTextBoxColumn";
            this.idNilaiPesertaDataGridViewTextBoxColumn.Visible = false;
            // 
            // nilaiPesertaDataGridViewTextBoxColumn
            // 
            this.nilaiPesertaDataGridViewTextBoxColumn.DataPropertyName = "NilaiPeserta";
            this.nilaiPesertaDataGridViewTextBoxColumn.HeaderText = "NilaiPeserta";
            this.nilaiPesertaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nilaiPesertaDataGridViewTextBoxColumn.Name = "nilaiPesertaDataGridViewTextBoxColumn";
            this.nilaiPesertaDataGridViewTextBoxColumn.Visible = false;
            // 
            // DetailCol
            // 
            this.DetailCol.DataPropertyName = "IdPeserta";
            this.DetailCol.HeaderText = "";
            this.DetailCol.MinimumWidth = 6;
            this.DetailCol.Name = "DetailCol";
            this.DetailCol.Text = "Detail";
            this.DetailCol.UseColumnTextForButtonValue = true;
            // 
            // NilaiCol
            // 
            this.NilaiCol.DataPropertyName = "IdPeserta";
            this.NilaiCol.HeaderText = "";
            this.NilaiCol.MinimumWidth = 6;
            this.NilaiCol.Name = "NilaiCol";
            this.NilaiCol.Text = "Nilai";
            this.NilaiCol.UseColumnTextForButtonValue = true;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(758, 566);
            this.Controls.Add(this.dateTimePicker3);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main Form | MagangGoBig!";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pesertaBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.BindingSource pesertaBindingSource;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dateTimePicker3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Timer timerWaktu_Tick;
        private System.Windows.Forms.DataGridViewTextBoxColumn idPesertaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn namaLengkapDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tanggalLahirDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sekolahDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn masukMagangDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn akhirMagangDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idNilaiPesertaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nilaiPesertaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewButtonColumn DetailCol;
        private System.Windows.Forms.DataGridViewButtonColumn NilaiCol;
    }
}