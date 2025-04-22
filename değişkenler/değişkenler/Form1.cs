namespace değişkenler
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string adsoyad, meslek;
            adsoyad = "mustafa şahin";
            meslek = "bilgisayar mühendisliği";
            label1.Text = adsoyad;
            label2.Text = meslek;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string şehir;
            şehir = textBox1.Text;
            label4.Text = şehir;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            string ADsoyad, Yaşı, Meslek, Şehir;
            ADsoyad = textBox2.Text;
            Yaşı = textBox3.Text;
            Meslek = textBox4.Text;
            Şehir = textBox5.Text;
            label12.Text = ADsoyad;
            label13.Text = Şehir;
            label14.Text = Meslek;
            label15.Text = Yaşı;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int sayi1, sayi2, toplam;
            sayi1 = 9;
            sayi2 = 10;
            toplam = sayi1 + sayi2 + 5;
            label16.Text = toplam.ToString();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            int kenar, alan, cevre;
            kenar = 5;
            alan = kenar * kenar;
            cevre = kenar * 4;
            label17.Text = "alan: " + alan + " cevre: " + cevre;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            int sayi,kupu;
            sayi = Convert.ToInt16(textBox6.Text);
            kupu = sayi * sayi * sayi;
            label19.Text = kupu .ToString();
        }
    }
}
