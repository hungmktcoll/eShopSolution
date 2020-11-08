using eShopSolution.Data.Entities;
using eShopSolution.Data.Enums;
using Microsoft.AspNetCore.Identity;
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
            var ADMIN_ID = new Guid("75BA9D25-D8C2-46C6-97ED-99622DE6EC8A");
            // any guid, but nothing is against to use the same one
            var ROLE_ID = new Guid("4BF5905E-9383-4749-9AE8-5232534A34B6");
            modelBuilder.Entity<AppRole>().HasData(new AppRole
            {
                Id = ROLE_ID,
                Name = "admin",
                NormalizedName = "admin",
                Description = "Administrator role"
            });

            var hasher = new PasswordHasher<AppUser>();
            modelBuilder.Entity<AppUser>().HasData(new AppUser
            {
                Id = ADMIN_ID,
                UserName = "admin",
                NormalizedUserName = "admin",
                Email = "hungmktcoll@gmail.com",
                NormalizedEmail = "hungmktcoll@gmail.com",
                EmailConfirmed = true,
                PasswordHash = hasher.HashPassword(null, "SOME_ADMIN_PLAIN_PASSWORD"),
                SecurityStamp = string.Empty,
                FirstName = "Hung",
                LastName = "Dong",
                Dob = new DateTime(2020,07,11)
            });

            modelBuilder.Entity<IdentityUserRole<Guid>>().HasData(new IdentityUserRole<Guid>
            {
                RoleId = ROLE_ID,
                UserId = ADMIN_ID
            });
        }
    }
}
