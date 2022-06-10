using ApprovalFlow.DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ApprovalFlow.Controllers
{
    public class AdminDashboardController : Controller
    {
        // GET: Dashboard
        public ActionResult Index()
        {
            StaffProvider staffProvider = new StaffProvider();
            List<Staff> staffList = staffProvider.ListStaff();
            return View(staffList);
        }

        public ActionResult Approve(int id)
        {
            StaffProvider staffProvider = new StaffProvider();
            staffProvider.ApproveStaff(id);
            return RedirectToAction("Index");
        }


        public ActionResult Deny(int id)
        {
            StaffProvider staffProvider = new StaffProvider();
            staffProvider.DenyStaff(id);
            return RedirectToAction("Index");
        }
    }
}