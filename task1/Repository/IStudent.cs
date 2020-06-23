using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using task1.Models;

namespace task1.Repository
{
   public interface IStudent
    {
         void AddStudent(Student stud);
         void DeleteStudent(int id);
         void EditStudent(Student stud);
         List<Student> GetStudent();
         Student GetStudentDetails(int id);

    }
}
