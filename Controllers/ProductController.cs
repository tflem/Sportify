using Microsoft.AspNetCore.Mvc;
using Sportify.Models;

namespace Sportify.Controllers
{
    public class ProductController : Controller
    {
        private IProductRepository repository;
        public ProductController(IProductRepository repo)
        {
            repository = repo;
        }

        public ViewResult List() => View(repository.Products);
    }
}
