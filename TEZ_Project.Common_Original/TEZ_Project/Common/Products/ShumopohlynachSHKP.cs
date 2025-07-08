using System;

namespace TEZ_Project.Common.Products;

public static class ShumopohlynachSHKP
{
	public static string[] materialName = new string[19]
	{
		"", "", "", "", "", "", "", "", "", "",
		"", "", "", "", "", "", "", "", ""
	};

	public static double materialCost;

	public static double priceProduct;

	public static double[] priceShumopohlynachSHKP = new double[87];

	public static double[,] MaterialShumopohlynachSHKP(int B, int H, int L, int typProfil, int number)
	{
		double[,] array = new double[19, 6];
		int num = -1;
		double num2 = ((B >= H) ? B : H);
		double num3 = 2.0 * (double)(B + H);
		materialName = new string[19]
		{
			"", "", "", "", "", "", "", "", "", "",
			"", "", "", "", "", "", "", "", ""
		};
		materialCost = 0.0;
		priceProduct = 0.0;
		num++;
		if (typProfil == 0)
		{
			typProfil = ((num2 < 800.0) ? 1 : 2);
		}
		double num4;
		double num5;
		if (typProfil == 1)
		{
			materialName[num] = Consts2.profilS20.MaterialName;
			materialName[num + 1] = Consts2.kutnykS20.MaterialName;
			num4 = 3.0;
			num5 = 0.5;
		}
		else
		{
			materialName[num] = Consts2.profilS30.MaterialName;
			materialName[num + 1] = Consts2.kutnykS30.MaterialName;
			num4 = 5.0;
			num5 = 0.75;
		}
		array[num, 0] = (num3 / 1000.0 - 0.12) * (1.0 + num4 / 100.0) * 2.0;
		if (array[num, 0] < 0.005)
		{
			array[num, 0] = Math.Round(1000.0 * array[num, 0]) / 1000.0;
		}
		else
		{
			array[num, 0] = Math.Round(100.0 * array[num, 0]) / 100.0;
		}
		array[num, 1] = num4 / 100.0;
		array[num, 4] = array[num, 0] * (double)number;
		array[num, 5] = array[num, 4] * num5;
		array[num, 2] = array[num, 4] * array[num, 1];
		array[num, 3] = array[num, 5] * array[num, 1];
		array[num + 1, 0] = 8.0;
		array[num + 1, 4] = array[num + 1, 0] * (double)number;
		priceProduct *= 3.0;
		return array;
	}

	public static double[] FormPriceShumopohlynachSHKP()
	{
		double[] array = new double[87];
		int[] array2 = new int[87]
		{
			315, 315, 315, 355, 355, 355, 355, 400, 400, 400,
			400, 400, 450, 450, 450, 450, 450, 450, 500, 500,
			500, 500, 500, 500, 500, 560, 560, 560, 560, 560,
			560, 560, 630, 630, 630, 630, 630, 630, 630, 710,
			710, 710, 710, 710, 710, 710, 710, 710, 800, 800,
			800, 800, 800, 800, 800, 800, 800, 800, 900, 900,
			900, 900, 900, 900, 900, 900, 900, 1000, 1000, 1000,
			1000, 1000, 1000, 1000, 1000, 1000, 1000, 1250, 1250, 1250,
			1250, 1250, 1250, 1250, 1600, 1600, 1600
		};
		int[] array3 = new int[87]
		{
			200, 250, 315, 200, 250, 315, 355, 200, 250, 315,
			355, 400, 200, 250, 315, 355, 400, 450, 200, 250,
			315, 355, 400, 450, 500, 250, 315, 355, 400, 450,
			500, 560, 250, 315, 400, 450, 500, 560, 630, 250,
			315, 355, 400, 450, 500, 560, 630, 710, 250, 315,
			355, 400, 450, 500, 560, 630, 710, 800, 315, 400,
			450, 500, 560, 630, 710, 800, 900, 355, 400, 450,
			500, 560, 630, 710, 800, 900, 1000, 450, 500, 560,
			630, 710, 800, 900, 500, 900, 1000
		};
		for (int i = 0; i < 87; i++)
		{
			MaterialShumopohlynachSHKP(array2[i], array3[i], 1000, 0, 1);
			array[i] = priceProduct;
		}
		return array;
	}

	public static double VolumeShumopohlynachSHKP(int B, int H, int L)
	{
		return Math.Round((double)B * (double)H * (double)L / 1000000.0) / 1000.0;
	}
}
