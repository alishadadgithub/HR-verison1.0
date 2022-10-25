using System;
using System.Collections.Generic;

#nullable disable

namespace HR.entity.Models
{
    public partial class ExtensionSectionJob
    {
        public int PkextensionSectionJobId { get; set; }
        public int? FkextensionSectionId { get; set; }
        public int? FkjobId { get; set; }
        public int? ExtensionSectionJobCount { get; set; }

        public virtual ExtensionSection FkextensionSection { get; set; }
        public virtual Job Fkjob { get; set; }
    }
}
