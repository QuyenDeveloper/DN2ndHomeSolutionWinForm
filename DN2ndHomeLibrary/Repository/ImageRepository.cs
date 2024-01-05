using DN2ndHomeLibrary.DataAccess;
using DN2ndHomeLibrary.DataManagament;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DN2ndHomeLibrary.Repository
{
    public class ImageRepository : IImageRepository
    {
        public IEnumerable<Img> GetImgs() => ImageManagement.Instance.GetImages();
        public IEnumerable<Img> GetImageByPrdID(int prdID) => ImageManagement.Instance.GetImageByPrdID(prdID);
        public Img GetImageByID(int id) => ImageManagement.Instance.GetImageByID(id);
        public void AddNewImage(Img img) => ImageManagement.Instance.AddNewImage(img);
        public void Update(Img img) => ImageManagement.Instance.Update(img);
        public void Delete(Img img) => ImageManagement.Instance.Remove(img);
        public void RemoveImagesByPrdID(int prdID) => ImageManagement.Instance.RemoveImagesByPrdID(prdID);
    }
}
