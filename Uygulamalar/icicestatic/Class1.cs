using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace icicestatic
{
    static class SinifB
    {
        public static string AdSoyad = "Taha Doğan";
        public static void AdGoster()
        {
            System.Windows.Forms.MessageBox.Show("SinifB : "+ AdSoyad);
        }

        public static class SinifC
        {
            public static string AdSoyad = "Aslı Doğan";
            public static void AdGoster()
            {
                System.Windows.Forms.MessageBox.Show("SinifC : "+ AdSoyad);
            }
        }
    }
}
