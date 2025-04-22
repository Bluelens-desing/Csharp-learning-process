namespace tekrar
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string[] kisiler = { "ali", "mehmet", "aydoðan", "mustafa", "melisa", "robin" };

            int[] sayýlar = { 42, 22, 45, 56436, 423, 42543 };

            label1.Text = sayýlar[Convert.ToInt16(textBox1.Text)].ToString();
            for (int i = 0; i < sayýlar.Length; i++)
            {
                if (sayýlar[i] % 2 == 0)
                {
                    if (sayýlar[i] > 40)
                    {
                        listBox2.Items.Add(sayýlar[i]);
                    }
                    listBox2.Items.Add(sayýlar[i]);
                }
                listBox1.Items.Add(kisiler[i]);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int toplam = 0, carp = 1;
            string[] kisiler = { "melisa", "mustafa", "aydoðan", "emin", "oruç", "taha", "robin", "reyyan" };
            foreach (string k in kisiler)
            {
                listBox3.Items.Add(k);
            }
            int[] sayýlar = { 12, 23, 34, 45, 56, 67, 78, 89, 90 };
            foreach (int n in sayýlar)
            {
                listBox4.Items.Add(n);
                toplam += n;
                carp *= n;
            }
            label2.Text = toplam.ToString();
            label3.Text = carp.ToString();
            label4.Text = (toplam / sayýlar.Length).ToString();


        }

        private void temizle()
        {
            listBox1.Items.Clear();
            listBox2.Items.Clear();
            listBox3.Items.Clear();
            listBox4.Items.Clear();
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
        }
        private void button3_Click(object sender, EventArgs e)
        {
            temizle();
        }
        void renlendir()
        {
            listBox1.BackColor = Color.Red;
            listBox2.BackColor = Color.Green;
            listBox3.BackColor = Color.Blue;
            listBox4.BackColor = Color.Yellow;
            textBox2.BackColor = Color.Pink;
            textBox3.BackColor = Color.PaleTurquoise;
            textBox4.BackColor = Color.Purple;
            textBox5.BackColor = Color.Orange;
            BackColor = Color.PapayaWhip;
        }
        private void button4_Click(object sender, EventArgs e)
        {
            renlendir();
        }
        int toplam(int s1, int s2)
        {
            int s3 = s1 + s2;
            return s3;
        }
        int fark(int s1, int s2)
        {
            int s3 = s1 - s2;
            return s3;
        }
        int carp(int s1, int s2)
        {
            int s3 = s1 * s2;
            return s3;
        }
        int bolum(int s1, int s2)
        {
            int s3 = s1 / s2;
            return s3;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            BackColor = Color.PeachPuff;
        }
        void temiz()
        {
            textBox6.Text = "";
            textBox7.Text = "";
            textBox8.Text = "";
            textBox9.Text = "";
            label9.Text = "Durum:";
        }
        private void button6_Click(object sender, EventArgs e)
        {
            int sonuc;
            if (textBox8.Text == "+")
            {
                sonuc = toplam(Convert.ToInt16(textBox6.Text), Convert.ToInt16(textBox7.Text));
                textBox9.Text = sonuc.ToString();
                label9.Text = "Hesaplandý";
            }
            else if (textBox8.Text == "-")
            {
                sonuc = fark(Convert.ToInt16(textBox6.Text), Convert.ToInt16(textBox7.Text));
                textBox9.Text = sonuc.ToString();
                label9.Text = "Hesaplandý";
            }
            else if (textBox8.Text == "*")
            {
                sonuc = carp(Convert.ToInt16(textBox6.Text), Convert.ToInt16(textBox7.Text));
                textBox9.Text = sonuc.ToString();
                label9.Text = "Hesaplandý";
            }
            else if ((textBox8.Text == "/") || (textBox8.Text == "\\"))
            {
                sonuc = bolum(Convert.ToInt16(textBox6.Text), Convert.ToInt16(textBox7.Text));
                textBox9.Text = sonuc.ToString();
                label9.Text = "Hesaplandý";
            }
            else
            {
                label9.Text = "Lütfen geçerli bir operatör giriniz";
                textBox8.Text = "+,-,*,/";
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            temiz();
        }
    }
}
