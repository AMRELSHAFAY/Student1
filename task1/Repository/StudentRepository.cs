using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using task1.Models;

namespace task1.Repository
{
    public class StudentRepository:IStudent
    {
        static List<Student> Students = new List<Student>()
        {
            new Student(){id=1,Name="Amr",Age=20},
            new Student(){id=2,Name="Magdi",Age=25},
            new Student(){id=3,Name="Elshafai",Age=30},
        };

        public List<Student> GetStudent()
        {
            return Students;
        }

        public void AddStudent(Student stud)
        {
            this.GetStudent().Add(stud);
            
        }
        [HttpGet]
        public Student EditStudent(int id)
        {
             Student stud=Students.Find(a => a.id==id);
            return stud;

        }

       

        public Student GetStudentDetails(int id)
        {
            return this.GetStudent().Find(a => a.id == id);
        }

        public void DeleteStudent(int id)
        {
            Student stud = this.GetStudentDetails(id);
            this.GetStudent().Remove(stud);
        }
        [HttpGet]
        public void EditStudent(Student stdl)
        {
            Student studt = this.GetStudent().FirstOrDefault(a => a.id == stdl.id);
            studt.id = stdl.id;
            studt.Name = stdl.Name;
            studt.Age = stdl.Age;
        }
    }
}
