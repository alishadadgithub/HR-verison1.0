using System;
using System.Collections.Generic;

#nullable disable

namespace HR.entity.Models
{
    public partial class Job
    {
        public Job()
        {
            AdministrativeDepartmentJobs = new HashSet<AdministrativeDepartmentJob>();
            AuthorityJobs = new HashSet<AuthorityJob>();
            CenterJobs = new HashSet<CenterJob>();
            DepartmentJobs = new HashSet<DepartmentJob>();
            DirectorateJobs = new HashSet<DirectorateJob>();
            EmployementDetails = new HashSet<EmployementDetail>();
            ExtensionCenterJobs = new HashSet<ExtensionCenterJob>();
            ExtensionSectionJobs = new HashSet<ExtensionSectionJob>();
            SectionJobs = new HashSet<SectionJob>();
        }

        public int PkjobId { get; set; }
        public string JobName { get; set; }
        public int FkcategoryId { get; set; }

        public virtual Category Fkcategory { get; set; }
        public virtual ICollection<AdministrativeDepartmentJob> AdministrativeDepartmentJobs { get; set; }
        public virtual ICollection<AuthorityJob> AuthorityJobs { get; set; }
        public virtual ICollection<CenterJob> CenterJobs { get; set; }
        public virtual ICollection<DepartmentJob> DepartmentJobs { get; set; }
        public virtual ICollection<DirectorateJob> DirectorateJobs { get; set; }
        public virtual ICollection<EmployementDetail> EmployementDetails { get; set; }
        public virtual ICollection<ExtensionCenterJob> ExtensionCenterJobs { get; set; }
        public virtual ICollection<ExtensionSectionJob> ExtensionSectionJobs { get; set; }
        public virtual ICollection<SectionJob> SectionJobs { get; set; }
    }
}
