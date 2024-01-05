using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DN2ndHomeLibrary.DataAccess;
using Microsoft.EntityFrameworkCore;

namespace DN2ndHomeLibrary.DataManagament
{
    public class WardManagement
    {
        private static WardManagement instance = null;
        private static readonly object instanceLock = new object();
        private WardManagement() { }

        public static WardManagement Instance
        {
            get
            {
                lock (instanceLock)
                {
                    if (instance == null)
                    {
                        instance = new WardManagement();
                    }
                    return instance;
                }
            }
        }
        public IEnumerable<Ward> GetWardList()
        {
            List<Ward> wards;
            try
            {
                var DbContext = new dn2ndhomeManagementContext();
                wards = DbContext.Wards.ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return wards;
        }
        public IEnumerable<Ward> GetWardsForDistrict(int districtID)
        {
            List<Ward> wards;
            try
            {
                var DbContext = new dn2ndhomeManagementContext();

                wards = DbContext.Wards
                    .Where(ward => ward.DistrictId == districtID)
                    .ToList();
            }
            catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return wards;
        }

        public Ward GetWardByID(int id)
        {
            Ward ward = null;
            try
            {
                var DbContext = new dn2ndhomeManagementContext();
                ward = DbContext.Wards.SingleOrDefault(ward => ward.WardId == id);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return ward;
        }
        public void AddNewWard(Ward ward)
        {
            try
            {
                var DbContext = new dn2ndhomeManagementContext();
                DbContext.Wards.Add(ward);
                DbContext.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public void Update(Ward ward)
        {
            try
            {
                Ward _ward = GetWardByID(ward.WardId);
                if (_ward != null)
                {
                    var DbContext = new dn2ndhomeManagementContext();
                    DbContext.Entry(ward).State = EntityState.Modified;
                    DbContext.SaveChanges();
                }
                else
                {
                    throw new Exception("The ward does not exist");
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void Remove(Ward ward)
        {
            try
            {
                Ward _ward = GetWardByID(ward.WardId);
                if (_ward != null)
                {
                    var DbContext = new dn2ndhomeManagementContext();
                    DbContext.Wards.Remove(ward);
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
