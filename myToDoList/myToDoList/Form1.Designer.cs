namespace myToDoList
{
    partial class Form1
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
            this.dgvTugas = new System.Windows.Forms.DataGridView();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.namaTugasDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.selesaiDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.tugasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnTambah = new System.Windows.Forms.Button();
            this.txtTugas = new System.Windows.Forms.TextBox();
            this.btnSelesai = new System.Windows.Forms.Button();
            this.btnHapus = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTugas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tugasBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(332, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(146, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "My To Do List";
            // 
            // dgvTugas
            // 
            this.dgvTugas.AllowUserToAddRows = false;
            this.dgvTugas.AllowUserToDeleteRows = false;
            this.dgvTugas.AutoGenerateColumns = false;
            this.dgvTugas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTugas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.namaTugasDataGridViewTextBoxColumn,
            this.selesaiDataGridViewCheckBoxColumn});
            this.dgvTugas.DataSource = this.tugasBindingSource;
            this.dgvTugas.Location = new System.Drawing.Point(12, 53);
            this.dgvTugas.MultiSelect = false;
            this.dgvTugas.Name = "dgvTugas";
            this.dgvTugas.ReadOnly = true;
            this.dgvTugas.RowHeadersWidth = 51;
            this.dgvTugas.RowTemplate.Height = 24;
            this.dgvTugas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTugas.Size = new System.Drawing.Size(776, 219);
            this.dgvTugas.TabIndex = 1;
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            this.iDDataGridViewTextBoxColumn.ReadOnly = true;
            this.iDDataGridViewTextBoxColumn.Visible = false;
            this.iDDataGridViewTextBoxColumn.Width = 125;
            // 
            // namaTugasDataGridViewTextBoxColumn
            // 
            this.namaTugasDataGridViewTextBoxColumn.DataPropertyName = "NamaTugas";
            this.namaTugasDataGridViewTextBoxColumn.HeaderText = "NamaTugas";
            this.namaTugasDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.namaTugasDataGridViewTextBoxColumn.Name = "namaTugasDataGridViewTextBoxColumn";
            this.namaTugasDataGridViewTextBoxColumn.ReadOnly = true;
            this.namaTugasDataGridViewTextBoxColumn.Width = 125;
            // 
            // selesaiDataGridViewCheckBoxColumn
            // 
            this.selesaiDataGridViewCheckBoxColumn.DataPropertyName = "Selesai";
            this.selesaiDataGridViewCheckBoxColumn.HeaderText = "Selesai";
            this.selesaiDataGridViewCheckBoxColumn.MinimumWidth = 6;
            this.selesaiDataGridViewCheckBoxColumn.Name = "selesaiDataGridViewCheckBoxColumn";
            this.selesaiDataGridViewCheckBoxColumn.ReadOnly = true;
            this.selesaiDataGridViewCheckBoxColumn.Width = 125;
            // 
            // tugasBindingSource
            // 
            this.tugasBindingSource.DataSource = typeof(myToDoList.Tugas);
            // 
            // btnTambah
            // 
            this.btnTambah.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTambah.Location = new System.Drawing.Point(12, 278);
            this.btnTambah.Name = "btnTambah";
            this.btnTambah.Size = new System.Drawing.Size(134, 30);
            this.btnTambah.TabIndex = 2;
            this.btnTambah.Text = "Tambah";
            this.btnTambah.UseVisualStyleBackColor = true;
            this.btnTambah.Click += new System.EventHandler(this.btnTambah_Click);
            // 
            // txtTugas
            // 
            this.txtTugas.Location = new System.Drawing.Point(161, 283);
            this.txtTugas.Name = "txtTugas";
            this.txtTugas.Size = new System.Drawing.Size(627, 22);
            this.txtTugas.TabIndex = 3;
            // 
            // btnSelesai
            // 
            this.btnSelesai.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSelesai.Location = new System.Drawing.Point(12, 314);
            this.btnSelesai.Name = "btnSelesai";
            this.btnSelesai.Size = new System.Drawing.Size(776, 48);
            this.btnSelesai.TabIndex = 4;
            this.btnSelesai.Text = "Selesai";
            this.btnSelesai.UseVisualStyleBackColor = true;
            this.btnSelesai.Click += new System.EventHandler(this.btnSelesai_Click);
            // 
            // btnHapus
            // 
            this.btnHapus.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHapus.Location = new System.Drawing.Point(12, 368);
            this.btnHapus.Name = "btnHapus";
            this.btnHapus.Size = new System.Drawing.Size(776, 48);
            this.btnHapus.TabIndex = 5;
            this.btnHapus.Text = "Hapus";
            this.btnHapus.UseVisualStyleBackColor = true;
            this.btnHapus.Click += new System.EventHandler(this.btnHapus_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 426);
            this.Controls.Add(this.btnHapus);
            this.Controls.Add(this.btnSelesai);
            this.Controls.Add(this.txtTugas);
            this.Controls.Add(this.btnTambah);
            this.Controls.Add(this.dgvTugas);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormListTugas";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTugas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tugasBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvTugas;
        private System.Windows.Forms.Button btnTambah;
        private System.Windows.Forms.TextBox txtTugas;
        private System.Windows.Forms.Button btnSelesai;
        private System.Windows.Forms.Button btnHapus;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn namaTugasDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn selesaiDataGridViewCheckBoxColumn;
        private System.Windows.Forms.BindingSource tugasBindingSource;
    }
}

