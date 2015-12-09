namespace WindowsFormServiceAccess
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
            this.txtMimicThis = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtMimicNow = new System.Windows.Forms.Button();
            this.txtMimicHere = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtMimicThis
            // 
            this.txtMimicThis.Location = new System.Drawing.Point(108, 12);
            this.txtMimicThis.Name = "txtMimicThis";
            this.txtMimicThis.Size = new System.Drawing.Size(319, 22);
            this.txtMimicThis.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = " Mimic this!:";
            // 
            // txtMimicNow
            // 
            this.txtMimicNow.Location = new System.Drawing.Point(108, 40);
            this.txtMimicNow.Name = "txtMimicNow";
            this.txtMimicNow.Size = new System.Drawing.Size(319, 23);
            this.txtMimicNow.TabIndex = 2;
            this.txtMimicNow.Text = "Mimic!";
            this.txtMimicNow.UseVisualStyleBackColor = true;
            this.txtMimicNow.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtMimicHere
            // 
            this.txtMimicHere.Location = new System.Drawing.Point(108, 69);
            this.txtMimicHere.Name = "txtMimicHere";
            this.txtMimicHere.Size = new System.Drawing.Size(319, 22);
            this.txtMimicHere.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(441, 105);
            this.Controls.Add(this.txtMimicHere);
            this.Controls.Add(this.txtMimicNow);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtMimicThis);
            this.Name = "Form1";
            this.Text = "Mimic me!";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtMimicThis;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button txtMimicNow;
        private System.Windows.Forms.TextBox txtMimicHere;
    }
}

