using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows;
using TEZ_Project.Common.Models;
using TEZ_Project.Common.Products;

namespace TEZ_Project.Common.Helpers;

public static class AluminiumGridHelper
{
	public static void AluminiumGrid_SaveFiles(List<IProduct> data, string filePathForSaving, string orderCode)
	{
		//IL_01c8: Unknown result type (might be due to invalid IL or missing references)
		List<Product_AluminiumGrid> list = Enumerable.ToList<Product_AluminiumGrid>(Enumerable.Select<IProduct, Product_AluminiumGrid>(Enumerable.Where<IProduct>((IEnumerable<IProduct>)data, (Func<IProduct, bool>)((IProduct x) => x is Product_AluminiumGrid)), (Func<IProduct, Product_AluminiumGrid>)((IProduct x) => x as Product_AluminiumGrid)));
		if (!Enumerable.Any<Product_AluminiumGrid>((IEnumerable<Product_AluminiumGrid>)list))
		{
			return;
		}
		string filePathForAluminiumGridImage = GetFilePathForAluminiumGridImage(filePathForSaving);
		foreach (Product_AluminiumGrid item in list)
		{
			string arg = (string.IsNullOrEmpty(orderCode) ? string.Empty : ("Замовлення_" + orderCode + "_"));
			string text = filePathForAluminiumGridImage + $"{arg}{item.Order}_Решітка АРТ-";
			text = ((!(item.TypReshitky == "однорядна")) ? (text + (item.Anodovane ? "2 (A) " : ("2 (" + item.RAL + ") "))) : (text + (item.Anodovane ? "1 (A) " : ("1 (" + item.RAL + ") "))));
			text = text + item.B + "х" + item.H + "(h)";
			try
			{
				AluminiumGrid.AluminiumGridDrawImage(item.B, item.H, item.TypReshitky, item.RAL, item.Anodovane, item.SposibKriplennja, item.Amount, text);
			}
			catch
			{
				MessageBox.Show("Не змогло створити малюнок для Решітка вент");
			}
		}
	}

	private static string GetFilePathForAluminiumGridImage(string filePathForSaving)
	{
		string oldValue = Enumerable.Last<string>((IEnumerable<string>)filePathForSaving.Split(new char[1] { '\\' }));
		string text = filePathForSaving.Replace(oldValue, string.Empty, StringComparison.OrdinalIgnoreCase) + "Решітка вент";
		if (!Directory.Exists(text))
		{
			Directory.CreateDirectory(text);
		}
		return text + "\\";
	}
}
