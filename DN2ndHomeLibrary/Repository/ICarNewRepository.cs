using DN2ndHomeLibrary.DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DN2ndHomeLibrary.Repository
{
    public interface ICarNewRepository
    {
        IEnumerable<CartNew> GetLists();
        IEnumerable<CartNew> GetListsByUserID(int id);
        void Add(CartNew carNew);
        CartNew GetByID(int id);
        void Remove(int prdID, int userID);
        bool IsPrdInfoSaved(int prdId, int userId);
    }
}
