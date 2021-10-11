using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{

    class SinifA
    {
        public string ogretimuyesi;
        public SinifA()
        {
            ogretimuyesi = "Serdar Biroğul";
        }
    }


    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            SinifA yeni = new SinifA();
            MessageBox.Show("Öğretim üyesi : " + yeni.ogretimuyesi);
        }
    }
}
