using System;
using System.Collections.Generic;

#nullable disable

namespace HR.entity.Models
{
    public partial class CenterJob
    {
        public int PkcenterJobId { get; set; }
        public int FkcenterId { get; set; }
        public int FkjobId { get; set; }
        public int CenterJobCount { get; set; }

        public virtual Center Fkcenter { get; set; }
        public virtual Job Fkjob { get; set; }
    }
}
