using DN2ndHomeLibrary.DataAccess;
using DN2ndHomeLibrary.Repository;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DN2ndHomeWinFormsApp
{
    public class CustomGroupBox : GroupBox
    {
        private bool isSelected = false;

        public bool IsSelected
        {
            get { return isSelected; }
            set
            {
                if (isSelected != value)
                {
                    isSelected = value;
                    Invalidate();
                }
            }
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            if (isSelected)
            {
                using (Pen borderPen = new Pen(Color.Blue, 2))
                {
                    Rectangle borderRect = new Rectangle(0, 0, Width - 1, Height - 1);
                    e.Graphics.DrawRectangle(borderPen, borderRect);
                }
            }
        }
    }
    public partial class MainBoardForm : Form
    {
        private User CurrentUser;
        private IAvatarReposity _avatarReposity;
        private IUserRepository _userRepository;
        private IPostRepository _postRepository;
        private IDistrictRepository _districtRepository;
        private IWardRepository _wardRepository;
        private IImageRepository _imageRepository;
        private CustomGroupBox selectedGroupBox = null;

        public MainBoardForm(User user,
            IUserRepository userRepository,
            IAvatarReposity avatarReposity,
            IPostRepository postRepository,
            IDistrictRepository districtRepository,
            IWardRepository wardRepository,
            IImageRepository imageRepository
            )
        {
            InitializeComponent();
            CurrentUser = user;
            _avatarReposity = avatarReposity;
            _userRepository = userRepository;
            _postRepository = postRepository;
            _districtRepository = districtRepository;
            _wardRepository = wardRepository;
            _imageRepository = imageRepository;
            tabPaneTinDang.AutoScroll = true;
            tabPaneTinDang.HorizontalScroll.Visible = false;
            tabPaneTinDang.VerticalScroll.Visible = true;
        }
        private void MainBoardForm_Load(object sender, EventArgs e)
        {
            Avatar avatar = _avatarReposity.GetAvatarByID((int)CurrentUser.AvatarId);
            pictureBox1.Image = ConvertByteArrayToImage(avatar.Avatar1);
            tbName.Text = CurrentUser.UserName;
            tbEmail.Text = CurrentUser.Email;
            tbPhone.Text = CurrentUser.Phone;
            LoadPosts();
        }
        private Image ConvertByteArrayToImage(byte[] bytes)
        {
            using (MemoryStream ms = new MemoryStream(bytes))
            {
                return Image.FromStream(ms);
            }
        }//done
        private void btnAdmin_Click(object sender, EventArgs e)
        {
            AdminForm adminForm = new AdminForm(_userRepository, _postRepository, CurrentUser, _districtRepository, _wardRepository, _imageRepository);
            Hide();
            if (adminForm.ShowDialog() == DialogResult.OK)
            {
                Show();
            }
        }//done
        private void btnDangXuat_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }//done
        private void btnDangTin_Click(object sender, EventArgs e)
        {
            PostForm postForm = new PostForm(CurrentUser, _postRepository, _districtRepository, _wardRepository, _imageRepository);
            Hide();
            if (postForm.ShowDialog() == DialogResult.OK)
            {
                Show();
            }
        }//done
        private void btnQuanLyTaiKhoan_Click(object sender, EventArgs e)
        {

        }
        private void LoadPosts()
        {
            int postLocation = 7;
            try
            {
                var list = _postRepository.GetPrdInfos();
                foreach (var post in list)
                {
                    PostDetailForm(post, postLocation);
                    postLocation += 120;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message + " at loadPost");
            }
        }//done
        private List<Img> GetPostImage(int postID)
        {
            List<Img> images = null;
            try
            {
                images = _imageRepository.GetImageByPrdID(postID).ToList();
                return images;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            return images;
        }//done
        private string GetAddress(int districtID, int wardId)
        {
            string address = null;
            try
            {
                District district = _districtRepository.GetDistrictByID(districtID);
                Ward ward = _wardRepository.GetWardByID(wardId);
                address = district.DistrictName + ", " + ward.WardName;
                return address;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }

            return address;
        }//done
        private string GetAuthor(int authorID)
        {
            string author = null;
            try
            {
                User user = _userRepository.GetUserByID(authorID);
                author = user.UserName;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message + " at GetAuthor");
            }
            return author;
        }//done
        private async void PostDetailForm(PrdInfo post, int postLocation)
        {
            if (post.PrdStatus == 1) return;
            tabPaneTinDang.Controls.Clear();
            await Task.Run(() =>
            {
                CustomGroupBox groupBox = new CustomGroupBox();
                groupBox.Location = new System.Drawing.Point(6, postLocation);
                groupBox.Size = new System.Drawing.Size(570, 118);

                PictureBox pictureBox = new PictureBox();
                pictureBox.Location = new System.Drawing.Point(6, 16);
                pictureBox.Size = new System.Drawing.Size(125, 96);
                pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
                List<Img> images = GetPostImage(post.PrdId);
                if (images.Count != 0)
                {
                    pictureBox.Image = ConvertByteArrayToImage(images[0].Img1);
                    groupBox.Controls.Add(pictureBox);
                }
                else
                {
                    groupBox.Controls.Add(pictureBox);
                }

                TextBox tbTitle = new TextBox();
                tbTitle.Location = new System.Drawing.Point(137, 16);
                tbTitle.Size = new System.Drawing.Size(438, 27);
                tbTitle.Text = post.PrdTitle.ToString();
                tbTitle.Enabled = false;
                tbTitle.ReadOnly = true;
                groupBox.Controls.Add(tbTitle);

                TextBox tbDetailAddress = new TextBox();
                tbDetailAddress.Location = new System.Drawing.Point(137, 51);
                tbDetailAddress.Size = new System.Drawing.Size(142, 27);
                tbDetailAddress.Text = post.DetailAddress.ToString();
                tbDetailAddress.Enabled = false;
                tbDetailAddress.ReadOnly = true;
                groupBox.Controls.Add(tbDetailAddress);

                TextBox tbAddress = new TextBox();
                tbAddress.Location = new System.Drawing.Point(285, 51);
                tbAddress.Size = new System.Drawing.Size(142, 27);
                tbAddress.Text = GetAddress(post.DistrictId ?? 0, post.WardId ?? 0);
                tbAddress.Enabled = false;
                tbAddress.ReadOnly = true;
                groupBox.Controls.Add(tbAddress);

                TextBox tbArea = new TextBox();
                tbArea.Location = new System.Drawing.Point(433, 51);
                tbArea.Size = new System.Drawing.Size(142, 27);
                tbArea.Enabled = false;
                tbArea.ReadOnly = true;
                groupBox.Controls.Add(tbArea);

                TextBox tbPrice = new TextBox();
                tbPrice.Location = new System.Drawing.Point(137, 83);
                tbPrice.Size = new System.Drawing.Size(142, 27);
                tbPrice.Enabled = false;
                tbPrice.ReadOnly = true;
                groupBox.Controls.Add(tbPrice);

                TextBox tbAuthor = new TextBox();
                tbAuthor.Location = new System.Drawing.Point(285, 84);
                tbAuthor.Size = new System.Drawing.Size(142, 27);
                tbAuthor.Text = GetAuthor(post.UserId ?? 0);
                tbAuthor.Enabled = false;
                tbAuthor.ReadOnly = true;
                groupBox.Controls.Add(tbAuthor);

                groupBox.Click += ((object sender, EventArgs e) =>
                {
                    if (selectedGroupBox != null)
                    {
                        selectedGroupBox.IsSelected = false;
                    }

                    // Select the current CustomGroupBox
                    groupBox.IsSelected = true;
                    selectedGroupBox = groupBox;

                    LoadPostDetail(post);
                });


                tabPaneTinDang.Invoke((MethodInvoker)delegate
                {
                    tabPaneTinDang.Controls.Add(groupBox);
                });
            });
        }
        private void LoadPostDetail(PrdInfo post)
        { 
            tbPostTitle.Text = post.PrdTitle;
        }
    }
}
