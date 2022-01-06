using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace all_inheritance_examples
{
    class InternalSinif
    {
        internal string OgretimUyesi = "Serdar Biroğul";
        public InternalSinif(string deger)
        {
            this.OgretimUyesi = deger;
        }
            internal void OgretimUyesiGoster()
            {
                MessageBox.Show(this.OgretimUyesi);
            }

    }
}


