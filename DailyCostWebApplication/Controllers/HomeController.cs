using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DailyCostWebApplication.Controllers
{
    //[Route("[controller]/[action]")]
    public class HomeController : Controller
    {
        //[Route("")]
        //[Route("~/")]
        //[Route("~/Home")]
        public IActionResult Index()
        {
            //throw new Exception("Some Error Happened");
            return View();
        }

    }
}
