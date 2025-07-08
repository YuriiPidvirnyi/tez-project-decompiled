using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using TEZ_Project.Common.Enums;
using TEZ_Project.Common.Models;
using TEZ_Project.Common.Products;
using TEZ_Project.Common.Products.ZontVytyazhnyy;

namespace TEZ_Project.Common.Helpers;

public static class ZontVytiajniyHelper
{
	public static void ZontyVytiajni_SaveFiles(List<IProduct> data, string filePathForSaving, string orderCode, string contragent)
	{
		ZontPrystinnyyTyp1_SaveFiles(data, filePathForSaving, orderCode, contragent);
		ZontPrystinnyyTyp2_SaveFiles(data, filePathForSaving, orderCode, contragent);
		ZontPrystinnyyTyp3_SaveFiles(data, filePathForSaving, orderCode, contragent);
		ZontPrystinnyyTyp31_SaveFiles(data, filePathForSaving, orderCode, contragent);
		ZontPrystinnyyTyp4_SaveFiles(data, filePathForSaving, orderCode, contragent);
		ZontOstrivnyyTyp1_SaveFiles(data, filePathForSaving, orderCode, contragent);
		ZontOstrivnyyTyp2_SaveFiles(data, filePathForSaving, orderCode, contragent);
		ZontOstrivnyyTyp3_SaveFiles(data, filePathForSaving, orderCode, contragent);
		ZontOstrivnyyTyp31_SaveFiles(data, filePathForSaving, orderCode, contragent);
		ZontOstrivnyyTyp4_SaveFiles(data, filePathForSaving, orderCode, contragent);
	}

	public static void ZontVytiajniy_TypVyhidCbox_SelectionChanged(ComboBox typVyhidCb, ComboBox vyhidCb, ComboBox profilTypeCb, Label profilTypeLbl)
	{
		string text = typVyhidCb?.GetValue();
		string text2 = vyhidCb?.GetValue();
		if (string.IsNullOrEmpty(text2) || string.IsNullOrEmpty(text))
		{
			return;
		}
		if (text == "фланець")
		{
			((UIElement)profilTypeCb).Visibility = (Visibility)0;
			((UIElement)profilTypeLbl).Visibility = (Visibility)0;
			if (text2 == "круглий")
			{
				((ItemsControl)profilTypeCb).Items.Add((object)"Лист Ст 3 3мм");
				((ItemsControl)profilTypeCb).Items.Add((object)"Кутник 25х25х3");
				((ItemsControl)profilTypeCb).Items.Add((object)"Кутник 32х32х3");
				((ItemsControl)profilTypeCb).Items.Add((object)"Кутник 35х35х4");
			}
			else
			{
				((ItemsControl)profilTypeCb).Items.Add((object)"S - 20");
				((ItemsControl)profilTypeCb).Items.Add((object)"S - 20 нерж");
			}
		}
		else
		{
			((Selector)profilTypeCb).SelectedItem = null;
			((ItemsControl)profilTypeCb).Items.Clear();
			((UIElement)profilTypeCb).Visibility = (Visibility)2;
			((UIElement)profilTypeLbl).Visibility = (Visibility)2;
		}
	}

	public static ZontVytyazhnyyComplex_ImageType ZontVytiajniy_Complex_GetImageType(ComboBox zhyrFiltrCb, TextBox BCb, string vyhid1Str, string vyhid2Str, string vyhid3Str)
	{
		string value = zhyrFiltrCb.GetValue();
		bool flag = value == "так";
		bool flag2 = BCb.GetIntValueOrDefault() > 790;
		if (!string.IsNullOrEmpty(vyhid1Str))
		{
			if (vyhid1Str == "круглий")
			{
				if (string.IsNullOrEmpty(vyhid2Str))
				{
					return (!flag) ? ZontVytyazhnyyComplex_ImageType.V100 : (flag2 ? ZontVytyazhnyyComplex_ImageType.V100ZF2 : ZontVytyazhnyyComplex_ImageType.V100ZF);
				}
				if (vyhid2Str == "круглий")
				{
					if (string.IsNullOrEmpty(vyhid3Str))
					{
						return (!flag) ? ZontVytyazhnyyComplex_ImageType.V110 : (flag2 ? ZontVytyazhnyyComplex_ImageType.V110ZF2 : ZontVytyazhnyyComplex_ImageType.V110ZF);
					}
					if (vyhid3Str == "круглий")
					{
						return (!flag) ? ZontVytyazhnyyComplex_ImageType.V111 : (flag2 ? ZontVytyazhnyyComplex_ImageType.V111ZF2 : ZontVytyazhnyyComplex_ImageType.V111ZF);
					}
					if (vyhid3Str == "прямокутний")
					{
						return (!flag) ? ZontVytyazhnyyComplex_ImageType.V112 : (flag2 ? ZontVytyazhnyyComplex_ImageType.V112ZF2 : ZontVytyazhnyyComplex_ImageType.V112ZF);
					}
				}
				else if (vyhid2Str == "прямокутний")
				{
					if (string.IsNullOrEmpty(vyhid3Str))
					{
						return (!flag) ? ZontVytyazhnyyComplex_ImageType.V120 : (flag2 ? ZontVytyazhnyyComplex_ImageType.V120ZF2 : ZontVytyazhnyyComplex_ImageType.V120ZF);
					}
					if (vyhid3Str == "круглий")
					{
						return (!flag) ? ZontVytyazhnyyComplex_ImageType.V121 : (flag2 ? ZontVytyazhnyyComplex_ImageType.V121ZF2 : ZontVytyazhnyyComplex_ImageType.V121ZF);
					}
					if (vyhid3Str == "прямокутний")
					{
						return (!flag) ? ZontVytyazhnyyComplex_ImageType.V122 : (flag2 ? ZontVytyazhnyyComplex_ImageType.V122ZF2 : ZontVytyazhnyyComplex_ImageType.V122ZF);
					}
				}
			}
			else if (vyhid1Str == "прямокутний")
			{
				if (string.IsNullOrEmpty(vyhid2Str))
				{
					return (!flag) ? ZontVytyazhnyyComplex_ImageType.V200 : (flag2 ? ZontVytyazhnyyComplex_ImageType.V200ZF2 : ZontVytyazhnyyComplex_ImageType.V200ZF);
				}
				if (vyhid2Str == "круглий")
				{
					if (string.IsNullOrEmpty(vyhid3Str))
					{
						return (!flag) ? ZontVytyazhnyyComplex_ImageType.V210 : (flag2 ? ZontVytyazhnyyComplex_ImageType.V210ZF2 : ZontVytyazhnyyComplex_ImageType.V210ZF);
					}
					if (vyhid3Str == "круглий")
					{
						return (!flag) ? ZontVytyazhnyyComplex_ImageType.V211 : (flag2 ? ZontVytyazhnyyComplex_ImageType.V211ZF2 : ZontVytyazhnyyComplex_ImageType.V211ZF);
					}
					if (vyhid3Str == "прямокутний")
					{
						return (!flag) ? ZontVytyazhnyyComplex_ImageType.V212 : (flag2 ? ZontVytyazhnyyComplex_ImageType.V212ZF2 : ZontVytyazhnyyComplex_ImageType.V212ZF);
					}
				}
				else if (vyhid2Str == "прямокутний")
				{
					if (string.IsNullOrEmpty(vyhid3Str))
					{
						return (!flag) ? ZontVytyazhnyyComplex_ImageType.V220 : (flag2 ? ZontVytyazhnyyComplex_ImageType.V220ZF2 : ZontVytyazhnyyComplex_ImageType.V220ZF);
					}
					if (vyhid3Str == "круглий")
					{
						return (!flag) ? ZontVytyazhnyyComplex_ImageType.V221 : (flag2 ? ZontVytyazhnyyComplex_ImageType.V221ZF2 : ZontVytyazhnyyComplex_ImageType.V221ZF);
					}
					if (vyhid3Str == "прямокутний")
					{
						return (!flag) ? ZontVytyazhnyyComplex_ImageType.V222 : (flag2 ? ZontVytyazhnyyComplex_ImageType.V222ZF2 : ZontVytyazhnyyComplex_ImageType.V222ZF);
					}
				}
			}
		}
		return flag ? ((!flag2) ? ZontVytyazhnyyComplex_ImageType.SimpleZF : ZontVytyazhnyyComplex_ImageType.SimpleZF2) : ZontVytyazhnyyComplex_ImageType.Simple;
	}

	public static string ZontVytiajniy_Complex_GetImageNumber(ZontVytyazhnyyComplex_ImageType imageType)
	{
		switch (imageType)
		{
		case ZontVytyazhnyyComplex_ImageType.Simple:
		case ZontVytyazhnyyComplex_ImageType.SimpleZF:
		case ZontVytyazhnyyComplex_ImageType.SimpleZF2:
			return "000";
		case ZontVytyazhnyyComplex_ImageType.V100:
		case ZontVytyazhnyyComplex_ImageType.V100ZF:
		case ZontVytyazhnyyComplex_ImageType.V100ZF2:
			return "100";
		case ZontVytyazhnyyComplex_ImageType.V110:
		case ZontVytyazhnyyComplex_ImageType.V110ZF:
		case ZontVytyazhnyyComplex_ImageType.V110ZF2:
			return "110";
		case ZontVytyazhnyyComplex_ImageType.V111:
		case ZontVytyazhnyyComplex_ImageType.V111ZF:
		case ZontVytyazhnyyComplex_ImageType.V111ZF2:
			return "111";
		case ZontVytyazhnyyComplex_ImageType.V112:
		case ZontVytyazhnyyComplex_ImageType.V112ZF:
		case ZontVytyazhnyyComplex_ImageType.V112ZF2:
			return "112";
		case ZontVytyazhnyyComplex_ImageType.V120:
		case ZontVytyazhnyyComplex_ImageType.V120ZF:
		case ZontVytyazhnyyComplex_ImageType.V120ZF2:
			return "120";
		case ZontVytyazhnyyComplex_ImageType.V121:
		case ZontVytyazhnyyComplex_ImageType.V121ZF:
		case ZontVytyazhnyyComplex_ImageType.V121ZF2:
			return "121";
		case ZontVytyazhnyyComplex_ImageType.V122:
		case ZontVytyazhnyyComplex_ImageType.V122ZF:
		case ZontVytyazhnyyComplex_ImageType.V122ZF2:
			return "122";
		case ZontVytyazhnyyComplex_ImageType.V200:
		case ZontVytyazhnyyComplex_ImageType.V200ZF:
		case ZontVytyazhnyyComplex_ImageType.V200ZF2:
			return "200";
		case ZontVytyazhnyyComplex_ImageType.V210:
		case ZontVytyazhnyyComplex_ImageType.V210ZF:
		case ZontVytyazhnyyComplex_ImageType.V210ZF2:
			return "210";
		case ZontVytyazhnyyComplex_ImageType.V211:
		case ZontVytyazhnyyComplex_ImageType.V211ZF:
		case ZontVytyazhnyyComplex_ImageType.V211ZF2:
			return "211";
		case ZontVytyazhnyyComplex_ImageType.V212:
		case ZontVytyazhnyyComplex_ImageType.V212ZF:
		case ZontVytyazhnyyComplex_ImageType.V212ZF2:
			return "212";
		case ZontVytyazhnyyComplex_ImageType.V220:
		case ZontVytyazhnyyComplex_ImageType.V220ZF:
		case ZontVytyazhnyyComplex_ImageType.V220ZF2:
			return "220";
		case ZontVytyazhnyyComplex_ImageType.V221:
		case ZontVytyazhnyyComplex_ImageType.V221ZF:
		case ZontVytyazhnyyComplex_ImageType.V221ZF2:
			return "221";
		case ZontVytyazhnyyComplex_ImageType.V222:
		case ZontVytyazhnyyComplex_ImageType.V222ZF:
		case ZontVytyazhnyyComplex_ImageType.V222ZF2:
			return "222";
		default:
			return string.Empty;
		}
	}

	public static void ZontVytyazhnyy_ThicknessOfMetalSetValues(ComboBox markaStaliCb, ComboBox thicknessOfMetalCbox)
	{
		if (thicknessOfMetalCbox != null && markaStaliCb != null)
		{
			((ItemsControl)thicknessOfMetalCbox).Items.Clear();
			string value = markaStaliCb.GetValue();
			string numberDecimalSeparator = CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator;
			((UIElement)thicknessOfMetalCbox).IsEnabled = true;
			string text = value;
			string text2 = text;
			if (text2 == "Оцинковка")
			{
				((ItemsControl)thicknessOfMetalCbox).Items.Add((object)("0" + numberDecimalSeparator + "5"));
				((ItemsControl)thicknessOfMetalCbox).Items.Add((object)("0" + numberDecimalSeparator + "65"));
				((ItemsControl)thicknessOfMetalCbox).Items.Add((object)("0" + numberDecimalSeparator + "68"));
				((ItemsControl)thicknessOfMetalCbox).Items.Add((object)("0" + numberDecimalSeparator + "7"));
				((ItemsControl)thicknessOfMetalCbox).Items.Add((object)("0" + numberDecimalSeparator + "9"));
				((ItemsControl)thicknessOfMetalCbox).Items.Add((object)("1" + numberDecimalSeparator + "0"));
				((ItemsControl)thicknessOfMetalCbox).Items.Add((object)("1" + numberDecimalSeparator + "2"));
			}
			else
			{
				((ItemsControl)thicknessOfMetalCbox).Items.Add((object)("0" + numberDecimalSeparator + "5"));
				((ItemsControl)thicknessOfMetalCbox).Items.Add((object)("0" + numberDecimalSeparator + "8"));
				((ItemsControl)thicknessOfMetalCbox).Items.Add((object)("1" + numberDecimalSeparator + "0"));
			}
			((Selector)thicknessOfMetalCbox).SelectedIndex = 0;
		}
	}

	public static string ZontVytyazhnyy_GetName(string zontType, int L, int B, int H, string zhyrFiltrStr)
	{
		return (zhyrFiltrStr == "ні") ? $"Зонт {zontType} {L}x{B}x{H}" : $"Зонт {zontType} {L}x{B}x{H} з ж/ф";
	}

	public static bool ZontVytyazhnyy_HasZhyrFiltr(ComboBox zhyrFiltrCb)
	{
		return zhyrFiltrCb.GetValue() == "так";
	}

	private static void ZontPrystinnyyTyp1_SaveFiles(List<IProduct> data, string filePathForSaving, string orderCode, string contragent)
	{
		//IL_0257: Unknown result type (might be due to invalid IL or missing references)
		List<Product_ZontPrystinnyyTyp1> list = Enumerable.ToList<Product_ZontPrystinnyyTyp1>(Enumerable.Select<IProduct, Product_ZontPrystinnyyTyp1>(Enumerable.Where<IProduct>((IEnumerable<IProduct>)data, (Func<IProduct, bool>)((IProduct x) => x is Product_ZontPrystinnyyTyp1)), (Func<IProduct, Product_ZontPrystinnyyTyp1>)((IProduct x) => x as Product_ZontPrystinnyyTyp1)));
		if (!Enumerable.Any<Product_ZontPrystinnyyTyp1>((IEnumerable<Product_ZontPrystinnyyTyp1>)list))
		{
			return;
		}
		string filePathForZontPrystinnyyDxfAndImage = GetFilePathForZontPrystinnyyDxfAndImage(filePathForSaving);
		foreach (Product_ZontPrystinnyyTyp1 item in list)
		{
			string text = (string.IsNullOrEmpty(orderCode) ? string.Empty : ("Замовлення_" + orderCode + "_"));
			string filePath = filePathForZontPrystinnyyDxfAndImage + $"{text}_{item.Order}_Зонт ЗВП-1 {item.L}x{item.B}x{item.H}";
			try
			{
				ZontPrystinnyyTyp1DrawDxf(item, filePath);
				ZontPrystinnyyTyp1.ZontPrystinnyyTyp1DrawImage(item.L, item.B, item.H, item.h, item.b, item.Amount, item.MarkaStali, item.ThicknessOfMetal, item.Connection, item.Zlyv, item.Fastening, item.Vyhid, item.Vyhid1, item.d1, item.a1, item.b1, item.p1, item.f1, item.g1, item.TypVyhid1, item.ProfilType1, item.Vyhid2, item.d2, item.a2, item.b2, item.p2, item.f2, item.g2, item.TypVyhid2, item.ProfilType2, item.Vyhid3, item.d3, item.a3, item.b3, item.p3, item.f3, item.g3, item.TypVyhid3, item.ProfilType3, item.ZhyrFiltr, item.G, item.MarkaStaliFiltr, item.ThicknessOfMetalFiltr, item.FasteningType, orderCode, contragent, filePath);
				ZontPrystinnyyTyp1DrawDxf(item, filePath);
			}
			catch
			{
				MessageBox.Show("Не змогло створити креслення для Зонт ЗВП-1");
			}
		}
	}

	private static void ZontPrystinnyyTyp1DrawDxf(Product_ZontPrystinnyyTyp1 zontPrystinnyyTyp1, string filePath)
	{
		ZontPrystinnyyTyp1.ZontPrystinnyyTyp1DrawDxf(zontPrystinnyyTyp1.L, zontPrystinnyyTyp1.B, zontPrystinnyyTyp1.H, zontPrystinnyyTyp1.h, zontPrystinnyyTyp1.b, zontPrystinnyyTyp1.Connection, zontPrystinnyyTyp1.Zlyv, zontPrystinnyyTyp1.Vyhid, zontPrystinnyyTyp1.Vyhid1, zontPrystinnyyTyp1.d1, zontPrystinnyyTyp1.a1, zontPrystinnyyTyp1.b1, zontPrystinnyyTyp1.f1, zontPrystinnyyTyp1.g1, zontPrystinnyyTyp1.TypVyhid1, zontPrystinnyyTyp1.Vyhid2, zontPrystinnyyTyp1.d2, zontPrystinnyyTyp1.a2, zontPrystinnyyTyp1.b2, zontPrystinnyyTyp1.f2, zontPrystinnyyTyp1.g2, zontPrystinnyyTyp1.TypVyhid2, zontPrystinnyyTyp1.Vyhid3, zontPrystinnyyTyp1.d3, zontPrystinnyyTyp1.a3, zontPrystinnyyTyp1.b3, zontPrystinnyyTyp1.f3, zontPrystinnyyTyp1.g3, zontPrystinnyyTyp1.TypVyhid3, zontPrystinnyyTyp1.ZhyrFiltr, zontPrystinnyyTyp1.G, filePath);
	}

	private static void ZontPrystinnyyTyp2_SaveFiles(List<IProduct> data, string filePathForSaving, string orderCode, string contragent)
	{
		//IL_0250: Unknown result type (might be due to invalid IL or missing references)
		List<Product_ZontPrystinnyyTyp2> list = Enumerable.ToList<Product_ZontPrystinnyyTyp2>(Enumerable.Select<IProduct, Product_ZontPrystinnyyTyp2>(Enumerable.Where<IProduct>((IEnumerable<IProduct>)data, (Func<IProduct, bool>)((IProduct x) => x is Product_ZontPrystinnyyTyp2)), (Func<IProduct, Product_ZontPrystinnyyTyp2>)((IProduct x) => x as Product_ZontPrystinnyyTyp2)));
		if (!Enumerable.Any<Product_ZontPrystinnyyTyp2>((IEnumerable<Product_ZontPrystinnyyTyp2>)list))
		{
			return;
		}
		string filePathForZontPrystinnyyDxfAndImage = GetFilePathForZontPrystinnyyDxfAndImage(filePathForSaving);
		foreach (Product_ZontPrystinnyyTyp2 item in list)
		{
			string text = (string.IsNullOrEmpty(orderCode) ? string.Empty : ("Замовлення_" + orderCode + "_"));
			string filePath = filePathForZontPrystinnyyDxfAndImage + $"{text}_{item.Order}_Зонт ЗВП-2 {item.L}x{item.B}x{item.H}";
			try
			{
				ZontPrystinnyyTyp2DrawDxf(item, filePath);
				ZontPrystinnyyTyp2.ZontPrystinnyyTyp2DrawImage(item.L, item.B, item.H, item.h, item.Amount, item.MarkaStali, item.ThicknessOfMetal, item.Connection, item.Zlyv, item.Fastening, item.Vyhid, item.Vyhid1, item.d1, item.a1, item.b1, item.p1, item.f1, item.g1, item.TypVyhid1, item.ProfilType1, item.Vyhid2, item.d2, item.a2, item.b2, item.p2, item.f2, item.g2, item.TypVyhid2, item.ProfilType2, item.Vyhid3, item.d3, item.a3, item.b3, item.p3, item.f3, item.g3, item.TypVyhid3, item.ProfilType3, item.ZhyrFiltr, item.G, item.MarkaStaliFiltr, item.ThicknessOfMetalFiltr, item.FasteningType, orderCode, contragent, filePath);
				ZontPrystinnyyTyp2DrawDxf(item, filePath);
			}
			catch
			{
				MessageBox.Show("Не змогло створити креслення для Зонт ЗВП-2");
			}
		}
	}

	private static void ZontPrystinnyyTyp3_SaveFiles(List<IProduct> data, string filePathForSaving, string orderCode, string contragent)
	{
		//IL_0227: Unknown result type (might be due to invalid IL or missing references)
		List<Product_ZontPrystinnyyTyp3> list = Enumerable.ToList<Product_ZontPrystinnyyTyp3>(Enumerable.Select<IProduct, Product_ZontPrystinnyyTyp3>(Enumerable.Where<IProduct>((IEnumerable<IProduct>)data, (Func<IProduct, bool>)((IProduct x) => x is Product_ZontPrystinnyyTyp3)), (Func<IProduct, Product_ZontPrystinnyyTyp3>)((IProduct x) => x as Product_ZontPrystinnyyTyp3)));
		if (!Enumerable.Any<Product_ZontPrystinnyyTyp3>((IEnumerable<Product_ZontPrystinnyyTyp3>)list))
		{
			return;
		}
		string filePathForZontPrystinnyyDxfAndImage = GetFilePathForZontPrystinnyyDxfAndImage(filePathForSaving);
		foreach (Product_ZontPrystinnyyTyp3 item in list)
		{
			string text = (string.IsNullOrEmpty(orderCode) ? string.Empty : ("Замовлення_" + orderCode + "_"));
			string filePath = filePathForZontPrystinnyyDxfAndImage + $"{text}_{item.Order}_Зонт ЗВП-3 {item.L}x{item.B}x{item.H}";
			try
			{
				ZontPrystinnyyTyp3DrawDxf(item, filePath);
				ZontPrystinnyyTyp3.ZontPrystinnyyTyp3DrawImage(item.L, item.B, item.H, item.h, item.a, item.b, item.c, item.Amount, item.Implementation, item.MarkaStali, item.ThicknessOfMetal, item.Connection, item.Zlyv, item.Fastening, item.FasteningType, item.Vyhid, item.Vyhid1, item.d1, item.a1, item.b1, item.p1, item.f1, item.g1, item.TypVyhid1, item.ProfilType1, item.Vyhid2, item.d2, item.a2, item.b2, item.p2, item.f2, item.g2, item.TypVyhid2, item.ProfilType2, item.ZhyrFiltr, item.MarkaStaliFiltr, item.ThicknessOfMetalFiltr, orderCode, contragent, filePath);
				ZontPrystinnyyTyp3DrawDxf(item, filePath);
			}
			catch
			{
				MessageBox.Show("Не змогло створити креслення для Зонт ЗВП-3");
			}
		}
	}

	private static void ZontPrystinnyyTyp31_SaveFiles(List<IProduct> data, string filePathForSaving, string orderCode, string contragent)
	{
		//IL_01a9: Unknown result type (might be due to invalid IL or missing references)
		List<Product_ZontPrystinnyyTyp31> list = Enumerable.ToList<Product_ZontPrystinnyyTyp31>(Enumerable.Select<IProduct, Product_ZontPrystinnyyTyp31>(Enumerable.Where<IProduct>((IEnumerable<IProduct>)data, (Func<IProduct, bool>)((IProduct x) => x is Product_ZontPrystinnyyTyp31)), (Func<IProduct, Product_ZontPrystinnyyTyp31>)((IProduct x) => x as Product_ZontPrystinnyyTyp31)));
		if (!Enumerable.Any<Product_ZontPrystinnyyTyp31>((IEnumerable<Product_ZontPrystinnyyTyp31>)list))
		{
			return;
		}
		string filePathForZontPrystinnyyDxfAndImage = GetFilePathForZontPrystinnyyDxfAndImage(filePathForSaving);
		foreach (Product_ZontPrystinnyyTyp31 item in list)
		{
			string text = (string.IsNullOrEmpty(orderCode) ? string.Empty : ("Замовлення_" + orderCode + "_"));
			string filePath = filePathForZontPrystinnyyDxfAndImage + $"{text}_{item.Order}_Зонт ЗВП-3.1 {item.L}x{item.B}x{item.H}";
			try
			{
				ZontPrystinnyyTyp31DrawDxf(item, filePath);
				ZontPrystinnyyTyp31.ZontPrystinnyyTyp31DrawImage(item.L, item.B, item.H, item.h, item.a, item.b, item.p, item.c, item.Amount, item.Implementation, item.MarkaStali, item.ThicknessOfMetal, item.Connection, item.Zlyv, item.Fastening, item.FasteningType, item.ZhyrFiltr, item.MarkaStaliFiltr, item.ThicknessOfMetalFiltr, orderCode, contragent, filePath);
				ZontPrystinnyyTyp31DrawDxf(item, filePath);
			}
			catch
			{
				MessageBox.Show("Не змогло створити креслення для Зонт ЗВП-3.1");
			}
		}
	}

	private static void ZontPrystinnyyTyp2DrawDxf(Product_ZontPrystinnyyTyp2 zontPrystinnyyTyp2, string filePath)
	{
		ZontPrystinnyyTyp2.ZontPrystinnyyTyp2DrawDxf(zontPrystinnyyTyp2.L, zontPrystinnyyTyp2.B, zontPrystinnyyTyp2.H, zontPrystinnyyTyp2.h, zontPrystinnyyTyp2.Connection, zontPrystinnyyTyp2.Zlyv, zontPrystinnyyTyp2.Vyhid, zontPrystinnyyTyp2.Vyhid1, zontPrystinnyyTyp2.d1, zontPrystinnyyTyp2.a1, zontPrystinnyyTyp2.b1, zontPrystinnyyTyp2.f1, zontPrystinnyyTyp2.g1, zontPrystinnyyTyp2.TypVyhid1, zontPrystinnyyTyp2.Vyhid2, zontPrystinnyyTyp2.d2, zontPrystinnyyTyp2.a2, zontPrystinnyyTyp2.b2, zontPrystinnyyTyp2.f2, zontPrystinnyyTyp2.g2, zontPrystinnyyTyp2.TypVyhid2, zontPrystinnyyTyp2.Vyhid3, zontPrystinnyyTyp2.d3, zontPrystinnyyTyp2.a3, zontPrystinnyyTyp2.b3, zontPrystinnyyTyp2.f3, zontPrystinnyyTyp2.g3, zontPrystinnyyTyp2.TypVyhid3, zontPrystinnyyTyp2.ZhyrFiltr, zontPrystinnyyTyp2.G, filePath);
	}

	private static void ZontPrystinnyyTyp3DrawDxf(Product_ZontPrystinnyyTyp3 zontPrystinnyyTyp3, string filePath)
	{
		ZontPrystinnyyTyp3.ZontPrystinnyyTyp3DrawDxf(zontPrystinnyyTyp3.L, zontPrystinnyyTyp3.B, zontPrystinnyyTyp3.H, zontPrystinnyyTyp3.h, zontPrystinnyyTyp3.a, zontPrystinnyyTyp3.b, zontPrystinnyyTyp3.c, zontPrystinnyyTyp3.Connection, zontPrystinnyyTyp3.Zlyv, zontPrystinnyyTyp3.Vyhid, zontPrystinnyyTyp3.Vyhid1, zontPrystinnyyTyp3.d1, zontPrystinnyyTyp3.a1, zontPrystinnyyTyp3.b1, zontPrystinnyyTyp3.f1, zontPrystinnyyTyp3.g1, zontPrystinnyyTyp3.TypVyhid1, zontPrystinnyyTyp3.Vyhid2, zontPrystinnyyTyp3.d2, zontPrystinnyyTyp3.a2, zontPrystinnyyTyp3.b2, zontPrystinnyyTyp3.f2, zontPrystinnyyTyp3.g2, zontPrystinnyyTyp3.TypVyhid2, zontPrystinnyyTyp3.ZhyrFiltr, zontPrystinnyyTyp3.Implementation, filePath);
	}

	private static void ZontPrystinnyyTyp31DrawDxf(Product_ZontPrystinnyyTyp31 zontPrystinnyyTyp31, string filePath)
	{
		ZontPrystinnyyTyp31.ZontPrystinnyyTyp31DrawDxf(zontPrystinnyyTyp31.L, zontPrystinnyyTyp31.B, zontPrystinnyyTyp31.H, zontPrystinnyyTyp31.h, zontPrystinnyyTyp31.a, zontPrystinnyyTyp31.b, zontPrystinnyyTyp31.p, zontPrystinnyyTyp31.c, zontPrystinnyyTyp31.Connection, zontPrystinnyyTyp31.Zlyv, zontPrystinnyyTyp31.ZhyrFiltr, zontPrystinnyyTyp31.Implementation, filePath);
	}

	private static void ZontPrystinnyyTyp4_SaveFiles(List<IProduct> data, string filePathForSaving, string orderCode, string contragent)
	{
		//IL_0255: Unknown result type (might be due to invalid IL or missing references)
		List<Product_ZontPrystinnyyTyp4> list = Enumerable.ToList<Product_ZontPrystinnyyTyp4>(Enumerable.Select<IProduct, Product_ZontPrystinnyyTyp4>(Enumerable.Where<IProduct>((IEnumerable<IProduct>)data, (Func<IProduct, bool>)((IProduct x) => x is Product_ZontPrystinnyyTyp4)), (Func<IProduct, Product_ZontPrystinnyyTyp4>)((IProduct x) => x as Product_ZontPrystinnyyTyp4)));
		if (!Enumerable.Any<Product_ZontPrystinnyyTyp4>((IEnumerable<Product_ZontPrystinnyyTyp4>)list))
		{
			return;
		}
		string filePathForZontPrystinnyyDxfAndImage = GetFilePathForZontPrystinnyyDxfAndImage(filePathForSaving);
		foreach (Product_ZontPrystinnyyTyp4 item in list)
		{
			string text = (string.IsNullOrEmpty(orderCode) ? string.Empty : ("Замовлення_" + orderCode + "_"));
			string filePath = filePathForZontPrystinnyyDxfAndImage + $"{text}_{item.Order}_Зонт ЗВП-4 {item.L}x{item.B}x{item.H}";
			try
			{
				ZontPrystinnyyTyp4DrawDxf(item, filePath);
				ZontOstrivnyyTyp4.ZontOstrivnyyTyp4DrawImage("ЗВП-4", item.Implementation, item.L, item.B, item.H, item.Amount, item.MarkaStali, item.ThicknessOfMetal, item.Connection, item.Zlyv, item.Fastening, item.FasteningType, item.Vyhid, item.Vyhid1, item.d1, item.a1, item.b1, item.p1, item.f1, item.g1, item.TypVyhid1, item.ProfilType1, item.Vyhid2, item.d2, item.a2, item.b2, item.p2, item.f2, item.g2, item.TypVyhid2, item.ProfilType2, item.Vyhid3, item.d3, item.a3, item.b3, item.p3, item.f3, item.g3, item.TypVyhid3, item.ProfilType3, item.ZhyrFiltr, item.G, item.MarkaStaliFiltr, item.ThicknessOfMetalFiltr, orderCode, contragent, filePath);
				ZontPrystinnyyTyp4DrawDxf(item, filePath);
			}
			catch
			{
				MessageBox.Show("Не змогло створити креслення для Зонт ЗВП-4");
			}
		}
	}

	private static void ZontPrystinnyyTyp4DrawDxf(Product_ZontPrystinnyyTyp4 zontPrystinnyyTyp4, string filePath)
	{
		ZontOstrivnyyTyp4.ZontOstrivnyyTyp4DrawDxf("ЗВП-4", zontPrystinnyyTyp4.Implementation, zontPrystinnyyTyp4.L, zontPrystinnyyTyp4.B, zontPrystinnyyTyp4.H, zontPrystinnyyTyp4.Connection, zontPrystinnyyTyp4.Zlyv, zontPrystinnyyTyp4.Vyhid, zontPrystinnyyTyp4.Vyhid1, zontPrystinnyyTyp4.d1, zontPrystinnyyTyp4.a1, zontPrystinnyyTyp4.b1, zontPrystinnyyTyp4.f1, zontPrystinnyyTyp4.g1, zontPrystinnyyTyp4.TypVyhid1, zontPrystinnyyTyp4.Vyhid2, zontPrystinnyyTyp4.d2, zontPrystinnyyTyp4.a2, zontPrystinnyyTyp4.b2, zontPrystinnyyTyp4.f2, zontPrystinnyyTyp4.g2, zontPrystinnyyTyp4.TypVyhid2, zontPrystinnyyTyp4.Vyhid3, zontPrystinnyyTyp4.d3, zontPrystinnyyTyp4.a3, zontPrystinnyyTyp4.b3, zontPrystinnyyTyp4.f3, zontPrystinnyyTyp4.g3, zontPrystinnyyTyp4.TypVyhid3, zontPrystinnyyTyp4.ZhyrFiltr, zontPrystinnyyTyp4.G, filePath);
	}

	private static void ZontOstrivnyyTyp1_SaveFiles(List<IProduct> data, string filePathForSaving, string orderCode, string contragent)
	{
		//IL_0258: Unknown result type (might be due to invalid IL or missing references)
		List<Product_ZontOstrivnyyTyp1> list = Enumerable.ToList<Product_ZontOstrivnyyTyp1>(Enumerable.Select<IProduct, Product_ZontOstrivnyyTyp1>(Enumerable.Where<IProduct>((IEnumerable<IProduct>)data, (Func<IProduct, bool>)((IProduct x) => x is Product_ZontOstrivnyyTyp1)), (Func<IProduct, Product_ZontOstrivnyyTyp1>)((IProduct x) => x as Product_ZontOstrivnyyTyp1)));
		if (!Enumerable.Any<Product_ZontOstrivnyyTyp1>((IEnumerable<Product_ZontOstrivnyyTyp1>)list))
		{
			return;
		}
		string filePathForZontPrystinnyyDxfAndImage = GetFilePathForZontPrystinnyyDxfAndImage(filePathForSaving);
		foreach (Product_ZontOstrivnyyTyp1 item in list)
		{
			string text = (string.IsNullOrEmpty(orderCode) ? string.Empty : ("Замовлення_" + orderCode + "_"));
			string filePath = filePathForZontPrystinnyyDxfAndImage + $"{text}_{item.Order}_Зонт ЗВО-1 {item.L}x{item.B}x{item.H}";
			try
			{
				ZontOstrivnyyTyp1DrawDxf(item, filePath);
				ZontOstrivnyyTyp1.ZontOstrivnyyTyp1DrawImage(item.L, item.B, item.H, item.h, item.b, item.Amount, item.MarkaStali, item.ThicknessOfMetal, item.Connection, item.Zlyv, item.Fastening, item.FasteningType, item.Vyhid, item.Vyhid1, item.d1, item.a1, item.b1, item.p1, item.f1, item.g1, item.TypVyhid1, item.ProfilType1, item.Vyhid2, item.d2, item.a2, item.b2, item.p2, item.f2, item.g2, item.TypVyhid2, item.ProfilType2, item.Vyhid3, item.d3, item.a3, item.b3, item.p3, item.f3, item.g3, item.TypVyhid3, item.ProfilType3, item.ZhyrFiltr, item.G, item.MarkaStaliFiltr, item.ThicknessOfMetalFiltr, orderCode, contragent, filePath);
				ZontOstrivnyyTyp1DrawDxf(item, filePath);
			}
			catch
			{
				MessageBox.Show("Не змогло створити креслення для Зонт ЗВО-1");
			}
		}
	}

	private static void ZontOstrivnyyTyp1DrawDxf(Product_ZontOstrivnyyTyp1 zontOstrivnyyTyp1, string filePath)
	{
		ZontOstrivnyyTyp1.ZontOstrivnyyTyp1DrawDxf(zontOstrivnyyTyp1.L, zontOstrivnyyTyp1.B, zontOstrivnyyTyp1.H, zontOstrivnyyTyp1.h, zontOstrivnyyTyp1.b, zontOstrivnyyTyp1.Connection, zontOstrivnyyTyp1.Zlyv, zontOstrivnyyTyp1.Vyhid, zontOstrivnyyTyp1.Vyhid1, zontOstrivnyyTyp1.d1, zontOstrivnyyTyp1.a1, zontOstrivnyyTyp1.b1, zontOstrivnyyTyp1.f1, zontOstrivnyyTyp1.g1, zontOstrivnyyTyp1.TypVyhid1, zontOstrivnyyTyp1.Vyhid2, zontOstrivnyyTyp1.d2, zontOstrivnyyTyp1.a2, zontOstrivnyyTyp1.b2, zontOstrivnyyTyp1.f2, zontOstrivnyyTyp1.g2, zontOstrivnyyTyp1.TypVyhid2, zontOstrivnyyTyp1.Vyhid3, zontOstrivnyyTyp1.d3, zontOstrivnyyTyp1.a3, zontOstrivnyyTyp1.b3, zontOstrivnyyTyp1.f3, zontOstrivnyyTyp1.g3, zontOstrivnyyTyp1.TypVyhid3, zontOstrivnyyTyp1.ZhyrFiltr, zontOstrivnyyTyp1.G, filePath);
	}

	private static void ZontOstrivnyyTyp2_SaveFiles(List<IProduct> data, string filePathForSaving, string orderCode, string contragent)
	{
		//IL_0250: Unknown result type (might be due to invalid IL or missing references)
		List<Product_ZontOstrivnyyTyp2> list = Enumerable.ToList<Product_ZontOstrivnyyTyp2>(Enumerable.Select<IProduct, Product_ZontOstrivnyyTyp2>(Enumerable.Where<IProduct>((IEnumerable<IProduct>)data, (Func<IProduct, bool>)((IProduct x) => x is Product_ZontOstrivnyyTyp2)), (Func<IProduct, Product_ZontOstrivnyyTyp2>)((IProduct x) => x as Product_ZontOstrivnyyTyp2)));
		if (!Enumerable.Any<Product_ZontOstrivnyyTyp2>((IEnumerable<Product_ZontOstrivnyyTyp2>)list))
		{
			return;
		}
		string filePathForZontPrystinnyyDxfAndImage = GetFilePathForZontPrystinnyyDxfAndImage(filePathForSaving);
		foreach (Product_ZontOstrivnyyTyp2 item in list)
		{
			string text = (string.IsNullOrEmpty(orderCode) ? string.Empty : ("Замовлення_" + orderCode + "_"));
			string filePath = filePathForZontPrystinnyyDxfAndImage + $"{text}_{item.Order}_Зонт ЗВО-2 {item.L}x{item.B}x{item.H}";
			try
			{
				ZontOstrivnyyTyp2DrawDxf(item, filePath);
				ZontOstrivnyyTyp2.ZontOstrivnyyTyp2DrawImage(item.L, item.B, item.H, item.h, item.Amount, item.MarkaStali, item.ThicknessOfMetal, item.Connection, item.Zlyv, item.Fastening, item.FasteningType, item.Vyhid, item.Vyhid1, item.d1, item.a1, item.b1, item.p1, item.f1, item.g1, item.TypVyhid1, item.ProfilType1, item.Vyhid2, item.d2, item.a2, item.b2, item.p2, item.f2, item.g2, item.TypVyhid2, item.ProfilType2, item.Vyhid3, item.d3, item.a3, item.b3, item.p3, item.f3, item.g3, item.TypVyhid3, item.ProfilType3, item.ZhyrFiltr, item.G, item.MarkaStaliFiltr, item.ThicknessOfMetalFiltr, orderCode, contragent, filePath);
				ZontOstrivnyyTyp2DrawDxf(item, filePath);
			}
			catch
			{
				MessageBox.Show("Не змогло створити креслення для Зонт ЗВО-2");
			}
		}
	}

	private static void ZontOstrivnyyTyp2DrawDxf(Product_ZontOstrivnyyTyp2 zontOstrivnyyTyp2, string filePath)
	{
		ZontOstrivnyyTyp2.ZontOstrivnyyTyp2DrawDxf(zontOstrivnyyTyp2.L, zontOstrivnyyTyp2.B, zontOstrivnyyTyp2.H, zontOstrivnyyTyp2.h, zontOstrivnyyTyp2.Connection, zontOstrivnyyTyp2.Zlyv, zontOstrivnyyTyp2.Vyhid, zontOstrivnyyTyp2.Vyhid1, zontOstrivnyyTyp2.d1, zontOstrivnyyTyp2.a1, zontOstrivnyyTyp2.b1, zontOstrivnyyTyp2.f1, zontOstrivnyyTyp2.g1, zontOstrivnyyTyp2.TypVyhid1, zontOstrivnyyTyp2.Vyhid2, zontOstrivnyyTyp2.d2, zontOstrivnyyTyp2.a2, zontOstrivnyyTyp2.b2, zontOstrivnyyTyp2.f2, zontOstrivnyyTyp2.g2, zontOstrivnyyTyp2.TypVyhid2, zontOstrivnyyTyp2.Vyhid3, zontOstrivnyyTyp2.d3, zontOstrivnyyTyp2.a3, zontOstrivnyyTyp2.b3, zontOstrivnyyTyp2.f3, zontOstrivnyyTyp2.g3, zontOstrivnyyTyp2.TypVyhid3, zontOstrivnyyTyp2.ZhyrFiltr, zontOstrivnyyTyp2.G, filePath);
	}

	private static void ZontOstrivnyyTyp3_SaveFiles(List<IProduct> data, string filePathForSaving, string orderCode, string contragent)
	{
		//IL_026e: Unknown result type (might be due to invalid IL or missing references)
		List<Product_ZontOstrivnyyTyp3> list = Enumerable.ToList<Product_ZontOstrivnyyTyp3>(Enumerable.Select<IProduct, Product_ZontOstrivnyyTyp3>(Enumerable.Where<IProduct>((IEnumerable<IProduct>)data, (Func<IProduct, bool>)((IProduct x) => x is Product_ZontOstrivnyyTyp3)), (Func<IProduct, Product_ZontOstrivnyyTyp3>)((IProduct x) => x as Product_ZontOstrivnyyTyp3)));
		if (!Enumerable.Any<Product_ZontOstrivnyyTyp3>((IEnumerable<Product_ZontOstrivnyyTyp3>)list))
		{
			return;
		}
		string filePathForZontPrystinnyyDxfAndImage = GetFilePathForZontPrystinnyyDxfAndImage(filePathForSaving);
		foreach (Product_ZontOstrivnyyTyp3 item in list)
		{
			string text = (string.IsNullOrEmpty(orderCode) ? string.Empty : ("Замовлення_" + orderCode + "_"));
			string filePath = filePathForZontPrystinnyyDxfAndImage + $"{text}_{item.Order}_Зонт ЗВО-3 {item.L}x{item.B}x{item.H}";
			try
			{
				ZontOstrivnyyTyp3DrawDxf(item, filePath);
				ZontOstrivnyyTyp3.ZontOstrivnyyTyp3DrawImage(item.L, item.B, item.H, item.h, item.a, item.b, item.c, item.c1, item.Amount, item.Implementation, item.MarkaStali, item.ThicknessOfMetal, item.Connection, item.Zlyv, item.Fastening, item.FasteningType, item.Vyhid, item.Vyhid1, item.d1, item.a1, item.b1, item.p1, item.f1, item.g1, item.TypVyhid1, item.ProfilType1, item.Vyhid2, item.d2, item.a2, item.b2, item.p2, item.f2, item.g2, item.TypVyhid2, item.ProfilType2, item.Vyhid3, item.d3, item.a3, item.b3, item.p3, item.f3, item.g3, item.TypVyhid3, item.ProfilType3, item.ZhyrFiltr, item.MarkaStaliFiltr, item.ThicknessOfMetalFiltr, orderCode, contragent, filePath);
				ZontOstrivnyyTyp3DrawDxf(item, filePath);
			}
			catch
			{
				MessageBox.Show("Не змогло створити креслення для Зонт ЗВО-3");
			}
		}
	}

	private static void ZontOstrivnyyTyp3DrawDxf(Product_ZontOstrivnyyTyp3 zontOstrivnyyTyp3, string filePath)
	{
		ZontOstrivnyyTyp3.ZontOstrivnyyTyp3DrawDxf(zontOstrivnyyTyp3.L, zontOstrivnyyTyp3.B, zontOstrivnyyTyp3.H, zontOstrivnyyTyp3.h, zontOstrivnyyTyp3.a, zontOstrivnyyTyp3.b, zontOstrivnyyTyp3.c, zontOstrivnyyTyp3.c1, zontOstrivnyyTyp3.Connection, zontOstrivnyyTyp3.Zlyv, zontOstrivnyyTyp3.Vyhid, zontOstrivnyyTyp3.Vyhid1, zontOstrivnyyTyp3.d1, zontOstrivnyyTyp3.a1, zontOstrivnyyTyp3.b1, zontOstrivnyyTyp3.f1, zontOstrivnyyTyp3.g1, zontOstrivnyyTyp3.TypVyhid1, zontOstrivnyyTyp3.Vyhid2, zontOstrivnyyTyp3.d2, zontOstrivnyyTyp3.a2, zontOstrivnyyTyp3.b2, zontOstrivnyyTyp3.f2, zontOstrivnyyTyp3.g2, zontOstrivnyyTyp3.TypVyhid2, zontOstrivnyyTyp3.Vyhid3, zontOstrivnyyTyp3.d3, zontOstrivnyyTyp3.a3, zontOstrivnyyTyp3.b3, zontOstrivnyyTyp3.f3, zontOstrivnyyTyp3.g3, zontOstrivnyyTyp3.TypVyhid3, zontOstrivnyyTyp3.ZhyrFiltr, zontOstrivnyyTyp3.Implementation, filePath);
	}

	private static void ZontOstrivnyyTyp31_SaveFiles(List<IProduct> data, string filePathForSaving, string orderCode, string contragent)
	{
		//IL_01b1: Unknown result type (might be due to invalid IL or missing references)
		List<Product_ZontOstrivnyyTyp31> list = Enumerable.ToList<Product_ZontOstrivnyyTyp31>(Enumerable.Select<IProduct, Product_ZontOstrivnyyTyp31>(Enumerable.Where<IProduct>((IEnumerable<IProduct>)data, (Func<IProduct, bool>)((IProduct x) => x is Product_ZontOstrivnyyTyp31)), (Func<IProduct, Product_ZontOstrivnyyTyp31>)((IProduct x) => x as Product_ZontOstrivnyyTyp31)));
		if (!Enumerable.Any<Product_ZontOstrivnyyTyp31>((IEnumerable<Product_ZontOstrivnyyTyp31>)list))
		{
			return;
		}
		string filePathForZontPrystinnyyDxfAndImage = GetFilePathForZontPrystinnyyDxfAndImage(filePathForSaving);
		foreach (Product_ZontOstrivnyyTyp31 item in list)
		{
			string text = (string.IsNullOrEmpty(orderCode) ? string.Empty : ("Замовлення_" + orderCode + "_"));
			string filePath = filePathForZontPrystinnyyDxfAndImage + $"{text}_{item.Order}_Зонт ЗВО-3.1 {item.L}x{item.B}x{item.H}";
			try
			{
				ZontOstrivnyyTyp31DrawDxf(item, filePath);
				ZontOstrivnyyTyp31.ZontOstrivnyyTyp31DrawImage(item.L, item.B, item.H, item.h, item.a, item.b, item.p, item.c, item.c1, item.Amount, item.Implementation, item.MarkaStali, item.ThicknessOfMetal, item.Connection, item.Zlyv, item.Fastening, item.FasteningType, item.ZhyrFiltr, item.MarkaStaliFiltr, item.ThicknessOfMetalFiltr, orderCode, contragent, filePath);
				ZontOstrivnyyTyp31DrawDxf(item, filePath);
			}
			catch
			{
				MessageBox.Show("Не змогло створити креслення для Зонт ЗВО-3.1");
			}
		}
	}

	private static void ZontOstrivnyyTyp31DrawDxf(Product_ZontOstrivnyyTyp31 zontOstrivnyyTyp31, string filePath)
	{
		ZontOstrivnyyTyp31.ZontOstrivnyyTyp31DrawDxf(zontOstrivnyyTyp31.L, zontOstrivnyyTyp31.B, zontOstrivnyyTyp31.H, zontOstrivnyyTyp31.h, zontOstrivnyyTyp31.a, zontOstrivnyyTyp31.b, zontOstrivnyyTyp31.p, zontOstrivnyyTyp31.c, zontOstrivnyyTyp31.c1, zontOstrivnyyTyp31.Connection, zontOstrivnyyTyp31.Zlyv, zontOstrivnyyTyp31.ZhyrFiltr, zontOstrivnyyTyp31.Implementation, filePath);
	}

	private static void ZontOstrivnyyTyp4_SaveFiles(List<IProduct> data, string filePathForSaving, string orderCode, string contragent)
	{
		//IL_0255: Unknown result type (might be due to invalid IL or missing references)
		List<Product_ZontOstrivnyyTyp4> list = Enumerable.ToList<Product_ZontOstrivnyyTyp4>(Enumerable.Select<IProduct, Product_ZontOstrivnyyTyp4>(Enumerable.Where<IProduct>((IEnumerable<IProduct>)data, (Func<IProduct, bool>)((IProduct x) => x is Product_ZontOstrivnyyTyp4)), (Func<IProduct, Product_ZontOstrivnyyTyp4>)((IProduct x) => x as Product_ZontOstrivnyyTyp4)));
		if (!Enumerable.Any<Product_ZontOstrivnyyTyp4>((IEnumerable<Product_ZontOstrivnyyTyp4>)list))
		{
			return;
		}
		string filePathForZontPrystinnyyDxfAndImage = GetFilePathForZontPrystinnyyDxfAndImage(filePathForSaving);
		foreach (Product_ZontOstrivnyyTyp4 item in list)
		{
			string text = (string.IsNullOrEmpty(orderCode) ? string.Empty : ("Замовлення_" + orderCode + "_"));
			string filePath = filePathForZontPrystinnyyDxfAndImage + $"{text}_{item.Order}_Зонт ЗВО-4 {item.L}x{item.B}x{item.H}";
			try
			{
				ZontOstrivnyyTyp4DrawDxf(item, filePath);
				ZontOstrivnyyTyp4.ZontOstrivnyyTyp4DrawImage("ЗВО-4", item.Implementation, item.L, item.B, item.H, item.Amount, item.MarkaStali, item.ThicknessOfMetal, item.Connection, item.Zlyv, item.Fastening, item.FasteningType, item.Vyhid, item.Vyhid1, item.d1, item.a1, item.b1, item.p1, item.f1, item.g1, item.TypVyhid1, item.ProfilType1, item.Vyhid2, item.d2, item.a2, item.b2, item.p2, item.f2, item.g2, item.TypVyhid2, item.ProfilType2, item.Vyhid3, item.d3, item.a3, item.b3, item.p3, item.f3, item.g3, item.TypVyhid3, item.ProfilType3, item.ZhyrFiltr, item.G, item.MarkaStaliFiltr, item.ThicknessOfMetalFiltr, orderCode, contragent, filePath);
				ZontOstrivnyyTyp4DrawDxf(item, filePath);
			}
			catch
			{
				MessageBox.Show("Не змогло створити креслення для Зонт ЗВО-4");
			}
		}
	}

	private static void ZontOstrivnyyTyp4DrawDxf(Product_ZontOstrivnyyTyp4 zontOstrivnyyTyp4, string filePath)
	{
		ZontOstrivnyyTyp4.ZontOstrivnyyTyp4DrawDxf("ЗВО-4", zontOstrivnyyTyp4.Implementation, zontOstrivnyyTyp4.L, zontOstrivnyyTyp4.B, zontOstrivnyyTyp4.H, zontOstrivnyyTyp4.Connection, zontOstrivnyyTyp4.Zlyv, zontOstrivnyyTyp4.Vyhid, zontOstrivnyyTyp4.Vyhid1, zontOstrivnyyTyp4.d1, zontOstrivnyyTyp4.a1, zontOstrivnyyTyp4.b1, zontOstrivnyyTyp4.f1, zontOstrivnyyTyp4.g1, zontOstrivnyyTyp4.TypVyhid1, zontOstrivnyyTyp4.Vyhid2, zontOstrivnyyTyp4.d2, zontOstrivnyyTyp4.a2, zontOstrivnyyTyp4.b2, zontOstrivnyyTyp4.f2, zontOstrivnyyTyp4.g2, zontOstrivnyyTyp4.TypVyhid2, zontOstrivnyyTyp4.Vyhid3, zontOstrivnyyTyp4.d3, zontOstrivnyyTyp4.a3, zontOstrivnyyTyp4.b3, zontOstrivnyyTyp4.f3, zontOstrivnyyTyp4.g3, zontOstrivnyyTyp4.TypVyhid3, zontOstrivnyyTyp4.ZhyrFiltr, zontOstrivnyyTyp4.G, filePath);
	}

	private static string GetFilePathForZontPrystinnyyDxfAndImage(string filePathForSaving)
	{
		string oldValue = Enumerable.Last<string>((IEnumerable<string>)filePathForSaving.Split(new char[1] { '\\' }));
		string text = filePathForSaving.Replace(oldValue, string.Empty) + "Зонт";
		if (!Directory.Exists(text))
		{
			Directory.CreateDirectory(text);
		}
		return text + "\\";
	}
}
