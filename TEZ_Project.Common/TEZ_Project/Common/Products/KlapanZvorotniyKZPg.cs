using System;
using TEZ_Project.Common.Helpers;

namespace TEZ_Project.Common.Products;

public static class KlapanZvorotniyKZPg
{
	public static string[] materialName = new string[19]
	{
		"", "", "", "", "", "", "", "", "", "",
		"", "", "", "", "", "", "", "", ""
	};

	public static double materialCost;

	public static double priceProduct;

	public static double[] priceKlapanZvorotniyKZPg = new double[93];

	public static double[,] MaterialKlapanZvorotniyKZPg(int B, int H, int typProfil, int number, int L = 150)
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
		if (B <= 500)
		{
			num++;
			materialName[num] = Consts2.lystOchynkovanyj05.MaterialName;
			array[num, 0] = (double)((B * 2 + H * 2 + 40) * L) / 1000000.0;
			array[num, 0] = array[num, 0] * 0.05 + array[num, 0];
			array[num, 1] = 0.05;
			array[num, 4] = array[num, 0] * (double)number;
			array[num, 5] = array[num, 4] * 7825.0 * 0.5 / 1000.0;
			array[num, 2] = array[num, 4] * array[num, 1];
			array[num, 3] = array[num, 5] * array[num, 1];
			array = MaterialHelper.RoundMaterialSpending(array, num);
			priceProduct = array[num, 0] * Consts2.lystOchynkovanyj05.Price;
		}
		if (B > 500 && B < 800)
		{
			num++;
			materialName[num] = Consts2.lystOchynkovanyj07.MaterialName;
			array[num, 0] = (double)((B * 2 + H * 2 + 40) * L) / 1000000.0;
			array[num, 0] = array[num, 0] * 0.05 + array[num, 0];
			array[num, 1] = 0.05;
			array[num, 4] = array[num, 0] * (double)number;
			array[num, 5] = array[num, 4] * 7825.0 * 0.7 / 1000.0;
			array[num, 2] = array[num, 4] * array[num, 1];
			array[num, 3] = array[num, 5] * array[num, 1];
			array = MaterialHelper.RoundMaterialSpending(array, num);
			priceProduct += array[num, 0] * Consts2.lystOchynkovanyj07.Price;
		}
		if (B >= 800)
		{
			num++;
			materialName[num] = Consts2.lystOchynkovanyj09.MaterialName;
			array[num, 0] = (double)((B * 2 + H * 2 + 40) * L) / 1000000.0;
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
		materialName[num] = Consts2.lystAljum08.MaterialName;
		array[num, 0] = (double)((B - 3) * 65) / 1000000.0 * 6.0;
		array[num, 0] = array[num, 0] * 0.05 + array[num, 0];
		array[num, 1] = 0.05;
		array[num, 4] = array[num, 0] * (double)number;
		array[num, 2] = array[num, 4] * array[num, 1];
		array = MaterialHelper.RoundMaterialSpending(array, num);
		priceProduct += array[num, 0] * Consts2.lystAljum08.Price;
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
			num4 = 3.0;
			num5 = 0.5;
		}
		else
		{
			materialName[num] = Consts2.profilS30.MaterialName;
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
		priceProduct += ((typProfil == 1) ? (array[num, 0] * Consts2.profilS20.Price) : (array[num, 0] * Consts2.profilS30.Price));
		num++;
		materialName[num] = ((typProfil == 1) ? Consts2.kutnykS20.MaterialName : Consts2.kutnykS30.MaterialName);
		array[num, 0] = 8.0;
		array[num, 4] = array[num, 0] * (double)number;
		priceProduct += ((typProfil == 1) ? (array[num, 0] * Consts2.kutnykS20.Price) : (array[num, 0] * Consts2.kutnykS30.Price));
		num++;
		materialName[num] = Consts2.zaklepkaKombinov48.MaterialName;
		array[num, 0] = 12.0;
		array[num, 4] = array[num, 0] * (double)number;
		priceProduct += array[num, 0] * Consts2.zaklepkaKombinov48.Price;
		num++;
		materialName[num] = Consts2.zaklepkaKombinov32x8.MaterialName;
		array[num, 0] = 10.0;
		array[num, 4] = array[num, 0] * (double)number;
		priceProduct += array[num, 0] * Consts2.zaklepkaKombinov32x8.Price;
		materialCost = priceProduct;
		priceProduct *= 3.0;
		return array;
	}

	public static double[] FormPriceKlapanZvorotniyKZPg()
	{
		double[] array = new double[93];
		int[] array2 = new int[93]
		{
			100, 140, 140, 160, 200, 200, 200, 250, 250, 250,
			250, 315, 315, 315, 315, 355, 355, 355, 355, 355,
			400, 400, 400, 400, 400, 400, 450, 450, 450, 450,
			450, 450, 500, 500, 500, 500, 500, 500, 500, 560,
			560, 560, 560, 560, 560, 560, 630, 630, 630, 630,
			630, 630, 710, 710, 710, 710, 710, 710, 710, 710,
			800, 800, 800, 800, 800, 800, 800, 800, 800, 800,
			800, 900, 900, 900, 900, 900, 900, 900, 900, 1000,
			1000, 1000, 1000, 1000, 1000, 1000, 1000, 1250, 1250, 1250,
			1250, 1250, 1250
		};
		int[] array3 = new int[93]
		{
			100, 100, 140, 100, 100, 140, 200, 100, 140, 200,
			250, 140, 200, 250, 315, 140, 200, 250, 315, 355,
			140, 200, 250, 315, 355, 400, 200, 250, 315, 355,
			400, 450, 200, 250, 315, 355, 400, 450, 500, 250,
			315, 355, 400, 450, 500, 560, 315, 400, 450, 500,
			560, 630, 315, 355, 400, 450, 500, 560, 630, 710,
			200, 250, 315, 355, 400, 450, 500, 560, 630, 710,
			800, 400, 450, 500, 560, 630, 710, 800, 900, 450,
			500, 560, 630, 710, 800, 900, 1000, 560, 630, 710,
			800, 900, 1000
		};
		for (int i = 0; i < 93; i++)
		{
			MaterialKlapanZvorotniyKZPg(array2[i], array3[i], 0, 1);
			array[i] = priceProduct;
		}
		return array;
	}

	public static double VolumeKlapanZvorotniyKZPg(int B, int H)
	{
		return Math.Round((double)(B + 60) * (double)(H + 60) * 200.0 / 1000000.0) / 1000.0;
	}
}
