using Microsoft.AspNetCore.Mvc;
using Assignment3.Data;
using Assignment3.Models;
using Assignment3.Services;

namespace Assignment3.Controllers
{
    public class StudentController : Controller
    {
        private readonly IStudentService _studentService;

        public StudentController(IStudentService studentService)
        {
            _studentService=studentService;
        }

        [HttpGet]
        public IActionResult Create()
        {
            
            return View();
        }
        
        
        [HttpPost]
        public IActionResult Create(Student s)
        {
            if (!ModelState.IsValid)
            {
                return View(s);
            }

            _studentService.CreateStudent(s);

            return RedirectToAction("Index", "Student");
        }
        [HttpGet]
        public IActionResult Edit(int index)
        {
            var student = _studentService.GetStudent(index);
            return View(student);
        }
        [HttpPost]
        public IActionResult Edit(Student model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            _studentService.UpdateStudent(model);

            return RedirectToAction("Index", "Student");
        }

        [HttpPost]
        public IActionResult Delete(int id)
        {
            _studentService.DeleteStudent(id);
            return RedirectToAction("Index", "Student");
        }
    }
}