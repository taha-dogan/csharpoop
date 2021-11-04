using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace diziparametrelifonksiyontanimlamak
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Class1 Yeni = new Class1();
            Double Deger;
            int adet, i = 0;
            adet = listBox1.Items.Count;
            int[] sayilar = new int[adet];
            foreach(object Eleman in listBox1.Items)
            {
                sayilar[i++] = Convert.ToInt32(Eleman);
            }
            Deger = Yeni.ToplamHesapla(sayilar);
            textBox1.Text = Deger.ToString();
        }
    }
}
