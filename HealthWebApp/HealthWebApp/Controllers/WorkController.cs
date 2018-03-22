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

 public IActionResult index()
 {
   List<Work> allWorks =  _work.Getall().ToList();
   
   return View();
 }
    // public IActionResult Index()
    // {
      
    //   return View();
    // }
  }
}
