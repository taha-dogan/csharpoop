using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace parametrelifonksiyontanimlama
{
    class Class1
    {
        public String Dekan;
        public string DekanYazdir(String Ad)
        {
            this.Dekan = Ad;
            return this.Dekan;
        }

        public Double FaktoriyelHesapla(int Deger)
        {
            Double sonuc = 1;
            for(int i = 2; i<=Deger; i++)
            {
                sonuc *= i;
            }
            return sonuc;
        }
    }
}
