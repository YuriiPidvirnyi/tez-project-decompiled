using System;
using TEZ_Project.Common.Helpers;

namespace TEZ_Project.Common.Products;

public static class KlapanZvorotniyKZKg
{
	public static string[] materialName = new string[14]
	{
		"", "", "", "", "", "", "", "", "", "",
		"", "", "", ""
	};

	public static double materialCost;

	public static double priceProduct;

	public static double[,] MaterialKlapanZvorotniyKZKg(int D, int number)
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
		if (D <= 630)
		{
			num++;
			materialName[num] = Consts2.lystOchynkovanyj05.MaterialName;
			array[num, 0] = (((double)D + 50.0) / 1000.0 * 4.0 + 0.03) * 0.155;
			array[num, 0] = array[num, 0] * 0.05 + array[num, 0];
			array[num, 1] = 0.05;
			array[num, 4] = array[num, 0] * (double)number;
			array[num, 5] = array[num, 4] * 7825.0 * 0.5 / 1000.0;
			array[num, 2] = array[num, 4] * array[num, 1];
			array[num, 3] = array[num, 5] * array[num, 1];
			array = MaterialHelper.RoundMaterialSpending(array, num);
			priceProduct = array[num, 0] * Consts2.lystOchynkovanyj05.Price;
		}
		num++;
		materialName[num] = Consts2.lystOchynkovanyj07.MaterialName;
		double num2 = ((D <= 630) ? ((Math.PI * (double)D / 1000.0 + 0.03) * 0.085 * 2.0) : ((Math.PI * (double)D / 1000.0 + 0.03) * 0.135 * 2.0));
		num2 = num2 * 0.05 + num2;
		double num3 = ((D > 630) ? (((double)(D + 50) / 1000.0 * 4.0 + 0.03) * 0.155) : 0.0);
		num3 = num3 * 0.05 + num3;
		double num4 = 0.04 * (double)(D + 50) / 1000.0 * 2.0;
		num4 = num4 * 0.05 + num4;
		array[num, 0] = num2 + num3 + num4;
		array[num, 1] = 0.05;
		array[num, 4] = array[num, 0] * (double)number;
		array[num, 5] = array[num, 4] * 7825.0 * 0.7 / 1000.0;
		array[num, 2] = array[num, 4] * array[num, 1];
		array[num, 3] = array[num, 5] * array[num, 1];
		array = MaterialHelper.RoundMaterialSpending(array, num);
		priceProduct += array[num, 0] * Consts2.lystOchynkovanyj07.Price;
		num++;
		materialName[num] = Consts2.lystOchynkovanyj09.MaterialName;
		array[num, 0] = (double)(D + 62) / 1000.0 * (double)(D + 62) / 1000.0 * 2.0;
		array[num, 0] = array[num, 0] * 0.05 + array[num, 0];
		array[num, 1] = 0.05;
		array[num, 4] = array[num, 0] * (double)number;
		array[num, 5] = array[num, 4] * 7825.0 * 0.9 / 1000.0;
		array[num, 2] = array[num, 4] * array[num, 1];
		array[num, 3] = array[num, 5] * array[num, 1];
		array = MaterialHelper.RoundMaterialSpending(array, num);
		priceProduct += array[num, 0] * Consts2.lystOchynkovanyj09.Price;
		num++;
		materialName[num] = Consts2.lystAljum05.MaterialName;
		array[num, 0] = (double)(D + 50 - 3) * 65.0 / 1000000.0 * 11.0;
		array[num, 0] = array[num, 0] * 0.05 + array[num, 0];
		array[num, 1] = 0.05;
		array[num, 4] = array[num, 0] * (double)number;
		array[num, 2] = array[num, 4] * array[num, 1];
		array = MaterialHelper.RoundMaterialSpending(array, num);
		priceProduct += array[num, 0] * Consts2.lystAljum05.Price;
		num++;
		materialName[num] = Consts2.zaklepkaKombinov48.MaterialName;
		array[num, 0] = 22.0;
		array[num, 4] = array[num, 0] * (double)number;
		priceProduct += array[num, 0] * Consts2.zaklepkaKombinov48.Price;
		num++;
		materialName[num] = Consts2.zaklepkaKombinov32x8.MaterialName;
		array[num, 0] = 16.0;
		array[num, 4] = array[num, 0] * (double)number;
		priceProduct += array[num, 0] * Consts2.zaklepkaKombinov32x8.Price;
		materialCost = priceProduct;
		priceProduct *= 3.0;
		return array;
	}

	public static double[] FormPriceKlapanZvorotniyKZKg()
	{
		double[] array = new double[7];
		int[] array2 = new int[5] { 450, 500, 560, 630, 710 };
		double[,] array3 = new double[12, 6];
		for (int i = 0; i < array2.Length; i++)
		{
			array3 = MaterialKlapanZvorotniyKZKg(array2[i], 1);
			array[i] = priceProduct;
		}
		return array;
	}

	public static double VolumeKlapanZvorotniyKZKg(int D)
	{
		return Math.Round((double)(D + 100) * (double)(D + 100) * 300.0 / 1000000.0) / 1000.0;
	}
}
