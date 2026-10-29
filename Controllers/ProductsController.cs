using Microsoft.AspNetCore.Mvc;

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
        return View(); // klasör: Views/Products/Details.cshtml
    }
}
