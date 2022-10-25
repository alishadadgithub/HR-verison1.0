using System;
using System.Collections.Generic;

#nullable disable

namespace HR.entity.Models
{
    public partial class Department
    {
        public Department()
        {
            DepartmentJobs = new HashSet<DepartmentJob>();
            Sections = new HashSet<Section>();
        }

        public int PkdepartmentId { get; set; }
        public string DepartmentNameEn { get; set; }
        public string DepartmentNameAr { get; set; }
        public int FkauthotiryId { get; set; }

        public virtual Authority Fkauthotiry { get; set; }
        public virtual ICollection<DepartmentJob> DepartmentJobs { get; set; }
        public virtual ICollection<Section> Sections { get; set; }
    }
}
