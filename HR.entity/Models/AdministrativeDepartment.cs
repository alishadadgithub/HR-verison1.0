using System;
using System.Collections.Generic;

#nullable disable

namespace HR.entity.Models
{
    public partial class AdministrativeDepartment
    {
        public AdministrativeDepartment()
        {
            AdministrativeDepartmentJobs = new HashSet<AdministrativeDepartmentJob>();
        }

        public int PkadministrativeDepartmentId { get; set; }
        public string AdministrativeDepartmentNameEn { get; set; }
        public string AdministrativeDepartmentNameAr { get; set; }
        public int FkdirectorateId { get; set; }

        public virtual Directorate Fkdirectorate { get; set; }
        public virtual ICollection<AdministrativeDepartmentJob> AdministrativeDepartmentJobs { get; set; }
    }
}
