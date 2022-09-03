namespace Activity_15
{
    partial class luckyNumberForm
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
            this.titleLabel = new System.Windows.Forms.Label();
            this.bloodTypeSelect = new System.Windows.Forms.ComboBox();
            this.fortuneCookie1 = new System.Windows.Forms.PictureBox();
            this.fortuneCookie2 = new System.Windows.Forms.PictureBox();
            this.fortuneCookie3 = new System.Windows.Forms.PictureBox();
            this.fortuneCookieBox = new System.Windows.Forms.GroupBox();
            this.fortuneCookieLabel = new System.Windows.Forms.Label();
            this.generateNumberButton = new System.Windows.Forms.Button();
            this.birthYearTextbox = new System.Windows.Forms.TextBox();
            this.horoscopeLabel = new System.Windows.Forms.Label();
            this.horoscopeBox = new System.Windows.Forms.GroupBox();
            this.bloodTypeLabel = new System.Windows.Forms.Label();
            this.birthYearLabel = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.personalityLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.fortuneCookie1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fortuneCookie2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fortuneCookie3)).BeginInit();
            this.fortuneCookieBox.SuspendLayout();
            this.horoscopeBox.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("Maiandra GD", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.ForeColor = System.Drawing.Color.Gold;
            this.titleLabel.Location = new System.Drawing.Point(29, 9);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(572, 48);
            this.titleLabel.TabIndex = 0;
            this.titleLabel.Text = "Discover Your Lucky Number!";
            // 
            // bloodTypeSelect
            // 
            this.bloodTypeSelect.BackColor = System.Drawing.Color.Gold;
            this.bloodTypeSelect.Font = new System.Drawing.Font("Maiandra GD", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bloodTypeSelect.ForeColor = System.Drawing.Color.Red;
            this.bloodTypeSelect.FormattingEnabled = true;
            this.bloodTypeSelect.Items.AddRange(new object[] {
            "A",
            "O",
            "B",
            "AB",
            "Other"});
            this.bloodTypeSelect.Location = new System.Drawing.Point(8, 22);
            this.bloodTypeSelect.Name = "bloodTypeSelect";
            this.bloodTypeSelect.Size = new System.Drawing.Size(95, 28);
            this.bloodTypeSelect.TabIndex = 1;
            this.bloodTypeSelect.Text = "Type";
            this.bloodTypeSelect.SelectedIndexChanged += new System.EventHandler(this.bloodTypeSelect_SelectedIndexChanged);
            // 
            // fortuneCookie1
            // 
            this.fortuneCookie1.BackgroundImage = global::Activity_15.Properties.Resources.Fortune_Cookie;
            this.fortuneCookie1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.fortuneCookie1.Location = new System.Drawing.Point(16, 21);
            this.fortuneCookie1.Name = "fortuneCookie1";
            this.fortuneCookie1.Size = new System.Drawing.Size(125, 120);
            this.fortuneCookie1.TabIndex = 3;
            this.fortuneCookie1.TabStop = false;
            this.fortuneCookie1.Click += new System.EventHandler(this.fortuneCookie1_Click);
            // 
            // fortuneCookie2
            // 
            this.fortuneCookie2.BackgroundImage = global::Activity_15.Properties.Resources.Fortune_Cookie;
            this.fortuneCookie2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.fortuneCookie2.Location = new System.Drawing.Point(207, 21);
            this.fortuneCookie2.Name = "fortuneCookie2";
            this.fortuneCookie2.Size = new System.Drawing.Size(125, 120);
            this.fortuneCookie2.TabIndex = 4;
            this.fortuneCookie2.TabStop = false;
            this.fortuneCookie2.Click += new System.EventHandler(this.fortuneCookie2_Click);
            // 
            // fortuneCookie3
            // 
            this.fortuneCookie3.BackgroundImage = global::Activity_15.Properties.Resources.Fortune_Cookie;
            this.fortuneCookie3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.fortuneCookie3.Location = new System.Drawing.Point(397, 21);
            this.fortuneCookie3.Name = "fortuneCookie3";
            this.fortuneCookie3.Size = new System.Drawing.Size(125, 120);
            this.fortuneCookie3.TabIndex = 5;
            this.fortuneCookie3.TabStop = false;
            this.fortuneCookie3.Click += new System.EventHandler(this.fortuneCookie3_Click);
            // 
            // fortuneCookieBox
            // 
            this.fortuneCookieBox.Controls.Add(this.fortuneCookie1);
            this.fortuneCookieBox.Controls.Add(this.fortuneCookie2);
            this.fortuneCookieBox.Controls.Add(this.fortuneCookie3);
            this.fortuneCookieBox.Location = new System.Drawing.Point(37, 265);
            this.fortuneCookieBox.Name = "fortuneCookieBox";
            this.fortuneCookieBox.Size = new System.Drawing.Size(537, 159);
            this.fortuneCookieBox.TabIndex = 6;
            this.fortuneCookieBox.TabStop = false;
            // 
            // fortuneCookieLabel
            // 
            this.fortuneCookieLabel.AutoSize = true;
            this.fortuneCookieLabel.Font = new System.Drawing.Font("Maiandra GD", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fortuneCookieLabel.ForeColor = System.Drawing.Color.Gold;
            this.fortuneCookieLabel.Location = new System.Drawing.Point(139, 192);
            this.fortuneCookieLabel.Name = "fortuneCookieLabel";
            this.fortuneCookieLabel.Size = new System.Drawing.Size(333, 36);
            this.fortuneCookieLabel.TabIndex = 7;
            this.fortuneCookieLabel.Text = "Pick a Fortune Cookie...";
            // 
            // generateNumberButton
            // 
            this.generateNumberButton.BackColor = System.Drawing.Color.Gold;
            this.generateNumberButton.Font = new System.Drawing.Font("Maiandra GD", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.generateNumberButton.ForeColor = System.Drawing.Color.Red;
            this.generateNumberButton.Location = new System.Drawing.Point(244, 448);
            this.generateNumberButton.Name = "generateNumberButton";
            this.generateNumberButton.Size = new System.Drawing.Size(125, 37);
            this.generateNumberButton.TabIndex = 6;
            this.generateNumberButton.Text = "Discover";
            this.generateNumberButton.UseVisualStyleBackColor = false;
            this.generateNumberButton.Click += new System.EventHandler(this.generateNumberButton_Click);
            // 
            // birthYearTextbox
            // 
            this.birthYearTextbox.BackColor = System.Drawing.Color.Gold;
            this.birthYearTextbox.Font = new System.Drawing.Font("Maiandra GD", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.birthYearTextbox.ForeColor = System.Drawing.Color.Red;
            this.birthYearTextbox.Location = new System.Drawing.Point(6, 21);
            this.birthYearTextbox.Name = "birthYearTextbox";
            this.birthYearTextbox.Size = new System.Drawing.Size(132, 28);
            this.birthYearTextbox.TabIndex = 8;
            this.birthYearTextbox.TextChanged += new System.EventHandler(this.birthYear_TextChanged);
            // 
            // horoscopeLabel
            // 
            this.horoscopeLabel.BackColor = System.Drawing.Color.Gold;
            this.horoscopeLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.horoscopeLabel.Font = new System.Drawing.Font("Maiandra GD", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.horoscopeLabel.ForeColor = System.Drawing.Color.Red;
            this.horoscopeLabel.Location = new System.Drawing.Point(144, 20);
            this.horoscopeLabel.Name = "horoscopeLabel";
            this.horoscopeLabel.Size = new System.Drawing.Size(132, 28);
            this.horoscopeLabel.TabIndex = 9;
            this.horoscopeLabel.Text = "horoscope";
            this.horoscopeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // horoscopeBox
            // 
            this.horoscopeBox.Controls.Add(this.birthYearTextbox);
            this.horoscopeBox.Controls.Add(this.horoscopeLabel);
            this.horoscopeBox.Location = new System.Drawing.Point(318, 103);
            this.horoscopeBox.Name = "horoscopeBox";
            this.horoscopeBox.Size = new System.Drawing.Size(283, 67);
            this.horoscopeBox.TabIndex = 10;
            this.horoscopeBox.TabStop = false;
            // 
            // bloodTypeLabel
            // 
            this.bloodTypeLabel.BackColor = System.Drawing.Color.Transparent;
            this.bloodTypeLabel.Font = new System.Drawing.Font("Maiandra GD", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bloodTypeLabel.ForeColor = System.Drawing.Color.Gold;
            this.bloodTypeLabel.Location = new System.Drawing.Point(33, 75);
            this.bloodTypeLabel.Name = "bloodTypeLabel";
            this.bloodTypeLabel.Size = new System.Drawing.Size(279, 28);
            this.bloodTypeLabel.TabIndex = 11;
            this.bloodTypeLabel.Text = "What\'s your blood type?";
            this.bloodTypeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // birthYearLabel
            // 
            this.birthYearLabel.BackColor = System.Drawing.Color.Transparent;
            this.birthYearLabel.Font = new System.Drawing.Font("Maiandra GD", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.birthYearLabel.ForeColor = System.Drawing.Color.Gold;
            this.birthYearLabel.Location = new System.Drawing.Point(322, 75);
            this.birthYearLabel.Name = "birthYearLabel";
            this.birthYearLabel.Size = new System.Drawing.Size(279, 28);
            this.birthYearLabel.TabIndex = 12;
            this.birthYearLabel.Text = "What\'s your birth year?";
            this.birthYearLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.personalityLabel);
            this.groupBox1.Controls.Add(this.bloodTypeSelect);
            this.groupBox1.Location = new System.Drawing.Point(29, 106);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(283, 67);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            // 
            // personalityLabel
            // 
            this.personalityLabel.BackColor = System.Drawing.Color.Gold;
            this.personalityLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.personalityLabel.Font = new System.Drawing.Font("Maiandra GD", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.personalityLabel.ForeColor = System.Drawing.Color.Red;
            this.personalityLabel.Location = new System.Drawing.Point(109, 22);
            this.personalityLabel.Name = "personalityLabel";
            this.personalityLabel.Size = new System.Drawing.Size(168, 28);
            this.personalityLabel.TabIndex = 10;
            this.personalityLabel.Text = "personality";
            this.personalityLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // luckyNumberForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkRed;
            this.ClientSize = new System.Drawing.Size(621, 534);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.birthYearLabel);
            this.Controls.Add(this.bloodTypeLabel);
            this.Controls.Add(this.horoscopeBox);
            this.Controls.Add(this.generateNumberButton);
            this.Controls.Add(this.fortuneCookieLabel);
            this.Controls.Add(this.fortuneCookieBox);
            this.Controls.Add(this.titleLabel);
            this.Name = "luckyNumberForm";
            this.Text = "Lucky Number";
            this.Load += new System.EventHandler(this.luckyNumberForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.fortuneCookie1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fortuneCookie2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fortuneCookie3)).EndInit();
            this.fortuneCookieBox.ResumeLayout(false);
            this.horoscopeBox.ResumeLayout(false);
            this.horoscopeBox.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.ComboBox bloodTypeSelect;
        private System.Windows.Forms.PictureBox fortuneCookie1;
        private System.Windows.Forms.PictureBox fortuneCookie2;
        private System.Windows.Forms.PictureBox fortuneCookie3;
        private System.Windows.Forms.GroupBox fortuneCookieBox;
        private System.Windows.Forms.Label fortuneCookieLabel;
        private System.Windows.Forms.Button generateNumberButton;
        private System.Windows.Forms.TextBox birthYearTextbox;
        private System.Windows.Forms.Label horoscopeLabel;
        private System.Windows.Forms.GroupBox horoscopeBox;
        private System.Windows.Forms.Label bloodTypeLabel;
        private System.Windows.Forms.Label birthYearLabel;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label personalityLabel;
    }
}

