using System;

namespace TEZ_Project.Common.Products;

public static class FlanetsKruglyj
{
	public static string[] materialName1 = new string[5] { "", "", "", "", "" };

	public static double materialCost1;

	public static double priceProduct1;

	public static double[,] MaterialFlanetsKruglyj(int D, int typMaterial, int number, int numberSides)
	{
		double[,] array = new double[5, 6];
		int num = -1;
		materialName1 = new string[5] { "", "", "", "", "" };
		if (typMaterial == 0)
		{
			typMaterial = ((D <= 200) ? 1 : ((D <= 800) ? 3 : 4));
		}
		priceProduct1 = 0.0;
		if (typMaterial == 1)
		{
			num++;
			materialName1[num] = Consts2.lystStalnyj30.MaterialName;
			array[num, 0] = ((double)D + 60.0) * (double)(D + 60) / 1000000.0;
			array[num, 1] = Math.PI * (double)((D + 50) * (D + 50) - D * D) / 4000000.0;
			array[num, 1] = Math.Round(100.0 * (array[num, 0] - array[num, 1]) / array[num, 0]) / 100.0;
			array[num, 0] *= 1.05;
			array[num, 4] = array[num, 0] * (double)number;
			double num2 = 3.0;
			array[num, 5] = array[num, 4] * 7825.0 * num2 / 1000.0;
			array[num, 2] = array[num, 4] * array[num, 1];
			array[num, 3] = array[num, 5] * array[num, 1];
			array[num, 0] *= numberSides;
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
			priceProduct1 += array[num, 0] * Consts2.lystStalnyj30.Price;
		}
		if (typMaterial == 2)
		{
			num++;
			materialName1[num] = Consts2.polosa30x4.MaterialName;
			array[num, 0] = Math.PI * (double)(D + 60) * 1.08 / 1000.0;
			array[num, 1] = 0.08;
			array[num, 4] = array[num, 0] * (double)number;
			double num3 = 4.0;
			array[num, 5] = array[num, 4] * 7825.0 * num3 * 0.03 / 1000.0;
			array[num, 2] = array[num, 4] * array[num, 1];
			array[num, 3] = array[num, 5] * array[num, 1];
			array[num, 0] *= numberSides;
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
			priceProduct1 += array[num, 0] * Consts2.polosa30x4.Price;
		}
		if (typMaterial == 3)
		{
			num++;
			materialName1[num] = Consts2.kutnyk25_25_4.MaterialName;
			array[num, 0] = Math.PI * (double)(D + 50) * 1.08 / 1000.0;
			array[num, 1] = 0.08;
			array[num, 4] = array[num, 0] * (double)number;
			array[num, 5] = array[num, 4] * 1.2;
			array[num, 2] = array[num, 4] * array[num, 1];
			array[num, 3] = array[num, 5] * array[num, 1];
			array[num, 0] *= numberSides;
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
			priceProduct1 += array[num, 0] * Consts2.kutnyk25_25_4.Price;
		}
		if (typMaterial == 4)
		{
			num++;
			materialName1[num] = Consts2.kutnyk32_32_3.MaterialName;
			array[num, 0] = Math.PI * (double)(D + 64) * 1.08 / 1000.0;
			array[num, 1] = 0.08;
			array[num, 4] = array[num, 0] * (double)number;
			array[num, 5] = array[num, 4] * 1.46;
			array[num, 2] = array[num, 4] * array[num, 1];
			array[num, 3] = array[num, 5] * array[num, 1];
			array[num, 0] *= numberSides;
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
			priceProduct1 += array[num, 0] * Consts2.kutnyk32_32_3.Price;
		}
		if (typMaterial == 5)
		{
			num++;
			materialName1[num] = Consts2.kutnyk35_35_4.MaterialName;
			array[num, 0] = Math.PI * (double)(D + 70) * 1.08 / 1000.0;
			array[num, 1] = 0.08;
			array[num, 4] = array[num, 0] * (double)number;
			array[num, 5] = array[num, 4] * 2.16;
			array[num, 2] = array[num, 4] * array[num, 1];
			array[num, 3] = array[num, 5] * array[num, 1];
			array[num, 0] *= numberSides;
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
			priceProduct1 += array[num, 0] * Consts2.kutnyk35_35_4.Price;
		}
		double num4 = ((D <= 200) ? (1.0 / 15.0) : ((D < 315) ? 0.1 : ((D <= 630) ? 0.2 : ((D < 800) ? 0.4 : ((D >= 1120) ? ((D < 1400) ? 0.8 : 1.0) : 0.6)))));
		if (num4 > 0.0)
		{
			num++;
			materialName1[num] = Consts2.hruntovkaHF.MaterialName;
			array[num, 0] = num4 * 0.8;
			array[num, 5] = array[num, 0] * (double)number;
			array[num, 0] *= numberSides;
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
			priceProduct1 += array[num, 0] * Consts2.hruntovkaHF.Price;
			num++;
			materialName1[num] = Consts2.rozchynnyk647.MaterialName;
			array[num, 0] = num4 * 0.5;
			array[num, 4] = array[num, 0] * (double)number;
			array[num, 0] *= numberSides;
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
			priceProduct1 += array[num, 0] * Consts2.rozchynnyk647.Price;
		}
		num4 = ((D > 200 && D < 315) ? 0.015 : ((D < 315 || D > 630) ? ((D > 630) ? 0.02 : 0.0) : 0.03));
		if (num4 > 0.0)
		{
			num++;
			materialName1[num] = Consts2.dritObmidnenyj08.MaterialName;
			array[num, 0] = num4 * 2.5;
			array[num, 5] = array[num, 0] * (double)number;
			array[num, 0] *= numberSides;
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
			priceProduct1 += array[num, 0] * Consts2.dritObmidnenyj08.Price;
		}
		materialCost1 = priceProduct1;
		priceProduct1 *= 3.0;
		return array;
	}

	public static double[] FormPriceFlanetsKruglyj()
	{
		double[] array = new double[24];
		int[] array2 = new int[24]
		{
			100, 110, 125, 140, 160, 180, 200, 225, 250, 280,
			315, 355, 400, 450, 500, 560, 630, 710, 800, 900,
			1000, 1120, 1250, 1400
		};
		double[,] array3 = new double[5, 6];
		for (int i = 0; i < 24; i++)
		{
			array3 = MaterialFlanetsKruglyj(array2[i], 0, 1, 1);
			array[i] = priceProduct1;
		}
		return array;
	}

	public static double VolumeFlanetsKruglyj(int D)
	{
		return Math.Round((double)D * (double)D * 35.0 / 4000000.0) / 1000.0;
	}
}
