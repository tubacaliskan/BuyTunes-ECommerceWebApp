using E_Commerce_Web_Application.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.UI.WebControls;

namespace E_Commerce_Web_Application.Models
{
    public class Cart
    {
        private List<CartLine> _cartLines = new List<CartLine>();
        public List<CartLine> CartLines
        {
            get { return _cartLines; }
        }

        public void AddProduct(Product product, int quantity)
        {
            var line = _cartLines.Where(i => i.Product.Id == product.Id).FirstOrDefault();
            if (line == null)
            {
                _cartLines.Add(new CartLine() { Product = product, Quantity = quantity });
            }
            else
            {
                line.Quantity += quantity;
            }
        }

        public void DeleteProduct(Product product)
        {
            _cartLines.RemoveAll(i => i.Product.Id == product.Id);
        }

        public double TotalPrice()
        {
            return _cartLines.Sum(i => i.Product.ProductPrice * i.Quantity);
        }
        public void Clear() 
        { 
            _cartLines.Clear();
        }
    }

    public class CartLine // alış veriş sepetindeki her bir satırı temsil ediyor.
    {
        public Product Product { get; set; }
        public int Quantity { get; set; } // ürün miktarı
    }

}