using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace garbagecollector
{
    public partial class Form1 : Form
    {
        SinifA yeni; //Hangi kod bloğunda olduğuna dikkat

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            yeni = new SinifA();
            int son, veri;
            veri = Convert.ToInt32(textBox1.Text);
            son = yeni.KareHesapla(veri);
            label3.Text = son.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //otomatik olarak destructor'ı bulur
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            yeni.SinifiTemizle(); //nesneyi temizler
        }
    }
}
