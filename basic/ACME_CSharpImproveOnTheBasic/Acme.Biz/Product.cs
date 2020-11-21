namespace Acme.Biz
{
	/// <summary>
	/// Manages product carried in inventory
	/// </summary>
	public class Product
	{
		public Product()
		{

		}

		public Product(string productName, string description, int productId) : this()
		{
			ProductName = productName;
			Description = description;
			ProductId = productId;
		}

		private string productName;

		public string ProductName
		{
			get { return productName; }
			set { productName = value; }
		}

		private string description;

		public string Description
		{
			get { return description; }
			set { description = value; }
		}

		private int productId;

		public int ProductId
		{
			get { return productId; }
			set { productId = value; }
		}

		public string SayHello()
		{
			return $"Hello {ProductName}({ProductId}): {Description}";
		}
	}
}
