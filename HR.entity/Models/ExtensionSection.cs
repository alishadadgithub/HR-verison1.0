using System;
using System.Collections.Generic;

#nullable disable

namespace HR.entity.Models
{
    public partial class ExtensionSection
    {
        public ExtensionSection()
        {
            ExtensionSectionDetails = new HashSet<ExtensionSectionDetail>();
            ExtensionSectionJobs = new HashSet<ExtensionSectionJob>();
        }

        public int PkextensionSectionId { get; set; }
        public string ExtensionSectionName { get; set; }

        public virtual ICollection<ExtensionSectionDetail> ExtensionSectionDetails { get; set; }
        public virtual ICollection<ExtensionSectionJob> ExtensionSectionJobs { get; set; }
    }
}
