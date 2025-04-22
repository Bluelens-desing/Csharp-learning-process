namespace diziler
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int i;
            string[] isimler = { "ali", "mustafa", "oruç", "melisa", "burak", "sewde", "taha", "mehmet" };
            i = Convert.ToInt16(textBox1.Text);
            label1.Text = isimler[i];
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            int i;
            int[] sayýlar = { 56, 342, 5643, 56, 23, 21, 78, 98, 09, 789, 6535, 4353, 6765, 6 };
            i = Convert.ToInt16(textBox2.Text);
            label2.Text = sayýlar[i].ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int toplam = 0,a=0;
            int[] sayilar = { 23, 21, 43, 34, 1, 5, 6, 10, 12, 14, 13, 2, 7, 9 };
            for (int i = 0; i < sayilar.Length; i++)
            {
                if (sayilar[i] % 2 == 1 && sayilar[i] > 10)
                {
                    a++;
                    listBox1.Items.Add(sayilar[i]);
                    toplam += sayilar[i];
                    int ortalama = toplam / a;
                    label3.Text=toplam.ToString();
                    label4.Text=ortalama.ToString();
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            string[] kisiler = { "ali", "veli", "taha", "oruc", "mustafa", "reyyan", "musab" };
            foreach (string k in kisiler)
            {
                listBox2.Items.Add(k);
            }
        }
    }
}
