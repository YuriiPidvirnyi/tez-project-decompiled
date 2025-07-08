using System;
using TEZ_Project.Common.Data;
using TEZ_Project.Common.Helpers;

namespace TEZ_Project.Common.Products;

public static class HrestovynaHAP
{
	public static string[] materialName = new string[11]
	{
		"", "", "", "", "", "", "", "", "", "",
		""
	};

	public static double materialCost;

	public static double materialSpendingCommercialOffer = 0.0;

	public static double tovchynaMetaluCommercialOffer = 0.0;

	public static double[,] MaterialHrestovynaHAP(int B, int B1, int B2, int B3, int H, int L, int r, int r1, int k, int k1, int k2, int k3, int markaStali, double tovchynaMetalu, int typHAPinput, int typHAPout, int typHAPleft, int typHAPright, int typProfilBH, int typProfilB1H1, int typProfilB2H2, int typProfilB3H3, int number, int polkaBH, int polkaB1H1, int polkaB2H2, int polkaB3H3, int vidbortovka, string aisiType = "430")
	{
		double[,] array = new double[11, 6];
		double num = 0.0;
		double num2 = 0.0;
		int num3 = ((B >= H) ? B : H);
		double num4 = 2.0 * (double)(B + H);
		double num5 = 2.0 * (double)(B1 + H);
		double num6 = 2.0 * (double)(B2 + H);
		double num7 = 2.0 * (double)(B3 + H);
		double num8 = 0.0;
		L += vidbortovka;
		materialName = new string[11]
		{
			"", "", "", "", "", "", "", "", "", "",
			""
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
		if (B3 >= num3)
		{
			num3 = B3;
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
										num8 = Consts2.lystOchynkovanyj12.Price;
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
									num8 = Consts2.lystOchynkovanyj10.Price;
									num2 = 10.0;
								}
							}
							else
							{
								materialName[0] = Consts2.lystOchynkovanyj09.MaterialName;
								num8 = Consts2.lystOchynkovanyj09.Price;
								num2 = 10.0;
							}
						}
						else
						{
							materialName[0] = Consts2.lystOchynkovanyj07.MaterialName;
							num8 = Consts2.lystOchynkovanyj07.Price;
							num2 = 10.0;
						}
					}
					else
					{
						materialName[0] = Consts2.lystOchynkovanyj068.MaterialName;
						num8 = Consts2.lystOchynkovanyj068.Price;
						num2 = 10.0;
					}
				}
				else
				{
					materialName[0] = Consts2.lystOchynkovanyj065.MaterialName;
					num8 = Consts2.lystOchynkovanyj065.Price;
					num2 = 10.0;
				}
			}
			else
			{
				materialName[0] = Consts2.lystOchynkovanyj05.MaterialName;
				num8 = Consts2.lystOchynkovanyj05.Price;
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
														num8 = Consts2.lystStalnyj60.Price;
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
													num8 = Consts2.lystStalnyj50.Price;
													num2 = 10.0;
												}
											}
											else
											{
												materialName[0] = Consts2.lystStalnyj40.MaterialName;
												num8 = Consts2.lystStalnyj40.Price;
												num2 = 10.0;
											}
										}
										else
										{
											materialName[0] = Consts2.lystStalnyj30.MaterialName;
											num8 = Consts2.lystStalnyj30.Price;
											num2 = 10.0;
										}
									}
									else
									{
										materialName[0] = Consts2.lystStalnyj25.MaterialName;
										num8 = Consts2.lystStalnyj25.Price;
										num2 = 10.0;
									}
								}
								else
								{
									materialName[0] = Consts2.lystStalnyj20.MaterialName;
									num8 = Consts2.lystStalnyj20.Price;
									num2 = 10.0;
								}
							}
							else
							{
								materialName[0] = Consts2.lystStalnyj15.MaterialName;
								num8 = Consts2.lystStalnyj15.Price;
								num2 = 10.0;
							}
						}
						else
						{
							materialName[0] = Consts2.lystStalnyj12.MaterialName;
							num8 = Consts2.lystStalnyj12.Price;
							num2 = 10.0;
						}
					}
					else
					{
						materialName[0] = Consts2.lystStalnyj10.MaterialName;
						num8 = Consts2.lystStalnyj10.Price;
						num2 = 10.0;
					}
				}
				else
				{
					materialName[0] = Consts2.lystStalnyj08.MaterialName;
					num8 = Consts2.lystStalnyj08.Price;
					num2 = 10.0;
				}
			}
			else
			{
				materialName[0] = Consts2.lystStalnyj05.MaterialName;
				num8 = Consts2.lystStalnyj05.Price;
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
			num8 = lystNerzavijuchyj.Price;
			break;
		}
		}
		double num13 = B + 10 + k2 + r + k3 + r1;
		double num14 = (double)L * num13;
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
		double num15 = (Math.PI * (double)r / 2.0 + (double)k + (double)k2) * (double)(H + 50);
		double num16 = (Math.PI * (double)r1 / 2.0 + (double)k1 + (double)k3) * (double)(H + 50);
		double num17 = (double)(k2 + r) + (double)B / 2.0;
		double num18 = num17 - (double)B1 / 2.0 - (double)k2 - (double)r;
		double num19 = Math.Sqrt(Math.Pow(B2 + r, 2.0) - Math.Pow(num17 - (double)B1 / 2.0 - (double)k2, 2.0));
		double num20 = (double)(k2 + r + B) - num17 - (double)B1 / 2.0;
		double num21 = Math.Sqrt(Math.Pow(B3 + r1, 2.0) - Math.Pow(num20 + (double)r1, 2.0));
		double num22 = Math.Acos(num19 / (double)(B2 + r));
		double num23 = Math.Acos(num21 / (double)(B3 + r1));
		num13 = (double)k3 + num23 * (double)(B3 + r1) + (double)L - (double)k1 - num21;
		double num24 = num13 * (double)(H + 50);
		if (H + 50 > 1250)
		{
			num24 += 30.0 * num13;
		}
		if (num13 > 2500.0)
		{
			num24 += 60.0 * (double)(H + 50);
		}
		else if (num13 > 1250.0)
		{
			num24 += 30.0 * (double)(H + 50);
		}
		num13 = (double)k2 + num22 * (double)(B2 + r) + (double)L - (double)k - num19;
		double num25 = num13 * (double)(H + 50);
		if (H + 50 > 1250)
		{
			num25 += 30.0 * num13;
		}
		if (num13 > 2500.0)
		{
			num25 += 60.0 * (double)(H + 50);
		}
		else if (num13 > 1250.0)
		{
			num25 += 30.0 * (double)(H + 50);
		}
		array[0, 0] = (2.0 * num14 + num15 + num16 + num24 + num25) * (1.0 + num2 / 100.0) / 1000000.0;
		num14 = (double)(B1 * L + B2 * k2) + num22 * (double)(B2 + r) * (double)(B2 + r) / 2.0 + 0.5 * ((double)r + num18) * num19 - Math.PI * (double)r * (double)r / 4.0 + num18 * (double)k;
		num14 += (double)(B3 * k3) + num23 * (double)(B3 + r1) * (double)(B3 + r1) / 2.0 + 0.5 * ((double)r1 + num20) * num21 - Math.PI * (double)r1 * (double)r1 / 4.0 + num20 * (double)k1;
		num14 *= 2.0;
		num14 += (double)(H + 50 + 10) * ((double)(2 * (k2 + k3 + L)) + Math.PI * (double)(r + r1) / 2.0 + num23 * (double)(B3 + r1) + num22 * (double)(B2 + r) - num19 - num21);
		num14 /= 1000000.0;
		num2 = Math.Round((array[0, 0] / num14 - 1.0) * 100.0);
		if (num2 > 20.0)
		{
			num2 = 20.0;
			array[0, 0] = num14 * (1.0 + num2 / 100.0);
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
		materialCost = array[0, 0] * num8;
		if (typHAPinput == 1 && typProfilBH == 0)
		{
			num3 = ((B >= H) ? B : H);
			typProfilBH = ((num3 < 800) ? 1 : 2);
		}
		if (typHAPout == 1 && typProfilB1H1 == 0)
		{
			num3 = ((B1 >= H) ? B1 : H);
			typProfilB1H1 = ((num3 < 800) ? 1 : 2);
		}
		if (typHAPleft == 1 && typProfilB2H2 == 0)
		{
			num3 = ((B2 >= H) ? B2 : H);
			typProfilB2H2 = ((num3 < 800) ? 1 : 2);
		}
		if (typHAPright == 1 && typProfilB3H3 == 0)
		{
			num3 = ((B3 >= H) ? B3 : H);
			typProfilB3H3 = ((num3 < 800) ? 1 : 2);
		}
		double[,] array2 = new double[2, 6];
		int num26 = 1;
		if (typProfilBH == 1 || typProfilB1H1 == 1 || typProfilB2H2 == 1 || typProfilB3H3 == 1)
		{
			if (typProfilBH == 1)
			{
				array2 = FlanetsPrjamokutnyj.MaterialFlanetsPrjamokutnyj(B, H, typProfilBH, number, polkaBH, 1);
				for (int i = 0; i < 2; i++)
				{
					if (FlanetsPrjamokutnyj.materialName[i] != "")
					{
						materialName[num26 + i] = FlanetsPrjamokutnyj.materialName[i];
						for (int j = 0; j < 6; j++)
						{
							array[num26 + i, j] = ((j == 1) ? array2[i, j] : (array[num26 + i, j] + array2[i, j]));
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
						materialName[num26 + l] = FlanetsPrjamokutnyj.materialName[l];
						for (int m = 0; m < 6; m++)
						{
							array[num26 + l, m] = ((m == 1) ? array2[l, m] : (array[num26 + l, m] + array2[l, m]));
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
						materialName[num26 + n] = FlanetsPrjamokutnyj.materialName[n];
						for (int num27 = 0; num27 < 6; num27++)
						{
							array[num26 + n, num27] = ((num27 == 1) ? array2[n, num27] : (array[num26 + n, num27] + array2[n, num27]));
						}
					}
				}
				materialCost += FlanetsPrjamokutnyj.materialCost1;
			}
			if (typProfilB3H3 == 1)
			{
				array2 = FlanetsPrjamokutnyj.MaterialFlanetsPrjamokutnyj(B3, H, typProfilB3H3, number, polkaB3H3, 1);
				for (int num28 = 0; num28 < 2; num28++)
				{
					if (FlanetsPrjamokutnyj.materialName[num28] != "")
					{
						materialName[num26 + num28] = FlanetsPrjamokutnyj.materialName[num28];
						for (int num29 = 0; num29 < 6; num29++)
						{
							array[num26 + num28, num29] = ((num29 == 1) ? array2[num28, num29] : (array[num26 + num28, num29] + array2[num28, num29]));
						}
					}
				}
				materialCost += FlanetsPrjamokutnyj.materialCost1;
			}
			num26 += 2;
		}
		if (typProfilBH == 2 || typProfilB1H1 == 2 || typProfilB2H2 == 2 || typProfilB3H3 == 2)
		{
			if (typProfilBH == 2)
			{
				array2 = FlanetsPrjamokutnyj.MaterialFlanetsPrjamokutnyj(B, H, typProfilBH, number, polkaBH, 1);
				for (int num30 = 0; num30 < 2; num30++)
				{
					if (FlanetsPrjamokutnyj.materialName[num30] != "")
					{
						materialName[num26 + num30] = FlanetsPrjamokutnyj.materialName[num30];
						for (int num31 = 0; num31 < 6; num31++)
						{
							array[num26 + num30, num31] = ((num31 == 1) ? array2[num30, num31] : (array[num26 + num30, num31] + array2[num30, num31]));
						}
					}
				}
				materialCost += FlanetsPrjamokutnyj.materialCost1;
			}
			if (typProfilB1H1 == 2)
			{
				array2 = FlanetsPrjamokutnyj.MaterialFlanetsPrjamokutnyj(B1, H, typProfilB1H1, number, polkaB1H1, 1);
				for (int num32 = 0; num32 < 2; num32++)
				{
					if (FlanetsPrjamokutnyj.materialName[num32] != "")
					{
						materialName[num26 + num32] = FlanetsPrjamokutnyj.materialName[num32];
						for (int num33 = 0; num33 < 6; num33++)
						{
							array[num26 + num32, num33] = ((num33 == 1) ? array2[num32, num33] : (array[num26 + num32, num33] + array2[num32, num33]));
						}
					}
				}
				materialCost += FlanetsPrjamokutnyj.materialCost1;
			}
			if (typProfilB2H2 == 2)
			{
				array2 = FlanetsPrjamokutnyj.MaterialFlanetsPrjamokutnyj(B2, H, typProfilB2H2, number, polkaB2H2, 1);
				for (int num34 = 0; num34 < 2; num34++)
				{
					if (FlanetsPrjamokutnyj.materialName[num34] != "")
					{
						materialName[num26 + num34] = FlanetsPrjamokutnyj.materialName[num34];
						for (int num35 = 0; num35 < 6; num35++)
						{
							array[num26 + num34, num35] = ((num35 == 1) ? array2[num34, num35] : (array[num26 + num34, num35] + array2[num34, num35]));
						}
					}
				}
				materialCost += FlanetsPrjamokutnyj.materialCost1;
			}
			if (typProfilB3H3 == 2)
			{
				array2 = FlanetsPrjamokutnyj.MaterialFlanetsPrjamokutnyj(B3, H, typProfilB3H3, number, polkaB3H3, 1);
				for (int num36 = 0; num36 < 2; num36++)
				{
					if (FlanetsPrjamokutnyj.materialName[num36] != "")
					{
						materialName[num26 + num36] = FlanetsPrjamokutnyj.materialName[num36];
						for (int num37 = 0; num37 < 6; num37++)
						{
							array[num26 + num36, num37] = ((num37 == 1) ? array2[num36, num37] : (array[num26 + num36, num37] + array2[num36, num37]));
						}
					}
				}
				materialCost += FlanetsPrjamokutnyj.materialCost1;
			}
			num26 += 2;
		}
		if (typProfilBH == 1 || typProfilBH == 2)
		{
			double[,] array3 = new double[1, 6];
			array3 = HvyntNaFlanets.MaterialHvyntNaFlanets(B, H, 1, number);
			materialName[num26] = HvyntNaFlanets.materialName1[0];
			for (int num38 = 0; num38 < 6; num38++)
			{
				array[num26, num38] = array3[0, num38];
			}
			materialCost += HvyntNaFlanets.materialCost1;
		}
		if (typProfilB1H1 == 1 || typProfilB1H1 == 2)
		{
			double[,] array4 = new double[1, 6];
			array4 = HvyntNaFlanets.MaterialHvyntNaFlanets(B1, H, 1, number);
			materialName[num26] = HvyntNaFlanets.materialName1[0];
			for (int num39 = 0; num39 < 6; num39++)
			{
				array[num26, num39] += array4[0, num39];
			}
			materialCost += HvyntNaFlanets.materialCost1;
		}
		if (typProfilB2H2 == 1 || typProfilB2H2 == 2)
		{
			double[,] array5 = new double[1, 6];
			array5 = HvyntNaFlanets.MaterialHvyntNaFlanets(B2, H, 1, number);
			materialName[num26] = HvyntNaFlanets.materialName1[0];
			for (int num40 = 0; num40 < 6; num40++)
			{
				array[num26, num40] += array5[0, num40];
			}
			materialCost += HvyntNaFlanets.materialCost1;
		}
		if (typProfilB3H3 == 1 || typProfilB3H3 == 2)
		{
			double[,] array6 = new double[1, 6];
			array6 = HvyntNaFlanets.MaterialHvyntNaFlanets(B3, H, 1, number);
			materialName[num26] = HvyntNaFlanets.materialName1[0];
			for (int num41 = 0; num41 < 6; num41++)
			{
				array[num26, num41] += array6[0, num41];
			}
			materialCost += HvyntNaFlanets.materialCost1;
		}
		if (typProfilBH == 1 || typProfilB1H1 == 1 || typProfilB2H2 == 1 || typProfilB3H3 == 1 || typProfilBH == 2 || typProfilB1H1 == 2 || typProfilB2H2 == 2 || typProfilB3H3 == 2)
		{
			num26++;
		}
		if (typProfilBH == 3 || typProfilB1H1 == 3 || typProfilB2H2 == 3 || typProfilB3H3 == 3)
		{
			if (typProfilBH == 3)
			{
				array2 = FlanetsPrjamokutnyj.MaterialFlanetsPrjamokutnyj(B, H, typProfilBH, number, polkaBH, 1);
				if (FlanetsPrjamokutnyj.materialName[0] != "")
				{
					materialName[num26] = FlanetsPrjamokutnyj.materialName[0];
					for (int num42 = 0; num42 < 6; num42++)
					{
						array[num26, num42] = ((num42 == 1) ? array2[0, num42] : (array[num26, num42] + array2[0, num42]));
					}
				}
				materialCost += FlanetsPrjamokutnyj.materialCost1;
			}
			if (typProfilB1H1 == 3)
			{
				array2 = FlanetsPrjamokutnyj.MaterialFlanetsPrjamokutnyj(B1, H, typProfilB1H1, number, polkaB1H1, 1);
				if (FlanetsPrjamokutnyj.materialName[0] != "")
				{
					materialName[num26] = FlanetsPrjamokutnyj.materialName[0];
					for (int num43 = 0; num43 < 6; num43++)
					{
						array[num26, num43] = ((num43 == 1) ? array2[0, num43] : (array[num26, num43] + array2[0, num43]));
					}
				}
				materialCost += FlanetsPrjamokutnyj.materialCost1;
			}
			if (typProfilB2H2 == 3)
			{
				array2 = FlanetsPrjamokutnyj.MaterialFlanetsPrjamokutnyj(B2, H, typProfilB2H2, number, polkaB2H2, 1);
				if (FlanetsPrjamokutnyj.materialName[0] != "")
				{
					materialName[num26] = FlanetsPrjamokutnyj.materialName[0];
					for (int num44 = 0; num44 < 6; num44++)
					{
						array[num26, num44] = ((num44 == 1) ? array2[0, num44] : (array[num26, num44] + array2[0, num44]));
					}
				}
				materialCost += FlanetsPrjamokutnyj.materialCost1;
			}
			if (typProfilB3H3 == 2)
			{
				array2 = FlanetsPrjamokutnyj.MaterialFlanetsPrjamokutnyj(B3, H, typProfilB3H3, number, polkaB3H3, 1);
				if (FlanetsPrjamokutnyj.materialName[0] != "")
				{
					materialName[num26] = FlanetsPrjamokutnyj.materialName[0];
					for (int num45 = 0; num45 < 6; num45++)
					{
						array[num26, num45] = ((num45 == 1) ? array2[0, num45] : (array[num26, num45] + array2[0, num45]));
					}
				}
				materialCost += FlanetsPrjamokutnyj.materialCost1;
			}
			num26++;
		}
		if (typProfilBH == 4 || typProfilB1H1 == 4 || typProfilB2H2 == 4 || typProfilB3H3 == 4)
		{
			if (typProfilBH == 4)
			{
				array2 = FlanetsPrjamokutnyj.MaterialFlanetsPrjamokutnyj(B, H, typProfilBH, number, polkaBH, 1);
				if (FlanetsPrjamokutnyj.materialName[0] != "")
				{
					materialName[num26] = FlanetsPrjamokutnyj.materialName[0];
					for (int num46 = 0; num46 < 6; num46++)
					{
						array[num26, num46] = ((num46 == 1) ? array2[0, num46] : (array[num26, num46] + array2[0, num46]));
					}
				}
				materialCost += FlanetsPrjamokutnyj.materialCost1;
			}
			if (typProfilB1H1 == 4)
			{
				array2 = FlanetsPrjamokutnyj.MaterialFlanetsPrjamokutnyj(B1, H, typProfilB1H1, number, polkaB1H1, 1);
				if (FlanetsPrjamokutnyj.materialName[0] != "")
				{
					materialName[num26] = FlanetsPrjamokutnyj.materialName[0];
					for (int num47 = 0; num47 < 6; num47++)
					{
						array[num26, num47] = ((num47 == 1) ? array2[0, num47] : (array[num26, num47] + array2[0, num47]));
					}
				}
				materialCost += FlanetsPrjamokutnyj.materialCost1;
			}
			if (typProfilB2H2 == 4)
			{
				array2 = FlanetsPrjamokutnyj.MaterialFlanetsPrjamokutnyj(B2, H, typProfilB2H2, number, polkaB2H2, 1);
				if (FlanetsPrjamokutnyj.materialName[0] != "")
				{
					materialName[num26] = FlanetsPrjamokutnyj.materialName[0];
					for (int num48 = 0; num48 < 6; num48++)
					{
						array[num26, num48] = ((num48 == 1) ? array2[0, num48] : (array[num26, num48] + array2[0, num48]));
					}
				}
				materialCost += FlanetsPrjamokutnyj.materialCost1;
			}
			if (typProfilB3H3 == 4)
			{
				array2 = FlanetsPrjamokutnyj.MaterialFlanetsPrjamokutnyj(B3, H, typProfilB3H3, number, polkaB3H3, 1);
				if (FlanetsPrjamokutnyj.materialName[0] != "")
				{
					materialName[num26] = FlanetsPrjamokutnyj.materialName[0];
					for (int num49 = 0; num49 < 6; num49++)
					{
						array[num26, num49] = ((num49 == 1) ? array2[0, num49] : (array[num26, num49] + array2[0, num49]));
					}
				}
				materialCost += FlanetsPrjamokutnyj.materialCost1;
			}
		}
		return array;
	}

	public static double PriceHrestovynaHAP(int B, int B1, int B2, int B3, int H, int L, int r, int r1, int k, int k1, int k2, int k3, int markaStali, double tovchynaMetalu, int typHAPinput, int typHAPout, int typHAPleft, int typHAPright, int vidbortovka)
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
		if (B3 >= num2)
		{
			num2 = B3;
		}
		switch (markaStali)
		{
		case 1:
			if (tovchynaMetalu == 0.0)
			{
				tovchynaMetalu = ((num2 > 400) ? ((num2 <= 800) ? 0.7 : 0.9) : 0.5);
			}
			num = ((typHAPinput != 1 && typHAPout != 1 && typHAPleft != 1 && typHAPright != 1) ? ((!(tovchynaMetalu < 0.65)) ? ((tovchynaMetalu < 0.9) ? 406.0 : 520.0) : 345.0) : ((!(tovchynaMetalu < 0.65)) ? ((tovchynaMetalu < 0.9) ? 464.0 : 600.0) : 402.5));
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
		double num7 = (double)(k2 + r) + (double)B / 2.0;
		double num8 = num7 - (double)B1 / 2.0 - (double)k2 - (double)r;
		double num9 = Math.Sqrt(Math.Pow(B2 + r, 2.0) - Math.Pow(num7 - (double)B1 / 2.0 - (double)k2, 2.0));
		double num10 = (double)(k2 + r + B) - num7 - (double)B1 / 2.0;
		double num11 = Math.Sqrt(Math.Pow(B3 + r1, 2.0) - Math.Pow(num10 + (double)r1, 2.0));
		double num12 = Math.Acos(num9 / (double)(B2 + r));
		double num13 = Math.Acos(num11 / (double)(B3 + r1));
		materialSpendingCommercialOffer = (double)(B1 * L + B2 * k2) + num12 * (double)(B2 + r) * (double)(B2 + r) / 2.0 + 0.5 * ((double)r + num8) * num9 - Math.PI * (double)r * (double)r / 4.0 + num8 * (double)k;
		materialSpendingCommercialOffer += (double)(B3 * k3) + num13 * (double)(B3 + r1) * (double)(B3 + r1) / 2.0 + 0.5 * ((double)r1 + num10) * num11 - Math.PI * (double)r1 * (double)r1 / 4.0 + num10 * (double)k1;
		materialSpendingCommercialOffer *= 2.0;
		materialSpendingCommercialOffer += (double)H * ((double)(2 * (k2 + k3 + L)) + Math.PI * (double)(r + r1) / 2.0 + num13 * (double)(B3 + r1) + num12 * (double)(B2 + r) - num9 - num11);
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

	public static double VolumeHrestovynaHAP(int B, int H, int L, int r, int r1, int k2, int k3)
	{
		return Math.Round((double)H * (double)L * (double)(B + k2 + r + r1 + k3) / 1000000.0) / 1000.0;
	}
}
