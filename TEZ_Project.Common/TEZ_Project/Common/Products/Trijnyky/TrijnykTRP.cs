using System;

namespace TEZ_Project.Common.Products.Trijnyky;

public static class TrijnykTRP
{
	public static string[] materialName = new string[11]
	{
		"", "", "", "", "", "", "", "", "", "",
		""
	};

	public static double materialCost;

	public static double materialSpendingCommercialOffer = 0.0;

	public static double tovchynaMetaluCommercialOffer = 0.0;

	public static double[,] MaterialTrijnykTRP(int B, int H, int B1, int B2, int G, int k, int k1, int k2, int L, int r, int markaStali, double tovchynaMetalu, int typTRPenter, int typTRPout, int typTRPvidvid, int typProfilBH, int typProfilB1H1, int typProfilB2H2, int number, int polkaBH, int polkaB1H1, int polkaB2H2)
	{
		double[,] array = new double[11, 6];
		double num = 0.0;
		double num2 = 0.0;
		int num3 = ((B >= H) ? B : H);
		double num4 = 0.0;
		double num5 = 0.0;
		double num6 = 0.0;
		materialName = new string[11]
		{
			"", "", "", "", "", "", "", "", "", "",
			""
		};
		materialCost = 0.0;
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
			double num9 = tovchynaMetalu;
			double num10 = num9;
			if (num10 != 0.5)
			{
				if (num10 != 0.65)
				{
					if (num10 != 0.68)
					{
						if (num10 != 0.7)
						{
							if (num10 != 0.9)
							{
								if (num10 != 1.0)
								{
									if (num10 == 1.2)
									{
										materialName[0] = Consts2.lystOchynkovanyj12.MaterialName;
										num6 = Consts2.lystOchynkovanyj12.Price;
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
									num6 = Consts2.lystOchynkovanyj10.Price;
									num2 = 10.0;
								}
							}
							else
							{
								materialName[0] = Consts2.lystOchynkovanyj09.MaterialName;
								num6 = Consts2.lystOchynkovanyj09.Price;
								num2 = 10.0;
							}
						}
						else
						{
							materialName[0] = Consts2.lystOchynkovanyj07.MaterialName;
							num6 = Consts2.lystOchynkovanyj07.Price;
							num2 = 10.0;
						}
					}
					else
					{
						materialName[0] = Consts2.lystOchynkovanyj068.MaterialName;
						num6 = Consts2.lystOchynkovanyj068.Price;
						num2 = 10.0;
					}
				}
				else
				{
					materialName[0] = Consts2.lystOchynkovanyj065.MaterialName;
					num6 = Consts2.lystOchynkovanyj065.Price;
					num2 = 10.0;
				}
			}
			else
			{
				materialName[0] = Consts2.lystOchynkovanyj05.MaterialName;
				num6 = Consts2.lystOchynkovanyj05.Price;
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
			double num11 = tovchynaMetalu;
			double num12 = num11;
			if (num12 != 0.5)
			{
				if (num12 != 0.8)
				{
					if (num12 != 1.0)
					{
						if (num12 != 1.2)
						{
							if (num12 != 1.5)
							{
								if (num12 != 2.0)
								{
									if (num12 != 2.5)
									{
										if (num12 != 3.0)
										{
											if (num12 != 4.0)
											{
												if (num12 != 5.0)
												{
													if (num12 == 6.0)
													{
														materialName[0] = Consts2.lystStalnyj60.MaterialName;
														num6 = Consts2.lystStalnyj60.Price;
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
													num6 = Consts2.lystStalnyj50.Price;
													num2 = 10.0;
												}
											}
											else
											{
												materialName[0] = Consts2.lystStalnyj40.MaterialName;
												num6 = Consts2.lystStalnyj40.Price;
												num2 = 10.0;
											}
										}
										else
										{
											materialName[0] = Consts2.lystStalnyj30.MaterialName;
											num6 = Consts2.lystStalnyj30.Price;
											num2 = 10.0;
										}
									}
									else
									{
										materialName[0] = Consts2.lystStalnyj25.MaterialName;
										num6 = Consts2.lystStalnyj25.Price;
										num2 = 10.0;
									}
								}
								else
								{
									materialName[0] = Consts2.lystStalnyj20.MaterialName;
									num6 = Consts2.lystStalnyj20.Price;
									num2 = 10.0;
								}
							}
							else
							{
								materialName[0] = Consts2.lystStalnyj15.MaterialName;
								num6 = Consts2.lystStalnyj15.Price;
								num2 = 10.0;
							}
						}
						else
						{
							materialName[0] = Consts2.lystStalnyj12.MaterialName;
							num6 = Consts2.lystStalnyj12.Price;
							num2 = 10.0;
						}
					}
					else
					{
						materialName[0] = Consts2.lystStalnyj10.MaterialName;
						num6 = Consts2.lystStalnyj10.Price;
						num2 = 10.0;
					}
				}
				else
				{
					materialName[0] = Consts2.lystStalnyj08.MaterialName;
					num6 = Consts2.lystStalnyj08.Price;
					num2 = 10.0;
				}
			}
			else
			{
				materialName[0] = Consts2.lystStalnyj05.MaterialName;
				num6 = Consts2.lystStalnyj05.Price;
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
							if (num8 == 1.5)
							{
								materialName[0] = Consts2.lystNerzavijuchyj15.MaterialName;
								num6 = Consts2.lystNerzavijuchyj15.Price;
								num2 = 10.0;
							}
							else
							{
								materialName[0] = "Лист НЕРЖ ??, м2";
							}
						}
						else
						{
							materialName[0] = Consts2.lystNerzavijuchyj12.MaterialName;
							num6 = Consts2.lystNerzavijuchyj12.Price;
							num2 = 10.0;
						}
					}
					else
					{
						materialName[0] = Consts2.lystNerzavijuchyj10.MaterialName;
						num6 = Consts2.lystNerzavijuchyj10.Price;
						num2 = 10.0;
					}
				}
				else
				{
					materialName[0] = Consts2.lystNerzavijuchyj08.MaterialName;
					num6 = Consts2.lystNerzavijuchyj08.Price;
					num2 = 10.0;
				}
			}
			else
			{
				materialName[0] = Consts2.lystNerzavijuchyj05.MaterialName;
				num6 = Consts2.lystNerzavijuchyj05.Price;
				num2 = 5.0;
			}
			break;
		}
		}
		double num13 = B + r + k2 + 10;
		double num14 = num13 * (double)L - (double)(k2 * (k + r)) - (double)(k * r);
		if (L > 2500)
		{
			num14 += 60.0 * num13;
		}
		else if (L > 1250)
		{
			num14 += 30.0 * num13;
		}
		if (num13 > 2500.0)
		{
			num14 += 60.0 * (double)L;
		}
		else if (num13 > 1250.0)
		{
			num14 += 30.0 * (double)L;
		}
		num13 = Math.PI * (double)r / 2.0 + (double)k + (double)k2;
		double num15 = num13 * (double)(H + 50);
		if (H + 50 > 2500)
		{
			num15 += 60.0 * num13;
		}
		else if (H + 50 > 1250)
		{
			num15 += 30.0 * num13;
		}
		num15 = ((!(num13 > 2500.0)) ? (num15 + 30.0 * (double)(H + 50)) : (num15 + 60.0 * (double)(H + 50)));
		num13 = Math.Sqrt(Math.Pow((double)B - (double)B1, 2.0) / 4.0 + Math.Pow((double)L - (double)k - (double)k1, 2.0)) + (double)k + (double)k1;
		double num16 = (double)(H + 50) * num13;
		if (H + 50 > 2500)
		{
			num16 += 60.0 * num13;
		}
		else if (H + 50 > 1250)
		{
			num16 += 30.0 * num13;
		}
		if (num13 > 2500.0)
		{
			num16 += 60.0 * (double)(H + 50);
		}
		else if (num13 > 1250.0)
		{
			num16 += 30.0 * (double)(H + 50);
		}
		double num18;
		double num19;
		if (G == -1)
		{
			double x = 2.0 * (double)(L - k - k1) / (double)(B - B1);
			double num17 = Math.Pow(x, 2.0) * Math.Pow(r, 2.0) - Math.Pow(B2 + r, 2.0);
			num18 = (Math.Pow(x, 2.0) * (double)r - Math.Sqrt(Math.Pow(x, 4.0) * Math.Pow(r, 2.0) - (1.0 + Math.Pow(x, 2.0)) * num17)) / (1.0 + Math.Pow(x, 2.0));
			num5 = 2.0 * (double)(L - k - k1) * (num18 - (double)r) / (double)(B - B1);
			num4 = Math.Asin(num18 / (double)(B2 + r));
			num19 = Math.Sqrt(Math.Pow(0.5 * (double)(B - B1) + (double)r - num18, 2.0) + Math.Pow((double)L - (double)k - (double)k1 - num5, 2.0)) + num4 * (double)(B2 + r) + (double)k1 + (double)k2;
		}
		else
		{
			num18 = 0.5 * (double)G * (double)(B - B1) / (double)(L - k - k1);
			num13 = (Math.PI * (double)(B2 + r - G) * ((double)r + num18) + Math.Pow(num18 + (double)G - (double)B2, 2.0)) / ((double)B2 + num18 + (double)(2 * r) - (double)G);
			num19 = Math.Sqrt(Math.Pow(0.5 * (double)(B - B1) - num18, 2.0) + Math.Pow((double)L - (double)k - (double)k1 - (double)G, 2.0)) + num13 + (double)k1 + (double)k2;
		}
		double num20 = num19 * (double)(H + 50);
		if (num19 > 2500.0)
		{
			num20 += 60.0 * (double)(H + 50);
		}
		else if (num19 > 1250.0)
		{
			num20 += 30.0 * (double)(H + 50);
		}
		if (H + 50 > 2500)
		{
			num20 += 60.0 * num19;
		}
		else if (H + 50 > 1250)
		{
			num20 += 30.0 * num19;
		}
		array[0, 0] = (2.0 * num14 + num15 + num20 + num16) * (1.0 + num2 / 100.0) / 1000000.0;
		num14 = (double)B * (double)k + (double)(B1 * k1) + (double)(B2 * k2) + 0.25 * (double)(B - B1) * (double)(L - k - k1) + (double)(B1 * (L - k - k1)) - Math.PI * (double)r * (double)r / 4.0;
		double num21 = 2.0 * (double)(H + 50 + 10) * (double)(k + k1 + k2) + (double)(H + 50 + 10) * (Math.PI * (double)r / 2.0 + Math.Sqrt(Math.Pow(0.5 * (double)(B - B1), 2.0) + Math.Pow((double)L - (double)k - (double)k1, 2.0)));
		if (G == -1)
		{
			num14 += (0.5 * (double)(B - B1) + (double)r - num18) * ((double)(L - k - k1) - num5) / 2.0 + num4 * Math.Pow(B2 + r, 2.0) / 2.0 + 0.5 * num18 * num5 + num5 * ((double)((B - B1) / 2 + r) - num18);
			num21 += (double)(H + 50 + 10) * (Math.Sqrt(Math.Pow(0.5 * (double)(B - B1) + (double)r - num18, 2.0) + Math.Pow((double)L - (double)k - (double)k1 - num5, 2.0)) + num4 * (double)(B2 + r));
		}
		else
		{
			num14 += (0.5 * (double)(B - B1) - num18) * (double)(L - k - k1 - G) / 2.0 + (0.5 * (double)(B - B1) - num18) * (double)G + Math.PI * (double)(B2 + r - G) * ((double)r + num18) / 4.0 + (double)G * ((double)r + num18);
			num21 += (double)(H + 50 + 10) * (Math.Sqrt(Math.Pow(0.5 * (double)(B - B1) - num18, 2.0) + Math.Pow((double)L - (double)k - (double)k1 - (double)G, 2.0)) + num13);
		}
		num2 = Math.Round((1000000.0 * array[0, 0] / (2.0 * num14 + num21) - 1.0) * 100.0);
		if (num2 > 20.0)
		{
			num2 = 20.0;
			array[0, 0] = (2.0 * num14 + num21) * (1.0 + num2 / 100.0) / 1000000.0;
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
		materialCost = array[0, 0] * num6;
		if (typTRPenter == 1 && typProfilBH == 0)
		{
			num3 = ((B >= H) ? B : H);
			typProfilBH = ((num3 < 800) ? 1 : 2);
		}
		if (typTRPout == 1 && typProfilB1H1 == 0)
		{
			num3 = ((B1 >= H) ? B1 : H);
			typProfilB1H1 = ((num3 < 800) ? 1 : 2);
		}
		if (typTRPvidvid == 1 && typProfilB2H2 == 0)
		{
			num3 = ((B2 >= H) ? B2 : H);
			typProfilB2H2 = ((num3 < 800) ? 1 : 2);
		}
		double[,] array2 = new double[2, 6];
		int num22 = 1;
		if (typProfilBH == 1 || typProfilB1H1 == 1 || typProfilB2H2 == 1)
		{
			if (typProfilBH == 1)
			{
				array2 = FlanetsPrjamokutnyj.MaterialFlanetsPrjamokutnyj(B, H, typProfilBH, number, polkaBH, 1);
				materialCost += FlanetsPrjamokutnyj.materialCost1;
				for (int i = 0; i < 2; i++)
				{
					if (FlanetsPrjamokutnyj.materialName[i] != "")
					{
						materialName[num22 + i] = FlanetsPrjamokutnyj.materialName[i];
						for (int j = 0; j < 6; j++)
						{
							array[num22 + i, j] = ((j == 1) ? array2[i, j] : (array[num22 + i, j] + array2[i, j]));
						}
					}
				}
			}
			if (typProfilB1H1 == 1)
			{
				array2 = FlanetsPrjamokutnyj.MaterialFlanetsPrjamokutnyj(B1, H, typProfilB1H1, number, polkaB1H1, 1);
				materialCost += FlanetsPrjamokutnyj.materialCost1;
				for (int l = 0; l < 2; l++)
				{
					if (FlanetsPrjamokutnyj.materialName[l] != "")
					{
						materialName[num22 + l] = FlanetsPrjamokutnyj.materialName[l];
						for (int m = 0; m < 6; m++)
						{
							array[num22 + l, m] = ((m == 1) ? array2[l, m] : (array[num22 + l, m] + array2[l, m]));
						}
					}
				}
			}
			if (typProfilB2H2 == 1)
			{
				array2 = FlanetsPrjamokutnyj.MaterialFlanetsPrjamokutnyj(B2, H, typProfilB2H2, number, polkaB2H2, 1);
				materialCost += FlanetsPrjamokutnyj.materialCost1;
				for (int n = 0; n < 2; n++)
				{
					if (FlanetsPrjamokutnyj.materialName[n] != "")
					{
						materialName[num22 + n] = FlanetsPrjamokutnyj.materialName[n];
						for (int num23 = 0; num23 < 6; num23++)
						{
							array[num22 + n, num23] = ((num23 == 1) ? array2[n, num23] : (array[num22 + n, num23] + array2[n, num23]));
						}
					}
				}
			}
			num22 += 2;
		}
		if (typProfilBH == 2 || typProfilB1H1 == 2 || typProfilB2H2 == 2)
		{
			if (typProfilBH == 2)
			{
				array2 = FlanetsPrjamokutnyj.MaterialFlanetsPrjamokutnyj(B, H, typProfilBH, number, polkaBH, 1);
				materialCost += FlanetsPrjamokutnyj.materialCost1;
				for (int num24 = 0; num24 < 2; num24++)
				{
					if (FlanetsPrjamokutnyj.materialName[num24] != "")
					{
						materialName[num22 + num24] = FlanetsPrjamokutnyj.materialName[num24];
						for (int num25 = 0; num25 < 6; num25++)
						{
							array[num22 + num24, num25] = ((num25 == 1) ? array2[num24, num25] : (array[num22 + num24, num25] + array2[num24, num25]));
						}
					}
				}
			}
			if (typProfilB1H1 == 2)
			{
				array2 = FlanetsPrjamokutnyj.MaterialFlanetsPrjamokutnyj(B1, H, typProfilB1H1, number, polkaB1H1, 1);
				materialCost += FlanetsPrjamokutnyj.materialCost1;
				for (int num26 = 0; num26 < 2; num26++)
				{
					if (FlanetsPrjamokutnyj.materialName[num26] != "")
					{
						materialName[num22 + num26] = FlanetsPrjamokutnyj.materialName[num26];
						for (int num27 = 0; num27 < 6; num27++)
						{
							array[num22 + num26, num27] = ((num27 == 1) ? array2[num26, num27] : (array[num22 + num26, num27] + array2[num26, num27]));
						}
					}
				}
			}
			if (typProfilB2H2 == 2)
			{
				array2 = FlanetsPrjamokutnyj.MaterialFlanetsPrjamokutnyj(B2, H, typProfilB2H2, number, polkaB2H2, 1);
				materialCost += FlanetsPrjamokutnyj.materialCost1;
				for (int num28 = 0; num28 < 2; num28++)
				{
					if (FlanetsPrjamokutnyj.materialName[num28] != "")
					{
						materialName[num22 + num28] = FlanetsPrjamokutnyj.materialName[num28];
						for (int num29 = 0; num29 < 6; num29++)
						{
							array[num22 + num28, num29] = ((num29 == 1) ? array2[num28, num29] : (array[num22 + num28, num29] + array2[num28, num29]));
						}
					}
				}
			}
			num22 += 2;
		}
		if (typProfilBH == 1 || typProfilBH == 2)
		{
			double[,] array3 = new double[1, 6];
			array3 = HvyntNaFlanets.MaterialHvyntNaFlanets(B, H, 1, number);
			materialCost += HvyntNaFlanets.materialCost1;
			materialName[num22] = HvyntNaFlanets.materialName1[0];
			for (int num30 = 0; num30 < 6; num30++)
			{
				array[num22, num30] = array3[0, num30];
			}
		}
		if (typProfilB1H1 == 1 || typProfilB1H1 == 2)
		{
			double[,] array4 = new double[1, 6];
			array4 = HvyntNaFlanets.MaterialHvyntNaFlanets(B1, H, 1, number);
			materialCost += HvyntNaFlanets.materialCost1;
			materialName[num22] = HvyntNaFlanets.materialName1[0];
			for (int num31 = 0; num31 < 6; num31++)
			{
				array[num22, num31] += array4[0, num31];
			}
		}
		if (typProfilB2H2 == 1 || typProfilB2H2 == 2)
		{
			double[,] array5 = new double[1, 6];
			array5 = HvyntNaFlanets.MaterialHvyntNaFlanets(B2, H, 1, number);
			materialCost += HvyntNaFlanets.materialCost1;
			materialName[num22] = HvyntNaFlanets.materialName1[0];
			for (int num32 = 0; num32 < 6; num32++)
			{
				array[num22, num32] += array5[0, num32];
			}
		}
		if (typProfilBH == 1 || typProfilB1H1 == 1 || typProfilB2H2 == 1 || typProfilBH == 2 || typProfilB1H1 == 2 || typProfilB2H2 == 2)
		{
			num22++;
		}
		if (typProfilBH == 3 || typProfilB1H1 == 3 || typProfilB2H2 == 3)
		{
			if (typProfilBH == 3)
			{
				array2 = FlanetsPrjamokutnyj.MaterialFlanetsPrjamokutnyj(B, H, typProfilBH, number, polkaBH, 1);
				materialCost += FlanetsPrjamokutnyj.materialCost1;
				if (FlanetsPrjamokutnyj.materialName[0] != "")
				{
					materialName[num22] = FlanetsPrjamokutnyj.materialName[0];
					for (int num33 = 0; num33 < 6; num33++)
					{
						array[num22, num33] = ((num33 == 1) ? array2[0, num33] : (array[num22, num33] + array2[0, num33]));
					}
				}
			}
			if (typProfilB1H1 == 3)
			{
				array2 = FlanetsPrjamokutnyj.MaterialFlanetsPrjamokutnyj(B1, H, typProfilB1H1, number, polkaB1H1, 1);
				materialCost += FlanetsPrjamokutnyj.materialCost1;
				if (FlanetsPrjamokutnyj.materialName[0] != "")
				{
					materialName[num22] = FlanetsPrjamokutnyj.materialName[0];
					for (int num34 = 0; num34 < 6; num34++)
					{
						array[num22, num34] = ((num34 == 1) ? array2[0, num34] : (array[num22, num34] + array2[0, num34]));
					}
				}
			}
			if (typProfilB2H2 == 3)
			{
				array2 = FlanetsPrjamokutnyj.MaterialFlanetsPrjamokutnyj(B2, H, typProfilB2H2, number, polkaB2H2, 1);
				materialCost += FlanetsPrjamokutnyj.materialCost1;
				if (FlanetsPrjamokutnyj.materialName[0] != "")
				{
					materialName[num22] = FlanetsPrjamokutnyj.materialName[0];
					for (int num35 = 0; num35 < 6; num35++)
					{
						array[num22, num35] = ((num35 == 1) ? array2[0, num35] : (array[num22, num35] + array2[0, num35]));
					}
				}
			}
			num22++;
		}
		if (typProfilBH == 4 || typProfilB1H1 == 4 || typProfilB2H2 == 4)
		{
			if (typProfilBH == 4)
			{
				array2 = FlanetsPrjamokutnyj.MaterialFlanetsPrjamokutnyj(B, H, typProfilBH, number, polkaBH, 1);
				materialCost += FlanetsPrjamokutnyj.materialCost1;
				if (FlanetsPrjamokutnyj.materialName[0] != "")
				{
					materialName[num22] = FlanetsPrjamokutnyj.materialName[0];
					for (int num36 = 0; num36 < 6; num36++)
					{
						array[num22, num36] = ((num36 == 1) ? array2[0, num36] : (array[num22, num36] + array2[0, num36]));
					}
				}
			}
			if (typProfilB1H1 == 4)
			{
				array2 = FlanetsPrjamokutnyj.MaterialFlanetsPrjamokutnyj(B1, H, typProfilB1H1, number, polkaB1H1, 1);
				materialCost += FlanetsPrjamokutnyj.materialCost1;
				if (FlanetsPrjamokutnyj.materialName[0] != "")
				{
					materialName[num22] = FlanetsPrjamokutnyj.materialName[0];
					for (int num37 = 0; num37 < 6; num37++)
					{
						array[num22, num37] = ((num37 == 1) ? array2[0, num37] : (array[num22, num37] + array2[0, num37]));
					}
				}
			}
			if (typProfilB2H2 == 4)
			{
				array2 = FlanetsPrjamokutnyj.MaterialFlanetsPrjamokutnyj(B2, H, typProfilB2H2, number, polkaB2H2, 1);
				materialCost += FlanetsPrjamokutnyj.materialCost1;
				if (FlanetsPrjamokutnyj.materialName[0] != "")
				{
					materialName[num22] = FlanetsPrjamokutnyj.materialName[0];
					for (int num38 = 0; num38 < 6; num38++)
					{
						array[num22, num38] = ((num38 == 1) ? array2[0, num38] : (array[num22, num38] + array2[0, num38]));
					}
				}
			}
		}
		return array;
	}

	public static double PriceTrijnykTRP(int B, int H, int B1, int B2, int G, int k, int k1, int k2, int L, int r, int markaStali, double tovchynaMetalu, int typTRPenter, int typTRPout, int typTRPvidvid)
	{
		double num = 1.0;
		int num2 = ((B >= H) ? B : H);
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
			num = ((typTRPenter != 1 && typTRPout != 1 && typTRPvidvid != 1) ? ((!(tovchynaMetalu < 0.65)) ? ((tovchynaMetalu < 0.9) ? 406.0 : 520.0) : 345.0) : ((!(tovchynaMetalu < 0.65)) ? ((tovchynaMetalu < 0.9) ? 464.0 : 600.0) : 402.5));
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
		double num7 = (double)B * (double)k + (double)(B1 * k1) + (double)(B2 * k2) + 0.25 * (double)(B - B1) * (double)(L - k - k1) + (double)(B1 * (L - k - k1)) - Math.PI * (double)r * (double)r / 4.0;
		double num8 = 2.0 * (double)H * (double)(k + k1 + k2) + (double)H * (Math.PI * (double)r / 2.0 + Math.Sqrt(Math.Pow(0.5 * (double)(B - B1), 2.0) + Math.Pow((double)L - (double)k - (double)k1, 2.0)));
		if (G == -1)
		{
			double x = 2.0 * (double)(L - k - k1) / (double)(B - B1);
			double num9 = Math.Pow(x, 2.0) * Math.Pow(r, 2.0) - Math.Pow(B2 + r, 2.0);
			double num10 = (Math.Pow(x, 2.0) * (double)r - Math.Sqrt(Math.Pow(x, 4.0) * Math.Pow(r, 2.0) - (1.0 + Math.Pow(x, 2.0)) * num9)) / (1.0 + Math.Pow(x, 2.0));
			double num11 = 2.0 * (double)(L - k - k1) * (num10 - (double)r) / (double)(B - B1);
			double num12 = Math.Asin(num10 / (double)(B2 + r));
			num7 += (0.5 * (double)(B - B1) + (double)r - num10) * ((double)(L - k - k1) - num11) / 2.0 + num12 * Math.Pow(B2 + r, 2.0) / 2.0 + 0.5 * num10 * num11 + num11 * ((double)((B - B1) / 2 + r) - num10);
			num8 += (double)H * (Math.Sqrt(Math.Pow(0.5 * (double)(B - B1) + (double)r - num10, 2.0) + Math.Pow((double)(L - k - k1) - num11, 2.0)) + num12 * (double)(B2 + r));
		}
		else
		{
			double num10 = 0.5 * (double)G * (double)(B - B1) / (double)(L - k - k1);
			double num13 = (Math.PI * (double)(B2 + r - G) * ((double)r + num10) + Math.Pow(num10 + (double)G - (double)B2, 2.0)) / ((double)B2 + num10 + (double)(2 * r) - (double)G);
			num7 += (0.5 * (double)(B - B1) - num10) * (double)(L - k - k1 - G) / 2.0 + (0.5 * (double)(B - B1) - num10) * (double)G + Math.PI * (double)(B2 + r - G) * ((double)r + num10) / 4.0 + (double)G * ((double)r + num10);
			num8 += (double)H * (Math.Sqrt(Math.Pow(0.5 * (double)(B - B1) - num10, 2.0) + Math.Pow((double)L - (double)k - (double)k1 - (double)G, 2.0)) + num13);
		}
		materialSpendingCommercialOffer = (2.0 * num7 + num8) / 1000000.0;
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

	public static double VolumeTrijnykTRP(int B, int H, int r, int k2, int L)
	{
		return Math.Round((double)L * (double)H * (double)(B + r + k2) / 1000000.0) / 1000.0;
	}
}
