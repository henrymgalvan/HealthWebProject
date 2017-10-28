using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using HealthWebApp.Data.Interface;
using HealthWebApp.Data.EntityModel;
using HealthWebApp.Models.HouseholdProfile;

namespace HealthWebApp.Controllers
{
    public class HouseholdProfileController : Controller
    {
        private IHouseholdProfile _householdProfile;
        public HouseholdProfileController(IHouseholdProfile householdProfile)
        {
            _householdProfile = householdProfile;
        }
        public IActionResult Index()
        {
            IEnumerable<HouseholdProfile> listOfHousehold = _householdProfile.GetAll();
            IEnumerable<HouseholdProfileDetailModel> householdModels = listOfHousehold
                .Select(h => new HouseholdProfileDetailModel
                {
                    Id = h.Id,
                    ProfileId = h.ProfileId,
                    Address = h.Address,
                    Barangay = h.Barangay.Name,
                    Note = h.Note
                }).ToList();
            var model = new HouseholdProfileIndexModel()
            {
                Households = householdModels
            };
            return View(model);
        }
    }
}