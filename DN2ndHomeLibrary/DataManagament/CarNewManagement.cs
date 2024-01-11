using DN2ndHomeLibrary.DataAccess;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DN2ndHomeLibrary.DataManagament
{
    public class CarNewManagement
    {
        private static CarNewManagement instance = null;
        private static readonly object instanceLock = new object();
        private CarNewManagement() { }

        public static CarNewManagement Instance
        {
            get
            {
                lock (instanceLock)
                {
                    if (instance == null)
                    {
                        instance = new CarNewManagement();
                    }
                    return instance;
                }
            }
        }
        public IEnumerable<CartNew> GetLists()
        {
            List<CartNew> carNews;
            try
            {
                using (var dbContext = new dn2ndhomeManagementContext())
                {
                    carNews = dbContext.CartNews.ToList();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return carNews;
        }

        public IEnumerable<CartNew> GetListsByUserID(int id)
        {
            List<CartNew> carNews = null;
            try
            {
                using (var dbContext = new dn2ndhomeManagementContext())
                {
                    carNews = dbContext.CartNews.Where(carNew => carNew.UserId == id).ToList();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return carNews;
        }
        public void Add(CartNew carNew)
        {
            try
            {
                using (var dbContext = new dn2ndhomeManagementContext())
                {
                    dbContext.CartNews.Add(carNew);
                    dbContext.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error adding avatar: " + ex.Message);
            }
        }
        public CartNew GetByID(int id)
        {
            CartNew carNew = null;
            try
            {
                using (var dbContext = new dn2ndhomeManagementContext())
                {
                    carNew = dbContext.CartNews.SingleOrDefault(carNew => carNew.UserId == id);
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return carNew;
        }
        public void Remove(int prdID, int userID)
        {
            try
            {
                using (var dbContext = new dn2ndhomeManagementContext())
                {
                    var cartToRemove = dbContext.CartNews.FirstOrDefault(cart => cart.IdPrd == prdID && cart.UserId == userID);

                    if (cartToRemove != null)
                    {
                        dbContext.CartNews.Remove(cartToRemove);
                        dbContext.SaveChanges();
                    }
                    else
                    {
                        Console.WriteLine($"CartNew with IdPrd = {prdID} and UserId = {userID} not found.");
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public bool IsPrdInfoSaved(int prdId, int userId)
        {
            try
            {
                using (var dbContext = new dn2ndhomeManagementContext())
                {
                    var isSaved = dbContext.CartNews.Any(cart => cart.IdPrd == prdId && cart.UserId == userId);
                    return isSaved;
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"Error checking if PrdInfo is saved: {ex.Message}");
            }
        }
    }
}
