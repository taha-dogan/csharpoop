using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace readonlyproperties
{
    class Class1
    {
        public int x = 0, y = 0;
        public double PolinomHesapla
        {
            get
            {
                double sonuc = 2 * x * x + 3 *y* y;
                return sonuc;
            }
        }
    }
}
