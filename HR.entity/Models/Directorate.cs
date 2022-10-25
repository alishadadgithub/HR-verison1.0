using System;
using System.Collections.Generic;

#nullable disable

namespace HR.entity.Models
{
    public partial class Directorate
    {
        public Directorate()
        {
            AdministrativeDepartments = new HashSet<AdministrativeDepartment>();
            Authorities = new HashSet<Authority>();
            DirectorateJobs = new HashSet<DirectorateJob>();
        }

        public int PkdirectorateId { get; set; }
        public string DirectorateNameEn { get; set; }
        public string DirectorateNameAr { get; set; }

        public virtual ICollection<AdministrativeDepartment> AdministrativeDepartments { get; set; }
        public virtual ICollection<Authority> Authorities { get; set; }
        public virtual ICollection<DirectorateJob> DirectorateJobs { get; set; }
    }
}
