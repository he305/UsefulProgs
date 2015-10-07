namespace GuitarTabGUI
{
    partial class MainWindow
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
            this.searchInput = new System.Windows.Forms.TextBox();
            this.searchButton = new System.Windows.Forms.Button();
            this.songBox = new System.Windows.Forms.ListBox();
            this.serverLabel = new System.Windows.Forms.Label();
            this.ultimate_guitarLabel = new System.Windows.Forms.Label();
            this.ultimate_guitarCheck = new System.Windows.Forms.CheckBox();
            this.showTabButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // searchInput
            // 
            this.searchInput.Location = new System.Drawing.Point(13, 13);
            this.searchInput.Name = "searchInput";
            this.searchInput.Size = new System.Drawing.Size(135, 20);
            this.searchInput.TabIndex = 0;
            this.searchInput.Text = "Введите название песни";
            // 
            // searchButton
            // 
            this.searchButton.Location = new System.Drawing.Point(197, 13);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(75, 20);
            this.searchButton.TabIndex = 1;
            this.searchButton.Text = "Поиск";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // songBox
            // 
            this.songBox.FormattingEnabled = true;
            this.songBox.HorizontalScrollbar = true;
            this.songBox.Location = new System.Drawing.Point(13, 39);
            this.songBox.Name = "songBox";
            this.songBox.Size = new System.Drawing.Size(259, 147);
            this.songBox.TabIndex = 2;
            // 
            // serverLabel
            // 
            this.serverLabel.AutoSize = true;
            this.serverLabel.Location = new System.Drawing.Point(287, 16);
            this.serverLabel.Name = "serverLabel";
            this.serverLabel.Size = new System.Drawing.Size(124, 13);
            this.serverLabel.TabIndex = 3;
            this.serverLabel.Text = "Доступность серверов";
            // 
            // ultimate_guitarLabel
            // 
            this.ultimate_guitarLabel.AutoSize = true;
            this.ultimate_guitarLabel.Location = new System.Drawing.Point(290, 39);
            this.ultimate_guitarLabel.Name = "ultimate_guitarLabel";
            this.ultimate_guitarLabel.Size = new System.Drawing.Size(72, 13);
            this.ultimate_guitarLabel.TabIndex = 4;
            this.ultimate_guitarLabel.Text = "ultimate-guitar";
            // 
            // ultimate_guitarCheck
            // 
            this.ultimate_guitarCheck.AutoSize = true;
            this.ultimate_guitarCheck.Enabled = false;
            this.ultimate_guitarCheck.Location = new System.Drawing.Point(396, 38);
            this.ultimate_guitarCheck.Name = "ultimate_guitarCheck";
            this.ultimate_guitarCheck.Size = new System.Drawing.Size(15, 14);
            this.ultimate_guitarCheck.TabIndex = 5;
            this.ultimate_guitarCheck.UseVisualStyleBackColor = true;
            // 
            // showTabButton
            // 
            this.showTabButton.Location = new System.Drawing.Point(13, 192);
            this.showTabButton.Name = "showTabButton";
            this.showTabButton.Size = new System.Drawing.Size(103, 23);
            this.showTabButton.TabIndex = 6;
            this.showTabButton.Text = "Показать табы";
            this.showTabButton.UseVisualStyleBackColor = true;
            this.showTabButton.Click += new System.EventHandler(this.showTabButton_Click);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(460, 221);
            this.Controls.Add(this.showTabButton);
            this.Controls.Add(this.ultimate_guitarCheck);
            this.Controls.Add(this.ultimate_guitarLabel);
            this.Controls.Add(this.serverLabel);
            this.Controls.Add(this.songBox);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.searchInput);
            this.Name = "MainWindow";
            this.Text = "Guitar TAB";
            this.Load += new System.EventHandler(this.MainWindow_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox searchInput;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.ListBox songBox;
        private System.Windows.Forms.Label serverLabel;
        private System.Windows.Forms.Label ultimate_guitarLabel;
        private System.Windows.Forms.CheckBox ultimate_guitarCheck;
        private System.Windows.Forms.Button showTabButton;
    }
}

