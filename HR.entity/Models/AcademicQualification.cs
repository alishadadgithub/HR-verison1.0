using System;
using System.Collections.Generic;

#nullable disable

namespace HR.entity.Models
{
    public partial class AcademicQualification
    {
        public AcademicQualification()
        {
            Employees = new HashSet<Employee>();
        }

        public int PkacademicQualificationId { get; set; }
        public string AcademicQualificationType { get; set; }

        public virtual ICollection<Employee> Employees { get; set; }
    }
}
