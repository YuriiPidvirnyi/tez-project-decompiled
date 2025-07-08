using System;
using TEZ_Project.Common.Helpers;

using TEZ_Project.Common.Data;
using TEZ_Project;

namespace TEZ_Project.Common.Products;

public static class PerehidnykPAK
{
	public static string[] materialName = new string[11]
	{
		"", "", "", "", "", "", "", "", "", "",
		""
	};

	public static double materialCost;

	public static double materialSpendingCommercialOffer = 0.0;

	public static double tovchynaMetaluCommercialOffer = 0.0;

	public static double[,] MaterialPerehidnykPAK(int D, int D1, int L, int c, int k, int k1, int markaStali, double tovchynaMetalu, int typPAK, int typMaterialD, int typMaterialD1, int number, int vidbortovka, string aisiType = "430")
	{
		double[,] array = new double[11, 6];
		double num = 0.0;
		int num2 = ((D > D1) ? D : D1);
		double num3 = 0.0;
		L += vidbortovka;
		materialName = new string[11]
		{
			"", "", "", "", "", "", "", "", "", "",
			""
		};
		materialCost = 0.0;
		switch (markaStali)
		{
		case 1:
		{
			if (tovchynaMetalu == 0.0)
			{
				tovchynaMetalu = ((num2 > 400) ? ((num2 <= 800) ? 0.7 : 0.9) : 0.5);
			}
			num = 7825.0;
			double num4 = tovchynaMetalu;
			double num5 = num4;
			if (num5 != 0.5)
			{
				if (num5 != 0.65)
				{
					if (num5 != 0.68)
					{
						if (num5 != 0.7)
						{
							if (num5 != 0.9)
							{
								if (num5 != 1.0)
								{
									if (num5 == 1.2)
									{
										materialName[0] = Consts2.lystOchynkovanyj12.MaterialName;
										num3 = Consts2.lystOchynkovanyj12.Price;
									}
									else
									{
										materialName[0] = "Лист ОЦ ??, м2";
									}
								}
								else
								{
									materialName[0] = Consts2.lystOchynkovanyj10.MaterialName;
									num3 = Consts2.lystOchynkovanyj10.Price;
								}
							}
							else
							{
								materialName[0] = Consts2.lystOchynkovanyj09.MaterialName;
								num3 = Consts2.lystOchynkovanyj09.Price;
							}
						}
						else
						{
							materialName[0] = Consts2.lystOchynkovanyj07.MaterialName;
							num3 = Consts2.lystOchynkovanyj07.Price;
						}
					}
					else
					{
						materialName[0] = Consts2.lystOchynkovanyj068.MaterialName;
						num3 = Consts2.lystOchynkovanyj068.Price;
					}
				}
				else
				{
					materialName[0] = Consts2.lystOchynkovanyj065.MaterialName;
					num3 = Consts2.lystOchynkovanyj065.Price;
				}
			}
			else
			{
				materialName[0] = Consts2.lystOchynkovanyj05.MaterialName;
				num3 = Consts2.lystOchynkovanyj05.Price;
			}
			break;
		}
		case 2:
		{
			if (tovchynaMetalu == 0.0)
			{
				tovchynaMetalu = ((num2 > 400) ? ((num2 <= 800) ? 0.8 : 1.0) : 0.5);
			}
			num = 7825.0;
			double num6 = tovchynaMetalu;
			double num7 = num6;
			if (num7 != 0.5)
			{
				if (num7 != 0.8)
				{
					if (num7 != 1.0)
					{
						if (num7 != 1.2)
						{
							if (num7 != 1.5)
							{
								if (num7 != 2.0)
								{
									if (num7 != 2.5)
									{
										if (num7 != 3.0)
										{
											if (num7 != 4.0)
											{
												if (num7 != 5.0)
												{
													if (num7 == 6.0)
													{
														materialName[0] = Consts2.lystStalnyj60.MaterialName;
														num3 = Consts2.lystStalnyj60.Price;
													}
													else
													{
														materialName[0] = "Лист СТ ??, м2";
													}
												}
												else
												{
													materialName[0] = Consts2.lystStalnyj50.MaterialName;
													num3 = Consts2.lystStalnyj50.Price;
												}
											}
											else
											{
												materialName[0] = Consts2.lystStalnyj40.MaterialName;
												num3 = Consts2.lystStalnyj40.Price;
											}
										}
										else
										{
											materialName[0] = Consts2.lystStalnyj30.MaterialName;
											num3 = Consts2.lystStalnyj30.Price;
										}
									}
									else
									{
										materialName[0] = Consts2.lystStalnyj25.MaterialName;
										num3 = Consts2.lystStalnyj25.Price;
									}
								}
								else
								{
									materialName[0] = Consts2.lystStalnyj20.MaterialName;
									num3 = Consts2.lystStalnyj20.Price;
								}
							}
							else
							{
								materialName[0] = Consts2.lystStalnyj15.MaterialName;
								num3 = Consts2.lystStalnyj15.Price;
							}
						}
						else
						{
							materialName[0] = Consts2.lystStalnyj12.MaterialName;
							num3 = Consts2.lystStalnyj12.Price;
						}
					}
					else
					{
						materialName[0] = Consts2.lystStalnyj10.MaterialName;
						num3 = Consts2.lystStalnyj10.Price;
					}
				}
				else
				{
					materialName[0] = Consts2.lystStalnyj08.MaterialName;
					num3 = Consts2.lystStalnyj08.Price;
				}
			}
			else
			{
				materialName[0] = Consts2.lystStalnyj05.MaterialName;
				num3 = Consts2.lystStalnyj05.Price;
			}
			break;
		}
		case 3:
		{
			if (tovchynaMetalu == 0.0)
			{
				tovchynaMetalu = ((num2 > 400) ? ((num2 <= 800) ? 0.8 : 1.0) : 0.5);
			}
			num = 7825.0;
			CustomConst lystNerzavijuchyj = MaterialHelper.GetLystNerzavijuchyj(tovchynaMetalu, aisiType);
			materialName[0] = lystNerzavijuchyj?.MaterialName ?? "Лист НЕРЖ ??, м2";
			num3 = lystNerzavijuchyj.Price;
			break;
		}
		}
		int num8;
		if (D > D1)
		{
			num2 = D;
			num8 = D1;
		}
		else
		{
			num2 = D1;
			num8 = D;
		}
		double num9 = Math.Sqrt((double)L * (double)L + (double)((num2 - num8 - c) * (num2 - num8 - c)));
		double num10 = Math.Sqrt((double)L * (double)L + (double)(c * c));
		double num11 = Math.Sqrt((double)L * (double)L + (double)(((num2 - num8) / 2 - c) * ((num2 - num8) / 2 - c)) + (double)(num2 - num8) * (double)(num2 - num8) / 4.0);
		double num12 = num11;
		double num13 = num9;
		if (num10 > num13)
		{
			num13 = num10;
		}
		if (num11 > num13)
		{
			num13 = num11;
		}
		if (num12 > num13)
		{
			num13 = num12;
		}
		double num14 = Math.PI * (double)(num2 - num8) / (2.0 * num13);
		double num15 = (num9 + num10 + num11 + num12) * ((double)num2 - (double)num8 * Math.Cos(num14)) / (double)(4 * (num2 - num8)) + (double)k + (double)k1;
		double num16 = (num9 + num10 + num11 + num12) * (double)num2 * Math.Sin(num14) / (double)(2 * (num2 - num8)) + 30.0;
		array[0, 0] = num15 * num16;
		if (num15 > 2500.0)
		{
			array[0, 0] += 60.0 * num16;
		}
		else if (num15 > 1250.0)
		{
			array[0, 0] += 30.0 * num16;
		}
		if (num16 > 2500.0)
		{
			array[0, 0] += 60.0 * num15;
		}
		else if (num16 > 1250.0)
		{
			array[0, 0] += 30.0 * num15;
		}
		array[0, 0] *= 1.0500000000000001E-06;
		double num17 = (Math.PI * (double)(D + D1) + 60.0) * (num9 + num10 + num11 + num12) / 8.0;
		num17 += (Math.PI * (double)D + 30.0) * (double)k + (Math.PI * (double)D1 + 30.0) * (double)k1;
		num17 /= 1000000.0;
		double num18 = Math.Round((array[0, 0] / num17 - 1.0) * 100.0);
		if (num18 > 20.0)
		{
			num18 = 20.0;
			array[0, 0] = num17 * (1.0 + num18 / 100.0);
		}
		array[0, 1] = num18 / 100.0;
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
		materialCost = array[0, 0] * num3;
		if (typPAK == 2 || typPAK == 3)
		{
			double[,] array2 = new double[5, 6];
			array2 = ((typPAK == 2) ? FlanetsKruglyj.MaterialFlanetsKruglyj(D, typMaterialD, number, 1) : FlanetsKruglyj.MaterialFlanetsKruglyj(D1, typMaterialD1, number, 1));
			materialCost += FlanetsKruglyj.materialCost1;
			for (int i = 0; i < 5; i++)
			{
				materialName[i + 1] = FlanetsKruglyj.materialName1[i];
				for (int j = 0; j < 6; j++)
				{
					array[i + 1, j] = array2[i, j];
				}
			}
		}
		else if (typPAK == 1)
		{
			double[,] array3 = new double[5, 6];
			array3 = FlanetsKruglyj.MaterialFlanetsKruglyj(D, typMaterialD, number, 1);
			materialCost += FlanetsKruglyj.materialCost1;
			for (int l = 0; l < 5; l++)
			{
				materialName[l + 1] = FlanetsKruglyj.materialName1[l];
				for (int m = 0; m < 6; m++)
				{
					array[l + 1, m] = array3[l, m];
				}
			}
			array3 = new double[5, 6];
			array3 = FlanetsKruglyj.MaterialFlanetsKruglyj(D1, typMaterialD1, number, 1);
			materialCost += FlanetsKruglyj.materialCost1;
			for (int n = 0; n < 5; n++)
			{
				materialName[n + 1 + 5] = FlanetsKruglyj.materialName1[n];
				for (int num19 = 0; num19 < 6; num19++)
				{
					array[n + 1 + 5, num19] = array3[n, num19];
				}
			}
			int num20 = 0;
			for (int num21 = 1; num21 < 6 && materialName[num21] != ""; num21++)
			{
				num20++;
			}
			int num22 = 0;
			for (int num23 = 6; num23 < 11 && materialName[num23] != ""; num23++)
			{
				num22++;
			}
			for (int num24 = 0; num24 < num20; num24++)
			{
				for (int num25 = 0; num25 < num22; num25++)
				{
					if (materialName[num24 + 1] == materialName[num25 + 6])
					{
						materialName[num25 + 6] = "";
						array[num24 + 1, 0] += array[num25 + 6, 0];
						array[num25 + 6, 0] = 0.0;
						if (materialName[num24 + 1] == Consts2.lystStalnyj30.MaterialName)
						{
							array[num24 + 1, 1] = Math.Round((array[num24 + 1, 1] + array[num25 + 6, 1]) / 2.0);
						}
						array[num25 + 6, 1] = 0.0;
						array[num24 + 1, 2] += array[num25 + 6, 2];
						array[num25 + 6, 2] = 0.0;
						array[num24 + 1, 3] += array[num25 + 6, 3];
						array[num25 + 6, 3] = 0.0;
						array[num24 + 1, 4] += array[num25 + 6, 4];
						array[num25 + 6, 4] = 0.0;
						array[num24 + 1, 5] += array[num25 + 6, 5];
						array[num25 + 6, 5] = 0.0;
					}
				}
			}
		}
		return array;
	}

	public static double PricePerehidnykPAK(int D, int D1, int L, int c, int k, int k1, int markaStali, double tovchynaMetalu, int typPAK, int typMaterialD, int typMaterialD1, int vidbortovka)
	{
		double num = 1.0;
		L += vidbortovka;
		int num2;
		int num3;
		if (D > D1)
		{
			num2 = D;
			num3 = D1;
		}
		else
		{
			num2 = D1;
			num3 = D;
		}
		double num4 = Math.Sqrt((double)L * (double)L + (double)(num2 - num3 - c) * (double)(num2 - num3 - c));
		double num5 = Math.Sqrt((double)L * (double)L + (double)(c * c));
		double num6 = Math.Sqrt((double)L * (double)L + (double)((num2 - num3) / 2 - c) * (double)((num2 - num3) / 2 - c) + (double)(num2 - num3) * (double)(num2 - num3) / 4.0);
		double num7 = num6;
		materialSpendingCommercialOffer = Math.PI * ((double)(D + D1) * (num4 + num5 + num6 + num7) / 8.0 + (double)(D * k) + (double)(D1 * k1)) / 1000000.0;
		switch (markaStali)
		{
		case 1:
			if (tovchynaMetalu == 0.0)
			{
				tovchynaMetalu = ((num2 > 400) ? ((num2 <= 800) ? 0.7 : 0.9) : 0.5);
			}
			num = ((!(tovchynaMetalu < 0.65)) ? ((tovchynaMetalu < 0.9) ? 406.0 : 520.0) : 345.0);
			break;
		case 2:
		{
			if (tovchynaMetalu == 0.0)
			{
				tovchynaMetalu = ((num2 > 400) ? ((num2 <= 800) ? 0.8 : 1.0) : 0.5);
			}
			double num10 = tovchynaMetalu;
			double num11 = num10;
			num = ((num11 == 0.5) ? 115.0 : ((num11 == 0.8) ? 115.0 : ((num11 == 1.0) ? 134.78 : ((num11 == 1.2) ? 134.78 : ((num11 == 1.5) ? 173.19 : ((num11 == 2.0) ? 173.19 : ((num11 == 2.5) ? 173.19 : ((num11 == 3.0) ? 173.19 : ((num11 == 4.0) ? 173.19 : ((num11 == 5.0) ? 173.19 : ((num11 != 6.0) ? 0.0 : 173.19)))))))))));
			break;
		}
		case 3:
		{
			if (tovchynaMetalu == 0.0)
			{
				tovchynaMetalu = ((num2 > 400) ? ((num2 <= 800) ? 0.8 : 1.0) : 0.5);
			}
			double num8 = tovchynaMetalu;
			double num9 = num8;
			num = ((num9 == 0.5) ? 115.0 : ((num9 == 0.8) ? 134.78 : ((num9 == 1.0) ? 173.19 : ((num9 == 1.2) ? 173.19 : ((num9 != 1.5) ? 0.0 : 173.19)))));
			break;
		}
		}
		double num12 = materialSpendingCommercialOffer * num;
		if (materialSpendingCommercialOffer < 0.005)
		{
			materialSpendingCommercialOffer = Math.Round(1000.0 * materialSpendingCommercialOffer) / 1000.0;
		}
		else
		{
			materialSpendingCommercialOffer = Math.Round(100.0 * materialSpendingCommercialOffer) / 100.0;
		}
		if (typPAK == 1 || typPAK == 2)
		{
			FlanetsKruglyj.MaterialFlanetsKruglyj(D, typMaterialD, 1, 1);
			num12 += FlanetsKruglyj.priceProduct1;
		}
		if (typPAK == 1 || typPAK == 3)
		{
			FlanetsKruglyj.MaterialFlanetsKruglyj(D1, typMaterialD1, 1, 1);
			num12 += FlanetsKruglyj.priceProduct1;
		}
		tovchynaMetaluCommercialOffer = tovchynaMetalu;
		return num12;
	}

	public static double VolumePerehidnykPAK(int D, int D1, int L, int k, int k1)
	{
		double num = ((D > D1) ? D : D1);
		return Math.Round(num * num * (double)(L + k + k1) / 1000000.0) / 1000.0;
	}
}
