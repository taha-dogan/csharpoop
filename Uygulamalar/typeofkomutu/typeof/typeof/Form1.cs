using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Reflection;

namespace @typeof
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Type tip = typeof(SinifA);
            //MethodInfo[] Dizi = tip.GetMethods();  aynı ifadeyi GetMembers ile tanımlayarak değişkenleri de dahil edelim
            MemberInfo[] Dizi = tip.GetMembers();
            foreach(MemberInfo Eleman in Dizi)
            {
                listBox1.Items.Add(Eleman);
            }
        }
    }

    class SinifA
    {
        public string Veri = "Taha Doğan";
        public int Sonuc = 0;
        

        public void MesajVer(string Deger)
        {
            MessageBox.Show(Deger);
        }

        public void MesajVer2(string Deger, int Adet)
        {
            for(int i = 0; i<=Adet-1;i++)
            {
                MessageBox.Show(Deger);
            }
        }

        public int Hesapla(int Deger)
        {
            int Sonuc = Deger * Deger;
            return Sonuc;
        }
    }
}
