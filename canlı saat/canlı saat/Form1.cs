namespace canlı_saat
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int sayac = 1;
        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            sayac++;
            label1.Text = DateTime.Now.Hour.ToString();
            label2.Text = DateTime.Now.Minute.ToString();
            label3.Text = DateTime.Now.Second.ToString();

            label4.Text = label1.Text + "." + label2.Text + "." + label3.Text;

            if (Convert.ToDecimal(DateTime.Now.Second) % 2 == 0) 
            {
                label4.BackColor = Color.Blue;
                label1.BackColor = Color.Red;
                label2.BackColor = Color.Yellow;
                label3.BackColor = Color.Green;
            }
            else
            {
                label4.BackColor = Color.Red;
                label1.BackColor = Color.Yellow;
                label2.BackColor = Color.Green;
                label3.BackColor = Color.Blue;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            timer1.Enabled= false;
        }
    }
}
