using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace dropdown08.Models
{
    public class Employee
    {
        [Key]
        public int EmployeeId { get; set; }

        [Required, Display(Name = "Employee Name")]
        public string EmployeeName { get; set; }

        [Required, Display(Name = "Address")]
        public String Address { get; set; }

        [Required, Display(Name = "State")]
        public int State { get; set; }

        [Required, Display(Name = "City")]
        public int City { get; set; }

        [Display(Name = "Zip Code")]
        public String ZipCode { get; set; }

        [Required, Display(Name = "Phone #")]
        public String Phone { get; set; }
    }
}