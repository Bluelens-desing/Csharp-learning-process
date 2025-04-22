namespace FormsApp4
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
            checkBox1 = new CheckBox();
            groupBox1 = new GroupBox();
            checkBox3 = new CheckBox();
            checkBox2 = new CheckBox();
            checkBox4 = new CheckBox();
            radioButton1 = new RadioButton();
            radioButton2 = new RadioButton();
            radioButton3 = new RadioButton();
            radioButton4 = new RadioButton();
            panel1 = new Panel();
            richTextBox1 = new RichTextBox();
            groupBox1.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(18, 40);
            checkBox1.Margin = new Padding(4);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(88, 26);
            checkBox1.TabIndex = 0;
            checkBox1.Text = "Ketçap";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.FromArgb(255, 255, 192);
            groupBox1.Controls.Add(checkBox3);
            groupBox1.Controls.Add(checkBox2);
            groupBox1.Controls.Add(checkBox4);
            groupBox1.Controls.Add(checkBox1);
            groupBox1.Location = new Point(23, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(315, 244);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "Sos seçimi:";
            // 
            // checkBox3
            // 
            checkBox3.AutoSize = true;
            checkBox3.Location = new Point(18, 108);
            checkBox3.Margin = new Padding(4);
            checkBox3.Name = "checkBox3";
            checkBox3.Size = new Size(90, 26);
            checkBox3.TabIndex = 3;
            checkBox3.Text = "Hardal";
            checkBox3.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            checkBox2.AutoSize = true;
            checkBox2.Location = new Point(18, 74);
            checkBox2.Margin = new Padding(4);
            checkBox2.Name = "checkBox2";
            checkBox2.Size = new Size(103, 26);
            checkBox2.TabIndex = 0;
            checkBox2.Text = "Mayonez";
            checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox4
            // 
            checkBox4.AutoSize = true;
            checkBox4.Location = new Point(18, 142);
            checkBox4.Margin = new Padding(4);
            checkBox4.Name = "checkBox4";
            checkBox4.Size = new Size(113, 26);
            checkBox4.TabIndex = 4;
            checkBox4.Text = "Ranch sos";
            checkBox4.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(59, 21);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(138, 26);
            radioButton1.TabIndex = 3;
            radioButton1.TabStop = true;
            radioButton1.Text = "Köfte burger:";
            radioButton1.UseVisualStyleBackColor = true;
            radioButton1.CheckedChanged += radioButton1_CheckedChanged;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(59, 64);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(137, 26);
            radioButton2.TabIndex = 4;
            radioButton2.TabStop = true;
            radioButton2.Text = "Dana burger:";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            radioButton3.AutoSize = true;
            radioButton3.Location = new Point(59, 108);
            radioButton3.Name = "radioButton3";
            radioButton3.Size = new Size(144, 26);
            radioButton3.TabIndex = 5;
            radioButton3.TabStop = true;
            radioButton3.Text = "Tavuk burger:";
            radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton4
            // 
            radioButton4.AutoSize = true;
            radioButton4.Location = new Point(59, 154);
            radioButton4.Name = "radioButton4";
            radioButton4.Size = new Size(144, 26);
            radioButton4.TabIndex = 6;
            radioButton4.TabStop = true;
            radioButton4.Text = "Vegan burger:";
            radioButton4.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(255, 192, 192);
            panel1.Controls.Add(radioButton2);
            panel1.Controls.Add(radioButton4);
            panel1.Controls.Add(radioButton1);
            panel1.Controls.Add(radioButton3);
            panel1.Location = new Point(401, 25);
            panel1.Name = "panel1";
            panel1.Size = new Size(283, 231);
            panel1.TabIndex = 7;
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(745, 25);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(323, 231);
            richTextBox1.TabIndex = 8;
            richTextBox1.Text = "";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(11F, 22F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(192, 192, 255);
            ClientSize = new Size(1100, 495);
            Controls.Add(richTextBox1);
            Controls.Add(panel1);
            Controls.Add(groupBox1);
            Font = new Font("Modern No. 20", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4);
            Name = "Form1";
            Text = "Form1";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private CheckBox checkBox1;
        private GroupBox groupBox1;
        private CheckBox checkBox3;
        private CheckBox checkBox2;
        private CheckBox checkBox4;
        private RadioButton radioButton1;
        private RadioButton radioButton2;
        private RadioButton radioButton3;
        private RadioButton radioButton4;
        private Panel panel1;
        private RichTextBox richTextBox1;
    }
}
