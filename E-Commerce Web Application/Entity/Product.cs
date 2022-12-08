using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;

namespace E_Commerce_Web_Application.Entity
{
    public class Product
    {
        public int Id { get; set; }
        [DisplayName("Product Name")]
        public string ProductName { get; set; }
        [DisplayName("Product Code")]
        public string ProductCode { get; set; } // bu product number'ı data ınıtılazer a manuel olarak girdim ama bunun datatable omotomik dolması gerek
        [DisplayName("Product Description")]
        public string ProductDescription { get; set; }
        [DisplayName("Product Price")]
        public int ProductPrice { get; set; }
        [DisplayName("Product Image")]
        public string ProductImage { get; set; }
        [DisplayName("Product Stock")]
        public int ProductStoct { get; set; }
        [DisplayName("Product Is Approved")]
        public bool ProductIsApproved { get; set; }
        public int CategoryId { get; set; }
        public  Category _Category { get; set; }
        [DisplayName("Product Is In Home Page")]
        public bool ProductHome { get; set; } // product ana sayda aduracak mı onu belirliyor
        // uğraşmak isteemdiğimden bunu şimdi eklemedim düzenleme yaparken bunu mutlaka ekle
    }
}