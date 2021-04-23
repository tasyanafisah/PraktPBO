
namespace Apotek_PBO
{
    partial class FormInformasiObat
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
            this.btnTambahObat = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnTambahObat
            // 
            this.btnTambahObat.Location = new System.Drawing.Point(301, 377);
            this.btnTambahObat.Name = "btnTambahObat";
            this.btnTambahObat.Size = new System.Drawing.Size(111, 32);
            this.btnTambahObat.TabIndex = 0;
            this.btnTambahObat.Text = "Tambah Obat";
            this.btnTambahObat.UseVisualStyleBackColor = true;
            this.btnTambahObat.Click += new System.EventHandler(this.btnTambahObat_Click);
            // 
            // FormInformasiObat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnTambahObat);
            this.Name = "FormInformasiObat";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.FormInformasiObat_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnTambahObat;
    }
}