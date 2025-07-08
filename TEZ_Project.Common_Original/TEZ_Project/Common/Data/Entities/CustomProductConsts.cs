namespace TEZ_Project.Common.Data.Entities;

public class CustomProductConsts
{
	public int Id { get; set; }

	public double MaterialSpending { get; set; }

	public int ConstId { get; set; }

	public int CustomProductId { get; set; }

	public CustomProduct CustomProduct { get; set; }

	public Const Const { get; set; }
}
