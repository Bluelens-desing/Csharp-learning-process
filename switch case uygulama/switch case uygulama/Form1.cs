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
                case 2: label2.Text = "�ubat"; break;
                case 3: label2.Text = "Mart"; break;
                case 4: label2.Text = "Nisan"; break;
                case 5: label2.Text = "May�s"; break;
                case 6: label2.Text = "Haziran"; break;
                case 7: label2.Text = "Temmuz"; break;
                case 8: label2.Text = "A�ustos"; break;
                case 9: label2.Text = "Eyl�l"; break;
                case 10: label2.Text = "Ekim"; break;
                case 11: label2.Text = "Kas�m"; break;
                case 12: label2.Text = "Aral�k"; break;
                default: label2.Text = "hatal� ay"; break;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string mevsim = textBox2.Text;
            switch (mevsim)
            {
                case "yaz": label3.Text = "haziran,temmuz,a�ustos"; break;
                case "sonbahar": label3.Text = "eyl�l,ekim,kas�m"; break;
                case "k��": label3.Text = "aral�k,ocak,�ubat"; break;
                case "ilkbahar": label3.Text = "mart,nisan,may�s"; break;
                default: label3.Text = "yanl�� mevsim"; break;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int say�1, say�2, sonu�;
            char i�lem;
                say�1 = Convert.ToInt16(textBox3.Text);
            say�2 = Convert.ToInt16(textBox4.Text);
            i�lem = Convert.ToChar(textBox5.Text);
            switch (i�lem)
            {
                case '+':
                    {
                        sonu� = say�1 + say�2;
                        label5.Text = sonu�.ToString(); break;
                    }
                case '-':
                    {
                        sonu� = say�1 - say�2;
                        label5.Text = sonu�.ToString(); break;
                    }
                case '*':
                    {
                        sonu� = say�1 * say�2;
                        label5.Text = sonu�.ToString(); break;
                    }
                case '/':
                    {
                        sonu� = say�1 / say�2;
                        label5.Text = sonu�.ToString(); break;
                    }
                default:
                    {
                        label5.Text = "yanl�� karakter";break;
                     }
            }
        }
    }
}
