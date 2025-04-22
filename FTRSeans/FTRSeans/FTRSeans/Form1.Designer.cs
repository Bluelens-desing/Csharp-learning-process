namespace FTRSeans
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnTemizle = new System.Windows.Forms.Button();
            this.btnkaydet = new System.Windows.Forms.Button();
            this.cbpol = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.txtdt = new System.Windows.Forms.MaskedTextBox();
            this.txtadsoyad = new System.Windows.Forms.TextBox();
            this.txtTC = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtSeans = new System.Windows.Forms.TextBox();
            this.txtgun = new System.Windows.Forms.TextBox();
            this.btnSeans = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txttlf = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.txttlf);
            this.groupBox1.Controls.Add(this.btnTemizle);
            this.groupBox1.Controls.Add(this.btnkaydet);
            this.groupBox1.Controls.Add(this.cbpol);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.richTextBox1);
            this.groupBox1.Controls.Add(this.txtdt);
            this.groupBox1.Controls.Add(this.txtadsoyad);
            this.groupBox1.Controls.Add(this.txtTC);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.Location = new System.Drawing.Point(33, 37);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(735, 199);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "KİŞİSEL BİLGİLER";
            // 
            // btnTemizle
            // 
            this.btnTemizle.Location = new System.Drawing.Point(413, 156);
            this.btnTemizle.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnTemizle.Name = "btnTemizle";
            this.btnTemizle.Size = new System.Drawing.Size(76, 38);
            this.btnTemizle.TabIndex = 11;
            this.btnTemizle.Text = "Formu Temizle";
            this.btnTemizle.UseVisualStyleBackColor = true;
            this.btnTemizle.Click += new System.EventHandler(this.btnTemizle_Click);
            // 
            // btnkaydet
            // 
            this.btnkaydet.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnkaydet.Location = new System.Drawing.Point(511, 156);
            this.btnkaydet.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnkaydet.Name = "btnkaydet";
            this.btnkaydet.Size = new System.Drawing.Size(94, 38);
            this.btnkaydet.TabIndex = 10;
            this.btnkaydet.Text = "Kaydet";
            this.btnkaydet.UseVisualStyleBackColor = true;
            this.btnkaydet.Click += new System.EventHandler(this.btnkaydet_Click);
            // 
            // cbpol
            // 
            this.cbpol.FormattingEnabled = true;
            this.cbpol.Items.AddRange(new object[] {
            "FTR 1",
            "FTR 2",
            "FTR 3",
            "FTR 4",
            "FTR 5",
            "FTR 6"});
            this.cbpol.Location = new System.Drawing.Point(151, 139);
            this.cbpol.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbpol.Name = "cbpol";
            this.cbpol.Size = new System.Drawing.Size(146, 21);
            this.cbpol.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(30, 145);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "POLİKLİNİK : ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(342, 79);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "ADRESİ : ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 104);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "DOĞUM TARİHİ : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "ADI SOYADI : ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "TC KİMLİK NO :";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(413, 76);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(213, 64);
            this.richTextBox1.TabIndex = 3;
            this.richTextBox1.Text = "";
            // 
            // txtdt
            // 
            this.txtdt.Location = new System.Drawing.Point(152, 101);
            this.txtdt.Mask = "00/00/0000";
            this.txtdt.Name = "txtdt";
            this.txtdt.Size = new System.Drawing.Size(145, 20);
            this.txtdt.TabIndex = 2;
            this.txtdt.ValidatingType = typeof(System.DateTime);
            // 
            // txtadsoyad
            // 
            this.txtadsoyad.Location = new System.Drawing.Point(151, 65);
            this.txtadsoyad.Name = "txtadsoyad";
            this.txtadsoyad.Size = new System.Drawing.Size(147, 20);
            this.txtadsoyad.TabIndex = 1;
            // 
            // txtTC
            // 
            this.txtTC.Location = new System.Drawing.Point(151, 28);
            this.txtTC.Name = "txtTC";
            this.txtTC.Size = new System.Drawing.Size(147, 20);
            this.txtTC.TabIndex = 0;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.Location = new System.Drawing.Point(333, 250);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(137, 24);
            this.label9.TabIndex = 9;
            this.label9.Text = "Hasta Bilgileri";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(333, 7);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(112, 24);
            this.label6.TabIndex = 10;
            this.label6.Text = "Hasta Kayıt";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(33, 284);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(744, 135);
            this.dataGridView1.TabIndex = 11;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(19, 66);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(98, 16);
            this.label7.TabIndex = 15;
            this.label7.Text = "SEANS SAYISI";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(19, 30);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(37, 16);
            this.label8.TabIndex = 14;
            this.label8.Text = "GÜN";
            // 
            // txtSeans
            // 
            this.txtSeans.Location = new System.Drawing.Point(166, 62);
            this.txtSeans.Name = "txtSeans";
            this.txtSeans.Size = new System.Drawing.Size(147, 26);
            this.txtSeans.TabIndex = 13;
            // 
            // txtgun
            // 
            this.txtgun.Location = new System.Drawing.Point(166, 30);
            this.txtgun.Name = "txtgun";
            this.txtgun.Size = new System.Drawing.Size(147, 26);
            this.txtgun.TabIndex = 12;
            // 
            // btnSeans
            // 
            this.btnSeans.Location = new System.Drawing.Point(190, 133);
            this.btnSeans.Name = "btnSeans";
            this.btnSeans.Size = new System.Drawing.Size(133, 34);
            this.btnSeans.TabIndex = 16;
            this.btnSeans.Text = "Seans Oluştur";
            this.btnSeans.UseVisualStyleBackColor = true;
            this.btnSeans.Click += new System.EventHandler(this.btnSeans_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(428, 435);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(349, 173);
            this.listBox1.TabIndex = 17;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(166, 98);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(147, 26);
            this.dateTimePicker1.TabIndex = 18;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label10.Location = new System.Drawing.Point(19, 108);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(48, 16);
            this.label10.TabIndex = 19;
            this.label10.Text = "TARİH";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(357, 28);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(41, 13);
            this.label11.TabIndex = 13;
            this.label11.Text = "TLF : ";
            // 
            // txttlf
            // 
            this.txttlf.Location = new System.Drawing.Point(413, 24);
            this.txttlf.Name = "txttlf";
            this.txttlf.Size = new System.Drawing.Size(147, 20);
            this.txttlf.TabIndex = 12;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox2.Controls.Add(this.dateTimePicker1);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.txtgun);
            this.groupBox2.Controls.Add(this.txtSeans);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.btnSeans);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox2.Location = new System.Drawing.Point(33, 435);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(358, 173);
            this.groupBox2.TabIndex = 20;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Seans Oluşturma";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(830, 628);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.MaskedTextBox txtdt;
        private System.Windows.Forms.TextBox txtadsoyad;
        private System.Windows.Forms.TextBox txtTC;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnkaydet;
        private System.Windows.Forms.ComboBox cbpol;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnTemizle;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtSeans;
        private System.Windows.Forms.TextBox txtgun;
        private System.Windows.Forms.Button btnSeans;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txttlf;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}

