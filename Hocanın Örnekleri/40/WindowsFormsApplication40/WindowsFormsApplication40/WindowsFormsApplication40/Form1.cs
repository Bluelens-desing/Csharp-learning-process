using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication40
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
                listBox1.Items.Add(checkBox1.Text);
            if (checkBox2.Checked == true)
                listBox1.Items.Add(checkBox2.Text);
            if (checkBox3.Checked == true)
                listBox1.Items.Add(checkBox3.Text);
            if (checkBox4.Checked == true)
                listBox1.Items.Add(checkBox4.Text);
            if (checkBox5.Checked == true)
                listBox1.Items.Add(checkBox5.Text);
            if (checkBox6.Checked == true)
                listBox1.Items.Add(checkBox6.Text);

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
                listBox1.Items.Add(checkBox1.Text);
            else
                listBox1.Items.Remove(checkBox1.Text);
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked == true)
                listBox1.Items.Add(checkBox2.Text);
            else
                listBox1.Items.Remove(checkBox2.Text);
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox3.Checked == true)
                listBox1.Items.Add(checkBox3.Text);
            else
                listBox1.Items.Remove(checkBox3.Text);
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox4.Checked == true)
                listBox1.Items.Add(checkBox4.Text);
            else
                listBox1.Items.Remove(checkBox4.Text);
        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox5.Checked == true)
                listBox1.Items.Add(checkBox5.Text);
            else
                listBox1.Items.Remove(checkBox5.Text);
        }

        private void checkBox6_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox6.Checked == true)
                listBox1.Items.Add(checkBox6.Text);
            else
                listBox1.Items.Remove(checkBox6.Text);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)  //cinsiyeti
                label3.Text = radioButton1.Text;
            else if (radioButton2.Checked == true)
                label3.Text = radioButton2.Text;
            else if (radioButton3.Checked == true)
                label3.Text = radioButton3.Text;

            if (radioButton4.Checked == true)    //medeni durumu
                label5.Text = radioButton4.Text;
            else if (radioButton5.Checked == true)
                label5.Text = radioButton5.Text;
            else if (radioButton6.Checked == true)
                label5.Text = radioButton6.Text;
            else if(radioButton7.Checked == true)
                label5.Text = radioButton7.Text;
        }

        private void checkBox7_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox7.Checked == true)
            {
                checkBox8.Checked = false;
                checkBox9.Checked = false;
            }
        }

        private void checkBox8_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox8.Checked == true)
            {
                checkBox7.Checked = false;
                checkBox9.Checked = false;
            }
        }

        private void checkBox9_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox9.Checked == true)
            {
                checkBox8.Checked = false;
                checkBox7.Checked = false;
            }
        }
    }
}
