using StudentManagementSystem.Common.CustomValidation;
using System.ComponentModel.DataAnnotations;

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
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}")]
        [DataType(DataType.Date)]
        [ValidateBirthDate]
        public DateTime BirthDate { get; set; }

        [Display(Name = "High school")]
        public string? HighSchool { get; set; }

        public string? Address { get; set; }

        [Required]
        [Display(Name = "Department")]
        public int DepartmentId { get; set; }  
    }
}
