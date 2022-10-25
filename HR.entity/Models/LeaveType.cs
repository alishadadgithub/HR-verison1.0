using System;
using System.Collections.Generic;

#nullable disable

namespace HR.entity.Models
{
    public partial class LeaveType
    {
        public LeaveType()
        {
            EmployeeLeaveApplications = new HashSet<EmployeeLeaveApplication>();
            LeaveTypeDays = new HashSet<LeaveTypeDay>();
        }

        public int PkleaveTypeId { get; set; }
        public string LeaveTypeNameEn { get; set; }
        public string LeaveTypeNameAr { get; set; }

        public virtual ICollection<EmployeeLeaveApplication> EmployeeLeaveApplications { get; set; }
        public virtual ICollection<LeaveTypeDay> LeaveTypeDays { get; set; }
    }
}
