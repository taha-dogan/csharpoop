using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace parametrelifonksiyontanimlama
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int Ver;
            double Son;
            Class1 Yeni = new Class1();
            Ver = Convert.ToInt32(textBox1.Text);
            Son = Yeni.FaktoriyelHesapla(Ver);
            MessageBox.Show(Son.ToString());
        }
    }
}
