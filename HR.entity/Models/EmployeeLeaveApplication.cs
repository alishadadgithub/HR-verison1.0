using System;
using System.Collections.Generic;

#nullable disable

namespace HR.entity.Models
{
    public partial class EmployeeLeaveApplication
    {
        public int PkemployeeLeaveApplicationId { get; set; }
        public DateTime? EmployeeLeaveApplicationFromDate { get; set; }
        public DateTime? EmployeeLeaveApplicationToDate { get; set; }
        public int? EmployeeLeaveApplicationDaysCount { get; set; }
        public bool? EmployeeLeaveApplicationApproved { get; set; }
        public int FkleaveTypeId { get; set; }
        public int FkemployeeId { get; set; }

        public virtual Employee Fkemployee { get; set; }
        public virtual LeaveType FkleaveType { get; set; }
    }
}
