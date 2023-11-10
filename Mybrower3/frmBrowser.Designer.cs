namespace Mybrower3
{
    partial class frmBrowser
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBrowser));
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.Home_button = new System.Windows.Forms.Button();
            this.Back_button = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.Refresh_button = new System.Windows.Forms.Button();
            this.Search_button = new System.Windows.Forms.Button();
            this.split = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.Setting_button = new System.Windows.Forms.Button();
            this.PDF = new System.Windows.Forms.Button();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(135, 4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(317, 20);
            this.textBox1.TabIndex = 0;
            // 
            // Home_button
            // 
            this.Home_button.Location = new System.Drawing.Point(2, 0);
            this.Home_button.Name = "Home_button";
            this.Home_button.Size = new System.Drawing.Size(49, 23);
            this.Home_button.TabIndex = 1;
            this.Home_button.Text = "Home";
            this.Home_button.UseVisualStyleBackColor = true;
            this.Home_button.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // Back_button
            // 
            this.Back_button.Location = new System.Drawing.Point(48, 1);
            this.Back_button.Name = "Back_button";
            this.Back_button.Size = new System.Drawing.Size(28, 23);
            this.Back_button.TabIndex = 2;
            this.Back_button.Text = "<";
            this.Back_button.UseVisualStyleBackColor = true;
            this.Back_button.Click += new System.EventHandler(this.button1_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(72, 1);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(27, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = ">";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_2);
            // 
            // Refresh_button
            // 
            this.Refresh_button.Location = new System.Drawing.Point(103, 1);
            this.Refresh_button.Name = "Refresh_button";
            this.Refresh_button.Size = new System.Drawing.Size(27, 23);
            this.Refresh_button.TabIndex = 4;
            this.Refresh_button.Text = "⟳";
            this.Refresh_button.UseVisualStyleBackColor = true;
            this.Refresh_button.Click += new System.EventHandler(this.Refresh_button_Click);
            // 
            // Search_button
            // 
            this.Search_button.Location = new System.Drawing.Point(458, 2);
            this.Search_button.Name = "Search_button";
            this.Search_button.Size = new System.Drawing.Size(49, 23);
            this.Search_button.TabIndex = 5;
            this.Search_button.Text = "Search";
            this.Search_button.UseVisualStyleBackColor = true;
            this.Search_button.Click += new System.EventHandler(this.Search_button_Click);
            // 
            // split
            // 
            this.split.Location = new System.Drawing.Point(632, 0);
            this.split.Name = "split";
            this.split.Size = new System.Drawing.Size(49, 23);
            this.split.TabIndex = 6;
            this.split.Text = "+ ||";
            this.split.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "URL",
            "Google",
            "Bing",
            "Yahoo",
            "DuckDuckgo"});
            this.comboBox1.Location = new System.Drawing.Point(513, 3);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(70, 21);
            this.comboBox1.TabIndex = 7;
            this.comboBox1.Text = "URL";
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // Setting_button
            // 
            this.Setting_button.Location = new System.Drawing.Point(765, 0);
            this.Setting_button.Name = "Setting_button";
            this.Setting_button.Size = new System.Drawing.Size(29, 23);
            this.Setting_button.TabIndex = 8;
            this.Setting_button.Text = "⚙";
            this.Setting_button.UseVisualStyleBackColor = true;
            // 
            // PDF
            // 
            this.PDF.Location = new System.Drawing.Point(708, 0);
            this.PDF.Name = "PDF";
            this.PDF.Size = new System.Drawing.Size(51, 23);
            this.PDF.TabIndex = 9;
            this.PDF.Text = " ↓ PDF";
            this.PDF.UseVisualStyleBackColor = true;
            this.PDF.Click += new System.EventHandler(this.PDF_Click);
            // 
            // webBrowser1
            // 
            this.webBrowser1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.webBrowser1.Location = new System.Drawing.Point(2, 27);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(1254, 416);
            this.webBrowser1.TabIndex = 10;
            this.webBrowser1.DocumentCompleted += new System.Windows.Forms.WebBrowserDocumentCompletedEventHandler(this.webBrowser1_DocumentCompleted);
            this.webBrowser1.Navigating += new System.Windows.Forms.WebBrowserNavigatingEventHandler(this.webBrowser1_Navigating);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.AppStarting;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(103, -1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(26, 26);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Visible = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(814, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Home page";
            this.label1.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // frmBrowser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1257, 445);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.webBrowser1);
            this.Controls.Add(this.PDF);
            this.Controls.Add(this.Setting_button);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.split);
            this.Controls.Add(this.Search_button);
            this.Controls.Add(this.Refresh_button);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Back_button);
            this.Controls.Add(this.Home_button);
            this.Controls.Add(this.textBox1);
            this.Name = "frmBrowser";
            this.Text = "frmBrowser";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button Home_button;
        private System.Windows.Forms.Button Back_button;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button Refresh_button;
        private System.Windows.Forms.Button Search_button;
        private System.Windows.Forms.Button split;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button Setting_button;
        private System.Windows.Forms.Button PDF;
        private System.Windows.Forms.WebBrowser webBrowser1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
    }
}