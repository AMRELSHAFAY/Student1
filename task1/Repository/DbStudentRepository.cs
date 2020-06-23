using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using task1.Models;

namespace task1.Repository
{
    public class DbStudentRepository:IStudent
    {
        School _db;
        public DbStudentRepository(School db)
        {
            _db = db;
        }
        //Add Student 
        public void AddStudent(Student stud)
        {
            _db.Students.Add(stud);
            _db.SaveChanges();
        }

        //Delete Student
        public void DeleteStudent(Student stud)
        {
            
            _db.Students.Remove(stud);
            _db.SaveChanges();
        }

        
        public void DeleteStudent(int id)
        {
          Student stud = _db.Students.FirstOrDefault(a => a.id == id);
            _db.Students.Remove(stud);
            _db.SaveChanges();
        }

        //Edit Syudent
        public void EditStudent(Student stud)
        {
            Student oldStudent = _db.Students.FirstOrDefault(a => a.id == stud.id);
            oldStudent.id = stud.id;
            oldStudent.Name = stud.Name;
            oldStudent.Age = stud.Age;
            _db.SaveChanges();
        }

        //Get All Students
        public List<Student> GetStudent()
        {
            return _db.Students.Include(s => s.Department).ToList<Student>();
        }

        //Get One student Details By the ID
        public Student GetStudentDetails(int id)
        {
            return _db.Students.Include(d => d.Department).FirstOrDefault(a => a.id == id);
        }

      
    }
}
