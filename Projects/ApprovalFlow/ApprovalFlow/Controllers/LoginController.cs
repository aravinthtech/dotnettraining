using ApprovalFlow.DataAccess;
using ApprovalFlow.DataAccess.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ApprovalFlow.Controllers
{
    public class LoginController : Controller
    {
        // GET: Login
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Submit(LoginModel loginModel)
        {
            UserProvider userProvider = new UserProvider();
            User user= userProvider.Login(loginModel);
            if (user.Role == "admin")
                //redirecting to Admin Home Page
                return Redirect("/admindashboard/index");
            else
                //redirecting to User Home Page
                return Redirect("/userdashboard/index");
        }
    }
}