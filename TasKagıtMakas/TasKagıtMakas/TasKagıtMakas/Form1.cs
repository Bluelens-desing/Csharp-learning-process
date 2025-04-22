using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TasKagıtMakas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }
        int skor = 0;

        private void button6_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            int deger;
            deger = random.Next(1, 4);
            if (deger == 1)
            {
                label1.Text = "beraberlik";
                button3.BackColor = Color.Gray;
            }
            else if (deger==2)
            {
                label1.Text = "Kaybettiniz";
                button2.BackColor = Color.Red;
            }
            else if (deger == 3)
            {
                skor++;
                label2.Text = skor.ToString();
                label1.Text = "Kazandınız";
                button1.BackColor = Color.Green;
            }

        }

        private void button5_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            int deger;
            deger = random.Next(1, 4);
            if (deger == 1)
            {
                skor++;
                label2.Text = skor.ToString();
                label1.Text = "Kazandınız";
                button3.BackColor = Color.Green;
            }
            else if (deger == 2)
            {
                label1.Text = "beraberlik";
                button2.BackColor = Color.Gray;
            }
            else if (deger == 3)
            {
                label1.Text = "Kaybettiniz";
                button1.BackColor = Color.Red;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            int deger;
            deger = random.Next(1, 4);
            if (deger == 1)
            {
                label1.Text = "Kaybettiniz";
                button3.BackColor = Color.Red;
            }
            else if (deger == 2)
            {
                skor++;
                label2.Text = skor.ToString();
                label1.Text = "Kazandınız";
                button2.BackColor = Color.Green;
            }
            else if (deger == 3)
            {
                label1.Text = "Beraberlik";
                button1.BackColor = Color.Gray;
            }
        }
    }
}
