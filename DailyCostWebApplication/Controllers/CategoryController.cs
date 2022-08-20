using DailyCostWebApplication.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DailyCostWebApplication.Controllers
{
    public class CategoryController : Controller
    {
        private readonly ICategoryRepository categoryRepository;

        public CategoryController(ICategoryRepository _categoryRepository)
        {
            categoryRepository = _categoryRepository;
        }

        public IActionResult Index()
        {
            var CatList = categoryRepository.GetAllCategories();
            return View(CatList);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Delete(IEnumerable<int> SelectedCatDelete)
        {

            var delList = categoryRepository.Delete(SelectedCatDelete);
            if(delList == null)
            {
                ViewBag.DelError = "Yes";
                ViewBag.DelTitle = "Delete operation has not been completed";
                ViewBag.DelMessage = "This record can not be deleted, beacuse one or more cost record use this category.";
                return View("Error");
            }
            return RedirectToAction("Index");
        }

    }
}
