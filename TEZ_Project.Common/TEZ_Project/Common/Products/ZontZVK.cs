using System;
using TEZ_Project.Common.Data;
using TEZ_Project.Common.Helpers;
using TEZ_Project;

namespace TEZ_Project.Common.Products;

public static class ZontZVK
{
	public static string[] materialName = new string[8] { "", "", "", "", "", "", "", "" };

	public static double materialCost;

	public static double[,] MaterialZontZVK(int D, int D1, int l, int markaStali, int typZVK, int typMaterialD, int number, string aisiType = "430")
	{
		double[,] array = new double[8, 6];
		double num = 0.0;
		double num2 = 0.0;
		double num3 = 0.0;
		materialName = new string[8] { "", "", "", "", "", "", "", "" };
		materialCost = 0.0;
		int num4 = ((D <= 630) ? 85 : 137);
		int num5 = ((D <= 100) ? 172 : ((D <= 110) ? 170 : ((D <= 130) ? 172 : ((D <= 140) ? 173 : ((D <= 150) ? 172 : ((D <= 160) ? 174 : ((D <= 180) ? 172 : ((D <= 315) ? 200 : ((D <= 400) ? 252 : ((D <= 630) ? 310 : ((D > 800) ? ((D <= 1000) ? 500 : 597) : 397)))))))))));
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
		int num6 = 0;
		double num7;
		double num8;
		if (D <= 400)
		{
			num2 = 0.5;
			switch (markaStali)
			{
			case 1:
				materialName[num6] = Consts2.lystOchynkovanyj05.MaterialName;
				num3 = Consts2.lystOchynkovanyj05.Price;
				break;
			case 2:
				materialName[num6] = Consts2.lystStalnyj05.MaterialName;
				num3 = Consts2.lystStalnyj05.Price;
				break;
			case 3:
			{
				CustomConst lystNerzavijuchyj = MaterialHelper.GetLystNerzavijuchyj(num2, aisiType);
				materialName[num6] = lystNerzavijuchyj?.MaterialName ?? "Лист НЕРЖ ??, м2";
				num3 = lystNerzavijuchyj.Price;
				break;
			}
			}
			num7 = Math.PI * (double)D * (double)num4;
			if (Math.PI * (double)D > 2500.0)
			{
				num7 += 60.0 * (double)num4;
			}
			else if (Math.PI * (double)D > 1250.0)
			{
				num7 += 30.0 * (double)num4;
			}
			num8 = Math.PI * (double)D1 / 2.0 * Math.Sqrt(Math.Pow(l, 2.0) + Math.Pow(D1 / 2, 2.0));
			array[num6, 0] = (num7 + num8) * 1.1 / 1000000.0;
			array[num6, 1] = 0.1;
			if (array[num6, 0] < 0.005)
			{
				array[num6, 0] = Math.Round(1000.0 * array[num6, 0]) / 1000.0;
			}
			else
			{
				array[num6, 0] = Math.Round(100.0 * array[num6, 0]) / 100.0;
			}
			array[num6, 4] = array[num6, 0] * (double)number;
			array[num6, 5] = array[num6, 4] * num * num2 / 1000.0;
			array[num6, 2] = array[num6, 4] * array[num6, 1];
			array[num6, 3] = array[num6, 5] * array[num6, 1];
		}
		else
		{
			num8 = ((D <= 800) ? (Math.PI * (double)D1 / 2.0 * Math.Sqrt(Math.Pow(l, 2.0) + Math.Pow(D1 / 2, 2.0))) : 0.0);
			if (D < 900)
			{
				switch (markaStali)
				{
				case 1:
					materialName[num6] = Consts2.lystOchynkovanyj07.MaterialName;
					num3 = Consts2.lystOchynkovanyj07.Price;
					num2 = 0.7;
					break;
				case 2:
					materialName[num6] = Consts2.lystStalnyj08.MaterialName;
					num3 = Consts2.lystStalnyj08.Price;
					num2 = 0.8;
					break;
				case 3:
				{
					num2 = 0.8;
					CustomConst lystNerzavijuchyj2 = MaterialHelper.GetLystNerzavijuchyj(num2, aisiType);
					materialName[num6] = lystNerzavijuchyj2?.MaterialName ?? "Лист НЕРЖ ??, м2";
					num3 = lystNerzavijuchyj2.Price;
					break;
				}
				}
				num7 = Math.PI * (double)D * (double)num4;
				if (Math.PI * (double)D > 2500.0)
				{
					num7 += 60.0 * (double)num4;
				}
				else if (Math.PI * (double)D > 1250.0)
				{
					num7 += 30.0 * (double)num4;
				}
				array[num6, 0] = (num7 + num8) * 1.1 / 1000000.0;
				array[num6, 1] = 0.1;
				if (array[num6, 0] < 0.005)
				{
					array[num6, 0] = Math.Round(1000.0 * array[num6, 0]) / 1000.0;
				}
				else
				{
					array[num6, 0] = Math.Round(100.0 * array[num6, 0]) / 100.0;
				}
				array[num6, 4] = array[num6, 0] * (double)number;
				array[num6, 5] = array[num6, 4] * num * num2 / 1000.0;
				array[num6, 2] = array[num6, 4] * array[num6, 1];
				array[num6, 3] = array[num6, 5] * array[num6, 1];
			}
		}
		materialCost = array[num6, 0] * num3;
		num6++;
		num2 = 1.0;
		switch (markaStali)
		{
		case 1:
			materialName[num6] = Consts2.lystOchynkovanyj10.MaterialName;
			num3 = Consts2.lystOchynkovanyj10.Price;
			break;
		case 2:
			materialName[num6] = Consts2.lystStalnyj10.MaterialName;
			num3 = Consts2.lystStalnyj10.Price;
			break;
		case 3:
		{
			CustomConst lystNerzavijuchyj3 = MaterialHelper.GetLystNerzavijuchyj(num2, aisiType);
			materialName[num6] = lystNerzavijuchyj3?.MaterialName ?? "Лист НЕРЖ ??, м2";
			num3 = lystNerzavijuchyj3.Price;
			break;
		}
		}
		if (D >= 900)
		{
			num7 = Math.PI * (double)D * (double)num4;
			if (Math.PI * (double)D > 2500.0)
			{
				num7 += 60.0 * (double)num4;
			}
			else if (Math.PI * (double)D > 1250.0)
			{
				num7 += 30.0 * (double)num4;
			}
		}
		else
		{
			num7 = 0.0;
		}
		int num9 = ((D <= 280) ? 3 : ((D > 400) ? ((D <= 800) ? 5 : 6) : 4));
		num7 += (double)((num5 + 50) * 50 * num9);
		num8 = ((D > 800) ? (Math.PI * (double)D1 / 2.0 * Math.Sqrt(Math.Pow(l, 2.0) + Math.Pow(D1 / 2, 2.0))) : 0.0);
		array[num6, 0] = (num7 + num8) * 1.1 / 1000000.0;
		array[num6, 1] = 0.1;
		if (array[num6, 0] < 0.005)
		{
			array[num6, 0] = Math.Round(1000.0 * array[num6, 0]) / 1000.0;
		}
		else
		{
			array[num6, 0] = Math.Round(100.0 * array[num6, 0]) / 100.0;
		}
		array[num6, 4] = array[num6, 0] * (double)number;
		array[num6, 5] = array[num6, 4] * num * num2 / 1000.0;
		array[num6, 2] = array[num6, 4] * array[num6, 1];
		array[num6, 3] = array[num6, 5] * array[num6, 1];
		materialCost += array[num6, 0] * num3;
		num6++;
		if (typZVK == 1)
		{
			double[,] array2 = new double[5, 6];
			array2 = FlanetsKruglyj.MaterialFlanetsKruglyj(D, typMaterialD, number, 1);
			materialCost += FlanetsKruglyj.materialCost1;
			for (int i = 0; i < 5; i++)
			{
				materialName[i + num6] = FlanetsKruglyj.materialName1[i];
				for (int j = 0; j < 6; j++)
				{
					array[i + num6, j] = array2[i, j];
				}
			}
		}
		return array;
	}

	public static double PriceZontZVK(int D, int D1, int l, int markaStali, int typZVK, int typMaterialD)
	{
		double num = 1.0;
		double num2 = 0.0;
		int num3 = ((D <= 630) ? 85 : 137);
		int num4 = ((D <= 100) ? 172 : ((D <= 110) ? 170 : ((D <= 130) ? 172 : ((D <= 140) ? 173 : ((D <= 150) ? 172 : ((D <= 160) ? 174 : ((D <= 180) ? 172 : ((D <= 315) ? 200 : ((D <= 400) ? 252 : ((D <= 630) ? 310 : ((D > 800) ? ((D <= 1000) ? 500 : 597) : 397)))))))))));
		double num5;
		double num6;
		if (D <= 400)
		{
			switch (markaStali)
			{
			case 1:
				num = 345.0;
				break;
			case 2:
				num = 115.0;
				break;
			case 3:
				num = 115.0;
				break;
			}
			num5 = Math.PI * (double)D * (double)num3;
			num6 = Math.PI * (double)D1 / 2.0 * Math.Sqrt(Math.Pow(l, 2.0) + Math.Pow(D1 / 2, 2.0));
			num2 += (num5 + num6) * num / 1000000.0;
		}
		else
		{
			num6 = ((D <= 800) ? (Math.PI * (double)D1 / 2.0 * Math.Sqrt(Math.Pow(l, 2.0) + Math.Pow(D1 / 2, 2.0))) : 0.0);
			if (D < 900)
			{
				switch (markaStali)
				{
				case 1:
					num = 406.0;
					break;
				case 2:
					num = 115.0;
					break;
				case 3:
					num = 134.78;
					break;
				}
				num5 = Math.PI * (double)D * (double)num3;
				num2 += (num5 + num6) * num / 1000000.0;
			}
		}
		switch (markaStali)
		{
		case 1:
			num = 520.0;
			break;
		case 2:
			num = 134.78;
			break;
		case 3:
			num = 173.19;
			break;
		}
		num5 = ((D >= 900) ? (Math.PI * (double)D * (double)num3) : 0.0);
		int num7 = ((D <= 280) ? 3 : ((D > 400) ? ((D <= 800) ? 5 : 6) : 4));
		num5 += (double)((num4 + 50) * 50 * num7);
		num6 = ((D > 800) ? (Math.PI * (double)D1 / 2.0 * Math.Sqrt(Math.Pow(l, 2.0) + Math.Pow(D1 / 2, 2.0))) : 0.0);
		num2 += (num5 + num6) * num / 1000000.0;
		if (typZVK == 1)
		{
			FlanetsKruglyj.MaterialFlanetsKruglyj(D, typMaterialD, 1, 1);
			num2 += FlanetsKruglyj.priceProduct1;
		}
		return num2;
	}

	public static double VolumeZontZVK(int D, int D1, int l)
	{
		int num = ((D <= 100) ? 172 : ((D <= 110) ? 170 : ((D <= 130) ? 172 : ((D <= 140) ? 173 : ((D <= 150) ? 172 : ((D <= 160) ? 174 : ((D <= 180) ? 172 : ((D <= 315) ? 200 : ((D <= 400) ? 252 : ((D <= 630) ? 310 : ((D > 800) ? ((D <= 1000) ? 500 : 597) : 397)))))))))));
		return Math.Round((double)D1 * (double)D1 * (double)(num + l) / 4000000.0) / 1000.0;
	}
}
