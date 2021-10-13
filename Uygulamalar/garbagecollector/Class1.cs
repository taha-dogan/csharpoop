using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms; //eklenmelidir

namespace garbagecollector
{
    class SinifA
    {
        public SinifA()
        {
            MessageBox.Show("Class yüklendi");
        }

        ~SinifA()
        {
            MessageBox.Show("Class kaldırıldı");
        }

        public int KareHesapla(int x)
        {
            int sonuc = 1;
            sonuc = x*x;
            return sonuc;
        }

        public void SinifiTemizle()
        {
            System.GC.SuppressFinalize(this); //nesneyi temizledik
        }
    }
}
