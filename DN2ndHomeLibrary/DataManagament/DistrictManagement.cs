using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DN2ndHomeLibrary.DataAccess;
using Microsoft.EntityFrameworkCore;

namespace DN2ndHomeLibrary.DataManagament
{
    public class DistrictManagement
    {
        private static DistrictManagement instance = null;
        private static readonly object instanceLock = new object();
        private DistrictManagement() { }

        public static DistrictManagement Instance
        {
            get
            {
                lock (instanceLock)
                {
                    if (instance == null)
                    {
                        instance = new DistrictManagement();
                    }
                    return instance;
                }
            }
        }
        public IEnumerable<District> GetDistrictList()
        {
            List<District> districts;
            try
            {
                var DbContext = new dn2ndhomeManagementContext();
                districts = DbContext.Districts.ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return districts;
        }

        public District GetDistrictByID(int id)
        {
            District district = null;
            try
            {
                var DbContext = new dn2ndhomeManagementContext();
                district = DbContext.Districts.SingleOrDefault(district => district.DistrictId == id);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return district;
        }
        public void AddNewDistrict(District district)
        {
            try
            {
                var DbContext = new dn2ndhomeManagementContext();
                DbContext.Districts.Add(district);
                DbContext.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public void Update(District district)
        {
            try
            {
                District _district = GetDistrictByID(district.DistrictId);
                if (_district != null)
                {
                    var DbContext = new dn2ndhomeManagementContext();
                    DbContext.Entry(district).State = EntityState.Modified;
                    DbContext.SaveChanges();
                }
                else
                {
                    throw new Exception("The avatar does not exist");
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void Remove(District district)
        {
            try
            {
                District _district = GetDistrictByID(district.DistrictId);
                if (_district != null)
                {
                    var DbContext = new dn2ndhomeManagementContext();
                    DbContext.Districts.Remove(district);
                    DbContext.SaveChanges();
                }
                else { throw new Exception("The avatar does not exist"); }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
