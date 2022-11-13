using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagementSystem.Common.Models
{
    public class StudentVM
    {
        public string Id { get; set; }

        [Required]
        [Display(Name="First name")]
        public string? FirstName { get; set; }

        [Required]
        [Display(Name = "Last name")]
        public string? LastName { get; set; }

        [Required]
        [Display(Name = "Birth date")]
        public DateTime? BirthDate { get; set; }

        [Display(Name = "High school")]
        public string? HighSchool { get; set; }

        public string? Address { get; set; }

        [Required]
        [Display(Name = "Department")]
        public int DepartmentId { get; set; }

    }
}
