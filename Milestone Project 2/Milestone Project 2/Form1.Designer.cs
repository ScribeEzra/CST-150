namespace Milestone_Project_2
{
    partial class libraryOfGames
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
            this.gameListLabel = new System.Windows.Forms.Label();
            this.addAGameLabel = new System.Windows.Forms.Label();
            this.inputTitle = new System.Windows.Forms.TextBox();
            this.titleLabel = new System.Windows.Forms.Label();
            this.consoleLabel = new System.Windows.Forms.Label();
            this.inputConsole = new System.Windows.Forms.TextBox();
            this.priceLabel = new System.Windows.Forms.Label();
            this.inputPrice = new System.Windows.Forms.TextBox();
            this.addGameButton = new System.Windows.Forms.Button();
            this.publisherLabel = new System.Windows.Forms.Label();
            this.inputPublisher = new System.Windows.Forms.TextBox();
            this.gameList = new System.Windows.Forms.ListBox();
            this.gameInfo = new System.Windows.Forms.Label();
            this.removeGameButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // gameListLabel
            // 
            this.gameListLabel.AutoSize = true;
            this.gameListLabel.Font = new System.Drawing.Font("Microsoft YaHei UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gameListLabel.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.gameListLabel.Location = new System.Drawing.Point(137, 25);
            this.gameListLabel.Name = "gameListLabel";
            this.gameListLabel.Size = new System.Drawing.Size(140, 31);
            this.gameListLabel.TabIndex = 8;
            this.gameListLabel.Text = "Games List";
            // 
            // addAGameLabel
            // 
            this.addAGameLabel.AutoSize = true;
            this.addAGameLabel.Font = new System.Drawing.Font("Microsoft YaHei UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addAGameLabel.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.addAGameLabel.Location = new System.Drawing.Point(521, 25);
            this.addAGameLabel.Name = "addAGameLabel";
            this.addAGameLabel.Size = new System.Drawing.Size(166, 31);
            this.addAGameLabel.TabIndex = 9;
            this.addAGameLabel.Text = "Add a Game?";
            // 
            // inputTitle
            // 
            this.inputTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inputTitle.Location = new System.Drawing.Point(596, 69);
            this.inputTitle.Name = "inputTitle";
            this.inputTitle.Size = new System.Drawing.Size(143, 27);
            this.inputTitle.TabIndex = 0;
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.Location = new System.Drawing.Point(482, 69);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(50, 23);
            this.titleLabel.TabIndex = 10;
            this.titleLabel.Text = "Title:";
            // 
            // consoleLabel
            // 
            this.consoleLabel.AutoSize = true;
            this.consoleLabel.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.consoleLabel.Location = new System.Drawing.Point(461, 135);
            this.consoleLabel.Name = "consoleLabel";
            this.consoleLabel.Size = new System.Drawing.Size(80, 23);
            this.consoleLabel.TabIndex = 11;
            this.consoleLabel.Text = "Console:";
            // 
            // inputConsole
            // 
            this.inputConsole.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inputConsole.Location = new System.Drawing.Point(596, 135);
            this.inputConsole.Name = "inputConsole";
            this.inputConsole.Size = new System.Drawing.Size(143, 27);
            this.inputConsole.TabIndex = 1;
            // 
            // priceLabel
            // 
            this.priceLabel.AutoSize = true;
            this.priceLabel.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.priceLabel.Location = new System.Drawing.Point(478, 270);
            this.priceLabel.Name = "priceLabel";
            this.priceLabel.Size = new System.Drawing.Size(54, 23);
            this.priceLabel.TabIndex = 13;
            this.priceLabel.Text = "Price:";
            // 
            // inputPrice
            // 
            this.inputPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inputPrice.Location = new System.Drawing.Point(596, 266);
            this.inputPrice.Name = "inputPrice";
            this.inputPrice.Size = new System.Drawing.Size(143, 27);
            this.inputPrice.TabIndex = 3;
            // 
            // addGameButton
            // 
            this.addGameButton.BackColor = System.Drawing.Color.LightGreen;
            this.addGameButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addGameButton.Location = new System.Drawing.Point(527, 332);
            this.addGameButton.Name = "addGameButton";
            this.addGameButton.Size = new System.Drawing.Size(160, 35);
            this.addGameButton.TabIndex = 4;
            this.addGameButton.Text = "Add";
            this.addGameButton.UseVisualStyleBackColor = false;
            this.addGameButton.Click += new System.EventHandler(this.addGameButton_Click);
            // 
            // publisherLabel
            // 
            this.publisherLabel.AutoSize = true;
            this.publisherLabel.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.publisherLabel.Location = new System.Drawing.Point(461, 204);
            this.publisherLabel.Name = "publisherLabel";
            this.publisherLabel.Size = new System.Drawing.Size(89, 23);
            this.publisherLabel.TabIndex = 12;
            this.publisherLabel.Text = "Publisher:";
            // 
            // inputPublisher
            // 
            this.inputPublisher.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inputPublisher.Location = new System.Drawing.Point(596, 200);
            this.inputPublisher.Name = "inputPublisher";
            this.inputPublisher.Size = new System.Drawing.Size(143, 27);
            this.inputPublisher.TabIndex = 2;
            // 
            // gameList
            // 
            this.gameList.BackColor = System.Drawing.Color.LightGreen;
            this.gameList.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gameList.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.gameList.FormattingEnabled = true;
            this.gameList.ItemHeight = 23;
            this.gameList.Location = new System.Drawing.Point(12, 69);
            this.gameList.Name = "gameList";
            this.gameList.Size = new System.Drawing.Size(391, 165);
            this.gameList.TabIndex = 6;
            this.gameList.SelectedIndexChanged += new System.EventHandler(this.gameList_SelectedIndexChanged);
            // 
            // gameInfo
            // 
            this.gameInfo.BackColor = System.Drawing.Color.DarkSlateGray;
            this.gameInfo.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gameInfo.ForeColor = System.Drawing.Color.Honeydew;
            this.gameInfo.Location = new System.Drawing.Point(12, 272);
            this.gameInfo.Name = "gameInfo";
            this.gameInfo.Size = new System.Drawing.Size(391, 160);
            this.gameInfo.TabIndex = 7;
            this.gameInfo.Text = "\r\n";
            // 
            // removeGameButton
            // 
            this.removeGameButton.BackColor = System.Drawing.Color.LightGreen;
            this.removeGameButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.removeGameButton.Location = new System.Drawing.Point(527, 373);
            this.removeGameButton.Name = "removeGameButton";
            this.removeGameButton.Size = new System.Drawing.Size(160, 35);
            this.removeGameButton.TabIndex = 5;
            this.removeGameButton.Text = "Remove";
            this.removeGameButton.UseVisualStyleBackColor = false;
            this.removeGameButton.Click += new System.EventHandler(this.removeGameButton_Click);
            // 
            // libraryOfGames
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Honeydew;
            this.ClientSize = new System.Drawing.Size(800, 488);
            this.Controls.Add(this.removeGameButton);
            this.Controls.Add(this.gameInfo);
            this.Controls.Add(this.gameList);
            this.Controls.Add(this.inputPublisher);
            this.Controls.Add(this.publisherLabel);
            this.Controls.Add(this.addGameButton);
            this.Controls.Add(this.inputPrice);
            this.Controls.Add(this.priceLabel);
            this.Controls.Add(this.inputConsole);
            this.Controls.Add(this.consoleLabel);
            this.Controls.Add(this.titleLabel);
            this.Controls.Add(this.inputTitle);
            this.Controls.Add(this.addAGameLabel);
            this.Controls.Add(this.gameListLabel);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "libraryOfGames";
            this.Text = "Library of Games";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label gameListLabel;
        private System.Windows.Forms.Label addAGameLabel;
        private System.Windows.Forms.TextBox inputTitle;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Label consoleLabel;
        private System.Windows.Forms.TextBox inputConsole;
        private System.Windows.Forms.Label priceLabel;
        private System.Windows.Forms.TextBox inputPrice;
        private System.Windows.Forms.Button addGameButton;
        private System.Windows.Forms.Label publisherLabel;
        private System.Windows.Forms.TextBox inputPublisher;
        private System.Windows.Forms.ListBox gameList;
        private System.Windows.Forms.Label gameInfo;
        private System.Windows.Forms.Button removeGameButton;
    }
}

