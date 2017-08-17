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
    public class ProductUnitTest
    {
        [TestMethod]
        public void ProductIndex()
        {
            ProductsController controller = new ProductsController();
            ViewResult result = controller.Index() as ViewResult;
            Assert.IsNotNull(result);
        }
        [TestMethod]
        public void ProductDetails()
        {
            ProductsController controller = new ProductsController();
            ViewResult result = controller.Details(2) as ViewResult;
            Assert.IsNotNull(result);
        }
        [TestMethod]
        public void ProductCreate()
        {
            ProductsController controller = new ProductsController();
            ViewResult result = controller.Create() as ViewResult;
            Assert.IsNotNull(result);
        }
        [TestMethod]
        public void ProductEdit()
        {
            ProductsController controller = new ProductsController();
            ViewResult result = controller.Edit(2) as ViewResult;
            Assert.IsNotNull(result);
        }
        [TestMethod]
        public void ProductDelete()
        {
            ProductsController controller = new ProductsController();
            ViewResult result = controller.Delete(2) as ViewResult;
            Assert.IsNotNull(result);
        }
    }
}
