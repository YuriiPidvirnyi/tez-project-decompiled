using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace TEZ_Project.Common.Helpers;

public static class MaterialHelper
{
	public static double[,] RoundMaterialSpending(double[,] materialSpending, int idx, List<int> skipNumbers = null)
	{
		if (skipNumbers == null || !skipNumbers.Contains(0))
		{
			if (materialSpending[idx, 0] < 0.005)
			{
				materialSpending[idx, 0] = Math.Round(1000.0 * materialSpending[idx, 0]) / 1000.0;
			}
			else
			{
				materialSpending[idx, 0] = Math.Round(100.0 * materialSpending[idx, 0]) / 100.0;
			}
		}
		if (skipNumbers == null || !skipNumbers.Contains(2))
		{
			if (materialSpending[idx, 2] < 0.005)
			{
				materialSpending[idx, 2] = Math.Round(1000.0 * materialSpending[idx, 2]) / 1000.0;
			}
			else
			{
				materialSpending[idx, 2] = Math.Round(100.0 * materialSpending[idx, 2]) / 100.0;
			}
		}
		if (skipNumbers == null || !skipNumbers.Contains(3))
		{
			if (materialSpending[idx, 3] < 0.005)
			{
				materialSpending[idx, 3] = Math.Round(1000.0 * materialSpending[idx, 3]) / 1000.0;
			}
			else
			{
				materialSpending[idx, 3] = Math.Round(100.0 * materialSpending[idx, 3]) / 100.0;
			}
		}
		if (skipNumbers == null || !skipNumbers.Contains(4))
		{
			if (materialSpending[idx, 4] < 0.005)
			{
				materialSpending[idx, 4] = Math.Round(1000.0 * materialSpending[idx, 4]) / 1000.0;
			}
			else
			{
				materialSpending[idx, 4] = Math.Round(100.0 * materialSpending[idx, 4]) / 100.0;
			}
		}
		if (skipNumbers == null || !skipNumbers.Contains(5))
		{
			if (materialSpending[idx, 5] < 0.005)
			{
				materialSpending[idx, 5] = Math.Round(1000.0 * materialSpending[idx, 5]) / 1000.0;
			}
			else
			{
				materialSpending[idx, 5] = Math.Round(100.0 * materialSpending[idx, 5]) / 100.0;
			}
		}
		return materialSpending;
	}

	public static int GetAmountOfPruzyn(int value)
	{
		if (value < 200)
		{
			return 1;
		}
		if (value < 315)
		{
			return 2;
		}
		if (value < 400)
		{
			return 3;
		}
		return 4;
	}

	public static CustomConst GetHofrovstavka(int d)
	{
		if (d <= 100)
		{
			return Consts2.hofrovstavka400x100;
		}
		if (d <= 125)
		{
			return Consts2.hofrovstavka453x125;
		}
		if (d <= 150)
		{
			return Consts2.hofrovstavka506x150;
		}
		if (d <= 160)
		{
			return Consts2.hofrovstavka526x160;
		}
		if (d <= 200)
		{
			return Consts2.hofrovstavka606x200;
		}
		if (d <= 250)
		{
			return Consts2.hofrovstavka796x250;
		}
		if (d <= 315)
		{
			return Consts2.hofrovstavka916x315;
		}
		return null;
	}

	public static double GetAzot(int d)
	{
		if (d <= 100)
		{
			return 0.004;
		}
		if (d <= 160)
		{
			return 0.005;
		}
		if (d <= 200)
		{
			return 0.006;
		}
		if (d <= 250)
		{
			return 0.007;
		}
		if (d <= 315)
		{
			return 0.008;
		}
		if (d <= 355)
		{
			return 0.009;
		}
		return 0.01;
	}

	public static int GetAdditionalLengthFromVidbortovka(string vidbortovka)
	{
		int num = 0;
		if (string.IsNullOrEmpty(vidbortovka))
		{
			return num;
		}
		List<string> list = Enumerable.ToList<string>((IEnumerable<string>)Regex.Split(vidbortovka, "\\D+"));
		foreach (string item in list)
		{
			if (int.TryParse(item, out var result))
			{
				num += result;
			}
		}
		return num;
	}

	public static (string, double) GetKlapanServopryvidData(int servopryvid)
	{
		string item = null;
		double item2 = 0.0;
		switch (servopryvid)
		{
		case 1:
			item = Consts2.servopryvidCM_24.MaterialName;
			item2 = Consts2.servopryvidCM_24.Price;
			break;
		case 2:
			item = Consts2.servopryvidCM_230.MaterialName;
			item2 = Consts2.servopryvidCM_230.Price;
			break;
		case 3:
			item = Consts2.servopryvidLM_24.MaterialName;
			item2 = Consts2.servopryvidLM_24.Price;
			break;
		case 4:
			item = Consts2.servopryvidLM_230.MaterialName;
			item2 = Consts2.servopryvidLM_230.Price;
			break;
		case 5:
			item = Consts2.servopryvidTF_24.MaterialName;
			item2 = Consts2.servopryvidTF_24.Price;
			break;
		case 6:
			item = Consts2.servopryvidTF_230.MaterialName;
			item2 = Consts2.servopryvidTF_230.Price;
			break;
		case 7:
			item = Consts2.servopryvidLF_24.MaterialName;
			item2 = Consts2.servopryvidLF_24.Price;
			break;
		case 8:
			item = Consts2.servopryvidLF_230.MaterialName;
			item2 = Consts2.servopryvidLF_230.Price;
			break;
		}
		return (item, item2);
	}

	public static int GetKlapanServopryvidByStr(string servopryvid)
	{
		return servopryvid switch
		{
			"CM 24" => 1, 
			"CM 230" => 2, 
			"LM 24" => 3, 
			"LM 230" => 4, 
			"TF 24" => 5, 
			"TF 230" => 6, 
			"LF 24" => 7, 
			"LF 230" => 8, 
			_ => 0, 
		};
	}

	public static CustomConst GetLystNerzavijuchyj(double tovchynaMetalu, string aisiType = "430")
	{
		if (tovchynaMetalu != 0.5)
		{
			if (tovchynaMetalu != 0.8)
			{
				if (tovchynaMetalu != 1.0)
				{
					if (tovchynaMetalu != 1.2)
					{
						if (tovchynaMetalu == 1.5)
						{
							return aisiType switch
							{
								"201" => Consts2.lystNerzavijuchyj15_201, 
								"304" => Consts2.lystNerzavijuchyj15_304, 
								"316" => Consts2.lystNerzavijuchyj15_316, 
								"321" => Consts2.lystNerzavijuchyj15_321, 
								_ => Consts2.lystNerzavijuchyj15, 
							};
						}
						return null;
					}
					return aisiType switch
					{
						"201" => Consts2.lystNerzavijuchyj12_201, 
						"304" => Consts2.lystNerzavijuchyj12_304, 
						"316" => Consts2.lystNerzavijuchyj12_316, 
						"321" => Consts2.lystNerzavijuchyj12_321, 
						_ => Consts2.lystNerzavijuchyj12, 
					};
				}
				return aisiType switch
				{
					"201" => Consts2.lystNerzavijuchyj10_201, 
					"304" => Consts2.lystNerzavijuchyj10_304, 
					"316" => Consts2.lystNerzavijuchyj10_316, 
					"321" => Consts2.lystNerzavijuchyj10_321, 
					_ => Consts2.lystNerzavijuchyj10, 
				};
			}
			return aisiType switch
			{
				"201" => Consts2.lystNerzavijuchyj08_201, 
				"304" => Consts2.lystNerzavijuchyj08_304, 
				"316" => Consts2.lystNerzavijuchyj08_316, 
				"321" => Consts2.lystNerzavijuchyj08_321, 
				_ => Consts2.lystNerzavijuchyj08, 
			};
		}
		return aisiType switch
		{
			"201" => Consts2.lystNerzavijuchyj05_201, 
			"304" => Consts2.lystNerzavijuchyj05_304, 
			"316" => Consts2.lystNerzavijuchyj05_316, 
			"321" => Consts2.lystNerzavijuchyj05_321, 
			_ => Consts2.lystNerzavijuchyj05, 
		};
	}

	public static double GetMaterialWithdrawalNerzavijka(double tovchynaMetalu)
	{
		if (tovchynaMetalu != 0.5)
		{
			if (tovchynaMetalu != 0.8)
			{
				if (tovchynaMetalu != 1.0)
				{
					if (tovchynaMetalu != 1.2)
					{
						if (tovchynaMetalu == 1.5)
						{
							return 10.0;
						}
						return 5.0;
					}
					return 10.0;
				}
				return 10.0;
			}
			return 10.0;
		}
		return 5.0;
	}
}
