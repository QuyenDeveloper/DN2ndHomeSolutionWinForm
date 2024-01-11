using DN2ndHomeLibrary.DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DN2ndHomeLibrary.Repository
{
    public interface IUserRepository
    {
        IEnumerable<User> GetUsers();
        IEnumerable<User> GetUsersByName(string username);
        User GetUserByID(int user_id);
        void AddNewUser(User user);
        void Remove(User user);
        void Update(User user);
        User Login(string username, string password);
        bool isExist(string username);
    }
}
