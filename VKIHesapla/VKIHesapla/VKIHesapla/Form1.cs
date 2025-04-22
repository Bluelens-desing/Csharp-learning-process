using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace VKIHesapla
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void HesaplaBtn_Click(object sender, EventArgs e)
        {
            int boy, kilo, vki;
            boy = Convert.ToInt32(BoytextBox.Text);
            kilo = Convert.ToInt32(KilotextBox.Text);
            vki = kilo / (boy * boy);
            VHItextBox.Text = vki.ToString();
            if (vki < 18)
            {
                DurumtextBox.Text = "Zayıf";
            }
            else if (vki >= 18 && vki < 25)
            {
                DurumtextBox.Text = "Normal";
            }
            else if (vki >= 25 && vki < 30)
            {
                DurumtextBox.Text = "Kilolu";
            }
            else if (vki >= 30 && vki < 35)
            {
                DurumtextBox.Text = "Obez";
            }
            else
            {
                DurumtextBox.Text = "Ciddi Obez";
            }
        }

        private void TemizleBtn_Click(object sender, EventArgs e)
        {
            BoytextBox.Clear();
            KilotextBox.Clear();
            VHItextBox.Text = "";
            DurumtextBox.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int sayi = Convert.ToInt32(SayitextBox.Text);

                if (sayi < 0)
                {
                    MessageBox.Show("Faktöriyel hesaplamak için pozitif bir tam sayı girmelisiniz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                long faktoriyel = FaktoriyelHesapla(sayi);
                textBox1.Text = $"{faktoriyel}";
            }
            catch (FormatException)
            {
                MessageBox.Show("Lütfen geçerli bir tam sayı girin.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (OverflowException)
            {
                MessageBox.Show("Girdiğiniz sayı çok büyük, daha küçük bir sayı deneyin.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private long FaktoriyelHesapla(int sayi)
        {
            if (sayi == 0 || sayi == 1)
                return 1;
            else
                return sayi * FaktoriyelHesapla(sayi - 1);
        }

        private void BoytextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
    

