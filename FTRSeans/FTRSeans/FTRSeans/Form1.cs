using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace FTRSeans
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            dataGridView1.Columns.Add("TC", "TC");
            dataGridView1.Columns.Add("AdSoyad", "Ad Soyad");
            dataGridView1.Columns.Add("DogumTarihi", "Doğum Tarihi");
            dataGridView1.Columns.Add("Poliklinik", "Poliklinik");
            dataGridView1.Columns.Add("Telefon", "Telefon");
            dataGridView1.Columns.Add("Adres", "Adres");
        }

        private void btnkaydet_Click(object sender, EventArgs e)
        {
            string tc = txtTC.Text;
            string adi = txtadsoyad.Text;
            string dt = txtdt.Text;
            string pol = cbpol.Text;
            string tlf = txttlf.Text;
            string adres = richTextBox1.Text;

            dataGridView1.Rows.Add(tc, adi, dt, pol,tlf, adres);
            listBox1.Items.Add("Hasta Adı Soyadı :"+txtadsoyad.Text);

        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            txtTC.Clear();
            txtadsoyad.Clear();
            txtdt.Clear();
            cbpol.SelectedIndex = -1;
            richTextBox1.Clear();

        }

        private void btnSeans_Click(object sender, EventArgs e)
        {
            // Kullanıcıdan seans sayısı ve gün aralığını alma
            int gun = Convert.ToInt32(txtgun.Text);
            int seansSayisi = Convert.ToInt32(txtSeans.Text);

            // Başlangıç tarihini belirleme
            DateTime baslangic = DateTime.Now;
          

            for (int i = 0; i < seansSayisi; i++)
            {
                int kacinci = i + 1;
                DateTime seansTarihi = baslangic.AddDays(i * gun);
                string deg = $"{kacinci}. Seans: {seansTarihi.ToShortDateString()}";

                // ListBox'a seans tarihini ekleme
                listBox1.Items.Add(deg);

            }
            }
        }
            
        }
    

