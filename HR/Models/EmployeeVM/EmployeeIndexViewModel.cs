using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace HR.Models.EmployeeVM
{
    public class EmployeeIndexViewModel
    {
        public int PkemployeeId { get; set; }
        public string EmployeeFirstName { get; set; }

        public string EmployeeLastName { get; set; }

        [DataType(DataType.Date)]
        public DateTime EmployeeDateOfBirth { get; set; }
        public string EmployeePhoneNumber { get; set; }

        public string EmployeeFinancialNumber { get; set; }
        public string EmployeeImageName { get; set; }



    }
}
