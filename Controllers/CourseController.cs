using Microsoft.AspNetCore.Mvc;
using mvc_project.Models;

namespace mvc_project.Controllers;

public class CourseController : Controller
{

    List<Course> courseList = [new Course
        {
            Image = "3.jpg",
            Title = ".Net Core Kursu",
            IsHome = false
        }, new Course
        {
            Image = "1.jpg",
            Title = "Java Kursu",
            IsHome = true
        }];

    // /course veya /course/index
    public ActionResult Index()
    {

        return View(courseList); // klasör: Views/Course/Index.cshtml
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

        return View(courseList); // klasör: Views/Course/List.cshtml
    }
}
