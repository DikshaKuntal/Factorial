using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using FactorialCalculation;
using FactorialCalculation.Controllers;
using FactorialCalculation.Models;

namespace FactorialCalculation.Tests.Controllers
{
    [TestClass]
    public class HomeControllerTest
    {        
        [TestMethod]
        public void TestZeroFactorial()
        {
            // Arrange
            HomeController controller = new HomeController();
            Factorial fact = new Factorial() { Number = 0 };
            double res = 1;
            
            // Act
            ViewResult result = controller.CalculateFactorial(fact) as ViewResult;
            fact = (Factorial)result.Model;

            // Assert
            Assert.AreEqual(res, fact.Result);
        }

        [TestMethod]
        public void TestOneFactorial()
        {
            // Arrange
            HomeController controller = new HomeController();
            Factorial fact = new Factorial() { Number = 1 };
            double res = 1; 

            // Act
            ViewResult result = controller.CalculateFactorial(fact) as ViewResult;
            fact = (Factorial)result.Model;

            // Assert
            Assert.AreEqual(res, fact.Result);
        }


    }
}
