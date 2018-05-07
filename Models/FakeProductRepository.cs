using System.Collections.Generic;
using System.Linq;

namespace Sportify.Models
{
    public class FakeProductRepository : IProductRepository
    {
        public IQueryable<Product> Products => new List<Product>
        {
            new Product { Name = "Football", Price = 25 },
            new Product { Name = "Baseball Glove", Price = 19 },
            new Product { Name = "Track Shoes", Price = 97 }
        }.AsQueryable<Product>();
    }
}
