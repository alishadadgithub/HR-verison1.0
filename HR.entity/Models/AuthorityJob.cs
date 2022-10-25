using System;
using System.Collections.Generic;

#nullable disable

namespace HR.entity.Models
{
    public partial class AuthorityJob
    {
        public int PkauthorityJobId { get; set; }
        public int FkauthotityId { get; set; }
        public int FkjobId { get; set; }
        public int AuthorityJobCount { get; set; }

        public virtual Authority Fkauthotity { get; set; }
        public virtual Job Fkjob { get; set; }
    }
}
