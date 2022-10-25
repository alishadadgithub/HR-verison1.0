using System;
using System.Collections.Generic;

#nullable disable

namespace HR.entity.Models
{
    public partial class Center
    {
        public Center()
        {
            CenterJobs = new HashSet<CenterJob>();
        }

        public int PkcenterId { get; set; }
        public string CenterNameEn { get; set; }
        public string CenterNameAr { get; set; }
        public int FksectionId { get; set; }

        public virtual Section Fksection { get; set; }
        public virtual ICollection<CenterJob> CenterJobs { get; set; }
    }
}
