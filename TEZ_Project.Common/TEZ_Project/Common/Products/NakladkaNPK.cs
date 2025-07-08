using System;
using TEZ_Project.Common.Helpers;

namespace TEZ_Project.Common.Products;

public static class NakladkaNPK
{
	public static string[] materialName = new string[4] { "", "", "", "" };

	public static double materialCost;

	public static double materialSpendingCommercialOffer = 0.0;

	public static double tovchynaMetaluCommercialOffer = 0.0;

	public static double[,] MaterialNakladkaNPK(int B, int H, int k, int D, int markaStali, double tovchynaMetalu, int typNPK, int typProfil, int number, int polka, string aisiType = "430")
	{
		double[,] array = new double[4, 6];
		double num = 0.0;
		double num2 = 0.0;
		int num3 = ((B >= H) ? B : H);
		double num4 = 2.0 * (double)(B + H);
		double num5 = 0.0;
		materialName = new string[4] { "", "", "", "" };
		materialCost = 0.0;
		switch (markaStali)
		{
		case 1:
		{
			if (tovchynaMetalu == 0.0)
			{
				tovchynaMetalu = ((num3 > 400) ? ((num3 <= 800) ? 0.7 : 0.9) : 0.5);
			}
			num = 7825.0;
			double num6 = tovchynaMetalu;
			double num7 = num6;
			if (num7 != 0.5)
			{
				if (num7 != 0.65)
				{
					if (num7 != 0.68)
					{
						if (num7 != 0.7)
						{
							if (num7 != 0.9)
							{
								if (num7 != 1.0)
								{
									if (num7 == 1.2)
									{
										materialName[0] = Consts2.lystOchynkovanyj12.MaterialName;
										num5 = Consts2.lystOchynkovanyj12.Price;
										num2 = 10.0;
									}
									else
									{
										materialName[0] = "Лист ОЦ ??, м2";
									}
								}
								else
								{
									materialName[0] = Consts2.lystOchynkovanyj10.MaterialName;
									num5 = Consts2.lystOchynkovanyj10.Price;
									num2 = 10.0;
								}
							}
							else
							{
								materialName[0] = Consts2.lystOchynkovanyj09.MaterialName;
								num5 = Consts2.lystOchynkovanyj09.Price;
								num2 = 10.0;
							}
						}
						else
						{
							materialName[0] = Consts2.lystOchynkovanyj07.MaterialName;
							num5 = Consts2.lystOchynkovanyj07.Price;
							num2 = 10.0;
						}
					}
					else
					{
						materialName[0] = Consts2.lystOchynkovanyj068.MaterialName;
						num5 = Consts2.lystOchynkovanyj068.Price;
						num2 = 10.0;
					}
				}
				else
				{
					materialName[0] = Consts2.lystOchynkovanyj065.MaterialName;
					num5 = Consts2.lystOchynkovanyj065.Price;
					num2 = 10.0;
				}
			}
			else
			{
				materialName[0] = Consts2.lystOchynkovanyj05.MaterialName;
				num5 = Consts2.lystOchynkovanyj05.Price;
				num2 = 5.0;
			}
			break;
		}
		case 2:
		{
			if (tovchynaMetalu == 0.0)
			{
				tovchynaMetalu = ((num3 > 400) ? ((num3 <= 800) ? 0.8 : 1.0) : 0.5);
			}
			num = 7825.0;
			double num8 = tovchynaMetalu;
			double num9 = num8;
			if (num9 != 0.5)
			{
				if (num9 != 0.8)
				{
					if (num9 != 1.0)
					{
						if (num9 != 1.2)
						{
							if (num9 != 1.5)
							{
								if (num9 != 2.0)
								{
									if (num9 != 2.5)
									{
										if (num9 != 3.0)
										{
											if (num9 != 4.0)
											{
												if (num9 != 5.0)
												{
													if (num9 == 6.0)
													{
														materialName[0] = Consts2.lystStalnyj60.MaterialName;
														num5 = Consts2.lystStalnyj60.Price;
														num2 = 10.0;
													}
													else
													{
														materialName[0] = "Лист СТ ??, м2";
													}
												}
												else
												{
													materialName[0] = Consts2.lystStalnyj50.MaterialName;
													num5 = Consts2.lystStalnyj50.Price;
													num2 = 10.0;
												}
											}
											else
											{
												materialName[0] = Consts2.lystStalnyj40.MaterialName;
												num5 = Consts2.lystStalnyj40.Price;
												num2 = 10.0;
											}
										}
										else
										{
											materialName[0] = Consts2.lystStalnyj30.MaterialName;
											num5 = Consts2.lystStalnyj30.Price;
											num2 = 10.0;
										}
									}
									else
									{
										materialName[0] = Consts2.lystStalnyj25.MaterialName;
										num5 = Consts2.lystStalnyj25.Price;
										num2 = 10.0;
									}
								}
								else
								{
									materialName[0] = Consts2.lystStalnyj20.MaterialName;
									num5 = Consts2.lystStalnyj20.Price;
									num2 = 10.0;
								}
							}
							else
							{
								materialName[0] = Consts2.lystStalnyj15.MaterialName;
								num5 = Consts2.lystStalnyj15.Price;
								num2 = 10.0;
							}
						}
						else
						{
							materialName[0] = Consts2.lystStalnyj12.MaterialName;
							num5 = Consts2.lystStalnyj12.Price;
							num2 = 10.0;
						}
					}
					else
					{
						materialName[0] = Consts2.lystStalnyj10.MaterialName;
						num5 = Consts2.lystStalnyj10.Price;
						num2 = 10.0;
					}
				}
				else
				{
					materialName[0] = Consts2.lystStalnyj08.MaterialName;
					num5 = Consts2.lystStalnyj08.Price;
					num2 = 10.0;
				}
			}
			else
			{
				materialName[0] = Consts2.lystStalnyj05.MaterialName;
				num5 = Consts2.lystStalnyj05.Price;
				num2 = 5.0;
			}
			break;
		}
		case 3:
		{
			if (tovchynaMetalu == 0.0)
			{
				tovchynaMetalu = ((num3 > 400) ? ((num3 <= 800) ? 0.8 : 1.0) : 0.5);
			}
			num = 7825.0;
			num2 = MaterialHelper.GetMaterialWithdrawalNerzavijka(tovchynaMetalu);
			CustomConst lystNerzavijuchyj = MaterialHelper.GetLystNerzavijuchyj(tovchynaMetalu, aisiType);
			materialName[0] = lystNerzavijuchyj?.MaterialName ?? "Лист НЕРЖ ??, м2";
			num5 = lystNerzavijuchyj.Price;
			break;
		}
		}
		double num10 = ((double)D - Math.Sqrt((double)D * (double)D - (double)(H * H))) / 2.0;
		array[0, 0] = (num4 + 30.0) * ((double)k + num10 + 12.0);
		if (num4 + 30.0 > 2500.0)
		{
			array[0, 0] += 60.0 * ((double)k + num10 + 12.0);
		}
		else if (num4 + 30.0 > 1250.0)
		{
			array[0, 0] += 30.0 * ((double)k + num10 + 12.0);
		}
		array[0, 0] *= (1.0 + num2 / 100.0) / 1000000.0;
		double num11 = Math.Asin((double)H / (double)D);
		num11 = ((double)(D * D) * num11 - (double)H * Math.Sqrt((double)D * (double)D - (double)(H * H))) / 2.0;
		double num12 = (num4 * ((double)k + num10) - num11) / 1000000.0;
		num2 = Math.Round((array[0, 0] / num12 - 1.0) * 100.0);
		if (num2 > 100.0)
		{
			num2 = 100.0;
			array[0, 0] = num12 * (1.0 + num2 / 100.0);
		}
		array[0, 1] = num2 / 100.0;
		if (array[0, 0] < 0.005)
		{
			array[0, 0] = Math.Round(1000.0 * array[0, 0]) / 1000.0;
		}
		else
		{
			array[0, 0] = Math.Round(100.0 * array[0, 0]) / 100.0;
		}
		array[0, 4] = array[0, 0] * (double)number;
		array[0, 5] = array[0, 4] * num * tovchynaMetalu / 1000.0;
		array[0, 2] = array[0, 4] * array[0, 1];
		array[0, 3] = array[0, 5] * array[0, 1];
		materialCost = array[0, 0] * num5;
		if (typNPK == 1)
		{
			if (typProfil == 0)
			{
				typProfil = ((num3 < 800) ? 1 : 2);
			}
			double[,] array2 = new double[2, 6];
			int num13 = 1;
			array2 = FlanetsPrjamokutnyj.MaterialFlanetsPrjamokutnyj(B, H, typProfil, number, polka, 1);
			materialCost += FlanetsPrjamokutnyj.materialCost1;
			if (typProfil <= 2)
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
			}
			else
			{
				if (FlanetsPrjamokutnyj.materialName[0] != "")
				{
					materialName[num13] = FlanetsPrjamokutnyj.materialName[0];
					for (int l = 0; l < 6; l++)
					{
						array[num13, l] = ((l == 1) ? array2[0, l] : (array[num13, l] + array2[0, l]));
					}
				}
				num13++;
			}
			double[,] array3 = new double[1, 6];
			array3 = HvyntNaFlanets.MaterialHvyntNaFlanets(B, H, 1, number);
			materialName[num13] = HvyntNaFlanets.materialName1[0];
			for (int m = 0; m < 6; m++)
			{
				array[num13, m] = array3[0, m];
			}
			materialCost += HvyntNaFlanets.materialCost1;
		}
		return array;
	}

	public static double PriceNakladkaNPK(int B, int H, int k, int D, int markaStali, double tovchynaMetalu, int typNPK, int typProfil)
	{
		double num = 1.0;
		int num2 = ((B >= H) ? B : H);
		double num3 = 2.0 * (double)(B + H);
		switch (markaStali)
		{
		case 1:
			if (tovchynaMetalu == 0.0)
			{
				tovchynaMetalu = ((num2 > 400) ? ((num2 <= 800) ? 0.7 : 0.9) : 0.5);
			}
			num = ((typNPK != 1) ? ((!(tovchynaMetalu < 0.65)) ? ((tovchynaMetalu < 0.9) ? 406.0 : 520.0) : 345.0) : ((!(tovchynaMetalu < 0.65)) ? ((tovchynaMetalu < 0.9) ? 464.0 : 600.0) : 402.5));
			break;
		case 2:
		{
			if (tovchynaMetalu == 0.0)
			{
				tovchynaMetalu = ((num2 > 400) ? ((num2 <= 800) ? 0.8 : 1.0) : 0.5);
			}
			double num6 = tovchynaMetalu;
			double num7 = num6;
			num = ((num7 == 0.5) ? 110.0 : ((num7 == 0.8) ? 140.0 : ((num7 == 1.0) ? 200.0 : ((num7 == 1.2) ? 250.0 : ((num7 == 1.5) ? 300.0 : ((num7 == 2.0) ? 350.0 : ((num7 == 2.5) ? 400.0 : ((num7 == 3.0) ? 500.0 : ((num7 == 4.0) ? 600.0 : ((num7 == 5.0) ? 700.0 : ((num7 != 6.0) ? 0.0 : 800.0)))))))))));
			num *= 1.8;
			break;
		}
		case 3:
		{
			if (tovchynaMetalu == 0.0)
			{
				tovchynaMetalu = ((num2 > 400) ? ((num2 <= 800) ? 0.8 : 1.0) : 0.5);
			}
			double num4 = tovchynaMetalu;
			double num5 = num4;
			num = ((num5 == 0.5) ? 110.0 : ((num5 == 0.8) ? 200.0 : ((num5 == 1.0) ? 250.0 : ((num5 == 1.2) ? 300.0 : ((num5 != 1.5) ? 0.0 : 400.0)))));
			num *= 1.7;
			break;
		}
		}
		double num8 = ((double)D - Math.Sqrt((double)D * (double)D - (double)(H * H))) / 2.0;
		materialSpendingCommercialOffer = ((double)D * (double)D * Math.Asin((double)H / (double)D) - (double)H * Math.Sqrt((double)D * (double)D - (double)(H * H))) / 2.0;
		materialSpendingCommercialOffer = (num3 * ((double)k + num8) - materialSpendingCommercialOffer) / 1000000.0;
		double result = materialSpendingCommercialOffer * num;
		if (materialSpendingCommercialOffer < 0.005)
		{
			materialSpendingCommercialOffer = Math.Round(1000.0 * materialSpendingCommercialOffer) / 1000.0;
		}
		else
		{
			materialSpendingCommercialOffer = Math.Round(100.0 * materialSpendingCommercialOffer) / 100.0;
		}
		tovchynaMetaluCommercialOffer = tovchynaMetalu;
		return result;
	}

	public static double VolumeNakladkaNPK(int B, int H, int k, int D)
	{
		double num = ((double)D - Math.Sqrt((double)D * (double)D - (double)(H * H))) / 2.0;
		return Math.Round((double)B * (double)H * ((double)k + num) / 1000000.0) / 1000.0;
	}
}
