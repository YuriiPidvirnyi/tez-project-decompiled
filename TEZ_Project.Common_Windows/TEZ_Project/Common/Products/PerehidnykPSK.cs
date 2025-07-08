using System;
using TEZ_Project.Common.Helpers;

namespace TEZ_Project.Common.Products;

public static class PerehidnykPSK
{
	public static string[] materialName = new string[11]
	{
		"", "", "", "", "", "", "", "", "", "",
		""
	};

	public static double materialCost;

	public static double materialSpendingCommercialOffer = 0.0;

	public static double tovchynaMetaluCommercialOffer = 0.0;

	public static double[,] MaterialPerehidnykPSK(int D, int D1, int L, int k, int k1, int markaStali, double tovchynaMetalu, int typPSK, int typMaterialD, int typMaterialD1, int number, int vidbortovka, string aisiType = "430")
	{
		double[,] array = new double[11, 6];
		double num = 0.0;
		int num2 = ((D > D1) ? D : D1);
		double num3 = 0.0;
		double num4 = 0.0;
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
								}
							}
							else
							{
								materialName[0] = Consts2.lystOchynkovanyj09.MaterialName;
								num4 = Consts2.lystOchynkovanyj09.Price;
							}
						}
						else
						{
							materialName[0] = Consts2.lystOchynkovanyj07.MaterialName;
							num4 = Consts2.lystOchynkovanyj07.Price;
						}
					}
					else
					{
						materialName[0] = Consts2.lystOchynkovanyj068.MaterialName;
						num4 = Consts2.lystOchynkovanyj068.Price;
					}
				}
				else
				{
					materialName[0] = Consts2.lystOchynkovanyj065.MaterialName;
					num4 = Consts2.lystOchynkovanyj065.Price;
				}
			}
			else
			{
				materialName[0] = Consts2.lystOchynkovanyj05.MaterialName;
				num4 = Consts2.lystOchynkovanyj05.Price;
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
												}
											}
											else
											{
												materialName[0] = Consts2.lystStalnyj40.MaterialName;
												num4 = Consts2.lystStalnyj40.Price;
											}
										}
										else
										{
											materialName[0] = Consts2.lystStalnyj30.MaterialName;
											num4 = Consts2.lystStalnyj30.Price;
										}
									}
									else
									{
										materialName[0] = Consts2.lystStalnyj25.MaterialName;
										num4 = Consts2.lystStalnyj25.Price;
									}
								}
								else
								{
									materialName[0] = Consts2.lystStalnyj20.MaterialName;
									num4 = Consts2.lystStalnyj20.Price;
								}
							}
							else
							{
								materialName[0] = Consts2.lystStalnyj15.MaterialName;
								num4 = Consts2.lystStalnyj15.Price;
							}
						}
						else
						{
							materialName[0] = Consts2.lystStalnyj12.MaterialName;
							num4 = Consts2.lystStalnyj12.Price;
						}
					}
					else
					{
						materialName[0] = Consts2.lystStalnyj10.MaterialName;
						num4 = Consts2.lystStalnyj10.Price;
					}
				}
				else
				{
					materialName[0] = Consts2.lystStalnyj08.MaterialName;
					num4 = Consts2.lystStalnyj08.Price;
				}
			}
			else
			{
				materialName[0] = Consts2.lystStalnyj05.MaterialName;
				num4 = Consts2.lystStalnyj05.Price;
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
			num4 = lystNerzavijuchyj.Price;
			break;
		}
		}
		int num9;
		if (D > D1)
		{
			num2 = D;
			num9 = D1;
		}
		else
		{
			num2 = D1;
			num9 = D;
		}
		double num10 = Math.Sqrt((double)L * (double)L + (double)((D - D1) * (D - D1) / 4));
		double num11 = Math.PI * (double)(num2 - num9) / (2.0 * num10);
		array[0, 0] = (num10 * ((double)num2 - (double)num9 * Math.Cos(num11)) / (double)(num2 - num9) + (double)k + (double)k1) * (2.0 * num10 * (double)num2 * Math.Sin(num11) / (double)(num2 - num9) + 30.0) * 1.05 / 1000000.0;
		double num12 = (Math.PI * (double)(D + D1) + 60.0) * num10 / 2.0;
		num12 += (Math.PI * (double)D + 30.0) * (double)k + (Math.PI * (double)D1 + 30.0) * (double)k1;
		num12 /= 1000000.0;
		num3 = Math.Round((array[0, 0] / num12 - 1.0) * 100.0);
		if (num3 > 20.0)
		{
			num3 = 20.0;
			array[0, 0] = num12 * (1.0 + num3 / 100.0);
		}
		array[0, 1] = num3 / 100.0;
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
		if (typPSK == 2 || typPSK == 3 || typPSK == 10)
		{
			double[,] array2 = new double[5, 6];
			array2 = ((typPSK == 2) ? FlanetsKruglyj.MaterialFlanetsKruglyj(D, typMaterialD, number, 1) : FlanetsKruglyj.MaterialFlanetsKruglyj(D1, typMaterialD1, number, 1));
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
		else if (typPSK == 1)
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
				for (int num13 = 0; num13 < 6; num13++)
				{
					array[n + 1 + 5, num13] = array3[n, num13];
				}
			}
			int num14 = 0;
			for (int num15 = 1; num15 < 6 && materialName[num15] != ""; num15++)
			{
				num14++;
			}
			int num16 = 0;
			for (int num17 = 6; num17 < 11 && materialName[num17] != ""; num17++)
			{
				num16++;
			}
			for (int num18 = 0; num18 < num14; num18++)
			{
				for (int num19 = 0; num19 < num16; num19++)
				{
					if (materialName[num18 + 1] == materialName[num19 + 6])
					{
						materialName[num19 + 6] = "";
						array[num18 + 1, 0] += array[num19 + 6, 0];
						array[num19 + 6, 0] = 0.0;
						if (materialName[num18 + 1] == Consts2.lystStalnyj30.MaterialName)
						{
							array[num18 + 1, 1] = Math.Round((array[num18 + 1, 1] + array[num19 + 6, 1]) / 2.0);
						}
						array[num19 + 6, 1] = 0.0;
						array[num18 + 1, 2] += array[num19 + 6, 2];
						array[num19 + 6, 2] = 0.0;
						array[num18 + 1, 3] += array[num19 + 6, 3];
						array[num19 + 6, 3] = 0.0;
						array[num18 + 1, 4] += array[num19 + 6, 4];
						array[num19 + 6, 4] = 0.0;
						array[num18 + 1, 5] += array[num19 + 6, 5];
						array[num19 + 6, 5] = 0.0;
					}
				}
			}
		}
		return array;
	}

	public static double PricePerehidnykPSK(int D, int D1, int L, int k, int k1, int markaStali, double tovchynaMetalu, int typPSK, int typMaterialD, int typMaterialD1, int vidbortovka)
	{
		double num = 1.0;
		int num2 = ((D > D1) ? D : D1);
		L += vidbortovka;
		double num3 = Math.Sqrt((double)L * (double)L + (double)((D - D1) * (D - D1) / 4));
		materialSpendingCommercialOffer = Math.PI * ((double)(D + D1) * num3 / 2.0 + (double)(D * k) + (double)(D1 * k1)) / 1000000.0;
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
		if (typPSK == 1 || typPSK == 2 || typPSK == 10)
		{
			FlanetsKruglyj.MaterialFlanetsKruglyj(D, typMaterialD, 1, 1);
			num8 += FlanetsKruglyj.priceProduct1;
		}
		if (typPSK == 1 || typPSK == 3)
		{
			FlanetsKruglyj.MaterialFlanetsKruglyj(D1, typMaterialD1, 1, 1);
			num8 += FlanetsKruglyj.priceProduct1;
		}
		tovchynaMetaluCommercialOffer = tovchynaMetalu;
		return num8;
	}

	public static double VolumePerehidnykPSK(int D, int D1, int L, int k, int k1)
	{
		double num = ((D > D1) ? D : D1);
		return Math.Round(num * num * (double)(L + k + k1) / 1000000.0) / 1000.0;
	}
}
