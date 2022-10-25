using HR.entity;
using HR.entity.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HR.services.Implementation
{
    public class AcademicQualificationService : IAcademicQualificationService
    {
        private readonly AgriBookContext _context;
        public AcademicQualificationService(AgriBookContext context)
        {
            _context = context;
        }
      
            public List<AcademicQualification> GetAllAcademicQualification() => _context.AcademicQualifications.FromSqlRaw("spGetAllAcademicQualifications").ToList();
        
    }
}
