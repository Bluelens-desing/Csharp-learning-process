using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Trafik_Lambasi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnBaslat_Click(object sender, EventArgs e)
        {
            timer2.Start();
        }

        private void btnDurdur_Click(object sender, EventArgs e)
        {
            timer2.Stop();

        }
        int sayac = 70;
        private void timer2_Tick(object sender, EventArgs e)
        {


            sayac--;

            if (sayac <= 70 && sayac >= 40)
            {
                panel1.BackColor = Color.Red;
                panel3.BackColor = Color.Transparent;
                label1.Text = sayac.ToString();

            }

            if (sayac < 40 && sayac >= 30)
            {
                panel2.BackColor = Color.Yellow;
                panel1.BackColor = Color.Transparent;
                label2.Text = sayac.ToString();


            }

            if (sayac < 30 && sayac >= 0)
            {
                panel3.BackColor = Color.Green;
                panel1.BackColor = Color.Transparent;
                panel2.BackColor = Color.Transparent;
                label3.Text = sayac.ToString();

            }
            if (sayac == 0)
            {
                sayac = 70;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}