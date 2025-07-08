using System;
using TEZ_Project.Common.Helpers;
using TEZ_Project;

namespace TEZ_Project.Common.Products;

public static class TrijnykTRK
{
	public static string[] materialName = new string[21]
	{
		"", "", "", "", "", "", "", "", "", "",
		"", "", "", "", "", "", "", "", "", "",
		""
	};

	public static double materialCost;

	public static double materialSpendingCommercialOffer = 0.0;

	public static double tovchynaMetaluCommercialOffer = 0.0;

	public static double[,] MaterialTrijnykTRK(int D, int D1, int D2, int L, int l, int k, int k1, double alpha, int markaStali, double tovchynaMetalu, int typTRKinput, int typTRKoutput, int typTRKvrizka, int typMaterialD, int typMaterialD1, int typMaterialD2, int number, int vidbortovka, string aisiType = "430")
	{
		double[,] array = new double[21, 6];
		double num = 0.0;
		int num2 = ((D > D1) ? D : D1);
		materialName = new string[21]
		{
			"", "", "", "", "", "", "", "", "", "",
			"", "", "", "", "", "", "", "", "", "",
			""
		};
		materialCost = 0.0;
		double num3 = 0.0;
		L += vidbortovka;
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
		double num8 = Math.PI * (double)D / 4.0;
		double num9 = Math.PI * (double)D1 / 4.0;
		double num10 = (4.0 * num8 + 30.0) * (double)k + (4.0 * num9 + 30.0) * (double)k1 + (2.0 * (num8 + num9) + 30.0) * (double)L;
		if (k + L + k1 > 2500)
		{
			num10 += 60.0 * (4.0 * num8 + 30.0);
		}
		else if (k + L + k1 > 1250)
		{
			num10 += 30.0 * (4.0 * num8 + 30.0);
		}
		if (4.0 * num8 + 30.0 > 2500.0)
		{
			num10 += 60.0 * (double)(k + L + k1);
		}
		else if (4.0 * num8 + 30.0 > 1250.0)
		{
			num10 += 30.0 * (double)(k + L + k1);
		}
		double num11 = Math.Asin((double)(D - D1) / (double)(2 * L));
		double a = alpha * Math.PI / 180.0 + num11;
		double num12 = ((double)D - Math.Sqrt((double)D * (double)D - (double)(D2 * D2))) / 2.0;
		double num13 = (double)D2 / Math.Tan(a);
		double num14 = ((num13 > num12) ? num13 : num12);
		double num15 = (Math.PI * (double)D2 + 10.0) * ((double)l + num14 + 10.0);
		if (Math.PI * (double)D2 + 10.0 > 2500.0)
		{
			num15 += 60.0 * ((double)l + num14 + 10.0);
		}
		else if (Math.PI * (double)D2 + 10.0 > 1250.0)
		{
			num15 += 30.0 * ((double)l + num14 + 10.0);
		}
		array[0, 0] = (num10 + num15) * 1.05 / 1000000.0;
		num10 = (Math.PI * (double)D + 30.0) * (double)k + (Math.PI * (double)D1 + 30.0) * (double)k1 + (Math.PI * (double)(D + D1) / 2.0 + 30.0) * (double)L;
		num10 += -Math.PI * (double)D2 * (double)D2 / (4.0 * Math.Sin(a)) + Math.PI * (double)D2 * ((double)l + (double)D2 / (2.0 * Math.Tan(a)));
		num10 /= 1000000.0;
		double num16 = Math.Round((array[0, 0] / num10 - 1.0) * 100.0);
		if (num16 > 100.0)
		{
			num16 = 100.0;
			array[0, 0] = num10 * (1.0 + num16 / 100.0);
		}
		array[0, 1] = num16 / 100.0;
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
		if (typTRKinput == 1 || typTRKoutput == 1 || typTRKvrizka == 1)
		{
			double[,] array2 = new double[5, 6];
			int num17 = 1;
			if (typTRKinput == 1)
			{
				array2 = FlanetsKruglyj.MaterialFlanetsKruglyj(D, typMaterialD, number, 1);
				materialCost += FlanetsKruglyj.materialCost1;
				int num18 = 0;
				for (int i = 0; i < 5 && FlanetsKruglyj.materialName1[i] != ""; i++)
				{
					num18++;
				}
				for (int j = 0; j < num18; j++)
				{
					materialName[j + num17] = FlanetsKruglyj.materialName1[j];
					for (int m = 0; m < 6; m++)
					{
						array[j + num17, m] = array2[j, m];
					}
				}
				num17 += num18;
			}
			if (typTRKoutput == 1)
			{
				array2 = FlanetsKruglyj.MaterialFlanetsKruglyj(D1, typMaterialD1, number, 1);
				materialCost += FlanetsKruglyj.materialCost1;
				int num19 = 0;
				for (int n = 0; n < 5 && FlanetsKruglyj.materialName1[n] != ""; n++)
				{
					num19++;
				}
				for (int num20 = 0; num20 < num19; num20++)
				{
					materialName[num20 + num17] = FlanetsKruglyj.materialName1[num20];
					for (int num21 = 0; num21 < 6; num21++)
					{
						array[num20 + num17, num21] = array2[num20, num21];
					}
				}
				num17 += num19;
			}
			if (typTRKvrizka == 1)
			{
				array2 = FlanetsKruglyj.MaterialFlanetsKruglyj(D2, typMaterialD2, number, 1);
				materialCost += FlanetsKruglyj.materialCost1;
				int num22 = 0;
				for (int num23 = 0; num23 < 5 && FlanetsKruglyj.materialName1[num23] != ""; num23++)
				{
					num22++;
				}
				for (int num24 = 0; num24 < num22; num24++)
				{
					materialName[num24 + num17] = FlanetsKruglyj.materialName1[num24];
					for (int num25 = 0; num25 < 6; num25++)
					{
						array[num24 + num17, num25] = array2[num24, num25];
					}
				}
				num17 += num22;
			}
			if (num17 > 2)
			{
				for (int num26 = 1; num26 < num17; num26++)
				{
					for (int num27 = num26 + 1; num27 < num17; num27++)
					{
						if (materialName[num26] == materialName[num27])
						{
							materialName[num27] = "";
							array[num26, 0] += array[num27, 0];
							array[num27, 0] = 0.0;
							if (materialName[num26] == Consts2.lystStalnyj30.MaterialName)
							{
								array[num26, 1] = Math.Round((array[num26, 1] + array[num27, 1]) / 2.0);
							}
							array[num27, 1] = 0.0;
							array[num26, 2] += array[num27, 2];
							array[num27, 2] = 0.0;
							array[num26, 3] += array[num27, 3];
							array[num27, 3] = 0.0;
							array[num26, 4] += array[num27, 4];
							array[num27, 4] = 0.0;
							array[num26, 5] += array[num27, 5];
							array[num27, 5] = 0.0;
						}
					}
				}
			}
		}
		return array;
	}

	public static double PriceTrijnykTRK(int D, int D1, int D2, int L, int l, int k, int k1, double alpha, int markaStali, double tovchynaMetalu, int typTRKinput, int typTRKoutput, int typTRKvrizka, int typMaterialD, int typMaterialD1, int typMaterialD2, int vidbortovka)
	{
		double num = 1.0;
		L += vidbortovka;
		int num2 = ((D > D1) ? D : D1);
		double num3 = Math.Asin((double)(D - D1) / (double)(2 * L));
		double a = alpha * Math.PI / 180.0 + num3;
		materialSpendingCommercialOffer = Math.PI * (double)(D * k + D1 * k1 + (D + D1) * L / 2) - Math.PI * (double)D2 * (double)D2 / (4.0 * Math.Sin(a)) + Math.PI * (double)D2 * ((double)l + (double)D2 / (2.0 * Math.Tan(a)));
		materialSpendingCommercialOffer /= 1000000.0;
		materialSpendingCommercialOffer *= 1.03;
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
			double num6 = tovchynaMetalu;
			double num7 = num6;
			num = ((num7 == 0.5) ? 115.0 : ((num7 == 0.8) ? 115.0 : ((num7 == 1.0) ? 134.78 : ((num7 == 1.2) ? 134.78 : ((num7 == 1.5) ? 173.19 : ((num7 == 2.0) ? 173.19 : ((num7 == 2.5) ? 173.19 : ((num7 == 3.0) ? 173.19 : ((num7 == 4.0) ? 173.19 : ((num7 == 5.0) ? 173.19 : ((num7 != 6.0) ? 0.0 : 173.19)))))))))));
			break;
		}
		case 3:
		{
			if (tovchynaMetalu == 0.0)
			{
				tovchynaMetalu = ((num2 > 400) ? ((num2 <= 800) ? 0.8 : 1.0) : 0.5);
			}
			double num4 = tovchynaMetalu;
			double num5 = num4;
			num = ((num5 == 0.5) ? 115.0 : ((num5 == 0.8) ? 134.78 : ((num5 == 1.0) ? 173.19 : ((num5 == 1.2) ? 173.19 : ((num5 != 1.5) ? 0.0 : 173.19)))));
			break;
		}
		}
		double num8 = materialSpendingCommercialOffer * num;
		if (materialSpendingCommercialOffer < 0.005)
		{
			materialSpendingCommercialOffer = Math.Round(1000.0 * materialSpendingCommercialOffer) / 1000.0;
		}
		else
		{
			materialSpendingCommercialOffer = Math.Round(100.0 * materialSpendingCommercialOffer) / 100.0;
		}
		if (typTRKinput == 1)
		{
			FlanetsKruglyj.MaterialFlanetsKruglyj(D, typMaterialD, 1, 1);
			num8 += FlanetsKruglyj.priceProduct1;
		}
		if (typTRKoutput == 1)
		{
			FlanetsKruglyj.MaterialFlanetsKruglyj(D1, typMaterialD1, 1, 1);
			num8 += FlanetsKruglyj.priceProduct1;
		}
		if (typTRKvrizka == 1)
		{
			FlanetsKruglyj.MaterialFlanetsKruglyj(D2, typMaterialD2, 1, 1);
			num8 += FlanetsKruglyj.priceProduct1;
		}
		tovchynaMetaluCommercialOffer = tovchynaMetalu;
		return num8;
	}

	public static double VolumeTrijnykTRK(int D, int D1, int D2, int L, int l, int k, int k1, double alpha)
	{
		double num = Math.Asin((D - D1) / (2 * L));
		double a = alpha * Math.PI / 180.0 + num;
		return Math.Round((double)(k + L + k1) * (double)D * ((double)D + ((double)D2 / Math.Tan(a) + (double)l) * Math.Sin(a)) / 1000000.0) / 1000.0;
	}
}
