using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace writeonlyproperties
{
    class AnaPara
    {
        public int Komisyon = 10;
        private double AlisTutari;

        public double KomisyonsuzTutar
        {
            set
            {
                AlisTutari = Convert.ToDouble(value);
            }
        }

        public double KomisyonluTutar
        {
            get
            {
                return AlisTutari * Komisyon / 100.0;
            }
        }
    }
}
