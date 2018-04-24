using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using HealthWebApp.Data.Interface;
using HealthWebApp.Data.EntityModel;
using HealthWebApp.Data.EntityModel.PhilHealthFolder;
using HealthWebApp.Models.PhilHealth;

namespace HealthWebApp.Controllers
{
    public class PhilHealthController : Controller
    {
        private IPerson _person;
        private IPhilHealth _philHealth;

        public PhilHealthController(IPhilHealth philHealth, IPerson person)
        {
            _person = person;
            _philHealth = philHealth;
        }
        public IActionResult Index()
        {
            List<Person> allPersons = _person.Getall().ToList();
            List<PhilHealth> allPhilHealth = _philHealth.Getall().ToList();
            return View();
        }
        public IActionResult Details(long Id)
        {
            Person PhilHealthMember = _person.Get(Id);
            PhilHealth PhilHealthDetail = _philHealth.Get(Id);


            return View();

        }
        [HttpGet]
        public IActionResult Create()
        {

            return View();
        }
        [HttpPost]
        public IActionResult Create(PhilHealthEditModel createPhilHealth)
        {

            return Index();
        }
        [HttpGet]
        public IActionResult Edit()
        {

            return View();
        }
        [HttpPost]
        public IActionResult Edit(PhilHealthEditModel editPhilHealth)
        {

            return Index();
        }


    }   
}