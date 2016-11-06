using System;
using System.Collections.Generic;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
using The.Apps.Game.Core.Data.Models.Users;
using The.Apps.Game.Core.Services.Results;
using The.Apps.Game.Core.Services.Users;
using The.Apps.Game.Web.Extensions.ViewModels;
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
        // GET: Register
        [HttpGet]
        public virtual ActionResult Register()
        {
            return View(new RegisterViewModel());
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
            var existingUser = _userService.Register(register.ToModel(0));
            if (existingUser.Result != OperationResultType.Success)
            {
                register.CustomError = existingUser.Reason;
                return View(register);
            }
            Login(existingUser.Model);
            return RedirectToAction(MVC.Game.Index());
        }
        // Get: Login
        [HttpGet]
        public virtual ActionResult Login()
        {
            return View(new LoginViewModel());
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
        // GET: Edit
        [HttpGet]
        public virtual ActionResult Edit()
        {
            var user = _userService.GetCurrent();
            if (user.Result == OperationResultType.Success && user.Model != null)
            {
                return View(user.Model.ToEditViewModel(_userService.GetCurrent().Model.Id));
            }
            else
            {
                return View(new EditViewModel
                {
                    CustomError = user.Reason
                });
            }
        }
        // POST: Edit
        [HttpPost]
        [Authorize]
        public virtual ActionResult Edit(EditViewModel register)
        {
            register.CustomError = null;
            if (!ModelState.IsValid)
            {
                return View(register);
            }
            var existingUser = _userService.Edit(register.ToModel(_userService.GetCurrent().Model.Id));
            if (existingUser.Result != OperationResultType.Success)
            {
                register.CustomError = existingUser.Reason;
                return View(register);
            }
            return RedirectToAction(MVC.Game.Index());
        }
        // GET: Details
        [HttpGet]
        public virtual ActionResult Details()
        {
            var user = _userService.GetCurrent();
            if (user.Result == OperationResultType.Success && user.Model != null)
            {
                return View(user.Model.ToDetailsViewModel(user.Model.Id));
            }
            else
            {
                return View(new EditViewModel
                {
                    CustomError = user.Reason
                });
            }
        }
        // POST: Details
        [HttpPost]
        [Authorize]
        public virtual ActionResult Details(DetailsViewModel details)
        {
            details.CustomError = null;
            if (!ModelState.IsValid)
            {
                return View(details);
            }

            var existingUser = _userService.GetCurrent().Model;
            existingUser.UserAddress = details.Address.ToModel(existingUser.Id);
            existingUser.UserDetail = details.Detail.ToModel(existingUser.Id);
            existingUser.UserPersonal = details.Personal.ToModel(existingUser.Id);

            var updatedDetails = _userService.EditDetails(existingUser);

            if (updatedDetails.Result != OperationResultType.Success)
            {
                details.CustomError = updatedDetails.Reason;
                return View(details);
            }
            return RedirectToAction(MVC.Account.Edit());
        }
        // GET: ChangePassword
        [HttpGet]
        public virtual ActionResult ChangePassword()
        {
            var user = _userService.GetCurrent();
            if (user.Result == OperationResultType.Success && user.Model != null)
            {
                return View(new ChangePasswordViewModel
                {
                    DisplayName = user.Model.DisplayName,
                    Email = user.Model.Email,
                    Name = user.Model.Name
                });
            }
            else
            {
                return View(new ChangePasswordViewModel
                {
                    CustomError = user.Reason
                });
            }
        }
        // POST: ChangePassword
        [HttpPost]
        [Authorize]
        public virtual ActionResult ChangePassword(ChangePasswordViewModel register)
        {
            register.CustomError = null;
            if (!ModelState.IsValid)
            {
                return View(register);
            }
            var existingUser = _userService.ChangePassword(register.OriginalPassword, register.Password);
            if (existingUser.Result != OperationResultType.Success)
            {
                register.CustomError = existingUser.Reason;
                return View(register);
            }
            return RedirectToAction(MVC.Account.Edit());
        }

        private void Login(User user)
        {
            var roles = new List<string> { UserRoles.User };
            var userData = string.Format("{0},{1}", user.DisplayName, string.Join(";", roles));
            var ticket = new FormsAuthenticationTicket
            (
                1,
                user.Id.ToString(),
                DateTime.Now,
                DateTime.Now.AddDays(1),
                true,
                userData
            );
            var cookie = new HttpCookie(FormsAuthentication.FormsCookieName, FormsAuthentication.Encrypt(ticket));
            HttpContext.Response.Cookies.Add(cookie);
        }
    }
}