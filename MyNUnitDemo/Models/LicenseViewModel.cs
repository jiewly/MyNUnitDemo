using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyNUnitDemo.Models
{

    public class LicenseViewModel
    {
        public int Id { get; set; }
        public string LicenseId { get; set; }
        public string LicenseName { get; set; }
        public int Amount { get; set; }
        public string PONo { get; set; }
        public int TypeId { get; set; }
        public string TypeName { get; set; }
        public int WorkTypeId { get; set; }
        public string WorkTypeName { get; set; }
        public int StatusId { get; set; }
        public string StatusName { get; set; }
        public DateTime? StartedDate { get; set; }
        public DateTime? ExpiredDate { get; set; }
        public DateTime? CreatedDate { get; set; }
        public DateTime? ModifiedDate { get; set; }
    }
}
