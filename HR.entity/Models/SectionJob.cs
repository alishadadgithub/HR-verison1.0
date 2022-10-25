using System;
using System.Collections.Generic;

#nullable disable

namespace HR.entity.Models
{
    public partial class SectionJob
    {
        public int PksectionJobId { get; set; }
        public int FksectionId { get; set; }
        public int FkjobId { get; set; }
        public int SectionJobCount { get; set; }

        public virtual Job Fkjob { get; set; }
        public virtual Section Fksection { get; set; }
    }
}
