using ApprovalFlow.DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ApprovalFlow.Controllers
{
    public class RegistrationController : Controller
    {
        // GET: Registration
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Submit(User user)
        {
            HashingProvider hashingProvider = new HashingProvider();
            user.Password = hashingProvider.GetHashedText(user.Password);
            UserProvider userProvider = new UserProvider();
            userProvider.RegisterUser(user);
            return Redirect("/Login/Index");
        }
    }
}