using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sınıflar
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            Araba rb2 = new Araba();
            rb2.renk = "yeşil";
            rb2.hiz = 140;
            rb2.motor = 1220.36;
            rb2.fiyat = 35850;
            rb2.durum = 'i';
            rb2.YIL = -2020;
            rb2.MARKASI = "Passat";
            rb2.plaka = "33PY828";
            rb2.muayene = 2020;
            rb2.sahip = "Abdül Kadir Şahin";

            label1.Text = rb2.renk;
            label2.Text = rb2.hiz.ToString();
            label3.Text = rb2.motor.ToString();
            label4.Text = rb2.fiyat.ToString();
            label5.Text = rb2.durum.ToString();
            label6.Text=rb2.YIL.ToString();
            label7.Text = rb2.MARKASI;
            label8.Text = rb2.plaka;
            label9.Text = rb2.muayene.ToString();
            label10.Text = rb2.sahip.ToString();

            pictureBox1.BackColor = Color.Green;
            panel1.BackColor = Color.Green;
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
