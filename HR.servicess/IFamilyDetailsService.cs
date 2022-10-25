using HR.entity.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HR.services
{
    public  interface IFamilyDetailsService
    {

        Task CreateAsync(FamilyDetail familyDetail);

        Employee GetByFamilyDetailId(int familyDetailId);

        Task UpdateFamilyDetailAsync(FamilyDetail  familyDetail, int Id);

        Task UpdateFamilyDetailAsync(int id);

        Task DeleteFamilyDetail(int familyDetailId);

        List<FamilyDetail> GetAllFamilyDetail();
    }
}
