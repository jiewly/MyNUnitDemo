using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyNUnitDemo.Models
{
    public class LicenseRenew
    {
        public int Id { get; set; }
        public string FK_LicenseId { get; set; }
        public string FK_PONo { get; set; }
        public bool IsStatus { get; set; }
        public DateTime? ExpiredDate { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string CreatedBy { get; set; }
    }
}
