using DN2ndHomeLibrary.DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DN2ndHomeLibrary.Repository
{
    public interface IPostRepository
    {
        IEnumerable<PrdInfo> GetPrdInfos();
        IEnumerable<PrdInfo> GetPrdInfosByPrdStatus(int status);
        IEnumerable<PrdInfo> GetPrdInfosByUserID(int userID);
        PrdInfo GetPrdInfoByID(int id);
        int AddNewPrdInfo(PrdInfo prdInfo);
        void Update(PrdInfo prdInfo);
        void Remove(PrdInfo prdInfo);
        void RemoveAllByUserID(int id);

    }
}
