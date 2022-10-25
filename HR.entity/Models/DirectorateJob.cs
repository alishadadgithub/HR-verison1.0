using System;
using System.Collections.Generic;

#nullable disable

namespace HR.entity.Models
{
    public partial class DirectorateJob
    {
        public int PkdirectorateJobId { get; set; }
        public int FkdirectorateId { get; set; }
        public int FkjobId { get; set; }
        public int DirectorateJobCount { get; set; }

        public virtual Directorate Fkdirectorate { get; set; }
        public virtual Job Fkjob { get; set; }
    }
}
