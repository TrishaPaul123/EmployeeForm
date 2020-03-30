using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Employee_Repository.Models
{
    public class Employee
    {
        public int EmployeeID { get; set; }
        [Required]
        [StringLength(20, MinimumLength = 3)]
        [RegularExpression("^([A-Za-z]*)$", ErrorMessage = "Please enter Upper and Lower case Alphabets only")]
        public string FirstName { get; set; }
        [StringLength(20, MinimumLength = 3)]
        [RegularExpression("^([A-Za-z]*)$", ErrorMessage = "Please enter Upper and Lower case Alphabets only")]
        public string MiddleName { get; set; }
        [Required]
        [StringLength(20, MinimumLength = 3)]
        [RegularExpression("^([A-Za-z]*)$", ErrorMessage = "Please enter Upper and Lower case Alphabets only")]
        public string LastName { get; set; }
        [Required]
        public string Gender { get; set; }
        [Required]
        public string Address { get; set; }
        [Required]
        public string City { get; set; }
        [Required]
        public string State { get; set; }
        [Required]
        public string Country { get; set; }
        [RegularExpression("^([7-9]{1}[0-9]{9})$", ErrorMessage ="Please enter ten digits only")]
        public string Mobile { get; set; }
    }
}