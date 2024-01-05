using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DN2ndHomeLibrary.DataAccess;

namespace DN2ndHomeLibrary.Repository
{
    public interface IImageRepository
    {
        IEnumerable<Img> GetImgs();
        IEnumerable<Img> GetImageByPrdID(int prdID);
        Img GetImageByID(int id);
        void AddNewImage(Img img);
        void Update(Img img);
        void Delete(Img img);
        void RemoveImagesByPrdID(int prdID);
    }
}
