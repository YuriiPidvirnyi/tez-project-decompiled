namespace TEZ_Project.Common;

internal class Material
{
	public string Name { get; set; }

	public int Amount { get; set; }

	public double[] Values { get; set; }

	public Material(string name, double[] values)
	{
		Name = name;
		Amount = 1;
		Values = values;
	}
}
