using Microsoft.AspNetCore.Mvc;
using mvc_project.Models;

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
        Course course = new Course
        {
            Title = "React Kursu",
            Image = "1.jpg"
        };

        return View(course);
    }

    public ActionResult List()
    {
        Course course1 = new Course
        {
            Image = "1.jpg",
            Title = "Java Kursu"
        };

        Course course2 = new Course
        {
            Image = "3.jpg",
            Title = ".Net Core Kursu"
        };

        List<Course> courseList = [course1, course2];

        return View(courseList); // klasör: Views/Course/List.cshtml
    }
}
