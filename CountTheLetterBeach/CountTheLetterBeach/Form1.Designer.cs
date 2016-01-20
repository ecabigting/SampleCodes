namespace CountTheLetterBeach
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
            this.txtLettersToCount = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lstShowCount = new System.Windows.Forms.ListBox();
            this.btnCountBitch = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtLettersToCount
            // 
            this.txtLettersToCount.Location = new System.Drawing.Point(12, 34);
            this.txtLettersToCount.Name = "txtLettersToCount";
            this.txtLettersToCount.Size = new System.Drawing.Size(561, 22);
            this.txtLettersToCount.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Letters To Count";
            // 
            // lstShowCount
            // 
            this.lstShowCount.FormattingEnabled = true;
            this.lstShowCount.ItemHeight = 16;
            this.lstShowCount.Location = new System.Drawing.Point(15, 63);
            this.lstShowCount.Name = "lstShowCount";
            this.lstShowCount.Size = new System.Drawing.Size(558, 180);
            this.lstShowCount.TabIndex = 2;
            // 
            // btnCountBitch
            // 
            this.btnCountBitch.Location = new System.Drawing.Point(287, 249);
            this.btnCountBitch.Name = "btnCountBitch";
            this.btnCountBitch.Size = new System.Drawing.Size(140, 40);
            this.btnCountBitch.TabIndex = 3;
            this.btnCountBitch.Text = "Count this bitch";
            this.btnCountBitch.UseVisualStyleBackColor = true;
            this.btnCountBitch.Click += new System.EventHandler(this.btnCountBitch_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(433, 249);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(140, 40);
            this.btnClear.TabIndex = 4;
            this.btnClear.Text = "Clear out Bitch";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(588, 295);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnCountBitch);
            this.Controls.Add(this.lstShowCount);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtLettersToCount);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.Text = "Count The Letters Beach!";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtLettersToCount;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lstShowCount;
        private System.Windows.Forms.Button btnCountBitch;
        private System.Windows.Forms.Button btnClear;
    }
}

