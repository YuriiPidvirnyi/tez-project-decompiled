using System;
using TEZ_Project.Common.Helpers;

namespace TEZ_Project.Common.Products;

public static class HrestovynaHSP
{
	public static string[] materialName = new string[12]
	{
		"", "", "", "", "", "", "", "", "", "",
		"", ""
	};

	public static double materialCost;

	public static double materialSpendingCommercialOffer = 0.0;

	public static double tovchynaMetaluCommercialOffer = 0.0;

	public static double[,] MaterialHrestovynaHSP(int B, int B1, int B2, int H, int L, int r, int k, int k1, int markaStali, double tovchynaMetalu, int typHSPinput, int typHSPout, int typHSPleft, int typHSPright, int typProfilBH, int typProfilB1H1, int typProfilB2H2, int typProfilB3H3, int number, int polkaBH, int polkaB1H1, int polkaB2H2, int polkaB3H3, int vidbortovka, string aisiType = "430")
	{
		double[,] array = new double[12, 6];
		double num = 0.0;
		double num2 = 0.0;
		int num3 = ((B >= H) ? B : H);
		double num4 = 2.0 * (double)(B + H);
		double num5 = 2.0 * (double)(B1 + H);
		double num6 = 2.0 * (double)(B2 + H);
		double num7 = 0.0;
		L += vidbortovka;
		materialName = new string[12]
		{
			"", "", "", "", "", "", "", "", "", "",
			"", ""
		};
		materialCost = 0.0;
		if (B1 >= num3)
		{
			num3 = B1;
		}
		if (B2 >= num3)
		{
			num3 = B2;
		}
		switch (markaStali)
		{
		case 1:
		{
			if (tovchynaMetalu == 0.0)
			{
				tovchynaMetalu = ((num3 > 400) ? ((num3 <= 800) ? 0.7 : 0.9) : 0.5);
			}
			num = 7825.0;
			double num8 = tovchynaMetalu;
			double num9 = num8;
			if (num9 != 0.5)
			{
				if (num9 != 0.65)
				{
					if (num9 != 0.68)
					{
						if (num9 != 0.7)
						{
							if (num9 != 0.9)
							{
								if (num9 != 1.0)
								{
									if (num9 == 1.2)
									{
										materialName[0] = Consts2.lystOchynkovanyj12.MaterialName;
										num7 = Consts2.lystOchynkovanyj12.Price;
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
									num7 = Consts2.lystOchynkovanyj10.Price;
									num2 = 10.0;
								}
							}
							else
							{
								materialName[0] = Consts2.lystOchynkovanyj09.MaterialName;
								num7 = Consts2.lystOchynkovanyj09.Price;
								num2 = 10.0;
							}
						}
						else
						{
							materialName[0] = Consts2.lystOchynkovanyj07.MaterialName;
							num7 = Consts2.lystOchynkovanyj07.Price;
							num2 = 10.0;
						}
					}
					else
					{
						materialName[0] = Consts2.lystOchynkovanyj068.MaterialName;
						num7 = Consts2.lystOchynkovanyj068.Price;
						num2 = 10.0;
					}
				}
				else
				{
					materialName[0] = Consts2.lystOchynkovanyj065.MaterialName;
					num7 = Consts2.lystOchynkovanyj065.Price;
					num2 = 10.0;
				}
			}
			else
			{
				materialName[0] = Consts2.lystOchynkovanyj05.MaterialName;
				num7 = Consts2.lystOchynkovanyj05.Price;
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
			double num10 = tovchynaMetalu;
			double num11 = num10;
			if (num11 != 0.5)
			{
				if (num11 != 0.8)
				{
					if (num11 != 1.0)
					{
						if (num11 != 1.2)
						{
							if (num11 != 1.5)
							{
								if (num11 != 2.0)
								{
									if (num11 != 2.5)
									{
										if (num11 != 3.0)
										{
											if (num11 != 4.0)
											{
												if (num11 != 5.0)
												{
													if (num11 == 6.0)
													{
														materialName[0] = Consts2.lystStalnyj60.MaterialName;
														num7 = Consts2.lystStalnyj60.Price;
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
													num7 = Consts2.lystStalnyj50.Price;
													num2 = 10.0;
												}
											}
											else
											{
												materialName[0] = Consts2.lystStalnyj40.MaterialName;
												num7 = Consts2.lystStalnyj40.Price;
												num2 = 10.0;
											}
										}
										else
										{
											materialName[0] = Consts2.lystStalnyj30.MaterialName;
											num7 = Consts2.lystStalnyj30.Price;
											num2 = 10.0;
										}
									}
									else
									{
										materialName[0] = Consts2.lystStalnyj25.MaterialName;
										num7 = Consts2.lystStalnyj25.Price;
										num2 = 10.0;
									}
								}
								else
								{
									materialName[0] = Consts2.lystStalnyj20.MaterialName;
									num7 = Consts2.lystStalnyj20.Price;
									num2 = 10.0;
								}
							}
							else
							{
								materialName[0] = Consts2.lystStalnyj15.MaterialName;
								num7 = Consts2.lystStalnyj15.Price;
								num2 = 10.0;
							}
						}
						else
						{
							materialName[0] = Consts2.lystStalnyj12.MaterialName;
							num7 = Consts2.lystStalnyj12.Price;
							num2 = 10.0;
						}
					}
					else
					{
						materialName[0] = Consts2.lystStalnyj10.MaterialName;
						num7 = Consts2.lystStalnyj10.Price;
						num2 = 10.0;
					}
				}
				else
				{
					materialName[0] = Consts2.lystStalnyj08.MaterialName;
					num7 = Consts2.lystStalnyj08.Price;
					num2 = 10.0;
				}
			}
			else
			{
				materialName[0] = Consts2.lystStalnyj05.MaterialName;
				num7 = Consts2.lystStalnyj05.Price;
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
			num7 = lystNerzavijuchyj.Price;
			break;
		}
		}
		double num12 = B + 10 + 2 * (k1 + r);
		double num13 = (double)L * num12;
		if (L > 2500)
		{
			num13 += 60.0 * num12;
		}
		else if (L > 1250)
		{
			num13 += 30.0 * num12;
		}
		if (num12 > 2500.0)
		{
			num13 += 60.0 * (double)L;
		}
		else if (num12 > 1250.0)
		{
			num13 += 30.0 * (double)L;
		}
		double num14 = (Math.PI * (double)r / 2.0 + (double)k + (double)k1) * (double)(H + 50);
		double num15 = B2 + r;
		double num16 = (double)r + (double)((B - B1) / 2);
		double num17 = Math.Sqrt(num15 * num15 - num16 * num16);
		double num18 = Math.Asin(num16 / num15);
		num12 = num15 * num18 + (double)L - num17 + (double)k1;
		double num19 = num12 * (double)(H + 50);
		if (H + 50 > 1250)
		{
			num19 += 30.0 * num12;
		}
		if (num12 > 2500.0)
		{
			num19 += 60.0 * (double)(H + 50);
		}
		else if (num12 > 1250.0)
		{
			num19 += 30.0 * (double)(H + 50);
		}
		array[0, 0] = 2.0 * (num13 + num14 + num19) * (1.0 + num2 / 100.0) / 1000000.0;
		num13 = num15 * num15 * num18 + num16 * num17 - Math.PI * (double)r * (double)r / 2.0;
		num13 += 2.0 * (double)B2 * (double)k1 + (double)(B1 * L);
		num13 += (Math.PI * (double)r / 2.0 + (double)k + (double)k1) * (double)H;
		num13 += (num15 * num18 + (double)L - num17 + (double)k1) * (double)H;
		num13 *= 2.0;
		num13 /= 1000000.0;
		num2 = Math.Round((array[0, 0] / num13 - 1.0) * 100.0);
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
		materialCost = array[0, 0] * num7;
		if (typHSPinput == 1 && typProfilBH == 0)
		{
			num3 = ((B >= H) ? B : H);
			typProfilBH = ((num3 < 800) ? 1 : 2);
		}
		if (typHSPout == 1 && typProfilB1H1 == 0)
		{
			num3 = ((B1 >= H) ? B1 : H);
			typProfilB1H1 = ((num3 < 800) ? 1 : 2);
		}
		if (typHSPleft == 1 && typProfilB2H2 == 0)
		{
			num3 = ((B2 >= H) ? B2 : H);
			typProfilB2H2 = ((num3 < 800) ? 1 : 2);
		}
		if (typHSPright == 1 && typProfilB3H3 == 0)
		{
			num3 = ((B2 >= H) ? B2 : H);
			typProfilB3H3 = ((num3 < 800) ? 1 : 2);
		}
		double[,] array2 = new double[2, 6];
		int num20 = 1;
		if (typProfilBH == 1 || typProfilB1H1 == 1 || typProfilB2H2 == 1 || typProfilB3H3 == 1)
		{
			if (typProfilBH == 1)
			{
				array2 = FlanetsPrjamokutnyj.MaterialFlanetsPrjamokutnyj(B, H, typProfilBH, number, polkaBH, 1);
				for (int i = 0; i < 2; i++)
				{
					if (FlanetsPrjamokutnyj.materialName[i] != "")
					{
						materialName[num20 + i] = FlanetsPrjamokutnyj.materialName[i];
						for (int j = 0; j < 6; j++)
						{
							array[num20 + i, j] = ((j == 1) ? array2[i, j] : (array[num20 + i, j] + array2[i, j]));
						}
					}
				}
				materialCost += FlanetsPrjamokutnyj.materialCost1;
			}
			if (typProfilB1H1 == 1)
			{
				array2 = FlanetsPrjamokutnyj.MaterialFlanetsPrjamokutnyj(B1, H, typProfilB1H1, number, polkaB1H1, 1);
				for (int l = 0; l < 2; l++)
				{
					if (FlanetsPrjamokutnyj.materialName[l] != "")
					{
						materialName[num20 + l] = FlanetsPrjamokutnyj.materialName[l];
						for (int m = 0; m < 6; m++)
						{
							array[num20 + l, m] = ((m == 1) ? array2[l, m] : (array[num20 + l, m] + array2[l, m]));
						}
					}
				}
				materialCost += FlanetsPrjamokutnyj.materialCost1;
			}
			if (typProfilB2H2 == 1)
			{
				array2 = FlanetsPrjamokutnyj.MaterialFlanetsPrjamokutnyj(B2, H, typProfilB2H2, number, polkaB2H2, 1);
				for (int n = 0; n < 2; n++)
				{
					if (FlanetsPrjamokutnyj.materialName[n] != "")
					{
						materialName[num20 + n] = FlanetsPrjamokutnyj.materialName[n];
						for (int num21 = 0; num21 < 6; num21++)
						{
							array[num20 + n, num21] = ((num21 == 1) ? array2[n, num21] : (array[num20 + n, num21] + array2[n, num21]));
						}
					}
				}
				materialCost += FlanetsPrjamokutnyj.materialCost1;
			}
			if (typProfilB3H3 == 1)
			{
				array2 = FlanetsPrjamokutnyj.MaterialFlanetsPrjamokutnyj(B2, H, typProfilB3H3, number, polkaB3H3, 1);
				for (int num22 = 0; num22 < 2; num22++)
				{
					if (FlanetsPrjamokutnyj.materialName[num22] != "")
					{
						materialName[num20 + num22] = FlanetsPrjamokutnyj.materialName[num22];
						for (int num23 = 0; num23 < 6; num23++)
						{
							array[num20 + num22, num23] = ((num23 == 1) ? array2[num22, num23] : (array[num20 + num22, num23] + array2[num22, num23]));
						}
					}
				}
				materialCost += FlanetsPrjamokutnyj.materialCost1;
			}
			num20 += 2;
		}
		if (typProfilBH == 2 || typProfilB1H1 == 2 || typProfilB2H2 == 2 || typProfilB3H3 == 2)
		{
			if (typProfilBH == 2)
			{
				array2 = FlanetsPrjamokutnyj.MaterialFlanetsPrjamokutnyj(B, H, typProfilBH, number, polkaBH, 1);
				for (int num24 = 0; num24 < 2; num24++)
				{
					if (FlanetsPrjamokutnyj.materialName[num24] != "")
					{
						materialName[num20 + num24] = FlanetsPrjamokutnyj.materialName[num24];
						for (int num25 = 0; num25 < 6; num25++)
						{
							array[num20 + num24, num25] = ((num25 == 1) ? array2[num24, num25] : (array[num20 + num24, num25] + array2[num24, num25]));
						}
					}
				}
				materialCost += FlanetsPrjamokutnyj.materialCost1;
			}
			if (typProfilB1H1 == 2)
			{
				array2 = FlanetsPrjamokutnyj.MaterialFlanetsPrjamokutnyj(B1, H, typProfilB1H1, number, polkaB1H1, 1);
				for (int num26 = 0; num26 < 2; num26++)
				{
					if (FlanetsPrjamokutnyj.materialName[num26] != "")
					{
						materialName[num20 + num26] = FlanetsPrjamokutnyj.materialName[num26];
						for (int num27 = 0; num27 < 6; num27++)
						{
							array[num20 + num26, num27] = ((num27 == 1) ? array2[num26, num27] : (array[num20 + num26, num27] + array2[num26, num27]));
						}
					}
				}
				materialCost += FlanetsPrjamokutnyj.materialCost1;
			}
			if (typProfilB2H2 == 2)
			{
				array2 = FlanetsPrjamokutnyj.MaterialFlanetsPrjamokutnyj(B2, H, typProfilB2H2, number, polkaB2H2, 1);
				for (int num28 = 0; num28 < 2; num28++)
				{
					if (FlanetsPrjamokutnyj.materialName[num28] != "")
					{
						materialName[num20 + num28] = FlanetsPrjamokutnyj.materialName[num28];
						for (int num29 = 0; num29 < 6; num29++)
						{
							array[num20 + num28, num29] = ((num29 == 1) ? array2[num28, num29] : (array[num20 + num28, num29] + array2[num28, num29]));
						}
					}
				}
				materialCost += FlanetsPrjamokutnyj.materialCost1;
			}
			if (typProfilB3H3 == 2)
			{
				array2 = FlanetsPrjamokutnyj.MaterialFlanetsPrjamokutnyj(B2, H, typProfilB3H3, number, polkaB3H3, 1);
				for (int num30 = 0; num30 < 2; num30++)
				{
					if (FlanetsPrjamokutnyj.materialName[num30] != "")
					{
						materialName[num20 + num30] = FlanetsPrjamokutnyj.materialName[num30];
						for (int num31 = 0; num31 < 6; num31++)
						{
							array[num20 + num30, num31] = ((num31 == 1) ? array2[num30, num31] : (array[num20 + num30, num31] + array2[num30, num31]));
						}
					}
				}
				materialCost += FlanetsPrjamokutnyj.materialCost1;
			}
			num20 += 2;
		}
		if (typProfilBH == 1 || typProfilBH == 2)
		{
			double[,] array3 = new double[1, 6];
			array3 = HvyntNaFlanets.MaterialHvyntNaFlanets(B, H, 1, number);
			materialName[num20] = HvyntNaFlanets.materialName1[0];
			for (int num32 = 0; num32 < 6; num32++)
			{
				array[num20, num32] = array3[0, num32];
			}
			materialCost += HvyntNaFlanets.materialCost1;
		}
		if (typProfilB1H1 == 1 || typProfilB1H1 == 2)
		{
			double[,] array4 = new double[1, 6];
			array4 = HvyntNaFlanets.MaterialHvyntNaFlanets(B1, H, 1, number);
			materialName[num20] = HvyntNaFlanets.materialName1[0];
			for (int num33 = 0; num33 < 6; num33++)
			{
				array[num20, num33] += array4[0, num33];
			}
			materialCost += HvyntNaFlanets.materialCost1;
		}
		if (typProfilB2H2 == 1 || typProfilB2H2 == 2)
		{
			double[,] array5 = new double[1, 6];
			array5 = HvyntNaFlanets.MaterialHvyntNaFlanets(B2, H, 1, number);
			materialName[num20] = HvyntNaFlanets.materialName1[0];
			for (int num34 = 0; num34 < 6; num34++)
			{
				array[num20, num34] += array5[0, num34];
			}
			materialCost += HvyntNaFlanets.materialCost1;
		}
		if (typProfilB3H3 == 1 || typProfilB3H3 == 2)
		{
			double[,] array6 = new double[1, 6];
			array6 = HvyntNaFlanets.MaterialHvyntNaFlanets(B2, H, 1, number);
			materialName[num20] = HvyntNaFlanets.materialName1[0];
			for (int num35 = 0; num35 < 6; num35++)
			{
				array[num20, num35] += array6[0, num35];
			}
			materialCost += HvyntNaFlanets.materialCost1;
		}
		if (typProfilBH == 1 || typProfilB1H1 == 1 || typProfilB2H2 == 1 || typProfilB3H3 == 1 || typProfilBH == 2 || typProfilB1H1 == 2 || typProfilB2H2 == 2 || typProfilB3H3 == 2)
		{
			num20++;
		}
		if (typProfilBH == 3 || typProfilB1H1 == 3 || typProfilB2H2 == 3 || typProfilB3H3 == 3)
		{
			if (typProfilBH == 3)
			{
				array2 = FlanetsPrjamokutnyj.MaterialFlanetsPrjamokutnyj(B, H, typProfilBH, number, polkaBH, 1);
				if (FlanetsPrjamokutnyj.materialName[0] != "")
				{
					materialName[num20] = FlanetsPrjamokutnyj.materialName[0];
					for (int num36 = 0; num36 < 6; num36++)
					{
						array[num20, num36] = ((num36 == 1) ? array2[0, num36] : (array[num20, num36] + array2[0, num36]));
					}
				}
				materialCost += FlanetsPrjamokutnyj.materialCost1;
			}
			if (typProfilB1H1 == 3)
			{
				array2 = FlanetsPrjamokutnyj.MaterialFlanetsPrjamokutnyj(B1, H, typProfilB1H1, number, polkaB1H1, 1);
				if (FlanetsPrjamokutnyj.materialName[0] != "")
				{
					materialName[num20] = FlanetsPrjamokutnyj.materialName[0];
					for (int num37 = 0; num37 < 6; num37++)
					{
						array[num20, num37] = ((num37 == 1) ? array2[0, num37] : (array[num20, num37] + array2[0, num37]));
					}
				}
				materialCost += FlanetsPrjamokutnyj.materialCost1;
			}
			if (typProfilB2H2 == 3)
			{
				array2 = FlanetsPrjamokutnyj.MaterialFlanetsPrjamokutnyj(B2, H, typProfilB2H2, number, polkaB2H2, 1);
				if (FlanetsPrjamokutnyj.materialName[0] != "")
				{
					materialName[num20] = FlanetsPrjamokutnyj.materialName[0];
					for (int num38 = 0; num38 < 6; num38++)
					{
						array[num20, num38] = ((num38 == 1) ? array2[0, num38] : (array[num20, num38] + array2[0, num38]));
					}
				}
				materialCost += FlanetsPrjamokutnyj.materialCost1;
			}
			if (typProfilB3H3 == 2)
			{
				array2 = FlanetsPrjamokutnyj.MaterialFlanetsPrjamokutnyj(B2, H, typProfilB3H3, number, polkaB3H3, 1);
				if (FlanetsPrjamokutnyj.materialName[0] != "")
				{
					materialName[num20] = FlanetsPrjamokutnyj.materialName[0];
					for (int num39 = 0; num39 < 6; num39++)
					{
						array[num20, num39] = ((num39 == 1) ? array2[0, num39] : (array[num20, num39] + array2[0, num39]));
					}
				}
				materialCost += FlanetsPrjamokutnyj.materialCost1;
			}
			num20++;
		}
		if (typProfilBH == 4 || typProfilB1H1 == 4 || typProfilB2H2 == 4 || typProfilB3H3 == 4)
		{
			if (typProfilBH == 4)
			{
				array2 = FlanetsPrjamokutnyj.MaterialFlanetsPrjamokutnyj(B, H, typProfilBH, number, polkaBH, 1);
				if (FlanetsPrjamokutnyj.materialName[0] != "")
				{
					materialName[num20] = FlanetsPrjamokutnyj.materialName[0];
					for (int num40 = 0; num40 < 6; num40++)
					{
						array[num20, num40] = ((num40 == 1) ? array2[0, num40] : (array[num20, num40] + array2[0, num40]));
					}
				}
				materialCost += FlanetsPrjamokutnyj.materialCost1;
			}
			if (typProfilB1H1 == 4)
			{
				array2 = FlanetsPrjamokutnyj.MaterialFlanetsPrjamokutnyj(B1, H, typProfilB1H1, number, polkaB1H1, 1);
				if (FlanetsPrjamokutnyj.materialName[0] != "")
				{
					materialName[num20] = FlanetsPrjamokutnyj.materialName[0];
					for (int num41 = 0; num41 < 6; num41++)
					{
						array[num20, num41] = ((num41 == 1) ? array2[0, num41] : (array[num20, num41] + array2[0, num41]));
					}
				}
				materialCost += FlanetsPrjamokutnyj.materialCost1;
			}
			if (typProfilB2H2 == 4)
			{
				array2 = FlanetsPrjamokutnyj.MaterialFlanetsPrjamokutnyj(B2, H, typProfilB2H2, number, polkaB2H2, 1);
				if (FlanetsPrjamokutnyj.materialName[0] != "")
				{
					materialName[num20] = FlanetsPrjamokutnyj.materialName[0];
					for (int num42 = 0; num42 < 6; num42++)
					{
						array[num20, num42] = ((num42 == 1) ? array2[0, num42] : (array[num20, num42] + array2[0, num42]));
					}
				}
				materialCost += FlanetsPrjamokutnyj.materialCost1;
			}
			if (typProfilB3H3 == 4)
			{
				array2 = FlanetsPrjamokutnyj.MaterialFlanetsPrjamokutnyj(B2, H, typProfilB3H3, number, polkaB3H3, 1);
				if (FlanetsPrjamokutnyj.materialName[0] != "")
				{
					materialName[num20] = FlanetsPrjamokutnyj.materialName[0];
					for (int num43 = 0; num43 < 6; num43++)
					{
						array[num20, num43] = ((num43 == 1) ? array2[0, num43] : (array[num20, num43] + array2[0, num43]));
					}
				}
				materialCost += FlanetsPrjamokutnyj.materialCost1;
			}
		}
		return array;
	}

	public static double PriceHrestovynaHSP(int B, int B1, int B2, int H, int L, int r, int k, int k1, int markaStali, double tovchynaMetalu, int typHSPinput, int typHSPout, int typHSPleft, int typHSPright, int vidbortovka)
	{
		double num = 1.0;
		int num2 = ((B >= H) ? B : H);
		L += vidbortovka;
		if (B1 >= num2)
		{
			num2 = B1;
		}
		if (B2 >= num2)
		{
			num2 = B2;
		}
		switch (markaStali)
		{
		case 1:
			if (tovchynaMetalu == 0.0)
			{
				tovchynaMetalu = ((num2 > 400) ? ((num2 <= 800) ? 0.7 : 0.9) : 0.5);
			}
			num = ((typHSPinput != 1 && typHSPout != 1 && typHSPleft != 1 && typHSPright != 1) ? ((!(tovchynaMetalu < 0.65)) ? ((tovchynaMetalu < 0.9) ? 406.0 : 520.0) : 345.0) : ((!(tovchynaMetalu < 0.65)) ? ((tovchynaMetalu < 0.9) ? 464.0 : 600.0) : 402.5));
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
		double num7 = B2 + r;
		double num8 = (double)r + (double)((B - B1) / 2);
		double num9 = Math.Sqrt(num7 * num7 - num8 * num8);
		double num10 = Math.Asin(num8 / num7);
		materialSpendingCommercialOffer = num7 * num7 * num10 + num8 * num9 - Math.PI * (double)r * (double)r / 2.0;
		materialSpendingCommercialOffer += 2.0 * (double)B2 * (double)k1 + (double)(B1 * L);
		materialSpendingCommercialOffer += (Math.PI * (double)r / 2.0 + (double)k + (double)k1) * (double)H;
		materialSpendingCommercialOffer += (num7 * num10 + (double)L - num9 + (double)k1) * (double)H;
		materialSpendingCommercialOffer *= 2.0;
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

	public static double VolumeHrestovynaHSP(int B, int H, int L, int r, int k1)
	{
		return Math.Round((double)H * (double)L * (double)(B + 2 * (r + k1)) / 1000000.0) / 1000.0;
	}
}
