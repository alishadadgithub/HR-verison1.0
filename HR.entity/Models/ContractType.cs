using System;
using System.Collections.Generic;

#nullable disable

namespace HR.entity.Models
{
    public partial class ContractType
    {
        public ContractType()
        {
            EmployementDetails = new HashSet<EmployementDetail>();
            LeaveTypeDays = new HashSet<LeaveTypeDay>();
        }

        public int PkcontractType { get; set; }
        public string ContractTypeName { get; set; }

        public virtual ICollection<EmployementDetail> EmployementDetails { get; set; }
        public virtual ICollection<LeaveTypeDay> LeaveTypeDays { get; set; }
    }
}
