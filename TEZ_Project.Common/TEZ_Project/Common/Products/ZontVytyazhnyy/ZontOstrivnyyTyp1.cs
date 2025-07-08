using System;
using System.Drawing;
using System.Globalization;
using System.IO;
using TEZ_Project.Common.Helpers;

namespace TEZ_Project.Common.Products.ZontVytyazhnyy;

public class ZontOstrivnyyTyp1
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

	public static double[,] MaterialZontOstrivnyyTyp1(int L, int B, int H, int h, int b, int number, string markaStaliZont, string tovchynaMetaluZont, string connection, string zlyv, string fastening, string typeFastening, string vyhid, string vyhid1, int d1, int a1, int b1, int p1, int f1, int g1, string typVyhid1, string profilType1, string vyhid2, int d2, int a2, int b2, int p2, int f2, int g2, string typVyhid2, string profilType2, string vyhid3, int d3, int a3, int b3, int p3, int f3, int g3, string typVyhid3, string profilType3, string zhyrFiltr, int G, string markaStaliFiltr, string tovchynaMetaluFiltr)
	{
		double[,] array = new double[32, 6];
		int num = -1;
		double num2 = 0.0;
		double num3 = 0.0;
		double num4 = 0.0;
		double num5 = 0.0;
		double num6 = 0.0;
		int num7 = 750;
		materialName = new string[32]
		{
			"", "", "", "", "", "", "", "", "", "",
			"", "", "", "", "", "", "", "", "", "",
			"", "", "", "", "", "", "", "", "", "",
			"", ""
		};
		materialCost = 0.0;
		materialSpendingCommercialOffer = 0.0;
		materialSpendingCommercialOffer1 = 0.0;
		priceProduct = 0.0;
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
		double num8 = ((connection == "зварка") ? 12 : 15);
		double num9 = num8 + (double)H + 20.0 + 10.0;
		double num10 = (2.0 * num8 + (double)B) * num9 - 0.5 * (double)(B - b) * (double)(H - h);
		if (B > 2500)
		{
			num10 += 40.0 * num9;
		}
		else if (B > 1250)
		{
			num10 += 20.0 * num9;
		}
		double num11 = Math.Sqrt(0.25 * (double)(B - b) * (double)(B - b) + (double)((H - h) * (H - h)));
		double num12 = 2.0 * ((double)(30 + h) + num11) + (double)b;
		num12 = ((B < 600 || B > 790) ? (num12 + 60.0) : (num12 + 170.0));
		if (num12 > 2460.0)
		{
			num12 += 40.0;
		}
		else if (num12 > 1230.0)
		{
			num12 += 20.0;
		}
		double num13 = ((L > 1230) ? 20 : 0);
		num13 += (double)((connection == "зварка") ? (L - 5) : L);
		double num14 = num12 * num13;
		double num15 = 0.0;
		if (vyhid == "з виходом")
		{
			num8 = 60.0;
			if (vyhid1 == "круглий")
			{
				double num16 = ((d1 < 560) ? 0.036 : ((d1 < 710) ? 0.043 : ((d1 >= 900) ? ((d1 < 1400) ? 0.086 : 0.11599999999999999) : 0.073)));
				num15 += (Math.PI * (double)d1 + num16) * ((double)p1 + num8);
			}
			if (vyhid2 == "круглий")
			{
				double num16 = ((d2 < 560) ? 0.036 : ((d2 < 710) ? 0.043 : ((d2 >= 900) ? ((d2 < 1400) ? 0.086 : 0.11599999999999999) : 0.073)));
				num15 += (Math.PI * (double)d2 + num16) * ((double)p2 + num8);
			}
			if (vyhid3 == "круглий")
			{
				double num16 = ((d3 < 560) ? 0.036 : ((d3 < 710) ? 0.043 : ((d3 >= 900) ? ((d3 < 1400) ? 0.086 : 0.11599999999999999) : 0.073)));
				num15 += (Math.PI * (double)d3 + num16) * ((double)p3 + num8);
			}
			if (vyhid1 == "прямокутний")
			{
				double num17 = 2.0 * (double)(a1 + 10 + b1 + 50);
				num8 = ((num17 <= 500.0) ? 60 : 30);
				num15 += (num17 + num8) * ((double)p1 + num8);
			}
			if (vyhid2 == "прямокутний")
			{
				double num17 = 2.0 * (double)(a2 + 10 + b2 + 50);
				num8 = ((num17 <= 500.0) ? 60 : 30);
				num15 += (num17 + num8) * ((double)p2 + num8);
			}
			if (vyhid3 == "прямокутний")
			{
				double num17 = 2.0 * (double)(a3 + 10 + b3 + 50);
				num8 = ((num17 <= 500.0) ? 60 : 30);
				num15 += (num17 + num8) * ((double)p3 + num8);
			}
		}
		if (zhyrFiltr == "так")
		{
			double num18 = 20.0;
			double num19 = 60.0;
			double num20 = 70.0;
			double num21 = 10.0;
			double num22 = 20.0;
			double num23 = 40.0;
			double num24 = 60.0;
			double num25 = 70.0;
			double num26 = 10.0;
			double num27 = 95.0;
			double num28 = 110.0;
			double num29 = 25.0;
			double num30 = 55.0;
			double num31 = 15.0;
			if (G == b)
			{
				typeUpperStrip = 1;
			}
			else if (b - G >= 50)
			{
				typeUpperStrip = 2;
			}
			num8 = ((L > 1230) ? 20 : 0);
			num12 = ((B >= 600 && B <= 790) ? num27 : (num28 + 2.0 * num29 + num30 + num31));
			if (G == b)
			{
				typeUpperStrip = 1;
				num12 += num22 + num23 + num24 + num25 + num26;
				if (B > 790)
				{
					num12 += num22 + num23 + num24 + num25 + num26;
				}
			}
			else if (b - G >= 50)
			{
				typeUpperStrip = 2;
				num12 += num18 + num19 + num20 + num21;
				if (B > 790)
				{
					num12 += num18 + num19 + num20 + num21;
				}
			}
			num5 = num12 * (double)(L - 5);
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
			num12 = ((ZontOstrivnyyTyp1.l > 1230) ? 20 : 0);
			num12 += (double)(ZontOstrivnyyTyp1.l + 30);
			num6 = (kk + 42.5) * num12 + 1700.0;
		}
		array[num, 0] = 2.0 * num10 + num14 + num15 + num5 + 2.0 * num6;
		if (B > 790)
		{
			array[num, 0] += 2.0 * num6;
		}
		array[num, 0] *= 1.0500000000000001E-06;
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
		for (int j = 0; j < 5; j++)
		{
			if (array[num, j] < 0.005)
			{
				array[num, j] = Math.Round(1000.0 * array[num, j]) / 1000.0;
			}
			else
			{
				array[num, j] = Math.Round(100.0 * array[num, j]) / 100.0;
			}
		}
		materialCost = array[num, 0] * num4;
		if (connection == "заклепка")
		{
			int num32 = 7;
			int num33 = 50;
			num11 = Math.Sqrt(0.25 * (double)(B - b) * (double)(B - b) + (double)((H - h) * (H - h)));
			int num34 = 2 * ((int)Math.Round(((double)h - 2.0 * (double)num32) / (double)num33, MidpointRounding.AwayFromZero) + (int)Math.Round((num11 - 2.0 * (double)num32) / (double)num33, MidpointRounding.AwayFromZero)) + (int)Math.Round(((double)b - 2.0 * (double)num32) / (double)num33, MidpointRounding.AwayFromZero);
			num34 *= 2;
			if (zhyrFiltr == "так")
			{
				num34 += 4;
				num34 += ((B > 790) ? (2 * (int)Math.Round(((double)L - 100.0) / 200.0, MidpointRounding.AwayFromZero)) : ((int)Math.Round(((double)L - 100.0) / 200.0, MidpointRounding.AwayFromZero)));
			}
			num++;
			materialName[num] = Consts2.zaklepkaKombinov48x6.MaterialName;
			array[num, 0] = num34;
			array[num, 4] = array[num, 0] * (double)number;
			materialCost += array[num, 0] * Consts2.zaklepkaKombinov48x6.Price;
		}
		if (zhyrFiltr == "так")
		{
			double[] array2 = new double[6];
			for (int k = 0; k < nFiltr; k++)
			{
				array2 = FiltrZh.MaterialFiltrZh(kFiltr[k], ZontOstrivnyyTyp1.l, markaStaliFiltr, tovchynaMetaluFiltr, 2 * number);
				materialCost += FiltrZh.materialCost;
				num++;
				materialName[num] = FiltrZh.materialName[0];
				for (int l = 0; l < 6; l++)
				{
					array[num, l] = array2[l];
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
					int num35 = 0;
					for (int m = 0; m < 5 && FlanetsKruglyj.materialName1[m] != ""; m++)
					{
						num35++;
					}
					for (int n = 0; n < num35; n++)
					{
						materialName[n + num] = FlanetsKruglyj.materialName1[n];
						for (int num36 = 0; num36 < 6; num36++)
						{
							array[n + num, num36] = array3[n, num36];
						}
					}
					num += num35 - 1;
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
					int num37 = 0;
					for (int num38 = 0; num38 < 5 && FlanetsKruglyj.materialName1[num38] != ""; num38++)
					{
						num37++;
					}
					for (int num39 = 0; num39 < num37; num39++)
					{
						materialName[num39 + num] = FlanetsKruglyj.materialName1[num39];
						for (int num40 = 0; num40 < 6; num40++)
						{
							array[num39 + num, num40] = array3[num39, num40];
						}
					}
					num += num37 - 1;
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
					int num41 = 0;
					for (int num42 = 0; num42 < 5 && FlanetsKruglyj.materialName1[num42] != ""; num42++)
					{
						num41++;
					}
					for (int num43 = 0; num43 < num41; num43++)
					{
						materialName[num43 + num] = FlanetsKruglyj.materialName1[num43];
						for (int num44 = 0; num44 < 6; num44++)
						{
							array[num43 + num, num44] = array3[num43, num44];
						}
					}
					num += num41 - 1;
				}
			}
			if ((vyhid1 == "прямокутний" && typVyhid1 == "фланець") || (vyhid2 == "прямокутний" && typVyhid2 == "фланець") || (vyhid3 == "прямокутний" && typVyhid3 == "фланець"))
			{
				double[,] array4 = new double[2, 6];
				if (vyhid1 == "прямокутний" && typVyhid1 == "фланець")
				{
					array4 = MaterialFlanetsPrjamokutnyj(a1, b1, profilType1, number);
					materialCost += materialCost1;
					for (int num45 = 0; num45 < 2; num45++)
					{
						if (materialName1[num45] != "")
						{
							num++;
							materialName[num] = materialName1[num45];
							for (int num46 = 0; num46 < 6; num46++)
							{
								array[num, num46] = array4[num45, num46];
							}
						}
					}
				}
				if (vyhid2 == "прямокутний" && typVyhid2 == "фланець")
				{
					array4 = MaterialFlanetsPrjamokutnyj(a2, b2, profilType2, number);
					materialCost += materialCost1;
					for (int num47 = 0; num47 < 2; num47++)
					{
						if (materialName1[num47] != "")
						{
							num++;
							materialName[num] = materialName1[num47];
							for (int num48 = 0; num48 < 6; num48++)
							{
								array[num, num48] = array4[num47, num48];
							}
						}
					}
				}
				if (vyhid3 == "прямокутний" && typVyhid3 == "фланець")
				{
					array4 = MaterialFlanetsPrjamokutnyj(a3, b3, profilType3, number);
					materialCost += materialCost1;
					for (int num49 = 0; num49 < 2; num49++)
					{
						if (materialName1[num49] != "")
						{
							num++;
							materialName[num] = materialName1[num49];
							for (int num50 = 0; num50 < 6; num50++)
							{
								array[num, num50] = array4[num49, num50];
							}
						}
					}
				}
				num++;
			}
		}
		if (num > 0)
		{
			for (int num51 = 0; num51 < num; num51++)
			{
				for (int num52 = num51 + 1; num52 <= num; num52++)
				{
					if (!(materialName[num51] == materialName[num52]))
					{
						continue;
					}
					for (int num53 = 0; num53 < 6; num53++)
					{
						if (num53 == 1)
						{
							if (materialName[num51] == Consts2.lystStalnyj30.MaterialName)
							{
								array[num51, num53] = Math.Round((array[num51, num53] + array[num52, num53]) / 2.0);
							}
						}
						else
						{
							array[num51, num53] += array[num52, num53];
						}
						array[num52, num53] = 0.0;
					}
					materialName[num52] = "";
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

	public static void ZontOstrivnyyTyp1DrawDxf(int L, int B, int H, int h, int b, string connection, string zlyv, string vyhid, string vyhid1, int d1, int a1, int b1, int f1, int g1, string typVyhid1, string vyhid2, int d2, int a2, int b2, int f2, int g2, string typVyhid2, string vyhid3, int d3, int a3, int b3, int f3, int g3, string typVyhid3, string zhyrFiltr, int G, string filePath)
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
			int num6 = ((B <= 790 && !(zhyrFiltr == "ні")) ? 1 : 2);
			double num7 = 1.0;
			double num8 = 10.0;
			double num9 = 20.0;
			double num10 = 112.0;
			double num11 = 100.0;
			double num12 = 19.5;
			double num13;
			double num14;
			double num15;
			double num16;
			if (connection == "зварка")
			{
				num13 = 12.0;
				num14 = 12.0;
				num15 = 12.0;
				num16 = 12.0;
			}
			else
			{
				num13 = 15.0;
				num14 = 15.0;
				num15 = 15.0;
				num16 = 15.0;
			}
			double num17 = Math.Atan((double)(H - h) / (double)((B - b) / 2));
			double num18 = 0.0;
			double num19 = 0.0;
			num2 = num14 + num9;
			num3 = 0.0;
			num4 = num2;
			num5 = num3 + num8;
			ushort num20 = (ushort)(num + 1);
			num = num20;
			DrawLine(streamWriter, num20, text, num18 + num2, num19 + num3, num18 + num4, num19 + num5);
			num2 = num4;
			num3 = num5;
			num4 = num2 - (num9 + num14);
			num5 = num3 + num9 + num14;
			num20 = (ushort)(num + 1);
			num = num20;
			DrawLine(streamWriter, num20, text, num18 + num2, num19 + num3, num18 + num4, num19 + num5);
			num2 = num4;
			num3 = num5;
			num4 = num2;
			num5 = num3 + (double)h - 2.0 * num14;
			num20 = (ushort)(num + 1);
			num = num20;
			DrawLine(streamWriter, num20, text, num18 + num2, num19 + num3, num18 + num4, num19 + num5);
			num = DrawZaklepka(streamWriter, num, text, connection, num2 + num18, num3 + num19, num4 + num18, num5 + num19, 1);
			num2 = num4;
			num3 = num5;
			num4 = num2 + num14;
			num5 = num3 + num14;
			num20 = (ushort)(num + 1);
			num = num20;
			DrawLine(streamWriter, num20, text, num18 + num2, num19 + num3, num18 + num4, num19 + num5);
			num2 = num4;
			num3 = num5;
			num4 = num2;
			num5 = num3 + num16 / Math.Cos(num17);
			num20 = (ushort)(num + 1);
			num = num20;
			DrawLine(streamWriter, num20, text, num18 + num2, num19 + num3, num18 + num4, num19 + num5);
			double num21 = Math.Sqrt(Math.Pow((B - b) / 2, 2.0) + Math.Pow(H - h, 2.0));
			num2 = num4;
			num3 = num5;
			num4 = num2 + num21 * Math.Cos(num17) - num16 / Math.Sin(num17);
			num5 = num3 + num21 * Math.Sin(num17) - num16 / Math.Cos(num17);
			num20 = (ushort)(num + 1);
			num = num20;
			DrawLine(streamWriter, num20, text, num18 + num2, num19 + num3, num18 + num4, num19 + num5);
			num = DrawZaklepka_3(streamWriter, num, text, connection, num2 - num16 * Math.Sin(num17) + num18, num3 - num16 * Math.Tan(num17) * Math.Sin(num17) + num19, num4 + num16 * Math.Cos(num17) * Math.Cos(num17) / Math.Sin(num17) + num18, num5 + num16 * Math.Cos(num17) + num19, 1);
			num2 = num4;
			num3 = num5;
			num4 = num2 + num16 / Math.Sin(num17);
			num5 = num3;
			num20 = (ushort)(num + 1);
			num = num20;
			DrawLine(streamWriter, num20, text, num18 + num2, num19 + num3, num18 + num4, num19 + num5);
			num2 = num4;
			num3 = num5;
			num4 = num2 + num13;
			num5 = num3 + num13;
			num20 = (ushort)(num + 1);
			num = num20;
			DrawLine(streamWriter, num20, text, num18 + num2, num19 + num3, num18 + num4, num19 + num5);
			num2 = num4;
			num3 = num5;
			num4 = num2 + (double)b - 2.0 * num13;
			num5 = num3;
			num20 = (ushort)(num + 1);
			num = num20;
			DrawLine(streamWriter, num20, text, num18 + num2, num19 + num3, num18 + num4, num19 + num5);
			num = DrawZaklepka(streamWriter, num, text, connection, num2 + num18, num3 + num19, num4 + num18, num5 + num19, 1);
			num2 = num4;
			num3 = num5;
			num4 = num2 + num13;
			num5 = num3 - num13;
			num20 = (ushort)(num + 1);
			num = num20;
			DrawLine(streamWriter, num20, text, num18 + num2, num19 + num3, num18 + num4, num19 + num5);
			num2 = num4;
			num3 = num5;
			num4 = num2 + num16 / Math.Sin(num17);
			num5 = num3;
			num20 = (ushort)(num + 1);
			num = num20;
			DrawLine(streamWriter, num20, text, num18 + num2, num19 + num3, num18 + num4, num19 + num5);
			num2 = num4;
			num3 = num5;
			num4 = num2 + num21 * Math.Cos(num17) - num16 / Math.Sin(num17);
			num5 = num3 - num21 * Math.Sin(num17) + num16 / Math.Cos(num17);
			num20 = (ushort)(num + 1);
			num = num20;
			DrawLine(streamWriter, num20, text, num18 + num2, num19 + num3, num18 + num4, num19 + num5);
			num = DrawZaklepka_3(streamWriter, num, text, connection, num2 - num16 * Math.Cos(num17) * Math.Cos(num17) / Math.Sin(num17) + num18, num3 + num16 * Math.Cos(num17) + num19, num4 + num16 * Math.Sin(num17) + num18, num5 - num16 * Math.Tan(num17) * Math.Sin(num17) + num19, 1);
			num2 = num4;
			num3 = num5;
			num4 = num2;
			num5 = num3 - num16 / Math.Cos(num17);
			num20 = (ushort)(num + 1);
			num = num20;
			DrawLine(streamWriter, num20, text, num18 + num2, num19 + num3, num18 + num4, num19 + num5);
			num2 = num4;
			num3 = num5;
			num4 = num2 + num14;
			num5 = num3 - num14;
			num20 = (ushort)(num + 1);
			num = num20;
			DrawLine(streamWriter, num20, text, num18 + num2, num19 + num3, num18 + num4, num19 + num5);
			num2 = num4;
			num3 = num5;
			num4 = num2;
			num5 = num3 - ((double)h - 2.0 * num14);
			num20 = (ushort)(num + 1);
			num = num20;
			DrawLine(streamWriter, num20, text, num18 + num2, num19 + num3, num18 + num4, num19 + num5);
			num = DrawZaklepka(streamWriter, num, text, connection, num2 + num18, num3 + num19, num4 + num18, num5 + num19, 1);
			num2 = num4;
			num3 = num5;
			num4 = num2 - num14;
			num5 = num3 - num14;
			num20 = (ushort)(num + 1);
			num = num20;
			DrawLine(streamWriter, num20, text, num18 + num2, num19 + num3, num18 + num4, num19 + num5);
			if (num6 == 1 && connection == "зварка")
			{
				num2 = num4;
				num3 = num5;
				num4 = num2 - num11;
				num5 = num3;
				num20 = (ushort)(num + 1);
				num = num20;
				DrawLine(streamWriter, num20, text, num18 + num2, num19 + num3, num18 + num4, num19 + num5);
				num2 = num4;
				num3 = num5;
				num4 = num2;
				num5 = num3 - (num9 + num8);
				num20 = (ushort)(num + 1);
				num = num20;
				DrawLine(streamWriter, num20, text, num18 + num2, num19 + num3, num18 + num4, num19 + num5);
				num2 = num4;
				num3 = num5;
				num4 = num2 - ((double)B - num9 - num11);
				num5 = num3;
				num20 = (ushort)(num + 1);
				num = num20;
				DrawLine(streamWriter, num20, text, num18 + num2, num19 + num3, num18 + num4, num19 + num5);
			}
			else if (num6 == 1 && connection == "заклепка")
			{
				num2 = num4;
				num3 = num5;
				num4 = num2 - num15;
				num5 = num3 - num15;
				num20 = (ushort)(num + 1);
				num = num20;
				DrawLine(streamWriter, num20, text, num18 + num2, num19 + num3, num18 + num4, num19 + num5);
				num2 = num4;
				num3 = num5;
				num4 = num2 - (num11 - 2.0 * num15);
				num5 = num3;
				num20 = (ushort)(num + 1);
				num = num20;
				DrawLine(streamWriter, num20, text, num18 + num2, num19 + num3, num18 + num4, num19 + num5);
				num = DrawZaklepka(streamWriter, num, text, connection, num4 + num18, num5 + num19, num2 + num18, num3 + num19, 0);
				num2 = num4;
				num3 = num5;
				num4 = num2 - num15;
				num5 = num3 + num15;
				num20 = (ushort)(num + 1);
				num = num20;
				DrawLine(streamWriter, num20, text, num18 + num2, num19 + num3, num18 + num4, num19 + num5);
				num2 = num4;
				num3 = num5;
				num4 = num2;
				num5 = num3 - num12;
				num20 = (ushort)(num + 1);
				num = num20;
				DrawLine(streamWriter, num20, text, num18 + num2, num19 + num3, num18 + num4, num19 + num5);
				num2 = num4;
				num3 = num5;
				num4 = num2 - num7;
				num5 = num3;
				num20 = (ushort)(num + 1);
				num = num20;
				DrawLine(streamWriter, num20, text, num18 + num2, num19 + num3, num18 + num4, num19 + num5);
				num2 = num4;
				num3 = num5;
				num4 = num2;
				num5 = num3 - num7;
				num20 = (ushort)(num + 1);
				num = num20;
				DrawLine(streamWriter, num20, text, num18 + num2, num19 + num3, num18 + num4, num19 + num5);
				num2 = num4;
				num3 = num5;
				num4 = num2 + num7;
				num5 = num3;
				num20 = (ushort)(num + 1);
				num = num20;
				DrawLine(streamWriter, num20, text, num18 + num2, num19 + num3, num18 + num4, num19 + num5);
				num2 = num4;
				num3 = num5;
				num4 = num2;
				num5 = num3 - (num8 + num9) + (num12 + num7);
				num20 = (ushort)(num + 1);
				num = num20;
				DrawLine(streamWriter, num20, text, num18 + num2, num19 + num3, num18 + num4, num19 + num5);
				num2 = num4;
				num3 = num5;
				num4 = num2 - ((double)B - num9 - num11);
				num5 = num3;
				num20 = (ushort)(num + 1);
				num = num20;
				DrawLine(streamWriter, num20, text, num18 + num2, num19 + num3, num18 + num4, num19 + num5);
			}
			else
			{
				num2 = num4;
				num3 = num5;
				num4 = num2 - num9;
				num5 = num3 - num9;
				num20 = (ushort)(num + 1);
				num = num20;
				DrawLine(streamWriter, num20, text, num18 + num2, num19 + num3, num18 + num4, num19 + num5);
				num2 = num4;
				num3 = num5;
				num4 = num2;
				num5 = num3 - num8;
				num20 = (ushort)(num + 1);
				num = num20;
				DrawLine(streamWriter, num20, text, num18 + num2, num19 + num3, num18 + num4, num19 + num5);
				if (zhyrFiltr == "так")
				{
					num2 = num4;
					num3 = num5;
					num4 = num2 - ((double)B - 2.0 * num9 - num10) / 2.0;
					num5 = num3;
					num20 = (ushort)(num + 1);
					num = num20;
					DrawLine(streamWriter, num20, text, num18 + num2, num19 + num3, num18 + num4, num19 + num5);
					num2 = num4;
					num3 = num5;
					num5 = num3 + num8;
					num20 = (ushort)(num + 1);
					num = num20;
					DrawLine(streamWriter, num20, text, num18 + num2, num19 + num3, num18 + num4, num19 + num5);
					num2 = num4;
					num3 = num5;
					num4 = num2 - num10;
					num5 = num3;
					num20 = (ushort)(num + 1);
					num = num20;
					DrawLine(streamWriter, num20, text, num18 + num2, num19 + num3, num18 + num4, num19 + num5);
					num2 = num4;
					num3 = num5;
					num5 = num3 - num8;
					num20 = (ushort)(num + 1);
					num = num20;
					DrawLine(streamWriter, num20, text, num18 + num2, num19 + num3, num18 + num4, num19 + num5);
					num2 = num4;
					num3 = num5;
					num4 = num2 - ((double)B - 2.0 * num9 - num10) / 2.0;
					num5 = num3;
					num20 = (ushort)(num + 1);
					num = num20;
					DrawLine(streamWriter, num20, text, num18 + num2, num19 + num3, num18 + num4, num19 + num5);
				}
				else
				{
					num2 = num4;
					num3 = num5;
					num4 = num2 - ((double)B - 2.0 * num9);
					num5 = num3;
					num20 = (ushort)(num + 1);
					num = num20;
					DrawLine(streamWriter, num20, text, num18 + num2, num19 + num3, num18 + num4, num19 + num5);
				}
			}
			double num22 = 10.5;
			double num23 = 21.0;
			double num24 = 21.0;
			double num25 = 20.5;
			double num26 = ((connection == "зварка") ? (L - 5) : L);
			num18 = 0.0;
			num19 = -200.0 - num26;
			if (num6 == 1)
			{
				num2 = num25 + num24 + num11 + num7 / 2.0;
				num3 = 0.0;
				num4 = num2;
				num5 = num3 + num7;
				num20 = (ushort)(num + 1);
				num = num20;
				DrawLine(streamWriter, num20, text, num18 + num2, num19 + num3, num18 + num4, num19 + num5);
				num2 = num4;
				num3 = num5;
				num4 = num2 - num7;
				num5 = num3;
				num20 = (ushort)(num + 1);
				num = num20;
				DrawLine(streamWriter, num20, text, num18 + num2, num19 + num3, num18 + num4, num19 + num5);
				num2 = num4;
				num3 = num5;
				num4 = num2;
				num5 = num3 - num7;
				num20 = (ushort)(num + 1);
				num = num20;
				DrawLine(streamWriter, num20, text, num18 + num2, num19 + num3, num18 + num4, num19 + num5);
				num2 = num4;
				num3 = num5;
				num4 = num2 - num11;
				num5 = num3;
				num20 = (ushort)(num + 1);
				num = num20;
				DrawLine(streamWriter, num20, text, num18 + num2, num19 + num3, num18 + num4, num19 + num5);
				num = DrawZaklepka_Top(streamWriter, num, text, connection, num4 + num18, num5 + num19, num2 + num18, num3 + num19, 0);
				num2 = num4;
				num3 = num5;
				num4 = num2;
				num5 = num3 + num7;
				num20 = (ushort)(num + 1);
				num = num20;
				DrawLine(streamWriter, num20, text, num18 + num2, num19 + num3, num18 + num4, num19 + num5);
				num2 = num4;
				num3 = num5;
				num4 = num2 - num7;
				num5 = num3;
				num20 = (ushort)(num + 1);
				num = num20;
				DrawLine(streamWriter, num20, text, num18 + num2, num19 + num3, num18 + num4, num19 + num5);
				num2 = num4;
				num3 = num5;
				num4 = num2;
				num5 = num3 - num7;
				num20 = (ushort)(num + 1);
				num = num20;
				DrawLine(streamWriter, num20, text, num18 + num2, num19 + num3, num18 + num4, num19 + num5);
				if (zlyv != "ні" && num6 == 1)
				{
					double num27 = 100.0;
					double num28 = 50.0;
					double num29 = 16.0;
					num2 = num4 + num28 + num7;
					num3 = ((zlyv == "так, трубка справа") ? (num5 + num26 - num27) : (num5 + num27));
					num20 = (ushort)(num + 1);
					num = num20;
					DrawCircle(streamWriter, num20, text, num18 + num2, num19 + num3, num29 / 2.0);
				}
				num2 = num4;
				num3 = num5;
				num4 = num2 - (num24 - num7);
				num5 = num3;
				num20 = (ushort)(num + 1);
				num = num20;
				DrawLine(streamWriter, num20, text, num18 + num2, num19 + num3, num18 + num4, num19 + num5);
				num2 = num4;
				num3 = num5;
				num4 = num2;
				num5 = num3 + num7;
				num20 = (ushort)(num + 1);
				num = num20;
				DrawLine(streamWriter, num20, text, num18 + num2, num19 + num3, num18 + num4, num19 + num5);
				num2 = num4;
				num3 = num5;
				num4 = num2 - num7;
				num5 = num3;
				num20 = (ushort)(num + 1);
				num = num20;
				DrawLine(streamWriter, num20, text, num18 + num2, num19 + num3, num18 + num4, num19 + num5);
				num2 = num4;
				num3 = num5;
				num4 = num2;
				num5 = num3 - num7;
				num20 = (ushort)(num + 1);
				num = num20;
				DrawLine(streamWriter, num20, text, num18 + num2, num19 + num3, num18 + num4, num19 + num5);
				num2 = num4;
				num3 = num5;
				num4 = num2 - (num25 - num7 / 2.0);
				num5 = num3;
				num20 = (ushort)(num + 1);
				num = num20;
				DrawLine(streamWriter, num20, text, num18 + num2, num19 + num3, num18 + num4, num19 + num5);
				num2 = num4;
				num3 = num5;
				num4 = num2;
				num5 = num3 + num26;
				num20 = (ushort)(num + 1);
				num = num20;
				DrawLine(streamWriter, num20, text, num18 + num2, num19 + num3, num18 + num4, num19 + num5);
				num2 = num4;
				num3 = num5;
				num4 = num2 + num25 - num7 / 2.0;
				num5 = num3;
				num20 = (ushort)(num + 1);
				num = num20;
				DrawLine(streamWriter, num20, text, num18 + num2, num19 + num3, num18 + num4, num19 + num5);
				num2 = num4;
				num3 = num5;
				num4 = num2;
				num5 = num3 - num7;
				num20 = (ushort)(num + 1);
				num = num20;
				DrawLine(streamWriter, num20, text, num18 + num2, num19 + num3, num18 + num4, num19 + num5);
				num2 = num4;
				num3 = num5;
				num4 = num2 + num7;
				num5 = num3;
				num20 = (ushort)(num + 1);
				num = num20;
				DrawLine(streamWriter, num20, text, num18 + num2, num19 + num3, num18 + num4, num19 + num5);
				num2 = num4;
				num3 = num5;
				num4 = num2;
				num5 = num3 + num7;
				num20 = (ushort)(num + 1);
				num = num20;
				DrawLine(streamWriter, num20, text, num18 + num2, num19 + num3, num18 + num4, num19 + num5);
				num2 = num4;
				num3 = num5;
				num4 = num2 + num24 - num7;
				num5 = num3;
				num20 = (ushort)(num + 1);
				num = num20;
				DrawLine(streamWriter, num20, text, num18 + num2, num19 + num3, num18 + num4, num19 + num5);
				num2 = num4;
				num3 = num5;
				num4 = num2;
				num5 = num3 - num7;
				num20 = (ushort)(num + 1);
				num = num20;
				DrawLine(streamWriter, num20, text, num18 + num2, num19 + num3, num18 + num4, num19 + num5);
				num2 = num4;
				num3 = num5;
				num4 = num2 + num7;
				num5 = num3;
				num20 = (ushort)(num + 1);
				num = num20;
				DrawLine(streamWriter, num20, text, num18 + num2, num19 + num3, num18 + num4, num19 + num5);
				num2 = num4;
				num3 = num5;
				num4 = num2;
				num5 = num3 + num7;
				num20 = (ushort)(num + 1);
				num = num20;
				DrawLine(streamWriter, num20, text, num18 + num2, num19 + num3, num18 + num4, num19 + num5);
				num2 = num4;
				num3 = num5;
				num4 = num2 + num11;
				num5 = num3;
				num20 = (ushort)(num + 1);
				num = num20;
				DrawLine(streamWriter, num20, text, num18 + num2, num19 + num3, num18 + num4, num19 + num5);
				num = DrawZaklepka_Top(streamWriter, num, text, connection, num2 + num18, num3 + num19, num4 + num18, num5 + num19, 1);
				num2 = num4;
				num3 = num5;
				num4 = num2;
				num5 = num3 - num7;
				num20 = (ushort)(num + 1);
				num = num20;
				DrawLine(streamWriter, num20, text, num18 + num2, num19 + num3, num18 + num4, num19 + num5);
				num2 = num4;
				num3 = num5;
				num4 = num2 + num7;
				num5 = num3;
				num20 = (ushort)(num + 1);
				num = num20;
				DrawLine(streamWriter, num20, text, num18 + num2, num19 + num3, num18 + num4, num19 + num5);
				num2 = num4;
				num3 = num5;
				num4 = num2;
				num5 = num3 + num7;
				num20 = (ushort)(num + 1);
				num = num20;
				DrawLine(streamWriter, num20, text, num18 + num2, num19 + num3, num18 + num4, num19 + num5);
			}
			else if (connection == "заклепка")
			{
				num2 = num22 + num23 + num7 / 2.0;
				num3 = 0.0;
				num4 = num2;
				num5 = num3 + num7;
				num20 = (ushort)(num + 1);
				num = num20;
				DrawLine(streamWriter, num20, text, num18 + num2, num19 + num3, num18 + num4, num19 + num5);
				num2 = num4;
				num3 = num5;
				num4 = num2 - num7;
				num5 = num3;
				num20 = (ushort)(num + 1);
				num = num20;
				DrawLine(streamWriter, num20, text, num18 + num2, num19 + num3, num18 + num4, num19 + num5);
				num2 = num4;
				num3 = num5;
				num4 = num2;
				num5 = num3 - num7;
				num20 = (ushort)(num + 1);
				num = num20;
				DrawLine(streamWriter, num20, text, num18 + num2, num19 + num3, num18 + num4, num19 + num5);
				num2 = num4;
				num3 = num5;
				num4 = num2 - (num23 - num7);
				num5 = num3;
				num20 = (ushort)(num + 1);
				num = num20;
				DrawLine(streamWriter, num20, text, num18 + num2, num19 + num3, num18 + num4, num19 + num5);
				num2 = num4;
				num3 = num5;
				num4 = num2;
				num5 = num3 + num7;
				num20 = (ushort)(num + 1);
				num = num20;
				DrawLine(streamWriter, num20, text, num18 + num2, num19 + num3, num18 + num4, num19 + num5);
				num2 = num4;
				num3 = num5;
				num4 = num2 - num7;
				num5 = num3;
				num20 = (ushort)(num + 1);
				num = num20;
				DrawLine(streamWriter, num20, text, num18 + num2, num19 + num3, num18 + num4, num19 + num5);
				num2 = num4;
				num3 = num5;
				num4 = num2;
				num5 = num3 - num7;
				num20 = (ushort)(num + 1);
				num = num20;
				DrawLine(streamWriter, num20, text, num18 + num2, num19 + num3, num18 + num4, num19 + num5);
				num2 = num4;
				num3 = num5;
				num4 = num2 - (num22 - num7 / 2.0);
				num5 = num3;
				num20 = (ushort)(num + 1);
				num = num20;
				DrawLine(streamWriter, num20, text, num18 + num2, num19 + num3, num18 + num4, num19 + num5);
				num2 = num4;
				num3 = num5;
				num4 = num2;
				num5 = num3 + num26;
				num20 = (ushort)(num + 1);
				num = num20;
				DrawLine(streamWriter, num20, text, num18 + num2, num19 + num3, num18 + num4, num19 + num5);
				num2 = num4;
				num3 = num5;
				num4 = num2 + num22 - num7 / 2.0;
				num5 = num3;
				num20 = (ushort)(num + 1);
				num = num20;
				DrawLine(streamWriter, num20, text, num18 + num2, num19 + num3, num18 + num4, num19 + num5);
				num2 = num4;
				num3 = num5;
				num4 = num2;
				num5 = num3 - num7;
				num20 = (ushort)(num + 1);
				num = num20;
				DrawLine(streamWriter, num20, text, num18 + num2, num19 + num3, num18 + num4, num19 + num5);
				num2 = num4;
				num3 = num5;
				num4 = num2 + num7;
				num5 = num3;
				num20 = (ushort)(num + 1);
				num = num20;
				DrawLine(streamWriter, num20, text, num18 + num2, num19 + num3, num18 + num4, num19 + num5);
				num2 = num4;
				num3 = num5;
				num4 = num2;
				num5 = num3 + num7;
				num20 = (ushort)(num + 1);
				num = num20;
				DrawLine(streamWriter, num20, text, num18 + num2, num19 + num3, num18 + num4, num19 + num5);
				num2 = num4;
				num3 = num5;
				num4 = num2 + num23 - num7;
				num5 = num3;
				num20 = (ushort)(num + 1);
				num = num20;
				DrawLine(streamWriter, num20, text, num18 + num2, num19 + num3, num18 + num4, num19 + num5);
				num2 = num4;
				num3 = num5;
				num4 = num2;
				num5 = num3 - num7;
				num20 = (ushort)(num + 1);
				num = num20;
				DrawLine(streamWriter, num20, text, num18 + num2, num19 + num3, num18 + num4, num19 + num5);
				num2 = num4;
				num3 = num5;
				num4 = num2 + num7;
				num5 = num3;
				num20 = (ushort)(num + 1);
				num = num20;
				DrawLine(streamWriter, num20, text, num18 + num2, num19 + num3, num18 + num4, num19 + num5);
				num2 = num4;
				num3 = num5;
				num4 = num2;
				num5 = num3 + num7;
				num20 = (ushort)(num + 1);
				num = num20;
				DrawLine(streamWriter, num20, text, num18 + num2, num19 + num3, num18 + num4, num19 + num5);
			}
			else
			{
				num2 = num22 + num23;
				num3 = 0.0;
				num4 = num2 - num23;
				num5 = num3 + num23;
				num20 = (ushort)(num + 1);
				num = num20;
				DrawLine(streamWriter, num20, text, num18 + num2, num19 + num3, num18 + num4, num19 + num5);
				num2 = num4;
				num3 = num5;
				num4 = num2 - num22;
				num5 = num3;
				num20 = (ushort)(num + 1);
				num = num20;
				DrawLine(streamWriter, num20, text, num18 + num2, num19 + num3, num18 + num4, num19 + num5);
				num2 = num4;
				num3 = num5;
				num4 = num2;
				num5 = num3 + num26 - 2.0 * num23;
				num20 = (ushort)(num + 1);
				num = num20;
				DrawLine(streamWriter, num20, text, num18 + num2, num19 + num3, num18 + num4, num19 + num5);
				num2 = num4;
				num3 = num5;
				num4 = num2 + num22;
				num5 = num3;
				num20 = (ushort)(num + 1);
				num = num20;
				DrawLine(streamWriter, num20, text, num18 + num2, num19 + num3, num18 + num4, num19 + num5);
				num2 = num4;
				num3 = num5;
				num4 = num2 + num23;
				num5 = num3 + num23;
				num20 = (ushort)(num + 1);
				num = num20;
				DrawLine(streamWriter, num20, text, num18 + num2, num19 + num3, num18 + num4, num19 + num5);
			}
			num2 = num4;
			num3 = num5;
			num4 = num2 + (double)h;
			num5 = num3;
			num20 = (ushort)(num + 1);
			num = num20;
			DrawLine(streamWriter, num20, text, num18 + num2, num19 + num3, num18 + num4, num19 + num5);
			num20 = (ushort)(num + 1);
			num = num20;
			DrawLine(streamWriter, num20, text, num18 + num2, num19 + num3 - num26, num18 + num4, num19 + num5 - num26);
			num = DrawZaklepka_Top(streamWriter, num, text, connection, num2 + num18, num3 + num19, num4 + num18, num5 + num19, 1);
			num = DrawZaklepka_Top(streamWriter, num, text, connection, num2 + num18, num3 + num19 - num26, num4 + num18, num5 + num19 - num26, 0);
			double num30 = num4;
			double num31 = num5;
			num2 = num4;
			num3 = num5;
			num4 = num2;
			num5 = num3 - num7;
			num20 = (ushort)(num + 1);
			num = num20;
			DrawLine(streamWriter, num20, text, num18 + num2, num19 + num3, num18 + num4, num19 + num5);
			num20 = (ushort)(num + 1);
			num = num20;
			DrawLine(streamWriter, num20, text, num18 + num2, num19 + num3 - num26, num18 + num4, num19 + num5 - num26 + 2.0 * num7);
			num2 = num4;
			num3 = num5;
			num4 = num2 + num7;
			num5 = num3;
			num20 = (ushort)(num + 1);
			num = num20;
			DrawLine(streamWriter, num20, text, num18 + num2, num19 + num3, num18 + num4, num19 + num5);
			num20 = (ushort)(num + 1);
			num = num20;
			DrawLine(streamWriter, num20, text, num18 + num2, num19 + num3 - num26 + 2.0 * num7, num18 + num4, num19 + num5 - num26 + 2.0 * num7);
			num2 = num4;
			num3 = num5;
			num4 = num2;
			num5 = num3 + num7;
			num20 = (ushort)(num + 1);
			num = num20;
			DrawLine(streamWriter, num20, text, num18 + num2, num19 + num3, num18 + num4, num19 + num5);
			num20 = (ushort)(num + 1);
			num = num20;
			DrawLine(streamWriter, num20, text, num18 + num2, num19 + num3 - num26 + num7, num18 + num4, num19 + num5 - num26 + num7);
			num2 = num4;
			num3 = num5;
			num4 = num2 + num21;
			num5 = num3;
			num20 = (ushort)(num + 1);
			num = num20;
			DrawLine(streamWriter, num20, text, num18 + num2, num19 + num3, num18 + num4, num19 + num5);
			num20 = (ushort)(num + 1);
			num = num20;
			DrawLine(streamWriter, num20, text, num18 + num2, num19 + num3 - num26, num18 + num4, num19 + num5 - num26);
			num = DrawZaklepka_Top(streamWriter, num, text, connection, num2 + num18, num3 + num19, num4 + num18, num5 + num19, 1);
			num = DrawZaklepka_Top(streamWriter, num, text, connection, num2 + num18, num3 + num19 - num26, num4 + num18, num5 + num19 - num26, 0);
			double num32 = num4 + num7;
			double num33 = num5;
			num2 = num4;
			num3 = num5;
			num4 = num2;
			num5 = num3 - num7;
			num20 = (ushort)(num + 1);
			num = num20;
			DrawLine(streamWriter, num20, text, num18 + num2, num19 + num3, num18 + num4, num19 + num5);
			num20 = (ushort)(num + 1);
			num = num20;
			DrawLine(streamWriter, num20, text, num18 + num2, num19 + num3 - num26, num18 + num4, num19 + num5 - num26 + 2.0 * num7);
			num2 = num4;
			num3 = num5;
			num4 = num2 + num7;
			num5 = num3;
			num20 = (ushort)(num + 1);
			num = num20;
			DrawLine(streamWriter, num20, text, num18 + num2, num19 + num3, num18 + num4, num19 + num5);
			num20 = (ushort)(num + 1);
			num = num20;
			DrawLine(streamWriter, num20, text, num18 + num2, num19 + num3 - num26 + 2.0 * num7, num18 + num4, num19 + num5 - num26 + 2.0 * num7);
			num2 = num4;
			num3 = num5;
			num4 = num2;
			num5 = num3 + num7;
			num20 = (ushort)(num + 1);
			num = num20;
			DrawLine(streamWriter, num20, text, num18 + num2, num19 + num3, num18 + num4, num19 + num5);
			num20 = (ushort)(num + 1);
			num = num20;
			DrawLine(streamWriter, num20, text, num18 + num2, num19 + num3 - num26 + num7, num18 + num4, num19 + num5 - num26 + num7);
			if (zhyrFiltr == "так")
			{
				if (num6 == 2)
				{
					num = DrawZaklepka_Top_1(streamWriter, num, text, connection, num4 + num18, num5 + num19, num4 + num18, num5 - num26 + num19, 0, (b - G) / 2 + 10);
					num = DrawZaklepka_Top_1(streamWriter, num, text, connection, num4 + (double)b + num18, num5 + num19, num4 + (double)b + num18, num5 - num26 + num19, 0, -((b - G) / 2 + 10));
				}
				else
				{
					num = DrawZaklepka_Top_1(streamWriter, num, text, connection, num4 + (double)b + num18, num5 + num19, num4 + (double)b + num18, num5 - num26 + num19, 0, -(b - G + 10));
				}
			}
			double num34 = num4;
			double num35 = num5 - num26;
			num2 = num4;
			num3 = num5;
			num4 = num2 + (double)b;
			num5 = num3;
			num20 = (ushort)(num + 1);
			num = num20;
			DrawLine(streamWriter, num20, text, num18 + num2, num19 + num3, num18 + num4, num19 + num5);
			num20 = (ushort)(num + 1);
			num = num20;
			DrawLine(streamWriter, num20, text, num18 + num2, num19 + num3 - num26, num18 + num4, num19 + num5 - num26);
			num = DrawZaklepka_Top(streamWriter, num, text, connection, num2 + num18, num3 + num19, num4 + num18, num5 + num19, 1);
			num = DrawZaklepka_Top(streamWriter, num, text, connection, num2 + num18, num3 + num19 - num26, num4 + num18, num5 + num19 - num26, 0);
			double num36 = num4;
			double num37 = num5;
			num2 = num4;
			num3 = num5;
			num4 = num2;
			num5 = num3 - num7;
			num20 = (ushort)(num + 1);
			num = num20;
			DrawLine(streamWriter, num20, text, num18 + num2, num19 + num3, num18 + num4, num19 + num5);
			num20 = (ushort)(num + 1);
			num = num20;
			DrawLine(streamWriter, num20, text, num18 + num2, num19 + num3 - num26, num18 + num4, num19 + num5 - num26 + 2.0 * num7);
			num2 = num4;
			num3 = num5;
			num4 = num2 + num7;
			num5 = num3;
			num20 = (ushort)(num + 1);
			num = num20;
			DrawLine(streamWriter, num20, text, num18 + num2, num19 + num3, num18 + num4, num19 + num5);
			num20 = (ushort)(num + 1);
			num = num20;
			DrawLine(streamWriter, num20, text, num18 + num2, num19 + num3 - num26 + 2.0 * num7, num18 + num4, num19 + num5 - num26 + 2.0 * num7);
			num2 = num4;
			num3 = num5;
			num4 = num2;
			num5 = num3 + num7;
			num20 = (ushort)(num + 1);
			num = num20;
			DrawLine(streamWriter, num20, text, num18 + num2, num19 + num3, num18 + num4, num19 + num5);
			num20 = (ushort)(num + 1);
			num = num20;
			DrawLine(streamWriter, num20, text, num18 + num2, num19 + num3 - num26 + num7, num18 + num4, num19 + num5 - num26 + num7);
			num2 = num4;
			num3 = num5;
			num4 = num2 + num21;
			num5 = num3;
			num20 = (ushort)(num + 1);
			num = num20;
			DrawLine(streamWriter, num20, text, num18 + num2, num19 + num3, num18 + num4, num19 + num5);
			num20 = (ushort)(num + 1);
			num = num20;
			DrawLine(streamWriter, num20, text, num18 + num2, num19 + num3 - num26, num18 + num4, num19 + num5 - num26);
			num = DrawZaklepka_Top(streamWriter, num, text, connection, num2 + num18, num3 + num19, num4 + num18, num5 + num19, 1);
			num = DrawZaklepka_Top(streamWriter, num, text, connection, num2 + num18, num3 + num19 - num26, num4 + num18, num5 + num19 - num26, 0);
			num2 = num4;
			num3 = num5;
			num4 = num2;
			num5 = num3 - num7;
			num20 = (ushort)(num + 1);
			num = num20;
			DrawLine(streamWriter, num20, text, num18 + num2, num19 + num3, num18 + num4, num19 + num5);
			num20 = (ushort)(num + 1);
			num = num20;
			DrawLine(streamWriter, num20, text, num18 + num2, num19 + num3 - num26, num18 + num4, num19 + num5 - num26 + 2.0 * num7);
			num2 = num4;
			num3 = num5;
			num4 = num2 + num7;
			num5 = num3;
			num20 = (ushort)(num + 1);
			num = num20;
			DrawLine(streamWriter, num20, text, num18 + num2, num19 + num3, num18 + num4, num19 + num5);
			num20 = (ushort)(num + 1);
			num = num20;
			DrawLine(streamWriter, num20, text, num18 + num2, num19 + num3 - num26 + 2.0 * num7, num18 + num4, num19 + num5 - num26 + 2.0 * num7);
			num2 = num4;
			num3 = num5;
			num4 = num2;
			num5 = num3 + num7;
			num20 = (ushort)(num + 1);
			num = num20;
			DrawLine(streamWriter, num20, text, num18 + num2, num19 + num3, num18 + num4, num19 + num5);
			num20 = (ushort)(num + 1);
			num = num20;
			DrawLine(streamWriter, num20, text, num18 + num2, num19 + num3 - num26 + num7, num18 + num4, num19 + num5 - num26 + num7);
			num2 = num4;
			num3 = num5;
			num4 = num2 + (double)h;
			num5 = num3;
			num20 = (ushort)(num + 1);
			num = num20;
			DrawLine(streamWriter, num20, text, num18 + num2, num19 + num3, num18 + num4, num19 + num5);
			num20 = (ushort)(num + 1);
			num = num20;
			DrawLine(streamWriter, num20, text, num18 + num2, num19 + num3 - num26, num18 + num4, num19 + num5 - num26);
			num = DrawZaklepka_Top(streamWriter, num, text, connection, num2 + num18, num3 + num19, num4 + num18, num5 + num19, 1);
			num = DrawZaklepka_Top(streamWriter, num, text, connection, num2 + num18, num3 + num19 - num26, num4 + num18, num5 + num19 - num26, 0);
			if (connection == "зварка")
			{
				num2 = num4;
				num3 = num5;
				num4 = num2 + (num23 - num7);
				num5 = num3 - (num23 - num7);
				num20 = (ushort)(num + 1);
				num = num20;
				DrawLine(streamWriter, num20, text, num18 + num2, num19 + num3, num18 + num4, num19 + num5);
				num2 = num4;
				num3 = num5;
				num4 = num2 + num22 - num7 / 2.0;
				num5 = num3;
				num20 = (ushort)(num + 1);
				num = num20;
				DrawLine(streamWriter, num20, text, num18 + num2, num19 + num3, num18 + num4, num19 + num5);
				num2 = num4;
				num3 = num5;
				num4 = num2;
				num5 = num3 - (num26 - 2.0 * (num23 - num7));
				num20 = (ushort)(num + 1);
				num = num20;
				DrawLine(streamWriter, num20, text, num18 + num2, num19 + num3, num18 + num4, num19 + num5);
				num2 = num4;
				num3 = num5;
				num4 = num2 - (num22 - num7 / 2.0);
				num5 = num3;
				num20 = (ushort)(num + 1);
				num = num20;
				DrawLine(streamWriter, num20, text, num18 + num2, num19 + num3, num18 + num4, num19 + num5);
				num2 = num4;
				num3 = num5;
				num4 = num2 - (num23 - num7);
				num5 = num3 - (num23 - num7);
				num20 = (ushort)(num + 1);
				num = num20;
				DrawLine(streamWriter, num20, text, num18 + num2, num19 + num3, num18 + num4, num19 + num5);
			}
			else
			{
				num2 = num4;
				num3 = num5;
				num4 = num2;
				num5 = num3 - num7;
				num20 = (ushort)(num + 1);
				num = num20;
				DrawLine(streamWriter, num20, text, num18 + num2, num19 + num3, num18 + num4, num19 + num5);
				num2 = num4;
				num3 = num5;
				num4 = num2 + num7;
				num5 = num3;
				num20 = (ushort)(num + 1);
				num = num20;
				DrawLine(streamWriter, num20, text, num18 + num2, num19 + num3, num18 + num4, num19 + num5);
				num2 = num4;
				num3 = num5;
				num4 = num2;
				num5 = num3 + num7;
				num20 = (ushort)(num + 1);
				num = num20;
				DrawLine(streamWriter, num20, text, num18 + num2, num19 + num3, num18 + num4, num19 + num5);
				num2 = num4;
				num3 = num5;
				num4 = num2 + num23 - num7;
				num5 = num3;
				num20 = (ushort)(num + 1);
				num = num20;
				DrawLine(streamWriter, num20, text, num18 + num2, num19 + num3, num18 + num4, num19 + num5);
				num2 = num4;
				num3 = num5;
				num4 = num2;
				num5 = num3 - num7;
				num20 = (ushort)(num + 1);
				num = num20;
				DrawLine(streamWriter, num20, text, num18 + num2, num19 + num3, num18 + num4, num19 + num5);
				num2 = num4;
				num3 = num5;
				num4 = num2 + num7;
				num5 = num3;
				num20 = (ushort)(num + 1);
				num = num20;
				DrawLine(streamWriter, num20, text, num18 + num2, num19 + num3, num18 + num4, num19 + num5);
				num2 = num4;
				num3 = num5;
				num4 = num2;
				num5 = num3 + num7;
				num20 = (ushort)(num + 1);
				num = num20;
				DrawLine(streamWriter, num20, text, num18 + num2, num19 + num3, num18 + num4, num19 + num5);
				num2 = num4;
				num3 = num5;
				num4 = num2 + num22 - num7 / 2.0;
				num5 = num3;
				num20 = (ushort)(num + 1);
				num = num20;
				DrawLine(streamWriter, num20, text, num18 + num2, num19 + num3, num18 + num4, num19 + num5);
				num2 = num4;
				num3 = num5;
				num4 = num2;
				num5 = num3 - num26;
				num20 = (ushort)(num + 1);
				num = num20;
				DrawLine(streamWriter, num20, text, num18 + num2, num19 + num3, num18 + num4, num19 + num5);
				num2 = num4;
				num3 = num5;
				num4 = num2 - num22 + num7 / 2.0;
				num5 = num3;
				num20 = (ushort)(num + 1);
				num = num20;
				DrawLine(streamWriter, num20, text, num18 + num2, num19 + num3, num18 + num4, num19 + num5);
				num2 = num4;
				num3 = num5;
				num4 = num2;
				num5 = num3 + num7;
				num20 = (ushort)(num + 1);
				num = num20;
				DrawLine(streamWriter, num20, text, num18 + num2, num19 + num3, num18 + num4, num19 + num5);
				num2 = num4;
				num3 = num5;
				num4 = num2 - num7;
				num5 = num3;
				num20 = (ushort)(num + 1);
				num = num20;
				DrawLine(streamWriter, num20, text, num18 + num2, num19 + num3, num18 + num4, num19 + num5);
				num2 = num4;
				num3 = num5;
				num4 = num2;
				num5 = num3 - num7;
				num20 = (ushort)(num + 1);
				num = num20;
				DrawLine(streamWriter, num20, text, num18 + num2, num19 + num3, num18 + num4, num19 + num5);
				num2 = num4;
				num3 = num5;
				num4 = num2 - num23 + num7;
				num5 = num3;
				num20 = (ushort)(num + 1);
				num = num20;
				DrawLine(streamWriter, num20, text, num18 + num2, num19 + num3, num18 + num4, num19 + num5);
				num2 = num4;
				num3 = num5;
				num4 = num2;
				num5 = num3 + num7;
				num20 = (ushort)(num + 1);
				num = num20;
				DrawLine(streamWriter, num20, text, num18 + num2, num19 + num3, num18 + num4, num19 + num5);
				num2 = num4;
				num3 = num5;
				num4 = num2 - num7;
				num5 = num3;
				num20 = (ushort)(num + 1);
				num = num20;
				DrawLine(streamWriter, num20, text, num18 + num2, num19 + num3, num18 + num4, num19 + num5);
				num2 = num4;
				num3 = num5;
				num4 = num2;
				num5 = num3 - num7;
				num20 = (ushort)(num + 1);
				num = num20;
				DrawLine(streamWriter, num20, text, num18 + num2, num19 + num3, num18 + num4, num19 + num5);
			}
			if (vyhid == "з виходом")
			{
				int num38 = d1;
				int num39 = a1;
				int num40 = b1;
				int num41 = d2;
				int num42 = a2;
				int num43 = b2;
				int num44 = d3;
				int num45 = a3;
				int num46 = b3;
				int num47 = 3;
				int num48 = 2;
				int num49 = 3;
				int num50 = 5;
				if (connection == "зварка")
				{
					if (typVyhid1 == "мінус")
					{
						d1 -= num47;
						a1 -= num47;
						b1 -= num47;
					}
					if (typVyhid2 == "мінус")
					{
						d2 -= num47;
						a2 -= num47;
						b2 -= num47;
					}
					if (typVyhid3 == "мінус")
					{
						d3 -= num47;
						a3 -= num47;
						b3 -= num47;
					}
				}
				if (connection == "заклепка")
				{
					if (typVyhid1 == "чисто" || typVyhid1 == "фланець")
					{
						d1 -= num48;
						a1 += num49;
						b1 += num49;
					}
					if (typVyhid1 == "мінус")
					{
						d1 -= num50;
					}
					if (typVyhid2 == "чисто" || typVyhid2 == "фланець")
					{
						d2 -= num48;
						a2 += num49;
						b2 += num49;
					}
					if (typVyhid2 == "мінус")
					{
						d2 -= num50;
					}
					if (typVyhid3 == "чисто" || typVyhid3 == "фланець")
					{
						d3 -= num48;
						a3 += num49;
						b3 += num49;
					}
					if (typVyhid3 == "мінус")
					{
						d3 -= num50;
					}
				}
				num18 += num34;
				num19 += num35 - 0.5 * ((double)L - num26);
				if (vyhid1 == "круглий")
				{
					num2 = g1;
					num3 = f1;
					num20 = (ushort)(num + 1);
					num = num20;
					DrawCircle(streamWriter, num20, text, num18 + num2, num19 + num3, (double)d1 / 2.0);
				}
				else if (vyhid1 == "прямокутний")
				{
					num2 = (double)g1 + (double)b1 / 2.0;
					num3 = (double)f1 + (double)a1 / 2.0;
					num4 = num2;
					num5 = num3 - (double)a1;
					num20 = (ushort)(num + 1);
					num = num20;
					DrawLine(streamWriter, num20, text, num18 + num2, num19 + num3, num18 + num4, num19 + num5);
					num2 = num4;
					num3 = num5;
					num4 = num2 - (double)b1;
					num5 = num3;
					num20 = (ushort)(num + 1);
					num = num20;
					DrawLine(streamWriter, num20, text, num18 + num2, num19 + num3, num18 + num4, num19 + num5);
					num2 = num4;
					num3 = num5;
					num4 = num2;
					num5 = num3 + (double)a1;
					num20 = (ushort)(num + 1);
					num = num20;
					DrawLine(streamWriter, num20, text, num18 + num2, num19 + num3, num18 + num4, num19 + num5);
					num2 = num4;
					num3 = num5;
					num4 = num2 + (double)b1;
					num5 = num3;
					num20 = (ushort)(num + 1);
					num = num20;
					DrawLine(streamWriter, num20, text, num18 + num2, num19 + num3, num18 + num4, num19 + num5);
				}
				if (vyhid2 == "круглий")
				{
					num2 = g2;
					num3 = f2;
					num20 = (ushort)(num + 1);
					num = num20;
					DrawCircle(streamWriter, num20, text, num18 + num2, num19 + num3, (double)d2 / 2.0);
				}
				else if (vyhid2 == "прямокутний")
				{
					num2 = (double)g2 + (double)b2 / 2.0;
					num3 = (double)f2 + (double)a2 / 2.0;
					num4 = num2;
					num5 = num3 - (double)a2;
					num20 = (ushort)(num + 1);
					num = num20;
					DrawLine(streamWriter, num20, text, num18 + num2, num19 + num3, num18 + num4, num19 + num5);
					num2 = num4;
					num3 = num5;
					num4 = num2 - (double)b2;
					num5 = num3;
					num20 = (ushort)(num + 1);
					num = num20;
					DrawLine(streamWriter, num20, text, num18 + num2, num19 + num3, num18 + num4, num19 + num5);
					num2 = num4;
					num3 = num5;
					num4 = num2;
					num5 = num3 + (double)a2;
					num20 = (ushort)(num + 1);
					num = num20;
					DrawLine(streamWriter, num20, text, num18 + num2, num19 + num3, num18 + num4, num19 + num5);
					num2 = num4;
					num3 = num5;
					num4 = num2 + (double)b2;
					num5 = num3;
					num20 = (ushort)(num + 1);
					num = num20;
					DrawLine(streamWriter, num20, text, num18 + num2, num19 + num3, num18 + num4, num19 + num5);
				}
				if (vyhid3 == "круглий")
				{
					num2 = g3;
					num3 = f3;
					num20 = (ushort)(num + 1);
					num = num20;
					DrawCircle(streamWriter, num20, text, num18 + num2, num19 + num3, (double)d3 / 2.0);
				}
				else if (vyhid3 == "прямокутний")
				{
					num2 = (double)g3 + (double)b3 / 2.0;
					num3 = (double)f3 + (double)a3 / 2.0;
					num4 = num2;
					num5 = num3 - (double)a3;
					num20 = (ushort)(num + 1);
					num = num20;
					DrawLine(streamWriter, num20, text, num18 + num2, num19 + num3, num18 + num4, num19 + num5);
					num2 = num4;
					num3 = num5;
					num4 = num2 - (double)b3;
					num5 = num3;
					num20 = (ushort)(num + 1);
					num = num20;
					DrawLine(streamWriter, num20, text, num18 + num2, num19 + num3, num18 + num4, num19 + num5);
					num2 = num4;
					num3 = num5;
					num4 = num2;
					num5 = num3 + (double)a3;
					num20 = (ushort)(num + 1);
					num = num20;
					DrawLine(streamWriter, num20, text, num18 + num2, num19 + num3, num18 + num4, num19 + num5);
					num2 = num4;
					num3 = num5;
					num4 = num2 + (double)b3;
					num5 = num3;
					num20 = (ushort)(num + 1);
					num = num20;
					DrawLine(streamWriter, num20, text, num18 + num2, num19 + num3, num18 + num4, num19 + num5);
				}
				d1 = num38;
				a1 = num39;
				b1 = num40;
				d2 = num41;
				a2 = num42;
				b2 = num43;
				d3 = num44;
				a3 = num45;
				b3 = num46;
			}
			if (G == b)
			{
				typeUpperStrip = 1;
			}
			else if (b - G >= 50)
			{
				typeUpperStrip = 2;
			}
			if (zhyrFiltr == "так")
			{
				double num51 = 9.5;
				double num52 = 69.0;
				double num53 = 59.5;
				double num54 = 15.0;
				double num55 = 38.5;
				double num56 = 19.5;
				num18 = B + 500;
				num19 = 600.0;
				if (typeUpperStrip == 1)
				{
					num2 = num54;
					num3 = 0.0;
					num4 = num2;
					num5 = num3 + num56;
					num20 = (ushort)(num + 1);
					num = num20;
					DrawLine(streamWriter, num20, text, num18 + num2, num19 + num3, num18 + num4, num19 + num5);
					num2 = num4;
					num3 = num5;
					num4 = num2 + num7;
					num5 = num3;
					num20 = (ushort)(num + 1);
					num = num20;
					DrawLine(streamWriter, num20, text, num18 + num2, num19 + num3, num18 + num4, num19 + num5);
					num2 = num4;
					num3 = num5;
					num4 = num2;
					num5 = num3 + num7;
					num20 = (ushort)(num + 1);
					num = num20;
					DrawLine(streamWriter, num20, text, num18 + num2, num19 + num3, num18 + num4, num19 + num5);
					num2 = num4;
					num3 = num5;
					num4 = num2 - num7;
					num5 = num3;
					num20 = (ushort)(num + 1);
					num = num20;
					DrawLine(streamWriter, num20, text, num18 + num2, num19 + num3, num18 + num4, num19 + num5);
					num2 = num4;
					num3 = num5;
					num4 = num2;
					num5 = num3 + num55;
					num20 = (ushort)(num + 1);
					num = num20;
					DrawLine(streamWriter, num20, text, num18 + num2, num19 + num3, num18 + num4, num19 + num5);
					num2 = num4;
					num3 = num5;
					num4 = num2 + num7;
					num5 = num3;
					num20 = (ushort)(num + 1);
					num = num20;
					DrawLine(streamWriter, num20, text, num18 + num2, num19 + num3, num18 + num4, num19 + num5);
					num2 = num4;
					num3 = num5;
					num4 = num2;
					num5 = num3 + num7;
					num20 = (ushort)(num + 1);
					num = num20;
					DrawLine(streamWriter, num20, text, num18 + num2, num19 + num3, num18 + num4, num19 + num5);
					num2 = num4;
					num3 = num5;
					num4 = num2 - num7 - num54;
					num5 = num3;
					num20 = (ushort)(num + 1);
					num = num20;
					DrawLine(streamWriter, num20, text, num18 + num2, num19 + num3, num18 + num4, num19 + num5);
					num2 = num4;
					num3 = num5;
					num4 = num2;
					num5 = num3 + num53;
					num20 = (ushort)(num + 1);
					num = num20;
					DrawLine(streamWriter, num20, text, num18 + num2, num19 + num3, num18 + num4, num19 + num5);
					num2 = num4;
					num3 = num5;
					num4 = num2 + num7;
					num5 = num3;
					num20 = (ushort)(num + 1);
					num = num20;
					DrawLine(streamWriter, num20, text, num18 + num2, num19 + num3, num18 + num4, num19 + num5);
					num2 = num4;
					num3 = num5;
					num4 = num2;
					num5 = num3 + num7;
					num20 = (ushort)(num + 1);
					num = num20;
					DrawLine(streamWriter, num20, text, num18 + num2, num19 + num3, num18 + num4, num19 + num5);
					num2 = num4;
					num3 = num5;
					num4 = num2 - num7;
					num5 = num3;
					num20 = (ushort)(num + 1);
					num = num20;
					DrawLine(streamWriter, num20, text, num18 + num2, num19 + num3, num18 + num4, num19 + num5);
					num2 = num4;
					num3 = num5;
					num4 = num2;
					num5 = num3 + num52;
					num20 = (ushort)(num + 1);
					num = num20;
					DrawLine(streamWriter, num20, text, num18 + num2, num19 + num3, num18 + num4, num19 + num5);
					num2 = num4;
					num3 = num5;
					num4 = num2 + num7;
					num5 = num3;
					num20 = (ushort)(num + 1);
					num = num20;
					DrawLine(streamWriter, num20, text, num18 + num2, num19 + num3, num18 + num4, num19 + num5);
					num2 = num4;
					num3 = num5;
					num4 = num2;
					num5 = num3 + num7;
					num20 = (ushort)(num + 1);
					num = num20;
					DrawLine(streamWriter, num20, text, num18 + num2, num19 + num3, num18 + num4, num19 + num5);
					num2 = num4;
					num3 = num5;
					num4 = num2 - num7;
					num5 = num3;
					num20 = (ushort)(num + 1);
					num = num20;
					DrawLine(streamWriter, num20, text, num18 + num2, num19 + num3, num18 + num4, num19 + num5);
					num2 = num4;
					num3 = num5;
					num4 = num2;
					num5 = num3 + num51;
					num20 = (ushort)(num + 1);
					num = num20;
					DrawLine(streamWriter, num20, text, num18 + num2, num19 + num3, num18 + num4, num19 + num5);
					num2 = num4;
					num3 = num5;
					num4 = num2 + (double)L - 5.0;
					num5 = num3;
					num20 = (ushort)(num + 1);
					num = num20;
					DrawLine(streamWriter, num20, text, num18 + num2, num19 + num3, num18 + num4, num19 + num5);
					num2 = num4;
					num3 = num5;
					num4 = num2;
					num5 = num3 - num51;
					num20 = (ushort)(num + 1);
					num = num20;
					DrawLine(streamWriter, num20, text, num18 + num2, num19 + num3, num18 + num4, num19 + num5);
					num2 = num4;
					num3 = num5;
					num4 = num2 - num7;
					num5 = num3;
					num20 = (ushort)(num + 1);
					num = num20;
					DrawLine(streamWriter, num20, text, num18 + num2, num19 + num3, num18 + num4, num19 + num5);
					num2 = num4;
					num3 = num5;
					num4 = num2;
					num5 = num3 - num7;
					num20 = (ushort)(num + 1);
					num = num20;
					DrawLine(streamWriter, num20, text, num18 + num2, num19 + num3, num18 + num4, num19 + num5);
					num2 = num4;
					num3 = num5;
					num4 = num2 + num7;
					num5 = num3;
					num20 = (ushort)(num + 1);
					num = num20;
					DrawLine(streamWriter, num20, text, num18 + num2, num19 + num3, num18 + num4, num19 + num5);
					num2 = num4;
					num3 = num5;
					num4 = num2;
					num5 = num3 - num52;
					num20 = (ushort)(num + 1);
					num = num20;
					DrawLine(streamWriter, num20, text, num18 + num2, num19 + num3, num18 + num4, num19 + num5);
					num2 = num4;
					num3 = num5;
					num4 = num2 - num7;
					num5 = num3;
					num20 = (ushort)(num + 1);
					num = num20;
					DrawLine(streamWriter, num20, text, num18 + num2, num19 + num3, num18 + num4, num19 + num5);
					num2 = num4;
					num3 = num5;
					num4 = num2;
					num5 = num3 - num7;
					num20 = (ushort)(num + 1);
					num = num20;
					DrawLine(streamWriter, num20, text, num18 + num2, num19 + num3, num18 + num4, num19 + num5);
					num2 = num4;
					num3 = num5;
					num4 = num2 + num7;
					num5 = num3;
					num20 = (ushort)(num + 1);
					num = num20;
					DrawLine(streamWriter, num20, text, num18 + num2, num19 + num3, num18 + num4, num19 + num5);
					num2 = num4;
					num3 = num5;
					num4 = num2;
					num5 = num3 - num53;
					num20 = (ushort)(num + 1);
					num = num20;
					DrawLine(streamWriter, num20, text, num18 + num2, num19 + num3, num18 + num4, num19 + num5);
					num2 = num4;
					num3 = num5;
					num4 = num2 - num54 - num7;
					num5 = num3;
					num20 = (ushort)(num + 1);
					num = num20;
					DrawLine(streamWriter, num20, text, num18 + num2, num19 + num3, num18 + num4, num19 + num5);
					num2 = num4;
					num3 = num5;
					num4 = num2;
					num5 = num3 - num7;
					num20 = (ushort)(num + 1);
					num = num20;
					DrawLine(streamWriter, num20, text, num18 + num2, num19 + num3, num18 + num4, num19 + num5);
					num2 = num4;
					num3 = num5;
					num4 = num2 + num7;
					num5 = num3;
					num20 = (ushort)(num + 1);
					num = num20;
					DrawLine(streamWriter, num20, text, num18 + num2, num19 + num3, num18 + num4, num19 + num5);
					num2 = num4;
					num3 = num5;
					num4 = num2;
					num5 = num3 - num55;
					num20 = (ushort)(num + 1);
					num = num20;
					DrawLine(streamWriter, num20, text, num18 + num2, num19 + num3, num18 + num4, num19 + num5);
					num2 = num4;
					num3 = num5;
					num4 = num2 - num7;
					num5 = num3;
					num20 = (ushort)(num + 1);
					num = num20;
					DrawLine(streamWriter, num20, text, num18 + num2, num19 + num3, num18 + num4, num19 + num5);
					num2 = num4;
					num3 = num5;
					num4 = num2;
					num5 = num3 - num7;
					num20 = (ushort)(num + 1);
					num = num20;
					DrawLine(streamWriter, num20, text, num18 + num2, num19 + num3, num18 + num4, num19 + num5);
					num2 = num4;
					num3 = num5;
					num4 = num2 + num7;
					num5 = num3;
					num20 = (ushort)(num + 1);
					num = num20;
					DrawLine(streamWriter, num20, text, num18 + num2, num19 + num3, num18 + num4, num19 + num5);
					num2 = num4;
					num3 = num5;
					num4 = num2;
					num5 = num3 - num56;
					num20 = (ushort)(num + 1);
					num = num20;
					DrawLine(streamWriter, num20, text, num18 + num2, num19 + num3, num18 + num4, num19 + num5);
					num2 = num4;
					num3 = num5;
					num4 = num2 - ((double)(L - 5) - 2.0 * num54);
					num5 = num3;
					num20 = (ushort)(num + 1);
					num = num20;
					DrawLine(streamWriter, num20, text, num18 + num2, num19 + num3, num18 + num4, num19 + num5);
					num = DrawZaklepka_1(streamWriter, num, text, connection, num4 - 2.5 - num54 + num18, num5 + num19, num2 + 2.5 + num54 + num18, num3 + num19, 0);
				}
				else
				{
					num2 = num54;
					num3 = 0.0;
					num4 = num2;
					num5 = num3 + num56;
					num20 = (ushort)(num + 1);
					num = num20;
					DrawLine(streamWriter, num20, text, num18 + num2, num19 + num3, num18 + num4, num19 + num5);
					num2 = num4;
					num3 = num5;
					num4 = num2 + num7;
					num5 = num3;
					num20 = (ushort)(num + 1);
					num = num20;
					DrawLine(streamWriter, num20, text, num18 + num2, num19 + num3, num18 + num4, num19 + num5);
					num2 = num4;
					num3 = num5;
					num4 = num2;
					num5 = num3 + num7;
					num20 = (ushort)(num + 1);
					num = num20;
					DrawLine(streamWriter, num20, text, num18 + num2, num19 + num3, num18 + num4, num19 + num5);
					num2 = num4;
					num3 = num5;
					num4 = num2 - num7 - num54;
					num5 = num3;
					num20 = (ushort)(num + 1);
					num = num20;
					DrawLine(streamWriter, num20, text, num18 + num2, num19 + num3, num18 + num4, num19 + num5);
					num2 = num4;
					num3 = num5;
					num4 = num2;
					num5 = num3 + num53;
					num20 = (ushort)(num + 1);
					num = num20;
					DrawLine(streamWriter, num20, text, num18 + num2, num19 + num3, num18 + num4, num19 + num5);
					num2 = num4;
					num3 = num5;
					num4 = num2 + num7;
					num5 = num3;
					num20 = (ushort)(num + 1);
					num = num20;
					DrawLine(streamWriter, num20, text, num18 + num2, num19 + num3, num18 + num4, num19 + num5);
					num2 = num4;
					num3 = num5;
					num4 = num2;
					num5 = num3 + num7;
					num20 = (ushort)(num + 1);
					num = num20;
					DrawLine(streamWriter, num20, text, num18 + num2, num19 + num3, num18 + num4, num19 + num5);
					num2 = num4;
					num3 = num5;
					num4 = num2 - num7;
					num5 = num3;
					num20 = (ushort)(num + 1);
					num = num20;
					DrawLine(streamWriter, num20, text, num18 + num2, num19 + num3, num18 + num4, num19 + num5);
					num2 = num4;
					num3 = num5;
					num4 = num2;
					num5 = num3 + num52;
					num20 = (ushort)(num + 1);
					num = num20;
					DrawLine(streamWriter, num20, text, num18 + num2, num19 + num3, num18 + num4, num19 + num5);
					num2 = num4;
					num3 = num5;
					num4 = num2 + num7;
					num5 = num3;
					num20 = (ushort)(num + 1);
					num = num20;
					DrawLine(streamWriter, num20, text, num18 + num2, num19 + num3, num18 + num4, num19 + num5);
					num2 = num4;
					num3 = num5;
					num4 = num2;
					num5 = num3 + num7;
					num20 = (ushort)(num + 1);
					num = num20;
					DrawLine(streamWriter, num20, text, num18 + num2, num19 + num3, num18 + num4, num19 + num5);
					num2 = num4;
					num3 = num5;
					num4 = num2 - num7;
					num5 = num3;
					num20 = (ushort)(num + 1);
					num = num20;
					DrawLine(streamWriter, num20, text, num18 + num2, num19 + num3, num18 + num4, num19 + num5);
					num2 = num4;
					num3 = num5;
					num4 = num2;
					num5 = num3 + num51;
					num20 = (ushort)(num + 1);
					num = num20;
					DrawLine(streamWriter, num20, text, num18 + num2, num19 + num3, num18 + num4, num19 + num5);
					num2 = num4;
					num3 = num5;
					num4 = num2 + (double)L - 5.0;
					num5 = num3;
					num20 = (ushort)(num + 1);
					num = num20;
					DrawLine(streamWriter, num20, text, num18 + num2, num19 + num3, num18 + num4, num19 + num5);
					num2 = num4;
					num3 = num5;
					num4 = num2;
					num5 = num3 - num51;
					num20 = (ushort)(num + 1);
					num = num20;
					DrawLine(streamWriter, num20, text, num18 + num2, num19 + num3, num18 + num4, num19 + num5);
					num2 = num4;
					num3 = num5;
					num4 = num2 - num7;
					num5 = num3;
					num20 = (ushort)(num + 1);
					num = num20;
					DrawLine(streamWriter, num20, text, num18 + num2, num19 + num3, num18 + num4, num19 + num5);
					num2 = num4;
					num3 = num5;
					num4 = num2;
					num5 = num3 - num7;
					num20 = (ushort)(num + 1);
					num = num20;
					DrawLine(streamWriter, num20, text, num18 + num2, num19 + num3, num18 + num4, num19 + num5);
					num2 = num4;
					num3 = num5;
					num4 = num2 + num7;
					num5 = num3;
					num20 = (ushort)(num + 1);
					num = num20;
					DrawLine(streamWriter, num20, text, num18 + num2, num19 + num3, num18 + num4, num19 + num5);
					num2 = num4;
					num3 = num5;
					num4 = num2;
					num5 = num3 - num52;
					num20 = (ushort)(num + 1);
					num = num20;
					DrawLine(streamWriter, num20, text, num18 + num2, num19 + num3, num18 + num4, num19 + num5);
					num2 = num4;
					num3 = num5;
					num4 = num2 - num7;
					num5 = num3;
					num20 = (ushort)(num + 1);
					num = num20;
					DrawLine(streamWriter, num20, text, num18 + num2, num19 + num3, num18 + num4, num19 + num5);
					num2 = num4;
					num3 = num5;
					num4 = num2;
					num5 = num3 - num7;
					num20 = (ushort)(num + 1);
					num = num20;
					DrawLine(streamWriter, num20, text, num18 + num2, num19 + num3, num18 + num4, num19 + num5);
					num2 = num4;
					num3 = num5;
					num4 = num2 + num7;
					num5 = num3;
					num20 = (ushort)(num + 1);
					num = num20;
					DrawLine(streamWriter, num20, text, num18 + num2, num19 + num3, num18 + num4, num19 + num5);
					num2 = num4;
					num3 = num5;
					num4 = num2;
					num5 = num3 - num53;
					num20 = (ushort)(num + 1);
					num = num20;
					DrawLine(streamWriter, num20, text, num18 + num2, num19 + num3, num18 + num4, num19 + num5);
					num2 = num4;
					num3 = num5;
					num4 = num2 - num54 - num7;
					num5 = num3;
					num20 = (ushort)(num + 1);
					num = num20;
					DrawLine(streamWriter, num20, text, num18 + num2, num19 + num3, num18 + num4, num19 + num5);
					num2 = num4;
					num3 = num5;
					num4 = num2;
					num5 = num3 - num7;
					num20 = (ushort)(num + 1);
					num = num20;
					DrawLine(streamWriter, num20, text, num18 + num2, num19 + num3, num18 + num4, num19 + num5);
					num2 = num4;
					num3 = num5;
					num4 = num2 + num7;
					num5 = num3;
					num20 = (ushort)(num + 1);
					num = num20;
					DrawLine(streamWriter, num20, text, num18 + num2, num19 + num3, num18 + num4, num19 + num5);
					num2 = num4;
					num3 = num5;
					num4 = num2;
					num5 = num3 - num56;
					num20 = (ushort)(num + 1);
					num = num20;
					DrawLine(streamWriter, num20, text, num18 + num2, num19 + num3, num18 + num4, num19 + num5);
					num2 = num4;
					num3 = num5;
					num4 = num2 - ((double)(L - 5) - 2.0 * num54);
					num5 = num3;
					num20 = (ushort)(num + 1);
					num = num20;
					DrawLine(streamWriter, num20, text, num18 + num2, num19 + num3, num18 + num4, num19 + num5);
					num = DrawZaklepka_1(streamWriter, num, text, connection, num4 - 2.5 - num54 + num18, num5 + num19, num2 + 2.5 + num54 + num18, num3 + num19, 0);
				}
				if (num6 == 1)
				{
					num18 = B + 500;
					num19 = 200.0;
					int num57 = 95;
					num2 = 0.0;
					num3 = 0.0;
					num4 = num2;
					num5 = num3 + (double)num57;
					num20 = (ushort)(num + 1);
					num = num20;
					DrawLine(streamWriter, num20, text, num18 + num2, num19 + num3, num18 + num4, num19 + num5);
					num2 = num4;
					num3 = num5;
					num4 = num2 + (double)L - 10.0;
					num5 = num3;
					num20 = (ushort)(num + 1);
					num = num20;
					DrawLine(streamWriter, num20, text, num18 + num2, num19 + num3, num18 + num4, num19 + num5);
					num2 = num4;
					num3 = num5;
					num4 = num2;
					num5 = num3 - (double)num57;
					num20 = (ushort)(num + 1);
					num = num20;
					DrawLine(streamWriter, num20, text, num18 + num2, num19 + num3, num18 + num4, num19 + num5);
					num2 = num4;
					num3 = num5;
					num4 = num2 - (double)(L - 10);
					num5 = num3;
					num20 = (ushort)(num + 1);
					num = num20;
					DrawLine(streamWriter, num20, text, num18 + num2, num19 + num3, num18 + num4, num19 + num5);
				}
				else
				{
					num18 = B + 500;
					num19 = 120.0;
					num51 = 54.5;
					num52 = 14.5;
					num2 = 0.0;
					num3 = 0.0;
					num4 = num2;
					num5 = num3 + num52;
					num20 = (ushort)(num + 1);
					num = num20;
					DrawLine(streamWriter, num20, text, num18 + num2, num19 + num3, num18 + num4, num19 + num5);
					num2 = num4;
					num3 = num5;
					num4 = num2 + num7;
					num5 = num3;
					num20 = (ushort)(num + 1);
					num = num20;
					DrawLine(streamWriter, num20, text, num18 + num2, num19 + num3, num18 + num4, num19 + num5);
					num2 = num4;
					num3 = num5;
					num4 = num2;
					num5 = num3 + num7;
					num20 = (ushort)(num + 1);
					num = num20;
					DrawLine(streamWriter, num20, text, num18 + num2, num19 + num3, num18 + num4, num19 + num5);
					num2 = num4;
					num3 = num5;
					num4 = num2 - num7;
					num5 = num3;
					num20 = (ushort)(num + 1);
					num = num20;
					DrawLine(streamWriter, num20, text, num18 + num2, num19 + num3, num18 + num4, num19 + num5);
					num2 = num4;
					num3 = num5;
					num4 = num2;
					num5 = num3 + num51;
					num20 = (ushort)(num + 1);
					num = num20;
					DrawLine(streamWriter, num20, text, num18 + num2, num19 + num3, num18 + num4, num19 + num5);
					num2 = num4;
					num3 = num5;
					num4 = num2 + (double)(L - 10);
					num5 = num3;
					num20 = (ushort)(num + 1);
					num = num20;
					DrawLine(streamWriter, num20, text, num18 + num2, num19 + num3, num18 + num4, num19 + num5);
					num2 = num4;
					num3 = num5;
					num4 = num2;
					num5 = num3 - num51;
					num20 = (ushort)(num + 1);
					num = num20;
					DrawLine(streamWriter, num20, text, num18 + num2, num19 + num3, num18 + num4, num19 + num5);
					num2 = num4;
					num3 = num5;
					num4 = num2 - num7;
					num5 = num3;
					num20 = (ushort)(num + 1);
					num = num20;
					DrawLine(streamWriter, num20, text, num18 + num2, num19 + num3, num18 + num4, num19 + num5);
					num2 = num4;
					num3 = num5;
					num4 = num2;
					num5 = num3 - num7;
					num20 = (ushort)(num + 1);
					num = num20;
					DrawLine(streamWriter, num20, text, num18 + num2, num19 + num3, num18 + num4, num19 + num5);
					num2 = num4;
					num3 = num5;
					num4 = num2 + num7;
					num5 = num3;
					num20 = (ushort)(num + 1);
					num = num20;
					DrawLine(streamWriter, num20, text, num18 + num2, num19 + num3, num18 + num4, num19 + num5);
					num2 = num4;
					num3 = num5;
					num4 = num2;
					num5 = num3 - num52;
					num20 = (ushort)(num + 1);
					num = num20;
					DrawLine(streamWriter, num20, text, num18 + num2, num19 + num3, num18 + num4, num19 + num5);
					if (zlyv == "ні")
					{
						num2 = num4;
						num3 = num5;
						num4 = num2 - (double)(L - 10);
						num5 = num3;
						num20 = (ushort)(num + 1);
						num = num20;
						DrawLine(streamWriter, num20, text, num18 + num2, num19 + num3, num18 + num4, num19 + num5);
					}
					else
					{
						double num58 = 12.5;
						double num59 = 10.5;
						double num60 = 72.5;
						num2 = num4 - (double)(L - 10);
						num3 = num5;
						num4 = num2 + num60 - num58;
						num5 = num3;
						num20 = (ushort)(num + 1);
						num = num20;
						DrawLine(streamWriter, num20, text, num18 + num2, num19 + num3, num18 + num4, num19 + num5);
						double num61 = num4;
						double num62 = num5;
						double num63 = 15.0;
						double num64 = 16.0;
						double num65 = 40.0;
						double num66 = 7.0;
						num2 += num63;
						num3 += num64;
						num4 = num2;
						num5 = num3 + num66;
						num20 = (ushort)(num + 1);
						num = num20;
						DrawLine(streamWriter, num20, text, num18 + num2, num19 + num3, num18 + num4, num19 + num5);
						num2 = num4;
						num3 = num5;
						num4 = num2 + num65;
						num5 = num3;
						num20 = (ushort)(num + 1);
						num = num20;
						DrawLine(streamWriter, num20, text, num18 + num2, num19 + num3, num18 + num4, num19 + num5);
						num2 = num4;
						num3 = num5;
						num4 = num2;
						num5 = num3 - num66;
						num20 = (ushort)(num + 1);
						num = num20;
						DrawLine(streamWriter, num20, text, num18 + num2, num19 + num3, num18 + num4, num19 + num5);
						num2 = num4;
						num3 = num5;
						num4 = num2 - num65;
						num5 = num3;
						num20 = (ushort)(num + 1);
						num = num20;
						DrawLine(streamWriter, num20, text, num18 + num2, num19 + num3, num18 + num4, num19 + num5);
						num2 = num61;
						num3 = num62;
						num4 = num2;
						num5 = num3 + num59 + num58;
						num20 = (ushort)(num + 1);
						num = num20;
						DrawLine(streamWriter, num20, text, num18 + num2, num19 + num3, num18 + num4, num19 + num5);
						num2 = num4;
						num3 = num5;
						num4 = num2 + 2.0 * num58;
						num5 = num3;
						num20 = (ushort)(num + 1);
						num = num20;
						DrawLine(streamWriter, num20, text, num18 + num2, num19 + num3, num18 + num4, num19 + num5);
						num2 = num4;
						num3 = num5;
						num4 = num2;
						num5 = num3 - (num59 + num58);
						num20 = (ushort)(num + 1);
						num = num20;
						DrawLine(streamWriter, num20, text, num18 + num2, num19 + num3, num18 + num4, num19 + num5);
						num61 = num4;
						num62 = num5;
						double num67 = 34.0;
						num63 = num4 + 5.0;
						num64 += num5;
						int num68 = (int)Math.Floor(((double)(L - 10) - num63) / (num67 + num65));
						for (int i = 0; i < num68; i++)
						{
							num2 = num63 + (double)i * (num67 + num65);
							num3 = num64;
							num4 = num2;
							num5 = num3 + num66;
							num20 = (ushort)(num + 1);
							num = num20;
							DrawLine(streamWriter, num20, text, num18 + num2, num19 + num3, num18 + num4, num19 + num5);
							num2 = num4;
							num3 = num5;
							num4 = num2 + num65;
							num5 = num3;
							num20 = (ushort)(num + 1);
							num = num20;
							DrawLine(streamWriter, num20, text, num18 + num2, num19 + num3, num18 + num4, num19 + num5);
							num2 = num4;
							num3 = num5;
							num4 = num2;
							num5 = num3 - num66;
							num20 = (ushort)(num + 1);
							num = num20;
							DrawLine(streamWriter, num20, text, num18 + num2, num19 + num3, num18 + num4, num19 + num5);
							num2 = num4;
							num3 = num5;
							num4 = num2 - num65;
							num5 = num3;
							num20 = (ushort)(num + 1);
							num = num20;
							DrawLine(streamWriter, num20, text, num18 + num2, num19 + num3, num18 + num4, num19 + num5);
						}
						num2 = num61;
						num3 = num62;
						num4 = num2 + (double)L - 10.0 - (num60 + num58);
						num5 = num3;
						num20 = (ushort)(num + 1);
						num = num20;
						DrawLine(streamWriter, num20, text, num18 + num2, num19 + num3, num18 + num4, num19 + num5);
					}
					num51 = 24.5;
					num52 = 109.0;
					num18 = B + 500;
					num19 = 300.0;
					num2 = 0.0;
					num3 = 0.0;
					num4 = num2;
					num5 = num3 + num51;
					num20 = (ushort)(num + 1);
					num = num20;
					DrawLine(streamWriter, num20, text, num18 + num2, num19 + num3, num18 + num4, num19 + num5);
					num2 = num4;
					num3 = num5;
					num4 = num2 + num7;
					num5 = num3;
					num20 = (ushort)(num + 1);
					num = num20;
					DrawLine(streamWriter, num20, text, num18 + num2, num19 + num3, num18 + num4, num19 + num5);
					num2 = num4;
					num3 = num5;
					num4 = num2;
					num5 = num3 + num7;
					num20 = (ushort)(num + 1);
					num = num20;
					DrawLine(streamWriter, num20, text, num18 + num2, num19 + num3, num18 + num4, num19 + num5);
					num2 = num4;
					num3 = num5;
					num4 = num2 - num7;
					num5 = num3;
					num20 = (ushort)(num + 1);
					num = num20;
					DrawLine(streamWriter, num20, text, num18 + num2, num19 + num3, num18 + num4, num19 + num5);
					num2 = num4;
					num3 = num5;
					num4 = num2;
					num5 = num3 + num52;
					num20 = (ushort)(num + 1);
					num = num20;
					DrawLine(streamWriter, num20, text, num18 + num2, num19 + num3, num18 + num4, num19 + num5);
					num = DrawZaklepka_Top_2(streamWriter, num, text, connection, num2 + num18, num3 + num19, num4 + num18, num5 + num19, 1);
					num2 = num4;
					num3 = num5;
					num4 = num2 + num7;
					num5 = num3;
					num20 = (ushort)(num + 1);
					num = num20;
					DrawLine(streamWriter, num20, text, num18 + num2, num19 + num3, num18 + num4, num19 + num5);
					num2 = num4;
					num3 = num5;
					num4 = num2;
					num5 = num3 + num7;
					num20 = (ushort)(num + 1);
					num = num20;
					DrawLine(streamWriter, num20, text, num18 + num2, num19 + num3, num18 + num4, num19 + num5);
					num2 = num4;
					num3 = num5;
					num4 = num2 - num7;
					num5 = num3;
					num20 = (ushort)(num + 1);
					num = num20;
					DrawLine(streamWriter, num20, text, num18 + num2, num19 + num3, num18 + num4, num19 + num5);
					num2 = num4;
					num3 = num5;
					num4 = num2;
					num5 = num3 + num51;
					num20 = (ushort)(num + 1);
					num = num20;
					DrawLine(streamWriter, num20, text, num18 + num2, num19 + num3, num18 + num4, num19 + num5);
					num2 = num4;
					num3 = num5;
					num4 = num2 + (double)L - 5.0;
					num5 = num3;
					num20 = (ushort)(num + 1);
					num = num20;
					DrawLine(streamWriter, num20, text, num18 + num2, num19 + num3, num18 + num4, num19 + num5);
					num2 = num4;
					num3 = num5;
					num4 = num2;
					num5 = num3 - num51;
					num20 = (ushort)(num + 1);
					num = num20;
					DrawLine(streamWriter, num20, text, num18 + num2, num19 + num3, num18 + num4, num19 + num5);
					num2 = num4;
					num3 = num5;
					num4 = num2 - num7;
					num5 = num3;
					num20 = (ushort)(num + 1);
					num = num20;
					DrawLine(streamWriter, num20, text, num18 + num2, num19 + num3, num18 + num4, num19 + num5);
					num2 = num4;
					num3 = num5;
					num4 = num2;
					num5 = num3 - num7;
					num20 = (ushort)(num + 1);
					num = num20;
					DrawLine(streamWriter, num20, text, num18 + num2, num19 + num3, num18 + num4, num19 + num5);
					num2 = num4;
					num3 = num5;
					num4 = num2 + num7;
					num5 = num3;
					num20 = (ushort)(num + 1);
					num = num20;
					DrawLine(streamWriter, num20, text, num18 + num2, num19 + num3, num18 + num4, num19 + num5);
					num2 = num4;
					num3 = num5;
					num4 = num2;
					num5 = num3 - num52;
					num20 = (ushort)(num + 1);
					num = num20;
					DrawLine(streamWriter, num20, text, num18 + num2, num19 + num3, num18 + num4, num19 + num5);
					num = DrawZaklepka_Top(streamWriter, num, text, connection, num2 + num18, num3 + num19, num4 + num18, num5 + num19, 1);
					num2 = num4;
					num3 = num5;
					num4 = num2 - num7;
					num5 = num3;
					num20 = (ushort)(num + 1);
					num = num20;
					DrawLine(streamWriter, num20, text, num18 + num2, num19 + num3, num18 + num4, num19 + num5);
					num2 = num4;
					num3 = num5;
					num4 = num2;
					num5 = num3 - num7;
					num20 = (ushort)(num + 1);
					num = num20;
					DrawLine(streamWriter, num20, text, num18 + num2, num19 + num3, num18 + num4, num19 + num5);
					num2 = num4;
					num3 = num5;
					num4 = num2 + num7;
					num5 = num3;
					num20 = (ushort)(num + 1);
					num = num20;
					DrawLine(streamWriter, num20, text, num18 + num2, num19 + num3, num18 + num4, num19 + num5);
					num2 = num4;
					num3 = num5;
					num4 = num2;
					num5 = num3 - num51;
					num20 = (ushort)(num + 1);
					num = num20;
					DrawLine(streamWriter, num20, text, num18 + num2, num19 + num3, num18 + num4, num19 + num5);
					if (zhyrFiltr == "так" && zlyv != "ні")
					{
						double num69 = 75.0;
						double num70 = 80.0;
						double num71 = 16.0;
						num2 = ((zlyv == "так, трубка справа") ? (num4 - num69) : (num4 - (double)(L - 5) + num69));
						num3 = num5 + num70;
						num20 = (ushort)(num + 1);
						num = num20;
						DrawCircle(streamWriter, num20, text, num18 + num2, num19 + num3, num71 / 2.0);
					}
					num2 = num4;
					num3 = num5;
					num4 = num2 - (double)(L - 5);
					num5 = num3;
					num20 = (ushort)(num + 1);
					num = num20;
					DrawLine(streamWriter, num20, text, num18 + num2, num19 + num3, num18 + num4, num19 + num5);
				}
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
				num51 = 19.5;
				double num72 = 1.0;
				num52 = 19.0;
				num53 = 42.5;
				num18 = B + 500;
				num19 = 900.0;
				num2 = 0.0;
				num3 = 0.0;
				num4 = num2;
				num5 = num3 + num53;
				num20 = (ushort)(num + 1);
				num = num20;
				DrawLine(streamWriter, num20, text, num18 + num2, num19 + num3, num18 + num4, num19 + num5);
				num2 = num4;
				num3 = num5;
				num4 = num2 + num51;
				num5 = num3;
				num20 = (ushort)(num + 1);
				num = num20;
				DrawLine(streamWriter, num20, text, num18 + num2, num19 + num3, num18 + num4, num19 + num5);
				num2 = num4;
				num3 = num5;
				num4 = num2;
				num5 = num3 - num72;
				num20 = (ushort)(num + 1);
				num = num20;
				DrawLine(streamWriter, num20, text, num18 + num2, num19 + num3, num18 + num4, num19 + num5);
				num2 = num4;
				num3 = num5;
				num4 = num2 + num72;
				num5 = num3;
				num20 = (ushort)(num + 1);
				num = num20;
				DrawLine(streamWriter, num20, text, num18 + num2, num19 + num3, num18 + num4, num19 + num5);
				num2 = num4;
				num3 = num5;
				num4 = num2;
				num5 = num3 + num72;
				num20 = (ushort)(num + 1);
				num = num20;
				DrawLine(streamWriter, num20, text, num18 + num2, num19 + num3, num18 + num4, num19 + num5);
				num2 = num4;
				num3 = num5;
				num4 = num2 + num51 + num72;
				num5 = num3;
				num20 = (ushort)(num + 1);
				num = num20;
				DrawLine(streamWriter, num20, text, num18 + num2, num19 + num3, num18 + num4, num19 + num5);
				num2 = num4;
				num3 = num5;
				num4 = num2;
				num5 = num3 + num72;
				num20 = (ushort)(num + 1);
				num = num20;
				DrawLine(streamWriter, num20, text, num18 + num2, num19 + num3, num18 + num4, num19 + num5);
				num2 = num4;
				num3 = num5;
				num4 = num2 - num72;
				num5 = num3;
				num20 = (ushort)(num + 1);
				num = num20;
				DrawLine(streamWriter, num20, text, num18 + num2, num19 + num3, num18 + num4, num19 + num5);
				num2 = num4;
				num3 = num5;
				num4 = num2;
				num5 = num3 + (kk - 0.5);
				num20 = (ushort)(num + 1);
				num = num20;
				DrawLine(streamWriter, num20, text, num18 + num2, num19 + num3, num18 + num4, num19 + num5);
				num2 = num4;
				num3 = num5;
				num4 = num2 + (double)(l + 30);
				num5 = num3;
				num20 = (ushort)(num + 1);
				num = num20;
				DrawLine(streamWriter, num20, text, num18 + num2, num19 + num3, num18 + num4, num19 + num5);
				num2 = num4;
				num3 = num5;
				num4 = num2;
				num5 = num3 - (kk - 0.5);
				num20 = (ushort)(num + 1);
				num = num20;
				DrawLine(streamWriter, num20, text, num18 + num2, num19 + num3, num18 + num4, num19 + num5);
				num2 = num4;
				num3 = num5;
				num4 = num2 - num72;
				num5 = num3;
				num20 = (ushort)(num + 1);
				num = num20;
				DrawLine(streamWriter, num20, text, num18 + num2, num19 + num3, num18 + num4, num19 + num5);
				num2 = num4;
				num3 = num5;
				num4 = num2;
				num5 = num3 - num72;
				num20 = (ushort)(num + 1);
				num = num20;
				DrawLine(streamWriter, num20, text, num18 + num2, num19 + num3, num18 + num4, num19 + num5);
				num2 = num4;
				num3 = num5;
				num4 = num2 + num72;
				num5 = num3;
				num20 = (ushort)(num + 1);
				num = num20;
				DrawLine(streamWriter, num20, text, num18 + num2, num19 + num3, num18 + num4, num19 + num5);
				num2 = num4;
				num3 = num5;
				num4 = num2;
				num5 = num3 - num53;
				num20 = (ushort)(num + 1);
				num = num20;
				DrawLine(streamWriter, num20, text, num18 + num2, num19 + num3, num18 + num4, num19 + num5);
				num2 = num4;
				num3 = num5;
				num4 = num2 - ((double)(l + 30) - 0.5);
				num5 = num3;
				num20 = (ushort)(num + 1);
				num = num20;
				DrawLine(streamWriter, num20, text, num18 + num2, num19 + num3, num18 + num4, num19 + num5);
				num2 = num4;
				num3 = num5;
				num4 = num2;
				num5 = num3 + num72;
				num20 = (ushort)(num + 1);
				num = num20;
				DrawLine(streamWriter, num20, text, num18 + num2, num19 + num3, num18 + num4, num19 + num5);
				num2 = num4;
				num3 = num5;
				num4 = num2 - num72;
				num5 = num3;
				num20 = (ushort)(num + 1);
				num = num20;
				DrawLine(streamWriter, num20, text, num18 + num2, num19 + num3, num18 + num4, num19 + num5);
				num2 = num4;
				num3 = num5;
				num4 = num2;
				num5 = num3 - num72;
				num20 = (ushort)(num + 1);
				num = num20;
				DrawLine(streamWriter, num20, text, num18 + num2, num19 + num3, num18 + num4, num19 + num5);
				num2 = num4;
				num3 = num5;
				num4 = num2 - num52;
				num5 = num3;
				num20 = (ushort)(num + 1);
				num = num20;
				DrawLine(streamWriter, num20, text, num18 + num2, num19 + num3, num18 + num4, num19 + num5);
				num2 = num4;
				num3 = num5;
				num4 = num2;
				num5 = num3 + num72;
				num20 = (ushort)(num + 1);
				num = num20;
				DrawLine(streamWriter, num20, text, num18 + num2, num19 + num3, num18 + num4, num19 + num5);
				num2 = num4;
				num3 = num5;
				num4 = num2 - num72;
				num5 = num3;
				num20 = (ushort)(num + 1);
				num = num20;
				DrawLine(streamWriter, num20, text, num18 + num2, num19 + num3, num18 + num4, num19 + num5);
				num2 = num4;
				num3 = num5;
				num4 = num2;
				num5 = num3 - num72;
				num20 = (ushort)(num + 1);
				num = num20;
				DrawLine(streamWriter, num20, text, num18 + num2, num19 + num3, num18 + num4, num19 + num5);
				num2 = num4;
				num3 = num5;
				num4 = num2 - num51;
				num5 = num3;
				num20 = (ushort)(num + 1);
				num = num20;
				DrawLine(streamWriter, num20, text, num18 + num2, num19 + num3, num18 + num4, num19 + num5);
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
			double num = 8.0;
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

	public static ushort DrawZaklepka_Top_2(StreamWriter sw, ushort ii, string Layer_Name, string connection, double x1, double y1, double x2, double y2, byte leftRight)
	{
		if (connection == "заклепка")
		{
			double num = 7.0;
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

	public static void ZontOstrivnyyTyp1DrawImage(int L, int B, int H, int h, int b, int number, string zontMaterial, string tovchynaMetaluZont, string connection, string zlyv, string fastening, string typeFastening, string vyhid, string vyhid1, int d1, int a1, int b1, int p1, int f1, int g1, string typVyhid1, string profilType1, string vyhid2, int d2, int a2, int b2, int p2, int f2, int g2, string typVyhid2, string profilType2, string vyhid3, int d3, int a3, int b3, int p3, int f3, int g3, string typVyhid3, string profilType3, string zhyrFiltr, int G, string zhyrFiltrMaterial, string tovchynaMetaluFiltr, string orderCode, string contragent, string filePath = null, bool onlyCalcBeta = false)
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
		//IL_83ba: Unknown result type (might be due to invalid IL or missing references)
		//IL_83c1: Expected O, but got Unknown
		//IL_83c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_83c8: Expected O, but got Unknown
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
			string text = "Зонт ЗВО-1 " + L + "х" + B + "х" + H;
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
			double num27 = (double)b * num18;
			double num28 = (double)L * num18;
			double num29 = (double)H * num18;
			double num30 = (double)B * num18;
			double num31 = (double)h * num18;
			double num32 = (double)G * num18;
			int num33 = (int)((num30 - num27) / 2.0);
			num3 += num33;
			double num34 = num3;
			double num35 = (double)num6 + num28 * Math.Sin(num17);
			double num36 = num34 + num27;
			double num37 = num35;
			val2.DrawLine(val4, (float)num34, (float)num35, (float)num36, (float)num37);
			num36 = num34 + num28 * Math.Cos(num17);
			num37 = num6;
			val2.DrawLine(val4, (float)num34, (float)num35, (float)num36, (float)num37);
			num34 = num36;
			num35 = num37;
			num36 = num34 + num27;
			val2.DrawLine(val4, (float)num34, (float)num35, (float)num36, (float)num37);
			num34 = (double)num3 + num27;
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
			num36 = num34 - (double)(int)((num30 - num27) / 2.0);
			num37 = num35 + num29 - num31;
			val2.DrawLine(val4, (float)num34, (float)num35, (float)num36, (float)num37);
			num34 = num36;
			num35 = num37;
			num37 = num35 + num31;
			val2.DrawLine(val4, (float)num34, (float)num35, (float)num36, (float)num37);
			num35 = num37;
			num36 = num34 + num30;
			val2.DrawLine(val4, (float)num34, (float)num35, (float)num36, (float)num37);
			num34 = num36;
			num35 = num37;
			num37 = num35 - num31;
			val2.DrawLine(val4, (float)num34, (float)num35, (float)num36, (float)num37);
			num35 = num37;
			num36 = (double)num3 + num27;
			num37 = (double)num6 + num28 * Math.Sin(num17);
			val2.DrawLine(val4, (float)num34, (float)num35, (float)num36, (float)num37);
			num34 = (double)(num3 - (int)((num30 - num27) / 2.0)) + num30;
			num35 = (double)num6 + num28 * Math.Sin(num17) + num29;
			num36 = num34 + num28 * Math.Cos(num17);
			num37 = (double)num6 + num29;
			val2.DrawLine(val4, (float)num34, (float)num35, (float)num36, (float)num37);
			num35 -= num31;
			num37 -= num31;
			val2.DrawLine(val4, (float)num34, (float)num35, (float)num36, (float)num37);
			num34 = num36;
			num35 = num37;
			num37 = num35 + num31;
			val2.DrawLine(val4, (float)num34, (float)num35, (float)num36, (float)num37);
			num36 = (double)num3 + num28 * Math.Cos(num17) + num27;
			num37 = num6;
			val2.DrawLine(val4, (float)num34, (float)num35, (float)num36, (float)num37);
			num34 = num3;
			num35 = (double)num6 + num28 * Math.Sin(num17);
			num36 = num34 - (double)(int)((num30 - num27) / 2.0) - (double)num14;
			num37 = num35;
			val2.DrawLine(val3, (float)num34, (float)num35, (float)num36, (float)num37);
			num34 = num3 - (int)((num30 - num27) / 2.0);
			num35 = (double)num6 + num28 * Math.Sin(num17) + num29;
			num36 = num34 - (double)num14;
			num37 = num35;
			val2.DrawLine(val3, (float)num34, (float)num35, (float)num36, (float)num37);
			num34 = num3 - (int)((num30 - num27) / 2.0) - num14 + 5;
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
			num34 = num3 - (int)((num30 - num27) / 2.0);
			num35 = (double)num6 + num28 * Math.Sin(num17) + num29;
			num36 = num34;
			num37 = num35 + (double)num14;
			val2.DrawLine(val3, (float)num34, (float)num35, (float)num36, (float)num37);
			num34 = (double)(num3 - (int)((num30 - num27) / 2.0)) + num30;
			num35 = (double)num6 + num28 * Math.Sin(num17) + num29;
			num36 = num34;
			num37 = num35 + (double)num14;
			val2.DrawLine(val3, (float)num34, (float)num35, (float)num36, (float)num37);
			num34 = num3 - (int)((num30 - num27) / 2.0);
			num35 = (double)num6 + num28 * Math.Sin(num17) + num29 + (double)num14 - 5.0;
			num36 = num34 + num30;
			num37 = num35;
			DrawRows(num34, num35, num36, num37, num18, val2, val3);
			num50 = (num34 + num36) / 2.0;
			num51 = num37 + (double)num21;
			#if WINDOWS
			val9.FormatFlags = (StringFormatFlags)1;
			#endif
			val2.DrawString(B.ToString(), val7, (Brush)(object)val8, (float)num50, (float)num51, val9);
			num34 = (double)(num3 - (int)((num30 - num27) / 2.0)) + num30 + num28 * Math.Cos(num17);
			num35 = (double)num6 + num29;
			num36 = num34;
			num37 = num35 + (double)num14;
			val2.DrawLine(val3, (float)num34, (float)num35, (float)num36, (float)num37);
			num34 = (double)(num3 - (int)((num30 - num27) / 2.0)) + num30;
			num35 = (double)num6 + num28 * Math.Sin(num17) + num29 + (double)num14 - 5.0;
			num36 = num34 + num28 * Math.Cos(num17);
			num37 = (double)num6 + num29 + (double)num14 - 5.0;
			DrawRows(num34, num35, num36, num37, num18, val2, val3);
			num50 = (num34 + num36) / 2.0;
			num51 = (num35 + num37) / 2.0 + 15.0 + 5.0;
			#if WINDOWS
			val9.FormatFlags = (StringFormatFlags)1;
			#endif
			val2.DrawString(L.ToString(), val7, (Brush)(object)val8, (float)num50, (float)num51, val9);
			num34 = num3;
			num35 = (double)num6 + num28 * Math.Sin(num17);
			num36 = num34;
			num37 = num35 - (double)num14;
			val2.DrawLine(val3, (float)num34, (float)num35, (float)num36, (float)num37);
			num34 = (double)num3 + num27;
			num35 = (double)num6 + num28 * Math.Sin(num17);
			num36 = num34;
			num37 = num35 - (double)num14;
			val2.DrawLine(val3, (float)num34, (float)num35, (float)num36, (float)num37);
			num34 = num3;
			num35 = (double)num6 + num28 * Math.Sin(num17) - (double)num14 + 5.0;
			num36 = num34 + num27;
			num37 = num35;
			DrawRows(num34, num35, num36, num37, num18, val2, val3);
			num50 = (num34 + num36) / 2.0;
			num51 = num37 - (double)(num21 / 2);
			#if WINDOWS
			val9.FormatFlags = (StringFormatFlags)1;
			#endif
			val2.DrawString(b.ToString(), val7, (Brush)(object)val8, (float)num50, (float)num51, val9);
			num34 = (double)(num3 - (int)((num30 - num27) / 2.0)) + num30 + num28 * Math.Cos(num17);
			num35 = (double)num6 + num29;
			num36 = num34 + (double)num14;
			num37 = num35;
			val2.DrawLine(val3, (float)num34, (float)num35, (float)num36, (float)num37);
			num34 = (double)(num3 - (int)((num30 - num27) / 2.0)) + num30 + num28 * Math.Cos(num17);
			num35 = (double)num6 + num29 - num31;
			num36 = num34 + (double)num14;
			num37 = num35;
			val2.DrawLine(val3, (float)num34, (float)num35, (float)num36, (float)num37);
			num34 = (double)(num3 - (int)((num30 - num27) / 2.0)) + num30 + num28 * Math.Cos(num17) + (double)num14 - 5.0;
			num35 = (double)num6 + num29 - num31;
			num36 = num34;
			num37 = num35 + num31;
			DrawRows(num34, num35, num36, num37, num18, val2, val3);
			num50 = num34 + (double)num21 + 5.0;
			num51 = (num35 + num37) / 2.0;
			#if WINDOWS
			val9.FormatFlags = (StringFormatFlags)2;
			#endif
			val2.DrawString(h.ToString(), val7, (Brush)(object)val8, (float)num50, (float)num51, val9);
			double num88 = Math.Ceiling(Math.Sqrt((B - b) * (B - b) / 4 + (H - h) * (H - h)));
			num34 = (double)(num3 - (int)((num30 - num27) / 2.0)) + num30 + num28 * Math.Cos(num17);
			num35 = (double)num6 + num29 - num31;
			num42 = (double)num3 + num27 + num28 * Math.Cos(num17);
			num43 = num6;
			double num89 = Math.Atan((num43 - num35) / (num42 - num34));
			num36 = num34 + (double)num14 * Math.Sin(num89);
			num37 = num35 - (double)num14 * Math.Cos(num89);
			val2.DrawLine(val3, (float)num34, (float)num35, (float)num36, (float)num37);
			double num90 = num36;
			double num91 = num37;
			num34 = num42;
			num35 = num43;
			num36 = num34 + (double)num14 * Math.Sin(num89);
			num37 = num35 - (double)num14 * Math.Cos(num89);
			val2.DrawLine(val3, (float)num34, (float)num35, (float)num36, (float)num37);
			double num92 = num36;
			double num93 = num37;
			num34 = num92 - 5.0 * Math.Sin(num89);
			num35 = num93 + 5.0 * Math.Cos(num89);
			num36 = num90 - 5.0 * Math.Sin(num89);
			num37 = num91 + 5.0 * Math.Cos(num89);
			DrawRows(num34, num35, num36, num37, num18, val2, val3);
			num50 = (num34 + num36) / 2.0 + (double)num21;
			num51 = (num35 + num37) / 2.0 - (double)(num21 / 2);
			#if WINDOWS
			val9.FormatFlags = (StringFormatFlags)1;
			#endif
			val2.DrawString(num88.ToString(), val7, (Brush)(object)val8, (float)num50, (float)num51, val9);
			double num94 = Math.Atan((2.0 * (double)H - (double)h) / ((double)B - (double)b));
			double num95 = Math.Min(num31 / 2.0, 20.0);
			num34 = (double)num3 + (num30 + num27) / 2.0;
			num35 = (double)num6 + num28 * Math.Sin(num17) + num29 - num31 + num95;
			num42 = num34 - num95 * Math.Cos(num94);
			num43 = (double)num6 + num28 * Math.Sin(num17) + num29 - num31 - num95 * Math.Sin(num94);
			num36 = num34 - num95;
			num37 = (num35 + num43) / 2.0;
			val2.DrawBezier(val3, (float)num42, (float)num43, (float)num36, (float)num37, (float)num34, (float)num35, (float)num34, (float)num35);
			num94 = Math.Round(num94 * 180.0 / Math.PI, MidpointRounding.AwayFromZero) + 90.0;
			#if WINDOWS
			val9.FormatFlags = (StringFormatFlags)1;
			#endif
			val2.DrawString(num94 + "°", val7, (Brush)(object)val8, (float)(num36 - 10.0), (float)num37, val9);
			#if WINDOWS
			val9.FormatFlags = (StringFormatFlags)2;
			#endif
			if (zhyrFiltr == "так")
			{
				double num96 = 0.0;
				double num97 = 100.0;
				double num98 = 20.0;
				double num99 = 20.0;
				double num100 = 20.0;
				double num101 = 60.0;
				double num102 = 70.0;
				double num103 = 10.0;
				double num104 = 20.0;
				double num105 = 40.0;
				double num106 = 60.0;
				double num107 = 70.0;
				double num108 = 10.0;
				double num109 = 45.0;
				double num110 = 35.0;
				double num111 = 20.0;
				double num112 = 110.0;
				double num113 = 25.0;
				double num114 = 55.0;
				double num115 = 15.0;
				double num116 = num97 * num18;
				double num117 = num98 * num18;
				double num118 = num100 * num18;
				double num119 = num99 * num18;
				double num120 = num104 * num18;
				double num121 = num105 * num18;
				double num122 = num106 * num18;
				double num123 = num107 * num18;
				double num124 = num108 * num18;
				double num125 = num101 * num18;
				double num126 = num102 * num18;
				double num127 = num103 * num18;
				double num128 = num109 * num18;
				double num129 = num110 * num18;
				double num130 = num111 * num18;
				double num131 = num112 * num18;
				double num132 = num113 * num18;
				double num133 = num114 * num18;
				double num134 = num115 * num18;
				if (B >= 600 && B <= 790)
				{
					num34 = num3 - (int)((num30 - num27) / 2.0);
					num35 = (double)num6 + num28 * Math.Sin(num17) + num29;
					num36 = num34 + num116;
					num37 = num35;
					val2.DrawLine(val5, (float)num34, (float)num35, (float)num36, (float)num37);
					num34 = num36;
					num35 = num37;
					num36 = num34;
					num37 = num35 - num117;
					val2.DrawLine(val5, (float)num34, (float)num35, (float)num36, (float)num37);
					num34 = (double)num3 + num27;
					num35 = (double)num6 + num28 * Math.Sin(num17);
					num36 = num34 - num120;
					num37 = num35;
					val2.DrawLine(val5, (float)num34, (float)num35, (float)num36, (float)num37);
					num89 = Math.Atan(2.0 * (num29 - num31) / (num30 - num27));
					num34 = (double)num3 + num27;
					num35 = (double)num6 + num28 * Math.Sin(num17);
					num36 = num34 + num121 * Math.Cos(num89);
					num37 = num35 + num121 * Math.Sin(num89);
					val2.DrawLine(val5, (float)num34, (float)num35, (float)num36, (float)num37);
					num34 = num36;
					num35 = num37;
					num36 = num34;
					num37 = num35 + num122;
					val2.DrawLine(val5, (float)num34, (float)num35, (float)num36, (float)num37);
					num34 = (double)(num3 - (int)((num30 - num27) / 2.0)) + num116;
					num35 = (double)num6 + num28 * Math.Sin(num17) + num29 - num117;
					num36 = (double)num3 + num27 + num121 * Math.Cos(num89);
					num37 = (double)num6 + num28 * Math.Sin(num17) + num121 * Math.Sin(num89) + num122;
					num43 = num37 + Math.Sqrt(Math.Pow(num124, 2.0) + Math.Pow(num36 - num42, 2.0));
					double num135 = 0.01;
					double num136 = num36 - num124;
					double num137 = num36;
					while (num137 - num136 > num135)
					{
						double num138 = (num136 + num137) / 2.0;
						double num139 = (num36 - num136) * (num136 - num34) - (num43 - num37) * (num43 - num35);
						double num140 = (num36 - num138) * (num138 - num34) - (num43 - num37) * (num43 - num35);
						if (num139 * num140 < 0.0)
						{
							num137 = num138;
						}
						else
						{
							num136 = num138;
						}
					}
					num42 = (num136 + num137) / 2.0;
					num43 = num37 + Math.Sqrt(Math.Pow(num124, 2.0) + Math.Pow(num36 - num42, 2.0));
					num96 = ((num34 == num42) ? 0.0 : Math.Atan((num43 - num35) / (num34 - num42)));
					num34 = (double)(num3 - (int)((num30 - num27) / 2.0)) + num116;
					num35 = (double)num6 + num28 * Math.Sin(num17) + num29 - num117;
					num36 = num34 - num119 * Math.Sin(num96);
					num37 = num35 - num119 * Math.Cos(num96);
					val2.DrawLine(val5, (float)num34, (float)num35, (float)num36, (float)num37);
					num34 = (double)num3 + num27 + num121 * Math.Cos(num89);
					num35 = (double)num6 + num28 * Math.Sin(num17) + num121 * Math.Sin(num89) + num122;
					num36 = num34 - num123 * Math.Cos(num96);
					num37 = num35 + num123 * Math.Sin(num96);
					val2.DrawLine(val5, (float)num34, (float)num35, (float)num36, (float)num37);
					num34 = num36;
					num35 = num37;
					num36 = num34 - num124 * Math.Sin(num96);
					num37 = num35 - num124 * Math.Cos(num96);
					val2.DrawLine(val5, (float)num34, (float)num35, (float)num36, (float)num37);
					double num141 = 5.0;
					num34 = (double)(num3 - (int)((num30 - num27) / 2.0)) + num116 + num141 * Math.Cos(num96);
					num35 = (double)num6 + num28 * Math.Sin(num17) + num29 - num117 - num141 * Math.Sin(num96);
					num36 = num34 - num128 * Math.Sin(num96);
					num37 = num35 - num128 * Math.Cos(num96);
					val2.DrawLine(val5, (float)num34, (float)num35, (float)num36, (float)num37);
					num34 = (double)(num3 - (int)((num30 - num27) / 2.0)) + num116 + num141 * Math.Cos(num96);
					num35 = (double)num6 + num28 * Math.Sin(num17) + num29 - num117 - num141 * Math.Sin(num96);
					num36 = num34 + num129 * Math.Cos(num96);
					num37 = num35 - num129 * Math.Sin(num96);
					val2.DrawLine(val5, (float)num34, (float)num35, (float)num36, (float)num37);
					num34 = (double)(num3 - (int)((num30 - num27) / 2.0)) + num116 + num141 * Math.Cos(num96) - num128 * Math.Sin(num96);
					num35 = (double)num6 + num28 * Math.Sin(num17) + num29 - num117 - num141 * Math.Sin(num96) - num128 * Math.Cos(num96);
					num36 = num34 + num130 * Math.Cos(num96);
					num37 = num35 - num130 * Math.Sin(num96);
					val2.DrawLine(val5, (float)num34, (float)num35, (float)num36, (float)num37);
					double num142 = 40.0;
					double num143 = (double)(B + b) / 2.0 - num97 + num105 * Math.Cos(num89) - num108 * Math.Sin(num96);
					double num144 = (double)H - num98 - num106 - num105 * Math.Sin(num89) + num108 * Math.Cos(num96);
					l = (int)Math.Round(Math.Sqrt(num143 * num143 + num144 * num144) - num142);
					double num145 = (double)l * num18 - num141;
					double num146 = 6.0;
					double num147 = num109 * num18 - 2.0 * num146;
					num34 = (double)(num3 - (int)((num30 - num27) / 2.0)) + num116 + num141 * Math.Cos(num96) - num146 * Math.Sin(num96) + num141 * Math.Cos(num96);
					num35 = (double)num6 + num28 * Math.Sin(num17) + num29 - num117 - num141 * Math.Sin(num96) - num146 * Math.Cos(num96) - num141 * Math.Sin(num96);
					num36 = num34 - num147 * Math.Sin(num96);
					num37 = num35 - num147 * Math.Cos(num96);
					val2.DrawLine(val4, (float)num34, (float)num35, (float)num36, (float)num37);
					num34 = (double)(num3 - (int)((num30 - num27) / 2.0)) + num116 + num141 * Math.Cos(num96) - num146 * Math.Sin(num96) + num141 * Math.Cos(num96);
					num35 = (double)num6 + num28 * Math.Sin(num17) + num29 - num117 - num141 * Math.Sin(num96) - num146 * Math.Cos(num96) - num141 * Math.Sin(num96);
					num36 = num34 + num145 * Math.Cos(num96);
					num37 = num35 - num145 * Math.Sin(num96);
					val2.DrawLine(val4, (float)num34, (float)num35, (float)num36, (float)num37);
					num34 = (double)(num3 - (int)((num30 - num27) / 2.0)) + num116 + num141 * Math.Cos(num96) - num146 * Math.Sin(num96) + num141 * Math.Cos(num96) - num147 * Math.Sin(num96);
					num35 = (double)num6 + num28 * Math.Sin(num17) + num29 - num117 - num141 * Math.Sin(num96) - num146 * Math.Cos(num96) - num141 * Math.Sin(num96) - num147 * Math.Cos(num96);
					num36 = num34 + num145 * Math.Cos(num96);
					num37 = num35 - num145 * Math.Sin(num96);
					val2.DrawLine(val4, (float)num34, (float)num35, (float)num36, (float)num37);
					num34 = (double)(num3 - (int)((num30 - num27) / 2.0)) + num116 + num141 * Math.Cos(num96) - num146 * Math.Sin(num96) + num141 * Math.Cos(num96) + num145 * Math.Cos(num96);
					num35 = (double)num6 + num28 * Math.Sin(num17) + num29 - num117 - num141 * Math.Sin(num96) - num146 * Math.Cos(num96) - num141 * Math.Sin(num96) - num145 * Math.Sin(num96);
					num36 = (double)(num3 - (int)((num30 - num27) / 2.0)) + num116 + num141 * Math.Cos(num96) - num146 * Math.Sin(num96) + num141 * Math.Cos(num96) - num147 * Math.Sin(num96) + num145 * Math.Cos(num96);
					num37 = (double)num6 + num28 * Math.Sin(num17) + num29 - num117 - num141 * Math.Sin(num96) - num146 * Math.Cos(num96) - num141 * Math.Sin(num96) - num147 * Math.Cos(num96) - num145 * Math.Sin(num96);
					val2.DrawLine(val4, (float)num34, (float)num35, (float)num36, (float)num37);
					double num148 = 1.5;
					double num149 = 0.0;
					double num150 = 0.0;
					double num151 = 0.0;
					double num152 = 0.0;
					num116 = num97 * num148;
					num117 = num98 * num148;
					num119 = num99 * num148;
					num120 = num104 * num148;
					num121 = num105 * num148;
					num122 = num106 * num148;
					num123 = num107 * num148;
					num124 = num108 * num148;
					num128 = num109 * num148;
					num129 = num110 * num148;
					num130 = num111 * num148;
					num29 = (double)H * num148;
					num31 = (double)h * num148;
					num30 = (double)B * num148;
					num27 = (double)b * num148;
					num151 = (double)(num - num4) - num121 * Math.Cos(num89);
					num152 = (double)num26 + num22 * num18 + 40.0;
					num149 = (double)(num - num4) - num116;
					num150 = num152 + num121 * Math.Sin(num89) + num122 + num123 + num117 + num119;
					num34 = num149;
					num35 = num150;
					num36 = num34 + num116;
					num37 = num35;
					val2.DrawLine(val5, (float)num34, (float)num35, (float)num36, (float)num37);
					num34 = num149;
					num35 = num150;
					num36 = num34;
					num37 = num35 + (double)num15;
					num90 = num36;
					num91 = num37;
					val2.DrawLine(val3, (float)num34, (float)num35, (float)num36, (float)num37);
					num34 += num116;
					num36 = num34;
					num92 = num36;
					num93 = num37;
					val2.DrawLine(val3, (float)num34, (float)num35, (float)num36, (float)num37);
					num34 = num90;
					num35 = num91 - 5.0;
					num36 = num92;
					num37 = num93 - 5.0;
					DrawRows(num34, num35, num36, num37, num18, val2, val3);
					num50 = (num90 + num92) / 2.0;
					num51 = num91 + (double)num21;
					#if WINDOWS
					val9.FormatFlags = (StringFormatFlags)1;
					#endif
					val2.DrawString(num97.ToString(), val7, (Brush)(object)val8, (float)num50, (float)num51, val9);
					num34 = num149 + num116;
					num35 = num150;
					num36 = num34;
					num37 = num35 - num117;
					val2.DrawLine(val5, (float)num34, (float)num35, (float)num36, (float)num37);
					num36 = num34 - (double)num15;
					num37 = num35;
					val2.DrawLine(val3, (float)num34, (float)num35, (float)num36, (float)num37);
					num35 = num150 - num117;
					num36 = num34 - (double)num15;
					num37 = num35;
					val2.DrawLine(val3, (float)num34, (float)num35, (float)num36, (float)num37);
					num34 = num36 + 5.0;
					num35 = num150;
					num36 = num34;
					num37 = num35 - num117;
					DrawRows(num36, num37, num34, num35, num18, val2, val3);
					num50 = num34 - (double)num21 - 3.0;
					num51 = (num35 + num37) / 2.0;
					#if WINDOWS
					val9.FormatFlags = (StringFormatFlags)1;
					#endif
					val2.DrawString(num98.ToString(), val7, (Brush)(object)val8, (float)num50, (float)num51, val9);
					num34 = num151;
					num35 = num152;
					num36 = num34 - num120;
					num37 = num35;
					val2.DrawLine(val5, (float)num34, (float)num35, (float)num36, (float)num37);
					num36 = num34;
					num37 = num35 - (double)num15;
					val2.DrawLine(val3, (float)num34, (float)num35, (float)num36, (float)num37);
					num34 = num36 - num120;
					num36 = num34;
					val2.DrawLine(val3, (float)num34, (float)num35, (float)num36, (float)num37);
					num34 = num151;
					num35 = num152 - (double)num15 + 5.0;
					num36 = num34 - num120;
					num37 = num35;
					DrawRows(num36, num37, num34, num35, num18, val2, val3);
					num50 = (num34 + num36) / 2.0;
					num51 = num35 - (double)num21 - 3.0;
					#if WINDOWS
					val9.FormatFlags = (StringFormatFlags)1;
					#endif
					val2.DrawString(num104.ToString(), val7, (Brush)(object)val8, (float)num50, (float)num51, val9);
					num34 = num151;
					num35 = num152;
					num36 = num34 + num121 * Math.Cos(num89);
					num37 = num35 + num121 * Math.Sin(num89);
					val2.DrawLine(val5, (float)num34, (float)num35, (float)num36, (float)num37);
					num36 = num34 + (double)num15 * Math.Sin(num89);
					num37 = num35 - (double)num15 * Math.Cos(num89);
					num90 = num36;
					num91 = num37;
					val2.DrawLine(val3, (float)num34, (float)num35, (float)num36, (float)num37);
					num34 += num121 * Math.Cos(num89);
					num35 += num121 * Math.Sin(num89);
					num36 = num34 + (double)num15 * Math.Sin(num89);
					num37 = num35 - (double)num15 * Math.Cos(num89);
					val2.DrawLine(val3, (float)num34, (float)num35, (float)num36, (float)num37);
					num34 = num90 - 5.0 * Math.Sin(num89);
					num35 = num91 + 5.0 * Math.Cos(num89);
					num36 -= 5.0 * Math.Sin(num89);
					num37 += 5.0 * Math.Cos(num89);
					DrawRows(num34, num35, num36, num37, num18, val2, val3);
					num50 = (num34 + num36) / 2.0 + (double)num21;
					num51 = (num35 + num37) / 2.0 - (double)(num21 / 2);
					#if WINDOWS
					val9.FormatFlags = (StringFormatFlags)1;
					#endif
					val2.DrawString(num105.ToString(), val7, (Brush)(object)val8, (float)num50, (float)num51, val9);
					num34 = num151 + num121 * Math.Cos(num89);
					num35 = num152 + num121 * Math.Sin(num89);
					num36 = num34;
					num37 = num35 + num122;
					double num153 = num36;
					double num154 = num37;
					val2.DrawLine(val5, (float)num34, (float)num35, (float)num36, (float)num37);
					num36 = num34 + (double)num15;
					num37 = num35;
					num90 = num36;
					num91 = num37;
					val2.DrawLine(val3, (float)num34, (float)num35, (float)num36, (float)num37);
					num34 = num151 + num121 * Math.Cos(num89);
					num35 = num152 + num121 * Math.Sin(num89) + num122;
					num36 = num34 + (double)num15;
					num37 = num35;
					val2.DrawLine(val3, (float)num34, (float)num35, (float)num36, (float)num37);
					num34 = num90 - 5.0;
					num35 = num91;
					num36 -= 5.0;
					DrawRows(num34, num35, num36, num37, num18, val2, val3);
					num50 = num34 + (double)num21;
					num51 = (num35 + num37) / 2.0;
					#if WINDOWS
					val9.FormatFlags = (StringFormatFlags)1;
					#endif
					val2.DrawString(num106.ToString(), val7, (Brush)(object)val8, (float)num50, (float)num51, val9);
					num34 = num149 + num116;
					num35 = num150 - num117;
					num36 = num34 - num119 * Math.Sin(num96);
					num37 = num35 - num119 * Math.Cos(num96);
					val2.DrawLine(val5, (float)num34, (float)num35, (float)num36, (float)num37);
					num36 = num34 + (double)num15 * Math.Cos(num96);
					num37 = num35 - (double)num15 * Math.Sin(num96);
					num90 = num36;
					num91 = num37;
					val2.DrawLine(val3, (float)num34, (float)num35, (float)num36, (float)num37);
					num34 -= num119 * Math.Sin(num96);
					num35 -= num119 * Math.Cos(num96);
					num36 = num34 + (double)num15 * Math.Cos(num96);
					num37 = num35 - (double)num15 * Math.Sin(num96);
					val2.DrawLine(val3, (float)num34, (float)num35, (float)num36, (float)num37);
					num34 = num90 - 5.0 * Math.Cos(num96);
					num35 = num91 + 5.0 * Math.Sin(num96);
					num36 -= 5.0 * Math.Cos(num96);
					num37 += 5.0 * Math.Sin(num96);
					DrawRows(num36, num37, num34, num35, num18, val2, val3);
					num50 = (num34 + num36) / 2.0 + (double)num21;
					num51 = (num35 + num37) / 2.0 - (double)(num21 / 2);
					#if WINDOWS
					val9.FormatFlags = (StringFormatFlags)1;
					#endif
					val2.DrawString(num99.ToString(), val7, (Brush)(object)val8, (float)num50, (float)num51, val9);
					num34 = num149 + num116;
					num35 = num150 - num117;
					num36 = num34 + num119 * Math.Sin(num96);
					num37 = num35 + num119 * Math.Cos(num96);
					val2.DrawLine(val3, (float)num34, (float)num35, (float)num36, (float)num37);
					double num155 = 3.0 * num119 * Math.Sin(num96) / 4.0;
					double num156 = 3.0 * num119 * Math.Cos(num96) / 4.0;
					num34 = num149 + num116;
					num35 = num150 - num117 + num156;
					num42 = num34 + num155;
					num43 = num35;
					num36 = (num34 + num42) / 2.0 + 3.0;
					num37 = (num35 + num43) / 2.0 + 5.0 + 3.0;
					val2.DrawBezier(val3, (float)num34, (float)num35, (float)num36, (float)num37, (float)num42, (float)num43, (float)num42, (float)num43);
					string text2 = Math.Round(num96 * 180.0 / Math.PI) + "°";
					val2.DrawString(text2, val7, (Brush)(object)val8, (float)(num36 + 3.0), (float)(num37 + (double)num21), val9);
					num34 = num153;
					num35 = num154;
					num36 = num34 - num123 * Math.Cos(num96);
					num37 = num35 + num123 * Math.Sin(num96);
					val2.DrawLine(val5, (float)num34, (float)num35, (float)num36, (float)num37);
					num36 = num34 - (double)num15 * Math.Sin(num96);
					num37 = num35 - (double)num15 * Math.Cos(num96);
					num90 = num36;
					num91 = num37;
					val2.DrawLine(val3, (float)num34, (float)num35, (float)num36, (float)num37);
					num34 = num153 - num123 * Math.Cos(num96);
					num35 = num154 + num123 * Math.Sin(num96);
					num36 = num34 - (double)num15 * Math.Sin(num96);
					num37 = num35 - (double)num15 * Math.Cos(num96);
					val2.DrawLine(val3, (float)num34, (float)num35, (float)num36, (float)num37);
					num34 = num90 + 5.0 * Math.Sin(num96);
					num35 = num91 + 5.0 * Math.Cos(num96);
					num36 += 5.0 * Math.Sin(num96);
					num37 += 5.0 * Math.Cos(num96);
					DrawRows(num36, num37, num34, num35, num18, val2, val3);
					num50 = (num34 + num36) / 2.0 - (double)num21;
					num51 = (num35 + num37) / 2.0 - (double)(num21 / 2);
					#if WINDOWS
					val9.FormatFlags = (StringFormatFlags)1;
					#endif
					val2.DrawString(num107.ToString(), val7, (Brush)(object)val8, (float)num50, (float)num51, val9);
					num34 = num153;
					num35 = num154;
					num36 = num34;
					num37 = num35 + num123 * Math.Sin(num96);
					val2.DrawLine(val3, (float)num34, (float)num35, (float)num36, (float)num37);
					num155 = 3.0 * num123 * Math.Cos(num96) / 8.0;
					num156 = 3.0 * num123 * Math.Sin(num96) / 8.0;
					num34 = num153;
					num35 = num154 + num156;
					num42 = num34 - num155;
					num43 = num35;
					num36 = (num34 + num42) / 2.0;
					num37 = (num35 + num43) / 2.0 + 5.0;
					val2.DrawBezier(val3, (float)num34, (float)num35, (float)num36, (float)num37, (float)num42, (float)num43, (float)num42, (float)num43);
					text2 = Math.Round((Math.PI / 2.0 - num96) * 180.0 / Math.PI) + "°";
					val2.DrawString(text2, val7, (Brush)(object)val8, (float)(num36 + 3.0), (float)(num37 + (double)num21), val9);
					num34 = num153 - num123 * Math.Cos(num96);
					num35 = num154 + num123 * Math.Sin(num96);
					num36 = num34 - num124 * Math.Sin(num96);
					num37 = num35 - num124 * Math.Cos(num96);
					val2.DrawLine(val5, (float)num34, (float)num35, (float)num36, (float)num37);
					num36 = num34 - (double)num15 * Math.Cos(num96);
					num37 = num35 + (double)num15 * Math.Sin(num96);
					num90 = num36;
					num91 = num37;
					val2.DrawLine(val3, (float)num34, (float)num35, (float)num36, (float)num37);
					num34 = num153 - num123 * Math.Cos(num96) - num124 * Math.Sin(num96);
					num35 = num154 + num123 * Math.Sin(num96) - num124 * Math.Cos(num96);
					num36 = num34 - (double)num15 * Math.Cos(num96);
					num37 = num35 + (double)num15 * Math.Sin(num96);
					val2.DrawLine(val3, (float)num34, (float)num35, (float)num36, (float)num37);
					num34 = num90 + 5.0 * Math.Cos(num96);
					num35 = num91 - 5.0 * Math.Sin(num96);
					num36 += 5.0 * Math.Cos(num96);
					num37 -= 5.0 * Math.Sin(num96);
					DrawRows(num34, num35, num36, num37, num18, val2, val3);
					num50 = (num34 + num36) / 2.0 - (double)num21;
					num51 = (num35 + num37) / 2.0 + (double)(num21 / 2);
					#if WINDOWS
					val9.FormatFlags = (StringFormatFlags)1;
					#endif
					val2.DrawString(num108.ToString(), val7, (Brush)(object)val8, (float)num50, (float)num51, val9);
				}
				else
				{
					if (G == b)
					{
						typeUpperStrip = 1;
					}
					else if (b - G >= 50)
					{
						typeUpperStrip = 2;
					}
					num34 = (double)(num3 - (int)((num30 - num27) / 2.0)) + num30 / 2.0 - num131 / 2.0;
					num35 = (double)num6 + num28 * Math.Sin(num17) + num29;
					num36 = num34 + num131;
					num37 = num35;
					val2.DrawLine(val5, (float)num34, (float)num35, (float)num36, (float)num37);
					num34 = (double)(num3 - (int)((num30 - num27) / 2.0)) + num30 / 2.0 - num131 / 2.0;
					num35 = (double)num6 + num28 * Math.Sin(num17) + num29;
					num36 = num34;
					num37 = num35 - num132;
					val2.DrawLine(val5, (float)num34, (float)num35, (float)num36, (float)num37);
					num34 = (double)(num3 - (int)((num30 - num27) / 2.0)) + num30 / 2.0 + num131 / 2.0;
					num35 = (double)num6 + num28 * Math.Sin(num17) + num29;
					num36 = num34;
					num37 = num35 - num132;
					val2.DrawLine(val5, (float)num34, (float)num35, (float)num36, (float)num37);
					double num157 = 4.0;
					num34 = (double)(num3 - (int)((num30 - num27) / 2.0)) + num30 / 2.0;
					num35 = (double)num6 + num28 * Math.Sin(num17) + num29 - num157;
					num36 = num34;
					num37 = num35 - (num133 - num157);
					val2.DrawLine(val5, (float)num34, (float)num35, (float)num36, (float)num37);
					num36 = num34 + num134;
					num37 = num35;
					val2.DrawLine(val5, (float)num34, (float)num35, (float)num36, (float)num37);
					if (typeUpperStrip == 1)
					{
						num34 = num3;
						num35 = (double)num6 + num28 * Math.Sin(num17);
						num36 = num34 + num120;
						num37 = num35;
						val2.DrawLine(val5, (float)num34, (float)num35, (float)num36, (float)num37);
						num34 = (double)num3 + num27;
						num35 = (double)num6 + num28 * Math.Sin(num17);
						num36 = num34 - num120;
						num37 = num35;
						val2.DrawLine(val5, (float)num34, (float)num35, (float)num36, (float)num37);
						num89 = Math.Atan(2.0 * (num29 - num31) / (num30 - num27));
						num34 = num3;
						num35 = (double)num6 + num28 * Math.Sin(num17);
						num36 = num34 - num121 * Math.Cos(num89);
						num37 = num35 + num121 * Math.Sin(num89);
						val2.DrawLine(val5, (float)num34, (float)num35, (float)num36, (float)num37);
						num34 = (double)num3 + num27;
						num35 = (double)num6 + num28 * Math.Sin(num17);
						num36 = num34 + num121 * Math.Cos(num89);
						num37 = num35 + num121 * Math.Sin(num89);
						val2.DrawLine(val5, (float)num34, (float)num35, (float)num36, (float)num37);
						num34 = (double)num3 - num121 * Math.Cos(num89);
						num35 = (double)num6 + num28 * Math.Sin(num17) + num121 * Math.Sin(num89);
						num36 = num34;
						num37 = num35 + num122;
						val2.DrawLine(val5, (float)num34, (float)num35, (float)num36, (float)num37);
						num34 += num27 + 2.0 * num121 * Math.Cos(num89);
						num36 = num34;
						val2.DrawLine(val5, (float)num34, (float)num35, (float)num36, (float)num37);
						num34 = (double)(num3 - (int)((num30 - num27) / 2.0)) + num30 / 2.0;
						num35 = (double)num6 + num28 * Math.Sin(num17) + num29;
						num36 = (double)num3 + num27 + num121 * Math.Cos(num89);
						num37 = (double)num6 + num28 * Math.Sin(num17) + num121 * Math.Sin(num89) + num122;
						double num158 = 40.0;
						double num159 = num158 * num18;
						double num160 = 1E-05;
						double num161 = Math.Atan((num35 - num37) / (num36 - num34));
						double num162 = Math.Atan((num35 - num37) / (num36 - 2.0 * num124 - (num34 + num159)));
						while (num162 - num161 > num160)
						{
							num96 = (num161 + num162) / 2.0;
							double num163 = num37 - num35 + num124 * Math.Cos(num161) - Math.Tan(num161) * (num36 - num34 - (num159 + num124) * Math.Sin(num161));
							double num164 = num37 - num35 + num124 * Math.Cos(num96) - Math.Tan(num96) * (num36 - num34 - (num159 + num124) * Math.Sin(num96));
							if (num163 * num164 < 0.0)
							{
								num162 = num96;
							}
							else
							{
								num161 = num96;
							}
						}
						num34 = (double)num3 + num27 + num121 * Math.Cos(num89);
						num35 = (double)num6 + num28 * Math.Sin(num17) + num121 * Math.Sin(num89) + num122;
						num36 = num34 - num123 * Math.Cos(num96);
						num37 = num35 + num123 * Math.Sin(num96);
						val2.DrawLine(val5, (float)num34, (float)num35, (float)num36, (float)num37);
						num34 = num36;
						num35 = num37;
						num36 = num34 - num124 * Math.Sin(num96);
						num37 = num35 - num124 * Math.Cos(num96);
						val2.DrawLine(val5, (float)num34, (float)num35, (float)num36, (float)num37);
						num34 = (double)num3 - num121 * Math.Cos(num89);
						num35 = (double)num6 + num28 * Math.Sin(num17) + num121 * Math.Sin(num89) + num122;
						num36 = num34 + num123 * Math.Cos(num96);
						num37 = num35 + num123 * Math.Sin(num96);
						val2.DrawLine(val5, (float)num34, (float)num35, (float)num36, (float)num37);
						num34 = num36;
						num35 = num37;
						num36 = num34 + num124 * Math.Sin(num96);
						num37 = num35 - num124 * Math.Cos(num96);
						val2.DrawLine(val5, (float)num34, (float)num35, (float)num36, (float)num37);
						double num165 = 40.0;
						double num166 = (double)b + num105 * Math.Cos(num89) - num108 * Math.Sin(num96) - ((double)(-((B - b) / 2) + B / 2) + num158 * Math.Sin(num96));
						double num167 = (double)H - (num105 * Math.Sin(num89) + num106 - num108 * Math.Cos(num96));
						l = (int)Math.Round(Math.Sqrt(num166 * num166 + num167 * num167) - num165);
						double num168 = (double)l * num18 - num157;
						num34 = (double)(num3 - (int)((num30 - num27) / 2.0)) + num30 / 2.0 + num159 * Math.Sin(num96) + num157 * Math.Cos(num96);
						num35 = (double)num6 + num28 * Math.Sin(num17) + num29 - num157 * Math.Sin(num96);
						num36 = num34 - num159 * Math.Sin(num96);
						num37 = num35 - num159 * Math.Cos(num96);
						val2.DrawLine(val5, (float)num34, (float)num35, (float)num36, (float)num37);
						num34 = (double)(num3 - (int)((num30 - num27) / 2.0)) + num30 / 2.0 + num159 * Math.Sin(num96) + num157 * Math.Cos(num96);
						num35 = (double)num6 + num28 * Math.Sin(num17) + num29 - num157 * Math.Sin(num96);
						num36 = num34 + num168 * Math.Cos(num96);
						num37 = num35 - num168 * Math.Sin(num96);
						num90 = num36;
						num91 = num37;
						val2.DrawLine(val5, (float)num34, (float)num35, (float)num36, (float)num37);
						num34 = (double)(num3 - (int)((num30 - num27) / 2.0)) + num30 / 2.0 + num157 * Math.Cos(num96);
						num35 = (double)num6 + num28 * Math.Sin(num17) + num29 - num157 * Math.Sin(num96) - num159 * Math.Cos(num96);
						num36 = num34 + num168 * Math.Cos(num96);
						num37 = num35 - num168 * Math.Sin(num96);
						num92 = num36;
						num93 = num37;
						val2.DrawLine(val5, (float)num34, (float)num35, (float)num36, (float)num37);
						val2.DrawLine(val5, (float)num90, (float)num91, (float)num92, (float)num93);
						num34 = (double)(num3 - (int)((num30 - num27) / 2.0)) + num30 / 2.0 - num159 * Math.Sin(num96) - num157 * Math.Cos(num96);
						num35 = (double)num6 + num28 * Math.Sin(num17) + num29 - num157 * Math.Sin(num96);
						num36 = num34 + num159 * Math.Sin(num96);
						num37 = num35 - num159 * Math.Cos(num96);
						val2.DrawLine(val5, (float)num34, (float)num35, (float)num36, (float)num37);
						num34 = (double)(num3 - (int)((num30 - num27) / 2.0)) + num30 / 2.0 - num159 * Math.Sin(num96) - num157 * Math.Cos(num96);
						num35 = (double)num6 + num28 * Math.Sin(num17) + num29 - num157 * Math.Sin(num96);
						num36 = num34 - num168 * Math.Cos(num96);
						num37 = num35 - num168 * Math.Sin(num96);
						num90 = num36;
						num91 = num37;
						val2.DrawLine(val5, (float)num34, (float)num35, (float)num36, (float)num37);
						num34 = (double)(num3 - (int)((num30 - num27) / 2.0)) + num30 / 2.0 - num157 * Math.Cos(num96);
						num35 = (double)num6 + num28 * Math.Sin(num17) + num29 - num157 * Math.Sin(num96) - num159 * Math.Cos(num96);
						num36 = num34 - num168 * Math.Cos(num96);
						num37 = num35 - num168 * Math.Sin(num96);
						num92 = num36;
						num93 = num37;
						val2.DrawLine(val5, (float)num34, (float)num35, (float)num36, (float)num37);
						val2.DrawLine(val5, (float)num90, (float)num91, (float)num92, (float)num93);
						double num169 = 1.5;
						double num170 = 0.0;
						double num171 = 0.0;
						double num172 = 0.0;
						double num173 = 0.0;
						num116 = num97 * num169;
						num117 = num98 * num169;
						num119 = num99 * num169;
						num120 = num104 * num169;
						num121 = num105 * num169;
						num122 = num106 * num169;
						num123 = num107 * num169;
						num124 = num108 * num169;
						num128 = num109 * num169;
						num129 = num110 * num169;
						num130 = num111 * num169;
						num131 = num112 * num169;
						num132 = num113 * num169;
						num133 = num114 * num169;
						num134 = num115 * num169;
						num29 = (double)H * num169;
						num31 = (double)h * num169;
						num30 = (double)B * num169;
						num27 = (double)b * num169;
						num172 = (double)(num - num4) - num121 * Math.Cos(num89);
						num173 = (double)num26 + num22 * num18 + 40.0;
						num170 = (double)(num - num4) - num131;
						num171 = num173 + num121 * Math.Sin(num89) + num122 + num123 + num133;
						num34 = num170;
						num35 = num171;
						num36 = num34 + num131;
						num37 = num35;
						val2.DrawLine(val5, (float)num34, (float)num35, (float)num36, (float)num37);
						num34 = num170;
						num35 = num171;
						num36 = num34;
						num37 = num35 + (double)num15;
						num90 = num36;
						num91 = num37;
						val2.DrawLine(val3, (float)num34, (float)num35, (float)num36, (float)num37);
						num34 += num131;
						num36 = num34;
						num92 = num36;
						num93 = num37;
						val2.DrawLine(val3, (float)num34, (float)num35, (float)num36, (float)num37);
						num34 = num90;
						num35 = num91 - 5.0;
						num36 = num92;
						num37 = num93 - 5.0;
						DrawRows(num34, num35, num36, num37, num18, val2, val3);
						num50 = (num90 + num92) / 2.0;
						num51 = num91 + (double)num21;
						#if WINDOWS
						val9.FormatFlags = (StringFormatFlags)1;
						#endif
						val2.DrawString(num112.ToString(), val7, (Brush)(object)val8, (float)num50, (float)num51, val9);
						num34 = num170 + num131;
						num35 = num171;
						num36 = num34;
						num37 = num35 - num132;
						val2.DrawLine(val5, (float)num34, (float)num35, (float)num36, (float)num37);
						num34 = num170;
						num35 = num171;
						num36 = num34;
						num37 = num35 - num132;
						val2.DrawLine(val5, (float)num34, (float)num35, (float)num36, (float)num37);
						num36 = num34 - (double)num15;
						num37 = num35;
						val2.DrawLine(val3, (float)num34, (float)num35, (float)num36, (float)num37);
						num35 = num171 - num132;
						num36 = num34 - (double)num15;
						num37 = num35;
						val2.DrawLine(val3, (float)num34, (float)num35, (float)num36, (float)num37);
						num34 = num36 + 5.0;
						num35 = num171;
						num36 = num34;
						num37 = num35 - num132;
						DrawRows(num36, num37, num34, num35, num18, val2, val3);
						num50 = num34 - (double)num21 - 3.0;
						num51 = (num35 + num37) / 2.0;
						#if WINDOWS
						val9.FormatFlags = (StringFormatFlags)1;
						#endif
						val2.DrawString(num113.ToString(), val7, (Brush)(object)val8, (float)num50, (float)num51, val9);
						num34 = num172 - num120 - 4.0 * num134;
						num35 = num173;
						num36 = num34;
						num37 = num35 + num133;
						val2.DrawLine(val5, (float)num34, (float)num35, (float)num36, (float)num37);
						num36 = num34 - (double)num15;
						num37 = num35;
						val2.DrawLine(val3, (float)num34, (float)num35, (float)num36, (float)num37);
						num34 = num172 - num120 - 4.0 * num134;
						num35 = num173 + num133;
						num36 = num34 - (double)num15;
						num37 = num35;
						val2.DrawLine(val3, (float)num34, (float)num35, (float)num36, (float)num37);
						num34 = num36 + 5.0;
						num35 = num173;
						num36 = num34;
						num37 = num35 + num133;
						DrawRows(num34, num35, num36, num37, num18, val2, val3);
						num50 = num34 - (double)num21 - 3.0;
						num51 = (num35 + num37) / 2.0;
						#if WINDOWS
						val9.FormatFlags = (StringFormatFlags)1;
						#endif
						val2.DrawString(num114.ToString(), val7, (Brush)(object)val8, (float)num50, (float)num51, val9);
						num34 = num172 - num120 - 4.0 * num134;
						num35 = num173 + num133;
						num36 = num34 + num134;
						num37 = num35;
						val2.DrawLine(val5, (float)num34, (float)num35, (float)num36, (float)num37);
						num36 = num34;
						num37 = num35 + (double)num15;
						val2.DrawLine(val3, (float)num34, (float)num35, (float)num36, (float)num37);
						num34 = num36 + num134;
						num36 = num34;
						val2.DrawLine(val3, (float)num34, (float)num35, (float)num36, (float)num37);
						num34 = num172 - num120 - 4.0 * num134;
						num35 = num173 + num133 + (double)num15 - 5.0;
						num36 = num34 + num134;
						num37 = num35;
						DrawRows(num36, num37, num34, num35, num18, val2, val3);
						num50 = (num34 + num36) / 2.0;
						num51 = num35 + (double)num21;
						#if WINDOWS
						val9.FormatFlags = (StringFormatFlags)1;
						#endif
						val2.DrawString(num115.ToString(), val7, (Brush)(object)val8, (float)num50, (float)num51, val9);
						num34 = num172;
						num35 = num173;
						num36 = num34 - num120;
						num37 = num35;
						val2.DrawLine(val5, (float)num34, (float)num35, (float)num36, (float)num37);
						num36 = num34;
						num37 = num35 - (double)num15;
						val2.DrawLine(val3, (float)num34, (float)num35, (float)num36, (float)num37);
						num34 = num36 - num120;
						num36 = num34;
						val2.DrawLine(val3, (float)num34, (float)num35, (float)num36, (float)num37);
						num34 = num172;
						num35 = num173 - (double)num15 + 5.0;
						num36 = num34 - num120;
						num37 = num35;
						DrawRows(num36, num37, num34, num35, num18, val2, val3);
						num50 = (num34 + num36) / 2.0;
						num51 = num35 - (double)num21 - 3.0;
						#if WINDOWS
						val9.FormatFlags = (StringFormatFlags)1;
						#endif
						val2.DrawString(num104.ToString(), val7, (Brush)(object)val8, (float)num50, (float)num51, val9);
						num34 = num172;
						num35 = num173;
						num36 = num34 + num121 * Math.Cos(num89);
						num37 = num35 + num121 * Math.Sin(num89);
						val2.DrawLine(val5, (float)num34, (float)num35, (float)num36, (float)num37);
						num36 = num34 + (double)num15 * Math.Sin(num89);
						num37 = num35 - (double)num15 * Math.Cos(num89);
						num90 = num36;
						num91 = num37;
						val2.DrawLine(val3, (float)num34, (float)num35, (float)num36, (float)num37);
						num34 += num121 * Math.Cos(num89);
						num35 += num121 * Math.Sin(num89);
						num36 = num34 + (double)num15 * Math.Sin(num89);
						num37 = num35 - (double)num15 * Math.Cos(num89);
						val2.DrawLine(val3, (float)num34, (float)num35, (float)num36, (float)num37);
						num34 = num90 - 5.0 * Math.Sin(num89);
						num35 = num91 + 5.0 * Math.Cos(num89);
						num36 -= 5.0 * Math.Sin(num89);
						num37 += 5.0 * Math.Cos(num89);
						DrawRows(num34, num35, num36, num37, num18, val2, val3);
						num50 = (num34 + num36) / 2.0 + (double)num21;
						num51 = (num35 + num37) / 2.0 - (double)(num21 / 2);
						#if WINDOWS
						val9.FormatFlags = (StringFormatFlags)1;
						#endif
						val2.DrawString(num105.ToString(), val7, (Brush)(object)val8, (float)num50, (float)num51, val9);
						num34 = num172 + num121 * Math.Cos(num89);
						num35 = num173 + num121 * Math.Sin(num89);
						num36 = num34;
						num37 = num35 + num122;
						double num153 = num36;
						double num154 = num37;
						val2.DrawLine(val5, (float)num34, (float)num35, (float)num36, (float)num37);
						num36 = num34 + (double)num15;
						num37 = num35;
						num90 = num36;
						num91 = num37;
						val2.DrawLine(val3, (float)num34, (float)num35, (float)num36, (float)num37);
						num34 = num172 + num121 * Math.Cos(num89);
						num35 = num173 + num121 * Math.Sin(num89) + num122;
						num36 = num34 + (double)num15;
						num37 = num35;
						val2.DrawLine(val3, (float)num34, (float)num35, (float)num36, (float)num37);
						num34 = num90 - 5.0;
						num35 = num91;
						num36 -= 5.0;
						DrawRows(num34, num35, num36, num37, num18, val2, val3);
						num50 = num34 + (double)num21;
						num51 = (num35 + num37) / 2.0;
						#if WINDOWS
						val9.FormatFlags = (StringFormatFlags)1;
						#endif
						val2.DrawString(num106.ToString(), val7, (Brush)(object)val8, (float)num50, (float)num51, val9);
						num34 = num153;
						num35 = num154;
						num36 = num34 - num123 * Math.Cos(num96);
						num37 = num35 + num123 * Math.Sin(num96);
						val2.DrawLine(val5, (float)num34, (float)num35, (float)num36, (float)num37);
						num36 = num34 - (double)num15 * Math.Sin(num96);
						num37 = num35 - (double)num15 * Math.Cos(num96);
						num90 = num36;
						num91 = num37;
						val2.DrawLine(val3, (float)num34, (float)num35, (float)num36, (float)num37);
						num34 = num153 - num123 * Math.Cos(num96);
						num35 = num154 + num123 * Math.Sin(num96);
						num36 = num34 - (double)num15 * Math.Sin(num96);
						num37 = num35 - (double)num15 * Math.Cos(num96);
						val2.DrawLine(val3, (float)num34, (float)num35, (float)num36, (float)num37);
						num34 = num90 + 5.0 * Math.Sin(num96);
						num35 = num91 + 5.0 * Math.Cos(num96);
						num36 += 5.0 * Math.Sin(num96);
						num37 += 5.0 * Math.Cos(num96);
						DrawRows(num36, num37, num34, num35, num18, val2, val3);
						num50 = (num34 + num36) / 2.0 - (double)num21;
						num51 = (num35 + num37) / 2.0 - (double)(num21 / 2);
						#if WINDOWS
						val9.FormatFlags = (StringFormatFlags)1;
						#endif
						val2.DrawString(num107.ToString(), val7, (Brush)(object)val8, (float)num50, (float)num51, val9);
						num34 = num153;
						num35 = num154;
						num36 = num34;
						num37 = num35 + num123 * Math.Sin(num96);
						val2.DrawLine(val3, (float)num34, (float)num35, (float)num36, (float)num37);
						double num174 = 3.0 * num123 * Math.Cos(num96) / 8.0;
						double num175 = 3.0 * num123 * Math.Sin(num96) / 8.0;
						num34 = num153;
						num35 = num154 + num175;
						num42 = num34 - num174;
						num43 = num35;
						num36 = (num34 + num42) / 2.0;
						num37 = (num35 + num43) / 2.0 + 5.0;
						val2.DrawBezier(val3, (float)num34, (float)num35, (float)num36, (float)num37, (float)num42, (float)num43, (float)num42, (float)num43);
						string text3 = Math.Round((Math.PI / 2.0 - num96) * 180.0 / Math.PI) + "°";
						val2.DrawString(text3, val7, (Brush)(object)val8, (float)(num36 + 3.0), (float)(num37 + (double)num21), val9);
						num34 = num153 - num123 * Math.Cos(num96);
						num35 = num154 + num123 * Math.Sin(num96);
						num36 = num34 - num124 * Math.Sin(num96);
						num37 = num35 - num124 * Math.Cos(num96);
						val2.DrawLine(val5, (float)num34, (float)num35, (float)num36, (float)num37);
						num36 = num34 - (double)num15 * Math.Cos(num96);
						num37 = num35 + (double)num15 * Math.Sin(num96);
						num90 = num36;
						num91 = num37;
						val2.DrawLine(val3, (float)num34, (float)num35, (float)num36, (float)num37);
						num34 = num153 - num123 * Math.Cos(num96) - num124 * Math.Sin(num96);
						num35 = num154 + num123 * Math.Sin(num96) - num124 * Math.Cos(num96);
						num36 = num34 - (double)num15 * Math.Cos(num96);
						num37 = num35 + (double)num15 * Math.Sin(num96);
						val2.DrawLine(val3, (float)num34, (float)num35, (float)num36, (float)num37);
						num34 = num90 + 5.0 * Math.Cos(num96);
						num35 = num91 - 5.0 * Math.Sin(num96);
						num36 += 5.0 * Math.Cos(num96);
						num37 -= 5.0 * Math.Sin(num96);
						DrawRows(num34, num35, num36, num37, num18, val2, val3);
						num50 = (num34 + num36) / 2.0 - (double)num21;
						num51 = (num35 + num37) / 2.0 + (double)(num21 / 2);
						#if WINDOWS
						val9.FormatFlags = (StringFormatFlags)1;
						#endif
						val2.DrawString(num108.ToString(), val7, (Brush)(object)val8, (float)num50, (float)num51, val9);
					}
					else
					{
						num34 = (double)num3 + (num27 - num32) / 2.0;
						num35 = (double)num6 + num28 * Math.Sin(num17);
						num36 = num34;
						num37 = num35 + (double)num14;
						val2.DrawLine(val3, (float)num34, (float)num35, (float)num36, (float)num37);
						num34 = (double)num3 + (num27 + num32) / 2.0;
						num35 = (double)num6 + num28 * Math.Sin(num17);
						num36 = num34;
						num37 = num35 + (double)num14;
						val2.DrawLine(val3, (float)num34, (float)num35, (float)num36, (float)num37);
						num34 = (double)num3 + (num27 - num32) / 2.0;
						num35 = (double)num6 + num28 * Math.Sin(num17) + (double)num14 - 5.0;
						num37 -= 5.0;
						DrawRows(num34, num35, num36, num37, num18, val2, val3);
						num50 = (num34 + num36) / 2.0;
						num51 = num37 + (double)num21 + 3.0;
						#if WINDOWS
						val9.FormatFlags = (StringFormatFlags)1;
						#endif
						val2.DrawString(G.ToString(), val7, (Brush)(object)val8, (float)num50, (float)num51, val9);
						num34 = (double)num3 + (num27 + num32) / 2.0;
						num35 = (double)num6 + num28 * Math.Sin(num17);
						num36 = num34 - num118;
						num37 = num35;
						val2.DrawLine(val5, (float)num34, (float)num35, (float)num36, (float)num37);
						num34 = (double)num3 + (num27 - num32) / 2.0;
						num35 = (double)num6 + num28 * Math.Sin(num17);
						num36 = num34 + num118;
						num37 = num35;
						val2.DrawLine(val5, (float)num34, (float)num35, (float)num36, (float)num37);
						num34 = (double)num3 + (num27 + num32) / 2.0;
						num35 = (double)num6 + num28 * Math.Sin(num17);
						num36 = num34;
						num37 = num35 + num125;
						val2.DrawLine(val5, (float)num34, (float)num35, (float)num36, (float)num37);
						num34 = (double)num3 + (num27 - num32) / 2.0;
						num35 = (double)num6 + num28 * Math.Sin(num17);
						num36 = num34;
						num37 = num35 + num125;
						val2.DrawLine(val5, (float)num34, (float)num35, (float)num36, (float)num37);
						num34 = (double)(num3 - (int)((num30 - num27) / 2.0)) + num30 / 2.0;
						num35 = (double)num6 + num28 * Math.Sin(num17) + num29;
						num36 = (double)num3 + (num27 + num32) / 2.0;
						num37 = (double)num6 + num28 * Math.Sin(num17) + num125;
						double num176 = 40.0;
						double num177 = num176 * num18;
						double num178 = 1E-05;
						double num179 = Math.Atan((num35 - num37) / (num36 - num34));
						double num180 = Math.Atan((num35 - num37 + num103) / (num36 - num103 - (num34 + num177)));
						while (num180 - num179 > num178)
						{
							num96 = (num179 + num180) / 2.0;
							double num181 = num36 - num34 - (num177 + num127) * Math.Sin(num179) - (num35 - num37 + num127 * Math.Cos(num179)) / Math.Tan(num179);
							double num182 = num36 - num34 - (num177 + num127) * Math.Sin(num96) - (num35 - num37 + num127 * Math.Cos(num96)) / Math.Tan(num96);
							if (num181 * num182 < 0.0)
							{
								num180 = num96;
							}
							else
							{
								num179 = num96;
							}
						}
						num34 = (double)num3 + (num27 + num32) / 2.0;
						num35 = (double)num6 + num28 * Math.Sin(num17) + num125;
						num36 = num34 - num126 * Math.Cos(num96);
						num37 = num35 + num126 * Math.Sin(num96);
						val2.DrawLine(val5, (float)num34, (float)num35, (float)num36, (float)num37);
						num34 = (double)num3 + (num27 - num32) / 2.0;
						num35 = (double)num6 + num28 * Math.Sin(num17) + num125;
						num36 = num34 + num126 * Math.Cos(num96);
						num37 = num35 + num126 * Math.Sin(num96);
						val2.DrawLine(val5, (float)num34, (float)num35, (float)num36, (float)num37);
						num34 = (double)num3 + (num27 + num32) / 2.0 - num126 * Math.Cos(num96);
						num35 = (double)num6 + num28 * Math.Sin(num17) + num125 + num126 * Math.Sin(num96);
						num36 = num34 - num127 * Math.Sin(num96);
						num37 = num35 - num127 * Math.Cos(num96);
						val2.DrawLine(val5, (float)num34, (float)num35, (float)num36, (float)num37);
						num34 = (double)num3 + (num27 - num32) / 2.0 + num126 * Math.Cos(num96);
						num35 = (double)num6 + num28 * Math.Sin(num17) + num125 + num126 * Math.Sin(num96);
						num36 = num34 + num127 * Math.Sin(num96);
						num37 = num35 - num127 * Math.Cos(num96);
						val2.DrawLine(val5, (float)num34, (float)num35, (float)num36, (float)num37);
						double num183 = 40.0;
						double num184 = (double)(G / 2) - (num176 + num103) * Math.Sin(num96);
						double num185 = (double)H - num101 + num103 * Math.Cos(num96);
						l = (int)Math.Round(Math.Sqrt(num184 * num184 + num185 * num185) - num183);
						double num186 = (double)l * num18 - num157;
						num34 = (double)(num3 - (int)((num30 - num27) / 2.0)) + num30 / 2.0 + num177 * Math.Sin(num96) + num157 * Math.Cos(num96);
						num35 = (double)num6 + num28 * Math.Sin(num17) + num29 - num157 * Math.Sin(num96);
						num36 = num34 - num177 * Math.Sin(num96);
						num37 = num35 - num177 * Math.Cos(num96);
						val2.DrawLine(val5, (float)num34, (float)num35, (float)num36, (float)num37);
						num36 = num34 + num186 * Math.Cos(num96);
						num37 = num35 - num186 * Math.Sin(num96);
						num90 = num36;
						num91 = num37;
						val2.DrawLine(val5, (float)num34, (float)num35, (float)num36, (float)num37);
						num34 -= num177 * Math.Sin(num96);
						num35 -= num177 * Math.Cos(num96);
						num36 = num34 + num186 * Math.Cos(num96);
						num37 = num35 - num186 * Math.Sin(num96);
						num92 = num36;
						num93 = num37;
						val2.DrawLine(val5, (float)num34, (float)num35, (float)num36, (float)num37);
						val2.DrawLine(val5, (float)num90, (float)num91, (float)num92, (float)num93);
						num34 = (double)(num3 - (int)((num30 - num27) / 2.0)) + num30 / 2.0 - num177 * Math.Sin(num96) - num157 * Math.Cos(num96);
						num35 = (double)num6 + num28 * Math.Sin(num17) + num29 - num157 * Math.Sin(num96);
						num36 = num34 + num177 * Math.Sin(num96);
						num37 = num35 - num177 * Math.Cos(num96);
						val2.DrawLine(val5, (float)num34, (float)num35, (float)num36, (float)num37);
						num36 = num34 - num186 * Math.Cos(num96);
						num37 = num35 - num186 * Math.Sin(num96);
						num90 = num36;
						num91 = num37;
						val2.DrawLine(val5, (float)num34, (float)num35, (float)num36, (float)num37);
						num34 += num177 * Math.Sin(num96);
						num35 -= num177 * Math.Cos(num96);
						num36 = num34 - num186 * Math.Cos(num96);
						num37 = num35 - num186 * Math.Sin(num96);
						num92 = num36;
						num93 = num37;
						val2.DrawLine(val5, (float)num34, (float)num35, (float)num36, (float)num37);
						val2.DrawLine(val5, (float)num90, (float)num91, (float)num92, (float)num93);
						double num187 = 1.5;
						double num188 = 0.0;
						double num189 = 0.0;
						double num190 = 0.0;
						double num191 = 0.0;
						num116 = num97 * num187;
						num117 = num98 * num187;
						num119 = num99 * num187;
						num120 = num104 * num187;
						num121 = num105 * num187;
						num122 = num106 * num187;
						num123 = num107 * num187;
						num124 = num108 * num187;
						num128 = num109 * num187;
						num129 = num110 * num187;
						num130 = num111 * num187;
						num131 = num112 * num187;
						num132 = num113 * num187;
						num133 = num114 * num187;
						num134 = num115 * num187;
						num29 = (double)H * num187;
						num31 = (double)h * num187;
						num30 = (double)B * num187;
						num27 = (double)b * num187;
						num118 = num100 * num187;
						num125 = num101 * num187;
						num126 = num102 * num187;
						num127 = num103 * num187;
						num190 = (double)(num - num4) - num121 * Math.Cos(num89);
						num191 = (double)num26 + num22 * num18 + 40.0;
						num188 = (double)(num - num4) - num131;
						num189 = num191 + num121 * Math.Sin(num89) + num122 + num123 + num133;
						num34 = num188;
						num35 = num189;
						num36 = num34 + num131;
						num37 = num35;
						val2.DrawLine(val5, (float)num34, (float)num35, (float)num36, (float)num37);
						num34 = num188;
						num35 = num189;
						num36 = num34;
						num37 = num35 + (double)num15;
						num90 = num36;
						num91 = num37;
						val2.DrawLine(val3, (float)num34, (float)num35, (float)num36, (float)num37);
						num34 += num131;
						num36 = num34;
						num92 = num36;
						num93 = num37;
						val2.DrawLine(val3, (float)num34, (float)num35, (float)num36, (float)num37);
						num34 = num90;
						num35 = num91 - 5.0;
						num36 = num92;
						num37 = num93 - 5.0;
						DrawRows(num34, num35, num36, num37, num18, val2, val3);
						num50 = (num90 + num92) / 2.0;
						num51 = num91 + (double)num21;
						#if WINDOWS
						val9.FormatFlags = (StringFormatFlags)1;
						#endif
						val2.DrawString(num112.ToString(), val7, (Brush)(object)val8, (float)num50, (float)num51, val9);
						num34 = num188 + num131;
						num35 = num189;
						num36 = num34;
						num37 = num35 - num132;
						val2.DrawLine(val5, (float)num34, (float)num35, (float)num36, (float)num37);
						num34 = num188;
						num35 = num189;
						num36 = num34;
						num37 = num35 - num132;
						val2.DrawLine(val5, (float)num34, (float)num35, (float)num36, (float)num37);
						num36 = num34 - (double)num15;
						num37 = num35;
						val2.DrawLine(val3, (float)num34, (float)num35, (float)num36, (float)num37);
						num35 = num189 - num132;
						num36 = num34 - (double)num15;
						num37 = num35;
						val2.DrawLine(val3, (float)num34, (float)num35, (float)num36, (float)num37);
						num34 = num36 + 5.0;
						num35 = num189;
						num36 = num34;
						num37 = num35 - num132;
						DrawRows(num36, num37, num34, num35, num18, val2, val3);
						num50 = num34 - (double)num21 - 3.0;
						num51 = (num35 + num37) / 2.0;
						#if WINDOWS
						val9.FormatFlags = (StringFormatFlags)1;
						#endif
						val2.DrawString(num113.ToString(), val7, (Brush)(object)val8, (float)num50, (float)num51, val9);
						num34 = num190 - num118 - 4.0 * num134;
						num35 = num191;
						num36 = num34;
						num37 = num35 + num133;
						val2.DrawLine(val5, (float)num34, (float)num35, (float)num36, (float)num37);
						num36 = num34 - (double)num15;
						num37 = num35;
						val2.DrawLine(val3, (float)num34, (float)num35, (float)num36, (float)num37);
						num34 = num190 - num118 - 4.0 * num134;
						num35 = num191 + num133;
						num36 = num34 - (double)num15;
						num37 = num35;
						val2.DrawLine(val3, (float)num34, (float)num35, (float)num36, (float)num37);
						num34 = num36 + 5.0;
						num35 = num191;
						num36 = num34;
						num37 = num35 + num133;
						DrawRows(num34, num35, num36, num37, num18, val2, val3);
						num50 = num34 - (double)num21 - 3.0;
						num51 = (num35 + num37) / 2.0;
						#if WINDOWS
						val9.FormatFlags = (StringFormatFlags)1;
						#endif
						val2.DrawString(num114.ToString(), val7, (Brush)(object)val8, (float)num50, (float)num51, val9);
						num34 = num190 - num118 - 4.0 * num134;
						num35 = num191 + num133;
						num36 = num34 + num134;
						num37 = num35;
						val2.DrawLine(val5, (float)num34, (float)num35, (float)num36, (float)num37);
						num36 = num34;
						num37 = num35 + (double)num15;
						val2.DrawLine(val3, (float)num34, (float)num35, (float)num36, (float)num37);
						num34 = num36 + num134;
						num36 = num34;
						val2.DrawLine(val3, (float)num34, (float)num35, (float)num36, (float)num37);
						num34 = num190 - num118 - 4.0 * num134;
						num35 = num191 + num133 + (double)num15 - 5.0;
						num36 = num34 + num134;
						num37 = num35;
						DrawRows(num36, num37, num34, num35, num18, val2, val3);
						num50 = (num34 + num36) / 2.0;
						num51 = num35 + (double)num21;
						#if WINDOWS
						val9.FormatFlags = (StringFormatFlags)1;
						#endif
						val2.DrawString(num115.ToString(), val7, (Brush)(object)val8, (float)num50, (float)num51, val9);
						num34 = num190;
						num35 = num191;
						num36 = num34 - num118;
						num37 = num35;
						val2.DrawLine(val5, (float)num34, (float)num35, (float)num36, (float)num37);
						num36 = num34;
						num37 = num35 - (double)num15;
						val2.DrawLine(val3, (float)num34, (float)num35, (float)num36, (float)num37);
						num34 = num36 - num118;
						num36 = num34;
						val2.DrawLine(val3, (float)num34, (float)num35, (float)num36, (float)num37);
						num34 = num190;
						num35 = num191 - (double)num15 + 5.0;
						num36 = num34 - num118;
						num37 = num35;
						DrawRows(num36, num37, num34, num35, num18, val2, val3);
						num50 = (num34 + num36) / 2.0;
						num51 = num35 - (double)num21 - 3.0;
						#if WINDOWS
						val9.FormatFlags = (StringFormatFlags)1;
						#endif
						val2.DrawString(num100.ToString(), val7, (Brush)(object)val8, (float)num50, (float)num51, val9);
						num34 = num190;
						num35 = num191;
						num36 = num34;
						num37 = num35 + num125;
						double num153 = num36;
						double num154 = num37;
						val2.DrawLine(val5, (float)num34, (float)num35, (float)num36, (float)num37);
						num36 = num34 + (double)num15;
						num37 = num35;
						num90 = num36;
						num91 = num37;
						val2.DrawLine(val3, (float)num34, (float)num35, (float)num36, (float)num37);
						num34 = num190;
						num35 = num191 + num125;
						num36 = num34 + (double)num15;
						num37 = num35;
						val2.DrawLine(val3, (float)num34, (float)num35, (float)num36, (float)num37);
						num34 = num90 - 5.0;
						num35 = num91;
						num36 -= 5.0;
						DrawRows(num34, num35, num36, num37, num18, val2, val3);
						num50 = num34 + (double)num21;
						num51 = (num35 + num37) / 2.0;
						#if WINDOWS
						val9.FormatFlags = (StringFormatFlags)1;
						#endif
						val2.DrawString(num101.ToString(), val7, (Brush)(object)val8, (float)num50, (float)num51, val9);
						num34 = num153;
						num35 = num154;
						num36 = num34 - num126 * Math.Cos(num96);
						num37 = num35 + num126 * Math.Sin(num96);
						val2.DrawLine(val5, (float)num34, (float)num35, (float)num36, (float)num37);
						num36 = num34 - (double)num15 * Math.Sin(num96);
						num37 = num35 - (double)num15 * Math.Cos(num96);
						num90 = num36;
						num91 = num37;
						val2.DrawLine(val3, (float)num34, (float)num35, (float)num36, (float)num37);
						num34 = num153 - num126 * Math.Cos(num96);
						num35 = num154 + num126 * Math.Sin(num96);
						num36 = num34 - (double)num15 * Math.Sin(num96);
						num37 = num35 - (double)num15 * Math.Cos(num96);
						val2.DrawLine(val3, (float)num34, (float)num35, (float)num36, (float)num37);
						num34 = num90 + 5.0 * Math.Sin(num96);
						num35 = num91 + 5.0 * Math.Cos(num96);
						num36 += 5.0 * Math.Sin(num96);
						num37 += 5.0 * Math.Cos(num96);
						DrawRows(num36, num37, num34, num35, num18, val2, val3);
						num50 = (num34 + num36) / 2.0 - (double)num21;
						num51 = (num35 + num37) / 2.0 - (double)(num21 / 2);
						#if WINDOWS
						val9.FormatFlags = (StringFormatFlags)1;
						#endif
						val2.DrawString(num102.ToString(), val7, (Brush)(object)val8, (float)num50, (float)num51, val9);
						num34 = num153;
						num35 = num154;
						num36 = num34;
						num37 = num35 + num126 * Math.Sin(num96);
						val2.DrawLine(val3, (float)num34, (float)num35, (float)num36, (float)num37);
						double num192 = 3.0 * num126 * Math.Cos(num96) / 8.0;
						double num193 = 3.0 * num126 * Math.Sin(num96) / 8.0;
						num34 = num153;
						num35 = num154 + num193;
						num42 = num34 - num192;
						num43 = num35;
						num36 = (num34 + num42) / 2.0;
						num37 = (num35 + num43) / 2.0 + 5.0;
						val2.DrawBezier(val3, (float)num34, (float)num35, (float)num36, (float)num37, (float)num42, (float)num43, (float)num42, (float)num43);
						string text4 = Math.Round((Math.PI / 2.0 - num96) * 180.0 / Math.PI) + "°";
						val2.DrawString(text4, val7, (Brush)(object)val8, (float)(num36 + 3.0), (float)(num37 + (double)num21), val9);
						num34 = num153 - num126 * Math.Cos(num96);
						num35 = num154 + num126 * Math.Sin(num96);
						num36 = num34 - num127 * Math.Sin(num96);
						num37 = num35 - num127 * Math.Cos(num96);
						val2.DrawLine(val5, (float)num34, (float)num35, (float)num36, (float)num37);
						num36 = num34 - (double)num15 * Math.Cos(num96);
						num37 = num35 + (double)num15 * Math.Sin(num96);
						num90 = num36;
						num91 = num37;
						val2.DrawLine(val3, (float)num34, (float)num35, (float)num36, (float)num37);
						num34 = num153 - num126 * Math.Cos(num96) - num127 * Math.Sin(num96);
						num35 = num154 + num126 * Math.Sin(num96) - num127 * Math.Cos(num96);
						num36 = num34 - (double)num15 * Math.Cos(num96);
						num37 = num35 + (double)num15 * Math.Sin(num96);
						val2.DrawLine(val3, (float)num34, (float)num35, (float)num36, (float)num37);
						num34 = num90 + 5.0 * Math.Cos(num96);
						num35 = num91 - 5.0 * Math.Sin(num96);
						num36 += 5.0 * Math.Cos(num96);
						num37 -= 5.0 * Math.Sin(num96);
						DrawRows(num34, num35, num36, num37, num18, val2, val3);
						num50 = (num34 + num36) / 2.0 - (double)num21;
						num51 = (num35 + num37) / 2.0 + (double)(num21 / 2);
						#if WINDOWS
						val9.FormatFlags = (StringFormatFlags)1;
						#endif
						val2.DrawString(num103.ToString(), val7, (Brush)(object)val8, (float)num50, (float)num51, val9);
					}
				}
				betaGradus = 90 - (int)Math.Round(num96 * 180.0 / Math.PI);
				if (onlyCalcBeta)
				{
					return;
				}
			}
			if (vyhid == "з виходом")
			{
				num19 = (double)(2 * num / 3 - num8 - num4) / (double)L;
				num9 = num26 + (int)(num22 * num18) + 50;
				int num194 = 0;
				if (vyhid3 == "круглий" || vyhid3 == "прямокутний")
				{
					num9 += 50;
					num194 += 50;
				}
				else if (vyhid2 == "круглий" || vyhid2 == "прямокутний")
				{
					num9 += 25;
					num194 += 25;
				}
				num9 += num15;
				if (num19 * (double)B + (double)(3 * num15) + (double)num194 > (double)num2 / 3.0)
				{
					num19 = ((double)num2 / 3.0 - (double)(3 * num15) - (double)num194) / (double)B;
				}
				num28 = (double)L * num19;
				num30 = (double)B * num19;
				num27 = (double)b * num19;
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
				num35 = (double)num9 + (num30 - num27) / 2.0;
				num36 = num34 + num28;
				num37 = num35;
				val2.DrawLine(val4, (float)num34, (float)num35, (float)num36, (float)num37);
				num34 = num8;
				num35 = (double)num9 + (num30 - num27) / 2.0 + num27;
				num36 = num34 + num28;
				num37 = num35;
				val2.DrawLine(val4, (float)num34, (float)num35, (float)num36, (float)num37);
				num34 = num8;
				num35 = (double)num9 + num30;
				num36 = num34 + num28;
				num37 = num35;
				val2.DrawLine(val4, (float)num34, (float)num35, (float)num36, (float)num37);
				num34 = num8;
				num35 = (double)num9 + (num30 - num27) / 2.0 + num27;
				num36 = num34 - (double)num14;
				num37 = num35;
				num92 = num36;
				num93 = num37;
				val2.DrawLine(val3, (float)num34, (float)num35, (float)num36, (float)num37);
				num34 = num8;
				num35 = (double)num9 + (num30 - num27) / 2.0;
				num36 = num34 - (double)num14;
				num37 = num35;
				num90 = num36;
				num91 = num37;
				val2.DrawLine(val3, (float)num34, (float)num35, (float)num36, (float)num37);
				num34 = num90 + 5.0;
				num35 = num91;
				num36 = num92 + 5.0;
				num37 = num93;
				DrawRows(num34, num35, num36, num37, num19, val2, val3);
				num50 = num34 - (double)num21;
				num51 = (num91 + num93) / 2.0;
				#if WINDOWS
				val9.FormatFlags = (StringFormatFlags)2;
				#endif
				val2.DrawString(b.ToString(), val7, (Brush)(object)val8, (float)num50, (float)num51, val9);
				num34 = (double)num8 + num28;
				num35 = (double)num9 + num30;
				num36 = num34 + (double)num14;
				num37 = num35;
				num92 = num36;
				num93 = num37;
				val2.DrawLine(val3, (float)num34, (float)num35, (float)num36, (float)num37);
				num34 = (double)num8 + num28;
				num35 = num9;
				num36 = num34 + (double)num14;
				num37 = num35;
				num90 = num36;
				num91 = num37;
				val2.DrawLine(val3, (float)num34, (float)num35, (float)num36, (float)num37);
				num34 = num90 - 5.0;
				num35 = num91;
				num36 = num92 - 5.0;
				num37 = num93;
				DrawRows(num34, num35, num36, num37, num19, val2, val3);
				num50 = num34 + (double)num21;
				num51 = (num91 + num93) / 2.0;
				#if WINDOWS
				val9.FormatFlags = (StringFormatFlags)2;
				#endif
				val2.DrawString(B.ToString(), val7, (Brush)(object)val8, (float)num50, (float)num51, val9);
				num34 = num8;
				num35 = (double)num9 + num30;
				num36 = num34;
				num37 = num35 + (double)num14;
				num90 = num36;
				num91 = num37;
				val2.DrawLine(val3, (float)num34, (float)num35, (float)num36, (float)num37);
				num34 = (double)num8 + num28;
				num35 = (double)num9 + num30;
				num36 = num34;
				num37 = num35 + (double)num14;
				num92 = num36;
				num93 = num37;
				val2.DrawLine(val3, (float)num34, (float)num35, (float)num36, (float)num37);
				num34 = num90;
				num35 = num91 - 5.0;
				num36 = num92;
				num37 = num93 - 5.0;
				val2.DrawLine(val3, (float)num34, (float)num35, (float)num36, (float)num37);
				num50 = (num90 + num92) / 2.0;
				num51 = (num91 + num93) / 2.0 + (double)num21;
				#if WINDOWS
				val9.FormatFlags = (StringFormatFlags)1;
				#endif
				val2.DrawString(L.ToString(), val7, (Brush)(object)val8, (float)num50, (float)num51, val9);
				if (vyhid1 == "круглий")
				{
					val2.DrawEllipse(val4, (float)((double)num8 + num38 - num40 / 2.0), (float)((double)num9 + (num30 - num27) / 2.0 + num39 - num40 / 2.0), (float)num40, (float)num40);
					num34 = num8;
					num35 = num9;
					num36 = num34;
					num37 = num35 - (double)num15;
					num90 = num36;
					num91 = num37;
					val2.DrawLine(val3, (float)num34, (float)num35, (float)num36, (float)num37);
					num34 = (double)num8 + num38;
					num35 = (double)num9 + (num30 - num27) / 2.0 + num39;
					num36 = num34;
					num37 = num35 - (num30 - num27) / 2.0 - num39 - (double)num15;
					num92 = num36;
					num93 = num37;
					val2.DrawLine(val3, (float)num34, (float)num35, (float)num36, (float)num37);
					num34 = num90;
					num35 = num91 + 5.0;
					num36 = num92;
					num37 = num93 + 5.0;
					val2.DrawLine(val3, (float)num34, (float)num35, (float)num36, (float)num37);
					DrawRows(num34, num35, num36, num37, num19, val2, val3);
					num50 = (num34 + num36) / 2.0;
					num51 = num37 - (double)num21;
					#if WINDOWS
					val9.FormatFlags = (StringFormatFlags)1;
					#endif
					val2.DrawString(f1.ToString(), val7, (Brush)(object)val8, (float)num50, (float)num51, val9);
					num34 = (double)num8 + num38;
					num35 = (double)num9 + (num30 - num27) / 2.0 + num39;
					num36 = num34 + num40 / 2.0 + (double)num15;
					num37 = num35;
					num90 = num36;
					num91 = num37;
					val2.DrawLine(val3, (float)num34, (float)num35, (float)num36, (float)num37);
					num92 = num90;
					num93 = (double)num9 + (num30 - num27) / 2.0;
					num34 = num90 - 5.0;
					num35 = num91;
					num36 = num92 - 5.0;
					num37 = num93;
					DrawRows(num36, num37, num34, num35, num19, val2, val3);
					num50 = num34 + (double)num21;
					num51 = ((vyhid2 == "прямокутний") ? (num37 + 15.0) : ((num35 + num37) / 2.0));
					#if WINDOWS
					val9.FormatFlags = (StringFormatFlags)2;
					#endif
					val2.DrawString(g1.ToString(), val7, (Brush)(object)val8, (float)num50, (float)num51, val9);
					num34 = (double)num8 + num38 - num40 / 2.0;
					num35 = (double)num9 + (num30 - num27) / 2.0 + num39;
					num36 = num34;
					num37 = num35 + num40 / 2.0 + (double)num15;
					num90 = num36;
					num91 = num37;
					val2.DrawLine(val3, (float)num34, (float)num35, (float)num36, (float)num37);
					num34 = (double)num8 + num38 + num40 / 2.0;
					num35 = (double)num9 + (num30 - num27) / 2.0 + num39;
					num36 = num34;
					num37 = num35 + num40 / 2.0 + (double)num15;
					num92 = num36;
					num93 = num37;
					val2.DrawLine(val3, (float)num34, (float)num35, (float)num36, (float)num37);
					num34 = num90;
					num35 = num91 - 5.0;
					num36 = num92;
					num37 = num93 - 5.0;
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
					val2.DrawRectangle(val4, (float)((double)num8 + num38 - num52 / 2.0), (float)((double)num9 + (num30 - num27) / 2.0 + num39 - num53 / 2.0), (float)num52, (float)num53);
					num34 = num8;
					num35 = num9;
					num36 = num34;
					num37 = num35 - (double)num15;
					num90 = num36;
					num91 = num37;
					val2.DrawLine(val3, (float)num34, (float)num35, (float)num36, (float)num37);
					num34 = (double)num8 + num38;
					num35 = (double)num9 + (num30 - num27) / 2.0 + num39;
					num36 = num34;
					num37 = num35 - (num30 - num27) / 2.0 - num39 - (double)num15;
					num92 = num36;
					num93 = num37;
					val2.DrawLine(val3, (float)num34, (float)num35, (float)num36, (float)num37);
					num34 = num90;
					num35 = num91 + 5.0;
					num36 = num92;
					num37 = num93 + 5.0;
					val2.DrawLine(val3, (float)num34, (float)num35, (float)num36, (float)num37);
					DrawRows(num34, num35, num36, num37, num19, val2, val3);
					num50 = (num34 + num36) / 2.0;
					num51 = num37 - (double)num21;
					#if WINDOWS
					val9.FormatFlags = (StringFormatFlags)1;
					#endif
					val2.DrawString(f1.ToString(), val7, (Brush)(object)val8, (float)num50, (float)num51, val9);
					num34 = (double)num8 + num38;
					num35 = (double)num9 + (num30 - num27) / 2.0 + num39;
					num36 = num34 + num52 / 2.0 + (double)num15;
					num37 = num35;
					num90 = num36;
					num91 = num37;
					val2.DrawLine(val3, (float)num34, (float)num35, (float)num36, (float)num37);
					num92 = num90;
					num93 = (double)num9 + (num30 - num27) / 2.0;
					num34 = num90 - 5.0;
					num35 = num91;
					num36 = num92 - 5.0;
					num37 = num93;
					DrawRows(num36, num37, num34, num35, num19, val2, val3);
					num50 = num34 + (double)num21;
					num51 = ((vyhid2 == "прямокутний") ? (num37 + 10.0) : ((num35 + num37) / 2.0));
					#if WINDOWS
					val9.FormatFlags = (StringFormatFlags)2;
					#endif
					val2.DrawString(g1.ToString(), val7, (Brush)(object)val8, (float)num50, (float)num51, val9);
					num34 = (double)num8 + num38 - num52 / 2.0;
					num35 = (double)num9 + (num30 - num27) / 2.0 + num39 + num53 / 2.0;
					num36 = num34;
					num37 = num35 + (double)num15;
					num90 = num36;
					num91 = num37;
					val2.DrawLine(val3, (float)num34, (float)num35, (float)num36, (float)num37);
					num34 = (double)num8 + num38 + num52 / 2.0;
					num35 = (double)num9 + (num30 - num27) / 2.0 + num39 + num53 / 2.0;
					num36 = num34;
					num37 = num35 + (double)num15;
					num92 = num36;
					num93 = num37;
					val2.DrawLine(val3, (float)num34, (float)num35, (float)num36, (float)num37);
					num34 = num90;
					num35 = num91 - 5.0;
					num36 = num92;
					num37 = num93 - 5.0;
					DrawRows(num34, num35, num36, num37, num19, val2, val3);
					num50 = (num34 + num36) / 2.0;
					num51 = num37 + (double)num21;
					#if WINDOWS
					val9.FormatFlags = (StringFormatFlags)1;
					#endif
					val2.DrawString(a1.ToString(), val7, (Brush)(object)val8, (float)num50, (float)num51, val9);
					num34 = (double)num8 + num38 - num52 / 2.0;
					num35 = (double)num9 + (num30 - num27) / 2.0 + num39 - num53 / 2.0;
					num36 = num34 - (double)num15;
					num37 = num35;
					num90 = num36;
					num91 = num37;
					val2.DrawLine(val3, (float)num34, (float)num35, (float)num36, (float)num37);
					num34 = (double)num8 + num38 - num52 / 2.0;
					num35 = (double)num9 + (num30 - num27) / 2.0 + num39 + num53 / 2.0;
					num36 = num34 - (double)num15;
					num37 = num35;
					num92 = num36;
					num93 = num37;
					val2.DrawLine(val3, (float)num34, (float)num35, (float)num36, (float)num37);
					num34 = num90 + 5.0;
					num35 = num91;
					num36 = num92 + 5.0;
					num37 = num93;
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
					val2.DrawEllipse(val4, (float)((double)num8 + num58 - num60 / 2.0), (float)((double)num9 + (num30 - num27) / 2.0 + num59 - num60 / 2.0), (float)num60, (float)num60);
					num34 = num8;
					num35 = num9;
					num36 = num34;
					num37 = num35 - (double)num15 - 25.0;
					num90 = num36;
					num91 = num37;
					val2.DrawLine(val3, (float)num34, (float)num35, (float)num36, (float)num37);
					num34 = (double)num8 + num58;
					num35 = (double)num9 + (num30 - num27) / 2.0 + num59;
					num36 = num34;
					num37 = num35 - (num30 - num27) / 2.0 - num59 - (double)num15 - 25.0;
					num92 = num36;
					num93 = num37;
					val2.DrawLine(val3, (float)num34, (float)num35, (float)num36, (float)num37);
					num34 = num90;
					num35 = num91 + 5.0;
					num36 = num92;
					num37 = num93 + 5.0;
					val2.DrawLine(val3, (float)num34, (float)num35, (float)num36, (float)num37);
					num50 = (num34 + num36) / 2.0;
					num51 = num37 - (double)num21;
					#if WINDOWS
					val9.FormatFlags = (StringFormatFlags)1;
					#endif
					val2.DrawString(f2.ToString(), val7, (Brush)(object)val8, (float)num50, (float)num51, val9);
					num34 = (double)num8 + num58;
					num35 = (double)num9 + (num30 - num27) / 2.0 + num59;
					num36 = num34 + num60 / 2.0 + (double)num15;
					num37 = num35;
					num90 = num36;
					num91 = num37;
					val2.DrawLine(val3, (float)num34, (float)num35, (float)num36, (float)num37);
					num92 = num90;
					num93 = (double)num9 + (num30 - num27) / 2.0;
					num34 = num90 - 5.0;
					num35 = num91;
					num36 = num92 - 5.0;
					num37 = num93;
					DrawRows(num36, num37, num34, num35, num19, val2, val3);
					num50 = num34 + (double)num21;
					num51 = (num35 + num37) / 2.0;
					#if WINDOWS
					val9.FormatFlags = (StringFormatFlags)2;
					#endif
					val2.DrawString(g2.ToString(), val7, (Brush)(object)val8, (float)num50, (float)num51, val9);
					num34 = (double)num8 + num58 - num60 / 2.0;
					num35 = (double)num9 + (num30 - num27) / 2.0 + num59;
					num36 = num34;
					num37 = num35 + num60 / 2.0 + (double)num15;
					num90 = num36;
					num91 = num37;
					val2.DrawLine(val3, (float)num34, (float)num35, (float)num36, (float)num37);
					num34 = (double)num8 + num58 + num60 / 2.0;
					num35 = (double)num9 + (num30 - num27) / 2.0 + num59;
					num36 = num34;
					num37 = num35 + num60 / 2.0 + (double)num15;
					num92 = num36;
					num93 = num37;
					val2.DrawLine(val3, (float)num34, (float)num35, (float)num36, (float)num37);
					num34 = num90;
					num35 = num91 - 5.0;
					num36 = num92;
					num37 = num93 - 5.0;
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
					val2.DrawRectangle(val4, (float)((double)num8 + num58 - num68 / 2.0), (float)((double)num9 + (num30 - num27) / 2.0 + num59 - num69 / 2.0), (float)num68, (float)num69);
					num34 = num8;
					num35 = num9;
					num36 = num34;
					num37 = num35 - (double)num15 - 25.0;
					num90 = num36;
					num91 = num37;
					val2.DrawLine(val3, (float)num34, (float)num35, (float)num36, (float)num37);
					num34 = (double)num8 + num58;
					num35 = (double)num9 + (num30 - num27) / 2.0 + num59;
					num36 = num34;
					num37 = num35 - (num30 - num27) / 2.0 - num59 - (double)num15 - 25.0;
					num92 = num36;
					num93 = num37;
					val2.DrawLine(val3, (float)num34, (float)num35, (float)num36, (float)num37);
					num34 = num90;
					num35 = num91 + 5.0;
					num36 = num92;
					num37 = num93 + 5.0;
					DrawRows(num34, num35, num36, num37, num19, val2, val3);
					num50 = (num34 + num36) / 2.0;
					num51 = num37 - (double)num21;
					#if WINDOWS
					val9.FormatFlags = (StringFormatFlags)1;
					#endif
					val2.DrawString(f2.ToString(), val7, (Brush)(object)val8, (float)num50, (float)num51, val9);
					num34 = (double)num8 + num58;
					num35 = (double)num9 + (num30 - num27) / 2.0 + num59;
					num36 = num34 + num68 / 2.0 + (double)num15;
					num37 = num35;
					num90 = num36;
					num91 = num37;
					val2.DrawLine(val3, (float)num34, (float)num35, (float)num36, (float)num37);
					num92 = num90;
					num93 = (double)num9 + (num30 - num27) / 2.0;
					num34 = num90 - 5.0;
					num35 = num91;
					num36 = num92 - 5.0;
					num37 = num93;
					DrawRows(num36, num37, num34, num35, num19, val2, val3);
					num50 = num34 + (double)num21;
					num51 = ((vyhid3 == "прямокутний") ? (num37 + 15.0) : ((num35 + num37) / 2.0));
					#if WINDOWS
					val9.FormatFlags = (StringFormatFlags)2;
					#endif
					val2.DrawString(g2.ToString(), val7, (Brush)(object)val8, (float)num50, (float)num51, val9);
					num34 = (double)num8 + num58 - num68 / 2.0;
					num35 = (double)num9 + (num30 - num27) / 2.0 + num59 + num69 / 2.0;
					num36 = num34;
					num37 = num35 + (double)num15;
					num90 = num36;
					num91 = num37;
					val2.DrawLine(val3, (float)num34, (float)num35, (float)num36, (float)num37);
					num34 = (double)num8 + num58 + num68 / 2.0;
					num35 = (double)num9 + (num30 - num27) / 2.0 + num59 + num69 / 2.0;
					num36 = num34;
					num37 = num35 + (double)num15;
					num92 = num36;
					num93 = num37;
					val2.DrawLine(val3, (float)num34, (float)num35, (float)num36, (float)num37);
					num34 = num90;
					num35 = num91 - 5.0;
					num36 = num92;
					num37 = num93 - 5.0;
					DrawRows(num34, num35, num36, num37, num19, val2, val3);
					num50 = (num34 + num36) / 2.0;
					num51 = num37 + (double)num21;
					#if WINDOWS
					val9.FormatFlags = (StringFormatFlags)1;
					#endif
					val2.DrawString(a2.ToString(), val7, (Brush)(object)val8, (float)num50, (float)num51, val9);
					num34 = (double)num8 + num58 - num68 / 2.0;
					num35 = (double)num9 + (num30 - num27) / 2.0 + num59 - num69 / 2.0;
					num36 = num34 - (double)num15;
					num37 = num35;
					num90 = num36;
					num91 = num37;
					val2.DrawLine(val3, (float)num34, (float)num35, (float)num36, (float)num37);
					num34 = (double)num8 + num58 - num68 / 2.0;
					num35 = (double)num9 + (num30 - num27) / 2.0 + num59 + num69 / 2.0;
					num36 = num34 - (double)num15;
					num37 = num35;
					num92 = num36;
					num93 = num37;
					val2.DrawLine(val3, (float)num34, (float)num35, (float)num36, (float)num37);
					num34 = num90 + 5.0;
					num35 = num91;
					num36 = num92 + 5.0;
					num37 = num93;
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
					val2.DrawEllipse(val4, (float)((double)num8 + num73 - num75 / 2.0), (float)((double)num9 + (num30 - num27) / 2.0 + num74 - num75 / 2.0), (float)num75, (float)num75);
					num34 = num8;
					num35 = num9;
					num36 = num34;
					num37 = num35 - (double)num15 - 50.0;
					num90 = num36;
					num91 = num37;
					val2.DrawLine(val3, (float)num34, (float)num35, (float)num36, (float)num37);
					num34 = (double)num8 + num73;
					num35 = (double)num9 + (num30 - num27) / 2.0 + num74;
					num36 = num34;
					num37 = num35 - (num30 - num27) / 2.0 - num74 - (double)num15 - 50.0;
					num92 = num36;
					num93 = num37;
					val2.DrawLine(val3, (float)num34, (float)num35, (float)num36, (float)num37);
					num34 = num90;
					num35 = num91 + 5.0;
					num36 = num92;
					num37 = num93 + 5.0;
					DrawRows(num34, num35, num36, num37, num19, val2, val3);
					num50 = (num34 + num36) / 2.0;
					num51 = num37 - (double)num21;
					#if WINDOWS
					val9.FormatFlags = (StringFormatFlags)1;
					#endif
					val2.DrawString(f3.ToString(), val7, (Brush)(object)val8, (float)num50, (float)num51, val9);
					num34 = (double)num8 + num73;
					num35 = (double)num9 + (num30 - num27) / 2.0 + num74;
					num36 = num34 + num75 / 2.0 + (double)num15;
					num37 = num35;
					num90 = num36;
					num91 = num37;
					val2.DrawLine(val3, (float)num34, (float)num35, (float)num36, (float)num37);
					num92 = num90;
					num93 = (double)num9 + (num30 - num27) / 2.0;
					num34 = num90 - 5.0;
					num35 = num91;
					num36 = num92 - 5.0;
					num37 = num93;
					DrawRows(num36, num37, num34, num35, num19, val2, val3);
					num50 = num34 + (double)num21;
					num51 = (num35 + num37) / 2.0;
					#if WINDOWS
					val9.FormatFlags = (StringFormatFlags)2;
					#endif
					val2.DrawString(g3.ToString(), val7, (Brush)(object)val8, (float)num50, (float)num51, val9);
					num34 = (double)num8 + num73 - num75 / 2.0;
					num35 = (double)num9 + (num30 - num27) / 2.0 + num74;
					num36 = num34;
					num37 = num35 + num75 / 2.0 + (double)num15;
					num90 = num36;
					num91 = num37;
					val2.DrawLine(val3, (float)num34, (float)num35, (float)num36, (float)num37);
					num34 = (double)num8 + num73 + num75 / 2.0;
					num35 = (double)num9 + (num30 - num27) / 2.0 + num74;
					num36 = num34;
					num37 = num35 + num75 / 2.0 + (double)num15;
					num92 = num36;
					num93 = num37;
					val2.DrawLine(val3, (float)num34, (float)num35, (float)num36, (float)num37);
					num34 = num90;
					num35 = num91 - 5.0;
					num36 = num92;
					num37 = num93 - 5.0;
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
					val2.DrawRectangle(val4, (float)((double)num8 + num73 - num83 / 2.0), (float)((double)num9 + (num30 - num27) / 2.0 + num74 - num84 / 2.0), (float)num83, (float)num84);
					num34 = num8;
					num35 = num9;
					num36 = num34;
					num37 = num35 - (double)num15 - 50.0;
					num90 = num36;
					num91 = num37;
					val2.DrawLine(val3, (float)num34, (float)num35, (float)num36, (float)num37);
					num34 = (double)num8 + num73;
					num35 = (double)num9 + (num30 - num27) / 2.0 + num74;
					num36 = num34;
					num37 = num35 - (num30 - num27) / 2.0 - num74 - (double)num15 - 50.0;
					num92 = num36;
					num93 = num37;
					val2.DrawLine(val3, (float)num34, (float)num35, (float)num36, (float)num37);
					num34 = num90;
					num35 = num91 + 5.0;
					num36 = num92;
					num37 = num93 + 5.0;
					DrawRows(num34, num35, num36, num37, num19, val2, val3);
					num50 = (num34 + num36) / 2.0;
					num51 = num37 - (double)num21;
					#if WINDOWS
					val9.FormatFlags = (StringFormatFlags)1;
					#endif
					val2.DrawString(f3.ToString(), val7, (Brush)(object)val8, (float)num50, (float)num51, val9);
					num34 = (double)num8 + num73;
					num35 = (double)num9 + (num30 - num27) / 2.0 + num74;
					num36 = num34 + num83 / 2.0 + (double)num15;
					num37 = num35;
					num90 = num36;
					num91 = num37;
					val2.DrawLine(val3, (float)num34, (float)num35, (float)num36, (float)num37);
					num92 = num90;
					num93 = (double)num9 + (num30 - num27) / 2.0;
					num34 = num90 - 5.0;
					num35 = num91;
					num36 = num92 - 5.0;
					num37 = num93;
					DrawRows(num36, num37, num34, num35, num19, val2, val3);
					num50 = num34 + (double)num21;
					num51 = (num35 + num37) / 2.0;
					#if WINDOWS
					val9.FormatFlags = (StringFormatFlags)2;
					#endif
					val2.DrawString(g3.ToString(), val7, (Brush)(object)val8, (float)num50, (float)num51, val9);
					num34 = (double)num8 + num73 - num83 / 2.0;
					num35 = (double)num9 + (num30 - num27) / 2.0 + num74 + num84 / 2.0;
					num36 = num34;
					num37 = num35 + (double)num15;
					num90 = num36;
					num91 = num37;
					val2.DrawLine(val3, (float)num34, (float)num35, (float)num36, (float)num37);
					num34 = (double)num8 + num73 + num83 / 2.0;
					num35 = (double)num9 + (num30 - num27) / 2.0 + num74 + num84 / 2.0;
					num36 = num34;
					num37 = num35 + (double)num15;
					num92 = num36;
					num93 = num37;
					val2.DrawLine(val3, (float)num34, (float)num35, (float)num36, (float)num37);
					num34 = num90;
					num35 = num91 - 5.0;
					num36 = num92;
					num37 = num93 - 5.0;
					DrawRows(num34, num35, num36, num37, num19, val2, val3);
					num50 = (num34 + num36) / 2.0;
					num51 = num37 + (double)num21 + 3.0;
					#if WINDOWS
					val9.FormatFlags = (StringFormatFlags)1;
					#endif
					val2.DrawString(a3.ToString(), val7, (Brush)(object)val8, (float)num50, (float)num51, val9);
					num34 = (double)num8 + num73 - num83 / 2.0;
					num35 = (double)num9 + (num30 - num27) / 2.0 + num74 - num84 / 2.0;
					num36 = num34 - (double)num15;
					num37 = num35;
					num90 = num36;
					num91 = num37;
					val2.DrawLine(val3, (float)num34, (float)num35, (float)num36, (float)num37);
					num34 = (double)num8 + num73 - num83 / 2.0;
					num35 = (double)num9 + (num30 - num27) / 2.0 + num74 + num84 / 2.0;
					num36 = num34 - (double)num15;
					num37 = num35;
					num92 = num36;
					num93 = num37;
					val2.DrawLine(val3, (float)num34, (float)num35, (float)num36, (float)num37);
					num34 = num90 + 5.0;
					num35 = num91;
					num36 = num92 + 5.0;
					num37 = num93;
					DrawRows(num34, num35, num36, num37, num19, val2, val3);
					num50 = num34 - (double)num21 - 3.0;
					num51 = (num35 + num37) / 2.0;
					#if WINDOWS
					val9.FormatFlags = (StringFormatFlags)2;
					#endif
					val2.DrawString(b3.ToString(), val7, (Brush)(object)val8, (float)num50, (float)num51, val9);
				}
			}
			num3 -= num33;
			num12 = num3;
			num13 = num26 + (int)(num22 * num18) + 50;
			if (vyhid == "з виходом")
			{
				num13 += num2 / 3 + 20;
			}
			int num195 = 10;
			int num196 = 0;
			Font val10 = new Font("Arial", (float)num195);
			StringFormat val11 = new StringFormat();
			val11.LineAlignment = (StringAlignment)0;
			val11.Alignment = (StringAlignment)0;
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
			if (zhyrFiltr == "так")
			{
				for (int i = 0; i < nFiltr; i++)
				{
					switch (i)
					{
					case 0:
						if (B >= 790 && B <= 1960)
						{
							val2.DrawString("Ширина першого жирфільтра: " + kFiltr[0] + "мм * 2шт", val10, (Brush)(object)val8, (float)num12, (float)(num13 + num196), val11);
						}
						else
						{
							val2.DrawString("Ширина першого жирфільтра: " + kFiltr[0] + "мм", val10, (Brush)(object)val8, (float)num12, (float)(num13 + num196), val11);
						}
						break;
					case 1:
						if (B >= 790 && B <= 1960)
						{
							val2.DrawString("Ширина другого жирфільтра: " + kFiltr[1] + "мм * 2шт", val10, (Brush)(object)val8, (float)num12, (float)(num13 + num196), val11);
						}
						else
						{
							val2.DrawString("Ширина другого жирфільтра: " + kFiltr[1] + "мм", val10, (Brush)(object)val8, (float)num12, (float)(num13 + num196), val11);
						}
						break;
					case 2:
						if (B >= 790 && B <= 1960)
						{
							val2.DrawString("Ширина третього жирфільтра: " + kFiltr[2] + "мм * 2шт", val10, (Brush)(object)val8, (float)num12, (float)(num13 + num196), val11);
						}
						else
						{
							val2.DrawString("Ширина третього жирфільтра: " + kFiltr[2] + "мм", val10, (Brush)(object)val8, (float)num12, (float)(num13 + num196), val11);
						}
						break;
					}
					num196 += num195 + 8;
					if (num13 + num196 > num2 - num7)
					{
						num12 = num3 + num / 2;
						num196 = 0;
					}
				}
				if (nFiltr == 1)
				{
					val2.DrawString("Довжина жирфільтра: " + l + "мм", val10, (Brush)(object)val8, (float)num12, (float)(num13 + num196), val11);
				}
				else
				{
					val2.DrawString("Довжина жирфільтрів: " + l + "мм", val10, (Brush)(object)val8, (float)num12, (float)(num13 + num196), val11);
				}
				num196 += num195 + 8;
				if (num13 + num196 > num2 - num7)
				{
					num12 = num3 + num / 2;
					num196 = 0;
				}
			}
			val2.DrawString("Матеріал зонта: " + zontMaterial, val10, (Brush)(object)val8, (float)num12, (float)(num13 + num196), val11);
			num196 += num195 + 8;
			if (num13 + num196 > num2 - num7)
			{
				num12 = num3 + num / 2;
				num196 = 0;
			}
			val2.DrawString("Товщина металу зонта: " + tovchynaMetaluZont + "мм", val10, (Brush)(object)val8, (float)num12, (float)(num13 + num196), val11);
			num196 += num195 + 8;
			if (num13 + num196 > num2 - num7)
			{
				num12 = num3 + num / 2;
				num196 = 0;
			}
			val2.DrawString("З'єднання: " + connection, val10, (Brush)(object)val8, (float)num12, (float)(num13 + num196), val11);
			num196 += num195 + 8;
			if (num13 + num196 > num2 - num7)
			{
				num12 = num3 + num / 2;
				num196 = 0;
			}
			val2.DrawString("Трубка зливу 1/2': " + zlyv, val10, (Brush)(object)val8, (float)num12, (float)(num13 + num196), val11);
			num196 += num195 + 8;
			if (num13 + num196 > num2 - num7)
			{
				num12 = num3 + num / 2;
				num196 = 0;
			}
			val2.DrawString("Кріплення: " + fastening, val10, (Brush)(object)val8, (float)num12, (float)(num13 + num196), val11);
			if (fastening == "так")
			{
				num196 += num195 + 8;
				if (num13 + num196 > num2 - num7)
				{
					num12 = num3 + num / 2;
					num196 = 0;
				}
				val2.DrawString("Тип кріплення: " + typeFastening, val10, (Brush)(object)val8, (float)num12, (float)(num13 + num196), val11);
			}
			if (vyhid == "з виходом")
			{
				if (vyhid1 == "круглий" || vyhid1 == "прямокутний")
				{
					num196 += num195 + 8;
					if (num13 + num196 > num2 - num7)
					{
						num12 = num3 + num / 2;
						num196 = 0;
					}
					val2.DrawString("Тип виходу 1: " + typVyhid1, val10, (Brush)(object)val8, (float)num12, (float)(num13 + num196), val11);
					if (typVyhid1 == "фланець")
					{
						num196 += num195 + 8;
						if (num13 + num196 > num2 - num7)
						{
							num12 = num3 + num / 2;
							num196 = 0;
						}
						val2.DrawString("Тип профілю для виходу 1: " + profilType1, val10, (Brush)(object)val8, (float)num12, (float)(num13 + num196), val11);
					}
				}
				if (vyhid2 == "круглий" || vyhid2 == "прямокутний")
				{
					num196 += num195 + 8;
					if (num13 + num196 > num2 - num7)
					{
						num12 = num3 + num / 2;
						num196 = 0;
					}
					val2.DrawString("Тип виходу 2: " + typVyhid2, val10, (Brush)(object)val8, (float)num12, (float)(num13 + num196), val11);
					if (typVyhid2 == "фланець")
					{
						num196 += num195 + 8;
						if (num13 + num196 > num2 - num7)
						{
							num12 = num3 + num / 2;
							num196 = 0;
						}
						val2.DrawString("Тип профілю для виходу 2: " + profilType2, val10, (Brush)(object)val8, (float)num12, (float)(num13 + num196), val11);
					}
				}
				if (vyhid3 == "круглий" || vyhid3 == "прямокутний")
				{
					num196 += num195 + 8;
					if (num13 + num196 > num2 - num7)
					{
						num12 = num3 + num / 2;
						num196 = 0;
					}
					val2.DrawString("Тип виходу 3: " + typVyhid3, val10, (Brush)(object)val8, (float)num12, (float)(num13 + num196), val11);
					if (typVyhid3 == "фланець")
					{
						num196 += num195 + 8;
						if (num13 + num196 > num2 - num7)
						{
							num12 = num3 + num / 2;
							num196 = 0;
						}
						val2.DrawString("Тип профілю для виходу 3: " + profilType3, val10, (Brush)(object)val8, (float)num12, (float)(num13 + num196), val11);
					}
				}
			}
			if (zhyrFiltr == "так")
			{
				num196 += num195 + 8;
				if (num13 + num196 > num2 - num7)
				{
					num12 = num3 + num / 2;
					num196 = 0;
				}
				val2.DrawString("Матеріал жирфільтра: " + zhyrFiltrMaterial, val10, (Brush)(object)val8, (float)num12, (float)(num13 + num196), val11);
				num196 += num195 + 8;
				if (num13 + num196 > num2 - num7)
				{
					num12 = num3 + num / 2;
					num196 = 0;
				}
				val2.DrawString("Товщина металу жирфільтра: " + tovchynaMetaluFiltr + "мм", val10, (Brush)(object)val8, (float)num12, (float)(num13 + num196), val11);
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
