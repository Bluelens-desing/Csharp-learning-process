namespace switch_case_uygulama
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
            label1 = new Label();
            label2 = new Label();
            textBox1 = new TextBox();
            button1 = new Button();
            button2 = new Button();
            textBox2 = new TextBox();
            label3 = new Label();
            label4 = new Label();
            button3 = new Button();
            textBox3 = new TextBox();
            label5 = new Label();
            label6 = new Label();
            textBox4 = new TextBox();
            label7 = new Label();
            textBox5 = new TextBox();
            label8 = new Label();
            groupBox1 = new GroupBox();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(72, 18);
            label1.Name = "label1";
            label1.Size = new Size(98, 27);
            label1.TabIndex = 0;
            label1.Text = "Ay getir:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(84, 110);
            label2.Name = "label2";
            label2.Size = new Size(74, 27);
            label2.TabIndex = 1;
            label2.Text = "Sonuç";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(37, 58);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(169, 34);
            textBox1.TabIndex = 2;
            // 
            // button1
            // 
            button1.Location = new Point(37, 152);
            button1.Name = "button1";
            button1.Size = new Size(169, 39);
            button1.TabIndex = 3;
            button1.Text = "Ay getir";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(220, 152);
            button2.Name = "button2";
            button2.Size = new Size(169, 39);
            button2.TabIndex = 7;
            button2.Text = "Ay getir";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(220, 58);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(169, 34);
            textBox2.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(267, 110);
            label3.Name = "label3";
            label3.Size = new Size(74, 27);
            label3.TabIndex = 5;
            label3.Text = "Sonuç";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(242, 18);
            label4.Name = "label4";
            label4.Size = new Size(125, 27);
            label4.TabIndex = 4;
            label4.Text = "mevsim gir";
            // 
            // button3
            // 
            button3.Location = new Point(23, 202);
            button3.Name = "button3";
            button3.Size = new Size(284, 39);
            button3.TabIndex = 11;
            button3.Text = "Hesapla:";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(138, 39);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(169, 34);
            textBox3.TabIndex = 10;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(128, 270);
            label5.Name = "label5";
            label5.Size = new Size(74, 27);
            label5.TabIndex = 9;
            label5.Text = "Sonuç";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(23, 42);
            label6.Name = "label6";
            label6.Size = new Size(69, 27);
            label6.TabIndex = 8;
            label6.Text = "sayı1:";
            // 
            // textBox4
            // 
            textBox4.Location = new Point(138, 86);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(169, 34);
            textBox4.TabIndex = 13;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(20, 89);
            label7.Name = "label7";
            label7.Size = new Size(72, 27);
            label7.TabIndex = 12;
            label7.Text = "sayı2:";
            // 
            // textBox5
            // 
            textBox5.Location = new Point(138, 142);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(169, 34);
            textBox5.TabIndex = 15;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(20, 145);
            label8.Name = "label8";
            label8.Size = new Size(94, 54);
            label8.TabIndex = 14;
            label8.Text = "işlem:\r\n(+,-,*,/)\r\n";
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.DeepPink;
            groupBox1.Controls.Add(textBox3);
            groupBox1.Controls.Add(textBox5);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(textBox4);
            groupBox1.Controls.Add(button3);
            groupBox1.Controls.Add(label7);
            groupBox1.Location = new Point(744, 29);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(316, 463);
            groupBox1.TabIndex = 16;
            groupBox1.TabStop = false;
            groupBox1.Text = "groupBox1";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(14F, 27F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1107, 608);
            Controls.Add(groupBox1);
            Controls.Add(button2);
            Controls.Add(textBox2);
            Controls.Add(label3);
            Controls.Add(label4);
            Controls.Add(button1);
            Controls.Add(textBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Georgia", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 162);
            Margin = new Padding(5, 4, 5, 4);
            Name = "Form1";
            Text = "Form1";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox textBox1;
        private Button button1;
        private Button button2;
        private TextBox textBox2;
        private Label label3;
        private Label label4;
        private Button button3;
        private TextBox textBox3;
        private Label label5;
        private Label label6;
        private TextBox textBox4;
        private Label label7;
        private TextBox textBox5;
        private Label label8;
        private GroupBox groupBox1;
    }
}
