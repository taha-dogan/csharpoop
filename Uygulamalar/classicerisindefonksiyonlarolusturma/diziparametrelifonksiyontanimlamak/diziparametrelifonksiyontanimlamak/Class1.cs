using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace diziparametrelifonksiyontanimlamak
{
    class Class1
    {
        public double ToplamHesapla(int[] Dizi)
        {
            Double sonuc = 0;
            foreach(int Eleman in Dizi)
            {
                sonuc += Eleman;
            }
            return sonuc;
        }
    }
}
