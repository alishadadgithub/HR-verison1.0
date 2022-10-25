using System;
using System.Collections.Generic;

#nullable disable

namespace HR.entity.Models
{
    public partial class Employee
    {
        public Employee()
        {
            CareerProgressions = new HashSet<CareerProgression>();
            EmployeeLeaveApplications = new HashSet<EmployeeLeaveApplication>();
            EmployementDetails = new HashSet<EmployementDetail>();
            FamilyDetails = new HashSet<FamilyDetail>();
        }

        public int PkemployeeId { get; set; }
        public string EmployeeFirstName { get; set; }
        public string EmployeeMiddleName { get; set; }
        public string EmployeeLastName { get; set; }
        public DateTime? EmployeeDateOfBirth { get; set; }
        public string EmployeePhoneNumber { get; set; }
        public string EmployeeFinancialNumber { get; set; }
        public int? EmployeeAutomatedNumber { get; set; }
        public string EmployeeImageUrl { get; set; }
        public int? EmployeeTaxNumber { get; set; }
      
        public int? FkacademicQualificationId { get; set; }
        public int? FkmaritalStatusId { get; set; }

        public virtual AcademicQualification FkacademicQualification { get; set; }
        public virtual MaritalStatus FkmaritalStatus { get; set; }
        public virtual ICollection<CareerProgression> CareerProgressions { get; set; }
        public virtual ICollection<EmployeeLeaveApplication> EmployeeLeaveApplications { get; set; }
        public virtual ICollection<EmployementDetail> EmployementDetails { get; set; }
        public virtual ICollection<FamilyDetail> FamilyDetails { get; set; }
    }
}
