using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;

namespace TEZ_Project.Common.Helpers;

public static class WPFHelper
{
	public static string GetValue(this ComboBox comboBox)
	{
		string text = ((Selector)comboBox).SelectedItem?.ToString();
		if (string.IsNullOrEmpty(text) || text == "System.Windows.Controls.ComboBoxItem")
		{
			return null;
		}
		return text.Contains(": ") ? Enumerable.Last<string>((IEnumerable<string>)text.Split(new string[1] { ": " }, StringSplitOptions.None)) : text;
	}

	public static int GetIntValueOrDefault(this TextBox textBox)
	{
		int result;
		return int.TryParse((textBox != null) ? textBox.Text : null, out result) ? result : 0;
	}

	public static string GetValueOrDefault(this TextBox textBox)
	{
		return string.IsNullOrEmpty(textBox.Text) ? null : textBox.Text;
	}

	public static void SetItem(this ComboBox comboBox, string itemName)
	{
		if (!ContainsItem(comboBox, itemName))
		{
			((ItemsControl)comboBox).Items.Insert(((CollectionView)((ItemsControl)comboBox).Items).Count - 1, (object)itemName);
		}
		comboBox.Text = itemName;
	}

	public static string GetProjectRootPath()
	{
		return Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location).Replace("\\bin\\Debug", string.Empty);
	}

	private static bool ContainsItem(ComboBox comboBox, string itemName)
	{
		for (int i = 0; i < ((CollectionView)((ItemsControl)comboBox).Items).Count; i++)
		{
			if (Enumerable.Last<string>((IEnumerable<string>)((ItemsControl)comboBox).Items[i].ToString().Split(new string[1] { ": " }, StringSplitOptions.None)) == itemName)
			{
				return true;
			}
		}
		return false;
	}
}
