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
            btnSignIn = new Button();
            toolStrip1 = new ToolStrip();
            toolStripButtonLoginClose = new ToolStripButton();
            toolStripButtonLoginMinimize = new ToolStripButton();
            toolStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(117, 36);
            label1.Name = "label1";
            label1.Size = new Size(156, 37);
            label1.TabIndex = 0;
            label1.Text = "Đăng nhập";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(39, 94);
            label2.Name = "label2";
            label2.Size = new Size(32, 20);
            label2.TabIndex = 1;
            label2.Text = "Tên";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(18, 143);
            label3.Name = "label3";
            label3.Size = new Size(70, 20);
            label3.TabIndex = 2;
            label3.Text = "Mật khẩu";
            // 
            // tbUserName
            // 
            tbUserName.Location = new Point(98, 94);
            tbUserName.Name = "tbUserName";
            tbUserName.Size = new Size(196, 27);
            tbUserName.TabIndex = 3;
            // 
            // tbPassword
            // 
            tbPassword.Location = new Point(98, 140);
            tbPassword.Name = "tbPassword";
            tbPassword.Size = new Size(196, 27);
            tbPassword.TabIndex = 4;
            // 
            // btnLogin
            // 
            btnLogin.Location = new Point(72, 197);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(94, 29);
            btnLogin.TabIndex = 5;
            btnLogin.Text = "Đăng nhập";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            // 
            // btnSignIn
            // 
            btnSignIn.Location = new Point(200, 197);
            btnSignIn.Name = "btnSignIn";
            btnSignIn.Size = new Size(94, 29);
            btnSignIn.TabIndex = 7;
            btnSignIn.Text = "Đăng ký";
            btnSignIn.UseVisualStyleBackColor = true;
            btnSignIn.Click += btnSignIn_Click;
            // 
            // toolStrip1
            // 
            toolStrip1.ImageScalingSize = new Size(20, 20);
            toolStrip1.Items.AddRange(new ToolStripItem[] { toolStripButtonLoginClose, toolStripButtonLoginMinimize });
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(365, 27);
            toolStrip1.TabIndex = 8;
            toolStrip1.Text = "toolStrip1";
            toolStrip1.MouseDown += toolStrip1_MouseDown;
            toolStrip1.MouseMove += toolStrip1_MouseMove;
            // 
            // toolStripButtonLoginClose
            // 
            toolStripButtonLoginClose.Alignment = ToolStripItemAlignment.Right;
            toolStripButtonLoginClose.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripButtonLoginClose.Image = Properties.Resources.close;
            toolStripButtonLoginClose.ImageTransparentColor = Color.Magenta;
            toolStripButtonLoginClose.Name = "toolStripButtonLoginClose";
            toolStripButtonLoginClose.Size = new Size(29, 24);
            toolStripButtonLoginClose.Text = "Close";
            toolStripButtonLoginClose.Click += toolStripButtonClose_Click;
            // 
            // toolStripButtonLoginMinimize
            // 
            toolStripButtonLoginMinimize.Alignment = ToolStripItemAlignment.Right;
            toolStripButtonLoginMinimize.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripButtonLoginMinimize.Image = Properties.Resources.minimize_sign;
            toolStripButtonLoginMinimize.ImageTransparentColor = Color.Magenta;
            toolStripButtonLoginMinimize.Name = "toolStripButtonLoginMinimize";
            toolStripButtonLoginMinimize.Size = new Size(29, 24);
            toolStripButtonLoginMinimize.Text = "Minimize";
            toolStripButtonLoginMinimize.Click += toolStripButtonSignInMinimize_Click;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(365, 250);
            ControlBox = false;
            Controls.Add(toolStrip1);
            Controls.Add(btnSignIn);
            Controls.Add(btnLogin);
            Controls.Add(tbPassword);
            Controls.Add(tbUserName);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "LoginForm";
            StartPosition = FormStartPosition.CenterScreen;
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
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
        private Button btnSignIn;
        private ToolStrip toolStrip1;
        private ToolStripButton toolStripButtonLoginClose;
        private ToolStripButton toolStripButtonLoginMinimize;
    }
}