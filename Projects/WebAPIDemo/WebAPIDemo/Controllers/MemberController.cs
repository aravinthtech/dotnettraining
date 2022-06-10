using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Security;
using WebApiDemo.DataAccess;
using WebApiDemo.DataAccess.Models;

namespace WebAPIDemo.Controllers
{
    public class MemberController : ApiController
    {
        [HttpPost]
        public string Insert(Member member)
        {
            MemberProvider memberProvider = new MemberProvider();
            memberProvider.InsertMember(member);
            return "success";
        }

       
    }
}
