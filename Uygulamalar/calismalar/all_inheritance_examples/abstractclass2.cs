using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace all_inheritance_examples
{
    abstract class Sinifa
    {
        abstract public void AdGoster(string Ad);
        abstract public void AdresGoster(string Adres);
        abstract public decimal KdvBul(decimal Anapara, int oran);

    }

    class Sinifb : Sinifa
    {
        public override void AdGoster(string Ad)
        {
            //throw new NotImplementedException();
            MessageBox.Show(Ad);
        }
        public override void AdresGoster(string Adres)
        {
            //throw new NotImplementedException();
            MessageBox.Show(Adres);
        }

        public override decimal KdvBul(decimal Anapara, int oran)
        {
            //throw new NotImplementedException();
            decimal sonuc = Anapara * oran / 100;
            return sonuc;
        }
    }
}
