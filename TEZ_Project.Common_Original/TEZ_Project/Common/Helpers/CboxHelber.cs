using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;

namespace TEZ_Project.Common.Helpers;

public static class CboxHelber
{
	public static void ShowHideAisiTypeCb(ComboBox markaStali, ComboBox aisiTypeCb, Label aisiTypeLb)
	{
		if (markaStali?.GetValue() == "Нержавійка")
		{
			((Selector)aisiTypeCb).SelectedIndex = 0;
			((UIElement)aisiTypeCb).Visibility = (Visibility)0;
			((UIElement)aisiTypeLb).Visibility = (Visibility)0;
		}
		else
		{
			((Selector)aisiTypeCb).SelectedItem = null;
			((UIElement)aisiTypeCb).Visibility = (Visibility)2;
			((UIElement)aisiTypeLb).Visibility = (Visibility)2;
		}
	}
}
