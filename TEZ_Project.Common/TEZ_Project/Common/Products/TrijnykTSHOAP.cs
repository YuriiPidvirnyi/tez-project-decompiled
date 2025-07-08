using System;
using TEZ_Project.Common.Helpers;

namespace TEZ_Project.Common.Products;

public static class TrijnykTSHOAP
{
	public static string[] materialName = new string[11]
	{
		"", "", "", "", "", "", "", "", "", "",
		""
	};

	public static double materialCost;

	public static double materialSpendingCommercialOffer = 0.0;

	public static double tovchynaMetaluCommercialOffer = 0.0;

	public static double[,] MaterialTrijnykTSHOAP(int B, int H, int B1, int H1, int B2, int H2, int k1, int k2, int k3, int k4, int L, int r1, int r2, int markaStali, double tovchynaMetalu, int typTSHOAPenter, int typTSHOAPleft, int typTSHOAPright, int typProfilBH, int typProfilB1H1, int typProfilB2H2, int number, int polkaBH, int polkaB1H1, int polkaB2H2, string aisiType = "430")
	{
		double[,] array = new double[11, 6];
		double num = 0.0;
		double num2 = 0.0;
		int num3 = ((B >= H) ? B : H);
		double num4 = 0.0;
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
		if (H1 >= num3)
		{
			num3 = H1;
		}
		if (B2 >= num3)
		{
			num3 = B2;
		}
		if (H2 >= num3)
		{
			num3 = H2;
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
			num2 = MaterialHelper.GetMaterialWithdrawalNerzavijka(tovchynaMetalu);
			CustomConst lystNerzavijuchyj = MaterialHelper.GetLystNerzavijuchyj(tovchynaMetalu, aisiType);
			materialName[0] = lystNerzavijuchyj?.MaterialName ?? "Лист НЕРЖ ??, м2";
			num4 = lystNerzavijuchyj.Price;
			break;
		}
		}
		double num9 = ((double)B / 2.0 + (double)r1 + (double)k3 + 5.0) * (double)(B1 + r1 + k1 + 10) + ((double)B / 2.0 + (double)r2 + (double)k4 + 5.0) * (double)(B2 + r2 + k2 + 10);
		double num10 = ((B1 + r1 + k1 > B2 + r2 + k2) ? (B1 + r1 + k1) : (B2 + r2 + k2));
		if (num10 > 2500.0)
		{
			num9 += 60.0 * (double)(k3 + r1 + B + r2 + k4 + 10);
		}
		else if (num10 > 1250.0)
		{
			num9 += 30.0 * (double)(k3 + r1 + B + r2 + k4 + 10);
		}
		if (k3 + r1 + B + r2 + k4 + 10 > 2500)
		{
			num9 += 60.0 * num10;
		}
		else if (k3 + r1 + B + r2 + k4 + 10 > 1250)
		{
			num9 += 30.0 * num10;
		}
		double num11 = num9 * (Math.Sqrt((double)(B1 + r1) * (double)(B1 + r1) + (double)((H - H1) * (H - H1))) / (double)(B1 + r1) + Math.Sqrt((double)(B2 + r2) * (double)(B2 + r2) + (double)(H - H2) * (double)(H - H2)) / (double)(B2 + r2)) / 2.0;
		num10 = (Math.PI * ((double)B / 2.0 + (double)r1) * (double)(B1 + r1 + k1 - L) + ((double)(B1 + k1 - L) - (double)B / 2.0) * ((double)(B1 + k1 - L) - (double)B / 2.0)) / ((double)(B1 + 2 * r1 + k1 - L) + (double)B / 2.0);
		double num12 = (double)(H + H1 + 100) / 2.0 * num10 + (double)((H1 + 50) * k3);
		if (num10 > 1250.0)
		{
			num3 = ((H > H1) ? H : H1);
			num12 += 30.0 * (double)num3;
		}
		num10 = (Math.PI * ((double)B / 2.0 + (double)r2) * (double)(B2 + r2 + k2 - L) + ((double)(B2 + k2 - L) - (double)B / 2.0) * ((double)(B2 + k2 - L) - (double)B / 2.0)) / ((double)(B2 + 2 * r2 + k2 - L) + (double)B / 2.0);
		double num13 = (double)(H + H2 + 100) / 2.0 * num10 + (double)((H2 + 50) * k4);
		if (num10 > 1250.0)
		{
			num3 = ((H > H2) ? H : H2);
			num13 += (double)(30 * num3);
		}
		double num14 = Math.PI * (double)r1 * (double)(H + H1 + 100) / 4.0 + (double)((H + 50) * k1) + (double)((H1 + 50) * k3);
		double num15 = Math.PI * (double)r2 * (double)(H + H2 + 100) / 4.0 + (double)((H + 50) * k2) + (double)((H2 + 50) * k4);
		array[0, 0] = (num9 + num11 + num12 + num13 + num14 + num15) * (1.0 + num2 / 100.0) / 1000000.0;
		num9 = Math.PI * (double)(B / 2 + r1) * (double)(B1 + r1 + k1 - L) / 4.0 + (double)(B1 * k3) + (double)L * ((double)B / 2.0 + (double)r1) - (double)(k1 * r1) - Math.PI * (double)r1 * (double)r1 / 4.0;
		num9 += Math.PI * (double)(B / 2 + r2) * (double)(B2 + r2 + k2 - L) / 4.0 + (double)(B2 * k4) + (double)L * ((double)B / 2.0 + (double)r2) - (double)(k2 * r2) - Math.PI * (double)r2 * (double)r2 / 4.0;
		num11 = Math.Sqrt((double)(B1 + r1) * (double)(B1 + r1) + (double)((H - H1) * (H - H1))) / (double)(B1 + r1) * (Math.PI * (double)(B / 2 + r1) * (double)(B1 + r1 + k1 - L) / 4.0 + (double)L * ((double)B / 2.0 + (double)r1) - (double)(k1 * r1) - Math.PI * (double)r1 * (double)r1 / 4.0 - (double)B * (double)k1 / 2.0) + (double)(B1 * k3) + (double)B * (double)k1 / 2.0;
		num11 += Math.Sqrt((double)(B2 + r2) * (double)(B2 + r2) + (double)((H - H2) * (H - H2))) / (double)(B2 + r2) * (Math.PI * ((double)B / 2.0 + (double)r2) * (double)(B2 + r2 + k2 - L) / 4.0 + (double)L * ((double)B / 2.0 + (double)r2) - (double)(k2 * r2) - Math.PI * (double)r2 * (double)r2 / 4.0 - (double)(B * k2 / 2)) + (double)(B2 * k4) + (double)B * (double)k2 / 2.0;
		num10 = (Math.PI * ((double)B / 2.0 + (double)r1) * (double)(B1 + r1 + k1 - L) + ((double)(B1 + k1 - L) - (double)B / 2.0) * ((double)(B1 + k1 - L) - (double)B / 2.0)) / ((double)(B1 + 2 * r1 + k1 - L) + (double)B / 2.0);
		num12 = (double)(H + H1) / 2.0 * num10 + (double)(H1 * k3);
		num10 = (Math.PI * ((double)B / 2.0 + (double)r2) * (double)(B2 + r2 + k2 - L) + ((double)(B2 + k2 - L) - (double)B / 2.0) * ((double)(B2 + k2 - L) - (double)B / 2.0)) / ((double)(B2 + 2 * r2 + k2 - L) + (double)B / 2.0);
		num13 = (double)(H + H2) / 2.0 * num10 + (double)(H2 * k4);
		num14 = Math.PI * (double)r1 * (double)(H + H1) / 4.0 + (double)(H * k1) + (double)(H1 * k3);
		num15 = Math.PI * (double)r2 * (double)(H + H2) / 4.0 + (double)(H * k2) + (double)(H2 * k4);
		num2 = Math.Round((1000000.0 * array[0, 0] / (num9 + num11 + num12 + num13 + num14 + num15) - 1.0) * 100.0);
		if (num2 > 20.0)
		{
			num2 = 20.0;
			array[0, 0] = (num9 + num11 + num12 + num13 + num14 + num15) * (1.0 + num2 / 100.0) / 1000000.0;
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
		if (typTSHOAPenter == 1 && typProfilBH == 0)
		{
			num3 = ((B >= H) ? B : H);
			typProfilBH = ((num3 < 800) ? 1 : 2);
		}
		if (typTSHOAPleft == 1 && typProfilB1H1 == 0)
		{
			num3 = ((B1 >= H1) ? B1 : H1);
			typProfilB1H1 = ((num3 < 800) ? 1 : 2);
		}
		if (typTSHOAPright == 1 && typProfilB2H2 == 0)
		{
			num3 = ((B2 >= H2) ? B2 : H2);
			typProfilB2H2 = ((num3 < 800) ? 1 : 2);
		}
		double[,] array2 = new double[2, 6];
		int num16 = 1;
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
						materialName[num16 + i] = FlanetsPrjamokutnyj.materialName[i];
						for (int j = 0; j < 6; j++)
						{
							array[num16 + i, j] = ((j == 1) ? array2[i, j] : (array[num16 + i, j] + array2[i, j]));
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
						materialName[num16 + l] = FlanetsPrjamokutnyj.materialName[l];
						for (int m = 0; m < 6; m++)
						{
							array[num16 + l, m] = ((m == 1) ? array2[l, m] : (array[num16 + l, m] + array2[l, m]));
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
						materialName[num16 + n] = FlanetsPrjamokutnyj.materialName[n];
						for (int num17 = 0; num17 < 6; num17++)
						{
							array[num16 + n, num17] = ((num17 == 1) ? array2[n, num17] : (array[num16 + n, num17] + array2[n, num17]));
						}
					}
				}
			}
			num16 += 2;
		}
		if (typProfilBH == 2 || typProfilB1H1 == 2 || typProfilB2H2 == 2)
		{
			if (typProfilBH == 2)
			{
				array2 = FlanetsPrjamokutnyj.MaterialFlanetsPrjamokutnyj(B, H, typProfilBH, number, polkaBH, 1);
				materialCost += FlanetsPrjamokutnyj.materialCost1;
				for (int num18 = 0; num18 < 2; num18++)
				{
					if (FlanetsPrjamokutnyj.materialName[num18] != "")
					{
						materialName[num16 + num18] = FlanetsPrjamokutnyj.materialName[num18];
						for (int num19 = 0; num19 < 6; num19++)
						{
							array[num16 + num18, num19] = ((num19 == 1) ? array2[num18, num19] : (array[num16 + num18, num19] + array2[num18, num19]));
						}
					}
				}
			}
			if (typProfilB1H1 == 2)
			{
				array2 = FlanetsPrjamokutnyj.MaterialFlanetsPrjamokutnyj(B1, H, typProfilB1H1, number, polkaB1H1, 1);
				materialCost += FlanetsPrjamokutnyj.materialCost1;
				for (int num20 = 0; num20 < 2; num20++)
				{
					if (FlanetsPrjamokutnyj.materialName[num20] != "")
					{
						materialName[num16 + num20] = FlanetsPrjamokutnyj.materialName[num20];
						for (int num21 = 0; num21 < 6; num21++)
						{
							array[num16 + num20, num21] = ((num21 == 1) ? array2[num20, num21] : (array[num16 + num20, num21] + array2[num20, num21]));
						}
					}
				}
			}
			if (typProfilB2H2 == 2)
			{
				array2 = FlanetsPrjamokutnyj.MaterialFlanetsPrjamokutnyj(B2, H, typProfilB2H2, number, polkaB2H2, 1);
				materialCost += FlanetsPrjamokutnyj.materialCost1;
				for (int num22 = 0; num22 < 2; num22++)
				{
					if (FlanetsPrjamokutnyj.materialName[num22] != "")
					{
						materialName[num16 + num22] = FlanetsPrjamokutnyj.materialName[num22];
						for (int num23 = 0; num23 < 6; num23++)
						{
							array[num16 + num22, num23] = ((num23 == 1) ? array2[num22, num23] : (array[num16 + num22, num23] + array2[num22, num23]));
						}
					}
				}
			}
			num16 += 2;
		}
		if (typProfilBH == 1 || typProfilBH == 2)
		{
			double[,] array3 = new double[1, 6];
			array3 = HvyntNaFlanets.MaterialHvyntNaFlanets(B, H, 1, number);
			materialCost += HvyntNaFlanets.materialCost1;
			materialName[num16] = HvyntNaFlanets.materialName1[0];
			for (int num24 = 0; num24 < 6; num24++)
			{
				array[num16, num24] = array3[0, num24];
			}
		}
		if (typProfilB1H1 == 1 || typProfilB1H1 == 2)
		{
			double[,] array4 = new double[1, 6];
			array4 = HvyntNaFlanets.MaterialHvyntNaFlanets(B1, H1, 1, number);
			materialCost += HvyntNaFlanets.materialCost1;
			materialName[num16] = HvyntNaFlanets.materialName1[0];
			for (int num25 = 0; num25 < 6; num25++)
			{
				array[num16, num25] += array4[0, num25];
			}
		}
		if (typProfilB2H2 == 1 || typProfilB2H2 == 2)
		{
			double[,] array5 = new double[1, 6];
			array5 = HvyntNaFlanets.MaterialHvyntNaFlanets(B2, H2, 1, number);
			materialCost += HvyntNaFlanets.materialCost1;
			materialName[num16] = HvyntNaFlanets.materialName1[0];
			for (int num26 = 0; num26 < 6; num26++)
			{
				array[num16, num26] += array5[0, num26];
			}
		}
		if (typProfilBH == 1 || typProfilB1H1 == 1 || typProfilB2H2 == 1 || typProfilBH == 2 || typProfilB1H1 == 2 || typProfilB2H2 == 2)
		{
			num16++;
		}
		if (typProfilBH == 3 || typProfilB1H1 == 3 || typProfilB2H2 == 3)
		{
			if (typProfilBH == 3)
			{
				array2 = FlanetsPrjamokutnyj.MaterialFlanetsPrjamokutnyj(B, H, typProfilBH, number, polkaBH, 1);
				materialCost += FlanetsPrjamokutnyj.materialCost1;
				if (FlanetsPrjamokutnyj.materialName[0] != "")
				{
					materialName[num16] = FlanetsPrjamokutnyj.materialName[0];
					for (int num27 = 0; num27 < 6; num27++)
					{
						array[num16, num27] = ((num27 == 1) ? array2[0, num27] : (array[num16, num27] + array2[0, num27]));
					}
				}
			}
			if (typProfilB1H1 == 3)
			{
				array2 = FlanetsPrjamokutnyj.MaterialFlanetsPrjamokutnyj(B1, H, typProfilB1H1, number, polkaB1H1, 1);
				materialCost += FlanetsPrjamokutnyj.materialCost1;
				if (FlanetsPrjamokutnyj.materialName[0] != "")
				{
					materialName[num16] = FlanetsPrjamokutnyj.materialName[0];
					for (int num28 = 0; num28 < 6; num28++)
					{
						array[num16, num28] = ((num28 == 1) ? array2[0, num28] : (array[num16, num28] + array2[0, num28]));
					}
				}
			}
			if (typProfilB2H2 == 3)
			{
				array2 = FlanetsPrjamokutnyj.MaterialFlanetsPrjamokutnyj(B2, H, typProfilB2H2, number, polkaB2H2, 1);
				materialCost += FlanetsPrjamokutnyj.materialCost1;
				if (FlanetsPrjamokutnyj.materialName[0] != "")
				{
					materialName[num16] = FlanetsPrjamokutnyj.materialName[0];
					for (int num29 = 0; num29 < 6; num29++)
					{
						array[num16, num29] = ((num29 == 1) ? array2[0, num29] : (array[num16, num29] + array2[0, num29]));
					}
				}
			}
			num16++;
		}
		if (typProfilBH == 4 || typProfilB1H1 == 4 || typProfilB2H2 == 4)
		{
			if (typProfilBH == 4)
			{
				array2 = FlanetsPrjamokutnyj.MaterialFlanetsPrjamokutnyj(B, H, typProfilBH, number, polkaBH, 1);
				materialCost += FlanetsPrjamokutnyj.materialCost1;
				if (FlanetsPrjamokutnyj.materialName[0] != "")
				{
					materialName[num16] = FlanetsPrjamokutnyj.materialName[0];
					for (int num30 = 0; num30 < 6; num30++)
					{
						array[num16, num30] = ((num30 == 1) ? array2[0, num30] : (array[num16, num30] + array2[0, num30]));
					}
				}
			}
			if (typProfilB1H1 == 4)
			{
				array2 = FlanetsPrjamokutnyj.MaterialFlanetsPrjamokutnyj(B1, H, typProfilB1H1, number, polkaB1H1, 1);
				materialCost += FlanetsPrjamokutnyj.materialCost1;
				if (FlanetsPrjamokutnyj.materialName[0] != "")
				{
					materialName[num16] = FlanetsPrjamokutnyj.materialName[0];
					for (int num31 = 0; num31 < 6; num31++)
					{
						array[num16, num31] = ((num31 == 1) ? array2[0, num31] : (array[num16, num31] + array2[0, num31]));
					}
				}
			}
			if (typProfilB2H2 == 4)
			{
				array2 = FlanetsPrjamokutnyj.MaterialFlanetsPrjamokutnyj(B2, H, typProfilB2H2, number, polkaB2H2, 1);
				materialCost += FlanetsPrjamokutnyj.materialCost1;
				if (FlanetsPrjamokutnyj.materialName[0] != "")
				{
					materialName[num16] = FlanetsPrjamokutnyj.materialName[0];
					for (int num32 = 0; num32 < 6; num32++)
					{
						array[num16, num32] = ((num32 == 1) ? array2[0, num32] : (array[num16, num32] + array2[0, num32]));
					}
				}
			}
		}
		return array;
	}

	public static double PriceTrijnykTSHOAP(int B, int H, int B1, int H1, int B2, int H2, int k1, int k2, int k3, int k4, int L, int r1, int r2, int markaStali, double tovchynaMetalu, int typTSHOAPenter, int typTSHOAPleft, int typTSHOAPright)
	{
		double num = 1.0;
		int num2 = ((B >= H) ? B : H);
		if (B1 >= num2)
		{
			num2 = B1;
		}
		if (H1 >= num2)
		{
			num2 = H1;
		}
		if (B2 >= num2)
		{
			num2 = B2;
		}
		if (H2 >= num2)
		{
			num2 = H2;
		}
		switch (markaStali)
		{
		case 1:
			if (tovchynaMetalu == 0.0)
			{
				tovchynaMetalu = ((num2 > 400) ? ((num2 <= 800) ? 0.7 : 0.9) : 0.5);
			}
			num = ((typTSHOAPenter != 1 && typTSHOAPleft != 1 && typTSHOAPright != 1) ? ((!(tovchynaMetalu < 0.65)) ? ((tovchynaMetalu < 0.9) ? 406.0 : 520.0) : 345.0) : ((!(tovchynaMetalu < 0.65)) ? ((tovchynaMetalu < 0.9) ? 464.0 : 600.0) : 402.5));
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
		double num7 = Math.PI * ((double)B / 2.0 + (double)r1) * (double)(B1 + r1 + k1 - L) / 4.0 + (double)(B1 * k3) + (double)L * ((double)B / 2.0 + (double)r1) - (double)(k1 * r1) - Math.PI * (double)r1 * (double)r1 / 4.0;
		num7 += Math.PI * ((double)B / 2.0 + (double)r2) * (double)(B2 + r2 + k2 - L) / 4.0 + (double)(B2 * k4) + (double)L * ((double)B / 2.0 + (double)r2) - (double)(k2 * r2) - Math.PI * (double)r2 * (double)r2 / 4.0;
		double num8 = Math.Sqrt((double)(B1 + r1) * (double)(B1 + r1) + (double)((H - H1) * (H - H1))) / (double)(B1 + r1) * (Math.PI * ((double)B / 2.0 + (double)r1) * (double)(B1 + r1 + k1 - L) / 4.0 + (double)L * ((double)B / 2.0 + (double)r1) - (double)(k1 * r1) - Math.PI * (double)r1 * (double)r1 / 4.0 - (double)B * (double)k1 / 2.0) + (double)(B1 * k3) + (double)B * (double)k1 / 2.0;
		num8 += Math.Sqrt((double)(B2 + r2) * (double)(B2 + r2) + (double)((H - H2) * (H - H2))) / (double)(B2 + r2) * (Math.PI * ((double)B / 2.0 + (double)r2) * (double)(B2 + r2 + k2 - L) / 4.0 + (double)L * ((double)B / 2.0 + (double)r2) - (double)(k2 * r2) - Math.PI * (double)r2 * (double)r2 / 4.0 - (double)B * (double)k2 / 2.0) + (double)(B2 * k4) + (double)B * (double)k2 / 2.0;
		double num9 = (Math.PI * ((double)B / 2.0 + (double)r1) * (double)(B1 + r1 + k1 - L) + ((double)(B1 + k1 - L) - (double)B / 2.0) * ((double)(B1 + k1 - L) - (double)B / 2.0)) / ((double)(B1 + 2 * r1 + k1 - L) + (double)B / 2.0);
		double num10 = (double)(H + H1) / 2.0 * num9 + (double)(H1 * k3);
		num9 = (Math.PI * ((double)B / 2.0 + (double)r2) * (double)(B2 + r2 + k2 - L) + ((double)(B2 + k2 - L) - (double)B / 2.0) * ((double)(B2 + k2 - L) - (double)B / 2.0)) / ((double)(B2 + 2 * r2 + k2 - L) + (double)B / 2.0);
		double num11 = (double)(H + H2) / 2.0 * num9 + (double)(H2 * k4);
		double num12 = Math.PI * (double)r1 * (double)(H + H1) / 4.0 + (double)(H * k1) + (double)(H1 * k3);
		double num13 = Math.PI * (double)r2 * (double)(H + H2) / 4.0 + (double)(H * k2) + (double)(H2 * k4);
		materialSpendingCommercialOffer = (num7 + num8 + num10 + num11 + num12 + num13) / 1000000.0;
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

	public static double VolumeTrijnykTSHOAP(int B, int H, int B1, int H1, int B2, int H2, int k1, int k2, int k3, int k4, int r1, int r2)
	{
		double num = ((B1 + r1 + k1 > B2 + r2 + k2) ? (B1 + r1 + k1) : (B2 + r2 + k2));
		double num2 = ((H > H1) ? H : H1);
		if ((double)H2 > num2)
		{
			num2 = H2;
		}
		double num3 = k3 + r1 + B + r2 + k4;
		return Math.Round(num * num2 * num3 / 1000000.0) / 1000.0;
	}
}
