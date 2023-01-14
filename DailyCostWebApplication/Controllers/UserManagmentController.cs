using DailyCostWebApplication.ViewModels;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace DailyCostWebApplication.Controllers
{
    public class UserManagmentController : Controller
    {
        private readonly UserManager<IdentityUser> userManger;

        public UserManagmentController(UserManager<IdentityUser> _userManger)
        {
            userManger = _userManger;
        }
        [HttpGet]
        public IActionResult CreateUser()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> CreateUser(CreateUserViewModel createUserViewModel)
        {
            if (ModelState.IsValid)
            {
                IdentityUser user = 
                    new IdentityUser { UserName = createUserViewModel.Email, Email = createUserViewModel.Email };
                var result = await userManger.CreateAsync(user, createUserViewModel.Password);
                if (result.Succeeded)
                {
                    ViewBag.RegisteredResult = "Yes";
                    ModelState.Clear();
                }
                else
                {
                    ViewBag.RegisteredResult = "No";
                    foreach(var error in result.Errors)
                    {
                        ModelState.AddModelError("Validation", error.Description);
                    }
                }
            }
            return View();
        }
    }
}
