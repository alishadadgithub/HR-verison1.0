using HR.entity.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HR.services
{
    public interface IAcademicQualificationService
    {
        List<AcademicQualification> GetAllAcademicQualification();
    }
}
