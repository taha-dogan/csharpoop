using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace staticmetodlar
{
    class SinifB
    {
        public SinifB()
        {
            System.Windows.Forms.MessageBox.Show("Yükleme tamamlandı");
        }

        public static void MesajVer(string veri)
        {
            System.Windows.Forms.MessageBox.Show(veri);
        }
    }
}
