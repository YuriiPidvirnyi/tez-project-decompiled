using System;

namespace TEZ_Project.Common.Products;

public static class VrizkaVK
{
	public static string[] materialName = new string[11]
	{
		"", "", "", "", "", "", "", "", "", "",
		""
	};

	public static double materialCost;

	public static double materialSpendingCommercialOffer = 0.0;

	public static double tovchynaMetaluCommercialOffer = 0.0;

	public static double[,] MaterialVrizkaVK(int D, int D1, int k, int alpha, int markaStali, double tovchynaMetalu, int typNK, int typMaterialD, int number)
	{
		double[,] array = new double[11, 6];
		double num = 0.0;
		double num2 = 0.0;
		double num3 = 0.0;
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
				tovchynaMetalu = ((D1 > 400) ? ((D1 <= 800) ? 0.7 : 0.9) : 0.5);
			}
			num = 7825.0;
			double num6 = tovchynaMetalu;
			double num7 = num6;
			if (num7 != 0.5)
			{
				if (num7 != 0.65)
				{
					if (num7 != 0.68)
					{
						if (num7 != 0.7)
						{
							if (num7 != 0.9)
							{
								if (num7 != 1.0)
								{
									if (num7 == 1.2)
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
				tovchynaMetalu = ((D1 > 400) ? ((D1 <= 800) ? 0.8 : 1.0) : 0.5);
			}
			num = 7825.0;
			double num8 = tovchynaMetalu;
			double num9 = num8;
			if (num9 != 0.5)
			{
				if (num9 != 0.8)
				{
					if (num9 != 1.0)
					{
						if (num9 != 1.2)
						{
							if (num9 != 1.5)
							{
								if (num9 != 2.0)
								{
									if (num9 != 2.5)
									{
										if (num9 != 3.0)
										{
											if (num9 != 4.0)
											{
												if (num9 != 5.0)
												{
													if (num9 == 6.0)
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
				tovchynaMetalu = ((D1 > 400) ? ((D1 <= 800) ? 0.8 : 1.0) : 0.5);
			}
			num = 7825.0;
			double num4 = tovchynaMetalu;
			double num5 = num4;
			if (num5 != 0.5)
			{
				if (num5 != 0.8)
				{
					if (num5 != 1.0)
					{
						if (num5 != 1.2)
						{
							if (num5 == 1.5)
							{
								materialName[0] = Consts2.lystNerzavijuchyj15.MaterialName;
								num3 = Consts2.lystNerzavijuchyj15.Price;
							}
							else
							{
								materialName[0] = "Лист НЕРЖ ??, м2";
							}
						}
						else
						{
							materialName[0] = Consts2.lystNerzavijuchyj12.MaterialName;
							num3 = Consts2.lystNerzavijuchyj12.Price;
						}
					}
					else
					{
						materialName[0] = Consts2.lystNerzavijuchyj10.MaterialName;
						num3 = Consts2.lystNerzavijuchyj10.Price;
					}
				}
				else
				{
					materialName[0] = Consts2.lystNerzavijuchyj08.MaterialName;
					num3 = Consts2.lystNerzavijuchyj08.Price;
				}
			}
			else
			{
				materialName[0] = Consts2.lystNerzavijuchyj05.MaterialName;
				num3 = Consts2.lystNerzavijuchyj05.Price;
			}
			break;
		}
		}
		double num10 = ((double)D - Math.Sqrt((double)D * (double)D - (double)(D1 * D1))) / 2.0;
		double num11 = (double)D1 / Math.Tan(Math.PI * (double)alpha / 180.0);
		double num12 = ((num11 > num10) ? num11 : num10);
		double num13 = (Math.PI * (double)D1 + 10.0) * ((double)k + num12 + 10.0);
		if (Math.PI * (double)D1 + 10.0 > 2500.0)
		{
			num13 += 60.0 * ((double)k + num12 + 10.0);
		}
		else if (Math.PI * (double)D1 + 10.0 > 1250.0)
		{
			num13 += 30.0 * ((double)k + num12 + 10.0);
		}
		array[0, 0] = num13 * 1.15 / 1000000.0;
		num13 = (Math.PI * (double)D1 + 10.0) * ((double)(2 * k) + num11 + num10 + 20.0) / 2000000.0;
		num2 = Math.Round((array[0, 0] / num13 - 1.0) * 100.0);
		if (num2 > 100.0)
		{
			num2 = 100.0;
			array[0, 0] = num13 * (1.0 + num2 / 100.0);
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
		materialCost = array[0, 0] * num3;
		if (typNK == 1)
		{
			double[,] array2 = new double[5, 6];
			array2 = FlanetsKruglyj.MaterialFlanetsKruglyj(D1, typMaterialD, number, 1);
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
		return array;
	}

	public static double PriceVrizkaVK(int D, int D1, int k, int alpha, int markaStali, double tovchynaMetalu, int typNK, int typMaterialD)
	{
		double num = 1.0;
		double num2 = (double)D1 / Math.Tan(Math.PI * (double)alpha / 180.0);
		materialSpendingCommercialOffer = ((double)D - Math.Sqrt((double)D * (double)D - (double)(D1 * D1))) / 2.0;
		materialSpendingCommercialOffer = Math.PI * (double)D1 * ((double)(2 * k) + num2 + materialSpendingCommercialOffer) / 2000000.0;
		materialSpendingCommercialOffer *= 1.06;
		switch (markaStali)
		{
		case 1:
			if (tovchynaMetalu == 0.0)
			{
				tovchynaMetalu = ((D1 > 400) ? ((D1 <= 800) ? 0.7 : 0.9) : 0.5);
			}
			num = ((!(tovchynaMetalu < 0.65)) ? ((tovchynaMetalu < 0.9) ? 406.0 : 520.0) : 345.0);
			break;
		case 2:
		{
			if (tovchynaMetalu == 0.0)
			{
				tovchynaMetalu = ((D1 > 400) ? ((D1 <= 800) ? 0.8 : 1.0) : 0.5);
			}
			double num5 = tovchynaMetalu;
			double num6 = num5;
			num = ((num6 == 0.5) ? 115.0 : ((num6 == 0.8) ? 115.0 : ((num6 == 1.0) ? 134.78 : ((num6 == 1.2) ? 134.78 : ((num6 == 1.5) ? 173.19 : ((num6 == 2.0) ? 173.19 : ((num6 == 2.5) ? 173.19 : ((num6 == 3.0) ? 173.19 : ((num6 == 4.0) ? 173.19 : ((num6 == 5.0) ? 173.19 : ((num6 != 6.0) ? 0.0 : 173.19)))))))))));
			break;
		}
		case 3:
		{
			if (tovchynaMetalu == 0.0)
			{
				tovchynaMetalu = ((D1 > 400) ? ((D1 <= 800) ? 0.8 : 1.0) : 0.5);
			}
			double num3 = tovchynaMetalu;
			double num4 = num3;
			num = ((num4 == 0.5) ? 115.0 : ((num4 == 0.8) ? 134.78 : ((num4 == 1.0) ? 173.19 : ((num4 == 1.2) ? 173.19 : ((num4 != 1.5) ? 0.0 : 173.19)))));
			break;
		}
		}
		double num7 = materialSpendingCommercialOffer * num;
		if (materialSpendingCommercialOffer < 0.005)
		{
			materialSpendingCommercialOffer = Math.Round(1000.0 * materialSpendingCommercialOffer) / 1000.0;
		}
		else
		{
			materialSpendingCommercialOffer = Math.Round(100.0 * materialSpendingCommercialOffer) / 100.0;
		}
		if (typNK == 1)
		{
			FlanetsKruglyj.MaterialFlanetsKruglyj(D1, typMaterialD, 1, 1);
			num7 += FlanetsKruglyj.priceProduct1;
		}
		tovchynaMetaluCommercialOffer = tovchynaMetalu;
		return num7;
	}

	public static double VolumeVrizkaVK(int D, int D1, int k, int alpha)
	{
		double num = Math.PI * (double)alpha / 180.0;
		double num2 = (double)D1 / Math.Sin(num) + (double)k * Math.Cos(num);
		double num3 = ((double)D1 / Math.Tan(num) + (double)k) * Math.Sin(num) + ((double)D - Math.Sqrt(D * D - D1 * D1)) / 2.0;
		return Math.Round(num2 * num3 * (double)D1 / 1000000.0) / 1000.0;
	}
}
