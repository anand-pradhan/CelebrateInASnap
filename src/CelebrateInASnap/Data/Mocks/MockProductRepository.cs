using CelebrateInASnap.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CelebrateInASnap.Models;

namespace CelebrateInASnap.Data.Mocks
{
    public class MockProductRepository : IProductRepository
    {
        private readonly ICategoryRepository _categoryRepository = new MockCategoryRepository();
        public IEnumerable<Product> PreferredProducts { get; }

        public IEnumerable<Product> Products
        {
            get
            {
                return new List<Product>
                {
                    new Product
                    {
                        ProductName = "Prosecco",
                        Description = "White Desert Wine",
                        Category = _categoryRepository.Categories.First(),
                        UnitPrice = 9.99M,
                    },
                    new Product
                    {
                        ProductName = "Stella Rossa",
                        Description = "Red Desert Wine",
                        Category = _categoryRepository.Categories.First(),
                        UnitPrice = 19.99M,
                    },
                    new Product
                    {
                        ProductName = "Cabernet",
                        Description = "Red Wine",
                        Category = _categoryRepository.Categories.First(),
                        UnitPrice = 16.99M,
                    },
                    new Product
                    {
                        ProductName = "Cheese",
                        Description = "Goat Cheese",
                        Category = _categoryRepository.Categories.First(),
                        UnitPrice = 9.99M,
                    },
                };
            }
        }

        public Product GetProductById(int productId)
        {
            throw new NotImplementedException();
        }
    }
}
