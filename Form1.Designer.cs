namespace _20170713_GeneratePdfName
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
            this.button1 = new System.Windows.Forms.Button();
            this.year = new System.Windows.Forms.TextBox();
            this.name = new System.Windows.Forms.TextBox();
            this.pdfName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.title = new System.Windows.Forms.TextBox();
            this.laber12 = new System.Windows.Forms.Label();
            this.journal = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(523, 93);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(110, 56);
            this.button1.TabIndex = 0;
            this.button1.Text = "Generate";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // year
            // 
            this.year.AccessibleName = "";
            this.year.Location = new System.Drawing.Point(117, 58);
            this.year.Name = "year";
            this.year.Size = new System.Drawing.Size(278, 21);
            this.year.TabIndex = 1;
            this.year.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // name
            // 
            this.name.Location = new System.Drawing.Point(117, 103);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(278, 21);
            this.name.TabIndex = 2;
            this.name.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // pdfName
            // 
            this.pdfName.Location = new System.Drawing.Point(117, 257);
            this.pdfName.Name = "pdfName";
            this.pdfName.Size = new System.Drawing.Size(1031, 21);
            this.pdfName.TabIndex = 5;
            this.pdfName.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 12);
            this.label1.TabIndex = 4;
            this.label1.Text = "Year";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 12);
            this.label2.TabIndex = 5;
            this.label2.Text = "Author Suname";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 260);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 12);
            this.label3.TabIndex = 6;
            this.label3.Text = "PdfName";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(30, 188);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 12);
            this.label4.TabIndex = 7;
            this.label4.Text = "Title";
            // 
            // title
            // 
            this.title.Location = new System.Drawing.Point(117, 188);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(1031, 21);
            this.title.TabIndex = 4;
            this.title.TextChanged += new System.EventHandler(this.title_TextChanged);
            // 
            // laber12
            // 
            this.laber12.AutoSize = true;
            this.laber12.Location = new System.Drawing.Point(30, 147);
            this.laber12.Name = "laber12";
            this.laber12.Size = new System.Drawing.Size(47, 12);
            this.laber12.TabIndex = 9;
            this.laber12.Text = "Journal";
            // 
            // journal
            // 
            this.journal.Location = new System.Drawing.Point(117, 147);
            this.journal.Name = "journal";
            this.journal.Size = new System.Drawing.Size(278, 21);
            this.journal.TabIndex = 3;
            this.journal.TextChanged += new System.EventHandler(this.journal_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1221, 332);
            this.Controls.Add(this.journal);
            this.Controls.Add(this.laber12);
            this.Controls.Add(this.title);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pdfName);
            this.Controls.Add(this.name);
            this.Controls.Add(this.year);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "生成Pdf文件名";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox year;
        private System.Windows.Forms.TextBox name;
        private System.Windows.Forms.TextBox pdfName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox title;
        private System.Windows.Forms.Label laber12;
        private System.Windows.Forms.TextBox journal;
    }
}

