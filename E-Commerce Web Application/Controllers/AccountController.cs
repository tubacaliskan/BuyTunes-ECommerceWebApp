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
using System.Data.Entity;
using System.Net;
using System.Configuration;
using System.Data.SqlClient;

namespace E_Commerce_Web_Application.Controllers
{
    public class AccountController : Controller
    {
        private DataContext db = new DataContext();
    
        private UserManager<ApplicationUser> UserManager;
        private RoleManager<ApplicationRole> RoleManager;

        public AccountController()
        {
            var userStore = new UserStore<ApplicationUser>(new IdentityDataContex());
            UserManager = new UserManager<ApplicationUser>(userStore);

            var roleStore = new RoleStore<ApplicationRole>(new IdentityDataContex());
            RoleManager = new RoleManager<ApplicationRole>(roleStore);

        }
        [Authorize]
        public ActionResult Index()
        {

            var orders = db.Orders.Where(i => i.UserName == User.Identity.Name).Select(i => new UserOrderModel()
            {
                Id = i.Id,
                OrderNumber = i.OrderNumber,
                OrderDate = i.OrderDate,
                OrderState = i.OrderState,
                Total = i.Total
            }).OrderByDescending(i => i.OrderDate).ToList();

            return View(orders);
        }
        [Authorize]
        public ActionResult Details(int id)
        {
            var entity = db.Orders.Where(i => i.Id == id).Select(i => new OrderDetailsModel()
            {
                OrderId = i.Id,
                OrderNumber = i.OrderNumber,
                OrderDate = i.OrderDate,
                Total = i.Total,
                OrderLines = i.OrderLines.Select(a=> new OrderLineModel()
                {
                    ProductId= a.ProductId,
                    ProductName = a.Product.ProductName,
                    ProductImage = a.Product.ProductImage,
                    ProductPrice= a.Product.ProductPrice,
                    Quantity = a.Quantity
                }).ToList(),
                UserName = User.Identity.Name,
                AddressTitle = i.AddressTitle,
                CustumerCity = i.CustumerCity,
                CustumerZıpCode = i.CustumerZıpCode,
                CustumerAdress= i.CustumerAdress,
                CustumerAdress2= i.CustumerAdress2,
                OrderState= i.OrderState,

            }).FirstOrDefault();

            return View(entity);
        }
        [Authorize]
        public ActionResult EditProfile()
        {

            //if (id == null)
            //{
            //    return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            //}
            RegisterCustomer profile = db.RegisterCustomers.Find(User.Identity.Name);
            if (profile == null)
            {
                return HttpNotFound();
            }

            return View(profile);

        }

        // POST: RegisterCustomer/Edit/5
        // Aşırı gönderim saldırılarından korunmak için bağlamak istediğiniz belirli özellikleri etkinleştirin. 
        // Daha fazla bilgi için bkz. https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult EditProfile(
        [Bind(Include = "CustumerName,CustumerSurname,UserName,CustumerEmail,CustumerPhone,CustumerPassword,CustumerRePassword,CustumerGender,CustumerCity, CustumerZıpCode, CustumerAdress, CustumerAdress2, CustumerState")] 
        RegisterCustomer profile)
        {
            if (ModelState.IsValid)
            {
                db.Entry(profile).State = EntityState.Modified;
                db.SaveChanges();

                TempData["message"] = "Information Updated";
                return RedirectToAction("EditProfile");
            }

            return View(profile);
        }

        public ActionResult Profile()
        {
            return View();
        }


        // GET: Account
        public ActionResult Register()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken] // /cs html de ki yollnana antiforgeryToken ile çalışır. oaradan gelen bilgi ile buradaki tutuyır mu diye kontrol eder
        public ActionResult Register(RegisterCustomer model)
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
                //string connstring = ConfigurationManager.ConnectionStrings["itmall"].ConnectionString;

                //SqlConnection con = new SqlConnection(connstring);
                db.RegisterCustomers.Add(model);
                db.SaveChanges();

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

                var user = UserManager.Find(model.UserName, model.CustumerPassword);

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
