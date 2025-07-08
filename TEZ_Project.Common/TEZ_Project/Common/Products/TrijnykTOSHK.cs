using System;
using TEZ_Project.Common.Helpers;
using TEZ_Project;

namespace TEZ_Project.Common.Products;

public static class TrijnykTOSHK
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

	public static double[,] MaterialTrijnykTOSHK(int D, int l, double alpha, int markaStali, double tovchynaMetalu, int typTOSHKinput, int typTOSHKoutLeft, int typTOSHKoutRight, int typMaterialInput, int typMaterialOutLeft, int typMaterialOutRight, int number, string aisiType = "430")
	{
		double[,] array = new double[21, 6];
		double num = 0.0;
		materialName = new string[21]
		{
			"", "", "", "", "", "", "", "", "", "",
			"", "", "", "", "", "", "", "", "", "",
			""
		};
		materialCost = 0.0;
		double num2 = 0.0;
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
											if (num6 == 4.0)
											{
												materialName[0] = Consts2.lystStalnyj40.MaterialName;
												num2 = Consts2.lystStalnyj40.Price;
											}
											else
											{
												materialName[0] = "Лист СТ ??, м2";
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
		double num7 = Math.Sin(alpha * Math.PI / 180.0);
		double num8 = Math.Cos(alpha * Math.PI / 180.0);
		double num9 = num7 / num8;
		double num10 = Math.PI * (double)D + 20.0;
		double num11 = (double)D * (1.0 / num7 - 1.0) / 2.0 + (double)l + 30.0;
		double num12 = num10 * num11;
		if (num10 > 2500.0)
		{
			num12 += 60.0 * num11;
		}
		else if (num10 > 1250.0)
		{
			num12 += 30.0 * num11;
		}
		double num13 = ((double)D * num8 + (double)l * num7 - (double)(D / 2)) / num9;
		double num14 = (double)D * num7;
		double num15 = Math.Sqrt(Math.Pow((double)D * num8 / 2.0 + (double)l * num7, 2.0) + Math.Pow((double)D / (2.0 * num7) - (double)(D / 2) - num13 - num14 / 2.0, 2.0)) + 30.0;
		num12 += 2.0 * num10 * num15;
		if (num10 > 2500.0)
		{
			num12 += 120.0 * num15;
		}
		else if (num10 > 1250.0)
		{
			num12 += 60.0 * num15;
		}
		array[0, 0] = num12 * 1.05 / 1000000.0;
		num12 = num10 * ((3.0 * (double)l + num11 + 2.0 * num15) / 2.0 + 30.0) / 1000000.0;
		double num16 = Math.Round((array[0, 0] / num12 - 1.0) * 100.0);
		if (num16 > 100.0)
		{
			num16 = 100.0;
			array[0, 0] = num12 * (1.0 + num16 / 100.0);
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
		materialCost = array[0, 0] * num2;
		if (typTOSHKinput == 1 || typTOSHKoutLeft == 1 || typTOSHKoutRight == 1)
		{
			double[,] array2 = new double[5, 6];
			int num17 = 1;
			if (typTOSHKinput == 1)
			{
				array2 = FlanetsKruglyj.MaterialFlanetsKruglyj(D, typMaterialInput, number, 1);
				materialCost += FlanetsKruglyj.materialCost1;
				int num18 = 0;
				for (int i = 0; i < 5 && FlanetsKruglyj.materialName1[i] != ""; i++)
				{
					num18++;
				}
				for (int j = 0; j < num18; j++)
				{
					materialName[j + num17] = FlanetsKruglyj.materialName1[j];
					for (int k = 0; k < 6; k++)
					{
						array[j + num17, k] = array2[j, k];
					}
				}
				num17 += num18;
			}
			if (typTOSHKoutLeft == 1)
			{
				array2 = FlanetsKruglyj.MaterialFlanetsKruglyj(D, typMaterialOutLeft, number, 1);
				materialCost += FlanetsKruglyj.materialCost1;
				int num19 = 0;
				for (int m = 0; m < 5 && FlanetsKruglyj.materialName1[m] != ""; m++)
				{
					num19++;
				}
				for (int n = 0; n < num19; n++)
				{
					materialName[n + num17] = FlanetsKruglyj.materialName1[n];
					for (int num20 = 0; num20 < 6; num20++)
					{
						array[n + num17, num20] = array2[n, num20];
					}
				}
				num17 += num19;
			}
			if (typTOSHKoutRight == 1)
			{
				array2 = FlanetsKruglyj.MaterialFlanetsKruglyj(D, typMaterialOutRight, number, 1);
				materialCost += FlanetsKruglyj.materialCost1;
				int num21 = 0;
				for (int num22 = 0; num22 < 5 && FlanetsKruglyj.materialName1[num22] != ""; num22++)
				{
					num21++;
				}
				for (int num23 = 0; num23 < num21; num23++)
				{
					materialName[num23 + num17] = FlanetsKruglyj.materialName1[num23];
					for (int num24 = 0; num24 < 6; num24++)
					{
						array[num23 + num17, num24] = array2[num23, num24];
					}
				}
				num17 += num21;
			}
			if (num17 > 2)
			{
				for (int num25 = 1; num25 < num17; num25++)
				{
					for (int num26 = num25 + 1; num26 < num17; num26++)
					{
						if (materialName[num25] == materialName[num26])
						{
							materialName[num26] = "";
							array[num25, 0] += array[num26, 0];
							array[num26, 0] = 0.0;
							if (materialName[num25] == Consts2.lystStalnyj30.MaterialName)
							{
								array[num25, 1] = Math.Round((array[num25, 1] + array[num26, 1]) / 2.0);
							}
							array[num26, 1] = 0.0;
							array[num25, 2] += array[num26, 2];
							array[num26, 2] = 0.0;
							array[num25, 3] += array[num26, 3];
							array[num26, 3] = 0.0;
							array[num25, 4] += array[num26, 4];
							array[num26, 4] = 0.0;
							array[num25, 5] += array[num26, 5];
							array[num26, 5] = 0.0;
						}
					}
				}
			}
		}
		return array;
	}

	public static double PriceTrijnykTOSHK(int D, int l, double alpha, int markaStali, double tovchynaMetalu, int typTOSHKinput, int typTOSHKoutLeft, int typTOSHKoutRight, int typMaterialInput, int typMaterialOutLeft, int typMaterialOutRight)
	{
		double num = 1.0;
		double num2 = Math.Sin(alpha * Math.PI / 180.0);
		double num3 = Math.Cos(alpha * Math.PI / 180.0);
		double num4 = num2 / num3;
		double num5 = ((double)D * num3 + (double)l * num2 - (double)(D / 2)) / num4;
		double num6 = (double)D * num2;
		double num7 = (double)D * (1.0 / num2 - 1.0) / 2.0 + (double)l;
		double num8 = Math.Sqrt(Math.Pow((double)D * num3 / 2.0 + (double)l * num2, 2.0) + Math.Pow((double)D / (2.0 * num2) - (double)(D / 2) - num5 - num6 / 2.0, 2.0));
		materialSpendingCommercialOffer = Math.PI * (double)D * ((double)(3 * l) + num7 + 2.0 * num8) / 2000000.0;
		materialSpendingCommercialOffer *= 1.02;
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
			double num11 = tovchynaMetalu;
			double num12 = num11;
			num = ((num12 == 0.5) ? 115.0 : ((num12 == 0.8) ? 115.0 : ((num12 == 1.0) ? 134.78 : ((num12 == 1.2) ? 134.78 : ((num12 == 1.5) ? 173.19 : ((num12 == 2.0) ? 173.19 : ((num12 == 2.5) ? 173.19 : ((num12 == 3.0) ? 173.19 : ((num12 != 4.0) ? 0.0 : 173.19)))))))));
			break;
		}
		case 3:
		{
			if (tovchynaMetalu == 0.0)
			{
				tovchynaMetalu = ((D > 400) ? ((D <= 800) ? 0.8 : 1.0) : 0.5);
			}
			double num9 = tovchynaMetalu;
			double num10 = num9;
			num = ((num10 == 0.5) ? 115.0 : ((num10 == 0.8) ? 134.78 : ((num10 == 1.0) ? 173.19 : ((num10 == 1.2) ? 173.19 : ((num10 != 1.5) ? 0.0 : 173.19)))));
			break;
		}
		}
		double num13 = materialSpendingCommercialOffer * num;
		if (materialSpendingCommercialOffer < 0.005)
		{
			materialSpendingCommercialOffer = Math.Round(1000.0 * materialSpendingCommercialOffer) / 1000.0;
		}
		else
		{
			materialSpendingCommercialOffer = Math.Round(100.0 * materialSpendingCommercialOffer) / 100.0;
		}
		if (typTOSHKinput == 1)
		{
			FlanetsKruglyj.MaterialFlanetsKruglyj(D, typMaterialInput, 1, 1);
			num13 += FlanetsKruglyj.priceProduct1;
		}
		if (typTOSHKoutLeft == 1)
		{
			FlanetsKruglyj.MaterialFlanetsKruglyj(D, typMaterialOutLeft, 1, 1);
			num13 += FlanetsKruglyj.priceProduct1;
		}
		if (typTOSHKoutRight == 1)
		{
			FlanetsKruglyj.MaterialFlanetsKruglyj(D, typMaterialOutRight, 1, 1);
			num13 += FlanetsKruglyj.priceProduct1;
		}
		tovchynaMetaluCommercialOffer = tovchynaMetalu;
		return num13;
	}

	public static double VolumeTrijnykTOSHK(int D, int l, double alpha)
	{
		double num = Math.Sin(alpha * Math.PI / 180.0);
		double num2 = Math.Cos(alpha * Math.PI / 180.0);
		double num3 = num / num2;
		double num4 = (double)(2 * l) * num;
		double num5 = ((double)D * num2 + (double)l * num - (double)(D / 2)) / num3;
		double num6 = (double)D * num2;
		double num7 = (double)D * num;
		return Math.Round(((double)l + num5 + num7) * (2.0 * num6 + num4) * (double)D / 1000000.0) / 1000.0;
	}
}
