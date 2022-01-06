using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace all_inheritance_examples
{
    class SinifX
    {
        public string Ad = "Serdar Biroğul";
        public void AdGoster()
        {
            MessageBox.Show(this.Ad);
        }
    }

    class SinifY : SinifX
    {
        public string Adres = "Düzce";
        public void AdresGoster()
        {
            MessageBox.Show(this.Adres);
        }
    }
}
