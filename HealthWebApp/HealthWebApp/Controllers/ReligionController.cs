using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using HealthWebApp.Data.EntityModel;
using HealthWebApp.Data.Interface;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace HealthWebApp.Controllers {
  public class ReligionController : Controller {
    private IReligion _religion;
    public ReligionController (IReligion religion) {
      _religion = religion;
    }

    public IActionResult Index()
    {
      List<Religion> allReligion = _religion.Getall().ToList();
      return View(allReligion);
    }
    public IActionResult Details(int Id) {
      Religion religion = _religion.Get(Id);
      return View(religion);
    }

    [HttpGet]
    public IActionResult Create() 
    {
      Religion newReligion = new Religion();
      return View(newReligion);
    }

    [HttpPost]
    [ValidateAntiForgeryToken]
    public IActionResult Create(Religion newReligion) 
    {
      try 
      {
        if (ModelState.IsValid) 
        {
          _religion.Add(newReligion);
          return RedirectToAction("Index");
        }
        return View(newReligion);
      } 
      catch(Exception err) 
      {
        ModelState.AddModelError(err.ToString(), "Unable to save changes. Try again, and if the problem persists, see your system administrator.");
      }
      return View(newReligion);
    }

    [HttpGet]
    public IActionResult Edit(int Id) 
    {
      Religion religion = _religion.Get(Id);
      return View(religion);
    }

    [HttpPost]
    [ValidateAntiForgeryToken]
    public IActionResult Edit(Religion modifiedReligion) 
    {
        if (ModelState.IsValid) 
        {
          _religion.Update(modifiedReligion);
          return RedirectToAction("Index");
        }
        return View(modifiedReligion);
    }
  }
}