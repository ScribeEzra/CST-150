namespace Milestone_3
{
    partial class gameLibraryForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(gameLibraryForm));
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.gameSearch = new System.Windows.Forms.TextBox();
            this.gameListBox = new System.Windows.Forms.ListBox();
            this.gameInfo = new System.Windows.Forms.Label();
            this.searchCriteriaBox = new System.Windows.Forms.GroupBox();
            this.searchingPublisher = new System.Windows.Forms.RadioButton();
            this.searchingConsole = new System.Windows.Forms.RadioButton();
            this.searchingGenre = new System.Windows.Forms.RadioButton();
            this.searchingTitle = new System.Windows.Forms.RadioButton();
            this.gameSearchButton = new System.Windows.Forms.Button();
            this.addGameButton = new System.Windows.Forms.Button();
            this.removeGameButton = new System.Windows.Forms.Button();
            this.restockButton = new System.Windows.Forms.Button();
            this.gameDisplayBox = new System.Windows.Forms.GroupBox();
            this.gameImage = new System.Windows.Forms.PictureBox();
            this.searchCriteriaBox.SuspendLayout();
            this.gameDisplayBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gameImage)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(115, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 40);
            this.label1.TabIndex = 0;
            this.label1.Text = "Search";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label3.Location = new System.Drawing.Point(87, 213);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(164, 40);
            this.label3.TabIndex = 2;
            this.label3.Text = "Game List";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // gameSearch
            // 
            this.gameSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gameSearch.Location = new System.Drawing.Point(24, 61);
            this.gameSearch.Name = "gameSearch";
            this.gameSearch.Size = new System.Drawing.Size(208, 27);
            this.gameSearch.TabIndex = 1;
            // 
            // gameListBox
            // 
            this.gameListBox.BackColor = System.Drawing.Color.LightGreen;
            this.gameListBox.FormattingEnabled = true;
            this.gameListBox.ItemHeight = 16;
            this.gameListBox.Location = new System.Drawing.Point(24, 190);
            this.gameListBox.Name = "gameListBox";
            this.gameListBox.ScrollAlwaysVisible = true;
            this.gameListBox.Size = new System.Drawing.Size(329, 228);
            this.gameListBox.TabIndex = 7;
            this.gameListBox.SelectedIndexChanged += new System.EventHandler(this.gameListBox_SelectedIndexChanged);
            // 
            // gameInfo
            // 
            this.gameInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.gameInfo.ForeColor = System.Drawing.Color.Honeydew;
            this.gameInfo.Location = new System.Drawing.Point(16, 241);
            this.gameInfo.Name = "gameInfo";
            this.gameInfo.Size = new System.Drawing.Size(332, 184);
            this.gameInfo.TabIndex = 19;
            // 
            // searchCriteriaBox
            // 
            this.searchCriteriaBox.Controls.Add(this.searchingPublisher);
            this.searchCriteriaBox.Controls.Add(this.searchingConsole);
            this.searchCriteriaBox.Controls.Add(this.searchingGenre);
            this.searchCriteriaBox.Controls.Add(this.searchingTitle);
            this.searchCriteriaBox.Location = new System.Drawing.Point(24, 110);
            this.searchCriteriaBox.Name = "searchCriteriaBox";
            this.searchCriteriaBox.Size = new System.Drawing.Size(317, 63);
            this.searchCriteriaBox.TabIndex = 13;
            this.searchCriteriaBox.TabStop = false;
            this.searchCriteriaBox.Text = "Criteria";
            // 
            // searchingPublisher
            // 
            this.searchingPublisher.AutoSize = true;
            this.searchingPublisher.Location = new System.Drawing.Point(225, 25);
            this.searchingPublisher.Name = "searchingPublisher";
            this.searchingPublisher.Size = new System.Drawing.Size(84, 20);
            this.searchingPublisher.TabIndex = 6;
            this.searchingPublisher.Text = "Publisher";
            this.searchingPublisher.UseVisualStyleBackColor = true;
            // 
            // searchingConsole
            // 
            this.searchingConsole.AutoSize = true;
            this.searchingConsole.Location = new System.Drawing.Point(141, 25);
            this.searchingConsole.Name = "searchingConsole";
            this.searchingConsole.Size = new System.Drawing.Size(78, 20);
            this.searchingConsole.TabIndex = 5;
            this.searchingConsole.Text = "Console";
            this.searchingConsole.UseVisualStyleBackColor = true;
            // 
            // searchingGenre
            // 
            this.searchingGenre.AutoSize = true;
            this.searchingGenre.Location = new System.Drawing.Point(70, 25);
            this.searchingGenre.Name = "searchingGenre";
            this.searchingGenre.Size = new System.Drawing.Size(65, 20);
            this.searchingGenre.TabIndex = 4;
            this.searchingGenre.Text = "Genre";
            this.searchingGenre.UseVisualStyleBackColor = true;
            // 
            // searchingTitle
            // 
            this.searchingTitle.AutoSize = true;
            this.searchingTitle.Checked = true;
            this.searchingTitle.Location = new System.Drawing.Point(6, 25);
            this.searchingTitle.Name = "searchingTitle";
            this.searchingTitle.Size = new System.Drawing.Size(54, 20);
            this.searchingTitle.TabIndex = 3;
            this.searchingTitle.TabStop = true;
            this.searchingTitle.Text = "Title";
            this.searchingTitle.UseVisualStyleBackColor = true;
            // 
            // gameSearchButton
            // 
            this.gameSearchButton.BackColor = System.Drawing.Color.DarkGreen;
            this.gameSearchButton.Font = new System.Drawing.Font("Microsoft YaHei", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gameSearchButton.ForeColor = System.Drawing.Color.Honeydew;
            this.gameSearchButton.Location = new System.Drawing.Point(238, 57);
            this.gameSearchButton.Name = "gameSearchButton";
            this.gameSearchButton.Size = new System.Drawing.Size(103, 36);
            this.gameSearchButton.TabIndex = 2;
            this.gameSearchButton.Text = "Search";
            this.gameSearchButton.UseVisualStyleBackColor = false;
            this.gameSearchButton.Click += new System.EventHandler(this.gameSearchButton_Click);
            // 
            // addGameButton
            // 
            this.addGameButton.BackColor = System.Drawing.Color.DarkGreen;
            this.addGameButton.Font = new System.Drawing.Font("Microsoft YaHei", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addGameButton.ForeColor = System.Drawing.Color.Honeydew;
            this.addGameButton.Location = new System.Drawing.Point(24, 466);
            this.addGameButton.Name = "addGameButton";
            this.addGameButton.Size = new System.Drawing.Size(329, 36);
            this.addGameButton.TabIndex = 10;
            this.addGameButton.Text = "Add a Game";
            this.addGameButton.UseVisualStyleBackColor = false;
            this.addGameButton.Click += new System.EventHandler(this.addGameButton_Click);
            // 
            // removeGameButton
            // 
            this.removeGameButton.BackColor = System.Drawing.Color.DarkGreen;
            this.removeGameButton.Font = new System.Drawing.Font("Microsoft YaHei", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.removeGameButton.ForeColor = System.Drawing.Color.Honeydew;
            this.removeGameButton.Location = new System.Drawing.Point(24, 424);
            this.removeGameButton.Name = "removeGameButton";
            this.removeGameButton.Size = new System.Drawing.Size(129, 36);
            this.removeGameButton.TabIndex = 8;
            this.removeGameButton.Text = "Remove";
            this.removeGameButton.UseVisualStyleBackColor = false;
            this.removeGameButton.Click += new System.EventHandler(this.removeGameButton_Click);
            // 
            // restockButton
            // 
            this.restockButton.BackColor = System.Drawing.Color.DarkGreen;
            this.restockButton.Font = new System.Drawing.Font("Microsoft YaHei", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.restockButton.ForeColor = System.Drawing.Color.Honeydew;
            this.restockButton.Location = new System.Drawing.Point(224, 424);
            this.restockButton.Name = "restockButton";
            this.restockButton.Size = new System.Drawing.Size(129, 36);
            this.restockButton.TabIndex = 9;
            this.restockButton.Text = "Restock";
            this.restockButton.UseVisualStyleBackColor = false;
            this.restockButton.Click += new System.EventHandler(this.restockButton_Click);
            // 
            // gameDisplayBox
            // 
            this.gameDisplayBox.Controls.Add(this.gameImage);
            this.gameDisplayBox.Controls.Add(this.gameInfo);
            this.gameDisplayBox.Location = new System.Drawing.Point(374, 61);
            this.gameDisplayBox.Name = "gameDisplayBox";
            this.gameDisplayBox.Size = new System.Drawing.Size(361, 441);
            this.gameDisplayBox.TabIndex = 20;
            this.gameDisplayBox.TabStop = false;
            // 
            // gameImage
            // 
            this.gameImage.BackgroundImage = global::Milestone_3.Properties.Resources.Game_Thumbnail;
            this.gameImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.gameImage.Location = new System.Drawing.Point(47, 21);
            this.gameImage.Name = "gameImage";
            this.gameImage.Size = new System.Drawing.Size(270, 217);
            this.gameImage.TabIndex = 20;
            this.gameImage.TabStop = false;
            // 
            // gameLibraryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Honeydew;
            this.ClientSize = new System.Drawing.Size(752, 513);
            this.Controls.Add(this.gameDisplayBox);
            this.Controls.Add(this.restockButton);
            this.Controls.Add(this.removeGameButton);
            this.Controls.Add(this.addGameButton);
            this.Controls.Add(this.gameSearchButton);
            this.Controls.Add(this.searchCriteriaBox);
            this.Controls.Add(this.gameListBox);
            this.Controls.Add(this.gameSearch);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "gameLibraryForm";
            this.Text = "Game Library";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.searchCriteriaBox.ResumeLayout(false);
            this.searchCriteriaBox.PerformLayout();
            this.gameDisplayBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gameImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox gameSearch;
        private System.Windows.Forms.ListBox gameListBox;
        private System.Windows.Forms.Label gameInfo;
        private System.Windows.Forms.GroupBox searchCriteriaBox;
        private System.Windows.Forms.Button gameSearchButton;
        private System.Windows.Forms.Button addGameButton;
        private System.Windows.Forms.Button removeGameButton;
        private System.Windows.Forms.RadioButton searchingPublisher;
        private System.Windows.Forms.RadioButton searchingConsole;
        private System.Windows.Forms.RadioButton searchingGenre;
        private System.Windows.Forms.RadioButton searchingTitle;
        private System.Windows.Forms.Button restockButton;
        private System.Windows.Forms.GroupBox gameDisplayBox;
        private System.Windows.Forms.PictureBox gameImage;
    }
}

