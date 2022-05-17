
namespace _6SigmaYazilimYapimi
{
    partial class frmAdmin
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtKullaniciAdiA = new System.Windows.Forms.TextBox();
            this.txtSifreA = new System.Windows.Forms.TextBox();
            this.btnGirisA = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(101, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kullanıcı Adı ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(101, 116);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Şifre";
            // 
            // txtKullaniciAdiA
            // 
            this.txtKullaniciAdiA.Location = new System.Drawing.Point(244, 48);
            this.txtKullaniciAdiA.Name = "txtKullaniciAdiA";
            this.txtKullaniciAdiA.Size = new System.Drawing.Size(135, 20);
            this.txtKullaniciAdiA.TabIndex = 2;
            // 
            // txtSifreA
            // 
            this.txtSifreA.Location = new System.Drawing.Point(244, 113);
            this.txtSifreA.Name = "txtSifreA";
            this.txtSifreA.Size = new System.Drawing.Size(135, 20);
            this.txtSifreA.TabIndex = 3;
            // 
            // btnGirisA
            // 
            this.btnGirisA.Location = new System.Drawing.Point(244, 168);
            this.btnGirisA.Name = "btnGirisA";
            this.btnGirisA.Size = new System.Drawing.Size(135, 23);
            this.btnGirisA.TabIndex = 4;
            this.btnGirisA.Text = "Giriş";
            this.btnGirisA.UseVisualStyleBackColor = true;
            this.btnGirisA.Click += new System.EventHandler(this.btnGirisA_Click);
            // 
            // frmAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(482, 243);
            this.Controls.Add(this.btnGirisA);
            this.Controls.Add(this.txtSifreA);
            this.Controls.Add(this.txtKullaniciAdiA);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmAdmin";
            this.Text = "Admin";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtKullaniciAdiA;
        private System.Windows.Forms.TextBox txtSifreA;
        private System.Windows.Forms.Button btnGirisA;
    }
}