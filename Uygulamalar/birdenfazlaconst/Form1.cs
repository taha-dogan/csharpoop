using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace birdenfazlaconst
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            string deger;
            deger = textBox1.Text;
            SinifA yeni = new SinifA(deger);
            MessageBox.Show(yeni.OgretimUyesi);
        }
    }
    class SinifA
    {
        public string OgretimUyesi;
        public SinifA() //constructor 1
        {
            OgretimUyesi = "Taha Doğan";
        }
        public SinifA(string Ad) //constructor 2
        {
            OgretimUyesi = Ad;
        }
    }
}
