using System;
using TEZ_Project.Common.Helpers;

using TEZ_Project.Common.Data;
using TEZ_Project;

namespace TEZ_Project.Common.Products;

public static class RoundAirPK
{
	public static string[] materialName = new string[6] { "", "", "", "", "", "" };

	public static double materialCost;

	public static double materialSpendingCommercialOffer = 0.0;

	public static double tovchynaMetaluCommercialOffer = 0.0;

	public static double[,] GetMaterialRoundAirFlowPK(int D, int L, int markaStali, double tovchynaMetalu, int number, int typPK, int typProfil, int vidbortovka, string aisiType = "430")
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
		int num7 = ((L <= 1250) ? 30 : ((D <= 388) ? 30 : ((D <= 777) ? 60 : ((D > 1165) ? ((D <= 1554) ? 120 : 150) : 90))));
		array[0, 0] = (Math.PI * (double)D + (double)num7) * (double)L / 1000000.0;
		double num8 = ((L != 1250) ? 5.0 : ((markaStali != 1 || (typPK != 2 && typPK != 3)) ? 5.0 : 1.0));
		array[0, 0] *= 1.0 + num8 / 100.0;
		if (array[0, 0] < 0.005)
		{
			array[0, 0] = Math.Round(1000.0 * array[0, 0]) / 1000.0;
		}
		else
		{
			array[0, 0] = Math.Round(100.0 * array[0, 0]) / 100.0;
		}
		array[0, 1] = num8 / 100.0;
		array[0, 4] = array[0, 0] * (double)number;
		array[0, 5] = array[0, 4] * num * tovchynaMetalu / 1000.0;
		array[0, 2] = array[0, 4] * array[0, 1];
		array[0, 3] = array[0, 5] * array[0, 1];
		materialCost = array[0, 0] * num2;
		if (typPK == 5 || typPK == 6)
		{
			double[,] array2 = new double[5, 6];
			array2 = ((typPK == 5) ? FlanetsKruglyj.MaterialFlanetsKruglyj(D, typProfil, number, 1) : FlanetsKruglyj.MaterialFlanetsKruglyj(D, typProfil, 2 * number, 2));
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

	public static double GetPriceRoundAirFlowPK(int D, int L, int markaStali, double tovchynaMetalu, int typPK, int typProfil, int vidbortovka)
	{
		double num = 1.0;
		L += vidbortovka;
		materialSpendingCommercialOffer = Math.PI * (double)D * (double)L / 1000000.0;
		switch (markaStali)
		{
		case 1:
		{
			if (tovchynaMetalu == 0.0)
			{
				tovchynaMetalu = ((D > 400) ? ((D <= 800) ? 0.7 : 0.9) : 0.5);
			}
			double num6 = tovchynaMetalu;
			double num7 = num6;
			num = ((num7 == 0.5) ? 287.5 : ((num7 == 0.65) ? 333.5 : ((num7 == 0.68) ? 333.5 : ((num7 == 0.7) ? 333.5 : ((num7 == 0.9) ? 400.0 : ((num7 == 1.0) ? 400.0 : ((num7 != 1.2) ? 0.0 : 173.19)))))));
			num *= 2.0;
			break;
		}
		case 2:
		{
			if (tovchynaMetalu == 0.0)
			{
				tovchynaMetalu = ((D > 400) ? ((D <= 800) ? 0.8 : 1.0) : 0.5);
			}
			double num4 = tovchynaMetalu;
			double num5 = num4;
			num = ((num5 == 0.5) ? 115.0 : ((num5 == 0.8) ? 115.0 : ((num5 == 1.0) ? 134.78 : ((num5 == 1.2) ? 134.78 : ((num5 == 1.5) ? 173.19 : ((num5 == 2.0) ? 173.19 : ((num5 == 2.5) ? 173.19 : ((num5 == 3.0) ? 173.19 : ((num5 == 4.0) ? 173.19 : ((num5 == 5.0) ? 173.19 : ((num5 != 6.0) ? 0.0 : 173.19)))))))))));
			num *= 1.8;
			break;
		}
		case 3:
		{
			if (tovchynaMetalu == 0.0)
			{
				tovchynaMetalu = ((D > 400) ? ((D <= 800) ? 0.8 : 1.0) : 0.5);
			}
			double num2 = tovchynaMetalu;
			double num3 = num2;
			num = ((num3 == 0.5) ? 110.0 : ((num3 == 0.8) ? 200.0 : ((num3 == 1.0) ? 250.0 : ((num3 == 1.2) ? 300.0 : ((num3 != 1.5) ? 0.0 : 400.0)))));
			num *= 1.7;
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
		if (typPK == 5 || typPK == 6)
		{
			FlanetsKruglyj.MaterialFlanetsKruglyj(D, typProfil, 1, 1);
			num8 += ((typPK == 5) ? FlanetsKruglyj.priceProduct1 : (2.0 * FlanetsKruglyj.priceProduct1));
		}
		tovchynaMetaluCommercialOffer = tovchynaMetalu;
		return num8;
	}

	public static double[] FormPriceRoundAirFlowPK()
	{
		double[] array = new double[24];
		int[] array2 = new int[24]
		{
			100, 110, 125, 140, 160, 180, 200, 225, 250, 280,
			315, 355, 400, 450, 500, 560, 630, 710, 800, 900,
			1000, 1120, 1250, 1400
		};
		for (int i = 0; i < array.Length; i++)
		{
			if (array2[i] <= 400)
			{
				array[i] = 287.5;
			}
			else
			{
				array[i] = ((array2[i] <= 800) ? 333.5 : 400.0);
			}
			array[i] = Math.PI * (double)array2[i] * array[i] * 2.0 / 1000.0;
		}
		return array;
	}

	public static double VolumeRoundAirFlowPK(int D, int L)
	{
		return Math.Round((double)D * (double)D * (double)L / 1000000.0) / 1000.0;
	}
}
