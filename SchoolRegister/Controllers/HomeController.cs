using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SchollRegister.Data.Entity;
using SchollRegister.Models;

namespace SchollRegister.Controllers
{
    public class HomeController : Controller
    {
        private SchoolContext _Context;
        public HomeController(SchoolContext context)
        {
            _Context = context;
            //_Context.Students.Add(new Student { Name = "Jafrul Hasan",Year="FirstYear"});
            //_Context.Students.Add(new Student { Name = "Mehedy Hasan",Year="FirstYear"});
            //_Context.Students.Add(new Student { Name = "Kamrul Hasan",Year="FirstYear"});
            //_Context.Students.Add(new Student { Name = "Delower Hossen",Year="FirstYear"});

            //_Context.Courses.Add(new Course { Name = "Basic Programming" });
            //_Context.Courses.Add(new Course { Name = "English & Economics" });
            //_Context.Courses.Add(new Course { Name = "Physics" });
            //_Context.Courses.Add(new Course { Name = "Math: Intregration" });
            //_Context.Courses.Add(new Course { Name = "Mecanical Engineering" });

            //_Context.StudentCourses.Add(new StudentCourse { CourseId = 1, StudentId = 1 });
            //_Context.StudentCourses.Add(new StudentCourse { CourseId = 2, StudentId = 2 });
            //_Context.StudentCourses.Add(new StudentCourse { CourseId = 3, StudentId = 3 });
            //_Context.StudentCourses.Add(new StudentCourse { CourseId = 4, StudentId = 4 });
            //_Context.StudentCourses.Add(new StudentCourse { CourseId = 5, StudentId = 1 });

            //var stuJaf = _Context.Students.Where(ID => ID.Id == 1).FirstOrDefault();

            //stuJaf.SchoolCourses = _Context.StudentCourses.Where(Id => Id.StudentId == 1).ToList();

           // stuJaf.SchoolCourses.Add(_Context.StudentCourses.Where(ID => ID.CourseId == 1).FirstOrDefault() );
            //stuJaf.SchoolCourses.Add(new StudentCourse {StudentId=1,CourseId=3 });
            //stuJaf.SchoolCourses.Add(new StudentCourse {StudentId=1,CourseId=4 });
            //stuJaf.SchoolCourses.Add(new StudentCourse {StudentId=1,CourseId=5 });

            //foreach(var a in stuJaf.SchoolCourses)
            //{
            //    a.Course = _Context.Courses.Where(Id => Id.Id == a.CourseId).FirstOrDefault();

            //}
            //_Context.SaveChanges();
        }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
