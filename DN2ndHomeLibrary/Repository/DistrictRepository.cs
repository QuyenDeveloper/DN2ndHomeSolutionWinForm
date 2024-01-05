using DN2ndHomeLibrary.DataAccess;
using DN2ndHomeLibrary.DataManagament;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DN2ndHomeLibrary.Repository
{
    public class DistrictRepository : IDistrictRepository
    {
        public District GetDistrictByID(int id) => DistrictManagement.Instance.GetDistrictByID(id);
        public IEnumerable<District> GetDistricts() => DistrictManagement.Instance.GetDistrictList();
        public void AddNewDistrict(District district) => DistrictManagement.Instance.AddNewDistrict(district);
        public void Remove(District district) => DistrictManagement.Instance.Remove(district);
        public void Update(District district) => DistrictManagement.Instance.Update(district);
    }
}
