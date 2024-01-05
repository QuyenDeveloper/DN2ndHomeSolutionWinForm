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
                var DbContext = new dn2ndhomeManagementContext();
                avatars = DbContext.Avatars.ToList();
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
                var DbContext = new dn2ndhomeManagementContext();
                avatar = DbContext.Avatars.SingleOrDefault(avatar => avatar.AvatarId == id);
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
                var DbContext = new dn2ndhomeManagementContext();
                lastAvatarId = DbContext.Avatars.OrderByDescending(a => a.AvatarId).Select(a => a.AvatarId).FirstOrDefault();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return lastAvatarId;
        }
        public void AddNewAvatar(Avatar avatar)
        {
            try
            {
                var DbContext = new dn2ndhomeManagementContext();
                DbContext.Avatars.Add(avatar);
                DbContext.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public void Update(Avatar avatar)
        {
            try
            {
                Avatar _avatar = GetAvatarByID(avatar.AvatarId);
                if (_avatar != null)
                {
                    var DbContext = new dn2ndhomeManagementContext();
                    DbContext.Entry(avatar).State = EntityState.Modified;
                    DbContext.SaveChanges();
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

        public void Remove(Avatar avatar)
        {
            try
            {
                Avatar _avatar = GetAvatarByID(avatar.AvatarId);
                if (_avatar != null)
                {
                    var DbContext = new dn2ndhomeManagementContext();
                    DbContext.Avatars.Remove(avatar);
                    DbContext.SaveChanges();
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
