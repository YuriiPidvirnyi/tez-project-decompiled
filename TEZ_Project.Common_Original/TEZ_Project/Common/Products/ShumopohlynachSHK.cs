using System;
using TEZ_Project.Common.Helpers;

namespace TEZ_Project.Common.Products;

public static class ShumopohlynachSHK
{
	public static string[] materialName = new string[14]
	{
		"", "", "", "", "", "", "", "", "", "",
		"", "", "", ""
	};

	public static double materialCost;

	public static double priceProduct;

	public static double[] priceShumopohlynachSHK600 = new double[14];

	public static double[,] MaterialShumopohlynachSHK(int D, int L, int number)
	{
		double[,] array = new double[14, 6];
		materialName = new string[14]
		{
			"", "", "", "", "", "", "", "", "", "",
			"", "", "", ""
		};
		materialCost = 0.0;
		priceProduct = 0.0;
		int num = -1;
		num++;
		materialName[num] = Consts2.lystOchynkovanyj05.MaterialName;
		double num2 = (Math.PI * ((double)D / 1000.0 + 0.1) + 0.03) * (double)L / 1000.0;
		num2 = num2 * 0.05 + num2;
		double num3 = (Math.PI * (double)D / 1000.0 + 0.01) * 100.0 / 1000.0 * 2.0;
		num3 = num3 * 0.25 + num3;
		double num4 = Math.Pow((double)D / 1000.0 + 0.14, 2.0) * 2.0;
		num4 = num4 * 0.05 + num4;
		array[num, 0] = num2;
		if (D <= 400)
		{
			array[num, 0] += num3;
		}
		if (D <= 160)
		{
			array[num, 0] += num4;
		}
		array[num, 1] = 0.05;
		array[num, 4] = array[num, 0] * (double)number;
		array[num, 5] = array[num, 4] * 7825.0 * 0.5 / 1000.0;
		array[num, 2] = array[num, 4] * array[num, 1];
		array[num, 3] = array[num, 5] * array[num, 1];
		array = MaterialHelper.RoundMaterialSpending(array, num);
		priceProduct = array[num, 0] * Consts2.lystOchynkovanyj05.Price;
		if ((D > 160 && D <= 315) || D > 400)
		{
			num++;
			materialName[num] = Consts2.lystOchynkovanyj07.MaterialName;
			array[num, 0] = 0.0;
			if (D > 160 && D <= 315)
			{
				array[num, 0] += num4;
			}
			if (D > 400)
			{
				array[num, 0] += num3;
			}
			array[num, 1] = 0.05;
			array[num, 4] = array[num, 0] * (double)number;
			array[num, 5] = array[num, 4] * 7825.0 * 0.7 / 1000.0;
			array[num, 2] = array[num, 4] * array[num, 1];
			array[num, 3] = array[num, 5] * array[num, 1];
			array = MaterialHelper.RoundMaterialSpending(array, num);
			priceProduct += array[num, 0] * Consts2.lystOchynkovanyj07.Price;
		}
		if (D > 315)
		{
			num++;
			materialName[num] = Consts2.lystOchynkovanyj09.MaterialName;
			array[num, 0] = Math.Pow((double)D / 1000.0 + 0.11, 2.0) * 2.0;
			array[num, 0] = array[num, 0] * 0.05 + array[num, 0];
			array[num, 1] = 0.05;
			array[num, 4] = array[num, 0] * (double)number;
			array[num, 5] = array[num, 4] * 7825.0 * 0.9 / 1000.0;
			array[num, 2] = array[num, 4] * array[num, 1];
			array[num, 3] = array[num, 5] * array[num, 1];
			array = MaterialHelper.RoundMaterialSpending(array, num);
			priceProduct += array[num, 0] * Consts2.lystOchynkovanyj09.Price;
		}
		num++;
		materialName[num] = Consts2.sitka25x25.MaterialName;
		array[num, 0] = (Math.PI * (double)D / 1000.0 + 0.05) * (double)L / 1000.0;
		array[num, 0] = array[num, 0] * 0.05 + array[num, 0];
		array[num, 1] = 0.05;
		array[num, 4] = array[num, 0] * (double)number;
		array[num, 5] = array[num, 4] * 1.81;
		array[num, 2] = array[num, 4] * array[num, 1];
		array[num, 3] = array[num, 2] * 1.81;
		array = MaterialHelper.RoundMaterialSpending(array, num);
		priceProduct += array[num, 0] * Consts2.sitka25x25.Price;
		num++;
		materialName[num] = Consts2.mineralnaVataTehno50mm.MaterialName;
		array[num, 0] = Math.PI * ((double)D / 1000.0 + 0.1) * (double)L / 1000.0;
		array[num, 0] = array[num, 0] * 0.05 + array[num, 0];
		array[num, 1] = 0.05;
		array[num, 4] = array[num, 0] * (double)number;
		array[num, 2] = array[num, 4] * array[num, 1];
		array = MaterialHelper.RoundMaterialSpending(array, num);
		priceProduct += array[num, 0] * Consts2.mineralnaVataTehno50mm.Price;
		num++;
		materialName[num] = Consts2.sklotkanynaTG_140.MaterialName;
		array[num, 0] = (Math.PI * (double)D / 1000.0 + 0.15) * (double)L / 1000.0;
		array[num, 0] = array[num, 0] * 0.05 + array[num, 0];
		array[num, 1] = 0.05;
		array[num, 4] = array[num, 0] * (double)number;
		array[num, 2] = array[num, 4] * array[num, 1];
		array = MaterialHelper.RoundMaterialSpending(array, num);
		priceProduct += array[num, 0] * Consts2.sklotkanynaTG_140.Price;
		num++;
		materialName[num] = Consts2.skotch48x200.MaterialName;
		array[num, 0] = (double)D / 1000.0 * 0.3;
		array[num, 4] = array[num, 0] * (double)number;
		priceProduct += array[num, 0] * Consts2.skotch48x200.Price;
		num++;
		materialName[num] = Consts2.zaklepkaKombinov4x6.MaterialName;
		array[num, 0] = 8.0;
		array[num, 4] = array[num, 0] * (double)number;
		priceProduct += array[num, 0] * Consts2.zaklepkaKombinov4x6.Price;
		materialCost = priceProduct;
		priceProduct *= 3.0;
		return array;
	}

	public static double[] FormPriceShumopohlynachSHK()
	{
		double[] array = new double[19];
		int[] array2 = new int[19]
		{
			100, 125, 140, 150, 160, 180, 200, 225, 250, 280,
			315, 355, 400, 450, 500, 560, 630, 710, 800
		};
		double[,] array3 = new double[12, 6];
		for (int i = 0; i < 14; i++)
		{
			array3 = MaterialShumopohlynachSHK(array2[i], 600, 1);
			priceShumopohlynachSHK600[i] = priceProduct;
		}
		for (int j = 0; j < 19; j++)
		{
			array3 = MaterialShumopohlynachSHK(array2[j], 1000, 1);
			array[j] = priceProduct;
		}
		return array;
	}

	public static double VolumeShumopohlynachSHK(int D, int L)
	{
		return Math.Round((double)D * (double)D * (double)L / 1000000.0) / 1000.0;
	}
}
