using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagementSystem.Common.Models
{
    public class DepartmentVM
    {
        public int Id { get; set; }

        [Required]
        public string? Name { get; set; }

        [Required]
        [StringLength(1000, ErrorMessage = "Description must contain at least 10 characters.")]
        public string? Description { get; set; }
    }
}
