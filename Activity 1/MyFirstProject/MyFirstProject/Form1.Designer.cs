namespace MyFirstProject
{
    partial class startupMenu
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
            this.ezraBio = new System.Windows.Forms.Button();
            this.aoiBio = new System.Windows.Forms.Button();
            this.kiraBio = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.anneBio = new System.Windows.Forms.Button();
            this.elvarBio = new System.Windows.Forms.Button();
            this.danielBio = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ezraBio
            // 
            this.ezraBio.Location = new System.Drawing.Point(87, 86);
            this.ezraBio.Name = "ezraBio";
            this.ezraBio.Size = new System.Drawing.Size(121, 23);
            this.ezraBio.TabIndex = 0;
            this.ezraBio.Text = "Ezra";
            this.ezraBio.UseVisualStyleBackColor = true;
            this.ezraBio.Click += new System.EventHandler(this.button1_Click);
            // 
            // aoiBio
            // 
            this.aoiBio.Location = new System.Drawing.Point(87, 115);
            this.aoiBio.Name = "aoiBio";
            this.aoiBio.Size = new System.Drawing.Size(121, 27);
            this.aoiBio.TabIndex = 1;
            this.aoiBio.Text = "Aoi";
            this.aoiBio.UseVisualStyleBackColor = true;
            this.aoiBio.Click += new System.EventHandler(this.button2_Click);
            // 
            // kiraBio
            // 
            this.kiraBio.Location = new System.Drawing.Point(87, 148);
            this.kiraBio.Name = "kiraBio";
            this.kiraBio.Size = new System.Drawing.Size(121, 28);
            this.kiraBio.TabIndex = 2;
            this.kiraBio.Text = "Kira";
            this.kiraBio.UseVisualStyleBackColor = true;
            this.kiraBio.Click += new System.EventHandler(this.kiraBio_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Blackadder ITC", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.label1.Location = new System.Drawing.Point(80, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(312, 41);
            this.label1.TabIndex = 3;
            this.label1.Text = "Soul of Azrael Characters";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // anneBio
            // 
            this.anneBio.Location = new System.Drawing.Point(255, 86);
            this.anneBio.Name = "anneBio";
            this.anneBio.Size = new System.Drawing.Size(121, 23);
            this.anneBio.TabIndex = 4;
            this.anneBio.Text = "Anne";
            this.anneBio.UseVisualStyleBackColor = true;
            this.anneBio.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // elvarBio
            // 
            this.elvarBio.Location = new System.Drawing.Point(255, 119);
            this.elvarBio.Name = "elvarBio";
            this.elvarBio.Size = new System.Drawing.Size(121, 23);
            this.elvarBio.TabIndex = 5;
            this.elvarBio.Text = "Elvar";
            this.elvarBio.UseVisualStyleBackColor = true;
            this.elvarBio.Click += new System.EventHandler(this.elvarBio_Click);
            // 
            // danielBio
            // 
            this.danielBio.Location = new System.Drawing.Point(255, 153);
            this.danielBio.Name = "danielBio";
            this.danielBio.Size = new System.Drawing.Size(121, 23);
            this.danielBio.TabIndex = 6;
            this.danielBio.Text = "Daniel";
            this.danielBio.UseVisualStyleBackColor = true;
            this.danielBio.Click += new System.EventHandler(this.button1_Click_2);
            // 
            // startupMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImage = global::MyFirstProject.Properties.Resources.Magic_Storm;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(484, 211);
            this.Controls.Add(this.danielBio);
            this.Controls.Add(this.elvarBio);
            this.Controls.Add(this.anneBio);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.kiraBio);
            this.Controls.Add(this.aoiBio);
            this.Controls.Add(this.ezraBio);
            this.DoubleBuffered = true;
            this.Name = "startupMenu";
            this.Text = "My First Project";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ezraBio;
        private System.Windows.Forms.Button aoiBio;
        private System.Windows.Forms.Button kiraBio;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button anneBio;
        private System.Windows.Forms.Button elvarBio;
        private System.Windows.Forms.Button danielBio;
    }
}

