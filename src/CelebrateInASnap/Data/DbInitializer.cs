using CelebrateInASnap.Data;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CelebrateInASnap.Models
{
    public class DbInitializer
    {
        public static void Seed(IApplicationBuilder applicationBuilder)
        {
            AppDbContext context =
                applicationBuilder.ApplicationServices.GetRequiredService<AppDbContext>();

            if (!context.Categories.Any())
            {
                context.Categories.AddRange(Categories.Select(c => c.Value));
            }

            if (!context.Products.Any())
            {
                context.AddRange
                (
                    new Product
                    {
                        ProductName = "Prosecco",
                        Description = "White Desert Wine",
                        Category = Categories["Merry Christmas"],
                        UnitPrice = 9.99M,
                        IsPreferredProduct = true
                    },
                    new Product
                    {
                        ProductName = "Stella Rossa",
                        Description = "Red Desert Wine",
                        Category = Categories["Thanks Giving"],
                        UnitPrice = 19.99M,
                        IsPreferredProduct = true
                    },
                    new Product
                    {
                        ProductName = "Cabernet",
                        Description = "Red Wine",
                        Category = Categories["Merry Christmas"],
                        UnitPrice = 16.99M,
                        IsPreferredProduct = true
                    },
                    new Product
                    {
                        ProductName = "Cheese",
                        Description = "Goat Cheese",
                        Category = Categories["Merry Christmas"],
                        UnitPrice = 9.99M,
                        IsPreferredProduct = false
                    }
                );
            }

            context.SaveChanges();
        }

        private static Dictionary<string, Category> categories;
        public static Dictionary<string, Category> Categories
        {
            get
            {
                if (categories == null)
                {
                    var genresList = new Category[]
                    {
                        new Category { CategoryName = "Merry Christmas", Description="Christmas Gift Options" },
                        new Category { CategoryName = "Thanks Giving", Description="Thanks Giving Gift Options" },
                        new Category { CategoryName = "New Year", Description="New Year Gift Options" }
                    };

                    categories = new Dictionary<string, Category>();

                    foreach (Category genre in genresList)
                    {
                        categories.Add(genre.CategoryName, genre);
                    }
                }

                return categories;
            }
        }
    }
}
