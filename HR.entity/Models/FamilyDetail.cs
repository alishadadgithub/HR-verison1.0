using System;
using System.Collections.Generic;

#nullable disable

namespace HR.entity.Models
{
    public partial class FamilyDetail
    {
        public int PkfamilyDetailsId { get; set; }
        public string FamilyDetailsFullName { get; set; }
        public DateTime? FamilyDetailsDob { get; set; }
        public string FamilyDetailsGender { get; set; }
        public int FkrelativeTypeId { get; set; }
        public int FkemployeeId { get; set; }

        public virtual Employee Fkemployee { get; set; }
        public virtual RelativeType FkrelativeType { get; set; }
    }
}
