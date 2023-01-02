using E_Commerce_Web_Application.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace E_Commerce_Web_Application.Models
{
    public class ProductModel
    {
        public int Id { get; set; }
        public string ProductName { get; set; }
        public string ProductCode { get; set; } // bu product number'ı data ınıtılazer a manuel olarak girdim ama bunun datatable omotomik dolması gerek
        public string ProductDescription { get; set; }
        public string ProductPrice { get; set; }
        public string ProductImage { get; set; }
        public int ProductStoct { get; set; }
        public bool ProductIsApproved { get; set; }
        public int CategoryId { get; set; }
        public Category Category { get; set; }
        public bool ProductHome { get; set; } // product ana sayda aduracak mı onu belirliyor
        // uğraşmak isteemdiğimden bunu şimdi eklemedim düzenleme yaparken bunu mutlaka ekle
    }
}