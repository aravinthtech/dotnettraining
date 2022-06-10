using FilterExample.DataAccess;
using FilterExample.Exceptions;
using FilterExample.Filters;
using FilterExample.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FilterExample.Controllers
{

    [HandleError(ExceptionType = typeof(BusinessException), View = "BusinessError")]
    [HandleError(ExceptionType = typeof(Exception), View = "Error")]


    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            if (1 == 1) throw new BusinessException("Invalid");
            TempData["World"] = "World from Index";
            ViewBag.Hello = "Hello from Index";
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult SignUpForm()
        {
            string s = ViewBag.Hello;
            string t = TempData["World"].ToString();
            Employee employee = new Employee();
            return View(employee);

        }

        [HttpPost]
        public ActionResult Submit(Employee employee)
        {
            //EmployeeProvider employeeProvider = new EmployeeProvider();
            //employeeProvider.InsertEmployee(employee);
            return View("SignUpForm");
        }
    }
}