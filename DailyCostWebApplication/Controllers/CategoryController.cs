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
        public IActionResult Delete(IEnumerable<int> SelectedCatDelete)
        {

            categoryRepository.Delete(SelectedCatDelete);
            return RedirectToAction("Index");
        }

    }
}
