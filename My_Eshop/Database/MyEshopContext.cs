using System;
using Microsoft.EntityFrameworkCore;
using My_Eshop.Models;

namespace My_Eshop.Database
{
    public class MyEshopContext : DbContext
    {
        public MyEshopContext()
        {
        }

        public MyEshopContext(DbContextOptions<MyEshopContext> options) : base(options)
        {

        }

        public DbSet<Category> Categories { get; set; }
        public DbSet<CategoryToProduct> categoryToProducts { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Item> Items { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<CategoryToProduct>()
                .HasKey(t => new { t.ProductId, t.CategoryId });


            modelBuilder.Entity<Item>(
                i => {
                    i.Property(w => w.Price).HasColumnType("Money");
                    i.HasKey(w => w.Id);
                }
                );


            #region seed Data Category

            modelBuilder.Entity<Category>().HasData(


                new Category()
                {
                    Id = 1,
                    Name = "ابزار",
                    Description = "ابزار کاربردی",
                },
                new Category()
                {
                    Id = 2,
                    Name = "لباس",
                    Description = "نمامی برند لباس ها ",
                },
                new Category()
                {
                    Id = 3,
                    Name = "ساعت",
                    Description = "تمامی برند های ساعت",
                },
                new Category()
                {
                    Id = 4,
                    Name = "لواز کاربردی",
                    Description = "لوازم",
                }

                );

            modelBuilder.Entity<Item>().HasData(

                new Item()
                {
                    Id = 1,
                    Price = 854.0M,
                    QuantityInStock = 5
                },

                new Item()
                {
                    Id = 2,
                    Price = 144.8M,
                    QuantityInStock = 8
                },

                new Item()
                {
                    Id = 3 ,
                    Price = 442.0M ,
                    QuantityInStock = 4
                },

                new Item()
                {
                    Id = 4,
                    Price = 2500,
                    QuantityInStock = 3
                }
                );

            modelBuilder.Entity<Product>().HasData(

                new Product
                {
                    Id = 1,
                    ItemId = 1,
                    Name =  "Asp.net Core 3" ,
                    Description = "Asp.net آموزش",
                },


                new Product
                {
                    Id = 2,
                    ItemId = 2,
                    Name = "Blazor‌",
                    Description = "Blazor آموزش",
                },


                new Product
                {
                    Id = 3,
                    ItemId = 3,
                    Name = "PWA",
                    Description = "PWA آموزش",
                },


                new Product
                {
                    Id = 4,
                    ItemId = 4,
                    Name = "Entity",
                    Description = "Entity آموزش",
                }

                );

            modelBuilder.Entity<CategoryToProduct>().HasData(

                new CategoryToProduct() { CategoryId = 1, ProductId = 1 },
                new CategoryToProduct() { CategoryId = 2, ProductId = 1 },
                new CategoryToProduct() { CategoryId = 3, ProductId = 1 },
                new CategoryToProduct() { CategoryId = 4, ProductId = 1 },

                new CategoryToProduct() { CategoryId = 1, ProductId = 2 },
                new CategoryToProduct() { CategoryId = 2, ProductId = 2 },
                new CategoryToProduct() { CategoryId = 3, ProductId = 2 },
                new CategoryToProduct() { CategoryId = 4, ProductId = 2 },

                new CategoryToProduct() { CategoryId = 1, ProductId = 3 },
                new CategoryToProduct() { CategoryId = 2, ProductId = 3 },
                new CategoryToProduct() { CategoryId = 3, ProductId = 3 },
                new CategoryToProduct() { CategoryId = 4, ProductId = 3 },

                new CategoryToProduct() { CategoryId = 1, ProductId = 4 },
                new CategoryToProduct() { CategoryId = 2, ProductId = 4 },
                new CategoryToProduct() { CategoryId = 3, ProductId = 4 },
                new CategoryToProduct() { CategoryId = 4, ProductId = 4 }

                );
            #endregion

            base.OnModelCreating(modelBuilder);
        }
    }
}
