using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ProductManagement;
using ProductManagement.Controllers;

namespace ProductManagement.Tests.Controllers
{
    [TestClass]
    public class HomeControllerTest
    {
        private string currentFilter;
        private string sortOrder;
        private string searchString;
        private int? page;
        private int? id;

        [TestMethod]
        public void Login()
        {
            // Arrange
            HomeController controller = new HomeController();

            // Act
            ViewResult result = controller.Login() as ViewResult;

            // Assert
            Assert.IsNotNull(result);
        }
        public void Index()
        {
            // Arrange
            ProductsController controller = new ProductsController();

            // Act
            ViewResult result = controller.Index() as ViewResult;

            // Assert
            Assert.IsNotNull(result);
        }
        public void List()
        {
            // Arrange
            ProductsController controller = new ProductsController();

            // Act
            ViewResult result = controller.List(sortOrder,currentFilter,searchString, page)as ViewResult;

            // Assert
            Assert.IsNotNull(result);
        }
        public void Create()
        {
            // Arrange
            ProductsController controller = new ProductsController();

            // Act
            ViewResult result = controller.Create() as ViewResult;

            // Assert
            Assert.IsNotNull(result);
        }
        public void Edit()
        {
            // Arrange
            ProductsController controller = new ProductsController();

            // Act
            ViewResult result = controller.Edit(id) as ViewResult;

            // Assert
            Assert.IsNotNull(result);
        }


    }
}
