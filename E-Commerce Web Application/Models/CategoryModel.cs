using E_Commerce_Web_Application.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace E_Commerce_Web_Application.Models
{
    public class CategoryModel
    {
        public int Id { get; set; }
        public string MainCategory { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public List<Product> Products { get; set; }
        public int MainCategoryId { get; set; }
        public MainCategory Main_Category { get; set; }
    }
}