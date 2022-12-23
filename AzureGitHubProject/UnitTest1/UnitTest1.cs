using AzureGitHubProject.Controllers;
using Microsoft.AspNetCore.Mvc;
using System;
using Xunit;

namespace UnitTest1
{
    public class UnitTest1
    {
        [Fact]
        public void MyTest()
        {
            HomeController h = new HomeController(null);

            var data = (ViewResult)h.Index();

            Assert.Equal("Shiv", data.ViewData["myvar"]);

        }
    }
}
