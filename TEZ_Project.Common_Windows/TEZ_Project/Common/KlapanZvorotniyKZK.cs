using System;
using TEZ_Project.Common.Helpers;

namespace TEZ_Project.Common;

public static class KlapanZvorotniyKZK
{
	public static string[] materialName = new string[14]
	{
		"", "", "", "", "", "", "", "", "", "",
		"", "", "", ""
	};

	public static double materialCost;

	public static double priceProduct;

	public static double[,] MaterialKlapanZvorotniyKZK(int D, int L, int number)
	{
		double[,] array = new double[14, 6];
		materialName = new string[14]
		{
			"", "", "", "", "", "", "", "", "", "",
			"", "", "", ""
		};
		materialCost = 0.0;
		priceProduct = 0.0;
		int num = -1;
		if (D < 355)
		{
			num++;
			materialName[num] = Consts2.lystOchynkovanyj05.MaterialName;
			array[num, 0] = Math.PI * (double)D / 1000.0 * (double)L / 1000.0;
			array[num, 0] = array[num, 0] * 0.05 + array[num, 0];
			array[num, 1] = 0.1;
			array[num, 4] = array[num, 0] * (double)number;
			array[num, 5] = array[num, 4] * 7825.0 * 0.5 / 1000.0;
			array[num, 2] = array[num, 4] * array[num, 1];
			array[num, 3] = array[num, 5] * array[num, 1];
			array = MaterialHelper.RoundMaterialSpending(array, num);
			priceProduct = array[num, 0] * Consts2.lystOchynkovanyj05.Price;
		}
		else
		{
			num++;
			materialName[num] = Consts2.lystOchynkovanyj07.MaterialName;
			array[num, 0] = Math.PI * (double)D / 1000.0 * (double)L / 1000.0;
			array[num, 0] = array[num, 0] * 0.05 + array[num, 0];
			array[num, 1] = 0.05;
			array[num, 4] = array[num, 0] * (double)number;
			array[num, 5] = array[num, 4] * 7825.0 * 0.7 / 1000.0;
			array[num, 2] = array[num, 4] * array[num, 1];
			array[num, 3] = array[num, 5] * array[num, 1];
			array = MaterialHelper.RoundMaterialSpending(array, num);
			priceProduct += array[num, 0] * Consts2.lystOchynkovanyj07.Price;
		}
		num++;
		materialName[num] = Consts2.lystAljum03.MaterialName;
		array[num, 0] = (double)D / 1000.0 * (double)D / 1000.0;
		array[num, 0] = array[num, 0] * 0.05 + array[num, 0];
		array[num, 1] = 0.2;
		array[num, 4] = array[num, 0] * (double)number;
		array[num, 5] = array[num, 4] * 7625.0 / 1000.0;
		array[num, 2] = array[num, 4] * array[num, 1];
		array[num, 3] = array[num, 5] * array[num, 1];
		array = MaterialHelper.RoundMaterialSpending(array, num);
		priceProduct += array[num, 0] * Consts2.lystAljum03.Price;
		num++;
		materialName[num] = Consts2.drit2.MaterialName;
		array[num, 0] = (double)(D + 10) / 1000.0;
		array[num, 0] = array[num, 0] * 0.05 + array[num, 0];
		array[num, 1] = 0.05;
		array[num, 4] = array[num, 0] * (double)number;
		array[num, 5] = array[num, 4] * 0.07;
		array[num, 2] = array[num, 4] * array[num, 1];
		array[num, 3] = array[num, 5] * array[num, 1];
		array = MaterialHelper.RoundMaterialSpending(array, num);
		priceProduct += array[num, 0] * Consts2.drit2.Price;
		num++;
		materialName[num] = Consts2.pruzyna22.MaterialName;
		array[num, 0] = MaterialHelper.GetAmountOfPruzyn(D);
		array[num, 4] = array[num, 0] * (double)number;
		priceProduct += array[num, 0] * Consts2.pruzyna22.Price;
		num++;
		CustomConst hofrovstavka = MaterialHelper.GetHofrovstavka(D);
		if (hofrovstavka != null)
		{
			materialName[num] = hofrovstavka.MaterialName;
			array[num, 0] = 1.0;
			array[num, 4] = array[num, 0] * (double)number;
			priceProduct += array[num, 0] * hofrovstavka.Price;
		}
		num++;
		CustomConst etyketkaKZK = GetEtyketkaKZK(D);
		if (etyketkaKZK != null)
		{
			materialName[num] = etyketkaKZK.MaterialName;
			array[num, 0] = 1.0;
			array[num, 4] = array[num, 0] * (double)number;
			priceProduct += array[num, 0] * etyketkaKZK.Price;
		}
		num++;
		materialName[num] = Consts2.azot1.MaterialName;
		array[num, 0] = MaterialHelper.GetAzot(D);
		array[num, 4] = array[num, 0] * (double)number;
		priceProduct += array[num, 0] * Consts2.azot1.Price;
		materialCost = priceProduct;
		priceProduct *= 3.0;
		return array;
	}

	public static double[] FormPriceKlapanZvorotniyKZK()
	{
		double[] result = new double[13];
		int[] array = new int[13]
		{
			100, 125, 140, 150, 160, 180, 200, 225, 250, 280,
			315, 355, 400
		};
		double[,] array2 = new double[12, 6];
		return result;
	}

	public static double VolumeKlapanZvorotniyKZK(int D)
	{
		return Math.Round((double)D * (double)D * 140.0 / 1000000.0) / 1000.0;
	}

	public static CustomConst GetEtyketkaKZK(int d)
	{
		if (d <= 100)
		{
			return Consts2.etyketkaKZK100;
		}
		if (d <= 125)
		{
			return Consts2.etyketkaKZK125;
		}
		if (d <= 150)
		{
			return Consts2.etyketkaKZK150;
		}
		if (d <= 160)
		{
			return Consts2.etyketkaKZK160;
		}
		if (d <= 200)
		{
			return Consts2.etyketkaKZK200;
		}
		if (d <= 250)
		{
			return Consts2.etyketkaKZK250;
		}
		if (d <= 315)
		{
			return Consts2.etyketkaKZK315;
		}
		if (d <= 355)
		{
			return Consts2.etyketkaKZK355;
		}
		if (d <= 400)
		{
			return Consts2.etyketkaKZK400;
		}
		return null;
	}
}
