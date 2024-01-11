namespace DN2ndHomeWinFormsApp
{
    partial class ManageAccountForm
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
            toolStrip1 = new ToolStrip();
            toolStripButtonClose = new ToolStripButton();
            toolStripButtonMinimize = new ToolStripButton();
            toolStripButtonBack = new ToolStripButton();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            tbUserName = new TextBox();
            tbEmail = new TextBox();
            tbPhone = new TextBox();
            tbPassword = new TextBox();
            btnEdit = new Button();
            openFileDialog1 = new OpenFileDialog();
            toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // toolStrip1
            // 
            toolStrip1.ImageScalingSize = new Size(20, 20);
            toolStrip1.Items.AddRange(new ToolStripItem[] { toolStripButtonClose, toolStripButtonMinimize, toolStripButtonBack });
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(656, 27);
            toolStrip1.TabIndex = 0;
            toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButtonClose
            // 
            toolStripButtonClose.Alignment = ToolStripItemAlignment.Right;
            toolStripButtonClose.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripButtonClose.Image = Properties.Resources.close;
            toolStripButtonClose.ImageTransparentColor = Color.Magenta;
            toolStripButtonClose.Name = "toolStripButtonClose";
            toolStripButtonClose.Size = new Size(29, 24);
            toolStripButtonClose.Text = "Close";
            toolStripButtonClose.Click += toolStripButtonClose_Click;
            // 
            // toolStripButtonMinimize
            // 
            toolStripButtonMinimize.Alignment = ToolStripItemAlignment.Right;
            toolStripButtonMinimize.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripButtonMinimize.Image = Properties.Resources.minimize_sign;
            toolStripButtonMinimize.ImageTransparentColor = Color.Magenta;
            toolStripButtonMinimize.Name = "toolStripButtonMinimize";
            toolStripButtonMinimize.Size = new Size(29, 24);
            toolStripButtonMinimize.Text = "Minimize";
            toolStripButtonMinimize.Click += toolStripButtonMinimize_Click;
            // 
            // toolStripButtonBack
            // 
            toolStripButtonBack.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripButtonBack.Image = Properties.Resources.left_arrow;
            toolStripButtonBack.ImageTransparentColor = Color.Magenta;
            toolStripButtonBack.Name = "toolStripButtonBack";
            toolStripButtonBack.Size = new Size(29, 24);
            toolStripButtonBack.Text = "Back";
            toolStripButtonBack.Click += toolStripButtonBack_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(183, 47);
            label1.Name = "label1";
            label1.Size = new Size(288, 37);
            label1.TabIndex = 1;
            label1.Text = "QUẢN LÝ TÀI KHOẢN";
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(23, 115);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(180, 169);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pbAvatar_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(246, 115);
            label2.Name = "label2";
            label2.Size = new Size(97, 20);
            label2.TabIndex = 3;
            label2.Text = "Tên tài khoản";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(297, 150);
            label3.Name = "label3";
            label3.Size = new Size(46, 20);
            label3.TabIndex = 4;
            label3.Text = "Email";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(246, 187);
            label4.Name = "label4";
            label4.Size = new Size(97, 20);
            label4.TabIndex = 5;
            label4.Text = "Số điện thoại";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(273, 225);
            label5.Name = "label5";
            label5.Size = new Size(70, 20);
            label5.TabIndex = 6;
            label5.Text = "Mật khẩu";
            // 
            // tbUserName
            // 
            tbUserName.Enabled = false;
            tbUserName.Location = new Point(369, 108);
            tbUserName.Name = "tbUserName";
            tbUserName.ReadOnly = true;
            tbUserName.Size = new Size(196, 27);
            tbUserName.TabIndex = 7;
            // 
            // tbEmail
            // 
            tbEmail.Enabled = false;
            tbEmail.Location = new Point(369, 143);
            tbEmail.Name = "tbEmail";
            tbEmail.ReadOnly = true;
            tbEmail.Size = new Size(196, 27);
            tbEmail.TabIndex = 8;
            // 
            // tbPhone
            // 
            tbPhone.Enabled = false;
            tbPhone.Location = new Point(369, 180);
            tbPhone.Name = "tbPhone";
            tbPhone.ReadOnly = true;
            tbPhone.Size = new Size(196, 27);
            tbPhone.TabIndex = 9;
            // 
            // tbPassword
            // 
            tbPassword.Enabled = false;
            tbPassword.Location = new Point(369, 218);
            tbPassword.Name = "tbPassword";
            tbPassword.ReadOnly = true;
            tbPassword.Size = new Size(196, 27);
            tbPassword.TabIndex = 10;
            // 
            // btnEdit
            // 
            btnEdit.Location = new Point(312, 315);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(94, 29);
            btnEdit.TabIndex = 11;
            btnEdit.Text = "Chỉnh sửa";
            btnEdit.UseVisualStyleBackColor = true;
            btnEdit.Click += btnEdit_Click;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // ManageAccountForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(656, 389);
            ControlBox = false;
            Controls.Add(btnEdit);
            Controls.Add(tbPassword);
            Controls.Add(tbPhone);
            Controls.Add(tbEmail);
            Controls.Add(tbUserName);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(pictureBox1);
            Controls.Add(label1);
            Controls.Add(toolStrip1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "ManageAccountForm";
            StartPosition = FormStartPosition.CenterScreen;
            Load += ManageAccountForm_Load;
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ToolStrip toolStrip1;
        private ToolStripButton toolStripButtonClose;
        private ToolStripButton toolStripButtonMinimize;
        private ToolStripButton toolStripButtonBack;
        private Label label1;
        private PictureBox pictureBox1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox tbUserName;
        private TextBox tbEmail;
        private TextBox tbPhone;
        private TextBox tbPassword;
        private Button btnEdit;
        private OpenFileDialog openFileDialog1;
    }
}