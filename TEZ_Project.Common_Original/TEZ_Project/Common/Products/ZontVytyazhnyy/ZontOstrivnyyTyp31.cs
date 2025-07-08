using System;
using System.Drawing;
using System.Globalization;
using System.IO;
using TEZ_Project.Common.Helpers;

namespace TEZ_Project.Common.Products.ZontVytyazhnyy;

public class ZontOstrivnyyTyp31
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

	public static double[,] MaterialZontOstrivnyyTyp31(int L, int B, int H, int h, int a, int b, int p, double c, double c1, int number, string markaStaliZont, string tovchynaMetaluZont, string connection, string zlyv, string fastening, string typeFastening, string zhyrFiltr, string markaStaliFiltr, string tovchynaMetaluFiltr, string implementation1)
	{
		double[,] array = new double[32, 6];
		int num = -1;
		double num2 = 0.0;
		double num3 = 0.0;
		double num4 = 0.0;
		double num5 = 0.0;
		double num6 = 0.0;
		double num7 = 0.0;
		int num8 = 750;
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
		double num9 = Math.Sqrt(Math.Pow(c, 2.0) + Math.Pow(c1, 2.0) + Math.Pow(H - h, 2.0));
		double num10 = Math.Sqrt(Math.Pow(c, 2.0) + Math.Pow((double)(B - b) - c1, 2.0) + Math.Pow(H - h, 2.0));
		double num11 = Math.Sqrt(Math.Pow((double)(L - a) - c, 2.0) + Math.Pow((double)(B - b) - c1, 2.0) + Math.Pow(H - h, 2.0));
		double num12 = Math.Sqrt(Math.Pow((double)(L - a) - c, 2.0) + Math.Pow(c1, 2.0) + Math.Pow(H - h, 2.0));
		double num13 = 1.0;
		double num14 = 10.0;
		double num15 = 20.0;
		double num16 = 25.0;
		double num17 = ((connection == "зварка") ? 12 : 15);
		double num18 = Math.Sqrt(Math.Pow(num9, 2.0) - Math.Pow(c1, 2.0));
		num18 += num14 + num15 + num16 + (double)h + 2.0 * num13;
		double num19 = B;
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
		num18 = Math.Sqrt(Math.Pow(num12, 2.0) - Math.Pow(c1, 2.0));
		num18 += num14 + num15 + num16 + (double)h + 2.0 * num13;
		num19 = B;
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
		num18 = Math.Sqrt(Math.Pow(num9, 2.0) - Math.Pow(c, 2.0));
		num18 += num14 + num15 + num16 + (double)h;
		num19 = (double)L + 2.0 * num17;
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
		num18 = Math.Sqrt(Math.Pow(num10, 2.0) - Math.Pow(c, 2.0));
		num18 += num14 + num15 + num16 + (double)h;
		num19 = (double)L + 2.0 * num17;
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
		num5 += 2.0 * (double)(a + b) * (double)p;
		if (zhyrFiltr == "так")
		{
			if (implementation1 == "ж/ф внизу зонта (2 ряди)")
			{
				double num20 = 54.5;
				double num21 = 15.0;
				num7 = (num20 + num21) * (double)(L - 10);
				num20 = 24.5;
				num21 = 109.0;
				num7 += (num21 + 2.0 * (num20 + num13)) * (double)(L - 5);
			}
			else
			{
				double num22 = 9.5;
				double num23 = 59.0;
				double num24 = 64.5;
				double num25 = 20.0;
				double num26 = 70.0;
				num7 = (num22 + num23 + num24 + num25 + 2.0 * num13) * ((double)ZontOstrivnyyTyp31.l + num26);
				double num27 = 20.0;
				double num28 = 60.0;
				double num29 = 15.0;
				double num30 = 35.0;
				num7 += (num27 + num28 + 2.0 * num29 + num30) * (kk + 2.0 * num29);
			}
		}
		num6 = 50.0 * (double)(a + b);
		array[num, 0] = (num5 + num6 + num7) * 1.05 / 1000000.0;
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
			int num31 = 50;
			int num32 = 4 * ((int)Math.Round(((double)h - 22.0 - 28.0) / (double)num31, MidpointRounding.AwayFromZero) + 1);
			num32 += (int)Math.Round((num9 - 22.0 - 28.0) / (double)num31, MidpointRounding.AwayFromZero) + 1;
			num32 += (int)Math.Round((num10 - 22.0 - 28.0) / (double)num31, MidpointRounding.AwayFromZero) + 1;
			num32 += (int)Math.Round((num11 - 22.0 - 28.0) / (double)num31, MidpointRounding.AwayFromZero) + 1;
			num32 += (int)Math.Round((num12 - 22.0 - 28.0) / (double)num31, MidpointRounding.AwayFromZero) + 1;
			num32 += ((implementation1 == "ж/ф внизу зонта (2 ряди)") ? 4 : 11);
			num++;
			materialName[num] = Consts2.zaklepkaKombinov48x6.MaterialName;
			array[num, 0] = num32;
			array[num, 4] = array[num, 0] * (double)number;
			materialCost += array[num, 0] * Consts2.zaklepkaKombinov48x6.Price;
		}
		if (zhyrFiltr == "так")
		{
			double[] array2 = new double[6];
			for (int j = 0; j < nFiltr; j++)
			{
				array2 = FiltrZh.MaterialFiltrZh(kFiltr[j], ZontOstrivnyyTyp31.l, markaStaliFiltr, tovchynaMetaluFiltr, number);
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
		if (num > 0)
		{
			for (int l = 0; l < num; l++)
			{
				for (int m = l + 1; m <= num; m++)
				{
					if (!(materialName[l] == materialName[m]))
					{
						continue;
					}
					for (int n = 0; n < 6; n++)
					{
						if (n == 1)
						{
							if (materialName[l] == Consts2.lystStalnyj30.MaterialName)
							{
								array[l, n] = Math.Round((array[l, n] + array[m, n]) / 2.0);
							}
						}
						else
						{
							array[l, n] += array[m, n];
						}
						array[m, n] = 0.0;
					}
					materialName[m] = "";
				}
			}
		}
		priceProduct = Math.Round(100.0 * materialCost * 3.0) / 100.0;
		return array;
	}

	public static void ZontOstrivnyyTyp31DrawDxf(int L, int B, int H, int h, int a, int b, int p, double c, double c1, string connection, string zlyv, string zhyrFiltr, string implementation1, string filePath)
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
			double num9 = p;
			double num10 = 112.0;
			double num11 = ((connection == "зварка") ? 12 : 15);
			double num12 = 0.0;
			double num13 = 0.0;
			int num14 = 130;
			int num15 = (L + a) / 2 - num14;
			if (num15 <= 550)
			{
				nFiltr = 1;
				kFiltr[0] = 400;
			}
			else if (num15 <= 650)
			{
				nFiltr = 1;
				kFiltr[0] = 500;
			}
			else if (num15 <= 675)
			{
				nFiltr = 1;
				kFiltr[0] = 600;
			}
			else if (num15 <= 750)
			{
				nFiltr = 2;
				kFiltr[0] = 300;
				kFiltr[1] = 300;
			}
			else if (num15 <= 850)
			{
				nFiltr = 2;
				kFiltr[0] = 300;
				kFiltr[1] = 400;
			}
			else if (num15 <= 950)
			{
				nFiltr = 2;
				kFiltr[0] = 400;
				kFiltr[1] = 400;
			}
			else if (num15 <= 1050)
			{
				nFiltr = 2;
				kFiltr[0] = 400;
				kFiltr[1] = 500;
			}
			else if (num15 <= 1150)
			{
				nFiltr = 2;
				kFiltr[0] = 500;
				kFiltr[1] = 500;
			}
			else if (num15 <= 1250)
			{
				nFiltr = 2;
				kFiltr[0] = 500;
				kFiltr[1] = 600;
			}
			else if (num15 <= 1350)
			{
				nFiltr = 2;
				kFiltr[0] = 600;
				kFiltr[1] = 600;
			}
			else if (num15 <= 1450)
			{
				nFiltr = 3;
				kFiltr[0] = 400;
				kFiltr[1] = 400;
				kFiltr[2] = 500;
			}
			else if (num15 <= 1550)
			{
				nFiltr = 3;
				kFiltr[0] = 400;
				kFiltr[1] = 500;
				kFiltr[2] = 500;
			}
			else if (num15 <= 1650)
			{
				nFiltr = 3;
				kFiltr[0] = 500;
				kFiltr[1] = 500;
				kFiltr[2] = 500;
			}
			else if (num15 <= 1750)
			{
				nFiltr = 3;
				kFiltr[0] = 500;
				kFiltr[1] = 500;
				kFiltr[2] = 600;
			}
			else if (num15 <= 1850)
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
			L1 = num14;
			for (int i = 0; i < nFiltr; i++)
			{
				L1 += kFiltr[i];
			}
			double num16 = Math.Sqrt(Math.Pow(c, 2.0) + Math.Pow(c1, 2.0) + Math.Pow(H - h, 2.0));
			double num17 = Math.Sqrt(Math.Pow(c, 2.0) + Math.Pow((double)(B - b) - c1, 2.0) + Math.Pow(H - h, 2.0));
			double num18 = Math.Sqrt(Math.Pow((double)(L - a) - c, 2.0) + Math.Pow((double)(B - b) - c1, 2.0) + Math.Pow(H - h, 2.0));
			double num19 = Math.Sqrt(Math.Pow((double)(L - a) - c, 2.0) + Math.Pow(c1, 2.0) + Math.Pow(H - h, 2.0));
			double num20 = (L1 - (double)a) * ((double)H - (double)h) / ((double)L - (double)a);
			double num21 = 40.0;
			num2 = num7 + num8;
			num3 = 0.0;
			num4 = num2 + (double)L - 2.0 * num8;
			num5 = num3;
			ushort num22 = (ushort)(num + 1);
			num = num22;
			DrawLine(streamWriter, num22, text, num12 + num2, num13 + num3, num12 + num4, num13 + num5);
			num4 = num2;
			num5 = num3 + num7;
			num22 = (ushort)(num + 1);
			num = num22;
			DrawLine(streamWriter, num22, text, num12 + num2, num13 + num3, num12 + num4, num13 + num5);
			num3 = num5;
			num4 = num2 - num8;
			num5 += num8;
			num22 = (ushort)(num + 1);
			num = num22;
			DrawLine(streamWriter, num22, text, num12 + num2, num13 + num3, num12 + num4, num13 + num5);
			double num23 = num5;
			num2 = num4;
			num3 = num5;
			num4 = num2 - num11;
			num5 += num11;
			num22 = (ushort)(num + 1);
			num = num22;
			DrawLine(streamWriter, num22, text, num12 + num2, num13 + num3, num12 + num4, num13 + num5);
			double num24 = num4;
			double num25 = Math.Acos(c / num16);
			double num26 = num11 * Math.Tan(num25);
			num2 = num4;
			num3 = num5;
			num4 = num2;
			num5 += (double)h - num11 - num26;
			num22 = (ushort)(num + 1);
			num = num22;
			DrawLine(streamWriter, num22, text, num12 + num2, num13 + num3, num12 + num4, num13 + num5);
			num2 = num4;
			num3 = num5;
			num4 = num2 + num11;
			num5 += num26;
			num22 = (ushort)(num + 1);
			num = num22;
			DrawLine(streamWriter, num22, text, num12 + num2, num13 + num3, num12 + num4, num13 + num5);
			num = DrawZaklepka_5(streamWriter, num, text, connection, num24 + num12, num23 + num13, num24 + num12, num5 + num13, 1);
			num24 = num4;
			num23 = num5;
			num2 = num4;
			num3 = num5;
			num5 += num11 / Math.Cos(num25);
			num22 = (ushort)(num + 1);
			num = num22;
			DrawLine(streamWriter, num22, text, num12 + num2, num13 + num3, num12 + num4, num13 + num5);
			num2 = num4;
			num3 = num5;
			num4 = num2 + (num16 - num11) * Math.Cos(num25) - num11 * Math.Sin(num25);
			num5 = num3 + (num16 - num11) * Math.Sin(num25) + num11 * Math.Cos(num25) - num11 / Math.Cos(num25);
			num22 = (ushort)(num + 1);
			num = num22;
			DrawLine(streamWriter, num22, text, num12 + num2, num13 + num3, num12 + num4, num13 + num5);
			num2 = num4;
			num3 = num5;
			num4 = num24 + num16 * Math.Cos(num25);
			num5 = num23 + num16 * Math.Sin(num25);
			num22 = (ushort)(num + 1);
			num = num22;
			DrawLine(streamWriter, num22, text, num12 + num2, num13 + num3, num12 + num4, num13 + num5);
			double z = ((double)H - (double)h - num20 - num21 / 2.0) * num16 / ((double)H - (double)h);
			num = DrawZaklepka_6(streamWriter, num, text, connection, num24 - num11 * Math.Sin(num25) + num12, num23 + num11 * Math.Cos(num25) + num13, num4 - num11 * Math.Sin(num25) + num12, num5 + num11 * Math.Cos(num25) + num13, z, 1);
			num2 = num4;
			num3 = num5;
			num4 = num2;
			num5 = num3 + num9;
			num22 = (ushort)(num + 1);
			num = num22;
			DrawLine(streamWriter, num22, text, num12 + num2, num13 + num3, num12 + num4, num13 + num5);
			num2 = num4;
			num3 = num5;
			num4 = num2 + (double)a;
			num22 = (ushort)(num + 1);
			num = num22;
			DrawLine(streamWriter, num22, text, num12 + num2, num13 + num3, num12 + num4, num13 + num5);
			double num27 = 0.0;
			double p2 = 0.0;
			if (implementation1 == "ж/ф в середині зонта")
			{
				double num28 = (num20 + num21 - 50.0) * Math.Sqrt(Math.Pow(num16, 2.0) - Math.Pow(c, 2.0)) / (double)(H - h) - 10.0;
				num27 = num4 - (double)(a / 2);
				p2 = num5 - num28;
				num22 = (ushort)(num + 1);
				num = num22;
				DrawCircle(streamWriter, num22, text, num27, p2, 2.65);
			}
			num2 = num4;
			num3 = num5;
			num4 = num2;
			num5 = num3 - num9;
			num22 = (ushort)(num + 1);
			num = num22;
			DrawLine(streamWriter, num22, text, num12 + num2, num13 + num3, num12 + num4, num13 + num5);
			num2 = num7 + (double)L - num8;
			num3 = 0.0;
			num4 = num2;
			num5 = num3 + num7;
			num22 = (ushort)(num + 1);
			num = num22;
			DrawLine(streamWriter, num22, text, num12 + num2, num13 + num3, num12 + num4, num13 + num5);
			num3 = num5;
			num4 = num2 + num8;
			num5 += num8;
			num22 = (ushort)(num + 1);
			num = num22;
			DrawLine(streamWriter, num22, text, num12 + num2, num13 + num3, num12 + num4, num13 + num5);
			num23 = num5;
			num2 = num4;
			num3 = num5;
			num4 = num2 + num11;
			num5 += num11;
			num22 = (ushort)(num + 1);
			num = num22;
			DrawLine(streamWriter, num22, text, num12 + num2, num13 + num3, num12 + num4, num13 + num5);
			num24 = num4;
			num25 = Math.Acos(((double)L - c - (double)a) / num19);
			num26 = num11 * Math.Tan(num25);
			num2 = num4;
			num3 = num5;
			num4 = num2;
			num5 += (double)h - num11 - num26;
			num22 = (ushort)(num + 1);
			num = num22;
			DrawLine(streamWriter, num22, text, num12 + num2, num13 + num3, num12 + num4, num13 + num5);
			num2 = num4;
			num3 = num5;
			num4 = num2 - num11;
			num5 += num26;
			num22 = (ushort)(num + 1);
			num = num22;
			DrawLine(streamWriter, num22, text, num12 + num2, num13 + num3, num12 + num4, num13 + num5);
			num = DrawZaklepka_5(streamWriter, num, text, connection, num24 + num12, num23 + num13, num24 + num12, num5 + num13, 0);
			num24 = num4;
			num23 = num5;
			num2 = num4;
			num3 = num5;
			num5 += num11 / Math.Cos(num25);
			num22 = (ushort)(num + 1);
			num = num22;
			DrawLine(streamWriter, num22, text, num12 + num2, num13 + num3, num12 + num4, num13 + num5);
			num2 = num4;
			num3 = num5;
			num4 = num2 - (num19 - num11) * Math.Cos(num25) + num11 * Math.Sin(num25);
			num5 = num3 + (num19 - num11) * Math.Sin(num25) + num11 * Math.Cos(num25) - num11 / Math.Cos(num25);
			num22 = (ushort)(num + 1);
			num = num22;
			DrawLine(streamWriter, num22, text, num12 + num2, num13 + num3, num12 + num4, num13 + num5);
			num2 = num4;
			num3 = num5;
			num4 = num24 - num19 * Math.Cos(num25);
			num5 = num23 + num19 * Math.Sin(num25);
			num22 = (ushort)(num + 1);
			num = num22;
			DrawLine(streamWriter, num22, text, num12 + num2, num13 + num3, num12 + num4, num13 + num5);
			double z2 = (num20 + num21 / 2.0) * num19 / ((double)H - (double)h);
			num = DrawZaklepka_7(streamWriter, num, text, connection, num4 + num11 * Math.Sin(num25) + num12, num5 + num11 * Math.Cos(num25) + num13, num24 + num11 * Math.Sin(num25) + num12, num23 + num11 * Math.Cos(num25) + num13, z2, 1);
			num12 += (double)(L + 100);
			num2 = num7 + num8;
			num3 = 0.0;
			num4 = num2 + (double)L - 2.0 * num8;
			num5 = num3;
			num22 = (ushort)(num + 1);
			num = num22;
			DrawLine(streamWriter, num22, text, num12 + num2, num13 + num3, num12 + num4, num13 + num5);
			num4 = num2;
			num5 = num3 + num7;
			num22 = (ushort)(num + 1);
			num = num22;
			DrawLine(streamWriter, num22, text, num12 + num2, num13 + num3, num12 + num4, num13 + num5);
			num3 = num5;
			num4 = num2 - num8;
			num5 += num8;
			num22 = (ushort)(num + 1);
			num = num22;
			DrawLine(streamWriter, num22, text, num12 + num2, num13 + num3, num12 + num4, num13 + num5);
			num23 = num5;
			num2 = num4;
			num3 = num5;
			num4 = num2 - num11;
			num5 += num11;
			num22 = (ushort)(num + 1);
			num = num22;
			DrawLine(streamWriter, num22, text, num12 + num2, num13 + num3, num12 + num4, num13 + num5);
			num24 = num4;
			num25 = Math.Acos(c / num17);
			num26 = num11 * Math.Tan(num25);
			num2 = num4;
			num3 = num5;
			num4 = num2;
			num5 += (double)h - num11 - num26;
			num22 = (ushort)(num + 1);
			num = num22;
			DrawLine(streamWriter, num22, text, num12 + num2, num13 + num3, num12 + num4, num13 + num5);
			num2 = num4;
			num3 = num5;
			num4 = num2 + num11;
			num5 += num26;
			num22 = (ushort)(num + 1);
			num = num22;
			DrawLine(streamWriter, num22, text, num12 + num2, num13 + num3, num12 + num4, num13 + num5);
			num = DrawZaklepka_5(streamWriter, num, text, connection, num24 + num12, num23 + num13, num24 + num12, num5 + num13, 1);
			num24 = num4;
			num23 = num5;
			num2 = num4;
			num3 = num5;
			num5 += num11 / Math.Cos(num25);
			num22 = (ushort)(num + 1);
			num = num22;
			DrawLine(streamWriter, num22, text, num12 + num2, num13 + num3, num12 + num4, num13 + num5);
			num2 = num4;
			num3 = num5;
			num4 = num2 + (num17 - num11) * Math.Cos(num25) - num11 * Math.Sin(num25);
			num5 = num3 + (num17 - num11) * Math.Sin(num25) + num11 * Math.Cos(num25) - num11 / Math.Cos(num25);
			num22 = (ushort)(num + 1);
			num = num22;
			DrawLine(streamWriter, num22, text, num12 + num2, num13 + num3, num12 + num4, num13 + num5);
			num2 = num4;
			num3 = num5;
			num4 = num24 + num17 * Math.Cos(num25);
			num5 = num23 + num17 * Math.Sin(num25);
			num22 = (ushort)(num + 1);
			num = num22;
			DrawLine(streamWriter, num22, text, num12 + num2, num13 + num3, num12 + num4, num13 + num5);
			double z3 = ((double)H - (double)h - num20 - num21 / 2.0) * num17 / ((double)H - (double)h);
			num = DrawZaklepka_6(streamWriter, num, text, connection, num24 - num11 * Math.Sin(num25) + num12, num23 + num11 * Math.Cos(num25) + num13, num4 - num11 * Math.Sin(num25) + num12, num5 + num11 * Math.Cos(num25) + num13, z3, 1);
			num2 = num4;
			num3 = num5;
			num4 = num2;
			num5 = num3 + num9;
			num22 = (ushort)(num + 1);
			num = num22;
			DrawLine(streamWriter, num22, text, num12 + num2, num13 + num3, num12 + num4, num13 + num5);
			num2 = num4;
			num3 = num5;
			num4 = num2 + (double)a;
			num22 = (ushort)(num + 1);
			num = num22;
			DrawLine(streamWriter, num22, text, num12 + num2, num13 + num3, num12 + num4, num13 + num5);
			num2 = num4;
			num3 = num5;
			num4 = num2;
			num5 = num3 - num9;
			num22 = (ushort)(num + 1);
			num = num22;
			DrawLine(streamWriter, num22, text, num12 + num2, num13 + num3, num12 + num4, num13 + num5);
			num2 = num7 + (double)L - num8;
			num3 = 0.0;
			num4 = num2;
			num5 = num3 + num7;
			num22 = (ushort)(num + 1);
			num = num22;
			DrawLine(streamWriter, num22, text, num12 + num2, num13 + num3, num12 + num4, num13 + num5);
			num3 = num5;
			num4 = num2 + num8;
			num5 += num8;
			num22 = (ushort)(num + 1);
			num = num22;
			DrawLine(streamWriter, num22, text, num12 + num2, num13 + num3, num12 + num4, num13 + num5);
			num23 = num5;
			num2 = num4;
			num3 = num5;
			num4 = num2 + num11;
			num5 += num11;
			num22 = (ushort)(num + 1);
			num = num22;
			DrawLine(streamWriter, num22, text, num12 + num2, num13 + num3, num12 + num4, num13 + num5);
			num24 = num4;
			num25 = Math.Acos(((double)L - c - (double)a) / num18);
			num26 = num11 * Math.Tan(num25);
			num2 = num4;
			num3 = num5;
			num4 = num2;
			num5 += (double)h - num11 - num26;
			num22 = (ushort)(num + 1);
			num = num22;
			DrawLine(streamWriter, num22, text, num12 + num2, num13 + num3, num12 + num4, num13 + num5);
			num2 = num4;
			num3 = num5;
			num4 = num2 - num11;
			num5 += num26;
			num22 = (ushort)(num + 1);
			num = num22;
			DrawLine(streamWriter, num22, text, num12 + num2, num13 + num3, num12 + num4, num13 + num5);
			num = DrawZaklepka_5(streamWriter, num, text, connection, num24 + num12, num23 + num13, num24 + num12, num5 + num13, 0);
			num24 = num4;
			num23 = num5;
			num2 = num4;
			num3 = num5;
			num5 += num11 / Math.Cos(num25);
			num22 = (ushort)(num + 1);
			num = num22;
			DrawLine(streamWriter, num22, text, num12 + num2, num13 + num3, num12 + num4, num13 + num5);
			num2 = num4;
			num3 = num5;
			num4 = num2 - (num18 - num11) * Math.Cos(num25) + num11 * Math.Sin(num25);
			num5 = num3 + (num18 - num11) * Math.Sin(num25) + num11 * Math.Cos(num25) - num11 / Math.Cos(num25);
			num22 = (ushort)(num + 1);
			num = num22;
			DrawLine(streamWriter, num22, text, num12 + num2, num13 + num3, num12 + num4, num13 + num5);
			num2 = num4;
			num3 = num5;
			num4 = num24 - num18 * Math.Cos(num25);
			num5 = num23 + num18 * Math.Sin(num25);
			num22 = (ushort)(num + 1);
			num = num22;
			DrawLine(streamWriter, num22, text, num12 + num2, num13 + num3, num12 + num4, num13 + num5);
			double z4 = (num20 + num21 / 2.0) * num18 / ((double)H - (double)h);
			num = DrawZaklepka_7(streamWriter, num, text, connection, num4 + num11 * Math.Sin(num25) + num12, num5 + num11 * Math.Cos(num25) + num13, num24 + num11 * Math.Sin(num25) + num12, num23 + num11 * Math.Cos(num25) + num13, z4, 1);
			num12 -= (double)(L + 100);
			num13 += (double)(2 * H);
			num2 = 0.0;
			num3 = 0.0;
			num4 = num2;
			num5 = num3 + num7;
			num22 = (ushort)(num + 1);
			num = num22;
			DrawLine(streamWriter, num22, text, num12 + num2, num13 + num3, num12 + num4, num13 + num5);
			num2 = num4;
			num3 = num5;
			num4 = num2 + num6;
			num5 = num3;
			num22 = (ushort)(num + 1);
			num = num22;
			DrawLine(streamWriter, num22, text, num12 + num2, num13 + num3, num12 + num4, num13 + num5);
			num2 = num4;
			num3 = num5;
			num4 = num2;
			num5 = num3 + num6;
			num22 = (ushort)(num + 1);
			num = num22;
			DrawLine(streamWriter, num22, text, num12 + num2, num13 + num3, num12 + num4, num13 + num5);
			num2 = num4;
			num3 = num5;
			num4 = num2 - num6;
			num5 = num3;
			num22 = (ushort)(num + 1);
			num = num22;
			DrawLine(streamWriter, num22, text, num12 + num2, num13 + num3, num12 + num4, num13 + num5);
			num2 = num4;
			num3 = num5;
			num4 = num2;
			num5 = num3 + num8;
			num22 = (ushort)(num + 1);
			num = num22;
			DrawLine(streamWriter, num22, text, num12 + num2, num13 + num3, num12 + num4, num13 + num5);
			num2 = num4;
			num3 = num5;
			num4 = num2 + num6;
			num5 = num3;
			num22 = (ushort)(num + 1);
			num = num22;
			DrawLine(streamWriter, num22, text, num12 + num2, num13 + num3, num12 + num4, num13 + num5);
			num2 = num4;
			num3 = num5;
			num4 = num2;
			num5 = num3 + num6;
			num22 = (ushort)(num + 1);
			num = num22;
			DrawLine(streamWriter, num22, text, num12 + num2, num13 + num3, num12 + num4, num13 + num5);
			num2 = num4;
			num3 = num5;
			num4 = num2 - num6;
			num5 = num3;
			num22 = (ushort)(num + 1);
			num = num22;
			DrawLine(streamWriter, num22, text, num12 + num2, num13 + num3, num12 + num4, num13 + num5);
			num2 = num4;
			num3 = num5;
			num4 = num2;
			num5 = num3 + (double)h;
			num22 = (ushort)(num + 1);
			num = num22;
			DrawLine(streamWriter, num22, text, num12 + num2, num13 + num3, num12 + num4, num13 + num5);
			num = DrawZaklepka_5(streamWriter, num, text, connection, num2 + num12, num3 + num13, num4 + num12, num5 + num13, 1);
			num25 = Math.Acos(c1 / num16);
			num2 = num4;
			num3 = num5;
			num4 = num2 + num16 * Math.Cos(num25);
			num5 = num3 + num16 * Math.Sin(num25);
			num22 = (ushort)(num + 1);
			num = num22;
			DrawLine(streamWriter, num22, text, num12 + num2, num13 + num3, num12 + num4, num13 + num5);
			num = DrawZaklepka_6_2(streamWriter, num, text, connection, num2 + num12, num3 + num13, num4 + num12, num5 + num13, 1);
			num2 = num4;
			num3 = num5;
			num4 = num2;
			num5 = num3 + num9;
			num22 = (ushort)(num + 1);
			num = num22;
			DrawLine(streamWriter, num22, text, num12 + num2, num13 + num3, num12 + num4, num13 + num5);
			num2 = num4;
			num3 = num5;
			num4 = num2 + (double)b;
			num22 = (ushort)(num + 1);
			num = num22;
			DrawLine(streamWriter, num22, text, num12 + num2, num13 + num3, num12 + num4, num13 + num5);
			num2 = num4;
			num3 = num5;
			num4 = num2;
			num5 = num3 - num9;
			num22 = (ushort)(num + 1);
			num = num22;
			DrawLine(streamWriter, num22, text, num12 + num2, num13 + num3, num12 + num4, num13 + num5);
			num2 = 0.0;
			num3 = 0.0;
			if (zhyrFiltr == "так" && implementation1 == "ж/ф внизу зонта (2 ряди)")
			{
				num4 = num2 + ((double)B - num10) / 2.0;
				num5 = num3;
				num22 = (ushort)(num + 1);
				num = num22;
				DrawLine(streamWriter, num22, text, num12 + num2, num13 + num3, num12 + num4, num13 + num5);
				num2 = num4;
				num3 = num5;
				num5 = num3 + num7;
				num22 = (ushort)(num + 1);
				num = num22;
				DrawLine(streamWriter, num22, text, num12 + num2, num13 + num3, num12 + num4, num13 + num5);
				num2 = num4;
				num3 = num5;
				num4 = num2 + num10;
				num22 = (ushort)(num + 1);
				num = num22;
				DrawLine(streamWriter, num22, text, num12 + num2, num13 + num3, num12 + num4, num13 + num5);
				num2 = num4;
				num3 = num5;
				num5 = num3 - num7;
				num22 = (ushort)(num + 1);
				num = num22;
				DrawLine(streamWriter, num22, text, num12 + num2, num13 + num3, num12 + num4, num13 + num5);
				num2 = num4;
				num3 = num5;
				num4 = num2 + ((double)B - num10) / 2.0;
				num5 = num3;
				num22 = (ushort)(num + 1);
				num = num22;
				DrawLine(streamWriter, num22, text, num12 + num2, num13 + num3, num12 + num4, num13 + num5);
			}
			else
			{
				num4 = num2 + (double)B;
				num5 = num3;
				num22 = (ushort)(num + 1);
				num = num22;
				DrawLine(streamWriter, num22, text, num12 + num2, num13 + num3, num12 + num4, num13 + num5);
			}
			num2 = num4;
			num3 = num5;
			num4 = num2;
			num5 = num3 + num7;
			num22 = (ushort)(num + 1);
			num = num22;
			DrawLine(streamWriter, num22, text, num12 + num2, num13 + num3, num12 + num4, num13 + num5);
			num2 = num4;
			num3 = num5;
			num4 = num2 - num6;
			num5 = num3;
			num22 = (ushort)(num + 1);
			num = num22;
			DrawLine(streamWriter, num22, text, num12 + num2, num13 + num3, num12 + num4, num13 + num5);
			num2 = num4;
			num3 = num5;
			num4 = num2;
			num5 = num3 + num6;
			num22 = (ushort)(num + 1);
			num = num22;
			DrawLine(streamWriter, num22, text, num12 + num2, num13 + num3, num12 + num4, num13 + num5);
			num2 = num4;
			num3 = num5;
			num4 = num2 + num6;
			num5 = num3;
			num22 = (ushort)(num + 1);
			num = num22;
			DrawLine(streamWriter, num22, text, num12 + num2, num13 + num3, num12 + num4, num13 + num5);
			num2 = num4;
			num3 = num5;
			num4 = num2;
			num5 = num3 + num8;
			num22 = (ushort)(num + 1);
			num = num22;
			DrawLine(streamWriter, num22, text, num12 + num2, num13 + num3, num12 + num4, num13 + num5);
			num2 = num4;
			num3 = num5;
			num4 = num2 - num6;
			num5 = num3;
			num22 = (ushort)(num + 1);
			num = num22;
			DrawLine(streamWriter, num22, text, num12 + num2, num13 + num3, num12 + num4, num13 + num5);
			num2 = num4;
			num3 = num5;
			num4 = num2;
			num5 = num3 + num6;
			num22 = (ushort)(num + 1);
			num = num22;
			DrawLine(streamWriter, num22, text, num12 + num2, num13 + num3, num12 + num4, num13 + num5);
			num2 = num4;
			num3 = num5;
			num4 = num2 + num6;
			num5 = num3;
			num22 = (ushort)(num + 1);
			num = num22;
			DrawLine(streamWriter, num22, text, num12 + num2, num13 + num3, num12 + num4, num13 + num5);
			num2 = num4;
			num3 = num5;
			num4 = num2;
			num5 = num3 + (double)h;
			num22 = (ushort)(num + 1);
			num = num22;
			DrawLine(streamWriter, num22, text, num12 + num2, num13 + num3, num12 + num4, num13 + num5);
			num = DrawZaklepka_5(streamWriter, num, text, connection, num2 + num12, num3 + num13, num4 + num12, num5 + num13, 0);
			num25 = Math.Acos(((double)B - c1 - (double)b) / num17);
			num2 = num4;
			num3 = num5;
			num4 = num2 - num17 * Math.Cos(num25);
			num5 = num3 + num17 * Math.Sin(num25);
			num22 = (ushort)(num + 1);
			num = num22;
			DrawLine(streamWriter, num22, text, num12 + num2, num13 + num3, num12 + num4, num13 + num5);
			num = DrawZaklepka_7_2(streamWriter, num, text, connection, num4 + num12, num5 + num13, num2 + num12, num3 + num13, 1);
			num12 += (double)(L + 100);
			num2 = 0.0;
			num3 = 0.0;
			num4 = num2;
			num5 = num3 + num7;
			num22 = (ushort)(num + 1);
			num = num22;
			DrawLine(streamWriter, num22, text, num12 + num2, num13 + num3, num12 + num4, num13 + num5);
			num2 = num4;
			num3 = num5;
			num4 = num2 + num6;
			num5 = num3;
			num22 = (ushort)(num + 1);
			num = num22;
			DrawLine(streamWriter, num22, text, num12 + num2, num13 + num3, num12 + num4, num13 + num5);
			num2 = num4;
			num3 = num5;
			num4 = num2;
			num5 = num3 + num6;
			num22 = (ushort)(num + 1);
			num = num22;
			DrawLine(streamWriter, num22, text, num12 + num2, num13 + num3, num12 + num4, num13 + num5);
			num2 = num4;
			num3 = num5;
			num4 = num2 - num6;
			num5 = num3;
			num22 = (ushort)(num + 1);
			num = num22;
			DrawLine(streamWriter, num22, text, num12 + num2, num13 + num3, num12 + num4, num13 + num5);
			num2 = num4;
			num3 = num5;
			num4 = num2;
			num5 = num3 + num8;
			num22 = (ushort)(num + 1);
			num = num22;
			DrawLine(streamWriter, num22, text, num12 + num2, num13 + num3, num12 + num4, num13 + num5);
			num2 = num4;
			num3 = num5;
			num4 = num2 + num6;
			num5 = num3;
			num22 = (ushort)(num + 1);
			num = num22;
			DrawLine(streamWriter, num22, text, num12 + num2, num13 + num3, num12 + num4, num13 + num5);
			num2 = num4;
			num3 = num5;
			num4 = num2;
			num5 = num3 + num6;
			num22 = (ushort)(num + 1);
			num = num22;
			DrawLine(streamWriter, num22, text, num12 + num2, num13 + num3, num12 + num4, num13 + num5);
			num2 = num4;
			num3 = num5;
			num4 = num2 - num6;
			num5 = num3;
			num22 = (ushort)(num + 1);
			num = num22;
			DrawLine(streamWriter, num22, text, num12 + num2, num13 + num3, num12 + num4, num13 + num5);
			num2 = num4;
			num3 = num5;
			num4 = num2;
			num5 = num3 + (double)h;
			num22 = (ushort)(num + 1);
			num = num22;
			DrawLine(streamWriter, num22, text, num12 + num2, num13 + num3, num12 + num4, num13 + num5);
			num = DrawZaklepka_5(streamWriter, num, text, connection, num2 + num12, num3 + num13, num4 + num12, num5 + num13, 1);
			num25 = Math.Acos(c1 / num19);
			num2 = num4;
			num3 = num5;
			num4 = num2 + num19 * Math.Cos(num25);
			num5 = num3 + num19 * Math.Sin(num25);
			num22 = (ushort)(num + 1);
			num = num22;
			DrawLine(streamWriter, num22, text, num12 + num2, num13 + num3, num12 + num4, num13 + num5);
			num = DrawZaklepka_6_2(streamWriter, num, text, connection, num2 + num12, num3 + num13, num4 + num12, num5 + num13, 1);
			num2 = num4;
			num3 = num5;
			num4 = num2;
			num5 = num3 + num9;
			num22 = (ushort)(num + 1);
			num = num22;
			DrawLine(streamWriter, num22, text, num12 + num2, num13 + num3, num12 + num4, num13 + num5);
			num2 = num4;
			num3 = num5;
			num4 = num2 + (double)b;
			num22 = (ushort)(num + 1);
			num = num22;
			DrawLine(streamWriter, num22, text, num12 + num2, num13 + num3, num12 + num4, num13 + num5);
			num2 = num4;
			num3 = num5;
			num4 = num2;
			num5 = num3 - num9;
			num22 = (ushort)(num + 1);
			num = num22;
			DrawLine(streamWriter, num22, text, num12 + num2, num13 + num3, num12 + num4, num13 + num5);
			num2 = 0.0;
			num3 = 0.0;
			if (zhyrFiltr == "так" && implementation1 == "ж/ф внизу зонта (2 ряди)")
			{
				num4 = num2 + ((double)B - num10) / 2.0;
				num5 = num3;
				num22 = (ushort)(num + 1);
				num = num22;
				DrawLine(streamWriter, num22, text, num12 + num2, num13 + num3, num12 + num4, num13 + num5);
				num2 = num4;
				num3 = num5;
				num5 = num3 + num7;
				num22 = (ushort)(num + 1);
				num = num22;
				DrawLine(streamWriter, num22, text, num12 + num2, num13 + num3, num12 + num4, num13 + num5);
				num2 = num4;
				num3 = num5;
				num4 = num2 + num10;
				num22 = (ushort)(num + 1);
				num = num22;
				DrawLine(streamWriter, num22, text, num12 + num2, num13 + num3, num12 + num4, num13 + num5);
				num2 = num4;
				num3 = num5;
				num5 = num3 - num7;
				num22 = (ushort)(num + 1);
				num = num22;
				DrawLine(streamWriter, num22, text, num12 + num2, num13 + num3, num12 + num4, num13 + num5);
				num2 = num4;
				num3 = num5;
				num4 = num2 + ((double)B - num10) / 2.0;
				num5 = num3;
				num22 = (ushort)(num + 1);
				num = num22;
				DrawLine(streamWriter, num22, text, num12 + num2, num13 + num3, num12 + num4, num13 + num5);
			}
			else
			{
				num4 = num2 + (double)B;
				num5 = num3;
				num22 = (ushort)(num + 1);
				num = num22;
				DrawLine(streamWriter, num22, text, num12 + num2, num13 + num3, num12 + num4, num13 + num5);
			}
			num2 = num4;
			num3 = num5;
			num4 = num2;
			num5 = num3 + num7;
			num22 = (ushort)(num + 1);
			num = num22;
			DrawLine(streamWriter, num22, text, num12 + num2, num13 + num3, num12 + num4, num13 + num5);
			num2 = num4;
			num3 = num5;
			num4 = num2 - num6;
			num5 = num3;
			num22 = (ushort)(num + 1);
			num = num22;
			DrawLine(streamWriter, num22, text, num12 + num2, num13 + num3, num12 + num4, num13 + num5);
			num2 = num4;
			num3 = num5;
			num4 = num2;
			num5 = num3 + num6;
			num22 = (ushort)(num + 1);
			num = num22;
			DrawLine(streamWriter, num22, text, num12 + num2, num13 + num3, num12 + num4, num13 + num5);
			num2 = num4;
			num3 = num5;
			num4 = num2 + num6;
			num5 = num3;
			num22 = (ushort)(num + 1);
			num = num22;
			DrawLine(streamWriter, num22, text, num12 + num2, num13 + num3, num12 + num4, num13 + num5);
			num2 = num4;
			num3 = num5;
			num4 = num2;
			num5 = num3 + num8;
			num22 = (ushort)(num + 1);
			num = num22;
			DrawLine(streamWriter, num22, text, num12 + num2, num13 + num3, num12 + num4, num13 + num5);
			num2 = num4;
			num3 = num5;
			num4 = num2 - num6;
			num5 = num3;
			num22 = (ushort)(num + 1);
			num = num22;
			DrawLine(streamWriter, num22, text, num12 + num2, num13 + num3, num12 + num4, num13 + num5);
			num2 = num4;
			num3 = num5;
			num4 = num2;
			num5 = num3 + num6;
			num22 = (ushort)(num + 1);
			num = num22;
			DrawLine(streamWriter, num22, text, num12 + num2, num13 + num3, num12 + num4, num13 + num5);
			num2 = num4;
			num3 = num5;
			num4 = num2 + num6;
			num5 = num3;
			num22 = (ushort)(num + 1);
			num = num22;
			DrawLine(streamWriter, num22, text, num12 + num2, num13 + num3, num12 + num4, num13 + num5);
			num2 = num4;
			num3 = num5;
			num4 = num2;
			num5 = num3 + (double)h;
			num22 = (ushort)(num + 1);
			num = num22;
			DrawLine(streamWriter, num22, text, num12 + num2, num13 + num3, num12 + num4, num13 + num5);
			num = DrawZaklepka_5(streamWriter, num, text, connection, num2 + num12, num3 + num13, num4 + num12, num5 + num13, 0);
			num25 = Math.Acos(((double)B - c1 - (double)b) / num18);
			num2 = num4;
			num3 = num5;
			num4 = num2 - num18 * Math.Cos(num25);
			num5 = num3 + num18 * Math.Sin(num25);
			num22 = (ushort)(num + 1);
			num = num22;
			DrawLine(streamWriter, num22, text, num12 + num2, num13 + num3, num12 + num4, num13 + num5);
			num = DrawZaklepka_7_2(streamWriter, num, text, connection, num4 + num12, num5 + num13, num2 + num12, num3 + num13, 1);
			if (zhyrFiltr == "так")
			{
				if (implementation1 == "ж/ф внизу зонта (2 ряди)")
				{
					num12 = L + B + 1000;
					num13 = a + 300;
					double num29 = 54.5;
					double num30 = 15.0;
					num2 = 0.0;
					num3 = 0.0;
					num4 = num2;
					num5 = num3 + num30;
					num22 = (ushort)(num + 1);
					num = num22;
					DrawLine(streamWriter, num22, text, num12 + num2, num13 + num3, num12 + num4, num13 + num5);
					num2 = num4;
					num3 = num5;
					num4 = num2 + num6;
					num5 = num3;
					num22 = (ushort)(num + 1);
					num = num22;
					DrawLine(streamWriter, num22, text, num12 + num2, num13 + num3, num12 + num4, num13 + num5);
					num2 = num4;
					num3 = num5;
					num4 = num2;
					num5 = num3 + num6;
					num22 = (ushort)(num + 1);
					num = num22;
					DrawLine(streamWriter, num22, text, num12 + num2, num13 + num3, num12 + num4, num13 + num5);
					num2 = num4;
					num3 = num5;
					num4 = num2 - num6;
					num5 = num3;
					num22 = (ushort)(num + 1);
					num = num22;
					DrawLine(streamWriter, num22, text, num12 + num2, num13 + num3, num12 + num4, num13 + num5);
					num2 = num4;
					num3 = num5;
					num4 = num2;
					num5 = num3 + num29;
					num22 = (ushort)(num + 1);
					num = num22;
					DrawLine(streamWriter, num22, text, num12 + num2, num13 + num3, num12 + num4, num13 + num5);
					num2 = num4;
					num3 = num5;
					num4 = num2 + (double)(L - 10);
					num5 = num3;
					num22 = (ushort)(num + 1);
					num = num22;
					DrawLine(streamWriter, num22, text, num12 + num2, num13 + num3, num12 + num4, num13 + num5);
					num2 = num4;
					num3 = num5;
					num4 = num2;
					num5 = num3 - num29;
					num22 = (ushort)(num + 1);
					num = num22;
					DrawLine(streamWriter, num22, text, num12 + num2, num13 + num3, num12 + num4, num13 + num5);
					num2 = num4;
					num3 = num5;
					num4 = num2 - num6;
					num5 = num3;
					num22 = (ushort)(num + 1);
					num = num22;
					DrawLine(streamWriter, num22, text, num12 + num2, num13 + num3, num12 + num4, num13 + num5);
					num2 = num4;
					num3 = num5;
					num4 = num2;
					num5 = num3 - num6;
					num22 = (ushort)(num + 1);
					num = num22;
					DrawLine(streamWriter, num22, text, num12 + num2, num13 + num3, num12 + num4, num13 + num5);
					num2 = num4;
					num3 = num5;
					num4 = num2 + num6;
					num5 = num3;
					num22 = (ushort)(num + 1);
					num = num22;
					DrawLine(streamWriter, num22, text, num12 + num2, num13 + num3, num12 + num4, num13 + num5);
					num2 = num4;
					num3 = num5;
					num4 = num2;
					num5 = num3 - num30;
					num22 = (ushort)(num + 1);
					num = num22;
					DrawLine(streamWriter, num22, text, num12 + num2, num13 + num3, num12 + num4, num13 + num5);
					if (zlyv == "ні")
					{
						num2 = num4;
						num3 = num5;
						num4 = num2 - (double)(L - 10);
						num5 = num3;
						num22 = (ushort)(num + 1);
						num = num22;
						DrawLine(streamWriter, num22, text, num12 + num2, num13 + num3, num12 + num4, num13 + num5);
					}
					else
					{
						double num31 = 12.5;
						double num32 = 10.5;
						double num33 = 72.5;
						num2 = num4 - (double)(L - 10);
						num3 = num5;
						num4 = num2 + num33 - num31;
						num5 = num3;
						num22 = (ushort)(num + 1);
						num = num22;
						DrawLine(streamWriter, num22, text, num12 + num2, num13 + num3, num12 + num4, num13 + num5);
						double num34 = num4;
						double num35 = num5;
						double num36 = 15.0;
						double num37 = 16.0;
						double num38 = 40.0;
						double num39 = 7.0;
						num2 += num36;
						num3 += num37;
						num4 = num2;
						num5 = num3 + num39;
						num22 = (ushort)(num + 1);
						num = num22;
						DrawLine(streamWriter, num22, text, num12 + num2, num13 + num3, num12 + num4, num13 + num5);
						num2 = num4;
						num3 = num5;
						num4 = num2 + num38;
						num5 = num3;
						num22 = (ushort)(num + 1);
						num = num22;
						DrawLine(streamWriter, num22, text, num12 + num2, num13 + num3, num12 + num4, num13 + num5);
						num2 = num4;
						num3 = num5;
						num4 = num2;
						num5 = num3 - num39;
						num22 = (ushort)(num + 1);
						num = num22;
						DrawLine(streamWriter, num22, text, num12 + num2, num13 + num3, num12 + num4, num13 + num5);
						num2 = num4;
						num3 = num5;
						num4 = num2 - num38;
						num5 = num3;
						num22 = (ushort)(num + 1);
						num = num22;
						DrawLine(streamWriter, num22, text, num12 + num2, num13 + num3, num12 + num4, num13 + num5);
						num2 = num34;
						num3 = num35;
						num4 = num2;
						num5 = num3 + num32 + num31;
						num22 = (ushort)(num + 1);
						num = num22;
						DrawLine(streamWriter, num22, text, num12 + num2, num13 + num3, num12 + num4, num13 + num5);
						num2 = num4;
						num3 = num5;
						num4 = num2 + 2.0 * num31;
						num5 = num3;
						num22 = (ushort)(num + 1);
						num = num22;
						DrawLine(streamWriter, num22, text, num12 + num2, num13 + num3, num12 + num4, num13 + num5);
						num2 = num4;
						num3 = num5;
						num4 = num2;
						num5 = num3 - (num32 + num31);
						num22 = (ushort)(num + 1);
						num = num22;
						DrawLine(streamWriter, num22, text, num12 + num2, num13 + num3, num12 + num4, num13 + num5);
						num34 = num4;
						num35 = num5;
						double num40 = 34.0;
						num36 = num4 + 5.0;
						num37 += num5;
						int num41 = (int)Math.Floor(((double)(L - 10) - num36) / (num40 + num38));
						for (int j = 0; j < num41; j++)
						{
							num2 = num36 + (double)j * (num40 + num38);
							num3 = num37;
							num4 = num2;
							num5 = num3 + num39;
							num22 = (ushort)(num + 1);
							num = num22;
							DrawLine(streamWriter, num22, text, num12 + num2, num13 + num3, num12 + num4, num13 + num5);
							num2 = num4;
							num3 = num5;
							num4 = num2 + num38;
							num5 = num3;
							num22 = (ushort)(num + 1);
							num = num22;
							DrawLine(streamWriter, num22, text, num12 + num2, num13 + num3, num12 + num4, num13 + num5);
							num2 = num4;
							num3 = num5;
							num4 = num2;
							num5 = num3 - num39;
							num22 = (ushort)(num + 1);
							num = num22;
							DrawLine(streamWriter, num22, text, num12 + num2, num13 + num3, num12 + num4, num13 + num5);
							num2 = num4;
							num3 = num5;
							num4 = num2 - num38;
							num5 = num3;
							num22 = (ushort)(num + 1);
							num = num22;
							DrawLine(streamWriter, num22, text, num12 + num2, num13 + num3, num12 + num4, num13 + num5);
						}
						num2 = num34;
						num3 = num35;
						num4 = num2 + (double)L - 10.0 - (num33 + num31);
						num5 = num3;
						num22 = (ushort)(num + 1);
						num = num22;
						DrawLine(streamWriter, num22, text, num12 + num2, num13 + num3, num12 + num4, num13 + num5);
					}
					num29 = 24.5;
					num30 = 109.0;
					num12 = L + B + 1000;
					num13 = a + 300 + 300;
					num2 = 0.0;
					num3 = 0.0;
					num4 = num2;
					num5 = num3 + num29;
					num22 = (ushort)(num + 1);
					num = num22;
					DrawLine(streamWriter, num22, text, num12 + num2, num13 + num3, num12 + num4, num13 + num5);
					num2 = num4;
					num3 = num5;
					num4 = num2 + num6;
					num5 = num3;
					num22 = (ushort)(num + 1);
					num = num22;
					DrawLine(streamWriter, num22, text, num12 + num2, num13 + num3, num12 + num4, num13 + num5);
					num2 = num4;
					num3 = num5;
					num4 = num2;
					num5 = num3 + num6;
					num22 = (ushort)(num + 1);
					num = num22;
					DrawLine(streamWriter, num22, text, num12 + num2, num13 + num3, num12 + num4, num13 + num5);
					num2 = num4;
					num3 = num5;
					num4 = num2 - num6;
					num5 = num3;
					num22 = (ushort)(num + 1);
					num = num22;
					DrawLine(streamWriter, num22, text, num12 + num2, num13 + num3, num12 + num4, num13 + num5);
					num2 = num4;
					num3 = num5;
					num4 = num2;
					num5 = num3 + num30;
					num22 = (ushort)(num + 1);
					num = num22;
					DrawLine(streamWriter, num22, text, num12 + num2, num13 + num3, num12 + num4, num13 + num5);
					num = DrawZaklepka_Top_2(streamWriter, num, text, connection, num2 + num12, num3 + num13, num4 + num12, num5 + num13, 1);
					num2 = num4;
					num3 = num5;
					num4 = num2 + num6;
					num5 = num3;
					num22 = (ushort)(num + 1);
					num = num22;
					DrawLine(streamWriter, num22, text, num12 + num2, num13 + num3, num12 + num4, num13 + num5);
					num2 = num4;
					num3 = num5;
					num4 = num2;
					num5 = num3 + num6;
					num22 = (ushort)(num + 1);
					num = num22;
					DrawLine(streamWriter, num22, text, num12 + num2, num13 + num3, num12 + num4, num13 + num5);
					num2 = num4;
					num3 = num5;
					num4 = num2 - num6;
					num5 = num3;
					num22 = (ushort)(num + 1);
					num = num22;
					DrawLine(streamWriter, num22, text, num12 + num2, num13 + num3, num12 + num4, num13 + num5);
					num2 = num4;
					num3 = num5;
					num4 = num2;
					num5 = num3 + num29;
					num22 = (ushort)(num + 1);
					num = num22;
					DrawLine(streamWriter, num22, text, num12 + num2, num13 + num3, num12 + num4, num13 + num5);
					num2 = num4;
					num3 = num5;
					num4 = num2 + (double)L - 5.0;
					num5 = num3;
					num22 = (ushort)(num + 1);
					num = num22;
					DrawLine(streamWriter, num22, text, num12 + num2, num13 + num3, num12 + num4, num13 + num5);
					num2 = num4;
					num3 = num5;
					num4 = num2;
					num5 = num3 - num29;
					num22 = (ushort)(num + 1);
					num = num22;
					DrawLine(streamWriter, num22, text, num12 + num2, num13 + num3, num12 + num4, num13 + num5);
					num2 = num4;
					num3 = num5;
					num4 = num2 - num6;
					num5 = num3;
					num22 = (ushort)(num + 1);
					num = num22;
					DrawLine(streamWriter, num22, text, num12 + num2, num13 + num3, num12 + num4, num13 + num5);
					num2 = num4;
					num3 = num5;
					num4 = num2;
					num5 = num3 - num6;
					num22 = (ushort)(num + 1);
					num = num22;
					DrawLine(streamWriter, num22, text, num12 + num2, num13 + num3, num12 + num4, num13 + num5);
					num2 = num4;
					num3 = num5;
					num4 = num2 + num6;
					num5 = num3;
					num22 = (ushort)(num + 1);
					num = num22;
					DrawLine(streamWriter, num22, text, num12 + num2, num13 + num3, num12 + num4, num13 + num5);
					num2 = num4;
					num3 = num5;
					num4 = num2;
					num5 = num3 - num30;
					num22 = (ushort)(num + 1);
					num = num22;
					DrawLine(streamWriter, num22, text, num12 + num2, num13 + num3, num12 + num4, num13 + num5);
					num = DrawZaklepka_Top_2(streamWriter, num, text, connection, num2 + num12, num3 + num13, num4 + num12, num5 + num13, 1);
					num2 = num4;
					num3 = num5;
					num4 = num2 - num6;
					num5 = num3;
					num22 = (ushort)(num + 1);
					num = num22;
					DrawLine(streamWriter, num22, text, num12 + num2, num13 + num3, num12 + num4, num13 + num5);
					num2 = num4;
					num3 = num5;
					num4 = num2;
					num5 = num3 - num6;
					num22 = (ushort)(num + 1);
					num = num22;
					DrawLine(streamWriter, num22, text, num12 + num2, num13 + num3, num12 + num4, num13 + num5);
					num2 = num4;
					num3 = num5;
					num4 = num2 + num6;
					num5 = num3;
					num22 = (ushort)(num + 1);
					num = num22;
					DrawLine(streamWriter, num22, text, num12 + num2, num13 + num3, num12 + num4, num13 + num5);
					num2 = num4;
					num3 = num5;
					num4 = num2;
					num5 = num3 - num29;
					num22 = (ushort)(num + 1);
					num = num22;
					DrawLine(streamWriter, num22, text, num12 + num2, num13 + num3, num12 + num4, num13 + num5);
					if (zhyrFiltr == "так" && zlyv != "ні")
					{
						double num42 = 75.0;
						double num43 = 80.0;
						double num44 = 16.0;
						num2 = ((zlyv == "так, трубка справа") ? (num4 - num42) : (num4 - (double)(L - 5) + num42));
						num3 = num5 + num43;
						num22 = (ushort)(num + 1);
						num = num22;
						DrawCircle(streamWriter, num22, text, num12 + num2, num13 + num3, num44 / 2.0);
					}
					num2 = num4;
					num3 = num5;
					num4 = num2 - (double)(L - 5);
					num5 = num3;
					num22 = (ushort)(num + 1);
					num = num22;
					DrawLine(streamWriter, num22, text, num12 + num2, num13 + num3, num12 + num4, num13 + num5);
				}
				else
				{
					num12 = L + B + 1000;
					num13 = a + 300;
					double num45 = 9.5;
					double num46 = 59.0;
					double num47 = 64.5;
					double num48 = 17.0;
					double num49 = 20.0;
					double num50 = 70.0;
					double d = 2.65;
					num2 = (double)l + num50;
					num3 = 0.0;
					num4 = num2 - ((double)l + num50);
					num5 = num3;
					num22 = (ushort)(num + 1);
					num = num22;
					DrawLine(streamWriter, num22, text, num12 + num2, num13 + num3, num12 + num4, num13 + num5);
					num2 = num4;
					num3 = num5;
					num5 = num3 + num45;
					num22 = (ushort)(num + 1);
					num = num22;
					DrawLine(streamWriter, num22, text, num12 + num2, num13 + num3, num12 + num4, num13 + num5);
					num2 = num4;
					num3 = num5;
					num4 = num2 + num6;
					num5 = num3;
					num22 = (ushort)(num + 1);
					num = num22;
					DrawLine(streamWriter, num22, text, num12 + num2, num13 + num3, num12 + num4, num13 + num5);
					num2 = num4;
					num3 = num5;
					num4 = num2;
					num5 = num3 + num6;
					num22 = (ushort)(num + 1);
					num = num22;
					DrawLine(streamWriter, num22, text, num12 + num2, num13 + num3, num12 + num4, num13 + num5);
					num2 = num4;
					num3 = num5;
					num4 = num2 - num6;
					num5 = num3;
					num22 = (ushort)(num + 1);
					num = num22;
					DrawLine(streamWriter, num22, text, num12 + num2, num13 + num3, num12 + num4, num13 + num5);
					num2 = num4;
					num3 = num5;
					num5 = num3 + num46;
					num22 = (ushort)(num + 1);
					num = num22;
					DrawLine(streamWriter, num22, text, num12 + num2, num13 + num3, num12 + num4, num13 + num5);
					num22 = (ushort)(num + 1);
					num = num22;
					DrawCircle(streamWriter, num22, text, num12 + num4 + 50.65, num13 + num5 - 39.5, d);
					num2 = num4;
					num3 = num5;
					num4 = num2 + num6;
					num5 = num3;
					num22 = (ushort)(num + 1);
					num = num22;
					DrawLine(streamWriter, num22, text, num12 + num2, num13 + num3, num12 + num4, num13 + num5);
					num2 = num4;
					num3 = num5;
					num4 = num2;
					num5 = num3 + num6;
					num22 = (ushort)(num + 1);
					num = num22;
					DrawLine(streamWriter, num22, text, num12 + num2, num13 + num3, num12 + num4, num13 + num5);
					num2 = num4;
					num3 = num5;
					num4 = num2 - num6;
					num5 = num3;
					num22 = (ushort)(num + 1);
					num = num22;
					DrawLine(streamWriter, num22, text, num12 + num2, num13 + num3, num12 + num4, num13 + num5);
					num22 = (ushort)(num + 1);
					num = num22;
					DrawCircle(streamWriter, num22, text, num12 + num4 + 7.0, num13 + num5 + 15.75, d);
					num22 = (ushort)(num + 1);
					num = num22;
					DrawCircle(streamWriter, num22, text, num12 + num4 + 7.0, num13 + num5 + 15.75 + 32.5, d);
					num2 = num4;
					num3 = num5;
					num5 = num3 + num47;
					num22 = (ushort)(num + 1);
					num = num22;
					DrawLine(streamWriter, num22, text, num12 + num2, num13 + num3, num12 + num4, num13 + num5);
					num2 = num4;
					num3 = num5;
					num4 = num2 + num48;
					num22 = (ushort)(num + 1);
					num = num22;
					DrawLine(streamWriter, num22, text, num12 + num2, num13 + num3, num12 + num4, num13 + num5);
					num2 = num4;
					num3 = num5;
					num4 = num2 + num49 / Math.Tan(Math.PI / 6.0);
					num5 = num3 + num49;
					num22 = (ushort)(num + 1);
					num = num22;
					DrawLine(streamWriter, num22, text, num12 + num2, num13 + num3, num12 + num4, num13 + num5);
					num22 = (ushort)(num + 1);
					num = num22;
					DrawCircle(streamWriter, num22, text, num12 + num2 + 35.0, num13 + num5 - 10.0, d);
					double num51 = num2 + 35.0;
					num2 = num4;
					num3 = num5;
					num4 = num2 + (double)l + num50 - 2.0 * (num49 / Math.Tan(Math.PI / 6.0) + num48);
					num22 = (ushort)(num + 1);
					num = num22;
					DrawLine(streamWriter, num22, text, num12 + num2, num13 + num3, num12 + num4, num13 + num5);
					num22 = (ushort)(num + 1);
					num = num22;
					DrawCircle(streamWriter, num22, text, num12 + num2 + ((double)l + num50 - 2.0 * (num49 / Math.Tan(Math.PI / 6.0) + num48)) / 2.0, num13 + num5 - 10.0, d);
					num51 = num2 + ((double)l + num50 - 2.0 * (num49 / Math.Tan(Math.PI / 6.0) + num48)) / 2.0 - num51;
					num22 = (ushort)(num + 1);
					num = num22;
					DrawCircle(streamWriter, num22, text, num27 - num51, p2, 2.65);
					num22 = (ushort)(num + 1);
					num = num22;
					DrawCircle(streamWriter, num22, text, num27 + num51, p2, 2.65);
					num2 = num4;
					num3 = num5;
					num4 = num2 + num49 / Math.Tan(Math.PI / 6.0);
					num5 = num3 - num49;
					num22 = (ushort)(num + 1);
					num = num22;
					DrawLine(streamWriter, num22, text, num12 + num2, num13 + num3, num12 + num4, num13 + num5);
					num22 = (ushort)(num + 1);
					num = num22;
					DrawCircle(streamWriter, num22, text, num12 + num4 - 35.0, num13 + num3 - 10.0, d);
					num2 = num4;
					num3 = num5;
					num4 = num2 + num48;
					num22 = (ushort)(num + 1);
					num = num22;
					DrawLine(streamWriter, num22, text, num12 + num2, num13 + num3, num12 + num4, num13 + num5);
					num2 = num4;
					num3 = num5;
					num5 = num3 - num47;
					num22 = (ushort)(num + 1);
					num = num22;
					DrawLine(streamWriter, num22, text, num12 + num2, num13 + num3, num12 + num4, num13 + num5);
					num22 = (ushort)(num + 1);
					num = num22;
					DrawCircle(streamWriter, num22, text, num12 + num4 - 7.0, num13 + num5 + 15.75, d);
					num22 = (ushort)(num + 1);
					num = num22;
					DrawCircle(streamWriter, num22, text, num12 + num4 - 7.0, num13 + num5 + 15.75 + 32.5, d);
					num2 = num4;
					num3 = num5;
					num4 = num2 - num6;
					num5 = num3;
					num22 = (ushort)(num + 1);
					num = num22;
					DrawLine(streamWriter, num22, text, num12 + num2, num13 + num3, num12 + num4, num13 + num5);
					num2 = num4;
					num3 = num5;
					num4 = num2;
					num5 = num3 - num6;
					num22 = (ushort)(num + 1);
					num = num22;
					DrawLine(streamWriter, num22, text, num12 + num2, num13 + num3, num12 + num4, num13 + num5);
					num2 = num4;
					num3 = num5;
					num4 = num2 + num6;
					num5 = num3;
					num22 = (ushort)(num + 1);
					num = num22;
					DrawLine(streamWriter, num22, text, num12 + num2, num13 + num3, num12 + num4, num13 + num5);
					num2 = num4;
					num3 = num5;
					num5 = num3 - num46;
					num22 = (ushort)(num + 1);
					num = num22;
					DrawLine(streamWriter, num22, text, num12 + num2, num13 + num3, num12 + num4, num13 + num5);
					num2 = num4;
					num3 = num5;
					num4 = num2 - num6;
					num5 = num3;
					num22 = (ushort)(num + 1);
					num = num22;
					DrawLine(streamWriter, num22, text, num12 + num2, num13 + num3, num12 + num4, num13 + num5);
					num2 = num4;
					num3 = num5;
					num4 = num2;
					num5 = num3 - num6;
					num22 = (ushort)(num + 1);
					num = num22;
					DrawLine(streamWriter, num22, text, num12 + num2, num13 + num3, num12 + num4, num13 + num5);
					num2 = num4;
					num3 = num5;
					num4 = num2 + num6;
					num5 = num3;
					num22 = (ushort)(num + 1);
					num = num22;
					DrawLine(streamWriter, num22, text, num12 + num2, num13 + num3, num12 + num4, num13 + num5);
					num2 = num4;
					num3 = num5;
					num5 = num3 - num45;
					num22 = (ushort)(num + 1);
					num = num22;
					DrawLine(streamWriter, num22, text, num12 + num2, num13 + num3, num12 + num4, num13 + num5);
					num22 = (ushort)(num + 1);
					num = num22;
					DrawCircle(streamWriter, num22, text, num12 + num4 - 50.65, num13 + num5 + 30.0, d);
					num12 = L + B + 1000;
					num13 = a + 600;
					double num52 = 20.0;
					double num53 = 60.0 - num6 * Math.Cos(Math.PI / 4.0) / 2.0;
					double num54 = 15.0;
					double num55 = 35.0;
					num2 = kk - num53 - num6 * Math.Cos(Math.PI / 4.0) / 2.0;
					num3 = 0.0;
					num4 = num53 + num6 * Math.Cos(Math.PI / 4.0) / 2.0;
					num5 = num3;
					num22 = (ushort)(num + 1);
					num = num22;
					DrawLine(streamWriter, num22, text, num12 + num2, num13 + num3, num12 + num4, num13 + num5);
					num2 = num4;
					num3 = num5;
					num4 = num2;
					num5 = num3 + num52;
					num22 = (ushort)(num + 1);
					num = num22;
					DrawLine(streamWriter, num22, text, num12 + num2, num13 + num3, num12 + num4, num13 + num5);
					num2 = num4;
					num3 = num5;
					num4 = num2 - num53;
					num5 = num3 + num53;
					num22 = (ushort)(num + 1);
					num = num22;
					DrawLine(streamWriter, num22, text, num12 + num2, num13 + num3, num12 + num4, num13 + num5);
					num22 = (ushort)(num + 1);
					num = num22;
					DrawCircle(streamWriter, num22, text, num12 + num4 - num6 * Math.Cos(Math.PI / 4.0) / 2.0 + 40.0 + 7.0 / Math.Cos(Math.PI / 4.0), num13 + num5 + num6 * Math.Cos(Math.PI / 4.0) / 2.0 - 40.0, d);
					num2 = num4;
					num3 = num5;
					num4 = num2 + num6 * Math.Cos(Math.PI / 4.0);
					num5 = num3 + num6 * Math.Sin(Math.PI / 4.0);
					num22 = (ushort)(num + 1);
					num = num22;
					DrawLine(streamWriter, num22, text, num12 + num2, num13 + num3, num12 + num4, num13 + num5);
					num2 = num4;
					num3 = num5;
					num4 = num2 - num6 * Math.Cos(Math.PI / 4.0);
					num5 = num3 + num6 * Math.Sin(Math.PI / 4.0);
					num22 = (ushort)(num + 1);
					num = num22;
					DrawLine(streamWriter, num22, text, num12 + num2, num13 + num3, num12 + num4, num13 + num5);
					num2 = num4;
					num3 = num5;
					num4 = num2 - num6 * Math.Cos(Math.PI / 4.0);
					num5 = num3 - num6 * Math.Sin(Math.PI / 4.0);
					num22 = (ushort)(num + 1);
					num = num22;
					DrawLine(streamWriter, num22, text, num12 + num2, num13 + num3, num12 + num4, num13 + num5);
					num2 = num4;
					num3 = num5;
					num4 = num2 - (num54 - num6 * Math.Cos(Math.PI / 4.0) / 2.0);
					num5 = num3 + (num54 - num6 * Math.Cos(Math.PI / 4.0) / 2.0);
					num22 = (ushort)(num + 1);
					num = num22;
					DrawLine(streamWriter, num22, text, num12 + num2, num13 + num3, num12 + num4, num13 + num5);
					num2 = num4;
					num3 = num5;
					num4 = num2;
					num5 = num3 + num55;
					num22 = (ushort)(num + 1);
					num = num22;
					DrawLine(streamWriter, num22, text, num12 + num2, num13 + num3, num12 + num4, num13 + num5);
					num22 = (ushort)(num + 1);
					num = num22;
					DrawCircle(streamWriter, num22, text, num12 + num2 + 8.0, num13 + num3 + (num55 - 32.5) / 2.0, d);
					num22 = (ushort)(num + 1);
					num = num22;
					DrawCircle(streamWriter, num22, text, num12 + num2 + 8.0, num13 + num3 + (num55 + 32.5) / 2.0, d);
					num2 = num4;
					num3 = num5;
					num4 = num2 + num54;
					num5 = num3 + num54;
					num22 = (ushort)(num + 1);
					num = num22;
					DrawLine(streamWriter, num22, text, num12 + num2, num13 + num3, num12 + num4, num13 + num5);
					num2 = num4;
					num3 = num5;
					num4 = num2 + kk;
					num5 = num3;
					num22 = (ushort)(num + 1);
					num = num22;
					DrawLine(streamWriter, num22, text, num12 + num2, num13 + num3, num12 + num4, num13 + num5);
					num2 = num4;
					num3 = num5;
					num4 = num2 + num54;
					num5 = num3 - num54;
					num22 = (ushort)(num + 1);
					num = num22;
					DrawLine(streamWriter, num22, text, num12 + num2, num13 + num3, num12 + num4, num13 + num5);
					num2 = num4;
					num3 = num5;
					num4 = num2;
					num5 = num3 - num55;
					num22 = (ushort)(num + 1);
					num = num22;
					DrawLine(streamWriter, num22, text, num12 + num2, num13 + num3, num12 + num4, num13 + num5);
					num22 = (ushort)(num + 1);
					num = num22;
					DrawCircle(streamWriter, num22, text, num12 + num4 - 8.0, num13 + num5 + (num55 - 32.5) / 2.0, d);
					num22 = (ushort)(num + 1);
					num = num22;
					DrawCircle(streamWriter, num22, text, num12 + num4 - 8.0, num13 + num5 + (num55 + 32.5) / 2.0, d);
					num2 = num4;
					num3 = num5;
					num4 = num2 - (num54 - num6 * Math.Cos(Math.PI / 4.0) / 2.0);
					num5 = num3 - (num54 - num6 * Math.Cos(Math.PI / 4.0) / 2.0);
					num22 = (ushort)(num + 1);
					num = num22;
					DrawLine(streamWriter, num22, text, num12 + num2, num13 + num3, num12 + num4, num13 + num5);
					num2 = num4;
					num3 = num5;
					num4 = num2 - num6 * Math.Cos(Math.PI / 4.0);
					num5 = num3 + num6 * Math.Sin(Math.PI / 4.0);
					num22 = (ushort)(num + 1);
					num = num22;
					DrawLine(streamWriter, num22, text, num12 + num2, num13 + num3, num12 + num4, num13 + num5);
					num2 = num4;
					num3 = num5;
					num4 = num2 - num6 * Math.Cos(Math.PI / 4.0);
					num5 = num3 - num6 * Math.Sin(Math.PI / 4.0);
					num22 = (ushort)(num + 1);
					num = num22;
					DrawLine(streamWriter, num22, text, num12 + num2, num13 + num3, num12 + num4, num13 + num5);
					num2 = num4;
					num3 = num5;
					num4 = num2 + num6 * Math.Cos(Math.PI / 4.0);
					num5 = num3 - num6 * Math.Sin(Math.PI / 4.0);
					num22 = (ushort)(num + 1);
					num = num22;
					DrawLine(streamWriter, num22, text, num12 + num2, num13 + num3, num12 + num4, num13 + num5);
					num22 = (ushort)(num + 1);
					num = num22;
					DrawCircle(streamWriter, num22, text, num12 + num4 + num6 * Math.Cos(Math.PI / 4.0) / 2.0 - 40.0 - 7.0 / Math.Cos(Math.PI / 4.0), num13 + num5 + num6 * Math.Cos(Math.PI / 4.0) / 2.0 - 40.0, d);
					num2 = num4;
					num3 = num5;
					num4 = num2 - num53;
					num5 = num3 - num53;
					num22 = (ushort)(num + 1);
					num = num22;
					DrawLine(streamWriter, num22, text, num12 + num2, num13 + num3, num12 + num4, num13 + num5);
					num2 = num4;
					num3 = num5;
					num4 = num2;
					num5 = num3 - num52;
					num22 = (ushort)(num + 1);
					num = num22;
					DrawLine(streamWriter, num22, text, num12 + num2, num13 + num3, num12 + num4, num13 + num5);
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

	public static ushort DrawZaklepka_6(StreamWriter sw, ushort ii, string Layer_Name, string connection, double x1, double y1, double x2, double y2, double z11, byte leftRight)
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
			double num12 = z11 * Math.Cos(num7);
			double num13 = z11 * Math.Sin(num7);
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

	public static ushort DrawZaklepka_6_1(StreamWriter sw, ushort ii, string Layer_Name, string connection, double x1, double y1, double x2, double y2, double z11, byte leftRight)
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
			double num12 = z11 * Math.Cos(num7);
			double num13 = z11 * Math.Sin(num7);
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

	public static ushort DrawZaklepka_6_2(StreamWriter sw, ushort ii, string Layer_Name, string connection, double x1, double y1, double x2, double y2, byte leftRight)
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

	public static ushort DrawZaklepka_7_1(StreamWriter sw, ushort ii, string Layer_Name, string connection, double x1, double y1, double x2, double y2, double z41, byte leftRight)
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

	public static void ZontOstrivnyyTyp31DrawImage(int L, int B, int H, int h, int a, int b, int p, double c, double c1, int number, string implementation, string zontMaterial, string tovchynaMetaluZont, string connection, string zlyv, string fastening, string typeFastening, string zhyrFiltr, string zhyrFiltrMaterial, string tovchynaMetaluFiltr, string orderCode, string contragent, string filePath = null)
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
		//IL_3db2: Unknown result type (might be due to invalid IL or missing references)
		//IL_3db9: Expected O, but got Unknown
		//IL_3db9: Unknown result type (might be due to invalid IL or missing references)
		//IL_3dc0: Expected O, but got Unknown
		int num = 725;
		int num2 = 1026;
		int num3 = 35;
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
			string text = "Зонт ЗВО-3.1 " + L + "х" + B + "х" + H;
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
			double num22 = p;
			double num23 = num22 * num18;
			double num24 = (double)a * Math.Sin(num17);
			num24 += (double)H + num22;
			if ((double)L * Math.Sin(num17) + (double)h > num24)
			{
				num24 = (double)L * Math.Sin(num17) + (double)h;
			}
			double num25 = (double)(num2 / 3) / num24;
			if (num25 < num18)
			{
				num18 = num25;
			}
			int num26 = 10;
			num6 = num5 + num20 + num26;
			int num27 = num6;
			num6 += (int)((num24 - ((double)H + (double)a * Math.Sin(num17))) * num18);
			double num28 = (double)L * num18;
			double num29 = (double)H * num18;
			double num30 = (double)B * num18;
			double num31 = (double)h * num18;
			double num32 = (double)a * num18;
			double num33 = (double)b * num18;
			double num34 = c * num18;
			double num35 = c1 * num18;
			double num36 = Math.Sqrt(Math.Pow(c, 2.0) + Math.Pow(c1, 2.0) + Math.Pow(H - h, 2.0));
			double num37 = Math.Sqrt(Math.Pow(c, 2.0) + Math.Pow((double)(B - b) - c1, 2.0) + Math.Pow(H - h, 2.0));
			double num38 = Math.Sqrt(Math.Pow((double)(L - a) - c, 2.0) + Math.Pow((double)(B - b) - c1, 2.0) + Math.Pow(H - h, 2.0));
			double num39 = Math.Sqrt(Math.Pow((double)(L - a) - c, 2.0) + Math.Pow(c1, 2.0) + Math.Pow(H - h, 2.0));
			double num40 = num36 * num18;
			double num41 = num37 * num18;
			double num42 = num38 * num18;
			double num43 = num39 * num18;
			double num44 = (double)num3 + num35;
			double num45 = (double)num6 + num32 * Math.Sin(num17);
			double num46 = num44 + num33;
			double num47 = num45;
			val2.DrawLine(val4, (float)num44, (float)num45, (float)num46, (float)num47);
			val2.DrawLine(val4, (float)num44, (float)num45, (float)num44, (float)num45 - (float)num23);
			val2.DrawLine(val4, (float)num44, (float)num45 - (float)num23, (float)num46, (float)num47 - (float)num23);
			val2.DrawLine(val4, (float)num46, (float)num47, (float)num46, (float)num47 - (float)num23);
			num46 = num44 + num32 * Math.Cos(num17);
			num47 = num6;
			val2.DrawLine(val4, (float)num44, (float)num45, (float)num46, (float)num47);
			val2.DrawLine(val4, (float)num44, (float)num45 - (float)num23, (float)num46, (float)num47 - (float)num23);
			val2.DrawLine(val4, (float)num46, (float)num47, (float)num46, (float)num47 - (float)num23);
			num44 = num46;
			num45 = num47;
			num46 = num44 + num33;
			val2.DrawLine(val4, (float)num44, (float)num45, (float)num46, (float)num47);
			val2.DrawLine(val4, (float)num44, (float)num45 - (float)num23, (float)num46, (float)num47 - (float)num23);
			val2.DrawLine(val4, (float)num46, (float)num47, (float)num46, (float)num47 - (float)num23);
			num44 = (double)num3 + num35 + num33;
			num45 = (double)num6 + num32 * Math.Sin(num17);
			val2.DrawLine(val4, (float)num44, (float)num45, (float)num46, (float)num47);
			val2.DrawLine(val4, (float)num44, (float)num45 - (float)num23, (float)num46, (float)num47 - (float)num23);
			num44 = (double)num3 + num35;
			num45 = (double)num6 + num32 * Math.Sin(num17);
			num46 = num44 - num35;
			num47 = num45 + (num29 - num31);
			val2.DrawLine(val4, (float)num44, (float)num45, (float)num46, (float)num47);
			num44 = num46;
			num45 = num47;
			num46 = num44 + num30;
			num47 = num45;
			val2.DrawLine(val4, (float)num44, (float)num45, (float)num46, (float)num47);
			num44 = num46;
			num45 = num47;
			num46 = (double)num3 + num35 + num33;
			num47 = num45 - (num29 - num31);
			val2.DrawLine(val4, (float)num44, (float)num45, (float)num46, (float)num47);
			num46 = num44 + num28 * Math.Cos(num17);
			num47 = num45 - num28 * Math.Sin(num17);
			val2.DrawLine(val4, (float)num44, (float)num45, (float)num46, (float)num47);
			num44 = num46;
			num45 = num47;
			num46 = (double)num3 + num35 + num32 * Math.Cos(num17) + num33;
			num47 = num6;
			val2.DrawLine(val4, (float)num44, (float)num45, (float)num46, (float)num47);
			num46 = num44 - num30;
			num47 = num45;
			val2.DrawLine(val4, (float)num44, (float)num45, (float)num46, (float)num47);
			num44 = num46;
			num45 = num47;
			num46 = (double)num3 + num35 + num32 * Math.Cos(num17);
			num47 = num6;
			val2.DrawLine(val4, (float)num44, (float)num45, (float)num46, (float)num47);
			num44 = num3;
			num45 = (double)num6 + num32 * Math.Sin(num17) + num29 - num31;
			num46 = num44;
			num47 = num45 + num31;
			val2.DrawLine(val4, (float)num44, (float)num45, (float)num46, (float)num47);
			num44 = num46;
			num45 = num47;
			num46 = num44 + num30;
			val2.DrawLine(val4, (float)num44, (float)num45, (float)num46, (float)num47);
			num44 = num46;
			num45 = num47 - num31;
			val2.DrawLine(val4, (float)num44, (float)num45, (float)num46, (float)num47);
			num44 = num46 + num28 * Math.Cos(num17);
			num45 = num47 - num28 * Math.Sin(num17);
			val2.DrawLine(val4, (float)num44, (float)num45, (float)num46, (float)num47);
			num46 = num44;
			num47 = num45 - num31;
			val2.DrawLine(val4, (float)num44, (float)num45, (float)num46, (float)num47);
			num44 = (double)num3 + num35;
			num45 = (double)num6 + num32 * Math.Sin(num17);
			num46 = num44 - num35 - (double)num14;
			num47 = num45;
			val2.DrawLine(val3, (float)num44, (float)num45, (float)num46, (float)num47);
			num44 = num3;
			num45 = (double)num6 + num32 * Math.Sin(num17) + num29;
			num46 = num3 - num14;
			num47 = num45;
			val2.DrawLine(val3, (float)num44, (float)num45, (float)num46, (float)num47);
			num44 = num3 - num14 + 5;
			num45 = (double)num6 + num32 * Math.Sin(num17);
			num46 = num44;
			num47 = num45 + num29;
			DrawRows(num44, num45, num46, num47, num18, val2, val3);
			double num48 = num44 - (double)num21;
			double num49 = (num45 + num47) / 2.0;
			#if WINDOWS

			val9.FormatFlags = (StringFormatFlags)2;

			#endif
			val2.DrawString(H.ToString(), val7, (Brush)(object)val8, (float)num48, (float)num49, val9);
			num44 = (double)num3 + num35;
			num45 = (double)num6 + num32 * Math.Sin(num17) - num23;
			num46 = num44 - (double)num14;
			num47 = num45;
			val2.DrawLine(val3, (float)num44, (float)num45, (float)num46, (float)num47);
			num44 = (double)num3 + num35 - (double)num14 + 5.0;
			num45 = (double)num6 + num32 * Math.Sin(num17);
			num46 = num44;
			num47 = num45 - num23;
			DrawRows(num44, num45, num46, num47, num18, val2, val3);
			num48 = num44 - (double)(2 * num21);
			num49 = num47;
			#if WINDOWS

			val9.FormatFlags = (StringFormatFlags)2;

			#endif
			val2.DrawString(num22.ToString(), val7, (Brush)(object)val8, (float)num48, (float)num49, val9);
			num44 = num3;
			num45 = (double)num6 + num32 * Math.Sin(num17) + num29;
			num46 = num44;
			num47 = num45 + (double)num14;
			val2.DrawLine(val3, (float)num44, (float)num45, (float)num46, (float)num47);
			num44 = (double)num3 + num30;
			num45 = (double)num6 + num32 * Math.Sin(num17) + num29;
			num46 = num44;
			num47 = num45 + (double)num14;
			val2.DrawLine(val3, (float)num44, (float)num45, (float)num46, (float)num47);
			num44 = num3;
			num45 = (double)num6 + num32 * Math.Sin(num17) + num29 + (double)num14 - 5.0;
			num46 = num44 + num30;
			num47 = num45;
			DrawRows(num44, num45, num46, num47, num18, val2, val3);
			num48 = (num44 + num46) / 2.0;
			num49 = num47 + (double)num21;
			#if WINDOWS

			val9.FormatFlags = (StringFormatFlags)1;

			#endif
			val2.DrawString(B.ToString(), val7, (Brush)(object)val8, (float)num48, (float)num49, val9);
			num44 = (double)num3 + num30 + num28 * Math.Cos(num17);
			num45 = (double)num6 + num32 * Math.Sin(num17) + num29 - num28 * Math.Sin(num17);
			num46 = num44;
			num47 = num45 + (double)num14;
			val2.DrawLine(val3, (float)num44, (float)num45, (float)num46, (float)num47);
			num44 = num46;
			num45 = num47 - 5.0;
			num46 = num44 - num28 * Math.Cos(num17);
			num47 = num45 + num28 * Math.Sin(num17);
			DrawRows(num46, num47, num44, num45, num18, val2, val3);
			num48 = (num44 + num46) / 2.0;
			num49 = (num45 + num47) / 2.0 + 15.0 + 5.0;
			#if WINDOWS

			val9.FormatFlags = (StringFormatFlags)1;

			#endif
			val2.DrawString(L.ToString(), val7, (Brush)(object)val8, (float)num48, (float)num49, val9);
			num44 = (double)num3 + num30 + num28 * Math.Cos(num17);
			num45 = (double)num6 + num32 * Math.Sin(num17) + num29 - num28 * Math.Sin(num17);
			num46 = num44 + (double)num14;
			num47 = num45;
			val2.DrawLine(val3, (float)num44, (float)num45, (float)num46, (float)num47);
			num45 -= num31;
			num47 = num45;
			val2.DrawLine(val3, (float)num44, (float)num45, (float)num46, (float)num47);
			num44 = (double)num3 + num30 + num28 * Math.Cos(num17) + (double)num14 - 5.0;
			num45 = (double)num6 + num32 * Math.Sin(num17) + num29 - num28 * Math.Sin(num17);
			num46 = num44;
			num47 = num45 - num31;
			DrawRows(num46, num47, num44, num45, num18, val2, val3);
			num48 = num44 + (double)num21;
			num49 = (num45 + num47) / 2.0;
			#if WINDOWS

			val9.FormatFlags = (StringFormatFlags)2;

			#endif
			val2.DrawString(h.ToString(), val7, (Brush)(object)val8, (float)num48, (float)num49, val9);
			num44 = (double)num3 + num35;
			num45 = (double)num6 + num32 * Math.Sin(num17);
			num46 = num44;
			num47 = num45 + (double)num14;
			val2.DrawLine(val3, (float)num44, (float)num45, (float)num46, (float)num47);
			num44 += num33;
			num46 = num44;
			val2.DrawLine(val3, (float)num44, (float)num45, (float)num46, (float)num47);
			num44 = num46;
			num47 -= 5.0;
			num46 = num44 - num33;
			num45 = num47;
			DrawRows(num46, num47, num44, num45, num18, val2, val3);
			num48 = (num44 + num46) / 2.0;
			num49 = num47 + (double)num21;
			#if WINDOWS

			val9.FormatFlags = (StringFormatFlags)1;

			#endif
			val2.DrawString(b.ToString(), val7, (Brush)(object)val8, (float)num48, (float)num49, val9);
			num44 = (double)num3 + num33 + num35;
			num45 = (double)num6 + num32 * Math.Sin(num17);
			num46 = num44 + (double)num14 * Math.Sin(num17);
			num47 = num45 + (double)num14 * Math.Cos(num17);
			double num50 = num46;
			double num51 = num47;
			val2.DrawLine(val3, (float)num44, (float)num45, (float)num46, (float)num47);
			num44 += num32 * Math.Cos(num17);
			num45 = num6;
			num46 = num44 + (double)num14 * Math.Sin(num17);
			num47 = num45 + (double)num14 * Math.Cos(num17);
			val2.DrawLine(val3, (float)num44, (float)num45, (float)num46, (float)num47);
			num44 = num50 - 5.0 * Math.Sin(num17);
			num45 = num51 - 5.0 * Math.Cos(num17);
			num46 -= 5.0 * Math.Sin(num17);
			num47 -= 5.0 * Math.Cos(num17);
			DrawRows(num44, num45, num46, num47, num18, val2, val3);
			num48 = (num44 + num46) / 2.0 + (double)num21;
			num49 = (num45 + num47) / 2.0 + (double)num21;
			#if WINDOWS

			val9.FormatFlags = (StringFormatFlags)1;

			#endif
			val2.DrawString(a.ToString(), val7, (Brush)(object)val8, (float)num48, (float)num49, val9);
			num44 = num3;
			num45 = (double)num6 + num32 * Math.Sin(num17) + num29 - num31;
			num46 = num44 + num35;
			num47 = (double)num6 + num32 * Math.Sin(num17);
			num48 = (num44 + num46) / 2.0 - 1.5 * (double)num21;
			num49 = (num45 + num47) / 2.0;
			#if WINDOWS

			val9.FormatFlags = (StringFormatFlags)1;

			#endif
			val2.DrawString(Math.Round(num36, MidpointRounding.AwayFromZero).ToString(), val7, (Brush)(object)val8, (float)num48, (float)num49, val9);
			num44 = (double)num3 + num30;
			num45 = (double)num6 + num32 * Math.Sin(num17) + num29 - num31;
			num46 = num44 - (num30 - num35 - num33);
			num47 = (double)num6 + num32 * Math.Sin(num17);
			num48 = (num44 + num46) / 2.0 + 1.5 * (double)num21;
			num49 = (num45 + num47) / 2.0;
			#if WINDOWS

			val9.FormatFlags = (StringFormatFlags)1;

			#endif
			val2.DrawString(Math.Round(num37, MidpointRounding.AwayFromZero).ToString(), val7, (Brush)(object)val8, (float)num48, (float)num49, val9);
			num44 = (double)num3 + num30 + num28 * Math.Cos(num17);
			num45 = (double)num6 + num32 * Math.Sin(num17) - (num28 * Math.Sin(num17) - (num29 - num31));
			num46 = (double)num3 + num35 + num33 + num32 * Math.Sin(num17);
			num47 = num6;
			num48 = (num44 + num46) / 2.0 + (double)num21;
			num49 = (num45 + num47) / 2.0 - (double)num21;
			#if WINDOWS

			val9.FormatFlags = (StringFormatFlags)1;

			#endif
			val2.DrawString(Math.Round(num38, MidpointRounding.AwayFromZero).ToString(), val7, (Brush)(object)val8, (float)num48, (float)num49, val9);
			num44 -= num30;
			num46 -= num33;
			num47 = num6;
			num48 = (num44 + num46) / 2.0 + (double)num21;
			num49 = (num45 + num47) / 2.0 - (double)num21;
			#if WINDOWS

			val9.FormatFlags = (StringFormatFlags)1;

			#endif
			val2.DrawString(Math.Round(num39, MidpointRounding.AwayFromZero).ToString(), val7, (Brush)(object)val8, (float)num48, (float)num49, val9);
			double num52 = Math.Atan((double)(H - h) / c);
			double num53 = Math.Atan((double)(H - h) / ((double)L - c - (double)a));
			double num54 = Math.Atan((double)(H - h) / c1);
			double num55 = Math.Atan((double)(H - h) / ((double)B - c1 - (double)b));
			double num56 = (double)B * Math.Sqrt(Math.Pow(num36, 2.0) - Math.Pow(c1, 2.0)) / num36;
			double num57 = Math.Sqrt(Math.Pow(B, 2.0) - Math.Pow(num56, 2.0));
			double a2 = Math.Acos(c / num36);
			double num58 = num57 * Math.Tan(a2);
			double x = Math.Sqrt(Math.Pow(num57, 2.0) + Math.Pow(num58, 2.0));
			double x2 = Math.Sqrt(Math.Pow(B, 2.0) + Math.Pow(x, 2.0));
			double num59 = Math.Round(180.0 * Math.Acos((Math.Pow(num56, 2.0) + Math.Pow(num58, 2.0) - Math.Pow(x2, 2.0)) / (2.0 * num56 * num58)) / Math.PI, MidpointRounding.AwayFromZero);
			num56 = (double)B * Math.Sqrt(Math.Pow(num37, 2.0) - Math.Pow((double)B - c1 - (double)b, 2.0)) / num37;
			double num60 = Math.Sqrt(Math.Pow(B, 2.0) - Math.Pow(num56, 2.0));
			a2 = Math.Acos(c / num37);
			num58 = num60 * Math.Tan(a2);
			x = Math.Sqrt(Math.Pow(num60, 2.0) + Math.Pow(num58, 2.0));
			x2 = Math.Sqrt(Math.Pow(B, 2.0) + Math.Pow(x, 2.0));
			double num61 = Math.Round(180.0 * Math.Acos((Math.Pow(num56, 2.0) + Math.Pow(num58, 2.0) - Math.Pow(x2, 2.0)) / (2.0 * num56 * num58)) / Math.PI, MidpointRounding.AwayFromZero);
			num56 = (double)L * Math.Sqrt(Math.Pow(num38, 2.0) - Math.Pow((double)L - c - (double)a, 2.0)) / num38;
			double num62 = Math.Sqrt(Math.Pow(L, 2.0) - Math.Pow(num56, 2.0));
			a2 = Math.Acos(((double)B - c1 - (double)b) / num38);
			num58 = num62 * Math.Tan(a2);
			x = Math.Sqrt(Math.Pow(num62, 2.0) + Math.Pow(num58, 2.0));
			x2 = Math.Sqrt(Math.Pow(L, 2.0) + Math.Pow(x, 2.0));
			double num63 = Math.Round(180.0 * Math.Acos((Math.Pow(num56, 2.0) + Math.Pow(num58, 2.0) - Math.Pow(x2, 2.0)) / (2.0 * num56 * num58)) / Math.PI, MidpointRounding.AwayFromZero);
			num56 = (double)L * Math.Sqrt(Math.Pow(num39, 2.0) - Math.Pow((double)L - c - (double)a, 2.0)) / num39;
			double num64 = Math.Sqrt(Math.Pow(L, 2.0) - Math.Pow(num56, 2.0));
			a2 = Math.Acos(c1 / num39);
			num58 = num64 * Math.Tan(a2);
			x = Math.Sqrt(Math.Pow(num64, 2.0) + Math.Pow(num58, 2.0));
			x2 = Math.Sqrt(Math.Pow(L, 2.0) + Math.Pow(x, 2.0));
			double num65 = Math.Round(180.0 * Math.Acos((Math.Pow(num56, 2.0) + Math.Pow(num58, 2.0) - Math.Pow(x2, 2.0)) / (2.0 * num56 * num58)) / Math.PI, MidpointRounding.AwayFromZero);
			if (c == 0.0)
			{
				num59 = 90.0;
				num61 = 90.0;
			}
			if (c == (double)(L - a))
			{
				num63 = 90.0;
				num65 = 90.0;
			}
			if (c1 == 0.0)
			{
				num59 = 90.0;
				num65 = 90.0;
			}
			if (c1 == (double)(B - b))
			{
				num61 = 90.0;
				num63 = 90.0;
			}
			double num66 = 20.0;
			double num67 = Math.Acos(c1 / num36);
			num44 = (double)num3 + num30 / 2.0;
			num45 = (double)num6 + num32 * Math.Sin(num17) + num29 - num31;
			num46 = num44 + num66 * Math.Cos(num67);
			num47 = num45 - num66 * Math.Sin(num67);
			val2.DrawLine(val3, (float)num44, (float)num45, (float)num46, (float)num47);
			num46 = num44 + num66 * Math.Cos(num17);
			num47 = num45 - num66 * Math.Sin(num17);
			val2.DrawLine(val3, (float)num44, (float)num45, (float)num46, (float)num47);
			num44 = (double)num3 + num30 / 2.0 + num66 * Math.Cos(num67) / 2.0;
			num45 = (double)num6 + num32 * Math.Sin(num17) + num29 - num31 - num66 * Math.Sin(num67) / 2.0;
			double num68 = (double)num3 + num30 / 2.0 + num66 * Math.Cos(num17) / 2.0;
			double num69 = (double)num6 + num32 * Math.Sin(num17) + num29 - num31 - num66 * Math.Sin(num17) / 2.0;
			num46 = (num44 + num68) / 2.0 + num66 / 2.0;
			num47 = (num45 + num69) / 2.0 - num66 / 2.0;
			val2.DrawBezier(val3, (float)num68, (float)num69, (float)num46, (float)num47, (float)num44, (float)num45, (float)num44, (float)num45);
			num52 = Math.Round(180.0 * num52 / Math.PI, MidpointRounding.AwayFromZero);
			num52 = 90.0 - num52;
			#if WINDOWS

			val9.FormatFlags = (StringFormatFlags)1;

			#endif
			val2.DrawString(num52 + "°", val7, (Brush)(object)val8, (float)(num46 + 5.0), (float)num47 - 5f, val9);
			#if WINDOWS

			val9.FormatFlags = (StringFormatFlags)2;

			#endif
			num44 = (double)num3 + num30 + num28 * Math.Cos(num17) / 2.0;
			num45 = (double)num6 + num32 * Math.Sin(num17) + num29 - num31 - num28 * Math.Sin(num17) / 2.0;
			num46 = num44 - num66;
			num47 = num45;
			val2.DrawLine(val3, (float)num44, (float)num45, (float)num46, (float)num47);
			num46 = num44 - num66 * Math.Sin(num17);
			num47 = num45 - num66 * Math.Cos(num17);
			val2.DrawLine(val3, (float)num44, (float)num45, (float)num46, (float)num47);
			num44 = (double)num3 + num30 + num28 * Math.Cos(num17) / 2.0 - num66 / 2.0;
			num45 = (double)num6 + num32 * Math.Sin(num17) + num29 - num31 - num28 * Math.Sin(num17) / 2.0;
			num68 = (double)num3 + num30 + num28 * Math.Cos(num17) / 2.0 - num66 * Math.Sin(num17) / 2.0;
			num69 = num45 - num66 * Math.Cos(num17) / 2.0;
			num46 = (num44 + num68) / 2.0 - num66 / 2.0;
			num47 = (num45 + num69) / 2.0 - num66 / 2.0;
			val2.DrawBezier(val3, (float)num68, (float)num69, (float)num46, (float)num47, (float)num44, (float)num45, (float)num44, (float)num45);
			num55 = Math.Round(180.0 * num55 / Math.PI, MidpointRounding.AwayFromZero);
			num55 = 90.0 - num55;
			#if WINDOWS

			val9.FormatFlags = (StringFormatFlags)1;

			#endif
			val2.DrawString(num55 + "°", val7, (Brush)(object)val8, (float)(num46 - 5.0), (float)num47, val9);
			#if WINDOWS

			val9.FormatFlags = (StringFormatFlags)2;

			#endif
			num67 = Math.Acos(((double)L - c - (double)a) / num39);
			num44 = (double)num3 + num30 / 2.0 + num28 * Math.Cos(num17);
			num45 = (double)num6 + num32 * Math.Sin(num17) + num29 - num31 - num28 * Math.Sin(num17);
			num46 = num44 - num66 * Math.Cos(num67 - num17);
			num47 = num45 + num66 * Math.Sin(num67 - num17);
			val2.DrawLine(val3, (float)num44, (float)num45, (float)num46, (float)num47);
			num46 = num44 - num66 * Math.Cos(num17);
			num47 = num45 - num66 * Math.Sin(num17);
			val2.DrawLine(val3, (float)num44, (float)num45, (float)num46, (float)num47);
			num44 = (double)num3 + num30 / 2.0 + num28 * Math.Cos(num17) - num66 * Math.Cos(num67 - num17) / 2.0;
			num45 += num66 * Math.Sin(num67 - num17) / 2.0;
			num68 = (double)num3 + num30 / 2.0 + num28 * Math.Cos(num17) - num66 * Math.Cos(num17) / 2.0;
			num69 = (double)num6 + num32 * Math.Sin(num17) + num29 - num31 - num28 * Math.Sin(num17) - num66 * Math.Sin(num17) / 2.0;
			num46 = (num44 + num68) / 2.0 - num66 / 2.0;
			num47 = (num45 + num69) / 2.0 + num66 / 2.0;
			val2.DrawBezier(val3, (float)num68, (float)num69, (float)num46, (float)num47, (float)num44, (float)num45, (float)num44, (float)num45);
			num53 = Math.Round(180.0 * num53 / Math.PI, MidpointRounding.AwayFromZero);
			num53 = 90.0 - num53;
			#if WINDOWS

			val9.FormatFlags = (StringFormatFlags)1;

			#endif
			val2.DrawString(num53 + "°", val7, (Brush)(object)val8, (float)(num46 - 5.0), (float)num47, val9);
			#if WINDOWS

			val9.FormatFlags = (StringFormatFlags)2;

			#endif
			num44 = num3;
			num45 = (double)num6 + num32 * Math.Sin(num17) + num29 - num31;
			num46 = num44 + 3.0 * num66 * Math.Cos(num17);
			num47 = num45 - 3.0 * num66 * Math.Sin(num17);
			val2.DrawLine(val3, (float)num44, (float)num45, (float)num46, (float)num47);
			num67 = Math.Atan((double)(H - h) / c1);
			num44 = (double)num3 + num66 * Math.Cos(num17);
			num45 = (double)num6 + num32 * Math.Sin(num17) + num29 - num31 - num66 * Math.Sin(num17);
			num46 = num44 + num66;
			num47 = num45;
			val2.DrawLine(val3, (float)num44, (float)num45, (float)num46, (float)num47);
			num46 = num44 + num66 * Math.Cos(num67);
			num47 = num45 - num66 * Math.Sin(num67);
			val2.DrawLine(val3, (float)num44, (float)num45, (float)num46, (float)num47);
			num44 = (double)num3 + num66 * Math.Cos(num17) + num66 / 2.0;
			num45 = (double)num6 + num32 * Math.Sin(num17) + num29 - num31 - num66 * Math.Sin(num17);
			num68 = (double)num3 + num66 * Math.Cos(num17) + num66 * Math.Cos(num67) / 2.0;
			num69 = (double)num6 + num32 * Math.Sin(num17) + num29 - num31 - num66 * Math.Sin(num17) - num66 * Math.Sin(num67) / 2.0;
			num46 = (num44 + num68) / 2.0 + num66;
			num47 = (num45 + num69) / 2.0 - num66 / 2.0;
			val2.DrawBezier(val3, (float)num68, (float)num69, (float)num46, (float)num47, (float)num44, (float)num45, (float)num44, (float)num45);
			num54 = Math.Round(180.0 * num54 / Math.PI, MidpointRounding.AwayFromZero);
			num54 = 90.0 - num54;
			#if WINDOWS

			val9.FormatFlags = (StringFormatFlags)1;

			#endif
			val2.DrawString(num54 + "°", val7, (Brush)(object)val8, (float)(num46 + 3.0), (float)num45, val9);
			#if WINDOWS

			val9.FormatFlags = (StringFormatFlags)2;

			#endif
			num67 = Math.Atan((double)(H - h) / c1);
			num44 = (double)num3 + 2.0 * num66 * Math.Cos(num67);
			num45 = (double)num6 + num32 * Math.Sin(num17) + num29 - num31 - 2.0 * num66 * Math.Sin(num67);
			num46 = num44 + num66 * Math.Cos(num17);
			num47 = num45 - num66 * Math.Sin(num17);
			val2.DrawLine(val3, (float)num44, (float)num45, (float)num46, (float)num47);
			num46 = num44 + num66;
			num47 = num45;
			val2.DrawLine(val3, (float)num44, (float)num45, (float)num46, (float)num47);
			num44 = (double)num3 + 2.0 * num66 * Math.Cos(num67) + num66 * Math.Cos(num17) / 2.0;
			num45 = (double)num6 + num32 * Math.Sin(num17) + num29 - num31 - 2.0 * num66 * Math.Sin(num67) - num66 * Math.Sin(num17) / 2.0;
			num68 = (double)num3 + 2.0 * num66 * Math.Cos(num67) + num66 / 2.0;
			num69 = (double)num6 + num32 * Math.Sin(num17) + num29 - num31 - 2.0 * num66 * Math.Sin(num67);
			num46 = (num44 + num68) / 2.0 + num66 / 2.0;
			num47 = (num45 + num69) / 2.0 - num66 / 2.0;
			val2.DrawBezier(val3, (float)num68, (float)num69, (float)num46, (float)num47, (float)num44, (float)num45, (float)num44, (float)num45);
			num59 = 180.0 - num59;
			#if WINDOWS

			val9.FormatFlags = (StringFormatFlags)1;

			#endif
			val2.DrawString(num59 + "°", val7, (Brush)(object)val8, (float)(num46 + 10.0), (float)(num47 + 3.0), val9);
			#if WINDOWS

			val9.FormatFlags = (StringFormatFlags)2;

			#endif
			num67 = Math.Atan((double)(H - h) / ((double)(B - b) - c1));
			num44 = (double)num3 + num30 - 2.0 * num66 * Math.Cos(num67);
			num45 = (double)num6 + num32 * Math.Sin(num17) + num29 - num31 - 2.0 * num66 * Math.Sin(num67);
			num46 = num44 - num66 * Math.Cos(num17);
			num47 = num45 - num66 * Math.Sin(num17);
			val2.DrawLine(val3, (float)num44, (float)num45, (float)num46, (float)num47);
			num46 = num44 - num66;
			num47 = num45;
			val2.DrawLine(val3, (float)num44, (float)num45, (float)num46, (float)num47);
			num44 = (double)num3 + num30 - 2.0 * num66 * Math.Cos(num67) - num66 * Math.Cos(num17) / 2.0;
			num45 = (double)num6 + num32 * Math.Sin(num17) + num29 - num31 - 2.0 * num66 * Math.Sin(num67) - num66 * Math.Sin(num17) / 2.0;
			num68 = (double)num3 + num30 - 2.0 * num66 * Math.Cos(num67) - num66 / 2.0;
			num69 = (double)num6 + num32 * Math.Sin(num17) + num29 - num31 - 2.0 * num66 * Math.Sin(num67);
			num46 = (num44 + num68) / 2.0 - num66 / 2.0;
			num47 = (num45 + num69) / 2.0 - num66 / 2.0;
			val2.DrawBezier(val3, (float)num68, (float)num69, (float)num46, (float)num47, (float)num44, (float)num45, (float)num44, (float)num45);
			num61 = 180.0 - num61;
			#if WINDOWS

			val9.FormatFlags = (StringFormatFlags)1;

			#endif
			val2.DrawString(num61 + "°", val7, (Brush)(object)val8, (float)(num46 - 10.0), (float)(num47 + 3.0), val9);
			#if WINDOWS

			val9.FormatFlags = (StringFormatFlags)2;

			#endif
			num44 = ((double)num3 + num30 + num28 * Math.Cos(num17) + ((double)num3 + num35 + num33 + num32 * Math.Cos(num17))) / 2.0;
			num45 = ((double)(num6 + num6) + num32 * Math.Sin(num17) + num29 - num31 - num28 * Math.Sin(num17)) / 2.0;
			num46 = num44 - num66 * Math.Cos(num17);
			num47 = num45 + num66 * Math.Sin(num17);
			val2.DrawLine(val3, (float)num44, (float)num45, (float)num46, (float)num47);
			num46 = num44 - num66;
			num47 = num45;
			val2.DrawLine(val3, (float)num44, (float)num45, (float)num46, (float)num47);
			num44 = ((double)num3 + num30 + num28 * Math.Cos(num17) + ((double)num3 + num35 + num33 + num32 * Math.Cos(num17))) / 2.0 - num66 * Math.Cos(num17) / 2.0;
			num45 = ((double)(num6 + num6) + num32 * Math.Sin(num17) + num29 - num31 - num28 * Math.Sin(num17)) / 2.0 + num66 * Math.Sin(num17) / 2.0;
			num68 = ((double)num3 + num30 + num28 * Math.Cos(num17) + ((double)num3 + num35 + num33 + num32 * Math.Cos(num17))) / 2.0 - num66 / 2.0;
			num69 = ((double)(num6 + num6) + num32 * Math.Sin(num17) + num29 - num31 - num28 * Math.Sin(num17)) / 2.0;
			num46 = (num44 + num68) / 2.0 - num66 / 2.0;
			num47 = (num45 + num69) / 2.0 + num66 / 2.0;
			val2.DrawBezier(val3, (float)num68, (float)num69, (float)num46, (float)num47, (float)num44, (float)num45, (float)num44, (float)num45);
			num63 = 180.0 - num63;
			#if WINDOWS

			val9.FormatFlags = (StringFormatFlags)1;

			#endif
			val2.DrawString(num63 + "°", val7, (Brush)(object)val8, (float)(num46 - 10.0), (float)(num47 + 3.0), val9);
			#if WINDOWS

			val9.FormatFlags = (StringFormatFlags)2;

			#endif
			num44 = ((double)num3 + num28 * Math.Cos(num17) + ((double)num3 + num35 + num32 * Math.Cos(num17))) / 2.0;
			num45 = ((double)(num6 + num6) + num32 * Math.Sin(num17) + num29 - num31 - num28 * Math.Sin(num17)) / 2.0;
			num46 = num44 - num66 * Math.Cos(num17);
			num47 = num45 + num66 * Math.Sin(num17);
			val2.DrawLine(val3, (float)num44, (float)num45, (float)num46, (float)num47);
			num46 = num44 + num66;
			num47 = num45;
			val2.DrawLine(val3, (float)num44, (float)num45, (float)num46, (float)num47);
			num44 = ((double)num3 + num28 * Math.Cos(num17) + ((double)num3 + num35 + num32 * Math.Cos(num17))) / 2.0 - num66 * Math.Cos(num17) / 2.0;
			num45 = ((double)(num6 + num6) + num32 * Math.Sin(num17) + num29 - num31 - num28 * Math.Sin(num17)) / 2.0 + num66 * Math.Sin(num17) / 2.0;
			num68 = ((double)num3 + num28 * Math.Cos(num17) + ((double)num3 + num35 + num32 * Math.Cos(num17))) / 2.0 + num66 / 2.0;
			num69 = ((double)(num6 + num6) + num32 * Math.Sin(num17) + num29 - num31 - num28 * Math.Sin(num17)) / 2.0;
			num46 = (num44 + num68) / 2.0 + num66 / 2.0;
			num47 = (num45 + num69) / 2.0 + num66 / 2.0;
			val2.DrawBezier(val3, (float)num68, (float)num69, (float)num46, (float)num47, (float)num44, (float)num45, (float)num44, (float)num45);
			num65 = 180.0 - num65;
			#if WINDOWS

			val9.FormatFlags = (StringFormatFlags)1;

			#endif
			val2.DrawString(num65 + "°", val7, (Brush)(object)val8, (float)(num46 - 5.0), (float)(num47 + 3.0), val9);
			#if WINDOWS

			val9.FormatFlags = (StringFormatFlags)2;

			#endif
			double num94;
			double num95;
			if (zhyrFiltr == "так")
			{
				if (implementation == "ж/ф внизу зонта (2 ряди)")
				{
					double num70 = 60.0;
					double num71 = 10.0;
					double num72 = 55.0;
					double num73 = 15.0;
					double num74 = 30.0;
					double num75 = 10.0;
					double num76 = num70 * num18;
					double num77 = num71 * num18;
					double num78 = num72 * num18;
					double num79 = num73 * num18;
					double num80 = num74 * num18;
					double num81 = num75 * num18;
					num44 = num3;
					num45 = (double)num6 + num32 * Math.Sin(num17) + num29;
					num46 = num44 + num80;
					num47 = num45;
					val2.DrawLine(val5, (float)num44, (float)num45, (float)num46, (float)num47);
					num44 = num46;
					num47 = num45 - num81;
					val2.DrawLine(val5, (float)num44, (float)num45, (float)num46, (float)num47);
					num44 = (double)num3 + num30;
					num45 = (double)num6 + num32 * Math.Sin(num17) + num29;
					num46 = num44 - num80;
					num47 = num45;
					val2.DrawLine(val5, (float)num44, (float)num45, (float)num46, (float)num47);
					num44 = num46;
					num47 = num45 - num81;
					val2.DrawLine(val5, (float)num44, (float)num45, (float)num46, (float)num47);
					num44 = (double)num3 + num30 / 2.0 - num76 / 2.0;
					num45 = (double)num6 + num32 * Math.Sin(num17) + num29;
					num46 = num44 + num76;
					num47 = num45;
					val2.DrawLine(val5, (float)num44, (float)num45, (float)num46, (float)num47);
					num46 = num44;
					num47 = num45 - num77;
					val2.DrawLine(val5, (float)num44, (float)num45, (float)num46, (float)num47);
					num44 += num76;
					num46 = num44;
					num47 = num45 - num77;
					val2.DrawLine(val5, (float)num44, (float)num45, (float)num46, (float)num47);
					double num82 = 3.0;
					double num83 = 3.0;
					num44 = (double)num3 + num30 / 2.0;
					num45 = (double)num6 + num32 * Math.Sin(num17) + num29 - num82;
					num46 = num44 + num79;
					num47 = num45;
					val2.DrawLine(val5, (float)num44, (float)num45, (float)num46, (float)num47);
					num46 = num44;
					num47 = num45 - num78;
					val2.DrawLine(val5, (float)num44, (float)num45, (float)num46, (float)num47);
					double num84 = 40.0;
					double num85 = num84 * num18;
					double num86 = 5.0;
					double num87 = num86 * num18;
					l = B / 2 - 2 * (int)num86;
					double num88 = (double)l * num18;
					num44 = (double)num3 + num87 + num83;
					num45 = (double)num6 + num32 * Math.Sin(num17) + num29 - num81 - num82;
					num46 = num44 + num88 - 2.0 * num83;
					num47 = num45;
					val2.DrawLine(val5, (float)num44, (float)num45, (float)num46, (float)num47);
					num46 = num44;
					num47 = num45 - num85;
					val2.DrawLine(val5, (float)num44, (float)num45, (float)num46, (float)num47);
					num44 += num88 - 2.0 * num83;
					num46 = num44;
					num47 = num45 - num85;
					val2.DrawLine(val5, (float)num44, (float)num45, (float)num46, (float)num47);
					num45 = num47;
					num46 = num44 - (num88 - 2.0 * num83);
					val2.DrawLine(val5, (float)num44, (float)num45, (float)num46, (float)num47);
					num44 = (double)num3 + num30 / 2.0 + num87 + num83;
					num45 = (double)num6 + num32 * Math.Sin(num17) + num29 - num81 - num82;
					num46 = num44 + num88 - 2.0 * num83;
					num47 = num45;
					val2.DrawLine(val5, (float)num44, (float)num45, (float)num46, (float)num47);
					num46 = num44;
					num47 = num45 - num85;
					val2.DrawLine(val5, (float)num44, (float)num45, (float)num46, (float)num47);
					num44 += num88 - 2.0 * num83;
					num46 = num44;
					num47 = num45 - num85;
					val2.DrawLine(val5, (float)num44, (float)num45, (float)num46, (float)num47);
					num45 = num47;
					num46 = num44 - (num88 - 2.0 * num83);
					val2.DrawLine(val5, (float)num44, (float)num45, (float)num46, (float)num47);
					double num89 = 1.5;
					double num90 = 0.0;
					double num91 = 0.0;
					double num92 = 0.0;
					double num93 = 0.0;
					num80 = num74 * num89;
					num81 = num75 * num89;
					num76 = num70 * num89;
					num77 = num71 * num89;
					num78 = num72 * num89;
					num79 = num73 * num89;
					num92 = num - num4;
					num93 = (double)num27 + num24 * num18 + 40.0;
					num90 = (double)(num - num4) - num76;
					num91 = num93 + num81;
					num44 = num90;
					num45 = num91;
					num46 = num44 + num76;
					num47 = num45;
					val2.DrawLine(val5, (float)num44, (float)num45, (float)num46, (float)num47);
					num44 = num90;
					num45 = num91;
					num46 = num44;
					num47 = num45 + (double)num15;
					num50 = num46;
					num51 = num47;
					val2.DrawLine(val3, (float)num44, (float)num45, (float)num46, (float)num47);
					num44 += num76;
					num46 = num44;
					num94 = num46;
					num95 = num47;
					val2.DrawLine(val3, (float)num44, (float)num45, (float)num46, (float)num47);
					num44 = num50;
					num45 = num51 - 5.0;
					num46 = num94;
					num47 = num95 - 5.0;
					DrawRows(num44, num45, num46, num47, num18, val2, val3);
					num48 = (num50 + num94) / 2.0;
					num49 = num51 + (double)num21;
					#if WINDOWS

					val9.FormatFlags = (StringFormatFlags)1;

					#endif
					val2.DrawString(num70.ToString(), val7, (Brush)(object)val8, (float)num48, (float)num49, val9);
					num44 = num90 + num76;
					num45 = num91;
					num46 = num44;
					num47 = num45 - num77;
					val2.DrawLine(val5, (float)num44, (float)num45, (float)num46, (float)num47);
					num44 = num90;
					num45 = num91;
					num46 = num44;
					num47 = num45 - num77;
					val2.DrawLine(val5, (float)num44, (float)num45, (float)num46, (float)num47);
					num46 = num44 - (double)num15;
					num47 = num45;
					val2.DrawLine(val3, (float)num44, (float)num45, (float)num46, (float)num47);
					num45 = num91 - num77;
					num46 = num44 - (double)num15;
					num47 = num45;
					val2.DrawLine(val3, (float)num44, (float)num45, (float)num46, (float)num47);
					num44 = num46 + 5.0;
					num45 = num91;
					num46 = num44;
					num47 = num45 - num77;
					DrawRows(num44, num45, num46, num47, num18, val2, val3);
					num48 = num44 - (double)num21 - 3.0;
					num49 = (num45 + num47) / 2.0;
					#if WINDOWS

					val9.FormatFlags = (StringFormatFlags)1;

					#endif
					val2.DrawString(num71.ToString(), val7, (Brush)(object)val8, (float)num48, (float)num49, val9);
					num44 = num92 - num76 - 2.0 * num79;
					num45 = num93;
					num46 = num44;
					num47 = num45 + num78;
					val2.DrawLine(val5, (float)num44, (float)num45, (float)num46, (float)num47);
					num44 = num92 - num76 - 2.0 * num79;
					num45 = num93;
					num46 = num44;
					num47 = num45 + num78;
					val2.DrawLine(val5, (float)num44, (float)num45, (float)num46, (float)num47);
					num46 = num44 - (double)num15;
					num47 = num45;
					val2.DrawLine(val3, (float)num44, (float)num45, (float)num46, (float)num47);
					num44 = num92 - num76 - 2.0 * num79;
					num45 = num93 + num78;
					num46 = num44 - (double)num15;
					num47 = num45;
					val2.DrawLine(val3, (float)num44, (float)num45, (float)num46, (float)num47);
					num44 = num46 + 5.0;
					num45 = num93;
					num46 = num44;
					num47 = num45 + num78;
					DrawRows(num44, num45, num46, num47, num18, val2, val3);
					num48 = num44 - (double)num21 - 3.0;
					num49 = (num45 + num47) / 2.0;
					#if WINDOWS

					val9.FormatFlags = (StringFormatFlags)1;

					#endif
					val2.DrawString(num72.ToString(), val7, (Brush)(object)val8, (float)num48, (float)num49, val9);
					num44 = num92 - num76 - 2.0 * num79;
					num45 = num93 + num78;
					num46 = num44 + num79;
					num47 = num45;
					val2.DrawLine(val5, (float)num44, (float)num45, (float)num46, (float)num47);
					num46 = num44;
					num47 = num45 + (double)num15;
					val2.DrawLine(val3, (float)num44, (float)num45, (float)num46, (float)num47);
					num44 = num46 + num79;
					num46 = num44;
					val2.DrawLine(val3, (float)num44, (float)num45, (float)num46, (float)num47);
					num44 = num92 - num76 - 2.0 * num79;
					num45 = num93 + num78 + (double)num15 - 5.0;
					num46 = num44 + num79;
					num47 = num45;
					DrawRows(num46, num47, num44, num45, num18, val2, val3);
					num48 = (num44 + num46) / 2.0;
					num49 = num45 + (double)num21;
					#if WINDOWS

					val9.FormatFlags = (StringFormatFlags)1;

					#endif
					val2.DrawString(num73.ToString(), val7, (Brush)(object)val8, (float)num48, (float)num49, val9);
				}
				else
				{
					int num96 = 130;
					int num97 = (L + a) / 2 - num96;
					if (num97 <= 550)
					{
						nFiltr = 1;
						kFiltr[0] = 400;
					}
					else if (num97 <= 650)
					{
						nFiltr = 1;
						kFiltr[0] = 500;
					}
					else if (num97 <= 675)
					{
						nFiltr = 1;
						kFiltr[0] = 600;
					}
					else if (num97 <= 750)
					{
						nFiltr = 2;
						kFiltr[0] = 300;
						kFiltr[1] = 300;
					}
					else if (num97 <= 850)
					{
						nFiltr = 2;
						kFiltr[0] = 300;
						kFiltr[1] = 400;
					}
					else if (num97 <= 950)
					{
						nFiltr = 2;
						kFiltr[0] = 400;
						kFiltr[1] = 400;
					}
					else if (num97 <= 1050)
					{
						nFiltr = 2;
						kFiltr[0] = 400;
						kFiltr[1] = 500;
					}
					else if (num97 <= 1150)
					{
						nFiltr = 2;
						kFiltr[0] = 500;
						kFiltr[1] = 500;
					}
					else if (num97 <= 1250)
					{
						nFiltr = 2;
						kFiltr[0] = 500;
						kFiltr[1] = 600;
					}
					else if (num97 <= 1350)
					{
						nFiltr = 2;
						kFiltr[0] = 600;
						kFiltr[1] = 600;
					}
					else if (num97 <= 1450)
					{
						nFiltr = 3;
						kFiltr[0] = 400;
						kFiltr[1] = 400;
						kFiltr[2] = 500;
					}
					else if (num97 <= 1550)
					{
						nFiltr = 3;
						kFiltr[0] = 400;
						kFiltr[1] = 500;
						kFiltr[2] = 500;
					}
					else if (num97 <= 1650)
					{
						nFiltr = 3;
						kFiltr[0] = 500;
						kFiltr[1] = 500;
						kFiltr[2] = 500;
					}
					else if (num97 <= 1750)
					{
						nFiltr = 3;
						kFiltr[0] = 500;
						kFiltr[1] = 500;
						kFiltr[2] = 600;
					}
					else if (num97 <= 1850)
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
					L1 = num96;
					for (int i = 0; i < nFiltr; i++)
					{
						L1 += kFiltr[i];
					}
					kk = L1;
					if (!(L1 > (double)a))
					{
						return;
					}
					double num98 = (L1 - (double)a) * ((double)H - (double)h) / ((double)L - (double)a);
					double num99 = ((double)B - (double)b) * num98 / ((double)H - (double)h) + (double)b;
					int num100 = 70;
					l = (int)num99 - num100;
					double num101 = num98 * num18;
					double num102 = (double)l * num18;
					double num103 = (double)num100 * num18;
					double num104 = 40.0;
					double num105 = num104 * num18;
					num44 = (double)num3 + num35 * (1.0 - num101 / (num29 - num31)) + num103 / 2.0;
					num45 = (double)num6 + num32 * Math.Sin(num17) + num101;
					num46 = num44 + num102;
					num47 = num45;
					val2.DrawLine(val5, (float)num44, (float)num45, (float)num46, (float)num47);
					num46 = num44;
					num47 = num45 + num105;
					val2.DrawLine(val5, (float)num44, (float)num45, (float)num46, (float)num47);
					num44 = num46;
					num45 = num47;
					num46 = num44 + num102;
					val2.DrawLine(val5, (float)num44, (float)num45, (float)num46, (float)num47);
					num44 = num46;
					num47 = num45 - num105;
					val2.DrawLine(val5, (float)num44, (float)num45, (float)num46, (float)num47);
					num44 = (double)num3 + num35 * (1.0 - num101 / (num29 - num31)) + num103 / 2.0;
					num45 = (double)num6 + num32 * Math.Sin(num17) + num101;
					num46 = num44 - num103;
					num47 = num45;
					val2.DrawLine(val3, (float)num44, (float)num45, (float)num46, (float)num47);
					num44 = (double)num3 + num35 - num103 / 2.0 + 5.0;
					num45 = (double)num6 + num32 * Math.Sin(num17);
					num46 = num44;
					num47 = num45 + num101;
					DrawRows(num44, num45, num46, num47, num18, val2, val3);
					num48 = num44 - (double)num21;
					num49 = (num45 + num47) / 2.0;
					#if WINDOWS

					val9.FormatFlags = (StringFormatFlags)2;

					#endif
					val2.DrawString(Math.Round(num98, MidpointRounding.AwayFromZero).ToString(), val7, (Brush)(object)val8, (float)num48, (float)num49, val9);
				}
			}
			num19 = ((double)(2 * num / 3) - num8 - (double)num4) / (double)L;
			num9 = num27 + (int)(num24 * num18) + 70;
			int num106 = 0;
			num9 += (double)num15;
			if (num19 * (double)B + (double)(3 * num15) + (double)num106 > (double)num2 / 3.0)
			{
				num19 = ((double)num2 / 3.0 - (double)(3 * num15) - (double)num106) / (double)B;
			}
			num28 = (double)L * num19;
			num30 = (double)B * num19;
			num34 = c * num19;
			num35 = c1 * num19;
			num32 = (double)a * num19;
			num33 = (double)b * num19;
			num44 = num8;
			num45 = num9;
			num46 = num44 + num28;
			num47 = num45;
			val2.DrawLine(val4, (float)num44, (float)num45, (float)num46, (float)num47);
			num44 = num46;
			num45 = num47;
			num46 = num44;
			num47 = num45 + num30;
			val2.DrawLine(val4, (float)num44, (float)num45, (float)num46, (float)num47);
			num44 = num8;
			num45 = num9;
			num46 = num44;
			num47 = num45 + num30;
			val2.DrawLine(val4, (float)num44, (float)num45, (float)num46, (float)num47);
			num44 = num8;
			num45 = num9 + num30;
			num46 = num44 + num28;
			num47 = num45;
			val2.DrawLine(val4, (float)num44, (float)num45, (float)num46, (float)num47);
			num44 = num8 + num28;
			num45 = num9 + num30;
			num46 = num44 + (double)num14;
			num47 = num45;
			num94 = num46;
			num95 = num47;
			val2.DrawLine(val3, (float)num44, (float)num45, (float)num46, (float)num47);
			num44 = num8 + num28;
			num45 = num9;
			num46 = num44 + (double)num14;
			num47 = num45;
			num50 = num46;
			num51 = num47;
			val2.DrawLine(val3, (float)num44, (float)num45, (float)num46, (float)num47);
			num44 = num50 - 5.0;
			num45 = num51;
			num46 = num94 - 5.0;
			num47 = num95;
			DrawRows(num44, num45, num46, num47, num19, val2, val3);
			num48 = num44 + (double)num21;
			num49 = (num51 + num95) / 2.0;
			#if WINDOWS

			val9.FormatFlags = (StringFormatFlags)2;

			#endif
			val2.DrawString(B.ToString(), val7, (Brush)(object)val8, (float)num48, (float)num49, val9);
			num44 = num8;
			num45 = num9;
			num46 = num44 - (double)num14;
			num47 = num45;
			num94 = num46;
			num95 = num47;
			val2.DrawLine(val3, (float)num44, (float)num45, (float)num46, (float)num47);
			num44 = num8 + num34;
			num45 = num9 + num35;
			num47 = num45;
			num50 = num46;
			num51 = num47;
			val2.DrawLine(val3, (float)num44, (float)num45, (float)num46, (float)num47);
			num44 = num50 + 5.0;
			num45 = num51;
			num46 = num94 + 5.0;
			num47 = num95;
			DrawRows(num46, num47, num44, num45, num19, val2, val3);
			num48 = num44 - (double)num21;
			num49 = (num51 + num95) / 2.0;
			#if WINDOWS

			val9.FormatFlags = (StringFormatFlags)2;

			#endif
			val2.DrawString(c1.ToString(), val7, (Brush)(object)val8, (float)num48, (float)num49, val9);
			num44 = num8;
			num45 = num9 + num30;
			num46 = num44;
			num47 = num45 + (double)num14;
			num50 = num46;
			num51 = num47;
			val2.DrawLine(val3, (float)num44, (float)num45, (float)num46, (float)num47);
			num44 = num8 + num28;
			num45 = num9 + num30;
			num46 = num44;
			num47 = num45 + (double)num14;
			num94 = num46;
			num95 = num47;
			val2.DrawLine(val3, (float)num44, (float)num45, (float)num46, (float)num47);
			num44 = num50;
			num45 = num51 - 5.0;
			num46 = num94;
			num47 = num95 - 5.0;
			DrawRows(num44, num45, num46, num47, num19, val2, val3);
			num48 = (num50 + num94) / 2.0;
			num49 = (num51 + num95) / 2.0 + (double)num21;
			#if WINDOWS

			val9.FormatFlags = (StringFormatFlags)1;

			#endif
			val2.DrawString(L.ToString(), val7, (Brush)(object)val8, (float)num48, (float)num49, val9);
			num44 = num8;
			num45 = num9;
			num46 = num44;
			num47 = num45 - (double)num14;
			num50 = num46;
			num51 = num47;
			val2.DrawLine(val3, (float)num44, (float)num45, (float)num46, (float)num47);
			num44 = num8 + num34;
			num45 = num9 + num35;
			num46 = num44;
			num47 = num9 - (double)num14;
			num94 = num46;
			num95 = num47;
			val2.DrawLine(val3, (float)num44, (float)num45, (float)num46, (float)num47);
			num44 = num50;
			num45 = num51 + 5.0;
			num46 = num94;
			num47 = num95 + 5.0;
			DrawRows(num44, num45, num46, num47, num19, val2, val3);
			num48 = (num50 + num94) / 2.0;
			num49 = (num51 + num95) / 2.0 - (double)num21;
			#if WINDOWS

			val9.FormatFlags = (StringFormatFlags)1;

			#endif
			val2.DrawString(c.ToString(), val7, (Brush)(object)val8, (float)num48, (float)num49, val9);
			num44 = num8 + num34;
			num45 = num9 + num35;
			num46 = num44 + num32;
			num47 = num45;
			val2.DrawLine(val4, (float)num44, (float)num45, (float)num46, (float)num47);
			num46 = num44;
			num47 = num45 + num33;
			val2.DrawLine(val4, (float)num44, (float)num45, (float)num46, (float)num47);
			num44 = num46;
			num45 = num47;
			num46 = num44 + num32;
			num47 = num45;
			val2.DrawLine(val4, (float)num44, (float)num45, (float)num46, (float)num47);
			num44 = num46;
			num47 -= num33;
			val2.DrawLine(val4, (float)num44, (float)num45, (float)num46, (float)num47);
			num44 = num8;
			num45 = num9;
			num46 = num44 + num34;
			num47 = num45 + num35;
			val2.DrawLine(val4, (float)num44, (float)num45, (float)num46, (float)num47);
			num44 = num8;
			num45 = num9 + num30;
			num46 = num44 + num34;
			num47 = num45 - (num30 - num35 - num33);
			val2.DrawLine(val4, (float)num44, (float)num45, (float)num46, (float)num47);
			num44 = num8 + num28;
			num45 = num9;
			num46 = num44 - (num28 - num34 - num32);
			num47 = num45 + num35;
			val2.DrawLine(val4, (float)num44, (float)num45, (float)num46, (float)num47);
			num44 = num8 + num28;
			num45 = num9 + num30;
			num46 = num44 - (num28 - num34 - num32);
			num47 = num45 - (num30 - num35 - num33);
			val2.DrawLine(val4, (float)num44, (float)num45, (float)num46, (float)num47);
			num8 += num34;
			num9 += num35;
			num12 = num3;
			num13 = num27 + (int)(num24 * num18) + 70;
			num13 += num2 / 3 + 20;
			int num107 = 10;
			int num108 = 0;
			Font val10 = new Font("Arial", (float)num107);
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
						val2.DrawString("Ширина першого жирфільтра: " + kFiltr[0] + "мм * 2шт", val10, (Brush)(object)val8, (float)num12, (float)(num13 + num108), val11);
						break;
					case 1:
						val2.DrawString("Ширина другого жирфільтра: " + kFiltr[1] + "мм * 2шт", val10, (Brush)(object)val8, (float)num12, (float)(num13 + num108), val11);
						break;
					case 2:
						val2.DrawString("Ширина третього жирфільтра: " + kFiltr[2] + "мм * 2шт", val10, (Brush)(object)val8, (float)num12, (float)(num13 + num108), val11);
						break;
					}
					num108 += num107 + 8;
					if (num13 + num108 > num2 - num7)
					{
						num12 = num3 + num / 2;
						num108 = 0;
					}
				}
				if (nFiltr == 1)
				{
					val2.DrawString("Довжина жирфільтра: " + l + "мм", val10, (Brush)(object)val8, (float)num12, (float)(num13 + num108), val11);
				}
				else
				{
					val2.DrawString("Довжина жирфільтрів: " + l + "мм", val10, (Brush)(object)val8, (float)num12, (float)(num13 + num108), val11);
				}
				num108 += num107 + 8;
				if (num13 + num108 > num2 - num7)
				{
					num12 = num3 + num / 2;
					num108 = 0;
				}
			}
			val2.DrawString("Матеріал зонта: " + zontMaterial, val10, (Brush)(object)val8, (float)num12, (float)(num13 + num108), val11);
			num108 += num107 + 8;
			if (num13 + num108 > num2 - num7)
			{
				num12 = num3 + num / 2;
				num108 = 0;
			}
			val2.DrawString("Товщина металу зонта: " + tovchynaMetaluZont + "мм", val10, (Brush)(object)val8, (float)num12, (float)(num13 + num108), val11);
			num108 += num107 + 8;
			if (num13 + num108 > num2 - num7)
			{
				num12 = num3 + num / 2;
				num108 = 0;
			}
			val2.DrawString("З'єднання: " + connection, val10, (Brush)(object)val8, (float)num12, (float)(num13 + num108), val11);
			num108 += num107 + 8;
			if (num13 + num108 > num2 - num7)
			{
				num12 = num3 + num / 2;
				num108 = 0;
			}
			val2.DrawString("Трубка зливу 1/2': " + zlyv, val10, (Brush)(object)val8, (float)num12, (float)(num13 + num108), val11);
			num108 += num107 + 8;
			if (num13 + num108 > num2 - num7)
			{
				num12 = num3 + num / 2;
				num108 = 0;
			}
			val2.DrawString("Кріплення: " + fastening, val10, (Brush)(object)val8, (float)num12, (float)(num13 + num108), val11);
			if (fastening == "так")
			{
				num108 += num107 + 8;
				if (num13 + num108 > num2 - num7)
				{
					num12 = num3 + num / 2;
					num108 = 0;
				}
				val2.DrawString("Тип кріплення: " + typeFastening, val10, (Brush)(object)val8, (float)num12, (float)(num13 + num108), val11);
			}
			if (zhyrFiltr == "так")
			{
				num108 += num107 + 8;
				if (num13 + num108 > num2 - num7)
				{
					num12 = num3 + num / 2;
					num108 = 0;
				}
				val2.DrawString("Матеріал жирфільтра: " + zhyrFiltrMaterial, val10, (Brush)(object)val8, (float)num12, (float)(num13 + num108), val11);
				num108 += num107 + 8;
				if (num13 + num108 > num2 - num7)
				{
					num12 = num3 + num / 2;
					num108 = 0;
				}
				val2.DrawString("Товщина металу жирфільтра: " + tovchynaMetaluFiltr + "мм", val10, (Brush)(object)val8, (float)num12, (float)(num13 + num108), val11);
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

	public static double VolumeZontOstrivnyyTyp31(int L, int B, int H)
	{
		return Math.Round((double)L * (double)B * (double)(H + 25) / 1000000.0) / 1000.0;
	}
}
