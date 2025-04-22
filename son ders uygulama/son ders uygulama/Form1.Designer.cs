namespace son_ders_uygulama
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
            label3 = new Label();
            label5 = new Label();
            label4 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox4 = new TextBox();
            textBox3 = new TextBox();
            label6 = new Label();
            textBox5 = new TextBox();
            label7 = new Label();
            richTextBox1 = new RichTextBox();
            button1 = new Button();
            button2 = new Button();
            groupBox1 = new GroupBox();
            label8 = new Label();
            groupBox2 = new GroupBox();
            button3 = new Button();
            textBox6 = new TextBox();
            textBox7 = new TextBox();
            textBox8 = new TextBox();
            label9 = new Label();
            label10 = new Label();
            label11 = new Label();
            listBox1 = new ListBox();
            dataGridView1 = new DataGridView();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tahoma", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label1.Location = new Point(466, 9);
            label1.Margin = new Padding(5, 0, 5, 0);
            label1.Name = "label1";
            label1.Size = new Size(177, 34);
            label1.TabIndex = 0;
            label1.Text = "Hasta Kayıt";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(52, 66);
            label2.Name = "label2";
            label2.Size = new Size(167, 28);
            label2.TabIndex = 0;
            label2.Text = "TC KİMLİK NO:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(52, 111);
            label3.Name = "label3";
            label3.Size = new Size(147, 28);
            label3.TabIndex = 1;
            label3.Text = "ADI SOYADI:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(52, 204);
            label5.Name = "label5";
            label5.Size = new Size(145, 28);
            label5.TabIndex = 2;
            label5.Text = "POLİKNİNİK:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(52, 157);
            label4.Name = "label4";
            label4.Size = new Size(174, 28);
            label4.TabIndex = 3;
            label4.Text = "DOĞUM TARİHİ";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(232, 59);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(213, 35);
            textBox1.TabIndex = 4;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(232, 108);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(213, 35);
            textBox2.TabIndex = 5;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(232, 201);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(213, 35);
            textBox4.TabIndex = 6;
            textBox4.TextChanged += textBox4_TextChanged;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(232, 154);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(213, 35);
            textBox3.TabIndex = 7;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(522, 66);
            label6.Name = "label6";
            label6.Size = new Size(94, 28);
            label6.TabIndex = 8;
            label6.Text = "TLF NO:";
            // 
            // textBox5
            // 
            textBox5.Location = new Point(637, 63);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(213, 35);
            textBox5.TabIndex = 9;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(522, 111);
            label7.Name = "label7";
            label7.Size = new Size(90, 28);
            label7.TabIndex = 10;
            label7.Text = "ADRES:";
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(637, 111);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(319, 95);
            richTextBox1.TabIndex = 11;
            richTextBox1.Text = "";
            // 
            // button1
            // 
            button1.Location = new Point(687, 220);
            button1.Name = "button1";
            button1.Size = new Size(105, 69);
            button1.TabIndex = 12;
            button1.Text = "Formu temizle";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(822, 236);
            button2.Name = "button2";
            button2.Size = new Size(108, 37);
            button2.TabIndex = 13;
            button2.Text = "Kaydet";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.FromArgb(192, 255, 192);
            groupBox1.Controls.Add(button2);
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(richTextBox1);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(textBox5);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(textBox3);
            groupBox1.Controls.Add(textBox4);
            groupBox1.Controls.Add(textBox2);
            groupBox1.Controls.Add(textBox1);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Location = new Point(12, 58);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1084, 295);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "KİŞİSEL BİLGİLER";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Tahoma", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label8.Location = new Point(451, 367);
            label8.Margin = new Padding(5, 0, 5, 0);
            label8.Name = "label8";
            label8.Size = new Size(220, 34);
            label8.TabIndex = 2;
            label8.Text = "Hasta Bilgileri:";
            // 
            // groupBox2
            // 
            groupBox2.BackColor = SystemColors.ActiveCaption;
            groupBox2.Controls.Add(button3);
            groupBox2.Controls.Add(textBox6);
            groupBox2.Controls.Add(textBox7);
            groupBox2.Controls.Add(textBox8);
            groupBox2.Controls.Add(label9);
            groupBox2.Controls.Add(label10);
            groupBox2.Controls.Add(label11);
            groupBox2.Location = new Point(12, 610);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(499, 208);
            groupBox2.TabIndex = 3;
            groupBox2.TabStop = false;
            groupBox2.Text = "Seans oluşturma";
            // 
            // button3
            // 
            button3.Location = new Point(229, 151);
            button3.Name = "button3";
            button3.Size = new Size(141, 38);
            button3.TabIndex = 13;
            button3.Text = "button3";
            button3.UseVisualStyleBackColor = true;
            // 
            // textBox6
            // 
            textBox6.Location = new Point(211, 110);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(174, 35);
            textBox6.TabIndex = 12;
            // 
            // textBox7
            // 
            textBox7.Location = new Point(211, 72);
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(174, 35);
            textBox7.TabIndex = 11;
            // 
            // textBox8
            // 
            textBox8.Location = new Point(211, 34);
            textBox8.Name = "textBox8";
            textBox8.Size = new Size(174, 35);
            textBox8.TabIndex = 10;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(51, 113);
            label9.Name = "label9";
            label9.Size = new Size(86, 28);
            label9.TabIndex = 9;
            label9.Text = "TARİH:";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(51, 75);
            label10.Name = "label10";
            label10.Size = new Size(166, 28);
            label10.TabIndex = 8;
            label10.Text = "SEANS SAYISI:";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(51, 37);
            label11.Name = "label11";
            label11.Size = new Size(65, 28);
            label11.TabIndex = 7;
            label11.Text = "GÜN:";
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 28;
            listBox1.Location = new Point(593, 612);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(449, 200);
            listBox1.TabIndex = 4;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(35, 404);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(1029, 176);
            dataGridView1.TabIndex = 5;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1108, 854);
            Controls.Add(dataGridView1);
            Controls.Add(listBox1);
            Controls.Add(groupBox2);
            Controls.Add(label8);
            Controls.Add(groupBox1);
            Controls.Add(label1);
            Font = new Font("Tahoma", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 162);
            Margin = new Padding(5, 4, 5, 4);
            Name = "Form1";
            Text = "Form1";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label5;
        private Label label4;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox4;
        private TextBox textBox3;
        private Label label6;
        private TextBox textBox5;
        private Label label7;
        private RichTextBox richTextBox1;
        private Button button1;
        private Button button2;
        private GroupBox groupBox1;
        private Label label8;
        private GroupBox groupBox2;
        private Button button3;
        private TextBox textBox6;
        private TextBox textBox7;
        private TextBox textBox8;
        private Label label9;
        private Label label10;
        private Label label11;
        private ListBox listBox1;
        private DataGridView dataGridView1;
    }
}
