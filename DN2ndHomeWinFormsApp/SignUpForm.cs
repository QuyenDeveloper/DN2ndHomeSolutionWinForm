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
    public partial class SignUpForm : Form
    {
        IUserRepository _userRepository;
        IAvatarReposity _avatarRepository;
        public SignUpForm(IUserRepository userRepository, IAvatarReposity avatarReposity)
        {
            InitializeComponent();
            _userRepository = userRepository;
            _avatarRepository = avatarReposity;
        }

        private void btnSignIn_Click(object sender, EventArgs e)
        {
            if (CheckVal() == 1)
            {
                return;
            }

            try
            {
                SaveImage();
                SaveUser();
                MessageBox.Show("Sign up success!!!");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"error: {ex.Message}", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private byte[] ConvertImageToByte(Image image)
        {
            using (MemoryStream ms = new MemoryStream())
            {
                image.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
                return ms.ToArray();
            }
        }

        private void SaveImage()
        {
            string fileName = pbAvatar.Image.Tag.ToString();
            string imageName = Path.GetFileName(fileName);
            try
            {
                Avatar avatar = new Avatar
                {
                    Avatar1 = ConvertImageToByte(pbAvatar.Image),
                    AvatarName = imageName,
                };
                _avatarRepository.AddNewAvatar(avatar);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
        private void SaveUser()
        {
            int id = _avatarRepository.GetLastID();
            try
            {
                User user = new User
                {
                    UserName = tbName.Text,
                    Password = tbPassword.Text,
                    Phone = tbPhone.Text,
                    Email = tbEmail.Text,
                    AvatarId = id,
                };
                _userRepository.AddNewUser(user);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void SignIn()
        {


        }
        private int CheckVal()
        {
            int cancelState = 0;
            string username = tbName.Text;
            string password = tbPassword.Text;
            string confirmPassword = tbConfirmPassword.Text;
            string email = tbEmail.Text;
            string phone = tbPhone.Text;
            if (username == string.Empty)
            {
                MessageBox.Show("Name is required");
                cancelState = 1;
                return cancelState;
            }

            if (password == string.Empty)
            {
                MessageBox.Show("Password is required");
                cancelState = 1;
                return cancelState;
            }
            else if (password.Length < 6)
            {
                MessageBox.Show("Password is required to be above 6 character");
                cancelState = 1;
                return cancelState;
            }

            if (confirmPassword == string.Empty)
            {
                MessageBox.Show("Confirm password is required");
                cancelState = 1;
                return cancelState;
            }
            else if (confirmPassword != password)
            {
                MessageBox.Show("Confirm password is required to be like password");
                cancelState = 1;
                return cancelState;
            }

            if (email == string.Empty && phone == string.Empty)
            {
                MessageBox.Show("Email or phone is required");
                cancelState = 1;
                return cancelState;
            }
            if (pbAvatar.Image == null)
            {
                pbAvatar.Image = Properties.Resources.DefaultAvt;
                pbAvatar.Image.Tag = "\\DefaultAvt.png";
            }
            return cancelState;
        }

        private void SignInForm_Load(object sender, EventArgs e)
        {

        }

        private void pbAvatar_Click(object sender, EventArgs e)
        {
            try
            {
                openFileDialog1.Filter = "Images (*.BMP;*.JPG;*.GIF;*.PNG)|*.BMP;*.JPG;*.GIF;*.PNG|" + "All files (*.*)|*.*";
                openFileDialog1.ShowDialog();
                string filePath = openFileDialog1.FileName;
                pbAvatar.Image = Image.FromFile(filePath);
                pbAvatar.Image.Tag = filePath;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
