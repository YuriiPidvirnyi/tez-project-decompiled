using System;
using TEZ_Project.Common.Helpers;
using TEZ_Project;

namespace TEZ_Project.Common.Products;

public static class UtkaURVP
{
	public static string[] materialName = new string[7] { "", "", "", "", "", "", "" };

	public static double materialCost;

	public static double materialSpendingCommercialOffer = 0.0;

	public static double tovchynaMetaluCommercialOffer = 0.0;

	public static double[,] MaterialUtkaURVP(int B, int B1, int H, int L, int C, int k, int k1, int markaStali, double tovchynaMetalu, int typURVP, int typProfilB1H1, int typProfilB2H2, int number, int polkaBH, int polkaB1H1, int vidbortovka, string aisiType = "430")
	{
		double[,] array = new double[7, 6];
		double num = 0.0;
		double num2 = 0.0;
		int num3 = ((B >= H) ? B : H);
		double num4 = 0.0;
		L += vidbortovka;
		if (B1 > num3)
		{
			num3 = B1;
		}
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
			num2 = MaterialHelper.GetMaterialWithdrawalNerzavijka(tovchynaMetalu);
			num = 7825.0;
			CustomConst lystNerzavijuchyj = MaterialHelper.GetLystNerzavijuchyj(tovchynaMetalu, aisiType);
			materialName[0] = lystNerzavijuchyj?.MaterialName ?? "Лист НЕРЖ ??, м2";
			num4 = lystNerzavijuchyj.Price;
			break;
		}
		}
		double num9 = (double)C + (double)(B + B1) / 2.0 + 10.0;
		double num10 = num9 * (double)L;
		if (num9 > 2500.0)
		{
			num10 += 60.0 * (double)L;
		}
		else if (num9 > 1250.0)
		{
			num10 += 30.0 * (double)L;
		}
		if (L > 2500)
		{
			num10 += 60.0 * num9;
		}
		else if (L > 1250)
		{
			num10 += 30.0 * num9;
		}
		L -= k + k1;
		double num11 = C - (B - B1);
		double num12 = (double)B1 * ((double)L - Math.Sqrt((double)L * (double)L - (double)(2 * B1) * num11 + num11 * num11)) / ((double)(2 * B1) - num11);
		double num13 = Math.Sqrt(((double)L - num12) * ((double)L - num12) + num11 * num11);
		double num14 = (double)B * ((double)L - Math.Sqrt((double)L * (double)L - (double)(2 * B * C) + (double)(C * C))) / (double)(2 * B - C);
		double num15 = Math.Sqrt(((double)L - num14) * ((double)L - num14) + (double)(C * C));
		num9 = 2.0 * (double)(k + k1) + num12 + num13 + num14 + num15;
		double num16 = ((double)H + 50.0) * num9;
		if (num9 > 2500.0)
		{
			num16 += 60.0 * (double)(H + 50);
		}
		else if (num9 > 1250.0)
		{
			num16 += 30.0 * (double)(H + 50);
		}
		if (H + 50 > 2500)
		{
			num16 += 60.0 * num9;
		}
		else if (H + 50 > 1250)
		{
			num16 += 30.0 * num9;
		}
		array[0, 0] = (2.0 * num10 + num16) * (1.0 + num2 / 100.0) / 1000000.0;
		num10 = ((double)B + (double)B1) * (double)L + num11 * num12 + (double)C * num14 + (double)(2 * (B * k + B1 * k1)) + (double)(H + 50 + 10) * num9;
		num10 /= 1000000.0;
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
		materialCost = array[0, 0] * num4;
		if ((typURVP == 1 || typURVP == 2) && typProfilB1H1 == 0)
		{
			num3 = ((B >= H) ? B : H);
			typProfilB1H1 = ((num3 < 800) ? 1 : 2);
		}
		if ((typURVP == 1 || typURVP == 3) && typProfilB2H2 == 0)
		{
			num3 = ((B1 >= H) ? B1 : H);
			typProfilB2H2 = ((num3 < 800) ? 1 : 2);
		}
		double[,] array2 = new double[2, 6];
		int num17 = 1;
		if (typProfilB1H1 == 1 || typProfilB2H2 == 1)
		{
			if (typProfilB1H1 == 1)
			{
				array2 = FlanetsPrjamokutnyj.MaterialFlanetsPrjamokutnyj(B, H, typProfilB1H1, number, polkaBH, 1);
				materialCost += FlanetsPrjamokutnyj.materialCost1;
				for (int i = 0; i < 2; i++)
				{
					if (FlanetsPrjamokutnyj.materialName[i] != "")
					{
						materialName[num17 + i] = FlanetsPrjamokutnyj.materialName[i];
						for (int j = 0; j < 6; j++)
						{
							array[num17 + i, j] = ((j == 1) ? array2[i, j] : (array[num17 + i, j] + array2[i, j]));
						}
					}
				}
			}
			if (typProfilB2H2 == 1)
			{
				array2 = FlanetsPrjamokutnyj.MaterialFlanetsPrjamokutnyj(B1, H, typProfilB2H2, number, polkaB1H1, 1);
				materialCost += FlanetsPrjamokutnyj.materialCost1;
				for (int l = 0; l < 2; l++)
				{
					if (FlanetsPrjamokutnyj.materialName[l] != "")
					{
						materialName[num17 + l] = FlanetsPrjamokutnyj.materialName[l];
						for (int m = 0; m < 6; m++)
						{
							array[num17 + l, m] = ((m == 1) ? array2[l, m] : (array[num17 + l, m] + array2[l, m]));
						}
					}
				}
			}
			num17 += 2;
		}
		if (typProfilB1H1 == 2 || typProfilB2H2 == 2)
		{
			if (typProfilB1H1 == 2)
			{
				array2 = FlanetsPrjamokutnyj.MaterialFlanetsPrjamokutnyj(B, H, typProfilB1H1, number, polkaBH, 1);
				materialCost += FlanetsPrjamokutnyj.materialCost1;
				for (int n = 0; n < 2; n++)
				{
					if (FlanetsPrjamokutnyj.materialName[n] != "")
					{
						materialName[num17 + n] = FlanetsPrjamokutnyj.materialName[n];
						for (int num18 = 0; num18 < 6; num18++)
						{
							array[num17 + n, num18] = ((num18 == 1) ? array2[n, num18] : (array[num17 + n, num18] + array2[n, num18]));
						}
					}
				}
			}
			if (typProfilB2H2 == 2)
			{
				array2 = FlanetsPrjamokutnyj.MaterialFlanetsPrjamokutnyj(B1, H, typProfilB2H2, number, polkaB1H1, 1);
				materialCost += FlanetsPrjamokutnyj.materialCost1;
				for (int num19 = 0; num19 < 2; num19++)
				{
					if (FlanetsPrjamokutnyj.materialName[num19] != "")
					{
						materialName[num17 + num19] = FlanetsPrjamokutnyj.materialName[num19];
						for (int num20 = 0; num20 < 6; num20++)
						{
							array[num17 + num19, num20] = ((num20 == 1) ? array2[num19, num20] : (array[num17 + num19, num20] + array2[num19, num20]));
						}
					}
				}
			}
			num17 += 2;
		}
		if (typProfilB1H1 == 1 || typProfilB1H1 == 2)
		{
			double[,] array3 = new double[1, 6];
			array3 = HvyntNaFlanets.MaterialHvyntNaFlanets(B, H, 1, number);
			materialCost += HvyntNaFlanets.materialCost1;
			materialName[num17] = HvyntNaFlanets.materialName1[0];
			for (int num21 = 0; num21 < 6; num21++)
			{
				array[num17, num21] = array3[0, num21];
			}
		}
		if (typProfilB2H2 == 1 || typProfilB2H2 == 2)
		{
			double[,] array4 = new double[1, 6];
			array4 = HvyntNaFlanets.MaterialHvyntNaFlanets(B1, H, 1, number);
			materialCost += HvyntNaFlanets.materialCost1;
			materialName[num17] = HvyntNaFlanets.materialName1[0];
			for (int num22 = 0; num22 < 6; num22++)
			{
				array[num17, num22] += array4[0, num22];
			}
		}
		if (typProfilB1H1 == 1 || typProfilB2H2 == 1 || typProfilB1H1 == 2 || typProfilB2H2 == 2)
		{
			num17++;
		}
		if (typProfilB1H1 == 3 || typProfilB2H2 == 3)
		{
			if (typProfilB1H1 == 3)
			{
				array2 = FlanetsPrjamokutnyj.MaterialFlanetsPrjamokutnyj(B, H, typProfilB1H1, number, polkaBH, 1);
				materialCost += FlanetsPrjamokutnyj.materialCost1;
				if (FlanetsPrjamokutnyj.materialName[0] != "")
				{
					materialName[num17] = FlanetsPrjamokutnyj.materialName[0];
					for (int num23 = 0; num23 < 6; num23++)
					{
						array[num17, num23] = ((num23 == 1) ? array2[0, num23] : (array[num17, num23] + array2[0, num23]));
					}
				}
			}
			if (typProfilB2H2 == 3)
			{
				array2 = FlanetsPrjamokutnyj.MaterialFlanetsPrjamokutnyj(B1, H, typProfilB2H2, number, polkaB1H1, 1);
				materialCost += FlanetsPrjamokutnyj.materialCost1;
				if (FlanetsPrjamokutnyj.materialName[0] != "")
				{
					materialName[num17] = FlanetsPrjamokutnyj.materialName[0];
					for (int num24 = 0; num24 < 6; num24++)
					{
						array[num17, num24] = ((num24 == 1) ? array2[0, num24] : (array[num17, num24] + array2[0, num24]));
					}
				}
			}
			num17++;
		}
		if (typProfilB1H1 == 4 || typProfilB2H2 == 4)
		{
			if (typProfilB1H1 == 4)
			{
				array2 = FlanetsPrjamokutnyj.MaterialFlanetsPrjamokutnyj(B, H, typProfilB1H1, number, polkaBH, 1);
				materialCost += FlanetsPrjamokutnyj.materialCost1;
				if (FlanetsPrjamokutnyj.materialName[0] != "")
				{
					materialName[num17] = FlanetsPrjamokutnyj.materialName[0];
					for (int num25 = 0; num25 < 6; num25++)
					{
						array[num17, num25] = ((num25 == 1) ? array2[0, num25] : (array[num17, num25] + array2[0, num25]));
					}
				}
			}
			if (typProfilB2H2 == 4)
			{
				array2 = FlanetsPrjamokutnyj.MaterialFlanetsPrjamokutnyj(B1, H, typProfilB2H2, number, polkaB1H1, 1);
				materialCost += FlanetsPrjamokutnyj.materialCost1;
				if (FlanetsPrjamokutnyj.materialName[0] != "")
				{
					materialName[num17] = FlanetsPrjamokutnyj.materialName[0];
					for (int num26 = 0; num26 < 6; num26++)
					{
						array[num17, num26] = ((num26 == 1) ? array2[0, num26] : (array[num17, num26] + array2[0, num26]));
					}
				}
			}
		}
		return array;
	}

	public static double PriceUtkaURVP(int B, int B1, int H, int L, int C, int k, int k1, int markaStali, double tovchynaMetalu, int typURVP, int vidbortovka)
	{
		double num = 1.0;
		int num2 = ((B >= H) ? B : H);
		L += vidbortovka;
		if (B1 > num2)
		{
			num2 = B1;
		}
		switch (markaStali)
		{
		case 1:
			if (tovchynaMetalu == 0.0)
			{
				tovchynaMetalu = ((num2 > 400) ? ((num2 <= 800) ? 0.7 : 0.9) : 0.5);
			}
			num = ((typURVP > 3) ? ((!(tovchynaMetalu < 0.65)) ? ((tovchynaMetalu < 0.9) ? 406.0 : 520.0) : 345.0) : ((!(tovchynaMetalu < 0.65)) ? ((tovchynaMetalu < 0.9) ? 464.0 : 600.0) : 402.5));
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
		L -= k + k1;
		double num7 = C - (B - B1);
		double num8 = (double)B1 * ((double)L - Math.Sqrt((double)L * (double)L - (double)(2 * B1) * num7 + num7 * num7)) / ((double)(2 * B1) - num7);
		double num9 = Math.Sqrt(((double)L - num8) * ((double)L - num8) + num7 * num7);
		double num10 = (double)B * ((double)L - Math.Sqrt((double)L * (double)L - (double)(2 * B * C) + (double)(C * C))) / (double)(2 * B - C);
		double num11 = Math.Sqrt(((double)L - num10) * ((double)L - num10) + (double)(C * C));
		materialSpendingCommercialOffer = ((double)B + (double)B1) * (double)L + num7 * num8 + (double)C * num10 + (double)(2 * (B * k + B1 * k1));
		materialSpendingCommercialOffer += (double)H * ((double)(2 * (k + k1)) + num8 + num9 + num10 + num11);
		materialSpendingCommercialOffer /= 1000000.0;
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

	public static double VolumeUtkaURVP(int B1, int H, int L, int C)
	{
		return Math.Round((double)H * (double)(B1 + C) * (double)L / 1000000.0) / 1000.0;
	}
}
