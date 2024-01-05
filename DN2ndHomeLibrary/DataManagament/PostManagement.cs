using DN2ndHomeLibrary.DataAccess;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DN2ndHomeLibrary.DataManagament
{
    public class PostManagement
    {
        private static PostManagement instance = null;
        private static readonly object instanceLock = new object();
        private PostManagement() { }

        public static PostManagement Instance
        {
            get
            {
                lock (instanceLock)
                {
                    if (instance == null)
                    {
                        instance = new PostManagement();
                    }
                    return instance;
                }
            }
        }

        public IEnumerable<PrdInfo> GetPrdInfos()
        {
            List<PrdInfo> prdInfos;
            try
            {
                var DbContext = new dn2ndhomeManagementContext();
                prdInfos = DbContext.PrdInfos.ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return prdInfos;
        }
        public PrdInfo GetPrdInfoByID(int id)
        {
            PrdInfo prdInfo = null;
            try
            {
                var DbContext = new dn2ndhomeManagementContext();
                prdInfo = DbContext.PrdInfos.SingleOrDefault(prdInfo => prdInfo.PrdId == id);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return prdInfo;
        }
        public int AddNewPrdInfo(PrdInfo prdInfo)
        {
            try
            {
                var DbContext = new dn2ndhomeManagementContext();
                DbContext.PrdInfos.Add(prdInfo);
                DbContext.SaveChanges();

                int prdID = prdInfo.PrdId;
                return prdID;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public void Update(PrdInfo prdInfo)
        {
            try
            {
                PrdInfo _prdInfo = GetPrdInfoByID(prdInfo.PrdId);
                if (_prdInfo != null)
                {
                    var DbContext = new dn2ndhomeManagementContext();
                    DbContext.Entry(prdInfo).State = EntityState.Modified;
                    DbContext.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void Remove(PrdInfo prdInfo)
        {
            try
            {
                PrdInfo _prdInfo = GetPrdInfoByID(prdInfo.PrdId);
                if (_prdInfo != null)
                {
                    var DbContext = new dn2ndhomeManagementContext();
                    DbContext.PrdInfos.Remove(prdInfo);
                    DbContext.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
