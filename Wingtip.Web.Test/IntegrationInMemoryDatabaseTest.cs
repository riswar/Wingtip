using Microsoft.EntityFrameworkCore;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Wingtip.Data;
using Wingtip.Domain;

namespace Wingtip.Web.Test
{
    [TestClass]
  public class IntegrationInMemoryDatabaseTests
  {
    [TestMethod]
    public void BizDataGetSamuraiReturnsSamurai()
    {
      //Arrange (set up builder & seed data)
      var builder = new DbContextOptionsBuilder<WingtopContext>();
      builder.UseInMemoryDatabase("GetSamurai");
      int productId = SeedWithOneProduct(builder.Options);
      //Act (call the method)
      using (var context = new WingtopContext(builder.Options))
      {
        var productDataRetrieved = context.Products.Find(productId);
       //Assert (check the results)
        Assert.AreEqual(productId, productDataRetrieved.ProductId);
      };
    }
    private int SeedWithOneProduct(DbContextOptions<WingtopContext> options)
    {
      using (var seedcontext = new WingtopContext(options))
      {
        var product = new Product();
        seedcontext.Products.Add(product);
        seedcontext.SaveChanges();
        return product.ProductId;
      }
    }
  }
}