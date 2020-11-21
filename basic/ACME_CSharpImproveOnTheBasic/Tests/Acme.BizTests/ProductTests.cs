using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Acme.Biz.Tests
{
	[TestClass()]
	public class ProductTests
	{
		[TestMethod()]
		public void SayHelloTest()
		{
			// Arrange
			var currentProduct = new Product
			{
				ProductName = "Saw",
				ProductId = 1,
				Description = "15-inch steel blade hand saw"
			};
			var expected = "Hello Saw(1): 15-inch steel blade hand saw";

			// Act
			var actual = currentProduct.SayHello();

			// Assert
			Assert.AreEqual(expected, actual);
		}
	}
}