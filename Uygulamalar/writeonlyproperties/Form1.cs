using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace writeonlyproperties
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AnaPara XX = new AnaPara();
            XX.Komisyon = 20;
            XX.KomisyonsuzTutar = 200;
            MessageBox.Show(XX.KomisyonluTutar.ToString()); //40 yazar
        }
    }
}
