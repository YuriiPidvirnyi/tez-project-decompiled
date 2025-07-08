using System;
using TEZ_Project.Common.Helpers;
using TEZ_Project;

namespace TEZ_Project.Common.Products;

public static class VidvidVRNP
{
	public static string[] materialName = new string[6] { "", "", "", "", "", "" };

	public static double materialCost;

	public static double materialSpendingCommercialOffer = 0.0;

	public static double tovchynaMetaluCommercialOffer = 0.0;

	public static double[,] MaterialVidvidVRNP(int B, int H, int H1, int k, int k1, int r, int Angle, int markaStali, double tovchynaMetalu, int typVRNP, int typProfilH1, int typProfilH2, int number, int polkaBH, int polkaB1H1, string aisiType = "430")
	{
		double[,] array = new double[6, 6];
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
		materialName = new string[6] { "", "", "", "", "", "" };
		materialCost = 0.0;
		if (H1 >= num9)
		{
			num9 = H1;
		}
		switch (markaStali)
		{
		case 1:
		{
			if (tovchynaMetalu == 0.0)
			{
				if (num9 <= 400)
				{
					tovchynaMetalu = 0.5;
					num4 = 5.0;
				}
				else if (num9 <= 800)
				{
					tovchynaMetalu = 0.7;
					num4 = 10.0;
				}
				else
				{
					tovchynaMetalu = 0.9;
					num4 = 10.0;
				}
			}
			num = 7825.0;
			double num11 = tovchynaMetalu;
			double num12 = num11;
			if (num12 != 0.5)
			{
				if (num12 != 0.65)
				{
					if (num12 != 0.68)
					{
						if (num12 != 0.7)
						{
							if (num12 != 0.9)
							{
								if (num12 != 1.0)
								{
									if (num12 == 1.2)
									{
										materialName[0] = Consts2.lystOchynkovanyj12.MaterialName;
										num10 = Consts2.lystOchynkovanyj12.Price;
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
									num10 = Consts2.lystOchynkovanyj10.Price;
									num4 = 10.0;
								}
							}
							else
							{
								materialName[0] = Consts2.lystOchynkovanyj09.MaterialName;
								num10 = Consts2.lystOchynkovanyj09.Price;
								num4 = 10.0;
							}
						}
						else
						{
							materialName[0] = Consts2.lystOchynkovanyj07.MaterialName;
							num10 = Consts2.lystOchynkovanyj07.Price;
							num4 = 10.0;
						}
					}
					else
					{
						materialName[0] = Consts2.lystOchynkovanyj068.MaterialName;
						num10 = Consts2.lystOchynkovanyj068.Price;
						num4 = 10.0;
					}
				}
				else
				{
					materialName[0] = Consts2.lystOchynkovanyj065.MaterialName;
					num10 = Consts2.lystOchynkovanyj065.Price;
					num4 = 10.0;
				}
			}
			else
			{
				materialName[0] = Consts2.lystOchynkovanyj05.MaterialName;
				num10 = Consts2.lystOchynkovanyj05.Price;
				num4 = 5.0;
			}
			break;
		}
		case 2:
		{
			if (tovchynaMetalu == 0.0)
			{
				if (num9 <= 400)
				{
					tovchynaMetalu = 0.5;
					num4 = 5.0;
				}
				else if (num9 <= 800)
				{
					tovchynaMetalu = 0.8;
					num4 = 10.0;
				}
				else
				{
					tovchynaMetalu = 1.0;
					num4 = 10.0;
				}
			}
			num = 7825.0;
			double num13 = tovchynaMetalu;
			double num14 = num13;
			if (num14 != 0.5)
			{
				if (num14 != 0.8)
				{
					if (num14 != 1.0)
					{
						if (num14 != 1.2)
						{
							if (num14 != 1.5)
							{
								if (num14 != 2.0)
								{
									if (num14 != 2.5)
									{
										if (num14 != 3.0)
										{
											if (num14 != 4.0)
											{
												if (num14 != 5.0)
												{
													if (num14 == 6.0)
													{
														materialName[0] = Consts2.lystStalnyj60.MaterialName;
														num10 = Consts2.lystStalnyj60.Price;
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
													num10 = Consts2.lystStalnyj50.Price;
													num4 = 10.0;
												}
											}
											else
											{
												materialName[0] = Consts2.lystStalnyj40.MaterialName;
												num10 = Consts2.lystStalnyj40.Price;
												num4 = 10.0;
											}
										}
										else
										{
											materialName[0] = Consts2.lystStalnyj30.MaterialName;
											num10 = Consts2.lystStalnyj30.Price;
											num4 = 10.0;
										}
									}
									else
									{
										materialName[0] = Consts2.lystStalnyj25.MaterialName;
										num10 = Consts2.lystStalnyj25.Price;
										num4 = 10.0;
									}
								}
								else
								{
									materialName[0] = Consts2.lystStalnyj20.MaterialName;
									num10 = Consts2.lystStalnyj20.Price;
									num4 = 10.0;
								}
							}
							else
							{
								materialName[0] = Consts2.lystStalnyj15.MaterialName;
								num10 = Consts2.lystStalnyj15.Price;
								num4 = 10.0;
							}
						}
						else
						{
							materialName[0] = Consts2.lystStalnyj12.MaterialName;
							num10 = Consts2.lystStalnyj12.Price;
							num4 = 10.0;
						}
					}
					else
					{
						materialName[0] = Consts2.lystStalnyj10.MaterialName;
						num10 = Consts2.lystStalnyj10.Price;
						num4 = 10.0;
					}
				}
				else
				{
					materialName[0] = Consts2.lystStalnyj08.MaterialName;
					num10 = Consts2.lystStalnyj08.Price;
					num4 = 10.0;
				}
			}
			else
			{
				materialName[0] = Consts2.lystStalnyj05.MaterialName;
				num10 = Consts2.lystStalnyj05.Price;
				num4 = 5.0;
			}
			break;
		}
		case 3:
		{
			if (tovchynaMetalu == 0.0)
			{
				if (num9 <= 400)
				{
					tovchynaMetalu = 0.5;
					num4 = 5.0;
				}
				else if (num9 <= 800)
				{
					tovchynaMetalu = 0.8;
					num4 = 10.0;
				}
				else
				{
					tovchynaMetalu = 1.0;
					num4 = 10.0;
				}
			}
			num = 7825.0;
			CustomConst lystNerzavijuchyj = MaterialHelper.GetLystNerzavijuchyj(tovchynaMetalu, aisiType);
			materialName[0] = lystNerzavijuchyj?.MaterialName ?? "Лист НЕРЖ ??, м2";
			num10 = lystNerzavijuchyj.Price;
			break;
		}
		}
		double num15 = Math.Sin(Math.PI * (double)Angle / 180.0);
		if (r == 0)
		{
			double num16 = (double)B + Math.Sqrt(Math.Pow(k, 2.0) + Math.Pow((H - H1) / 2, 2.0)) * num15 + 10.0;
			double num17 = (double)B + (double)k1 * num15 + 10.0;
			double num18 = num16 * num17 / num15;
			if (num16 > 2500.0)
			{
				num18 += 60.0 * num17 / num15;
			}
			else if (num16 > 1250.0)
			{
				num18 += 30.0 * num17 / num15;
			}
			if (num17 > 2500.0)
			{
				num18 += 60.0 * num16 / num15;
			}
			else if (num17 > 1250.0)
			{
				num18 += 30.0 * num16 / num15;
			}
			double num19 = ((H1 > H) ? H1 : H);
			num16 = (double)(k + k1) + Math.PI * (double)B * (double)Angle / 180.0;
			double num20 = num16 * (num19 + 50.0);
			if (num19 + 50.0 > 2500.0)
			{
				num20 += 60.0 * num16;
			}
			else if (num19 + 50.0 > 1250.0)
			{
				num20 += 30.0 * num16;
			}
			if (num16 > 2500.0)
			{
				num20 += 60.0 * (num19 + 50.0);
			}
			else if (num16 > 1250.0)
			{
				num20 += 30.0 * (num19 + 50.0);
			}
			double num21 = (num19 + 50.0) * (double)(k + k1);
			if (num19 + 50.0 > 2500.0)
			{
				num21 += 60.0 * (double)(k + k1);
			}
			else if (num19 + 50.0 > 1250.0)
			{
				num21 += 30.0 * (double)(k + k1);
			}
			if (k + k1 > 2500)
			{
				num21 += 60.0 * (num19 + 50.0);
			}
			else if (k + k1 > 1250)
			{
				num21 += 30.0 * (num19 + 50.0);
			}
			double num22 = ((typVRNP == 6 || typVRNP == 7) ? (2 * (B + H) * 40) : 0);
			if (typVRNP == 4 || typVRNP == 5 || typVRNP == 11 || typVRNP == 12)
			{
				num22 += (double)((B + 80) * (H + 80));
			}
			array[0, 0] = (2.0 * num18 + num20 + num21 + num22) * (1.0 + num4 / 100.0) / 1000000.0;
			num18 = 2.0 * (double)(B + 10) * (Math.PI * (double)B * (double)Angle / 360.0 + Math.Sqrt(Math.Pow(k, 2.0) + Math.Pow((H - H1) / 2, 2.0)) + (double)k1);
			num18 += (double)(k * (H + H1 + 100)) + 2.0 * (double)k1 * (double)(H1 + 50) + Math.PI * (double)B * (double)Angle * (double)(H1 + 50) / 180.0 + num22;
			num18 /= 1000000.0;
			num4 = Math.Round((array[0, 0] / num18 - 1.0) * 100.0);
			if (num4 > 20.0)
			{
				num4 = 20.0;
				array[0, 0] = num18 * (1.0 + num4 / 100.0);
			}
			array[0, 1] = num4 / 100.0;
		}
		else
		{
			double num23 = (double)(B + r) + Math.Sqrt(Math.Pow(k, 2.0) + Math.Pow((H - H1) / 2, 2.0)) * num15 + 10.0;
			double num24 = (double)(B + r) + (double)k1 * num15 + 10.0;
			double num18 = num23 * num24 / num15;
			if (num23 > 2500.0)
			{
				num18 += 60.0 * num24 / num15;
			}
			else if (num23 > 1250.0)
			{
				num18 += 30.0 * num24 / num15;
			}
			if (num24 > 2500.0)
			{
				num18 += 60.0 * num23 / num15;
			}
			else if (num24 > 1250.0)
			{
				num18 += 30.0 * num23 / num15;
			}
			double num25 = ((H1 > H) ? H1 : H);
			num23 = (double)(k + k1) + Math.PI * (double)(B + r) * (double)Angle / 180.0;
			double num20 = num23 * (num25 + 50.0);
			if (num25 + 50.0 > 2500.0)
			{
				num20 += 60.0 * num23;
			}
			else if (num25 + 50.0 > 1250.0)
			{
				num20 += 30.0 * num23;
			}
			if (num23 > 2500.0)
			{
				num20 += 60.0 * (num25 + 50.0);
			}
			else if (num23 > 1250.0)
			{
				num20 += 30.0 * (num25 + 50.0);
			}
			num23 = (double)(k + k1) + Math.PI * (double)r * (double)Angle / 180.0;
			double num21 = (num25 + 50.0) * num23;
			if (num25 + 50.0 > 2500.0)
			{
				num21 += 60.0 * num23;
			}
			else if (num25 + 50.0 > 1250.0)
			{
				num21 += 30.0 * num23;
			}
			if (num23 > 2500.0)
			{
				num21 += 60.0 * (num25 + 50.0);
			}
			else if (num23 > 1250.0)
			{
				num21 += 30.0 * (num25 + 50.0);
			}
			double num26 = ((typVRNP == 6 || typVRNP == 7) ? (2 * (B + H) * 40) : 0);
			if (typVRNP == 4 || typVRNP == 5 || typVRNP == 11 || typVRNP == 12)
			{
				num26 += (double)((B + 80) * (H + 80));
			}
			array[0, 0] = (2.0 * num18 + num20 + num21 + num26) * (1.0 + num4 / 100.0) / 1000000.0;
			num18 = 2.0 * (Math.PI * (double)Angle * (Math.Pow(B + 10 + r, 2.0) - Math.Pow(r, 2.0)) / 360.0 + (double)(B + 10) * (Math.Sqrt(Math.Pow(k, 2.0) + Math.Pow((H - H1) / 2, 2.0)) + (double)k1));
			num18 += (double)(k * (H + H1 + 100)) + 2.0 * (double)k1 * (double)(H1 + 50) + Math.PI * (double)(B + 2 * r) * (double)Angle * (double)(H1 + 50) / 180.0;
			num18 /= 1000000.0;
			num4 = Math.Round((array[0, 0] / num18 - 1.0) * 100.0);
			if (num4 > 20.0)
			{
				num4 = 20.0;
				array[0, 0] = num18 * (1.0 + num4 / 100.0);
			}
			array[0, 1] = num4 / 100.0;
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
		materialCost = array[0, 0] * num10;
		if (typVRNP == 1 || typVRNP == 2 || typVRNP == 4 || typVRNP == 6)
		{
			num7 = 1;
		}
		if (typVRNP == 1 || typVRNP == 3 || typVRNP == 5 || typVRNP == 7)
		{
			num8 = 1;
		}
		if (num7 > 0 && typProfilH1 == 0)
		{
			num9 = ((B >= H) ? B : H);
			typProfilH1 = ((num9 < 800) ? 1 : 2);
		}
		if (num8 > 0 && typProfilH2 == 0)
		{
			num9 = ((B >= H1) ? B : H1);
			typProfilH2 = ((num9 < 800) ? 1 : 2);
		}
		double[,] array2 = new double[2, 6];
		int num27 = 1;
		if (typProfilH1 == 1 || typProfilH2 == 1)
		{
			if (typProfilH1 == 1)
			{
				array2 = FlanetsPrjamokutnyj.MaterialFlanetsPrjamokutnyj(B, H, typProfilH1, number, polkaBH, 1);
				materialCost += FlanetsPrjamokutnyj.materialCost1;
				for (int i = 0; i < 2; i++)
				{
					if (FlanetsPrjamokutnyj.materialName[i] != "")
					{
						materialName[num27 + i] = FlanetsPrjamokutnyj.materialName[i];
						for (int j = 0; j < 6; j++)
						{
							array[num27 + i, j] = ((j == 1) ? array2[i, j] : (array[num27 + i, j] + array2[i, j]));
						}
					}
				}
			}
			if (typProfilH2 == 1)
			{
				array2 = FlanetsPrjamokutnyj.MaterialFlanetsPrjamokutnyj(B, H1, typProfilH2, number, polkaB1H1, 1);
				materialCost += FlanetsPrjamokutnyj.materialCost1;
				for (int l = 0; l < 2; l++)
				{
					if (FlanetsPrjamokutnyj.materialName[l] != "")
					{
						materialName[num27 + l] = FlanetsPrjamokutnyj.materialName[l];
						for (int m = 0; m < 6; m++)
						{
							array[num27 + l, m] = ((m == 1) ? array2[l, m] : (array[num27 + l, m] + array2[l, m]));
						}
					}
				}
			}
			num27 += 2;
		}
		if (typProfilH1 == 2 || typProfilH2 == 2)
		{
			if (typProfilH1 == 2)
			{
				array2 = FlanetsPrjamokutnyj.MaterialFlanetsPrjamokutnyj(B, H, typProfilH1, number, polkaBH, 1);
				materialCost += FlanetsPrjamokutnyj.materialCost1;
				for (int n = 0; n < 2; n++)
				{
					if (FlanetsPrjamokutnyj.materialName[n] != "")
					{
						materialName[num27 + n] = FlanetsPrjamokutnyj.materialName[n];
						for (int num28 = 0; num28 < 6; num28++)
						{
							array[num27 + n, num28] = ((num28 == 1) ? array2[n, num28] : (array[num27 + n, num28] + array2[n, num28]));
						}
					}
				}
			}
			if (typProfilH2 == 2)
			{
				array2 = FlanetsPrjamokutnyj.MaterialFlanetsPrjamokutnyj(B, H1, typProfilH2, number, polkaB1H1, 1);
				materialCost += FlanetsPrjamokutnyj.materialCost1;
				for (int num29 = 0; num29 < 2; num29++)
				{
					if (FlanetsPrjamokutnyj.materialName[num29] != "")
					{
						materialName[num27 + num29] = FlanetsPrjamokutnyj.materialName[num29];
						for (int num30 = 0; num30 < 6; num30++)
						{
							array[num27 + num29, num30] = ((num30 == 1) ? array2[num29, num30] : (array[num27 + num29, num30] + array2[num29, num30]));
						}
					}
				}
			}
			num27 += 2;
		}
		if (typProfilH1 == 1 || typProfilH1 == 2)
		{
			double[,] array3 = new double[1, 6];
			array3 = HvyntNaFlanets.MaterialHvyntNaFlanets(B, H, 1, number);
			materialCost += HvyntNaFlanets.materialCost1;
			materialName[num27] = HvyntNaFlanets.materialName1[0];
			for (int num31 = 0; num31 < 6; num31++)
			{
				array[num27, num31] = array3[0, num31];
			}
		}
		if (typProfilH2 == 1 || typProfilH2 == 2)
		{
			double[,] array4 = new double[1, 6];
			array4 = HvyntNaFlanets.MaterialHvyntNaFlanets(B, H1, 1, number);
			materialCost += HvyntNaFlanets.materialCost1;
			materialName[num27] = HvyntNaFlanets.materialName1[0];
			for (int num32 = 0; num32 < 6; num32++)
			{
				array[num27, num32] += array4[0, num32];
			}
		}
		if (typProfilH1 == 1 || typProfilH2 == 1 || typProfilH1 == 2 || typProfilH2 == 2)
		{
			num27++;
		}
		if (typProfilH1 == 3 || typProfilH2 == 3)
		{
			if (typProfilH1 == 3)
			{
				array2 = FlanetsPrjamokutnyj.MaterialFlanetsPrjamokutnyj(B, H, typProfilH1, number, polkaBH, 1);
				materialCost += FlanetsPrjamokutnyj.materialCost1;
				if (FlanetsPrjamokutnyj.materialName[0] != "")
				{
					materialName[num27] = FlanetsPrjamokutnyj.materialName[0];
					for (int num33 = 0; num33 < 6; num33++)
					{
						array[num27, num33] = ((num33 == 1) ? array2[0, num33] : (array[num27, num33] + array2[0, num33]));
					}
				}
			}
			if (typProfilH2 == 3)
			{
				array2 = FlanetsPrjamokutnyj.MaterialFlanetsPrjamokutnyj(B, H1, typProfilH2, number, polkaB1H1, 1);
				materialCost += FlanetsPrjamokutnyj.materialCost1;
				if (FlanetsPrjamokutnyj.materialName[0] != "")
				{
					materialName[num27] = FlanetsPrjamokutnyj.materialName[0];
					for (int num34 = 0; num34 < 6; num34++)
					{
						array[num27, num34] = ((num34 == 1) ? array2[0, num34] : (array[num27, num34] + array2[0, num34]));
					}
				}
			}
			num27++;
		}
		if (typProfilH1 == 4 || typProfilH2 == 4)
		{
			if (typProfilH1 == 4)
			{
				array2 = FlanetsPrjamokutnyj.MaterialFlanetsPrjamokutnyj(B, H, typProfilH1, number, polkaBH, 1);
				materialCost += FlanetsPrjamokutnyj.materialCost1;
				if (FlanetsPrjamokutnyj.materialName[0] != "")
				{
					materialName[num27] = FlanetsPrjamokutnyj.materialName[0];
					for (int num35 = 0; num35 < 6; num35++)
					{
						array[num27, num35] = ((num35 == 1) ? array2[0, num35] : (array[num27, num35] + array2[0, num35]));
					}
				}
			}
			if (typProfilH2 == 4)
			{
				array2 = FlanetsPrjamokutnyj.MaterialFlanetsPrjamokutnyj(B, H1, typProfilH2, number, polkaB1H1, 1);
				materialCost += FlanetsPrjamokutnyj.materialCost1;
				if (FlanetsPrjamokutnyj.materialName[0] != "")
				{
					materialName[num27] = FlanetsPrjamokutnyj.materialName[0];
					for (int num36 = 0; num36 < 6; num36++)
					{
						array[num27, num36] = ((num36 == 1) ? array2[0, num36] : (array[num27, num36] + array2[0, num36]));
					}
				}
			}
			num27++;
		}
		if (typVRNP == 6 || typVRNP == 7)
		{
			materialName[num27] = Consts2.sitka25x25.MaterialName;
			array[num27, 0] = ((typVRNP == 6) ? ((double)(H + 40)) : ((double)(H1 + 40)));
			array[num27, 0] = array[num27, 0] * (double)(B + 40) * 1.15 / 1000000.0;
			if (array[num27, 0] < 0.005)
			{
				array[num27, 0] = Math.Round(1000.0 * array[num27, 0]) / 1000.0;
			}
			else
			{
				array[num27, 0] = Math.Round(100.0 * array[num27, 0]) / 100.0;
			}
			array[num27, 1] = 0.15;
			array[num27, 4] = array[num27, 0] * (double)number;
			array[num27, 2] = array[num27, 4] * array[num27, 1];
		}
		return array;
	}

	public static double PriceVidvidVRNP(int B, int H, int H1, int k, int k1, int r, int Angle, int markaStali, double tovchynaMetalu, int typVRNP)
	{
		double num = 1.0;
		int num2 = ((B >= H) ? B : H);
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
			num = ((typVRNP > 3) ? ((!(tovchynaMetalu < 0.65)) ? ((tovchynaMetalu < 0.9) ? 406.0 : 520.0) : 345.0) : ((!(tovchynaMetalu < 0.65)) ? ((tovchynaMetalu < 0.9) ? 464.0 : 600.0) : 402.5));
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
			materialSpendingCommercialOffer = 2.0 * (double)B * (Math.PI * (double)B * (double)Angle / 360.0 + Math.Sqrt(Math.Pow(k, 2.0) + Math.Pow((H - H1) / 2, 2.0)) + (double)k1);
			materialSpendingCommercialOffer += (double)(k * (H + H1)) + 2.0 * (double)k1 * (double)H1 + Math.PI * (double)B * (double)Angle * (double)H1 / 180.0;
			materialSpendingCommercialOffer /= 1000000.0;
		}
		else
		{
			materialSpendingCommercialOffer = 2.0 * (Math.PI * (double)Angle * (Math.Pow(B + r, 2.0) - Math.Pow(r, 2.0)) / 360.0 + (double)B * (Math.Sqrt(Math.Pow(k, 2.0) + Math.Pow((H - H1) / 2, 2.0)) + (double)k1));
			materialSpendingCommercialOffer += (double)(k * (H + H1)) + 2.0 * (double)k1 * (double)H1 + Math.PI * (double)(B + 2 * r) * (double)Angle * (double)H1 / 180.0;
			materialSpendingCommercialOffer /= 1000000.0;
		}
		if (typVRNP == 5 || typVRNP == 12)
		{
			materialSpendingCommercialOffer += (double)B * (double)H / 1000000.0;
		}
		if (typVRNP == 4 || typVRNP == 11)
		{
			materialSpendingCommercialOffer += (double)B * (double)H1 / 1000000.0;
		}
		double num7 = materialSpendingCommercialOffer * num;
		switch (typVRNP)
		{
		case 6:
			num7 += 1.8 * Consts2.sitka25x25.Price * (double)B * (double)H1 / 1000000.0;
			break;
		case 7:
			num7 += 1.8 * Consts2.sitka25x25.Price * (double)B * (double)H / 1000000.0;
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
		return num7;
	}

	public static double VolumeVidvidVRNP(int B, int H, int H1, int k, int k1, int r)
	{
		int num = ((H > H1) ? H : H1);
		return Math.Round((double)num * (double)(B + r + k) * (double)(B + r + k1) / 1000000.0) / 1000.0;
	}
}
