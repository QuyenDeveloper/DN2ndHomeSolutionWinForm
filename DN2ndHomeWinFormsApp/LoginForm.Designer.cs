namespace DN2ndHomeWinFormsApp
{
    partial class LoginForm
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            tbUserName = new TextBox();
            tbPassword = new TextBox();
            btnLogin = new Button();
            btnLoginAsGuest = new Button();
            btnSignIn = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(167, 9);
            label1.Name = "label1";
            label1.Size = new Size(89, 37);
            label1.TabIndex = 0;
            label1.Text = "Login";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(33, 64);
            label2.Name = "label2";
            label2.Size = new Size(49, 20);
            label2.TabIndex = 1;
            label2.Text = "Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 113);
            label3.Name = "label3";
            label3.Size = new Size(70, 20);
            label3.TabIndex = 2;
            label3.Text = "Password";
            // 
            // tbUserName
            // 
            tbUserName.Location = new Point(92, 64);
            tbUserName.Name = "tbUserName";
            tbUserName.Size = new Size(196, 27);
            tbUserName.TabIndex = 3;
            // 
            // tbPassword
            // 
            tbPassword.Location = new Point(92, 110);
            tbPassword.Name = "tbPassword";
            tbPassword.Size = new Size(196, 27);
            tbPassword.TabIndex = 4;
            // 
            // btnLogin
            // 
            btnLogin.Location = new Point(132, 165);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(94, 29);
            btnLogin.TabIndex = 5;
            btnLogin.Text = "Sign in";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            // 
            // btnLoginAsGuest
            // 
            btnLoginAsGuest.Location = new Point(344, 113);
            btnLoginAsGuest.Name = "btnLoginAsGuest";
            btnLoginAsGuest.Size = new Size(129, 29);
            btnLoginAsGuest.TabIndex = 6;
            btnLoginAsGuest.Text = "Login As Guest";
            btnLoginAsGuest.UseVisualStyleBackColor = true;
            // 
            // btnSignIn
            // 
            btnSignIn.Location = new Point(344, 64);
            btnSignIn.Name = "btnSignIn";
            btnSignIn.Size = new Size(94, 29);
            btnSignIn.TabIndex = 7;
            btnSignIn.Text = "Sign up";
            btnSignIn.UseVisualStyleBackColor = true;
            btnSignIn.Click += btnSignIn_Click;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(487, 206);
            Controls.Add(btnSignIn);
            Controls.Add(btnLoginAsGuest);
            Controls.Add(btnLogin);
            Controls.Add(tbPassword);
            Controls.Add(tbUserName);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "LoginForm";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox tbUserName;
        private TextBox tbPassword;
        private Button btnLogin;
        private Button btnLoginAsGuest;
        private Button btnSignIn;
    }
}