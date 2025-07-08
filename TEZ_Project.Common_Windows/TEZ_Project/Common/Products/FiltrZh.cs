using System;

namespace TEZ_Project.Common.Products;

public class FiltrZh
{
	public static string[] materialName = new string[1] { "" };

	public static double materialCost = 0.0;

	public static double materialSpendingCommercialOffer = 0.0;

	public static double priceProduct = 0.0;

	public static double[] MaterialFiltrZh(int B, int H, string markaStali, string tovchynaMetalu, int number)
	{
		double[] array = new double[6];
		double num = 0.0;
		int num2 = 0;
		double num3 = 0.0;
		double num4 = 5.0;
		double num5 = 0.0;
		if (markaStali == "AISI 304" || markaStali == "AISI 430" || markaStali == "AISI 201")
		{
			num = 7825.0;
		}
		else if (markaStali == "Оцинковка")
		{
			num = 7825.0;
		}
		switch (B)
		{
		case 300:
			num2 = 2;
			break;
		case 400:
			num2 = 3;
			break;
		case 500:
			num2 = 4;
			break;
		case 600:
			num2 = 5;
			break;
		}
		double num6 = (2.0 * (double)(B + H) * 0.115 + (double)H * (0.1 * (double)(2 * num2 + 1) + 0.22)) / 1000.0;
		switch (markaStali)
		{
		case "AISI 304":
			if (!(tovchynaMetalu == "0.5"))
			{
				if (tovchynaMetalu == "0.8")
				{
					materialName[0] = Consts2.lystNerzavijuchyj08_304.MaterialName;
					num3 = Consts2.lystNerzavijuchyj08_304.Price;
					num5 = 0.8;
				}
				else
				{
					materialName[0] = Consts2.lystNerzavijuchyj10_304.MaterialName;
					num3 = Consts2.lystNerzavijuchyj10_304.Price;
					num5 = 1.0;
				}
			}
			else
			{
				materialName[0] = Consts2.lystNerzavijuchyj05_304.MaterialName;
				num3 = Consts2.lystNerzavijuchyj05_304.Price;
				num5 = 0.5;
			}
			break;
		case "AISI 430":
			if (!(tovchynaMetalu == "0.5"))
			{
				if (tovchynaMetalu == "0.8")
				{
					materialName[0] = Consts2.lystNerzavijuchyj08.MaterialName;
					num3 = Consts2.lystNerzavijuchyj08.Price;
					num5 = 0.8;
				}
				else
				{
					materialName[0] = Consts2.lystNerzavijuchyj10.MaterialName;
					num3 = Consts2.lystNerzavijuchyj10.Price;
					num5 = 1.0;
				}
			}
			else
			{
				materialName[0] = Consts2.lystNerzavijuchyj05.MaterialName;
				num3 = Consts2.lystNerzavijuchyj05.Price;
				num5 = 0.5;
			}
			break;
		case "AISI 201":
			if (!(tovchynaMetalu == "0.5"))
			{
				if (tovchynaMetalu == "0.8")
				{
					materialName[0] = Consts2.lystNerzavijuchyj08_201.MaterialName;
					num3 = Consts2.lystNerzavijuchyj08_201.Price;
					num5 = 0.8;
				}
				else
				{
					materialName[0] = Consts2.lystNerzavijuchyj10_201.MaterialName;
					num3 = Consts2.lystNerzavijuchyj10_201.Price;
					num5 = 1.0;
				}
			}
			else
			{
				materialName[0] = Consts2.lystNerzavijuchyj05_201.MaterialName;
				num3 = Consts2.lystNerzavijuchyj05_201.Price;
				num5 = 0.5;
			}
			break;
		case "Оцинковка":
			switch (tovchynaMetalu)
			{
			case "0.5":
				materialName[0] = Consts2.lystOchynkovanyj05.MaterialName;
				num3 = Consts2.lystOchynkovanyj05.Price;
				num5 = 0.5;
				break;
			case "0.65":
				materialName[0] = Consts2.lystOchynkovanyj065.MaterialName;
				num3 = Consts2.lystOchynkovanyj065.Price;
				num5 = 0.65;
				break;
			case "0.68":
				materialName[0] = Consts2.lystOchynkovanyj068.MaterialName;
				num3 = Consts2.lystOchynkovanyj068.Price;
				num5 = 0.68;
				break;
			case "0.7":
				materialName[0] = Consts2.lystOchynkovanyj07.MaterialName;
				num3 = Consts2.lystOchynkovanyj07.Price;
				num5 = 0.7;
				break;
			case "0.9":
				materialName[0] = Consts2.lystOchynkovanyj09.MaterialName;
				num3 = Consts2.lystOchynkovanyj09.Price;
				num5 = 0.9;
				break;
			case "1.0":
				materialName[0] = Consts2.lystOchynkovanyj10.MaterialName;
				num3 = Consts2.lystOchynkovanyj10.Price;
				num5 = 1.0;
				break;
			case "1.2":
				materialName[0] = Consts2.lystOchynkovanyj12.MaterialName;
				num3 = Consts2.lystOchynkovanyj12.Price;
				num5 = 1.2;
				break;
			}
			break;
		}
		materialSpendingCommercialOffer = num6;
		if (materialSpendingCommercialOffer < 0.005)
		{
			materialSpendingCommercialOffer = Math.Round(1000.0 * materialSpendingCommercialOffer) / 1000.0;
		}
		else
		{
			materialSpendingCommercialOffer = Math.Round(100.0 * materialSpendingCommercialOffer) / 100.0;
		}
		priceProduct = materialSpendingCommercialOffer * num3 * 3.0;
		priceProduct = Math.Round(100.0 * priceProduct) / 100.0;
		array[0] = num6 * (1.0 + num4 / 100.0);
		materialCost = Math.Round(100.0 * num3 * array[0]) / 100.0;
		array[1] = num4 / 100.0;
		array[4] = array[0] * (double)number;
		array[5] = array[4] * num * num5 / 1000.0;
		array[2] = array[4] * array[1];
		array[3] = array[5] * array[1];
		for (int i = 0; i < 5; i++)
		{
			if (array[i] < 0.005)
			{
				array[i] = Math.Round(1000.0 * array[i]) / 1000.0;
			}
			else
			{
				array[i] = Math.Round(100.0 * array[i]) / 100.0;
			}
		}
		return array;
	}

	public static double VolumeFiltrZh(int B, int H)
	{
		return Math.Round(0.04 * (double)B * (double)H / 1000.0) / 1000.0;
	}
}
