using ApprovalFlow.DataAccess.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApprovalFlow.DataAccess
{
    public class UserProvider
    {
        public User Login(LoginModel loginModel)
        {
            using(var db=new ApprovalFlowEntities())
            {
                //var user = db.Users.Where(m => m.Username == loginModel.UserName 
                //            && m.Password == loginModel.Password).FirstOrDefault();

                var user = (from u in db.Users
                            where u.Username == loginModel.UserName && u.Password == loginModel.Password
                            select u).FirstOrDefault();

                if (user == null)
                    throw new Exception("Invalid Credentials");

                return user;
            }
        }
    }
}
