
namespace AGENDA_GURU
{
    partial class FormUser
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
            this.txtnamauser = new System.Windows.Forms.TextBox();
            this.txtusername = new System.Windows.Forms.TextBox();
            this.txtpassword = new System.Windows.Forms.TextBox();
            this.cmbrole = new System.Windows.Forms.ComboBox();
            this.dgvuser = new System.Windows.Forms.DataGridView();
            this.btnsimpan = new System.Windows.Forms.Button();
            this.btnubah = new System.Windows.Forms.Button();
            this.hapus = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnbatal = new System.Windows.Forms.Button();
            this.txtiduser = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvuser)).BeginInit();
            this.SuspendLayout();
            // 
            // txtnamauser
            // 
            this.txtnamauser.Location = new System.Drawing.Point(258, 60);
            this.txtnamauser.Margin = new System.Windows.Forms.Padding(2);
            this.txtnamauser.Name = "txtnamauser";
            this.txtnamauser.Size = new System.Drawing.Size(120, 20);
            this.txtnamauser.TabIndex = 0;
            // 
            // txtusername
            // 
            this.txtusername.Location = new System.Drawing.Point(258, 93);
            this.txtusername.Margin = new System.Windows.Forms.Padding(2);
            this.txtusername.Name = "txtusername";
            this.txtusername.Size = new System.Drawing.Size(120, 20);
            this.txtusername.TabIndex = 1;
            // 
            // txtpassword
            // 
            this.txtpassword.Location = new System.Drawing.Point(258, 117);
            this.txtpassword.Margin = new System.Windows.Forms.Padding(2);
            this.txtpassword.Name = "txtpassword";
            this.txtpassword.Size = new System.Drawing.Size(120, 20);
            this.txtpassword.TabIndex = 2;
            // 
            // cmbrole
            // 
            this.cmbrole.FormattingEnabled = true;
            this.cmbrole.Location = new System.Drawing.Point(258, 144);
            this.cmbrole.Margin = new System.Windows.Forms.Padding(2);
            this.cmbrole.Name = "cmbrole";
            this.cmbrole.Size = new System.Drawing.Size(120, 21);
            this.cmbrole.TabIndex = 3;
            // 
            // dgvuser
            // 
            this.dgvuser.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvuser.Location = new System.Drawing.Point(242, 178);
            this.dgvuser.Margin = new System.Windows.Forms.Padding(2);
            this.dgvuser.Name = "dgvuser";
            this.dgvuser.RowHeadersWidth = 62;
            this.dgvuser.RowTemplate.Height = 28;
            this.dgvuser.Size = new System.Drawing.Size(573, 257);
            this.dgvuser.TabIndex = 4;
          
            // 
            // btnsimpan
            // 
            this.btnsimpan.Location = new System.Drawing.Point(411, 119);
            this.btnsimpan.Margin = new System.Windows.Forms.Padding(2);
            this.btnsimpan.Name = "btnsimpan";
            this.btnsimpan.Size = new System.Drawing.Size(61, 23);
            this.btnsimpan.TabIndex = 5;
            this.btnsimpan.Text = "Simpan";
            this.btnsimpan.UseVisualStyleBackColor = true;
            
            // 
            // btnubah
            // 
            this.btnubah.Location = new System.Drawing.Point(492, 119);
            this.btnubah.Margin = new System.Windows.Forms.Padding(2);
            this.btnubah.Name = "btnubah";
            this.btnubah.Size = new System.Drawing.Size(61, 23);
            this.btnubah.TabIndex = 6;
            this.btnubah.Text = "Ubah";
            this.btnubah.UseVisualStyleBackColor = true;
            
            // 
            // hapus
            // 
            this.hapus.Location = new System.Drawing.Point(576, 119);
            this.hapus.Margin = new System.Windows.Forms.Padding(2);
            this.hapus.Name = "hapus";
            this.hapus.Size = new System.Drawing.Size(61, 23);
            this.hapus.TabIndex = 7;
            this.hapus.Text = "hapus";
            this.hapus.UseVisualStyleBackColor = true;
           
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(200, 60);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Nama";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(186, 93);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Username";
            
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(186, 119);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Password";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(200, 147);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Role";
            // 
            // btnbatal
            // 
            this.btnbatal.Location = new System.Drawing.Point(650, 120);
            this.btnbatal.Margin = new System.Windows.Forms.Padding(2);
            this.btnbatal.Name = "btnbatal";
            this.btnbatal.Size = new System.Drawing.Size(61, 23);
            this.btnbatal.TabIndex = 12;
            this.btnbatal.Text = "batal";
            this.btnbatal.UseVisualStyleBackColor = true;
           
            // 
            // txtiduser
            // 
            this.txtiduser.Location = new System.Drawing.Point(258, 27);
            this.txtiduser.Margin = new System.Windows.Forms.Padding(2);
            this.txtiduser.Name = "txtiduser";
            this.txtiduser.Size = new System.Drawing.Size(120, 20);
            this.txtiduser.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(206, 30);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(15, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "id";
            // 
            // FormUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(879, 473);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtiduser);
            this.Controls.Add(this.btnbatal);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.hapus);
            this.Controls.Add(this.btnubah);
            this.Controls.Add(this.btnsimpan);
            this.Controls.Add(this.dgvuser);
            this.Controls.Add(this.cmbrole);
            this.Controls.Add(this.txtpassword);
            this.Controls.Add(this.txtusername);
            this.Controls.Add(this.txtnamauser);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormUser";
            this.Text = "FormUser";
            ((System.ComponentModel.ISupportInitialize)(this.dgvuser)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtnamauser;
        private System.Windows.Forms.TextBox txtusername;
        private System.Windows.Forms.TextBox txtpassword;
        private System.Windows.Forms.ComboBox cmbrole;
        private System.Windows.Forms.DataGridView dgvuser;
        private System.Windows.Forms.Button btnsimpan;
        private System.Windows.Forms.Button btnubah;
        private System.Windows.Forms.Button hapus;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnbatal;
        private System.Windows.Forms.TextBox txtiduser;
        private System.Windows.Forms.Label label5;
    }
}