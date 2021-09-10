using Autofac.Extras.Moq;
using Moq;
using MyNUnitDemo.Models;
using MyNUnitDemo.Repositories;
using MyNUnitDemo.Service;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NUnitTest
{
    public class LicenseRenewServiceTest
    {
        private AutoMock autoMock;

        [SetUp]
        public void SetUp()
        {
            autoMock = AutoMock.GetLoose();
        }

        [Test]
        public void GetAll_HaveModels_ReturnListModel()
        {
            autoMock.Mock<ILicenseRenewRepository>().Setup(m => m.GetAll()).Returns(GetLicenseRenews());
            var licenseRenewsService = autoMock.Create<LicenseRenewService>();
            var licenseRenews = licenseRenewsService.GetAll().ToString();
            Assert.Greater(licenseRenews.Count(), 0);
        }

        [Test]
        public void GetById_Found_ReturnModel()
        {
            autoMock.Mock<ILicenseRenewRepository>().Setup(m => m.GetById(It.IsAny<string>())).Returns((string licenseId) => GetLicenseRenews().Where(m => m.FK_LicenseId == licenseId).FirstOrDefault());

            var licenseRenewService = autoMock.Create<LicenseRenewService>();
            var res = licenseRenewService.GetById("100");
            Assert.Null(res);
            
        }

        [Test]
        public void GetById_NotFound_ReturnNull()
        {
            autoMock.Mock<ILicenseRenewRepository>().Setup(m => m.GetById(It.IsAny<string>())).Returns((string licenseId) => GetLicenseRenews().Where(m => m.FK_LicenseId == licenseId).FirstOrDefault());

            var licenseRenewService = autoMock.Create<LicenseRenewService>();
            var res = licenseRenewService.GetById("11");
            Assert.NotNull(res);
            Assert.AreEqual(res.FK_PONo, "A002");
        }



        [TearDown]
        public void TearDown()
        {

        }

        public IEnumerable<LicenseRenew> GetLicenseRenews()
        {
            return new List<LicenseRenew>{
                new LicenseRenew{ Id = 1, FK_PONo="A001", FK_LicenseId="10"},
                new LicenseRenew{ Id = 2, FK_PONo="A002", FK_LicenseId="11"}
                };
        }
    }
}
