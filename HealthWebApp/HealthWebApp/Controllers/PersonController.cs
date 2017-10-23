using HealthWebApp.Data.EntityModel;
using HealthWebApp.Data.Interface;
using HealthWebApp.Models.Person;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

namespace HealthWebApp.Controllers
{
    public class PersonController : Controller
    {
        private IPerson _person;
        public PersonController(IPerson person)
        {
            _person = person;
        }

        public IActionResult Index()
        {
            IEnumerable<Person> allPersons = _person.Getall();

            IEnumerable<PersonDetailModel> PersonModels = allPersons
                                .Select(p => new PersonDetailModel
                                {
                                    Id = p.Id,
                                    FirstName = p.FirstName,
                                    MiddleName = p.MiddleName,
                                    LastName = p.LastName,
                                    ExtensionName = p.ExtensionName,
                                    NameTitle = p.NameTitle,
                                    DateOfBirth = p.DateOfBirth.ToString(),
                                    Sex = p.Sex.ToString(),
                                    CivilStatus = p.CivilStatus.ToString(),
                                    Address = p.HouseholdProfile?.Address,
                                    Barangay = p.HouseholdProfile?.Barangay.Name,
                                    ContactNumber = p.ContactNumber,
                                    HouseholdProfileId = p.HouseholdProfile?.ProfileId
                                }).ToList();
            var model = new PersonIndexModel()
            {
                People = PersonModels
            };
            return View(model);
        }

        public IActionResult Details(int id)
        {
            Person patient = _person.Get(id);

            var model = new PersonDetailModel()
            {
                Id = patient.Id,
                FirstName = patient.FirstName,
                MiddleName = patient.MiddleName,
                LastName = patient.LastName,
                ExtensionName = patient.ExtensionName,
                NameTitle = patient.NameTitle,
                DateOfBirth = patient.DateOfBirth.ToString(),
                Sex = patient.Sex.ToString(),
                Address = patient.HouseholdProfile.Address,
                Barangay = patient.HouseholdProfile.Barangay.Name,
                ContactNumber = patient.ContactNumber,
                HouseholdProfileId = patient.HouseholdProfile.ProfileId

            };
            return View(model);
        }

        [HttpGet]
        public IActionResult Create()
        {
            PersonCreateModel newPerson = new PersonCreateModel();
            return View(newPerson);
         }
    }
}