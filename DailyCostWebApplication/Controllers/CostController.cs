using DailyCostWebApplication.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DailyCostWebApplication.Controllers
{
    //[Route("[Controller]/[action]")]
    public class CostController : Controller
    {
        private readonly ICostRepository costRepository;

        public CostController(ICostRepository _costRepository)
        {
            costRepository = _costRepository;
        }
    }
 
}
