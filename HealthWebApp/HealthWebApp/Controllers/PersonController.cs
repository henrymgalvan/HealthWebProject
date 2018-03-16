using HealthWebApp.Data.EntityModel;
using HealthWebApp.Data.Interface;
using HealthWebApp.Models.Person;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using AutoMapper;

namespace HealthWebApp.Controllers
{
    public class PersonController : Controller
    {
        private IPerson _person;
        private IMapper _mapper;

        public PersonController(IPerson person, IMapper mapper)
        {
            _person = person;
            _mapper = mapper;
        }

        public IActionResult Index()
        {
            List<Person> allPersons = _person.Getall().ToList();
            IEnumerable<PersonDetailModel> PersonModels;

 //           if (allPersons.Any())
 //           {
                PersonModels = Mapper.Map<List<Person>, List<PersonDetailModel>>(allPersons);
                var model = new PersonIndexModel()
                {
                    People = PersonModels
                };
                return View(model);
 //           }
 //           return RedirectToAction("Index", "Home");
        }


        public IActionResult Details(int id)
        {
            Person person = _person.Get(id);
            if (person != null)
            {
                var model = Mapper.Map<Person, PersonDetailModel>(person);
                return View(model);
            }

            //var model = new PersonDetailModel()
            //{
            //    Id = person.Id,
            //    FirstName = person.FirstName,
            //    MiddleName = person.MiddleName,
            //    LastName = person.LastName,
            //    ExtensionName = person.ExtensionName,
            //    NameTitle = person.NameTitle,
            //    DateOfBirth = person.DateOfBirth.ToString("yyyy, MMM-dd"),
            //    Sex = person.Sex.ToString(),
            //    ContactNumber = person.ContactNumber,
            //};
            return RedirectToAction("Index", "Home");

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
                        person.NameTitleId = newPerson.NameTitleId;
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
                NameTitle = person.NameTitleId.ToString(),
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
                    UpdatedPerson.NameTitleId = editPerson.NameTitleId;
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

        //[HttpGet]
        //public IActionResult Delete(int id)
        //{
        //    Person person = _person.Get(id);
        //    if (person != null)
        //    {

        //        ViewBag["FullName"] = person.FirstName + " " + person.MiddleName + " " + person.LastName;
        //        return View(ViewBag);
        //    } else
        //    {
        //        return View("ErrorDelete");
        //    }
        //}
    }
}