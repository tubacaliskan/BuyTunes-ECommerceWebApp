using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;

namespace E_Commerce_Web_Application.Entity
{
    public class Category
    {
        public int Id { get; set; }
        [DisplayName("Main Category Name")]
        public string MainCategory { get; set; } // bu dolmuyor 
        [DisplayName("Category Name")]
        public string CategoryName { get; set; }
        public string Description { get; set; }

        public List<Product> Products { get; set; }
        public int MainCategoryId { get; set; } // bu doluyor
        public MainCategory Main_Category { get; set; } // bu da dolmuyor 
    }
}