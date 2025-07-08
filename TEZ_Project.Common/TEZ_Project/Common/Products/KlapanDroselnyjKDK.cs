using System;
using TEZ_Project.Common.Helpers;
using TEZ_Project.Common.Data;
using TEZ_Project;

namespace TEZ_Project.Common.Products;

public static class KlapanDroselnyjKDK
{
	public static string[] materialName = new string[16]
	{
		"", "", "", "", "", "", "", "", "", "",
		"", "", "", "", "", ""
	};

	public static double materialCost;

	public static double priceProduct;

	public static double[,] priceKlapanDroselnyjKDZK = new double[11, 2];

	public static double[,] MaterialKlapanDroselnyjKDK(int D, int L, int number, int vydKDK, int servopryvid, int markaStali = 1, int vidbortovka = 0, string aisiType = "430", double tovchynaMetalu = 0.0)
	{
		double[,] array = new double[16, 6];
		int num = -1;
		double num2 = 0.0;
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
		switch (vydKDK)
		{
		case 1:
			if (D <= 315)
			{
				num++;
				switch (markaStali)
				{
				case 1:
					materialName[num] = Consts2.lystOchynkovanyj05.MaterialName;
					num2 = Consts2.lystOchynkovanyj05.Price;
					break;
				case 2:
					materialName[num] = Consts2.lystStalnyj05.MaterialName;
					num2 = Consts2.lystStalnyj05.Price;
					break;
				default:
				{
					CustomConst lystNerzavijuchyj43 = MaterialHelper.GetLystNerzavijuchyj(0.5, aisiType);
					materialName[num] = lystNerzavijuchyj43?.MaterialName ?? "Лист НЕРЖ ??, м2";
					num2 = lystNerzavijuchyj43.Price;
					break;
				}
				}
				array[num, 0] = (Math.PI * (double)D / 1000.0 + 0.01) * (double)L / 1000.0;
				array[num, 0] += (double)D * (double)D / 1000000.0;
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
				priceProduct = array[num, 0] * num2;
				num++;
				switch (markaStali)
				{
				case 1:
					materialName[num] = Consts2.lystOchynkovanyj09.MaterialName;
					num2 = Consts2.lystOchynkovanyj09.Price;
					break;
				case 2:
					materialName[num] = Consts2.lystStalnyj08.MaterialName;
					num2 = Consts2.lystStalnyj08.Price;
					break;
				default:
				{
					CustomConst lystNerzavijuchyj44 = MaterialHelper.GetLystNerzavijuchyj(0.8, aisiType);
					materialName[num] = lystNerzavijuchyj44?.MaterialName ?? "Лист НЕРЖ ??, м2";
					num2 = lystNerzavijuchyj44.Price;
					break;
				}
				}
				array[num, 0] = 0.05 * (double)D / 1000.0 + 0.03;
				array[num, 1] = 0.05;
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
				priceProduct += array[num, 0] * num2;
				num++;
				materialName[num] = Consts2.lystOchynkovanyj15.MaterialName;
				array[num, 0] = 0.01;
				array[num, 4] = array[num, 0] * (double)number;
				array[num, 5] = array[num, 4] * 7825.0 * 1.5 / 1000.0;
				priceProduct += array[num, 0] * Consts2.lystOchynkovanyj15.Price;
				num++;
				materialName[num] = Consts2.kvadrat10.MaterialName;
				array[num, 0] = (double)(D + 65) / 1000.0 * 1.03;
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
			else if (D <= 400)
			{
				num++;
				switch (markaStali)
				{
				case 1:
					materialName[num] = Consts2.lystOchynkovanyj05.MaterialName;
					num2 = Consts2.lystOchynkovanyj05.Price;
					break;
				case 2:
					materialName[num] = Consts2.lystStalnyj05.MaterialName;
					num2 = Consts2.lystStalnyj05.Price;
					break;
				default:
				{
					CustomConst lystNerzavijuchyj45 = MaterialHelper.GetLystNerzavijuchyj(0.5, aisiType);
					materialName[num] = lystNerzavijuchyj45?.MaterialName ?? "Лист НЕРЖ ??, м2";
					num2 = lystNerzavijuchyj45.Price;
					break;
				}
				}
				array[num, 0] = (Math.PI * (double)D / 1000.0 + 0.01) * (double)L / 1000.0 * 1.1;
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
				priceProduct = array[num, 0] * num2;
				num++;
				switch (markaStali)
				{
				case 1:
					materialName[num] = Consts2.lystOchynkovanyj07.MaterialName;
					num2 = Consts2.lystOchynkovanyj07.Price;
					break;
				case 2:
					materialName[num] = Consts2.lystStalnyj08.MaterialName;
					num2 = Consts2.lystStalnyj08.Price;
					break;
				default:
				{
					CustomConst lystNerzavijuchyj46 = MaterialHelper.GetLystNerzavijuchyj(0.8, aisiType);
					materialName[num] = lystNerzavijuchyj46?.MaterialName ?? "Лист НЕРЖ ??, м2";
					num2 = lystNerzavijuchyj46.Price;
					break;
				}
				}
				array[num, 0] = (double)D * (double)D / 1000000.0 * 1.1;
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
				priceProduct += array[num, 0] * num2;
				num++;
				switch (markaStali)
				{
				case 1:
					materialName[num] = Consts2.lystOchynkovanyj09.MaterialName;
					num2 = Consts2.lystOchynkovanyj09.Price;
					break;
				case 2:
					materialName[num] = Consts2.lystStalnyj08.MaterialName;
					num2 = Consts2.lystStalnyj08.Price;
					break;
				default:
				{
					CustomConst lystNerzavijuchyj47 = MaterialHelper.GetLystNerzavijuchyj(0.8, aisiType);
					materialName[num] = lystNerzavijuchyj47?.MaterialName ?? "Лист НЕРЖ ??, м2";
					num2 = lystNerzavijuchyj47.Price;
					break;
				}
				}
				array[num, 0] = 0.05 * (double)D / 1000.0 + 0.03;
				array[num, 1] = 0.05;
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
				priceProduct += array[num, 0] * num2;
				num++;
				materialName[num] = Consts2.lystStalnyj20.MaterialName;
				array[num, 0] = 0.01;
				array[num, 4] = array[num, 0] * (double)number;
				array[num, 5] = array[num, 4] * 7825.0 * 2.0 / 1000.0;
				priceProduct += array[num, 0] * Consts2.lystStalnyj20.Price;
				num++;
				materialName[num] = Consts2.kvadrat10.MaterialName;
				array[num, 0] = (double)(D + 65) / 1000.0 * 1.03;
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
			else if (D <= 630)
			{
				num++;
				switch (markaStali)
				{
				case 1:
					materialName[num] = Consts2.lystOchynkovanyj07.MaterialName;
					num2 = Consts2.lystOchynkovanyj07.Price;
					break;
				case 2:
					materialName[num] = Consts2.lystStalnyj08.MaterialName;
					num2 = Consts2.lystStalnyj08.Price;
					break;
				default:
				{
					CustomConst lystNerzavijuchyj48 = MaterialHelper.GetLystNerzavijuchyj(0.8, aisiType);
					materialName[num] = lystNerzavijuchyj48?.MaterialName ?? "Лист НЕРЖ ??, м2";
					num2 = lystNerzavijuchyj48.Price;
					break;
				}
				}
				array[num, 0] = (Math.PI * (double)D / 1000.0 + 0.01) * (double)L / 1000.0 * 1.1;
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
				priceProduct = array[num, 0] * num2;
				num++;
				switch (markaStali)
				{
				case 1:
					materialName[num] = Consts2.lystOchynkovanyj09.MaterialName;
					num2 = Consts2.lystOchynkovanyj09.Price;
					break;
				case 2:
					materialName[num] = Consts2.lystStalnyj08.MaterialName;
					num2 = Consts2.lystStalnyj08.Price;
					break;
				default:
				{
					CustomConst lystNerzavijuchyj49 = MaterialHelper.GetLystNerzavijuchyj(0.8, aisiType);
					materialName[num] = lystNerzavijuchyj49?.MaterialName ?? "Лист НЕРЖ ??, м2";
					num2 = lystNerzavijuchyj49.Price;
					break;
				}
				}
				array[num, 0] = (double)D * (double)D / 1000000.0 * 1.1;
				array[num, 0] += 0.05 * (double)D / 1000.0 + 0.03;
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
				priceProduct += array[num, 0] * num2;
				num++;
				materialName[num] = Consts2.lystStalnyj20.MaterialName;
				array[num, 0] = 0.01;
				array[num, 4] = array[num, 0] * (double)number;
				array[num, 5] = array[num, 4] * 7825.0 * 2.0 / 1000.0;
				priceProduct += array[num, 0] * Consts2.lystStalnyj20.Price;
				num++;
				materialName[num] = Consts2.kvadrat10.MaterialName;
				array[num, 0] = (double)(D + 65) / 1000.0 * 1.03;
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
			if (D <= 315)
			{
				num++;
				switch (markaStali)
				{
				case 1:
					materialName[num] = Consts2.lystOchynkovanyj05.MaterialName;
					num2 = Consts2.lystOchynkovanyj05.Price;
					break;
				case 2:
					materialName[num] = Consts2.lystStalnyj05.MaterialName;
					num2 = Consts2.lystStalnyj05.Price;
					break;
				default:
				{
					CustomConst lystNerzavijuchyj22 = MaterialHelper.GetLystNerzavijuchyj(0.5, aisiType);
					materialName[num] = lystNerzavijuchyj22?.MaterialName ?? "Лист НЕРЖ ??, м2";
					num2 = lystNerzavijuchyj22.Price;
					break;
				}
				}
				array[num, 0] = (Math.PI * (double)D / 1000.0 + 0.01) * (double)L / 1000.0;
				array[num, 0] += (double)D * (double)D / 1000000.0;
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
				priceProduct = array[num, 0] * num2;
				num++;
				switch (markaStali)
				{
				case 1:
					materialName[num] = Consts2.lystOchynkovanyj07.MaterialName;
					num2 = Consts2.lystOchynkovanyj07.Price;
					break;
				case 2:
					materialName[num] = Consts2.lystStalnyj08.MaterialName;
					num2 = Consts2.lystStalnyj08.Price;
					break;
				default:
				{
					CustomConst lystNerzavijuchyj23 = MaterialHelper.GetLystNerzavijuchyj(0.8, aisiType);
					materialName[num] = lystNerzavijuchyj23?.MaterialName ?? "Лист НЕРЖ ??, м2";
					num2 = lystNerzavijuchyj23.Price;
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
				priceProduct += array[num, 0] * num2;
				num++;
				switch (markaStali)
				{
				case 1:
					materialName[num] = Consts2.lystOchynkovanyj09.MaterialName;
					num2 = Consts2.lystOchynkovanyj09.Price;
					break;
				case 2:
					materialName[num] = Consts2.lystStalnyj08.MaterialName;
					num2 = Consts2.lystStalnyj08.Price;
					break;
				default:
				{
					CustomConst lystNerzavijuchyj24 = MaterialHelper.GetLystNerzavijuchyj(0.8, aisiType);
					materialName[num] = lystNerzavijuchyj24?.MaterialName ?? "Лист НЕРЖ ??, м2";
					num2 = lystNerzavijuchyj24.Price;
					break;
				}
				}
				array[num, 0] = 0.05 * (double)D / 1000.0;
				array[num, 1] = 0.05;
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
				priceProduct += array[num, 0] * num2;
				num++;
				materialName[num] = Consts2.kvadrat10.MaterialName;
				array[num, 0] = (double)(D + 130) / 1000.0 * 1.03;
				if (array[num, 0] < 0.005)
				{
					array[num, 0] = Math.Round(1000.0 * array[num, 0]) / 1000.0;
				}
				else
				{
					array[num, 0] = Math.Round(100.0 * array[num, 0]) / 100.0;
				}
				array[num, 1] = 0.03;
				array[num, 4] = array[num, 0] * (double)number;
				array[num, 2] = array[num, 4] * array[num, 1];
				priceProduct += array[num, 0] * Consts2.kvadrat10.Price;
				num++;
				materialName[num] = Consts2.polipropilen.MaterialName;
				array[num, 0] = 0.01;
				array[num, 1] = 0.03;
				array[num, 5] = array[num, 0] * (double)number;
				array[num, 3] = array[num, 5] * array[num, 1];
				priceProduct += array[num, 0] * Consts2.polipropilen.Price;
			}
			else if (D <= 400)
			{
				num++;
				switch (markaStali)
				{
				case 1:
					materialName[num] = Consts2.lystOchynkovanyj05.MaterialName;
					num2 = Consts2.lystOchynkovanyj05.Price;
					break;
				case 2:
					materialName[num] = Consts2.lystStalnyj05.MaterialName;
					num2 = Consts2.lystStalnyj05.Price;
					break;
				default:
				{
					CustomConst lystNerzavijuchyj25 = MaterialHelper.GetLystNerzavijuchyj(0.5, aisiType);
					materialName[num] = lystNerzavijuchyj25?.MaterialName ?? "Лист НЕРЖ ??, м2";
					num2 = lystNerzavijuchyj25.Price;
					break;
				}
				}
				array[num, 0] = (Math.PI * (double)D / 1000.0 + 0.01) * (double)L / 1000.0 * 1.1;
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
				priceProduct = array[num, 0] * num2;
				num++;
				switch (markaStali)
				{
				case 1:
					materialName[num] = Consts2.lystOchynkovanyj07.MaterialName;
					num2 = Consts2.lystOchynkovanyj07.Price;
					break;
				case 2:
					materialName[num] = Consts2.lystStalnyj08.MaterialName;
					num2 = Consts2.lystStalnyj08.Price;
					break;
				default:
				{
					CustomConst lystNerzavijuchyj26 = MaterialHelper.GetLystNerzavijuchyj(0.8, aisiType);
					materialName[num] = lystNerzavijuchyj26?.MaterialName ?? "Лист НЕРЖ ??, м2";
					num2 = lystNerzavijuchyj26.Price;
					break;
				}
				}
				array[num, 0] = ((double)D * (double)D / 1000000.0 + 0.0357) * 1.1;
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
				priceProduct += array[num, 0] * num2;
				num++;
				switch (markaStali)
				{
				case 1:
					materialName[num] = Consts2.lystOchynkovanyj09.MaterialName;
					num2 = Consts2.lystOchynkovanyj09.Price;
					break;
				case 2:
					materialName[num] = Consts2.lystStalnyj08.MaterialName;
					num2 = Consts2.lystStalnyj08.Price;
					break;
				default:
				{
					CustomConst lystNerzavijuchyj27 = MaterialHelper.GetLystNerzavijuchyj(0.8, aisiType);
					materialName[num] = lystNerzavijuchyj27?.MaterialName ?? "Лист НЕРЖ ??, м2";
					num2 = lystNerzavijuchyj27.Price;
					break;
				}
				}
				array[num, 0] = 0.05 * (double)D / 1000.0;
				array[num, 4] = array[num, 0] * (double)number;
				array[num, 5] = array[num, 4] * 7825.0 * 0.9 / 1000.0;
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
				if (array[num, 5] < 0.005)
				{
					array[num, 5] = Math.Round(1000.0 * array[num, 5]) / 1000.0;
				}
				else
				{
					array[num, 5] = Math.Round(100.0 * array[num, 5]) / 100.0;
				}
				priceProduct += array[num, 0] * num2;
				num++;
				materialName[num] = Consts2.kvadrat10.MaterialName;
				array[num, 0] = (double)(D + 130) / 1000.0 * 1.03;
				array[num, 1] = 0.03;
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
				priceProduct += array[num, 0] * Consts2.kvadrat10.Price;
				num++;
				materialName[num] = Consts2.polipropilen.MaterialName;
				array[num, 0] = 0.01;
				array[num, 1] = 0.03;
				array[num, 5] = array[num, 0] * (double)number;
				array[num, 3] = array[num, 5] * array[num, 1];
				priceProduct += array[num, 0] * Consts2.polipropilen.Price;
			}
			else if (D <= 630)
			{
				num++;
				switch (markaStali)
				{
				case 1:
					materialName[num] = Consts2.lystOchynkovanyj07.MaterialName;
					num2 = Consts2.lystOchynkovanyj07.Price;
					break;
				case 2:
					materialName[num] = Consts2.lystStalnyj08.MaterialName;
					num2 = Consts2.lystStalnyj08.Price;
					break;
				default:
				{
					CustomConst lystNerzavijuchyj28 = MaterialHelper.GetLystNerzavijuchyj(0.8, aisiType);
					materialName[num] = lystNerzavijuchyj28?.MaterialName ?? "Лист НЕРЖ ??, м2";
					num2 = lystNerzavijuchyj28.Price;
					break;
				}
				}
				if (L == 0)
				{
					L = 300;
				}
				array[num, 0] = ((Math.PI * (double)D / 1000.0 + 0.01) * (double)L / 1000.0 + 0.0357) * 1.1;
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
				priceProduct = array[num, 0] * num2;
				num++;
				switch (markaStali)
				{
				case 1:
					materialName[num] = Consts2.lystOchynkovanyj09.MaterialName;
					num2 = Consts2.lystOchynkovanyj09.Price;
					break;
				case 2:
					materialName[num] = Consts2.lystStalnyj08.MaterialName;
					num2 = Consts2.lystStalnyj08.Price;
					break;
				default:
				{
					CustomConst lystNerzavijuchyj29 = MaterialHelper.GetLystNerzavijuchyj(0.8, aisiType);
					materialName[num] = lystNerzavijuchyj29?.MaterialName ?? "Лист НЕРЖ ??, м2";
					num2 = lystNerzavijuchyj29.Price;
					break;
				}
				}
				array[num, 0] = (double)D * (double)D / 1000000.0 * 1.1 + 0.05 * (double)D / 1000.0 + 0.03;
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
				priceProduct += array[num, 0] * num2;
				num++;
				materialName[num] = Consts2.kvadrat10.MaterialName;
				array[num, 0] = (double)(D + 130) / 1000.0 * 1.03;
				array[num, 1] = 0.03;
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
				priceProduct += array[num, 0] * Consts2.kvadrat10.Price;
				num++;
				materialName[num] = Consts2.polipropilen.MaterialName;
				array[num, 0] = 0.01;
				array[num, 1] = 0.03;
				array[num, 5] = array[num, 0] * (double)number;
				array[num, 3] = array[num, 5] * array[num, 1];
				priceProduct += array[num, 0] * Consts2.polipropilen.Price;
			}
			break;
		case 3:
			if (D <= 315)
			{
				num++;
				switch (markaStali)
				{
				case 1:
					materialName[num] = Consts2.lystOchynkovanyj05.MaterialName;
					num2 = Consts2.lystOchynkovanyj05.Price;
					break;
				case 2:
					materialName[num] = Consts2.lystStalnyj05.MaterialName;
					num2 = Consts2.lystStalnyj05.Price;
					break;
				default:
				{
					CustomConst lystNerzavijuchyj30 = MaterialHelper.GetLystNerzavijuchyj(0.5, aisiType);
					materialName[num] = lystNerzavijuchyj30?.MaterialName ?? "Лист НЕРЖ ??, м2";
					num2 = lystNerzavijuchyj30.Price;
					break;
				}
				}
				array[num, 0] = (Math.PI * (double)D / 1000.0 + 0.01) * (double)L / 1000.0 * 1.1;
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
				priceProduct = array[num, 0] * num2;
				num++;
				switch (markaStali)
				{
				case 1:
					materialName[num] = Consts2.lystOchynkovanyj09.MaterialName;
					num2 = Consts2.lystOchynkovanyj09.Price;
					break;
				case 2:
					materialName[num] = Consts2.lystStalnyj08.MaterialName;
					num2 = Consts2.lystStalnyj08.Price;
					break;
				default:
				{
					CustomConst lystNerzavijuchyj31 = MaterialHelper.GetLystNerzavijuchyj(0.8, aisiType);
					materialName[num] = lystNerzavijuchyj31?.MaterialName ?? "Лист НЕРЖ ??, м2";
					num2 = lystNerzavijuchyj31.Price;
					break;
				}
				}
				array[num, 0] = (double)D * (double)D / 1000000.0 * 1.1 + 0.05 * (double)D / 1000.0 + 0.03;
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
				priceProduct += array[num, 0] * num2;
				num++;
				materialName[num] = Consts2.lystOchynkovanyj15.MaterialName;
				array[num, 0] = 0.01;
				array[num, 4] = array[num, 0] * (double)number;
				array[num, 5] = array[num, 4] * 7825.0 * 1.5 / 1000.0;
				priceProduct += array[num, 0] * Consts2.lystOchynkovanyj15.Price;
				num++;
				materialName[num] = Consts2.kvadrat10.MaterialName;
				array[num, 0] = (double)(D + 65) / 1000.0 * 1.03;
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
				num++;
				materialName[num] = Consts2.uschilnjuvach_ASS.MaterialName;
				array[num, 0] = Math.PI * (double)D / 1000.0 * 1.02;
				array[num, 1] = 0.02;
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
				priceProduct += array[num, 0] * Consts2.uschilnjuvach_ASS.Price;
			}
			else if (D <= 400)
			{
				num++;
				switch (markaStali)
				{
				case 1:
					materialName[num] = Consts2.lystOchynkovanyj07.MaterialName;
					num2 = Consts2.lystOchynkovanyj07.Price;
					break;
				case 2:
					materialName[num] = Consts2.lystStalnyj08.MaterialName;
					num2 = Consts2.lystStalnyj08.Price;
					break;
				default:
				{
					CustomConst lystNerzavijuchyj32 = MaterialHelper.GetLystNerzavijuchyj(0.8, aisiType);
					materialName[num] = lystNerzavijuchyj32?.MaterialName ?? "Лист НЕРЖ ??, м2";
					num2 = lystNerzavijuchyj32.Price;
					break;
				}
				}
				array[num, 0] = (Math.PI * (double)D / 1000.0 + 0.01) * (double)L / 1000.0 * 1.1;
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
				priceProduct = array[num, 0] * num2;
				num++;
				switch (markaStali)
				{
				case 1:
					materialName[num] = Consts2.lystOchynkovanyj09.MaterialName;
					num2 = Consts2.lystOchynkovanyj09.Price;
					break;
				case 2:
					materialName[num] = Consts2.lystStalnyj08.MaterialName;
					num2 = Consts2.lystStalnyj08.Price;
					break;
				default:
				{
					CustomConst lystNerzavijuchyj33 = MaterialHelper.GetLystNerzavijuchyj(0.8, aisiType);
					materialName[num] = lystNerzavijuchyj33?.MaterialName ?? "Лист НЕРЖ ??, м2";
					num2 = lystNerzavijuchyj33.Price;
					break;
				}
				}
				array[num, 0] = (double)D * (double)D / 1000000.0 * 1.1 + 0.05 * (double)D / 1000.0 + 0.03;
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
				priceProduct += array[num, 0] * num2;
				num++;
				materialName[num] = Consts2.lystStalnyj20.MaterialName;
				array[num, 0] = 0.01;
				array[num, 4] = array[num, 0] * (double)number;
				array[num, 5] = array[num, 4] * 7825.0 * 2.0 / 1000.0;
				priceProduct += array[num, 0] * Consts2.lystStalnyj20.Price;
				num++;
				materialName[num] = Consts2.kvadrat10.MaterialName;
				array[num, 0] = (double)(D + 65) / 1000.0 * 1.03;
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
				num++;
				materialName[num] = Consts2.uschilnjuvach_ASS.MaterialName;
				array[num, 0] = Math.PI * (double)D / 1000.0 * 1.02;
				array[num, 1] = 0.02;
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
				priceProduct += array[num, 0] * Consts2.uschilnjuvach_ASS.Price;
			}
			else if (D <= 630)
			{
				num++;
				switch (markaStali)
				{
				case 1:
					materialName[num] = Consts2.lystOchynkovanyj07.MaterialName;
					num2 = Consts2.lystOchynkovanyj07.Price;
					break;
				case 2:
					materialName[num] = Consts2.lystStalnyj08.MaterialName;
					num2 = Consts2.lystStalnyj08.Price;
					break;
				default:
				{
					CustomConst lystNerzavijuchyj34 = MaterialHelper.GetLystNerzavijuchyj(0.8, aisiType);
					materialName[num] = lystNerzavijuchyj34?.MaterialName ?? "Лист НЕРЖ ??, м2";
					num2 = lystNerzavijuchyj34.Price;
					break;
				}
				}
				if (L == 0)
				{
					L = 300;
				}
				array[num, 0] = (Math.PI * (double)D / 1000.0 + 0.01) * (double)L / 1000.0 * 1.1;
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
				priceProduct = array[num, 0] * num2;
				num++;
				switch (markaStali)
				{
				case 1:
					materialName[num] = Consts2.lystOchynkovanyj09.MaterialName;
					num2 = Consts2.lystOchynkovanyj09.Price;
					break;
				case 2:
					materialName[num] = Consts2.lystStalnyj08.MaterialName;
					num2 = Consts2.lystStalnyj08.Price;
					break;
				default:
				{
					CustomConst lystNerzavijuchyj35 = MaterialHelper.GetLystNerzavijuchyj(0.8, aisiType);
					materialName[num] = lystNerzavijuchyj35?.MaterialName ?? "Лист НЕРЖ ??, м2";
					num2 = lystNerzavijuchyj35.Price;
					break;
				}
				}
				array[num, 0] = 2.0 * (double)D * (double)D / 1000000.0 * 1.1 + 0.05 * (double)D / 1000.0 + 0.03;
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
				priceProduct += array[num, 0] * num2;
				num++;
				materialName[num] = Consts2.lystStalnyj20.MaterialName;
				array[num, 0] = 0.01;
				array[num, 4] = array[num, 0] * (double)number;
				array[num, 5] = array[num, 4] * 7825.0 * 2.0 / 1000.0;
				priceProduct += array[num, 0] * Consts2.lystStalnyj20.Price;
				num++;
				materialName[num] = Consts2.kvadrat10.MaterialName;
				array[num, 0] = (double)(D + 65) / 1000.0 * 1.03;
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
				num++;
				materialName[num] = Consts2.uschilnjuvach_ASS.MaterialName;
				array[num, 0] = Math.PI * (double)D / 1000.0 * 1.02;
				array[num, 1] = 0.02;
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
				priceProduct += array[num, 0] * Consts2.uschilnjuvach_ASS.Price;
			}
			break;
		case 4:
			if (D <= 315)
			{
				num++;
				switch (markaStali)
				{
				case 1:
					materialName[num] = Consts2.lystOchynkovanyj05.MaterialName;
					num2 = Consts2.lystOchynkovanyj05.Price;
					break;
				case 2:
					materialName[num] = Consts2.lystStalnyj05.MaterialName;
					num2 = Consts2.lystStalnyj05.Price;
					break;
				default:
				{
					CustomConst lystNerzavijuchyj36 = MaterialHelper.GetLystNerzavijuchyj(0.5, aisiType);
					materialName[num] = lystNerzavijuchyj36?.MaterialName ?? "Лист НЕРЖ ??, м2";
					num2 = lystNerzavijuchyj36.Price;
					break;
				}
				}
				array[num, 0] = (Math.PI * (double)D / 1000.0 + 0.01) * (double)L / 1000.0 * 1.1;
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
				priceProduct = array[num, 0] * num2;
				num++;
				switch (markaStali)
				{
				case 1:
					materialName[num] = Consts2.lystOchynkovanyj07.MaterialName;
					num2 = Consts2.lystOchynkovanyj07.Price;
					break;
				case 2:
					materialName[num] = Consts2.lystStalnyj08.MaterialName;
					num2 = Consts2.lystStalnyj08.Price;
					break;
				default:
				{
					CustomConst lystNerzavijuchyj37 = MaterialHelper.GetLystNerzavijuchyj(0.8, aisiType);
					materialName[num] = lystNerzavijuchyj37?.MaterialName ?? "Лист НЕРЖ ??, м2";
					num2 = lystNerzavijuchyj37.Price;
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
				priceProduct += array[num, 0] * num2;
				num++;
				switch (markaStali)
				{
				case 1:
					materialName[num] = Consts2.lystOchynkovanyj09.MaterialName;
					num2 = Consts2.lystOchynkovanyj09.Price;
					break;
				case 2:
					materialName[num] = Consts2.lystStalnyj08.MaterialName;
					num2 = Consts2.lystStalnyj08.Price;
					break;
				default:
				{
					CustomConst lystNerzavijuchyj38 = MaterialHelper.GetLystNerzavijuchyj(0.8, aisiType);
					materialName[num] = lystNerzavijuchyj38?.MaterialName ?? "Лист НЕРЖ ??, м2";
					num2 = lystNerzavijuchyj38.Price;
					break;
				}
				}
				array[num, 0] = 2.0 * (double)D * (double)D / 1000000.0 * 1.1 + 0.05 * (double)D / 1000.0;
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
				priceProduct += array[num, 0] * num2;
				num++;
				materialName[num] = Consts2.kvadrat10.MaterialName;
				array[num, 0] = (double)(D + 130) / 1000.0 * 1.03;
				array[num, 1] = 0.03;
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
				priceProduct += array[num, 0] * Consts2.kvadrat10.Price;
				num++;
				materialName[num] = Consts2.polipropilen.MaterialName;
				array[num, 0] = 0.01;
				array[num, 1] = 0.03;
				array[num, 5] = array[num, 0] * (double)number;
				array[num, 3] = array[num, 5] * array[num, 1];
				priceProduct += array[num, 0] * Consts2.polipropilen.Price;
				num++;
				materialName[num] = Consts2.uschilnjuvach_ASS.MaterialName;
				array[num, 0] = Math.PI * (double)D / 1000.0 * 1.02;
				array[num, 1] = 0.02;
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
				priceProduct += array[num, 0] * Consts2.uschilnjuvach_ASS.Price;
			}
			else if (D <= 400)
			{
				num++;
				switch (markaStali)
				{
				case 1:
					materialName[num] = Consts2.lystOchynkovanyj07.MaterialName;
					num2 = Consts2.lystOchynkovanyj07.Price;
					break;
				case 2:
					materialName[num] = Consts2.lystStalnyj08.MaterialName;
					num2 = Consts2.lystStalnyj08.Price;
					break;
				default:
				{
					CustomConst lystNerzavijuchyj39 = MaterialHelper.GetLystNerzavijuchyj(0.8, aisiType);
					materialName[num] = lystNerzavijuchyj39?.MaterialName ?? "Лист НЕРЖ ??, м2";
					num2 = lystNerzavijuchyj39.Price;
					break;
				}
				}
				array[num, 0] = ((Math.PI * (double)D / 1000.0 + 0.01) * (double)L / 1000.0 + 0.0357) * 1.1;
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
				priceProduct = array[num, 0] * num2;
				num++;
				switch (markaStali)
				{
				case 1:
					materialName[num] = Consts2.lystOchynkovanyj09.MaterialName;
					num2 = Consts2.lystOchynkovanyj09.Price;
					break;
				case 2:
					materialName[num] = Consts2.lystStalnyj08.MaterialName;
					num2 = Consts2.lystStalnyj08.Price;
					break;
				default:
				{
					CustomConst lystNerzavijuchyj40 = MaterialHelper.GetLystNerzavijuchyj(0.8, aisiType);
					materialName[num] = lystNerzavijuchyj40?.MaterialName ?? "Лист НЕРЖ ??, м2";
					num2 = lystNerzavijuchyj40.Price;
					break;
				}
				}
				array[num, 0] = 2.0 * (double)D * (double)D / 1000000.0 * 1.1 + 0.05 * (double)D / 1000.0;
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
				priceProduct += array[num, 0] * num2;
				num++;
				materialName[num] = Consts2.kvadrat10.MaterialName;
				array[num, 0] = (double)(D + 130) / 1000.0 * 1.03;
				array[num, 1] = 0.03;
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
				priceProduct += array[num, 0] * Consts2.kvadrat10.Price;
				num++;
				materialName[num] = Consts2.polipropilen.MaterialName;
				array[num, 0] = 0.01;
				array[num, 1] = 0.03;
				array[num, 5] = array[num, 0] * (double)number;
				array[num, 3] = array[num, 5] * array[num, 1];
				priceProduct += array[num, 0] * Consts2.polipropilen.Price;
				num++;
				materialName[num] = Consts2.uschilnjuvach_ASS.MaterialName;
				array[num, 0] = Math.PI * (double)D / 1000.0 * 1.02;
				array[num, 1] = 0.02;
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
				priceProduct += array[num, 0] * Consts2.uschilnjuvach_ASS.Price;
			}
			else if (D <= 630)
			{
				num++;
				switch (markaStali)
				{
				case 1:
					materialName[num] = Consts2.lystOchynkovanyj07.MaterialName;
					num2 = Consts2.lystOchynkovanyj07.Price;
					break;
				case 2:
					materialName[num] = Consts2.lystStalnyj08.MaterialName;
					num2 = Consts2.lystStalnyj08.Price;
					break;
				default:
				{
					CustomConst lystNerzavijuchyj41 = MaterialHelper.GetLystNerzavijuchyj(0.8, aisiType);
					materialName[num] = lystNerzavijuchyj41?.MaterialName ?? "Лист НЕРЖ ??, м2";
					num2 = lystNerzavijuchyj41.Price;
					break;
				}
				}
				if (L == 0)
				{
					L = 300;
				}
				array[num, 0] = ((Math.PI * (double)D / 1000.0 + 0.01) * (double)L / 1000.0 + 0.0357) * 1.1;
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
				priceProduct = array[num, 0] * num2;
				num++;
				switch (markaStali)
				{
				case 1:
					materialName[num] = Consts2.lystOchynkovanyj09.MaterialName;
					num2 = Consts2.lystOchynkovanyj09.Price;
					break;
				case 2:
					materialName[num] = Consts2.lystStalnyj08.MaterialName;
					num2 = Consts2.lystStalnyj08.Price;
					break;
				default:
				{
					CustomConst lystNerzavijuchyj42 = MaterialHelper.GetLystNerzavijuchyj(0.8, aisiType);
					materialName[num] = lystNerzavijuchyj42?.MaterialName ?? "Лист НЕРЖ ??, м2";
					num2 = lystNerzavijuchyj42.Price;
					break;
				}
				}
				array[num, 0] = 2.0 * (double)D * (double)D / 1000000.0 * 1.1 + 0.05 * (double)D / 1000.0;
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
				priceProduct += array[num, 0] * num2;
				num++;
				materialName[num] = Consts2.kvadrat10.MaterialName;
				array[num, 0] = (double)(D + 130) / 1000.0 * 1.03;
				array[num, 1] = 0.03;
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
				priceProduct += array[num, 0] * Consts2.kvadrat10.Price;
				num++;
				materialName[num] = Consts2.polipropilen.MaterialName;
				array[num, 0] = 0.01;
				array[num, 1] = 0.03;
				array[num, 5] = array[num, 0] * (double)number;
				array[num, 3] = array[num, 5] * array[num, 1];
				priceProduct += array[num, 0] * Consts2.polipropilen.Price;
				num++;
				materialName[num] = Consts2.uschilnjuvach_ASS.MaterialName;
				array[num, 0] = Math.PI * (double)D / 1000.0 * 1.02;
				array[num, 1] = 0.02;
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
				priceProduct += array[num, 0] * Consts2.uschilnjuvach_ASS.Price;
			}
			break;
		case 5:
			if (D <= 315)
			{
				num++;
				switch (markaStali)
				{
				case 1:
					materialName[num] = Consts2.lystOchynkovanyj05.MaterialName;
					num2 = Consts2.lystOchynkovanyj05.Price;
					break;
				case 2:
					materialName[num] = Consts2.lystStalnyj05.MaterialName;
					num2 = Consts2.lystStalnyj05.Price;
					break;
				default:
				{
					CustomConst lystNerzavijuchyj8 = MaterialHelper.GetLystNerzavijuchyj(0.5, aisiType);
					materialName[num] = lystNerzavijuchyj8?.MaterialName ?? "Лист НЕРЖ ??, м2";
					num2 = lystNerzavijuchyj8.Price;
					break;
				}
				}
				if (L == 0)
				{
					L = 150;
				}
				array[num, 0] = ((Math.PI * (double)D / 1000.0 + 0.01) * (double)L / 1000.0 + (double)D * (double)D / 1000000.0) * 1.1;
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
				priceProduct = array[num, 0] * num2;
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
			}
			break;
		case 6:
			if (D <= 315)
			{
				num++;
				switch (markaStali)
				{
				case 1:
					materialName[num] = Consts2.lystOchynkovanyj05.MaterialName;
					num2 = Consts2.lystOchynkovanyj05.Price;
					break;
				case 2:
					materialName[num] = Consts2.lystStalnyj05.MaterialName;
					num2 = Consts2.lystStalnyj05.Price;
					break;
				default:
				{
					CustomConst lystNerzavijuchyj9 = MaterialHelper.GetLystNerzavijuchyj(0.5, aisiType);
					materialName[num] = lystNerzavijuchyj9?.MaterialName ?? "Лист НЕРЖ ??, м2";
					num2 = lystNerzavijuchyj9.Price;
					break;
				}
				}
				array[num, 0] = ((Math.PI * (double)D / 1000.0 + 0.01) * (double)L / 1000.0 + (double)D * (double)D / 1000000.0) * 1.1;
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
				priceProduct = array[num, 0] * num2;
				num++;
				switch (markaStali)
				{
				case 1:
					materialName[num] = Consts2.lystOchynkovanyj09.MaterialName;
					num2 = Consts2.lystOchynkovanyj09.Price;
					break;
				case 2:
					materialName[num] = Consts2.lystStalnyj08.MaterialName;
					num2 = Consts2.lystStalnyj08.Price;
					break;
				default:
				{
					CustomConst lystNerzavijuchyj10 = MaterialHelper.GetLystNerzavijuchyj(0.8, aisiType);
					materialName[num] = lystNerzavijuchyj10?.MaterialName ?? "Лист НЕРЖ ??, м2";
					num2 = lystNerzavijuchyj10.Price;
					break;
				}
				}
				array[num, 0] = 0.05 * (double)D / 1000.0 + 0.03;
				array[num, 1] = 0.05;
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
				priceProduct += array[num, 0] * num2;
				num++;
				materialName[num] = Consts2.lystOchynkovanyj15.MaterialName;
				array[num, 0] = 0.01;
				array[num, 4] = array[num, 0] * (double)number;
				array[num, 5] = array[num, 4] * 7825.0 * 1.5 / 1000.0;
				priceProduct += array[num, 0] * Consts2.lystOchynkovanyj15.Price;
				num++;
				materialName[num] = Consts2.kvadrat10.MaterialName;
				array[num, 0] = (double)(D + 65) / 1000.0 * 1.03;
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
				array[num, 0] = 0.02;
				array[num, 4] = array[num, 0] * (double)number;
				priceProduct += array[num, 0] * Consts2.kruh24.Price;
				num++;
				materialName[num] = Consts2.kruh18LC59.MaterialName;
				array[num, 0] = 0.02;
				array[num, 4] = array[num, 0] * (double)number;
				priceProduct += array[num, 0] * Consts2.kruh18LC59.Price;
				num++;
				materialName[num] = Consts2.ftoroplastF20.MaterialName;
				array[num, 0] = 0.01;
				array[num, 4] = array[num, 0] * (double)number;
				priceProduct += array[num, 0] * Consts2.ftoroplastF20.Price;
			}
			else if (D <= 400)
			{
				num++;
				switch (markaStali)
				{
				case 1:
					materialName[num] = Consts2.lystOchynkovanyj05.MaterialName;
					num2 = Consts2.lystOchynkovanyj05.Price;
					break;
				case 2:
					materialName[num] = Consts2.lystStalnyj05.MaterialName;
					num2 = Consts2.lystStalnyj05.Price;
					break;
				default:
				{
					CustomConst lystNerzavijuchyj11 = MaterialHelper.GetLystNerzavijuchyj(0.5, aisiType);
					materialName[num] = lystNerzavijuchyj11?.MaterialName ?? "Лист НЕРЖ ??, м2";
					num2 = lystNerzavijuchyj11.Price;
					break;
				}
				}
				array[num, 0] = (Math.PI * (double)D / 1000.0 + 0.01) * (double)L / 1000.0 * 1.1;
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
				priceProduct = array[num, 0] * num2;
				num++;
				switch (markaStali)
				{
				case 1:
					materialName[num] = Consts2.lystOchynkovanyj07.MaterialName;
					num2 = Consts2.lystOchynkovanyj07.Price;
					break;
				case 2:
					materialName[num] = Consts2.lystStalnyj08.MaterialName;
					num2 = Consts2.lystStalnyj08.Price;
					break;
				default:
				{
					CustomConst lystNerzavijuchyj12 = MaterialHelper.GetLystNerzavijuchyj(0.8, aisiType);
					materialName[num] = lystNerzavijuchyj12?.MaterialName ?? "Лист НЕРЖ ??, м2";
					num2 = lystNerzavijuchyj12.Price;
					break;
				}
				}
				array[num, 0] = (double)D * (double)D / 1000000.0 * 1.1;
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
				priceProduct += array[num, 0] * num2;
				num++;
				switch (markaStali)
				{
				case 1:
					materialName[num] = Consts2.lystOchynkovanyj09.MaterialName;
					num2 = Consts2.lystOchynkovanyj09.Price;
					break;
				case 2:
					materialName[num] = Consts2.lystStalnyj08.MaterialName;
					num2 = Consts2.lystStalnyj08.Price;
					break;
				default:
				{
					CustomConst lystNerzavijuchyj13 = MaterialHelper.GetLystNerzavijuchyj(0.8, aisiType);
					materialName[num] = lystNerzavijuchyj13?.MaterialName ?? "Лист НЕРЖ ??, м2";
					num2 = lystNerzavijuchyj13.Price;
					break;
				}
				}
				array[num, 0] = 0.05 * (double)D / 1000.0 + 0.03;
				array[num, 1] = 0.05;
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
				priceProduct += array[num, 0] * num2;
				num++;
				materialName[num] = Consts2.lystStalnyj20.MaterialName;
				array[num, 0] = 0.01;
				array[num, 4] = array[num, 0] * (double)number;
				array[num, 5] = array[num, 4] * 7825.0 * 2.0 / 1000.0;
				priceProduct += array[num, 0] * Consts2.lystStalnyj20.Price;
				num++;
				materialName[num] = Consts2.kvadrat10.MaterialName;
				array[num, 0] = (double)(D + 65) / 1000.0 * 1.03;
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
				array[num, 0] = 0.02;
				array[num, 4] = array[num, 0] * (double)number;
				priceProduct += array[num, 0] * Consts2.kruh24.Price;
				num++;
				materialName[num] = Consts2.kruh18LC59.MaterialName;
				array[num, 0] = 0.02;
				array[num, 4] = array[num, 0] * (double)number;
				priceProduct += array[num, 0] * Consts2.kruh18LC59.Price;
				num++;
				materialName[num] = Consts2.ftoroplastF20.MaterialName;
				array[num, 0] = 0.01;
				array[num, 4] = array[num, 0] * (double)number;
				priceProduct += array[num, 0] * Consts2.ftoroplastF20.Price;
			}
			else if (D <= 630)
			{
				num++;
				switch (markaStali)
				{
				case 1:
					materialName[num] = Consts2.lystOchynkovanyj07.MaterialName;
					num2 = Consts2.lystOchynkovanyj07.Price;
					break;
				case 2:
					materialName[num] = Consts2.lystStalnyj08.MaterialName;
					num2 = Consts2.lystStalnyj08.Price;
					break;
				default:
				{
					CustomConst lystNerzavijuchyj14 = MaterialHelper.GetLystNerzavijuchyj(0.8, aisiType);
					materialName[num] = lystNerzavijuchyj14?.MaterialName ?? "Лист НЕРЖ ??, м2";
					num2 = lystNerzavijuchyj14.Price;
					break;
				}
				}
				if (L == 0)
				{
					L = 300;
				}
				array[num, 0] = (Math.PI * (double)D / 1000.0 + 0.01) * (double)L / 1000.0 * 1.1;
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
				priceProduct = array[num, 0] * num2;
				num++;
				switch (markaStali)
				{
				case 1:
					materialName[num] = Consts2.lystOchynkovanyj09.MaterialName;
					num2 = Consts2.lystOchynkovanyj09.Price;
					break;
				case 2:
					materialName[num] = Consts2.lystStalnyj08.MaterialName;
					num2 = Consts2.lystStalnyj08.Price;
					break;
				default:
				{
					CustomConst lystNerzavijuchyj15 = MaterialHelper.GetLystNerzavijuchyj(0.8, aisiType);
					materialName[num] = lystNerzavijuchyj15?.MaterialName ?? "Лист НЕРЖ ??, м2";
					num2 = lystNerzavijuchyj15.Price;
					break;
				}
				}
				array[num, 0] = (double)D * (double)D / 1000000.0 * 1.1 + 0.05 * (double)D / 1000.0 + 0.03;
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
				priceProduct += array[num, 0] * num2;
				num++;
				materialName[num] = Consts2.lystStalnyj20.MaterialName;
				array[num, 0] = 0.01;
				array[num, 4] = array[num, 0] * (double)number;
				array[num, 5] = array[num, 4] * 7825.0 * 2.0 / 1000.0;
				priceProduct += array[num, 0] * Consts2.lystStalnyj20.Price;
				num++;
				materialName[num] = Consts2.kvadrat10.MaterialName;
				array[num, 0] = (double)(D + 65) / 1000.0 * 1.03;
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
				array[num, 0] = 0.02;
				array[num, 4] = array[num, 0] * (double)number;
				priceProduct += array[num, 0] * Consts2.kruh24.Price;
				num++;
				materialName[num] = Consts2.kruh18LC59.MaterialName;
				array[num, 0] = 0.02;
				array[num, 4] = array[num, 0] * (double)number;
				priceProduct += array[num, 0] * Consts2.kruh18LC59.Price;
				num++;
				materialName[num] = Consts2.ftoroplastF20.MaterialName;
				array[num, 0] = 0.01;
				array[num, 4] = array[num, 0] * (double)number;
				priceProduct += array[num, 0] * Consts2.ftoroplastF20.Price;
			}
			break;
		case 7:
			if (D <= 315)
			{
				num++;
				switch (markaStali)
				{
				case 1:
					materialName[num] = Consts2.lystOchynkovanyj05.MaterialName;
					num2 = Consts2.lystOchynkovanyj05.Price;
					break;
				case 2:
					materialName[num] = Consts2.lystStalnyj05.MaterialName;
					num2 = Consts2.lystStalnyj05.Price;
					break;
				default:
				{
					CustomConst lystNerzavijuchyj50 = MaterialHelper.GetLystNerzavijuchyj(0.5, aisiType);
					materialName[num] = lystNerzavijuchyj50?.MaterialName ?? "Лист НЕРЖ ??, м2";
					num2 = lystNerzavijuchyj50.Price;
					break;
				}
				}
				array[num, 0] = ((Math.PI * (double)D / 1000.0 + 0.01) * (double)L / 1000.0 + (double)D * (double)D / 1000000.0) * 1.1;
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
				priceProduct = array[num, 0] * num2;
				num++;
				switch (markaStali)
				{
				case 1:
					materialName[num] = Consts2.lystOchynkovanyj07.MaterialName;
					num2 = Consts2.lystOchynkovanyj07.Price;
					break;
				case 2:
					materialName[num] = Consts2.lystStalnyj08.MaterialName;
					num2 = Consts2.lystStalnyj08.Price;
					break;
				default:
				{
					CustomConst lystNerzavijuchyj51 = MaterialHelper.GetLystNerzavijuchyj(0.8, aisiType);
					materialName[num] = lystNerzavijuchyj51?.MaterialName ?? "Лист НЕРЖ ??, м2";
					num2 = lystNerzavijuchyj51.Price;
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
				priceProduct += array[num, 0] * num2;
				num++;
				switch (markaStali)
				{
				case 1:
					materialName[num] = Consts2.lystOchynkovanyj09.MaterialName;
					num2 = Consts2.lystOchynkovanyj09.Price;
					break;
				case 2:
					materialName[num] = Consts2.lystStalnyj08.MaterialName;
					num2 = Consts2.lystStalnyj08.Price;
					break;
				default:
				{
					CustomConst lystNerzavijuchyj52 = MaterialHelper.GetLystNerzavijuchyj(0.8, aisiType);
					materialName[num] = lystNerzavijuchyj52?.MaterialName ?? "Лист НЕРЖ ??, м2";
					num2 = lystNerzavijuchyj52.Price;
					break;
				}
				}
				array[num, 0] = 0.05 * (double)D / 1000.0;
				array[num, 1] = 0.05;
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
				priceProduct += array[num, 0] * num2;
				num++;
				materialName[num] = Consts2.kvadrat10.MaterialName;
				array[num, 0] = (double)(D + 130) / 1000.0 * 1.03;
				array[num, 1] = 0.03;
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
				priceProduct += array[num, 0] * Consts2.kvadrat10.Price;
				num++;
				materialName[num] = Consts2.kruh24.MaterialName;
				array[num, 0] = 0.02;
				array[num, 4] = array[num, 0] * (double)number;
				priceProduct += array[num, 0] * Consts2.kruh24.Price;
				num++;
				materialName[num] = Consts2.kruh18LC59.MaterialName;
				array[num, 0] = 0.02;
				array[num, 4] = array[num, 0] * (double)number;
				priceProduct += array[num, 0] * Consts2.kruh18LC59.Price;
				num++;
				materialName[num] = Consts2.ftoroplastF20.MaterialName;
				array[num, 0] = 0.01;
				array[num, 4] = array[num, 0] * (double)number;
				priceProduct += array[num, 0] * Consts2.ftoroplastF20.Price;
			}
			else if (D <= 400)
			{
				num++;
				switch (markaStali)
				{
				case 1:
					materialName[num] = Consts2.lystOchynkovanyj05.MaterialName;
					num2 = Consts2.lystOchynkovanyj05.Price;
					break;
				case 2:
					materialName[num] = Consts2.lystStalnyj05.MaterialName;
					num2 = Consts2.lystStalnyj05.Price;
					break;
				default:
				{
					CustomConst lystNerzavijuchyj53 = MaterialHelper.GetLystNerzavijuchyj(0.5, aisiType);
					materialName[num] = lystNerzavijuchyj53?.MaterialName ?? "Лист НЕРЖ ??, м2";
					num2 = lystNerzavijuchyj53.Price;
					break;
				}
				}
				array[num, 0] = (Math.PI * (double)D / 1000.0 + 0.01) * (double)L / 1000.0 * 1.1;
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
				priceProduct = array[num, 0] * num2;
				num++;
				switch (markaStali)
				{
				case 1:
					materialName[num] = Consts2.lystOchynkovanyj07.MaterialName;
					num2 = Consts2.lystOchynkovanyj07.Price;
					break;
				case 2:
					materialName[num] = Consts2.lystStalnyj08.MaterialName;
					num2 = Consts2.lystStalnyj08.Price;
					break;
				default:
				{
					CustomConst lystNerzavijuchyj54 = MaterialHelper.GetLystNerzavijuchyj(0.8, aisiType);
					materialName[num] = lystNerzavijuchyj54?.MaterialName ?? "Лист НЕРЖ ??, м2";
					num2 = lystNerzavijuchyj54.Price;
					break;
				}
				}
				array[num, 0] = ((double)D * (double)D / 1000000.0 + 0.0357) * 1.1;
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
				priceProduct += array[num, 0] * num2;
				num++;
				switch (markaStali)
				{
				case 1:
					materialName[num] = Consts2.lystOchynkovanyj09.MaterialName;
					num2 = Consts2.lystOchynkovanyj09.Price;
					break;
				case 2:
					materialName[num] = Consts2.lystStalnyj08.MaterialName;
					num2 = Consts2.lystStalnyj08.Price;
					break;
				default:
				{
					CustomConst lystNerzavijuchyj55 = MaterialHelper.GetLystNerzavijuchyj(0.8, aisiType);
					materialName[num] = lystNerzavijuchyj55?.MaterialName ?? "Лист НЕРЖ ??, м2";
					num2 = lystNerzavijuchyj55.Price;
					break;
				}
				}
				array[num, 0] = 0.05 * (double)D / 1000.0;
				array[num, 1] = 0.05;
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
				priceProduct += array[num, 0] * num2;
				num++;
				materialName[num] = Consts2.kvadrat10.MaterialName;
				array[num, 0] = (double)(D + 130) / 1000.0 * 1.03;
				array[num, 1] = 0.03;
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
				priceProduct += array[num, 0] * Consts2.kvadrat10.Price;
				num++;
				materialName[num] = Consts2.kruh24.MaterialName;
				array[num, 0] = 0.02;
				array[num, 4] = array[num, 0] * (double)number;
				priceProduct += array[num, 0] * Consts2.kruh24.Price;
				num++;
				materialName[num] = Consts2.kruh18LC59.MaterialName;
				array[num, 0] = 0.02;
				array[num, 4] = array[num, 0] * (double)number;
				priceProduct += array[num, 0] * Consts2.kruh18LC59.Price;
				num++;
				materialName[num] = Consts2.ftoroplastF20.MaterialName;
				array[num, 0] = 0.01;
				array[num, 4] = array[num, 0] * (double)number;
				priceProduct += array[num, 0] * Consts2.ftoroplastF20.Price;
			}
			else if (D <= 630)
			{
				num++;
				switch (markaStali)
				{
				case 1:
					materialName[num] = Consts2.lystOchynkovanyj07.MaterialName;
					num2 = Consts2.lystOchynkovanyj07.Price;
					break;
				case 2:
					materialName[num] = Consts2.lystStalnyj08.MaterialName;
					num2 = Consts2.lystStalnyj08.Price;
					break;
				default:
				{
					CustomConst lystNerzavijuchyj56 = MaterialHelper.GetLystNerzavijuchyj(0.8, aisiType);
					materialName[num] = lystNerzavijuchyj56?.MaterialName ?? "Лист НЕРЖ ??, м2";
					num2 = lystNerzavijuchyj56.Price;
					break;
				}
				}
				if (L == 0)
				{
					L = 300;
				}
				array[num, 0] = ((Math.PI * (double)D / 1000.0 + 0.01) * (double)L / 1000.0 + 0.0357) * 1.1;
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
				priceProduct = array[num, 0] * num2;
				num++;
				switch (markaStali)
				{
				case 1:
					materialName[num] = Consts2.lystOchynkovanyj09.MaterialName;
					num2 = Consts2.lystOchynkovanyj09.Price;
					break;
				case 2:
					materialName[num] = Consts2.lystStalnyj08.MaterialName;
					num2 = Consts2.lystStalnyj08.Price;
					break;
				default:
				{
					CustomConst lystNerzavijuchyj57 = MaterialHelper.GetLystNerzavijuchyj(0.8, aisiType);
					materialName[num] = lystNerzavijuchyj57?.MaterialName ?? "Лист НЕРЖ ??, м2";
					num2 = lystNerzavijuchyj57.Price;
					break;
				}
				}
				array[num, 0] = (double)D * (double)D / 1000000.0 * 1.1 + 0.05 * (double)D / 1000.0 + 0.03;
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
				priceProduct += array[num, 0] * num2;
				num++;
				materialName[num] = Consts2.kvadrat10.MaterialName;
				array[num, 0] = (double)(D + 130) / 1000.0 * 1.03;
				array[num, 1] = 0.03;
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
				priceProduct += array[num, 0] * Consts2.kvadrat10.Price;
				num++;
				materialName[num] = Consts2.kruh24.MaterialName;
				array[num, 0] = 0.02;
				array[num, 4] = array[num, 0] * (double)number;
				priceProduct += array[num, 0] * Consts2.kruh24.Price;
				num++;
				materialName[num] = Consts2.kruh18LC59.MaterialName;
				array[num, 0] = 0.02;
				array[num, 4] = array[num, 0] * (double)number;
				priceProduct += array[num, 0] * Consts2.kruh18LC59.Price;
				num++;
				materialName[num] = Consts2.ftoroplastF20.MaterialName;
				array[num, 0] = 0.01;
				array[num, 4] = array[num, 0] * (double)number;
				priceProduct += array[num, 0] * Consts2.ftoroplastF20.Price;
			}
			break;
		case 8:
			if (D <= 315)
			{
				num++;
				switch (markaStali)
				{
				case 1:
					materialName[num] = Consts2.lystOchynkovanyj05.MaterialName;
					num2 = Consts2.lystOchynkovanyj05.Price;
					break;
				case 2:
					materialName[num] = Consts2.lystStalnyj05.MaterialName;
					num2 = Consts2.lystStalnyj05.Price;
					break;
				default:
				{
					CustomConst lystNerzavijuchyj16 = MaterialHelper.GetLystNerzavijuchyj(0.5, aisiType);
					materialName[num] = lystNerzavijuchyj16?.MaterialName ?? "Лист НЕРЖ ??, м2";
					num2 = lystNerzavijuchyj16.Price;
					break;
				}
				}
				array[num, 0] = (Math.PI * (double)D / 1000.0 + 0.01) * (double)L / 1000.0 * 1.1;
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
				priceProduct = array[num, 0] * num2;
				num++;
				switch (markaStali)
				{
				case 1:
					materialName[num] = Consts2.lystOchynkovanyj09.MaterialName;
					num2 = Consts2.lystOchynkovanyj09.Price;
					break;
				case 2:
					materialName[num] = Consts2.lystStalnyj08.MaterialName;
					num2 = Consts2.lystStalnyj08.Price;
					break;
				default:
				{
					CustomConst lystNerzavijuchyj17 = MaterialHelper.GetLystNerzavijuchyj(0.8, aisiType);
					materialName[num] = lystNerzavijuchyj17?.MaterialName ?? "Лист НЕРЖ ??, м2";
					num2 = lystNerzavijuchyj17.Price;
					break;
				}
				}
				array[num, 0] = 2.0 * (double)D * (double)D / 1000000.0 * 1.1 + 0.05 * (double)D / 1000.0 + 0.03;
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
				priceProduct += array[num, 0] * num2;
				num++;
				materialName[num] = Consts2.lystStalnyj20.MaterialName;
				array[num, 0] = 0.01;
				array[num, 4] = array[num, 0] * (double)number;
				array[num, 5] = array[num, 4] * 7825.0 * 2.0 / 1000.0;
				priceProduct += array[num, 0] * Consts2.lystStalnyj20.Price;
				num++;
				materialName[num] = Consts2.kvadrat10.MaterialName;
				array[num, 0] = (double)(D + 65) / 1000.0 * 1.03;
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
				array[num, 0] = 0.02;
				array[num, 4] = array[num, 0] * (double)number;
				priceProduct += array[num, 0] * Consts2.kruh24.Price;
				num++;
				materialName[num] = Consts2.kruh18LC59.MaterialName;
				array[num, 0] = 0.02;
				array[num, 4] = array[num, 0] * (double)number;
				priceProduct += array[num, 0] * Consts2.kruh18LC59.Price;
				num++;
				materialName[num] = Consts2.ftoroplastF20.MaterialName;
				array[num, 0] = 0.01;
				array[num, 4] = array[num, 0] * (double)number;
				priceProduct += array[num, 0] * Consts2.ftoroplastF20.Price;
				num++;
				materialName[num] = Consts2.uschilnjuvach_ASS.MaterialName;
				array[num, 0] = Math.PI * (double)D / 1000.0 * 1.02;
				array[num, 1] = 0.02;
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
				priceProduct += array[num, 0] * Consts2.uschilnjuvach_ASS.Price;
			}
			else if (D <= 400)
			{
				num++;
				switch (markaStali)
				{
				case 1:
					materialName[num] = Consts2.lystOchynkovanyj07.MaterialName;
					num2 = Consts2.lystOchynkovanyj07.Price;
					break;
				case 2:
					materialName[num] = Consts2.lystStalnyj08.MaterialName;
					num2 = Consts2.lystStalnyj08.Price;
					break;
				default:
				{
					CustomConst lystNerzavijuchyj18 = MaterialHelper.GetLystNerzavijuchyj(0.8, aisiType);
					materialName[num] = lystNerzavijuchyj18?.MaterialName ?? "Лист НЕРЖ ??, м2";
					num2 = lystNerzavijuchyj18.Price;
					break;
				}
				}
				array[num, 0] = (Math.PI * (double)D / 1000.0 + 0.01) * (double)L / 1000.0 * 1.1;
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
				priceProduct = array[num, 0] * num2;
				num++;
				switch (markaStali)
				{
				case 1:
					materialName[num] = Consts2.lystOchynkovanyj09.MaterialName;
					num2 = Consts2.lystOchynkovanyj09.Price;
					break;
				case 2:
					materialName[num] = Consts2.lystStalnyj08.MaterialName;
					num2 = Consts2.lystStalnyj08.Price;
					break;
				default:
				{
					CustomConst lystNerzavijuchyj19 = MaterialHelper.GetLystNerzavijuchyj(0.8, aisiType);
					materialName[num] = lystNerzavijuchyj19?.MaterialName ?? "Лист НЕРЖ ??, м2";
					num2 = lystNerzavijuchyj19.Price;
					break;
				}
				}
				array[num, 0] = 2.0 * (double)D * (double)D / 1000000.0 * 1.1 + 0.05 * (double)D / 1000.0 + 0.03;
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
				priceProduct += array[num, 0] * num2;
				num++;
				materialName[num] = Consts2.lystStalnyj20.MaterialName;
				array[num, 0] = 0.01;
				array[num, 4] = array[num, 0] * (double)number;
				array[num, 5] = array[num, 4] * 7825.0 * 2.0 / 1000.0;
				priceProduct += array[num, 0] * Consts2.lystStalnyj20.Price;
				num++;
				materialName[num] = Consts2.kvadrat10.MaterialName;
				array[num, 0] = (double)(D + 65) / 1000.0 * 1.03;
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
				array[num, 0] = 0.02;
				array[num, 4] = array[num, 0] * (double)number;
				priceProduct += array[num, 0] * Consts2.kruh24.Price;
				num++;
				materialName[num] = Consts2.kruh18LC59.MaterialName;
				array[num, 0] = 0.02;
				array[num, 4] = array[num, 0] * (double)number;
				priceProduct += array[num, 0] * Consts2.kruh18LC59.Price;
				num++;
				materialName[num] = Consts2.ftoroplastF20.MaterialName;
				array[num, 0] = 0.01;
				array[num, 4] = array[num, 0] * (double)number;
				priceProduct += array[num, 0] * Consts2.ftoroplastF20.Price;
				num++;
				materialName[num] = Consts2.uschilnjuvach_ASS.MaterialName;
				array[num, 0] = Math.PI * (double)D / 1000.0 * 1.02;
				array[num, 1] = 0.02;
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
				priceProduct += array[num, 0] * Consts2.uschilnjuvach_ASS.Price;
			}
			else if (D <= 630)
			{
				num++;
				switch (markaStali)
				{
				case 1:
					materialName[num] = Consts2.lystOchynkovanyj07.MaterialName;
					num2 = Consts2.lystOchynkovanyj07.Price;
					break;
				case 2:
					materialName[num] = Consts2.lystStalnyj08.MaterialName;
					num2 = Consts2.lystStalnyj08.Price;
					break;
				default:
				{
					CustomConst lystNerzavijuchyj20 = MaterialHelper.GetLystNerzavijuchyj(0.8, aisiType);
					materialName[num] = lystNerzavijuchyj20?.MaterialName ?? "Лист НЕРЖ ??, м2";
					num2 = lystNerzavijuchyj20.Price;
					break;
				}
				}
				if (L == 0)
				{
					L = 300;
				}
				array[num, 0] = (Math.PI * (double)D / 1000.0 + 0.01) * (double)L / 1000.0 * 1.1;
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
				priceProduct = array[num, 0] * num2;
				num++;
				switch (markaStali)
				{
				case 1:
					materialName[num] = Consts2.lystOchynkovanyj09.MaterialName;
					num2 = Consts2.lystOchynkovanyj09.Price;
					break;
				case 2:
					materialName[num] = Consts2.lystStalnyj08.MaterialName;
					num2 = Consts2.lystStalnyj08.Price;
					break;
				default:
				{
					CustomConst lystNerzavijuchyj21 = MaterialHelper.GetLystNerzavijuchyj(0.8, aisiType);
					materialName[num] = lystNerzavijuchyj21?.MaterialName ?? "Лист НЕРЖ ??, м2";
					num2 = lystNerzavijuchyj21.Price;
					break;
				}
				}
				array[num, 0] = 2.0 * (double)D * (double)D / 1000000.0 * 1.1 + 0.05 * (double)D / 1000.0 + 0.03;
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
				priceProduct += array[num, 0] * num2;
				num++;
				materialName[num] = Consts2.lystStalnyj20.MaterialName;
				array[num, 0] = 0.01;
				array[num, 4] = array[num, 0] * (double)number;
				array[num, 5] = array[num, 4] * 7825.0 * 2.0 / 1000.0;
				priceProduct += array[num, 0] * Consts2.lystStalnyj20.Price;
				num++;
				materialName[num] = Consts2.kvadrat10.MaterialName;
				array[num, 0] = (double)(D + 65) / 1000.0 * 1.03;
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
				array[num, 0] = 0.02;
				array[num, 4] = array[num, 0] * (double)number;
				priceProduct += array[num, 0] * Consts2.kruh24.Price;
				num++;
				materialName[num] = Consts2.kruh18LC59.MaterialName;
				array[num, 0] = 0.02;
				array[num, 4] = array[num, 0] * (double)number;
				priceProduct += array[num, 0] * Consts2.kruh18LC59.Price;
				num++;
				materialName[num] = Consts2.ftoroplastF20.MaterialName;
				array[num, 0] = 0.01;
				array[num, 4] = array[num, 0] * (double)number;
				priceProduct += array[num, 0] * Consts2.ftoroplastF20.Price;
				num++;
				materialName[num] = Consts2.uschilnjuvach_ASS.MaterialName;
				array[num, 0] = Math.PI * (double)D / 1000.0 * 1.02;
				array[num, 1] = 0.02;
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
				priceProduct += array[num, 0] * Consts2.uschilnjuvach_ASS.Price;
			}
			break;
		case 9:
			if (D <= 315)
			{
				num++;
				switch (markaStali)
				{
				case 1:
					materialName[num] = Consts2.lystOchynkovanyj05.MaterialName;
					num2 = Consts2.lystOchynkovanyj05.Price;
					break;
				case 2:
					materialName[num] = Consts2.lystStalnyj05.MaterialName;
					num2 = Consts2.lystStalnyj05.Price;
					break;
				default:
				{
					CustomConst lystNerzavijuchyj = MaterialHelper.GetLystNerzavijuchyj(0.5, aisiType);
					materialName[num] = lystNerzavijuchyj?.MaterialName ?? "Лист НЕРЖ ??, м2";
					num2 = lystNerzavijuchyj.Price;
					break;
				}
				}
				array[num, 0] = (Math.PI * (double)D / 1000.0 + 0.01) * (double)L / 1000.0 * 1.1;
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
				priceProduct = array[num, 0] * num2;
				num++;
				switch (markaStali)
				{
				case 1:
					materialName[num] = Consts2.lystOchynkovanyj07.MaterialName;
					num2 = Consts2.lystOchynkovanyj07.Price;
					break;
				case 2:
					materialName[num] = Consts2.lystStalnyj08.MaterialName;
					num2 = Consts2.lystStalnyj08.Price;
					break;
				default:
				{
					CustomConst lystNerzavijuchyj2 = MaterialHelper.GetLystNerzavijuchyj(0.8, aisiType);
					materialName[num] = lystNerzavijuchyj2?.MaterialName ?? "Лист НЕРЖ ??, м2";
					num2 = lystNerzavijuchyj2.Price;
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
				priceProduct = array[num, 0] * num2;
				num++;
				switch (markaStali)
				{
				case 1:
					materialName[num] = Consts2.lystOchynkovanyj09.MaterialName;
					num2 = Consts2.lystOchynkovanyj09.Price;
					break;
				case 2:
					materialName[num] = Consts2.lystStalnyj08.MaterialName;
					num2 = Consts2.lystStalnyj08.Price;
					break;
				default:
				{
					CustomConst lystNerzavijuchyj3 = MaterialHelper.GetLystNerzavijuchyj(0.8, aisiType);
					materialName[num] = lystNerzavijuchyj3?.MaterialName ?? "Лист НЕРЖ ??, м2";
					num2 = lystNerzavijuchyj3.Price;
					break;
				}
				}
				array[num, 0] = 2.0 * (double)D * (double)D / 1000000.0 * 1.1 + 0.05 * (double)D / 1000.0;
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
				priceProduct += array[num, 0] * num2;
				num++;
				materialName[num] = Consts2.kvadrat10.MaterialName;
				array[num, 0] = (double)(D + 130) / 1000.0 * 1.03;
				array[num, 1] = 0.03;
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
				priceProduct += array[num, 0] * Consts2.kvadrat10.Price;
				num++;
				materialName[num] = Consts2.kruh24.MaterialName;
				array[num, 0] = 0.02;
				array[num, 4] = array[num, 0] * (double)number;
				priceProduct += array[num, 0] * Consts2.kruh24.Price;
				num++;
				materialName[num] = Consts2.kruh18LC59.MaterialName;
				array[num, 0] = 0.02;
				array[num, 4] = array[num, 0] * (double)number;
				priceProduct += array[num, 0] * Consts2.kruh18LC59.Price;
				num++;
				materialName[num] = Consts2.ftoroplastF20.MaterialName;
				array[num, 0] = 0.01;
				array[num, 4] = array[num, 0] * (double)number;
				priceProduct += array[num, 0] * Consts2.ftoroplastF20.Price;
				num++;
				materialName[num] = Consts2.uschilnjuvach_ASS.MaterialName;
				array[num, 0] = Math.PI * (double)D / 1000.0 * 1.02;
				array[num, 1] = 0.02;
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
				priceProduct += array[num, 0] * Consts2.uschilnjuvach_ASS.Price;
			}
			else if (D <= 400)
			{
				num++;
				switch (markaStali)
				{
				case 1:
					materialName[num] = Consts2.lystOchynkovanyj07.MaterialName;
					num2 = Consts2.lystOchynkovanyj07.Price;
					break;
				case 2:
					materialName[num] = Consts2.lystStalnyj08.MaterialName;
					num2 = Consts2.lystStalnyj08.Price;
					break;
				default:
				{
					CustomConst lystNerzavijuchyj4 = MaterialHelper.GetLystNerzavijuchyj(0.8, aisiType);
					materialName[num] = lystNerzavijuchyj4?.MaterialName ?? "Лист НЕРЖ ??, м2";
					num2 = lystNerzavijuchyj4.Price;
					break;
				}
				}
				array[num, 0] = ((Math.PI * (double)D / 1000.0 + 0.01) * (double)L / 1000.0 + 0.0357) * 1.1;
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
				priceProduct = array[num, 0] * num2;
				num++;
				switch (markaStali)
				{
				case 1:
					materialName[num] = Consts2.lystOchynkovanyj09.MaterialName;
					num2 = Consts2.lystOchynkovanyj09.Price;
					break;
				case 2:
					materialName[num] = Consts2.lystStalnyj08.MaterialName;
					num2 = Consts2.lystStalnyj08.Price;
					break;
				default:
				{
					CustomConst lystNerzavijuchyj5 = MaterialHelper.GetLystNerzavijuchyj(0.8, aisiType);
					materialName[num] = lystNerzavijuchyj5?.MaterialName ?? "Лист НЕРЖ ??, м2";
					num2 = lystNerzavijuchyj5.Price;
					break;
				}
				}
				array[num, 0] = 2.0 * (double)D * (double)D / 1000000.0 * 1.1 + 0.05 * (double)D / 1000.0;
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
				priceProduct += array[num, 0] * num2;
				num++;
				materialName[num] = Consts2.kvadrat10.MaterialName;
				array[num, 0] = (double)(D + 130) / 1000.0 * 1.03;
				array[num, 1] = 0.03;
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
				priceProduct += array[num, 0] * Consts2.kvadrat10.Price;
				num++;
				materialName[num] = Consts2.kruh24.MaterialName;
				array[num, 0] = 0.02;
				array[num, 4] = array[num, 0] * (double)number;
				priceProduct += array[num, 0] * Consts2.kruh24.Price;
				num++;
				materialName[num] = Consts2.kruh18LC59.MaterialName;
				array[num, 0] = 0.02;
				array[num, 4] = array[num, 0] * (double)number;
				priceProduct += array[num, 0] * Consts2.kruh18LC59.Price;
				num++;
				materialName[num] = Consts2.ftoroplastF20.MaterialName;
				array[num, 0] = 0.01;
				array[num, 4] = array[num, 0] * (double)number;
				priceProduct += array[num, 0] * Consts2.ftoroplastF20.Price;
				num++;
				materialName[num] = Consts2.uschilnjuvach_ASS.MaterialName;
				array[num, 0] = Math.PI * (double)D / 1000.0 * 1.02;
				array[num, 1] = 0.02;
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
				priceProduct += array[num, 0] * Consts2.uschilnjuvach_ASS.Price;
			}
			else if (D <= 630)
			{
				num++;
				switch (markaStali)
				{
				case 1:
					materialName[num] = Consts2.lystOchynkovanyj07.MaterialName;
					num2 = Consts2.lystOchynkovanyj07.Price;
					break;
				case 2:
					materialName[num] = Consts2.lystStalnyj08.MaterialName;
					num2 = Consts2.lystStalnyj08.Price;
					break;
				default:
				{
					CustomConst lystNerzavijuchyj6 = MaterialHelper.GetLystNerzavijuchyj(0.8, aisiType);
					materialName[num] = lystNerzavijuchyj6?.MaterialName ?? "Лист НЕРЖ ??, м2";
					num2 = lystNerzavijuchyj6.Price;
					break;
				}
				}
				if (L == 0)
				{
					L = 300;
				}
				array[num, 0] = ((Math.PI * (double)D / 1000.0 + 0.01) * (double)L / 1000.0 + 0.0357) * 1.1;
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
				priceProduct = array[num, 0] * num2;
				num++;
				switch (markaStali)
				{
				case 1:
					materialName[num] = Consts2.lystOchynkovanyj09.MaterialName;
					num2 = Consts2.lystOchynkovanyj09.Price;
					break;
				case 2:
					materialName[num] = Consts2.lystStalnyj08.MaterialName;
					num2 = Consts2.lystStalnyj08.Price;
					break;
				default:
				{
					CustomConst lystNerzavijuchyj7 = MaterialHelper.GetLystNerzavijuchyj(0.8, aisiType);
					materialName[num] = lystNerzavijuchyj7?.MaterialName ?? "Лист НЕРЖ ??, м2";
					num2 = lystNerzavijuchyj7.Price;
					break;
				}
				}
				array[num, 0] = 2.0 * (double)D * (double)D / 1000000.0 * 1.1 + 0.05 * (double)D / 1000.0;
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
				priceProduct += array[num, 0] * num2;
				num++;
				materialName[num] = Consts2.kvadrat10.MaterialName;
				array[num, 0] = (double)(D + 130) / 1000.0 * 1.03;
				array[num, 1] = 0.03;
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
				priceProduct += array[num, 0] * Consts2.kvadrat10.Price;
				num++;
				materialName[num] = Consts2.kruh24.MaterialName;
				array[num, 0] = 0.02;
				array[num, 4] = array[num, 0] * (double)number;
				priceProduct += array[num, 0] * Consts2.kruh24.Price;
				num++;
				materialName[num] = Consts2.kruh18LC59.MaterialName;
				array[num, 0] = 0.02;
				array[num, 4] = array[num, 0] * (double)number;
				priceProduct += array[num, 0] * Consts2.kruh18LC59.Price;
				num++;
				materialName[num] = Consts2.ftoroplastF20.MaterialName;
				array[num, 0] = 0.01;
				array[num, 4] = array[num, 0] * (double)number;
				priceProduct += array[num, 0] * Consts2.ftoroplastF20.Price;
				num++;
				materialName[num] = Consts2.uschilnjuvach_ASS.MaterialName;
				array[num, 0] = Math.PI * (double)D / 1000.0 * 1.02;
				array[num, 1] = 0.02;
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
				priceProduct += array[num, 0] * Consts2.uschilnjuvach_ASS.Price;
			}
			break;
		}
		double num3 = 0.0;
		if (servopryvid != 0)
		{
			num++;
			var (text, num4) = MaterialHelper.GetKlapanServopryvidData(servopryvid);
			materialName[num] = text;
			array[num, 0] = 1.0;
			array[num, 4] = array[num, 0] * (double)number;
			num3 = num4;
		}
		num++;
		CustomConst etyketkaKDK = GetEtyketkaKDK(D);
		if (etyketkaKDK != null)
		{
			materialName[num] = etyketkaKDK.MaterialName;
			array[num, 0] = 1.0;
			array[num, 4] = array[num, 0] * (double)number;
			priceProduct += array[num, 0] * etyketkaKDK.Price;
		}
		materialCost = priceProduct + num3;
		priceProduct *= 7.0;
		priceProduct += num3;
		return array;
	}

	public static double[,] FormPriceKlapanDroselnyjKDK()
	{
		double[,] array = new double[17, 2];
		int[] array2 = new int[17]
		{
			100, 125, 140, 150, 160, 180, 200, 225, 250, 280,
			315, 355, 400, 450, 500, 560, 630
		};
		double[,] array3 = new double[13, 6];
		for (int i = 0; i < 2; i++)
		{
			for (int j = 0; j < 17; j++)
			{
				array3 = MaterialKlapanDroselnyjKDK(array2[j], 0, 1, i + 1, 0);
				array[j, i] = priceProduct;
			}
			for (int k = 0; k < 11; k++)
			{
				array3 = MaterialKlapanDroselnyjKDK(array2[k + 6], 0, 1, i + 3, 0);
				priceKlapanDroselnyjKDZK[k, i] = priceProduct;
			}
		}
		return array;
	}

	public static double VolumeKlapanDroselnyjKDK(int D, int L)
	{
		return Math.Round(Math.PI * (double)D * (double)D * (double)L / 4000000.0) / 1000.0;
	}

	public static CustomConst GetEtyketkaKDK(int d)
	{
		if (d <= 100)
		{
			return Consts2.etyketkaKDK100;
		}
		if (d <= 125)
		{
			return Consts2.etyketkaKDK125;
		}
		if (d <= 150)
		{
			return Consts2.etyketkaKDK150;
		}
		if (d <= 160)
		{
			return Consts2.etyketkaKDK160;
		}
		if (d <= 200)
		{
			return Consts2.etyketkaKDK200;
		}
		if (d <= 250)
		{
			return Consts2.etyketkaKDK250;
		}
		if (d <= 315)
		{
			return Consts2.etyketkaKDK315;
		}
		if (d <= 355)
		{
			return Consts2.etyketkaKDK355;
		}
		if (d <= 400)
		{
			return Consts2.etyketkaKDK400;
		}
		return null;
	}
}
