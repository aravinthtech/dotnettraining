using AuthenticationExample.DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AuthenticationExample.Controllers
{
    public class MemberController : Controller
    {
        // GET: Member
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Submit(Member member)
        {
            MemberProvider memberProvider = new MemberProvider();
            memberProvider.InsertMember(member);
            return View("Index");
        }
    }
}