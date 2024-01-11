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
            toolStrip1 = new ToolStrip();
            btnSignUpFormClose = new ToolStripButton();
            btnSignUpFormMinimize = new ToolStripButton();
            btnSignUpBack = new ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)pbAvatar).BeginInit();
            toolStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(258, 27);
            label1.Name = "label1";
            label1.Size = new Size(137, 37);
            label1.TabIndex = 0;
            label1.Text = "ĐĂNG KÝ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(44, 83);
            label2.Name = "label2";
            label2.Size = new Size(97, 20);
            label2.TabIndex = 1;
            label2.Text = "Tên tài khoản";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(71, 126);
            label3.Name = "label3";
            label3.Size = new Size(70, 20);
            label3.TabIndex = 2;
            label3.Text = "Mật khẩu";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(11, 169);
            label4.Name = "label4";
            label4.Size = new Size(130, 20);
            label4.TabIndex = 3;
            label4.Text = "Nhập lại mật khẩu";
            // 
            // tbName
            // 
            tbName.Location = new Point(188, 76);
            tbName.Name = "tbName";
            tbName.Size = new Size(207, 27);
            tbName.TabIndex = 4;
            // 
            // tbPassword
            // 
            tbPassword.Location = new Point(188, 119);
            tbPassword.Name = "tbPassword";
            tbPassword.PasswordChar = '*';
            tbPassword.Size = new Size(207, 27);
            tbPassword.TabIndex = 5;
            // 
            // tbConfirmPassword
            // 
            tbConfirmPassword.Location = new Point(188, 162);
            tbConfirmPassword.Name = "tbConfirmPassword";
            tbConfirmPassword.PasswordChar = '*';
            tbConfirmPassword.Size = new Size(207, 27);
            tbConfirmPassword.TabIndex = 6;
            // 
            // btnSignIn
            // 
            btnSignIn.Location = new Point(258, 309);
            btnSignIn.Name = "btnSignIn";
            btnSignIn.Size = new Size(94, 29);
            btnSignIn.TabIndex = 7;
            btnSignIn.Text = "Đăng ký";
            btnSignIn.UseVisualStyleBackColor = true;
            btnSignIn.Click += btnSignIn_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(44, 216);
            label5.Name = "label5";
            label5.Size = new Size(97, 20);
            label5.TabIndex = 8;
            label5.Text = "Số điện thoại";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(95, 257);
            label6.Name = "label6";
            label6.Size = new Size(46, 20);
            label6.TabIndex = 9;
            label6.Text = "Email";
            // 
            // tbPhone
            // 
            tbPhone.Location = new Point(188, 209);
            tbPhone.Name = "tbPhone";
            tbPhone.Size = new Size(207, 27);
            tbPhone.TabIndex = 10;
            // 
            // tbEmail
            // 
            tbEmail.Location = new Point(188, 257);
            tbEmail.Name = "tbEmail";
            tbEmail.Size = new Size(207, 27);
            tbEmail.TabIndex = 11;
            // 
            // pbAvatar
            // 
            pbAvatar.BorderStyle = BorderStyle.FixedSingle;
            pbAvatar.Location = new Point(438, 76);
            pbAvatar.Name = "pbAvatar";
            pbAvatar.Size = new Size(181, 174);
            pbAvatar.SizeMode = PictureBoxSizeMode.StretchImage;
            pbAvatar.TabIndex = 12;
            pbAvatar.TabStop = false;
            pbAvatar.Click += pbAvatar_Click;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // toolStrip1
            // 
            toolStrip1.ImageScalingSize = new Size(20, 20);
            toolStrip1.Items.AddRange(new ToolStripItem[] { btnSignUpFormClose, btnSignUpFormMinimize, btnSignUpBack });
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(656, 27);
            toolStrip1.TabIndex = 13;
            toolStrip1.Text = "toolStrip1";
            toolStrip1.MouseDown += toolStrip1_MouseDown;
            toolStrip1.MouseMove += toolStrip1_MouseMove;
            // 
            // btnSignUpFormClose
            // 
            btnSignUpFormClose.Alignment = ToolStripItemAlignment.Right;
            btnSignUpFormClose.DisplayStyle = ToolStripItemDisplayStyle.Image;
            btnSignUpFormClose.Image = Properties.Resources.close;
            btnSignUpFormClose.ImageTransparentColor = Color.Magenta;
            btnSignUpFormClose.Name = "btnSignUpFormClose";
            btnSignUpFormClose.Size = new Size(29, 24);
            btnSignUpFormClose.Text = "toolStripButton1";
            btnSignUpFormClose.Click += btnSignUpFormClose_Click;
            // 
            // btnSignUpFormMinimize
            // 
            btnSignUpFormMinimize.Alignment = ToolStripItemAlignment.Right;
            btnSignUpFormMinimize.DisplayStyle = ToolStripItemDisplayStyle.Image;
            btnSignUpFormMinimize.Image = Properties.Resources.minimize_sign;
            btnSignUpFormMinimize.ImageTransparentColor = Color.Magenta;
            btnSignUpFormMinimize.Name = "btnSignUpFormMinimize";
            btnSignUpFormMinimize.Size = new Size(29, 24);
            btnSignUpFormMinimize.Text = "toolStripButton2";
            btnSignUpFormMinimize.Click += btnSignUpFormMinimize_Click;
            // 
            // btnSignUpBack
            // 
            btnSignUpBack.DisplayStyle = ToolStripItemDisplayStyle.Image;
            btnSignUpBack.Image = Properties.Resources.left_arrow;
            btnSignUpBack.ImageTransparentColor = Color.Magenta;
            btnSignUpBack.Name = "btnSignUpBack";
            btnSignUpBack.Size = new Size(29, 24);
            btnSignUpBack.Text = "toolStripButton1";
            btnSignUpBack.Click += btnSignUpBack_Click;
            // 
            // SignUpForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(656, 364);
            ControlBox = false;
            Controls.Add(toolStrip1);
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
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "SignUpForm";
            StartPosition = FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)pbAvatar).EndInit();
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
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
        private ToolStrip toolStrip1;
        private ToolStripButton btnSignUpFormClose;
        private ToolStripButton btnSignUpFormMinimize;
        private ToolStripButton btnSignUpBack;
    }
}