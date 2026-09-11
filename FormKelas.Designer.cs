
namespace AGENDA_GURU
{
    partial class FormKelas
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
            this.txtidkelas = new System.Windows.Forms.TextBox();
            this.txtnamakelas = new System.Windows.Forms.TextBox();
            this.btntambah = new System.Windows.Forms.Button();
            this.btnedit = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvkelas = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvkelas)).BeginInit();
            this.SuspendLayout();
            // 
            // txtidkelas
            // 
            this.txtidkelas.Location = new System.Drawing.Point(162, 50);
            this.txtidkelas.Name = "txtidkelas";
            this.txtidkelas.Size = new System.Drawing.Size(129, 20);
            this.txtidkelas.TabIndex = 0;
            // 
            // txtnamakelas
            // 
            this.txtnamakelas.Location = new System.Drawing.Point(162, 91);
            this.txtnamakelas.Name = "txtnamakelas";
            this.txtnamakelas.Size = new System.Drawing.Size(129, 20);
            this.txtnamakelas.TabIndex = 1;
            // 
            // btntambah
            // 
            this.btntambah.Location = new System.Drawing.Point(310, 88);
            this.btntambah.Name = "btntambah";
            this.btntambah.Size = new System.Drawing.Size(75, 23);
            this.btntambah.TabIndex = 2;
            this.btntambah.Text = "tambah";
            this.btntambah.UseVisualStyleBackColor = true;
            // 
            // btnedit
            // 
            this.btnedit.Location = new System.Drawing.Point(408, 89);
            this.btnedit.Name = "btnedit";
            this.btnedit.Size = new System.Drawing.Size(75, 23);
            this.btnedit.TabIndex = 3;
            this.btnedit.Text = "edit";
            this.btnedit.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(503, 89);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 4;
            this.button3.Text = "hapus";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(106, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "id kelas";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(88, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "nama kelas";
            // 
            // dgvkelas
            // 
            this.dgvkelas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvkelas.Location = new System.Drawing.Point(51, 149);
            this.dgvkelas.Name = "dgvkelas";
            this.dgvkelas.Size = new System.Drawing.Size(697, 200);
            this.dgvkelas.TabIndex = 7;
            // 
            // FormKelas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgvkelas);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.btnedit);
            this.Controls.Add(this.btntambah);
            this.Controls.Add(this.txtnamakelas);
            this.Controls.Add(this.txtidkelas);
            this.Name = "FormKelas";
            this.Text = "FormKelas";
            ((System.ComponentModel.ISupportInitialize)(this.dgvkelas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtidkelas;
        private System.Windows.Forms.TextBox txtnamakelas;
        private System.Windows.Forms.Button btntambah;
        private System.Windows.Forms.Button btnedit;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvkelas;
    }
}