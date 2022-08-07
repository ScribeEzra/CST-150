namespace Activity_7
{
    partial class aproximatedPi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(aproximatedPi));
            this.directionsLabel1 = new System.Windows.Forms.Label();
            this.DirectionsLabel2 = new System.Windows.Forms.Label();
            this.integerInput = new System.Windows.Forms.TextBox();
            this.calcTermsOfPi = new System.Windows.Forms.Button();
            this.piAproxValDisplay = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // directionsLabel1
            // 
            this.directionsLabel1.AutoSize = true;
            this.directionsLabel1.BackColor = System.Drawing.SystemColors.Control;
            this.directionsLabel1.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.directionsLabel1.ForeColor = System.Drawing.Color.DodgerBlue;
            this.directionsLabel1.Location = new System.Drawing.Point(23, 54);
            this.directionsLabel1.Name = "directionsLabel1";
            this.directionsLabel1.Size = new System.Drawing.Size(170, 24);
            this.directionsLabel1.TabIndex = 0;
            this.directionsLabel1.Text = "Pi Aproximated To";
            // 
            // DirectionsLabel2
            // 
            this.DirectionsLabel2.AutoSize = true;
            this.DirectionsLabel2.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DirectionsLabel2.ForeColor = System.Drawing.Color.DodgerBlue;
            this.DirectionsLabel2.Location = new System.Drawing.Point(379, 54);
            this.DirectionsLabel2.Name = "DirectionsLabel2";
            this.DirectionsLabel2.Size = new System.Drawing.Size(82, 24);
            this.DirectionsLabel2.TabIndex = 1;
            this.DirectionsLabel2.Text = "Terms Is";
            // 
            // integerInput
            // 
            this.integerInput.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.integerInput.Location = new System.Drawing.Point(217, 51);
            this.integerInput.Name = "integerInput";
            this.integerInput.Size = new System.Drawing.Size(137, 30);
            this.integerInput.TabIndex = 2;
            // 
            // calcTermsOfPi
            // 
            this.calcTermsOfPi.BackColor = System.Drawing.Color.Gainsboro;
            this.calcTermsOfPi.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.calcTermsOfPi.ForeColor = System.Drawing.Color.SlateGray;
            this.calcTermsOfPi.Location = new System.Drawing.Point(167, 114);
            this.calcTermsOfPi.Name = "calcTermsOfPi";
            this.calcTermsOfPi.Size = new System.Drawing.Size(140, 34);
            this.calcTermsOfPi.TabIndex = 3;
            this.calcTermsOfPi.Text = "Calculate";
            this.calcTermsOfPi.UseVisualStyleBackColor = false;
            this.calcTermsOfPi.Click += new System.EventHandler(this.calcTermsOfPi_Click);
            // 
            // piAproxValDisplay
            // 
            this.piAproxValDisplay.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.piAproxValDisplay.ForeColor = System.Drawing.Color.DodgerBlue;
            this.piAproxValDisplay.Location = new System.Drawing.Point(90, 174);
            this.piAproxValDisplay.Name = "piAproxValDisplay";
            this.piAproxValDisplay.Size = new System.Drawing.Size(300, 25);
            this.piAproxValDisplay.TabIndex = 4;
            this.piAproxValDisplay.Text = "label1";
            this.piAproxValDisplay.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // aproximatedPi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(497, 260);
            this.Controls.Add(this.piAproxValDisplay);
            this.Controls.Add(this.calcTermsOfPi);
            this.Controls.Add(this.integerInput);
            this.Controls.Add(this.DirectionsLabel2);
            this.Controls.Add(this.directionsLabel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "aproximatedPi";
            this.Text = "Pi Aproximated";
            this.Load += new System.EventHandler(this.aproximatedPi_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label directionsLabel1;
        private System.Windows.Forms.Label DirectionsLabel2;
        private System.Windows.Forms.TextBox integerInput;
        private System.Windows.Forms.Button calcTermsOfPi;
        private System.Windows.Forms.Label piAproxValDisplay;
    }
}

