using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication24
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string metin1 = textBox1.Text;
            string metin2 = textBox2.Text;
            textBox3.Text = metin1.ToUpper(); //BÜYÜKHARF
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string metin1 = textBox1.Text;
            string metin2 = textBox2.Text;
            textBox3.Text = metin1.ToLower(); //KÜÇÜKHARF
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string metin1 = textBox1.Text;
            textBox3.Text = metin1.Trim();  //BOŞLUK SİL
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string metin1 = textBox1.Text;
            textBox3.Text = metin1.Length.ToString(); //UZUNLUK
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string metin1 = textBox1.Text;
            textBox3.Text = metin1.Substring(Convert.ToInt32(textBox4.Text),Convert.ToInt32(textBox5.Text)); //PARÇA AL
        }

        private void button6_Click(object sender, EventArgs e)
        {
            string metin1 = textBox1.Text;
            textBox3.Text = metin1.Insert(9, "GİBTÜ "); //YAPIŞTIR
        }

        private void button7_Click(object sender, EventArgs e)
        {
            string metin1 = textBox1.Text;
            textBox3.Text = metin1.Replace("7 ARALIK", "18 MART"); //DEĞİŞTİR
            //textBox3.Text = textBox3.Text.Replace("ARALIK", "MART");
        }

        private void button8_Click(object sender, EventArgs e)
        {
            string metin1 = textBox1.Text;
            textBox3.Text = metin1.Remove(6,2); //SİL
        }

        private void button9_Click(object sender, EventArgs e)
        {
            string metin1 = textBox1.Text;
            string metin2 = textBox2.Text;
            //textBox3.Text = metin1 + metin2;
            textBox3.Text = string.Concat(metin1, " ", metin2, " ", "bu birleştirme işlemi");
        }

        private void button10_Click(object sender, EventArgs e)
        {
            string metin1 = textBox1.Text;
            string metin2 = textBox2.Text;
            textBox3.Text = string.Compare(metin1, metin2).ToString();//KARŞILAŞTIR
        }

        private void button11_Click(object sender, EventArgs e)
        {
            string metin1 = textBox1.Text;
            textBox3.Text = metin1.IndexOf("ÜNİ",6).ToString(); //METİN BUL ->İNDEX VERİR
        }

        private void button12_Click(object sender, EventArgs e)
        {
            string metin1 = textBox1.Text;
            int indis = metin1.IndexOf("ÜNİ"); //ÜNİVERSİTESİNİ AYIRMA?
            textBox3.Text = metin1.Substring(0,metin1.Length-13);
        }

        private void button13_Click(object sender, EventArgs e)
        {
       

        }

        private void button13_Click_1(object sender, EventArgs e)
        {
            string adSoyad = textBox1.Text;
           
            int bosluk = adSoyad.IndexOf(' ');   //BOŞLUĞU BULARAK SONRASINI AYRIŞTIRMA
            string ad = adSoyad.Substring(0, bosluk);
            textBox2.Text = ad;
            string soyad = adSoyad.Substring(bosluk + 1, (adSoyad.Length - bosluk-1));
            textBox3.Text = soyad;
        }

        private void button14_Click(object sender, EventArgs e)
        {
            string isim = textBox1.Text;
            string[] dizi = isim.Split(' ');  //AYRIŞTIRIP DİZİYE ATAMA OTOMATİK

            for (int i = 0; i < dizi.Length; i++)
                listBox1.Items.Add(dizi[i]);
           
        }

        private void button15_Click(object sender, EventArgs e)
        {
            string metin = richTextBox1.Text;
            
            string[] dizi = metin.Split(' ');  //KELİMELERE AYIRMA

            for (int i = 0; i < dizi.Length; i++)
                listBox2.Items.Add(dizi[i].Trim());
        }
    }
}
