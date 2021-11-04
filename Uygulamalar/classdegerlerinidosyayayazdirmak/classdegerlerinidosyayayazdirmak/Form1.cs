using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.Serialization; //ekle
using System.Runtime.Serialization.Formatters.Binary;//ekle
using System.IO;

namespace classdegerlerinidosyayayazdirmak
{
    public partial class Form1 : Form
    {
        //Çalıştırınca direkt oku butonuna basılırsa önceden kayıtlı verinin geldiği görülür.

        ozellikleritut Yeni = new ozellikleritut(); //yavru değişken

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Yeni.adsoyad = "Aslı Doğan";
            Yeni.Adres = "İst";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //kaydet
            IFormatter Yazdir = new BinaryFormatter();
            FileStream Akis = new FileStream("Dosya.xml", FileMode.Create, FileAccess.Write);
            Yazdir.Serialize(Akis,Yeni);
            Akis.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //Oku
            IFormatter Oku = new BinaryFormatter();
            FileStream Akis = new FileStream("Dosya.xml",FileMode.Open,FileAccess.Read);
            ozellikleritut DosyaOku = (ozellikleritut)Oku.Deserialize(Akis);
            Akis.Close();
            listBox1.Items.Add(DosyaOku.adsoyad);
            listBox1.Items.Add(DosyaOku.Adres);
        }
    }
}
