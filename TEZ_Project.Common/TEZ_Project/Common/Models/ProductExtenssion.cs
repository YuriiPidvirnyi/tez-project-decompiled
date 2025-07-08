using System.Reflection;
using TEZ_Project.Common.Helpers;

namespace TEZ_Project.Common.Models;

public static class ProductExtenssion
{
	public static bool IsPovitroprovid(this IProduct item)
	{
		return ProductHelper.GetProductType(item) == "Povitroprovody";
	}

	public static bool IsFasonka(this IProduct item)
	{
		return ProductHelper.GetProductType(item) == "Fasonka";
	}

	public static bool IsObladn(this IProduct item)
	{
		return ProductHelper.GetProductType(item) == "Obladn";
	}

	public static int GetProductMarkaStali(this IProduct product)
	{
		int result = 0;
		PropertyInfo propertyInfo = product.GetType()?.GetProperty("MarkaStali");
		if (propertyInfo != null && propertyInfo.GetValue(product, null) is string text)
		{
			switch (text)
			{
			case "Оцинковка":
				result = 1;
				break;
			case "Чорна":
				result = 2;
				break;
			case "Нержавійка":
				result = 3;
				break;
			}
		}
		return result;
	}

	public static double GetMarkup(this IProduct product)
	{
		return product.Price - product.MaterialCost;
	}

	public static double GetRentabelnist(this IProduct product)
	{
		if (product.Price == 0.0)
		{
			return 0.0;
		}
		return product.GetMarkup() / product.Price * 100.0;
	}

	public static string GetRentabelnistFormatted(this IProduct product)
	{
		return $"{product.GetRentabelnist():F1}%";
	}
}
