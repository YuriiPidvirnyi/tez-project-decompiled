using System;
using System.Drawing;
using TEZ_Project.Common.Helpers;

namespace TEZ_Project.Common.Products;

public class AluminiumGrid
{
	public static string[] materialName = new string[32]
	{
		"", "", "", "", "", "", "", "", "", "",
		"", "", "", "", "", "", "", "", "", "",
		"", "", "", "", "", "", "", "", "", "",
		"", ""
	};

	public static double materialCost;

	public static double priceProduct = 0.0;

	public static string[] materialName1 = new string[2] { "", "" };

	public static double[,] MaterialAluminiumGrid(int B, int H, string typReshitky, string ral, bool checkBoxAnodovane, string sposibKriplennja, bool notRegular, int number, bool IsFasadna, bool hasSitka = false)
	{
		double[,] array = new double[32, 6];
		int num = -1;
		double num2 = 0.0;
		bool flag = typReshitky == "однорядна";
		bool flag2 = B >= 600;
		materialName = new string[32]
		{
			"", "", "", "", "", "", "", "", "", "",
			"", "", "", "", "", "", "", "", "", "",
			"", "", "", "", "", "", "", "", "", "",
			"", ""
		};
		materialCost = 0.0;
		priceProduct = 0.0;
		num++;
		CustomConst customConst = (flag ? Consts2.lystOchynkovanyj12 : Consts2.lystOchynkovanyjKutnyk);
		materialName[num] = customConst.MaterialName;
		array[num, 0] = 0.0081;
		array[num, 4] = array[num, 0] * (double)number;
		array[num, 5] = array[num, 4] * 7825.0 * 0.0005;
		materialCost += array[num, 0] * customConst.Price;
		num++;
		materialName[num] = Consts2.klipsaReshVent.MaterialName;
		array[num, 0] = 4.0;
		array[num, 4] = array[num, 0] * (double)number;
		materialCost += array[num, 0] * Consts2.klipsaReshVent.Price;
		num++;
		CustomConst customConst2 = (IsFasadna ? Consts2.profilAlum3319 : (checkBoxAnodovane ? Consts2.profilAlumLamelAnodovan : Consts2.profilAlumLamel));
		materialName[num] = customConst2.MaterialName;
		num2 = customConst2.Price;
		double num3 = ((double)B + 8.0) / 1000.0 * Math.Round((double)H / 24.0);
		if (typReshitky == "дворядна")
		{
			num3 += ((double)H + 8.0) / 1000.0 * Math.Round((double)B / 24.0);
		}
		array[num, 0] = num3;
		array[num, 0] *= 1.05;
		array[num, 1] = 0.05;
		array[num, 4] = array[num, 0] * (double)number;
		array[num, 2] = array[num, 4] * array[num, 1];
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
		if (array[num, 4] < 0.005)
		{
			array[num, 4] = Math.Round(1000.0 * array[num, 4]) / 1000.0;
		}
		else
		{
			array[num, 4] = Math.Round(100.0 * array[num, 4]) / 100.0;
		}
		materialCost += array[num, 0] * num2;
		num++;
		CustomConst customConst3 = (IsFasadna ? Consts2.profilAlumLamel3320 : ((!checkBoxAnodovane) ? (flag ? Consts2.profilAlumOdnor : Consts2.profilAlumDvor) : (flag ? Consts2.profilAlumOdnorAnodovan : Consts2.profilAlumDvorAnodovan)));
		materialName[num] = customConst3.MaterialName;
		num2 = customConst3.Price;
		array[num, 0] = (double)(B + 54) / 1000.0 * 2.0 + (double)(H + 54) / 1000.0 * 2.0;
		array[num, 0] *= 1.05;
		array[num, 1] = 0.05;
		array[num, 4] = array[num, 0] * (double)number;
		array[num, 2] = array[num, 4] * array[num, 1];
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
		if (array[num, 4] < 0.005)
		{
			array[num, 4] = Math.Round(1000.0 * array[num, 4]) / 1000.0;
		}
		else
		{
			array[num, 4] = Math.Round(100.0 * array[num, 4]) / 100.0;
		}
		materialCost += array[num, 0] * num2;
		if (flag2)
		{
			num++;
			CustomConst customConst4 = (checkBoxAnodovane ? Consts2.progilAlumBPOAnodovan : Consts2.progilAlumBPO);
			materialName[num] = customConst4.MaterialName;
			num2 = customConst4.Price;
			array[num, 0] = ((double)H + 10.0) / 1000.0;
			array[num, 0] *= 1.05;
			array[num, 1] = 0.05;
			array[num, 4] = array[num, 0] * (double)number;
			array[num, 2] = array[num, 4] * array[num, 1];
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
			if (array[num, 4] < 0.005)
			{
				array[num, 4] = Math.Round(1000.0 * array[num, 4]) / 1000.0;
			}
			else
			{
				array[num, 4] = Math.Round(100.0 * array[num, 4]) / 100.0;
			}
			materialCost += array[num, 0] * num2;
		}
		if (!notRegular)
		{
			num++;
			materialName[num] = Consts2.dritAlumLamel.MaterialName;
			num2 = Consts2.dritAlumLamel.Price;
			double num4 = ((!flag) ? ((double)(2 * H) / 1000.0 + 0.08 + ((double)(2 * B) / 1000.0 + 0.08)) : (flag2 ? (((double)(2 * H) / 1000.0 + 0.08) * 2.0) : ((double)(2 * H) / 1000.0 + 0.08)));
			array[num, 0] = num4;
			array[num, 4] = array[num, 0] * (double)number;
			array[num, 5] = array[num, 4] * 7.85E-07 * 7820.0;
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
			materialCost += array[num, 0] * num2;
		}
		if (!checkBoxAnodovane && ral != "Нефарбована")
		{
			GetFarba(ral, out var farbaName, out var farbaPrice);
			num++;
			materialName[num] = farbaName;
			double num5 = (flag2 ? 0.19 : (flag ? 0.05 : 0.04));
			array[num, 0] = num5;
			array[num, 4] = array[num, 0] * (double)number;
			materialCost += array[num, 0] * farbaPrice;
		}
		if (sposibKriplennja == "отвори потай + гвинт 3.5х25")
		{
			num++;
			materialName[num] = Consts2.gvynt35.MaterialName;
			array[num, 0] = 8.0;
			array[num, 4] = array[num, 0] * (double)number;
			materialCost += array[num, 0] * Consts2.gvynt35.Price;
		}
		if (sposibKriplennja == "затискач")
		{
			num++;
			materialName[num] = Consts2.zatyscach.MaterialName;
			array[num, 0] = 2.0;
			array[num, 4] = array[num, 0] * (double)number;
			materialCost += array[num, 0] * Consts2.zatyscach.Price;
		}
		if (IsFasadna && hasSitka)
		{
			num++;
			materialName[num] = Consts2.sitka10x10.MaterialName;
			num2 = Consts2.sitka10x10.Price;
			if (B == 200)
			{
				array[num, 0] = 275.0;
			}
			else if (B <= 250)
			{
				array[num, 0] = 315.0;
			}
			else if (B <= 300)
			{
				array[num, 0] = 355.0;
			}
			else if (B <= 350)
			{
				array[num, 0] = 455.0;
			}
			else if (B <= 400)
			{
				array[num, 0] = 495.0;
			}
			else if (B <= 450)
			{
				array[num, 0] = 500.0;
			}
			else if (B <= 500)
			{
				array[num, 0] = 635.0;
			}
			else if (B <= 550)
			{
				array[num, 0] = 675.0;
			}
			else if (B <= 600)
			{
				array[num, 0] = 775.0;
			}
			else if (B <= 650)
			{
				array[num, 0] = 815.0;
			}
			else if (B <= 700)
			{
				array[num, 0] = 855.0;
			}
			else if (B <= 750)
			{
				array[num, 0] = 955.0;
			}
			else if (B <= 800)
			{
				array[num, 0] = 995.0;
			}
			else if (B <= 850)
			{
				array[num, 0] = 1030.0;
			}
			else if (B <= 900)
			{
				array[num, 0] = 1135.0;
			}
			else if (B <= 950)
			{
				array[num, 0] = 1175.0;
			}
			else if (B <= 1000)
			{
				array[num, 0] = 1210.0;
			}
			array[num, 0] = (double)H * array[num, 0] / 1000000.0;
			array[num, 4] = array[num, 0] * (double)number;
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
			if (array[num, 4] < 0.005)
			{
				array[num, 4] = Math.Round(1000.0 * array[num, 4]) / 1000.0;
			}
			else
			{
				array[num, 4] = Math.Round(100.0 * array[num, 4]) / 100.0;
			}
			materialCost += array[num, 0] * num2;
		}
		priceProduct = Math.Round(100.0 * materialCost * 3.0) / 100.0;
		return array;
	}

	private static void GetFarba(string ral, out string farbaName, out double farbaPrice)
	{
		switch (ral)
		{
		case "9016 Білий":
			farbaName = Consts2.farba9016W.MaterialName;
			farbaPrice = Consts2.farba9016W.Price;
			break;
		case "9016М Білий матовий":
			farbaName = Consts2.farba9016WM.MaterialName;
			farbaPrice = Consts2.farba9016WM.Price;
			break;
		case "9005 Чорний":
			farbaName = Consts2.farba9005B.MaterialName;
			farbaPrice = Consts2.farba9005B.Price;
			break;
		case "9005М Чорний матовий":
			farbaName = Consts2.farba9005BM.MaterialName;
			farbaPrice = Consts2.farba9005BM.Price;
			break;
		case "9001":
			farbaName = Consts2.farba9001.MaterialName;
			farbaPrice = Consts2.farba9001.Price;
			break;
		case "9001М":
			farbaName = Consts2.farba9001M.MaterialName;
			farbaPrice = Consts2.farba9001M.Price;
			break;
		case "9002":
			farbaName = Consts2.farba9002.MaterialName;
			farbaPrice = Consts2.farba9002.Price;
			break;
		case "9002М":
			farbaName = Consts2.farba9002M.MaterialName;
			farbaPrice = Consts2.farba9002M.Price;
			break;
		case "9003":
			farbaName = Consts2.farba9003.MaterialName;
			farbaPrice = Consts2.farba9003.Price;
			break;
		case "9003М":
			farbaName = Consts2.farba9003M.MaterialName;
			farbaPrice = Consts2.farba9003M.Price;
			break;
		case "9010":
			farbaName = Consts2.farba9010.MaterialName;
			farbaPrice = Consts2.farba9010.Price;
			break;
		case "9010М":
			farbaName = Consts2.farba9010M.MaterialName;
			farbaPrice = Consts2.farba9010M.Price;
			break;
		case "9004":
			farbaName = Consts2.farba9004.MaterialName;
			farbaPrice = Consts2.farba9004.Price;
			break;
		case "9004М":
			farbaName = Consts2.farba9004M.MaterialName;
			farbaPrice = Consts2.farba9004M.Price;
			break;
		case "90011":
			farbaName = Consts2.farba90011.MaterialName;
			farbaPrice = Consts2.farba90011.Price;
			break;
		case "90011М":
			farbaName = Consts2.farba90011M.MaterialName;
			farbaPrice = Consts2.farba90011M.Price;
			break;
		case "90017":
			farbaName = Consts2.farba90017.MaterialName;
			farbaPrice = Consts2.farba90017.Price;
			break;
		case "90017М":
			farbaName = Consts2.farba90017M.MaterialName;
			farbaPrice = Consts2.farba90017M.Price;
			break;
		case "1000":
			farbaName = Consts2.farba1000.MaterialName;
			farbaPrice = Consts2.farba1000.Price;
			break;
		case "1001":
			farbaName = Consts2.farba1001.MaterialName;
			farbaPrice = Consts2.farba1001.Price;
			break;
		case "1001М":
			farbaName = Consts2.farba1001M.MaterialName;
			farbaPrice = Consts2.farba1001M.Price;
			break;
		case "1002":
			farbaName = Consts2.farba1002.MaterialName;
			farbaPrice = Consts2.farba1002.Price;
			break;
		case "1003":
			farbaName = Consts2.farba1003.MaterialName;
			farbaPrice = Consts2.farba1003.Price;
			break;
		case "1004":
			farbaName = Consts2.farba1004.MaterialName;
			farbaPrice = Consts2.farba1004.Price;
			break;
		case "1005":
			farbaName = Consts2.farba1005.MaterialName;
			farbaPrice = Consts2.farba1005.Price;
			break;
		case "1005М":
			farbaName = Consts2.farba1005M.MaterialName;
			farbaPrice = Consts2.farba1005M.Price;
			break;
		case "1007":
			farbaName = Consts2.farba1007.MaterialName;
			farbaPrice = Consts2.farba1007.Price;
			break;
		case "1011":
			farbaName = Consts2.farba1011.MaterialName;
			farbaPrice = Consts2.farba1011.Price;
			break;
		case "1011М":
			farbaName = Consts2.farba1011M.MaterialName;
			farbaPrice = Consts2.farba1011M.Price;
			break;
		case "1012":
			farbaName = Consts2.farba1012.MaterialName;
			farbaPrice = Consts2.farba1012.Price;
			break;
		case "1013":
			farbaName = Consts2.farba1013.MaterialName;
			farbaPrice = Consts2.farba1013.Price;
			break;
		case "1013М":
			farbaName = Consts2.farba1013M.MaterialName;
			farbaPrice = Consts2.farba1013M.Price;
			break;
		case "1014":
			farbaName = Consts2.farba1014.MaterialName;
			farbaPrice = Consts2.farba1014.Price;
			break;
		case "1014М":
			farbaName = Consts2.farba1014M.MaterialName;
			farbaPrice = Consts2.farba1014M.Price;
			break;
		case "1015":
			farbaName = Consts2.farba1015.MaterialName;
			farbaPrice = Consts2.farba1015.Price;
			break;
		case "1015М":
			farbaName = Consts2.farba1015M.MaterialName;
			farbaPrice = Consts2.farba1015M.Price;
			break;
		case "1016":
			farbaName = Consts2.farba1016.MaterialName;
			farbaPrice = Consts2.farba1016.Price;
			break;
		case "1017":
			farbaName = Consts2.farba1017.MaterialName;
			farbaPrice = Consts2.farba1017.Price;
			break;
		case "1018":
			farbaName = Consts2.farba1018.MaterialName;
			farbaPrice = Consts2.farba1018.Price;
			break;
		case "1019":
			farbaName = Consts2.farba1019.MaterialName;
			farbaPrice = Consts2.farba1019.Price;
			break;
		case "1019М":
			farbaName = Consts2.farba1019M.MaterialName;
			farbaPrice = Consts2.farba1019.Price;
			break;
		case "1020":
			farbaName = Consts2.farba1020.MaterialName;
			farbaPrice = Consts2.farba1020.Price;
			break;
		case "1021":
			farbaName = Consts2.farba1021.MaterialName;
			farbaPrice = Consts2.farba1021.Price;
			break;
		case "1021М":
			farbaName = Consts2.farba1021M.MaterialName;
			farbaPrice = Consts2.farba1021M.Price;
			break;
		case "1023":
			farbaName = Consts2.farba1023.MaterialName;
			farbaPrice = Consts2.farba1023.Price;
			break;
		case "1023М":
			farbaName = Consts2.farba1023M.MaterialName;
			farbaPrice = Consts2.farba1023M.Price;
			break;
		case "1024":
			farbaName = Consts2.farba1024.MaterialName;
			farbaPrice = Consts2.farba1024.Price;
			break;
		case "1026":
			farbaName = Consts2.farba1026.MaterialName;
			farbaPrice = Consts2.farba1026.Price;
			break;
		case "1027":
			farbaName = Consts2.farba1027.MaterialName;
			farbaPrice = Consts2.farba1027.Price;
			break;
		case "1028":
			farbaName = Consts2.farba1028.MaterialName;
			farbaPrice = Consts2.farba1028.Price;
			break;
		case "1032":
			farbaName = Consts2.farba1032.MaterialName;
			farbaPrice = Consts2.farba1032.Price;
			break;
		case "1033":
			farbaName = Consts2.farba1033.MaterialName;
			farbaPrice = Consts2.farba1033.Price;
			break;
		case "1034":
			farbaName = Consts2.farba1034.MaterialName;
			farbaPrice = Consts2.farba1034.Price;
			break;
		case "1035":
			farbaName = Consts2.farba1035.MaterialName;
			farbaPrice = Consts2.farba1035.Price;
			break;
		case "1036":
			farbaName = Consts2.farba1036.MaterialName;
			farbaPrice = Consts2.farba1036.Price;
			break;
		case "1036М":
			farbaName = Consts2.farba1036M.MaterialName;
			farbaPrice = Consts2.farba1036M.Price;
			break;
		case "1037":
			farbaName = Consts2.farba1037.MaterialName;
			farbaPrice = Consts2.farba1037.Price;
			break;
		case "2000":
			farbaName = Consts2.farba2000.MaterialName;
			farbaPrice = Consts2.farba2000.Price;
			break;
		case "2001":
			farbaName = Consts2.farba2001.MaterialName;
			farbaPrice = Consts2.farba2001.Price;
			break;
		case "2002":
			farbaName = Consts2.farba2002.MaterialName;
			farbaPrice = Consts2.farba2002.Price;
			break;
		case "2003":
			farbaName = Consts2.farba2003.MaterialName;
			farbaPrice = Consts2.farba2003.Price;
			break;
		case "2004":
			farbaName = Consts2.farba2004.MaterialName;
			farbaPrice = Consts2.farba2004.Price;
			break;
		case "2008":
			farbaName = Consts2.farba2008.MaterialName;
			farbaPrice = Consts2.farba2008.Price;
			break;
		case "2009":
			farbaName = Consts2.farba2009.MaterialName;
			farbaPrice = Consts2.farba2009.Price;
			break;
		case "2010":
			farbaName = Consts2.farba2010.MaterialName;
			farbaPrice = Consts2.farba2010.Price;
			break;
		case "2011":
			farbaName = Consts2.farba2011.MaterialName;
			farbaPrice = Consts2.farba2011.Price;
			break;
		case "2012":
			farbaName = Consts2.farba2012.MaterialName;
			farbaPrice = Consts2.farba2012.Price;
			break;
		case "2013":
			farbaName = Consts2.farba2013.MaterialName;
			farbaPrice = Consts2.farba2013.Price;
			break;
		case "3000":
			farbaName = Consts2.farba3000.MaterialName;
			farbaPrice = Consts2.farba3000.Price;
			break;
		case "3001":
			farbaName = Consts2.farba3001.MaterialName;
			farbaPrice = Consts2.farba3001.Price;
			break;
		case "3002":
			farbaName = Consts2.farba3002.MaterialName;
			farbaPrice = Consts2.farba3002.Price;
			break;
		case "3003":
			farbaName = Consts2.farba3003.MaterialName;
			farbaPrice = Consts2.farba3003.Price;
			break;
		case "3004":
			farbaName = Consts2.farba3004.MaterialName;
			farbaPrice = Consts2.farba3004.Price;
			break;
		case "3005":
			farbaName = Consts2.farba3005.MaterialName;
			farbaPrice = Consts2.farba3005.Price;
			break;
		case "3005М":
			farbaName = Consts2.farba3005M.MaterialName;
			farbaPrice = Consts2.farba3005M.Price;
			break;
		case "3007":
			farbaName = Consts2.farba3007.MaterialName;
			farbaPrice = Consts2.farba3007.Price;
			break;
		case "3009":
			farbaName = Consts2.farba3009.MaterialName;
			farbaPrice = Consts2.farba3009.Price;
			break;
		case "3011":
			farbaName = Consts2.farba3011.MaterialName;
			farbaPrice = Consts2.farba3011.Price;
			break;
		case "3012":
			farbaName = Consts2.farba3012.MaterialName;
			farbaPrice = Consts2.farba3012.Price;
			break;
		case "3013":
			farbaName = Consts2.farba3013.MaterialName;
			farbaPrice = Consts2.farba3013.Price;
			break;
		case "3014":
			farbaName = Consts2.farba3014.MaterialName;
			farbaPrice = Consts2.farba3014.Price;
			break;
		case "3015":
			farbaName = Consts2.farba3015.MaterialName;
			farbaPrice = Consts2.farba3015.Price;
			break;
		case "3016":
			farbaName = Consts2.farba3016.MaterialName;
			farbaPrice = Consts2.farba3016.Price;
			break;
		case "3017":
			farbaName = Consts2.farba3017.MaterialName;
			farbaPrice = Consts2.farba3017.Price;
			break;
		case "3018":
			farbaName = Consts2.farba3018.MaterialName;
			farbaPrice = Consts2.farba3018.Price;
			break;
		case "3020":
			farbaName = Consts2.farba3020.MaterialName;
			farbaPrice = Consts2.farba3020.Price;
			break;
		case "3022":
			farbaName = Consts2.farba3022.MaterialName;
			farbaPrice = Consts2.farba3022.Price;
			break;
		case "3028":
			farbaName = Consts2.farba3028.MaterialName;
			farbaPrice = Consts2.farba3028.Price;
			break;
		case "3031":
			farbaName = Consts2.farba3031.MaterialName;
			farbaPrice = Consts2.farba3031.Price;
			break;
		case "3033":
			farbaName = Consts2.farba3033.MaterialName;
			farbaPrice = Consts2.farba3033.Price;
			break;
		case "4002":
			farbaName = Consts2.farba4002.MaterialName;
			farbaPrice = Consts2.farba4002.Price;
			break;
		case "4003":
			farbaName = Consts2.farba4003.MaterialName;
			farbaPrice = Consts2.farba4003.Price;
			break;
		case "4004":
			farbaName = Consts2.farba4004.MaterialName;
			farbaPrice = Consts2.farba4004.Price;
			break;
		case "4005":
			farbaName = Consts2.farba4005.MaterialName;
			farbaPrice = Consts2.farba4005.Price;
			break;
		case "4007":
			farbaName = Consts2.farba4007.MaterialName;
			farbaPrice = Consts2.farba4007.Price;
			break;
		case "4009":
			farbaName = Consts2.farba4009.MaterialName;
			farbaPrice = Consts2.farba4009.Price;
			break;
		case "4011":
			farbaName = Consts2.farba4011.MaterialName;
			farbaPrice = Consts2.farba4011.Price;
			break;
		case "5000":
			farbaName = Consts2.farba5000.MaterialName;
			farbaPrice = Consts2.farba5000.Price;
			break;
		case "5001":
			farbaName = Consts2.farba5001.MaterialName;
			farbaPrice = Consts2.farba5001.Price;
			break;
		case "5001М":
			farbaName = Consts2.farba5001M.MaterialName;
			farbaPrice = Consts2.farba5001M.Price;
			break;
		case "5002":
			farbaName = Consts2.farba5002.MaterialName;
			farbaPrice = Consts2.farba5002.Price;
			break;
		case "5003":
			farbaName = Consts2.farba5003.MaterialName;
			farbaPrice = Consts2.farba5003.Price;
			break;
		case "5003М":
			farbaName = Consts2.farba5003M.MaterialName;
			farbaPrice = Consts2.farba5003M.Price;
			break;
		case "5004":
			farbaName = Consts2.farba5004.MaterialName;
			farbaPrice = Consts2.farba5004.Price;
			break;
		case "5005":
			farbaName = Consts2.farba5005.MaterialName;
			farbaPrice = Consts2.farba5005.Price;
			break;
		case "5007":
			farbaName = Consts2.farba5007.MaterialName;
			farbaPrice = Consts2.farba5007.Price;
			break;
		case "5008":
			farbaName = Consts2.farba5008.MaterialName;
			farbaPrice = Consts2.farba5008.Price;
			break;
		case "5009":
			farbaName = Consts2.farba5009.MaterialName;
			farbaPrice = Consts2.farba5009.Price;
			break;
		case "5010":
			farbaName = Consts2.farba5010.MaterialName;
			farbaPrice = Consts2.farba5010.Price;
			break;
		case "5011":
			farbaName = Consts2.farba5011.MaterialName;
			farbaPrice = Consts2.farba5011.Price;
			break;
		case "5012":
			farbaName = Consts2.farba5012.MaterialName;
			farbaPrice = Consts2.farba5012.Price;
			break;
		case "5013":
			farbaName = Consts2.farba5013.MaterialName;
			farbaPrice = Consts2.farba5013.Price;
			break;
		case "5013М":
			farbaName = Consts2.farba5013M.MaterialName;
			farbaPrice = Consts2.farba5013M.Price;
			break;
		case "5014":
			farbaName = Consts2.farba5014.MaterialName;
			farbaPrice = Consts2.farba5014.Price;
			break;
		case "5015":
			farbaName = Consts2.farba5015.MaterialName;
			farbaPrice = Consts2.farba5015.Price;
			break;
		case "5017":
			farbaName = Consts2.farba5017.MaterialName;
			farbaPrice = Consts2.farba5017.Price;
			break;
		case "5018":
			farbaName = Consts2.farba5018.MaterialName;
			farbaPrice = Consts2.farba5018.Price;
			break;
		case "5019":
			farbaName = Consts2.farba5019.MaterialName;
			farbaPrice = Consts2.farba5019.Price;
			break;
		case "5020":
			farbaName = Consts2.farba5020.MaterialName;
			farbaPrice = Consts2.farba5020.Price;
			break;
		case "5021":
			farbaName = Consts2.farba5021.MaterialName;
			farbaPrice = Consts2.farba5021.Price;
			break;
		case "5022":
			farbaName = Consts2.farba5022.MaterialName;
			farbaPrice = Consts2.farba5022.Price;
			break;
		case "5023":
			farbaName = Consts2.farba5023.MaterialName;
			farbaPrice = Consts2.farba5023.Price;
			break;
		case "5023М":
			farbaName = Consts2.farba5023M.MaterialName;
			farbaPrice = Consts2.farba5023M.Price;
			break;
		case "5024":
			farbaName = Consts2.farba5024.MaterialName;
			farbaPrice = Consts2.farba5024.Price;
			break;
		case "5025":
			farbaName = Consts2.farba5025.MaterialName;
			farbaPrice = Consts2.farba5025.Price;
			break;
		case "5026":
			farbaName = Consts2.farba5026.MaterialName;
			farbaPrice = Consts2.farba5026.Price;
			break;
		case "6000":
			farbaName = Consts2.farba6000.MaterialName;
			farbaPrice = Consts2.farba6000.Price;
			break;
		case "6001":
			farbaName = Consts2.farba6001.MaterialName;
			farbaPrice = Consts2.farba6001.Price;
			break;
		case "6002":
			farbaName = Consts2.farba6002.MaterialName;
			farbaPrice = Consts2.farba6002.Price;
			break;
		case "6003":
			farbaName = Consts2.farba6003.MaterialName;
			farbaPrice = Consts2.farba6003.Price;
			break;
		case "6003М":
			farbaName = Consts2.farba6003M.MaterialName;
			farbaPrice = Consts2.farba6003M.Price;
			break;
		case "6004":
			farbaName = Consts2.farba6004.MaterialName;
			farbaPrice = Consts2.farba6004.Price;
			break;
		case "6004М":
			farbaName = Consts2.farba6004M.MaterialName;
			farbaPrice = Consts2.farba6004M.Price;
			break;
		case "6005":
			farbaName = Consts2.farba6005.MaterialName;
			farbaPrice = Consts2.farba6005.Price;
			break;
		case "6005М":
			farbaName = Consts2.farba6005M.MaterialName;
			farbaPrice = Consts2.farba6005M.Price;
			break;
		case "6006":
			farbaName = Consts2.farba6006.MaterialName;
			farbaPrice = Consts2.farba6006.Price;
			break;
		case "6007":
			farbaName = Consts2.farba6007.MaterialName;
			farbaPrice = Consts2.farba6007.Price;
			break;
		case "6009":
			farbaName = Consts2.farba6009.MaterialName;
			farbaPrice = Consts2.farba6009.Price;
			break;
		case "6010":
			farbaName = Consts2.farba6010.MaterialName;
			farbaPrice = Consts2.farba6010.Price;
			break;
		case "6011":
			farbaName = Consts2.farba6011.MaterialName;
			farbaPrice = Consts2.farba6011.Price;
			break;
		case "6012":
			farbaName = Consts2.farba6012.MaterialName;
			farbaPrice = Consts2.farba6012.Price;
			break;
		case "6013":
			farbaName = Consts2.farba6013.MaterialName;
			farbaPrice = Consts2.farba6013.Price;
			break;
		case "6014":
			farbaName = Consts2.farba6014.MaterialName;
			farbaPrice = Consts2.farba6014.Price;
			break;
		case "6015":
			farbaName = Consts2.farba6015.MaterialName;
			farbaPrice = Consts2.farba6015.Price;
			break;
		case "6016":
			farbaName = Consts2.farba6016.MaterialName;
			farbaPrice = Consts2.farba6016.Price;
			break;
		case "6017":
			farbaName = Consts2.farba6017.MaterialName;
			farbaPrice = Consts2.farba6017.Price;
			break;
		case "6018":
			farbaName = Consts2.farba6018.MaterialName;
			farbaPrice = Consts2.farba6018.Price;
			break;
		case "6019":
			farbaName = Consts2.farba6019.MaterialName;
			farbaPrice = Consts2.farba6019.Price;
			break;
		case "6019М":
			farbaName = Consts2.farba6019M.MaterialName;
			farbaPrice = Consts2.farba6019M.Price;
			break;
		case "6020":
			farbaName = Consts2.farba6020.MaterialName;
			farbaPrice = Consts2.farba6020.Price;
			break;
		case "6020М":
			farbaName = Consts2.farba6020M.MaterialName;
			farbaPrice = Consts2.farba6020M.Price;
			break;
		case "6021":
			farbaName = Consts2.farba6021.MaterialName;
			farbaPrice = Consts2.farba6021.Price;
			break;
		case "6021М":
			farbaName = Consts2.farba6021M.MaterialName;
			farbaPrice = Consts2.farba6021M.Price;
			break;
		case "6022":
			farbaName = Consts2.farba6022.MaterialName;
			farbaPrice = Consts2.farba6022.Price;
			break;
		case "6024":
			farbaName = Consts2.farba6024.MaterialName;
			farbaPrice = Consts2.farba6024.Price;
			break;
		case "6025":
			farbaName = Consts2.farba6025.MaterialName;
			farbaPrice = Consts2.farba6025.Price;
			break;
		case "6026":
			farbaName = Consts2.farba6026.MaterialName;
			farbaPrice = Consts2.farba6026.Price;
			break;
		case "6027":
			farbaName = Consts2.farba6027.MaterialName;
			farbaPrice = Consts2.farba6027.Price;
			break;
		case "6027М":
			farbaName = Consts2.farba6027M.MaterialName;
			farbaPrice = Consts2.farba6027M.Price;
			break;
		case "6028":
			farbaName = Consts2.farba6028.MaterialName;
			farbaPrice = Consts2.farba6028.Price;
			break;
		case "6029":
			farbaName = Consts2.farba6029.MaterialName;
			farbaPrice = Consts2.farba6029.Price;
			break;
		case "6032":
			farbaName = Consts2.farba6032.MaterialName;
			farbaPrice = Consts2.farba6032.Price;
			break;
		case "6033":
			farbaName = Consts2.farba6033.MaterialName;
			farbaPrice = Consts2.farba6033.Price;
			break;
		case "6034":
			farbaName = Consts2.farba6034.MaterialName;
			farbaPrice = Consts2.farba6034.Price;
			break;
		case "6034М":
			farbaName = Consts2.farba6034M.MaterialName;
			farbaPrice = Consts2.farba6034M.Price;
			break;
		case "6035":
			farbaName = Consts2.farba6035.MaterialName;
			farbaPrice = Consts2.farba6035.Price;
			break;
		case "6036":
			farbaName = Consts2.farba6036.MaterialName;
			farbaPrice = Consts2.farba6036.Price;
			break;
		case "6037":
			farbaName = Consts2.farba6037.MaterialName;
			farbaPrice = Consts2.farba6037.Price;
			break;
		case "7000":
			farbaName = Consts2.farba7000.MaterialName;
			farbaPrice = Consts2.farba7000.Price;
			break;
		case "7001":
			farbaName = Consts2.farba7001.MaterialName;
			farbaPrice = Consts2.farba7001.Price;
			break;
		case "7001М":
			farbaName = Consts2.farba7001M.MaterialName;
			farbaPrice = Consts2.farba7001M.Price;
			break;
		case "7002":
			farbaName = Consts2.farba7002.MaterialName;
			farbaPrice = Consts2.farba7002.Price;
			break;
		case "7003":
			farbaName = Consts2.farba7003.MaterialName;
			farbaPrice = Consts2.farba7003.Price;
			break;
		case "7004":
			farbaName = Consts2.farba7004.MaterialName;
			farbaPrice = Consts2.farba7004.Price;
			break;
		case "7005":
			farbaName = Consts2.farba7005.MaterialName;
			farbaPrice = Consts2.farba7005.Price;
			break;
		case "7005М":
			farbaName = Consts2.farba7005M.MaterialName;
			farbaPrice = Consts2.farba7005M.Price;
			break;
		case "7006":
			farbaName = Consts2.farba7006.MaterialName;
			farbaPrice = Consts2.farba7006.Price;
			break;
		case "7006М":
			farbaName = Consts2.farba7006M.MaterialName;
			farbaPrice = Consts2.farba7006M.Price;
			break;
		case "7008":
			farbaName = Consts2.farba7008.MaterialName;
			farbaPrice = Consts2.farba7008.Price;
			break;
		case "7009":
			farbaName = Consts2.farba7009.MaterialName;
			farbaPrice = Consts2.farba7009.Price;
			break;
		case "7010":
			farbaName = Consts2.farba7010.MaterialName;
			farbaPrice = Consts2.farba7010.Price;
			break;
		case "7010М":
			farbaName = Consts2.farba7010M.MaterialName;
			farbaPrice = Consts2.farba7010M.Price;
			break;
		case "7011":
			farbaName = Consts2.farba7011.MaterialName;
			farbaPrice = Consts2.farba7011.Price;
			break;
		case "7011М":
			farbaName = Consts2.farba7011M.MaterialName;
			farbaPrice = Consts2.farba7011M.Price;
			break;
		case "7012":
			farbaName = Consts2.farba7012.MaterialName;
			farbaPrice = Consts2.farba7012.Price;
			break;
		case "7012М":
			farbaName = Consts2.farba7012M.MaterialName;
			farbaPrice = Consts2.farba7012M.Price;
			break;
		case "7013":
			farbaName = Consts2.farba7013.MaterialName;
			farbaPrice = Consts2.farba7013.Price;
			break;
		case "7015":
			farbaName = Consts2.farba7015.MaterialName;
			farbaPrice = Consts2.farba7015.Price;
			break;
		case "7015М":
			farbaName = Consts2.farba7015M.MaterialName;
			farbaPrice = Consts2.farba7015M.Price;
			break;
		case "7016":
			farbaName = Consts2.farba7016.MaterialName;
			farbaPrice = Consts2.farba7016.Price;
			break;
		case "7016М":
			farbaName = Consts2.farba7016M.MaterialName;
			farbaPrice = Consts2.farba7016M.Price;
			break;
		case "7021":
			farbaName = Consts2.farba7021.MaterialName;
			farbaPrice = Consts2.farba7021.Price;
			break;
		case "7021М":
			farbaName = Consts2.farba7021M.MaterialName;
			farbaPrice = Consts2.farba7021M.Price;
			break;
		case "7022":
			farbaName = Consts2.farba7022.MaterialName;
			farbaPrice = Consts2.farba7022.Price;
			break;
		case "7022М":
			farbaName = Consts2.farba7022M.MaterialName;
			farbaPrice = Consts2.farba7022M.Price;
			break;
		case "7023":
			farbaName = Consts2.farba7023.MaterialName;
			farbaPrice = Consts2.farba7023.Price;
			break;
		case "7024":
			farbaName = Consts2.farba7024.MaterialName;
			farbaPrice = Consts2.farba7024.Price;
			break;
		case "7024М":
			farbaName = Consts2.farba7024M.MaterialName;
			farbaPrice = Consts2.farba7024M.Price;
			break;
		case "7026":
			farbaName = Consts2.farba7026.MaterialName;
			farbaPrice = Consts2.farba7026.Price;
			break;
		case "7026М":
			farbaName = Consts2.farba7026M.MaterialName;
			farbaPrice = Consts2.farba7026M.Price;
			break;
		case "7030":
			farbaName = Consts2.farba7030.MaterialName;
			farbaPrice = Consts2.farba7030.Price;
			break;
		case "7030М":
			farbaName = Consts2.farba7030M.MaterialName;
			farbaPrice = Consts2.farba7030M.Price;
			break;
		case "7031":
			farbaName = Consts2.farba7031.MaterialName;
			farbaPrice = Consts2.farba7031.Price;
			break;
		case "7032":
			farbaName = Consts2.farba7032.MaterialName;
			farbaPrice = Consts2.farba7032.Price;
			break;
		case "7032М":
			farbaName = Consts2.farba7032M.MaterialName;
			farbaPrice = Consts2.farba7032M.Price;
			break;
		case "7033":
			farbaName = Consts2.farba7033.MaterialName;
			farbaPrice = Consts2.farba7033.Price;
			break;
		case "7034":
			farbaName = Consts2.farba7034.MaterialName;
			farbaPrice = Consts2.farba7034.Price;
			break;
		case "7035":
			farbaName = Consts2.farba7035.MaterialName;
			farbaPrice = Consts2.farba7035.Price;
			break;
		case "7035М":
			farbaName = Consts2.farba7035M.MaterialName;
			farbaPrice = Consts2.farba7035M.Price;
			break;
		case "7036":
			farbaName = Consts2.farba7036.MaterialName;
			farbaPrice = Consts2.farba7036.Price;
			break;
		case "7036М":
			farbaName = Consts2.farba7036M.MaterialName;
			farbaPrice = Consts2.farba7036M.Price;
			break;
		case "7037":
			farbaName = Consts2.farba7037.MaterialName;
			farbaPrice = Consts2.farba7037.Price;
			break;
		case "7037М":
			farbaName = Consts2.farba7037M.MaterialName;
			farbaPrice = Consts2.farba7037M.Price;
			break;
		case "7038":
			farbaName = Consts2.farba7038.MaterialName;
			farbaPrice = Consts2.farba7038.Price;
			break;
		case "7038М":
			farbaName = Consts2.farba7038M.MaterialName;
			farbaPrice = Consts2.farba7038M.Price;
			break;
		case "7039":
			farbaName = Consts2.farba7039.MaterialName;
			farbaPrice = Consts2.farba7039.Price;
			break;
		case "7040":
			farbaName = Consts2.farba7040.MaterialName;
			farbaPrice = Consts2.farba7040.Price;
			break;
		case "7040М":
			farbaName = Consts2.farba7040M.MaterialName;
			farbaPrice = Consts2.farba7040M.Price;
			break;
		case "7042":
			farbaName = Consts2.farba7042.MaterialName;
			farbaPrice = Consts2.farba7042.Price;
			break;
		case "7042М":
			farbaName = Consts2.farba7042M.MaterialName;
			farbaPrice = Consts2.farba7042M.Price;
			break;
		case "7043":
			farbaName = Consts2.farba7043.MaterialName;
			farbaPrice = Consts2.farba7043.Price;
			break;
		case "7043М":
			farbaName = Consts2.farba7043M.MaterialName;
			farbaPrice = Consts2.farba7043M.Price;
			break;
		case "7044":
			farbaName = Consts2.farba7044.MaterialName;
			farbaPrice = Consts2.farba7044.Price;
			break;
		case "7044М":
			farbaName = Consts2.farba7044M.MaterialName;
			farbaPrice = Consts2.farba7044M.Price;
			break;
		case "7045":
			farbaName = Consts2.farba7045.MaterialName;
			farbaPrice = Consts2.farba7045.Price;
			break;
		case "7045М":
			farbaName = Consts2.farba7045M.MaterialName;
			farbaPrice = Consts2.farba7045M.Price;
			break;
		case "7046":
			farbaName = Consts2.farba7046.MaterialName;
			farbaPrice = Consts2.farba7046.Price;
			break;
		case "7046М":
			farbaName = Consts2.farba7046M.MaterialName;
			farbaPrice = Consts2.farba7046M.Price;
			break;
		case "7047":
			farbaName = Consts2.farba7047.MaterialName;
			farbaPrice = Consts2.farba7047.Price;
			break;
		case "7047М":
			farbaName = Consts2.farba7047M.MaterialName;
			farbaPrice = Consts2.farba7047M.Price;
			break;
		case "7048":
			farbaName = Consts2.farba7048.MaterialName;
			farbaPrice = Consts2.farba7048.Price;
			break;
		case "7152":
			farbaName = Consts2.farba7152.MaterialName;
			farbaPrice = Consts2.farba7152.Price;
			break;
		case "9018":
			farbaName = Consts2.farba9018.MaterialName;
			farbaPrice = Consts2.farba9018.Price;
			break;
		case "9018М":
			farbaName = Consts2.farba9018M.MaterialName;
			farbaPrice = Consts2.farba9018M.Price;
			break;
		case "8000":
			farbaName = Consts2.farba8000.MaterialName;
			farbaPrice = Consts2.farba8000.Price;
			break;
		case "8001":
			farbaName = Consts2.farba8001.MaterialName;
			farbaPrice = Consts2.farba8001.Price;
			break;
		case "8001М":
			farbaName = Consts2.farba8001M.MaterialName;
			farbaPrice = Consts2.farba8001M.Price;
			break;
		case "8002":
			farbaName = Consts2.farba8002.MaterialName;
			farbaPrice = Consts2.farba8002.Price;
			break;
		case "8003":
			farbaName = Consts2.farba8003.MaterialName;
			farbaPrice = Consts2.farba8003.Price;
			break;
		case "8003М":
			farbaName = Consts2.farba8003M.MaterialName;
			farbaPrice = Consts2.farba8003M.Price;
			break;
		case "8004":
			farbaName = Consts2.farba8004.MaterialName;
			farbaPrice = Consts2.farba8004.Price;
			break;
		case "8007":
			farbaName = Consts2.farba8007.MaterialName;
			farbaPrice = Consts2.farba8007.Price;
			break;
		case "8008":
			farbaName = Consts2.farba8008.MaterialName;
			farbaPrice = Consts2.farba8008.Price;
			break;
		case "8011":
			farbaName = Consts2.farba8011.MaterialName;
			farbaPrice = Consts2.farba8011.Price;
			break;
		case "8011М":
			farbaName = Consts2.farba8011M.MaterialName;
			farbaPrice = Consts2.farba8011M.Price;
			break;
		case "8012":
			farbaName = Consts2.farba8012.MaterialName;
			farbaPrice = Consts2.farba8012.Price;
			break;
		case "8014":
			farbaName = Consts2.farba8014.MaterialName;
			farbaPrice = Consts2.farba8014.Price;
			break;
		case "8014М":
			farbaName = Consts2.farba8014M.MaterialName;
			farbaPrice = Consts2.farba8014M.Price;
			break;
		case "8015":
			farbaName = Consts2.farba8015.MaterialName;
			farbaPrice = Consts2.farba8015.Price;
			break;
		case "8016":
			farbaName = Consts2.farba8016.MaterialName;
			farbaPrice = Consts2.farba8016.Price;
			break;
		case "8016М":
			farbaName = Consts2.farba8016M.MaterialName;
			farbaPrice = Consts2.farba8016M.Price;
			break;
		case "8017":
			farbaName = Consts2.farba8017.MaterialName;
			farbaPrice = Consts2.farba8017.Price;
			break;
		case "8017М":
			farbaName = Consts2.farba8017M.MaterialName;
			farbaPrice = Consts2.farba8017M.Price;
			break;
		case "8019":
			farbaName = Consts2.farba8019.MaterialName;
			farbaPrice = Consts2.farba8019.Price;
			break;
		case "8019М":
			farbaName = Consts2.farba8019M.MaterialName;
			farbaPrice = Consts2.farba8019M.Price;
			break;
		case "8022":
			farbaName = Consts2.farba8022.MaterialName;
			farbaPrice = Consts2.farba8022.Price;
			break;
		case "8022М":
			farbaName = Consts2.farba8022M.MaterialName;
			farbaPrice = Consts2.farba8022M.Price;
			break;
		case "8023":
			farbaName = Consts2.farba8023.MaterialName;
			farbaPrice = Consts2.farba8023.Price;
			break;
		case "8024":
			farbaName = Consts2.farba8024.MaterialName;
			farbaPrice = Consts2.farba8024.Price;
			break;
		case "8025":
			farbaName = Consts2.farba8025.MaterialName;
			farbaPrice = Consts2.farba8025.Price;
			break;
		case "8025М":
			farbaName = Consts2.farba8025M.MaterialName;
			farbaPrice = Consts2.farba8025M.Price;
			break;
		case "8028":
			farbaName = Consts2.farba8028.MaterialName;
			farbaPrice = Consts2.farba8028.Price;
			break;
		default:
			farbaName = Consts2.farba8028M.MaterialName;
			farbaPrice = Consts2.farba8028M.Price;
			break;
		}
	}

	public static double[,] MaterialFlanetsPrjamokutnyj(int B, int H, string typProfilBH, int number)
	{
		double[,] array = new double[2, 6];
		double num = 2.0 * (double)(B + H) / 1000.0 - 0.12;
		materialName1 = new string[2] { "", "" };
		double num2 = 0.0;
		if (typProfilBH == "S - 20")
		{
			materialName1[0] = Consts2.profilS20.MaterialName;
			materialName1[1] = Consts2.kutnykS20.MaterialName;
			num2 = 0.5;
		}
		else if (typProfilBH == "S - 20 нерж")
		{
			materialName1[0] = Consts2.profilS20nerzh.MaterialName;
			materialName1[1] = Consts2.kutnykS20nerzh.MaterialName;
			num2 = 0.5;
		}
		array[0, 0] = num * 1.03;
		array[1, 0] = 4.0;
		if (array[0, 0] < 0.005)
		{
			array[0, 0] = Math.Round(1000.0 * array[0, 0]) / 1000.0;
		}
		else
		{
			array[0, 0] = Math.Round(100.0 * array[0, 0]) / 100.0;
		}
		array[0, 1] = 0.03;
		array[0, 4] = array[0, 0] * (double)number;
		array[0, 5] = array[0, 4] * num2;
		array[0, 2] = array[0, 4] * array[0, 1];
		array[0, 3] = array[0, 5] * array[0, 1];
		array[1, 4] = array[1, 0] * (double)number;
		return array;
	}

	public static void AluminiumGridDrawImage(int B, int H, string typReshitky, string ral, bool checkBoxAnodovane, string sposibKriplennja, int number, string filePath = null)
	{
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		//IL_004d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0054: Expected O, but got Unknown
		//IL_005c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0066: Unknown result type (might be due to invalid IL or missing references)
		//IL_006d: Expected O, but got Unknown
		//IL_0075: Unknown result type (might be due to invalid IL or missing references)
		//IL_007f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0086: Expected O, but got Unknown
		//IL_0096: Unknown result type (might be due to invalid IL or missing references)
		//IL_009d: Expected O, but got Unknown
		//IL_00a5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ac: Expected O, but got Unknown
		//IL_00ac: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b8: Expected O, but got Unknown
		//IL_00b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bf: Expected O, but got Unknown
		//IL_023c: Unknown result type (might be due to invalid IL or missing references)
		//IL_020a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0331: Unknown result type (might be due to invalid IL or missing references)
		//IL_0338: Expected O, but got Unknown
		//IL_0338: Unknown result type (might be due to invalid IL or missing references)
		//IL_033f: Expected O, but got Unknown
		int num = 35;
		int num2 = 25;
		int num3 = num + 275;
		int num4 = num2 + 20;
		int num5 = 725;
		Image val = Image.FromFile(WPFHelper.GetProjectRootPath() + "\\Images\\Untitled.jpg");
		Graphics val2 = Graphics.FromImage(val);
		try
		{
			Pen val3 = new Pen(Color.FromArgb(255, 0, 0, 0), 1f);
			Pen val4 = new Pen(Color.FromArgb(255, 0, 0, 0), 2f);
			Pen val5 = new Pen(Color.FromArgb(255, 0, 0, 0), 3f);
			int num6 = 12;
			int num7 = 10;
			Font val6 = new Font("Arial", (float)num6);
			Font val7 = new Font("Arial", (float)num7);
			SolidBrush val8 = new SolidBrush(Color.Black);
			StringFormat val9 = new StringFormat();
			val9.LineAlignment = (StringAlignment)1;
			val9.Alignment = (StringAlignment)1;
			string text = "Решітка АРТ-";
			string text2;
			if (checkBoxAnodovane)
			{
				text2 = "A";
			}
			else
			{
				int num8 = ral.IndexOf(" ");
				text2 = ((num8 > 0) ? ral.Substring(0, num8) : ral);
			}
			text = ((!(typReshitky == "однорядна")) ? (text + "2 (" + text2 + ") ") : (text + "1 (" + text2 + ") "));
			text = text + B + "х" + H + "(h)";
			text = text + " - " + number + " шт";
			#if WINDOWS

			val9.FormatFlags = (StringFormatFlags)1;

			#endif
			val2.DrawString(text, val6, (Brush)(object)val8, (float)(num5 / 2), (float)num2, val9);
			Image val10 = Image.FromFile(WPFHelper.GetProjectRootPath() + "\\Images\\AluminiumGrid\\Odnorjadna_H.jpg");
			if (typReshitky == "однорядна")
			{
				val10 = Image.FromFile(WPFHelper.GetProjectRootPath() + "\\Images\\AluminiumGrid\\Odnorjadna_H.jpg");
				Point val11 = default(Point);
				((Point)(ref val11))._002Ector(num, num2 + 20);
				val2.DrawImage(val10, val11);
			}
			else
			{
				val10 = Image.FromFile(WPFHelper.GetProjectRootPath() + "\\Images\\AluminiumGrid\\Dvoorjadna_H.jpg");
				Point val12 = default(Point);
				((Point)(ref val12))._002Ector(num, num2 + 20);
				val2.DrawImage(val10, val12);
			}
			if (typReshitky == "однорядна")
			{
				int num9 = num + 110;
				int num10 = num2 + 25;
				#if WINDOWS

				val9.FormatFlags = (StringFormatFlags)1;

				#endif
				val2.DrawString(B.ToString(), val7, (Brush)(object)val8, (float)num9, (float)num10, val9);
				num9 = num;
				num10 = num2 + 20 + 90;
				#if WINDOWS

				val9.FormatFlags = (StringFormatFlags)1;

				#endif
				val2.DrawString(H.ToString(), val7, (Brush)(object)val8, (float)num9, (float)num10, val9);
			}
			else
			{
				int num9 = num + 130;
				int num10 = num2 + 30;
				#if WINDOWS

				val9.FormatFlags = (StringFormatFlags)1;

				#endif
				val2.DrawString(B.ToString(), val7, (Brush)(object)val8, (float)num9, (float)num10, val9);
				num9 = num;
				num10 = num2 + 20 + 130;
				#if WINDOWS

				val9.FormatFlags = (StringFormatFlags)1;

				#endif
				val2.DrawString(H.ToString(), val7, (Brush)(object)val8, (float)num9, (float)num10, val9);
			}
			int num11 = 10;
			int num12 = 0;
			Font val13 = new Font("Arial", (float)num11);
			StringFormat val14 = new StringFormat();
			val14.LineAlignment = (StringAlignment)0;
			val14.Alignment = (StringAlignment)0;
			val2.DrawString("Ширина: " + B + " мм", val13, (Brush)(object)val8, (float)num3, (float)(num4 + num12), val14);
			num12 += num11 + 8;
			val2.DrawString("Висота: " + H + " мм", val13, (Brush)(object)val8, (float)num3, (float)(num4 + num12), val14);
			num12 += num11 + 8;
			if (checkBoxAnodovane)
			{
				val2.DrawString("Анодоване покриття", val13, (Brush)(object)val8, (float)num3, (float)(num4 + num12), val14);
			}
			else
			{
				val2.DrawString("RAL: " + ral, val13, (Brush)(object)val8, (float)num3, (float)(num4 + num12), val14);
			}
			num12 += num11 + 8;
			val2.DrawString(sposibKriplennja, val13, (Brush)(object)val8, (float)num3, (float)(num4 + num12), val14);
			num12 += num11 + 8;
			num12 = 0;
			num3 = num;
			num4 = num2 + 20 + val10.Height + 20;
			string text3 = ((!(typReshitky == "однорядна")) ? (checkBoxAnodovane ? Consts2.profilAlumDvorAnodovan.MaterialName : Consts2.profilAlumDvor.MaterialName) : (checkBoxAnodovane ? Consts2.profilAlumOdnorAnodovan.MaterialName : Consts2.profilAlumOdnor.MaterialName));
			int num13 = 27;
			val2.DrawString(text3 + ": " + ((double)B + 2.0 * (double)num13) + " мм - " + 2 * number + " шт", val13, (Brush)(object)val8, (float)num3, (float)(num4 + num12), val14);
			num12 += num11 + 8;
			val2.DrawString(text3 + ": " + ((double)H + 2.0 * (double)num13) + " мм - " + 2 * number + " шт", val13, (Brush)(object)val8, (float)num3, (float)(num4 + num12), val14);
			num12 += num11 + 8;
			double num14 = B;
			double num15 = 0.0;
			int num16 = H / 25;
			int num17 = 0;
			string text4 = (checkBoxAnodovane ? Consts2.profilAlumLamelAnodovan.MaterialName : Consts2.profilAlumLamel.MaterialName);
			if (typReshitky == "дворядна")
			{
				num15 = H;
				num17 = B / 25;
			}
			val2.DrawString(text4 + ": " + num14 + " мм - " + num16 * number + " шт", val13, (Brush)(object)val8, (float)num3, (float)(num4 + num12), val14);
			if (typReshitky == "дворядна")
			{
				text3 = (checkBoxAnodovane ? Consts2.profilAlumDvorAnodovan.MaterialName : Consts2.profilAlumDvor.MaterialName);
				num12 += num11 + 8;
				val2.DrawString(Consts2.profilAlumLamel.MaterialName + ": " + num15 + " мм - " + num17 * number + " шт", val13, (Brush)(object)val8, (float)num3, (float)(num4 + num12), val14);
			}
			num12 += num11 + 8;
			double num18 = 0.5 * (double)(H - (H / 25 - 1) * 25);
			if (typReshitky == "однорядна")
			{
				val2.DrawString("Зазор між крайньою ламеллю та решіткою: " + num18 + " мм", val13, (Brush)(object)val8, (float)num3, (float)(num4 + num12), val14);
			}
			else
			{
				val2.DrawString("Зазор між крайньою горизонтальною ламеллю та решіткою: " + num18 + " мм", val13, (Brush)(object)val8, (float)num3, (float)(num4 + num12), val14);
				num18 = 0.5 * (double)(B - (B / 25 - 1) * 25);
				num12 += num11 + 8;
				val2.DrawString("Зазор між крайньою вертикальною ламеллю та решіткою: " + num18 + " мм", val13, (Brush)(object)val8, (float)num3, (float)(num4 + num12), val14);
			}
		}
		finally
		{
			((IDisposable)val2)?.Dispose();
		}
		if (!string.IsNullOrEmpty(filePath))
		{
			val.Save(filePath + ".jpg");
		}
	}

	public static double VolumeAluminiumGrid(int B, int H, string typReshitky)
	{
		int num = ((typReshitky == "однорядна") ? 35 : 65);
		return Math.Round(((double)B + 54.0) * ((double)H + 54.0) * (double)num / 1000000.0) / 1000.0;
	}
}
