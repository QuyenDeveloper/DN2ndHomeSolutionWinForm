namespace DN2ndHomeWinFormsApp
{
    partial class MainBoardForm
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
            components = new System.ComponentModel.Container();
            groupBox1 = new GroupBox();
            tabControl1 = new TabControl();
            tabPaneTinDang = new TabPage();
            tabPageLienHe = new TabPage();
            contextMenuStrip1 = new ContextMenuStrip(components);
            toolStripMenuItem2 = new ToolStripMenuItem();
            toolStripMenuItem3 = new ToolStripMenuItem();
            toolStripMenuItem4 = new ToolStripMenuItem();
            groupBox2 = new GroupBox();
            btnAdmin = new Button();
            btnDangXuat = new Button();
            btnTinDangCuaToi = new Button();
            btnDangTin = new Button();
            btnQuanLyTaiKhoan = new Button();
            tbEmail = new TextBox();
            tbPhone = new TextBox();
            tbName = new TextBox();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            tbPostTitle = new TextBox();
            groupBox1.SuspendLayout();
            tabControl1.SuspendLayout();
            contextMenuStrip1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.AutoSize = true;
            groupBox1.Controls.Add(tabControl1);
            groupBox1.Location = new Point(166, 5);
            groupBox1.Margin = new Padding(3, 4, 3, 4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 4, 3, 4);
            groupBox1.Size = new Size(614, 479);
            groupBox1.TabIndex = 6;
            groupBox1.TabStop = false;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPaneTinDang);
            tabControl1.Controls.Add(tabPageLienHe);
            tabControl1.Location = new Point(7, 50);
            tabControl1.Margin = new Padding(3, 4, 3, 4);
            tabControl1.Multiline = true;
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(601, 401);
            tabControl1.TabIndex = 2;
            // 
            // tabPaneTinDang
            // 
            tabPaneTinDang.Location = new Point(4, 29);
            tabPaneTinDang.Margin = new Padding(3, 4, 3, 4);
            tabPaneTinDang.Name = "tabPaneTinDang";
            tabPaneTinDang.Padding = new Padding(3, 4, 3, 4);
            tabPaneTinDang.Size = new Size(593, 368);
            tabPaneTinDang.TabIndex = 1;
            tabPaneTinDang.Text = "Tin Đăng ";
            tabPaneTinDang.UseVisualStyleBackColor = true;
            // 
            // tabPageLienHe
            // 
            tabPageLienHe.Location = new Point(4, 29);
            tabPageLienHe.Margin = new Padding(3, 4, 3, 4);
            tabPageLienHe.Name = "tabPageLienHe";
            tabPageLienHe.Size = new Size(593, 368);
            tabPageLienHe.TabIndex = 2;
            tabPageLienHe.Text = "Liên Hệ";
            tabPageLienHe.UseVisualStyleBackColor = true;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new Size(20, 20);
            contextMenuStrip1.Items.AddRange(new ToolStripItem[] { toolStripMenuItem2, toolStripMenuItem3, toolStripMenuItem4 });
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(87, 76);
            // 
            // toolStripMenuItem2
            // 
            toolStripMenuItem2.Name = "toolStripMenuItem2";
            toolStripMenuItem2.Size = new Size(86, 24);
            toolStripMenuItem2.Text = "1";
            // 
            // toolStripMenuItem3
            // 
            toolStripMenuItem3.Name = "toolStripMenuItem3";
            toolStripMenuItem3.Size = new Size(86, 24);
            toolStripMenuItem3.Text = "2";
            // 
            // toolStripMenuItem4
            // 
            toolStripMenuItem4.Name = "toolStripMenuItem4";
            toolStripMenuItem4.Size = new Size(86, 24);
            toolStripMenuItem4.Text = "3";
            // 
            // groupBox2
            // 
            groupBox2.AutoSize = true;
            groupBox2.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            groupBox2.Controls.Add(btnAdmin);
            groupBox2.Controls.Add(btnDangXuat);
            groupBox2.Controls.Add(btnTinDangCuaToi);
            groupBox2.Controls.Add(btnDangTin);
            groupBox2.Controls.Add(btnQuanLyTaiKhoan);
            groupBox2.Controls.Add(tbEmail);
            groupBox2.Controls.Add(tbPhone);
            groupBox2.Controls.Add(tbName);
            groupBox2.Controls.Add(pictureBox1);
            groupBox2.Location = new Point(11, 5);
            groupBox2.Margin = new Padding(3, 4, 3, 4);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(3, 4, 3, 4);
            groupBox2.Size = new Size(149, 479);
            groupBox2.TabIndex = 7;
            groupBox2.TabStop = false;
            // 
            // btnAdmin
            // 
            btnAdmin.Location = new Point(2, 420);
            btnAdmin.Margin = new Padding(3, 4, 3, 4);
            btnAdmin.Name = "btnAdmin";
            btnAdmin.Size = new Size(141, 31);
            btnAdmin.TabIndex = 8;
            btnAdmin.Text = "Admin";
            btnAdmin.UseVisualStyleBackColor = true;
            btnAdmin.Click += btnAdmin_Click;
            // 
            // btnDangXuat
            // 
            btnDangXuat.Location = new Point(2, 380);
            btnDangXuat.Margin = new Padding(3, 4, 3, 4);
            btnDangXuat.Name = "btnDangXuat";
            btnDangXuat.Size = new Size(139, 31);
            btnDangXuat.TabIndex = 12;
            btnDangXuat.Text = "Đăng xuất";
            btnDangXuat.UseVisualStyleBackColor = true;
            btnDangXuat.Click += btnDangXuat_Click;
            // 
            // btnTinDangCuaToi
            // 
            btnTinDangCuaToi.Location = new Point(2, 341);
            btnTinDangCuaToi.Margin = new Padding(3, 4, 3, 4);
            btnTinDangCuaToi.Name = "btnTinDangCuaToi";
            btnTinDangCuaToi.Size = new Size(139, 31);
            btnTinDangCuaToi.TabIndex = 11;
            btnTinDangCuaToi.Text = "Tin đăng của tôi";
            btnTinDangCuaToi.UseVisualStyleBackColor = true;
            // 
            // btnDangTin
            // 
            btnDangTin.Location = new Point(2, 303);
            btnDangTin.Margin = new Padding(3, 4, 3, 4);
            btnDangTin.Name = "btnDangTin";
            btnDangTin.Size = new Size(141, 31);
            btnDangTin.TabIndex = 10;
            btnDangTin.Text = "Đăng Tin";
            btnDangTin.UseVisualStyleBackColor = true;
            btnDangTin.Click += btnDangTin_Click;
            // 
            // btnQuanLyTaiKhoan
            // 
            btnQuanLyTaiKhoan.Location = new Point(2, 264);
            btnQuanLyTaiKhoan.Margin = new Padding(3, 4, 3, 4);
            btnQuanLyTaiKhoan.Name = "btnQuanLyTaiKhoan";
            btnQuanLyTaiKhoan.Size = new Size(141, 31);
            btnQuanLyTaiKhoan.TabIndex = 9;
            btnQuanLyTaiKhoan.Text = "Quản lý tài khoản";
            btnQuanLyTaiKhoan.UseVisualStyleBackColor = true;
            btnQuanLyTaiKhoan.Click += btnQuanLyTaiKhoan_Click;
            // 
            // tbEmail
            // 
            tbEmail.Enabled = false;
            tbEmail.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            tbEmail.Location = new Point(2, 230);
            tbEmail.Name = "tbEmail";
            tbEmail.ReadOnly = true;
            tbEmail.Size = new Size(140, 27);
            tbEmail.TabIndex = 8;
            tbEmail.TextAlign = HorizontalAlignment.Center;
            // 
            // tbPhone
            // 
            tbPhone.Enabled = false;
            tbPhone.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            tbPhone.Location = new Point(3, 197);
            tbPhone.Name = "tbPhone";
            tbPhone.ReadOnly = true;
            tbPhone.Size = new Size(140, 27);
            tbPhone.TabIndex = 7;
            tbPhone.TextAlign = HorizontalAlignment.Center;
            // 
            // tbName
            // 
            tbName.Enabled = false;
            tbName.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            tbName.Location = new Point(2, 164);
            tbName.Name = "tbName";
            tbName.ReadOnly = true;
            tbName.Size = new Size(140, 27);
            tbName.TabIndex = 6;
            tbName.TextAlign = HorizontalAlignment.Center;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(2, 19);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(139, 139);
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(930, 24);
            label1.Name = "label1";
            label1.Size = new Size(273, 37);
            label1.TabIndex = 9;
            label1.Text = "Selected Post Detail";
            // 
            // tbPostTitle
            // 
            tbPostTitle.Location = new Point(855, 84);
            tbPostTitle.Name = "tbPostTitle";
            tbPostTitle.Size = new Size(410, 27);
            tbPostTitle.TabIndex = 8;
            // 
            // MainBoardForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ClientSize = new Size(1317, 491);
            Controls.Add(label1);
            Controls.Add(tbPostTitle);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "MainBoardForm";
            Text = "MainBoardForm";
            Load += MainBoardForm_Load;
            groupBox1.ResumeLayout(false);
            tabControl1.ResumeLayout(false);
            contextMenuStrip1.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private TextBox tbEmail;
        private TextBox tbPhone;
        private TextBox tbName;
        private PictureBox pictureBox1;
        private ToolStripMenuItem tinĐăngToolStripMenuItem;
        private ToolStripMenuItem đăngTinToolStripMenuItem;
        private ToolStripMenuItem tinCủaBạnToolStripMenuItem;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPaneTinDang;
        private ContextMenuStrip contextMenuStrip1;
        private TabPage tabPageLienHe;
        private ToolStripMenuItem toolStripMenuItem2;
        private ToolStripMenuItem toolStripMenuItem3;
        private ToolStripMenuItem toolStripMenuItem4;
        private Button btnDangXuat;
        private Button btnTinDangCuaToi;
        private Button btnDangTin;
        private Button btnQuanLyTaiKhoan;
        private Button btnAdmin;
        private Label label3;
        private Label label1;
        private TextBox tbPostTitle;
    }
}