using System;

namespace TEZ_Project.Common.Products;

public static class HnuchkaVstavkaVHK
{
	public static string[] materialName = new string[7] { "", "", "", "", "", "", "" };

	public static double materialCost;

	public static double priceProduct;

	public static double[,] MateriaHnuchkaVstavkaVHK(int D, int number, int typVHK)
	{
		double[,] array = new double[7, 6];
		double num = 0.0;
		int num2 = -1;
		double num3 = 0.0;
		double num4 = 0.0;
		double num5 = 0.0;
		materialName = new string[7] { "", "", "", "", "", "", "" };
		priceProduct = 0.0;
		materialCost = 0.0;
		int num6 = typVHK - 1;
		if (num6 > 0)
		{
			if (D >= 80 && D <= 250)
			{
				num2++;
				materialName[num2] = Consts2.lystStalnyj30.MaterialName;
				array[num2, 0] = (double)num6 * Math.Pow(D + 60, 2.0) * 1.05 / 1000000.0;
				num3 = array[num2, 0];
				array[num2, 1] = 0.05;
				array[num2, 4] = array[num2, 0] * (double)number;
				num = 3.0;
				array[num2, 5] = array[num2, 4] * 7825.0 * num / 1000.0;
				array[num2, 2] = array[num2, 4] * array[num2, 1];
				array[num2, 3] = array[num2, 5] * array[num2, 1];
				if (array[num2, 0] < 0.005)
				{
					array[num2, 0] = Math.Round(1000.0 * array[num2, 0]) / 1000.0;
				}
				else
				{
					array[num2, 0] = Math.Round(100.0 * array[num2, 0]) / 100.0;
				}
				if (array[num2, 2] < 0.005)
				{
					array[num2, 2] = Math.Round(1000.0 * array[num2, 2]) / 1000.0;
				}
				else
				{
					array[num2, 2] = Math.Round(100.0 * array[num2, 2]) / 100.0;
				}
				if (array[num2, 3] < 0.005)
				{
					array[num2, 3] = Math.Round(1000.0 * array[num2, 3]) / 1000.0;
				}
				else
				{
					array[num2, 3] = Math.Round(100.0 * array[num2, 3]) / 100.0;
				}
				if (array[num2, 4] < 0.005)
				{
					array[num2, 4] = Math.Round(1000.0 * array[num2, 4]) / 1000.0;
				}
				else
				{
					array[num2, 4] = Math.Round(100.0 * array[num2, 4]) / 100.0;
				}
				if (array[num2, 5] < 0.005)
				{
					array[num2, 5] = Math.Round(1000.0 * array[num2, 5]) / 1000.0;
				}
				else
				{
					array[num2, 5] = Math.Round(100.0 * array[num2, 5]) / 100.0;
				}
				priceProduct += array[num2, 0] * Consts2.lystStalnyj30.Price;
			}
			if (D >= 250 && D <= 800)
			{
				num2++;
				materialName[num2] = Consts2.kutnyk25_25_4.MaterialName;
				array[num2, 0] = (double)num6 * Math.PI * (double)(D + 50) * 1.08 / 1000.0;
				num4 = array[num2, 0];
				array[num2, 1] = 0.08;
				array[num2, 4] = array[num2, 0] * (double)number;
				array[num2, 5] = array[num2, 4] * 1.46;
				array[num2, 2] = array[num2, 4] * array[num2, 1];
				array[num2, 3] = array[num2, 2] * 1.46;
				if (array[num2, 0] < 0.005)
				{
					array[num2, 0] = Math.Round(1000.0 * array[num2, 0]) / 1000.0;
				}
				else
				{
					array[num2, 0] = Math.Round(100.0 * array[num2, 0]) / 100.0;
				}
				if (array[num2, 2] < 0.005)
				{
					array[num2, 2] = Math.Round(1000.0 * array[num2, 2]) / 1000.0;
				}
				else
				{
					array[num2, 2] = Math.Round(100.0 * array[num2, 2]) / 100.0;
				}
				if (array[num2, 3] < 0.005)
				{
					array[num2, 3] = Math.Round(1000.0 * array[num2, 3]) / 1000.0;
				}
				else
				{
					array[num2, 3] = Math.Round(100.0 * array[num2, 3]) / 100.0;
				}
				if (array[num2, 4] < 0.005)
				{
					array[num2, 4] = Math.Round(1000.0 * array[num2, 4]) / 1000.0;
				}
				else
				{
					array[num2, 4] = Math.Round(100.0 * array[num2, 4]) / 100.0;
				}
				if (array[num2, 5] < 0.005)
				{
					array[num2, 5] = Math.Round(1000.0 * array[num2, 5]) / 1000.0;
				}
				else
				{
					array[num2, 5] = Math.Round(100.0 * array[num2, 5]) / 100.0;
				}
				priceProduct += array[num2, 0] * Consts2.kutnyk25_25_4.Price;
			}
			if (D > 800)
			{
				num2++;
				materialName[num2] = Consts2.kutnyk35_35_4.MaterialName;
				array[num2, 0] = (double)num6 * Math.PI * (double)(D + 70) * 1.08 / 1000.0;
				num5 = array[num2, 0];
				array[num2, 1] = 0.08;
				array[num2, 4] = array[num2, 0] * (double)number;
				array[num2, 5] = array[num2, 4] * 2.16;
				array[num2, 2] = array[num2, 4] * array[num2, 1];
				array[num2, 3] = array[num2, 2] * 2.16;
				if (array[num2, 0] < 0.005)
				{
					array[num2, 0] = Math.Round(1000.0 * array[num2, 0]) / 1000.0;
				}
				else
				{
					array[num2, 0] = Math.Round(100.0 * array[num2, 0]) / 100.0;
				}
				if (array[num2, 2] < 0.005)
				{
					array[num2, 2] = Math.Round(1000.0 * array[num2, 2]) / 1000.0;
				}
				else
				{
					array[num2, 2] = Math.Round(100.0 * array[num2, 2]) / 100.0;
				}
				if (array[num2, 3] < 0.005)
				{
					array[num2, 3] = Math.Round(1000.0 * array[num2, 3]) / 1000.0;
				}
				else
				{
					array[num2, 3] = Math.Round(100.0 * array[num2, 3]) / 100.0;
				}
				if (array[num2, 4] < 0.005)
				{
					array[num2, 4] = Math.Round(1000.0 * array[num2, 4]) / 1000.0;
				}
				else
				{
					array[num2, 4] = Math.Round(100.0 * array[num2, 4]) / 100.0;
				}
				if (array[num2, 5] < 0.005)
				{
					array[num2, 5] = Math.Round(1000.0 * array[num2, 5]) / 1000.0;
				}
				else
				{
					array[num2, 5] = Math.Round(100.0 * array[num2, 5]) / 100.0;
				}
				priceProduct += array[num2, 0] * Consts2.kutnyk35_35_4.Price;
			}
			num2++;
			materialName[num2] = Consts2.hruntovkaHF.MaterialName;
			array[num2, 0] = ((D <= 200) ? (num3 * 2.0 * 0.05) : (0.08 * (num4 + 2.0 * num5)));
			array[num2, 5] = array[num2, 0] * (double)number;
			if (array[num2, 0] < 0.005)
			{
				array[num2, 0] = Math.Round(1000.0 * array[num2, 0]) / 1000.0;
			}
			else
			{
				array[num2, 0] = Math.Round(100.0 * array[num2, 0]) / 100.0;
			}
			if (array[num2, 5] < 0.005)
			{
				array[num2, 5] = Math.Round(1000.0 * array[num2, 5]) / 1000.0;
			}
			else
			{
				array[num2, 5] = Math.Round(100.0 * array[num2, 5]) / 100.0;
			}
			priceProduct += array[num2, 0] * Consts2.hruntovkaHF.Price;
			num2++;
			materialName[num2] = Consts2.rozchynnyk647.MaterialName;
			array[num2, 0] = array[num2 - 1, 0] / 2.2;
			array[num2, 4] = array[num2, 0] * (double)number;
			if (array[num2, 0] < 0.005)
			{
				array[num2, 0] = Math.Round(1000.0 * array[num2, 0]) / 1000.0;
			}
			else
			{
				array[num2, 0] = Math.Round(100.0 * array[num2, 0]) / 100.0;
			}
			if (array[num2, 4] < 0.005)
			{
				array[num2, 4] = Math.Round(1000.0 * array[num2, 4]) / 1000.0;
			}
			else
			{
				array[num2, 4] = Math.Round(100.0 * array[num2, 4]) / 100.0;
			}
			priceProduct += array[num2, 0] * Consts2.rozchynnyk647.Price;
			if (D >= 200)
			{
				num2++;
				materialName[num2] = Consts2.dritObmidnenyj08.MaterialName;
				array[num2, 0] = (double)num6 * 0.03 * 5.0 / 2.0;
				array[num2, 5] = array[num2, 0] * (double)number;
				if (array[num2, 0] < 0.005)
				{
					array[num2, 0] = Math.Round(1000.0 * array[num2, 0]) / 1000.0;
				}
				else
				{
					array[num2, 0] = Math.Round(100.0 * array[num2, 0]) / 100.0;
				}
				if (array[num2, 5] < 0.005)
				{
					array[num2, 5] = Math.Round(1000.0 * array[num2, 5]) / 1000.0;
				}
				else
				{
					array[num2, 5] = Math.Round(100.0 * array[num2, 5]) / 100.0;
				}
				priceProduct += array[num2, 0] * Consts2.dritObmidnenyj08.Price;
			}
		}
		num2++;
		materialName[num2] = Consts2.klejSecunda.MaterialName;
		array[num2, 0] = 0.07;
		array[num2, 5] = array[num2, 0] * (double)number;
		priceProduct += array[num2, 0] * Consts2.klejSecunda.Price;
		num2++;
		materialName[num2] = Consts2.hnuchkaVstavka45_60_45.MaterialName;
		array[num2, 0] = (Math.PI * (double)D / 1000.0 + 0.1) * 1.025;
		array[num2, 1] = 0.025;
		array[num2, 4] = array[num2, 0] * (double)number;
		array[num2, 2] = array[num2, 4] * array[num2, 1];
		if (array[num2, 0] < 0.005)
		{
			array[num2, 0] = Math.Round(1000.0 * array[num2, 0]) / 1000.0;
		}
		else
		{
			array[num2, 0] = Math.Round(100.0 * array[num2, 0]) / 100.0;
		}
		if (array[num2, 2] < 0.005)
		{
			array[num2, 2] = Math.Round(1000.0 * array[num2, 2]) / 1000.0;
		}
		else
		{
			array[num2, 2] = Math.Round(100.0 * array[num2, 2]) / 100.0;
		}
		if (array[num2, 4] < 0.005)
		{
			array[num2, 4] = Math.Round(1000.0 * array[num2, 4]) / 1000.0;
		}
		else
		{
			array[num2, 4] = Math.Round(100.0 * array[num2, 4]) / 100.0;
		}
		priceProduct += array[num2, 0] * Consts2.hnuchkaVstavka45_60_45.Price;
		materialCost = priceProduct;
		priceProduct *= 3.0;
		return array;
	}

	public static double[,] FormPriceHnuchkaVstavkaVHK()
	{
		double[,] array = new double[24, 2];
		int[] array2 = new int[24]
		{
			100, 110, 125, 140, 160, 180, 200, 225, 250, 280,
			315, 355, 400, 450, 500, 560, 630, 710, 800, 900,
			1000, 1120, 1250, 1400
		};
		double[,] array3 = new double[6, 6];
		for (int i = 0; i < 24; i++)
		{
			array3 = MateriaHnuchkaVstavkaVHK(array2[i], 1, 3);
			array[i, 0] = priceProduct;
			array3 = MateriaHnuchkaVstavkaVHK(array2[i], 1, 1);
			array[i, 1] = priceProduct;
		}
		return array;
	}

	public static double VolumeHnuchkaVstavkaVHK(int D)
	{
		return Math.Round((double)D * (double)D * 150.0 / 1000000.0) / 1000.0;
	}
}
