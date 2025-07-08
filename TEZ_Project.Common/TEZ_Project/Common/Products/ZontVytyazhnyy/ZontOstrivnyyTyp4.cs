using System;
using System.Drawing;
using System.Globalization;
using System.IO;
using TEZ_Project.Common.Helpers;

namespace TEZ_Project.Common.Products.ZontVytyazhnyy;

public class ZontOstrivnyyTyp4
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

	public static double[,] MaterialZontOstrivnyyTyp4(string name, int implementation, int L, int B, int H, int number, string markaStaliZont, string tovchynaMetaluZont, string connection, string zlyv, string fastening, string typeFastening, string vyhid, string vyhid1, int d1, int a1, int b1, int p1, int f1, int g1, string typVyhid1, string profilType1, string vyhid2, int d2, int a2, int b2, int p2, int f2, int g2, string typVyhid2, string profilType2, string vyhid3, int d3, int a3, int b3, int p3, int f3, int g3, string typVyhid3, string profilType3, string zhyrFiltr, int G, string markaStaliFiltr, string tovchynaMetaluFiltr)
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
		double num11 = ((connection == "зварка") ? 12 : 15);
		double num12 = 100.0;
		double num13 = 20.0;
		double num14 = 20.0;
		double num15 = 20.0;
		double num16 = 60.0;
		double num17 = 70.0;
		double num18 = 10.0;
		double num19 = 20.0;
		double num20 = 40.0;
		double num21 = 60.0;
		double num22 = 70.0;
		double num23 = 10.0;
		double num24 = 45.0;
		double num25 = 35.0;
		double num26 = 20.0;
		double num27 = 110.0;
		double num28 = 25.0;
		double num29 = 55.0;
		double num30 = 15.0;
		double num31 = 40.0;
		if (name == "ЗВО-4")
		{
			if (implementation == 1)
			{
				double num32 = num11 + (double)H + 20.0 + 10.0;
				num5 = (2.0 * num11 + (double)B) * num32;
				if (B > 2500)
				{
					num5 += 40.0 * num32;
				}
				else if (B > 1250)
				{
					num5 += 20.0 * num32;
				}
				num5 *= 2.0;
				double num33 = 2.0 * (double)(30 + H) + (double)B;
				if (num33 > 2460.0)
				{
					num33 += 40.0;
				}
				else if (num33 > 1230.0)
				{
					num33 += 20.0;
				}
				double num34 = ((L > 1230) ? 20 : 0);
				num34 += (double)((connection == "зварка") ? (L - 5) : L);
				num6 = num33 * num34;
				if (zhyrFiltr == "так")
				{
					num8 = (num27 + 2.0 * num28) * (double)(L - 5);
					num8 += (num29 + num30) * (double)(L - 10);
					num8 += 2.0 * (num15 + num16 + num17 + num18) * (double)(L - 5);
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
					num9 = 2.0 * (kk + 42.5) * (double)ZontOstrivnyyTyp4.l + 1700.0;
				}
			}
			else
			{
				double num35 = 20.0;
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
					num35 = kk;
				}
				double num32 = num11 + (double)H + num35 + 10.0;
				num5 = (2.0 * num11 + (double)B) * num32;
				if (B > 2500)
				{
					num5 += 40.0 * num32;
				}
				else if (B > 1250)
				{
					num5 += 20.0 * num32;
				}
				num5 *= 2.0;
				double num33 = 2.0 * (double)(40 + H) + (double)B;
				if (num33 > 2460.0)
				{
					num33 += 40.0;
				}
				else if (num33 > 1230.0)
				{
					num33 += 20.0;
				}
				double num34 = ((L > 1230) ? 20 : 0);
				num34 += (double)((connection == "зварка") ? (L - 5) : L);
				num6 = num33 * num34;
				if (zhyrFiltr == "так")
				{
					num8 = 80.0 * (double)(L - 5);
					num8 += (num29 + num30) * (double)(L - 10);
					num9 = 0.0;
				}
			}
		}
		else if (implementation == 1)
		{
			double num32 = num11 + (double)H + 20.0 + 10.0;
			num5 = (2.0 * num11 + (double)B) * num32;
			if (B > 2500)
			{
				num5 += 40.0 * num32;
			}
			else if (B > 1250)
			{
				num5 += 20.0 * num32;
			}
			num5 *= 2.0;
			double num33 = 2.0 * (double)(20 + H) + 20.0 + 100.0 + (double)B + 10.0;
			if (num33 > 2460.0)
			{
				num33 += 40.0;
			}
			else if (num33 > 1230.0)
			{
				num33 += 20.0;
			}
			double num34 = ((L > 1230) ? 20 : 0);
			num34 += (double)((connection == "зварка") ? (L - 5) : L);
			num6 = num33 * num34;
			if (zhyrFiltr == "так")
			{
				num8 = (num24 + num23 + num26) * (double)(L - 10);
				num8 += 2.0 * (num15 + num16 + num17 + num18) * (double)(L - 5);
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
				num9 = 2.0 * (kk + 42.5) * ((double)ZontOstrivnyyTyp4.l + 30.0) + 1700.0;
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
				for (int l = 0; l < nFiltr; l++)
				{
					kk += kFiltr[l];
				}
				kk = 0.5 * ((double)L - kk) + 15.0;
				num36 = kk;
			}
			double num32 = num11 + (double)H + num36 + 10.0;
			num5 = (2.0 * num11 + (double)B) * num32;
			if (B > 2500)
			{
				num5 += 40.0 * num32;
			}
			else if (B > 1250)
			{
				num5 += 20.0 * num32;
			}
			num5 *= 2.0;
			double num33 = 2.0 * (double)(40 + H) + (double)B;
			if (num33 > 2460.0)
			{
				num33 += 40.0;
			}
			else if (num33 > 1230.0)
			{
				num33 += 20.0;
			}
			double num34 = ((L > 1230) ? 20 : 0);
			num34 += (double)((connection == "зварка") ? (L - 5) : L);
			num6 = num33 * num34;
			num8 = 0.0;
			num9 = 0.0;
		}
		num7 = 0.0;
		if (vyhid == "з виходом")
		{
			num11 = 60.0;
			if (vyhid1 == "круглий")
			{
				double num37 = ((d1 < 560) ? 0.036 : ((d1 < 710) ? 0.043 : ((d1 >= 900) ? ((d1 < 1400) ? 0.086 : 0.11599999999999999) : 0.073)));
				num7 += (Math.PI * (double)d1 + num37) * ((double)p1 + num11);
			}
			if (vyhid2 == "круглий")
			{
				double num37 = ((d2 < 560) ? 0.036 : ((d2 < 710) ? 0.043 : ((d2 >= 900) ? ((d2 < 1400) ? 0.086 : 0.11599999999999999) : 0.073)));
				num7 += (Math.PI * (double)d2 + num37) * ((double)p2 + num11);
			}
			if (vyhid3 == "круглий")
			{
				double num37 = ((d3 < 560) ? 0.036 : ((d3 < 710) ? 0.043 : ((d3 >= 900) ? ((d3 < 1400) ? 0.086 : 0.11599999999999999) : 0.073)));
				num7 += (Math.PI * (double)d3 + num37) * ((double)p3 + num11);
			}
			if (vyhid1 == "прямокутний")
			{
				double num38 = 2.0 * (double)(a1 + 10 + b1 + 50);
				num11 = ((num38 <= 500.0) ? 60 : 30);
				num7 += (num38 + num11) * ((double)p1 + num11);
			}
			if (vyhid2 == "прямокутний")
			{
				double num38 = 2.0 * (double)(a2 + 10 + b2 + 50);
				num11 = ((num38 <= 500.0) ? 60 : 30);
				num7 += (num38 + num11) * ((double)p2 + num11);
			}
			if (vyhid3 == "прямокутний")
			{
				double num38 = 2.0 * (double)(a3 + 10 + b3 + 50);
				num11 = ((num38 <= 500.0) ? 60 : 30);
				num7 += (num38 + num11) * ((double)p3 + num11);
			}
		}
		array[num, 0] = (num5 + num6 + num7 + num8 + num9) * 1.05 / 1000000.0;
		materialSpendingCommercialOffer = array[num, 0];
		if (materialSpendingCommercialOffer < 0.005)
		{
			materialSpendingCommercialOffer = Math.Round(1000.0 * materialSpendingCommercialOffer) / 1000.0;
		}
		else
		{
			materialSpendingCommercialOffer = Math.Round(100.0 * materialSpendingCommercialOffer) / 100.0;
		}
		array[num, 1] = 0.05;
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
			int num39 = 7;
			int num40 = 50;
			int num41 = 2 * (2 * (int)Math.Round(((double)H - 2.0 * (double)num39) / (double)num40, MidpointRounding.AwayFromZero) + (int)Math.Round(((double)B - 2.0 * (double)num39) / (double)num40, MidpointRounding.AwayFromZero));
			if (zhyrFiltr == "так" && implementation == 1)
			{
				if (name == "ЗВП-4")
				{
					num41 += 4;
					num41 += (int)Math.Round(((double)L - 100.0) / 200.0, MidpointRounding.AwayFromZero);
				}
				else
				{
					num41 += 4;
					num41 += 2 * (int)Math.Round(((double)L - 100.0) / 200.0, MidpointRounding.AwayFromZero);
				}
			}
			if (zhyrFiltr == "так" && name == "ЗВО-4" && implementation == 2)
			{
				num41 += 4;
			}
			num++;
			materialName[num] = Consts2.zaklepkaKombinov48x6.MaterialName;
			array[num, 0] = num41;
			array[num, 4] = array[num, 0] * (double)number;
		}
		if (zhyrFiltr == "так")
		{
			double[] array2 = new double[6];
			for (int n = 0; n < nFiltr; n++)
			{
				array2 = FiltrZh.MaterialFiltrZh(kFiltr[n], ZontOstrivnyyTyp4.l, markaStaliFiltr, tovchynaMetaluFiltr, 2 * number);
				materialCost += FiltrZh.materialCost;
				num++;
				materialName[num] = FiltrZh.materialName[0];
				for (int num42 = 0; num42 < 6; num42++)
				{
					array[num, num42] = array2[num42];
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
					int num43 = 0;
					for (int num44 = 0; num44 < 5 && FlanetsKruglyj.materialName1[num44] != ""; num44++)
					{
						num43++;
					}
					for (int num45 = 0; num45 < num43; num45++)
					{
						materialName[num45 + num] = FlanetsKruglyj.materialName1[num45];
						for (int num46 = 0; num46 < 6; num46++)
						{
							array[num45 + num, num46] = array3[num45, num46];
						}
					}
					num += num43 - 1;
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
					int num47 = 0;
					for (int num48 = 0; num48 < 5 && FlanetsKruglyj.materialName1[num48] != ""; num48++)
					{
						num47++;
					}
					for (int num49 = 0; num49 < num47; num49++)
					{
						materialName[num49 + num] = FlanetsKruglyj.materialName1[num49];
						for (int num50 = 0; num50 < 6; num50++)
						{
							array[num49 + num, num50] = array3[num49, num50];
						}
					}
					num += num47 - 1;
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
					int num51 = 0;
					for (int num52 = 0; num52 < 5 && FlanetsKruglyj.materialName1[num52] != ""; num52++)
					{
						num51++;
					}
					for (int num53 = 0; num53 < num51; num53++)
					{
						materialName[num53 + num] = FlanetsKruglyj.materialName1[num53];
						for (int num54 = 0; num54 < 6; num54++)
						{
							array[num53 + num, num54] = array3[num53, num54];
						}
					}
					num += num51 - 1;
				}
			}
			if ((vyhid1 == "прямокутний" && typVyhid1 == "фланець") || (vyhid2 == "прямокутний" && typVyhid2 == "фланець") || (vyhid3 == "прямокутний" && typVyhid3 == "фланець"))
			{
				double[,] array4 = new double[2, 6];
				if (vyhid1 == "прямокутний" && typVyhid1 == "фланець")
				{
					array4 = MaterialFlanetsPrjamokutnyj(a1, b1, profilType1, number);
					materialCost += materialCost1;
					for (int num55 = 0; num55 < 2; num55++)
					{
						if (materialName1[num55] != "")
						{
							num++;
							materialName[num] = materialName1[num55];
							for (int num56 = 0; num56 < 6; num56++)
							{
								array[num, num56] = array4[num55, num56];
							}
						}
					}
				}
				if (vyhid2 == "прямокутний" && typVyhid2 == "фланець")
				{
					array4 = MaterialFlanetsPrjamokutnyj(a2, b2, profilType2, number);
					materialCost += materialCost1;
					for (int num57 = 0; num57 < 2; num57++)
					{
						if (materialName1[num57] != "")
						{
							num++;
							materialName[num] = materialName1[num57];
							for (int num58 = 0; num58 < 6; num58++)
							{
								array[num, num58] = array4[num57, num58];
							}
						}
					}
				}
				if (vyhid3 == "прямокутний" && typVyhid3 == "фланець")
				{
					array4 = MaterialFlanetsPrjamokutnyj(a3, b3, profilType3, number);
					materialCost += materialCost1;
					for (int num59 = 0; num59 < 2; num59++)
					{
						if (materialName1[num59] != "")
						{
							num++;
							materialName[num] = materialName1[num59];
							for (int num60 = 0; num60 < 6; num60++)
							{
								array[num, num60] = array4[num59, num60];
							}
						}
					}
				}
				num++;
			}
		}
		if (num > 0)
		{
			for (int num61 = 0; num61 < num; num61++)
			{
				for (int num62 = num61 + 1; num62 <= num; num62++)
				{
					if (!(materialName[num61] == materialName[num62]))
					{
						continue;
					}
					for (int num63 = 0; num63 < 6; num63++)
					{
						if (num63 == 1)
						{
							if (materialName[num61] == Consts2.lystStalnyj30.MaterialName)
							{
								array[num61, num63] = Math.Round((array[num61, num63] + array[num62, num63]) / 2.0);
							}
						}
						else
						{
							array[num61, num63] += array[num62, num63];
						}
						array[num62, num63] = 0.0;
					}
					materialName[num62] = "";
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

	public static void ZontOstrivnyyTyp4DrawDxf(string name, int implementation, int L, int B, int H, string connection, string zlyv, string vyhid, string vyhid1, int d1, int a1, int b1, int f1, int g1, string typVyhid1, string vyhid2, int d2, int a2, int b2, int f2, int g2, string typVyhid2, string vyhid3, int d3, int a3, int b3, int f3, int g3, string typVyhid3, string zhyrFiltr, int G, string filePath)
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
			int num6 = ((!(name == "ЗВО-4") && !(zhyrFiltr == "ні")) ? 1 : 2);
			double num7 = 1.0;
			double num8 = 20.0;
			double num9 = 20.0;
			double num10 = 112.0;
			double num11 = 31.0;
			double num12 = 62.0;
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
			kk = 0.5 * ((double)L - kk) - 5.0;
			double num13 = kk;
			double num14;
			double num15;
			if (connection == "зварка")
			{
				num14 = 12.0;
				num15 = 12.0;
			}
			else
			{
				num14 = 15.0;
				num15 = 15.0;
			}
			double num16 = 0.0;
			double num17 = 0.0;
			if (name == "ЗВО-4")
			{
				ushort num18;
				if (implementation == 1)
				{
					num2 = num15;
					num3 = num8 + num9;
					num4 = num2 + num9;
					num5 = num3 - num9;
					num18 = (ushort)(num + 1);
					num = num18;
					DrawLine(streamWriter, num18, text, num16 + num2, num17 + num3, num16 + num4, num17 + num5);
					num2 = num4;
					num3 = num5;
					num4 = num2;
					num5 = num3 - num8;
					num18 = (ushort)(num + 1);
					num = num18;
					DrawLine(streamWriter, num18, text, num16 + num2, num17 + num3, num16 + num4, num17 + num5);
					if (zhyrFiltr == "так")
					{
						num2 = num4;
						num3 = num5;
						num4 = num2 + ((double)B - 2.0 * num9 - num10) / 2.0;
						num5 = num3;
						num18 = (ushort)(num + 1);
						num = num18;
						DrawLine(streamWriter, num18, text, num16 + num2, num17 + num3, num16 + num4, num17 + num5);
						num2 = num4;
						num3 = num5;
						num4 = num2;
						num5 = num3 + num8;
						num18 = (ushort)(num + 1);
						num = num18;
						DrawLine(streamWriter, num18, text, num16 + num2, num17 + num3, num16 + num4, num17 + num5);
						num2 = num4;
						num3 = num5;
						num4 = num2 + num10;
						num5 = num3;
						num18 = (ushort)(num + 1);
						num = num18;
						DrawLine(streamWriter, num18, text, num16 + num2, num17 + num3, num16 + num4, num17 + num5);
						num = DrawZaklepka_2(streamWriter, num, text, connection, num2 + num16, num3 + num17, num4 + num16, num5 + num17, 0);
						num2 = num4;
						num3 = num5;
						num4 = num2;
						num5 = num3 - num8;
						num18 = (ushort)(num + 1);
						num = num18;
						DrawLine(streamWriter, num18, text, num16 + num2, num17 + num3, num16 + num4, num17 + num5);
						num2 = num4;
						num3 = num5;
						num4 = num2 + ((double)B - 2.0 * num9 - num10) / 2.0;
						num5 = num3;
						num18 = (ushort)(num + 1);
						num = num18;
						DrawLine(streamWriter, num18, text, num16 + num2, num17 + num3, num16 + num4, num17 + num5);
					}
					else
					{
						num2 = num4;
						num3 = num5;
						num4 = num2 + (double)B - 2.0 * num9;
						num5 = num3;
						num18 = (ushort)(num + 1);
						num = num18;
						DrawLine(streamWriter, num18, text, num16 + num2, num17 + num3, num16 + num4, num17 + num5);
					}
					num2 = num4;
					num3 = num5;
					num4 = num2;
					num5 = num3 + num8;
					num18 = (ushort)(num + 1);
					num = num18;
					DrawLine(streamWriter, num18, text, num16 + num2, num17 + num3, num16 + num4, num17 + num5);
					num2 = num4;
					num3 = num5;
					num4 = num2 + num9 + num15;
					num5 = num3 + num9 + num15;
					num18 = (ushort)(num + 1);
					num = num18;
					DrawLine(streamWriter, num18, text, num16 + num2, num17 + num3, num16 + num4, num17 + num5);
				}
				else
				{
					num2 = num15;
					num3 = num8 + num9;
					num4 = num2 + num11;
					num5 = num3;
					num18 = (ushort)(num + 1);
					num = num18;
					DrawLine(streamWriter, num18, text, num16 + num2, num17 + num3, num16 + num4, num17 + num5);
					num2 = num4;
					num3 = num5;
					num4 = num2;
					num5 = num3 - (num13 - num7 / 2.0);
					num18 = (ushort)(num + 1);
					num = num18;
					DrawLine(streamWriter, num18, text, num16 + num2, num17 + num3, num16 + num4, num17 + num5);
					num2 = num4;
					num3 = num5;
					num4 = num2 + num7;
					num5 = num3;
					num18 = (ushort)(num + 1);
					num = num18;
					DrawLine(streamWriter, num18, text, num16 + num2, num17 + num3, num16 + num4, num17 + num5);
					num2 = num4;
					num3 = num5;
					num4 = num2;
					num5 = num3 - num7;
					num18 = (ushort)(num + 1);
					num = num18;
					DrawLine(streamWriter, num18, text, num16 + num2, num17 + num3, num16 + num4, num17 + num5);
					num2 = num4;
					num3 = num5;
					num4 = num2 - num7;
					num5 = num3;
					num18 = (ushort)(num + 1);
					num = num18;
					DrawLine(streamWriter, num18, text, num16 + num2, num17 + num3, num16 + num4, num17 + num5);
					num2 = num4;
					num3 = num5;
					num4 = num2;
					num5 = num3 - num8;
					num18 = (ushort)(num + 1);
					num = num18;
					DrawLine(streamWriter, num18, text, num16 + num2, num17 + num3, num16 + num4, num17 + num5);
					if (zhyrFiltr == "так")
					{
						num2 = num4;
						num3 = num5;
						num4 = num2 + ((double)B - num12 - 2.0 * num11) / 2.0;
						num5 = num3;
						num18 = (ushort)(num + 1);
						num = num18;
						DrawLine(streamWriter, num18, text, num16 + num2, num17 + num3, num16 + num4, num17 + num5);
						num2 = num4;
						num3 = num5;
						num4 = num2;
						num5 = num3 + num8;
						num18 = (ushort)(num + 1);
						num = num18;
						DrawLine(streamWriter, num18, text, num16 + num2, num17 + num3, num16 + num4, num17 + num5);
						num2 = num4;
						num3 = num5;
						num4 = num2 + num12;
						num5 = num3;
						num18 = (ushort)(num + 1);
						num = num18;
						DrawLine(streamWriter, num18, text, num16 + num2, num17 + num3, num16 + num4, num17 + num5);
						num2 = num4;
						num3 = num5;
						num4 = num2;
						num5 = num3 - num8;
						num18 = (ushort)(num + 1);
						num = num18;
						DrawLine(streamWriter, num18, text, num16 + num2, num17 + num3, num16 + num4, num17 + num5);
						num2 = num4;
						num3 = num5;
						num4 = num2 + ((double)B - num12 - 2.0 * num11) / 2.0;
						num5 = num3;
						num18 = (ushort)(num + 1);
						num = num18;
						DrawLine(streamWriter, num18, text, num16 + num2, num17 + num3, num16 + num4, num17 + num5);
					}
					else
					{
						num2 = num4;
						num3 = num5;
						num4 = num2 + (double)B - 2.0 * num11;
						num5 = num3;
						num18 = (ushort)(num + 1);
						num = num18;
						DrawLine(streamWriter, num18, text, num16 + num2, num17 + num3, num16 + num4, num17 + num5);
					}
					num2 = num4;
					num3 = num5;
					num4 = num2;
					num5 = num3 + num8;
					num18 = (ushort)(num + 1);
					num = num18;
					DrawLine(streamWriter, num18, text, num16 + num2, num17 + num3, num16 + num4, num17 + num5);
					num2 = num4;
					num3 = num5;
					num4 = num2 - num7;
					num5 = num3;
					num18 = (ushort)(num + 1);
					num = num18;
					DrawLine(streamWriter, num18, text, num16 + num2, num17 + num3, num16 + num4, num17 + num5);
					num2 = num4;
					num3 = num5;
					num4 = num2;
					num5 = num3 + num7;
					num18 = (ushort)(num + 1);
					num = num18;
					DrawLine(streamWriter, num18, text, num16 + num2, num17 + num3, num16 + num4, num17 + num5);
					num2 = num4;
					num3 = num5;
					num4 = num2 + num7;
					num5 = num3;
					num18 = (ushort)(num + 1);
					num = num18;
					DrawLine(streamWriter, num18, text, num16 + num2, num17 + num3, num16 + num4, num17 + num5);
					num2 = num4;
					num3 = num5;
					num4 = num2;
					num5 = num3 + num13 - num7 / 2.0;
					num18 = (ushort)(num + 1);
					num = num18;
					DrawLine(streamWriter, num18, text, num16 + num2, num17 + num3, num16 + num4, num17 + num5);
					num2 = num4;
					num3 = num5;
					num4 = num2 + num11;
					num5 = num3;
					num18 = (ushort)(num + 1);
					num = num18;
					DrawLine(streamWriter, num18, text, num16 + num2, num17 + num3, num16 + num4, num17 + num5);
					num2 = num4;
					num3 = num5;
					num4 = num2 + num15;
					num5 = num3 + num15;
					num18 = (ushort)(num + 1);
					num = num18;
					DrawLine(streamWriter, num18, text, num16 + num2, num17 + num3, num16 + num4, num17 + num5);
				}
				num2 = num15;
				num3 = num8 + num9;
				num4 = num2 - num15;
				num5 = num3 + num15;
				num18 = (ushort)(num + 1);
				num = num18;
				DrawLine(streamWriter, num18, text, num16 + num2, num17 + num3, num16 + num4, num17 + num5);
				num2 = num4;
				num3 = num5;
				num4 = num2;
				num5 = num3 + (double)H - 2.0 * num15;
				num18 = (ushort)(num + 1);
				num = num18;
				DrawLine(streamWriter, num18, text, num16 + num2, num17 + num3, num16 + num4, num17 + num5);
				num = DrawZaklepka(streamWriter, num, text, connection, num2 + num16, num3 + num17, num4 + num16, num5 + num17, 1);
				num2 = num4;
				num3 = num5;
				num4 = num2 + num15 + num14;
				num5 = num3 + num15 + num14;
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
				num4 = num2 + num14 + num15;
				num5 = num3 - (num14 + num15);
				num18 = (ushort)(num + 1);
				num = num18;
				DrawLine(streamWriter, num18, text, num16 + num2, num17 + num3, num16 + num4, num17 + num5);
				num2 = num4;
				num3 = num5;
				num4 = num2;
				num5 = num3 - ((double)H - 2.0 * num15);
				num18 = (ushort)(num + 1);
				num = num18;
				DrawLine(streamWriter, num18, text, num16 + num2, num17 + num3, num16 + num4, num17 + num5);
				num = DrawZaklepka(streamWriter, num, text, connection, num2 + num16, num3 + num17, num4 + num16, num5 + num17, 1);
				double num19 = 10.5;
				double num20 = ((implementation == 2) ? 31 : 21);
				double num21 = ((connection == "зварка") ? (L - 5) : L);
				num16 = 0.0;
				num17 = -200.0 - num21;
				if (connection == "зварка" && implementation == 1)
				{
					num2 = num19 - num7 / 2.0 + num20 - num7;
					num3 = 0.0;
					num4 = num2 - (num20 - num7);
					num5 = num3 + (num20 - num7);
					num18 = (ushort)(num + 1);
					num = num18;
					DrawLine(streamWriter, num18, text, num16 + num2, num17 + num3, num16 + num4, num17 + num5);
					num2 = num4;
					num3 = num5;
					num4 = num2 - (num19 - num7 / 2.0);
					num5 = num3;
					num18 = (ushort)(num + 1);
					num = num18;
					DrawLine(streamWriter, num18, text, num16 + num2, num17 + num3, num16 + num4, num17 + num5);
					num2 = num4;
					num3 = num5;
					num4 = num2;
					num5 = num3 + num21 - 2.0 * (num20 - num7);
					num18 = (ushort)(num + 1);
					num = num18;
					DrawLine(streamWriter, num18, text, num16 + num2, num17 + num3, num16 + num4, num17 + num5);
					num2 = num4;
					num3 = num5;
					num4 = num2 + num19 - num7 / 2.0;
					num5 = num3;
					num18 = (ushort)(num + 1);
					num = num18;
					DrawLine(streamWriter, num18, text, num16 + num2, num17 + num3, num16 + num4, num17 + num5);
					num2 = num4;
					num3 = num5;
					num4 = num2 + num20 - num7;
					num5 = num3 + num20 - num7;
					num18 = (ushort)(num + 1);
					num = num18;
					DrawLine(streamWriter, num18, text, num16 + num2, num17 + num3, num16 + num4, num17 + num5);
				}
				else
				{
					num2 = num19 + num20 + num7 / 2.0;
					num3 = 0.0;
					num4 = num2;
					num5 = num3 + num7;
					num18 = (ushort)(num + 1);
					num = num18;
					DrawLine(streamWriter, num18, text, num16 + num2, num17 + num3, num16 + num4, num17 + num5);
					num2 = num4;
					num3 = num5;
					num4 = num2 - num7;
					num5 = num3;
					num18 = (ushort)(num + 1);
					num = num18;
					DrawLine(streamWriter, num18, text, num16 + num2, num17 + num3, num16 + num4, num17 + num5);
					num2 = num4;
					num3 = num5;
					num4 = num2;
					num5 = num3 - num7;
					num18 = (ushort)(num + 1);
					num = num18;
					DrawLine(streamWriter, num18, text, num16 + num2, num17 + num3, num16 + num4, num17 + num5);
					num2 = num4;
					num3 = num5;
					num4 = num2 - (num20 - num7);
					num5 = num3;
					num18 = (ushort)(num + 1);
					num = num18;
					DrawLine(streamWriter, num18, text, num16 + num2, num17 + num3, num16 + num4, num17 + num5);
					num2 = num4;
					num3 = num5;
					num4 = num2;
					num5 = num3 + num7;
					num18 = (ushort)(num + 1);
					num = num18;
					DrawLine(streamWriter, num18, text, num16 + num2, num17 + num3, num16 + num4, num17 + num5);
					num2 = num4;
					num3 = num5;
					num4 = num2 - num7;
					num5 = num3;
					num18 = (ushort)(num + 1);
					num = num18;
					DrawLine(streamWriter, num18, text, num16 + num2, num17 + num3, num16 + num4, num17 + num5);
					num2 = num4;
					num3 = num5;
					num4 = num2;
					num5 = num3 - num7;
					num18 = (ushort)(num + 1);
					num = num18;
					DrawLine(streamWriter, num18, text, num16 + num2, num17 + num3, num16 + num4, num17 + num5);
					num2 = num4;
					num3 = num5;
					num4 = num2 - (num19 - num7 / 2.0);
					num5 = num3;
					num18 = (ushort)(num + 1);
					num = num18;
					DrawLine(streamWriter, num18, text, num16 + num2, num17 + num3, num16 + num4, num17 + num5);
					num2 = num4;
					num3 = num5;
					num4 = num2;
					num5 = num3 + num21;
					num18 = (ushort)(num + 1);
					num = num18;
					DrawLine(streamWriter, num18, text, num16 + num2, num17 + num3, num16 + num4, num17 + num5);
					num2 = num4;
					num3 = num5;
					num4 = num2 + num19 - num7 / 2.0;
					num5 = num3;
					num18 = (ushort)(num + 1);
					num = num18;
					DrawLine(streamWriter, num18, text, num16 + num2, num17 + num3, num16 + num4, num17 + num5);
					num2 = num4;
					num3 = num5;
					num4 = num2;
					num5 = num3 - num7;
					num18 = (ushort)(num + 1);
					num = num18;
					DrawLine(streamWriter, num18, text, num16 + num2, num17 + num3, num16 + num4, num17 + num5);
					num2 = num4;
					num3 = num5;
					num4 = num2 + num7;
					num5 = num3;
					num18 = (ushort)(num + 1);
					num = num18;
					DrawLine(streamWriter, num18, text, num16 + num2, num17 + num3, num16 + num4, num17 + num5);
					num2 = num4;
					num3 = num5;
					num4 = num2;
					num5 = num3 + num7;
					num18 = (ushort)(num + 1);
					num = num18;
					DrawLine(streamWriter, num18, text, num16 + num2, num17 + num3, num16 + num4, num17 + num5);
					num2 = num4;
					num3 = num5;
					num4 = num2 + num20 - num7;
					num5 = num3;
					num18 = (ushort)(num + 1);
					num = num18;
					DrawLine(streamWriter, num18, text, num16 + num2, num17 + num3, num16 + num4, num17 + num5);
					num2 = num4;
					num3 = num5;
					num4 = num2;
					num5 = num3 - num7;
					num18 = (ushort)(num + 1);
					num = num18;
					DrawLine(streamWriter, num18, text, num16 + num2, num17 + num3, num16 + num4, num17 + num5);
					num2 = num4;
					num3 = num5;
					num4 = num2 + num7;
					num5 = num3;
					num18 = (ushort)(num + 1);
					num = num18;
					DrawLine(streamWriter, num18, text, num16 + num2, num17 + num3, num16 + num4, num17 + num5);
					num2 = num4;
					num3 = num5;
					num4 = num2;
					num5 = num3 + num7;
					num18 = (ushort)(num + 1);
					num = num18;
					DrawLine(streamWriter, num18, text, num16 + num2, num17 + num3, num16 + num4, num17 + num5);
				}
				num2 = num4;
				num3 = num5;
				num4 = num2 + (double)H;
				num5 = num3;
				num18 = (ushort)(num + 1);
				num = num18;
				DrawLine(streamWriter, num18, text, num16 + num2, num17 + num3, num16 + num4, num17 + num5);
				num18 = (ushort)(num + 1);
				num = num18;
				DrawLine(streamWriter, num18, text, num16 + num2, num17 + num3 - num21, num16 + num4, num17 + num5 - num21);
				num = DrawZaklepka_Top(streamWriter, num, text, connection, num2 + num16, num3 + num17, num4 + num16, num5 + num17, 1);
				num = DrawZaklepka_Top(streamWriter, num, text, connection, num2 + num16, num3 + num17 - num21, num4 + num16, num5 + num17 - num21, 0);
				num2 = num4;
				num3 = num5;
				num4 = num2;
				num5 = num3 - num7;
				num18 = (ushort)(num + 1);
				num = num18;
				DrawLine(streamWriter, num18, text, num16 + num2, num17 + num3, num16 + num4, num17 + num5);
				num18 = (ushort)(num + 1);
				num = num18;
				DrawLine(streamWriter, num18, text, num16 + num2, num17 + num3 - num21, num16 + num4, num17 + num5 - num21 + 2.0 * num7);
				num2 = num4;
				num3 = num5;
				num4 = num2 + num7;
				num5 = num3;
				num18 = (ushort)(num + 1);
				num = num18;
				DrawLine(streamWriter, num18, text, num16 + num2, num17 + num3, num16 + num4, num17 + num5);
				num18 = (ushort)(num + 1);
				num = num18;
				DrawLine(streamWriter, num18, text, num16 + num2, num17 + num3 - num21 + 2.0 * num7, num16 + num4, num17 + num5 - num21 + 2.0 * num7);
				num2 = num4;
				num3 = num5;
				num4 = num2;
				num5 = num3 + num7;
				num18 = (ushort)(num + 1);
				num = num18;
				DrawLine(streamWriter, num18, text, num16 + num2, num17 + num3, num16 + num4, num17 + num5);
				num18 = (ushort)(num + 1);
				num = num18;
				DrawLine(streamWriter, num18, text, num16 + num2, num17 + num3 - num21 + num7, num16 + num4, num17 + num5 - num21 + num7);
				if (implementation == 1 && zhyrFiltr == "так")
				{
					if (num6 == 1)
					{
						num = DrawZaklepka_Top_1(streamWriter, num, text, connection, num4 + num16, num5 + num17, num4 + num16, num5 - num21 + num17, 0, G - 10);
					}
					else
					{
						num = DrawZaklepka_Top_1(streamWriter, num, text, connection, num4 + num16, num5 + num17, num4 + num16, num5 - num21 + num17, 0, 0.5 * (double)(B - G) + 10.0);
						num = DrawZaklepka_Top_1(streamWriter, num, text, connection, num4 + num16, num5 + num17, num4 + num16, num5 - num21 + num17, 0, 0.5 * (double)(B + G) - 10.0);
					}
				}
				double num22 = num4 - num7 / 2.0;
				double num23 = num5 - num21;
				num2 = num4;
				num3 = num5;
				num4 = num2 + (double)B;
				num5 = num3;
				num18 = (ushort)(num + 1);
				num = num18;
				DrawLine(streamWriter, num18, text, num16 + num2, num17 + num3, num16 + num4, num17 + num5);
				num18 = (ushort)(num + 1);
				num = num18;
				DrawLine(streamWriter, num18, text, num16 + num2, num17 + num3 - num21, num16 + num4, num17 + num5 - num21);
				num = DrawZaklepka_Top(streamWriter, num, text, connection, num2 + num16, num3 + num17, num4 + num16, num5 + num17, 1);
				num = DrawZaklepka_Top(streamWriter, num, text, connection, num2 + num16, num3 + num17 - num21, num4 + num16, num5 + num17 - num21, 0);
				num2 = num4;
				num3 = num5;
				num4 = num2;
				num5 = num3 - num7;
				num18 = (ushort)(num + 1);
				num = num18;
				DrawLine(streamWriter, num18, text, num16 + num2, num17 + num3, num16 + num4, num17 + num5);
				num18 = (ushort)(num + 1);
				num = num18;
				DrawLine(streamWriter, num18, text, num16 + num2, num17 + num3 - num21, num16 + num4, num17 + num5 - num21 + 2.0 * num7);
				num2 = num4;
				num3 = num5;
				num4 = num2 + num7;
				num5 = num3;
				num18 = (ushort)(num + 1);
				num = num18;
				DrawLine(streamWriter, num18, text, num16 + num2, num17 + num3, num16 + num4, num17 + num5);
				num18 = (ushort)(num + 1);
				num = num18;
				DrawLine(streamWriter, num18, text, num16 + num2, num17 + num3 - num21 + 2.0 * num7, num16 + num4, num17 + num5 - num21 + 2.0 * num7);
				num2 = num4;
				num3 = num5;
				num4 = num2;
				num5 = num3 + num7;
				num18 = (ushort)(num + 1);
				num = num18;
				DrawLine(streamWriter, num18, text, num16 + num2, num17 + num3, num16 + num4, num17 + num5);
				num18 = (ushort)(num + 1);
				num = num18;
				DrawLine(streamWriter, num18, text, num16 + num2, num17 + num3 - num21 + num7, num16 + num4, num17 + num5 - num21 + num7);
				num2 = num4;
				num3 = num5;
				num4 = num2 + (double)H;
				num5 = num3;
				num18 = (ushort)(num + 1);
				num = num18;
				DrawLine(streamWriter, num18, text, num16 + num2, num17 + num3, num16 + num4, num17 + num5);
				num18 = (ushort)(num + 1);
				num = num18;
				DrawLine(streamWriter, num18, text, num16 + num2, num17 + num3 - num21, num16 + num4, num17 + num5 - num21);
				num = DrawZaklepka_Top(streamWriter, num, text, connection, num2 + num16, num3 + num17, num4 + num16, num5 + num17, 1);
				num = DrawZaklepka_Top(streamWriter, num, text, connection, num2 + num16, num3 + num17 - num21, num4 + num16, num5 + num17 - num21, 0);
				if (connection == "зварка" && implementation == 1)
				{
					num2 = num4;
					num3 = num5;
					num4 = num2 + (num20 - num7);
					num5 = num3 - (num20 - num7);
					num18 = (ushort)(num + 1);
					num = num18;
					DrawLine(streamWriter, num18, text, num16 + num2, num17 + num3, num16 + num4, num17 + num5);
					num2 = num4;
					num3 = num5;
					num4 = num2 + num19 - num7 / 2.0;
					num5 = num3;
					num18 = (ushort)(num + 1);
					num = num18;
					DrawLine(streamWriter, num18, text, num16 + num2, num17 + num3, num16 + num4, num17 + num5);
					num2 = num4;
					num3 = num5;
					num4 = num2;
					num5 = num3 - (num21 - 2.0 * (num20 - num7));
					num18 = (ushort)(num + 1);
					num = num18;
					DrawLine(streamWriter, num18, text, num16 + num2, num17 + num3, num16 + num4, num17 + num5);
					num2 = num4;
					num3 = num5;
					num4 = num2 - (num19 - num7 / 2.0);
					num5 = num3;
					num18 = (ushort)(num + 1);
					num = num18;
					DrawLine(streamWriter, num18, text, num16 + num2, num17 + num3, num16 + num4, num17 + num5);
					num2 = num4;
					num3 = num5;
					num4 = num2 - (num20 - num7);
					num5 = num3 - (num20 - num7);
					num18 = (ushort)(num + 1);
					num = num18;
					DrawLine(streamWriter, num18, text, num16 + num2, num17 + num3, num16 + num4, num17 + num5);
				}
				else
				{
					num2 = num4;
					num3 = num5;
					num4 = num2;
					num5 = num3 - num7;
					num18 = (ushort)(num + 1);
					num = num18;
					DrawLine(streamWriter, num18, text, num16 + num2, num17 + num3, num16 + num4, num17 + num5);
					num18 = (ushort)(num + 1);
					num = num18;
					DrawLine(streamWriter, num18, text, num16 + num2, num17 + num3 - num21, num16 + num4, num17 + num5 - num21 + 2.0 * num7);
					num2 = num4;
					num3 = num5;
					num4 = num2 + num7;
					num5 = num3;
					num18 = (ushort)(num + 1);
					num = num18;
					DrawLine(streamWriter, num18, text, num16 + num2, num17 + num3, num16 + num4, num17 + num5);
					num18 = (ushort)(num + 1);
					num = num18;
					DrawLine(streamWriter, num18, text, num16 + num2, num17 + num3 - num21 + 2.0 * num7, num16 + num4, num17 + num5 - num21 + 2.0 * num7);
					num2 = num4;
					num3 = num5;
					num4 = num2;
					num5 = num3 + num7;
					num18 = (ushort)(num + 1);
					num = num18;
					DrawLine(streamWriter, num18, text, num16 + num2, num17 + num3, num16 + num4, num17 + num5);
					num18 = (ushort)(num + 1);
					num = num18;
					DrawLine(streamWriter, num18, text, num16 + num2, num17 + num3 - num21 + num7, num16 + num4, num17 + num5 - num21 + num7);
					num2 = num4;
					num3 = num5;
					num4 = num2 + num20 - num7;
					num5 = num3;
					num18 = (ushort)(num + 1);
					num = num18;
					DrawLine(streamWriter, num18, text, num16 + num2, num17 + num3, num16 + num4, num17 + num5);
					num18 = (ushort)(num + 1);
					num = num18;
					DrawLine(streamWriter, num18, text, num16 + num2, num17 + num3 - num21, num16 + num4, num17 + num5 - num21);
					num2 = num4;
					num3 = num5;
					num4 = num2;
					num5 = num3 - num7;
					num18 = (ushort)(num + 1);
					num = num18;
					DrawLine(streamWriter, num18, text, num16 + num2, num17 + num3, num16 + num4, num17 + num5);
					num18 = (ushort)(num + 1);
					num = num18;
					DrawLine(streamWriter, num18, text, num16 + num2, num17 + num3 - num21, num16 + num4, num17 + num5 - num21 + 2.0 * num7);
					num2 = num4;
					num3 = num5;
					num4 = num2 + num7;
					num5 = num3;
					num18 = (ushort)(num + 1);
					num = num18;
					DrawLine(streamWriter, num18, text, num16 + num2, num17 + num3, num16 + num4, num17 + num5);
					num18 = (ushort)(num + 1);
					num = num18;
					DrawLine(streamWriter, num18, text, num16 + num2, num17 + num3 - num21 + 2.0 * num7, num16 + num4, num17 + num5 - num21 + 2.0 * num7);
					num2 = num4;
					num3 = num5;
					num4 = num2;
					num5 = num3 + num7;
					num18 = (ushort)(num + 1);
					num = num18;
					DrawLine(streamWriter, num18, text, num16 + num2, num17 + num3, num16 + num4, num17 + num5);
					num18 = (ushort)(num + 1);
					num = num18;
					DrawLine(streamWriter, num18, text, num16 + num2, num17 + num3 - num21 + num7, num16 + num4, num17 + num5 - num21 + num7);
					num2 = num4;
					num3 = num5;
					num4 = num2 + num19 - num7 / 2.0;
					num5 = num3;
					num18 = (ushort)(num + 1);
					num = num18;
					DrawLine(streamWriter, num18, text, num16 + num2, num17 + num3, num16 + num4, num17 + num5);
					num18 = (ushort)(num + 1);
					num = num18;
					DrawLine(streamWriter, num18, text, num16 + num2, num17 + num3 - num21, num16 + num4, num17 + num5 - num21);
					num2 = num4;
					num3 = num5;
					num4 = num2;
					num5 = num3 - num21;
					num18 = (ushort)(num + 1);
					num = num18;
					DrawLine(streamWriter, num18, text, num16 + num2, num17 + num3, num16 + num4, num17 + num5);
				}
				if (vyhid == "з виходом")
				{
					int num24 = d1;
					int num25 = a1;
					int num26 = b1;
					int num27 = d2;
					int num28 = a2;
					int num29 = b2;
					int num30 = d3;
					int num31 = a3;
					int num32 = b3;
					int num33 = 3;
					int num34 = 2;
					int num35 = 3;
					int num36 = 5;
					if (connection == "зварка")
					{
						if (typVyhid1 == "мінус")
						{
							d1 -= num33;
							a1 -= num33;
							b1 -= num33;
						}
						if (typVyhid2 == "мінус")
						{
							d2 -= num33;
							a2 -= num33;
							b2 -= num33;
						}
						if (typVyhid3 == "мінус")
						{
							d3 -= num33;
							a3 -= num33;
							b3 -= num33;
						}
					}
					if (connection == "заклепка")
					{
						if (typVyhid1 == "чисто" || typVyhid1 == "фланець")
						{
							d1 -= num34;
							a1 += num35;
							b1 += num35;
						}
						if (typVyhid1 == "мінус")
						{
							d1 -= num36;
						}
						if (typVyhid2 == "чисто" || typVyhid2 == "фланець")
						{
							d2 -= num34;
							a2 += num35;
							b2 += num35;
						}
						if (typVyhid2 == "мінус")
						{
							d2 -= num36;
						}
						if (typVyhid3 == "чисто" || typVyhid3 == "фланець")
						{
							d3 -= num34;
							a3 += num35;
							b3 += num35;
						}
						if (typVyhid3 == "мінус")
						{
							d3 -= num36;
						}
					}
					num16 += num22 + num7 / 2.0;
					num17 += num23 - 0.5 * ((double)L - num21);
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
					d1 = num24;
					a1 = num25;
					b1 = num26;
					d2 = num27;
					a2 = num28;
					b2 = num29;
					d3 = num30;
					a3 = num31;
					b3 = num32;
				}
				if (zhyrFiltr == "так")
				{
					double num37 = 9.5;
					double num38 = 69.0;
					double num39 = 59.5;
					double num40 = 15.0;
					double num41 = 19.5;
					num16 = B + 500;
					num17 = -150.0;
					if (implementation == 1)
					{
						num2 = num40;
						num3 = 0.0;
						num4 = num2;
						num5 = num3 + num41;
						num18 = (ushort)(num + 1);
						num = num18;
						DrawLine(streamWriter, num18, text, num16 + num2, num17 + num3, num16 + num4, num17 + num5);
						num2 = num4;
						num3 = num5;
						num4 = num2 + num7;
						num5 = num3;
						num18 = (ushort)(num + 1);
						num = num18;
						DrawLine(streamWriter, num18, text, num16 + num2, num17 + num3, num16 + num4, num17 + num5);
						num2 = num4;
						num3 = num5;
						num4 = num2;
						num5 = num3 + num7;
						num18 = (ushort)(num + 1);
						num = num18;
						DrawLine(streamWriter, num18, text, num16 + num2, num17 + num3, num16 + num4, num17 + num5);
						num2 = num4;
						num3 = num5;
						num4 = num2 - num7 - num40;
						num5 = num3;
						num18 = (ushort)(num + 1);
						num = num18;
						DrawLine(streamWriter, num18, text, num16 + num2, num17 + num3, num16 + num4, num17 + num5);
						num2 = num4;
						num3 = num5;
						num4 = num2;
						num5 = num3 + num39;
						num18 = (ushort)(num + 1);
						num = num18;
						DrawLine(streamWriter, num18, text, num16 + num2, num17 + num3, num16 + num4, num17 + num5);
						num2 = num4;
						num3 = num5;
						num4 = num2 + num7;
						num5 = num3;
						num18 = (ushort)(num + 1);
						num = num18;
						DrawLine(streamWriter, num18, text, num16 + num2, num17 + num3, num16 + num4, num17 + num5);
						num2 = num4;
						num3 = num5;
						num4 = num2;
						num5 = num3 + num7;
						num18 = (ushort)(num + 1);
						num = num18;
						DrawLine(streamWriter, num18, text, num16 + num2, num17 + num3, num16 + num4, num17 + num5);
						num2 = num4;
						num3 = num5;
						num4 = num2 - num7;
						num5 = num3;
						num18 = (ushort)(num + 1);
						num = num18;
						DrawLine(streamWriter, num18, text, num16 + num2, num17 + num3, num16 + num4, num17 + num5);
						num2 = num4;
						num3 = num5;
						num4 = num2;
						num5 = num3 + num38;
						num18 = (ushort)(num + 1);
						num = num18;
						DrawLine(streamWriter, num18, text, num16 + num2, num17 + num3, num16 + num4, num17 + num5);
						num2 = num4;
						num3 = num5;
						num4 = num2 + num7;
						num5 = num3;
						num18 = (ushort)(num + 1);
						num = num18;
						DrawLine(streamWriter, num18, text, num16 + num2, num17 + num3, num16 + num4, num17 + num5);
						num2 = num4;
						num3 = num5;
						num4 = num2;
						num5 = num3 + num7;
						num18 = (ushort)(num + 1);
						num = num18;
						DrawLine(streamWriter, num18, text, num16 + num2, num17 + num3, num16 + num4, num17 + num5);
						num2 = num4;
						num3 = num5;
						num4 = num2 - num7;
						num5 = num3;
						num18 = (ushort)(num + 1);
						num = num18;
						DrawLine(streamWriter, num18, text, num16 + num2, num17 + num3, num16 + num4, num17 + num5);
						num2 = num4;
						num3 = num5;
						num4 = num2;
						num5 = num3 + num37;
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
						num5 = num3 - num37;
						num18 = (ushort)(num + 1);
						num = num18;
						DrawLine(streamWriter, num18, text, num16 + num2, num17 + num3, num16 + num4, num17 + num5);
						num2 = num4;
						num3 = num5;
						num4 = num2 - num7;
						num5 = num3;
						num18 = (ushort)(num + 1);
						num = num18;
						DrawLine(streamWriter, num18, text, num16 + num2, num17 + num3, num16 + num4, num17 + num5);
						num2 = num4;
						num3 = num5;
						num4 = num2;
						num5 = num3 - num7;
						num18 = (ushort)(num + 1);
						num = num18;
						DrawLine(streamWriter, num18, text, num16 + num2, num17 + num3, num16 + num4, num17 + num5);
						num2 = num4;
						num3 = num5;
						num4 = num2 + num7;
						num5 = num3;
						num18 = (ushort)(num + 1);
						num = num18;
						DrawLine(streamWriter, num18, text, num16 + num2, num17 + num3, num16 + num4, num17 + num5);
						num2 = num4;
						num3 = num5;
						num4 = num2;
						num5 = num3 - num38;
						num18 = (ushort)(num + 1);
						num = num18;
						DrawLine(streamWriter, num18, text, num16 + num2, num17 + num3, num16 + num4, num17 + num5);
						num2 = num4;
						num3 = num5;
						num4 = num2 - num7;
						num5 = num3;
						num18 = (ushort)(num + 1);
						num = num18;
						DrawLine(streamWriter, num18, text, num16 + num2, num17 + num3, num16 + num4, num17 + num5);
						num2 = num4;
						num3 = num5;
						num4 = num2;
						num5 = num3 - num7;
						num18 = (ushort)(num + 1);
						num = num18;
						DrawLine(streamWriter, num18, text, num16 + num2, num17 + num3, num16 + num4, num17 + num5);
						num2 = num4;
						num3 = num5;
						num4 = num2 + num7;
						num5 = num3;
						num18 = (ushort)(num + 1);
						num = num18;
						DrawLine(streamWriter, num18, text, num16 + num2, num17 + num3, num16 + num4, num17 + num5);
						num2 = num4;
						num3 = num5;
						num4 = num2;
						num5 = num3 - num39;
						num18 = (ushort)(num + 1);
						num = num18;
						DrawLine(streamWriter, num18, text, num16 + num2, num17 + num3, num16 + num4, num17 + num5);
						num2 = num4;
						num3 = num5;
						num4 = num2 - num40 - num7;
						num5 = num3;
						num18 = (ushort)(num + 1);
						num = num18;
						DrawLine(streamWriter, num18, text, num16 + num2, num17 + num3, num16 + num4, num17 + num5);
						num2 = num4;
						num3 = num5;
						num4 = num2;
						num5 = num3 - num7;
						num18 = (ushort)(num + 1);
						num = num18;
						DrawLine(streamWriter, num18, text, num16 + num2, num17 + num3, num16 + num4, num17 + num5);
						num2 = num4;
						num3 = num5;
						num4 = num2 + num7;
						num5 = num3;
						num18 = (ushort)(num + 1);
						num = num18;
						DrawLine(streamWriter, num18, text, num16 + num2, num17 + num3, num16 + num4, num17 + num5);
						num2 = num4;
						num3 = num5;
						num4 = num2;
						num5 = num3 - num41;
						num18 = (ushort)(num + 1);
						num = num18;
						DrawLine(streamWriter, num18, text, num16 + num2, num17 + num3, num16 + num4, num17 + num5);
						num2 = num4;
						num3 = num5;
						num4 = num2 - ((double)(L - 5) - 2.0 * num40);
						num5 = num3;
						num18 = (ushort)(num + 1);
						num = num18;
						DrawLine(streamWriter, num18, text, num16 + num2, num17 + num3, num16 + num4, num17 + num5);
						num = DrawZaklepka_1(streamWriter, num, text, connection, num4 - 2.5 - num40 + num16, num5 + num17, num2 + 2.5 + num40 + num16, num3 + num17, 0);
					}
					num16 = B + 500;
					num17 = 120.0;
					num37 = 54.5;
					num38 = 14.5;
					num2 = 0.0;
					num3 = 0.0;
					num4 = num2;
					num5 = num3 + num38;
					num18 = (ushort)(num + 1);
					num = num18;
					DrawLine(streamWriter, num18, text, num16 + num2, num17 + num3, num16 + num4, num17 + num5);
					num2 = num4;
					num3 = num5;
					num4 = num2 + num7;
					num5 = num3;
					num18 = (ushort)(num + 1);
					num = num18;
					DrawLine(streamWriter, num18, text, num16 + num2, num17 + num3, num16 + num4, num17 + num5);
					num2 = num4;
					num3 = num5;
					num4 = num2;
					num5 = num3 + num7;
					num18 = (ushort)(num + 1);
					num = num18;
					DrawLine(streamWriter, num18, text, num16 + num2, num17 + num3, num16 + num4, num17 + num5);
					num2 = num4;
					num3 = num5;
					num4 = num2 - num7;
					num5 = num3;
					num18 = (ushort)(num + 1);
					num = num18;
					DrawLine(streamWriter, num18, text, num16 + num2, num17 + num3, num16 + num4, num17 + num5);
					num2 = num4;
					num3 = num5;
					num4 = num2;
					num5 = num3 + num37;
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
					num5 = num3 - num37;
					num18 = (ushort)(num + 1);
					num = num18;
					DrawLine(streamWriter, num18, text, num16 + num2, num17 + num3, num16 + num4, num17 + num5);
					num2 = num4;
					num3 = num5;
					num4 = num2 - num7;
					num5 = num3;
					num18 = (ushort)(num + 1);
					num = num18;
					DrawLine(streamWriter, num18, text, num16 + num2, num17 + num3, num16 + num4, num17 + num5);
					num2 = num4;
					num3 = num5;
					num4 = num2;
					num5 = num3 - num7;
					num18 = (ushort)(num + 1);
					num = num18;
					DrawLine(streamWriter, num18, text, num16 + num2, num17 + num3, num16 + num4, num17 + num5);
					num2 = num4;
					num3 = num5;
					num4 = num2 + num7;
					num5 = num3;
					num18 = (ushort)(num + 1);
					num = num18;
					DrawLine(streamWriter, num18, text, num16 + num2, num17 + num3, num16 + num4, num17 + num5);
					num2 = num4;
					num3 = num5;
					num4 = num2;
					num5 = num3 - num38;
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
						double num42 = 12.5;
						double num43 = 10.5;
						double num44 = 72.5;
						num2 = num4 - (double)(L - 10);
						num3 = num5;
						num4 = num2 + num44 - num42;
						num5 = num3;
						num18 = (ushort)(num + 1);
						num = num18;
						DrawLine(streamWriter, num18, text, num16 + num2, num17 + num3, num16 + num4, num17 + num5);
						double num45 = num4;
						double num46 = num5;
						double num47 = 15.0;
						double num48 = 16.0;
						double num49 = 40.0;
						double num50 = 7.0;
						num2 += num47;
						num3 += num48;
						num4 = num2;
						num5 = num3 + num50;
						num18 = (ushort)(num + 1);
						num = num18;
						DrawLine(streamWriter, num18, text, num16 + num2, num17 + num3, num16 + num4, num17 + num5);
						num2 = num4;
						num3 = num5;
						num4 = num2 + num49;
						num5 = num3;
						num18 = (ushort)(num + 1);
						num = num18;
						DrawLine(streamWriter, num18, text, num16 + num2, num17 + num3, num16 + num4, num17 + num5);
						num2 = num4;
						num3 = num5;
						num4 = num2;
						num5 = num3 - num50;
						num18 = (ushort)(num + 1);
						num = num18;
						DrawLine(streamWriter, num18, text, num16 + num2, num17 + num3, num16 + num4, num17 + num5);
						num2 = num4;
						num3 = num5;
						num4 = num2 - num49;
						num5 = num3;
						num18 = (ushort)(num + 1);
						num = num18;
						DrawLine(streamWriter, num18, text, num16 + num2, num17 + num3, num16 + num4, num17 + num5);
						num2 = num45;
						num3 = num46;
						num4 = num2;
						num5 = num3 + num43 + num42;
						num18 = (ushort)(num + 1);
						num = num18;
						DrawLine(streamWriter, num18, text, num16 + num2, num17 + num3, num16 + num4, num17 + num5);
						num2 = num4;
						num3 = num5;
						num4 = num2 + 2.0 * num42;
						num5 = num3;
						num18 = (ushort)(num + 1);
						num = num18;
						DrawLine(streamWriter, num18, text, num16 + num2, num17 + num3, num16 + num4, num17 + num5);
						num2 = num4;
						num3 = num5;
						num4 = num2;
						num5 = num3 - (num43 + num42);
						num18 = (ushort)(num + 1);
						num = num18;
						DrawLine(streamWriter, num18, text, num16 + num2, num17 + num3, num16 + num4, num17 + num5);
						num45 = num4;
						num46 = num5;
						double num51 = 34.0;
						num47 = num4 + 5.0;
						num48 += num5;
						int num52 = (int)Math.Floor(((double)(L - 10) - num47) / (num51 + num49));
						for (int j = 0; j < num52; j++)
						{
							num2 = num47 + (double)j * (num51 + num49);
							num3 = num48;
							num4 = num2;
							num5 = num3 + num50;
							num18 = (ushort)(num + 1);
							num = num18;
							DrawLine(streamWriter, num18, text, num16 + num2, num17 + num3, num16 + num4, num17 + num5);
							num2 = num4;
							num3 = num5;
							num4 = num2 + num49;
							num5 = num3;
							num18 = (ushort)(num + 1);
							num = num18;
							DrawLine(streamWriter, num18, text, num16 + num2, num17 + num3, num16 + num4, num17 + num5);
							num2 = num4;
							num3 = num5;
							num4 = num2;
							num5 = num3 - num50;
							num18 = (ushort)(num + 1);
							num = num18;
							DrawLine(streamWriter, num18, text, num16 + num2, num17 + num3, num16 + num4, num17 + num5);
							num2 = num4;
							num3 = num5;
							num4 = num2 - num49;
							num5 = num3;
							num18 = (ushort)(num + 1);
							num = num18;
							DrawLine(streamWriter, num18, text, num16 + num2, num17 + num3, num16 + num4, num17 + num5);
						}
						num2 = num45;
						num3 = num46;
						num4 = num2 + (double)L - 10.0 - (num44 + num42);
						num5 = num3;
						num18 = (ushort)(num + 1);
						num = num18;
						DrawLine(streamWriter, num18, text, num16 + num2, num17 + num3, num16 + num4, num17 + num5);
					}
					num37 = ((implementation == 1) ? 25 : 10);
					num38 = ((implementation == 1) ? 110 : 60);
					num16 = B + 500;
					num17 = 300.0;
					num2 = 0.0;
					num3 = 0.0;
					num4 = num2;
					num5 = num3 + num37 - num7 / 2.0;
					num18 = (ushort)(num + 1);
					num = num18;
					DrawLine(streamWriter, num18, text, num16 + num2, num17 + num3, num16 + num4, num17 + num5);
					num2 = num4;
					num3 = num5;
					num4 = num2 + num7;
					num5 = num3;
					num18 = (ushort)(num + 1);
					num = num18;
					DrawLine(streamWriter, num18, text, num16 + num2, num17 + num3, num16 + num4, num17 + num5);
					num2 = num4;
					num3 = num5;
					num4 = num2;
					num5 = num3 + num7;
					num18 = (ushort)(num + 1);
					num = num18;
					DrawLine(streamWriter, num18, text, num16 + num2, num17 + num3, num16 + num4, num17 + num5);
					num2 = num4;
					num3 = num5;
					num4 = num2 - num7;
					num5 = num3;
					num18 = (ushort)(num + 1);
					num = num18;
					DrawLine(streamWriter, num18, text, num16 + num2, num17 + num3, num16 + num4, num17 + num5);
					num2 = num4;
					num3 = num5;
					num4 = num2;
					num5 = num3 + num38 - num7;
					num18 = (ushort)(num + 1);
					num = num18;
					DrawLine(streamWriter, num18, text, num16 + num2, num17 + num3, num16 + num4, num17 + num5);
					num = ((num38 != 110.0) ? DrawZaklepka_Planka2(streamWriter, num, text, connection, num2 + num16, num3 + num17, num4 + num16, num5 + num17, 1) : DrawZaklepka_Planka1(streamWriter, num, text, connection, num2 + num16, num3 + num17, num4 + num16, num5 + num17, 1));
					num2 = num4;
					num3 = num5;
					num4 = num2 + num7;
					num5 = num3;
					num18 = (ushort)(num + 1);
					num = num18;
					DrawLine(streamWriter, num18, text, num16 + num2, num17 + num3, num16 + num4, num17 + num5);
					num2 = num4;
					num3 = num5;
					num4 = num2;
					num5 = num3 + num7;
					num18 = (ushort)(num + 1);
					num = num18;
					DrawLine(streamWriter, num18, text, num16 + num2, num17 + num3, num16 + num4, num17 + num5);
					num2 = num4;
					num3 = num5;
					num4 = num2 - num7;
					num5 = num3;
					num18 = (ushort)(num + 1);
					num = num18;
					DrawLine(streamWriter, num18, text, num16 + num2, num17 + num3, num16 + num4, num17 + num5);
					num2 = num4;
					num3 = num5;
					num4 = num2;
					num5 = num3 + num37 - num7 / 2.0;
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
					num5 = num3 - (num37 - num7 / 2.0);
					num18 = (ushort)(num + 1);
					num = num18;
					DrawLine(streamWriter, num18, text, num16 + num2, num17 + num3, num16 + num4, num17 + num5);
					num2 = num4;
					num3 = num5;
					num4 = num2 - num7;
					num5 = num3;
					num18 = (ushort)(num + 1);
					num = num18;
					DrawLine(streamWriter, num18, text, num16 + num2, num17 + num3, num16 + num4, num17 + num5);
					num2 = num4;
					num3 = num5;
					num4 = num2;
					num5 = num3 - num7;
					num18 = (ushort)(num + 1);
					num = num18;
					DrawLine(streamWriter, num18, text, num16 + num2, num17 + num3, num16 + num4, num17 + num5);
					num2 = num4;
					num3 = num5;
					num4 = num2 + num7;
					num5 = num3;
					num18 = (ushort)(num + 1);
					num = num18;
					DrawLine(streamWriter, num18, text, num16 + num2, num17 + num3, num16 + num4, num17 + num5);
					num2 = num4;
					num3 = num5;
					num4 = num2;
					num5 = num3 - (num38 - num7);
					num18 = (ushort)(num + 1);
					num = num18;
					DrawLine(streamWriter, num18, text, num16 + num2, num17 + num3, num16 + num4, num17 + num5);
					num = ((num38 != 110.0) ? DrawZaklepka_Planka2(streamWriter, num, text, connection, num2 + num16, num3 + num17, num4 + num16, num5 + num17, 1) : DrawZaklepka_Planka1(streamWriter, num, text, connection, num2 + num16, num3 + num17, num4 + num16, num5 + num17, 1));
					num2 = num4;
					num3 = num5;
					num4 = num2 - num7;
					num5 = num3;
					num18 = (ushort)(num + 1);
					num = num18;
					DrawLine(streamWriter, num18, text, num16 + num2, num17 + num3, num16 + num4, num17 + num5);
					num2 = num4;
					num3 = num5;
					num4 = num2;
					num5 = num3 - num7;
					num18 = (ushort)(num + 1);
					num = num18;
					DrawLine(streamWriter, num18, text, num16 + num2, num17 + num3, num16 + num4, num17 + num5);
					num2 = num4;
					num3 = num5;
					num4 = num2 + num7;
					num5 = num3;
					num18 = (ushort)(num + 1);
					num = num18;
					DrawLine(streamWriter, num18, text, num16 + num2, num17 + num3, num16 + num4, num17 + num5);
					num2 = num4;
					num3 = num5;
					num4 = num2;
					num5 = num3 - (num37 - num7 / 2.0);
					num18 = (ushort)(num + 1);
					num = num18;
					DrawLine(streamWriter, num18, text, num16 + num2, num17 + num3, num16 + num4, num17 + num5);
					if (zlyv != "ні")
					{
						double num53 = 75.0;
						double num54 = ((implementation == 2) ? 40 : 80);
						double num55 = 16.0;
						num2 = ((zlyv == "так, трубка справа") ? (num4 - num53) : (num4 - (double)(L - 5) + num53));
						num3 = num5 + num54;
						num18 = (ushort)(num + 1);
						num = num18;
						DrawCircle(streamWriter, num18, text, num16 + num2, num17 + num3, num55 / 2.0);
					}
					num2 = num4;
					num3 = num5;
					num4 = num2 - (double)(L - 5);
					num5 = num3;
					num18 = (ushort)(num + 1);
					num = num18;
					DrawLine(streamWriter, num18, text, num16 + num2, num17 + num3, num16 + num4, num17 + num5);
					if (implementation == 1)
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
						for (int k = 0; k < nFiltr; k++)
						{
							kk += kFiltr[k];
						}
						kk = 0.5 * ((double)L - kk) + 15.0;
						num37 = 19.5;
						double num56 = 1.0;
						num38 = 19.0;
						num39 = 42.5;
						num16 = B + 500;
						num17 = 600.0;
						num2 = 0.0;
						num3 = 0.0;
						num4 = num2;
						num5 = num3 + num39;
						num18 = (ushort)(num + 1);
						num = num18;
						DrawLine(streamWriter, num18, text, num16 + num2, num17 + num3, num16 + num4, num17 + num5);
						num2 = num4;
						num3 = num5;
						num4 = num2 + num37;
						num5 = num3;
						num18 = (ushort)(num + 1);
						num = num18;
						DrawLine(streamWriter, num18, text, num16 + num2, num17 + num3, num16 + num4, num17 + num5);
						num2 = num4;
						num3 = num5;
						num4 = num2;
						num5 = num3 - num56;
						num18 = (ushort)(num + 1);
						num = num18;
						DrawLine(streamWriter, num18, text, num16 + num2, num17 + num3, num16 + num4, num17 + num5);
						num2 = num4;
						num3 = num5;
						num4 = num2 + num56;
						num5 = num3;
						num18 = (ushort)(num + 1);
						num = num18;
						DrawLine(streamWriter, num18, text, num16 + num2, num17 + num3, num16 + num4, num17 + num5);
						num2 = num4;
						num3 = num5;
						num4 = num2;
						num5 = num3 + num56;
						num18 = (ushort)(num + 1);
						num = num18;
						DrawLine(streamWriter, num18, text, num16 + num2, num17 + num3, num16 + num4, num17 + num5);
						num2 = num4;
						num3 = num5;
						num4 = num2 + num37 + num56;
						num5 = num3;
						num18 = (ushort)(num + 1);
						num = num18;
						DrawLine(streamWriter, num18, text, num16 + num2, num17 + num3, num16 + num4, num17 + num5);
						num2 = num4;
						num3 = num5;
						num4 = num2;
						num5 = num3 + num56;
						num18 = (ushort)(num + 1);
						num = num18;
						DrawLine(streamWriter, num18, text, num16 + num2, num17 + num3, num16 + num4, num17 + num5);
						num2 = num4;
						num3 = num5;
						num4 = num2 - num56;
						num5 = num3;
						num18 = (ushort)(num + 1);
						num = num18;
						DrawLine(streamWriter, num18, text, num16 + num2, num17 + num3, num16 + num4, num17 + num5);
						num2 = num4;
						num3 = num5;
						num4 = num2;
						num5 = num3 + (kk - 0.5);
						num18 = (ushort)(num + 1);
						num = num18;
						DrawLine(streamWriter, num18, text, num16 + num2, num17 + num3, num16 + num4, num17 + num5);
						num2 = num4;
						num3 = num5;
						num4 = num2 + (double)(ZontOstrivnyyTyp4.l + 30);
						num5 = num3;
						num18 = (ushort)(num + 1);
						num = num18;
						DrawLine(streamWriter, num18, text, num16 + num2, num17 + num3, num16 + num4, num17 + num5);
						num2 = num4;
						num3 = num5;
						num4 = num2;
						num5 = num3 - (kk - 0.5);
						num18 = (ushort)(num + 1);
						num = num18;
						DrawLine(streamWriter, num18, text, num16 + num2, num17 + num3, num16 + num4, num17 + num5);
						num2 = num4;
						num3 = num5;
						num4 = num2 - num56;
						num5 = num3;
						num18 = (ushort)(num + 1);
						num = num18;
						DrawLine(streamWriter, num18, text, num16 + num2, num17 + num3, num16 + num4, num17 + num5);
						num2 = num4;
						num3 = num5;
						num4 = num2;
						num5 = num3 - num56;
						num18 = (ushort)(num + 1);
						num = num18;
						DrawLine(streamWriter, num18, text, num16 + num2, num17 + num3, num16 + num4, num17 + num5);
						num2 = num4;
						num3 = num5;
						num4 = num2 + num56;
						num5 = num3;
						num18 = (ushort)(num + 1);
						num = num18;
						DrawLine(streamWriter, num18, text, num16 + num2, num17 + num3, num16 + num4, num17 + num5);
						num2 = num4;
						num3 = num5;
						num4 = num2;
						num5 = num3 - num39;
						num18 = (ushort)(num + 1);
						num = num18;
						DrawLine(streamWriter, num18, text, num16 + num2, num17 + num3, num16 + num4, num17 + num5);
						num2 = num4;
						num3 = num5;
						num4 = num2 - ((double)(ZontOstrivnyyTyp4.l + 30) - 0.5);
						num5 = num3;
						num18 = (ushort)(num + 1);
						num = num18;
						DrawLine(streamWriter, num18, text, num16 + num2, num17 + num3, num16 + num4, num17 + num5);
						num2 = num4;
						num3 = num5;
						num4 = num2;
						num5 = num3 + num56;
						num18 = (ushort)(num + 1);
						num = num18;
						DrawLine(streamWriter, num18, text, num16 + num2, num17 + num3, num16 + num4, num17 + num5);
						num2 = num4;
						num3 = num5;
						num4 = num2 - num56;
						num5 = num3;
						num18 = (ushort)(num + 1);
						num = num18;
						DrawLine(streamWriter, num18, text, num16 + num2, num17 + num3, num16 + num4, num17 + num5);
						num2 = num4;
						num3 = num5;
						num4 = num2;
						num5 = num3 - num56;
						num18 = (ushort)(num + 1);
						num = num18;
						DrawLine(streamWriter, num18, text, num16 + num2, num17 + num3, num16 + num4, num17 + num5);
						num2 = num4;
						num3 = num5;
						num4 = num2 - num38;
						num5 = num3;
						num18 = (ushort)(num + 1);
						num = num18;
						DrawLine(streamWriter, num18, text, num16 + num2, num17 + num3, num16 + num4, num17 + num5);
						num2 = num4;
						num3 = num5;
						num4 = num2;
						num5 = num3 + num56;
						num18 = (ushort)(num + 1);
						num = num18;
						DrawLine(streamWriter, num18, text, num16 + num2, num17 + num3, num16 + num4, num17 + num5);
						num2 = num4;
						num3 = num5;
						num4 = num2 - num56;
						num5 = num3;
						num18 = (ushort)(num + 1);
						num = num18;
						DrawLine(streamWriter, num18, text, num16 + num2, num17 + num3, num16 + num4, num17 + num5);
						num2 = num4;
						num3 = num5;
						num4 = num2;
						num5 = num3 - num56;
						num18 = (ushort)(num + 1);
						num = num18;
						DrawLine(streamWriter, num18, text, num16 + num2, num17 + num3, num16 + num4, num17 + num5);
						num2 = num4;
						num3 = num5;
						num4 = num2 - num37;
						num5 = num3;
						num18 = (ushort)(num + 1);
						num = num18;
						DrawLine(streamWriter, num18, text, num16 + num2, num17 + num3, num16 + num4, num17 + num5);
					}
				}
			}
			else
			{
				double num57 = 100.0;
				double num58 = 10.0;
				double num59 = 20.0;
				ushort num18;
				if (implementation == 2)
				{
					num2 = num15;
					num3 = num8 + num9;
					num4 = num2 + num11;
					num5 = num3;
					num18 = (ushort)(num + 1);
					num = num18;
					DrawLine(streamWriter, num18, text, num16 + num2, num17 + num3, num16 + num4, num17 + num5);
					num2 = num4;
					num3 = num5;
					num4 = num2;
					num5 = num3 - num13;
					num18 = (ushort)(num + 1);
					num = num18;
					DrawLine(streamWriter, num18, text, num16 + num2, num17 + num3, num16 + num4, num17 + num5);
					num2 = num4;
					num3 = num5;
					num4 = num2 + num7;
					num5 = num3;
					num18 = (ushort)(num + 1);
					num = num18;
					DrawLine(streamWriter, num18, text, num16 + num2, num17 + num3, num16 + num4, num17 + num5);
					num2 = num4;
					num3 = num5;
					num4 = num2;
					num5 = num3 - num7;
					num18 = (ushort)(num + 1);
					num = num18;
					DrawLine(streamWriter, num18, text, num16 + num2, num17 + num3, num16 + num4, num17 + num5);
					num2 = num4;
					num3 = num5;
					num4 = num2 - num7;
					num5 = num3;
					num18 = (ushort)(num + 1);
					num = num18;
					DrawLine(streamWriter, num18, text, num16 + num2, num17 + num3, num16 + num4, num17 + num5);
					num2 = num4;
					num3 = num5;
					num4 = num2;
					num5 = num3 - (num8 - num7 / 2.0);
					num18 = (ushort)(num + 1);
					num = num18;
					DrawLine(streamWriter, num18, text, num16 + num2, num17 + num3, num16 + num4, num17 + num5);
					num2 = num4;
					num3 = num5;
					num4 = num2 + (double)B - 2.0 * num11;
					num5 = num3;
					num18 = (ushort)(num + 1);
					num = num18;
					DrawLine(streamWriter, num18, text, num16 + num2, num17 + num3, num16 + num4, num17 + num5);
					num2 = num4;
					num3 = num5;
					num4 = num2;
					num5 = num3 + num8 - num7 / 2.0;
					num18 = (ushort)(num + 1);
					num = num18;
					DrawLine(streamWriter, num18, text, num16 + num2, num17 + num3, num16 + num4, num17 + num5);
					num2 = num4;
					num3 = num5;
					num4 = num2 - num7;
					num5 = num3;
					num18 = (ushort)(num + 1);
					num = num18;
					DrawLine(streamWriter, num18, text, num16 + num2, num17 + num3, num16 + num4, num17 + num5);
					num2 = num4;
					num3 = num5;
					num4 = num2;
					num5 = num3 + num7;
					num18 = (ushort)(num + 1);
					num = num18;
					DrawLine(streamWriter, num18, text, num16 + num2, num17 + num3, num16 + num4, num17 + num5);
					num2 = num4;
					num3 = num5;
					num4 = num2 + num7;
					num5 = num3;
					num18 = (ushort)(num + 1);
					num = num18;
					DrawLine(streamWriter, num18, text, num16 + num2, num17 + num3, num16 + num4, num17 + num5);
					num2 = num4;
					num3 = num5;
					num4 = num2;
					num5 = num3 + num13;
					num18 = (ushort)(num + 1);
					num = num18;
					DrawLine(streamWriter, num18, text, num16 + num2, num17 + num3, num16 + num4, num17 + num5);
					num2 = num4;
					num3 = num5;
					num4 = num2 + num11;
					num5 = num3;
					num18 = (ushort)(num + 1);
					num = num18;
					DrawLine(streamWriter, num18, text, num16 + num2, num17 + num3, num16 + num4, num17 + num5);
					num2 = num4;
					num3 = num5;
					num4 = num2 + num15;
					num5 = num3 + num15;
					num18 = (ushort)(num + 1);
					num = num18;
					DrawLine(streamWriter, num18, text, num16 + num2, num17 + num3, num16 + num4, num17 + num5);
				}
				else
				{
					if (connection == "зварка")
					{
						num2 = num15;
						num3 = num8 + num9;
						num4 = num2 + num57;
						num5 = num3;
						num18 = (ushort)(num + 1);
						num = num18;
						DrawLine(streamWriter, num18, text, num16 + num2, num17 + num3, num16 + num4, num17 + num5);
						num2 = num4;
						num3 = num5;
						num4 = num2;
						num5 = num3 - (num59 - num7 / 2.0);
						num18 = (ushort)(num + 1);
						num = num18;
						DrawLine(streamWriter, num18, text, num16 + num2, num17 + num3, num16 + num4, num17 + num5);
						num2 = num4;
						num3 = num5;
						num4 = num2 + num7;
						num5 = num3;
						num18 = (ushort)(num + 1);
						num = num18;
						DrawLine(streamWriter, num18, text, num16 + num2, num17 + num3, num16 + num4, num17 + num5);
						num2 = num4;
						num3 = num5;
						num4 = num2;
						num5 = num3 - num7;
						num18 = (ushort)(num + 1);
						num = num18;
						DrawLine(streamWriter, num18, text, num16 + num2, num17 + num3, num16 + num4, num17 + num5);
						num2 = num4;
						num3 = num5;
						num4 = num2 - num7;
						num5 = num3;
						num18 = (ushort)(num + 1);
						num = num18;
						DrawLine(streamWriter, num18, text, num16 + num2, num17 + num3, num16 + num4, num17 + num5);
						num2 = num4;
						num3 = num5;
						num4 = num2;
						num5 = num3 - (num58 - num7 / 2.0);
						num18 = (ushort)(num + 1);
						num = num18;
						DrawLine(streamWriter, num18, text, num16 + num2, num17 + num3, num16 + num4, num17 + num5);
					}
					else
					{
						num2 = num15;
						num3 = num8 + num9;
						num4 = num2 + num15;
						num5 = num3 - num15;
						num18 = (ushort)(num + 1);
						num = num18;
						DrawLine(streamWriter, num18, text, num16 + num2, num17 + num3, num16 + num4, num17 + num5);
						num2 = num4;
						num3 = num5;
						num4 = num2 + num57 - 2.0 * num15;
						num5 = num3;
						num18 = (ushort)(num + 1);
						num = num18;
						DrawLine(streamWriter, num18, text, num16 + num2, num17 + num3, num16 + num4, num17 + num5);
						num = DrawZaklepka(streamWriter, num, text, connection, num2 + num16, num3 + num17, num4 + num16, num5 + num17, 0);
						num2 = num4;
						num3 = num5;
						num4 = num2 + num15;
						num5 = num3 + num15;
						num18 = (ushort)(num + 1);
						num = num18;
						DrawLine(streamWriter, num18, text, num16 + num2, num17 + num3, num16 + num4, num17 + num5);
						num2 = num4;
						num3 = num5;
						num4 = num2;
						num5 = num3 - (num59 - num7 / 2.0);
						num18 = (ushort)(num + 1);
						num = num18;
						DrawLine(streamWriter, num18, text, num16 + num2, num17 + num3, num16 + num4, num17 + num5);
						num2 = num4;
						num3 = num5;
						num4 = num2 + num7;
						num5 = num3;
						num18 = (ushort)(num + 1);
						num = num18;
						DrawLine(streamWriter, num18, text, num16 + num2, num17 + num3, num16 + num4, num17 + num5);
						num2 = num4;
						num3 = num5;
						num4 = num2;
						num5 = num3 - num7;
						num18 = (ushort)(num + 1);
						num = num18;
						DrawLine(streamWriter, num18, text, num16 + num2, num17 + num3, num16 + num4, num17 + num5);
						num2 = num4;
						num3 = num5;
						num4 = num2 - num7;
						num5 = num3;
						num18 = (ushort)(num + 1);
						num = num18;
						DrawLine(streamWriter, num18, text, num16 + num2, num17 + num3, num16 + num4, num17 + num5);
						num2 = num4;
						num3 = num5;
						num4 = num2;
						num5 = num3 - (num58 - num7 / 2.0);
						num18 = (ushort)(num + 1);
						num = num18;
						DrawLine(streamWriter, num18, text, num16 + num2, num17 + num3, num16 + num4, num17 + num5);
					}
					num2 = num4;
					num3 = num5;
					num4 = num2 + (double)B - num57 - num9;
					num5 = num3;
					num18 = (ushort)(num + 1);
					num = num18;
					DrawLine(streamWriter, num18, text, num16 + num2, num17 + num3, num16 + num4, num17 + num5);
					num2 = num4;
					num3 = num5;
					num4 = num2;
					num5 = num3 + num8;
					num18 = (ushort)(num + 1);
					num = num18;
					DrawLine(streamWriter, num18, text, num16 + num2, num17 + num3, num16 + num4, num17 + num5);
					num2 = num4;
					num3 = num5;
					num4 = num2 + num9 + num15;
					num5 = num3 + num9 + num15;
					num18 = (ushort)(num + 1);
					num = num18;
					DrawLine(streamWriter, num18, text, num16 + num2, num17 + num3, num16 + num4, num17 + num5);
				}
				num2 = num15;
				num3 = num8 + num9;
				num4 = num2 - num15;
				num5 = num3 + num15;
				num18 = (ushort)(num + 1);
				num = num18;
				DrawLine(streamWriter, num18, text, num16 + num2, num17 + num3, num16 + num4, num17 + num5);
				num2 = num4;
				num3 = num5;
				num4 = num2;
				num5 = num3 + (double)H - 2.0 * num15;
				num18 = (ushort)(num + 1);
				num = num18;
				DrawLine(streamWriter, num18, text, num16 + num2, num17 + num3, num16 + num4, num17 + num5);
				num = DrawZaklepka(streamWriter, num, text, connection, num2 + num16, num3 + num17, num4 + num16, num5 + num17, 1);
				num2 = num4;
				num3 = num5;
				num4 = num2 + num15 + num14;
				num5 = num3 + num15 + num14;
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
				num4 = num2 + num14 + num15;
				num5 = num3 - (num14 + num15);
				num18 = (ushort)(num + 1);
				num = num18;
				DrawLine(streamWriter, num18, text, num16 + num2, num17 + num3, num16 + num4, num17 + num5);
				num2 = num4;
				num3 = num5;
				num4 = num2;
				num5 = num3 - ((double)H - 2.0 * num15);
				num18 = (ushort)(num + 1);
				num = num18;
				DrawLine(streamWriter, num18, text, num16 + num2, num17 + num3, num16 + num4, num17 + num5);
				num = DrawZaklepka(streamWriter, num, text, connection, num2 + num16, num3 + num17, num4 + num16, num5 + num17, 1);
				double num60 = ((implementation == 1) ? 20.5 : 10.5);
				double num61 = ((implementation == 1) ? 21 : 31);
				double num62 = ((connection == "зварка") ? (L - 5) : L);
				num16 = 0.0;
				num17 = -200.0 - num62;
				if (implementation == 1)
				{
					if (zlyv != "ні" && num6 == 1)
					{
						double num63 = 100.0;
						double num64 = num60 + num61 + num7 / 2.0 + 50.0;
						double num65 = 16.0;
						num2 = num64;
						num3 = ((zlyv == "так, трубка справа") ? (num62 - num63) : num63);
						num18 = (ushort)(num + 1);
						num = num18;
						DrawCircle(streamWriter, num18, text, num16 + num2, num17 + num3, num65 / 2.0);
					}
				}
				else if (zlyv != "ні" && num6 == 1)
				{
					double num66 = 75.0;
					double num67 = 26.0;
					double num68 = 16.0;
					num2 = num67;
					num3 = ((zlyv == "так, трубка справа") ? (num62 - num66) : num66);
					num18 = (ushort)(num + 1);
					num = num18;
					DrawCircle(streamWriter, num18, text, num16 + num2, num17 + num3, num68 / 2.0);
				}
				num2 = 0.0;
				num3 = 0.0;
				num4 = num2;
				num5 = num3 + num62;
				num18 = (ushort)(num + 1);
				num = num18;
				DrawLine(streamWriter, num18, text, num16 + num2, num17 + num3, num16 + num4, num17 + num5);
				num2 = num4;
				num3 = num5;
				num4 = num2 + num60 - num7 / 2.0;
				num5 = num3;
				num18 = (ushort)(num + 1);
				num = num18;
				DrawLine(streamWriter, num18, text, num16 + num2, num17 + num3, num16 + num4, num17 + num5);
				num18 = (ushort)(num + 1);
				num = num18;
				DrawLine(streamWriter, num18, text, num16 + num2, num17 + num3 - num62, num16 + num4, num17 + num5 - num62);
				num2 = num4;
				num3 = num5;
				num4 = num2;
				num5 = num3 - num7;
				num18 = (ushort)(num + 1);
				num = num18;
				DrawLine(streamWriter, num18, text, num16 + num2, num17 + num3, num16 + num4, num17 + num5);
				num18 = (ushort)(num + 1);
				num = num18;
				DrawLine(streamWriter, num18, text, num16 + num2, num17 + num3 - num62, num16 + num4, num17 + num5 - (num62 - 2.0 * num7));
				num2 = num4;
				num3 = num5;
				num4 = num2 + num7;
				num5 = num3;
				num18 = (ushort)(num + 1);
				num = num18;
				DrawLine(streamWriter, num18, text, num16 + num2, num17 + num3, num16 + num4, num17 + num5);
				num18 = (ushort)(num + 1);
				num = num18;
				DrawLine(streamWriter, num18, text, num16 + num2, num17 + num3 - (num62 - 2.0 * num7), num16 + num4, num17 + num5 - (num62 - 2.0 * num7));
				num2 = num4;
				num3 = num5;
				num4 = num2;
				num5 = num3 + num7;
				num18 = (ushort)(num + 1);
				num = num18;
				DrawLine(streamWriter, num18, text, num16 + num2, num17 + num3, num16 + num4, num17 + num5);
				num18 = (ushort)(num + 1);
				num = num18;
				DrawLine(streamWriter, num18, text, num16 + num2, num17 + num3 - (num62 - 2.0 * num7), num16 + num4, num17 + num5 - num62);
				num2 = num4;
				num3 = num5;
				num4 = num2 + num61 - num7;
				num5 = num3;
				num18 = (ushort)(num + 1);
				num = num18;
				DrawLine(streamWriter, num18, text, num16 + num2, num17 + num3, num16 + num4, num17 + num5);
				num18 = (ushort)(num + 1);
				num = num18;
				DrawLine(streamWriter, num18, text, num16 + num2, num17 + num3 - num62, num16 + num4, num17 + num5 - num62);
				num2 = num4;
				num3 = num5;
				num4 = num2;
				num5 = num3 - num7;
				num18 = (ushort)(num + 1);
				num = num18;
				DrawLine(streamWriter, num18, text, num16 + num2, num17 + num3, num16 + num4, num17 + num5);
				num18 = (ushort)(num + 1);
				num = num18;
				DrawLine(streamWriter, num18, text, num16 + num2, num17 + num3 - num62, num16 + num4, num17 + num5 - (num62 - 2.0 * num7));
				num2 = num4;
				num3 = num5;
				num4 = num2 + num7;
				num5 = num3;
				num18 = (ushort)(num + 1);
				num = num18;
				DrawLine(streamWriter, num18, text, num16 + num2, num17 + num3, num16 + num4, num17 + num5);
				num18 = (ushort)(num + 1);
				num = num18;
				DrawLine(streamWriter, num18, text, num16 + num2, num17 + num3 - (num62 - 2.0 * num7), num16 + num4, num17 + num5 - (num62 - 2.0 * num7));
				num2 = num4;
				num3 = num5;
				num4 = num2;
				num5 = num3 + num7;
				num18 = (ushort)(num + 1);
				num = num18;
				DrawLine(streamWriter, num18, text, num16 + num2, num17 + num3, num16 + num4, num17 + num5);
				num18 = (ushort)(num + 1);
				num = num18;
				DrawLine(streamWriter, num18, text, num16 + num2, num17 + num3 - (num62 - 2.0 * num7), num16 + num4, num17 + num5 - num62);
				if (implementation == 1)
				{
					num2 = num4;
					num3 = num5;
					num4 = num2 + num57;
					num5 = num3;
					num18 = (ushort)(num + 1);
					num = num18;
					DrawLine(streamWriter, num18, text, num16 + num2, num17 + num3, num16 + num4, num17 + num5);
					num18 = (ushort)(num + 1);
					num = num18;
					DrawLine(streamWriter, num18, text, num16 + num2, num17 + num3 - num62, num16 + num4, num17 + num5 - num62);
					num = DrawZaklepka_Top(streamWriter, num, text, connection, num2 + num16, num3 + num17, num4 + num16, num5 + num17, 1);
					num = DrawZaklepka_Top(streamWriter, num, text, connection, num2 + num16, num3 + num17 - num62, num4 + num16, num5 + num17 - num62, 0);
					num2 = num4;
					num3 = num5;
					num4 = num2;
					num5 = num3 - num7;
					num18 = (ushort)(num + 1);
					num = num18;
					DrawLine(streamWriter, num18, text, num16 + num2, num17 + num3, num16 + num4, num17 + num5);
					num18 = (ushort)(num + 1);
					num = num18;
					DrawLine(streamWriter, num18, text, num16 + num2, num17 + num3 - num62, num16 + num4, num17 + num5 - num62 + 2.0 * num7);
					num2 = num4;
					num3 = num5;
					num4 = num2 + num7;
					num5 = num3;
					num18 = (ushort)(num + 1);
					num = num18;
					DrawLine(streamWriter, num18, text, num16 + num2, num17 + num3, num16 + num4, num17 + num5);
					num18 = (ushort)(num + 1);
					num = num18;
					DrawLine(streamWriter, num18, text, num16 + num2, num17 + num3 - num62 + 2.0 * num7, num16 + num4, num17 + num5 - num62 + 2.0 * num7);
					num2 = num4;
					num3 = num5;
					num4 = num2;
					num5 = num3 + num7;
					num18 = (ushort)(num + 1);
					num = num18;
					DrawLine(streamWriter, num18, text, num16 + num2, num17 + num3, num16 + num4, num17 + num5);
					num18 = (ushort)(num + 1);
					num = num18;
					DrawLine(streamWriter, num18, text, num16 + num2, num17 + num3 - num62 + 2.0 * num7, num16 + num4, num17 + num5 - num62);
				}
				num2 = num4;
				num3 = num5;
				num4 = num2 + (double)H;
				num5 = num3;
				num18 = (ushort)(num + 1);
				num = num18;
				DrawLine(streamWriter, num18, text, num16 + num2, num17 + num3, num16 + num4, num17 + num5);
				num18 = (ushort)(num + 1);
				num = num18;
				DrawLine(streamWriter, num18, text, num16 + num2, num17 + num3 - num62, num16 + num4, num17 + num5 - num62);
				num = DrawZaklepka_Top(streamWriter, num, text, connection, num2 + num16, num3 + num17, num4 + num16, num5 + num17, 1);
				num = DrawZaklepka_Top(streamWriter, num, text, connection, num2 + num16, num3 + num17 - num62, num4 + num16, num5 + num17 - num62, 0);
				num2 = num4;
				num3 = num5;
				num4 = num2;
				num5 = num3 - num7;
				num18 = (ushort)(num + 1);
				num = num18;
				DrawLine(streamWriter, num18, text, num16 + num2, num17 + num3, num16 + num4, num17 + num5);
				num18 = (ushort)(num + 1);
				num = num18;
				DrawLine(streamWriter, num18, text, num16 + num2, num17 + num3 - num62, num16 + num4, num17 + num5 - num62 + 2.0 * num7);
				num2 = num4;
				num3 = num5;
				num4 = num2 + num7;
				num5 = num3;
				num18 = (ushort)(num + 1);
				num = num18;
				DrawLine(streamWriter, num18, text, num16 + num2, num17 + num3, num16 + num4, num17 + num5);
				num18 = (ushort)(num + 1);
				num = num18;
				DrawLine(streamWriter, num18, text, num16 + num2, num17 + num3 - num62 + 2.0 * num7, num16 + num4, num17 + num5 - num62 + 2.0 * num7);
				num2 = num4;
				num3 = num5;
				num4 = num2;
				num5 = num3 + num7;
				num18 = (ushort)(num + 1);
				num = num18;
				DrawLine(streamWriter, num18, text, num16 + num2, num17 + num3, num16 + num4, num17 + num5);
				num18 = (ushort)(num + 1);
				num = num18;
				DrawLine(streamWriter, num18, text, num16 + num2, num17 + num3 - num62 + num7, num16 + num4, num17 + num5 - num62 + num7);
				if (implementation == 1 && zhyrFiltr == "так")
				{
					num = DrawZaklepka_Top_1(streamWriter, num, text, connection, num4 + num16, num5 + num17, num4 + num16, num5 - num62 + num17, 0, G - 10);
				}
				double num69 = num4 - num7 / 2.0;
				double num70 = num5 - num62;
				num2 = num4;
				num3 = num5;
				num4 = num2 + (double)B;
				num5 = num3;
				num18 = (ushort)(num + 1);
				num = num18;
				DrawLine(streamWriter, num18, text, num16 + num2, num17 + num3, num16 + num4, num17 + num5);
				num18 = (ushort)(num + 1);
				num = num18;
				DrawLine(streamWriter, num18, text, num16 + num2, num17 + num3 - num62, num16 + num4, num17 + num5 - num62);
				num = DrawZaklepka_Top(streamWriter, num, text, connection, num2 + num16, num3 + num17, num4 + num16, num5 + num17, 1);
				num = DrawZaklepka_Top(streamWriter, num, text, connection, num2 + num16, num3 + num17 - num62, num4 + num16, num5 + num17 - num62, 0);
				num2 = num4;
				num3 = num5;
				num4 = num2;
				num5 = num3 - num7;
				num18 = (ushort)(num + 1);
				num = num18;
				DrawLine(streamWriter, num18, text, num16 + num2, num17 + num3, num16 + num4, num17 + num5);
				num18 = (ushort)(num + 1);
				num = num18;
				DrawLine(streamWriter, num18, text, num16 + num2, num17 + num3 - num62, num16 + num4, num17 + num5 - num62 + 2.0 * num7);
				num2 = num4;
				num3 = num5;
				num4 = num2 + num7;
				num5 = num3;
				num18 = (ushort)(num + 1);
				num = num18;
				DrawLine(streamWriter, num18, text, num16 + num2, num17 + num3, num16 + num4, num17 + num5);
				num18 = (ushort)(num + 1);
				num = num18;
				DrawLine(streamWriter, num18, text, num16 + num2, num17 + num3 - num62 + 2.0 * num7, num16 + num4, num17 + num5 - num62 + 2.0 * num7);
				num2 = num4;
				num3 = num5;
				num4 = num2;
				num5 = num3 + num7;
				num18 = (ushort)(num + 1);
				num = num18;
				DrawLine(streamWriter, num18, text, num16 + num2, num17 + num3, num16 + num4, num17 + num5);
				num18 = (ushort)(num + 1);
				num = num18;
				DrawLine(streamWriter, num18, text, num16 + num2, num17 + num3 - num62 + num7, num16 + num4, num17 + num5 - num62 + num7);
				num2 = num4;
				num3 = num5;
				num4 = num2 + (double)H;
				num5 = num3;
				num18 = (ushort)(num + 1);
				num = num18;
				DrawLine(streamWriter, num18, text, num16 + num2, num17 + num3, num16 + num4, num17 + num5);
				num18 = (ushort)(num + 1);
				num = num18;
				DrawLine(streamWriter, num18, text, num16 + num2, num17 + num3 - num62, num16 + num4, num17 + num5 - num62);
				num = DrawZaklepka_Top(streamWriter, num, text, connection, num2 + num16, num3 + num17, num4 + num16, num5 + num17, 1);
				num = DrawZaklepka_Top(streamWriter, num, text, connection, num2 + num16, num3 + num17 - num62, num4 + num16, num5 + num17 - num62, 0);
				num60 = 10.0;
				if (implementation == 2 || (implementation == 1 && connection != "зварка"))
				{
					num2 = num4;
					num3 = num5;
					num4 = num2;
					num5 = num3 - num7;
					num18 = (ushort)(num + 1);
					num = num18;
					DrawLine(streamWriter, num18, text, num16 + num2, num17 + num3, num16 + num4, num17 + num5);
					num18 = (ushort)(num + 1);
					num = num18;
					DrawLine(streamWriter, num18, text, num16 + num2, num17 + num3 - num62, num16 + num4, num17 + num5 - num62 + 2.0 * num7);
					num2 = num4;
					num3 = num5;
					num4 = num2 + num7;
					num5 = num3;
					num18 = (ushort)(num + 1);
					num = num18;
					DrawLine(streamWriter, num18, text, num16 + num2, num17 + num3, num16 + num4, num17 + num5);
					num18 = (ushort)(num + 1);
					num = num18;
					DrawLine(streamWriter, num18, text, num16 + num2, num17 + num3 - num62 + 2.0 * num7, num16 + num4, num17 + num5 - num62 + 2.0 * num7);
					num2 = num4;
					num3 = num5;
					num4 = num2;
					num5 = num3 + num7;
					num18 = (ushort)(num + 1);
					num = num18;
					DrawLine(streamWriter, num18, text, num16 + num2, num17 + num3, num16 + num4, num17 + num5);
					num18 = (ushort)(num + 1);
					num = num18;
					DrawLine(streamWriter, num18, text, num16 + num2, num17 + num3 - num62 + num7, num16 + num4, num17 + num5 - num62 + num7);
					num2 = num4;
					num3 = num5;
					num4 = num2 + num61 - num7;
					num5 = num3;
					num18 = (ushort)(num + 1);
					num = num18;
					DrawLine(streamWriter, num18, text, num16 + num2, num17 + num3, num16 + num4, num17 + num5);
					num18 = (ushort)(num + 1);
					num = num18;
					DrawLine(streamWriter, num18, text, num16 + num2, num17 + num3 - num62, num16 + num4, num17 + num5 - num62);
					num2 = num4;
					num3 = num5;
					num4 = num2;
					num5 = num3 - num7;
					num18 = (ushort)(num + 1);
					num = num18;
					DrawLine(streamWriter, num18, text, num16 + num2, num17 + num3, num16 + num4, num17 + num5);
					num18 = (ushort)(num + 1);
					num = num18;
					DrawLine(streamWriter, num18, text, num16 + num2, num17 + num3 - num62, num16 + num4, num17 + num5 - num62 + 2.0 * num7);
					num2 = num4;
					num3 = num5;
					num4 = num2 + num7;
					num5 = num3;
					num18 = (ushort)(num + 1);
					num = num18;
					DrawLine(streamWriter, num18, text, num16 + num2, num17 + num3, num16 + num4, num17 + num5);
					num18 = (ushort)(num + 1);
					num = num18;
					DrawLine(streamWriter, num18, text, num16 + num2, num17 + num3 - num62 + 2.0 * num7, num16 + num4, num17 + num5 - num62 + 2.0 * num7);
					num2 = num4;
					num3 = num5;
					num4 = num2;
					num5 = num3 + num7;
					num18 = (ushort)(num + 1);
					num = num18;
					DrawLine(streamWriter, num18, text, num16 + num2, num17 + num3, num16 + num4, num17 + num5);
					num18 = (ushort)(num + 1);
					num = num18;
					DrawLine(streamWriter, num18, text, num16 + num2, num17 + num3 - num62 + num7, num16 + num4, num17 + num5 - num62 + num7);
					num2 = num4;
					num3 = num5;
					num4 = num2 + num60;
					num5 = num3;
					num18 = (ushort)(num + 1);
					num = num18;
					DrawLine(streamWriter, num18, text, num16 + num2, num17 + num3, num16 + num4, num17 + num5);
					num18 = (ushort)(num + 1);
					num = num18;
					DrawLine(streamWriter, num18, text, num16 + num2, num17 + num3 - num62, num16 + num4, num17 + num5 - num62);
					num2 = num4;
					num3 = num5;
					num4 = num2;
					num5 = num3 - num62;
					num18 = (ushort)(num + 1);
					num = num18;
					DrawLine(streamWriter, num18, text, num16 + num2, num17 + num3, num16 + num4, num17 + num5);
				}
				else
				{
					num2 = num4;
					num3 = num5;
					num4 = num2 + (num61 - num7);
					num5 = num3 - (num61 - num7);
					num18 = (ushort)(num + 1);
					num = num18;
					DrawLine(streamWriter, num18, text, num16 + num2, num17 + num3, num16 + num4, num17 + num5);
					num2 = num4;
					num3 = num5;
					num4 = num2 + num60;
					num5 = num3;
					num18 = (ushort)(num + 1);
					num = num18;
					DrawLine(streamWriter, num18, text, num16 + num2, num17 + num3, num16 + num4, num17 + num5);
					num2 = num4;
					num3 = num5;
					num4 = num2;
					num5 = num3 - (num62 - 2.0 * (num61 - num7));
					num18 = (ushort)(num + 1);
					num = num18;
					DrawLine(streamWriter, num18, text, num16 + num2, num17 + num3, num16 + num4, num17 + num5);
					num2 = num4;
					num3 = num5;
					num4 = num2 - num60;
					num5 = num3;
					num18 = (ushort)(num + 1);
					num = num18;
					DrawLine(streamWriter, num18, text, num16 + num2, num17 + num3, num16 + num4, num17 + num5);
					num2 = num4;
					num3 = num5;
					num4 = num2 - (num61 - num7);
					num5 = num3 - (num61 - num7);
					num18 = (ushort)(num + 1);
					num = num18;
					DrawLine(streamWriter, num18, text, num16 + num2, num17 + num3, num16 + num4, num17 + num5);
				}
				if (vyhid == "з виходом")
				{
					int num71 = d1;
					int num72 = a1;
					int num73 = b1;
					int num74 = d2;
					int num75 = a2;
					int num76 = b2;
					int num77 = d3;
					int num78 = a3;
					int num79 = b3;
					int num80 = 3;
					int num81 = 2;
					int num82 = 3;
					int num83 = 5;
					if (connection == "зварка")
					{
						if (typVyhid1 == "мінус")
						{
							d1 -= num80;
							a1 -= num80;
							b1 -= num80;
						}
						if (typVyhid2 == "мінус")
						{
							d2 -= num80;
							a2 -= num80;
							b2 -= num80;
						}
						if (typVyhid3 == "мінус")
						{
							d3 -= num80;
							a3 -= num80;
							b3 -= num80;
						}
					}
					if (connection == "заклепка")
					{
						if (typVyhid1 == "чисто" || typVyhid1 == "фланець")
						{
							d1 -= num81;
							a1 += num82;
							b1 += num82;
						}
						if (typVyhid1 == "мінус")
						{
							d1 -= num83;
						}
						if (typVyhid2 == "чисто" || typVyhid2 == "фланець")
						{
							d2 -= num81;
							a2 += num82;
							b2 += num82;
						}
						if (typVyhid2 == "мінус")
						{
							d2 -= num83;
						}
						if (typVyhid3 == "чисто" || typVyhid3 == "фланець")
						{
							d3 -= num81;
							a3 += num82;
							b3 += num82;
						}
						if (typVyhid3 == "мінус")
						{
							d3 -= num83;
						}
					}
					num16 += num69 + num7 / 2.0;
					num17 += num70 - 0.5 * ((double)L - num62);
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
					d1 = num71;
					a1 = num72;
					b1 = num73;
					d2 = num74;
					a2 = num75;
					b2 = num76;
					d3 = num77;
					a3 = num78;
					b3 = num79;
				}
				if (implementation == 1 && zhyrFiltr == "так")
				{
					double num84 = 9.5;
					double num85 = 69.0;
					double num86 = 59.5;
					double num87 = 15.0;
					double num88 = 19.5;
					double num89 = 95.0;
					num16 = B + 200;
					num17 = 0.0;
					num2 = 0.0;
					num3 = 0.0;
					num4 = num2;
					num5 = num3 + num89;
					num18 = (ushort)(num + 1);
					num = num18;
					DrawLine(streamWriter, num18, text, num16 + num2, num17 + num3, num16 + num4, num17 + num5);
					num2 = num4;
					num3 = num5;
					num4 = num2 + (double)L - 10.0;
					num5 = num3;
					num18 = (ushort)(num + 1);
					num = num18;
					DrawLine(streamWriter, num18, text, num16 + num2, num17 + num3, num16 + num4, num17 + num5);
					num2 = num4;
					num3 = num5;
					num4 = num2;
					num5 = num3 - num89;
					num18 = (ushort)(num + 1);
					num = num18;
					DrawLine(streamWriter, num18, text, num16 + num2, num17 + num3, num16 + num4, num17 + num5);
					num2 = num4;
					num3 = num5;
					num4 = num2 - (double)(L - 10);
					num5 = num3;
					num18 = (ushort)(num + 1);
					num = num18;
					DrawLine(streamWriter, num18, text, num16 + num2, num17 + num3, num16 + num4, num17 + num5);
					num16 = B + 200;
					num17 = num89 + 100.0;
					num2 = num87;
					num3 = 0.0;
					num4 = num2;
					num5 = num3 + num88;
					num18 = (ushort)(num + 1);
					num = num18;
					DrawLine(streamWriter, num18, text, num16 + num2, num17 + num3, num16 + num4, num17 + num5);
					num2 = num4;
					num3 = num5;
					num4 = num2 + num7;
					num5 = num3;
					num18 = (ushort)(num + 1);
					num = num18;
					DrawLine(streamWriter, num18, text, num16 + num2, num17 + num3, num16 + num4, num17 + num5);
					num2 = num4;
					num3 = num5;
					num4 = num2;
					num5 = num3 + num7;
					num18 = (ushort)(num + 1);
					num = num18;
					DrawLine(streamWriter, num18, text, num16 + num2, num17 + num3, num16 + num4, num17 + num5);
					num2 = num4;
					num3 = num5;
					num4 = num2 - num7 - num87;
					num5 = num3;
					num18 = (ushort)(num + 1);
					num = num18;
					DrawLine(streamWriter, num18, text, num16 + num2, num17 + num3, num16 + num4, num17 + num5);
					num2 = num4;
					num3 = num5;
					num4 = num2;
					num5 = num3 + num86;
					num18 = (ushort)(num + 1);
					num = num18;
					DrawLine(streamWriter, num18, text, num16 + num2, num17 + num3, num16 + num4, num17 + num5);
					num2 = num4;
					num3 = num5;
					num4 = num2 + num7;
					num5 = num3;
					num18 = (ushort)(num + 1);
					num = num18;
					DrawLine(streamWriter, num18, text, num16 + num2, num17 + num3, num16 + num4, num17 + num5);
					num2 = num4;
					num3 = num5;
					num4 = num2;
					num5 = num3 + num7;
					num18 = (ushort)(num + 1);
					num = num18;
					DrawLine(streamWriter, num18, text, num16 + num2, num17 + num3, num16 + num4, num17 + num5);
					num2 = num4;
					num3 = num5;
					num4 = num2 - num7;
					num5 = num3;
					num18 = (ushort)(num + 1);
					num = num18;
					DrawLine(streamWriter, num18, text, num16 + num2, num17 + num3, num16 + num4, num17 + num5);
					num2 = num4;
					num3 = num5;
					num4 = num2;
					num5 = num3 + num85;
					num18 = (ushort)(num + 1);
					num = num18;
					DrawLine(streamWriter, num18, text, num16 + num2, num17 + num3, num16 + num4, num17 + num5);
					num2 = num4;
					num3 = num5;
					num4 = num2 + num7;
					num5 = num3;
					num18 = (ushort)(num + 1);
					num = num18;
					DrawLine(streamWriter, num18, text, num16 + num2, num17 + num3, num16 + num4, num17 + num5);
					num2 = num4;
					num3 = num5;
					num4 = num2;
					num5 = num3 + num7;
					num18 = (ushort)(num + 1);
					num = num18;
					DrawLine(streamWriter, num18, text, num16 + num2, num17 + num3, num16 + num4, num17 + num5);
					num2 = num4;
					num3 = num5;
					num4 = num2 - num7;
					num5 = num3;
					num18 = (ushort)(num + 1);
					num = num18;
					DrawLine(streamWriter, num18, text, num16 + num2, num17 + num3, num16 + num4, num17 + num5);
					num2 = num4;
					num3 = num5;
					num4 = num2;
					num5 = num3 + num84;
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
					num5 = num3 - num84;
					num18 = (ushort)(num + 1);
					num = num18;
					DrawLine(streamWriter, num18, text, num16 + num2, num17 + num3, num16 + num4, num17 + num5);
					num2 = num4;
					num3 = num5;
					num4 = num2 - num7;
					num5 = num3;
					num18 = (ushort)(num + 1);
					num = num18;
					DrawLine(streamWriter, num18, text, num16 + num2, num17 + num3, num16 + num4, num17 + num5);
					num2 = num4;
					num3 = num5;
					num4 = num2;
					num5 = num3 - num7;
					num18 = (ushort)(num + 1);
					num = num18;
					DrawLine(streamWriter, num18, text, num16 + num2, num17 + num3, num16 + num4, num17 + num5);
					num2 = num4;
					num3 = num5;
					num4 = num2 + num7;
					num5 = num3;
					num18 = (ushort)(num + 1);
					num = num18;
					DrawLine(streamWriter, num18, text, num16 + num2, num17 + num3, num16 + num4, num17 + num5);
					num2 = num4;
					num3 = num5;
					num4 = num2;
					num5 = num3 - num85;
					num18 = (ushort)(num + 1);
					num = num18;
					DrawLine(streamWriter, num18, text, num16 + num2, num17 + num3, num16 + num4, num17 + num5);
					num2 = num4;
					num3 = num5;
					num4 = num2 - num7;
					num5 = num3;
					num18 = (ushort)(num + 1);
					num = num18;
					DrawLine(streamWriter, num18, text, num16 + num2, num17 + num3, num16 + num4, num17 + num5);
					num2 = num4;
					num3 = num5;
					num4 = num2;
					num5 = num3 - num7;
					num18 = (ushort)(num + 1);
					num = num18;
					DrawLine(streamWriter, num18, text, num16 + num2, num17 + num3, num16 + num4, num17 + num5);
					num2 = num4;
					num3 = num5;
					num4 = num2 + num7;
					num5 = num3;
					num18 = (ushort)(num + 1);
					num = num18;
					DrawLine(streamWriter, num18, text, num16 + num2, num17 + num3, num16 + num4, num17 + num5);
					num2 = num4;
					num3 = num5;
					num4 = num2;
					num5 = num3 - num86;
					num18 = (ushort)(num + 1);
					num = num18;
					DrawLine(streamWriter, num18, text, num16 + num2, num17 + num3, num16 + num4, num17 + num5);
					num2 = num4;
					num3 = num5;
					num4 = num2 - num87 - num7;
					num5 = num3;
					num18 = (ushort)(num + 1);
					num = num18;
					DrawLine(streamWriter, num18, text, num16 + num2, num17 + num3, num16 + num4, num17 + num5);
					num2 = num4;
					num3 = num5;
					num4 = num2;
					num5 = num3 - num7;
					num18 = (ushort)(num + 1);
					num = num18;
					DrawLine(streamWriter, num18, text, num16 + num2, num17 + num3, num16 + num4, num17 + num5);
					num2 = num4;
					num3 = num5;
					num4 = num2 + num7;
					num5 = num3;
					num18 = (ushort)(num + 1);
					num = num18;
					DrawLine(streamWriter, num18, text, num16 + num2, num17 + num3, num16 + num4, num17 + num5);
					num2 = num4;
					num3 = num5;
					num4 = num2;
					num5 = num3 - num88;
					num18 = (ushort)(num + 1);
					num = num18;
					DrawLine(streamWriter, num18, text, num16 + num2, num17 + num3, num16 + num4, num17 + num5);
					num2 = num4;
					num3 = num5;
					num4 = num2 - ((double)(L - 5) - 2.0 * num87);
					num5 = num3;
					num18 = (ushort)(num + 1);
					num = num18;
					DrawLine(streamWriter, num18, text, num16 + num2, num17 + num3, num16 + num4, num17 + num5);
					num = DrawZaklepka_1(streamWriter, num, text, connection, num4 - 2.5 - num87 + num16, num5 + num17, num2 + 2.5 + num87 + num16, num3 + num17, 0);
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
					num84 = 19.5;
					double num90 = 1.0;
					num85 = 19.0;
					num86 = 42.5;
					num16 = B + 500;
					num17 = 600.0;
					num2 = 0.0;
					num3 = 0.0;
					num4 = num2;
					num5 = num3 + num86;
					num18 = (ushort)(num + 1);
					num = num18;
					DrawLine(streamWriter, num18, text, num16 + num2, num17 + num3, num16 + num4, num17 + num5);
					num2 = num4;
					num3 = num5;
					num4 = num2 + num84;
					num5 = num3;
					num18 = (ushort)(num + 1);
					num = num18;
					DrawLine(streamWriter, num18, text, num16 + num2, num17 + num3, num16 + num4, num17 + num5);
					num2 = num4;
					num3 = num5;
					num4 = num2;
					num5 = num3 - num90;
					num18 = (ushort)(num + 1);
					num = num18;
					DrawLine(streamWriter, num18, text, num16 + num2, num17 + num3, num16 + num4, num17 + num5);
					num2 = num4;
					num3 = num5;
					num4 = num2 + num90;
					num5 = num3;
					num18 = (ushort)(num + 1);
					num = num18;
					DrawLine(streamWriter, num18, text, num16 + num2, num17 + num3, num16 + num4, num17 + num5);
					num2 = num4;
					num3 = num5;
					num4 = num2;
					num5 = num3 + num90;
					num18 = (ushort)(num + 1);
					num = num18;
					DrawLine(streamWriter, num18, text, num16 + num2, num17 + num3, num16 + num4, num17 + num5);
					num2 = num4;
					num3 = num5;
					num4 = num2 + num84 + num90;
					num5 = num3;
					num18 = (ushort)(num + 1);
					num = num18;
					DrawLine(streamWriter, num18, text, num16 + num2, num17 + num3, num16 + num4, num17 + num5);
					num2 = num4;
					num3 = num5;
					num4 = num2;
					num5 = num3 + num90;
					num18 = (ushort)(num + 1);
					num = num18;
					DrawLine(streamWriter, num18, text, num16 + num2, num17 + num3, num16 + num4, num17 + num5);
					num2 = num4;
					num3 = num5;
					num4 = num2 - num90;
					num5 = num3;
					num18 = (ushort)(num + 1);
					num = num18;
					DrawLine(streamWriter, num18, text, num16 + num2, num17 + num3, num16 + num4, num17 + num5);
					num2 = num4;
					num3 = num5;
					num4 = num2;
					num5 = num3 + (kk - 0.5);
					num18 = (ushort)(num + 1);
					num = num18;
					DrawLine(streamWriter, num18, text, num16 + num2, num17 + num3, num16 + num4, num17 + num5);
					num2 = num4;
					num3 = num5;
					num4 = num2 + (double)(ZontOstrivnyyTyp4.l + 30);
					num5 = num3;
					num18 = (ushort)(num + 1);
					num = num18;
					DrawLine(streamWriter, num18, text, num16 + num2, num17 + num3, num16 + num4, num17 + num5);
					num2 = num4;
					num3 = num5;
					num4 = num2;
					num5 = num3 - (kk - 0.5);
					num18 = (ushort)(num + 1);
					num = num18;
					DrawLine(streamWriter, num18, text, num16 + num2, num17 + num3, num16 + num4, num17 + num5);
					num2 = num4;
					num3 = num5;
					num4 = num2 - num90;
					num5 = num3;
					num18 = (ushort)(num + 1);
					num = num18;
					DrawLine(streamWriter, num18, text, num16 + num2, num17 + num3, num16 + num4, num17 + num5);
					num2 = num4;
					num3 = num5;
					num4 = num2;
					num5 = num3 - num90;
					num18 = (ushort)(num + 1);
					num = num18;
					DrawLine(streamWriter, num18, text, num16 + num2, num17 + num3, num16 + num4, num17 + num5);
					num2 = num4;
					num3 = num5;
					num4 = num2 + num90;
					num5 = num3;
					num18 = (ushort)(num + 1);
					num = num18;
					DrawLine(streamWriter, num18, text, num16 + num2, num17 + num3, num16 + num4, num17 + num5);
					num2 = num4;
					num3 = num5;
					num4 = num2;
					num5 = num3 - num86;
					num18 = (ushort)(num + 1);
					num = num18;
					DrawLine(streamWriter, num18, text, num16 + num2, num17 + num3, num16 + num4, num17 + num5);
					num2 = num4;
					num3 = num5;
					num4 = num2 - ((double)(ZontOstrivnyyTyp4.l + 30) - 0.5);
					num5 = num3;
					num18 = (ushort)(num + 1);
					num = num18;
					DrawLine(streamWriter, num18, text, num16 + num2, num17 + num3, num16 + num4, num17 + num5);
					num2 = num4;
					num3 = num5;
					num4 = num2;
					num5 = num3 + num90;
					num18 = (ushort)(num + 1);
					num = num18;
					DrawLine(streamWriter, num18, text, num16 + num2, num17 + num3, num16 + num4, num17 + num5);
					num2 = num4;
					num3 = num5;
					num4 = num2 - num90;
					num5 = num3;
					num18 = (ushort)(num + 1);
					num = num18;
					DrawLine(streamWriter, num18, text, num16 + num2, num17 + num3, num16 + num4, num17 + num5);
					num2 = num4;
					num3 = num5;
					num4 = num2;
					num5 = num3 - num90;
					num18 = (ushort)(num + 1);
					num = num18;
					DrawLine(streamWriter, num18, text, num16 + num2, num17 + num3, num16 + num4, num17 + num5);
					num2 = num4;
					num3 = num5;
					num4 = num2 - num85;
					num5 = num3;
					num18 = (ushort)(num + 1);
					num = num18;
					DrawLine(streamWriter, num18, text, num16 + num2, num17 + num3, num16 + num4, num17 + num5);
					num2 = num4;
					num3 = num5;
					num4 = num2;
					num5 = num3 + num90;
					num18 = (ushort)(num + 1);
					num = num18;
					DrawLine(streamWriter, num18, text, num16 + num2, num17 + num3, num16 + num4, num17 + num5);
					num2 = num4;
					num3 = num5;
					num4 = num2 - num90;
					num5 = num3;
					num18 = (ushort)(num + 1);
					num = num18;
					DrawLine(streamWriter, num18, text, num16 + num2, num17 + num3, num16 + num4, num17 + num5);
					num2 = num4;
					num3 = num5;
					num4 = num2;
					num5 = num3 - num90;
					num18 = (ushort)(num + 1);
					num = num18;
					DrawLine(streamWriter, num18, text, num16 + num2, num17 + num3, num16 + num4, num17 + num5);
					num2 = num4;
					num3 = num5;
					num4 = num2 - num84;
					num5 = num3;
					num18 = (ushort)(num + 1);
					num = num18;
					DrawLine(streamWriter, num18, text, num16 + num2, num17 + num3, num16 + num4, num17 + num5);
				}
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
			double num2 = 15.0;
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

	public static void ZontOstrivnyyTyp4DrawImage(string name, int implementation, int L, int B, int H, int number, string zontMaterial, string tovchynaMetaluZont, string connection, string zlyv, string fastening, string typeFastening, string vyhid, string vyhid1, int d1, int a1, int b1, int p1, int f1, int g1, string typVyhid1, string profilType1, string vyhid2, int d2, int a2, int b2, int p2, int f2, int g2, string typVyhid2, string profilType2, string vyhid3, int d3, int a3, int b3, int p3, int f3, int g3, string typVyhid3, string profilType3, string zhyrFiltr, int G, string zhyrFiltrMaterial, string tovchynaMetaluFiltr, string orderCode, string contragent, string filePath = null)
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
		//IL_6fa3: Unknown result type (might be due to invalid IL or missing references)
		//IL_6faa: Expected O, but got Unknown
		//IL_6faa: Unknown result type (might be due to invalid IL or missing references)
		//IL_6fb1: Expected O, but got Unknown
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
			string text = ((zhyrFiltr == "ні") ? "Зонт ЗВ-4 " : ("Зонт " + name + " "));
			text = text + L + "х" + B + "х" + H;
			if (zhyrFiltr == "так")
			{
				text += " з ж/ф ";
			}
			text = text + number + " шт";
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
			double num27 = (double)L * num18;
			double num28 = (double)H * num18;
			double num29 = (double)B * num18;
			double num30 = (double)G * num18;
			double num31 = num3;
			double num32 = (double)num6 + num27 * Math.Sin(num17);
			double num33 = num31 + num29;
			double num34 = num32;
			val2.DrawLine(val4, (float)num31, (float)num32, (float)num33, (float)num34);
			num33 = num31 + num27 * Math.Cos(num17);
			num34 = num6;
			val2.DrawLine(val4, (float)num31, (float)num32, (float)num33, (float)num34);
			num31 = num33;
			num32 = num34;
			num33 = num31 + num29;
			val2.DrawLine(val4, (float)num31, (float)num32, (float)num33, (float)num34);
			num31 = (double)num3 + num29;
			num32 = (double)num6 + num27 * Math.Sin(num17);
			num33 = num31 + num27 * Math.Cos(num17);
			num34 = num6;
			val2.DrawLine(val4, (float)num31, (float)num32, (float)num33, (float)num34);
			double num47;
			double num48;
			if (vyhid == "з виходом")
			{
				if (vyhid1 == "круглий")
				{
					double num35 = (double)f1 * num18;
					double num36 = (double)g1 * num18;
					double num37 = (double)d1 * num18;
					double num38 = (double)p1 * num18;
					num31 = (double)num3 + num36 + (num35 - num37 / 2.0) * Math.Cos(num17);
					num32 = (double)num6 + num27 * Math.Sin(num17) - (num35 - num37 / 2.0) * Math.Sin(num17);
					num33 = (double)num3 + num36 - num37 / 2.0 + num35 * Math.Cos(num17) - 5.0;
					num34 = num32 - num37 / 2.0 * Math.Sin(num17);
					double num39 = (double)num3 + num36 + (num35 + num37 / 2.0) * Math.Cos(num17);
					double num40 = num32 - num37 * Math.Sin(num17);
					double num41 = num32 - num38;
					double num42 = num34 - num38;
					double num43 = num40 - num38;
					val2.DrawBezier(val4, (float)num31, (float)num32, (float)num33, (float)num34, (float)num39, (float)num40, (float)num39, (float)num40);
					val2.DrawBezier(val4, (float)num31, (float)num41, (float)num33, (float)num42, (float)num39, (float)num43, (float)num39, (float)num43);
					num33 = num33 + num37 + 10.0;
					val2.DrawBezier(val4, (float)num31, (float)num32, (float)num33, (float)num34, (float)num39, (float)num40, (float)num39, (float)num40);
					val2.DrawBezier(val4, (float)num31, (float)num41, (float)num33, (float)num42, (float)num39, (float)num43, (float)num39, (float)num43);
					val2.DrawLine(val4, (float)num31, (float)num32, (float)num31, (float)num41);
					val2.DrawLine(val4, (float)num39, (float)num40, (float)num39, (float)num43);
					double num44 = num31 - (double)num14;
					double num45 = num32;
					double num46 = num41;
					val2.DrawLine(val3, (float)num31, (float)num32, (float)num44, (float)num45);
					val2.DrawLine(val3, (float)num31, (float)num41, (float)num44, (float)num46);
					DrawRows(num44 + 5.0, num46, num44 + 5.0, num45, num18, val2, val3);
					num47 = num44 - (double)num21;
					num48 = (num45 + num46) / 2.0;
					#if WINDOWS
					val9.FormatFlags = (StringFormatFlags)2;
					#endif
					val2.DrawString(p1.ToString(), val7, (Brush)(object)val8, (float)num47, (float)num48, val9);
				}
				else if (vyhid1 == "прямокутний")
				{
					double num35 = (double)f1 * num18;
					double num36 = (double)g1 * num18;
					double num49 = (double)a1 * num18;
					double num50 = (double)b1 * num18;
					double num38 = (double)p1 * num18;
					num31 = (double)num3 + num36 + (num35 - num49 / 2.0) * Math.Cos(num17) - num50 / 2.0;
					num32 = (double)num6 + num27 * Math.Sin(num17) - (num35 - num49 / 2.0) * Math.Sin(num17);
					num33 = num31 + num50;
					num34 = num32;
					val2.DrawLine(val4, (float)num31, (float)num32, (float)num33, (float)num34);
					double num40 = num32 - num38;
					val2.DrawLine(val4, (float)num31, (float)num32, (float)num31, (float)num40);
					double num51 = num34 - num38;
					val2.DrawLine(val4, (float)num33, (float)num34, (float)num33, (float)num51);
					val2.DrawLine(val4, (float)num31, (float)num40, (float)num33, (float)num51);
					double num52 = num31 - (double)num14;
					double num53 = num32;
					double num54 = num40;
					val2.DrawLine(val3, (float)num31, (float)num32, (float)num52, (float)num53);
					val2.DrawLine(val3, (float)num31, (float)num40, (float)num52, (float)num54);
					DrawRows(num52 + 5.0, num54, num52 + 5.0, num53, num18, val2, val3);
					num47 = num52 - (double)num21;
					num48 = (num53 + num54) / 2.0;
					#if WINDOWS
					val9.FormatFlags = (StringFormatFlags)2;
					#endif
					val2.DrawString(p1.ToString(), val7, (Brush)(object)val8, (float)num47, (float)num48, val9);
					num31 = num33;
					num32 = num34;
					num33 = num31 + num49 * Math.Cos(num17);
					num34 = num32 - num49 * Math.Sin(num17);
					val2.DrawLine(val4, (float)num31, (float)num32, (float)num33, (float)num34);
					num40 = num32 - num38;
					val2.DrawLine(val4, (float)num31, (float)num32, (float)num31, (float)num40);
					num51 = num34 - num38;
					val2.DrawLine(val4, (float)num33, (float)num34, (float)num33, (float)num51);
					val2.DrawLine(val4, (float)num31, (float)num40, (float)num33, (float)num51);
					num31 = num33;
					num32 = num34;
					num33 = num31 - num50;
					num34 = num32;
					val2.DrawLine(val4, (float)num31, (float)num32, (float)num33, (float)num34);
					num40 = num32 - num38;
					val2.DrawLine(val4, (float)num31, (float)num32, (float)num31, (float)num40);
					num51 = num34 - num38;
					val2.DrawLine(val4, (float)num33, (float)num34, (float)num33, (float)num51);
					val2.DrawLine(val4, (float)num31, (float)num40, (float)num33, (float)num51);
					num31 = num33;
					num32 = num34;
					num33 = num31 - num49 * Math.Cos(num17);
					num34 = num32 + num49 * Math.Sin(num17);
					val2.DrawLine(val4, (float)num31, (float)num32, (float)num33, (float)num34);
					num40 = num32 - num38;
					val2.DrawLine(val4, (float)num31, (float)num32, (float)num31, (float)num40);
					num51 = num34 - num38;
					val2.DrawLine(val4, (float)num33, (float)num34, (float)num33, (float)num51);
					val2.DrawLine(val4, (float)num31, (float)num40, (float)num33, (float)num51);
				}
				if (vyhid2 == "круглий")
				{
					double num55 = (double)f2 * num18;
					double num56 = (double)g2 * num18;
					double num57 = (double)d2 * num18;
					double num58 = (double)p2 * num18;
					num31 = (double)num3 + num56 + (num55 - num57 / 2.0) * Math.Cos(num17);
					num32 = (double)num6 + num27 * Math.Sin(num17) - (num55 - num57 / 2.0) * Math.Sin(num17);
					num33 = (double)num3 + num56 - num57 / 2.0 + num55 * Math.Cos(num17) - 5.0;
					num34 = num32 - num57 / 2.0 * Math.Sin(num17);
					double num39 = (double)num3 + num56 + (num55 + num57 / 2.0) * Math.Cos(num17);
					double num40 = num32 - num57 * Math.Sin(num17);
					double num59 = num32 - num58;
					double num60 = num34 - num58;
					double num61 = num40 - num58;
					val2.DrawBezier(val4, (float)num31, (float)num32, (float)num33, (float)num34, (float)num39, (float)num40, (float)num39, (float)num40);
					val2.DrawBezier(val4, (float)num31, (float)num59, (float)num33, (float)num60, (float)num39, (float)num61, (float)num39, (float)num61);
					num33 = num33 + num57 + 10.0;
					val2.DrawBezier(val4, (float)num31, (float)num32, (float)num33, (float)num34, (float)num39, (float)num40, (float)num39, (float)num40);
					val2.DrawBezier(val4, (float)num31, (float)num59, (float)num33, (float)num60, (float)num39, (float)num61, (float)num39, (float)num61);
					val2.DrawLine(val4, (float)num31, (float)num32, (float)num31, (float)num59);
					val2.DrawLine(val4, (float)num39, (float)num40, (float)num39, (float)num61);
					double num62 = num31 - (double)num14;
					double num63 = num32;
					double num64 = num59;
					val2.DrawLine(val3, (float)num31, (float)num32, (float)num62, (float)num63);
					val2.DrawLine(val3, (float)num31, (float)num59, (float)num62, (float)num64);
					DrawRows(num62 + 5.0, num64, num62 + 5.0, num63, num18, val2, val3);
					num47 = num62 - (double)num21;
					num48 = (num63 + num64) / 2.0;
					#if WINDOWS
					val9.FormatFlags = (StringFormatFlags)2;
					#endif
					val2.DrawString(p2.ToString(), val7, (Brush)(object)val8, (float)num47, (float)num48, val9);
				}
				else if (vyhid2 == "прямокутний")
				{
					double num55 = (double)f2 * num18;
					double num56 = (double)g2 * num18;
					double num65 = (double)a2 * num18;
					double num66 = (double)b2 * num18;
					double num58 = (double)p2 * num18;
					num31 = (double)num3 + num56 + (num55 - num65 / 2.0) * Math.Cos(num17) - num66 / 2.0;
					num32 = (double)num6 + num27 * Math.Sin(num17) - (num55 - num65 / 2.0) * Math.Sin(num17);
					num33 = num31 + num66;
					num34 = num32;
					val2.DrawLine(val4, (float)num31, (float)num32, (float)num33, (float)num34);
					double num40 = num32 - num58;
					val2.DrawLine(val4, (float)num31, (float)num32, (float)num31, (float)num40);
					double num51 = num34 - num58;
					val2.DrawLine(val4, (float)num33, (float)num34, (float)num33, (float)num51);
					val2.DrawLine(val4, (float)num31, (float)num40, (float)num33, (float)num51);
					double num67 = num31 - (double)num14;
					double num68 = num32;
					double num69 = num40;
					val2.DrawLine(val3, (float)num31, (float)num32, (float)num67, (float)num68);
					val2.DrawLine(val3, (float)num31, (float)num40, (float)num67, (float)num69);
					DrawRows(num67 + 5.0, num69, num67 + 5.0, num68, num18, val2, val3);
					num47 = num67 - (double)num21;
					num48 = (num68 + num69) / 2.0;
					#if WINDOWS
					val9.FormatFlags = (StringFormatFlags)2;
					#endif
					val2.DrawString(p2.ToString(), val7, (Brush)(object)val8, (float)num47, (float)num48, val9);
					num31 = num33;
					num32 = num34;
					num33 = num31 + num65 * Math.Cos(num17);
					num34 = num32 - num65 * Math.Sin(num17);
					val2.DrawLine(val4, (float)num31, (float)num32, (float)num33, (float)num34);
					num40 = num32 - num58;
					val2.DrawLine(val4, (float)num31, (float)num32, (float)num31, (float)num40);
					num51 = num34 - num58;
					val2.DrawLine(val4, (float)num33, (float)num34, (float)num33, (float)num51);
					val2.DrawLine(val4, (float)num31, (float)num40, (float)num33, (float)num51);
					num31 = num33;
					num32 = num34;
					num33 = num31 - num66;
					num34 = num32;
					val2.DrawLine(val4, (float)num31, (float)num32, (float)num33, (float)num34);
					num40 = num32 - num58;
					val2.DrawLine(val4, (float)num31, (float)num32, (float)num31, (float)num40);
					num51 = num34 - num58;
					val2.DrawLine(val4, (float)num33, (float)num34, (float)num33, (float)num51);
					val2.DrawLine(val4, (float)num31, (float)num40, (float)num33, (float)num51);
					num31 = num33;
					num32 = num34;
					num33 = num31 - num65 * Math.Cos(num17);
					num34 = num32 + num65 * Math.Sin(num17);
					val2.DrawLine(val4, (float)num31, (float)num32, (float)num33, (float)num34);
					num40 = num32 - num58;
					val2.DrawLine(val4, (float)num31, (float)num32, (float)num31, (float)num40);
					num51 = num34 - num58;
					val2.DrawLine(val4, (float)num33, (float)num34, (float)num33, (float)num51);
					val2.DrawLine(val4, (float)num31, (float)num40, (float)num33, (float)num51);
				}
				if (vyhid3 == "круглий")
				{
					double num70 = (double)f3 * num18;
					double num71 = (double)g3 * num18;
					double num72 = (double)d3 * num18;
					double num73 = (double)p3 * num18;
					num31 = (double)num3 + num71 + (num70 - num72 / 2.0) * Math.Cos(num17);
					num32 = (double)num6 + num27 * Math.Sin(num17) - (num70 - num72 / 2.0) * Math.Sin(num17);
					num33 = (double)num3 + num71 - num72 / 2.0 + num70 * Math.Cos(num17) - 5.0;
					num34 = num32 - num72 / 2.0 * Math.Sin(num17);
					double num39 = (double)num3 + num71 + (num70 + num72 / 2.0) * Math.Cos(num17);
					double num40 = num32 - num72 * Math.Sin(num17);
					double num74 = num32 - num73;
					double num75 = num34 - num73;
					double num76 = num40 - num73;
					val2.DrawBezier(val4, (float)num31, (float)num32, (float)num33, (float)num34, (float)num39, (float)num40, (float)num39, (float)num40);
					val2.DrawBezier(val4, (float)num31, (float)num74, (float)num33, (float)num75, (float)num39, (float)num76, (float)num39, (float)num76);
					num33 = num33 + num72 + 10.0;
					val2.DrawBezier(val4, (float)num31, (float)num32, (float)num33, (float)num34, (float)num39, (float)num40, (float)num39, (float)num40);
					val2.DrawBezier(val4, (float)num31, (float)num74, (float)num33, (float)num75, (float)num39, (float)num76, (float)num39, (float)num76);
					val2.DrawLine(val4, (float)num31, (float)num32, (float)num31, (float)num74);
					val2.DrawLine(val4, (float)num39, (float)num40, (float)num39, (float)num76);
					double num77 = num31 - (double)num14;
					double num78 = num32;
					double num79 = num74;
					val2.DrawLine(val3, (float)num31, (float)num32, (float)num77, (float)num78);
					val2.DrawLine(val3, (float)num31, (float)num74, (float)num77, (float)num79);
					DrawRows(num77 + 5.0, num79, num77 + 5.0, num78, num18, val2, val3);
					num47 = num77 - (double)num21;
					num48 = (num78 + num79) / 2.0;
					#if WINDOWS
					val9.FormatFlags = (StringFormatFlags)2;
					#endif
					val2.DrawString(p3.ToString(), val7, (Brush)(object)val8, (float)num47, (float)num48, val9);
				}
				else if (vyhid3 == "прямокутний")
				{
					double num70 = (double)f3 * num18;
					double num71 = (double)g3 * num18;
					double num80 = (double)a3 * num18;
					double num81 = (double)b3 * num18;
					double num73 = (double)p3 * num18;
					num31 = (double)num3 + num71 + (num70 - num80 / 2.0) * Math.Cos(num17) - num81 / 2.0;
					num32 = (double)num6 + num27 * Math.Sin(num17) - (num70 - num80 / 2.0) * Math.Sin(num17);
					num33 = num31 + num81;
					num34 = num32;
					val2.DrawLine(val4, (float)num31, (float)num32, (float)num33, (float)num34);
					double num40 = num32 - num73;
					val2.DrawLine(val4, (float)num31, (float)num32, (float)num31, (float)num40);
					double num51 = num34 - num73;
					val2.DrawLine(val4, (float)num33, (float)num34, (float)num33, (float)num51);
					val2.DrawLine(val4, (float)num31, (float)num40, (float)num33, (float)num51);
					double num82 = num31 - (double)num14;
					double num83 = num32;
					double num84 = num40;
					val2.DrawLine(val3, (float)num31, (float)num32, (float)num82, (float)num83);
					val2.DrawLine(val3, (float)num31, (float)num40, (float)num82, (float)num84);
					DrawRows(num82 + 5.0, num84, num82 + 5.0, num83, num18, val2, val3);
					num47 = num82 - (double)num21;
					num48 = (num83 + num84) / 2.0;
					#if WINDOWS
					val9.FormatFlags = (StringFormatFlags)2;
					#endif
					val2.DrawString(p3.ToString(), val7, (Brush)(object)val8, (float)num47, (float)num48, val9);
					num31 = num33;
					num32 = num34;
					num33 = num31 + num80 * Math.Cos(num17);
					num34 = num32 - num80 * Math.Sin(num17);
					val2.DrawLine(val4, (float)num31, (float)num32, (float)num33, (float)num34);
					num40 = num32 - num73;
					val2.DrawLine(val4, (float)num31, (float)num32, (float)num31, (float)num40);
					num51 = num34 - num73;
					val2.DrawLine(val4, (float)num33, (float)num34, (float)num33, (float)num51);
					val2.DrawLine(val4, (float)num31, (float)num40, (float)num33, (float)num51);
					num31 = num33;
					num32 = num34;
					num33 = num31 - num81;
					num34 = num32;
					val2.DrawLine(val4, (float)num31, (float)num32, (float)num33, (float)num34);
					num40 = num32 - num73;
					val2.DrawLine(val4, (float)num31, (float)num32, (float)num31, (float)num40);
					num51 = num34 - num73;
					val2.DrawLine(val4, (float)num33, (float)num34, (float)num33, (float)num51);
					val2.DrawLine(val4, (float)num31, (float)num40, (float)num33, (float)num51);
					num31 = num33;
					num32 = num34;
					num33 = num31 - num80 * Math.Cos(num17);
					num34 = num32 + num80 * Math.Sin(num17);
					val2.DrawLine(val4, (float)num31, (float)num32, (float)num33, (float)num34);
					num40 = num32 - num73;
					val2.DrawLine(val4, (float)num31, (float)num32, (float)num31, (float)num40);
					num51 = num34 - num73;
					val2.DrawLine(val4, (float)num33, (float)num34, (float)num33, (float)num51);
					val2.DrawLine(val4, (float)num31, (float)num40, (float)num33, (float)num51);
				}
			}
			num31 = num3;
			num32 = (double)num6 + num27 * Math.Sin(num17);
			num33 = num31;
			num34 = num32 + num28;
			val2.DrawLine(val4, (float)num31, (float)num32, (float)num33, (float)num34);
			num31 += num29;
			num33 = num31;
			num34 = num32 + num28;
			val2.DrawLine(val4, (float)num31, (float)num32, (float)num33, (float)num34);
			num31 = num33;
			num32 = num34;
			num33 = num31 - num29;
			num34 = num32;
			val2.DrawLine(val4, (float)num31, (float)num32, (float)num33, (float)num34);
			num31 = (double)num3 + num29;
			num32 = (double)num6 + num27 * Math.Sin(num17) + num28;
			num33 = num31 + num27 * Math.Cos(num17);
			num34 = num32 - num27 * Math.Sin(num17);
			val2.DrawLine(val4, (float)num31, (float)num32, (float)num33, (float)num34);
			num31 = num33;
			num32 = num34;
			num34 = num32 - num28;
			val2.DrawLine(val4, (float)num31, (float)num32, (float)num33, (float)num34);
			num31 = num3;
			num32 = (double)num6 + num27 * Math.Sin(num17);
			num33 = num31 - (double)num14;
			num34 = num32;
			val2.DrawLine(val3, (float)num31, (float)num32, (float)num33, (float)num34);
			num31 = num3;
			num32 = (double)num6 + num27 * Math.Sin(num17) + num28;
			num33 = num31 - (double)num14;
			num34 = num32;
			val2.DrawLine(val3, (float)num31, (float)num32, (float)num33, (float)num34);
			num31 = num3 - num14 + 5;
			num32 = (double)num6 + num27 * Math.Sin(num17);
			num33 = num31;
			num34 = num32 + num28;
			DrawRows(num31, num32, num33, num34, num18, val2, val3);
			num47 = num31 - (double)num21;
			num48 = (num32 + num34) / 2.0;
			#if WINDOWS
			val9.FormatFlags = (StringFormatFlags)2;
			#endif
			val2.DrawString(H.ToString(), val7, (Brush)(object)val8, (float)num47, (float)num48, val9);
			num31 = num3;
			num32 = (double)num6 + num27 * Math.Sin(num17) + num28;
			num33 = num31;
			num34 = num32 + (double)num14;
			val2.DrawLine(val3, (float)num31, (float)num32, (float)num33, (float)num34);
			num31 = (double)num3 + num29;
			num32 = (double)num6 + num27 * Math.Sin(num17) + num28;
			num33 = num31;
			num34 = num32 + (double)num14;
			val2.DrawLine(val3, (float)num31, (float)num32, (float)num33, (float)num34);
			num31 = num3;
			num32 = (double)num6 + num27 * Math.Sin(num17) + num28 + (double)num14 - 5.0;
			num33 = num31 + num29;
			num34 = num32;
			DrawRows(num31, num32, num33, num34, num18, val2, val3);
			num47 = (num31 + num33) / 2.0;
			num48 = num34 + (double)num21;
			#if WINDOWS
			val9.FormatFlags = (StringFormatFlags)1;
			#endif
			val2.DrawString(B.ToString(), val7, (Brush)(object)val8, (float)num47, (float)num48, val9);
			num31 = (double)num3 + num29 + num27 * Math.Cos(num17);
			num32 = (double)num6 + num28;
			num33 = num31;
			num34 = num32 + (double)num14;
			val2.DrawLine(val3, (float)num31, (float)num32, (float)num33, (float)num34);
			num31 = (double)num3 + num29;
			num32 = (double)num6 + num27 * Math.Sin(num17) + num28 + (double)num14 - 5.0;
			num33 = num31 + num27 * Math.Cos(num17);
			num34 = (double)num6 + num28 + (double)num14 - 5.0;
			DrawRows(num31, num32, num33, num34, num18, val2, val3);
			num47 = (num31 + num33) / 2.0;
			num48 = (num32 + num34) / 2.0 + 15.0 + 5.0;
			#if WINDOWS
			val9.FormatFlags = (StringFormatFlags)1;
			#endif
			val2.DrawString(L.ToString(), val7, (Brush)(object)val8, (float)num47, (float)num48, val9);
			int num85 = ((name == "ЗВП-4") ? 1 : 2);
			if (zhyrFiltr == "так")
			{
				double num86 = 100.0;
				double num87 = 20.0;
				double num88 = 20.0;
				double num89 = 20.0;
				double num90 = 60.0;
				double num91 = 70.0;
				double num92 = 10.0;
				double num93 = 45.0;
				double num94 = 35.0;
				double num95 = 20.0;
				double num96 = 110.0;
				double num97 = 25.0;
				double num98 = 55.0;
				double num99 = 15.0;
				double num100 = 30.0;
				double num101 = 10.0;
				double num102 = 30.0;
				double num103 = 10.0;
				double num104 = num86 * num18;
				double num105 = num87 * num18;
				double num106 = num89 * num18;
				double num107 = num88 * num18;
				double num108 = num90 * num18;
				double num109 = num91 * num18;
				double num110 = num92 * num18;
				double num111 = num93 * num18;
				double num112 = num94 * num18;
				double num113 = num95 * num18;
				double num114 = num96 * num18;
				double num115 = num97 * num18;
				double num116 = num98 * num18;
				double num117 = num99 * num18;
				double num118 = num100 * num18;
				double num119 = num101 * num18;
				double num120 = num102 * num18;
				double num121 = num103 * num18;
				double num122 = 0.0;
				if (num85 == 1)
				{
					if (implementation == 1)
					{
						num31 = num3;
						num32 = (double)num6 + num27 * Math.Sin(num17) + num28;
						num33 = num31 + num104;
						num34 = num32;
						val2.DrawLine(val5, (float)num31, (float)num32, (float)num33, (float)num34);
						num31 = num33;
						num32 = num34;
						num33 = num31;
						num34 = num32 - num105;
						val2.DrawLine(val5, (float)num31, (float)num32, (float)num33, (float)num34);
						if (G < B)
						{
							num31 = (double)num3 + num30;
							num32 = (double)num6 + num27 * Math.Sin(num17);
							num33 = num31;
							num34 = num32 + (double)num14;
							val2.DrawLine(val3, (float)num31, (float)num32, (float)num33, (float)num34);
							num31 = num3;
							num32 = (double)num6 + num27 * Math.Sin(num17) + (double)num14 - 5.0;
							num34 -= 5.0;
							DrawRows(num31, num32, num33, num34, num18, val2, val3);
							num47 = (num31 + num33) / 2.0;
							num48 = num34 + (double)num21 + 3.0;
							#if WINDOWS
							val9.FormatFlags = (StringFormatFlags)1;
							#endif
							val2.DrawString(G.ToString(), val7, (Brush)(object)val8, (float)num47, (float)num48, val9);
						}
						num31 = (double)num3 + num30;
						num32 = (double)num6 + num27 * Math.Sin(num17);
						num33 = num31 - num106;
						num34 = num32;
						val2.DrawLine(val5, (float)num31, (float)num32, (float)num33, (float)num34);
						num31 = (double)num3 + num30;
						num32 = (double)num6 + num27 * Math.Sin(num17);
						num33 = num31;
						num34 = num32 + num108;
						val2.DrawLine(val5, (float)num31, (float)num32, (float)num33, (float)num34);
						num31 = (double)num3 + num104;
						num32 = (double)num6 + num27 * Math.Sin(num17) + num28 - num105;
						double num123 = 45.0;
						double num124 = 1E-05;
						double num125 = Math.Atan((num32 - num34) / (num33 - num31));
						double num126 = Math.Atan((num32 - num34) / (num33 - num31 - num92));
						while (num126 - num125 > num124)
						{
							num122 = (num125 + num126) / 2.0;
							double num127 = Math.Tan(num125) - (num32 - num34 + num110 * Math.Cos(num125)) / (num33 - num31 - num110 * Math.Sin(num125));
							double num128 = Math.Tan(num122) - (num32 - num34 + num110 * Math.Cos(num122)) / (num33 - num31 - num110 * Math.Sin(num122));
							if (num127 * num128 < 0.0)
							{
								num126 = num122;
							}
							else
							{
								num125 = num122;
							}
						}
						betaGradus = 90 - (int)Math.Round(num122 * 180.0 / Math.PI);
						num31 = (double)num3 + num30;
						num32 = (double)num6 + num27 * Math.Sin(num17) + num108;
						num33 = num31 - num109 * Math.Cos(num122);
						num34 = num32 + num109 * Math.Sin(num122);
						val2.DrawLine(val5, (float)num31, (float)num32, (float)num33, (float)num34);
						num31 = (double)num3 + num30 - num109 * Math.Cos(num122);
						num32 = (double)num6 + num27 * Math.Sin(num17) + num108 + num109 * Math.Sin(num122);
						num33 = num31 - num110 * Math.Sin(num122);
						num34 = num32 - num110 * Math.Cos(num122);
						val2.DrawLine(val5, (float)num31, (float)num32, (float)num33, (float)num34);
						double num129 = 40.0;
						double num130 = (double)G - num86 - num92 * Math.Sin(num122);
						double num131 = (double)H - num87 - num90 + num92 * Math.Cos(num122);
						l = (int)Math.Round(Math.Sqrt(num130 * num130 + num131 * num131) - num129);
						double num132 = 5.0;
						num31 = (double)num3 + num104 + num132 * Math.Cos(num122);
						num32 = (double)num6 + num27 * Math.Sin(num17) + num28 - num105 - num132 * Math.Sin(num122);
						num33 = num31 - num111 * Math.Sin(num122);
						num34 = num32 - num111 * Math.Cos(num122);
						val2.DrawLine(val5, (float)num31, (float)num32, (float)num33, (float)num34);
						num31 = (double)num3 + num104 + num132 * Math.Cos(num122);
						num32 = (double)num6 + num27 * Math.Sin(num17) + num28 - num105 - num132 * Math.Sin(num122);
						num33 = num31 + num112 * Math.Cos(num122);
						num34 = num32 - num112 * Math.Sin(num122);
						val2.DrawLine(val5, (float)num31, (float)num32, (float)num33, (float)num34);
						num31 = (double)num3 + num104 + num132 * Math.Cos(num122) - num111 * Math.Sin(num122);
						num32 = (double)num6 + num27 * Math.Sin(num17) + num28 - num105 - num132 * Math.Sin(num122) - num111 * Math.Cos(num122);
						num33 = num31 + num113 * Math.Cos(num122);
						num34 = num32 - num113 * Math.Sin(num122);
						val2.DrawLine(val5, (float)num31, (float)num32, (float)num33, (float)num34);
						double num133 = 4.0;
						double num134 = (double)l * num18 - num133;
						double num135 = num123 * num18 - 2.0 * num133;
						num31 = (double)num3 + num104 + num132 * Math.Cos(num122) - num133 * Math.Sin(num122) + num132 * Math.Cos(num122);
						num32 = (double)num6 + num27 * Math.Sin(num17) + num28 - num105 - num132 * Math.Sin(num122) - num133 * Math.Cos(num122) - num132 * Math.Sin(num122);
						num33 = num31 - num135 * Math.Sin(num122);
						num34 = num32 - num135 * Math.Cos(num122);
						val2.DrawLine(val5, (float)num31, (float)num32, (float)num33, (float)num34);
						num33 = num31 + num134 * Math.Cos(num122);
						num34 = num32 - num134 * Math.Sin(num122);
						double num136 = num33;
						double num137 = num34;
						val2.DrawLine(val5, (float)num31, (float)num32, (float)num33, (float)num34);
						num31 -= num135 * Math.Sin(num122);
						num32 -= num135 * Math.Cos(num122);
						num33 = num31 + num134 * Math.Cos(num122);
						num34 = num32 - num134 * Math.Sin(num122);
						double num138 = num33;
						double num139 = num34;
						val2.DrawLine(val5, (float)num31, (float)num32, (float)num33, (float)num34);
						val2.DrawLine(val5, (float)num136, (float)num137, (float)num138, (float)num139);
						num31 = (double)num3 + num104;
						num32 = (double)num6 + num27 * Math.Sin(num17) + num28 - num105;
						num33 = num31 - num107 * Math.Sin(num122);
						num34 = num32 - num107 * Math.Cos(num122);
						val2.DrawLine(val5, (float)num31, (float)num32, (float)num33, (float)num34);
						double num140 = 1.5;
						double num141 = 0.0;
						double num142 = 0.0;
						double num143 = 0.0;
						double num144 = 0.0;
						num104 = num86 * num140;
						num105 = num87 * num140;
						num107 = num88 * num140;
						num111 = num93 * num140;
						num112 = num94 * num140;
						num113 = num95 * num140;
						num114 = num96 * num140;
						num115 = num97 * num140;
						num116 = num98 * num140;
						num117 = num99 * num140;
						num28 = (double)H * num140;
						num29 = (double)B * num140;
						num106 = num89 * num140;
						num108 = num90 * num140;
						num109 = num91 * num140;
						num110 = num92 * num140;
						num143 = num - num4;
						num144 = (double)num26 + num22 * num18 + 40.0;
						num141 = (double)(num - num4) - num114;
						num142 = num144 + num108 + num109 + num116;
						num31 = num141;
						num32 = num142;
						num33 = num31 + num104;
						num34 = num32;
						val2.DrawLine(val5, (float)num31, (float)num32, (float)num33, (float)num34);
						num31 = num141;
						num32 = num142;
						num33 = num31;
						num34 = num32 + (double)num15;
						num136 = num33;
						num137 = num34;
						val2.DrawLine(val3, (float)num31, (float)num32, (float)num33, (float)num34);
						num31 += num104;
						num33 = num31;
						num138 = num33;
						num139 = num34;
						val2.DrawLine(val3, (float)num31, (float)num32, (float)num33, (float)num34);
						num31 = num136;
						num32 = num137 - 5.0;
						num33 = num138;
						num34 = num139 - 5.0;
						DrawRows(num31, num32, num33, num34, num18, val2, val3);
						num47 = (num136 + num138) / 2.0;
						num48 = num137 + (double)num21;
						#if WINDOWS
						val9.FormatFlags = (StringFormatFlags)1;
						#endif
						val2.DrawString(num86.ToString(), val7, (Brush)(object)val8, (float)num47, (float)num48, val9);
						num31 = num141 + num104;
						num32 = num142;
						num33 = num31;
						num34 = num32 - num105;
						val2.DrawLine(val5, (float)num31, (float)num32, (float)num33, (float)num34);
						num33 = num31 - (double)num15;
						num34 = num32;
						val2.DrawLine(val3, (float)num31, (float)num32, (float)num33, (float)num34);
						num32 = num142 - num105;
						num33 = num31 - (double)num15;
						num34 = num32;
						val2.DrawLine(val3, (float)num31, (float)num32, (float)num33, (float)num34);
						num31 = num33 + 5.0;
						num32 = num142;
						num33 = num31;
						num34 = num32 - num105;
						DrawRows(num33, num34, num31, num32, num18, val2, val3);
						num47 = num31 - (double)num21 - 3.0;
						num48 = (num32 + num34) / 2.0;
						#if WINDOWS
						val9.FormatFlags = (StringFormatFlags)1;
						#endif
						val2.DrawString(num87.ToString(), val7, (Brush)(object)val8, (float)num47, (float)num48, val9);
						num31 = num141 + num104;
						num32 = num142 - num105;
						num33 = num31 - num107 * Math.Sin(num122);
						num34 = num32 - num107 * Math.Cos(num122);
						val2.DrawLine(val5, (float)num31, (float)num32, (float)num33, (float)num34);
						num33 = num31 + (double)num15 * Math.Cos(num122);
						num34 = num32 - (double)num15 * Math.Sin(num122);
						num136 = num33;
						num137 = num34;
						val2.DrawLine(val3, (float)num31, (float)num32, (float)num33, (float)num34);
						num31 -= num107 * Math.Sin(num122);
						num32 -= num107 * Math.Cos(num122);
						num33 = num31 + (double)num15 * Math.Cos(num122);
						num34 = num32 - (double)num15 * Math.Sin(num122);
						val2.DrawLine(val3, (float)num31, (float)num32, (float)num33, (float)num34);
						num31 = num136 - 5.0 * Math.Cos(num122);
						num32 = num137 + 5.0 * Math.Sin(num122);
						num33 -= 5.0 * Math.Cos(num122);
						num34 += 5.0 * Math.Sin(num122);
						DrawRows(num33, num34, num31, num32, num18, val2, val3);
						num47 = (num31 + num33) / 2.0 + (double)num21;
						num48 = (num32 + num34) / 2.0 - (double)(num21 / 2);
						#if WINDOWS
						val9.FormatFlags = (StringFormatFlags)1;
						#endif
						val2.DrawString(num88.ToString(), val7, (Brush)(object)val8, (float)num47, (float)num48, val9);
						num31 = num141 + num104;
						num32 = num142 - num105;
						num33 = num31 + num107 * Math.Sin(num122);
						num34 = num32 + num107 * Math.Cos(num122);
						val2.DrawLine(val3, (float)num31, (float)num32, (float)num33, (float)num34);
						double num145 = 3.0 * num107 * Math.Sin(num122) / 4.0;
						double num146 = 3.0 * num107 * Math.Cos(num122) / 4.0;
						num31 = num141 + num104;
						num32 = num142 - num105 + num146;
						double num39 = num31 + num145;
						double num40 = num32;
						num33 = (num31 + num39) / 2.0 + 3.0;
						num34 = (num32 + num40) / 2.0 + 5.0 + 3.0;
						val2.DrawBezier(val3, (float)num31, (float)num32, (float)num33, (float)num34, (float)num39, (float)num40, (float)num39, (float)num40);
						string text2 = Math.Round(num122 * 180.0 / Math.PI) + "°";
						val2.DrawString(text2, val7, (Brush)(object)val8, (float)(num33 + 3.0), (float)(num34 + (double)num21), val9);
						num31 = num143;
						num32 = num144;
						num33 = num31 - num106;
						num34 = num32;
						val2.DrawLine(val5, (float)num31, (float)num32, (float)num33, (float)num34);
						num33 = num31;
						num34 = num32 - (double)num15;
						val2.DrawLine(val3, (float)num31, (float)num32, (float)num33, (float)num34);
						num31 = num33 - num106;
						num33 = num31;
						val2.DrawLine(val3, (float)num31, (float)num32, (float)num33, (float)num34);
						num31 = num143;
						num32 = num144 - (double)num15 + 5.0;
						num33 = num31 - num106;
						num34 = num32;
						DrawRows(num33, num34, num31, num32, num18, val2, val3);
						num47 = (num31 + num33) / 2.0;
						num48 = num32 - (double)num21 - 3.0;
						#if WINDOWS
						val9.FormatFlags = (StringFormatFlags)1;
						#endif
						val2.DrawString(num89.ToString(), val7, (Brush)(object)val8, (float)num47, (float)num48, val9);
						num31 = num143;
						num32 = num144;
						num33 = num31;
						num34 = num32 + num108;
						double num147 = num33;
						double num148 = num34;
						val2.DrawLine(val5, (float)num31, (float)num32, (float)num33, (float)num34);
						num33 = num31 + (double)num15;
						num34 = num32;
						num136 = num33;
						num137 = num34;
						val2.DrawLine(val3, (float)num31, (float)num32, (float)num33, (float)num34);
						num31 = num143;
						num32 = num144 + num108;
						num33 = num31 + (double)num15;
						num34 = num32;
						val2.DrawLine(val3, (float)num31, (float)num32, (float)num33, (float)num34);
						num31 = num136 - 5.0;
						num32 = num137;
						num33 -= 5.0;
						DrawRows(num31, num32, num33, num34, num18, val2, val3);
						num47 = num31 + (double)num21;
						num48 = (num32 + num34) / 2.0;
						#if WINDOWS
						val9.FormatFlags = (StringFormatFlags)1;
						#endif
						val2.DrawString(num90.ToString(), val7, (Brush)(object)val8, (float)num47, (float)num48, val9);
						num31 = num147;
						num32 = num148;
						num33 = num31 - num109 * Math.Cos(num122);
						num34 = num32 + num109 * Math.Sin(num122);
						val2.DrawLine(val5, (float)num31, (float)num32, (float)num33, (float)num34);
						num33 = num31 - (double)num15 * Math.Sin(num122);
						num34 = num32 - (double)num15 * Math.Cos(num122);
						num136 = num33;
						num137 = num34;
						val2.DrawLine(val3, (float)num31, (float)num32, (float)num33, (float)num34);
						num31 = num147 - num109 * Math.Cos(num122);
						num32 = num148 + num109 * Math.Sin(num122);
						num33 = num31 - (double)num15 * Math.Sin(num122);
						num34 = num32 - (double)num15 * Math.Cos(num122);
						val2.DrawLine(val3, (float)num31, (float)num32, (float)num33, (float)num34);
						num31 = num136 + 5.0 * Math.Sin(num122);
						num32 = num137 + 5.0 * Math.Cos(num122);
						num33 += 5.0 * Math.Sin(num122);
						num34 += 5.0 * Math.Cos(num122);
						DrawRows(num33, num34, num31, num32, num18, val2, val3);
						num47 = (num31 + num33) / 2.0 - (double)num21;
						num48 = (num32 + num34) / 2.0 - (double)(num21 / 2);
						#if WINDOWS
						val9.FormatFlags = (StringFormatFlags)1;
						#endif
						val2.DrawString(num91.ToString(), val7, (Brush)(object)val8, (float)num47, (float)num48, val9);
						num31 = num147;
						num32 = num148;
						num33 = num31;
						num34 = num32 + num109 * Math.Sin(num122);
						val2.DrawLine(val3, (float)num31, (float)num32, (float)num33, (float)num34);
						num145 = 3.0 * num109 * Math.Cos(num122) / 8.0;
						num146 = 3.0 * num109 * Math.Sin(num122) / 8.0;
						num31 = num147;
						num32 = num148 + num146;
						num39 = num31 - num145;
						num40 = num32;
						num33 = (num31 + num39) / 2.0;
						num34 = (num32 + num40) / 2.0 + 5.0;
						val2.DrawBezier(val3, (float)num31, (float)num32, (float)num33, (float)num34, (float)num39, (float)num40, (float)num39, (float)num40);
						text2 = Math.Round((Math.PI / 2.0 - num122) * 180.0 / Math.PI) + "°";
						val2.DrawString(text2, val7, (Brush)(object)val8, (float)(num33 + 3.0), (float)(num34 + (double)num21), val9);
						num31 = num147 - num109 * Math.Cos(num122);
						num32 = num148 + num109 * Math.Sin(num122);
						num33 = num31 - num110 * Math.Sin(num122);
						num34 = num32 - num110 * Math.Cos(num122);
						val2.DrawLine(val5, (float)num31, (float)num32, (float)num33, (float)num34);
						num33 = num31 - (double)num15 * Math.Cos(num122);
						num34 = num32 + (double)num15 * Math.Sin(num122);
						num136 = num33;
						num137 = num34;
						val2.DrawLine(val3, (float)num31, (float)num32, (float)num33, (float)num34);
						num31 = num147 - num109 * Math.Cos(num122) - num110 * Math.Sin(num122);
						num32 = num148 + num109 * Math.Sin(num122) - num110 * Math.Cos(num122);
						num33 = num31 - (double)num15 * Math.Cos(num122);
						num34 = num32 + (double)num15 * Math.Sin(num122);
						val2.DrawLine(val3, (float)num31, (float)num32, (float)num33, (float)num34);
						num31 = num136 + 5.0 * Math.Cos(num122);
						num32 = num137 - 5.0 * Math.Sin(num122);
						num33 += 5.0 * Math.Cos(num122);
						num34 -= 5.0 * Math.Sin(num122);
						DrawRows(num31, num32, num33, num34, num18, val2, val3);
						num47 = (num31 + num33) / 2.0 - (double)num21;
						num48 = (num32 + num34) / 2.0 + (double)(num21 / 2);
						#if WINDOWS
						val9.FormatFlags = (StringFormatFlags)1;
						#endif
						val2.DrawString(num92.ToString(), val7, (Brush)(object)val8, (float)num47, (float)num48, val9);
						num142 = num144 + num112;
						num31 = num141;
						num32 = num142;
						num33 = num31 + num111;
						num34 = num32;
						val2.DrawLine(val5, (float)num31, (float)num32, (float)num33, (float)num34);
						num31 = num141;
						num32 = num142;
						num33 = num31;
						num34 = num32 + (double)num15;
						num136 = num33;
						num137 = num34;
						val2.DrawLine(val3, (float)num31, (float)num32, (float)num33, (float)num34);
						num31 += num111;
						num33 = num31;
						num138 = num33;
						num139 = num34;
						val2.DrawLine(val3, (float)num31, (float)num32, (float)num33, (float)num34);
						num31 = num136;
						num32 = num137 - 5.0;
						num33 = num138;
						num34 = num139 - 5.0;
						DrawRows(num31, num32, num33, num34, num18, val2, val3);
						num47 = (num136 + num138) / 2.0;
						num48 = num137 + (double)num21;
						#if WINDOWS
						val9.FormatFlags = (StringFormatFlags)1;
						#endif
						val2.DrawString(num93.ToString(), val7, (Brush)(object)val8, (float)num47, (float)num48, val9);
						num31 = num141 + num111;
						num32 = num142;
						num33 = num31;
						num34 = num32 - num112;
						val2.DrawLine(val5, (float)num31, (float)num32, (float)num33, (float)num34);
						num33 = num31 - (double)num15;
						num34 = num32;
						val2.DrawLine(val3, (float)num31, (float)num32, (float)num33, (float)num34);
						num32 = num142 - num112;
						num33 = num31 - (double)num15;
						num34 = num32;
						val2.DrawLine(val3, (float)num31, (float)num32, (float)num33, (float)num34);
						num31 = num33 + 5.0;
						num32 = num142;
						num33 = num31;
						num34 = num32 - num112;
						DrawRows(num33, num34, num31, num32, num18, val2, val3);
						num47 = num31 - (double)num21 - 3.0;
						num48 = (num32 + num34) / 2.0;
						#if WINDOWS
						val9.FormatFlags = (StringFormatFlags)1;
						#endif
						val2.DrawString(num94.ToString(), val7, (Brush)(object)val8, (float)num47, (float)num48, val9);
						num31 = num141;
						num32 = num142;
						num33 = num31;
						num34 = num32 - num113;
						val2.DrawLine(val5, (float)num31, (float)num32, (float)num33, (float)num34);
						num33 = num31 - (double)num15;
						num34 = num32;
						val2.DrawLine(val3, (float)num31, (float)num32, (float)num33, (float)num34);
						num32 = num142 - num113;
						num33 = num31 - (double)num15;
						num34 = num32;
						val2.DrawLine(val3, (float)num31, (float)num32, (float)num33, (float)num34);
						num31 = num33 + 5.0;
						num32 = num142;
						num33 = num31;
						num34 = num32 - num113;
						DrawRows(num33, num34, num31, num32, num18, val2, val3);
						num47 = num31 - (double)num21 - 3.0;
						num48 = (num32 + num34) / 2.0;
						#if WINDOWS
						val9.FormatFlags = (StringFormatFlags)1;
						#endif
						val2.DrawString(num95.ToString(), val7, (Brush)(object)val8, (float)num47, (float)num48, val9);
					}
					else
					{
						num31 = num3;
						num32 = (double)num6 + num27 * Math.Sin(num17) + num28;
						num33 = num31 + num118;
						num34 = num32;
						val2.DrawLine(val5, (float)num31, (float)num32, (float)num33, (float)num34);
						num31 = num33;
						num34 = num32 - num119;
						val2.DrawLine(val5, (float)num31, (float)num32, (float)num33, (float)num34);
						num31 = (double)num3 + num29;
						num32 = (double)num6 + num27 * Math.Sin(num17) + num28;
						num33 = num31 - num118;
						num34 = num32;
						val2.DrawLine(val5, (float)num31, (float)num32, (float)num33, (float)num34);
						num31 = num33;
						num34 = num32 - num119;
						val2.DrawLine(val5, (float)num31, (float)num32, (float)num33, (float)num34);
						double num149 = 40.0;
						double num150 = num149 * num18;
						double num151 = 5.0;
						double num152 = num151 * num18;
						l = B - 2 * (int)num151;
						double num153 = 3.0;
						double num154 = (double)l * num18;
						num31 = (double)num3 + num152;
						num32 = (double)num6 + num27 * Math.Sin(num17) + num28 - num119 - num153;
						num33 = num31 + num154;
						num34 = num32;
						val2.DrawLine(val5, (float)num31, (float)num32, (float)num33, (float)num34);
						num33 = num31;
						num34 = num32 - num150;
						val2.DrawLine(val5, (float)num31, (float)num32, (float)num33, (float)num34);
						num31 += num154;
						num33 = num31;
						num34 = num32 - num150;
						val2.DrawLine(val5, (float)num31, (float)num32, (float)num33, (float)num34);
						num32 = num34;
						num33 = num31 - num154;
						val2.DrawLine(val5, (float)num31, (float)num32, (float)num33, (float)num34);
					}
				}
				else if (implementation == 1)
				{
					num31 = (double)num3 + num29 / 2.0 - num114 / 2.0;
					num32 = (double)num6 + num27 * Math.Sin(num17) + num28;
					num33 = num31 + num114;
					num34 = num32;
					val2.DrawLine(val5, (float)num31, (float)num32, (float)num33, (float)num34);
					num31 = (double)num3 + num29 / 2.0 - num114 / 2.0;
					num32 = (double)num6 + num27 * Math.Sin(num17) + num28;
					num33 = num31;
					num34 = num32 - num115;
					val2.DrawLine(val5, (float)num31, (float)num32, (float)num33, (float)num34);
					num31 = (double)num3 + num29 / 2.0 + num114 / 2.0;
					num32 = (double)num6 + num27 * Math.Sin(num17) + num28;
					num33 = num31;
					num34 = num32 - num115;
					val2.DrawLine(val5, (float)num31, (float)num32, (float)num33, (float)num34);
					double num155 = 4.0;
					num31 = (double)num3 + num29 / 2.0;
					num32 = (double)num6 + num27 * Math.Sin(num17) + num28 - num155;
					num33 = num31;
					num34 = num32 - (num116 - num155);
					val2.DrawLine(val5, (float)num31, (float)num32, (float)num33, (float)num34);
					num33 = num31 + num117;
					num34 = num32;
					val2.DrawLine(val5, (float)num31, (float)num32, (float)num33, (float)num34);
					if (G < B)
					{
						num31 = (double)num3 + (num29 - num30) / 2.0;
						num32 = (double)num6 + num27 * Math.Sin(num17);
						num33 = num31;
						num34 = num32 + (double)num14;
						val2.DrawLine(val3, (float)num31, (float)num32, (float)num33, (float)num34);
						num31 = (double)num3 + (num29 + num30) / 2.0;
						num32 = (double)num6 + num27 * Math.Sin(num17);
						num33 = num31;
						num34 = num32 + (double)num14;
						val2.DrawLine(val3, (float)num31, (float)num32, (float)num33, (float)num34);
						num31 = (double)num3 + (num29 - num30) / 2.0;
						num32 = (double)num6 + num27 * Math.Sin(num17) + (double)num14 - 5.0;
						num34 -= 5.0;
						DrawRows(num31, num32, num33, num34, num18, val2, val3);
						num47 = (num31 + num33) / 2.0;
						num48 = num34 + (double)num21 + 3.0;
						#if WINDOWS
						val9.FormatFlags = (StringFormatFlags)1;
						#endif
						val2.DrawString(G.ToString(), val7, (Brush)(object)val8, (float)num47, (float)num48, val9);
					}
					num31 = (double)num3 + (num29 + num30) / 2.0;
					num32 = (double)num6 + num27 * Math.Sin(num17);
					num33 = num31 - num106;
					num34 = num32;
					val2.DrawLine(val5, (float)num31, (float)num32, (float)num33, (float)num34);
					num31 = (double)num3 + (num29 - num30) / 2.0;
					num32 = (double)num6 + num27 * Math.Sin(num17);
					num33 = num31 + num106;
					num34 = num32;
					val2.DrawLine(val5, (float)num31, (float)num32, (float)num33, (float)num34);
					num31 = (double)num3 + (num29 + num30) / 2.0;
					num32 = (double)num6 + num27 * Math.Sin(num17);
					num33 = num31;
					num34 = num32 + num108;
					val2.DrawLine(val5, (float)num31, (float)num32, (float)num33, (float)num34);
					num31 = (double)num3 + (num29 - num30) / 2.0;
					num32 = (double)num6 + num27 * Math.Sin(num17);
					num33 = num31;
					num34 = num32 + num108;
					val2.DrawLine(val5, (float)num31, (float)num32, (float)num33, (float)num34);
					num31 = (double)num3 + num29 / 2.0;
					num32 = (double)num6 + num27 * Math.Sin(num17) + num28;
					num33 = (double)num3 + (num29 + num30) / 2.0;
					num34 = (double)num6 + num27 * Math.Sin(num17) + num108;
					double num156 = 40.0;
					double num157 = num156 * num18;
					double num158 = 1E-05;
					double num159 = Math.Atan((num32 - num34) / (num33 - num31));
					double num160 = Math.Atan((num32 - num34 + num92) / (num33 - num92 - (num31 + num157)));
					while (num160 - num159 > num158)
					{
						num122 = (num159 + num160) / 2.0;
						double num161 = num33 - num31 - (num157 + num110) * Math.Sin(num159) - (num32 - num34 + num110 * Math.Cos(num159)) / Math.Tan(num159);
						double num162 = num33 - num31 - (num157 + num110) * Math.Sin(num122) - (num32 - num34 + num110 * Math.Cos(num122)) / Math.Tan(num122);
						if (num161 * num162 < 0.0)
						{
							num160 = num122;
						}
						else
						{
							num159 = num122;
						}
					}
					betaGradus = 90 - (int)Math.Round(num122 * 180.0 / Math.PI);
					num31 = (double)num3 + (num29 + num30) / 2.0;
					num32 = (double)num6 + num27 * Math.Sin(num17) + num108;
					num33 = num31 - num109 * Math.Cos(num122);
					num34 = num32 + num109 * Math.Sin(num122);
					val2.DrawLine(val5, (float)num31, (float)num32, (float)num33, (float)num34);
					num31 = (double)num3 + (num29 - num30) / 2.0;
					num32 = (double)num6 + num27 * Math.Sin(num17) + num108;
					num33 = num31 + num109 * Math.Cos(num122);
					num34 = num32 + num109 * Math.Sin(num122);
					val2.DrawLine(val5, (float)num31, (float)num32, (float)num33, (float)num34);
					num31 = (double)num3 + (num29 + num30) / 2.0 - num109 * Math.Cos(num122);
					num32 = (double)num6 + num27 * Math.Sin(num17) + num108 + num109 * Math.Sin(num122);
					num33 = num31 - num110 * Math.Sin(num122);
					num34 = num32 - num110 * Math.Cos(num122);
					val2.DrawLine(val5, (float)num31, (float)num32, (float)num33, (float)num34);
					num31 = (double)num3 + (num29 - num30) / 2.0 + num109 * Math.Cos(num122);
					num32 = (double)num6 + num27 * Math.Sin(num17) + num108 + num109 * Math.Sin(num122);
					num33 = num31 + num110 * Math.Sin(num122);
					num34 = num32 - num110 * Math.Cos(num122);
					val2.DrawLine(val5, (float)num31, (float)num32, (float)num33, (float)num34);
					double num163 = 40.0;
					double num164 = (double)(G / 2) - (num156 + num92) * Math.Sin(num122);
					double num165 = (double)H - num90 + num92 * Math.Cos(num122);
					l = (int)Math.Round(Math.Sqrt(num164 * num164 + num165 * num165) - num163);
					double num166 = (double)l * num18 - num155;
					num31 = (double)num3 + num29 / 2.0 + num157 * Math.Sin(num122) + num155 * Math.Cos(num122);
					num32 = (double)num6 + num27 * Math.Sin(num17) + num28 - num155 * Math.Sin(num122);
					num33 = num31 - num157 * Math.Sin(num122);
					num34 = num32 - num157 * Math.Cos(num122);
					val2.DrawLine(val5, (float)num31, (float)num32, (float)num33, (float)num34);
					num33 = num31 + num166 * Math.Cos(num122);
					num34 = num32 - num166 * Math.Sin(num122);
					double num136 = num33;
					double num137 = num34;
					val2.DrawLine(val5, (float)num31, (float)num32, (float)num33, (float)num34);
					num31 -= num157 * Math.Sin(num122);
					num32 -= num157 * Math.Cos(num122);
					num33 = num31 + num166 * Math.Cos(num122);
					num34 = num32 - num166 * Math.Sin(num122);
					double num138 = num33;
					double num139 = num34;
					val2.DrawLine(val5, (float)num31, (float)num32, (float)num33, (float)num34);
					val2.DrawLine(val5, (float)num136, (float)num137, (float)num138, (float)num139);
					num31 = (double)num3 + num29 / 2.0 - num157 * Math.Sin(num122) - num155 * Math.Cos(num122);
					num32 = (double)num6 + num27 * Math.Sin(num17) + num28 - num155 * Math.Sin(num122);
					num33 = num31 + num157 * Math.Sin(num122);
					num34 = num32 - num157 * Math.Cos(num122);
					val2.DrawLine(val5, (float)num31, (float)num32, (float)num33, (float)num34);
					num33 = num31 - num166 * Math.Cos(num122);
					num34 = num32 - num166 * Math.Sin(num122);
					num136 = num33;
					num137 = num34;
					val2.DrawLine(val5, (float)num31, (float)num32, (float)num33, (float)num34);
					num31 += num157 * Math.Sin(num122);
					num32 -= num157 * Math.Cos(num122);
					num33 = num31 - num166 * Math.Cos(num122);
					num34 = num32 - num166 * Math.Sin(num122);
					num138 = num33;
					num139 = num34;
					val2.DrawLine(val5, (float)num31, (float)num32, (float)num33, (float)num34);
					val2.DrawLine(val5, (float)num136, (float)num137, (float)num138, (float)num139);
					double num167 = 1.5;
					double num168 = 0.0;
					double num169 = 0.0;
					double num170 = 0.0;
					double num171 = 0.0;
					num104 = num86 * num167;
					num105 = num87 * num167;
					num107 = num88 * num167;
					num111 = num93 * num167;
					num112 = num94 * num167;
					num113 = num95 * num167;
					num114 = num96 * num167;
					num115 = num97 * num167;
					num116 = num98 * num167;
					num117 = num99 * num167;
					num28 = (double)H * num167;
					num29 = (double)B * num167;
					num106 = num89 * num167;
					num108 = num90 * num167;
					num109 = num91 * num167;
					num110 = num92 * num167;
					num170 = num - num4;
					num171 = (double)num26 + num22 * num18 + 40.0;
					num168 = (double)(num - num4) - num114;
					num169 = num171 + num108 + num109 + num116;
					num31 = num168;
					num32 = num169;
					num33 = num31 + num114;
					num34 = num32;
					val2.DrawLine(val5, (float)num31, (float)num32, (float)num33, (float)num34);
					num31 = num168;
					num32 = num169;
					num33 = num31;
					num34 = num32 + (double)num15;
					num136 = num33;
					num137 = num34;
					val2.DrawLine(val3, (float)num31, (float)num32, (float)num33, (float)num34);
					num31 += num114;
					num33 = num31;
					num138 = num33;
					num139 = num34;
					val2.DrawLine(val3, (float)num31, (float)num32, (float)num33, (float)num34);
					num31 = num136;
					num32 = num137 - 5.0;
					num33 = num138;
					num34 = num139 - 5.0;
					DrawRows(num31, num32, num33, num34, num18, val2, val3);
					num47 = (num136 + num138) / 2.0;
					num48 = num137 + (double)num21;
					#if WINDOWS
					val9.FormatFlags = (StringFormatFlags)1;
					#endif
					val2.DrawString(num96.ToString(), val7, (Brush)(object)val8, (float)num47, (float)num48, val9);
					num31 = num168 + num114;
					num32 = num169;
					num33 = num31;
					num34 = num32 - num115;
					val2.DrawLine(val5, (float)num31, (float)num32, (float)num33, (float)num34);
					num31 = num168;
					num32 = num169;
					num33 = num31;
					num34 = num32 - num115;
					val2.DrawLine(val5, (float)num31, (float)num32, (float)num33, (float)num34);
					num33 = num31 - (double)num15;
					num34 = num32;
					val2.DrawLine(val3, (float)num31, (float)num32, (float)num33, (float)num34);
					num32 = num169 - num115;
					num33 = num31 - (double)num15;
					num34 = num32;
					val2.DrawLine(val3, (float)num31, (float)num32, (float)num33, (float)num34);
					num31 = num33 + 5.0;
					num32 = num169;
					num33 = num31;
					num34 = num32 - num115;
					DrawRows(num33, num34, num31, num32, num18, val2, val3);
					num47 = num31 - (double)num21 - 3.0;
					num48 = (num32 + num34) / 2.0;
					#if WINDOWS
					val9.FormatFlags = (StringFormatFlags)1;
					#endif
					val2.DrawString(num97.ToString(), val7, (Brush)(object)val8, (float)num47, (float)num48, val9);
					num31 = num170 - num106 - 4.0 * num117;
					num32 = num171;
					num33 = num31;
					num34 = num32 + num116;
					val2.DrawLine(val5, (float)num31, (float)num32, (float)num33, (float)num34);
					num33 = num31 - (double)num15;
					num34 = num32;
					val2.DrawLine(val3, (float)num31, (float)num32, (float)num33, (float)num34);
					num31 = num170 - num106 - 4.0 * num117;
					num32 = num171 + num116;
					num33 = num31 - (double)num15;
					num34 = num32;
					val2.DrawLine(val3, (float)num31, (float)num32, (float)num33, (float)num34);
					num31 = num33 + 5.0;
					num32 = num171;
					num33 = num31;
					num34 = num32 + num116;
					DrawRows(num31, num32, num33, num34, num18, val2, val3);
					num47 = num31 - (double)num21 - 3.0;
					num48 = (num32 + num34) / 2.0;
					#if WINDOWS
					val9.FormatFlags = (StringFormatFlags)1;
					#endif
					val2.DrawString(num98.ToString(), val7, (Brush)(object)val8, (float)num47, (float)num48, val9);
					num31 = num170 - num106 - 4.0 * num117;
					num32 = num171 + num116;
					num33 = num31 + num117;
					num34 = num32;
					val2.DrawLine(val5, (float)num31, (float)num32, (float)num33, (float)num34);
					num33 = num31;
					num34 = num32 + (double)num15;
					val2.DrawLine(val3, (float)num31, (float)num32, (float)num33, (float)num34);
					num31 = num33 + num117;
					num33 = num31;
					val2.DrawLine(val3, (float)num31, (float)num32, (float)num33, (float)num34);
					num31 = num170 - num106 - 4.0 * num117;
					num32 = num171 + num116 + (double)num15 - 5.0;
					num33 = num31 + num117;
					num34 = num32;
					DrawRows(num33, num34, num31, num32, num18, val2, val3);
					num47 = (num31 + num33) / 2.0;
					num48 = num32 + (double)num21;
					#if WINDOWS
					val9.FormatFlags = (StringFormatFlags)1;
					#endif
					val2.DrawString(num99.ToString(), val7, (Brush)(object)val8, (float)num47, (float)num48, val9);
					num31 = num170;
					num32 = num171;
					num33 = num31 - num106;
					num34 = num32;
					val2.DrawLine(val5, (float)num31, (float)num32, (float)num33, (float)num34);
					num33 = num31;
					num34 = num32 - (double)num15;
					val2.DrawLine(val3, (float)num31, (float)num32, (float)num33, (float)num34);
					num31 = num33 - num106;
					num33 = num31;
					val2.DrawLine(val3, (float)num31, (float)num32, (float)num33, (float)num34);
					num31 = num170;
					num32 = num171 - (double)num15 + 5.0;
					num33 = num31 - num106;
					num34 = num32;
					DrawRows(num33, num34, num31, num32, num18, val2, val3);
					num47 = (num31 + num33) / 2.0;
					num48 = num32 - (double)num21 - 3.0;
					#if WINDOWS
					val9.FormatFlags = (StringFormatFlags)1;
					#endif
					val2.DrawString(num89.ToString(), val7, (Brush)(object)val8, (float)num47, (float)num48, val9);
					num31 = num170;
					num32 = num171;
					num33 = num31;
					num34 = num32 + num108;
					double num147 = num33;
					double num148 = num34;
					val2.DrawLine(val5, (float)num31, (float)num32, (float)num33, (float)num34);
					num33 = num31 + (double)num15;
					num34 = num32;
					num136 = num33;
					num137 = num34;
					val2.DrawLine(val3, (float)num31, (float)num32, (float)num33, (float)num34);
					num31 = num170;
					num32 = num171 + num108;
					num33 = num31 + (double)num15;
					num34 = num32;
					val2.DrawLine(val3, (float)num31, (float)num32, (float)num33, (float)num34);
					num31 = num136 - 5.0;
					num32 = num137;
					num33 -= 5.0;
					DrawRows(num31, num32, num33, num34, num18, val2, val3);
					num47 = num31 + (double)num21;
					num48 = (num32 + num34) / 2.0;
					#if WINDOWS
					val9.FormatFlags = (StringFormatFlags)1;
					#endif
					val2.DrawString(num90.ToString(), val7, (Brush)(object)val8, (float)num47, (float)num48, val9);
					num31 = num147;
					num32 = num148;
					num33 = num31 - num109 * Math.Cos(num122);
					num34 = num32 + num109 * Math.Sin(num122);
					val2.DrawLine(val5, (float)num31, (float)num32, (float)num33, (float)num34);
					num33 = num31 - (double)num15 * Math.Sin(num122);
					num34 = num32 - (double)num15 * Math.Cos(num122);
					num136 = num33;
					num137 = num34;
					val2.DrawLine(val3, (float)num31, (float)num32, (float)num33, (float)num34);
					num31 = num147 - num109 * Math.Cos(num122);
					num32 = num148 + num109 * Math.Sin(num122);
					num33 = num31 - (double)num15 * Math.Sin(num122);
					num34 = num32 - (double)num15 * Math.Cos(num122);
					val2.DrawLine(val3, (float)num31, (float)num32, (float)num33, (float)num34);
					num31 = num136 + 5.0 * Math.Sin(num122);
					num32 = num137 + 5.0 * Math.Cos(num122);
					num33 += 5.0 * Math.Sin(num122);
					num34 += 5.0 * Math.Cos(num122);
					DrawRows(num33, num34, num31, num32, num18, val2, val3);
					num47 = (num31 + num33) / 2.0 - (double)num21;
					num48 = (num32 + num34) / 2.0 - (double)(num21 / 2);
					#if WINDOWS
					val9.FormatFlags = (StringFormatFlags)1;
					#endif
					val2.DrawString(num91.ToString(), val7, (Brush)(object)val8, (float)num47, (float)num48, val9);
					num31 = num147;
					num32 = num148;
					num33 = num31;
					num34 = num32 + num109 * Math.Sin(num122);
					val2.DrawLine(val3, (float)num31, (float)num32, (float)num33, (float)num34);
					double num172 = 3.0 * num109 * Math.Cos(num122) / 8.0;
					double num173 = 3.0 * num109 * Math.Sin(num122) / 8.0;
					num31 = num147;
					num32 = num148 + num173;
					double num39 = num31 - num172;
					double num40 = num32;
					num33 = (num31 + num39) / 2.0;
					num34 = (num32 + num40) / 2.0 + 5.0;
					val2.DrawBezier(val3, (float)num31, (float)num32, (float)num33, (float)num34, (float)num39, (float)num40, (float)num39, (float)num40);
					string text3 = Math.Round((Math.PI / 2.0 - num122) * 180.0 / Math.PI) + "°";
					val2.DrawString(text3, val7, (Brush)(object)val8, (float)(num33 + 3.0), (float)(num34 + (double)num21), val9);
					num31 = num147 - num109 * Math.Cos(num122);
					num32 = num148 + num109 * Math.Sin(num122);
					num33 = num31 - num110 * Math.Sin(num122);
					num34 = num32 - num110 * Math.Cos(num122);
					val2.DrawLine(val5, (float)num31, (float)num32, (float)num33, (float)num34);
					num33 = num31 - (double)num15 * Math.Cos(num122);
					num34 = num32 + (double)num15 * Math.Sin(num122);
					num136 = num33;
					num137 = num34;
					val2.DrawLine(val3, (float)num31, (float)num32, (float)num33, (float)num34);
					num31 = num147 - num109 * Math.Cos(num122) - num110 * Math.Sin(num122);
					num32 = num148 + num109 * Math.Sin(num122) - num110 * Math.Cos(num122);
					num33 = num31 - (double)num15 * Math.Cos(num122);
					num34 = num32 + (double)num15 * Math.Sin(num122);
					val2.DrawLine(val3, (float)num31, (float)num32, (float)num33, (float)num34);
					num31 = num136 + 5.0 * Math.Cos(num122);
					num32 = num137 - 5.0 * Math.Sin(num122);
					num33 += 5.0 * Math.Cos(num122);
					num34 -= 5.0 * Math.Sin(num122);
					DrawRows(num31, num32, num33, num34, num18, val2, val3);
					num47 = (num31 + num33) / 2.0 - (double)num21;
					num48 = (num32 + num34) / 2.0 + (double)(num21 / 2);
					#if WINDOWS
					val9.FormatFlags = (StringFormatFlags)1;
					#endif
					val2.DrawString(num92.ToString(), val7, (Brush)(object)val8, (float)num47, (float)num48, val9);
				}
				else
				{
					num31 = num3;
					num32 = (double)num6 + num27 * Math.Sin(num17) + num28;
					num33 = num31 + num118;
					num34 = num32;
					val2.DrawLine(val5, (float)num31, (float)num32, (float)num33, (float)num34);
					num31 = num33;
					num34 = num32 - num119;
					val2.DrawLine(val5, (float)num31, (float)num32, (float)num33, (float)num34);
					num31 = (double)num3 + num29;
					num32 = (double)num6 + num27 * Math.Sin(num17) + num28;
					num33 = num31 - num118;
					num34 = num32;
					val2.DrawLine(val5, (float)num31, (float)num32, (float)num33, (float)num34);
					num31 = num33;
					num34 = num32 - num119;
					val2.DrawLine(val5, (float)num31, (float)num32, (float)num33, (float)num34);
					num31 = (double)num3 + num29 / 2.0 - num120;
					num32 = (double)num6 + num27 * Math.Sin(num17) + num28;
					num33 = num31 + 2.0 * num120;
					num34 = num32;
					val2.DrawLine(val5, (float)num31, (float)num32, (float)num33, (float)num34);
					num33 = num31;
					num34 = num32 - num121;
					val2.DrawLine(val5, (float)num31, (float)num32, (float)num33, (float)num34);
					num31 += 2.0 * num120;
					num33 = num31;
					num34 = num32 - num121;
					val2.DrawLine(val5, (float)num31, (float)num32, (float)num33, (float)num34);
					double num174 = 3.0;
					double num175 = 3.0;
					num31 = (double)num3 + num29 / 2.0;
					num32 = (double)num6 + num27 * Math.Sin(num17) + num28 - num174;
					num33 = num31 + num117;
					num34 = num32;
					val2.DrawLine(val5, (float)num31, (float)num32, (float)num33, (float)num34);
					num33 = num31;
					num34 = num32 - num116;
					val2.DrawLine(val5, (float)num31, (float)num32, (float)num33, (float)num34);
					double num176 = 40.0;
					double num177 = num176 * num18;
					double num178 = 5.0;
					double num179 = num178 * num18;
					l = B / 2 - 2 * (int)num178;
					double num180 = (double)l * num18;
					num31 = (double)num3 + num179 + num175;
					num32 = (double)num6 + num27 * Math.Sin(num17) + num28 - num119 - num174;
					num33 = num31 + num180 - 2.0 * num175;
					num34 = num32;
					val2.DrawLine(val5, (float)num31, (float)num32, (float)num33, (float)num34);
					num33 = num31;
					num34 = num32 - num177;
					val2.DrawLine(val5, (float)num31, (float)num32, (float)num33, (float)num34);
					num31 += num180 - 2.0 * num175;
					num33 = num31;
					num34 = num32 - num177;
					val2.DrawLine(val5, (float)num31, (float)num32, (float)num33, (float)num34);
					num32 = num34;
					num33 = num31 - (num180 - 2.0 * num175);
					val2.DrawLine(val5, (float)num31, (float)num32, (float)num33, (float)num34);
					num31 = (double)num3 + num29 / 2.0 + num179 + num175;
					num32 = (double)num6 + num27 * Math.Sin(num17) + num28 - num119 - num174;
					num33 = num31 + num180 - 2.0 * num175;
					num34 = num32;
					val2.DrawLine(val5, (float)num31, (float)num32, (float)num33, (float)num34);
					num33 = num31;
					num34 = num32 - num177;
					val2.DrawLine(val5, (float)num31, (float)num32, (float)num33, (float)num34);
					num31 += num180 - 2.0 * num175;
					num33 = num31;
					num34 = num32 - num177;
					val2.DrawLine(val5, (float)num31, (float)num32, (float)num33, (float)num34);
					num32 = num34;
					num33 = num31 - (num180 - 2.0 * num175);
					val2.DrawLine(val5, (float)num31, (float)num32, (float)num33, (float)num34);
					double num181 = 1.5;
					double num182 = 0.0;
					double num183 = 0.0;
					double num184 = 0.0;
					double num185 = 0.0;
					num120 = num102 * num181;
					num121 = num103 * num181;
					num116 = num98 * num181;
					num117 = num99 * num181;
					num28 = (double)H * num181;
					num29 = (double)B * num181;
					num184 = num - num4;
					num185 = (double)num26 + num22 * num18 + 40.0;
					num182 = (double)(num - num4) - 2.0 * num120;
					num183 = num185 + num121;
					num31 = num182;
					num32 = num183;
					num33 = num31 + 2.0 * num120;
					num34 = num32;
					val2.DrawLine(val5, (float)num31, (float)num32, (float)num33, (float)num34);
					num31 = num182;
					num32 = num183;
					num33 = num31;
					num34 = num32 + (double)num15;
					double num136 = num33;
					double num137 = num34;
					val2.DrawLine(val3, (float)num31, (float)num32, (float)num33, (float)num34);
					num31 += 2.0 * num120;
					num33 = num31;
					double num138 = num33;
					double num139 = num34;
					val2.DrawLine(val3, (float)num31, (float)num32, (float)num33, (float)num34);
					num31 = num136;
					num32 = num137 - 5.0;
					num33 = num138;
					num34 = num139 - 5.0;
					DrawRows(num31, num32, num33, num34, num18, val2, val3);
					num47 = (num136 + num138) / 2.0;
					num48 = num137 + (double)num21;
					#if WINDOWS
					val9.FormatFlags = (StringFormatFlags)1;
					#endif
					val2.DrawString((2.0 * num102).ToString(), val7, (Brush)(object)val8, (float)num47, (float)num48, val9);
					num31 = num182 + 2.0 * num120;
					num32 = num183;
					num33 = num31;
					num34 = num32 - num121;
					val2.DrawLine(val5, (float)num31, (float)num32, (float)num33, (float)num34);
					num31 = num182;
					num32 = num183;
					num33 = num31;
					num34 = num32 - num121;
					val2.DrawLine(val5, (float)num31, (float)num32, (float)num33, (float)num34);
					num33 = num31 - (double)num15;
					num34 = num32;
					val2.DrawLine(val3, (float)num31, (float)num32, (float)num33, (float)num34);
					num32 = num183 - num121;
					num33 = num31 - (double)num15;
					num34 = num32;
					val2.DrawLine(val3, (float)num31, (float)num32, (float)num33, (float)num34);
					num31 = num33 + 5.0;
					num32 = num183;
					num33 = num31;
					num34 = num32 - num121;
					DrawRows(num33, num34, num31, num32, num18, val2, val3);
					num47 = num31 - (double)num21 - 3.0;
					num48 = (num32 + num34) / 2.0;
					#if WINDOWS
					val9.FormatFlags = (StringFormatFlags)1;
					#endif
					val2.DrawString(num103.ToString(), val7, (Brush)(object)val8, (float)num47, (float)num48, val9);
					num31 = num184 - 2.0 * num120 - 4.0 * num117;
					num32 = num185;
					num33 = num31;
					num34 = num32 + num116;
					val2.DrawLine(val5, (float)num31, (float)num32, (float)num33, (float)num34);
					num31 = num184 - 2.0 * num120 - 4.0 * num117;
					num32 = num185;
					num33 = num31;
					num34 = num32 + num116;
					val2.DrawLine(val5, (float)num31, (float)num32, (float)num33, (float)num34);
					num33 = num31 - (double)num15;
					num34 = num32;
					val2.DrawLine(val3, (float)num31, (float)num32, (float)num33, (float)num34);
					num31 = num184 - 2.0 * num120 - 4.0 * num117;
					num32 = num185 + num116;
					num33 = num31 - (double)num15;
					num34 = num32;
					val2.DrawLine(val3, (float)num31, (float)num32, (float)num33, (float)num34);
					num31 = num33 + 5.0;
					num32 = num185;
					num33 = num31;
					num34 = num32 + num116;
					DrawRows(num31, num32, num33, num34, num18, val2, val3);
					num47 = num31 - (double)num21 - 3.0;
					num48 = (num32 + num34) / 2.0;
					#if WINDOWS
					val9.FormatFlags = (StringFormatFlags)1;
					#endif
					val2.DrawString(num98.ToString(), val7, (Brush)(object)val8, (float)num47, (float)num48, val9);
					num31 = num184 - 2.0 * num120 - 4.0 * num117;
					num32 = num185 + num116;
					num33 = num31 + num117;
					num34 = num32;
					val2.DrawLine(val5, (float)num31, (float)num32, (float)num33, (float)num34);
					num33 = num31;
					num34 = num32 + (double)num15;
					val2.DrawLine(val3, (float)num31, (float)num32, (float)num33, (float)num34);
					num31 = num33 + num117;
					num33 = num31;
					val2.DrawLine(val3, (float)num31, (float)num32, (float)num33, (float)num34);
					num31 = num184 - 2.0 * num120 - 4.0 * num117;
					num32 = num185 + num116 + (double)num15 - 5.0;
					num33 = num31 + num117;
					num34 = num32;
					DrawRows(num33, num34, num31, num32, num18, val2, val3);
					num47 = (num31 + num33) / 2.0;
					num48 = num32 + (double)num21;
					#if WINDOWS
					val9.FormatFlags = (StringFormatFlags)1;
					#endif
					val2.DrawString(num99.ToString(), val7, (Brush)(object)val8, (float)num47, (float)num48, val9);
				}
			}
			if (vyhid == "з виходом")
			{
				num19 = (double)(2 * num / 3 - num8 - num4) / (double)L;
				num9 = num26 + (int)(num22 * num18) + 50;
				int num186 = 0;
				if (vyhid3 == "круглий" || vyhid3 == "прямокутний")
				{
					num9 += 50;
					num186 += 50;
				}
				else if (vyhid2 == "круглий" || vyhid2 == "прямокутний")
				{
					num9 += 25;
					num186 += 25;
				}
				num9 += num15;
				if (num19 * (double)B + (double)(3 * num15) + (double)num186 > (double)num2 / 3.0)
				{
					num19 = ((double)num2 / 3.0 - (double)(3 * num15) - (double)num186) / (double)B;
				}
				num27 = (double)L * num19;
				num29 = (double)B * num19;
				double num37 = (double)d1 * num19;
				double num49 = (double)a1 * num19;
				double num50 = (double)b1 * num19;
				double num38 = (double)p1 * num19;
				double num35 = (double)f1 * num19;
				double num36 = (double)g1 * num19;
				double num57 = (double)d2 * num19;
				double num65 = (double)a2 * num19;
				double num66 = (double)b2 * num19;
				double num58 = (double)p2 * num19;
				double num55 = (double)f2 * num19;
				double num56 = (double)g2 * num19;
				double num72 = (double)d2 * num19;
				double num80 = (double)a3 * num19;
				double num81 = (double)b3 * num19;
				double num73 = (double)p3 * num19;
				double num70 = (double)f3 * num19;
				double num71 = (double)g3 * num19;
				num31 = num8;
				num32 = num9;
				num33 = num31 + num27;
				num34 = num32;
				val2.DrawLine(val4, (float)num31, (float)num32, (float)num33, (float)num34);
				num31 = num33;
				num32 = num34;
				num33 = num31;
				num34 = num32 + num29;
				val2.DrawLine(val4, (float)num31, (float)num32, (float)num33, (float)num34);
				num31 = num8;
				num32 = num9;
				num33 = num31;
				num34 = num32 + num29;
				val2.DrawLine(val4, (float)num31, (float)num32, (float)num33, (float)num34);
				num31 = num8;
				num32 = (double)num9 + num29;
				num33 = num31 + num27;
				num34 = num32;
				val2.DrawLine(val4, (float)num31, (float)num32, (float)num33, (float)num34);
				num31 = (double)num8 + num27;
				num32 = (double)num9 + num29;
				num33 = num31 + (double)num14;
				num34 = num32;
				double num138 = num33;
				double num139 = num34;
				val2.DrawLine(val3, (float)num31, (float)num32, (float)num33, (float)num34);
				num31 = (double)num8 + num27;
				num32 = num9;
				num33 = num31 + (double)num14;
				num34 = num32;
				double num136 = num33;
				double num137 = num34;
				val2.DrawLine(val3, (float)num31, (float)num32, (float)num33, (float)num34);
				num31 = num136 - 5.0;
				num32 = num137;
				num33 = num138 - 5.0;
				num34 = num139;
				DrawRows(num31, num32, num33, num34, num19, val2, val3);
				num47 = num31 + (double)num21;
				num48 = (num137 + num139) / 2.0;
				#if WINDOWS
				val9.FormatFlags = (StringFormatFlags)2;
				#endif
				val2.DrawString(B.ToString(), val7, (Brush)(object)val8, (float)num47, (float)num48, val9);
				num31 = num8;
				num32 = (double)num9 + num29;
				num33 = num31;
				num34 = num32 + (double)num14;
				num136 = num33;
				num137 = num34;
				val2.DrawLine(val3, (float)num31, (float)num32, (float)num33, (float)num34);
				num31 = (double)num8 + num27;
				num32 = (double)num9 + num29;
				num33 = num31;
				num34 = num32 + (double)num14;
				num138 = num33;
				num139 = num34;
				val2.DrawLine(val3, (float)num31, (float)num32, (float)num33, (float)num34);
				num31 = num136;
				num32 = num137 - 5.0;
				num33 = num138;
				num34 = num139 - 5.0;
				val2.DrawLine(val3, (float)num31, (float)num32, (float)num33, (float)num34);
				num47 = (num136 + num138) / 2.0;
				num48 = (num137 + num139) / 2.0 + (double)num21;
				#if WINDOWS
				val9.FormatFlags = (StringFormatFlags)1;
				#endif
				val2.DrawString(L.ToString(), val7, (Brush)(object)val8, (float)num47, (float)num48, val9);
				if (vyhid1 == "круглий")
				{
					val2.DrawEllipse(val4, (float)((double)num8 + num35 - num37 / 2.0), (float)((double)num9 + num36 - num37 / 2.0), (float)num37, (float)num37);
					num31 = num8;
					num32 = num9;
					num33 = num31;
					num34 = num32 - (double)num15;
					num136 = num33;
					num137 = num34;
					val2.DrawLine(val3, (float)num31, (float)num32, (float)num33, (float)num34);
					num31 = (double)num8 + num35;
					num32 = (double)num9 + num36;
					num33 = num31;
					num34 = num32 - num36 - (double)num15;
					num138 = num33;
					num139 = num34;
					val2.DrawLine(val3, (float)num31, (float)num32, (float)num33, (float)num34);
					num31 = num136;
					num32 = num137 + 5.0;
					num33 = num138;
					num34 = num139 + 5.0;
					val2.DrawLine(val3, (float)num31, (float)num32, (float)num33, (float)num34);
					DrawRows(num31, num32, num33, num34, num19, val2, val3);
					num47 = (num31 + num33) / 2.0;
					num48 = num34 - (double)num21;
					#if WINDOWS
					val9.FormatFlags = (StringFormatFlags)1;
					#endif
					val2.DrawString(f1.ToString(), val7, (Brush)(object)val8, (float)num47, (float)num48, val9);
					num31 = (double)num8 + num35;
					num32 = (double)num9 + num36;
					num33 = num31 + num37 / 2.0 + (double)num15;
					num34 = num32;
					num136 = num33;
					num137 = num34;
					val2.DrawLine(val3, (float)num31, (float)num32, (float)num33, (float)num34);
					num138 = num136;
					num139 = num9;
					num31 = num136 - 5.0;
					num32 = num137;
					num33 = num138 - 5.0;
					num34 = num139;
					DrawRows(num33, num34, num31, num32, num19, val2, val3);
					num47 = num31 + (double)num21;
					num48 = ((vyhid2 == "прямокутний") ? (num34 + 15.0) : ((num32 + num34) / 2.0));
					#if WINDOWS
					val9.FormatFlags = (StringFormatFlags)2;
					#endif
					val2.DrawString(g1.ToString(), val7, (Brush)(object)val8, (float)num47, (float)num48, val9);
					num31 = (double)num8 + num35 - num37 / 2.0;
					num32 = (double)num9 + num36;
					num33 = num31;
					num34 = num32 + num37 / 2.0 + (double)num15;
					num136 = num33;
					num137 = num34;
					val2.DrawLine(val3, (float)num31, (float)num32, (float)num33, (float)num34);
					num31 = (double)num8 + num35 + num37 / 2.0;
					num32 = (double)num9 + num36;
					num33 = num31;
					num34 = num32 + num37 / 2.0 + (double)num15;
					num138 = num33;
					num139 = num34;
					val2.DrawLine(val3, (float)num31, (float)num32, (float)num33, (float)num34);
					num31 = num136;
					num32 = num137 - 5.0;
					num33 = num138;
					num34 = num139 - 5.0;
					DrawRows(num31, num32, num33, num34, num19, val2, val3);
					num47 = (num31 + num33) / 2.0;
					num48 = num34 + (double)num21;
					#if WINDOWS
					val9.FormatFlags = (StringFormatFlags)1;
					#endif
					val2.DrawString(d1.ToString(), val7, (Brush)(object)val8, (float)num47, (float)num48, val9);
				}
				else if (vyhid1 == "прямокутний")
				{
					val2.DrawRectangle(val4, (float)((double)num8 + num35 - num49 / 2.0), (float)((double)num9 + num36 - num50 / 2.0), (float)num49, (float)num50);
					num31 = num8;
					num32 = num9;
					num33 = num31;
					num34 = num32 - (double)num15;
					num136 = num33;
					num137 = num34;
					val2.DrawLine(val3, (float)num31, (float)num32, (float)num33, (float)num34);
					num31 = (double)num8 + num35;
					num32 = (double)num9 + num36;
					num33 = num31;
					num34 = num32 - num36 - (double)num15;
					num138 = num33;
					num139 = num34;
					val2.DrawLine(val3, (float)num31, (float)num32, (float)num33, (float)num34);
					num31 = num136;
					num32 = num137 + 5.0;
					num33 = num138;
					num34 = num139 + 5.0;
					val2.DrawLine(val3, (float)num31, (float)num32, (float)num33, (float)num34);
					DrawRows(num31, num32, num33, num34, num19, val2, val3);
					num47 = (num31 + num33) / 2.0;
					num48 = num34 - (double)num21;
					#if WINDOWS
					val9.FormatFlags = (StringFormatFlags)1;
					#endif
					val2.DrawString(f1.ToString(), val7, (Brush)(object)val8, (float)num47, (float)num48, val9);
					num31 = (double)num8 + num35;
					num32 = (double)num9 + num36;
					num33 = num31 + num49 / 2.0 + (double)num15;
					num34 = num32;
					num136 = num33;
					num137 = num34;
					val2.DrawLine(val3, (float)num31, (float)num32, (float)num33, (float)num34);
					num138 = num136;
					num139 = num9;
					num31 = num136 - 5.0;
					num32 = num137;
					num33 = num138 - 5.0;
					num34 = num139;
					DrawRows(num33, num34, num31, num32, num19, val2, val3);
					num47 = num31 + (double)num21;
					num48 = ((vyhid2 == "прямокутний") ? (num34 + 10.0) : ((num32 + num34) / 2.0));
					#if WINDOWS
					val9.FormatFlags = (StringFormatFlags)2;
					#endif
					val2.DrawString(g1.ToString(), val7, (Brush)(object)val8, (float)num47, (float)num48, val9);
					num31 = (double)num8 + num35 - num49 / 2.0;
					num32 = (double)num9 + num36 + num50 / 2.0;
					num33 = num31;
					num34 = num32 + (double)num15;
					num136 = num33;
					num137 = num34;
					val2.DrawLine(val3, (float)num31, (float)num32, (float)num33, (float)num34);
					num31 = (double)num8 + num35 + num49 / 2.0;
					num32 = (double)num9 + num36 + num50 / 2.0;
					num33 = num31;
					num34 = num32 + (double)num15;
					num138 = num33;
					num139 = num34;
					val2.DrawLine(val3, (float)num31, (float)num32, (float)num33, (float)num34);
					num31 = num136;
					num32 = num137 - 5.0;
					num33 = num138;
					num34 = num139 - 5.0;
					DrawRows(num31, num32, num33, num34, num19, val2, val3);
					num47 = (num31 + num33) / 2.0;
					num48 = num34 + (double)num21;
					#if WINDOWS
					val9.FormatFlags = (StringFormatFlags)1;
					#endif
					val2.DrawString(a1.ToString(), val7, (Brush)(object)val8, (float)num47, (float)num48, val9);
					num31 = (double)num8 + num35 - num49 / 2.0;
					num32 = (double)num9 + num36 - num50 / 2.0;
					num33 = num31 - (double)num15;
					num34 = num32;
					num136 = num33;
					num137 = num34;
					val2.DrawLine(val3, (float)num31, (float)num32, (float)num33, (float)num34);
					num31 = (double)num8 + num35 - num49 / 2.0;
					num32 = (double)num9 + num36 + num50 / 2.0;
					num33 = num31 - (double)num15;
					num34 = num32;
					num138 = num33;
					num139 = num34;
					val2.DrawLine(val3, (float)num31, (float)num32, (float)num33, (float)num34);
					num31 = num136 + 5.0;
					num32 = num137;
					num33 = num138 + 5.0;
					num34 = num139;
					val2.DrawLine(val3, (float)num31, (float)num32, (float)num33, (float)num34);
					DrawRows(num31, num32, num33, num34, num19, val2, val3);
					num47 = num31 - (double)num21 - 3.0;
					num48 = (num32 + num34) / 2.0;
					#if WINDOWS
					val9.FormatFlags = (StringFormatFlags)2;
					#endif
					val2.DrawString(b1.ToString(), val7, (Brush)(object)val8, (float)num47, (float)num48, val9);
				}
				if (vyhid2 == "круглий")
				{
					val2.DrawEllipse(val4, (float)((double)num8 + num55 - num57 / 2.0), (float)((double)num9 + num56 - num57 / 2.0), (float)num57, (float)num57);
					num31 = num8;
					num32 = num9;
					num33 = num31;
					num34 = num32 - (double)num15 - 25.0;
					num136 = num33;
					num137 = num34;
					val2.DrawLine(val3, (float)num31, (float)num32, (float)num33, (float)num34);
					num31 = (double)num8 + num55;
					num32 = (double)num9 + num56;
					num33 = num31;
					num34 = num32 - num56 - (double)num15 - 25.0;
					num138 = num33;
					num139 = num34;
					val2.DrawLine(val3, (float)num31, (float)num32, (float)num33, (float)num34);
					num31 = num136;
					num32 = num137 + 5.0;
					num33 = num138;
					num34 = num139 + 5.0;
					val2.DrawLine(val3, (float)num31, (float)num32, (float)num33, (float)num34);
					num47 = (num31 + num33) / 2.0;
					num48 = num34 - (double)num21;
					#if WINDOWS
					val9.FormatFlags = (StringFormatFlags)1;
					#endif
					val2.DrawString(f2.ToString(), val7, (Brush)(object)val8, (float)num47, (float)num48, val9);
					num31 = (double)num8 + num55;
					num32 = (double)num9 + num56;
					num33 = num31 + num57 / 2.0 + (double)num15;
					num34 = num32;
					num136 = num33;
					num137 = num34;
					val2.DrawLine(val3, (float)num31, (float)num32, (float)num33, (float)num34);
					num138 = num136;
					num139 = num9;
					num31 = num136 - 5.0;
					num32 = num137;
					num33 = num138 - 5.0;
					num34 = num139;
					DrawRows(num33, num34, num31, num32, num19, val2, val3);
					num47 = num31 + (double)num21;
					num48 = (num32 + num34) / 2.0;
					#if WINDOWS
					val9.FormatFlags = (StringFormatFlags)2;
					#endif
					val2.DrawString(g2.ToString(), val7, (Brush)(object)val8, (float)num47, (float)num48, val9);
					num31 = (double)num8 + num55 - num57 / 2.0;
					num32 = (double)num9 + num56;
					num33 = num31;
					num34 = num32 + num57 / 2.0 + (double)num15;
					num136 = num33;
					num137 = num34;
					val2.DrawLine(val3, (float)num31, (float)num32, (float)num33, (float)num34);
					num31 = (double)num8 + num55 + num57 / 2.0;
					num32 = (double)num9 + num56;
					num33 = num31;
					num34 = num32 + num57 / 2.0 + (double)num15;
					num138 = num33;
					num139 = num34;
					val2.DrawLine(val3, (float)num31, (float)num32, (float)num33, (float)num34);
					num31 = num136;
					num32 = num137 - 5.0;
					num33 = num138;
					num34 = num139 - 5.0;
					DrawRows(num31, num32, num33, num34, num19, val2, val3);
					num47 = (num31 + num33) / 2.0;
					num48 = num34 + (double)num21 + 3.0;
					#if WINDOWS
					val9.FormatFlags = (StringFormatFlags)1;
					#endif
					val2.DrawString(d2.ToString(), val7, (Brush)(object)val8, (float)num47, (float)num48, val9);
				}
				else if (vyhid2 == "прямокутний")
				{
					val2.DrawRectangle(val4, (float)((double)num8 + num55 - num65 / 2.0), (float)((double)num9 + num56 - num66 / 2.0), (float)num65, (float)num66);
					num31 = num8;
					num32 = num9;
					num33 = num31;
					num34 = num32 - (double)num15 - 25.0;
					num136 = num33;
					num137 = num34;
					val2.DrawLine(val3, (float)num31, (float)num32, (float)num33, (float)num34);
					num31 = (double)num8 + num55;
					num32 = (double)num9 + num56;
					num33 = num31;
					num34 = num32 - num56 - (double)num15 - 25.0;
					num138 = num33;
					num139 = num34;
					val2.DrawLine(val3, (float)num31, (float)num32, (float)num33, (float)num34);
					num31 = num136;
					num32 = num137 + 5.0;
					num33 = num138;
					num34 = num139 + 5.0;
					DrawRows(num31, num32, num33, num34, num19, val2, val3);
					num47 = (num31 + num33) / 2.0;
					num48 = num34 - (double)num21;
					#if WINDOWS
					val9.FormatFlags = (StringFormatFlags)1;
					#endif
					val2.DrawString(f2.ToString(), val7, (Brush)(object)val8, (float)num47, (float)num48, val9);
					num31 = (double)num8 + num55;
					num32 = (double)num9 + num56;
					num33 = num31 + num65 / 2.0 + (double)num15;
					num34 = num32;
					num136 = num33;
					num137 = num34;
					val2.DrawLine(val3, (float)num31, (float)num32, (float)num33, (float)num34);
					num138 = num136;
					num139 = num9;
					num31 = num136 - 5.0;
					num32 = num137;
					num33 = num138 - 5.0;
					num34 = num139;
					DrawRows(num33, num34, num31, num32, num19, val2, val3);
					num47 = num31 + (double)num21;
					num48 = ((vyhid3 == "прямокутний") ? (num34 + 15.0) : ((num32 + num34) / 2.0));
					#if WINDOWS
					val9.FormatFlags = (StringFormatFlags)2;
					#endif
					val2.DrawString(g2.ToString(), val7, (Brush)(object)val8, (float)num47, (float)num48, val9);
					num31 = (double)num8 + num55 - num65 / 2.0;
					num32 = (double)num9 + num56 + num66 / 2.0;
					num33 = num31;
					num34 = num32 + (double)num15;
					num136 = num33;
					num137 = num34;
					val2.DrawLine(val3, (float)num31, (float)num32, (float)num33, (float)num34);
					num31 = (double)num8 + num55 + num65 / 2.0;
					num32 = (double)num9 + num56 + num66 / 2.0;
					num33 = num31;
					num34 = num32 + (double)num15;
					num138 = num33;
					num139 = num34;
					val2.DrawLine(val3, (float)num31, (float)num32, (float)num33, (float)num34);
					num31 = num136;
					num32 = num137 - 5.0;
					num33 = num138;
					num34 = num139 - 5.0;
					DrawRows(num31, num32, num33, num34, num19, val2, val3);
					num47 = (num31 + num33) / 2.0;
					num48 = num34 + (double)num21;
					#if WINDOWS
					val9.FormatFlags = (StringFormatFlags)1;
					#endif
					val2.DrawString(a2.ToString(), val7, (Brush)(object)val8, (float)num47, (float)num48, val9);
					num31 = (double)num8 + num55 - num65 / 2.0;
					num32 = (double)num9 + num56 - num66 / 2.0;
					num33 = num31 - (double)num15;
					num34 = num32;
					num136 = num33;
					num137 = num34;
					val2.DrawLine(val3, (float)num31, (float)num32, (float)num33, (float)num34);
					num31 = (double)num8 + num55 - num65 / 2.0;
					num32 = (double)num9 + num56 + num66 / 2.0;
					num33 = num31 - (double)num15;
					num34 = num32;
					num138 = num33;
					num139 = num34;
					val2.DrawLine(val3, (float)num31, (float)num32, (float)num33, (float)num34);
					num31 = num136 + 5.0;
					num32 = num137;
					num33 = num138 + 5.0;
					num34 = num139;
					DrawRows(num31, num32, num33, num34, num19, val2, val3);
					num47 = num31 - (double)num21 - 3.0;
					num48 = (num32 + num34) / 2.0;
					#if WINDOWS
					val9.FormatFlags = (StringFormatFlags)2;
					#endif
					val2.DrawString(b2.ToString(), val7, (Brush)(object)val8, (float)num47, (float)num48, val9);
				}
				if (vyhid3 == "круглий")
				{
					val2.DrawEllipse(val4, (float)((double)num8 + num70 - num72 / 2.0), (float)((double)num9 + num71 - num72 / 2.0), (float)num72, (float)num72);
					num31 = num8;
					num32 = num9;
					num33 = num31;
					num34 = num32 - (double)num15 - 50.0;
					num136 = num33;
					num137 = num34;
					val2.DrawLine(val3, (float)num31, (float)num32, (float)num33, (float)num34);
					num31 = (double)num8 + num70;
					num32 = (double)num9 + num71;
					num33 = num31;
					num34 = num32 - num71 - (double)num15 - 50.0;
					num138 = num33;
					num139 = num34;
					val2.DrawLine(val3, (float)num31, (float)num32, (float)num33, (float)num34);
					num31 = num136;
					num32 = num137 + 5.0;
					num33 = num138;
					num34 = num139 + 5.0;
					DrawRows(num31, num32, num33, num34, num19, val2, val3);
					num47 = (num31 + num33) / 2.0;
					num48 = num34 - (double)num21;
					#if WINDOWS
					val9.FormatFlags = (StringFormatFlags)1;
					#endif
					val2.DrawString(f3.ToString(), val7, (Brush)(object)val8, (float)num47, (float)num48, val9);
					num31 = (double)num8 + num70;
					num32 = (double)num9 + num71;
					num33 = num31 + num72 / 2.0 + (double)num15;
					num34 = num32;
					num136 = num33;
					num137 = num34;
					val2.DrawLine(val3, (float)num31, (float)num32, (float)num33, (float)num34);
					num138 = num136;
					num139 = num9;
					num31 = num136 - 5.0;
					num32 = num137;
					num33 = num138 - 5.0;
					num34 = num139;
					DrawRows(num33, num34, num31, num32, num19, val2, val3);
					num47 = num31 + (double)num21;
					num48 = (num32 + num34) / 2.0;
					#if WINDOWS
					val9.FormatFlags = (StringFormatFlags)2;
					#endif
					val2.DrawString(g3.ToString(), val7, (Brush)(object)val8, (float)num47, (float)num48, val9);
					num31 = (double)num8 + num70 - num72 / 2.0;
					num32 = (double)num9 + num71;
					num33 = num31;
					num34 = num32 + num72 / 2.0 + (double)num15;
					num136 = num33;
					num137 = num34;
					val2.DrawLine(val3, (float)num31, (float)num32, (float)num33, (float)num34);
					num31 = (double)num8 + num70 + num72 / 2.0;
					num32 = (double)num9 + num71;
					num33 = num31;
					num34 = num32 + num72 / 2.0 + (double)num15;
					num138 = num33;
					num139 = num34;
					val2.DrawLine(val3, (float)num31, (float)num32, (float)num33, (float)num34);
					num31 = num136;
					num32 = num137 - 5.0;
					num33 = num138;
					num34 = num139 - 5.0;
					DrawRows(num31, num32, num33, num34, num19, val2, val3);
					num47 = (num31 + num33) / 2.0;
					num48 = num34 + (double)num21 + 3.0;
					#if WINDOWS
					val9.FormatFlags = (StringFormatFlags)1;
					#endif
					val2.DrawString(d3.ToString(), val7, (Brush)(object)val8, (float)num47, (float)num48, val9);
				}
				else if (vyhid3 == "прямокутний")
				{
					val2.DrawRectangle(val4, (float)((double)num8 + num70 - num80 / 2.0), (float)((double)num9 + num71 - num81 / 2.0), (float)num80, (float)num81);
					num31 = num8;
					num32 = num9;
					num33 = num31;
					num34 = num32 - (double)num15 - 50.0;
					num136 = num33;
					num137 = num34;
					val2.DrawLine(val3, (float)num31, (float)num32, (float)num33, (float)num34);
					num31 = (double)num8 + num70;
					num32 = (double)num9 + num71;
					num33 = num31;
					num34 = num32 - num71 - (double)num15 - 50.0;
					num138 = num33;
					num139 = num34;
					val2.DrawLine(val3, (float)num31, (float)num32, (float)num33, (float)num34);
					num31 = num136;
					num32 = num137 + 5.0;
					num33 = num138;
					num34 = num139 + 5.0;
					DrawRows(num31, num32, num33, num34, num19, val2, val3);
					num47 = (num31 + num33) / 2.0;
					num48 = num34 - (double)num21;
					#if WINDOWS
					val9.FormatFlags = (StringFormatFlags)1;
					#endif
					val2.DrawString(f3.ToString(), val7, (Brush)(object)val8, (float)num47, (float)num48, val9);
					num31 = (double)num8 + num70;
					num32 = (double)num9 + num71;
					num33 = num31 + num80 / 2.0 + (double)num15;
					num34 = num32;
					num136 = num33;
					num137 = num34;
					val2.DrawLine(val3, (float)num31, (float)num32, (float)num33, (float)num34);
					num138 = num136;
					num139 = num9;
					num31 = num136 - 5.0;
					num32 = num137;
					num33 = num138 - 5.0;
					num34 = num139;
					DrawRows(num33, num34, num31, num32, num19, val2, val3);
					num47 = num31 + (double)num21;
					num48 = (num32 + num34) / 2.0;
					#if WINDOWS
					val9.FormatFlags = (StringFormatFlags)2;
					#endif
					val2.DrawString(g3.ToString(), val7, (Brush)(object)val8, (float)num47, (float)num48, val9);
					num31 = (double)num8 + num70 - num80 / 2.0;
					num32 = (double)num9 + num71 + num81 / 2.0;
					num33 = num31;
					num34 = num32 + (double)num15;
					num136 = num33;
					num137 = num34;
					val2.DrawLine(val3, (float)num31, (float)num32, (float)num33, (float)num34);
					num31 = (double)num8 + num70 + num80 / 2.0;
					num32 = (double)num9 + num71 + num81 / 2.0;
					num33 = num31;
					num34 = num32 + (double)num15;
					num138 = num33;
					num139 = num34;
					val2.DrawLine(val3, (float)num31, (float)num32, (float)num33, (float)num34);
					num31 = num136;
					num32 = num137 - 5.0;
					num33 = num138;
					num34 = num139 - 5.0;
					DrawRows(num31, num32, num33, num34, num19, val2, val3);
					num47 = (num31 + num33) / 2.0;
					num48 = num34 + (double)num21 + 3.0;
					#if WINDOWS
					val9.FormatFlags = (StringFormatFlags)1;
					#endif
					val2.DrawString(a3.ToString(), val7, (Brush)(object)val8, (float)num47, (float)num48, val9);
					num31 = (double)num8 + num70 - num80 / 2.0;
					num32 = (double)num9 + num71 - num81 / 2.0;
					num33 = num31 - (double)num15;
					num34 = num32;
					num136 = num33;
					num137 = num34;
					val2.DrawLine(val3, (float)num31, (float)num32, (float)num33, (float)num34);
					num31 = (double)num8 + num70 - num80 / 2.0;
					num32 = (double)num9 + num71 + num81 / 2.0;
					num33 = num31 - (double)num15;
					num34 = num32;
					num138 = num33;
					num139 = num34;
					val2.DrawLine(val3, (float)num31, (float)num32, (float)num33, (float)num34);
					num31 = num136 + 5.0;
					num32 = num137;
					num33 = num138 + 5.0;
					num34 = num139;
					DrawRows(num31, num32, num33, num34, num19, val2, val3);
					num47 = num31 - (double)num21 - 3.0;
					num48 = (num32 + num34) / 2.0;
					#if WINDOWS
					val9.FormatFlags = (StringFormatFlags)2;
					#endif
					val2.DrawString(b3.ToString(), val7, (Brush)(object)val8, (float)num47, (float)num48, val9);
				}
			}
			num12 = num3;
			num13 = num26 + (int)(num22 * num18) + 50;
			if (vyhid == "з виходом")
			{
				num13 += num2 / 3 + 20;
			}
			int num187 = 10;
			int num188 = 0;
			Font val10 = new Font("Arial", (float)num187);
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
						if (num85 == 2)
						{
							val2.DrawString("Ширина першого жирфільтра: " + kFiltr[0] + "мм * 2шт", val10, (Brush)(object)val8, (float)num12, (float)(num13 + num188), val11);
						}
						else
						{
							val2.DrawString("Ширина першого жирфільтра: " + kFiltr[0] + "мм", val10, (Brush)(object)val8, (float)num12, (float)(num13 + num188), val11);
						}
						break;
					case 1:
						if (num85 == 2)
						{
							val2.DrawString("Ширина другого жирфільтра: " + kFiltr[1] + "мм * 2шт", val10, (Brush)(object)val8, (float)num12, (float)(num13 + num188), val11);
						}
						else
						{
							val2.DrawString("Ширина другого жирфільтра: " + kFiltr[1] + "мм", val10, (Brush)(object)val8, (float)num12, (float)(num13 + num188), val11);
						}
						break;
					case 2:
						if (num85 == 2)
						{
							val2.DrawString("Ширина третього жирфільтра: " + kFiltr[2] + "мм * 2шт", val10, (Brush)(object)val8, (float)num12, (float)(num13 + num188), val11);
						}
						else
						{
							val2.DrawString("Ширина третього жирфільтра: " + kFiltr[2] + "мм", val10, (Brush)(object)val8, (float)num12, (float)(num13 + num188), val11);
						}
						break;
					}
					num188 += num187 + 8;
					if (num13 + num188 > num2 - num7)
					{
						num12 = num3 + num / 2;
						num188 = 0;
					}
				}
				if (nFiltr == 1)
				{
					val2.DrawString("Довжина жирфільтра: " + l + "мм", val10, (Brush)(object)val8, (float)num12, (float)(num13 + num188), val11);
				}
				else
				{
					val2.DrawString("Довжина жирфільтрів: " + l + "мм", val10, (Brush)(object)val8, (float)num12, (float)(num13 + num188), val11);
				}
				num188 += num187 + 8;
				if (num13 + num188 > num2 - num7)
				{
					num12 = num3 + num / 2;
					num188 = 0;
				}
			}
			val2.DrawString("Матеріал зонта: " + zontMaterial, val10, (Brush)(object)val8, (float)num12, (float)(num13 + num188), val11);
			num188 += num187 + 8;
			if (num13 + num188 > num2 - num7)
			{
				num12 = num3 + num / 2;
				num188 = 0;
			}
			val2.DrawString("Товщина металу зонта: " + tovchynaMetaluZont + "мм", val10, (Brush)(object)val8, (float)num12, (float)(num13 + num188), val11);
			num188 += num187 + 8;
			if (num13 + num188 > num2 - num7)
			{
				num12 = num3 + num / 2;
				num188 = 0;
			}
			val2.DrawString("З'єднання: " + connection, val10, (Brush)(object)val8, (float)num12, (float)(num13 + num188), val11);
			num188 += num187 + 8;
			if (num13 + num188 > num2 - num7)
			{
				num12 = num3 + num / 2;
				num188 = 0;
			}
			val2.DrawString("Трубка зливу 1/2': " + zlyv, val10, (Brush)(object)val8, (float)num12, (float)(num13 + num188), val11);
			num188 += num187 + 8;
			if (num13 + num188 > num2 - num7)
			{
				num12 = num3 + num / 2;
				num188 = 0;
			}
			val2.DrawString("Кріплення: " + fastening, val10, (Brush)(object)val8, (float)num12, (float)(num13 + num188), val11);
			if (fastening == "так")
			{
				num188 += num187 + 8;
				if (num13 + num188 > num2 - num7)
				{
					num12 = num3 + num / 2;
					num188 = 0;
				}
				val2.DrawString("Тип кріплення: " + typeFastening, val10, (Brush)(object)val8, (float)num12, (float)(num13 + num188), val11);
			}
			if (vyhid == "з виходом")
			{
				if (vyhid1 == "круглий" || vyhid1 == "прямокутний")
				{
					num188 += num187 + 8;
					if (num13 + num188 > num2 - num7)
					{
						num12 = num3 + num / 2;
						num188 = 0;
					}
					val2.DrawString("Тип виходу 1: " + typVyhid1, val10, (Brush)(object)val8, (float)num12, (float)(num13 + num188), val11);
					if (typVyhid1 == "фланець")
					{
						num188 += num187 + 8;
						if (num13 + num188 > num2 - num7)
						{
							num12 = num3 + num / 2;
							num188 = 0;
						}
						val2.DrawString("Тип профілю для виходу 1: " + profilType1, val10, (Brush)(object)val8, (float)num12, (float)(num13 + num188), val11);
					}
				}
				if (vyhid2 == "круглий" || vyhid2 == "прямокутний")
				{
					num188 += num187 + 8;
					if (num13 + num188 > num2 - num7)
					{
						num12 = num3 + num / 2;
						num188 = 0;
					}
					val2.DrawString("Тип виходу 2: " + typVyhid2, val10, (Brush)(object)val8, (float)num12, (float)(num13 + num188), val11);
					if (typVyhid2 == "фланець")
					{
						num188 += num187 + 8;
						if (num13 + num188 > num2 - num7)
						{
							num12 = num3 + num / 2;
							num188 = 0;
						}
						val2.DrawString("Тип профілю для виходу 2: " + profilType2, val10, (Brush)(object)val8, (float)num12, (float)(num13 + num188), val11);
					}
				}
				if (vyhid3 == "круглий" || vyhid3 == "прямокутний")
				{
					num188 += num187 + 8;
					if (num13 + num188 > num2 - num7)
					{
						num12 = num3 + num / 2;
						num188 = 0;
					}
					val2.DrawString("Тип виходу 3: " + typVyhid3, val10, (Brush)(object)val8, (float)num12, (float)(num13 + num188), val11);
					if (typVyhid3 == "фланець")
					{
						num188 += num187 + 8;
						if (num13 + num188 > num2 - num7)
						{
							num12 = num3 + num / 2;
							num188 = 0;
						}
						val2.DrawString("Тип профілю для виходу 3: " + profilType3, val10, (Brush)(object)val8, (float)num12, (float)(num13 + num188), val11);
					}
				}
			}
			if (zhyrFiltr == "так")
			{
				num188 += num187 + 8;
				if (num13 + num188 > num2 - num7)
				{
					num12 = num3 + num / 2;
					num188 = 0;
				}
				val2.DrawString("Матеріал жирфільтра: " + zhyrFiltrMaterial, val10, (Brush)(object)val8, (float)num12, (float)(num13 + num188), val11);
				num188 += num187 + 8;
				if (num13 + num188 > num2 - num7)
				{
					num12 = num3 + num / 2;
					num188 = 0;
				}
				val2.DrawString("Товщина металу жирфільтра: " + tovchynaMetaluFiltr + "мм", val10, (Brush)(object)val8, (float)num12, (float)(num13 + num188), val11);
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

	public static double VolumeZontOstrivnyyTyp1(int L, int B, int H, int p1, int p2, int p3)
	{
		int num = ((p1 > p2) ? p1 : p2);
		if (p3 > num)
		{
			num = p3;
		}
		return Math.Round((double)L * (double)B * (double)(H + num) / 1000000.0) / 1000.0;
	}
}
