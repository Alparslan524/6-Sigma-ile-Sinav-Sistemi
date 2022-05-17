
namespace _6SigmaYazilimYapimi
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnAdmin = new System.Windows.Forms.Button();
            this.btnSinavSorumlusu = new System.Windows.Forms.Button();
            this.btnOgrenci = new System.Windows.Forms.Button();
            this.btnYeniKayit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnAdmin
            // 
            this.btnAdmin.Location = new System.Drawing.Point(43, 84);
            this.btnAdmin.Name = "btnAdmin";
            this.btnAdmin.Size = new System.Drawing.Size(160, 99);
            this.btnAdmin.TabIndex = 0;
            this.btnAdmin.Text = "Admin";
            this.btnAdmin.UseVisualStyleBackColor = true;
            this.btnAdmin.Click += new System.EventHandler(this.btnAdmin_Click);
            // 
            // btnSinavSorumlusu
            // 
            this.btnSinavSorumlusu.Location = new System.Drawing.Point(237, 84);
            this.btnSinavSorumlusu.Name = "btnSinavSorumlusu";
            this.btnSinavSorumlusu.Size = new System.Drawing.Size(160, 99);
            this.btnSinavSorumlusu.TabIndex = 1;
            this.btnSinavSorumlusu.Text = "Sınav Sorumlusu";
            this.btnSinavSorumlusu.UseVisualStyleBackColor = true;
            this.btnSinavSorumlusu.Click += new System.EventHandler(this.btnSinavSorumlusu_Click);
            // 
            // btnOgrenci
            // 
            this.btnOgrenci.Location = new System.Drawing.Point(427, 84);
            this.btnOgrenci.Name = "btnOgrenci";
            this.btnOgrenci.Size = new System.Drawing.Size(160, 99);
            this.btnOgrenci.TabIndex = 2;
            this.btnOgrenci.Text = "Öğrenci";
            this.btnOgrenci.UseVisualStyleBackColor = true;
            this.btnOgrenci.Click += new System.EventHandler(this.btnOgrenci_Click);
            // 
            // btnYeniKayit
            // 
            this.btnYeniKayit.Location = new System.Drawing.Point(635, 84);
            this.btnYeniKayit.Name = "btnYeniKayit";
            this.btnYeniKayit.Size = new System.Drawing.Size(160, 99);
            this.btnYeniKayit.TabIndex = 3;
            this.btnYeniKayit.Text = "Yeni Kayıt Yap";
            this.btnYeniKayit.UseVisualStyleBackColor = true;
            this.btnYeniKayit.Click += new System.EventHandler(this.btnYeniKayit_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(280, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(237, 31);
            this.label1.TabIndex = 4;
            this.label1.Text = "Giriş Tipini Seçiniz";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(819, 231);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnYeniKayit);
            this.Controls.Add(this.btnOgrenci);
            this.Controls.Add(this.btnSinavSorumlusu);
            this.Controls.Add(this.btnAdmin);
            this.Name = "Form1";
            this.Text = "Giriş Ekranı";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAdmin;
        private System.Windows.Forms.Button btnSinavSorumlusu;
        private System.Windows.Forms.Button btnOgrenci;
        private System.Windows.Forms.Button btnYeniKayit;
        private System.Windows.Forms.Label label1;
    }
}

