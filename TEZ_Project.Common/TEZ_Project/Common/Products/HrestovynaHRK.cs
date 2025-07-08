using System;
using TEZ_Project.Common.Data;
using TEZ_Project.Common.Helpers;
using TEZ_Project;

namespace TEZ_Project.Common.Products;

public static class HrestovynaHRK
{
	public static string[] materialName = new string[26]
	{
		"", "", "", "", "", "", "", "", "", "",
		"", "", "", "", "", "", "", "", "", "",
		"", "", "", "", "", ""
	};

	public static double materialCost;

	public static double materialSpendingCommercialOffer = 0.0;

	public static double tovchynaMetaluCommercialOffer = 0.0;

	public static double[,] MaterialHrestovynaHRK(int D, int D1, int D2, int D3, double L, int l, int l1, int alpha1, double alpha2, int k, int k1, int markaStali, double tovchynaMetalu, int typHRKinput, int typHRKoutput, int typHRKvrizkaUp, int typHRKvrizkaDown, int typMaterialD, int typMaterialD1, int typMaterialD2, int typMaterialD3, int number, int vidbortovka, string aisiType = "430")
	{
		double[,] array = new double[26, 6];
		double num = 0.0;
		double num2 = 0.0;
		materialName = new string[26]
		{
			"", "", "", "", "", "", "", "", "", "",
			"", "", "", "", "", "", "", "", "", "",
			"", "", "", "", "", ""
		};
		materialCost = 0.0;
		L += (double)vidbortovka;
		switch (markaStali)
		{
		case 1:
		{
			if (tovchynaMetalu == 0.0)
			{
				tovchynaMetalu = ((D > 400) ? ((D <= 800) ? 0.7 : 0.9) : 0.5);
			}
			num = 7825.0;
			double num3 = tovchynaMetalu;
			double num4 = num3;
			if (num4 != 0.5)
			{
				if (num4 != 0.65)
				{
					if (num4 != 0.68)
					{
						if (num4 != 0.7)
						{
							if (num4 != 0.9)
							{
								if (num4 != 1.0)
								{
									if (num4 == 1.2)
									{
										materialName[0] = Consts2.lystOchynkovanyj12.MaterialName;
										num2 = Consts2.lystOchynkovanyj12.Price;
									}
									else
									{
										materialName[0] = "Лист ОЦ ??, м2";
									}
								}
								else
								{
									materialName[0] = Consts2.lystOchynkovanyj10.MaterialName;
									num2 = Consts2.lystOchynkovanyj10.Price;
								}
							}
							else
							{
								materialName[0] = Consts2.lystOchynkovanyj09.MaterialName;
								num2 = Consts2.lystOchynkovanyj09.Price;
							}
						}
						else
						{
							materialName[0] = Consts2.lystOchynkovanyj07.MaterialName;
							num2 = Consts2.lystOchynkovanyj07.Price;
						}
					}
					else
					{
						materialName[0] = Consts2.lystOchynkovanyj068.MaterialName;
						num2 = Consts2.lystOchynkovanyj068.Price;
					}
				}
				else
				{
					materialName[0] = Consts2.lystOchynkovanyj065.MaterialName;
					num2 = Consts2.lystOchynkovanyj065.Price;
				}
			}
			else
			{
				materialName[0] = Consts2.lystOchynkovanyj05.MaterialName;
				num2 = Consts2.lystOchynkovanyj05.Price;
			}
			break;
		}
		case 2:
		{
			if (tovchynaMetalu == 0.0)
			{
				tovchynaMetalu = ((D > 400) ? ((D <= 800) ? 0.8 : 1.0) : 0.5);
			}
			num = 7825.0;
			double num5 = tovchynaMetalu;
			double num6 = num5;
			if (num6 != 0.5)
			{
				if (num6 != 0.8)
				{
					if (num6 != 1.0)
					{
						if (num6 != 1.2)
						{
							if (num6 != 1.5)
							{
								if (num6 != 2.0)
								{
									if (num6 != 2.5)
									{
										if (num6 != 3.0)
										{
											if (num6 != 4.0)
											{
												if (num6 != 5.0)
												{
													if (num6 == 6.0)
													{
														materialName[0] = Consts2.lystStalnyj60.MaterialName;
														num2 = Consts2.lystStalnyj60.Price;
													}
													else
													{
														materialName[0] = "Лист СТ ??, м2";
													}
												}
												else
												{
													materialName[0] = Consts2.lystStalnyj50.MaterialName;
													num2 = Consts2.lystStalnyj50.Price;
												}
											}
											else
											{
												materialName[0] = Consts2.lystStalnyj40.MaterialName;
												num2 = Consts2.lystStalnyj40.Price;
											}
										}
										else
										{
											materialName[0] = Consts2.lystStalnyj30.MaterialName;
											num2 = Consts2.lystStalnyj30.Price;
										}
									}
									else
									{
										materialName[0] = Consts2.lystStalnyj25.MaterialName;
										num2 = Consts2.lystStalnyj25.Price;
									}
								}
								else
								{
									materialName[0] = Consts2.lystStalnyj20.MaterialName;
									num2 = Consts2.lystStalnyj20.Price;
								}
							}
							else
							{
								materialName[0] = Consts2.lystStalnyj15.MaterialName;
								num2 = Consts2.lystStalnyj15.Price;
							}
						}
						else
						{
							materialName[0] = Consts2.lystStalnyj12.MaterialName;
							num2 = Consts2.lystStalnyj12.Price;
						}
					}
					else
					{
						materialName[0] = Consts2.lystStalnyj10.MaterialName;
						num2 = Consts2.lystStalnyj10.Price;
					}
				}
				else
				{
					materialName[0] = Consts2.lystStalnyj08.MaterialName;
					num2 = Consts2.lystStalnyj08.Price;
				}
			}
			else
			{
				materialName[0] = Consts2.lystStalnyj05.MaterialName;
				num2 = Consts2.lystStalnyj05.Price;
			}
			break;
		}
		case 3:
		{
			if (tovchynaMetalu == 0.0)
			{
				tovchynaMetalu = ((D > 400) ? ((D <= 800) ? 0.8 : 1.0) : 0.5);
			}
			num = 7825.0;
			CustomConst lystNerzavijuchyj = MaterialHelper.GetLystNerzavijuchyj(tovchynaMetalu, aisiType);
			materialName[0] = lystNerzavijuchyj?.MaterialName ?? "Лист НЕРЖ ??, м2";
			num2 = lystNerzavijuchyj.Price;
			break;
		}
		}
		double num7 = (Math.PI * (double)D + 30.0) * (double)k + (Math.PI * (double)D1 + 30.0) * (double)k1 + (Math.PI * (double)(D + D1) / 2.0 + 30.0) * L;
		if ((double)k + L + (double)k1 > 2500.0)
		{
			num7 += 60.0 * (Math.PI * (double)D + 30.0);
		}
		else if ((double)k + L + (double)k1 > 1250.0)
		{
			num7 += 30.0 * (Math.PI * (double)D + 30.0);
		}
		if (Math.PI * (double)D + 30.0 > 2500.0)
		{
			num7 += 60.0 * ((double)k + L + (double)k1);
		}
		else if (Math.PI * (double)D + 30.0 > 1250.0)
		{
			num7 += 30.0 * ((double)k + L + (double)k1);
		}
		double num8 = Math.Asin((double)(D - D1) / (2.0 * L));
		double a = (double)alpha1 * Math.PI / 180.0 + num8;
		double a2 = alpha2 * Math.PI / 180.0 + num8;
		double num9 = ((double)D - Math.Sqrt((double)D * (double)D - (double)(D2 * D2))) / 2.0;
		double num10 = (double)D2 / Math.Tan(a);
		double num11 = ((num10 > num9) ? num10 : num9);
		double num12 = (Math.PI * (double)D2 + 10.0) * ((double)l + num11 + 10.0);
		if (Math.PI * (double)D2 + 10.0 > 2500.0)
		{
			num12 += 60.0 * ((double)l + num11 + 10.0);
		}
		else if (Math.PI * (double)D2 + 10.0 > 1250.0)
		{
			num12 += 30.0 * ((double)l + num11 + 10.0);
		}
		num9 = ((double)D - Math.Sqrt((double)D * (double)D - (double)(D3 * D3))) / 2.0;
		num10 = (double)D2 / Math.Tan(a2);
		num11 = ((num10 > num9) ? num10 : num9);
		double num13 = (Math.PI * (double)D3 + 10.0) * ((double)l + num11 + 10.0);
		if (Math.PI * (double)D3 + 10.0 > 2500.0)
		{
			num13 += 60.0 * ((double)l + num11 + 10.0);
		}
		else if (Math.PI * (double)D3 + 10.0 > 1250.0)
		{
			num13 += 30.0 * ((double)l + num11 + 10.0);
		}
		array[0, 0] = (num7 + num12 + num13) * 1.05 / 1000000.0;
		num7 = (Math.PI * (double)D + 30.0) * (double)k + (Math.PI * (double)D1 + 30.0) * (double)k1 + (Math.PI * (double)(D + D1) + 60.0) * L / 2.0;
		num7 -= Math.PI * (double)D2 * (double)D2 / (4.0 * Math.Sin(a)) + Math.PI * (double)D3 * (double)D3 / (4.0 * Math.Sin(a2));
		num7 /= 1000000.0;
		num12 = (Math.PI * (double)D2 + 30.0) * ((double)l + (double)D2 / (2.0 * Math.Tan(a)) + 30.0) + (Math.PI * (double)D3 + 30.0) * ((double)l1 + (double)D3 / (2.0 * Math.Tan(a2)) + 30.0);
		num12 /= 1000000.0;
		double num14 = Math.Round((array[0, 0] / (num7 + num12) - 1.0) * 100.0);
		if (num14 > 100.0)
		{
			num14 = 100.0;
			array[0, 0] = num7 * (1.0 + num14 / 100.0);
		}
		array[0, 1] = num14 / 100.0;
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
		materialCost = array[0, 0] * num2;
		if (typHRKinput == 1 || typHRKoutput == 1 || typHRKvrizkaUp == 1 || typHRKvrizkaDown == 1)
		{
			double[,] array2 = new double[5, 6];
			int num15 = 1;
			if (typHRKinput == 1)
			{
				array2 = FlanetsKruglyj.MaterialFlanetsKruglyj(D, typMaterialD, number, 1);
				materialCost += FlanetsKruglyj.materialCost1;
				int num16 = 0;
				for (int i = 0; i < 5 && FlanetsKruglyj.materialName1[i] != ""; i++)
				{
					num16++;
				}
				for (int j = 0; j < num16; j++)
				{
					materialName[j + num15] = FlanetsKruglyj.materialName1[j];
					for (int m = 0; m < 6; m++)
					{
						array[j + num15, m] = array2[j, m];
					}
				}
				num15 += num16;
			}
			if (typHRKoutput == 1)
			{
				array2 = FlanetsKruglyj.MaterialFlanetsKruglyj(D1, typMaterialD1, number, 1);
				materialCost += FlanetsKruglyj.materialCost1;
				int num17 = 0;
				for (int n = 0; n < 5 && FlanetsKruglyj.materialName1[n] != ""; n++)
				{
					num17++;
				}
				for (int num18 = 0; num18 < num17; num18++)
				{
					materialName[num18 + num15] = FlanetsKruglyj.materialName1[num18];
					for (int num19 = 0; num19 < 6; num19++)
					{
						array[num18 + num15, num19] = array2[num18, num19];
					}
				}
				num15 += num17;
			}
			if (typHRKvrizkaUp == 1)
			{
				array2 = FlanetsKruglyj.MaterialFlanetsKruglyj(D2, typMaterialD2, number, 1);
				materialCost += FlanetsKruglyj.materialCost1;
				int num20 = 0;
				for (int num21 = 0; num21 < 5 && FlanetsKruglyj.materialName1[num21] != ""; num21++)
				{
					num20++;
				}
				for (int num22 = 0; num22 < num20; num22++)
				{
					materialName[num22 + num15] = FlanetsKruglyj.materialName1[num22];
					for (int num23 = 0; num23 < 6; num23++)
					{
						array[num22 + num15, num23] = array2[num22, num23];
					}
				}
				num15 += num20;
			}
			if (typHRKvrizkaDown == 1)
			{
				array2 = FlanetsKruglyj.MaterialFlanetsKruglyj(D3, typMaterialD3, number, 1);
				materialCost += FlanetsKruglyj.materialCost1;
				int num24 = 0;
				for (int num25 = 0; num25 < 5 && FlanetsKruglyj.materialName1[num25] != ""; num25++)
				{
					num24++;
				}
				for (int num26 = 0; num26 < num24; num26++)
				{
					materialName[num26 + num15] = FlanetsKruglyj.materialName1[num26];
					for (int num27 = 0; num27 < 6; num27++)
					{
						array[num26 + num15, num27] = array2[num26, num27];
					}
				}
				num15 += num24;
			}
			if (num15 > 2)
			{
				for (int num28 = 1; num28 < num15; num28++)
				{
					for (int num29 = num28 + 1; num29 < num15; num29++)
					{
						if (materialName[num28] == materialName[num29])
						{
							materialName[num29] = "";
							array[num28, 0] += array[num29, 0];
							array[num29, 0] = 0.0;
							if (materialName[num28] == Consts2.lystStalnyj30.MaterialName)
							{
								array[num28, 1] = Math.Round((array[num28, 1] + array[num29, 1]) / 2.0);
							}
							array[num29, 1] = 0.0;
							array[num28, 2] += array[num29, 2];
							array[num29, 2] = 0.0;
							array[num28, 3] += array[num29, 3];
							array[num29, 3] = 0.0;
							array[num28, 4] += array[num29, 4];
							array[num29, 4] = 0.0;
							array[num28, 5] += array[num29, 5];
							array[num29, 5] = 0.0;
						}
					}
				}
			}
		}
		return array;
	}

	public static double PriceHrestovynaHRK(int D, int D1, int D2, int D3, double L, int l, int l1, int alpha1, double alpha2, int k, int k1, int markaStali, double tovchynaMetalu, int typHRKinput, int typHRKoutput, int typHRKvrizkaUp, int typHRKvrizkaDown, int typMaterialD, int typMaterialD1, int typMaterialD2, int typMaterialD3, int vidbortovka)
	{
		L += (double)vidbortovka;
		double num = 1.0;
		double num2 = Math.Asin((double)(D - D1) / (2.0 * L));
		double a = (double)alpha1 * Math.PI / 180.0 + num2;
		double a2 = alpha2 * Math.PI / 180.0 + num2;
		double num3 = Math.PI * ((double)(D * k + D1 * k1) + (double)(D + D1) * L / 2.0) - Math.PI * (double)D2 * (double)D2 / (4.0 * Math.Sin(a)) - Math.PI * (double)D3 * (double)D3 / (4.0 * Math.Sin(a2));
		num3 /= 1000000.0;
		double num4 = Math.PI * (double)D2 * ((double)l + (double)D2 / (2.0 * Math.Tan(a))) + Math.PI * (double)D3 * ((double)l1 + (double)D3 / (2.0 * Math.Tan(a2)));
		num4 /= 1000000.0;
		materialSpendingCommercialOffer = num3 + num4;
		materialSpendingCommercialOffer *= 1.11;
		switch (markaStali)
		{
		case 1:
			if (tovchynaMetalu == 0.0)
			{
				tovchynaMetalu = ((D > 400) ? ((D <= 800) ? 0.7 : 0.9) : 0.5);
			}
			num = ((!(tovchynaMetalu < 0.65)) ? ((tovchynaMetalu < 0.9) ? 406.0 : 520.0) : 345.0);
			break;
		case 2:
		{
			if (tovchynaMetalu == 0.0)
			{
				tovchynaMetalu = ((D > 400) ? ((D <= 800) ? 0.8 : 1.0) : 0.5);
			}
			double num7 = tovchynaMetalu;
			double num8 = num7;
			num = ((num8 == 0.5) ? 115.0 : ((num8 == 0.8) ? 115.0 : ((num8 == 1.0) ? 134.78 : ((num8 == 1.2) ? 134.78 : ((num8 == 1.5) ? 173.19 : ((num8 == 2.0) ? 173.19 : ((num8 == 2.5) ? 173.19 : ((num8 == 3.0) ? 173.19 : ((num8 == 4.0) ? 173.19 : ((num8 == 5.0) ? 173.19 : ((num8 != 6.0) ? 0.0 : 173.19)))))))))));
			break;
		}
		case 3:
		{
			if (tovchynaMetalu == 0.0)
			{
				tovchynaMetalu = ((D > 400) ? ((D <= 800) ? 0.8 : 1.0) : 0.5);
			}
			double num5 = tovchynaMetalu;
			double num6 = num5;
			num = ((num6 == 0.5) ? 115.0 : ((num6 == 0.8) ? 134.78 : ((num6 == 1.0) ? 173.19 : ((num6 == 1.2) ? 173.19 : ((num6 != 1.5) ? 0.0 : 173.19)))));
			break;
		}
		}
		double num9 = materialSpendingCommercialOffer * num;
		if (materialSpendingCommercialOffer < 0.005)
		{
			materialSpendingCommercialOffer = Math.Round(1000.0 * materialSpendingCommercialOffer) / 1000.0;
		}
		else
		{
			materialSpendingCommercialOffer = Math.Round(100.0 * materialSpendingCommercialOffer) / 100.0;
		}
		if (typHRKinput == 1)
		{
			FlanetsKruglyj.MaterialFlanetsKruglyj(D, typMaterialD, 1, 1);
			num9 += FlanetsKruglyj.priceProduct1;
		}
		if (typHRKoutput == 1)
		{
			FlanetsKruglyj.MaterialFlanetsKruglyj(D1, typMaterialD1, 1, 1);
			num9 += FlanetsKruglyj.priceProduct1;
		}
		if (typHRKvrizkaUp == 1)
		{
			FlanetsKruglyj.MaterialFlanetsKruglyj(D2, typMaterialD2, 1, 1);
			num9 += FlanetsKruglyj.priceProduct1;
		}
		if (typHRKvrizkaDown == 1)
		{
			FlanetsKruglyj.MaterialFlanetsKruglyj(D3, typMaterialD3, 1, 1);
			num9 += FlanetsKruglyj.priceProduct1;
		}
		tovchynaMetaluCommercialOffer = tovchynaMetalu;
		return num9;
	}

	public static double VolumeHrestovynaHRK(int D, int D1, int D2, int D3, double L, int l, int l1, int alpha1, double alpha2, int k, int k1)
	{
		double num = Math.Asin((double)(D - D1) / (2.0 * L));
		double a = (double)alpha1 * Math.PI / 180.0 + num;
		double a2 = alpha2 * Math.PI / 180.0 + num;
		return Math.Round(((double)k + L + (double)k1) * (double)D * ((double)D + ((double)D2 / Math.Tan(a) + (double)l) * Math.Sin(a) + ((double)D3 / Math.Tan(a2) + (double)l1) * Math.Sin(a2)) / 1000000.0) / 1000.0;
	}
}
