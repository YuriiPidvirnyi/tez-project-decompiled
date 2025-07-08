using System;
using TEZ_Project.Common.Helpers;

using TEZ_Project.Common.Data;
using TEZ_Project;

namespace TEZ_Project.Common.Products;

public static class TrijnykTSHK
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

	public static double[,] MaterialTrijnykTSHK(int D, int D1, int L, int l, double alpha, int markaStali, double tovchynaMetalu, int typTSHKinput1, int typTSHKinput2, int typTSHKvrizka, int typMaterialD, int typMaterialD1, int number, int vidbortovka, string aisiType = "430")
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
		double num10 = 4.0 * num8 + 30.0;
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
		double num12 = ((double)D - Math.Sqrt((double)D * (double)D - (double)(D1 * D1))) / 2.0;
		double num13 = (double)D1 / Math.Tan(Math.PI * alpha / 180.0);
		double num14 = ((num13 > num12) ? num13 : num12);
		num11 += (Math.PI * (double)D1 + 10.0) * ((double)l + num14 + 10.0);
		if (Math.PI * (double)D1 + 10.0 > 2500.0)
		{
			num11 += 60.0 * ((double)l + num14 + 10.0);
		}
		else if (Math.PI * (double)D1 + 10.0 > 1250.0)
		{
			num11 += 30.0 * ((double)l + num14 + 10.0);
		}
		double num15 = Math.Tan(alpha * Math.PI / 180.0);
		array[0, 0] = num11 * 1.05 / 1000000.0;
		double num16 = Math.Sin(alpha * Math.PI / 180.0);
		num11 = ((4.0 * num8 + 30.0) * (double)L - num9 * num9 / num16 + (4.0 * num9 + 30.0) * ((double)l + num9 / (2.0 * num15) + 12.0)) / 1000000.0;
		double num17 = Math.Round((array[0, 0] / num11 - 1.0) * 100.0);
		if (num17 > 100.0)
		{
			num17 = 100.0;
			array[0, 0] = num11 * (1.0 + num17 / 100.0);
		}
		array[0, 1] = num17 / 100.0;
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
		if (typTSHKinput1 == 1 || typTSHKinput2 == 1 || typTSHKvrizka == 1)
		{
			double[,] array2 = new double[5, 6];
			int num18 = 1;
			if (typTSHKinput1 == 1)
			{
				array2 = FlanetsKruglyj.MaterialFlanetsKruglyj(D, typMaterialD, number, 1);
				materialCost += FlanetsKruglyj.materialCost1;
				int num19 = 0;
				for (int i = 0; i < 5 && FlanetsKruglyj.materialName1[i] != ""; i++)
				{
					num19++;
				}
				for (int j = 0; j < num19; j++)
				{
					materialName[j + num18] = FlanetsKruglyj.materialName1[j];
					for (int k = 0; k < 6; k++)
					{
						array[j + num18, k] = array2[j, k];
					}
				}
				num18 += num19;
			}
			if (typTSHKinput2 == 1)
			{
				array2 = FlanetsKruglyj.MaterialFlanetsKruglyj(D, typMaterialD, number, 1);
				materialCost += FlanetsKruglyj.materialCost1;
				int num20 = 0;
				for (int m = 0; m < 5 && FlanetsKruglyj.materialName1[m] != ""; m++)
				{
					num20++;
				}
				for (int n = 0; n < num20; n++)
				{
					materialName[n + num18] = FlanetsKruglyj.materialName1[n];
					for (int num21 = 0; num21 < 6; num21++)
					{
						array[n + num18, num21] = array2[n, num21];
					}
				}
				num18 += num20;
			}
			if (typTSHKvrizka == 1)
			{
				array2 = FlanetsKruglyj.MaterialFlanetsKruglyj(D1, typMaterialD1, number, 1);
				materialCost += FlanetsKruglyj.materialCost1;
				int num22 = 0;
				for (int num23 = 0; num23 < 5 && FlanetsKruglyj.materialName1[num23] != ""; num23++)
				{
					num22++;
				}
				for (int num24 = 0; num24 < num22; num24++)
				{
					materialName[num24 + num18] = FlanetsKruglyj.materialName1[num24];
					for (int num25 = 0; num25 < 6; num25++)
					{
						array[num24 + num18, num25] = array2[num24, num25];
					}
				}
				num18 += num22;
			}
			if (num18 > 2)
			{
				for (int num26 = 1; num26 < num18; num26++)
				{
					for (int num27 = num26 + 1; num27 < num18; num27++)
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

	public static double PriceTrijnykTSHK(int D, int D1, int L, int l, double alpha, int markaStali, double tovchynaMetalu, int typTSHKinput1, int typTSHKinput2, int typTSHKvrizka, int typMaterialD, int typMaterialD1, int vidbortovka)
	{
		double num = 1.0;
		int num2 = ((D > D1) ? D : D1);
		double num3 = Math.Sin(alpha * Math.PI / 180.0);
		double num4 = Math.Tan(alpha * Math.PI / 180.0);
		double num5 = Math.PI * (double)D / 4.0;
		double num6 = Math.PI * (double)D1 / 4.0;
		L += vidbortovka;
		materialSpendingCommercialOffer = (4.0 * num5 * (double)L - num6 * num6 / num3 + 2.0 * num6 * (2.0 * (double)l + num6 / num4)) / 1000000.0;
		materialSpendingCommercialOffer *= 1.06;
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
			double num9 = tovchynaMetalu;
			double num10 = num9;
			num = ((num10 == 0.5) ? 115.0 : ((num10 == 0.8) ? 115.0 : ((num10 == 1.0) ? 134.78 : ((num10 == 1.2) ? 134.78 : ((num10 == 1.5) ? 173.19 : ((num10 == 2.0) ? 173.19 : ((num10 == 2.5) ? 173.19 : ((num10 == 3.0) ? 173.19 : ((num10 == 4.0) ? 173.19 : ((num10 == 5.0) ? 173.19 : ((num10 != 6.0) ? 0.0 : 173.19)))))))))));
			break;
		}
		case 3:
		{
			if (tovchynaMetalu == 0.0)
			{
				tovchynaMetalu = ((num2 > 400) ? ((num2 <= 800) ? 0.8 : 1.0) : 0.5);
			}
			double num7 = tovchynaMetalu;
			double num8 = num7;
			num = ((num8 == 0.5) ? 115.0 : ((num8 == 0.8) ? 134.78 : ((num8 == 1.0) ? 173.19 : ((num8 == 1.2) ? 173.19 : ((num8 != 1.5) ? 0.0 : 173.19)))));
			break;
		}
		}
		double num11 = materialSpendingCommercialOffer * num;
		if (materialSpendingCommercialOffer < 0.005)
		{
			materialSpendingCommercialOffer = Math.Round(1000.0 * materialSpendingCommercialOffer) / 1000.0;
		}
		else
		{
			materialSpendingCommercialOffer = Math.Round(100.0 * materialSpendingCommercialOffer) / 100.0;
		}
		if (typTSHKinput1 == 1)
		{
			FlanetsKruglyj.MaterialFlanetsKruglyj(D, typMaterialD, 1, 1);
			num11 += FlanetsKruglyj.priceProduct1;
		}
		if (typTSHKinput2 == 1)
		{
			FlanetsKruglyj.MaterialFlanetsKruglyj(D, typMaterialD, 1, 1);
			num11 += FlanetsKruglyj.priceProduct1;
		}
		if (typTSHKvrizka == 1)
		{
			FlanetsKruglyj.MaterialFlanetsKruglyj(D1, typMaterialD1, 1, 1);
			num11 += FlanetsKruglyj.priceProduct1;
		}
		tovchynaMetaluCommercialOffer = tovchynaMetalu;
		return num11;
	}

	public static double VolumeTrijnykTSHK(int D, int D1, int L, int l, double alpha)
	{
		double num = Math.Tan(alpha * Math.PI / 180.0);
		double num2 = Math.Cos(alpha * Math.PI / 180.0);
		return Math.Round((double)L * (double)D * ((double)D + ((double)D1 / num + (double)l) * num2) / 1000000.0) / 1000.0;
	}
}
