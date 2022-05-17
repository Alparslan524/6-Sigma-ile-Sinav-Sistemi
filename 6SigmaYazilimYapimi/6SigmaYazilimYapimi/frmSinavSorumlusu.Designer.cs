
namespace _6SigmaYazilimYapimi
{
    partial class frmSinavSorumlusu
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
            this.btnGirisSS = new System.Windows.Forms.Button();
            this.txtSifreSS = new System.Windows.Forms.TextBox();
            this.txtKullaniciAdiSS = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnGirisSS
            // 
            this.btnGirisSS.Location = new System.Drawing.Point(218, 176);
            this.btnGirisSS.Name = "btnGirisSS";
            this.btnGirisSS.Size = new System.Drawing.Size(135, 23);
            this.btnGirisSS.TabIndex = 9;
            this.btnGirisSS.Text = "Giriş";
            this.btnGirisSS.UseVisualStyleBackColor = true;
            this.btnGirisSS.Click += new System.EventHandler(this.btnGirisSS_Click);
            // 
            // txtSifreSS
            // 
            this.txtSifreSS.Location = new System.Drawing.Point(218, 121);
            this.txtSifreSS.Name = "txtSifreSS";
            this.txtSifreSS.Size = new System.Drawing.Size(135, 20);
            this.txtSifreSS.TabIndex = 8;
            // 
            // txtKullaniciAdiSS
            // 
            this.txtKullaniciAdiSS.Location = new System.Drawing.Point(218, 56);
            this.txtKullaniciAdiSS.Name = "txtKullaniciAdiSS";
            this.txtKullaniciAdiSS.Size = new System.Drawing.Size(135, 20);
            this.txtKullaniciAdiSS.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(75, 124);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Şifre";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(75, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Kullanıcı Adı ";
            // 
            // frmSinavSorumlusu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(422, 239);
            this.Controls.Add(this.btnGirisSS);
            this.Controls.Add(this.txtSifreSS);
            this.Controls.Add(this.txtKullaniciAdiSS);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmSinavSorumlusu";
            this.Text = "Sınav Sorumlusu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGirisSS;
        private System.Windows.Forms.TextBox txtSifreSS;
        private System.Windows.Forms.TextBox txtKullaniciAdiSS;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}