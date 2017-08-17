using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyProducts.AdminSite;
using MyProducts.AdminSite.Models;
using MyProducts.AdminSite.Controllers;
using System.Web.Mvc;
namespace UnitTestProject.Controller
{
    [TestClass]
    public class HomeUnitTest
    {
        [TestMethod]
        public void HomeIndex()
        {
            HomeController controller = new HomeController();
            ViewResult result = controller.Index() as ViewResult;
            Assert.IsNotNull(result);
        }
        [TestMethod]
        public void HomeAbout()
        {
            HomeController controller = new HomeController();
            ViewResult result = controller.About() as ViewResult;
            Assert.IsNotNull(result);
        }
        [TestMethod]
        public void HomeContact()
        {
            HomeController controller = new HomeController();
            ViewResult result = controller.Contact() as ViewResult;
            Assert.IsNotNull(result);
        }

    }
}
