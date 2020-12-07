namespace _09_RichTextBox_kontrola
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
            this.CitajButton = new System.Windows.Forms.Button();
            this.BrisiButton = new System.Windows.Forms.Button();
            this.SpremiButton = new System.Windows.Forms.Button();
            this.RichBox = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // CitajButton
            // 
            this.CitajButton.Location = new System.Drawing.Point(137, 56);
            this.CitajButton.Name = "CitajButton";
            this.CitajButton.Size = new System.Drawing.Size(75, 23);
            this.CitajButton.TabIndex = 0;
            this.CitajButton.Text = "Citaj";
            this.CitajButton.UseVisualStyleBackColor = true;
            this.CitajButton.Click += new System.EventHandler(this.CitajButton_Click);
            // 
            // BrisiButton
            // 
            this.BrisiButton.Location = new System.Drawing.Point(317, 56);
            this.BrisiButton.Name = "BrisiButton";
            this.BrisiButton.Size = new System.Drawing.Size(75, 23);
            this.BrisiButton.TabIndex = 1;
            this.BrisiButton.Text = "Brisi";
            this.BrisiButton.UseVisualStyleBackColor = true;
            this.BrisiButton.Click += new System.EventHandler(this.BrisiButton_Click);
            // 
            // SpremiButton
            // 
            this.SpremiButton.Location = new System.Drawing.Point(137, 356);
            this.SpremiButton.Name = "SpremiButton";
            this.SpremiButton.Size = new System.Drawing.Size(75, 23);
            this.SpremiButton.TabIndex = 2;
            this.SpremiButton.Text = "Spremi";
            this.SpremiButton.UseVisualStyleBackColor = true;
            this.SpremiButton.Click += new System.EventHandler(this.SpremiButton_Click);
            // 
            // RichBox
            // 
            this.RichBox.Location = new System.Drawing.Point(137, 132);
            this.RichBox.Name = "RichBox";
            this.RichBox.Size = new System.Drawing.Size(255, 178);
            this.RichBox.TabIndex = 3;
            this.RichBox.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.RichBox);
            this.Controls.Add(this.SpremiButton);
            this.Controls.Add(this.BrisiButton);
            this.Controls.Add(this.CitajButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button CitajButton;
        private System.Windows.Forms.Button BrisiButton;
        private System.Windows.Forms.Button SpremiButton;
        private System.Windows.Forms.RichTextBox RichBox;
    }
}

