using DailyCostWebApplication.Models;
using DailyCostWebApplication.ViewModels;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using X.PagedList;

namespace DailyCostWebApplication.Controllers
{
    //[Route("[Controller]/[action]")]
    public class CostController : Controller
    {
        private readonly ICostRepository costRepository;
        private readonly ICategoryRepository categoryRepository;
        private readonly IWebHostEnvironment webHostEnvironment;

        public CostController(ICostRepository _costRepository, ICategoryRepository _categoryRepository, 
            IWebHostEnvironment _webHostEnvironment)
        {
            costRepository = _costRepository;
            categoryRepository = _categoryRepository;
            webHostEnvironment = _webHostEnvironment;
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
                if(model.UploadFile != null)
                {
                    cost.InvoiceImagePath = UploadFile(model.UploadFile);
                }
                costRepository.Create(cost);
                return RedirectToAction("Index");
            }
            LoadDropdownList();
            return View(model);
        }
        [HttpGet]
        public IActionResult Index(string searchby, string searchfor, int? page, string sortby)
        {
            //var costs = costRepository.GetAllCost();
            var costs = costRepository.GetCostList(searchby, searchfor,sortby).ToPagedList(page ?? 1, 5);
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
            UpdateCostViewModel model = new()
            {
                ID = cost.ID,
                Amount = cost.Amount,
                RegisteredDate = cost.RegisteredDate,
                Comment = cost.Comment,
                CategoryID = cost.CategoryID,
                PaymentMethod = cost.PaymentMethod,
                ExsitingFile = cost.InvoiceImagePath
            };
            LoadDropdownList();
            return View(model);
        }
        [HttpPost]
        public IActionResult Update(UpdateCostViewModel model)
        {
            if (ModelState.IsValid)
            {
                Cost UpdatedCost = costRepository.GetCostByID(model.ID);
                UpdatedCost.Amount = model.Amount;
                UpdatedCost.RegisteredDate = model.RegisteredDate;
                UpdatedCost.Comment = model.Comment;
                UpdatedCost.CategoryID = model.CategoryID;
                UpdatedCost.PaymentMethod = model.PaymentMethod;
                if(model.UploadFile != null)
                {
                    if(UpdatedCost.InvoiceImagePath != null)
                    {
                        string ExitingFile = Path.Combine(webHostEnvironment.WebRootPath, "images", UpdatedCost.InvoiceImagePath);
                        System.IO.File.Delete(ExitingFile);
                    }
                    UpdatedCost.InvoiceImagePath = UploadFile(model.UploadFile);
                }
                costRepository.Update(UpdatedCost);
                return RedirectToAction("Index");
            }
            LoadDropdownList();
            return View(model);
        }
        [HttpPost]
        public IActionResult Delete(int id)
        {
            Cost cost = costRepository.GetCostByID(id);
            if (cost.InvoiceImagePath != null)
            {
                string ExitingFile = Path.Combine(webHostEnvironment.WebRootPath, "images", cost.InvoiceImagePath);
                System.IO.File.Delete(ExitingFile);
            }
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
        private string UploadFile(IFormFile formFile)
        {
            string UniqueFileName = Guid.NewGuid().ToString() + "-" + formFile.FileName;
            string TargetPath = Path.Combine(webHostEnvironment.WebRootPath, "images", UniqueFileName);
            using (var stream = new FileStream(TargetPath, FileMode.Create))
            {
                formFile.CopyTo(stream);
            }
            return UniqueFileName;
        }


    }
 
}
