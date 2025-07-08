using System;
using TEZ_Project.Common.Helpers;
using TEZ_Project;

namespace TEZ_Project.Common.Products;

public static class KlapanDroselnyjKDP
{
	public static string[] materialName = new string[16]
	{
		"", "", "", "", "", "", "", "", "", "",
		"", "", "", "", "", ""
	};

	public static double materialCost;

	public static double priceProduct;

	public static double[] priceKlapanDroselnyjKDP = new double[11];

	public static double[,] MaterialKlapanDroselnyjKDP(int B, int H, int L, int number, int vydKDP, int servopryvid, int markaStali = 1, int vidbortovka = 0, string aisiType = "430", double tovchynaMetalu = 0.0)
	{
		double[,] array = new double[16, 6];
		int num = -1;
		double num2 = ((B >= H) ? B : H);
		double num3 = 0.0;
		markaStali = ((markaStali == 0) ? 1 : markaStali);
		materialName = new string[16]
		{
			"", "", "", "", "", "", "", "", "", "",
			"", "", "", "", "", ""
		};
		priceProduct = 0.0;
		materialCost = 0.0;
		if (L == 0)
		{
			L = 200;
		}
		L += vidbortovka;
		switch (vydKDP)
		{
		case 1:
			if (num2 <= 450.0)
			{
				num++;
				switch (markaStali)
				{
				case 1:
					materialName[num] = Consts2.lystOchynkovanyj05.MaterialName;
					num3 = Consts2.lystOchynkovanyj05.Price;
					break;
				case 2:
					materialName[num] = Consts2.lystStalnyj05.MaterialName;
					num3 = Consts2.lystStalnyj05.Price;
					break;
				default:
				{
					CustomConst lystNerzavijuchyj8 = MaterialHelper.GetLystNerzavijuchyj(0.5, aisiType);
					materialName[num] = lystNerzavijuchyj8?.MaterialName ?? "Лист НЕРЖ ??, м2";
					num3 = lystNerzavijuchyj8.Price;
					break;
				}
				}
				if (L == 0)
				{
					L = 200;
				}
				array[num, 0] = (2.0 * (double)(B + H) / 1000.0 + 0.01) * (double)L / 1000.0;
				if (num2 <= 300.0)
				{
					array[num, 0] += (double)B * (double)H / 1000000.0;
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
				priceProduct = array[num, 0] * num3;
				num++;
				switch (markaStali)
				{
				case 1:
					materialName[num] = Consts2.lystOchynkovanyj09.MaterialName;
					num3 = Consts2.lystOchynkovanyj09.Price;
					break;
				case 2:
					materialName[num] = Consts2.lystStalnyj08.MaterialName;
					num3 = Consts2.lystStalnyj08.Price;
					break;
				default:
				{
					CustomConst lystNerzavijuchyj9 = MaterialHelper.GetLystNerzavijuchyj(0.8, aisiType);
					materialName[num] = lystNerzavijuchyj9?.MaterialName ?? "Лист НЕРЖ ??, м2";
					num3 = lystNerzavijuchyj9.Price;
					break;
				}
				}
				array[num, 0] = ((num2 > 300.0) ? ((double)B * (double)H / 1000000.0) : 0.0);
				array[num, 0] += 0.05 * (double)B / 1000.0 + 0.0188;
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
				priceProduct += array[num, 0] * num3;
				num++;
				array[num, 0] = 0.01;
				array[num, 4] = array[num, 0] * (double)number;
				if (num2 <= 300.0)
				{
					materialName[num] = Consts2.lystOchynkovanyj15.MaterialName;
					array[num, 5] = array[num, 4] * 7825.0 * 1.5 / 1000.0;
					priceProduct += array[num, 0] * Consts2.lystOchynkovanyj15.Price;
				}
				else
				{
					materialName[num] = Consts2.lystStalnyj20.MaterialName;
					array[num, 5] = array[num, 4] * 7825.0 * 2.0 / 1000.0;
					priceProduct += array[num, 0] * Consts2.lystStalnyj20.Price;
				}
				num++;
				materialName[num] = Consts2.profilS20.MaterialName;
				if (num2 >= 710.0)
				{
					array[num, 0] = ((B + H > 1000) ? (2.1 * (2.0 * (double)(B + H) / 1000.0 - 0.14)) : (2.06 * (2.0 * (double)(B + H) / 1000.0 - 0.12)));
				}
				else
				{
					array[num, 0] = 2.06 * (2.0 * (double)(B + H) / 1000.0 - 0.12);
				}
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
				num++;
				materialName[num] = Consts2.kvadrat10.MaterialName;
				array[num, 0] = (double)(B + 65) / 1000.0 * 1.03;
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
				priceProduct += array[num, 0] * Consts2.kvadrat10.Price;
				num++;
				materialName[num] = Consts2.boltM6_20.MaterialName;
				array[num, 0] = 1.0;
				array[num, 4] = array[num, 0] * (double)number;
				priceProduct += array[num, 0] * Consts2.boltM6_20.Price;
				num++;
				materialName[num] = Consts2.boltM6_12.MaterialName;
				array[num, 0] = 1.0;
				array[num, 4] = array[num, 0] * (double)number;
				priceProduct += array[num, 0] * Consts2.boltM6_12.Price;
				num++;
				materialName[num] = Consts2.boltM8_35.MaterialName;
				array[num, 0] = 1.0;
				array[num, 4] = array[num, 0] * (double)number;
				priceProduct += array[num, 0] * Consts2.boltM8_35.Price;
				num++;
				materialName[num] = Consts2.hajkaM6_Metelyk.MaterialName;
				array[num, 0] = 1.0;
				array[num, 4] = array[num, 0] * (double)number;
				priceProduct += array[num, 0] * Consts2.hajkaM6_Metelyk.Price;
				num++;
				materialName[num] = Consts2.hajkaM8.MaterialName;
				array[num, 0] = 1.0;
				array[num, 4] = array[num, 0] * (double)number;
				priceProduct += array[num, 0] * Consts2.hajkaM8.Price;
				num++;
				materialName[num] = Consts2.shajba_8.MaterialName;
				array[num, 0] = 5.0;
				array[num, 4] = array[num, 0] * (double)number;
				priceProduct += array[num, 0] * Consts2.shajba_8.Price;
				num++;
				materialName[num] = Consts2.polipropilen.MaterialName;
				array[num, 0] = 0.01;
				array[num, 1] = 0.05;
				array[num, 5] = array[num, 0] * (double)number;
				array[num, 3] = array[num, 5] * array[num, 1];
				priceProduct += array[num, 0] * Consts2.polipropilen.Price;
			}
			else if (num2 <= 600.0)
			{
				num++;
				switch (markaStali)
				{
				case 1:
					materialName[num] = Consts2.lystOchynkovanyj07.MaterialName;
					num3 = Consts2.lystOchynkovanyj07.Price;
					break;
				case 2:
					materialName[num] = Consts2.lystStalnyj08.MaterialName;
					num3 = Consts2.lystStalnyj08.Price;
					break;
				default:
				{
					CustomConst lystNerzavijuchyj10 = MaterialHelper.GetLystNerzavijuchyj(0.8, aisiType);
					materialName[num] = lystNerzavijuchyj10?.MaterialName ?? "Лист НЕРЖ ??, м2";
					num3 = lystNerzavijuchyj10.Price;
					break;
				}
				}
				if (L == 0)
				{
					L = 250;
				}
				array[num, 0] = (2.0 * (double)(B + H) / 1000.0 + 0.01) * (double)L / 1000.0 * 1.1;
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
				priceProduct = array[num, 0] * num3;
				num++;
				switch (markaStali)
				{
				case 1:
					materialName[num] = Consts2.lystOchynkovanyj09.MaterialName;
					num3 = Consts2.lystOchynkovanyj09.Price;
					break;
				case 2:
					materialName[num] = Consts2.lystStalnyj08.MaterialName;
					num3 = Consts2.lystStalnyj08.Price;
					break;
				default:
				{
					CustomConst lystNerzavijuchyj11 = MaterialHelper.GetLystNerzavijuchyj(0.8, aisiType);
					materialName[num] = lystNerzavijuchyj11?.MaterialName ?? "Лист НЕРЖ ??, м2";
					num3 = lystNerzavijuchyj11.Price;
					break;
				}
				}
				array[num, 0] = ((double)B * (double)H / 1000000.0 + 0.05 * (double)B / 1000.0 + 0.0188) * 1.1;
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
				priceProduct += array[num, 0] * num3;
				num++;
				materialName[num] = Consts2.lystStalnyj20.MaterialName;
				array[num, 0] = 0.01;
				array[num, 4] = array[num, 0] * (double)number;
				array[num, 5] = array[num, 4] * 7825.0 * 2.0 / 1000.0;
				priceProduct += array[num, 0] * Consts2.lystStalnyj20.Price;
				num++;
				materialName[num] = Consts2.profilS20.MaterialName;
				if (num2 >= 710.0)
				{
					array[num, 0] = ((B + H > 1000) ? (2.1 * (2.0 * (double)(B + H) / 1000.0 - 0.14)) : (2.06 * (2.0 * (double)(B + H) / 1000.0 - 0.12)));
				}
				else
				{
					array[num, 0] = 2.06 * (2.0 * (double)(B + H) / 1000.0 - 0.12);
				}
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
				num++;
				materialName[num] = Consts2.kvadrat10.MaterialName;
				array[num, 0] = (double)(B + 65) / 1000.0 * 1.03;
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
				priceProduct += array[num, 0] * Consts2.kvadrat10.Price;
				num++;
				materialName[num] = Consts2.boltM6_20.MaterialName;
				array[num, 0] = 1.0;
				array[num, 4] = array[num, 0] * (double)number;
				priceProduct += array[num, 0] * Consts2.boltM6_20.Price;
				num++;
				materialName[num] = Consts2.boltM6_12.MaterialName;
				array[num, 0] = 1.0;
				array[num, 4] = array[num, 0] * (double)number;
				priceProduct += array[num, 0] * Consts2.boltM6_12.Price;
				num++;
				materialName[num] = Consts2.boltM8_35.MaterialName;
				array[num, 0] = 1.0;
				array[num, 4] = array[num, 0] * (double)number;
				priceProduct += array[num, 0] * Consts2.boltM8_35.Price;
				num++;
				materialName[num] = Consts2.hajkaM6_Metelyk.MaterialName;
				array[num, 0] = 1.0;
				array[num, 4] = array[num, 0] * (double)number;
				priceProduct += array[num, 0] * Consts2.hajkaM6_Metelyk.Price;
				num++;
				materialName[num] = Consts2.hajkaM8.MaterialName;
				array[num, 0] = 1.0;
				array[num, 4] = array[num, 0] * (double)number;
				priceProduct += array[num, 0] * Consts2.hajkaM8.Price;
				num++;
				materialName[num] = Consts2.shajba_8.MaterialName;
				array[num, 0] = 5.0;
				array[num, 4] = array[num, 0] * (double)number;
				priceProduct += array[num, 0] * Consts2.shajba_8.Price;
				num++;
				materialName[num] = Consts2.polipropilen.MaterialName;
				array[num, 0] = 0.01;
				array[num, 1] = 0.05;
				array[num, 5] = array[num, 0] * (double)number;
				array[num, 3] = array[num, 5] * array[num, 1];
				priceProduct += array[num, 0] * Consts2.polipropilen.Price;
			}
			else if (num2 <= 800.0)
			{
				num++;
				switch (markaStali)
				{
				case 1:
					materialName[num] = Consts2.lystOchynkovanyj07.MaterialName;
					num3 = Consts2.lystOchynkovanyj07.Price;
					break;
				case 2:
					materialName[num] = Consts2.lystStalnyj08.MaterialName;
					num3 = Consts2.lystStalnyj08.Price;
					break;
				default:
				{
					CustomConst lystNerzavijuchyj12 = MaterialHelper.GetLystNerzavijuchyj(0.8, aisiType);
					materialName[num] = lystNerzavijuchyj12?.MaterialName ?? "Лист НЕРЖ ??, м2";
					num3 = lystNerzavijuchyj12.Price;
					break;
				}
				}
				if (L == 0)
				{
					L = 300;
				}
				array[num, 0] = (2.0 * (double)(B + H) / 1000.0 + 0.01) * (double)L / 1000.0 * 1.1;
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
				priceProduct = array[num, 0] * num3;
				num++;
				switch (markaStali)
				{
				case 1:
					materialName[num] = Consts2.lystOchynkovanyj09.MaterialName;
					num3 = Consts2.lystOchynkovanyj09.Price;
					break;
				case 2:
					materialName[num] = Consts2.lystStalnyj08.MaterialName;
					num3 = Consts2.lystStalnyj08.Price;
					break;
				default:
				{
					CustomConst lystNerzavijuchyj13 = MaterialHelper.GetLystNerzavijuchyj(0.8, aisiType);
					materialName[num] = lystNerzavijuchyj13?.MaterialName ?? "Лист НЕРЖ ??, м2";
					num3 = lystNerzavijuchyj13.Price;
					break;
				}
				}
				array[num, 0] = ((double)B * (double)H / 1000000.0 + 0.05 * (double)B / 1000.0 + 0.0188) * 1.1;
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
				priceProduct += array[num, 0] * num3;
				num++;
				materialName[num] = Consts2.lystStalnyj20.MaterialName;
				array[num, 0] = 0.01;
				array[num, 4] = array[num, 0] * (double)number;
				array[num, 5] = array[num, 4] * 7825.0 * 2.0 / 1000.0;
				priceProduct += array[num, 0] * Consts2.lystStalnyj20.Price;
				num++;
				materialName[num] = Consts2.profilS20.MaterialName;
				if (num2 >= 710.0)
				{
					array[num, 0] = ((B + H > 1000) ? (2.1 * (2.0 * (double)(B + H) / 1000.0 - 0.14)) : (2.06 * (2.0 * (double)(B + H) / 1000.0 - 0.12)));
				}
				else
				{
					array[num, 0] = 2.06 * (2.0 * (double)(B + H) / 1000.0 - 0.12);
				}
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
				num++;
				materialName[num] = Consts2.kvadrat10.MaterialName;
				array[num, 0] = (double)(B + 65) / 1000.0 * 1.03;
				array[num, 4] = array[num, 0] * (double)number;
				priceProduct += array[num, 0] * Consts2.kvadrat10.Price;
				num++;
				materialName[num] = Consts2.boltM6_20.MaterialName;
				array[num, 0] = 1.0;
				array[num, 4] = array[num, 0] * (double)number;
				priceProduct += array[num, 0] * Consts2.boltM6_20.Price;
				num++;
				materialName[num] = Consts2.boltM6_12.MaterialName;
				array[num, 0] = 1.0;
				array[num, 4] = array[num, 0] * (double)number;
				priceProduct += array[num, 0] * Consts2.boltM6_12.Price;
				num++;
				materialName[num] = Consts2.boltM8_35.MaterialName;
				array[num, 0] = 1.0;
				array[num, 4] = array[num, 0] * (double)number;
				priceProduct += array[num, 0] * Consts2.boltM8_35.Price;
				num++;
				materialName[num] = Consts2.hajkaM6_Metelyk.MaterialName;
				array[num, 0] = 1.0;
				array[num, 4] = array[num, 0] * (double)number;
				priceProduct += array[num, 0] * Consts2.hajkaM6_Metelyk.Price;
				num++;
				materialName[num] = Consts2.hajkaM8.MaterialName;
				array[num, 0] = 1.0;
				array[num, 4] = array[num, 0] * (double)number;
				priceProduct += array[num, 0] * Consts2.hajkaM8.Price;
				num++;
				materialName[num] = Consts2.shajba_8.MaterialName;
				array[num, 0] = 5.0;
				array[num, 4] = array[num, 0] * (double)number;
				priceProduct += array[num, 0] * Consts2.shajba_8.Price;
				num++;
				materialName[num] = Consts2.polipropilen.MaterialName;
				array[num, 0] = 0.01;
				array[num, 1] = 0.05;
				array[num, 5] = array[num, 0] * (double)number;
				array[num, 3] = array[num, 5] * array[num, 1];
				priceProduct += array[num, 0] * Consts2.polipropilen.Price;
			}
			break;
		case 2:
			if (num2 <= 450.0)
			{
				num++;
				switch (markaStali)
				{
				case 1:
					materialName[num] = Consts2.lystOchynkovanyj05.MaterialName;
					num3 = Consts2.lystOchynkovanyj05.Price;
					break;
				case 2:
					materialName[num] = Consts2.lystStalnyj05.MaterialName;
					num3 = Consts2.lystStalnyj05.Price;
					break;
				default:
				{
					CustomConst lystNerzavijuchyj14 = MaterialHelper.GetLystNerzavijuchyj(0.5, aisiType);
					materialName[num] = lystNerzavijuchyj14?.MaterialName ?? "Лист НЕРЖ ??, м2";
					num3 = lystNerzavijuchyj14.Price;
					break;
				}
				}
				if (L == 0)
				{
					L = 200;
				}
				array[num, 0] = (2.0 * (double)(B + H) / 1000.0 + 0.01) * (double)L / 1000.0 * 1.1;
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
				priceProduct = array[num, 0] * num3;
				num++;
				switch (markaStali)
				{
				case 1:
					materialName[num] = Consts2.lystOchynkovanyj07.MaterialName;
					num3 = Consts2.lystOchynkovanyj07.Price;
					break;
				case 2:
					materialName[num] = Consts2.lystStalnyj08.MaterialName;
					num3 = Consts2.lystStalnyj08.Price;
					break;
				default:
				{
					CustomConst lystNerzavijuchyj15 = MaterialHelper.GetLystNerzavijuchyj(0.8, aisiType);
					materialName[num] = lystNerzavijuchyj15?.MaterialName ?? "Лист НЕРЖ ??, м2";
					num3 = lystNerzavijuchyj15.Price;
					break;
				}
				}
				array[num, 0] = 0.039270000000000006;
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
				priceProduct += array[num, 0] * num3;
				num++;
				switch (markaStali)
				{
				case 1:
					materialName[num] = Consts2.lystOchynkovanyj09.MaterialName;
					num3 = Consts2.lystOchynkovanyj09.Price;
					break;
				case 2:
					materialName[num] = Consts2.lystStalnyj08.MaterialName;
					num3 = Consts2.lystStalnyj08.Price;
					break;
				default:
				{
					CustomConst lystNerzavijuchyj16 = MaterialHelper.GetLystNerzavijuchyj(0.8, aisiType);
					materialName[num] = lystNerzavijuchyj16?.MaterialName ?? "Лист НЕРЖ ??, м2";
					num3 = lystNerzavijuchyj16.Price;
					break;
				}
				}
				array[num, 0] = ((num2 > 300.0) ? ((double)B * (double)H / 1000000.0) : 0.0);
				array[num, 0] += 0.05 * (double)B / 1000.0;
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
				priceProduct += array[num, 0] * num3;
				num++;
				materialName[num] = Consts2.profilS20.MaterialName;
				if (num2 >= 710.0)
				{
					array[num, 0] = ((B + H > 1000) ? (2.1 * (2.0 * (double)(B + H) / 1000.0 - 0.14)) : (2.06 * (2.0 * (double)(B + H) / 1000.0 - 0.12)));
				}
				else
				{
					array[num, 0] = 2.06 * (2.0 * (double)(B + H) / 1000.0 - 0.12);
				}
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
				num++;
				materialName[num] = Consts2.kvadrat10.MaterialName;
				array[num, 0] = (double)(B + 130) / 1000.0 * 1.03;
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
				priceProduct += array[num, 0] * Consts2.kvadrat10.Price;
				num++;
				materialName[num] = Consts2.polipropilen.MaterialName;
				array[num, 0] = 0.01;
				array[num, 1] = 0.05;
				array[num, 5] = array[num, 0] * (double)number;
				array[num, 3] = array[num, 5] * array[num, 1];
				priceProduct += array[num, 0] * Consts2.polipropilen.Price;
			}
			else if (num2 <= 600.0)
			{
				num++;
				switch (markaStali)
				{
				case 1:
					materialName[num] = Consts2.lystOchynkovanyj07.MaterialName;
					num3 = Consts2.lystOchynkovanyj07.Price;
					break;
				case 2:
					materialName[num] = Consts2.lystStalnyj08.MaterialName;
					num3 = Consts2.lystStalnyj08.Price;
					break;
				default:
				{
					CustomConst lystNerzavijuchyj17 = MaterialHelper.GetLystNerzavijuchyj(0.8, aisiType);
					materialName[num] = lystNerzavijuchyj17?.MaterialName ?? "Лист НЕРЖ ??, м2";
					num3 = lystNerzavijuchyj17.Price;
					break;
				}
				}
				if (L == 0)
				{
					L = 250;
				}
				array[num, 0] = (2.0 * (double)(B + H) * (double)L / 1000000.0 + 0.01 + 0.0357) * 1.1;
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
				priceProduct = array[num, 0] * num3;
				num++;
				switch (markaStali)
				{
				case 1:
					materialName[num] = Consts2.lystOchynkovanyj09.MaterialName;
					num3 = Consts2.lystOchynkovanyj09.Price;
					break;
				case 2:
					materialName[num] = Consts2.lystStalnyj08.MaterialName;
					num3 = Consts2.lystStalnyj08.Price;
					break;
				default:
				{
					CustomConst lystNerzavijuchyj18 = MaterialHelper.GetLystNerzavijuchyj(0.8, aisiType);
					materialName[num] = lystNerzavijuchyj18?.MaterialName ?? "Лист НЕРЖ ??, м2";
					num3 = lystNerzavijuchyj18.Price;
					break;
				}
				}
				array[num, 0] = ((double)B * (double)H / 1000000.0 + 0.05 * (double)B / 1000.0) * 1.1;
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
				priceProduct += array[num, 0] * num3;
				num++;
				materialName[num] = Consts2.profilS20.MaterialName;
				if (num2 >= 710.0)
				{
					array[num, 0] = ((B + H > 1000) ? (2.1 * (2.0 * (double)(B + H) / 1000.0 - 0.14)) : (2.06 * (2.0 * (double)(B + H) / 1000.0 - 0.12)));
				}
				else
				{
					array[num, 0] = 2.06 * (2.0 * (double)(B + H) / 1000.0 - 0.12);
				}
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
				num++;
				materialName[num] = Consts2.kvadrat10.MaterialName;
				array[num, 0] = (double)(B + 130) / 1000.0 * 1.03;
				array[num, 4] = array[num, 0] * (double)number;
				priceProduct += array[num, 0] * Consts2.kvadrat10.Price;
				num++;
				materialName[num] = Consts2.polipropilen.MaterialName;
				array[num, 0] = 0.01;
				array[num, 1] = 0.05;
				array[num, 5] = array[num, 0] * (double)number;
				array[num, 3] = array[num, 5] * array[num, 1];
				priceProduct += array[num, 0] * Consts2.polipropilen.Price;
			}
			else if (num2 <= 800.0)
			{
				num++;
				switch (markaStali)
				{
				case 1:
					materialName[num] = Consts2.lystOchynkovanyj07.MaterialName;
					num3 = Consts2.lystOchynkovanyj07.Price;
					break;
				case 2:
					materialName[num] = Consts2.lystStalnyj08.MaterialName;
					num3 = Consts2.lystStalnyj08.Price;
					break;
				default:
				{
					CustomConst lystNerzavijuchyj19 = MaterialHelper.GetLystNerzavijuchyj(0.8, aisiType);
					materialName[num] = lystNerzavijuchyj19?.MaterialName ?? "Лист НЕРЖ ??, м2";
					num3 = lystNerzavijuchyj19.Price;
					break;
				}
				}
				if (L == 0)
				{
					L = 300;
				}
				array[num, 0] = (2.0 * (double)(B + H) * (double)L / 1000000.0 + 0.01 + 0.0357) * 1.1;
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
				priceProduct = array[num, 0] * num3;
				num++;
				switch (markaStali)
				{
				case 1:
					materialName[num] = Consts2.lystOchynkovanyj09.MaterialName;
					num3 = Consts2.lystOchynkovanyj09.Price;
					break;
				case 2:
					materialName[num] = Consts2.lystStalnyj08.MaterialName;
					num3 = Consts2.lystStalnyj08.Price;
					break;
				default:
				{
					CustomConst lystNerzavijuchyj20 = MaterialHelper.GetLystNerzavijuchyj(0.8, aisiType);
					materialName[num] = lystNerzavijuchyj20?.MaterialName ?? "Лист НЕРЖ ??, м2";
					num3 = lystNerzavijuchyj20.Price;
					break;
				}
				}
				array[num, 0] = ((double)B * (double)H / 1000000.0 + 0.05 * (double)B / 1000.0) * 1.1;
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
				priceProduct += array[num, 0] * num3;
				num++;
				materialName[num] = Consts2.profilS20.MaterialName;
				if (num2 >= 710.0)
				{
					array[num, 0] = ((B + H > 1000) ? (2.1 * ((double)(2 * (B + H) / 1000) - 0.14)) : (2.06 * ((double)(2 * (B + H) / 1000) - 0.12)));
				}
				else
				{
					array[num, 0] = 2.06 * ((double)(2 * (B + H) / 1000) - 0.12);
				}
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
				num++;
				materialName[num] = Consts2.kvadrat10.MaterialName;
				array[num, 0] = (double)(B + 130) / 1000.0 * 1.03;
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
				priceProduct += array[num, 0] * Consts2.kvadrat10.Price;
				num++;
				materialName[num] = Consts2.polipropilen.MaterialName;
				array[num, 0] = 0.01;
				array[num, 1] = 0.05;
				array[num, 5] = array[num, 0] * (double)number;
				array[num, 3] = array[num, 5] * array[num, 1];
				priceProduct += array[num, 0] * Consts2.polipropilen.Price;
			}
			break;
		case 3:
			if (num2 <= 450.0)
			{
				num++;
				switch (markaStali)
				{
				case 1:
					materialName[num] = Consts2.lystOchynkovanyj05.MaterialName;
					num3 = Consts2.lystOchynkovanyj05.Price;
					break;
				case 2:
					materialName[num] = Consts2.lystStalnyj05.MaterialName;
					num3 = Consts2.lystStalnyj05.Price;
					break;
				default:
				{
					CustomConst lystNerzavijuchyj2 = MaterialHelper.GetLystNerzavijuchyj(0.5, aisiType);
					materialName[num] = lystNerzavijuchyj2?.MaterialName ?? "Лист НЕРЖ ??, м2";
					num3 = lystNerzavijuchyj2.Price;
					break;
				}
				}
				if (L == 0)
				{
					L = 200;
				}
				array[num, 0] = (2.0 * (double)(B + H) / 1000.0 + 0.01) * (double)L / 1000.0;
				if (num2 <= 300.0)
				{
					array[num, 0] += (double)B * (double)H / 1000000.0;
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
				priceProduct = array[num, 0] * num3;
				num++;
				switch (markaStali)
				{
				case 1:
					materialName[num] = Consts2.lystOchynkovanyj09.MaterialName;
					num3 = Consts2.lystOchynkovanyj09.Price;
					break;
				case 2:
					materialName[num] = Consts2.lystStalnyj08.MaterialName;
					num3 = Consts2.lystStalnyj08.Price;
					break;
				default:
				{
					CustomConst lystNerzavijuchyj3 = MaterialHelper.GetLystNerzavijuchyj(0.8, aisiType);
					materialName[num] = lystNerzavijuchyj3?.MaterialName ?? "Лист НЕРЖ ??, м2";
					num3 = lystNerzavijuchyj3.Price;
					break;
				}
				}
				array[num, 0] = ((num2 > 300.0) ? ((double)B * (double)H / 1000000.0) : 0.0);
				array[num, 0] += 0.05 * (double)B / 1000.0 + 0.0188;
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
				priceProduct += array[num, 0] * num3;
				num++;
				array[num, 0] = 0.01;
				array[num, 4] = array[num, 0] * (double)number;
				if (num2 <= 300.0)
				{
					materialName[num] = Consts2.lystOchynkovanyj15.MaterialName;
					array[num, 5] = array[num, 4] * 7825.0 * 1.5 / 1000.0;
					priceProduct += array[num, 0] * Consts2.lystOchynkovanyj15.Price;
				}
				else
				{
					materialName[num] = Consts2.lystStalnyj20.MaterialName;
					array[num, 5] = array[num, 4] * 7825.0 * 2.0 / 1000.0;
					priceProduct += array[num, 0] * Consts2.lystStalnyj20.Price;
				}
				num++;
				materialName[num] = Consts2.profilS20.MaterialName;
				if (num2 >= 710.0)
				{
					array[num, 0] = ((B + H > 1000) ? (2.1 * (2.0 * (double)(B + H) / 1000.0 - 0.14)) : (2.06 * (2.0 * (double)(B + H) / 1000.0 - 0.12)));
				}
				else
				{
					array[num, 0] = 2.06 * (2.0 * (double)(B + H) / 1000.0 - 0.12);
				}
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
				num++;
				materialName[num] = Consts2.kvadrat10.MaterialName;
				array[num, 0] = (double)(B + 65) / 1000.0 * 1.03;
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
				priceProduct += array[num, 0] * Consts2.kvadrat10.Price;
				num++;
				materialName[num] = Consts2.boltM6_20.MaterialName;
				array[num, 0] = 1.0;
				array[num, 4] = array[num, 0] * (double)number;
				priceProduct += array[num, 0] * Consts2.boltM6_20.Price;
				num++;
				materialName[num] = Consts2.boltM6_12.MaterialName;
				array[num, 0] = 1.0;
				array[num, 4] = array[num, 0] * (double)number;
				priceProduct += array[num, 0] * Consts2.boltM6_12.Price;
				num++;
				materialName[num] = Consts2.boltM8_35.MaterialName;
				array[num, 0] = 1.0;
				array[num, 4] = array[num, 0] * (double)number;
				priceProduct += array[num, 0] * Consts2.boltM8_35.Price;
				num++;
				materialName[num] = Consts2.hajkaM6_Metelyk.MaterialName;
				array[num, 0] = 1.0;
				array[num, 4] = array[num, 0] * (double)number;
				priceProduct += array[num, 0] * Consts2.hajkaM6_Metelyk.Price;
				num++;
				materialName[num] = Consts2.hajkaM8.MaterialName;
				array[num, 0] = 1.0;
				array[num, 4] = array[num, 0] * (double)number;
				priceProduct += array[num, 0] * Consts2.hajkaM8.Price;
				num++;
				materialName[num] = Consts2.shajba_8.MaterialName;
				array[num, 0] = 5.0;
				array[num, 4] = array[num, 0] * (double)number;
				priceProduct += array[num, 0] * Consts2.shajba_8.Price;
				num++;
				materialName[num] = Consts2.kruh24.MaterialName;
				array[num, 0] = 0.017;
				array[num, 4] = array[num, 0] * (double)number;
				priceProduct += array[num, 0] * Consts2.kruh24.Price;
				num++;
				materialName[num] = Consts2.kruh18LC59.MaterialName;
				array[num, 0] = 0.017;
				array[num, 4] = array[num, 0] * (double)number;
				priceProduct += array[num, 0] * Consts2.kruh18LC59.Price;
				num++;
				materialName[num] = Consts2.ftoroplastF20.MaterialName;
				array[num, 0] = 0.01;
				array[num, 4] = array[num, 0] * (double)number;
				priceProduct += array[num, 0] * Consts2.ftoroplastF20.Price;
			}
			else if (num2 <= 630.0)
			{
				num++;
				switch (markaStali)
				{
				case 1:
					materialName[num] = Consts2.lystOchynkovanyj07.MaterialName;
					num3 = Consts2.lystOchynkovanyj07.Price;
					break;
				case 2:
					materialName[num] = Consts2.lystStalnyj08.MaterialName;
					num3 = Consts2.lystStalnyj08.Price;
					break;
				default:
				{
					CustomConst lystNerzavijuchyj4 = MaterialHelper.GetLystNerzavijuchyj(0.8, aisiType);
					materialName[num] = lystNerzavijuchyj4?.MaterialName ?? "Лист НЕРЖ ??, м2";
					num3 = lystNerzavijuchyj4.Price;
					break;
				}
				}
				if (L == 0)
				{
					L = 250;
				}
				array[num, 0] = (2.0 * (double)(B + H) / 1000.0 + 0.01) * (double)L / 1000.0 * 1.1;
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
				priceProduct = array[num, 0] * num3;
				num++;
				switch (markaStali)
				{
				case 1:
					materialName[num] = Consts2.lystOchynkovanyj09.MaterialName;
					num3 = Consts2.lystOchynkovanyj09.Price;
					break;
				case 2:
					materialName[num] = Consts2.lystStalnyj08.MaterialName;
					num3 = Consts2.lystStalnyj08.Price;
					break;
				default:
				{
					CustomConst lystNerzavijuchyj5 = MaterialHelper.GetLystNerzavijuchyj(0.8, aisiType);
					materialName[num] = lystNerzavijuchyj5?.MaterialName ?? "Лист НЕРЖ ??, м2";
					num3 = lystNerzavijuchyj5.Price;
					break;
				}
				}
				array[num, 0] = ((double)B * (double)H / 1000000.0 + 0.05 * (double)B / 1000.0 + 0.0188) * 1.1;
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
				priceProduct += array[num, 0] * num3;
				num++;
				materialName[num] = Consts2.lystStalnyj20.MaterialName;
				array[num, 0] = 0.01;
				array[num, 4] = array[num, 0] * (double)number;
				array[num, 5] = array[num, 4] * 7825.0 * 2.0 / 1000.0;
				priceProduct += array[num, 0] * Consts2.lystStalnyj20.Price;
				num++;
				materialName[num] = Consts2.profilS20.MaterialName;
				if (num2 >= 710.0)
				{
					array[num, 0] = ((B + H > 1000) ? (2.1 * (2.0 * (double)(B + H) / 1000.0 - 0.14)) : (2.06 * (2.0 * (double)(B + H) / 1000.0 - 0.12)));
				}
				else
				{
					array[num, 0] = 2.06 * (2.0 * (double)(B + H) / 1000.0 - 0.12);
				}
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
				num++;
				materialName[num] = Consts2.kvadrat10.MaterialName;
				array[num, 0] = (double)(B + 65) / 1000.0 * 1.03;
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
				priceProduct += array[num, 0] * Consts2.kvadrat10.Price;
				num++;
				materialName[num] = Consts2.boltM6_20.MaterialName;
				array[num, 0] = 1.0;
				array[num, 4] = array[num, 0] * (double)number;
				priceProduct += array[num, 0] * Consts2.boltM6_20.Price;
				num++;
				materialName[num] = Consts2.boltM6_12.MaterialName;
				array[num, 0] = 1.0;
				array[num, 4] = array[num, 0] * (double)number;
				priceProduct += array[num, 0] * Consts2.boltM6_12.Price;
				num++;
				materialName[num] = Consts2.boltM8_35.MaterialName;
				array[num, 0] = 1.0;
				array[num, 4] = array[num, 0] * (double)number;
				priceProduct += array[num, 0] * Consts2.boltM8_35.Price;
				num++;
				materialName[num] = Consts2.hajkaM6_Metelyk.MaterialName;
				array[num, 0] = 1.0;
				array[num, 4] = array[num, 0] * (double)number;
				priceProduct += array[num, 0] * Consts2.hajkaM6_Metelyk.Price;
				num++;
				materialName[num] = Consts2.hajkaM8.MaterialName;
				array[num, 0] = 1.0;
				array[num, 4] = array[num, 0] * (double)number;
				priceProduct += array[num, 0] * Consts2.hajkaM8.Price;
				num++;
				materialName[num] = Consts2.shajba_8.MaterialName;
				array[num, 0] = 5.0;
				array[num, 4] = array[num, 0] * (double)number;
				priceProduct += array[num, 0] * Consts2.shajba_8.Price;
				num++;
				materialName[num] = Consts2.kruh24.MaterialName;
				array[num, 0] = 0.017;
				array[num, 4] = array[num, 0] * (double)number;
				priceProduct += array[num, 0] * Consts2.kruh24.Price;
				num++;
				materialName[num] = Consts2.kruh18LC59.MaterialName;
				array[num, 0] = 0.017;
				array[num, 4] = array[num, 0] * (double)number;
				priceProduct += array[num, 0] * Consts2.kruh18LC59.Price;
				num++;
				materialName[num] = Consts2.ftoroplastF20.MaterialName;
				array[num, 0] = 0.01;
				array[num, 4] = array[num, 0] * (double)number;
				priceProduct += array[num, 0] * Consts2.ftoroplastF20.Price;
			}
			else if (num2 <= 800.0)
			{
				num++;
				switch (markaStali)
				{
				case 1:
					materialName[num] = Consts2.lystOchynkovanyj07.MaterialName;
					num3 = Consts2.lystOchynkovanyj07.Price;
					break;
				case 2:
					materialName[num] = Consts2.lystStalnyj08.MaterialName;
					num3 = Consts2.lystStalnyj08.Price;
					break;
				default:
				{
					CustomConst lystNerzavijuchyj6 = MaterialHelper.GetLystNerzavijuchyj(0.8, aisiType);
					materialName[num] = lystNerzavijuchyj6?.MaterialName ?? "Лист НЕРЖ ??, м2";
					num3 = lystNerzavijuchyj6.Price;
					break;
				}
				}
				if (L == 0)
				{
					L = 300;
				}
				array[num, 0] = (2.0 * (double)(B + H) / 1000.0 + 0.01) * (double)L / 1000.0 * 1.1;
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
				priceProduct = array[num, 0] * num3;
				num++;
				switch (markaStali)
				{
				case 1:
					materialName[num] = Consts2.lystOchynkovanyj09.MaterialName;
					num3 = Consts2.lystOchynkovanyj09.Price;
					break;
				case 2:
					materialName[num] = Consts2.lystStalnyj08.MaterialName;
					num3 = Consts2.lystStalnyj08.Price;
					break;
				default:
				{
					CustomConst lystNerzavijuchyj7 = MaterialHelper.GetLystNerzavijuchyj(0.8, aisiType);
					materialName[num] = lystNerzavijuchyj7?.MaterialName ?? "Лист НЕРЖ ??, м2";
					num3 = lystNerzavijuchyj7.Price;
					break;
				}
				}
				array[num, 0] = ((double)B * (double)H / 1000000.0 + 0.05 * (double)B / 1000.0 + 0.0188) * 1.1;
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
				priceProduct += array[num, 0] * num3;
				num++;
				materialName[num] = Consts2.lystStalnyj20.MaterialName;
				array[num, 0] = 0.01;
				array[num, 4] = array[num, 0] * (double)number;
				array[num, 5] = array[num, 4] * 7825.0 * 2.0 / 1000.0;
				priceProduct += array[num, 0] * Consts2.lystStalnyj20.Price;
				num++;
				materialName[num] = Consts2.profilS20.MaterialName;
				if (num2 >= 710.0)
				{
					array[num, 0] = ((B + H > 1000) ? (2.1 * (2.0 * (double)(B + H) / 1000.0 - 0.14)) : (2.06 * (2.0 * (double)(B + H) / 1000.0 - 0.12)));
				}
				else
				{
					array[num, 0] = 2.06 * (2.0 * (double)(B + H) / 1000.0 - 0.12);
				}
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
				num++;
				materialName[num] = Consts2.kvadrat10.MaterialName;
				array[num, 0] = (double)(B + 65) / 1000.0 * 1.03;
				array[num, 4] = array[num, 0] * (double)number;
				priceProduct += array[num, 0] * Consts2.kvadrat10.Price;
				num++;
				materialName[num] = Consts2.boltM6_20.MaterialName;
				array[num, 0] = 1.0;
				array[num, 4] = array[num, 0] * (double)number;
				priceProduct += array[num, 0] * Consts2.boltM6_20.Price;
				num++;
				materialName[num] = Consts2.boltM6_12.MaterialName;
				array[num, 0] = 1.0;
				array[num, 4] = array[num, 0] * (double)number;
				priceProduct += array[num, 0] * Consts2.boltM6_12.Price;
				num++;
				materialName[num] = Consts2.boltM8_35.MaterialName;
				array[num, 0] = 1.0;
				array[num, 4] = array[num, 0] * (double)number;
				priceProduct += array[num, 0] * Consts2.boltM8_35.Price;
				num++;
				materialName[num] = Consts2.hajkaM6_Metelyk.MaterialName;
				array[num, 0] = 1.0;
				array[num, 4] = array[num, 0] * (double)number;
				priceProduct += array[num, 0] * Consts2.hajkaM6_Metelyk.Price;
				num++;
				materialName[num] = Consts2.hajkaM8.MaterialName;
				array[num, 0] = 1.0;
				array[num, 4] = array[num, 0] * (double)number;
				priceProduct += array[num, 0] * Consts2.hajkaM8.Price;
				num++;
				materialName[num] = Consts2.shajba_8.MaterialName;
				array[num, 0] = 5.0;
				array[num, 4] = array[num, 0] * (double)number;
				priceProduct += array[num, 0] * Consts2.shajba_8.Price;
				num++;
				materialName[num] = Consts2.kruh24.MaterialName;
				array[num, 0] = 0.017;
				array[num, 4] = array[num, 0] * (double)number;
				priceProduct += array[num, 0] * Consts2.kruh24.Price;
				num++;
				materialName[num] = Consts2.kruh18LC59.MaterialName;
				array[num, 0] = 0.017;
				array[num, 4] = array[num, 0] * (double)number;
				priceProduct += array[num, 0] * Consts2.kruh18LC59.Price;
				num++;
				materialName[num] = Consts2.ftoroplastF20.MaterialName;
				array[num, 0] = 0.01;
				array[num, 4] = array[num, 0] * (double)number;
				priceProduct += array[num, 0] * Consts2.ftoroplastF20.Price;
			}
			break;
		case 4:
			if (num2 <= 450.0)
			{
				num++;
				switch (markaStali)
				{
				case 1:
					materialName[num] = Consts2.lystOchynkovanyj05.MaterialName;
					num3 = Consts2.lystOchynkovanyj05.Price;
					break;
				case 2:
					materialName[num] = Consts2.lystStalnyj05.MaterialName;
					num3 = Consts2.lystStalnyj05.Price;
					break;
				default:
				{
					CustomConst lystNerzavijuchyj21 = MaterialHelper.GetLystNerzavijuchyj(0.5, aisiType);
					materialName[num] = lystNerzavijuchyj21?.MaterialName ?? "Лист НЕРЖ ??, м2";
					num3 = lystNerzavijuchyj21.Price;
					break;
				}
				}
				if (L == 0)
				{
					L = 200;
				}
				array[num, 0] = (2.0 * (double)(B + H) / 1000.0 + 0.01) * (double)L / 1000.0 * 1.1;
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
				priceProduct = array[num, 0] * num3;
				num++;
				switch (markaStali)
				{
				case 1:
					materialName[num] = Consts2.lystOchynkovanyj07.MaterialName;
					num3 = Consts2.lystOchynkovanyj07.Price;
					break;
				case 2:
					materialName[num] = Consts2.lystStalnyj08.MaterialName;
					num3 = Consts2.lystStalnyj08.Price;
					break;
				default:
				{
					CustomConst lystNerzavijuchyj22 = MaterialHelper.GetLystNerzavijuchyj(0.8, aisiType);
					materialName[num] = lystNerzavijuchyj22?.MaterialName ?? "Лист НЕРЖ ??, м2";
					num3 = lystNerzavijuchyj22.Price;
					break;
				}
				}
				array[num, 0] = 0.039270000000000006;
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
				priceProduct += array[num, 0] * num3;
				num++;
				switch (markaStali)
				{
				case 1:
					materialName[num] = Consts2.lystOchynkovanyj09.MaterialName;
					num3 = Consts2.lystOchynkovanyj09.Price;
					break;
				case 2:
					materialName[num] = Consts2.lystStalnyj08.MaterialName;
					num3 = Consts2.lystStalnyj08.Price;
					break;
				default:
				{
					CustomConst lystNerzavijuchyj23 = MaterialHelper.GetLystNerzavijuchyj(0.8, aisiType);
					materialName[num] = lystNerzavijuchyj23?.MaterialName ?? "Лист НЕРЖ ??, м2";
					num3 = lystNerzavijuchyj23.Price;
					break;
				}
				}
				array[num, 0] = ((num2 > 300.0) ? ((double)B * (double)H / 1000000.0) : 0.0);
				array[num, 0] += 0.05 * (double)B / 1000.0;
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
				priceProduct += array[num, 0] * num3;
				num++;
				materialName[num] = Consts2.profilS20.MaterialName;
				if (num2 >= 710.0)
				{
					array[num, 0] = ((B + H > 1000) ? (2.1 * (2.0 * (double)(B + H) / 1000.0 - 0.14)) : (2.06 * (2.0 * (double)(B + H) / 1000.0 - 0.12)));
				}
				else
				{
					array[num, 0] = 2.06 * (2.0 * (double)(B + H) / 1000.0 - 0.12);
				}
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
				num++;
				materialName[num] = Consts2.kvadrat10.MaterialName;
				array[num, 0] = (double)(B + 130) / 1000.0 * 1.03;
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
				priceProduct += array[num, 0] * Consts2.kvadrat10.Price;
				num++;
				materialName[num] = Consts2.kruh24.MaterialName;
				array[num, 0] = 0.017;
				array[num, 4] = array[num, 0] * (double)number;
				priceProduct += array[num, 0] * Consts2.kruh24.Price;
				num++;
				materialName[num] = Consts2.kruh18LC59.MaterialName;
				array[num, 0] = 0.017;
				array[num, 4] = array[num, 0] * (double)number;
				priceProduct += array[num, 0] * Consts2.kruh18LC59.Price;
				num++;
				materialName[num] = Consts2.ftoroplastF20.MaterialName;
				array[num, 0] = 0.01;
				array[num, 4] = array[num, 0] * (double)number;
				priceProduct += array[num, 0] * Consts2.ftoroplastF20.Price;
			}
			else if (num2 <= 630.0)
			{
				num++;
				switch (markaStali)
				{
				case 1:
					materialName[num] = Consts2.lystOchynkovanyj07.MaterialName;
					num3 = Consts2.lystOchynkovanyj07.Price;
					break;
				case 2:
					materialName[num] = Consts2.lystStalnyj08.MaterialName;
					num3 = Consts2.lystStalnyj08.Price;
					break;
				default:
				{
					CustomConst lystNerzavijuchyj24 = MaterialHelper.GetLystNerzavijuchyj(0.8, aisiType);
					materialName[num] = lystNerzavijuchyj24?.MaterialName ?? "Лист НЕРЖ ??, м2";
					num3 = lystNerzavijuchyj24.Price;
					break;
				}
				}
				if (L == 0)
				{
					L = 250;
				}
				array[num, 0] = ((2.0 * (double)(B + H) / 1000.0 + 0.01) * (double)L / 1000.0 + 0.0357) * 1.1;
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
				priceProduct = array[num, 0] * num3;
				num++;
				switch (markaStali)
				{
				case 1:
					materialName[num] = Consts2.lystOchynkovanyj09.MaterialName;
					num3 = Consts2.lystOchynkovanyj09.Price;
					break;
				case 2:
					materialName[num] = Consts2.lystStalnyj08.MaterialName;
					num3 = Consts2.lystStalnyj08.Price;
					break;
				default:
				{
					CustomConst lystNerzavijuchyj25 = MaterialHelper.GetLystNerzavijuchyj(0.8, aisiType);
					materialName[num] = lystNerzavijuchyj25?.MaterialName ?? "Лист НЕРЖ ??, м2";
					num3 = lystNerzavijuchyj25.Price;
					break;
				}
				}
				array[num, 0] = ((double)B * (double)H / 1000000.0 + 0.05 * (double)B / 1000.0) * 1.1;
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
				priceProduct += array[num, 0] * num3;
				num++;
				materialName[num] = Consts2.profilS20.MaterialName;
				if (num2 >= 710.0)
				{
					array[num, 0] = ((B + H > 1000) ? (2.1 * (2.0 * (double)(B + H) / 1000.0 - 0.14)) : (2.06 * (2.0 * (double)(B + H) / 1000.0 - 0.12)));
				}
				else
				{
					array[num, 0] = 2.06 * (2.0 * (double)(B + H) / 1000.0 - 0.12);
				}
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
				num++;
				materialName[num] = Consts2.kvadrat10.MaterialName;
				array[num, 0] = (double)(B + 130) / 1000.0 * 1.03;
				array[num, 4] = array[num, 0] * (double)number;
				priceProduct += array[num, 0] * Consts2.kvadrat10.Price;
				num++;
				materialName[num] = Consts2.kruh24.MaterialName;
				array[num, 0] = 0.017;
				array[num, 4] = array[num, 0] * (double)number;
				priceProduct += array[num, 0] * Consts2.kruh24.Price;
				num++;
				materialName[num] = Consts2.kruh18LC59.MaterialName;
				array[num, 0] = 0.017;
				array[num, 4] = array[num, 0] * (double)number;
				priceProduct += array[num, 0] * Consts2.kruh18LC59.Price;
				num++;
				materialName[num] = Consts2.ftoroplastF20.MaterialName;
				array[num, 0] = 0.01;
				array[num, 4] = array[num, 0] * (double)number;
				priceProduct += array[num, 0] * Consts2.ftoroplastF20.Price;
			}
			else if (num2 <= 800.0)
			{
				num++;
				switch (markaStali)
				{
				case 1:
					materialName[num] = Consts2.lystOchynkovanyj07.MaterialName;
					num3 = Consts2.lystOchynkovanyj07.Price;
					break;
				case 2:
					materialName[num] = Consts2.lystStalnyj08.MaterialName;
					num3 = Consts2.lystStalnyj08.Price;
					break;
				default:
				{
					CustomConst lystNerzavijuchyj26 = MaterialHelper.GetLystNerzavijuchyj(0.8, aisiType);
					materialName[num] = lystNerzavijuchyj26?.MaterialName ?? "Лист НЕРЖ ??, м2";
					num3 = lystNerzavijuchyj26.Price;
					break;
				}
				}
				if (L == 0)
				{
					L = 300;
				}
				array[num, 0] = ((2.0 * (double)(B + H) / 1000.0 + 0.01) * (double)L / 1000.0 + 0.0357) * 1.1;
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
				priceProduct = array[num, 0] * num3;
				num++;
				switch (markaStali)
				{
				case 1:
					materialName[num] = Consts2.lystOchynkovanyj09.MaterialName;
					num3 = Consts2.lystOchynkovanyj09.Price;
					break;
				case 2:
					materialName[num] = Consts2.lystStalnyj08.MaterialName;
					num3 = Consts2.lystStalnyj08.Price;
					break;
				default:
				{
					CustomConst lystNerzavijuchyj27 = MaterialHelper.GetLystNerzavijuchyj(0.8, aisiType);
					materialName[num] = lystNerzavijuchyj27?.MaterialName ?? "Лист НЕРЖ ??, м2";
					num3 = lystNerzavijuchyj27.Price;
					break;
				}
				}
				array[num, 0] = ((double)B * (double)H / 1000000.0 + 0.05 * (double)B / 1000.0) * 1.1;
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
				priceProduct += array[num, 0] * num3;
				num++;
				materialName[num] = Consts2.profilS20.MaterialName;
				if (num2 >= 710.0)
				{
					array[num, 0] = ((B + H > 1000) ? (2.1 * (2.0 * (double)(B + H) / 1000.0 - 0.14)) : (2.06 * (2.0 * (double)(B + H) / 1000.0 - 0.12)));
				}
				else
				{
					array[num, 0] = 2.06 * (2.0 * (double)(B + H) / 1000.0 - 0.12);
				}
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
				num++;
				materialName[num] = Consts2.kvadrat10.MaterialName;
				array[num, 0] = (double)(B + 130) / 1000.0 * 1.03;
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
				priceProduct += array[num, 0] * Consts2.kvadrat10.Price;
				num++;
				materialName[num] = Consts2.kruh24.MaterialName;
				array[num, 0] = 0.017;
				array[num, 4] = array[num, 0] * (double)number;
				priceProduct += array[num, 0] * Consts2.kruh24.Price;
				num++;
				materialName[num] = Consts2.kruh18LC59.MaterialName;
				array[num, 0] = 0.017;
				array[num, 4] = array[num, 0] * (double)number;
				priceProduct += array[num, 0] * Consts2.kruh18LC59.Price;
				num++;
				materialName[num] = Consts2.ftoroplastF20.MaterialName;
				array[num, 0] = 0.01;
				array[num, 4] = array[num, 0] * (double)number;
				priceProduct += array[num, 0] * Consts2.ftoroplastF20.Price;
			}
			break;
		case 5:
			num++;
			switch (markaStali)
			{
			case 1:
				materialName[num] = Consts2.lystOchynkovanyj05.MaterialName;
				num3 = Consts2.lystOchynkovanyj05.Price;
				break;
			case 2:
				materialName[num] = Consts2.lystStalnyj05.MaterialName;
				num3 = Consts2.lystStalnyj05.Price;
				break;
			default:
			{
				CustomConst lystNerzavijuchyj = MaterialHelper.GetLystNerzavijuchyj(0.5, aisiType);
				materialName[num] = lystNerzavijuchyj?.MaterialName ?? "Лист НЕРЖ ??, м2";
				num3 = lystNerzavijuchyj.Price;
				break;
			}
			}
			if (L == 0)
			{
				L = 170;
			}
			array[num, 0] = ((2.0 * (double)(B + H) / 1000.0 + 0.01) * (double)L / 1000.0 + (double)B * (double)H / 1000000.0) * 1.1;
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
			priceProduct = array[num, 0] * num3;
			num++;
			materialName[num] = Consts2.profilS20.MaterialName;
			if (num2 >= 710.0)
			{
				array[num, 0] = ((B + H > 1000) ? (2.1 * (2.0 * (double)(B + H) / 1000.0 - 0.14)) : (2.06 * (2.0 * (double)(B + H) / 1000.0 - 0.12)));
			}
			else
			{
				array[num, 0] = 2.06 * (2.0 * (double)(B + H) / 1000.0 - 0.12);
			}
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
			num++;
			materialName[num] = Consts2.komplectRuchkyDroselKlapana.MaterialName;
			array[num, 0] = 1.0;
			array[num, 4] = array[num, 0] * (double)number;
			priceProduct += array[num, 0] * Consts2.komplectRuchkyDroselKlapana.Price;
			num++;
			materialName[num] = Consts2.shurupWF42_19.MaterialName;
			array[num, 0] = 5.0;
			array[num, 4] = array[num, 0] * (double)number;
			priceProduct += array[num, 0] * Consts2.shurupWF42_19.Price;
			num++;
			materialName[num] = Consts2.shurupWFS42_13.MaterialName;
			array[num, 0] = 5.0;
			array[num, 4] = array[num, 0] * (double)number;
			priceProduct += array[num, 0] * Consts2.shurupWFS42_13.Price;
			break;
		}
		double num4 = 0.0;
		if (servopryvid != 0)
		{
			num++;
			var (text, num5) = MaterialHelper.GetKlapanServopryvidData(servopryvid);
			materialName[num] = text;
			array[num, 0] = 1.0;
			array[num, 4] = array[num, 0] * (double)number;
			num4 = num5;
		}
		materialCost = priceProduct + num4;
		priceProduct *= 3.5;
		priceProduct += num4;
		return array;
	}

	public static double[] FormPriceKlapanDroselnyjKDP()
	{
		double[] array = new double[70];
		int[] array2 = new int[70]
		{
			200, 200, 250, 250, 250, 250, 315, 315, 315, 315,
			355, 355, 355, 355, 355, 400, 400, 400, 400, 400,
			400, 450, 450, 450, 450, 450, 450, 500, 500, 500,
			500, 500, 500, 500, 500, 560, 560, 560, 560, 560,
			560, 560, 560, 630, 630, 630, 630, 630, 630, 630,
			630, 710, 710, 710, 710, 710, 710, 710, 710, 710,
			710, 800, 800, 800, 800, 800, 800, 800, 800, 800
		};
		int[] array3 = new int[70]
		{
			140, 200, 100, 140, 200, 250, 140, 200, 250, 315,
			140, 200, 250, 315, 355, 140, 200, 250, 315, 355,
			400, 200, 250, 315, 355, 400, 450, 200, 250, 315,
			355, 400, 450, 500, 630, 250, 315, 355, 400, 450,
			500, 560, 630, 200, 250, 315, 400, 450, 500, 560,
			630, 200, 250, 315, 355, 400, 450, 500, 560, 630,
			710, 200, 250, 315, 355, 400, 450, 500, 560, 630
		};
		double[,] array4 = new double[14, 6];
		for (int i = 0; i < 70; i++)
		{
			array4 = MaterialKlapanDroselnyjKDP(array2[i], array3[i], 0, 1, 1, 0);
			array[i] = priceProduct;
		}
		return array;
	}

	public static double VolumeKlapanDroselnyjKDP(int B, int H, int L)
	{
		return Math.Round((double)B * (double)H * (double)L / 1000000.0) / 1000.0;
	}
}
