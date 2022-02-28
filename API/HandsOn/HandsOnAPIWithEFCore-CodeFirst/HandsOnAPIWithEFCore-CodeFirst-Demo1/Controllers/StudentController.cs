using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HandsOnAPIWithEFCore_CodeFirst_Demo1.Entities;
using HandsOnAPIWithEFCore_CodeFirst_Demo1.DBAccess;
namespace HandsOnAPIWithEFCore_CodeFirst_Demo1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        private readonly HappyDB228Context happyDB228Context;
        public StudentController()
        {
            this.happyDB228Context = new HappyDB228Context();
        }
        [HttpPost]
        [Route("AddStudent")]
        public IActionResult Add(Student student)
        {
            happyDB228Context.Students.Add(student); //addes new student details to db table
            happyDB228Context.SaveChanges();
            return Ok("Record Added");
        }
        [HttpGet]
        [Route("GetStudents")]
        public IActionResult GetAll()
        {
            List<Student> students = happyDB228Context.Students.ToList(); //return list of students
            return Ok(students);
        }
        [HttpGet]
        [Route("GetStudent/{id}")]
        public IActionResult GetStudent(int id)
        {
            Student student = happyDB228Context.Students.Find(id);
            return Ok(student);
        }
        [HttpDelete]
        [Route("DeleteStudent/{id}")]
        public IActionResult DeleteStudent(int id)
        {
            Student student = happyDB228Context.Students.Find(id);
            if (student != null)
            {
                //Remove Student from table
                happyDB228Context.Students.Remove(student);
                happyDB228Context.SaveChanges();
                return Ok(student);
            }
            else
            {
                return NotFound("Invalid Id");
            }
        }
        [HttpPut]
        [Route("EditStudent")]
        public IActionResult Edit(Student student)
        {
            happyDB228Context.Students.Update(student); //update student details to db table
            happyDB228Context.SaveChanges();
            return Ok("Record Edited");
        }

    }
}
