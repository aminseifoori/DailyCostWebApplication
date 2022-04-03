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
            var Categories = categoryRepository.GetAllCategories();
            List<SelectListItem> CatList = new();
            foreach (var category in Categories)
            {
                CatList.Add(new SelectListItem(category.CategoryName, category.ID.ToString()));
            }
            ViewBag.Categories = CatList;
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
            var Categories = categoryRepository.GetAllCategories();
            List<SelectListItem> CatList = new();
            foreach (var category in Categories)
            {
                CatList.Add(new SelectListItem(category.CategoryName, category.ID.ToString()));
            }
            ViewBag.Categories = CatList;
            return View();
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
            var Categories = categoryRepository.GetAllCategories();
            List<SelectListItem> CatList = new();
            foreach (var category in Categories)
            {
                CatList.Add(new SelectListItem(category.CategoryName, category.ID.ToString()));
            }
            ViewBag.Categories = CatList;
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
            var cost = costRepository.GetCostByID(model.ID);
            var Categories = categoryRepository.GetAllCategories();
            List<SelectListItem> CatList = new();
            foreach (var category in Categories)
            {
                CatList.Add(new SelectListItem(category.CategoryName, category.ID.ToString()));
            }
            ViewBag.Categories = CatList;
            return View(cost);
        }
        [HttpPost]
        public IActionResult Delete(int id)
        {
            costRepository.Delete(id);
            return RedirectToAction("index");
        }


    }
 
}
