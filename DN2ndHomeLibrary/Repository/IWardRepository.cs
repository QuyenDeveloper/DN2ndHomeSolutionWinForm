using DN2ndHomeLibrary.DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DN2ndHomeLibrary.Repository
{
    public interface IWardRepository
    {
        IEnumerable<Ward> GetWards();
        Ward GetWardByID(int id);
        void AddNewWard(Ward ward);
        void Remove(Ward ward);
        void Update(Ward ward);
        IEnumerable<Ward> GetWardsForDistrict(int districtID);
    }
}
