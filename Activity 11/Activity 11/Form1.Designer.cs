namespace Activity_11
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
            this.die1Display = new System.Windows.Forms.Label();
            this.die2Display = new System.Windows.Forms.Label();
            this.die1Label = new System.Windows.Forms.Label();
            this.die2Label = new System.Windows.Forms.Label();
            this.sidesLabel = new System.Windows.Forms.Label();
            this.diceSidesInput = new System.Windows.Forms.TextBox();
            this.rollDieButton = new System.Windows.Forms.Button();
            this.diceRollLog = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // die1Display
            // 
            this.die1Display.BackColor = System.Drawing.Color.White;
            this.die1Display.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.die1Display.Font = new System.Drawing.Font("Felix Titling", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.die1Display.Location = new System.Drawing.Point(30, 63);
            this.die1Display.Name = "die1Display";
            this.die1Display.Size = new System.Drawing.Size(150, 150);
            this.die1Display.TabIndex = 0;
            this.die1Display.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // die2Display
            // 
            this.die2Display.BackColor = System.Drawing.Color.White;
            this.die2Display.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.die2Display.Font = new System.Drawing.Font("Felix Titling", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.die2Display.Location = new System.Drawing.Point(216, 63);
            this.die2Display.Name = "die2Display";
            this.die2Display.Size = new System.Drawing.Size(150, 150);
            this.die2Display.TabIndex = 1;
            this.die2Display.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // die1Label
            // 
            this.die1Label.AutoSize = true;
            this.die1Label.BackColor = System.Drawing.Color.Transparent;
            this.die1Label.Font = new System.Drawing.Font("Franklin Gothic Book", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.die1Label.ForeColor = System.Drawing.Color.Snow;
            this.die1Label.Location = new System.Drawing.Point(62, 24);
            this.die1Label.Name = "die1Label";
            this.die1Label.Size = new System.Drawing.Size(90, 38);
            this.die1Label.TabIndex = 2;
            this.die1Label.Text = "Die 1";
            // 
            // die2Label
            // 
            this.die2Label.AutoSize = true;
            this.die2Label.BackColor = System.Drawing.Color.Transparent;
            this.die2Label.Font = new System.Drawing.Font("Franklin Gothic Book", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.die2Label.ForeColor = System.Drawing.Color.Snow;
            this.die2Label.Location = new System.Drawing.Point(245, 24);
            this.die2Label.Name = "die2Label";
            this.die2Label.Size = new System.Drawing.Size(90, 38);
            this.die2Label.TabIndex = 3;
            this.die2Label.Text = "Die 2";
            // 
            // sidesLabel
            // 
            this.sidesLabel.AutoSize = true;
            this.sidesLabel.BackColor = System.Drawing.Color.Transparent;
            this.sidesLabel.Font = new System.Drawing.Font("Franklin Gothic Book", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sidesLabel.ForeColor = System.Drawing.Color.Snow;
            this.sidesLabel.Location = new System.Drawing.Point(388, 63);
            this.sidesLabel.Name = "sidesLabel";
            this.sidesLabel.Size = new System.Drawing.Size(143, 29);
            this.sidesLabel.TabIndex = 4;
            this.sidesLabel.Text = "Sides (4-20)";
            // 
            // diceSidesInput
            // 
            this.diceSidesInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.diceSidesInput.Location = new System.Drawing.Point(393, 104);
            this.diceSidesInput.Name = "diceSidesInput";
            this.diceSidesInput.Size = new System.Drawing.Size(138, 27);
            this.diceSidesInput.TabIndex = 5;
            // 
            // rollDieButton
            // 
            this.rollDieButton.Font = new System.Drawing.Font("Franklin Gothic Book", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rollDieButton.Location = new System.Drawing.Point(393, 159);
            this.rollDieButton.Name = "rollDieButton";
            this.rollDieButton.Size = new System.Drawing.Size(138, 54);
            this.rollDieButton.TabIndex = 6;
            this.rollDieButton.Text = "Roll Dice";
            this.rollDieButton.UseVisualStyleBackColor = true;
            this.rollDieButton.Click += new System.EventHandler(this.rollDieButton_Click);
            // 
            // diceRollLog
            // 
            this.diceRollLog.BackColor = System.Drawing.Color.Black;
            this.diceRollLog.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.diceRollLog.ForeColor = System.Drawing.Color.White;
            this.diceRollLog.FormattingEnabled = true;
            this.diceRollLog.ItemHeight = 20;
            this.diceRollLog.Location = new System.Drawing.Point(30, 243);
            this.diceRollLog.Name = "diceRollLog";
            this.diceRollLog.ScrollAlwaysVisible = true;
            this.diceRollLog.Size = new System.Drawing.Size(499, 104);
            this.diceRollLog.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.IndianRed;
            this.ClientSize = new System.Drawing.Size(570, 391);
            this.Controls.Add(this.diceRollLog);
            this.Controls.Add(this.rollDieButton);
            this.Controls.Add(this.diceSidesInput);
            this.Controls.Add(this.sidesLabel);
            this.Controls.Add(this.die2Label);
            this.Controls.Add(this.die1Label);
            this.Controls.Add(this.die2Display);
            this.Controls.Add(this.die1Display);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label die1Display;
        private System.Windows.Forms.Label die2Display;
        private System.Windows.Forms.Label die1Label;
        private System.Windows.Forms.Label die2Label;
        private System.Windows.Forms.Label sidesLabel;
        private System.Windows.Forms.TextBox diceSidesInput;
        private System.Windows.Forms.Button rollDieButton;
        private System.Windows.Forms.ListBox diceRollLog;
    }
}

