using System;
using System.Collections.Generic;

#nullable disable

namespace HR.entity.Models
{
    public partial class Section
    {
        public Section()
        {
            Centers = new HashSet<Center>();
            SectionJobs = new HashSet<SectionJob>();
        }

        public int PksectionId { get; set; }
        public string SectionNameEn { get; set; }
        public string SectionNameAr { get; set; }
        public int FkdepartmentId { get; set; }

        public virtual Department Fkdepartment { get; set; }
        public virtual ICollection<Center> Centers { get; set; }
        public virtual ICollection<SectionJob> SectionJobs { get; set; }
    }
}
