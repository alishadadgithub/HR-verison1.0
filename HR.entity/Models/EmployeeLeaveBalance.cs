using System;
using System.Collections.Generic;

#nullable disable

namespace HR.entity.Models
{
    public partial class EmployeeLeaveBalance
    {
        public int PkemployeeLeaveBalanceId { get; set; }
        public int? EmployeeLeaveYearlyTakenDaysCount { get; set; }
        public int? EmployeeLeaveSickTakenDaysCount { get; set; }
        public int? EmployeeLeaveUnpaidTakenDaysCount { get; set; }
        public int? EmployeeLeaveLongTermTakenDaysCount { get; set; }
        public int FkemployeeId { get; set; }
    }
}
