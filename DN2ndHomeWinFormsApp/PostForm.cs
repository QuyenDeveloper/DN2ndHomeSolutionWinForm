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
    public partial class PostForm : Form
    {
        private User _CurrentUser;
        private IPostRepository _postRepository;
        private IDistrictRepository _districtRepository;
        private IWardRepository _wardRepository;
        private IImageRepository _imageRepository;
        BindingSource districtBindingSource, wardBindingSource;
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
        public PostForm(User CurrentUser, IPostRepository postRepository, IDistrictRepository districtRepository, IWardRepository wardRepository, IImageRepository imageRepository)
        {
            InitializeComponent();
            _CurrentUser = CurrentUser;
            _postRepository = postRepository;
            _districtRepository = districtRepository;
            _wardRepository = wardRepository;
            _imageRepository = imageRepository;
        }
        private void PostForm_Load(object sender, EventArgs e)
        {
            LoadDistrict();
            LoadWard();
        }
        private PrdInfo GetPost()
        {
            PrdInfo prdInfo = new PrdInfo
            {
                PrdTitle = tbTitle.Text,
                PrdDetail = tbDetail.Text,
                Area = int.Parse(tbArea.Text),
                Booked = 1,
                DetailAddress = tbDetail.Text,
                DistrictId = int.Parse(cbDistrict.SelectedValue.ToString()),
                PrdStatus = 1,
                Price = int.Parse(tbPrice.Text),
                WardId = int.Parse(cbWard.SelectedValue.ToString()),
                UserId = _CurrentUser.UserId,
            };
            return prdInfo;
        }//done
        private void ShowMessage(string message)
        {
            MessageBox.Show("Fail!! Your " + message);
        }//done
        private bool InputValidation()
        {
            if (tbTitle.Text == string.Empty) { ShowMessage("title can't be empty"); return true; }
            if (tbDetail.Text == string.Empty) { ShowMessage("detail can't be empty"); return true; }
            if (tbPrice.Text == string.Empty) { ShowMessage("price can't be empty"); return true; }
            if (!double.TryParse(tbPrice.Text, out _)) { ShowMessage("price have to be number"); return true; }
            if (tbArea.Text == string.Empty) { ShowMessage("area can't be empty"); return true; }
            if (!double.TryParse(tbArea.Text, out _)) { ShowMessage("area have to be number"); return true; }
            if (tbDetailAddress.Text == string.Empty) { ShowMessage("detail address"); return true; }
            return false;
        }//done
        private async void btnSave_Click(object sender, EventArgs e)
        {
            if (InputValidation()) return;
            try
            {
                int prdID = _postRepository.AddNewPrdInfo(GetPost());

                PictureBox[] pictureBoxes = { pbPost1, pbPost2, pbPost3, pbPost4 };

                foreach (var pictureBox in pictureBoxes)
                {
                    if (pictureBox.Image?.Tag != null)
                    {
                        string filePath = pictureBox.Image.Tag.ToString();
                        string imageName = Path.GetFileName(filePath);

                        await Task.Run(() =>
                        {
                            Img img = new Img
                            {
                                Img1 = ConvertImageToByte(pictureBox.Image),
                                ImgName = imageName,
                                PrdId = prdID,
                            };
                            _imageRepository.AddNewImage(img);
                        });
                    }
                }
                MessageBox.Show("Đăng thành công!!!", "Thành công", MessageBoxButtons.OK);
                DialogResult = DialogResult.OK;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }

        }//done
        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }//done
        private void LoadDistrict()//done
        {
            try
            {
                districtBindingSource = new BindingSource();
                var districts = _districtRepository.GetDistricts();
                districtBindingSource.DataSource = districts;

                cbDistrict.DataBindings.Clear();

                cbDistrict.DisplayMember = "DistrictName";
                cbDistrict.ValueMember = "DistrictID";
                cbDistrict.DataSource = districtBindingSource;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
        private void LoadWard()//done
        {
            try
            {
                wardBindingSource = new BindingSource();
                var wards = _wardRepository.GetWards();
                wardBindingSource.DataSource = wards;
                cbWard.DataBindings.Clear();

                cbWard.DisplayMember = "WardName";
                cbWard.ValueMember = "WardID";
                cbWard.DataSource = wardBindingSource;

                cbDistrict.SelectedIndexChanged += (sender, e) =>
                {
                    var selectedDistrict = (District)cbDistrict.SelectedItem;
                    var filteredWards = _wardRepository.GetWardsForDistrict(selectedDistrict.DistrictId);
                    wardBindingSource.DataSource = filteredWards;
                };
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
        private void pbPost1_Click(object sender, EventArgs e)//done
        {
            PictureBox clickedPictureBox = sender as PictureBox;
            try
            {
                postOpenFileDialog.Filter = "Images (*.BMP;*.JPG;*.GIF;*.PNG)|*.BMP;*.JPG;*.GIF;*.PNG|" + "All files (*.*)|*.*";
                postOpenFileDialog.ShowDialog();
                string filePath = postOpenFileDialog.FileName;
                clickedPictureBox.Image = Image.FromFile(filePath);
                clickedPictureBox.Image.Tag = filePath;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private byte[] ConvertImageToByte(Image image)//done
        {
            using (MemoryStream ms = new MemoryStream())
            {
                image.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
                return ms.ToArray();
            }
        }
        private void toolStrip1_MouseDown(object sender, MouseEventArgs e)//done
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
        private void toolStrip1_MouseMove(object sender, MouseEventArgs e)//done
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
        private void btnPostFormClose_Click(object sender, EventArgs e)//done
        {
            DialogResult = DialogResult.Cancel;
        }
        private void btnPostFormMinimize_Click(object sender, EventArgs e)//done
        {
            WindowState = FormWindowState.Minimized;
        }
        private void btnPostFormBack_Click(object sender, EventArgs e)//done
        {
            DialogResult = DialogResult.OK;
        }
    }
}
