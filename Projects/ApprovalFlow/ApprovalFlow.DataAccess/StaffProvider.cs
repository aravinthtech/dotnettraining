using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApprovalFlow.DataAccess
{
    public class StaffProvider
    {
        public List<Staff> ListStaff()
        {
            using(var db=new ApprovalFlowEntities())
            {
                return db.Staffs.ToList();
            }
        }

        public void InsertStaff(Staff staff)
        {
            using(var db=new ApprovalFlowEntities())
            {
                db.Staffs.Add(staff);
                db.SaveChanges();
            }
        }

        public void ApproveStaff(int staffID)
        {
            using (var db = new ApprovalFlowEntities())
            {
                var staff = db.Staffs.Where(m => m.StaffID == staffID).FirstOrDefault();
                staff.Status = 1;                
                db.SaveChanges();
            }

        }

        public void DenyStaff(int staffID)
        {
            using (var db = new ApprovalFlowEntities())
            {
                var staff = db.Staffs.Where(m => m.StaffID == staffID).FirstOrDefault();
                staff.Status = 2;
                db.SaveChanges();
            }
        }
    }
}
