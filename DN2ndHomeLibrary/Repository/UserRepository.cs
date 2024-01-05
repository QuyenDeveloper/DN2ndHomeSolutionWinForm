using DN2ndHomeLibrary.DataAccess;
using DN2ndHomeLibrary.DataManagament;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DN2ndHomeLibrary.Repository
{
    public class UserRepository : IUserRepository
    {
        public User GetUserByID(int user_id) => UserManagement.Instance.GetUserByID(user_id);
        public IEnumerable<User> GetUsersByName(string searchName) => UserManagement.Instance.GetUserListByName(searchName);
        public IEnumerable<User> GetUsers() => UserManagement.Instance.GetUserList();
        public void AddNewUser(User user) => UserManagement.Instance.AddNewUser(user);
        public void Remove(User user) => UserManagement.Instance.Remove(user);
        public void Update(User user) => UserManagement.Instance.Update(user);
        public User Login(string username, string password) => UserManagement.Instance.Login(username, password);
    }
}
