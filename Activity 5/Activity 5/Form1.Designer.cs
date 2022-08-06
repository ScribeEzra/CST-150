namespace Activity_5
{
    partial class fileInputTestForm
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
            this.openInputFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.openFileButton = new System.Windows.Forms.Button();
            this.wordListLabel = new System.Windows.Forms.Label();
            this.firstAlphabetizedLabel = new System.Windows.Forms.Label();
            this.lastAlphabetizedLabel = new System.Windows.Forms.Label();
            this.longestWordLabel = new System.Windows.Forms.Label();
            this.mostVowelsLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // openInputFileDialog
            // 
            this.openInputFileDialog.FileName = "openInputFile";
            // 
            // openFileButton
            // 
            this.openFileButton.Location = new System.Drawing.Point(165, 12);
            this.openFileButton.Name = "openFileButton";
            this.openFileButton.Size = new System.Drawing.Size(151, 30);
            this.openFileButton.TabIndex = 0;
            this.openFileButton.Text = "Open File";
            this.openFileButton.UseVisualStyleBackColor = true;
            this.openFileButton.Click += new System.EventHandler(this.openFileButton_Click);
            // 
            // wordListLabel
            // 
            this.wordListLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.wordListLabel.Location = new System.Drawing.Point(12, 65);
            this.wordListLabel.Name = "wordListLabel";
            this.wordListLabel.Size = new System.Drawing.Size(100, 300);
            this.wordListLabel.TabIndex = 1;
            this.wordListLabel.Text = "label1";
            // 
            // firstAlphabetizedLabel
            // 
            this.firstAlphabetizedLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.firstAlphabetizedLabel.Location = new System.Drawing.Point(161, 65);
            this.firstAlphabetizedLabel.Name = "firstAlphabetizedLabel";
            this.firstAlphabetizedLabel.Size = new System.Drawing.Size(300, 75);
            this.firstAlphabetizedLabel.TabIndex = 2;
            this.firstAlphabetizedLabel.Text = "label2";
            // 
            // lastAlphabetizedLabel
            // 
            this.lastAlphabetizedLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lastAlphabetizedLabel.Location = new System.Drawing.Point(161, 140);
            this.lastAlphabetizedLabel.Name = "lastAlphabetizedLabel";
            this.lastAlphabetizedLabel.Size = new System.Drawing.Size(300, 75);
            this.lastAlphabetizedLabel.TabIndex = 3;
            this.lastAlphabetizedLabel.Text = "label3";
            // 
            // longestWordLabel
            // 
            this.longestWordLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.longestWordLabel.Location = new System.Drawing.Point(161, 215);
            this.longestWordLabel.Name = "longestWordLabel";
            this.longestWordLabel.Size = new System.Drawing.Size(300, 75);
            this.longestWordLabel.TabIndex = 4;
            this.longestWordLabel.Text = "label4";
            // 
            // mostVowelsLabel
            // 
            this.mostVowelsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mostVowelsLabel.Location = new System.Drawing.Point(161, 290);
            this.mostVowelsLabel.Name = "mostVowelsLabel";
            this.mostVowelsLabel.Size = new System.Drawing.Size(300, 75);
            this.mostVowelsLabel.TabIndex = 5;
            this.mostVowelsLabel.Text = "label5";
            // 
            // fileInputTestForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 417);
            this.Controls.Add(this.mostVowelsLabel);
            this.Controls.Add(this.longestWordLabel);
            this.Controls.Add(this.lastAlphabetizedLabel);
            this.Controls.Add(this.firstAlphabetizedLabel);
            this.Controls.Add(this.wordListLabel);
            this.Controls.Add(this.openFileButton);
            this.Name = "fileInputTestForm";
            this.Text = "File Input Test";
            this.Load += new System.EventHandler(this.fileInputTestForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog openInputFileDialog;
        private System.Windows.Forms.Button openFileButton;
        private System.Windows.Forms.Label wordListLabel;
        private System.Windows.Forms.Label firstAlphabetizedLabel;
        private System.Windows.Forms.Label lastAlphabetizedLabel;
        private System.Windows.Forms.Label longestWordLabel;
        private System.Windows.Forms.Label mostVowelsLabel;
    }
}

