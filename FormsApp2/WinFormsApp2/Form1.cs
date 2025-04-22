namespace WinFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            comboBox1.Items.Add("Antalya");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            comboBox1.Items.Add(textBox1.Text);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add("doktor");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(textBox2.Text);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            listBox2.Items.Add(textBox3.Text + textBox4.Text + textBox5.Text + textBox6.Text + textBox7.Text);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            progressBar1.Value += 10;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            progressBar1.Value -= 10;
        }
    }
}
