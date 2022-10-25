using System;
using System.Collections.Generic;

#nullable disable

namespace HR.entity.Models
{
    public partial class AdministrativeDepartmentJob
    {
        public int PkadministrativeDepartmentJobId { get; set; }
        public int? FkadministrativeDepartmentId { get; set; }
        public int? FkjobId { get; set; }
        public int? AdministrativeDepartmentJobCount { get; set; }

        public virtual AdministrativeDepartment FkadministrativeDepartment { get; set; }
        public virtual Job Fkjob { get; set; }
    }
}
