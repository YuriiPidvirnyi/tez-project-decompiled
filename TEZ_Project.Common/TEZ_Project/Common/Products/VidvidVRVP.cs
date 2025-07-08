using System;
using TEZ_Project.Common.Helpers;
using TEZ_Project;

namespace TEZ_Project.Common.Products;

public static class VidvidVRVP
{
	public static string[] materialName = new string[7] { "", "", "", "", "", "", "" };

	public static double materialCost;

	public static double materialSpendingCommercialOffer = 0.0;

	public static double tovchynaMetaluCommercialOffer = 0.0;

	public static double[,] MaterialVidvidVRVP(int B, int B1, int H, int k, int k1, int r, int Angle, int markaStali, double tovchynaMetalu, int typVRVP, int typProfilB1, int typProfilB2, int number, int polkaBH, int polkaB1H1, string aisiType = "430")
	{
		double[,] array = new double[7, 6];
		double num = 0.0;
		double num2 = 0.0;
		double num3 = 0.0;
		double num4 = 0.0;
		double num5 = 0.0;
		double num6 = 0.0;
		int num7 = 0;
		int num8 = 0;
		int num9 = ((B >= H) ? B : H);
		double num10 = 0.0;
		double num11 = 0.0;
		materialName = new string[7] { "", "", "", "", "", "", "" };
		materialCost = 0.0;
		if (B1 >= num9)
		{
			num9 = B1;
		}
		switch (markaStali)
		{
		case 1:
		{
			if (tovchynaMetalu == 0.0)
			{
				tovchynaMetalu = ((num9 > 400) ? ((num9 <= 800) ? 0.7 : 0.9) : 0.5);
			}
			num = 7825.0;
			double num12 = tovchynaMetalu;
			double num13 = num12;
			if (num13 != 0.5)
			{
				if (num13 != 0.65)
				{
					if (num13 != 0.68)
					{
						if (num13 != 0.7)
						{
							if (num13 != 0.9)
							{
								if (num13 != 1.0)
								{
									if (num13 == 1.2)
									{
										materialName[0] = Consts2.lystOchynkovanyj12.MaterialName;
										num11 = Consts2.lystOchynkovanyj12.Price;
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
									num11 = Consts2.lystOchynkovanyj10.Price;
									num4 = 10.0;
								}
							}
							else
							{
								materialName[0] = Consts2.lystOchynkovanyj09.MaterialName;
								num11 = Consts2.lystOchynkovanyj09.Price;
								num4 = 10.0;
							}
						}
						else
						{
							materialName[0] = Consts2.lystOchynkovanyj07.MaterialName;
							num11 = Consts2.lystOchynkovanyj07.Price;
							num4 = 10.0;
						}
					}
					else
					{
						materialName[0] = Consts2.lystOchynkovanyj068.MaterialName;
						num11 = Consts2.lystOchynkovanyj068.Price;
						num4 = 10.0;
					}
				}
				else
				{
					materialName[0] = Consts2.lystOchynkovanyj065.MaterialName;
					num11 = Consts2.lystOchynkovanyj065.Price;
					num4 = 10.0;
				}
			}
			else
			{
				materialName[0] = Consts2.lystOchynkovanyj05.MaterialName;
				num11 = Consts2.lystOchynkovanyj05.Price;
				num4 = 5.0;
			}
			break;
		}
		case 2:
		{
			if (tovchynaMetalu == 0.0)
			{
				tovchynaMetalu = ((num9 > 400) ? ((num9 <= 800) ? 0.8 : 1.0) : 0.5);
			}
			num = 7825.0;
			double num14 = tovchynaMetalu;
			double num15 = num14;
			if (num15 != 0.5)
			{
				if (num15 != 0.8)
				{
					if (num15 != 1.0)
					{
						if (num15 != 1.2)
						{
							if (num15 != 1.5)
							{
								if (num15 != 2.0)
								{
									if (num15 != 2.5)
									{
										if (num15 != 3.0)
										{
											if (num15 != 4.0)
											{
												if (num15 != 5.0)
												{
													if (num15 == 6.0)
													{
														materialName[0] = Consts2.lystStalnyj60.MaterialName;
														num11 = Consts2.lystStalnyj60.Price;
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
													num11 = Consts2.lystStalnyj50.Price;
													num4 = 10.0;
												}
											}
											else
											{
												materialName[0] = Consts2.lystStalnyj40.MaterialName;
												num11 = Consts2.lystStalnyj40.Price;
												num4 = 10.0;
											}
										}
										else
										{
											materialName[0] = Consts2.lystStalnyj30.MaterialName;
											num11 = Consts2.lystStalnyj30.Price;
											num4 = 10.0;
										}
									}
									else
									{
										materialName[0] = Consts2.lystStalnyj25.MaterialName;
										num11 = Consts2.lystStalnyj25.Price;
										num4 = 10.0;
									}
								}
								else
								{
									materialName[0] = Consts2.lystStalnyj20.MaterialName;
									num11 = Consts2.lystStalnyj20.Price;
									num4 = 10.0;
								}
							}
							else
							{
								materialName[0] = Consts2.lystStalnyj15.MaterialName;
								num11 = Consts2.lystStalnyj15.Price;
								num4 = 10.0;
							}
						}
						else
						{
							materialName[0] = Consts2.lystStalnyj12.MaterialName;
							num11 = Consts2.lystStalnyj12.Price;
							num4 = 10.0;
						}
					}
					else
					{
						materialName[0] = Consts2.lystStalnyj10.MaterialName;
						num11 = Consts2.lystStalnyj10.Price;
						num4 = 10.0;
					}
				}
				else
				{
					materialName[0] = Consts2.lystStalnyj08.MaterialName;
					num11 = Consts2.lystStalnyj08.Price;
					num4 = 10.0;
				}
			}
			else
			{
				materialName[0] = Consts2.lystStalnyj05.MaterialName;
				num11 = Consts2.lystStalnyj05.Price;
				num4 = 5.0;
			}
			break;
		}
		case 3:
		{
			if (tovchynaMetalu == 0.0)
			{
				tovchynaMetalu = ((num9 > 400) ? ((num9 <= 800) ? 0.8 : 1.0) : 0.5);
			}
			num = 7825.0;
			CustomConst lystNerzavijuchyj = MaterialHelper.GetLystNerzavijuchyj(tovchynaMetalu, aisiType);
			materialName[0] = lystNerzavijuchyj?.MaterialName ?? "Лист НЕРЖ ??, м2";
			num11 = lystNerzavijuchyj.Price;
			break;
		}
		}
		if (B1 > B)
		{
			int num16 = B;
			B = B1;
			B1 = num16;
			num16 = k;
			k = k1;
			k1 = num16;
		}
		if (r == 0)
		{
			double num17 = Math.PI * (double)(B1 + 5) * (double)(B1 + 5) * (double)Angle / 360.0 + (double)((B1 + 5) * (B - B1 + k1 + 5)) + (double)((B + 10) * k);
			if (B1 + k > 1250)
			{
				num17 += 30.0 * (Math.Sqrt((double)B1 * (double)B1 - (double)((1250 - k) * (1250 - k))) + (double)B - (double)B1 + (double)k1);
			}
			double num18 = (double)(H + 50) * (Math.PI * (double)B1 * (double)Angle / 180.0 + (double)B - (double)B1 + (double)k + (double)k1);
			if (H + 50 > 1250)
			{
				num18 += 30.0 * (Math.PI * (double)B1 * (double)Angle / 180.0 + (double)B - (double)B1 + (double)k + (double)k1);
			}
			double num19 = Math.PI * (double)B1 * (double)Angle / 180.0 + (double)B - (double)B1 + (double)k + (double)k1;
			if (num19 > 2500.0)
			{
				num18 += 60.0 * (double)(H + 50);
			}
			else if (num19 > 1250.0)
			{
				num18 += 30.0 * (double)(H + 50);
			}
			double num20 = (k + k1) * (H + 50);
			switch (typVRVP)
			{
			case 6:
				num10 = 2.0 * (double)(B + H) * 40.0;
				break;
			case 7:
				num10 = 2.0 * (double)(B1 + H) * 40.0;
				break;
			}
			if (typVRVP == 5 || typVRVP == 12)
			{
				num10 += (double)((B + 80) * (H + 80));
			}
			if (typVRVP == 4 || typVRVP == 11)
			{
				num10 += (double)((B1 + 80) * (H + 80));
			}
			array[0, 0] = 2.0 * (double)(B + k1 + 5) * ((double)B1 * Math.Sin(Math.PI * (double)Angle / 180.0) + (double)k + 5.0) + (num18 + num20 + num10) * (1.0 + num4 / 100.0);
			num4 = Math.Round((array[0, 0] / (2.0 * num17 + num18 + num20 + num10) - 1.0) * 100.0);
			if (num4 > 20.0)
			{
				num4 = 20.0;
				array[0, 0] = (2.0 * num17 + num18 + num20 + num10) * (1.0 + num4 / 100.0);
			}
			array[0, 1] = num4 / 100.0;
		}
		else
		{
			double num17 = Math.PI * (double)Angle * (double)(B1 + 5) * (double)(B1 + 2 * r + 5) / 360.0 + (double)((B - B1 + 5) * (B1 + r + 5)) + (double)((B + 10) * k) + (double)((B1 + 10) * k1);
			if (B1 + r + k > 1250)
			{
				num17 += 30.0 * (Math.Sqrt((B1 + r) * (B1 + r) - (1250 - k) * (1250 - k)) + (double)B - (double)B1 + (double)k1);
			}
			double num18 = (double)(H + 50) * (Math.PI * (double)(B1 + r) * (double)Angle / 180.0 + (double)B - (double)B1 + (double)k + (double)k1);
			if (H + 50 > 1250)
			{
				num18 += 30.0 * (Math.PI * (double)(B1 + r) * (double)Angle / 180.0 + (double)B - (double)B1 + (double)k + (double)k1);
			}
			double num19 = Math.PI * (double)(B1 + r) * (double)Angle / 180.0 + (double)B - (double)B1 + (double)k + (double)k1;
			if (num19 > 2500.0)
			{
				num18 += 60.0 * (double)(H + 50);
			}
			else if (num19 > 1250.0)
			{
				num18 += 30.0 * (double)(H + 50);
			}
			double num20 = (double)(H + 50) * (Math.PI * (double)r * (double)Angle / 180.0 + (double)k + (double)k1);
			switch (typVRVP)
			{
			case 6:
				num10 = 2.0 * (double)(B + H) * 40.0;
				break;
			case 7:
				num10 = 2.0 * (double)(B1 + H) * 40.0;
				break;
			}
			if (typVRVP == 5 || typVRVP == 12)
			{
				num10 += (double)((B + 80) * (H + 80));
			}
			if (typVRVP == 4 || typVRVP == 11)
			{
				num10 += (double)((B1 + 80) * (H + 80));
			}
			array[0, 0] = 2.0 * (((double)(B1 + r) * Math.Sin(Math.PI * (double)Angle / 180.0) + (double)B - (double)B1 + (double)k1) * (double)(B1 + r + k)) + (num18 + num20 + num10) * (1.0 + num4 / 100.0);
			num4 = Math.Round((array[0, 0] / (2.0 * num17 + num18 + num20 + num10) - 1.0) * 100.0);
			if (num4 > 20.0)
			{
				num4 = 20.0;
				array[0, 0] = (2.0 * num17 + num18 + num20 + num10) * (1.0 + num4 / 100.0);
			}
			array[0, 1] = num4 / 100.0;
		}
		array[0, 0] /= 1000000.0;
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
		materialCost = array[0, 0] * num11;
		if (typVRVP == 1 || typVRVP == 2 || typVRVP == 4 || typVRVP == 6)
		{
			num7 = 1;
		}
		if (typVRVP == 1 || typVRVP == 3 || typVRVP == 5 || typVRVP == 7)
		{
			num8 = 1;
		}
		if (num7 > 0 && typProfilB1 == 0)
		{
			num9 = ((B >= H) ? B : H);
			typProfilB1 = ((num9 < 800) ? 1 : 2);
		}
		if (num8 > 0 && typProfilB2 == 0)
		{
			num9 = ((B1 >= H) ? B1 : H);
			typProfilB2 = ((num9 < 800) ? 1 : 2);
		}
		double[,] array2 = new double[2, 6];
		int num21 = 1;
		if (typProfilB1 == 1 || typProfilB2 == 1)
		{
			if (typProfilB1 == 1)
			{
				array2 = FlanetsPrjamokutnyj.MaterialFlanetsPrjamokutnyj(B, H, typProfilB1, number, polkaBH, 1);
				materialCost += FlanetsPrjamokutnyj.materialCost1;
				for (int i = 0; i < 2; i++)
				{
					if (FlanetsPrjamokutnyj.materialName[i] != "")
					{
						materialName[num21 + i] = FlanetsPrjamokutnyj.materialName[i];
						for (int j = 0; j < 6; j++)
						{
							array[num21 + i, j] = ((j == 1) ? array2[i, j] : (array[num21 + i, j] + array2[i, j]));
						}
					}
				}
			}
			if (typProfilB2 == 1)
			{
				array2 = FlanetsPrjamokutnyj.MaterialFlanetsPrjamokutnyj(B1, H, typProfilB2, number, polkaB1H1, 1);
				materialCost += FlanetsPrjamokutnyj.materialCost1;
				for (int l = 0; l < 2; l++)
				{
					if (FlanetsPrjamokutnyj.materialName[l] != "")
					{
						materialName[num21 + l] = FlanetsPrjamokutnyj.materialName[l];
						for (int m = 0; m < 6; m++)
						{
							array[num21 + l, m] = ((m == 1) ? array2[l, m] : (array[num21 + l, m] + array2[l, m]));
						}
					}
				}
			}
			num21 += 2;
		}
		if (typProfilB1 == 2 || typProfilB2 == 2)
		{
			if (typProfilB1 == 2)
			{
				array2 = FlanetsPrjamokutnyj.MaterialFlanetsPrjamokutnyj(B, H, typProfilB1, number, polkaBH, 1);
				materialCost += FlanetsPrjamokutnyj.materialCost1;
				for (int n = 0; n < 2; n++)
				{
					if (FlanetsPrjamokutnyj.materialName[n] != "")
					{
						materialName[num21 + n] = FlanetsPrjamokutnyj.materialName[n];
						for (int num22 = 0; num22 < 6; num22++)
						{
							array[num21 + n, num22] = ((num22 == 1) ? array2[n, num22] : (array[num21 + n, num22] + array2[n, num22]));
						}
					}
				}
			}
			if (typProfilB2 == 2)
			{
				array2 = FlanetsPrjamokutnyj.MaterialFlanetsPrjamokutnyj(B1, H, typProfilB2, number, polkaB1H1, 1);
				materialCost += FlanetsPrjamokutnyj.materialCost1;
				for (int num23 = 0; num23 < 2; num23++)
				{
					if (FlanetsPrjamokutnyj.materialName[num23] != "")
					{
						materialName[num21 + num23] = FlanetsPrjamokutnyj.materialName[num23];
						for (int num24 = 0; num24 < 6; num24++)
						{
							array[num21 + num23, num24] = ((num24 == 1) ? array2[num23, num24] : (array[num21 + num23, num24] + array2[num23, num24]));
						}
					}
				}
			}
			num21 += 2;
		}
		if (typProfilB1 == 1 || typProfilB1 == 2)
		{
			double[,] array3 = new double[1, 6];
			array3 = HvyntNaFlanets.MaterialHvyntNaFlanets(B, H, 1, number);
			materialCost += HvyntNaFlanets.materialCost1;
			materialName[num21] = HvyntNaFlanets.materialName1[0];
			for (int num25 = 0; num25 < 6; num25++)
			{
				array[num21, num25] = array3[0, num25];
			}
		}
		if (typProfilB2 == 1 || typProfilB2 == 2)
		{
			double[,] array4 = new double[1, 6];
			array4 = HvyntNaFlanets.MaterialHvyntNaFlanets(B1, H, 1, number);
			materialCost += HvyntNaFlanets.materialCost1;
			materialName[num21] = HvyntNaFlanets.materialName1[0];
			for (int num26 = 0; num26 < 6; num26++)
			{
				array[num21, num26] += array4[0, num26];
			}
		}
		if (typProfilB1 == 1 || typProfilB2 == 1 || typProfilB1 == 2 || typProfilB2 == 2)
		{
			num21++;
		}
		if (typProfilB1 == 3 || typProfilB2 == 3)
		{
			if (typProfilB1 == 3)
			{
				array2 = FlanetsPrjamokutnyj.MaterialFlanetsPrjamokutnyj(B, H, typProfilB1, number, polkaBH, 1);
				materialCost += FlanetsPrjamokutnyj.materialCost1;
				if (FlanetsPrjamokutnyj.materialName[0] != "")
				{
					materialName[num21] = FlanetsPrjamokutnyj.materialName[0];
					for (int num27 = 0; num27 < 6; num27++)
					{
						array[num21, num27] = ((num27 == 1) ? array2[0, num27] : (array[num21, num27] + array2[0, num27]));
					}
				}
			}
			if (typProfilB2 == 3)
			{
				array2 = FlanetsPrjamokutnyj.MaterialFlanetsPrjamokutnyj(B1, H, typProfilB2, number, polkaB1H1, 1);
				materialCost += FlanetsPrjamokutnyj.materialCost1;
				if (FlanetsPrjamokutnyj.materialName[0] != "")
				{
					materialName[num21] = FlanetsPrjamokutnyj.materialName[0];
					for (int num28 = 0; num28 < 6; num28++)
					{
						array[num21, num28] = ((num28 == 1) ? array2[0, num28] : (array[num21, num28] + array2[0, num28]));
					}
				}
			}
			num21++;
		}
		if (typProfilB1 == 4 || typProfilB2 == 4)
		{
			if (typProfilB1 == 4)
			{
				array2 = FlanetsPrjamokutnyj.MaterialFlanetsPrjamokutnyj(B, H, typProfilB1, number, polkaBH, 1);
				materialCost += FlanetsPrjamokutnyj.materialCost1;
				if (FlanetsPrjamokutnyj.materialName[0] != "")
				{
					materialName[num21] = FlanetsPrjamokutnyj.materialName[0];
					for (int num29 = 0; num29 < 6; num29++)
					{
						array[num21, num29] = ((num29 == 1) ? array2[0, num29] : (array[num21, num29] + array2[0, num29]));
					}
				}
			}
			if (typProfilB2 == 4)
			{
				array2 = FlanetsPrjamokutnyj.MaterialFlanetsPrjamokutnyj(B1, H, typProfilB2, number, polkaB1H1, 1);
				materialCost += FlanetsPrjamokutnyj.materialCost1;
				if (FlanetsPrjamokutnyj.materialName[0] != "")
				{
					materialName[num21] = FlanetsPrjamokutnyj.materialName[0];
					for (int num30 = 0; num30 < 6; num30++)
					{
						array[num21, num30] = ((num30 == 1) ? array2[0, num30] : (array[num21, num30] + array2[0, num30]));
					}
				}
			}
			num21++;
		}
		if (typVRVP == 6 || typVRVP == 7)
		{
			materialName[num21] = Consts2.sitka25x25.MaterialName;
			array[num21, 0] = ((typVRVP == 6) ? ((double)(B + 40)) : ((double)(B1 + 40)));
			array[num21, 0] = array[num21, 0] * (double)(H + 40) * 1.15 / 1000000.0;
			if (array[num21, 0] < 0.005)
			{
				array[num21, 0] = Math.Round(1000.0 * array[num21, 0]) / 1000.0;
			}
			else
			{
				array[num21, 0] = Math.Round(100.0 * array[num21, 0]) / 100.0;
			}
			array[num21, 1] = 0.15;
			array[num21, 4] = array[num21, 0] * (double)number;
			array[num21, 2] = array[num21, 4] * array[num21, 1];
		}
		return array;
	}

	public static double PriceVidvidVRVP(int B, int B1, int H, int k, int k1, int r, int Angle, int markaStali, double tovchynaMetalu, int typVRVP)
	{
		double num = 1.0;
		int num2 = ((B >= H) ? B : H);
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
			num = ((typVRVP > 7) ? ((!(tovchynaMetalu < 0.65)) ? ((tovchynaMetalu < 0.9) ? 406.0 : 520.0) : 345.0) : ((!(tovchynaMetalu < 0.65)) ? ((tovchynaMetalu < 0.9) ? 464.0 : 600.0) : 402.5));
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
		if (B1 > B)
		{
			int num7 = B;
			B = B1;
			B1 = num7;
			num7 = k;
			k = k1;
			k1 = num7;
		}
		if (r == 0)
		{
			materialSpendingCommercialOffer = (k + k1) * H;
			materialSpendingCommercialOffer += 2.0 * (Math.PI * (double)B1 * (double)B1 * (double)Angle / 360.0 + (double)(B1 * (B - B1 + k1)) + (double)(B * k));
			materialSpendingCommercialOffer += (double)H * (Math.PI * (double)B1 * (double)Angle / 180.0 + (double)B - (double)B1 + (double)k + (double)k1);
		}
		else
		{
			materialSpendingCommercialOffer = (double)H * (Math.PI * (double)r * (double)Angle / 180.0 + (double)k + (double)k1);
			materialSpendingCommercialOffer += 2.0 * (Math.PI * (double)Angle * (double)B1 * (double)(B1 + 2 * r) / 360.0 + (double)((B - B1) * (B1 + r)) + (double)(B * k) + (double)(B1 * k1));
			materialSpendingCommercialOffer += (double)H * (Math.PI * (double)(B1 + r) * (double)Angle / 180.0 + (double)B - (double)B1 + (double)k + (double)k1);
		}
		if (typVRVP == 5 || typVRVP == 12)
		{
			materialSpendingCommercialOffer += B * H;
		}
		if (typVRVP == 4 || typVRVP == 11)
		{
			materialSpendingCommercialOffer += B1 * H;
		}
		materialSpendingCommercialOffer /= 1000000.0;
		double num8 = materialSpendingCommercialOffer * num;
		switch (typVRVP)
		{
		case 6:
			num8 += 1.8 * Consts2.sitka25x25.Price * (double)B * (double)H / 1000000.0;
			materialSpendingCommercialOffer += (double)B * (double)H / 1000000.0;
			break;
		case 7:
			num8 += 1.8 * Consts2.sitka25x25.Price * (double)B1 * (double)H / 1000000.0;
			materialSpendingCommercialOffer += (double)B1 * (double)H / 1000000.0;
			break;
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
		return num8;
	}

	public static double VolumeVidvidVRVP(int B, int B1, int H, int k, int k1, int r)
	{
		return Math.Round((double)H * (double)(B + r + k) * (double)(B1 + r + k1) / 1000000.0) / 1000.0;
	}
}
