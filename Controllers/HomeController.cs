using Microsoft.AspNetCore.Mvc;

namespace mvc_project.Controllers;

public class HomeController : Controller
{


  // /home veya /home/index
  public ActionResult Index()
  {
    return View(); // klasör: Views/Home/Index.cshtml
  }

  // /home/about
  public ActionResult About()
  {
    return View();  // klasör: Views/Home/About.cshtml

  }

  // /home/contact
  public ActionResult Contact()
  {
    return View();  // klasör: Views/Home/Contact.cshtml

  }
}