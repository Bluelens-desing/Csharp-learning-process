namespace sinema_büfe_satış_uygulaması
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int kasa = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            int bilet, su, mısır, cay, toplam;
            bilet = Convert.ToInt16(textBox1.Text);
            su = Convert.ToInt16(textBox2.Text);
            mısır = Convert.ToInt16(textBox3.Text);
            cay = Convert.ToInt16(textBox4.Text);
            toplam = bilet * 120 + su * 15 + mısır * 50 + cay * 20;
            kasa = kasa + toplam;
            label12.Text = toplam.ToString() + " TL";
            label10.Text = kasa.ToString() + " TL";
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            label12.Text = "";
            textBox1.Focus();
        }
    }
}
