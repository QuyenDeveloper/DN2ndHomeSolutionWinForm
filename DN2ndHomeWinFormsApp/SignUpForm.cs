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
        public SignUpForm(IUserRepository userRepository, IAvatarReposity avatarReposity)
        {
            InitializeComponent();
            _userRepository = userRepository;
            _avatarRepository = avatarReposity;
        }
        private void btnSignIn_Click(object sender, EventArgs e)
        {
            if (CheckVal() == 1) return;
            try
            {
                SaveUser();
                MessageBox.Show("Sign up success!!!", "Success", MessageBoxButtons.OK);
                DialogResult = DialogResult.OK;
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
        private int SaveAvatar()
        {
            string avatarName = pbAvatar.Image.Tag.ToString();
            int id = 0;
            try
            {
                Avatar avatar = new Avatar
                {
                    Avatar1 = ConvertImageToByte(pbAvatar.Image),
                    AvatarName = avatarName,
                };
                id = _avatarRepository.AddNewAvatar(avatar);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            return id;
        }
        private void SaveUser()
        {
            int id = SaveAvatar();
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
        private void pbAvatar_Click(object sender, EventArgs e)
        {
            try
            {
                openFileDialog1.Filter = "Images (*.BMP;*.JPG;*.GIF;*.PNG)|*.BMP;*.JPG;*.GIF;*.PNG|" + "All files (*.*)|*.*";
                openFileDialog1.ShowDialog();
                string filePath = openFileDialog1.FileName;
                pbAvatar.Image = Image.FromFile(filePath);
                pbAvatar.Image.Tag = Path.GetFileName(filePath);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void btnSignUpFormClose_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
        private void btnSignUpFormMinimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }
        private void btnSignUpBack_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }
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
    }
}
