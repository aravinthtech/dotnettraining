using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Web.Mvc;
using WebAPIDemo.Controllers;

namespace WebAPI.Test
{
    [TestClass]
    public class HomeControllerTest
    {
        [TestInitialize]
        public void SetupTest()
        {
            string s = "123";
        }

        [TestMethod]
        public void Should_HomeControllerRendersWithoutError_WhenPageIsLoaded()
        {
            HomeController homeController = new HomeController();
            ViewResult viewResult = homeController.Index() as ViewResult;
            Assert.IsNotNull(viewResult);           

        }

        [TestMethod]
        public void Should_HomeControllerViewBagCarriesMessage_WhenPageIsLoaded()
        {
            HomeController homeController = new HomeController();
            ViewResult viewResult = homeController.Index() as ViewResult;
            Assert.IsTrue(viewResult.ViewName=="Index");

        }

        [TestCleanup]
        public void CleanUp()
        {
            string q = "456";
        }
    }
}
