using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication14
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
          //  MessageBox.Show(DateTime.Today.ToString());
            listBox1.Items.Add(DateTime.Today);
            listBox1.Items.Add(DateTime.Today.Date);
            listBox1.Items.Add(DateTime.Today.Day);
            listBox1.Items.Add(DateTime.Today.Month);
            listBox1.Items.Add(DateTime.Today.Year);
            listBox1.Items.Add(DateTime.Today.DayOfWeek);
            listBox1.Items.Add(DateTime.Today.DayOfYear);

            listBox2.Items.Add(DateTime.Now);
            listBox2.Items.Add(DateTime.Now.Date);
            listBox2.Items.Add(DateTime.Now.Hour);
            listBox2.Items.Add(DateTime.Now.Minute);
            listBox2.Items.Add(DateTime.Now.Second);
            listBox2.Items.Add(DateTime.Now.Millisecond);

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            textBox1.Text = dateTimePicker1.Value.ToString();
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DateTime tarih = Convert.ToDateTime(textBox1.Text);
          DateTime yeniTarih= tarih.AddDays(Convert.ToDouble(textBox2.Text));
            DateTime yeniTarih2= tarih.AddMonths(Convert.ToInt32(textBox2.Text));
            DateTime yeniTarih3= tarih.AddYears(Convert.ToInt32(textBox2.Text));
             DateTime yeniTarih4= tarih.AddMinutes(Convert.ToDouble(textBox2.Text));
             DateTime yeniTarih5 = tarih.AddHours(Convert.ToDouble(textBox2.Text));
             DateTime yeniTarih6 = tarih.AddSeconds(Convert.ToDouble(textBox2.Text));
          
            
         
            listBox3.Items.Add(yeniTarih.ToString());
            listBox3.Items.Add(yeniTarih2.ToString());
            listBox3.Items.Add(yeniTarih3.ToString());
            listBox3.Items.Add(yeniTarih4.ToString());
            listBox3.Items.Add(yeniTarih5.ToString());
            listBox3.Items.Add(yeniTarih6.ToString());


        }

        private void button4_Click(object sender, EventArgs e)
        {
            TimeSpan zamanFarki = dateTimePicker3.Value - dateTimePicker2.Value;
            listBox4.Items.Add(zamanFarki);
                listBox4.Items.Add(zamanFarki.Days);
                listBox4.Items.Add(zamanFarki.Hours);
                listBox4.Items.Add(zamanFarki.Minutes);
                listBox4.Items.Add(zamanFarki.Seconds);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            DateTime oncesi = DateTime.Now;
            double sayac = 0;
            for (double i = 1; i <= 1000000000; i++)
                sayac = sayac + i;

            DateTime sonrası = DateTime.Now;

            TimeSpan   fark = sonrası - oncesi;
            
            MessageBox.Show("Sayıların toplamı: " + sayac + "İşlem Süresi: " +fark.TotalSeconds.ToString());
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
