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
    public class MaritalStatusService : IMaritalStatusService
    {

        private readonly AgriBookContext _context;

        public MaritalStatusService( AgriBookContext context)
        {
            _context = context;
        }
        public List<MaritalStatus> GetAllMaritalStatus() => _context.MaritalStatuses.FromSqlRaw("spGetAllMaritalStatus").ToList();

    }
}
