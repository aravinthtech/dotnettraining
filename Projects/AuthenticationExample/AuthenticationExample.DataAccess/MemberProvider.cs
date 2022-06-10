using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AuthenticationExample.DataAccess
{
    public class MemberProvider
    {
        public bool InsertMember(Member member)
        {

            using(var db=new LIBRARYMANAGMENTEntities())
            {
                db.Members.Add(member);                
                db.SaveChanges();
            }

            return true;

        }

        public Member GetMember(string memberName)
        {
            using(var db=new LIBRARYMANAGMENTEntities())
            {
                var member = (from a in db.Members
                              where a.MemberName == memberName
                              select a).FirstOrDefault();
                return member;
            }
        }
    }
}
