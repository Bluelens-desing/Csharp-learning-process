namespace VKIHesapla
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.BoytextBox = new System.Windows.Forms.TextBox();
            this.KilotextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.VHItextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.DurumtextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.HesaplaBtn = new System.Windows.Forms.Button();
            this.TemizleBtn = new System.Windows.Forms.Button();
            this.SayitextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.Faktoriyel = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Faktoriyel.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(134, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Boy :";
            // 
            // BoytextBox
            // 
            this.BoytextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BoytextBox.Location = new System.Drawing.Point(242, 31);
            this.BoytextBox.Name = "BoytextBox";
            this.BoytextBox.Size = new System.Drawing.Size(101, 38);
            this.BoytextBox.TabIndex = 1;
            this.BoytextBox.TextChanged += new System.EventHandler(this.BoytextBox_TextChanged);
            // 
            // KilotextBox
            // 
            this.KilotextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.KilotextBox.Location = new System.Drawing.Point(242, 91);
            this.KilotextBox.Name = "KilotextBox";
            this.KilotextBox.Size = new System.Drawing.Size(101, 38);
            this.KilotextBox.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(134, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 32);
            this.label2.TabIndex = 2;
            this.label2.Text = "Kilo :";
            // 
            // VHItextBox
            // 
            this.VHItextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.VHItextBox.Location = new System.Drawing.Point(242, 152);
            this.VHItextBox.Name = "VHItextBox";
            this.VHItextBox.Size = new System.Drawing.Size(101, 38);
            this.VHItextBox.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(134, 152);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 32);
            this.label3.TabIndex = 4;
            this.label3.Text = "VHI :";
            // 
            // DurumtextBox
            // 
            this.DurumtextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.DurumtextBox.Location = new System.Drawing.Point(242, 209);
            this.DurumtextBox.Name = "DurumtextBox";
            this.DurumtextBox.Size = new System.Drawing.Size(101, 38);
            this.DurumtextBox.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(99, 209);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(113, 32);
            this.label4.TabIndex = 6;
            this.label4.Text = "Durum :";
            // 
            // HesaplaBtn
            // 
            this.HesaplaBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.HesaplaBtn.Location = new System.Drawing.Point(73, 265);
            this.HesaplaBtn.Name = "HesaplaBtn";
            this.HesaplaBtn.Size = new System.Drawing.Size(139, 52);
            this.HesaplaBtn.TabIndex = 8;
            this.HesaplaBtn.Text = "Hesapla";
            this.HesaplaBtn.UseVisualStyleBackColor = true;
            this.HesaplaBtn.Click += new System.EventHandler(this.HesaplaBtn_Click);
            // 
            // TemizleBtn
            // 
            this.TemizleBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TemizleBtn.Location = new System.Drawing.Point(242, 265);
            this.TemizleBtn.Name = "TemizleBtn";
            this.TemizleBtn.Size = new System.Drawing.Size(131, 52);
            this.TemizleBtn.TabIndex = 9;
            this.TemizleBtn.Text = "Temizle";
            this.TemizleBtn.UseVisualStyleBackColor = true;
            this.TemizleBtn.Click += new System.EventHandler(this.TemizleBtn_Click);
            // 
            // SayitextBox
            // 
            this.SayitextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.SayitextBox.Location = new System.Drawing.Point(120, 36);
            this.SayitextBox.Name = "SayitextBox";
            this.SayitextBox.Size = new System.Drawing.Size(64, 38);
            this.SayitextBox.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(12, 36);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 32);
            this.label5.TabIndex = 10;
            this.label5.Text = "Sayı :";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.Location = new System.Drawing.Point(200, 28);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(79, 52);
            this.button1.TabIndex = 12;
            this.button1.Text = "!  =";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox1.Location = new System.Drawing.Point(299, 33);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(89, 38);
            this.textBox1.TabIndex = 13;
            // 
            // Faktoriyel
            // 
            this.Faktoriyel.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.Faktoriyel.Controls.Add(this.button1);
            this.Faktoriyel.Controls.Add(this.textBox1);
            this.Faktoriyel.Controls.Add(this.label5);
            this.Faktoriyel.Controls.Add(this.SayitextBox);
            this.Faktoriyel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Faktoriyel.Location = new System.Drawing.Point(451, 12);
            this.Faktoriyel.Name = "Faktoriyel";
            this.Faktoriyel.Size = new System.Drawing.Size(394, 108);
            this.Faktoriyel.TabIndex = 14;
            this.Faktoriyel.TabStop = false;
            this.Faktoriyel.Text = "Faktöriyel";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.AntiqueWhite;
            this.groupBox1.Controls.Add(this.HesaplaBtn);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.TemizleBtn);
            this.groupBox1.Controls.Add(this.BoytextBox);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.DurumtextBox);
            this.groupBox1.Controls.Add(this.KilotextBox);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.VHItextBox);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.Location = new System.Drawing.Point(-4, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(449, 338);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Vücut Kitle Indeksi Hesapla";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(857, 371);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.Faktoriyel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Faktoriyel.ResumeLayout(false);
            this.Faktoriyel.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox BoytextBox;
        private System.Windows.Forms.TextBox KilotextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox VHItextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox DurumtextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button HesaplaBtn;
        private System.Windows.Forms.Button TemizleBtn;
        private System.Windows.Forms.TextBox SayitextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.GroupBox Faktoriyel;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}

