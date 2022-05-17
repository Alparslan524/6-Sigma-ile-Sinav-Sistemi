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
    public partial class frmOgrenci : Form
    {
        public frmOgrenci()
        {
            InitializeComponent();
        }

        private void btnGirisO_Click(object sender, EventArgs e)
        {
            bool giris_yapildimi;
            Kisi kisi = new Kisi();
            KisiVeriTabani kisiveritabani = new KisiVeriTabani(); // yapıcı method ile bağlan() methodu çalışır...

            kisi.KullaniciAdi = txtKullaniciAdiO.Text;
            kisi.Sifre = txtSifreO.Text;
            kisi.KullaniciTipi = 3;

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
