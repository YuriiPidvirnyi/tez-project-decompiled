using System;
using TEZ_Project.Common.Helpers;
using TEZ_Project;

namespace TEZ_Project.Common.Products;

public static class VidvidVK60_45_30_15
{
	public static string[] materialName = new string[7] { "", "", "", "", "", "", "" };

	public static double materialCost;

	public static double materialSpendingCommercialOffer = 0.0;

	public static double tovchynaMetaluCommercialOffer = 0.0;

	public static double[,] MaterialVidvidVK60_45_30_15(int D, double R, int K, int K1, int Angle, int markaStali, double tovchynaMetalu, int typVK, int typProfil, int number, string aisiType = "430")
	{
		double[,] array = new double[7, 6];
		double num = 0.0;
		double num2 = 0.0;
		materialName = new string[7] { "", "", "", "", "", "", "" };
		materialCost = 0.0;
		int num3 = -1;
		num3++;
		switch (markaStali)
		{
		case 1:
		{
			if (tovchynaMetalu == 0.0)
			{
				tovchynaMetalu = ((D > 400) ? ((D <= 800) ? 0.7 : 0.9) : 0.5);
			}
			num = 7825.0;
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
								if (num5 != 1.0)
								{
									if (num5 == 1.2)
									{
										materialName[num3] = Consts2.lystOchynkovanyj12.MaterialName;
										num2 = Consts2.lystOchynkovanyj12.Price;
									}
									else
									{
										materialName[num3] = "Лист ОЦ ??, м2";
									}
								}
								else
								{
									materialName[num3] = Consts2.lystOchynkovanyj10.MaterialName;
									num2 = Consts2.lystOchynkovanyj10.Price;
								}
							}
							else
							{
								materialName[num3] = Consts2.lystOchynkovanyj09.MaterialName;
								num2 = Consts2.lystOchynkovanyj09.Price;
							}
						}
						else
						{
							materialName[num3] = Consts2.lystOchynkovanyj07.MaterialName;
							num2 = Consts2.lystOchynkovanyj07.Price;
						}
					}
					else
					{
						materialName[num3] = Consts2.lystOchynkovanyj068.MaterialName;
						num2 = Consts2.lystOchynkovanyj068.Price;
					}
				}
				else
				{
					materialName[num3] = Consts2.lystOchynkovanyj065.MaterialName;
					num2 = Consts2.lystOchynkovanyj065.Price;
				}
			}
			else
			{
				materialName[num3] = Consts2.lystOchynkovanyj05.MaterialName;
				num2 = Consts2.lystOchynkovanyj05.Price;
			}
			break;
		}
		case 2:
		{
			if (tovchynaMetalu == 0.0)
			{
				tovchynaMetalu = ((D > 400) ? ((D <= 800) ? 0.8 : 1.0) : 0.5);
			}
			num = 7825.0;
			double num6 = tovchynaMetalu;
			double num7 = num6;
			if (num7 != 0.5)
			{
				if (num7 != 0.8)
				{
					if (num7 != 1.0)
					{
						if (num7 != 1.2)
						{
							if (num7 != 1.5)
							{
								if (num7 != 2.0)
								{
									if (num7 != 2.5)
									{
										if (num7 != 3.0)
										{
											if (num7 != 4.0)
											{
												if (num7 != 5.0)
												{
													if (num7 == 6.0)
													{
														materialName[num3] = Consts2.lystStalnyj60.MaterialName;
														num2 = Consts2.lystStalnyj60.Price;
													}
													else
													{
														materialName[num3] = "Лист СТ ??, м2";
													}
												}
												else
												{
													materialName[num3] = Consts2.lystStalnyj50.MaterialName;
													num2 = Consts2.lystStalnyj50.Price;
												}
											}
											else
											{
												materialName[num3] = Consts2.lystStalnyj40.MaterialName;
												num2 = Consts2.lystStalnyj40.Price;
											}
										}
										else
										{
											materialName[num3] = Consts2.lystStalnyj30.MaterialName;
											num2 = Consts2.lystStalnyj30.Price;
										}
									}
									else
									{
										materialName[num3] = Consts2.lystStalnyj25.MaterialName;
										num2 = Consts2.lystStalnyj25.Price;
									}
								}
								else
								{
									materialName[num3] = Consts2.lystStalnyj20.MaterialName;
									num2 = Consts2.lystStalnyj20.Price;
								}
							}
							else
							{
								materialName[num3] = Consts2.lystStalnyj15.MaterialName;
								num2 = Consts2.lystStalnyj15.Price;
							}
						}
						else
						{
							materialName[num3] = Consts2.lystStalnyj12.MaterialName;
							num2 = Consts2.lystStalnyj12.Price;
						}
					}
					else
					{
						materialName[num3] = Consts2.lystStalnyj10.MaterialName;
						num2 = Consts2.lystStalnyj10.Price;
					}
				}
				else
				{
					materialName[num3] = Consts2.lystStalnyj08.MaterialName;
					num2 = Consts2.lystStalnyj08.Price;
				}
			}
			else
			{
				materialName[num3] = Consts2.lystStalnyj05.MaterialName;
				num2 = Consts2.lystStalnyj05.Price;
			}
			break;
		}
		case 3:
		{
			if (tovchynaMetalu == 0.0)
			{
				tovchynaMetalu = ((D > 400) ? ((D <= 800) ? 0.8 : 1.0) : 0.5);
			}
			num = 7825.0;
			CustomConst lystNerzavijuchyj = MaterialHelper.GetLystNerzavijuchyj(tovchynaMetalu, aisiType);
			materialName[num3] = lystNerzavijuchyj?.MaterialName ?? "Лист НЕРЖ ??, м2";
			num2 = lystNerzavijuchyj.Price;
			break;
		}
		}
		double num8 = ((D < 560) ? 0.036 : ((D < 710) ? 0.043 : ((D >= 900) ? ((D < 1400) ? 0.086 : 0.11599999999999999) : 0.073)));
		double num9 = ((D >= 560) ? ((D < 900) ? 0.029 : 0.034) : 0.025);
		double num10 = ((D < 710) ? 40 : 60);
		array[num3, 0] = (Math.PI * (double)D / 1000.0 + num8) * (Math.PI * (double)Angle / 180.0 * R * (double)D / 1000.0 + 2.0 * (num10 + 25.0) / 1000.0 + 4.0 * num9);
		array[num3, 0] += (Math.PI * (double)D / 1000.0 + num8) * (double)(K + K1 - 100) / 1000.0;
		if (array[num3, 0] < 0.005)
		{
			array[num3, 0] = Math.Round(1000.0 * array[num3, 0]) / 1000.0;
		}
		else
		{
			array[num3, 0] = Math.Round(100.0 * array[num3, 0]) / 100.0;
		}
		double num11 = ((!(tovchynaMetalu < 0.65)) ? ((tovchynaMetalu < 0.9) ? 10.0 : 10.0) : 5.0);
		array[num3, 0] *= 1.0 + num11 / 100.0;
		array[num3, 1] = num11 / 100.0;
		array[num3, 4] = array[num3, 0] * (double)number;
		array[num3, 5] = array[num3, 4] * num * tovchynaMetalu / 1000.0;
		array[num3, 2] = array[num3, 4] * array[num3, 1];
		array[num3, 3] = array[num3, 5] * array[num3, 1];
		materialCost = array[num3, 0] * num2;
		if (typVK == 8 || typVK == 9 || typVK == 10)
		{
			num3++;
			materialName[num3] = Consts2.sitka25x25.MaterialName;
			array[num3, 0] = Math.PI / 4.0 * ((double)D / 1000.0) * ((double)D / 1000.0);
			array[num3, 0] = array[num3, 0] * 0.05 + array[num3, 0];
			array[num3, 1] = 0.05;
			array[num3, 4] = array[num3, 0] * (double)number;
			array[num3, 5] = array[num3, 4] * 1.81;
			array[num3, 2] = array[num3, 4] * array[num3, 1];
			array[num3, 3] = array[num3, 2] * 1.81;
			array = MaterialHelper.RoundMaterialSpending(array, num3);
			materialCost += array[num3, 0] * Consts2.sitka25x25.Price;
		}
		if (typVK == 5 || typVK == 6 || typVK == 10)
		{
			num3++;
			double[,] array2 = ((typVK == 6) ? FlanetsKruglyj.MaterialFlanetsKruglyj(D, typProfil, 2 * number, 2) : FlanetsKruglyj.MaterialFlanetsKruglyj(D, typProfil, number, 1));
			materialCost += FlanetsKruglyj.materialCost1;
			for (int i = 0; i < 5; i++)
			{
				materialName[i + num3] = FlanetsKruglyj.materialName1[i];
				for (int j = 0; j < 6; j++)
				{
					array[i + num3, j] = array2[i, j];
				}
			}
		}
		return array;
	}

	public static double PriceVidvidVK60_45_30_15(int D, double R, int K, int K1, int Angle, int markaStali, double tovchynaMetalu, int typVK, int typProfil)
	{
		double num = 1.0;
		double num2 = 0.0;
		materialSpendingCommercialOffer = Math.PI * (double)D / 1000.0 * Math.PI * (double)Angle / 180.0 * R * (double)D / 1000.0 + Math.PI * (double)D / 1000.0 * 50.0 / 1000.0 * 2.0;
		materialSpendingCommercialOffer += Math.PI * (double)D * (double)(K + K1 - 100) / 1000000.0;
		switch (markaStali)
		{
		case 1:
			if (tovchynaMetalu == 0.0)
			{
				tovchynaMetalu = ((D > 400) ? ((D <= 800) ? 0.7 : 0.9) : 0.5);
			}
			num = ((!(tovchynaMetalu < 0.65)) ? ((tovchynaMetalu < 0.9) ? 406.0 : 520.0) : 345.0);
			break;
		case 2:
		{
			if (tovchynaMetalu == 0.0)
			{
				tovchynaMetalu = ((D > 400) ? ((D <= 800) ? 0.8 : 1.0) : 0.5);
			}
			double num5 = tovchynaMetalu;
			double num6 = num5;
			num = ((num6 == 0.5) ? 115.0 : ((num6 == 0.8) ? 115.0 : ((num6 == 1.0) ? 134.78 : ((num6 == 1.2) ? 134.78 : ((num6 == 1.5) ? 173.19 : ((num6 == 2.0) ? 173.19 : ((num6 == 2.5) ? 173.19 : ((num6 == 3.0) ? 173.19 : ((num6 == 4.0) ? 173.19 : ((num6 == 5.0) ? 173.19 : ((num6 != 6.0) ? 0.0 : 173.19)))))))))));
			break;
		}
		case 3:
		{
			if (tovchynaMetalu == 0.0)
			{
				tovchynaMetalu = ((D > 400) ? ((D <= 800) ? 0.8 : 1.0) : 0.5);
			}
			double num3 = tovchynaMetalu;
			double num4 = num3;
			num = ((num4 == 0.5) ? 115.0 : ((num4 == 0.8) ? 134.78 : ((num4 == 1.0) ? 173.19 : ((num4 == 1.2) ? 173.19 : ((num4 != 1.5) ? 0.0 : 173.19)))));
			break;
		}
		}
		num2 = materialSpendingCommercialOffer * num;
		if (typVK == 8 || typVK == 9 || typVK == 10)
		{
			num2 += 1.8 * Consts2.sitka25x25.Price * (double)D * (double)D / 1000000.0;
		}
		if (materialSpendingCommercialOffer < 0.005)
		{
			materialSpendingCommercialOffer = Math.Round(1000.0 * materialSpendingCommercialOffer) / 1000.0;
		}
		else
		{
			materialSpendingCommercialOffer = Math.Round(100.0 * materialSpendingCommercialOffer) / 100.0;
		}
		if (typVK == 5 || typVK == 6 || typVK == 10)
		{
			FlanetsKruglyj.MaterialFlanetsKruglyj(D, typProfil, 1, 1);
			num2 += ((typVK == 5) ? FlanetsKruglyj.priceProduct1 : (2.0 * FlanetsKruglyj.priceProduct1));
		}
		tovchynaMetaluCommercialOffer = tovchynaMetalu;
		return num2;
	}

	public static double[,] FormPriceVidvidVK60_45_30_15()
	{
		double num = 1.0;
		double[,] array = new double[24, 4];
		int[] array2 = new int[24]
		{
			100, 110, 125, 140, 160, 180, 200, 225, 250, 280,
			315, 355, 400, 450, 500, 560, 630, 710, 800, 900,
			1000, 1120, 1250, 1400
		};
		int[] array3 = new int[4] { 60, 45, 30, 15 };
		for (int i = 0; i < 24; i++)
		{
			double num2 = ((array2[i] > 400) ? ((array2[i] <= 800) ? 406.0 : 520.0) : 345.0);
			for (int j = 0; j < 4; j++)
			{
				array[i, j] = Math.PI * (double)array2[i] / 1000.0 * Math.PI * (double)array3[j] / 180.0 * num * (double)array2[i] / 1000.0 + Math.PI * (double)array2[i] / 1000.0 * 50.0 / 1000.0 * 2.0 * num2;
			}
		}
		return array;
	}

	public static double VolumeVidvidVK60_45_30_15(int D, double R, int K, int K1, int Angle)
	{
		return Math.Round((R * (double)D + (double)D / 2.0 + (double)K) * ((R * (double)D + (double)D / 2.0) * Math.Sin(Angle) + (double)K1) * (double)D / 1000000.0) / 1000.0;
	}
}
