namespace Lab5_Task3
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
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.P2y = new System.Windows.Forms.TextBox();
            this.P2x = new System.Windows.Forms.TextBox();
            this.P1y = new System.Windows.Forms.TextBox();
            this.P1x = new System.Windows.Forms.TextBox();
            this.kvalue = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(555, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(20, 13);
            this.label2.TabIndex = 31;
            this.label2.Text = "P2";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(555, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 13);
            this.label1.TabIndex = 30;
            this.label1.Text = "P1";
            // 
            // P2y
            // 
            this.P2y.Location = new System.Drawing.Point(688, 56);
            this.P2y.Name = "P2y";
            this.P2y.Size = new System.Drawing.Size(100, 20);
            this.P2y.TabIndex = 29;
            this.P2y.Text = "300";
            // 
            // P2x
            // 
            this.P2x.Location = new System.Drawing.Point(582, 56);
            this.P2x.Name = "P2x";
            this.P2x.Size = new System.Drawing.Size(100, 20);
            this.P2x.TabIndex = 28;
            this.P2x.Text = "300";
            // 
            // P1y
            // 
            this.P1y.Location = new System.Drawing.Point(688, 12);
            this.P1y.Name = "P1y";
            this.P1y.Size = new System.Drawing.Size(100, 20);
            this.P1y.TabIndex = 27;
            this.P1y.Text = "300";
            // 
            // P1x
            // 
            this.P1x.Location = new System.Drawing.Point(582, 12);
            this.P1x.Name = "P1x";
            this.P1x.Size = new System.Drawing.Size(100, 20);
            this.P1x.TabIndex = 26;
            this.P1x.Text = "100";
            // 
            // kvalue
            // 
            this.kvalue.Location = new System.Drawing.Point(582, 95);
            this.kvalue.Name = "kvalue";
            this.kvalue.Size = new System.Drawing.Size(100, 20);
            this.kvalue.TabIndex = 35;
            this.kvalue.Text = "4";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(556, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(14, 13);
            this.label3.TabIndex = 36;
            this.label3.Text = "K";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(634, 138);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 37;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.kvalue);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.P2y);
            this.Controls.Add(this.P2x);
            this.Controls.Add(this.P1y);
            this.Controls.Add(this.P1x);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox P2y;
        private System.Windows.Forms.TextBox P2x;
        private System.Windows.Forms.TextBox P1y;
        private System.Windows.Forms.TextBox P1x;
        private System.Windows.Forms.TextBox kvalue;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
    }
}

