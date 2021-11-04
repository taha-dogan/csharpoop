using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace indexer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Elemanlar Yeni = new Elemanlar(); //görüldüğü gibi bir dizi değil ancak dizi gibi indeks verildi
            Yeni[0] = "Serdar Biroğul";
            Yeni[1] = "Taha Doğan"; //Yeni [1] olur
            Yeni[2] = "Aslı Doğan"; //Yeni[2] olur
            MessageBox.Show(Yeni[1].ToString());
        }
    }
}
