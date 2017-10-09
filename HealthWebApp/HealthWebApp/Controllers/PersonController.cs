using System.Linq;
using HealthWebApp.Data.Interface;
using HealthWebApp.Models.Person;
using Microsoft.AspNetCore.Mvc;
using System.Net;
using HealthWebApp.Data.EntityModel;

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
            var allPersons = _person.Getall();
            var PersonModels = allPersons
                                .Select(p=>new PersonDetailModel
                                {
                                    Id = p.Id,
                                    FirstName = p.FirstName,
                                    MiddleName = p.MiddleName,
                                    LastName = p.LastName,
                                    ExtensionName = p.ExtensionName,
                                    NameTittle = p.NameTittle,
                                    DateOfBirth = p.DateOfBirth.ToString(),
                                    Sex = p.Sex.ToString(),
                                    ContactNumber = p.ContactNumber,
                                    HouseholdProfileId = p.HouseholdProfile.ProfileId
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
                NameTittle = patient.NameTittle,
                DateOfBirth = patient.DateOfBirth.ToString(),
                Sex = patient.Sex.ToString(),
                ContactNumber = patient.ContactNumber,
                HouseholdProfileId = patient.HouseholdProfile.ProfileId

            };
            return View(model);
        }
    }
}