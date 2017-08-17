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
    public class ProductImageUnitTest
    {
        [TestMethod]
        public void ProductImageIndex()
        {
            ProductImagesController controller = new ProductImagesController();
            ViewResult result = controller.Index() as ViewResult;
            Assert.IsNotNull(result);
        }
        [TestMethod]
        public void ProductImageDetails()
        {
            ProductImagesController controller = new ProductImagesController();
            ViewResult result = controller.Details(2) as ViewResult;
            Assert.IsNotNull(result);
        }
        [TestMethod]
        public void ProductImagesCreate()
        {
            ProductImagesController controller = new ProductImagesController();
            ViewResult result = controller.Create() as ViewResult;
            Assert.IsNotNull(result);
        }
        [TestMethod]
        public void ProductImagesEdit()
        {
            ProductImagesController controller = new ProductImagesController();
            ViewResult result = controller.Edit(2) as ViewResult;
            Assert.IsNotNull(result);
        }
        [TestMethod]
        public void ProductImagesDelete()
        {
            ProductImagesController controller = new ProductImagesController();
            ViewResult result = controller.Delete(2) as ViewResult;
            Assert.IsNotNull(result);
        }
    }
}
