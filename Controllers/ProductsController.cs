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
        return View(); // klasör: Views/Products/List.cshtml
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
