using E_Commerce_Web_Application.Entity;
using E_Commerce_Web_Application.Models;
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
            var product = _context.Products.
                Where(i => i.ProductHome && i.ProductIsApproved).
                Select(i => new ProductModel()
                {
                    Id = i.Id, 
                    ProductName = i.ProductName, 
                    CategoryId= i.CategoryId,
                    ProductImage = i.ProductImage,    
                    ProductDescription= i.ProductDescription.Length > 50 ? i.ProductDescription.Substring(0,47) + "..." : i.ProductDescription,
                    ProductCode= i.ProductCode,
                    ProductHome = i.ProductHome,
                    ProductPrice= i.ProductPrice.ToString(),
                    ProductStoct = i.ProductStoct

                }).ToList();
            return View(product);
        }

        public ActionResult ProductList(int? id) 
        {
            var product = _context.Products.
               Where(i => i.ProductIsApproved).
               Select(i => new ProductModel()
               {
                   Id = i.Id,
                   ProductName = i.ProductName,
                   CategoryId = i.CategoryId,
                   ProductImage = i.ProductImage,
                   ProductDescription = i.ProductDescription.Length > 50 ? i.ProductDescription.Substring(0, 47) + "..." : i.ProductDescription,
                   ProductCode = i.ProductCode,
                   ProductHome = i.ProductHome,
                   ProductPrice = i.ProductPrice.ToString(),
                   ProductStoct = i.ProductStoct

               }).AsQueryable();
            if (id != null)
            {
                product = product.Where(i => i.CategoryId == id);
            }

            //burada select yazarak sorguyu çalıştırıyorduk ama asqu yazarak yazdığımız isteği sorgulatmadan çalıştırmış olacağız 
            // nedenini tam anlamadım.
            return View(product.ToList());
        }

        public ActionResult Product(int id) 
        {

            return View(_context.Products.Where(i => i.Id == id).FirstOrDefault());
        }

        public PartialViewResult GetCategories()
        {
            return PartialView(_context.Categories.ToList());
        }
        
        public PartialViewResult GetMainCategories() 
        {
            return PartialView(_context.MainCategories.ToList());
        }
    }
}