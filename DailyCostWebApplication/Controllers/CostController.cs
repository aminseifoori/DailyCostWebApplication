using DailyCostWebApplication.Models;
using DailyCostWebApplication.ViewModels;
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
        private readonly IPaymentMethodRepository paymentMethodRepository;

        public CostController(ICostRepository _costRepository, IPaymentMethodRepository _paymentMethodRepository)
        {
            costRepository = _costRepository;
            paymentMethodRepository = _paymentMethodRepository;
        }
        //[Route("{id?}")]
        public IActionResult Detail(int? id)
        {
            CostDetailViewModel model = new CostDetailViewModel
            {
                CostData = costRepository.GetCostByID(id ?? 1),
                PageTitle = "Cost Detail"
            };
            //Cost model = costRepository.GetCostByID(1);
            //ViewBag.Cost = costRepository.GetCostByID(1);
            //ViewBag.PageTitle = "Cost Detail";
            //ViewData["Cost"] = costRepository.GetCostByID(1);
            //ViewData["PageTitle"] = "Cost Detail";
            return View(model);
        }
        public IActionResult List()
        {
            var model = costRepository.GetAllCost();
            return View(model);
        }
        public IActionResult Create()
        {
            List<SelectListItem> CatList = new List<SelectListItem>
               {
                   new SelectListItem{Text = "Grocery", Value = "Grocery", Selected=true },
                   new SelectListItem{Text = "Bill", Value = "Bill" },
                   new SelectListItem{Text = "Rent", Value = "Rent" },
                   new SelectListItem{Text = "Home Appliance", Value = "Home Appliance" },
               };
            ViewBag.category = CatList;

            return View();
        }
        [HttpGet]
        public IActionResult CreateStronglyTypedView()
        {
            List<SelectListItem> CatList = new()
            {
                new SelectListItem { Text = "Grocery", Value = "Grocery", Selected = true },
                new SelectListItem { Text = "Bill", Value = "Bill" },
                new SelectListItem { Text = "Rent", Value = "Rent" },
                new SelectListItem { Text = "Home Appliance", Value = "Home Appliance" },
            };
            CreateCostViewModel Model = new()
            {
                Amount = 100,
                Comment = "No Comment",
                Date = DateTime.Now,
                Categories = CatList,
                PaymentMethods = paymentMethodRepository.GetAll(),
                PaymentMethod = 3,
                MakeFormClear = false
            };

            return View(Model);
        }
        [HttpPost]
        public IActionResult CreateStronglyTypedView(CreateCostViewModel Model)
        {
            if (ModelState.IsValid)
            {
                CostRegisteredViewModel costRegistered = new()
                {
                    Amount = Model.Amount,
                    Comment = Model.Comment,
                    Date = Model.Date,
                    Category = Model.Category,
                    PaymentMethod = paymentMethodRepository.GetPaymentMethodbyID(Model.PaymentMethod),
                    WebSite = "https://www.goldencourses.net",
                    Email = "info@goldencourses.net",
                    CurrentTime = DateTime.Now
                };

                return View("View", costRegistered);
            }
            List<SelectListItem> CatList = new()
            {
                new SelectListItem { Text = "Grocery", Value = "Grocery", Selected = true },
                new SelectListItem { Text = "Bill", Value = "Bill" },
                new SelectListItem { Text = "Rent", Value = "Rent" },
                new SelectListItem { Text = "Home Appliance", Value = "Home Appliance" },
            };
            Model.Categories = CatList;
            Model.PaymentMethods = paymentMethodRepository.GetAll();
            return View(Model);
        }
        [HttpGet]
        public IActionResult Edit(int id)
        {
            var SelectCost = costRepository.GetCostByID(id);
            return View(SelectCost);
        }
        [HttpPost]
        public IActionResult Edit(Cost Model)
        {
            if (ModelState.IsValid)
            {
                //Post Process
            }
            return View(Model);
        }
    }
}
