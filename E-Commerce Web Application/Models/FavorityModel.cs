using E_Commerce_Web_Application.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.UI.WebControls;

namespace E_Commerce_Web_Application.Models
{
    public class FavorityModel
    {

        private List<FavorityLine> _favorityLines = new List<FavorityLine>();
        public List<FavorityLine> FavorityLines
        {
            get { return _favorityLines; }
        }

        public void AddProduct(Product product)
        {
            var line = _favorityLines.Where(i => i.Product.Id == product.Id).FirstOrDefault();
            if (line == null)
            {
                _favorityLines.Add(new FavorityLine() { Product = product });
            }
           
        }

        public void DeleteProduct(Product product)
        {
            _favorityLines.RemoveAll(i => i.Product.Id == product.Id);
        }

        public void Clear()
        {
            _favorityLines.Clear();
        }
    }

    public class FavorityLine // alış veriş sepetindeki her bir satırı temsil ediyor.
    {
        public Product Product { get; set; }
    }

}