using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _6SigmaYazilimYapimi
{
    public partial class frmAdmin : Form
    {
        public frmAdmin()
        {
            InitializeComponent();
        }

        private void btnGirisA_Click(object sender, EventArgs e)
        {
            {
                bool giris_yapildimi;
                Kisi kisi = new Kisi();
                KisiVeriTabani kisiveritabani = new KisiVeriTabani(); // yapıcı method ile bağlan() methodu çalışır...

                kisi.KullaniciAdi = txtKullaniciAdiA.Text;
                kisi.Sifre = txtSifreA.Text;
                kisi.KullaniciTipi = 1; // admin olduğu icin tip idsini 1 veriyoruz.

                giris_yapildimi = kisiveritabani.Giris(kisi);

                if (giris_yapildimi)
                {
                    MessageBox.Show("basariyla giriş yaptınız"); //form gecisi uygulanacak
                }
                else
                {
                    MessageBox.Show("Giris başarisiz");
                }

            }
        }
    }
}
