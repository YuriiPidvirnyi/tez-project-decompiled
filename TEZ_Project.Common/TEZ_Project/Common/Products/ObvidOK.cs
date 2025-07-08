using System;
using TEZ_Project.Common.Helpers;

namespace TEZ_Project.Common.Products;

public static class ObvidOK
{
	public static string[] materialName = new string[6] { "", "", "", "", "", "" };

	public static double materialCost;

	public static double materialSpendingCommercialOffer = 0.0;

	public static double tovchynaMetaluCommercialOffer = 0.0;

	public static double[,] MaterialObvidOK(int D, int L, int l, int c, int k, int k1, int markaStali, double tovchynaMetalu, int typOK, int typMaterialD, int number, int vidbortovka = 0, string aisiType = "430")
	{
		double[,] array = new double[6, 6];
		double num = 0.0;
		double num2 = 0.0;
		L += vidbortovka;
		materialName = new string[6] { "", "", "", "", "", "" };
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
		double num7 = ((double)L - (double)k - (double)k1 - (double)l) / 2.0;
		double num8 = (double)D * (num7 - Math.Sqrt(num7 * num7 - (double)(2 * D * c) + (double)(c * c))) / (2.0 * (double)D - (double)c);
		double num9 = Math.Sqrt((num7 - num8) * (num7 - num8) + (double)(c * c));
		double num10 = (Math.PI * (double)D + 30.0) * (2.0 * (num8 + num9) + (double)k + (double)k1 + (double)l);
		array[0, 0] = num10;
		if (Math.PI * (double)D + 30.0 > 2500.0)
		{
			array[0, 0] += 60.0 * (2.0 * (num8 + num9) + (double)k + (double)k1 + (double)l);
		}
		else if (Math.PI * (double)D + 30.0 > 1250.0)
		{
			array[0, 0] += 30.0 * (2.0 * (num8 + num9) + (double)k + (double)k1 + (double)l);
		}
		if (2.0 * (num8 + num9) + (double)k + (double)k1 + (double)l > 2500.0)
		{
			array[0, 0] += 60.0 * (Math.PI * (double)D + 30.0);
		}
		else if (2.0 * (num8 + num9) + (double)k + (double)k1 + (double)l > 1250.0)
		{
			array[0, 0] += 30.0 * (Math.PI * (double)D + 30.0);
		}
		array[0, 0] *= 1.0500000000000001E-06;
		num10 = (Math.PI * (double)D + 30.0) * (2.0 * (num8 + num9) + (double)k + (double)k1 + (double)l) / 1000000.0;
		array[0, 1] = Math.Round((array[0, 0] / num10 - 1.0) * 100.0) / 100.0;
		if (100.0 * array[0, 1] > 20.0)
		{
			array[0, 1] = 0.2;
			array[0, 0] = num10 * (1.0 + array[0, 1]);
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
		if (typOK == 1 || typOK == 2)
		{
			double[,] array2 = new double[5, 6];
			array2 = ((typOK == 1) ? FlanetsKruglyj.MaterialFlanetsKruglyj(D, typMaterialD, 2 * number, 2) : FlanetsKruglyj.MaterialFlanetsKruglyj(D, typMaterialD, number, 1));
			for (int i = 0; i < 5; i++)
			{
				materialName[i + 1] = FlanetsKruglyj.materialName1[i];
				for (int j = 0; j < 6; j++)
				{
					array[i + 1, j] = array2[i, j];
				}
			}
			materialCost += FlanetsKruglyj.materialCost1;
		}
		return array;
	}

	public static double PriceObvidOK(int D, int L, int l, int c, int k, int k1, int markaStali, double tovchynaMetalu, int typOK, int typMaterialD, int vidbortovka = 0)
	{
		double num = 1.0;
		L += vidbortovka;
		double num2 = (L - k - k1 - l) / 2;
		double num3 = (double)D * (num2 - Math.Sqrt(num2 * num2 - (double)(2 * D * c) + (double)(c * c))) / (2.0 * (double)D - (double)c);
		double num4 = Math.Sqrt((num2 - num3) * (num2 - num3) + (double)(c * c));
		materialSpendingCommercialOffer = Math.PI * (double)D * (2.0 * (num3 + num4) + (double)k + (double)k1 + (double)l) / 1000000.0;
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
		switch (typOK)
		{
		case 1:
			FlanetsKruglyj.MaterialFlanetsKruglyj(D, typMaterialD, 2, 2);
			num9 += FlanetsKruglyj.priceProduct1;
			break;
		case 2:
			FlanetsKruglyj.MaterialFlanetsKruglyj(D, typMaterialD, 1, 1);
			num9 += FlanetsKruglyj.priceProduct1;
			break;
		}
		tovchynaMetaluCommercialOffer = tovchynaMetalu;
		return num9;
	}

	public static double VolumeObvidOK(int D, int L, int c)
	{
		return Math.Round((double)D * (double)(D + c) * (double)L / 1000000.0) / 1000.0;
	}
}
