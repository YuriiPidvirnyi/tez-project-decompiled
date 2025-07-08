using System;

namespace TEZ_Project.Common.Products;

public static class RoundAirPSK
{
	public static string[] materialName = new string[2] { "", "" };

	public static double materialCost;

	public static double materialSpendingCommercialOffer = 0.0;

	public static double tovchynaMetaluCommercialOffer = 0.0;

	public static double[,] MaterialRoundAirFlowPSK(int D, int L, double tovchynaMetalu, int number)
	{
		double[,] array = new double[2, 6];
		double num = 7825.0;
		double num2 = 0.0;
		double num3 = 0.0;
		materialName = new string[2] { "", "" };
		materialCost = 0.0;
		array[0, 0] = Math.PI * (double)D * (double)L / 1000000.0;
		if (array[0, 0] < 0.005)
		{
			array[0, 0] = Math.Round(1000.0 * array[0, 0]) / 1000.0;
		}
		else
		{
			array[0, 0] = Math.Round(100.0 * array[0, 0]) / 100.0;
		}
		double num4 = tovchynaMetalu;
		double num5 = num4;
		if (num5 != 0.5)
		{
			if (num5 != 0.65)
			{
				if (num5 != 0.68)
				{
					if (num5 != 0.7)
					{
						if (num5 != 0.9)
						{
							if (num5 == 1.0)
							{
								materialName[0] = Consts2.strichkaOtsynkovana10.MaterialName;
								num3 = Consts2.strichkaOtsynkovana10.Price;
							}
							else if (D <= 400)
							{
								materialName[0] = Consts2.strichkaOtsynkovana05.MaterialName;
								num3 = Consts2.strichkaOtsynkovana05.Price;
								tovchynaMetalu = 0.5;
							}
							else if (D <= 800)
							{
								materialName[0] = Consts2.strichkaOtsynkovana07.MaterialName;
								num3 = Consts2.strichkaOtsynkovana07.Price;
								tovchynaMetalu = 0.7;
							}
							else
							{
								materialName[0] = Consts2.strichkaOtsynkovana09.MaterialName;
								num3 = Consts2.strichkaOtsynkovana09.Price;
								tovchynaMetalu = 0.9;
							}
						}
						else
						{
							materialName[0] = Consts2.strichkaOtsynkovana09.MaterialName;
							num3 = Consts2.strichkaOtsynkovana09.Price;
						}
					}
					else
					{
						materialName[0] = Consts2.strichkaOtsynkovana07.MaterialName;
						num3 = Consts2.strichkaOtsynkovana07.Price;
					}
				}
				else
				{
					materialName[0] = Consts2.strichkaOtsynkovana068.MaterialName;
					num3 = Consts2.strichkaOtsynkovana068.Price;
				}
			}
			else
			{
				materialName[0] = Consts2.strichkaOtsynkovana065.MaterialName;
				num3 = Consts2.strichkaOtsynkovana065.Price;
			}
		}
		else
		{
			materialName[0] = Consts2.strichkaOtsynkovana05.MaterialName;
			num3 = Consts2.strichkaOtsynkovana05.Price;
		}
		materialName[1] = Consts2.mastOholodRidynaECOCOOL_МК_3.MaterialName;
		num2 = ((tovchynaMetalu < 0.65) ? 2.0 : ((!(tovchynaMetalu < 0.8)) ? 5.0 : 5.0));
		array[0, 0] *= 1.0 + num2 / 100.0;
		if (array[0, 0] < 0.005)
		{
			array[0, 0] = Math.Round(1000.0 * array[0, 0]) / 1000.0;
		}
		else
		{
			array[0, 0] = Math.Round(100.0 * array[0, 0]) / 100.0;
		}
		array[0, 1] = num2 / 100.0;
		array[0, 4] = array[0, 0] * (double)number;
		array[0, 5] = array[0, 4] * num * tovchynaMetalu / 1000.0;
		array[0, 2] = array[0, 4] * array[0, 1];
		array[0, 3] = array[0, 5] * array[0, 1];
		materialCost = array[0, 0] * num3 * 1.16;
		array[1, 0] = array[0, 5] * 0.0017 / (double)number;
		if (array[1, 0] < 0.005)
		{
			array[1, 0] = Math.Round(1000.0 * array[1, 0]) / 1000.0;
		}
		else
		{
			array[1, 0] = Math.Round(100.0 * array[1, 0]) / 100.0;
		}
		array[1, 5] = array[1, 0] * (double)number;
		materialCost += array[1, 0] * Consts2.mastOholodRidynaECOCOOL_МК_3.Price;
		return array;
	}

	public static double PricePovitroprovidPSK(int D, int L, double tovchynaMetalu)
	{
		double num = 1.0;
		double num2 = 0.0;
		materialSpendingCommercialOffer = Math.PI * (double)D * (double)L * 1.16 / 1000000.0;
		if (tovchynaMetalu == 0.0)
		{
			tovchynaMetalu = ((D > 400) ? ((D <= 800) ? 0.7 : 0.9) : 0.5);
		}
		double num3 = tovchynaMetalu;
		double num4 = num3;
		num = ((num4 == 0.5) ? 287.5 : ((num4 == 0.65) ? 333.5 : ((num4 == 0.68) ? 333.5 : ((num4 == 0.7) ? 333.5 : ((num4 == 0.9) ? 400.0 : ((num4 != 1.0) ? ((D > 400) ? ((D <= 800) ? 333.5 : 400.0) : 287.5) : 400.0))))));
		num = ((tovchynaMetalu < 0.65) ? (num * 0.758287449921433) : ((!(tovchynaMetalu < 0.8)) ? (num * 0.7749888310433174) : (num * 0.7749888310433174)));
		num2 = materialSpendingCommercialOffer * num;
		if (materialSpendingCommercialOffer < 0.005)
		{
			materialSpendingCommercialOffer = Math.Round(1000.0 * materialSpendingCommercialOffer) / 1000.0;
		}
		else
		{
			materialSpendingCommercialOffer = Math.Round(100.0 * materialSpendingCommercialOffer) / 100.0;
		}
		tovchynaMetaluCommercialOffer = tovchynaMetalu;
		return num2;
	}

	public static double[] FormPricePovitroprovidPSK()
	{
		double[] array = new double[24];
		int[] array2 = new int[24]
		{
			100, 110, 125, 140, 160, 180, 200, 225, 250, 280,
			315, 355, 400, 450, 500, 560, 630, 710, 800, 900,
			1000, 1120, 1250, 1400
		};
		for (int i = 0; i < array.Length; i++)
		{
			if (array2[i] <= 400)
			{
				array[i] = 218.007641852412;
			}
			else
			{
				array[i] = ((array2[i] <= 800) ? 258.4587751529464 : 309.99553241732696);
			}
			array[i] = Math.PI * (double)array2[i] * 1.16 * array[i] / 1000.0;
		}
		return array;
	}

	public static double VolumePovitroprovidPSK(int D, int L)
	{
		return Math.Round((double)D * (double)D * (double)L / 1000000.0) / 1000.0;
	}
}
