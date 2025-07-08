using System;
using TEZ_Project.Common.Helpers;

namespace TEZ_Project.Common.Products;

public static class VrizkaVKP
{
	public static string[] materialName = new string[19]
	{
		"", "", "", "", "", "", "", "", "", "",
		"", "", "", "", "", "", "", "", ""
	};

	public static double materialCost;

	public static double materialSpendingCommercialOffer = 0.0;

	public static double tovchynaMetaluCommercialOffer = 0.0;

	public static double[,] MaterialVrizkaVKP(int D, int B, int H, int L, int l, int markaStali, double tovchynaMetalu, int typVPKenter, int typVPKout, int typVPKvrizka, int typMaterialD, int typMaterialD1, int typProfilBH, int number, int polka, int vidbortovka, string aisiType = "430")
	{
		double[,] array = new double[19, 6];
		double num = 0.0;
		double num2 = 0.0;
		int num3 = ((B >= H) ? B : H);
		double num4 = 2.0 * (double)(B + H);
		int num5 = 0;
		double num6 = 0.0;
		L += vidbortovka;
		if (D > num3)
		{
			num3 = D;
		}
		materialName = new string[19]
		{
			"", "", "", "", "", "", "", "", "", "",
			"", "", "", "", "", "", "", "", ""
		};
		materialCost = 0.0;
		switch (markaStali)
		{
		case 1:
		{
			if (tovchynaMetalu == 0.0)
			{
				tovchynaMetalu = ((num3 > 400) ? ((num3 <= 800) ? 0.7 : 0.9) : 0.5);
			}
			num = 7825.0;
			double num7 = tovchynaMetalu;
			double num8 = num7;
			if (num8 != 0.5)
			{
				if (num8 != 0.65)
				{
					if (num8 != 0.68)
					{
						if (num8 != 0.7)
						{
							if (num8 != 0.9)
							{
								if (num8 != 1.0)
								{
									if (num8 == 1.2)
									{
										materialName[0] = Consts2.lystOchynkovanyj12.MaterialName;
										num6 = Consts2.lystOchynkovanyj12.Price;
										num2 = 10.0;
									}
									else
									{
										materialName[0] = "Лист ОЦ ??, м2";
									}
								}
								else
								{
									materialName[0] = Consts2.lystOchynkovanyj10.MaterialName;
									num6 = Consts2.lystOchynkovanyj10.Price;
									num2 = 10.0;
								}
							}
							else
							{
								materialName[0] = Consts2.lystOchynkovanyj09.MaterialName;
								num6 = Consts2.lystOchynkovanyj09.Price;
								num2 = 10.0;
							}
						}
						else
						{
							materialName[0] = Consts2.lystOchynkovanyj07.MaterialName;
							num6 = Consts2.lystOchynkovanyj07.Price;
							num2 = 10.0;
						}
					}
					else
					{
						materialName[0] = Consts2.lystOchynkovanyj068.MaterialName;
						num6 = Consts2.lystOchynkovanyj068.Price;
						num2 = 10.0;
					}
				}
				else
				{
					materialName[0] = Consts2.lystOchynkovanyj065.MaterialName;
					num6 = Consts2.lystOchynkovanyj065.Price;
					num2 = 10.0;
				}
			}
			else
			{
				materialName[0] = Consts2.lystOchynkovanyj05.MaterialName;
				num6 = Consts2.lystOchynkovanyj05.Price;
				num2 = 5.0;
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
			double num9 = tovchynaMetalu;
			double num10 = num9;
			if (num10 != 0.5)
			{
				if (num10 != 0.8)
				{
					if (num10 != 1.0)
					{
						if (num10 != 1.2)
						{
							if (num10 != 1.5)
							{
								if (num10 != 2.0)
								{
									if (num10 != 2.5)
									{
										if (num10 != 3.0)
										{
											if (num10 != 4.0)
											{
												if (num10 != 5.0)
												{
													if (num10 == 6.0)
													{
														materialName[0] = Consts2.lystStalnyj60.MaterialName;
														num6 = Consts2.lystStalnyj60.Price;
														num2 = 10.0;
													}
													else
													{
														materialName[0] = "Лист СТ ??, м2";
													}
												}
												else
												{
													materialName[0] = Consts2.lystStalnyj50.MaterialName;
													num6 = Consts2.lystStalnyj50.Price;
													num2 = 10.0;
												}
											}
											else
											{
												materialName[0] = Consts2.lystStalnyj40.MaterialName;
												num6 = Consts2.lystStalnyj40.Price;
												num2 = 10.0;
											}
										}
										else
										{
											materialName[0] = Consts2.lystStalnyj30.MaterialName;
											num6 = Consts2.lystStalnyj30.Price;
											num2 = 10.0;
										}
									}
									else
									{
										materialName[0] = Consts2.lystStalnyj25.MaterialName;
										num6 = Consts2.lystStalnyj25.Price;
										num2 = 10.0;
									}
								}
								else
								{
									materialName[0] = Consts2.lystStalnyj20.MaterialName;
									num6 = Consts2.lystStalnyj20.Price;
									num2 = 10.0;
								}
							}
							else
							{
								materialName[0] = Consts2.lystStalnyj15.MaterialName;
								num6 = Consts2.lystStalnyj15.Price;
								num2 = 10.0;
							}
						}
						else
						{
							materialName[0] = Consts2.lystStalnyj12.MaterialName;
							num6 = Consts2.lystStalnyj12.Price;
							num2 = 10.0;
						}
					}
					else
					{
						materialName[0] = Consts2.lystStalnyj10.MaterialName;
						num6 = Consts2.lystStalnyj10.Price;
						num2 = 10.0;
					}
				}
				else
				{
					materialName[0] = Consts2.lystStalnyj08.MaterialName;
					num6 = Consts2.lystStalnyj08.Price;
					num2 = 10.0;
				}
			}
			else
			{
				materialName[0] = Consts2.lystStalnyj05.MaterialName;
				num6 = Consts2.lystStalnyj05.Price;
				num2 = 5.0;
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
			num2 = MaterialHelper.GetMaterialWithdrawalNerzavijka(tovchynaMetalu);
			CustomConst lystNerzavijuchyj = MaterialHelper.GetLystNerzavijuchyj(tovchynaMetalu, aisiType);
			materialName[0] = lystNerzavijuchyj?.MaterialName ?? "Лист НЕРЖ ??, м2";
			num6 = lystNerzavijuchyj.Price;
			break;
		}
		}
		double num11 = Math.PI * (double)D + 30.0;
		double num12 = num11 * (double)L;
		if (num11 > 2500.0)
		{
			num12 += 60.0 * (double)L;
		}
		else if (num11 > 1250.0)
		{
			num12 += 30.0 * (double)L;
		}
		if (L > 2500)
		{
			num12 += 60.0 * num11;
		}
		else if (L > 1250)
		{
			num12 += 30.0 * num11;
		}
		num11 = (double)l + ((double)D - Math.Sqrt((double)D * (double)D - (double)(H * H))) / 2.0 + 12.0;
		double num13 = (num4 + 30.0) * num11;
		if (num4 + 30.0 > 2500.0)
		{
			num13 += 60.0 * num11;
		}
		else if (num4 + 30.0 > 1250.0)
		{
			num13 += 30.0 * num11;
		}
		if (num11 > 2500.0)
		{
			num13 += 60.0 * (num4 + 30.0);
		}
		else if (num11 > 1250.0)
		{
			num13 += 30.0 * (num4 + 30.0);
		}
		array[0, 0] = (num12 + num13) * (1.0 + num2 / 100.0) / 1000000.0;
		double num14 = Math.Acos(Math.Sqrt((double)D * (double)D - (double)(H * H)) / (double)D);
		num12 = (Math.PI * (double)D + 30.0) * (double)L - (double)(D * B) * num14;
		double num15 = ((double)(D * D) * num14 - (double)H * Math.Sqrt((double)D * (double)D - (double)(H * H))) / 4.0;
		num13 = (num4 + 30.0) * ((double)l + ((double)D - Math.Sqrt((double)D * (double)D - (double)(H * H))) / 2.0) - 2.0 * num15;
		num12 += num13;
		num12 /= 1000000.0;
		num2 = Math.Round((array[0, 0] / num12 - 1.0) * 100.0);
		if (num2 > 20.0)
		{
			num2 = 20.0;
			array[0, 0] = num12 * (1.0 + num2 / 100.0);
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
		materialCost = array[0, 0] * num6;
		if (typVPKvrizka == 1)
		{
			if (typProfilBH == 0)
			{
				num3 = ((B >= H) ? B : H);
				typProfilBH = ((num3 < 800) ? 1 : 2);
			}
			double[,] array2 = new double[2, 6];
			num5 = 1;
			array2 = FlanetsPrjamokutnyj.MaterialFlanetsPrjamokutnyj(B, H, typProfilBH, number, polka, 1);
			materialCost += FlanetsPrjamokutnyj.materialCost1;
			for (int i = 0; i < 2; i++)
			{
				if (FlanetsPrjamokutnyj.materialName[i] != "")
				{
					materialName[num5] = FlanetsPrjamokutnyj.materialName[i];
					for (int j = 0; j < 6; j++)
					{
						array[num5, j] = array2[i, j];
					}
					num5++;
				}
			}
			if (typProfilBH <= 2)
			{
				double[,] array3 = new double[1, 6];
				array3 = HvyntNaFlanets.MaterialHvyntNaFlanets(B, H, 1, number);
				materialCost += HvyntNaFlanets.materialCost1;
				materialName[3] = HvyntNaFlanets.materialName1[0];
				for (int k = 0; k < 6; k++)
				{
					array[3, k] = array3[0, k];
				}
				num5++;
			}
		}
		if ((typVPKenter == 1 && typVPKout != 1) || (typVPKenter != 1 && typVPKout == 1))
		{
			double[,] array4 = new double[5, 6];
			array4 = ((typVPKenter == 1 && typVPKout != 1) ? FlanetsKruglyj.MaterialFlanetsKruglyj(D, typMaterialD, number, 1) : FlanetsKruglyj.MaterialFlanetsKruglyj(D, typMaterialD1, number, 1));
			materialCost += FlanetsKruglyj.materialCost1;
			for (int m = 0; m < 5; m++)
			{
				materialName[m + num5 + 1] = FlanetsKruglyj.materialName1[m];
				for (int n = 0; n < 6; n++)
				{
					array[m + num5 + 1, n] = array4[m, n];
				}
			}
		}
		else if (typVPKenter == 1 && typVPKout == 1)
		{
			double[,] array5 = new double[5, 6];
			array5 = FlanetsKruglyj.MaterialFlanetsKruglyj(D, typMaterialD, number, 1);
			materialCost += FlanetsKruglyj.materialCost1;
			for (int num16 = 0; num16 < 5; num16++)
			{
				materialName[num16 + num5 + 1] = FlanetsKruglyj.materialName1[num16];
				for (int num17 = 0; num17 < 6; num17++)
				{
					array[num16 + num5 + 1, num17] = array5[num16, num17];
				}
			}
			array5 = new double[5, 6];
			array5 = FlanetsKruglyj.MaterialFlanetsKruglyj(D, typMaterialD1, number, 1);
			materialCost += FlanetsKruglyj.materialCost1;
			for (int num18 = 0; num18 < 5; num18++)
			{
				materialName[num18 + num5 + 1 + 5] = FlanetsKruglyj.materialName1[num18];
				for (int num19 = 0; num19 < 6; num19++)
				{
					array[num18 + num5 + 1 + 5, num19] = array5[num18, num19];
				}
			}
			int num20 = 0;
			for (int num21 = 0; num21 < 5 && materialName[num21 + num5 + 1] != ""; num21++)
			{
				num20++;
			}
			int num22 = 0;
			for (int num23 = 0; num23 < 5 && materialName[num23 + num5 + 6] != ""; num23++)
			{
				num22++;
			}
			for (int num24 = 0; num24 < num20; num24++)
			{
				for (int num25 = 0; num25 < num22; num25++)
				{
					if (materialName[num24 + num5 + 1] == materialName[num25 + num5 + 6])
					{
						materialName[num25 + num5 + 6] = "";
						array[num24 + num5 + 1, 0] += array[num25 + num5 + 6, 0];
						array[num25 + num5 + 6, 0] = 0.0;
						if (materialName[num24 + num5 + 1] == Consts2.lystStalnyj30.MaterialName)
						{
							array[num24 + num5 + 1, 1] = Math.Round((array[num24 + num5 + 1, 1] + array[num25 + num5 + 6, 1]) / 2.0);
						}
						array[num25 + num5 + 6, 1] = 0.0;
						array[num24 + num5 + 1, 2] += array[num25 + num5 + 6, 2];
						array[num25 + num5 + 6, 2] = 0.0;
						array[num24 + num5 + 1, 3] += array[num25 + num5 + 6, 3];
						array[num25 + num5 + 6, 3] = 0.0;
						array[num24 + num5 + 1, 4] += array[num25 + num5 + 6, 4];
						array[num25 + num5 + 6, 4] = 0.0;
						array[num24 + num5 + 1, 5] += array[num25 + num5 + 6, 5];
						array[num25 + num5 + 6, 5] = 0.0;
					}
				}
			}
		}
		return array;
	}

	public static double PriceVrizkaVKP(int D, int B, int H, int L, int l, int markaStali, double tovchynaMetalu, int typVPKenter, int typVPKout, int typVPKvrizka, int typMaterialD, int typMaterialD1, int vidbortovka)
	{
		double num = 1.0;
		int num2 = ((B >= H) ? B : H);
		double num3 = 2.0 * (double)(B + H);
		L += vidbortovka;
		if (D > num2)
		{
			num2 = D;
		}
		switch (markaStali)
		{
		case 1:
			if (tovchynaMetalu == 0.0)
			{
				tovchynaMetalu = ((num2 > 400) ? ((num2 <= 800) ? 0.7 : 0.9) : 0.5);
			}
			num = ((typVPKvrizka != 1) ? ((!(tovchynaMetalu < 0.65)) ? ((tovchynaMetalu < 0.9) ? 406.0 : 520.0) : 345.0) : ((!(tovchynaMetalu < 0.65)) ? ((tovchynaMetalu < 0.9) ? 464.0 : 600.0) : 402.5));
			break;
		case 2:
		{
			if (tovchynaMetalu == 0.0)
			{
				tovchynaMetalu = ((num2 > 400) ? ((num2 <= 800) ? 0.8 : 1.0) : 0.5);
			}
			double num6 = tovchynaMetalu;
			double num7 = num6;
			num = ((num7 == 0.5) ? 110.0 : ((num7 == 0.8) ? 140.0 : ((num7 == 1.0) ? 200.0 : ((num7 == 1.2) ? 250.0 : ((num7 == 1.5) ? 300.0 : ((num7 == 2.0) ? 350.0 : ((num7 == 2.5) ? 400.0 : ((num7 == 3.0) ? 500.0 : ((num7 == 4.0) ? 600.0 : ((num7 == 5.0) ? 700.0 : ((num7 != 6.0) ? 0.0 : 800.0)))))))))));
			num *= 1.8;
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
			num = ((num5 == 0.5) ? 110.0 : ((num5 == 0.8) ? 200.0 : ((num5 == 1.0) ? 250.0 : ((num5 == 1.2) ? 300.0 : ((num5 != 1.5) ? 0.0 : 400.0)))));
			num *= 1.7;
			break;
		}
		}
		double num8 = Math.Acos(Math.Sqrt((double)D * (double)D - (double)(H * H)) / (double)D);
		double num9 = (double)D * (Math.PI * (double)L - (double)B * num8);
		double num10 = ((double)(D * D) * num8 - (double)H * Math.Sqrt(D * D - H * H)) / 4.0;
		double num11 = num3 * ((double)l + ((double)D - Math.Sqrt(D * D - H * H)) / 2.0) - 2.0 * num10;
		materialSpendingCommercialOffer = (num9 + num11) / 1000000.0;
		double num12 = materialSpendingCommercialOffer * num;
		if (materialSpendingCommercialOffer < 0.005)
		{
			materialSpendingCommercialOffer = Math.Round(1000.0 * materialSpendingCommercialOffer) / 1000.0;
		}
		else
		{
			materialSpendingCommercialOffer = Math.Round(100.0 * materialSpendingCommercialOffer) / 100.0;
		}
		if (typVPKenter == 1)
		{
			FlanetsKruglyj.MaterialFlanetsKruglyj(D, typMaterialD, 1, 1);
			num12 += FlanetsKruglyj.priceProduct1;
		}
		if (typVPKout == 1)
		{
			FlanetsKruglyj.MaterialFlanetsKruglyj(D, typMaterialD1, 1, 1);
			num12 += FlanetsKruglyj.priceProduct1;
		}
		tovchynaMetaluCommercialOffer = tovchynaMetalu;
		return num12;
	}

	public static double VolumeVrizkaVKP(int D, int L, int l)
	{
		return Math.Round((double)D * (double)(D + l) * (double)L / 1000000.0) / 1000.0;
	}
}
