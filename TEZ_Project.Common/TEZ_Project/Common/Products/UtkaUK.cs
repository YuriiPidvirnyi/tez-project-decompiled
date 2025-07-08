using System;
using TEZ_Project.Common.Helpers;
using TEZ_Project;

namespace TEZ_Project.Common.Products;

public static class UtkaUK
{
	public static string[] materialName = new string[11]
	{
		"", "", "", "", "", "", "", "", "", "",
		""
	};

	public static double materialCost;

	public static double materialSpendingCommercialOffer = 0.0;

	public static double tovchynaMetaluCommercialOffer = 0.0;

	public static double[,] MaterialUtkaUK(int D, int L, int k, int k1, int c, int markaStali, double tovchynaMetalu, int typUK, int typMaterialInput, int typMaterialOutput, int number, int vidbortovka, string aisiType = "430")
	{
		double[,] array = new double[11, 6];
		double num = 0.0;
		double num2 = 0.0;
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
		L -= k + k1;
		double num7 = (double)D * ((double)L - Math.Sqrt((double)L * (double)L - (double)(2 * D * c) + (double)(c * c))) / (double)(2 * D - c);
		double num8 = Math.Sqrt(((double)L - num7) * ((double)L - num7) + (double)(c * c));
		double num9 = (Math.PI * (double)D + 30.0) * (num7 + num8 + (double)k + (double)k1);
		array[0, 0] = num9;
		if (Math.PI * (double)D + 30.0 > 2500.0)
		{
			array[0, 0] += 60.0 * (num7 + num8 + (double)k + (double)k1);
		}
		else if (Math.PI * (double)D + 30.0 > 1250.0)
		{
			array[0, 0] += 30.0 * (num7 + num8 + (double)k + (double)k1);
		}
		if (num7 + num8 + (double)k + (double)k1 > 2500.0)
		{
			array[0, 0] += 60.0 * (Math.PI * (double)D + 30.0);
		}
		else if (num7 + num8 + (double)k + (double)k1 > 1250.0)
		{
			array[0, 0] += 30.0 * (Math.PI * (double)D + 30.0);
		}
		array[0, 0] *= 1.0500000000000001E-06;
		num9 = (Math.PI * (double)D + 30.0) * (num7 + num8 + (double)k + (double)k1) / 1000000.0;
		array[0, 1] = Math.Round((array[0, 0] / num9 - 1.0) * 100.0) / 100.0;
		if (100.0 * array[0, 1] > 20.0)
		{
			array[0, 1] = 0.2;
			array[0, 0] = num9 * (1.0 + array[0, 1]);
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
		materialCost = array[0, 0] * num2;
		if (typUK == 2 || typUK == 3)
		{
			double[,] array2 = new double[5, 6];
			array2 = ((typUK == 2) ? FlanetsKruglyj.MaterialFlanetsKruglyj(D, typMaterialInput, number, 1) : FlanetsKruglyj.MaterialFlanetsKruglyj(D, typMaterialOutput, number, 1));
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
		else if (typUK == 1)
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
			array3 = FlanetsKruglyj.MaterialFlanetsKruglyj(D, typMaterialOutput, number, 1);
			materialCost += FlanetsKruglyj.materialCost1;
			for (int n = 0; n < 5; n++)
			{
				materialName[n + 1 + 5] = FlanetsKruglyj.materialName1[n];
				for (int num10 = 0; num10 < 6; num10++)
				{
					array[n + 1 + 5, num10] = array3[n, num10];
				}
			}
			int num11 = 0;
			for (int num12 = 1; num12 < 6 && materialName[num12] != ""; num12++)
			{
				num11++;
			}
			int num13 = 0;
			for (int num14 = 6; num14 < 11 && materialName[num14] != ""; num14++)
			{
				num13++;
			}
			for (int num15 = 0; num15 < num11; num15++)
			{
				for (int num16 = 0; num16 < num13; num16++)
				{
					if (materialName[num15 + 1] == materialName[num16 + 6])
					{
						materialName[num16 + 6] = "";
						array[num15 + 1, 0] += array[num16 + 6, 0];
						array[num16 + 6, 0] = 0.0;
						if (materialName[num15 + 1] == Consts2.lystStalnyj30.MaterialName)
						{
							array[num15 + 1, 1] = Math.Round((array[num15 + 1, 1] + array[num16 + 6, 1]) / 2.0);
						}
						array[num16 + 6, 1] = 0.0;
						array[num15 + 1, 2] += array[num16 + 6, 2];
						array[num16 + 6, 2] = 0.0;
						array[num15 + 1, 3] += array[num16 + 6, 3];
						array[num16 + 6, 3] = 0.0;
						array[num15 + 1, 4] += array[num16 + 6, 4];
						array[num16 + 6, 4] = 0.0;
						array[num15 + 1, 5] += array[num16 + 6, 5];
						array[num16 + 6, 5] = 0.0;
					}
				}
			}
		}
		return array;
	}

	public static double PriceUtkaUK(int D, int L, int k, int k1, int c, int markaStali, double tovchynaMetalu, int typUK, int typMaterialInput, int typMaterialOutput, int vidbortovka)
	{
		double num = 1.0;
		L += vidbortovka;
		L -= k + k1;
		double num2 = (double)D * ((double)L - Math.Sqrt((double)L * (double)L - (double)(2 * D * c) + (double)(c * c))) / (double)(2 * D - c);
		double num3 = Math.Sqrt(((double)L - num2) * ((double)L - num2) + (double)(c * c));
		materialSpendingCommercialOffer = Math.PI * (double)D * (num2 + num3 + (double)k + (double)k1) / 1000000.0;
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
			double num6 = tovchynaMetalu;
			double num7 = num6;
			num = ((num7 == 0.5) ? 115.0 : ((num7 == 0.8) ? 115.0 : ((num7 == 1.0) ? 134.78 : ((num7 == 1.2) ? 134.78 : ((num7 == 1.5) ? 173.19 : ((num7 == 2.0) ? 173.19 : ((num7 == 2.5) ? 173.19 : ((num7 == 3.0) ? 173.19 : ((num7 == 4.0) ? 173.19 : ((num7 == 5.0) ? 173.19 : ((num7 != 6.0) ? 0.0 : 173.19)))))))))));
			break;
		}
		case 3:
		{
			if (tovchynaMetalu == 0.0)
			{
				tovchynaMetalu = ((D > 400) ? ((D <= 800) ? 0.8 : 1.0) : 0.5);
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
		if (typUK == 1 || typUK == 2)
		{
			FlanetsKruglyj.MaterialFlanetsKruglyj(D, typMaterialInput, 1, 1);
			num8 += FlanetsKruglyj.priceProduct1;
		}
		if (typUK == 1 || typUK == 3)
		{
			FlanetsKruglyj.MaterialFlanetsKruglyj(D, typMaterialOutput, 1, 1);
			num8 += FlanetsKruglyj.priceProduct1;
		}
		tovchynaMetaluCommercialOffer = tovchynaMetalu;
		return num8;
	}

	public static double VolumeUtkaUK(int D, int L, int c)
	{
		return Math.Round((double)D * (double)(D + c) * (double)L / 1000000.0) / 1000.0;
	}
}
