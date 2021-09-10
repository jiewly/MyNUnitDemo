using MyNUnitDemo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyNUnitDemo.Repositories
{
     public interface ILicensesRepository
    {
        IEnumerable<License> GetAll();
        IEnumerable<LicenseViewModel> GetAllWithJoin();
        IEnumerable<LicenseReportViewModel> GetAllForReport();
        License GetById(int id);
        License GetById(string licenseId);
        int Add(License tModel);
        int Update(License tModel);
        int Delete(License tModel);
    }
    public class LicensesRepository : ILicensesRepository
    {
        public int Add(License tModel)
        {
            throw new NotImplementedException();
        }

        public int Delete(License tModel)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<License> GetAll()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<LicenseReportViewModel> GetAllForReport()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<LicenseViewModel> GetAllWithJoin()
        {
            throw new NotImplementedException();
        }

        public License GetById(int id)
        {
            throw new NotImplementedException();
        }

        public License GetById(string licenseId)
        {
            throw new NotImplementedException();
        }

        public int Update(License tModel)
        {
            throw new NotImplementedException();
        }
    }
}
