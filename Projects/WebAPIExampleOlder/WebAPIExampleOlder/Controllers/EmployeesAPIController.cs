using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebAPIExampleOlder.Models;

namespace WebAPIExampleOlder.Controllers
{
    public class EmployeesAPIController : ApiController
    {
        [HttpGet]
        public Employee Detail(int id)
        {
            return new Employee() { EmployeeID = 1, EmployeeName = "Richards", EmployeeAddress = "Chennai" };
        }
    }
}
