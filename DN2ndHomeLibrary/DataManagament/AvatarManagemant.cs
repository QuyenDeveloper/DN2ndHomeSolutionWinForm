using DN2ndHomeLibrary.DataAccess;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DN2ndHomeLibrary.DataManagament
{
    public class AvatarManagemant
    {
        private static AvatarManagemant instance = null;
        private static readonly object instanceLock = new object();
        private AvatarManagemant() { }

        public static AvatarManagemant Instance
        {
            get
            {
                lock (instanceLock)
                {
                    if (instance == null)
                    {
                        instance = new AvatarManagemant();
                    }
                    return instance;
                }
            }
        }
        public IEnumerable<Avatar> GetAvatarList()
        {
            List<Avatar> avatars;
            try
            {
                using (var dbContext = new dn2ndhomeManagementContext())
                {
                    avatars = dbContext.Avatars.ToList();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return avatars;
        }

        public Avatar GetAvatarByID(int id)
        {
            Avatar avatar = null;
            try
            {
                using (var dbContext = new dn2ndhomeManagementContext())
                {
                    avatar = dbContext.Avatars.SingleOrDefault(avatar => avatar.AvatarId == id);
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return avatar;
        }
        public int GetLastID()
        {
            int lastAvatarId = 0;
            try
            {
                using (var dbContext = new dn2ndhomeManagementContext())
                {
                    lastAvatarId = dbContext.Avatars.OrderByDescending(a => a.AvatarId).Select(a => a.AvatarId).FirstOrDefault();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return lastAvatarId;
        }
        public int AddNewAvatar(Avatar avatar)
        {
            try
            {
                using (var dbContext = new dn2ndhomeManagementContext())
                {
                    dbContext.Avatars.Add(avatar);
                    dbContext.SaveChanges();
                    return avatar.AvatarId;
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error adding avatar: " + ex.Message);
            }
        }

        public void Update(Avatar avatar)
        {
            try
            {
                Avatar _avatar = GetAvatarByID(avatar.AvatarId);
                if (_avatar != null)
                {
                    using (var dbContext = new dn2ndhomeManagementContext())
                    {
                        dbContext.Entry(avatar).State = EntityState.Modified;
                        dbContext.SaveChanges();
                    }
                }
                else
                {
                    throw new Exception("The avatar does not exist");
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void Remove(int id)
        {
            try
            {
                Avatar _avatar = GetAvatarByID(id);
                if (_avatar != null)
                {
                    using (var dbContext = new dn2ndhomeManagementContext())
                    {
                        dbContext.Avatars.Remove(_avatar);
                        dbContext.SaveChanges();
                    }
                }
                else { throw new Exception("The avatar does not exist"); }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
