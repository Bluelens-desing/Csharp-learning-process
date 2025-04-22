namespace FormsApp3
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
            maskedTextBox1 = new MaskedTextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            maskedTextBox2 = new MaskedTextBox();
            maskedTextBox3 = new MaskedTextBox();
            maskedTextBox4 = new MaskedTextBox();
            listBox1 = new ListBox();
            button1 = new Button();
            pictureBox1 = new PictureBox();
            dateTimePicker1 = new DateTimePicker();
            button2 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // maskedTextBox1
            // 
            maskedTextBox1.Font = new Font("Microsoft Sans Serif", 12F);
            maskedTextBox1.Location = new Point(160, 38);
            maskedTextBox1.Mask = "(999) 000-0000";
            maskedTextBox1.Name = "maskedTextBox1";
            maskedTextBox1.Size = new Size(144, 30);
            maskedTextBox1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 12F);
            label1.Location = new Point(35, 41);
            label1.Name = "label1";
            label1.Size = new Size(119, 25);
            label1.TabIndex = 1;
            label1.Text = "Telefon NO:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 12F);
            label2.Location = new Point(16, 77);
            label2.Name = "label2";
            label2.Size = new Size(138, 25);
            label2.TabIndex = 2;
            label2.Text = "TC Kimlik NO:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 12F);
            label3.Location = new Point(95, 159);
            label3.Name = "label3";
            label3.Size = new Size(59, 25);
            label3.TabIndex = 4;
            label3.Text = "Saat:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 12F);
            label4.Location = new Point(91, 116);
            label4.Name = "label4";
            label4.Size = new Size(63, 25);
            label4.TabIndex = 3;
            label4.Text = "Tarih:";
            label4.Click += label4_Click;
            // 
            // maskedTextBox2
            // 
            maskedTextBox2.Font = new Font("Microsoft Sans Serif", 12F);
            maskedTextBox2.Location = new Point(160, 77);
            maskedTextBox2.Mask = "00000000000";
            maskedTextBox2.Name = "maskedTextBox2";
            maskedTextBox2.Size = new Size(144, 30);
            maskedTextBox2.TabIndex = 5;
            maskedTextBox2.ValidatingType = typeof(int);
            // 
            // maskedTextBox3
            // 
            maskedTextBox3.Font = new Font("Microsoft Sans Serif", 12F);
            maskedTextBox3.Location = new Point(160, 116);
            maskedTextBox3.Mask = "00/00/0000";
            maskedTextBox3.Name = "maskedTextBox3";
            maskedTextBox3.Size = new Size(144, 30);
            maskedTextBox3.TabIndex = 6;
            maskedTextBox3.ValidatingType = typeof(DateTime);
            // 
            // maskedTextBox4
            // 
            maskedTextBox4.Font = new Font("Microsoft Sans Serif", 12F);
            maskedTextBox4.Location = new Point(160, 159);
            maskedTextBox4.Mask = "00:00";
            maskedTextBox4.Name = "maskedTextBox4";
            maskedTextBox4.Size = new Size(144, 30);
            maskedTextBox4.TabIndex = 7;
            maskedTextBox4.ValidatingType = typeof(DateTime);
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.Location = new Point(362, 38);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(388, 204);
            listBox1.TabIndex = 8;
            // 
            // button1
            // 
            button1.Location = new Point(156, 206);
            button1.Name = "button1";
            button1.Size = new Size(148, 36);
            button1.TabIndex = 9;
            button1.Text = "Bilgileri aktar:";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(16, 248);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(288, 150);
            pictureBox1.TabIndex = 10;
            pictureBox1.TabStop = false;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(434, 269);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(250, 27);
            dateTimePicker1.TabIndex = 11;
            // 
            // button2
            // 
            button2.Location = new Point(488, 312);
            button2.Name = "button2";
            button2.Size = new Size(148, 36);
            button2.TabIndex = 12;
            button2.Text = "Bilgileri aktar:";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ScrollBar;
            ClientSize = new Size(800, 450);
            Controls.Add(button2);
            Controls.Add(dateTimePicker1);
            Controls.Add(pictureBox1);
            Controls.Add(button1);
            Controls.Add(listBox1);
            Controls.Add(maskedTextBox4);
            Controls.Add(maskedTextBox3);
            Controls.Add(maskedTextBox2);
            Controls.Add(label3);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(maskedTextBox1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MaskedTextBox maskedTextBox1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private MaskedTextBox maskedTextBox2;
        private MaskedTextBox maskedTextBox3;
        private MaskedTextBox maskedTextBox4;
        private ListBox listBox1;
        private Button button1;
        private PictureBox pictureBox1;
        private DateTimePicker dateTimePicker1;
        private Button button2;
    }
}
