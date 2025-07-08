using System;
using TEZ_Project.Common.Helpers;
using TEZ_Project;

namespace TEZ_Project.Common.Products;

public class PerehidnykPSP_K
{
	public static string[] materialName = new string[9] { "", "", "", "", "", "", "", "", "" };

	public static double materialCost;

	public static double materialSpendingCommercialOffer = 0.0;

	public static double tovchynaMetaluCommercialOffer = 0.0;

	public static double[,] MaterialPerehignykPSP_K(int B, int H, int D, int L, int k, int k1, int markaStali, double tovchynaMetalu, int typPSP_K, int typProfilBH, int typProfilD, int number, int polkaBH, int vidbortovka, string aisiType = "430")
	{
		double[,] array = new double[9, 6];
		double num = 0.0;
		double num2 = 0.0;
		double num3 = ((B >= H) ? B : H);
		double num4 = 0.0;
		L += vidbortovka;
		materialName = new string[9] { "", "", "", "", "", "", "", "", "" };
		materialCost = 0.0;
		switch (markaStali)
		{
		case 1:
		{
			if (tovchynaMetalu == 0.0)
			{
				tovchynaMetalu = ((!(num3 <= 400.0)) ? ((num3 <= 800.0) ? 0.7 : 0.9) : 0.5);
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
				tovchynaMetalu = ((!(num3 <= 400.0)) ? ((num3 <= 800.0) ? 0.8 : 1.0) : 0.5);
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
				tovchynaMetalu = ((!(num3 <= 400.0)) ? ((num3 <= 800.0) ? 0.8 : 1.0) : 0.5);
			}
			num = 7825.0;
			num2 = MaterialHelper.GetMaterialWithdrawalNerzavijka(tovchynaMetalu);
			CustomConst lystNerzavijuchyj = MaterialHelper.GetLystNerzavijuchyj(tovchynaMetalu, aisiType);
			materialName[0] = lystNerzavijuchyj?.MaterialName ?? "Лист НЕРЖ ??, м2";
			num4 = lystNerzavijuchyj.Price;
			break;
		}
		}
		L -= k;
		double num9 = Math.PI * (double)D / 4.0;
		double num10 = num9;
		double num11 = Math.Sqrt(4.0 * (double)L * (double)L + (num10 - (double)H) * (num10 - (double)H)) / 2.0;
		num3 = (((double)B > num9) ? ((double)B) : num9);
		double num12 = (num3 + 10.0) * (num11 + (double)k + (double)k1);
		if (num11 > (double)(1250 - k))
		{
			num12 += 30.0 * (double)(1250 - k) * (num9 + 10.0) / num11;
		}
		num11 = Math.Sqrt(4.0 * (double)L * (double)L + (num9 - (double)B) * (num9 - (double)B)) / 2.0;
		num3 = (((double)H > num10) ? ((double)H) : num10);
		double num13 = (num3 + 50.0) * (num11 + (double)k + (double)k1);
		if (num11 > (double)(1250 - k))
		{
			num13 += 30.0 * (double)(1250 - k) * (num10 + 50.0) / num11;
		}
		array[0, 0] = 2.0 * (num12 + num13) * (1.0 + num2 / 100.0) / 1000000.0;
		num12 = ((double)B + num9 + 20.0) * Math.Sqrt(4.0 * (double)L * (double)L + (num10 - (double)H) * (num10 - (double)H)) / 4.0 + (double)((B + 10) * k) + (num9 + 10.0) * (double)k1;
		num12 += ((double)H + num10 + 100.0) * Math.Sqrt(4.0 * (double)L * (double)L + (num9 - (double)B) * (num9 - (double)B)) / 4.0 + (double)((H + 50) * k) + (num10 + 50.0) * (double)k1;
		num12 *= 2.0;
		num12 /= 1000000.0;
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
		materialCost = array[0, 0] * num4;
		int num14 = 1;
		int num15 = 0;
		if (typPSP_K == 1 || typPSP_K == 2 || typPSP_K == 9)
		{
			if (typProfilBH == 0)
			{
				num3 = ((B >= H) ? B : H);
				typProfilBH = ((num3 < 800.0) ? 1 : 2);
			}
			double[,] array2 = new double[2, 6];
			array2 = FlanetsPrjamokutnyj.MaterialFlanetsPrjamokutnyj(B, H, typProfilBH, number, polkaBH, 1);
			materialCost += FlanetsPrjamokutnyj.materialCost1;
			if (typProfilBH <= 2)
			{
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
				num14 += 2;
				double[,] array3 = new double[1, 6];
				array3 = HvyntNaFlanets.MaterialHvyntNaFlanets(B, H, 1, number);
				materialCost += HvyntNaFlanets.materialCost1;
				materialName[num14] = HvyntNaFlanets.materialName1[0];
				for (int l = 0; l < 6; l++)
				{
					array[num14, l] = array3[0, l];
				}
				num14++;
			}
			else
			{
				if (FlanetsPrjamokutnyj.materialName[0] != "")
				{
					num15 = num14;
					materialName[num14] = FlanetsPrjamokutnyj.materialName[0];
					for (int m = 0; m < 6; m++)
					{
						array[num14, m] = ((m == 1) ? array2[0, m] : (array[num14, m] + array2[0, m]));
					}
				}
				num14++;
			}
		}
		if (typPSP_K == 1 || typPSP_K == 3 || typPSP_K == 10)
		{
			double[,] array4 = new double[5, 6];
			array4 = FlanetsKruglyj.MaterialFlanetsKruglyj(D, typProfilD, number, 1);
			materialCost += FlanetsKruglyj.materialCost1;
			for (int n = 0; n < 5; n++)
			{
				if (FlanetsKruglyj.materialName1[n] == materialName[num15])
				{
					for (int num16 = 0; num16 < 6; num16++)
					{
						array[num15, num16] += array4[n, num16];
					}
					array[num15, 1] = Math.Round(100.0 * array[num15, 1] / 2.0) / 100.0;
				}
				else
				{
					materialName[n + num14] = FlanetsKruglyj.materialName1[n];
					for (int num17 = 0; num17 < 6; num17++)
					{
						array[n + num14, num17] = array4[n, num17];
					}
				}
			}
		}
		return array;
	}

	public static double PricePerehidnykPSP_K(int B, int H, int D, int L, int k, int k1, int markaStali, double tovchynaMetalu, int typPSP_K, int typProfilD, int vidbortovka)
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
			num = ((!(tovchynaMetalu < 0.65)) ? ((tovchynaMetalu < 0.9) ? 464.0 : 600.0) : 402.5);
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
		L -= k;
		double num7 = Math.PI * (double)D / 4.0;
		double num8 = num7;
		materialSpendingCommercialOffer = ((double)B + num7) * Math.Sqrt(4.0 * (double)L * (double)L + (num8 - (double)H) * (num8 - (double)H)) / 4.0 + (double)(B * k) + num7 * (double)k1;
		materialSpendingCommercialOffer += ((double)H + num8) * Math.Sqrt(4.0 * (double)L * (double)L + (num7 - (double)B) * (num7 - (double)B)) / 4.0 + (double)(H * k) + num8 * (double)k1;
		materialSpendingCommercialOffer *= 2.0;
		materialSpendingCommercialOffer /= 1000000.0;
		double num9 = materialSpendingCommercialOffer * num;
		if (materialSpendingCommercialOffer < 0.005)
		{
			materialSpendingCommercialOffer = Math.Round(1000.0 * materialSpendingCommercialOffer) / 1000.0;
		}
		else
		{
			materialSpendingCommercialOffer = Math.Round(100.0 * materialSpendingCommercialOffer) / 100.0;
		}
		if (typPSP_K == 1 || typPSP_K == 3 || typPSP_K == 10)
		{
			FlanetsKruglyj.MaterialFlanetsKruglyj(D, typProfilD, 1, 1);
			num9 += FlanetsKruglyj.priceProduct1;
		}
		tovchynaMetaluCommercialOffer = tovchynaMetalu;
		return num9;
	}

	public static double VolumePerehidnykPSP_K(int B, int H, int D, int L, int k, int k1)
	{
		double num = ((B > D) ? B : D);
		double num2 = ((H > D) ? H : D);
		double num3 = L + k + k1;
		return Math.Round(num * num2 * num3 / 1000000.0) / 1000.0;
	}
}
