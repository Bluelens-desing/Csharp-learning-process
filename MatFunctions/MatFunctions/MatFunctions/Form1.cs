using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace MatFunctions
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button6_Click(object sender, EventArgs e)
        { 
            textBox15.Text = Math.Sin(Convert.ToDouble(textBox14.Text) * Math.PI / 180).ToString();
            textBox16.Text = Math.Cos(Convert.ToDouble(textBox14.Text) * Math.PI / 180).ToString();
            textBox17.Text = Math.Tan(Convert.ToDouble(textBox14.Text) * Math.PI / 180).ToString();
            //textBox22.Text = Math.Acos(Convert.ToDouble(textBox14.Text) * Math.PI / 180).ToString();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox20.Text = Math.Log(Convert.ToDouble(textBox21.Text)).ToString();
            textBox19.Text = Math.Log10(Convert.ToDouble(textBox21.Text)).ToString();
            textBox18.Text = Math.Log(8, 2).ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double a, b, c, x1, x2, delta;
            a = Convert.ToDouble(textBox4.Text);
            b = Convert.ToDouble(textBox3.Text);
            c = Convert.ToDouble(textBox2.Text);
            delta = b * b - 4* a * c;
            if (delta > 0)
            {
                x1 = (-b - Math.Sqrt(delta)) / (2 * a);
                x2 = (-b + Math.Sqrt(delta)) / (2 * a);

                labelsonuc.Text = $"İki gerçek kök:";
                labelkok.Text = $"x1 = {x1}, x2 = {x2}";
            }
            else if (delta == 0)
            {
                x1 = -b / (2 * a);
                labelsonuc.Text = $"Tek gerçek kök:";
                labelkok.Text = $"x = {x1}";
            }
            else
            {
                labelsonuc.Text = "KÖK YOK";
                
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            double adet, bf, tutar = 0;
            adet = Convert.ToDouble(textBox6.Text);
            bf = Convert.ToDouble(textBox5.Text);
            if (checkBox1.Checked == true)
                tutar = bf * adet + bf * adet * 18 / 100;
            else
            { tutar = bf * adet; }
            label4.Text = tutar + " TL";
        }
    }
    }

