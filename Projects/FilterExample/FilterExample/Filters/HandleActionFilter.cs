using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FilterExample.Filters
{
    public class HandleActionFilter: ActionFilterAttribute, IActionFilter
    {
        public override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            //base.OnActionExecuting(filterContext);
            if (filterContext.HttpContext.Request.Url.AbsoluteUri.Contains("Home"))
            {
                filterContext.Result = new RedirectResult("http://www.google.com");
            }
        }


    }
}