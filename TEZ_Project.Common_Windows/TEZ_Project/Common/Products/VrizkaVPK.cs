using System;
using TEZ_Project.Common.Helpers;

namespace TEZ_Project.Common.Products;

public static class VrizkaVPK
{
	public static string[] materialName = new string[16]
	{
		"", "", "", "", "", "", "", "", "", "",
		"", "", "", "", "", ""
	};

	public static double materialCost;

	public static double materialSpendingCommercialOffer = 0.0;

	public static double tovchynaMetaluCommercialOffer = 0.0;

	public static double[,] MaterialVrizkaVPK(int B, int H, int L, int D, int l, double alpha, int markaStali, double tovchynaMetalu, int typVPKenter, int typVPKout, int typVPKvrizka, int typProfilB1H1, int typProfilB2H2, int typMaterialD, int number, int polkaBH, int polkaB1H1, int vidbortovka, string aisiType = "430")
	{
		double[,] array = new double[16, 6];
		double num = 0.0;
		double num2 = 0.0;
		int num3 = ((B >= H) ? B : H);
		double num4 = 2.0 * (double)(B + H);
		double num5 = 0.0;
		L += vidbortovka;
		materialName = new string[16]
		{
			"", "", "", "", "", "", "", "", "", "",
			"", "", "", "", "", ""
		};
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
			num = 7825.0;
			num2 = MaterialHelper.GetMaterialWithdrawalNerzavijka(tovchynaMetalu);
			CustomConst lystNerzavijuchyj = MaterialHelper.GetLystNerzavijuchyj(tovchynaMetalu, aisiType);
			materialName[0] = lystNerzavijuchyj?.MaterialName ?? "Лист НЕРЖ ??, м2";
			num5 = lystNerzavijuchyj.Price;
			break;
		}
		}
		double num10 = num4 + 30.0;
		double num11 = num10 * (double)L;
		if (num10 > 2500.0)
		{
			num11 += 60.0 * (double)L;
		}
		else if (num10 > 1250.0)
		{
			num11 += 30.0 * (double)L;
		}
		if (L > 2500)
		{
			num11 += 60.0 * num10;
		}
		else if (L > 1250)
		{
			num11 += 30.0 * num10;
		}
		if (alpha > 90.0)
		{
			alpha = 180.0 - alpha;
		}
		alpha = Math.PI * alpha / 180.0;
		num10 = l;
		if (alpha != Math.PI / 2.0)
		{
			num10 += (double)D / Math.Tan(alpha);
		}
		double num12 = (Math.PI * (double)D + 30.0) * num10;
		if (Math.PI * (double)D + 30.0 > 1250.0)
		{
			num12 += 30.0 * num10;
		}
		array[0, 0] = (num11 + num12) * (1.0 + num2 / 100.0) / 1000000.0;
		num11 = (num4 + 30.0) * (double)L - Math.PI * (double)D * (double)D / (4.0 * Math.Sin(alpha));
		num10 = l;
		if (alpha != Math.PI / 2.0)
		{
			num10 += (double)D / (2.0 * Math.Tan(alpha));
		}
		num11 += (Math.PI * (double)D + 30.0) * num10;
		num11 /= 1000000.0;
		num2 = Math.Round((array[0, 0] / num11 - 1.0) * 100.0);
		if (num2 > 20.0)
		{
			num2 = 20.0;
			array[0, 0] = num11 * (1.0 + num2 / 100.0);
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
		if (typVPKenter == 1 || typVPKout == 1 || typVPKvrizka == 1)
		{
			int num13 = 0;
			if (typVPKenter == 1 && typProfilB1H1 == 0)
			{
				num3 = ((B >= H) ? B : H);
				typProfilB1H1 = ((num3 < 800) ? 1 : 2);
			}
			if (typVPKout == 1 && typProfilB2H2 == 0)
			{
				num3 = ((B >= H) ? B : H);
				typProfilB2H2 = ((num3 < 800) ? 1 : 2);
			}
			double[,] array2 = new double[2, 6];
			num13 = 1;
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
							materialName[num13 + i] = FlanetsPrjamokutnyj.materialName[i];
							for (int j = 0; j < 6; j++)
							{
								array[num13 + i, j] = ((j == 1) ? array2[i, j] : (array[num13 + i, j] + array2[i, j]));
							}
						}
					}
				}
				if (typProfilB2H2 == 1)
				{
					array2 = FlanetsPrjamokutnyj.MaterialFlanetsPrjamokutnyj(B, H, typProfilB2H2, number, polkaB1H1, 1);
					materialCost += FlanetsPrjamokutnyj.materialCost1;
					for (int k = 0; k < 2; k++)
					{
						if (FlanetsPrjamokutnyj.materialName[k] != "")
						{
							materialName[num13 + k] = FlanetsPrjamokutnyj.materialName[k];
							for (int m = 0; m < 6; m++)
							{
								array[num13 + k, m] = ((m == 1) ? array2[k, m] : (array[num13 + k, m] + array2[k, m]));
							}
						}
					}
				}
				num13 += 2;
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
							materialName[num13 + n] = FlanetsPrjamokutnyj.materialName[n];
							for (int num14 = 0; num14 < 6; num14++)
							{
								array[num13 + n, num14] = ((num14 == 1) ? array2[n, num14] : (array[num13 + n, num14] + array2[n, num14]));
							}
						}
					}
				}
				if (typProfilB2H2 == 2)
				{
					array2 = FlanetsPrjamokutnyj.MaterialFlanetsPrjamokutnyj(B, H, typProfilB2H2, number, polkaB1H1, 1);
					materialCost += FlanetsPrjamokutnyj.materialCost1;
					for (int num15 = 0; num15 < 2; num15++)
					{
						if (FlanetsPrjamokutnyj.materialName[num15] != "")
						{
							materialName[num13 + num15] = FlanetsPrjamokutnyj.materialName[num15];
							for (int num16 = 0; num16 < 6; num16++)
							{
								array[num13 + num15, num16] = ((num16 == 1) ? array2[num15, num16] : (array[num13 + num15, num16] + array2[num15, num16]));
							}
						}
					}
				}
				num13 += 2;
			}
			if (typProfilB1H1 == 1 || typProfilB1H1 == 2)
			{
				double[,] array3 = new double[1, 6];
				array3 = HvyntNaFlanets.MaterialHvyntNaFlanets(B, H, 1, number);
				materialCost += HvyntNaFlanets.materialCost1;
				materialName[num13] = HvyntNaFlanets.materialName1[0];
				for (int num17 = 0; num17 < 6; num17++)
				{
					array[num13, num17] = array3[0, num17];
				}
			}
			if (typProfilB2H2 == 1 || typProfilB2H2 == 2)
			{
				double[,] array4 = new double[1, 6];
				array4 = HvyntNaFlanets.MaterialHvyntNaFlanets(B, H, 1, number);
				materialCost += HvyntNaFlanets.materialCost1;
				materialName[num13] = HvyntNaFlanets.materialName1[0];
				for (int num18 = 0; num18 < 6; num18++)
				{
					array[num13, num18] += array4[0, num18];
				}
			}
			if (typProfilB1H1 == 1 || typProfilB2H2 == 1 || typProfilB1H1 == 2 || typProfilB2H2 == 2)
			{
				num13++;
			}
			if (typProfilB1H1 == 3 || typProfilB2H2 == 3)
			{
				if (typProfilB1H1 == 3)
				{
					array2 = FlanetsPrjamokutnyj.MaterialFlanetsPrjamokutnyj(B, H, typProfilB1H1, number, polkaBH, 1);
					materialCost += FlanetsPrjamokutnyj.materialCost1;
					if (FlanetsPrjamokutnyj.materialName[0] != "")
					{
						materialName[num13] = FlanetsPrjamokutnyj.materialName[0];
						for (int num19 = 0; num19 < 6; num19++)
						{
							array[num13, num19] = ((num19 == 1) ? array2[0, num19] : (array[num13, num19] + array2[0, num19]));
						}
					}
				}
				if (typProfilB2H2 == 3)
				{
					array2 = FlanetsPrjamokutnyj.MaterialFlanetsPrjamokutnyj(B, H, typProfilB2H2, number, polkaB1H1, 1);
					materialCost += FlanetsPrjamokutnyj.materialCost1;
					if (FlanetsPrjamokutnyj.materialName[0] != "")
					{
						materialName[num13] = FlanetsPrjamokutnyj.materialName[0];
						for (int num20 = 0; num20 < 6; num20++)
						{
							array[num13, num20] = ((num20 == 1) ? array2[0, num20] : (array[num13, num20] + array2[0, num20]));
						}
					}
				}
				num13++;
			}
			if (typProfilB1H1 == 4 || typProfilB2H2 == 4)
			{
				if (typProfilB1H1 == 4)
				{
					array2 = FlanetsPrjamokutnyj.MaterialFlanetsPrjamokutnyj(B, H, typProfilB1H1, number, polkaBH, 1);
					materialCost += FlanetsPrjamokutnyj.materialCost1;
					if (FlanetsPrjamokutnyj.materialName[0] != "")
					{
						materialName[num13] = FlanetsPrjamokutnyj.materialName[0];
						for (int num21 = 0; num21 < 6; num21++)
						{
							array[num13, num21] = ((num21 == 1) ? array2[0, num21] : (array[num13, num21] + array2[0, num21]));
						}
					}
				}
				if (typProfilB2H2 == 4)
				{
					array2 = FlanetsPrjamokutnyj.MaterialFlanetsPrjamokutnyj(B, H, typProfilB2H2, number, polkaB1H1, 1);
					materialCost += FlanetsPrjamokutnyj.materialCost1;
					if (FlanetsPrjamokutnyj.materialName[0] != "")
					{
						materialName[num13] = FlanetsPrjamokutnyj.materialName[0];
						for (int num22 = 0; num22 < 6; num22++)
						{
							array[num13, num22] = ((num22 == 1) ? array2[0, num22] : (array[num13, num22] + array2[0, num22]));
						}
					}
				}
				num13++;
			}
			if (typVPKvrizka == 1)
			{
				double[,] array5 = new double[5, 6];
				array5 = FlanetsKruglyj.MaterialFlanetsKruglyj(D, typMaterialD, number, 1);
				materialCost += FlanetsKruglyj.materialCost1;
				for (int num23 = 0; num23 < 5; num23++)
				{
					materialName[num23 + num13 + 1] = FlanetsKruglyj.materialName1[num23];
					for (int num24 = 0; num24 < 6; num24++)
					{
						array[num23 + num13 + 1, num24] = array5[num23, num24];
					}
				}
			}
		}
		return array;
	}

	public static double PriceVrizkaVPK(int B, int H, int L, int D, int l, double alpha, int markaStali, double tovchynaMetalu, int typVPKenter, int typVPKout, int typVPKvrizka, int typMaterialD, int vidbortovka)
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
			num = ((typVPKenter != 1 && typVPKout != 1) ? ((!(tovchynaMetalu < 0.65)) ? ((tovchynaMetalu < 0.9) ? 406.0 : 520.0) : 345.0) : ((!(tovchynaMetalu < 0.65)) ? ((tovchynaMetalu < 0.9) ? 464.0 : 600.0) : 402.5));
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
		if (alpha > 90.0)
		{
			alpha = 180.0 - alpha;
		}
		alpha = Math.PI * alpha / 180.0;
		materialSpendingCommercialOffer = 2.0 * (double)(B + H) * (double)L - Math.PI * (double)D * (double)D / (4.0 * Math.Sin(alpha));
		double num7 = l;
		if (alpha != Math.PI / 2.0)
		{
			num7 += (double)D / (2.0 * Math.Tan(alpha));
		}
		materialSpendingCommercialOffer += Math.PI * (double)D * num7;
		materialSpendingCommercialOffer /= 1000000.0;
		double num8 = materialSpendingCommercialOffer * num;
		if (materialSpendingCommercialOffer < 0.005)
		{
			materialSpendingCommercialOffer = Math.Round(1000.0 * materialSpendingCommercialOffer) / 1000.0;
		}
		else
		{
			materialSpendingCommercialOffer = Math.Round(100.0 * materialSpendingCommercialOffer) / 100.0;
		}
		if (typVPKvrizka == 1)
		{
			FlanetsKruglyj.MaterialFlanetsKruglyj(D, typMaterialD, 1, 1);
			num8 += FlanetsKruglyj.priceProduct1;
		}
		tovchynaMetaluCommercialOffer = tovchynaMetalu;
		return num8;
	}

	public static double VolumeVrizkaVPK(int B, int H, int L, int l, double alpha)
	{
		if (alpha > 90.0)
		{
			alpha = 180.0 - alpha;
		}
		alpha = Math.PI * alpha / 180.0;
		double num = ((alpha == Math.PI / 2.0) ? ((double)l) : ((double)l * Math.Tan(alpha)));
		return Math.Round((double)H * ((double)B + num) * (double)L / 1000000.0) / 1000.0;
	}
}
