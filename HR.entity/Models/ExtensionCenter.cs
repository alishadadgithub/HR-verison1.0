using System;
using System.Collections.Generic;

#nullable disable

namespace HR.entity.Models
{
    public partial class ExtensionCenter
    {
        public ExtensionCenter()
        {
            ExtensionCenterJobs = new HashSet<ExtensionCenterJob>();
        }

        public int PkextensionCenterId { get; set; }
        public string ExtensionCenterNameEn { get; set; }
        public string ExtensionCenterNameAr { get; set; }
        public int? FkextensionId { get; set; }

        public virtual Extension Fkextension { get; set; }
        public virtual ICollection<ExtensionCenterJob> ExtensionCenterJobs { get; set; }
    }
}
