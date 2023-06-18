using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tikitapp.Website.Tests
{
    public class WebTests: IClassFixture<WebApplicationFactory<Program>>
    {
        private readonly WebApplicationFactory<Program> factory = new();

        [Fact]
        public async Task Home_Index_Returns_Valid_Html()
        {
            var client = factory.CreateClient();
            var response = await client.GetAsync("/");
            response.IsSuccessStatusCode.ShouldBe(true);
            var body = await response.Content.ReadAsStringAsync();
            body.ShouldContain("Welcome");
        }

        [Fact]
        public async Task Home_Privacy_Returns_Valid_Html()
        {
            var client = factory.CreateClient();
            var response = await client.GetAsync("/Home/Privacy");
            response.IsSuccessStatusCode.ShouldBe(true);
            var body = await response.Content.ReadAsStringAsync();
            body.ShouldContain("MIT License");
        }
    }

}
