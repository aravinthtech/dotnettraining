using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FilterExample.Filters
{
    public class HandleCustomError : FilterAttribute, IExceptionFilter
    {
        public void OnException(ExceptionContext filterContext)
        {
            System.IO.File.WriteAllText("C:\\Aravinth\\customErrors.log", filterContext.Exception.Message);
        }
    }
}