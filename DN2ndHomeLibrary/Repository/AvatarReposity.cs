using DN2ndHomeLibrary.DataAccess;
using DN2ndHomeLibrary.DataManagament;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DN2ndHomeLibrary.Repository
{
    public class AvatarReposity : IAvatarReposity
    {
        public Avatar GetAvatarByID(int id) => AvatarManagemant.Instance.GetAvatarByID(id);
        public int GetLastID() => AvatarManagemant.Instance.GetLastID();
        public IEnumerable<Avatar> GetAvatars() => AvatarManagemant.Instance.GetAvatarList();
        public int AddNewAvatar(Avatar avatar) => AvatarManagemant.Instance.AddNewAvatar(avatar);
        public void Remove(int id) => AvatarManagemant.Instance.Remove(id);
        public void Update(Avatar avatar) => AvatarManagemant.Instance.Update(avatar);
    }
}
