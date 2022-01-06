using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace all_inheritance_examples
{
    internal class basekomutukalitim
    {
        class MirasVerecek
        {
            public int uzunluk = 0;
            protected double alan()
            {
                double sonuc = uzunluk * uzunluk / 2;
                return sonuc;
            }
        }

        class KisitliErisimSinif : MirasVerecek
        {
            public double yenialan()
            {
                double sonuc = base.alan() * 2;
                return sonuc;
            }
        }

    }
}
