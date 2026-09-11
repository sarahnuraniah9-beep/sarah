
namespace AGENDA_GURU
{
    partial class FormRole
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
            this.txtnamarole = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvrole = new System.Windows.Forms.DataGridView();
            this.btnsimpan = new System.Windows.Forms.Button();
            this.btnubah = new System.Windows.Forms.Button();
            this.btnhapus = new System.Windows.Forms.Button();
            this.txtidrole = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnbatal = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvrole)).BeginInit();
            this.SuspendLayout();
            // 
            // txtnamarole
            // 
            this.txtnamarole.Location = new System.Drawing.Point(271, 60);
            this.txtnamarole.Margin = new System.Windows.Forms.Padding(2);
            this.txtnamarole.Name = "txtnamarole";
            this.txtnamarole.Size = new System.Drawing.Size(134, 20);
            this.txtnamarole.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(207, 63);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nama Role";
            // 
            // dgvrole
            // 
            this.dgvrole.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvrole.Location = new System.Drawing.Point(271, 96);
            this.dgvrole.Margin = new System.Windows.Forms.Padding(2);
            this.dgvrole.Name = "dgvrole";
            this.dgvrole.RowHeadersWidth = 62;
            this.dgvrole.RowTemplate.Height = 28;
            this.dgvrole.Size = new System.Drawing.Size(573, 256);
            this.dgvrole.TabIndex = 2;
           
            // 
            // btnsimpan
            // 
            this.btnsimpan.Location = new System.Drawing.Point(417, 60);
            this.btnsimpan.Margin = new System.Windows.Forms.Padding(2);
            this.btnsimpan.Name = "btnsimpan";
            this.btnsimpan.Size = new System.Drawing.Size(76, 26);
            this.btnsimpan.TabIndex = 3;
            this.btnsimpan.Text = "simpan";
            this.btnsimpan.UseVisualStyleBackColor = true;
           
            // 
            // btnubah
            // 
            this.btnubah.Location = new System.Drawing.Point(505, 60);
            this.btnubah.Margin = new System.Windows.Forms.Padding(2);
            this.btnubah.Name = "btnubah";
            this.btnubah.Size = new System.Drawing.Size(76, 26);
            this.btnubah.TabIndex = 4;
            this.btnubah.Text = "ubah";
            this.btnubah.UseVisualStyleBackColor = true;
            
            // 
            // btnhapus
            // 
            this.btnhapus.Location = new System.Drawing.Point(595, 60);
            this.btnhapus.Margin = new System.Windows.Forms.Padding(2);
            this.btnhapus.Name = "btnhapus";
            this.btnhapus.Size = new System.Drawing.Size(76, 26);
            this.btnhapus.TabIndex = 5;
            this.btnhapus.Text = "hapus";
            this.btnhapus.UseVisualStyleBackColor = true;
            

            // 
            // txtidrole
            // 
            this.txtidrole.Location = new System.Drawing.Point(271, 36);
            this.txtidrole.Margin = new System.Windows.Forms.Padding(2);
            this.txtidrole.Name = "txtidrole";
            this.txtidrole.Size = new System.Drawing.Size(134, 20);
            this.txtidrole.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(207, 39);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "ID Role";
            // 
            // btnbatal
            // 
            this.btnbatal.Location = new System.Drawing.Point(675, 60);
            this.btnbatal.Margin = new System.Windows.Forms.Padding(2);
            this.btnbatal.Name = "btnbatal";
            this.btnbatal.Size = new System.Drawing.Size(76, 26);
            this.btnbatal.TabIndex = 8;
            this.btnbatal.Text = "batal";
            this.btnbatal.UseVisualStyleBackColor = true;
            // 
            // FormRole
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(885, 382);
            this.Controls.Add(this.btnbatal);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtidrole);
            this.Controls.Add(this.btnhapus);
            this.Controls.Add(this.btnubah);
            this.Controls.Add(this.btnsimpan);
            this.Controls.Add(this.dgvrole);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtnamarole);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormRole";
            this.Text = "FormRole";
            ((System.ComponentModel.ISupportInitialize)(this.dgvrole)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtnamarole;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvrole;
        private System.Windows.Forms.Button btnsimpan;
        private System.Windows.Forms.Button btnubah;
        private System.Windows.Forms.Button btnhapus;
        private System.Windows.Forms.TextBox txtidrole;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnbatal;
    }
}