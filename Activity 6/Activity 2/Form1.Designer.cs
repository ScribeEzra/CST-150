namespace Activity_2
{
    partial class tempConversionForm
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
            this.converterDescription1 = new System.Windows.Forms.Label();
            this.converterDescription2 = new System.Windows.Forms.Label();
            this.degreesLabel1 = new System.Windows.Forms.Label();
            this.degreesLabel2 = new System.Windows.Forms.Label();
            this.userInputFahrenheit = new System.Windows.Forms.TextBox();
            this.userInputCelsius = new System.Windows.Forms.TextBox();
            this.convertButton1 = new System.Windows.Forms.Button();
            this.convertButton2 = new System.Windows.Forms.Button();
            this.conversionDisplay1 = new System.Windows.Forms.Label();
            this.conversionDisplay2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // converterDescription1
            // 
            this.converterDescription1.AutoSize = true;
            this.converterDescription1.Font = new System.Drawing.Font("Microsoft Uighur", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.converterDescription1.Location = new System.Drawing.Point(92, 9);
            this.converterDescription1.Name = "converterDescription1";
            this.converterDescription1.Size = new System.Drawing.Size(326, 41);
            this.converterDescription1.TabIndex = 0;
            this.converterDescription1.Text = "Convert Fahrenheit to Celsius";
            // 
            // converterDescription2
            // 
            this.converterDescription2.AutoSize = true;
            this.converterDescription2.Font = new System.Drawing.Font("Microsoft Uighur", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.converterDescription2.Location = new System.Drawing.Point(92, 211);
            this.converterDescription2.Name = "converterDescription2";
            this.converterDescription2.Size = new System.Drawing.Size(326, 41);
            this.converterDescription2.TabIndex = 1;
            this.converterDescription2.Text = "Convert Celsius to Fahrenheit";
            // 
            // degreesLabel1
            // 
            this.degreesLabel1.AutoSize = true;
            this.degreesLabel1.Location = new System.Drawing.Point(292, 64);
            this.degreesLabel1.Name = "degreesLabel1";
            this.degreesLabel1.Size = new System.Drawing.Size(126, 16);
            this.degreesLabel1.TabIndex = 2;
            this.degreesLabel1.Text = "Degrees Fahrenheit";
            // 
            // degreesLabel2
            // 
            this.degreesLabel2.AutoSize = true;
            this.degreesLabel2.Location = new System.Drawing.Point(292, 268);
            this.degreesLabel2.Name = "degreesLabel2";
            this.degreesLabel2.Size = new System.Drawing.Size(107, 16);
            this.degreesLabel2.TabIndex = 3;
            this.degreesLabel2.Text = "Degrees Celsius";
            // 
            // userInputFahrenheit
            // 
            this.userInputFahrenheit.Location = new System.Drawing.Point(127, 61);
            this.userInputFahrenheit.Name = "userInputFahrenheit";
            this.userInputFahrenheit.Size = new System.Drawing.Size(149, 22);
            this.userInputFahrenheit.TabIndex = 4;
            // 
            // userInputCelsius
            // 
            this.userInputCelsius.Location = new System.Drawing.Point(127, 265);
            this.userInputCelsius.Name = "userInputCelsius";
            this.userInputCelsius.Size = new System.Drawing.Size(149, 22);
            this.userInputCelsius.TabIndex = 5;
            // 
            // convertButton1
            // 
            this.convertButton1.Location = new System.Drawing.Point(186, 107);
            this.convertButton1.Name = "convertButton1";
            this.convertButton1.Size = new System.Drawing.Size(124, 27);
            this.convertButton1.TabIndex = 6;
            this.convertButton1.Text = "Convert";
            this.convertButton1.UseVisualStyleBackColor = true;
            this.convertButton1.Click += new System.EventHandler(this.convertButton1_Click);
            // 
            // convertButton2
            // 
            this.convertButton2.Location = new System.Drawing.Point(186, 306);
            this.convertButton2.Name = "convertButton2";
            this.convertButton2.Size = new System.Drawing.Size(124, 27);
            this.convertButton2.TabIndex = 7;
            this.convertButton2.Text = "Convert";
            this.convertButton2.UseVisualStyleBackColor = true;
            this.convertButton2.Click += new System.EventHandler(this.convertButton2_Click);
            // 
            // conversionDisplay1
            // 
            this.conversionDisplay1.AutoSize = true;
            this.conversionDisplay1.Location = new System.Drawing.Point(232, 163);
            this.conversionDisplay1.Name = "conversionDisplay1";
            this.conversionDisplay1.Size = new System.Drawing.Size(0, 16);
            this.conversionDisplay1.TabIndex = 8;
            this.conversionDisplay1.Click += new System.EventHandler(this.label1_Click);
            // 
            // conversionDisplay2
            // 
            this.conversionDisplay2.AutoSize = true;
            this.conversionDisplay2.Location = new System.Drawing.Point(232, 363);
            this.conversionDisplay2.Name = "conversionDisplay2";
            this.conversionDisplay2.Size = new System.Drawing.Size(0, 16);
            this.conversionDisplay2.TabIndex = 9;
            // 
            // tempConversionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Activity_2.Properties.Resources.FireIce;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(486, 431);
            this.Controls.Add(this.conversionDisplay2);
            this.Controls.Add(this.conversionDisplay1);
            this.Controls.Add(this.convertButton2);
            this.Controls.Add(this.convertButton1);
            this.Controls.Add(this.userInputCelsius);
            this.Controls.Add(this.userInputFahrenheit);
            this.Controls.Add(this.degreesLabel2);
            this.Controls.Add(this.degreesLabel1);
            this.Controls.Add(this.converterDescription2);
            this.Controls.Add(this.converterDescription1);
            this.Name = "tempConversionForm";
            this.Text = "Temperature Conversion";
            this.Load += new System.EventHandler(this.tempConversionForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label converterDescription1;
        private System.Windows.Forms.Label converterDescription2;
        private System.Windows.Forms.Label degreesLabel1;
        private System.Windows.Forms.Label degreesLabel2;
        private System.Windows.Forms.TextBox userInputFahrenheit;
        private System.Windows.Forms.TextBox userInputCelsius;
        private System.Windows.Forms.Button convertButton1;
        private System.Windows.Forms.Button convertButton2;
        private System.Windows.Forms.Label conversionDisplay1;
        private System.Windows.Forms.Label conversionDisplay2;
    }
}

