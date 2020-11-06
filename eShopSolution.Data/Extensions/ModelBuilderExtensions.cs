using eShopSolution.Data.Entities;
using eShopSolution.Data.Enums;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace eShopSolution.Data.Extensions
{
    public static class ModelBuilderExtensions
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AppConfig>().HasData(
                new AppConfig() 
                { 
                    Key = "HomeTittle", 
                    Value = "This is home page of eShopSolution"
                },
                new AppConfig() { 
                    Key = "Homekeyword", 
                    Value = "This is home keyword of eShopSolution"
                },
                new AppConfig() { 
                    Key = "Homedescription", 
                    Value = "This is home description of eShopSolution"
                }
            );
            modelBuilder.Entity<Category>().HasData(
                new Category() 
                { 
                    Id = 1,
                    Name = "Thú bông",
                    SeoDescription = "Sản phẩm thú bông",
                    SeoTitle = "Sản phẩm thú bông",
                    SeoAlias = "thu-bong",
                    SortOrder = 1,
                    IsShowOnHome = true,
                    ParentId = null,
                    Status = Status.Active
                },
                new Category()
                {
                    Id = 2,
                    Name = "Gấu bông",
                    SeoDescription = "Sản phẩm gấu bông",
                    SeoTitle = "Sản phẩm gấu bông",
                    SeoAlias = "gau-bong",
                    SortOrder = 1,
                    IsShowOnHome = true,
                    ParentId = 1,
                    Status = Status.Active
                },
                new Category()
                {
                    Id = 3,
                    Name = "Chó bông",
                    SeoDescription = "Sản phẩm chó bông",
                    SeoTitle = "Sản phẩm chó bông",
                    SeoAlias = "cho-bong",
                    SortOrder = 2,
                    IsShowOnHome = true,
                    ParentId = 1,
                    Status = Status.Active
                },
                new Category()
                {
                    Id = 4,
                    Name = "Thú bông khác",
                    SeoDescription = "Sản phẩm gấu bông",
                    SeoTitle = "Sản phẩm gấu bông",
                    SeoAlias = "gau-bong",
                    SortOrder = 3,
                    IsShowOnHome = true,
                    ParentId = 1,
                    Status = Status.Active
                }

            );
            modelBuilder.Entity<Product>().HasData(
                new Product()
                {
                    Id = 1,
                    Name = "Chó bông 1",
                    Description = "Chó bông cho mọi người",
                    Details = "Chó bông cho mọi người",
                    SeoDescription = "Chó bông cho mọi người",
                    SeoTitle = "Chó bông cho mọi người",
                    SeoAlias = "cho-bong-cho-moi-nguoi",
                    Price = 200000,
                    OriginalPrice = 100000,
                    Stock = 0,
                    ViewCount = 0,
                    DateCreated = DateTime.Now
                }
            );
            modelBuilder.Entity<ProductInCategory>().HasData(
                new ProductInCategory()
                {
                    CategoryId = 1,
                    ProductId = 1
                }
            );
        }
    }
}
