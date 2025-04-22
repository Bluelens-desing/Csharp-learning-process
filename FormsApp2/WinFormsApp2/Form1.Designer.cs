namespace WinFormsApp2
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            comboBox1 = new ComboBox();
            button1 = new Button();
            button2 = new Button();
            textBox1 = new TextBox();
            label1 = new Label();
            listBox1 = new ListBox();
            button3 = new Button();
            button4 = new Button();
            textBox2 = new TextBox();
            listBox2 = new ListBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            textBox5 = new TextBox();
            textBox6 = new TextBox();
            textBox7 = new TextBox();
            button5 = new Button();
            progressBar1 = new ProgressBar();
            button6 = new Button();
            button7 = new Button();
            SuspendLayout();
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Bursa", "Ankara", "Niğde", "Mersin", "Gaziantep", "Kütahya", "Elazığ", "İstanbul", "Adana", "Van" });
            comboBox1.Location = new Point(782, 20);
            comboBox1.Margin = new Padding(4);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(276, 32);
            comboBox1.TabIndex = 0;
            // 
            // button1
            // 
            button1.Location = new Point(800, 58);
            button1.Name = "button1";
            button1.Size = new Size(244, 61);
            button1.TabIndex = 1;
            button1.Text = "Şehir ekle";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(118, 58);
            button2.Name = "button2";
            button2.Size = new Size(189, 40);
            button2.TabIndex = 2;
            button2.Text = "Kendin ekle";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(90, 20);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(244, 32);
            textBox1.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 20);
            label1.Name = "label1";
            label1.Size = new Size(59, 24);
            label1.TabIndex = 4;
            label1.Text = "Şehir:";
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 24;
            listBox1.Items.AddRange(new object[] { "mühendis", "öğretmen", "hemşire" });
            listBox1.Location = new Point(12, 104);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(154, 292);
            listBox1.TabIndex = 5;
            // 
            // button3
            // 
            button3.Location = new Point(12, 402);
            button3.Name = "button3";
            button3.Size = new Size(154, 50);
            button3.TabIndex = 6;
            button3.Text = "Meslek ekle";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Location = new Point(371, 58);
            button4.Name = "button4";
            button4.Size = new Size(214, 89);
            button4.TabIndex = 7;
            button4.Text = "kendin meslek ekle";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(371, 20);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(214, 32);
            textBox2.TabIndex = 8;
            // 
            // listBox2
            // 
            listBox2.FormattingEnabled = true;
            listBox2.ItemHeight = 24;
            listBox2.Location = new Point(235, 175);
            listBox2.Name = "listBox2";
            listBox2.Size = new Size(566, 28);
            listBox2.TabIndex = 9;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(279, 222);
            label2.Name = "label2";
            label2.Size = new Size(69, 24);
            label2.TabIndex = 10;
            label2.Text = "Adınız:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(250, 259);
            label3.Name = "label3";
            label3.Size = new Size(98, 24);
            label3.TabIndex = 11;
            label3.Text = "Soyadınız:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(243, 296);
            label4.Name = "label4";
            label4.Size = new Size(105, 24);
            label4.TabIndex = 12;
            label4.Text = "Mesleğiniz:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(235, 334);
            label5.Name = "label5";
            label5.Size = new Size(111, 24);
            label5.TabIndex = 13;
            label5.Text = "Telefon NO:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(243, 372);
            label6.Name = "label6";
            label6.Size = new Size(100, 24);
            label6.TabIndex = 14;
            label6.Text = "Memleket:";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(354, 219);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(153, 32);
            textBox3.TabIndex = 15;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(354, 256);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(153, 32);
            textBox4.TabIndex = 16;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(354, 331);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(153, 32);
            textBox5.TabIndex = 18;
            // 
            // textBox6
            // 
            textBox6.Location = new Point(354, 293);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(153, 32);
            textBox6.TabIndex = 17;
            // 
            // textBox7
            // 
            textBox7.Location = new Point(354, 369);
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(153, 32);
            textBox7.TabIndex = 19;
            // 
            // button5
            // 
            button5.Location = new Point(354, 422);
            button5.Name = "button5";
            button5.Size = new Size(153, 44);
            button5.TabIndex = 20;
            button5.Text = "Bilgileri kaydet";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // progressBar1
            // 
            progressBar1.Location = new Point(694, 293);
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(202, 159);
            progressBar1.TabIndex = 21;
            // 
            // button6
            // 
            button6.Location = new Point(684, 471);
            button6.Name = "button6";
            button6.Size = new Size(94, 29);
            button6.TabIndex = 22;
            button6.Text = "+";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // button7
            // 
            button7.Location = new Point(821, 469);
            button7.Name = "button7";
            button7.Size = new Size(94, 29);
            button7.TabIndex = 23;
            button7.Text = "-";
            button7.UseVisualStyleBackColor = true;
            button7.Click += button7_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(11F, 24F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.AppWorkspace;
            ClientSize = new Size(1100, 540);
            Controls.Add(button7);
            Controls.Add(button6);
            Controls.Add(progressBar1);
            Controls.Add(button5);
            Controls.Add(textBox7);
            Controls.Add(textBox5);
            Controls.Add(textBox6);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(listBox2);
            Controls.Add(textBox2);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(listBox1);
            Controls.Add(label1);
            Controls.Add(textBox1);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(comboBox1);
            Font = new Font("Corbel", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            Margin = new Padding(4);
            Name = "Form1";
            Text = "ARAÇ kutusu";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox comboBox1;
        private Button button1;
        private Button button2;
        private TextBox textBox1;
        private Label label1;
        private ListBox listBox1;
        private Button button3;
        private Button button4;
        private TextBox textBox2;
        private ListBox listBox2;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox textBox3;
        private TextBox textBox4;
        private TextBox textBox5;
        private TextBox textBox6;
        private TextBox textBox7;
        private Button button5;
        private ProgressBar progressBar1;
        private Button button6;
        private Button button7;
    }
}
