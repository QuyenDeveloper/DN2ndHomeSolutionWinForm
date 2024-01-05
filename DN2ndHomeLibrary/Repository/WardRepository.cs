using DN2ndHomeLibrary.DataAccess;
using DN2ndHomeLibrary.DataManagament;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DN2ndHomeLibrary.Repository
{
    public class WardRepository : IWardRepository
    {
        public Ward GetWardByID(int id) => WardManagement.Instance.GetWardByID(id);
        public IEnumerable<Ward> GetWards() => WardManagement.Instance.GetWardList();
        public void AddNewWard(Ward ward) => WardManagement.Instance.AddNewWard(ward);
        public void Remove(Ward ward) => WardManagement.Instance.Remove(ward);
        public void Update(Ward ward) => WardManagement.Instance.Update(ward);
        public IEnumerable<Ward> GetWardsForDistrict(int districtID) => WardManagement.Instance.GetWardsForDistrict(districtID);
    }
}
