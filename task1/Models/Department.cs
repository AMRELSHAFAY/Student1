using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace task1.Models
{
    public class Department
    {
        [Key]
        public int DeptID { get; set; }
        public string DeptName { get; set; }

        public List<Student>Students { get; set; }
    }
}
