using E_Commerce_Web_Application.Entity;
using E_Commerce_Web_Application.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace E_Commerce_Web_Application.Controllers
{
    public class CartController : Controller
    {
        private DataContext db = new DataContext();
        // GET: Cart
        public ActionResult Index()
        {
            return View(GetCart());
        }

        public ActionResult AddToCart(int Id)
        {
            var product = db.Products.Where(i => i.Id == Id).FirstOrDefault();
            if (product != null)
            {
                GetCart().AddProduct(product, 1);
            }
            return RedirectToAction("Home", "Home");
        }

        public ActionResult RemoveFromCart(int Id)
        {
            var product = db.Products.Where(i => i.Id == Id).FirstOrDefault();
            if (product != null)
            {
                GetCart().DeleteProduct(product);
            }
            return RedirectToAction("Index");
        }

        public Cart GetCart()
        {
            var cart = (Cart)Session["Cart"]; // session her kullanıcıya özel oluşturulan depo 

            if (cart == null)
            {
                cart = new Cart();
                Session["Cart"] = cart;
            }

            return cart;
        }

        public ActionResult Checkout()
        {
            return View(new ShippingDetails());
        }

        [HttpPost]
        public ActionResult Checkout(ShippingDetails entity)
        {

            var cart = GetCart();

            if (cart.CartLines.Count == 0)
            {
                ModelState.AddModelError("NoItemsError", "There are no items in your cart");
            }

            if (ModelState.IsValid)
            {
                // siparişi veri tabanına kaydet
                // cart ı sıfırla
                // müşteriyi complated sayfasına yolla
                SaveOrder(cart,entity);
                cart.Clear();
                return View("Completed2");
            }
            else
            {
                return View(entity);
            }
        }

        private void SaveOrder(Cart cart, ShippingDetails entity)
        {
            var order = new Order();

            order.OrderNumber = new Random().Next(111111,999999).ToString();
            order.OrderDate = DateTime.Now;
            order.Total = cart.TotalPrice();
            order.OrderState = EnumOrderState.Waiting;
            order.UserName = User.Identity.Name;

            order.AddressTitle = entity.AddressTitle;
            order.CustumerCity = entity.CustumerCity;
            order.CustumerZıpCode = entity.CustumerZıpCode;
            order.CustumerAdress = entity.CustumerAdress;
            order.CustumerAdress2 = entity.CustumerAdress2;
            order.CustumerState= entity.CustumerState;

            //order linelar
            order.OrderLines = new List<OrderLine>();

            foreach (var product in cart.CartLines)
            {
                var orderline = new OrderLine();
                orderline.Quantity= product.Quantity;
                orderline.ProductPrice= (product.Product.ProductPrice * product.Quantity);
                orderline.ProductId= product.Product.Id;

                order.OrderLines.Add(orderline);
            }
            db.Orders.Add(order);
            db.SaveChanges();
        }
    }
}