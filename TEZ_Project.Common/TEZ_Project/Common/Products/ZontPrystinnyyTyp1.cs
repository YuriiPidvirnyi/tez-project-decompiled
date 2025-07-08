using System;
using System.Drawing;
using System.Globalization;
using System.IO;
using TEZ_Project.Common.Helpers;

namespace TEZ_Project.Common.Products;

public class ZontPrystinnyyTyp1
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

	public static int lMin = 300;

	public static int lMax = 750;

	public static int betaGradus = 0;

	public static double materialSpendingCommercialOffer = 0.0;

	public static double materialSpendingCommercialOffer1 = 0.0;

	public static double[,] MaterialZontVytyazhnyyTyp1(int L, int B, int H, int h, int b, int number, string markaStaliZont, string tovchynaMetaluZont, string connection, string zlyv, string fastening, string vyhid, string vyhid1, int d1, int a1, int b1, int p1, int f1, int g1, string typVyhid1, string profilType1, string vyhid2, int d2, int a2, int b2, int p2, int f2, int g2, string typVyhid2, string profilType2, string vyhid3, int d3, int a3, int b3, int p3, int f3, int g3, string typVyhid3, string profilType3, string zhyrFiltr, int G, string markaStaliFiltr, string tovchynaMetaluFiltr)
	{
		double[,] array = new double[32, 6];
		int num = -1;
		double num2 = 0.0;
		double num3 = 0.0;
		double num4 = 0.0;
		double num5 = 0.0;
		double num6 = 0.0;
		materialName = new string[32]
		{
			"", "", "", "", "", "", "", "", "", "",
			"", "", "", "", "", "", "", "", "", "",
			"", "", "", "", "", "", "", "", "", "",
			"", ""
		};
		materialCost = 0.0;
		betaGradus = 0;
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
		double num7 = ((connection == "зварка") ? 12 : 15);
		double num8 = (2.0 * num7 + (double)B) * (num7 + 10.0 + 20.0 + (double)H) - 0.5 * (double)(B - b) * (double)(H - h);
		if (B > 2500)
		{
			num8 += 40.0 * (num7 + 10.0 + 20.0 + (double)H);
		}
		else if (B > 1250)
		{
			num8 += 20.0 * (num7 + 10.0 + 20.0 + (double)H);
		}
		double num9 = Math.Sqrt((B - b) * (B - b) + (H - h) * (H - h));
		double num10 = 140.0 + (double)H + (double)b + num9 + (double)h + 20.0 + 10.0;
		if (num10 > 2460.0)
		{
			num10 += 40.0;
		}
		else if (num10 > 1230.0)
		{
			num10 += 20.0;
		}
		double num11 = ((L > 1230) ? 20 : 0);
		num11 += (double)((connection == "зварка") ? (L - 5) : L);
		double num12 = num10 * num11;
		double num13 = 0.0;
		if (vyhid == "з виходом")
		{
			num7 = 60.0;
			if (vyhid1 == "круглий")
			{
				double num14 = ((d1 < 560) ? 0.036 : ((d1 < 710) ? 0.043 : ((d1 >= 900) ? ((d1 < 1400) ? 0.086 : 0.11599999999999999) : 0.073)));
				num13 += (Math.PI * (double)d1 + num14) * ((double)p1 + num7);
			}
			if (vyhid2 == "круглий")
			{
				double num14 = ((d2 < 560) ? 0.036 : ((d2 < 710) ? 0.043 : ((d2 >= 900) ? ((d2 < 1400) ? 0.086 : 0.11599999999999999) : 0.073)));
				num13 += (Math.PI * (double)d2 + num14) * ((double)p2 + num7);
			}
			if (vyhid3 == "круглий")
			{
				double num14 = ((d3 < 560) ? 0.036 : ((d3 < 710) ? 0.043 : ((d3 >= 900) ? ((d3 < 1400) ? 0.086 : 0.11599999999999999) : 0.073)));
				num13 += (Math.PI * (double)d3 + num14) * ((double)p3 + num7);
			}
			if (vyhid1 == "прямокутний")
			{
				double num15 = 2.0 * (double)(a1 + 10 + b1 + 50);
				num7 = ((num15 <= 500.0) ? 60 : 30);
				num13 += (num15 + num7) * ((double)p1 + num7);
			}
			if (vyhid2 == "прямокутний")
			{
				double num15 = 2.0 * (double)(a2 + 10 + b2 + 50);
				num7 = ((num15 <= 500.0) ? 60 : 30);
				num13 += (num15 + num7) * ((double)p2 + num7);
			}
			if (vyhid3 == "прямокутний")
			{
				double num15 = 2.0 * (double)(a3 + 10 + b3 + 50);
				num7 = ((num15 <= 500.0) ? 60 : 30);
				num13 += (num15 + num7) * ((double)p3 + num7);
			}
		}
		if (zhyrFiltr == "так")
		{
			double num16 = 100.0;
			double num17 = 20.0;
			double num18 = 60.0;
			double num19 = 40.0;
			num7 = ((L > 1230) ? 20 : 0);
			num10 = 95.0;
			if (G == b)
			{
				typeUpperStrip = 1;
				num10 += 210.0;
			}
			else if (b - G >= 50)
			{
				typeUpperStrip = 2;
				num10 += 20.0 + num18 + 70.0 + 10.0;
			}
			num5 = num10 * (double)(L - 10);
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
			num10 = ((ZontPrystinnyyTyp1.l > 1230) ? 20 : 0);
			num10 += (double)(ZontPrystinnyyTyp1.l + 30);
			num6 = (kk + 42.5) * num10 + 1700.0;
		}
		array[num, 0] = (2.0 * num8 + num12 + num13 + num5 + 2.0 * num6) * 1.05 / 1000000.0;
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
			int num20 = 7;
			int num21 = 50;
			num9 = Math.Sqrt((B - b) * (B - b) + (H - h) * (H - h));
			int num22 = (int)Math.Round(((double)H - 2.0 * (double)num20) / (double)num21, MidpointRounding.AwayFromZero) + (int)Math.Round(((double)b - 2.0 * (double)num20) / (double)num21, MidpointRounding.AwayFromZero) + (int)Math.Round((num9 - 2.0 * (double)num20) / (double)num21, MidpointRounding.AwayFromZero) + (int)Math.Round(((double)h - 2.0 * (double)num20) / (double)num21, MidpointRounding.AwayFromZero);
			num22 *= 2;
			if (zhyrFiltr == "так")
			{
				num22 += 4;
				num22 += (int)Math.Round(((double)L - 100.0) / 200.0, MidpointRounding.AwayFromZero);
			}
			num++;
			materialName[num] = Consts2.zaklepkaKombinov48x6.MaterialName;
			array[num, 0] = num22;
			array[num, 4] = array[num, 0] * (double)number;
			materialCost += array[num, 0] * Consts2.zaklepkaKombinov48x6.Price;
		}
		if (zhyrFiltr == "так")
		{
			double[] array2 = new double[6];
			for (int k = 0; k < nFiltr; k++)
			{
				array2 = FiltrZh.MaterialFiltrZh(kFiltr[k], ZontPrystinnyyTyp1.l, markaStaliFiltr, tovchynaMetaluFiltr, number);
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
					int num23 = 0;
					for (int m = 0; m < 5 && FlanetsKruglyj.materialName1[m] != ""; m++)
					{
						num23++;
					}
					for (int n = 0; n < num23; n++)
					{
						materialName[n + num] = FlanetsKruglyj.materialName1[n];
						for (int num24 = 0; num24 < 6; num24++)
						{
							array[n + num, num24] = array3[n, num24];
						}
					}
					num += num23 - 1;
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
					int num25 = 0;
					for (int num26 = 0; num26 < 5 && FlanetsKruglyj.materialName1[num26] != ""; num26++)
					{
						num25++;
					}
					for (int num27 = 0; num27 < num25; num27++)
					{
						materialName[num27 + num] = FlanetsKruglyj.materialName1[num27];
						for (int num28 = 0; num28 < 6; num28++)
						{
							array[num27 + num, num28] = array3[num27, num28];
						}
					}
					num += num25 - 1;
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
					int num29 = 0;
					for (int num30 = 0; num30 < 5 && FlanetsKruglyj.materialName1[num30] != ""; num30++)
					{
						num29++;
					}
					for (int num31 = 0; num31 < num29; num31++)
					{
						materialName[num31 + num] = FlanetsKruglyj.materialName1[num31];
						for (int num32 = 0; num32 < 6; num32++)
						{
							array[num31 + num, num32] = array3[num31, num32];
						}
					}
					num += num29 - 1;
				}
			}
			if ((vyhid1 == "прямокутний" && typVyhid1 == "фланець") || (vyhid2 == "прямокутний" && typVyhid2 == "фланець") || (vyhid3 == "прямокутний" && typVyhid3 == "фланець"))
			{
				double[,] array4 = new double[2, 6];
				if (vyhid1 == "прямокутний" && typVyhid1 == "фланець")
				{
					array4 = MaterialFlanetsPrjamokutnyj(a1, b1, profilType1, number);
					materialCost += materialCost1;
					for (int num33 = 0; num33 < 2; num33++)
					{
						if (materialName1[num33] != "")
						{
							num++;
							materialName[num] = materialName1[num33];
							for (int num34 = 0; num34 < 6; num34++)
							{
								array[num, num34] = array4[num33, num34];
							}
						}
					}
				}
				if (vyhid2 == "прямокутний" && typVyhid2 == "фланець")
				{
					array4 = MaterialFlanetsPrjamokutnyj(a2, b2, profilType2, number);
					materialCost += materialCost1;
					for (int num35 = 0; num35 < 2; num35++)
					{
						if (materialName1[num35] != "")
						{
							num++;
							materialName[num] = materialName1[num35];
							for (int num36 = 0; num36 < 6; num36++)
							{
								array[num, num36] = array4[num35, num36];
							}
						}
					}
				}
				if (vyhid3 == "прямокутний" && typVyhid3 == "фланець")
				{
					array4 = MaterialFlanetsPrjamokutnyj(a3, b3, profilType3, number);
					materialCost += materialCost1;
					for (int num37 = 0; num37 < 2; num37++)
					{
						if (materialName1[num37] != "")
						{
							num++;
							materialName[num] = materialName1[num37];
							for (int num38 = 0; num38 < 6; num38++)
							{
								array[num, num38] = array4[num37, num38];
							}
						}
					}
				}
				num++;
			}
		}
		if (num > 0)
		{
			for (int num39 = 0; num39 < num; num39++)
			{
				for (int num40 = num39 + 1; num40 <= num; num40++)
				{
					if (!(materialName[num39] == materialName[num40]))
					{
						continue;
					}
					for (int num41 = 0; num41 < 6; num41++)
					{
						if (num41 == 1)
						{
							if (materialName[num39] == Consts2.lystStalnyj30.MaterialName)
							{
								array[num39, num41] = Math.Round((array[num39, num41] + array[num40, num41]) / 2.0);
							}
						}
						else
						{
							array[num39, num41] += array[num40, num41];
						}
						array[num40, num41] = 0.0;
					}
					materialName[num40] = "";
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

	public static void ZontPrystinnyyTyp1DrawDxf(int L, int B, int H, int h, int b, string connection, string zlyv, string vyhid, string vyhid1, int d1, int a1, int b1, int f1, int g1, string typVyhid1, string vyhid2, int d2, int a2, int b2, int f2, int g2, string typVyhid2, string vyhid3, int d3, int a3, int b3, int f3, int g3, string typVyhid3, string zhyrFiltr, int G, string filePath)
	{
		ushort num = 566;
		string text = "0";
		double num2 = 0.0;
		double num3 = 0.0;
		double num4 = 0.0;
		double num5 = 0.0;
		double num6 = 5.3;
		double num7 = 50.0;
		double num8 = 7.0;
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
			if (G == b)
			{
				typeUpperStrip = 1;
			}
			else if (b - G >= 50)
			{
				typeUpperStrip = 2;
			}
			double num9 = 10.0;
			double num10 = 20.0;
			double num11 = 100.0;
			double num12;
			double num13;
			double num14;
			double num15;
			if (connection == "зварка")
			{
				num12 = 12.0;
				num13 = 12.0;
				num14 = 12.0;
				num15 = 12.0;
			}
			else
			{
				num12 = 15.0;
				num13 = 15.0;
				num14 = 15.0;
				num15 = 15.0;
			}
			double num16 = 0.0;
			double num17 = 0.0;
			num2 = 0.0;
			num3 = num9 + num10 + num13;
			num4 = 0.0;
			num5 = num3 + (double)h - 2.0 * num13;
			ushort num18 = (ushort)(num + 1);
			num = num18;
			DrawLine(streamWriter, num18, text, num16 + num2, num17 + num3, num16 + num4, num17 + num5);
			num = DrawZaklepka(streamWriter, num, text, connection, num2, num3, num4, num5, 1);
			num2 = num4;
			num3 = num5;
			num4 = num13;
			num5 = num3 + num13;
			num18 = (ushort)(num + 1);
			num = num18;
			DrawLine(streamWriter, num18, text, num16 + num2, num17 + num3, num16 + num4, num17 + num5);
			double num19 = Math.Atan((double)(H - h) / (double)(B - b));
			num2 = num4;
			num3 = num5;
			num4 = num2;
			num5 = num3 + num15 / Math.Cos(num19);
			num18 = (ushort)(num + 1);
			num = num18;
			DrawLine(streamWriter, num18, text, num16 + num2, num17 + num3, num16 + num4, num17 + num5);
			double num20 = num4;
			double num21 = num5;
			num2 = 0.0;
			num3 = num9 + num10 + num13;
			num4 = num2 + num10 + num13;
			num5 = num3 - (num10 + num13);
			num18 = (ushort)(num + 1);
			num = num18;
			DrawLine(streamWriter, num18, text, num16 + num2, num17 + num3, num16 + num4, num17 + num5);
			num2 = num4;
			num3 = num5;
			num4 = num2;
			num5 = num3 - num9;
			num18 = (ushort)(num + 1);
			num = num18;
			DrawLine(streamWriter, num18, text, num16 + num2, num17 + num3, num16 + num4, num17 + num5);
			num2 = num4;
			num3 = num5;
			num4 = num2 + (double)B - (num10 + num11);
			num5 = num3;
			num18 = (ushort)(num + 1);
			num = num18;
			DrawLine(streamWriter, num18, text, num16 + num2, num17 + num3, num16 + num4, num17 + num5);
			num2 = num4;
			num3 = num5;
			num4 = num2;
			num5 = num3 + num9 + num10;
			num18 = (ushort)(num + 1);
			num = num18;
			DrawLine(streamWriter, num18, text, num16 + num2, num17 + num3, num16 + num4, num17 + num5);
			if (connection == "зварка")
			{
				num2 = num4;
				num3 = num5;
				num4 = num2 + num11;
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
			}
			else
			{
				num2 = num4;
				num3 = num5;
				num4 = num2 + num14;
				num5 = num3 - num14;
				num18 = (ushort)(num + 1);
				num = num18;
				DrawLine(streamWriter, num18, text, num16 + num2, num17 + num3, num16 + num4, num17 + num5);
				num2 = num4;
				num3 = num5;
				num4 = num2 + num11 - 2.0 * num14;
				num5 = num3;
				num18 = (ushort)(num + 1);
				num = num18;
				DrawLine(streamWriter, num18, text, num16 + num2, num17 + num3, num16 + num4, num17 + num5);
				num = DrawZaklepka(streamWriter, num, text, connection, num2, num3, num4, num5, 0);
				num2 = num4;
				num3 = num5;
				num4 = num2 + 2.0 * num14;
				num5 = num3 + 2.0 * num14;
				num18 = (ushort)(num + 1);
				num = num18;
				DrawLine(streamWriter, num18, text, num16 + num2, num17 + num3, num16 + num4, num17 + num5);
			}
			num2 = num4;
			num3 = num5;
			num4 = num2;
			num5 = num3 + (double)H - 2.0 * num14;
			num18 = (ushort)(num + 1);
			num = num18;
			DrawLine(streamWriter, num18, text, num16 + num2, num17 + num3, num16 + num4, num17 + num5);
			num = DrawZaklepka(streamWriter, num, text, connection, num2, num3, num4, num5, 0);
			num2 = num4;
			num3 = num5;
			num4 = num2 - (num12 + num14);
			num5 = num3 + num12 + num14;
			num18 = (ushort)(num + 1);
			num = num18;
			DrawLine(streamWriter, num18, text, num16 + num2, num17 + num3, num16 + num4, num17 + num5);
			num2 = num4;
			num3 = num5;
			num4 = num2 - ((double)b - 2.0 * num12);
			num5 = num3;
			num18 = (ushort)(num + 1);
			num = num18;
			DrawLine(streamWriter, num18, text, num16 + num2, num17 + num3, num16 + num4, num17 + num5);
			num = DrawZaklepka(streamWriter, num, text, connection, num4, num5, num2, num3, 1);
			num2 = num4;
			num3 = num5;
			num4 = num2 - num12;
			num5 = num3 - num12;
			num18 = (ushort)(num + 1);
			num = num18;
			DrawLine(streamWriter, num18, text, num16 + num2, num17 + num3, num16 + num4, num17 + num5);
			num2 = num4;
			num3 = num5;
			num4 = num2 - num15 / Math.Sin(num19);
			num5 = num3;
			double num22 = num4;
			double num23 = num5;
			num18 = (ushort)(num + 1);
			num = num18;
			DrawLine(streamWriter, num18, text, num16 + num2, num17 + num3, num16 + num4, num17 + num5);
			num2 = num20;
			num3 = num21;
			num18 = (ushort)(num + 1);
			num = num18;
			DrawLine(streamWriter, num18, text, num16 + num2, num17 + num3, num16 + num4, num17 + num5);
			num2 -= num15 * Math.Sin(num19);
			num3 -= num15 * Math.Tan(num19) * Math.Sin(num19);
			num4 += num15 * Math.Cos(num19) * Math.Cos(num19) / Math.Sin(num19);
			num5 += num15 * Math.Cos(num19);
			num = DrawZaklepka_1(streamWriter, num, text, connection, num2, num3, num4, num5, 1);
			double num24 = 10.5;
			double num25 = 21.0;
			double num26 = 1.0;
			double num27 = 21.0;
			double num28 = 20.5;
			double num29 = ((connection == "зварка") ? (L - 5) : L);
			num16 = 0.0;
			num17 = -500.0;
			if (connection == "зварка")
			{
				num2 = num24 + num25;
				num3 = 0.0;
				num4 = num2 - (num25 - num26);
				num5 = num3 - (num25 - num26);
				num18 = (ushort)(num + 1);
				num = num18;
				DrawLine(streamWriter, num18, text, num16 + num2, num17 + num3, num16 + num4, num17 + num5);
				num2 = num4;
				num3 = num5;
				num4 = num2 - (num24 - num26 / 2.0);
				num5 = num3;
				num18 = (ushort)(num + 1);
				num = num18;
				DrawLine(streamWriter, num18, text, num16 + num2, num17 + num3, num16 + num4, num17 + num5);
				num2 = num4;
				num3 = num5;
				num4 = num2;
				num5 = num3 - (num29 - 2.0 * (num25 - num26));
				num18 = (ushort)(num + 1);
				num = num18;
				DrawLine(streamWriter, num18, text, num16 + num2, num17 + num3, num16 + num4, num17 + num5);
				num2 = num4;
				num3 = num5;
				num4 = num2 + num24 - num26 / 2.0;
				num5 = num3;
				num18 = (ushort)(num + 1);
				num = num18;
				DrawLine(streamWriter, num18, text, num16 + num2, num17 + num3, num16 + num4, num17 + num5);
				num2 = num4;
				num3 = num5;
				num4 = num2 + num25 - num26;
				num5 = num3 - (num25 - num26);
				num18 = (ushort)(num + 1);
				num = num18;
				DrawLine(streamWriter, num18, text, num16 + num2, num17 + num3, num16 + num4, num17 + num5);
			}
			else
			{
				num2 = 0.0;
				num3 = 0.0;
				num4 = num2 + num24 - num26 / 2.0;
				num5 = num3;
				num18 = (ushort)(num + 1);
				num = num18;
				DrawLine(streamWriter, num18, text, num16 + num2, num17 + num3, num16 + num4, num17 + num5);
				num2 = num4;
				num3 = num5;
				num4 = num2;
				num5 = num3 - num26;
				num18 = (ushort)(num + 1);
				num = num18;
				DrawLine(streamWriter, num18, text, num16 + num2, num17 + num3, num16 + num4, num17 + num5);
				num2 = num4;
				num3 = num5;
				num4 = num2 + num26;
				num18 = (ushort)(num + 1);
				num = num18;
				DrawLine(streamWriter, num18, text, num16 + num2, num17 + num3, num16 + num4, num17 + num5);
				num2 = num4;
				num3 = num5;
				num4 = num2;
				num5 = num3 + num26;
				num18 = (ushort)(num + 1);
				num = num18;
				DrawLine(streamWriter, num18, text, num16 + num2, num17 + num3, num16 + num4, num17 + num5);
				num2 = num4;
				num3 = num5;
				num4 = num2 + num25 - num26;
				num5 = num3;
				num18 = (ushort)(num + 1);
				num = num18;
				DrawLine(streamWriter, num18, text, num16 + num2, num17 + num3, num16 + num4, num17 + num5);
				num2 = num4;
				num3 = num5;
				num4 = num2;
				num5 = num3 - num26;
				num18 = (ushort)(num + 1);
				num = num18;
				DrawLine(streamWriter, num18, text, num16 + num2, num17 + num3, num16 + num4, num17 + num5);
				num2 = num4;
				num3 = num5;
				num4 = num2 + num26;
				num18 = (ushort)(num + 1);
				num = num18;
				DrawLine(streamWriter, num18, text, num16 + num2, num17 + num3, num16 + num4, num17 + num5);
				num2 = num4;
				num3 = num5;
				num4 = num2;
				num5 = num3 + num26;
				num18 = (ushort)(num + 1);
				num = num18;
				DrawLine(streamWriter, num18, text, num16 + num2, num17 + num3, num16 + num4, num17 + num5);
				num2 = 0.0;
				num3 = 0.0;
				num4 = num2;
				num5 = num3 - num29;
				num18 = (ushort)(num + 1);
				num = num18;
				DrawLine(streamWriter, num18, text, num16 + num2, num17 + num3, num16 + num4, num17 + num5);
				num2 = num4;
				num3 = num5;
				num4 = num2 + num24 - num26 / 2.0;
				num5 = num3;
				num18 = (ushort)(num + 1);
				num = num18;
				DrawLine(streamWriter, num18, text, num16 + num2, num17 + num3, num16 + num4, num17 + num5);
				num2 = num4;
				num3 = num5;
				num4 = num2;
				num5 = num3 + num26;
				num18 = (ushort)(num + 1);
				num = num18;
				DrawLine(streamWriter, num18, text, num16 + num2, num17 + num3, num16 + num4, num17 + num5);
				num2 = num4;
				num3 = num5;
				num4 = num2 + num26;
				num18 = (ushort)(num + 1);
				num = num18;
				DrawLine(streamWriter, num18, text, num16 + num2, num17 + num3, num16 + num4, num17 + num5);
				num2 = num4;
				num3 = num5;
				num4 = num2;
				num5 = num3 - num26;
				num18 = (ushort)(num + 1);
				num = num18;
				DrawLine(streamWriter, num18, text, num16 + num2, num17 + num3, num16 + num4, num17 + num5);
				num2 = num4;
				num3 = num5;
				num4 = num2 + num25 - num26;
				num5 = num3;
				num18 = (ushort)(num + 1);
				num = num18;
				DrawLine(streamWriter, num18, text, num16 + num2, num17 + num3, num16 + num4, num17 + num5);
				num2 = num4;
				num3 = num5;
				num4 = num2;
				num5 = num3 + num26;
				num18 = (ushort)(num + 1);
				num = num18;
				DrawLine(streamWriter, num18, text, num16 + num2, num17 + num3, num16 + num4, num17 + num5);
				num2 = num4;
				num3 = num5;
				num4 = num2 + num26;
				num18 = (ushort)(num + 1);
				num = num18;
				DrawLine(streamWriter, num18, text, num16 + num2, num17 + num3, num16 + num4, num17 + num5);
				num2 = num4;
				num3 = num5;
				num4 = num2;
				num5 = num3 - num26;
				num18 = (ushort)(num + 1);
				num = num18;
				DrawLine(streamWriter, num18, text, num16 + num2, num17 + num3, num16 + num4, num17 + num5);
			}
			num2 = num4;
			num3 = num5;
			num4 = num2 + (double)h;
			num5 = num3;
			num18 = (ushort)(num + 1);
			num = num18;
			DrawLine(streamWriter, num18, text, num16 + num2, num17 + num3, num16 + num4, num17 + num5);
			num = DrawZaklepka_Top(streamWriter, num, text, connection, num2 + num16, num3 + num17, num4 + num16, num5 + num17, 0);
			num2 = num4;
			num3 = num5;
			num4 = num2;
			num5 = num3 + num26;
			num18 = (ushort)(num + 1);
			num = num18;
			DrawLine(streamWriter, num18, text, num16 + num2, num17 + num3, num16 + num4, num17 + num5);
			num2 = num4;
			num3 = num5;
			num4 = num2 + num26;
			num5 = num3;
			num18 = (ushort)(num + 1);
			num = num18;
			DrawLine(streamWriter, num18, text, num16 + num2, num17 + num3, num16 + num4, num17 + num5);
			num2 = num4;
			num3 = num5;
			num4 = num2;
			num5 = num3 - num26;
			num18 = (ushort)(num + 1);
			num = num18;
			DrawLine(streamWriter, num18, text, num16 + num2, num17 + num3, num16 + num4, num17 + num5);
			double num30 = Math.Sqrt(Math.Pow(B - b, 2.0) + Math.Pow(H - h, 2.0));
			num2 = num4;
			num3 = num5;
			num4 = num2 + num30;
			num5 = num3;
			num18 = (ushort)(num + 1);
			num = num18;
			DrawLine(streamWriter, num18, text, num16 + num2, num17 + num3, num16 + num4, num17 + num5);
			num = DrawZaklepka_Top(streamWriter, num, text, connection, num2 + num16, num3 + num17, num4 + num16, num5 + num17, 0);
			num2 = num4;
			num3 = num5;
			num4 = num2;
			num5 = num3 + num26;
			num18 = (ushort)(num + 1);
			num = num18;
			DrawLine(streamWriter, num18, text, num16 + num2, num17 + num3, num16 + num4, num17 + num5);
			num2 = num4;
			num3 = num5;
			num4 = num2 + num26;
			num5 = num3;
			num18 = (ushort)(num + 1);
			num = num18;
			DrawLine(streamWriter, num18, text, num16 + num2, num17 + num3, num16 + num4, num17 + num5);
			num2 = num4;
			num3 = num5;
			num4 = num2;
			num5 = num3 - num26;
			num18 = (ushort)(num + 1);
			num = num18;
			DrawLine(streamWriter, num18, text, num16 + num2, num17 + num3, num16 + num4, num17 + num5);
			num2 = num4;
			num3 = num5;
			num4 = num2 + (double)b;
			num5 = num3;
			num18 = (ushort)(num + 1);
			num = num18;
			DrawLine(streamWriter, num18, text, num16 + num2, num17 + num3, num16 + num4, num17 + num5);
			num = DrawZaklepka_Top(streamWriter, num, text, connection, num2 + num16, num3 + num17, num4 + num16, num5 + num17, 0);
			double num31 = num4;
			double num32 = num5;
			num2 = num4;
			num3 = num5;
			num4 = num2;
			num5 = num3 + num26;
			num18 = (ushort)(num + 1);
			num = num18;
			DrawLine(streamWriter, num18, text, num16 + num2, num17 + num3, num16 + num4, num17 + num5);
			num2 = num4;
			num3 = num5;
			num4 = num2 + num26;
			num5 = num3;
			num18 = (ushort)(num + 1);
			num = num18;
			DrawLine(streamWriter, num18, text, num16 + num2, num17 + num3, num16 + num4, num17 + num5);
			num2 = num4;
			num3 = num5;
			num4 = num2;
			num5 = num3 - num26;
			num18 = (ushort)(num + 1);
			num = num18;
			DrawLine(streamWriter, num18, text, num16 + num2, num17 + num3, num16 + num4, num17 + num5);
			num2 = num4;
			num3 = num5;
			num4 = num2 + (double)H;
			num5 = num3;
			num18 = (ushort)(num + 1);
			num = num18;
			DrawLine(streamWriter, num18, text, num16 + num2, num17 + num3, num16 + num4, num17 + num5);
			num = DrawZaklepka_Top(streamWriter, num, text, connection, num2 + num16, num3 + num17, num4 + num16, num5 + num17, 0);
			num2 = num4;
			num3 = num5;
			num4 = num2;
			num5 = num3 + num26;
			num18 = (ushort)(num + 1);
			num = num18;
			DrawLine(streamWriter, num18, text, num16 + num2, num17 + num3, num16 + num4, num17 + num5);
			num2 = num4;
			num3 = num5;
			num4 = num2 + num26;
			num5 = num3;
			num18 = (ushort)(num + 1);
			num = num18;
			DrawLine(streamWriter, num18, text, num16 + num2, num17 + num3, num16 + num4, num17 + num5);
			num2 = num4;
			num3 = num5;
			num4 = num2;
			num5 = num3 - num26;
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
			num = DrawZaklepka_Top(streamWriter, num, text, connection, num2 + num16, num3 + num17, num4 + num16, num5 + num17, 0);
			num2 = num4;
			num3 = num5;
			num4 = num2;
			num5 = num3 + num26;
			num18 = (ushort)(num + 1);
			num = num18;
			DrawLine(streamWriter, num18, text, num16 + num2, num17 + num3, num16 + num4, num17 + num5);
			num2 = num4;
			num3 = num5;
			num4 = num2 + num26;
			num5 = num3;
			num18 = (ushort)(num + 1);
			num = num18;
			DrawLine(streamWriter, num18, text, num16 + num2, num17 + num3, num16 + num4, num17 + num5);
			num2 = num4;
			num3 = num5;
			num4 = num2;
			num5 = num3 - num26;
			num18 = (ushort)(num + 1);
			num = num18;
			DrawLine(streamWriter, num18, text, num16 + num2, num17 + num3, num16 + num4, num17 + num5);
			num2 = num4;
			num3 = num5;
			num4 = num2 + num27 - num26;
			num5 = num3;
			num18 = (ushort)(num + 1);
			num = num18;
			DrawLine(streamWriter, num18, text, num16 + num2, num17 + num3, num16 + num4, num17 + num5);
			num2 = num4;
			num3 = num5;
			num4 = num2;
			num5 = num3 + num26;
			num18 = (ushort)(num + 1);
			num = num18;
			DrawLine(streamWriter, num18, text, num16 + num2, num17 + num3, num16 + num4, num17 + num5);
			num2 = num4;
			num3 = num5;
			num4 = num2 + num26;
			num5 = num3;
			num18 = (ushort)(num + 1);
			num = num18;
			DrawLine(streamWriter, num18, text, num16 + num2, num17 + num3, num16 + num4, num17 + num5);
			num2 = num4;
			num3 = num5;
			num4 = num2;
			num5 = num3 - num26;
			num18 = (ushort)(num + 1);
			num = num18;
			DrawLine(streamWriter, num18, text, num16 + num2, num17 + num3, num16 + num4, num17 + num5);
			num2 = num4;
			num3 = num5;
			num4 = num2 + num28 - num26 / 2.0;
			num5 = num3;
			num18 = (ushort)(num + 1);
			num = num18;
			DrawLine(streamWriter, num18, text, num16 + num2, num17 + num3, num16 + num4, num17 + num5);
			num2 = num4;
			num3 = num5;
			num4 = num2;
			num5 = num3 + num29;
			num18 = (ushort)(num + 1);
			num = num18;
			DrawLine(streamWriter, num18, text, num16 + num2, num17 + num3, num16 + num4, num17 + num5);
			num2 = ((connection == "зварка") ? (num24 + num25) : (num24 + num25 + num26 / 2.0));
			num3 = 0.0;
			num4 = num2 + (double)h;
			num5 = num3;
			num18 = (ushort)(num + 1);
			num = num18;
			DrawLine(streamWriter, num18, text, num16 + num2, num17 + num3, num16 + num4, num17 + num5);
			num = DrawZaklepka_Top(streamWriter, num, text, connection, num2 + num16, num3 + num17, num4 + num16, num5 + num17, 1);
			num2 = num4;
			num3 = num5;
			num4 = num2;
			num5 = num3 - num26;
			num18 = (ushort)(num + 1);
			num = num18;
			DrawLine(streamWriter, num18, text, num16 + num2, num17 + num3, num16 + num4, num17 + num5);
			num2 = num4;
			num3 = num5;
			num4 = num2 + num26;
			num5 = num3;
			num18 = (ushort)(num + 1);
			num = num18;
			DrawLine(streamWriter, num18, text, num16 + num2, num17 + num3, num16 + num4, num17 + num5);
			num2 = num4;
			num3 = num5;
			num4 = num2;
			num5 = num3 + num26;
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
			num = DrawZaklepka_Top(streamWriter, num, text, connection, num2 + num16, num3 + num17, num4 + num16, num5 + num17, 1);
			num2 = num4;
			num3 = num5;
			num4 = num2;
			num5 = num3 - num26;
			num18 = (ushort)(num + 1);
			num = num18;
			DrawLine(streamWriter, num18, text, num16 + num2, num17 + num3, num16 + num4, num17 + num5);
			num2 = num4;
			num3 = num5;
			num4 = num2 + num26;
			num5 = num3;
			num18 = (ushort)(num + 1);
			num = num18;
			DrawLine(streamWriter, num18, text, num16 + num2, num17 + num3, num16 + num4, num17 + num5);
			num2 = num4;
			num3 = num5;
			num4 = num2;
			num5 = num3 + num26;
			num18 = (ushort)(num + 1);
			num = num18;
			DrawLine(streamWriter, num18, text, num16 + num2, num17 + num3, num16 + num4, num17 + num5);
			num2 = num4;
			num3 = num5;
			num4 = num2 + (double)b;
			num5 = num3;
			num18 = (ushort)(num + 1);
			num = num18;
			DrawLine(streamWriter, num18, text, num16 + num2, num17 + num3, num16 + num4, num17 + num5);
			num = DrawZaklepka_Top(streamWriter, num, text, connection, num2 + num16, num3 + num17, num4 + num16, num5 + num17, 1);
			if (zhyrFiltr == "так")
			{
				double num33 = num4;
				double num34 = num5;
				double zaklepkaOffsetX = G - 10;
				num = DrawZaklepka_Top_1(streamWriter, num, text, connection, num31 + num16, num32 + num17, num33 + num16, num34 + num17, 0, zaklepkaOffsetX);
			}
			num20 = num16 + num4 + num26 / 2.0;
			num21 = num17 + num5;
			num2 = num4;
			num3 = num5;
			num4 = num2;
			num5 = num3 - num26;
			num18 = (ushort)(num + 1);
			num = num18;
			DrawLine(streamWriter, num18, text, num16 + num2, num17 + num3, num16 + num4, num17 + num5);
			num2 = num4;
			num3 = num5;
			num4 = num2 + num26;
			num5 = num3;
			num18 = (ushort)(num + 1);
			num = num18;
			DrawLine(streamWriter, num18, text, num16 + num2, num17 + num3, num16 + num4, num17 + num5);
			num2 = num4;
			num3 = num5;
			num4 = num2;
			num5 = num3 + num26;
			num18 = (ushort)(num + 1);
			num = num18;
			DrawLine(streamWriter, num18, text, num16 + num2, num17 + num3, num16 + num4, num17 + num5);
			num2 = num4;
			num3 = num5;
			num4 = num2 + (double)H;
			num5 = num3;
			num18 = (ushort)(num + 1);
			num = num18;
			DrawLine(streamWriter, num18, text, num16 + num2, num17 + num3, num16 + num4, num17 + num5);
			num = DrawZaklepka_Top(streamWriter, num, text, connection, num2 + num16, num3 + num17, num4 + num16, num5 + num17, 1);
			num2 = num4;
			num3 = num5;
			num4 = num2;
			num5 = num3 - num26;
			num18 = (ushort)(num + 1);
			num = num18;
			DrawLine(streamWriter, num18, text, num16 + num2, num17 + num3, num16 + num4, num17 + num5);
			num2 = num4;
			num3 = num5;
			num4 = num2 + num26;
			num5 = num3;
			num18 = (ushort)(num + 1);
			num = num18;
			DrawLine(streamWriter, num18, text, num16 + num2, num17 + num3, num16 + num4, num17 + num5);
			num2 = num4;
			num3 = num5;
			num4 = num2;
			num5 = num3 + num26;
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
			num = DrawZaklepka_Top(streamWriter, num, text, connection, num2 + num16, num3 + num17, num4 + num16, num5 + num17, 1);
			num2 = num4;
			num3 = num5;
			num4 = num2;
			num5 = num3 - num26;
			num18 = (ushort)(num + 1);
			num = num18;
			DrawLine(streamWriter, num18, text, num16 + num2, num17 + num3, num16 + num4, num17 + num5);
			num2 = num4;
			num3 = num5;
			num4 = num2 + num26;
			num5 = num3;
			num18 = (ushort)(num + 1);
			num = num18;
			DrawLine(streamWriter, num18, text, num16 + num2, num17 + num3, num16 + num4, num17 + num5);
			num2 = num4;
			num3 = num5;
			num4 = num2;
			num5 = num3 + num26;
			num18 = (ushort)(num + 1);
			num = num18;
			DrawLine(streamWriter, num18, text, num16 + num2, num17 + num3, num16 + num4, num17 + num5);
			num2 = num4;
			num3 = num5;
			num4 = num2 + num27 - num26;
			num5 = num3;
			num18 = (ushort)(num + 1);
			num = num18;
			DrawLine(streamWriter, num18, text, num16 + num2, num17 + num3, num16 + num4, num17 + num5);
			num2 = num4;
			num3 = num5;
			num4 = num2;
			num5 = num3 - num26;
			num18 = (ushort)(num + 1);
			num = num18;
			DrawLine(streamWriter, num18, text, num16 + num2, num17 + num3, num16 + num4, num17 + num5);
			num2 = num4;
			num3 = num5;
			num4 = num2 + num26;
			num5 = num3;
			num18 = (ushort)(num + 1);
			num = num18;
			DrawLine(streamWriter, num18, text, num16 + num2, num17 + num3, num16 + num4, num17 + num5);
			num2 = num4;
			num3 = num5;
			num4 = num2;
			num5 = num3 + num26;
			num18 = (ushort)(num + 1);
			num = num18;
			DrawLine(streamWriter, num18, text, num16 + num2, num17 + num3, num16 + num4, num17 + num5);
			num2 = num4;
			num3 = num5;
			num4 = num2 + num28 - num26 / 2.0;
			num5 = num3;
			num18 = (ushort)(num + 1);
			num = num18;
			DrawLine(streamWriter, num18, text, num16 + num2, num17 + num3, num16 + num4, num17 + num5);
			if (zhyrFiltr == "так" && zlyv != "ні")
			{
				double num35 = 100.0;
				double num36 = 50.0 + num27 + num28 + num26 / 2.0;
				double num37 = 16.0;
				num2 = num4 - num36;
				num3 = ((zlyv == "так, трубка справа") ? (num5 - num29 + num35) : (num5 - num35));
				num18 = (ushort)(num + 1);
				num = num18;
				DrawCircle(streamWriter, num18, text, num16 + num2, num17 + num3, num37 / 2.0);
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
				num16 = num20 - num26 / 2.0;
				num17 = num21 - 0.5 * ((double)L - num29);
				if (vyhid1 == "круглий")
				{
					num2 = -g1;
					num3 = -f1;
					num18 = (ushort)(num + 1);
					num = num18;
					DrawCircle(streamWriter, num18, text, num16 + num2, num17 + num3, (double)d1 / 2.0);
				}
				else if (vyhid1 == "прямокутний")
				{
					num2 = (double)(-g1) + (double)b1 / 2.0;
					num3 = (double)(-f1) + (double)a1 / 2.0;
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
					num2 = -g2;
					num3 = -f2;
					num18 = (ushort)(num + 1);
					num = num18;
					DrawCircle(streamWriter, num18, text, num16 + num2, num17 + num3, (double)d2 / 2.0);
				}
				else if (vyhid2 == "прямокутний")
				{
					num2 = (double)(-g2) + (double)b2 / 2.0;
					num3 = (double)(-f2) + (double)a2 / 2.0;
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
					num2 = -g3;
					num3 = -f3;
					num18 = (ushort)(num + 1);
					num = num18;
					DrawCircle(streamWriter, num18, text, num16 + num2, num17 + num3, (double)d3 / 2.0);
				}
				else if (vyhid3 == "прямокутний")
				{
					num2 = (double)(-g3) + (double)b3 / 2.0;
					num3 = (double)(-f3) + (double)a3 / 2.0;
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
			if (zhyrFiltr == "так")
			{
				int num51 = 95;
				num16 = B + 500;
				num17 = 0.0;
				num2 = 0.0;
				num3 = 0.0;
				num4 = num2;
				num5 = num3 + (double)num51;
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
				num5 = num3 - (double)num51;
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
				double num52 = 20.0;
				double num53 = 40.0;
				double num54 = 60.0;
				double num55 = 70.0;
				double num56 = 10.0;
				double num57 = ((connection == "зварка") ? 12 : 15);
				if (typeUpperStrip == 1)
				{
					num16 = B + 500;
					num17 = 250.0 + num52 + num53 + num54 + num55 + num56;
					num2 = 0.0;
					num3 = 0.0;
					num4 = num2;
					num5 = num3 - (num56 - num26 / 2.0);
					num18 = (ushort)(num + 1);
					num = num18;
					DrawLine(streamWriter, num18, text, num16 + num2, num17 + num3, num16 + num4, num17 + num5);
					num2 = num4;
					num3 = num5;
					num4 = num2 + num26;
					num5 = num3;
					num18 = (ushort)(num + 1);
					num = num18;
					DrawLine(streamWriter, num18, text, num16 + num2, num17 + num3, num16 + num4, num17 + num5);
					num2 = num4;
					num3 = num5;
					num4 = num2;
					num5 = num3 - num26;
					num18 = (ushort)(num + 1);
					num = num18;
					DrawLine(streamWriter, num18, text, num16 + num2, num17 + num3, num16 + num4, num17 + num5);
					num2 = num4;
					num3 = num5;
					num4 = num2 - num26;
					num5 = num3;
					num18 = (ushort)(num + 1);
					num = num18;
					DrawLine(streamWriter, num18, text, num16 + num2, num17 + num3, num16 + num4, num17 + num5);
					num2 = num4;
					num3 = num5;
					num4 = num2;
					num5 = num3 - (num55 - num26);
					num18 = (ushort)(num + 1);
					num = num18;
					DrawLine(streamWriter, num18, text, num16 + num2, num17 + num3, num16 + num4, num17 + num5);
					num2 = num4;
					num3 = num5;
					num4 = num2 + num26;
					num5 = num3;
					num18 = (ushort)(num + 1);
					num = num18;
					DrawLine(streamWriter, num18, text, num16 + num2, num17 + num3, num16 + num4, num17 + num5);
					num2 = num4;
					num3 = num5;
					num4 = num2;
					num5 = num3 - num26;
					num18 = (ushort)(num + 1);
					num = num18;
					DrawLine(streamWriter, num18, text, num16 + num2, num17 + num3, num16 + num4, num17 + num5);
					num2 = num4;
					num3 = num5;
					num4 = num2 - num26;
					num5 = num3;
					num18 = (ushort)(num + 1);
					num = num18;
					DrawLine(streamWriter, num18, text, num16 + num2, num17 + num3, num16 + num4, num17 + num5);
					num2 = num4;
					num3 = num5;
					num4 = num2;
					num5 = num3 - (num54 - num26 / 2.0);
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
					num5 = num3 - (num53 - num26 / 2.0);
					num18 = (ushort)(num + 1);
					num = num18;
					DrawLine(streamWriter, num18, text, num16 + num2, num17 + num3, num16 + num4, num17 + num5);
					num2 = num4;
					num3 = num5;
					num4 = num2 + num26;
					num5 = num3;
					num18 = (ushort)(num + 1);
					num = num18;
					DrawLine(streamWriter, num18, text, num16 + num2, num17 + num3, num16 + num4, num17 + num5);
					num2 = num4;
					num3 = num5;
					num4 = num2;
					num5 = num3 - num26;
					num18 = (ushort)(num + 1);
					num = num18;
					DrawLine(streamWriter, num18, text, num16 + num2, num17 + num3, num16 + num4, num17 + num5);
					num2 = num4;
					num3 = num5;
					num4 = num2 - num26;
					num5 = num3;
					num18 = (ushort)(num + 1);
					num = num18;
					DrawLine(streamWriter, num18, text, num16 + num2, num17 + num3, num16 + num4, num17 + num5);
					num2 = num4;
					num3 = num5;
					num4 = num2;
					num5 = num3 - (num52 - num26 / 2.0);
					num21 = num5;
					num18 = (ushort)(num + 1);
					num = num18;
					DrawLine(streamWriter, num18, text, num16 + num2, num17 + num3, num16 + num4, num17 + num5);
					num2 = num4;
					num3 = num5;
					num4 = num2 + (double)L - 2.0 * num57 - 10.0;
					num5 = num3;
					num18 = (ushort)(num + 1);
					num = num18;
					DrawLine(streamWriter, num18, text, num16 + num2, num17 + num3, num16 + num4, num17 + num5);
					num2 = num4;
					num3 = num5;
					num4 = num2;
					num5 = num3 + num52 - num26 / 2.0;
					num18 = (ushort)(num + 1);
					num = num18;
					DrawLine(streamWriter, num18, text, num16 + num2, num17 + num3, num16 + num4, num17 + num5);
					num2 = num4;
					num3 = num5;
					num4 = num2 - num26;
					num5 = num3;
					num18 = (ushort)(num + 1);
					num = num18;
					DrawLine(streamWriter, num18, text, num16 + num2, num17 + num3, num16 + num4, num17 + num5);
					num2 = num4;
					num3 = num5;
					num4 = num2;
					num5 = num3 + num26;
					num18 = (ushort)(num + 1);
					num = num18;
					DrawLine(streamWriter, num18, text, num16 + num2, num17 + num3, num16 + num4, num17 + num5);
					num2 = num4;
					num3 = num5;
					num4 = num2 + num26;
					num5 = num3;
					num18 = (ushort)(num + 1);
					num = num18;
					DrawLine(streamWriter, num18, text, num16 + num2, num17 + num3, num16 + num4, num17 + num5);
					num2 = num4;
					num3 = num5;
					num4 = num2;
					num5 = num3 + num53 - num26 / 2.0;
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
					num5 = num3 + num54 - num26 / 2.0;
					num18 = (ushort)(num + 1);
					num = num18;
					DrawLine(streamWriter, num18, text, num16 + num2, num17 + num3, num16 + num4, num17 + num5);
					num2 = num4;
					num3 = num5;
					num4 = num2 - num26;
					num5 = num3;
					num18 = (ushort)(num + 1);
					num = num18;
					DrawLine(streamWriter, num18, text, num16 + num2, num17 + num3, num16 + num4, num17 + num5);
					num2 = num4;
					num3 = num5;
					num4 = num2;
					num5 = num3 + num26;
					num18 = (ushort)(num + 1);
					num = num18;
					DrawLine(streamWriter, num18, text, num16 + num2, num17 + num3, num16 + num4, num17 + num5);
					num2 = num4;
					num3 = num5;
					num4 = num2 + num26;
					num5 = num3;
					num18 = (ushort)(num + 1);
					num = num18;
					DrawLine(streamWriter, num18, text, num16 + num2, num17 + num3, num16 + num4, num17 + num5);
					num2 = num4;
					num3 = num5;
					num4 = num2;
					num5 = num3 + num55 - num26;
					num18 = (ushort)(num + 1);
					num = num18;
					DrawLine(streamWriter, num18, text, num16 + num2, num17 + num3, num16 + num4, num17 + num5);
					num2 = num4;
					num3 = num5;
					num4 = num2 - num26;
					num5 = num3;
					num18 = (ushort)(num + 1);
					num = num18;
					DrawLine(streamWriter, num18, text, num16 + num2, num17 + num3, num16 + num4, num17 + num5);
					num2 = num4;
					num3 = num5;
					num4 = num2;
					num5 = num3 + num26;
					num18 = (ushort)(num + 1);
					num = num18;
					DrawLine(streamWriter, num18, text, num16 + num2, num17 + num3, num16 + num4, num17 + num5);
					num2 = num4;
					num3 = num5;
					num4 = num2 + num26;
					num5 = num3;
					num18 = (ushort)(num + 1);
					num = num18;
					DrawLine(streamWriter, num18, text, num16 + num2, num17 + num3, num16 + num4, num17 + num5);
					num2 = num4;
					num3 = num5;
					num4 = num2;
					num5 = num3 + num56 - num26 / 2.0;
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
				}
				if (typeUpperStrip == 2)
				{
					num16 = B + 500;
					num17 = 250.0;
					double num58 = 59.5;
					double num59 = 69.5;
					double num60 = 20.0;
					double num61 = 10.0;
					double num62 = ((connection == "зварка") ? 12 : 15);
					num2 = 0.0;
					num3 = 0.0;
					num4 = num2;
					num5 = num61 - num26 / 2.0;
					num18 = (ushort)(num + 1);
					num = num18;
					DrawLine(streamWriter, num18, text, num16 + num2, num17 + num3, num16 + num4, num17 + num5);
					num2 = num4;
					num3 = num5;
					num4 = num2 + num26;
					num5 = num3;
					num18 = (ushort)(num + 1);
					num = num18;
					DrawLine(streamWriter, num18, text, num16 + num2, num17 + num3, num16 + num4, num17 + num5);
					num2 = num4;
					num3 = num5;
					num4 = num2;
					num5 = num3 + num26;
					num18 = (ushort)(num + 1);
					num = num18;
					DrawLine(streamWriter, num18, text, num16 + num2, num17 + num3, num16 + num4, num17 + num5);
					num2 = num4;
					num3 = num5;
					num4 = num2 - num26;
					num5 = num3;
					num18 = (ushort)(num + 1);
					num = num18;
					DrawLine(streamWriter, num18, text, num16 + num2, num17 + num3, num16 + num4, num17 + num5);
					num2 = num4;
					num3 = num5;
					num4 = num2;
					num5 = num3 + num59 - num26 / 2.0;
					num18 = (ushort)(num + 1);
					num = num18;
					DrawLine(streamWriter, num18, text, num16 + num2, num17 + num3, num16 + num4, num17 + num5);
					num2 = num4;
					num3 = num5;
					num4 = num2 + num26;
					num5 = num3;
					num18 = (ushort)(num + 1);
					num = num18;
					DrawLine(streamWriter, num18, text, num16 + num2, num17 + num3, num16 + num4, num17 + num5);
					num2 = num4;
					num3 = num5;
					num4 = num2;
					num5 = num3 + num26;
					num18 = (ushort)(num + 1);
					num = num18;
					DrawLine(streamWriter, num18, text, num16 + num2, num17 + num3, num16 + num4, num17 + num5);
					num2 = num4;
					num3 = num5;
					num4 = num2 - num26;
					num5 = num3;
					num18 = (ushort)(num + 1);
					num = num18;
					DrawLine(streamWriter, num18, text, num16 + num2, num17 + num3, num16 + num4, num17 + num5);
					num2 = num4;
					num3 = num5;
					num4 = num2;
					num5 = num3 + num58;
					num18 = (ushort)(num + 1);
					num = num18;
					DrawLine(streamWriter, num18, text, num16 + num2, num17 + num3, num16 + num4, num17 + num5);
					num2 = num4;
					num3 = num5;
					num4 = num2 + num62;
					num5 = num3;
					num18 = (ushort)(num + 1);
					num = num18;
					DrawLine(streamWriter, num18, text, num16 + num2, num17 + num3, num16 + num4, num17 + num5);
					num2 = num4;
					num3 = num5;
					num4 = num2;
					num5 = num3 + num60;
					num18 = (ushort)(num + 1);
					num = num18;
					DrawLine(streamWriter, num18, text, num16 + num2, num17 + num3, num16 + num4, num17 + num5);
					num2 = num4;
					num3 = num5;
					num4 = num2 + (double)(L - 10) - 2.0 * num62;
					num5 = num3;
					num18 = (ushort)(num + 1);
					num = num18;
					DrawLine(streamWriter, num18, text, num16 + num2, num17 + num3, num16 + num4, num17 + num5);
					num2 = num4;
					num3 = num5;
					num4 = num2;
					num5 = num3 - num60;
					num18 = (ushort)(num + 1);
					num = num18;
					DrawLine(streamWriter, num18, text, num16 + num2, num17 + num3, num16 + num4, num17 + num5);
					num2 = num4;
					num3 = num5;
					num4 = num2 + num62;
					num5 = num3;
					num18 = (ushort)(num + 1);
					num = num18;
					DrawLine(streamWriter, num18, text, num16 + num2, num17 + num3, num16 + num4, num17 + num5);
					num21 = num5;
					num2 = num4;
					num3 = num5;
					num4 = num2;
					num5 = num3 - num58;
					num18 = (ushort)(num + 1);
					num = num18;
					DrawLine(streamWriter, num18, text, num16 + num2, num17 + num3, num16 + num4, num17 + num5);
					num2 = num4;
					num3 = num5;
					num4 = num2 - num26;
					num5 = num3;
					num18 = (ushort)(num + 1);
					num = num18;
					DrawLine(streamWriter, num18, text, num16 + num2, num17 + num3, num16 + num4, num17 + num5);
					num2 = num4;
					num3 = num5;
					num4 = num2;
					num5 = num3 - num26;
					num18 = (ushort)(num + 1);
					num = num18;
					DrawLine(streamWriter, num18, text, num16 + num2, num17 + num3, num16 + num4, num17 + num5);
					num2 = num4;
					num3 = num5;
					num4 = num2 + num26;
					num5 = num3;
					num18 = (ushort)(num + 1);
					num = num18;
					DrawLine(streamWriter, num18, text, num16 + num2, num17 + num3, num16 + num4, num17 + num5);
					num2 = num4;
					num3 = num5;
					num4 = num2;
					num5 = num3 - (num59 - num26 / 2.0);
					num18 = (ushort)(num + 1);
					num = num18;
					DrawLine(streamWriter, num18, text, num16 + num2, num17 + num3, num16 + num4, num17 + num5);
					num2 = num4;
					num3 = num5;
					num4 = num2 - num26;
					num5 = num3;
					num18 = (ushort)(num + 1);
					num = num18;
					DrawLine(streamWriter, num18, text, num16 + num2, num17 + num3, num16 + num4, num17 + num5);
					num2 = num4;
					num3 = num5;
					num4 = num2;
					num5 = num3 - num26;
					num18 = (ushort)(num + 1);
					num = num18;
					DrawLine(streamWriter, num18, text, num16 + num2, num17 + num3, num16 + num4, num17 + num5);
					num2 = num4;
					num3 = num5;
					num4 = num2 + num26;
					num5 = num3;
					num18 = (ushort)(num + 1);
					num = num18;
					DrawLine(streamWriter, num18, text, num16 + num2, num17 + num3, num16 + num4, num17 + num5);
					num2 = num4;
					num3 = num5;
					num4 = num2;
					num5 = num3 - (num61 - num26 / 2.0);
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
				}
				num7 = 220.0;
				double num63 = (int)Math.Round((double)(L - 100) / num7);
				num8 = 10.0;
				double num64 = 45.0;
				num7 = (double)(L - 100) / num63;
				num63++;
				num2 = num64;
				for (int i = 0; (double)i < num63; i++)
				{
					num18 = (ushort)(num + 1);
					num = num18;
					DrawCircle(streamWriter, num18, text, num16 + num2, num17 + num21 + num8, num6 / 2.0);
					num2 += num7;
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
				double num65 = 19.5;
				double num66 = 1.0;
				double num67 = 19.0;
				double num68 = 42.5;
				num16 = B + 500;
				num17 = 600.0;
				num2 = 0.0;
				num3 = 0.0;
				num4 = num2;
				num5 = num3 + num68;
				num18 = (ushort)(num + 1);
				num = num18;
				DrawLine(streamWriter, num18, text, num16 + num2, num17 + num3, num16 + num4, num17 + num5);
				num2 = num4;
				num3 = num5;
				num4 = num2 + num65;
				num5 = num3;
				num18 = (ushort)(num + 1);
				num = num18;
				DrawLine(streamWriter, num18, text, num16 + num2, num17 + num3, num16 + num4, num17 + num5);
				num2 = num4;
				num3 = num5;
				num4 = num2;
				num5 = num3 - num66;
				num18 = (ushort)(num + 1);
				num = num18;
				DrawLine(streamWriter, num18, text, num16 + num2, num17 + num3, num16 + num4, num17 + num5);
				num2 = num4;
				num3 = num5;
				num4 = num2 + num66;
				num5 = num3;
				num18 = (ushort)(num + 1);
				num = num18;
				DrawLine(streamWriter, num18, text, num16 + num2, num17 + num3, num16 + num4, num17 + num5);
				num2 = num4;
				num3 = num5;
				num4 = num2;
				num5 = num3 + num66;
				num18 = (ushort)(num + 1);
				num = num18;
				DrawLine(streamWriter, num18, text, num16 + num2, num17 + num3, num16 + num4, num17 + num5);
				num2 = num4;
				num3 = num5;
				num4 = num2 + num65 + num66;
				num5 = num3;
				num18 = (ushort)(num + 1);
				num = num18;
				DrawLine(streamWriter, num18, text, num16 + num2, num17 + num3, num16 + num4, num17 + num5);
				num2 = num4;
				num3 = num5;
				num4 = num2;
				num5 = num3 + num66;
				num18 = (ushort)(num + 1);
				num = num18;
				DrawLine(streamWriter, num18, text, num16 + num2, num17 + num3, num16 + num4, num17 + num5);
				num2 = num4;
				num3 = num5;
				num4 = num2 - num66;
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
				num4 = num2 + (double)(l + 30);
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
				num4 = num2 - num66;
				num5 = num3;
				num18 = (ushort)(num + 1);
				num = num18;
				DrawLine(streamWriter, num18, text, num16 + num2, num17 + num3, num16 + num4, num17 + num5);
				num2 = num4;
				num3 = num5;
				num4 = num2;
				num5 = num3 - num66;
				num18 = (ushort)(num + 1);
				num = num18;
				DrawLine(streamWriter, num18, text, num16 + num2, num17 + num3, num16 + num4, num17 + num5);
				num2 = num4;
				num3 = num5;
				num4 = num2 + num66;
				num5 = num3;
				num18 = (ushort)(num + 1);
				num = num18;
				DrawLine(streamWriter, num18, text, num16 + num2, num17 + num3, num16 + num4, num17 + num5);
				num2 = num4;
				num3 = num5;
				num4 = num2;
				num5 = num3 - num68;
				num18 = (ushort)(num + 1);
				num = num18;
				DrawLine(streamWriter, num18, text, num16 + num2, num17 + num3, num16 + num4, num17 + num5);
				num2 = num4;
				num3 = num5;
				num4 = num2 - ((double)(l + 30) - 0.5);
				num5 = num3;
				num18 = (ushort)(num + 1);
				num = num18;
				DrawLine(streamWriter, num18, text, num16 + num2, num17 + num3, num16 + num4, num17 + num5);
				num2 = num4;
				num3 = num5;
				num4 = num2;
				num5 = num3 + num66;
				num18 = (ushort)(num + 1);
				num = num18;
				DrawLine(streamWriter, num18, text, num16 + num2, num17 + num3, num16 + num4, num17 + num5);
				num2 = num4;
				num3 = num5;
				num4 = num2 - num66;
				num5 = num3;
				num18 = (ushort)(num + 1);
				num = num18;
				DrawLine(streamWriter, num18, text, num16 + num2, num17 + num3, num16 + num4, num17 + num5);
				num2 = num4;
				num3 = num5;
				num4 = num2;
				num5 = num3 - num66;
				num18 = (ushort)(num + 1);
				num = num18;
				DrawLine(streamWriter, num18, text, num16 + num2, num17 + num3, num16 + num4, num17 + num5);
				num2 = num4;
				num3 = num5;
				num4 = num2 - num67;
				num5 = num3;
				num18 = (ushort)(num + 1);
				num = num18;
				DrawLine(streamWriter, num18, text, num16 + num2, num17 + num3, num16 + num4, num17 + num5);
				num2 = num4;
				num3 = num5;
				num4 = num2;
				num5 = num3 + num66;
				num18 = (ushort)(num + 1);
				num = num18;
				DrawLine(streamWriter, num18, text, num16 + num2, num17 + num3, num16 + num4, num17 + num5);
				num2 = num4;
				num3 = num5;
				num4 = num2 - num66;
				num5 = num3;
				num18 = (ushort)(num + 1);
				num = num18;
				DrawLine(streamWriter, num18, text, num16 + num2, num17 + num3, num16 + num4, num17 + num5);
				num2 = num4;
				num3 = num5;
				num4 = num2;
				num5 = num3 - num66;
				num18 = (ushort)(num + 1);
				num = num18;
				DrawLine(streamWriter, num18, text, num16 + num2, num17 + num3, num16 + num4, num17 + num5);
				num2 = num4;
				num3 = num5;
				num4 = num2 - num65;
				num5 = num3;
				num18 = (ushort)(num + 1);
				num = num18;
				DrawLine(streamWriter, num18, text, num16 + num2, num17 + num3, num16 + num4, num17 + num5);
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
		catch (IOException)
		{
			throw;
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

	public static ushort DrawZaklepka_1(StreamWriter sw, ushort ii, string Layer_Name, string connection, double x1, double y1, double x2, double y2, byte leftRight)
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

	public static void ZontPrystinnyyTyp1DrawImage(int L, int B, int H, int h, int b, int number, string zontMaterial, string tovchynaMetaluZont, string connection, string zlyv, string fastening, string vyhid, string vyhid1, int d1, int a1, int b1, int p1, int f1, int g1, string typVyhid1, string profilType1, string vyhid2, int d2, int a2, int b2, int p2, int f2, int g2, string typVyhid2, string profilType2, string vyhid3, int d3, int a3, int b3, int p3, int f3, int g3, string typVyhid3, string profilType3, string zhyrFiltr, int G, string zhyrFiltrMaterial, string tovchynaMetaluFiltr, string typeFastening, string orderCode, string contragent, string filePath = null)
	{
		//IL_0093: Unknown result type (might be due to invalid IL or missing references)
		//IL_009d: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a4: Expected O, but got Unknown
		//IL_00ac: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bd: Expected O, but got Unknown
		//IL_00c5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cf: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d6: Expected O, but got Unknown
		//IL_00e6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ed: Expected O, but got Unknown
		//IL_00f5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fc: Expected O, but got Unknown
		//IL_00fc: Unknown result type (might be due to invalid IL or missing references)
		//IL_0101: Unknown result type (might be due to invalid IL or missing references)
		//IL_0108: Expected O, but got Unknown
		//IL_0108: Unknown result type (might be due to invalid IL or missing references)
		//IL_010f: Expected O, but got Unknown
		//IL_5e56: Unknown result type (might be due to invalid IL or missing references)
		//IL_5e5d: Expected O, but got Unknown
		//IL_5e5d: Unknown result type (might be due to invalid IL or missing references)
		//IL_5e64: Expected O, but got Unknown
		int num = 725;
		int num2 = 1026;
		int num3 = 35;
		int num4 = 40;
		int num5 = 25;
		int num6 = 20;
		int num7 = num3;
		int num8 = 0;
		int num9 = 2 * num / 3 + 20;
		int num10 = num2 / 6;
		int num11 = 20;
		int num12 = 15;
		double num13 = Math.PI / 6.0;
		double num14 = 0.0;
		double num15 = 0.0;
		int num16 = 750;
		double num17 = 0.0;
		Image val = Image.FromFile(WPFHelper.GetProjectRootPath() + "\\Images\\Untitled.jpg");
		Graphics val2 = Graphics.FromImage(val);
		try
		{
			Pen val3 = new Pen(Color.FromArgb(255, 0, 0, 0), 1f);
			Pen val4 = new Pen(Color.FromArgb(255, 0, 0, 0), 2f);
			Pen val5 = new Pen(Color.FromArgb(255, 0, 0, 0), 3f);
			int num18 = 12;
			int num19 = 10;
			Font val6 = new Font("Arial", (float)num18);
			Font val7 = new Font("Arial", (float)num19);
			SolidBrush val8 = new SolidBrush(Color.Black);
			StringFormat val9 = new StringFormat();
			val9.LineAlignment = (StringAlignment)1;
			val9.Alignment = (StringAlignment)1;
			string text = "Зонт ЗВП-1 " + L + "х" + B + "х" + H;
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
			num14 = (double)(num - num3 - num4) / ((double)B + (double)L * Math.Cos(num13));
			double num20 = (double)L * Math.Sin(num13);
			double num21 = 0.0;
			if (vyhid == "з виходом")
			{
				if (vyhid1 == "круглий" || vyhid1 == "прямокутний")
				{
					num21 = ((vyhid1 == "круглий") ? ((double)(f1 + d1 / 2) * Math.Sin(num13)) : ((double)(f1 + a1 / 2) * Math.Sin(num13)));
					num21 += (double)p1;
					if (num21 > num20)
					{
						num20 = num21;
					}
				}
				if (vyhid2 == "круглий" || vyhid2 == "прямокутний")
				{
					num21 = ((vyhid2 == "круглий") ? ((double)(f2 + d2 / 2) * Math.Sin(num13)) : ((double)(f2 + a2 / 2) * Math.Sin(num13)));
					num21 += (double)p2;
					if (num21 > num20)
					{
						num20 = num21;
					}
				}
				if (vyhid3 == "круглий" || vyhid3 == "прямокутний")
				{
					num21 = ((vyhid3 == "круглий") ? ((double)(f3 + d3 / 2) * Math.Sin(num13)) : ((double)(f3 + a3 / 2) * Math.Sin(num13)));
					num21 += (double)p3;
					if (num21 > num20)
					{
						num20 = num21;
					}
				}
			}
			num20 += (double)H;
			if (G == b)
			{
				typeUpperStrip = 1;
			}
			else if (b - G >= 50)
			{
				typeUpperStrip = 2;
			}
			double num22 = (double)(num2 / 3) / num20;
			if (num22 < num14)
			{
				num14 = num22;
			}
			int num23 = 10;
			int num24 = num5 + num18 + num23;
			int num25 = num24;
			if (num20 > (double)H + (double)L * Math.Sin(num13))
			{
				num24 += (int)((num20 - ((double)H + (double)L * Math.Sin(num13))) * num14);
			}
			double num26 = (double)b * num14;
			double num27 = (double)L * num14;
			double num28 = (double)H * num14;
			double num29 = (double)B * num14;
			double num30 = (double)h * num14;
			double num31 = (double)G * num14;
			double num32 = num3;
			double num33 = (double)num24 + num27 * Math.Sin(num13);
			double num34 = num32 + num26;
			double num35 = num33;
			val2.DrawLine(val4, (float)num32, (float)num33, (float)num34, (float)num35);
			num34 = num32 + num27 * Math.Cos(num13);
			num35 = num24;
			val2.DrawLine(val4, (float)num32, (float)num33, (float)num34, (float)num35);
			num32 = num34;
			num33 = num35;
			num34 = num32 + num26;
			val2.DrawLine(val4, (float)num32, (float)num33, (float)num34, (float)num35);
			num32 = (double)num3 + num26;
			num33 = (double)num24 + num27 * Math.Sin(num13);
			num34 = num32 + num27 * Math.Cos(num13);
			num35 = num24;
			val2.DrawLine(val4, (float)num32, (float)num33, (float)num34, (float)num35);
			double num40;
			double num41;
			double num48;
			double num49;
			if (vyhid == "з виходом")
			{
				if (vyhid1 == "круглий")
				{
					double num36 = (double)f1 * num14;
					double num37 = (double)g1 * num14;
					double num38 = (double)d1 * num14;
					double num39 = (double)p1 * num14;
					num32 = (double)num3 + num37 + (num36 - num38 / 2.0) * Math.Cos(num13);
					num33 = (double)num24 + num27 * Math.Sin(num13) - (num36 - num38 / 2.0) * Math.Sin(num13);
					num34 = (double)num3 + num37 - num38 / 2.0 + num36 * Math.Cos(num13) - 5.0;
					num35 = num33 - num38 / 2.0 * Math.Sin(num13);
					num40 = (double)num3 + num37 + (num36 + num38 / 2.0) * Math.Cos(num13);
					num41 = num33 - num38 * Math.Sin(num13);
					double num42 = num33 - num39;
					double num43 = num35 - num39;
					double num44 = num41 - num39;
					val2.DrawBezier(val4, (float)num32, (float)num33, (float)num34, (float)num35, (float)num40, (float)num41, (float)num40, (float)num41);
					val2.DrawBezier(val4, (float)num32, (float)num42, (float)num34, (float)num43, (float)num40, (float)num44, (float)num40, (float)num44);
					num34 = num34 + num38 + 10.0;
					val2.DrawBezier(val4, (float)num32, (float)num33, (float)num34, (float)num35, (float)num40, (float)num41, (float)num40, (float)num41);
					val2.DrawBezier(val4, (float)num32, (float)num42, (float)num34, (float)num43, (float)num40, (float)num44, (float)num40, (float)num44);
					val2.DrawLine(val4, (float)num32, (float)num33, (float)num32, (float)num42);
					val2.DrawLine(val4, (float)num40, (float)num41, (float)num40, (float)num44);
					double num45 = num32 - (double)num11;
					double num46 = num33;
					double num47 = num42;
					val2.DrawLine(val3, (float)num32, (float)num33, (float)num45, (float)num46);
					val2.DrawLine(val3, (float)num32, (float)num42, (float)num45, (float)num47);
					DrawRows(num45 + 5.0, num47, num45 + 5.0, num46, num14, val2, val3);
					num48 = num45 - (double)num19;
					num49 = (num46 + num47) / 2.0;
					#if WINDOWS
					val9.FormatFlags = (StringFormatFlags)2;
					#endif
					val2.DrawString(p1.ToString(), val7, (Brush)(object)val8, (float)num48, (float)num49, val9);
				}
				else if (vyhid1 == "прямокутний")
				{
					double num36 = (double)f1 * num14;
					double num37 = (double)g1 * num14;
					double num50 = (double)a1 * num14;
					double num51 = (double)b1 * num14;
					double num39 = (double)p1 * num14;
					num32 = (double)num3 + num37 + (num36 - num50 / 2.0) * Math.Cos(num13) - num51 / 2.0;
					num33 = (double)num24 + num27 * Math.Sin(num13) - (num36 - num50 / 2.0) * Math.Sin(num13);
					num34 = num32 + num51;
					num35 = num33;
					val2.DrawLine(val4, (float)num32, (float)num33, (float)num34, (float)num35);
					num41 = num33 - num39;
					val2.DrawLine(val4, (float)num32, (float)num33, (float)num32, (float)num41);
					double num52 = num35 - num39;
					val2.DrawLine(val4, (float)num34, (float)num35, (float)num34, (float)num52);
					val2.DrawLine(val4, (float)num32, (float)num41, (float)num34, (float)num52);
					double num53 = num32 - (double)num11;
					double num54 = num33;
					double num55 = num41;
					val2.DrawLine(val3, (float)num32, (float)num33, (float)num53, (float)num54);
					val2.DrawLine(val3, (float)num32, (float)num41, (float)num53, (float)num55);
					DrawRows(num53 + 5.0, num55, num53 + 5.0, num54, num14, val2, val3);
					num48 = num53 - (double)num19;
					num49 = (num54 + num55) / 2.0;
					#if WINDOWS
					val9.FormatFlags = (StringFormatFlags)2;
					#endif
					val2.DrawString(p1.ToString(), val7, (Brush)(object)val8, (float)num48, (float)num49, val9);
					num32 = num34;
					num33 = num35;
					num34 = num32 + num50 * Math.Cos(num13);
					num35 = num33 - num50 * Math.Sin(num13);
					val2.DrawLine(val4, (float)num32, (float)num33, (float)num34, (float)num35);
					num41 = num33 - num39;
					val2.DrawLine(val4, (float)num32, (float)num33, (float)num32, (float)num41);
					num52 = num35 - num39;
					val2.DrawLine(val4, (float)num34, (float)num35, (float)num34, (float)num52);
					val2.DrawLine(val4, (float)num32, (float)num41, (float)num34, (float)num52);
					num32 = num34;
					num33 = num35;
					num34 = num32 - num51;
					num35 = num33;
					val2.DrawLine(val4, (float)num32, (float)num33, (float)num34, (float)num35);
					num41 = num33 - num39;
					val2.DrawLine(val4, (float)num32, (float)num33, (float)num32, (float)num41);
					num52 = num35 - num39;
					val2.DrawLine(val4, (float)num34, (float)num35, (float)num34, (float)num52);
					val2.DrawLine(val4, (float)num32, (float)num41, (float)num34, (float)num52);
					num32 = num34;
					num33 = num35;
					num34 = num32 - num50 * Math.Cos(num13);
					num35 = num33 + num50 * Math.Sin(num13);
					val2.DrawLine(val4, (float)num32, (float)num33, (float)num34, (float)num35);
					num41 = num33 - num39;
					val2.DrawLine(val4, (float)num32, (float)num33, (float)num32, (float)num41);
					num52 = num35 - num39;
					val2.DrawLine(val4, (float)num34, (float)num35, (float)num34, (float)num52);
					val2.DrawLine(val4, (float)num32, (float)num41, (float)num34, (float)num52);
				}
				if (vyhid2 == "круглий")
				{
					double num56 = (double)f2 * num14;
					double num57 = (double)g2 * num14;
					double num58 = (double)d2 * num14;
					double num59 = (double)p2 * num14;
					num32 = (double)num3 + num57 + (num56 - num58 / 2.0) * Math.Cos(num13);
					num33 = (double)num24 + num27 * Math.Sin(num13) - (num56 - num58 / 2.0) * Math.Sin(num13);
					num34 = (double)num3 + num57 - num58 / 2.0 + num56 * Math.Cos(num13) - 5.0;
					num35 = num33 - num58 / 2.0 * Math.Sin(num13);
					num40 = (double)num3 + num57 + (num56 + num58 / 2.0) * Math.Cos(num13);
					num41 = num33 - num58 * Math.Sin(num13);
					double num60 = num33 - num59;
					double num61 = num35 - num59;
					double num62 = num41 - num59;
					val2.DrawBezier(val4, (float)num32, (float)num33, (float)num34, (float)num35, (float)num40, (float)num41, (float)num40, (float)num41);
					val2.DrawBezier(val4, (float)num32, (float)num60, (float)num34, (float)num61, (float)num40, (float)num62, (float)num40, (float)num62);
					num34 = num34 + num58 + 10.0;
					val2.DrawBezier(val4, (float)num32, (float)num33, (float)num34, (float)num35, (float)num40, (float)num41, (float)num40, (float)num41);
					val2.DrawBezier(val4, (float)num32, (float)num60, (float)num34, (float)num61, (float)num40, (float)num62, (float)num40, (float)num62);
					val2.DrawLine(val4, (float)num32, (float)num33, (float)num32, (float)num60);
					val2.DrawLine(val4, (float)num40, (float)num41, (float)num40, (float)num62);
					double num63 = num32 - (double)num11;
					double num64 = num33;
					double num65 = num60;
					val2.DrawLine(val3, (float)num32, (float)num33, (float)num63, (float)num64);
					val2.DrawLine(val3, (float)num32, (float)num60, (float)num63, (float)num65);
					DrawRows(num63 + 5.0, num65, num63 + 5.0, num64, num14, val2, val3);
					num48 = num63 - (double)num19;
					num49 = (num64 + num65) / 2.0;
					#if WINDOWS
					val9.FormatFlags = (StringFormatFlags)2;
					#endif
					val2.DrawString(p2.ToString(), val7, (Brush)(object)val8, (float)num48, (float)num49, val9);
				}
				else if (vyhid2 == "прямокутний")
				{
					double num56 = (double)f2 * num14;
					double num57 = (double)g2 * num14;
					double num66 = (double)a2 * num14;
					double num67 = (double)b2 * num14;
					double num59 = (double)p2 * num14;
					num32 = (double)num3 + num57 + (num56 - num66 / 2.0) * Math.Cos(num13) - num67 / 2.0;
					num33 = (double)num24 + num27 * Math.Sin(num13) - (num56 - num66 / 2.0) * Math.Sin(num13);
					num34 = num32 + num67;
					num35 = num33;
					val2.DrawLine(val4, (float)num32, (float)num33, (float)num34, (float)num35);
					num41 = num33 - num59;
					val2.DrawLine(val4, (float)num32, (float)num33, (float)num32, (float)num41);
					double num52 = num35 - num59;
					val2.DrawLine(val4, (float)num34, (float)num35, (float)num34, (float)num52);
					val2.DrawLine(val4, (float)num32, (float)num41, (float)num34, (float)num52);
					double num68 = num32 - (double)num11;
					double num69 = num33;
					double num70 = num41;
					val2.DrawLine(val3, (float)num32, (float)num33, (float)num68, (float)num69);
					val2.DrawLine(val3, (float)num32, (float)num41, (float)num68, (float)num70);
					DrawRows(num68 + 5.0, num70, num68 + 5.0, num69, num14, val2, val3);
					num48 = num68 - (double)num19;
					num49 = (num69 + num70) / 2.0;
					#if WINDOWS
					val9.FormatFlags = (StringFormatFlags)2;
					#endif
					val2.DrawString(p2.ToString(), val7, (Brush)(object)val8, (float)num48, (float)num49, val9);
					num32 = num34;
					num33 = num35;
					num34 = num32 + num66 * Math.Cos(num13);
					num35 = num33 - num66 * Math.Sin(num13);
					val2.DrawLine(val4, (float)num32, (float)num33, (float)num34, (float)num35);
					num41 = num33 - num59;
					val2.DrawLine(val4, (float)num32, (float)num33, (float)num32, (float)num41);
					num52 = num35 - num59;
					val2.DrawLine(val4, (float)num34, (float)num35, (float)num34, (float)num52);
					val2.DrawLine(val4, (float)num32, (float)num41, (float)num34, (float)num52);
					num32 = num34;
					num33 = num35;
					num34 = num32 - num67;
					num35 = num33;
					val2.DrawLine(val4, (float)num32, (float)num33, (float)num34, (float)num35);
					num41 = num33 - num59;
					val2.DrawLine(val4, (float)num32, (float)num33, (float)num32, (float)num41);
					num52 = num35 - num59;
					val2.DrawLine(val4, (float)num34, (float)num35, (float)num34, (float)num52);
					val2.DrawLine(val4, (float)num32, (float)num41, (float)num34, (float)num52);
					num32 = num34;
					num33 = num35;
					num34 = num32 - num66 * Math.Cos(num13);
					num35 = num33 + num66 * Math.Sin(num13);
					val2.DrawLine(val4, (float)num32, (float)num33, (float)num34, (float)num35);
					num41 = num33 - num59;
					val2.DrawLine(val4, (float)num32, (float)num33, (float)num32, (float)num41);
					num52 = num35 - num59;
					val2.DrawLine(val4, (float)num34, (float)num35, (float)num34, (float)num52);
					val2.DrawLine(val4, (float)num32, (float)num41, (float)num34, (float)num52);
				}
				if (vyhid3 == "круглий")
				{
					double num71 = (double)f3 * num14;
					double num72 = (double)g3 * num14;
					double num73 = (double)d3 * num14;
					double num74 = (double)p3 * num14;
					num32 = (double)num3 + num72 + (num71 - num73 / 2.0) * Math.Cos(num13);
					num33 = (double)num24 + num27 * Math.Sin(num13) - (num71 - num73 / 2.0) * Math.Sin(num13);
					num34 = (double)num3 + num72 - num73 / 2.0 + num71 * Math.Cos(num13) - 5.0;
					num35 = num33 - num73 / 2.0 * Math.Sin(num13);
					num40 = (double)num3 + num72 + (num71 + num73 / 2.0) * Math.Cos(num13);
					num41 = num33 - num73 * Math.Sin(num13);
					double num75 = num33 - num74;
					double num76 = num35 - num74;
					double num77 = num41 - num74;
					val2.DrawBezier(val4, (float)num32, (float)num33, (float)num34, (float)num35, (float)num40, (float)num41, (float)num40, (float)num41);
					val2.DrawBezier(val4, (float)num32, (float)num75, (float)num34, (float)num76, (float)num40, (float)num77, (float)num40, (float)num77);
					num34 = num34 + num73 + 10.0;
					val2.DrawBezier(val4, (float)num32, (float)num33, (float)num34, (float)num35, (float)num40, (float)num41, (float)num40, (float)num41);
					val2.DrawBezier(val4, (float)num32, (float)num75, (float)num34, (float)num76, (float)num40, (float)num77, (float)num40, (float)num77);
					val2.DrawLine(val4, (float)num32, (float)num33, (float)num32, (float)num75);
					val2.DrawLine(val4, (float)num40, (float)num41, (float)num40, (float)num77);
					double num78 = num32 - (double)num11;
					double num79 = num33;
					double num80 = num75;
					val2.DrawLine(val3, (float)num32, (float)num33, (float)num78, (float)num79);
					val2.DrawLine(val3, (float)num32, (float)num75, (float)num78, (float)num80);
					DrawRows(num78 + 5.0, num80, num78 + 5.0, num79, num14, val2, val3);
					num48 = num78 - (double)num19;
					num49 = (num79 + num80) / 2.0;
					#if WINDOWS
					val9.FormatFlags = (StringFormatFlags)2;
					#endif
					val2.DrawString(p3.ToString(), val7, (Brush)(object)val8, (float)num48, (float)num49, val9);
				}
				else if (vyhid3 == "прямокутний")
				{
					double num71 = (double)f3 * num14;
					double num72 = (double)g3 * num14;
					double num81 = (double)a3 * num14;
					double num82 = (double)b3 * num14;
					double num74 = (double)p3 * num14;
					num32 = (double)num3 + num72 + (num71 - num81 / 2.0) * Math.Cos(num13) - num82 / 2.0;
					num33 = (double)num24 + num27 * Math.Sin(num13) - (num71 - num81 / 2.0) * Math.Sin(num13);
					num34 = num32 + num82;
					num35 = num33;
					val2.DrawLine(val4, (float)num32, (float)num33, (float)num34, (float)num35);
					num41 = num33 - num74;
					val2.DrawLine(val4, (float)num32, (float)num33, (float)num32, (float)num41);
					double num52 = num35 - num74;
					val2.DrawLine(val4, (float)num34, (float)num35, (float)num34, (float)num52);
					val2.DrawLine(val4, (float)num32, (float)num41, (float)num34, (float)num52);
					double num83 = num32 - (double)num11;
					double num84 = num33;
					double num85 = num41;
					val2.DrawLine(val3, (float)num32, (float)num33, (float)num83, (float)num84);
					val2.DrawLine(val3, (float)num32, (float)num41, (float)num83, (float)num85);
					DrawRows(num83 + 5.0, num85, num83 + 5.0, num84, num14, val2, val3);
					num48 = num83 - (double)num19;
					num49 = (num84 + num85) / 2.0;
					#if WINDOWS
					val9.FormatFlags = (StringFormatFlags)2;
					#endif
					val2.DrawString(p3.ToString(), val7, (Brush)(object)val8, (float)num48, (float)num49, val9);
					num32 = num34;
					num33 = num35;
					num34 = num32 + num81 * Math.Cos(num13);
					num35 = num33 - num81 * Math.Sin(num13);
					val2.DrawLine(val4, (float)num32, (float)num33, (float)num34, (float)num35);
					num41 = num33 - num74;
					val2.DrawLine(val4, (float)num32, (float)num33, (float)num32, (float)num41);
					num52 = num35 - num74;
					val2.DrawLine(val4, (float)num34, (float)num35, (float)num34, (float)num52);
					val2.DrawLine(val4, (float)num32, (float)num41, (float)num34, (float)num52);
					num32 = num34;
					num33 = num35;
					num34 = num32 - num82;
					num35 = num33;
					val2.DrawLine(val4, (float)num32, (float)num33, (float)num34, (float)num35);
					num41 = num33 - num74;
					val2.DrawLine(val4, (float)num32, (float)num33, (float)num32, (float)num41);
					num52 = num35 - num74;
					val2.DrawLine(val4, (float)num34, (float)num35, (float)num34, (float)num52);
					val2.DrawLine(val4, (float)num32, (float)num41, (float)num34, (float)num52);
					num32 = num34;
					num33 = num35;
					num34 = num32 - num81 * Math.Cos(num13);
					num35 = num33 + num81 * Math.Sin(num13);
					val2.DrawLine(val4, (float)num32, (float)num33, (float)num34, (float)num35);
					num41 = num33 - num74;
					val2.DrawLine(val4, (float)num32, (float)num33, (float)num32, (float)num41);
					num52 = num35 - num74;
					val2.DrawLine(val4, (float)num34, (float)num35, (float)num34, (float)num52);
					val2.DrawLine(val4, (float)num32, (float)num41, (float)num34, (float)num52);
				}
			}
			num32 = num3;
			num33 = (double)num24 + num27 * Math.Sin(num13);
			num34 = num32;
			num35 = num33 + num28;
			val2.DrawLine(val4, (float)num32, (float)num33, (float)num34, (float)num35);
			num33 = num35;
			num34 = num32 + num29;
			num35 = num33;
			val2.DrawLine(val4, (float)num32, (float)num33, (float)num34, (float)num35);
			num32 = num34;
			num33 = num35;
			num35 = num33 - num30;
			val2.DrawLine(val4, (float)num32, (float)num33, (float)num34, (float)num35);
			num33 = num35;
			num34 = (double)num3 + num26;
			num35 = (double)num24 + num27 * Math.Sin(num13);
			val2.DrawLine(val4, (float)num32, (float)num33, (float)num34, (float)num35);
			num32 = (double)num3 + num29;
			num33 = (double)num24 + num27 * Math.Sin(num13) + num28;
			num34 = num32 + num27 * Math.Cos(num13);
			num35 = (double)num24 + num28;
			val2.DrawLine(val4, (float)num32, (float)num33, (float)num34, (float)num35);
			num33 -= num30;
			num35 -= num30;
			val2.DrawLine(val4, (float)num32, (float)num33, (float)num34, (float)num35);
			num32 = num34;
			num33 = num35;
			num35 = num33 + num30;
			val2.DrawLine(val4, (float)num32, (float)num33, (float)num34, (float)num35);
			num34 = (double)num3 + num27 * Math.Cos(num13) + num26;
			num35 = num24;
			val2.DrawLine(val4, (float)num32, (float)num33, (float)num34, (float)num35);
			num32 = num3;
			num33 = (double)num24 + num27 * Math.Sin(num13);
			num34 = num32 - (double)num11;
			num35 = num33;
			val2.DrawLine(val3, (float)num32, (float)num33, (float)num34, (float)num35);
			num32 = num3;
			num33 = (double)num24 + num27 * Math.Sin(num13) + num28;
			num34 = num32 - (double)num11;
			num35 = num33;
			val2.DrawLine(val3, (float)num32, (float)num33, (float)num34, (float)num35);
			num32 = num3 - num11 + 5;
			num33 = (double)num24 + num27 * Math.Sin(num13);
			num34 = num32;
			num35 = num33 + num28;
			DrawRows(num32, num33, num34, num35, num14, val2, val3);
			num48 = num32 - (double)num19;
			num49 = (num33 + num35) / 2.0;
			#if WINDOWS
			val9.FormatFlags = (StringFormatFlags)2;
			#endif
			val2.DrawString(H.ToString(), val7, (Brush)(object)val8, (float)num48, (float)num49, val9);
			num32 = num3;
			num33 = (double)num24 + num27 * Math.Sin(num13) + num28;
			num34 = num32;
			num35 = num33 + (double)num11;
			val2.DrawLine(val3, (float)num32, (float)num33, (float)num34, (float)num35);
			num32 = (double)num3 + num29;
			num33 = (double)num24 + num27 * Math.Sin(num13) + num28;
			num34 = num32;
			num35 = num33 + (double)num11;
			val2.DrawLine(val3, (float)num32, (float)num33, (float)num34, (float)num35);
			num32 = num3;
			num33 = (double)num24 + num27 * Math.Sin(num13) + num28 + (double)num11 - 5.0;
			num34 = num32 + num29;
			num35 = num33;
			DrawRows(num32, num33, num34, num35, num14, val2, val3);
			num48 = (num32 + num34) / 2.0;
			num49 = num35 + (double)num19;
			#if WINDOWS
			val9.FormatFlags = (StringFormatFlags)1;
			#endif
			val2.DrawString(B.ToString(), val7, (Brush)(object)val8, (float)num48, (float)num49, val9);
			num32 = (double)num3 + num29 + num27 * Math.Cos(num13);
			num33 = (double)num24 + num28;
			num34 = num32;
			num35 = num33 + (double)num11;
			val2.DrawLine(val3, (float)num32, (float)num33, (float)num34, (float)num35);
			num32 = (double)num3 + num29;
			num33 = (double)num24 + num27 * Math.Sin(num13) + num28 + (double)num11 - 5.0;
			num34 = num32 + num27 * Math.Cos(num13);
			num35 = (double)num24 + num28 + (double)num11 - 5.0;
			DrawRows(num32, num33, num34, num35, num14, val2, val3);
			num48 = (num32 + num34) / 2.0;
			num49 = (num33 + num35) / 2.0 + 15.0 + 5.0;
			#if WINDOWS
			val9.FormatFlags = (StringFormatFlags)1;
			#endif
			val2.DrawString(L.ToString(), val7, (Brush)(object)val8, (float)num48, (float)num49, val9);
			num32 = num3;
			num33 = (double)num24 + num27 * Math.Sin(num13);
			num34 = num32;
			num35 = num33 - (double)num11;
			val2.DrawLine(val3, (float)num32, (float)num33, (float)num34, (float)num35);
			num32 = (double)num3 + num26;
			num33 = (double)num24 + num27 * Math.Sin(num13);
			num34 = num32;
			num35 = num33 - (double)num11;
			val2.DrawLine(val3, (float)num32, (float)num33, (float)num34, (float)num35);
			num32 = num3;
			num33 = (double)num24 + num27 * Math.Sin(num13) - (double)num11 + 5.0;
			num34 = num32 + num26;
			num35 = num33;
			DrawRows(num32, num33, num34, num35, num14, val2, val3);
			num48 = (num32 + num34) / 2.0;
			num49 = num35 - (double)(num19 / 2);
			#if WINDOWS
			val9.FormatFlags = (StringFormatFlags)1;
			#endif
			val2.DrawString(b.ToString(), val7, (Brush)(object)val8, (float)num48, (float)num49, val9);
			num32 = (double)num3 + num29 + num27 * Math.Cos(num13);
			num33 = (double)num24 + num28;
			num34 = num32 + (double)num11;
			num35 = num33;
			val2.DrawLine(val3, (float)num32, (float)num33, (float)num34, (float)num35);
			num32 = (double)num3 + num29 + num27 * Math.Cos(num13);
			num33 = (double)num24 + num28 - num30;
			num34 = num32 + (double)num11;
			num35 = num33;
			val2.DrawLine(val3, (float)num32, (float)num33, (float)num34, (float)num35);
			num32 = (double)num3 + num29 + num27 * Math.Cos(num13) + (double)num11 - 5.0;
			num33 = (double)num24 + num28 - num30;
			num34 = num32;
			num35 = num33 + num30;
			DrawRows(num32, num33, num34, num35, num14, val2, val3);
			num48 = num32 + (double)num19 + 5.0;
			num49 = (num33 + num35) / 2.0;
			#if WINDOWS
			val9.FormatFlags = (StringFormatFlags)2;
			#endif
			val2.DrawString(h.ToString(), val7, (Brush)(object)val8, (float)num48, (float)num49, val9);
			double num86 = Math.Ceiling(Math.Sqrt((B - b) * (B - b) + (H - h) * (H - h)));
			num32 = (double)num3 + num29 + num27 * Math.Cos(num13);
			num33 = (double)num24 + num28 - num30;
			num40 = (double)num3 + num26 + num27 * Math.Cos(num13);
			num41 = num24;
			double num87 = Math.Atan(((double)H - (double)h) / ((double)B - (double)b));
			num34 = num32 + (double)num11 * Math.Sin(num87);
			num35 = num33 - (double)num11 * Math.Cos(num87);
			val2.DrawLine(val3, (float)num32, (float)num33, (float)num34, (float)num35);
			double num88 = num34;
			double num89 = num35;
			num32 = num40;
			num33 = num41;
			num34 = num32 + (double)num11 * Math.Sin(num87);
			num35 = num33 - (double)num11 * Math.Cos(num87);
			val2.DrawLine(val3, (float)num32, (float)num33, (float)num34, (float)num35);
			double num90 = num34;
			double num91 = num35;
			num32 = num90 - 5.0 * Math.Sin(num87);
			num33 = num91 + 5.0 * Math.Cos(num87);
			num34 = num88 - 5.0 * Math.Sin(num87);
			num35 = num89 + 5.0 * Math.Cos(num87);
			DrawRows(num32, num33, num34, num35, num14, val2, val3);
			num48 = (num32 + num34) / 2.0 + (double)num19;
			num49 = (num33 + num35) / 2.0 - (double)(num19 / 2);
			#if WINDOWS
			val9.FormatFlags = (StringFormatFlags)1;
			#endif
			val2.DrawString(num86.ToString(), val7, (Brush)(object)val8, (float)num48, (float)num49, val9);
			double num92 = Math.Atan(((double)H - (double)h) / ((double)B - (double)b));
			double num93 = Math.Min(num30 / 2.0, 20.0);
			num32 = (double)num3 + num29;
			num33 = (double)num24 + num27 * Math.Sin(num13) + num28 - num30 + num93;
			num40 = num32 - num93 * Math.Cos(num92);
			num41 = (double)num24 + num27 * Math.Sin(num13) + num28 - num30 - num93 * Math.Sin(num92);
			num34 = num32 - num93;
			num35 = (num33 + num41) / 2.0;
			val2.DrawBezier(val3, (float)num40, (float)num41, (float)num34, (float)num35, (float)num32, (float)num33, (float)num32, (float)num33);
			num92 = Math.Round(num92 * 180.0 / Math.PI, MidpointRounding.AwayFromZero) + 90.0;
			#if WINDOWS
			val9.FormatFlags = (StringFormatFlags)1;
			#endif
			val2.DrawString(num92 + "°", val7, (Brush)(object)val8, (float)(num34 - 10.0), (float)num35, val9);
			#if WINDOWS
			val9.FormatFlags = (StringFormatFlags)2;
			#endif
			if (zhyrFiltr == "так")
			{
				double num94 = 100.0;
				double num95 = 20.0;
				double num96 = 20.0;
				double num97 = 20.0;
				double num98 = 60.0;
				double num99 = 70.0;
				double num100 = 10.0;
				double num101 = 50.0;
				double num102 = 60.0;
				double num103 = 70.0;
				double num104 = 10.0;
				double num105 = 45.0;
				double num106 = 30.0;
				double num107 = 20.0;
				double num108 = num94 * num14;
				double num109 = num95 * num14;
				double num110 = num97 * num14;
				double num111 = num96 * num14;
				double num112 = num101 * num14;
				double num113 = num102 * num14;
				double num114 = num103 * num14;
				double num115 = num104 * num14;
				double num116 = num98 * num14;
				double num117 = num99 * num14;
				double num118 = num100 * num14;
				double num119 = num105 * num14;
				double num120 = num106 * num14;
				double num121 = num107 * num14;
				num32 = num3;
				num33 = (double)num24 + num27 * Math.Sin(num13) + num28;
				num34 = num32 + num108;
				num35 = num33;
				val2.DrawLine(val5, (float)num32, (float)num33, (float)num34, (float)num35);
				num32 = num34;
				num33 = num35;
				num34 = num32;
				num35 = num33 - num109;
				val2.DrawLine(val5, (float)num32, (float)num33, (float)num34, (float)num35);
				if (typeUpperStrip == 2)
				{
					num32 = (double)num3 + num31;
					num33 = (double)num24 + num27 * Math.Sin(num13);
					num34 = num32;
					num35 = num33 + (double)num11;
					val2.DrawLine(val3, (float)num32, (float)num33, (float)num34, (float)num35);
					num32 = num3;
					num33 = (double)num24 + num27 * Math.Sin(num13) + (double)num11 - 5.0;
					num35 -= 5.0;
					DrawRows(num32, num33, num34, num35, num14, val2, val3);
					num48 = (num32 + num34) / 2.0;
					num49 = num35 + (double)num19 + 3.0;
					#if WINDOWS
					val9.FormatFlags = (StringFormatFlags)1;
					#endif
					val2.DrawString(G.ToString(), val7, (Brush)(object)val8, (float)num48, (float)num49, val9);
					num32 = (double)num3 + num31;
					num33 = (double)num24 + num27 * Math.Sin(num13);
					num34 = num32 - num110;
					num35 = num33;
					val2.DrawLine(val5, (float)num32, (float)num33, (float)num34, (float)num35);
					num32 = (double)num3 + num31;
					num33 = (double)num24 + num27 * Math.Sin(num13);
					num34 = num32;
					num35 = num33 + num116;
					val2.DrawLine(val5, (float)num32, (float)num33, (float)num34, (float)num35);
					num32 = (double)num3 + num108;
					num33 = (double)num24 + num27 * Math.Sin(num13) + num28 - num109;
					num34 = (double)num3 + num31;
					num35 = (double)num24 + num27 * Math.Sin(num13) + num116;
					double num122 = 1E-05;
					double num123 = Math.Atan((num33 - num35) / (num34 - num32));
					double num124 = Math.Atan((num33 - num35 + num118) / (num34 - num32 - num118));
					num17 = 0.0;
					while (num124 - num123 > num122)
					{
						num17 = (num123 + num124) / 2.0;
						double num125 = Math.Tan(num123) - (num33 - num35 + num118 * Math.Cos(num123)) / (num34 - num32 - num118 * Math.Sin(num123));
						double num126 = Math.Tan(num17) - (num33 - num35 + num118 * Math.Cos(num17)) / (num34 - num32 - num118 * Math.Sin(num17));
						if (num125 * num126 < 0.0)
						{
							num124 = num17;
						}
						else
						{
							num123 = num17;
						}
					}
					num34 = num32 - num111 * Math.Sin(num17);
					num35 = num33 - num111 * Math.Cos(num17);
					val2.DrawLine(val5, (float)num32, (float)num33, (float)num34, (float)num35);
					num32 = (double)num3 + num31;
					num33 = (double)num24 + num27 * Math.Sin(num13) + num116;
					num34 = num32 - num117 * Math.Cos(num17);
					num35 = num33 + num117 * Math.Sin(num17);
					val2.DrawLine(val5, (float)num32, (float)num33, (float)num34, (float)num35);
					num32 = num34;
					num33 = num35;
					num34 = num32 - num118 * Math.Sin(num17);
					num35 = num33 - num118 * Math.Cos(num17);
					val2.DrawLine(val5, (float)num32, (float)num33, (float)num34, (float)num35);
					double num127 = 40.0;
					double num128 = (double)G - num94 - num100 * Math.Sin(num17);
					double num129 = (double)H - num95 - num98 + num100 * Math.Cos(num17);
					l = (int)Math.Round(Math.Sqrt(num128 * num128 + num129 * num129) - num127);
				}
				else if (typeUpperStrip == 1)
				{
					num32 = (double)num3 + num26;
					num33 = (double)num24 + num27 * Math.Sin(num13);
					num34 = num32 - num111;
					num35 = num33;
					val2.DrawLine(val5, (float)num32, (float)num33, (float)num34, (float)num35);
					num34 = num32 + num112 * Math.Cos(num87);
					num35 = num33 + num112 * Math.Sin(num87);
					val2.DrawLine(val5, (float)num32, (float)num33, (float)num34, (float)num35);
					num32 = num34;
					num33 = num35;
					num34 = num32;
					num35 = num33 + num113;
					val2.DrawLine(val5, (float)num32, (float)num33, (float)num34, (float)num35);
					num32 = (double)num3 + num108;
					num33 = (double)num24 + num27 * Math.Sin(num13) + num28 - num109;
					num34 = (double)num3 + num26 + num112 * Math.Cos(num87);
					num35 = (double)num24 + num27 * Math.Sin(num13) + num112 * Math.Sin(num87) + num113;
					double num130 = 1E-05;
					double num131 = Math.Atan((num33 - num35) / (num34 - num32));
					double num132 = Math.Atan((num33 - num35 + num115) / (num34 - num32 - num115));
					num17 = 0.0;
					while (num132 - num131 > num130)
					{
						num17 = (num131 + num132) / 2.0;
						double num133 = Math.Tan(num131) - (num33 - num35 + num115 * Math.Cos(num131)) / (num34 - num32 - num115 * Math.Sin(num131));
						double num134 = Math.Tan(num17) - (num33 - num35 + num115 * Math.Cos(num17)) / (num34 - num32 - num115 * Math.Sin(num17));
						if (num133 * num134 < 0.0)
						{
							num132 = num17;
						}
						else
						{
							num131 = num17;
						}
					}
					num34 = num32 - num111 * Math.Sin(num17);
					num35 = num33 - num111 * Math.Cos(num17);
					val2.DrawLine(val5, (float)num32, (float)num33, (float)num34, (float)num35);
					num32 = (double)num3 + num26 + num112 * Math.Cos(num87);
					num33 = (double)num24 + num27 * Math.Sin(num13) + num112 * Math.Sin(num87) + num113;
					num34 = num32 - num114 * Math.Cos(num17);
					num35 = num33 + num114 * Math.Sin(num17);
					val2.DrawLine(val5, (float)num32, (float)num33, (float)num34, (float)num35);
					num32 = num34;
					num33 = num35;
					num34 = num32 - num115 * Math.Sin(num17);
					num35 = num33 - num115 * Math.Cos(num17);
					val2.DrawLine(val5, (float)num32, (float)num33, (float)num34, (float)num35);
					double num135 = 40.0;
					double num136 = (double)b - num94 + num101 * Math.Cos(num87) - num104 * Math.Sin(num17);
					double num137 = (double)H - num95 - num101 * Math.Sin(num87) - num102 + num104 * Math.Cos(num17);
					l = (int)Math.Round(Math.Sqrt(num136 * num136 + num137 * num137) - num135);
				}
				betaGradus = 90 - (int)Math.Round(num17 * 180.0 / Math.PI);
				double num138 = 6.0;
				num32 = (double)num3 + num108 + num138 * Math.Cos(num17);
				num33 = (double)num24 + num27 * Math.Sin(num13) + num28 - num109 - num138 * Math.Sin(num17);
				num34 = num32 - num119 * Math.Sin(num17);
				num35 = num33 - num119 * Math.Cos(num17);
				val2.DrawLine(val5, (float)num32, (float)num33, (float)num34, (float)num35);
				num32 = (double)num3 + num108 + num138 * Math.Cos(num17);
				num33 = (double)num24 + num27 * Math.Sin(num13) + num28 - num109 - num138 * Math.Sin(num17);
				num34 = num32 + num120 * Math.Cos(num17);
				num35 = num33 - num120 * Math.Sin(num17);
				val2.DrawLine(val5, (float)num32, (float)num33, (float)num34, (float)num35);
				num32 = (double)num3 + num108 + num138 * Math.Cos(num17) - num119 * Math.Sin(num17);
				num33 = (double)num24 + num27 * Math.Sin(num13) + num28 - num109 - num138 * Math.Sin(num17) - num119 * Math.Cos(num17);
				num34 = num32 + num121 * Math.Cos(num17);
				num35 = num33 - num121 * Math.Sin(num17);
				val2.DrawLine(val5, (float)num32, (float)num33, (float)num34, (float)num35);
				double num139 = (double)l * num14 - num138;
				double num140 = 4.0;
				double num141 = num105 * num14 - 2.0 * num140;
				num32 = (double)num3 + num108 + num138 * Math.Cos(num17) - num140 * Math.Sin(num17) + num138 * Math.Cos(num17);
				num33 = (double)num24 + num27 * Math.Sin(num13) + num28 - num109 - num138 * Math.Sin(num17) - num140 * Math.Cos(num17) - num138 * Math.Sin(num17);
				num34 = num32 - num141 * Math.Sin(num17);
				num35 = num33 - num141 * Math.Cos(num17);
				val2.DrawLine(val4, (float)num32, (float)num33, (float)num34, (float)num35);
				num32 = (double)num3 + num108 + num138 * Math.Cos(num17) - num140 * Math.Sin(num17) + num138 * Math.Cos(num17);
				num33 = (double)num24 + num27 * Math.Sin(num13) + num28 - num109 - num138 * Math.Sin(num17) - num140 * Math.Cos(num17) - num138 * Math.Sin(num17);
				num34 = num32 + num139 * Math.Cos(num17);
				num35 = num33 - num139 * Math.Sin(num17);
				val2.DrawLine(val4, (float)num32, (float)num33, (float)num34, (float)num35);
				num32 = (double)num3 + num108 + num138 * Math.Cos(num17) - num140 * Math.Sin(num17) + num138 * Math.Cos(num17) - num141 * Math.Sin(num17);
				num33 = (double)num24 + num27 * Math.Sin(num13) + num28 - num109 - num138 * Math.Sin(num17) - num140 * Math.Cos(num17) - num138 * Math.Sin(num17) - num141 * Math.Cos(num17);
				num34 = num32 + num139 * Math.Cos(num17);
				num35 = num33 - num139 * Math.Sin(num17);
				val2.DrawLine(val4, (float)num32, (float)num33, (float)num34, (float)num35);
				num32 = (double)num3 + num108 + num138 * Math.Cos(num17) - num140 * Math.Sin(num17) + num138 * Math.Cos(num17) + num139 * Math.Cos(num17);
				num33 = (double)num24 + num27 * Math.Sin(num13) + num28 - num109 - num138 * Math.Sin(num17) - num140 * Math.Cos(num17) - num138 * Math.Sin(num17) - num139 * Math.Sin(num17);
				num34 = (double)num3 + num108 + num138 * Math.Cos(num17) - num140 * Math.Sin(num17) + num138 * Math.Cos(num17) - num141 * Math.Sin(num17) + num139 * Math.Cos(num17);
				num35 = (double)num24 + num27 * Math.Sin(num13) + num28 - num109 - num138 * Math.Sin(num17) - num140 * Math.Cos(num17) - num138 * Math.Sin(num17) - num141 * Math.Cos(num17) - num139 * Math.Sin(num17);
				val2.DrawLine(val4, (float)num32, (float)num33, (float)num34, (float)num35);
				double num142 = 1.5;
				double num143 = 0.0;
				double num144 = 0.0;
				double num145 = 0.0;
				double num146 = 0.0;
				num108 = num94 * num142;
				num109 = num95 * num142;
				num110 = num97 * num142;
				num111 = num96 * num142;
				num112 = num101 * num142;
				num113 = num102 * num142;
				num114 = num103 * num142;
				num115 = num104 * num142;
				num116 = num98 * num142;
				num117 = num99 * num142;
				num118 = num100 * num142;
				num31 = (double)G * num142;
				num28 = (double)H * num142;
				num30 = (double)h * num142;
				num29 = (double)B * num142;
				num26 = (double)b * num142;
				if (typeUpperStrip == 2)
				{
					num145 = num - num4;
					num146 = (double)num25 + num20 * num14;
					num143 = (double)(num - num4) - num108;
					num144 = num146 + num116 + num117 + num109 + num110;
				}
				else if (typeUpperStrip == 1)
				{
					num145 = (double)(num - num4) - num112 * Math.Cos(num17);
					num146 = (double)num25 + num20 * num14 + 40.0;
					num143 = (double)(num - num4) - num108;
					num144 = num146 + num112 * Math.Sin(num17) + num113 + num114 + num109 + num110;
				}
				num32 = num143;
				num33 = num144;
				num34 = num32 + num108;
				num35 = num33;
				val2.DrawLine(val5, (float)num32, (float)num33, (float)num34, (float)num35);
				num32 = num143;
				num33 = num144;
				num34 = num32;
				num35 = num33 + (double)num12;
				num88 = num34;
				num89 = num35;
				val2.DrawLine(val3, (float)num32, (float)num33, (float)num34, (float)num35);
				num32 += num108;
				num34 = num32;
				num90 = num34;
				num91 = num35;
				val2.DrawLine(val3, (float)num32, (float)num33, (float)num34, (float)num35);
				num32 = num88;
				num33 = num89 - 5.0;
				num34 = num90;
				num35 = num91 - 5.0;
				DrawRows(num32, num33, num34, num35, num14, val2, val3);
				num48 = (num88 + num90) / 2.0;
				num49 = num89 + (double)num19;
				#if WINDOWS
				val9.FormatFlags = (StringFormatFlags)1;
				#endif
				val2.DrawString(num94.ToString(), val7, (Brush)(object)val8, (float)num48, (float)num49, val9);
				num32 = num143 + num108;
				num33 = num144;
				num34 = num32;
				num35 = num33 - num109;
				val2.DrawLine(val5, (float)num32, (float)num33, (float)num34, (float)num35);
				num34 = num32 - (double)num12;
				num35 = num33;
				val2.DrawLine(val3, (float)num32, (float)num33, (float)num34, (float)num35);
				num33 = num144 - num109;
				num34 = num32 - (double)num12;
				num35 = num33;
				val2.DrawLine(val3, (float)num32, (float)num33, (float)num34, (float)num35);
				num32 = num34 + 5.0;
				num33 = num144;
				num34 = num32;
				num35 = num33 - num109;
				DrawRows(num34, num35, num32, num33, num14, val2, val3);
				num48 = num32 - (double)num19 - 3.0;
				num49 = (num33 + num35) / 2.0;
				#if WINDOWS
				val9.FormatFlags = (StringFormatFlags)1;
				#endif
				val2.DrawString(num95.ToString(), val7, (Brush)(object)val8, (float)num48, (float)num49, val9);
				num32 = num145;
				num33 = num146;
				num34 = num32 - num111;
				num35 = num33;
				val2.DrawLine(val5, (float)num32, (float)num33, (float)num34, (float)num35);
				num34 = num32;
				num35 = num33 - (double)num12;
				val2.DrawLine(val3, (float)num32, (float)num33, (float)num34, (float)num35);
				num32 = num34 - num111;
				num34 = num32;
				val2.DrawLine(val3, (float)num32, (float)num33, (float)num34, (float)num35);
				num32 = num145;
				num33 = num146 - (double)num12 + 5.0;
				num34 = num32 - num111;
				num35 = num33;
				DrawRows(num34, num35, num32, num33, num14, val2, val3);
				num48 = (num32 + num34) / 2.0;
				num49 = num33 - (double)num19 - 3.0;
				#if WINDOWS
				val9.FormatFlags = (StringFormatFlags)1;
				#endif
				val2.DrawString(num96.ToString(), val7, (Brush)(object)val8, (float)num48, (float)num49, val9);
				if (typeUpperStrip == 2)
				{
					num32 = num145;
					num33 = num146;
					num34 = num32;
					num35 = num33 + num116;
					val2.DrawLine(val5, (float)num32, (float)num33, (float)num34, (float)num35);
					num34 = num32 + (double)num12;
					num35 = num33;
					val2.DrawLine(val3, (float)num32, (float)num33, (float)num34, (float)num35);
					num32 = num145;
					num33 = num146 + num116;
					num34 = num32 + (double)num12;
					num35 = num33;
					val2.DrawLine(val3, (float)num32, (float)num33, (float)num34, (float)num35);
					num32 = num145 + (double)num12 - 5.0;
					num33 = num146;
					num34 = num32;
					num35 = num33 + num116;
					DrawRows(num32, num33, num34, num35, num14, val2, val3);
					num48 = num32 + (double)num19;
					num49 = (num33 + num35) / 2.0;
					#if WINDOWS
					val9.FormatFlags = (StringFormatFlags)1;
					#endif
					val2.DrawString(num98.ToString(), val7, (Brush)(object)val8, (float)num48, (float)num49, val9);
					num32 = num143 + num108;
					num33 = num144 - num109;
					num34 = num32 - num111 * Math.Sin(num17);
					num35 = num33 - num111 * Math.Cos(num17);
					val2.DrawLine(val5, (float)num32, (float)num33, (float)num34, (float)num35);
					num34 = num32 + (double)num12 * Math.Cos(num17);
					num35 = num33 - (double)num12 * Math.Sin(num17);
					val2.DrawLine(val3, (float)num32, (float)num33, (float)num34, (float)num35);
					num32 -= num110 * Math.Sin(num17);
					num33 -= num110 * Math.Cos(num17);
					num34 = num32 + (double)num12 * Math.Cos(num17);
					num35 = num33 - (double)num12 * Math.Sin(num17);
					val2.DrawLine(val3, (float)num32, (float)num33, (float)num34, (float)num35);
					num32 = num143 + num108 + (double)(num12 - 5) * Math.Cos(num17);
					num33 = num144 - num109 - (double)(num12 - 5) * Math.Sin(num17);
					num34 -= 5.0 * Math.Cos(num17);
					num35 += 5.0 * Math.Sin(num17);
					DrawRows(num34, num35, num32, num33, num14, val2, val3);
					num48 = (num32 + num34) / 2.0 + (double)num19;
					num49 = (num33 + num35) / 2.0 - (double)(num19 / 2);
					#if WINDOWS
					val9.FormatFlags = (StringFormatFlags)1;
					#endif
					val2.DrawString(num96.ToString(), val7, (Brush)(object)val8, (float)num48, (float)num49, val9);
					num32 = num143 + num108;
					num33 = num144 - num109;
					num34 = num32 + num110 * Math.Sin(num17);
					num35 = num33 + num110 * Math.Cos(num17);
					val2.DrawLine(val3, (float)num32, (float)num33, (float)num34, (float)num35);
					double num147 = 3.0 * num111 * Math.Sin(num17) / 4.0;
					double num148 = 3.0 * num111 * Math.Cos(num17) / 4.0;
					num32 = num143 + num108;
					num33 = num144 - num109 + num148;
					num40 = num32 + num147;
					num41 = num33;
					num34 = (num32 + num40) / 2.0;
					num35 = (num33 + num41) / 2.0 + 5.0;
					val2.DrawBezier(val3, (float)num32, (float)num33, (float)num34, (float)num35, (float)num40, (float)num41, (float)num40, (float)num41);
					string text2 = Math.Round(num17 * 180.0 / Math.PI) + "°";
					val2.DrawString(text2, val7, (Brush)(object)val8, (float)(num34 + 3.0), (float)(num35 + (double)num19), val9);
					num32 = num145;
					num33 = num146 + num116;
					num34 = num32 - num117 * Math.Cos(num17);
					num35 = num33 + num117 * Math.Sin(num17);
					val2.DrawLine(val5, (float)num32, (float)num33, (float)num34, (float)num35);
					num34 = num32 - (double)num12 * Math.Sin(num17);
					num35 = num33 - (double)num12 * Math.Cos(num17);
					num88 = num34;
					num89 = num35;
					val2.DrawLine(val3, (float)num32, (float)num33, (float)num34, (float)num35);
					num32 = num145 - num117 * Math.Cos(num17);
					num33 = num146 + num116 + num117 * Math.Sin(num17);
					num34 = num32 - (double)num12 * Math.Sin(num17);
					num35 = num33 - (double)num12 * Math.Cos(num17);
					val2.DrawLine(val3, (float)num32, (float)num33, (float)num34, (float)num35);
					num32 = num88 + 5.0 * Math.Sin(num17);
					num33 = num89 + 5.0 * Math.Cos(num17);
					num34 += 5.0 * Math.Sin(num17);
					num35 += 5.0 * Math.Cos(num17);
					DrawRows(num34, num35, num32, num33, num14, val2, val3);
					num48 = (num32 + num34) / 2.0 - (double)num19;
					num49 = (num33 + num35) / 2.0 - (double)(num19 / 2);
					#if WINDOWS
					val9.FormatFlags = (StringFormatFlags)1;
					#endif
					val2.DrawString(num99.ToString(), val7, (Brush)(object)val8, (float)num48, (float)num49, val9);
					num32 = num145;
					num33 = num146 + num116;
					num34 = num32;
					num35 = num33 + num117 * Math.Sin(num17);
					val2.DrawLine(val3, (float)num32, (float)num33, (float)num34, (float)num35);
					num147 = 3.0 * num117 * Math.Cos(num17) / 8.0;
					num148 = 3.0 * num117 * Math.Sin(num17) / 8.0;
					num32 = num145;
					num33 = num146 + num116 + num148;
					num40 = num32 - num147;
					num41 = num33;
					num34 = (num32 + num40) / 2.0;
					num35 = (num33 + num41) / 2.0 + 5.0;
					val2.DrawBezier(val3, (float)num32, (float)num33, (float)num34, (float)num35, (float)num40, (float)num41, (float)num40, (float)num41);
					text2 = Math.Round((Math.PI / 2.0 - num17) * 180.0 / Math.PI) + "°";
					val2.DrawString(text2, val7, (Brush)(object)val8, (float)(num34 + 3.0), (float)(num35 + (double)num19), val9);
					num32 = num145 - num117 * Math.Cos(num17);
					num33 = num146 + num116 + num117 * Math.Sin(num17);
					num34 = num32 - num118 * Math.Sin(num17);
					num35 = num33 - num118 * Math.Cos(num17);
					val2.DrawLine(val5, (float)num32, (float)num33, (float)num34, (float)num35);
					num34 = num32 - (double)num12 * Math.Cos(num17);
					num35 = num33 + (double)num12 * Math.Sin(num17);
					num88 = num34;
					num89 = num35;
					val2.DrawLine(val3, (float)num32, (float)num33, (float)num34, (float)num35);
					num32 -= num118 * Math.Sin(num17);
					num33 -= num118 * Math.Cos(num17);
					num34 = num32 - (double)num12 * Math.Cos(num17);
					num35 = num33 + (double)num12 * Math.Sin(num17);
					val2.DrawLine(val3, (float)num32, (float)num33, (float)num34, (float)num35);
					num32 = num88 + 5.0 * Math.Cos(num17);
					num33 = num89 - 5.0 * Math.Sin(num17);
					num34 += 5.0 * Math.Cos(num17);
					num35 -= 5.0 * Math.Sin(num17);
					DrawRows(num32, num33, num34, num35, num14, val2, val3);
					num48 = (num32 + num34) / 2.0 - (double)num19;
					num49 = (num33 + num35) / 2.0 + (double)(num19 / 2);
					#if WINDOWS
					val9.FormatFlags = (StringFormatFlags)1;
					#endif
					val2.DrawString(num100.ToString(), val7, (Brush)(object)val8, (float)num48, (float)num49, val9);
				}
				else if (typeUpperStrip == 1)
				{
					num32 = num145;
					num33 = num146;
					num34 = num32 + num112 * Math.Cos(num87);
					num35 = num33 + num112 * Math.Sin(num87);
					val2.DrawLine(val5, (float)num32, (float)num33, (float)num34, (float)num35);
					num34 = num32 + (double)num12 * Math.Sin(num87);
					num35 = num33 - (double)num12 * Math.Cos(num87);
					num88 = num34;
					num89 = num35;
					val2.DrawLine(val3, (float)num32, (float)num33, (float)num34, (float)num35);
					num32 += num112 * Math.Cos(num87);
					num33 += num112 * Math.Sin(num87);
					num34 = num32 + (double)num12 * Math.Sin(num87);
					num35 = num33 - (double)num12 * Math.Cos(num87);
					val2.DrawLine(val3, (float)num32, (float)num33, (float)num34, (float)num35);
					num32 = num88 - 5.0 * Math.Sin(num87);
					num33 = num89 + 5.0 * Math.Cos(num87);
					num34 -= 5.0 * Math.Sin(num87);
					num35 += 5.0 * Math.Cos(num87);
					DrawRows(num32, num33, num34, num35, num14, val2, val3);
					num48 = (num32 + num34) / 2.0 + (double)num19;
					num49 = (num33 + num35) / 2.0 - (double)(num19 / 2);
					#if WINDOWS
					val9.FormatFlags = (StringFormatFlags)1;
					#endif
					val2.DrawString(num101.ToString(), val7, (Brush)(object)val8, (float)num48, (float)num49, val9);
					num32 = num145 + num112 * Math.Cos(num87);
					num33 = num146 + num112 * Math.Sin(num87);
					num34 = num32;
					num35 = num33 + num113;
					double num149 = num34;
					double num150 = num35;
					val2.DrawLine(val5, (float)num32, (float)num33, (float)num34, (float)num35);
					num34 = num32 + (double)num12;
					num35 = num33;
					num88 = num34;
					num89 = num35;
					val2.DrawLine(val3, (float)num32, (float)num33, (float)num34, (float)num35);
					num32 = num145 + num112 * Math.Cos(num87);
					num33 = num146 + num112 * Math.Sin(num87) + num113;
					num34 = num32 + (double)num12;
					num35 = num33;
					val2.DrawLine(val3, (float)num32, (float)num33, (float)num34, (float)num35);
					num32 = num88 - 5.0;
					num33 = num89;
					num34 -= 5.0;
					DrawRows(num32, num33, num34, num35, num14, val2, val3);
					num48 = num32 + (double)num19;
					num49 = (num33 + num35) / 2.0;
					#if WINDOWS
					val9.FormatFlags = (StringFormatFlags)1;
					#endif
					val2.DrawString(num102.ToString(), val7, (Brush)(object)val8, (float)num48, (float)num49, val9);
					num32 = num143 + num108;
					num33 = num144 - num109;
					num34 = num32 - num111 * Math.Sin(num17);
					num35 = num33 - num111 * Math.Cos(num17);
					val2.DrawLine(val5, (float)num32, (float)num33, (float)num34, (float)num35);
					num34 = num32 + (double)num12 * Math.Cos(num17);
					num35 = num33 - (double)num12 * Math.Sin(num17);
					num88 = num34;
					num89 = num35;
					val2.DrawLine(val3, (float)num32, (float)num33, (float)num34, (float)num35);
					num32 -= num111 * Math.Sin(num17);
					num33 -= num111 * Math.Cos(num17);
					num34 = num32 + (double)num12 * Math.Cos(num17);
					num35 = num33 - (double)num12 * Math.Sin(num17);
					val2.DrawLine(val3, (float)num32, (float)num33, (float)num34, (float)num35);
					num32 = num88 - 5.0 * Math.Cos(num17);
					num33 = num89 + 5.0 * Math.Sin(num17);
					num34 -= 5.0 * Math.Cos(num17);
					num35 += 5.0 * Math.Sin(num17);
					DrawRows(num34, num35, num32, num33, num14, val2, val3);
					num48 = (num32 + num34) / 2.0 + (double)num19;
					num49 = (num33 + num35) / 2.0 - (double)(num19 / 2);
					#if WINDOWS
					val9.FormatFlags = (StringFormatFlags)1;
					#endif
					val2.DrawString(num96.ToString(), val7, (Brush)(object)val8, (float)num48, (float)num49, val9);
					num32 = num143 + num108;
					num33 = num144 - num109;
					num34 = num32 + num111 * Math.Sin(num17);
					num35 = num33 + num111 * Math.Cos(num17);
					val2.DrawLine(val3, (float)num32, (float)num33, (float)num34, (float)num35);
					double num151 = 3.0 * num111 * Math.Sin(num17) / 4.0;
					double num152 = 3.0 * num111 * Math.Cos(num17) / 4.0;
					num32 = num143 + num108;
					num33 = num144 - num109 + num152;
					num40 = num32 + num151;
					num41 = num33;
					num34 = (num32 + num40) / 2.0 + 3.0;
					num35 = (num33 + num41) / 2.0 + 5.0 + 3.0;
					val2.DrawBezier(val3, (float)num32, (float)num33, (float)num34, (float)num35, (float)num40, (float)num41, (float)num40, (float)num41);
					string text3 = Math.Round(num17 * 180.0 / Math.PI) + "°";
					val2.DrawString(text3, val7, (Brush)(object)val8, (float)(num34 + 3.0), (float)(num35 + (double)num19), val9);
					num32 = num149;
					num33 = num150;
					num34 = num32 - num114 * Math.Cos(num17);
					num35 = num33 + num114 * Math.Sin(num17);
					val2.DrawLine(val5, (float)num32, (float)num33, (float)num34, (float)num35);
					num34 = num32 - (double)num12 * Math.Sin(num17);
					num35 = num33 - (double)num12 * Math.Cos(num17);
					num88 = num34;
					num89 = num35;
					val2.DrawLine(val3, (float)num32, (float)num33, (float)num34, (float)num35);
					num32 = num149 - num114 * Math.Cos(num17);
					num33 = num150 + num114 * Math.Sin(num17);
					num34 = num32 - (double)num12 * Math.Sin(num17);
					num35 = num33 - (double)num12 * Math.Cos(num17);
					val2.DrawLine(val3, (float)num32, (float)num33, (float)num34, (float)num35);
					num32 = num88 + 5.0 * Math.Sin(num17);
					num33 = num89 + 5.0 * Math.Cos(num17);
					num34 += 5.0 * Math.Sin(num17);
					num35 += 5.0 * Math.Cos(num17);
					DrawRows(num34, num35, num32, num33, num14, val2, val3);
					num48 = (num32 + num34) / 2.0 - (double)num19;
					num49 = (num33 + num35) / 2.0 - (double)(num19 / 2);
					#if WINDOWS
					val9.FormatFlags = (StringFormatFlags)1;
					#endif
					val2.DrawString(num103.ToString(), val7, (Brush)(object)val8, (float)num48, (float)num49, val9);
					num32 = num149;
					num33 = num150;
					num34 = num32;
					num35 = num33 + num114 * Math.Sin(num17);
					val2.DrawLine(val3, (float)num32, (float)num33, (float)num34, (float)num35);
					num151 = 3.0 * num114 * Math.Cos(num17) / 8.0;
					num152 = 3.0 * num114 * Math.Sin(num17) / 8.0;
					num32 = num149;
					num33 = num150 + num152;
					num40 = num32 - num151;
					num41 = num33;
					num34 = (num32 + num40) / 2.0;
					num35 = (num33 + num41) / 2.0 + 5.0;
					val2.DrawBezier(val3, (float)num32, (float)num33, (float)num34, (float)num35, (float)num40, (float)num41, (float)num40, (float)num41);
					text3 = Math.Round((Math.PI / 2.0 - num17) * 180.0 / Math.PI) + "°";
					val2.DrawString(text3, val7, (Brush)(object)val8, (float)(num34 + 3.0), (float)(num35 + (double)num19), val9);
					num32 = num145 + num112 * Math.Cos(num87) - num114 * Math.Cos(num17);
					num33 = num146 + num112 * Math.Sin(num87) + num113 + num114 * Math.Sin(num17);
					num34 = num32 - num115 * Math.Sin(num17);
					num35 = num33 - num115 * Math.Cos(num17);
					val2.DrawLine(val5, (float)num32, (float)num33, (float)num34, (float)num35);
					num34 = num32 - (double)num12 * Math.Cos(num17);
					num35 = num33 + (double)num12 * Math.Sin(num17);
					num88 = num34;
					num89 = num35;
					val2.DrawLine(val3, (float)num32, (float)num33, (float)num34, (float)num35);
					num32 -= num115 * Math.Sin(num17);
					num33 -= num115 * Math.Cos(num17);
					num34 = num32 - (double)num12 * Math.Cos(num17);
					num35 = num33 + (double)num12 * Math.Sin(num17);
					val2.DrawLine(val3, (float)num32, (float)num33, (float)num34, (float)num35);
					num32 = num88 + 5.0 * Math.Cos(num17);
					num33 = num89 - 5.0 * Math.Sin(num17);
					num34 += 5.0 * Math.Cos(num17);
					num35 -= 5.0 * Math.Sin(num17);
					DrawRows(num32, num33, num34, num35, num14, val2, val3);
					num48 = (num32 + num34) / 2.0 - (double)num19;
					num49 = (num33 + num35) / 2.0 + (double)(num19 / 2);
					#if WINDOWS
					val9.FormatFlags = (StringFormatFlags)1;
					#endif
					val2.DrawString(num104.ToString(), val7, (Brush)(object)val8, (float)num48, (float)num49, val9);
				}
			}
			if (vyhid == "з виходом")
			{
				num15 = (double)(2 * num / 3 - num7 - num4) / (double)L;
				num8 = num25 + (int)(num20 * num14) + 50;
				int num153 = 0;
				if (vyhid3 == "круглий" || vyhid3 == "прямокутний")
				{
					num8 += 50;
					num153 += 50;
				}
				else if (vyhid2 == "круглий" || vyhid2 == "прямокутний")
				{
					num8 += 25;
					num153 += 25;
				}
				num8 += num12;
				if (num15 * (double)B + (double)(3 * num12) + (double)num153 > (double)num2 / 3.0)
				{
					num15 = ((double)num2 / 3.0 - (double)(3 * num12) - (double)num153) / (double)B;
				}
				num27 = (double)L * num15;
				num29 = (double)B * num15;
				num26 = (double)b * num15;
				double num38 = (double)d1 * num15;
				double num50 = (double)a1 * num15;
				double num51 = (double)b1 * num15;
				double num39 = (double)p1 * num15;
				double num36 = (double)f1 * num15;
				double num37 = (double)g1 * num15;
				double num58 = (double)d2 * num15;
				double num66 = (double)a2 * num15;
				double num67 = (double)b2 * num15;
				double num59 = (double)p2 * num15;
				double num56 = (double)f2 * num15;
				double num57 = (double)g2 * num15;
				double num73 = (double)d2 * num15;
				double num81 = (double)a3 * num15;
				double num82 = (double)b3 * num15;
				double num74 = (double)p3 * num15;
				double num71 = (double)f3 * num15;
				double num72 = (double)g3 * num15;
				num32 = num7;
				num33 = num8;
				num34 = num32 + num27;
				num35 = num33;
				val2.DrawLine(val4, (float)num32, (float)num33, (float)num34, (float)num35);
				num32 = num34;
				num33 = num35;
				num34 = num32;
				num35 = num33 + num29;
				val2.DrawLine(val4, (float)num32, (float)num33, (float)num34, (float)num35);
				num32 = num7;
				num33 = num8;
				num34 = num32;
				num35 = num33 + num29;
				val2.DrawLine(val4, (float)num32, (float)num33, (float)num34, (float)num35);
				num32 = num7;
				num33 = (double)num8 + num26;
				num34 = num32 + num27;
				num35 = num33;
				val2.DrawLine(val4, (float)num32, (float)num33, (float)num34, (float)num35);
				num32 = num7;
				num33 = (double)num8 + num29;
				num34 = num32 + num27;
				num35 = num33;
				val2.DrawLine(val4, (float)num32, (float)num33, (float)num34, (float)num35);
				num32 = num7;
				num33 = (double)num8 + num26;
				num34 = num32 - (double)num11;
				num35 = num33;
				num90 = num34;
				num91 = num35;
				val2.DrawLine(val3, (float)num32, (float)num33, (float)num34, (float)num35);
				num32 = num7;
				num33 = num8;
				num34 = num32 - (double)num11;
				num35 = num33;
				num88 = num34;
				num89 = num35;
				val2.DrawLine(val3, (float)num32, (float)num33, (float)num34, (float)num35);
				num32 = num88 + 5.0;
				num33 = num89;
				num34 = num90 + 5.0;
				num35 = num91;
				DrawRows(num32, num33, num34, num35, num15, val2, val3);
				num48 = num32 - (double)num19;
				num49 = (num89 + num91) / 2.0;
				#if WINDOWS
				val9.FormatFlags = (StringFormatFlags)2;
				#endif
				val2.DrawString(b.ToString(), val7, (Brush)(object)val8, (float)num48, (float)num49, val9);
				num32 = (double)num7 + num27;
				num33 = (double)num8 + num29;
				num34 = num32 + (double)num11;
				num35 = num33;
				num90 = num34;
				num91 = num35;
				val2.DrawLine(val3, (float)num32, (float)num33, (float)num34, (float)num35);
				num32 = (double)num7 + num27;
				num33 = num8;
				num34 = num32 + (double)num11;
				num35 = num33;
				num88 = num34;
				num89 = num35;
				val2.DrawLine(val3, (float)num32, (float)num33, (float)num34, (float)num35);
				num32 = num88 - 5.0;
				num33 = num89;
				num34 = num90 - 5.0;
				num35 = num91;
				DrawRows(num32, num33, num34, num35, num15, val2, val3);
				num48 = num32 + (double)num19;
				num49 = (num89 + num91) / 2.0;
				#if WINDOWS
				val9.FormatFlags = (StringFormatFlags)2;
				#endif
				val2.DrawString(B.ToString(), val7, (Brush)(object)val8, (float)num48, (float)num49, val9);
				num32 = num7;
				num33 = (double)num8 + num29;
				num34 = num32;
				num35 = num33 + (double)num11;
				num88 = num34;
				num89 = num35;
				val2.DrawLine(val3, (float)num32, (float)num33, (float)num34, (float)num35);
				num32 = (double)num7 + num27;
				num33 = (double)num8 + num29;
				num34 = num32;
				num35 = num33 + (double)num11;
				num90 = num34;
				num91 = num35;
				val2.DrawLine(val3, (float)num32, (float)num33, (float)num34, (float)num35);
				num32 = num88;
				num33 = num89 - 5.0;
				num34 = num90;
				num35 = num91 - 5.0;
				val2.DrawLine(val3, (float)num32, (float)num33, (float)num34, (float)num35);
				num48 = (num88 + num90) / 2.0;
				num49 = (num89 + num91) / 2.0 + (double)num19;
				#if WINDOWS
				val9.FormatFlags = (StringFormatFlags)1;
				#endif
				val2.DrawString(L.ToString(), val7, (Brush)(object)val8, (float)num48, (float)num49, val9);
				if (vyhid1 == "круглий")
				{
					val2.DrawEllipse(val4, (float)((double)num7 + num36 - num38 / 2.0), (float)((double)num8 + num37 - num38 / 2.0), (float)num38, (float)num38);
					num32 = num7;
					num33 = num8;
					num34 = num32;
					num35 = num33 - (double)num12;
					num88 = num34;
					num89 = num35;
					val2.DrawLine(val3, (float)num32, (float)num33, (float)num34, (float)num35);
					num32 = (double)num7 + num36;
					num33 = (double)num8 + num37;
					num34 = num32;
					num35 = num33 - num37 - (double)num12;
					num90 = num34;
					num91 = num35;
					val2.DrawLine(val3, (float)num32, (float)num33, (float)num34, (float)num35);
					num32 = num88;
					num33 = num89 + 5.0;
					num34 = num90;
					num35 = num91 + 5.0;
					val2.DrawLine(val3, (float)num32, (float)num33, (float)num34, (float)num35);
					DrawRows(num32, num33, num34, num35, num15, val2, val3);
					num48 = (num32 + num34) / 2.0;
					num49 = num35 - (double)num19;
					#if WINDOWS
					val9.FormatFlags = (StringFormatFlags)1;
					#endif
					val2.DrawString(f1.ToString(), val7, (Brush)(object)val8, (float)num48, (float)num49, val9);
					num32 = (double)num7 + num36;
					num33 = (double)num8 + num37;
					num34 = num32 + num38 / 2.0 + (double)num12;
					num35 = num33;
					num88 = num34;
					num89 = num35;
					val2.DrawLine(val3, (float)num32, (float)num33, (float)num34, (float)num35);
					num90 = num88;
					num91 = num8;
					num32 = num88 - 5.0;
					num33 = num89;
					num34 = num90 - 5.0;
					num35 = num91;
					DrawRows(num34, num35, num32, num33, num15, val2, val3);
					num48 = num32 + (double)num19;
					num49 = (num33 + num35) / 2.0;
					#if WINDOWS
					val9.FormatFlags = (StringFormatFlags)2;
					#endif
					val2.DrawString(g1.ToString(), val7, (Brush)(object)val8, (float)num48, (float)num49, val9);
					num32 = (double)num7 + num36 - num38 / 2.0;
					num33 = (double)num8 + num37;
					num34 = num32;
					num35 = num33 + num38 / 2.0 + (double)num12;
					num88 = num34;
					num89 = num35;
					val2.DrawLine(val3, (float)num32, (float)num33, (float)num34, (float)num35);
					num32 = (double)num7 + num36 + num38 / 2.0;
					num33 = (double)num8 + num37;
					num34 = num32;
					num35 = num33 + num38 / 2.0 + (double)num12;
					num90 = num34;
					num91 = num35;
					val2.DrawLine(val3, (float)num32, (float)num33, (float)num34, (float)num35);
					num32 = num88;
					num33 = num89 - 5.0;
					num34 = num90;
					num35 = num91 - 5.0;
					DrawRows(num32, num33, num34, num35, num15, val2, val3);
					num48 = (num32 + num34) / 2.0;
					num49 = num35 + (double)num19;
					#if WINDOWS
					val9.FormatFlags = (StringFormatFlags)1;
					#endif
					val2.DrawString(d1.ToString(), val7, (Brush)(object)val8, (float)num48, (float)num49, val9);
				}
				else if (vyhid1 == "прямокутний")
				{
					val2.DrawRectangle(val4, (float)((double)num7 + num36 - num50 / 2.0), (float)((double)num8 + num37 - num51 / 2.0), (float)num50, (float)num51);
					num32 = num7;
					num33 = num8;
					num34 = num32;
					num35 = num33 - (double)num12;
					num88 = num34;
					num89 = num35;
					val2.DrawLine(val3, (float)num32, (float)num33, (float)num34, (float)num35);
					num32 = (double)num7 + num36;
					num33 = (double)num8 + num37;
					num34 = num32;
					num35 = num33 - num37 - (double)num12;
					num90 = num34;
					num91 = num35;
					val2.DrawLine(val3, (float)num32, (float)num33, (float)num34, (float)num35);
					num32 = num88;
					num33 = num89 + 5.0;
					num34 = num90;
					num35 = num91 + 5.0;
					val2.DrawLine(val3, (float)num32, (float)num33, (float)num34, (float)num35);
					DrawRows(num32, num33, num34, num35, num15, val2, val3);
					num48 = (num32 + num34) / 2.0;
					num49 = num35 - (double)num19;
					#if WINDOWS
					val9.FormatFlags = (StringFormatFlags)1;
					#endif
					val2.DrawString(f1.ToString(), val7, (Brush)(object)val8, (float)num48, (float)num49, val9);
					num32 = (double)num7 + num36;
					num33 = (double)num8 + num37;
					num34 = num32 + num50 / 2.0 + (double)num12;
					num35 = num33;
					num88 = num34;
					num89 = num35;
					val2.DrawLine(val3, (float)num32, (float)num33, (float)num34, (float)num35);
					num90 = num88;
					num91 = num8;
					num32 = num88 - 5.0;
					num33 = num89;
					num34 = num90 - 5.0;
					num35 = num91;
					DrawRows(num34, num35, num32, num33, num15, val2, val3);
					num48 = num32 + (double)num19;
					num49 = ((vyhid2 == "прямокутний") ? (num35 + 15.0) : ((num33 + num35) / 2.0));
					#if WINDOWS
					val9.FormatFlags = (StringFormatFlags)2;
					#endif
					val2.DrawString(g1.ToString(), val7, (Brush)(object)val8, (float)num48, (float)num49, val9);
					num32 = (double)num7 + num36 - num50 / 2.0;
					num33 = (double)num8 + num37 + num51 / 2.0;
					num34 = num32;
					num35 = num33 + (double)num12;
					num88 = num34;
					num89 = num35;
					val2.DrawLine(val3, (float)num32, (float)num33, (float)num34, (float)num35);
					num32 = (double)num7 + num36 + num50 / 2.0;
					num33 = (double)num8 + num37 + num51 / 2.0;
					num34 = num32;
					num35 = num33 + (double)num12;
					num90 = num34;
					num91 = num35;
					val2.DrawLine(val3, (float)num32, (float)num33, (float)num34, (float)num35);
					num32 = num88;
					num33 = num89 - 5.0;
					num34 = num90;
					num35 = num91 - 5.0;
					DrawRows(num32, num33, num34, num35, num15, val2, val3);
					num48 = (num32 + num34) / 2.0;
					num49 = num35 + (double)num19;
					#if WINDOWS
					val9.FormatFlags = (StringFormatFlags)1;
					#endif
					val2.DrawString(a1.ToString(), val7, (Brush)(object)val8, (float)num48, (float)num49, val9);
					num32 = (double)num7 + num36 - num50 / 2.0;
					num33 = (double)num8 + num37 - num51 / 2.0;
					num34 = num32 - (double)num12;
					num35 = num33;
					num88 = num34;
					num89 = num35;
					val2.DrawLine(val3, (float)num32, (float)num33, (float)num34, (float)num35);
					num32 = (double)num7 + num36 - num50 / 2.0;
					num33 = (double)num8 + num37 + num51 / 2.0;
					num34 = num32 - (double)num12;
					num35 = num33;
					num90 = num34;
					num91 = num35;
					val2.DrawLine(val3, (float)num32, (float)num33, (float)num34, (float)num35);
					num32 = num88 + 5.0;
					num33 = num89;
					num34 = num90 + 5.0;
					num35 = num91;
					val2.DrawLine(val3, (float)num32, (float)num33, (float)num34, (float)num35);
					DrawRows(num32, num33, num34, num35, num15, val2, val3);
					num48 = num32 - (double)num19 - 3.0;
					num49 = (num33 + num35) / 2.0;
					#if WINDOWS
					val9.FormatFlags = (StringFormatFlags)2;
					#endif
					val2.DrawString(b1.ToString(), val7, (Brush)(object)val8, (float)num48, (float)num49, val9);
				}
				if (vyhid2 == "круглий")
				{
					val2.DrawEllipse(val4, (float)((double)num7 + num56 - num58 / 2.0), (float)((double)num8 + num57 - num58 / 2.0), (float)num58, (float)num58);
					num32 = num7;
					num33 = num8;
					num34 = num32;
					num35 = num33 - (double)num12 - 25.0;
					num88 = num34;
					num89 = num35;
					val2.DrawLine(val3, (float)num32, (float)num33, (float)num34, (float)num35);
					num32 = (double)num7 + num56;
					num33 = (double)num8 + num57;
					num34 = num32;
					num35 = num33 - num57 - (double)num12 - 25.0;
					num90 = num34;
					num91 = num35;
					val2.DrawLine(val3, (float)num32, (float)num33, (float)num34, (float)num35);
					num32 = num88;
					num33 = num89 + 5.0;
					num34 = num90;
					num35 = num91 + 5.0;
					val2.DrawLine(val3, (float)num32, (float)num33, (float)num34, (float)num35);
					num48 = (num32 + num34) / 2.0;
					num49 = num35 - (double)num19;
					#if WINDOWS
					val9.FormatFlags = (StringFormatFlags)1;
					#endif
					val2.DrawString(f2.ToString(), val7, (Brush)(object)val8, (float)num48, (float)num49, val9);
					num32 = (double)num7 + num56;
					num33 = (double)num8 + num57;
					num34 = num32 + num58 / 2.0 + (double)num12;
					num35 = num33;
					num88 = num34;
					num89 = num35;
					val2.DrawLine(val3, (float)num32, (float)num33, (float)num34, (float)num35);
					num90 = num88;
					num91 = num8;
					num32 = num88 - 5.0;
					num33 = num89;
					num34 = num90 - 5.0;
					num35 = num91;
					DrawRows(num34, num35, num32, num33, num15, val2, val3);
					num48 = num32 + (double)num19;
					num49 = (num33 + num35) / 2.0;
					#if WINDOWS
					val9.FormatFlags = (StringFormatFlags)2;
					#endif
					val2.DrawString(g2.ToString(), val7, (Brush)(object)val8, (float)num48, (float)num49, val9);
					num32 = (double)num7 + num56 - num58 / 2.0;
					num33 = (double)num8 + num57;
					num34 = num32;
					num35 = num33 + num58 / 2.0 + (double)num12;
					num88 = num34;
					num89 = num35;
					val2.DrawLine(val3, (float)num32, (float)num33, (float)num34, (float)num35);
					num32 = (double)num7 + num56 + num58 / 2.0;
					num33 = (double)num8 + num57;
					num34 = num32;
					num35 = num33 + num58 / 2.0 + (double)num12;
					num90 = num34;
					num91 = num35;
					val2.DrawLine(val3, (float)num32, (float)num33, (float)num34, (float)num35);
					num32 = num88;
					num33 = num89 - 5.0;
					num34 = num90;
					num35 = num91 - 5.0;
					DrawRows(num32, num33, num34, num35, num15, val2, val3);
					num48 = (num32 + num34) / 2.0;
					num49 = num35 + (double)num19 + 3.0;
					#if WINDOWS
					val9.FormatFlags = (StringFormatFlags)1;
					#endif
					val2.DrawString(d2.ToString(), val7, (Brush)(object)val8, (float)num48, (float)num49, val9);
				}
				else if (vyhid2 == "прямокутний")
				{
					val2.DrawRectangle(val4, (float)((double)num7 + num56 - num66 / 2.0), (float)((double)num8 + num57 - num67 / 2.0), (float)num66, (float)num67);
					num32 = num7;
					num33 = num8;
					num34 = num32;
					num35 = num33 - (double)num12 - 25.0;
					num88 = num34;
					num89 = num35;
					val2.DrawLine(val3, (float)num32, (float)num33, (float)num34, (float)num35);
					num32 = (double)num7 + num56;
					num33 = (double)num8 + num57;
					num34 = num32;
					num35 = num33 - num57 - (double)num12 - 25.0;
					num90 = num34;
					num91 = num35;
					val2.DrawLine(val3, (float)num32, (float)num33, (float)num34, (float)num35);
					num32 = num88;
					num33 = num89 + 5.0;
					num34 = num90;
					num35 = num91 + 5.0;
					DrawRows(num32, num33, num34, num35, num15, val2, val3);
					num48 = (num32 + num34) / 2.0;
					num49 = num35 - (double)num19;
					#if WINDOWS
					val9.FormatFlags = (StringFormatFlags)1;
					#endif
					val2.DrawString(f2.ToString(), val7, (Brush)(object)val8, (float)num48, (float)num49, val9);
					num32 = (double)num7 + num56;
					num33 = (double)num8 + num57;
					num34 = num32 + num66 / 2.0 + (double)num12;
					num35 = num33;
					num88 = num34;
					num89 = num35;
					val2.DrawLine(val3, (float)num32, (float)num33, (float)num34, (float)num35);
					num90 = num88;
					num91 = num8;
					num32 = num88 - 5.0;
					num33 = num89;
					num34 = num90 - 5.0;
					num35 = num91;
					DrawRows(num34, num35, num32, num33, num15, val2, val3);
					num48 = num32 + (double)num19;
					num49 = ((vyhid3 == "прямокутний") ? (num35 + 15.0) : ((num33 + num35) / 2.0));
					#if WINDOWS
					val9.FormatFlags = (StringFormatFlags)2;
					#endif
					val2.DrawString(g2.ToString(), val7, (Brush)(object)val8, (float)num48, (float)num49, val9);
					num32 = (double)num7 + num56 - num66 / 2.0;
					num33 = (double)num8 + num57 + num67 / 2.0;
					num34 = num32;
					num35 = num33 + (double)num12;
					num88 = num34;
					num89 = num35;
					val2.DrawLine(val3, (float)num32, (float)num33, (float)num34, (float)num35);
					num32 = (double)num7 + num56 + num66 / 2.0;
					num33 = (double)num8 + num57 + num67 / 2.0;
					num34 = num32;
					num35 = num33 + (double)num12;
					num90 = num34;
					num91 = num35;
					val2.DrawLine(val3, (float)num32, (float)num33, (float)num34, (float)num35);
					num32 = num88;
					num33 = num89 - 5.0;
					num34 = num90;
					num35 = num91 - 5.0;
					DrawRows(num32, num33, num34, num35, num15, val2, val3);
					num48 = (num32 + num34) / 2.0;
					num49 = num35 + (double)num19;
					#if WINDOWS
					val9.FormatFlags = (StringFormatFlags)1;
					#endif
					val2.DrawString(a2.ToString(), val7, (Brush)(object)val8, (float)num48, (float)num49, val9);
					num32 = (double)num7 + num56 - num66 / 2.0;
					num33 = (double)num8 + num57 - num67 / 2.0;
					num34 = num32 - (double)num12;
					num35 = num33;
					num88 = num34;
					num89 = num35;
					val2.DrawLine(val3, (float)num32, (float)num33, (float)num34, (float)num35);
					num32 = (double)num7 + num56 - num66 / 2.0;
					num33 = (double)num8 + num57 + num67 / 2.0;
					num34 = num32 - (double)num12;
					num35 = num33;
					num90 = num34;
					num91 = num35;
					val2.DrawLine(val3, (float)num32, (float)num33, (float)num34, (float)num35);
					num32 = num88 + 5.0;
					num33 = num89;
					num34 = num90 + 5.0;
					num35 = num91;
					DrawRows(num32, num33, num34, num35, num15, val2, val3);
					num48 = num32 - (double)num19 - 3.0;
					num49 = (num33 + num35) / 2.0;
					#if WINDOWS
					val9.FormatFlags = (StringFormatFlags)2;
					#endif
					val2.DrawString(b2.ToString(), val7, (Brush)(object)val8, (float)num48, (float)num49, val9);
				}
				if (vyhid3 == "круглий")
				{
					val2.DrawEllipse(val4, (float)((double)num7 + num71 - num73 / 2.0), (float)((double)num8 + num72 - num73 / 2.0), (float)num73, (float)num73);
					num32 = num7;
					num33 = num8;
					num34 = num32;
					num35 = num33 - (double)num12 - 50.0;
					num88 = num34;
					num89 = num35;
					val2.DrawLine(val3, (float)num32, (float)num33, (float)num34, (float)num35);
					num32 = (double)num7 + num71;
					num33 = (double)num8 + num72;
					num34 = num32;
					num35 = num33 - num72 - (double)num12 - 50.0;
					num90 = num34;
					num91 = num35;
					val2.DrawLine(val3, (float)num32, (float)num33, (float)num34, (float)num35);
					num32 = num88;
					num33 = num89 + 5.0;
					num34 = num90;
					num35 = num91 + 5.0;
					DrawRows(num32, num33, num34, num35, num15, val2, val3);
					num48 = (num32 + num34) / 2.0;
					num49 = num35 - (double)num19;
					#if WINDOWS
					val9.FormatFlags = (StringFormatFlags)1;
					#endif
					val2.DrawString(f3.ToString(), val7, (Brush)(object)val8, (float)num48, (float)num49, val9);
					num32 = (double)num7 + num71;
					num33 = (double)num8 + num72;
					num34 = num32 + num73 / 2.0 + (double)num12;
					num35 = num33;
					num88 = num34;
					num89 = num35;
					val2.DrawLine(val3, (float)num32, (float)num33, (float)num34, (float)num35);
					num90 = num88;
					num91 = num8;
					num32 = num88 - 5.0;
					num33 = num89;
					num34 = num90 - 5.0;
					num35 = num91;
					DrawRows(num34, num35, num32, num33, num15, val2, val3);
					num48 = num32 + (double)num19;
					num49 = (num33 + num35) / 2.0;
					#if WINDOWS
					val9.FormatFlags = (StringFormatFlags)2;
					#endif
					val2.DrawString(g3.ToString(), val7, (Brush)(object)val8, (float)num48, (float)num49, val9);
					num32 = (double)num7 + num71 - num73 / 2.0;
					num33 = (double)num8 + num72;
					num34 = num32;
					num35 = num33 + num73 / 2.0 + (double)num12;
					num88 = num34;
					num89 = num35;
					val2.DrawLine(val3, (float)num32, (float)num33, (float)num34, (float)num35);
					num32 = (double)num7 + num71 + num73 / 2.0;
					num33 = (double)num8 + num72;
					num34 = num32;
					num35 = num33 + num73 / 2.0 + (double)num12;
					num90 = num34;
					num91 = num35;
					val2.DrawLine(val3, (float)num32, (float)num33, (float)num34, (float)num35);
					num32 = num88;
					num33 = num89 - 5.0;
					num34 = num90;
					num35 = num91 - 5.0;
					DrawRows(num32, num33, num34, num35, num15, val2, val3);
					num48 = (num32 + num34) / 2.0;
					num49 = num35 + (double)num19 + 3.0;
					#if WINDOWS
					val9.FormatFlags = (StringFormatFlags)1;
					#endif
					val2.DrawString(d3.ToString(), val7, (Brush)(object)val8, (float)num48, (float)num49, val9);
				}
				else if (vyhid3 == "прямокутний")
				{
					val2.DrawRectangle(val4, (float)((double)num7 + num71 - num81 / 2.0), (float)((double)num8 + num72 - num82 / 2.0), (float)num81, (float)num82);
					num32 = num7;
					num33 = num8;
					num34 = num32;
					num35 = num33 - (double)num12 - 50.0;
					num88 = num34;
					num89 = num35;
					val2.DrawLine(val3, (float)num32, (float)num33, (float)num34, (float)num35);
					num32 = (double)num7 + num71;
					num33 = (double)num8 + num72;
					num34 = num32;
					num35 = num33 - num72 - (double)num12 - 50.0;
					num90 = num34;
					num91 = num35;
					val2.DrawLine(val3, (float)num32, (float)num33, (float)num34, (float)num35);
					num32 = num88;
					num33 = num89 + 5.0;
					num34 = num90;
					num35 = num91 + 5.0;
					DrawRows(num32, num33, num34, num35, num15, val2, val3);
					num48 = (num32 + num34) / 2.0;
					num49 = num35 - (double)num19;
					#if WINDOWS
					val9.FormatFlags = (StringFormatFlags)1;
					#endif
					val2.DrawString(f3.ToString(), val7, (Brush)(object)val8, (float)num48, (float)num49, val9);
					num32 = (double)num7 + num71;
					num33 = (double)num8 + num72;
					num34 = num32 + num81 / 2.0 + (double)num12;
					num35 = num33;
					num88 = num34;
					num89 = num35;
					val2.DrawLine(val3, (float)num32, (float)num33, (float)num34, (float)num35);
					num90 = num88;
					num91 = num8;
					num32 = num88 - 5.0;
					num33 = num89;
					num34 = num90 - 5.0;
					num35 = num91;
					DrawRows(num34, num35, num32, num33, num15, val2, val3);
					num48 = num32 + (double)num19;
					num49 = (num33 + num35) / 2.0;
					#if WINDOWS
					val9.FormatFlags = (StringFormatFlags)2;
					#endif
					val2.DrawString(g3.ToString(), val7, (Brush)(object)val8, (float)num48, (float)num49, val9);
					num32 = (double)num7 + num71 - num81 / 2.0;
					num33 = (double)num8 + num72 + num82 / 2.0;
					num34 = num32;
					num35 = num33 + (double)num12;
					num88 = num34;
					num89 = num35;
					val2.DrawLine(val3, (float)num32, (float)num33, (float)num34, (float)num35);
					num32 = (double)num7 + num71 + num81 / 2.0;
					num33 = (double)num8 + num72 + num82 / 2.0;
					num34 = num32;
					num35 = num33 + (double)num12;
					num90 = num34;
					num91 = num35;
					val2.DrawLine(val3, (float)num32, (float)num33, (float)num34, (float)num35);
					num32 = num88;
					num33 = num89 - 5.0;
					num34 = num90;
					num35 = num91 - 5.0;
					DrawRows(num32, num33, num34, num35, num15, val2, val3);
					num48 = (num32 + num34) / 2.0;
					num49 = num35 + (double)num19 + 3.0;
					#if WINDOWS
					val9.FormatFlags = (StringFormatFlags)1;
					#endif
					val2.DrawString(a3.ToString(), val7, (Brush)(object)val8, (float)num48, (float)num49, val9);
					num32 = (double)num7 + num71 - num81 / 2.0;
					num33 = (double)num8 + num72 - num82 / 2.0;
					num34 = num32 - (double)num12;
					num35 = num33;
					num88 = num34;
					num89 = num35;
					val2.DrawLine(val3, (float)num32, (float)num33, (float)num34, (float)num35);
					num32 = (double)num7 + num71 - num81 / 2.0;
					num33 = (double)num8 + num72 + num82 / 2.0;
					num34 = num32 - (double)num12;
					num35 = num33;
					num90 = num34;
					num91 = num35;
					val2.DrawLine(val3, (float)num32, (float)num33, (float)num34, (float)num35);
					num32 = num88 + 5.0;
					num33 = num89;
					num34 = num90 + 5.0;
					num35 = num91;
					DrawRows(num32, num33, num34, num35, num15, val2, val3);
					num48 = num32 - (double)num19 - 3.0;
					num49 = (num33 + num35) / 2.0;
					#if WINDOWS
					val9.FormatFlags = (StringFormatFlags)2;
					#endif
					val2.DrawString(b3.ToString(), val7, (Brush)(object)val8, (float)num48, (float)num49, val9);
				}
			}
			num9 = num3;
			num10 = num25 + (int)(num20 * num14) + 50;
			if (vyhid == "з виходом")
			{
				num10 += num2 / 3 + 20;
			}
			int num154 = 10;
			int num155 = 0;
			Font val10 = new Font("Arial", (float)num154);
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
						val2.DrawString("Ширина першого жирфільтра: " + kFiltr[0] + "мм", val10, (Brush)(object)val8, (float)num9, (float)(num10 + num155), val11);
						break;
					case 1:
						val2.DrawString("Ширина другого жирфільтра: " + kFiltr[1] + "мм", val10, (Brush)(object)val8, (float)num9, (float)(num10 + num155), val11);
						break;
					case 2:
						val2.DrawString("Ширина третього жирфільтра: " + kFiltr[2] + "мм", val10, (Brush)(object)val8, (float)num9, (float)(num10 + num155), val11);
						break;
					}
					num155 += num154 + 8;
					if (num10 + num155 > num2 - num6)
					{
						num9 = num3 + num / 2;
						num155 = 0;
					}
				}
				if (nFiltr == 1)
				{
					val2.DrawString("Довжина жирфільтра: " + l + "мм", val10, (Brush)(object)val8, (float)num9, (float)(num10 + num155), val11);
				}
				else
				{
					val2.DrawString("Довжина жирфільтрів: " + l + "мм", val10, (Brush)(object)val8, (float)num9, (float)(num10 + num155), val11);
				}
				num155 += num154 + 8;
				if (num10 + num155 > num2 - num6)
				{
					num9 = num3 + num / 2;
					num155 = 0;
				}
			}
			val2.DrawString("Матеріал зонта: " + zontMaterial, val10, (Brush)(object)val8, (float)num9, (float)(num10 + num155), val11);
			num155 += num154 + 8;
			if (num10 + num155 > num2 - num6)
			{
				num9 = num3 + num / 2;
				num155 = 0;
			}
			val2.DrawString("Товщина металу зонта: " + tovchynaMetaluZont + "мм", val10, (Brush)(object)val8, (float)num9, (float)(num10 + num155), val11);
			num155 += num154 + 8;
			if (num10 + num155 > num2 - num6)
			{
				num9 = num3 + num / 2;
				num155 = 0;
			}
			val2.DrawString("З'єднання: " + connection, val10, (Brush)(object)val8, (float)num9, (float)(num10 + num155), val11);
			num155 += num154 + 8;
			if (num10 + num155 > num2 - num6)
			{
				num9 = num3 + num / 2;
				num155 = 0;
			}
			val2.DrawString("Трубка зливу 1/2': " + zlyv, val10, (Brush)(object)val8, (float)num9, (float)(num10 + num155), val11);
			num155 += num154 + 8;
			if (num10 + num155 > num2 - num6)
			{
				num9 = num3 + num / 2;
				num155 = 0;
			}
			val2.DrawString("Кріплення: " + fastening, val10, (Brush)(object)val8, (float)num9, (float)(num10 + num155), val11);
			if (fastening == "так")
			{
				num155 += num154 + 8;
				if (num10 + num155 > num2 - num6)
				{
					num9 = num3 + num / 2;
					num155 = 0;
				}
				val2.DrawString("Тип кріплення: " + typeFastening, val10, (Brush)(object)val8, (float)num9, (float)(num10 + num155), val11);
			}
			if (vyhid == "з виходом")
			{
				if (vyhid1 == "круглий" || vyhid1 == "прямокутний")
				{
					num155 += num154 + 8;
					if (num10 + num155 > num2 - num6)
					{
						num9 = num3 + num / 2;
						num155 = 0;
					}
					val2.DrawString("Тип виходу 1: " + typVyhid1, val10, (Brush)(object)val8, (float)num9, (float)(num10 + num155), val11);
					if (typVyhid1 == "фланець")
					{
						num155 += num154 + 8;
						if (num10 + num155 > num2 - num6)
						{
							num9 = num3 + num / 2;
							num155 = 0;
						}
						val2.DrawString("Тип профілю для виходу 1: " + profilType1, val10, (Brush)(object)val8, (float)num9, (float)(num10 + num155), val11);
					}
				}
				if (vyhid2 == "круглий" || vyhid2 == "прямокутний")
				{
					num155 += num154 + 8;
					if (num10 + num155 > num2 - num6)
					{
						num9 = num3 + num / 2;
						num155 = 0;
					}
					val2.DrawString("Тип виходу 2: " + typVyhid2, val10, (Brush)(object)val8, (float)num9, (float)(num10 + num155), val11);
					if (typVyhid2 == "фланець")
					{
						num155 += num154 + 8;
						if (num10 + num155 > num2 - num6)
						{
							num9 = num3 + num / 2;
							num155 = 0;
						}
						val2.DrawString("Тип профілю для виходу 2: " + profilType2, val10, (Brush)(object)val8, (float)num9, (float)(num10 + num155), val11);
					}
				}
				if (vyhid3 == "круглий" || vyhid3 == "прямокутний")
				{
					num155 += num154 + 8;
					if (num10 + num155 > num2 - num6)
					{
						num9 = num3 + num / 2;
						num155 = 0;
					}
					val2.DrawString("Тип виходу 3: " + typVyhid3, val10, (Brush)(object)val8, (float)num9, (float)(num10 + num155), val11);
					if (typVyhid3 == "фланець")
					{
						num155 += num154 + 8;
						if (num10 + num155 > num2 - num6)
						{
							num9 = num3 + num / 2;
							num155 = 0;
						}
						val2.DrawString("Тип профілю для виходу 3: " + profilType3, val10, (Brush)(object)val8, (float)num9, (float)(num10 + num155), val11);
					}
				}
			}
			if (zhyrFiltr == "так")
			{
				num155 += num154 + 8;
				if (num10 + num155 > num2 - num6)
				{
					num9 = num3 + num / 2;
					num155 = 0;
				}
				val2.DrawString("Матеріал жирфільтра: " + zhyrFiltrMaterial, val10, (Brush)(object)val8, (float)num9, (float)(num10 + num155), val11);
				num155 += num154 + 8;
				if (num10 + num155 > num2 - num6)
				{
					num9 = num3 + num / 2;
					num155 = 0;
				}
				val2.DrawString("Товщина металу жирфільтра: " + tovchynaMetaluFiltr + "мм", val10, (Brush)(object)val8, (float)num9, (float)(num10 + num155), val11);
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

	public static double VolumeZontVytyazhnyyTyp1(int L, int B, int H, int p1, int p2, int p3)
	{
		int num = ((p1 > p2) ? p1 : p2);
		if (p3 > num)
		{
			num = p3;
		}
		return Math.Round((double)L * (double)B * (double)(H + num) / 1000000.0) / 1000.0;
	}
}
