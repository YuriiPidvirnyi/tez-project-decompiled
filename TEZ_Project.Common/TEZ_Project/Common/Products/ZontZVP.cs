using System;
using TEZ_Project.Common.Data;
using TEZ_Project.Common.Helpers;
using TEZ_Project;

namespace TEZ_Project.Common.Products;

public static class ZontZVP
{
	public static string[] materialName = new string[10] { "", "", "", "", "", "", "", "", "", "" };

	public static double materialCost;

	public static double[,] MaterialZontZVP(int B, int H, int B1, int H1, int markaStali, int typZVP, int typProfilBH, int number, int polkaBH, string aisiType = "430")
	{
		double[,] array = new double[10, 6];
		double num = 0.0;
		int num2 = ((B >= H) ? B : H);
		double num3 = 0.0;
		double num4 = 0.0;
		double num5 = 0.0;
		double num6 = 0.0;
		double num7 = 0.0;
		materialName = new string[10] { "", "", "", "", "", "", "", "", "", "" };
		materialCost = 0.0;
		switch (markaStali)
		{
		case 1:
			num = 7825.0;
			break;
		case 2:
			num = 7825.0;
			break;
		case 3:
			num = 7825.0;
			break;
		}
		double num8 = (double)B1 * Math.Sqrt(Math.Pow((double)B1 / 5.5, 2.0) + Math.Pow(0.5 * (double)H1, 2.0));
		num8 += (double)H1 * Math.Sqrt(Math.Pow((double)H1 / 5.5, 2.0) + Math.Pow(0.5 * (double)B1, 2.0));
		num8 += 20.0 * (double)(B + H);
		int num9 = ((num2 <= 150) ? 80 : ((num2 <= 250) ? 150 : ((num2 > 450) ? ((num2 <= 650) ? 300 : 350) : 250)));
		int num10 = ((H <= 300) ? 1 : ((H <= 650) ? 2 : 3));
		int num11 = ((B <= 300) ? 1 : ((B <= 650) ? 2 : 3));
		double num12 = 2.0 * (double)(num11 + num10) * (Math.Sqrt(Math.Pow(num9, 2.0) + Math.Pow(50.0, 2.0)) + 64.0) * 50.0;
		if (num2 >= 100 && num2 < 400)
		{
			num3 = num8;
		}
		else if (num2 <= 650)
		{
			num4 = num8;
		}
		else
		{
			num5 = num8 + num12;
		}
		num8 = 200.0 * (double)(B + H);
		if (num2 <= 400)
		{
			num3 += num8;
		}
		else if (num2 <= 800)
		{
			num4 += num8;
		}
		else
		{
			num5 += ((num5 > 0.0) ? num8 : (num8 + num12));
		}
		if (num5 == 0.0)
		{
			num5 = num12;
		}
		int num13 = 0;
		if (num3 > 0.0)
		{
			num6 = 0.5;
			switch (markaStali)
			{
			case 1:
				materialName[num13] = Consts2.lystOchynkovanyj05.MaterialName;
				num7 = Consts2.lystOchynkovanyj05.Price;
				break;
			case 2:
				materialName[num13] = Consts2.lystStalnyj05.MaterialName;
				num7 = Consts2.lystStalnyj05.Price;
				break;
			case 3:
			{
				CustomConst lystNerzavijuchyj = MaterialHelper.GetLystNerzavijuchyj(num6, aisiType);
				materialName[num13] = lystNerzavijuchyj?.MaterialName ?? "Лист НЕРЖ ??, м2";
				num7 = lystNerzavijuchyj.Price;
				break;
			}
			}
			array[num13, 0] = num3 * 1.05 / 1000000.0;
			array[num13, 1] = 0.05;
			if (array[num13, 0] < 0.005)
			{
				array[num13, 0] = Math.Round(1000.0 * array[num13, 0]) / 1000.0;
			}
			else
			{
				array[num13, 0] = Math.Round(100.0 * array[num13, 0]) / 100.0;
			}
			array[num13, 4] = array[num13, 0] * (double)number;
			array[num13, 5] = array[num13, 4] * num * num6 / 1000.0;
			array[num13, 2] = array[num13, 4] * array[num13, 1];
			array[num13, 3] = array[num13, 5] * array[num13, 1];
			materialCost = array[num13, 0] * num7;
			num13++;
		}
		if (num4 > 0.0)
		{
			switch (markaStali)
			{
			case 1:
				materialName[num13] = Consts2.lystOchynkovanyj07.MaterialName;
				num7 = Consts2.lystOchynkovanyj07.Price;
				num6 = 0.7;
				break;
			case 2:
				materialName[num13] = Consts2.lystStalnyj08.MaterialName;
				num7 = Consts2.lystStalnyj08.Price;
				num6 = 0.8;
				break;
			case 3:
			{
				num6 = 0.8;
				CustomConst lystNerzavijuchyj2 = MaterialHelper.GetLystNerzavijuchyj(num6, aisiType);
				materialName[num13] = lystNerzavijuchyj2?.MaterialName ?? "Лист НЕРЖ ??, м2";
				num7 = lystNerzavijuchyj2.Price;
				break;
			}
			}
			array[num13, 0] = num4 * 1.05 / 1000000.0;
			array[num13, 1] = 0.05;
			if (array[num13, 0] < 0.005)
			{
				array[num13, 0] = Math.Round(1000.0 * array[num13, 0]) / 1000.0;
			}
			else
			{
				array[num13, 0] = Math.Round(100.0 * array[num13, 0]) / 100.0;
			}
			array[num13, 4] = array[num13, 0] * (double)number;
			array[num13, 5] = array[num13, 4] * num * num6 / 1000.0;
			array[num13, 2] = array[num13, 4] * array[num13, 1];
			array[num13, 3] = array[num13, 5] * array[num13, 1];
			materialCost += array[num13, 0] * num7;
			num13++;
		}
		num6 = 1.0;
		switch (markaStali)
		{
		case 1:
			materialName[num13] = Consts2.lystOchynkovanyj10.MaterialName;
			num7 = Consts2.lystOchynkovanyj10.Price;
			break;
		case 2:
			materialName[num13] = Consts2.lystStalnyj10.MaterialName;
			num7 = Consts2.lystStalnyj10.Price;
			break;
		case 3:
		{
			CustomConst lystNerzavijuchyj3 = MaterialHelper.GetLystNerzavijuchyj(num6, aisiType);
			materialName[num13] = lystNerzavijuchyj3?.MaterialName ?? "Лист НЕРЖ ??, м2";
			num7 = lystNerzavijuchyj3.Price;
			break;
		}
		}
		array[num13, 0] = num5 * 1.05 / 1000000.0;
		array[num13, 1] = 0.05;
		if (array[num13, 0] < 0.005)
		{
			array[num13, 0] = Math.Round(1000.0 * array[num13, 0]) / 1000.0;
		}
		else
		{
			array[num13, 0] = Math.Round(100.0 * array[num13, 0]) / 100.0;
		}
		array[num13, 4] = array[num13, 0] * (double)number;
		array[num13, 5] = array[num13, 4] * num * num6 / 1000.0;
		array[num13, 2] = array[num13, 4] * array[num13, 1];
		array[num13, 3] = array[num13, 5] * array[num13, 1];
		materialCost += array[num13, 0] * num7;
		num13++;
		if (typZVP == 1)
		{
			if (typProfilBH == 0)
			{
				typProfilBH = ((num2 < 800) ? 1 : 2);
			}
			double[,] array2 = new double[2, 6];
			array2 = FlanetsPrjamokutnyj.MaterialFlanetsPrjamokutnyj(B, H, typProfilBH, number, polkaBH, 1);
			materialCost += FlanetsPrjamokutnyj.materialCost1;
			if (typProfilBH <= 2)
			{
				for (int i = 0; i < 2; i++)
				{
					if (FlanetsPrjamokutnyj.materialName[i] != "")
					{
						materialName[num13 + i] = FlanetsPrjamokutnyj.materialName[i];
						for (int j = 0; j < 6; j++)
						{
							array[num13 + i, j] = ((j == 1) ? array2[i, j] : (array[num13 + i, j] + array2[i, j]));
						}
					}
				}
				num13 += 2;
				double[,] array3 = new double[1, 6];
				array3 = HvyntNaFlanets.MaterialHvyntNaFlanets(B, H, 1, number);
				materialCost += HvyntNaFlanets.materialCost1;
				materialName[num13] = HvyntNaFlanets.materialName1[0];
				for (int k = 0; k < 6; k++)
				{
					array[num13, k] = array3[0, k];
				}
			}
			else if (FlanetsPrjamokutnyj.materialName[0] != "")
			{
				materialName[num13] = FlanetsPrjamokutnyj.materialName[0];
				for (int l = 0; l < 6; l++)
				{
					array[num13, l] = ((l == 1) ? array2[0, l] : (array[num13, l] + array2[0, l]));
				}
			}
		}
		return array;
	}

	public static double PriceZontZVP(int B, int H, int B1, int H1, int markaStali, int typZVP, int polkaBH)
	{
		double num = 1.0;
		double num2 = 0.0;
		int num3 = ((B >= H) ? B : H);
		double num4 = 0.0;
		double num5 = 0.0;
		double num6 = 0.0;
		double num7 = (double)B1 * Math.Sqrt(Math.Pow((double)B1 / 5.5, 2.0) + Math.Pow(0.5 * (double)H1, 2.0));
		num7 += (double)H1 * Math.Sqrt(Math.Pow((double)H1 / 5.5, 2.0) + Math.Pow(0.5 * (double)B1, 2.0));
		num7 += 20.0 * (double)(B + H);
		int num8 = ((num3 <= 150) ? 80 : ((num3 <= 250) ? 150 : ((num3 > 450) ? ((num3 <= 650) ? 300 : 350) : 250)));
		int num9 = ((H <= 300) ? 1 : ((H <= 650) ? 2 : 3));
		int num10 = ((B <= 300) ? 1 : ((B <= 650) ? 2 : 3));
		double num11 = 2.0 * (double)(num10 + num9) * (Math.Sqrt(Math.Pow(num8, 2.0) + Math.Pow(50.0, 2.0)) + 64.0) * 50.0;
		if (num3 >= 100 && num3 < 400)
		{
			num4 = num7;
		}
		else if (num3 <= 650)
		{
			num5 = num7;
		}
		else
		{
			num6 = num7 + num11;
		}
		num7 = 200.0 * (double)(B + H);
		if (num3 <= 400)
		{
			num4 += num7;
		}
		else if (num3 <= 800)
		{
			num5 += num7;
		}
		else
		{
			num6 += ((num6 > 0.0) ? num7 : (num7 + num11));
		}
		if (num6 == 0.0)
		{
			num6 = num11;
		}
		if (num4 > 0.0)
		{
			switch (markaStali)
			{
			case 1:
				num = ((typZVP == 0) ? 402.5 : 345.0);
				break;
			case 2:
				num = 115.0;
				break;
			case 3:
				num = 115.0;
				break;
			}
			num2 += num4 * num / 1000000.0;
		}
		if (num5 > 0.0)
		{
			switch (markaStali)
			{
			case 1:
				num = ((typZVP == 0) ? 464.0 : 406.0);
				break;
			case 2:
				num = 115.0;
				break;
			case 3:
				num = 134.78;
				break;
			}
			num2 += num5 * num / 1000000.0;
		}
		switch (markaStali)
		{
		case 1:
			num = ((typZVP == 0) ? 600.0 : 520.0);
			break;
		case 2:
			num = 134.78;
			break;
		case 3:
			num = 173.19;
			break;
		}
		return num2 + num6 * num / 1000000.0;
	}

	public static double VolumeZontZVP(int B, int H, int B1, int H1)
	{
		int num = ((B >= H) ? B : H);
		int num2 = ((num <= 150) ? 80 : ((num <= 250) ? 150 : ((num > 450) ? ((num <= 650) ? 300 : 350) : 250)));
		return Math.Round((double)B1 * (double)H1 * ((double)(100 + num2 + 10) + 0.5 * (double)B1 / 2.75) / 1000000.0) / 1000.0;
	}
}
