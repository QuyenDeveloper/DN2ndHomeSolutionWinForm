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
                DialogResult = DialogResult.OK;
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }

        }//done
        private void showTest(PrdInfo p)
        {
            MessageBox.Show("Title: " + p.PrdTitle + ", Detail: " + p.PrdDetail + ", Area: " + p.Area + ", Booked: " + p.Booked + ", DetailAddress: " + p.DetailAddress + ", DistrictID: " + p.DistrictId + ", Price: " + p.Price + ", WardID: " + p.WardId + ", Userid: " + p.UserId);
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }//done
        private void LoadDistrict()
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
        }//done
        private void LoadWard()
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
        }//done
        private void pbPost1_Click(object sender, EventArgs e)
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
