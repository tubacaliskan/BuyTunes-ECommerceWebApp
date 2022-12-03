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
                new MainCategory(){MainCategoryName = "Telli", Description = "Telli Çalgılar"},
                new MainCategory(){MainCategoryName = "Vurmalı", Description = "Vurmalı Çalgılar"},
                new MainCategory(){MainCategoryName = "Tuşlu", Description = "Tuşlu Çalgılar"},
                new MainCategory(){MainCategoryName = "Zilli", Description = "Zilli Çalgılar"},
                new MainCategory(){MainCategoryName = "Üflemeli", Description = "Üflemeli Çalgılar"},
            };
            foreach (var mainCategory in mainCategories)
            {
                context.MainCategories.Add(mainCategory);
            }
            context.SaveChanges();

            List<Category> categories = new List<Category>()
            {
                 new Category(){CategoryName = "Keman", Description = "Keman Ürünleri", MainCategoryId = 1},
                 new Category(){CategoryName = "Gitar", Description = "Gitar Ürünleri",  MainCategoryId = 1},
                 new Category(){CategoryName = "Saz", Description = "Saz Ürünleri",  MainCategoryId = 1},
                 new Category(){CategoryName = "Flut", Description = "Flut Ürünleri", MainCategoryId = 5},
                 new Category(){CategoryName = "Davul", Description = "Davul Ürünleri",  MainCategoryId = 2},
                 new Category(){CategoryName = "Zurna", Description = "Zurna Ürünleri", MainCategoryId = 5},
            };

            foreach (var category in categories)
            {
                context.Categories.Add(category);
            }
            context.SaveChanges();

            List<Product> products = new List<Product>()
            {
                new Product(){ProductName = "Yamaha Keman", ProductPrice ="520", ProductCode = "643247", ProductIsApproved= true, ProductHome = true, ProductStoct = 34, CategoryId = 1, ProductDescription = "jsdkajdlksajdklsdjkljdlkjdkljdkljdkljdkladjlkasjkljfkljakfjklsfjklsjflksjfklafjklajfklasjflkasjfmckjgoırjfııjfımcımceomwjjakjlksajfkajfkljfkamckjakmal", ProductImage = "celloBackground.jpg"},
                new Product(){ProductName = "zeynep Keman", ProductPrice ="520",ProductCode = "643247",ProductIsApproved= true, ProductStoct = 0, CategoryId = 1, ProductDescription = "jsdkajdlksajdklsdjkljdlkjdkljdkljdkljdkladjlkasjkljfkljakfjklsfjklsjflksjfklafjklajfklasjflkasjfmckjgoırjfııjfımcımceomwjjakjlksajfkajfkljfkamckjakmal", ProductImage = "celloBackground.jpg"},
                new Product(){ProductName = "çello Keman", ProductPrice ="520",ProductIsApproved= true,ProductCode = "643247", ProductStoct = 7, CategoryId = 1, ProductDescription = "jsdkajdlksajdklsdjkljdlkjdkljdkljdkljdkladjlkasjkljfkljakfjklsfjklsjflksjfklafjklajfklasjflkasjfmckjgoırjfııjfımcımceomwjjakjlksajfkajfkljfkamckjakmal", ProductImage = "celloBackground.jpg"} ,
                new Product(){ProductName = "gariban Keman", ProductPrice ="520",ProductIsApproved= true, ProductStoct = 10,ProductCode = "643247",ProductHome = true, CategoryId = 1, ProductDescription = "jsdkajdlksajdklsdjkljdlkjdkljdkljdkljdkladjlkasjkljfkljakfjklsfjklsjflksjfklafjklajfklasjflkasjfmckjgoırjfııjfımcımceomwjjakjlksajfkajfkljfkamckjakmal", ProductImage = "celloBackground.jpg"},
                new Product(){ProductName = "bir seni sevdim Keman", ProductPrice ="520",ProductIsApproved= true,ProductCode = "643247", ProductStoct = 34, CategoryId = 1, ProductDescription = "jsdkajdlksajdklsdjkljdlkjdkljdkljdkljdkladjlkasjkljfkljakfjklsfjklsjflksjfklafjklajfklasjflkasjfmckjgoırjfııjfımcımceomwjjakjlksajfkajfkljfkamckjakmal", ProductImage = "celloBackground.jpg"},

                new Product(){ProductName = "Yamaha gitar", ProductPrice ="520",ProductIsApproved= true,ProductCode = "643247", ProductStoct = 34, CategoryId = 2, ProductDescription = "jsdkajdlksajdklsdjkljdlkjdkljdkljdkljdkladjlkasjkljfkljakfjklsfjklsjflksjfklafjklajfklasjflkasjfmckjgoırjfııjfımcımceomwjjakjlksajfkajfkljfkamckjakmal", ProductImage = "celloBackground.jpg"},
                new Product(){ProductName = "zeynep gitar", ProductPrice ="520",ProductIsApproved= true, ProductStoct = 34,ProductCode = "643247",ProductHome = true, CategoryId = 2, ProductDescription = "jsdkajdlksajdklsdjkljdlkjdkljdkljdkljdkladjlkasjkljfkljakfjklsfjklsjflksjfklafjklajfklasjflkasjfmckjgoırjfııjfımcımceomwjjakjlksajfkajfkljfkamckjakmal", ProductImage = "celloBackground.jpg"},
                new Product(){ProductName = "çello gitar", ProductPrice ="520",ProductIsApproved= true, ProductStoct = 34,ProductCode = "643247",ProductHome = true, CategoryId = 2, ProductDescription = "jsdkajdlksajdklsdjkljdlkjdkljdkljdkljdkladjlkasjkljfkljakfjklsfjklsjflksjfklafjklajfklasjflkasjfmckjgoırjfııjfımcımceomwjjakjlksajfkajfkljfkamckjakmal", ProductImage = "celloBackground.jpg"},
                new Product(){ProductName = "gariban gitar", ProductPrice ="520",ProductIsApproved= true, ProductCode = "643247",ProductStoct = 34,ProductHome = true, CategoryId = 2, ProductDescription = "jsdkajdlksajdklsdjkljdlkjdkljdkljdkljdkladjlkasjkljfkljakfjklsfjklsjflksjfklafjklajfklasjflkasjfmckjgoırjfııjfımcımceomwjjakjlksajfkajfkljfkamckjakmal", ProductImage = "celloBackground.jpg"},
                new Product(){ProductName = "bir seni sevdim gitar", ProductPrice ="520",ProductIsApproved= true, ProductCode = "643247",ProductStoct = 34, CategoryId = 2, ProductDescription = "jsdkajdlksajdklsdjkljdlkjdkljdkljdkljdkladjlkasjkljfkljakfjklsfjklsjflksjfklafjklajfklasjflkasjfmckjgoırjfııjfımcımceomwjjakjlksajfkajfkljfkamckjakmal",ProductImage = "celloBackground.jpg"},

                new Product(){ProductName = "Yamaha saz", ProductPrice ="520",ProductIsApproved= true,ProductCode = "643247", ProductStoct = 34, CategoryId = 3, ProductDescription = "jsdkajdlksajdklsdjkljdlkjdkljdkljdkljdkladjlkasjkljfkljakfjklsfjklsjflksjfklafjklajfklasjflkasjfmckjgoırjfııjfımcımceomwjjakjlksajfkajfkljfkamckjakmal",ProductImage = "celloBackground.jpg"},
                new Product(){ProductName = "zeynep saz", ProductPrice ="520",ProductIsApproved= true, ProductCode = "643247",ProductStoct = 34, CategoryId = 3, ProductDescription = "jsdkajdlksajdklsdjkljdlkjdkljdkljdkljdkladjlkasjkljfkljakfjklsfjklsjflksjfklafjklajfklasjflkasjfmckjgoırjfııjfımcımceomwjjakjlksajfkajfkljfkamckjakmal",ProductImage = "celloBackground.jpg"},
                new Product(){ProductName = "çello saz", ProductPrice ="520",ProductIsApproved= true, ProductCode = "643247",ProductStoct = 34,ProductHome = true, CategoryId = 3, ProductDescription = "jsdkajdlksajdklsdjkljdlkjdkljdkljdkljdkladjlkasjkljfkljakfjklsfjklsjflksjfklafjklajfklasjflkasjfmckjgoırjfııjfımcımceomwjjakjlksajfkajfkljfkamckjakmal",ProductImage = "celloBackground.jpg"},
                new Product(){ProductName = "gariban saz", ProductPrice ="520",ProductIsApproved= true,ProductCode = "643247", ProductStoct = 34, CategoryId = 3, ProductDescription = "jsdkajdlksajdklsdjkljdlkjdkljdkljdkljdkladjlkasjkljfkljakfjklsfjklsjflksjfklafjklajfklasjflkasjfmckjgoırjfııjfımcımceomwjjakjlksajfkajfkljfkamckjakmal",ProductImage = "celloBackground.jpg"},
                new Product(){ProductName = "bir seni sevdim saz", ProductPrice ="520",ProductIsApproved= true,ProductCode = "643247", ProductStoct = 34, CategoryId = 3, ProductDescription = "jsdkajdlksajdklsdjkljdlkjdkljdkljdkljdkladjlkasjkljfkljakfjklsfjklsjflksjfklafjklajfklasjflkasjfmckjgoırjfııjfımcımceomwjjakjlksajfkajfkljfkamckjakmal",ProductImage = "celloBackground.jpg"},

                new Product(){ProductName = "Yamaha Flut", ProductPrice ="520",ProductIsApproved= true, ProductCode = "643247",ProductStoct = 34, CategoryId = 4,ProductHome = true, ProductDescription = "jsdkajdlksajdklsdjkljdlkjdkljdkljdkljdkladjlkasjkljfkljakfjklsfjklsjflksjfklafjklajfklasjflkasjfmckjgoırjfııjfımcımceomwjjakjlksajfkajfkljfkamckjakmal",ProductImage = "celloBackground.jpg"},
                new Product(){ProductName = "zeynep Flut", ProductPrice ="520",ProductIsApproved= true, ProductCode = "643247",ProductStoct = 34, CategoryId = 4,ProductHome = true, ProductDescription = "jsdkajdlksajdklsdjkljdlkjdkljdkljdkljdkladjlkasjkljfkljakfjklsfjklsjflksjfklafjklajfklasjflkasjfmckjgoırjfııjfımcımceomwjjakjlksajfkajfkljfkamckjakmal",ProductImage = "celloBackground.jpg"},
                new Product(){ProductName = "çello Flut", ProductPrice ="520",ProductIsApproved= true, ProductCode = "643247",ProductStoct = 34, CategoryId = 4, ProductDescription = "jsdkajdlksajdklsdjkljdlkjdkljdkljdkljdkladjlkasjkljfkljakfjklsfjklsjflksjfklafjklajfklasjflkasjfmckjgoırjfııjfımcımceomwjjakjlksajfkajfkljfkamckjakmal",ProductImage = "celloBackground.jpg"},
                new Product(){ProductName = "gariban Flut", ProductPrice ="520",ProductIsApproved= true,ProductCode = "643247", ProductStoct = 34, CategoryId = 4, ProductDescription = "jsdkajdlksajdklsdjkljdlkjdkljdkljdkljdkladjlkasjkljfkljakfjklsfjklsjflksjfklafjklajfklasjflkasjfmckjgoırjfııjfımcımceomwjjakjlksajfkajfkljfkamckjakmal",ProductImage = "celloBackground.jpg"},
                new Product(){ProductName = "bir seni sevdim Flut", ProductPrice ="520",ProductIsApproved= true,ProductCode = "643247", ProductStoct = 34, CategoryId = 4, ProductDescription = "jsdkajdlksajdklsdjkljdlkjdkljdkljdkljdkladjlkasjkljfkljakfjklsfjklsjflksjfklafjklajfklasjflkasjfmckjgoırjfııjfımcımceomwjjakjlksajfkajfkljfkamckjakmal",ProductImage = "celloBackground.jpg"},

                new Product(){ProductName = "Yamaha Davul", ProductPrice ="520",ProductIsApproved= true,ProductCode = "643247", ProductStoct = 34, CategoryId = 5, ProductDescription = "jsdkajdlksajdklsdjkljdlkjdkljdkljdkljdkladjlkasjkljfkljakfjklsfjklsjflksjfklafjklajfklasjflkasjfmckjgoırjfııjfımcımceomwjjakjlksajfkajfkljfkamckjakmal",ProductImage = "celloBackground.jpg"},
                new Product(){ProductName = "zeynep Davul", ProductPrice ="520",ProductIsApproved= true,ProductCode = "643247", ProductStoct = 34, CategoryId = 5,ProductHome = true, ProductDescription = "jsdkajdlksajdklsdjkljdlkjdkljdkljdkljdkladjlkasjkljfkljakfjklsfjklsjflksjfklafjklajfklasjflkasjfmckjgoırjfııjfımcımceomwjjakjlksajfkajfkljfkamckjakmal",ProductImage = "celloBackground.jpg"},
                new Product(){ProductName = "çello Davul", ProductPrice ="520",ProductIsApproved= true,ProductCode = "643247", ProductStoct = 34, CategoryId = 5, ProductDescription = "jsdkajdlksajdklsdjkljdlkjdkljdkljdkljdkladjlkasjkljfkljakfjklsfjklsjflksjfklafjklajfklasjflkasjfmckjgoırjfııjfımcımceomwjjakjlksajfkajfkljfkamckjakmal",ProductImage = "celloBackground.jpg"},
                new Product(){ProductName = "gariban Davul", ProductPrice ="520",ProductIsApproved= true, ProductCode = "643247",ProductStoct = 34, CategoryId = 5, ProductDescription = "jsdkajdlksajdklsdjkljdlkjdkljdkljdkljdkladjlkasjkljfkljakfjklsfjklsjflksjfklafjklajfklasjflkasjfmckjgoırjfııjfımcımceomwjjakjlksajfkajfkljfkamckjakmal",ProductImage = "celloBackground.jpg"},
                new Product(){ProductName = "bir seni sevdim Davul", ProductPrice ="520",ProductIsApproved= true, ProductCode = "643247",ProductStoct = 34, CategoryId = 5,ProductHome = true, ProductDescription = "jsdkajdlksajdklsdjkljdlkjdkljdkljdkljdkladjlkasjkljfkljakfjklsfjklsjflksjfklafjklajfklasjflkasjfmckjgoırjfııjfımcımceomwjjakjlksajfkajfkljfkamckjakmal",ProductImage = "celloBackground.jpg"},

                new Product(){ProductName = "Yamaha Zurna", ProductPrice ="520",ProductIsApproved= true, ProductStoct = 34,ProductCode = "643247", CategoryId = 6, ProductDescription = "jsdkajdlksajdklsdjkljdlkjdkljdkljdkljdkladjlkasjkljfkljakfjklsfjklsjflksjfklafjklajfklasjflkasjfmckjgoırjfııjfımcımceomwjjakjlksajfkajfkljfkamckjakmal",ProductImage = "celloBackground.jpg"},
                new Product(){ProductName = "zeynep Zurna", ProductPrice ="520",ProductIsApproved= true, ProductStoct = 34,ProductCode = "643247", CategoryId = 6,ProductHome = true, ProductDescription = "jsdkajdlksajdklsdjkljdlkjdkljdkljdkljdkladjlkasjkljfkljakfjklsfjklsjflksjfklafjklajfklasjflkasjfmckjgoırjfııjfımcımceomwjjakjlksajfkajfkljfkamckjakmal",ProductImage = "celloBackground.jpg"},
                new Product(){ProductName = "çello Zurna", ProductPrice ="520",ProductIsApproved= true, ProductStoct = 34, ProductCode = "643247",CategoryId = 6, ProductDescription = "jsdkajdlksajdklsdjkljdlkjdkljdkljdkljdkladjlkasjkljfkljakfjklsfjklsjflksjfklafjklajfklasjflkasjfmckjgoırjfııjfımcımceomwjjakjlksajfkajfkljfkamckjakmal",ProductImage = "celloBackground.jpg"},
                new Product(){ProductName = "gariban Zurna", ProductPrice ="520",ProductIsApproved= true, ProductStoct = 34, ProductCode = "643247",CategoryId = 6, ProductHome = true,ProductDescription = "jsdkajdlksajdklsdjkljdlkjdkljdkljdkljdkladjlkasjkljfkljakfjklsfjklsjflksjfklafjklajfklasjflkasjfmckjgoırjfııjfımcımceomwjjakjlksajfkajfkljfkamckjakmal",ProductImage = "celloBackground.jpg"},
                new Product(){ProductName = "bir seni sevdim Zurna", ProductPrice ="520",ProductIsApproved= true, ProductStoct = 34,ProductCode = "643247", CategoryId = 6, ProductDescription = "jsdkajdlksajdklsdjkljdlkjdkljdkljdkljdkladjlkasjkljfkljakfjklsfjklsjflksjfklafjklajfklasjflkasjfmckjgoırjfııjfımcımceomwjjakjlksajfkajfkljfkamckjakmal",ProductImage = "celloBackground.jpg"},
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