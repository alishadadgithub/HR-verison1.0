using System;
using System.Collections.Generic;

#nullable disable

namespace HR.entity.Models
{
    public partial class CareerProgression
    {
        public int PkcareerProgressionId { get; set; }
        public DateTime? CareerProgressionDate { get; set; }
        public decimal? CareerProgressionRaise { get; set; }
        public int? FkemployeeId { get; set; }

        public virtual Employee Fkemployee { get; set; }
    }
}
