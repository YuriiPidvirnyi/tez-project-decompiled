using System;
using TEZ_Project.Common.Helpers;

namespace TEZ_Project.Common.Products;

public static class ShumopohlynachSHP
{
	public static string[] materialName = new string[19]
	{
		"", "", "", "", "", "", "", "", "", "",
		"", "", "", "", "", "", "", "", ""
	};

	public static double materialCost;

	public static double priceProduct;

	public static double[] priceShumopohlynachSHP = new double[65];

	public static double[,] MaterialShumopohlynachSHP(int B, int H, int L, int typProfil, int number)
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
		materialName[num] = Consts2.lystOchynkovanyj05.MaterialName;
		double num4 = ((double)(B + 100 + 2 * (H + 100) + 60) / 1000.0 + (double)(B + 100 + 20) / 1000.0) * (double)(L + 100) / 1000.0;
		num4 = num4 * 0.05 + num4;
		double num5 = 0.08 * (double)H / 1000.0 * 4.0;
		num5 = num5 * 0.05 + num5;
		array[num, 0] = num4 + num5;
		array[num, 1] = 0.05;
		array[num, 4] = array[num, 0] * (double)number;
		array[num, 5] = array[num, 4] * 7825.0 * 0.5 / 1000.0;
		array[num, 2] = array[num, 4] * array[num, 1];
		array[num, 3] = array[num, 5] * array[num, 1];
		array = MaterialHelper.RoundMaterialSpending(array, num);
		priceProduct = array[num, 0] * Consts2.lystOchynkovanyj05.Price;
		num++;
		if (typProfil == 0)
		{
			typProfil = ((num2 < 800.0) ? 1 : 2);
		}
		double num6;
		double num7;
		if (typProfil == 1)
		{
			materialName[num] = Consts2.profilS20.MaterialName;
			num6 = 3.0;
			num7 = 0.5;
		}
		else
		{
			materialName[num] = Consts2.profilS30.MaterialName;
			num6 = 5.0;
			num7 = 0.75;
		}
		array[num, 0] = (num3 / 1000.0 - 0.12) * (1.0 + num6 / 100.0) * 2.0;
		if (array[num, 0] < 0.005)
		{
			array[num, 0] = Math.Round(1000.0 * array[num, 0]) / 1000.0;
		}
		else
		{
			array[num, 0] = Math.Round(100.0 * array[num, 0]) / 100.0;
		}
		array[num, 1] = num6 / 100.0;
		array[num, 4] = array[num, 0] * (double)number;
		array[num, 5] = array[num, 4] * num7;
		array[num, 2] = array[num, 4] * array[num, 1];
		array[num, 3] = array[num, 5] * array[num, 1];
		priceProduct += array[num, 0] * ((typProfil == 1) ? Consts2.profilS20.Price : Consts2.profilS30.Price);
		num++;
		materialName[num] = ((typProfil == 1) ? Consts2.kutnykS20.MaterialName : Consts2.kutnykS30.MaterialName);
		array[num, 0] = 8.0;
		array[num, 4] = array[num, 0] * (double)number;
		priceProduct += array[num, 0] * ((typProfil == 1) ? Consts2.kutnykS20.Price : Consts2.kutnykS30.Price);
		num++;
		materialName[num] = Consts2.sitka25x25.MaterialName;
		array[num, 0] = (double)((B + H) * 2 + 50) / 1000.0 * (double)L / 1000.0;
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
		array[num, 0] = (double)(2 * (B + 100) + 2 * H) / 1000.0 * (double)(L - 100) / 1000.0;
		array[num, 0] = array[num, 0] * 0.05 + array[num, 0];
		array[num, 1] = 0.05;
		array[num, 4] = array[num, 0] * (double)number;
		array[num, 2] = array[num, 4] * array[num, 1];
		array = MaterialHelper.RoundMaterialSpending(array, num);
		priceProduct += array[num, 0] * Consts2.mineralnaVataTehno50mm.Price;
		num++;
		materialName[num] = Consts2.sklotkanynaTG_140.MaterialName;
		array[num, 0] = (double)((B + H) * 2 + 100) / 1000.0 * (double)L / 1000.0;
		array[num, 0] = array[num, 0] * 0.1 + array[num, 0];
		array[num, 1] = 0.05;
		array[num, 4] = array[num, 0] * (double)number;
		array[num, 2] = array[num, 4] * array[num, 1];
		array = MaterialHelper.RoundMaterialSpending(array, num);
		priceProduct += array[num, 0] * Consts2.sklotkanynaTG_140.Price;
		num++;
		materialName[num] = Consts2.skotch48x200.MaterialName;
		array[num, 0] = (double)(2 * (B + H)) / 1000.0 * 0.1;
		array[num, 4] = array[num, 0] * (double)number;
		priceProduct += array[num, 0] * Consts2.skotch48x200.Price;
		num++;
		materialName[num] = Consts2.hvynt9x11.MaterialName;
		array[num, 0] = 24.0;
		array[num, 4] = array[num, 0] * (double)number;
		priceProduct += array[num, 0] * Consts2.hvynt9x11.Price;
		materialCost = priceProduct;
		priceProduct *= 3.0;
		return array;
	}

	public static double[] FormPriceShumopohlynachSHP()
	{
		double[] array = new double[65];
		int[] array2 = new int[65]
		{
			200, 200, 250, 250, 250, 315, 315, 315, 315, 355,
			355, 355, 355, 400, 400, 400, 400, 400, 400, 450,
			450, 450, 450, 450, 450, 500, 500, 500, 500, 500,
			500, 500, 560, 560, 560, 560, 560, 560, 560, 630,
			630, 630, 630, 630, 630, 630, 710, 710, 710, 710,
			710, 710, 710, 710, 710, 800, 800, 800, 800, 800,
			800, 800, 800, 800, 800
		};
		int[] array3 = new int[65]
		{
			140, 200, 140, 200, 250, 140, 200, 250, 315, 200,
			250, 315, 355, 140, 200, 250, 315, 355, 400, 200,
			250, 315, 355, 400, 450, 200, 250, 315, 355, 400,
			450, 500, 250, 315, 355, 400, 450, 500, 560, 250,
			315, 400, 450, 500, 560, 630, 250, 315, 355, 400,
			450, 500, 560, 630, 710, 250, 315, 355, 400, 450,
			500, 560, 630, 710, 800
		};
		for (int i = 0; i < 65; i++)
		{
			MaterialShumopohlynachSHP(array2[i], array3[i], 600, 0, 1);
			array[i] = priceProduct;
		}
		return array;
	}

	public static double VolumeShumopohlynachSHP(int B, int H, int L)
	{
		return Math.Round((double)B * (double)H * (double)L / 1000000.0) / 1000.0;
	}
}
