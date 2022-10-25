using HR.services;
using Microsoft.AspNetCore.Mvc;

namespace HR.Controllers
{
    public class FamilyDetailsController : Controller
    {
        private readonly IFamilyDetailsService _familyDetailsService;

        public FamilyDetailsController(IFamilyDetailsService familyDetailsService)
        {
            _familyDetailsService = familyDetailsService;
        }


        public IActionResult Index()
        {
            return View();
        }


        
        public IActionResult Create()
        {

            return View();
        }
    }
}