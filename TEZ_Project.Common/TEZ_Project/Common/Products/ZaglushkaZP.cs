using System;
using TEZ_Project.Common.Helpers;
using TEZ_Project;

namespace TEZ_Project.Common.Products;

public static class ZaglushkaZP
{
	public static string[] materialName = new string[4] { "", "", "", "" };

	public static double materialCost;

	public static double materialSpendingCommercialOffer = 0.0;

	public static double tovchynaMetaluCommercialOffer = 0.0;

	public static double[,] MaterialZaglushkaZP(int B, int H, int M, int markaStali, double tovchynaMetalu, int typZP, int typProfil, int number, int polka, string aisiType = "430")
	{
		double[,] array = new double[4, 6];
		double num = 0.0;
		int num2 = ((B >= H) ? B : H);
		double num3 = 0.0;
		double num4 = 0.0;
		materialName = new string[4] { "", "", "", "" };
		materialCost = 0.0;
		switch (markaStali)
		{
		case 1:
		{
			if (tovchynaMetalu == 0.0)
			{
				tovchynaMetalu = ((num2 > 400) ? ((num2 <= 800) ? 0.7 : 0.9) : 0.5);
			}
			num = 7825.0;
			double num5 = tovchynaMetalu;
			double num6 = num5;
			if (num6 != 0.5)
			{
				if (num6 != 0.65)
				{
					if (num6 != 0.68)
					{
						if (num6 != 0.7)
						{
							if (num6 != 0.9)
							{
								if (num6 != 1.0)
								{
									if (num6 == 1.2)
									{
										materialName[0] = Consts2.lystOchynkovanyj12.MaterialName;
										num3 = Consts2.lystOchynkovanyj12.Price;
										num4 = 10.0;
									}
									else
									{
										materialName[0] = "Лист ОЦ ??, м2";
									}
								}
								else
								{
									materialName[0] = Consts2.lystOchynkovanyj10.MaterialName;
									num3 = Consts2.lystOchynkovanyj10.Price;
									num4 = 10.0;
								}
							}
							else
							{
								materialName[0] = Consts2.lystOchynkovanyj09.MaterialName;
								num3 = Consts2.lystOchynkovanyj09.Price;
								num4 = 10.0;
							}
						}
						else
						{
							materialName[0] = Consts2.lystOchynkovanyj07.MaterialName;
							num3 = Consts2.lystOchynkovanyj07.Price;
							num4 = 10.0;
						}
					}
					else
					{
						materialName[0] = Consts2.lystOchynkovanyj068.MaterialName;
						num3 = Consts2.lystOchynkovanyj068.Price;
						num4 = 10.0;
					}
				}
				else
				{
					materialName[0] = Consts2.lystOchynkovanyj065.MaterialName;
					num3 = Consts2.lystOchynkovanyj065.Price;
					num4 = 10.0;
				}
			}
			else
			{
				materialName[0] = Consts2.lystOchynkovanyj05.MaterialName;
				num3 = Consts2.lystOchynkovanyj05.Price;
				num4 = 5.0;
			}
			break;
		}
		case 2:
		{
			if (tovchynaMetalu == 0.0)
			{
				tovchynaMetalu = ((num2 > 400) ? ((num2 <= 800) ? 0.8 : 1.0) : 0.5);
			}
			num = 7825.0;
			double num7 = tovchynaMetalu;
			double num8 = num7;
			if (num8 != 0.5)
			{
				if (num8 != 0.8)
				{
					if (num8 != 1.0)
					{
						if (num8 != 1.2)
						{
							if (num8 != 1.5)
							{
								if (num8 != 2.0)
								{
									if (num8 != 2.5)
									{
										if (num8 != 3.0)
										{
											if (num8 != 4.0)
											{
												if (num8 != 5.0)
												{
													if (num8 == 6.0)
													{
														materialName[0] = Consts2.lystStalnyj60.MaterialName;
														num3 = Consts2.lystStalnyj60.Price;
														num4 = 10.0;
													}
													else
													{
														materialName[0] = "Лист СТ ??, м2";
													}
												}
												else
												{
													materialName[0] = Consts2.lystStalnyj50.MaterialName;
													num3 = Consts2.lystStalnyj50.Price;
													num4 = 10.0;
												}
											}
											else
											{
												materialName[0] = Consts2.lystStalnyj40.MaterialName;
												num3 = Consts2.lystStalnyj40.Price;
												num4 = 10.0;
											}
										}
										else
										{
											materialName[0] = Consts2.lystStalnyj30.MaterialName;
											num3 = Consts2.lystStalnyj30.Price;
											num4 = 10.0;
										}
									}
									else
									{
										materialName[0] = Consts2.lystStalnyj25.MaterialName;
										num3 = Consts2.lystStalnyj25.Price;
										num4 = 10.0;
									}
								}
								else
								{
									materialName[0] = Consts2.lystStalnyj20.MaterialName;
									num3 = Consts2.lystStalnyj20.Price;
									num4 = 10.0;
								}
							}
							else
							{
								materialName[0] = Consts2.lystStalnyj15.MaterialName;
								num3 = Consts2.lystStalnyj15.Price;
								num4 = 10.0;
							}
						}
						else
						{
							materialName[0] = Consts2.lystStalnyj12.MaterialName;
							num3 = Consts2.lystStalnyj12.Price;
							num4 = 10.0;
						}
					}
					else
					{
						materialName[0] = Consts2.lystStalnyj10.MaterialName;
						num3 = Consts2.lystStalnyj10.Price;
						num4 = 10.0;
					}
				}
				else
				{
					materialName[0] = Consts2.lystStalnyj08.MaterialName;
					num3 = Consts2.lystStalnyj08.Price;
					num4 = 10.0;
				}
			}
			else
			{
				materialName[0] = Consts2.lystStalnyj05.MaterialName;
				num3 = Consts2.lystStalnyj05.Price;
				num4 = 5.0;
			}
			break;
		}
		case 3:
		{
			if (tovchynaMetalu == 0.0)
			{
				tovchynaMetalu = ((num2 > 400) ? ((num2 <= 800) ? 0.8 : 1.0) : 0.5);
			}
			num4 = MaterialHelper.GetMaterialWithdrawalNerzavijka(tovchynaMetalu);
			num = 7825.0;
			CustomConst lystNerzavijuchyj = MaterialHelper.GetLystNerzavijuchyj(tovchynaMetalu, aisiType);
			materialName[0] = lystNerzavijuchyj?.MaterialName ?? "Лист НЕРЖ ??, м2";
			num3 = lystNerzavijuchyj.Price;
			break;
		}
		}
		if (M == 0)
		{
			M = ((num2 < 630) ? 40 : 80);
		}
		array[0, 0] = (double)(B + 2 * M) * (double)(H + 2 * M) * (1.0 + num4 / 100.0) / 1000000.0;
		if (array[0, 0] < 0.005)
		{
			array[0, 0] = Math.Round(1000.0 * array[0, 0]) / 1000.0;
		}
		else
		{
			array[0, 0] = Math.Round(100.0 * array[0, 0]) / 100.0;
		}
		array[0, 1] = num4 / 100.0;
		array[0, 4] = array[0, 0] * (double)number;
		array[0, 5] = array[0, 4] * num * tovchynaMetalu / 1000.0;
		array[0, 2] = array[0, 4] * array[0, 1];
		array[0, 3] = array[0, 5] * array[0, 1];
		materialCost = array[0, 0] * num3;
		if (markaStali == 1 && typZP == 1)
		{
			if (typProfil == 0)
			{
				typProfil = ((num2 < 800) ? 1 : 2);
			}
			double[,] array2 = new double[2, 6];
			int num9 = 1;
			if (typProfil == 1)
			{
				array2 = FlanetsPrjamokutnyj.MaterialFlanetsPrjamokutnyj(B, H, typProfil, number, polka, 1);
				materialCost += FlanetsPrjamokutnyj.materialCost1;
				for (int i = 0; i < 2; i++)
				{
					if (FlanetsPrjamokutnyj.materialName[i] != "")
					{
						materialName[num9 + i] = FlanetsPrjamokutnyj.materialName[i];
						for (int j = 0; j < 6; j++)
						{
							array[num9 + i, j] = ((j == 1) ? array2[i, j] : (array[num9 + i, j] + array2[i, j]));
						}
					}
				}
				num9 += 2;
			}
			if (typProfil == 2)
			{
				array2 = FlanetsPrjamokutnyj.MaterialFlanetsPrjamokutnyj(B, H, typProfil, number, polka, 1);
				materialCost += FlanetsPrjamokutnyj.materialCost1;
				for (int k = 0; k < 2; k++)
				{
					if (FlanetsPrjamokutnyj.materialName[k] != "")
					{
						materialName[num9 + k] = FlanetsPrjamokutnyj.materialName[k];
						for (int l = 0; l < 6; l++)
						{
							array[num9 + k, l] = ((l == 1) ? array2[k, l] : (array[num9 + k, l] + array2[k, l]));
						}
					}
				}
				num9 += 2;
			}
			if (typProfil == 1 || typProfil == 2)
			{
				double[,] array3 = new double[1, 6];
				array3 = HvyntNaFlanets.MaterialHvyntNaFlanets(B, H, 1, number);
				materialCost += HvyntNaFlanets.materialCost1;
				materialName[num9] = HvyntNaFlanets.materialName1[0];
				for (int m = 0; m < 6; m++)
				{
					array[num9, m] = array3[0, m];
				}
				num9++;
			}
			if (typProfil == 3)
			{
				array2 = FlanetsPrjamokutnyj.MaterialFlanetsPrjamokutnyj(B, H, typProfil, number, polka, 1);
				materialCost += FlanetsPrjamokutnyj.materialCost1;
				if (FlanetsPrjamokutnyj.materialName[0] != "")
				{
					materialName[num9] = FlanetsPrjamokutnyj.materialName[0];
					for (int n = 0; n < 6; n++)
					{
						array[num9, n] = ((n == 1) ? array2[0, n] : (array[num9, n] + array2[0, n]));
					}
				}
				num9++;
			}
			if (typProfil == 4)
			{
				array2 = FlanetsPrjamokutnyj.MaterialFlanetsPrjamokutnyj(B, H, typProfil, number, polka, 1);
				materialCost += FlanetsPrjamokutnyj.materialCost1;
				if (FlanetsPrjamokutnyj.materialName[0] != "")
				{
					materialName[num9] = FlanetsPrjamokutnyj.materialName[0];
					for (int num10 = 0; num10 < 6; num10++)
					{
						array[num9, num10] = ((num10 == 1) ? array2[0, num10] : (array[num9, num10] + array2[0, num10]));
					}
				}
			}
		}
		return array;
	}

	public static double PriceZaglushkaZP(int B, int H, int M, int markaStali, double tovchynaMetalu, int typZP, int typProfil)
	{
		double num = 1.0;
		int num2 = ((B >= H) ? B : H);
		if (M == 0)
		{
			M = ((num2 < 630) ? 40 : 80);
		}
		materialSpendingCommercialOffer = (double)(B * H + 2 * (B + H) * M) / 1000000.0;
		switch (markaStali)
		{
		case 1:
		{
			if (tovchynaMetalu == 0.0)
			{
				tovchynaMetalu = ((num2 > 400) ? ((num2 <= 800) ? 0.7 : 0.9) : 0.5);
			}
			double num7 = tovchynaMetalu;
			double num8 = num7;
			num = ((num8 == 0.5) ? 287.5 : ((num8 == 0.65) ? 333.5 : ((num8 == 0.68) ? 333.5 : ((num8 == 0.7) ? 333.5 : ((num8 == 0.9) ? 400.0 : ((num8 == 1.0) ? 400.0 : ((num8 != 1.2) ? 0.0 : 173.19)))))));
			num *= 4.0;
			break;
		}
		case 2:
		{
			if (tovchynaMetalu == 0.0)
			{
				tovchynaMetalu = ((num2 > 400) ? ((num2 <= 800) ? 0.8 : 1.0) : 0.5);
			}
			double num5 = tovchynaMetalu;
			double num6 = num5;
			num = ((num6 == 0.5) ? 110.0 : ((num6 == 0.8) ? 140.0 : ((num6 == 1.0) ? 200.0 : ((num6 == 1.2) ? 250.0 : ((num6 == 1.5) ? 300.0 : ((num6 == 2.0) ? 350.0 : ((num6 == 2.5) ? 400.0 : ((num6 == 3.0) ? 500.0 : ((num6 == 4.0) ? 600.0 : ((num6 == 5.0) ? 700.0 : ((num6 != 6.0) ? 0.0 : 800.0)))))))))));
			num *= 4.0;
			break;
		}
		case 3:
		{
			if (tovchynaMetalu == 0.0)
			{
				tovchynaMetalu = ((num2 > 400) ? ((num2 <= 800) ? 0.8 : 1.0) : 0.5);
			}
			double num3 = tovchynaMetalu;
			double num4 = num3;
			num = ((num4 == 0.5) ? 110.0 : ((num4 == 0.8) ? 200.0 : ((num4 == 1.0) ? 250.0 : ((num4 == 1.2) ? 300.0 : ((num4 != 1.5) ? 0.0 : 400.0)))));
			num *= 4.0;
			break;
		}
		}
		double num9 = materialSpendingCommercialOffer * num;
		if (materialSpendingCommercialOffer < 0.005)
		{
			materialSpendingCommercialOffer = Math.Round(1000.0 * materialSpendingCommercialOffer) / 1000.0;
		}
		else
		{
			materialSpendingCommercialOffer = Math.Round(100.0 * materialSpendingCommercialOffer) / 100.0;
		}
		if (markaStali == 1 && typZP == 1)
		{
			if (typProfil == 0)
			{
				typProfil = ((num2 < 800) ? 1 : 2);
			}
			if (typProfil == 1)
			{
				num9 += 2.0 * (double)(B + H) * Consts2.profilS20.Price * 4.0 / 1000.0;
				num9 += 4.0 * Consts2.kutnykS20.Price * 4.0;
			}
			else
			{
				num9 += 2.0 * (double)(B + H) * Consts2.profilS30.Price * 4.0 / 1000.0;
				num9 += 4.0 * Consts2.kutnykS30.Price * 4.0;
			}
		}
		tovchynaMetaluCommercialOffer = tovchynaMetalu;
		return num9;
	}

	public static double CalculateZarplataZagluskaZP(int B, int H, double tovchynaMetalu, int typZP, int typProfil, int number, int M = 40, bool kriplennia = false)
	{
		double num = CalculateBaseSalary(B, H, tovchynaMetalu, typZP, typProfil, M, kriplennia);
		return num * (double)number;
	}

	private static double CalculateBaseSalary(int B, int H, double tovchynaMetalu, int typZP, int typProfil, int M = 40, bool kriplennia = false)
	{
		double num = 0.0;
		double num2 = 0.0;
		double num3 = Math.Round((double)(B * H + 2 * (B + H) * M) / 1000000.0, 2);
		if (tovchynaMetalu > 0.5 && tovchynaMetalu <= 0.7)
		{
			tovchynaMetalu = 0.7;
		}
		else if (tovchynaMetalu > 0.7 && tovchynaMetalu <= 1.0)
		{
			tovchynaMetalu = 1.0;
		}
		double num4 = 1.0;
		double num5 = ((num3 <= 0.3) ? 130.0 : ((!(num3 <= 1.0)) ? 50.0 : 70.0));
		double num6 = tovchynaMetalu;
		double num7 = num6;
		double num8;
		double num9;
		if (num7 != 0.5)
		{
			if (num7 != 0.7)
			{
				if (num7 != 1.0)
				{
					throw new ArgumentOutOfRangeException("tovchynaMetalu");
				}
				num8 = 1.3;
				num9 = 1.05;
			}
			else
			{
				num8 = 1.15;
				num9 = 1.02;
			}
		}
		else
		{
			num8 = 1.0;
			num9 = 1.0;
		}
		int num10 = (B + 199) / 100 + 1;
		int num11 = (H + 199) / 100 + 1;
		if (typZP == 1)
		{
			num += ((typProfil == 1) ? 9.0 : 12.0);
			num2 += ((typProfil == 1) ? ((double)(num10 + num11) * 0.4) : ((double)(num10 + num11) * 0.45)) * num9;
		}
		if (kriplennia)
		{
			double num12 = tovchynaMetalu;
			double num13 = num12;
			if (num13 != 0.5)
			{
				if (num13 != 0.7)
				{
					if (num13 != 1.0)
					{
						throw new ArgumentOutOfRangeException("tovchynaMetalu");
					}
					num4 = 1.3;
				}
				else
				{
					num4 = 1.25;
				}
			}
			else
			{
				num4 = 1.2;
			}
		}
		num += (num3 * num5 * num8 + num2) * num4;
		return Math.Round(num, 2);
	}

	public static double VolumeZaglushkaZP(int B, int H, int M)
	{
		int num = ((B >= H) ? B : H);
		if (M == 0)
		{
			M = ((num < 630) ? 40 : 80);
		}
		return Math.Round((double)B * (double)H * (double)M / 1000000.0) / 1000.0;
	}
}
