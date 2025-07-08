using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Input;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using TEZ_Project.Common.Helpers;

namespace TEZ_Project.ProductWindows;

public class ZontPrystinnyyTyp3Window : Window, IComponentConnector
{
	internal Image ZontPrystinnyyTyp3_Img;

	internal GroupBox inputDataZontPrystinnyyTyp3_Vyhid1;

	internal Grid inputDataInnerGridZontPrystinnyyTyp3_Vyhid1;

	internal TextBox textBox_d1_ZontPrystinnyyTyp3;

	internal TextBox textBox_a1_ZontPrystinnyyTyp3;

	internal TextBox textBox_b1_ZontPrystinnyyTyp3;

	internal TextBox textBox_p1_ZontPrystinnyyTyp3;

	internal TextBox textBox_f1_ZontPrystinnyyTyp3;

	internal TextBox textBox_g1_ZontPrystinnyyTyp3;

	internal ComboBox comboBox_Vyhid1_ZontPrystinnyyTyp3;

	internal ComboBox comboBox_typVyhid1_ZontPrystinnyyTyp3;

	internal ComboBox comboBox_profilType1_ZontPrystinnyyTyp3;

	internal Label label_d1_ZontPrystinnyyTyp3;

	internal Label label_p1_ZontPrystinnyyTyp3;

	internal Label label_f1_ZontPrystinnyyTyp3;

	internal Label label_g1_ZontPrystinnyyTyp3;

	internal Label label_a1_ZontPrystinnyyTyp3;

	internal Label label_b1_ZontPrystinnyyTyp3;

	internal Label label_typVyhid1_ZontPrystinnyyTyp3;

	internal Label label_Vyhid1_ZontPrystinnyyTyp3;

	internal Label label_profilType1_ZontPrystinnyyTyp3;

	internal GroupBox inputDataZontPrystinnyyTyp3_Vyhid2;

	internal Grid inputDataInnerGridZontPrystinnyyTyp3_Vyhid2;

	internal TextBox textBox_d2_ZontPrystinnyyTyp3;

	internal TextBox textBox_a2_ZontPrystinnyyTyp3;

	internal TextBox textBox_b2_ZontPrystinnyyTyp3;

	internal TextBox textBox_p2_ZontPrystinnyyTyp3;

	internal TextBox textBox_f2_ZontPrystinnyyTyp3;

	internal TextBox textBox_g2_ZontPrystinnyyTyp3;

	internal ComboBox comboBox_Vyhid2_ZontPrystinnyyTyp3;

	internal ComboBox comboBox_typVyhid2_ZontPrystinnyyTyp3;

	internal ComboBox comboBox_profilType2_ZontPrystinnyyTyp3;

	internal Label label_d2_ZontPrystinnyyTyp3;

	internal Label label_p2_ZontPrystinnyyTyp3;

	internal Label label_f2_ZontPrystinnyyTyp3;

	internal Label label_g2_ZontPrystinnyyTyp3;

	internal Label label_a2_ZontPrystinnyyTyp3;

	internal Label label_b2_ZontPrystinnyyTyp3;

	internal Label label_typVyhid2_ZontPrystinnyyTyp3;

	internal Label label_Vyhid2_ZontPrystinnyyTyp3;

	internal Label label_profilType2_ZontPrystinnyyTyp3;

	private bool _contentLoaded;

	public MainWindow ParentWindow { get; set; }

	public ZontPrystinnyyTyp3Window()
	{
		InitializeComponent();
		ZontPrystinnyyTyp3_Vyhid_AttachEventHandlersToComboBoxes();
	}

	private void ZontPrystinnyyTyp3_Vyhid_AttachEventHandlersToComboBoxes()
	{
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0018: Expected O, but got Unknown
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		//IL_0030: Expected O, but got Unknown
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0048: Expected O, but got Unknown
		((Selector)comboBox_Vyhid2_ZontPrystinnyyTyp3).SelectionChanged += new SelectionChangedEventHandler(ZontPrystinnyyTyp3_Vyhid2Cbox_SelectionChanged);
		((Selector)comboBox_typVyhid1_ZontPrystinnyyTyp3).SelectionChanged += new SelectionChangedEventHandler(ZontPrystinnyyTyp3_TypVyhid1Cbox_SelectionChanged);
		((Selector)comboBox_typVyhid2_ZontPrystinnyyTyp3).SelectionChanged += new SelectionChangedEventHandler(ZontPrystinnyyTyp3_TypVyhid2Cbox_SelectionChanged);
	}

	private void ZontPrystinnyyTyp3_Vyhid1Cbox_SelectionChanged(object sender, RoutedEventArgs e)
	{
		string text = comboBox_Vyhid1_ZontPrystinnyyTyp3?.GetValue();
		if (string.IsNullOrEmpty(text))
		{
			ParentWindow.ZontPrystinnyyTyp3_SetFirstImage();
			return;
		}
		if (text == "круглий")
		{
			((UIElement)textBox_d1_ZontPrystinnyyTyp3).Visibility = (Visibility)0;
			((UIElement)label_d1_ZontPrystinnyyTyp3).Visibility = (Visibility)0;
			textBox_a1_ZontPrystinnyyTyp3.Clear();
			((UIElement)textBox_a1_ZontPrystinnyyTyp3).Visibility = (Visibility)2;
			((UIElement)label_a1_ZontPrystinnyyTyp3).Visibility = (Visibility)2;
			textBox_b1_ZontPrystinnyyTyp3.Clear();
			((UIElement)textBox_b1_ZontPrystinnyyTyp3).Visibility = (Visibility)2;
			((UIElement)label_b1_ZontPrystinnyyTyp3).Visibility = (Visibility)2;
		}
		else if (text == "прямокутний")
		{
			((UIElement)textBox_a1_ZontPrystinnyyTyp3).Visibility = (Visibility)0;
			((UIElement)label_a1_ZontPrystinnyyTyp3).Visibility = (Visibility)0;
			((UIElement)textBox_b1_ZontPrystinnyyTyp3).Visibility = (Visibility)0;
			((UIElement)label_b1_ZontPrystinnyyTyp3).Visibility = (Visibility)0;
			textBox_d1_ZontPrystinnyyTyp3.Clear();
			((UIElement)textBox_d1_ZontPrystinnyyTyp3).Visibility = (Visibility)2;
			((UIElement)label_d1_ZontPrystinnyyTyp3).Visibility = (Visibility)2;
		}
		textBox_p1_ZontPrystinnyyTyp3.Text = "50";
		((UIElement)textBox_p1_ZontPrystinnyyTyp3).Visibility = (Visibility)0;
		((UIElement)label_p1_ZontPrystinnyyTyp3).Visibility = (Visibility)0;
		((UIElement)textBox_f1_ZontPrystinnyyTyp3).Visibility = (Visibility)0;
		((UIElement)label_f1_ZontPrystinnyyTyp3).Visibility = (Visibility)0;
		((UIElement)textBox_g1_ZontPrystinnyyTyp3).Visibility = (Visibility)0;
		((UIElement)label_g1_ZontPrystinnyyTyp3).Visibility = (Visibility)0;
		((Selector)comboBox_typVyhid1_ZontPrystinnyyTyp3).SelectedIndex = 0;
		((UIElement)comboBox_typVyhid1_ZontPrystinnyyTyp3).Visibility = (Visibility)0;
		((UIElement)label_typVyhid1_ZontPrystinnyyTyp3).Visibility = (Visibility)0;
		((UIElement)inputDataZontPrystinnyyTyp3_Vyhid2).Visibility = (Visibility)0;
		ParentWindow.ZontPrystinnyyTyp3_TextBox_a_LostFocus(null, null);
		ParentWindow.ZontPrystinnyyTyp3_TextBox_b_LostFocus(null, null);
		ParentWindow.ZontPrystinnyyTyp3_TextBox_a_SetDefaultValue(text);
		ParentWindow.ZontPrystinnyyTyp3_TextBox_b_SetDefaultValue(text);
		ParentWindow.ZontPrystinnyyTyp3_SetFirstImage();
	}

	private void ZontPrystinnyyTyp3_TypVyhid1Cbox_SelectionChanged(object sender, RoutedEventArgs e)
	{
		ZontVytiajniyHelper.ZontVytiajniy_TypVyhidCbox_SelectionChanged((ComboBox)((sender is ComboBox) ? sender : null), comboBox_Vyhid1_ZontPrystinnyyTyp3, comboBox_profilType1_ZontPrystinnyyTyp3, label_profilType1_ZontPrystinnyyTyp3);
	}

	public void ZontPrystinnyyTyp3_TextBox_d1_LostFocus(object sender, RoutedEventArgs e)
	{
		//IL_009e: Unknown result type (might be due to invalid IL or missing references)
		TextBox val = textBox_d1_ZontPrystinnyyTyp3;
		if (int.TryParse(val.Text, out var result) && int.TryParse(ParentWindow.textBox_a_ZontPrystinnyyTyp3.Text, out var result2) && int.TryParse(ParentWindow.textBox_b_ZontPrystinnyyTyp3.Text, out var result3))
		{
			int num = Math.Min(result2, result3) - 10;
			if (num > 10 && (result < 10 || result > num))
			{
				val.Text = "";
				MessageBox.Show($"Діаметр вихода 1 має бути в межах {10} - {num} мм");
				return;
			}
		}
		ZontPrystinnyyTyp3_TextBox_f1_LostFocus(null, null);
		ZontPrystinnyyTyp3_TextBox_g1_LostFocus(null, null);
		ZontPrystinnyyTyp3_TextBox_a2_LostFocus(null, null);
		ZontPrystinnyyTyp3_TextBox_b2_LostFocus(null, null);
		ZontPrystinnyyTyp3_TextBox_d2_LostFocus(null, null);
		ParentWindow.ZontPrystinnyyTyp3_TextBox_a_SetDefaultValue();
		ParentWindow.ZontPrystinnyyTyp3_TextBox_b_SetDefaultValue();
		if (sender != null)
		{
			ParentWindow.ZontPrystinnyyTyp3_TextBox_LostFocus(sender, e);
		}
	}

	public void ZontPrystinnyyTyp3_TextBox_a1_LostFocus(object sender, RoutedEventArgs e)
	{
		//IL_007d: Unknown result type (might be due to invalid IL or missing references)
		TextBox val = textBox_a1_ZontPrystinnyyTyp3;
		if (int.TryParse(val.Text, out var result) && int.TryParse(ParentWindow.textBox_a_ZontPrystinnyyTyp3.Text, out var result2))
		{
			int num = result2 - 10;
			if (num > 10 && (result < 10 || result > num))
			{
				val.Text = "";
				MessageBox.Show($"Довжина вихода 1 має бути в межах {10} - {num} мм");
				return;
			}
		}
		ZontPrystinnyyTyp3_TextBox_f1_LostFocus(null, null);
		ZontPrystinnyyTyp3_TextBox_f2_LostFocus(null, null);
		ZontPrystinnyyTyp3_TextBox_d2_LostFocus(null, null);
		ZontPrystinnyyTyp3_TextBox_a2_LostFocus(null, null);
		ParentWindow.ZontPrystinnyyTyp3_TextBox_a_SetDefaultValue();
		if (sender != null)
		{
			ZontPrystinnyyTyp3_TextBox_Base_LostFocus(sender, e);
		}
	}

	public void ZontPrystinnyyTyp3_TextBox_b1_LostFocus(object sender, RoutedEventArgs e)
	{
		//IL_007d: Unknown result type (might be due to invalid IL or missing references)
		TextBox val = textBox_b1_ZontPrystinnyyTyp3;
		if (int.TryParse(val.Text, out var result) && int.TryParse(ParentWindow.textBox_b_ZontPrystinnyyTyp3.Text, out var result2))
		{
			int num = result2 - 10;
			if (num > 10 && (result < 10 || result > num))
			{
				val.Text = "";
				MessageBox.Show($"Ширина вихода 1 має бути в межах {10} - {num} мм");
				return;
			}
		}
		ZontPrystinnyyTyp3_TextBox_g1_LostFocus(null, null);
		ZontPrystinnyyTyp3_TextBox_b2_LostFocus(null, null);
		ParentWindow.ZontPrystinnyyTyp3_TextBox_b_SetDefaultValue();
		if (sender != null)
		{
			ZontPrystinnyyTyp3_TextBox_Base_LostFocus(sender, e);
		}
	}

	public void ZontPrystinnyyTyp3_TextBox_p1_LostFocus(object sender, RoutedEventArgs e)
	{
		//IL_0090: Unknown result type (might be due to invalid IL or missing references)
		string text = comboBox_Vyhid1_ZontPrystinnyyTyp3?.GetValue();
		if (!string.IsNullOrEmpty(text))
		{
			int num = ((text == "круглий") ? 50 : 30);
			TextBox val = textBox_p1_ZontPrystinnyyTyp3;
			if (int.TryParse(val.Text, out var result) && (result < num || result > 600))
			{
				val.Text = "";
				MessageBox.Show($"Висота вихода 1 має бути в межах {num} - {600} мм");
			}
			else if (sender != null)
			{
				ParentWindow.ZontPrystinnyyTyp3_TextBox_LostFocus(sender, e);
			}
		}
	}

	public void ZontPrystinnyyTyp3_TextBox_f1_LostFocus(object sender, RoutedEventArgs e)
	{
		//IL_0129: Unknown result type (might be due to invalid IL or missing references)
		string text = comboBox_Vyhid1_ZontPrystinnyyTyp3?.GetValue();
		if (string.IsNullOrEmpty(text))
		{
			return;
		}
		TextBox val = textBox_f1_ZontPrystinnyyTyp3;
		if (int.TryParse(val.Text, out var result) && int.TryParse(ParentWindow.textBox_a_ZontPrystinnyyTyp3.Text, out var result2))
		{
			int num = 0;
			int num2 = 0;
			if (text == "круглий" && int.TryParse(textBox_d1_ZontPrystinnyyTyp3.Text, out var result3))
			{
				num = 10 + result3 / 2;
				num2 = result2 - 10 - result3 / 2;
			}
			if (text == "прямокутний" && int.TryParse(textBox_a1_ZontPrystinnyyTyp3.Text, out var result4))
			{
				num = 10 + result4 / 2;
				num2 = result2 - 10 - result4 / 2;
			}
			if (num2 > num && num2 != 0 && (result <= num || result >= num2))
			{
				val.Text = "";
				MessageBox.Show($"Розміщення по довжині вихода 1 має бути більше ніж {num} і менше ніж {num2} мм");
				return;
			}
		}
		if (sender != null)
		{
			ZontPrystinnyyTyp3_TextBox_Base_LostFocus(sender, e);
		}
	}

	public void ZontPrystinnyyTyp3_TextBox_g1_LostFocus(object sender, RoutedEventArgs e)
	{
		//IL_0129: Unknown result type (might be due to invalid IL or missing references)
		string text = comboBox_Vyhid1_ZontPrystinnyyTyp3?.GetValue();
		if (string.IsNullOrEmpty(text))
		{
			return;
		}
		TextBox val = textBox_g1_ZontPrystinnyyTyp3;
		if (int.TryParse(val.Text, out var result) && int.TryParse(ParentWindow.textBox_b_ZontPrystinnyyTyp3.Text, out var result2))
		{
			int num = 0;
			int num2 = 0;
			if (text == "круглий" && int.TryParse(textBox_d1_ZontPrystinnyyTyp3.Text, out var result3))
			{
				num = 10 + result3 / 2;
				num2 = result2 - 10 - result3 / 2;
			}
			if (text == "прямокутний" && int.TryParse(textBox_b1_ZontPrystinnyyTyp3.Text, out var result4))
			{
				num = 10 + result4 / 2;
				num2 = result2 - 10 - result4 / 2;
			}
			if (num2 > num && num2 != 0 && (result <= num || result >= num2))
			{
				val.Text = "";
				MessageBox.Show($"Розміщення по ширині вихода 1 має бути більше ніж {num} і менше ніж {num2} мм");
				return;
			}
		}
		if (sender != null)
		{
			ZontPrystinnyyTyp3_TextBox_Base_LostFocus(sender, e);
		}
	}

	private void ZontPrystinnyyTyp3_TextBox_p1_PreviewMouseLeftButtonUp(object sender, MouseButtonEventArgs e)
	{
		ParentWindow.ZontPrystinnyyTyp3_SetImage("p1");
	}

	private void ZontPrystinnyyTyp3_TextBox_g1_PreviewMouseLeftButtonUp(object sender, MouseButtonEventArgs e)
	{
		ZontPrystinnyyTyp3_SetInnerImage("g1");
	}

	private void ZontPrystinnyyTyp3_TextBox_f1_PreviewMouseLeftButtonUp(object sender, MouseButtonEventArgs e)
	{
		ZontPrystinnyyTyp3_SetInnerImage("f1");
	}

	private void ZontPrystinnyyTyp3_Vyhid2Cbox_SelectionChanged(object sender, RoutedEventArgs e)
	{
		string text = comboBox_Vyhid2_ZontPrystinnyyTyp3?.GetValue();
		if (string.IsNullOrEmpty(text))
		{
			textBox_a2_ZontPrystinnyyTyp3.Clear();
			textBox_b2_ZontPrystinnyyTyp3.Clear();
			textBox_d2_ZontPrystinnyyTyp3.Clear();
			textBox_p2_ZontPrystinnyyTyp3.Clear();
			textBox_f2_ZontPrystinnyyTyp3.Clear();
			textBox_g2_ZontPrystinnyyTyp3.Clear();
			((Selector)comboBox_typVyhid2_ZontPrystinnyyTyp3).SelectedItem = null;
			((UIElement)textBox_d2_ZontPrystinnyyTyp3).Visibility = (Visibility)2;
			((UIElement)label_d2_ZontPrystinnyyTyp3).Visibility = (Visibility)2;
			((UIElement)textBox_a2_ZontPrystinnyyTyp3).Visibility = (Visibility)2;
			((UIElement)label_a2_ZontPrystinnyyTyp3).Visibility = (Visibility)2;
			((UIElement)textBox_b2_ZontPrystinnyyTyp3).Visibility = (Visibility)2;
			((UIElement)label_b2_ZontPrystinnyyTyp3).Visibility = (Visibility)2;
			((UIElement)textBox_p2_ZontPrystinnyyTyp3).Visibility = (Visibility)2;
			((UIElement)label_p2_ZontPrystinnyyTyp3).Visibility = (Visibility)2;
			((UIElement)textBox_f2_ZontPrystinnyyTyp3).Visibility = (Visibility)2;
			((UIElement)label_f2_ZontPrystinnyyTyp3).Visibility = (Visibility)2;
			((UIElement)textBox_g2_ZontPrystinnyyTyp3).Visibility = (Visibility)2;
			((UIElement)label_g2_ZontPrystinnyyTyp3).Visibility = (Visibility)2;
			((UIElement)comboBox_typVyhid2_ZontPrystinnyyTyp3).Visibility = (Visibility)2;
			((UIElement)label_typVyhid2_ZontPrystinnyyTyp3).Visibility = (Visibility)2;
			((UIElement)comboBox_profilType2_ZontPrystinnyyTyp3).Visibility = (Visibility)2;
			((UIElement)label_profilType2_ZontPrystinnyyTyp3).Visibility = (Visibility)2;
			ParentWindow.ZontPrystinnyyTyp3_SetFirstImage();
			return;
		}
		if (text == "круглий")
		{
			((UIElement)textBox_d2_ZontPrystinnyyTyp3).Visibility = (Visibility)0;
			((UIElement)label_d2_ZontPrystinnyyTyp3).Visibility = (Visibility)0;
			textBox_a2_ZontPrystinnyyTyp3.Clear();
			((UIElement)textBox_a2_ZontPrystinnyyTyp3).Visibility = (Visibility)2;
			((UIElement)label_a2_ZontPrystinnyyTyp3).Visibility = (Visibility)2;
			textBox_b2_ZontPrystinnyyTyp3.Clear();
			((UIElement)textBox_b2_ZontPrystinnyyTyp3).Visibility = (Visibility)2;
			((UIElement)label_b2_ZontPrystinnyyTyp3).Visibility = (Visibility)2;
		}
		else if (text == "прямокутний")
		{
			((UIElement)textBox_a2_ZontPrystinnyyTyp3).Visibility = (Visibility)0;
			((UIElement)label_a2_ZontPrystinnyyTyp3).Visibility = (Visibility)0;
			((UIElement)textBox_b2_ZontPrystinnyyTyp3).Visibility = (Visibility)0;
			((UIElement)label_b2_ZontPrystinnyyTyp3).Visibility = (Visibility)0;
			textBox_d2_ZontPrystinnyyTyp3.Clear();
			((UIElement)textBox_d2_ZontPrystinnyyTyp3).Visibility = (Visibility)2;
			((UIElement)label_d2_ZontPrystinnyyTyp3).Visibility = (Visibility)2;
		}
		textBox_p2_ZontPrystinnyyTyp3.Text = "50";
		((UIElement)textBox_p2_ZontPrystinnyyTyp3).Visibility = (Visibility)0;
		((UIElement)label_p2_ZontPrystinnyyTyp3).Visibility = (Visibility)0;
		((UIElement)textBox_f2_ZontPrystinnyyTyp3).Visibility = (Visibility)0;
		((UIElement)label_f2_ZontPrystinnyyTyp3).Visibility = (Visibility)0;
		((UIElement)textBox_g2_ZontPrystinnyyTyp3).Visibility = (Visibility)0;
		((UIElement)label_g2_ZontPrystinnyyTyp3).Visibility = (Visibility)0;
		((Selector)comboBox_typVyhid2_ZontPrystinnyyTyp3).SelectedIndex = 0;
		((UIElement)comboBox_typVyhid2_ZontPrystinnyyTyp3).Visibility = (Visibility)0;
		((UIElement)label_typVyhid2_ZontPrystinnyyTyp3).Visibility = (Visibility)0;
		ParentWindow.ZontPrystinnyyTyp3_SetFirstImage();
	}

	private void ZontPrystinnyyTyp3_TypVyhid2Cbox_SelectionChanged(object sender, RoutedEventArgs e)
	{
		ZontVytiajniyHelper.ZontVytiajniy_TypVyhidCbox_SelectionChanged((ComboBox)((sender is ComboBox) ? sender : null), comboBox_Vyhid2_ZontPrystinnyyTyp3, comboBox_profilType2_ZontPrystinnyyTyp3, label_profilType2_ZontPrystinnyyTyp3);
	}

	public void ZontPrystinnyyTyp3_TextBox_d2_LostFocus(object sender, RoutedEventArgs e)
	{
		//IL_00c8: Unknown result type (might be due to invalid IL or missing references)
		if (string.IsNullOrEmpty(comboBox_Vyhid2_ZontPrystinnyyTyp3?.GetValue()))
		{
			return;
		}
		TextBox val = textBox_d2_ZontPrystinnyyTyp3;
		if (int.TryParse(val.Text, out var result) && int.TryParse(ParentWindow.textBox_a_ZontPrystinnyyTyp3.Text, out var result2) && int.TryParse(ParentWindow.textBox_b_ZontPrystinnyyTyp3.Text, out var result3))
		{
			int num = ZontPrystinnyyTyp3_TextBox_d2a2_GetMinValue();
			int num2 = Math.Min(result2, result3) - 10;
			if (num2 > num && (result < num || result > num2))
			{
				val.Text = "";
				MessageBox.Show($"Діаметр вихода 2 має бути в межах {num} - {num2} мм");
				return;
			}
		}
		ZontPrystinnyyTyp3_TextBox_f2_LostFocus(null, null);
		ZontPrystinnyyTyp3_TextBox_g2_LostFocus(null, null);
		if (sender != null)
		{
			ParentWindow.ZontPrystinnyyTyp3_TextBox_LostFocus(sender, e);
		}
	}

	public void ZontPrystinnyyTyp3_TextBox_a2_LostFocus(object sender, RoutedEventArgs e)
	{
		//IL_00a7: Unknown result type (might be due to invalid IL or missing references)
		if (string.IsNullOrEmpty(comboBox_Vyhid2_ZontPrystinnyyTyp3?.GetValue()))
		{
			return;
		}
		TextBox val = textBox_a2_ZontPrystinnyyTyp3;
		if (int.TryParse(val.Text, out var result) && int.TryParse(ParentWindow.textBox_a_ZontPrystinnyyTyp3.Text, out var result2))
		{
			int num = ZontPrystinnyyTyp3_TextBox_d2a2_GetMinValue();
			int num2 = result2 - 10;
			if (num2 > num && (result < num || result > num2))
			{
				val.Text = "";
				MessageBox.Show($"Довжина вихода 2 має бути в межах {num} - {num2} мм");
				return;
			}
		}
		ZontPrystinnyyTyp3_TextBox_f2_LostFocus(null, null);
		ParentWindow.ZontPrystinnyyTyp3_TextBox_a_SetDefaultValue();
		if (sender != null)
		{
			ZontPrystinnyyTyp3_TextBox_Base_LostFocus(sender, e);
		}
	}

	public void ZontPrystinnyyTyp3_TextBox_b2_LostFocus(object sender, RoutedEventArgs e)
	{
		//IL_00a7: Unknown result type (might be due to invalid IL or missing references)
		if (string.IsNullOrEmpty(comboBox_Vyhid2_ZontPrystinnyyTyp3?.GetValue()))
		{
			return;
		}
		TextBox val = textBox_b2_ZontPrystinnyyTyp3;
		if (int.TryParse(val.Text, out var result) && int.TryParse(ParentWindow.textBox_b_ZontPrystinnyyTyp3.Text, out var result2))
		{
			int num = ZontPrystinnyyTyp3_TextBox_b2_GetMinValue();
			int num2 = result2 - 10;
			if (num2 > num && (result < num || result > num2))
			{
				val.Text = "";
				MessageBox.Show($"Ширина вихода 2 має бути в межах {num} - {num2} мм");
				return;
			}
		}
		ZontPrystinnyyTyp3_TextBox_g2_LostFocus(null, null);
		ParentWindow.ZontPrystinnyyTyp3_TextBox_b_SetDefaultValue();
		if (sender != null)
		{
			ZontPrystinnyyTyp3_TextBox_Base_LostFocus(sender, e);
		}
	}

	public void ZontPrystinnyyTyp3_TextBox_p2_LostFocus(object sender, RoutedEventArgs e)
	{
		//IL_0090: Unknown result type (might be due to invalid IL or missing references)
		string text = comboBox_Vyhid2_ZontPrystinnyyTyp3?.GetValue();
		if (!string.IsNullOrEmpty(text))
		{
			int num = ((text == "круглий") ? 50 : 30);
			TextBox val = textBox_p2_ZontPrystinnyyTyp3;
			if (int.TryParse(val.Text, out var result) && (result < num || result > 600))
			{
				val.Text = "";
				MessageBox.Show($"Висота вихода 2 має бути в межах {num} - {600} мм");
			}
			else if (sender != null)
			{
				ParentWindow.ZontPrystinnyyTyp3_TextBox_LostFocus(sender, e);
			}
		}
	}

	public void ZontPrystinnyyTyp3_TextBox_f2_LostFocus(object sender, RoutedEventArgs e)
	{
		//IL_01a2: Unknown result type (might be due to invalid IL or missing references)
		string text = comboBox_Vyhid1_ZontPrystinnyyTyp3?.GetValue();
		string text2 = comboBox_Vyhid2_ZontPrystinnyyTyp3?.GetValue();
		if (string.IsNullOrEmpty(text) || string.IsNullOrEmpty(text2))
		{
			return;
		}
		TextBox val = textBox_f2_ZontPrystinnyyTyp3;
		if (int.TryParse(val.Text, out var result) && int.TryParse(ParentWindow.textBox_a_ZontPrystinnyyTyp3.Text, out var result2))
		{
			int num = 0;
			int num2 = 0;
			int result4;
			if (text == "круглий" && int.TryParse(textBox_d1_ZontPrystinnyyTyp3.Text, out var result3))
			{
				num = result3;
			}
			else if (text == "прямокутний" && int.TryParse(textBox_a1_ZontPrystinnyyTyp3.Text, out result4))
			{
				num = result4;
			}
			int result6;
			if (text2 == "круглий" && int.TryParse(textBox_d2_ZontPrystinnyyTyp3.Text, out var result5))
			{
				num2 = result5;
			}
			else if (text2 == "прямокутний" && int.TryParse(textBox_a2_ZontPrystinnyyTyp3.Text, out result6))
			{
				num2 = result6;
			}
			int num3 = 10 + num + 50 + num2 / 2;
			int num4 = result2 - 10 - num2 / 2;
			if (num4 > num3 && num4 != 0 && (result <= num3 || result >= num4))
			{
				val.Text = "";
				MessageBox.Show($"Розміщення по довжині вихода 2 має бути більше ніж {num3} і менше ніж {num4} мм");
				return;
			}
		}
		if (sender != null)
		{
			ZontPrystinnyyTyp3_TextBox_Base_LostFocus(sender, e);
		}
	}

	public void ZontPrystinnyyTyp3_TextBox_g2_LostFocus(object sender, RoutedEventArgs e)
	{
		//IL_01a2: Unknown result type (might be due to invalid IL or missing references)
		string text = comboBox_Vyhid1_ZontPrystinnyyTyp3?.GetValue();
		string text2 = comboBox_Vyhid2_ZontPrystinnyyTyp3?.GetValue();
		if (string.IsNullOrEmpty(text) || string.IsNullOrEmpty(text2))
		{
			return;
		}
		TextBox val = textBox_f2_ZontPrystinnyyTyp3;
		if (int.TryParse(val.Text, out var result) && int.TryParse(ParentWindow.textBox_b_ZontPrystinnyyTyp3.Text, out var result2))
		{
			int num = 0;
			int num2 = 0;
			int result4;
			if (text == "круглий" && int.TryParse(textBox_d1_ZontPrystinnyyTyp3.Text, out var result3))
			{
				num = result3;
			}
			else if (text == "прямокутний" && int.TryParse(textBox_b1_ZontPrystinnyyTyp3.Text, out result4))
			{
				num = result4;
			}
			int result6;
			if (text2 == "круглий" && int.TryParse(textBox_d2_ZontPrystinnyyTyp3.Text, out var result5))
			{
				num2 = result5;
			}
			else if (text2 == "прямокутний" && int.TryParse(textBox_b2_ZontPrystinnyyTyp3.Text, out result6))
			{
				num2 = result6;
			}
			int num3 = 10 + num + 50 + num2 / 2;
			int num4 = result2 - 10 - num2 / 2;
			if (num4 > num3 && num4 != 0 && (result <= num3 || result >= num4))
			{
				val.Text = "";
				MessageBox.Show($"Розміщення по ширині вихода 2 має бути більше ніж {num3} і менше ніж {num4} мм");
				return;
			}
		}
		if (sender != null)
		{
			ZontPrystinnyyTyp3_TextBox_Base_LostFocus(sender, e);
		}
	}

	private void ZontPrystinnyyTyp3_TextBox_p2_PreviewMouseLeftButtonUp(object sender, MouseButtonEventArgs e)
	{
		ParentWindow.ZontPrystinnyyTyp3_SetImage("p2");
	}

	private void ZontPrystinnyyTyp3_TextBox_g2_PreviewMouseLeftButtonUp(object sender, MouseButtonEventArgs e)
	{
		ZontPrystinnyyTyp3_SetInnerImage("g2");
	}

	private void ZontPrystinnyyTyp3_TextBox_f2_PreviewMouseLeftButtonUp(object sender, MouseButtonEventArgs e)
	{
		ZontPrystinnyyTyp3_SetInnerImage("f2");
	}

	private void TextBox_GotFocus(object sender, RoutedEventArgs e)
	{
		ParentWindow.TextBox_GotFocus(sender, e);
	}

	public void ZontPrystinnyyTyp3_TextBox_LostFocus(object sender, RoutedEventArgs e)
	{
		ParentWindow.ZontPrystinnyyTyp3_TextBox_LostFocus(sender, e);
	}

	public void ZontPrystinnyyTyp3_TextBox_Base_LostFocus(object sender, RoutedEventArgs e)
	{
		ZontPrystinnyyTyp3_Img.Source = null;
		((UIElement)ZontPrystinnyyTyp3_Img).Visibility = (Visibility)2;
		if (ParentWindow.TextBoxHasValue(sender))
		{
		}
	}

	public void ZontPrystinnyyTyp3_SetInnerImage(string parameter)
	{
		ZontPrystinnyyTyp3_SetImages(ParentWindow.ZontPrystinnyyTyp3_GetTopImagePath(parameter));
	}

	private void ZontPrystinnyyTyp3_SetImages(string imagePath)
	{
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0035: Expected O, but got Unknown
		ParentWindow.shapeImg.Source = (ImageSource)new BitmapImage(new Uri(imagePath, UriKind.Relative));
		ZontPrystinnyyTyp3_Img.Source = (ImageSource)new BitmapImage(new Uri(imagePath, UriKind.Relative));
		((UIElement)ZontPrystinnyyTyp3_Img).Visibility = (Visibility)0;
	}

	private int ZontPrystinnyyTyp3_TextBox_d2a2_GetMinValue()
	{
		string text = comboBox_Vyhid1_ZontPrystinnyyTyp3?.GetValue();
		if (text == "круглий" && int.TryParse(textBox_d1_ZontPrystinnyyTyp3.Text, out var result))
		{
			return result + 60;
		}
		if (text == "прямокутний" && int.TryParse(textBox_a1_ZontPrystinnyyTyp3.Text, out var result2))
		{
			return result2 + 60;
		}
		return 60;
	}

	private int ZontPrystinnyyTyp3_TextBox_b2_GetMinValue()
	{
		string text = comboBox_Vyhid1_ZontPrystinnyyTyp3?.GetValue();
		if (text == "круглий" && int.TryParse(textBox_d1_ZontPrystinnyyTyp3.Text, out var result))
		{
			return result + 60;
		}
		if (text == "прямокутний" && int.TryParse(textBox_b1_ZontPrystinnyyTyp3.Text, out var result2))
		{
			return result2 + 60;
		}
		return 60;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	public void InitializeComponent()
	{
		if (!_contentLoaded)
		{
			_contentLoaded = true;
			Uri uri = new Uri("/TEZ_Project;component/productwindows/zontprystinnyytyp3window.xaml", UriKind.Relative);
			Application.LoadComponent((object)this, uri);
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	[EditorBrowsable(EditorBrowsableState.Never)]
	void IComponentConnector.Connect(int connectionId, object target)
	{
		//IL_00b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c2: Expected O, but got Unknown
		//IL_00c9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d3: Expected O, but got Unknown
		//IL_00da: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e4: Expected O, but got Unknown
		//IL_00eb: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f5: Expected O, but got Unknown
		//IL_0102: Unknown result type (might be due to invalid IL or missing references)
		//IL_010c: Expected O, but got Unknown
		//IL_011a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0124: Expected O, but got Unknown
		//IL_012c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0136: Expected O, but got Unknown
		//IL_0143: Unknown result type (might be due to invalid IL or missing references)
		//IL_014d: Expected O, but got Unknown
		//IL_015b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0165: Expected O, but got Unknown
		//IL_016d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0177: Expected O, but got Unknown
		//IL_0184: Unknown result type (might be due to invalid IL or missing references)
		//IL_018e: Expected O, but got Unknown
		//IL_019c: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a6: Expected O, but got Unknown
		//IL_01ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b8: Expected O, but got Unknown
		//IL_01c5: Unknown result type (might be due to invalid IL or missing references)
		//IL_01cf: Expected O, but got Unknown
		//IL_01dd: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e7: Expected O, but got Unknown
		//IL_01f5: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ff: Expected O, but got Unknown
		//IL_0207: Unknown result type (might be due to invalid IL or missing references)
		//IL_0211: Expected O, but got Unknown
		//IL_021e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0228: Expected O, but got Unknown
		//IL_0236: Unknown result type (might be due to invalid IL or missing references)
		//IL_0240: Expected O, but got Unknown
		//IL_024e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0258: Expected O, but got Unknown
		//IL_0260: Unknown result type (might be due to invalid IL or missing references)
		//IL_026a: Expected O, but got Unknown
		//IL_0277: Unknown result type (might be due to invalid IL or missing references)
		//IL_0281: Expected O, but got Unknown
		//IL_028f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0299: Expected O, but got Unknown
		//IL_02a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b1: Expected O, but got Unknown
		//IL_02b9: Unknown result type (might be due to invalid IL or missing references)
		//IL_02c3: Expected O, but got Unknown
		//IL_02d0: Unknown result type (might be due to invalid IL or missing references)
		//IL_02da: Expected O, but got Unknown
		//IL_02e2: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ec: Expected O, but got Unknown
		//IL_02f3: Unknown result type (might be due to invalid IL or missing references)
		//IL_02fd: Expected O, but got Unknown
		//IL_0304: Unknown result type (might be due to invalid IL or missing references)
		//IL_030e: Expected O, but got Unknown
		//IL_0315: Unknown result type (might be due to invalid IL or missing references)
		//IL_031f: Expected O, but got Unknown
		//IL_0326: Unknown result type (might be due to invalid IL or missing references)
		//IL_0330: Expected O, but got Unknown
		//IL_0337: Unknown result type (might be due to invalid IL or missing references)
		//IL_0341: Expected O, but got Unknown
		//IL_0348: Unknown result type (might be due to invalid IL or missing references)
		//IL_0352: Expected O, but got Unknown
		//IL_0359: Unknown result type (might be due to invalid IL or missing references)
		//IL_0363: Expected O, but got Unknown
		//IL_036a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0374: Expected O, but got Unknown
		//IL_037b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0385: Expected O, but got Unknown
		//IL_038c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0396: Expected O, but got Unknown
		//IL_039d: Unknown result type (might be due to invalid IL or missing references)
		//IL_03a7: Expected O, but got Unknown
		//IL_03ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_03b8: Expected O, but got Unknown
		//IL_03bf: Unknown result type (might be due to invalid IL or missing references)
		//IL_03c9: Expected O, but got Unknown
		//IL_03d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_03e0: Expected O, but got Unknown
		//IL_03ee: Unknown result type (might be due to invalid IL or missing references)
		//IL_03f8: Expected O, but got Unknown
		//IL_0400: Unknown result type (might be due to invalid IL or missing references)
		//IL_040a: Expected O, but got Unknown
		//IL_0417: Unknown result type (might be due to invalid IL or missing references)
		//IL_0421: Expected O, but got Unknown
		//IL_042f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0439: Expected O, but got Unknown
		//IL_0441: Unknown result type (might be due to invalid IL or missing references)
		//IL_044b: Expected O, but got Unknown
		//IL_0458: Unknown result type (might be due to invalid IL or missing references)
		//IL_0462: Expected O, but got Unknown
		//IL_0470: Unknown result type (might be due to invalid IL or missing references)
		//IL_047a: Expected O, but got Unknown
		//IL_0482: Unknown result type (might be due to invalid IL or missing references)
		//IL_048c: Expected O, but got Unknown
		//IL_0499: Unknown result type (might be due to invalid IL or missing references)
		//IL_04a3: Expected O, but got Unknown
		//IL_04b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_04bb: Expected O, but got Unknown
		//IL_04c9: Unknown result type (might be due to invalid IL or missing references)
		//IL_04d3: Expected O, but got Unknown
		//IL_04db: Unknown result type (might be due to invalid IL or missing references)
		//IL_04e5: Expected O, but got Unknown
		//IL_04f2: Unknown result type (might be due to invalid IL or missing references)
		//IL_04fc: Expected O, but got Unknown
		//IL_050a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0514: Expected O, but got Unknown
		//IL_0522: Unknown result type (might be due to invalid IL or missing references)
		//IL_052c: Expected O, but got Unknown
		//IL_0534: Unknown result type (might be due to invalid IL or missing references)
		//IL_053e: Expected O, but got Unknown
		//IL_054b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0555: Expected O, but got Unknown
		//IL_0563: Unknown result type (might be due to invalid IL or missing references)
		//IL_056d: Expected O, but got Unknown
		//IL_057b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0585: Expected O, but got Unknown
		//IL_058d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0597: Expected O, but got Unknown
		//IL_059e: Unknown result type (might be due to invalid IL or missing references)
		//IL_05a8: Expected O, but got Unknown
		//IL_05af: Unknown result type (might be due to invalid IL or missing references)
		//IL_05b9: Expected O, but got Unknown
		//IL_05c0: Unknown result type (might be due to invalid IL or missing references)
		//IL_05ca: Expected O, but got Unknown
		//IL_05ce: Unknown result type (might be due to invalid IL or missing references)
		//IL_05d8: Expected O, but got Unknown
		//IL_05dc: Unknown result type (might be due to invalid IL or missing references)
		//IL_05e6: Expected O, but got Unknown
		//IL_05ea: Unknown result type (might be due to invalid IL or missing references)
		//IL_05f4: Expected O, but got Unknown
		//IL_05f8: Unknown result type (might be due to invalid IL or missing references)
		//IL_0602: Expected O, but got Unknown
		//IL_0606: Unknown result type (might be due to invalid IL or missing references)
		//IL_0610: Expected O, but got Unknown
		//IL_0614: Unknown result type (might be due to invalid IL or missing references)
		//IL_061e: Expected O, but got Unknown
		//IL_0622: Unknown result type (might be due to invalid IL or missing references)
		//IL_062c: Expected O, but got Unknown
		//IL_0630: Unknown result type (might be due to invalid IL or missing references)
		//IL_063a: Expected O, but got Unknown
		switch (connectionId)
		{
		case 1:
			ZontPrystinnyyTyp3_Img = (Image)target;
			break;
		case 2:
			inputDataZontPrystinnyyTyp3_Vyhid1 = (GroupBox)target;
			break;
		case 3:
			inputDataInnerGridZontPrystinnyyTyp3_Vyhid1 = (Grid)target;
			break;
		case 4:
			textBox_d1_ZontPrystinnyyTyp3 = (TextBox)target;
			((UIElement)textBox_d1_ZontPrystinnyyTyp3).LostFocus += new RoutedEventHandler(ZontPrystinnyyTyp3_TextBox_d1_LostFocus);
			((UIElement)textBox_d1_ZontPrystinnyyTyp3).GotFocus += new RoutedEventHandler(TextBox_GotFocus);
			break;
		case 5:
			textBox_a1_ZontPrystinnyyTyp3 = (TextBox)target;
			((UIElement)textBox_a1_ZontPrystinnyyTyp3).LostFocus += new RoutedEventHandler(ZontPrystinnyyTyp3_TextBox_a1_LostFocus);
			((UIElement)textBox_a1_ZontPrystinnyyTyp3).GotFocus += new RoutedEventHandler(TextBox_GotFocus);
			break;
		case 6:
			textBox_b1_ZontPrystinnyyTyp3 = (TextBox)target;
			((UIElement)textBox_b1_ZontPrystinnyyTyp3).LostFocus += new RoutedEventHandler(ZontPrystinnyyTyp3_TextBox_b1_LostFocus);
			((UIElement)textBox_b1_ZontPrystinnyyTyp3).GotFocus += new RoutedEventHandler(TextBox_GotFocus);
			break;
		case 7:
			textBox_p1_ZontPrystinnyyTyp3 = (TextBox)target;
			((UIElement)textBox_p1_ZontPrystinnyyTyp3).LostFocus += new RoutedEventHandler(ZontPrystinnyyTyp3_TextBox_p1_LostFocus);
			((UIElement)textBox_p1_ZontPrystinnyyTyp3).PreviewMouseLeftButtonUp += new MouseButtonEventHandler(ZontPrystinnyyTyp3_TextBox_p1_PreviewMouseLeftButtonUp);
			((UIElement)textBox_p1_ZontPrystinnyyTyp3).GotFocus += new RoutedEventHandler(TextBox_GotFocus);
			break;
		case 8:
			textBox_f1_ZontPrystinnyyTyp3 = (TextBox)target;
			((UIElement)textBox_f1_ZontPrystinnyyTyp3).LostFocus += new RoutedEventHandler(ZontPrystinnyyTyp3_TextBox_f1_LostFocus);
			((UIElement)textBox_f1_ZontPrystinnyyTyp3).PreviewMouseLeftButtonUp += new MouseButtonEventHandler(ZontPrystinnyyTyp3_TextBox_f1_PreviewMouseLeftButtonUp);
			((UIElement)textBox_f1_ZontPrystinnyyTyp3).GotFocus += new RoutedEventHandler(TextBox_GotFocus);
			break;
		case 9:
			textBox_g1_ZontPrystinnyyTyp3 = (TextBox)target;
			((UIElement)textBox_g1_ZontPrystinnyyTyp3).LostFocus += new RoutedEventHandler(ZontPrystinnyyTyp3_TextBox_g1_LostFocus);
			((UIElement)textBox_g1_ZontPrystinnyyTyp3).PreviewMouseLeftButtonUp += new MouseButtonEventHandler(ZontPrystinnyyTyp3_TextBox_g1_PreviewMouseLeftButtonUp);
			((UIElement)textBox_g1_ZontPrystinnyyTyp3).GotFocus += new RoutedEventHandler(TextBox_GotFocus);
			break;
		case 10:
			comboBox_Vyhid1_ZontPrystinnyyTyp3 = (ComboBox)target;
			((Selector)comboBox_Vyhid1_ZontPrystinnyyTyp3).SelectionChanged += new SelectionChangedEventHandler(ZontPrystinnyyTyp3_Vyhid1Cbox_SelectionChanged);
			break;
		case 11:
			comboBox_typVyhid1_ZontPrystinnyyTyp3 = (ComboBox)target;
			break;
		case 12:
			comboBox_profilType1_ZontPrystinnyyTyp3 = (ComboBox)target;
			break;
		case 13:
			label_d1_ZontPrystinnyyTyp3 = (Label)target;
			break;
		case 14:
			label_p1_ZontPrystinnyyTyp3 = (Label)target;
			break;
		case 15:
			label_f1_ZontPrystinnyyTyp3 = (Label)target;
			break;
		case 16:
			label_g1_ZontPrystinnyyTyp3 = (Label)target;
			break;
		case 17:
			label_a1_ZontPrystinnyyTyp3 = (Label)target;
			break;
		case 18:
			label_b1_ZontPrystinnyyTyp3 = (Label)target;
			break;
		case 19:
			label_typVyhid1_ZontPrystinnyyTyp3 = (Label)target;
			break;
		case 20:
			label_Vyhid1_ZontPrystinnyyTyp3 = (Label)target;
			break;
		case 21:
			label_profilType1_ZontPrystinnyyTyp3 = (Label)target;
			break;
		case 22:
			inputDataZontPrystinnyyTyp3_Vyhid2 = (GroupBox)target;
			break;
		case 23:
			inputDataInnerGridZontPrystinnyyTyp3_Vyhid2 = (Grid)target;
			break;
		case 24:
			textBox_d2_ZontPrystinnyyTyp3 = (TextBox)target;
			((UIElement)textBox_d2_ZontPrystinnyyTyp3).LostFocus += new RoutedEventHandler(ZontPrystinnyyTyp3_TextBox_d2_LostFocus);
			((UIElement)textBox_d2_ZontPrystinnyyTyp3).GotFocus += new RoutedEventHandler(TextBox_GotFocus);
			break;
		case 25:
			textBox_a2_ZontPrystinnyyTyp3 = (TextBox)target;
			((UIElement)textBox_a2_ZontPrystinnyyTyp3).LostFocus += new RoutedEventHandler(ZontPrystinnyyTyp3_TextBox_a2_LostFocus);
			((UIElement)textBox_a2_ZontPrystinnyyTyp3).GotFocus += new RoutedEventHandler(TextBox_GotFocus);
			break;
		case 26:
			textBox_b2_ZontPrystinnyyTyp3 = (TextBox)target;
			((UIElement)textBox_b2_ZontPrystinnyyTyp3).LostFocus += new RoutedEventHandler(ZontPrystinnyyTyp3_TextBox_b2_LostFocus);
			((UIElement)textBox_b2_ZontPrystinnyyTyp3).GotFocus += new RoutedEventHandler(TextBox_GotFocus);
			break;
		case 27:
			textBox_p2_ZontPrystinnyyTyp3 = (TextBox)target;
			((UIElement)textBox_p2_ZontPrystinnyyTyp3).LostFocus += new RoutedEventHandler(ZontPrystinnyyTyp3_TextBox_p2_LostFocus);
			((UIElement)textBox_p2_ZontPrystinnyyTyp3).PreviewMouseLeftButtonUp += new MouseButtonEventHandler(ZontPrystinnyyTyp3_TextBox_p2_PreviewMouseLeftButtonUp);
			((UIElement)textBox_p2_ZontPrystinnyyTyp3).GotFocus += new RoutedEventHandler(TextBox_GotFocus);
			break;
		case 28:
			textBox_f2_ZontPrystinnyyTyp3 = (TextBox)target;
			((UIElement)textBox_f2_ZontPrystinnyyTyp3).LostFocus += new RoutedEventHandler(ZontPrystinnyyTyp3_TextBox_Base_LostFocus);
			((UIElement)textBox_f2_ZontPrystinnyyTyp3).PreviewMouseLeftButtonUp += new MouseButtonEventHandler(ZontPrystinnyyTyp3_TextBox_f2_PreviewMouseLeftButtonUp);
			((UIElement)textBox_f2_ZontPrystinnyyTyp3).GotFocus += new RoutedEventHandler(TextBox_GotFocus);
			break;
		case 29:
			textBox_g2_ZontPrystinnyyTyp3 = (TextBox)target;
			((UIElement)textBox_g2_ZontPrystinnyyTyp3).LostFocus += new RoutedEventHandler(ZontPrystinnyyTyp3_TextBox_Base_LostFocus);
			((UIElement)textBox_g2_ZontPrystinnyyTyp3).PreviewMouseLeftButtonUp += new MouseButtonEventHandler(ZontPrystinnyyTyp3_TextBox_g2_PreviewMouseLeftButtonUp);
			((UIElement)textBox_g2_ZontPrystinnyyTyp3).GotFocus += new RoutedEventHandler(TextBox_GotFocus);
			break;
		case 30:
			comboBox_Vyhid2_ZontPrystinnyyTyp3 = (ComboBox)target;
			break;
		case 31:
			comboBox_typVyhid2_ZontPrystinnyyTyp3 = (ComboBox)target;
			break;
		case 32:
			comboBox_profilType2_ZontPrystinnyyTyp3 = (ComboBox)target;
			break;
		case 33:
			label_d2_ZontPrystinnyyTyp3 = (Label)target;
			break;
		case 34:
			label_p2_ZontPrystinnyyTyp3 = (Label)target;
			break;
		case 35:
			label_f2_ZontPrystinnyyTyp3 = (Label)target;
			break;
		case 36:
			label_g2_ZontPrystinnyyTyp3 = (Label)target;
			break;
		case 37:
			label_a2_ZontPrystinnyyTyp3 = (Label)target;
			break;
		case 38:
			label_b2_ZontPrystinnyyTyp3 = (Label)target;
			break;
		case 39:
			label_typVyhid2_ZontPrystinnyyTyp3 = (Label)target;
			break;
		case 40:
			label_Vyhid2_ZontPrystinnyyTyp3 = (Label)target;
			break;
		case 41:
			label_profilType2_ZontPrystinnyyTyp3 = (Label)target;
			break;
		default:
			_contentLoaded = true;
			break;
		}
	}
}
