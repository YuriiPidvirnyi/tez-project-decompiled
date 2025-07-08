using System;
using TEZ_Project.Common.Data;
using TEZ_Project.Common.Helpers;
using TEZ_Project;

namespace TEZ_Project.Common.Products;

public static class NipelNZK
{
	public static string[] materialName = new string[1] { "" };

	public static double materialCost;

	public static double materialSpendingCommercialOffer = 0.0;

	public static double tovchynaMetaluCommercialOffer = 0.0;

	public static double[] MaterialNipelNZK(int D, int markaStali, double tovchynaMetalu, int number, string aisiType = "430")
	{
		double[] array = new double[6];
		double num = 0.0;
		double num2 = 0.0;
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
		array[0] = ((D <= 630) ? 100.0 : 137.0);
		array[0] = array[0] * (3.14 * (double)D / 1000.0 + 0.01) / 1000.0;
		array[0] *= 1.05;
		materialCost = array[0] * num2;
		if (array[0] < 0.005)
		{
			array[0] = Math.Round(1000.0 * array[0]) / 1000.0;
		}
		else
		{
			array[0] = Math.Round(100.0 * array[0]) / 100.0;
		}
		array[1] = 0.05;
		array[4] = array[0] * (double)number;
		array[5] = array[4] * num * tovchynaMetalu / 1000.0;
		array[2] = array[4] * array[1];
		array[3] = array[5] * array[1];
		return array;
	}

	public static double PriceNipelNZK(int D, int markaStali, double tovchynaMetalu)
	{
		double num = 0.0;
		double num2 = 1.0;
		materialSpendingCommercialOffer = ((D <= 630) ? 100.0 : 137.0);
		materialSpendingCommercialOffer = materialSpendingCommercialOffer * (3.14 * (double)D / 1000.0 + 0.01) / 1000.0;
		switch (markaStali)
		{
		case 1:
		{
			if (tovchynaMetalu == 0.0)
			{
				tovchynaMetalu = ((D > 400) ? ((D <= 800) ? 0.7 : 0.9) : 0.5);
			}
			double num7 = tovchynaMetalu;
			double num8 = num7;
			num2 = ((num8 == 0.5) ? 287.5 : ((num8 == 0.65) ? 333.5 : ((num8 == 0.68) ? 333.5 : ((num8 == 0.7) ? 333.5 : ((num8 == 0.9) ? 400.0 : ((num8 == 1.0) ? 400.0 : ((num8 != 1.2) ? 0.0 : 173.19)))))));
			num2 *= 2.2;
			break;
		}
		case 2:
		{
			if (tovchynaMetalu == 0.0)
			{
				tovchynaMetalu = ((D > 400) ? ((D <= 800) ? 0.8 : 1.0) : 0.5);
			}
			double num5 = tovchynaMetalu;
			double num6 = num5;
			num2 = ((num6 == 0.5) ? 115.0 : ((num6 == 0.8) ? 115.0 : ((num6 == 1.0) ? 134.78 : ((num6 == 1.2) ? 134.78 : ((num6 == 1.5) ? 173.19 : ((num6 == 2.0) ? 173.19 : ((num6 == 2.5) ? 173.19 : ((num6 == 3.0) ? 173.19 : ((num6 == 4.0) ? 173.19 : ((num6 == 5.0) ? 173.19 : ((num6 != 6.0) ? 0.0 : 173.19)))))))))));
			num2 *= 1.8;
			break;
		}
		case 3:
		{
			if (tovchynaMetalu == 0.0)
			{
				tovchynaMetalu = ((D > 400) ? ((D <= 800) ? 0.8 : 1.0) : 0.5);
			}
			double num3 = tovchynaMetalu;
			double num4 = num3;
			num2 = ((num4 == 0.5) ? 110.0 : ((num4 == 0.8) ? 200.0 : ((num4 == 1.0) ? 250.0 : ((num4 == 1.2) ? 300.0 : ((num4 != 1.5) ? 0.0 : 400.0)))));
			num2 *= 1.7;
			break;
		}
		}
		num = materialSpendingCommercialOffer * num2;
		if (materialSpendingCommercialOffer < 0.005)
		{
			materialSpendingCommercialOffer = Math.Round(1000.0 * materialSpendingCommercialOffer) / 1000.0;
		}
		else
		{
			materialSpendingCommercialOffer = Math.Round(100.0 * materialSpendingCommercialOffer) / 100.0;
		}
		tovchynaMetaluCommercialOffer = tovchynaMetalu;
		return num;
	}

	public static double[] FormPriceNipelNZK()
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
			double num = ((array2[i] <= 630) ? 100.0 : 137.0);
			num = num * (3.14 * (double)array2[i] / 1000.0 + 0.01) / 1000.0;
			if (array2[i] <= 400)
			{
				array[i] = 287.5;
			}
			else
			{
				array[i] = ((array2[i] <= 800) ? 333.5 : 400.0);
			}
			array[i] = num * array[i] * 2.2;
		}
		return array;
	}

	public static double VolumeNipelNZK(int D)
	{
		double num = ((D <= 630) ? 100.0 : 137.0);
		return Math.Round((double)D * (double)D * num / 1000000.0) / 1000.0;
	}
}
