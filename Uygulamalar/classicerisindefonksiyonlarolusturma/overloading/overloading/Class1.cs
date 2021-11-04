using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace overloading
{
    class Class1
    {
        public double ToplamHesapla(int[] Dizi)
        {
            Double sonuc = 0;
            foreach(int Elemanlar in Dizi)
            {
                sonuc += Elemanlar;
            }
            return sonuc;
        }

        public double ToplamHesapla(int[] Dizi, int Kuvvet)
        {
            double sonuc = 0;
            foreach(int Elemanlar in Dizi)
            {
                sonuc += Math.Pow(Elemanlar, Kuvvet);
            }
            return sonuc;
        }
    }
}
