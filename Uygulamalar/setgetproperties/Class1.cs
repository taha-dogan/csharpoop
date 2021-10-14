using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace setgetproperties
{
    class FormatliPara
    {
        private double ParaTutari = 0.0;
        private string ParaFormat;

        public string Format1
        {
            set
            {
                double sonuc;
                sonuc = Convert.ToDouble(value);
                this.ParaTutari = sonuc;
            }
            get
            {
                this.ParaFormat = ParaTutari.ToString("###,###,### TL");
                return this.ParaFormat;
            }
        }
    }
}
