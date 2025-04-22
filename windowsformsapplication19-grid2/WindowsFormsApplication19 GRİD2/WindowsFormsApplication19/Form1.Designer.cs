namespace WindowsFormsApplication19
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.kasaDataSet = new WindowsFormsApplication19.kasaDataSet();
            this.unvanBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.unvanTableAdapter = new WindowsFormsApplication19.kasaDataSetTableAdapters.unvanTableAdapter();
            this.vdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vnoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tel1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tel2DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adres1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adres2DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adres3DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ilDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kodDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.carigrupDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.parabirimiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.limitDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.notDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.yorumDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mknoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.s1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.s2DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.s3DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.s4DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.t1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.t2DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.t3DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.t4DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.caritipDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kasaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.unvanBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            this.dataGridView1.Location = new System.Drawing.Point(28, 586);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(576, 329);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Öğrenci No";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Adı Soyadı";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Bölüm";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Fakülte";
            this.Column4.Name = "Column4";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(25, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(177, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "ÖĞRENCİ NO";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox1.Location = new System.Drawing.Point(208, 35);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(258, 34);
            this.textBox1.TabIndex = 2;
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox2.Location = new System.Drawing.Point(208, 89);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(258, 34);
            this.textBox2.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(25, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(156, 29);
            this.label2.TabIndex = 3;
            this.label2.Text = "ADI SOYADI";
            // 
            // textBox3
            // 
            this.textBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox3.Location = new System.Drawing.Point(208, 144);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(135, 34);
            this.textBox3.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(96, 149);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 29);
            this.label3.TabIndex = 5;
            this.label3.Text = "VİZE";
            // 
            // textBox4
            // 
            this.textBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox4.Location = new System.Drawing.Point(208, 198);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(135, 34);
            this.textBox4.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(96, 203);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 29);
            this.label4.TabIndex = 7;
            this.label4.Text = "FİNAL";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.Location = new System.Drawing.Point(115, 260);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(327, 41);
            this.button1.TabIndex = 9;
            this.button1.Text = "TABLOYA EKLE";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(510, 35);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView2.Size = new System.Drawing.Size(817, 463);
            this.dataGridView2.TabIndex = 10;
            this.dataGridView2.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellClick);
            this.dataGridView2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button2.Location = new System.Drawing.Point(115, 345);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(327, 41);
            this.button2.TabIndex = 11;
            this.button2.Text = "DÜZELT";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button3.Location = new System.Drawing.Point(115, 415);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(327, 41);
            this.button3.TabIndex = 12;
            this.button3.Text = "SATIR SİL";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // textBox5
            // 
            this.textBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox5.Location = new System.Drawing.Point(39, 485);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(106, 34);
            this.textBox5.TabIndex = 13;
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button4.Location = new System.Drawing.Point(165, 480);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(327, 41);
            this.button4.TabIndex = 14;
            this.button4.Text = "SATIR NO İLE SİL";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button5.Location = new System.Drawing.Point(1111, 524);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(195, 41);
            this.button5.TabIndex = 15;
            this.button5.Text = "HESAPLA";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // textBox6
            // 
            this.textBox6.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox6.Location = new System.Drawing.Point(955, 531);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(135, 34);
            this.textBox6.TabIndex = 16;
            // 
            // dataGridView3
            // 
            this.dataGridView3.AutoGenerateColumns = false;
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.vdDataGridViewTextBoxColumn,
            this.vnoDataGridViewTextBoxColumn,
            this.tel1DataGridViewTextBoxColumn,
            this.tel2DataGridViewTextBoxColumn,
            this.adres1DataGridViewTextBoxColumn,
            this.adres2DataGridViewTextBoxColumn,
            this.adres3DataGridViewTextBoxColumn,
            this.ilDataGridViewTextBoxColumn,
            this.kodDataGridViewTextBoxColumn,
            this.carigrupDataGridViewTextBoxColumn,
            this.parabirimiDataGridViewTextBoxColumn,
            this.limitDataGridViewTextBoxColumn,
            this.notDataGridViewTextBoxColumn,
            this.yorumDataGridViewTextBoxColumn,
            this.mknoDataGridViewTextBoxColumn,
            this.s1DataGridViewTextBoxColumn,
            this.s2DataGridViewTextBoxColumn,
            this.s3DataGridViewTextBoxColumn,
            this.s4DataGridViewTextBoxColumn,
            this.t1DataGridViewTextBoxColumn,
            this.t2DataGridViewTextBoxColumn,
            this.t3DataGridViewTextBoxColumn,
            this.t4DataGridViewTextBoxColumn,
            this.caritipDataGridViewTextBoxColumn,
            this.adDataGridViewTextBoxColumn});
            this.dataGridView3.DataSource = this.unvanBindingSource;
            this.dataGridView3.Location = new System.Drawing.Point(622, 597);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.RowTemplate.Height = 24;
            this.dataGridView3.Size = new System.Drawing.Size(735, 247);
            this.dataGridView3.TabIndex = 17;
            // 
            // kasaDataSet
            // 
            this.kasaDataSet.DataSetName = "kasaDataSet";
            this.kasaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // unvanBindingSource
            // 
            this.unvanBindingSource.DataMember = "unvan";
            this.unvanBindingSource.DataSource = this.kasaDataSet;
            // 
            // unvanTableAdapter
            // 
            this.unvanTableAdapter.ClearBeforeFill = true;
            // 
            // vdDataGridViewTextBoxColumn
            // 
            this.vdDataGridViewTextBoxColumn.DataPropertyName = "vd";
            this.vdDataGridViewTextBoxColumn.HeaderText = "vd";
            this.vdDataGridViewTextBoxColumn.Name = "vdDataGridViewTextBoxColumn";
            // 
            // vnoDataGridViewTextBoxColumn
            // 
            this.vnoDataGridViewTextBoxColumn.DataPropertyName = "vno";
            this.vnoDataGridViewTextBoxColumn.HeaderText = "vno";
            this.vnoDataGridViewTextBoxColumn.Name = "vnoDataGridViewTextBoxColumn";
            // 
            // tel1DataGridViewTextBoxColumn
            // 
            this.tel1DataGridViewTextBoxColumn.DataPropertyName = "tel1";
            this.tel1DataGridViewTextBoxColumn.HeaderText = "tel1";
            this.tel1DataGridViewTextBoxColumn.Name = "tel1DataGridViewTextBoxColumn";
            // 
            // tel2DataGridViewTextBoxColumn
            // 
            this.tel2DataGridViewTextBoxColumn.DataPropertyName = "tel2";
            this.tel2DataGridViewTextBoxColumn.HeaderText = "tel2";
            this.tel2DataGridViewTextBoxColumn.Name = "tel2DataGridViewTextBoxColumn";
            // 
            // adres1DataGridViewTextBoxColumn
            // 
            this.adres1DataGridViewTextBoxColumn.DataPropertyName = "adres1";
            this.adres1DataGridViewTextBoxColumn.HeaderText = "adres1";
            this.adres1DataGridViewTextBoxColumn.Name = "adres1DataGridViewTextBoxColumn";
            // 
            // adres2DataGridViewTextBoxColumn
            // 
            this.adres2DataGridViewTextBoxColumn.DataPropertyName = "adres2";
            this.adres2DataGridViewTextBoxColumn.HeaderText = "adres2";
            this.adres2DataGridViewTextBoxColumn.Name = "adres2DataGridViewTextBoxColumn";
            // 
            // adres3DataGridViewTextBoxColumn
            // 
            this.adres3DataGridViewTextBoxColumn.DataPropertyName = "adres3";
            this.adres3DataGridViewTextBoxColumn.HeaderText = "adres3";
            this.adres3DataGridViewTextBoxColumn.Name = "adres3DataGridViewTextBoxColumn";
            // 
            // ilDataGridViewTextBoxColumn
            // 
            this.ilDataGridViewTextBoxColumn.DataPropertyName = "il";
            this.ilDataGridViewTextBoxColumn.HeaderText = "il";
            this.ilDataGridViewTextBoxColumn.Name = "ilDataGridViewTextBoxColumn";
            // 
            // kodDataGridViewTextBoxColumn
            // 
            this.kodDataGridViewTextBoxColumn.DataPropertyName = "kod";
            this.kodDataGridViewTextBoxColumn.HeaderText = "kod";
            this.kodDataGridViewTextBoxColumn.Name = "kodDataGridViewTextBoxColumn";
            // 
            // carigrupDataGridViewTextBoxColumn
            // 
            this.carigrupDataGridViewTextBoxColumn.DataPropertyName = "carigrup";
            this.carigrupDataGridViewTextBoxColumn.HeaderText = "carigrup";
            this.carigrupDataGridViewTextBoxColumn.Name = "carigrupDataGridViewTextBoxColumn";
            // 
            // parabirimiDataGridViewTextBoxColumn
            // 
            this.parabirimiDataGridViewTextBoxColumn.DataPropertyName = "parabirimi";
            this.parabirimiDataGridViewTextBoxColumn.HeaderText = "parabirimi";
            this.parabirimiDataGridViewTextBoxColumn.Name = "parabirimiDataGridViewTextBoxColumn";
            // 
            // limitDataGridViewTextBoxColumn
            // 
            this.limitDataGridViewTextBoxColumn.DataPropertyName = "limit";
            this.limitDataGridViewTextBoxColumn.HeaderText = "limit";
            this.limitDataGridViewTextBoxColumn.Name = "limitDataGridViewTextBoxColumn";
            // 
            // notDataGridViewTextBoxColumn
            // 
            this.notDataGridViewTextBoxColumn.DataPropertyName = "not";
            this.notDataGridViewTextBoxColumn.HeaderText = "not";
            this.notDataGridViewTextBoxColumn.Name = "notDataGridViewTextBoxColumn";
            // 
            // yorumDataGridViewTextBoxColumn
            // 
            this.yorumDataGridViewTextBoxColumn.DataPropertyName = "yorum";
            this.yorumDataGridViewTextBoxColumn.HeaderText = "yorum";
            this.yorumDataGridViewTextBoxColumn.Name = "yorumDataGridViewTextBoxColumn";
            // 
            // mknoDataGridViewTextBoxColumn
            // 
            this.mknoDataGridViewTextBoxColumn.DataPropertyName = "mkno";
            this.mknoDataGridViewTextBoxColumn.HeaderText = "mkno";
            this.mknoDataGridViewTextBoxColumn.Name = "mknoDataGridViewTextBoxColumn";
            // 
            // s1DataGridViewTextBoxColumn
            // 
            this.s1DataGridViewTextBoxColumn.DataPropertyName = "s1";
            this.s1DataGridViewTextBoxColumn.HeaderText = "s1";
            this.s1DataGridViewTextBoxColumn.Name = "s1DataGridViewTextBoxColumn";
            // 
            // s2DataGridViewTextBoxColumn
            // 
            this.s2DataGridViewTextBoxColumn.DataPropertyName = "s2";
            this.s2DataGridViewTextBoxColumn.HeaderText = "s2";
            this.s2DataGridViewTextBoxColumn.Name = "s2DataGridViewTextBoxColumn";
            // 
            // s3DataGridViewTextBoxColumn
            // 
            this.s3DataGridViewTextBoxColumn.DataPropertyName = "s3";
            this.s3DataGridViewTextBoxColumn.HeaderText = "s3";
            this.s3DataGridViewTextBoxColumn.Name = "s3DataGridViewTextBoxColumn";
            // 
            // s4DataGridViewTextBoxColumn
            // 
            this.s4DataGridViewTextBoxColumn.DataPropertyName = "s4";
            this.s4DataGridViewTextBoxColumn.HeaderText = "s4";
            this.s4DataGridViewTextBoxColumn.Name = "s4DataGridViewTextBoxColumn";
            // 
            // t1DataGridViewTextBoxColumn
            // 
            this.t1DataGridViewTextBoxColumn.DataPropertyName = "t1";
            this.t1DataGridViewTextBoxColumn.HeaderText = "t1";
            this.t1DataGridViewTextBoxColumn.Name = "t1DataGridViewTextBoxColumn";
            // 
            // t2DataGridViewTextBoxColumn
            // 
            this.t2DataGridViewTextBoxColumn.DataPropertyName = "t2";
            this.t2DataGridViewTextBoxColumn.HeaderText = "t2";
            this.t2DataGridViewTextBoxColumn.Name = "t2DataGridViewTextBoxColumn";
            // 
            // t3DataGridViewTextBoxColumn
            // 
            this.t3DataGridViewTextBoxColumn.DataPropertyName = "t3";
            this.t3DataGridViewTextBoxColumn.HeaderText = "t3";
            this.t3DataGridViewTextBoxColumn.Name = "t3DataGridViewTextBoxColumn";
            // 
            // t4DataGridViewTextBoxColumn
            // 
            this.t4DataGridViewTextBoxColumn.DataPropertyName = "t4";
            this.t4DataGridViewTextBoxColumn.HeaderText = "t4";
            this.t4DataGridViewTextBoxColumn.Name = "t4DataGridViewTextBoxColumn";
            // 
            // caritipDataGridViewTextBoxColumn
            // 
            this.caritipDataGridViewTextBoxColumn.DataPropertyName = "caritip";
            this.caritipDataGridViewTextBoxColumn.HeaderText = "caritip";
            this.caritipDataGridViewTextBoxColumn.Name = "caritipDataGridViewTextBoxColumn";
            // 
            // adDataGridViewTextBoxColumn
            // 
            this.adDataGridViewTextBoxColumn.DataPropertyName = "ad";
            this.adDataGridViewTextBoxColumn.HeaderText = "ad";
            this.adDataGridViewTextBoxColumn.Name = "adDataGridViewTextBoxColumn";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1387, 856);
            this.Controls.Add(this.dataGridView3);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kasaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.unvanBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.DataGridView dataGridView3;
        private kasaDataSet kasaDataSet;
        private System.Windows.Forms.BindingSource unvanBindingSource;
        private kasaDataSetTableAdapters.unvanTableAdapter unvanTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn vdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vnoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tel1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tel2DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn adres1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn adres2DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn adres3DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ilDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kodDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn carigrupDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn parabirimiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn limitDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn notDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn yorumDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mknoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn s1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn s2DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn s3DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn s4DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn t1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn t2DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn t3DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn t4DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn caritipDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn adDataGridViewTextBoxColumn;
    }
}

