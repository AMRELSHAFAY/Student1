using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace task1.Models
{
    public class Student
    {
        public int id { get; set; }

        [Required]
        public string Name{ get; set; }

        [Range(10,20)]
        public int Age{ get; set; }

        [ForeignKey("Department")]
        public int DeptID { get; set; }

        public Department Department { get; set; }
    }
}
