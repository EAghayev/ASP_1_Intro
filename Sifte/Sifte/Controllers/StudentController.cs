using Microsoft.AspNetCore.Mvc;
using Sifte.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sifte.Controllers
{
    public class StudentController:Controller
    {
        private List<Student> _students;
        public StudentController()
        {
                _students = new List<Student>
            {
                new Student{Id = 1,Name="Hesen",Surname="Seyfullayev",GroupNo="P201"},
                new Student{Id = 2,Name="Elnur",Surname="Huseynov",GroupNo="P200"},
                new Student{Id = 3,Name="Elnur",Surname="Akula",GroupNo="P202"},
                new Student{Id = 4,Name="Togrul",Surname="Niva",GroupNo="P201"}
            };
        }
        public ActionResult Index()
        {

            ViewBag.Students = _students;

            return View();
        }

        public ActionResult Detail(int id)
        {
            Student std = _students.Find(x => x.Id == id);
            ViewBag.Student = std;

            return View();
        }
    }
}
