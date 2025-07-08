using System;
using TEZ_Project.Common.Data;
using TEZ_Project.Common.Helpers;

namespace TEZ_Project.Common.Products;

public static class ObvidOP
{
	public static string[] materialName = new string[7] { "", "", "", "", "", "", "" };

	public static double materialCost;

	public static double materialSpendingCommercialOffer = 0.0;

	public static double tovchynaMetaluCommercialOffer = 0.0;

	public static double[,] MaterialObvidOP(int B, int H, int L, int C, int l, int k, int k1, int markaStali, double tovchynaMetalu, int typOP, int typProfilB1H1, int typProfilB2H2, int number, int polkaB1H1, int polkaB2H2, int vidbortovka = 0, string aisiType = "430")
	{
		double[,] array = new double[7, 6];
		double num = 0.0;
		double num2 = 0.0;
		int num3 = ((B >= H) ? B : H);
		double num4 = 2.0 * (double)(B + H);
		double num5 = 0.0;
		L += vidbortovka;
		materialName = new string[7] { "", "", "", "", "", "", "" };
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
			num2 = MaterialHelper.GetMaterialWithdrawalNerzavijka(tovchynaMetalu);
			num = 7825.0;
			CustomConst lystNerzavijuchyj = MaterialHelper.GetLystNerzavijuchyj(tovchynaMetalu, aisiType);
			materialName[0] = lystNerzavijuchyj?.MaterialName ?? "Лист НЕРЖ ??, м2";
			num5 = lystNerzavijuchyj.Price;
			break;
		}
		}
		double num10 = ((double)B + (double)C + 10.0) * (double)L;
		if (B + C + 10 > 2500)
		{
			num10 += 60.0 * (double)L;
		}
		if (B + C + 10 > 1250)
		{
			num10 += 30.0 * (double)L;
		}
		if (L > 2500)
		{
			num10 += 60.0 * (double)(B + C + 10);
		}
		else if (L > 1250)
		{
			num10 += 30.0 * (double)(B + C + 10);
		}
		double num11 = ((double)L - (double)k - (double)k1 - (double)l) / 2.0;
		double num12 = (double)B * (num11 - Math.Sqrt(num11 * num11 - (double)(2 * B * C) + (double)(C * C))) / (2.0 * (double)B - (double)C);
		double num13 = Math.Sqrt((num11 - num12) * (num11 - num12) + (double)(C * C));
		double num14 = 2.0 * (num12 + num13) + (double)k + (double)k1 + (double)l;
		double num15 = ((double)H + 50.0) * num14;
		if (num14 > 2500.0)
		{
			num15 += 60.0 * (double)(H + 50);
		}
		else if (num14 > 1250.0)
		{
			num15 += 30.0 * (double)(H + 50);
		}
		if (H + 50 > 2500)
		{
			num15 += 60.0 * num14;
		}
		else if (H + 50 > 1250)
		{
			num15 += 30.0 * num14;
		}
		array[0, 0] = 2.0 * (num10 + num15) * (1.0 + num2 / 100.0) / 1000000.0;
		num10 = 2.0 * (double)(B + H + 50 + 10) * num14 / 1000000.0;
		num2 = Math.Round((array[0, 0] / num10 - 1.0) * 100.0);
		if (num2 > 20.0)
		{
			num2 = 20.0;
			array[0, 0] = num10 * (1.0 + num2 / 100.0);
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
		if ((typOP == 1 || typOP == 2) && typProfilB1H1 == 0)
		{
			num3 = ((B >= H) ? B : H);
			typProfilB1H1 = ((num3 < 800) ? 1 : 2);
		}
		if (typOP == 1 && typProfilB2H2 == 0)
		{
			num3 = ((B >= H) ? B : H);
			typProfilB2H2 = ((num3 < 800) ? 1 : 2);
		}
		double[,] array2 = new double[2, 6];
		int num16 = 1;
		if (typProfilB1H1 == 1 || typProfilB2H2 == 1)
		{
			if (typProfilB1H1 == 1)
			{
				array2 = FlanetsPrjamokutnyj.MaterialFlanetsPrjamokutnyj(B, H, typProfilB1H1, number, polkaB1H1, 1);
				for (int i = 0; i < 2; i++)
				{
					if (FlanetsPrjamokutnyj.materialName[i] != "")
					{
						materialName[num16 + i] = FlanetsPrjamokutnyj.materialName[i];
						for (int j = 0; j < 6; j++)
						{
							array[num16 + i, j] = ((j == 1) ? array2[i, j] : (array[num16 + i, j] + array2[i, j]));
						}
					}
				}
				materialCost += FlanetsPrjamokutnyj.materialCost1;
			}
			if (typProfilB2H2 == 1)
			{
				array2 = FlanetsPrjamokutnyj.MaterialFlanetsPrjamokutnyj(B, H, typProfilB2H2, number, polkaB2H2, 1);
				for (int m = 0; m < 2; m++)
				{
					if (FlanetsPrjamokutnyj.materialName[m] != "")
					{
						materialName[num16 + m] = FlanetsPrjamokutnyj.materialName[m];
						for (int n = 0; n < 6; n++)
						{
							array[num16 + m, n] = ((n == 1) ? array2[m, n] : (array[num16 + m, n] + array2[m, n]));
						}
					}
				}
				materialCost += FlanetsPrjamokutnyj.materialCost1;
			}
			num16 += 2;
		}
		if (typProfilB1H1 == 2 || typProfilB2H2 == 2)
		{
			if (typProfilB1H1 == 2)
			{
				array2 = FlanetsPrjamokutnyj.MaterialFlanetsPrjamokutnyj(B, H, typProfilB1H1, number, polkaB1H1, 1);
				for (int num17 = 0; num17 < 2; num17++)
				{
					if (FlanetsPrjamokutnyj.materialName[num17] != "")
					{
						materialName[num16 + num17] = FlanetsPrjamokutnyj.materialName[num17];
						for (int num18 = 0; num18 < 6; num18++)
						{
							array[num16 + num17, num18] = ((num18 == 1) ? array2[num17, num18] : (array[num16 + num17, num18] + array2[num17, num18]));
						}
					}
				}
				materialCost += FlanetsPrjamokutnyj.materialCost1;
			}
			if (typProfilB2H2 == 2)
			{
				array2 = FlanetsPrjamokutnyj.MaterialFlanetsPrjamokutnyj(B, H, typProfilB2H2, number, polkaB2H2, 1);
				for (int num19 = 0; num19 < 2; num19++)
				{
					if (FlanetsPrjamokutnyj.materialName[num19] != "")
					{
						materialName[num16 + num19] = FlanetsPrjamokutnyj.materialName[num19];
						for (int num20 = 0; num20 < 6; num20++)
						{
							array[num16 + num19, num20] = ((num20 == 1) ? array2[num19, num20] : (array[num16 + num19, num20] + array2[num19, num20]));
						}
					}
				}
				materialCost += FlanetsPrjamokutnyj.materialCost1;
			}
			num16 += 2;
		}
		if (typProfilB1H1 == 1 || typProfilB1H1 == 2)
		{
			double[,] array3 = new double[1, 6];
			array3 = HvyntNaFlanets.MaterialHvyntNaFlanets(B, H, 1, number);
			materialName[num16] = HvyntNaFlanets.materialName1[0];
			for (int num21 = 0; num21 < 6; num21++)
			{
				array[num16, num21] = array3[0, num21];
			}
			materialCost += HvyntNaFlanets.materialCost1;
		}
		if (typProfilB2H2 == 1 || typProfilB2H2 == 2)
		{
			double[,] array4 = new double[1, 6];
			array4 = HvyntNaFlanets.MaterialHvyntNaFlanets(B, H, 1, number);
			materialName[num16] = HvyntNaFlanets.materialName1[0];
			for (int num22 = 0; num22 < 6; num22++)
			{
				array[num16, num22] += array4[0, num22];
			}
			materialCost += HvyntNaFlanets.materialCost1;
		}
		if (typProfilB1H1 == 1 || typProfilB1H1 == 2 || typProfilB2H2 == 1 || typProfilB2H2 == 2)
		{
			num16++;
		}
		if (typProfilB1H1 == 3 || typProfilB2H2 == 3)
		{
			if (typProfilB1H1 == 3)
			{
				array2 = FlanetsPrjamokutnyj.MaterialFlanetsPrjamokutnyj(B, H, typProfilB1H1, number, polkaB1H1, 1);
				if (FlanetsPrjamokutnyj.materialName[0] != "")
				{
					materialName[num16] = FlanetsPrjamokutnyj.materialName[0];
					for (int num23 = 0; num23 < 6; num23++)
					{
						array[num16, num23] = ((num23 == 1) ? array2[0, num23] : (array[num16, num23] + array2[0, num23]));
					}
				}
				materialCost += FlanetsPrjamokutnyj.materialCost1;
			}
			if (typProfilB2H2 == 3)
			{
				array2 = FlanetsPrjamokutnyj.MaterialFlanetsPrjamokutnyj(B, H, typProfilB2H2, number, polkaB2H2, 1);
				if (FlanetsPrjamokutnyj.materialName[0] != "")
				{
					materialName[num16] = FlanetsPrjamokutnyj.materialName[0];
					for (int num24 = 0; num24 < 6; num24++)
					{
						array[num16, num24] = ((num24 == 1) ? array2[0, num24] : (array[num16, num24] + array2[0, num24]));
					}
				}
				materialCost += FlanetsPrjamokutnyj.materialCost1;
			}
			num16++;
		}
		if (typProfilB1H1 == 4 || typProfilB2H2 == 4)
		{
			if (typProfilB1H1 == 4)
			{
				array2 = FlanetsPrjamokutnyj.MaterialFlanetsPrjamokutnyj(B, H, typProfilB1H1, number, polkaB1H1, 1);
				if (FlanetsPrjamokutnyj.materialName[0] != "")
				{
					materialName[num16] = FlanetsPrjamokutnyj.materialName[0];
					for (int num25 = 0; num25 < 6; num25++)
					{
						array[num16, num25] = ((num25 == 1) ? array2[0, num25] : (array[num16, num25] + array2[0, num25]));
					}
				}
				materialCost += FlanetsPrjamokutnyj.materialCost1;
			}
			if (typProfilB2H2 == 4)
			{
				array2 = FlanetsPrjamokutnyj.MaterialFlanetsPrjamokutnyj(B, H, typProfilB2H2, number, polkaB2H2, 1);
				if (FlanetsPrjamokutnyj.materialName[0] != "")
				{
					materialName[num16] = FlanetsPrjamokutnyj.materialName[0];
					for (int num26 = 0; num26 < 6; num26++)
					{
						array[num16, num26] = ((num26 == 1) ? array2[0, num26] : (array[num16, num26] + array2[0, num26]));
					}
				}
				materialCost += FlanetsPrjamokutnyj.materialCost1;
			}
		}
		return array;
	}

	public static double PriceObvidOP(int B, int H, int L, int C, int l, int k, int k1, int markaStali, double tovchynaMetalu, int typOP, int vidbortovka = 0)
	{
		double num = 1.0;
		int num2 = ((B >= H) ? B : H);
		L += vidbortovka;
		switch (markaStali)
		{
		case 1:
			if (tovchynaMetalu == 0.0)
			{
				tovchynaMetalu = ((num2 > 400) ? ((num2 <= 800) ? 0.7 : 0.9) : 0.5);
			}
			num = ((typOP > 2) ? ((!(tovchynaMetalu < 0.65)) ? ((tovchynaMetalu < 0.9) ? 406.0 : 520.0) : 345.0) : ((!(tovchynaMetalu < 0.65)) ? ((tovchynaMetalu < 0.9) ? 464.0 : 600.0) : 402.5));
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
		double num7 = ((double)L - (double)k - (double)k1 - (double)l) / 2.0;
		double num8 = (double)B * (num7 - Math.Sqrt(num7 * num7 - (double)(2 * B * C) + (double)(C * C))) / (2.0 * (double)B - (double)C);
		double num9 = Math.Sqrt((num7 - num8) * (num7 - num8) + (double)(C * C));
		materialSpendingCommercialOffer = 2.0 * (double)(B + H) * (2.0 * (num8 + num9) + (double)k + (double)k1 + (double)l) / 1000000.0;
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

	public static double VolumeObvidOP(int B, int H, int L, int C)
	{
		return Math.Round((double)H * (double)(B + C) * (double)L / 1000000.0) / 1000.0;
	}
}
