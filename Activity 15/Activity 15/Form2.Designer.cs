namespace Activity_15
{
    partial class luckyNumberPopupForm
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
            this.congratsLabel = new System.Windows.Forms.Label();
            this.luckyNumDisplay = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // congratsLabel
            // 
            this.congratsLabel.AutoSize = true;
            this.congratsLabel.Font = new System.Drawing.Font("Maiandra GD", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.congratsLabel.ForeColor = System.Drawing.Color.Gold;
            this.congratsLabel.Location = new System.Drawing.Point(28, 9);
            this.congratsLabel.Name = "congratsLabel";
            this.congratsLabel.Size = new System.Drawing.Size(333, 72);
            this.congratsLabel.TabIndex = 8;
            this.congratsLabel.Text = "Congratulations!\r\nYour Lucky Number is...";
            this.congratsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // luckyNumDisplay
            // 
            this.luckyNumDisplay.Font = new System.Drawing.Font("Maiandra GD", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.luckyNumDisplay.ForeColor = System.Drawing.Color.Gold;
            this.luckyNumDisplay.Location = new System.Drawing.Point(12, 120);
            this.luckyNumDisplay.Name = "luckyNumDisplay";
            this.luckyNumDisplay.Size = new System.Drawing.Size(354, 88);
            this.luckyNumDisplay.TabIndex = 9;
            this.luckyNumDisplay.Text = "#";
            this.luckyNumDisplay.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // luckyNumberPopupForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkRed;
            this.ClientSize = new System.Drawing.Size(383, 307);
            this.Controls.Add(this.luckyNumDisplay);
            this.Controls.Add(this.congratsLabel);
            this.Name = "luckyNumberPopupForm";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.luckyNumberPopupForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label congratsLabel;
        private System.Windows.Forms.Label luckyNumDisplay;
    }
}