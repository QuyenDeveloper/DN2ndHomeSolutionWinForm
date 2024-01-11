using DN2ndHomeLibrary.DataAccess;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace DN2ndHomeLibrary.DataManagament
{
    public class UserManagement
    {
        private static UserManagement instance = null;
        private static readonly object instanceLock = new object();
        private UserManagement() { }

        public static UserManagement Instance
        {
            get
            {
                lock (instanceLock)
                {
                    if (instance == null)
                    {
                        instance = new UserManagement();
                    }
                    return instance;
                }
            }
        }
        public IEnumerable<User> GetUserList()
        {
            List<User> users;
            try
            {
                using (var dbContext = new dn2ndhomeManagementContext())
                { 
                    users = dbContext.Users.ToList();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return users;
        }
        public IEnumerable<User> GetUserListByName(string searchName)
        {
            List<User> users;
            try
            {
                using (var dbContext = new dn2ndhomeManagementContext())
                { 
                    users = dbContext.Users
                    .Where(user => user.UserName.Contains(searchName))
                    .ToList();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return users;
        }

        public User GetUserByID(int user_id)
        {
            User user = null;
            try
            {
                using (var dbContext = new dn2ndhomeManagementContext())
                {
                    user = dbContext.Users.SingleOrDefault(user => user.UserId == user_id);
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return user;
        }

        public void AddNewUser(User user)
        {
            try
            {
                User _user = GetUserByID(user.UserId);
                if (_user == null)
                {
                    using (var dbContext = new dn2ndhomeManagementContext())
                    {
                        dbContext.Users.Add(user);
                        dbContext.SaveChanges();
                    }
                }
                else
                {
                    throw new Exception("The user is already exist");
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public void Update(User user)
        {
            try
            {
                User u = GetUserByID(user.UserId);
                if (u != null)
                {
                    using (var dbContext = new dn2ndhomeManagementContext())
                    {
                        dbContext.Entry(user).State = EntityState.Modified;
                        dbContext.SaveChanges();
                    }
                }
                else
                {
                    throw new Exception("The user does not exist");
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void Remove(User user)
        {
            try
            {
                User _user = GetUserByID(user.UserId);
                if (_user != null)
                {
                    using (var dbContext = new dn2ndhomeManagementContext())
                    {
                        dbContext.Users.Remove(user);
                        dbContext.SaveChanges();
                    }
                }
                else { throw new Exception("The user does not exist"); }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public User Login(string username, string password)
        {
            User user = null;
            try
            {
                using (var dbContext = new dn2ndhomeManagementContext())
                { 
                    user = dbContext.Users.SingleOrDefault(user => user.UserName == username && user.Password == password);
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return user;
        }
        public bool isExist(string username)
        {
            try
            {
                using (var dbContext = new dn2ndhomeManagementContext())
                {
                    var isExist = dbContext.Users.Any(user => user.UserName == username);
                    return isExist;
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"Error checking if PrdInfo is saved: {ex.Message}");
            }
        }
    }
}
