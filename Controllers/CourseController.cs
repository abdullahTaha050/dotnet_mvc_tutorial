using Microsoft.AspNetCore.Mvc;

namespace mvc_project.Controllers;

public class CourseController : Controller
{

    // /course veya /course/index
    public ActionResult Index()
    {
        return View(); // klasör: Views/Course/Index.cshtml
    }

    public ActionResult Details()
    {
        return View(); // klasör: Views/Course/Details.cshtml
    }

    public ActionResult List()
    {
        return View(); // klasör: Views/Course/List.cshtml
    }
}
