﻿namespace DN2ndHomeWinFormsApp
{
    partial class PostForm
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
            label2 = new Label();
            label4 = new Label();
            label5 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            label3 = new Label();
            tbTitle = new TextBox();
            tbDetail = new TextBox();
            tbPrice = new TextBox();
            tbArea = new TextBox();
            tbDetailAddress = new TextBox();
            cbDistrict = new ComboBox();
            cbWard = new ComboBox();
            sqlCommand1 = new Microsoft.Data.SqlClient.SqlCommand();
            btnSave = new Button();
            btnCancel = new Button();
            pbPost1 = new PictureBox();
            pbPost2 = new PictureBox();
            pbPost3 = new PictureBox();
            pbPost4 = new PictureBox();
            postOpenFileDialog = new OpenFileDialog();
            label1 = new Label();
            label6 = new Label();
            label11 = new Label();
            label12 = new Label();
            toolStrip1 = new ToolStrip();
            btnPostFormClose = new ToolStripButton();
            btnPostFormMinimize = new ToolStripButton();
            btnPostFormBack = new ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)pbPost1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbPost2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbPost3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbPost4).BeginInit();
            toolStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(77, 104);
            label2.Name = "label2";
            label2.Size = new Size(58, 20);
            label2.TabIndex = 1;
            label2.Text = "Tiêu đề";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(87, 137);
            label4.Name = "label4";
            label4.Size = new Size(48, 20);
            label4.TabIndex = 3;
            label4.Text = "Mô tả";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 167);
            label5.Name = "label5";
            label5.Size = new Size(123, 20);
            label5.TabIndex = 4;
            label5.Text = "Giá (VND/Tháng)";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(67, 204);
            label7.Name = "label7";
            label7.Size = new Size(68, 20);
            label7.TabIndex = 6;
            label7.Text = "Diện tích";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(31, 237);
            label8.Name = "label8";
            label8.Size = new Size(104, 20);
            label8.TabIndex = 7;
            label8.Text = "Địa chỉ chi tiết";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(87, 271);
            label9.Name = "label9";
            label9.Size = new Size(44, 20);
            label9.TabIndex = 8;
            label9.Text = "Quận";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(71, 300);
            label10.Name = "label10";
            label10.Size = new Size(60, 20);
            label10.TabIndex = 9;
            label10.Text = "Phường";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(287, 41);
            label3.Name = "label3";
            label3.Size = new Size(149, 37);
            label3.TabIndex = 10;
            label3.Text = "ĐĂNG TIN";
            // 
            // tbTitle
            // 
            tbTitle.Location = new Point(156, 101);
            tbTitle.Name = "tbTitle";
            tbTitle.Size = new Size(151, 27);
            tbTitle.TabIndex = 11;
            // 
            // tbDetail
            // 
            tbDetail.Location = new Point(156, 134);
            tbDetail.Name = "tbDetail";
            tbDetail.Size = new Size(151, 27);
            tbDetail.TabIndex = 12;
            // 
            // tbPrice
            // 
            tbPrice.Location = new Point(156, 164);
            tbPrice.Name = "tbPrice";
            tbPrice.Size = new Size(151, 27);
            tbPrice.TabIndex = 13;
            // 
            // tbArea
            // 
            tbArea.Location = new Point(156, 197);
            tbArea.Name = "tbArea";
            tbArea.Size = new Size(151, 27);
            tbArea.TabIndex = 14;
            // 
            // tbDetailAddress
            // 
            tbDetailAddress.Location = new Point(156, 230);
            tbDetailAddress.Name = "tbDetailAddress";
            tbDetailAddress.Size = new Size(151, 27);
            tbDetailAddress.TabIndex = 15;
            // 
            // cbDistrict
            // 
            cbDistrict.FormattingEnabled = true;
            cbDistrict.Location = new Point(156, 263);
            cbDistrict.Name = "cbDistrict";
            cbDistrict.Size = new Size(151, 28);
            cbDistrict.TabIndex = 17;
            // 
            // cbWard
            // 
            cbWard.FormattingEnabled = true;
            cbWard.Location = new Point(156, 297);
            cbWard.Name = "cbWard";
            cbWard.Size = new Size(151, 28);
            cbWard.TabIndex = 18;
            // 
            // sqlCommand1
            // 
            sqlCommand1.CommandTimeout = 30;
            sqlCommand1.Connection = null;
            sqlCommand1.Notification = null;
            sqlCommand1.Transaction = null;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(189, 346);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(94, 29);
            btnSave.TabIndex = 19;
            btnSave.Text = "Đăng";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(342, 346);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(94, 29);
            btnCancel.TabIndex = 20;
            btnCancel.Text = "Hủy";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // pbPost1
            // 
            pbPost1.BorderStyle = BorderStyle.FixedSingle;
            pbPost1.Location = new Point(356, 101);
            pbPost1.Name = "pbPost1";
            pbPost1.Size = new Size(125, 85);
            pbPost1.SizeMode = PictureBoxSizeMode.StretchImage;
            pbPost1.TabIndex = 21;
            pbPost1.TabStop = false;
            pbPost1.Click += pbPost1_Click;
            // 
            // pbPost2
            // 
            pbPost2.BorderStyle = BorderStyle.FixedSingle;
            pbPost2.Location = new Point(545, 101);
            pbPost2.Name = "pbPost2";
            pbPost2.Size = new Size(125, 85);
            pbPost2.SizeMode = PictureBoxSizeMode.StretchImage;
            pbPost2.TabIndex = 22;
            pbPost2.TabStop = false;
            pbPost2.Click += pbPost1_Click;
            // 
            // pbPost3
            // 
            pbPost3.BorderStyle = BorderStyle.FixedSingle;
            pbPost3.Location = new Point(356, 221);
            pbPost3.Name = "pbPost3";
            pbPost3.Size = new Size(125, 92);
            pbPost3.SizeMode = PictureBoxSizeMode.StretchImage;
            pbPost3.TabIndex = 23;
            pbPost3.TabStop = false;
            pbPost3.Click += pbPost1_Click;
            // 
            // pbPost4
            // 
            pbPost4.BorderStyle = BorderStyle.FixedSingle;
            pbPost4.Location = new Point(545, 221);
            pbPost4.Name = "pbPost4";
            pbPost4.Size = new Size(125, 92);
            pbPost4.SizeMode = PictureBoxSizeMode.StretchImage;
            pbPost4.TabIndex = 24;
            pbPost4.TabStop = false;
            pbPost4.Click += pbPost1_Click;
            // 
            // postOpenFileDialog
            // 
            postOpenFileDialog.FileName = "openFileDialog1";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(397, 189);
            label1.Name = "label1";
            label1.Size = new Size(47, 20);
            label1.TabIndex = 25;
            label1.Text = "Ảnh 1";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(588, 189);
            label6.Name = "label6";
            label6.Size = new Size(47, 20);
            label6.TabIndex = 26;
            label6.Text = "Ảnh 2";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(397, 316);
            label11.Name = "label11";
            label11.Size = new Size(47, 20);
            label11.TabIndex = 27;
            label11.Text = "Ảnh 3";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(588, 316);
            label12.Name = "label12";
            label12.Size = new Size(47, 20);
            label12.TabIndex = 28;
            label12.Text = "Ảnh 4";
            // 
            // toolStrip1
            // 
            toolStrip1.ImageScalingSize = new Size(20, 20);
            toolStrip1.Items.AddRange(new ToolStripItem[] { btnPostFormClose, btnPostFormMinimize, btnPostFormBack });
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(690, 27);
            toolStrip1.TabIndex = 29;
            toolStrip1.Text = "toolStrip1";
            toolStrip1.MouseDown += toolStrip1_MouseDown;
            toolStrip1.MouseMove += toolStrip1_MouseMove;
            // 
            // btnPostFormClose
            // 
            btnPostFormClose.Alignment = ToolStripItemAlignment.Right;
            btnPostFormClose.DisplayStyle = ToolStripItemDisplayStyle.Image;
            btnPostFormClose.Image = Properties.Resources.close;
            btnPostFormClose.ImageTransparentColor = Color.Magenta;
            btnPostFormClose.Name = "btnPostFormClose";
            btnPostFormClose.Size = new Size(29, 24);
            btnPostFormClose.Text = "Close";
            btnPostFormClose.Click += btnPostFormClose_Click;
            // 
            // btnPostFormMinimize
            // 
            btnPostFormMinimize.Alignment = ToolStripItemAlignment.Right;
            btnPostFormMinimize.DisplayStyle = ToolStripItemDisplayStyle.Image;
            btnPostFormMinimize.Image = Properties.Resources.minimize_sign;
            btnPostFormMinimize.ImageTransparentColor = Color.Magenta;
            btnPostFormMinimize.Name = "btnPostFormMinimize";
            btnPostFormMinimize.Size = new Size(29, 24);
            btnPostFormMinimize.Text = "Minimize";
            btnPostFormMinimize.Click += btnPostFormMinimize_Click;
            // 
            // btnPostFormBack
            // 
            btnPostFormBack.DisplayStyle = ToolStripItemDisplayStyle.Image;
            btnPostFormBack.Image = Properties.Resources.left_arrow;
            btnPostFormBack.ImageTransparentColor = Color.Magenta;
            btnPostFormBack.Name = "btnPostFormBack";
            btnPostFormBack.Size = new Size(29, 24);
            btnPostFormBack.Text = "Back";
            btnPostFormBack.Click += btnPostFormBack_Click;
            // 
            // PostForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(690, 406);
            ControlBox = false;
            Controls.Add(toolStrip1);
            Controls.Add(label12);
            Controls.Add(label11);
            Controls.Add(label6);
            Controls.Add(label1);
            Controls.Add(pbPost4);
            Controls.Add(pbPost3);
            Controls.Add(pbPost2);
            Controls.Add(pbPost1);
            Controls.Add(btnCancel);
            Controls.Add(btnSave);
            Controls.Add(cbWard);
            Controls.Add(cbDistrict);
            Controls.Add(tbDetailAddress);
            Controls.Add(tbArea);
            Controls.Add(tbPrice);
            Controls.Add(tbDetail);
            Controls.Add(tbTitle);
            Controls.Add(label3);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label2);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "PostForm";
            StartPosition = FormStartPosition.CenterScreen;
            Load += PostForm_Load;
            ((System.ComponentModel.ISupportInitialize)pbPost1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbPost2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbPost3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbPost4).EndInit();
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label2;
        private Label label4;
        private Label label5;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
        private Label label3;
        private TextBox tbTitle;
        private TextBox tbDetail;
        private TextBox tbPrice;
        private TextBox tbArea;
        private TextBox tbDetailAddress;
        private ComboBox cbDistrict;
        private ComboBox cbWard;
        private Microsoft.Data.SqlClient.SqlCommand sqlCommand1;
        private Button btnSave;
        private Button btnCancel;
        private PictureBox pbPost1;
        private PictureBox pbPost2;
        private PictureBox pbPost3;
        private PictureBox pbPost4;
        private OpenFileDialog postOpenFileDialog;
        private Label label1;
        private Label label6;
        private Label label11;
        private Label label12;
        private ToolStrip toolStrip1;
        private ToolStripButton btnPostFormClose;
        private ToolStripButton btnPostFormMinimize;
        private ToolStripButton btnPostFormBack;
    }
}