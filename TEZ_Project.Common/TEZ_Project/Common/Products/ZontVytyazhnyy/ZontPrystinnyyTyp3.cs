using System;
using System.Drawing;
using System.Globalization;
using System.IO;
using TEZ_Project.Common.Helpers;

namespace TEZ_Project.Common.Products.ZontVytyazhnyy;

public class ZontPrystinnyyTyp3
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

	public static double L1 = 0.0;

	public static double materialSpendingCommercialOffer = 0.0;

	public static double materialSpendingCommercialOffer1 = 0.0;

	public static double[,] MaterialZontPrystinnyyTyp3(int L, int B, int H, int h, int a, int b, double c, int number, string markaStaliZont, string tovchynaMetaluZont, string connection, string zlyv, string fastening, string typeFastening, string vyhid, string vyhid1, int d1, int a1, int b1, int p1, int f1, int g1, string typVyhid1, string profilType1, string vyhid2, int d2, int a2, int b2, int p2, int f2, int g2, string typVyhid2, string profilType2, string zhyrFiltr, string markaStaliFiltr, string tovchynaMetaluFiltr, string implementation1)
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
		int num9 = 750;
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
		double num10 = Math.Sqrt(Math.Pow(c, 2.0) + Math.Pow(H - h, 2.0));
		double num11 = Math.Sqrt(Math.Pow(c, 2.0) + Math.Pow(B - b, 2.0) + Math.Pow(H - h, 2.0));
		double num12 = Math.Sqrt(Math.Pow((double)(L - a) - c, 2.0) + Math.Pow(B - b, 2.0) + Math.Pow(H - h, 2.0));
		double num13 = Math.Sqrt(Math.Pow((double)(L - a) - c, 2.0) + Math.Pow(H - h, 2.0));
		double num14 = 1.0;
		double num15 = 10.0;
		double num16 = 20.0;
		double num17 = ((connection == "зварка") ? 12 : 15);
		double num18 = Math.Sqrt(Math.Pow(num10, 2.0) - Math.Pow(c, 2.0));
		num18 += num15 + num16 + num17 + (double)h + 2.0 * num14;
		double num19 = L;
		num5 = num19 * num18;
		if (num18 > 2500.0)
		{
			num5 += 40.0 * num19;
		}
		else if (num18 > 1250.0)
		{
			num5 += 20.0 * num19;
		}
		if (num19 > 2500.0)
		{
			num5 += 40.0 * num18;
		}
		else if (num19 > 1250.0)
		{
			num5 += 20.0 * num18;
		}
		num18 = Math.Sqrt(Math.Pow(num11, 2.0) - Math.Pow(c, 2.0));
		num18 += num15 + num16 + num17 + (double)h + 2.0 * num14;
		num19 = L;
		num5 += num19 * num18;
		if (num18 > 2500.0)
		{
			num5 += 40.0 * num19;
		}
		else if (num18 > 1250.0)
		{
			num5 += 20.0 * num19;
		}
		if (num19 > 2500.0)
		{
			num5 += 40.0 * num18;
		}
		else if (num19 > 1250.0)
		{
			num5 += 20.0 * num18;
		}
		num18 = num10;
		num18 += num15 + num16 + num17 + (double)h;
		num19 = (double)B + 2.0 * num17;
		num5 += num19 * num18;
		if (num18 > 2500.0)
		{
			num5 += 40.0 * num19;
		}
		else if (num18 > 1250.0)
		{
			num5 += 20.0 * num19;
		}
		if (num19 > 2500.0)
		{
			num5 += 40.0 * num18;
		}
		else if (num19 > 1250.0)
		{
			num5 += 20.0 * num18;
		}
		num18 = num13;
		num18 += num15 + num16 + num17 + (double)h;
		num19 = (double)B + 2.0 * num17;
		num5 += num19 * num18;
		if (num18 > 2500.0)
		{
			num5 += 40.0 * num19;
		}
		else if (num18 > 1250.0)
		{
			num5 += 20.0 * num19;
		}
		if (num19 > 2500.0)
		{
			num5 += 40.0 * num18;
		}
		else if (num19 > 1250.0)
		{
			num5 += 20.0 * num18;
		}
		num6 = a * b;
		if (zhyrFiltr == "так")
		{
			if (implementation1 == "ж/ф внизу зонта (2 ряди)")
			{
				double num20 = 54.5;
				double num21 = 15.0;
				num8 = (num20 + num21) * (double)(L - 10);
				num20 = 24.5;
				num21 = 109.0;
				num8 += (num21 + 2.0 * (num20 + num14)) * (double)(L - 5);
			}
			else
			{
				double num22 = 9.5;
				double num23 = 59.0;
				double num24 = 64.5;
				double num25 = 20.0;
				double num26 = 70.0;
				num8 = (num22 + num23 + num24 + num25 + 2.0 * num14) * ((double)ZontPrystinnyyTyp3.l + num26);
				double num27 = 20.0;
				double num28 = 60.0;
				double num29 = 15.0;
				double num30 = 35.0;
				num8 += (num27 + num28 + 2.0 * num29 + num30) * (kk + 2.0 * num29);
			}
		}
		num7 = 0.0;
		if (vyhid == "з виходом")
		{
			double num31 = 60.0;
			if (vyhid1 == "круглий")
			{
				double num32 = ((d1 < 560) ? 0.036 : ((d1 < 710) ? 0.043 : ((d1 >= 900) ? ((d1 < 1400) ? 0.086 : 0.11599999999999999) : 0.073)));
				num7 += (Math.PI * (double)d1 + num32) * ((double)p1 + num31);
			}
			if (vyhid2 == "круглий")
			{
				double num32 = ((d2 < 560) ? 0.036 : ((d2 < 710) ? 0.043 : ((d2 >= 900) ? ((d2 < 1400) ? 0.086 : 0.11599999999999999) : 0.073)));
				num7 += (Math.PI * (double)d2 + num32) * ((double)p2 + num31);
			}
			if (vyhid1 == "прямокутний")
			{
				double num33 = 2.0 * (double)(a1 + 10 + b1 + 50);
				num31 = ((num33 <= 500.0) ? 60 : 30);
				num7 += (num33 + num31) * ((double)p1 + num31);
			}
			if (vyhid2 == "прямокутний")
			{
				double num33 = 2.0 * (double)(a2 + 10 + b2 + 50);
				num31 = ((num33 <= 500.0) ? 60 : 30);
				num7 += (num33 + num31) * ((double)p2 + num31);
			}
		}
		array[num, 0] = (num5 + num6 + num7 + num8) * 1.05 / 1000000.0;
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
		for (int i = 0; i < 5; i++)
		{
			if (array[num, i] < 0.005)
			{
				array[num, i] = Math.Round(1000.0 * array[num, i]) / 1000.0;
			}
			else
			{
				array[num, i] = Math.Round(100.0 * array[num, i]) / 100.0;
			}
		}
		materialCost = array[num, 0] * num4;
		if (connection == "заклепка")
		{
			int num34 = 50;
			int num35 = 4 * ((int)Math.Round(((double)h - 22.0 - 28.0) / (double)num34, MidpointRounding.AwayFromZero) + 1);
			num35 += (int)Math.Round((num10 - 22.0 - 28.0) / (double)num34, MidpointRounding.AwayFromZero) + 1;
			num35 += (int)Math.Round((num11 - 22.0 - 28.0) / (double)num34, MidpointRounding.AwayFromZero) + 1;
			num35 += (int)Math.Round((num12 - 22.0 - 28.0) / (double)num34, MidpointRounding.AwayFromZero) + 1;
			num35 += (int)Math.Round((num13 - 22.0 - 28.0) / (double)num34, MidpointRounding.AwayFromZero) + 1;
			num35 += 2 * ((int)Math.Round(((double)a - 44.0) / (double)num34, MidpointRounding.AwayFromZero) + 1);
			num35 += 2 * ((int)Math.Round(((double)b - 44.0) / (double)num34, MidpointRounding.AwayFromZero) + 1);
			num35 += ((implementation1 == "ж/ф внизу зонта (2 ряди)") ? 4 : 11);
			num++;
			materialName[num] = Consts2.zaklepkaKombinov48x6.MaterialName;
			array[num, 0] = num35;
			array[num, 4] = array[num, 0] * (double)number;
			materialCost += array[num, 0] * Consts2.zaklepkaKombinov48x6.Price;
		}
		if (zhyrFiltr == "так")
		{
			double[] array2 = new double[6];
			for (int j = 0; j < nFiltr; j++)
			{
				array2 = FiltrZh.MaterialFiltrZh(kFiltr[j], ZontPrystinnyyTyp3.l, markaStaliFiltr, tovchynaMetaluFiltr, number);
				materialCost += FiltrZh.materialCost;
				num++;
				materialName[num] = FiltrZh.materialName[0];
				for (int k = 0; k < 6; k++)
				{
					array[num, k] = array2[k];
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
			if ((vyhid1 == "круглий" && typVyhid1 == "фланець") || (vyhid2 == "круглий" && typVyhid2 == "фланець"))
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
					int num36 = 0;
					for (int l = 0; l < 5 && FlanetsKruglyj.materialName1[l] != ""; l++)
					{
						num36++;
					}
					for (int m = 0; m < num36; m++)
					{
						materialName[m + num] = FlanetsKruglyj.materialName1[m];
						for (int n = 0; n < 6; n++)
						{
							array[m + num, n] = array3[m, n];
						}
					}
					num += num36 - 1;
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
			}
			if ((vyhid1 == "прямокутний" && typVyhid1 == "фланець") || (vyhid2 == "прямокутний" && typVyhid2 == "фланець"))
			{
				double[,] array4 = new double[2, 6];
				if (vyhid1 == "прямокутний" && typVyhid1 == "фланець")
				{
					array4 = MaterialFlanetsPrjamokutnyj(a1, b1, profilType1, number);
					materialCost += materialCost1;
					for (int num41 = 0; num41 < 2; num41++)
					{
						if (materialName1[num41] != "")
						{
							num++;
							materialName[num] = materialName1[num41];
							for (int num42 = 0; num42 < 6; num42++)
							{
								array[num, num42] = array4[num41, num42];
							}
						}
					}
				}
				if (vyhid2 == "прямокутний" && typVyhid2 == "фланець")
				{
					array4 = MaterialFlanetsPrjamokutnyj(a2, b2, profilType2, number);
					materialCost += materialCost1;
					for (int num43 = 0; num43 < 2; num43++)
					{
						if (materialName1[num43] != "")
						{
							num++;
							materialName[num] = materialName1[num43];
							for (int num44 = 0; num44 < 6; num44++)
							{
								array[num, num44] = array4[num43, num44];
							}
						}
					}
				}
				num++;
			}
		}
		if (num > 0)
		{
			for (int num45 = 0; num45 < num; num45++)
			{
				for (int num46 = num45 + 1; num46 <= num; num46++)
				{
					if (!(materialName[num45] == materialName[num46]))
					{
						continue;
					}
					for (int num47 = 0; num47 < 6; num47++)
					{
						if (num47 == 1)
						{
							if (materialName[num45] == Consts2.lystStalnyj30.MaterialName)
							{
								array[num45, num47] = Math.Round((array[num45, num47] + array[num46, num47]) / 2.0);
							}
						}
						else
						{
							array[num45, num47] += array[num46, num47];
						}
						array[num46, num47] = 0.0;
					}
					materialName[num46] = "";
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

	public static void ZontPrystinnyyTyp3DrawDxf(int L, int B, int H, int h, int a, int b, double c, string connection, string zlyv, string vyhid, string vyhid1, int d1, int a1, int b1, int f1, int g1, string typVyhid1, string vyhid2, int d2, int a2, int b2, int f2, int g2, string typVyhid2, string zhyrFiltr, string implementation1, string filePath)
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
			double num6 = 2 * L + 200;
			double num7 = 0.0;
			num2 = 0.0;
			num3 = 0.0;
			num4 = num2 + (double)b;
			num5 = num3;
			ushort num8 = (ushort)(num + 1);
			num = num8;
			DrawLine(streamWriter, num8, text, num6 + num2, num7 + num3, num6 + num4, num7 + num5);
			num = DrawZaklepka_Top(streamWriter, num, text, connection, num2 + num6, num3 + num7, num4 + num6, num5 + num7, 0);
			num4 = num2;
			num5 = num3 + (double)a;
			num8 = (ushort)(num + 1);
			num = num8;
			DrawLine(streamWriter, num8, text, num6 + num2, num7 + num3, num6 + num4, num7 + num5);
			num = DrawZaklepka_Top(streamWriter, num, text, connection, num2 + num6, num3 + num7, num4 + num6, num5 + num7, 1);
			num2 = num4;
			num3 = num5;
			num4 = num2 + (double)b;
			num5 = num3;
			num8 = (ushort)(num + 1);
			num = num8;
			DrawLine(streamWriter, num8, text, num6 + num2, num7 + num3, num6 + num4, num7 + num5);
			num = DrawZaklepka_Top(streamWriter, num, text, connection, num2 + num6, num3 + num7, num4 + num6, num5 + num7, 1);
			num2 = num4;
			num3 = num5;
			num4 = num2;
			num5 = num3 - (double)a;
			num8 = (ushort)(num + 1);
			num = num8;
			DrawLine(streamWriter, num8, text, num6 + num2, num7 + num3, num6 + num4, num7 + num5);
			num = DrawZaklepka_Top(streamWriter, num, text, connection, num2 + num6, num3 + num7, num4 + num6, num5 + num7, 1);
			if (vyhid == "з виходом")
			{
				int num9 = d1;
				int num10 = a1;
				int num11 = b1;
				int num12 = d2;
				int num13 = a2;
				int num14 = b2;
				int num15 = 3;
				int num16 = 2;
				int num17 = 3;
				int num18 = 5;
				if (connection == "зварка")
				{
					if (typVyhid1 == "мінус")
					{
						d1 -= num15;
						a1 -= num15;
						b1 -= num15;
					}
					if (typVyhid2 == "мінус")
					{
						d2 -= num15;
						a2 -= num15;
						b2 -= num15;
					}
				}
				if (connection == "заклепка")
				{
					if (typVyhid1 == "чисто" || typVyhid1 == "фланець")
					{
						d1 -= num16;
						a1 += num17;
						b1 += num17;
					}
					if (typVyhid1 == "мінус")
					{
						d1 -= num18;
					}
					if (typVyhid2 == "чисто" || typVyhid2 == "фланець")
					{
						d2 -= num16;
						a2 += num17;
						b2 += num17;
					}
					if (typVyhid2 == "мінус")
					{
						d2 -= num18;
					}
				}
				if (vyhid1 == "круглий")
				{
					num2 = g1;
					num3 = f1;
					num8 = (ushort)(num + 1);
					num = num8;
					DrawCircle(streamWriter, num8, text, num6 + num2, num7 + num3, (double)d1 / 2.0);
				}
				else if (vyhid1 == "прямокутний")
				{
					num2 = (double)g1 + (double)b1 / 2.0;
					num3 = (double)f1 + (double)a1 / 2.0;
					num4 = num2;
					num5 = num3 - (double)a1;
					num8 = (ushort)(num + 1);
					num = num8;
					DrawLine(streamWriter, num8, text, num6 + num2, num7 + num3, num6 + num4, num7 + num5);
					num2 = num4;
					num3 = num5;
					num4 = num2 - (double)b1;
					num5 = num3;
					num8 = (ushort)(num + 1);
					num = num8;
					DrawLine(streamWriter, num8, text, num6 + num2, num7 + num3, num6 + num4, num7 + num5);
					num2 = num4;
					num3 = num5;
					num4 = num2;
					num5 = num3 + (double)a1;
					num8 = (ushort)(num + 1);
					num = num8;
					DrawLine(streamWriter, num8, text, num6 + num2, num7 + num3, num6 + num4, num7 + num5);
					num2 = num4;
					num3 = num5;
					num4 = num2 + (double)b1;
					num5 = num3;
					num8 = (ushort)(num + 1);
					num = num8;
					DrawLine(streamWriter, num8, text, num6 + num2, num7 + num3, num6 + num4, num7 + num5);
				}
				if (vyhid2 == "круглий")
				{
					num2 = g2;
					num3 = f2;
					num8 = (ushort)(num + 1);
					num = num8;
					DrawCircle(streamWriter, num8, text, num6 + num2, num7 + num3, (double)d2 / 2.0);
				}
				else if (vyhid2 == "прямокутний")
				{
					num2 = (double)g2 + (double)b2 / 2.0;
					num3 = (double)f2 + (double)a2 / 2.0;
					num4 = num2;
					num5 = num3 - (double)a2;
					num8 = (ushort)(num + 1);
					num = num8;
					DrawLine(streamWriter, num8, text, num6 + num2, num7 + num3, num6 + num4, num7 + num5);
					num2 = num4;
					num3 = num5;
					num4 = num2 - (double)b2;
					num5 = num3;
					num8 = (ushort)(num + 1);
					num = num8;
					DrawLine(streamWriter, num8, text, num6 + num2, num7 + num3, num6 + num4, num7 + num5);
					num2 = num4;
					num3 = num5;
					num4 = num2;
					num5 = num3 + (double)a2;
					num8 = (ushort)(num + 1);
					num = num8;
					DrawLine(streamWriter, num8, text, num6 + num2, num7 + num3, num6 + num4, num7 + num5);
					num2 = num4;
					num3 = num5;
					num4 = num2 + (double)b2;
					num5 = num3;
					num8 = (ushort)(num + 1);
					num = num8;
					DrawLine(streamWriter, num8, text, num6 + num2, num7 + num3, num6 + num4, num7 + num5);
				}
				d1 = num9;
				a1 = num10;
				b1 = num11;
				d2 = num12;
				a2 = num13;
				b2 = num14;
			}
			double num19 = 1.0;
			double num20 = 10.0;
			double num21 = 20.0;
			double num22 = 112.0;
			double num23 = ((connection == "зварка") ? 12 : 15);
			num6 = 0.0;
			num7 = 0.0;
			int num24 = 130;
			int num25 = (L + a) / 2 - num24;
			if (num25 <= 550)
			{
				nFiltr = 1;
				kFiltr[0] = 400;
			}
			else if (num25 <= 650)
			{
				nFiltr = 1;
				kFiltr[0] = 500;
			}
			else if (num25 <= 675)
			{
				nFiltr = 1;
				kFiltr[0] = 600;
			}
			else if (num25 <= 750)
			{
				nFiltr = 2;
				kFiltr[0] = 300;
				kFiltr[1] = 300;
			}
			else if (num25 <= 850)
			{
				nFiltr = 2;
				kFiltr[0] = 300;
				kFiltr[1] = 400;
			}
			else if (num25 <= 950)
			{
				nFiltr = 2;
				kFiltr[0] = 400;
				kFiltr[1] = 400;
			}
			else if (num25 <= 1050)
			{
				nFiltr = 2;
				kFiltr[0] = 400;
				kFiltr[1] = 500;
			}
			else if (num25 <= 1150)
			{
				nFiltr = 2;
				kFiltr[0] = 500;
				kFiltr[1] = 500;
			}
			else if (num25 <= 1250)
			{
				nFiltr = 2;
				kFiltr[0] = 500;
				kFiltr[1] = 600;
			}
			else if (num25 <= 1350)
			{
				nFiltr = 2;
				kFiltr[0] = 600;
				kFiltr[1] = 600;
			}
			else if (num25 <= 1450)
			{
				nFiltr = 3;
				kFiltr[0] = 400;
				kFiltr[1] = 400;
				kFiltr[2] = 500;
			}
			else if (num25 <= 1550)
			{
				nFiltr = 3;
				kFiltr[0] = 400;
				kFiltr[1] = 500;
				kFiltr[2] = 500;
			}
			else if (num25 <= 1650)
			{
				nFiltr = 3;
				kFiltr[0] = 500;
				kFiltr[1] = 500;
				kFiltr[2] = 500;
			}
			else if (num25 <= 1750)
			{
				nFiltr = 3;
				kFiltr[0] = 500;
				kFiltr[1] = 500;
				kFiltr[2] = 600;
			}
			else if (num25 <= 1850)
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
			L1 = num24;
			for (int i = 0; i < nFiltr; i++)
			{
				L1 += kFiltr[i];
			}
			double num26 = Math.Sqrt(Math.Pow(c, 2.0) + Math.Pow(H - h, 2.0));
			double num27 = Math.Sqrt(Math.Pow(c, 2.0) + Math.Pow(B - b, 2.0) + Math.Pow(H - h, 2.0));
			double num28 = Math.Sqrt(Math.Pow((double)(L - a) - c, 2.0) + Math.Pow(B - b, 2.0) + Math.Pow(H - h, 2.0));
			double num29 = Math.Sqrt(Math.Pow((double)(L - a) - c, 2.0) + Math.Pow(H - h, 2.0));
			double num30 = 40.0;
			double num31 = Math.Atan((double)(H - h) / c);
			double num32 = Math.Atan((double)(H - h) / ((double)L - c - (double)a));
			double a3 = Math.PI / 2.0;
			double a4 = Math.Atan((double)(H - h) / (double)(B - b));
			num2 = 0.0;
			num3 = 0.0;
			num4 = num2;
			num5 = num3 + num20;
			num8 = (ushort)(num + 1);
			num = num8;
			DrawLine(streamWriter, num8, text, num6 + num2, num7 + num3, num6 + num4, num7 + num5);
			num2 = num4;
			num3 = num5;
			num4 = num2 + num19;
			num5 = num3;
			num8 = (ushort)(num + 1);
			num = num8;
			DrawLine(streamWriter, num8, text, num6 + num2, num7 + num3, num6 + num4, num7 + num5);
			num2 = num4;
			num3 = num5;
			num4 = num2;
			num5 = num3 + num19;
			num8 = (ushort)(num + 1);
			num = num8;
			DrawLine(streamWriter, num8, text, num6 + num2, num7 + num3, num6 + num4, num7 + num5);
			num2 = num4;
			num3 = num5;
			num4 = num2 - num19;
			num5 = num3;
			num8 = (ushort)(num + 1);
			num = num8;
			DrawLine(streamWriter, num8, text, num6 + num2, num7 + num3, num6 + num4, num7 + num5);
			num2 = num4;
			num3 = num5;
			num4 = num2;
			num5 = num3 + num21;
			num8 = (ushort)(num + 1);
			num = num8;
			DrawLine(streamWriter, num8, text, num6 + num2, num7 + num3, num6 + num4, num7 + num5);
			num2 = num4;
			num3 = num5;
			num4 = num2 + num19;
			num5 = num3;
			num8 = (ushort)(num + 1);
			num = num8;
			DrawLine(streamWriter, num8, text, num6 + num2, num7 + num3, num6 + num4, num7 + num5);
			num2 = num4;
			num3 = num5;
			num4 = num2;
			num5 = num3 + num19;
			num8 = (ushort)(num + 1);
			num = num8;
			DrawLine(streamWriter, num8, text, num6 + num2, num7 + num3, num6 + num4, num7 + num5);
			num2 = num4;
			num3 = num5;
			num4 = num2 - num19;
			num5 = num3;
			num8 = (ushort)(num + 1);
			num = num8;
			DrawLine(streamWriter, num8, text, num6 + num2, num7 + num3, num6 + num4, num7 + num5);
			num2 = num4;
			num3 = num5;
			num4 = num2;
			num5 = num3 + (double)h;
			num8 = (ushort)(num + 1);
			num = num8;
			DrawLine(streamWriter, num8, text, num6 + num2, num7 + num3, num6 + num4, num7 + num5);
			num = DrawZaklepka_5(streamWriter, num, text, connection, num2 + num6, num3 + num7, num4 + num6, num5 + num7, 1);
			double num33 = Math.Acos(c / num26);
			num2 = num4;
			num3 = num5;
			num4 = num2 + num26 * Math.Cos(num33);
			num5 = num3 + num26 * Math.Sin(num33);
			num8 = (ushort)(num + 1);
			num = num8;
			DrawLine(streamWriter, num8, text, num6 + num2, num7 + num3, num6 + num4, num7 + num5);
			double num34 = 0.0;
			if (zhyrFiltr == "ні")
			{
				num = DrawZaklepka_6_2(streamWriter, num, text, connection, num2 + num6, num3 + num7, num4 + num6, num5 + num7, 1);
			}
			else if (implementation1 == "ж/ф в середині зонта")
			{
				num34 = (L1 - (double)a) * Math.Sqrt(Math.Pow(num26, 2.0) - Math.Pow(c, 2.0)) / ((double)L - (double)a) + num30 / (2.0 * Math.Sin(a3));
				double num35 = num26 - num34 / Math.Sin(num33);
				double num36 = num35 * Math.Cos(num33);
				double num37 = num35 * Math.Sin(num33);
				num = DrawZaklepka_6_1(streamWriter, num, text, connection, num2 + num6, num3 + num7, num4 + num6, num5 + num7, num36 + num2 + num6, num37 + num3 + num7, 1);
			}
			else
			{
				num = DrawZaklepka_6_2(streamWriter, num, text, connection, num2 + num6, num3 + num7, num4 + num6, num5 + num7, 1);
			}
			num2 = num4;
			num3 = num5;
			num4 = num2 + num23;
			num5 = num3 + num23;
			num8 = (ushort)(num + 1);
			num = num8;
			DrawLine(streamWriter, num8, text, num6 + num2, num7 + num3, num6 + num4, num7 + num5);
			num2 = num4;
			num3 = num5;
			num4 = num2 + ((double)a - 2.0 * num23);
			num8 = (ushort)(num + 1);
			num = num8;
			DrawLine(streamWriter, num8, text, num6 + num2, num7 + num3, num6 + num4, num7 + num5);
			num = DrawZaklepka_3(streamWriter, num, text, connection, num2 - num23 + num6, num3 + num7, num4 + num23 + num6, num3 + num7, 1);
			num2 = num4;
			num3 = num5;
			num4 = num2 + num23;
			num5 = num3 - num23;
			num8 = (ushort)(num + 1);
			num = num8;
			DrawLine(streamWriter, num8, text, num6 + num2, num7 + num3, num6 + num4, num7 + num5);
			num2 = 0.0;
			num3 = 0.0;
			num4 = num2 + (double)L;
			num5 = num3;
			num8 = (ushort)(num + 1);
			num = num8;
			DrawLine(streamWriter, num8, text, num6 + num2, num7 + num3, num6 + num4, num7 + num5);
			num2 = num4;
			num3 = num5;
			num4 = num2;
			num5 = num3 + num20;
			num8 = (ushort)(num + 1);
			num = num8;
			DrawLine(streamWriter, num8, text, num6 + num2, num7 + num3, num6 + num4, num7 + num5);
			num2 = num4;
			num3 = num5;
			num4 = num2 - num19;
			num5 = num3;
			num8 = (ushort)(num + 1);
			num = num8;
			DrawLine(streamWriter, num8, text, num6 + num2, num7 + num3, num6 + num4, num7 + num5);
			num2 = num4;
			num3 = num5;
			num4 = num2;
			num5 = num3 + num19;
			num8 = (ushort)(num + 1);
			num = num8;
			DrawLine(streamWriter, num8, text, num6 + num2, num7 + num3, num6 + num4, num7 + num5);
			num2 = num4;
			num3 = num5;
			num4 = num2 + num19;
			num5 = num3;
			num8 = (ushort)(num + 1);
			num = num8;
			DrawLine(streamWriter, num8, text, num6 + num2, num7 + num3, num6 + num4, num7 + num5);
			num2 = num4;
			num3 = num5;
			num4 = num2;
			num5 = num3 + num21;
			num8 = (ushort)(num + 1);
			num = num8;
			DrawLine(streamWriter, num8, text, num6 + num2, num7 + num3, num6 + num4, num7 + num5);
			num2 = num4;
			num3 = num5;
			num4 = num2 - num19;
			num5 = num3;
			num8 = (ushort)(num + 1);
			num = num8;
			DrawLine(streamWriter, num8, text, num6 + num2, num7 + num3, num6 + num4, num7 + num5);
			num2 = num4;
			num3 = num5;
			num4 = num2;
			num5 = num3 + num19;
			num8 = (ushort)(num + 1);
			num = num8;
			DrawLine(streamWriter, num8, text, num6 + num2, num7 + num3, num6 + num4, num7 + num5);
			num2 = num4;
			num3 = num5;
			num4 = num2 + num19;
			num5 = num3;
			num8 = (ushort)(num + 1);
			num = num8;
			DrawLine(streamWriter, num8, text, num6 + num2, num7 + num3, num6 + num4, num7 + num5);
			num2 = num4;
			num3 = num5;
			num4 = num2;
			num5 = num3 + (double)h;
			num8 = (ushort)(num + 1);
			num = num8;
			DrawLine(streamWriter, num8, text, num6 + num2, num7 + num3, num6 + num4, num7 + num5);
			num = DrawZaklepka_5(streamWriter, num, text, connection, num2 + num6, num3 + num7, num4 + num6, num5 + num7, 0);
			num33 = Math.Acos(((double)L - c - (double)a) / num29);
			num2 = num4;
			num3 = num5;
			num4 = num2 - num29 * Math.Cos(num33);
			num5 = num3 + num29 * Math.Sin(num33);
			num8 = (ushort)(num + 1);
			num = num8;
			DrawLine(streamWriter, num8, text, num6 + num2, num7 + num3, num6 + num4, num7 + num5);
			if (zhyrFiltr == "ні")
			{
				num = DrawZaklepka_7_2(streamWriter, num, text, connection, num4 + num6, num5 + num7, num2 + num6, num3 + num7, 1);
			}
			else if (implementation1 == "ж/ф в середині зонта")
			{
				num34 = (L1 - (double)a) * Math.Sqrt(Math.Pow(num26, 2.0) - Math.Pow(c, 2.0)) / ((double)L - (double)a) + num30 / (2.0 * Math.Sin(a3));
				double num38 = num34 / Math.Sin(num33);
				double num39 = num38 * Math.Cos(num33);
				double num40 = num38 * Math.Sin(num33);
				num = DrawZaklepka_7_1(streamWriter, num, text, connection, num4 + num6, num5 + num7, num2 + num6, num3 + num7, num39 + num4 + num6, num5 - num40 + num7, 1);
			}
			else
			{
				num = DrawZaklepka_7_2(streamWriter, num, text, connection, num4 + num6, num5 + num7, num2 + num6, num3 + num7, 1);
			}
			num6 += (double)(L + 100);
			num2 = 0.0;
			num3 = 0.0;
			num4 = num2;
			num5 = num3 + num20;
			num8 = (ushort)(num + 1);
			num = num8;
			DrawLine(streamWriter, num8, text, num6 + num2, num7 + num3, num6 + num4, num7 + num5);
			num2 = num4;
			num3 = num5;
			num4 = num2 + num19;
			num5 = num3;
			num8 = (ushort)(num + 1);
			num = num8;
			DrawLine(streamWriter, num8, text, num6 + num2, num7 + num3, num6 + num4, num7 + num5);
			num2 = num4;
			num3 = num5;
			num4 = num2;
			num5 = num3 + num19;
			num8 = (ushort)(num + 1);
			num = num8;
			DrawLine(streamWriter, num8, text, num6 + num2, num7 + num3, num6 + num4, num7 + num5);
			num2 = num4;
			num3 = num5;
			num4 = num2 - num19;
			num5 = num3;
			num8 = (ushort)(num + 1);
			num = num8;
			DrawLine(streamWriter, num8, text, num6 + num2, num7 + num3, num6 + num4, num7 + num5);
			num2 = num4;
			num3 = num5;
			num4 = num2;
			num5 = num3 + num21;
			num8 = (ushort)(num + 1);
			num = num8;
			DrawLine(streamWriter, num8, text, num6 + num2, num7 + num3, num6 + num4, num7 + num5);
			num2 = num4;
			num3 = num5;
			num4 = num2 + num19;
			num5 = num3;
			num8 = (ushort)(num + 1);
			num = num8;
			DrawLine(streamWriter, num8, text, num6 + num2, num7 + num3, num6 + num4, num7 + num5);
			num2 = num4;
			num3 = num5;
			num4 = num2;
			num5 = num3 + num19;
			num8 = (ushort)(num + 1);
			num = num8;
			DrawLine(streamWriter, num8, text, num6 + num2, num7 + num3, num6 + num4, num7 + num5);
			num2 = num4;
			num3 = num5;
			num4 = num2 - num19;
			num5 = num3;
			num8 = (ushort)(num + 1);
			num = num8;
			DrawLine(streamWriter, num8, text, num6 + num2, num7 + num3, num6 + num4, num7 + num5);
			num2 = num4;
			num3 = num5;
			num4 = num2;
			num5 = num3 + (double)h;
			num8 = (ushort)(num + 1);
			num = num8;
			DrawLine(streamWriter, num8, text, num6 + num2, num7 + num3, num6 + num4, num7 + num5);
			num = DrawZaklepka_5(streamWriter, num, text, connection, num2 + num6, num3 + num7, num4 + num6, num5 + num7, 1);
			num33 = Math.Acos(c / num27);
			num2 = num4;
			num3 = num5;
			num4 = num2 + num27 * Math.Cos(num33);
			num5 = num3 + num27 * Math.Sin(num33);
			num8 = (ushort)(num + 1);
			num = num8;
			DrawLine(streamWriter, num8, text, num6 + num2, num7 + num3, num6 + num4, num7 + num5);
			if (zhyrFiltr == "ні")
			{
				num = DrawZaklepka_6_2(streamWriter, num, text, connection, num2 + num6, num3 + num7, num4 + num6, num5 + num7, 1);
			}
			else if (implementation1 == "ж/ф в середині зонта")
			{
				num34 = (L1 - (double)a) * Math.Sqrt(Math.Pow(num27, 2.0) - Math.Pow(c, 2.0)) / ((double)L - (double)a) + num30 / (2.0 * Math.Sin(a4));
				double num41 = num27 - num34 / Math.Sin(num33);
				double num42 = num41 * Math.Cos(num33);
				double num43 = num41 * Math.Sin(num33);
				num = DrawZaklepka_6_1(streamWriter, num, text, connection, num2 + num6, num3 + num7, num4 + num6, num5 + num7, num41 + num2 + num6, num43 + num3 + num7, 1);
			}
			else
			{
				num = DrawZaklepka_6_2(streamWriter, num, text, connection, num2 + num6, num3 + num7, num4 + num6, num5 + num7, 1);
			}
			num2 = num4;
			num3 = num5;
			num4 = num2 + num23;
			num5 = num3 + num23;
			num8 = (ushort)(num + 1);
			num = num8;
			DrawLine(streamWriter, num8, text, num6 + num2, num7 + num3, num6 + num4, num7 + num5);
			num2 = num4;
			num3 = num5;
			num4 = num2 + ((double)a - 2.0 * num23);
			num8 = (ushort)(num + 1);
			num = num8;
			DrawLine(streamWriter, num8, text, num6 + num2, num7 + num3, num6 + num4, num7 + num5);
			num = DrawZaklepka_3(streamWriter, num, text, connection, num2 - num23 + num6, num3 + num7, num4 + num23 + num6, num3 + num7, 1);
			num2 = num4;
			num3 = num5;
			num4 = num2 + num23;
			num5 = num3 - num23;
			num8 = (ushort)(num + 1);
			num = num8;
			DrawLine(streamWriter, num8, text, num6 + num2, num7 + num3, num6 + num4, num7 + num5);
			num2 = 0.0;
			num3 = 0.0;
			num4 = num2 + (double)L;
			num5 = num3;
			num8 = (ushort)(num + 1);
			num = num8;
			DrawLine(streamWriter, num8, text, num6 + num2, num7 + num3, num6 + num4, num7 + num5);
			num2 = num4;
			num3 = num5;
			num4 = num2;
			num5 = num3 + num20;
			num8 = (ushort)(num + 1);
			num = num8;
			DrawLine(streamWriter, num8, text, num6 + num2, num7 + num3, num6 + num4, num7 + num5);
			num2 = num4;
			num3 = num5;
			num4 = num2 - num19;
			num5 = num3;
			num8 = (ushort)(num + 1);
			num = num8;
			DrawLine(streamWriter, num8, text, num6 + num2, num7 + num3, num6 + num4, num7 + num5);
			num2 = num4;
			num3 = num5;
			num4 = num2;
			num5 = num3 + num19;
			num8 = (ushort)(num + 1);
			num = num8;
			DrawLine(streamWriter, num8, text, num6 + num2, num7 + num3, num6 + num4, num7 + num5);
			num2 = num4;
			num3 = num5;
			num4 = num2 + num19;
			num5 = num3;
			num8 = (ushort)(num + 1);
			num = num8;
			DrawLine(streamWriter, num8, text, num6 + num2, num7 + num3, num6 + num4, num7 + num5);
			num2 = num4;
			num3 = num5;
			num4 = num2;
			num5 = num3 + num21;
			num8 = (ushort)(num + 1);
			num = num8;
			DrawLine(streamWriter, num8, text, num6 + num2, num7 + num3, num6 + num4, num7 + num5);
			num2 = num4;
			num3 = num5;
			num4 = num2 - num19;
			num5 = num3;
			num8 = (ushort)(num + 1);
			num = num8;
			DrawLine(streamWriter, num8, text, num6 + num2, num7 + num3, num6 + num4, num7 + num5);
			num2 = num4;
			num3 = num5;
			num4 = num2;
			num5 = num3 + num19;
			num8 = (ushort)(num + 1);
			num = num8;
			DrawLine(streamWriter, num8, text, num6 + num2, num7 + num3, num6 + num4, num7 + num5);
			num2 = num4;
			num3 = num5;
			num4 = num2 + num19;
			num5 = num3;
			num8 = (ushort)(num + 1);
			num = num8;
			DrawLine(streamWriter, num8, text, num6 + num2, num7 + num3, num6 + num4, num7 + num5);
			num2 = num4;
			num3 = num5;
			num4 = num2;
			num5 = num3 + (double)h;
			num8 = (ushort)(num + 1);
			num = num8;
			DrawLine(streamWriter, num8, text, num6 + num2, num7 + num3, num6 + num4, num7 + num5);
			num = DrawZaklepka_5(streamWriter, num, text, connection, num2 + num6, num3 + num7, num4 + num6, num5 + num7, 0);
			num33 = Math.Acos(((double)L - c - (double)a) / num28);
			num2 = num4;
			num3 = num5;
			num4 = num2 - num28 * Math.Cos(num33);
			num5 = num3 + num28 * Math.Sin(num33);
			num8 = (ushort)(num + 1);
			num = num8;
			DrawLine(streamWriter, num8, text, num6 + num2, num7 + num3, num6 + num4, num7 + num5);
			if (zhyrFiltr == "ні")
			{
				num = DrawZaklepka_7_2(streamWriter, num, text, connection, num4 + num6, num5 + num7, num2 + num6, num3 + num7, 1);
			}
			else if (implementation1 == "ж/ф в середині зонта")
			{
				num34 = (L1 - (double)a) * Math.Sqrt(Math.Pow(num27, 2.0) - Math.Pow(c, 2.0)) / ((double)L - (double)a) + num30 / (2.0 * Math.Sin(a4));
				double num44 = num34 / Math.Sin(num33);
				double num45 = num44 * Math.Cos(num33);
				double num46 = num44 * Math.Sin(num33);
				num = DrawZaklepka_7_1(streamWriter, num, text, connection, num4 + num6, num5 + num7, num2 + num6, num3 + num7, num45 + num4 + num6, num5 - num46 + num7, 1);
			}
			else
			{
				num = DrawZaklepka_7_2(streamWriter, num, text, connection, num4 + num6, num5 + num7, num2 + num6, num3 + num7, 1);
			}
			num6 -= (double)(L + 100);
			double num47 = ((num26 > num29) ? num26 : num29);
			if (num27 > num47)
			{
				num47 = num27;
			}
			if (num28 > num47)
			{
				num47 = num28;
			}
			num7 += num47 + 100.0;
			num2 = 0.0;
			num3 = 0.0;
			num4 = num2;
			num5 = num3 + num20;
			num8 = (ushort)(num + 1);
			num = num8;
			DrawLine(streamWriter, num8, text, num6 + num2, num7 + num3, num6 + num4, num7 + num5);
			num3 = num5;
			num4 = num2 - num21;
			num5 += num21;
			num8 = (ushort)(num + 1);
			num = num8;
			DrawLine(streamWriter, num8, text, num6 + num2, num7 + num3, num6 + num4, num7 + num5);
			num = DrawZaklepka_5_1(streamWriter, num, text, connection, num4 - num23 + num6, num5 + num7, num4 - num23 + num6, num5 + (double)h + num7, 1);
			double num48 = num4 - num23;
			double num49 = num5 + (double)h;
			num2 = num4;
			num3 = num5;
			num4 = num2 - num23;
			num5 += num23;
			num8 = (ushort)(num + 1);
			num = num8;
			DrawLine(streamWriter, num8, text, num6 + num2, num7 + num3, num6 + num4, num7 + num5);
			num2 = num4;
			num3 = num5;
			num4 = num2;
			num5 = num3 + (double)h + num26 - 2.0 * num23;
			num8 = (ushort)(num + 1);
			num = num8;
			DrawLine(streamWriter, num8, text, num6 + num2, num7 + num3, num6 + num4, num7 + num5);
			num33 = Math.Acos(0.0 / num26);
			if (zhyrFiltr == "ні")
			{
				num = DrawZaklepka_6_3(streamWriter, num, text, connection, num48 + num6, num49 + num7, num48 + num6, num5 + num23 + num7, 1);
			}
			else if (implementation1 == "ж/ф в середині зонта")
			{
				num34 = (L1 - (double)a) * Math.Sqrt(Math.Pow(num26, 2.0) - Math.Pow(c, 2.0)) / ((double)L - (double)a) + num30 / (2.0 * Math.Sin(a3));
				double num50 = num26 - num34 / Math.Sin(num33);
				double num51 = num50 * Math.Cos(num33);
				double num52 = num50 * Math.Sin(num33);
				num = DrawZaklepka_6(streamWriter, num, text, connection, num2 + num6, num3 + num7, num4 + num6, num5 + num7, num51 + num2 + num6, num52 + num3 + num7, 1);
			}
			else
			{
				num = DrawZaklepka_6_3(streamWriter, num, text, connection, num48 + num6, num49 + num7, num48 + num6, num5 + num23 + num7, 1);
			}
			num2 = num4;
			num3 = num5;
			num4 = num2 + 2.0 * num23;
			num5 = num3 + 2.0 * num23;
			num8 = (ushort)(num + 1);
			num = num8;
			DrawLine(streamWriter, num8, text, num6 + num2, num7 + num3, num6 + num4, num7 + num5);
			num2 = num4;
			num3 = num5;
			num4 = num2 + ((double)b - 2.0 * num23);
			num8 = (ushort)(num + 1);
			num = num8;
			DrawLine(streamWriter, num8, text, num6 + num2, num7 + num3, num6 + num4, num7 + num5);
			num = DrawZaklepka_3(streamWriter, num, text, connection, num2 - num23 + num6, num3 + num7, num4 + num23 + num6, num3 + num7, 1);
			num2 = num4;
			num3 = num5;
			num4 = num2 + num23;
			num5 = num3 - num23;
			num8 = (ushort)(num + 1);
			num = num8;
			DrawLine(streamWriter, num8, text, num6 + num2, num7 + num3, num6 + num4, num7 + num5);
			num2 = 0.0;
			num3 = 0.0;
			if (zhyrFiltr == "так" && implementation1 == "ж/ф внизу зонта (2 ряди)")
			{
				num4 = num2 + ((double)B - num22) / 2.0 - num21;
				num5 = num3;
				num8 = (ushort)(num + 1);
				num = num8;
				DrawLine(streamWriter, num8, text, num6 + num2, num7 + num3, num6 + num4, num7 + num5);
				num2 = num4;
				num3 = num5;
				num5 = num3 + num20;
				num8 = (ushort)(num + 1);
				num = num8;
				DrawLine(streamWriter, num8, text, num6 + num2, num7 + num3, num6 + num4, num7 + num5);
				num2 = num4;
				num3 = num5;
				num4 = num2 + num22;
				num8 = (ushort)(num + 1);
				num = num8;
				DrawLine(streamWriter, num8, text, num6 + num2, num7 + num3, num6 + num4, num7 + num5);
				num2 = num4;
				num3 = num5;
				num5 = num3 - num20;
				num8 = (ushort)(num + 1);
				num = num8;
				DrawLine(streamWriter, num8, text, num6 + num2, num7 + num3, num6 + num4, num7 + num5);
				num2 = num4;
				num3 = num5;
				num4 = num2 + ((double)B - num22) / 2.0 - num21;
				num5 = num3;
				num8 = (ushort)(num + 1);
				num = num8;
				DrawLine(streamWriter, num8, text, num6 + num2, num7 + num3, num6 + num4, num7 + num5);
			}
			else
			{
				num4 = num2 + (double)B - 2.0 * num21;
				num5 = num3;
				num8 = (ushort)(num + 1);
				num = num8;
				DrawLine(streamWriter, num8, text, num6 + num2, num7 + num3, num6 + num4, num7 + num5);
			}
			num2 = num4;
			num3 = num5;
			num4 = num2;
			num5 = num3 + num20;
			num8 = (ushort)(num + 1);
			num = num8;
			DrawLine(streamWriter, num8, text, num6 + num2, num7 + num3, num6 + num4, num7 + num5);
			num2 = num4;
			num3 = num5;
			num4 = num2 + num21;
			num5 = num3 + num21;
			num8 = (ushort)(num + 1);
			num = num8;
			DrawLine(streamWriter, num8, text, num6 + num2, num7 + num3, num6 + num4, num7 + num5);
			num49 = num5;
			num2 = num4;
			num3 = num5;
			num4 = num2 + num23;
			num5 = num3 + num23;
			num8 = (ushort)(num + 1);
			num = num8;
			DrawLine(streamWriter, num8, text, num6 + num2, num7 + num3, num6 + num4, num7 + num5);
			num48 = num4;
			num33 = Math.Acos((double)(B - b) / num27);
			double num53 = num23 * Math.Tan(num33);
			num2 = num4;
			num3 = num5;
			num4 = num2;
			num5 += (double)h - num23 - num53;
			num8 = (ushort)(num + 1);
			num = num8;
			DrawLine(streamWriter, num8, text, num6 + num2, num7 + num3, num6 + num4, num7 + num5);
			num2 = num4;
			num3 = num5;
			num4 = num2 - num23;
			num5 += num53;
			num8 = (ushort)(num + 1);
			num = num8;
			DrawLine(streamWriter, num8, text, num6 + num2, num7 + num3, num6 + num4, num7 + num5);
			num = DrawZaklepka_5(streamWriter, num, text, connection, num48 + num6, num49 + num7, num48 + num6, num5 + num7, 0);
			num48 = num4;
			num49 = num5;
			num2 = num4;
			num3 = num5;
			num5 += num23 / Math.Cos(num33);
			num8 = (ushort)(num + 1);
			num = num8;
			DrawLine(streamWriter, num8, text, num6 + num2, num7 + num3, num6 + num4, num7 + num5);
			num2 = num4;
			num3 = num5;
			num4 = num2 - (num27 - num23) * Math.Cos(num33) + num23 * Math.Sin(num33);
			num5 = num3 + (num27 - num23) * Math.Sin(num33) + num23 * Math.Cos(num33) - num23 / Math.Cos(num33);
			num8 = (ushort)(num + 1);
			num = num8;
			DrawLine(streamWriter, num8, text, num6 + num2, num7 + num3, num6 + num4, num7 + num5);
			num2 = num4;
			num3 = num5;
			num4 = num48 - num27 * Math.Cos(num33);
			num5 = num49 + num27 * Math.Sin(num33);
			num8 = (ushort)(num + 1);
			num = num8;
			DrawLine(streamWriter, num8, text, num6 + num2, num7 + num3, num6 + num4, num7 + num5);
			if (zhyrFiltr == "ні")
			{
				num = DrawZaklepka_7_3(streamWriter, num, text, connection, num4 + num23 * Math.Sin(num33) + num6, num5 + num23 * Math.Cos(num33) + num7, num48 + num23 * Math.Sin(num33) + num6, num49 + num23 * Math.Cos(num33) + num7, 1);
			}
			else if (implementation1 == "ж/ф в середині зонта")
			{
				double z = (num34 + num30 / 2.0) * num27 / ((double)H - (double)h);
				num = DrawZaklepka_7(streamWriter, num, text, connection, num4 + num23 * Math.Sin(num33) + num6, num5 + num23 * Math.Cos(num33) + num7, num48 + num23 * Math.Sin(num33) + num6, num49 + num23 * Math.Cos(num33) + num7, z, 1);
			}
			else
			{
				num = DrawZaklepka_7_3(streamWriter, num, text, connection, num4 + num23 * Math.Sin(num33) + num6, num5 + num23 * Math.Cos(num33) + num7, num48 + num23 * Math.Sin(num33) + num6, num49 + num23 * Math.Cos(num33) + num7, 1);
			}
			num6 += (double)(B + 100);
			num2 = 0.0;
			num3 = 0.0;
			num4 = num2;
			num5 = num3 + num20;
			num8 = (ushort)(num + 1);
			num = num8;
			DrawLine(streamWriter, num8, text, num6 + num2, num7 + num3, num6 + num4, num7 + num5);
			num3 = num5;
			num4 = num2 - num21;
			num5 += num21;
			num8 = (ushort)(num + 1);
			num = num8;
			DrawLine(streamWriter, num8, text, num6 + num2, num7 + num3, num6 + num4, num7 + num5);
			num = DrawZaklepka_5_1(streamWriter, num, text, connection, num4 - num23 + num6, num5 + num7, num4 - num23 + num6, num5 + (double)h + num7, 1);
			num48 = num4 - num23;
			num49 = num5 + (double)h;
			num2 = num4;
			num3 = num5;
			num4 = num2 - num23;
			num5 += num23;
			num8 = (ushort)(num + 1);
			num = num8;
			DrawLine(streamWriter, num8, text, num6 + num2, num7 + num3, num6 + num4, num7 + num5);
			num2 = num4;
			num3 = num5;
			num4 = num2;
			num5 = num3 + (double)h + num29 - 2.0 * num23;
			num8 = (ushort)(num + 1);
			num = num8;
			DrawLine(streamWriter, num8, text, num6 + num2, num7 + num3, num6 + num4, num7 + num5);
			if (zhyrFiltr == "ні")
			{
				num = DrawZaklepka_6_3(streamWriter, num, text, connection, num48 + num6, num49 + num7, num48 + num6, num5 + num23 + num7, 1);
			}
			else if (implementation1 == "ж/ф в середині зонта")
			{
				double num54 = ((double)H - (double)h - num34 - num30 / 2.0) * num29 / ((double)H - (double)h);
			}
			else
			{
				num = DrawZaklepka_6_3(streamWriter, num, text, connection, num48 + num6, num49 + num7, num48 + num6, num5 + num23 + num7, 1);
			}
			num2 = num4;
			num3 = num5;
			num4 = num2 + 2.0 * num23;
			num5 = num3 + 2.0 * num23;
			num8 = (ushort)(num + 1);
			num = num8;
			DrawLine(streamWriter, num8, text, num6 + num2, num7 + num3, num6 + num4, num7 + num5);
			num2 = num4;
			num3 = num5;
			num4 = num2 + ((double)b - 2.0 * num23);
			num8 = (ushort)(num + 1);
			num = num8;
			DrawLine(streamWriter, num8, text, num6 + num2, num7 + num3, num6 + num4, num7 + num5);
			num = DrawZaklepka_3(streamWriter, num, text, connection, num2 - num23 + num6, num3 + num7, num4 + num23 + num6, num3 + num7, 1);
			num2 = num4;
			num3 = num5;
			num4 = num2 + num23;
			num5 = num3 - num23;
			num8 = (ushort)(num + 1);
			num = num8;
			DrawLine(streamWriter, num8, text, num6 + num2, num7 + num3, num6 + num4, num7 + num5);
			num2 = 0.0;
			num3 = 0.0;
			if (zhyrFiltr == "так" && implementation1 == "ж/ф внизу зонта (2 ряди)")
			{
				num4 = num2 + ((double)B - num22) / 2.0 - num21;
				num5 = num3;
				num8 = (ushort)(num + 1);
				num = num8;
				DrawLine(streamWriter, num8, text, num6 + num2, num7 + num3, num6 + num4, num7 + num5);
				num2 = num4;
				num3 = num5;
				num5 = num3 + num20;
				num8 = (ushort)(num + 1);
				num = num8;
				DrawLine(streamWriter, num8, text, num6 + num2, num7 + num3, num6 + num4, num7 + num5);
				num2 = num4;
				num3 = num5;
				num4 = num2 + num22;
				num8 = (ushort)(num + 1);
				num = num8;
				DrawLine(streamWriter, num8, text, num6 + num2, num7 + num3, num6 + num4, num7 + num5);
				num2 = num4;
				num3 = num5;
				num5 = num3 - num20;
				num8 = (ushort)(num + 1);
				num = num8;
				DrawLine(streamWriter, num8, text, num6 + num2, num7 + num3, num6 + num4, num7 + num5);
				num2 = num4;
				num3 = num5;
				num4 = num2 + ((double)B - num22) / 2.0 - num21;
				num5 = num3;
				num8 = (ushort)(num + 1);
				num = num8;
				DrawLine(streamWriter, num8, text, num6 + num2, num7 + num3, num6 + num4, num7 + num5);
			}
			else
			{
				num4 = num2 + (double)B - 2.0 * num21;
				num5 = num3;
				num8 = (ushort)(num + 1);
				num = num8;
				DrawLine(streamWriter, num8, text, num6 + num2, num7 + num3, num6 + num4, num7 + num5);
			}
			num2 = num4;
			num3 = num5;
			num4 = num2;
			num5 = num3 + num20;
			num8 = (ushort)(num + 1);
			num = num8;
			DrawLine(streamWriter, num8, text, num6 + num2, num7 + num3, num6 + num4, num7 + num5);
			num2 = num4;
			num3 = num5;
			num4 = num2 + num21;
			num5 = num3 + num21;
			num8 = (ushort)(num + 1);
			num = num8;
			DrawLine(streamWriter, num8, text, num6 + num2, num7 + num3, num6 + num4, num7 + num5);
			num49 = num5;
			num2 = num4;
			num3 = num5;
			num4 = num2 + num23;
			num5 = num3 + num23;
			num8 = (ushort)(num + 1);
			num = num8;
			DrawLine(streamWriter, num8, text, num6 + num2, num7 + num3, num6 + num4, num7 + num5);
			num48 = num4;
			num33 = Math.Acos((double)(B - b) / num28);
			num53 = num23 * Math.Tan(num33);
			num2 = num4;
			num3 = num5;
			num4 = num2;
			num5 += (double)h - num23 - num53;
			num8 = (ushort)(num + 1);
			num = num8;
			DrawLine(streamWriter, num8, text, num6 + num2, num7 + num3, num6 + num4, num7 + num5);
			num2 = num4;
			num3 = num5;
			num4 = num2 - num23;
			num5 += num53;
			num8 = (ushort)(num + 1);
			num = num8;
			DrawLine(streamWriter, num8, text, num6 + num2, num7 + num3, num6 + num4, num7 + num5);
			num = DrawZaklepka_5(streamWriter, num, text, connection, num48 + num6, num49 + num7, num48 + num6, num5 + num7, 0);
			num48 = num4;
			num49 = num5;
			num2 = num4;
			num3 = num5;
			num5 += num23 / Math.Cos(num33);
			num8 = (ushort)(num + 1);
			num = num8;
			DrawLine(streamWriter, num8, text, num6 + num2, num7 + num3, num6 + num4, num7 + num5);
			num2 = num4;
			num3 = num5;
			num4 = num2 - (num28 - num23) * Math.Cos(num33) + num23 * Math.Sin(num33);
			num5 = num3 + (num28 - num23) * Math.Sin(num33) + num23 * Math.Cos(num33) - num23 / Math.Cos(num33);
			num8 = (ushort)(num + 1);
			num = num8;
			DrawLine(streamWriter, num8, text, num6 + num2, num7 + num3, num6 + num4, num7 + num5);
			num2 = num4;
			num3 = num5;
			num4 = num48 - num28 * Math.Cos(num33);
			num5 = num49 + num28 * Math.Sin(num33);
			num8 = (ushort)(num + 1);
			num = num8;
			DrawLine(streamWriter, num8, text, num6 + num2, num7 + num3, num6 + num4, num7 + num5);
			if (zhyrFiltr == "ні")
			{
				num = DrawZaklepka_7_3(streamWriter, num, text, connection, num4 + num23 * Math.Sin(num33) + num6, num5 + num23 * Math.Cos(num33) + num7, num48 + num23 * Math.Sin(num33) + num6, num49 + num23 * Math.Cos(num33) + num7, 1);
			}
			else if (implementation1 == "ж/ф в середині зонта")
			{
				double z2 = (num34 + num30 / 2.0) * num28 / ((double)H - (double)h);
				num = DrawZaklepka_7(streamWriter, num, text, connection, num4 + num23 * Math.Sin(num33) + num6, num5 + num23 * Math.Cos(num33) + num7, num48 + num23 * Math.Sin(num33) + num6, num49 + num23 * Math.Cos(num33) + num7, z2, 1);
			}
			else
			{
				num = DrawZaklepka_7_3(streamWriter, num, text, connection, num4 + num23 * Math.Sin(num33) + num6, num5 + num23 * Math.Cos(num33) + num7, num48 + num23 * Math.Sin(num33) + num6, num49 + num23 * Math.Cos(num33) + num7, 1);
			}
			if (zhyrFiltr == "так")
			{
				if (implementation1 == "ж/ф внизу зонта (2 ряди)")
				{
					num6 = L + B + 1000;
					num7 = a + 300;
					double num55 = 54.5;
					double num56 = 15.0;
					num2 = 0.0;
					num3 = 0.0;
					num4 = num2;
					num5 = num3 + num56;
					num8 = (ushort)(num + 1);
					num = num8;
					DrawLine(streamWriter, num8, text, num6 + num2, num7 + num3, num6 + num4, num7 + num5);
					num2 = num4;
					num3 = num5;
					num4 = num2 + num19;
					num5 = num3;
					num8 = (ushort)(num + 1);
					num = num8;
					DrawLine(streamWriter, num8, text, num6 + num2, num7 + num3, num6 + num4, num7 + num5);
					num2 = num4;
					num3 = num5;
					num4 = num2;
					num5 = num3 + num19;
					num8 = (ushort)(num + 1);
					num = num8;
					DrawLine(streamWriter, num8, text, num6 + num2, num7 + num3, num6 + num4, num7 + num5);
					num2 = num4;
					num3 = num5;
					num4 = num2 - num19;
					num5 = num3;
					num8 = (ushort)(num + 1);
					num = num8;
					DrawLine(streamWriter, num8, text, num6 + num2, num7 + num3, num6 + num4, num7 + num5);
					num2 = num4;
					num3 = num5;
					num4 = num2;
					num5 = num3 + num55;
					num8 = (ushort)(num + 1);
					num = num8;
					DrawLine(streamWriter, num8, text, num6 + num2, num7 + num3, num6 + num4, num7 + num5);
					num2 = num4;
					num3 = num5;
					num4 = num2 + (double)(L - 10);
					num5 = num3;
					num8 = (ushort)(num + 1);
					num = num8;
					DrawLine(streamWriter, num8, text, num6 + num2, num7 + num3, num6 + num4, num7 + num5);
					num2 = num4;
					num3 = num5;
					num4 = num2;
					num5 = num3 - num55;
					num8 = (ushort)(num + 1);
					num = num8;
					DrawLine(streamWriter, num8, text, num6 + num2, num7 + num3, num6 + num4, num7 + num5);
					num2 = num4;
					num3 = num5;
					num4 = num2 - num19;
					num5 = num3;
					num8 = (ushort)(num + 1);
					num = num8;
					DrawLine(streamWriter, num8, text, num6 + num2, num7 + num3, num6 + num4, num7 + num5);
					num2 = num4;
					num3 = num5;
					num4 = num2;
					num5 = num3 - num19;
					num8 = (ushort)(num + 1);
					num = num8;
					DrawLine(streamWriter, num8, text, num6 + num2, num7 + num3, num6 + num4, num7 + num5);
					num2 = num4;
					num3 = num5;
					num4 = num2 + num19;
					num5 = num3;
					num8 = (ushort)(num + 1);
					num = num8;
					DrawLine(streamWriter, num8, text, num6 + num2, num7 + num3, num6 + num4, num7 + num5);
					num2 = num4;
					num3 = num5;
					num4 = num2;
					num5 = num3 - num56;
					num8 = (ushort)(num + 1);
					num = num8;
					DrawLine(streamWriter, num8, text, num6 + num2, num7 + num3, num6 + num4, num7 + num5);
					if (zlyv == "ні")
					{
						num2 = num4;
						num3 = num5;
						num4 = num2 - (double)(L - 10);
						num5 = num3;
						num8 = (ushort)(num + 1);
						num = num8;
						DrawLine(streamWriter, num8, text, num6 + num2, num7 + num3, num6 + num4, num7 + num5);
					}
					else
					{
						double num57 = 12.5;
						double num58 = 10.5;
						double num59 = 72.5;
						num2 = num4 - (double)(L - 10);
						num3 = num5;
						num4 = num2 + num59 - num57;
						num5 = num3;
						num8 = (ushort)(num + 1);
						num = num8;
						DrawLine(streamWriter, num8, text, num6 + num2, num7 + num3, num6 + num4, num7 + num5);
						double num60 = num4;
						double num61 = num5;
						double num62 = 15.0;
						double num63 = 16.0;
						double num64 = 40.0;
						double num65 = 7.0;
						num2 += num62;
						num3 += num63;
						num4 = num2;
						num5 = num3 + num65;
						num8 = (ushort)(num + 1);
						num = num8;
						DrawLine(streamWriter, num8, text, num6 + num2, num7 + num3, num6 + num4, num7 + num5);
						num2 = num4;
						num3 = num5;
						num4 = num2 + num64;
						num5 = num3;
						num8 = (ushort)(num + 1);
						num = num8;
						DrawLine(streamWriter, num8, text, num6 + num2, num7 + num3, num6 + num4, num7 + num5);
						num2 = num4;
						num3 = num5;
						num4 = num2;
						num5 = num3 - num65;
						num8 = (ushort)(num + 1);
						num = num8;
						DrawLine(streamWriter, num8, text, num6 + num2, num7 + num3, num6 + num4, num7 + num5);
						num2 = num4;
						num3 = num5;
						num4 = num2 - num64;
						num5 = num3;
						num8 = (ushort)(num + 1);
						num = num8;
						DrawLine(streamWriter, num8, text, num6 + num2, num7 + num3, num6 + num4, num7 + num5);
						num2 = num60;
						num3 = num61;
						num4 = num2;
						num5 = num3 + num58 + num57;
						num8 = (ushort)(num + 1);
						num = num8;
						DrawLine(streamWriter, num8, text, num6 + num2, num7 + num3, num6 + num4, num7 + num5);
						num2 = num4;
						num3 = num5;
						num4 = num2 + 2.0 * num57;
						num5 = num3;
						num8 = (ushort)(num + 1);
						num = num8;
						DrawLine(streamWriter, num8, text, num6 + num2, num7 + num3, num6 + num4, num7 + num5);
						num2 = num4;
						num3 = num5;
						num4 = num2;
						num5 = num3 - (num58 + num57);
						num8 = (ushort)(num + 1);
						num = num8;
						DrawLine(streamWriter, num8, text, num6 + num2, num7 + num3, num6 + num4, num7 + num5);
						num60 = num4;
						num61 = num5;
						double num66 = 34.0;
						num62 = num4 + 5.0;
						num63 += num5;
						int num67 = (int)Math.Floor(((double)(L - 10) - num62) / (num66 + num64));
						for (int j = 0; j < num67; j++)
						{
							num2 = num62 + (double)j * (num66 + num64);
							num3 = num63;
							num4 = num2;
							num5 = num3 + num65;
							num8 = (ushort)(num + 1);
							num = num8;
							DrawLine(streamWriter, num8, text, num6 + num2, num7 + num3, num6 + num4, num7 + num5);
							num2 = num4;
							num3 = num5;
							num4 = num2 + num64;
							num5 = num3;
							num8 = (ushort)(num + 1);
							num = num8;
							DrawLine(streamWriter, num8, text, num6 + num2, num7 + num3, num6 + num4, num7 + num5);
							num2 = num4;
							num3 = num5;
							num4 = num2;
							num5 = num3 - num65;
							num8 = (ushort)(num + 1);
							num = num8;
							DrawLine(streamWriter, num8, text, num6 + num2, num7 + num3, num6 + num4, num7 + num5);
							num2 = num4;
							num3 = num5;
							num4 = num2 - num64;
							num5 = num3;
							num8 = (ushort)(num + 1);
							num = num8;
							DrawLine(streamWriter, num8, text, num6 + num2, num7 + num3, num6 + num4, num7 + num5);
						}
						num2 = num60;
						num3 = num61;
						num4 = num2 + (double)L - 10.0 - (num59 + num57);
						num5 = num3;
						num8 = (ushort)(num + 1);
						num = num8;
						DrawLine(streamWriter, num8, text, num6 + num2, num7 + num3, num6 + num4, num7 + num5);
					}
					num55 = 24.5;
					num56 = 109.0;
					num6 = L + B + 1000;
					num7 = a + 300 + 300;
					num2 = 0.0;
					num3 = 0.0;
					num4 = num2;
					num5 = num3 + num55;
					num8 = (ushort)(num + 1);
					num = num8;
					DrawLine(streamWriter, num8, text, num6 + num2, num7 + num3, num6 + num4, num7 + num5);
					num2 = num4;
					num3 = num5;
					num4 = num2 + num19;
					num5 = num3;
					num8 = (ushort)(num + 1);
					num = num8;
					DrawLine(streamWriter, num8, text, num6 + num2, num7 + num3, num6 + num4, num7 + num5);
					num2 = num4;
					num3 = num5;
					num4 = num2;
					num5 = num3 + num19;
					num8 = (ushort)(num + 1);
					num = num8;
					DrawLine(streamWriter, num8, text, num6 + num2, num7 + num3, num6 + num4, num7 + num5);
					num2 = num4;
					num3 = num5;
					num4 = num2 - num19;
					num5 = num3;
					num8 = (ushort)(num + 1);
					num = num8;
					DrawLine(streamWriter, num8, text, num6 + num2, num7 + num3, num6 + num4, num7 + num5);
					num2 = num4;
					num3 = num5;
					num4 = num2;
					num5 = num3 + num56;
					num8 = (ushort)(num + 1);
					num = num8;
					DrawLine(streamWriter, num8, text, num6 + num2, num7 + num3, num6 + num4, num7 + num5);
					num = DrawZaklepka_Top_2(streamWriter, num, text, connection, num2 + num6, num3 + num7, num4 + num6, num5 + num7, 1);
					num2 = num4;
					num3 = num5;
					num4 = num2 + num19;
					num5 = num3;
					num8 = (ushort)(num + 1);
					num = num8;
					DrawLine(streamWriter, num8, text, num6 + num2, num7 + num3, num6 + num4, num7 + num5);
					num2 = num4;
					num3 = num5;
					num4 = num2;
					num5 = num3 + num19;
					num8 = (ushort)(num + 1);
					num = num8;
					DrawLine(streamWriter, num8, text, num6 + num2, num7 + num3, num6 + num4, num7 + num5);
					num2 = num4;
					num3 = num5;
					num4 = num2 - num19;
					num5 = num3;
					num8 = (ushort)(num + 1);
					num = num8;
					DrawLine(streamWriter, num8, text, num6 + num2, num7 + num3, num6 + num4, num7 + num5);
					num2 = num4;
					num3 = num5;
					num4 = num2;
					num5 = num3 + num55;
					num8 = (ushort)(num + 1);
					num = num8;
					DrawLine(streamWriter, num8, text, num6 + num2, num7 + num3, num6 + num4, num7 + num5);
					num2 = num4;
					num3 = num5;
					num4 = num2 + (double)L - 5.0;
					num5 = num3;
					num8 = (ushort)(num + 1);
					num = num8;
					DrawLine(streamWriter, num8, text, num6 + num2, num7 + num3, num6 + num4, num7 + num5);
					num2 = num4;
					num3 = num5;
					num4 = num2;
					num5 = num3 - num55;
					num8 = (ushort)(num + 1);
					num = num8;
					DrawLine(streamWriter, num8, text, num6 + num2, num7 + num3, num6 + num4, num7 + num5);
					num2 = num4;
					num3 = num5;
					num4 = num2 - num19;
					num5 = num3;
					num8 = (ushort)(num + 1);
					num = num8;
					DrawLine(streamWriter, num8, text, num6 + num2, num7 + num3, num6 + num4, num7 + num5);
					num2 = num4;
					num3 = num5;
					num4 = num2;
					num5 = num3 - num19;
					num8 = (ushort)(num + 1);
					num = num8;
					DrawLine(streamWriter, num8, text, num6 + num2, num7 + num3, num6 + num4, num7 + num5);
					num2 = num4;
					num3 = num5;
					num4 = num2 + num19;
					num5 = num3;
					num8 = (ushort)(num + 1);
					num = num8;
					DrawLine(streamWriter, num8, text, num6 + num2, num7 + num3, num6 + num4, num7 + num5);
					num2 = num4;
					num3 = num5;
					num4 = num2;
					num5 = num3 - num56;
					num8 = (ushort)(num + 1);
					num = num8;
					DrawLine(streamWriter, num8, text, num6 + num2, num7 + num3, num6 + num4, num7 + num5);
					num = DrawZaklepka_Top_2(streamWriter, num, text, connection, num2 + num6, num3 + num7, num4 + num6, num5 + num7, 1);
					num2 = num4;
					num3 = num5;
					num4 = num2 - num19;
					num5 = num3;
					num8 = (ushort)(num + 1);
					num = num8;
					DrawLine(streamWriter, num8, text, num6 + num2, num7 + num3, num6 + num4, num7 + num5);
					num2 = num4;
					num3 = num5;
					num4 = num2;
					num5 = num3 - num19;
					num8 = (ushort)(num + 1);
					num = num8;
					DrawLine(streamWriter, num8, text, num6 + num2, num7 + num3, num6 + num4, num7 + num5);
					num2 = num4;
					num3 = num5;
					num4 = num2 + num19;
					num5 = num3;
					num8 = (ushort)(num + 1);
					num = num8;
					DrawLine(streamWriter, num8, text, num6 + num2, num7 + num3, num6 + num4, num7 + num5);
					num2 = num4;
					num3 = num5;
					num4 = num2;
					num5 = num3 - num55;
					num8 = (ushort)(num + 1);
					num = num8;
					DrawLine(streamWriter, num8, text, num6 + num2, num7 + num3, num6 + num4, num7 + num5);
					if (zhyrFiltr == "так" && zlyv != "ні")
					{
						double num68 = 75.0;
						double num69 = 80.0;
						double num70 = 16.0;
						num2 = ((zlyv == "так, трубка справа") ? (num4 - num68) : (num4 - (double)(L - 5) + num68));
						num3 = num5 + num69;
						num8 = (ushort)(num + 1);
						num = num8;
						DrawCircle(streamWriter, num8, text, num6 + num2, num7 + num3, num70 / 2.0);
					}
					num2 = num4;
					num3 = num5;
					num4 = num2 - (double)(L - 5);
					num5 = num3;
					num8 = (ushort)(num + 1);
					num = num8;
					DrawLine(streamWriter, num8, text, num6 + num2, num7 + num3, num6 + num4, num7 + num5);
				}
				else
				{
					num6 = L + B + 1000;
					num7 = a + 300;
					double num71 = 9.5;
					double num72 = 59.0;
					double num73 = 64.5;
					double num74 = 17.0;
					double num75 = 20.0;
					double num76 = 70.0;
					double d3 = 2.65;
					num2 = (double)l + num76;
					num3 = 0.0;
					num4 = num2 - ((double)l + num76);
					num5 = num3;
					num8 = (ushort)(num + 1);
					num = num8;
					DrawLine(streamWriter, num8, text, num6 + num2, num7 + num3, num6 + num4, num7 + num5);
					num2 = num4;
					num3 = num5;
					num5 = num3 + num71;
					num8 = (ushort)(num + 1);
					num = num8;
					DrawLine(streamWriter, num8, text, num6 + num2, num7 + num3, num6 + num4, num7 + num5);
					num2 = num4;
					num3 = num5;
					num4 = num2 + num19;
					num5 = num3;
					num8 = (ushort)(num + 1);
					num = num8;
					DrawLine(streamWriter, num8, text, num6 + num2, num7 + num3, num6 + num4, num7 + num5);
					num2 = num4;
					num3 = num5;
					num4 = num2;
					num5 = num3 + num19;
					num8 = (ushort)(num + 1);
					num = num8;
					DrawLine(streamWriter, num8, text, num6 + num2, num7 + num3, num6 + num4, num7 + num5);
					num2 = num4;
					num3 = num5;
					num4 = num2 - num19;
					num5 = num3;
					num8 = (ushort)(num + 1);
					num = num8;
					DrawLine(streamWriter, num8, text, num6 + num2, num7 + num3, num6 + num4, num7 + num5);
					num2 = num4;
					num3 = num5;
					num5 = num3 + num72;
					num8 = (ushort)(num + 1);
					num = num8;
					DrawLine(streamWriter, num8, text, num6 + num2, num7 + num3, num6 + num4, num7 + num5);
					num8 = (ushort)(num + 1);
					num = num8;
					DrawCircle(streamWriter, num8, text, num6 + num4 + 50.65, num7 + num5 - 39.5, d3);
					num2 = num4;
					num3 = num5;
					num4 = num2 + num19;
					num5 = num3;
					num8 = (ushort)(num + 1);
					num = num8;
					DrawLine(streamWriter, num8, text, num6 + num2, num7 + num3, num6 + num4, num7 + num5);
					num2 = num4;
					num3 = num5;
					num4 = num2;
					num5 = num3 + num19;
					num8 = (ushort)(num + 1);
					num = num8;
					DrawLine(streamWriter, num8, text, num6 + num2, num7 + num3, num6 + num4, num7 + num5);
					num2 = num4;
					num3 = num5;
					num4 = num2 - num19;
					num5 = num3;
					num8 = (ushort)(num + 1);
					num = num8;
					DrawLine(streamWriter, num8, text, num6 + num2, num7 + num3, num6 + num4, num7 + num5);
					num8 = (ushort)(num + 1);
					num = num8;
					DrawCircle(streamWriter, num8, text, num6 + num4 + 7.0, num7 + num5 + 15.75, d3);
					num8 = (ushort)(num + 1);
					num = num8;
					DrawCircle(streamWriter, num8, text, num6 + num4 + 7.0, num7 + num5 + 15.75 + 32.5, d3);
					num2 = num4;
					num3 = num5;
					num5 = num3 + num73;
					num8 = (ushort)(num + 1);
					num = num8;
					DrawLine(streamWriter, num8, text, num6 + num2, num7 + num3, num6 + num4, num7 + num5);
					num2 = num4;
					num3 = num5;
					num4 = num2 + num74;
					num8 = (ushort)(num + 1);
					num = num8;
					DrawLine(streamWriter, num8, text, num6 + num2, num7 + num3, num6 + num4, num7 + num5);
					num2 = num4;
					num3 = num5;
					num4 = num2 + num75 / Math.Tan(Math.PI / 6.0);
					num5 = num3 + num75;
					num8 = (ushort)(num + 1);
					num = num8;
					DrawLine(streamWriter, num8, text, num6 + num2, num7 + num3, num6 + num4, num7 + num5);
					num8 = (ushort)(num + 1);
					num = num8;
					DrawCircle(streamWriter, num8, text, num6 + num2 + 35.0, num7 + num5 - 10.0, d3);
					num2 = num4;
					num3 = num5;
					num4 = num2 + (double)l + num76 - 2.0 * (num75 / Math.Tan(Math.PI / 6.0) + num74);
					num8 = (ushort)(num + 1);
					num = num8;
					DrawLine(streamWriter, num8, text, num6 + num2, num7 + num3, num6 + num4, num7 + num5);
					num8 = (ushort)(num + 1);
					num = num8;
					DrawCircle(streamWriter, num8, text, num6 + num2 + ((double)l + num76 - 2.0 * (num75 / Math.Tan(Math.PI / 6.0) + num74)) / 2.0, num7 + num5 - 10.0, d3);
					num2 = num4;
					num3 = num5;
					num4 = num2 + num75 / Math.Tan(Math.PI / 6.0);
					num5 = num3 - num75;
					num8 = (ushort)(num + 1);
					num = num8;
					DrawLine(streamWriter, num8, text, num6 + num2, num7 + num3, num6 + num4, num7 + num5);
					num8 = (ushort)(num + 1);
					num = num8;
					DrawCircle(streamWriter, num8, text, num6 + num4 - 35.0, num7 + num3 - 10.0, d3);
					num2 = num4;
					num3 = num5;
					num4 = num2 + num74;
					num8 = (ushort)(num + 1);
					num = num8;
					DrawLine(streamWriter, num8, text, num6 + num2, num7 + num3, num6 + num4, num7 + num5);
					num2 = num4;
					num3 = num5;
					num5 = num3 - num73;
					num8 = (ushort)(num + 1);
					num = num8;
					DrawLine(streamWriter, num8, text, num6 + num2, num7 + num3, num6 + num4, num7 + num5);
					num8 = (ushort)(num + 1);
					num = num8;
					DrawCircle(streamWriter, num8, text, num6 + num4 - 7.0, num7 + num5 + 15.75, d3);
					num8 = (ushort)(num + 1);
					num = num8;
					DrawCircle(streamWriter, num8, text, num6 + num4 - 7.0, num7 + num5 + 15.75 + 32.5, d3);
					num2 = num4;
					num3 = num5;
					num4 = num2 - num19;
					num5 = num3;
					num8 = (ushort)(num + 1);
					num = num8;
					DrawLine(streamWriter, num8, text, num6 + num2, num7 + num3, num6 + num4, num7 + num5);
					num2 = num4;
					num3 = num5;
					num4 = num2;
					num5 = num3 - num19;
					num8 = (ushort)(num + 1);
					num = num8;
					DrawLine(streamWriter, num8, text, num6 + num2, num7 + num3, num6 + num4, num7 + num5);
					num2 = num4;
					num3 = num5;
					num4 = num2 + num19;
					num5 = num3;
					num8 = (ushort)(num + 1);
					num = num8;
					DrawLine(streamWriter, num8, text, num6 + num2, num7 + num3, num6 + num4, num7 + num5);
					num2 = num4;
					num3 = num5;
					num5 = num3 - num72;
					num8 = (ushort)(num + 1);
					num = num8;
					DrawLine(streamWriter, num8, text, num6 + num2, num7 + num3, num6 + num4, num7 + num5);
					num2 = num4;
					num3 = num5;
					num4 = num2 - num19;
					num5 = num3;
					num8 = (ushort)(num + 1);
					num = num8;
					DrawLine(streamWriter, num8, text, num6 + num2, num7 + num3, num6 + num4, num7 + num5);
					num2 = num4;
					num3 = num5;
					num4 = num2;
					num5 = num3 - num19;
					num8 = (ushort)(num + 1);
					num = num8;
					DrawLine(streamWriter, num8, text, num6 + num2, num7 + num3, num6 + num4, num7 + num5);
					num2 = num4;
					num3 = num5;
					num4 = num2 + num19;
					num5 = num3;
					num8 = (ushort)(num + 1);
					num = num8;
					DrawLine(streamWriter, num8, text, num6 + num2, num7 + num3, num6 + num4, num7 + num5);
					num2 = num4;
					num3 = num5;
					num5 = num3 - num71;
					num8 = (ushort)(num + 1);
					num = num8;
					DrawLine(streamWriter, num8, text, num6 + num2, num7 + num3, num6 + num4, num7 + num5);
					num8 = (ushort)(num + 1);
					num = num8;
					DrawCircle(streamWriter, num8, text, num6 + num4 - 50.65, num7 + num5 + 30.0, d3);
					num6 = L + B + 1000;
					num7 = a + 600;
					double num77 = 20.0;
					double num78 = 60.0 - num19 * Math.Cos(Math.PI / 4.0) / 2.0;
					double num79 = 15.0;
					double num80 = 35.0;
					num2 = kk - num78 - num19 * Math.Cos(Math.PI / 4.0) / 2.0;
					num3 = 0.0;
					num4 = num78 + num19 * Math.Cos(Math.PI / 4.0) / 2.0;
					num5 = num3;
					num8 = (ushort)(num + 1);
					num = num8;
					DrawLine(streamWriter, num8, text, num6 + num2, num7 + num3, num6 + num4, num7 + num5);
					num2 = num4;
					num3 = num5;
					num4 = num2;
					num5 = num3 + num77;
					num8 = (ushort)(num + 1);
					num = num8;
					DrawLine(streamWriter, num8, text, num6 + num2, num7 + num3, num6 + num4, num7 + num5);
					num2 = num4;
					num3 = num5;
					num4 = num2 - num78;
					num5 = num3 + num78;
					num8 = (ushort)(num + 1);
					num = num8;
					DrawLine(streamWriter, num8, text, num6 + num2, num7 + num3, num6 + num4, num7 + num5);
					num8 = (ushort)(num + 1);
					num = num8;
					DrawCircle(streamWriter, num8, text, num6 + num4 - num19 * Math.Cos(Math.PI / 4.0) / 2.0 + 40.0 + 7.0 / Math.Cos(Math.PI / 4.0), num7 + num5 + num19 * Math.Cos(Math.PI / 4.0) / 2.0 - 40.0, d3);
					num2 = num4;
					num3 = num5;
					num4 = num2 + num19 * Math.Cos(Math.PI / 4.0);
					num5 = num3 + num19 * Math.Sin(Math.PI / 4.0);
					num8 = (ushort)(num + 1);
					num = num8;
					DrawLine(streamWriter, num8, text, num6 + num2, num7 + num3, num6 + num4, num7 + num5);
					num2 = num4;
					num3 = num5;
					num4 = num2 - num19 * Math.Cos(Math.PI / 4.0);
					num5 = num3 + num19 * Math.Sin(Math.PI / 4.0);
					num8 = (ushort)(num + 1);
					num = num8;
					DrawLine(streamWriter, num8, text, num6 + num2, num7 + num3, num6 + num4, num7 + num5);
					num2 = num4;
					num3 = num5;
					num4 = num2 - num19 * Math.Cos(Math.PI / 4.0);
					num5 = num3 - num19 * Math.Sin(Math.PI / 4.0);
					num8 = (ushort)(num + 1);
					num = num8;
					DrawLine(streamWriter, num8, text, num6 + num2, num7 + num3, num6 + num4, num7 + num5);
					num2 = num4;
					num3 = num5;
					num4 = num2 - (num79 - num19 * Math.Cos(Math.PI / 4.0) / 2.0);
					num5 = num3 + (num79 - num19 * Math.Cos(Math.PI / 4.0) / 2.0);
					num8 = (ushort)(num + 1);
					num = num8;
					DrawLine(streamWriter, num8, text, num6 + num2, num7 + num3, num6 + num4, num7 + num5);
					num2 = num4;
					num3 = num5;
					num4 = num2;
					num5 = num3 + num80;
					num8 = (ushort)(num + 1);
					num = num8;
					DrawLine(streamWriter, num8, text, num6 + num2, num7 + num3, num6 + num4, num7 + num5);
					num8 = (ushort)(num + 1);
					num = num8;
					DrawCircle(streamWriter, num8, text, num6 + num2 + 8.0, num7 + num3 + (num80 - 32.5) / 2.0, d3);
					num8 = (ushort)(num + 1);
					num = num8;
					DrawCircle(streamWriter, num8, text, num6 + num2 + 8.0, num7 + num3 + (num80 + 32.5) / 2.0, d3);
					num2 = num4;
					num3 = num5;
					num4 = num2 + num79;
					num5 = num3 + num79;
					num8 = (ushort)(num + 1);
					num = num8;
					DrawLine(streamWriter, num8, text, num6 + num2, num7 + num3, num6 + num4, num7 + num5);
					num2 = num4;
					num3 = num5;
					num4 = num2 + kk;
					num5 = num3;
					num8 = (ushort)(num + 1);
					num = num8;
					DrawLine(streamWriter, num8, text, num6 + num2, num7 + num3, num6 + num4, num7 + num5);
					num2 = num4;
					num3 = num5;
					num4 = num2 + num79;
					num5 = num3 - num79;
					num8 = (ushort)(num + 1);
					num = num8;
					DrawLine(streamWriter, num8, text, num6 + num2, num7 + num3, num6 + num4, num7 + num5);
					num2 = num4;
					num3 = num5;
					num4 = num2;
					num5 = num3 - num80;
					num8 = (ushort)(num + 1);
					num = num8;
					DrawLine(streamWriter, num8, text, num6 + num2, num7 + num3, num6 + num4, num7 + num5);
					num8 = (ushort)(num + 1);
					num = num8;
					DrawCircle(streamWriter, num8, text, num6 + num4 - 8.0, num7 + num5 + (num80 - 32.5) / 2.0, d3);
					num8 = (ushort)(num + 1);
					num = num8;
					DrawCircle(streamWriter, num8, text, num6 + num4 - 8.0, num7 + num5 + (num80 + 32.5) / 2.0, d3);
					num2 = num4;
					num3 = num5;
					num4 = num2 - (num79 - num19 * Math.Cos(Math.PI / 4.0) / 2.0);
					num5 = num3 - (num79 - num19 * Math.Cos(Math.PI / 4.0) / 2.0);
					num8 = (ushort)(num + 1);
					num = num8;
					DrawLine(streamWriter, num8, text, num6 + num2, num7 + num3, num6 + num4, num7 + num5);
					num2 = num4;
					num3 = num5;
					num4 = num2 - num19 * Math.Cos(Math.PI / 4.0);
					num5 = num3 + num19 * Math.Sin(Math.PI / 4.0);
					num8 = (ushort)(num + 1);
					num = num8;
					DrawLine(streamWriter, num8, text, num6 + num2, num7 + num3, num6 + num4, num7 + num5);
					num2 = num4;
					num3 = num5;
					num4 = num2 - num19 * Math.Cos(Math.PI / 4.0);
					num5 = num3 - num19 * Math.Sin(Math.PI / 4.0);
					num8 = (ushort)(num + 1);
					num = num8;
					DrawLine(streamWriter, num8, text, num6 + num2, num7 + num3, num6 + num4, num7 + num5);
					num2 = num4;
					num3 = num5;
					num4 = num2 + num19 * Math.Cos(Math.PI / 4.0);
					num5 = num3 - num19 * Math.Sin(Math.PI / 4.0);
					num8 = (ushort)(num + 1);
					num = num8;
					DrawLine(streamWriter, num8, text, num6 + num2, num7 + num3, num6 + num4, num7 + num5);
					num8 = (ushort)(num + 1);
					num = num8;
					DrawCircle(streamWriter, num8, text, num6 + num4 + num19 * Math.Cos(Math.PI / 4.0) / 2.0 - 40.0 - 7.0 / Math.Cos(Math.PI / 4.0), num7 + num5 + num19 * Math.Cos(Math.PI / 4.0) / 2.0 - 40.0, d3);
					num2 = num4;
					num3 = num5;
					num4 = num2 - num78;
					num5 = num3 - num78;
					num8 = (ushort)(num + 1);
					num = num8;
					DrawLine(streamWriter, num8, text, num6 + num2, num7 + num3, num6 + num4, num7 + num5);
					num2 = num4;
					num3 = num5;
					num4 = num2;
					num5 = num3 - num77;
					num8 = (ushort)(num + 1);
					num = num8;
					DrawLine(streamWriter, num8, text, num6 + num2, num7 + num3, num6 + num4, num7 + num5);
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

	public static ushort DrawZaklepka_5(StreamWriter sw, ushort ii, string Layer_Name, string connection, double x1, double y1, double x2, double y2, byte leftRight)
	{
		if (connection == "заклепка")
		{
			double num = 7.0;
			double num2 = 22.0;
			double num3 = 28.0;
			double num4 = 50.0;
			double num5 = Math.Sqrt(Math.Pow(x2 - x1, 2.0) + Math.Pow(y2 - y1, 2.0)) - (num2 + num3);
			int num6 = (int)Math.Round(num5 / num4);
			double num7 = ((y1 == y2) ? 0.0 : Math.Atan((y2 - y1) / (x2 - x1)));
			double d = 2.65;
			num4 = num5 / (double)num6;
			num6++;
			double num8 = x1 + num2 * Math.Cos(num7);
			num8 += ((leftRight == 0) ? ((0.0 - num) * Math.Sin(num7)) : (num * Math.Sin(num7)));
			double num9 = y1 + num2 * Math.Sin(num7);
			num9 += ((leftRight == 0) ? (num * Math.Cos(num7)) : ((0.0 - num) * Math.Cos(num7)));
			for (int i = 0; i < num6; i++)
			{
				DrawCircle(sw, ++ii, Layer_Name, num8, num9, d);
				num8 += num4 * Math.Cos(num7);
				num9 += num4 * Math.Sin(num7);
			}
		}
		return ii;
	}

	public static ushort DrawZaklepka_5_1(StreamWriter sw, ushort ii, string Layer_Name, string connection, double x1, double y1, double x2, double y2, byte leftRight)
	{
		if (connection == "заклепка")
		{
			double num = 8.0;
			double num2 = 22.0;
			double num3 = 28.0;
			double num4 = 50.0;
			double num5 = Math.Sqrt(Math.Pow(x2 - x1, 2.0) + Math.Pow(y2 - y1, 2.0)) - (num2 + num3);
			int num6 = (int)Math.Round(num5 / num4);
			double num7 = ((y1 == y2) ? 0.0 : Math.Atan((y2 - y1) / (x2 - x1)));
			double d = 2.65;
			num4 = num5 / (double)num6;
			num6++;
			double num8 = x1 + num2 * Math.Cos(num7);
			num8 += ((leftRight == 0) ? ((0.0 - num) * Math.Sin(num7)) : (num * Math.Sin(num7)));
			double num9 = y1 + num2 * Math.Sin(num7);
			num9 += ((leftRight == 0) ? (num * Math.Cos(num7)) : ((0.0 - num) * Math.Cos(num7)));
			for (int i = 0; i < num6; i++)
			{
				DrawCircle(sw, ++ii, Layer_Name, num8, num9, d);
				num8 += num4 * Math.Cos(num7);
				num9 += num4 * Math.Sin(num7);
			}
		}
		return ii;
	}

	public static ushort DrawZaklepka_6(StreamWriter sw, ushort ii, string Layer_Name, string connection, double x1, double y1, double x2, double y2, double z11x, double z11y, byte leftRight)
	{
		if (connection == "заклепка")
		{
			double num = 8.0;
			double num2 = 28.0;
			double num3 = 22.0;
			double num4 = 50.0;
			double num5 = Math.Sqrt(Math.Pow(x2 - x1, 2.0) + Math.Pow(y2 - y1, 2.0)) - (num2 + num3);
			int num6 = (int)Math.Round(num5 / num4);
			double num7 = ((y1 == y2) ? 0.0 : Math.Atan((y2 - y1) / (x2 - x1)));
			double d = 2.65;
			num4 = num5 / (double)num6;
			num6++;
			double num8 = 10000000000.0;
			int num9 = 0;
			double num10 = x1 + num2 * Math.Cos(num7);
			num10 += ((leftRight == 0) ? ((0.0 - num) * Math.Sin(num7)) : (num * Math.Sin(num7)));
			double num11 = y1 + num2 * Math.Sin(num7);
			num11 += ((leftRight == 0) ? (num * Math.Cos(num7)) : ((0.0 - num) * Math.Cos(num7)));
			z11x += num * Math.Sin(num7);
			z11y -= num * Math.Cos(num7);
			for (int i = 0; i < num6; i++)
			{
				double num12 = Math.Sqrt(Math.Pow(num10 - z11x, 2.0) + Math.Pow(num11 - z11y, 2.0));
				if (num12 < num8)
				{
					num8 = num12;
					num9 = i;
				}
				num10 += num4 * Math.Cos(num7);
				num11 += num4 * Math.Sin(num7);
			}
			num10 = x1 + num2 * Math.Cos(num7);
			num10 += ((leftRight == 0) ? ((0.0 - num) * Math.Sin(num7)) : (num * Math.Sin(num7)));
			num11 = y1 + num2 * Math.Sin(num7);
			num11 += ((leftRight == 0) ? (num * Math.Cos(num7)) : ((0.0 - num) * Math.Cos(num7)));
			for (int j = 0; j < num6; j++)
			{
				if (num9 != j)
				{
					DrawCircle(sw, ++ii, Layer_Name, num10, num11, d);
				}
				num10 += num4 * Math.Cos(num7);
				num11 += num4 * Math.Sin(num7);
			}
		}
		return ii;
	}

	public static ushort DrawZaklepka_6_1(StreamWriter sw, ushort ii, string Layer_Name, string connection, double x1, double y1, double x2, double y2, double z11x, double z11y, byte leftRight)
	{
		if (connection == "заклепка")
		{
			double num = 7.0;
			double num2 = 28.0;
			double num3 = 22.0;
			double num4 = 50.0;
			double num5 = Math.Sqrt(Math.Pow(x2 - x1, 2.0) + Math.Pow(y2 - y1, 2.0)) - (num2 + num3);
			int num6 = (int)Math.Round(num5 / num4);
			double num7 = ((y1 == y2) ? 0.0 : Math.Atan((y2 - y1) / (x2 - x1)));
			double d = 2.65;
			num4 = num5 / (double)num6;
			num6++;
			double num8 = 10000000000.0;
			int num9 = 0;
			double num10 = x1 + num2 * Math.Cos(num7);
			num10 += ((leftRight == 0) ? ((0.0 - num) * Math.Sin(num7)) : (num * Math.Sin(num7)));
			double num11 = y1 + num2 * Math.Sin(num7);
			num11 += ((leftRight == 0) ? (num * Math.Cos(num7)) : ((0.0 - num) * Math.Cos(num7)));
			z11x += num * Math.Sin(num7);
			z11y -= num * Math.Cos(num7);
			for (int i = 0; i < num6; i++)
			{
				double num12 = Math.Sqrt(Math.Pow(num10 - z11x, 2.0) + Math.Pow(num11 - z11y, 2.0));
				if (num12 < num8)
				{
					num8 = num12;
					num9 = i;
				}
				num10 += num4 * Math.Cos(num7);
				num11 += num4 * Math.Sin(num7);
			}
			num10 = x1 + num2 * Math.Cos(num7);
			num10 += ((leftRight == 0) ? ((0.0 - num) * Math.Sin(num7)) : (num * Math.Sin(num7)));
			num11 = y1 + num2 * Math.Sin(num7);
			num11 += ((leftRight == 0) ? (num * Math.Cos(num7)) : ((0.0 - num) * Math.Cos(num7)));
			for (int j = 0; j < num6; j++)
			{
				if (num9 != j)
				{
					DrawCircle(sw, ++ii, Layer_Name, num10, num11, d);
				}
				num10 += num4 * Math.Cos(num7);
				num11 += num4 * Math.Sin(num7);
			}
		}
		return ii;
	}

	public static ushort DrawZaklepka_6_2(StreamWriter sw, ushort ii, string Layer_Name, string connection, double x1, double y1, double x2, double y2, byte leftRight)
	{
		if (connection == "заклепка")
		{
			double num = 7.0;
			double num2 = 22.0;
			double num3 = 28.0;
			double num4 = 50.0;
			double num5 = Math.Sqrt(Math.Pow(x2 - x1, 2.0) + Math.Pow(y2 - y1, 2.0)) - (num2 + num3);
			int num6 = (int)Math.Round(num5 / num4);
			double num7 = ((y1 == y2) ? 0.0 : Math.Atan((y2 - y1) / (x2 - x1)));
			double d = 2.65;
			num4 = num5 / (double)num6;
			num6++;
			double num8 = x1 + num2 * Math.Cos(num7);
			num8 += ((leftRight == 0) ? ((0.0 - num) * Math.Sin(num7)) : (num * Math.Sin(num7)));
			double num9 = y1 + num2 * Math.Sin(num7);
			num9 += ((leftRight == 0) ? (num * Math.Cos(num7)) : ((0.0 - num) * Math.Cos(num7)));
			for (int i = 0; i < num6; i++)
			{
				DrawCircle(sw, ++ii, Layer_Name, num8, num9, d);
				num8 += num4 * Math.Cos(num7);
				num9 += num4 * Math.Sin(num7);
			}
		}
		return ii;
	}

	public static ushort DrawZaklepka_6_3(StreamWriter sw, ushort ii, string Layer_Name, string connection, double x1, double y1, double x2, double y2, byte leftRight)
	{
		if (connection == "заклепка")
		{
			double num = 8.0;
			double num2 = 22.0;
			double num3 = 28.0;
			double num4 = 50.0;
			double num5 = Math.Sqrt(Math.Pow(x2 - x1, 2.0) + Math.Pow(y2 - y1, 2.0)) - (num2 + num3);
			int num6 = (int)Math.Round(num5 / num4);
			double num7 = ((y1 == y2) ? 0.0 : Math.Atan((y2 - y1) / (x2 - x1)));
			double d = 2.65;
			num4 = num5 / (double)num6;
			num6++;
			double num8 = x1 + num2 * Math.Cos(num7);
			num8 += ((leftRight == 0) ? ((0.0 - num) * Math.Sin(num7)) : (num * Math.Sin(num7)));
			double num9 = y1 + num2 * Math.Sin(num7);
			num9 += ((leftRight == 0) ? (num * Math.Cos(num7)) : ((0.0 - num) * Math.Cos(num7)));
			for (int i = 0; i < num6; i++)
			{
				DrawCircle(sw, ++ii, Layer_Name, num8, num9, d);
				num8 += num4 * Math.Cos(num7);
				num9 += num4 * Math.Sin(num7);
			}
		}
		return ii;
	}

	public static ushort DrawZaklepka_7(StreamWriter sw, ushort ii, string Layer_Name, string connection, double x1, double y1, double x2, double y2, double z41, byte leftRight)
	{
		if (connection == "заклепка")
		{
			double num = 8.0;
			double num2 = 22.0;
			double num3 = 28.0;
			double num4 = 50.0;
			double num5 = Math.Sqrt(Math.Pow(x2 - x1, 2.0) + Math.Pow(y2 - y1, 2.0)) - (num2 + num3);
			int num6 = (int)Math.Round(num5 / num4);
			double num7 = ((y1 == y2) ? 0.0 : Math.Atan((y2 - y1) / (x2 - x1)));
			double d = 2.65;
			num4 = num5 / (double)num6;
			num6++;
			double num8 = 10000000000.0;
			int num9 = 0;
			double num10 = x1 + num2 * Math.Cos(num7);
			num10 += ((leftRight == 0) ? ((0.0 - num) * Math.Sin(num7)) : (num * Math.Sin(num7)));
			double num11 = y1 + num2 * Math.Sin(num7);
			num11 += ((leftRight == 0) ? (num * Math.Cos(num7)) : ((0.0 - num) * Math.Cos(num7)));
			double num12 = z41 * Math.Cos(num7);
			double num13 = z41 * Math.Sin(num7);
			for (int i = 0; i < num6; i++)
			{
				double num14 = Math.Sqrt(Math.Pow(num10 - x1 - num12, 2.0) + Math.Pow(num11 - y1 - num13, 2.0));
				if (num14 < num8)
				{
					num8 = num14;
					num9 = i;
				}
				num10 += num4 * Math.Cos(num7);
				num11 += num4 * Math.Sin(num7);
			}
			num10 = x1 + num2 * Math.Cos(num7);
			num10 += ((leftRight == 0) ? ((0.0 - num) * Math.Sin(num7)) : (num * Math.Sin(num7)));
			num11 = y1 + num2 * Math.Sin(num7);
			num11 += ((leftRight == 0) ? (num * Math.Cos(num7)) : ((0.0 - num) * Math.Cos(num7)));
			for (int j = 0; j < num6; j++)
			{
				if (num9 != j)
				{
					DrawCircle(sw, ++ii, Layer_Name, num10, num11, d);
				}
				num10 += num4 * Math.Cos(num7);
				num11 += num4 * Math.Sin(num7);
			}
		}
		return ii;
	}

	public static ushort DrawZaklepka_7_1(StreamWriter sw, ushort ii, string Layer_Name, string connection, double x1, double y1, double x2, double y2, double z11x, double z11y, byte leftRight)
	{
		if (connection == "заклепка")
		{
			double num = 7.0;
			double num2 = 22.0;
			double num3 = 28.0;
			double num4 = 50.0;
			double num5 = Math.Sqrt(Math.Pow(x2 - x1, 2.0) + Math.Pow(y2 - y1, 2.0)) - (num2 + num3);
			int num6 = (int)Math.Round(num5 / num4);
			double num7 = ((y1 == y2) ? 0.0 : Math.Atan((y2 - y1) / (x2 - x1)));
			double d = 2.65;
			num4 = num5 / (double)num6;
			num6++;
			double num8 = 10000000000.0;
			int num9 = 0;
			double num10 = x1 + num2 * Math.Cos(num7);
			num10 += ((leftRight == 0) ? ((0.0 - num) * Math.Sin(num7)) : (num * Math.Sin(num7)));
			double num11 = y1 + num2 * Math.Sin(num7);
			num11 += ((leftRight == 0) ? (num * Math.Cos(num7)) : ((0.0 - num) * Math.Cos(num7)));
			z11x -= num * Math.Sin(num7);
			z11y -= num * Math.Cos(num7);
			for (int i = 0; i < num6; i++)
			{
				double num12 = Math.Sqrt(Math.Pow(num10 - z11x, 2.0) + Math.Pow(num11 - z11y, 2.0));
				if (num12 < num8)
				{
					num8 = num12;
					num9 = i;
				}
				num10 += num4 * Math.Cos(num7);
				num11 += num4 * Math.Sin(num7);
			}
			num10 = x1 + num2 * Math.Cos(num7);
			num10 += ((leftRight == 0) ? ((0.0 - num) * Math.Sin(num7)) : (num * Math.Sin(num7)));
			num11 = y1 + num2 * Math.Sin(num7);
			num11 += ((leftRight == 0) ? (num * Math.Cos(num7)) : ((0.0 - num) * Math.Cos(num7)));
			for (int j = 0; j < num6; j++)
			{
				if (num9 != j)
				{
					DrawCircle(sw, ++ii, Layer_Name, num10, num11, d);
				}
				num10 += num4 * Math.Cos(num7);
				num11 += num4 * Math.Sin(num7);
			}
		}
		return ii;
	}

	public static ushort DrawZaklepka_7_2(StreamWriter sw, ushort ii, string Layer_Name, string connection, double x1, double y1, double x2, double y2, byte leftRight)
	{
		if (connection == "заклепка")
		{
			double num = 7.0;
			double num2 = 22.0;
			double num3 = 28.0;
			double num4 = 50.0;
			double num5 = Math.Sqrt(Math.Pow(x2 - x1, 2.0) + Math.Pow(y2 - y1, 2.0)) - (num2 + num3);
			int num6 = (int)Math.Round(num5 / num4);
			double num7 = ((y1 == y2) ? 0.0 : Math.Atan((y2 - y1) / (x2 - x1)));
			double d = 2.65;
			num4 = num5 / (double)num6;
			num6++;
			double num8 = x1 + num2 * Math.Cos(num7);
			num8 += ((leftRight == 0) ? ((0.0 - num) * Math.Sin(num7)) : (num * Math.Sin(num7)));
			double num9 = y1 + num2 * Math.Sin(num7);
			num9 += ((leftRight == 0) ? (num * Math.Cos(num7)) : ((0.0 - num) * Math.Cos(num7)));
			for (int i = 0; i < num6; i++)
			{
				DrawCircle(sw, ++ii, Layer_Name, num8, num9, d);
				num8 += num4 * Math.Cos(num7);
				num9 += num4 * Math.Sin(num7);
			}
		}
		return ii;
	}

	public static ushort DrawZaklepka_7_3(StreamWriter sw, ushort ii, string Layer_Name, string connection, double x1, double y1, double x2, double y2, byte leftRight)
	{
		if (connection == "заклепка")
		{
			double num = 8.0;
			double num2 = 22.0;
			double num3 = 28.0;
			double num4 = 50.0;
			double num5 = Math.Sqrt(Math.Pow(x2 - x1, 2.0) + Math.Pow(y2 - y1, 2.0)) - (num2 + num3);
			int num6 = (int)Math.Round(num5 / num4);
			double num7 = ((y1 == y2) ? 0.0 : Math.Atan((y2 - y1) / (x2 - x1)));
			double d = 2.65;
			num4 = num5 / (double)num6;
			num6++;
			double num8 = x1 + num2 * Math.Cos(num7);
			num8 += ((leftRight == 0) ? ((0.0 - num) * Math.Sin(num7)) : (num * Math.Sin(num7)));
			double num9 = y1 + num2 * Math.Sin(num7);
			num9 += ((leftRight == 0) ? (num * Math.Cos(num7)) : ((0.0 - num) * Math.Cos(num7)));
			for (int i = 0; i < num6; i++)
			{
				DrawCircle(sw, ++ii, Layer_Name, num8, num9, d);
				num8 += num4 * Math.Cos(num7);
				num9 += num4 * Math.Sin(num7);
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

	public static void ZontPrystinnyyTyp3DrawImage(int L, int B, int H, int h, int a, int b, double c, int number, string implementation, string zontMaterial, string tovchynaMetaluZont, string connection, string zlyv, string fastening, string typeFastening, string vyhid, string vyhid1, int d1, int a1, int b1, int p1, int f1, int g1, string typVyhid1, string profilType1, string vyhid2, int d2, int a2, int b2, int p2, int f2, int g2, string typVyhid2, string profilType2, string zhyrFiltr, string zhyrFiltrMaterial, string tovchynaMetaluFiltr, string orderCode, string contragent, string filePath = null)
	{
		//IL_00a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ad: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b4: Expected O, but got Unknown
		//IL_00bc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cd: Expected O, but got Unknown
		//IL_00d5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00df: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e6: Expected O, but got Unknown
		//IL_00f6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fd: Expected O, but got Unknown
		//IL_0105: Unknown result type (might be due to invalid IL or missing references)
		//IL_010c: Expected O, but got Unknown
		//IL_010c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0111: Unknown result type (might be due to invalid IL or missing references)
		//IL_0118: Expected O, but got Unknown
		//IL_0118: Unknown result type (might be due to invalid IL or missing references)
		//IL_011f: Expected O, but got Unknown
		//IL_56d0: Unknown result type (might be due to invalid IL or missing references)
		//IL_56d7: Expected O, but got Unknown
		//IL_56d7: Unknown result type (might be due to invalid IL or missing references)
		//IL_56de: Expected O, but got Unknown
		int num = 725;
		int num2 = 1026;
		int num3 = 45;
		int num4 = 40;
		int num5 = 25;
		int num6 = 25 + num5;
		int num7 = 20;
		double num8 = num3;
		double num9 = 0.0;
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
			string text = "Зонт ЗВП-3 " + L + "х" + B + "х" + H;
			if (zhyrFiltr == "так")
			{
				text += " з ж/ф ";
			}
			text = text + number + " шт";
			text = text + " №Замовлення" + orderCode;
			text = text + ", Контрагент:" + contragent;
			val9.FormatFlags = (StringFormatFlags)1;
			val2.DrawString(text, val6, (Brush)(object)val8, (float)(num / 2), (float)num5, val9);
			num18 = (double)(num - num3 - num4) / ((double)B + (double)L * Math.Cos(num17));
			double num22 = (double)a * Math.Sin(num17);
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
			}
			num22 += (double)H;
			if ((double)L * Math.Sin(num17) + (double)h > num22)
			{
				num22 = (double)L * Math.Sin(num17) + (double)h;
			}
			double num24 = (double)(num2 / 3) / num22;
			if (num24 < num18)
			{
				num18 = num24;
			}
			int num25 = 10;
			num6 = num5 + num20 + num25;
			int num26 = num6;
			num6 += (int)((num22 - ((double)H + (double)a * Math.Sin(num17))) * num18);
			double num27 = (double)L * num18;
			double num28 = (double)H * num18;
			double num29 = (double)B * num18;
			double num30 = (double)h * num18;
			double num31 = (double)a * num18;
			double num32 = (double)b * num18;
			double num33 = c * num18;
			double num34 = Math.Sqrt(Math.Pow(c, 2.0) + Math.Pow(H - h, 2.0));
			double num35 = Math.Sqrt(Math.Pow(c, 2.0) + Math.Pow(B - b, 2.0) + Math.Pow(H - h, 2.0));
			double num36 = Math.Sqrt(Math.Pow((double)(L - a) - c, 2.0) + Math.Pow(B - b, 2.0) + Math.Pow(H - h, 2.0));
			double num37 = Math.Sqrt(Math.Pow((double)(L - a) - c, 2.0) + Math.Pow(H - h, 2.0));
			double num38 = num34 * num18;
			double num39 = num35 * num18;
			double num40 = num36 * num18;
			double num41 = num37 * num18;
			double num42 = num3;
			double num43 = (double)num6 + num31 * Math.Sin(num17);
			double num44 = num42 + num32;
			double num45 = num43;
			val2.DrawLine(val4, (float)num42, (float)num43, (float)num44, (float)num45);
			num44 = num42 + num31 * Math.Cos(num17);
			num45 = num6;
			val2.DrawLine(val4, (float)num42, (float)num43, (float)num44, (float)num45);
			num42 = num44;
			num43 = num45;
			num44 = num42 + num32;
			val2.DrawLine(val4, (float)num42, (float)num43, (float)num44, (float)num45);
			num42 = (double)num3 + num32;
			num43 = (double)num6 + num31 * Math.Sin(num17);
			val2.DrawLine(val4, (float)num42, (float)num43, (float)num44, (float)num45);
			double num51;
			double num52;
			double num49;
			double num61;
			double num62;
			double num50;
			double num47;
			double num48;
			double num69;
			double num77;
			double num78;
			double num70;
			double num67;
			double num68;
			double num59;
			double num60;
			if (vyhid == "з виходом")
			{
				double num46 = num3;
				if (vyhid1 == "круглий")
				{
					num47 = (double)f1 * num18;
					num48 = (double)g1 * num18;
					num49 = (double)d1 * num18;
					num50 = (double)p1 * num18;
					num42 = num46 + num48 + (num47 - num49 / 2.0) * Math.Cos(num17);
					num43 = (double)num6 + num31 * Math.Sin(num17) - (num47 - num49 / 2.0) * Math.Sin(num17);
					num44 = num46 + num48 - num49 / 2.0 + num47 * Math.Cos(num17) - 5.0;
					num45 = num43 - num49 / 2.0 * Math.Sin(num17);
					num51 = num46 + num48 + (num47 + num49 / 2.0) * Math.Cos(num17);
					num52 = num43 - num49 * Math.Sin(num17);
					double num53 = num43 - num50;
					double num54 = num45 - num50;
					double num55 = num52 - num50;
					val2.DrawBezier(val4, (float)num42, (float)num43, (float)num44, (float)num45, (float)num51, (float)num52, (float)num51, (float)num52);
					val2.DrawBezier(val4, (float)num42, (float)num53, (float)num44, (float)num54, (float)num51, (float)num55, (float)num51, (float)num55);
					num44 = num44 + num49 + 10.0;
					val2.DrawBezier(val4, (float)num42, (float)num43, (float)num44, (float)num45, (float)num51, (float)num52, (float)num51, (float)num52);
					val2.DrawBezier(val4, (float)num42, (float)num53, (float)num44, (float)num54, (float)num51, (float)num55, (float)num51, (float)num55);
					val2.DrawLine(val4, (float)num42, (float)num43, (float)num42, (float)num53);
					val2.DrawLine(val4, (float)num51, (float)num52, (float)num51, (float)num55);
					double num56 = num42 - (double)num14;
					double num57 = num43;
					double num58 = num53;
					val2.DrawLine(val3, (float)num42, (float)num43, (float)num56, (float)num57);
					val2.DrawLine(val3, (float)num42, (float)num53, (float)num56, (float)num58);
					DrawRows(num56 + 5.0, num58, num56 + 5.0, num57, num18, val2, val3);
					num59 = num56 - (double)num21;
					num60 = (num57 + num58) / 2.0;
					val9.FormatFlags = (StringFormatFlags)2;
					val2.DrawString(p1.ToString(), val7, (Brush)(object)val8, (float)num59, (float)num60, val9);
				}
				else if (vyhid1 == "прямокутний")
				{
					num47 = (double)f1 * num18;
					num48 = (double)g1 * num18;
					num61 = (double)a1 * num18;
					num62 = (double)b1 * num18;
					num50 = (double)p1 * num18;
					num42 = num46 + num48 + (num47 - num61 / 2.0) * Math.Cos(num17) - num62 / 2.0;
					num43 = (double)num6 + num31 * Math.Sin(num17) - (num47 - num61 / 2.0) * Math.Sin(num17);
					num44 = num42 + num62;
					num45 = num43;
					val2.DrawLine(val4, (float)num42, (float)num43, (float)num44, (float)num45);
					num52 = num43 - num50;
					val2.DrawLine(val4, (float)num42, (float)num43, (float)num42, (float)num52);
					double num63 = num45 - num50;
					val2.DrawLine(val4, (float)num44, (float)num45, (float)num44, (float)num63);
					val2.DrawLine(val4, (float)num42, (float)num52, (float)num44, (float)num63);
					double num64 = num42 - (double)num14;
					double num65 = num43;
					double num66 = num52;
					val2.DrawLine(val3, (float)num42, (float)num43, (float)num64, (float)num65);
					val2.DrawLine(val3, (float)num42, (float)num52, (float)num64, (float)num66);
					DrawRows(num64 + 5.0, num66, num64 + 5.0, num65, num18, val2, val3);
					num59 = num64 - (double)num21;
					num60 = (num65 + num66) / 2.0;
					val9.FormatFlags = (StringFormatFlags)2;
					val2.DrawString(p1.ToString(), val7, (Brush)(object)val8, (float)num59, (float)num60, val9);
					num42 = num44;
					num43 = num45;
					num44 = num42 + num61 * Math.Cos(num17);
					num45 = num43 - num61 * Math.Sin(num17);
					val2.DrawLine(val4, (float)num42, (float)num43, (float)num44, (float)num45);
					num52 = num43 - num50;
					val2.DrawLine(val4, (float)num42, (float)num43, (float)num42, (float)num52);
					num63 = num45 - num50;
					val2.DrawLine(val4, (float)num44, (float)num45, (float)num44, (float)num63);
					val2.DrawLine(val4, (float)num42, (float)num52, (float)num44, (float)num63);
					num42 = num44;
					num43 = num45;
					num44 = num42 - num62;
					num45 = num43;
					val2.DrawLine(val4, (float)num42, (float)num43, (float)num44, (float)num45);
					num52 = num43 - num50;
					val2.DrawLine(val4, (float)num42, (float)num43, (float)num42, (float)num52);
					num63 = num45 - num50;
					val2.DrawLine(val4, (float)num44, (float)num45, (float)num44, (float)num63);
					val2.DrawLine(val4, (float)num42, (float)num52, (float)num44, (float)num63);
					num42 = num44;
					num43 = num45;
					num44 = num42 - num61 * Math.Cos(num17);
					num45 = num43 + num61 * Math.Sin(num17);
					val2.DrawLine(val4, (float)num42, (float)num43, (float)num44, (float)num45);
					num52 = num43 - num50;
					val2.DrawLine(val4, (float)num42, (float)num43, (float)num42, (float)num52);
					num63 = num45 - num50;
					val2.DrawLine(val4, (float)num44, (float)num45, (float)num44, (float)num63);
					val2.DrawLine(val4, (float)num42, (float)num52, (float)num44, (float)num63);
				}
				if (vyhid2 == "круглий")
				{
					num67 = (double)f2 * num18;
					num68 = (double)g2 * num18;
					num69 = (double)d2 * num18;
					num70 = (double)p2 * num18;
					num42 = num46 + num68 + (num67 - num69 / 2.0) * Math.Cos(num17);
					num43 = (double)num6 + num31 * Math.Sin(num17) - (num67 - num69 / 2.0) * Math.Sin(num17);
					num44 = num46 + num68 - num69 / 2.0 + num67 * Math.Cos(num17) - 5.0;
					num45 = num43 - num69 / 2.0 * Math.Sin(num17);
					num51 = num46 + num68 + (num67 + num69 / 2.0) * Math.Cos(num17);
					num52 = num43 - num69 * Math.Sin(num17);
					double num71 = num43 - num70;
					double num72 = num45 - num70;
					double num73 = num52 - num70;
					val2.DrawBezier(val4, (float)num42, (float)num43, (float)num44, (float)num45, (float)num51, (float)num52, (float)num51, (float)num52);
					val2.DrawBezier(val4, (float)num42, (float)num71, (float)num44, (float)num72, (float)num51, (float)num73, (float)num51, (float)num73);
					num44 = num44 + num69 + 10.0;
					val2.DrawBezier(val4, (float)num42, (float)num43, (float)num44, (float)num45, (float)num51, (float)num52, (float)num51, (float)num52);
					val2.DrawBezier(val4, (float)num42, (float)num71, (float)num44, (float)num72, (float)num51, (float)num73, (float)num51, (float)num73);
					val2.DrawLine(val4, (float)num42, (float)num43, (float)num42, (float)num71);
					val2.DrawLine(val4, (float)num51, (float)num52, (float)num51, (float)num73);
					double num74 = num42 - (double)num14;
					double num75 = num43;
					double num76 = num71;
					val2.DrawLine(val3, (float)num42, (float)num43, (float)num74, (float)num75);
					val2.DrawLine(val3, (float)num42, (float)num71, (float)num74, (float)num76);
					DrawRows(num74 + 5.0, num76, num74 + 5.0, num75, num18, val2, val3);
					num59 = num74 - (double)num21;
					num60 = (num75 + num76) / 2.0;
					val9.FormatFlags = (StringFormatFlags)2;
					val2.DrawString(p2.ToString(), val7, (Brush)(object)val8, (float)num59, (float)num60, val9);
				}
				else if (vyhid2 == "прямокутний")
				{
					num67 = (double)f2 * num18;
					num68 = (double)g2 * num18;
					num77 = (double)a2 * num18;
					num78 = (double)b2 * num18;
					num70 = (double)p2 * num18;
					num42 = num46 + num68 + (num67 - num77 / 2.0) * Math.Cos(num17) - num78 / 2.0;
					num43 = (double)num6 + num31 * Math.Sin(num17) - (num67 - num77 / 2.0) * Math.Sin(num17);
					num44 = num42 + num78;
					num45 = num43;
					val2.DrawLine(val4, (float)num42, (float)num43, (float)num44, (float)num45);
					num52 = num43 - num70;
					val2.DrawLine(val4, (float)num42, (float)num43, (float)num42, (float)num52);
					double num63 = num45 - num70;
					val2.DrawLine(val4, (float)num44, (float)num45, (float)num44, (float)num63);
					val2.DrawLine(val4, (float)num42, (float)num52, (float)num44, (float)num63);
					double num79 = num42 - (double)num14;
					double num80 = num43;
					double num81 = num52;
					val2.DrawLine(val3, (float)num42, (float)num43, (float)num79, (float)num80);
					val2.DrawLine(val3, (float)num42, (float)num52, (float)num79, (float)num81);
					DrawRows(num79 + 5.0, num81, num79 + 5.0, num80, num18, val2, val3);
					num59 = num79 - (double)num21;
					num60 = (num80 + num81) / 2.0;
					val9.FormatFlags = (StringFormatFlags)2;
					val2.DrawString(p2.ToString(), val7, (Brush)(object)val8, (float)num59, (float)num60, val9);
					num42 = num44;
					num43 = num45;
					num44 = num42 + num77 * Math.Cos(num17);
					num45 = num43 - num77 * Math.Sin(num17);
					val2.DrawLine(val4, (float)num42, (float)num43, (float)num44, (float)num45);
					num52 = num43 - num70;
					val2.DrawLine(val4, (float)num42, (float)num43, (float)num42, (float)num52);
					num63 = num45 - num70;
					val2.DrawLine(val4, (float)num44, (float)num45, (float)num44, (float)num63);
					val2.DrawLine(val4, (float)num42, (float)num52, (float)num44, (float)num63);
					num42 = num44;
					num43 = num45;
					num44 = num42 - num78;
					num45 = num43;
					val2.DrawLine(val4, (float)num42, (float)num43, (float)num44, (float)num45);
					num52 = num43 - num70;
					val2.DrawLine(val4, (float)num42, (float)num43, (float)num42, (float)num52);
					num63 = num45 - num70;
					val2.DrawLine(val4, (float)num44, (float)num45, (float)num44, (float)num63);
					val2.DrawLine(val4, (float)num42, (float)num52, (float)num44, (float)num63);
					num42 = num44;
					num43 = num45;
					num44 = num42 - num77 * Math.Cos(num17);
					num45 = num43 + num77 * Math.Sin(num17);
					val2.DrawLine(val4, (float)num42, (float)num43, (float)num44, (float)num45);
					num52 = num43 - num70;
					val2.DrawLine(val4, (float)num42, (float)num43, (float)num42, (float)num52);
					num63 = num45 - num70;
					val2.DrawLine(val4, (float)num44, (float)num45, (float)num44, (float)num63);
					val2.DrawLine(val4, (float)num42, (float)num52, (float)num44, (float)num63);
				}
			}
			num42 = num3;
			num43 = (double)num6 + num31 * Math.Sin(num17);
			num44 = num42;
			num45 = num43 + (num28 - num30);
			val2.DrawLine(val4, (float)num42, (float)num43, (float)num44, (float)num45);
			num42 = num44;
			num43 = num45;
			num44 = num42 + num29;
			num45 = num43;
			val2.DrawLine(val4, (float)num42, (float)num43, (float)num44, (float)num45);
			num42 = num44;
			num43 = num45;
			num44 = (double)num3 + num32;
			num45 = num43 - (num28 - num30);
			val2.DrawLine(val4, (float)num42, (float)num43, (float)num44, (float)num45);
			num44 = num42 + num27 * Math.Cos(num17);
			num45 = num43 - num27 * Math.Sin(num17);
			val2.DrawLine(val4, (float)num42, (float)num43, (float)num44, (float)num45);
			num42 = num44;
			num43 = num45;
			num44 = (double)num3 + num31 * Math.Cos(num17) + num32;
			num45 = num6;
			val2.DrawLine(val4, (float)num42, (float)num43, (float)num44, (float)num45);
			num44 = num42 - num29;
			num45 = num43;
			val2.DrawLine(val4, (float)num42, (float)num43, (float)num44, (float)num45);
			num42 = num44;
			num43 = num45;
			num44 = (double)num3 + num31 * Math.Cos(num17);
			num45 = num6;
			val2.DrawLine(val4, (float)num42, (float)num43, (float)num44, (float)num45);
			num42 = num3;
			num43 = (double)num6 + num31 * Math.Sin(num17) + num28 - num30;
			num44 = num42;
			num45 = num43 + num30;
			val2.DrawLine(val4, (float)num42, (float)num43, (float)num44, (float)num45);
			num42 = num44;
			num43 = num45;
			num44 = num42 + num29;
			val2.DrawLine(val4, (float)num42, (float)num43, (float)num44, (float)num45);
			num42 = num44;
			num43 = num45 - num30;
			val2.DrawLine(val4, (float)num42, (float)num43, (float)num44, (float)num45);
			num42 = num44 + num27 * Math.Cos(num17);
			num43 = num45 - num27 * Math.Sin(num17);
			val2.DrawLine(val4, (float)num42, (float)num43, (float)num44, (float)num45);
			num44 = num42;
			num45 = num43 - num30;
			val2.DrawLine(val4, (float)num42, (float)num43, (float)num44, (float)num45);
			num42 = num3;
			num43 = (double)num6 + num31 * Math.Sin(num17);
			num44 = num42 - (double)num14;
			if (implementation == "ж/ф в середині зонта")
			{
				num44 -= (double)(num14 / 2);
			}
			num45 = num43;
			val2.DrawLine(val3, (float)num42, (float)num43, (float)num44, (float)num45);
			num42 = num3;
			num43 = (double)num6 + num31 * Math.Sin(num17) + num28;
			num44 = num3 - num14;
			if (implementation == "ж/ф в середині зонта")
			{
				num44 -= (double)(num14 / 2);
			}
			num45 = num43;
			val2.DrawLine(val3, (float)num42, (float)num43, (float)num44, (float)num45);
			num42 = num3 - num14 + 5;
			if (implementation == "ж/ф в середині зонта")
			{
				num42 -= (double)(num14 / 2);
			}
			num43 = (double)num6 + num31 * Math.Sin(num17);
			num44 = num42;
			num45 = num43 + num28;
			DrawRows(num42, num43, num44, num45, num18, val2, val3);
			num59 = num42 - (double)num21;
			num60 = (num43 + num45) / 2.0;
			val9.FormatFlags = (StringFormatFlags)2;
			val2.DrawString(H.ToString(), val7, (Brush)(object)val8, (float)num59, (float)num60, val9);
			num42 = num3;
			num43 = (double)num6 + num31 * Math.Sin(num17) + num28;
			num44 = num42;
			num45 = num43 + (double)num14;
			val2.DrawLine(val3, (float)num42, (float)num43, (float)num44, (float)num45);
			num42 = (double)num3 + num29;
			num43 = (double)num6 + num31 * Math.Sin(num17) + num28;
			num44 = num42;
			num45 = num43 + (double)num14;
			val2.DrawLine(val3, (float)num42, (float)num43, (float)num44, (float)num45);
			num42 = num3;
			num43 = (double)num6 + num31 * Math.Sin(num17) + num28 + (double)num14 - 5.0;
			num44 = num42 + num29;
			num45 = num43;
			DrawRows(num42, num43, num44, num45, num18, val2, val3);
			num59 = (num42 + num44) / 2.0;
			num60 = num45 + (double)num21;
			val9.FormatFlags = (StringFormatFlags)1;
			val2.DrawString(B.ToString(), val7, (Brush)(object)val8, (float)num59, (float)num60, val9);
			num42 = (double)num3 + num29 + num27 * Math.Cos(num17);
			num43 = (double)num6 + num31 * Math.Sin(num17) + num28 - num27 * Math.Sin(num17);
			num44 = num42;
			num45 = num43 + (double)num14;
			val2.DrawLine(val3, (float)num42, (float)num43, (float)num44, (float)num45);
			num42 = num44;
			num43 = num45 - 5.0;
			num44 = num42 - num27 * Math.Cos(num17);
			num45 = num43 + num27 * Math.Sin(num17);
			DrawRows(num44, num45, num42, num43, num18, val2, val3);
			num59 = (num42 + num44) / 2.0;
			num60 = (num43 + num45) / 2.0 + 15.0 + 5.0;
			val9.FormatFlags = (StringFormatFlags)1;
			val2.DrawString(L.ToString(), val7, (Brush)(object)val8, (float)num59, (float)num60, val9);
			num42 = (double)num3 + num29 + num27 * Math.Cos(num17);
			num43 = (double)num6 + num31 * Math.Sin(num17) + num28 - num27 * Math.Sin(num17);
			num44 = num42 + (double)num14;
			num45 = num43;
			val2.DrawLine(val3, (float)num42, (float)num43, (float)num44, (float)num45);
			num43 -= num30;
			num45 = num43;
			val2.DrawLine(val3, (float)num42, (float)num43, (float)num44, (float)num45);
			num42 = (double)num3 + num29 + num27 * Math.Cos(num17) + (double)num14 - 5.0;
			num43 = (double)num6 + num31 * Math.Sin(num17) + num28 - num27 * Math.Sin(num17);
			num44 = num42;
			num45 = num43 - num30;
			DrawRows(num44, num45, num42, num43, num18, val2, val3);
			num59 = num42 + (double)num21;
			num60 = (num43 + num45) / 2.0;
			val9.FormatFlags = (StringFormatFlags)2;
			val2.DrawString(h.ToString(), val7, (Brush)(object)val8, (float)num59, (float)num60, val9);
			num42 = num3;
			num43 = (double)num6 + num31 * Math.Sin(num17);
			num44 = num42;
			num45 = num43 + (double)num14;
			val2.DrawLine(val3, (float)num42, (float)num43, (float)num44, (float)num45);
			num42 += num32;
			num44 = num42;
			val2.DrawLine(val3, (float)num42, (float)num43, (float)num44, (float)num45);
			num42 = num44;
			num45 -= 5.0;
			num44 = num42 - num32;
			num43 = num45;
			DrawRows(num44, num45, num42, num43, num18, val2, val3);
			num59 = (num42 + num44) / 2.0;
			num60 = num45 + (double)num21;
			val9.FormatFlags = (StringFormatFlags)1;
			val2.DrawString(b.ToString(), val7, (Brush)(object)val8, (float)num59, (float)num60, val9);
			num42 = (double)num3 + num32;
			num43 = (double)num6 + num31 * Math.Sin(num17);
			num44 = num42 + (double)num14 * Math.Sin(num17);
			num45 = num43 + (double)num14 * Math.Cos(num17);
			double num82 = num44;
			double num83 = num45;
			val2.DrawLine(val3, (float)num42, (float)num43, (float)num44, (float)num45);
			num42 += num31 * Math.Cos(num17);
			num43 = num6;
			num44 = num42 + (double)num14 * Math.Sin(num17);
			num45 = num43 + (double)num14 * Math.Cos(num17);
			val2.DrawLine(val3, (float)num42, (float)num43, (float)num44, (float)num45);
			num42 = num82 - 5.0 * Math.Sin(num17);
			num43 = num83 - 5.0 * Math.Cos(num17);
			num44 -= 5.0 * Math.Sin(num17);
			num45 -= 5.0 * Math.Cos(num17);
			DrawRows(num42, num43, num44, num45, num18, val2, val3);
			num59 = (num42 + num44) / 2.0 + (double)num21;
			num60 = (num43 + num45) / 2.0 + (double)num21;
			val9.FormatFlags = (StringFormatFlags)1;
			val2.DrawString(a.ToString(), val7, (Brush)(object)val8, (float)num59, (float)num60, val9);
			num42 = num3;
			num43 = (double)num6 + num31 * Math.Sin(num17) + num28 - num30;
			num44 = num42;
			num45 = (double)num6 + num31 * Math.Sin(num17);
			num59 = (num42 + num44) / 2.0 - 1.5 * (double)num21;
			num60 = (num43 + num45) / 2.0;
			val9.FormatFlags = (StringFormatFlags)1;
			val2.DrawString(Math.Round(num34, MidpointRounding.AwayFromZero).ToString(), val7, (Brush)(object)val8, (float)num59, (float)num60, val9);
			num42 = (double)num3 + num29;
			num43 = (double)num6 + num31 * Math.Sin(num17) + num28 - num30;
			num44 = num42 - (num29 - num32);
			num45 = (double)num6 + num31 * Math.Sin(num17);
			num59 = (num42 + num44) / 2.0 + 1.5 * (double)num21;
			num60 = (num43 + num45) / 2.0;
			val9.FormatFlags = (StringFormatFlags)1;
			val2.DrawString(Math.Round(num35, MidpointRounding.AwayFromZero).ToString(), val7, (Brush)(object)val8, (float)num59, (float)num60, val9);
			num42 = (double)num3 + num29 + num27 * Math.Cos(num17);
			num43 = (double)num6 + num31 * Math.Sin(num17) - (num27 * Math.Sin(num17) - (num28 - num30));
			num44 = (double)num3 + num32 + num31 * Math.Sin(num17);
			num45 = num6;
			num59 = (num42 + num44) / 2.0 + (double)num21;
			num60 = (num43 + num45) / 2.0 - (double)num21;
			val9.FormatFlags = (StringFormatFlags)1;
			val2.DrawString(Math.Round(num36, MidpointRounding.AwayFromZero).ToString(), val7, (Brush)(object)val8, (float)num59, (float)num60, val9);
			num42 -= num29;
			num44 -= num32;
			num45 = num6;
			num59 = (num42 + num44) / 2.0 + (double)num21;
			num60 = (num43 + num45) / 2.0 - (double)num21;
			val9.FormatFlags = (StringFormatFlags)1;
			val2.DrawString(Math.Round(num37, MidpointRounding.AwayFromZero).ToString(), val7, (Brush)(object)val8, (float)num59, (float)num60, val9);
			double num84 = Math.Atan((double)(H - h) / c);
			double num85 = Math.Atan((double)(H - h) / ((double)L - c - (double)a));
			double num86 = Math.PI / 2.0;
			double num87 = Math.Atan((double)(H - h) / (double)(B - b));
			double num88 = 0.0;
			double num89 = (double)L * Math.Sqrt(Math.Pow(num34, 2.0) - Math.Pow(c, 2.0)) / num34;
			double num90 = Math.Sqrt(Math.Pow(L, 2.0) - Math.Pow(num89, 2.0));
			double a3 = Math.Acos(num88 / num34);
			double num91 = num90 * Math.Tan(a3);
			double x = Math.Sqrt(Math.Pow(num90, 2.0) + Math.Pow(num91, 2.0));
			double x2 = Math.Sqrt(Math.Pow(L, 2.0) + Math.Pow(x, 2.0));
			double num92 = Math.Round(180.0 * Math.Acos((Math.Pow(num91, 2.0) + Math.Pow(num89, 2.0) - Math.Pow(x2, 2.0)) / (2.0 * num91 * num89)) / Math.PI, MidpointRounding.AwayFromZero);
			num91 = (double)B * Math.Sqrt(Math.Pow(num35, 2.0) - Math.Pow((double)B - num88 - (double)b, 2.0)) / num35;
			double num93 = Math.Sqrt(Math.Pow(B, 2.0) - Math.Pow(num91, 2.0));
			a3 = Math.Acos(c / num35);
			num89 = num93 * Math.Tan(a3);
			x = Math.Sqrt(Math.Pow(num93, 2.0) + Math.Pow(num89, 2.0));
			x2 = Math.Sqrt(Math.Pow(B, 2.0) + Math.Pow(x, 2.0));
			double num94 = Math.Round(180.0 * Math.Acos((Math.Pow(num91, 2.0) + Math.Pow(num89, 2.0) - Math.Pow(x2, 2.0)) / (2.0 * num91 * num89)) / Math.PI, MidpointRounding.AwayFromZero);
			num91 = (double)L * Math.Sqrt(Math.Pow(num36, 2.0) - Math.Pow((double)L - c - (double)a, 2.0)) / num36;
			double num95 = Math.Sqrt(Math.Pow(L, 2.0) - Math.Pow(num91, 2.0));
			a3 = Math.Acos(((double)B - num88 - (double)b) / num36);
			num89 = num95 * Math.Tan(a3);
			x = Math.Sqrt(Math.Pow(num95, 2.0) + Math.Pow(num89, 2.0));
			x2 = Math.Sqrt(Math.Pow(L, 2.0) + Math.Pow(x, 2.0));
			double num96 = Math.Round(180.0 * Math.Acos((Math.Pow(num91, 2.0) + Math.Pow(num89, 2.0) - Math.Pow(x2, 2.0)) / (2.0 * num91 * num89)) / Math.PI, MidpointRounding.AwayFromZero);
			num91 = (double)L * Math.Sqrt(Math.Pow(num37, 2.0) - Math.Pow((double)L - c - (double)a, 2.0)) / num37;
			double num97 = Math.Sqrt(Math.Pow(L, 2.0) - Math.Pow(num91, 2.0));
			a3 = Math.Acos(num88 / num37);
			num89 = num97 * Math.Tan(a3);
			x = Math.Sqrt(Math.Pow(num97, 2.0) + Math.Pow(num89, 2.0));
			x2 = Math.Sqrt(Math.Pow(L, 2.0) + Math.Pow(x, 2.0));
			double num98 = Math.Round(180.0 * Math.Acos((Math.Pow(num91, 2.0) + Math.Pow(num89, 2.0) - Math.Pow(x2, 2.0)) / (2.0 * num91 * num89)) / Math.PI, MidpointRounding.AwayFromZero);
			if (c == 0.0)
			{
				num92 = 90.0;
				num94 = 90.0;
			}
			if (c == (double)(L - a))
			{
				num96 = 90.0;
				num98 = 90.0;
			}
			double num99 = 20.0;
			double num100 = Math.Acos(0.0);
			num42 = (double)num3 + num29 / 2.0;
			num43 = (double)num6 + num31 * Math.Sin(num17) + num28 - num30;
			num44 = num42 + num99 * Math.Cos(num100);
			num45 = num43 - num99 * Math.Sin(num100);
			val2.DrawLine(val3, (float)num42, (float)num43, (float)num44, (float)num45);
			num44 = num42 + num99 * Math.Cos(num17);
			num45 = num43 - num99 * Math.Sin(num17);
			val2.DrawLine(val3, (float)num42, (float)num43, (float)num44, (float)num45);
			num42 = (double)num3 + num29 / 2.0 + num99 * Math.Cos(num100) / 2.0;
			num43 = (double)num6 + num31 * Math.Sin(num17) + num28 - num30 - num99 * Math.Sin(num100) / 2.0;
			num51 = (double)num3 + num29 / 2.0 + num99 * Math.Cos(num17) / 2.0;
			num52 = (double)num6 + num31 * Math.Sin(num17) + num28 - num30 - num99 * Math.Sin(num17) / 2.0;
			num44 = (num42 + num51) / 2.0 + num99 / 2.0;
			num45 = (num43 + num52) / 2.0 - num99 / 2.0;
			val2.DrawBezier(val3, (float)num51, (float)num52, (float)num44, (float)num45, (float)num42, (float)num43, (float)num42, (float)num43);
			num84 = Math.Round(180.0 * num84 / Math.PI, MidpointRounding.AwayFromZero);
			num84 = 90.0 - num84;
			val9.FormatFlags = (StringFormatFlags)1;
			val2.DrawString(num84 + "°", val7, (Brush)(object)val8, (float)(num44 + 5.0), (float)num45 - 5f, val9);
			val9.FormatFlags = (StringFormatFlags)2;
			num42 = (double)num3 + num29 + num27 * Math.Cos(num17) / 2.0;
			num43 = (double)num6 + num31 * Math.Sin(num17) + num28 - num30 - num27 * Math.Sin(num17) / 2.0;
			num44 = num42 - num99;
			num45 = num43;
			val2.DrawLine(val3, (float)num42, (float)num43, (float)num44, (float)num45);
			num44 = num42 - num99 * Math.Sin(num17);
			num45 = num43 - num99 * Math.Cos(num17);
			val2.DrawLine(val3, (float)num42, (float)num43, (float)num44, (float)num45);
			num42 = (double)num3 + num29 + num27 * Math.Cos(num17) / 2.0 - num99 / 2.0;
			num43 = (double)num6 + num31 * Math.Sin(num17) + num28 - num30 - num27 * Math.Sin(num17) / 2.0;
			num51 = (double)num3 + num29 + num27 * Math.Cos(num17) / 2.0 - num99 * Math.Sin(num17) / 2.0;
			num52 = num43 - num99 * Math.Cos(num17) / 2.0;
			num44 = (num42 + num51) / 2.0 - num99 / 2.0;
			num45 = (num43 + num52) / 2.0 - num99 / 2.0;
			val2.DrawBezier(val3, (float)num51, (float)num52, (float)num44, (float)num45, (float)num42, (float)num43, (float)num42, (float)num43);
			num87 = Math.Round(180.0 * num87 / Math.PI, MidpointRounding.AwayFromZero);
			num87 = 90.0 - num87;
			val9.FormatFlags = (StringFormatFlags)1;
			val2.DrawString(num87 + "°", val7, (Brush)(object)val8, (float)(num44 - 5.0), (float)num45, val9);
			val9.FormatFlags = (StringFormatFlags)2;
			num100 = Math.Acos(((double)L - c - (double)a) / num37);
			num42 = (double)num3 + num29 / 2.0 + num27 * Math.Cos(num17);
			num43 = (double)num6 + num31 * Math.Sin(num17) + num28 - num30 - num27 * Math.Sin(num17);
			num44 = num42 - num99 * Math.Cos(num100 - num17);
			num45 = num43 + num99 * Math.Sin(num100 - num17);
			val2.DrawLine(val3, (float)num42, (float)num43, (float)num44, (float)num45);
			num44 = num42 - num99 * Math.Cos(num17);
			num45 = num43 - num99 * Math.Sin(num17);
			val2.DrawLine(val3, (float)num42, (float)num43, (float)num44, (float)num45);
			num42 = (double)num3 + num29 / 2.0 + num27 * Math.Cos(num17) - num99 * Math.Cos(num100 - num17) / 2.0;
			num43 += num99 * Math.Sin(num100 - num17) / 2.0;
			num51 = (double)num3 + num29 / 2.0 + num27 * Math.Cos(num17) - num99 * Math.Cos(num17) / 2.0;
			num52 = (double)num6 + num31 * Math.Sin(num17) + num28 - num30 - num27 * Math.Sin(num17) - num99 * Math.Sin(num17) / 2.0;
			num44 = (num42 + num51) / 2.0 - num99 / 2.0;
			num45 = (num43 + num52) / 2.0 + num99 / 2.0;
			val2.DrawBezier(val3, (float)num51, (float)num52, (float)num44, (float)num45, (float)num42, (float)num43, (float)num42, (float)num43);
			num85 = Math.Round(180.0 * num85 / Math.PI, MidpointRounding.AwayFromZero);
			num85 = 90.0 - num85;
			val9.FormatFlags = (StringFormatFlags)1;
			val2.DrawString(num85 + "°", val7, (Brush)(object)val8, (float)(num44 - 5.0), (float)num45, val9);
			val9.FormatFlags = (StringFormatFlags)2;
			num42 = num3;
			num43 = (double)num6 + num31 * Math.Sin(num17) + num28 - num30;
			num44 = num42 + 3.0 * num99 * Math.Cos(num17);
			num45 = num43 - 3.0 * num99 * Math.Sin(num17);
			val2.DrawLine(val3, (float)num42, (float)num43, (float)num44, (float)num45);
			num100 = Math.PI / 2.0;
			num42 = (double)num3 + num99 * Math.Cos(num17);
			num43 = (double)num6 + num31 * Math.Sin(num17) + num28 - num30 - num99 * Math.Sin(num17);
			num44 = num42 + num99;
			num45 = num43;
			val2.DrawLine(val3, (float)num42, (float)num43, (float)num44, (float)num45);
			num44 = num42 + num99 * Math.Cos(num100);
			num45 = num43 - num99 * Math.Sin(num100);
			val2.DrawLine(val3, (float)num42, (float)num43, (float)num44, (float)num45);
			num42 = (double)num3 + num99 * Math.Cos(num17) + num99 / 2.0;
			num43 = (double)num6 + num31 * Math.Sin(num17) + num28 - num30 - num99 * Math.Sin(num17);
			num51 = (double)num3 + num99 * Math.Cos(num17) + num99 * Math.Cos(num100) / 2.0;
			num52 = (double)num6 + num31 * Math.Sin(num17) + num28 - num30 - num99 * Math.Sin(num17) - num99 * Math.Sin(num100) / 2.0;
			num44 = (num42 + num51) / 2.0 + num99;
			num45 = (num43 + num52) / 2.0 - num99 / 2.0;
			val2.DrawBezier(val3, (float)num51, (float)num52, (float)num44, (float)num45, (float)num42, (float)num43, (float)num42, (float)num43);
			num86 = Math.Round(180.0 * num86 / Math.PI, MidpointRounding.AwayFromZero);
			num86 = 90.0 - num86;
			val9.FormatFlags = (StringFormatFlags)1;
			val2.DrawString(num86 + "°", val7, (Brush)(object)val8, (float)(num44 + 3.0), (float)num43, val9);
			val9.FormatFlags = (StringFormatFlags)2;
			num100 = Math.PI / 2.0;
			num42 = (double)num3 + 2.0 * num99 * Math.Cos(num100);
			num43 = (double)num6 + num31 * Math.Sin(num17) + num28 - num30 - 2.0 * num99 * Math.Sin(num100);
			num44 = num42 + num99 * Math.Cos(num17);
			num45 = num43 - num99 * Math.Sin(num17);
			val2.DrawLine(val3, (float)num42, (float)num43, (float)num44, (float)num45);
			num44 = num42 + num99;
			num45 = num43;
			val2.DrawLine(val3, (float)num42, (float)num43, (float)num44, (float)num45);
			num42 = (double)num3 + 2.0 * num99 * Math.Cos(num100) + num99 * Math.Cos(num17) / 2.0;
			num43 = (double)num6 + num31 * Math.Sin(num17) + num28 - num30 - 2.0 * num99 * Math.Sin(num100) - num99 * Math.Sin(num17) / 2.0;
			num51 = (double)num3 + 2.0 * num99 * Math.Cos(num100) + num99 / 2.0;
			num52 = (double)num6 + num31 * Math.Sin(num17) + num28 - num30 - 2.0 * num99 * Math.Sin(num100);
			num44 = (num42 + num51) / 2.0 + num99 / 2.0;
			num45 = (num43 + num52) / 2.0 - num99 / 2.0;
			val2.DrawBezier(val3, (float)num51, (float)num52, (float)num44, (float)num45, (float)num42, (float)num43, (float)num42, (float)num43);
			num92 = 180.0 - num92;
			val9.FormatFlags = (StringFormatFlags)1;
			val2.DrawString(num92 + "°", val7, (Brush)(object)val8, (float)(num44 + 10.0), (float)(num45 + 3.0), val9);
			val9.FormatFlags = (StringFormatFlags)2;
			num100 = Math.Atan((double)(H - h) / (double)(B - b));
			num42 = (double)num3 + num29 - 2.0 * num99 * Math.Cos(num100);
			num43 = (double)num6 + num31 * Math.Sin(num17) + num28 - num30 - 2.0 * num99 * Math.Sin(num100);
			num44 = num42 - num99 * Math.Cos(num17);
			num45 = num43 - num99 * Math.Sin(num17);
			val2.DrawLine(val3, (float)num42, (float)num43, (float)num44, (float)num45);
			num44 = num42 - num99;
			num45 = num43;
			val2.DrawLine(val3, (float)num42, (float)num43, (float)num44, (float)num45);
			num42 = (double)num3 + num29 - 2.0 * num99 * Math.Cos(num100) - num99 * Math.Cos(num17) / 2.0;
			num43 = (double)num6 + num31 * Math.Sin(num17) + num28 - num30 - 2.0 * num99 * Math.Sin(num100) - num99 * Math.Sin(num17) / 2.0;
			num51 = (double)num3 + num29 - 2.0 * num99 * Math.Cos(num100) - num99 / 2.0;
			num52 = (double)num6 + num31 * Math.Sin(num17) + num28 - num30 - 2.0 * num99 * Math.Sin(num100);
			num44 = (num42 + num51) / 2.0 - num99 / 2.0;
			num45 = (num43 + num52) / 2.0 - num99 / 2.0;
			val2.DrawBezier(val3, (float)num51, (float)num52, (float)num44, (float)num45, (float)num42, (float)num43, (float)num42, (float)num43);
			num94 = 180.0 - num94;
			val9.FormatFlags = (StringFormatFlags)1;
			val2.DrawString(num94 + "°", val7, (Brush)(object)val8, (float)(num44 - 10.0), (float)(num45 + 3.0), val9);
			val9.FormatFlags = (StringFormatFlags)2;
			num42 = ((double)num3 + num29 + num27 * Math.Cos(num17) + ((double)num3 + num32 + num31 * Math.Cos(num17))) / 2.0;
			num43 = ((double)(num6 + num6) + num31 * Math.Sin(num17) + num28 - num30 - num27 * Math.Sin(num17)) / 2.0;
			num44 = num42 - num99 * Math.Cos(num17);
			num45 = num43 + num99 * Math.Sin(num17);
			val2.DrawLine(val3, (float)num42, (float)num43, (float)num44, (float)num45);
			num44 = num42 - num99;
			num45 = num43;
			val2.DrawLine(val3, (float)num42, (float)num43, (float)num44, (float)num45);
			num42 = ((double)num3 + num29 + num27 * Math.Cos(num17) + ((double)num3 + num32 + num31 * Math.Cos(num17))) / 2.0 - num99 * Math.Cos(num17) / 2.0;
			num43 = ((double)(num6 + num6) + num31 * Math.Sin(num17) + num28 - num30 - num27 * Math.Sin(num17)) / 2.0 + num99 * Math.Sin(num17) / 2.0;
			num51 = ((double)num3 + num29 + num27 * Math.Cos(num17) + ((double)num3 + num32 + num31 * Math.Cos(num17))) / 2.0 - num99 / 2.0;
			num52 = ((double)(num6 + num6) + num31 * Math.Sin(num17) + num28 - num30 - num27 * Math.Sin(num17)) / 2.0;
			num44 = (num42 + num51) / 2.0 - num99 / 2.0;
			num45 = (num43 + num52) / 2.0 + num99 / 2.0;
			val2.DrawBezier(val3, (float)num51, (float)num52, (float)num44, (float)num45, (float)num42, (float)num43, (float)num42, (float)num43);
			num96 = 180.0 - num96;
			val9.FormatFlags = (StringFormatFlags)1;
			val2.DrawString(num96 + "°", val7, (Brush)(object)val8, (float)(num44 - 10.0), (float)(num45 + 3.0), val9);
			val9.FormatFlags = (StringFormatFlags)2;
			num42 = ((double)num3 + num27 * Math.Cos(num17) + ((double)num3 + num31 * Math.Cos(num17))) / 2.0;
			num43 = ((double)(num6 + num6) + num31 * Math.Sin(num17) + num28 - num30 - num27 * Math.Sin(num17)) / 2.0;
			num44 = num42 - num99 * Math.Cos(num17);
			num45 = num43 + num99 * Math.Sin(num17);
			val2.DrawLine(val3, (float)num42, (float)num43, (float)num44, (float)num45);
			num44 = num42 + num99;
			num45 = num43;
			val2.DrawLine(val3, (float)num42, (float)num43, (float)num44, (float)num45);
			num42 = ((double)num3 + num27 * Math.Cos(num17) + ((double)num3 + num31 * Math.Cos(num17))) / 2.0 - num99 * Math.Cos(num17) / 2.0;
			num43 = ((double)(num6 + num6) + num31 * Math.Sin(num17) + num28 - num30 - num27 * Math.Sin(num17)) / 2.0 + num99 * Math.Sin(num17) / 2.0;
			num51 = ((double)num3 + num27 * Math.Cos(num17) + ((double)num3 + num31 * Math.Cos(num17))) / 2.0 + num99 / 2.0;
			num52 = ((double)(num6 + num6) + num31 * Math.Sin(num17) + num28 - num30 - num27 * Math.Sin(num17)) / 2.0;
			num44 = (num42 + num51) / 2.0 + num99 / 2.0;
			num45 = (num43 + num52) / 2.0 + num99 / 2.0;
			val2.DrawBezier(val3, (float)num51, (float)num52, (float)num44, (float)num45, (float)num42, (float)num43, (float)num42, (float)num43);
			num98 = 180.0 - num98;
			val9.FormatFlags = (StringFormatFlags)1;
			val2.DrawString(num98 + "°", val7, (Brush)(object)val8, (float)(num44 - 5.0), (float)(num45 + 3.0), val9);
			val9.FormatFlags = (StringFormatFlags)2;
			double num125;
			double num126;
			if (zhyrFiltr == "так")
			{
				if (implementation == "ж/ф внизу зонта (2 ряди)")
				{
					double num101 = 60.0;
					double num102 = 10.0;
					double num103 = 55.0;
					double num104 = 15.0;
					double num105 = 30.0;
					double num106 = 10.0;
					double num107 = num101 * num18;
					double num108 = num102 * num18;
					double num109 = num103 * num18;
					double num110 = num104 * num18;
					double num111 = num105 * num18;
					double num112 = num106 * num18;
					num42 = num3;
					num43 = (double)num6 + num31 * Math.Sin(num17) + num28;
					num44 = num42 + num111;
					num45 = num43;
					val2.DrawLine(val5, (float)num42, (float)num43, (float)num44, (float)num45);
					num42 = num44;
					num45 = num43 - num112;
					val2.DrawLine(val5, (float)num42, (float)num43, (float)num44, (float)num45);
					num42 = (double)num3 + num29;
					num43 = (double)num6 + num31 * Math.Sin(num17) + num28;
					num44 = num42 - num111;
					num45 = num43;
					val2.DrawLine(val5, (float)num42, (float)num43, (float)num44, (float)num45);
					num42 = num44;
					num45 = num43 - num112;
					val2.DrawLine(val5, (float)num42, (float)num43, (float)num44, (float)num45);
					num42 = (double)num3 + num29 / 2.0 - num107 / 2.0;
					num43 = (double)num6 + num31 * Math.Sin(num17) + num28;
					num44 = num42 + num107;
					num45 = num43;
					val2.DrawLine(val5, (float)num42, (float)num43, (float)num44, (float)num45);
					num44 = num42;
					num45 = num43 - num108;
					val2.DrawLine(val5, (float)num42, (float)num43, (float)num44, (float)num45);
					num42 += num107;
					num44 = num42;
					num45 = num43 - num108;
					val2.DrawLine(val5, (float)num42, (float)num43, (float)num44, (float)num45);
					double num113 = 3.0;
					double num114 = 3.0;
					num42 = (double)num3 + num29 / 2.0;
					num43 = (double)num6 + num31 * Math.Sin(num17) + num28 - num113;
					num44 = num42 + num110;
					num45 = num43;
					val2.DrawLine(val5, (float)num42, (float)num43, (float)num44, (float)num45);
					num44 = num42;
					num45 = num43 - num109;
					val2.DrawLine(val5, (float)num42, (float)num43, (float)num44, (float)num45);
					double num115 = 40.0;
					double num116 = num115 * num18;
					double num117 = 5.0;
					double num118 = num117 * num18;
					l = B / 2 - 2 * (int)num117;
					double num119 = (double)l * num18;
					num42 = (double)num3 + num118 + num114;
					num43 = (double)num6 + num31 * Math.Sin(num17) + num28 - num112 - num113;
					num44 = num42 + num119 - 2.0 * num114;
					num45 = num43;
					val2.DrawLine(val5, (float)num42, (float)num43, (float)num44, (float)num45);
					num44 = num42;
					num45 = num43 - num116;
					val2.DrawLine(val5, (float)num42, (float)num43, (float)num44, (float)num45);
					num42 += num119 - 2.0 * num114;
					num44 = num42;
					num45 = num43 - num116;
					val2.DrawLine(val5, (float)num42, (float)num43, (float)num44, (float)num45);
					num43 = num45;
					num44 = num42 - (num119 - 2.0 * num114);
					val2.DrawLine(val5, (float)num42, (float)num43, (float)num44, (float)num45);
					num42 = (double)num3 + num29 / 2.0 + num118 + num114;
					num43 = (double)num6 + num31 * Math.Sin(num17) + num28 - num112 - num113;
					num44 = num42 + num119 - 2.0 * num114;
					num45 = num43;
					val2.DrawLine(val5, (float)num42, (float)num43, (float)num44, (float)num45);
					num44 = num42;
					num45 = num43 - num116;
					val2.DrawLine(val5, (float)num42, (float)num43, (float)num44, (float)num45);
					num42 += num119 - 2.0 * num114;
					num44 = num42;
					num45 = num43 - num116;
					val2.DrawLine(val5, (float)num42, (float)num43, (float)num44, (float)num45);
					num43 = num45;
					num44 = num42 - (num119 - 2.0 * num114);
					val2.DrawLine(val5, (float)num42, (float)num43, (float)num44, (float)num45);
					double num120 = 1.5;
					double num121 = 0.0;
					double num122 = 0.0;
					double num123 = 0.0;
					double num124 = 0.0;
					num111 = num105 * num120;
					num112 = num106 * num120;
					num107 = num101 * num120;
					num108 = num102 * num120;
					num109 = num103 * num120;
					num110 = num104 * num120;
					num123 = num - num4;
					num124 = (double)num26 + num22 * num18 + 40.0;
					num121 = (double)(num - num4) - num107;
					num122 = num124 + num112;
					num42 = num121;
					num43 = num122;
					num44 = num42 + num107;
					num45 = num43;
					val2.DrawLine(val5, (float)num42, (float)num43, (float)num44, (float)num45);
					num42 = num121;
					num43 = num122;
					num44 = num42;
					num45 = num43 + (double)num15;
					num82 = num44;
					num83 = num45;
					val2.DrawLine(val3, (float)num42, (float)num43, (float)num44, (float)num45);
					num42 += num107;
					num44 = num42;
					num125 = num44;
					num126 = num45;
					val2.DrawLine(val3, (float)num42, (float)num43, (float)num44, (float)num45);
					num42 = num82;
					num43 = num83 - 5.0;
					num44 = num125;
					num45 = num126 - 5.0;
					DrawRows(num42, num43, num44, num45, num18, val2, val3);
					num59 = (num82 + num125) / 2.0;
					num60 = num83 + (double)num21;
					val9.FormatFlags = (StringFormatFlags)1;
					val2.DrawString(num101.ToString(), val7, (Brush)(object)val8, (float)num59, (float)num60, val9);
					num42 = num121 + num107;
					num43 = num122;
					num44 = num42;
					num45 = num43 - num108;
					val2.DrawLine(val5, (float)num42, (float)num43, (float)num44, (float)num45);
					num42 = num121;
					num43 = num122;
					num44 = num42;
					num45 = num43 - num108;
					val2.DrawLine(val5, (float)num42, (float)num43, (float)num44, (float)num45);
					num44 = num42 - (double)num15;
					num45 = num43;
					val2.DrawLine(val3, (float)num42, (float)num43, (float)num44, (float)num45);
					num43 = num122 - num108;
					num44 = num42 - (double)num15;
					num45 = num43;
					val2.DrawLine(val3, (float)num42, (float)num43, (float)num44, (float)num45);
					num42 = num44 + 5.0;
					num43 = num122;
					num44 = num42;
					num45 = num43 - num108;
					DrawRows(num42, num43, num44, num45, num18, val2, val3);
					num59 = num42 - (double)num21 - 3.0;
					num60 = (num43 + num45) / 2.0;
					val9.FormatFlags = (StringFormatFlags)1;
					val2.DrawString(num102.ToString(), val7, (Brush)(object)val8, (float)num59, (float)num60, val9);
					num42 = num123 - num107 - 2.0 * num110;
					num43 = num124;
					num44 = num42;
					num45 = num43 + num109;
					val2.DrawLine(val5, (float)num42, (float)num43, (float)num44, (float)num45);
					num42 = num123 - num107 - 2.0 * num110;
					num43 = num124;
					num44 = num42;
					num45 = num43 + num109;
					val2.DrawLine(val5, (float)num42, (float)num43, (float)num44, (float)num45);
					num44 = num42 - (double)num15;
					num45 = num43;
					val2.DrawLine(val3, (float)num42, (float)num43, (float)num44, (float)num45);
					num42 = num123 - num107 - 2.0 * num110;
					num43 = num124 + num109;
					num44 = num42 - (double)num15;
					num45 = num43;
					val2.DrawLine(val3, (float)num42, (float)num43, (float)num44, (float)num45);
					num42 = num44 + 5.0;
					num43 = num124;
					num44 = num42;
					num45 = num43 + num109;
					DrawRows(num42, num43, num44, num45, num18, val2, val3);
					num59 = num42 - (double)num21 - 3.0;
					num60 = (num43 + num45) / 2.0;
					val9.FormatFlags = (StringFormatFlags)1;
					val2.DrawString(num103.ToString(), val7, (Brush)(object)val8, (float)num59, (float)num60, val9);
					num42 = num123 - num107 - 2.0 * num110;
					num43 = num124 + num109;
					num44 = num42 + num110;
					num45 = num43;
					val2.DrawLine(val5, (float)num42, (float)num43, (float)num44, (float)num45);
					num44 = num42;
					num45 = num43 + (double)num15;
					val2.DrawLine(val3, (float)num42, (float)num43, (float)num44, (float)num45);
					num42 = num44 + num110;
					num44 = num42;
					val2.DrawLine(val3, (float)num42, (float)num43, (float)num44, (float)num45);
					num42 = num123 - num107 - 2.0 * num110;
					num43 = num124 + num109 + (double)num15 - 5.0;
					num44 = num42 + num110;
					num45 = num43;
					DrawRows(num44, num45, num42, num43, num18, val2, val3);
					num59 = (num42 + num44) / 2.0;
					num60 = num43 + (double)num21;
					val9.FormatFlags = (StringFormatFlags)1;
					val2.DrawString(num104.ToString(), val7, (Brush)(object)val8, (float)num59, (float)num60, val9);
				}
				else
				{
					int num127 = 130;
					int num128 = (L + a) / 2 - num127;
					if (num128 <= 550)
					{
						nFiltr = 1;
						kFiltr[0] = 400;
					}
					else if (num128 <= 650)
					{
						nFiltr = 1;
						kFiltr[0] = 500;
					}
					else if (num128 <= 675)
					{
						nFiltr = 1;
						kFiltr[0] = 600;
					}
					else if (num128 <= 750)
					{
						nFiltr = 2;
						kFiltr[0] = 300;
						kFiltr[1] = 300;
					}
					else if (num128 <= 850)
					{
						nFiltr = 2;
						kFiltr[0] = 300;
						kFiltr[1] = 400;
					}
					else if (num128 <= 950)
					{
						nFiltr = 2;
						kFiltr[0] = 400;
						kFiltr[1] = 400;
					}
					else if (num128 <= 1050)
					{
						nFiltr = 2;
						kFiltr[0] = 400;
						kFiltr[1] = 500;
					}
					else if (num128 <= 1150)
					{
						nFiltr = 2;
						kFiltr[0] = 500;
						kFiltr[1] = 500;
					}
					else if (num128 <= 1250)
					{
						nFiltr = 2;
						kFiltr[0] = 500;
						kFiltr[1] = 600;
					}
					else if (num128 <= 1350)
					{
						nFiltr = 2;
						kFiltr[0] = 600;
						kFiltr[1] = 600;
					}
					else if (num128 <= 1450)
					{
						nFiltr = 3;
						kFiltr[0] = 400;
						kFiltr[1] = 400;
						kFiltr[2] = 500;
					}
					else if (num128 <= 1550)
					{
						nFiltr = 3;
						kFiltr[0] = 400;
						kFiltr[1] = 500;
						kFiltr[2] = 500;
					}
					else if (num128 <= 1650)
					{
						nFiltr = 3;
						kFiltr[0] = 500;
						kFiltr[1] = 500;
						kFiltr[2] = 500;
					}
					else if (num128 <= 1750)
					{
						nFiltr = 3;
						kFiltr[0] = 500;
						kFiltr[1] = 500;
						kFiltr[2] = 600;
					}
					else if (num128 <= 1850)
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
					L1 = num127;
					for (int i = 0; i < nFiltr; i++)
					{
						L1 += kFiltr[i];
					}
					kk = L1;
					if (!(L1 > (double)a))
					{
						return;
					}
					double num129 = (L1 - (double)a) * ((double)H - (double)h) / ((double)L - (double)a);
					double num130 = ((double)B - (double)b) * num129 / ((double)H - (double)h) + (double)b;
					int num131 = 70;
					l = (int)num130 - num131;
					double num132 = num129 * num18;
					double num133 = (double)l * num18;
					double num134 = (double)num131 * num18;
					double num135 = 40.0;
					double num136 = num135 * num18;
					num42 = (double)num3 + num134 / 2.0;
					num43 = (double)num6 + num31 * Math.Sin(num17) + num132;
					num44 = num42 + num133;
					num45 = num43;
					val2.DrawLine(val5, (float)num42, (float)num43, (float)num44, (float)num45);
					num44 = num42;
					num45 = num43 + num136;
					val2.DrawLine(val5, (float)num42, (float)num43, (float)num44, (float)num45);
					num42 = num44;
					num43 = num45;
					num44 = num42 + num133;
					val2.DrawLine(val5, (float)num42, (float)num43, (float)num44, (float)num45);
					num42 = num44;
					num45 = num43 - num136;
					val2.DrawLine(val5, (float)num42, (float)num43, (float)num44, (float)num45);
					num42 = (double)num3 + num134 / 2.0;
					num43 = (double)num6 + num31 * Math.Sin(num17) + num132;
					num44 = num42 - num134;
					num45 = num43;
					val2.DrawLine(val3, (float)num42, (float)num43, (float)num44, (float)num45);
					num42 = (double)num3 - num134 / 2.0 + 5.0;
					num43 = (double)num6 + num31 * Math.Sin(num17);
					num44 = num42;
					num45 = num43 + num132;
					DrawRows(num42, num43, num44, num45, num18, val2, val3);
					num59 = num42 - (double)num21;
					num60 = (num43 + num45) / 2.0;
					val9.FormatFlags = (StringFormatFlags)2;
					val2.DrawString(Math.Round(num129, MidpointRounding.AwayFromZero).ToString(), val7, (Brush)(object)val8, (float)num59, (float)num60, val9);
				}
			}
			num19 = ((double)(2 * num / 3) - num8 - (double)num4) / (double)L;
			num9 = num26 + (int)(num22 * num18) + 70;
			int num137 = 0;
			if (vyhid2 == "круглий" || vyhid2 == "прямокутний")
			{
				num9 += 25.0;
				num137 += 25;
			}
			num9 += (double)num15;
			if (num19 * (double)B + (double)(3 * num15) + (double)num137 > (double)num2 / 3.0)
			{
				num19 = ((double)num2 / 3.0 - (double)(3 * num15) - (double)num137) / (double)B;
			}
			num27 = (double)L * num19;
			num29 = (double)B * num19;
			num33 = c * num19;
			num31 = (double)a * num19;
			num32 = (double)b * num19;
			num49 = (double)d1 * num19;
			num61 = (double)a1 * num19;
			num62 = (double)b1 * num19;
			num50 = (double)p1 * num19;
			num47 = (double)f1 * num19;
			num48 = (double)g1 * num19;
			num69 = (double)d2 * num19;
			num77 = (double)a2 * num19;
			num78 = (double)b2 * num19;
			num70 = (double)p2 * num19;
			num67 = (double)f2 * num19;
			num68 = (double)g2 * num19;
			num42 = num8;
			num43 = num9;
			num44 = num42 + num27;
			num45 = num43;
			val2.DrawLine(val4, (float)num42, (float)num43, (float)num44, (float)num45);
			num42 = num44;
			num43 = num45;
			num44 = num42;
			num45 = num43 + num29;
			val2.DrawLine(val4, (float)num42, (float)num43, (float)num44, (float)num45);
			num42 = num8;
			num43 = num9;
			num44 = num42;
			num45 = num43 + num29;
			val2.DrawLine(val4, (float)num42, (float)num43, (float)num44, (float)num45);
			num42 = num8;
			num43 = num9 + num29;
			num44 = num42 + num27;
			num45 = num43;
			val2.DrawLine(val4, (float)num42, (float)num43, (float)num44, (float)num45);
			num42 = num8 + num27;
			num43 = num9 + num29;
			num44 = num42 + (double)num14;
			num45 = num43;
			num125 = num44;
			num126 = num45;
			val2.DrawLine(val3, (float)num42, (float)num43, (float)num44, (float)num45);
			num42 = num8 + num27;
			num43 = num9;
			num44 = num42 + (double)num14;
			num45 = num43;
			num82 = num44;
			num83 = num45;
			val2.DrawLine(val3, (float)num42, (float)num43, (float)num44, (float)num45);
			num42 = num82 - 5.0;
			num43 = num83;
			num44 = num125 - 5.0;
			num45 = num126;
			DrawRows(num42, num43, num44, num45, num19, val2, val3);
			num59 = num42 + (double)num21;
			num60 = (num83 + num126) / 2.0;
			val9.FormatFlags = (StringFormatFlags)2;
			val2.DrawString(B.ToString(), val7, (Brush)(object)val8, (float)num59, (float)num60, val9);
			num42 = num8;
			num43 = num9 + num29;
			num44 = num42;
			num45 = num43 + (double)num14;
			num82 = num44;
			num83 = num45;
			val2.DrawLine(val3, (float)num42, (float)num43, (float)num44, (float)num45);
			num42 = num8 + num27;
			num43 = num9 + num29;
			num44 = num42;
			num45 = num43 + (double)num14;
			num125 = num44;
			num126 = num45;
			val2.DrawLine(val3, (float)num42, (float)num43, (float)num44, (float)num45);
			num42 = num82;
			num43 = num83 - 5.0;
			num44 = num125;
			num45 = num126 - 5.0;
			DrawRows(num42, num43, num44, num45, num19, val2, val3);
			num59 = (num82 + num125) / 2.0;
			num60 = (num83 + num126) / 2.0 + (double)num21;
			val9.FormatFlags = (StringFormatFlags)1;
			val2.DrawString(L.ToString(), val7, (Brush)(object)val8, (float)num59, (float)num60, val9);
			num42 = num8;
			num43 = num9;
			num44 = num42;
			num45 = num43 - (double)num14;
			num82 = num44;
			num83 = num45;
			val2.DrawLine(val3, (float)num42, (float)num43, (float)num44, (float)num45);
			num42 = num8 + num33;
			num43 = num9;
			num44 = num42;
			num45 = num9 - (double)num14;
			num125 = num44;
			num126 = num45;
			val2.DrawLine(val3, (float)num42, (float)num43, (float)num44, (float)num45);
			num42 = num82;
			num43 = num83 + 5.0;
			num44 = num125;
			num45 = num126 + 5.0;
			DrawRows(num42, num43, num44, num45, num19, val2, val3);
			num59 = (num82 + num125) / 2.0;
			num60 = (num83 + num126) / 2.0 - (double)num21;
			val9.FormatFlags = (StringFormatFlags)1;
			val2.DrawString(c.ToString(), val7, (Brush)(object)val8, (float)num59, (float)num60, val9);
			num42 = num8 + num33;
			num43 = num9;
			num44 = num42 + num31;
			num45 = num43;
			val2.DrawLine(val4, (float)num42, (float)num43, (float)num44, (float)num45);
			num44 = num42;
			num45 = num43 + num32;
			val2.DrawLine(val4, (float)num42, (float)num43, (float)num44, (float)num45);
			num42 = num44;
			num43 = num45;
			num44 = num42 + num31;
			num45 = num43;
			val2.DrawLine(val4, (float)num42, (float)num43, (float)num44, (float)num45);
			num42 = num44;
			num45 -= num32;
			val2.DrawLine(val4, (float)num42, (float)num43, (float)num44, (float)num45);
			num42 = num8;
			num43 = num9;
			num44 = num42 + num33;
			num45 = num43;
			val2.DrawLine(val4, (float)num42, (float)num43, (float)num44, (float)num45);
			num42 = num8;
			num43 = num9 + num29;
			num44 = num42 + num33;
			num45 = num43 - (num29 - num32);
			val2.DrawLine(val4, (float)num42, (float)num43, (float)num44, (float)num45);
			num42 = num8 + num27;
			num43 = num9;
			num44 = num42 - (num27 - num33 - num31);
			num45 = num43;
			val2.DrawLine(val4, (float)num42, (float)num43, (float)num44, (float)num45);
			num42 = num8 + num27;
			num43 = num9 + num29;
			num44 = num42 - (num27 - num33 - num31);
			num45 = num43 - (num29 - num32);
			val2.DrawLine(val4, (float)num42, (float)num43, (float)num44, (float)num45);
			num8 += num33;
			if (vyhid == "з виходом")
			{
				if (vyhid1 == "круглий")
				{
					val2.DrawEllipse(val4, (float)(num8 + num47 - num49 / 2.0), (float)(num9 + num48 - num49 / 2.0), (float)num49, (float)num49);
					num42 = num8;
					num43 = num9;
					num44 = num42;
					num45 = num43 - (double)num15;
					num82 = num44;
					num83 = num45;
					val2.DrawLine(val3, (float)num42, (float)num43, (float)num44, (float)num45);
					num42 = num8 + num47;
					num43 = num9 + num48;
					num44 = num42;
					num45 = num43 - num48 - (double)num15;
					num125 = num44;
					num126 = num45;
					val2.DrawLine(val3, (float)num42, (float)num43, (float)num44, (float)num45);
					num42 = num82;
					num43 = num83 + 5.0;
					num44 = num125;
					num45 = num126 + 5.0;
					val2.DrawLine(val3, (float)num42, (float)num43, (float)num44, (float)num45);
					DrawRows(num42, num43, num44, num45, num19, val2, val3);
					num59 = (num42 + num44) / 2.0;
					num60 = num45 - (double)num21;
					val9.FormatFlags = (StringFormatFlags)1;
					val2.DrawString(f1.ToString(), val7, (Brush)(object)val8, (float)num59, (float)num60, val9);
					num42 = num8 + num47;
					num43 = num9 + num48;
					num44 = num42 + num49 / 2.0 + (double)num15;
					num45 = num43;
					num82 = num44;
					num83 = num45;
					val2.DrawLine(val3, (float)num42, (float)num43, (float)num44, (float)num45);
					num125 = num82;
					num126 = num9;
					num42 = num82 - 5.0;
					num43 = num83;
					num44 = num125 - 5.0;
					num45 = num126;
					DrawRows(num44, num45, num42, num43, num19, val2, val3);
					num59 = num42 + (double)num21;
					num60 = ((vyhid2 == "прямокутний") ? (num45 + 15.0) : ((num43 + num45) / 2.0));
					val9.FormatFlags = (StringFormatFlags)2;
					val2.DrawString(g1.ToString(), val7, (Brush)(object)val8, (float)num59, (float)num60, val9);
					num42 = num8 + num47 - num49 / 2.0;
					num43 = num9 + num48;
					num44 = num42;
					num45 = num43 + num49 / 2.0 + (double)num15;
					num82 = num44;
					num83 = num45;
					val2.DrawLine(val3, (float)num42, (float)num43, (float)num44, (float)num45);
					num42 = num8 + num47 + num49 / 2.0;
					num43 = num9 + num48;
					num44 = num42;
					num45 = num43 + num49 / 2.0 + (double)num15;
					num125 = num44;
					num126 = num45;
					val2.DrawLine(val3, (float)num42, (float)num43, (float)num44, (float)num45);
					num42 = num82;
					num43 = num83 - 5.0;
					num44 = num125;
					num45 = num126 - 5.0;
					DrawRows(num42, num43, num44, num45, num19, val2, val3);
					num59 = (num42 + num44) / 2.0;
					num60 = num45 + (double)num21;
					val9.FormatFlags = (StringFormatFlags)1;
					val2.DrawString(d1.ToString(), val7, (Brush)(object)val8, (float)num59, (float)num60, val9);
				}
				else if (vyhid1 == "прямокутний")
				{
					val2.DrawRectangle(val4, (float)(num8 + num47 - num61 / 2.0), (float)(num9 + num48 - num62 / 2.0), (float)num61, (float)num62);
					num42 = num8;
					num43 = num9;
					num44 = num42;
					num45 = num43 - (double)num15;
					num82 = num44;
					num83 = num45;
					val2.DrawLine(val3, (float)num42, (float)num43, (float)num44, (float)num45);
					num42 = num8 + num47;
					num43 = num9 + num48;
					num44 = num42;
					num45 = num43 - num48 - (double)num15;
					num125 = num44;
					num126 = num45;
					val2.DrawLine(val3, (float)num42, (float)num43, (float)num44, (float)num45);
					num42 = num82;
					num43 = num83 + 5.0;
					num44 = num125;
					num45 = num126 + 5.0;
					val2.DrawLine(val3, (float)num42, (float)num43, (float)num44, (float)num45);
					DrawRows(num42, num43, num44, num45, num19, val2, val3);
					num59 = (num42 + num44) / 2.0;
					num60 = num45 - (double)num21;
					val9.FormatFlags = (StringFormatFlags)1;
					val2.DrawString(f1.ToString(), val7, (Brush)(object)val8, (float)num59, (float)num60, val9);
					num42 = num8 + num47;
					num43 = num9 + num48;
					num44 = num42 + num61 / 2.0 + (double)num15;
					num45 = num43;
					num82 = num44;
					num83 = num45;
					val2.DrawLine(val3, (float)num42, (float)num43, (float)num44, (float)num45);
					num125 = num82;
					num126 = num9;
					num42 = num82 - 5.0;
					num43 = num83;
					num44 = num125 - 5.0;
					num45 = num126;
					DrawRows(num44, num45, num42, num43, num19, val2, val3);
					num59 = num42 + (double)num21;
					num60 = ((vyhid2 == "прямокутний") ? (num45 + 10.0) : ((num43 + num45) / 2.0));
					val9.FormatFlags = (StringFormatFlags)2;
					val2.DrawString(g1.ToString(), val7, (Brush)(object)val8, (float)num59, (float)num60, val9);
					num42 = num8 + num47 - num61 / 2.0;
					num43 = num9 + num48 + num62 / 2.0;
					num44 = num42;
					num45 = num43 + (double)num15;
					num82 = num44;
					num83 = num45;
					val2.DrawLine(val3, (float)num42, (float)num43, (float)num44, (float)num45);
					num42 = num8 + num47 + num61 / 2.0;
					num43 = num9 + num48 + num62 / 2.0;
					num44 = num42;
					num45 = num43 + (double)num15;
					num125 = num44;
					num126 = num45;
					val2.DrawLine(val3, (float)num42, (float)num43, (float)num44, (float)num45);
					num42 = num82;
					num43 = num83 - 5.0;
					num44 = num125;
					num45 = num126 - 5.0;
					DrawRows(num42, num43, num44, num45, num19, val2, val3);
					num59 = (num42 + num44) / 2.0;
					num60 = num45 + (double)num21;
					val9.FormatFlags = (StringFormatFlags)1;
					val2.DrawString(a1.ToString(), val7, (Brush)(object)val8, (float)num59, (float)num60, val9);
					num42 = num8 + num47 - num61 / 2.0;
					num43 = num9 + num48 - num62 / 2.0;
					num44 = num42 - (double)num15;
					num45 = num43;
					num82 = num44;
					num83 = num45;
					val2.DrawLine(val3, (float)num42, (float)num43, (float)num44, (float)num45);
					num42 = num8 + num47 - num61 / 2.0;
					num43 = num9 + num48 + num62 / 2.0;
					num44 = num42 - (double)num15;
					num45 = num43;
					num125 = num44;
					num126 = num45;
					val2.DrawLine(val3, (float)num42, (float)num43, (float)num44, (float)num45);
					num42 = num82 + 5.0;
					num43 = num83;
					num44 = num125 + 5.0;
					num45 = num126;
					val2.DrawLine(val3, (float)num42, (float)num43, (float)num44, (float)num45);
					DrawRows(num42, num43, num44, num45, num19, val2, val3);
					num59 = num42 - (double)num21 - 3.0;
					num60 = (num43 + num45) / 2.0;
					val9.FormatFlags = (StringFormatFlags)2;
					val2.DrawString(b1.ToString(), val7, (Brush)(object)val8, (float)num59, (float)num60, val9);
				}
				if (vyhid2 == "круглий")
				{
					val2.DrawEllipse(val4, (float)(num8 + num67 - num69 / 2.0), (float)(num9 + num68 - num69 / 2.0), (float)num69, (float)num69);
					num42 = num8;
					num43 = num9;
					num44 = num42;
					num45 = num43 - (double)num15 - 25.0;
					num82 = num44;
					num83 = num45;
					val2.DrawLine(val3, (float)num42, (float)num43, (float)num44, (float)num45);
					num42 = num8 + num67;
					num43 = num9 + num68;
					num44 = num42;
					num45 = num43 - num68 - (double)num15 - 25.0;
					num125 = num44;
					num126 = num45;
					val2.DrawLine(val3, (float)num42, (float)num43, (float)num44, (float)num45);
					num42 = num82;
					num43 = num83 + 5.0;
					num44 = num125;
					num45 = num126 + 5.0;
					val2.DrawLine(val3, (float)num42, (float)num43, (float)num44, (float)num45);
					num59 = (num42 + num44) / 2.0;
					num60 = num45 - (double)num21;
					val9.FormatFlags = (StringFormatFlags)1;
					val2.DrawString(f2.ToString(), val7, (Brush)(object)val8, (float)num59, (float)num60, val9);
					num42 = num8 + num67;
					num43 = num9 + num68;
					num44 = num42 + num69 / 2.0 + (double)num15;
					num45 = num43;
					num82 = num44;
					num83 = num45;
					val2.DrawLine(val3, (float)num42, (float)num43, (float)num44, (float)num45);
					num125 = num82;
					num126 = num9;
					num42 = num82 - 5.0;
					num43 = num83;
					num44 = num125 - 5.0;
					num45 = num126;
					DrawRows(num44, num45, num42, num43, num19, val2, val3);
					num59 = num42 + (double)num21;
					num60 = (num43 + num45) / 2.0;
					val9.FormatFlags = (StringFormatFlags)2;
					val2.DrawString(g2.ToString(), val7, (Brush)(object)val8, (float)num59, (float)num60, val9);
					num42 = num8 + num67 - num69 / 2.0;
					num43 = num9 + num68;
					num44 = num42;
					num45 = num43 + num69 / 2.0 + (double)num15;
					num82 = num44;
					num83 = num45;
					val2.DrawLine(val3, (float)num42, (float)num43, (float)num44, (float)num45);
					num42 = num8 + num67 + num69 / 2.0;
					num43 = num9 + num68;
					num44 = num42;
					num45 = num43 + num69 / 2.0 + (double)num15;
					num125 = num44;
					num126 = num45;
					val2.DrawLine(val3, (float)num42, (float)num43, (float)num44, (float)num45);
					num42 = num82;
					num43 = num83 - 5.0;
					num44 = num125;
					num45 = num126 - 5.0;
					DrawRows(num42, num43, num44, num45, num19, val2, val3);
					num59 = (num42 + num44) / 2.0;
					num60 = num45 + (double)num21 + 3.0;
					val9.FormatFlags = (StringFormatFlags)1;
					val2.DrawString(d2.ToString(), val7, (Brush)(object)val8, (float)num59, (float)num60, val9);
				}
				else if (vyhid2 == "прямокутний")
				{
					val2.DrawRectangle(val4, (float)(num8 + num67 - num77 / 2.0), (float)(num9 + num68 - num78 / 2.0), (float)num77, (float)num78);
					num42 = num8;
					num43 = num9;
					num44 = num42;
					num45 = num43 - (double)num15 - 25.0;
					num82 = num44;
					num83 = num45;
					val2.DrawLine(val3, (float)num42, (float)num43, (float)num44, (float)num45);
					num42 = num8 + num67;
					num43 = num9 + num68;
					num44 = num42;
					num45 = num43 - num68 - (double)num15 - 25.0;
					num125 = num44;
					num126 = num45;
					val2.DrawLine(val3, (float)num42, (float)num43, (float)num44, (float)num45);
					num42 = num82;
					num43 = num83 + 5.0;
					num44 = num125;
					num45 = num126 + 5.0;
					DrawRows(num42, num43, num44, num45, num19, val2, val3);
					num59 = (num42 + num44) / 2.0;
					num60 = num45 - (double)num21;
					val9.FormatFlags = (StringFormatFlags)1;
					val2.DrawString(f2.ToString(), val7, (Brush)(object)val8, (float)num59, (float)num60, val9);
					num42 = num8 + num67;
					num43 = num9 + num68;
					num44 = num42 + num77 / 2.0 + (double)num15;
					num45 = num43;
					num82 = num44;
					num83 = num45;
					val2.DrawLine(val3, (float)num42, (float)num43, (float)num44, (float)num45);
					num125 = num82;
					num126 = num9;
					num42 = num82 - 5.0;
					num43 = num83;
					num44 = num125 - 5.0;
					num45 = num126;
					DrawRows(num44, num45, num42, num43, num19, val2, val3);
					num59 = num42 + (double)num21;
					num60 = (num43 + num45) / 2.0;
					val9.FormatFlags = (StringFormatFlags)2;
					val2.DrawString(g2.ToString(), val7, (Brush)(object)val8, (float)num59, (float)num60, val9);
					num42 = num8 + num67 - num77 / 2.0;
					num43 = num9 + num68 + num78 / 2.0;
					num44 = num42;
					num45 = num43 + (double)num15;
					num82 = num44;
					num83 = num45;
					val2.DrawLine(val3, (float)num42, (float)num43, (float)num44, (float)num45);
					num42 = num8 + num67 + num77 / 2.0;
					num43 = num9 + num68 + num78 / 2.0;
					num44 = num42;
					num45 = num43 + (double)num15;
					num125 = num44;
					num126 = num45;
					val2.DrawLine(val3, (float)num42, (float)num43, (float)num44, (float)num45);
					num42 = num82;
					num43 = num83 - 5.0;
					num44 = num125;
					num45 = num126 - 5.0;
					DrawRows(num42, num43, num44, num45, num19, val2, val3);
					num59 = (num42 + num44) / 2.0;
					num60 = num45 + (double)num21;
					val9.FormatFlags = (StringFormatFlags)1;
					val2.DrawString(a2.ToString(), val7, (Brush)(object)val8, (float)num59, (float)num60, val9);
					num42 = num8 + num67 - num77 / 2.0;
					num43 = num9 + num68 - num78 / 2.0;
					num44 = num42 - (double)num15;
					num45 = num43;
					num82 = num44;
					num83 = num45;
					val2.DrawLine(val3, (float)num42, (float)num43, (float)num44, (float)num45);
					num42 = num8 + num67 - num77 / 2.0;
					num43 = num9 + num68 + num78 / 2.0;
					num44 = num42 - (double)num15;
					num45 = num43;
					num125 = num44;
					num126 = num45;
					val2.DrawLine(val3, (float)num42, (float)num43, (float)num44, (float)num45);
					num42 = num82 + 5.0;
					num43 = num83;
					num44 = num125 + 5.0;
					num45 = num126;
					DrawRows(num42, num43, num44, num45, num19, val2, val3);
					num59 = num42 - (double)num21 - 3.0;
					num60 = (num43 + num45) / 2.0;
					val9.FormatFlags = (StringFormatFlags)2;
					val2.DrawString(b2.ToString(), val7, (Brush)(object)val8, (float)num59, (float)num60, val9);
				}
			}
			num12 = num3;
			num13 = num26 + (int)(num22 * num18) + 70;
			num13 += num2 / 3 + 20;
			int num139 = 10;
			int num140 = 0;
			Font val10 = new Font("Arial", (float)num139);
			StringFormat val11 = new StringFormat();
			val11.LineAlignment = (StringAlignment)0;
			val11.Alignment = (StringAlignment)0;
			if (zhyrFiltr == "так")
			{
				for (int j = 0; j < nFiltr; j++)
				{
					switch (j)
					{
					case 0:
						val2.DrawString("Ширина першого жирфільтра: " + kFiltr[0] + "мм * 2шт", val10, (Brush)(object)val8, (float)num12, (float)(num13 + num140), val11);
						break;
					case 1:
						val2.DrawString("Ширина другого жирфільтра: " + kFiltr[1] + "мм * 2шт", val10, (Brush)(object)val8, (float)num12, (float)(num13 + num140), val11);
						break;
					case 2:
						val2.DrawString("Ширина третього жирфільтра: " + kFiltr[2] + "мм * 2шт", val10, (Brush)(object)val8, (float)num12, (float)(num13 + num140), val11);
						break;
					}
					num140 += num139 + 8;
					if (num13 + num140 > num2 - num7)
					{
						num12 = num3 + num / 2;
						num140 = 0;
					}
				}
				if (nFiltr == 1)
				{
					val2.DrawString("Довжина жирфільтра: " + l + "мм", val10, (Brush)(object)val8, (float)num12, (float)(num13 + num140), val11);
				}
				else
				{
					val2.DrawString("Довжина жирфільтрів: " + l + "мм", val10, (Brush)(object)val8, (float)num12, (float)(num13 + num140), val11);
				}
				num140 += num139 + 8;
				if (num13 + num140 > num2 - num7)
				{
					num12 = num3 + num / 2;
					num140 = 0;
				}
			}
			val2.DrawString("Матеріал зонта: " + zontMaterial, val10, (Brush)(object)val8, (float)num12, (float)(num13 + num140), val11);
			num140 += num139 + 8;
			if (num13 + num140 > num2 - num7)
			{
				num12 = num3 + num / 2;
				num140 = 0;
			}
			val2.DrawString("Товщина металу зонта: " + tovchynaMetaluZont + "мм", val10, (Brush)(object)val8, (float)num12, (float)(num13 + num140), val11);
			num140 += num139 + 8;
			if (num13 + num140 > num2 - num7)
			{
				num12 = num3 + num / 2;
				num140 = 0;
			}
			val2.DrawString("З'єднання: " + connection, val10, (Brush)(object)val8, (float)num12, (float)(num13 + num140), val11);
			num140 += num139 + 8;
			if (num13 + num140 > num2 - num7)
			{
				num12 = num3 + num / 2;
				num140 = 0;
			}
			val2.DrawString("Трубка зливу 1/2': " + zlyv, val10, (Brush)(object)val8, (float)num12, (float)(num13 + num140), val11);
			num140 += num139 + 8;
			if (num13 + num140 > num2 - num7)
			{
				num12 = num3 + num / 2;
				num140 = 0;
			}
			val2.DrawString("Кріплення: " + fastening, val10, (Brush)(object)val8, (float)num12, (float)(num13 + num140), val11);
			if (fastening == "так")
			{
				num140 += num139 + 8;
				if (num13 + num140 > num2 - num7)
				{
					num12 = num3 + num / 2;
					num140 = 0;
				}
				val2.DrawString("Тип кріплення: " + typeFastening, val10, (Brush)(object)val8, (float)num12, (float)(num13 + num140), val11);
			}
			if (vyhid == "з виходом")
			{
				if (vyhid1 == "круглий" || vyhid1 == "прямокутний")
				{
					num140 += num139 + 8;
					if (num13 + num140 > num2 - num7)
					{
						num12 = num3 + num / 2;
						num140 = 0;
					}
					val2.DrawString("Тип виходу 1: " + typVyhid1, val10, (Brush)(object)val8, (float)num12, (float)(num13 + num140), val11);
					if (typVyhid1 == "фланець")
					{
						num140 += num139 + 8;
						if (num13 + num140 > num2 - num7)
						{
							num12 = num3 + num / 2;
							num140 = 0;
						}
						val2.DrawString("Тип профілю для виходу 1: " + profilType1, val10, (Brush)(object)val8, (float)num12, (float)(num13 + num140), val11);
					}
				}
				if (vyhid2 == "круглий" || vyhid2 == "прямокутний")
				{
					num140 += num139 + 8;
					if (num13 + num140 > num2 - num7)
					{
						num12 = num3 + num / 2;
						num140 = 0;
					}
					val2.DrawString("Тип виходу 2: " + typVyhid2, val10, (Brush)(object)val8, (float)num12, (float)(num13 + num140), val11);
					if (typVyhid2 == "фланець")
					{
						num140 += num139 + 8;
						if (num13 + num140 > num2 - num7)
						{
							num12 = num3 + num / 2;
							num140 = 0;
						}
						val2.DrawString("Тип профілю для виходу 2: " + profilType2, val10, (Brush)(object)val8, (float)num12, (float)(num13 + num140), val11);
					}
				}
			}
			if (zhyrFiltr == "так")
			{
				num140 += num139 + 8;
				if (num13 + num140 > num2 - num7)
				{
					num12 = num3 + num / 2;
					num140 = 0;
				}
				val2.DrawString("Матеріал жирфільтра: " + zhyrFiltrMaterial, val10, (Brush)(object)val8, (float)num12, (float)(num13 + num140), val11);
				num140 += num139 + 8;
				if (num13 + num140 > num2 - num7)
				{
					num12 = num3 + num / 2;
					num140 = 0;
				}
				val2.DrawString("Товщина металу жирфільтра: " + tovchynaMetaluFiltr + "мм", val10, (Brush)(object)val8, (float)num12, (float)(num13 + num140), val11);
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

	public static double VolumeZontPrystinnyyTyp3(int L, int B, int H, int p1, int p2)
	{
		int num = ((p1 > p2) ? p1 : p2);
		return Math.Round((double)L * (double)B * (double)(H + num) / 1000000.0) / 1000.0;
	}
}
