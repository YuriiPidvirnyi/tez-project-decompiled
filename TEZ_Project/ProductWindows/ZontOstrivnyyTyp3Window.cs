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

public class ZontOstrivnyyTyp3Window : Window, IComponentConnector
{
	internal Image ZontOstrivnyyTyp3_Img;

	internal GroupBox inputDataZontOstrivnyyTyp3_Vyhid1;

	internal Grid inputDataInnerGridZontOstrivnyyTyp3_Vyhid1;

	internal TextBox textBox_d1_ZontOstrivnyyTyp3;

	internal TextBox textBox_a1_ZontOstrivnyyTyp3;

	internal TextBox textBox_b1_ZontOstrivnyyTyp3;

	internal TextBox textBox_p1_ZontOstrivnyyTyp3;

	internal TextBox textBox_f1_ZontOstrivnyyTyp3;

	internal TextBox textBox_g1_ZontOstrivnyyTyp3;

	internal ComboBox comboBox_Vyhid1_ZontOstrivnyyTyp3;

	internal ComboBox comboBox_typVyhid1_ZontOstrivnyyTyp3;

	internal ComboBox comboBox_profilType1_ZontOstrivnyyTyp3;

	internal Label label_d1_ZontOstrivnyyTyp3;

	internal Label label_p1_ZontOstrivnyyTyp3;

	internal Label label_f1_ZontOstrivnyyTyp3;

	internal Label label_g1_ZontOstrivnyyTyp3;

	internal Label label_a1_ZontOstrivnyyTyp3;

	internal Label label_b1_ZontOstrivnyyTyp3;

	internal Label label_typVyhid1_ZontOstrivnyyTyp3;

	internal Label label_Vyhid1_ZontOstrivnyyTyp3;

	internal Label label_profilType1_ZontOstrivnyyTyp3;

	internal GroupBox inputDataZontOstrivnyyTyp3_Vyhid2;

	internal Grid inputDataInnerGridZontOstrivnyyTyp3_Vyhid2;

	internal TextBox textBox_d2_ZontOstrivnyyTyp3;

	internal TextBox textBox_a2_ZontOstrivnyyTyp3;

	internal TextBox textBox_b2_ZontOstrivnyyTyp3;

	internal TextBox textBox_p2_ZontOstrivnyyTyp3;

	internal TextBox textBox_f2_ZontOstrivnyyTyp3;

	internal TextBox textBox_g2_ZontOstrivnyyTyp3;

	internal ComboBox comboBox_Vyhid2_ZontOstrivnyyTyp3;

	internal ComboBox comboBox_typVyhid2_ZontOstrivnyyTyp3;

	internal ComboBox comboBox_profilType2_ZontOstrivnyyTyp3;

	internal Label label_d2_ZontOstrivnyyTyp3;

	internal Label label_p2_ZontOstrivnyyTyp3;

	internal Label label_f2_ZontOstrivnyyTyp3;

	internal Label label_g2_ZontOstrivnyyTyp3;

	internal Label label_a2_ZontOstrivnyyTyp3;

	internal Label label_b2_ZontOstrivnyyTyp3;

	internal Label label_typVyhid2_ZontOstrivnyyTyp3;

	internal Label label_Vyhid2_ZontOstrivnyyTyp3;

	internal Label label_profilType2_ZontOstrivnyyTyp3;

	internal GroupBox inputDataZontOstrivnyyTyp3_Vyhid3;

	internal Grid inputDataInnerGridZontOstrivnyyTyp3_Vyhid3;

	internal TextBox textBox_d3_ZontOstrivnyyTyp3;

	internal TextBox textBox_a3_ZontOstrivnyyTyp3;

	internal TextBox textBox_b3_ZontOstrivnyyTyp3;

	internal TextBox textBox_p3_ZontOstrivnyyTyp3;

	internal TextBox textBox_f3_ZontOstrivnyyTyp3;

	internal TextBox textBox_g3_ZontOstrivnyyTyp3;

	internal ComboBox comboBox_Vyhid3_ZontOstrivnyyTyp3;

	internal ComboBox comboBox_typVyhid3_ZontOstrivnyyTyp3;

	internal ComboBox comboBox_profilType3_ZontOstrivnyyTyp3;

	internal Label label_d3_ZontOstrivnyyTyp3;

	internal Label label_p3_ZontOstrivnyyTyp3;

	internal Label label_f3_ZontOstrivnyyTyp3;

	internal Label label_g3_ZontOstrivnyyTyp3;

	internal Label label_a3_ZontOstrivnyyTyp3;

	internal Label label_b3_ZontOstrivnyyTyp3;

	internal Label label_typVyhid3_ZontOstrivnyyTyp3;

	internal Label label_Vyhid3_ZontOstrivnyyTyp3;

	internal Label label_profilType3_ZontOstrivnyyTyp3;

	private bool _contentLoaded;

	public MainWindow ParentWindow { get; set; }

	public ZontOstrivnyyTyp3Window()
	{
		InitializeComponent();
		ZontOstrivnyyTyp3_Vyhid_AttachEventHandlersToComboBoxes();
	}

	private void ZontOstrivnyyTyp3_Vyhid_AttachEventHandlersToComboBoxes()
	{
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0018: Expected O, but got Unknown
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		//IL_0030: Expected O, but got Unknown
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0048: Expected O, but got Unknown
		//IL_0056: Unknown result type (might be due to invalid IL or missing references)
		//IL_0060: Expected O, but got Unknown
		//IL_006e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0078: Expected O, but got Unknown
		((Selector)comboBox_Vyhid2_ZontOstrivnyyTyp3).SelectionChanged += new SelectionChangedEventHandler(ZontOstrivnyyTyp3_Vyhid2Cbox_SelectionChanged);
		((Selector)comboBox_Vyhid3_ZontOstrivnyyTyp3).SelectionChanged += new SelectionChangedEventHandler(ZontOstrivnyyTyp3_Vyhid3Cbox_SelectionChanged);
		((Selector)comboBox_typVyhid1_ZontOstrivnyyTyp3).SelectionChanged += new SelectionChangedEventHandler(ZontOstrivnyyTyp3_TypVyhid1Cbox_SelectionChanged);
		((Selector)comboBox_typVyhid2_ZontOstrivnyyTyp3).SelectionChanged += new SelectionChangedEventHandler(ZontOstrivnyyTyp3_TypVyhid2Cbox_SelectionChanged);
		((Selector)comboBox_typVyhid3_ZontOstrivnyyTyp3).SelectionChanged += new SelectionChangedEventHandler(ZontOstrivnyyTyp3_TypVyhid3Cbox_SelectionChanged);
	}

	private void ZontOstrivnyyTyp3_Vyhid1Cbox_SelectionChanged(object sender, RoutedEventArgs e)
	{
		string text = comboBox_Vyhid1_ZontOstrivnyyTyp3?.GetValue();
		if (string.IsNullOrEmpty(text))
		{
			ParentWindow.ZontOstrivnyyTyp3_SetFirstImage();
			return;
		}
		if (text == "круглий")
		{
			((UIElement)textBox_d1_ZontOstrivnyyTyp3).Visibility = (Visibility)0;
			((UIElement)label_d1_ZontOstrivnyyTyp3).Visibility = (Visibility)0;
			textBox_a1_ZontOstrivnyyTyp3.Clear();
			((UIElement)textBox_a1_ZontOstrivnyyTyp3).Visibility = (Visibility)2;
			((UIElement)label_a1_ZontOstrivnyyTyp3).Visibility = (Visibility)2;
			textBox_b1_ZontOstrivnyyTyp3.Clear();
			((UIElement)textBox_b1_ZontOstrivnyyTyp3).Visibility = (Visibility)2;
			((UIElement)label_b1_ZontOstrivnyyTyp3).Visibility = (Visibility)2;
		}
		else if (text == "прямокутний")
		{
			((UIElement)textBox_a1_ZontOstrivnyyTyp3).Visibility = (Visibility)0;
			((UIElement)label_a1_ZontOstrivnyyTyp3).Visibility = (Visibility)0;
			((UIElement)textBox_b1_ZontOstrivnyyTyp3).Visibility = (Visibility)0;
			((UIElement)label_b1_ZontOstrivnyyTyp3).Visibility = (Visibility)0;
			textBox_d1_ZontOstrivnyyTyp3.Clear();
			((UIElement)textBox_d1_ZontOstrivnyyTyp3).Visibility = (Visibility)2;
			((UIElement)label_d1_ZontOstrivnyyTyp3).Visibility = (Visibility)2;
		}
		textBox_p1_ZontOstrivnyyTyp3.Text = "50";
		((UIElement)textBox_p1_ZontOstrivnyyTyp3).Visibility = (Visibility)0;
		((UIElement)label_p1_ZontOstrivnyyTyp3).Visibility = (Visibility)0;
		((UIElement)textBox_f1_ZontOstrivnyyTyp3).Visibility = (Visibility)0;
		((UIElement)label_f1_ZontOstrivnyyTyp3).Visibility = (Visibility)0;
		((UIElement)textBox_g1_ZontOstrivnyyTyp3).Visibility = (Visibility)0;
		((UIElement)label_g1_ZontOstrivnyyTyp3).Visibility = (Visibility)0;
		((Selector)comboBox_typVyhid1_ZontOstrivnyyTyp3).SelectedIndex = 0;
		((UIElement)comboBox_typVyhid1_ZontOstrivnyyTyp3).Visibility = (Visibility)0;
		((UIElement)label_typVyhid1_ZontOstrivnyyTyp3).Visibility = (Visibility)0;
		((UIElement)inputDataZontOstrivnyyTyp3_Vyhid2).Visibility = (Visibility)0;
		ParentWindow.ZontOstrivnyyTyp3_SetFirstImage();
	}

	private void ZontOstrivnyyTyp3_TypVyhid1Cbox_SelectionChanged(object sender, RoutedEventArgs e)
	{
		ZontVytiajniyHelper.ZontVytiajniy_TypVyhidCbox_SelectionChanged((ComboBox)((sender is ComboBox) ? sender : null), comboBox_Vyhid1_ZontOstrivnyyTyp3, comboBox_profilType1_ZontOstrivnyyTyp3, label_profilType1_ZontOstrivnyyTyp3);
	}

	public void ZontOstrivnyyTyp3_TextBox_d1_LostFocus(object sender, RoutedEventArgs e)
	{
		//IL_009e: Unknown result type (might be due to invalid IL or missing references)
		TextBox val = textBox_d1_ZontOstrivnyyTyp3;
		if (int.TryParse(val.Text, out var result) && int.TryParse(ParentWindow.textBox_a_ZontOstrivnyyTyp3.Text, out var result2) && int.TryParse(ParentWindow.textBox_b_ZontOstrivnyyTyp3.Text, out var result3))
		{
			int num = Math.Min(result2, result3) - 10;
			if (num > 10 && (result < 10 || result > num))
			{
				val.Text = "";
				MessageBox.Show($"Діаметр вихода 1 має бути в межах {10} - {num} мм");
				return;
			}
		}
		if (sender != null)
		{
			ZontOstrivnyyTyp3_TextBox_f1_LostFocus(null, null);
			ZontOstrivnyyTyp3_TextBox_g1_LostFocus(null, null);
			ZontOstrivnyyTyp3_TextBox_a2_LostFocus(null, null);
			ZontOstrivnyyTyp3_TextBox_b2_LostFocus(null, null);
			ZontOstrivnyyTyp3_TextBox_d2_LostFocus(null, null);
			ZontOstrivnyyTyp3_TextBox_f2_LostFocus(null, null);
			ZontOstrivnyyTyp3_TextBox_g2_LostFocus(null, null);
			ZontOstrivnyyTyp3_TextBox_a3_LostFocus(null, null);
			ZontOstrivnyyTyp3_TextBox_b3_LostFocus(null, null);
			ZontOstrivnyyTyp3_TextBox_d3_LostFocus(null, null);
			ZontOstrivnyyTyp3_TextBox_f3_LostFocus(null, null);
			ZontOstrivnyyTyp3_TextBox_g3_LostFocus(null, null);
			ParentWindow.ZontOstrivnyyTyp3_TextBox_a_SetDefaultValue();
			ParentWindow.ZontOstrivnyyTyp3_TextBox_b_SetDefaultValue();
		}
		if (sender != null)
		{
			ParentWindow.ZontOstrivnyyTyp3_TextBox_LostFocus(sender, e);
		}
	}

	public void ZontOstrivnyyTyp3_TextBox_a1_LostFocus(object sender, RoutedEventArgs e)
	{
		//IL_007d: Unknown result type (might be due to invalid IL or missing references)
		TextBox val = textBox_a1_ZontOstrivnyyTyp3;
		if (int.TryParse(val.Text, out var result) && int.TryParse(ParentWindow.textBox_a_ZontOstrivnyyTyp3.Text, out var result2))
		{
			int num = result2 - 10;
			if (num > 10 && (result < 10 || result > num))
			{
				val.Text = "";
				MessageBox.Show($"Довжина вихода 1 має бути в межах {10} - {num} мм");
				return;
			}
		}
		if (sender != null)
		{
			ZontOstrivnyyTyp3_TextBox_f1_LostFocus(null, null);
			ZontOstrivnyyTyp3_TextBox_d2_LostFocus(null, null);
			ZontOstrivnyyTyp3_TextBox_a2_LostFocus(null, null);
			ZontOstrivnyyTyp3_TextBox_f2_LostFocus(null, null);
			ZontOstrivnyyTyp3_TextBox_d3_LostFocus(null, null);
			ZontOstrivnyyTyp3_TextBox_a3_LostFocus(null, null);
			ZontOstrivnyyTyp3_TextBox_f3_LostFocus(null, null);
			ParentWindow.ZontOstrivnyyTyp3_TextBox_a_SetDefaultValue();
		}
		if (sender != null)
		{
			ZontOstrivnyyTyp3_TextBox_Base_LostFocus(sender, e);
		}
	}

	public void ZontOstrivnyyTyp3_TextBox_b1_LostFocus(object sender, RoutedEventArgs e)
	{
		//IL_007d: Unknown result type (might be due to invalid IL or missing references)
		TextBox val = textBox_b1_ZontOstrivnyyTyp3;
		if (int.TryParse(val.Text, out var result) && int.TryParse(ParentWindow.textBox_b_ZontOstrivnyyTyp3.Text, out var result2))
		{
			int num = result2 - 10;
			if (num > 10 && (result < 10 || result > num))
			{
				val.Text = "";
				MessageBox.Show($"Ширина вихода 1 має бути в межах {10} - {num} мм");
				return;
			}
		}
		if (sender != null)
		{
			ZontOstrivnyyTyp3_TextBox_g1_LostFocus(null, null);
			ZontOstrivnyyTyp3_TextBox_b2_LostFocus(null, null);
			ZontOstrivnyyTyp3_TextBox_g2_LostFocus(null, null);
			ZontOstrivnyyTyp3_TextBox_b3_LostFocus(null, null);
			ZontOstrivnyyTyp3_TextBox_g3_LostFocus(null, null);
			ParentWindow.ZontOstrivnyyTyp3_TextBox_b_SetDefaultValue();
		}
		if (sender != null)
		{
			ZontOstrivnyyTyp3_TextBox_Base_LostFocus(sender, e);
		}
	}

	public void ZontOstrivnyyTyp3_TextBox_p1_LostFocus(object sender, RoutedEventArgs e)
	{
		//IL_0090: Unknown result type (might be due to invalid IL or missing references)
		string text = comboBox_Vyhid1_ZontOstrivnyyTyp3?.GetValue();
		if (!string.IsNullOrEmpty(text))
		{
			int num = ((text == "круглий") ? 50 : 30);
			TextBox val = textBox_p1_ZontOstrivnyyTyp3;
			if (int.TryParse(val.Text, out var result) && (result < num || result > 600))
			{
				val.Text = "";
				MessageBox.Show($"Висота вихода 1 має бути в межах {num} - {600} мм");
			}
			else if (sender != null)
			{
				ParentWindow.ZontOstrivnyyTyp3_TextBox_LostFocus(sender, e);
			}
		}
	}

	public void ZontOstrivnyyTyp3_TextBox_f1_LostFocus(object sender, RoutedEventArgs e)
	{
		//IL_0129: Unknown result type (might be due to invalid IL or missing references)
		string text = comboBox_Vyhid1_ZontOstrivnyyTyp3?.GetValue();
		if (string.IsNullOrEmpty(text))
		{
			return;
		}
		TextBox val = textBox_f1_ZontOstrivnyyTyp3;
		if (int.TryParse(val.Text, out var result) && int.TryParse(ParentWindow.textBox_a_ZontOstrivnyyTyp3.Text, out var result2))
		{
			int num = 0;
			int num2 = 0;
			if (text == "круглий" && int.TryParse(textBox_d1_ZontOstrivnyyTyp3.Text, out var result3))
			{
				num = 10 + result3 / 2;
				num2 = result2 - 10 - result3 / 2;
			}
			if (text == "прямокутний" && int.TryParse(textBox_a1_ZontOstrivnyyTyp3.Text, out var result4))
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
			ZontOstrivnyyTyp3_TextBox_Base_LostFocus(sender, e);
		}
	}

	public void ZontOstrivnyyTyp3_TextBox_g1_LostFocus(object sender, RoutedEventArgs e)
	{
		//IL_0129: Unknown result type (might be due to invalid IL or missing references)
		string text = comboBox_Vyhid1_ZontOstrivnyyTyp3?.GetValue();
		if (string.IsNullOrEmpty(text))
		{
			return;
		}
		TextBox val = textBox_g1_ZontOstrivnyyTyp3;
		if (int.TryParse(val.Text, out var result) && int.TryParse(ParentWindow.textBox_b_ZontOstrivnyyTyp3.Text, out var result2))
		{
			int num = 0;
			int num2 = 0;
			if (text == "круглий" && int.TryParse(textBox_d1_ZontOstrivnyyTyp3.Text, out var result3))
			{
				num = 10 + result3 / 2;
				num2 = result2 - 10 - result3 / 2;
			}
			if (text == "прямокутний" && int.TryParse(textBox_b1_ZontOstrivnyyTyp3.Text, out var result4))
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
			ZontOstrivnyyTyp3_TextBox_Base_LostFocus(sender, e);
		}
	}

	private void ZontOstrivnyyTyp3_TextBox_p1_PreviewMouseLeftButtonUp(object sender, MouseButtonEventArgs e)
	{
		ParentWindow.ZontOstrivnyyTyp3_SetImage("p1");
	}

	private void ZontOstrivnyyTyp3_TextBox_g1_PreviewMouseLeftButtonUp(object sender, MouseButtonEventArgs e)
	{
		ZontOstrivnyyTyp3_SetInnerImage("g1");
	}

	private void ZontOstrivnyyTyp3_TextBox_f1_PreviewMouseLeftButtonUp(object sender, MouseButtonEventArgs e)
	{
		ZontOstrivnyyTyp3_SetInnerImage("f1");
	}

	private void ZontOstrivnyyTyp3_Vyhid2Cbox_SelectionChanged(object sender, RoutedEventArgs e)
	{
		string text = comboBox_Vyhid2_ZontOstrivnyyTyp3?.GetValue();
		if (string.IsNullOrEmpty(text))
		{
			textBox_a2_ZontOstrivnyyTyp3.Clear();
			textBox_b2_ZontOstrivnyyTyp3.Clear();
			textBox_d2_ZontOstrivnyyTyp3.Clear();
			textBox_p2_ZontOstrivnyyTyp3.Clear();
			textBox_f2_ZontOstrivnyyTyp3.Clear();
			textBox_g2_ZontOstrivnyyTyp3.Clear();
			((Selector)comboBox_typVyhid2_ZontOstrivnyyTyp3).SelectedItem = null;
			((UIElement)textBox_d2_ZontOstrivnyyTyp3).Visibility = (Visibility)2;
			((UIElement)label_d2_ZontOstrivnyyTyp3).Visibility = (Visibility)2;
			((UIElement)textBox_a2_ZontOstrivnyyTyp3).Visibility = (Visibility)2;
			((UIElement)label_a2_ZontOstrivnyyTyp3).Visibility = (Visibility)2;
			((UIElement)textBox_b2_ZontOstrivnyyTyp3).Visibility = (Visibility)2;
			((UIElement)label_b2_ZontOstrivnyyTyp3).Visibility = (Visibility)2;
			((UIElement)textBox_p2_ZontOstrivnyyTyp3).Visibility = (Visibility)2;
			((UIElement)label_p2_ZontOstrivnyyTyp3).Visibility = (Visibility)2;
			((UIElement)textBox_f2_ZontOstrivnyyTyp3).Visibility = (Visibility)2;
			((UIElement)label_f2_ZontOstrivnyyTyp3).Visibility = (Visibility)2;
			((UIElement)textBox_g2_ZontOstrivnyyTyp3).Visibility = (Visibility)2;
			((UIElement)label_g2_ZontOstrivnyyTyp3).Visibility = (Visibility)2;
			((UIElement)comboBox_typVyhid2_ZontOstrivnyyTyp3).Visibility = (Visibility)2;
			((UIElement)label_typVyhid2_ZontOstrivnyyTyp3).Visibility = (Visibility)2;
			((UIElement)comboBox_profilType2_ZontOstrivnyyTyp3).Visibility = (Visibility)2;
			((UIElement)label_profilType2_ZontOstrivnyyTyp3).Visibility = (Visibility)2;
			((Selector)comboBox_Vyhid3_ZontOstrivnyyTyp3).SelectedItem = null;
			((UIElement)inputDataZontOstrivnyyTyp3_Vyhid3).Visibility = (Visibility)2;
			ParentWindow.ZontOstrivnyyTyp3_SetFirstImage();
			return;
		}
		if (text == "круглий")
		{
			((UIElement)textBox_d2_ZontOstrivnyyTyp3).Visibility = (Visibility)0;
			((UIElement)label_d2_ZontOstrivnyyTyp3).Visibility = (Visibility)0;
			textBox_a2_ZontOstrivnyyTyp3.Clear();
			((UIElement)textBox_a2_ZontOstrivnyyTyp3).Visibility = (Visibility)2;
			((UIElement)label_a2_ZontOstrivnyyTyp3).Visibility = (Visibility)2;
			textBox_b2_ZontOstrivnyyTyp3.Clear();
			((UIElement)textBox_b2_ZontOstrivnyyTyp3).Visibility = (Visibility)2;
			((UIElement)label_b2_ZontOstrivnyyTyp3).Visibility = (Visibility)2;
		}
		else if (text == "прямокутний")
		{
			((UIElement)textBox_a2_ZontOstrivnyyTyp3).Visibility = (Visibility)0;
			((UIElement)label_a2_ZontOstrivnyyTyp3).Visibility = (Visibility)0;
			((UIElement)textBox_b2_ZontOstrivnyyTyp3).Visibility = (Visibility)0;
			((UIElement)label_b2_ZontOstrivnyyTyp3).Visibility = (Visibility)0;
			textBox_d2_ZontOstrivnyyTyp3.Clear();
			((UIElement)textBox_d2_ZontOstrivnyyTyp3).Visibility = (Visibility)2;
			((UIElement)label_d2_ZontOstrivnyyTyp3).Visibility = (Visibility)2;
		}
		textBox_p2_ZontOstrivnyyTyp3.Text = "50";
		((UIElement)textBox_p2_ZontOstrivnyyTyp3).Visibility = (Visibility)0;
		((UIElement)label_p2_ZontOstrivnyyTyp3).Visibility = (Visibility)0;
		((UIElement)textBox_f2_ZontOstrivnyyTyp3).Visibility = (Visibility)0;
		((UIElement)label_f2_ZontOstrivnyyTyp3).Visibility = (Visibility)0;
		((UIElement)textBox_g2_ZontOstrivnyyTyp3).Visibility = (Visibility)0;
		((UIElement)label_g2_ZontOstrivnyyTyp3).Visibility = (Visibility)0;
		((Selector)comboBox_typVyhid2_ZontOstrivnyyTyp3).SelectedIndex = 0;
		((UIElement)comboBox_typVyhid2_ZontOstrivnyyTyp3).Visibility = (Visibility)0;
		((UIElement)label_typVyhid2_ZontOstrivnyyTyp3).Visibility = (Visibility)0;
		((UIElement)inputDataZontOstrivnyyTyp3_Vyhid3).Visibility = (Visibility)0;
		ParentWindow.ZontOstrivnyyTyp3_SetFirstImage();
	}

	private void ZontOstrivnyyTyp3_TypVyhid2Cbox_SelectionChanged(object sender, RoutedEventArgs e)
	{
		ZontVytiajniyHelper.ZontVytiajniy_TypVyhidCbox_SelectionChanged((ComboBox)((sender is ComboBox) ? sender : null), comboBox_Vyhid2_ZontOstrivnyyTyp3, comboBox_profilType2_ZontOstrivnyyTyp3, label_profilType2_ZontOstrivnyyTyp3);
	}

	public void ZontOstrivnyyTyp3_TextBox_d2_LostFocus(object sender, RoutedEventArgs e)
	{
		//IL_00c8: Unknown result type (might be due to invalid IL or missing references)
		if (string.IsNullOrEmpty(comboBox_Vyhid2_ZontOstrivnyyTyp3?.GetValue()))
		{
			return;
		}
		TextBox val = textBox_d2_ZontOstrivnyyTyp3;
		if (int.TryParse(val.Text, out var result) && int.TryParse(ParentWindow.textBox_a_ZontOstrivnyyTyp3.Text, out var result2) && int.TryParse(ParentWindow.textBox_b_ZontOstrivnyyTyp3.Text, out var result3))
		{
			int num = ZontOstrivnyyTyp3_TextBox_d2a2_GetMinValue();
			int num2 = Math.Min(result2, result3) - 10;
			if (num2 > num && (result < num || result > num2))
			{
				val.Text = "";
				MessageBox.Show($"Діаметр вихода 2 має бути в межах {num} - {num2} мм");
				return;
			}
		}
		if (sender != null)
		{
			ZontOstrivnyyTyp3_TextBox_f2_LostFocus(null, null);
			ZontOstrivnyyTyp3_TextBox_g2_LostFocus(null, null);
			ZontOstrivnyyTyp3_TextBox_d3_LostFocus(null, null);
			ZontOstrivnyyTyp3_TextBox_a3_LostFocus(null, null);
			ZontOstrivnyyTyp3_TextBox_b3_LostFocus(null, null);
			ZontOstrivnyyTyp3_TextBox_f3_LostFocus(null, null);
			ZontOstrivnyyTyp3_TextBox_g3_LostFocus(null, null);
		}
		if (sender != null)
		{
			ParentWindow.ZontOstrivnyyTyp3_TextBox_LostFocus(sender, e);
		}
	}

	public void ZontOstrivnyyTyp3_TextBox_a2_LostFocus(object sender, RoutedEventArgs e)
	{
		//IL_00a7: Unknown result type (might be due to invalid IL or missing references)
		if (string.IsNullOrEmpty(comboBox_Vyhid2_ZontOstrivnyyTyp3?.GetValue()))
		{
			return;
		}
		TextBox val = textBox_a2_ZontOstrivnyyTyp3;
		if (int.TryParse(val.Text, out var result) && int.TryParse(ParentWindow.textBox_a_ZontOstrivnyyTyp3.Text, out var result2))
		{
			int num = ZontOstrivnyyTyp3_TextBox_d2a2_GetMinValue();
			int num2 = result2 - 10;
			if (num2 > num && (result < num || result > num2))
			{
				val.Text = "";
				MessageBox.Show($"Довжина вихода 2 має бути в межах {num} - {num2} мм");
				return;
			}
		}
		if (sender != null)
		{
			ZontOstrivnyyTyp3_TextBox_f2_LostFocus(null, null);
			ZontOstrivnyyTyp3_TextBox_d3_LostFocus(null, null);
			ZontOstrivnyyTyp3_TextBox_a3_LostFocus(null, null);
			ZontOstrivnyyTyp3_TextBox_f3_LostFocus(null, null);
		}
		if (sender != null)
		{
			ZontOstrivnyyTyp3_TextBox_Base_LostFocus(sender, e);
		}
	}

	public void ZontOstrivnyyTyp3_TextBox_b2_LostFocus(object sender, RoutedEventArgs e)
	{
		//IL_00a7: Unknown result type (might be due to invalid IL or missing references)
		if (string.IsNullOrEmpty(comboBox_Vyhid2_ZontOstrivnyyTyp3?.GetValue()))
		{
			return;
		}
		TextBox val = textBox_b2_ZontOstrivnyyTyp3;
		if (int.TryParse(val.Text, out var result) && int.TryParse(ParentWindow.textBox_b_ZontOstrivnyyTyp3.Text, out var result2))
		{
			int num = ZontOstrivnyyTyp3_TextBox_b2_GetMinValue();
			int num2 = result2 - 10;
			if (num2 > num && (result < num || result > num2))
			{
				val.Text = "";
				MessageBox.Show($"Ширина вихода 2 має бути в межах {num} - {num2} мм");
				return;
			}
		}
		if (sender != null)
		{
			ZontOstrivnyyTyp3_TextBox_g2_LostFocus(null, null);
			ZontOstrivnyyTyp3_TextBox_b3_LostFocus(null, null);
			ZontOstrivnyyTyp3_TextBox_g3_LostFocus(null, null);
		}
		if (sender != null)
		{
			ZontOstrivnyyTyp3_TextBox_Base_LostFocus(sender, e);
		}
	}

	public void ZontOstrivnyyTyp3_TextBox_p2_LostFocus(object sender, RoutedEventArgs e)
	{
		//IL_0090: Unknown result type (might be due to invalid IL or missing references)
		string text = comboBox_Vyhid2_ZontOstrivnyyTyp3?.GetValue();
		if (!string.IsNullOrEmpty(text))
		{
			int num = ((text == "круглий") ? 50 : 30);
			TextBox val = textBox_p2_ZontOstrivnyyTyp3;
			if (int.TryParse(val.Text, out var result) && (result < num || result > 600))
			{
				val.Text = "";
				MessageBox.Show($"Висота вихода 2 має бути в межах {num} - {600} мм");
			}
			else if (sender != null)
			{
				ParentWindow.ZontOstrivnyyTyp3_TextBox_LostFocus(sender, e);
			}
		}
	}

	public void ZontOstrivnyyTyp3_TextBox_f2_LostFocus(object sender, RoutedEventArgs e)
	{
		//IL_01a2: Unknown result type (might be due to invalid IL or missing references)
		string text = comboBox_Vyhid1_ZontOstrivnyyTyp3?.GetValue();
		string text2 = comboBox_Vyhid2_ZontOstrivnyyTyp3?.GetValue();
		if (string.IsNullOrEmpty(text) || string.IsNullOrEmpty(text2))
		{
			return;
		}
		TextBox val = textBox_f2_ZontOstrivnyyTyp3;
		if (int.TryParse(val.Text, out var result) && int.TryParse(ParentWindow.textBox_a_ZontOstrivnyyTyp3.Text, out var result2))
		{
			int num = 0;
			int num2 = 0;
			int result4;
			if (text == "круглий" && int.TryParse(textBox_d1_ZontOstrivnyyTyp3.Text, out var result3))
			{
				num = result3;
			}
			else if (text == "прямокутний" && int.TryParse(textBox_a1_ZontOstrivnyyTyp3.Text, out result4))
			{
				num = result4;
			}
			int result6;
			if (text2 == "круглий" && int.TryParse(textBox_d2_ZontOstrivnyyTyp3.Text, out var result5))
			{
				num2 = result5;
			}
			else if (text2 == "прямокутний" && int.TryParse(textBox_a2_ZontOstrivnyyTyp3.Text, out result6))
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
			ZontOstrivnyyTyp3_TextBox_Base_LostFocus(sender, e);
		}
	}

	public void ZontOstrivnyyTyp3_TextBox_g2_LostFocus(object sender, RoutedEventArgs e)
	{
		//IL_01a2: Unknown result type (might be due to invalid IL or missing references)
		string text = comboBox_Vyhid1_ZontOstrivnyyTyp3?.GetValue();
		string text2 = comboBox_Vyhid2_ZontOstrivnyyTyp3?.GetValue();
		if (string.IsNullOrEmpty(text) || string.IsNullOrEmpty(text2))
		{
			return;
		}
		TextBox val = textBox_f2_ZontOstrivnyyTyp3;
		if (int.TryParse(val.Text, out var result) && int.TryParse(ParentWindow.textBox_b_ZontOstrivnyyTyp3.Text, out var result2))
		{
			int num = 0;
			int num2 = 0;
			int result4;
			if (text == "круглий" && int.TryParse(textBox_d1_ZontOstrivnyyTyp3.Text, out var result3))
			{
				num = result3;
			}
			else if (text == "прямокутний" && int.TryParse(textBox_b1_ZontOstrivnyyTyp3.Text, out result4))
			{
				num = result4;
			}
			int result6;
			if (text2 == "круглий" && int.TryParse(textBox_d2_ZontOstrivnyyTyp3.Text, out var result5))
			{
				num2 = result5;
			}
			else if (text2 == "прямокутний" && int.TryParse(textBox_b2_ZontOstrivnyyTyp3.Text, out result6))
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
			ZontOstrivnyyTyp3_TextBox_Base_LostFocus(sender, e);
		}
	}

	private void ZontOstrivnyyTyp3_TextBox_p2_PreviewMouseLeftButtonUp(object sender, MouseButtonEventArgs e)
	{
		ParentWindow.ZontOstrivnyyTyp3_SetImage("p2");
	}

	private void ZontOstrivnyyTyp3_TextBox_g2_PreviewMouseLeftButtonUp(object sender, MouseButtonEventArgs e)
	{
		ZontOstrivnyyTyp3_SetInnerImage("g2");
	}

	private void ZontOstrivnyyTyp3_TextBox_f2_PreviewMouseLeftButtonUp(object sender, MouseButtonEventArgs e)
	{
		ZontOstrivnyyTyp3_SetInnerImage("f2");
	}

	private void ZontOstrivnyyTyp3_Vyhid3Cbox_SelectionChanged(object sender, RoutedEventArgs e)
	{
		string text = comboBox_Vyhid3_ZontOstrivnyyTyp3?.GetValue();
		if (string.IsNullOrEmpty(text))
		{
			textBox_a3_ZontOstrivnyyTyp3.Clear();
			textBox_b3_ZontOstrivnyyTyp3.Clear();
			textBox_d3_ZontOstrivnyyTyp3.Clear();
			textBox_p3_ZontOstrivnyyTyp3.Clear();
			textBox_f3_ZontOstrivnyyTyp3.Clear();
			textBox_g3_ZontOstrivnyyTyp3.Clear();
			((Selector)comboBox_typVyhid3_ZontOstrivnyyTyp3).SelectedItem = null;
			((UIElement)textBox_d3_ZontOstrivnyyTyp3).Visibility = (Visibility)2;
			((UIElement)label_d3_ZontOstrivnyyTyp3).Visibility = (Visibility)2;
			((UIElement)textBox_a3_ZontOstrivnyyTyp3).Visibility = (Visibility)2;
			((UIElement)label_a3_ZontOstrivnyyTyp3).Visibility = (Visibility)2;
			((UIElement)textBox_b3_ZontOstrivnyyTyp3).Visibility = (Visibility)2;
			((UIElement)label_b3_ZontOstrivnyyTyp3).Visibility = (Visibility)2;
			((UIElement)textBox_p3_ZontOstrivnyyTyp3).Visibility = (Visibility)2;
			((UIElement)label_p3_ZontOstrivnyyTyp3).Visibility = (Visibility)2;
			((UIElement)textBox_f3_ZontOstrivnyyTyp3).Visibility = (Visibility)2;
			((UIElement)label_f3_ZontOstrivnyyTyp3).Visibility = (Visibility)2;
			((UIElement)textBox_g3_ZontOstrivnyyTyp3).Visibility = (Visibility)2;
			((UIElement)label_g3_ZontOstrivnyyTyp3).Visibility = (Visibility)2;
			((UIElement)comboBox_typVyhid3_ZontOstrivnyyTyp3).Visibility = (Visibility)2;
			((UIElement)label_typVyhid3_ZontOstrivnyyTyp3).Visibility = (Visibility)2;
			((UIElement)comboBox_profilType3_ZontOstrivnyyTyp3).Visibility = (Visibility)2;
			((UIElement)label_profilType3_ZontOstrivnyyTyp3).Visibility = (Visibility)2;
			ParentWindow.ZontOstrivnyyTyp3_SetFirstImage();
			return;
		}
		if (text == "круглий")
		{
			((UIElement)textBox_d3_ZontOstrivnyyTyp3).Visibility = (Visibility)0;
			((UIElement)label_d3_ZontOstrivnyyTyp3).Visibility = (Visibility)0;
			textBox_a3_ZontOstrivnyyTyp3.Clear();
			((UIElement)textBox_a3_ZontOstrivnyyTyp3).Visibility = (Visibility)2;
			((UIElement)label_a3_ZontOstrivnyyTyp3).Visibility = (Visibility)2;
			textBox_b3_ZontOstrivnyyTyp3.Clear();
			((UIElement)textBox_b3_ZontOstrivnyyTyp3).Visibility = (Visibility)2;
			((UIElement)label_b3_ZontOstrivnyyTyp3).Visibility = (Visibility)2;
		}
		else if (text == "прямокутний")
		{
			((UIElement)textBox_a3_ZontOstrivnyyTyp3).Visibility = (Visibility)0;
			((UIElement)label_a3_ZontOstrivnyyTyp3).Visibility = (Visibility)0;
			((UIElement)textBox_b3_ZontOstrivnyyTyp3).Visibility = (Visibility)0;
			((UIElement)label_b3_ZontOstrivnyyTyp3).Visibility = (Visibility)0;
			textBox_d3_ZontOstrivnyyTyp3.Clear();
			((UIElement)textBox_d3_ZontOstrivnyyTyp3).Visibility = (Visibility)2;
			((UIElement)label_d3_ZontOstrivnyyTyp3).Visibility = (Visibility)2;
		}
		textBox_p3_ZontOstrivnyyTyp3.Text = "50";
		((UIElement)textBox_p3_ZontOstrivnyyTyp3).Visibility = (Visibility)0;
		((UIElement)label_p3_ZontOstrivnyyTyp3).Visibility = (Visibility)0;
		((UIElement)textBox_f3_ZontOstrivnyyTyp3).Visibility = (Visibility)0;
		((UIElement)label_f3_ZontOstrivnyyTyp3).Visibility = (Visibility)0;
		((UIElement)textBox_g3_ZontOstrivnyyTyp3).Visibility = (Visibility)0;
		((UIElement)label_g3_ZontOstrivnyyTyp3).Visibility = (Visibility)0;
		((Selector)comboBox_typVyhid3_ZontOstrivnyyTyp3).SelectedIndex = 0;
		((UIElement)comboBox_typVyhid3_ZontOstrivnyyTyp3).Visibility = (Visibility)0;
		((UIElement)label_typVyhid3_ZontOstrivnyyTyp3).Visibility = (Visibility)0;
		((UIElement)inputDataZontOstrivnyyTyp3_Vyhid3).Visibility = (Visibility)0;
		ParentWindow.ZontOstrivnyyTyp3_TextBox_a_SetDefaultValue();
		ParentWindow.ZontOstrivnyyTyp3_TextBox_b_SetDefaultValue();
		ParentWindow.ZontOstrivnyyTyp3_SetFirstImage();
	}

	private void ZontOstrivnyyTyp3_TypVyhid3Cbox_SelectionChanged(object sender, RoutedEventArgs e)
	{
		ZontVytiajniyHelper.ZontVytiajniy_TypVyhidCbox_SelectionChanged((ComboBox)((sender is ComboBox) ? sender : null), comboBox_Vyhid3_ZontOstrivnyyTyp3, comboBox_profilType3_ZontOstrivnyyTyp3, label_profilType3_ZontOstrivnyyTyp3);
	}

	public void ZontOstrivnyyTyp3_TextBox_d3_LostFocus(object sender, RoutedEventArgs e)
	{
		//IL_00c8: Unknown result type (might be due to invalid IL or missing references)
		if (string.IsNullOrEmpty(comboBox_Vyhid3_ZontOstrivnyyTyp3?.GetValue()))
		{
			return;
		}
		TextBox val = textBox_d3_ZontOstrivnyyTyp3;
		if (int.TryParse(val.Text, out var result) && int.TryParse(ParentWindow.textBox_a_ZontOstrivnyyTyp3.Text, out var result2) && int.TryParse(ParentWindow.textBox_b_ZontOstrivnyyTyp3.Text, out var result3))
		{
			int num = ZontOstrivnyyTyp3_TextBox_d3a3_GetMinValue();
			int num2 = Math.Min(result2, result3) - 10;
			if (num2 > num && (result < num || result > num2))
			{
				val.Text = "";
				MessageBox.Show($"Діаметр вихода 3 має бути в межах {num} - {num2} мм");
				return;
			}
		}
		if (sender != null)
		{
			ZontOstrivnyyTyp3_TextBox_f3_LostFocus(null, null);
			ZontOstrivnyyTyp3_TextBox_g3_LostFocus(null, null);
		}
		if (sender != null)
		{
			ParentWindow.ZontOstrivnyyTyp3_TextBox_LostFocus(sender, e);
		}
	}

	public void ZontOstrivnyyTyp3_TextBox_a3_LostFocus(object sender, RoutedEventArgs e)
	{
		//IL_00a7: Unknown result type (might be due to invalid IL or missing references)
		if (string.IsNullOrEmpty(comboBox_Vyhid3_ZontOstrivnyyTyp3?.GetValue()))
		{
			return;
		}
		TextBox val = textBox_a3_ZontOstrivnyyTyp3;
		if (int.TryParse(val.Text, out var result) && int.TryParse(ParentWindow.textBox_a_ZontOstrivnyyTyp3.Text, out var result2))
		{
			int num = ZontOstrivnyyTyp3_TextBox_d3a3_GetMinValue();
			int num2 = result2 - 10;
			if (num2 > num && (result < num || result > num2))
			{
				val.Text = "";
				MessageBox.Show($"Довжина вихода 3 має бути в межах {num} - {num2} мм");
				return;
			}
		}
		if (sender != null)
		{
			ZontOstrivnyyTyp3_TextBox_f3_LostFocus(null, null);
		}
		if (sender != null)
		{
			ZontOstrivnyyTyp3_TextBox_Base_LostFocus(sender, e);
		}
	}

	public void ZontOstrivnyyTyp3_TextBox_b3_LostFocus(object sender, RoutedEventArgs e)
	{
		//IL_00a7: Unknown result type (might be due to invalid IL or missing references)
		if (string.IsNullOrEmpty(comboBox_Vyhid3_ZontOstrivnyyTyp3?.GetValue()))
		{
			return;
		}
		TextBox val = textBox_b3_ZontOstrivnyyTyp3;
		if (int.TryParse(val.Text, out var result) && int.TryParse(ParentWindow.textBox_b_ZontOstrivnyyTyp3.Text, out var result2))
		{
			int num = ZontOstrivnyyTyp3_TextBox_b3_GetMinValue();
			int num2 = result2 - 10;
			if (num2 > num && (result < num || result > num2))
			{
				val.Text = "";
				MessageBox.Show($"Ширина вихода 3 має бути в межах {num} - {num2} мм");
				return;
			}
		}
		if (sender != null)
		{
			ZontOstrivnyyTyp3_TextBox_g3_LostFocus(null, null);
		}
		if (sender != null)
		{
			ZontOstrivnyyTyp3_TextBox_Base_LostFocus(sender, e);
		}
	}

	public void ZontOstrivnyyTyp3_TextBox_p3_LostFocus(object sender, RoutedEventArgs e)
	{
		//IL_0090: Unknown result type (might be due to invalid IL or missing references)
		string text = comboBox_Vyhid3_ZontOstrivnyyTyp3?.GetValue();
		if (!string.IsNullOrEmpty(text))
		{
			int num = ((text == "круглий") ? 50 : 30);
			TextBox val = textBox_p3_ZontOstrivnyyTyp3;
			if (int.TryParse(val.Text, out var result) && (result < num || result > 600))
			{
				val.Text = "";
				MessageBox.Show($"Висота вихода 3 має бути в межах {num} - {600} мм");
			}
			else if (sender != null)
			{
				ParentWindow.ZontOstrivnyyTyp3_TextBox_LostFocus(sender, e);
			}
		}
	}

	public void ZontOstrivnyyTyp3_TextBox_f3_LostFocus(object sender, RoutedEventArgs e)
	{
		//IL_0226: Unknown result type (might be due to invalid IL or missing references)
		string text = comboBox_Vyhid1_ZontOstrivnyyTyp3?.GetValue();
		string text2 = comboBox_Vyhid2_ZontOstrivnyyTyp3?.GetValue();
		string text3 = comboBox_Vyhid3_ZontOstrivnyyTyp3?.GetValue();
		if (string.IsNullOrEmpty(text) || string.IsNullOrEmpty(text2) || string.IsNullOrEmpty(text3))
		{
			return;
		}
		TextBox val = textBox_f2_ZontOstrivnyyTyp3;
		if (int.TryParse(val.Text, out var result) && int.TryParse(ParentWindow.textBox_a_ZontOstrivnyyTyp3.Text, out var result2))
		{
			int num = 0;
			int num2 = 0;
			int num3 = 0;
			int result4;
			if (text == "круглий" && int.TryParse(textBox_d1_ZontOstrivnyyTyp3.Text, out var result3))
			{
				num = result3;
			}
			else if (text == "прямокутний" && int.TryParse(textBox_a1_ZontOstrivnyyTyp3.Text, out result4))
			{
				num = result4;
			}
			int result6;
			if (text2 == "круглий" && int.TryParse(textBox_d2_ZontOstrivnyyTyp3.Text, out var result5))
			{
				num2 = result5;
			}
			else if (text2 == "прямокутний" && int.TryParse(textBox_a2_ZontOstrivnyyTyp3.Text, out result6))
			{
				num2 = result6;
			}
			int result8;
			if (text3 == "круглий" && int.TryParse(textBox_d3_ZontOstrivnyyTyp3.Text, out var result7))
			{
				num3 = result7;
			}
			else if (text3 == "прямокутний" && int.TryParse(textBox_a3_ZontOstrivnyyTyp3.Text, out result8))
			{
				num3 = result8;
			}
			int num4 = 10 + num + 50 + num2 + 50 + num3 / 2;
			int num5 = result2 - 10 - num3 / 2;
			if (num5 > num4 && num5 != 0 && (result <= num4 || result >= num5))
			{
				val.Text = "";
				MessageBox.Show($"Розміщення по довжині вихода 3 має бути більше ніж {num4} і менше ніж {num5} мм");
				return;
			}
		}
		if (sender != null)
		{
			ZontOstrivnyyTyp3_TextBox_Base_LostFocus(sender, e);
		}
	}

	public void ZontOstrivnyyTyp3_TextBox_g3_LostFocus(object sender, RoutedEventArgs e)
	{
		//IL_0226: Unknown result type (might be due to invalid IL or missing references)
		string text = comboBox_Vyhid1_ZontOstrivnyyTyp3?.GetValue();
		string text2 = comboBox_Vyhid2_ZontOstrivnyyTyp3?.GetValue();
		string text3 = comboBox_Vyhid3_ZontOstrivnyyTyp3?.GetValue();
		if (string.IsNullOrEmpty(text) || string.IsNullOrEmpty(text2) || string.IsNullOrEmpty(text3))
		{
			return;
		}
		TextBox val = textBox_f2_ZontOstrivnyyTyp3;
		if (int.TryParse(val.Text, out var result) && int.TryParse(ParentWindow.textBox_a_ZontOstrivnyyTyp3.Text, out var result2))
		{
			int num = 0;
			int num2 = 0;
			int num3 = 0;
			int result4;
			if (text == "круглий" && int.TryParse(textBox_d1_ZontOstrivnyyTyp3.Text, out var result3))
			{
				num = result3;
			}
			else if (text == "прямокутний" && int.TryParse(textBox_b1_ZontOstrivnyyTyp3.Text, out result4))
			{
				num = result4;
			}
			int result6;
			if (text2 == "круглий" && int.TryParse(textBox_d2_ZontOstrivnyyTyp3.Text, out var result5))
			{
				num2 = result5;
			}
			else if (text2 == "прямокутний" && int.TryParse(textBox_b2_ZontOstrivnyyTyp3.Text, out result6))
			{
				num2 = result6;
			}
			int result8;
			if (text3 == "круглий" && int.TryParse(textBox_d3_ZontOstrivnyyTyp3.Text, out var result7))
			{
				num3 = result7;
			}
			else if (text3 == "прямокутний" && int.TryParse(textBox_b3_ZontOstrivnyyTyp3.Text, out result8))
			{
				num3 = result8;
			}
			int num4 = 10 + num + 50 + num2 + 50 + num3 / 2;
			int num5 = result2 - 10 - num3 / 2;
			if (num5 > num4 && num5 != 0 && (result <= num4 || result >= num5))
			{
				val.Text = "";
				MessageBox.Show($"Розміщення по ширині вихода 3 має бути більше ніж {num4} і менше ніж {num5} мм");
				return;
			}
		}
		if (sender != null)
		{
			ZontOstrivnyyTyp3_TextBox_Base_LostFocus(sender, e);
		}
	}

	private void ZontOstrivnyyTyp3_TextBox_p3_PreviewMouseLeftButtonUp(object sender, MouseButtonEventArgs e)
	{
		ParentWindow.ZontOstrivnyyTyp3_SetImage("p3");
	}

	private void ZontOstrivnyyTyp3_TextBox_g3_PreviewMouseLeftButtonUp(object sender, MouseButtonEventArgs e)
	{
		ZontOstrivnyyTyp3_SetInnerImage("g3");
	}

	private void ZontOstrivnyyTyp3_TextBox_f3_PreviewMouseLeftButtonUp(object sender, MouseButtonEventArgs e)
	{
		ZontOstrivnyyTyp3_SetInnerImage("f3");
	}

	private void TextBox_GotFocus(object sender, RoutedEventArgs e)
	{
		ParentWindow.TextBox_GotFocus(sender, e);
	}

	public void ZontOstrivnyyTyp3_TextBox_Base_LostFocus(object sender, RoutedEventArgs e)
	{
		ZontOstrivnyyTyp3_Img.Source = null;
		((UIElement)ZontOstrivnyyTyp3_Img).Visibility = (Visibility)2;
		if (ParentWindow.TextBoxHasValue(sender))
		{
		}
	}

	public void ZontOstrivnyyTyp3_SetInnerImage(string parameter)
	{
		string text = "ZontOstrivnyyTyp3_ Top_";
		text += ZontVytiajniyHelper.ZontVytiajniy_Complex_GetImageNumber(ParentWindow.ZontOstrivnyyTyp3_GetImageType());
		string imagePath = "/Images/Zonty/ZontOstrivnyyType3/" + text + "_" + parameter + ".jpg";
		ZontOstrivnyyTyp3_SetImages(imagePath);
	}

	private void ZontOstrivnyyTyp3_SetImages(string imagePath)
	{
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0035: Expected O, but got Unknown
		ParentWindow.shapeImg.Source = (ImageSource)new BitmapImage(new Uri(imagePath, UriKind.Relative));
		ZontOstrivnyyTyp3_Img.Source = (ImageSource)new BitmapImage(new Uri(imagePath, UriKind.Relative));
		((UIElement)ZontOstrivnyyTyp3_Img).Visibility = (Visibility)0;
	}

	private int ZontOstrivnyyTyp3_TextBox_d2a2_GetMinValue()
	{
		string text = comboBox_Vyhid1_ZontOstrivnyyTyp3?.GetValue();
		if (text == "круглий" && int.TryParse(textBox_d1_ZontOstrivnyyTyp3.Text, out var result))
		{
			return result + 60;
		}
		if (text == "прямокутний" && int.TryParse(textBox_a1_ZontOstrivnyyTyp3.Text, out var result2))
		{
			return result2 + 60;
		}
		return 60;
	}

	private int ZontOstrivnyyTyp3_TextBox_b2_GetMinValue()
	{
		string text = comboBox_Vyhid1_ZontOstrivnyyTyp3?.GetValue();
		if (text == "круглий" && int.TryParse(textBox_d1_ZontOstrivnyyTyp3.Text, out var result))
		{
			return result + 60;
		}
		if (text == "прямокутний" && int.TryParse(textBox_b1_ZontOstrivnyyTyp3.Text, out var result2))
		{
			return result2 + 60;
		}
		return 60;
	}

	private int ZontOstrivnyyTyp3_TextBox_d3a3_GetMinValue()
	{
		int num = 110;
		string text = comboBox_Vyhid1_ZontOstrivnyyTyp3?.GetValue();
		string text2 = comboBox_Vyhid2_ZontOstrivnyyTyp3?.GetValue();
		if (text == "круглий" && int.TryParse(textBox_d1_ZontOstrivnyyTyp3.Text, out var result))
		{
			num += result;
		}
		if (text == "прямокутний" && int.TryParse(textBox_a1_ZontOstrivnyyTyp3.Text, out var result2))
		{
			num += result2;
		}
		if (text2 == "круглий" && int.TryParse(textBox_d2_ZontOstrivnyyTyp3.Text, out var result3))
		{
			num += result3;
		}
		if (text2 == "прямокутний" && int.TryParse(textBox_a2_ZontOstrivnyyTyp3.Text, out var result4))
		{
			num += result4;
		}
		return num;
	}

	private int ZontOstrivnyyTyp3_TextBox_b3_GetMinValue()
	{
		int num = 110;
		string text = comboBox_Vyhid1_ZontOstrivnyyTyp3?.GetValue();
		string text2 = comboBox_Vyhid2_ZontOstrivnyyTyp3?.GetValue();
		if (text == "круглий" && int.TryParse(textBox_d1_ZontOstrivnyyTyp3.Text, out var result))
		{
			num += result;
		}
		if (text == "прямокутний" && int.TryParse(textBox_b1_ZontOstrivnyyTyp3.Text, out var result2))
		{
			num += result2;
		}
		if (text2 == "круглий" && int.TryParse(textBox_d2_ZontOstrivnyyTyp3.Text, out var result3))
		{
			num += result3;
		}
		if (text2 == "прямокутний" && int.TryParse(textBox_b2_ZontOstrivnyyTyp3.Text, out var result4))
		{
			num += result4;
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	public void InitializeComponent()
	{
		if (!_contentLoaded)
		{
			_contentLoaded = true;
			Uri uri = new Uri("/TEZ_Project;component/productwindows/zontostrivnyytyp3window.xaml", UriKind.Relative);
			Application.LoadComponent((object)this, uri);
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	[EditorBrowsable(EditorBrowsableState.Never)]
	void IComponentConnector.Connect(int connectionId, object target)
	{
		//IL_0108: Unknown result type (might be due to invalid IL or missing references)
		//IL_0112: Expected O, but got Unknown
		//IL_0119: Unknown result type (might be due to invalid IL or missing references)
		//IL_0123: Expected O, but got Unknown
		//IL_012a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0134: Expected O, but got Unknown
		//IL_013b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0145: Expected O, but got Unknown
		//IL_0152: Unknown result type (might be due to invalid IL or missing references)
		//IL_015c: Expected O, but got Unknown
		//IL_016a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0174: Expected O, but got Unknown
		//IL_017c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0186: Expected O, but got Unknown
		//IL_0193: Unknown result type (might be due to invalid IL or missing references)
		//IL_019d: Expected O, but got Unknown
		//IL_01ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b5: Expected O, but got Unknown
		//IL_01bd: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c7: Expected O, but got Unknown
		//IL_01d4: Unknown result type (might be due to invalid IL or missing references)
		//IL_01de: Expected O, but got Unknown
		//IL_01ec: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f6: Expected O, but got Unknown
		//IL_01fe: Unknown result type (might be due to invalid IL or missing references)
		//IL_0208: Expected O, but got Unknown
		//IL_0215: Unknown result type (might be due to invalid IL or missing references)
		//IL_021f: Expected O, but got Unknown
		//IL_022d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0237: Expected O, but got Unknown
		//IL_0245: Unknown result type (might be due to invalid IL or missing references)
		//IL_024f: Expected O, but got Unknown
		//IL_0257: Unknown result type (might be due to invalid IL or missing references)
		//IL_0261: Expected O, but got Unknown
		//IL_026e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0278: Expected O, but got Unknown
		//IL_0286: Unknown result type (might be due to invalid IL or missing references)
		//IL_0290: Expected O, but got Unknown
		//IL_029e: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a8: Expected O, but got Unknown
		//IL_02b0: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ba: Expected O, but got Unknown
		//IL_02c7: Unknown result type (might be due to invalid IL or missing references)
		//IL_02d1: Expected O, but got Unknown
		//IL_02df: Unknown result type (might be due to invalid IL or missing references)
		//IL_02e9: Expected O, but got Unknown
		//IL_02f7: Unknown result type (might be due to invalid IL or missing references)
		//IL_0301: Expected O, but got Unknown
		//IL_0309: Unknown result type (might be due to invalid IL or missing references)
		//IL_0313: Expected O, but got Unknown
		//IL_0320: Unknown result type (might be due to invalid IL or missing references)
		//IL_032a: Expected O, but got Unknown
		//IL_0332: Unknown result type (might be due to invalid IL or missing references)
		//IL_033c: Expected O, but got Unknown
		//IL_0343: Unknown result type (might be due to invalid IL or missing references)
		//IL_034d: Expected O, but got Unknown
		//IL_0354: Unknown result type (might be due to invalid IL or missing references)
		//IL_035e: Expected O, but got Unknown
		//IL_0365: Unknown result type (might be due to invalid IL or missing references)
		//IL_036f: Expected O, but got Unknown
		//IL_0376: Unknown result type (might be due to invalid IL or missing references)
		//IL_0380: Expected O, but got Unknown
		//IL_0387: Unknown result type (might be due to invalid IL or missing references)
		//IL_0391: Expected O, but got Unknown
		//IL_0398: Unknown result type (might be due to invalid IL or missing references)
		//IL_03a2: Expected O, but got Unknown
		//IL_03a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_03b3: Expected O, but got Unknown
		//IL_03ba: Unknown result type (might be due to invalid IL or missing references)
		//IL_03c4: Expected O, but got Unknown
		//IL_03cb: Unknown result type (might be due to invalid IL or missing references)
		//IL_03d5: Expected O, but got Unknown
		//IL_03dc: Unknown result type (might be due to invalid IL or missing references)
		//IL_03e6: Expected O, but got Unknown
		//IL_03ed: Unknown result type (might be due to invalid IL or missing references)
		//IL_03f7: Expected O, but got Unknown
		//IL_03fe: Unknown result type (might be due to invalid IL or missing references)
		//IL_0408: Expected O, but got Unknown
		//IL_040f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0419: Expected O, but got Unknown
		//IL_0426: Unknown result type (might be due to invalid IL or missing references)
		//IL_0430: Expected O, but got Unknown
		//IL_043e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0448: Expected O, but got Unknown
		//IL_0450: Unknown result type (might be due to invalid IL or missing references)
		//IL_045a: Expected O, but got Unknown
		//IL_0467: Unknown result type (might be due to invalid IL or missing references)
		//IL_0471: Expected O, but got Unknown
		//IL_047f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0489: Expected O, but got Unknown
		//IL_0491: Unknown result type (might be due to invalid IL or missing references)
		//IL_049b: Expected O, but got Unknown
		//IL_04a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_04b2: Expected O, but got Unknown
		//IL_04c0: Unknown result type (might be due to invalid IL or missing references)
		//IL_04ca: Expected O, but got Unknown
		//IL_04d2: Unknown result type (might be due to invalid IL or missing references)
		//IL_04dc: Expected O, but got Unknown
		//IL_04e9: Unknown result type (might be due to invalid IL or missing references)
		//IL_04f3: Expected O, but got Unknown
		//IL_0501: Unknown result type (might be due to invalid IL or missing references)
		//IL_050b: Expected O, but got Unknown
		//IL_0519: Unknown result type (might be due to invalid IL or missing references)
		//IL_0523: Expected O, but got Unknown
		//IL_052b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0535: Expected O, but got Unknown
		//IL_0542: Unknown result type (might be due to invalid IL or missing references)
		//IL_054c: Expected O, but got Unknown
		//IL_055a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0564: Expected O, but got Unknown
		//IL_0572: Unknown result type (might be due to invalid IL or missing references)
		//IL_057c: Expected O, but got Unknown
		//IL_0584: Unknown result type (might be due to invalid IL or missing references)
		//IL_058e: Expected O, but got Unknown
		//IL_059b: Unknown result type (might be due to invalid IL or missing references)
		//IL_05a5: Expected O, but got Unknown
		//IL_05b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_05bd: Expected O, but got Unknown
		//IL_05cb: Unknown result type (might be due to invalid IL or missing references)
		//IL_05d5: Expected O, but got Unknown
		//IL_05dd: Unknown result type (might be due to invalid IL or missing references)
		//IL_05e7: Expected O, but got Unknown
		//IL_05ee: Unknown result type (might be due to invalid IL or missing references)
		//IL_05f8: Expected O, but got Unknown
		//IL_05ff: Unknown result type (might be due to invalid IL or missing references)
		//IL_0609: Expected O, but got Unknown
		//IL_0610: Unknown result type (might be due to invalid IL or missing references)
		//IL_061a: Expected O, but got Unknown
		//IL_0621: Unknown result type (might be due to invalid IL or missing references)
		//IL_062b: Expected O, but got Unknown
		//IL_0632: Unknown result type (might be due to invalid IL or missing references)
		//IL_063c: Expected O, but got Unknown
		//IL_0643: Unknown result type (might be due to invalid IL or missing references)
		//IL_064d: Expected O, but got Unknown
		//IL_0654: Unknown result type (might be due to invalid IL or missing references)
		//IL_065e: Expected O, but got Unknown
		//IL_0665: Unknown result type (might be due to invalid IL or missing references)
		//IL_066f: Expected O, but got Unknown
		//IL_0676: Unknown result type (might be due to invalid IL or missing references)
		//IL_0680: Expected O, but got Unknown
		//IL_0687: Unknown result type (might be due to invalid IL or missing references)
		//IL_0691: Expected O, but got Unknown
		//IL_0698: Unknown result type (might be due to invalid IL or missing references)
		//IL_06a2: Expected O, but got Unknown
		//IL_06a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_06b3: Expected O, but got Unknown
		//IL_06ba: Unknown result type (might be due to invalid IL or missing references)
		//IL_06c4: Expected O, but got Unknown
		//IL_06cb: Unknown result type (might be due to invalid IL or missing references)
		//IL_06d5: Expected O, but got Unknown
		//IL_06e2: Unknown result type (might be due to invalid IL or missing references)
		//IL_06ec: Expected O, but got Unknown
		//IL_06fa: Unknown result type (might be due to invalid IL or missing references)
		//IL_0704: Expected O, but got Unknown
		//IL_070c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0716: Expected O, but got Unknown
		//IL_0723: Unknown result type (might be due to invalid IL or missing references)
		//IL_072d: Expected O, but got Unknown
		//IL_073b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0745: Expected O, but got Unknown
		//IL_074d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0757: Expected O, but got Unknown
		//IL_0764: Unknown result type (might be due to invalid IL or missing references)
		//IL_076e: Expected O, but got Unknown
		//IL_077c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0786: Expected O, but got Unknown
		//IL_078e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0798: Expected O, but got Unknown
		//IL_07a5: Unknown result type (might be due to invalid IL or missing references)
		//IL_07af: Expected O, but got Unknown
		//IL_07bd: Unknown result type (might be due to invalid IL or missing references)
		//IL_07c7: Expected O, but got Unknown
		//IL_07d5: Unknown result type (might be due to invalid IL or missing references)
		//IL_07df: Expected O, but got Unknown
		//IL_07e7: Unknown result type (might be due to invalid IL or missing references)
		//IL_07f1: Expected O, but got Unknown
		//IL_07fe: Unknown result type (might be due to invalid IL or missing references)
		//IL_0808: Expected O, but got Unknown
		//IL_0816: Unknown result type (might be due to invalid IL or missing references)
		//IL_0820: Expected O, but got Unknown
		//IL_082e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0838: Expected O, but got Unknown
		//IL_0840: Unknown result type (might be due to invalid IL or missing references)
		//IL_084a: Expected O, but got Unknown
		//IL_0857: Unknown result type (might be due to invalid IL or missing references)
		//IL_0861: Expected O, but got Unknown
		//IL_086f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0879: Expected O, but got Unknown
		//IL_0887: Unknown result type (might be due to invalid IL or missing references)
		//IL_0891: Expected O, but got Unknown
		//IL_0899: Unknown result type (might be due to invalid IL or missing references)
		//IL_08a3: Expected O, but got Unknown
		//IL_08aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_08b4: Expected O, but got Unknown
		//IL_08bb: Unknown result type (might be due to invalid IL or missing references)
		//IL_08c5: Expected O, but got Unknown
		//IL_08cc: Unknown result type (might be due to invalid IL or missing references)
		//IL_08d6: Expected O, but got Unknown
		//IL_08da: Unknown result type (might be due to invalid IL or missing references)
		//IL_08e4: Expected O, but got Unknown
		//IL_08e8: Unknown result type (might be due to invalid IL or missing references)
		//IL_08f2: Expected O, but got Unknown
		//IL_08f6: Unknown result type (might be due to invalid IL or missing references)
		//IL_0900: Expected O, but got Unknown
		//IL_0904: Unknown result type (might be due to invalid IL or missing references)
		//IL_090e: Expected O, but got Unknown
		//IL_0912: Unknown result type (might be due to invalid IL or missing references)
		//IL_091c: Expected O, but got Unknown
		//IL_0920: Unknown result type (might be due to invalid IL or missing references)
		//IL_092a: Expected O, but got Unknown
		//IL_092e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0938: Expected O, but got Unknown
		//IL_093c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0946: Expected O, but got Unknown
		switch (connectionId)
		{
		case 1:
			ZontOstrivnyyTyp3_Img = (Image)target;
			break;
		case 2:
			inputDataZontOstrivnyyTyp3_Vyhid1 = (GroupBox)target;
			break;
		case 3:
			inputDataInnerGridZontOstrivnyyTyp3_Vyhid1 = (Grid)target;
			break;
		case 4:
			textBox_d1_ZontOstrivnyyTyp3 = (TextBox)target;
			((UIElement)textBox_d1_ZontOstrivnyyTyp3).LostFocus += new RoutedEventHandler(ZontOstrivnyyTyp3_TextBox_d1_LostFocus);
			((UIElement)textBox_d1_ZontOstrivnyyTyp3).GotFocus += new RoutedEventHandler(TextBox_GotFocus);
			break;
		case 5:
			textBox_a1_ZontOstrivnyyTyp3 = (TextBox)target;
			((UIElement)textBox_a1_ZontOstrivnyyTyp3).LostFocus += new RoutedEventHandler(ZontOstrivnyyTyp3_TextBox_a1_LostFocus);
			((UIElement)textBox_a1_ZontOstrivnyyTyp3).GotFocus += new RoutedEventHandler(TextBox_GotFocus);
			break;
		case 6:
			textBox_b1_ZontOstrivnyyTyp3 = (TextBox)target;
			((UIElement)textBox_b1_ZontOstrivnyyTyp3).LostFocus += new RoutedEventHandler(ZontOstrivnyyTyp3_TextBox_b1_LostFocus);
			((UIElement)textBox_b1_ZontOstrivnyyTyp3).GotFocus += new RoutedEventHandler(TextBox_GotFocus);
			break;
		case 7:
			textBox_p1_ZontOstrivnyyTyp3 = (TextBox)target;
			((UIElement)textBox_p1_ZontOstrivnyyTyp3).LostFocus += new RoutedEventHandler(ZontOstrivnyyTyp3_TextBox_p1_LostFocus);
			((UIElement)textBox_p1_ZontOstrivnyyTyp3).PreviewMouseLeftButtonUp += new MouseButtonEventHandler(ZontOstrivnyyTyp3_TextBox_p1_PreviewMouseLeftButtonUp);
			((UIElement)textBox_p1_ZontOstrivnyyTyp3).GotFocus += new RoutedEventHandler(TextBox_GotFocus);
			break;
		case 8:
			textBox_f1_ZontOstrivnyyTyp3 = (TextBox)target;
			((UIElement)textBox_f1_ZontOstrivnyyTyp3).LostFocus += new RoutedEventHandler(ZontOstrivnyyTyp3_TextBox_f1_LostFocus);
			((UIElement)textBox_f1_ZontOstrivnyyTyp3).PreviewMouseLeftButtonUp += new MouseButtonEventHandler(ZontOstrivnyyTyp3_TextBox_f1_PreviewMouseLeftButtonUp);
			((UIElement)textBox_f1_ZontOstrivnyyTyp3).GotFocus += new RoutedEventHandler(TextBox_GotFocus);
			break;
		case 9:
			textBox_g1_ZontOstrivnyyTyp3 = (TextBox)target;
			((UIElement)textBox_g1_ZontOstrivnyyTyp3).LostFocus += new RoutedEventHandler(ZontOstrivnyyTyp3_TextBox_g1_LostFocus);
			((UIElement)textBox_g1_ZontOstrivnyyTyp3).PreviewMouseLeftButtonUp += new MouseButtonEventHandler(ZontOstrivnyyTyp3_TextBox_g1_PreviewMouseLeftButtonUp);
			((UIElement)textBox_g1_ZontOstrivnyyTyp3).GotFocus += new RoutedEventHandler(TextBox_GotFocus);
			break;
		case 10:
			comboBox_Vyhid1_ZontOstrivnyyTyp3 = (ComboBox)target;
			((Selector)comboBox_Vyhid1_ZontOstrivnyyTyp3).SelectionChanged += new SelectionChangedEventHandler(ZontOstrivnyyTyp3_Vyhid1Cbox_SelectionChanged);
			break;
		case 11:
			comboBox_typVyhid1_ZontOstrivnyyTyp3 = (ComboBox)target;
			break;
		case 12:
			comboBox_profilType1_ZontOstrivnyyTyp3 = (ComboBox)target;
			break;
		case 13:
			label_d1_ZontOstrivnyyTyp3 = (Label)target;
			break;
		case 14:
			label_p1_ZontOstrivnyyTyp3 = (Label)target;
			break;
		case 15:
			label_f1_ZontOstrivnyyTyp3 = (Label)target;
			break;
		case 16:
			label_g1_ZontOstrivnyyTyp3 = (Label)target;
			break;
		case 17:
			label_a1_ZontOstrivnyyTyp3 = (Label)target;
			break;
		case 18:
			label_b1_ZontOstrivnyyTyp3 = (Label)target;
			break;
		case 19:
			label_typVyhid1_ZontOstrivnyyTyp3 = (Label)target;
			break;
		case 20:
			label_Vyhid1_ZontOstrivnyyTyp3 = (Label)target;
			break;
		case 21:
			label_profilType1_ZontOstrivnyyTyp3 = (Label)target;
			break;
		case 22:
			inputDataZontOstrivnyyTyp3_Vyhid2 = (GroupBox)target;
			break;
		case 23:
			inputDataInnerGridZontOstrivnyyTyp3_Vyhid2 = (Grid)target;
			break;
		case 24:
			textBox_d2_ZontOstrivnyyTyp3 = (TextBox)target;
			((UIElement)textBox_d2_ZontOstrivnyyTyp3).LostFocus += new RoutedEventHandler(ZontOstrivnyyTyp3_TextBox_d2_LostFocus);
			((UIElement)textBox_d2_ZontOstrivnyyTyp3).GotFocus += new RoutedEventHandler(TextBox_GotFocus);
			break;
		case 25:
			textBox_a2_ZontOstrivnyyTyp3 = (TextBox)target;
			((UIElement)textBox_a2_ZontOstrivnyyTyp3).LostFocus += new RoutedEventHandler(ZontOstrivnyyTyp3_TextBox_a2_LostFocus);
			((UIElement)textBox_a2_ZontOstrivnyyTyp3).GotFocus += new RoutedEventHandler(TextBox_GotFocus);
			break;
		case 26:
			textBox_b2_ZontOstrivnyyTyp3 = (TextBox)target;
			((UIElement)textBox_b2_ZontOstrivnyyTyp3).LostFocus += new RoutedEventHandler(ZontOstrivnyyTyp3_TextBox_b2_LostFocus);
			((UIElement)textBox_b2_ZontOstrivnyyTyp3).GotFocus += new RoutedEventHandler(TextBox_GotFocus);
			break;
		case 27:
			textBox_p2_ZontOstrivnyyTyp3 = (TextBox)target;
			((UIElement)textBox_p2_ZontOstrivnyyTyp3).LostFocus += new RoutedEventHandler(ZontOstrivnyyTyp3_TextBox_p2_LostFocus);
			((UIElement)textBox_p2_ZontOstrivnyyTyp3).PreviewMouseLeftButtonUp += new MouseButtonEventHandler(ZontOstrivnyyTyp3_TextBox_p2_PreviewMouseLeftButtonUp);
			((UIElement)textBox_p2_ZontOstrivnyyTyp3).GotFocus += new RoutedEventHandler(TextBox_GotFocus);
			break;
		case 28:
			textBox_f2_ZontOstrivnyyTyp3 = (TextBox)target;
			((UIElement)textBox_f2_ZontOstrivnyyTyp3).LostFocus += new RoutedEventHandler(ZontOstrivnyyTyp3_TextBox_f2_LostFocus);
			((UIElement)textBox_f2_ZontOstrivnyyTyp3).PreviewMouseLeftButtonUp += new MouseButtonEventHandler(ZontOstrivnyyTyp3_TextBox_f2_PreviewMouseLeftButtonUp);
			((UIElement)textBox_f2_ZontOstrivnyyTyp3).GotFocus += new RoutedEventHandler(TextBox_GotFocus);
			break;
		case 29:
			textBox_g2_ZontOstrivnyyTyp3 = (TextBox)target;
			((UIElement)textBox_g2_ZontOstrivnyyTyp3).LostFocus += new RoutedEventHandler(ZontOstrivnyyTyp3_TextBox_g2_LostFocus);
			((UIElement)textBox_g2_ZontOstrivnyyTyp3).PreviewMouseLeftButtonUp += new MouseButtonEventHandler(ZontOstrivnyyTyp3_TextBox_g2_PreviewMouseLeftButtonUp);
			((UIElement)textBox_g2_ZontOstrivnyyTyp3).GotFocus += new RoutedEventHandler(TextBox_GotFocus);
			break;
		case 30:
			comboBox_Vyhid2_ZontOstrivnyyTyp3 = (ComboBox)target;
			break;
		case 31:
			comboBox_typVyhid2_ZontOstrivnyyTyp3 = (ComboBox)target;
			break;
		case 32:
			comboBox_profilType2_ZontOstrivnyyTyp3 = (ComboBox)target;
			break;
		case 33:
			label_d2_ZontOstrivnyyTyp3 = (Label)target;
			break;
		case 34:
			label_p2_ZontOstrivnyyTyp3 = (Label)target;
			break;
		case 35:
			label_f2_ZontOstrivnyyTyp3 = (Label)target;
			break;
		case 36:
			label_g2_ZontOstrivnyyTyp3 = (Label)target;
			break;
		case 37:
			label_a2_ZontOstrivnyyTyp3 = (Label)target;
			break;
		case 38:
			label_b2_ZontOstrivnyyTyp3 = (Label)target;
			break;
		case 39:
			label_typVyhid2_ZontOstrivnyyTyp3 = (Label)target;
			break;
		case 40:
			label_Vyhid2_ZontOstrivnyyTyp3 = (Label)target;
			break;
		case 41:
			label_profilType2_ZontOstrivnyyTyp3 = (Label)target;
			break;
		case 42:
			inputDataZontOstrivnyyTyp3_Vyhid3 = (GroupBox)target;
			break;
		case 43:
			inputDataInnerGridZontOstrivnyyTyp3_Vyhid3 = (Grid)target;
			break;
		case 44:
			textBox_d3_ZontOstrivnyyTyp3 = (TextBox)target;
			((UIElement)textBox_d3_ZontOstrivnyyTyp3).LostFocus += new RoutedEventHandler(ZontOstrivnyyTyp3_TextBox_d3_LostFocus);
			((UIElement)textBox_d3_ZontOstrivnyyTyp3).GotFocus += new RoutedEventHandler(TextBox_GotFocus);
			break;
		case 45:
			textBox_a3_ZontOstrivnyyTyp3 = (TextBox)target;
			((UIElement)textBox_a3_ZontOstrivnyyTyp3).LostFocus += new RoutedEventHandler(ZontOstrivnyyTyp3_TextBox_a3_LostFocus);
			((UIElement)textBox_a3_ZontOstrivnyyTyp3).GotFocus += new RoutedEventHandler(TextBox_GotFocus);
			break;
		case 46:
			textBox_b3_ZontOstrivnyyTyp3 = (TextBox)target;
			((UIElement)textBox_b3_ZontOstrivnyyTyp3).LostFocus += new RoutedEventHandler(ZontOstrivnyyTyp3_TextBox_b3_LostFocus);
			((UIElement)textBox_b3_ZontOstrivnyyTyp3).GotFocus += new RoutedEventHandler(TextBox_GotFocus);
			break;
		case 47:
			textBox_p3_ZontOstrivnyyTyp3 = (TextBox)target;
			((UIElement)textBox_p3_ZontOstrivnyyTyp3).LostFocus += new RoutedEventHandler(ZontOstrivnyyTyp3_TextBox_p3_LostFocus);
			((UIElement)textBox_p3_ZontOstrivnyyTyp3).PreviewMouseLeftButtonUp += new MouseButtonEventHandler(ZontOstrivnyyTyp3_TextBox_p3_PreviewMouseLeftButtonUp);
			((UIElement)textBox_p3_ZontOstrivnyyTyp3).GotFocus += new RoutedEventHandler(TextBox_GotFocus);
			break;
		case 48:
			textBox_f3_ZontOstrivnyyTyp3 = (TextBox)target;
			((UIElement)textBox_f3_ZontOstrivnyyTyp3).LostFocus += new RoutedEventHandler(ZontOstrivnyyTyp3_TextBox_f3_LostFocus);
			((UIElement)textBox_f3_ZontOstrivnyyTyp3).PreviewMouseLeftButtonUp += new MouseButtonEventHandler(ZontOstrivnyyTyp3_TextBox_f3_PreviewMouseLeftButtonUp);
			((UIElement)textBox_f3_ZontOstrivnyyTyp3).GotFocus += new RoutedEventHandler(TextBox_GotFocus);
			break;
		case 49:
			textBox_g3_ZontOstrivnyyTyp3 = (TextBox)target;
			((UIElement)textBox_g3_ZontOstrivnyyTyp3).LostFocus += new RoutedEventHandler(ZontOstrivnyyTyp3_TextBox_g3_LostFocus);
			((UIElement)textBox_g3_ZontOstrivnyyTyp3).PreviewMouseLeftButtonUp += new MouseButtonEventHandler(ZontOstrivnyyTyp3_TextBox_g3_PreviewMouseLeftButtonUp);
			((UIElement)textBox_g3_ZontOstrivnyyTyp3).GotFocus += new RoutedEventHandler(TextBox_GotFocus);
			break;
		case 50:
			comboBox_Vyhid3_ZontOstrivnyyTyp3 = (ComboBox)target;
			break;
		case 51:
			comboBox_typVyhid3_ZontOstrivnyyTyp3 = (ComboBox)target;
			break;
		case 52:
			comboBox_profilType3_ZontOstrivnyyTyp3 = (ComboBox)target;
			break;
		case 53:
			label_d3_ZontOstrivnyyTyp3 = (Label)target;
			break;
		case 54:
			label_p3_ZontOstrivnyyTyp3 = (Label)target;
			break;
		case 55:
			label_f3_ZontOstrivnyyTyp3 = (Label)target;
			break;
		case 56:
			label_g3_ZontOstrivnyyTyp3 = (Label)target;
			break;
		case 57:
			label_a3_ZontOstrivnyyTyp3 = (Label)target;
			break;
		case 58:
			label_b3_ZontOstrivnyyTyp3 = (Label)target;
			break;
		case 59:
			label_typVyhid3_ZontOstrivnyyTyp3 = (Label)target;
			break;
		case 60:
			label_Vyhid3_ZontOstrivnyyTyp3 = (Label)target;
			break;
		case 61:
			label_profilType3_ZontOstrivnyyTyp3 = (Label)target;
			break;
		default:
			_contentLoaded = true;
			break;
		}
	}
}
