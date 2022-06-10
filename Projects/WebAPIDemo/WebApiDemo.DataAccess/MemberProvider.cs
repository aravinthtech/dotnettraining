using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApiDemo.DataAccess.Models;

namespace WebApiDemo.DataAccess
{
    public class MemberProvider
    {
        public bool InsertMember(Member member)
        {
            SqlConnection connection = new SqlConnection("Server=.\\SqlExpress;Database=LibraryManagment;Integrated Security=true;");
            connection.Open();
            SqlCommand sqlCommand = connection.CreateCommand();
            sqlCommand.CommandText = "INSERT INTO MEMBERS VALUES('"+member.MemberName+"')";
            sqlCommand.ExecuteNonQuery();
            connection.Close();
            return true;
        }
    }
}
