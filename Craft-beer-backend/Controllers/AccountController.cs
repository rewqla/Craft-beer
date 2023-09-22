using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Craft_beer_backend.Entities;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Craft_beer_backend.Controllers
{
    public class AccountController : Controller
    {
        private readonly UserManager<DbUser> userManager;
        private readonly SignInManager<DbUser> signInManager;

        public AccountController(UserManager<DbUser> userManager, SignInManager<DbUser> signInManager)
        {
            this.userManager = userManager;
            this.signInManager = signInManager;
        }
        [HttpGet]
        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Register(ViewModels.RegisterViewModel Model)
        {
            if (ModelState.IsValid)
            {
                var user = new DbUser()
                {
                    UserName = Model.Email,
                    Email = Model.Email
                };

                var result = await userManager.CreateAsync(user, Model.Password);
                if (result.Succeeded)
                {
                    await signInManager.SignInAsync(user, false);
                    return RedirectToAction("Index", "Home");
                }
                foreach (var error in result.Errors)
                {
                    ModelState.AddModelError("", error.Description);
                }
            }
            return View();
        }


        [HttpGet]
        public IActionResult Login()
        {
            string ReturnUrl = HttpContext.Request.Query["ReturnUrl"];
            TempData["ReturnUrl"] = ReturnUrl;
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Login(ViewModels.LoginViewModel Model)
        {
            if (ModelState.IsValid)
            {
                var identityResult = await signInManager.PasswordSignInAsync(Model.Email, Model.Password, Model.RememberMe, false);

                if (identityResult.Succeeded)
                {
                    if (Model.ReturnUrl == null || Model.ReturnUrl == "/")
                        return RedirectToAction("Index", "Home");
                    else
                        return Redirect(Model.ReturnUrl);

                }
                ModelState.AddModelError("", "ім'я або пароль невірні");
            }
            return View();
        }


        [HttpGet]
        public IActionResult Logout(string returnUrl = null)
        {
            if (string.IsNullOrEmpty(returnUrl))
            {
                returnUrl = HttpContext.Request.Path;
            }
            ViewBag.returnUrl = returnUrl;
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Logout()
        {

            await signInManager.SignOutAsync();
            return RedirectToAction("Index", "Home");
        }





        public async Task<IActionResult> ListUsers()
        {
            var users = userManager.Users;
            return View(users);
        }

        //[HttpGet]
        //public async Task<IActionResult> EditUser(string id)
        //{
        //    var user = await userManager.FindByIdAsync(id);

        //    if (user == null)
        //    {
        //        ViewBag.ErrorMessage = $"Користувача з id = {id} не знайдено";
        //        return View("NotFound");
        //    }

        //    var model = new EditUserViewModel
        //    {
        //        Id = user.Id,
        //        UserName = user.UserName,
        //        Email = user.Email,
        //        PhoneNumber = user.PhoneNumber
        //    };

        //    return View(model);
        //}


        //[HttpPost]
        //public async Task<IActionResult> EditUser(EditUserViewModel model)
        //{
        //    var user = await userManager.FindByIdAsync(model.Id);

        //    if (user == null)
        //    {
        //        ViewBag.ErrorMessage = $"Користувача з id = {model.Id} не знайдено";
        //        return View("NotFound");
        //    }
        //    else
        //    {
        //        user.UserName = model.UserName;
        //        user.Email = model.Email;
        //        user.PhoneNumber = model.UserName;
        //        if (model.Password != null)
        //            if (model.Password.Replace(" ", "") != "")
        //                user.PasswordHash = userManager.PasswordHasher.HashPassword(user, model.Password);


        //        var result = await userManager.UpdateAsync(user);

        //        if (result.Succeeded)
        //        { return RedirectToAction("ListUsers"); }

        //        foreach (var error in result.Errors)
        //        {
        //            ModelState.AddModelError("", error.Description);
        //        }
        //    }

        //    return View(model);
        //}

        public async Task<IActionResult> DeleteUser(string Id)
        {
            var role = await userManager.FindByIdAsync(Id);

            if (role != null)
            {
                var result = await userManager.DeleteAsync(role);
                if (result.Succeeded)
                {
                    return RedirectToAction("ListUsers");
                }
                else
                {
                    ViewBag.ErrorMessage = $"При спробі видалити користувача, виникла проблема з базою даних";
                    return View("NotFound");
                }
            }
            ViewBag.ErrorMessage = $"Користувача з id = {Id} не знайдено";
            return View("NotFound");
        }


    }
}
