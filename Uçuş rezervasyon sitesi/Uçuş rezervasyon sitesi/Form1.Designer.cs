namespace Uçuş_rezervasyon_sitesi
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
            groupBox1 = new GroupBox();
            maskedTextBox1 = new MaskedTextBox();
            label4 = new Label();
            dateTimePicker1 = new DateTimePicker();
            comboBox2 = new ComboBox();
            comboBox1 = new ComboBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            groupBox2 = new GroupBox();
            button1 = new Button();
            maskedTextBox3 = new MaskedTextBox();
            maskedTextBox2 = new MaskedTextBox();
            textBox1 = new TextBox();
            label7 = new Label();
            label5 = new Label();
            label6 = new Label();
            panel1 = new Panel();
            label8 = new Label();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(maskedTextBox1);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(dateTimePicker1);
            groupBox1.Controls.Add(comboBox2);
            groupBox1.Controls.Add(comboBox1);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label3);
            groupBox1.Location = new Point(13, 180);
            groupBox1.Margin = new Padding(4, 5, 4, 5);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(4, 5, 4, 5);
            groupBox1.Size = new Size(557, 457);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Uçuş bilgileri";
            // 
            // maskedTextBox1
            // 
            maskedTextBox1.Location = new Point(140, 275);
            maskedTextBox1.Mask = "00:00";
            maskedTextBox1.Name = "maskedTextBox1";
            maskedTextBox1.Size = new Size(248, 46);
            maskedTextBox1.TabIndex = 8;
            maskedTextBox1.ValidatingType = typeof(DateTime);
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(72, 278);
            label4.Margin = new Padding(5, 0, 5, 0);
            label4.Name = "label4";
            label4.Size = new Size(58, 38);
            label4.TabIndex = 7;
            label4.Text = "Saat :";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(138, 214);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(250, 46);
            dateTimePicker1.TabIndex = 7;
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Items.AddRange(new object[] { "Ankara", "Bursa", "Adana ", "Elazığ", "Samsun" });
            comboBox2.Location = new Point(138, 145);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(250, 46);
            comboBox2.TabIndex = 6;
            comboBox2.SelectedIndexChanged += comboBox2_SelectedIndexChanged;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Ankara", "Bursa", "Adana ", "Elazığ", "Samsun" });
            comboBox1.Location = new Point(140, 81);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(248, 46);
            comboBox1.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Javanese Text", 10.8F);
            label1.Location = new Point(34, 82);
            label1.Margin = new Padding(5, 0, 5, 0);
            label1.Name = "label1";
            label1.Size = new Size(96, 41);
            label1.TabIndex = 2;
            label1.Text = "Nereden :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Javanese Text", 10.8F);
            label2.Location = new Point(45, 150);
            label2.Margin = new Padding(5, 0, 5, 0);
            label2.Name = "label2";
            label2.Size = new Size(85, 41);
            label2.TabIndex = 3;
            label2.Text = "Nereye :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(66, 214);
            label3.Margin = new Padding(5, 0, 5, 0);
            label3.Name = "label3";
            label3.Size = new Size(64, 38);
            label3.TabIndex = 4;
            label3.Text = "Tarih :";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(button1);
            groupBox2.Controls.Add(maskedTextBox3);
            groupBox2.Controls.Add(maskedTextBox2);
            groupBox2.Controls.Add(textBox1);
            groupBox2.Controls.Add(label7);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(label6);
            groupBox2.Location = new Point(604, 180);
            groupBox2.Margin = new Padding(4, 5, 4, 5);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(4, 5, 4, 5);
            groupBox2.Size = new Size(595, 457);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Yolcu bilgileri";
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(192, 255, 192);
            button1.Font = new Font("Verdana", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(190, 282);
            button1.Name = "button1";
            button1.Size = new Size(248, 68);
            button1.TabIndex = 13;
            button1.Text = "Kaydet";
            button1.UseVisualStyleBackColor = false;
            // 
            // maskedTextBox3
            // 
            maskedTextBox3.Location = new Point(190, 206);
            maskedTextBox3.Mask = "(999) 000-0000";
            maskedTextBox3.Name = "maskedTextBox3";
            maskedTextBox3.Size = new Size(248, 46);
            maskedTextBox3.TabIndex = 12;
            // 
            // maskedTextBox2
            // 
            maskedTextBox2.Location = new Point(190, 145);
            maskedTextBox2.Mask = "00000000000";
            maskedTextBox2.Name = "maskedTextBox2";
            maskedTextBox2.Size = new Size(248, 46);
            maskedTextBox2.TabIndex = 11;
            maskedTextBox2.ValidatingType = typeof(int);
            // 
            // textBox1
            // 
            textBox1.Location = new Point(190, 82);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(248, 46);
            textBox1.TabIndex = 9;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(81, 214);
            label7.Margin = new Padding(5, 0, 5, 0);
            label7.Name = "label7";
            label7.Size = new Size(101, 38);
            label7.TabIndex = 7;
            label7.Text = "Telefon NO";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(50, 152);
            label5.Margin = new Padding(5, 0, 5, 0);
            label5.Name = "label5";
            label5.Size = new Size(132, 38);
            label5.TabIndex = 6;
            label5.Text = "TC Kimlik NO :";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(43, 84);
            label6.Margin = new Padding(5, 0, 5, 0);
            label6.Name = "label6";
            label6.Size = new Size(139, 38);
            label6.TabIndex = 5;
            label6.Text = "Yolcu Ad Soyad :";
            // 
            // panel1
            // 
            panel1.BackColor = Color.Red;
            panel1.Controls.Add(label8);
            panel1.Location = new Point(-21, -1);
            panel1.Name = "panel1";
            panel1.Size = new Size(1263, 154);
            panel1.TabIndex = 2;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Lucida Calligraphy", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.Location = new Point(68, 45);
            label8.Name = "label8";
            label8.Size = new Size(474, 52);
            label8.TabIndex = 0;
            label8.Text = "Jupiter Hava Yolları";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 38F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkGray;
            ClientSize = new Size(1209, 738);
            Controls.Add(panel1);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Font = new Font("Javanese Text", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4, 5, 4, 5);
            Name = "Form1";
            Text = "Bilmem ney uçuş sayfası";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Label label1;
        private Label label2;
        private Label label3;
        private GroupBox groupBox2;
        private Label label4;
        private Label label5;
        private Label label6;
        private DateTimePicker dateTimePicker1;
        private ComboBox comboBox2;
        private ComboBox comboBox1;
        private MaskedTextBox maskedTextBox1;
        private TextBox textBox1;
        private Label label7;
        private MaskedTextBox maskedTextBox3;
        private MaskedTextBox maskedTextBox2;
        private Button button1;
        private Panel panel1;
        private Label label8;
    }
}
