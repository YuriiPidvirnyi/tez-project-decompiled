using System;
using System.Collections.Generic;
using TEZ_Project.Common.Helpers;

namespace TEZ_Project.Common.Products;

public static class FiltrFK
{
	public static string[] materialName = new string[14]
	{
		"", "", "", "", "", "", "", "", "", "",
		"", "", "", ""
	};

	public static double materialCost;

	public static double priceProduct;

	public static double[,] MaterialFiltrFK(int D, int number)
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
		if (D <= 355)
		{
			num++;
			materialName[num] = Consts2.lystOchynkovanyj05.MaterialName;
			double num2 = (double)(D + 70) / 1000.0 * 120.0 / 1000.0;
			double num3 = Math.PI * (double)D / 1000.0 * 85.0 / 1000.0 * 2.0;
			double num4 = (double)(D + 80) / 1000.0 * (double)(D + 80) / 1000.0 * 2.0;
			double num5 = (double)(D + 50) / 1000.0 * 3.0 * 100.0 / 1000.0;
			array[num, 0] = num2 + num3 + num4 + num5;
			array[num, 0] = array[num, 0] * 0.05 + array[num, 0];
			array[num, 1] = 0.05;
			array[num, 4] = array[num, 0] * (double)number;
			array[num, 5] = array[num, 4] * 7825.0 * 0.5 / 1000.0;
			array[num, 2] = array[num, 4] * array[num, 1];
			array[num, 3] = array[num, 5] * array[num, 1];
			array = MaterialHelper.RoundMaterialSpending(array, num);
			priceProduct = array[num, 0] * Consts2.lystOchynkovanyj05.Price;
			num++;
			materialName[num] = Consts2.sitkaProsVyt10x25x08.MaterialName;
			array[num, 0] = Math.Sqrt(Math.Pow(0.1, 2.0) + Math.Pow((double)(D + 50) / 2000.0, 2.0)) * 2.0 * (double)(D + 50) / 1000.0;
			array[num, 0] = array[num, 0] * 0.05 + array[num, 0];
			array[num, 1] = 0.05;
			array[num, 4] = array[num, 0] * (double)number;
			array[num, 2] = array[num, 4] * array[num, 1];
			array = MaterialHelper.RoundMaterialSpending(array, num, new List<int> { 3, 5 });
			priceProduct += array[num, 0] * Consts2.sitkaProsVyt10x25x08.Price;
			num++;
			materialName[num] = Consts2.filtruvalnaTkanynaSyntepon.MaterialName;
			array[num, 0] = (Math.Sqrt(Math.Pow(0.1, 2.0) + Math.Pow((double)(D + 50) / 2000.0, 2.0)) * 2.0 + 0.05) * ((double)(D + 50) / 1000.0 + 0.05);
			array[num, 0] = array[num, 0] * 0.05 + array[num, 0];
			array[num, 1] = 0.05;
			array[num, 4] = array[num, 0] * (double)number;
			array[num, 2] = array[num, 4] * array[num, 1];
			array = MaterialHelper.RoundMaterialSpending(array, num, new List<int> { 3, 5 });
			priceProduct += array[num, 0] * Consts2.filtruvalnaTkanynaSyntepon.Price;
			num++;
			materialName[num] = Consts2.zaklepkaKombinov4x6.MaterialName;
			array[num, 0] = 20.0;
			array[num, 4] = array[num, 0] * (double)number;
			priceProduct += array[num, 0] * Consts2.zaklepkaKombinov4x6.Price;
			num++;
			materialName[num] = Consts2.hajkaM6_05_25.MaterialName;
			array[num, 0] = 4.0;
			array[num, 4] = array[num, 0] * (double)number;
			priceProduct += array[num, 0] * Consts2.hajkaM6_05_25.Price;
			num++;
			materialName[num] = Consts2.hvyntBarancM6x10.MaterialName;
			array[num, 0] = 4.0;
			array[num, 4] = array[num, 0] * (double)number;
			priceProduct += array[num, 0] * Consts2.hvyntBarancM6x10.Price;
		}
		else
		{
			num++;
			materialName[num] = Consts2.lystOchynkovanyj05.MaterialName;
			double num6 = ((D <= 400) ? ((Math.PI * (double)D / 1000.0 + 0.01) * 85.0 / 1000.0) : 0.0);
			double num7 = ((D <= 630) ? (((double)(D + 50) / 1000.0 * 3.0 + 0.02) * 235.0 / 1000.0) : 0.0);
			array[num, 0] = num6 + num7;
			array[num, 0] = array[num, 0] * 0.05 + array[num, 0];
			array[num, 1] = 0.05;
			array[num, 4] = array[num, 0] * (double)number;
			array[num, 5] = array[num, 4] * 7825.0 * 0.5 / 1000.0;
			array[num, 2] = array[num, 4] * array[num, 1];
			array[num, 3] = array[num, 5] * array[num, 1];
			array = MaterialHelper.RoundMaterialSpending(array, num);
			priceProduct = array[num, 0] * Consts2.lystOchynkovanyj05.Price;
			num++;
			materialName[num] = Consts2.lystOchynkovanyj07.MaterialName;
			double num8 = ((D > 355 && D < 630) ? ((double)((D + 50) * 4 + 30) / 1000.0 * 150.0 / 1000.0) : 0.0);
			double num9 = ((D >= 630) ? ((double)((D + 50) * 3 + 30) / 1000.0 * 150.0 / 1000.0) : 0.0);
			double num10 = ((D > 400 && D <= 630) ? ((Math.PI * (double)D / 1000.0 + 0.01) * 85.0 / 1000.0) : 0.0);
			double num11 = ((D <= 315) ? ((double)(D + 70) / 1000.0 * (double)(D + 70) / 1000.0) : 0.0);
			double num12 = ((D > 630) ? (((double)(D + 50) / 1000.0 * 3.0 + 0.02) * 235.0 / 1000.0) : 0.0);
			double num13 = ((D > 315) ? ((double)(D + 50) / 1000.0 * 40.0 / 1000.0 * 4.0) : 0.0);
			array[num, 0] = num8 + num9 + num10 + num11 + num12 + num13;
			array[num, 0] = array[num, 0] * 0.05 + array[num, 0];
			array[num, 1] = 0.05;
			array[num, 4] = array[num, 0] * (double)number;
			array[num, 5] = array[num, 4] * 7825.0 * 0.7 / 1000.0;
			array[num, 2] = array[num, 4] * array[num, 1];
			array[num, 3] = array[num, 5] * array[num, 1];
			array = MaterialHelper.RoundMaterialSpending(array, num);
			priceProduct += array[num, 0] * Consts2.lystOchynkovanyj07.Price;
			num++;
			materialName[num] = Consts2.lystOchynkovanyj09.MaterialName;
			double num14 = (double)(D + 100) / 1000.0 * 200.0 / 1000.0;
			double num15 = ((D >= 630) ? ((double)(D + 50) / 1000.0 * 150.0 / 1000.0) : 0.0);
			double num16 = ((D > 630) ? ((Math.PI * (double)D / 1000.0 + 0.01) * 135.0 / 1000.0) : 0.0);
			double num17 = ((D > 315) ? ((double)(D + 70) / 1000.0 * (double)(D + 70) / 1000.0) : 0.0);
			array[num, 0] = num14 + num15 + num16 + num17;
			array[num, 0] = array[num, 0] * 0.05 + array[num, 0];
			array[num, 1] = 0.05;
			array[num, 4] = array[num, 0] * (double)number;
			array[num, 5] = array[num, 4] * 7825.0 * 0.9 / 1000.0;
			array[num, 2] = array[num, 4] * array[num, 1];
			array[num, 3] = array[num, 5] * array[num, 1];
			array = MaterialHelper.RoundMaterialSpending(array, num);
			priceProduct += array[num, 0] * Consts2.lystOchynkovanyj09.Price;
			num++;
			materialName[num] = Consts2.uschilnjuvachGumovyiD.MaterialName;
			array[num, 0] = (double)(D + 50 + 180) / 1000.0 * 2.0;
			array[num, 0] *= 1.05;
			array[num, 1] = 0.05;
			array[num, 4] = array[num, 0] * (double)number;
			array[num, 2] = array[num, 4] * array[num, 1];
			array = MaterialHelper.RoundMaterialSpending(array, num, new List<int> { 3, 5 });
			priceProduct += array[num, 0] * Consts2.uschilnjuvachGumovyiD.Price;
			num++;
			materialName[num] = Consts2.sitka25x25.MaterialName;
			array[num, 0] = GetSitka25x25(D) * 2.0;
			array[num, 0] = array[num, 0] * 0.05 + array[num, 0];
			array[num, 1] = 0.05;
			array[num, 4] = array[num, 0] * (double)number;
			array[num, 2] = array[num, 4] * array[num, 1];
			array = MaterialHelper.RoundMaterialSpending(array, num, new List<int> { 3, 5 });
			priceProduct += array[num, 0] * Consts2.sitka25x25.Price;
			num++;
			materialName[num] = Consts2.filtruvalnaTkanynaSyntepon.MaterialName;
			array[num, 0] = GetFiltruvalnaTkanynaSyntepon(D);
			array[num, 0] = array[num, 0] * 0.05 + array[num, 0];
			array[num, 1] = 0.05;
			array[num, 4] = array[num, 0] * (double)number;
			array[num, 2] = array[num, 4] * array[num, 1];
			array = MaterialHelper.RoundMaterialSpending(array, num, new List<int> { 3, 5 });
			priceProduct += array[num, 0] * Consts2.filtruvalnaTkanynaSyntepon.Price;
			num++;
			materialName[num] = Consts2.zatyskach.MaterialName;
			array[num, 0] = 2.0;
			array[num, 4] = array[num, 0] * (double)number;
			priceProduct += array[num, 0] * Consts2.zatyskach.Price;
			num++;
			materialName[num] = Consts2.zaklepkaKombinov48.MaterialName;
			array[num, 0] = 6.0;
			array[num, 4] = array[num, 0] * (double)number;
			priceProduct += array[num, 0] * Consts2.zaklepkaKombinov48.Price;
			num++;
			materialName[num] = Consts2.hvynt9x11.MaterialName;
			array[num, 0] = 6.0;
			array[num, 4] = array[num, 0] * (double)number;
			priceProduct += array[num, 0] * Consts2.hvynt9x11.Price;
		}
		materialCost = priceProduct;
		priceProduct *= 3.0;
		return array;
	}

	public static double[] FormPriceFiltrFK()
	{
		double[] array = new double[24];
		int[] array2 = new int[24]
		{
			100, 125, 140, 150, 160, 180, 200, 225, 250, 280,
			315, 355, 400, 450, 500, 560, 630, 710, 800, 900,
			1000, 1120, 1250, 1400
		};
		double[,] array3 = new double[12, 6];
		for (int i = 0; i < 24; i++)
		{
			array3 = MaterialFiltrFK(array2[i], 1);
			array[i] = priceProduct;
		}
		return array;
	}

	public static double VolumeFiltrFK(int D)
	{
		return Math.Round((double)(D + 100) * (double)(D + 100) * 300.0 / 1000000.0) / 1000.0;
	}

	private static double GetSitka25x25(int d)
	{
		Func<int, double> getResult = (int x) => (double)(d + 50) / 1000.0 * (double)x / 1000.0;
		return GetSitkaOrFiltruvalnaTkanyna(d, getResult);
	}

	private static double GetFiltruvalnaTkanynaSyntepon(int d)
	{
		Func<int, double> getResult = (int x) => (double)(d + 100) / 1000.0 * (double)(x + 150) / 1000.0;
		return GetSitkaOrFiltruvalnaTkanyna(d, getResult);
	}

	private static double GetSitkaOrFiltruvalnaTkanyna(int d, Func<int, double> GetResult)
	{
		if (d <= 200)
		{
			return GetResult(315);
		}
		if (d <= 250)
		{
			return GetResult(355);
		}
		if (d <= 280)
		{
			return GetResult(442);
		}
		if (d <= 315)
		{
			return GetResult(465);
		}
		if (d <= 355)
		{
			return GetResult(500);
		}
		if (d <= 400)
		{
			return GetResult(600);
		}
		if (d <= 450)
		{
			return GetResult(635);
		}
		if (d <= 500)
		{
			return GetResult(675);
		}
		if (d <= 550)
		{
			return GetResult(775);
		}
		if (d <= 630)
		{
			return GetResult(840);
		}
		return GetResult(960);
	}
}
