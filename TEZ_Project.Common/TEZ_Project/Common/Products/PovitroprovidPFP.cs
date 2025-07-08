using System;
using TEZ_Project.Common.Helpers;
using TEZ_Project;

namespace TEZ_Project.Common.Products;

public static class PovitroprovidPFP
{
	public static string[] materialName = new string[4] { "", "", "", "" };

	public static double materialCost;

	public static double materialSpendingCommercialOffer = 0.0;

	public static double tovchynaMetaluCommercialOffer = 0.0;

	public static double[,] MaterialPovitroprovidPFP(int B, int H, int L, int markaStali, int typPFP, int typProfil, double tovchynaMetalu, int number, int polka, int vidbortovka, string aisiType = "430")
	{
		double[,] array = new double[4, 6];
		double num = 0.0;
		double num2 = 2.0 * (double)(B + H);
		double num3 = ((L == 1250) ? 1.0 : 10.0);
		L += vidbortovka;
		int num4 = ((B >= H) ? B : H);
		double num5 = 0.0;
		materialName = new string[4] { "", "", "", "" };
		materialCost = 0.0;
		switch (markaStali)
		{
		case 1:
		{
			if (tovchynaMetalu == 0.0)
			{
				tovchynaMetalu = ((num4 > 400) ? ((num4 <= 800) ? 0.7 : 0.9) : 0.5);
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
								}
							}
							else
							{
								materialName[0] = Consts2.lystOchynkovanyj09.MaterialName;
								num5 = Consts2.lystOchynkovanyj09.Price;
							}
						}
						else
						{
							materialName[0] = Consts2.lystOchynkovanyj07.MaterialName;
							num5 = Consts2.lystOchynkovanyj07.Price;
						}
					}
					else
					{
						materialName[0] = Consts2.lystOchynkovanyj068.MaterialName;
						num5 = Consts2.lystOchynkovanyj068.Price;
					}
				}
				else
				{
					materialName[0] = Consts2.lystOchynkovanyj065.MaterialName;
					num5 = Consts2.lystOchynkovanyj065.Price;
				}
			}
			else
			{
				materialName[0] = Consts2.lystOchynkovanyj05.MaterialName;
				num5 = Consts2.lystOchynkovanyj05.Price;
			}
			break;
		}
		case 2:
		{
			if (tovchynaMetalu == 0.0)
			{
				tovchynaMetalu = ((num4 > 400) ? ((num4 <= 800) ? 0.8 : 1.0) : 0.5);
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
														num3 = 10.0;
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
													num3 = 10.0;
												}
											}
											else
											{
												materialName[0] = Consts2.lystStalnyj40.MaterialName;
												num5 = Consts2.lystStalnyj40.Price;
												num3 = 10.0;
											}
										}
										else
										{
											materialName[0] = Consts2.lystStalnyj30.MaterialName;
											num5 = Consts2.lystStalnyj30.Price;
											num3 = 10.0;
										}
									}
									else
									{
										materialName[0] = Consts2.lystStalnyj25.MaterialName;
										num5 = Consts2.lystStalnyj25.Price;
										num3 = 10.0;
									}
								}
								else
								{
									materialName[0] = Consts2.lystStalnyj20.MaterialName;
									num5 = Consts2.lystStalnyj20.Price;
									num3 = 10.0;
								}
							}
							else
							{
								materialName[0] = Consts2.lystStalnyj15.MaterialName;
								num5 = Consts2.lystStalnyj15.Price;
								num3 = 10.0;
							}
						}
						else
						{
							materialName[0] = Consts2.lystStalnyj12.MaterialName;
							num5 = Consts2.lystStalnyj12.Price;
							num3 = 10.0;
						}
					}
					else
					{
						materialName[0] = Consts2.lystStalnyj10.MaterialName;
						num5 = Consts2.lystStalnyj10.Price;
						num3 = 10.0;
					}
				}
				else
				{
					materialName[0] = Consts2.lystStalnyj08.MaterialName;
					num5 = Consts2.lystStalnyj08.Price;
					num3 = 10.0;
				}
			}
			else
			{
				materialName[0] = Consts2.lystStalnyj05.MaterialName;
				num5 = Consts2.lystStalnyj05.Price;
				num3 = 5.0;
			}
			break;
		}
		case 3:
		{
			if (tovchynaMetalu == 0.0)
			{
				tovchynaMetalu = ((num4 > 400) ? ((num4 <= 800) ? 0.8 : 1.0) : 0.5);
			}
			num = 7825.0;
			CustomConst lystNerzavijuchyj = MaterialHelper.GetLystNerzavijuchyj(tovchynaMetalu, aisiType);
			materialName[0] = lystNerzavijuchyj?.MaterialName ?? "Лист НЕРЖ ??, м2";
			num5 = lystNerzavijuchyj.Price;
			break;
		}
		}
		if (num2 <= 500.0)
		{
			array[0, 0] = num2 + 60.0;
		}
		else if (num2 <= 1220.0)
		{
			array[0, 0] = num2 + 30.0;
		}
		else if (num2 <= 2440.0)
		{
			array[0, 0] = num2 + 60.0;
		}
		else
		{
			array[0, 0] = ((num2 <= 3660.0) ? (num2 + 90.0) : (num2 + 120.0));
		}
		array[0, 0] = array[0, 0] * (1.0 + num3 / 100.0) * (double)L / 1000000.0;
		if (typPFP == 3 || typPFP == 7)
		{
			array[0, 0] += (double)(B + 80) * (double)(H + 80) * (1.0 + num3 / 100.0) / 1000000.0;
		}
		if (array[0, 0] < 0.005)
		{
			array[0, 0] = Math.Round(1000.0 * array[0, 0]) / 1000.0;
		}
		else
		{
			array[0, 0] = Math.Round(100.0 * array[0, 0]) / 100.0;
		}
		array[0, 1] = num3 / 100.0;
		array[0, 4] = array[0, 0] * (double)number;
		array[0, 5] = array[0, 4] * num * tovchynaMetalu / 1000.0;
		array[0, 2] = array[0, 4] * array[0, 1];
		array[0, 3] = array[0, 5] * array[0, 1];
		materialCost = array[0, 0] * num5;
		int num10 = ((typPFP != 1) ? ((typPFP == 2 || typPFP == 3 || typPFP == 4) ? 1 : 0) : 2);
		if (num10 > 0)
		{
			if (typProfil == 0)
			{
				typProfil = ((num4 < 800) ? 1 : 2);
			}
			double[,] array2 = new double[2, 6];
			int num11 = 1;
			array2 = FlanetsPrjamokutnyj.MaterialFlanetsPrjamokutnyj(B, H, typProfil, number, polka, num10);
			materialCost += FlanetsPrjamokutnyj.materialCost1;
			for (int i = 0; i < 2; i++)
			{
				if (FlanetsPrjamokutnyj.materialName[i] != "")
				{
					materialName[num11] = FlanetsPrjamokutnyj.materialName[i];
					for (int j = 0; j < 6; j++)
					{
						array[num11, j] = array2[i, j];
					}
					num11++;
				}
			}
			if (typProfil <= 2)
			{
				double[,] array3 = new double[1, 6];
				array3 = HvyntNaFlanets.MaterialHvyntNaFlanets(B, H, num10, number);
				materialCost += HvyntNaFlanets.materialCost1;
				materialName[num11] = HvyntNaFlanets.materialName1[0];
				for (int k = 0; k < 6; k++)
				{
					array[num11, k] = array3[0, k];
				}
			}
		}
		return array;
	}

	public static double GetPovitroprovidPFP(int B, int H, int L, int markaStali, double tovchynaMetalu, int typPFP, int vidbortovka)
	{
		L += vidbortovka;
		double num = 1.0;
		double num2 = 0.0;
		int num3 = ((B >= H) ? B : H);
		materialSpendingCommercialOffer = 2.0 * (double)(B + H) * (double)L;
		if (typPFP == 3 || typPFP == 7)
		{
			materialSpendingCommercialOffer += B * H;
		}
		materialSpendingCommercialOffer /= 1000000.0;
		switch (markaStali)
		{
		case 1:
			if (tovchynaMetalu == 0.0)
			{
				tovchynaMetalu = ((num3 > 400) ? ((num3 <= 800) ? 0.7 : 0.9) : 0.5);
			}
			num = ((typPFP > 3) ? ((!(tovchynaMetalu < 0.65)) ? ((tovchynaMetalu < 0.9) ? 333.5 : 400.0) : 287.5) : ((!(tovchynaMetalu < 0.65)) ? ((tovchynaMetalu < 0.9) ? 377.0 : 480.0) : 322.0));
			break;
		case 2:
		{
			if (tovchynaMetalu == 0.0)
			{
				tovchynaMetalu = ((num3 > 400) ? ((num3 <= 800) ? 0.8 : 1.0) : 0.5);
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
				tovchynaMetalu = ((num3 > 400) ? ((num3 <= 800) ? 0.8 : 1.0) : 0.5);
			}
			double num4 = tovchynaMetalu;
			double num5 = num4;
			num = ((num5 == 0.5) ? 110.0 : ((num5 == 0.8) ? 200.0 : ((num5 == 1.0) ? 250.0 : ((num5 == 1.2) ? 300.0 : ((num5 != 1.5) ? 0.0 : 400.0)))));
			num *= 1.7;
			break;
		}
		}
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

	public static double VolumePovitroprovidPFP(int B, int H, int L)
	{
		return Math.Round((double)B * (double)H * (double)L / 1000000.0) / 1000.0;
	}

	public static double CalculateZarplataPovitroprovidPFP(int width, int height, int length, double metalThickness, int pfpType, int profileType, int quantity)
	{
		double num = CalculateBaseSalary(width, height, length, metalThickness, pfpType, profileType);
		return num * (double)quantity;
	}

	private static double CalculateBaseSalary(int width, int height, int length, double metalThickness, int pfpType, int profileType)
	{
		double num = 0.0;
		double num2 = 0.0;
		double num3 = 2.0 * (double)(width + height) * (double)length / 1000000.0;
		if (metalThickness > 0.5 && metalThickness <= 0.7)
		{
			metalThickness = 0.7;
		}
		else if (metalThickness > 0.7 && metalThickness <= 1.0)
		{
			metalThickness = 1.0;
		}
		double num4 = ((num3 <= 0.3) ? 100.0 : ((!(num3 <= 1.0)) ? 30.0 : 40.0));
		double num5 = metalThickness;
		double num6 = num5;
		double num7;
		double num8;
		if (num6 != 0.5)
		{
			if (num6 != 0.7)
			{
				if (num6 != 1.0)
				{
					throw new ArgumentOutOfRangeException("metalThickness");
				}
				num7 = 1.3;
				num8 = 1.05;
			}
			else
			{
				num7 = 1.15;
				num8 = 1.02;
			}
		}
		else
		{
			num7 = 1.0;
			num8 = 1.0;
		}
		int num9 = (width + 199) / 100 + 1;
		int num10 = (height + 199) / 100 + 1;
		if (pfpType == 1)
		{
			num += ((profileType == 1) ? 18.0 : 24.0);
			num2 += ((profileType == 1) ? ((double)((num9 + num10) * 2) * 0.4) : ((double)((num9 + num10) * 2) * 0.45)) * num8;
		}
		else if (pfpType == 2 || pfpType == 4)
		{
			num += ((profileType == 1) ? 9.0 : 12.0);
			num2 += ((profileType == 1) ? ((double)(num9 + num10) * 0.4) : ((double)(num9 + num10) * 0.45)) * num8;
		}
		else
		{
			switch (pfpType)
			{
			case 3:
			{
				num += ((profileType == 1) ? 9.0 : 12.0);
				num2 += ((profileType == 1) ? ((double)(num9 + num10) * 0.4) : ((double)(num9 + num10) * 0.45)) * num8;
				double num11 = ZaglushkaZP.CalculateZarplataZagluskaZP(width, height, metalThickness, 2, 0, 1, 40, kriplennia: true);
				num += num11;
				break;
			}
			case 7:
			{
				double num11 = ZaglushkaZP.CalculateZarplataZagluskaZP(width, height, metalThickness, 2, 0, 1, 40, kriplennia: true);
				num += num11;
				break;
			}
			}
		}
		num += ((pfpType == 5 || pfpType == 6) ? (num3 * num4 * num7) : (num2 + num3 * num4 * num7));
		return Math.Round(num, 2);
	}
}
