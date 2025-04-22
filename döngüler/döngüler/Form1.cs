using System.Windows.Forms;

namespace döngüler
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 10; i++)
            {
                listBox1.Items.Add(i + 1 + "Merhaba Antep");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int sayı, toplam = 0, i;
            sayı = Convert.ToInt16(textBox1.Text);
            for (i = 0; i <= sayı; i += 2)
            {
                if (sayı % 2 == 0)

                {
                    toplam = toplam + i;
                    label1.Text = toplam.ToString();
                }
                else
                {
                    label1.Text = "lütfen çift sayı giriniz";
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int sayı = Convert.ToInt16(textBox2.Text);
            for (int i = 1; i <= sayı; i++)
            {
                if (sayı % i == 0)
                {
                    listBox2.Items.Add(i);
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int toplam = 1, sayı = Convert.ToInt16(textBox3.Text);
            for (int i = 1; i <= sayı; i++)
            {
                toplam = toplam * i;
            }
            label3.Text = toplam.ToString();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            int i = 1;
            while (i <= 5)
            {
                listBox3.Items.Add("van ve mersin");
                listBox4.Items.Add(i);
                i++;
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            int i = 0;
            {
                do
                {
                    listBox5.Items.Add("yoğurtlu tantuni");
                    i++;
                } while (i <= 5);
            }
        }
        int sayac = 0;
        private void button7_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            sayac++;
            label4.Text = sayac.ToString();
            if (sayac == 0)
            {
                this.BackColor = Color.Green;
            }
            if (sayac == 4)
            {
                this.BackColor = Color.Pink;
            }
            if (sayac == 8)
            {
                this.BackColor = Color.Red;
            }
            if (sayac == 12)
            {
                this.BackColor = Color.Yellow;
                sayac = 0;
            }
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {
            timer2.Start();
            this.panel1.BackColor = Color.Red;
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            sayac++;
            label5.Text = sayac.ToString();
            if (sayac == 15)
            {
                this.panel1.BackColor = Color.Red;
                this.panel3.BackColor = Color.FromName("ControlLight");
            }
            if (sayac == 50)
            {
                this.panel2.BackColor = Color.Yellow;
                this.panel1.BackColor = Color.FromName("ControlLight");
            }
            if (sayac == 55)
            {
                this.panel3.BackColor = Color.Green;
                this.panel2.BackColor = Color.FromName("ControlLight");
                sayac = 0;
            }
        }
        int saat = 0, dakika = 0, saniye = 0;
        private void timer3_Tick(object sender, EventArgs e)
        {
            saniye++;
            label6.Text = saniye.ToString();
            if (saniye == 60)
            {
                dakika++;
                saniye = 0;
                label7.Text = dakika + ":".ToString();
            }
            if (dakika == 5)
            {
                saat++;
                dakika = 0;
                label8.Text = saat + ":".ToString();
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            progressBar1.Value = 100;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            progressBar1.Value = 0;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            progressBar1.Value += 10;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            progressBar1.Value -= 10;
        }
    }
}
