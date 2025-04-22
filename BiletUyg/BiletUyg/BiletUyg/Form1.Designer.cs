namespace BiletUyg
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
            this.lblBakiye = new System.Windows.Forms.Label();
            this.btnOde = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.rbAktarma0 = new System.Windows.Forms.RadioButton();
            this.rbAktarma1 = new System.Windows.Forms.RadioButton();
            this.rbAktarma2 = new System.Windows.Forms.RadioButton();
            this.rbAktarma3 = new System.Windows.Forms.RadioButton();
            this.cbOgrenci = new System.Windows.Forms.CheckBox();
            this.btn50 = new System.Windows.Forms.Button();
            this.btn100 = new System.Windows.Forms.Button();
            this.btn200 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(71, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(164, 54);
            this.label1.TabIndex = 0;
            this.label1.Text = "Bakiye";
            // 
            // lblBakiye
            // 
            this.lblBakiye.AutoSize = true;
            this.lblBakiye.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblBakiye.Location = new System.Drawing.Point(258, 38);
            this.lblBakiye.Name = "lblBakiye";
            this.lblBakiye.Size = new System.Drawing.Size(127, 54);
            this.lblBakiye.TabIndex = 1;
            this.lblBakiye.Text = "1000";
            this.lblBakiye.Click += new System.EventHandler(this.lblBakiye_Click);
            // 
            // btnOde
            // 
            this.btnOde.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnOde.Location = new System.Drawing.Point(514, 33);
            this.btnOde.Name = "btnOde";
            this.btnOde.Size = new System.Drawing.Size(210, 67);
            this.btnOde.TabIndex = 2;
            this.btnOde.Text = "Ödeme";
            this.btnOde.UseVisualStyleBackColor = true;
            this.btnOde.Click += new System.EventHandler(this.btnOde_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(77, 109);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 25);
            this.label3.TabIndex = 3;
            this.label3.Text = "Ödeme";
            // 
            // rbAktarma0
            // 
            this.rbAktarma0.AutoSize = true;
            this.rbAktarma0.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rbAktarma0.Location = new System.Drawing.Point(80, 145);
            this.rbAktarma0.Name = "rbAktarma0";
            this.rbAktarma0.Size = new System.Drawing.Size(99, 29);
            this.rbAktarma0.TabIndex = 4;
            this.rbAktarma0.TabStop = true;
            this.rbAktarma0.Text = "İlk Biniş";
            this.rbAktarma0.UseVisualStyleBackColor = true;
            // 
            // rbAktarma1
            // 
            this.rbAktarma1.AutoSize = true;
            this.rbAktarma1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rbAktarma1.Location = new System.Drawing.Point(80, 180);
            this.rbAktarma1.Name = "rbAktarma1";
            this.rbAktarma1.Size = new System.Drawing.Size(122, 29);
            this.rbAktarma1.TabIndex = 5;
            this.rbAktarma1.TabStop = true;
            this.rbAktarma1.Text = "1.Aktarma";
            this.rbAktarma1.UseVisualStyleBackColor = true;
            // 
            // rbAktarma2
            // 
            this.rbAktarma2.AutoSize = true;
            this.rbAktarma2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rbAktarma2.Location = new System.Drawing.Point(80, 217);
            this.rbAktarma2.Name = "rbAktarma2";
            this.rbAktarma2.Size = new System.Drawing.Size(122, 29);
            this.rbAktarma2.TabIndex = 6;
            this.rbAktarma2.TabStop = true;
            this.rbAktarma2.Text = "2.Aktarma";
            this.rbAktarma2.UseVisualStyleBackColor = true;
            // 
            // rbAktarma3
            // 
            this.rbAktarma3.AutoSize = true;
            this.rbAktarma3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rbAktarma3.Location = new System.Drawing.Point(80, 254);
            this.rbAktarma3.Name = "rbAktarma3";
            this.rbAktarma3.Size = new System.Drawing.Size(122, 29);
            this.rbAktarma3.TabIndex = 7;
            this.rbAktarma3.TabStop = true;
            this.rbAktarma3.Text = "3.Aktarma";
            this.rbAktarma3.UseVisualStyleBackColor = true;
            // 
            // cbOgrenci
            // 
            this.cbOgrenci.AutoSize = true;
            this.cbOgrenci.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cbOgrenci.Location = new System.Drawing.Point(82, 291);
            this.cbOgrenci.Name = "cbOgrenci";
            this.cbOgrenci.Size = new System.Drawing.Size(103, 29);
            this.cbOgrenci.TabIndex = 8;
            this.cbOgrenci.Text = "Öğrenci";
            this.cbOgrenci.UseVisualStyleBackColor = true;
            // 
            // btn50
            // 
            this.btn50.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn50.Location = new System.Drawing.Point(532, 120);
            this.btn50.Name = "btn50";
            this.btn50.Size = new System.Drawing.Size(163, 59);
            this.btn50.TabIndex = 9;
            this.btn50.Text = "50 TL";
            this.btn50.UseVisualStyleBackColor = true;
            this.btn50.Click += new System.EventHandler(this.btn50_Click);
            // 
            // btn100
            // 
            this.btn100.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn100.Location = new System.Drawing.Point(532, 195);
            this.btn100.Name = "btn100";
            this.btn100.Size = new System.Drawing.Size(163, 59);
            this.btn100.TabIndex = 10;
            this.btn100.Text = "100 TL";
            this.btn100.UseVisualStyleBackColor = true;
            this.btn100.Click += new System.EventHandler(this.btn100_Click);
            // 
            // btn200
            // 
            this.btn200.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn200.Location = new System.Drawing.Point(532, 271);
            this.btn200.Name = "btn200";
            this.btn200.Size = new System.Drawing.Size(163, 59);
            this.btn200.TabIndex = 11;
            this.btn200.Text = "200 TL";
            this.btn200.UseVisualStyleBackColor = true;
            this.btn200.Click += new System.EventHandler(this.btn200_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(532, 336);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(163, 22);
            this.textBox1.TabIndex = 12;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(532, 364);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(163, 37);
            this.button1.TabIndex = 13;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(790, 413);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btn200);
            this.Controls.Add(this.btn100);
            this.Controls.Add(this.btn50);
            this.Controls.Add(this.cbOgrenci);
            this.Controls.Add(this.rbAktarma3);
            this.Controls.Add(this.rbAktarma2);
            this.Controls.Add(this.rbAktarma1);
            this.Controls.Add(this.rbAktarma0);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnOde);
            this.Controls.Add(this.lblBakiye);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblBakiye;
        private System.Windows.Forms.Button btnOde;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton rbAktarma0;
        private System.Windows.Forms.RadioButton rbAktarma1;
        private System.Windows.Forms.RadioButton rbAktarma2;
        private System.Windows.Forms.RadioButton rbAktarma3;
        private System.Windows.Forms.CheckBox cbOgrenci;
        private System.Windows.Forms.Button btn50;
        private System.Windows.Forms.Button btn100;
        private System.Windows.Forms.Button btn200;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
    }
}

