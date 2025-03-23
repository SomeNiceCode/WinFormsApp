namespace WinFormsApp
{
    partial class Registration
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
            label1 = new Label();
            label2 = new Label();
            EnterNewLogin = new TextBox();
            EnterNewPassword = new TextBox();
            DownloadPhoto = new Button();
            FinishRegistration = new Button();
            ShowPhoto = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)ShowPhoto).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F);
            label1.Location = new Point(21, 22);
            label1.Name = "label1";
            label1.Size = new Size(326, 54);
            label1.TabIndex = 0;
            label1.Text = "Enter your login: ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 20F);
            label2.Location = new Point(12, 170);
            label2.Name = "label2";
            label2.Size = new Size(404, 54);
            label2.TabIndex = 1;
            label2.Text = "Enter your password: ";
            // 
            // EnterNewLogin
            // 
            EnterNewLogin.Font = new Font("Segoe UI", 18F);
            EnterNewLogin.Location = new Point(21, 91);
            EnterNewLogin.Name = "EnterNewLogin";
            EnterNewLogin.Size = new Size(366, 55);
            EnterNewLogin.TabIndex = 2;
            EnterNewLogin.TextChanged += EnterNewLogin_TextChanged;
            // 
            // EnterNewPassword
            // 
            EnterNewPassword.Font = new Font("Segoe UI", 18F);
            EnterNewPassword.Location = new Point(21, 242);
            EnterNewPassword.Name = "EnterNewPassword";
            EnterNewPassword.Size = new Size(366, 55);
            EnterNewPassword.TabIndex = 3;
            EnterNewPassword.TextChanged += EnterNewPassword_TextChanged;
            // 
            // DownloadPhoto
            // 
            DownloadPhoto.Font = new Font("Segoe UI", 18F);
            DownloadPhoto.Location = new Point(21, 349);
            DownloadPhoto.Name = "DownloadPhoto";
            DownloadPhoto.Size = new Size(178, 61);
            DownloadPhoto.TabIndex = 4;
            DownloadPhoto.Text = "Photo...";
            DownloadPhoto.UseVisualStyleBackColor = true;
            DownloadPhoto.Click += DownloadPhoto_Click;
            // 
            // FinishRegistration
            // 
            FinishRegistration.Font = new Font("Segoe UI", 18F);
            FinishRegistration.Location = new Point(265, 349);
            FinishRegistration.Name = "FinishRegistration";
            FinishRegistration.Size = new Size(122, 61);
            FinishRegistration.TabIndex = 5;
            FinishRegistration.Text = "OK";
            FinishRegistration.UseVisualStyleBackColor = true;
            FinishRegistration.Click += FinishRegistration_Click;
            // 
            // ShowPhoto
            // 
            ShowPhoto.Location = new Point(413, 22);
            ShowPhoto.Name = "ShowPhoto";
            ShowPhoto.Size = new Size(365, 388);
            ShowPhoto.TabIndex = 6;
            ShowPhoto.TabStop = false;
            ShowPhoto.Click += ShowPhoto_Click;
            // 
            // Registration
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(ShowPhoto);
            Controls.Add(FinishRegistration);
            Controls.Add(DownloadPhoto);
            Controls.Add(EnterNewPassword);
            Controls.Add(EnterNewLogin);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Registration";
            Text = "Registration";
            ((System.ComponentModel.ISupportInitialize)ShowPhoto).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox EnterNewLogin;
        private TextBox EnterNewPassword;
        private Button DownloadPhoto;
        private Button FinishRegistration;
        private PictureBox ShowPhoto;
    }
}