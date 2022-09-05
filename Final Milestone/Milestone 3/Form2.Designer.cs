namespace Milestone_3
{
    partial class addAGameForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(addAGameForm));
            this.label6 = new System.Windows.Forms.Label();
            this.addGameButton = new System.Windows.Forms.Button();
            this.inputInGamePurchases = new System.Windows.Forms.CheckBox();
            this.inputOnlineGameplay = new System.Windows.Forms.CheckBox();
            this.inputDescription = new System.Windows.Forms.TextBox();
            this.inputPlayers = new System.Windows.Forms.TextBox();
            this.inputGenre = new System.Windows.Forms.TextBox();
            this.inputPrice = new System.Windows.Forms.TextBox();
            this.inputPublisher = new System.Windows.Forms.TextBox();
            this.inputConsole = new System.Windows.Forms.TextBox();
            this.inputTitle = new System.Windows.Forms.TextBox();
            this.addGameLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.inputQuantity = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.uploadGameImage = new System.Windows.Forms.OpenFileDialog();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label6.Location = new System.Drawing.Point(6, 78);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(110, 30);
            this.label6.TabIndex = 45;
            this.label6.Text = "Publisher";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // addGameButton
            // 
            this.addGameButton.BackColor = System.Drawing.Color.DarkGreen;
            this.addGameButton.Font = new System.Drawing.Font("Microsoft YaHei", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addGameButton.ForeColor = System.Drawing.Color.Honeydew;
            this.addGameButton.Location = new System.Drawing.Point(246, 561);
            this.addGameButton.Name = "addGameButton";
            this.addGameButton.Size = new System.Drawing.Size(129, 36);
            this.addGameButton.TabIndex = 10;
            this.addGameButton.Text = "Add";
            this.addGameButton.UseVisualStyleBackColor = false;
            this.addGameButton.Click += new System.EventHandler(this.addGameButton_Click);
            // 
            // inputInGamePurchases
            // 
            this.inputInGamePurchases.AutoSize = true;
            this.inputInGamePurchases.Location = new System.Drawing.Point(12, 475);
            this.inputInGamePurchases.Name = "inputInGamePurchases";
            this.inputInGamePurchases.Size = new System.Drawing.Size(175, 20);
            this.inputInGamePurchases.TabIndex = 7;
            this.inputInGamePurchases.Text = "Has In-Game Purchases";
            this.inputInGamePurchases.UseVisualStyleBackColor = true;
            // 
            // inputOnlineGameplay
            // 
            this.inputOnlineGameplay.AutoSize = true;
            this.inputOnlineGameplay.Location = new System.Drawing.Point(225, 475);
            this.inputOnlineGameplay.Name = "inputOnlineGameplay";
            this.inputOnlineGameplay.Size = new System.Drawing.Size(161, 20);
            this.inputOnlineGameplay.TabIndex = 8;
            this.inputOnlineGameplay.Text = "Has Online Gameplay";
            this.inputOnlineGameplay.UseVisualStyleBackColor = true;
            // 
            // inputDescription
            // 
            this.inputDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inputDescription.Location = new System.Drawing.Point(42, 313);
            this.inputDescription.Multiline = true;
            this.inputDescription.Name = "inputDescription";
            this.inputDescription.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.inputDescription.Size = new System.Drawing.Size(311, 156);
            this.inputDescription.TabIndex = 6;
            // 
            // inputPlayers
            // 
            this.inputPlayers.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inputPlayers.Location = new System.Drawing.Point(152, 171);
            this.inputPlayers.Name = "inputPlayers";
            this.inputPlayers.Size = new System.Drawing.Size(175, 27);
            this.inputPlayers.TabIndex = 5;
            // 
            // inputGenre
            // 
            this.inputGenre.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inputGenre.Location = new System.Drawing.Point(152, 141);
            this.inputGenre.Name = "inputGenre";
            this.inputGenre.Size = new System.Drawing.Size(175, 27);
            this.inputGenre.TabIndex = 4;
            // 
            // inputPrice
            // 
            this.inputPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inputPrice.Location = new System.Drawing.Point(152, 112);
            this.inputPrice.Name = "inputPrice";
            this.inputPrice.Size = new System.Drawing.Size(175, 27);
            this.inputPrice.TabIndex = 3;
            // 
            // inputPublisher
            // 
            this.inputPublisher.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inputPublisher.Location = new System.Drawing.Point(152, 81);
            this.inputPublisher.Name = "inputPublisher";
            this.inputPublisher.Size = new System.Drawing.Size(175, 27);
            this.inputPublisher.TabIndex = 2;
            // 
            // inputConsole
            // 
            this.inputConsole.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inputConsole.Location = new System.Drawing.Point(152, 51);
            this.inputConsole.Name = "inputConsole";
            this.inputConsole.Size = new System.Drawing.Size(175, 27);
            this.inputConsole.TabIndex = 1;
            // 
            // inputTitle
            // 
            this.inputTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inputTitle.Location = new System.Drawing.Point(152, 21);
            this.inputTitle.Name = "inputTitle";
            this.inputTitle.Size = new System.Drawing.Size(175, 27);
            this.inputTitle.TabIndex = 0;
            // 
            // addGameLabel
            // 
            this.addGameLabel.AutoSize = true;
            this.addGameLabel.Font = new System.Drawing.Font("Microsoft YaHei", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addGameLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.addGameLabel.Location = new System.Drawing.Point(99, 9);
            this.addGameLabel.Name = "addGameLabel";
            this.addGameLabel.Size = new System.Drawing.Size(201, 40);
            this.addGameLabel.TabIndex = 33;
            this.addGameLabel.Text = "Add a Game";
            this.addGameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(6, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 30);
            this.label1.TabIndex = 49;
            this.label1.Text = "Console";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label3.Location = new System.Drawing.Point(6, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 30);
            this.label3.TabIndex = 50;
            this.label3.Text = "Title";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label4.Location = new System.Drawing.Point(6, 108);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(110, 30);
            this.label4.TabIndex = 51;
            this.label4.Text = "Price";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label5.Location = new System.Drawing.Point(6, 138);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(110, 30);
            this.label5.TabIndex = 52;
            this.label5.Text = "Genre";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label7.Location = new System.Drawing.Point(6, 168);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(110, 30);
            this.label7.TabIndex = 53;
            this.label7.Text = "Players";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.inputPlayers);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.inputGenre);
            this.groupBox1.Controls.Add(this.inputTitle);
            this.groupBox1.Controls.Add(this.inputPrice);
            this.groupBox1.Controls.Add(this.inputConsole);
            this.groupBox1.Controls.Add(this.inputPublisher);
            this.groupBox1.Location = new System.Drawing.Point(42, 61);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(333, 216);
            this.groupBox1.TabIndex = 54;
            this.groupBox1.TabStop = false;
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label8.Location = new System.Drawing.Point(130, 280);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(129, 30);
            this.label8.TabIndex = 55;
            this.label8.Text = "Description";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label9
            // 
            this.label9.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label9.Location = new System.Drawing.Point(8, 510);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(160, 30);
            this.label9.TabIndex = 56;
            this.label9.Text = "Initial Quantity";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // inputQuantity
            // 
            this.inputQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inputQuantity.Location = new System.Drawing.Point(174, 513);
            this.inputQuantity.Name = "inputQuantity";
            this.inputQuantity.Size = new System.Drawing.Size(93, 27);
            this.inputQuantity.TabIndex = 9;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DarkGreen;
            this.button1.Font = new System.Drawing.Font("Microsoft YaHei", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Honeydew;
            this.button1.Location = new System.Drawing.Point(42, 561);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(129, 36);
            this.button1.TabIndex = 57;
            this.button1.Text = "Upload Image";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // addAGameForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Honeydew;
            this.ClientSize = new System.Drawing.Size(423, 626);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.inputQuantity);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.addGameButton);
            this.Controls.Add(this.inputInGamePurchases);
            this.Controls.Add(this.inputOnlineGameplay);
            this.Controls.Add(this.inputDescription);
            this.Controls.Add(this.addGameLabel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "addAGameForm";
            this.Text = "Add a Game";
            this.Load += new System.EventHandler(this.addAGameForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button addGameButton;
        private System.Windows.Forms.CheckBox inputInGamePurchases;
        private System.Windows.Forms.CheckBox inputOnlineGameplay;
        private System.Windows.Forms.TextBox inputDescription;
        private System.Windows.Forms.TextBox inputPlayers;
        private System.Windows.Forms.TextBox inputGenre;
        private System.Windows.Forms.TextBox inputPrice;
        private System.Windows.Forms.TextBox inputPublisher;
        private System.Windows.Forms.TextBox inputConsole;
        private System.Windows.Forms.TextBox inputTitle;
        private System.Windows.Forms.Label addGameLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox inputQuantity;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.OpenFileDialog uploadGameImage;
    }
}