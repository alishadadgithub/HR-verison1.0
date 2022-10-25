using System;
using System.Collections.Generic;

#nullable disable

namespace HR.entity.Models
{
    public partial class Authority
    {
        public Authority()
        {
            AuthorityJobs = new HashSet<AuthorityJob>();
            Departments = new HashSet<Department>();
        }

        public int PkauthorityId { get; set; }
        public string AuthorityNameEn { get; set; }
        public string AuthorityNameAr { get; set; }
        public int FkdirectorateId { get; set; }

        public virtual Directorate Fkdirectorate { get; set; }
        public virtual ICollection<AuthorityJob> AuthorityJobs { get; set; }
        public virtual ICollection<Department> Departments { get; set; }
    }
}
