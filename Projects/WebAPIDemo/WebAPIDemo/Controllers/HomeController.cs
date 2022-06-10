using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
using WebApiDemo.DataAccess;

namespace WebAPIDemo.Controllers
{
    [Authorize]
    public class HomeController : Controller
    {
        [AllowAnonymous]
        public ActionResult Index()
        {
           
            ViewBag.CustomMessage = "Hello World";
            TempData["TempMessage"] = "Using Temporary Data";
            return View();
        }
        [Authorize(Roles ="admin")]
        public ActionResult About()
        {
            string s = ViewBag.CustomMessage;
            return View();
        }

        [Authorize(Roles = "user")]
        public ActionResult Contact()
        {
            string t = TempData["TempMessage"].ToString();
            TempData.Keep("TempMessage");
            ViewBag.Message = "Your contact page.";

            return View();
        }

        [AllowAnonymous]
        [HttpGet]
        public string Login()
        {
            LoginProvider loginProvider = new LoginProvider();
            bool rslt = loginProvider.VerifyCredential("admin", "admin");
            if (rslt)
                FormsAuthentication.SetAuthCookie("admin", false);

            return "success";
        }
    }


}