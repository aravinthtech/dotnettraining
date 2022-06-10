using HelloLayouts.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HelloLayouts.Controllers
{

    public class EmployeesController : Controller
    {
        public IActionResult Index()
        {
            EmployeeDetailViewModel employeeDetailViewModel = new EmployeeDetailViewModel();
            employeeDetailViewModel.Employees = new Employees()
            {
                EmployeeID = 1,
                EmployeeName = "Williams",
                EmployeeEmail = "williams@gmail.com"
            };

            employeeDetailViewModel.EmployeeAddress = new EmployeeAddress()
            {
                EmployeeAddressLine1 = "001,A Street",
                EmployeeCity = "Bangalore",
                EmployeeState = "Karnataka"
            };
            ////if (1 == 1) throw new Exception("Invalid object");
            return View(employeeDetailViewModel);
        }

        public IActionResult List()
        {
            return View("NewView");
        }

        
    }
}
