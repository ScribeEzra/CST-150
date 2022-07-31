namespace Activity_4
{
    partial class timeCalculationForm
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
            this.instructionsLabel1 = new System.Windows.Forms.Label();
            this.instructionsLabel2 = new System.Windows.Forms.Label();
            this.userInputSeconds = new System.Windows.Forms.TextBox();
            this.userInputDisplay = new System.Windows.Forms.Label();
            this.convertedValueDisplay = new System.Windows.Forms.Label();
            this.timeConvertButton = new System.Windows.Forms.Button();
            this.userInputLabel = new System.Windows.Forms.Label();
            this.convertedDaysLabel = new System.Windows.Forms.Label();
            this.convertedHoursLabel = new System.Windows.Forms.Label();
            this.convertedMinutesLabel = new System.Windows.Forms.Label();
            this.convertedSecondsLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // instructionsLabel1
            // 
            this.instructionsLabel1.AutoSize = true;
            this.instructionsLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.instructionsLabel1.Location = new System.Drawing.Point(22, 9);
            this.instructionsLabel1.Name = "instructionsLabel1";
            this.instructionsLabel1.Size = new System.Drawing.Size(372, 20);
            this.instructionsLabel1.TabIndex = 0;
            this.instructionsLabel1.Text = "Enter any number of seconds and see how many";
            // 
            // instructionsLabel2
            // 
            this.instructionsLabel2.AutoSize = true;
            this.instructionsLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.instructionsLabel2.Location = new System.Drawing.Point(46, 29);
            this.instructionsLabel2.Name = "instructionsLabel2";
            this.instructionsLabel2.Size = new System.Drawing.Size(309, 20);
            this.instructionsLabel2.TabIndex = 1;
            this.instructionsLabel2.Text = "Days, Hours, and Minutes it converts to.";
            // 
            // userInputSeconds
            // 
            this.userInputSeconds.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userInputSeconds.Location = new System.Drawing.Point(92, 65);
            this.userInputSeconds.Name = "userInputSeconds";
            this.userInputSeconds.Size = new System.Drawing.Size(228, 27);
            this.userInputSeconds.TabIndex = 2;
            // 
            // userInputDisplay
            // 
            this.userInputDisplay.AutoSize = true;
            this.userInputDisplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userInputDisplay.Location = new System.Drawing.Point(177, 154);
            this.userInputDisplay.Name = "userInputDisplay";
            this.userInputDisplay.Size = new System.Drawing.Size(0, 20);
            this.userInputDisplay.TabIndex = 3;
            // 
            // convertedValueDisplay
            // 
            this.convertedValueDisplay.AutoSize = true;
            this.convertedValueDisplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.convertedValueDisplay.Location = new System.Drawing.Point(177, 174);
            this.convertedValueDisplay.Name = "convertedValueDisplay";
            this.convertedValueDisplay.Size = new System.Drawing.Size(0, 20);
            this.convertedValueDisplay.TabIndex = 4;
            // 
            // timeConvertButton
            // 
            this.timeConvertButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timeConvertButton.Location = new System.Drawing.Point(155, 98);
            this.timeConvertButton.Name = "timeConvertButton";
            this.timeConvertButton.Size = new System.Drawing.Size(97, 42);
            this.timeConvertButton.TabIndex = 5;
            this.timeConvertButton.Text = "Convert";
            this.timeConvertButton.UseVisualStyleBackColor = true;
            this.timeConvertButton.Click += new System.EventHandler(this.timeConvertButton_Click);
            // 
            // userInputLabel
            // 
            this.userInputLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userInputLabel.Location = new System.Drawing.Point(12, 143);
            this.userInputLabel.Name = "userInputLabel";
            this.userInputLabel.Size = new System.Drawing.Size(400, 20);
            this.userInputLabel.TabIndex = 6;
            this.userInputLabel.Text = "label1";
            this.userInputLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // convertedDaysLabel
            // 
            this.convertedDaysLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.convertedDaysLabel.Location = new System.Drawing.Point(12, 174);
            this.convertedDaysLabel.Name = "convertedDaysLabel";
            this.convertedDaysLabel.Size = new System.Drawing.Size(400, 20);
            this.convertedDaysLabel.TabIndex = 7;
            this.convertedDaysLabel.Text = "label1";
            this.convertedDaysLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // convertedHoursLabel
            // 
            this.convertedHoursLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.convertedHoursLabel.Location = new System.Drawing.Point(12, 194);
            this.convertedHoursLabel.Name = "convertedHoursLabel";
            this.convertedHoursLabel.Size = new System.Drawing.Size(400, 20);
            this.convertedHoursLabel.TabIndex = 8;
            this.convertedHoursLabel.Text = "label1";
            this.convertedHoursLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // convertedMinutesLabel
            // 
            this.convertedMinutesLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.convertedMinutesLabel.Location = new System.Drawing.Point(12, 214);
            this.convertedMinutesLabel.Name = "convertedMinutesLabel";
            this.convertedMinutesLabel.Size = new System.Drawing.Size(400, 20);
            this.convertedMinutesLabel.TabIndex = 9;
            this.convertedMinutesLabel.Text = "label1";
            this.convertedMinutesLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // convertedSecondsLabel
            // 
            this.convertedSecondsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.convertedSecondsLabel.Location = new System.Drawing.Point(12, 234);
            this.convertedSecondsLabel.Name = "convertedSecondsLabel";
            this.convertedSecondsLabel.Size = new System.Drawing.Size(400, 20);
            this.convertedSecondsLabel.TabIndex = 10;
            this.convertedSecondsLabel.Text = "label1";
            this.convertedSecondsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timeCalculationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(457, 283);
            this.Controls.Add(this.convertedSecondsLabel);
            this.Controls.Add(this.convertedMinutesLabel);
            this.Controls.Add(this.convertedHoursLabel);
            this.Controls.Add(this.convertedDaysLabel);
            this.Controls.Add(this.userInputLabel);
            this.Controls.Add(this.timeConvertButton);
            this.Controls.Add(this.convertedValueDisplay);
            this.Controls.Add(this.userInputDisplay);
            this.Controls.Add(this.userInputSeconds);
            this.Controls.Add(this.instructionsLabel2);
            this.Controls.Add(this.instructionsLabel1);
            this.Name = "timeCalculationForm";
            this.Text = "Time Calculation";
            this.Load += new System.EventHandler(this.timeCalculationForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label instructionsLabel1;
        private System.Windows.Forms.Label instructionsLabel2;
        private System.Windows.Forms.TextBox userInputSeconds;
        private System.Windows.Forms.Label userInputDisplay;
        private System.Windows.Forms.Label convertedValueDisplay;
        private System.Windows.Forms.Button timeConvertButton;
        private System.Windows.Forms.Label userInputLabel;
        private System.Windows.Forms.Label convertedDaysLabel;
        private System.Windows.Forms.Label convertedHoursLabel;
        private System.Windows.Forms.Label convertedMinutesLabel;
        private System.Windows.Forms.Label convertedSecondsLabel;
    }
}

