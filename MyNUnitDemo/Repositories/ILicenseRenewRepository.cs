using MyNUnitDemo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyNUnitDemo.Repositories
{
    public interface ILicenseRenewRepository
    {
        IEnumerable<LicenseRenew> GetAll();
        LicenseRenew GetById(string licenseId);
        int Add(LicenseRenew tModel);
        int Update(LicenseRenew tModel);
        int Delete(LicenseRenew tModel);
    }
    public class LicenseRenewRepository : ILicenseRenewRepository
    {
        public int Add(LicenseRenew tModel)
        {
            throw new NotImplementedException();
        }

        public int Delete(LicenseRenew tModel)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<LicenseRenew> GetAll()
        {
            throw new NotImplementedException();
        }

        public LicenseRenew GetById(string licenseId)
        {
            throw new NotImplementedException();
        }

        public int Update(LicenseRenew tModel)
        {
            throw new NotImplementedException();
        }
    }
}
