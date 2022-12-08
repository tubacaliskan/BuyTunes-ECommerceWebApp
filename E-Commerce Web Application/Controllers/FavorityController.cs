using E_Commerce_Web_Application.Entity;
using E_Commerce_Web_Application.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace E_Commerce_Web_Application.Controllers
{
    public class FavorityController : Controller
    {
        private DataContext db = new DataContext();

        // GET: Favority
        public ActionResult Index()
        {
            return View(GetFavority());
        }
       
        public ActionResult AddToFavority(int Id)
        {
            var product = db.Products.Where(i => i.Id == Id).FirstOrDefault();
            if (product != null)
            {
                GetFavority().AddProduct(product);
            }
            return RedirectToAction("Home", "Home");
        }

        public ActionResult RemoveFromFavority(int Id)
        {
            var product = db.Products.Where(i => i.Id == Id).FirstOrDefault();
            if (product != null)
            {
                GetFavority().DeleteProduct(product);
            }
            return RedirectToAction("Index");
        }

        public FavorityModel GetFavority()
        {
            var favority = (FavorityModel)Session["Favority"]; // session her kullanıcıya özel oluşturulan depo 

            if (favority == null)
            {
                favority = new FavorityModel();
                Session["Favority"] = favority;
            }

            return favority;
        }

        public ActionResult Checkout()
        {
            return View(new ShippingDetails());
        }
    }
}