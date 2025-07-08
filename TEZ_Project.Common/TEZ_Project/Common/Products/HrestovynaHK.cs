using System;
using TEZ_Project.Common.Data;
using TEZ_Project.Common.Helpers;
using TEZ_Project;

namespace TEZ_Project.Common.Products;

public static class HrestovynaHK
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

	public static double[,] MaterialHrestovynaHK(int D, int D1, int D2, double L, int l, int l1, int alpha1, double alpha2, int markaStali, double tovchynaMetalu, int typHKinput, int typHKoutput, int typHKvrizkaUp, int typHKvrizkaDown, int typMaterialD, int typMaterialD1, int typMaterialD2, int typMaterialD3, int number, int vidbortovka, string aisiType = "430")
	{
		double[,] array = new double[26, 6];
		double num = 0.0;
		double num2 = 0.0;
		materialCost = 0.0;
		materialName = new string[26]
		{
			"", "", "", "", "", "", "", "", "", "",
			"", "", "", "", "", "", "", "", "", "",
			"", "", "", "", "", ""
		};
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
		double num7 = Math.Sin(Math.PI * (double)alpha1 / 180.0);
		double num8 = Math.Tan(Math.PI * (double)alpha1 / 180.0);
		double num9 = Math.Sin(Math.PI * alpha2 / 180.0);
		double num10 = Math.Tan(Math.PI * alpha2 / 180.0);
		double num11 = Math.PI * (double)D + 30.0;
		double num12 = num11 * L;
		if (L > 2500.0)
		{
			num12 += 60.0 * num11;
		}
		else if (L > 1250.0)
		{
			num12 += 30.0 * num11;
		}
		if (num11 > 2500.0)
		{
			num12 += 60.0 * L;
		}
		else if (num11 > 1250.0)
		{
			num12 += 30.0 * L;
		}
		double num13 = ((double)D - Math.Sqrt((double)D * (double)D - (double)(D1 * D1))) / 2.0;
		double num14 = (double)D1 / num8;
		double num15 = ((num14 > num13) ? num14 : num13);
		double num16 = (Math.PI * (double)D1 + 10.0) * ((double)l + num15 + 10.0);
		if (Math.PI * (double)D1 + 10.0 > 2500.0)
		{
			num16 += 60.0 * ((double)l + num15 + 10.0);
		}
		else if (Math.PI * (double)D1 + 10.0 > 1250.0)
		{
			num16 += 30.0 * ((double)l + num15 + 10.0);
		}
		num13 = ((double)D - Math.Sqrt((double)D * (double)D - (double)(D2 * D2))) / 2.0;
		num14 = (double)D2 / num10;
		num15 = ((num14 > num13) ? num14 : num13);
		double num17 = (Math.PI * (double)D2 + 10.0) * ((double)l + num15 + 10.0);
		if (Math.PI * (double)D2 + 10.0 > 2500.0)
		{
			num17 += 60.0 * ((double)l + num15 + 10.0);
		}
		else if (Math.PI * (double)D2 + 10.0 > 1250.0)
		{
			num17 += 30.0 * ((double)l + num15 + 10.0);
		}
		array[0, 0] = (num12 + num16 + num17) * 1.05 / 1000000.0;
		num12 = (Math.PI * (double)D + 30.0) * L + (Math.PI * (double)D1 + 30.0) * ((double)l + (double)D1 / (2.0 * num8) + 30.0) + (Math.PI * (double)D2 + 30.0) * ((double)l1 + (double)D2 / (2.0 * num10) + 30.0);
		num12 -= Math.PI * (double)D1 * (double)D1 / (4.0 * num7) + Math.PI * (double)D2 * (double)D2 / (4.0 * num9);
		num12 /= 1000000.0;
		double num18 = Math.Round((array[0, 0] / num12 - 1.0) * 100.0);
		if (num18 > 100.0)
		{
			num18 = 100.0;
			array[0, 0] = num12 * (1.0 + num18 / 100.0);
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
		materialCost = array[0, 0] * num2;
		if (typHKinput == 1 || typHKoutput == 1 || typHKvrizkaUp == 1 || typHKvrizkaDown == 1)
		{
			double[,] array2 = new double[5, 6];
			int num19 = 1;
			if (typHKinput == 1)
			{
				array2 = FlanetsKruglyj.MaterialFlanetsKruglyj(D, typMaterialD, number, 1);
				materialCost += FlanetsKruglyj.materialCost1;
				int num20 = 0;
				for (int i = 0; i < 5 && FlanetsKruglyj.materialName1[i] != ""; i++)
				{
					num20++;
				}
				for (int j = 0; j < num20; j++)
				{
					materialName[j + num19] = FlanetsKruglyj.materialName1[j];
					for (int k = 0; k < 6; k++)
					{
						array[j + num19, k] = array2[j, k];
					}
				}
				num19 += num20;
			}
			if (typHKoutput == 1)
			{
				array2 = FlanetsKruglyj.MaterialFlanetsKruglyj(D, typMaterialD1, number, 1);
				materialCost += FlanetsKruglyj.materialCost1;
				int num21 = 0;
				for (int m = 0; m < 5 && FlanetsKruglyj.materialName1[m] != ""; m++)
				{
					num21++;
				}
				for (int n = 0; n < num21; n++)
				{
					materialName[n + num19] = FlanetsKruglyj.materialName1[n];
					for (int num22 = 0; num22 < 6; num22++)
					{
						array[n + num19, num22] = array2[n, num22];
					}
				}
				num19 += num21;
			}
			if (typHKvrizkaUp == 1)
			{
				array2 = FlanetsKruglyj.MaterialFlanetsKruglyj(D1, typMaterialD2, number, 1);
				materialCost += FlanetsKruglyj.materialCost1;
				int num23 = 0;
				for (int num24 = 0; num24 < 5 && FlanetsKruglyj.materialName1[num24] != ""; num24++)
				{
					num23++;
				}
				for (int num25 = 0; num25 < num23; num25++)
				{
					materialName[num25 + num19] = FlanetsKruglyj.materialName1[num25];
					for (int num26 = 0; num26 < 6; num26++)
					{
						array[num25 + num19, num26] = array2[num25, num26];
					}
				}
				num19 += num23;
			}
			if (typHKvrizkaDown == 1)
			{
				array2 = FlanetsKruglyj.MaterialFlanetsKruglyj(D2, typMaterialD3, number, 1);
				materialCost += FlanetsKruglyj.materialCost1;
				int num27 = 0;
				for (int num28 = 0; num28 < 5 && FlanetsKruglyj.materialName1[num28] != ""; num28++)
				{
					num27++;
				}
				for (int num29 = 0; num29 < num27; num29++)
				{
					materialName[num29 + num19] = FlanetsKruglyj.materialName1[num29];
					for (int num30 = 0; num30 < 6; num30++)
					{
						array[num29 + num19, num30] = array2[num29, num30];
					}
				}
				num19 += num27;
			}
			if (num19 > 2)
			{
				for (int num31 = 1; num31 < num19; num31++)
				{
					for (int num32 = num31 + 1; num32 < num19; num32++)
					{
						if (materialName[num31] == materialName[num32])
						{
							materialName[num32] = "";
							array[num31, 0] += array[num32, 0];
							array[num32, 0] = 0.0;
							if (materialName[num31] == Consts2.lystStalnyj30.MaterialName)
							{
								array[num31, 1] = Math.Round((array[num31, 1] + array[num32, 1]) / 2.0);
							}
							array[num32, 1] = 0.0;
							array[num31, 2] += array[num32, 2];
							array[num32, 2] = 0.0;
							array[num31, 3] += array[num32, 3];
							array[num32, 3] = 0.0;
							array[num31, 4] += array[num32, 4];
							array[num32, 4] = 0.0;
							array[num31, 5] += array[num32, 5];
							array[num32, 5] = 0.0;
						}
					}
				}
			}
		}
		return array;
	}

	public static double PriceHrestovynaHK(int D, int D1, int D2, double L, int l, int l1, int alpha1, double alpha2, int markaStali, double tovchynaMetalu, int typHKinput, int typHKoutput, int typHKvrizkaUp, int typHKvrizkaDown, int typMaterialD, int typMaterialD1, int typMaterialD2, int typMaterialD3, int vidbortovka)
	{
		double num = 1.0;
		double num2 = Math.Sin(Math.PI * (double)alpha1 / 180.0);
		double num3 = Math.Tan(Math.PI * (double)alpha1 / 180.0);
		double num4 = Math.Sin(Math.PI * alpha2 / 180.0);
		double num5 = Math.Tan(Math.PI * alpha2 / 180.0);
		double num6 = (double)D * L - (double)(D1 * D1) / (4.0 * num2) - (double)(D2 * D2) / (4.0 * num4);
		double num7 = (double)D1 * ((double)l + (double)D1 / (2.0 * num3)) + (double)D2 * ((double)l1 + (double)D2 / (2.0 * num5));
		L += (double)vidbortovka;
		materialSpendingCommercialOffer = Math.PI * (num6 + num7) / 1000000.0;
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
			double num10 = tovchynaMetalu;
			double num11 = num10;
			num = ((num11 == 0.5) ? 115.0 : ((num11 == 0.8) ? 115.0 : ((num11 == 1.0) ? 134.78 : ((num11 == 1.2) ? 134.78 : ((num11 == 1.5) ? 173.19 : ((num11 == 2.0) ? 173.19 : ((num11 == 2.5) ? 173.19 : ((num11 == 3.0) ? 173.19 : ((num11 == 4.0) ? 173.19 : ((num11 == 5.0) ? 173.19 : ((num11 != 6.0) ? 0.0 : 173.19)))))))))));
			break;
		}
		case 3:
		{
			if (tovchynaMetalu == 0.0)
			{
				tovchynaMetalu = ((D > 400) ? ((D <= 800) ? 0.8 : 1.0) : 0.5);
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
		if (typHKinput == 1)
		{
			FlanetsKruglyj.MaterialFlanetsKruglyj(D, typMaterialD, 1, 1);
			num12 += FlanetsKruglyj.priceProduct1;
		}
		if (typHKoutput == 1)
		{
			FlanetsKruglyj.MaterialFlanetsKruglyj(D, typMaterialD1, 1, 1);
			num12 += FlanetsKruglyj.priceProduct1;
		}
		if (typHKvrizkaUp == 1)
		{
			FlanetsKruglyj.MaterialFlanetsKruglyj(D1, typMaterialD2, 1, 1);
			num12 += FlanetsKruglyj.priceProduct1;
		}
		if (typHKvrizkaDown == 1)
		{
			FlanetsKruglyj.MaterialFlanetsKruglyj(D2, typMaterialD3, 1, 1);
			num12 += FlanetsKruglyj.priceProduct1;
		}
		tovchynaMetaluCommercialOffer = tovchynaMetalu;
		return num12;
	}

	public static double VolumeHrestovynaHK(int D, int D1, int D2, double L, int l, int l1, int alpha1, double alpha2)
	{
		return Math.Round(L * (double)D * ((double)D + ((double)D1 / Math.Tan(alpha1) + (double)l) * Math.Sin(alpha1) + ((double)D2 / Math.Tan(alpha2) + (double)l1) * Math.Sin(alpha2)) / 1000000.0) / 1000.0;
	}
}
