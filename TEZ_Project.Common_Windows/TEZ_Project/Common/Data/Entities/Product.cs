namespace TEZ_Project.Common.Data.Entities;

public class Product
{
	public int Id { get; set; }

	public string Type { get; set; }

	public string Data { get; set; }

	public int OrderId { get; set; }

	public double Price { get; set; }

	public Order Order { get; set; }
}
