using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;

namespace E_Commerce_Web_Application.Entity
{
    public class MainCategory
    {
        public int Id { get; set; }
        [DisplayName("Main Category Name")]
        public string MainCategoryName { get; set; }
        public string Description { get; set; }

        public List<Category> Categories { get; set; }
    }
}