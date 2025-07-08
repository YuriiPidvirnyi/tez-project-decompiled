using System;

namespace TEZ_Project.Common.Products;

public static class FiltrFP
{
	public static string[] materialName = new string[11]
	{
		"", "", "", "", "", "", "", "", "", "",
		""
	};

	public static double materialCost;

	public static double priceProduct;

	public static double[] priceFiltrFP = new double[59];

	public static double[,] MaterialFiltrFP(int B, int H, int L, int number)
	{
		double[,] array = new double[11, 6];
		int num = -1;
		double num2 = ((B >= H) ? B : H);
		materialName = new string[11]
		{
			"", "", "", "", "", "", "", "", "", "",
			""
		};
		priceProduct = 0.0;
		materialCost = 0.0;
		num++;
		materialName[num] = Consts2.lystOchynkovanyj05.MaterialName;
		if (num2 <= 400.0)
		{
			array[num, 0] = ((double)B + (double)(2 * (H + 60))) * (double)L / 1000000.0;
		}
		if (B <= 400)
		{
			array[num, 0] += (2.0 * (double)(B + H) + 15.0) * 150.0 / 1000000.0;
		}
		if (H <= 400)
		{
			array[num, 0] += 200.0 * (double)H / 1000000.0;
		}
		array[num, 0] *= 1.1;
		array[num, 1] = 0.1;
		array[num, 4] = array[num, 0] * (double)number;
		array[num, 5] = array[num, 4] * 7825.0 * 0.5 / 1000.0;
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
		priceProduct = array[num, 0] * Consts2.lystOchynkovanyj05.Price;
		if (array[num, 0] == 0.0)
		{
			num--;
		}
		num++;
		materialName[num] = Consts2.lystOchynkovanyj07.MaterialName;
		if (num2 > 400.0 && num2 <= 800.0)
		{
			array[num, 0] = ((double)B + (double)(2 * (H + 60))) * (double)L / 1000000.0;
		}
		if (B > 400 && B <= 600)
		{
			array[num, 0] += (2.0 * (double)(B + H) + 15.0) * 150.0 / 1000000.0;
		}
		if (B > 600)
		{
			array[num, 0] += ((double)B + (double)(2 * H)) * 150.0 / 1000000.0;
		}
		if (H > 400)
		{
			array[num, 0] += 200.0 * (double)H / 1000000.0;
		}
		array[num, 0] *= 1.1;
		array[num, 1] = 0.1;
		array[num, 4] = array[num, 0] * (double)number;
		array[num, 5] = array[num, 4] * 7825.0 * 0.7 / 1000.0;
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
		priceProduct += array[num, 0] * Consts2.lystOchynkovanyj07.Price;
		if (array[num, 0] == 0.0)
		{
			num--;
		}
		num++;
		materialName[num] = Consts2.lystOchynkovanyj09.MaterialName;
		if (num2 > 800.0)
		{
			array[num, 0] = ((double)B + (double)(2 * (H + 60))) * (double)L / 1000000.0;
		}
		array[num, 0] += ((double)L + 40.0) * (double)(B + 60) / 1000000.0;
		if (B > 600)
		{
			array[num, 0] += ((double)B + 30.0) * 150.0 / 1000000.0;
		}
		array[num, 0] *= 1.1;
		array[num, 1] = 0.1;
		array[num, 4] = array[num, 0] * (double)number;
		array[num, 5] = array[num, 4] * 7825.0 * 0.9 / 1000.0;
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
		priceProduct += array[num, 0] * Consts2.lystOchynkovanyj09.Price;
		if (array[num, 0] == 0.0)
		{
			num--;
		}
		num++;
		if (num2 >= 710.0 && B + H > 1000)
		{
			materialName[num] = Consts2.profilS30.MaterialName;
			array[num, 0] = 2.0 * (2.0 * (double)(B + H) / 1000.0 - 0.14) * 1.05;
			array[num, 1] = 0.05;
			array[num, 4] = array[num, 0] * (double)number;
			array[num, 5] = array[num, 4] * 0.75;
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
			priceProduct += array[num, 0] * Consts2.profilS30.Price;
			num++;
			materialName[num] = Consts2.kutnykS30.MaterialName;
			array[num, 0] = 8.0;
			array[num, 4] = array[num, 0] * (double)number;
			priceProduct += array[num, 0] * Consts2.kutnykS30.Price;
		}
		else
		{
			materialName[num] = Consts2.profilS20.MaterialName;
			array[num, 0] = 2.0 * (2.0 * (double)(B + H) / 1000.0 - 0.12) * 1.03;
			array[num, 1] = 0.03;
			array[num, 4] = array[num, 0] * (double)number;
			array[num, 5] = array[num, 4] * 0.5;
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
			priceProduct += array[num, 0] * Consts2.profilS20.Price;
			num++;
			materialName[num] = Consts2.kutnykS20.MaterialName;
			array[num, 0] = 8.0;
			array[num, 4] = array[num, 0] * (double)number;
			priceProduct += array[num, 0] * Consts2.kutnykS20.Price;
		}
		num++;
		materialName[num] = Consts2.uschilnjuvachGumovyiD.MaterialName;
		array[num, 0] = 2.0 * (double)(2 * B + 300) / 1000.0;
		array[num, 0] *= 1.05;
		array[num, 1] = 0.05;
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
		priceProduct += array[num, 0] * Consts2.uschilnjuvachGumovyiD.Price;
		if (array[num, 0] == 0.0)
		{
			num--;
		}
		num++;
		materialName[num] = Consts2.sitka25x25.MaterialName;
		if (B == 200)
		{
			array[num, 0] = 275.0;
		}
		else if (B <= 250)
		{
			array[num, 0] = 315.0;
		}
		else if (B <= 300)
		{
			array[num, 0] = 355.0;
		}
		else if (B <= 350)
		{
			array[num, 0] = 455.0;
		}
		else if (B <= 400)
		{
			array[num, 0] = 495.0;
		}
		else if (B <= 450)
		{
			array[num, 0] = 500.0;
		}
		else if (B <= 500)
		{
			array[num, 0] = 635.0;
		}
		else if (B <= 550)
		{
			array[num, 0] = 675.0;
		}
		else if (B <= 600)
		{
			array[num, 0] = 775.0;
		}
		else if (B <= 650)
		{
			array[num, 0] = 815.0;
		}
		else if (B <= 700)
		{
			array[num, 0] = 855.0;
		}
		else if (B <= 750)
		{
			array[num, 0] = 955.0;
		}
		else if (B <= 800)
		{
			array[num, 0] = 995.0;
		}
		else if (B <= 850)
		{
			array[num, 0] = 1030.0;
		}
		else if (B <= 900)
		{
			array[num, 0] = 1135.0;
		}
		else if (B <= 950)
		{
			array[num, 0] = 1175.0;
		}
		else if (B <= 1000)
		{
			array[num, 0] = 1210.0;
		}
		array[num, 0] = 2.0 * (double)H * array[num, 0] / 1000000.0;
		array[num, 0] *= 1.05;
		array[num, 1] = 0.05;
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
		priceProduct += array[num, 0] * Consts2.sitka25x25.Price;
		if (array[num, 0] == 0.0)
		{
			num--;
		}
		num++;
		materialName[num] = Consts2.filtruvalnaTkanynaSyntepon.MaterialName;
		if (B == 200)
		{
			array[num, 0] = 275.0;
		}
		else if (B <= 250)
		{
			array[num, 0] = 315.0;
		}
		else if (B <= 300)
		{
			array[num, 0] = 355.0;
		}
		else if (B <= 350)
		{
			array[num, 0] = 455.0;
		}
		else if (B <= 400)
		{
			array[num, 0] = 495.0;
		}
		else if (B <= 450)
		{
			array[num, 0] = 500.0;
		}
		else if (B <= 500)
		{
			array[num, 0] = 635.0;
		}
		else if (B <= 550)
		{
			array[num, 0] = 675.0;
		}
		else if (B <= 600)
		{
			array[num, 0] = 775.0;
		}
		else if (B <= 650)
		{
			array[num, 0] = 815.0;
		}
		else if (B <= 700)
		{
			array[num, 0] = 855.0;
		}
		else if (B <= 750)
		{
			array[num, 0] = 955.0;
		}
		else if (B <= 800)
		{
			array[num, 0] = 995.0;
		}
		else if (B <= 850)
		{
			array[num, 0] = 1030.0;
		}
		else if (B <= 900)
		{
			array[num, 0] = 1135.0;
		}
		else if (B <= 950)
		{
			array[num, 0] = 1175.0;
		}
		else if (B <= 1000)
		{
			array[num, 0] = 1210.0;
		}
		array[num, 0] = (double)H * array[num, 0] / 1000000.0;
		array[num, 0] *= 1.05;
		array[num, 1] = 0.05;
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
		priceProduct += array[num, 0] * Consts2.filtruvalnaTkanynaSyntepon.Price;
		if (array[num, 0] == 0.0)
		{
			num--;
		}
		num++;
		materialName[num] = Consts2.zatyskach.MaterialName;
		array[num, 0] = 2.0;
		array[num, 4] = array[num, 0] * (double)number;
		priceProduct += array[num, 0] * Consts2.zatyskach.Price;
		num++;
		materialName[num] = Consts2.zaklepkaKombinov48.MaterialName;
		array[num, 0] = 8.0;
		array[num, 4] = array[num, 0] * (double)number;
		priceProduct += array[num, 0] * Consts2.zaklepkaKombinov48.Price;
		num++;
		materialName[num] = Consts2.hvynt9x11.MaterialName;
		array[num, 0] = 4.0;
		array[num, 4] = array[num, 0] * (double)number;
		priceProduct += array[num, 0] * Consts2.hvynt9x11.Price;
		materialCost = priceProduct;
		priceProduct *= 3.0;
		return array;
	}

	public static double VolumeFiltrFP(int B, int H, int L)
	{
		return Math.Round((double)B * (double)H * (double)L / 1000000.0) / 1000.0;
	}

	public static double[] FormPriceFiltrFP()
	{
		double[] array = new double[59];
		int[] array2 = new int[59]
		{
			200, 200, 250, 250, 250, 315, 315, 315, 315, 355,
			355, 355, 355, 400, 400, 400, 400, 400, 450, 450,
			450, 450, 450, 450, 500, 500, 500, 500, 500, 500,
			500, 560, 560, 560, 560, 560, 560, 630, 630, 630,
			630, 630, 630, 710, 710, 710, 710, 710, 800, 800,
			800, 800, 800, 900, 900, 900, 1000, 1000, 1000
		};
		int[] array3 = new int[59]
		{
			140, 200, 140, 200, 250, 140, 200, 250, 315, 200,
			250, 315, 355, 200, 250, 315, 355, 400, 200, 250,
			315, 355, 400, 450, 200, 250, 315, 355, 400, 450,
			500, 315, 355, 400, 450, 500, 560, 315, 400, 450,
			500, 560, 630, 400, 450, 500, 560, 630, 400, 450,
			500, 560, 630, 500, 560, 630, 500, 560, 630
		};
		for (int i = 0; i < 59; i++)
		{
			MaterialFiltrFP(array2[i], array3[i], 180, 1);
			array[i] = priceProduct;
		}
		return array;
	}
}
