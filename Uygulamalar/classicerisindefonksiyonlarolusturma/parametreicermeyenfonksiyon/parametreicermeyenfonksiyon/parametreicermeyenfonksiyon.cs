using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace parametreicermeyenfonksiyon
{
    static class SinifB //static olarak tanımlandı
    {
        public static string AdSoyad = "Serdar Biroğul";
        public static void AdGoster()
        {
            System.Windows.Forms.MessageBox.Show(AdSoyad);

        }
        public static class SinifC //static olmasa bile hata yoktur
        {
            public static string AdSoyad = "Taha Doğan";
            public static void AdGoster()
            {
                System.Windows.Forms.MessageBox.Show(AdSoyad);
            }
        }
    }

}
