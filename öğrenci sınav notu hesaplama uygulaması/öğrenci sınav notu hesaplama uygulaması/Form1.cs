namespace öğrenci_sınav_notu_hesaplama_uygulaması
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string ad, soyad;
            double s1, s2, pro, ort;
            ad = textBox1.Text;
            soyad = textBox2.Text;
            s1 = Convert.ToDouble(textBox3.Text);
            s2 = Convert.ToDouble(textBox4.Text);
            pro = Convert.ToDouble(textBox5.Text);
            ort = (s1 + s2 + pro) / 3;
            listBox1.Items.Add (ad +" "+ soyad + " : " + ort);
        }
    }
}
