using System;
using TEZ_Project.Common.Helpers;
using TEZ_Project;

namespace TEZ_Project.Common.Products;

public static class VidvidVSP
{
	public static string[] materialName = new string[5] { "", "", "", "", "" };

	public static double materialCost;

	public static double materialSpendingCommercialOffer = 0.0;

	public static double tovchynaMetaluCommercialOffer = 0.0;

	public static double[,] MaterialVidvidVSP(int B, int H, int k1, int k2, int r, int Angle, int markaStali, double tovchynaMetalu, int typVSP, int typProfil, int number, int polka, string aisiType = "430")
	{
		double[,] array = new double[5, 6];
		double num = 0.0;
		double num2 = 0.0;
		int num3 = ((B >= H) ? B : H);
		double num4 = 0.0;
		materialName = new string[5] { "", "", "", "", "" };
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
										num4 = Consts2.lystOchynkovanyj12.Price;
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
									num4 = Consts2.lystOchynkovanyj10.Price;
									num2 = 10.0;
								}
							}
							else
							{
								materialName[0] = Consts2.lystOchynkovanyj09.MaterialName;
								num4 = Consts2.lystOchynkovanyj09.Price;
								num2 = 10.0;
							}
						}
						else
						{
							materialName[0] = Consts2.lystOchynkovanyj07.MaterialName;
							num4 = Consts2.lystOchynkovanyj07.Price;
							num2 = 10.0;
						}
					}
					else
					{
						materialName[0] = Consts2.lystOchynkovanyj068.MaterialName;
						num4 = Consts2.lystOchynkovanyj068.Price;
						num2 = 10.0;
					}
				}
				else
				{
					materialName[0] = Consts2.lystOchynkovanyj065.MaterialName;
					num4 = Consts2.lystOchynkovanyj065.Price;
					num2 = 10.0;
				}
			}
			else
			{
				materialName[0] = Consts2.lystOchynkovanyj05.MaterialName;
				num4 = Consts2.lystOchynkovanyj05.Price;
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
														num4 = Consts2.lystStalnyj60.Price;
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
													num4 = Consts2.lystStalnyj50.Price;
													num2 = 10.0;
												}
											}
											else
											{
												materialName[0] = Consts2.lystStalnyj40.MaterialName;
												num4 = Consts2.lystStalnyj40.Price;
												num2 = 10.0;
											}
										}
										else
										{
											materialName[0] = Consts2.lystStalnyj30.MaterialName;
											num4 = Consts2.lystStalnyj30.Price;
											num2 = 10.0;
										}
									}
									else
									{
										materialName[0] = Consts2.lystStalnyj25.MaterialName;
										num4 = Consts2.lystStalnyj25.Price;
										num2 = 10.0;
									}
								}
								else
								{
									materialName[0] = Consts2.lystStalnyj20.MaterialName;
									num4 = Consts2.lystStalnyj20.Price;
									num2 = 10.0;
								}
							}
							else
							{
								materialName[0] = Consts2.lystStalnyj15.MaterialName;
								num4 = Consts2.lystStalnyj15.Price;
								num2 = 10.0;
							}
						}
						else
						{
							materialName[0] = Consts2.lystStalnyj12.MaterialName;
							num4 = Consts2.lystStalnyj12.Price;
							num2 = 10.0;
						}
					}
					else
					{
						materialName[0] = Consts2.lystStalnyj10.MaterialName;
						num4 = Consts2.lystStalnyj10.Price;
						num2 = 10.0;
					}
				}
				else
				{
					materialName[0] = Consts2.lystStalnyj08.MaterialName;
					num4 = Consts2.lystStalnyj08.Price;
					num2 = 10.0;
				}
			}
			else
			{
				materialName[0] = Consts2.lystStalnyj05.MaterialName;
				num4 = Consts2.lystStalnyj05.Price;
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
			CustomConst lystNerzavijuchyj = MaterialHelper.GetLystNerzavijuchyj(tovchynaMetalu, aisiType);
			materialName[0] = lystNerzavijuchyj?.MaterialName ?? "Лист НЕРЖ ??, м2";
			num4 = lystNerzavijuchyj.Price;
			break;
		}
		}
		double num9 = Math.Sin(Math.PI * (double)Angle / 180.0);
		if (r == 0)
		{
			double num10 = (double)B + (double)k1 * num9 + 10.0;
			double num11 = (double)B + (double)k2 * num9 + 10.0;
			double num12 = num10 * num11 / num9;
			if (num10 > 2500.0)
			{
				num12 += 60.0 * num11 / num9;
			}
			else if (num10 > 1250.0)
			{
				num12 += 30.0 * num11 / num9;
			}
			if (num11 > 2500.0)
			{
				num12 += 60.0 * num10 / num9;
			}
			else if (num11 > 1250.0)
			{
				num12 += 30.0 * num10 / num9;
			}
			num10 = (double)(k1 + k2) + Math.PI * (double)B * (double)Angle / 180.0;
			double num13 = num10 * (double)(H + 50);
			if (H + 50 > 2500)
			{
				num13 += 60.0 * num10;
			}
			else if (H + 50 > 1250)
			{
				num13 += 30.0 * num10;
			}
			if (num10 > 2500.0)
			{
				num13 += 60.0 * (double)(H + 50);
			}
			else if (num10 > 1250.0)
			{
				num13 += 30.0 * (double)(H + 50);
			}
			double num14 = (H + 50) * (k1 + k2);
			if (H + 50 > 2500)
			{
				num14 += 60.0 * (double)(k1 + k2);
			}
			else if (H + 50 > 1250)
			{
				num14 += 30.0 * (double)(k1 + k2);
			}
			if (k1 + k2 > 2500)
			{
				num14 += 60.0 * (double)(H + 50);
			}
			else if (k1 + k2 > 1250)
			{
				num14 += 30.0 * (double)(H + 50);
			}
			double num15 = ((typVSP == 4) ? (2 * (B + H) * 40) : 0);
			if (typVSP == 3 || typVSP == 7)
			{
				num15 += (double)((B + 80) * (H + 80));
			}
			array[0, 0] = (2.0 * num12 + num13 + num14 + num15) * (1.0 + num2 / 100.0) / 1000000.0;
			num12 = 2.0 * (double)(B + 10) * (Math.PI * (double)B * (double)Angle / 360.0 + (double)k1 + (double)k2);
			num12 += (double)(H + 50) * (2.0 * (double)(k1 + k2) + Math.PI * (double)B * (double)Angle / 180.0) + num15;
			num12 /= 1000000.0;
			num2 = Math.Round((array[0, 0] / num12 - 1.0) * 100.0);
			if (num2 > 20.0)
			{
				num2 = 20.0;
				array[0, 0] = num12 * (1.0 + num2 / 100.0);
			}
			array[0, 1] = num2 / 100.0;
		}
		else
		{
			double num16 = (double)(B + r) + (double)k1 * num9 + 10.0;
			double num17 = (double)(B + r) + (double)k2 * num9 + 10.0;
			double num12 = num16 * num17 / num9;
			if (num16 > 2500.0)
			{
				num12 += 60.0 * num17 / num9;
			}
			else if (num16 > 1250.0)
			{
				num12 += 30.0 * num17 / num9;
			}
			if (num17 > 2500.0)
			{
				num12 += 60.0 * num16 / num9;
			}
			else if (num17 > 1250.0)
			{
				num12 += 30.0 * num16 / num9;
			}
			num16 = (double)(k1 + k2) + Math.PI * (double)(B + r) * (double)Angle / 180.0;
			double num13 = num16 * (double)(H + 50);
			if (H + 50 > 2500)
			{
				num13 += 60.0 * num16;
			}
			else if (H + 50 > 1250)
			{
				num13 += 30.0 * num16;
			}
			if (num16 > 2500.0)
			{
				num13 += 60.0 * (double)(H + 50);
			}
			else if (num16 > 1250.0)
			{
				num13 += 30.0 * (double)(H + 50);
			}
			double num14 = (double)(H + 50) * ((double)(k1 + k2) + Math.PI * (double)r * (double)Angle / 180.0);
			if (H + 50 > 2500)
			{
				num14 += 60.0 * (double)(k1 + k2);
			}
			else if (H + 50 > 1250)
			{
				num14 += 30.0 * (double)(k1 + k2);
			}
			if (k1 + k2 > 2500)
			{
				num14 += 60.0 * (double)(H + 50);
			}
			else if (k1 + k2 > 1250)
			{
				num14 += 30.0 * (double)(H + 50);
			}
			double num15 = ((typVSP == 4) ? (2 * (B + H) * 40) : 0);
			if (typVSP == 3 || typVSP == 7)
			{
				num15 += (double)((B + 80) * (H + 80));
			}
			array[0, 0] = (2.0 * num12 + num13 + num14 + num15) * (1.0 + num2 / 100.0) / 1000000.0;
			num12 = (double)(H + 50) * (Math.PI * (double)r * (double)Angle / 180.0 + (double)k1 + (double)k2);
			num12 += 2.0 * (Math.PI * (Math.Pow(B + 10 + r, 2.0) - Math.Pow(r, 2.0)) / 4.0 + (double)((B + 10) * (k1 + k1)));
			num12 += (double)(H + 50) * (Math.PI * (double)(B + r) * (double)Angle / 180.0 + (double)k1 + (double)k2);
			num12 /= 1000000.0;
			num2 = Math.Round((array[0, 0] / num12 - 1.0) * 100.0);
			if (num2 > 20.0)
			{
				num2 = 20.0;
				array[0, 0] = num12 * (1.0 + num2 / 100.0);
			}
			array[0, 1] = num2 / 100.0;
		}
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
		materialCost = array[0, 0] * num4;
		int num18 = ((typVSP != 1) ? ((typVSP == 2 || typVSP == 3 || typVSP == 4) ? 1 : 0) : 2);
		if (num18 > 0)
		{
			if (typProfil == 0)
			{
				typProfil = ((num3 < 800) ? 1 : 2);
			}
			double[,] array2 = new double[2, 6];
			int num19 = 1;
			array2 = FlanetsPrjamokutnyj.MaterialFlanetsPrjamokutnyj(B, H, typProfil, number, polka, num18);
			materialCost += FlanetsPrjamokutnyj.materialCost1;
			for (int i = 0; i < 2; i++)
			{
				if (FlanetsPrjamokutnyj.materialName[i] != "")
				{
					materialName[num19] = FlanetsPrjamokutnyj.materialName[i];
					for (int j = 0; j < 6; j++)
					{
						array[num19, j] = array2[i, j];
					}
					num19++;
				}
			}
			if (typProfil <= 2)
			{
				double[,] array3 = new double[1, 6];
				array3 = HvyntNaFlanets.MaterialHvyntNaFlanets(B, H, num18, number);
				materialCost += HvyntNaFlanets.materialCost1;
				materialName[num19] = HvyntNaFlanets.materialName1[0];
				for (int l = 0; l < 6; l++)
				{
					array[num19, l] = array3[0, l];
				}
				num19++;
			}
			if (typVSP == 4)
			{
				materialName[num19] = Consts2.sitka25x25.MaterialName;
				array[num19, 0] = (double)(B + 40) * (double)(H + 40) * 1.15 / 1000000.0;
				if (array[num19, 0] < 0.005)
				{
					array[num19, 0] = Math.Round(1000.0 * array[num19, 0]) / 1000.0;
				}
				else
				{
					array[num19, 0] = Math.Round(100.0 * array[num19, 0]) / 100.0;
				}
				array[num19, 1] = 0.15;
				array[num19, 4] = array[num19, 0] * (double)number;
				array[num19, 2] = array[num19, 4] * array[num19, 1];
			}
		}
		return array;
	}

	public static double PriceVidvidVSP(int B, int H, int k1, int k2, int r, int Angle, int markaStali, double tovchynaMetalu, int typVSP)
	{
		double num = 1.0;
		int num2 = ((B >= H) ? B : H);
		switch (markaStali)
		{
		case 1:
			if (tovchynaMetalu == 0.0)
			{
				tovchynaMetalu = ((num2 > 400) ? ((num2 <= 800) ? 0.7 : 0.9) : 0.5);
			}
			num = ((typVSP > 4) ? ((!(tovchynaMetalu < 0.65)) ? ((tovchynaMetalu < 0.9) ? 406.0 : 520.0) : 345.0) : ((!(tovchynaMetalu < 0.65)) ? ((tovchynaMetalu < 0.9) ? 464.0 : 600.0) : 402.5));
			break;
		case 2:
		{
			if (tovchynaMetalu == 0.0)
			{
				tovchynaMetalu = ((num2 > 400) ? ((num2 <= 800) ? 0.8 : 1.0) : 0.5);
			}
			double num5 = tovchynaMetalu;
			double num6 = num5;
			num = ((num6 == 0.5) ? 110.0 : ((num6 == 0.8) ? 140.0 : ((num6 == 1.0) ? 200.0 : ((num6 == 1.2) ? 250.0 : ((num6 == 1.5) ? 300.0 : ((num6 == 2.0) ? 350.0 : ((num6 == 2.5) ? 400.0 : ((num6 == 3.0) ? 500.0 : ((num6 == 4.0) ? 600.0 : ((num6 == 5.0) ? 700.0 : ((num6 != 6.0) ? 0.0 : 800.0)))))))))));
			num *= 1.8;
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
			num *= 1.7;
			break;
		}
		}
		if (r == 0)
		{
			materialSpendingCommercialOffer = (k1 + k2) * H;
			materialSpendingCommercialOffer += 2.0 * (double)B * (Math.PI * (double)B * (double)Angle / 360.0 + (double)k1 + (double)k2);
			materialSpendingCommercialOffer += (double)H * (Math.PI * (double)B * (double)Angle / 180.0 + (double)k1 + (double)k2);
		}
		else
		{
			materialSpendingCommercialOffer = (double)H * (Math.PI * (double)r * (double)Angle / 180.0 + (double)k1 + (double)k2);
			materialSpendingCommercialOffer += 2.0 * (Math.PI * (Math.Pow(B + r, 2.0) - Math.Pow(r, 2.0)) / 4.0 + (double)(B * (k1 + k1)));
			materialSpendingCommercialOffer += (double)H * (Math.PI * (double)(B + r) * (double)Angle / 180.0 + (double)k1 + (double)k2);
		}
		if (typVSP == 3 || typVSP == 7)
		{
			materialSpendingCommercialOffer += B * H;
		}
		materialSpendingCommercialOffer /= 1000000.0;
		double num7 = materialSpendingCommercialOffer * num;
		if (typVSP == 4)
		{
			num7 += 1.8 * Consts2.sitka25x25.Price * (double)B * (double)H / 1000000.0;
		}
		if (materialSpendingCommercialOffer < 0.005)
		{
			materialSpendingCommercialOffer = Math.Round(1000.0 * materialSpendingCommercialOffer) / 1000.0;
		}
		else
		{
			materialSpendingCommercialOffer = Math.Round(100.0 * materialSpendingCommercialOffer) / 100.0;
		}
		tovchynaMetaluCommercialOffer = tovchynaMetalu;
		return num7;
	}

	public static double VolumeVidvidVSP(int B, int H, int k1, int k2, int r)
	{
		return Math.Round((double)H * (double)(B + r + k1) * (double)(B + r + k2) / 1000000.0) / 1000.0;
	}

	public static double CalculateZarplataVidvidVSP(int B, int H, double metalThickness, int typVSP, int typProfil, int number, int k1 = 100, int k2 = 100, int r = 0, int angle = 90)
	{
		double num = CalculateBaseSalary(B, H, metalThickness, typVSP, typProfil, k1, k2, r, angle);
		return num * (double)number;
	}

	private static double CalculateBaseSalary(int B, int H, double metalThickness, int typVSP, int typProfil, int k1 = 100, int k2 = 100, int r = 0, int angle = 90)
	{
		double num = 0.0;
		double num2 = 0.0;
		double num3;
		if (r == 0)
		{
			num3 = (k1 + k2) * H;
			num3 += 2.0 * (double)B * (Math.PI * (double)B * (double)angle / 360.0 + (double)k1 + (double)k2);
			num3 += (double)H * (Math.PI * (double)B * (double)angle / 180.0 + (double)k1 + (double)k2);
		}
		else
		{
			num3 = (double)H * (Math.PI * (double)r * (double)angle / 180.0 + (double)k1 + (double)k2);
			num3 += 2.0 * (Math.PI * (Math.Pow(B + r, 2.0) - Math.Pow(r, 2.0)) / 4.0 + (double)(B * (k1 + k1)));
			num3 += (double)H * (Math.PI * (double)(B + r) * (double)angle / 180.0 + (double)k1 + (double)k2);
		}
		num3 /= 1000000.0;
		if (metalThickness > 0.5 && metalThickness <= 0.7)
		{
			metalThickness = 0.7;
		}
		else if (metalThickness > 0.7 && metalThickness <= 1.0)
		{
			metalThickness = 1.0;
		}
		double num4 = ((num3 <= 0.3) ? 130.0 : ((!(num3 <= 1.0)) ? 50.0 : 70.0));
		num3 = ((!(num3 < 0.005)) ? (Math.Round(100.0 * num3) / 100.0) : (Math.Round(1000.0 * num3) / 1000.0));
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
		int num9 = (B + 199) / 100 + 1;
		int num10 = (H + 199) / 100 + 1;
		if (typVSP == 1)
		{
			num += ((typProfil == 1) ? 18.0 : 24.0);
			num2 += ((typProfil == 1) ? ((double)((num9 + num10) * 2) * 0.4) : ((double)((num9 + num10) * 2) * 0.45)) * num8;
		}
		else if (typVSP == 2)
		{
			num += ((typProfil == 1) ? 9.0 : 12.0);
			num2 += ((typProfil == 1) ? ((double)(num9 + num10) * 0.4) : ((double)(num9 + num10) * 0.45)) * num8;
		}
		else if (typVSP == 3 || typVSP == 4)
		{
			num += ((typProfil == 1) ? 9.0 : 12.0);
			num2 += ((typProfil == 1) ? ((double)(num9 + num10) * 0.4) : ((double)(num9 + num10) * 0.45)) * num8;
			double num11 = ZaglushkaZP.CalculateZarplataZagluskaZP(B, H, metalThickness, 2, 0, 1, 40, kriplennia: true);
			num += num11;
		}
		else if (typVSP == 7)
		{
			double num11 = ZaglushkaZP.CalculateZarplataZagluskaZP(B, H, metalThickness, 2, 0, 1, 40, kriplennia: true);
			num += num11;
		}
		num += ((typVSP == 5 || typVSP == 6 || typVSP == 8) ? (num3 * num4 * num7) : (num2 + num3 * num4 * num7));
		return Math.Round(num, 2);
	}
}
