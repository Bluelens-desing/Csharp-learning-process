namespace sınıflar
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Araba rb = new Araba();
            rb.renk = "mavi";
            rb.hiz = 160;
            rb.motor = 1245.56;
            rb.fiyat = 50000;
            rb.durum = 's';
            rb.YIL = -2016;
            rb.MARKASI = "Golf";
            rb.plaka = "33AUT083";
            rb.muayene = 2024;
            rb.sahip = "Mümtaz Şahin";

            label1.Text = rb.renk;
            label2.Text = rb.hiz.ToString();
            label3.Text = rb.motor.ToString();
            label4.Text = rb.fiyat.ToString();
            label5.Text = rb.durum.ToString();
            label6.Text = rb.YIL.ToString();
            label7.Text = rb.MARKASI;
            label8.Text = rb.plaka;
            label9.Text = rb.muayene.ToString();
            label10.Text = rb.sahip;

            pictureBox1.BackColor = Color.Blue;
            panel1.BackColor = Color.Blue;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 araba15 = new Form2();
            araba15.Show();
        }
    }
}
