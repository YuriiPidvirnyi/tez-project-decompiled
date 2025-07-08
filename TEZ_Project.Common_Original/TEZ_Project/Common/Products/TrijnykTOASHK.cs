using System;
using TEZ_Project.Common.Helpers;

namespace TEZ_Project.Common.Products;

public static class TrijnykTOASHK
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

	public static double[,] MaterialTrijnykTOASHK(int D, int D1, int D2, int l, int l1, int l2, int k, int k1, double alpha, int markaStali, double tovchynaMetalu, int typTOASHKinput, int typTOASHKoutLeft, int typTOASHKoutRight, int typMaterialInput, int typMaterialOutLeft, int typMaterialOutRight, int number, string aisiType = "430")
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
		int num3 = ((D > D1) ? D : D1);
		if (D2 > num3)
		{
			num3 = D2;
		}
		switch (markaStali)
		{
		case 1:
		{
			if (tovchynaMetalu == 0.0)
			{
				tovchynaMetalu = ((num3 > 400) ? ((num3 <= 800) ? 0.7 : 0.9) : 0.5);
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
				tovchynaMetalu = ((num3 > 400) ? ((num3 <= 800) ? 0.8 : 1.0) : 0.5);
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
											if (num7 == 4.0)
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
				tovchynaMetalu = ((num3 > 400) ? ((num3 <= 800) ? 0.8 : 1.0) : 0.5);
			}
			num = 7825.0;
			CustomConst lystNerzavijuchyj = MaterialHelper.GetLystNerzavijuchyj(tovchynaMetalu, aisiType);
			materialName[0] = lystNerzavijuchyj?.MaterialName ?? "Лист НЕРЖ ??, м2";
			num2 = lystNerzavijuchyj.Price;
			break;
		}
		}
		double num8 = Math.Sin(alpha * Math.PI / 180.0);
		double num9 = Math.Cos(alpha * Math.PI / 180.0);
		int num10 = (int)Math.Round(3.0 * (double)l / 2.0) + 30;
		double num11 = (double)D1 * num9 / 2.0;
		double num12 = (double)D1 * num8 / 2.0 - Math.Sqrt(3.0) * (double)D / 2.0 + (double)num10 - (double)l;
		double num13 = Math.Pow(num12 * num9 - num11 * num8, 2.0) - (Math.Pow(num11, 2.0) + Math.Pow(num12, 2.0) - Math.Pow(l1, 2.0));
		int num14;
		if (num13 < 0.0)
		{
			num14 = 0;
		}
		else
		{
			double num15 = num11 * num8 - num12 * num9;
			num13 = Math.Sqrt(num13);
			num14 = (int)Math.Round(num15 + num13);
			num14 += 30;
			if (num14 < l1)
			{
				num14 = 0;
			}
		}
		num11 = (double)D2 * num9 / 2.0;
		num12 = (double)D2 * num8 / 2.0 - Math.Sqrt(3.0) * (double)D / 2.0 + (double)num10 - (double)l;
		num13 = Math.Pow(num12 * num9 - num11 * num8, 2.0) - (Math.Pow(num11, 2.0) + Math.Pow(num12, 2.0) - Math.Pow(l2, 2.0));
		int num16;
		if (num13 < 0.0)
		{
			num16 = 0;
		}
		else
		{
			double num15 = num11 * num8 - num12 * num9;
			num13 = Math.Sqrt(num13);
			num16 = (int)Math.Round(num15 + num13);
			num16 += 30;
			if (num16 < l2)
			{
				num16 = 0;
			}
		}
		double num17 = Math.PI * (double)D + 20.0;
		double num18 = num17 * (double)num10;
		if (num17 > 2500.0)
		{
			num18 += 60.0 * (double)num10;
		}
		else if (num17 > 1250.0)
		{
			num18 += 30.0 * (double)num10;
		}
		num17 = ((D > D1) ? D : D1);
		num17 = Math.PI * num17 + 20.0;
		num18 += num17 * (double)(num14 + k + 30);
		if (num17 > 2500.0)
		{
			num18 += 60.0 * (double)(num14 + k + 30);
		}
		else if (num17 > 1250.0)
		{
			num18 += 30.0 * (double)(num14 + k + 30);
		}
		num17 = ((D > D2) ? D : D2);
		num17 = Math.PI * num17 + 20.0;
		num18 += num17 * (double)(num16 + k1 + 30);
		if (num17 > 2500.0)
		{
			num18 += 60.0 * (double)(num16 + k1 + 30);
		}
		else if (num17 > 1250.0)
		{
			num18 += 30.0 * (double)(num16 + k1 + 30);
		}
		array[0, 0] = num18 * 1.05 / 1000000.0;
		num18 = (Math.PI * (double)D + 20.0) * (double)(l + 30 + num10) / 2.0;
		num18 += (Math.PI * (double)(D + D1) / 2.0 + 20.0) * (double)(l1 + 30 + num14) / 2.0 + (Math.PI * (double)D1 + 20.0) * (double)(k + 30);
		num18 += (Math.PI * (double)(D + D2) / 2.0 + 20.0) * (double)(l2 + 30 + num16) / 2.0 + (Math.PI * (double)D2 + 20.0) * (double)(k1 + 30);
		num18 /= 1000000.0;
		double num19 = Math.Round((array[0, 0] / num18 - 1.0) * 100.0);
		if (num19 > 100.0)
		{
			num19 = 100.0;
			array[0, 0] = num18 * (1.0 + num19 / 100.0);
		}
		array[0, 1] = num19 / 100.0;
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
		if (typTOASHKinput == 1 || typTOASHKoutLeft == 1 || typTOASHKoutRight == 1)
		{
			double[,] array2 = new double[5, 6];
			int num20 = 1;
			if (typTOASHKinput == 1)
			{
				array2 = FlanetsKruglyj.MaterialFlanetsKruglyj(D, typMaterialInput, number, 1);
				materialCost += FlanetsKruglyj.materialCost1;
				int num21 = 0;
				for (int i = 0; i < 5 && FlanetsKruglyj.materialName1[i] != ""; i++)
				{
					num21++;
				}
				for (int j = 0; j < num21; j++)
				{
					materialName[j + num20] = FlanetsKruglyj.materialName1[j];
					for (int m = 0; m < 6; m++)
					{
						array[j + num20, m] = array2[j, m];
					}
				}
				num20 += num21;
			}
			if (typTOASHKoutLeft == 1)
			{
				array2 = FlanetsKruglyj.MaterialFlanetsKruglyj(D1, typMaterialOutLeft, number, 1);
				materialCost += FlanetsKruglyj.materialCost1;
				int num22 = 0;
				for (int n = 0; n < 5 && FlanetsKruglyj.materialName1[n] != ""; n++)
				{
					num22++;
				}
				for (int num23 = 0; num23 < num22; num23++)
				{
					materialName[num23 + num20] = FlanetsKruglyj.materialName1[num23];
					for (int num24 = 0; num24 < 6; num24++)
					{
						array[num23 + num20, num24] = array2[num23, num24];
					}
				}
				num20 += num22;
			}
			if (typTOASHKoutRight == 1)
			{
				array2 = FlanetsKruglyj.MaterialFlanetsKruglyj(D2, typMaterialOutRight, number, 1);
				materialCost += FlanetsKruglyj.materialCost1;
				int num25 = 0;
				for (int num26 = 0; num26 < 5 && FlanetsKruglyj.materialName1[num26] != ""; num26++)
				{
					num25++;
				}
				for (int num27 = 0; num27 < num25; num27++)
				{
					materialName[num27 + num20] = FlanetsKruglyj.materialName1[num27];
					for (int num28 = 0; num28 < 6; num28++)
					{
						array[num27 + num20, num28] = array2[num27, num28];
					}
				}
				num20 += num25;
			}
			if (num20 > 2)
			{
				for (int num29 = 1; num29 < num20; num29++)
				{
					for (int num30 = num29 + 1; num30 < num20; num30++)
					{
						if (materialName[num29] == materialName[num30])
						{
							materialName[num30] = "";
							array[num29, 0] += array[num30, 0];
							array[num30, 0] = 0.0;
							if (materialName[num29] == Consts2.lystStalnyj30.MaterialName)
							{
								array[num29, 1] = Math.Round((array[num29, 1] + array[num30, 1]) / 2.0);
							}
							array[num30, 1] = 0.0;
							array[num29, 2] += array[num30, 2];
							array[num30, 2] = 0.0;
							array[num29, 3] += array[num30, 3];
							array[num30, 3] = 0.0;
							array[num29, 4] += array[num30, 4];
							array[num30, 4] = 0.0;
							array[num29, 5] += array[num30, 5];
							array[num30, 5] = 0.0;
						}
					}
				}
			}
		}
		return array;
	}

	public static double PriceTrijnykTOASHK(int D, int D1, int D2, int l, int l1, int l2, int k, int k1, double alpha, int markaStali, double tovchynaMetalu, int typTOASHKinput, int typTOASHKoutLeft, int typTOASHKoutRight, int typMaterialInput, int typMaterialOutLeft, int typMaterialOutRight)
	{
		double num = 1.0;
		double num2 = Math.Sin(alpha * Math.PI / 180.0);
		double num3 = Math.Cos(alpha * Math.PI / 180.0);
		int num4 = (int)Math.Round(3.0 * (double)l / 2.0);
		double num5 = (double)D1 * num3 / 2.0;
		double num6 = (double)D1 * num2 / 2.0 - Math.Sqrt(3.0) * (double)D / 2.0 + (double)num4 - (double)l;
		double num7 = Math.Pow(num6 * num3 - num5 * num2, 2.0) - (Math.Pow(num5, 2.0) + Math.Pow(num6, 2.0) - Math.Pow(l1, 2.0));
		int num8;
		if (num7 < 0.0)
		{
			num8 = 0;
		}
		else
		{
			double num9 = num5 * num2 - num6 * num3;
			num7 = Math.Sqrt(num7);
			num8 = (int)Math.Round(num9 + num7);
			if (num8 < l1)
			{
				num8 = 0;
			}
		}
		num5 = (double)D2 * num3 / 2.0;
		num6 = (double)D2 * num2 / 2.0 - Math.Sqrt(3.0) * (double)D / 2.0 + (double)num4 - (double)l;
		num7 = Math.Pow(num6 * num3 - num5 * num2, 2.0) - (Math.Pow(num5, 2.0) + Math.Pow(num6, 2.0) - Math.Pow(l2, 2.0));
		int num10;
		if (num7 < 0.0)
		{
			num10 = 0;
		}
		else
		{
			double num9 = num5 * num2 - num6 * num3;
			num7 = Math.Sqrt(num7);
			num10 = (int)Math.Round(num9 + num7);
			if (num10 < l2)
			{
				num10 = 0;
			}
		}
		materialSpendingCommercialOffer = Math.PI * (double)D * (double)(l + num4) / 2.0;
		materialSpendingCommercialOffer += Math.PI * (double)(D + D1) * (double)(l1 + num8) / 4.0 + Math.PI * (double)D1 * (double)k;
		materialSpendingCommercialOffer += Math.PI * (double)(D + D2) * (double)(l2 + num10) / 4.0 + Math.PI * (double)D2 * (double)k1;
		materialSpendingCommercialOffer /= 1000000.0;
		materialSpendingCommercialOffer *= 1.01;
		int num11 = ((D > D1) ? D : D1);
		if (D2 > num11)
		{
			num11 = D2;
		}
		switch (markaStali)
		{
		case 1:
			if (tovchynaMetalu == 0.0)
			{
				tovchynaMetalu = ((num11 > 400) ? ((num11 <= 800) ? 0.7 : 0.9) : 0.5);
			}
			num = ((!(tovchynaMetalu < 0.65)) ? ((tovchynaMetalu < 0.9) ? 406.0 : 520.0) : 345.0);
			break;
		case 2:
		{
			if (tovchynaMetalu == 0.0)
			{
				tovchynaMetalu = ((num11 > 400) ? ((num11 <= 800) ? 0.8 : 1.0) : 0.5);
			}
			double num14 = tovchynaMetalu;
			double num15 = num14;
			num = ((num15 == 0.5) ? 115.0 : ((num15 == 0.8) ? 115.0 : ((num15 == 1.0) ? 134.78 : ((num15 == 1.2) ? 134.78 : ((num15 == 1.5) ? 173.19 : ((num15 == 2.0) ? 173.19 : ((num15 == 2.5) ? 173.19 : ((num15 == 3.0) ? 173.19 : ((num15 != 4.0) ? 0.0 : 173.19)))))))));
			break;
		}
		case 3:
		{
			if (tovchynaMetalu == 0.0)
			{
				tovchynaMetalu = ((num11 > 400) ? ((num11 <= 800) ? 0.8 : 1.0) : 0.5);
			}
			double num12 = tovchynaMetalu;
			double num13 = num12;
			num = ((num13 == 0.5) ? 115.0 : ((num13 == 0.8) ? 134.78 : ((num13 == 1.0) ? 173.19 : ((num13 == 1.2) ? 173.19 : ((num13 != 1.5) ? 0.0 : 173.19)))));
			break;
		}
		}
		double num16 = materialSpendingCommercialOffer * num;
		if (materialSpendingCommercialOffer < 0.005)
		{
			materialSpendingCommercialOffer = Math.Round(1000.0 * materialSpendingCommercialOffer) / 1000.0;
		}
		else
		{
			materialSpendingCommercialOffer = Math.Round(100.0 * materialSpendingCommercialOffer) / 100.0;
		}
		if (typTOASHKinput == 1)
		{
			FlanetsKruglyj.MaterialFlanetsKruglyj(D, typMaterialInput, 1, 1);
			num16 += FlanetsKruglyj.priceProduct1;
		}
		if (typTOASHKoutLeft == 1)
		{
			FlanetsKruglyj.MaterialFlanetsKruglyj(D1, typMaterialOutLeft, 1, 1);
			num16 += FlanetsKruglyj.priceProduct1;
		}
		if (typTOASHKoutRight == 1)
		{
			FlanetsKruglyj.MaterialFlanetsKruglyj(D2, typMaterialOutRight, 1, 1);
			num16 += FlanetsKruglyj.priceProduct1;
		}
		tovchynaMetaluCommercialOffer = tovchynaMetalu;
		return num16;
	}

	public static double VolumeTrijnykTOASHK(int D, int D1, int D2, int l, int l1, int l2, int k, int k1, double alpha)
	{
		double num = Math.Sin(alpha * Math.PI / 180.0);
		double num2 = Math.Cos(alpha * Math.PI / 180.0);
		int num3 = (int)Math.Round(3.0 * (double)l / 2.0);
		double num4 = (double)D1 * num2 / 2.0;
		double num5 = (double)D1 * num / 2.0 - Math.Sqrt(3.0) * (double)D / 2.0 + (double)num3 - (double)l;
		int num6 = (int)Math.Round(num4 * num - num5 * num2 + Math.Sqrt(Math.Pow(num5 * num2 - num4 * num, 2.0) - (Math.Pow(num4, 2.0) + Math.Pow(num5, 2.0) - Math.Pow(l1, 2.0))));
		num4 = (double)D2 * num2 / 2.0;
		num5 = (double)D2 * num / 2.0 - Math.Sqrt(3.0) * (double)D / 2.0 + (double)num3 - (double)l;
		int num7 = (int)Math.Round(num4 * num - num5 * num2 + Math.Sqrt(Math.Pow(num5 * num2 - num4 * num, 2.0) - (Math.Pow(num4, 2.0) + Math.Pow(num5, 2.0) - Math.Pow(l2, 2.0))));
		double num8 = (double)(-num6) * num - (double)D1 * num2 / 2.0 - (double)k * num;
		double num9 = (double)num6 * num2 + (double)D1 * num / 2.0 + (double)k * num2;
		double num10 = (double)num7 * num + (double)D2 * num2 / 2.0 + (double)k1 * num;
		double num11 = (double)num7 * num2 + (double)D2 * num / 2.0 + (double)k1 * num2;
		double num12 = ((num11 > num9) ? num11 : num9);
		int num13 = ((D > D1) ? D : D1);
		if (D2 > num13)
		{
			num13 = D2;
		}
		return Math.Round((num10 - num8) * (num12 + (double)num3) * (double)num13 / 1000000.0) / 1000.0;
	}
}
