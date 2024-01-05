using DN2ndHomeLibrary.DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DN2ndHomeLibrary.Repository
{
    public interface IDistrictRepository
    {
        IEnumerable<District> GetDistricts();
        District GetDistrictByID(int id);
        void AddNewDistrict(District district);
        void Remove(District district);
        void Update(District district);
    }
}
