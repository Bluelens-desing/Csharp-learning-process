namespace öğrenci_sınav_notu_hesaplama_uygulaması
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            label1 = new Label();
            label2 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            label3 = new Label();
            label4 = new Label();
            textBox4 = new TextBox();
            textBox5 = new TextBox();
            label5 = new Label();
            pictureBox1 = new PictureBox();
            listBox1 = new ListBox();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(35, 27);
            label1.Margin = new Padding(5, 0, 5, 0);
            label1.Name = "label1";
            label1.Size = new Size(54, 27);
            label1.TabIndex = 0;
            label1.Text = "Adı:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(35, 73);
            label2.Margin = new Padding(5, 0, 5, 0);
            label2.Name = "label2";
            label2.Size = new Size(87, 27);
            label2.TabIndex = 1;
            label2.Text = "Soyadı:";
            // 
            // textBox1
            // 
            textBox1.BackColor = SystemColors.ScrollBar;
            textBox1.Location = new Point(132, 20);
            textBox1.Margin = new Padding(5, 4, 5, 4);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(216, 34);
            textBox1.TabIndex = 2;
            // 
            // textBox2
            // 
            textBox2.BackColor = SystemColors.ScrollBar;
            textBox2.Location = new Point(132, 62);
            textBox2.Margin = new Padding(5, 4, 5, 4);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(216, 34);
            textBox2.TabIndex = 3;
            // 
            // textBox3
            // 
            textBox3.BackColor = SystemColors.ScrollBar;
            textBox3.Location = new Point(104, 148);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(40, 34);
            textBox3.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 151);
            label3.Name = "label3";
            label3.Size = new Size(86, 27);
            label3.TabIndex = 7;
            label3.Text = "Sınav1:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(237, 151);
            label4.Name = "label4";
            label4.Size = new Size(89, 27);
            label4.TabIndex = 8;
            label4.Text = "Sınav2:";
            // 
            // textBox4
            // 
            textBox4.BackColor = SystemColors.ScrollBar;
            textBox4.Location = new Point(332, 148);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(40, 34);
            textBox4.TabIndex = 9;
            // 
            // textBox5
            // 
            textBox5.BackColor = SystemColors.ScrollBar;
            textBox5.Location = new Point(571, 148);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(40, 34);
            textBox5.TabIndex = 10;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(493, 151);
            label5.Name = "label5";
            label5.Size = new Size(72, 27);
            label5.TabIndex = 11;
            label5.Text = "Proje:";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(389, 20);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(201, 110);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 12;
            pictureBox1.TabStop = false;
            // 
            // listBox1
            // 
            listBox1.BackColor = SystemColors.ScrollBar;
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 27;
            listBox1.Location = new Point(12, 269);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(599, 112);
            listBox1.TabIndex = 13;
            // 
            // button1
            // 
            button1.Location = new Point(219, 216);
            button1.Name = "button1";
            button1.Size = new Size(174, 38);
            button1.TabIndex = 14;
            button1.Text = "Hesapla";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(14F, 27F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDark;
            ClientSize = new Size(637, 417);
            Controls.Add(button1);
            Controls.Add(listBox1);
            Controls.Add(pictureBox1);
            Controls.Add(label5);
            Controls.Add(textBox5);
            Controls.Add(textBox4);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Georgia", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 162);
            Margin = new Padding(5, 4, 5, 4);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private Label label3;
        private Label label4;
        private TextBox textBox4;
        private TextBox textBox5;
        private Label label5;
        private PictureBox pictureBox1;
        private ListBox listBox1;
        private Button button1;
    }
}
