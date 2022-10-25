using System;
using System.Collections.Generic;

#nullable disable

namespace HR.entity.Models
{
    public partial class EmployementDetail
    {
        public int PkemployementDetailsId { get; set; }
        public DateTime? EmployementDecreeDate { get; set; }
        public DateTime? EmployementStartWorkingDate { get; set; }
        public DateTime? EmployementRetirementDate { get; set; }
        public int? FkjobId { get; set; }
        public int? FkcategoryId { get; set; }
        public int? FkemployeeId { get; set; }
        public int? FkdecreeType { get; set; }
        public int? FkcontractType { get; set; }
        public int? FkemploymentStatusId { get; set; }

        public virtual Category Fkcategory { get; set; }
        public virtual ContractType FkcontractTypeNavigation { get; set; }
        public virtual DecreeType FkdecreeTypeNavigation { get; set; }
        public virtual Employee Fkemployee { get; set; }
        public virtual EmployementStatus FkemploymentStatus { get; set; }
        public virtual Job Fkjob { get; set; }
    }
}
