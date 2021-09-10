using MyNUnitDemo.Models;
using MyNUnitDemo.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyNUnitDemo.Service
{
    public interface ILicenseRenewService
    {
        IEnumerable<LicenseRenew> GetAll();
        LicenseRenew GetById(string id);
        bool Add(LicenseRenew model);
        bool Update(LicenseRenew model);
        bool Delete(int id);
        IEnumerable<LicenseRenew> GetByLicenseId(string id);
        bool LicenseRenew(LicenseRenew model);
    }

    public class LicenseRenewService : ILicenseRenewService
    {
        private ILicenseRenewRepository licenseRenewRepository;
        private ILicensesRepository licensesRepository;
        //injection
        public LicenseRenewService(
            ILicenseRenewRepository licenseRenewRepository,
            ILicensesRepository licensesRepository)
        {
            //dependency
            this.licenseRenewRepository = licenseRenewRepository;
            this.licensesRepository = licensesRepository;
        }

        public IEnumerable<LicenseRenew> GetAll()
        {
            return licenseRenewRepository.GetAll();
        }

        public LicenseRenew GetById(string id)
        {
            return licenseRenewRepository.GetById(id);
        }

        public bool Add(LicenseRenew model)
        {
            model.CreatedDate = DateTime.Now;
            model.IsStatus = true;
            return licenseRenewRepository.Add(model) > 0;
        }

        public bool Update(LicenseRenew model)
        {
            return licenseRenewRepository.Update(model) > 0;
        }

        public bool Delete(int id)
        {
            var model = new LicenseRenew { Id = id };
            return licenseRenewRepository.Delete(model) > 0;
        }

        public IEnumerable<LicenseRenew> GetByLicenseId(string id)
        {
            var haspurchaseOrder = licenseRenewRepository.GetAll().Where(x => x.FK_LicenseId == id && x.IsStatus == false).ToList();
            return haspurchaseOrder;
        }

        public bool LicenseRenew(LicenseRenew model)
        {
            //update to old license & purchase order
            var oldPurchaseOrder = licenseRenewRepository.GetAll().SingleOrDefault(x => x.FK_LicenseId == model.FK_LicenseId && x.IsStatus == true);
            oldPurchaseOrder.IsStatus = false;
            var updateRenew = licenseRenewRepository.Update(oldPurchaseOrder);

            if (updateRenew <= 0)
            {
                return false;
            }

            //update to license
            var hasLicense = licensesRepository.GetAll().SingleOrDefault(x => x.LicenseId == model.FK_LicenseId);
            hasLicense.FK_PONo = model.FK_PONo;
            hasLicense.ExpiredDate = model.ExpiredDate;
            licensesRepository.Update(hasLicense);

            //add to new license renew
            model.CreatedDate = DateTime.Now;
            var result = licenseRenewRepository.Add(model) > 0;

            return result;
        }
    }
}