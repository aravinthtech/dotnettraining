using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace JuneFourMVC.Filters
{
    public class HandleErrorCustom : FilterAttribute, IExceptionFilter
    {
        public void OnException(ExceptionContext filterContext)
        {
            System.IO.File.WriteAllText("C:\\Aravinth\\errorlog.txt","Error captured by Filter:"+filterContext.Exception.Message);            
        }
    }
}