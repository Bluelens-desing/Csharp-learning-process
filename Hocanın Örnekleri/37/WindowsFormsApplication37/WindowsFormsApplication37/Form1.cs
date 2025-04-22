using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication37
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text = textBox1.Text;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label2.Text = textBox2.Text;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            label3.Text = textBox3.Text;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            label7.Text = "ADI SOYADI : " +textBox6.Text + " TELEFONU : " + textBox5.Text + " ADRESİ : " + textBox4.Text;
        }

        private void button5_Click(object sender, EventArgs e)
        {
         //   label10.Text = "Toplama İşleminizin Sonucu : " + Convert.ToString(Convert.ToInt32(textBox7.Text) + Convert.ToInt32(textBox8.Text));
            textBox9.Text = Convert.ToString(Convert.ToInt32(textBox7.Text) + Convert.ToInt32(textBox8.Text));
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox10.Text = Convert.ToString(Convert.ToInt32(textBox12.Text) - Convert.ToInt32(textBox11.Text));
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox13.Text = Convert.ToString(Convert.ToInt32(textBox14.Text) * Convert.ToInt32(textBox15.Text));
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (textBox17.Text != "0")
            {
                textBox16.Text = Convert.ToString(Convert.ToDouble(textBox18.Text) / Convert.ToDouble(textBox17.Text));
            }
            else
            {
                MessageBox.Show("Sıfıra Bölme Hatası. Bölen 0 olamaz.");
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (textBox20.Text != "0")
            {
                textBox19.Text = Convert.ToString(Convert.ToDouble(textBox21.Text) % Convert.ToDouble(textBox20.Text));
            }
            else
            {
                MessageBox.Show("Sıfıra Bölme Hatası. Bölen 0 olamaz.");
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text =="TOPLAMA")
            {
                // TOPLAMA
                label26.Text =comboBox1.Text + " İşleminizin Sonucu : " + Convert.ToString(Convert.ToInt32(textBox23.Text) + Convert.ToInt32(textBox22.Text));
            
                textBox24.Text = Convert.ToString(Convert.ToInt32(textBox23.Text) + Convert.ToInt32(textBox22.Text));
            }

            else if (comboBox1.Text=="ÇIKARMA")
            {  
                //ÇIKARMA
                textBox24.Text = Convert.ToString(Convert.ToInt32(textBox23.Text) - Convert.ToInt32(textBox22.Text));
            }

        else if (comboBox1.Text=="ÇARPMA")
            {
            //çarpma
                textBox24.Text = Convert.ToString(Convert.ToInt32(textBox23.Text) * Convert.ToInt32(textBox22.Text));
             }
            else if (comboBox1.Text =="BÖLME")
            {
                textBox24.Text = Convert.ToString(Convert.ToDouble(textBox23.Text) / Convert.ToDouble(textBox22.Text));
                //bölme
            }
            else if (comboBox1.Text == "MOD")
            {      
                //mod
                textBox24.Text = Convert.ToString(Convert.ToDouble(textBox23.Text) % Convert.ToDouble(textBox22.Text));
            }
            else
            {
                MessageBox.Show("Yanlış işlem seçtiniz");
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            label1.Text = textBox1.Text;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            label2.Text = textBox2.Text;
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            label3.Text = textBox3.Text;
        }
    }
}
