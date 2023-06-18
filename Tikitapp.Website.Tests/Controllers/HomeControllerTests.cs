using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tikitapp.Website.Controllers;

namespace Tikitapp.Website.Tests.Controllers
{
    public class HomeControllerTests
    {
        private readonly NullLogger<HomeController> logger = new();

        [Fact]
        public void Home_Index_Return_ViewResult()
        {
            var c = new HomeController(logger);
            var result = c.Index();
            result.ShouldBeOfType<ViewResult>();

        }

        [Fact]
        public void Home_Privacy_Return_ViewResult()
        {
            var c = new HomeController(logger);
            var result = c.Privacy();
            result.ShouldBeOfType<ViewResult>();
        }
    }
}
