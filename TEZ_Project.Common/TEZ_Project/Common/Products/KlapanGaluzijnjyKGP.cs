using System;
using TEZ_Project.Common.Data;
using TEZ_Project.Common.Helpers;

namespace TEZ_Project.Common.Products;

public static class KlapanGaluzijnjyKGP
{
	public static string[] materialName = new string[20]
	{
		"", "", "", "", "", "", "", "", "", "",
		"", "", "", "", "", "", "", "", "", ""
	};

	public static double materialCost;

	public static double priceProduct;

	public static double[] priceKlapanGaluzijnjyKGP = new double[98];

	public static double[,] MaterialKlapanGaluzijnjyKGP(int B, int H, int number, int vydKGP, int servopryvid, int markaStali = 1, int typProfil = 0, string aisiType = "430", double tovchynaMetalu = 0.0)
	{
		double[,] array = new double[20, 6];
		int num = -1;
		double num2 = ((B >= H) ? B : H);
		double num3 = 0.0;
		markaStali = ((markaStali == 0) ? 1 : markaStali);
		materialName = new string[20]
		{
			"", "", "", "", "", "", "", "", "", "",
			"", "", "", "", "", "", "", "", "", ""
		};
		priceProduct = 0.0;
		materialCost = 0.0;
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
			CustomConst lystNerzavijuchyj = MaterialHelper.GetLystNerzavijuchyj(0.8, aisiType);
			materialName[num] = lystNerzavijuchyj?.MaterialName ?? "Лист НЕРЖ ??, м2";
			num3 = lystNerzavijuchyj.Price;
			break;
		}
		}
		array[num, 0] = 200.0 * (double)B * 1.05 / 1000000.0;
		array[num, 1] = 0.05;
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
			CustomConst lystNerzavijuchyj2 = MaterialHelper.GetLystNerzavijuchyj(0.8, aisiType);
			materialName[num] = lystNerzavijuchyj2?.MaterialName ?? "Лист НЕРЖ ??, м2";
			num3 = lystNerzavijuchyj2.Price;
			break;
		}
		}
		array[num, 0] = 2.0 * (double)(H + B + 30) * 0.175 / 1000.0 + 0.0188;
		array[num, 0] *= 1.05;
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
		priceProduct += array[num, 0] * num3;
		num++;
		materialName[num] = Consts2.lystStalnyj20.MaterialName;
		array[num, 0] = ((vydKGP == 1) ? 0.01 : 0.038);
		array[num, 4] = array[num, 0] * (double)number;
		array[num, 5] = array[num, 4] * 7825.0 * 2.0 / 1000.0;
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
		priceProduct += array[num, 0] * Consts2.lystStalnyj20.Price;
		num++;
		bool num4;
		if (typProfil == 0)
		{
			if (!(num2 >= 710.0))
			{
				goto IL_0dc1;
			}
			num4 = B + H > 1000;
		}
		else
		{
			num4 = typProfil == 2;
		}
		if (!num4)
		{
			goto IL_0dc1;
		}
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
		goto IL_112c;
		IL_0dc1:
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
		goto IL_112c;
		IL_112c:
		num++;
		materialName[num] = Consts2.profil0393.MaterialName;
		array[num, 0] = Math.Floor((double)H / 100.0) * (100.0 * Math.Ceiling((double)B / 100.0) - 24.0) / 1000.0;
		array[num, 0] *= 1.05;
		array[num, 1] = 0.05;
		array[num, 4] = array[num, 0] * (double)number;
		array[num, 5] = array[num, 4] * 0.8;
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
		priceProduct += array[num, 0] * Consts2.profil0393.Price;
		num++;
		materialName[num] = Consts2.kvadrat10.MaterialName;
		array[num, 0] = 0.21;
		array[num, 4] = array[num, 0] * (double)number;
		priceProduct += array[num, 0] * Consts2.kvadrat10.Price;
		num++;
		materialName[num] = Consts2.uschilnjuvach1166.MaterialName;
		array[num, 0] = (Math.Floor((double)H / 100.0) + 1.0) * (double)B * 1.05 / 1000.0;
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
		priceProduct += array[num, 0] * Consts2.uschilnjuvach1166.Price;
		if (vydKGP == 1)
		{
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
		}
		num++;
		materialName[num] = Consts2.polipropilen.MaterialName;
		array[num, 0] = 2.0 * Math.Floor((double)H / 100.0) * 0.065;
		array[num, 1] = 0.03;
		array[num, 5] = array[num, 0] * (double)number;
		array[num, 3] = array[num, 5] * array[num, 1];
		if (array[num, 0] < 0.005)
		{
			array[num, 0] = Math.Round(1000.0 * array[num, 0]) / 1000.0;
		}
		else
		{
			array[num, 0] = Math.Round(100.0 * array[num, 0]) / 100.0;
		}
		if (array[num, 3] < 0.005)
		{
			array[num, 3] = Math.Round(1000.0 * array[num, 3]) / 1000.0;
		}
		else
		{
			array[num, 3] = Math.Round(100.0 * array[num, 3]) / 100.0;
		}
		if (array[num, 5] < 0.005)
		{
			array[num, 5] = Math.Round(1000.0 * array[num, 5]) / 1000.0;
		}
		else
		{
			array[num, 5] = Math.Round(100.0 * array[num, 5]) / 100.0;
		}
		priceProduct += array[num, 0] * Consts2.polipropilen.Price;
		if (num2 > 1000.0)
		{
			num++;
			materialName[num] = Consts2.shpylkaM10.MaterialName;
			array[num, 0] = 2.0 * (double)(B + 50) * 1.15 / 1000.0;
			array[num, 1] = 0.15;
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
			priceProduct += array[num, 0] * Consts2.shpylkaM10.Price;
			num++;
			materialName[num] = Consts2.gajkaM10.MaterialName;
			array[num, 0] = 8.0;
			array[num, 4] = array[num, 0] * (double)number;
			priceProduct += array[num, 0] * Consts2.gajkaM10.Price;
			num++;
			materialName[num] = Consts2.shajbaF10.MaterialName;
			array[num, 0] = 8.0;
			array[num, 4] = array[num, 0] * (double)number;
			priceProduct += array[num, 0] * Consts2.shajbaF10.Price;
			num++;
			materialName[num] = Consts2.shajbaGroverF10.MaterialName;
			array[num, 0] = 8.0;
			array[num, 4] = array[num, 0] * (double)number;
			priceProduct += array[num, 0] * Consts2.shajbaGroverF10.Price;
		}
		double num5 = 0.0;
		if (servopryvid != 0)
		{
			num++;
			var (text, num6) = MaterialHelper.GetKlapanServopryvidData(servopryvid);
			materialName[num] = text;
			array[num, 0] = 1.0;
			array[num, 4] = array[num, 0] * (double)number;
			num5 = num6;
		}
		materialCost = priceProduct + num5;
		priceProduct *= 3.0;
		priceProduct += num5;
		return array;
	}

	public static double VolumeKlapanGaluzijnjyKGP(int B, int H)
	{
		return Math.Round((double)B * (double)H * 175.0 / 1000000.0) / 1000.0;
	}

	public static double[] FormPriceKlapanGaluzijnjyKGP()
	{
		double[] array = new double[98];
		int[] array2 = new int[98]
		{
			200, 250, 250, 315, 315, 315, 355, 355, 355, 355,
			400, 400, 400, 400, 400, 450, 450, 450, 450, 450,
			450, 500, 500, 500, 500, 500, 500, 500, 500, 560,
			560, 560, 560, 560, 560, 560, 560, 630, 630, 630,
			630, 630, 630, 630, 630, 710, 710, 710, 710, 710,
			710, 710, 710, 710, 710, 800, 800, 800, 800, 800,
			800, 800, 800, 800, 800, 800, 900, 900, 900, 900,
			900, 900, 900, 900, 900, 900, 900, 1000, 1000, 1000,
			1000, 1000, 1000, 1000, 1000, 1000, 1000, 1000, 1000, 1250,
			1250, 1250, 1250, 1250, 1250, 1250, 1250, 1250
		};
		int[] array3 = new int[98]
		{
			200, 200, 250, 200, 250, 315, 200, 250, 315, 355,
			200, 250, 315, 355, 400, 200, 250, 315, 355, 400,
			450, 200, 250, 315, 355, 400, 450, 500, 630, 250,
			315, 355, 400, 450, 500, 560, 630, 200, 250, 315,
			400, 450, 500, 560, 630, 200, 250, 315, 355, 400,
			450, 500, 560, 630, 710, 200, 250, 315, 355, 400,
			450, 500, 560, 630, 710, 800, 200, 315, 355, 400,
			450, 500, 560, 630, 710, 800, 900, 200, 315, 355,
			400, 450, 500, 560, 630, 710, 800, 900, 1000, 400,
			450, 500, 560, 630, 710, 800, 900, 1000
		};
		for (int i = 0; i < 98; i++)
		{
			MaterialKlapanGaluzijnjyKGP(array2[i], array3[i], 1, 1, 0);
			array[i] = priceProduct;
		}
		return array;
	}
}
