using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace HelloLayouts.Models
{
    public class Employees
    {
        public int EmployeeID { get; set; }
        public string EmployeeName { get; set; }
        public string EmployeeEmail { get; set; }
    }

    public class EmployeeAddress
    {
        public int EmployeeAddressID { get; set; }
        public string EmployeeAddressLine1 { get; set; }
        public string EmployeeCity { get; set; }
        public string EmployeeState { get; set; }
    }

    public class EmployeeDetailViewModel
    {
        public Employees Employees { get; set; }
        public EmployeeAddress EmployeeAddress { get; set; }
    }

    public class RegistrationModel
    {
        [Required]
        [StringLength(20)]
        public string FirstName { get; set; }

        [Required]
        public string LastName { get; set; }

        [Required]
        public string UserName { get; set; }

        [Required]
        public string Password { get; set; }
    }
}
