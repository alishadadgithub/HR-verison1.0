using System;
using System.Collections.Generic;

#nullable disable

namespace HR.entity.Models
{
    public partial class DepartmentJob
    {
        public int PkdepartmentJobId { get; set; }
        public int FkdepartmentId { get; set; }
        public int FkjobId { get; set; }
        public int DepartmentJobCount { get; set; }

        public virtual Department Fkdepartment { get; set; }
        public virtual Job Fkjob { get; set; }
    }
}
