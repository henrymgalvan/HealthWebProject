using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using HealthWebApp.Data.Interface;
using HealthWebApp.Data.EntityModel;
using HealthWebApp.Models.HouseholdMember;
using HealthWebApp.Data.EntityModel.Household;

namespace HealthWebApp.Controllers
{
    public class HouseholdMemberController : Controller
    {
        private IHouseholdMember _householdMember;
        private IPerson _person;
        private IHouseholdProfile _householdProfile;

        public HouseholdMemberController(IHouseholdMember householdMember, IPerson person, IHouseholdProfile householdProfile)
        {
            _householdMember = householdMember;
            _person = person;
            _householdProfile = householdProfile;
        }
        public IActionResult Index()
        {
            IEnumerable<HouseholdMember> allMembers = _householdMember.GetAll();
            IEnumerable<HouseholdMemberDetailModel> HouseholdMembersModel = allMembers
                .Select(hm => new HouseholdMemberDetailModel
                {
                    Id = hm.PersonId,
                    FullName = hm.Person.FullName,
                    Sex = hm.Person.Sex.ToString(),
                    RelationToHead = hm.RelationToHead.ToString(),
                    YearsOld = hm.Person.DateOfBirth.Year,
                    MonthsOld = hm.Person.DateOfBirth.Month,
                    DaysOld = hm.Person.DateOfBirth.Day
                }).ToList();
            var model = new HouseholdMembersIndexModel()
            {
                Members = HouseholdMembersModel
            };
            return View(model);
        }

        public IActionResult Details(long id)
        {
            HouseholdMember member = _householdMember.Get(id);

            var model = new HouseholdMemberDetailModel()
            {
                Id = member.PersonId,
                FullName = member.Person.FullName,
                Sex = member.Person.Sex.ToString(),
                RelationToHead = member.RelationToHead.ToString(),
                YearsOld = member.Person.DateOfBirth.Year,
                MonthsOld = member.Person.DateOfBirth.Month,
                DaysOld = member.Person.DateOfBirth.Day,
            };

            return View(model);
        }

        [HttpGet]
        public IActionResult Create()
        {
            List<Person> personList = new List<Person>();
            personList = (from person in _person.Getall() select person).ToList();
            personList.Insert(0, new Person { Id = 0, LastName = "Select" });
            ViewBag.ListOfPerson = personList;

            List<HouseholdProfile> householdProfileList = new List<HouseholdProfile>();
            householdProfileList = (from household in _householdProfile.GetAll() select household).ToList();
            householdProfileList.Insert(0, new HouseholdProfile { Id = 0, ProfileId = "Select Profile" });
            ViewBag.ListOfHouseholdProfile = householdProfileList;

            return View();
        }

        [HttpPost]
        public IActionResult Create(HouseholdMemberCreateModel householdMemberCreateModel)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    var householdMember = new HouseholdMember();
                    householdMember.HouseholdProfileId = householdMemberCreateModel.HouseholdProfileId;
                    householdMember.PersonId = householdMemberCreateModel.PersonId;
                    householdMember.RelationToHead = householdMemberCreateModel.RelationToHouseholdHead;

                    _householdMember.Add(householdMember);
                    return RedirectToAction("Index");
                }
                return View(householdMemberCreateModel);

            }
            catch (Exception err)
            {
                ModelState.AddModelError(err.ToString(), "Unable to save changes. Try again, and if the problem persists, see your system administrator.");
            }
            return View(householdMemberCreateModel);

        }
    }
}