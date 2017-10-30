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
        private IBarangay _barangay;

        public HouseholdProfileController(IHouseholdProfile householdProfile, IBarangay barangay)
        {
            _householdProfile = householdProfile;
            _barangay = barangay;
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

        [HttpGet]
        public IActionResult Create()
        {
            List<Barangay> barangaylist = new List<Barangay>();
            barangaylist = (from barangay in _barangay.GetAll() select barangay).ToList();
            barangaylist.Insert(0, new Barangay { Id = 0, Name = "Select" });
            ViewBag.ListOfBarangay = barangaylist;
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(HouseholdProfileCreateModel householdProfileCreateModel)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    var householdProfile = new HouseholdProfile();
                    householdProfile.ProfileId = householdProfileCreateModel.ProfileId;
                    householdProfile.Address = householdProfileCreateModel.Address;
                    householdProfile.BarangayId = householdProfileCreateModel.BarangayId;
                    householdProfile.Note = householdProfileCreateModel.Note;
                    householdProfile.DateCreated = DateTime.Now;
                    householdProfile.DateTimeLastUpdated = householdProfile.DateCreated;

                    _householdProfile.Add(householdProfile);
                    return RedirectToAction("Index");
                }
                return View(householdProfileCreateModel);
            }
            catch (Exception err)
            {
                ModelState.AddModelError(err.ToString(), "Unable to save changes. Try again, and if the problem persists, see your system administrator.");
            }
            return View(householdProfileCreateModel);
        }

        //[HttpGet]
        //public IActionResult Edit(HouseholdProfileEditModel householdProfileEditModel)
        //{
        //    List<Barangay> barangaylist = new List<Barangay>();
        //    barangaylist = (from barangay in _barangay.GetAll() select barangay).ToList();
        //    barangaylist.Insert(0, new Barangay { Id = 0, Name = "Select" });
        //    ViewBag.ListOfBarangay = barangaylist;

        //    return View(householdProfileEditModel);
        //}

        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public IActionResult Edit(HouseholdProfileEditModel householdProfileEditModel)
        //{

        //}
    }
}