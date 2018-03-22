using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using HealthWebApp.Data.EntityModel;
using HealthWebApp.Data.Interface;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace HealthWebApp.Controllers
{
  public class WorkController : Controller
  {
    private IWork _work;
    private IMapper _mapper;
    public WorkController(IWork work, IMapper mapper )
    {
      _work = work;
      _mapper = mapper;
    }

        public IActionResult Index
        {
            get
            {
                List<Work> allWorks = _work.Getall().ToList();
                return View();
            }
        }
      public IActionResult Details(int id)
      {
        //TODO: Implement Realistic Implementation
        return View();
      }

      [HttpGet]
      public IActionResult Create()
      {
        Work newWork = new Work();
        return View(newWork);
      }

      [HttpPost]
      [ValidateAntiForgeryToken]
      public IActionResult Create(Work newWork)
      {
        try
        {
          if (ModelState.IsValid)
          {
            _work.Add(newWork);
            return RedirectToAction("Index");
          }
          return View(newWork);
        }
        catch (Exception err)
        {
          ModelState.AddModelError(err.ToString(), "Unable to save changes. Try again, and if the problem persists, see your system administrator.");
        }
        return View(newWork);
      }

      [HttpGet]
      public IActionResult Edit(int id )
      {
        Work work = _work.Get(id);
        return View(work);
      }

      [HttpPost]
      [ValidateAntiForgeryToken]
      public IActionResult Edit(Work modifiedWork)
      {
        try
        {
          if (ModelState.IsValid)
          {
            _work.Update(modifiedWork);
            return RedirectToAction("Index");
          }
          return View(modifiedWork);
        }
        return View();
      }
    }
}
