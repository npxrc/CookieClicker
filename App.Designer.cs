namespace GameApp
{
    partial class App
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(App));
            title = new Label();
            runButton = new Button();
            timesClicked = new Label();
            cookieImage = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)cookieImage).BeginInit();
            SuspendLayout();
            // 
            // title
            // 
            title.AutoSize = true;
            title.Font = new Font("Segoe UI", 25F);
            title.Location = new Point(12, 9);
            title.Name = "title";
            title.Size = new Size(233, 46);
            title.TabIndex = 0;
            title.Text = "Cookie Clicker";
            // 
            // runButton
            // 
            runButton.BackColor = Color.FromArgb(191, 215, 234);
            runButton.Cursor = Cursors.Hand;
            runButton.FlatAppearance.BorderSize = 0;
            runButton.ForeColor = SystemColors.ControlText;
            runButton.ImageAlign = ContentAlignment.MiddleRight;
            runButton.Location = new Point(12, 58);
            runButton.Name = "runButton";
            runButton.Size = new Size(250, 30);
            runButton.TabIndex = 1;
            runButton.Text = "more cookie";
            runButton.UseVisualStyleBackColor = false;
            // 
            // timesClicked
            // 
            timesClicked.AutoSize = true;
            timesClicked.Font = new Font("Segoe UI", 12F);
            timesClicked.Location = new Point(12, 92);
            timesClicked.Name = "timesClicked";
            timesClicked.Size = new Size(81, 21);
            timesClicked.TabIndex = 2;
            timesClicked.Text = "Cookies: 0";
            // 
            // cookieImage
            // 
            cookieImage.Image = (Image)resources.GetObject("cookieImage.Image");
            cookieImage.InitialImage = (Image)resources.GetObject("cookieImage.InitialImage");
            cookieImage.Location = new Point(292, 22);
            cookieImage.Name = "cookieImage";
            cookieImage.Size = new Size(493, 440);
            cookieImage.TabIndex = 3;
            cookieImage.TabStop = false;
            // 
            // App
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(186, 168, 152);
            ClientSize = new Size(784, 461);
            Controls.Add(cookieImage);
            Controls.Add(timesClicked);
            Controls.Add(runButton);
            Controls.Add(title);
            ForeColor = SystemColors.ControlText;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MinimumSize = new Size(300, 400);
            Name = "App";
            Text = "Cookie Clicker";
            ((System.ComponentModel.ISupportInitialize)cookieImage).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label title;
        private Button runButton;
        private Label timesClicked;
        private PictureBox cookieImage;
    }
}
