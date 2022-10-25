using System;
using System.Collections.Generic;

#nullable disable

namespace HR.entity.Models
{
    public partial class LeaveTypeDay
    {
        public int PkleaveTypeDaysId { get; set; }
        public int? FkleaveTypeId { get; set; }
        public int? FkcontractTypeId { get; set; }
        public int? LeaveTypeDaysYearlyPermittedCount { get; set; }
        public int? LeaveTypeSickDaysPermittedCount { get; set; }
        public int? LeaveTypeDaysUnpaidPermittedCount { get; set; }
        public int? LeaveTypeDaysLongTermPermittedCount { get; set; }
        public int? LeaveTypeDaysFamilyPermittedCount { get; set; }
        public int? LeaveTypeDaysMotherhoodCount { get; set; }

        public virtual ContractType FkcontractType { get; set; }
        public virtual LeaveType FkleaveType { get; set; }
    }
}
