using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HandsOnMVCUsingModels.Models;
using HandsOnMVCUsingModels.Repositories;
namespace HandsOnMVCUsingModels.Controllers
{
    public class StudentController : Controller
    {
        StudentRepository repository;

        public StudentController(StudentRepository repository)
        {
            this.repository = repository;
        }

        //public StudentController()
        //{
        //    repository = new StudentRepository();
        //}
        public IActionResult Index() //Get All Students
        {
            List<Student> students=repository.GetStudents();
            return View(students);
        }
        public IActionResult Details(int studentId) //show the student Details
        {
            Student student = repository.GetStudent(studentId);
            return View(student);
        }
        public IActionResult Create()
        {
            return View();
        }
        public IActionResult Save(Student student)
        {
            repository.AddStudent(student);
            return RedirectToAction("Index"); //Redirects to Index action
           // return RedirectToAction("Index","Home"); //Redirects to Home Controller Index action
        }
        
    }
}
