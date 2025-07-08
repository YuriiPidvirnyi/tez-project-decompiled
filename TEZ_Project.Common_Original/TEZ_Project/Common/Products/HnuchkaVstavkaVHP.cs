using System;

namespace TEZ_Project.Common.Products;

public static class HnuchkaVstavkaVHP
{
	public static string[] materialName = new string[6] { "", "", "", "", "", "" };

	public static double materialCost;

	public static double priceProduct;

	public static double[,] MateriaHnuchkaVstavkaVHP(int B, int H, int typVHP, int typProfil, int number)
	{
		double[,] array = new double[6, 6];
		int num = -1;
		materialName = new string[6] { "", "", "", "", "", "" };
		priceProduct = 0.0;
		materialCost = 0.0;
		num++;
		materialName[num] = Consts2.hnuchkaVstavka45_60_45.MaterialName;
		array[num, 0] = (2.0 * (double)(B + H) / 1000.0 + 0.1) * 1.025;
		array[num, 1] = 0.025;
		array[num, 4] = array[num, 0] * (double)number;
		array[num, 2] = array[num, 4] * array[num, 1];
		if (array[num, 0] < 0.005)
		{
			array[num, 0] = Math.Round(1000.0 * array[num, 0]) / 1000.0;
		}
		else
		{
			array[num, 0] = Math.Round(100.0 * array[num, 0]) / 100.0;
		}
		if (array[num, 2] < 0.005)
		{
			array[num, 2] = Math.Round(1000.0 * array[num, 2]) / 1000.0;
		}
		else
		{
			array[num, 2] = Math.Round(100.0 * array[num, 2]) / 100.0;
		}
		if (array[num, 4] < 0.005)
		{
			array[num, 4] = Math.Round(1000.0 * array[num, 4]) / 1000.0;
		}
		else
		{
			array[num, 4] = Math.Round(100.0 * array[num, 4]) / 100.0;
		}
		priceProduct = array[num, 0] * Consts2.hnuchkaVstavka45_60_45.Price;
		num++;
		materialName[num] = Consts2.klejSecunda.MaterialName;
		array[num, 0] = 0.07;
		array[num, 5] = array[num, 0] * (double)number;
		priceProduct += array[num, 0] * Consts2.klejSecunda.Price;
		int num2 = ((typVHP != 1) ? ((typVHP == 2 || typVHP == 3) ? 1 : 0) : 2);
		if (num2 > 0)
		{
			if (typProfil == 0)
			{
				double num3 = ((B >= H) ? B : H);
				typProfil = ((!(num3 > 700.0) || B + H <= 1000) ? 1 : 2);
			}
			if (typProfil == 1)
			{
				num++;
				materialName[num] = Consts2.profilS20.MaterialName;
				array[num, 0] = (double)num2 * (2.0 * (double)(B + H) / 1000.0 - 0.12) * 1.03;
				array[num, 1] = 0.03;
				array[num, 4] = array[num, 0] * (double)number;
				array[num, 5] = array[num, 4] * 0.5;
				array[num, 2] = array[num, 4] * array[num, 1];
				array[num, 3] = array[num, 2] * 0.5;
				if (array[num, 0] < 0.005)
				{
					array[num, 0] = Math.Round(1000.0 * array[num, 0]) / 1000.0;
				}
				else
				{
					array[num, 0] = Math.Round(100.0 * array[num, 0]) / 100.0;
				}
				if (array[num, 2] < 0.005)
				{
					array[num, 2] = Math.Round(1000.0 * array[num, 2]) / 1000.0;
				}
				else
				{
					array[num, 2] = Math.Round(100.0 * array[num, 2]) / 100.0;
				}
				if (array[num, 3] < 0.005)
				{
					array[num, 3] = Math.Round(1000.0 * array[num, 3]) / 1000.0;
				}
				else
				{
					array[num, 3] = Math.Round(100.0 * array[num, 3]) / 100.0;
				}
				if (array[num, 4] < 0.005)
				{
					array[num, 4] = Math.Round(1000.0 * array[num, 4]) / 1000.0;
				}
				else
				{
					array[num, 4] = Math.Round(100.0 * array[num, 4]) / 100.0;
				}
				if (array[num, 5] < 0.005)
				{
					array[num, 5] = Math.Round(1000.0 * array[num, 5]) / 1000.0;
				}
				else
				{
					array[num, 5] = Math.Round(100.0 * array[num, 5]) / 100.0;
				}
				priceProduct += array[num, 0] * Consts2.profilS20.Price;
				num++;
				materialName[num] = Consts2.kutnykS20.MaterialName;
				array[num, 0] = num2 * 4;
				array[num, 4] = array[num, 0] * (double)number;
				priceProduct += array[num, 0] * Consts2.kutnykS20.Price;
			}
			else
			{
				num++;
				materialName[num] = Consts2.profilS30.MaterialName;
				array[num, 0] = (double)num2 * (2.0 * (double)(B + H) / 1000.0 - 0.14) * 1.05;
				array[num, 1] = 0.05;
				array[num, 4] = array[num, 0] * (double)number;
				array[num, 5] = array[num, 4] * 0.75;
				array[num, 2] = array[num, 4] * array[num, 1];
				array[num, 3] = array[num, 2] * 0.75;
				if (array[num, 0] < 0.005)
				{
					array[num, 0] = Math.Round(1000.0 * array[num, 0]) / 1000.0;
				}
				else
				{
					array[num, 0] = Math.Round(100.0 * array[num, 0]) / 100.0;
				}
				if (array[num, 2] < 0.005)
				{
					array[num, 2] = Math.Round(1000.0 * array[num, 2]) / 1000.0;
				}
				else
				{
					array[num, 2] = Math.Round(100.0 * array[num, 2]) / 100.0;
				}
				if (array[num, 3] < 0.005)
				{
					array[num, 3] = Math.Round(1000.0 * array[num, 3]) / 1000.0;
				}
				else
				{
					array[num, 3] = Math.Round(100.0 * array[num, 3]) / 100.0;
				}
				if (array[num, 4] < 0.005)
				{
					array[num, 4] = Math.Round(1000.0 * array[num, 4]) / 1000.0;
				}
				else
				{
					array[num, 4] = Math.Round(100.0 * array[num, 4]) / 100.0;
				}
				if (array[num, 5] < 0.005)
				{
					array[num, 5] = Math.Round(1000.0 * array[num, 5]) / 1000.0;
				}
				else
				{
					array[num, 5] = Math.Round(100.0 * array[num, 5]) / 100.0;
				}
				priceProduct += array[num, 0] * Consts2.profilS30.Price;
				num++;
				materialName[num] = Consts2.kutnykS30.MaterialName;
				array[num, 0] = num2 * 4;
				array[num, 4] = array[num, 0] * (double)number;
				priceProduct += array[num, 0] * Consts2.kutnykS30.Price;
			}
		}
		materialCost = priceProduct;
		priceProduct *= 3.0;
		return array;
	}

	public static double[] FormPriceHnuchkaVstavkaVHP()
	{
		double[] array = new double[100];
		int[] array2 = new int[100]
		{
			100, 140, 140, 160, 200, 200, 200, 250, 250, 250,
			250, 315, 315, 315, 315, 355, 355, 355, 355, 355,
			400, 400, 400, 400, 400, 400, 450, 450, 450, 450,
			450, 450, 500, 500, 500, 500, 500, 500, 500, 500,
			560, 560, 560, 560, 560, 560, 560, 560, 630, 630,
			630, 630, 630, 630, 630, 630, 710, 710, 710, 710,
			710, 710, 710, 710, 710, 710, 800, 800, 800, 800,
			800, 800, 800, 800, 800, 800, 800, 900, 900, 900,
			900, 900, 900, 900, 900, 900, 900, 900, 1000, 1000,
			1000, 1000, 1000, 1000, 1000, 1000, 1000, 1000, 1000, 1000
		};
		int[] array3 = new int[100]
		{
			100, 100, 140, 100, 100, 140, 200, 100, 140, 200,
			250, 140, 200, 250, 315, 140, 200, 250, 315, 355,
			140, 200, 250, 315, 355, 400, 200, 250, 315, 355,
			400, 450, 200, 250, 315, 355, 400, 450, 500, 630,
			250, 315, 355, 400, 450, 500, 560, 630, 200, 250,
			315, 400, 450, 500, 560, 630, 200, 250, 315, 355,
			400, 450, 500, 560, 630, 710, 200, 250, 315, 355,
			400, 450, 500, 560, 630, 710, 800, 200, 315, 355,
			400, 450, 500, 560, 630, 710, 800, 900, 200, 315,
			355, 400, 450, 500, 560, 630, 710, 800, 900, 1000
		};
		double[,] array4 = new double[6, 6];
		for (int i = 0; i < 100; i++)
		{
			array4 = MateriaHnuchkaVstavkaVHP(array2[i], array3[i], 1, 0, 1);
			array[i] = priceProduct;
		}
		return array;
	}

	public static double VolumeHnuchkaVstavkaVHP(int B, int H)
	{
		return Math.Round((double)B * (double)H * 150.0 / 1000000.0) / 1000.0;
	}
}
