namespace _4_işlem
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int sayi1, sayi2, toplam, fark, carpım, bolum;
            sayi1 = Convert.ToInt16(textBox1.Text);
            sayi2 = Convert.ToInt16(textBox2.Text);
            toplam = sayi1 + sayi2;
            fark = sayi1 - sayi2;
            carpım = sayi1 * sayi2;
            bolum = sayi1 / sayi2;
            MessageBox.Show("Toplam:" + toplam + "\nFark:" + fark + "\nÇarpım:" + carpım + "\nBölüm:" + bolum);

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            double not1, not2, not3, ortalama;
            string ad, soyad;
            ad = textBox6.Text;
            soyad = textBox7.Text;
            not1 = Convert.ToDouble(textBox3.Text);
            not2 = Convert.ToDouble(textBox4.Text);
            not3 = Convert.ToDouble(textBox5.Text);
            ortalama = (not1 + not2 + not3) / 3;
            listBox1.Items.Add(ad + " " + soyad + " " + "ortalama:" + ortalama);
        }
    }
}
