using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace all_inheritance_examples
{
    abstract class Siniff
    {
        public string Universite = "Düzce Üniversitesi";
        public void UniversiteGoster()
        {
            MessageBox.Show(this.Universite);
        }
    }

    class Siniff2:Siniff
    {
        public string Bolum = "Bilgisayar Mühendisliği";
        public void BolumGoster()
        {
            MessageBox.Show(this.Bolum);
        }
    }
}
