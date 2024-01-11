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
                using (var dbContext = new dn2ndhomeManagementContext())
                {
                    Images = dbContext.Imgs.ToList();
                }
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
                using (var dbContext = new dn2ndhomeManagementContext())
                {
                    images = dbContext.Imgs.Where(image => image.PrdId == id).ToList();
                }
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
                using (var dbContext = new dn2ndhomeManagementContext())
                {
                    image = dbContext.Imgs.SingleOrDefault(image => image.ImgId == id);
                }
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
                using (var dbContext = new dn2ndhomeManagementContext())
                {
                    dbContext.Imgs.Add(image);
                    dbContext.SaveChanges();
                }
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
                    using (var dbContext = new dn2ndhomeManagementContext())
                    {
                        dbContext.Entry(image).State = EntityState.Modified;
                        dbContext.SaveChanges();
                    }
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
                    using (var dbContext = new dn2ndhomeManagementContext())
                    {
                        dbContext.Imgs.Remove(image);
                        dbContext.SaveChanges();
                    }
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
                using (var dbContext = new dn2ndhomeManagementContext())
                {
                    var imagesToRemove = dbContext.Imgs.Where(img => img.PrdId == prdID).ToList();

                    if (imagesToRemove.Any())
                    {
                        dbContext.Imgs.RemoveRange(imagesToRemove);
                        dbContext.SaveChanges();
                    }
                    else
                    {
                        throw new Exception("No images found with the specified prdID");
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error removing images: " + ex.Message);
            }
        }

    }
}
