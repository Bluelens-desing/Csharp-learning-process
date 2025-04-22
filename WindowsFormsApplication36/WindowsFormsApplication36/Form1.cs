using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication36
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label1.Text = "GÖRSEL PROGRAMLAMA DERSİ";
          //  button1.Visible = false;
           // button2.Visible = false;
           // button3.Visible = false;
           // button4.Visible = false;
           // button5.Visible = false;
           // button7.Visible = false;
           // button8.Visible = false;
           // button9.Visible = false;
           // button10.Visible = false;
           // button11.Visible = false;
           // button12.Visible = false;

        }

        private void button1_Click(object sender, EventArgs e)
        {
          //  label1.Text = button1.Text;
            button1.Text = label1.Text;
        }

        private void button2_Click(object sender, EventArgs e)
        {
          DialogResult cvp =  MessageBox.Show("İŞLEMİ ONAYLIYOR MUSUNUZ?","ONAY",MessageBoxButtons.YesNoCancel,MessageBoxIcon.Question,MessageBoxDefaultButton.Button1);

          if (cvp == DialogResult.Yes)
          {
              label1.Text = "EVET TIKLANDI";
          }
           else  if (cvp == DialogResult.No)
          {
              label1.Text = "HAYIR TIKLANDI";
          }
          else if (cvp == DialogResult.Cancel)
          {
              label1.Text = "İPTAL TIKLANDI";
          }
   
        
        }

        private void button3_Click(object sender, EventArgs e)
        {
            for (int i = 0; 1==1; i++)
            { 
            DialogResult dr = MessageBox.Show("Döngü değişkeni değeri:" +i, "Devam etmek istiyor musunuz?",MessageBoxButtons.YesNoCancel,MessageBoxIcon.Stop);
                if (dr==DialogResult.No)
                    break;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            label2.Text = textBox1.Text;
            textBox2.Text = textBox1.Text;

        }

        private void button5_Click(object sender, EventArgs e)
        {
            button1.Visible = false;
            button2.Visible = false;
            button3.Visible = false;

            button4.Visible = false;
            label1.Visible = false;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            button1.Visible = true;
            button2.Visible = true;
            button3.Visible = true;
            button4.Visible = true;
            label1.Visible = true;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (button4.Visible == true)
                button4.Visible = false;
            else
                button4.Visible = true;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            button4.Height = button4.Height + 10;
          //  button4.Width = button4.Width + 10;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            button4.Height = button4.Height - 10;
         //   button4.Width = button4.Width - 10;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            button4.Enabled = true;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            button4.Enabled = false;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            if (button4.Enabled == true)
                button4.Enabled = false;
            else
                button4.Enabled = true;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            textBox2.Text = textBox1.Text;
            label2.Text = textBox1.Text;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            textBox1.Text = textBox2.Text;
            label2.Text = textBox2.Text;
        }
    }
}
