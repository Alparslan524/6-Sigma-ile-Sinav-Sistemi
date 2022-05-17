
namespace _6SigmaYazilimYapimi
{
    partial class frmOgrenci
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
            this.btnGirisO = new System.Windows.Forms.Button();
            this.txtSifreO = new System.Windows.Forms.TextBox();
            this.txtKullaniciAdiO = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnGirisO
            // 
            this.btnGirisO.Location = new System.Drawing.Point(261, 179);
            this.btnGirisO.Name = "btnGirisO";
            this.btnGirisO.Size = new System.Drawing.Size(135, 23);
            this.btnGirisO.TabIndex = 14;
            this.btnGirisO.Text = "Giriş";
            this.btnGirisO.UseVisualStyleBackColor = true;
            this.btnGirisO.Click += new System.EventHandler(this.btnGirisO_Click);
            // 
            // txtSifreO
            // 
            this.txtSifreO.Location = new System.Drawing.Point(261, 124);
            this.txtSifreO.Name = "txtSifreO";
            this.txtSifreO.Size = new System.Drawing.Size(135, 20);
            this.txtSifreO.TabIndex = 13;
            // 
            // txtKullaniciAdiO
            // 
            this.txtKullaniciAdiO.Location = new System.Drawing.Point(261, 59);
            this.txtKullaniciAdiO.Name = "txtKullaniciAdiO";
            this.txtKullaniciAdiO.Size = new System.Drawing.Size(135, 20);
            this.txtKullaniciAdiO.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(118, 127);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Şifre";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(118, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Kullanıcı Adı ";
            // 
            // frmOgrenci
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(514, 260);
            this.Controls.Add(this.btnGirisO);
            this.Controls.Add(this.txtSifreO);
            this.Controls.Add(this.txtKullaniciAdiO);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmOgrenci";
            this.Text = "Öğrenci";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGirisO;
        private System.Windows.Forms.TextBox txtSifreO;
        private System.Windows.Forms.TextBox txtKullaniciAdiO;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}