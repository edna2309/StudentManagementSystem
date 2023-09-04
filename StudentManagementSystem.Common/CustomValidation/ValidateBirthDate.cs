using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagementSystem.Common.CustomValidation
{
    public class ValidateBirthDateAttribute : ValidationAttribute
    {
        protected override ValidationResult? IsValid(object? value, ValidationContext validationContext)
        {
            var BirthDate = Convert.ToDateTime(value);
            if(BirthDate > DateTime.Today)
            {
                return new ValidationResult("Birth date cannot be set in the future.");
            }

            return ValidationResult.Success;
        }
    }
}
