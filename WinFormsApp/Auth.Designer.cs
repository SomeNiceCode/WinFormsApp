namespace WinFormsApp
{
    partial class Auth
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
            EnterLogin = new TextBox();
            EnterPassword = new TextBox();
            Enter = new Button();
            Registration = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 24F);
            label1.Location = new Point(68, 85);
            label1.Name = "label1";
            label1.Size = new Size(169, 65);
            label1.TabIndex = 0;
            label1.Text = "Login: ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 24F);
            label2.Location = new Point(68, 189);
            label2.Name = "label2";
            label2.Size = new Size(248, 65);
            label2.TabIndex = 1;
            label2.Text = "Password: ";
            // 
            // EnterLogin
            // 
            EnterLogin.Font = new Font("Segoe UI", 20F);
            EnterLogin.Location = new Point(394, 85);
            EnterLogin.Name = "EnterLogin";
            EnterLogin.Size = new Size(348, 61);
            EnterLogin.TabIndex = 2;
            EnterLogin.TextChanged += EnterLogin_TextChanged;
            // 
            // EnterPassword
            // 
            EnterPassword.Font = new Font("Segoe UI", 20F);
            EnterPassword.Location = new Point(393, 189);
            EnterPassword.Name = "EnterPassword";
            EnterPassword.Size = new Size(349, 61);
            EnterPassword.TabIndex = 3;
            EnterPassword.TextChanged += EnterPassword_TextChanged;
            // 
            // Enter
            // 
            Enter.Font = new Font("Segoe UI", 24F);
            Enter.Location = new Point(68, 338);
            Enter.Name = "Enter";
            Enter.Size = new Size(239, 78);
            Enter.TabIndex = 4;
            Enter.Text = "Confirm";
            Enter.UseVisualStyleBackColor = true;
            Enter.Click += Enter_Click;
            // 
            // Registration
            // 
            Registration.Font = new Font("Segoe UI", 24F);
            Registration.Location = new Point(497, 338);
            Registration.Name = "Registration";
            Registration.Size = new Size(245, 78);
            Registration.TabIndex = 5;
            Registration.Text = "Register";
            Registration.UseVisualStyleBackColor = true;
            Registration.Click += Registration_Click;
            // 
            // Auth
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(Registration);
            Controls.Add(Enter);
            Controls.Add(EnterPassword);
            Controls.Add(EnterLogin);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Auth";
            Text = "Auth";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox EnterLogin;
        private TextBox EnterPassword;
        private Button Enter;
        private Button Registration;
    }
}