using DN2ndHomeLibrary.DataAccess;
using DN2ndHomeLibrary.Repository;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlTypes;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DN2ndHomeWinFormsApp
{
    public partial class AdminForm : Form
    {
        private User _CurrentUser;
        private IUserRepository _userRepository;
        private IPostRepository _postRepository;
        private IDistrictRepository _districtRepository;
        private IWardRepository _wardRepository;
        private IImageRepository _imageRepository;
        BindingSource userBindingSource, 
            postBindingSource, 
            districtBindingSource, 
            wardBindingSource, 
            cboNewDistrictBindingSource, 
            cboDistrictBindingSource,
            DistrictForPostBindingSource,
            WardForPostBindingSource;
        public AdminForm(IUserRepository userRepository,
            IPostRepository postRepository,
            User CurrentUser,
            IDistrictRepository districtRepository,
            IWardRepository wardRepository,
            IImageRepository imageRepository)
        {
            InitializeComponent();
            _CurrentUser = CurrentUser;
            _userRepository = userRepository;
            _postRepository = postRepository;
            _districtRepository = districtRepository;
            _wardRepository = wardRepository;
            _imageRepository = imageRepository;
        }
        private void AdminForm_Load(object sender, EventArgs e)
        {
            var users = _userRepository.GetUsers();
            LoadUserList(users);
        }
        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControl1.SelectedTab == tPUserMa)
            {
                var users = _userRepository.GetUsers();
                LoadUserList(users);
            }
            else if (tabControl1.SelectedTab == tPPostMa)
            {
                LoadPosts();
            }
            else if (tabControl1.SelectedTab == tPDistrictMa)
            {
                LoadDistricts();
            }
            else if (tabControl1.SelectedTab == tPWardMa)
            {
                LoadWard();
                LoadDistrictComboBox();
            }
        }
        private void AdminForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            DialogResult = DialogResult.OK;
        }
        //Start of UserManagement tab
        private void LoadUserList(IEnumerable<User> users)
        {
            try
            {
                userBindingSource = new BindingSource();
                userBindingSource.DataSource = users;

                tbUserID.DataBindings.Clear();
                tbUserName.DataBindings.Clear();
                tbAvatarID.DataBindings.Clear();
                tbPhone.DataBindings.Clear();
                tbEmail.DataBindings.Clear();
                tbPassword.DataBindings.Clear();
                tbUserLV.DataBindings.Clear();
                tbCreatedDate.DataBindings.Clear();

                tbUserID.DataBindings.Add("Text", userBindingSource, "UserID");
                tbUserName.DataBindings.Add("Text", userBindingSource, "UserName");
                tbAvatarID.DataBindings.Add("Text", userBindingSource, "AvatarID");
                tbPhone.DataBindings.Add("Text", userBindingSource, "Phone");
                tbEmail.DataBindings.Add("Text", userBindingSource, "Email");
                tbPassword.DataBindings.Add("Text", userBindingSource, "Password");
                tbUserLV.DataBindings.Add("Text", userBindingSource, "UserLevel");
                tbCreatedDate.DataBindings.Add("Text", userBindingSource, "CreateAt");

                userDataGridView.DataSource = userBindingSource;

                userDataGridView.SelectionChanged += (sender, e) =>
                {
                    if (userDataGridView.CurrentRow != null)
                        userBindingSource.Position = userDataGridView.CurrentRow.Index;
                };
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}\nStackTrace: {ex.StackTrace}", "Error Loading User List");
            }
        } //done
        private User GetSelectedUser()
        {
            User user = new User
            {
                UserId = int.Parse(tbUserID.Text),
                UserName = tbUserName.Text,
                AvatarId = int.Parse(tbAvatarID.Text),
                Phone = tbPhone.Text,
                Email = tbEmail.Text,
                Password = tbPassword.Text,
                UserLevel = int.Parse(tbUserLV.Text),
                CreateAt = DateTime.Parse(tbCreatedDate.Text)
            };
            return user;
        }  //done
        private void btnUserUpdate_Click(object sender, EventArgs e)
        {
            User user = GetSelectedUser();
            try
            {
                _userRepository.Update(user);
                MessageBox.Show("Update Success");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        } //done
        private void btnUserDelete_Click(object sender, EventArgs e)
        {
            User user = GetSelectedUser();
            try
            {
                _userRepository.Remove(user);
                MessageBox.Show("Delete Success");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        } //done
        private void tbUserSearch_TextChanged(object sender, EventArgs e)
        {
            var users = _userRepository.GetUsersByName(tbUserSearch.Text);
            LoadUserList(users);
        } //done
        private void btnUserInsert_Click(object sender, EventArgs e)
        {

        } //not done
        //End of UserManagement tab


        //Start of PostManagement tab
        private void LoadPosts()
        {
            var prdInfos = _postRepository.GetPrdInfos();
            postBindingSource = new BindingSource();
            postBindingSource.DataSource = prdInfos;

            tbPrdID.DataBindings.Clear();
            tbTitle.DataBindings.Clear();
            tbDetail.DataBindings.Clear();
            tbPrice.DataBindings.Clear();
            tbArea.DataBindings.Clear();
            cbPostStatus.DataBindings.Clear();
            tbDetailAddress.DataBindings.Clear();
            tbUserIDForPost.DataBindings.Clear();
            cbBooked.DataBindings.Clear();
            tbCreateDateForPost.DataBindings.Clear();

            tbPrdID.DataBindings.Add("Text", postBindingSource, "PrdID");
            tbTitle.DataBindings.Add("Text", postBindingSource, "PrdTitle");
            tbDetail.DataBindings.Add("Text", postBindingSource, "PrdDetail");
            tbPrice.DataBindings.Add("Text", postBindingSource, "Price");
            tbArea.DataBindings.Add("Text", postBindingSource, "Area");

            cbPostStatus.DataSource = new List<object>
            {
                new { Text = "Chưa duyệt", Value = 1 },
                new { Text = "Duyệt", Value = 2 }
            };

            cbPostStatus.DisplayMember = "Text";
            cbPostStatus.ValueMember = "Value";
            cbPostStatus.DataBindings.Add("SelectedValue", postBindingSource, "PrdStatus");

            tbDetailAddress.DataBindings.Add("Text", postBindingSource, "DetailAddress");
            LoadDistrictForPostComboBox();
            LoadWardForPostComboBox();
            tbUserIDForPost.DataBindings.Add("Text", postBindingSource, "UserID");
            
            cbBooked.DataSource = new List<object>
            {
                new { Text = "Trống", Value = 1 },
                new { Text = "Đầy", Value = 2 }
            };

            cbBooked.DisplayMember = "Text";
            cbBooked.ValueMember = "Value";
            cbBooked.DataBindings.Add("SelectedValue", postBindingSource, "Booked");
            tbCreateDateForPost.DataBindings.Add("Text", postBindingSource, "CreateDay");

            postDataGridView.DataSource = postBindingSource;

            postDataGridView.SelectionChanged += (sender, e) =>
            {
                if (postDataGridView.CurrentRow != null)
                    postBindingSource.Position = postDataGridView.CurrentRow.Index;
            };
        }
        private void btnNewPost_Click(object sender, EventArgs e)
        {
            PostForm postForm = new PostForm(_CurrentUser, _postRepository, _districtRepository, _wardRepository, _imageRepository);
            Hide();
            if (postForm.ShowDialog() == DialogResult.OK)
            {
                Show();
                LoadPosts();
            }
        }//done
        private void btnUpdatePost_Click(object sender, EventArgs e)
        {

        }//not done
        private void btnDeletePost_Click(object sender, EventArgs e)
        {
            try
            {
                PrdInfo prdInfo = GetSelectedPost();
                _postRepository.Remove(prdInfo);
                _imageRepository.RemoveImagesByPrdID(prdInfo.PrdId);
                LoadPosts();
            }catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }//done
        private void LoadDistrictForPostComboBox()
        {
            try
            {
                var districts = _districtRepository.GetDistricts();

                DistrictForPostBindingSource = new BindingSource();
                DistrictForPostBindingSource.DataSource = districts;
                cbDistrictForPost.DataBindings.Clear();
                cbDistrictForPost.DisplayMember = "districtname";
                cbDistrictForPost.ValueMember = "districtid";
                cbDistrictForPost.DataSource = DistrictForPostBindingSource;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }//done
        private void LoadWardForPostComboBox()
        {
            WardForPostBindingSource = new BindingSource();
            var wards = _wardRepository.GetWards();
            WardForPostBindingSource.DataSource = wards;
            cbWardForPost.DataBindings.Clear();

            cbWardForPost.DisplayMember = "WardName";
            cbWardForPost.ValueMember = "WardID";
            cbWardForPost.DataSource = WardForPostBindingSource;

            cbDistrictForPost.SelectedIndexChanged += (sender, e) =>
            {
                var selectedDistrict = (District)cbDistrictForPost.SelectedItem;
                var filteredWards = _wardRepository.GetWardsForDistrict(selectedDistrict.DistrictId);
                WardForPostBindingSource.DataSource = filteredWards;
            };
        }//done
        private PrdInfo GetSelectedPost()
        {
            PrdInfo prdInfo = new PrdInfo
            {
                Area = int.Parse(tbArea.Text),
                Booked = int.Parse(cbBooked.Text),
                CreateDay = DateTime.Parse(tbCreateDateForPost.Text),
                DetailAddress = tbDetailAddress.Text,
                DistrictId = int.Parse(cbDistrictForPost.SelectedValue.ToString()),
                PrdDetail = tbDetail.Text,
                PrdId = int.Parse(tbPrdID.Text),
                PrdStatus = int.Parse(cbPostStatus.Text),
                PrdTitle = tbTitle.Text,
                Price = decimal.Parse(tbPrice.Text),
                UserId = int.Parse(tbUserIDForPost.Text),
                WardId = int.Parse(cbWardForPost.SelectedValue.ToString()),
            };
            return prdInfo;
        }//not done
        //End of PostManagement tab


        //District Management tab
        private void LoadDistricts()
        {
            var districts = _districtRepository.GetDistricts();
            districtBindingSource = new BindingSource();
            districtBindingSource.DataSource = districts;

            tbDistrictID.DataBindings.Clear();
            tbDistrictName.DataBindings.Clear();

            tbDistrictID.DataBindings.Add("Text", districtBindingSource, "districtid");
            tbDistrictName.DataBindings.Add("Text", districtBindingSource, "districtname");

            districtDataGridView.DataSource = districtBindingSource;

            districtDataGridView.SelectionChanged += (sender, e) =>
            {
                if (districtDataGridView.CurrentRow != null)
                    districtBindingSource.Position = districtDataGridView.CurrentRow.Index;
            };
        }//done
        private void btnNewDistrict_Click(object sender, EventArgs e)
        {
            if (tbDistrictName.Text == string.Empty) return;
            try
            {
                District district = new District
                {
                    DistrictName = tbNewDistrictName.Text,
                };
                _districtRepository.AddNewDistrict(district);
                LoadDistricts();
                tbNewDistrictName.Text = string.Empty;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }//done
        private void btnDeleteDistrict_Click(object sender, EventArgs e)
        {
            try
            {
                District district = new District
                {
                    DistrictId = int.Parse(tbDistrictID.Text),
                    DistrictName = tbDistrictName.Text,
                };
                _districtRepository.Remove(district);
                LoadDistricts();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }//done
        private void btnUpdateDistrict_Click(object sender, EventArgs e)
        {
            try
            {
                District district = new District
                {
                    DistrictId = int.Parse(tbDistrictID.Text),
                    DistrictName = tbDistrictName.Text,
                };
                _districtRepository.Update(district);
                LoadDistricts();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }//done
        //End of district management tab


        //Start of WardManagement tab
        private void LoadWard()
        {
            var wards = _wardRepository.GetWards();
            var districts = _districtRepository.GetDistricts();
            wardBindingSource = new BindingSource();
            wardBindingSource.DataSource = wards;

            tbWardID.DataBindings.Clear();
            tbWardName.DataBindings.Clear();
            cbDistrictIDOWard.DataBindings.Clear();


            tbWardID.DataBindings.Add("Text", wardBindingSource, "WardID");
            tbWardName.DataBindings.Add("Text", wardBindingSource, "WardName");
            cboDistrictBindingSource = new BindingSource();
            cboDistrictBindingSource.DataSource = districts;
            cbDistrictIDOWard.DataBindings.Clear();
            cbDistrictIDOWard.DisplayMember = "DistrictName";
            cbDistrictIDOWard.ValueMember = "DistrictID";
            cbDistrictIDOWard.DataBindings.Add("SelectedValue", wardBindingSource, "DistrictID");
            cbDistrictIDOWard.DataSource = cboDistrictBindingSource;

            wardDataGridView.Columns.Clear();
            wardDataGridView.AutoGenerateColumns = false;

            wardDataGridView.Columns.Add("DistrictID", "District ID");
            wardDataGridView.Columns.Add("WardID", "Ward ID");
            wardDataGridView.Columns.Add("WardName", "Ward Name");

            wardDataGridView.Columns["DistrictID"].DataPropertyName = "DistrictID";
            wardDataGridView.Columns["WardID"].DataPropertyName = "WardID";
            wardDataGridView.Columns["WardName"].DataPropertyName = "WardName";

            wardDataGridView.DataSource = wardBindingSource;

            wardDataGridView.SelectionChanged += (sender, e) =>
            {
                if (wardDataGridView.CurrentRow != null)
                    wardBindingSource.Position = wardDataGridView.CurrentRow.Index;
            };
        }//done
        private void LoadDistrictComboBox()
        {
            try
            {
                var districts = _districtRepository.GetDistricts();

                cboNewDistrictBindingSource = new BindingSource();
                cboNewDistrictBindingSource.DataSource = districts;
                cbNewDistrictOWard.DataBindings.Clear();
                cbNewDistrictOWard.DisplayMember = "districtname";
                cbNewDistrictOWard.ValueMember = "districtid";
                cbNewDistrictOWard.DataSource = cboNewDistrictBindingSource;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }//done
        private void btnAddWard_Click(object sender, EventArgs e)
        {
            if (tbNewWardName.Text == string.Empty) return;
            try
            {
                Ward ward = new Ward
                {
                    WardName = tbNewWardName.Text,
                    DistrictId = int.Parse(cbNewDistrictOWard.SelectedValue.ToString())
                };
                _wardRepository.AddNewWard(ward);
                LoadWard();
                tbNewWardName.Text = string.Empty;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }//done
        private void btnDeleteWard_Click(object sender, EventArgs e)
        {
            try
            {
                Ward ward = new Ward
                {
                    WardId = int.Parse(tbWardID.Text),
                    DistrictId = int.Parse(cbDistrictIDOWard.SelectedValue.ToString()),
                    WardName = tbWardName.Text
                };
                _wardRepository.Remove(ward);
                LoadWard();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }//done 
        private void btnUpdateWard_Click(object sender, EventArgs e)
        {
            try
            {
                Ward ward = new Ward
                {
                    WardId = int.Parse(tbWardID.Text),
                    DistrictId = int.Parse(cbDistrictIDOWard.SelectedValue.ToString()),
                    WardName = tbWardName.Text
                };
                _wardRepository.Update(ward);
                LoadWard();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }//done
        //End of WardManagement tab
    }
}
