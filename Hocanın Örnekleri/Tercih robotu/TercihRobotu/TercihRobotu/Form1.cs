using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TercihRobotu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(textBox1.Text);
        }

        private void button1_Click(object sender, EventArgs e)
        {
          //  listBox1.Items.Clear();
         //   listBox2.Items.Clear();
         textBox1.Clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex != -1)
            {
                listBox2.Items.Add(listBox1.SelectedItem); // Seçili olanı aktar
                listBox1.Items.Remove(listBox1.SelectedItem); //Seçili olanı sil
            }
            else
            {
                MessageBox.Show("Lütfen seçim yapın.");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (listBox2.SelectedIndex != -1)
            {
                listBox1.Items.Add(listBox2.SelectedItem); // Seçili olanı aktar
                listBox2.Items.Remove(listBox2.SelectedItem); //Seçili olanı sil
            }
            else
            {
                MessageBox.Show("Lütfen seçim yapın.");
            }
        }
    }
}
