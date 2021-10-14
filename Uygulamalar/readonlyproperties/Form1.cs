using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace readonlyproperties
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Class1 polihesap = new Class1();
            double son;
            polihesap.x = Convert.ToInt32(textBox1.Text);
            polihesap.y = Convert.ToInt32(textBox2.Text);
            son = polihesap.PolinomHesapla;//Dikkat edilir ise sadece okuduk. Sadece sağ tarafta
            MessageBox.Show("Polinomun sonucu = "+ son);
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
