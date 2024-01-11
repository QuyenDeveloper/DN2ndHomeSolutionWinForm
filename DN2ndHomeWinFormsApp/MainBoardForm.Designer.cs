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
            groupBox3 = new GroupBox();
            lbPostImageCount = new Label();
            btnPostPreviousImage = new Button();
            btnPostNextImage = new Button();
            pbPostImage = new PictureBox();
            tbPosterEmail = new TextBox();
            btnSavePost = new Button();
            tbPostTitle = new TextBox();
            label10 = new Label();
            label1 = new Label();
            tbPosterName = new TextBox();
            label2 = new Label();
            tbPostDetail = new TextBox();
            tbPosterPhone = new TextBox();
            label3 = new Label();
            label9 = new Label();
            label4 = new Label();
            label8 = new Label();
            tbPostAddress = new TextBox();
            label7 = new Label();
            label5 = new Label();
            tbPostPrice = new TextBox();
            tbPostArea = new TextBox();
            label6 = new Label();
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
            toolStrip1 = new ToolStrip();
            btnMainBoardClose = new ToolStripButton();
            btnMainBoardMinimize = new ToolStripButton();
            btnMainBoardRefresh = new ToolStripButton();
            btnSavedPost = new Button();
            groupBox1.SuspendLayout();
            tabControl1.SuspendLayout();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbPostImage).BeginInit();
            contextMenuStrip1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            toolStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.AutoSize = true;
            groupBox1.Controls.Add(tabControl1);
            groupBox1.Location = new Point(149, 13);
            groupBox1.Margin = new Padding(3, 4, 3, 4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 4, 3, 4);
            groupBox1.Size = new Size(656, 626);
            groupBox1.TabIndex = 6;
            groupBox1.TabStop = false;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPaneTinDang);
            tabControl1.Controls.Add(tabPageLienHe);
            tabControl1.Location = new Point(9, 17);
            tabControl1.Margin = new Padding(3, 4, 3, 4);
            tabControl1.Multiline = true;
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(641, 581);
            tabControl1.TabIndex = 2;
            // 
            // tabPaneTinDang
            // 
            tabPaneTinDang.Location = new Point(4, 29);
            tabPaneTinDang.Margin = new Padding(3, 4, 3, 4);
            tabPaneTinDang.Name = "tabPaneTinDang";
            tabPaneTinDang.Padding = new Padding(3, 4, 3, 4);
            tabPaneTinDang.Size = new Size(633, 548);
            tabPaneTinDang.TabIndex = 1;
            tabPaneTinDang.Text = "Tin Đăng ";
            tabPaneTinDang.UseVisualStyleBackColor = true;
            // 
            // tabPageLienHe
            // 
            tabPageLienHe.Location = new Point(4, 29);
            tabPageLienHe.Margin = new Padding(3, 4, 3, 4);
            tabPageLienHe.Name = "tabPageLienHe";
            tabPageLienHe.Size = new Size(633, 548);
            tabPageLienHe.TabIndex = 2;
            tabPageLienHe.Text = "Liên Hệ";
            tabPageLienHe.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(lbPostImageCount);
            groupBox3.Controls.Add(btnPostPreviousImage);
            groupBox3.Controls.Add(btnPostNextImage);
            groupBox3.Controls.Add(pbPostImage);
            groupBox3.Controls.Add(tbPosterEmail);
            groupBox3.Controls.Add(btnSavePost);
            groupBox3.Controls.Add(tbPostTitle);
            groupBox3.Controls.Add(label10);
            groupBox3.Controls.Add(label1);
            groupBox3.Controls.Add(tbPosterName);
            groupBox3.Controls.Add(label2);
            groupBox3.Controls.Add(tbPostDetail);
            groupBox3.Controls.Add(tbPosterPhone);
            groupBox3.Controls.Add(label3);
            groupBox3.Controls.Add(label9);
            groupBox3.Controls.Add(label4);
            groupBox3.Controls.Add(label8);
            groupBox3.Controls.Add(tbPostAddress);
            groupBox3.Controls.Add(label7);
            groupBox3.Controls.Add(label5);
            groupBox3.Controls.Add(tbPostPrice);
            groupBox3.Controls.Add(tbPostArea);
            groupBox3.Controls.Add(label6);
            groupBox3.Location = new Point(811, 12);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(506, 599);
            groupBox3.TabIndex = 27;
            groupBox3.TabStop = false;
            // 
            // lbPostImageCount
            // 
            lbPostImageCount.AutoSize = true;
            lbPostImageCount.Location = new Point(389, 221);
            lbPostImageCount.Name = "lbPostImageCount";
            lbPostImageCount.Size = new Size(31, 20);
            lbPostImageCount.TabIndex = 30;
            lbPostImageCount.Text = "0/0";
            // 
            // btnPostPreviousImage
            // 
            btnPostPreviousImage.Location = new Point(361, 332);
            btnPostPreviousImage.Name = "btnPostPreviousImage";
            btnPostPreviousImage.Size = new Size(94, 29);
            btnPostPreviousImage.TabIndex = 29;
            btnPostPreviousImage.Text = "<< <<";
            btnPostPreviousImage.UseVisualStyleBackColor = true;
            // 
            // btnPostNextImage
            // 
            btnPostNextImage.Location = new Point(361, 280);
            btnPostNextImage.Name = "btnPostNextImage";
            btnPostNextImage.Size = new Size(94, 29);
            btnPostNextImage.TabIndex = 28;
            btnPostNextImage.Text = ">> >>";
            btnPostNextImage.UseVisualStyleBackColor = true;
            // 
            // pbPostImage
            // 
            pbPostImage.Location = new Point(40, 221);
            pbPostImage.Name = "pbPostImage";
            pbPostImage.Size = new Size(293, 207);
            pbPostImage.SizeMode = PictureBoxSizeMode.StretchImage;
            pbPostImage.TabIndex = 27;
            pbPostImage.TabStop = false;
            // 
            // tbPosterEmail
            // 
            tbPosterEmail.Enabled = false;
            tbPosterEmail.Location = new Point(339, 520);
            tbPosterEmail.Name = "tbPosterEmail";
            tbPosterEmail.ReadOnly = true;
            tbPosterEmail.Size = new Size(144, 27);
            tbPosterEmail.TabIndex = 23;
            // 
            // btnSavePost
            // 
            btnSavePost.Location = new Point(389, 553);
            btnSavePost.Name = "btnSavePost";
            btnSavePost.Size = new Size(94, 29);
            btnSavePost.TabIndex = 26;
            btnSavePost.Text = "Lưu tin";
            btnSavePost.UseVisualStyleBackColor = true;
            // 
            // tbPostTitle
            // 
            tbPostTitle.Enabled = false;
            tbPostTitle.Location = new Point(100, 74);
            tbPostTitle.Multiline = true;
            tbPostTitle.Name = "tbPostTitle";
            tbPostTitle.ReadOnly = true;
            tbPostTitle.Size = new Size(381, 27);
            tbPostTitle.TabIndex = 8;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(100, 485);
            label10.Name = "label10";
            label10.Size = new Size(32, 20);
            label10.TabIndex = 25;
            label10.Text = "Tên";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(221, 21);
            label1.Name = "label1";
            label1.Size = new Size(110, 37);
            label1.TabIndex = 9;
            label1.Text = "Chi tiết";
            // 
            // tbPosterName
            // 
            tbPosterName.Enabled = false;
            tbPosterName.Location = new Point(138, 478);
            tbPosterName.Name = "tbPosterName";
            tbPosterName.ReadOnly = true;
            tbPosterName.Size = new Size(133, 27);
            tbPosterName.TabIndex = 24;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(33, 81);
            label2.Name = "label2";
            label2.Size = new Size(53, 20);
            label2.TabIndex = 10;
            label2.Text = "Tên tin";
            // 
            // tbPostDetail
            // 
            tbPostDetail.Enabled = false;
            tbPostDetail.Location = new Point(100, 107);
            tbPostDetail.Multiline = true;
            tbPostDetail.Name = "tbPostDetail";
            tbPostDetail.ReadOnly = true;
            tbPostDetail.Size = new Size(381, 27);
            tbPostDetail.TabIndex = 11;
            // 
            // tbPosterPhone
            // 
            tbPosterPhone.Enabled = false;
            tbPosterPhone.Location = new Point(138, 521);
            tbPosterPhone.Name = "tbPosterPhone";
            tbPosterPhone.ReadOnly = true;
            tbPosterPhone.Size = new Size(133, 27);
            tbPosterPhone.TabIndex = 22;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(38, 114);
            label3.Name = "label3";
            label3.Size = new Size(48, 20);
            label3.TabIndex = 12;
            label3.Text = "Mô tả";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(287, 524);
            label9.Name = "label9";
            label9.Size = new Size(46, 20);
            label9.TabIndex = 21;
            label9.Text = "Email";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(31, 147);
            label4.Name = "label4";
            label4.Size = new Size(55, 20);
            label4.TabIndex = 13;
            label4.Text = "Địa chỉ";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(35, 527);
            label8.Name = "label8";
            label8.Size = new Size(97, 20);
            label8.TabIndex = 20;
            label8.Text = "Số điện thoại";
            // 
            // tbPostAddress
            // 
            tbPostAddress.Enabled = false;
            tbPostAddress.Location = new Point(100, 140);
            tbPostAddress.Name = "tbPostAddress";
            tbPostAddress.ReadOnly = true;
            tbPostAddress.Size = new Size(381, 27);
            tbPostAddress.TabIndex = 14;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(33, 447);
            label7.Name = "label7";
            label7.Size = new Size(153, 20);
            label7.TabIndex = 19;
            label7.Text = "Thông tin người đăng";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(18, 180);
            label5.Name = "label5";
            label5.Size = new Size(68, 20);
            label5.TabIndex = 15;
            label5.Text = "Diện tích";
            // 
            // tbPostPrice
            // 
            tbPostPrice.Enabled = false;
            tbPostPrice.Location = new Point(312, 173);
            tbPostPrice.Name = "tbPostPrice";
            tbPostPrice.ReadOnly = true;
            tbPostPrice.Size = new Size(169, 27);
            tbPostPrice.TabIndex = 18;
            // 
            // tbPostArea
            // 
            tbPostArea.Enabled = false;
            tbPostArea.Location = new Point(100, 173);
            tbPostArea.Name = "tbPostArea";
            tbPostArea.ReadOnly = true;
            tbPostArea.Size = new Size(169, 27);
            tbPostArea.TabIndex = 16;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(275, 180);
            label6.Name = "label6";
            label6.Size = new Size(31, 20);
            label6.TabIndex = 17;
            label6.Text = "Giá";
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
            groupBox2.Controls.Add(btnSavedPost);
            groupBox2.Controls.Add(btnAdmin);
            groupBox2.Controls.Add(btnDangXuat);
            groupBox2.Controls.Add(btnTinDangCuaToi);
            groupBox2.Controls.Add(btnDangTin);
            groupBox2.Controls.Add(btnQuanLyTaiKhoan);
            groupBox2.Controls.Add(tbEmail);
            groupBox2.Controls.Add(tbPhone);
            groupBox2.Controls.Add(tbName);
            groupBox2.Controls.Add(pictureBox1);
            groupBox2.Location = new Point(0, 0);
            groupBox2.Margin = new Padding(3, 4, 3, 4);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(3, 4, 3, 4);
            groupBox2.Size = new Size(150, 618);
            groupBox2.TabIndex = 7;
            groupBox2.TabStop = false;
            // 
            // btnAdmin
            // 
            btnAdmin.Location = new Point(3, 471);
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
            btnDangXuat.Location = new Point(4, 432);
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
            btnTinDangCuaToi.Location = new Point(1, 358);
            btnTinDangCuaToi.Margin = new Padding(3, 4, 3, 4);
            btnTinDangCuaToi.Name = "btnTinDangCuaToi";
            btnTinDangCuaToi.Size = new Size(139, 31);
            btnTinDangCuaToi.TabIndex = 11;
            btnTinDangCuaToi.Text = "Tin đăng của tôi";
            btnTinDangCuaToi.UseVisualStyleBackColor = true;
            btnTinDangCuaToi.Click += btnTinDangCuaToi_Click;
            // 
            // btnDangTin
            // 
            btnDangTin.Location = new Point(1, 319);
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
            btnQuanLyTaiKhoan.Location = new Point(2, 279);
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
            tbEmail.Location = new Point(2, 245);
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
            tbPhone.Location = new Point(3, 212);
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
            tbName.Location = new Point(4, 179);
            tbName.Name = "tbName";
            tbName.ReadOnly = true;
            tbName.Size = new Size(140, 27);
            tbName.TabIndex = 6;
            tbName.TextAlign = HorizontalAlignment.Center;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(4, 30);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(139, 139);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            // 
            // toolStrip1
            // 
            toolStrip1.ImageScalingSize = new Size(20, 20);
            toolStrip1.Items.AddRange(new ToolStripItem[] { btnMainBoardClose, btnMainBoardMinimize, btnMainBoardRefresh });
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(1317, 27);
            toolStrip1.TabIndex = 28;
            toolStrip1.Text = "toolStrip1";
            toolStrip1.MouseDown += toolStrip1_MouseDown;
            toolStrip1.MouseMove += toolStrip1_MouseMove;
            // 
            // btnMainBoardClose
            // 
            btnMainBoardClose.Alignment = ToolStripItemAlignment.Right;
            btnMainBoardClose.DisplayStyle = ToolStripItemDisplayStyle.Image;
            btnMainBoardClose.Image = Properties.Resources.close;
            btnMainBoardClose.ImageTransparentColor = Color.Magenta;
            btnMainBoardClose.Name = "btnMainBoardClose";
            btnMainBoardClose.Size = new Size(29, 24);
            btnMainBoardClose.Text = "Close";
            btnMainBoardClose.Click += btnMainBoardClose_Click;
            // 
            // btnMainBoardMinimize
            // 
            btnMainBoardMinimize.Alignment = ToolStripItemAlignment.Right;
            btnMainBoardMinimize.DisplayStyle = ToolStripItemDisplayStyle.Image;
            btnMainBoardMinimize.Image = Properties.Resources.minimize_sign;
            btnMainBoardMinimize.ImageTransparentColor = Color.Magenta;
            btnMainBoardMinimize.Name = "btnMainBoardMinimize";
            btnMainBoardMinimize.Size = new Size(29, 24);
            btnMainBoardMinimize.Text = "Minimize";
            btnMainBoardMinimize.Click += btnMainBoardMinimize_Click;
            // 
            // btnMainBoardRefresh
            // 
            btnMainBoardRefresh.DisplayStyle = ToolStripItemDisplayStyle.Image;
            btnMainBoardRefresh.Image = Properties.Resources.refresh;
            btnMainBoardRefresh.ImageTransparentColor = Color.Magenta;
            btnMainBoardRefresh.Name = "btnMainBoardRefresh";
            btnMainBoardRefresh.Size = new Size(29, 24);
            btnMainBoardRefresh.Text = "Refresh";
            btnMainBoardRefresh.Click += btnMainBoardRefresh_Click;
            // 
            // btnSavedPost
            // 
            btnSavedPost.Location = new Point(3, 396);
            btnSavedPost.Name = "btnSavedPost";
            btnSavedPost.Size = new Size(140, 29);
            btnSavedPost.TabIndex = 13;
            btnSavedPost.Text = "Tin lưu";
            btnSavedPost.UseVisualStyleBackColor = true;
            // 
            // MainBoardForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ClientSize = new Size(1317, 628);
            ControlBox = false;
            Controls.Add(toolStrip1);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "MainBoardForm";
            StartPosition = FormStartPosition.CenterScreen;
            Load += MainBoardForm_Load;
            groupBox1.ResumeLayout(false);
            tabControl1.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pbPostImage).EndInit();
            contextMenuStrip1.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
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
        private Label label2;
        private TextBox tbPostDetail;
        private Label label4;
        private TextBox tbPostAddress;
        private Label label5;
        private TextBox tbPostArea;
        private Label label6;
        private TextBox tbPostPrice;
        private Label label7;
        private Label label8;
        private Label label9;
        private TextBox tbPosterPhone;
        private TextBox tbPosterEmail;
        private TextBox tbPosterName;
        private Label label10;
        private Button btnSavePost;
        private GroupBox groupBox3;
        private PictureBox pbPostImage;
        private Button btnPostPreviousImage;
        private Button btnPostNextImage;
        private Label lbPostImageCount;
        private ToolStrip toolStrip1;
        private ToolStripButton btnMainBoardClose;
        private ToolStripButton btnMainBoardMinimize;
        private ToolStripButton btnMainBoardRefresh;
        private Button btnSavedPost;
    }
}