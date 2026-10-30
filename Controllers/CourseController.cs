using Microsoft.AspNetCore.Mvc;
using mvc_project.Models;

namespace mvc_project.Controllers;

public class CourseController : Controller
{

    readonly List<Course> courseList = [new Course
        {
            Id= 1,
            Image = "3.jpg",
            Title = ".Net Core Kursu",
            IsHome = false
        }, new Course
        {
            Id =2,
            Image = "1.jpg",
            Title = "Java Kursu",
            IsHome = true
        }];

    // /course veya /course/index
    public ActionResult Index()
    {

        return View(courseList); // klasör: Views/Course/Index.cshtml
    }

    public ActionResult Details(int id)
    {
        Course course = courseList.FirstOrDefault(x => x.Id == id);

        return View(course);
    }

    public ActionResult List()
    {

        return View(courseList); // klasör: Views/Course/List.cshtml
    }
}
