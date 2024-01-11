using DN2ndHomeLibrary.DataAccess;
using DN2ndHomeLibrary.DataManagament;
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
    public partial class MainBoardForm : Form
    {
        private User CurrentUser;
        private IAvatarReposity _avatarReposity;
        private IUserRepository _userRepository;
        private IPostRepository _postRepository;
        private IDistrictRepository _districtRepository;
        private IWardRepository _wardRepository;
        private IImageRepository _imageRepository;
        private ICarNewRepository _carNewRepository;
        private CustomGroupBox selectedGroupBox = null;
        private PrdInfo selectedPost = null;
        List<Image> selectedPostImages = new List<Image>();
        private int currentImageIndex = 0;
        private const int WM_NCHITTEST = 0x84;
        private const int HTCLIENT = 0x1;
        private const int HTCAPTION = 0x2;
        private Point dragOffset;
        protected override void WndProc(ref Message message)
        {
            base.WndProc(ref message);

            if (message.Msg == WM_NCHITTEST && (int)message.Result == HTCLIENT)
                message.Result = (IntPtr)HTCAPTION;
        }
        public MainBoardForm(User user,
            IUserRepository userRepository,
            IAvatarReposity avatarReposity,
            IPostRepository postRepository,
            IDistrictRepository districtRepository,
            IWardRepository wardRepository,
            IImageRepository imageRepository,
            ICarNewRepository carNewRepository
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
            _carNewRepository = carNewRepository;
            tabPaneTinDang.AutoScroll = true;
            tabPaneTinDang.HorizontalScroll.Visible = false;
            tabPaneTinDang.VerticalScroll.Visible = true;
        }
        private void MainBoardForm_Load(object sender, EventArgs e)
        {
            LoadCurrentUser();
            LoadPosts();
        }

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
        }//done
        private void LoadCurrentUser()
        {
            CurrentUser = _userRepository.GetUserByID(CurrentUser.UserId);
            Avatar avatar = _avatarReposity.GetAvatarByID((int)CurrentUser.AvatarId);
            pictureBox1.Image = ConvertByteArrayToImage(avatar.Avatar1);
            tbName.Text = CurrentUser.UserName;
            tbEmail.Text = CurrentUser.Email;
            tbPhone.Text = CurrentUser.Phone;
            if(CurrentUser.UserLevel == 1) btnAdmin.Visible = false;
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
            AdminForm adminForm = new AdminForm(_userRepository, _postRepository, CurrentUser, _districtRepository, _wardRepository, _imageRepository, _avatarReposity);
            Hide();
            if (adminForm.ShowDialog() == DialogResult.OK)
            {
                Show();
            }
            else
            {
                Close();
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
            else
            {
                Close();
            }
        }//done
        private void btnQuanLyTaiKhoan_Click(object sender, EventArgs e)
        {
            ManageAccountForm manageAccountForm = new ManageAccountForm(CurrentUser, _userRepository, _avatarReposity);
            Hide();
            if (manageAccountForm.ShowDialog() == DialogResult.OK)
            {
                LoadCurrentUser();
                Show();
            }
            else
            {
                Close();
            }
        }
        private void LoadPosts()
        {
            tabPaneTinDang.Text = "Tin đăng";
            int postLocation = 7;
            try
            {
                var list = _postRepository.GetPrdInfosByPrdStatus(2);
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
                address = ward.WardName + ", " + district.DistrictName;
                return address;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }

            return address;
        }//done
        private User GetAuthor(int authorID)
        {
            User author = null;
            try
            {
                author = _userRepository.GetUserByID(authorID);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message + " at GetAuthor");
            }
            return author;
        }//done
        private async void PostDetailForm(PrdInfo post, int postLocation)
        {
            var syncContext = SynchronizationContext.Current;
            await Task.Run(() =>
            {
                User author = GetAuthor(post.UserId ?? 0);
                CustomGroupBox groupBox = new CustomGroupBox();
                groupBox.Dock = DockStyle.Top;
                groupBox.Location = new System.Drawing.Point(6, postLocation);
                groupBox.Size = new System.Drawing.Size(570, 118);

                PictureBox pictureBox = new PictureBox();
                pictureBox.Size = new System.Drawing.Size(125, 96);
                pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
                pictureBox.Dock = DockStyle.Left;
                List<Img> images = GetPostImage(post.PrdId);
                if (images.Count != 0)
                {
                    pictureBox.Image = ConvertByteArrayToImage(images[0].Img1);
                }
                groupBox.Controls.Add(pictureBox);

                TextBox tbTitle = new TextBox();
                tbTitle.Location = new System.Drawing.Point(137, 23);
                tbTitle.Size = new System.Drawing.Size(475, 27);
                tbTitle.Text = post.PrdTitle.ToString();
                tbTitle.Enabled = false;
                tbTitle.ReadOnly = true;
                groupBox.Controls.Add(tbTitle);

                TextBox tbDetailAddress = new TextBox();
                tbDetailAddress.Location = new System.Drawing.Point(137, 53);
                tbDetailAddress.Size = new System.Drawing.Size(475, 27);
                tbDetailAddress.Text = post.DetailAddress.ToString() + ", " + GetAddress(post.DistrictId ?? 0, post.WardId ?? 0);
                tbDetailAddress.Enabled = false;
                tbDetailAddress.ReadOnly = true;
                groupBox.Controls.Add(tbDetailAddress);

                TextBox tbPrice = new TextBox();
                tbPrice.Location = new System.Drawing.Point(137, 83);
                tbPrice.Size = new System.Drawing.Size(142, 27);
                tbPrice.Text = post.Price.ToString() + " VND/Tháng";
                tbPrice.Enabled = false;
                tbPrice.ReadOnly = true;
                groupBox.Controls.Add(tbPrice);

                TextBox tbAuthor = new TextBox();
                tbAuthor.Location = new System.Drawing.Point(285, 84);
                tbAuthor.Size = new System.Drawing.Size(142, 27);
                tbAuthor.Text = author.UserName;
                tbAuthor.Enabled = false;
                tbAuthor.ReadOnly = true;
                groupBox.Controls.Add(tbAuthor);

                groupBox.Click += ((object sender, EventArgs e) =>
                {
                    if (selectedGroupBox != null)
                    {
                        selectedGroupBox.IsSelected = false;
                    }
                    btnPostPreviousImage.Enabled = false;
                    btnPostNextImage.Enabled = true;
                    groupBox.IsSelected = true;
                    selectedGroupBox = groupBox;
                    selectedPost = post;
                    LoadPostDetail(post, author, images);
                });
                syncContext.Post(_ =>
                {
                    tabPaneTinDang.Controls.Add(groupBox);
                }, null);
            });
        }//done
        private async void LoadPostDetail(PrdInfo post, User author, List<Img> images)
        {
            if (_carNewRepository.IsPrdInfoSaved(post.PrdId, (int)CurrentUser.UserId))
            {
                btnSavePost.Text = "Hủy lưu";
            }
            else
            {
                btnSavePost.Text = "Lưu";
            }
            tbPostTitle.Text = post.PrdTitle;
            tbPostDetail.Text = post.PrdDetail;
            tbPostAddress.Text = post.DetailAddress + ", " + GetAddress(post.DistrictId ?? 0, post.WardId ?? 0);
            tbPostArea.Text = post.Area.ToString();
            tbPostPrice.Text = post.Price.ToString() + " VND/Tháng";

            tbPosterName.Text = author.UserName;
            tbPosterPhone.Text = author.Phone;
            tbPosterEmail.Text = author.Email;
            if (images.Count > 0)
            {
                selectedPostImages.Clear();
                await Task.Run(() =>
                {
                    foreach (Img img in images)
                    {
                        selectedPostImages.Add(ConvertByteArrayToImage(img.Img1));
                    }
                });
                pbPostImage.Image = selectedPostImages[0];
                lbPostImageCount.Text = (currentImageIndex + 1) + "/" + selectedPostImages.Count.ToString();
            }
            else
            {
                lbPostImageCount.Text = "0/0";
                btnPostNextImage.Enabled = false;
                btnPostPreviousImage.Enabled = false;
                pbPostImage.Image = Properties.Resources.empty;
            }
        }//done
        private void btnMainBoardClose_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }//done
        private void btnMainBoardMinimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }//done
        private void btnMainBoardRefresh_Click(object sender, EventArgs e)
        {
            tabPaneTinDang.Controls.Clear();
            LoadPosts();
        }//done
        private void toolStrip1_MouseDown(object sender, MouseEventArgs e)
        {
            base.OnMouseDown(e);
            if (e.Button == MouseButtons.Left)
            {
                dragOffset = this.PointToScreen(e.Location);
                var formLocation = FindForm().Location;
                dragOffset.X -= formLocation.X;
                dragOffset.Y -= formLocation.Y;
            }
        }
        private void toolStrip1_MouseMove(object sender, MouseEventArgs e)
        {
            base.OnMouseMove(e);

            if (e.Button == MouseButtons.Left)
            {
                Point newLocation = this.PointToScreen(e.Location);

                newLocation.X -= dragOffset.X;
                newLocation.Y -= dragOffset.Y;

                FindForm().Location = newLocation;
            }
        }
        private void btnTinDangCuaToi_Click(object sender, EventArgs e)
        {
            tabPaneTinDang.Controls.Clear();
            tabPaneTinDang.Text = "Tin đăng của tôi";
            int postLocation = 7;
            try
            {
                var list = _postRepository.GetPrdInfosByUserID(CurrentUser.UserId);
                if (!list.Any())
                {
                    Label lb = new Label();
                    lb.Text = "EMPTY";
                    lb.Dock = DockStyle.Fill;
                    lb.TextAlign = ContentAlignment.MiddleCenter;
                    tabPaneTinDang.Controls.Add(lb);
                }
                else
                {
                    foreach (var post in list)
                    {
                        PostDetailForm(post, postLocation);
                        postLocation += 120;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message + " at loadPost");
            }
        }
        private void btnSavedPost_Click(object sender, EventArgs e)
        {
            tabPaneTinDang.Controls.Clear();
            tabPaneTinDang.Text = "Tin đã lưu";
            int postLocation = 7;

            var carNewList = _carNewRepository.GetListsByUserID(CurrentUser.UserId);

            try
            {
                if (!carNewList.Any())
                {
                    Label lb = new Label();
                    lb.Text = "EMPTY";
                    lb.Dock = DockStyle.Fill;
                    lb.TextAlign = ContentAlignment.MiddleCenter;
                    tabPaneTinDang.Controls.Add(lb);
                }
                else
                {
                    foreach (var carNew in carNewList)
                    {
                        var post = _postRepository.GetPrdInfoByID((int)carNew.IdPrd);
                        if (post != null)
                        {
                            PostDetailForm(post, postLocation);
                            postLocation += 120;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message + " at loadPost");
            }
        }
        private void btnSavePost_Click(object sender, EventArgs e)
        {
            if (selectedPost != null)
            {
                try
                {
                    bool isSaved = _carNewRepository.IsPrdInfoSaved(selectedPost.PrdId, CurrentUser.UserId);
                    if (!isSaved)
                    {
                        CartNew cartNew = new CartNew
                        {
                            IdPrd = selectedPost.PrdId,
                            UserId = CurrentUser.UserId,
                        };
                        _carNewRepository.Add(cartNew);
                        MessageBox.Show("Lưu thành công");

                        btnSavePost.Text = "Hủy lưu";
                    }
                    else
                    {
                        _carNewRepository.Remove(selectedPost.PrdId, CurrentUser.UserId);
                        MessageBox.Show("Hủy thành công");

                        btnSavePost.Text = "Lưu";
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error : " + ex.Message);
                }
            }
        }
        private void btnPostNextImage_Click(object sender, EventArgs e)
        {
            currentImageIndex = (currentImageIndex + 1) % selectedPostImages.Count;
            lbPostImageCount.Text = (currentImageIndex + 1) + "/" + selectedPostImages.Count.ToString();
            pbPostImage.Image = selectedPostImages[currentImageIndex];
            btnPostNextImage.Enabled = (currentImageIndex < selectedPostImages.Count - 1);
            btnPostPreviousImage.Enabled = (currentImageIndex > 0);
        }
        private void btnPostPreviousImage_Click(object sender, EventArgs e)
        {
            currentImageIndex = (currentImageIndex - 1 + selectedPostImages.Count) % selectedPostImages.Count;
            lbPostImageCount.Text = (currentImageIndex + 1) + "/" + selectedPostImages.Count.ToString();
            pbPostImage.Image = selectedPostImages[currentImageIndex];
            btnPostNextImage.Enabled = (currentImageIndex < selectedPostImages.Count - 1);
            btnPostPreviousImage.Enabled = (currentImageIndex > 0);
        }
    }
}
