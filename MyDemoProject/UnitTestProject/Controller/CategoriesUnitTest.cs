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
    public class CategoriesUnitTest
    {
        [TestMethod]
        public void CategoriesIndex()
        {
            CategoriesController controller = new CategoriesController();
            ViewResult result = controller.Index() as ViewResult;
            Assert.IsNotNull(result);
        }
        [TestMethod]
        public void CategoriesDetails()
        {
            CategoriesController controller = new CategoriesController();
            ViewResult result = controller.Details(2) as ViewResult;
            Assert.IsNotNull(result);
        }
        [TestMethod]
        public void PCategoriesCreate()
        {
            CategoriesController controller = new CategoriesController();
            ViewResult result = controller.Create() as ViewResult;
            Assert.IsNotNull(result);
        }
        [TestMethod]
        public void CategoriesEdit()
        {
            CategoriesController controller = new CategoriesController();
            ViewResult result = controller.Edit(2) as ViewResult;
            Assert.IsNotNull(result);
        }
        [TestMethod]
        public void CategoriesDelete()
        {
            CategoriesController controller = new CategoriesController();
            ViewResult result = controller.Delete(2) as ViewResult;
            Assert.IsNotNull(result);
        }
    }
}
