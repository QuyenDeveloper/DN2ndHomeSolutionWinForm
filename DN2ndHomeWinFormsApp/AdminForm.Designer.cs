namespace DN2ndHomeWinFormsApp
{
    partial class AdminForm
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
            wardDataGridView = new DataGridView();
            tabControl1 = new TabControl();
            tPUserMa = new TabPage();
            btnUserInsert = new Button();
            tbUserSearch = new TextBox();
            label10 = new Label();
            label9 = new Label();
            btnUserDelete = new Button();
            btnUserUpdate = new Button();
            tbCreatedDate = new TextBox();
            tbUserLV = new TextBox();
            tbPassword = new TextBox();
            tbEmail = new TextBox();
            tbPhone = new TextBox();
            tbAvatarID = new TextBox();
            tbUserName = new TextBox();
            tbUserID = new TextBox();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            userDataGridView = new DataGridView();
            tPPostMa = new TabPage();
            cbPostStatus = new ComboBox();
            cbBooked = new ComboBox();
            label32 = new Label();
            tbCreateDateForPost = new TextBox();
            tbUserIDForPost = new TextBox();
            label31 = new Label();
            label30 = new Label();
            tbPrdID = new TextBox();
            label29 = new Label();
            label28 = new Label();
            btnDeletePost = new Button();
            btnUpdatePost = new Button();
            btnNewPost = new Button();
            cbWardForPost = new ComboBox();
            cbDistrictForPost = new ComboBox();
            tbDetailAddress = new TextBox();
            tbArea = new TextBox();
            tbPrice = new TextBox();
            tbDetail = new TextBox();
            tbTitle = new TextBox();
            label12 = new Label();
            label13 = new Label();
            label14 = new Label();
            label15 = new Label();
            label16 = new Label();
            label17 = new Label();
            label18 = new Label();
            label19 = new Label();
            tbPostSearch = new TextBox();
            postDataGridView = new DataGridView();
            label11 = new Label();
            tPDistrictMa = new TabPage();
            groupBox1 = new GroupBox();
            tbNewDistrictName = new TextBox();
            label22 = new Label();
            btnAddDistrict = new Button();
            btnDeleteDistrict = new Button();
            btnUpdateDistrict = new Button();
            tbDistrictName = new TextBox();
            tbDistrictID = new TextBox();
            label21 = new Label();
            label20 = new Label();
            districtDataGridView = new DataGridView();
            tPWardMa = new TabPage();
            cbDistrictIDOWard = new ComboBox();
            btnUpdateWard = new Button();
            btnDeleteWard = new Button();
            groupBox2 = new GroupBox();
            btnAddWard = new Button();
            tbNewWardName = new TextBox();
            label27 = new Label();
            cbNewDistrictOWard = new ComboBox();
            label26 = new Label();
            tbWardName = new TextBox();
            tbWardID = new TextBox();
            label25 = new Label();
            label24 = new Label();
            label23 = new Label();
            ((System.ComponentModel.ISupportInitialize)wardDataGridView).BeginInit();
            tabControl1.SuspendLayout();
            tPUserMa.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)userDataGridView).BeginInit();
            tPPostMa.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)postDataGridView).BeginInit();
            tPDistrictMa.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)districtDataGridView).BeginInit();
            tPWardMa.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // wardDataGridView
            // 
            wardDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            wardDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            wardDataGridView.Location = new Point(3, 3);
            wardDataGridView.Name = "wardDataGridView";
            wardDataGridView.RowHeadersWidth = 51;
            wardDataGridView.RowTemplate.Height = 29;
            wardDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            wardDataGridView.Size = new Size(707, 390);
            wardDataGridView.TabIndex = 0;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tPUserMa);
            tabControl1.Controls.Add(tPPostMa);
            tabControl1.Controls.Add(tPDistrictMa);
            tabControl1.Controls.Add(tPWardMa);
            tabControl1.Location = new Point(12, 12);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(1096, 426);
            tabControl1.TabIndex = 0;
            tabControl1.SelectedIndexChanged += tabControl1_SelectedIndexChanged;
            // 
            // tPUserMa
            // 
            tPUserMa.AllowDrop = true;
            tPUserMa.Controls.Add(btnUserInsert);
            tPUserMa.Controls.Add(tbUserSearch);
            tPUserMa.Controls.Add(label10);
            tPUserMa.Controls.Add(label9);
            tPUserMa.Controls.Add(btnUserDelete);
            tPUserMa.Controls.Add(btnUserUpdate);
            tPUserMa.Controls.Add(tbCreatedDate);
            tPUserMa.Controls.Add(tbUserLV);
            tPUserMa.Controls.Add(tbPassword);
            tPUserMa.Controls.Add(tbEmail);
            tPUserMa.Controls.Add(tbPhone);
            tPUserMa.Controls.Add(tbAvatarID);
            tPUserMa.Controls.Add(tbUserName);
            tPUserMa.Controls.Add(tbUserID);
            tPUserMa.Controls.Add(label8);
            tPUserMa.Controls.Add(label7);
            tPUserMa.Controls.Add(label6);
            tPUserMa.Controls.Add(label5);
            tPUserMa.Controls.Add(label4);
            tPUserMa.Controls.Add(label3);
            tPUserMa.Controls.Add(label2);
            tPUserMa.Controls.Add(label1);
            tPUserMa.Controls.Add(userDataGridView);
            tPUserMa.Location = new Point(4, 29);
            tPUserMa.Name = "tPUserMa";
            tPUserMa.Padding = new Padding(3);
            tPUserMa.Size = new Size(1088, 393);
            tPUserMa.TabIndex = 0;
            tPUserMa.Text = "User Managament";
            tPUserMa.UseVisualStyleBackColor = true;
            // 
            // btnUserInsert
            // 
            btnUserInsert.Location = new Point(976, 67);
            btnUserInsert.Name = "btnUserInsert";
            btnUserInsert.Size = new Size(94, 29);
            btnUserInsert.TabIndex = 1;
            btnUserInsert.Text = "Insert";
            btnUserInsert.UseVisualStyleBackColor = true;
            btnUserInsert.Click += btnUserInsert_Click;
            // 
            // tbUserSearch
            // 
            tbUserSearch.Location = new Point(79, 14);
            tbUserSearch.Name = "tbUserSearch";
            tbUserSearch.Size = new Size(583, 27);
            tbUserSearch.TabIndex = 41;
            tbUserSearch.TextChanged += tbUserSearch_TextChanged;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(6, 17);
            label10.Name = "label10";
            label10.Size = new Size(53, 20);
            label10.TabIndex = 40;
            label10.Text = "Search";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point);
            label9.Location = new Point(811, 17);
            label9.Name = "label9";
            label9.Size = new Size(159, 37);
            label9.TabIndex = 39;
            label9.Text = "User Detail";
            // 
            // btnUserDelete
            // 
            btnUserDelete.Location = new Point(976, 201);
            btnUserDelete.Name = "btnUserDelete";
            btnUserDelete.Size = new Size(94, 29);
            btnUserDelete.TabIndex = 37;
            btnUserDelete.Text = "Delete";
            btnUserDelete.UseVisualStyleBackColor = true;
            btnUserDelete.Click += btnUserDelete_Click;
            // 
            // btnUserUpdate
            // 
            btnUserUpdate.Location = new Point(976, 133);
            btnUserUpdate.Name = "btnUserUpdate";
            btnUserUpdate.Size = new Size(94, 29);
            btnUserUpdate.TabIndex = 36;
            btnUserUpdate.Text = "Update";
            btnUserUpdate.UseVisualStyleBackColor = true;
            btnUserUpdate.Click += btnUserUpdate_Click;
            // 
            // tbCreatedDate
            // 
            tbCreatedDate.Enabled = false;
            tbCreatedDate.Location = new Point(811, 315);
            tbCreatedDate.Name = "tbCreatedDate";
            tbCreatedDate.ReadOnly = true;
            tbCreatedDate.Size = new Size(125, 27);
            tbCreatedDate.TabIndex = 35;
            // 
            // tbUserLV
            // 
            tbUserLV.Location = new Point(811, 277);
            tbUserLV.Name = "tbUserLV";
            tbUserLV.Size = new Size(125, 27);
            tbUserLV.TabIndex = 34;
            // 
            // tbPassword
            // 
            tbPassword.Location = new Point(811, 236);
            tbPassword.Name = "tbPassword";
            tbPassword.Size = new Size(125, 27);
            tbPassword.TabIndex = 33;
            // 
            // tbEmail
            // 
            tbEmail.Location = new Point(811, 203);
            tbEmail.Name = "tbEmail";
            tbEmail.Size = new Size(125, 27);
            tbEmail.TabIndex = 32;
            // 
            // tbPhone
            // 
            tbPhone.Location = new Point(811, 171);
            tbPhone.Name = "tbPhone";
            tbPhone.Size = new Size(125, 27);
            tbPhone.TabIndex = 31;
            // 
            // tbAvatarID
            // 
            tbAvatarID.Enabled = false;
            tbAvatarID.Location = new Point(811, 138);
            tbAvatarID.Name = "tbAvatarID";
            tbAvatarID.ReadOnly = true;
            tbAvatarID.Size = new Size(125, 27);
            tbAvatarID.TabIndex = 30;
            // 
            // tbUserName
            // 
            tbUserName.Location = new Point(811, 102);
            tbUserName.Name = "tbUserName";
            tbUserName.Size = new Size(125, 27);
            tbUserName.TabIndex = 29;
            // 
            // tbUserID
            // 
            tbUserID.Enabled = false;
            tbUserID.Location = new Point(811, 69);
            tbUserID.Name = "tbUserID";
            tbUserID.ReadOnly = true;
            tbUserID.Size = new Size(125, 27);
            tbUserID.TabIndex = 28;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(693, 318);
            label8.Name = "label8";
            label8.Size = new Size(97, 20);
            label8.TabIndex = 27;
            label8.Text = "Created Date";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(714, 277);
            label7.Name = "label7";
            label7.Size = new Size(76, 20);
            label7.TabIndex = 26;
            label7.Text = "User Level";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(719, 142);
            label6.Name = "label6";
            label6.Size = new Size(71, 20);
            label6.TabIndex = 25;
            label6.Text = "Avatar ID";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(744, 206);
            label5.Name = "label5";
            label5.Size = new Size(46, 20);
            label5.TabIndex = 24;
            label5.Text = "Email";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(740, 174);
            label4.Name = "label4";
            label4.Size = new Size(50, 20);
            label4.TabIndex = 23;
            label4.Text = "Phone";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(720, 243);
            label3.Name = "label3";
            label3.Size = new Size(70, 20);
            label3.TabIndex = 22;
            label3.Text = "Password";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(708, 106);
            label2.Name = "label2";
            label2.Size = new Size(82, 20);
            label2.TabIndex = 21;
            label2.Text = "User Name";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(733, 76);
            label1.Name = "label1";
            label1.Size = new Size(57, 20);
            label1.TabIndex = 20;
            label1.Text = "User ID";
            // 
            // userDataGridView
            // 
            userDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            userDataGridView.Location = new Point(6, 69);
            userDataGridView.Name = "userDataGridView";
            userDataGridView.ReadOnly = true;
            userDataGridView.RowHeadersWidth = 51;
            userDataGridView.RowTemplate.Height = 29;
            userDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            userDataGridView.Size = new Size(665, 318);
            userDataGridView.TabIndex = 0;
            // 
            // tPPostMa
            // 
            tPPostMa.Controls.Add(cbPostStatus);
            tPPostMa.Controls.Add(cbBooked);
            tPPostMa.Controls.Add(label32);
            tPPostMa.Controls.Add(tbCreateDateForPost);
            tPPostMa.Controls.Add(tbUserIDForPost);
            tPPostMa.Controls.Add(label31);
            tPPostMa.Controls.Add(label30);
            tPPostMa.Controls.Add(tbPrdID);
            tPPostMa.Controls.Add(label29);
            tPPostMa.Controls.Add(label28);
            tPPostMa.Controls.Add(btnDeletePost);
            tPPostMa.Controls.Add(btnUpdatePost);
            tPPostMa.Controls.Add(btnNewPost);
            tPPostMa.Controls.Add(cbWardForPost);
            tPPostMa.Controls.Add(cbDistrictForPost);
            tPPostMa.Controls.Add(tbDetailAddress);
            tPPostMa.Controls.Add(tbArea);
            tPPostMa.Controls.Add(tbPrice);
            tPPostMa.Controls.Add(tbDetail);
            tPPostMa.Controls.Add(tbTitle);
            tPPostMa.Controls.Add(label12);
            tPPostMa.Controls.Add(label13);
            tPPostMa.Controls.Add(label14);
            tPPostMa.Controls.Add(label15);
            tPPostMa.Controls.Add(label16);
            tPPostMa.Controls.Add(label17);
            tPPostMa.Controls.Add(label18);
            tPPostMa.Controls.Add(label19);
            tPPostMa.Controls.Add(tbPostSearch);
            tPPostMa.Controls.Add(postDataGridView);
            tPPostMa.Controls.Add(label11);
            tPPostMa.Location = new Point(4, 29);
            tPPostMa.Name = "tPPostMa";
            tPPostMa.Padding = new Padding(3);
            tPPostMa.Size = new Size(1088, 393);
            tPPostMa.TabIndex = 1;
            tPPostMa.Text = "Post Managament";
            tPPostMa.UseVisualStyleBackColor = true;
            // 
            // cbPostStatus
            // 
            cbPostStatus.FormattingEnabled = true;
            cbPostStatus.Location = new Point(856, 178);
            cbPostStatus.Name = "cbPostStatus";
            cbPostStatus.Size = new Size(213, 28);
            cbPostStatus.TabIndex = 49;
            // 
            // cbBooked
            // 
            cbBooked.FormattingEnabled = true;
            cbBooked.Location = new Point(994, 281);
            cbBooked.Name = "cbBooked";
            cbBooked.Size = new Size(75, 28);
            cbBooked.TabIndex = 48;
            // 
            // label32
            // 
            label32.AutoSize = true;
            label32.Location = new Point(806, 321);
            label32.Name = "label32";
            label32.Size = new Size(41, 20);
            label32.TabIndex = 47;
            label32.Text = "Date";
            // 
            // tbCreateDateForPost
            // 
            tbCreateDateForPost.Enabled = false;
            tbCreateDateForPost.Location = new Point(856, 318);
            tbCreateDateForPost.Name = "tbCreateDateForPost";
            tbCreateDateForPost.ReadOnly = true;
            tbCreateDateForPost.Size = new Size(213, 27);
            tbCreateDateForPost.TabIndex = 46;
            // 
            // tbUserIDForPost
            // 
            tbUserIDForPost.Enabled = false;
            tbUserIDForPost.Location = new Point(856, 281);
            tbUserIDForPost.Name = "tbUserIDForPost";
            tbUserIDForPost.ReadOnly = true;
            tbUserIDForPost.Size = new Size(75, 27);
            tbUserIDForPost.TabIndex = 44;
            // 
            // label31
            // 
            label31.AutoSize = true;
            label31.Location = new Point(937, 284);
            label31.Name = "label31";
            label31.Size = new Size(60, 20);
            label31.TabIndex = 43;
            label31.Text = "Booked";
            // 
            // label30
            // 
            label30.AutoSize = true;
            label30.Location = new Point(794, 284);
            label30.Name = "label30";
            label30.Size = new Size(53, 20);
            label30.TabIndex = 42;
            label30.Text = "UserID";
            // 
            // tbPrdID
            // 
            tbPrdID.Enabled = false;
            tbPrdID.Location = new Point(856, 48);
            tbPrdID.Name = "tbPrdID";
            tbPrdID.ReadOnly = true;
            tbPrdID.Size = new Size(213, 27);
            tbPrdID.TabIndex = 41;
            // 
            // label29
            // 
            label29.AutoSize = true;
            label29.Location = new Point(801, 55);
            label29.Name = "label29";
            label29.Size = new Size(46, 20);
            label29.TabIndex = 40;
            label29.Text = "PrdID";
            // 
            // label28
            // 
            label28.AutoSize = true;
            label28.Font = new Font("Segoe UI", 13F, FontStyle.Bold, GraphicsUnit.Point);
            label28.Location = new Point(874, 14);
            label28.Name = "label28";
            label28.Size = new Size(152, 30);
            label28.TabIndex = 39;
            label28.Text = "Selected Post";
            // 
            // btnDeletePost
            // 
            btnDeletePost.Location = new Point(982, 358);
            btnDeletePost.Name = "btnDeletePost";
            btnDeletePost.Size = new Size(87, 29);
            btnDeletePost.TabIndex = 37;
            btnDeletePost.Text = "Delete";
            btnDeletePost.UseVisualStyleBackColor = true;
            btnDeletePost.Click += btnDeletePost_Click;
            // 
            // btnUpdatePost
            // 
            btnUpdatePost.Location = new Point(889, 358);
            btnUpdatePost.Name = "btnUpdatePost";
            btnUpdatePost.Size = new Size(82, 29);
            btnUpdatePost.TabIndex = 36;
            btnUpdatePost.Text = "Update";
            btnUpdatePost.UseVisualStyleBackColor = true;
            btnUpdatePost.Click += btnUpdatePost_Click;
            // 
            // btnNewPost
            // 
            btnNewPost.Location = new Point(791, 358);
            btnNewPost.Name = "btnNewPost";
            btnNewPost.Size = new Size(85, 29);
            btnNewPost.TabIndex = 35;
            btnNewPost.Text = "New";
            btnNewPost.UseVisualStyleBackColor = true;
            btnNewPost.Click += btnNewPost_Click;
            // 
            // cbWardForPost
            // 
            cbWardForPost.FormattingEnabled = true;
            cbWardForPost.Location = new Point(994, 245);
            cbWardForPost.Name = "cbWardForPost";
            cbWardForPost.Size = new Size(75, 28);
            cbWardForPost.TabIndex = 34;
            // 
            // cbDistrictForPost
            // 
            cbDistrictForPost.FormattingEnabled = true;
            cbDistrictForPost.Location = new Point(856, 245);
            cbDistrictForPost.Name = "cbDistrictForPost";
            cbDistrictForPost.Size = new Size(75, 28);
            cbDistrictForPost.TabIndex = 33;
            // 
            // tbDetailAddress
            // 
            tbDetailAddress.Location = new Point(856, 212);
            tbDetailAddress.Name = "tbDetailAddress";
            tbDetailAddress.Size = new Size(213, 27);
            tbDetailAddress.TabIndex = 31;
            // 
            // tbArea
            // 
            tbArea.Location = new Point(994, 143);
            tbArea.Name = "tbArea";
            tbArea.Size = new Size(75, 27);
            tbArea.TabIndex = 30;
            // 
            // tbPrice
            // 
            tbPrice.Location = new Point(856, 143);
            tbPrice.Name = "tbPrice";
            tbPrice.Size = new Size(75, 27);
            tbPrice.TabIndex = 29;
            // 
            // tbDetail
            // 
            tbDetail.Location = new Point(856, 110);
            tbDetail.Name = "tbDetail";
            tbDetail.Size = new Size(213, 27);
            tbDetail.TabIndex = 28;
            // 
            // tbTitle
            // 
            tbTitle.Location = new Point(856, 78);
            tbTitle.Name = "tbTitle";
            tbTitle.Size = new Size(213, 27);
            tbTitle.TabIndex = 27;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(944, 248);
            label12.Name = "label12";
            label12.Size = new Size(44, 20);
            label12.TabIndex = 26;
            label12.Text = "Ward";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(791, 248);
            label13.Name = "label13";
            label13.Size = new Size(56, 20);
            label13.TabIndex = 25;
            label13.Text = "District";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(788, 215);
            label14.Name = "label14";
            label14.Size = new Size(62, 20);
            label14.TabIndex = 24;
            label14.Text = "Address";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(944, 146);
            label15.Name = "label15";
            label15.Size = new Size(40, 20);
            label15.TabIndex = 23;
            label15.Text = "Area";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Location = new Point(801, 186);
            label16.Name = "label16";
            label16.Size = new Size(49, 20);
            label16.TabIndex = 22;
            label16.Text = "Status";
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Location = new Point(806, 151);
            label17.Name = "label17";
            label17.Size = new Size(41, 20);
            label17.TabIndex = 21;
            label17.Text = "Price";
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Location = new Point(801, 118);
            label18.Name = "label18";
            label18.Size = new Size(49, 20);
            label18.TabIndex = 20;
            label18.Text = "Detail";
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Location = new Point(812, 84);
            label19.Name = "label19";
            label19.Size = new Size(38, 20);
            label19.TabIndex = 19;
            label19.Text = "Title";
            // 
            // tbPostSearch
            // 
            tbPostSearch.Location = new Point(92, 11);
            tbPostSearch.Name = "tbPostSearch";
            tbPostSearch.Size = new Size(690, 27);
            tbPostSearch.TabIndex = 2;
            // 
            // postDataGridView
            // 
            postDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            postDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            postDataGridView.Location = new Point(15, 46);
            postDataGridView.Name = "postDataGridView";
            postDataGridView.RowHeadersWidth = 51;
            postDataGridView.RowTemplate.Height = 29;
            postDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            postDataGridView.Size = new Size(767, 341);
            postDataGridView.TabIndex = 1;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(15, 14);
            label11.Name = "label11";
            label11.Size = new Size(53, 20);
            label11.TabIndex = 0;
            label11.Text = "Search";
            // 
            // tPDistrictMa
            // 
            tPDistrictMa.Controls.Add(groupBox1);
            tPDistrictMa.Controls.Add(btnDeleteDistrict);
            tPDistrictMa.Controls.Add(btnUpdateDistrict);
            tPDistrictMa.Controls.Add(tbDistrictName);
            tPDistrictMa.Controls.Add(tbDistrictID);
            tPDistrictMa.Controls.Add(label21);
            tPDistrictMa.Controls.Add(label20);
            tPDistrictMa.Controls.Add(districtDataGridView);
            tPDistrictMa.Location = new Point(4, 29);
            tPDistrictMa.Name = "tPDistrictMa";
            tPDistrictMa.Size = new Size(1088, 393);
            tPDistrictMa.TabIndex = 2;
            tPDistrictMa.Text = "District Managament";
            tPDistrictMa.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(tbNewDistrictName);
            groupBox1.Controls.Add(label22);
            groupBox1.Controls.Add(btnAddDistrict);
            groupBox1.Location = new Point(714, 212);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(358, 136);
            groupBox1.TabIndex = 8;
            groupBox1.TabStop = false;
            groupBox1.Text = "Add New District";
            // 
            // tbNewDistrictName
            // 
            tbNewDistrictName.Location = new Point(127, 44);
            tbNewDistrictName.Name = "tbNewDistrictName";
            tbNewDistrictName.Size = new Size(214, 27);
            tbNewDistrictName.TabIndex = 11;
            // 
            // label22
            // 
            label22.AutoSize = true;
            label22.Location = new Point(11, 44);
            label22.Name = "label22";
            label22.Size = new Size(100, 20);
            label22.TabIndex = 9;
            label22.Text = "District Name";
            // 
            // btnAddDistrict
            // 
            btnAddDistrict.Location = new Point(247, 98);
            btnAddDistrict.Name = "btnAddDistrict";
            btnAddDistrict.Size = new Size(94, 29);
            btnAddDistrict.TabIndex = 7;
            btnAddDistrict.Text = "Add";
            btnAddDistrict.UseVisualStyleBackColor = true;
            btnAddDistrict.Click += btnNewDistrict_Click;
            // 
            // btnDeleteDistrict
            // 
            btnDeleteDistrict.Location = new Point(916, 107);
            btnDeleteDistrict.Name = "btnDeleteDistrict";
            btnDeleteDistrict.Size = new Size(94, 29);
            btnDeleteDistrict.TabIndex = 6;
            btnDeleteDistrict.Text = "Delete";
            btnDeleteDistrict.UseVisualStyleBackColor = true;
            btnDeleteDistrict.Click += btnDeleteDistrict_Click;
            // 
            // btnUpdateDistrict
            // 
            btnUpdateDistrict.Location = new Point(772, 107);
            btnUpdateDistrict.Name = "btnUpdateDistrict";
            btnUpdateDistrict.Size = new Size(94, 29);
            btnUpdateDistrict.TabIndex = 5;
            btnUpdateDistrict.Text = "Update";
            btnUpdateDistrict.UseVisualStyleBackColor = true;
            btnUpdateDistrict.Click += btnUpdateDistrict_Click;
            // 
            // tbDistrictName
            // 
            tbDistrictName.Location = new Point(840, 57);
            tbDistrictName.Name = "tbDistrictName";
            tbDistrictName.Size = new Size(214, 27);
            tbDistrictName.TabIndex = 4;
            // 
            // tbDistrictID
            // 
            tbDistrictID.Enabled = false;
            tbDistrictID.Location = new Point(840, 18);
            tbDistrictID.Name = "tbDistrictID";
            tbDistrictID.ReadOnly = true;
            tbDistrictID.Size = new Size(214, 27);
            tbDistrictID.TabIndex = 3;
            // 
            // label21
            // 
            label21.AutoSize = true;
            label21.Location = new Point(724, 64);
            label21.Name = "label21";
            label21.Size = new Size(100, 20);
            label21.TabIndex = 2;
            label21.Text = "District Name";
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.Location = new Point(749, 25);
            label20.Name = "label20";
            label20.Size = new Size(75, 20);
            label20.TabIndex = 1;
            label20.Text = "District ID";
            // 
            // districtDataGridView
            // 
            districtDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            districtDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            districtDataGridView.Location = new Point(3, 3);
            districtDataGridView.Name = "districtDataGridView";
            districtDataGridView.RowHeadersWidth = 51;
            districtDataGridView.RowTemplate.Height = 29;
            districtDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            districtDataGridView.Size = new Size(693, 387);
            districtDataGridView.TabIndex = 0;
            // 
            // tPWardMa
            // 
            tPWardMa.Controls.Add(cbDistrictIDOWard);
            tPWardMa.Controls.Add(btnUpdateWard);
            tPWardMa.Controls.Add(btnDeleteWard);
            tPWardMa.Controls.Add(groupBox2);
            tPWardMa.Controls.Add(tbWardName);
            tPWardMa.Controls.Add(tbWardID);
            tPWardMa.Controls.Add(label25);
            tPWardMa.Controls.Add(label24);
            tPWardMa.Controls.Add(label23);
            tPWardMa.Controls.Add(wardDataGridView);
            tPWardMa.Location = new Point(4, 29);
            tPWardMa.Name = "tPWardMa";
            tPWardMa.Size = new Size(1088, 393);
            tPWardMa.TabIndex = 3;
            tPWardMa.Text = "Ward Managament";
            tPWardMa.UseVisualStyleBackColor = true;
            // 
            // cbDistrictIDOWard
            // 
            cbDistrictIDOWard.FormattingEnabled = true;
            cbDistrictIDOWard.Location = new Point(891, 112);
            cbDistrictIDOWard.Name = "cbDistrictIDOWard";
            cbDistrictIDOWard.Size = new Size(168, 28);
            cbDistrictIDOWard.TabIndex = 10;
            // 
            // btnUpdateWard
            // 
            btnUpdateWard.Location = new Point(791, 165);
            btnUpdateWard.Name = "btnUpdateWard";
            btnUpdateWard.Size = new Size(94, 29);
            btnUpdateWard.TabIndex = 9;
            btnUpdateWard.Text = "Update";
            btnUpdateWard.UseVisualStyleBackColor = true;
            btnUpdateWard.Click += btnUpdateWard_Click;
            // 
            // btnDeleteWard
            // 
            btnDeleteWard.Location = new Point(918, 165);
            btnDeleteWard.Name = "btnDeleteWard";
            btnDeleteWard.Size = new Size(94, 29);
            btnDeleteWard.TabIndex = 8;
            btnDeleteWard.Text = "Delete";
            btnDeleteWard.UseVisualStyleBackColor = true;
            btnDeleteWard.Click += btnDeleteWard_Click;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(btnAddWard);
            groupBox2.Controls.Add(tbNewWardName);
            groupBox2.Controls.Add(label27);
            groupBox2.Controls.Add(cbNewDistrictOWard);
            groupBox2.Controls.Add(label26);
            groupBox2.Location = new Point(721, 222);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(364, 168);
            groupBox2.TabIndex = 7;
            groupBox2.TabStop = false;
            groupBox2.Text = "Add New Ward";
            // 
            // btnAddWard
            // 
            btnAddWard.Location = new Point(244, 124);
            btnAddWard.Name = "btnAddWard";
            btnAddWard.Size = new Size(94, 29);
            btnAddWard.TabIndex = 4;
            btnAddWard.Text = "Add";
            btnAddWard.UseVisualStyleBackColor = true;
            btnAddWard.Click += btnAddWard_Click;
            // 
            // tbNewWardName
            // 
            tbNewWardName.Location = new Point(158, 31);
            tbNewWardName.Name = "tbNewWardName";
            tbNewWardName.Size = new Size(180, 27);
            tbNewWardName.TabIndex = 3;
            // 
            // label27
            // 
            label27.AutoSize = true;
            label27.Location = new Point(18, 86);
            label27.Name = "label27";
            label27.Size = new Size(125, 20);
            label27.TabIndex = 2;
            label27.Text = "Belong to District";
            // 
            // cbNewDistrictOWard
            // 
            cbNewDistrictOWard.FormattingEnabled = true;
            cbNewDistrictOWard.Location = new Point(158, 78);
            cbNewDistrictOWard.Name = "cbNewDistrictOWard";
            cbNewDistrictOWard.Size = new Size(180, 28);
            cbNewDistrictOWard.TabIndex = 1;
            // 
            // label26
            // 
            label26.AutoSize = true;
            label26.Location = new Point(45, 38);
            label26.Name = "label26";
            label26.Size = new Size(88, 20);
            label26.TabIndex = 0;
            label26.Text = "Ward Name";
            // 
            // tbWardName
            // 
            tbWardName.Location = new Point(890, 68);
            tbWardName.Name = "tbWardName";
            tbWardName.Size = new Size(169, 27);
            tbWardName.TabIndex = 5;
            // 
            // tbWardID
            // 
            tbWardID.Enabled = false;
            tbWardID.Location = new Point(890, 30);
            tbWardID.Name = "tbWardID";
            tbWardID.ReadOnly = true;
            tbWardID.Size = new Size(169, 27);
            tbWardID.TabIndex = 4;
            // 
            // label25
            // 
            label25.AutoSize = true;
            label25.Location = new Point(721, 110);
            label25.Name = "label25";
            label25.Size = new Size(144, 20);
            label25.TabIndex = 3;
            label25.Text = "District ID Belong to";
            // 
            // label24
            // 
            label24.AutoSize = true;
            label24.Location = new Point(777, 68);
            label24.Name = "label24";
            label24.Size = new Size(88, 20);
            label24.TabIndex = 2;
            label24.Text = "Ward Name";
            // 
            // label23
            // 
            label23.AutoSize = true;
            label23.Location = new Point(802, 33);
            label23.Name = "label23";
            label23.Size = new Size(63, 20);
            label23.TabIndex = 1;
            label23.Text = "Ward ID";
            // 
            // AdminForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1118, 450);
            Controls.Add(tabControl1);
            Name = "AdminForm";
            Text = "AdminForm";
            FormClosed += AdminForm_FormClosed;
            Load += AdminForm_Load;
            ((System.ComponentModel.ISupportInitialize)wardDataGridView).EndInit();
            tabControl1.ResumeLayout(false);
            tPUserMa.ResumeLayout(false);
            tPUserMa.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)userDataGridView).EndInit();
            tPPostMa.ResumeLayout(false);
            tPPostMa.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)postDataGridView).EndInit();
            tPDistrictMa.ResumeLayout(false);
            tPDistrictMa.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)districtDataGridView).EndInit();
            tPWardMa.ResumeLayout(false);
            tPWardMa.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tPUserMa;
        private TabPage tPPostMa;
        private TabPage tPDistrictMa;
        private TabPage tPWardMa;
        private DataGridView userDataGridView;
        private Label label9;
        private Button btnExit;
        private Button btnUserDelete;
        private Button btnUserUpdate;
        private TextBox tbCreatedDate;
        private TextBox tbUserLV;
        private TextBox tbPassword;
        private TextBox tbEmail;
        private TextBox tbPhone;
        private TextBox tbAvatarID;
        private TextBox tbUserName;
        private TextBox tbUserID;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox tbUserSearch;
        private Label label10;
        private Button btnUserInsert;
        private TextBox tbPostSearch;
        private DataGridView postDataGridView;
        private Label label11;
        private Button btnDeletePost;
        private Button btnUpdatePost;
        private Button btnNewPost;
        private ComboBox cbWardForPost;
        private ComboBox cbDistrictForPost;
        private TextBox tbDetailAddress;
        private TextBox tbArea;
        private TextBox tbPrice;
        private TextBox tbDetail;
        private TextBox tbTitle;
        private Label label12;
        private Label label13;
        private Label label14;
        private Label label15;
        private Label label16;
        private Label label17;
        private Label label18;
        private Label label19;
        private DataGridView districtDataGridView;
        private Label label21;
        private Label label20;
        private Button btnDeleteDistrict;
        private Button btnUpdateDistrict;
        private TextBox tbDistrictName;
        private TextBox tbDistrictID;
        private Button btnAddDistrict;
        private GroupBox groupBox1;
        private TextBox tbNewDistrictName;
        private Label label22;
        private DataGridView wardDataGridView;
        private GroupBox groupBox2;
        private TextBox tbNewWardName;
        private Label label27;
        private ComboBox cbNewDistrictOWard;
        private Label label26;
        private TextBox tbWardName;
        private TextBox tbWardID;
        private Label label25;
        private Label label24;
        private Label label23;
        private Button btnUpdateWard;
        private Button btnDeleteWard;
        private Button btnAddWard;
        private ComboBox cbDistrictIDOWard;
        private Label label28;
        private TextBox tbPrdID;
        private Label label29;
        private ComboBox cbBooked;
        private Label label32;
        private TextBox tbCreateDateForPost;
        private TextBox tbUserIDForPost;
        private Label label31;
        private Label label30;
        private ComboBox cbPostStatus;
    }
}