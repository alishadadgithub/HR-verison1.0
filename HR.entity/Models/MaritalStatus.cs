using System;
using System.Collections.Generic;

#nullable disable

namespace HR.entity.Models
{
    public partial class MaritalStatus
    {
        public MaritalStatus()
        {
            Employees = new HashSet<Employee>();
        }

        public int PkmaritalStatusId { get; set; }
        public string MaritalStatusType { get; set; }

        public virtual ICollection<Employee> Employees { get; set; }
    }
}
