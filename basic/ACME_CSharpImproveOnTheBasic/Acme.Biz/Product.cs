namespace Acme.Biz
{
	/// <summary>
	/// Manages products carried in inventory
	/// </summary>
	public class Product
	{
		public Product()
		{

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

		private int proudctId;

		public int ProductId
		{
			get { return proudctId; }
			set { proudctId = value; }
		}
		
		public string SayHello()
		{
			return $"Hello {ProductName}({ProductId}): {Description}";
		}
	}
}
