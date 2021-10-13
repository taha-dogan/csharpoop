using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace destructor
{
    class SinifA
    {
        public SinifA() //constructor
        {
            System.Windows.Forms.MessageBox.Show("Class yüklendi");
        }
        ~SinifA()//destructor
        {
            System.Windows.Forms.MessageBox.Show("Destructor çalıştı");
        }
    }
}
