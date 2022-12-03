using E_Commerce_Web_Application.Entity;
using E_Commerce_Web_Application.Models;
using E_Commerce_Web_Application.Identity;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Microsoft.Owin.Security;
using System.Net.Http.Headers;

namespace E_Commerce_Web_Application.Controllers
{
    public class AccountController : Controller
    {
        private UserManager<ApplicationUser> UserManager;
        private RoleManager<ApplicationRole> RoleManager;

        public AccountController()
        {
            var userStore = new UserStore<ApplicationUser>(new IdentityDataContex());
            UserManager = new UserManager<ApplicationUser>(userStore);

            var roleStore = new RoleStore<ApplicationRole>(new IdentityDataContex());
            RoleManager = new RoleManager<ApplicationRole>(roleStore);

        }

        // GET: Account
        public ActionResult Register()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken] // /cs html de ki yollnana antiforgeryToken ile çalışır. oaradan gelen bilgi ile buradaki tutuyır mu diye kontrol eder
        public ActionResult Register(RegisterModel model)
        {
            if (ModelState.IsValid)
            {
                // Kayıt işelmleri

                var user = new ApplicationUser();
                user.Name = model.CustumerName;
                user.Surname = model.CustumerSurname;
                user.Email = model.CustumerEmail;
                user.UserName = model.UserName;

                var result = UserManager.Create(user, model.CustumerPassword);

                if (result.Succeeded)
                {
                    // kullanıcı oluşturuldu onu artık bir role atayabiliriz.              
                    if (RoleManager.RoleExists("user"))
                    {
                        UserManager.AddToRoles(user.Id, "user");
                    }
                    return RedirectToAction("Login", "Account");
                }
                else
                {
                    ModelState.AddModelError("RegisterUserError", "User could not be created");
                }
            }
            return View();
        }


        // GET: Account
        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken] // /cs html de ki yollnana antiforgeryToken ile çalışır. oaradan gelen bilgi ile buradaki tutuyır mu diye kontrol eder
        public ActionResult Login(LoginModel model, string ReturnUrl)
        {
            if (ModelState.IsValid)
            {
                // Login işelmleri

                var user= UserManager.Find(model.UserName, model.CustumerPassword);

                if (user != null)
                {
                    // var olan kullanıcıyı sisteme dahil et
                    // applicationCookie oluşturup sisteme bırak

                    var authManager = HttpContext.GetOwinContext().Authentication;
                    var identityclaims = UserManager.CreateIdentity(user, "ApplicationCookie");
                    var authProperties = new AuthenticationProperties();
                    (new AuthenticationProperties()).IsPersistent = model.RememberMe;

                    authManager.SignIn(authProperties, identityclaims);

                    if (!String.IsNullOrEmpty(ReturnUrl))
                    {
                        return Redirect(ReturnUrl);
                    }

                    return RedirectToAction("Home", "Home");
                }
                else
                {
                    ModelState.AddModelError("LoginUserError", "User not found");
                }
            }
            return View();
        }

        public ActionResult Logout()
        {
            var authManager = HttpContext.GetOwinContext().Authentication;
            authManager.SignOut();

            return RedirectToAction("Home", "Home");
        }
    }
}
