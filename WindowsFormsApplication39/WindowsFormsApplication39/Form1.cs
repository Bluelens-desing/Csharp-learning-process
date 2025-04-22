using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication39
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter  || e.KeyCode==Keys.Down)
                textBox2.Focus();

        }

        private void textBox2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Down)
                maskedTextBox1.Focus();
            if (e.KeyCode == Keys.Up)
                textBox1.Focus();
        }

        private void maskedTextBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Down)
                maskedTextBox2.Focus();
            if (e.KeyCode == Keys.Up)
                textBox2.Focus();
        }

        private void maskedTextBox2_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Up)
                maskedTextBox1.Focus();
        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            textBox1.BackColor = Color.Yellow;
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            textBox1.BackColor = Color.White;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(textBox1.Text + " " + textBox2.Text + " " + maskedTextBox1.Text + " " + maskedTextBox2.Text);

            listBox2.Items.Add(textBox1.Text);
            listBox3.Items.Add(textBox2.Text);
            listBox4.Items.Add(maskedTextBox1.Text);
            listBox5.Items.Add(maskedTextBox2.Text);
        
        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            listBox1.SelectedIndex = listBox2.SelectedIndex;
            
            listBox3.SelectedIndex = listBox2.SelectedIndex;
            listBox4.SelectedIndex = listBox2.SelectedIndex;
            listBox5.SelectedIndex = listBox2.SelectedIndex;

        }

        private void listBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            listBox1.SelectedIndex = listBox3.SelectedIndex;
            
            listBox2.SelectedIndex = listBox3.SelectedIndex;
            listBox4.SelectedIndex = listBox3.SelectedIndex;
            listBox5.SelectedIndex = listBox3.SelectedIndex;
        }

        private void listBox4_SelectedIndexChanged(object sender, EventArgs e)
        {
            listBox1.SelectedIndex = listBox4.SelectedIndex;
            
            listBox2.SelectedIndex = listBox4.SelectedIndex;
            listBox3.SelectedIndex = listBox4.SelectedIndex;
            listBox5.SelectedIndex = listBox4.SelectedIndex;
        }

        private void listBox5_SelectedIndexChanged(object sender, EventArgs e)
        {
            listBox1.SelectedIndex = listBox5.SelectedIndex;
            
            listBox2.SelectedIndex = listBox5.SelectedIndex;
            listBox3.SelectedIndex = listBox5.SelectedIndex;
            listBox4.SelectedIndex = listBox5.SelectedIndex;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox6.Items.Add(textBox4.Text);
            comboBox1.Items.Add(textBox4.Text);
            textBox4.Text = "";
            textBox4.Focus();
        }

        private void textBox4_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                button2_Click(sender, e);
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
           // listBox6.Sorted = true;
          //  comboBox1.Sorted = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            listBox6.Sorted = true;
            comboBox1.Sorted = true;

        }

        private void listBox6_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listBox6_Click(object sender, EventArgs e)
        {
            textBox5.Text = listBox6.Text;   //liste eleman değeri
            textBox6.Text = listBox6.SelectedIndex.ToString();   //indeksi
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (listBox7.Items.Count < 5)
            {
                listBox7.Items.Add(listBox6.Text);
                label9.Text = "TOP.TERCİH SAYISI: " + listBox7.Items.Count.ToString();
            }
            else
                MessageBox.Show("Tercih hakkınız dolmuştur.");
        }

        private void listBox6_DoubleClick(object sender, EventArgs e)
        {
            button4_Click(sender, e);
        }

        private void listBox7_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            listBox7.Items.RemoveAt(listBox7.SelectedIndex);
            label9.Text = "TOP.TERCİH SAYISI: " + listBox7.Items.Count.ToString();

        }

        private void listBox7_DoubleClick(object sender, EventArgs e)
        {
            button5_Click(sender, e);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
