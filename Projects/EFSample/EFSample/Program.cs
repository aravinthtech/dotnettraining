using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFSample
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("EF Test");
            using(var db=new LIBRARYMANAGMENTEntities())
            {
                db.Books.Add(new Book() { BookName = "ABFG" });
                db.SaveChanges();
            }
            Console.ReadKey();
        }
    }
}
