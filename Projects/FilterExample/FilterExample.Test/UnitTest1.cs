using FilterExample.Controllers;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Web.Mvc;

namespace FilterExample.Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Should_HomeController_Index_RendersWithoutErrors()
        {
            HomeController homeController = new HomeController();
            ViewResult viewResult= homeController.Index() as ViewResult;
            
            Assert.IsNotNull(viewResult);
        }
    }
}
