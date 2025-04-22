using System.Security.Cryptography;

namespace metotlar
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        void temizle()
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox1.Focus();
        }
        void renklendir()
        {
            textBox1.BackColor = Color.Pink;
            textBox2.BackColor = Color.Red;
            textBox3.BackColor = Color.Green;
            textBox4.BackColor = Color.Blue;
        }
        void boyatemizle()
        {
            textBox2.BackColor = Color.White;
            textBox3.BackColor = Color.White;
            textBox4.BackColor = Color.White;
            textBox1.BackColor = Color.White;
        }
        void bilgiler()
        {
            textBox1.Text = "Mustafa";
            textBox2.Text = "Þahin";
            textBox3.Text = "5392386796";
            textBox4.Text = "pcMÜH";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            temizle();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            renklendir();
            bilgiler();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            boyatemizle();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
            panel2.BackColor = Color.Brown;
        }
        int topla(int s1, int s2)
        {
            int s3 = s1 + s2;
            return s3;
        }
        int carp(int s1, int s2)
        {
            int s3 = s1 * s2;
            return s3;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            label1.Text = topla(Convert.ToInt16(textBox5.Text), Convert.ToInt16(textBox6.Text)).ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int deger;
            deger = carp(Convert.ToUInt16(textBox7.Text), Convert.ToUInt16(textBox8.Text));
            label2.Text = deger.ToString();
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {
            panel3.BackColor = Color.Purple;
        }
        int küp(int s1)
        {
            int küp = s1 * s1 * s1;
            return küp;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            label3.Text = küp(Convert.ToInt16(textBox10.Text)).ToString();
            textBox10.Text = "";
            textBox10.Focus();
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void panel4_Paint_1(object sender, PaintEventArgs e)
        {
            panel4.BackColor = Color.Yellow;
        }
    }
}
