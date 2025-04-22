namespace öğrenci_sınav_durum_hesaplama
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "ali")
            {
                label1.Text = "Hoşgeldiniz";
                textBox1.Focus();
            }
            else
            {
                label1.Text = "Yanlış kişi";
                textBox1.Focus();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int a = Convert.ToInt16(textBox2.Text);
            if (a == 5)
            {
                label4.Text = "doğru sayı";
                textBox2.Focus();
            }
            else
            {
                label4.Text = "yanlış sayı";
                textBox2.Focus();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int b = Convert.ToInt16(textBox3.Text);
            if (b % 2 == 0)
            {
                label6.Text = "girilen sayı çifttir";
                textBox3.Focus();
            }
            else
            {
                label6.Text = "girilen sayı tektir";
                textBox3.Focus();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int c = Convert.ToInt16(textBox4.Text);
            if (c >= 10 && c % 2 == 0)
            {
                label8.Text = "ondan büyük ve çift sayıdır";
                textBox4.Focus();
            }
            else if (c >= 10 && c % 2 == 1)
            {
                label8.Text = "ondan büyük ve tek sayıdır";
                textBox4.Focus();
            }
            else
            {
                if (c % 2 == 0)
                {
                    label8.Text = "ondan küçük bir sayıdır ve çifttir";
                    textBox4.Focus();
                }
                else
                {
                    label8.Text = "ondan küçük bir sayıdır ve tektir";
                    textBox4.Focus();
                }
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            double s1, s2, pro, ort;
            s1 = Convert.ToDouble(textBox5.Text);
            s2 = Convert.ToDouble(textBox6.Text);
            pro = Convert.ToDouble(textBox7.Text);
            ort = (s1 + s2 + pro) / 3;

            if (ort >= 60)
            {
                label13.Text = "BAŞARILI";
            }
            else if (ort >= 50)
            {
                label13.Text = "KOŞULLU BAŞARI";
            }
            else
            {
                label13.Text = "BAŞARISIZ";
            }
            textBox8.Text = ort.ToString("0.00");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            int kitap;
            kitap = Convert.ToInt16(textBox10.Text);
            double fiyat;
            if (kitap >= 0 && kitap <= 20)
            {
                fiyat = (kitap * 8) * (8.0 / 10.0);
                label15.Text = fiyat.ToString("0.00") + "TL";
                textBox10.Focus();
            }
            else if (kitap >= 21 && kitap <= 40)
            {
                fiyat = (kitap * 8) * (6.0 / 10.0);
                label15.Text = fiyat.ToString("0.00") + "TL";
                textBox10.Focus();
            }
            else
            {
                fiyat = (kitap * 8) * (1.0 / 2.0);
                label15.Text = fiyat.ToString("0.00") + "TL";
                textBox10.Focus();
            }
            
        }
    }
}
