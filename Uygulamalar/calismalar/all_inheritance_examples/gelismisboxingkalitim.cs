using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace all_inheritance_examples
{
    class Sinif1
    {
        public string Ad = "Serdar Biroğul";
        public void AdGoster()
        {
            MessageBox.Show(this.Ad);
        }
    }

    class Sinif2:Sinif1
    {
        public string Adres = "Düzce";
        public void AdresGoster()
        {
            MessageBox.Show(this.Adres);
        }
    }

    class Sinif3 : Sinif2
    {
        public string Telefon = "0445 780 9131";
        public void TelefonGoster()
        {
            MessageBox.Show(this.Telefon);
        }
    }
}
