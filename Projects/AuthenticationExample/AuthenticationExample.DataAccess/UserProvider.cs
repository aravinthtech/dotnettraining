using AuthenticationExample.DataAccess.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AuthenticationExample.DataAccess
{
    public class UserProvider
    {
        public bool VerifyCredential(LoginModel loginModel)
        {
            if (loginModel.Username == "admin" && loginModel.Password == "admin") return true;
            if (loginModel.Username == "user" && loginModel.Password == "user") return true;
            return false;
        }
    }
}
