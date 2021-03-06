﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CarBrokers;
using CarBrokers.Controllers;

namespace CarBrokers.Tests.Controllers
{
    [TestClass]
    public class CarRequestControllerTest
    {
        [TestMethod]
        public void Create()
        {
            // Arrange
           CarRequestController controller = new CarRequestController();

            // Act
            ViewResult result = controller.Create() as ViewResult;

            // Assert
            Assert.IsNotNull(result);
        }

       
    }
}
