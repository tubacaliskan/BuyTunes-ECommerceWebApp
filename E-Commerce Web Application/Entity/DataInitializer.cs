using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace E_Commerce_Web_Application.Entity
{
    public class DataInitializer : DropCreateDatabaseIfModelChanges<DataContext>
    {
        protected override void Seed(DataContext context)
        {
            List<MainCategory> mainCategories = new List<MainCategory>()
            {
                new MainCategory(){Name = "Telli", Description = "Telli Çalgılar"},
                new MainCategory(){Name = "Vurmalı", Description = "Vurmalı Çalgılar"},
                new MainCategory(){Name = "Tuşlu", Description = "Tuşlu Çalgılar"},
                new MainCategory(){Name = "Zilli", Description = "Zilli Çalgılar"},
                new MainCategory(){Name = "Üflemeli", Description = "Üflemeli Çalgılar"}
            };
            foreach (var mainCategory in mainCategories)
            {
                context.MainCategories.Add(mainCategory);
            }
            context.SaveChanges();

            List<Category> categories = new List<Category>()
            {
                 new Category(){Name = "Keman", Description = "Keman Ürünleri", MainCategoryId = 1},
                 new Category(){Name = "Gitar", Description = "Gitar Ürünleri",  MainCategoryId = 1},
                 new Category(){Name = "Saz", Description = "Saz Ürünleri",  MainCategoryId = 1},
                 new Category(){Name = "Flut", Description = "Flut Ürünleri", MainCategoryId = 2},
                 new Category(){Name = "Davul", Description = "Davul Ürünleri",  MainCategoryId = 3},
                 new Category(){Name = "Zurna", Description = "Zurna Ürünleri", MainCategoryId = 2}
            };

            foreach (var category in categories)
            {
                context.Categories.Add(category);
            }
            context.SaveChanges();

            List<Product> products = new List<Product>()
            {
                new Product(){ProductName = "Yamaha Keman", ProductPrice ="520", ProductCode = "643247", ProductIsApproved= true, ProductHome = true, ProductStoct = 34, CategoryId = 1, ProductDescription = "jsdkajdlksajdklsdjkljdlkjdkljdkljdkljdkladjlkasjkljfkljakfjklsfjklsjflksjfklafjklajfklasjflkasjfmckjgoırjfııjfımcımceomwjjakjlksajfkajfkljfkamckjakmal"},
                new Product(){ProductName = "zeynep Keman", ProductPrice ="520",ProductCode = "643247",ProductIsApproved= true, ProductStoct = 34, CategoryId = 1, ProductDescription = "jsdkajdlksajdklsdjkljdlkjdkljdkljdkljdkladjlkasjkljfkljakfjklsfjklsjflksjfklafjklajfklasjflkasjfmckjgoırjfııjfımcımceomwjjakjlksajfkajfkljfkamckjakmal"},
                new Product(){ProductName = "çello Keman", ProductPrice ="520",ProductIsApproved= true,ProductCode = "643247", ProductStoct = 34, CategoryId = 1, ProductDescription = "jsdkajdlksajdklsdjkljdlkjdkljdkljdkljdkladjlkasjkljfkljakfjklsfjklsjflksjfklafjklajfklasjflkasjfmckjgoırjfııjfımcımceomwjjakjlksajfkajfkljfkamckjakmal"},
                new Product(){ProductName = "gariban Keman", ProductPrice ="520",ProductIsApproved= true, ProductStoct = 34,ProductCode = "643247",ProductHome = true, CategoryId = 1, ProductDescription = "jsdkajdlksajdklsdjkljdlkjdkljdkljdkljdkladjlkasjkljfkljakfjklsfjklsjflksjfklafjklajfklasjflkasjfmckjgoırjfııjfımcımceomwjjakjlksajfkajfkljfkamckjakmal"},
                new Product(){ProductName = "bir seni sevdim Keman", ProductPrice ="520",ProductIsApproved= true,ProductCode = "643247", ProductStoct = 34, CategoryId = 1, ProductDescription = "jsdkajdlksajdklsdjkljdlkjdkljdkljdkljdkladjlkasjkljfkljakfjklsfjklsjflksjfklafjklajfklasjflkasjfmckjgoırjfııjfımcımceomwjjakjlksajfkajfkljfkamckjakmal"},

                new Product(){ProductName = "Yamaha gitar", ProductPrice ="520",ProductIsApproved= true,ProductCode = "643247", ProductStoct = 34, CategoryId = 2, ProductDescription = "jsdkajdlksajdklsdjkljdlkjdkljdkljdkljdkladjlkasjkljfkljakfjklsfjklsjflksjfklafjklajfklasjflkasjfmckjgoırjfııjfımcımceomwjjakjlksajfkajfkljfkamckjakmal"},
                new Product(){ProductName = "zeynep gitar", ProductPrice ="520",ProductIsApproved= true, ProductStoct = 34,ProductCode = "643247",ProductHome = true, CategoryId = 2, ProductDescription = "jsdkajdlksajdklsdjkljdlkjdkljdkljdkljdkladjlkasjkljfkljakfjklsfjklsjflksjfklafjklajfklasjflkasjfmckjgoırjfııjfımcımceomwjjakjlksajfkajfkljfkamckjakmal"},
                new Product(){ProductName = "çello gitar", ProductPrice ="520",ProductIsApproved= true, ProductStoct = 34,ProductCode = "643247",ProductHome = true, CategoryId = 2, ProductDescription = "jsdkajdlksajdklsdjkljdlkjdkljdkljdkljdkladjlkasjkljfkljakfjklsfjklsjflksjfklafjklajfklasjflkasjfmckjgoırjfııjfımcımceomwjjakjlksajfkajfkljfkamckjakmal"},
                new Product(){ProductName = "gariban gitar", ProductPrice ="520",ProductIsApproved= true, ProductCode = "643247",ProductStoct = 34,ProductHome = true, CategoryId = 2, ProductDescription = "jsdkajdlksajdklsdjkljdlkjdkljdkljdkljdkladjlkasjkljfkljakfjklsfjklsjflksjfklafjklajfklasjflkasjfmckjgoırjfııjfımcımceomwjjakjlksajfkajfkljfkamckjakmal"},
                new Product(){ProductName = "bir seni sevdim gitar", ProductPrice ="520",ProductIsApproved= true, ProductCode = "643247",ProductStoct = 34, CategoryId = 2, ProductDescription = "jsdkajdlksajdklsdjkljdlkjdkljdkljdkljdkladjlkasjkljfkljakfjklsfjklsjflksjfklafjklajfklasjflkasjfmckjgoırjfııjfımcımceomwjjakjlksajfkajfkljfkamckjakmal"},

                new Product(){ProductName = "Yamaha saz", ProductPrice ="520",ProductIsApproved= true,ProductCode = "643247", ProductStoct = 34, CategoryId = 3, ProductDescription = "jsdkajdlksajdklsdjkljdlkjdkljdkljdkljdkladjlkasjkljfkljakfjklsfjklsjflksjfklafjklajfklasjflkasjfmckjgoırjfııjfımcımceomwjjakjlksajfkajfkljfkamckjakmal"},
                new Product(){ProductName = "zeynep saz", ProductPrice ="520",ProductIsApproved= true, ProductCode = "643247",ProductStoct = 34, CategoryId = 3, ProductDescription = "jsdkajdlksajdklsdjkljdlkjdkljdkljdkljdkladjlkasjkljfkljakfjklsfjklsjflksjfklafjklajfklasjflkasjfmckjgoırjfııjfımcımceomwjjakjlksajfkajfkljfkamckjakmal"},
                new Product(){ProductName = "çello saz", ProductPrice ="520",ProductIsApproved= true, ProductCode = "643247",ProductStoct = 34,ProductHome = true, CategoryId = 3, ProductDescription = "jsdkajdlksajdklsdjkljdlkjdkljdkljdkljdkladjlkasjkljfkljakfjklsfjklsjflksjfklafjklajfklasjflkasjfmckjgoırjfııjfımcımceomwjjakjlksajfkajfkljfkamckjakmal"},
                new Product(){ProductName = "gariban saz", ProductPrice ="520",ProductIsApproved= true,ProductCode = "643247", ProductStoct = 34, CategoryId = 3, ProductDescription = "jsdkajdlksajdklsdjkljdlkjdkljdkljdkljdkladjlkasjkljfkljakfjklsfjklsjflksjfklafjklajfklasjflkasjfmckjgoırjfııjfımcımceomwjjakjlksajfkajfkljfkamckjakmal"},
                new Product(){ProductName = "bir seni sevdim saz", ProductPrice ="520",ProductIsApproved= true,ProductCode = "643247", ProductStoct = 34, CategoryId = 3, ProductDescription = "jsdkajdlksajdklsdjkljdlkjdkljdkljdkljdkladjlkasjkljfkljakfjklsfjklsjflksjfklafjklajfklasjflkasjfmckjgoırjfııjfımcımceomwjjakjlksajfkajfkljfkamckjakmal"},

                new Product(){ProductName = "Yamaha Flut", ProductPrice ="520",ProductIsApproved= true, ProductCode = "643247",ProductStoct = 34, CategoryId = 4,ProductHome = true, ProductDescription = "jsdkajdlksajdklsdjkljdlkjdkljdkljdkljdkladjlkasjkljfkljakfjklsfjklsjflksjfklafjklajfklasjflkasjfmckjgoırjfııjfımcımceomwjjakjlksajfkajfkljfkamckjakmal"},
                new Product(){ProductName = "zeynep Flut", ProductPrice ="520",ProductIsApproved= true, ProductCode = "643247",ProductStoct = 34, CategoryId = 4,ProductHome = true, ProductDescription = "jsdkajdlksajdklsdjkljdlkjdkljdkljdkljdkladjlkasjkljfkljakfjklsfjklsjflksjfklafjklajfklasjflkasjfmckjgoırjfııjfımcımceomwjjakjlksajfkajfkljfkamckjakmal"},
                new Product(){ProductName = "çello Flut", ProductPrice ="520",ProductIsApproved= true, ProductCode = "643247",ProductStoct = 34, CategoryId = 4, ProductDescription = "jsdkajdlksajdklsdjkljdlkjdkljdkljdkljdkladjlkasjkljfkljakfjklsfjklsjflksjfklafjklajfklasjflkasjfmckjgoırjfııjfımcımceomwjjakjlksajfkajfkljfkamckjakmal"},
                new Product(){ProductName = "gariban Flut", ProductPrice ="520",ProductIsApproved= true,ProductCode = "643247", ProductStoct = 34, CategoryId = 4, ProductDescription = "jsdkajdlksajdklsdjkljdlkjdkljdkljdkljdkladjlkasjkljfkljakfjklsfjklsjflksjfklafjklajfklasjflkasjfmckjgoırjfııjfımcımceomwjjakjlksajfkajfkljfkamckjakmal"},
                new Product(){ProductName = "bir seni sevdim Flut", ProductPrice ="520",ProductIsApproved= true,ProductCode = "643247", ProductStoct = 34, CategoryId = 4, ProductDescription = "jsdkajdlksajdklsdjkljdlkjdkljdkljdkljdkladjlkasjkljfkljakfjklsfjklsjflksjfklafjklajfklasjflkasjfmckjgoırjfııjfımcımceomwjjakjlksajfkajfkljfkamckjakmal"},

                new Product(){ProductName = "Yamaha Davul", ProductPrice ="520",ProductIsApproved= true,ProductCode = "643247", ProductStoct = 34, CategoryId = 5, ProductDescription = "jsdkajdlksajdklsdjkljdlkjdkljdkljdkljdkladjlkasjkljfkljakfjklsfjklsjflksjfklafjklajfklasjflkasjfmckjgoırjfııjfımcımceomwjjakjlksajfkajfkljfkamckjakmal"},
                new Product(){ProductName = "zeynep Davul", ProductPrice ="520",ProductIsApproved= true,ProductCode = "643247", ProductStoct = 34, CategoryId = 5,ProductHome = true, ProductDescription = "jsdkajdlksajdklsdjkljdlkjdkljdkljdkljdkladjlkasjkljfkljakfjklsfjklsjflksjfklafjklajfklasjflkasjfmckjgoırjfııjfımcımceomwjjakjlksajfkajfkljfkamckjakmal"},
                new Product(){ProductName = "çello Davul", ProductPrice ="520",ProductIsApproved= true,ProductCode = "643247", ProductStoct = 34, CategoryId = 5, ProductDescription = "jsdkajdlksajdklsdjkljdlkjdkljdkljdkljdkladjlkasjkljfkljakfjklsfjklsjflksjfklafjklajfklasjflkasjfmckjgoırjfııjfımcımceomwjjakjlksajfkajfkljfkamckjakmal"},
                new Product(){ProductName = "gariban Davul", ProductPrice ="520",ProductIsApproved= true, ProductCode = "643247",ProductStoct = 34, CategoryId = 5, ProductDescription = "jsdkajdlksajdklsdjkljdlkjdkljdkljdkljdkladjlkasjkljfkljakfjklsfjklsjflksjfklafjklajfklasjflkasjfmckjgoırjfııjfımcımceomwjjakjlksajfkajfkljfkamckjakmal"},
                new Product(){ProductName = "bir seni sevdim Davul", ProductPrice ="520",ProductIsApproved= true, ProductCode = "643247",ProductStoct = 34, CategoryId = 5,ProductHome = true, ProductDescription = "jsdkajdlksajdklsdjkljdlkjdkljdkljdkljdkladjlkasjkljfkljakfjklsfjklsjflksjfklafjklajfklasjflkasjfmckjgoırjfııjfımcımceomwjjakjlksajfkajfkljfkamckjakmal"},

                new Product(){ProductName = "Yamaha Zurna", ProductPrice ="520",ProductIsApproved= true, ProductStoct = 34,ProductCode = "643247", CategoryId = 6, ProductDescription = "jsdkajdlksajdklsdjkljdlkjdkljdkljdkljdkladjlkasjkljfkljakfjklsfjklsjflksjfklafjklajfklasjflkasjfmckjgoırjfııjfımcımceomwjjakjlksajfkajfkljfkamckjakmal"},
                new Product(){ProductName = "zeynep Zurna", ProductPrice ="520",ProductIsApproved= true, ProductStoct = 34,ProductCode = "643247", CategoryId = 6,ProductHome = true, ProductDescription = "jsdkajdlksajdklsdjkljdlkjdkljdkljdkljdkladjlkasjkljfkljakfjklsfjklsjflksjfklafjklajfklasjflkasjfmckjgoırjfııjfımcımceomwjjakjlksajfkajfkljfkamckjakmal"},
                new Product(){ProductName = "çello Zurna", ProductPrice ="520",ProductIsApproved= true, ProductStoct = 34, ProductCode = "643247",CategoryId = 6, ProductDescription = "jsdkajdlksajdklsdjkljdlkjdkljdkljdkljdkladjlkasjkljfkljakfjklsfjklsjflksjfklafjklajfklasjflkasjfmckjgoırjfııjfımcımceomwjjakjlksajfkajfkljfkamckjakmal"},
                new Product(){ProductName = "gariban Zurna", ProductPrice ="520",ProductIsApproved= true, ProductStoct = 34, ProductCode = "643247",CategoryId = 6, ProductHome = true,ProductDescription = "jsdkajdlksajdklsdjkljdlkjdkljdkljdkljdkladjlkasjkljfkljakfjklsfjklsjflksjfklafjklajfklasjflkasjfmckjgoırjfııjfımcımceomwjjakjlksajfkajfkljfkamckjakmal"},
                new Product(){ProductName = "bir seni sevdim Zurna", ProductPrice ="520",ProductIsApproved= true, ProductStoct = 34,ProductCode = "643247", CategoryId = 6, ProductDescription = "jsdkajdlksajdklsdjkljdlkjdkljdkljdkljdkladjlkasjkljfkljakfjklsfjklsjflksjfklafjklajfklasjflkasjfmckjgoırjfııjfımcımceomwjjakjlksajfkajfkljfkamckjakmal"},
            };
            foreach (var product in products)
            {
                context.Products.Add(product);
            }
            context.SaveChanges();

            base.Seed(context);
        }
    }
}