using BeginnerWebApp.Controllers;
using System;
//using System.Web.Mvc;
using Xunit;
using Microsoft.AspNetCore.Mvc;


namespace BeginnerWebApp.Tests
{
    public class HomeControllerTests
    {
        [Fact]
        public void Index_Returns_A_View()
        {
            var sut = new HomeController();

            var result = sut.Index();

            Assert.IsType<ViewResult>(result);

        }
    }
}
