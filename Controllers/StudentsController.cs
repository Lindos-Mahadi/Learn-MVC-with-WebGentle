using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApp_MVC_AllTopics_with_WebGentle.Models;


namespace WebApp_MVC_AllTopics_with_WebGentle.Controllers
{
    public class StudentsController : Controller
    {
        // GET: Students
        [Route("students")]
        public ActionResult GetAllStudent()
        {
            var students = Students();
            return View(students);
        }

        // GET: Students/Details/5
        [Route("students/{id}")]
        public ActionResult GetStudent(int id)
        {
            var students = Students().FirstOrDefault(x => x.StudentID == id);
            return View(students);
        }
        [Route("students/{id}/address")]
        public ActionResult GetStudentAddress(int id)
        {
            var studentAddress = Students().Where(x => x.StudentID == id).Select(x => x.StudentAddress).FirstOrDefault();
            return View(studentAddress);
        }
        private List<Student> Students()
        {
            return new List<Student>()
            {
                new Student()
                {
                    StudentID = 1,
                    StudentName = "Lindos",
                    Standard = "First",
                    StudentAddress = new StudentAddress()
                    {
                        HomeNumber = "10",
                        City = "Dhaka",
                        State = "Dhaka division"
                    },
                },
                new Student()
                {
                    StudentID = 2,
                    StudentName = "Lindos 2",
                    Standard = "Second",
                    StudentAddress = new StudentAddress()
                    {
                        HomeNumber = "1010",
                        City = "Khulna",
                        State = "Khulna division"
                    },
                },
                new Student()
                {
                    StudentID = 3,
                    StudentName = "Lindos 3",
                    Standard = "Four",
                    StudentAddress = new StudentAddress()
                    {
                        HomeNumber = "101020",
                        City = "Gazipur",
                        State = "Dhaka division"
                    },
                },
                new Student()
                {
                    StudentID = 5,
                    StudentName = "Lindos 5",
                    Standard = "Five",
                    StudentAddress = new StudentAddress()
                    {
                        HomeNumber = "101030",
                        City = "Dinazpur",
                        State = "Dinazpur division"
                    },
                },
                new Student()
                {
                    StudentID = 5,
                    StudentName = "Lindos 6",
                    Standard = "Six",
                    StudentAddress = new StudentAddress()
                    {
                        HomeNumber = "101040",
                        City = "Joshor",
                        State = "Joshor division"
                    },
                },
            };
        }
    }
}
