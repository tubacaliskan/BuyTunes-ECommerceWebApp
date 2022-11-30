using E_Commerce_Web_Application.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace E_Commerce_Web_Application.Controllers
{
    public class HomeController : Controller
    {
        DataContext _context = new DataContext();
     
        public ActionResult Home()
        {
            return View(_context.Products.Where(i => i.ProductHome && i.ProductIsApproved).ToList());
        }

        public ActionResult Login2()
        {

            return View();
        }

        public ActionResult Register2()
        {

            return View();
        }
        public ActionResult ProductList() // burada shop vardı //ürünlerin listelenmesi için yapıldı
        { 
            return View(_context.Products.Where(i => i.ProductIsApproved).ToList());
        }
        public ActionResult Favorities(int id)  // metod favorilere eklenmiş ürünü listeler 
        {
            //  -> favorilere ekleme kısmı ekstra bir sayfaya gerek duyulmadığı için ürünün detayları kısmında yapılabilir
            // burası ekstra sayfaya ihtiyaç duyulduğu için controller'da method oluşturuldu
            // list fonksiyonu belki burda kullanılabilir
            return View(_context.Products.Where(i => i.Id == id).ToList());
        }
        public ActionResult Cart(int id) // metod sepete eklenmiş ürünü listeler 
        {
            //  -> sepete ekleme kısmı ekstra bir sayfaya gerek duyulmadığı için ürünün detayları kısmında yapılabilir
            // burası ekstra sayfaya ihtiyaç duyulduğu için controller'da method oluşturuldu
            // list fonksiyonu belki burda kullanılabilir
            return View(_context.Products.Where(i => i.Id == id).ToList());
        }

        public ActionResult Product(int id) // ürünü ayrı sayfada görmek için belki ek bunun için ekstra controller oluşturulur.
            // favorilere ve sepet ekleme işlemi burada yapılıyor
        {

            return View(_context.Products.Where(i => i.Id == id).FirstOrDefault());
        }
    }
}