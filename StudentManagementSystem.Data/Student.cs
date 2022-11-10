using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagementSystem.Data
{
    public class Student : User
    {
        public string? HighSchool { get; set; }
        public string? Address { get; set; }
        public DateTime? BirthDate { get; set; }

        [ForeignKey("DepartmentId")]
        public Department department;
    }
}
