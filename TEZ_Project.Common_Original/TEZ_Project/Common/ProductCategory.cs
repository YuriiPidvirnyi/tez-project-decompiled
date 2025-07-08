using System.Collections.Generic;

namespace TEZ_Project.Common;

internal class ProductCategory
{
	public string Name { get; set; }

	public double MaterialSpendingClear { get; set; }

	public List<Material> Materials { get; set; }

	public ProductCategory(string name, List<Material> materials, double? matSpend = null)
	{
		Name = name;
		Materials = materials;
		MaterialSpendingClear = matSpend.GetValueOrDefault();
	}
}
