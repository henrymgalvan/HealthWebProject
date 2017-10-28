using HealthWebApp.Data.EntityModel;
using HealthWebApp.Data.Interface;
using HealthWebApp.Models.Person;
using Microsoft.AspNetCore.Mvc;
using System;
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
                                    ContactNumber = p.ContactNumber,
                                }).ToList();
            var model = new PersonIndexModel()
            {
                People = PersonModels
            };
            return View(model);
        }
        public IActionResult Details(int id)
        {
            Person person = _person.Get(id);

            var model = new PersonDetailModel()
            {
                Id = person.Id,
                FirstName = person.FirstName,
                MiddleName = person.MiddleName,
                LastName = person.LastName,
                ExtensionName = person.ExtensionName,
                NameTitle = person.NameTitle,
                DateOfBirth = person.DateOfBirth.ToString(),
                Sex = person.Sex.ToString(),
                ContactNumber = person.ContactNumber,
            };
            return View(model);
        }

        [HttpGet]
        public IActionResult Create()
        {
            PersonCreateModel newPerson = new PersonCreateModel();
            return View(newPerson);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(PersonCreateModel newPerson)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    if (newPerson.PersonConsent)
                    {
                        var person = new Person();
                        person.FirstName = newPerson.FirstName;
                        person.MiddleName = newPerson.MiddleName;
                        person.LastName = newPerson.LastName;
                        person.ExtensionName = newPerson.ExtensionName;
                        person.NameTitle = newPerson.NameTitle;
                        person.Sex = newPerson.Sex;
                        person.DateOfBirth = newPerson.DateOfBirth;
                        person.CivilStatus = newPerson.CivilStatus;
                        person.ContactNumber = newPerson.ContactNumber;
                        person.DateCreated = DateTime.Now;
                        person.DateTimeLastUpdated = person.DateCreated;
                        person.PersonConsent = newPerson.PersonConsent;

                        _person.Add(person);
                        return RedirectToAction("Index");
                    }
                    return View(newPerson);
                }
            }
            catch (Exception err)
            {
                ModelState.AddModelError(err.ToString(), "Unable to save changes. Try again, and if the problem persists, see your system administrator.");
            }
            return View(newPerson);
        }

        [HttpGet]
        public IActionResult Edit(int Id)
        {
            Person person = _person.Get(Id);
            var model = new PersonEditModel()
            {
                Id = person.Id,
                FirstName = person.FirstName,
                MiddleName = person.MiddleName,
                LastName = person.LastName,
                ExtensionName = person.ExtensionName,
                NameTitle = person.NameTitle,
                DateOfBirth = person.DateOfBirth,
                Sex = person.Sex,
                ContactNumber = person.ContactNumber,
            };
            return View(model);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(PersonEditModel editPerson)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    var UpdatedPerson = new Person();
                    UpdatedPerson.Id = editPerson.Id;
                    UpdatedPerson.FirstName = editPerson.FirstName;
                    UpdatedPerson.MiddleName = editPerson.MiddleName;
                    UpdatedPerson.LastName = editPerson.LastName;
                    UpdatedPerson.ExtensionName = editPerson.ExtensionName;
                    UpdatedPerson.NameTitle = editPerson.NameTitle;
                    UpdatedPerson.Sex = editPerson.Sex;
                    UpdatedPerson.DateOfBirth = editPerson.DateOfBirth;
                    UpdatedPerson.CivilStatus = editPerson.CivilStatus;
                    UpdatedPerson.ContactNumber = editPerson.ContactNumber;
                    UpdatedPerson.DateTimeLastUpdated = DateTime.Now;
                    _person.Update(UpdatedPerson);
                        return RedirectToAction("Index");
                }
                return View(editPerson);
            }
            catch (Exception err)
            {
                ModelState.AddModelError(err.ToString(), "Unable to save changes. Try again, and if the problem persists, see your system administrator.");
            }
            return View(editPerson);
        }
    }
}