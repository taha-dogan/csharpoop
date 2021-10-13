using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace staticclassicindebaskaclass
{
    static class SinifB
    {
        public static string AdSoyad = "Taha Doğan";
        public static void AdGoster()
        {
            System.Windows.Forms.MessageBox.Show(AdSoyad);
        }

        public class SinifC //static değil ama hata yok
        {
            public string AdSoyad = "Ali Doğan";
            public void AdGoster()
            {
                System.Windows.Forms.MessageBox.Show(AdSoyad);
            }
        }
        
    }
}
