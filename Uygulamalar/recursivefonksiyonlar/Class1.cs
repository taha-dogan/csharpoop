using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace recursivefonksiyonlar
{
    class Class1
    {
        public double Faktoriyel(int sayi)
        {
            double sonuc = 1;
            if(sayi > 1)
            {
                sonuc = sayi * Faktoriyel(sayi - 1);
            }
            return sonuc;
        }
    }
}
