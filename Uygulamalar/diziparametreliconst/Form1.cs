using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections; //eklenmelidir

namespace diziparametreliconst
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

        private void button1_Click(object sender, EventArgs e)
        {/*textboxtaki itemi listbox'a ekledik*/
            listBox1.Items.Add(textBox1.Text);
        }
        ArrayList dizi = new ArrayList();

        private void button2_Click(object sender, EventArgs e)
        {/*Listedeki tüm elemanları sırası ile gösterecek*/
            dizi.AddRange(listBox1.Items); //listbox elemanlarını dizi listesine ekle
            SinifA yeni = new SinifA(dizi); //dizi listesini sınıfa gönder
            yeni.OgretimUyesiGoster(); //görüntüleme işlemini yap
        }
    }

    class SinifA
    {
        private ArrayList kadro; //private bir dizi oluştur
        public SinifA(ArrayList isimler) //dizi değişkenli constructor
        {
            kadro = new ArrayList(); //kadro listesini de oluşturduk
            foreach (object Eleman in isimler) //eleman değişkenini gelen isimler listesinin hepsini tarattık
            {
                kadro.Add(Eleman); //gelen tüm liste elemanlarını private kadro'ya ekledik
            }
        }

        public void OgretimUyesiGoster()
        {
            foreach(object Eleman in kadro) //tüm kadro listesini al
            {
                System.Windows.Forms.MessageBox.Show(Eleman.ToString()); //messagebox ile göster
            }
        }
    }
}
