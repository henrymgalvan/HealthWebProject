using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using HealthWebApp.Data.Interface;
using HealthWebApp.Data.EntityModel;
using HealthWebApp.Models.HouseholdProfile;
using HealthWebApp.Models.HouseholdMember;
using HealthWebApp.Data.EntityModel.Barangays;
using HealthWebApp.Data.EntityModel.Household;

namespace HealthWebApp.Controllers
{
    public class HouseholdProfileController : Controller
    {
        private IHouseholdProfile _householdProfile;
        private IBarangay _barangay;
        private IHouseholdMember _householdMembers;

        public HouseholdProfileController(IHouseholdProfile householdProfile, IBarangay barangay, IHouseholdMember householdMembers)
        {
            _householdProfile = householdProfile;
            _barangay = barangay;
            _householdMembers = householdMembers;
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

        [HttpGet]
        public IActionResult Edit(int id)
        {
            HouseholdProfile household = _householdProfile.GetById(id);

            List<Barangay> barangaylist = new List<Barangay>();
            barangaylist = (from barangay in _barangay.GetAll() select barangay).ToList();
            barangaylist.Insert(0, new Barangay { Id = 0, Name = "Select" });
            ViewBag.ListOfBarangay = barangaylist;

            var householdProfileEditModel = new HouseholdProfileEditModel()
            {
                Id = household.Id,
                ProfileId = household.ProfileId,
                Address = household.Address,
                BarangayId = household.BarangayId,
                Note = household.Note
            };

            return View(householdProfileEditModel);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(HouseholdProfileEditModel householdProfileEditModel)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    var updatedHousehold = new HouseholdProfile();
                    updatedHousehold.Id = householdProfileEditModel.Id;
                    updatedHousehold.ProfileId = householdProfileEditModel.ProfileId;
                    updatedHousehold.Address = householdProfileEditModel.Address;
                    updatedHousehold.BarangayId = householdProfileEditModel.BarangayId;
                    updatedHousehold.Note = householdProfileEditModel.Note;

                    _householdProfile.Update(updatedHousehold);
                    return RedirectToAction("Index");
                }
                return View(householdProfileEditModel);
            }
            catch (Exception err)
            {
                ModelState.AddModelError(err.ToString(), "Unable to save changes. Try again, and if the problem persists, see your system administrator.");
            }
            return View(householdProfileEditModel);

        }

        [HttpGet]
        public IActionResult Details(long id)
        {
            HouseholdProfile household = _householdProfile.GetById(id);
            List<HouseholdMember> members = _householdMembers.GetAllByHouseholdProfileId(household.Id).ToList();
            IEnumerable<HouseholdMemberDetailModel> householdMembersDetailModel = members
                .Select(hm => new HouseholdMemberDetailModel
                {
                    Id = hm.PersonId,
                    FullName = hm.Person.FirstName + " " + hm.Person.MiddleName + " " + hm.Person.LastName,
                    Sex = hm.Person.Sex.ToString(),
                    RelationToHead = hm.RelationToHead.ToString(),
                    YearsOld = 0,
                    MonthsOld = 0,
                    DaysOld = 0
                }).ToList();

            var model = new HouseholdProfileDetailModel()
            {
                Id = household.Id,
                ProfileId = household.ProfileId,
                Address = household.Address,
                Barangay = household.Barangay.Name,
                Note = household.Note,
                HouseholdMembers = householdMembersDetailModel
            };

            return View(model);
        }
    }
}