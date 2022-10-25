using System;
using System.Collections.Generic;

#nullable disable

namespace HR.entity.Models
{
    public partial class Category
    {
        public Category()
        {
            EmployementDetails = new HashSet<EmployementDetail>();
            Jobs = new HashSet<Job>();
        }

        public int PkcategoryId { get; set; }
        public string CategoryName { get; set; }
        public int? CategoryNumber { get; set; }

        public virtual ICollection<EmployementDetail> EmployementDetails { get; set; }
        public virtual ICollection<Job> Jobs { get; set; }
    }
}
