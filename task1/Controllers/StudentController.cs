using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using task1.Models;
using task1.Repository;

namespace task1.Controllers
{
    public class StudentController : Controller
    {
        IStudent _stud;
        IDepartment _dept;
       
        public StudentController(IStudent std,IDepartment dept)
        {
            _stud = std;
            _dept = dept;
       
        }
        
        public IActionResult Index()
        {
            return View(_stud.GetStudent());
        }

       
        public IActionResult Add()
        {
            ViewBag.DeptID = new SelectList(_dept.GetDepartments(), "DeptID", "DeptName");
            return View();
        }
       
        [HttpPost]
        public IActionResult Add(Student std)
        {
            _stud.AddStudent(std);
            return RedirectToAction("Index");
        }
        
        [HttpGet]
        public IActionResult EditStudent(int id)
        {
            Student std = _stud.GetStudentDetails(id);
            ViewBag.DeptID = new SelectList(_dept.GetDepartments(), "DeptID", "DeptName",std.DeptID);
            return View(std);
        }
       
        [HttpPost]
        public IActionResult EditStudent(Student stdl)
        {
            _stud.EditStudent(stdl);
            return RedirectToAction("Index");
        }
        
        public IActionResult DeleteStudent(int id)
        {
            _stud.DeleteStudent(id);
            return RedirectToAction("Index");
        }

        public IActionResult Details(int id)
        {
            
            return View(_stud.GetStudentDetails(id));
        }
    }
}