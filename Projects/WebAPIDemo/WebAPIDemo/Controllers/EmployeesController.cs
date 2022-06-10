using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web;
using System.Web.Http;
//using WebApiDemo.DataAccess;
using WebAPIDemo.Models;

namespace WebAPIDemo.Controllers
{
    public class EmployeesController : ApiController
    {
        [HttpGet]
        public Employee Detail(int id)
        {
            return new Employee() { ID = 1, Name = "Richards", Email = "richards@gmail.com" };
        }

        [HttpPost]
        public string InsertEmployee(Employee employee)
        {
            //Save data to db
            //TestAsync();
            //EmployeesProvider employees = new EmployeesProvider();
            //employees.InsertEmployee();
            return "success";
        }

        [HttpGet]
        public Employee DetailByNameAndEmail(string name, string email)
        {
            return new Employee() { ID = 1, Name = "Richards", Email = "richards@gmail.com" };
        }

        [HttpPost]
        public string UploadDocument()
        {
            var files = HttpContext.Current.Request.Files;
            
            return "success";
        }

        private async void TestAsync()
        {

        }
    }
}
