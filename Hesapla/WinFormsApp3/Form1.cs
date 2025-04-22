namespace WinFormsApp3
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
            label4.Text = Convert.ToString(Convert.ToInt32(textBox1.Text) + Convert.ToInt32(textBox2.Text));
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label5.Text = Convert.ToString(Convert.ToInt32(textBox4.Text) - Convert.ToInt32(textBox3.Text));
        }

        private void button3_Click(object sender, EventArgs e)
        {
            label8.Text = Convert.ToString(Convert.ToInt32(textBox6.Text) * Convert.ToInt32(textBox5.Text));
        }

        private void button4_Click(object sender, EventArgs e)
        {
            label11.Text = Convert.ToString(Convert.ToInt32(textBox8.Text) / Convert.ToInt32(textBox7.Text));
        }

        private void button5_Click(object sender, EventArgs e)
        {
            label14.Text = Convert.ToString(Convert.ToInt32(textBox10.Text) % Convert.ToInt32(textBox9.Text));
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text == "TOPLAMA")
            {
                textBox13.Text = Convert.ToString(Convert.ToInt32(textBox12.Text) + Convert.ToInt32(textBox11.Text));
            }
            else if (comboBox1.Text == "ÇIRKARMA")
            {
                textBox13.Text = Convert.ToString(Convert.ToInt32(textBox12.Text) - Convert.ToInt32(textBox11.Text));
            }
            else if (comboBox1.Text == "ÇARPMA")
            {
                textBox13.Text = Convert.ToString(Convert.ToInt32(textBox12.Text) * Convert.ToInt32(textBox11.Text));
            }
            else if (comboBox1.Text == "BÖLME")
            {
                textBox13.Text = Convert.ToString(Convert.ToInt32(textBox12.Text) / Convert.ToInt32(textBox11.Text));
            }
        }
    }
}
