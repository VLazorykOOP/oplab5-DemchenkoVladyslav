namespace Lab5
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.P1x = new System.Windows.Forms.TextBox();
            this.P1y = new System.Windows.Forms.TextBox();
            this.P2y = new System.Windows.Forms.TextBox();
            this.P2x = new System.Windows.Forms.TextBox();
            this.Q1y = new System.Windows.Forms.TextBox();
            this.Q1x = new System.Windows.Forms.TextBox();
            this.Q2y = new System.Windows.Forms.TextBox();
            this.Q2x = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(551, 293);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // P1x
            // 
            this.P1x.Location = new System.Drawing.Point(587, 24);
            this.P1x.Name = "P1x";
            this.P1x.Size = new System.Drawing.Size(100, 20);
            this.P1x.TabIndex = 1;
            this.P1x.Text = "-50";
            // 
            // P1y
            // 
            this.P1y.Location = new System.Drawing.Point(693, 24);
            this.P1y.Name = "P1y";
            this.P1y.Size = new System.Drawing.Size(100, 20);
            this.P1y.TabIndex = 2;
            this.P1y.Text = "-50";
            // 
            // P2y
            // 
            this.P2y.Location = new System.Drawing.Point(693, 68);
            this.P2y.Name = "P2y";
            this.P2y.Size = new System.Drawing.Size(100, 20);
            this.P2y.TabIndex = 4;
            this.P2y.Text = "50";
            // 
            // P2x
            // 
            this.P2x.Location = new System.Drawing.Point(587, 68);
            this.P2x.Name = "P2x";
            this.P2x.Size = new System.Drawing.Size(100, 20);
            this.P2x.TabIndex = 3;
            this.P2x.Text = "50";
            // 
            // Q1y
            // 
            this.Q1y.Location = new System.Drawing.Point(693, 112);
            this.Q1y.Name = "Q1y";
            this.Q1y.Size = new System.Drawing.Size(100, 20);
            this.Q1y.TabIndex = 6;
            this.Q1y.Text = "-100";
            // 
            // Q1x
            // 
            this.Q1x.Location = new System.Drawing.Point(587, 112);
            this.Q1x.Name = "Q1x";
            this.Q1x.Size = new System.Drawing.Size(100, 20);
            this.Q1x.TabIndex = 5;
            this.Q1x.Text = "100";
            // 
            // Q2y
            // 
            this.Q2y.Location = new System.Drawing.Point(693, 157);
            this.Q2y.Name = "Q2y";
            this.Q2y.Size = new System.Drawing.Size(100, 20);
            this.Q2y.TabIndex = 8;
            this.Q2y.Text = "100";
            // 
            // Q2x
            // 
            this.Q2x.Location = new System.Drawing.Point(587, 157);
            this.Q2x.Name = "Q2x";
            this.Q2x.Size = new System.Drawing.Size(100, 20);
            this.Q2x.TabIndex = 7;
            this.Q2x.Text = "-100";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(621, 198);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 9;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(560, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "P1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(560, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(20, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "P2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(560, 160);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(21, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Q2";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(560, 115);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(21, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Q1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Q2y);
            this.Controls.Add(this.Q2x);
            this.Controls.Add(this.Q1y);
            this.Controls.Add(this.Q1x);
            this.Controls.Add(this.P2y);
            this.Controls.Add(this.P2x);
            this.Controls.Add(this.P1y);
            this.Controls.Add(this.P1x);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox P1x;
        private System.Windows.Forms.TextBox P1y;
        private System.Windows.Forms.TextBox P2y;
        private System.Windows.Forms.TextBox P2x;
        private System.Windows.Forms.TextBox Q1y;
        private System.Windows.Forms.TextBox Q1x;
        private System.Windows.Forms.TextBox Q2y;
        private System.Windows.Forms.TextBox Q2x;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}

