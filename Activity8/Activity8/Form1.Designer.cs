namespace Activity8
{
    partial class CalorieCounter
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CalorieCounter));
            this.instructionLabel2 = new System.Windows.Forms.Label();
            this.instructionLabel1 = new System.Windows.Forms.Label();
            this.instructionLabel3 = new System.Windows.Forms.Label();
            this.fatGramsInput = new System.Windows.Forms.TextBox();
            this.instructionLabel4 = new System.Windows.Forms.Label();
            this.instructionLabel5 = new System.Windows.Forms.Label();
            this.carbGramsInput = new System.Windows.Forms.TextBox();
            this.instructionLabel6 = new System.Windows.Forms.Label();
            this.instructionLabel7 = new System.Windows.Forms.Label();
            this.displayCaloriesFromFat = new System.Windows.Forms.Label();
            this.displayCaloriesFromCarbs = new System.Windows.Forms.Label();
            this.calculateFatCalories = new System.Windows.Forms.Button();
            this.calculateCarbCalories = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // instructionLabel2
            // 
            this.instructionLabel2.AutoSize = true;
            this.instructionLabel2.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.instructionLabel2.Location = new System.Drawing.Point(74, 82);
            this.instructionLabel2.Name = "instructionLabel2";
            this.instructionLabel2.Size = new System.Drawing.Size(461, 21);
            this.instructionLabel2.TabIndex = 0;
            this.instructionLabel2.Text = "First, how many grams of fat do you consume in a day?";
            // 
            // instructionLabel1
            // 
            this.instructionLabel1.AutoSize = true;
            this.instructionLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.instructionLabel1.Location = new System.Drawing.Point(102, 29);
            this.instructionLabel1.Name = "instructionLabel1";
            this.instructionLabel1.Size = new System.Drawing.Size(408, 32);
            this.instructionLabel1.TabIndex = 1;
            this.instructionLabel1.Text = "Let\'s Calculate Your Calories";
            // 
            // instructionLabel3
            // 
            this.instructionLabel3.AutoSize = true;
            this.instructionLabel3.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.instructionLabel3.Location = new System.Drawing.Point(34, 208);
            this.instructionLabel3.Name = "instructionLabel3";
            this.instructionLabel3.Size = new System.Drawing.Size(554, 21);
            this.instructionLabel3.TabIndex = 2;
            this.instructionLabel3.Text = "Next, how many grams of carbohydrates do you consume in a day?";
            // 
            // fatGramsInput
            // 
            this.fatGramsInput.Font = new System.Drawing.Font("Mongolian Baiti", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fatGramsInput.Location = new System.Drawing.Point(38, 128);
            this.fatGramsInput.Name = "fatGramsInput";
            this.fatGramsInput.Size = new System.Drawing.Size(120, 27);
            this.fatGramsInput.TabIndex = 3;
            // 
            // instructionLabel4
            // 
            this.instructionLabel4.AutoSize = true;
            this.instructionLabel4.Font = new System.Drawing.Font("Mongolian Baiti", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.instructionLabel4.Location = new System.Drawing.Point(164, 131);
            this.instructionLabel4.Name = "instructionLabel4";
            this.instructionLabel4.Size = new System.Drawing.Size(155, 18);
            this.instructionLabel4.TabIndex = 4;
            this.instructionLabel4.Text = "grams of fat result in";
            // 
            // instructionLabel5
            // 
            this.instructionLabel5.AutoSize = true;
            this.instructionLabel5.Font = new System.Drawing.Font("Mongolian Baiti", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.instructionLabel5.Location = new System.Drawing.Point(507, 131);
            this.instructionLabel5.Name = "instructionLabel5";
            this.instructionLabel5.Size = new System.Drawing.Size(68, 18);
            this.instructionLabel5.TabIndex = 5;
            this.instructionLabel5.Text = "calories.";
            // 
            // carbGramsInput
            // 
            this.carbGramsInput.Font = new System.Drawing.Font("Mongolian Baiti", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.carbGramsInput.Location = new System.Drawing.Point(38, 253);
            this.carbGramsInput.Name = "carbGramsInput";
            this.carbGramsInput.Size = new System.Drawing.Size(120, 27);
            this.carbGramsInput.TabIndex = 6;
            // 
            // instructionLabel6
            // 
            this.instructionLabel6.AutoSize = true;
            this.instructionLabel6.Font = new System.Drawing.Font("Mongolian Baiti", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.instructionLabel6.Location = new System.Drawing.Point(164, 256);
            this.instructionLabel6.Name = "instructionLabel6";
            this.instructionLabel6.Size = new System.Drawing.Size(174, 18);
            this.instructionLabel6.TabIndex = 7;
            this.instructionLabel6.Text = "grams of carbs result in";
            // 
            // instructionLabel7
            // 
            this.instructionLabel7.AutoSize = true;
            this.instructionLabel7.Font = new System.Drawing.Font("Mongolian Baiti", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.instructionLabel7.Location = new System.Drawing.Point(507, 256);
            this.instructionLabel7.Name = "instructionLabel7";
            this.instructionLabel7.Size = new System.Drawing.Size(68, 18);
            this.instructionLabel7.TabIndex = 8;
            this.instructionLabel7.Text = "calories.";
            // 
            // displayCaloriesFromFat
            // 
            this.displayCaloriesFromFat.Font = new System.Drawing.Font("Mongolian Baiti", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.displayCaloriesFromFat.Location = new System.Drawing.Point(346, 130);
            this.displayCaloriesFromFat.Name = "displayCaloriesFromFat";
            this.displayCaloriesFromFat.Size = new System.Drawing.Size(155, 20);
            this.displayCaloriesFromFat.TabIndex = 9;
            this.displayCaloriesFromFat.Text = "Null";
            this.displayCaloriesFromFat.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // displayCaloriesFromCarbs
            // 
            this.displayCaloriesFromCarbs.Font = new System.Drawing.Font("Mongolian Baiti", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.displayCaloriesFromCarbs.Location = new System.Drawing.Point(346, 255);
            this.displayCaloriesFromCarbs.Name = "displayCaloriesFromCarbs";
            this.displayCaloriesFromCarbs.Size = new System.Drawing.Size(155, 20);
            this.displayCaloriesFromCarbs.TabIndex = 10;
            this.displayCaloriesFromCarbs.Text = "Null";
            this.displayCaloriesFromCarbs.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // calculateFatCalories
            // 
            this.calculateFatCalories.BackColor = System.Drawing.Color.Maroon;
            this.calculateFatCalories.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.calculateFatCalories.ForeColor = System.Drawing.Color.MistyRose;
            this.calculateFatCalories.Location = new System.Drawing.Point(262, 164);
            this.calculateFatCalories.Name = "calculateFatCalories";
            this.calculateFatCalories.Size = new System.Drawing.Size(125, 30);
            this.calculateFatCalories.TabIndex = 11;
            this.calculateFatCalories.Text = "Calculate";
            this.calculateFatCalories.UseVisualStyleBackColor = false;
            this.calculateFatCalories.Click += new System.EventHandler(this.calculateFatCalories_Click);
            // 
            // calculateCarbCalories
            // 
            this.calculateCarbCalories.BackColor = System.Drawing.Color.Maroon;
            this.calculateCarbCalories.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.calculateCarbCalories.ForeColor = System.Drawing.Color.MistyRose;
            this.calculateCarbCalories.Location = new System.Drawing.Point(262, 291);
            this.calculateCarbCalories.Name = "calculateCarbCalories";
            this.calculateCarbCalories.Size = new System.Drawing.Size(125, 30);
            this.calculateCarbCalories.TabIndex = 12;
            this.calculateCarbCalories.Text = "Calculate";
            this.calculateCarbCalories.UseVisualStyleBackColor = false;
            this.calculateCarbCalories.Click += new System.EventHandler(this.calculateCarbCalories_Click);
            // 
            // CalorieCounter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LemonChiffon;
            this.BackgroundImage = global::Activity8.Properties.Resources.redsframe;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(645, 365);
            this.Controls.Add(this.calculateCarbCalories);
            this.Controls.Add(this.calculateFatCalories);
            this.Controls.Add(this.displayCaloriesFromCarbs);
            this.Controls.Add(this.displayCaloriesFromFat);
            this.Controls.Add(this.instructionLabel7);
            this.Controls.Add(this.instructionLabel6);
            this.Controls.Add(this.carbGramsInput);
            this.Controls.Add(this.instructionLabel5);
            this.Controls.Add(this.instructionLabel4);
            this.Controls.Add(this.fatGramsInput);
            this.Controls.Add(this.instructionLabel3);
            this.Controls.Add(this.instructionLabel1);
            this.Controls.Add(this.instructionLabel2);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.Color.Maroon;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CalorieCounter";
            this.Text = "Calorie Counter";
            this.Load += new System.EventHandler(this.CalorieCounter_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label instructionLabel2;
        private System.Windows.Forms.Label instructionLabel1;
        private System.Windows.Forms.Label instructionLabel3;
        private System.Windows.Forms.TextBox fatGramsInput;
        private System.Windows.Forms.Label instructionLabel4;
        private System.Windows.Forms.Label instructionLabel5;
        private System.Windows.Forms.TextBox carbGramsInput;
        private System.Windows.Forms.Label instructionLabel6;
        private System.Windows.Forms.Label instructionLabel7;
        private System.Windows.Forms.Label displayCaloriesFromFat;
        private System.Windows.Forms.Label displayCaloriesFromCarbs;
        private System.Windows.Forms.Button calculateFatCalories;
        private System.Windows.Forms.Button calculateCarbCalories;
    }
}

