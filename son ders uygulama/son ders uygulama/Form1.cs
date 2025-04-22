namespace son_ders_uygulama
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            dataGridView1.Columns.Add("TC", "TC");
            dataGridView1.Columns.Add("AD SOYAD", "AD SOYAD");
            dataGridView1.Columns.Add("DTARÝH", "DTARÝH");
            dataGridView1.Columns.Add("POLÝKLÝNÝK", "POLÝKLÝNÝK");
            dataGridView1.Columns.Add("TLFNO", "TLFNO");
            dataGridView1.Columns.Add("ADRES", "ADRES");
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string tc, adsoyad, dtarih, poliknilik, tlf, adres;
            tc = textBox1.Text;
            adsoyad = textBox2.Text;
            dtarih = textBox3.Text;
            poliknilik = textBox4.Text;
            tlf = textBox5.Text;
            adres = richTextBox1.Text;

            dataGridView1.Rows.Add(tc, adsoyad, dtarih, poliknilik, tlf, adres);

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            richTextBox1.Text = "";
        }
    }
}
