using System;
using System.Collections.Generic;

#nullable disable

namespace HR.entity.Models
{
    public partial class Extension
    {
        public Extension()
        {
            ExtensionCenters = new HashSet<ExtensionCenter>();
            ExtensionSectionDetails = new HashSet<ExtensionSectionDetail>();
        }

        public int PkextensionId { get; set; }
        public string ExtensionNameEn { get; set; }
        public string ExtensionNameAr { get; set; }

        public virtual ICollection<ExtensionCenter> ExtensionCenters { get; set; }
        public virtual ICollection<ExtensionSectionDetail> ExtensionSectionDetails { get; set; }
    }
}
