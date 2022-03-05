using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HandsOnMVCUsingModels.Models;
namespace HandsOnMVCUsingModels.Repositories
{
    public class StudentRepository
    {
        static List<Student> students = new List<Student>()
            {
                 new Student() { StudentId = 1, Age = 10, StudentName = "Rohan", Std = "III" },
                   new Student() { StudentId = 2, Age = 11, StudentName = "Rishi", Std = "IV" },
                     new Student() { StudentId = 3, Age = 10, StudentName = "Imran", Std = "III" },
                       new Student() { StudentId = 4, Age = 11, StudentName = "Srijan", Std = "IV" },
                         new Student() { StudentId = 5, Age = 10, StudentName = "Sanhitha", Std = "III" },
            };
        public List<Student> GetStudents()
        {
            return students; //return list of students
        }
        public Student GetStudent(int studentId)
        {
            Student student = students.Single(s => s.StudentId == studentId);
            return student;
        }
        public void AddStudent(Student student)
        {
            students.Add(student);
        }
    }
}
