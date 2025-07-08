using System;
using System.Collections.Generic;
using TEZ_Project.Common.Helpers;

namespace TEZ_Project.Common.Products;

public static class KlapanZvorotniyKZP
{
	public static string[] materialName = new string[19]
	{
		"", "", "", "", "", "", "", "", "", "",
		"", "", "", "", "", "", "", "", ""
	};

	public static double materialCost;

	public static double priceProduct;

	public static double[,] MaterialKlapanZvorotniyKZP(int B, int H, int typProfil, int number, int L = 150)
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
		double num4 = (((double)B / 1000.0 + (double)H / 1000.0) * 2.0 + 0.03) * (double)L / 1000.0;
		num4 = num4 * 0.05 + num4;
		double num5 = ((double)B / 1000.0 + (double)H / 1000.0) * 2.0 * 50.0 / 1000.0;
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
		materialName[num] = Consts2.lystAljum05.MaterialName;
		array[num, 0] = (double)(B + 10) / 1000.0 * (double)(H + 10) / 1000.0;
		array[num, 0] = array[num, 0] * 0.05 + array[num, 0];
		array[num, 1] = 0.05;
		array[num, 4] = array[num, 0] * (double)number;
		array[num, 2] = array[num, 4] * array[num, 1];
		array = MaterialHelper.RoundMaterialSpending(array, num, new List<int> { 2 });
		priceProduct += array[num, 0] * Consts2.lystAljum05.Price;
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
		materialName[num] = Consts2.pruzyna22.MaterialName;
		array[num, 0] = MaterialHelper.GetAmountOfPruzyn(B);
		array[num, 4] = array[num, 0] * (double)number;
		priceProduct += array[num, 0] * Consts2.pruzyna22.Price;
		num++;
		materialName[num] = Consts2.drit2.MaterialName;
		array[num, 0] = (double)(B + 20) / 1000.0;
		array[num, 0] = array[num, 0] * 0.05 + array[num, 0];
		array[num, 1] = 0.05;
		array[num, 4] = array[num, 0] * (double)number;
		array[num, 5] = array[num, 4] * 0.07;
		array[num, 2] = array[num, 4] * array[num, 1];
		array[num, 3] = array[num, 5] * array[num, 1];
		array = MaterialHelper.RoundMaterialSpending(array, num);
		priceProduct += array[num, 0] * Consts2.drit2.Price;
		materialCost = priceProduct;
		priceProduct *= 3.0;
		return array;
	}

	public static double VolumeKlapanZvorotniyKZP(int B, int H)
	{
		return Math.Round((double)(B + 60) * (double)(H + 60) * 200.0 / 1000000.0) / 1000.0;
	}
}
