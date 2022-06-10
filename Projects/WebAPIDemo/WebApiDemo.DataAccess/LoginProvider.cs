using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebApiDemo.DataAccess
{
    public class LoginProvider
    {
        public bool VerifyCredential(string userName, string password)
        {
            if (userName == "admin" && password == "admin") return true;
            return false;
        }
    }
}
