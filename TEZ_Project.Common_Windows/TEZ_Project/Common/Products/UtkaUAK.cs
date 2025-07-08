using System;
using TEZ_Project.Common.Helpers;

namespace TEZ_Project.Common.Products;

public static class UtkaUAK
{
	public static string[] materialName = new string[11]
	{
		"", "", "", "", "", "", "", "", "", "",
		""
	};

	public static double materialCost;

	public static double materialSpendingCommercialOffer = 0.0;

	public static double tovchynaMetaluCommercialOffer = 0.0;

	public static double[,] MaterialUtkaUAK(int D, int D1, int L, int k, int k1, int C, int markaStali, double tovchynaMetalu, int typUAK, int typMaterialInput, int typMaterialOutput, int number, int vidbortovka, string aisiType = "430")
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
		L -= k + k1;
		double num8 = (double)D * Math.PI / 4.0;
		double num9 = (double)D1 * Math.PI / 4.0;
		double num10 = ((double)D + (double)D1) * Math.PI / 8.0;
		double num11 = (double)C - (num8 - num9) / 2.0;
		double num12 = num9 * ((double)L - Math.Sqrt((double)L * (double)L - 2.0 * num9 * num11 + num11 * num11)) / (2.0 * num9 - num11);
		double num13 = Math.Sqrt(((double)L - num12) * ((double)L - num12) + num11 * num11);
		double num14 = (double)C + (num8 - num9) / 2.0;
		double num15 = num8 * ((double)L - Math.Sqrt((double)L * (double)L - 2.0 * num8 * num14 + num14 * num14)) / (2.0 * num8 - num14);
		double num16 = Math.Sqrt(((double)L - num15) * ((double)L - num15) + num14 * num14);
		double num17 = (num8 + num9) * (double)L + num11 * num12 + num14 * num15 + 2.0 * (num8 * (double)k + num9 * (double)k1);
		if (L + k + k1 > 2500)
		{
			num17 += 60.0 * (num8 + num9);
		}
		else if (L + k + k1 > 1250)
		{
			num17 += 30.0 * (num8 + num9);
		}
		double num18 = (double)(2 * (k + k1)) + num12 + num13 + num15 + num16;
		double num19 = (num10 + 30.0) * num18;
		if (num18 > 2500.0)
		{
			num19 += 60.0 * (num10 + 30.0);
		}
		else if (num18 > 1250.0)
		{
			num19 += 30.0 * (num10 + 30.0);
		}
		array[0, 0] = (num17 + num19) * 1.05 / 1000000.0;
		num17 = ((num8 + num9) * (double)L + num11 * num12 + num14 * num15 + 2.0 * (num8 * (double)k + num9 * (double)k1) + (num10 + 50.0 + 10.0) * num18) / 1000000.0;
		array[0, 1] = Math.Round((array[0, 0] / num17 - 1.0) * 100.0) / 100.0;
		if (100.0 * array[0, 1] > 20.0)
		{
			array[0, 1] = 0.2;
			array[0, 0] = num17 * (1.0 + array[0, 1]);
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
		materialCost = array[0, 0] * num3;
		if (typUAK == 2 || typUAK == 3)
		{
			double[,] array2 = new double[5, 6];
			array2 = ((typUAK == 2) ? FlanetsKruglyj.MaterialFlanetsKruglyj(D, typMaterialInput, number, 1) : FlanetsKruglyj.MaterialFlanetsKruglyj(D1, typMaterialOutput, number, 1));
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
		else if (typUAK == 1)
		{
			double[,] array3 = new double[5, 6];
			array3 = FlanetsKruglyj.MaterialFlanetsKruglyj(D, typMaterialInput, number, 1);
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
			array3 = FlanetsKruglyj.MaterialFlanetsKruglyj(D1, typMaterialOutput, number, 1);
			materialCost += FlanetsKruglyj.materialCost1;
			for (int n = 0; n < 5; n++)
			{
				materialName[n + 1 + 5] = FlanetsKruglyj.materialName1[n];
				for (int num20 = 0; num20 < 6; num20++)
				{
					array[n + 1 + 5, num20] = array3[n, num20];
				}
			}
			int num21 = 0;
			for (int num22 = 1; num22 < 6 && materialName[num22] != ""; num22++)
			{
				num21++;
			}
			int num23 = 0;
			for (int num24 = 6; num24 < 11 && materialName[num24] != ""; num24++)
			{
				num23++;
			}
			for (int num25 = 0; num25 < num21; num25++)
			{
				for (int num26 = 0; num26 < num23; num26++)
				{
					if (materialName[num25 + 1] == materialName[num26 + 6])
					{
						materialName[num26 + 6] = "";
						array[num25 + 1, 0] += array[num26 + 6, 0];
						array[num26 + 6, 0] = 0.0;
						if (materialName[num25 + 1] == Consts2.lystStalnyj30.MaterialName)
						{
							array[num25 + 1, 1] = Math.Round((array[num25 + 1, 1] + array[num26 + 6, 1]) / 2.0);
						}
						array[num26 + 6, 1] = 0.0;
						array[num25 + 1, 2] += array[num26 + 6, 2];
						array[num26 + 6, 2] = 0.0;
						array[num25 + 1, 3] += array[num26 + 6, 3];
						array[num26 + 6, 3] = 0.0;
						array[num25 + 1, 4] += array[num26 + 6, 4];
						array[num26 + 6, 4] = 0.0;
						array[num25 + 1, 5] += array[num26 + 6, 5];
						array[num26 + 6, 5] = 0.0;
					}
				}
			}
		}
		return array;
	}

	public static double PriceUtkaUAK(int D, int D1, int L, int k, int k1, int C, int markaStali, double tovchynaMetalu, int typUAK, int typMaterialInput, int typMaterialOutput, int vidbortovka)
	{
		double num = 1.0;
		int num2 = ((D > D1) ? D : D1);
		L += vidbortovka;
		L -= k + k1;
		double num3 = (double)D * Math.PI / 4.0;
		double num4 = (double)D1 * Math.PI / 4.0;
		double num5 = ((double)D + (double)D1) * Math.PI / 8.0;
		double num6 = (double)C - (num3 - num4) / 2.0;
		double num7 = num4 * ((double)L - Math.Sqrt((double)L * (double)L - 2.0 * num4 * num6 + num6 * num6)) / (2.0 * num4 - num6);
		double num8 = Math.Sqrt(((double)L - num7) * ((double)L - num7) + num6 * num6);
		double num9 = (double)C + (num3 - num4) / 2.0;
		double num10 = num3 * ((double)L - Math.Sqrt((double)L * (double)L - 2.0 * num3 * num9 + num9 * num9)) / (2.0 * num3 - num9);
		double num11 = Math.Sqrt(((double)L - num10) * ((double)L - num10) + num9 * num9);
		double num12 = (double)(2 * (k + k1)) + num7 + num8 + num10 + num11;
		materialSpendingCommercialOffer = ((num3 + num4) * (double)L + num6 * num7 + num9 * num10 + 2.0 * (num3 * (double)k + num4 * (double)k1) + num5 * num12) / 1000000.0;
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
			double num15 = tovchynaMetalu;
			double num16 = num15;
			num = ((num16 == 0.5) ? 115.0 : ((num16 == 0.8) ? 115.0 : ((num16 == 1.0) ? 134.78 : ((num16 == 1.2) ? 134.78 : ((num16 == 1.5) ? 173.19 : ((num16 == 2.0) ? 173.19 : ((num16 == 2.5) ? 173.19 : ((num16 == 3.0) ? 173.19 : ((num16 == 4.0) ? 173.19 : ((num16 == 5.0) ? 173.19 : ((num16 != 6.0) ? 0.0 : 173.19)))))))))));
			break;
		}
		case 3:
		{
			if (tovchynaMetalu == 0.0)
			{
				tovchynaMetalu = ((num2 > 400) ? ((num2 <= 800) ? 0.8 : 1.0) : 0.5);
			}
			double num13 = tovchynaMetalu;
			double num14 = num13;
			num = ((num14 == 0.5) ? 115.0 : ((num14 == 0.8) ? 134.78 : ((num14 == 1.0) ? 173.19 : ((num14 == 1.2) ? 173.19 : ((num14 != 1.5) ? 0.0 : 173.19)))));
			break;
		}
		}
		double num17 = materialSpendingCommercialOffer * num;
		if (materialSpendingCommercialOffer < 0.005)
		{
			materialSpendingCommercialOffer = Math.Round(1000.0 * materialSpendingCommercialOffer) / 1000.0;
		}
		else
		{
			materialSpendingCommercialOffer = Math.Round(100.0 * materialSpendingCommercialOffer) / 100.0;
		}
		if (typUAK == 1 || typUAK == 2)
		{
			FlanetsKruglyj.MaterialFlanetsKruglyj(D, typMaterialInput, 1, 1);
			num17 += FlanetsKruglyj.priceProduct1;
		}
		if (typUAK == 1 || typUAK == 3)
		{
			FlanetsKruglyj.MaterialFlanetsKruglyj(D1, typMaterialOutput, 1, 1);
			num17 += FlanetsKruglyj.priceProduct1;
		}
		tovchynaMetaluCommercialOffer = tovchynaMetalu;
		return num17;
	}

	public static double VolumeUtkaUAK(int D, int D1, int L, int C)
	{
		int num = ((D > D1) ? D : D1);
		return Math.Round((double)num * (double)((D + D1) / 2 + C) * (double)L / 1000000.0) / 1000.0;
	}
}
