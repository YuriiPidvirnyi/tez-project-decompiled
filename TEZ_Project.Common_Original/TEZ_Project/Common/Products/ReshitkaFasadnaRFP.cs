using System;

namespace TEZ_Project.Common.Products;

public static class ReshitkaFasadnaRFP
{
	public static string[] materialName = new string[3] { "", "", "" };

	public static double materialCost;

	public static double priceProduct;

	public static double[,] MaterialReshitkaFasadnaRFP(int B, int H, int number, int markaStali, double tovchynaMetalu = 0.0)
	{
		double[,] array = new double[3, 6];
		int num = 0;
		int num2 = ((B >= H) ? B : H);
		double num3 = 0.0;
		double num4 = 0.0;
		double num5 = 0.0;
		int num6 = 0;
		materialName = new string[3] { "", "", "" };
		priceProduct = 0.0;
		materialCost = 0.0;
		switch (markaStali)
		{
		case 1:
		{
			if (tovchynaMetalu == 0.0)
			{
				tovchynaMetalu = ((num2 > 400) ? ((num2 <= 800) ? 0.7 : 0.9) : 0.5);
			}
			num3 = 7825.0;
			double num9 = tovchynaMetalu;
			double num10 = num9;
			if (num10 != 0.5)
			{
				if (num10 != 0.65)
				{
					if (num10 != 0.68)
					{
						if (num10 != 0.7)
						{
							if (num10 != 0.9)
							{
								if (num10 != 1.0)
								{
									if (num10 == 1.2)
									{
										materialName[num] = Consts2.lystOchynkovanyj12.MaterialName;
										num4 = Consts2.lystOchynkovanyj12.Price;
										num5 = 10.0;
									}
									else
									{
										materialName[num] = "Лист ОЦ ??, м2";
									}
								}
								else
								{
									materialName[num] = Consts2.lystOchynkovanyj10.MaterialName;
									num4 = Consts2.lystOchynkovanyj10.Price;
									num5 = 10.0;
								}
							}
							else
							{
								materialName[num] = Consts2.lystOchynkovanyj09.MaterialName;
								num4 = Consts2.lystOchynkovanyj09.Price;
								num5 = 10.0;
							}
						}
						else
						{
							materialName[num] = Consts2.lystOchynkovanyj07.MaterialName;
							num4 = Consts2.lystOchynkovanyj07.Price;
							num5 = 10.0;
						}
					}
					else
					{
						materialName[num] = Consts2.lystOchynkovanyj068.MaterialName;
						num4 = Consts2.lystOchynkovanyj068.Price;
						num5 = 10.0;
					}
				}
				else
				{
					materialName[num] = Consts2.lystOchynkovanyj065.MaterialName;
					num4 = Consts2.lystOchynkovanyj065.Price;
					num5 = 10.0;
				}
			}
			else
			{
				materialName[num] = Consts2.lystOchynkovanyj05.MaterialName;
				num4 = Consts2.lystOchynkovanyj05.Price;
				num5 = 5.0;
			}
			break;
		}
		case 2:
		{
			if (tovchynaMetalu == 0.0)
			{
				tovchynaMetalu = ((num2 > 400) ? ((num2 <= 800) ? 0.8 : 1.0) : 0.5);
			}
			num3 = 7825.0;
			double num11 = tovchynaMetalu;
			double num12 = num11;
			if (num12 != 0.5)
			{
				if (num12 != 0.8)
				{
					if (num12 != 1.0)
					{
						if (num12 != 1.2)
						{
							if (num12 != 1.5)
							{
								if (num12 != 2.0)
								{
									if (num12 != 2.5)
									{
										if (num12 != 3.0)
										{
											if (num12 != 4.0)
											{
												if (num12 != 5.0)
												{
													if (num12 == 6.0)
													{
														materialName[num] = Consts2.lystStalnyj60.MaterialName;
														num4 = Consts2.lystStalnyj60.Price;
														num5 = 10.0;
													}
													else
													{
														materialName[num] = "Лист СТ ??, м2";
													}
												}
												else
												{
													materialName[num] = Consts2.lystStalnyj50.MaterialName;
													num4 = Consts2.lystStalnyj50.Price;
													num5 = 10.0;
												}
											}
											else
											{
												materialName[num] = Consts2.lystStalnyj40.MaterialName;
												num4 = Consts2.lystStalnyj40.Price;
												num5 = 10.0;
											}
										}
										else
										{
											materialName[num] = Consts2.lystStalnyj30.MaterialName;
											num4 = Consts2.lystStalnyj30.Price;
											num5 = 10.0;
										}
									}
									else
									{
										materialName[num] = Consts2.lystStalnyj25.MaterialName;
										num4 = Consts2.lystStalnyj25.Price;
										num5 = 10.0;
									}
								}
								else
								{
									materialName[num] = Consts2.lystStalnyj20.MaterialName;
									num4 = Consts2.lystStalnyj20.Price;
									num5 = 10.0;
								}
							}
							else
							{
								materialName[num] = Consts2.lystStalnyj15.MaterialName;
								num4 = Consts2.lystStalnyj15.Price;
								num5 = 10.0;
							}
						}
						else
						{
							materialName[num] = Consts2.lystStalnyj12.MaterialName;
							num4 = Consts2.lystStalnyj12.Price;
							num5 = 10.0;
						}
					}
					else
					{
						materialName[num] = Consts2.lystStalnyj10.MaterialName;
						num4 = Consts2.lystStalnyj10.Price;
						num5 = 10.0;
					}
				}
				else
				{
					materialName[num] = Consts2.lystStalnyj08.MaterialName;
					num4 = Consts2.lystStalnyj08.Price;
					num5 = 10.0;
				}
			}
			else
			{
				materialName[num] = Consts2.lystStalnyj05.MaterialName;
				num4 = Consts2.lystStalnyj05.Price;
				num5 = 5.0;
			}
			break;
		}
		case 3:
		{
			if (tovchynaMetalu == 0.0)
			{
				tovchynaMetalu = ((num2 > 400) ? ((num2 <= 800) ? 0.8 : 1.0) : 0.5);
			}
			num3 = 7825.0;
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
							if (num8 == 1.5)
							{
								materialName[num] = Consts2.lystNerzavijuchyj15.MaterialName;
								num4 = Consts2.lystNerzavijuchyj15.Price;
								num5 = 10.0;
							}
							else
							{
								materialName[num] = "Лист НЕРЖ ??, м2";
							}
						}
						else
						{
							materialName[num] = Consts2.lystNerzavijuchyj12.MaterialName;
							num4 = Consts2.lystNerzavijuchyj12.Price;
							num5 = 10.0;
						}
					}
					else
					{
						materialName[num] = Consts2.lystNerzavijuchyj10.MaterialName;
						num4 = Consts2.lystNerzavijuchyj10.Price;
						num5 = 10.0;
					}
				}
				else
				{
					materialName[num] = Consts2.lystNerzavijuchyj08.MaterialName;
					num4 = Consts2.lystNerzavijuchyj08.Price;
					num5 = 10.0;
				}
			}
			else
			{
				materialName[num] = Consts2.lystNerzavijuchyj05.MaterialName;
				num4 = Consts2.lystNerzavijuchyj05.Price;
				num5 = 5.0;
			}
			break;
		}
		}
		if (num2 <= 350)
		{
			array[num, 0] = (0.06 * (double)(B + 20) * Math.Ceiling((double)H / 25.0 - 1.0) + (double)((B + 50 + H + 50) * 2) * 0.09) * (1.0 + num5 / 100.0) / 1000.0;
		}
		else
		{
			array[num, 0] = ((double)B + 70.0 + (double)H + 70.0) * 2.0 * 0.115 * (1.0 + num5 / 100.0) / 1000.0;
		}
		array[num, 1] = num5 / 100.0;
		array[num, 4] = array[num, 0] * (double)number;
		array[num, 5] = array[num, 4] * num3 * tovchynaMetalu / 1000.0;
		array[num, 2] = array[num, 4] * array[num, 1];
		array[num, 3] = array[num, 5] * array[num, 1];
		if (array[num, 0] < 0.005)
		{
			array[num, 0] = Math.Round(1000.0 * array[num, 0]) / 1000.0;
		}
		else
		{
			array[num, 0] = Math.Round(100.0 * array[num, 0]) / 100.0;
		}
		if (array[num, 2] < 0.005)
		{
			array[num, 2] = Math.Round(1000.0 * array[num, 2]) / 1000.0;
		}
		else
		{
			array[num, 2] = Math.Round(100.0 * array[num, 2]) / 100.0;
		}
		if (array[num, 3] < 0.005)
		{
			array[num, 3] = Math.Round(1000.0 * array[num, 3]) / 1000.0;
		}
		else
		{
			array[num, 3] = Math.Round(100.0 * array[num, 3]) / 100.0;
		}
		if (array[num, 4] < 0.005)
		{
			array[num, 4] = Math.Round(1000.0 * array[num, 4]) / 1000.0;
		}
		else
		{
			array[num, 4] = Math.Round(100.0 * array[num, 4]) / 100.0;
		}
		if (array[num, 5] < 0.005)
		{
			array[num, 5] = Math.Round(1000.0 * array[num, 5]) / 1000.0;
		}
		else
		{
			array[num, 5] = Math.Round(100.0 * array[num, 5]) / 100.0;
		}
		priceProduct = array[num, 0] * num4;
		if (num2 > 350)
		{
			num++;
			materialName[num] = Consts2.lystOchynkovanyj09.MaterialName;
			if (B >= 1000)
			{
				num6 = 2;
			}
			else if (B >= 600)
			{
				num6 = 1;
			}
			array[num, 0] = ((double)B * 60.0 * Math.Floor((double)H / 28.0) + (double)(H + 70) * 40.0 * (double)num6) * 1.05 / 1000000.0;
			array[num, 1] = 0.05;
			array[num, 4] = array[num, 0] * (double)number;
			array[num, 5] = array[num, 4] * 7825.0 * 0.9 / 1000.0;
			array[num, 2] = array[num, 4] * array[num, 1];
			array[num, 3] = array[num, 5] * array[num, 1];
			if (array[num, 0] < 0.005)
			{
				array[num, 0] = Math.Round(1000.0 * array[num, 0]) / 1000.0;
			}
			else
			{
				array[num, 0] = Math.Round(100.0 * array[num, 0]) / 100.0;
			}
			if (array[num, 2] < 0.005)
			{
				array[num, 2] = Math.Round(1000.0 * array[num, 2]) / 1000.0;
			}
			else
			{
				array[num, 2] = Math.Round(100.0 * array[num, 2]) / 100.0;
			}
			if (array[num, 3] < 0.005)
			{
				array[num, 3] = Math.Round(1000.0 * array[num, 3]) / 1000.0;
			}
			else
			{
				array[num, 3] = Math.Round(100.0 * array[num, 3]) / 100.0;
			}
			if (array[num, 4] < 0.005)
			{
				array[num, 4] = Math.Round(1000.0 * array[num, 4]) / 1000.0;
			}
			else
			{
				array[num, 4] = Math.Round(100.0 * array[num, 4]) / 100.0;
			}
			if (array[num, 5] < 0.005)
			{
				array[num, 5] = Math.Round(1000.0 * array[num, 5]) / 1000.0;
			}
			else
			{
				array[num, 5] = Math.Round(100.0 * array[num, 5]) / 100.0;
			}
			priceProduct += array[num, 0] * Consts2.lystOchynkovanyj09.Price;
		}
		num++;
		materialName[num] = Consts2.zaklepkaKombinov4x10.MaterialName;
		array[num, 0] = ((num2 <= 350) ? 4.0 : ((Math.Floor((double)H / 28.0) + 4.0) * (double)num6 + 8.0));
		array[num, 4] = array[num, 0] * (double)number;
		priceProduct += array[num, 0] * Consts2.zaklepkaKombinov4x10.Price;
		materialCost = priceProduct;
		priceProduct *= 3.0;
		return array;
	}

	public static double VolumeReshitkaFasadnaRFP(int B, int H)
	{
		int num = ((B > H) ? B : H);
		return (num <= 350) ? (Math.Round(((double)B + 50.0) * ((double)H + 50.0) * 90.0 / 1000000.0) / 1000.0) : (Math.Round(((double)B + 70.0) * ((double)H + 70.0) * 115.0 / 1000000.0) / 1000.0);
	}
}
