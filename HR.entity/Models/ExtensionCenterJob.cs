using System;
using System.Collections.Generic;

#nullable disable

namespace HR.entity.Models
{
    public partial class ExtensionCenterJob
    {
        public int PkextensionCenterJobId { get; set; }
        public int? FkextensionCenterId { get; set; }
        public int? FkjobId { get; set; }
        public int? ExtensionCenterJobCount { get; set; }

        public virtual ExtensionCenter FkextensionCenter { get; set; }
        public virtual Job Fkjob { get; set; }
    }
}
