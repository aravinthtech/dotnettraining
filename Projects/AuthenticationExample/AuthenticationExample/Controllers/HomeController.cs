using AuthenticationExample.DataAccess;
using AuthenticationExample.DataAccess.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace AuthenticationExample.Controllers
{
    [Authorize]
    //"Index/1/3"
    //Index/2/6
    [OutputCache(Duration =60,VaryByParam ="id")]
    public class HomeController : Controller
    {
        [AllowAnonymous]
        [Route("Dashboard/{id}/{varB}")]
        public ActionResult Index(int id,int varB)
        {
            return View();
        }

        [Authorize(Roles="Administrator")]
        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        [Authorize(Roles="RegisteredUser")]
        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        [AllowAnonymous]
        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        [AllowAnonymous]
        public ActionResult VerifyCredential(LoginModel loginModel)
        {
            
            UserProvider userProvider = new UserProvider();
            bool rslt = userProvider.VerifyCredential(loginModel);

            if (rslt)
            {
                FormsAuthentication.SetAuthCookie(loginModel.Username, false);
            }

            return RedirectToAction("Index");
        }
    }
}