namespace DN2ndHomeWinFormsApp
{
    partial class SignUpForm
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
            label3 = new Label();
            label4 = new Label();
            tbName = new TextBox();
            tbPassword = new TextBox();
            tbConfirmPassword = new TextBox();
            btnSignIn = new Button();
            label5 = new Label();
            label6 = new Label();
            tbPhone = new TextBox();
            tbEmail = new TextBox();
            pbAvatar = new PictureBox();
            openFileDialog1 = new OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)pbAvatar).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(359, 65);
            label1.Name = "label1";
            label1.Size = new Size(61, 20);
            label1.TabIndex = 0;
            label1.Text = "Sign Up";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(138, 120);
            label2.Name = "label2";
            label2.Size = new Size(49, 20);
            label2.TabIndex = 1;
            label2.Text = "Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(128, 160);
            label3.Name = "label3";
            label3.Size = new Size(70, 20);
            label3.TabIndex = 2;
            label3.Text = "Password";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(103, 206);
            label4.Name = "label4";
            label4.Size = new Size(129, 20);
            label4.TabIndex = 3;
            label4.Text = "Confirm password";
            // 
            // tbName
            // 
            tbName.Location = new Point(287, 117);
            tbName.Name = "tbName";
            tbName.Size = new Size(207, 27);
            tbName.TabIndex = 4;
            // 
            // tbPassword
            // 
            tbPassword.Location = new Point(287, 157);
            tbPassword.Name = "tbPassword";
            tbPassword.PasswordChar = '*';
            tbPassword.Size = new Size(207, 27);
            tbPassword.TabIndex = 5;
            // 
            // tbConfirmPassword
            // 
            tbConfirmPassword.Location = new Point(287, 203);
            tbConfirmPassword.Name = "tbConfirmPassword";
            tbConfirmPassword.PasswordChar = '*';
            tbConfirmPassword.Size = new Size(207, 27);
            tbConfirmPassword.TabIndex = 6;
            // 
            // btnSignIn
            // 
            btnSignIn.Location = new Point(287, 352);
            btnSignIn.Name = "btnSignIn";
            btnSignIn.Size = new Size(94, 29);
            btnSignIn.TabIndex = 7;
            btnSignIn.Text = "Sign Up";
            btnSignIn.UseVisualStyleBackColor = true;
            btnSignIn.Click += btnSignIn_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(138, 253);
            label5.Name = "label5";
            label5.Size = new Size(50, 20);
            label5.TabIndex = 8;
            label5.Text = "Phone";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(141, 298);
            label6.Name = "label6";
            label6.Size = new Size(46, 20);
            label6.TabIndex = 9;
            label6.Text = "Email";
            // 
            // tbPhone
            // 
            tbPhone.Location = new Point(287, 250);
            tbPhone.Name = "tbPhone";
            tbPhone.Size = new Size(207, 27);
            tbPhone.TabIndex = 10;
            // 
            // tbEmail
            // 
            tbEmail.Location = new Point(287, 291);
            tbEmail.Name = "tbEmail";
            tbEmail.Size = new Size(207, 27);
            tbEmail.TabIndex = 11;
            // 
            // pbAvatar
            // 
            pbAvatar.BorderStyle = BorderStyle.FixedSingle;
            pbAvatar.Location = new Point(550, 120);
            pbAvatar.Name = "pbAvatar";
            pbAvatar.Size = new Size(147, 153);
            pbAvatar.SizeMode = PictureBoxSizeMode.StretchImage;
            pbAvatar.TabIndex = 12;
            pbAvatar.TabStop = false;
            pbAvatar.Click += pbAvatar_Click;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // SignInForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(pbAvatar);
            Controls.Add(tbEmail);
            Controls.Add(tbPhone);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(btnSignIn);
            Controls.Add(tbConfirmPassword);
            Controls.Add(tbPassword);
            Controls.Add(tbName);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "SignInForm";
            Text = "SignUpForm";
            Load += SignInForm_Load;
            ((System.ComponentModel.ISupportInitialize)pbAvatar).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox tbName;
        private TextBox tbPassword;
        private TextBox tbConfirmPassword;
        private Button btnSignIn;
        private Label label5;
        private Label label6;
        private TextBox tbPhone;
        private TextBox tbEmail;
        private PictureBox pbAvatar;
        private OpenFileDialog openFileDialog1;
    }
}