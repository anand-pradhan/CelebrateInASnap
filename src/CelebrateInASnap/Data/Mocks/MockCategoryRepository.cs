using CelebrateInASnap.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CelebrateInASnap.Models;

namespace CelebrateInASnap.Data.Mocks
{
    public class MockCategoryRepository : ICategoryRepository
    {
        public IEnumerable<Category> Categories
        {
            get
            {
                return new List<Category>
                {
                    new Category { CategoryName = "Christmas", Description = "Gifts for Chrismas" },
                    new Category { CategoryName = "New Year", Description = "Gifts for New Year" }
                };
            }
        }
    }

}
