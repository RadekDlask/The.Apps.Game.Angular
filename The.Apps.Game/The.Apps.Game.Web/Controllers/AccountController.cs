using System;
using System.Collections.Generic;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
using The.Apps.Game.Core.Data.Models.Users;
using The.Apps.Game.Core.Services.Results;
using The.Apps.Game.Core.Services.Users;
using The.Apps.Game.Web.ViewModels.User;

namespace The.Apps.Game.Web.Controllers
{
    public partial class AccountController : Controller
    {
        private IUserService _userService;
        public AccountController(IUserService userService)
        {
            _userService = userService;
        }
        // POST: Login
        [HttpPost]
        public virtual ActionResult Login(LoginViewModel login)
        {
            login.CustomError = null;
            if (!ModelState.IsValid)
            {
                return View(login);
            }
            var existingUser = _userService.LogIn(login.Name, login.Password);
            if (existingUser.Result != OperationResultType.Success)
            {
                login.CustomError = existingUser.Reason;
                return View(login);
            }
            Login(existingUser.Model);
            return RedirectToAction(MVC.Game.Index());
        }
        // Get: Logout
        [HttpGet]
        public virtual ActionResult Logout()
        {
            FormsAuthentication.SignOut();
            return RedirectToAction(MVC.Home.Index());
        }

        // Get: Login
        [HttpGet]
        public virtual ActionResult Login()
        {            
            return View(new LoginViewModel());
        }
        // POST: Register
        [HttpPost]
        public virtual ActionResult Register(RegisterViewModel register)
        {
            register.CustomError = null;
            if (!ModelState.IsValid)
            {
                return View(register);
            }
            var existingUser = _userService.Register(register.Name, register.Password, register.DisplayName, register.Email);
            if (existingUser.Result != OperationResultType.Success)
            {
                register.CustomError = existingUser.Reason;
                return View(register);
            }
            Login(existingUser.Model);
            return RedirectToAction(MVC.Game.Index());
        }
        // GET: Register
        [HttpGet]
        public virtual ActionResult Register()
        {            
            return View(new RegisterViewModel());
        }

        private void Login(User user)
        {
            var roles = new List<string> { "user" };
            var ticket = new FormsAuthenticationTicket
            (
                1,
                user.Id.ToString(),
                DateTime.Now,
                DateTime.Now.AddDays(1),
                true,
                string.Join(";", roles)
            );
            var cookie = new HttpCookie(FormsAuthentication.FormsCookieName, FormsAuthentication.Encrypt(ticket));
            HttpContext.Response.Cookies.Add(cookie);
        }
    }
}