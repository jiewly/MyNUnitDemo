using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyNUnitDemo.Models
{
    public class License
    {
        public int Id { get; set; }
        public string LicenseId { get; set; }
        public string LicenseName { get; set; }
        public string FK_PONo { get; set; }
        public int FK_TypeId { get; set; }
        public int FK_WorkTypeId { get; set; }
        public int FK_StatusId { get; set; }
        public int FK_LocationId { get; set; }
        public int Amount { get; set; }
        public int TimeAlert { get; set; }
        public bool TimeStatus { get; set; }
        public string Description { get; set; }
        public bool IsStatus { get; set; }
        public DateTime? StartedDate { get; set; }
        public DateTime? ExpiredDate { get; set; }
        public DateTime? CreatedDate { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public string CreatedBy { get; set; }
        public string ModifiedBy { get; set; }
    }
}
