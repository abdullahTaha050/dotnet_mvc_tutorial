using Microsoft.AspNetCore.Mvc;
using mvc_project.Models;

namespace mvc_project.Controllers;

public class ProductsController : Controller
{

    public ActionResult Index()
    {
        return View(); // klasör: Views/Products/Index.cshtml
    }

    public ActionResult List()
    {
        List<Product> productList = new List<Product>{
            new Product { Title = "Samsung S10", Description = "128 Gb telefon", IsSale = true, Photo = "1.jpg", Price = 20},
            new Product { Title = "iPhone Duo", Description = "512 Gb telefon", IsSale = true, Photo = "2.jpg", Price = 30},
        };

        return View(productList); // klasör: Views/Products/List.cshtml
    }

    public ActionResult Details()
    {
        Product product1 = new()
        {
            Title = "iPhone 15",
            Description = "256 Gb Telefon",
            IsSale = true,
            Photo = "2.jpg",
            Price = 50000
        };
        return View(product1); // klasör: Views/Products/Details.cshtml
    }
}
