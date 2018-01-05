using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CelebrateInASnap.Models
{
    public class Product
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public string Description { get; set; }
        public string ImagePath { get; set; }
        public decimal UnitPrice { get; set; }
        public bool IsPreferredProduct { get; set; }
        public int? CategoryId { get; set; }
        public virtual Category Category { get; set; }
    }
}
