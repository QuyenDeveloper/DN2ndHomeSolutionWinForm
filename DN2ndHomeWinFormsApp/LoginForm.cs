using DN2ndHomeLibrary.Repository;
using DN2ndHomeLibrary.DataAccess;
namespace DN2ndHomeWinFormsApp
{
    public partial class LoginForm : Form
    {
        UserRepository _userRepository = new UserRepository();
        AvatarReposity _avatarReposity = new AvatarReposity();
        PostRepository _postRepository = new PostRepository();
        DistrictRepository _districtRepository = new DistrictRepository();
        WardRepository _wardRepository = new WardRepository();
        ImageRepository _imageRepository = new ImageRepository();
        CarNewRepository _carNewRepository = new CarNewRepository();
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
        public LoginForm()
        {
            InitializeComponent();
        }
        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = tbUserName.Text;
            string password = tbPassword.Text;
            if (username == string.Empty || password == string.Empty) { MessageBox.Show(this, "Thiếu tên đăng nhập hoặc mật khẩu", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Information); return; }
            try
            {
                User user = _userRepository.Login(username, password);
                if (user == null)
                {
                    MessageBox.Show( "Sai mật khậu hoặc người dùng không tồn tại");
                }
                else if (user.UserLevel == 2)
                {
                    ConfirmAdminPasswordForm confirmAdminPasswordForm = new ConfirmAdminPasswordForm();
                    if(confirmAdminPasswordForm.ShowDialog() == DialogResult.OK)
                    {
                        MainBoardForm board = new MainBoardForm(user,
                        _userRepository,
                        _avatarReposity,
                        _postRepository,
                        _districtRepository,
                        _wardRepository,
                        _imageRepository,
                        _carNewRepository);
                        Hide();
                        if (board.ShowDialog() == DialogResult.OK)
                        {
                            Show();
                        }
                        else
                        {
                            Close();
                        }
                    }
                }
                else
                {
                    MainBoardForm board = new MainBoardForm(user,
                        _userRepository,
                        _avatarReposity,
                        _postRepository,
                        _districtRepository,
                        _wardRepository,
                        _imageRepository,
                        _carNewRepository);
                    Hide();
                    if (board.ShowDialog() == DialogResult.OK)
                    {
                        Show();
                    }
                    else
                    {
                        Close();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
        private void btnSignIn_Click(object sender, EventArgs e)
        {
            SignUpForm signInForm = new SignUpForm(_userRepository, _avatarReposity);
            Hide();
            if (signInForm.ShowDialog() == DialogResult.OK)
            {
                Show();
            }
            else
            {
                Close();
            }
        }
        private void toolStripButtonClose_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void toolStripButtonSignInMinimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
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