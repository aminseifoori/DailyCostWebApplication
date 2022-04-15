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
        private readonly ICategoryRepository categoryRepository;

        public CostController(ICostRepository _costRepository, ICategoryRepository _categoryRepository)
        {
            costRepository = _costRepository;
            categoryRepository = _categoryRepository;
        }

        [HttpGet]
        public IActionResult Create()
        {
            LoadDropdownList();
            return View();
        }
        [HttpPost]
        public IActionResult Create(CreateCostViewModel model)
        {
            if (ModelState.IsValid)
            {
                Cost cost = new()
                {
                    Amount = model.Amount,
                    Comment = model.Comment,
                    RegisteredDate = model.RegisteredDate,
                    CategoryID = model.CategoryID,
                    PaymentMethod = model.PaymentMethod
                };
                costRepository.Create(cost);
                return RedirectToAction("Index");
            }
            LoadDropdownList();
            return View(model);
        }
        [HttpGet]
        public IActionResult Index()
        {
            var costs = costRepository.GetAllCost();
            return View(costs);
        }
        [HttpGet]
        public IActionResult Detail(int id)
        {
            var cost = costRepository.GetCostByID(id);
            return View(cost);
        }
        [HttpGet]
        public IActionResult Update(int id)
        {
            var cost = costRepository.GetCostByID(id);
            LoadDropdownList();
            return View(cost);
        }
        [HttpPost]
        public IActionResult Update(Cost model)
        {
            if (ModelState.IsValid)
            {
                costRepository.Update(model);
                return RedirectToAction("Index");
            }
            LoadDropdownList();
            return View(model);
        }
        [HttpPost]
        public IActionResult Delete(int id)
        {
            costRepository.Delete(id);
            return RedirectToAction("index");
        }
        private void LoadDropdownList()
        {
            var Categories = categoryRepository.GetAllCategories();
            List<SelectListItem> CatList = new();
            CatList.Add(new SelectListItem("Select a Category", "-1"));
            foreach (var category in Categories)
            {
                CatList.Add(new SelectListItem(category.CategoryName, category.ID.ToString()));
            }
            List<SelectListItem> PaymentList = new();
            PaymentList.Add(new SelectListItem("Select a Payment Method", ""));
            var PaymentMethod = Enum.GetValues(typeof(PaymentMethods)).Cast<PaymentMethods>().ToList();
            for (var i = 0; i < PaymentMethod.Count(); i++)
            {
                PaymentList.Add(new SelectListItem(PaymentMethod[i].ToString(), i.ToString()));
            }
            ViewBag.Categories = CatList;
            ViewBag.PaymentMethods = PaymentList;
        }


    }
 
}
