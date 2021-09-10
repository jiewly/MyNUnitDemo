using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyNUnitDemo.Models
{
    public class LicenseReportViewModel
    {
        public int Id { get; set; }
        public string PONo { get; set; }
        public string LicenseId { get; set; }
        public string LicenseName { get; set; }
        public string StatusName { get; set; }
        public string LocationName { get; set; }
        public int Amount { get; set; }
        public string WorkTypeName { get; set; }
        public DateTime? StartedDate { get; set; }
        public DateTime? ExpiredDate { get; set; }
        public DateTime? CreatedDate { get; set; }
    }
}
