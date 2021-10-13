using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms; //kendimiz ekledik

namespace staticclass
{
    static class SinifB //static olarak tanımladık
    {
        public static string AdSoyad = "Taha Doğan";
        public static void AdGoster()
        {
            MessageBox.Show(AdSoyad);
        }
    }
}
