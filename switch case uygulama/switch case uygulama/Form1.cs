using System.Collections;

namespace switch_case_uygulama
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int ay = Convert.ToInt16(textBox1.Text);
            switch (ay)
            {
                case 1: label2.Text = "Ocak"; break;
                case 2: label2.Text = "Þubat"; break;
                case 3: label2.Text = "Mart"; break;
                case 4: label2.Text = "Nisan"; break;
                case 5: label2.Text = "Mayýs"; break;
                case 6: label2.Text = "Haziran"; break;
                case 7: label2.Text = "Temmuz"; break;
                case 8: label2.Text = "Aðustos"; break;
                case 9: label2.Text = "Eylül"; break;
                case 10: label2.Text = "Ekim"; break;
                case 11: label2.Text = "Kasým"; break;
                case 12: label2.Text = "Aralýk"; break;
                default: label2.Text = "hatalý ay"; break;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string mevsim = textBox2.Text;
            switch (mevsim)
            {
                case "yaz": label3.Text = "haziran,temmuz,aðustos"; break;
                case "sonbahar": label3.Text = "eylül,ekim,kasým"; break;
                case "kýþ": label3.Text = "aralýk,ocak,þubat"; break;
                case "ilkbahar": label3.Text = "mart,nisan,mayýs"; break;
                default: label3.Text = "yanlýþ mevsim"; break;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int sayý1, sayý2, sonuç;
            char iþlem;
                sayý1 = Convert.ToInt16(textBox3.Text);
            sayý2 = Convert.ToInt16(textBox4.Text);
            iþlem = Convert.ToChar(textBox5.Text);
            switch (iþlem)
            {
                case '+':
                    {
                        sonuç = sayý1 + sayý2;
                        label5.Text = sonuç.ToString(); break;
                    }
                case '-':
                    {
                        sonuç = sayý1 - sayý2;
                        label5.Text = sonuç.ToString(); break;
                    }
                case '*':
                    {
                        sonuç = sayý1 * sayý2;
                        label5.Text = sonuç.ToString(); break;
                    }
                case '/':
                    {
                        sonuç = sayý1 / sayý2;
                        label5.Text = sonuç.ToString(); break;
                    }
                default:
                    {
                        label5.Text = "yanlýþ karakter";break;
                     }
            }
        }
    }
}
