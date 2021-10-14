using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace recursivefonksiyonlar
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int sayi;
            double son;
            Class1 f = new Class1();
            sayi = Convert.ToInt32(textBox1.Text);
            son = f.Faktoriyel(sayi);
            MessageBox.Show("Faktöriyel işleminin sonucu = "+ son.ToString());
        }
    }
}
