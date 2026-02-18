using Exercice6.Interfaces;
using Exercice6.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercice6.Controllers
{
    public class StudentController : Controller
    {
        private List<Student> students { get; set;} = new List<Student>();
        
        private readonly IStudentService _studentService;

        public StudentController(IStudentService studentService)
        {
            _studentService = studentService;
        }
        public IActionResult GetAllStudent()
        {
            string allStudents = "";

            foreach(Student student in students)
            {
                allStudents += student + " , ";
            }
                        
            return View( allStudents);
        }

        [HttpPost]
        public IActionResult TreatForm(Student student)
        {
            if (!ModelState.IsValid)
            {
                return View("DisplayForm", student);
            }
            
            return RedirectToAction("GetAllStudent");
        }

        public IActionResult DisplayForm()
        {
            return View(new Student());
        }
    }
}
