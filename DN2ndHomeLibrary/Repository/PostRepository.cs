using DN2ndHomeLibrary.DataAccess;
using DN2ndHomeLibrary.DataManagament;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DN2ndHomeLibrary.Repository
{
    public class PostRepository : IPostRepository
    {
        public IEnumerable<PrdInfo> GetPrdInfos() => PostManagement.Instance.GetPrdInfos();
        public PrdInfo GetPrdInfoByID(int id) => PostManagement.Instance.GetPrdInfoByID(id);
        public int AddNewPrdInfo(PrdInfo prdInfo) => PostManagement.Instance.AddNewPrdInfo(prdInfo);
        public void Update(PrdInfo prdInfo) => PostManagement.Instance.Update(prdInfo);
        public void Remove(PrdInfo prdInfo) => PostManagement.Instance.Remove(prdInfo);
    }
}
