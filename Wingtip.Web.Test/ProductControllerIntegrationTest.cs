using Microsoft.AspNetCore.Mvc.Testing;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Threading.Tasks;
using Wingtip.ViewModels;

namespace Wingtip.Web.Test
{
    [TestClass]
    public class ProductControllerIntegrationTest
    {
        private readonly WebApplicationFactory<Wingtip.Web.Startup> _factory;

        public ProductControllerIntegrationTest()
        {
            _factory = new WebApplicationFactory<Wingtip.Web.Startup>();
        }
        [TestMethod]
        public async Task GetProductData()
        {
            // Arrange
            var client = _factory.CreateClient();
            // Act
            var response = await client.GetAsync("/api/Product");
            response.EnsureSuccessStatusCode(); // Status Code 200-299
            var responseString = await response.Content.ReadAsStringAsync();
            var responseObjectList = JsonConvert.DeserializeObject<List<ProductViewModel>>(responseString);
            // Assert
            Assert.AreNotEqual(0, responseObjectList.Count);

        }
    }
}
