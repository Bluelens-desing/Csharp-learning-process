namespace canlı_saat
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
            components = new System.ComponentModel.Container();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            button1 = new Button();
            label4 = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            button2 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(20, 19);
            label1.Margin = new Padding(11, 0, 11, 0);
            label1.Name = "label1";
            label1.Size = new Size(165, 87);
            label1.TabIndex = 0;
            label1.Text = "label1";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(230, 19);
            label2.Margin = new Padding(11, 0, 11, 0);
            label2.Name = "label2";
            label2.Size = new Size(172, 87);
            label2.TabIndex = 1;
            label2.Text = "label2";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(440, 19);
            label3.Margin = new Padding(11, 0, 11, 0);
            label3.Name = "label3";
            label3.Size = new Size(172, 87);
            label3.TabIndex = 2;
            label3.Text = "label3";
            // 
            // button1
            // 
            button1.Location = new Point(14, 236);
            button1.Name = "button1";
            button1.Size = new Size(592, 110);
            button1.TabIndex = 3;
            button1.Text = "başla";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(230, 132);
            label4.Margin = new Padding(11, 0, 11, 0);
            label4.Name = "label4";
            label4.Size = new Size(173, 87);
            label4.TabIndex = 4;
            label4.Text = "label4";
            // 
            // timer1
            // 
            timer1.Tick += timer1_Tick;
            // 
            // button2
            // 
            button2.Location = new Point(14, 352);
            button2.Name = "button2";
            button2.Size = new Size(592, 110);
            button2.TabIndex = 5;
            button2.Text = "bitir";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(30F, 87F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1012, 548);
            Controls.Add(button2);
            Controls.Add(label4);
            Controls.Add(button1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Sitka Banner", 36F, FontStyle.Regular, GraphicsUnit.Point, 162);
            Margin = new Padding(11, 13, 11, 13);
            Name = "Form1";
            Text = "form";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Button button1;
        private Label label4;
        private System.Windows.Forms.Timer timer1;
        private Button button2;
    }
}
