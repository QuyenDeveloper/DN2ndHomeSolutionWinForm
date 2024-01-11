using DN2ndHomeLibrary.DataAccess;
using DN2ndHomeLibrary.DataManagament;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DN2ndHomeLibrary.Repository
{
    public class CarNewRepository : ICarNewRepository
    {
        public IEnumerable<CartNew> GetLists() => CarNewManagement.Instance.GetLists();
        public IEnumerable<CartNew> GetListsByUserID(int id) => CarNewManagement.Instance.GetListsByUserID(id);
        public void Add(CartNew carNew) => CarNewManagement.Instance.Add(carNew);
        public CartNew GetByID(int id) => CarNewManagement.Instance.GetByID(id);
        public void Remove(int id) => CarNewManagement.Instance.Remove(id);
    }
}
