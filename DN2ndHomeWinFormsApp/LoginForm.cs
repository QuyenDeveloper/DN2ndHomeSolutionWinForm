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
        public LoginForm()
        {
            InitializeComponent();
        }
        private User GetLoginUser(string username, string password)
        {
            User user = null;
            try
            {
                user = _userRepository.Login(username, password);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

            return user;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = tbUserName.Text;
            string password = tbPassword.Text;
            if (username == string.Empty || password == string.Empty) { MessageBox.Show("Missing Name or Password"); return; }
            try
            {
                User user = GetLoginUser(username, password);
                if (user == null)
                {
                    MessageBox.Show("Wrong info or user doesn't exist");
                }
                else
                {
                    MainBoardForm board = new MainBoardForm(user, 
                        _userRepository, 
                        _avatarReposity, 
                        _postRepository, 
                        _districtRepository, 
                        _wardRepository, 
                        _imageRepository);
                    Hide();
                    if (board.ShowDialog() == DialogResult.OK)
                    {
                        Show();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btnSignIn_Click(object sender, EventArgs e) //Sign up btn
        {
            SignUpForm signInForm = new SignUpForm(_userRepository, _avatarReposity);
            signInForm.Show();
        }
    }
}