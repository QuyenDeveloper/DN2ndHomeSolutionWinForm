using DN2ndHomeLibrary.DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DN2ndHomeLibrary.Repository
{
    public interface IAvatarReposity
    {
        IEnumerable<Avatar> GetAvatars();
        int GetLastID();
        Avatar GetAvatarByID(int id);
        int AddNewAvatar(Avatar avatar);
        void Remove(int id);
        void Update(Avatar avatar);
        
    }
}
