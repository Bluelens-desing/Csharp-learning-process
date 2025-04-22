namespace FormsApp5
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
            panel1 = new Panel();
            label1 = new Label();
            label2 = new Label();
            maskedTextBox1 = new MaskedTextBox();
            maskedTextBox2 = new MaskedTextBox();
            panel2 = new Panel();
            checkBox1 = new CheckBox();
            button1 = new Button();
            label3 = new Label();
            pictureBox1 = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(255, 192, 192);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(label3);
            panel1.Location = new Point(-6, -1);
            panel1.Margin = new Padding(4, 3, 4, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(710, 184);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Corbel", 16.2F, FontStyle.Bold);
            label1.Location = new Point(53, 219);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(184, 35);
            label1.TabIndex = 1;
            label1.Text = "TC Kimlik NO:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Corbel", 16.2F, FontStyle.Bold);
            label2.Location = new Point(158, 267);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(79, 35);
            label2.TabIndex = 2;
            label2.Text = "Şifre:";
            // 
            // maskedTextBox1
            // 
            maskedTextBox1.Location = new Point(272, 225);
            maskedTextBox1.Mask = "00000000000";
            maskedTextBox1.Name = "maskedTextBox1";
            maskedTextBox1.Size = new Size(253, 29);
            maskedTextBox1.TabIndex = 3;
            maskedTextBox1.ValidatingType = typeof(int);
            // 
            // maskedTextBox2
            // 
            maskedTextBox2.Location = new Point(272, 273);
            maskedTextBox2.Name = "maskedTextBox2";
            maskedTextBox2.Size = new Size(253, 29);
            maskedTextBox2.TabIndex = 4;
            maskedTextBox2.UseSystemPasswordChar = true;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(255, 192, 192);
            panel2.Location = new Point(0, 456);
            panel2.Margin = new Padding(4, 3, 4, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(713, 44);
            panel2.TabIndex = 5;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(545, 276);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(159, 26);
            checkBox1.TabIndex = 6;
            checkBox1.Text = "Şifremi unuttum";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Location = new Point(319, 330);
            button1.Name = "button1";
            button1.Size = new Size(162, 46);
            button1.TabIndex = 7;
            button1.Text = "Giriş yap";
            button1.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Harlow Solid Italic", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label3.Location = new Point(18, 61);
            label3.Name = "label3";
            label3.Size = new Size(430, 38);
            label3.TabIndex = 0;
            label3.Text = "Okul giriş sayfasına hojgeldinizz";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(471, 13);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(212, 153);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 22F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(224, 224, 224);
            ClientSize = new Size(700, 495);
            Controls.Add(button1);
            Controls.Add(checkBox1);
            Controls.Add(panel2);
            Controls.Add(maskedTextBox2);
            Controls.Add(maskedTextBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(panel1);
            Font = new Font("Corbel", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 162);
            Margin = new Padding(4, 3, 4, 3);
            Name = "Form1";
            Text = "lab";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Label label2;
        private MaskedTextBox maskedTextBox1;
        private MaskedTextBox maskedTextBox2;
        private Panel panel2;
        private PictureBox pictureBox1;
        private Label label3;
        private CheckBox checkBox1;
        private Button button1;
    }
}
