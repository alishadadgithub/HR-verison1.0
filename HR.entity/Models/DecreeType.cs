using System;
using System.Collections.Generic;

#nullable disable

namespace HR.entity.Models
{
    public partial class DecreeType
    {
        public DecreeType()
        {
            EmployementDetails = new HashSet<EmployementDetail>();
        }

        public int PkdecreeTypeId { get; set; }
        public string DecreeTypeName { get; set; }

        public virtual ICollection<EmployementDetail> EmployementDetails { get; set; }
    }
}
