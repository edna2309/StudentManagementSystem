using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagementSystem.Data
{
    public class Department : BaseEntity
    {
        public string? Name { get; set; }
        public string? Description { get; set; }

        public void SetInfo(string Name, string Description)
        {
            this.Name = Name;
            this.Description = Description;
        }
    }
}
