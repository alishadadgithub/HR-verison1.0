using System;
using System.Collections.Generic;

#nullable disable

namespace HR.entity.Models
{
    public partial class EmployementStatus
    {
        public EmployementStatus()
        {
            EmployementDetails = new HashSet<EmployementDetail>();
        }

        public int PkemploymentStatusId { get; set; }
        public string EmploymentStatusName { get; set; }

        public virtual ICollection<EmployementDetail> EmployementDetails { get; set; }
    }
}
