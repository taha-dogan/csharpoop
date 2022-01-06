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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            mirasAl yeni = new mirasAl();
            yeni.mesajVer();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            mirasAl2 yeni = new mirasAl2();
            MessageBox.Show(yeni.ogretimUyesi);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            mirasAl3 yeni = new mirasAl3();
            MessageBox.Show(yeni.ogretimUyesi);
            yeni.mesajVer();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            string veri = "Ayhan Nuri Yılmaz";
            InternalSinif yeni = new InternalSinif(veri);
            yeni.OgretimUyesiGoster();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            KisitliErisimSinif yeni = new KisitliErisimSinif();
            yeni.uzunluk = 20;
            double alanhesapla = yeni.yenialan();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            SinifA a = new SinifA();
            SinifC c = new SinifC();
            a.AdGoster();
            c.AdGoster2();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            KisitliErisimSinif yeni = new KisitliErisimSinif();
            yeni.uzunluk = 10;
            MessageBox.Show(yeni.yenialan().ToString());
        }

        private void button8_Click(object sender, EventArgs e)
        {
            dikucgen yeni = new dikucgen();
            yeni.genislik = 10;
            yeni.yukseklik = 20;
            double son = yeni.alan();
            MessageBox.Show(son.ToString());
        }

        private void button9_Click(object sender, EventArgs e)
        {
            overrideicin form2 = new overrideicin();
            this.Hide();
            form2.Show();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            SinifY yeni = new SinifY();
            this.Text=yeni.Ad;
            yeni.AdGoster();
            this.Text=yeni.Adres;
            yeni.AdresGoster();
            

            /*
            SinifX yeni = new SinifY();
            this.Text=yeni.Ad;
            yeni.AdGoster();
            this.Text=yeni.Adres; //bu x içerisinde olmadığı için çalışmaz
            yeni.AdresGoster();//bu x içerisinde olmadığı için çalışmaz
            */

        }

        private void button11_Click(object sender, EventArgs e)
        {
            Sinif2 yeni = new Sinif2();
            this.Text = yeni.Ad;
            yeni.AdGoster();
            this.Text = yeni.Adres; 
            yeni.AdresGoster();
            //yeni.TelefonGoster() veya yeni.Telefon alt sınıfta (Sinif3) olduğu için listelenmez.
            //Aşağıdaki gibi bir tasarımda da kısmı boxing yapılabilir.
            Sinif3 yeni2 = new Sinif3();
            yeni2.TelefonGoster();
            ((Sinif2)yeni2).AdGoster(); //bu satırda da "." işaretinden sonra telefon bilgileri gelmez.
        }

        private void button12_Click(object sender, EventArgs e)
        {
            Sinif_B yeni = new Sinif_B("Taha Doğan");
        }

        private void button13_Click(object sender, EventArgs e)
        {
            Siniff1 yeni = new Siniff1();
            yeni.goster();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            Siniff2 yeni = new Siniff2();
            yeni.Universite = "Kocaeli";
            yeni.UniversiteGoster();
            yeni.BolumGoster();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            abstract2icin abstt = new abstract2icin();
            this.Hide();
            abstt.Show();
        }
    }
}
