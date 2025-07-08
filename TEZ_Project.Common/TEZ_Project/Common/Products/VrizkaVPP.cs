using System;
using TEZ_Project.Common.Helpers;
using TEZ_Project;

namespace TEZ_Project.Common.Products;

public static class VrizkaVPP
{
	public static string[] materialName = new string[10] { "", "", "", "", "", "", "", "", "", "" };

	public static double materialCost;

	public static double materialSpendingCommercialOffer = 0.0;

	public static double tovchynaMetaluCommercialOffer = 0.0;

	public static double[,] MaterialVrizkaVPP(int B, int H, int L, int B1, int H1, int l, int markaStali, double tovchynaMetalu, int typVPPenter, int typVPPout, int typVPPvrizka, int typProfilBH, int typProfilB1H1, int typProfilB2H2, int number, int polkaBH, int polkaB1H1, int polkaB2H2, int vidbortovka, string aisiType = "430")
	{
		double[,] array = new double[10, 6];
		double num = 0.0;
		double num2 = 0.0;
		int num3 = ((B >= H) ? B : H);
		double num4 = 2.0 * (double)(B + H);
		double num5 = 2.0 * (double)(B1 + H1);
		double num6 = 0.0;
		L += vidbortovka;
		if (H1 > num3)
		{
			num3 = H1;
		}
		materialName = new string[10] { "", "", "", "", "", "", "", "", "", "" };
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
			double num7 = tovchynaMetalu;
			double num8 = num7;
			if (num8 != 0.5)
			{
				if (num8 != 0.65)
				{
					if (num8 != 0.68)
					{
						if (num8 != 0.7)
						{
							if (num8 != 0.9)
							{
								if (num8 != 1.0)
								{
									if (num8 == 1.2)
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
			double num9 = tovchynaMetalu;
			double num10 = num9;
			if (num10 != 0.5)
			{
				if (num10 != 0.8)
				{
					if (num10 != 1.0)
					{
						if (num10 != 1.2)
						{
							if (num10 != 1.5)
							{
								if (num10 != 2.0)
								{
									if (num10 != 2.5)
									{
										if (num10 != 3.0)
										{
											if (num10 != 4.0)
											{
												if (num10 != 5.0)
												{
													if (num10 == 6.0)
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
			num2 = MaterialHelper.GetMaterialWithdrawalNerzavijka(tovchynaMetalu);
			CustomConst lystNerzavijuchyj = MaterialHelper.GetLystNerzavijuchyj(tovchynaMetalu, aisiType);
			materialName[0] = lystNerzavijuchyj?.MaterialName ?? "Лист НЕРЖ ??, м2";
			num6 = lystNerzavijuchyj.Price;
			break;
		}
		}
		double num11 = num4 + 30.0;
		double num12 = num11 * (double)L;
		if (num11 > 2500.0)
		{
			num12 += 60.0 * (double)L;
		}
		else if (num11 > 1250.0)
		{
			num12 += 30.0 * (double)L;
		}
		if (L > 2500)
		{
			num12 += 60.0 * num11;
		}
		else if (L > 1250)
		{
			num12 += 30.0 * num11;
		}
		double num13 = (num5 + 30.0) * (double)(l + 12);
		if (num5 + 30.0 > 2500.0)
		{
			num13 += 60.0 * (double)(l + 12);
		}
		else if (num5 + 30.0 > 1250.0)
		{
			num13 += 30.0 * (double)(l + 12);
		}
		array[0, 0] = (num12 + num13) * (1.0 + num2 / 100.0) / 1000000.0;
		num12 = ((2.0 * (double)(B + H) + 30.0) * (double)L + (2.0 * (double)(B1 + H1) * (double)l - (double)(B1 * H1))) / 1000000.0;
		num2 = Math.Round((array[0, 0] / num12 - 1.0) * 100.0);
		if (num2 > 20.0)
		{
			num2 = 20.0;
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
		materialCost = array[0, 0] * num6;
		if (typVPPenter == 1 && typProfilBH == 0)
		{
			num3 = ((B >= H) ? B : H);
			typProfilBH = ((num3 < 800) ? 1 : 2);
		}
		if (typVPPout == 1 && typProfilB1H1 == 0)
		{
			num3 = ((B >= H) ? B : H);
			typProfilB1H1 = ((num3 < 800) ? 1 : 2);
		}
		if (typVPPvrizka == 1 && typProfilB2H2 == 0)
		{
			num3 = ((B1 >= H1) ? B1 : H1);
			typProfilB2H2 = ((num3 < 800) ? 1 : 2);
		}
		double[,] array2 = new double[2, 6];
		int num14 = 1;
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
						materialName[num14 + i] = FlanetsPrjamokutnyj.materialName[i];
						for (int j = 0; j < 6; j++)
						{
							array[num14 + i, j] = ((j == 1) ? array2[i, j] : (array[num14 + i, j] + array2[i, j]));
						}
					}
				}
			}
			if (typProfilB1H1 == 1)
			{
				array2 = FlanetsPrjamokutnyj.MaterialFlanetsPrjamokutnyj(B, H, typProfilB1H1, number, polkaB1H1, 1);
				materialCost += FlanetsPrjamokutnyj.materialCost1;
				for (int k = 0; k < 2; k++)
				{
					if (FlanetsPrjamokutnyj.materialName[k] != "")
					{
						materialName[num14 + k] = FlanetsPrjamokutnyj.materialName[k];
						for (int m = 0; m < 6; m++)
						{
							array[num14 + k, m] = ((m == 1) ? array2[k, m] : (array[num14 + k, m] + array2[k, m]));
						}
					}
				}
			}
			if (typProfilB2H2 == 1)
			{
				array2 = FlanetsPrjamokutnyj.MaterialFlanetsPrjamokutnyj(B1, H1, typProfilB2H2, number, polkaB2H2, 1);
				materialCost += FlanetsPrjamokutnyj.materialCost1;
				for (int n = 0; n < 2; n++)
				{
					if (FlanetsPrjamokutnyj.materialName[n] != "")
					{
						materialName[num14 + n] = FlanetsPrjamokutnyj.materialName[n];
						for (int num15 = 0; num15 < 6; num15++)
						{
							array[num14 + n, num15] = ((num15 == 1) ? array2[n, num15] : (array[num14 + n, num15] + array2[n, num15]));
						}
					}
				}
			}
			num14 += 2;
		}
		if (typProfilBH == 2 || typProfilB1H1 == 2 || typProfilB2H2 == 2)
		{
			if (typProfilBH == 2)
			{
				array2 = FlanetsPrjamokutnyj.MaterialFlanetsPrjamokutnyj(B, H, typProfilBH, number, polkaBH, 1);
				materialCost += FlanetsPrjamokutnyj.materialCost1;
				for (int num16 = 0; num16 < 2; num16++)
				{
					if (FlanetsPrjamokutnyj.materialName[num16] != "")
					{
						materialName[num14 + num16] = FlanetsPrjamokutnyj.materialName[num16];
						for (int num17 = 0; num17 < 6; num17++)
						{
							array[num14 + num16, num17] = ((num17 == 1) ? array2[num16, num17] : (array[num14 + num16, num17] + array2[num16, num17]));
						}
					}
				}
			}
			if (typProfilB1H1 == 2)
			{
				array2 = FlanetsPrjamokutnyj.MaterialFlanetsPrjamokutnyj(B, H, typProfilB1H1, number, polkaB1H1, 1);
				materialCost += FlanetsPrjamokutnyj.materialCost1;
				for (int num18 = 0; num18 < 2; num18++)
				{
					if (FlanetsPrjamokutnyj.materialName[num18] != "")
					{
						materialName[num14 + num18] = FlanetsPrjamokutnyj.materialName[num18];
						for (int num19 = 0; num19 < 6; num19++)
						{
							array[num14 + num18, num19] = ((num19 == 1) ? array2[num18, num19] : (array[num14 + num18, num19] + array2[num18, num19]));
						}
					}
				}
			}
			if (typProfilB2H2 == 2)
			{
				array2 = FlanetsPrjamokutnyj.MaterialFlanetsPrjamokutnyj(B1, H1, typProfilB2H2, number, polkaB2H2, 1);
				materialCost += FlanetsPrjamokutnyj.materialCost1;
				for (int num20 = 0; num20 < 2; num20++)
				{
					if (FlanetsPrjamokutnyj.materialName[num20] != "")
					{
						materialName[num14 + num20] = FlanetsPrjamokutnyj.materialName[num20];
						for (int num21 = 0; num21 < 6; num21++)
						{
							array[num14 + num20, num21] = ((num21 == 1) ? array2[num20, num21] : (array[num14 + num20, num21] + array2[num20, num21]));
						}
					}
				}
			}
			num14 += 2;
		}
		if (typProfilBH == 1 || typProfilBH == 2)
		{
			double[,] array3 = new double[1, 6];
			array3 = HvyntNaFlanets.MaterialHvyntNaFlanets(B, H, 1, number);
			materialCost += HvyntNaFlanets.materialCost1;
			materialName[num14] = HvyntNaFlanets.materialName1[0];
			for (int num22 = 0; num22 < 6; num22++)
			{
				array[num14, num22] = array3[0, num22];
			}
		}
		if (typProfilB1H1 == 1 || typProfilB1H1 == 2)
		{
			double[,] array4 = new double[1, 6];
			array4 = HvyntNaFlanets.MaterialHvyntNaFlanets(B, H, 1, number);
			materialCost += HvyntNaFlanets.materialCost1;
			materialName[num14] = HvyntNaFlanets.materialName1[0];
			for (int num23 = 0; num23 < 6; num23++)
			{
				array[num14, num23] += array4[0, num23];
			}
		}
		if (typProfilB2H2 == 1 || typProfilB2H2 == 2)
		{
			double[,] array5 = new double[1, 6];
			array5 = HvyntNaFlanets.MaterialHvyntNaFlanets(B1, H1, 1, number);
			materialCost += HvyntNaFlanets.materialCost1;
			materialName[num14] = HvyntNaFlanets.materialName1[0];
			for (int num24 = 0; num24 < 6; num24++)
			{
				array[num14, num24] += array5[0, num24];
			}
		}
		if (typProfilBH == 1 || typProfilB1H1 == 1 || typProfilB2H2 == 1 || typProfilBH == 2 || typProfilB1H1 == 2 || typProfilB2H2 == 2)
		{
			num14++;
		}
		if (typProfilBH == 3 || typProfilB1H1 == 3 || typProfilB2H2 == 3)
		{
			if (typProfilBH == 3)
			{
				array2 = FlanetsPrjamokutnyj.MaterialFlanetsPrjamokutnyj(B, H, typProfilBH, number, polkaBH, 1);
				materialCost += FlanetsPrjamokutnyj.materialCost1;
				if (FlanetsPrjamokutnyj.materialName[0] != "")
				{
					materialName[num14] = FlanetsPrjamokutnyj.materialName[0];
					for (int num25 = 0; num25 < 6; num25++)
					{
						array[num14, num25] = ((num25 == 1) ? array2[0, num25] : (array[num14, num25] + array2[0, num25]));
					}
				}
			}
			if (typProfilB1H1 == 3)
			{
				array2 = FlanetsPrjamokutnyj.MaterialFlanetsPrjamokutnyj(B, H, typProfilB1H1, number, polkaB1H1, 1);
				materialCost += FlanetsPrjamokutnyj.materialCost1;
				if (FlanetsPrjamokutnyj.materialName[0] != "")
				{
					materialName[num14] = FlanetsPrjamokutnyj.materialName[0];
					for (int num26 = 0; num26 < 6; num26++)
					{
						array[num14, num26] = ((num26 == 1) ? array2[0, num26] : (array[num14, num26] + array2[0, num26]));
					}
				}
			}
			if (typProfilB2H2 == 3)
			{
				array2 = FlanetsPrjamokutnyj.MaterialFlanetsPrjamokutnyj(B1, H1, typProfilB2H2, number, polkaB2H2, 1);
				materialCost += FlanetsPrjamokutnyj.materialCost1;
				if (FlanetsPrjamokutnyj.materialName[0] != "")
				{
					materialName[num14] = FlanetsPrjamokutnyj.materialName[0];
					for (int num27 = 0; num27 < 6; num27++)
					{
						array[num14, num27] = ((num27 == 1) ? array2[0, num27] : (array[num14, num27] + array2[0, num27]));
					}
				}
			}
			num14++;
		}
		if (typProfilBH == 4 || typProfilB1H1 == 4 || typProfilB2H2 == 4)
		{
			if (typProfilBH == 4)
			{
				array2 = FlanetsPrjamokutnyj.MaterialFlanetsPrjamokutnyj(B, H, typProfilBH, number, polkaBH, 1);
				materialCost += FlanetsPrjamokutnyj.materialCost1;
				if (FlanetsPrjamokutnyj.materialName[0] != "")
				{
					materialName[num14] = FlanetsPrjamokutnyj.materialName[0];
					for (int num28 = 0; num28 < 6; num28++)
					{
						array[num14, num28] = ((num28 == 1) ? array2[0, num28] : (array[num14, num28] + array2[0, num28]));
					}
				}
			}
			if (typProfilB1H1 == 4)
			{
				array2 = FlanetsPrjamokutnyj.MaterialFlanetsPrjamokutnyj(B, H, typProfilB1H1, number, polkaB1H1, 1);
				materialCost += FlanetsPrjamokutnyj.materialCost1;
				if (FlanetsPrjamokutnyj.materialName[0] != "")
				{
					materialName[num14] = FlanetsPrjamokutnyj.materialName[0];
					for (int num29 = 0; num29 < 6; num29++)
					{
						array[num14, num29] = ((num29 == 1) ? array2[0, num29] : (array[num14, num29] + array2[0, num29]));
					}
				}
			}
			if (typProfilB2H2 == 4)
			{
				array2 = FlanetsPrjamokutnyj.MaterialFlanetsPrjamokutnyj(B1, H1, typProfilB2H2, number, polkaB2H2, 1);
				materialCost += FlanetsPrjamokutnyj.materialCost1;
				if (FlanetsPrjamokutnyj.materialName[0] != "")
				{
					materialName[num14] = FlanetsPrjamokutnyj.materialName[0];
					for (int num30 = 0; num30 < 6; num30++)
					{
						array[num14, num30] = ((num30 == 1) ? array2[0, num30] : (array[num14, num30] + array2[0, num30]));
					}
				}
			}
		}
		return array;
	}

	public static double PriceVrizkaVPP(int B, int H, int L, int B1, int H1, int l, int markaStali, double tovchynaMetalu, int typVPPenter, int typVPPout, int typVPPvrizka, int vidbortovka)
	{
		double num = 1.0;
		int num2 = ((B >= H) ? B : H);
		L += vidbortovka;
		if (H1 > num2)
		{
			num2 = H1;
		}
		switch (markaStali)
		{
		case 1:
			if (tovchynaMetalu == 0.0)
			{
				tovchynaMetalu = ((num2 > 400) ? ((num2 <= 800) ? 0.7 : 0.9) : 0.5);
			}
			num = ((typVPPenter != 1 && typVPPout != 1 && typVPPvrizka != 1) ? ((!(tovchynaMetalu < 0.65)) ? ((tovchynaMetalu < 0.9) ? 406.0 : 520.0) : 345.0) : ((!(tovchynaMetalu < 0.65)) ? ((tovchynaMetalu < 0.9) ? 464.0 : 600.0) : 402.5));
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
		materialSpendingCommercialOffer = (2.0 * (double)((B + H) * L + (B1 + H1) * l) - (double)(B1 * H1)) / 1000000.0;
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

	public static double VolumeVrizkaVPP(int B, int H, int L, int l)
	{
		return Math.Round((double)B * (double)(H + l) * (double)L / 1000000.0) / 1000.0;
	}
}
