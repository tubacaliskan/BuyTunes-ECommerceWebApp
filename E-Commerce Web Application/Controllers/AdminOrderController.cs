using E_Commerce_Web_Application.Entity;
using E_Commerce_Web_Application.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace E_Commerce_Web_Application.Controllers
{
    [Authorize(Roles = "admin")]
    public class AdminOrderController : Controller
    {
        DataContext db = new DataContext();

        // GET: AdminOrder
        public ActionResult Index()
        {
            var orders = db.Orders.Select(i => new AdminOrderModel()
            {
                Id = i.Id,
                OrderDate = i.OrderDate,
                OrderNumber = i.OrderNumber,
                OrderState = i.OrderState,
                Total = i.Total,
                Count = i.OrderLines.Count
            }).OrderByDescending(i => i.OrderDate).ToList();

            return View(orders);
        }

        public ActionResult Details(int id)
        {
            var entity = db.Orders.Where(i => i.Id == id).Select(i => new OrderDetailsModel()
            {
                OrderId = i.Id,
                OrderNumber = i.OrderNumber,
                OrderDate = i.OrderDate,
                Total = i.Total,
                OrderLines = i.OrderLines.Select(a => new OrderLineModel()
                {
                    ProductId = a.ProductId,
                    ProductName = a.Product.ProductName,
                    ProductImage = a.Product.ProductImage,
                    ProductPrice = a.Product.ProductPrice,
                    Quantity = a.Quantity
                }).ToList(),
                UserName = i.UserName,
                AddressTitle = i.AddressTitle,
                CustumerCity = i.CustumerCity,
                CustumerZıpCode = i.CustumerZıpCode,
                CustumerAdress = i.CustumerAdress,
                CustumerAdress2 = i.CustumerAdress2,
                OrderState = i.OrderState,

            }).FirstOrDefault();
            return View(entity);
        }

        public ActionResult UpdateOrderState(int OrderId, EnumOrderState OrderState)
        {
            var order = db.Orders.FirstOrDefault(i=>i.Id== OrderId);
            if (order == null) 
            {
                return RedirectToAction("Index");
            }
            else
            {
                order.OrderState= OrderState;
                db.SaveChanges();

                TempData["message"] = "Information Updated";

                return RedirectToAction("Details", new {id = OrderId});
            }
        }
    }
}