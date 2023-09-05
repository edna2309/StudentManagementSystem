using StudentManagementSystem.Common.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagementSystem.Data
{
    public class Student : BaseEntity
    {
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? HighSchool { get; set; }
        public string? Address { get; set; }
        public DateTime? BirthDate { get; set; }
        public int DepartmentId { get; set; }

        [ForeignKey("DepartmentId")]
        public Department? Department;
    }
}
