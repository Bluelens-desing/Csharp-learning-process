using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication38
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + button2.Text;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + button1.Text;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + button3.Text;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + button4.Text;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + button5.Text;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + button6.Text;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + button7.Text;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + button8.Text;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + button9.Text;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + button10.Text;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            label1.Text = "";
            label2.Text = "";
        }

        private void button12_Click(object sender, EventArgs e)
        {
            label1.Text = textBox1.Text;
            label2.Text = "TOPLAMA";
            textBox1.Text = "";
        }

        private void button13_Click(object sender, EventArgs e)
        {
            label1.Text = textBox1.Text;
            label2.Text = "ÇIKARMA";
            textBox1.Text = "";
        }

        private void button14_Click(object sender, EventArgs e)
        {
            label1.Text = textBox1.Text;
            label2.Text = "ÇARPMA";
            textBox1.Text = "";
        }

        private void button16_Click(object sender, EventArgs e)
        {
            label1.Text = textBox1.Text;
            label2.Text = "BOLME";
            textBox1.Text = "";
        }

        private void button17_Click(object sender, EventArgs e)
        {
            label1.Text = textBox1.Text;
            label2.Text = "YUZDE";
            textBox1.Text = "";
        }

        private void button15_Click(object sender, EventArgs e)
        {
            label1.Text = textBox1.Text;
            label2.Text = "MOD";
            textBox1.Text = "";
        }

        private void button18_Click(object sender, EventArgs e)
        {
            if (label2.Text == "TOPLAMA")
                textBox1.Text = Convert.ToString(Convert.ToDouble(label1.Text) + Convert.ToDouble(textBox1.Text));
            if (label2.Text == "ÇIKARMA")
                textBox1.Text = Convert.ToString(Convert.ToDouble(label1.Text) - Convert.ToDouble(textBox1.Text));
            if (label2.Text == "ÇARPMA")
                textBox1.Text = Convert.ToString(Convert.ToDouble(label1.Text) * Convert.ToDouble(textBox1.Text));
            if (label2.Text == "BOLME")
                textBox1.Text = Convert.ToString(Convert.ToDouble(label1.Text) / Convert.ToDouble(textBox1.Text));
            if (label2.Text == "MOD")
                textBox1.Text = Convert.ToString(Convert.ToDouble(label1.Text) % Convert.ToDouble(textBox1.Text));
            if (label2.Text == "YUZDE")
                textBox1.Text = Convert.ToString(Convert.ToDouble(label1.Text)/100*Convert.ToDouble(textBox1.Text));
           
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label1.Visible = false;
            label2.Visible = false;
            label3.Visible = false;
        }
        int sayi1;
        private void button19_Click(object sender, EventArgs e)
        {
            textBox5.Text =Convert.ToString(Convert.ToDouble(textBox2.Text) * 0.4 + Convert.ToDouble(textBox3.Text) * 0.6);
            listBox1.Items.Add(textBox5.Text);

            if (Convert.ToDouble(textBox5.Text) < 36)
                textBox4.Text = "FF";
            else if (Convert.ToDouble(textBox5.Text) < 50)
                textBox4.Text = "FD";
            else if (Convert.ToDouble(textBox5.Text) < 55)
                textBox4.Text = "DD";
            else if (Convert.ToDouble(textBox5.Text) < 60)
                textBox4.Text = "DC";
            else if (Convert.ToDouble(textBox5.Text) < 71)
                textBox4.Text = "CC";
            else if (Convert.ToDouble(textBox5.Text) < 80)
                textBox4.Text = "CB";
            else if (Convert.ToDouble(textBox5.Text) < 85)
                textBox4.Text = "BB";
            else if (Convert.ToDouble(textBox5.Text) < 91)
                textBox4.Text = "BA";
            else if (Convert.ToDouble(textBox5.Text) <= 100)
                textBox4.Text = "AA";
            else
                MessageBox.Show("HATALI NOT GİRİŞİ");


            textBox2.Text = "";
            textBox3.Text = "";
         //   textBox4.Text = "";
         //   textBox5.Text = "";


        }

        private void button20_Click(object sender, EventArgs e)
        {
            double toplam = 0;
            for (int i = 0; i < listBox1.Items.Count; i++)
            {
                toplam = toplam + Convert.ToDouble(listBox1.Items[i]);
            }
            textBox6.Text = Convert.ToString(toplam / listBox1.Items.Count);
            label9.Text = "Sınıf Ortalamasına " + listBox1.Items.Count + " kadar öğrenci katılmıştır";
        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox7_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter || e.KeyCode==Keys.Down)
                textBox8.Focus();

        }

        private void textBox8_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter || e.KeyCode==Keys.Down)
                textBox9.Focus();
            if (e.KeyCode == Keys.Up)
                textBox7.Focus();
        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox9_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up)
                textBox8.Focus();
        }
        
        private void textBox7_Enter(object sender, EventArgs e)
        {
            textBox7.BackColor = Color.Yellow;
        }

        private void textBox7_Leave(object sender, EventArgs e)
        {
            textBox7.BackColor = Color.White;
        }

        private void textBox8_Enter(object sender, EventArgs e)
        {
            textBox8.BackColor = Color.Yellow;
        }

        private void textBox8_Leave(object sender, EventArgs e)
        {
            textBox8.BackColor = Color.White;
        }

        private void textBox9_Enter(object sender, EventArgs e)
        {
            textBox9.BackColor = Color.Yellow;
        }

        private void textBox9_Leave(object sender, EventArgs e)
        {
            textBox9.BackColor = Color.White;
        }

        private void button10_Click_1(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "9";
        }

        private void button8_Click_1(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "7";
        }

        private void button18_Click_1(object sender, EventArgs e)
        {
            textBox1.Text=Convert.ToString(Convert.ToInt32(textBox1.Text)+sayi1);
        }

        private void button12_Click_1(object sender, EventArgs e)
        {
            sayi1=Convert.ToInt32(textBox1.Text);
            textBox1.Text = "";
        }

        private void textBox7_MouseEnter(object sender, EventArgs e)
        {
        }
    }
}
