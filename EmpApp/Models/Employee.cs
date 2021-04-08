using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EmpApp.Models
{
    public class Employee
    {
        [Key]
        public int Id{ get; set; }
        [Required]
        public string EmployeeName{ get; set;}
        [Required]
        public string Gender { get; set;}
        [Required]
        public string City{ get; set;}
        [Required]
        public string Salary{ get; set; }
        [Required]
        public string DateofHiring{ get; set; }
        [Required]
        public string DateofBirth{ get; set; }


    }
}
