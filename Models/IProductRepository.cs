using System.Linq;

namespace Sportify.Models
{
    public interface IProductRepository
    {
        IQueryable<Product> Products { get; }
    }
}
