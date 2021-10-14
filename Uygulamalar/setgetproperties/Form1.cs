using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace setgetproperties
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormatliPara X = new FormatliPara();
            X.Format1 = textBox1.Text; //set işlemi var çünkü atama işlemi var
            MessageBox.Show(X.Format1); //get işlemi var çünkü içeriden veri aldık
        }
    }
}
