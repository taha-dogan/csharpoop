using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace all_inheritance_examples
{
    public partial class abstract2icin : Form
    {
        public abstract2icin()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 Forrm1 = new Form1();
            this.Hide();
            Forrm1.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Sinifb yeni = new Sinifb();
            yeni.AdGoster("Taha");

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Sinifb yeni = new Sinifb();
            yeni.AdresGoster("İstanbul");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Sinifb yeni = new Sinifb();
            MessageBox.Show(yeni.KdvBul(10000, 13).ToString());
        }
    }
}
