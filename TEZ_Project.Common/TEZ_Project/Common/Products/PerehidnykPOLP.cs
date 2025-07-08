using System;
using TEZ_Project.Common.Helpers;

using TEZ_Project.Common.Data;
using TEZ_Project;

namespace TEZ_Project.Common.Products;

public static class PerehidnykPOLP
{
	public static string[] materialName = new string[7] { "", "", "", "", "", "", "" };

	public static double materialCost;

	public static double materialSpendingCommercialOffer = 0.0;

	public static double tovchynaMetaluCommercialOffer = 0.0;

	public static double[,] MaterialPerehidnykPOLP(int B, int H, int B1, int H1, int L, int k, int k1, int markaStali, double tovchynaMetalu, int typPOLP, int typProfilB1H1, int typProfilB2H2, int number, int polkaB1H1, int polkaB2H2, int vidbortovka, string aisiType = "430")
	{
		double[,] array = new double[7, 6];
		double num = 0.0;
		double num2 = 0.0;
		int num3 = ((B >= H) ? B : H);
		double num4 = 0.0;
		L += vidbortovka;
		materialName = new string[7] { "", "", "", "", "", "", "" };
		materialCost = 0.0;
		if (B1 >= num3)
		{
			num3 = B1;
		}
		if (H1 >= num3)
		{
			num3 = H1;
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
		L = L - k - k1;
		double num9 = L + k + k1;
		num3 = ((B > B1) ? B : B1);
		num3 += 10;
		double num10 = (double)num3 * num9;
		if (num3 > 2500)
		{
			num10 += 60.0 * num9;
		}
		else if (num3 > 1250)
		{
			num10 += 30.0 * num9;
		}
		if (num9 > 2500.0)
		{
			num10 += 60.0 * (double)num3;
		}
		else if (num9 > 1250.0)
		{
			num10 += 30.0 * (double)num3;
		}
		num9 = Math.Sqrt((double)L * (double)L + (double)((H1 - H) * (H1 - H))) + (double)k + (double)k1;
		double num11 = (double)num3 * num9;
		if (num3 > 2500)
		{
			num11 += 60.0 * num9;
		}
		else if (num3 > 1250)
		{
			num11 += 30.0 * num9;
		}
		if (num9 > 2500.0)
		{
			num11 += 60.0 * (double)num3;
		}
		else if (num9 > 1250.0)
		{
			num11 += 30.0 * (double)num3;
		}
		num9 = L + k + k1;
		num3 = ((H > H1) ? H : H1);
		num3 += 50;
		double num12 = (double)num3 * num9;
		if (num3 > 2500)
		{
			num12 += 60.0 * num9;
		}
		else if (num3 > 1250)
		{
			num12 += 30.0 * num9;
		}
		if (num9 > 2500.0)
		{
			num12 += 60.0 * (double)num3;
		}
		else if (num9 > 1250.0)
		{
			num12 += 30.0 * (double)num3;
		}
		num9 = Math.Sqrt((double)L * (double)L + (double)((B1 - B) * (B1 - B))) + (double)k + (double)k1;
		double num13 = (double)num3 * num9;
		if (num3 > 2500)
		{
			num13 += 60.0 * num9;
		}
		else if (num3 > 1250)
		{
			num13 += 30.0 * num9;
		}
		if (num9 > 2500.0)
		{
			num13 += 60.0 * (double)num3;
		}
		else if (num9 > 1250.0)
		{
			num13 += 30.0 * (double)num3;
		}
		array[0, 0] = (num10 + num12 + num11 + num13) * (1.0 + num2 / 100.0) / 1000000.0;
		num10 = (double)(B + B1 + 20) * (double)L / 2.0 + (double)((B + 10) * k) + (double)((B1 + 10) * k1);
		num10 += (double)(H + H1 + 100) * (double)L / 2.0 + (double)((H + 50) * k) + (double)((H1 + 50) * k1);
		num10 += (double)(B + B1 + 20) * Math.Sqrt((double)L * (double)L + (double)((H1 - H) * (H1 - H))) / 2.0 + (double)((B + 10) * k) + (double)((B1 + 10) * k1);
		num10 += (double)(H + H1 + 100) * Math.Sqrt((double)L * (double)L + (double)((B1 - B) * (B1 - B))) / 2.0 + (double)((H + 50) * k) + (double)((H1 + 50) * k1);
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
		if ((typPOLP == 1 || typPOLP == 2) && typProfilB1H1 == 0)
		{
			num3 = ((B >= H) ? B : H);
			typProfilB1H1 = ((num3 < 800) ? 1 : 2);
		}
		if ((typPOLP == 1 || typPOLP == 3) && typProfilB2H2 == 0)
		{
			num3 = ((B1 >= H1) ? B1 : H1);
			typProfilB2H2 = ((num3 < 800) ? 1 : 2);
		}
		double[,] array2 = new double[2, 6];
		int num14 = 1;
		if (typProfilB1H1 == 1 || typProfilB2H2 == 1)
		{
			if (typProfilB1H1 == 1)
			{
				array2 = FlanetsPrjamokutnyj.MaterialFlanetsPrjamokutnyj(B, H, typProfilB1H1, number, polkaB1H1, 1);
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
			if (typProfilB2H2 == 1)
			{
				array2 = FlanetsPrjamokutnyj.MaterialFlanetsPrjamokutnyj(B1, H1, typProfilB2H2, number, polkaB2H2, 1);
				materialCost += FlanetsPrjamokutnyj.materialCost1;
				for (int l = 0; l < 2; l++)
				{
					if (FlanetsPrjamokutnyj.materialName[l] != "")
					{
						materialName[num14 + l] = FlanetsPrjamokutnyj.materialName[l];
						for (int m = 0; m < 6; m++)
						{
							array[num14 + l, m] = ((m == 1) ? array2[l, m] : (array[num14 + l, m] + array2[l, m]));
						}
					}
				}
			}
			num14 += 2;
		}
		if (typProfilB1H1 == 2 || typProfilB2H2 == 2)
		{
			if (typProfilB1H1 == 2)
			{
				array2 = FlanetsPrjamokutnyj.MaterialFlanetsPrjamokutnyj(B, H, typProfilB1H1, number, polkaB1H1, 1);
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
			if (typProfilB2H2 == 2)
			{
				array2 = FlanetsPrjamokutnyj.MaterialFlanetsPrjamokutnyj(B1, H1, typProfilB2H2, number, polkaB2H2, 1);
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
			num14 += 2;
		}
		if (typProfilB1H1 == 1 || typProfilB1H1 == 2)
		{
			double[,] array3 = new double[1, 6];
			array3 = HvyntNaFlanets.MaterialHvyntNaFlanets(B, H, 1, number);
			materialCost += HvyntNaFlanets.materialCost1;
			materialName[num14] = HvyntNaFlanets.materialName1[0];
			for (int num18 = 0; num18 < 6; num18++)
			{
				array[num14, num18] = array3[0, num18];
			}
		}
		if (typProfilB2H2 == 1 || typProfilB2H2 == 2)
		{
			double[,] array4 = new double[1, 6];
			array4 = HvyntNaFlanets.MaterialHvyntNaFlanets(B1, H1, 1, number);
			materialCost += HvyntNaFlanets.materialCost1;
			materialName[num14] = HvyntNaFlanets.materialName1[0];
			for (int num19 = 0; num19 < 6; num19++)
			{
				array[num14, num19] += array4[0, num19];
			}
		}
		if (typProfilB1H1 == 1 || typProfilB2H2 == 1 || typProfilB1H1 == 2 || typProfilB2H2 == 2)
		{
			num14++;
		}
		if (typProfilB1H1 == 3 || typProfilB2H2 == 3)
		{
			if (typProfilB1H1 == 3)
			{
				array2 = FlanetsPrjamokutnyj.MaterialFlanetsPrjamokutnyj(B, H, typProfilB1H1, number, polkaB1H1, 1);
				materialCost += FlanetsPrjamokutnyj.materialCost1;
				if (FlanetsPrjamokutnyj.materialName[0] != "")
				{
					materialName[num14] = FlanetsPrjamokutnyj.materialName[0];
					for (int num20 = 0; num20 < 6; num20++)
					{
						array[num14, num20] = ((num20 == 1) ? array2[0, num20] : (array[num14, num20] + array2[0, num20]));
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
					for (int num21 = 0; num21 < 6; num21++)
					{
						array[num14, num21] = ((num21 == 1) ? array2[0, num21] : (array[num14, num21] + array2[0, num21]));
					}
				}
			}
			num14++;
		}
		if (typProfilB1H1 == 4 || typProfilB2H2 == 4)
		{
			if (typProfilB1H1 == 4)
			{
				array2 = FlanetsPrjamokutnyj.MaterialFlanetsPrjamokutnyj(B, H, typProfilB1H1, number, polkaB1H1, 1);
				materialCost += FlanetsPrjamokutnyj.materialCost1;
				if (FlanetsPrjamokutnyj.materialName[0] != "")
				{
					materialName[num14] = FlanetsPrjamokutnyj.materialName[0];
					for (int num22 = 0; num22 < 6; num22++)
					{
						array[num14, num22] = ((num22 == 1) ? array2[0, num22] : (array[num14, num22] + array2[0, num22]));
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
					for (int num23 = 0; num23 < 6; num23++)
					{
						array[num14, num23] = ((num23 == 1) ? array2[0, num23] : (array[num14, num23] + array2[0, num23]));
					}
				}
			}
		}
		return array;
	}

	public static double PricePerehidnykPOLP(int B, int H, int B1, int H1, int L, int k, int k1, int markaStali, double tovchynaMetalu, int typPOLP, int vidbortovka)
	{
		double num = 1.0;
		int num2 = ((B >= H) ? B : H);
		L += vidbortovka;
		if (B1 > num2)
		{
			num2 = B1;
		}
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
			num = ((typPOLP > 3) ? ((!(tovchynaMetalu < 0.65)) ? ((tovchynaMetalu < 0.9) ? 406.0 : 520.0) : 345.0) : ((!(tovchynaMetalu < 0.65)) ? ((tovchynaMetalu < 0.9) ? 464.0 : 600.0) : 402.5));
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
		L = L - k - k1;
		materialSpendingCommercialOffer = (double)(B + B1) * (double)L / 2.0 + (double)(B * k) + (double)(B1 * k1);
		materialSpendingCommercialOffer += (double)(H + H1) * (double)L / 2.0 + (double)(H * k) + (double)(H1 * k1);
		materialSpendingCommercialOffer += (double)(B + B1) * Math.Sqrt((double)L * (double)L + (double)((H1 - H) * (H1 - H))) / 2.0 + (double)(B * k) + (double)(B1 * k1);
		materialSpendingCommercialOffer += (double)(H + H1) * Math.Sqrt((double)L * (double)L + (double)((B1 - B) * (B1 - B))) / 2.0 + (double)(H * k) + (double)(H1 * k1);
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

	public static double VolumePerehidnykPOLP(int B, int H, int B1, int H1, int L, int k, int k1)
	{
		int num = ((B > B1) ? B : B1);
		int num2 = ((H > H1) ? H : H1);
		int num3 = L + k + k1;
		return Math.Round((double)num * (double)num2 * (double)num3 / 1000000.0) / 1000.0;
	}
}
