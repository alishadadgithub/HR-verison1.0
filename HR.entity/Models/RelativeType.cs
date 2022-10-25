using System;
using System.Collections.Generic;

#nullable disable

namespace HR.entity.Models
{
    public partial class RelativeType
    {
        public RelativeType()
        {
            FamilyDetails = new HashSet<FamilyDetail>();
        }

        public int PkrelativeTypeId { get; set; }
        public string RelativeTypeName { get; set; }

        public virtual ICollection<FamilyDetail> FamilyDetails { get; set; }
    }
}
