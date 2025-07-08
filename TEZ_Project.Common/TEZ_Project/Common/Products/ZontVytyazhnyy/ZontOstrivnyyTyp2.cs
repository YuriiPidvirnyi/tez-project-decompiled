using System;
using System.Drawing;
using System.Globalization;
using System.IO;
using TEZ_Project.Common.Helpers;

namespace TEZ_Project.Common.Products.ZontVytyazhnyy;

public class ZontOstrivnyyTyp2
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

	public static double materialCost1;

	public static double kk = 0.0;

	public static int l = 0;

	public static int[] kFiltr = new int[3];

	public static int nFiltr = 0;

	public static int typeUpperStrip = 0;

	public static int lMax = 750;

	public static int betaGradus = 0;

	public static double materialSpendingCommercialOffer = 0.0;

	public static double materialSpendingCommercialOffer1 = 0.0;

	public static double[,] MaterialZontOstrivnyyTyp2(int L, int B, int H, int h, int number, string markaStaliZont, string tovchynaMetaluZont, string connection, string zlyv, string fastening, string typeFastening, string vyhid, string vyhid1, int d1, int a1, int b1, int p1, int f1, int g1, string typVyhid1, string profilType1, string vyhid2, int d2, int a2, int b2, int p2, int f2, int g2, string typVyhid2, string profilType2, string vyhid3, int d3, int a3, int b3, int p3, int f3, int g3, string typVyhid3, string profilType3, string zhyrFiltr, int G, string markaStaliFiltr, string tovchynaMetaluFiltr)
	{
		double[,] array = new double[32, 6];
		int num = -1;
		double num2 = 0.0;
		double num3 = 0.0;
		double num4 = 0.0;
		double num5 = 0.0;
		double num6 = 0.0;
		double num7 = 0.0;
		double num8 = 0.0;
		double num9 = 0.0;
		int num10 = 750;
		materialName = new string[32]
		{
			"", "", "", "", "", "", "", "", "", "",
			"", "", "", "", "", "", "", "", "", "",
			"", "", "", "", "", "", "", "", "", "",
			"", ""
		};
		priceProduct = 0.0;
		materialCost = 0.0;
		materialSpendingCommercialOffer = 0.0;
		materialSpendingCommercialOffer1 = 0.0;
		if (markaStaliZont == "AISI 304" || markaStaliZont == "AISI 430" || markaStaliZont == "AISI 201")
		{
			num2 = 7825.0;
		}
		else if (markaStaliZont == "Оцинковка")
		{
			num2 = 7825.0;
		}
		num++;
		switch (markaStaliZont)
		{
		case "AISI 304":
			switch (tovchynaMetaluZont)
			{
			case "0.5":
				materialName[num] = Consts2.lystNerzavijuchyj05_304.MaterialName;
				num4 = Consts2.lystNerzavijuchyj05_304.Price;
				num3 = 0.5;
				break;
			case "0.8":
				materialName[num] = Consts2.lystNerzavijuchyj08_304.MaterialName;
				num4 = Consts2.lystNerzavijuchyj08_304.Price;
				num3 = 0.8;
				break;
			case "1.0":
				materialName[num] = Consts2.lystNerzavijuchyj10_304.MaterialName;
				num4 = Consts2.lystNerzavijuchyj10_304.Price;
				num3 = 1.0;
				break;
			}
			break;
		case "AISI 430":
			switch (tovchynaMetaluZont)
			{
			case "0.5":
				materialName[num] = Consts2.lystNerzavijuchyj05.MaterialName;
				num4 = Consts2.lystNerzavijuchyj05.Price;
				num3 = 0.5;
				break;
			case "0.8":
				materialName[num] = Consts2.lystNerzavijuchyj08.MaterialName;
				num4 = Consts2.lystNerzavijuchyj08.Price;
				num3 = 0.8;
				break;
			case "1.0":
				materialName[num] = Consts2.lystNerzavijuchyj10.MaterialName;
				num4 = Consts2.lystNerzavijuchyj10.Price;
				num3 = 1.0;
				break;
			}
			break;
		case "AISI 201":
			switch (tovchynaMetaluZont)
			{
			case "0.5":
				materialName[num] = Consts2.lystNerzavijuchyj05_201.MaterialName;
				num4 = Consts2.lystNerzavijuchyj05_201.Price;
				num3 = 0.5;
				break;
			case "0.8":
				materialName[num] = Consts2.lystNerzavijuchyj08_201.MaterialName;
				num4 = Consts2.lystNerzavijuchyj08_201.Price;
				num3 = 0.8;
				break;
			case "1.0":
				materialName[num] = Consts2.lystNerzavijuchyj10_201.MaterialName;
				num4 = Consts2.lystNerzavijuchyj10_201.Price;
				num3 = 1.0;
				break;
			}
			break;
		case "Оцинковка":
			switch (tovchynaMetaluZont)
			{
			case "0.5":
				materialName[num] = Consts2.lystOchynkovanyj05.MaterialName;
				num4 = Consts2.lystOchynkovanyj05.Price;
				num3 = 0.5;
				break;
			case "0.65":
				materialName[num] = Consts2.lystOchynkovanyj065.MaterialName;
				num4 = Consts2.lystOchynkovanyj065.Price;
				num3 = 0.65;
				break;
			case "0.68":
				materialName[num] = Consts2.lystOchynkovanyj068.MaterialName;
				num4 = Consts2.lystOchynkovanyj068.Price;
				num3 = 0.68;
				break;
			case "0.7":
				materialName[num] = Consts2.lystOchynkovanyj07.MaterialName;
				num4 = Consts2.lystOchynkovanyj07.Price;
				num3 = 0.7;
				break;
			case "0.9":
				materialName[num] = Consts2.lystOchynkovanyj09.MaterialName;
				num4 = Consts2.lystOchynkovanyj09.Price;
				num3 = 0.9;
				break;
			case "1.0":
				materialName[num] = Consts2.lystOchynkovanyj10.MaterialName;
				num4 = Consts2.lystOchynkovanyj10.Price;
				num3 = 1.0;
				break;
			case "1.2":
				materialName[num] = Consts2.lystOchynkovanyj12.MaterialName;
				num4 = Consts2.lystOchynkovanyj12.Price;
				num3 = 1.2;
				break;
			}
			break;
		}
		string text = "ЗВП-4";
		int num11 = 1;
		double num12 = ((connection == "зварка") ? 12 : 15);
		double num13 = 100.0;
		double num14 = 20.0;
		double num15 = 20.0;
		double num16 = 20.0;
		double num17 = 60.0;
		double num18 = 70.0;
		double num19 = 10.0;
		double num20 = 20.0;
		double num21 = 40.0;
		double num22 = 60.0;
		double num23 = 70.0;
		double num24 = 10.0;
		double num25 = 45.0;
		double num26 = 35.0;
		double num27 = 20.0;
		double num28 = 110.0;
		double num29 = 25.0;
		double num30 = 55.0;
		double num31 = 15.0;
		double num32 = 40.0;
		if (text == "ЗВО-4")
		{
			if (num11 == 1)
			{
				double num33 = num12 + (double)H + 20.0 + 10.0;
				num5 = (2.0 * num12 + (double)B) * num33;
				if (B > 2500)
				{
					num5 += 40.0 * num33;
				}
				else if (B > 1250)
				{
					num5 += 20.0 * num33;
				}
				num5 *= 2.0;
				double num34 = 2.0 * (double)(30 + H) + (double)B;
				if (num34 > 2460.0)
				{
					num34 += 40.0;
				}
				else if (num34 > 1230.0)
				{
					num34 += 20.0;
				}
				double num35 = ((L > 1230) ? 20 : 0);
				num35 += (double)((connection == "зварка") ? (L - 5) : L);
				num6 = num34 * num35;
				if (zhyrFiltr == "так")
				{
					num8 = (num28 + 2.0 * num29) * (double)(L - 5);
					num8 += (num30 + num31) * (double)(L - 10);
					num8 += 2.0 * (num16 + num17 + num18 + num19) * (double)(L - 5);
					if (L <= 550)
					{
						nFiltr = 1;
						kFiltr[0] = 400;
					}
					else if (L <= 650)
					{
						nFiltr = 1;
						kFiltr[0] = 500;
					}
					else if (L <= 675)
					{
						nFiltr = 1;
						kFiltr[0] = 600;
					}
					else if (L <= 750)
					{
						nFiltr = 2;
						kFiltr[0] = 300;
						kFiltr[1] = 300;
					}
					else if (L <= 850)
					{
						nFiltr = 2;
						kFiltr[0] = 300;
						kFiltr[1] = 400;
					}
					else if (L <= 950)
					{
						nFiltr = 2;
						kFiltr[0] = 400;
						kFiltr[1] = 400;
					}
					else if (L <= 1050)
					{
						nFiltr = 2;
						kFiltr[0] = 400;
						kFiltr[1] = 500;
					}
					else if (L <= 1150)
					{
						nFiltr = 2;
						kFiltr[0] = 500;
						kFiltr[1] = 500;
					}
					else if (L <= 1250)
					{
						nFiltr = 2;
						kFiltr[0] = 500;
						kFiltr[1] = 600;
					}
					else if (L <= 1350)
					{
						nFiltr = 2;
						kFiltr[0] = 600;
						kFiltr[1] = 600;
					}
					else if (L <= 1450)
					{
						nFiltr = 3;
						kFiltr[0] = 400;
						kFiltr[1] = 400;
						kFiltr[2] = 500;
					}
					else if (L <= 1550)
					{
						nFiltr = 3;
						kFiltr[0] = 400;
						kFiltr[1] = 500;
						kFiltr[2] = 500;
					}
					else if (L <= 1650)
					{
						nFiltr = 3;
						kFiltr[0] = 500;
						kFiltr[1] = 500;
						kFiltr[2] = 500;
					}
					else if (L <= 1750)
					{
						nFiltr = 3;
						kFiltr[0] = 500;
						kFiltr[1] = 500;
						kFiltr[2] = 600;
					}
					else if (L <= 1850)
					{
						nFiltr = 3;
						kFiltr[0] = 500;
						kFiltr[1] = 600;
						kFiltr[2] = 600;
					}
					else
					{
						nFiltr = 3;
						kFiltr[0] = 600;
						kFiltr[1] = 600;
						kFiltr[2] = 600;
					}
					kk = 0.0;
					for (int i = 0; i < nFiltr; i++)
					{
						kk += kFiltr[i];
					}
					kk = 0.5 * ((double)L - kk) + 15.0;
					num9 = 2.0 * (kk + 42.5) * (double)(ZontOstrivnyyTyp2.l + 30) + 1700.0;
				}
			}
			else
			{
				double num36 = 20.0;
				if (zhyrFiltr == "так")
				{
					if (L <= 550)
					{
						nFiltr = 1;
						kFiltr[0] = 400;
					}
					else if (L <= 650)
					{
						nFiltr = 1;
						kFiltr[0] = 500;
					}
					else if (L <= 675)
					{
						nFiltr = 1;
						kFiltr[0] = 600;
					}
					else if (L <= 750)
					{
						nFiltr = 2;
						kFiltr[0] = 300;
						kFiltr[1] = 300;
					}
					else if (L <= 850)
					{
						nFiltr = 2;
						kFiltr[0] = 300;
						kFiltr[1] = 400;
					}
					else if (L <= 950)
					{
						nFiltr = 2;
						kFiltr[0] = 400;
						kFiltr[1] = 400;
					}
					else if (L <= 1050)
					{
						nFiltr = 2;
						kFiltr[0] = 400;
						kFiltr[1] = 500;
					}
					else if (L <= 1150)
					{
						nFiltr = 2;
						kFiltr[0] = 500;
						kFiltr[1] = 500;
					}
					else if (L <= 1250)
					{
						nFiltr = 2;
						kFiltr[0] = 500;
						kFiltr[1] = 600;
					}
					else if (L <= 1350)
					{
						nFiltr = 2;
						kFiltr[0] = 600;
						kFiltr[1] = 600;
					}
					else if (L <= 1450)
					{
						nFiltr = 3;
						kFiltr[0] = 400;
						kFiltr[1] = 400;
						kFiltr[2] = 500;
					}
					else if (L <= 1550)
					{
						nFiltr = 3;
						kFiltr[0] = 400;
						kFiltr[1] = 500;
						kFiltr[2] = 500;
					}
					else if (L <= 1650)
					{
						nFiltr = 3;
						kFiltr[0] = 500;
						kFiltr[1] = 500;
						kFiltr[2] = 500;
					}
					else if (L <= 1750)
					{
						nFiltr = 3;
						kFiltr[0] = 500;
						kFiltr[1] = 500;
						kFiltr[2] = 600;
					}
					else if (L <= 1850)
					{
						nFiltr = 3;
						kFiltr[0] = 500;
						kFiltr[1] = 600;
						kFiltr[2] = 600;
					}
					else
					{
						nFiltr = 3;
						kFiltr[0] = 600;
						kFiltr[1] = 600;
						kFiltr[2] = 600;
					}
					kk = 0.0;
					for (int j = 0; j < nFiltr; j++)
					{
						kk += kFiltr[j];
					}
					kk = 0.5 * ((double)L - kk) + 15.0;
					num36 = kk;
				}
				double num33 = num12 + (double)H + num36 + 10.0;
				num5 = (2.0 * num12 + (double)B) * num33;
				if (B > 2500)
				{
					num5 += 40.0 * num33;
				}
				else if (B > 1250)
				{
					num5 += 20.0 * num33;
				}
				num5 *= 2.0;
				double num34 = 2.0 * (double)(40 + H) + (double)B;
				if (num34 > 2460.0)
				{
					num34 += 40.0;
				}
				else if (num34 > 1230.0)
				{
					num34 += 20.0;
				}
				double num35 = ((L > 1230) ? 20 : 0);
				num35 += (double)((connection == "зварка") ? (L - 5) : L);
				num6 = num34 * num35;
				if (zhyrFiltr == "так")
				{
					num8 = 80.0 * (double)(L - 5);
					num8 += (num30 + num31) * (double)(L - 10);
					num9 = 0.0;
				}
			}
		}
		else if (num11 == 1)
		{
			double num33 = num12 + (double)H + 20.0 + 10.0;
			num5 = (2.0 * num12 + (double)B) * num33;
			if (B > 2500)
			{
				num5 += 40.0 * num33;
			}
			else if (B > 1250)
			{
				num5 += 20.0 * num33;
			}
			num5 *= 2.0;
			double num34 = 2.0 * (double)(20 + H) + 20.0 + 100.0 + (double)B + 10.0;
			if (num34 > 2460.0)
			{
				num34 += 40.0;
			}
			else if (num34 > 1230.0)
			{
				num34 += 20.0;
			}
			double num35 = ((L > 1230) ? 20 : 0);
			num35 += (double)((connection == "зварка") ? (L - 5) : L);
			num6 = num34 * num35;
			if (zhyrFiltr == "так")
			{
				num8 = (num25 + num24 + num27) * (double)(L - 10);
				num8 += 2.0 * (num16 + num17 + num18 + num19) * (double)(L - 5);
				if (L <= 550)
				{
					nFiltr = 1;
					kFiltr[0] = 400;
				}
				else if (L <= 650)
				{
					nFiltr = 1;
					kFiltr[0] = 500;
				}
				else if (L <= 675)
				{
					nFiltr = 1;
					kFiltr[0] = 600;
				}
				else if (L <= 750)
				{
					nFiltr = 2;
					kFiltr[0] = 300;
					kFiltr[1] = 300;
				}
				else if (L <= 850)
				{
					nFiltr = 2;
					kFiltr[0] = 300;
					kFiltr[1] = 400;
				}
				else if (L <= 950)
				{
					nFiltr = 2;
					kFiltr[0] = 400;
					kFiltr[1] = 400;
				}
				else if (L <= 1050)
				{
					nFiltr = 2;
					kFiltr[0] = 400;
					kFiltr[1] = 500;
				}
				else if (L <= 1150)
				{
					nFiltr = 2;
					kFiltr[0] = 500;
					kFiltr[1] = 500;
				}
				else if (L <= 1250)
				{
					nFiltr = 2;
					kFiltr[0] = 500;
					kFiltr[1] = 600;
				}
				else if (L <= 1350)
				{
					nFiltr = 2;
					kFiltr[0] = 600;
					kFiltr[1] = 600;
				}
				else if (L <= 1450)
				{
					nFiltr = 3;
					kFiltr[0] = 400;
					kFiltr[1] = 400;
					kFiltr[2] = 500;
				}
				else if (L <= 1550)
				{
					nFiltr = 3;
					kFiltr[0] = 400;
					kFiltr[1] = 500;
					kFiltr[2] = 500;
				}
				else if (L <= 1650)
				{
					nFiltr = 3;
					kFiltr[0] = 500;
					kFiltr[1] = 500;
					kFiltr[2] = 500;
				}
				else if (L <= 1750)
				{
					nFiltr = 3;
					kFiltr[0] = 500;
					kFiltr[1] = 500;
					kFiltr[2] = 600;
				}
				else if (L <= 1850)
				{
					nFiltr = 3;
					kFiltr[0] = 500;
					kFiltr[1] = 600;
					kFiltr[2] = 600;
				}
				else
				{
					nFiltr = 3;
					kFiltr[0] = 600;
					kFiltr[1] = 600;
					kFiltr[2] = 600;
				}
				kk = 0.0;
				for (int k = 0; k < nFiltr; k++)
				{
					kk += kFiltr[k];
				}
				kk = 0.5 * ((double)L - kk) + 15.0;
				num9 = 2.0 * (kk + 42.5) * (double)(ZontOstrivnyyTyp2.l + 30) + 1700.0;
			}
		}
		else
		{
			double num37 = 20.0;
			if (zhyrFiltr == "так")
			{
				if (L <= 550)
				{
					nFiltr = 1;
					kFiltr[0] = 400;
				}
				else if (L <= 650)
				{
					nFiltr = 1;
					kFiltr[0] = 500;
				}
				else if (L <= 675)
				{
					nFiltr = 1;
					kFiltr[0] = 600;
				}
				else if (L <= 750)
				{
					nFiltr = 2;
					kFiltr[0] = 300;
					kFiltr[1] = 300;
				}
				else if (L <= 850)
				{
					nFiltr = 2;
					kFiltr[0] = 300;
					kFiltr[1] = 400;
				}
				else if (L <= 950)
				{
					nFiltr = 2;
					kFiltr[0] = 400;
					kFiltr[1] = 400;
				}
				else if (L <= 1050)
				{
					nFiltr = 2;
					kFiltr[0] = 400;
					kFiltr[1] = 500;
				}
				else if (L <= 1150)
				{
					nFiltr = 2;
					kFiltr[0] = 500;
					kFiltr[1] = 500;
				}
				else if (L <= 1250)
				{
					nFiltr = 2;
					kFiltr[0] = 500;
					kFiltr[1] = 600;
				}
				else if (L <= 1350)
				{
					nFiltr = 2;
					kFiltr[0] = 600;
					kFiltr[1] = 600;
				}
				else if (L <= 1450)
				{
					nFiltr = 3;
					kFiltr[0] = 400;
					kFiltr[1] = 400;
					kFiltr[2] = 500;
				}
				else if (L <= 1550)
				{
					nFiltr = 3;
					kFiltr[0] = 400;
					kFiltr[1] = 500;
					kFiltr[2] = 500;
				}
				else if (L <= 1650)
				{
					nFiltr = 3;
					kFiltr[0] = 500;
					kFiltr[1] = 500;
					kFiltr[2] = 500;
				}
				else if (L <= 1750)
				{
					nFiltr = 3;
					kFiltr[0] = 500;
					kFiltr[1] = 500;
					kFiltr[2] = 600;
				}
				else if (L <= 1850)
				{
					nFiltr = 3;
					kFiltr[0] = 500;
					kFiltr[1] = 600;
					kFiltr[2] = 600;
				}
				else
				{
					nFiltr = 3;
					kFiltr[0] = 600;
					kFiltr[1] = 600;
					kFiltr[2] = 600;
				}
				kk = 0.0;
				for (int l = 0; l < nFiltr; l++)
				{
					kk += kFiltr[l];
				}
				kk = 0.5 * ((double)L - kk) + 15.0;
				num37 = kk;
			}
			double num33 = num12 + (double)H + num37 + 10.0;
			num5 = (2.0 * num12 + (double)B) * num33;
			if (B > 2500)
			{
				num5 += 40.0 * num33;
			}
			else if (B > 1250)
			{
				num5 += 20.0 * num33;
			}
			num5 *= 2.0;
			double num34 = 2.0 * (double)(40 + H) + (double)B;
			if (num34 > 2460.0)
			{
				num34 += 40.0;
			}
			else if (num34 > 1230.0)
			{
				num34 += 20.0;
			}
			double num35 = ((L > 1230) ? 20 : 0);
			num35 += (double)((connection == "зварка") ? (L - 5) : L);
			num6 = num34 * num35;
			num8 = 0.0;
			num9 = 0.0;
		}
		num7 = 0.0;
		if (vyhid == "з виходом")
		{
			num12 = 60.0;
			if (vyhid1 == "круглий")
			{
				double num38 = ((d1 < 560) ? 0.036 : ((d1 < 710) ? 0.043 : ((d1 >= 900) ? ((d1 < 1400) ? 0.086 : 0.11599999999999999) : 0.073)));
				num7 += (Math.PI * (double)d1 + num38) * ((double)p1 + num12);
			}
			if (vyhid2 == "круглий")
			{
				double num38 = ((d2 < 560) ? 0.036 : ((d2 < 710) ? 0.043 : ((d2 >= 900) ? ((d2 < 1400) ? 0.086 : 0.11599999999999999) : 0.073)));
				num7 += (Math.PI * (double)d2 + num38) * ((double)p2 + num12);
			}
			if (vyhid3 == "круглий")
			{
				double num38 = ((d3 < 560) ? 0.036 : ((d3 < 710) ? 0.043 : ((d3 >= 900) ? ((d3 < 1400) ? 0.086 : 0.11599999999999999) : 0.073)));
				num7 += (Math.PI * (double)d3 + num38) * ((double)p3 + num12);
			}
			if (vyhid1 == "прямокутний")
			{
				double num39 = 2.0 * (double)(a1 + 10 + b1 + 50);
				num12 = ((num39 <= 500.0) ? 60 : 30);
				num7 += (num39 + num12) * ((double)p1 + num12);
			}
			if (vyhid2 == "прямокутний")
			{
				double num39 = 2.0 * (double)(a2 + 10 + b2 + 50);
				num12 = ((num39 <= 500.0) ? 60 : 30);
				num7 += (num39 + num12) * ((double)p2 + num12);
			}
			if (vyhid3 == "прямокутний")
			{
				double num39 = 2.0 * (double)(a3 + 10 + b3 + 50);
				num12 = ((num39 <= 500.0) ? 60 : 30);
				num7 += (num39 + num12) * ((double)p3 + num12);
			}
		}
		array[num, 0] = (num5 + num6 + num7 + num8 + num9) * 1.05 / 1000000.0;
		array[num, 1] = 0.05;
		materialSpendingCommercialOffer = array[num, 0];
		if (materialSpendingCommercialOffer < 0.005)
		{
			materialSpendingCommercialOffer = Math.Round(1000.0 * materialSpendingCommercialOffer) / 1000.0;
		}
		else
		{
			materialSpendingCommercialOffer = Math.Round(100.0 * materialSpendingCommercialOffer) / 100.0;
		}
		array[num, 4] = array[num, 0] * (double)number;
		array[num, 5] = array[num, 4] * num2 * num3 / 1000.0;
		array[num, 2] = array[num, 4] * array[num, 1];
		array[num, 3] = array[num, 5] * array[num, 1];
		for (int m = 0; m < 5; m++)
		{
			if (array[num, m] < 0.005)
			{
				array[num, m] = Math.Round(1000.0 * array[num, m]) / 1000.0;
			}
			else
			{
				array[num, m] = Math.Round(100.0 * array[num, m]) / 100.0;
			}
		}
		materialCost = array[num, 0] * num4;
		if (connection == "заклепка")
		{
			int num40 = 7;
			int num41 = 50;
			int num42 = 2 * (2 * (int)Math.Round(((double)H - 2.0 * (double)num40) / (double)num41, MidpointRounding.AwayFromZero) + (int)Math.Round(((double)B - 2.0 * (double)num40) / (double)num41, MidpointRounding.AwayFromZero));
			if (zhyrFiltr == "так" && num11 == 1)
			{
				if (text == "ЗВП-4")
				{
					num42 += 4;
					num42 += (int)Math.Round(((double)L - 100.0) / 200.0, MidpointRounding.AwayFromZero);
				}
				else
				{
					num42 += 4;
					num42 += 2 * (int)Math.Round(((double)L - 100.0) / 200.0, MidpointRounding.AwayFromZero);
				}
			}
			if (zhyrFiltr == "так" && text == "ЗВО-4" && num11 == 2)
			{
				num42 += 4;
			}
			num++;
			materialName[num] = Consts2.zaklepkaKombinov48x6.MaterialName;
			array[num, 0] = num42;
			array[num, 4] = array[num, 0] * (double)number;
		}
		if (zhyrFiltr == "так")
		{
			double[] array2 = new double[6];
			for (int n = 0; n < nFiltr; n++)
			{
				array2 = FiltrZh.MaterialFiltrZh(kFiltr[n], ZontOstrivnyyTyp2.l, markaStaliFiltr, tovchynaMetaluFiltr, 2 * number);
				materialCost += FiltrZh.materialCost;
				num++;
				materialName[num] = FiltrZh.materialName[0];
				for (int num43 = 0; num43 < 6; num43++)
				{
					array[num, num43] = array2[num43];
				}
				materialSpendingCommercialOffer1 += array[num, 0];
			}
			if (materialSpendingCommercialOffer1 < 0.005)
			{
				materialSpendingCommercialOffer1 = Math.Round(1000.0 * materialSpendingCommercialOffer1) / 1000.0;
			}
			else
			{
				materialSpendingCommercialOffer1 = Math.Round(100.0 * materialSpendingCommercialOffer1) / 100.0;
			}
		}
		if (vyhid == "з виходом")
		{
			if ((vyhid1 == "круглий" && typVyhid1 == "фланець") || (vyhid2 == "круглий" && typVyhid2 == "фланець") || (vyhid3 == "круглий" && typVyhid3 == "фланець"))
			{
				double[,] array3 = new double[5, 6];
				if (vyhid1 == "круглий" && typVyhid1 == "фланець")
				{
					num++;
					int typMaterial = 0;
					switch (profilType1)
					{
					case "Лист Ст 3 3мм":
						typMaterial = 1;
						break;
					case "Кутник 25х25х3":
						typMaterial = 3;
						break;
					case "Кутник 32х32х3":
						typMaterial = 4;
						break;
					case "Кутник 35х35х4":
						typMaterial = 5;
						break;
					}
					array3 = FlanetsKruglyj.MaterialFlanetsKruglyj(d1, typMaterial, number, 1);
					materialCost += FlanetsKruglyj.materialCost1;
					int num44 = 0;
					for (int num45 = 0; num45 < 5 && FlanetsKruglyj.materialName1[num45] != ""; num45++)
					{
						num44++;
					}
					for (int num46 = 0; num46 < num44; num46++)
					{
						materialName[num46 + num] = FlanetsKruglyj.materialName1[num46];
						for (int num47 = 0; num47 < 6; num47++)
						{
							array[num46 + num, num47] = array3[num46, num47];
						}
					}
					num += num44 - 1;
				}
				if (vyhid2 == "круглий" && typVyhid2 == "фланець")
				{
					num++;
					int typMaterial2 = 0;
					switch (profilType2)
					{
					case "Лист Ст 3 3мм":
						typMaterial2 = 1;
						break;
					case "Кутник 25х25х3":
						typMaterial2 = 3;
						break;
					case "Кутник 32х32х3":
						typMaterial2 = 4;
						break;
					case "Кутник 35х35х4":
						typMaterial2 = 5;
						break;
					}
					array3 = FlanetsKruglyj.MaterialFlanetsKruglyj(d2, typMaterial2, number, 1);
					materialCost += FlanetsKruglyj.materialCost1;
					int num48 = 0;
					for (int num49 = 0; num49 < 5 && FlanetsKruglyj.materialName1[num49] != ""; num49++)
					{
						num48++;
					}
					for (int num50 = 0; num50 < num48; num50++)
					{
						materialName[num50 + num] = FlanetsKruglyj.materialName1[num50];
						for (int num51 = 0; num51 < 6; num51++)
						{
							array[num50 + num, num51] = array3[num50, num51];
						}
					}
					num += num48 - 1;
				}
				if (vyhid3 == "круглий" && typVyhid3 == "фланець")
				{
					num++;
					int typMaterial3 = 0;
					switch (profilType3)
					{
					case "Лист Ст 3 3мм":
						typMaterial3 = 1;
						break;
					case "Кутник 25х25х3":
						typMaterial3 = 3;
						break;
					case "Кутник 32х32х3":
						typMaterial3 = 4;
						break;
					case "Кутник 35х35х4":
						typMaterial3 = 5;
						break;
					}
					array3 = FlanetsKruglyj.MaterialFlanetsKruglyj(d3, typMaterial3, number, 1);
					materialCost += FlanetsKruglyj.materialCost1;
					int num52 = 0;
					for (int num53 = 0; num53 < 5 && FlanetsKruglyj.materialName1[num53] != ""; num53++)
					{
						num52++;
					}
					for (int num54 = 0; num54 < num52; num54++)
					{
						materialName[num54 + num] = FlanetsKruglyj.materialName1[num54];
						for (int num55 = 0; num55 < 6; num55++)
						{
							array[num54 + num, num55] = array3[num54, num55];
						}
					}
					num += num52 - 1;
				}
			}
			if ((vyhid1 == "прямокутний" && typVyhid1 == "фланець") || (vyhid2 == "прямокутний" && typVyhid2 == "фланець") || (vyhid3 == "прямокутний" && typVyhid3 == "фланець"))
			{
				double[,] array4 = new double[2, 6];
				if (vyhid1 == "прямокутний" && typVyhid1 == "фланець")
				{
					array4 = MaterialFlanetsPrjamokutnyj(a1, b1, profilType1, number);
					materialCost += materialCost1;
					for (int num56 = 0; num56 < 2; num56++)
					{
						if (materialName1[num56] != "")
						{
							num++;
							materialName[num] = materialName1[num56];
							for (int num57 = 0; num57 < 6; num57++)
							{
								array[num, num57] = array4[num56, num57];
							}
						}
					}
				}
				if (vyhid2 == "прямокутний" && typVyhid2 == "фланець")
				{
					array4 = MaterialFlanetsPrjamokutnyj(a2, b2, profilType2, number);
					materialCost += materialCost1;
					for (int num58 = 0; num58 < 2; num58++)
					{
						if (materialName1[num58] != "")
						{
							num++;
							materialName[num] = materialName1[num58];
							for (int num59 = 0; num59 < 6; num59++)
							{
								array[num, num59] = array4[num58, num59];
							}
						}
					}
				}
				if (vyhid3 == "прямокутний" && typVyhid3 == "фланець")
				{
					array4 = MaterialFlanetsPrjamokutnyj(a3, b3, profilType3, number);
					materialCost += materialCost1;
					for (int num60 = 0; num60 < 2; num60++)
					{
						if (materialName1[num60] != "")
						{
							num++;
							materialName[num] = materialName1[num60];
							for (int num61 = 0; num61 < 6; num61++)
							{
								array[num, num61] = array4[num60, num61];
							}
						}
					}
				}
				num++;
			}
		}
		if (num > 0)
		{
			for (int num62 = 0; num62 < num; num62++)
			{
				for (int num63 = num62 + 1; num63 <= num; num63++)
				{
					if (!(materialName[num62] == materialName[num63]))
					{
						continue;
					}
					for (int num64 = 0; num64 < 6; num64++)
					{
						if (num64 == 1)
						{
							if (materialName[num62] == Consts2.lystStalnyj30.MaterialName)
							{
								array[num62, num64] = Math.Round((array[num62, num64] + array[num63, num64]) / 2.0);
							}
						}
						else
						{
							array[num62, num64] += array[num63, num64];
						}
						array[num63, num64] = 0.0;
					}
					materialName[num63] = "";
				}
			}
		}
		priceProduct = Math.Round(100.0 * materialCost * 3.0) / 100.0;
		return array;
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
			materialCost1 = num * Consts2.profilS20.Price + 4.0 * Consts2.kutnykS20.Price;
		}
		else if (typProfilBH == "S - 20 нерж")
		{
			materialName1[0] = Consts2.profilS20nerzh.MaterialName;
			materialName1[1] = Consts2.kutnykS20nerzh.MaterialName;
			num2 = 0.5;
			materialCost1 = num * Consts2.profilS20nerzh.Price + 4.0 * Consts2.kutnykS20nerzh.Price;
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

	public static void ZontOstrivnyyTyp2DrawDxf(int L, int B, int H, int h, string connection, string zlyv, string vyhid, string vyhid1, int d1, int a1, int b1, int f1, int g1, string typVyhid1, string vyhid2, int d2, int a2, int b2, int f2, int g2, string typVyhid2, string vyhid3, int d3, int a3, int b3, int f3, int g3, string typVyhid3, string zhyrFiltr, int G, string filePath)
	{
		ushort num = 566;
		string text = "0";
		double num2 = 0.0;
		double num3 = 0.0;
		double num4 = 0.0;
		double num5 = 0.0;
		try
		{
			FileStream stream = new FileStream(filePath + ".dxf", FileMode.OpenOrCreate);
			StreamWriter streamWriter = new StreamWriter(stream);
			streamWriter.WriteLine("0");
			streamWriter.WriteLine("SECTION");
			streamWriter.WriteLine("2");
			streamWriter.WriteLine("HEADER");
			streamWriter.WriteLine("9");
			streamWriter.WriteLine("$ACADVER");
			streamWriter.WriteLine("1");
			streamWriter.WriteLine("AC1015");
			streamWriter.WriteLine("9");
			streamWriter.WriteLine("$ACADMAINTVER");
			streamWriter.WriteLine("70");
			streamWriter.WriteLine("13");
			streamWriter.WriteLine("9");
			streamWriter.WriteLine("$DWGCODEPAGE");
			streamWriter.WriteLine("3");
			streamWriter.WriteLine("ANSI_1251");
			streamWriter.WriteLine("9");
			streamWriter.WriteLine("$INSBASE");
			streamWriter.WriteLine("10");
			streamWriter.WriteLine("0");
			streamWriter.WriteLine("20");
			streamWriter.WriteLine("0");
			streamWriter.WriteLine("30");
			streamWriter.WriteLine("0");
			streamWriter.WriteLine("9");
			streamWriter.WriteLine("$EXTMIN");
			streamWriter.WriteLine("10");
			streamWriter.WriteLine("0");
			streamWriter.WriteLine("20");
			streamWriter.WriteLine("-2.4E-15");
			streamWriter.WriteLine("30");
			streamWriter.WriteLine("0");
			streamWriter.WriteLine("9");
			streamWriter.WriteLine("$EXTMAX");
			streamWriter.WriteLine("10");
			streamWriter.WriteLine("98.0499999999999");
			streamWriter.WriteLine("20");
			streamWriter.WriteLine("44.3749999999999");
			streamWriter.WriteLine("30");
			streamWriter.WriteLine("83.6344714633423");
			streamWriter.WriteLine("9");
			streamWriter.WriteLine("$LIMMIN");
			streamWriter.WriteLine("10");
			streamWriter.WriteLine("0");
			streamWriter.WriteLine("20");
			streamWriter.WriteLine("0");
			streamWriter.WriteLine("9");
			streamWriter.WriteLine("$LIMMAX");
			streamWriter.WriteLine("10");
			streamWriter.WriteLine("420");
			streamWriter.WriteLine("20");
			streamWriter.WriteLine("297");
			streamWriter.WriteLine("9");
			streamWriter.WriteLine("$ORTHOMODE");
			streamWriter.WriteLine("70");
			streamWriter.WriteLine("0");
			streamWriter.WriteLine("9");
			streamWriter.WriteLine("$REGENMODE");
			streamWriter.WriteLine("70");
			streamWriter.WriteLine("1");
			streamWriter.WriteLine("9");
			streamWriter.WriteLine("$FILLMODE");
			streamWriter.WriteLine("70");
			streamWriter.WriteLine("1");
			streamWriter.WriteLine("9");
			streamWriter.WriteLine("$QTEXTMODE");
			streamWriter.WriteLine("70");
			streamWriter.WriteLine("0");
			streamWriter.WriteLine("9");
			streamWriter.WriteLine("$MIRRTEXT");
			streamWriter.WriteLine("70");
			streamWriter.WriteLine("1");
			streamWriter.WriteLine("9");
			streamWriter.WriteLine("$LTSCALE");
			streamWriter.WriteLine("40");
			streamWriter.WriteLine("1");
			streamWriter.WriteLine("9");
			streamWriter.WriteLine("$ATTMODE");
			streamWriter.WriteLine("70");
			streamWriter.WriteLine("1");
			streamWriter.WriteLine("9");
			streamWriter.WriteLine("$TEXTSIZE");
			streamWriter.WriteLine("40");
			streamWriter.WriteLine("2.5");
			streamWriter.WriteLine("9");
			streamWriter.WriteLine("$TRACEWID");
			streamWriter.WriteLine("40");
			streamWriter.WriteLine("1");
			streamWriter.WriteLine("9");
			streamWriter.WriteLine("$TEXTSTYLE");
			streamWriter.WriteLine("7");
			streamWriter.WriteLine("Standard");
			streamWriter.WriteLine("9");
			streamWriter.WriteLine("$CLAYER");
			streamWriter.WriteLine("8");
			streamWriter.WriteLine(text);
			streamWriter.WriteLine("9");
			streamWriter.WriteLine("$CELTYPE");
			streamWriter.WriteLine("6");
			streamWriter.WriteLine("ByLayer");
			streamWriter.WriteLine("9");
			streamWriter.WriteLine("$CECOLOR");
			streamWriter.WriteLine("62");
			streamWriter.WriteLine("256");
			streamWriter.WriteLine("9");
			streamWriter.WriteLine("$CELTSCALE");
			streamWriter.WriteLine("40");
			streamWriter.WriteLine("1");
			streamWriter.WriteLine("9");
			streamWriter.WriteLine("$DISPSILH");
			streamWriter.WriteLine("70");
			streamWriter.WriteLine("0");
			streamWriter.WriteLine("9");
			streamWriter.WriteLine("$DIMSCALE");
			streamWriter.WriteLine("40");
			streamWriter.WriteLine("1");
			streamWriter.WriteLine("9");
			streamWriter.WriteLine("$DIMASZ");
			streamWriter.WriteLine("40");
			streamWriter.WriteLine("2.5");
			streamWriter.WriteLine("9");
			streamWriter.WriteLine("$DIMEXO");
			streamWriter.WriteLine("40");
			streamWriter.WriteLine("0.625");
			streamWriter.WriteLine("9");
			streamWriter.WriteLine("$DIMDLI");
			streamWriter.WriteLine("40");
			streamWriter.WriteLine("3.75");
			streamWriter.WriteLine("9");
			streamWriter.WriteLine("$DIMRND");
			streamWriter.WriteLine("40");
			streamWriter.WriteLine("0");
			streamWriter.WriteLine("9");
			streamWriter.WriteLine("$DIMDLE");
			streamWriter.WriteLine("40");
			streamWriter.WriteLine("0");
			streamWriter.WriteLine("9");
			streamWriter.WriteLine("$DIMEXE");
			streamWriter.WriteLine("40");
			streamWriter.WriteLine("1.25");
			streamWriter.WriteLine("9");
			streamWriter.WriteLine("$DIMTP");
			streamWriter.WriteLine("40");
			streamWriter.WriteLine("0");
			streamWriter.WriteLine("9");
			streamWriter.WriteLine("$DIMTM");
			streamWriter.WriteLine("40");
			streamWriter.WriteLine("0");
			streamWriter.WriteLine("9");
			streamWriter.WriteLine("$DIMTXT");
			streamWriter.WriteLine("40");
			streamWriter.WriteLine("2.5");
			streamWriter.WriteLine("9");
			streamWriter.WriteLine("$DIMCEN");
			streamWriter.WriteLine("40");
			streamWriter.WriteLine("2.5");
			streamWriter.WriteLine("9");
			streamWriter.WriteLine("$DIMTSZ");
			streamWriter.WriteLine("40");
			streamWriter.WriteLine("0");
			streamWriter.WriteLine("9");
			streamWriter.WriteLine("$DIMTOL");
			streamWriter.WriteLine("70");
			streamWriter.WriteLine("0");
			streamWriter.WriteLine("9");
			streamWriter.WriteLine("$DIMLIM");
			streamWriter.WriteLine("70");
			streamWriter.WriteLine("0");
			streamWriter.WriteLine("9");
			streamWriter.WriteLine("$DIMTIH");
			streamWriter.WriteLine("70");
			streamWriter.WriteLine("0");
			streamWriter.WriteLine("9");
			streamWriter.WriteLine("$DIMTOH");
			streamWriter.WriteLine("70");
			streamWriter.WriteLine("0");
			streamWriter.WriteLine("9");
			streamWriter.WriteLine("$DIMSE1");
			streamWriter.WriteLine("70");
			streamWriter.WriteLine("0");
			streamWriter.WriteLine("9");
			streamWriter.WriteLine("$DIMSE2");
			streamWriter.WriteLine("70");
			streamWriter.WriteLine("0");
			streamWriter.WriteLine("9");
			streamWriter.WriteLine("$DIMTAD");
			streamWriter.WriteLine("70");
			streamWriter.WriteLine("1");
			streamWriter.WriteLine("9");
			streamWriter.WriteLine("$DIMZIN");
			streamWriter.WriteLine("70");
			streamWriter.WriteLine("8");
			streamWriter.WriteLine("9");
			streamWriter.WriteLine("$DIMBLK");
			streamWriter.WriteLine("1");
			streamWriter.WriteLine("");
			streamWriter.WriteLine("9");
			streamWriter.WriteLine("$DIMASO");
			streamWriter.WriteLine("70");
			streamWriter.WriteLine("1");
			streamWriter.WriteLine("9");
			streamWriter.WriteLine("$DIMSHO");
			streamWriter.WriteLine("70");
			streamWriter.WriteLine("1");
			streamWriter.WriteLine("9");
			streamWriter.WriteLine("$DIMPOST");
			streamWriter.WriteLine("1");
			streamWriter.WriteLine("");
			streamWriter.WriteLine("9");
			streamWriter.WriteLine("$DIMAPOST");
			streamWriter.WriteLine("1");
			streamWriter.WriteLine("");
			streamWriter.WriteLine("9");
			streamWriter.WriteLine("$DIMALT");
			streamWriter.WriteLine("70");
			streamWriter.WriteLine("0");
			streamWriter.WriteLine("9");
			streamWriter.WriteLine("$DIMALTD");
			streamWriter.WriteLine("70");
			streamWriter.WriteLine("3");
			streamWriter.WriteLine("9");
			streamWriter.WriteLine("$DIMALTF");
			streamWriter.WriteLine("40");
			streamWriter.WriteLine("0.03937007874016");
			streamWriter.WriteLine("9");
			streamWriter.WriteLine("$DIMLFAC");
			streamWriter.WriteLine("40");
			streamWriter.WriteLine("1");
			streamWriter.WriteLine("9");
			streamWriter.WriteLine("$DIMTOFL");
			streamWriter.WriteLine("70");
			streamWriter.WriteLine("1");
			streamWriter.WriteLine("9");
			streamWriter.WriteLine("$DIMTVP");
			streamWriter.WriteLine("40");
			streamWriter.WriteLine("0");
			streamWriter.WriteLine("9");
			streamWriter.WriteLine("$DIMTIX");
			streamWriter.WriteLine("70");
			streamWriter.WriteLine("0");
			streamWriter.WriteLine("9");
			streamWriter.WriteLine("$DIMSOXD");
			streamWriter.WriteLine("70");
			streamWriter.WriteLine("0");
			streamWriter.WriteLine("9");
			streamWriter.WriteLine("$DIMSAH");
			streamWriter.WriteLine("70");
			streamWriter.WriteLine("0");
			streamWriter.WriteLine("9");
			streamWriter.WriteLine("$DIMBLK1");
			streamWriter.WriteLine("1");
			streamWriter.WriteLine("");
			streamWriter.WriteLine("9");
			streamWriter.WriteLine("$DIMBLK2");
			streamWriter.WriteLine("1");
			streamWriter.WriteLine("");
			streamWriter.WriteLine("9");
			streamWriter.WriteLine("$DIMSTYLE");
			streamWriter.WriteLine("2");
			streamWriter.WriteLine("ISO-25");
			streamWriter.WriteLine("9");
			streamWriter.WriteLine("$DIMCLRD");
			streamWriter.WriteLine("70");
			streamWriter.WriteLine("0");
			streamWriter.WriteLine("9");
			streamWriter.WriteLine("$DIMCLRE");
			streamWriter.WriteLine("70");
			streamWriter.WriteLine("0");
			streamWriter.WriteLine("9");
			streamWriter.WriteLine("$DIMCLRT");
			streamWriter.WriteLine("70");
			streamWriter.WriteLine("0");
			streamWriter.WriteLine("9");
			streamWriter.WriteLine("$DIMTFAC");
			streamWriter.WriteLine("40");
			streamWriter.WriteLine("1");
			streamWriter.WriteLine("9");
			streamWriter.WriteLine("$DIMGAP");
			streamWriter.WriteLine("40");
			streamWriter.WriteLine("0.625");
			streamWriter.WriteLine("9");
			streamWriter.WriteLine("$DIMJUST");
			streamWriter.WriteLine("70");
			streamWriter.WriteLine("0");
			streamWriter.WriteLine("9");
			streamWriter.WriteLine("$DIMSD1");
			streamWriter.WriteLine("70");
			streamWriter.WriteLine("0");
			streamWriter.WriteLine("9");
			streamWriter.WriteLine("$DIMSD2");
			streamWriter.WriteLine("70");
			streamWriter.WriteLine("0");
			streamWriter.WriteLine("9");
			streamWriter.WriteLine("$DIMTOLJ");
			streamWriter.WriteLine("70");
			streamWriter.WriteLine("0");
			streamWriter.WriteLine("9");
			streamWriter.WriteLine("$DIMTZIN");
			streamWriter.WriteLine("70");
			streamWriter.WriteLine("8");
			streamWriter.WriteLine("9");
			streamWriter.WriteLine("$DIMALTZ");
			streamWriter.WriteLine("70");
			streamWriter.WriteLine("0");
			streamWriter.WriteLine("9");
			streamWriter.WriteLine("$DIMALTTZ");
			streamWriter.WriteLine("70");
			streamWriter.WriteLine("0");
			streamWriter.WriteLine("9");
			streamWriter.WriteLine("$DIMUPT");
			streamWriter.WriteLine("70");
			streamWriter.WriteLine("0");
			streamWriter.WriteLine("9");
			streamWriter.WriteLine("$DIMDEC");
			streamWriter.WriteLine("70");
			streamWriter.WriteLine("2");
			streamWriter.WriteLine("9");
			streamWriter.WriteLine("$DIMTDEC");
			streamWriter.WriteLine("70");
			streamWriter.WriteLine("2");
			streamWriter.WriteLine("9");
			streamWriter.WriteLine("$DIMALTU");
			streamWriter.WriteLine("70");
			streamWriter.WriteLine("2");
			streamWriter.WriteLine("9");
			streamWriter.WriteLine("$DIMALTTD");
			streamWriter.WriteLine("70");
			streamWriter.WriteLine("3");
			streamWriter.WriteLine("9");
			streamWriter.WriteLine("$DIMTXSTY");
			streamWriter.WriteLine("7");
			streamWriter.WriteLine("Standard");
			streamWriter.WriteLine("9");
			streamWriter.WriteLine("$DIMAUNIT");
			streamWriter.WriteLine("70");
			streamWriter.WriteLine("0");
			streamWriter.WriteLine("9");
			streamWriter.WriteLine("$DIMADEC");
			streamWriter.WriteLine("70");
			streamWriter.WriteLine("0");
			streamWriter.WriteLine("9");
			streamWriter.WriteLine("$DIMALTRND");
			streamWriter.WriteLine("40");
			streamWriter.WriteLine("0");
			streamWriter.WriteLine("9");
			streamWriter.WriteLine("$DIMAZIN");
			streamWriter.WriteLine("70");
			streamWriter.WriteLine("0");
			streamWriter.WriteLine("9");
			streamWriter.WriteLine("$DIMDSEP");
			streamWriter.WriteLine("70");
			streamWriter.WriteLine("44");
			streamWriter.WriteLine("9");
			streamWriter.WriteLine("$DIMATFIT");
			streamWriter.WriteLine("70");
			streamWriter.WriteLine("3");
			streamWriter.WriteLine("9");
			streamWriter.WriteLine("$DIMFRAC");
			streamWriter.WriteLine("70");
			streamWriter.WriteLine("0");
			streamWriter.WriteLine("9");
			streamWriter.WriteLine("$DIMLDRBLK");
			streamWriter.WriteLine("1");
			streamWriter.WriteLine("");
			streamWriter.WriteLine("9");
			streamWriter.WriteLine("$DIMLUNIT");
			streamWriter.WriteLine("70");
			streamWriter.WriteLine("2");
			streamWriter.WriteLine("9");
			streamWriter.WriteLine("$DIMLWD");
			streamWriter.WriteLine("70");
			streamWriter.WriteLine("-2");
			streamWriter.WriteLine("9");
			streamWriter.WriteLine("$DIMLWE");
			streamWriter.WriteLine("70");
			streamWriter.WriteLine("-2");
			streamWriter.WriteLine("9");
			streamWriter.WriteLine("$DIMTMOVE");
			streamWriter.WriteLine("70");
			streamWriter.WriteLine("0");
			streamWriter.WriteLine("9");
			streamWriter.WriteLine("$LUNITS");
			streamWriter.WriteLine("70");
			streamWriter.WriteLine("2");
			streamWriter.WriteLine("9");
			streamWriter.WriteLine("$LUPREC");
			streamWriter.WriteLine("70");
			streamWriter.WriteLine("4");
			streamWriter.WriteLine("9");
			streamWriter.WriteLine("$SKETCHINC");
			streamWriter.WriteLine("40");
			streamWriter.WriteLine("1");
			streamWriter.WriteLine("9");
			streamWriter.WriteLine("$FILLETRAD");
			streamWriter.WriteLine("40");
			streamWriter.WriteLine("10");
			streamWriter.WriteLine("9");
			streamWriter.WriteLine("$AUNITS");
			streamWriter.WriteLine("70");
			streamWriter.WriteLine("0");
			streamWriter.WriteLine("9");
			streamWriter.WriteLine("$AUPREC");
			streamWriter.WriteLine("70");
			streamWriter.WriteLine("0");
			streamWriter.WriteLine("9");
			streamWriter.WriteLine("$MENU");
			streamWriter.WriteLine("1");
			streamWriter.WriteLine(".");
			streamWriter.WriteLine("9");
			streamWriter.WriteLine("$ELEVATION");
			streamWriter.WriteLine("40");
			streamWriter.WriteLine("0");
			streamWriter.WriteLine("9");
			streamWriter.WriteLine("$PELEVATION");
			streamWriter.WriteLine("40");
			streamWriter.WriteLine("0");
			streamWriter.WriteLine("9");
			streamWriter.WriteLine("$THICKNESS");
			streamWriter.WriteLine("40");
			streamWriter.WriteLine("0");
			streamWriter.WriteLine("9");
			streamWriter.WriteLine("$LIMCHECK");
			streamWriter.WriteLine("70");
			streamWriter.WriteLine("0");
			streamWriter.WriteLine("9");
			streamWriter.WriteLine("$CHAMFERA");
			streamWriter.WriteLine("40");
			streamWriter.WriteLine("10");
			streamWriter.WriteLine("9");
			streamWriter.WriteLine("$CHAMFERB");
			streamWriter.WriteLine("40");
			streamWriter.WriteLine("10");
			streamWriter.WriteLine("9");
			streamWriter.WriteLine("$CHAMFERC");
			streamWriter.WriteLine("40");
			streamWriter.WriteLine("20");
			streamWriter.WriteLine("9");
			streamWriter.WriteLine("$CHAMFERD");
			streamWriter.WriteLine("40");
			streamWriter.WriteLine("0");
			streamWriter.WriteLine("9");
			streamWriter.WriteLine("$SKPOLY");
			streamWriter.WriteLine("70");
			streamWriter.WriteLine("0");
			streamWriter.WriteLine("9");
			streamWriter.WriteLine("$TDCREATE");
			streamWriter.WriteLine("40");
			streamWriter.WriteLine("2454559.50949489");
			streamWriter.WriteLine("9");
			streamWriter.WriteLine("$TDUCREATE");
			streamWriter.WriteLine("40");
			streamWriter.WriteLine("2454559.38449489");
			streamWriter.WriteLine("9");
			streamWriter.WriteLine("$TDUPDATE");
			streamWriter.WriteLine("40");
			streamWriter.WriteLine("2454559.51011012");
			streamWriter.WriteLine("9");
			streamWriter.WriteLine("$TDUUPDATE");
			streamWriter.WriteLine("40");
			streamWriter.WriteLine("2454559.38511012");
			streamWriter.WriteLine("9");
			streamWriter.WriteLine("$TDINDWG");
			streamWriter.WriteLine("40");
			streamWriter.WriteLine("0.0006157755");
			streamWriter.WriteLine("9");
			streamWriter.WriteLine("$TDUSRTIMER");
			streamWriter.WriteLine("40");
			streamWriter.WriteLine("0.0006155903");
			streamWriter.WriteLine("9");
			streamWriter.WriteLine("$USRTIMER");
			streamWriter.WriteLine("70");
			streamWriter.WriteLine("1");
			streamWriter.WriteLine("9");
			streamWriter.WriteLine("$ANGBASE");
			streamWriter.WriteLine("50");
			streamWriter.WriteLine("0");
			streamWriter.WriteLine("9");
			streamWriter.WriteLine("$ANGDIR");
			streamWriter.WriteLine("70");
			streamWriter.WriteLine("0");
			streamWriter.WriteLine("9");
			streamWriter.WriteLine("$PDMODE");
			streamWriter.WriteLine("70");
			streamWriter.WriteLine("0");
			streamWriter.WriteLine("9");
			streamWriter.WriteLine("$PDSIZE");
			streamWriter.WriteLine("40");
			streamWriter.WriteLine("0");
			streamWriter.WriteLine("9");
			streamWriter.WriteLine("$PLINEWID");
			streamWriter.WriteLine("40");
			streamWriter.WriteLine("0");
			streamWriter.WriteLine("9");
			streamWriter.WriteLine("$SPLFRAME");
			streamWriter.WriteLine("70");
			streamWriter.WriteLine("0");
			streamWriter.WriteLine("9");
			streamWriter.WriteLine("$SPLINETYPE");
			streamWriter.WriteLine("70");
			streamWriter.WriteLine("6");
			streamWriter.WriteLine("9");
			streamWriter.WriteLine("$SPLINESEGS");
			streamWriter.WriteLine("70");
			streamWriter.WriteLine("8");
			streamWriter.WriteLine("9");
			streamWriter.WriteLine("$HANDSEED");
			streamWriter.WriteLine("5");
			streamWriter.WriteLine("55E");
			streamWriter.WriteLine("9");
			streamWriter.WriteLine("$SURFTAB1");
			streamWriter.WriteLine("70");
			streamWriter.WriteLine("6");
			streamWriter.WriteLine("9");
			streamWriter.WriteLine("$SURFTAB2");
			streamWriter.WriteLine("70");
			streamWriter.WriteLine("6");
			streamWriter.WriteLine("9");
			streamWriter.WriteLine("$SURFTYPE");
			streamWriter.WriteLine("70");
			streamWriter.WriteLine("6");
			streamWriter.WriteLine("9");
			streamWriter.WriteLine("$SURFU");
			streamWriter.WriteLine("70");
			streamWriter.WriteLine("6");
			streamWriter.WriteLine("9");
			streamWriter.WriteLine("$SURFV");
			streamWriter.WriteLine("70");
			streamWriter.WriteLine("6");
			streamWriter.WriteLine("9");
			streamWriter.WriteLine("$UCSBASE");
			streamWriter.WriteLine("2");
			streamWriter.WriteLine("");
			streamWriter.WriteLine("9");
			streamWriter.WriteLine("$UCSNAME");
			streamWriter.WriteLine("2");
			streamWriter.WriteLine("");
			streamWriter.WriteLine("9");
			streamWriter.WriteLine("$UCSORG");
			streamWriter.WriteLine("10");
			streamWriter.WriteLine("0");
			streamWriter.WriteLine("20");
			streamWriter.WriteLine("0");
			streamWriter.WriteLine("30");
			streamWriter.WriteLine("0");
			streamWriter.WriteLine("9");
			streamWriter.WriteLine("$UCSXDIR");
			streamWriter.WriteLine("10");
			streamWriter.WriteLine("1");
			streamWriter.WriteLine("20");
			streamWriter.WriteLine("0");
			streamWriter.WriteLine("30");
			streamWriter.WriteLine("0");
			streamWriter.WriteLine("9");
			streamWriter.WriteLine("$UCSYDIR");
			streamWriter.WriteLine("10");
			streamWriter.WriteLine("0");
			streamWriter.WriteLine("20");
			streamWriter.WriteLine("1");
			streamWriter.WriteLine("30");
			streamWriter.WriteLine("0");
			streamWriter.WriteLine("9");
			streamWriter.WriteLine("$UCSORTHOREF");
			streamWriter.WriteLine("2");
			streamWriter.WriteLine("");
			streamWriter.WriteLine("9");
			streamWriter.WriteLine("$UCSORTHOVIEW");
			streamWriter.WriteLine("70");
			streamWriter.WriteLine("0");
			streamWriter.WriteLine("9");
			streamWriter.WriteLine("$UCSORGTOP");
			streamWriter.WriteLine("10");
			streamWriter.WriteLine("0");
			streamWriter.WriteLine("20");
			streamWriter.WriteLine("0");
			streamWriter.WriteLine("30");
			streamWriter.WriteLine("0");
			streamWriter.WriteLine("9");
			streamWriter.WriteLine("$UCSORGBOTTOM");
			streamWriter.WriteLine("10");
			streamWriter.WriteLine("0");
			streamWriter.WriteLine("20");
			streamWriter.WriteLine("0");
			streamWriter.WriteLine("30");
			streamWriter.WriteLine("0");
			streamWriter.WriteLine("9");
			streamWriter.WriteLine("$UCSORGLEFT");
			streamWriter.WriteLine("10");
			streamWriter.WriteLine("0");
			streamWriter.WriteLine("20");
			streamWriter.WriteLine("0");
			streamWriter.WriteLine("30");
			streamWriter.WriteLine("0");
			streamWriter.WriteLine("9");
			streamWriter.WriteLine("$UCSORGRIGHT");
			streamWriter.WriteLine("10");
			streamWriter.WriteLine("0");
			streamWriter.WriteLine("20");
			streamWriter.WriteLine("0");
			streamWriter.WriteLine("30");
			streamWriter.WriteLine("0");
			streamWriter.WriteLine("9");
			streamWriter.WriteLine("$UCSORGFRONT");
			streamWriter.WriteLine("10");
			streamWriter.WriteLine("0");
			streamWriter.WriteLine("20");
			streamWriter.WriteLine("0");
			streamWriter.WriteLine("30");
			streamWriter.WriteLine("0");
			streamWriter.WriteLine("9");
			streamWriter.WriteLine("$UCSORGBACK");
			streamWriter.WriteLine("10");
			streamWriter.WriteLine("0");
			streamWriter.WriteLine("20");
			streamWriter.WriteLine("0");
			streamWriter.WriteLine("30");
			streamWriter.WriteLine("0");
			streamWriter.WriteLine("9");
			streamWriter.WriteLine("$PUCSBASE");
			streamWriter.WriteLine("2");
			streamWriter.WriteLine("");
			streamWriter.WriteLine("9");
			streamWriter.WriteLine("$PUCSNAME");
			streamWriter.WriteLine("2");
			streamWriter.WriteLine("");
			streamWriter.WriteLine("9");
			streamWriter.WriteLine("$PUCSORG");
			streamWriter.WriteLine("10");
			streamWriter.WriteLine("0");
			streamWriter.WriteLine("20");
			streamWriter.WriteLine("0");
			streamWriter.WriteLine("30");
			streamWriter.WriteLine("0");
			streamWriter.WriteLine("9");
			streamWriter.WriteLine("$PUCSXDIR");
			streamWriter.WriteLine("10");
			streamWriter.WriteLine("1");
			streamWriter.WriteLine("20");
			streamWriter.WriteLine("0");
			streamWriter.WriteLine("30");
			streamWriter.WriteLine("0");
			streamWriter.WriteLine("9");
			streamWriter.WriteLine("$PUCSYDIR");
			streamWriter.WriteLine("10");
			streamWriter.WriteLine("0");
			streamWriter.WriteLine("20");
			streamWriter.WriteLine("1");
			streamWriter.WriteLine("30");
			streamWriter.WriteLine("0");
			streamWriter.WriteLine("9");
			streamWriter.WriteLine("$PUCSORTHOREF");
			streamWriter.WriteLine("2");
			streamWriter.WriteLine("");
			streamWriter.WriteLine("9");
			streamWriter.WriteLine("$PUCSORTHOVIEW");
			streamWriter.WriteLine("70");
			streamWriter.WriteLine("0");
			streamWriter.WriteLine("9");
			streamWriter.WriteLine("$PUCSORGTOP");
			streamWriter.WriteLine("10");
			streamWriter.WriteLine("0");
			streamWriter.WriteLine("20");
			streamWriter.WriteLine("0");
			streamWriter.WriteLine("30");
			streamWriter.WriteLine("0");
			streamWriter.WriteLine("9");
			streamWriter.WriteLine("$PUCSORGBOTTOM");
			streamWriter.WriteLine("10");
			streamWriter.WriteLine("0");
			streamWriter.WriteLine("20");
			streamWriter.WriteLine("0");
			streamWriter.WriteLine("30");
			streamWriter.WriteLine("0");
			streamWriter.WriteLine("9");
			streamWriter.WriteLine("$PUCSORGLEFT");
			streamWriter.WriteLine("10");
			streamWriter.WriteLine("0");
			streamWriter.WriteLine("20");
			streamWriter.WriteLine("0");
			streamWriter.WriteLine("30");
			streamWriter.WriteLine("0");
			streamWriter.WriteLine("9");
			streamWriter.WriteLine("$PUCSORGRIGHT");
			streamWriter.WriteLine("10");
			streamWriter.WriteLine("0");
			streamWriter.WriteLine("20");
			streamWriter.WriteLine("0");
			streamWriter.WriteLine("30");
			streamWriter.WriteLine("0");
			streamWriter.WriteLine("9");
			streamWriter.WriteLine("$PUCSORGFRONT");
			streamWriter.WriteLine("10");
			streamWriter.WriteLine("0");
			streamWriter.WriteLine("20");
			streamWriter.WriteLine("0");
			streamWriter.WriteLine("30");
			streamWriter.WriteLine("0");
			streamWriter.WriteLine("9");
			streamWriter.WriteLine("$PUCSORGBACK");
			streamWriter.WriteLine("10");
			streamWriter.WriteLine("0");
			streamWriter.WriteLine("20");
			streamWriter.WriteLine("0");
			streamWriter.WriteLine("30");
			streamWriter.WriteLine("0");
			streamWriter.WriteLine("9");
			streamWriter.WriteLine("$USERI1");
			streamWriter.WriteLine("70");
			streamWriter.WriteLine("0");
			streamWriter.WriteLine("9");
			streamWriter.WriteLine("$USERI2");
			streamWriter.WriteLine("70");
			streamWriter.WriteLine("0");
			streamWriter.WriteLine("9");
			streamWriter.WriteLine("$USERI3");
			streamWriter.WriteLine("70");
			streamWriter.WriteLine("0");
			streamWriter.WriteLine("9");
			streamWriter.WriteLine("$USERI4");
			streamWriter.WriteLine("70");
			streamWriter.WriteLine("0");
			streamWriter.WriteLine("9");
			streamWriter.WriteLine("$USERI5");
			streamWriter.WriteLine("70");
			streamWriter.WriteLine("0");
			streamWriter.WriteLine("9");
			streamWriter.WriteLine("$USERR1");
			streamWriter.WriteLine("40");
			streamWriter.WriteLine("0");
			streamWriter.WriteLine("9");
			streamWriter.WriteLine("$USERR2");
			streamWriter.WriteLine("40");
			streamWriter.WriteLine("0");
			streamWriter.WriteLine("9");
			streamWriter.WriteLine("$USERR3");
			streamWriter.WriteLine("40");
			streamWriter.WriteLine("0");
			streamWriter.WriteLine("9");
			streamWriter.WriteLine("$USERR4");
			streamWriter.WriteLine("40");
			streamWriter.WriteLine("0");
			streamWriter.WriteLine("9");
			streamWriter.WriteLine("$USERR5");
			streamWriter.WriteLine("40");
			streamWriter.WriteLine("0");
			streamWriter.WriteLine("9");
			streamWriter.WriteLine("$WORLDVIEW");
			streamWriter.WriteLine("70");
			streamWriter.WriteLine("1");
			streamWriter.WriteLine("9");
			streamWriter.WriteLine("$SHADEDGE");
			streamWriter.WriteLine("70");
			streamWriter.WriteLine("3");
			streamWriter.WriteLine("9");
			streamWriter.WriteLine("$SHADEDIF");
			streamWriter.WriteLine("70");
			streamWriter.WriteLine("70");
			streamWriter.WriteLine("9");
			streamWriter.WriteLine("$TILEMODE");
			streamWriter.WriteLine("70");
			streamWriter.WriteLine("1");
			streamWriter.WriteLine("9");
			streamWriter.WriteLine("$MAXACTVP");
			streamWriter.WriteLine("70");
			streamWriter.WriteLine("64");
			streamWriter.WriteLine("9");
			streamWriter.WriteLine("$PINSBASE");
			streamWriter.WriteLine("10");
			streamWriter.WriteLine("0");
			streamWriter.WriteLine("20");
			streamWriter.WriteLine("0");
			streamWriter.WriteLine("30");
			streamWriter.WriteLine("0");
			streamWriter.WriteLine("9");
			streamWriter.WriteLine("$PLIMCHECK");
			streamWriter.WriteLine("70");
			streamWriter.WriteLine("0");
			streamWriter.WriteLine("9");
			streamWriter.WriteLine("$PEXTMIN");
			streamWriter.WriteLine("10");
			streamWriter.WriteLine("1E+20");
			streamWriter.WriteLine("20");
			streamWriter.WriteLine("1E+20");
			streamWriter.WriteLine("30");
			streamWriter.WriteLine("1E+20");
			streamWriter.WriteLine("9");
			streamWriter.WriteLine("$PEXTMAX");
			streamWriter.WriteLine("10");
			streamWriter.WriteLine("-1E+20");
			streamWriter.WriteLine("20");
			streamWriter.WriteLine("-1E+20");
			streamWriter.WriteLine("30");
			streamWriter.WriteLine("-1E+20");
			streamWriter.WriteLine("9");
			streamWriter.WriteLine("$PLIMMIN");
			streamWriter.WriteLine("10");
			streamWriter.WriteLine("0");
			streamWriter.WriteLine("20");
			streamWriter.WriteLine("0");
			streamWriter.WriteLine("9");
			streamWriter.WriteLine("$PLIMMAX");
			streamWriter.WriteLine("10");
			streamWriter.WriteLine("420");
			streamWriter.WriteLine("20");
			streamWriter.WriteLine("297");
			streamWriter.WriteLine("9");
			streamWriter.WriteLine("$UNITMODE");
			streamWriter.WriteLine("70");
			streamWriter.WriteLine("0");
			streamWriter.WriteLine("9");
			streamWriter.WriteLine("$VISRETAIN");
			streamWriter.WriteLine("70");
			streamWriter.WriteLine("1");
			streamWriter.WriteLine("9");
			streamWriter.WriteLine("$PLINEGEN");
			streamWriter.WriteLine("70");
			streamWriter.WriteLine("0");
			streamWriter.WriteLine("9");
			streamWriter.WriteLine("$PSLTSCALE");
			streamWriter.WriteLine("70");
			streamWriter.WriteLine("1");
			streamWriter.WriteLine("9");
			streamWriter.WriteLine("$TREEDEPTH");
			streamWriter.WriteLine("70");
			streamWriter.WriteLine("3020");
			streamWriter.WriteLine("9");
			streamWriter.WriteLine("$CMLSTYLE");
			streamWriter.WriteLine("2");
			streamWriter.WriteLine("Standard");
			streamWriter.WriteLine("9");
			streamWriter.WriteLine("$CMLJUST");
			streamWriter.WriteLine("70");
			streamWriter.WriteLine("0");
			streamWriter.WriteLine("9");
			streamWriter.WriteLine("$CMLSCALE");
			streamWriter.WriteLine("40");
			streamWriter.WriteLine("20");
			streamWriter.WriteLine("9");
			streamWriter.WriteLine("$PROXYGRAPHICS");
			streamWriter.WriteLine("70");
			streamWriter.WriteLine("1");
			streamWriter.WriteLine("9");
			streamWriter.WriteLine("$MEASUREMENT");
			streamWriter.WriteLine("70");
			streamWriter.WriteLine("1");
			streamWriter.WriteLine("9");
			streamWriter.WriteLine("$CELWEIGHT");
			streamWriter.WriteLine("370");
			streamWriter.WriteLine("-1");
			streamWriter.WriteLine("9");
			streamWriter.WriteLine("$ENDCAPS");
			streamWriter.WriteLine("280");
			streamWriter.WriteLine("0");
			streamWriter.WriteLine("9");
			streamWriter.WriteLine("$JOINSTYLE");
			streamWriter.WriteLine("280");
			streamWriter.WriteLine("0");
			streamWriter.WriteLine("9");
			streamWriter.WriteLine("$LWDISPLAY");
			streamWriter.WriteLine("290");
			streamWriter.WriteLine("0");
			streamWriter.WriteLine("9");
			streamWriter.WriteLine("$INSUNITS");
			streamWriter.WriteLine("70");
			streamWriter.WriteLine("4");
			streamWriter.WriteLine("9");
			streamWriter.WriteLine("$HYPERLINKBASE");
			streamWriter.WriteLine("1");
			streamWriter.WriteLine("");
			streamWriter.WriteLine("9");
			streamWriter.WriteLine("$STYLESHEET");
			streamWriter.WriteLine("1");
			streamWriter.WriteLine("");
			streamWriter.WriteLine("9");
			streamWriter.WriteLine("$XEDIT");
			streamWriter.WriteLine("290");
			streamWriter.WriteLine("1");
			streamWriter.WriteLine("9");
			streamWriter.WriteLine("$CEPSNTYPE");
			streamWriter.WriteLine("380");
			streamWriter.WriteLine("0");
			streamWriter.WriteLine("9");
			streamWriter.WriteLine("$PSTYLEMODE");
			streamWriter.WriteLine("290");
			streamWriter.WriteLine("1");
			streamWriter.WriteLine("9");
			streamWriter.WriteLine("$FINGERPRINTGUID");
			streamWriter.WriteLine("2");
			streamWriter.WriteLine("{51262485-76E3-4C58-AFBD-FD05A8DBFB01}");
			streamWriter.WriteLine("9");
			streamWriter.WriteLine("$VERSIONGUID");
			streamWriter.WriteLine("2");
			streamWriter.WriteLine("{08C46022-0101-4072-9299-A6E01F35DBEE}");
			streamWriter.WriteLine("9");
			streamWriter.WriteLine("$EXTNAMES");
			streamWriter.WriteLine("290");
			streamWriter.WriteLine("1");
			streamWriter.WriteLine("9");
			streamWriter.WriteLine("$PSVPSCALE");
			streamWriter.WriteLine("40");
			streamWriter.WriteLine("0");
			streamWriter.WriteLine("9");
			streamWriter.WriteLine("$OLESTARTUP");
			streamWriter.WriteLine("290");
			streamWriter.WriteLine("0");
			streamWriter.WriteLine("0");
			streamWriter.WriteLine("ENDSEC");
			streamWriter.WriteLine("0");
			streamWriter.WriteLine("SECTION");
			streamWriter.WriteLine("2");
			streamWriter.WriteLine("CLASSES");
			streamWriter.WriteLine("0");
			streamWriter.WriteLine("CLASS");
			streamWriter.WriteLine("1");
			streamWriter.WriteLine("ACDBDICTIONARYWDFLT");
			streamWriter.WriteLine("2");
			streamWriter.WriteLine("AcDbDictionaryWithDefault");
			streamWriter.WriteLine("3");
			streamWriter.WriteLine("AutoCAD 2000");
			streamWriter.WriteLine("90");
			streamWriter.WriteLine("0");
			streamWriter.WriteLine("280");
			streamWriter.WriteLine("0");
			streamWriter.WriteLine("281");
			streamWriter.WriteLine("0");
			streamWriter.WriteLine("0");
			streamWriter.WriteLine("CLASS");
			streamWriter.WriteLine("1");
			streamWriter.WriteLine("ACDBPLACEHOLDER");
			streamWriter.WriteLine("2");
			streamWriter.WriteLine("AcDbPlaceHolder");
			streamWriter.WriteLine("3");
			streamWriter.WriteLine("AutoCAD 2000");
			streamWriter.WriteLine("90");
			streamWriter.WriteLine("0");
			streamWriter.WriteLine("280");
			streamWriter.WriteLine("0");
			streamWriter.WriteLine("281");
			streamWriter.WriteLine("0");
			streamWriter.WriteLine("0");
			streamWriter.WriteLine("CLASS");
			streamWriter.WriteLine("1");
			streamWriter.WriteLine("LAYOUT");
			streamWriter.WriteLine("2");
			streamWriter.WriteLine("AcDbLayout");
			streamWriter.WriteLine("3");
			streamWriter.WriteLine("AutoCAD 2000");
			streamWriter.WriteLine("90");
			streamWriter.WriteLine("0");
			streamWriter.WriteLine("280");
			streamWriter.WriteLine("0");
			streamWriter.WriteLine("281");
			streamWriter.WriteLine("0");
			streamWriter.WriteLine("0");
			streamWriter.WriteLine("CLASS");
			streamWriter.WriteLine("1");
			streamWriter.WriteLine("DICTIONARYVAR");
			streamWriter.WriteLine("2");
			streamWriter.WriteLine("AcDbDictionaryVar");
			streamWriter.WriteLine("3");
			streamWriter.WriteLine("AutoCAD 2000");
			streamWriter.WriteLine("90");
			streamWriter.WriteLine("0");
			streamWriter.WriteLine("280");
			streamWriter.WriteLine("0");
			streamWriter.WriteLine("281");
			streamWriter.WriteLine("0");
			streamWriter.WriteLine("0");
			streamWriter.WriteLine("ENDSEC");
			streamWriter.WriteLine("0");
			streamWriter.WriteLine("SECTION");
			streamWriter.WriteLine("2");
			streamWriter.WriteLine("TABLES");
			streamWriter.WriteLine("0");
			streamWriter.WriteLine("TABLE");
			streamWriter.WriteLine("2");
			streamWriter.WriteLine("VPORT");
			streamWriter.WriteLine("5");
			streamWriter.WriteLine("8");
			streamWriter.WriteLine("330");
			streamWriter.WriteLine("0");
			streamWriter.WriteLine("100");
			streamWriter.WriteLine("AcDbSymbolTable");
			streamWriter.WriteLine("70");
			streamWriter.WriteLine("4");
			streamWriter.WriteLine("0");
			streamWriter.WriteLine("VPORT");
			streamWriter.WriteLine("5");
			streamWriter.WriteLine("55D");
			streamWriter.WriteLine("330");
			streamWriter.WriteLine("8");
			streamWriter.WriteLine("100");
			streamWriter.WriteLine("AcDbSymbolTableRecord");
			streamWriter.WriteLine("100");
			streamWriter.WriteLine("AcDbViewportTableRecord");
			streamWriter.WriteLine("2");
			streamWriter.WriteLine("*Active");
			streamWriter.WriteLine("70");
			streamWriter.WriteLine("0");
			streamWriter.WriteLine("10");
			streamWriter.WriteLine("0");
			streamWriter.WriteLine("20");
			streamWriter.WriteLine("0");
			streamWriter.WriteLine("11");
			streamWriter.WriteLine("1");
			streamWriter.WriteLine("21");
			streamWriter.WriteLine("1");
			streamWriter.WriteLine("12");
			streamWriter.WriteLine("225.181360201511");
			streamWriter.WriteLine("22");
			streamWriter.WriteLine("148.5");
			streamWriter.WriteLine("13");
			streamWriter.WriteLine("0");
			streamWriter.WriteLine("23");
			streamWriter.WriteLine("0");
			streamWriter.WriteLine("14");
			streamWriter.WriteLine("10");
			streamWriter.WriteLine("24");
			streamWriter.WriteLine("10");
			streamWriter.WriteLine("15");
			streamWriter.WriteLine("10");
			streamWriter.WriteLine("25");
			streamWriter.WriteLine("10");
			streamWriter.WriteLine("16");
			streamWriter.WriteLine("0");
			streamWriter.WriteLine("26");
			streamWriter.WriteLine("0");
			streamWriter.WriteLine("36");
			streamWriter.WriteLine("1");
			streamWriter.WriteLine("17");
			streamWriter.WriteLine("0");
			streamWriter.WriteLine("27");
			streamWriter.WriteLine("0");
			streamWriter.WriteLine("37");
			streamWriter.WriteLine("0");
			streamWriter.WriteLine("40");
			streamWriter.WriteLine("297");
			streamWriter.WriteLine("41");
			streamWriter.WriteLine("1.51637279596977");
			streamWriter.WriteLine("42");
			streamWriter.WriteLine("50");
			streamWriter.WriteLine("43");
			streamWriter.WriteLine("0");
			streamWriter.WriteLine("44");
			streamWriter.WriteLine("0");
			streamWriter.WriteLine("50");
			streamWriter.WriteLine("0");
			streamWriter.WriteLine("51");
			streamWriter.WriteLine("0");
			streamWriter.WriteLine("71");
			streamWriter.WriteLine("0");
			streamWriter.WriteLine("72");
			streamWriter.WriteLine("100");
			streamWriter.WriteLine("73");
			streamWriter.WriteLine("1");
			streamWriter.WriteLine("74");
			streamWriter.WriteLine("3");
			streamWriter.WriteLine("75");
			streamWriter.WriteLine("0");
			streamWriter.WriteLine("76");
			streamWriter.WriteLine("0");
			streamWriter.WriteLine("77");
			streamWriter.WriteLine("0");
			streamWriter.WriteLine("78");
			streamWriter.WriteLine("0");
			streamWriter.WriteLine("281");
			streamWriter.WriteLine("0");
			streamWriter.WriteLine("65");
			streamWriter.WriteLine("1");
			streamWriter.WriteLine("110");
			streamWriter.WriteLine("0");
			streamWriter.WriteLine("120");
			streamWriter.WriteLine("0");
			streamWriter.WriteLine("130");
			streamWriter.WriteLine("0");
			streamWriter.WriteLine("111");
			streamWriter.WriteLine("1");
			streamWriter.WriteLine("121");
			streamWriter.WriteLine("0");
			streamWriter.WriteLine("131");
			streamWriter.WriteLine("0");
			streamWriter.WriteLine("112");
			streamWriter.WriteLine("0");
			streamWriter.WriteLine("122");
			streamWriter.WriteLine("1");
			streamWriter.WriteLine("132");
			streamWriter.WriteLine("0");
			streamWriter.WriteLine("79");
			streamWriter.WriteLine("0");
			streamWriter.WriteLine("146");
			streamWriter.WriteLine("0");
			streamWriter.WriteLine("0");
			streamWriter.WriteLine("ENDTAB");
			streamWriter.WriteLine("0");
			streamWriter.WriteLine("TABLE");
			streamWriter.WriteLine("2");
			streamWriter.WriteLine("LTYPE");
			streamWriter.WriteLine("5");
			streamWriter.WriteLine("5");
			streamWriter.WriteLine("330");
			streamWriter.WriteLine("0");
			streamWriter.WriteLine("100");
			streamWriter.WriteLine("AcDbSymbolTable");
			streamWriter.WriteLine("70");
			streamWriter.WriteLine("1");
			streamWriter.WriteLine("0");
			streamWriter.WriteLine("LTYPE");
			streamWriter.WriteLine("5");
			streamWriter.WriteLine("14");
			streamWriter.WriteLine("330");
			streamWriter.WriteLine("5");
			streamWriter.WriteLine("100");
			streamWriter.WriteLine("AcDbSymbolTableRecord");
			streamWriter.WriteLine("100");
			streamWriter.WriteLine("AcDbLinetypeTableRecord");
			streamWriter.WriteLine("2");
			streamWriter.WriteLine("ByBlock");
			streamWriter.WriteLine("70");
			streamWriter.WriteLine("0");
			streamWriter.WriteLine("3");
			streamWriter.WriteLine("");
			streamWriter.WriteLine("72");
			streamWriter.WriteLine("65");
			streamWriter.WriteLine("73");
			streamWriter.WriteLine("0");
			streamWriter.WriteLine("40");
			streamWriter.WriteLine("0");
			streamWriter.WriteLine("0");
			streamWriter.WriteLine("LTYPE");
			streamWriter.WriteLine("5");
			streamWriter.WriteLine("15");
			streamWriter.WriteLine("330");
			streamWriter.WriteLine("5");
			streamWriter.WriteLine("100");
			streamWriter.WriteLine("AcDbSymbolTableRecord");
			streamWriter.WriteLine("100");
			streamWriter.WriteLine("AcDbLinetypeTableRecord");
			streamWriter.WriteLine("2");
			streamWriter.WriteLine("ByLayer");
			streamWriter.WriteLine("70");
			streamWriter.WriteLine("0");
			streamWriter.WriteLine("3");
			streamWriter.WriteLine("");
			streamWriter.WriteLine("72");
			streamWriter.WriteLine("65");
			streamWriter.WriteLine("73");
			streamWriter.WriteLine("0");
			streamWriter.WriteLine("40");
			streamWriter.WriteLine("0");
			streamWriter.WriteLine("0");
			streamWriter.WriteLine("LTYPE");
			streamWriter.WriteLine("5");
			streamWriter.WriteLine("16");
			streamWriter.WriteLine("330");
			streamWriter.WriteLine("5");
			streamWriter.WriteLine("100");
			streamWriter.WriteLine("AcDbSymbolTableRecord");
			streamWriter.WriteLine("100");
			streamWriter.WriteLine("AcDbLinetypeTableRecord");
			streamWriter.WriteLine("2");
			streamWriter.WriteLine("Continuous");
			streamWriter.WriteLine("70");
			streamWriter.WriteLine("0");
			streamWriter.WriteLine("3");
			streamWriter.WriteLine("Solid line");
			streamWriter.WriteLine("72");
			streamWriter.WriteLine("65");
			streamWriter.WriteLine("73");
			streamWriter.WriteLine("0");
			streamWriter.WriteLine("40");
			streamWriter.WriteLine("0");
			streamWriter.WriteLine("0");
			streamWriter.WriteLine("ENDTAB");
			streamWriter.WriteLine("0");
			streamWriter.WriteLine("TABLE");
			streamWriter.WriteLine("2");
			streamWriter.WriteLine("LAYER");
			streamWriter.WriteLine("5");
			streamWriter.WriteLine("2");
			streamWriter.WriteLine("330");
			streamWriter.WriteLine("0");
			streamWriter.WriteLine("100");
			streamWriter.WriteLine("AcDbSymbolTable");
			streamWriter.WriteLine("70");
			streamWriter.WriteLine("9");
			streamWriter.WriteLine("0");
			streamWriter.WriteLine("LAYER");
			streamWriter.WriteLine("5");
			streamWriter.WriteLine("10");
			streamWriter.WriteLine("330");
			streamWriter.WriteLine("2");
			streamWriter.WriteLine("100");
			streamWriter.WriteLine("AcDbSymbolTableRecord");
			streamWriter.WriteLine("100");
			streamWriter.WriteLine("AcDbLayerTableRecord");
			streamWriter.WriteLine("2");
			streamWriter.WriteLine("0");
			streamWriter.WriteLine("70");
			streamWriter.WriteLine("0");
			streamWriter.WriteLine("62");
			streamWriter.WriteLine("7");
			streamWriter.WriteLine("6");
			streamWriter.WriteLine("Continuous");
			streamWriter.WriteLine("370");
			streamWriter.WriteLine("-3");
			streamWriter.WriteLine("390");
			streamWriter.WriteLine("F");
			streamWriter.WriteLine("0");
			streamWriter.WriteLine("ENDTAB");
			streamWriter.WriteLine("0");
			streamWriter.WriteLine("TABLE");
			streamWriter.WriteLine("2");
			streamWriter.WriteLine("STYLE");
			streamWriter.WriteLine("5");
			streamWriter.WriteLine("3");
			streamWriter.WriteLine("330");
			streamWriter.WriteLine("0");
			streamWriter.WriteLine("100");
			streamWriter.WriteLine("AcDbSymbolTable");
			streamWriter.WriteLine("70");
			streamWriter.WriteLine("1");
			streamWriter.WriteLine("0");
			streamWriter.WriteLine("STYLE");
			streamWriter.WriteLine("5");
			streamWriter.WriteLine("11");
			streamWriter.WriteLine("330");
			streamWriter.WriteLine("3");
			streamWriter.WriteLine("100");
			streamWriter.WriteLine("AcDbSymbolTableRecord");
			streamWriter.WriteLine("100");
			streamWriter.WriteLine("AcDbTextStyleTableRecord");
			streamWriter.WriteLine("2");
			streamWriter.WriteLine("Standard");
			streamWriter.WriteLine("70");
			streamWriter.WriteLine("0");
			streamWriter.WriteLine("40");
			streamWriter.WriteLine("0");
			streamWriter.WriteLine("41");
			streamWriter.WriteLine("1");
			streamWriter.WriteLine("50");
			streamWriter.WriteLine("0");
			streamWriter.WriteLine("71");
			streamWriter.WriteLine("0");
			streamWriter.WriteLine("42");
			streamWriter.WriteLine("2.5");
			streamWriter.WriteLine("3");
			streamWriter.WriteLine("txt");
			streamWriter.WriteLine("4");
			streamWriter.WriteLine("");
			streamWriter.WriteLine("0");
			streamWriter.WriteLine("ENDTAB");
			streamWriter.WriteLine("0");
			streamWriter.WriteLine("TABLE");
			streamWriter.WriteLine("2");
			streamWriter.WriteLine("VIEW");
			streamWriter.WriteLine("5");
			streamWriter.WriteLine("6");
			streamWriter.WriteLine("330");
			streamWriter.WriteLine("0");
			streamWriter.WriteLine("100");
			streamWriter.WriteLine("AcDbSymbolTable");
			streamWriter.WriteLine("70");
			streamWriter.WriteLine("0");
			streamWriter.WriteLine("0");
			streamWriter.WriteLine("ENDTAB");
			streamWriter.WriteLine("0");
			streamWriter.WriteLine("TABLE");
			streamWriter.WriteLine("2");
			streamWriter.WriteLine("UCS");
			streamWriter.WriteLine("5");
			streamWriter.WriteLine("7");
			streamWriter.WriteLine("330");
			streamWriter.WriteLine("0");
			streamWriter.WriteLine("100");
			streamWriter.WriteLine("AcDbSymbolTable");
			streamWriter.WriteLine("70");
			streamWriter.WriteLine("0");
			streamWriter.WriteLine("0");
			streamWriter.WriteLine("ENDTAB");
			streamWriter.WriteLine("0");
			streamWriter.WriteLine("TABLE");
			streamWriter.WriteLine("2");
			streamWriter.WriteLine("APPID");
			streamWriter.WriteLine("5");
			streamWriter.WriteLine("9");
			streamWriter.WriteLine("330");
			streamWriter.WriteLine("0");
			streamWriter.WriteLine("100");
			streamWriter.WriteLine("AcDbSymbolTable");
			streamWriter.WriteLine("70");
			streamWriter.WriteLine("1");
			streamWriter.WriteLine("0");
			streamWriter.WriteLine("APPID");
			streamWriter.WriteLine("5");
			streamWriter.WriteLine("12");
			streamWriter.WriteLine("330");
			streamWriter.WriteLine("9");
			streamWriter.WriteLine("100");
			streamWriter.WriteLine("AcDbSymbolTableRecord");
			streamWriter.WriteLine("100");
			streamWriter.WriteLine("AcDbRegAppTableRecord");
			streamWriter.WriteLine("2");
			streamWriter.WriteLine("ACAD");
			streamWriter.WriteLine("70");
			streamWriter.WriteLine("0");
			streamWriter.WriteLine("0");
			streamWriter.WriteLine("ENDTAB");
			streamWriter.WriteLine("0");
			streamWriter.WriteLine("TABLE");
			streamWriter.WriteLine("2");
			streamWriter.WriteLine("DIMSTYLE");
			streamWriter.WriteLine("5");
			streamWriter.WriteLine("A");
			streamWriter.WriteLine("330");
			streamWriter.WriteLine("0");
			streamWriter.WriteLine("100");
			streamWriter.WriteLine("AcDbSymbolTable");
			streamWriter.WriteLine("70");
			streamWriter.WriteLine("1");
			streamWriter.WriteLine("100");
			streamWriter.WriteLine("AcDbDimStyleTable");
			streamWriter.WriteLine("71");
			streamWriter.WriteLine("0");
			streamWriter.WriteLine("0");
			streamWriter.WriteLine("DIMSTYLE");
			streamWriter.WriteLine("105");
			streamWriter.WriteLine("27");
			streamWriter.WriteLine("330");
			streamWriter.WriteLine("A");
			streamWriter.WriteLine("100");
			streamWriter.WriteLine("AcDbSymbolTableRecord");
			streamWriter.WriteLine("100");
			streamWriter.WriteLine("AcDbDimStyleTableRecord");
			streamWriter.WriteLine("2");
			streamWriter.WriteLine("ISO-25");
			streamWriter.WriteLine("70");
			streamWriter.WriteLine("0");
			streamWriter.WriteLine("41");
			streamWriter.WriteLine("2.5");
			streamWriter.WriteLine("42");
			streamWriter.WriteLine("0.625");
			streamWriter.WriteLine("43");
			streamWriter.WriteLine("3.75");
			streamWriter.WriteLine("44");
			streamWriter.WriteLine("1.25");
			streamWriter.WriteLine("73");
			streamWriter.WriteLine("0");
			streamWriter.WriteLine("74");
			streamWriter.WriteLine("0");
			streamWriter.WriteLine("77");
			streamWriter.WriteLine("1");
			streamWriter.WriteLine("78");
			streamWriter.WriteLine("8");
			streamWriter.WriteLine("140");
			streamWriter.WriteLine("2.5");
			streamWriter.WriteLine("141");
			streamWriter.WriteLine("2.5");
			streamWriter.WriteLine("143");
			streamWriter.WriteLine("0.03937007874016");
			streamWriter.WriteLine("147");
			streamWriter.WriteLine("0.625");
			streamWriter.WriteLine("171");
			streamWriter.WriteLine("3");
			streamWriter.WriteLine("172");
			streamWriter.WriteLine("1");
			streamWriter.WriteLine("271");
			streamWriter.WriteLine("2");
			streamWriter.WriteLine("272");
			streamWriter.WriteLine("2");
			streamWriter.WriteLine("274");
			streamWriter.WriteLine("3");
			streamWriter.WriteLine("278");
			streamWriter.WriteLine("44");
			streamWriter.WriteLine("283");
			streamWriter.WriteLine("0");
			streamWriter.WriteLine("284");
			streamWriter.WriteLine("8");
			streamWriter.WriteLine("340");
			streamWriter.WriteLine("11");
			streamWriter.WriteLine("0");
			streamWriter.WriteLine("ENDTAB");
			streamWriter.WriteLine("0");
			streamWriter.WriteLine("TABLE");
			streamWriter.WriteLine("2");
			streamWriter.WriteLine("BLOCK_RECORD");
			streamWriter.WriteLine("5");
			streamWriter.WriteLine("1");
			streamWriter.WriteLine("330");
			streamWriter.WriteLine("0");
			streamWriter.WriteLine("100");
			streamWriter.WriteLine("AcDbSymbolTable");
			streamWriter.WriteLine("70");
			streamWriter.WriteLine("1");
			streamWriter.WriteLine("0");
			streamWriter.WriteLine("BLOCK_RECORD");
			streamWriter.WriteLine("5");
			streamWriter.WriteLine("1F");
			streamWriter.WriteLine("330");
			streamWriter.WriteLine("1");
			streamWriter.WriteLine("100");
			streamWriter.WriteLine("AcDbSymbolTableRecord");
			streamWriter.WriteLine("100");
			streamWriter.WriteLine("AcDbBlockTableRecord");
			streamWriter.WriteLine("2");
			streamWriter.WriteLine("*Model_Space");
			streamWriter.WriteLine("340");
			streamWriter.WriteLine("22");
			streamWriter.WriteLine("0");
			streamWriter.WriteLine("BLOCK_RECORD");
			streamWriter.WriteLine("5");
			streamWriter.WriteLine("1B");
			streamWriter.WriteLine("330");
			streamWriter.WriteLine("1");
			streamWriter.WriteLine("100");
			streamWriter.WriteLine("AcDbSymbolTableRecord");
			streamWriter.WriteLine("100");
			streamWriter.WriteLine("AcDbBlockTableRecord");
			streamWriter.WriteLine("2");
			streamWriter.WriteLine("*Paper_Space");
			streamWriter.WriteLine("340");
			streamWriter.WriteLine("1E");
			streamWriter.WriteLine("0");
			streamWriter.WriteLine("BLOCK_RECORD");
			streamWriter.WriteLine("5");
			streamWriter.WriteLine("23");
			streamWriter.WriteLine("330");
			streamWriter.WriteLine("1");
			streamWriter.WriteLine("100");
			streamWriter.WriteLine("AcDbSymbolTableRecord");
			streamWriter.WriteLine("100");
			streamWriter.WriteLine("AcDbBlockTableRecord");
			streamWriter.WriteLine("2");
			streamWriter.WriteLine("*Paper_Space0");
			streamWriter.WriteLine("340");
			streamWriter.WriteLine("26");
			streamWriter.WriteLine("0");
			streamWriter.WriteLine("ENDTAB");
			streamWriter.WriteLine("0");
			streamWriter.WriteLine("ENDSEC");
			streamWriter.WriteLine("0");
			streamWriter.WriteLine("SECTION");
			streamWriter.WriteLine("2");
			streamWriter.WriteLine("BLOCKS");
			streamWriter.WriteLine("0");
			streamWriter.WriteLine("BLOCK");
			streamWriter.WriteLine("5");
			streamWriter.WriteLine("20");
			streamWriter.WriteLine("330");
			streamWriter.WriteLine("1F");
			streamWriter.WriteLine("100");
			streamWriter.WriteLine("AcDbEntity");
			streamWriter.WriteLine("8");
			streamWriter.WriteLine("0");
			streamWriter.WriteLine("100");
			streamWriter.WriteLine("AcDbBlockBegin");
			streamWriter.WriteLine("2");
			streamWriter.WriteLine("*Model_Space");
			streamWriter.WriteLine("70");
			streamWriter.WriteLine("0");
			streamWriter.WriteLine("10");
			streamWriter.WriteLine("0");
			streamWriter.WriteLine("20");
			streamWriter.WriteLine("0");
			streamWriter.WriteLine("30");
			streamWriter.WriteLine("0");
			streamWriter.WriteLine("3");
			streamWriter.WriteLine("*Model_Space");
			streamWriter.WriteLine("1");
			streamWriter.WriteLine("");
			streamWriter.WriteLine("0");
			streamWriter.WriteLine("ENDBLK");
			streamWriter.WriteLine("5");
			streamWriter.WriteLine("21");
			streamWriter.WriteLine("330");
			streamWriter.WriteLine("1F");
			streamWriter.WriteLine("100");
			streamWriter.WriteLine("AcDbEntity");
			streamWriter.WriteLine("8");
			streamWriter.WriteLine("0");
			streamWriter.WriteLine("100");
			streamWriter.WriteLine("AcDbBlockEnd");
			streamWriter.WriteLine("0");
			streamWriter.WriteLine("BLOCK");
			streamWriter.WriteLine("5");
			streamWriter.WriteLine("1C");
			streamWriter.WriteLine("330");
			streamWriter.WriteLine("1B");
			streamWriter.WriteLine("100");
			streamWriter.WriteLine("AcDbEntity");
			streamWriter.WriteLine("67");
			streamWriter.WriteLine("1");
			streamWriter.WriteLine("8");
			streamWriter.WriteLine("0");
			streamWriter.WriteLine("100");
			streamWriter.WriteLine("AcDbBlockBegin");
			streamWriter.WriteLine("2");
			streamWriter.WriteLine("*Paper_Space");
			streamWriter.WriteLine("70");
			streamWriter.WriteLine("0");
			streamWriter.WriteLine("10");
			streamWriter.WriteLine("0");
			streamWriter.WriteLine("20");
			streamWriter.WriteLine("0");
			streamWriter.WriteLine("30");
			streamWriter.WriteLine("0");
			streamWriter.WriteLine("3");
			streamWriter.WriteLine("*Paper_Space");
			streamWriter.WriteLine("1");
			streamWriter.WriteLine("");
			streamWriter.WriteLine("0");
			streamWriter.WriteLine("ENDBLK");
			streamWriter.WriteLine("5");
			streamWriter.WriteLine("1D");
			streamWriter.WriteLine("330");
			streamWriter.WriteLine("1B");
			streamWriter.WriteLine("100");
			streamWriter.WriteLine("AcDbEntity");
			streamWriter.WriteLine("67");
			streamWriter.WriteLine("1");
			streamWriter.WriteLine("8");
			streamWriter.WriteLine("0");
			streamWriter.WriteLine("100");
			streamWriter.WriteLine("AcDbBlockEnd");
			streamWriter.WriteLine("0");
			streamWriter.WriteLine("BLOCK");
			streamWriter.WriteLine("5");
			streamWriter.WriteLine("24");
			streamWriter.WriteLine("330");
			streamWriter.WriteLine("23");
			streamWriter.WriteLine("100");
			streamWriter.WriteLine("AcDbEntity");
			streamWriter.WriteLine("8");
			streamWriter.WriteLine("0");
			streamWriter.WriteLine("100");
			streamWriter.WriteLine("AcDbBlockBegin");
			streamWriter.WriteLine("2");
			streamWriter.WriteLine("*Paper_Space0");
			streamWriter.WriteLine("70");
			streamWriter.WriteLine("0");
			streamWriter.WriteLine("10");
			streamWriter.WriteLine("0");
			streamWriter.WriteLine("20");
			streamWriter.WriteLine("0");
			streamWriter.WriteLine("30");
			streamWriter.WriteLine("0");
			streamWriter.WriteLine("3");
			streamWriter.WriteLine("*Paper_Space0");
			streamWriter.WriteLine("1");
			streamWriter.WriteLine("");
			streamWriter.WriteLine("0");
			streamWriter.WriteLine("ENDBLK");
			streamWriter.WriteLine("5");
			streamWriter.WriteLine("25");
			streamWriter.WriteLine("330");
			streamWriter.WriteLine("23");
			streamWriter.WriteLine("100");
			streamWriter.WriteLine("AcDbEntity");
			streamWriter.WriteLine("8");
			streamWriter.WriteLine("0");
			streamWriter.WriteLine("100");
			streamWriter.WriteLine("AcDbBlockEnd");
			streamWriter.WriteLine("0");
			streamWriter.WriteLine("ENDSEC");
			streamWriter.WriteLine("0");
			streamWriter.WriteLine("SECTION");
			streamWriter.WriteLine("2");
			streamWriter.WriteLine("ENTITIES");
			streamWriter.WriteLine("0");
			double num6 = 1.0;
			double num7 = 10.0;
			double num8 = 20.0;
			double num9 = 110.0;
			double num10 = 31.0;
			double num11 = 62.0;
			double num12 = 70.0;
			double num14;
			if (connection == "зварка")
			{
				double num13 = 12.0;
				num14 = 12.0;
			}
			else
			{
				double num13 = 15.0;
				num14 = 15.0;
			}
			double num15 = Math.Atan(2.0 * (double)(H - h) / ((double)B - num9));
			double num16 = 0.0;
			double num17 = 0.0;
			num2 = num14;
			num3 = (double)H + num14 - (double)h;
			num4 = num2 - num14;
			num5 = num3 + num14;
			ushort num18 = (ushort)(num + 1);
			num = num18;
			DrawLine(streamWriter, num18, text, num16 + num2, num17 + num3, num16 + num4, num17 + num5);
			num2 = num4;
			num3 = num5;
			num4 = num2;
			num5 = num3 + (double)h - 2.0 * num14;
			num18 = (ushort)(num + 1);
			num = num18;
			DrawLine(streamWriter, num18, text, num16 + num2, num17 + num3, num16 + num4, num17 + num5);
			num = DrawZaklepka(streamWriter, num, text, connection, num2 + num16, num3 + num17, num4 + num16, num5 + num17, 1);
			num2 = num4;
			num3 = num5;
			num4 = num2 + 2.0 * num14;
			num5 = num3 + 2.0 * num14;
			num18 = (ushort)(num + 1);
			num = num18;
			DrawLine(streamWriter, num18, text, num16 + num2, num17 + num3, num16 + num4, num17 + num5);
			num2 = num4;
			num3 = num5;
			num4 = num2 + (double)B - 2.0 * num14;
			num5 = num3;
			num18 = (ushort)(num + 1);
			num = num18;
			DrawLine(streamWriter, num18, text, num16 + num2, num17 + num3, num16 + num4, num17 + num5);
			num = DrawZaklepka(streamWriter, num, text, connection, num2 + num16, num3 + num17, num4 + num16, num5 + num17, 1);
			num2 = num4;
			num3 = num5;
			num4 = num2 + 2.0 * num14;
			num5 = num3 - 2.0 * num14;
			num18 = (ushort)(num + 1);
			num = num18;
			DrawLine(streamWriter, num18, text, num16 + num2, num17 + num3, num16 + num4, num17 + num5);
			num2 = num4;
			num3 = num5;
			num4 = num2;
			num5 = num3 - ((double)h - 2.0 * num14);
			num18 = (ushort)(num + 1);
			num = num18;
			DrawLine(streamWriter, num18, text, num16 + num2, num17 + num3, num16 + num4, num17 + num5);
			num = DrawZaklepka(streamWriter, num, text, connection, num2 + num16, num3 + num17, num4 + num16, num5 + num17, 1);
			num2 = num4;
			num3 = num5;
			num4 = num2 - num14;
			num5 = num3 - num14;
			num18 = (ushort)(num + 1);
			num = num18;
			DrawLine(streamWriter, num18, text, num16 + num2, num17 + num3, num16 + num4, num17 + num5);
			double num19 = 0.0;
			double num20 = 0.0;
			double num21 = num4;
			double num22 = num5;
			double num23 = Math.Sqrt(Math.Pow(((double)B - num9) / 2.0, 2.0) + Math.Pow(H - h, 2.0));
			if (zhyrFiltr == "ні")
			{
				num2 = num14;
				num3 = (double)H + num14 - (double)h;
				num4 = num2 - Math.Sqrt(2.0) * num8 * Math.Cos(Math.PI * 3.0 / 4.0 - num15);
				num5 = num3 - Math.Sqrt(2.0) * num8 * Math.Sin(Math.PI * 3.0 / 4.0 - num15);
				num18 = (ushort)(num + 1);
				num = num18;
				DrawLine(streamWriter, num18, text, num16 + num2, num17 + num3, num16 + num4, num17 + num5);
				num2 = num4;
				num3 = num5;
				num4 = num2 - num7 * Math.Sin(num15);
				num5 = num3 - num7 * Math.Cos(num15);
				num18 = (ushort)(num + 1);
				num = num18;
				DrawLine(streamWriter, num18, text, num16 + num2, num17 + num3, num16 + num4, num17 + num5);
				num2 = num4;
				num3 = num5;
				num4 = num2 + (num23 - 2.0 * num8) * Math.Cos(num15);
				num5 = num3 - (num23 - 2.0 * num8) * Math.Sin(num15);
				num18 = (ushort)(num + 1);
				num = num18;
				DrawLine(streamWriter, num18, text, num16 + num2, num17 + num3, num16 + num4, num17 + num5);
				num2 = num4;
				num3 = num5;
				num4 = num2 + num7 * Math.Sin(num15);
				num5 = num3 + num7 * Math.Cos(num15);
				num18 = (ushort)(num + 1);
				num = num18;
				DrawLine(streamWriter, num18, text, num16 + num2, num17 + num3, num16 + num4, num17 + num5);
				num2 = num4;
				num3 = num5;
				num4 = num2 + Math.Sqrt(2.0) * num8 * Math.Cos(num15 - Math.PI / 4.0);
				num5 = num3 - Math.Sqrt(2.0) * num8 * Math.Sin(num15 - Math.PI / 4.0);
				num18 = (ushort)(num + 1);
				num = num18;
				DrawLine(streamWriter, num18, text, num16 + num2, num17 + num3, num16 + num4, num17 + num5);
				num19 = num4;
				num20 = num5;
				num2 = num21;
				num3 = num22;
				num4 = num2 + Math.Sqrt(2.0) * num8 * Math.Cos(Math.PI * 3.0 / 4.0 - num15);
				num5 = num3 - Math.Sqrt(2.0) * num8 * Math.Sin(Math.PI * 3.0 / 4.0 - num15);
				num18 = (ushort)(num + 1);
				num = num18;
				DrawLine(streamWriter, num18, text, num16 + num2, num17 + num3, num16 + num4, num17 + num5);
				num2 = num4;
				num3 = num5;
				num4 = num2 + num7 * Math.Sin(num15);
				num5 = num3 - num7 * Math.Cos(num15);
				num18 = (ushort)(num + 1);
				num = num18;
				DrawLine(streamWriter, num18, text, num16 + num2, num17 + num3, num16 + num4, num17 + num5);
				num2 = num4;
				num3 = num5;
				num4 = num2 - (num23 - 2.0 * num8) * Math.Cos(num15);
				num5 = num3 - (num23 - 2.0 * num8) * Math.Sin(num15);
				num18 = (ushort)(num + 1);
				num = num18;
				DrawLine(streamWriter, num18, text, num16 + num2, num17 + num3, num16 + num4, num17 + num5);
				num2 = num4;
				num3 = num5;
				num4 = num2 - num7 * Math.Sin(num15);
				num5 = num3 + num7 * Math.Cos(num15);
				num18 = (ushort)(num + 1);
				num = num18;
				DrawLine(streamWriter, num18, text, num16 + num2, num17 + num3, num16 + num4, num17 + num5);
				num2 = num4;
				num3 = num5;
				num4 = num2 - Math.Sqrt(2.0) * num8 * Math.Cos(num15 - Math.PI / 4.0);
				num5 = num3 - Math.Sqrt(2.0) * num8 * Math.Sin(num15 - Math.PI / 4.0);
				num18 = (ushort)(num + 1);
				num = num18;
				DrawLine(streamWriter, num18, text, num16 + num2, num17 + num3, num16 + num4, num17 + num5);
			}
			else
			{
				num2 = num14;
				num3 = (double)H + num14 - (double)h;
				num4 = num2 + Math.Sqrt(2.0) * num14 * Math.Cos(num15 + Math.PI / 4.0);
				num5 = num3 - Math.Sqrt(2.0) * num14 * Math.Sin(num15 + Math.PI / 4.0);
				num18 = (ushort)(num + 1);
				num = num18;
				DrawLine(streamWriter, num18, text, num16 + num2, num17 + num3, num16 + num4, num17 + num5);
				num2 = num4;
				num3 = num5;
				num4 = num2 + (num12 - 2.0 * num14) * Math.Cos(num15);
				num5 = num3 - (num12 - 2.0 * num14) * Math.Sin(num15);
				num18 = (ushort)(num + 1);
				num = num18;
				DrawLine(streamWriter, num18, text, num16 + num2, num17 + num3, num16 + num4, num17 + num5);
				num = DrawZaklepka(streamWriter, num, text, connection, num2 + num16, num3 + num17, num4 + num16, num5 + num17, 0);
				num2 = num4;
				num3 = num5;
				num4 = num14 + num12 * Math.Cos(num15);
				num5 = (double)H + num14 - (double)h - num12 * Math.Sin(num15);
				num18 = (ushort)(num + 1);
				num = num18;
				DrawLine(streamWriter, num18, text, num16 + num2, num17 + num3, num16 + num4, num17 + num5);
				if (L <= 550)
				{
					nFiltr = 1;
					kFiltr[0] = 400;
				}
				else if (L <= 650)
				{
					nFiltr = 1;
					kFiltr[0] = 500;
				}
				else if (L <= 675)
				{
					nFiltr = 1;
					kFiltr[0] = 600;
				}
				else if (L <= 750)
				{
					nFiltr = 2;
					kFiltr[0] = 300;
					kFiltr[1] = 300;
				}
				else if (L <= 850)
				{
					nFiltr = 2;
					kFiltr[0] = 300;
					kFiltr[1] = 400;
				}
				else if (L <= 950)
				{
					nFiltr = 2;
					kFiltr[0] = 400;
					kFiltr[1] = 400;
				}
				else if (L <= 1050)
				{
					nFiltr = 2;
					kFiltr[0] = 400;
					kFiltr[1] = 500;
				}
				else if (L <= 1150)
				{
					nFiltr = 2;
					kFiltr[0] = 500;
					kFiltr[1] = 500;
				}
				else if (L <= 1250)
				{
					nFiltr = 2;
					kFiltr[0] = 500;
					kFiltr[1] = 600;
				}
				else if (L <= 1350)
				{
					nFiltr = 2;
					kFiltr[0] = 600;
					kFiltr[1] = 600;
				}
				else if (L <= 1450)
				{
					nFiltr = 3;
					kFiltr[0] = 400;
					kFiltr[1] = 400;
					kFiltr[2] = 500;
				}
				else if (L <= 1550)
				{
					nFiltr = 3;
					kFiltr[0] = 400;
					kFiltr[1] = 500;
					kFiltr[2] = 500;
				}
				else if (L <= 1650)
				{
					nFiltr = 3;
					kFiltr[0] = 500;
					kFiltr[1] = 500;
					kFiltr[2] = 500;
				}
				else if (L <= 1750)
				{
					nFiltr = 3;
					kFiltr[0] = 500;
					kFiltr[1] = 500;
					kFiltr[2] = 600;
				}
				else if (L <= 1850)
				{
					nFiltr = 3;
					kFiltr[0] = 500;
					kFiltr[1] = 600;
					kFiltr[2] = 600;
				}
				else
				{
					nFiltr = 3;
					kFiltr[0] = 600;
					kFiltr[1] = 600;
					kFiltr[2] = 600;
				}
				kk = 0.0;
				for (int i = 0; i < nFiltr; i++)
				{
					kk += kFiltr[i];
				}
				kk = 0.5 * ((double)L - kk) + 15.0;
				double num24 = kk;
				num2 = num4;
				num3 = num5;
				num4 = num2 - (num24 - num6 / 2.0) * Math.Sin(num15);
				num5 = num3 - (num24 - num6 / 2.0) * Math.Cos(num15);
				num18 = (ushort)(num + 1);
				num = num18;
				DrawLine(streamWriter, num18, text, num16 + num2, num17 + num3, num16 + num4, num17 + num5);
				num2 = num4;
				num3 = num5;
				num4 = num2 + num6 * Math.Cos(num15);
				num5 = num3 - num6 * Math.Sin(num15);
				num18 = (ushort)(num + 1);
				num = num18;
				DrawLine(streamWriter, num18, text, num16 + num2, num17 + num3, num16 + num4, num17 + num5);
				num2 = num4;
				num3 = num5;
				num4 = num2 - num6 * Math.Sin(num15);
				num5 = num3 - num6 * Math.Cos(num15);
				num18 = (ushort)(num + 1);
				num = num18;
				DrawLine(streamWriter, num18, text, num16 + num2, num17 + num3, num16 + num4, num17 + num5);
				num2 = num4;
				num3 = num5;
				num4 = num2 - num6 * Math.Cos(num15);
				num5 = num3 + num6 * Math.Sin(num15);
				num18 = (ushort)(num + 1);
				num = num18;
				DrawLine(streamWriter, num18, text, num16 + num2, num17 + num3, num16 + num4, num17 + num5);
				num2 = num4;
				num3 = num5;
				num4 = num2 - (num7 - num6 / 2.0) * Math.Sin(num15);
				num5 = num3 - (num7 - num6 / 2.0) * Math.Cos(num15);
				num18 = (ushort)(num + 1);
				num = num18;
				DrawLine(streamWriter, num18, text, num16 + num2, num17 + num3, num16 + num4, num17 + num5);
				num2 = num4;
				num3 = num5;
				num4 = num2 + (num23 - num12 - num7) * Math.Cos(num15);
				num5 = num3 - (num23 - num12 - num7) * Math.Sin(num15);
				num18 = (ushort)(num + 1);
				num = num18;
				DrawLine(streamWriter, num18, text, num16 + num2, num17 + num3, num16 + num4, num17 + num5);
				num2 = num4;
				num3 = num5;
				num4 = num2 + Math.Sqrt(2.0) * num7 * Math.Cos(num15 - Math.PI / 4.0);
				num5 = num3 - Math.Sqrt(2.0) * num7 * Math.Sin(num15 - Math.PI / 4.0);
				num18 = (ushort)(num + 1);
				num = num18;
				DrawLine(streamWriter, num18, text, num16 + num2, num17 + num3, num16 + num4, num17 + num5);
				num2 = num4;
				num3 = num5;
				num4 = num2 + num24 * Math.Sin(num15);
				num5 = num3 + num24 * Math.Cos(num15);
				num18 = (ushort)(num + 1);
				num = num18;
				DrawLine(streamWriter, num18, text, num16 + num2, num17 + num3, num16 + num4, num17 + num5);
				num19 = num4;
				num20 = num5;
				num2 = num21;
				num3 = num22;
				num4 = num2 - Math.Sqrt(2.0) * num14 * Math.Cos(num15 + Math.PI / 4.0);
				num5 = num3 - Math.Sqrt(2.0) * num14 * Math.Sin(num15 + Math.PI / 4.0);
				num18 = (ushort)(num + 1);
				num = num18;
				DrawLine(streamWriter, num18, text, num16 + num2, num17 + num3, num16 + num4, num17 + num5);
				num2 = num4;
				num3 = num5;
				num4 = num2 - (num12 - 2.0 * num14) * Math.Cos(num15);
				num5 = num3 - (num12 - 2.0 * num14) * Math.Sin(num15);
				num18 = (ushort)(num + 1);
				num = num18;
				DrawLine(streamWriter, num18, text, num16 + num2, num17 + num3, num16 + num4, num17 + num5);
				num = DrawZaklepka(streamWriter, num, text, connection, num4 + num16, num5 + num17, num2 + num16, num3 + num17, 0);
				num2 = num4;
				num3 = num5;
				num4 = num21 - num12 * Math.Cos(num15);
				num5 = num22 - num12 * Math.Sin(num15);
				num18 = (ushort)(num + 1);
				num = num18;
				DrawLine(streamWriter, num18, text, num16 + num2, num17 + num3, num16 + num4, num17 + num5);
				num2 = num4;
				num3 = num5;
				num4 = num2 + (num24 - num6 / 2.0) * Math.Sin(num15);
				num5 = num3 - (num24 - num6 / 2.0) * Math.Cos(num15);
				num18 = (ushort)(num + 1);
				num = num18;
				DrawLine(streamWriter, num18, text, num16 + num2, num17 + num3, num16 + num4, num17 + num5);
				num2 = num4;
				num3 = num5;
				num4 = num2 - num6 * Math.Cos(num15);
				num5 = num3 - num6 * Math.Sin(num15);
				num18 = (ushort)(num + 1);
				num = num18;
				DrawLine(streamWriter, num18, text, num16 + num2, num17 + num3, num16 + num4, num17 + num5);
				num2 = num4;
				num3 = num5;
				num4 = num2 + num6 * Math.Sin(num15);
				num5 = num3 - num6 * Math.Cos(num15);
				num18 = (ushort)(num + 1);
				num = num18;
				DrawLine(streamWriter, num18, text, num16 + num2, num17 + num3, num16 + num4, num17 + num5);
				num2 = num4;
				num3 = num5;
				num4 = num2 + num6 * Math.Cos(num15);
				num5 = num3 + num6 * Math.Sin(num15);
				num18 = (ushort)(num + 1);
				num = num18;
				DrawLine(streamWriter, num18, text, num16 + num2, num17 + num3, num16 + num4, num17 + num5);
				num2 = num4;
				num3 = num5;
				num4 = num2 + (num7 - num6 / 2.0) * Math.Sin(num15);
				num5 = num3 - (num7 - num6 / 2.0) * Math.Cos(num15);
				num18 = (ushort)(num + 1);
				num = num18;
				DrawLine(streamWriter, num18, text, num16 + num2, num17 + num3, num16 + num4, num17 + num5);
				num2 = num4;
				num3 = num5;
				num4 = num2 - (num23 - num12 - num7) * Math.Cos(num15);
				num5 = num3 - (num23 - num12 - num7) * Math.Sin(num15);
				num18 = (ushort)(num + 1);
				num = num18;
				DrawLine(streamWriter, num18, text, num16 + num2, num17 + num3, num16 + num4, num17 + num5);
				num2 = num4;
				num3 = num5;
				num4 = num2 - Math.Sqrt(2.0) * num7 * Math.Cos(num15 - Math.PI / 4.0);
				num5 = num3 - Math.Sqrt(2.0) * num7 * Math.Sin(num15 - Math.PI / 4.0);
				num18 = (ushort)(num + 1);
				num = num18;
				DrawLine(streamWriter, num18, text, num16 + num2, num17 + num3, num16 + num4, num17 + num5);
				num2 = num4;
				num3 = num5;
				num4 = num2 - num24 * Math.Sin(num15);
				num5 = num3 + num24 * Math.Cos(num15);
				num18 = (ushort)(num + 1);
				num = num18;
				DrawLine(streamWriter, num18, text, num16 + num2, num17 + num3, num16 + num4, num17 + num5);
			}
			num2 = num19;
			num3 = num20;
			num4 = num2 + num14;
			num5 = num3 - num14;
			num18 = (ushort)(num + 1);
			num = num18;
			DrawLine(streamWriter, num18, text, num16 + num2, num17 + num3, num16 + num4, num17 + num5);
			num2 = num4;
			num3 = num5;
			num4 = num2 + num9 - 2.0 * num14;
			num5 = num3;
			num18 = (ushort)(num + 1);
			num = num18;
			DrawLine(streamWriter, num18, text, num16 + num2, num17 + num3, num16 + num4, num17 + num5);
			num2 = num4;
			num3 = num5;
			num4 = num2 + num14;
			num5 = num3 + num14;
			num18 = (ushort)(num + 1);
			num = num18;
			DrawLine(streamWriter, num18, text, num16 + num2, num17 + num3, num16 + num4, num17 + num5);
			double num25 = ((connection == "зварка") ? (L - 5) : L);
			num16 = 0.0;
			num17 = -200.0 - num25;
			double num26 = 0.0;
			double num27 = 0.0;
			if (zhyrFiltr == "ні")
			{
				double num28 = 10.0;
				double num29 = 20.0;
				num2 = num28 + num29;
				num3 = 0.0;
				num4 = num2 - num29;
				num5 = num3 + num29;
				num18 = (ushort)(num + 1);
				num = num18;
				DrawLine(streamWriter, num18, text, num16 + num2, num17 + num3, num16 + num4, num17 + num5);
				num2 = num4;
				num3 = num5;
				num4 = num2 - num28;
				num5 = num3;
				num18 = (ushort)(num + 1);
				num = num18;
				DrawLine(streamWriter, num18, text, num16 + num2, num17 + num3, num16 + num4, num17 + num5);
				num2 = num4;
				num3 = num5;
				num4 = num2;
				num5 = num3 + num25 - 2.0 * num29;
				num18 = (ushort)(num + 1);
				num = num18;
				DrawLine(streamWriter, num18, text, num16 + num2, num17 + num3, num16 + num4, num17 + num5);
				num2 = num4;
				num3 = num5;
				num4 = num2 + num28;
				num5 = num3;
				num18 = (ushort)(num + 1);
				num = num18;
				DrawLine(streamWriter, num18, text, num16 + num2, num17 + num3, num16 + num4, num17 + num5);
				num2 = num4;
				num3 = num5;
				num4 = num2 + num29;
				num5 = num3 + num29;
				num18 = (ushort)(num + 1);
				num = num18;
				DrawLine(streamWriter, num18, text, num16 + num2, num17 + num3, num16 + num4, num17 + num5);
				num2 = num4;
				num3 = num5;
				num4 = num2 + (double)h;
				num5 = num3;
				num18 = (ushort)(num + 1);
				num = num18;
				DrawLine(streamWriter, num18, text, num16 + num2, num17 + num3, num16 + num4, num17 + num5);
				num18 = (ushort)(num + 1);
				num = num18;
				DrawLine(streamWriter, num18, text, num16 + num2, num17 + num3 - num25, num16 + num4, num17 + num5 - num25);
				num = DrawZaklepka_Top(streamWriter, num, text, connection, num2 + num16, num3 + num17, num4 + num16, num5 + num17, 1);
				num = DrawZaklepka_Top(streamWriter, num, text, connection, num2 + num16, num3 + num17 - num25, num4 + num16, num5 + num17 - num25, 0);
				num2 = num4;
				num3 = num5;
				num4 = num2;
				num5 = num3 - num6;
				num18 = (ushort)(num + 1);
				num = num18;
				DrawLine(streamWriter, num18, text, num16 + num2, num17 + num3, num16 + num4, num17 + num5);
				num18 = (ushort)(num + 1);
				num = num18;
				DrawLine(streamWriter, num18, text, num16 + num2, num17 + num3 - num25, num16 + num4, num17 + num5 - num25 + 2.0 * num6);
				num2 = num4;
				num3 = num5;
				num4 = num2 + num6;
				num5 = num3;
				num18 = (ushort)(num + 1);
				num = num18;
				DrawLine(streamWriter, num18, text, num16 + num2, num17 + num3, num16 + num4, num17 + num5);
				num18 = (ushort)(num + 1);
				num = num18;
				DrawLine(streamWriter, num18, text, num16 + num2, num17 + num3 - num25 + 2.0 * num6, num16 + num4, num17 + num5 - num25 + 2.0 * num6);
				num2 = num4;
				num3 = num5;
				num4 = num2;
				num5 = num3 + num6;
				num18 = (ushort)(num + 1);
				num = num18;
				DrawLine(streamWriter, num18, text, num16 + num2, num17 + num3, num16 + num4, num17 + num5);
				num18 = (ushort)(num + 1);
				num = num18;
				DrawLine(streamWriter, num18, text, num16 + num2, num17 + num3 - num25 + num6, num16 + num4, num17 + num5 - num25 + num6);
				num26 = num4;
				num27 = num5 - num25;
				num2 = num4;
				num3 = num5;
				num4 = num2 + (double)B;
				num5 = num3;
				num18 = (ushort)(num + 1);
				num = num18;
				DrawLine(streamWriter, num18, text, num16 + num2, num17 + num3, num16 + num4, num17 + num5);
				num18 = (ushort)(num + 1);
				num = num18;
				DrawLine(streamWriter, num18, text, num16 + num2, num17 + num3 - num25, num16 + num4, num17 + num5 - num25);
				num = DrawZaklepka_Top(streamWriter, num, text, connection, num2 + num16, num3 + num17, num4 + num16, num5 + num17, 1);
				num = DrawZaklepka_Top(streamWriter, num, text, connection, num2 + num16, num3 + num17 - num25, num4 + num16, num5 + num17 - num25, 0);
				num2 = num4;
				num3 = num5;
				num4 = num2;
				num5 = num3 - num6;
				num18 = (ushort)(num + 1);
				num = num18;
				DrawLine(streamWriter, num18, text, num16 + num2, num17 + num3, num16 + num4, num17 + num5);
				num18 = (ushort)(num + 1);
				num = num18;
				DrawLine(streamWriter, num18, text, num16 + num2, num17 + num3 - num25, num16 + num4, num17 + num5 - num25 + 2.0 * num6);
				num2 = num4;
				num3 = num5;
				num4 = num2 + num6;
				num5 = num3;
				num18 = (ushort)(num + 1);
				num = num18;
				DrawLine(streamWriter, num18, text, num16 + num2, num17 + num3, num16 + num4, num17 + num5);
				num18 = (ushort)(num + 1);
				num = num18;
				DrawLine(streamWriter, num18, text, num16 + num2, num17 + num3 - num25 + 2.0 * num6, num16 + num4, num17 + num5 - num25 + 2.0 * num6);
				num2 = num4;
				num3 = num5;
				num4 = num2;
				num5 = num3 + num6;
				num18 = (ushort)(num + 1);
				num = num18;
				DrawLine(streamWriter, num18, text, num16 + num2, num17 + num3, num16 + num4, num17 + num5);
				num18 = (ushort)(num + 1);
				num = num18;
				DrawLine(streamWriter, num18, text, num16 + num2, num17 + num3 - num25 + num6, num16 + num4, num17 + num5 - num25 + num6);
				num2 = num4;
				num3 = num5;
				num4 = num2 + (double)h;
				num5 = num3;
				num18 = (ushort)(num + 1);
				num = num18;
				DrawLine(streamWriter, num18, text, num16 + num2, num17 + num3, num16 + num4, num17 + num5);
				num18 = (ushort)(num + 1);
				num = num18;
				DrawLine(streamWriter, num18, text, num16 + num2, num17 + num3 - num25, num16 + num4, num17 + num5 - num25);
				num = DrawZaklepka_Top(streamWriter, num, text, connection, num2 + num16, num3 + num17, num4 + num16, num5 + num17, 1);
				num = DrawZaklepka_Top(streamWriter, num, text, connection, num2 + num16, num3 + num17 - num25, num4 + num16, num5 + num17 - num25, 0);
				num2 = num4;
				num3 = num5;
				num4 = num2 + num29;
				num5 = num3 - num29;
				num18 = (ushort)(num + 1);
				num = num18;
				DrawLine(streamWriter, num18, text, num16 + num2, num17 + num3, num16 + num4, num17 + num5);
				num2 = num4;
				num3 = num5;
				num4 = num2 + num28;
				num5 = num3;
				num18 = (ushort)(num + 1);
				num = num18;
				DrawLine(streamWriter, num18, text, num16 + num2, num17 + num3, num16 + num4, num17 + num5);
				num2 = num4;
				num3 = num5;
				num4 = num2;
				num5 = num3 - (num25 - 2.0 * num29);
				num18 = (ushort)(num + 1);
				num = num18;
				DrawLine(streamWriter, num18, text, num16 + num2, num17 + num3, num16 + num4, num17 + num5);
				num2 = num4;
				num3 = num5;
				num4 = num2 - num28;
				num5 = num3;
				num18 = (ushort)(num + 1);
				num = num18;
				DrawLine(streamWriter, num18, text, num16 + num2, num17 + num3, num16 + num4, num17 + num5);
				num2 = num4;
				num3 = num5;
				num4 = num2 - num29;
				num5 = num3 - num29;
				num18 = (ushort)(num + 1);
				num = num18;
				DrawLine(streamWriter, num18, text, num16 + num2, num17 + num3, num16 + num4, num17 + num5);
			}
			else
			{
				double num30 = 10.0;
				double num31 = 70.0;
				num2 = 0.0;
				num3 = 0.0;
				num4 = num2;
				num5 = num3 + num25;
				num18 = (ushort)(num + 1);
				num = num18;
				DrawLine(streamWriter, num18, text, num16 + num2, num17 + num3, num16 + num4, num17 + num5);
				num2 = num4;
				num3 = num5;
				num4 = num2 + num30;
				num5 = num3;
				num18 = (ushort)(num + 1);
				num = num18;
				DrawLine(streamWriter, num18, text, num16 + num2, num17 + num3, num16 + num4, num17 + num5);
				num18 = (ushort)(num + 1);
				num = num18;
				DrawLine(streamWriter, num18, text, num16 + num2, num17 + num3 - num25, num16 + num4, num17 + num5 - num25);
				num2 = num4;
				num3 = num5;
				num4 = num2;
				num5 = num3 - num6;
				num18 = (ushort)(num + 1);
				num = num18;
				DrawLine(streamWriter, num18, text, num16 + num2, num17 + num3, num16 + num4, num17 + num5);
				num18 = (ushort)(num + 1);
				num = num18;
				DrawLine(streamWriter, num18, text, num16 + num2, num17 + num3 - num25, num16 + num4, num17 + num5 - num25 + 2.0 * num6);
				num2 = num4;
				num3 = num5;
				num4 = num2 + num6;
				num5 = num3;
				num18 = (ushort)(num + 1);
				num = num18;
				DrawLine(streamWriter, num18, text, num16 + num2, num17 + num3, num16 + num4, num17 + num5);
				num18 = (ushort)(num + 1);
				num = num18;
				DrawLine(streamWriter, num18, text, num16 + num2, num17 + num3 - num25 + 2.0 * num6, num16 + num4, num17 + num5 - num25 + 2.0 * num6);
				num2 = num4;
				num3 = num5;
				num4 = num2;
				num5 = num3 + num6;
				num18 = (ushort)(num + 1);
				num = num18;
				DrawLine(streamWriter, num18, text, num16 + num2, num17 + num3, num16 + num4, num17 + num5);
				num18 = (ushort)(num + 1);
				num = num18;
				DrawLine(streamWriter, num18, text, num16 + num2, num17 + num3 - num25 + num6, num16 + num4, num17 + num5 - num25 + num6);
				num2 = num4;
				num3 = num5;
				num4 = num2 + num31;
				num5 = num3;
				num18 = (ushort)(num + 1);
				num = num18;
				DrawLine(streamWriter, num18, text, num16 + num2, num17 + num3, num16 + num4, num17 + num5);
				num18 = (ushort)(num + 1);
				num = num18;
				DrawLine(streamWriter, num18, text, num16 + num2, num17 + num3 - num25, num16 + num4, num17 + num5 - num25);
				num = DrawZaklepka_Top(streamWriter, num, text, connection, num2 + num16, num3 + num17, num4 + num16, num5 + num17, 1);
				num = DrawZaklepka_Top(streamWriter, num, text, connection, num2 + num16, num3 + num17 - num25, num4 + num16, num5 + num17 - num25, 0);
				num2 = num4;
				num3 = num5;
				num4 = num2;
				num5 = num3 - num6;
				num18 = (ushort)(num + 1);
				num = num18;
				DrawLine(streamWriter, num18, text, num16 + num2, num17 + num3, num16 + num4, num17 + num5);
				num18 = (ushort)(num + 1);
				num = num18;
				DrawLine(streamWriter, num18, text, num16 + num2, num17 + num3 - num25, num16 + num4, num17 + num5 - num25 + 2.0 * num6);
				num2 = num4;
				num3 = num5;
				num4 = num2 + num6;
				num5 = num3;
				num18 = (ushort)(num + 1);
				num = num18;
				DrawLine(streamWriter, num18, text, num16 + num2, num17 + num3, num16 + num4, num17 + num5);
				num18 = (ushort)(num + 1);
				num = num18;
				DrawLine(streamWriter, num18, text, num16 + num2, num17 + num3 - num25 + 2.0 * num6, num16 + num4, num17 + num5 - num25 + 2.0 * num6);
				num2 = num4;
				num3 = num5;
				num4 = num2;
				num5 = num3 + num6;
				num18 = (ushort)(num + 1);
				num = num18;
				DrawLine(streamWriter, num18, text, num16 + num2, num17 + num3, num16 + num4, num17 + num5);
				num18 = (ushort)(num + 1);
				num = num18;
				DrawLine(streamWriter, num18, text, num16 + num2, num17 + num3 - num25 + num6, num16 + num4, num17 + num5 - num25 + num6);
				num2 = num4;
				num3 = num5;
				num4 = num2 + (double)h;
				num5 = num3;
				num18 = (ushort)(num + 1);
				num = num18;
				DrawLine(streamWriter, num18, text, num16 + num2, num17 + num3, num16 + num4, num17 + num5);
				num18 = (ushort)(num + 1);
				num = num18;
				DrawLine(streamWriter, num18, text, num16 + num2, num17 + num3 - num25, num16 + num4, num17 + num5 - num25);
				num = DrawZaklepka_Top(streamWriter, num, text, connection, num2 + num16, num3 + num17, num4 + num16, num5 + num17, 1);
				num = DrawZaklepka_Top(streamWriter, num, text, connection, num2 + num16, num3 + num17 - num25, num4 + num16, num5 + num17 - num25, 0);
				num2 = num4;
				num3 = num5;
				num4 = num2;
				num5 = num3 - num6;
				num18 = (ushort)(num + 1);
				num = num18;
				DrawLine(streamWriter, num18, text, num16 + num2, num17 + num3, num16 + num4, num17 + num5);
				num18 = (ushort)(num + 1);
				num = num18;
				DrawLine(streamWriter, num18, text, num16 + num2, num17 + num3 - num25, num16 + num4, num17 + num5 - num25 + 2.0 * num6);
				num2 = num4;
				num3 = num5;
				num4 = num2 + num6;
				num5 = num3;
				num18 = (ushort)(num + 1);
				num = num18;
				DrawLine(streamWriter, num18, text, num16 + num2, num17 + num3, num16 + num4, num17 + num5);
				num18 = (ushort)(num + 1);
				num = num18;
				DrawLine(streamWriter, num18, text, num16 + num2, num17 + num3 - num25 + 2.0 * num6, num16 + num4, num17 + num5 - num25 + 2.0 * num6);
				num2 = num4;
				num3 = num5;
				num4 = num2;
				num5 = num3 + num6;
				num18 = (ushort)(num + 1);
				num = num18;
				DrawLine(streamWriter, num18, text, num16 + num2, num17 + num3, num16 + num4, num17 + num5);
				num18 = (ushort)(num + 1);
				num = num18;
				DrawLine(streamWriter, num18, text, num16 + num2, num17 + num3 - num25 + num6, num16 + num4, num17 + num5 - num25 + num6);
				num26 = num4;
				num27 = num5 - num25;
				if (zhyrFiltr == "так")
				{
					num = DrawZaklepka_Top_1(streamWriter, num, text, connection, num4 + num16, num5 + num17, num4 + num16, num5 - num25 + num17, 0, 0.5 * (double)(B - G) + 10.0);
					num = DrawZaklepka_Top_1(streamWriter, num, text, connection, num4 + num16, num5 + num17, num4 + num16, num5 - num25 + num17, 0, 0.5 * (double)(B + G) - 10.0);
				}
				num2 = num4;
				num3 = num5;
				num4 = num2 + (double)B;
				num5 = num3;
				num18 = (ushort)(num + 1);
				num = num18;
				DrawLine(streamWriter, num18, text, num16 + num2, num17 + num3, num16 + num4, num17 + num5);
				num18 = (ushort)(num + 1);
				num = num18;
				DrawLine(streamWriter, num18, text, num16 + num2, num17 + num3 - num25, num16 + num4, num17 + num5 - num25);
				num = DrawZaklepka_Top(streamWriter, num, text, connection, num2 + num16, num3 + num17, num4 + num16, num5 + num17, 1);
				num = DrawZaklepka_Top(streamWriter, num, text, connection, num2 + num16, num3 + num17 - num25, num4 + num16, num5 + num17 - num25, 0);
				num2 = num4;
				num3 = num5;
				num4 = num2;
				num5 = num3 - num6;
				num18 = (ushort)(num + 1);
				num = num18;
				DrawLine(streamWriter, num18, text, num16 + num2, num17 + num3, num16 + num4, num17 + num5);
				num18 = (ushort)(num + 1);
				num = num18;
				DrawLine(streamWriter, num18, text, num16 + num2, num17 + num3 - num25, num16 + num4, num17 + num5 - num25 + 2.0 * num6);
				num2 = num4;
				num3 = num5;
				num4 = num2 + num6;
				num5 = num3;
				num18 = (ushort)(num + 1);
				num = num18;
				DrawLine(streamWriter, num18, text, num16 + num2, num17 + num3, num16 + num4, num17 + num5);
				num18 = (ushort)(num + 1);
				num = num18;
				DrawLine(streamWriter, num18, text, num16 + num2, num17 + num3 - num25 + 2.0 * num6, num16 + num4, num17 + num5 - num25 + 2.0 * num6);
				num2 = num4;
				num3 = num5;
				num4 = num2;
				num5 = num3 + num6;
				num18 = (ushort)(num + 1);
				num = num18;
				DrawLine(streamWriter, num18, text, num16 + num2, num17 + num3, num16 + num4, num17 + num5);
				num18 = (ushort)(num + 1);
				num = num18;
				DrawLine(streamWriter, num18, text, num16 + num2, num17 + num3 - num25 + num6, num16 + num4, num17 + num5 - num25 + num6);
				num2 = num4;
				num3 = num5;
				num4 = num2 + (double)h;
				num5 = num3;
				num18 = (ushort)(num + 1);
				num = num18;
				DrawLine(streamWriter, num18, text, num16 + num2, num17 + num3, num16 + num4, num17 + num5);
				num18 = (ushort)(num + 1);
				num = num18;
				DrawLine(streamWriter, num18, text, num16 + num2, num17 + num3 - num25, num16 + num4, num17 + num5 - num25);
				num = DrawZaklepka_Top(streamWriter, num, text, connection, num2 + num16, num3 + num17, num4 + num16, num5 + num17, 1);
				num = DrawZaklepka_Top(streamWriter, num, text, connection, num2 + num16, num3 + num17 - num25, num4 + num16, num5 + num17 - num25, 0);
				num2 = num4;
				num3 = num5;
				num4 = num2;
				num5 = num3 - num6;
				num18 = (ushort)(num + 1);
				num = num18;
				DrawLine(streamWriter, num18, text, num16 + num2, num17 + num3, num16 + num4, num17 + num5);
				num18 = (ushort)(num + 1);
				num = num18;
				DrawLine(streamWriter, num18, text, num16 + num2, num17 + num3 - num25, num16 + num4, num17 + num5 - num25 + 2.0 * num6);
				num2 = num4;
				num3 = num5;
				num4 = num2 + num6;
				num5 = num3;
				num18 = (ushort)(num + 1);
				num = num18;
				DrawLine(streamWriter, num18, text, num16 + num2, num17 + num3, num16 + num4, num17 + num5);
				num18 = (ushort)(num + 1);
				num = num18;
				DrawLine(streamWriter, num18, text, num16 + num2, num17 + num3 - num25 + 2.0 * num6, num16 + num4, num17 + num5 - num25 + 2.0 * num6);
				num2 = num4;
				num3 = num5;
				num4 = num2;
				num5 = num3 + num6;
				num18 = (ushort)(num + 1);
				num = num18;
				DrawLine(streamWriter, num18, text, num16 + num2, num17 + num3, num16 + num4, num17 + num5);
				num18 = (ushort)(num + 1);
				num = num18;
				DrawLine(streamWriter, num18, text, num16 + num2, num17 + num3 - num25 + num6, num16 + num4, num17 + num5 - num25 + num6);
				num2 = num4;
				num3 = num5;
				num4 = num2 + num31;
				num5 = num3;
				num18 = (ushort)(num + 1);
				num = num18;
				DrawLine(streamWriter, num18, text, num16 + num2, num17 + num3, num16 + num4, num17 + num5);
				num18 = (ushort)(num + 1);
				num = num18;
				DrawLine(streamWriter, num18, text, num16 + num2, num17 + num3 - num25, num16 + num4, num17 + num5 - num25);
				num = DrawZaklepka_Top(streamWriter, num, text, connection, num2 + num16, num3 + num17, num4 + num16, num5 + num17, 1);
				num = DrawZaklepka_Top(streamWriter, num, text, connection, num2 + num16, num3 + num17 - num25, num4 + num16, num5 + num17 - num25, 0);
				num2 = num4;
				num3 = num5;
				num4 = num2;
				num5 = num3 - num6;
				num18 = (ushort)(num + 1);
				num = num18;
				DrawLine(streamWriter, num18, text, num16 + num2, num17 + num3, num16 + num4, num17 + num5);
				num18 = (ushort)(num + 1);
				num = num18;
				DrawLine(streamWriter, num18, text, num16 + num2, num17 + num3 - num25, num16 + num4, num17 + num5 - num25 + 2.0 * num6);
				num2 = num4;
				num3 = num5;
				num4 = num2 + num6;
				num5 = num3;
				num18 = (ushort)(num + 1);
				num = num18;
				DrawLine(streamWriter, num18, text, num16 + num2, num17 + num3, num16 + num4, num17 + num5);
				num18 = (ushort)(num + 1);
				num = num18;
				DrawLine(streamWriter, num18, text, num16 + num2, num17 + num3 - num25 + 2.0 * num6, num16 + num4, num17 + num5 - num25 + 2.0 * num6);
				num2 = num4;
				num3 = num5;
				num4 = num2;
				num5 = num3 + num6;
				num18 = (ushort)(num + 1);
				num = num18;
				DrawLine(streamWriter, num18, text, num16 + num2, num17 + num3, num16 + num4, num17 + num5);
				num18 = (ushort)(num + 1);
				num = num18;
				DrawLine(streamWriter, num18, text, num16 + num2, num17 + num3 - num25 + num6, num16 + num4, num17 + num5 - num25 + num6);
				num2 = num4;
				num3 = num5;
				num4 = num2 + num30;
				num5 = num3;
				num18 = (ushort)(num + 1);
				num = num18;
				DrawLine(streamWriter, num18, text, num16 + num2, num17 + num3, num16 + num4, num17 + num5);
				num18 = (ushort)(num + 1);
				num = num18;
				DrawLine(streamWriter, num18, text, num16 + num2, num17 + num3 - num25, num16 + num4, num17 + num5 - num25);
				num2 = num4;
				num3 = num5;
				num4 = num2;
				num5 = num3 - num25;
				num18 = (ushort)(num + 1);
				num = num18;
				DrawLine(streamWriter, num18, text, num16 + num2, num17 + num3, num16 + num4, num17 + num5);
			}
			if (vyhid == "з виходом")
			{
				int num32 = d1;
				int num33 = a1;
				int num34 = b1;
				int num35 = d2;
				int num36 = a2;
				int num37 = b2;
				int num38 = d3;
				int num39 = a3;
				int num40 = b3;
				int num41 = 3;
				int num42 = 2;
				int num43 = 3;
				int num44 = 5;
				if (connection == "зварка")
				{
					if (typVyhid1 == "мінус")
					{
						d1 -= num41;
						a1 -= num41;
						b1 -= num41;
					}
					if (typVyhid2 == "мінус")
					{
						d2 -= num41;
						a2 -= num41;
						b2 -= num41;
					}
					if (typVyhid3 == "мінус")
					{
						d3 -= num41;
						a3 -= num41;
						b3 -= num41;
					}
				}
				if (connection == "заклепка")
				{
					if (typVyhid1 == "чисто" || typVyhid1 == "фланець")
					{
						d1 -= num42;
						a1 += num43;
						b1 += num43;
					}
					if (typVyhid1 == "мінус")
					{
						d1 -= num44;
					}
					if (typVyhid2 == "чисто" || typVyhid2 == "фланець")
					{
						d2 -= num42;
						a2 += num43;
						b2 += num43;
					}
					if (typVyhid2 == "мінус")
					{
						d2 -= num44;
					}
					if (typVyhid3 == "чисто" || typVyhid3 == "фланець")
					{
						d3 -= num42;
						a3 += num43;
						b3 += num43;
					}
					if (typVyhid3 == "мінус")
					{
						d3 -= num44;
					}
				}
				num16 += num26;
				num17 += num27 - 0.5 * ((double)L - num25);
				if (vyhid1 == "круглий")
				{
					num2 = g1;
					num3 = f1;
					num18 = (ushort)(num + 1);
					num = num18;
					DrawCircle(streamWriter, num18, text, num16 + num2, num17 + num3, (double)d1 / 2.0);
				}
				else if (vyhid1 == "прямокутний")
				{
					num2 = (double)g1 + (double)b1 / 2.0;
					num3 = (double)f1 + (double)a1 / 2.0;
					num4 = num2;
					num5 = num3 - (double)a1;
					num18 = (ushort)(num + 1);
					num = num18;
					DrawLine(streamWriter, num18, text, num16 + num2, num17 + num3, num16 + num4, num17 + num5);
					num2 = num4;
					num3 = num5;
					num4 = num2 - (double)b1;
					num5 = num3;
					num18 = (ushort)(num + 1);
					num = num18;
					DrawLine(streamWriter, num18, text, num16 + num2, num17 + num3, num16 + num4, num17 + num5);
					num2 = num4;
					num3 = num5;
					num4 = num2;
					num5 = num3 + (double)a1;
					num18 = (ushort)(num + 1);
					num = num18;
					DrawLine(streamWriter, num18, text, num16 + num2, num17 + num3, num16 + num4, num17 + num5);
					num2 = num4;
					num3 = num5;
					num4 = num2 + (double)b1;
					num5 = num3;
					num18 = (ushort)(num + 1);
					num = num18;
					DrawLine(streamWriter, num18, text, num16 + num2, num17 + num3, num16 + num4, num17 + num5);
				}
				if (vyhid2 == "круглий")
				{
					num2 = g2;
					num3 = f2;
					num18 = (ushort)(num + 1);
					num = num18;
					DrawCircle(streamWriter, num18, text, num16 + num2, num17 + num3, (double)d2 / 2.0);
				}
				else if (vyhid2 == "прямокутний")
				{
					num2 = (double)g2 + (double)b2 / 2.0;
					num3 = (double)f2 + (double)a2 / 2.0;
					num4 = num2;
					num5 = num3 - (double)a2;
					num18 = (ushort)(num + 1);
					num = num18;
					DrawLine(streamWriter, num18, text, num16 + num2, num17 + num3, num16 + num4, num17 + num5);
					num2 = num4;
					num3 = num5;
					num4 = num2 - (double)b2;
					num5 = num3;
					num18 = (ushort)(num + 1);
					num = num18;
					DrawLine(streamWriter, num18, text, num16 + num2, num17 + num3, num16 + num4, num17 + num5);
					num2 = num4;
					num3 = num5;
					num4 = num2;
					num5 = num3 + (double)a2;
					num18 = (ushort)(num + 1);
					num = num18;
					DrawLine(streamWriter, num18, text, num16 + num2, num17 + num3, num16 + num4, num17 + num5);
					num2 = num4;
					num3 = num5;
					num4 = num2 + (double)b2;
					num5 = num3;
					num18 = (ushort)(num + 1);
					num = num18;
					DrawLine(streamWriter, num18, text, num16 + num2, num17 + num3, num16 + num4, num17 + num5);
				}
				if (vyhid3 == "круглий")
				{
					num2 = g3;
					num3 = f3;
					num18 = (ushort)(num + 1);
					num = num18;
					DrawCircle(streamWriter, num18, text, num16 + num2, num17 + num3, (double)d3 / 2.0);
				}
				else if (vyhid3 == "прямокутний")
				{
					num2 = (double)g3 + (double)b3 / 2.0;
					num3 = (double)f3 + (double)a3 / 2.0;
					num4 = num2;
					num5 = num3 - (double)a3;
					num18 = (ushort)(num + 1);
					num = num18;
					DrawLine(streamWriter, num18, text, num16 + num2, num17 + num3, num16 + num4, num17 + num5);
					num2 = num4;
					num3 = num5;
					num4 = num2 - (double)b3;
					num5 = num3;
					num18 = (ushort)(num + 1);
					num = num18;
					DrawLine(streamWriter, num18, text, num16 + num2, num17 + num3, num16 + num4, num17 + num5);
					num2 = num4;
					num3 = num5;
					num4 = num2;
					num5 = num3 + (double)a3;
					num18 = (ushort)(num + 1);
					num = num18;
					DrawLine(streamWriter, num18, text, num16 + num2, num17 + num3, num16 + num4, num17 + num5);
					num2 = num4;
					num3 = num5;
					num4 = num2 + (double)b3;
					num5 = num3;
					num18 = (ushort)(num + 1);
					num = num18;
					DrawLine(streamWriter, num18, text, num16 + num2, num17 + num3, num16 + num4, num17 + num5);
				}
				d1 = num32;
				a1 = num33;
				b1 = num34;
				d2 = num35;
				a2 = num36;
				b2 = num37;
				d3 = num38;
				a3 = num39;
				b3 = num40;
			}
			double num45 = ((connection == "заклепка") ? 24.5 : 24.0);
			double num46 = 110.0;
			num16 = B + 500;
			num17 = 300.0;
			num2 = 0.0;
			num3 = 0.0;
			num4 = num2;
			num5 = num3 + num45;
			num18 = (ushort)(num + 1);
			num = num18;
			DrawLine(streamWriter, num18, text, num16 + num2, num17 + num3, num16 + num4, num17 + num5);
			num2 = num4;
			num3 = num5;
			num4 = num2 + num6;
			num5 = num3;
			num18 = (ushort)(num + 1);
			num = num18;
			DrawLine(streamWriter, num18, text, num16 + num2, num17 + num3, num16 + num4, num17 + num5);
			num2 = num4;
			num3 = num5;
			num4 = num2;
			num5 = num3 + num6;
			num18 = (ushort)(num + 1);
			num = num18;
			DrawLine(streamWriter, num18, text, num16 + num2, num17 + num3, num16 + num4, num17 + num5);
			num2 = num4;
			num3 = num5;
			num4 = num2 - num6;
			num5 = num3;
			num18 = (ushort)(num + 1);
			num = num18;
			DrawLine(streamWriter, num18, text, num16 + num2, num17 + num3, num16 + num4, num17 + num5);
			num2 = num4;
			num3 = num5;
			num4 = num2;
			num5 = num3 + num46;
			num18 = (ushort)(num + 1);
			num = num18;
			DrawLine(streamWriter, num18, text, num16 + num2, num17 + num3, num16 + num4, num17 + num5);
			num = DrawZaklepka_Planka1(streamWriter, num, text, connection, num2 + num16, num3 + num17, num4 + num16, num5 + num17, 1);
			num2 = num4;
			num3 = num5;
			num4 = num2 + num6;
			num5 = num3;
			num18 = (ushort)(num + 1);
			num = num18;
			DrawLine(streamWriter, num18, text, num16 + num2, num17 + num3, num16 + num4, num17 + num5);
			num2 = num4;
			num3 = num5;
			num4 = num2;
			num5 = num3 + num6;
			num18 = (ushort)(num + 1);
			num = num18;
			DrawLine(streamWriter, num18, text, num16 + num2, num17 + num3, num16 + num4, num17 + num5);
			num2 = num4;
			num3 = num5;
			num4 = num2 - num6;
			num5 = num3;
			num18 = (ushort)(num + 1);
			num = num18;
			DrawLine(streamWriter, num18, text, num16 + num2, num17 + num3, num16 + num4, num17 + num5);
			num2 = num4;
			num3 = num5;
			num4 = num2;
			num5 = num3 + num45;
			num18 = (ushort)(num + 1);
			num = num18;
			DrawLine(streamWriter, num18, text, num16 + num2, num17 + num3, num16 + num4, num17 + num5);
			num2 = num4;
			num3 = num5;
			num4 = num2 + (double)L - 5.0;
			num5 = num3;
			num18 = (ushort)(num + 1);
			num = num18;
			DrawLine(streamWriter, num18, text, num16 + num2, num17 + num3, num16 + num4, num17 + num5);
			num2 = num4;
			num3 = num5;
			num4 = num2;
			num5 = num3 - num45;
			num18 = (ushort)(num + 1);
			num = num18;
			DrawLine(streamWriter, num18, text, num16 + num2, num17 + num3, num16 + num4, num17 + num5);
			num2 = num4;
			num3 = num5;
			num4 = num2 - num6;
			num5 = num3;
			num18 = (ushort)(num + 1);
			num = num18;
			DrawLine(streamWriter, num18, text, num16 + num2, num17 + num3, num16 + num4, num17 + num5);
			num2 = num4;
			num3 = num5;
			num4 = num2;
			num5 = num3 - num6;
			num18 = (ushort)(num + 1);
			num = num18;
			DrawLine(streamWriter, num18, text, num16 + num2, num17 + num3, num16 + num4, num17 + num5);
			num2 = num4;
			num3 = num5;
			num4 = num2 + num6;
			num5 = num3;
			num18 = (ushort)(num + 1);
			num = num18;
			DrawLine(streamWriter, num18, text, num16 + num2, num17 + num3, num16 + num4, num17 + num5);
			num2 = num4;
			num3 = num5;
			num4 = num2;
			num5 = num3 - num46;
			num18 = (ushort)(num + 1);
			num = num18;
			DrawLine(streamWriter, num18, text, num16 + num2, num17 + num3, num16 + num4, num17 + num5);
			num = DrawZaklepka_Planka1(streamWriter, num, text, connection, num2 + num16, num3 + num17, num4 + num16, num5 + num17, 1);
			num2 = num4;
			num3 = num5;
			num4 = num2 - num6;
			num5 = num3;
			num18 = (ushort)(num + 1);
			num = num18;
			DrawLine(streamWriter, num18, text, num16 + num2, num17 + num3, num16 + num4, num17 + num5);
			num2 = num4;
			num3 = num5;
			num4 = num2;
			num5 = num3 - num6;
			num18 = (ushort)(num + 1);
			num = num18;
			DrawLine(streamWriter, num18, text, num16 + num2, num17 + num3, num16 + num4, num17 + num5);
			num2 = num4;
			num3 = num5;
			num4 = num2 + num6;
			num5 = num3;
			num18 = (ushort)(num + 1);
			num = num18;
			DrawLine(streamWriter, num18, text, num16 + num2, num17 + num3, num16 + num4, num17 + num5);
			num2 = num4;
			num3 = num5;
			num4 = num2;
			num5 = num3 - num45;
			num18 = (ushort)(num + 1);
			num = num18;
			DrawLine(streamWriter, num18, text, num16 + num2, num17 + num3, num16 + num4, num17 + num5);
			if (zhyrFiltr == "так" && zlyv != "ні")
			{
				double num47 = 75.0;
				double num48 = num45 + num6 + num46 / 2.0;
				double num49 = 16.0;
				num2 = ((zlyv == "так, трубка справа") ? (num4 - num47) : (num4 - (double)(L - 5) + num47));
				num3 = num5 + num48;
				num18 = (ushort)(num + 1);
				num = num18;
				DrawCircle(streamWriter, num18, text, num16 + num2, num17 + num3, num49 / 2.0);
			}
			num2 = num4;
			num3 = num5;
			num4 = num2 - (double)(L - 5);
			num5 = num3;
			num18 = (ushort)(num + 1);
			num = num18;
			DrawLine(streamWriter, num18, text, num16 + num2, num17 + num3, num16 + num4, num17 + num5);
			num16 = B + 500;
			num17 = 120.0;
			num45 = 54.5;
			num46 = 15.0;
			num2 = 0.0;
			num3 = 0.0;
			num4 = num2;
			num5 = num3 + num46;
			num18 = (ushort)(num + 1);
			num = num18;
			DrawLine(streamWriter, num18, text, num16 + num2, num17 + num3, num16 + num4, num17 + num5);
			num2 = num4;
			num3 = num5;
			num4 = num2 + num6;
			num5 = num3;
			num18 = (ushort)(num + 1);
			num = num18;
			DrawLine(streamWriter, num18, text, num16 + num2, num17 + num3, num16 + num4, num17 + num5);
			num2 = num4;
			num3 = num5;
			num4 = num2;
			num5 = num3 + num6;
			num18 = (ushort)(num + 1);
			num = num18;
			DrawLine(streamWriter, num18, text, num16 + num2, num17 + num3, num16 + num4, num17 + num5);
			num2 = num4;
			num3 = num5;
			num4 = num2 - num6;
			num5 = num3;
			num18 = (ushort)(num + 1);
			num = num18;
			DrawLine(streamWriter, num18, text, num16 + num2, num17 + num3, num16 + num4, num17 + num5);
			num2 = num4;
			num3 = num5;
			num4 = num2;
			num5 = num3 + num45;
			num18 = (ushort)(num + 1);
			num = num18;
			DrawLine(streamWriter, num18, text, num16 + num2, num17 + num3, num16 + num4, num17 + num5);
			num2 = num4;
			num3 = num5;
			num4 = num2 + (double)(L - 10);
			num5 = num3;
			num18 = (ushort)(num + 1);
			num = num18;
			DrawLine(streamWriter, num18, text, num16 + num2, num17 + num3, num16 + num4, num17 + num5);
			num2 = num4;
			num3 = num5;
			num4 = num2;
			num5 = num3 - num45;
			num18 = (ushort)(num + 1);
			num = num18;
			DrawLine(streamWriter, num18, text, num16 + num2, num17 + num3, num16 + num4, num17 + num5);
			num2 = num4;
			num3 = num5;
			num4 = num2 - num6;
			num5 = num3;
			num18 = (ushort)(num + 1);
			num = num18;
			DrawLine(streamWriter, num18, text, num16 + num2, num17 + num3, num16 + num4, num17 + num5);
			num2 = num4;
			num3 = num5;
			num4 = num2;
			num5 = num3 - num6;
			num18 = (ushort)(num + 1);
			num = num18;
			DrawLine(streamWriter, num18, text, num16 + num2, num17 + num3, num16 + num4, num17 + num5);
			num2 = num4;
			num3 = num5;
			num4 = num2 + num6;
			num5 = num3;
			num18 = (ushort)(num + 1);
			num = num18;
			DrawLine(streamWriter, num18, text, num16 + num2, num17 + num3, num16 + num4, num17 + num5);
			num2 = num4;
			num3 = num5;
			num4 = num2;
			num5 = num3 - num46;
			num18 = (ushort)(num + 1);
			num = num18;
			DrawLine(streamWriter, num18, text, num16 + num2, num17 + num3, num16 + num4, num17 + num5);
			if (zlyv == "ні")
			{
				num2 = num4;
				num3 = num5;
				num4 = num2 - (double)(L - 10);
				num5 = num3;
				num18 = (ushort)(num + 1);
				num = num18;
				DrawLine(streamWriter, num18, text, num16 + num2, num17 + num3, num16 + num4, num17 + num5);
			}
			else
			{
				double num50 = 12.5;
				double num51 = 10.5;
				double num52 = 72.5;
				num2 = num4 - (double)(L - 10);
				num3 = num5;
				num4 = num2 + num52 - num50;
				num5 = num3;
				num18 = (ushort)(num + 1);
				num = num18;
				DrawLine(streamWriter, num18, text, num16 + num2, num17 + num3, num16 + num4, num17 + num5);
				double num53 = num4;
				double num54 = num5;
				double num55 = 15.0;
				double num56 = 16.0;
				double num57 = 40.0;
				double num58 = 7.0;
				num2 += num55;
				num3 += num56;
				num4 = num2;
				num5 = num3 + num58;
				num18 = (ushort)(num + 1);
				num = num18;
				DrawLine(streamWriter, num18, text, num16 + num2, num17 + num3, num16 + num4, num17 + num5);
				num2 = num4;
				num3 = num5;
				num4 = num2 + num57;
				num5 = num3;
				num18 = (ushort)(num + 1);
				num = num18;
				DrawLine(streamWriter, num18, text, num16 + num2, num17 + num3, num16 + num4, num17 + num5);
				num2 = num4;
				num3 = num5;
				num4 = num2;
				num5 = num3 - num58;
				num18 = (ushort)(num + 1);
				num = num18;
				DrawLine(streamWriter, num18, text, num16 + num2, num17 + num3, num16 + num4, num17 + num5);
				num2 = num4;
				num3 = num5;
				num4 = num2 - num57;
				num5 = num3;
				num18 = (ushort)(num + 1);
				num = num18;
				DrawLine(streamWriter, num18, text, num16 + num2, num17 + num3, num16 + num4, num17 + num5);
				num2 = num53;
				num3 = num54;
				num4 = num2;
				num5 = num3 + num51 + num50;
				num18 = (ushort)(num + 1);
				num = num18;
				DrawLine(streamWriter, num18, text, num16 + num2, num17 + num3, num16 + num4, num17 + num5);
				num2 = num4;
				num3 = num5;
				num4 = num2 + 2.0 * num50;
				num5 = num3;
				num18 = (ushort)(num + 1);
				num = num18;
				DrawLine(streamWriter, num18, text, num16 + num2, num17 + num3, num16 + num4, num17 + num5);
				num2 = num4;
				num3 = num5;
				num4 = num2;
				num5 = num3 - (num51 + num50);
				num18 = (ushort)(num + 1);
				num = num18;
				DrawLine(streamWriter, num18, text, num16 + num2, num17 + num3, num16 + num4, num17 + num5);
				num53 = num4;
				num54 = num5;
				double num59 = 34.0;
				num55 = num4 + 5.0;
				num56 += num5;
				int num60 = (int)Math.Floor(((double)(L - 10) - num55) / (num59 + num57));
				for (int j = 0; j < num60; j++)
				{
					num2 = num55 + (double)j * (num59 + num57);
					num3 = num56;
					num4 = num2;
					num5 = num3 + num58;
					num18 = (ushort)(num + 1);
					num = num18;
					DrawLine(streamWriter, num18, text, num16 + num2, num17 + num3, num16 + num4, num17 + num5);
					num2 = num4;
					num3 = num5;
					num4 = num2 + num57;
					num5 = num3;
					num18 = (ushort)(num + 1);
					num = num18;
					DrawLine(streamWriter, num18, text, num16 + num2, num17 + num3, num16 + num4, num17 + num5);
					num2 = num4;
					num3 = num5;
					num4 = num2;
					num5 = num3 - num58;
					num18 = (ushort)(num + 1);
					num = num18;
					DrawLine(streamWriter, num18, text, num16 + num2, num17 + num3, num16 + num4, num17 + num5);
					num2 = num4;
					num3 = num5;
					num4 = num2 - num57;
					num5 = num3;
					num18 = (ushort)(num + 1);
					num = num18;
					DrawLine(streamWriter, num18, text, num16 + num2, num17 + num3, num16 + num4, num17 + num5);
				}
				num2 = num53;
				num3 = num54;
				num4 = num2 + (double)L - 10.0 - (num52 + num50);
				num5 = num3;
				num18 = (ushort)(num + 1);
				num = num18;
				DrawLine(streamWriter, num18, text, num16 + num2, num17 + num3, num16 + num4, num17 + num5);
			}
			if (zhyrFiltr == "так" && G < B)
			{
				num45 = 9.5;
				num46 = 69.0;
				double num61 = 59.5;
				double num62 = 15.0;
				double num63 = 19.5;
				num16 = B + 500;
				num17 = -150.0;
				num2 = num62;
				num3 = 0.0;
				num4 = num2;
				num5 = num3 + num63;
				num18 = (ushort)(num + 1);
				num = num18;
				DrawLine(streamWriter, num18, text, num16 + num2, num17 + num3, num16 + num4, num17 + num5);
				num2 = num4;
				num3 = num5;
				num4 = num2 + num6;
				num5 = num3;
				num18 = (ushort)(num + 1);
				num = num18;
				DrawLine(streamWriter, num18, text, num16 + num2, num17 + num3, num16 + num4, num17 + num5);
				num2 = num4;
				num3 = num5;
				num4 = num2;
				num5 = num3 + num6;
				num18 = (ushort)(num + 1);
				num = num18;
				DrawLine(streamWriter, num18, text, num16 + num2, num17 + num3, num16 + num4, num17 + num5);
				num2 = num4;
				num3 = num5;
				num4 = num2 - num6 - num62;
				num5 = num3;
				num18 = (ushort)(num + 1);
				num = num18;
				DrawLine(streamWriter, num18, text, num16 + num2, num17 + num3, num16 + num4, num17 + num5);
				num2 = num4;
				num3 = num5;
				num4 = num2;
				num5 = num3 + num61;
				num18 = (ushort)(num + 1);
				num = num18;
				DrawLine(streamWriter, num18, text, num16 + num2, num17 + num3, num16 + num4, num17 + num5);
				num2 = num4;
				num3 = num5;
				num4 = num2 + num6;
				num5 = num3;
				num18 = (ushort)(num + 1);
				num = num18;
				DrawLine(streamWriter, num18, text, num16 + num2, num17 + num3, num16 + num4, num17 + num5);
				num2 = num4;
				num3 = num5;
				num4 = num2;
				num5 = num3 + num6;
				num18 = (ushort)(num + 1);
				num = num18;
				DrawLine(streamWriter, num18, text, num16 + num2, num17 + num3, num16 + num4, num17 + num5);
				num2 = num4;
				num3 = num5;
				num4 = num2 - num6;
				num5 = num3;
				num18 = (ushort)(num + 1);
				num = num18;
				DrawLine(streamWriter, num18, text, num16 + num2, num17 + num3, num16 + num4, num17 + num5);
				num2 = num4;
				num3 = num5;
				num4 = num2;
				num5 = num3 + num46;
				num18 = (ushort)(num + 1);
				num = num18;
				DrawLine(streamWriter, num18, text, num16 + num2, num17 + num3, num16 + num4, num17 + num5);
				num2 = num4;
				num3 = num5;
				num4 = num2 + num6;
				num5 = num3;
				num18 = (ushort)(num + 1);
				num = num18;
				DrawLine(streamWriter, num18, text, num16 + num2, num17 + num3, num16 + num4, num17 + num5);
				num2 = num4;
				num3 = num5;
				num4 = num2;
				num5 = num3 + num6;
				num18 = (ushort)(num + 1);
				num = num18;
				DrawLine(streamWriter, num18, text, num16 + num2, num17 + num3, num16 + num4, num17 + num5);
				num2 = num4;
				num3 = num5;
				num4 = num2 - num6;
				num5 = num3;
				num18 = (ushort)(num + 1);
				num = num18;
				DrawLine(streamWriter, num18, text, num16 + num2, num17 + num3, num16 + num4, num17 + num5);
				num2 = num4;
				num3 = num5;
				num4 = num2;
				num5 = num3 + num45;
				num18 = (ushort)(num + 1);
				num = num18;
				DrawLine(streamWriter, num18, text, num16 + num2, num17 + num3, num16 + num4, num17 + num5);
				num2 = num4;
				num3 = num5;
				num4 = num2 + (double)L - 5.0;
				num5 = num3;
				num18 = (ushort)(num + 1);
				num = num18;
				DrawLine(streamWriter, num18, text, num16 + num2, num17 + num3, num16 + num4, num17 + num5);
				num2 = num4;
				num3 = num5;
				num4 = num2;
				num5 = num3 - num45;
				num18 = (ushort)(num + 1);
				num = num18;
				DrawLine(streamWriter, num18, text, num16 + num2, num17 + num3, num16 + num4, num17 + num5);
				num2 = num4;
				num3 = num5;
				num4 = num2 - num6;
				num5 = num3;
				num18 = (ushort)(num + 1);
				num = num18;
				DrawLine(streamWriter, num18, text, num16 + num2, num17 + num3, num16 + num4, num17 + num5);
				num2 = num4;
				num3 = num5;
				num4 = num2;
				num5 = num3 - num6;
				num18 = (ushort)(num + 1);
				num = num18;
				DrawLine(streamWriter, num18, text, num16 + num2, num17 + num3, num16 + num4, num17 + num5);
				num2 = num4;
				num3 = num5;
				num4 = num2 + num6;
				num5 = num3;
				num18 = (ushort)(num + 1);
				num = num18;
				DrawLine(streamWriter, num18, text, num16 + num2, num17 + num3, num16 + num4, num17 + num5);
				num2 = num4;
				num3 = num5;
				num4 = num2;
				num5 = num3 - num46;
				num18 = (ushort)(num + 1);
				num = num18;
				DrawLine(streamWriter, num18, text, num16 + num2, num17 + num3, num16 + num4, num17 + num5);
				num2 = num4;
				num3 = num5;
				num4 = num2 - num6;
				num5 = num3;
				num18 = (ushort)(num + 1);
				num = num18;
				DrawLine(streamWriter, num18, text, num16 + num2, num17 + num3, num16 + num4, num17 + num5);
				num2 = num4;
				num3 = num5;
				num4 = num2;
				num5 = num3 - num6;
				num18 = (ushort)(num + 1);
				num = num18;
				DrawLine(streamWriter, num18, text, num16 + num2, num17 + num3, num16 + num4, num17 + num5);
				num2 = num4;
				num3 = num5;
				num4 = num2 + num6;
				num5 = num3;
				num18 = (ushort)(num + 1);
				num = num18;
				DrawLine(streamWriter, num18, text, num16 + num2, num17 + num3, num16 + num4, num17 + num5);
				num2 = num4;
				num3 = num5;
				num4 = num2;
				num5 = num3 - num61;
				num18 = (ushort)(num + 1);
				num = num18;
				DrawLine(streamWriter, num18, text, num16 + num2, num17 + num3, num16 + num4, num17 + num5);
				num2 = num4;
				num3 = num5;
				num4 = num2 - num62 - num6;
				num5 = num3;
				num18 = (ushort)(num + 1);
				num = num18;
				DrawLine(streamWriter, num18, text, num16 + num2, num17 + num3, num16 + num4, num17 + num5);
				num2 = num4;
				num3 = num5;
				num4 = num2;
				num5 = num3 - num6;
				num18 = (ushort)(num + 1);
				num = num18;
				DrawLine(streamWriter, num18, text, num16 + num2, num17 + num3, num16 + num4, num17 + num5);
				num2 = num4;
				num3 = num5;
				num4 = num2 + num6;
				num5 = num3;
				num18 = (ushort)(num + 1);
				num = num18;
				DrawLine(streamWriter, num18, text, num16 + num2, num17 + num3, num16 + num4, num17 + num5);
				num2 = num4;
				num3 = num5;
				num4 = num2;
				num5 = num3 - num63;
				num18 = (ushort)(num + 1);
				num = num18;
				DrawLine(streamWriter, num18, text, num16 + num2, num17 + num3, num16 + num4, num17 + num5);
				num2 = num4;
				num3 = num5;
				num4 = num2 - ((double)(L - 5) - 2.0 * num62);
				num5 = num3;
				num18 = (ushort)(num + 1);
				num = num18;
				DrawLine(streamWriter, num18, text, num16 + num2, num17 + num3, num16 + num4, num17 + num5);
				num = DrawZaklepka_1(streamWriter, num, text, connection, num4 - 2.5 - num62 + num16, num5 + num17, num2 + 2.5 + num62 + num16, num3 + num17, 0);
			}
			streamWriter.WriteLine("ENDSEC");
			streamWriter.WriteLine("0");
			streamWriter.WriteLine("SECTION");
			streamWriter.WriteLine("2");
			streamWriter.WriteLine("OBJECTS");
			streamWriter.WriteLine("0");
			streamWriter.WriteLine("DICTIONARY");
			streamWriter.WriteLine("5");
			streamWriter.WriteLine("C");
			streamWriter.WriteLine("330");
			streamWriter.WriteLine("0");
			streamWriter.WriteLine("100");
			streamWriter.WriteLine("AcDbDictionary");
			streamWriter.WriteLine("281");
			streamWriter.WriteLine("1");
			streamWriter.WriteLine("3");
			streamWriter.WriteLine("ACAD_GROUP");
			streamWriter.WriteLine("350");
			streamWriter.WriteLine("D");
			streamWriter.WriteLine("3");
			streamWriter.WriteLine("ACAD_LAYOUT");
			streamWriter.WriteLine("350");
			streamWriter.WriteLine("1A");
			streamWriter.WriteLine("3");
			streamWriter.WriteLine("ACAD_MLINESTYLE");
			streamWriter.WriteLine("350");
			streamWriter.WriteLine("17");
			streamWriter.WriteLine("3");
			streamWriter.WriteLine("ACAD_PLOTSETTINGS");
			streamWriter.WriteLine("350");
			streamWriter.WriteLine("19");
			streamWriter.WriteLine("3");
			streamWriter.WriteLine("ACAD_PLOTSTYLENAME");
			streamWriter.WriteLine("350");
			streamWriter.WriteLine("E");
			streamWriter.WriteLine("3");
			streamWriter.WriteLine("AcDbVariableDictionary");
			streamWriter.WriteLine("350");
			streamWriter.WriteLine("2B");
			streamWriter.WriteLine("0");
			streamWriter.WriteLine("DICTIONARY");
			streamWriter.WriteLine("5");
			streamWriter.WriteLine("D");
			streamWriter.WriteLine("102");
			streamWriter.WriteLine("{ACAD_REACTORS");
			streamWriter.WriteLine("330");
			streamWriter.WriteLine("C");
			streamWriter.WriteLine("102");
			streamWriter.WriteLine("}");
			streamWriter.WriteLine("330");
			streamWriter.WriteLine("C");
			streamWriter.WriteLine("100");
			streamWriter.WriteLine("AcDbDictionary");
			streamWriter.WriteLine("281");
			streamWriter.WriteLine("1");
			streamWriter.WriteLine("0");
			streamWriter.WriteLine("DICTIONARY");
			streamWriter.WriteLine("5");
			streamWriter.WriteLine("1A");
			streamWriter.WriteLine("102");
			streamWriter.WriteLine("{ACAD_REACTORS");
			streamWriter.WriteLine("330");
			streamWriter.WriteLine("C");
			streamWriter.WriteLine("102");
			streamWriter.WriteLine("}");
			streamWriter.WriteLine("330");
			streamWriter.WriteLine("C");
			streamWriter.WriteLine("100");
			streamWriter.WriteLine("AcDbDictionary");
			streamWriter.WriteLine("281");
			streamWriter.WriteLine("1");
			streamWriter.WriteLine("3");
			streamWriter.WriteLine("Layout1");
			streamWriter.WriteLine("350");
			streamWriter.WriteLine("1E");
			streamWriter.WriteLine("3");
			streamWriter.WriteLine("Layout2");
			streamWriter.WriteLine("350");
			streamWriter.WriteLine("26");
			streamWriter.WriteLine("3");
			streamWriter.WriteLine("Model");
			streamWriter.WriteLine("350");
			streamWriter.WriteLine("22");
			streamWriter.WriteLine("0");
			streamWriter.WriteLine("DICTIONARY");
			streamWriter.WriteLine("5");
			streamWriter.WriteLine("17");
			streamWriter.WriteLine("102");
			streamWriter.WriteLine("{ACAD_REACTORS");
			streamWriter.WriteLine("330");
			streamWriter.WriteLine("C");
			streamWriter.WriteLine("102");
			streamWriter.WriteLine("}");
			streamWriter.WriteLine("330");
			streamWriter.WriteLine("C");
			streamWriter.WriteLine("100");
			streamWriter.WriteLine("AcDbDictionary");
			streamWriter.WriteLine("281");
			streamWriter.WriteLine("1");
			streamWriter.WriteLine("3");
			streamWriter.WriteLine("Standard");
			streamWriter.WriteLine("350");
			streamWriter.WriteLine("18");
			streamWriter.WriteLine("0");
			streamWriter.WriteLine("DICTIONARY");
			streamWriter.WriteLine("5");
			streamWriter.WriteLine("19");
			streamWriter.WriteLine("102");
			streamWriter.WriteLine("{ACAD_REACTORS");
			streamWriter.WriteLine("330");
			streamWriter.WriteLine("C");
			streamWriter.WriteLine("102");
			streamWriter.WriteLine("}");
			streamWriter.WriteLine("330");
			streamWriter.WriteLine("C");
			streamWriter.WriteLine("100");
			streamWriter.WriteLine("AcDbDictionary");
			streamWriter.WriteLine("281");
			streamWriter.WriteLine("1");
			streamWriter.WriteLine("0");
			streamWriter.WriteLine("ACDBDICTIONARYWDFLT");
			streamWriter.WriteLine("5");
			streamWriter.WriteLine("E");
			streamWriter.WriteLine("102");
			streamWriter.WriteLine("{ACAD_REACTORS");
			streamWriter.WriteLine("330");
			streamWriter.WriteLine("C");
			streamWriter.WriteLine("102");
			streamWriter.WriteLine("}");
			streamWriter.WriteLine("330");
			streamWriter.WriteLine("C");
			streamWriter.WriteLine("100");
			streamWriter.WriteLine("AcDbDictionary");
			streamWriter.WriteLine("281");
			streamWriter.WriteLine("1");
			streamWriter.WriteLine("3");
			streamWriter.WriteLine("Normal");
			streamWriter.WriteLine("350");
			streamWriter.WriteLine("F");
			streamWriter.WriteLine("100");
			streamWriter.WriteLine("AcDbDictionaryWithDefault");
			streamWriter.WriteLine("340");
			streamWriter.WriteLine("F");
			streamWriter.WriteLine("0");
			streamWriter.WriteLine("DICTIONARY");
			streamWriter.WriteLine("5");
			streamWriter.WriteLine("2B");
			streamWriter.WriteLine("102");
			streamWriter.WriteLine("{ACAD_REACTORS");
			streamWriter.WriteLine("330");
			streamWriter.WriteLine("C");
			streamWriter.WriteLine("102");
			streamWriter.WriteLine("}");
			streamWriter.WriteLine("330");
			streamWriter.WriteLine("C");
			streamWriter.WriteLine("100");
			streamWriter.WriteLine("AcDbDictionary");
			streamWriter.WriteLine("281");
			streamWriter.WriteLine("1");
			streamWriter.WriteLine("3");
			streamWriter.WriteLine("DIMASSOC");
			streamWriter.WriteLine("350");
			streamWriter.WriteLine("2D");
			streamWriter.WriteLine("3");
			streamWriter.WriteLine("HIDETEXT");
			streamWriter.WriteLine("350");
			streamWriter.WriteLine("2C");
			streamWriter.WriteLine("0");
			streamWriter.WriteLine("LAYOUT");
			streamWriter.WriteLine("5");
			streamWriter.WriteLine("1E");
			streamWriter.WriteLine("102");
			streamWriter.WriteLine("{ACAD_REACTORS");
			streamWriter.WriteLine("330");
			streamWriter.WriteLine("1A");
			streamWriter.WriteLine("102");
			streamWriter.WriteLine("}");
			streamWriter.WriteLine("330");
			streamWriter.WriteLine("1A");
			streamWriter.WriteLine("100");
			streamWriter.WriteLine("AcDbPlotSettings");
			streamWriter.WriteLine("1");
			streamWriter.WriteLine("");
			streamWriter.WriteLine("2");
			streamWriter.WriteLine("Microsoft Office Document Image Writer");
			streamWriter.WriteLine("4");
			streamWriter.WriteLine("");
			streamWriter.WriteLine("6");
			streamWriter.WriteLine("");
			streamWriter.WriteLine("40");
			streamWriter.WriteLine("0");
			streamWriter.WriteLine("41");
			streamWriter.WriteLine("0");
			streamWriter.WriteLine("42");
			streamWriter.WriteLine("0");
			streamWriter.WriteLine("43");
			streamWriter.WriteLine("0");
			streamWriter.WriteLine("44");
			streamWriter.WriteLine("0");
			streamWriter.WriteLine("45");
			streamWriter.WriteLine("0");
			streamWriter.WriteLine("46");
			streamWriter.WriteLine("0");
			streamWriter.WriteLine("47");
			streamWriter.WriteLine("0");
			streamWriter.WriteLine("48");
			streamWriter.WriteLine("0");
			streamWriter.WriteLine("49");
			streamWriter.WriteLine("0");
			streamWriter.WriteLine("140");
			streamWriter.WriteLine("0");
			streamWriter.WriteLine("141");
			streamWriter.WriteLine("0");
			streamWriter.WriteLine("142");
			streamWriter.WriteLine("1");
			streamWriter.WriteLine("143");
			streamWriter.WriteLine("1");
			streamWriter.WriteLine("70");
			streamWriter.WriteLine("688");
			streamWriter.WriteLine("72");
			streamWriter.WriteLine("0");
			streamWriter.WriteLine("73");
			streamWriter.WriteLine("0");
			streamWriter.WriteLine("74");
			streamWriter.WriteLine("5");
			streamWriter.WriteLine("7");
			streamWriter.WriteLine("");
			streamWriter.WriteLine("75");
			streamWriter.WriteLine("16");
			streamWriter.WriteLine("147");
			streamWriter.WriteLine("1");
			streamWriter.WriteLine("148");
			streamWriter.WriteLine("0");
			streamWriter.WriteLine("149");
			streamWriter.WriteLine("0");
			streamWriter.WriteLine("100");
			streamWriter.WriteLine("AcDbLayout");
			streamWriter.WriteLine("1");
			streamWriter.WriteLine("Layout1");
			streamWriter.WriteLine("70");
			streamWriter.WriteLine("1");
			streamWriter.WriteLine("71");
			streamWriter.WriteLine("1");
			streamWriter.WriteLine("10");
			streamWriter.WriteLine("0");
			streamWriter.WriteLine("20");
			streamWriter.WriteLine("0");
			streamWriter.WriteLine("11");
			streamWriter.WriteLine("420");
			streamWriter.WriteLine("21");
			streamWriter.WriteLine("297");
			streamWriter.WriteLine("12");
			streamWriter.WriteLine("0");
			streamWriter.WriteLine("22");
			streamWriter.WriteLine("0");
			streamWriter.WriteLine("32");
			streamWriter.WriteLine("0");
			streamWriter.WriteLine("14");
			streamWriter.WriteLine("1E+20");
			streamWriter.WriteLine("24");
			streamWriter.WriteLine("1E+20");
			streamWriter.WriteLine("34");
			streamWriter.WriteLine("1E+20");
			streamWriter.WriteLine("15");
			streamWriter.WriteLine("-1E+20");
			streamWriter.WriteLine("25");
			streamWriter.WriteLine("-1E+20");
			streamWriter.WriteLine("35");
			streamWriter.WriteLine("-1E+20");
			streamWriter.WriteLine("146");
			streamWriter.WriteLine("0");
			streamWriter.WriteLine("13");
			streamWriter.WriteLine("0");
			streamWriter.WriteLine("23");
			streamWriter.WriteLine("0");
			streamWriter.WriteLine("33");
			streamWriter.WriteLine("0");
			streamWriter.WriteLine("16");
			streamWriter.WriteLine("1");
			streamWriter.WriteLine("26");
			streamWriter.WriteLine("0");
			streamWriter.WriteLine("36");
			streamWriter.WriteLine("0");
			streamWriter.WriteLine("17");
			streamWriter.WriteLine("0");
			streamWriter.WriteLine("27");
			streamWriter.WriteLine("1");
			streamWriter.WriteLine("37");
			streamWriter.WriteLine("0");
			streamWriter.WriteLine("76");
			streamWriter.WriteLine("0");
			streamWriter.WriteLine("330");
			streamWriter.WriteLine("1B");
			streamWriter.WriteLine("0");
			streamWriter.WriteLine("LAYOUT");
			streamWriter.WriteLine("5");
			streamWriter.WriteLine("26");
			streamWriter.WriteLine("102");
			streamWriter.WriteLine("{ACAD_REACTORS");
			streamWriter.WriteLine("330");
			streamWriter.WriteLine("1A");
			streamWriter.WriteLine("102");
			streamWriter.WriteLine("}");
			streamWriter.WriteLine("330");
			streamWriter.WriteLine("1A");
			streamWriter.WriteLine("100");
			streamWriter.WriteLine("AcDbPlotSettings");
			streamWriter.WriteLine("1");
			streamWriter.WriteLine("");
			streamWriter.WriteLine("2");
			streamWriter.WriteLine("Microsoft Office Document Image Writer");
			streamWriter.WriteLine("4");
			streamWriter.WriteLine("");
			streamWriter.WriteLine("6");
			streamWriter.WriteLine("");
			streamWriter.WriteLine("40");
			streamWriter.WriteLine("0");
			streamWriter.WriteLine("41");
			streamWriter.WriteLine("0");
			streamWriter.WriteLine("42");
			streamWriter.WriteLine("0");
			streamWriter.WriteLine("43");
			streamWriter.WriteLine("0");
			streamWriter.WriteLine("44");
			streamWriter.WriteLine("0");
			streamWriter.WriteLine("45");
			streamWriter.WriteLine("0");
			streamWriter.WriteLine("46");
			streamWriter.WriteLine("0");
			streamWriter.WriteLine("47");
			streamWriter.WriteLine("0");
			streamWriter.WriteLine("48");
			streamWriter.WriteLine("0");
			streamWriter.WriteLine("49");
			streamWriter.WriteLine("0");
			streamWriter.WriteLine("140");
			streamWriter.WriteLine("0");
			streamWriter.WriteLine("141");
			streamWriter.WriteLine("0");
			streamWriter.WriteLine("142");
			streamWriter.WriteLine("1");
			streamWriter.WriteLine("143");
			streamWriter.WriteLine("1");
			streamWriter.WriteLine("70");
			streamWriter.WriteLine("688");
			streamWriter.WriteLine("72");
			streamWriter.WriteLine("0");
			streamWriter.WriteLine("73");
			streamWriter.WriteLine("0");
			streamWriter.WriteLine("74");
			streamWriter.WriteLine("5");
			streamWriter.WriteLine("7");
			streamWriter.WriteLine("");
			streamWriter.WriteLine("75");
			streamWriter.WriteLine("16");
			streamWriter.WriteLine("147");
			streamWriter.WriteLine("1");
			streamWriter.WriteLine("148");
			streamWriter.WriteLine("0");
			streamWriter.WriteLine("149");
			streamWriter.WriteLine("0");
			streamWriter.WriteLine("100");
			streamWriter.WriteLine("AcDbLayout");
			streamWriter.WriteLine("1");
			streamWriter.WriteLine("Layout2");
			streamWriter.WriteLine("70");
			streamWriter.WriteLine("1");
			streamWriter.WriteLine("71");
			streamWriter.WriteLine("2");
			streamWriter.WriteLine("10");
			streamWriter.WriteLine("0");
			streamWriter.WriteLine("20");
			streamWriter.WriteLine("0");
			streamWriter.WriteLine("11");
			streamWriter.WriteLine("12");
			streamWriter.WriteLine("21");
			streamWriter.WriteLine("9");
			streamWriter.WriteLine("12");
			streamWriter.WriteLine("0");
			streamWriter.WriteLine("22");
			streamWriter.WriteLine("0");
			streamWriter.WriteLine("32");
			streamWriter.WriteLine("0");
			streamWriter.WriteLine("14");
			streamWriter.WriteLine("0");
			streamWriter.WriteLine("24");
			streamWriter.WriteLine("0");
			streamWriter.WriteLine("34");
			streamWriter.WriteLine("0");
			streamWriter.WriteLine("15");
			streamWriter.WriteLine("0");
			streamWriter.WriteLine("25");
			streamWriter.WriteLine("0");
			streamWriter.WriteLine("35");
			streamWriter.WriteLine("0");
			streamWriter.WriteLine("146");
			streamWriter.WriteLine("0");
			streamWriter.WriteLine("13");
			streamWriter.WriteLine("0");
			streamWriter.WriteLine("23");
			streamWriter.WriteLine("0");
			streamWriter.WriteLine("33");
			streamWriter.WriteLine("0");
			streamWriter.WriteLine("16");
			streamWriter.WriteLine("1");
			streamWriter.WriteLine("26");
			streamWriter.WriteLine("0");
			streamWriter.WriteLine("36");
			streamWriter.WriteLine("0");
			streamWriter.WriteLine("17");
			streamWriter.WriteLine("0");
			streamWriter.WriteLine("27");
			streamWriter.WriteLine("1");
			streamWriter.WriteLine("37");
			streamWriter.WriteLine("0");
			streamWriter.WriteLine("76");
			streamWriter.WriteLine("0");
			streamWriter.WriteLine("330");
			streamWriter.WriteLine("23");
			streamWriter.WriteLine("0");
			streamWriter.WriteLine("LAYOUT");
			streamWriter.WriteLine("5");
			streamWriter.WriteLine("22");
			streamWriter.WriteLine("102");
			streamWriter.WriteLine("{ACAD_REACTORS");
			streamWriter.WriteLine("330");
			streamWriter.WriteLine("1A");
			streamWriter.WriteLine("102");
			streamWriter.WriteLine("}");
			streamWriter.WriteLine("330");
			streamWriter.WriteLine("1A");
			streamWriter.WriteLine("100");
			streamWriter.WriteLine("AcDbPlotSettings");
			streamWriter.WriteLine("1");
			streamWriter.WriteLine("");
			streamWriter.WriteLine("2");
			streamWriter.WriteLine("Microsoft Office Document Image Writer");
			streamWriter.WriteLine("4");
			streamWriter.WriteLine("");
			streamWriter.WriteLine("6");
			streamWriter.WriteLine("");
			streamWriter.WriteLine("40");
			streamWriter.WriteLine("0");
			streamWriter.WriteLine("41");
			streamWriter.WriteLine("0");
			streamWriter.WriteLine("42");
			streamWriter.WriteLine("0");
			streamWriter.WriteLine("43");
			streamWriter.WriteLine("0");
			streamWriter.WriteLine("44");
			streamWriter.WriteLine("0");
			streamWriter.WriteLine("45");
			streamWriter.WriteLine("0");
			streamWriter.WriteLine("46");
			streamWriter.WriteLine("0");
			streamWriter.WriteLine("47");
			streamWriter.WriteLine("0");
			streamWriter.WriteLine("48");
			streamWriter.WriteLine("0");
			streamWriter.WriteLine("49");
			streamWriter.WriteLine("0");
			streamWriter.WriteLine("140");
			streamWriter.WriteLine("0");
			streamWriter.WriteLine("141");
			streamWriter.WriteLine("0");
			streamWriter.WriteLine("142");
			streamWriter.WriteLine("1");
			streamWriter.WriteLine("143");
			streamWriter.WriteLine("1");
			streamWriter.WriteLine("70");
			streamWriter.WriteLine("1712");
			streamWriter.WriteLine("72");
			streamWriter.WriteLine("0");
			streamWriter.WriteLine("73");
			streamWriter.WriteLine("0");
			streamWriter.WriteLine("74");
			streamWriter.WriteLine("0");
			streamWriter.WriteLine("7");
			streamWriter.WriteLine("");
			streamWriter.WriteLine("75");
			streamWriter.WriteLine("0");
			streamWriter.WriteLine("147");
			streamWriter.WriteLine("1");
			streamWriter.WriteLine("148");
			streamWriter.WriteLine("0");
			streamWriter.WriteLine("149");
			streamWriter.WriteLine("0");
			streamWriter.WriteLine("100");
			streamWriter.WriteLine("AcDbLayout");
			streamWriter.WriteLine("1");
			streamWriter.WriteLine("Model");
			streamWriter.WriteLine("70");
			streamWriter.WriteLine("1");
			streamWriter.WriteLine("71");
			streamWriter.WriteLine("0");
			streamWriter.WriteLine("10");
			streamWriter.WriteLine("0");
			streamWriter.WriteLine("20");
			streamWriter.WriteLine("0");
			streamWriter.WriteLine("11");
			streamWriter.WriteLine("12");
			streamWriter.WriteLine("21");
			streamWriter.WriteLine("9");
			streamWriter.WriteLine("12");
			streamWriter.WriteLine("0");
			streamWriter.WriteLine("22");
			streamWriter.WriteLine("0");
			streamWriter.WriteLine("32");
			streamWriter.WriteLine("0");
			streamWriter.WriteLine("14");
			streamWriter.WriteLine("0");
			streamWriter.WriteLine("24");
			streamWriter.WriteLine("0");
			streamWriter.WriteLine("34");
			streamWriter.WriteLine("0");
			streamWriter.WriteLine("15");
			streamWriter.WriteLine("0");
			streamWriter.WriteLine("25");
			streamWriter.WriteLine("0");
			streamWriter.WriteLine("35");
			streamWriter.WriteLine("0");
			streamWriter.WriteLine("146");
			streamWriter.WriteLine("0");
			streamWriter.WriteLine("13");
			streamWriter.WriteLine("0");
			streamWriter.WriteLine("23");
			streamWriter.WriteLine("0");
			streamWriter.WriteLine("33");
			streamWriter.WriteLine("0");
			streamWriter.WriteLine("16");
			streamWriter.WriteLine("1");
			streamWriter.WriteLine("26");
			streamWriter.WriteLine("0");
			streamWriter.WriteLine("36");
			streamWriter.WriteLine("0");
			streamWriter.WriteLine("17");
			streamWriter.WriteLine("0");
			streamWriter.WriteLine("27");
			streamWriter.WriteLine("1");
			streamWriter.WriteLine("37");
			streamWriter.WriteLine("0");
			streamWriter.WriteLine("76");
			streamWriter.WriteLine("0");
			streamWriter.WriteLine("330");
			streamWriter.WriteLine("1F");
			streamWriter.WriteLine("0");
			streamWriter.WriteLine("MLINESTYLE");
			streamWriter.WriteLine("5");
			streamWriter.WriteLine("18");
			streamWriter.WriteLine("102");
			streamWriter.WriteLine("{ACAD_REACTORS");
			streamWriter.WriteLine("330");
			streamWriter.WriteLine("17");
			streamWriter.WriteLine("102");
			streamWriter.WriteLine("}");
			streamWriter.WriteLine("330");
			streamWriter.WriteLine("17");
			streamWriter.WriteLine("100");
			streamWriter.WriteLine("AcDbMlineStyle");
			streamWriter.WriteLine("2");
			streamWriter.WriteLine("STANDARD");
			streamWriter.WriteLine("70");
			streamWriter.WriteLine("0");
			streamWriter.WriteLine("3");
			streamWriter.WriteLine("");
			streamWriter.WriteLine("62");
			streamWriter.WriteLine("256");
			streamWriter.WriteLine("51");
			streamWriter.WriteLine("90");
			streamWriter.WriteLine("52");
			streamWriter.WriteLine("90");
			streamWriter.WriteLine("71");
			streamWriter.WriteLine("2");
			streamWriter.WriteLine("49");
			streamWriter.WriteLine("0.5");
			streamWriter.WriteLine("62");
			streamWriter.WriteLine("256");
			streamWriter.WriteLine("6");
			streamWriter.WriteLine("BYLAYER");
			streamWriter.WriteLine("49");
			streamWriter.WriteLine("-0.5");
			streamWriter.WriteLine("62");
			streamWriter.WriteLine("256");
			streamWriter.WriteLine("6");
			streamWriter.WriteLine("BYLAYER");
			streamWriter.WriteLine("0");
			streamWriter.WriteLine("ACDBPLACEHOLDER");
			streamWriter.WriteLine("5");
			streamWriter.WriteLine("F");
			streamWriter.WriteLine("102");
			streamWriter.WriteLine("{ACAD_REACTORS");
			streamWriter.WriteLine("330");
			streamWriter.WriteLine("E");
			streamWriter.WriteLine("102");
			streamWriter.WriteLine("}");
			streamWriter.WriteLine("330");
			streamWriter.WriteLine("E");
			streamWriter.WriteLine("0");
			streamWriter.WriteLine("DICTIONARYVAR");
			streamWriter.WriteLine("5");
			streamWriter.WriteLine("2D");
			streamWriter.WriteLine("102");
			streamWriter.WriteLine("{ACAD_REACTORS");
			streamWriter.WriteLine("330");
			streamWriter.WriteLine("2B");
			streamWriter.WriteLine("102");
			streamWriter.WriteLine("}");
			streamWriter.WriteLine("330");
			streamWriter.WriteLine("2B");
			streamWriter.WriteLine("100");
			streamWriter.WriteLine("DictionaryVariables");
			streamWriter.WriteLine("280");
			streamWriter.WriteLine("0");
			streamWriter.WriteLine("1");
			streamWriter.WriteLine("2");
			streamWriter.WriteLine("0");
			streamWriter.WriteLine("DICTIONARYVAR");
			streamWriter.WriteLine("5");
			streamWriter.WriteLine("2C");
			streamWriter.WriteLine("102");
			streamWriter.WriteLine("{ACAD_REACTORS");
			streamWriter.WriteLine("330");
			streamWriter.WriteLine("2B");
			streamWriter.WriteLine("102");
			streamWriter.WriteLine("}");
			streamWriter.WriteLine("330");
			streamWriter.WriteLine("2B");
			streamWriter.WriteLine("100");
			streamWriter.WriteLine("DictionaryVariables");
			streamWriter.WriteLine("280");
			streamWriter.WriteLine("0");
			streamWriter.WriteLine("1");
			streamWriter.WriteLine("1");
			streamWriter.WriteLine("0");
			streamWriter.WriteLine("ENDSEC");
			streamWriter.WriteLine("0");
			streamWriter.WriteLine("EOF");
			streamWriter.Close();
		}
		catch (IOException ex)
		{
			Console.WriteLine("An IO exception has been thrown!");
			Console.WriteLine(ex.ToString());
			Console.ReadLine();
		}
	}

	public static void DrawLine(StreamWriter sw, int ii, string LayerName, double p1, double p2, double p3, double p4)
	{
		string numberDecimalSeparator = NumberFormatInfo.CurrentInfo.NumberDecimalSeparator;
		sw.WriteLine("LINE");
		sw.WriteLine("5");
		string value = Convert.ToString(ii);
		sw.WriteLine(value);
		sw.WriteLine("330");
		sw.WriteLine("1F");
		sw.WriteLine("100");
		sw.WriteLine("AcDbEntity");
		sw.WriteLine("8");
		sw.WriteLine(LayerName);
		sw.WriteLine("100");
		sw.WriteLine("AcDbLine");
		sw.WriteLine("10");
		value = Convert.ToString(p1);
		if (numberDecimalSeparator == ",")
		{
			value = value.Replace(",", ".");
		}
		sw.WriteLine(value);
		sw.WriteLine("20");
		value = Convert.ToString(p2);
		if (numberDecimalSeparator == ",")
		{
			value = value.Replace(",", ".");
		}
		sw.WriteLine(value);
		sw.WriteLine("30");
		sw.WriteLine("0");
		sw.WriteLine("11");
		value = Convert.ToString(p3);
		if (numberDecimalSeparator == ",")
		{
			value = value.Replace(",", ".");
		}
		sw.WriteLine(value);
		sw.WriteLine("21");
		value = Convert.ToString(p4);
		if (numberDecimalSeparator == ",")
		{
			value = value.Replace(",", ".");
		}
		sw.WriteLine(value);
		sw.WriteLine("31");
		sw.WriteLine("0");
		sw.WriteLine("0");
	}

	public static void DrawCircle(StreamWriter sw, int ii, string LayerName, double p1, double p2, double d)
	{
		string numberDecimalSeparator = NumberFormatInfo.CurrentInfo.NumberDecimalSeparator;
		sw.WriteLine("CIRCLE");
		sw.WriteLine("5");
		string value = Convert.ToString(ii);
		sw.WriteLine(value);
		sw.WriteLine("330");
		sw.WriteLine("6B");
		sw.WriteLine("100");
		sw.WriteLine("AcDbEntity");
		sw.WriteLine("8");
		sw.WriteLine(LayerName);
		sw.WriteLine("6");
		sw.WriteLine("Continuous");
		sw.WriteLine("100");
		sw.WriteLine("AcDbCircle");
		sw.WriteLine("10");
		value = Convert.ToString(p1);
		if (numberDecimalSeparator == ",")
		{
			value = value.Replace(",", ".");
		}
		sw.WriteLine(value);
		sw.WriteLine("20");
		value = Convert.ToString(p2);
		if (numberDecimalSeparator == ",")
		{
			value = value.Replace(",", ".");
		}
		sw.WriteLine(value);
		sw.WriteLine("30");
		sw.WriteLine("0");
		sw.WriteLine("40");
		value = Convert.ToString(d);
		if (numberDecimalSeparator == ",")
		{
			value = value.Replace(",", ".");
		}
		sw.WriteLine(value);
		sw.WriteLine("0");
	}

	public static ushort DrawZaklepka(StreamWriter sw, ushort ii, string Layer_Name, string connection, double x1, double y1, double x2, double y2, byte leftRight)
	{
		if (connection == "заклепка")
		{
			double num = 8.0;
			double num2 = 7.0;
			double num3 = 50.0;
			double num4 = Math.Sqrt(Math.Pow(x2 - x1, 2.0) + Math.Pow(y2 - y1, 2.0)) - 2.0 * num2;
			int num5 = (int)Math.Round(num4 / num3);
			double num6 = ((y1 == y2) ? 0.0 : Math.Atan((y2 - y1) / (x2 - x1)));
			double d = 2.65;
			num3 = num4 / (double)num5;
			num5++;
			double num7 = x1 + num2 * Math.Cos(num6);
			num7 += ((leftRight == 0) ? ((0.0 - num) * Math.Sin(num6)) : (num * Math.Sin(num6)));
			double num8 = y1 + num2 * Math.Sin(num6);
			num8 += ((leftRight == 0) ? (num * Math.Cos(num6)) : ((0.0 - num) * Math.Cos(num6)));
			for (int i = 0; i < num5; i++)
			{
				DrawCircle(sw, ++ii, Layer_Name, num7, num8, d);
				num7 += num3 * Math.Cos(num6);
				num8 += num3 * Math.Sin(num6);
			}
		}
		return ii;
	}

	public static ushort DrawZaklepka_3(StreamWriter sw, ushort ii, string Layer_Name, string connection, double x1, double y1, double x2, double y2, byte leftRight)
	{
		if (connection == "заклепка")
		{
			double num = 8.0;
			double num2 = 22.0;
			double num3 = 50.0;
			double num4 = Math.Sqrt(Math.Pow(x2 - x1, 2.0) + Math.Pow(y2 - y1, 2.0)) - 2.0 * num2;
			int num5 = (int)Math.Round(num4 / num3);
			double num6 = ((y1 == y2) ? 0.0 : Math.Atan((y2 - y1) / (x2 - x1)));
			double d = 2.65;
			num3 = num4 / (double)num5;
			num5++;
			double num7 = x1 + num2 * Math.Cos(num6);
			num7 += ((leftRight == 0) ? ((0.0 - num) * Math.Sin(num6)) : (num * Math.Sin(num6)));
			double num8 = y1 + num2 * Math.Sin(num6);
			num8 += ((leftRight == 0) ? (num * Math.Cos(num6)) : ((0.0 - num) * Math.Cos(num6)));
			for (int i = 0; i < num5; i++)
			{
				DrawCircle(sw, ++ii, Layer_Name, num7, num8, d);
				num7 += num3 * Math.Cos(num6);
				num8 += num3 * Math.Sin(num6);
			}
		}
		return ii;
	}

	public static ushort DrawZaklepka_2(StreamWriter sw, ushort ii, string Layer_Name, string connection, double x1, double y1, double x2, double y2, byte leftRight)
	{
		if (connection == "заклепка")
		{
			double num = 10.0;
			double num2 = 16.5;
			double num3 = 79.0;
			double num4 = Math.Sqrt(Math.Pow(x2 - x1, 2.0) + Math.Pow(y2 - y1, 2.0)) - 2.0 * num2;
			int num5 = (int)Math.Round(num4 / num3);
			double num6 = ((y1 == y2) ? 0.0 : Math.Atan((y2 - y1) / (x2 - x1)));
			double d = 2.65;
			num3 = num4 / (double)num5;
			num5++;
			double num7 = x1 + num2 * Math.Cos(num6);
			num7 += ((leftRight == 0) ? ((0.0 - num) * Math.Sin(num6)) : (num * Math.Sin(num6)));
			double num8 = y1 + num2 * Math.Sin(num6);
			num8 += ((leftRight == 0) ? (num * Math.Cos(num6)) : ((0.0 - num) * Math.Cos(num6)));
			for (int i = 0; i < num5; i++)
			{
				DrawCircle(sw, ++ii, Layer_Name, num7, num8, d);
				num7 += num3 * Math.Cos(num6);
				num8 += num3 * Math.Sin(num6);
			}
		}
		return ii;
	}

	public static ushort DrawZaklepka_1(StreamWriter sw, ushort ii, string Layer_Name, string connection, double x1, double y1, double x2, double y2, byte leftRight)
	{
		double num = 10.0;
		double num2 = 50.0;
		double num3 = 220.0;
		double num4 = Math.Sqrt(Math.Pow(x2 - x1, 2.0) + Math.Pow(y2 - y1, 2.0)) - 2.0 * num2;
		int num5 = (int)Math.Round(num4 / num3);
		double num6 = ((y1 == y2) ? 0.0 : Math.Atan((y2 - y1) / (x2 - x1)));
		double d = 2.65;
		num3 = num4 / (double)num5;
		num5++;
		double num7 = x1 + num2 * Math.Cos(num6);
		num7 += ((leftRight == 0) ? ((0.0 - num) * Math.Sin(num6)) : (num * Math.Sin(num6)));
		double num8 = y1 + num2 * Math.Sin(num6);
		num8 += ((leftRight == 0) ? (num * Math.Cos(num6)) : ((0.0 - num) * Math.Cos(num6)));
		for (int i = 0; i < num5; i++)
		{
			DrawCircle(sw, ++ii, Layer_Name, num7, num8, d);
			num7 += num3 * Math.Cos(num6);
			num8 += num3 * Math.Sin(num6);
		}
		return ii;
	}

	public static ushort DrawZaklepka_4(StreamWriter sw, ushort ii, string Layer_Name, string connection, double x1, double y1, double x2, double y2, byte leftRight)
	{
		if (connection == "заклепка")
		{
			double num = 10.0;
			double num2 = 16.5;
			double num3 = 29.0;
			double num4 = Math.Sqrt(Math.Pow(x2 - x1, 2.0) + Math.Pow(y2 - y1, 2.0)) - 2.0 * num2;
			int num5 = (int)Math.Round(num4 / num3);
			double num6 = ((y1 == y2) ? 0.0 : Math.Atan((y2 - y1) / (x2 - x1)));
			double d = 2.65;
			num3 = num4 / (double)num5;
			num5++;
			double num7 = x1 + num2 * Math.Cos(num6);
			num7 += ((leftRight == 0) ? ((0.0 - num) * Math.Sin(num6)) : (num * Math.Sin(num6)));
			double num8 = y1 + num2 * Math.Sin(num6);
			num8 += ((leftRight == 0) ? (num * Math.Cos(num6)) : ((0.0 - num) * Math.Cos(num6)));
			for (int i = 0; i < num5; i++)
			{
				DrawCircle(sw, ++ii, Layer_Name, num7, num8, d);
				num7 += num3 * Math.Cos(num6);
				num8 += num3 * Math.Sin(num6);
			}
		}
		return ii;
	}

	public static ushort DrawZaklepka_Top(StreamWriter sw, ushort ii, string Layer_Name, string connection, double x1, double y1, double x2, double y2, byte leftRight)
	{
		if (connection == "заклепка")
		{
			double num = 7.0;
			double num2 = 22.0;
			double num3 = 50.0;
			double num4 = Math.Sqrt(Math.Pow(x2 - x1, 2.0) + Math.Pow(y2 - y1, 2.0)) - 2.0 * num2;
			int num5 = (int)Math.Round(num4 / num3);
			double num6 = ((y1 == y2) ? 0.0 : Math.Atan((y2 - y1) / (x2 - x1)));
			double d = 2.65;
			num3 = num4 / (double)num5;
			num5++;
			double num7 = x1 + num2 * Math.Cos(num6);
			num7 += ((leftRight == 0) ? ((0.0 - num) * Math.Sin(num6)) : (num * Math.Sin(num6)));
			double num8 = y1 + num2 * Math.Sin(num6);
			num8 += ((leftRight == 0) ? (num * Math.Cos(num6)) : ((0.0 - num) * Math.Cos(num6)));
			for (int i = 0; i < num5; i++)
			{
				DrawCircle(sw, ++ii, Layer_Name, num7, num8, d);
				num7 += num3 * Math.Cos(num6);
				num8 += num3 * Math.Sin(num6);
			}
		}
		return ii;
	}

	public static ushort DrawZaklepka_Top_1(StreamWriter sw, ushort ii, string Layer_Name, string connection, double x1, double y1, double x2, double y2, byte leftRight, double zaklepkaOffsetX)
	{
		double num = ((connection == "заклепка") ? 50.0 : 47.5);
		double num2 = 220.0;
		double num3 = Math.Sqrt(Math.Pow(x2 - x1, 2.0) + Math.Pow(y2 - y1, 2.0)) - 2.0 * num;
		int num4 = (int)Math.Round(num3 / num2);
		double num5 = ((y1 == y2) ? 0.0 : Math.Atan((y2 - y1) / (x2 - x1)));
		double d = 2.65;
		num2 = num3 / (double)num4;
		num4++;
		double num6 = x1 + num * Math.Cos(num5);
		num6 += ((leftRight == 0) ? ((0.0 - zaklepkaOffsetX) * Math.Sin(num5)) : (zaklepkaOffsetX * Math.Sin(num5)));
		double num7 = y1 + num * Math.Sin(num5);
		num7 += ((leftRight == 0) ? (zaklepkaOffsetX * Math.Cos(num5)) : ((0.0 - zaklepkaOffsetX) * Math.Cos(num5)));
		for (int i = 0; i < num4; i++)
		{
			DrawCircle(sw, ++ii, Layer_Name, num6, num7, d);
			num6 += num2 * Math.Cos(num5);
			num7 += num2 * Math.Sin(num5);
		}
		return ii;
	}

	public static ushort DrawZaklepka_Planka1(StreamWriter sw, ushort ii, string Layer_Name, string connection, double x1, double y1, double x2, double y2, byte leftRight)
	{
		if (connection == "заклепка")
		{
			double num = 8.5;
			double num2 = 22.0;
			double num3 = 79.0;
			double num4 = Math.Sqrt(Math.Pow(x2 - x1, 2.0) + Math.Pow(y2 - y1, 2.0)) - 2.0 * num2;
			int num5 = (int)Math.Round(num4 / num3);
			double num6 = ((y1 == y2) ? 0.0 : Math.Atan((y2 - y1) / (x2 - x1)));
			double d = 2.65;
			num3 = num4 / (double)num5;
			num5++;
			double num7 = x1 + num2 * Math.Cos(num6);
			num7 += ((leftRight == 0) ? ((0.0 - num) * Math.Sin(num6)) : (num * Math.Sin(num6)));
			double num8 = y1 + num2 * Math.Sin(num6);
			num8 += ((leftRight == 0) ? (num * Math.Cos(num6)) : ((0.0 - num) * Math.Cos(num6)));
			for (int i = 0; i < num5; i++)
			{
				DrawCircle(sw, ++ii, Layer_Name, num7, num8, d);
				num7 += num3 * Math.Cos(num6);
				num8 += num3 * Math.Sin(num6);
			}
		}
		return ii;
	}

	public static ushort DrawZaklepka_Planka2(StreamWriter sw, ushort ii, string Layer_Name, string connection, double x1, double y1, double x2, double y2, byte leftRight)
	{
		if (connection == "заклепка")
		{
			double num = 8.5;
			double num2 = 15.0;
			double num3 = 29.0;
			double num4 = Math.Sqrt(Math.Pow(x2 - x1, 2.0) + Math.Pow(y2 - y1, 2.0)) - 2.0 * num2;
			int num5 = (int)Math.Round(num4 / num3);
			double num6 = ((y1 == y2) ? 0.0 : Math.Atan((y2 - y1) / (x2 - x1)));
			double d = 2.65;
			num3 = num4 / (double)num5;
			num5++;
			double num7 = x1 + num2 * Math.Cos(num6);
			num7 += ((leftRight == 0) ? ((0.0 - num) * Math.Sin(num6)) : (num * Math.Sin(num6)));
			double num8 = y1 + num2 * Math.Sin(num6);
			num8 += ((leftRight == 0) ? (num * Math.Cos(num6)) : ((0.0 - num) * Math.Cos(num6)));
			for (int i = 0; i < num5; i++)
			{
				DrawCircle(sw, ++ii, Layer_Name, num7, num8, d);
				num7 += num3 * Math.Cos(num6);
				num8 += num3 * Math.Sin(num6);
			}
		}
		return ii;
	}

	public static void ZontOstrivnyyTyp2DrawImage(int L, int B, int H, int h, int number, string zontMaterial, string tovchynaMetaluZont, string connection, string zlyv, string fastening, string typeFastening, string vyhid, string vyhid1, int d1, int a1, int b1, int p1, int f1, int g1, string typVyhid1, string profilType1, string vyhid2, int d2, int a2, int b2, int p2, int f2, int g2, string typVyhid2, string profilType2, string vyhid3, int d3, int a3, int b3, int p3, int f3, int g3, string typVyhid3, string profilType3, string zhyrFiltr, int G, string zhyrFiltrMaterial, string tovchynaMetaluFiltr, string orderCode, string contragent, string filePath = null)
	{
		//IL_009a: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ab: Expected O, but got Unknown
		//IL_00b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c4: Expected O, but got Unknown
		//IL_00cc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00dd: Expected O, but got Unknown
		//IL_00ed: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f4: Expected O, but got Unknown
		//IL_00fc: Unknown result type (might be due to invalid IL or missing references)
		//IL_0103: Expected O, but got Unknown
		//IL_0103: Unknown result type (might be due to invalid IL or missing references)
		//IL_0108: Unknown result type (might be due to invalid IL or missing references)
		//IL_010f: Expected O, but got Unknown
		//IL_010f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0116: Expected O, but got Unknown
		//IL_4f1f: Unknown result type (might be due to invalid IL or missing references)
		//IL_4f26: Expected O, but got Unknown
		//IL_4f26: Unknown result type (might be due to invalid IL or missing references)
		//IL_4f2d: Expected O, but got Unknown
		int num = 725;
		int num2 = 1026;
		int num3 = 35;
		int num4 = 40;
		int num5 = 25;
		int num6 = 25 + num5;
		int num7 = 20;
		int num8 = num3;
		int num9 = 0;
		int num10 = num3;
		int num11 = 2 * num2 / 3 + 80;
		int num12 = 2 * num / 3 + 20;
		int num13 = num2 / 6;
		int num14 = 20;
		int num15 = 15;
		int num16 = num / 2;
		double num17 = Math.PI / 6.0;
		double num18 = 0.0;
		double num19 = 0.0;
		Image val = Image.FromFile(WPFHelper.GetProjectRootPath() + "\\Images\\Untitled.jpg");
		Graphics val2 = Graphics.FromImage(val);
		try
		{
			Pen val3 = new Pen(Color.FromArgb(255, 0, 0, 0), 1f);
			Pen val4 = new Pen(Color.FromArgb(255, 0, 0, 0), 2f);
			Pen val5 = new Pen(Color.FromArgb(255, 0, 0, 0), 3f);
			int num20 = 12;
			int num21 = 10;
			Font val6 = new Font("Arial", (float)num20);
			Font val7 = new Font("Arial", (float)num21);
			SolidBrush val8 = new SolidBrush(Color.Black);
			StringFormat val9 = new StringFormat();
			val9.LineAlignment = (StringAlignment)1;
			val9.Alignment = (StringAlignment)1;
			string text = "Зонт ЗВО-2 " + L + "х" + B + "х" + H;
			text += ((zhyrFiltr == "так") ? (" з ж/ф " + nFiltr + "шт") : " без ж/ф");
			text = text + "  -  " + number + " шт";
			text = text + " №Замовлення" + orderCode;
			text = text + ", Контрагент:" + contragent;
			#if WINDOWS
			val9.FormatFlags = (StringFormatFlags)1;
			#endif
			val2.DrawString(text, val6, (Brush)(object)val8, (float)(num / 2), (float)num5, val9);
			num18 = (double)(num - num3 - num4) / ((double)B + (double)L * Math.Cos(num17));
			double num22 = (double)L * Math.Sin(num17);
			double num23 = 0.0;
			if (vyhid == "з виходом")
			{
				if (vyhid1 == "круглий" || vyhid1 == "прямокутний")
				{
					num23 = ((vyhid1 == "круглий") ? ((double)(f1 + d1 / 2) * Math.Sin(num17)) : ((double)(f1 + a1 / 2) * Math.Sin(num17)));
					num23 += (double)p1;
					if (num23 > num22)
					{
						num22 = num23;
					}
				}
				if (vyhid2 == "круглий" || vyhid2 == "прямокутний")
				{
					num23 = ((vyhid2 == "круглий") ? ((double)(f2 + d2 / 2) * Math.Sin(num17)) : ((double)(f2 + a2 / 2) * Math.Sin(num17)));
					num23 += (double)p2;
					if (num23 > num22)
					{
						num22 = num23;
					}
				}
				if (vyhid3 == "круглий" || vyhid3 == "прямокутний")
				{
					num23 = ((vyhid3 == "круглий") ? ((double)(f3 + d3 / 2) * Math.Sin(num17)) : ((double)(f3 + a3 / 2) * Math.Sin(num17)));
					num23 += (double)p3;
					if (num23 > num22)
					{
						num22 = num23;
					}
				}
			}
			num22 += (double)H;
			double num24 = (double)(num2 / 3) / num22;
			if (num24 < num18)
			{
				num18 = num24;
			}
			int num25 = 10;
			num6 = num5 + num20 + num25;
			int num26 = num6;
			if (num22 > (double)H + (double)L * Math.Sin(num17))
			{
				num6 += (int)((num22 - ((double)H + (double)L * Math.Sin(num17))) * num18);
			}
			double num27 = 110.0;
			double num28 = (double)L * num18;
			double num29 = (double)H * num18;
			double num30 = (double)B * num18;
			double num31 = (double)h * num18;
			double num32 = (double)G * num18;
			double num33 = num27 * num18;
			double num34 = num3;
			double num35 = (double)num6 + num28 * Math.Sin(num17);
			double num36 = num34 + num30;
			double num37 = num35;
			val2.DrawLine(val4, (float)num34, (float)num35, (float)num36, (float)num37);
			num36 = num34 + num28 * Math.Cos(num17);
			num37 = num6;
			val2.DrawLine(val4, (float)num34, (float)num35, (float)num36, (float)num37);
			num34 = num36;
			num35 = num37;
			num36 = num34 + num30;
			val2.DrawLine(val4, (float)num34, (float)num35, (float)num36, (float)num37);
			num34 = (double)num3 + num30;
			num35 = (double)num6 + num28 * Math.Sin(num17);
			num36 = num34 + num28 * Math.Cos(num17);
			num37 = num6;
			val2.DrawLine(val4, (float)num34, (float)num35, (float)num36, (float)num37);
			double num42;
			double num43;
			double num50;
			double num51;
			if (vyhid == "з виходом")
			{
				if (vyhid1 == "круглий")
				{
					double num38 = (double)f1 * num18;
					double num39 = (double)g1 * num18;
					double num40 = (double)d1 * num18;
					double num41 = (double)p1 * num18;
					num34 = (double)num3 + num39 + (num38 - num40 / 2.0) * Math.Cos(num17);
					num35 = (double)num6 + num28 * Math.Sin(num17) - (num38 - num40 / 2.0) * Math.Sin(num17);
					num36 = (double)num3 + num39 - num40 / 2.0 + num38 * Math.Cos(num17) - 5.0;
					num37 = num35 - num40 / 2.0 * Math.Sin(num17);
					num42 = (double)num3 + num39 + (num38 + num40 / 2.0) * Math.Cos(num17);
					num43 = num35 - num40 * Math.Sin(num17);
					double num44 = num35 - num41;
					double num45 = num37 - num41;
					double num46 = num43 - num41;
					val2.DrawBezier(val4, (float)num34, (float)num35, (float)num36, (float)num37, (float)num42, (float)num43, (float)num42, (float)num43);
					val2.DrawBezier(val4, (float)num34, (float)num44, (float)num36, (float)num45, (float)num42, (float)num46, (float)num42, (float)num46);
					num36 = num36 + num40 + 10.0;
					val2.DrawBezier(val4, (float)num34, (float)num35, (float)num36, (float)num37, (float)num42, (float)num43, (float)num42, (float)num43);
					val2.DrawBezier(val4, (float)num34, (float)num44, (float)num36, (float)num45, (float)num42, (float)num46, (float)num42, (float)num46);
					val2.DrawLine(val4, (float)num34, (float)num35, (float)num34, (float)num44);
					val2.DrawLine(val4, (float)num42, (float)num43, (float)num42, (float)num46);
					double num47 = num34 - (double)num14;
					double num48 = num35;
					double num49 = num44;
					val2.DrawLine(val3, (float)num34, (float)num35, (float)num47, (float)num48);
					val2.DrawLine(val3, (float)num34, (float)num44, (float)num47, (float)num49);
					DrawRows(num47 + 5.0, num49, num47 + 5.0, num48, num18, val2, val3);
					num50 = num47 - (double)num21;
					num51 = (num48 + num49) / 2.0;
					#if WINDOWS
					val9.FormatFlags = (StringFormatFlags)2;
					#endif
					val2.DrawString(p1.ToString(), val7, (Brush)(object)val8, (float)num50, (float)num51, val9);
				}
				else if (vyhid1 == "прямокутний")
				{
					double num38 = (double)f1 * num18;
					double num39 = (double)g1 * num18;
					double num52 = (double)a1 * num18;
					double num53 = (double)b1 * num18;
					double num41 = (double)p1 * num18;
					num34 = (double)num3 + num39 + (num38 - num52 / 2.0) * Math.Cos(num17) - num53 / 2.0;
					num35 = (double)num6 + num28 * Math.Sin(num17) - (num38 - num52 / 2.0) * Math.Sin(num17);
					num36 = num34 + num53;
					num37 = num35;
					val2.DrawLine(val4, (float)num34, (float)num35, (float)num36, (float)num37);
					num43 = num35 - num41;
					val2.DrawLine(val4, (float)num34, (float)num35, (float)num34, (float)num43);
					double num54 = num37 - num41;
					val2.DrawLine(val4, (float)num36, (float)num37, (float)num36, (float)num54);
					val2.DrawLine(val4, (float)num34, (float)num43, (float)num36, (float)num54);
					double num55 = num34 - (double)num14;
					double num56 = num35;
					double num57 = num43;
					val2.DrawLine(val3, (float)num34, (float)num35, (float)num55, (float)num56);
					val2.DrawLine(val3, (float)num34, (float)num43, (float)num55, (float)num57);
					DrawRows(num55 + 5.0, num57, num55 + 5.0, num56, num18, val2, val3);
					num50 = num55 - (double)num21;
					num51 = (num56 + num57) / 2.0;
					#if WINDOWS
					val9.FormatFlags = (StringFormatFlags)2;
					#endif
					val2.DrawString(p1.ToString(), val7, (Brush)(object)val8, (float)num50, (float)num51, val9);
					num34 = num36;
					num35 = num37;
					num36 = num34 + num52 * Math.Cos(num17);
					num37 = num35 - num52 * Math.Sin(num17);
					val2.DrawLine(val4, (float)num34, (float)num35, (float)num36, (float)num37);
					num43 = num35 - num41;
					val2.DrawLine(val4, (float)num34, (float)num35, (float)num34, (float)num43);
					num54 = num37 - num41;
					val2.DrawLine(val4, (float)num36, (float)num37, (float)num36, (float)num54);
					val2.DrawLine(val4, (float)num34, (float)num43, (float)num36, (float)num54);
					num34 = num36;
					num35 = num37;
					num36 = num34 - num53;
					num37 = num35;
					val2.DrawLine(val4, (float)num34, (float)num35, (float)num36, (float)num37);
					num43 = num35 - num41;
					val2.DrawLine(val4, (float)num34, (float)num35, (float)num34, (float)num43);
					num54 = num37 - num41;
					val2.DrawLine(val4, (float)num36, (float)num37, (float)num36, (float)num54);
					val2.DrawLine(val4, (float)num34, (float)num43, (float)num36, (float)num54);
					num34 = num36;
					num35 = num37;
					num36 = num34 - num52 * Math.Cos(num17);
					num37 = num35 + num52 * Math.Sin(num17);
					val2.DrawLine(val4, (float)num34, (float)num35, (float)num36, (float)num37);
					num43 = num35 - num41;
					val2.DrawLine(val4, (float)num34, (float)num35, (float)num34, (float)num43);
					num54 = num37 - num41;
					val2.DrawLine(val4, (float)num36, (float)num37, (float)num36, (float)num54);
					val2.DrawLine(val4, (float)num34, (float)num43, (float)num36, (float)num54);
				}
				if (vyhid2 == "круглий")
				{
					double num58 = (double)f2 * num18;
					double num59 = (double)g2 * num18;
					double num60 = (double)d2 * num18;
					double num61 = (double)p2 * num18;
					num34 = (double)num3 + num59 + (num58 - num60 / 2.0) * Math.Cos(num17);
					num35 = (double)num6 + num28 * Math.Sin(num17) - (num58 - num60 / 2.0) * Math.Sin(num17);
					num36 = (double)num3 + num59 - num60 / 2.0 + num58 * Math.Cos(num17) - 5.0;
					num37 = num35 - num60 / 2.0 * Math.Sin(num17);
					num42 = (double)num3 + num59 + (num58 + num60 / 2.0) * Math.Cos(num17);
					num43 = num35 - num60 * Math.Sin(num17);
					double num62 = num35 - num61;
					double num63 = num37 - num61;
					double num64 = num43 - num61;
					val2.DrawBezier(val4, (float)num34, (float)num35, (float)num36, (float)num37, (float)num42, (float)num43, (float)num42, (float)num43);
					val2.DrawBezier(val4, (float)num34, (float)num62, (float)num36, (float)num63, (float)num42, (float)num64, (float)num42, (float)num64);
					num36 = num36 + num60 + 10.0;
					val2.DrawBezier(val4, (float)num34, (float)num35, (float)num36, (float)num37, (float)num42, (float)num43, (float)num42, (float)num43);
					val2.DrawBezier(val4, (float)num34, (float)num62, (float)num36, (float)num63, (float)num42, (float)num64, (float)num42, (float)num64);
					val2.DrawLine(val4, (float)num34, (float)num35, (float)num34, (float)num62);
					val2.DrawLine(val4, (float)num42, (float)num43, (float)num42, (float)num64);
					double num65 = num34 - (double)num14;
					double num66 = num35;
					double num67 = num62;
					val2.DrawLine(val3, (float)num34, (float)num35, (float)num65, (float)num66);
					val2.DrawLine(val3, (float)num34, (float)num62, (float)num65, (float)num67);
					DrawRows(num65 + 5.0, num67, num65 + 5.0, num66, num18, val2, val3);
					num50 = num65 - (double)num21;
					num51 = (num66 + num67) / 2.0;
					#if WINDOWS
					val9.FormatFlags = (StringFormatFlags)2;
					#endif
					val2.DrawString(p2.ToString(), val7, (Brush)(object)val8, (float)num50, (float)num51, val9);
				}
				else if (vyhid2 == "прямокутний")
				{
					double num58 = (double)f2 * num18;
					double num59 = (double)g2 * num18;
					double num68 = (double)a2 * num18;
					double num69 = (double)b2 * num18;
					double num61 = (double)p2 * num18;
					num34 = (double)num3 + num59 + (num58 - num68 / 2.0) * Math.Cos(num17) - num69 / 2.0;
					num35 = (double)num6 + num28 * Math.Sin(num17) - (num58 - num68 / 2.0) * Math.Sin(num17);
					num36 = num34 + num69;
					num37 = num35;
					val2.DrawLine(val4, (float)num34, (float)num35, (float)num36, (float)num37);
					num43 = num35 - num61;
					val2.DrawLine(val4, (float)num34, (float)num35, (float)num34, (float)num43);
					double num54 = num37 - num61;
					val2.DrawLine(val4, (float)num36, (float)num37, (float)num36, (float)num54);
					val2.DrawLine(val4, (float)num34, (float)num43, (float)num36, (float)num54);
					double num70 = num34 - (double)num14;
					double num71 = num35;
					double num72 = num43;
					val2.DrawLine(val3, (float)num34, (float)num35, (float)num70, (float)num71);
					val2.DrawLine(val3, (float)num34, (float)num43, (float)num70, (float)num72);
					DrawRows(num70 + 5.0, num72, num70 + 5.0, num71, num18, val2, val3);
					num50 = num70 - (double)num21;
					num51 = (num71 + num72) / 2.0;
					#if WINDOWS
					val9.FormatFlags = (StringFormatFlags)2;
					#endif
					val2.DrawString(p2.ToString(), val7, (Brush)(object)val8, (float)num50, (float)num51, val9);
					num34 = num36;
					num35 = num37;
					num36 = num34 + num68 * Math.Cos(num17);
					num37 = num35 - num68 * Math.Sin(num17);
					val2.DrawLine(val4, (float)num34, (float)num35, (float)num36, (float)num37);
					num43 = num35 - num61;
					val2.DrawLine(val4, (float)num34, (float)num35, (float)num34, (float)num43);
					num54 = num37 - num61;
					val2.DrawLine(val4, (float)num36, (float)num37, (float)num36, (float)num54);
					val2.DrawLine(val4, (float)num34, (float)num43, (float)num36, (float)num54);
					num34 = num36;
					num35 = num37;
					num36 = num34 - num69;
					num37 = num35;
					val2.DrawLine(val4, (float)num34, (float)num35, (float)num36, (float)num37);
					num43 = num35 - num61;
					val2.DrawLine(val4, (float)num34, (float)num35, (float)num34, (float)num43);
					num54 = num37 - num61;
					val2.DrawLine(val4, (float)num36, (float)num37, (float)num36, (float)num54);
					val2.DrawLine(val4, (float)num34, (float)num43, (float)num36, (float)num54);
					num34 = num36;
					num35 = num37;
					num36 = num34 - num68 * Math.Cos(num17);
					num37 = num35 + num68 * Math.Sin(num17);
					val2.DrawLine(val4, (float)num34, (float)num35, (float)num36, (float)num37);
					num43 = num35 - num61;
					val2.DrawLine(val4, (float)num34, (float)num35, (float)num34, (float)num43);
					num54 = num37 - num61;
					val2.DrawLine(val4, (float)num36, (float)num37, (float)num36, (float)num54);
					val2.DrawLine(val4, (float)num34, (float)num43, (float)num36, (float)num54);
				}
				if (vyhid3 == "круглий")
				{
					double num73 = (double)f3 * num18;
					double num74 = (double)g3 * num18;
					double num75 = (double)d3 * num18;
					double num76 = (double)p3 * num18;
					num34 = (double)num3 + num74 + (num73 - num75 / 2.0) * Math.Cos(num17);
					num35 = (double)num6 + num28 * Math.Sin(num17) - (num73 - num75 / 2.0) * Math.Sin(num17);
					num36 = (double)num3 + num74 - num75 / 2.0 + num73 * Math.Cos(num17) - 5.0;
					num37 = num35 - num75 / 2.0 * Math.Sin(num17);
					num42 = (double)num3 + num74 + (num73 + num75 / 2.0) * Math.Cos(num17);
					num43 = num35 - num75 * Math.Sin(num17);
					double num77 = num35 - num76;
					double num78 = num37 - num76;
					double num79 = num43 - num76;
					val2.DrawBezier(val4, (float)num34, (float)num35, (float)num36, (float)num37, (float)num42, (float)num43, (float)num42, (float)num43);
					val2.DrawBezier(val4, (float)num34, (float)num77, (float)num36, (float)num78, (float)num42, (float)num79, (float)num42, (float)num79);
					num36 = num36 + num75 + 10.0;
					val2.DrawBezier(val4, (float)num34, (float)num35, (float)num36, (float)num37, (float)num42, (float)num43, (float)num42, (float)num43);
					val2.DrawBezier(val4, (float)num34, (float)num77, (float)num36, (float)num78, (float)num42, (float)num79, (float)num42, (float)num79);
					val2.DrawLine(val4, (float)num34, (float)num35, (float)num34, (float)num77);
					val2.DrawLine(val4, (float)num42, (float)num43, (float)num42, (float)num79);
					double num80 = num34 - (double)num14;
					double num81 = num35;
					double num82 = num77;
					val2.DrawLine(val3, (float)num34, (float)num35, (float)num80, (float)num81);
					val2.DrawLine(val3, (float)num34, (float)num77, (float)num80, (float)num82);
					DrawRows(num80 + 5.0, num82, num80 + 5.0, num81, num18, val2, val3);
					num50 = num80 - (double)num21;
					num51 = (num81 + num82) / 2.0;
					#if WINDOWS
					val9.FormatFlags = (StringFormatFlags)2;
					#endif
					val2.DrawString(p3.ToString(), val7, (Brush)(object)val8, (float)num50, (float)num51, val9);
				}
				else if (vyhid3 == "прямокутний")
				{
					double num73 = (double)f3 * num18;
					double num74 = (double)g3 * num18;
					double num83 = (double)a3 * num18;
					double num84 = (double)b3 * num18;
					double num76 = (double)p3 * num18;
					num34 = (double)num3 + num74 + (num73 - num83 / 2.0) * Math.Cos(num17) - num84 / 2.0;
					num35 = (double)num6 + num28 * Math.Sin(num17) - (num73 - num83 / 2.0) * Math.Sin(num17);
					num36 = num34 + num84;
					num37 = num35;
					val2.DrawLine(val4, (float)num34, (float)num35, (float)num36, (float)num37);
					num43 = num35 - num76;
					val2.DrawLine(val4, (float)num34, (float)num35, (float)num34, (float)num43);
					double num54 = num37 - num76;
					val2.DrawLine(val4, (float)num36, (float)num37, (float)num36, (float)num54);
					val2.DrawLine(val4, (float)num34, (float)num43, (float)num36, (float)num54);
					double num85 = num34 - (double)num14;
					double num86 = num35;
					double num87 = num43;
					val2.DrawLine(val3, (float)num34, (float)num35, (float)num85, (float)num86);
					val2.DrawLine(val3, (float)num34, (float)num43, (float)num85, (float)num87);
					DrawRows(num85 + 5.0, num87, num85 + 5.0, num86, num18, val2, val3);
					num50 = num85 - (double)num21;
					num51 = (num86 + num87) / 2.0;
					#if WINDOWS
					val9.FormatFlags = (StringFormatFlags)2;
					#endif
					val2.DrawString(p3.ToString(), val7, (Brush)(object)val8, (float)num50, (float)num51, val9);
					num34 = num36;
					num35 = num37;
					num36 = num34 + num83 * Math.Cos(num17);
					num37 = num35 - num83 * Math.Sin(num17);
					val2.DrawLine(val4, (float)num34, (float)num35, (float)num36, (float)num37);
					num43 = num35 - num76;
					val2.DrawLine(val4, (float)num34, (float)num35, (float)num34, (float)num43);
					num54 = num37 - num76;
					val2.DrawLine(val4, (float)num36, (float)num37, (float)num36, (float)num54);
					val2.DrawLine(val4, (float)num34, (float)num43, (float)num36, (float)num54);
					num34 = num36;
					num35 = num37;
					num36 = num34 - num84;
					num37 = num35;
					val2.DrawLine(val4, (float)num34, (float)num35, (float)num36, (float)num37);
					num43 = num35 - num76;
					val2.DrawLine(val4, (float)num34, (float)num35, (float)num34, (float)num43);
					num54 = num37 - num76;
					val2.DrawLine(val4, (float)num36, (float)num37, (float)num36, (float)num54);
					val2.DrawLine(val4, (float)num34, (float)num43, (float)num36, (float)num54);
					num34 = num36;
					num35 = num37;
					num36 = num34 - num83 * Math.Cos(num17);
					num37 = num35 + num83 * Math.Sin(num17);
					val2.DrawLine(val4, (float)num34, (float)num35, (float)num36, (float)num37);
					num43 = num35 - num76;
					val2.DrawLine(val4, (float)num34, (float)num35, (float)num34, (float)num43);
					num54 = num37 - num76;
					val2.DrawLine(val4, (float)num36, (float)num37, (float)num36, (float)num54);
					val2.DrawLine(val4, (float)num34, (float)num43, (float)num36, (float)num54);
				}
			}
			num34 = num3;
			num35 = (double)num6 + num28 * Math.Sin(num17);
			num36 = num34;
			num37 = num35 + num31;
			val2.DrawLine(val4, (float)num34, (float)num35, (float)num36, (float)num37);
			num34 = num36;
			num35 = num37;
			num36 = num34 + (num30 - num33) / 2.0;
			num37 = num35 + num29 - num31;
			val2.DrawLine(val4, (float)num34, (float)num35, (float)num36, (float)num37);
			num34 = num36;
			num35 = num37;
			num36 = num34 + num33;
			num37 = num35;
			val2.DrawLine(val4, (float)num34, (float)num35, (float)num36, (float)num37);
			num34 = num36;
			num35 = num37;
			num36 = num34 + (num30 - num33) / 2.0;
			num37 = num35 - (num29 - num31);
			val2.DrawLine(val4, (float)num34, (float)num35, (float)num36, (float)num37);
			num34 = num36;
			num35 = num37;
			num37 = num35 - num31;
			val2.DrawLine(val4, (float)num34, (float)num35, (float)num36, (float)num37);
			num34 = num36;
			num35 = num37 + num31;
			num36 = num34 + num28 * Math.Cos(num17);
			num37 = num35 - num28 * Math.Sin(num17);
			val2.DrawLine(val4, (float)num34, (float)num35, (float)num36, (float)num37);
			num34 = num36;
			num35 = num37;
			num37 = num35 - num31;
			val2.DrawLine(val4, (float)num34, (float)num35, (float)num36, (float)num37);
			num34 = (double)num3 + (num30 + num33) / 2.0;
			num35 = (double)num6 + num28 * Math.Sin(num17) + num29;
			num36 = num34 + num28 * Math.Cos(num17);
			num37 = num35 - num28 * Math.Sin(num17);
			val2.DrawLine(val4, (float)num34, (float)num35, (float)num36, (float)num37);
			num34 = num36;
			num35 = num37;
			num36 = num34 + (num30 - num33) / 2.0;
			num37 = num35 - (num29 - num31);
			val2.DrawLine(val4, (float)num34, (float)num35, (float)num36, (float)num37);
			num34 = num3;
			num35 = (double)num6 + num28 * Math.Sin(num17);
			num36 = num34 - (double)num14;
			num37 = num35;
			val2.DrawLine(val3, (float)num34, (float)num35, (float)num36, (float)num37);
			num34 = (double)num3 + (num30 - num33) / 2.0;
			num35 = (double)num6 + num28 * Math.Sin(num17) + num29;
			num36 = num3 - num14;
			num37 = num35;
			val2.DrawLine(val3, (float)num34, (float)num35, (float)num36, (float)num37);
			num34 = num3 - num14 + 5;
			num35 = (double)num6 + num28 * Math.Sin(num17);
			num36 = num34;
			num37 = num35 + num29;
			DrawRows(num34, num35, num36, num37, num18, val2, val3);
			num50 = num34 - (double)num21;
			num51 = (num35 + num37) / 2.0;
			#if WINDOWS
			val9.FormatFlags = (StringFormatFlags)2;
			#endif
			val2.DrawString(H.ToString(), val7, (Brush)(object)val8, (float)num50, (float)num51, val9);
			num34 = (double)num3 + (num30 - num33) / 2.0;
			num35 = (double)num6 + num28 * Math.Sin(num17) + num29;
			num36 = num34;
			num37 = num35 + (double)num14;
			val2.DrawLine(val3, (float)num34, (float)num35, (float)num36, (float)num37);
			num34 = (double)num3 + (num30 + num33) / 2.0;
			num35 = (double)num6 + num28 * Math.Sin(num17) + num29;
			num36 = num34;
			num37 = num35 + (double)num14;
			val2.DrawLine(val3, (float)num34, (float)num35, (float)num36, (float)num37);
			num34 = (double)num3 + (num30 - num33) / 2.0;
			num35 = (double)num6 + num28 * Math.Sin(num17) + num29 + (double)num14 - 5.0;
			num36 = num34 + num33;
			num37 = num35;
			DrawRows(num34, num35, num36, num37, num18, val2, val3);
			num50 = (num34 + num36) / 2.0;
			num51 = num37 + (double)num21;
			#if WINDOWS
			val9.FormatFlags = (StringFormatFlags)1;
			#endif
			val2.DrawString(num27.ToString(), val7, (Brush)(object)val8, (float)num50, (float)num51, val9);
			num34 = num3;
			num35 = (double)num6 + num28 * Math.Sin(num17) + num31;
			num36 = num34;
			num37 = num35 + num29 - num31 + (double)num14 + 20.0;
			val2.DrawLine(val3, (float)num34, (float)num35, (float)num36, (float)num37);
			num34 = (double)num3 + num30;
			num35 = (double)num6 + num28 * Math.Sin(num17) + num31;
			num36 = num34;
			num37 = num35 + num29 - num31 + (double)num14 + 20.0;
			val2.DrawLine(val3, (float)num34, (float)num35, (float)num36, (float)num37);
			num34 = num3;
			num35 = (double)num6 + num28 * Math.Sin(num17) + num29 + 20.0 + (double)num14 - 5.0;
			num36 = num34 + num30;
			num37 = num35;
			DrawRows(num34, num35, num36, num37, num18, val2, val3);
			num50 = (num34 + num36) / 2.0;
			num51 = num37 + (double)num21;
			#if WINDOWS
			val9.FormatFlags = (StringFormatFlags)1;
			#endif
			val2.DrawString(B.ToString(), val7, (Brush)(object)val8, (float)num50, (float)num51, val9);
			num34 = (double)num3 + num30 + num28 * Math.Cos(num17);
			num35 = (double)num6 + num31;
			num36 = num34;
			num37 = num35 + num29 - num31 + 20.0 + (double)num14;
			val2.DrawLine(val3, (float)num34, (float)num35, (float)num36, (float)num37);
			num34 = (double)num3 + num30;
			num35 = (double)num6 + num28 * Math.Sin(num17) + num29 + 20.0 + (double)num14 - 5.0;
			num36 = num34 + num28 * Math.Cos(num17);
			num37 = (double)num6 + num29 + 20.0 + (double)num14 - 5.0;
			DrawRows(num34, num35, num36, num37, num18, val2, val3);
			num50 = (num34 + num36) / 2.0;
			num51 = (num35 + num37) / 2.0 + 15.0 + 5.0;
			#if WINDOWS
			val9.FormatFlags = (StringFormatFlags)1;
			#endif
			val2.DrawString(L.ToString(), val7, (Brush)(object)val8, (float)num50, (float)num51, val9);
			num34 = (double)num3 + num28 * Math.Cos(num17) + num30;
			num35 = num6;
			num36 = num34 + (double)num14;
			num37 = num35;
			val2.DrawLine(val3, (float)num34, (float)num35, (float)num36, (float)num37);
			num34 = (double)num3 + num28 * Math.Cos(num17) + num30;
			num35 = (double)num6 + num31;
			num36 = num34 + (double)num14;
			num37 = num35;
			val2.DrawLine(val3, (float)num34, (float)num35, (float)num36, (float)num37);
			num34 = (double)num3 + num28 * Math.Cos(num17) + num30 + (double)num14 - 5.0;
			num35 = num6;
			num36 = num34;
			num37 = num35 + num31;
			DrawRows(num34, num35, num36, num37, num18, val2, val3);
			num50 = num34 + (double)num21;
			num51 = (num35 + num37) / 2.0;
			#if WINDOWS
			val9.FormatFlags = (StringFormatFlags)2;
			#endif
			val2.DrawString(h.ToString(), val7, (Brush)(object)val8, (float)num50, (float)num51, val9);
			double num88 = Math.Atan(2.0 * ((double)H - (double)h) / ((double)B - num27));
			double num89 = Math.Min(num31 / 2.0, 20.0);
			num34 = (double)num3 + num30;
			num35 = (double)num6 + num28 * Math.Sin(num17) + num31 - num89;
			num42 = num34 - num89 * Math.Cos(num88);
			num43 = (double)num6 + num28 * Math.Sin(num17) + num31 + num89 * Math.Sin(num88);
			num36 = num34 - num89;
			num37 = (num35 + num43) / 2.0;
			val2.DrawBezier(val3, (float)num42, (float)num43, (float)num36, (float)num37, (float)num34, (float)num35, (float)num34, (float)num35);
			num88 = Math.Round(num88 * 180.0 / Math.PI, MidpointRounding.AwayFromZero) + 90.0;
			#if WINDOWS
			val9.FormatFlags = (StringFormatFlags)1;
			#endif
			val2.DrawString(num88 + "°", val7, (Brush)(object)val8, (float)(num36 - 10.0), (float)num37 - 5f, val9);
			#if WINDOWS
			val9.FormatFlags = (StringFormatFlags)2;
			#endif
			if (zhyrFiltr == "так")
			{
				double num90 = 20.0;
				double num91 = 60.0;
				double num92 = 70.0;
				double num93 = 10.0;
				num27 = 110.0;
				double num94 = 25.0;
				double num95 = 55.0;
				double num96 = 15.0;
				double num97 = num90 * num18;
				double num98 = num91 * num18;
				double num99 = num92 * num18;
				double num100 = num93 * num18;
				num33 = num27 * num18;
				double num101 = num94 * num18;
				double num102 = num95 * num18;
				double num103 = num96 * num18;
				double num104 = 0.0;
				num34 = (double)num3 + (num30 - num33) / 2.0;
				num35 = (double)num6 + num28 * Math.Sin(num17) + num29;
				num36 = num34 + num33;
				num37 = num35;
				val2.DrawLine(val5, (float)num34, (float)num35, (float)num36, (float)num37);
				num36 = num34;
				num37 = num35 - num101;
				val2.DrawLine(val5, (float)num34, (float)num35, (float)num36, (float)num37);
				num34 += num33;
				num36 = num34;
				num37 = num35 - num101;
				val2.DrawLine(val5, (float)num34, (float)num35, (float)num36, (float)num37);
				double num105 = 4.0;
				num34 = (double)num3 + num30 / 2.0;
				num35 = (double)num6 + num28 * Math.Sin(num17) + num29 - num105;
				num36 = num34;
				num37 = num35 - (num102 - num105);
				val2.DrawLine(val5, (float)num34, (float)num35, (float)num36, (float)num37);
				num36 = num34 + num103;
				num37 = num35;
				val2.DrawLine(val5, (float)num34, (float)num35, (float)num36, (float)num37);
				if (G < B)
				{
					num34 = (double)num3 + (num30 - num32) / 2.0;
					num35 = (double)num6 + num28 * Math.Sin(num17);
					num36 = num34;
					num37 = num35 + (double)num14;
					val2.DrawLine(val3, (float)num34, (float)num35, (float)num36, (float)num37);
					num34 = (double)num3 + (num30 + num32) / 2.0;
					num35 = (double)num6 + num28 * Math.Sin(num17);
					num36 = num34;
					num37 = num35 + (double)num14;
					val2.DrawLine(val3, (float)num34, (float)num35, (float)num36, (float)num37);
					num34 = (double)num3 + (num30 - num32) / 2.0;
					num35 = (double)num6 + num28 * Math.Sin(num17) + (double)num14 - 5.0;
					num37 -= 5.0;
					DrawRows(num34, num35, num36, num37, num18, val2, val3);
					num50 = (num34 + num36) / 2.0;
					num51 = num37 + (double)num21 + 3.0;
					#if WINDOWS
					val9.FormatFlags = (StringFormatFlags)1;
					#endif
					val2.DrawString(G.ToString(), val7, (Brush)(object)val8, (float)num50, (float)num51, val9);
					num34 = (double)num3 + (num30 + num32) / 2.0;
					num35 = (double)num6 + num28 * Math.Sin(num17);
					num36 = num34 - num97;
					num37 = num35;
					val2.DrawLine(val5, (float)num34, (float)num35, (float)num36, (float)num37);
					num34 = (double)num3 + (num30 - num32) / 2.0;
					num35 = (double)num6 + num28 * Math.Sin(num17);
					num36 = num34 + num97;
					num37 = num35;
					val2.DrawLine(val5, (float)num34, (float)num35, (float)num36, (float)num37);
					num34 = (double)num3 + (num30 + num32) / 2.0;
					num35 = (double)num6 + num28 * Math.Sin(num17);
					num36 = num34;
					num37 = num35 + num98;
					val2.DrawLine(val5, (float)num34, (float)num35, (float)num36, (float)num37);
					num34 = (double)num3 + (num30 - num32) / 2.0;
					num35 = (double)num6 + num28 * Math.Sin(num17);
					num36 = num34;
					num37 = num35 + num98;
					val2.DrawLine(val5, (float)num34, (float)num35, (float)num36, (float)num37);
				}
				num34 = (double)num3 + num30 / 2.0;
				num35 = (double)num6 + num28 * Math.Sin(num17) + num29;
				num36 = (double)num3 + (num30 + num32) / 2.0;
				num37 = (double)num6 + num28 * Math.Sin(num17);
				num37 += ((G < B) ? num98 : num31);
				double num106 = 40.0;
				double num107 = num106 * num18;
				double num108 = 1E-05;
				double num109 = Math.Atan((num35 - num37) / (num36 - num34));
				double num110 = Math.Atan((num35 - num37 + num93) / (num36 - num93 - (num34 + num107)));
				while (num110 - num109 > num108)
				{
					num104 = (num109 + num110) / 2.0;
					double num111 = num36 - num34 - (num107 + num100) * Math.Sin(num109) - (num35 - num37 + num100 * Math.Cos(num109)) / Math.Tan(num109);
					double num112 = num36 - num34 - (num107 + num100) * Math.Sin(num104) - (num35 - num37 + num100 * Math.Cos(num104)) / Math.Tan(num104);
					if (num111 * num112 < 0.0)
					{
						num110 = num104;
					}
					else
					{
						num109 = num104;
					}
				}
				betaGradus = 90 - (int)Math.Round(num104 * 180.0 / Math.PI);
				num34 = (double)num3 + (num30 + num32) / 2.0;
				num35 = (double)num6 + num28 * Math.Sin(num17);
				num35 += ((G < B) ? num98 : num31);
				num36 = num34 - num99 * Math.Cos(num104);
				num37 = num35 + num99 * Math.Sin(num104);
				val2.DrawLine(val5, (float)num34, (float)num35, (float)num36, (float)num37);
				num34 = (double)num3 + (num30 - num32) / 2.0;
				num35 = (double)num6 + num28 * Math.Sin(num17);
				num35 += ((G < B) ? num98 : num31);
				num36 = num34 + num99 * Math.Cos(num104);
				num37 = num35 + num99 * Math.Sin(num104);
				val2.DrawLine(val5, (float)num34, (float)num35, (float)num36, (float)num37);
				num34 = (double)num3 + (num30 + num32) / 2.0 - num99 * Math.Cos(num104);
				num35 = (double)num6 + num28 * Math.Sin(num17) + num99 * Math.Sin(num104);
				num35 += ((G < B) ? num98 : num31);
				num36 = num34 - num100 * Math.Sin(num104);
				num37 = num35 - num100 * Math.Cos(num104);
				val2.DrawLine(val5, (float)num34, (float)num35, (float)num36, (float)num37);
				num34 = (double)num3 + (num30 - num32) / 2.0 + num99 * Math.Cos(num104);
				num35 = (double)num6 + num28 * Math.Sin(num17) + num99 * Math.Sin(num104);
				num35 += ((G < B) ? num98 : num31);
				num36 = num34 + num100 * Math.Sin(num104);
				num37 = num35 - num100 * Math.Cos(num104);
				val2.DrawLine(val5, (float)num34, (float)num35, (float)num36, (float)num37);
				double num113 = 40.0;
				double num114 = (double)(G / 2) - (num106 + num93) * Math.Sin(num104);
				double num115 = (double)H - num91 + num93 * Math.Cos(num104);
				l = (int)Math.Round(Math.Sqrt(num114 * num114 + num115 * num115) - num113);
				double num116 = (double)l * num18 - num105;
				num34 = (double)num3 + num30 / 2.0 + num107 * Math.Sin(num104) + num105 * Math.Cos(num104);
				num35 = (double)num6 + num28 * Math.Sin(num17) + num29 - num105 * Math.Sin(num104);
				num36 = num34 - num107 * Math.Sin(num104);
				num37 = num35 - num107 * Math.Cos(num104);
				val2.DrawLine(val5, (float)num34, (float)num35, (float)num36, (float)num37);
				num36 = num34 + num116 * Math.Cos(num104);
				num37 = num35 - num116 * Math.Sin(num104);
				double num117 = num36;
				double num118 = num37;
				val2.DrawLine(val5, (float)num34, (float)num35, (float)num36, (float)num37);
				num34 -= num107 * Math.Sin(num104);
				num35 -= num107 * Math.Cos(num104);
				num36 = num34 + num116 * Math.Cos(num104);
				num37 = num35 - num116 * Math.Sin(num104);
				double num119 = num36;
				double num120 = num37;
				val2.DrawLine(val5, (float)num34, (float)num35, (float)num36, (float)num37);
				val2.DrawLine(val5, (float)num117, (float)num118, (float)num119, (float)num120);
				num34 = (double)num3 + num30 / 2.0 - num107 * Math.Sin(num104) - num105 * Math.Cos(num104);
				num35 = (double)num6 + num28 * Math.Sin(num17) + num29 - num105 * Math.Sin(num104);
				num36 = num34 + num107 * Math.Sin(num104);
				num37 = num35 - num107 * Math.Cos(num104);
				val2.DrawLine(val5, (float)num34, (float)num35, (float)num36, (float)num37);
				num36 = num34 - num116 * Math.Cos(num104);
				num37 = num35 - num116 * Math.Sin(num104);
				num117 = num36;
				num118 = num37;
				val2.DrawLine(val5, (float)num34, (float)num35, (float)num36, (float)num37);
				num34 += num107 * Math.Sin(num104);
				num35 -= num107 * Math.Cos(num104);
				num36 = num34 - num116 * Math.Cos(num104);
				num37 = num35 - num116 * Math.Sin(num104);
				num119 = num36;
				num120 = num37;
				val2.DrawLine(val5, (float)num34, (float)num35, (float)num36, (float)num37);
				val2.DrawLine(val5, (float)num117, (float)num118, (float)num119, (float)num120);
				double num121 = 1.5;
				double num122 = 0.0;
				double num123 = 0.0;
				double num124 = 0.0;
				double num125 = 0.0;
				num33 = num27 * num121;
				num101 = num94 * num121;
				num102 = num95 * num121;
				num103 = num96 * num121;
				num29 = (double)H * num121;
				num31 = (double)h * num121;
				num30 = (double)B * num121;
				num97 = num90 * num121;
				num98 = num91 * num121;
				num99 = num92 * num121;
				num100 = num93 * num121;
				num124 = num - num4;
				num125 = (double)num26 + num22 * num18 + 40.0;
				num122 = (double)(num - num4) - num33;
				num123 = num125 + num98 + num99 + num102;
				num34 = num122;
				num35 = num123;
				num36 = num34 + num33;
				num37 = num35;
				val2.DrawLine(val5, (float)num34, (float)num35, (float)num36, (float)num37);
				num34 = num122;
				num35 = num123;
				num36 = num34;
				num37 = num35 + (double)num15;
				num117 = num36;
				num118 = num37;
				val2.DrawLine(val3, (float)num34, (float)num35, (float)num36, (float)num37);
				num34 += num33;
				num36 = num34;
				num119 = num36;
				num120 = num37;
				val2.DrawLine(val3, (float)num34, (float)num35, (float)num36, (float)num37);
				num34 = num117;
				num35 = num118 - 5.0;
				num36 = num119;
				num37 = num120 - 5.0;
				DrawRows(num34, num35, num36, num37, num18, val2, val3);
				num50 = (num117 + num119) / 2.0;
				num51 = num118 + (double)num21;
				#if WINDOWS
				val9.FormatFlags = (StringFormatFlags)1;
				#endif
				val2.DrawString(num27.ToString(), val7, (Brush)(object)val8, (float)num50, (float)num51, val9);
				num34 = num122 + num33;
				num35 = num123;
				num36 = num34;
				num37 = num35 - num101;
				val2.DrawLine(val5, (float)num34, (float)num35, (float)num36, (float)num37);
				num34 = num122;
				num35 = num123;
				num36 = num34;
				num37 = num35 - num101;
				val2.DrawLine(val5, (float)num34, (float)num35, (float)num36, (float)num37);
				num36 = num34 - (double)num15;
				num37 = num35;
				val2.DrawLine(val3, (float)num34, (float)num35, (float)num36, (float)num37);
				num35 = num123 - num101;
				num36 = num34 - (double)num15;
				num37 = num35;
				val2.DrawLine(val3, (float)num34, (float)num35, (float)num36, (float)num37);
				num34 = num36 + 5.0;
				num35 = num123;
				num36 = num34;
				num37 = num35 - num101;
				DrawRows(num36, num37, num34, num35, num18, val2, val3);
				num50 = num34 - (double)num21 - 3.0;
				num51 = (num35 + num37) / 2.0;
				#if WINDOWS
				val9.FormatFlags = (StringFormatFlags)1;
				#endif
				val2.DrawString(num94.ToString(), val7, (Brush)(object)val8, (float)num50, (float)num51, val9);
				num34 = num124 - num97 - 4.0 * num103;
				num35 = num125;
				num36 = num34;
				num37 = num35 + num102;
				val2.DrawLine(val5, (float)num34, (float)num35, (float)num36, (float)num37);
				num36 = num34 - (double)num15;
				num37 = num35;
				val2.DrawLine(val3, (float)num34, (float)num35, (float)num36, (float)num37);
				num34 = num124 - num97 - 4.0 * num103;
				num35 = num125 + num102;
				num36 = num34 - (double)num15;
				num37 = num35;
				val2.DrawLine(val3, (float)num34, (float)num35, (float)num36, (float)num37);
				num34 = num36 + 5.0;
				num35 = num125;
				num36 = num34;
				num37 = num35 + num102;
				DrawRows(num34, num35, num36, num37, num18, val2, val3);
				num50 = num34 - (double)num21 - 3.0;
				num51 = (num35 + num37) / 2.0;
				#if WINDOWS
				val9.FormatFlags = (StringFormatFlags)1;
				#endif
				val2.DrawString(num95.ToString(), val7, (Brush)(object)val8, (float)num50, (float)num51, val9);
				num34 = num124 - num97 - 4.0 * num103;
				num35 = num125 + num102;
				num36 = num34 + num103;
				num37 = num35;
				val2.DrawLine(val5, (float)num34, (float)num35, (float)num36, (float)num37);
				num36 = num34;
				num37 = num35 + (double)num15;
				val2.DrawLine(val3, (float)num34, (float)num35, (float)num36, (float)num37);
				num34 = num36 + num103;
				num36 = num34;
				val2.DrawLine(val3, (float)num34, (float)num35, (float)num36, (float)num37);
				num34 = num124 - num97 - 4.0 * num103;
				num35 = num125 + num102 + (double)num15 - 5.0;
				num36 = num34 + num103;
				num37 = num35;
				DrawRows(num36, num37, num34, num35, num18, val2, val3);
				num50 = (num34 + num36) / 2.0;
				num51 = num35 + (double)num21;
				#if WINDOWS
				val9.FormatFlags = (StringFormatFlags)1;
				#endif
				val2.DrawString(num96.ToString(), val7, (Brush)(object)val8, (float)num50, (float)num51, val9);
				if (G < B)
				{
					num34 = num124;
					num35 = num125;
					num36 = num34 - num97;
					num37 = num35;
					val2.DrawLine(val5, (float)num34, (float)num35, (float)num36, (float)num37);
					num36 = num34;
					num37 = num35 - (double)num15;
					val2.DrawLine(val3, (float)num34, (float)num35, (float)num36, (float)num37);
					num34 = num36 - num97;
					num36 = num34;
					val2.DrawLine(val3, (float)num34, (float)num35, (float)num36, (float)num37);
					num34 = num124;
					num35 = num125 - (double)num15 + 5.0;
					num36 = num34 - num97;
					num37 = num35;
					DrawRows(num36, num37, num34, num35, num18, val2, val3);
					num50 = (num34 + num36) / 2.0;
					num51 = num35 - (double)num21 - 3.0;
					#if WINDOWS
					val9.FormatFlags = (StringFormatFlags)1;
					#endif
					val2.DrawString(num90.ToString(), val7, (Brush)(object)val8, (float)num50, (float)num51, val9);
				}
				num34 = num124;
				num35 = num125;
				num36 = num34;
				num37 = num35 + num98;
				double num126 = num36;
				double num127 = num37;
				val2.DrawLine(val5, (float)num34, (float)num35, (float)num36, (float)num37);
				num36 = num34 + (double)num15;
				num37 = num35;
				num117 = num36;
				num118 = num37;
				val2.DrawLine(val3, (float)num34, (float)num35, (float)num36, (float)num37);
				num34 = num124;
				num35 = num125 + num98;
				num36 = num34 + (double)num15;
				num37 = num35;
				val2.DrawLine(val3, (float)num34, (float)num35, (float)num36, (float)num37);
				num34 = num117 - 5.0;
				num35 = num118;
				num36 -= 5.0;
				DrawRows(num34, num35, num36, num37, num18, val2, val3);
				num50 = num34 + (double)num21;
				num51 = (num35 + num37) / 2.0;
				#if WINDOWS
				val9.FormatFlags = (StringFormatFlags)1;
				#endif
				if (G < B)
				{
					val2.DrawString(num91.ToString(), val7, (Brush)(object)val8, (float)num50, (float)num51, val9);
				}
				else
				{
					val2.DrawString("h", val7, (Brush)(object)val8, (float)num50, (float)num51, val9);
				}
				num34 = num126;
				num35 = num127;
				num36 = num34 - num99 * Math.Cos(num104);
				num37 = num35 + num99 * Math.Sin(num104);
				val2.DrawLine(val5, (float)num34, (float)num35, (float)num36, (float)num37);
				num36 = num34 - (double)num15 * Math.Sin(num104);
				num37 = num35 - (double)num15 * Math.Cos(num104);
				num117 = num36;
				num118 = num37;
				val2.DrawLine(val3, (float)num34, (float)num35, (float)num36, (float)num37);
				num34 = num126 - num99 * Math.Cos(num104);
				num35 = num127 + num99 * Math.Sin(num104);
				num36 = num34 - (double)num15 * Math.Sin(num104);
				num37 = num35 - (double)num15 * Math.Cos(num104);
				val2.DrawLine(val3, (float)num34, (float)num35, (float)num36, (float)num37);
				num34 = num117 + 5.0 * Math.Sin(num104);
				num35 = num118 + 5.0 * Math.Cos(num104);
				num36 += 5.0 * Math.Sin(num104);
				num37 += 5.0 * Math.Cos(num104);
				DrawRows(num36, num37, num34, num35, num18, val2, val3);
				num50 = (num34 + num36) / 2.0 - (double)num21;
				num51 = (num35 + num37) / 2.0 - (double)(num21 / 2);
				#if WINDOWS
				val9.FormatFlags = (StringFormatFlags)1;
				#endif
				val2.DrawString(num92.ToString(), val7, (Brush)(object)val8, (float)num50, (float)num51, val9);
				num34 = num126;
				num35 = num127;
				num36 = num34;
				num37 = num35 + num99 * Math.Sin(num104);
				val2.DrawLine(val3, (float)num34, (float)num35, (float)num36, (float)num37);
				double num128 = 3.0 * num99 * Math.Cos(num104) / 8.0;
				double num129 = 3.0 * num99 * Math.Sin(num104) / 8.0;
				num34 = num126;
				num35 = num127 + num129;
				num42 = num34 - num128;
				num43 = num35;
				num36 = (num34 + num42) / 2.0;
				num37 = (num35 + num43) / 2.0 + 5.0;
				val2.DrawBezier(val3, (float)num34, (float)num35, (float)num36, (float)num37, (float)num42, (float)num43, (float)num42, (float)num43);
				string text2 = Math.Round((Math.PI / 2.0 - num104) * 180.0 / Math.PI) + "°";
				val2.DrawString(text2, val7, (Brush)(object)val8, (float)(num36 + 3.0), (float)(num37 + (double)num21), val9);
				num34 = num126 - num99 * Math.Cos(num104);
				num35 = num127 + num99 * Math.Sin(num104);
				num36 = num34 - num100 * Math.Sin(num104);
				num37 = num35 - num100 * Math.Cos(num104);
				val2.DrawLine(val5, (float)num34, (float)num35, (float)num36, (float)num37);
				num36 = num34 - (double)num15 * Math.Cos(num104);
				num37 = num35 + (double)num15 * Math.Sin(num104);
				num117 = num36;
				num118 = num37;
				val2.DrawLine(val3, (float)num34, (float)num35, (float)num36, (float)num37);
				num34 = num126 - num99 * Math.Cos(num104) - num100 * Math.Sin(num104);
				num35 = num127 + num99 * Math.Sin(num104) - num100 * Math.Cos(num104);
				num36 = num34 - (double)num15 * Math.Cos(num104);
				num37 = num35 + (double)num15 * Math.Sin(num104);
				val2.DrawLine(val3, (float)num34, (float)num35, (float)num36, (float)num37);
				num34 = num117 + 5.0 * Math.Cos(num104);
				num35 = num118 - 5.0 * Math.Sin(num104);
				num36 += 5.0 * Math.Cos(num104);
				num37 -= 5.0 * Math.Sin(num104);
				DrawRows(num34, num35, num36, num37, num18, val2, val3);
				num50 = (num34 + num36) / 2.0 - (double)num21;
				num51 = (num35 + num37) / 2.0 + (double)(num21 / 2);
				#if WINDOWS
				val9.FormatFlags = (StringFormatFlags)1;
				#endif
				val2.DrawString(num93.ToString(), val7, (Brush)(object)val8, (float)num50, (float)num51, val9);
			}
			if (vyhid == "з виходом")
			{
				num19 = (double)(2 * num / 3 - num8 - num4) / (double)L;
				num9 = num26 + (int)(num22 * num18) + 70;
				int num130 = 0;
				if (vyhid3 == "круглий" || vyhid3 == "прямокутний")
				{
					num9 += 50;
					num130 += 50;
				}
				else if (vyhid2 == "круглий" || vyhid2 == "прямокутний")
				{
					num9 += 25;
					num130 += 25;
				}
				num9 += num15;
				if (num19 * (double)B + (double)(3 * num15) + (double)num130 > (double)num2 / 3.0)
				{
					num19 = ((double)num2 / 3.0 - (double)(3 * num15) - (double)num130) / (double)B;
				}
				num28 = (double)L * num19;
				num30 = (double)B * num19;
				double num40 = (double)d1 * num19;
				double num52 = (double)a1 * num19;
				double num53 = (double)b1 * num19;
				double num41 = (double)p1 * num19;
				double num38 = (double)f1 * num19;
				double num39 = (double)g1 * num19;
				double num60 = (double)d2 * num19;
				double num68 = (double)a2 * num19;
				double num69 = (double)b2 * num19;
				double num61 = (double)p2 * num19;
				double num58 = (double)f2 * num19;
				double num59 = (double)g2 * num19;
				double num75 = (double)d2 * num19;
				double num83 = (double)a3 * num19;
				double num84 = (double)b3 * num19;
				double num76 = (double)p3 * num19;
				double num73 = (double)f3 * num19;
				double num74 = (double)g3 * num19;
				num34 = num8;
				num35 = num9;
				num36 = num34 + num28;
				num37 = num35;
				val2.DrawLine(val4, (float)num34, (float)num35, (float)num36, (float)num37);
				num34 = num36;
				num35 = num37;
				num36 = num34;
				num37 = num35 + num30;
				val2.DrawLine(val4, (float)num34, (float)num35, (float)num36, (float)num37);
				num34 = num8;
				num35 = num9;
				num36 = num34;
				num37 = num35 + num30;
				val2.DrawLine(val4, (float)num34, (float)num35, (float)num36, (float)num37);
				num34 = num8;
				num35 = (double)num9 + num30;
				num36 = num34 + num28;
				num37 = num35;
				val2.DrawLine(val4, (float)num34, (float)num35, (float)num36, (float)num37);
				num34 = (double)num8 + num28;
				num35 = (double)num9 + num30;
				num36 = num34 + (double)num14;
				num37 = num35;
				double num119 = num36;
				double num120 = num37;
				val2.DrawLine(val3, (float)num34, (float)num35, (float)num36, (float)num37);
				num34 = (double)num8 + num28;
				num35 = num9;
				num36 = num34 + (double)num14;
				num37 = num35;
				double num117 = num36;
				double num118 = num37;
				val2.DrawLine(val3, (float)num34, (float)num35, (float)num36, (float)num37);
				num34 = num117 - 5.0;
				num35 = num118;
				num36 = num119 - 5.0;
				num37 = num120;
				DrawRows(num34, num35, num36, num37, num19, val2, val3);
				num50 = num34 + (double)num21;
				num51 = (num118 + num120) / 2.0;
				#if WINDOWS
				val9.FormatFlags = (StringFormatFlags)2;
				#endif
				val2.DrawString(B.ToString(), val7, (Brush)(object)val8, (float)num50, (float)num51, val9);
				num34 = num8;
				num35 = (double)num9 + num30;
				num36 = num34;
				num37 = num35 + (double)num14;
				num117 = num36;
				num118 = num37;
				val2.DrawLine(val3, (float)num34, (float)num35, (float)num36, (float)num37);
				num34 = (double)num8 + num28;
				num35 = (double)num9 + num30;
				num36 = num34;
				num37 = num35 + (double)num14;
				num119 = num36;
				num120 = num37;
				val2.DrawLine(val3, (float)num34, (float)num35, (float)num36, (float)num37);
				num34 = num117;
				num35 = num118 - 5.0;
				num36 = num119;
				num37 = num120 - 5.0;
				val2.DrawLine(val3, (float)num34, (float)num35, (float)num36, (float)num37);
				num50 = (num117 + num119) / 2.0;
				num51 = (num118 + num120) / 2.0 + (double)num21;
				#if WINDOWS
				val9.FormatFlags = (StringFormatFlags)1;
				#endif
				val2.DrawString(L.ToString(), val7, (Brush)(object)val8, (float)num50, (float)num51, val9);
				if (vyhid1 == "круглий")
				{
					val2.DrawEllipse(val4, (float)((double)num8 + num38 - num40 / 2.0), (float)((double)num9 + num39 - num40 / 2.0), (float)num40, (float)num40);
					num34 = num8;
					num35 = num9;
					num36 = num34;
					num37 = num35 - (double)num15;
					num117 = num36;
					num118 = num37;
					val2.DrawLine(val3, (float)num34, (float)num35, (float)num36, (float)num37);
					num34 = (double)num8 + num38;
					num35 = (double)num9 + num39;
					num36 = num34;
					num37 = num35 - num39 - (double)num15;
					num119 = num36;
					num120 = num37;
					val2.DrawLine(val3, (float)num34, (float)num35, (float)num36, (float)num37);
					num34 = num117;
					num35 = num118 + 5.0;
					num36 = num119;
					num37 = num120 + 5.0;
					val2.DrawLine(val3, (float)num34, (float)num35, (float)num36, (float)num37);
					DrawRows(num34, num35, num36, num37, num19, val2, val3);
					num50 = (num34 + num36) / 2.0;
					num51 = num37 - (double)num21;
					#if WINDOWS
					val9.FormatFlags = (StringFormatFlags)1;
					#endif
					val2.DrawString(f1.ToString(), val7, (Brush)(object)val8, (float)num50, (float)num51, val9);
					num34 = (double)num8 + num38;
					num35 = (double)num9 + num39;
					num36 = num34 + num40 / 2.0 + (double)num15;
					num37 = num35;
					num117 = num36;
					num118 = num37;
					val2.DrawLine(val3, (float)num34, (float)num35, (float)num36, (float)num37);
					num119 = num117;
					num120 = num9;
					num34 = num117 - 5.0;
					num35 = num118;
					num36 = num119 - 5.0;
					num37 = num120;
					DrawRows(num36, num37, num34, num35, num19, val2, val3);
					num50 = num34 + (double)num21;
					num51 = ((vyhid2 == "прямокутний") ? (num37 + 15.0) : ((num35 + num37) / 2.0));
					#if WINDOWS
					val9.FormatFlags = (StringFormatFlags)2;
					#endif
					val2.DrawString(g1.ToString(), val7, (Brush)(object)val8, (float)num50, (float)num51, val9);
					num34 = (double)num8 + num38 - num40 / 2.0;
					num35 = (double)num9 + num39;
					num36 = num34;
					num37 = num35 + num40 / 2.0 + (double)num15;
					num117 = num36;
					num118 = num37;
					val2.DrawLine(val3, (float)num34, (float)num35, (float)num36, (float)num37);
					num34 = (double)num8 + num38 + num40 / 2.0;
					num35 = (double)num9 + num39;
					num36 = num34;
					num37 = num35 + num40 / 2.0 + (double)num15;
					num119 = num36;
					num120 = num37;
					val2.DrawLine(val3, (float)num34, (float)num35, (float)num36, (float)num37);
					num34 = num117;
					num35 = num118 - 5.0;
					num36 = num119;
					num37 = num120 - 5.0;
					DrawRows(num34, num35, num36, num37, num19, val2, val3);
					num50 = (num34 + num36) / 2.0;
					num51 = num37 + (double)num21;
					#if WINDOWS
					val9.FormatFlags = (StringFormatFlags)1;
					#endif
					val2.DrawString(d1.ToString(), val7, (Brush)(object)val8, (float)num50, (float)num51, val9);
				}
				else if (vyhid1 == "прямокутний")
				{
					val2.DrawRectangle(val4, (float)((double)num8 + num38 - num52 / 2.0), (float)((double)num9 + num39 - num53 / 2.0), (float)num52, (float)num53);
					num34 = num8;
					num35 = num9;
					num36 = num34;
					num37 = num35 - (double)num15;
					num117 = num36;
					num118 = num37;
					val2.DrawLine(val3, (float)num34, (float)num35, (float)num36, (float)num37);
					num34 = (double)num8 + num38;
					num35 = (double)num9 + num39;
					num36 = num34;
					num37 = num35 - num39 - (double)num15;
					num119 = num36;
					num120 = num37;
					val2.DrawLine(val3, (float)num34, (float)num35, (float)num36, (float)num37);
					num34 = num117;
					num35 = num118 + 5.0;
					num36 = num119;
					num37 = num120 + 5.0;
					val2.DrawLine(val3, (float)num34, (float)num35, (float)num36, (float)num37);
					DrawRows(num34, num35, num36, num37, num19, val2, val3);
					num50 = (num34 + num36) / 2.0;
					num51 = num37 - (double)num21;
					#if WINDOWS
					val9.FormatFlags = (StringFormatFlags)1;
					#endif
					val2.DrawString(f1.ToString(), val7, (Brush)(object)val8, (float)num50, (float)num51, val9);
					num34 = (double)num8 + num38;
					num35 = (double)num9 + num39;
					num36 = num34 + num52 / 2.0 + (double)num15;
					num37 = num35;
					num117 = num36;
					num118 = num37;
					val2.DrawLine(val3, (float)num34, (float)num35, (float)num36, (float)num37);
					num119 = num117;
					num120 = num9;
					num34 = num117 - 5.0;
					num35 = num118;
					num36 = num119 - 5.0;
					num37 = num120;
					DrawRows(num36, num37, num34, num35, num19, val2, val3);
					num50 = num34 + (double)num21;
					num51 = ((vyhid2 == "прямокутний") ? (num37 + 10.0) : ((num35 + num37) / 2.0));
					#if WINDOWS
					val9.FormatFlags = (StringFormatFlags)2;
					#endif
					val2.DrawString(g1.ToString(), val7, (Brush)(object)val8, (float)num50, (float)num51, val9);
					num34 = (double)num8 + num38 - num52 / 2.0;
					num35 = (double)num9 + num39 + num53 / 2.0;
					num36 = num34;
					num37 = num35 + (double)num15;
					num117 = num36;
					num118 = num37;
					val2.DrawLine(val3, (float)num34, (float)num35, (float)num36, (float)num37);
					num34 = (double)num8 + num38 + num52 / 2.0;
					num35 = (double)num9 + num39 + num53 / 2.0;
					num36 = num34;
					num37 = num35 + (double)num15;
					num119 = num36;
					num120 = num37;
					val2.DrawLine(val3, (float)num34, (float)num35, (float)num36, (float)num37);
					num34 = num117;
					num35 = num118 - 5.0;
					num36 = num119;
					num37 = num120 - 5.0;
					DrawRows(num34, num35, num36, num37, num19, val2, val3);
					num50 = (num34 + num36) / 2.0;
					num51 = num37 + (double)num21;
					#if WINDOWS
					val9.FormatFlags = (StringFormatFlags)1;
					#endif
					val2.DrawString(a1.ToString(), val7, (Brush)(object)val8, (float)num50, (float)num51, val9);
					num34 = (double)num8 + num38 - num52 / 2.0;
					num35 = (double)num9 + num39 - num53 / 2.0;
					num36 = num34 - (double)num15;
					num37 = num35;
					num117 = num36;
					num118 = num37;
					val2.DrawLine(val3, (float)num34, (float)num35, (float)num36, (float)num37);
					num34 = (double)num8 + num38 - num52 / 2.0;
					num35 = (double)num9 + num39 + num53 / 2.0;
					num36 = num34 - (double)num15;
					num37 = num35;
					num119 = num36;
					num120 = num37;
					val2.DrawLine(val3, (float)num34, (float)num35, (float)num36, (float)num37);
					num34 = num117 + 5.0;
					num35 = num118;
					num36 = num119 + 5.0;
					num37 = num120;
					val2.DrawLine(val3, (float)num34, (float)num35, (float)num36, (float)num37);
					DrawRows(num34, num35, num36, num37, num19, val2, val3);
					num50 = num34 - (double)num21 - 3.0;
					num51 = (num35 + num37) / 2.0;
					#if WINDOWS
					val9.FormatFlags = (StringFormatFlags)2;
					#endif
					val2.DrawString(b1.ToString(), val7, (Brush)(object)val8, (float)num50, (float)num51, val9);
				}
				if (vyhid2 == "круглий")
				{
					val2.DrawEllipse(val4, (float)((double)num8 + num58 - num60 / 2.0), (float)((double)num9 + num59 - num60 / 2.0), (float)num60, (float)num60);
					num34 = num8;
					num35 = num9;
					num36 = num34;
					num37 = num35 - (double)num15 - 25.0;
					num117 = num36;
					num118 = num37;
					val2.DrawLine(val3, (float)num34, (float)num35, (float)num36, (float)num37);
					num34 = (double)num8 + num58;
					num35 = (double)num9 + num59;
					num36 = num34;
					num37 = num35 - num59 - (double)num15 - 25.0;
					num119 = num36;
					num120 = num37;
					val2.DrawLine(val3, (float)num34, (float)num35, (float)num36, (float)num37);
					num34 = num117;
					num35 = num118 + 5.0;
					num36 = num119;
					num37 = num120 + 5.0;
					val2.DrawLine(val3, (float)num34, (float)num35, (float)num36, (float)num37);
					num50 = (num34 + num36) / 2.0;
					num51 = num37 - (double)num21;
					#if WINDOWS
					val9.FormatFlags = (StringFormatFlags)1;
					#endif
					val2.DrawString(f2.ToString(), val7, (Brush)(object)val8, (float)num50, (float)num51, val9);
					num34 = (double)num8 + num58;
					num35 = (double)num9 + num59;
					num36 = num34 + num60 / 2.0 + (double)num15;
					num37 = num35;
					num117 = num36;
					num118 = num37;
					val2.DrawLine(val3, (float)num34, (float)num35, (float)num36, (float)num37);
					num119 = num117;
					num120 = num9;
					num34 = num117 - 5.0;
					num35 = num118;
					num36 = num119 - 5.0;
					num37 = num120;
					DrawRows(num36, num37, num34, num35, num19, val2, val3);
					num50 = num34 + (double)num21;
					num51 = (num35 + num37) / 2.0;
					#if WINDOWS
					val9.FormatFlags = (StringFormatFlags)2;
					#endif
					val2.DrawString(g2.ToString(), val7, (Brush)(object)val8, (float)num50, (float)num51, val9);
					num34 = (double)num8 + num58 - num60 / 2.0;
					num35 = (double)num9 + num59;
					num36 = num34;
					num37 = num35 + num60 / 2.0 + (double)num15;
					num117 = num36;
					num118 = num37;
					val2.DrawLine(val3, (float)num34, (float)num35, (float)num36, (float)num37);
					num34 = (double)num8 + num58 + num60 / 2.0;
					num35 = (double)num9 + num59;
					num36 = num34;
					num37 = num35 + num60 / 2.0 + (double)num15;
					num119 = num36;
					num120 = num37;
					val2.DrawLine(val3, (float)num34, (float)num35, (float)num36, (float)num37);
					num34 = num117;
					num35 = num118 - 5.0;
					num36 = num119;
					num37 = num120 - 5.0;
					DrawRows(num34, num35, num36, num37, num19, val2, val3);
					num50 = (num34 + num36) / 2.0;
					num51 = num37 + (double)num21 + 3.0;
					#if WINDOWS
					val9.FormatFlags = (StringFormatFlags)1;
					#endif
					val2.DrawString(d2.ToString(), val7, (Brush)(object)val8, (float)num50, (float)num51, val9);
				}
				else if (vyhid2 == "прямокутний")
				{
					val2.DrawRectangle(val4, (float)((double)num8 + num58 - num68 / 2.0), (float)((double)num9 + num59 - num69 / 2.0), (float)num68, (float)num69);
					num34 = num8;
					num35 = num9;
					num36 = num34;
					num37 = num35 - (double)num15 - 25.0;
					num117 = num36;
					num118 = num37;
					val2.DrawLine(val3, (float)num34, (float)num35, (float)num36, (float)num37);
					num34 = (double)num8 + num58;
					num35 = (double)num9 + num59;
					num36 = num34;
					num37 = num35 - num59 - (double)num15 - 25.0;
					num119 = num36;
					num120 = num37;
					val2.DrawLine(val3, (float)num34, (float)num35, (float)num36, (float)num37);
					num34 = num117;
					num35 = num118 + 5.0;
					num36 = num119;
					num37 = num120 + 5.0;
					DrawRows(num34, num35, num36, num37, num19, val2, val3);
					num50 = (num34 + num36) / 2.0;
					num51 = num37 - (double)num21;
					#if WINDOWS
					val9.FormatFlags = (StringFormatFlags)1;
					#endif
					val2.DrawString(f2.ToString(), val7, (Brush)(object)val8, (float)num50, (float)num51, val9);
					num34 = (double)num8 + num58;
					num35 = (double)num9 + num59;
					num36 = num34 + num68 / 2.0 + (double)num15;
					num37 = num35;
					num117 = num36;
					num118 = num37;
					val2.DrawLine(val3, (float)num34, (float)num35, (float)num36, (float)num37);
					num119 = num117;
					num120 = num9;
					num34 = num117 - 5.0;
					num35 = num118;
					num36 = num119 - 5.0;
					num37 = num120;
					DrawRows(num36, num37, num34, num35, num19, val2, val3);
					num50 = num34 + (double)num21;
					num51 = ((vyhid3 == "прямокутний") ? (num37 + 15.0) : ((num35 + num37) / 2.0));
					#if WINDOWS
					val9.FormatFlags = (StringFormatFlags)2;
					#endif
					val2.DrawString(g2.ToString(), val7, (Brush)(object)val8, (float)num50, (float)num51, val9);
					num34 = (double)num8 + num58 - num68 / 2.0;
					num35 = (double)num9 + num59 + num69 / 2.0;
					num36 = num34;
					num37 = num35 + (double)num15;
					num117 = num36;
					num118 = num37;
					val2.DrawLine(val3, (float)num34, (float)num35, (float)num36, (float)num37);
					num34 = (double)num8 + num58 + num68 / 2.0;
					num35 = (double)num9 + num59 + num69 / 2.0;
					num36 = num34;
					num37 = num35 + (double)num15;
					num119 = num36;
					num120 = num37;
					val2.DrawLine(val3, (float)num34, (float)num35, (float)num36, (float)num37);
					num34 = num117;
					num35 = num118 - 5.0;
					num36 = num119;
					num37 = num120 - 5.0;
					DrawRows(num34, num35, num36, num37, num19, val2, val3);
					num50 = (num34 + num36) / 2.0;
					num51 = num37 + (double)num21;
					#if WINDOWS
					val9.FormatFlags = (StringFormatFlags)1;
					#endif
					val2.DrawString(a2.ToString(), val7, (Brush)(object)val8, (float)num50, (float)num51, val9);
					num34 = (double)num8 + num58 - num68 / 2.0;
					num35 = (double)num9 + num59 - num69 / 2.0;
					num36 = num34 - (double)num15;
					num37 = num35;
					num117 = num36;
					num118 = num37;
					val2.DrawLine(val3, (float)num34, (float)num35, (float)num36, (float)num37);
					num34 = (double)num8 + num58 - num68 / 2.0;
					num35 = (double)num9 + num59 + num69 / 2.0;
					num36 = num34 - (double)num15;
					num37 = num35;
					num119 = num36;
					num120 = num37;
					val2.DrawLine(val3, (float)num34, (float)num35, (float)num36, (float)num37);
					num34 = num117 + 5.0;
					num35 = num118;
					num36 = num119 + 5.0;
					num37 = num120;
					DrawRows(num34, num35, num36, num37, num19, val2, val3);
					num50 = num34 - (double)num21 - 3.0;
					num51 = (num35 + num37) / 2.0;
					#if WINDOWS
					val9.FormatFlags = (StringFormatFlags)2;
					#endif
					val2.DrawString(b2.ToString(), val7, (Brush)(object)val8, (float)num50, (float)num51, val9);
				}
				if (vyhid3 == "круглий")
				{
					val2.DrawEllipse(val4, (float)((double)num8 + num73 - num75 / 2.0), (float)((double)num9 + num74 - num75 / 2.0), (float)num75, (float)num75);
					num34 = num8;
					num35 = num9;
					num36 = num34;
					num37 = num35 - (double)num15 - 50.0;
					num117 = num36;
					num118 = num37;
					val2.DrawLine(val3, (float)num34, (float)num35, (float)num36, (float)num37);
					num34 = (double)num8 + num73;
					num35 = (double)num9 + num74;
					num36 = num34;
					num37 = num35 - num74 - (double)num15 - 50.0;
					num119 = num36;
					num120 = num37;
					val2.DrawLine(val3, (float)num34, (float)num35, (float)num36, (float)num37);
					num34 = num117;
					num35 = num118 + 5.0;
					num36 = num119;
					num37 = num120 + 5.0;
					DrawRows(num34, num35, num36, num37, num19, val2, val3);
					num50 = (num34 + num36) / 2.0;
					num51 = num37 - (double)num21;
					#if WINDOWS
					val9.FormatFlags = (StringFormatFlags)1;
					#endif
					val2.DrawString(f3.ToString(), val7, (Brush)(object)val8, (float)num50, (float)num51, val9);
					num34 = (double)num8 + num73;
					num35 = (double)num9 + num74;
					num36 = num34 + num75 / 2.0 + (double)num15;
					num37 = num35;
					num117 = num36;
					num118 = num37;
					val2.DrawLine(val3, (float)num34, (float)num35, (float)num36, (float)num37);
					num119 = num117;
					num120 = num9;
					num34 = num117 - 5.0;
					num35 = num118;
					num36 = num119 - 5.0;
					num37 = num120;
					DrawRows(num36, num37, num34, num35, num19, val2, val3);
					num50 = num34 + (double)num21;
					num51 = (num35 + num37) / 2.0;
					#if WINDOWS
					val9.FormatFlags = (StringFormatFlags)2;
					#endif
					val2.DrawString(g3.ToString(), val7, (Brush)(object)val8, (float)num50, (float)num51, val9);
					num34 = (double)num8 + num73 - num75 / 2.0;
					num35 = (double)num9 + num74;
					num36 = num34;
					num37 = num35 + num75 / 2.0 + (double)num15;
					num117 = num36;
					num118 = num37;
					val2.DrawLine(val3, (float)num34, (float)num35, (float)num36, (float)num37);
					num34 = (double)num8 + num73 + num75 / 2.0;
					num35 = (double)num9 + num74;
					num36 = num34;
					num37 = num35 + num75 / 2.0 + (double)num15;
					num119 = num36;
					num120 = num37;
					val2.DrawLine(val3, (float)num34, (float)num35, (float)num36, (float)num37);
					num34 = num117;
					num35 = num118 - 5.0;
					num36 = num119;
					num37 = num120 - 5.0;
					DrawRows(num34, num35, num36, num37, num19, val2, val3);
					num50 = (num34 + num36) / 2.0;
					num51 = num37 + (double)num21 + 3.0;
					#if WINDOWS
					val9.FormatFlags = (StringFormatFlags)1;
					#endif
					val2.DrawString(d3.ToString(), val7, (Brush)(object)val8, (float)num50, (float)num51, val9);
				}
				else if (vyhid3 == "прямокутний")
				{
					val2.DrawRectangle(val4, (float)((double)num8 + num73 - num83 / 2.0), (float)((double)num9 + num74 - num84 / 2.0), (float)num83, (float)num84);
					num34 = num8;
					num35 = num9;
					num36 = num34;
					num37 = num35 - (double)num15 - 50.0;
					num117 = num36;
					num118 = num37;
					val2.DrawLine(val3, (float)num34, (float)num35, (float)num36, (float)num37);
					num34 = (double)num8 + num73;
					num35 = (double)num9 + num74;
					num36 = num34;
					num37 = num35 - num74 - (double)num15 - 50.0;
					num119 = num36;
					num120 = num37;
					val2.DrawLine(val3, (float)num34, (float)num35, (float)num36, (float)num37);
					num34 = num117;
					num35 = num118 + 5.0;
					num36 = num119;
					num37 = num120 + 5.0;
					DrawRows(num34, num35, num36, num37, num19, val2, val3);
					num50 = (num34 + num36) / 2.0;
					num51 = num37 - (double)num21;
					#if WINDOWS
					val9.FormatFlags = (StringFormatFlags)1;
					#endif
					val2.DrawString(f3.ToString(), val7, (Brush)(object)val8, (float)num50, (float)num51, val9);
					num34 = (double)num8 + num73;
					num35 = (double)num9 + num74;
					num36 = num34 + num83 / 2.0 + (double)num15;
					num37 = num35;
					num117 = num36;
					num118 = num37;
					val2.DrawLine(val3, (float)num34, (float)num35, (float)num36, (float)num37);
					num119 = num117;
					num120 = num9;
					num34 = num117 - 5.0;
					num35 = num118;
					num36 = num119 - 5.0;
					num37 = num120;
					DrawRows(num36, num37, num34, num35, num19, val2, val3);
					num50 = num34 + (double)num21;
					num51 = (num35 + num37) / 2.0;
					#if WINDOWS
					val9.FormatFlags = (StringFormatFlags)2;
					#endif
					val2.DrawString(g3.ToString(), val7, (Brush)(object)val8, (float)num50, (float)num51, val9);
					num34 = (double)num8 + num73 - num83 / 2.0;
					num35 = (double)num9 + num74 + num84 / 2.0;
					num36 = num34;
					num37 = num35 + (double)num15;
					num117 = num36;
					num118 = num37;
					val2.DrawLine(val3, (float)num34, (float)num35, (float)num36, (float)num37);
					num34 = (double)num8 + num73 + num83 / 2.0;
					num35 = (double)num9 + num74 + num84 / 2.0;
					num36 = num34;
					num37 = num35 + (double)num15;
					num119 = num36;
					num120 = num37;
					val2.DrawLine(val3, (float)num34, (float)num35, (float)num36, (float)num37);
					num34 = num117;
					num35 = num118 - 5.0;
					num36 = num119;
					num37 = num120 - 5.0;
					DrawRows(num34, num35, num36, num37, num19, val2, val3);
					num50 = (num34 + num36) / 2.0;
					num51 = num37 + (double)num21 + 3.0;
					#if WINDOWS
					val9.FormatFlags = (StringFormatFlags)1;
					#endif
					val2.DrawString(a3.ToString(), val7, (Brush)(object)val8, (float)num50, (float)num51, val9);
					num34 = (double)num8 + num73 - num83 / 2.0;
					num35 = (double)num9 + num74 - num84 / 2.0;
					num36 = num34 - (double)num15;
					num37 = num35;
					num117 = num36;
					num118 = num37;
					val2.DrawLine(val3, (float)num34, (float)num35, (float)num36, (float)num37);
					num34 = (double)num8 + num73 - num83 / 2.0;
					num35 = (double)num9 + num74 + num84 / 2.0;
					num36 = num34 - (double)num15;
					num37 = num35;
					num119 = num36;
					num120 = num37;
					val2.DrawLine(val3, (float)num34, (float)num35, (float)num36, (float)num37);
					num34 = num117 + 5.0;
					num35 = num118;
					num36 = num119 + 5.0;
					num37 = num120;
					DrawRows(num34, num35, num36, num37, num19, val2, val3);
					num50 = num34 - (double)num21 - 3.0;
					num51 = (num35 + num37) / 2.0;
					#if WINDOWS
					val9.FormatFlags = (StringFormatFlags)2;
					#endif
					val2.DrawString(b3.ToString(), val7, (Brush)(object)val8, (float)num50, (float)num51, val9);
				}
			}
			num12 = num3;
			num13 = num26 + (int)(num22 * num18) + 70;
			if (vyhid == "з виходом")
			{
				num13 += num2 / 3 + 20;
			}
			int num131 = 10;
			int num132 = 0;
			Font val10 = new Font("Arial", (float)num131);
			StringFormat val11 = new StringFormat();
			val11.LineAlignment = (StringAlignment)0;
			val11.Alignment = (StringAlignment)0;
			if (zhyrFiltr == "так")
			{
				for (int i = 0; i < nFiltr; i++)
				{
					switch (i)
					{
					case 0:
						val2.DrawString("Ширина першого жирфільтра: " + kFiltr[0] + "мм * 2шт", val10, (Brush)(object)val8, (float)num12, (float)(num13 + num132), val11);
						break;
					case 1:
						val2.DrawString("Ширина другого жирфільтра: " + kFiltr[1] + "мм * 2шт", val10, (Brush)(object)val8, (float)num12, (float)(num13 + num132), val11);
						break;
					case 2:
						val2.DrawString("Ширина третього жирфільтра: " + kFiltr[2] + "мм * 2шт", val10, (Brush)(object)val8, (float)num12, (float)(num13 + num132), val11);
						break;
					}
					num132 += num131 + 8;
					if (num13 + num132 > num2 - num7)
					{
						num12 = num3 + num / 2;
						num132 = 0;
					}
				}
				if (nFiltr == 1)
				{
					val2.DrawString("Довжина жирфільтра: " + l + "мм", val10, (Brush)(object)val8, (float)num12, (float)(num13 + num132), val11);
				}
				else
				{
					val2.DrawString("Довжина жирфільтрів: " + l + "мм", val10, (Brush)(object)val8, (float)num12, (float)(num13 + num132), val11);
				}
				num132 += num131 + 8;
				if (num13 + num132 > num2 - num7)
				{
					num12 = num3 + num / 2;
					num132 = 0;
				}
			}
			val2.DrawString("Матеріал зонта: " + zontMaterial, val10, (Brush)(object)val8, (float)num12, (float)(num13 + num132), val11);
			num132 += num131 + 8;
			if (num13 + num132 > num2 - num7)
			{
				num12 = num3 + num / 2;
				num132 = 0;
			}
			val2.DrawString("Товщина металу зонта: " + tovchynaMetaluZont + "мм", val10, (Brush)(object)val8, (float)num12, (float)(num13 + num132), val11);
			num132 += num131 + 8;
			if (num13 + num132 > num2 - num7)
			{
				num12 = num3 + num / 2;
				num132 = 0;
			}
			val2.DrawString("З'єднання: " + connection, val10, (Brush)(object)val8, (float)num12, (float)(num13 + num132), val11);
			num132 += num131 + 8;
			if (num13 + num132 > num2 - num7)
			{
				num12 = num3 + num / 2;
				num132 = 0;
			}
			val2.DrawString("Трубка зливу 1/2': " + zlyv, val10, (Brush)(object)val8, (float)num12, (float)(num13 + num132), val11);
			num132 += num131 + 8;
			if (num13 + num132 > num2 - num7)
			{
				num12 = num3 + num / 2;
				num132 = 0;
			}
			val2.DrawString("Кріплення: " + fastening, val10, (Brush)(object)val8, (float)num12, (float)(num13 + num132), val11);
			if (fastening == "так")
			{
				num132 += num131 + 8;
				if (num13 + num132 > num2 - num7)
				{
					num12 = num3 + num / 2;
					num132 = 0;
				}
				val2.DrawString("Тип кріплення: " + typeFastening, val10, (Brush)(object)val8, (float)num12, (float)(num13 + num132), val11);
			}
			if (vyhid == "з виходом")
			{
				if (vyhid1 == "круглий" || vyhid1 == "прямокутний")
				{
					num132 += num131 + 8;
					if (num13 + num132 > num2 - num7)
					{
						num12 = num3 + num / 2;
						num132 = 0;
					}
					val2.DrawString("Тип виходу 1: " + typVyhid1, val10, (Brush)(object)val8, (float)num12, (float)(num13 + num132), val11);
					if (typVyhid1 == "фланець")
					{
						num132 += num131 + 8;
						if (num13 + num132 > num2 - num7)
						{
							num12 = num3 + num / 2;
							num132 = 0;
						}
						val2.DrawString("Тип профілю для виходу 1: " + profilType1, val10, (Brush)(object)val8, (float)num12, (float)(num13 + num132), val11);
					}
				}
				if (vyhid2 == "круглий" || vyhid2 == "прямокутний")
				{
					num132 += num131 + 8;
					if (num13 + num132 > num2 - num7)
					{
						num12 = num3 + num / 2;
						num132 = 0;
					}
					val2.DrawString("Тип виходу 2: " + typVyhid2, val10, (Brush)(object)val8, (float)num12, (float)(num13 + num132), val11);
					if (typVyhid2 == "фланець")
					{
						num132 += num131 + 8;
						if (num13 + num132 > num2 - num7)
						{
							num12 = num3 + num / 2;
							num132 = 0;
						}
						val2.DrawString("Тип профілю для виходу 2: " + profilType2, val10, (Brush)(object)val8, (float)num12, (float)(num13 + num132), val11);
					}
				}
				if (vyhid3 == "круглий" || vyhid3 == "прямокутний")
				{
					num132 += num131 + 8;
					if (num13 + num132 > num2 - num7)
					{
						num12 = num3 + num / 2;
						num132 = 0;
					}
					val2.DrawString("Тип виходу 3: " + typVyhid3, val10, (Brush)(object)val8, (float)num12, (float)(num13 + num132), val11);
					if (typVyhid3 == "фланець")
					{
						num132 += num131 + 8;
						if (num13 + num132 > num2 - num7)
						{
							num12 = num3 + num / 2;
							num132 = 0;
						}
						val2.DrawString("Тип профілю для виходу 3: " + profilType3, val10, (Brush)(object)val8, (float)num12, (float)(num13 + num132), val11);
					}
				}
			}
			if (zhyrFiltr == "так")
			{
				num132 += num131 + 8;
				if (num13 + num132 > num2 - num7)
				{
					num12 = num3 + num / 2;
					num132 = 0;
				}
				val2.DrawString("Матеріал жирфільтра: " + zhyrFiltrMaterial, val10, (Brush)(object)val8, (float)num12, (float)(num13 + num132), val11);
				num132 += num131 + 8;
				if (num13 + num132 > num2 - num7)
				{
					num12 = num3 + num / 2;
					num132 = 0;
				}
				val2.DrawString("Товщина металу жирфільтра: " + tovchynaMetaluFiltr + "мм", val10, (Brush)(object)val8, (float)num12, (float)(num13 + num132), val11);
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

	public static void DrawRows(double x1, double y1, double x2, double y2, double mult, Graphics g, Pen thinPen)
	{
		double num = 30.0;
		double num2 = 15.0;
		double[] array = new double[8];
		double num3 = ((x2 == x1) ? (Math.PI / 2.0) : Math.Atan((y2 - y1) / (x2 - x1)));
		double num4 = Math.Atan(num2 / num);
		double num5 = mult * Math.Sqrt(num * num + num2 * num2);
		double num6 = num3 + num4;
		double num7 = num3 - num4;
		array[0] = x1 + Math.Cos(num6) * num5;
		array[1] = y1 + Math.Sin(num6) * num5;
		array[2] = x1 + Math.Cos(num7) * num5;
		array[3] = y1 + Math.Sin(num7) * num5;
		array[4] = x2 - Math.Cos(num6) * num5;
		array[5] = y2 - Math.Sin(num6) * num5;
		array[6] = x2 - Math.Cos(num7) * num5;
		array[7] = y2 - Math.Sin(num7) * num5;
		g.DrawLine(thinPen, (float)x1, (float)y1, (float)array[0], (float)array[1]);
		g.DrawLine(thinPen, (float)x1, (float)y1, (float)array[2], (float)array[3]);
		g.DrawLine(thinPen, (float)x2, (float)y2, (float)array[4], (float)array[5]);
		g.DrawLine(thinPen, (float)x2, (float)y2, (float)array[6], (float)array[7]);
		g.DrawLine(thinPen, (float)x1, (float)y1, (float)x2, (float)y2);
	}

	public static double VolumeZontOstrivnyyTyp2(int L, int B, int H, int p1, int p2, int p3)
	{
		int num = ((p1 > p2) ? p1 : p2);
		if (p3 > num)
		{
			num = p3;
		}
		return Math.Round((double)L * (double)B * (double)(H + num) / 1000000.0) / 1000.0;
	}
}
