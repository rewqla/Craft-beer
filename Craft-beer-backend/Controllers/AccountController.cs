using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Craft_beer_backend.Entities;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Craft_beer_backend.ViewModels;
using Microsoft.AspNetCore.Authorization;

namespace Craft_beer_backend.Controllers
{
    public class AccountController : Controller
    {
        private readonly UserManager<DbUser> userManager;
        private readonly SignInManager<DbUser> signInManager;
        private readonly RoleManager<DbRole> roleManager;

        public AccountController(UserManager<DbUser> userManager, SignInManager<DbUser> signInManager, RoleManager<DbRole> roleManager)
        {
            this.userManager = userManager;
            this.signInManager = signInManager;
            this.roleManager = roleManager;
        }
        [HttpGet]
        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Register(RegisterViewModel Model)
        {
            if (ModelState.IsValid)
            {
                var user = new DbUser()
                {
                    UserName = Model.Email,
                    Email = Model.Email,
                };

                var result = await userManager.CreateAsync(user, Model.Password);
                if (result.Succeeded)
                {
                    await userManager.AddToRoleAsync(user, "User");
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
        public async Task<IActionResult> Login(LoginViewModel Model)
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

        [HttpGet]
        public async Task<IActionResult> ManageUser()
        {
            DbUser user = await userManager.GetUserAsync(User);

            if (user == null)
            {
                ViewBag.ErrorMessage = $"Користувача не знайдено";
                return View("Error");
            }


            var model = new EditUserViewModel
            {
                Id = user.Id,
                UserName = user.UserName,
                FirstName = user.FirstName,
                LastName = user.LastName,
                Birthday = user.Birthday,
                PhoneNumber = user.PhoneNumber
            };

            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> ManageUser(EditUserViewModel model)
        {
            var user = await userManager.FindByIdAsync(model.Id.ToString());
            IList<string> _allUserRoles = userManager.GetRolesAsync(user).Result;

            if (user == null)
            {
                ViewBag.ErrorMessage = $"Користувача з id = {model.Id} не знайдено";
                return View("Error");
            }
            else
            {
                user.Birthday = model.Birthday;
                user.FirstName = model.FirstName;
                user.LastName = model.LastName;
                user.Id = model.Id;
                user.UserName = model.UserName;
                user.PhoneNumber = model.PhoneNumber;

                if (model.Password != null)
                    if (model.Password.Replace(" ", "") != "")
                        user.PasswordHash = userManager.PasswordHasher.HashPassword(user, model.Password);


                var result = await userManager.UpdateAsync(user);

                if (result.Succeeded)
                { return RedirectToAction("Index","Home"); }

                foreach (var error in result.Errors)
                {
                    ModelState.AddModelError("", error.Description);
                }
            }

            return View(model);
        }



        //Administration
        public async Task<IActionResult> ListUsers(string id)
        {
            DbUser user = await userManager.FindByIdAsync(id);

            var users = userManager.Users;
            return View(users);
        }

        [HttpGet]
        public async Task<IActionResult> EditUser(string id)
        {
            DbUser user = await userManager.FindByIdAsync(id);

            if (user == null)
            {
                ViewBag.ErrorMessage = $"Користувача з id = {id} не знайдено";
                return View("Error");
            }


            IList<string> _allUserRoles = userManager.GetRolesAsync(user).Result;
            IList<string> _allRoles = roleManager.Roles.Select(x => x.Name).ToList();

            List<AllRoleViewModel> allRolesModel = new List<AllRoleViewModel>();

            foreach (var role in _allRoles)
            {
                allRolesModel.Add(new AllRoleViewModel { RoleName = role, IsSelected = _allUserRoles.Contains(role) });
            }


            var model = new EditUserViewModel
            {
                Id = user.Id,
                UserName = user.UserName,
                FirstName = user.FirstName,
                LastName = user.LastName,
                AllRoles = allRolesModel,
                Birthday = user.Birthday,
                PhoneNumber=user.PhoneNumber
            };

            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> EditUser(EditUserViewModel model)
        {
            var user = await userManager.FindByIdAsync(model.Id.ToString());
            IList<string> _allUserRoles = userManager.GetRolesAsync(user).Result;

            if (user == null)
            {
                ViewBag.ErrorMessage = $"Користувача з id = {model.Id} не знайдено";
                return View("Error");
            }
            else
            {
                user.Birthday = model.Birthday;
                user.FirstName = model.FirstName;
                user.LastName = model.LastName;
                user.PhoneNumber = model.PhoneNumber;

                foreach(var role in model.AllRoles)
                {
                    if(role.IsSelected)
                    await userManager.AddToRoleAsync(user, role.RoleName);
                    else
                    {
                        if(_allUserRoles.Contains(role.RoleName))
                            await userManager.RemoveFromRoleAsync(user, role.RoleName);
                    }
                }

                if (model.Password != null)
                    if (model.Password.Replace(" ", "") != "")
                        user.PasswordHash = userManager.PasswordHasher.HashPassword(user, model.Password);


                var result = await userManager.UpdateAsync(user);

                if (result.Succeeded)
                { return RedirectToAction("ListUsers"); }

                foreach (var error in result.Errors)
                {
                    ModelState.AddModelError("", error.Description);
                }
            }

            return View(model);
        }

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
                    return View("Error");
                }
            }
            ViewBag.ErrorMessage = $"Користувача з id = {Id} не знайдено";
            return View("Error");
        }


    }
}
