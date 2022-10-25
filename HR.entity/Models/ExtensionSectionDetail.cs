using System;
using System.Collections.Generic;

#nullable disable

namespace HR.entity.Models
{
    public partial class ExtensionSectionDetail
    {
        public int PkextensionSectionDetailsId { get; set; }
        public int? FkextensionId { get; set; }
        public int? FkextensionSectionId { get; set; }

        public virtual Extension Fkextension { get; set; }
        public virtual ExtensionSection FkextensionSection { get; set; }
    }
}
