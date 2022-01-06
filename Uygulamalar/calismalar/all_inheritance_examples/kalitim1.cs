using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace all_inheritance_examples
{
    class mirasVer
    {
        public string ogretimUyesi = "Serdar Biroğul";
        public void mesajVer()
        {
            MessageBox.Show(ogretimUyesi);
        }
    }

    class mirasAl:mirasVer
    {

    }
}
