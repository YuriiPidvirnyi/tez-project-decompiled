using System;

namespace TEZ_Project.Common.Products;

public static class HvyntNaFlanets
{
	public static string[] materialName1 = new string[1] { "" };

	public static double materialCost1;

	public static double priceProduct1;

	public static double[,] MaterialHvyntNaFlanets(int B, int H, int flanetsNumber, int number)
	{
		double[,] array = new double[1, 6];
		int num = 200;
		priceProduct1 = 0.0;
		materialName1[0] = Consts2.hvynt9x11.MaterialName;
		array[0, 0] = (2.0 * (Math.Ceiling((double)B / (double)num) + Math.Ceiling((double)H / (double)num)) + 4.0) * (double)flanetsNumber;
		array[0, 4] = array[0, 0] * (double)number;
		priceProduct1 += array[0, 4] * Consts2.hvynt9x11.Price;
		materialCost1 = array[0, 0] * Consts2.hvynt9x11.Price;
		return array;
	}
}
