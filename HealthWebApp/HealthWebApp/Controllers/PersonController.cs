using System.Linq;
using HealthWebApp.Data.Interface;
using HealthWebApp.Models.Person;
using Microsoft.AspNetCore.Mvc;

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
    }
}