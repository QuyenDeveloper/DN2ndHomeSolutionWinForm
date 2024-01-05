using DN2ndHomeLibrary.DataAccess;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DN2ndHomeLibrary.DataManagament
{
    public class ImageManagement
    {
        private static ImageManagement instance = null;
        private static readonly object instanceLock = new object();
        private ImageManagement() { }

        public static ImageManagement Instance
        {
            get
            {
                lock (instanceLock)
                {
                    if (instance == null)
                    {
                        instance = new ImageManagement();
                    }
                    return instance;
                }
            }
        }
        public IEnumerable<Img> GetImages()
        {
            List<Img> Images;
            try
            {
                var DbContext = new dn2ndhomeManagementContext();
                Images = DbContext.Imgs.ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return Images;
        }

        public IEnumerable<Img> GetImageByPrdID(int id)
        {
            List<Img> images = null;
            try
            {
                var DbContext = new dn2ndhomeManagementContext();
                images = DbContext.Imgs.Where(image => image.PrdId == id).ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return images;
        }
        public Img GetImageByID(int id)
        {
            Img image = null;
            try
            {
                var DbContext = new dn2ndhomeManagementContext();
                image = DbContext.Imgs.SingleOrDefault(image => image.ImgId == id);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return image;
        }
        public void AddNewImage(Img image)
        {   
            try
            {
                var DbContext = new dn2ndhomeManagementContext();
                DbContext.Imgs.Add(image);
                DbContext.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public void Update(Img image)
        {  
            try
            {
                Img _image = GetImageByID(image.ImgId);
                if (_image != null)
                {
                    var DbContext = new dn2ndhomeManagementContext();
                    DbContext.Entry(image).State = EntityState.Modified;
                    DbContext.SaveChanges();
                }
                else
                {
                    throw new Exception("This image does not exist");
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void Remove(Img image)
        {
            try
            {
                Img _image = GetImageByID(image.ImgId);
                if (_image != null)
                {
                    var DbContext = new dn2ndhomeManagementContext();
                    DbContext.Imgs.Remove(image);
                    DbContext.SaveChanges();
                }
                else { throw new Exception("This image does not exist"); }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public void RemoveImagesByPrdID(int prdID)
        {
            try
            {
                var DbContext = new dn2ndhomeManagementContext();

                var imagesToRemove = DbContext.Imgs.Where(img => img.PrdId == prdID).ToList();

                if (imagesToRemove.Any())
                {
                    DbContext.Imgs.RemoveRange(imagesToRemove);
                    DbContext.SaveChanges();
                }
                else
                {
                    throw new Exception("No images found with the specified prdID");
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error removing images: " + ex.Message);
            }
        }

    }
}
