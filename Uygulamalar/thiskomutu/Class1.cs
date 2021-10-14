using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace thiskomutu
{
    class Class1
    {
        public int KareAl(int sayi)
        {
            int sonuc = sayi * sayi;
            return sonuc;
        }

        public void SonucGoster(int deger)
        {
            int veri;
            veri = this.KareAl(deger);
            System.Windows.Forms.MessageBox.Show("Sayının karesi = "+ veri.ToString());
        }
    }
}
