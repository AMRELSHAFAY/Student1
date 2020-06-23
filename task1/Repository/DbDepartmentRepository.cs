using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using task1.Models;

namespace task1.Repository
{
    public interface IDepartment
    {
        public List<Department> GetDepartments();
    }
    public class DbDepartmentRepository : IDepartment
    {
        School _Dep;
        public DbDepartmentRepository(School dep)
        {
            _Dep = dep;
        }
        public List<Department> GetDepartments()
        {
            return _Dep.Departments.ToList<Department>();
                }
    }
}
