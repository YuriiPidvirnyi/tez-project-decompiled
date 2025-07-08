using System;

namespace TEZ_Project.Common.Products;

public static class VuzolProhoduVP1
{
	public static string[] materialName = new string[10] { "", "", "", "", "", "", "", "", "", "" };

	public static double materialCost;

	public static double priceProduct;

	public static double[,] MaterialVuzolProhoduVP1(int D, int number)
	{
		double[,] array = new double[10, 6];
		int num = -1;
		materialName = new string[10] { "", "", "", "", "", "", "", "", "", "" };
		priceProduct = 0.0;
		materialCost = 0.0;
		double num2 = Math.PI * (double)D * 1.0 * 1.1 / 1000.0;
		double num3 = 0.0;
		double num4 = 0.0;
		double num5 = 0.0;
		double num6 = ((D <= 315) ? Math.Pow(0.54, 2.0) : ((D > 500) ? ((D <= 800) ? Math.Pow(1.14, 2.0) : Math.Pow(1.59, 2.0)) : Math.Pow(0.84, 2.0)));
		switch (D)
		{
		case 200:
			num3 += Math.Pow(0.25, 2.0) * 2.0 * 1.08;
			num6 += (540.0 - (double)D) * 190.0 * 4.0 / 2000000.0;
			break;
		case 250:
			num3 += Math.Pow(0.3, 2.0) * 2.0 * 1.08;
			num6 += (540.0 - (double)D) * 190.0 * 4.0 / 2000000.0;
			break;
		case 280:
			num3 += Math.Pow(0.33, 2.0) * 2.0 * 1.08;
			num6 += (540.0 - (double)D) * 190.0 * 4.0 / 2000000.0;
			break;
		case 315:
			num3 += Math.Pow(0.365, 2.0) * 2.0 * 1.08;
			num6 += (540.0 - (double)D) * 190.0 * 4.0 / 2000000.0;
			break;
		case 400:
			num6 += (840.0 - (double)D) * 190.0 * 6.0 / 2000000.0;
			num4 += Math.PI * (double)(D + 50) * 2.0 * 1.08 / 1000.0;
			break;
		case 450:
			num6 += (840.0 - (double)D) * 190.0 * 6.0 / 2000000.0;
			num4 += Math.PI * (double)(D + 50) * 2.0 * 1.08 / 1000.0;
			break;
		case 500:
			num6 += (840.0 - (double)D) * 190.0 * 6.0 / 2000000.0;
			num4 += Math.PI * (double)(D + 50) * 2.0 * 1.08 / 1000.0;
			break;
		case 630:
			num6 += (1140.0 - (double)D) * 190.0 * 6.0 / 2000000.0;
			num4 += Math.PI * (double)(D + 50) * 2.0 * 1.08 / 1000.0;
			break;
		case 710:
			num6 += (1140.0 - (double)D) * 190.0 * 6.0 / 2000000.0;
			num4 += Math.PI * (double)(D + 50) * 2.0 * 1.08 / 1000.0;
			break;
		case 800:
			num6 += (1140.0 - (double)D) * 190.0 * 6.0 / 2000000.0;
			num4 += Math.PI * (double)(D + 50) * 2.0 * 1.08 / 1000.0;
			break;
		case 1000:
			num6 += (1590.0 - (double)D) * 190.0 * 8.0 / 2000000.0;
			num5 += Math.PI * (double)(D + 70) * 2.0 * 1.08 / 1000.0;
			break;
		default:
			num6 += (1590.0 - (double)D) * 190.0 * 8.0 / 2000000.0;
			num5 += Math.PI * (double)(D + 70) * 2.0 * 1.08 / 1000.0;
			break;
		}
		double num7 = 0.0;
		if (num2 > 0.0)
		{
			num++;
			materialName[num] = Consts2.lystStalnyj20.MaterialName;
			array[num, 0] = num2;
			num7 += array[num, 0];
			array[num, 1] = 0.1;
			array[num, 4] = array[num, 0] * (double)number;
			array[num, 5] = array[num, 4] * 7825.0 * 2.0 / 1000.0;
			array[num, 2] = array[num, 4] * array[num, 1];
			array[num, 3] = array[num, 5] * array[num, 1];
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
			priceProduct += array[num, 0] * Consts2.lystStalnyj20.Price;
		}
		if (num3 > 0.0)
		{
			num++;
			materialName[num] = Consts2.lystStalnyj30.MaterialName;
			array[num, 0] = num3;
			num7 += array[num, 0];
			array[num, 1] = 0.1;
			array[num, 4] = array[num, 0] * (double)number;
			array[num, 5] = array[num, 4] * 7825.0 * 3.0 / 1000.0;
			array[num, 2] = array[num, 4] * array[num, 1];
			array[num, 3] = array[num, 5] * array[num, 1];
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
			priceProduct += array[num, 0] * Consts2.lystStalnyj30.Price;
		}
		if (num6 > 0.0)
		{
			num++;
			materialName[num] = Consts2.lystStalnyj50.MaterialName;
			array[num, 0] = num6;
			num7 += array[num, 0];
			array[num, 1] = 0.1;
			array[num, 4] = array[num, 0] * (double)number;
			array[num, 5] = array[num, 4] * 7825.0 * 5.0 / 1000.0;
			array[num, 2] = array[num, 4] * array[num, 1];
			array[num, 3] = array[num, 5] * array[num, 1];
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
			priceProduct += array[num, 0] * Consts2.lystStalnyj50.Price;
		}
		if (num4 > 0.0)
		{
			num++;
			materialName[num] = Consts2.kutnyk25_25_4.MaterialName;
			array[num, 0] = num4;
			array[num, 1] = 0.08;
			array[num, 4] = array[num, 0] * (double)number;
			array[num, 5] = array[num, 4] * 1.2;
			array[num, 2] = array[num, 4] * array[num, 1];
			array[num, 3] = array[num, 2] * 1.2;
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
			priceProduct += array[num, 0] * Consts2.kutnyk25_25_4.Price;
		}
		if (num5 > 0.0)
		{
			num++;
			materialName[num] = Consts2.kutnyk35_35_4.MaterialName;
			array[num, 0] = num5;
			array[num, 1] = 0.08;
			array[num, 4] = array[num, 0] * (double)number;
			array[num, 5] = array[num, 4] * 1.6;
			array[num, 2] = array[num, 4] * array[num, 1];
			array[num, 3] = array[num, 2] * 1.6;
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
			priceProduct += array[num, 0] * Consts2.kutnyk35_35_4.Price;
		}
		num++;
		materialName[num] = Consts2.dritObmidnenyj08.MaterialName;
		if (D <= 315)
		{
			array[num, 0] = 1.2;
		}
		else
		{
			array[num, 0] = ((D <= 800) ? 1.5 : 2.0);
		}
		array[num, 5] = array[num, 0] * (double)number;
		if (array[num, 0] < 0.005)
		{
			array[num, 0] = Math.Round(1000.0 * array[num, 0]) / 1000.0;
		}
		else
		{
			array[num, 0] = Math.Round(100.0 * array[num, 0]) / 100.0;
		}
		if (array[num, 5] < 0.005)
		{
			array[num, 5] = Math.Round(1000.0 * array[num, 5]) / 1000.0;
		}
		else
		{
			array[num, 5] = Math.Round(100.0 * array[num, 5]) / 100.0;
		}
		priceProduct += array[num, 0] * Consts2.dritObmidnenyj08.Price;
		num++;
		materialName[num] = Consts2.soplo60A.MaterialName;
		array[num, 0] = 1.0;
		array[num, 4] = array[num, 0] * (double)number;
		priceProduct += array[num, 0] * Consts2.soplo60A.Price;
		num++;
		materialName[num] = Consts2.electrod40_80A.MaterialName;
		array[num, 0] = 1.0;
		array[num, 4] = array[num, 0] * (double)number;
		priceProduct += array[num, 0] * Consts2.electrod40_80A.Price;
		num++;
		materialName[num] = Consts2.hruntovkaHF.MaterialName;
		array[num, 0] = num7 * 0.25;
		array[num, 5] = array[num, 0] * (double)number;
		if (array[num, 0] < 0.005)
		{
			array[num, 0] = Math.Round(1000.0 * array[num, 0]) / 1000.0;
		}
		else
		{
			array[num, 0] = Math.Round(100.0 * array[num, 0]) / 100.0;
		}
		if (array[num, 5] < 0.005)
		{
			array[num, 5] = Math.Round(1000.0 * array[num, 5]) / 1000.0;
		}
		else
		{
			array[num, 5] = Math.Round(100.0 * array[num, 5]) / 100.0;
		}
		priceProduct += array[num, 0] * Consts2.hruntovkaHF.Price;
		num++;
		materialName[num] = Consts2.rozchynnyk647.MaterialName;
		array[num, 0] = array[num - 1, 0] * 0.7;
		array[num, 4] = array[num, 0] * (double)number;
		if (array[num, 0] < 0.005)
		{
			array[num, 0] = Math.Round(1000.0 * array[num, 0]) / 1000.0;
		}
		else
		{
			array[num, 0] = Math.Round(100.0 * array[num, 0]) / 100.0;
		}
		if (array[num, 4] < 0.005)
		{
			array[num, 4] = Math.Round(1000.0 * array[num, 4]) / 1000.0;
		}
		else
		{
			array[num, 4] = Math.Round(100.0 * array[num, 4]) / 100.0;
		}
		priceProduct += array[num, 0] * Consts2.rozchynnyk647.Price;
		materialCost = priceProduct;
		priceProduct *= 3.0;
		return array;
	}

	public static double VolumeVuzolProhoduVP1(int D)
	{
		int num = ((D <= 315) ? 540 : ((D > 500) ? ((D <= 800) ? 1140 : 1590) : 840));
		return Math.Round((double)num * (double)num * 1000.0 / 1000000.0) / 1000.0;
	}
}
