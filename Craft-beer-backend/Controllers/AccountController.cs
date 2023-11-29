using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Craft_beer_backend.Entities;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Craft_beer_backend.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Craft_beer_backend.Services.Interfaces;
using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;

namespace Craft_beer_backend.Controllers
{
    public class AccountController : Controller
    {
        private readonly UserManager<DbUser> userManager;
        private readonly SignInManager<DbUser> signInManager;
        private readonly RoleManager<DbRole> roleManager;
        private readonly IOrderService _orderService;

        public AccountController(UserManager<DbUser> userManager, SignInManager<DbUser> signInManager,
            RoleManager<DbRole> roleManager, IOrderService orderService)
        {
            this.userManager = userManager;
            this.signInManager = signInManager;
            this.roleManager = roleManager;
            _orderService = orderService;
        }
        [AllowAnonymous]
        [HttpPost]
        public async Task<JsonResult> Register(string email, string username, string password)
        { 
            if (ModelState.IsValid)
            {
                var user = new DbUser()
                {
                    UserName = username,
                    Email = email,
                };

                var result = await userManager.CreateAsync(user, password);
                    var success = result.Succeeded;
                if(success)
                    await signInManager.SignInAsync(user, false);
                return Json(new { success });
            }
            return Json(false);
        }
        [HttpGet]
        public IActionResult Login(string ReturnUrl)
        {if (ReturnUrl == null)
                ReturnUrl = "/Home/Index";
            ViewBag.ReturnUrl = ReturnUrl;
            return View();
        }
            [AllowAnonymous]
        [HttpPost]
        public async Task<JsonResult> Login(string username, string password, bool rememberMe)
        {
            if (ModelState.IsValid)
            {
                var identityResult = await signInManager.PasswordSignInAsync(username, password, rememberMe, false);

                var success = identityResult.Succeeded;
                    return Json(new { success });
            }
            return Json(false);
        }

        [Authorize]
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
        [Authorize]
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
                PhoneNumber = user.PhoneNumber,
                Email = user.Email,

            };

            return View(model);
        }
        [Authorize]
        [HttpPost]
        public async Task<IActionResult> ManageUser(EditUserViewModel model)
        {
            var user = await userManager.FindByIdAsync(model.Id.ToString());

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
                user.Email = model.Email;

                if (model.Password != null)
                    if (model.Password.Replace(" ", "") != "")
                        user.PasswordHash = userManager.PasswordHasher.HashPassword(user, model.Password);


                var result = await userManager.UpdateAsync(user);

                if (result.Succeeded)
                { return RedirectToAction("ManageUser","Account"); }

                foreach (var error in result.Errors)
                {
                    ModelState.AddModelError("", error.Description);
                }
            }

            return View(model);
        }
        [Authorize]
        [HttpGet]
        public async Task<IActionResult> OrdersAsync()
        {
            var model = _orderService.GetUserOrders((await userManager.GetUserAsync(User)).Id);

            return View(model);
        }
        [Authorize]
        [HttpGet]
        public IActionResult OrderDetails(string uniqueCode)
        {
            var model = _orderService.GetOrderDetails(uniqueCode);

            return View(model);
        }
        [Authorize]
        [HttpPost]
        public IActionResult CancelOrder(string uniqueCode)
        {
            _orderService.CancelOrder(uniqueCode);

            return RedirectToAction("OrderDetails","Account", new { uniqueCode = uniqueCode });
        }

        //Administration
        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> ListUsers(string id)
        {
            DbUser user = await userManager.FindByIdAsync(id);

            var users = userManager.Users;
            return View(users);
        }
        [Authorize(Roles = "Admin")]
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
                PhoneNumber=user.PhoneNumber,
                Email = user.Email
            };

            return View(model);
        }
        [Authorize(Roles = "Admin")]
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
                user.UserName = model.UserName;

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
        [Authorize(Roles = "Admin")]
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
