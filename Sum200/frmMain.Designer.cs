namespace Sum200
{
    partial class frmMain
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtHalfway = new System.Windows.Forms.TextBox();
            this.txtSum = new System.Windows.Forms.TextBox();
            this.Sum = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(17, 30);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(88, 24);
            this.button1.TabIndex = 0;
            this.button1.Text = "Start";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(111, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Halfway Total";
            // 
            // txtHalfway
            // 
            this.txtHalfway.Location = new System.Drawing.Point(17, 85);
            this.txtHalfway.Name = "txtHalfway";
            this.txtHalfway.Size = new System.Drawing.Size(88, 20);
            this.txtHalfway.TabIndex = 2;
            this.txtHalfway.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtSum
            // 
            this.txtSum.Location = new System.Drawing.Point(17, 111);
            this.txtSum.Name = "txtSum";
            this.txtSum.ReadOnly = true;
            this.txtSum.Size = new System.Drawing.Size(88, 20);
            this.txtSum.TabIndex = 4;
            this.txtSum.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // Sum
            // 
            this.Sum.AutoSize = true;
            this.Sum.Location = new System.Drawing.Point(111, 114);
            this.Sum.Name = "Sum";
            this.Sum.Size = new System.Drawing.Size(28, 13);
            this.Sum.TabIndex = 3;
            this.Sum.Text = "Sum";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(351, 373);
            this.Controls.Add(this.txtSum);
            this.Controls.Add(this.Sum);
            this.Controls.Add(this.txtHalfway);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Name = "frmMain";
            this.Text = "Sum 200";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtHalfway;
        private System.Windows.Forms.TextBox txtSum;
        private System.Windows.Forms.Label Sum;
    }
}

