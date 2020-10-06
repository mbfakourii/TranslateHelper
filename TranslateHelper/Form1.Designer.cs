namespace TranslateHelper
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5ss = new System.Windows.Forms.Button();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.cmbDesc = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbSrc = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 67);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(605, 173);
            this.textBox1.TabIndex = 0;
            this.textBox1.WordWrap = false;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(12, 290);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(605, 156);
            this.textBox2.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(12, 246);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(153, 38);
            this.button1.TabIndex = 1;
            this.button1.Text = "Convert";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1238, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(464, 246);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(153, 38);
            this.button2.TabIndex = 1;
            this.button2.Text = "Copy";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(239, 246);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(153, 38);
            this.button3.TabIndex = 1;
            this.button3.Text = "Auto Convert And Copy";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Red;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.button4.ForeColor = System.Drawing.Color.White;
            this.button4.Location = new System.Drawing.Point(12, 27);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(72, 38);
            this.button4.TabIndex = 3;
            this.button4.Text = "Clear";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5ss
            // 
            this.button5ss.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.button5ss.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.button5ss.ForeColor = System.Drawing.Color.White;
            this.button5ss.Location = new System.Drawing.Point(661, 413);
            this.button5ss.Name = "button5ss";
            this.button5ss.Size = new System.Drawing.Size(565, 38);
            this.button5ss.TabIndex = 1;
            this.button5ss.Text = "Auto Convert And Translate And Copy";
            this.button5ss.UseVisualStyleBackColor = false;
            this.button5ss.Click += new System.EventHandler(this.buttonss_Click);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(661, 104);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.textBox3.Size = new System.Drawing.Size(565, 303);
            this.textBox3.TabIndex = 0;
            this.textBox3.WordWrap = false;
            // 
            // cmbDesc
            // 
            this.cmbDesc.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.cmbDesc.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbDesc.FormattingEnabled = true;
            this.cmbDesc.Location = new System.Drawing.Point(1071, 51);
            this.cmbDesc.Name = "cmbDesc";
            this.cmbDesc.Size = new System.Drawing.Size(155, 21);
            this.cmbDesc.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(999, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Translate to:";
            // 
            // cmbSrc
            // 
            this.cmbSrc.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.cmbSrc.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbSrc.FormattingEnabled = true;
            this.cmbSrc.Location = new System.Drawing.Point(773, 51);
            this.cmbSrc.Name = "cmbSrc";
            this.cmbSrc.Size = new System.Drawing.Size(145, 21);
            this.cmbSrc.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(658, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Source Language:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1238, 463);
            this.Controls.Add(this.cmbDesc);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbSrc);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button5ss);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1254, 502);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(1254, 502);
            this.Name = "Form1";
            this.Text = "TranslateHelper";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5ss;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.ComboBox cmbDesc;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbSrc;
        private System.Windows.Forms.Label label1;
    }
}

