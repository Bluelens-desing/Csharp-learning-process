namespace mat_fonksiyonları
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox2.Text = Math.Abs(Convert.ToInt32(textBox1.Text)).ToString();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            textBox3.BackColor = Color.AliceBlue;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            double r = Convert.ToDouble(textBox3.Text);
            textBox3.Text = Convert.ToString(r * Math.PI * 2);
            textBox4.Text = (Math.PI * Math.Pow(r, 2)).ToString();

        }
        double kare(int s1)
        {
            double s2 = Math.Pow(s1, 2);
            return s2;
        }
        double küp(int s1)
        {
            double s2 = Math.Pow(s1, 3);
            return s2;
        }
        private void button3_Click(object sender, EventArgs e)
        {
            int sayı;
            sayı = Convert.ToInt32(textBox5.Text);
            textBox5.Text = kare(sayı).ToString();
            textBox6.Text = küp(sayı).ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            double sayı1;
            sayı1 = Convert.ToDouble(textBox7.Text);
            textBox7.Text = Math.Sqrt(sayı1).ToString();
            textBox8.Text = Math.Pow(sayı1, 1.0 / 3.0).ToString();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            int sayı1, sayı2;
            sayı1 = Convert.ToInt32(textBox9.Text);
            sayı2 = Convert.ToInt32(textBox10.Text);
            button5.Text = Math.Max(Convert.ToInt16(sayı1), Convert.ToInt16(sayı2)).ToString();
            button6.Text = "MİN";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            int sayı1, sayı2;
            sayı1 = Convert.ToInt32(textBox9.Text);
            sayı2 = Convert.ToInt32(textBox10.Text);
            button6.Text = Math.Min(Convert.ToUInt16(sayı1), Convert.ToInt16(sayı2)).ToString();
            button5.Text = "MAX";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox10.Text = "";
            textBox9.Text = "";
            button5.Text = "MAX";
            button6.Text = "MİN";
        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBox12.Text = Math.Sin(Convert.ToDouble(textBox11.Text)).ToString();
            textBox13.Text = Math.Cos(Convert.ToDouble(textBox11.Text)).ToString();
            textBox14.Text = Math.Tan(Convert.ToDouble(textBox11.Text)).ToString();
        }
    }
}
