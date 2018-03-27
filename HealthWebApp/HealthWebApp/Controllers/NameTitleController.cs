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
  public class NameTitleController : Controller {
    private INameTitle _nameTitle;
    public NameTitleController (INameTitle nameTitle) 
    {
      _nameTitle = nameTitle;
    }

    public IActionResult Index()
    {
      List<NameTitle> allNameTitles = _nameTitle.Getall().ToList();
      return View(allNameTitles);
    }

    public IActionResult Details(int id) 
    {
      NameTitle nameTitle = _nameTitle.Get(id);
      return View(nameTitle);
    }

    [HttpGet]
    public IActionResult Create() 
    {
      NameTitle newNameTitle = new NameTitle();
      return View(newNameTitle);
    }

    [HttpPost]
    [ValidateAntiForgeryToken]
    public IActionResult Create(NameTitle newNameTitle) 
    {
      try 
      {
        if (ModelState.IsValid) 
        {
          _nameTitle.Add(newNameTitle);
          return RedirectToAction("Index");
        }
        return View(newNameTitle);
      } 
      catch(Exception err) 
      {
        ModelState.AddModelError(err.ToString(), "Unable to save changes. Try again, and if the problem persists, see your system administrator.");
      }
      return View(newNameTitle);
    }

    [HttpGet]
    public IActionResult Edit(int id) 
    {
      NameTitle nameTitle = _nameTitle.Get(id);
      return View(nameTitle);
    }

    [HttpPost]
    [ValidateAntiForgeryToken]
    public IActionResult Edit(NameTitle modifiedNameTitle) 
    {
        if (ModelState.IsValid) 
        {
          _nameTitle.Update(modifiedNameTitle);
          return RedirectToAction("Index");
        }
        return View(modifiedNameTitle);
    }
  }
}