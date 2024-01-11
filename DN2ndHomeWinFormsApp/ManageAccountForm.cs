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
    public partial class ManageAccountForm : Form
    {
        private User _currentUser;
        private IUserRepository _userRepository;
        private bool _isEditing;
        private IAvatarReposity _avatarRepository;
        private Avatar avatar;
        public ManageAccountForm(User currentUser, IUserRepository userRepository, IAvatarReposity avatarReposity)
        {
            InitializeComponent();
            _currentUser = currentUser;
            _userRepository = userRepository;
            _isEditing = false;
            _avatarRepository = avatarReposity;
        }
        private void toolStripButtonClose_Click(object sender, EventArgs e)//done
        {
            DialogResult = DialogResult.Cancel;
        }
        private void toolStripButtonMinimize_Click(object sender, EventArgs e)//done
        {
            WindowState = FormWindowState.Minimized;
        }
        private void toolStripButtonBack_Click(object sender, EventArgs e)//done
        {
            DialogResult = DialogResult.OK;
        }
        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (_isEditing)
            {
                btnEdit.Text = "Chỉnh sửa";

                int i = UpdateUser();
                string message;
                if (i == 2)
                {
                    message = "Không thay đổi gì!!!";
                }
                else if (i == 0)
                {
                    message = "Sửa thành công!!!";
                }
                else
                {
                    message = "Sửa thất bại!!!";
                    pictureBox1.Image = ConvertByteArrayToImage(avatar.Avatar1);
                    pictureBox1.Tag = avatar.AvatarName;
                    tbUserName.Text = _currentUser.UserName;
                    tbEmail.Text = _currentUser.Email;
                    tbPhone.Text = _currentUser.Phone;
                    tbPassword.Text = _currentUser.Password;
                }
                MessageBox.Show(message);

                _isEditing = false;
                tbUserName.Enabled = false;
                tbPassword.Enabled = false;
                tbEmail.Enabled = false;
                tbPhone.Enabled = false;

                tbUserName.ReadOnly = true;
                tbPassword.ReadOnly = true;
                tbEmail.ReadOnly = true;
                tbPhone.ReadOnly = true;
            }
            else
            {
                btnEdit.Text = "Lưu";

                _isEditing = true;
                tbUserName.Enabled = true;
                tbPassword.Enabled = true;
                tbEmail.Enabled = true;
                tbPhone.Enabled = true;

                tbUserName.ReadOnly = false;
                tbPassword.ReadOnly = false;
                tbEmail.ReadOnly = false;
                tbPhone.ReadOnly = false;
            }
        }//done
        private int UpdateUser()
        {
            int a = 1;
            User user = new User
            {
                UserId = _currentUser.UserId,
                UserName = tbUserName.Text,
                Email = tbEmail.Text,
                Phone = tbPhone.Text,
                Password = tbPassword.Text,
                AvatarId = _currentUser.AvatarId,
                CreateAt = _currentUser.CreateAt,
                UserLevel = _currentUser.UserLevel,
            };
            if (user.UserName == _currentUser.UserName && user.Email == _currentUser.Email && user.Phone == _currentUser.Phone && user.Password == _currentUser.Password) a = 2;
            try
            {
                _userRepository.Update(user);
                a = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error : " + ex.Message);
            }
            a = UpdateAvatar();
            return a;
        }//done
        private Image ConvertByteArrayToImage(byte[] bytes)
        {
            using (MemoryStream ms = new MemoryStream(bytes))
            {
                return Image.FromStream(ms);
            }
        }//done
        private void GetUserAvatar()
        {
            try
            {
                avatar = _avatarRepository.GetAvatarByID((int)_currentUser.AvatarId);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error : " + ex.Message);
            }
        }//done
        private void ManageAccountForm_Load(object sender, EventArgs e)
        {
            GetUserAvatar();
            pictureBox1.Image = ConvertByteArrayToImage(avatar.Avatar1);
            pictureBox1.Tag = avatar.AvatarName;
            tbUserName.Text = _currentUser.UserName;
            tbEmail.Text = _currentUser.Email;
            tbPhone.Text = _currentUser.Phone;
            tbPassword.Text = _currentUser.Password;
        }//done
        private void pbAvatar_Click(object sender, EventArgs e)
        {
            if (_isEditing)
            {
                try
                {
                    openFileDialog1.Filter = "Images (*.BMP;*.JPG;*.GIF;*.PNG)|*.BMP;*.JPG;*.GIF;*.PNG|" + "All files (*.*)|*.*";
                    openFileDialog1.ShowDialog();
                    string filePath = openFileDialog1.FileName;
                    pictureBox1.Image = Image.FromFile(filePath);
                    pictureBox1.Image.Tag = Path.GetFileName(filePath);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }//done
        private int UpdateAvatar()
        {
            if (pictureBox1.Tag.Equals(avatar.AvatarName)) return 2;
            try
            {
                Avatar _avatar = new Avatar
                {
                    AvatarId = avatar.AvatarId,
                    Avatar1 = ConvertImageToByte(pictureBox1.Image),
                    AvatarName = pictureBox1.Tag.ToString(),
                };
                _avatarRepository.Update(_avatar);
                return 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            return 1;
        }//done
        private byte[] ConvertImageToByte(Image image)
        {
            using (MemoryStream ms = new MemoryStream())
            {
                image.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
                return ms.ToArray();
            }
        }//done
    }
}