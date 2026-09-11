
namespace AGENDA_GURU
{
    partial class FormAgenda
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
            this.txtIdAgenda = new System.Windows.Forms.TextBox();
            this.dtpTanggal = new System.Windows.Forms.DateTimePicker();
            this.dtpJamMulai = new System.Windows.Forms.DateTimePicker();
            this.dtpJamSelesai = new System.Windows.Forms.DateTimePicker();
            this.cmbGuru = new System.Windows.Forms.ComboBox();
            this.txtMateri = new System.Windows.Forms.TextBox();
            this.cmbKelas = new System.Windows.Forms.ComboBox();
            this.txtKegiatan = new System.Windows.Forms.TextBox();
            this.txtTugas = new System.Windows.Forms.TextBox();
            this.txtKeterangan = new System.Windows.Forms.TextBox();
            this.cmbStatus = new System.Windows.Forms.ComboBox();
            this.btnTambah = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnHapus = new System.Windows.Forms.Button();
            this.btnBatal = new System.Windows.Forms.Button();
            this.dgvAgenda = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAgenda)).BeginInit();
            this.SuspendLayout();
            // 
            // txtIdAgenda
            // 
            this.txtIdAgenda.Location = new System.Drawing.Point(12, 31);
            this.txtIdAgenda.Name = "txtIdAgenda";
            this.txtIdAgenda.Size = new System.Drawing.Size(100, 20);
            this.txtIdAgenda.TabIndex = 0;
            // 
            // dtpTanggal
            // 
            this.dtpTanggal.Location = new System.Drawing.Point(141, 31);
            this.dtpTanggal.Name = "dtpTanggal";
            this.dtpTanggal.Size = new System.Drawing.Size(200, 20);
            this.dtpTanggal.TabIndex = 1;
            // 
            // dtpJamMulai
            // 
            this.dtpJamMulai.Location = new System.Drawing.Point(141, 84);
            this.dtpJamMulai.Name = "dtpJamMulai";
            this.dtpJamMulai.Size = new System.Drawing.Size(200, 20);
            this.dtpJamMulai.TabIndex = 2;
            // 
            // dtpJamSelesai
            // 
            this.dtpJamSelesai.Location = new System.Drawing.Point(141, 137);
            this.dtpJamSelesai.Name = "dtpJamSelesai";
            this.dtpJamSelesai.Size = new System.Drawing.Size(200, 20);
            this.dtpJamSelesai.TabIndex = 3;
            // 
            // cmbGuru
            // 
            this.cmbGuru.FormattingEnabled = true;
            this.cmbGuru.Location = new System.Drawing.Point(347, 31);
            this.cmbGuru.Name = "cmbGuru";
            this.cmbGuru.Size = new System.Drawing.Size(110, 21);
            this.cmbGuru.TabIndex = 4;
            // 
            // txtMateri
            // 
            this.txtMateri.Location = new System.Drawing.Point(473, 31);
            this.txtMateri.Name = "txtMateri";
            this.txtMateri.Size = new System.Drawing.Size(108, 20);
            this.txtMateri.TabIndex = 6;
            // 
            // cmbKelas
            // 
            this.cmbKelas.FormattingEnabled = true;
            this.cmbKelas.Location = new System.Drawing.Point(347, 83);
            this.cmbKelas.Name = "cmbKelas";
            this.cmbKelas.Size = new System.Drawing.Size(110, 21);
            this.cmbKelas.TabIndex = 7;
            // 
            // txtKegiatan
            // 
            this.txtKegiatan.Location = new System.Drawing.Point(473, 83);
            this.txtKegiatan.Name = "txtKegiatan";
            this.txtKegiatan.Size = new System.Drawing.Size(108, 20);
            this.txtKegiatan.TabIndex = 8;
            // 
            // txtTugas
            // 
            this.txtTugas.Location = new System.Drawing.Point(473, 137);
            this.txtTugas.Name = "txtTugas";
            this.txtTugas.Size = new System.Drawing.Size(108, 20);
            this.txtTugas.TabIndex = 9;
            // 
            // txtKeterangan
            // 
            this.txtKeterangan.Location = new System.Drawing.Point(473, 184);
            this.txtKeterangan.Name = "txtKeterangan";
            this.txtKeterangan.Size = new System.Drawing.Size(108, 20);
            this.txtKeterangan.TabIndex = 10;
            // 
            // cmbStatus
            // 
            this.cmbStatus.FormattingEnabled = true;
            this.cmbStatus.Location = new System.Drawing.Point(602, 30);
            this.cmbStatus.Name = "cmbStatus";
            this.cmbStatus.Size = new System.Drawing.Size(110, 21);
            this.cmbStatus.TabIndex = 11;
            // 
            // btnTambah
            // 
            this.btnTambah.Location = new System.Drawing.Point(602, 80);
            this.btnTambah.Name = "btnTambah";
            this.btnTambah.Size = new System.Drawing.Size(75, 23);
            this.btnTambah.TabIndex = 12;
            this.btnTambah.Text = "button1";
            this.btnTambah.UseVisualStyleBackColor = true;
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(602, 109);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(75, 23);
            this.btnEdit.TabIndex = 13;
            this.btnEdit.Text = "edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            // 
            // btnHapus
            // 
            this.btnHapus.Location = new System.Drawing.Point(602, 138);
            this.btnHapus.Name = "btnHapus";
            this.btnHapus.Size = new System.Drawing.Size(75, 23);
            this.btnHapus.TabIndex = 14;
            this.btnHapus.Text = "hapus";
            this.btnHapus.UseVisualStyleBackColor = true;
            // 
            // btnBatal
            // 
            this.btnBatal.Location = new System.Drawing.Point(602, 167);
            this.btnBatal.Name = "btnBatal";
            this.btnBatal.Size = new System.Drawing.Size(75, 23);
            this.btnBatal.TabIndex = 15;
            this.btnBatal.Text = "batal";
            this.btnBatal.UseVisualStyleBackColor = true;
            // 
            // dgvAgenda
            // 
            this.dgvAgenda.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAgenda.Location = new System.Drawing.Point(47, 210);
            this.dgvAgenda.Name = "dgvAgenda";
            this.dgvAgenda.Size = new System.Drawing.Size(665, 274);
            this.dgvAgenda.TabIndex = 17;
            // 
            // FormAgenda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(814, 492);
            this.Controls.Add(this.dgvAgenda);
            this.Controls.Add(this.btnBatal);
            this.Controls.Add(this.btnHapus);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnTambah);
            this.Controls.Add(this.cmbStatus);
            this.Controls.Add(this.txtKeterangan);
            this.Controls.Add(this.txtTugas);
            this.Controls.Add(this.txtKegiatan);
            this.Controls.Add(this.cmbKelas);
            this.Controls.Add(this.txtMateri);
            this.Controls.Add(this.cmbGuru);
            this.Controls.Add(this.dtpJamSelesai);
            this.Controls.Add(this.dtpJamMulai);
            this.Controls.Add(this.dtpTanggal);
            this.Controls.Add(this.txtIdAgenda);
            this.Name = "FormAgenda";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dgvAgenda)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtIdAgenda;
        private System.Windows.Forms.DateTimePicker dtpTanggal;
        private System.Windows.Forms.DateTimePicker dtpJamMulai;
        private System.Windows.Forms.DateTimePicker dtpJamSelesai;
        private System.Windows.Forms.ComboBox cmbGuru;
        private System.Windows.Forms.TextBox txtMateri;
        private System.Windows.Forms.ComboBox cmbKelas;
        private System.Windows.Forms.TextBox txtKegiatan;
        private System.Windows.Forms.TextBox txtTugas;
        private System.Windows.Forms.TextBox txtKeterangan;
        private System.Windows.Forms.ComboBox cmbStatus;
        private System.Windows.Forms.Button btnTambah;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnHapus;
        private System.Windows.Forms.Button btnBatal;
        private System.Windows.Forms.DataGridView dgvAgenda;
    }
}