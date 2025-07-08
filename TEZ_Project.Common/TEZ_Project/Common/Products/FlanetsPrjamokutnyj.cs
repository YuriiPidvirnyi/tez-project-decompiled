using System;

namespace TEZ_Project.Common.Products;

public static class FlanetsPrjamokutnyj
{
	public static string[] materialName = new string[2] { "", "" };

	public static double materialCost1;

	public static double priceProduct;

	public static double[,] MaterialFlanetsPrjamokutnyj(int B, int H, int typProfilBH, int number, int polka, int flanetsNumber)
	{
		double[,] array = new double[2, 6];
		materialName = new string[2] { "", "" };
		if (typProfilBH == 0)
		{
			int num = ((B >= H) ? B : H);
			typProfilBH = ((num < 800) ? 1 : 2);
		}
		if (typProfilBH <= 2)
		{
			double num2 = 2.0 * (double)(B + H) / 1000.0 - 0.12;
			double num3;
			double num4;
			if (typProfilBH == 1)
			{
				materialName[0] = Consts2.profilS20.MaterialName;
				materialName[1] = Consts2.kutnykS20.MaterialName;
				num3 = 3.0;
				num4 = 0.5;
				priceProduct = num2 * Consts2.profilS20.Price + 4.0 * Consts2.kutnykS20.Price;
			}
			else
			{
				materialName[0] = Consts2.profilS30.MaterialName;
				materialName[1] = Consts2.kutnykS30.MaterialName;
				num3 = 5.0;
				num4 = 0.75;
				priceProduct = num2 * Consts2.profilS30.Price + 4.0 * Consts2.kutnykS30.Price;
			}
			array[0, 0] = num2 * (1.0 + num3 / 100.0) * (double)flanetsNumber;
			array[1, 0] = 4 * flanetsNumber;
			if (array[0, 0] < 0.005)
			{
				array[0, 0] = Math.Round(1000.0 * array[0, 0]) / 1000.0;
			}
			else
			{
				array[0, 0] = Math.Round(100.0 * array[0, 0]) / 100.0;
			}
			array[0, 1] = num3 / 100.0;
			array[0, 4] = array[0, 0] * (double)number;
			array[0, 5] = array[0, 4] * num4;
			array[0, 2] = array[0, 4] * array[0, 1];
			array[0, 3] = array[0, 5] * array[0, 1];
			array[1, 4] = array[1, 0] * (double)number;
		}
		else if (typProfilBH == 3)
		{
			materialName[0] = Consts2.lystStalnyj30.MaterialName;
			double num3 = 5.0;
			double num2 = 2.0 * (double)(B + H + 2 * polka) * (double)polka / 1000000.0;
			array[0, 0] = num2 * (1.0 + num3 / 100.0) * (double)flanetsNumber;
			if (array[0, 0] < 0.005)
			{
				array[0, 0] = Math.Round(1000.0 * array[0, 0]) / 1000.0;
			}
			else
			{
				array[0, 0] = Math.Round(100.0 * array[0, 0]) / 100.0;
			}
			array[0, 1] = num3 / 100.0;
			array[0, 4] = array[0, 0] * (double)number;
			array[0, 5] = array[0, 4] * 7825.0 * 3.0 / 1000.0;
			array[0, 2] = array[0, 4] * array[0, 1];
			array[0, 3] = array[0, 5] * array[0, 1];
			priceProduct += array[0, 0] * Consts2.lystStalnyj30.Price;
		}
		else
		{
			double price;
			int num5;
			switch (polka)
			{
			case 25:
				materialName[0] = Consts2.kutnyk25_25_4.MaterialName;
				price = Consts2.kutnyk25_25_4.Price;
				num5 = 4;
				break;
			case 32:
				materialName[0] = Consts2.kutnyk32_32_3.MaterialName;
				price = Consts2.kutnyk32_32_3.Price;
				num5 = 3;
				break;
			case 35:
				materialName[0] = Consts2.kutnyk35_35_4.MaterialName;
				price = Consts2.kutnyk35_35_4.Price;
				num5 = 4;
				break;
			case 40:
				materialName[0] = Consts2.kutnyk40_40_3.MaterialName;
				price = Consts2.kutnyk40_40_3.Price;
				num5 = 3;
				break;
			case 45:
				materialName[0] = Consts2.kutnyk45_45_4.MaterialName;
				price = Consts2.kutnyk45_45_4.Price;
				num5 = 4;
				break;
			case 50:
				materialName[0] = Consts2.kutnyk50_50_4.MaterialName;
				price = Consts2.kutnyk50_50_4.Price;
				num5 = 4;
				break;
			default:
				materialName[0] = Consts2.kutnyk63_63_4.MaterialName;
				price = Consts2.kutnyk63_63_4.Price;
				num5 = 4;
				break;
			}
			double num3 = 5.0;
			double num2 = 2.0 * (double)(B + H + 2 * polka) / 1000.0;
			array[0, 0] = num2 * (1.0 + num3 / 100.0) * (double)flanetsNumber;
			if (array[0, 0] < 0.005)
			{
				array[0, 0] = Math.Round(1000.0 * array[0, 0]) / 1000.0;
			}
			else
			{
				array[0, 0] = Math.Round(100.0 * array[0, 0]) / 100.0;
			}
			array[0, 1] = num3 / 100.0;
			array[0, 4] = array[0, 0] * (double)number;
			array[0, 5] = 2.0 * array[0, 4] * 7825.0 * (double)polka * (double)num5 / 1000000.0;
			array[0, 2] = array[0, 4] * array[0, 1];
			array[0, 3] = array[0, 5] * array[0, 1];
			priceProduct += array[0, 0] * price;
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
		materialCost1 = priceProduct;
		priceProduct *= 3.0;
		return array;
	}

	public static double VolumeFlanetsPrjamokutnyj(int B, int H)
	{
		return Math.Round((double)B * (double)H * 35.0 / 1000000.0) / 1000.0;
	}
}
