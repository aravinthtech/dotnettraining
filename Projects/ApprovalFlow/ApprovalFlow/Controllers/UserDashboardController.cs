using ApprovalFlow.DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ApprovalFlow.Controllers
{
    public class UserDashboardController : Controller
    {
        // GET: UserDashboard
        public ActionResult Index()
        {
            StaffProvider staffProvider = new StaffProvider();
            List<Staff> staffList = staffProvider.ListStaff();
            return View(staffList);
        }

        public ActionResult AddStaff()
        {
            return View();
        }

        [HttpPost]
        public ActionResult SubmitStaff(Staff staff)
        {
            staff.Status = 0;
            StaffProvider staffProvider = new StaffProvider();
            staffProvider.InsertStaff(staff);
            return RedirectToAction("Index");
        }
    }
}