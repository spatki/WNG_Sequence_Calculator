using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WNG_Sequences.Tests.Mock;
using WNG_Sequences.WebUI.Models;
using WNG_Sequences.WebUI.Controllers;
using System.Web.Mvc;
using System.Web.Helpers;

namespace WNG_Sequences.Tests.Controllers
{
    [TestClass]
    public class HomeControllerTest
    {
        MockSequenceService _service;

        [TestInitialize]
        public void Initialize()
        {
            _service = new MockSequenceService();
        }

        [TestMethod]
        public void DisplayIndexPage_Test()
        {
            HomeController controller = new HomeController(_service);

            var result = (ViewResult)controller.Index();

            Assert.AreEqual("Index", result.ViewName);
        }

        [TestMethod]
        public void InvaliInput_Test()
        {
            // Arrange
            UserInput input = new UserInput();
            
            HomeController controller = new HomeController(_service);
            // Act
            JsonResult result = (JsonResult)controller.GenerateSequences(input);
            // Assert
            Assert.IsNotNull(result,"No JSON returned");
        }

    }
}
