using HR.entity;
using HR.entity.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HR.services.Implementation
{
    public class FamilyDetailsService : IFamilyDetailsService



    {


       private readonly AgriBookContext _context;

        public FamilyDetailsService(AgriBookContext context)
        {
            _context = context;
        }

        public Task CreateAsync(FamilyDetail familyDetail)
        {
            throw new NotImplementedException();
        }

        public Task DeleteFamilyDetail(int familyDetailId)
        {
            throw new NotImplementedException();
        }

        public List<FamilyDetail> GetAllFamilyDetail()
        {
            throw new NotImplementedException();
        }

        public Employee GetByFamilyDetailId(int familyDetailId)
        {
            throw new NotImplementedException();
        }

        public Task UpdateFamilyDetailAsync(FamilyDetail familyDetail, int Id)
        {
            throw new NotImplementedException();
        }

        public Task UpdateFamilyDetailAsync(int id)
        {
            throw new NotImplementedException();
        }
    }
}
