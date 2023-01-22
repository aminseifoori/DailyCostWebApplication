using DailyCostWebApplication.ViewModels;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace DailyCostWebApplication.Controllers
{
    public class UserManagmentController : Controller
    {
        private readonly UserManager<IdentityUser> userManger;
        private readonly SignInManager<IdentityUser> signInManager;

        public UserManagmentController(UserManager<IdentityUser> _userManger, SignInManager<IdentityUser> _signInManager)
        {
            userManger = _userManger;
            signInManager = _signInManager;
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

        [HttpGet]
        public IActionResult SignIn()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> SignIn(SignInViewModel signIn)
        {
            if (ModelState.IsValid)
            {
                var result = await signInManager.PasswordSignInAsync(signIn.Email, signIn.Password, signIn.RememberMe, false);
                if(result.Succeeded)
                {
                    return RedirectToAction("Index", "Home");
                }
                ModelState.AddModelError("", "UserName or Password is incorrect");
            }
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> SignOut()
        {
            await signInManager.SignOutAsync();
            return RedirectToAction("Index", "Home");
        }
    }
}
