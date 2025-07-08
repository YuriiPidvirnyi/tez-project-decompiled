using System;

namespace TEZ_Project.Common.Products;

public static class HomutAspiratsijnyj
{
	public static string[] materialName = new string[5] { "", "", "", "", "" };

	public static double materialCost;

	public static double[,] MaterialHomutAspiratsijnyj(int D, int number)
	{
		double[,] array = new double[5, 6];
		double num = 7825.0;
		materialName = new string[5] { "", "", "", "", "" };
		materialCost = 0.0;
		materialName[0] = Consts2.lystOchynkovanyj07.MaterialName;
		materialName[1] = Consts2.lystOchynkovanyj09.MaterialName;
		materialName[2] = Consts2.boltM6_70.MaterialName;
		materialName[3] = Consts2.hajkaM6.MaterialName;
		materialName[4] = Consts2.shajba6zbilshena.MaterialName;
		array[0, 0] = (Math.PI * (double)D + 100.0) * 40.0 / 1000000.0 * 1.05;
		array[0, 1] = 0.05;
		array[0, 4] = array[0, 0] * (double)number;
		array[0, 5] = array[0, 4] * num * 0.7 / 1000.0;
		array[0, 2] = array[0, 4] * array[0, 1];
		array[0, 3] = array[0, 5] * array[0, 1];
		if (array[0, 0] < 0.005)
		{
			array[0, 0] = Math.Round(1000.0 * array[0, 0]) / 1000.0;
		}
		else
		{
			array[0, 0] = Math.Round(100.0 * array[0, 0]) / 100.0;
		}
		if (array[0, 2] < 0.005)
		{
			array[0, 2] = Math.Round(1000.0 * array[0, 2]) / 1000.0;
		}
		else
		{
			array[0, 2] = Math.Round(100.0 * array[0, 2]) / 100.0;
		}
		if (array[0, 3] < 0.005)
		{
			array[0, 3] = Math.Round(1000.0 * array[0, 3]) / 1000.0;
		}
		else
		{
			array[0, 3] = Math.Round(100.0 * array[0, 3]) / 100.0;
		}
		if (array[0, 4] < 0.005)
		{
			array[0, 4] = Math.Round(1000.0 * array[0, 4]) / 1000.0;
		}
		else
		{
			array[0, 4] = Math.Round(100.0 * array[0, 4]) / 100.0;
		}
		if (array[0, 5] < 0.005)
		{
			array[0, 5] = Math.Round(1000.0 * array[0, 5]) / 1000.0;
		}
		else
		{
			array[0, 5] = Math.Round(100.0 * array[0, 5]) / 100.0;
		}
		materialCost = array[0, 0] * Consts2.lystOchynkovanyj07.Price;
		array[1, 0] = 0.005;
		array[1, 1] = 0.2;
		array[1, 4] = array[1, 0] * (double)number;
		array[1, 5] = array[1, 4] * num * 0.7 / 1000.0;
		array[1, 2] = array[1, 4] * array[1, 1];
		array[1, 3] = array[1, 5] * array[1, 1];
		materialCost += array[1, 0] * Consts2.lystOchynkovanyj09.Price;
		array[2, 0] = 1.0;
		array[2, 4] = array[2, 0] * (double)number;
		materialCost += array[2, 0] * Consts2.boltM6_70.Price;
		array[3, 0] = 1.0;
		array[3, 4] = array[3, 0] * (double)number;
		materialCost += array[3, 0] * Consts2.hajkaM6.Price;
		array[4, 0] = 2.0;
		array[4, 4] = array[4, 0] * (double)number;
		materialCost += array[4, 0] * Consts2.shajba6zbilshena.Price;
		return array;
	}

	public static double GetPriceHomutAspiratsijnyj(int D)
	{
		return Math.PI * (double)D * 130.0 / 1000.0;
	}

	public static double[] FormPriceHomutAspiratsijnyj()
	{
		double[] array = new double[24];
		int[] array2 = new int[24]
		{
			100, 110, 125, 140, 160, 180, 200, 225, 250, 280,
			315, 355, 400, 450, 500, 560, 630, 710, 800, 900,
			1000, 1120, 1250, 1400
		};
		for (int i = 0; i < array.Length; i++)
		{
			array[i] = GetPriceHomutAspiratsijnyj(array2[i]);
		}
		return array;
	}

	public static double VolumeHomutAspiratsijnyj(int D)
	{
		return Math.Round((double)D * (double)D * 40.0 / 1000000.0) / 1000.0;
	}
}
