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
using TEZ_Project.Common.Enums;
using TEZ_Project.Common.Helpers;

namespace TEZ_Project.ProductWindows;

public class ZontOstrivnyyTyp1Window : Window, IComponentConnector
{
	internal Image ZontOstrivnyyTyp1_Img;

	internal GroupBox inputDataZontOstrivnyyTyp1_Vyhid1;

	internal Grid inputDataInnerGridZontOstrivnyyTyp1_Vyhid1;

	internal TextBox textBox_d1_ZontOstrivnyyTyp1;

	internal TextBox textBox_a1_ZontOstrivnyyTyp1;

	internal TextBox textBox_b1_ZontOstrivnyyTyp1;

	internal TextBox textBox_p1_ZontOstrivnyyTyp1;

	internal TextBox textBox_f1_ZontOstrivnyyTyp1;

	internal TextBox textBox_g1_ZontOstrivnyyTyp1;

	internal ComboBox comboBox_Vyhid1_ZontOstrivnyyTyp1;

	internal ComboBox comboBox_typVyhid1_ZontOstrivnyyTyp1;

	internal ComboBox comboBox_profilType1_ZontOstrivnyyTyp1;

	internal Label label_d1_ZontOstrivnyyTyp1;

	internal Label label_p1_ZontOstrivnyyTyp1;

	internal Label label_f1_ZontOstrivnyyTyp1;

	internal Label label_g1_ZontOstrivnyyTyp1;

	internal Label label_a1_ZontOstrivnyyTyp1;

	internal Label label_b1_ZontOstrivnyyTyp1;

	internal Label label_typVyhid1_ZontOstrivnyyTyp1;

	internal Label label_Vyhid1_ZontOstrivnyyTyp1;

	internal Label label_profilType1_ZontOstrivnyyTyp1;

	internal GroupBox inputDataZontOstrivnyyTyp1_Vyhid2;

	internal Grid inputDataInnerGridZontOstrivnyyTyp1_Vyhid2;

	internal TextBox textBox_d2_ZontOstrivnyyTyp1;

	internal TextBox textBox_a2_ZontOstrivnyyTyp1;

	internal TextBox textBox_b2_ZontOstrivnyyTyp1;

	internal TextBox textBox_p2_ZontOstrivnyyTyp1;

	internal TextBox textBox_f2_ZontOstrivnyyTyp1;

	internal TextBox textBox_g2_ZontOstrivnyyTyp1;

	internal ComboBox comboBox_Vyhid2_ZontOstrivnyyTyp1;

	internal ComboBox comboBox_typVyhid2_ZontOstrivnyyTyp1;

	internal ComboBox comboBox_profilType2_ZontOstrivnyyTyp1;

	internal Label label_d2_ZontOstrivnyyTyp1;

	internal Label label_p2_ZontOstrivnyyTyp1;

	internal Label label_f2_ZontOstrivnyyTyp1;

	internal Label label_g2_ZontOstrivnyyTyp1;

	internal Label label_a2_ZontOstrivnyyTyp1;

	internal Label label_b2_ZontOstrivnyyTyp1;

	internal Label label_typVyhid2_ZontOstrivnyyTyp1;

	internal Label label_Vyhid2_ZontOstrivnyyTyp1;

	internal Label label_profilType2_ZontOstrivnyyTyp1;

	internal GroupBox inputDataZontOstrivnyyTyp1_Vyhid3;

	internal Grid inputDataInnerGridZontOstrivnyyTyp1_Vyhid3;

	internal TextBox textBox_d3_ZontOstrivnyyTyp1;

	internal TextBox textBox_a3_ZontOstrivnyyTyp1;

	internal TextBox textBox_b3_ZontOstrivnyyTyp1;

	internal TextBox textBox_p3_ZontOstrivnyyTyp1;

	internal TextBox textBox_f3_ZontOstrivnyyTyp1;

	internal TextBox textBox_g3_ZontOstrivnyyTyp1;

	internal ComboBox comboBox_Vyhid3_ZontOstrivnyyTyp1;

	internal ComboBox comboBox_typVyhid3_ZontOstrivnyyTyp1;

	internal ComboBox comboBox_profilType3_ZontOstrivnyyTyp1;

	internal Label label_d3_ZontOstrivnyyTyp1;

	internal Label label_p3_ZontOstrivnyyTyp1;

	internal Label label_f3_ZontOstrivnyyTyp1;

	internal Label label_g3_ZontOstrivnyyTyp1;

	internal Label label_a3_ZontOstrivnyyTyp1;

	internal Label label_b3_ZontOstrivnyyTyp1;

	internal Label label_typVyhid3_ZontOstrivnyyTyp1;

	internal Label label_Vyhid3_ZontOstrivnyyTyp1;

	internal Label label_profilType3_ZontOstrivnyyTyp1;

	private bool _contentLoaded;

	public MainWindow ParentWindow { get; set; }

	public ZontOstrivnyyTyp1Window()
	{
		InitializeComponent();
		ZontOstrivnyyTyp1_Vyhid_AttachEventHandlersToComboBoxes();
	}

	private void ZontOstrivnyyTyp1_Vyhid_AttachEventHandlersToComboBoxes()
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
		((Selector)comboBox_Vyhid2_ZontOstrivnyyTyp1).SelectionChanged += new SelectionChangedEventHandler(ZontOstrivnyyTyp1_Vyhid2Cbox_SelectionChanged);
		((Selector)comboBox_Vyhid3_ZontOstrivnyyTyp1).SelectionChanged += new SelectionChangedEventHandler(ZontOstrivnyyTyp1_Vyhid3Cbox_SelectionChanged);
		((Selector)comboBox_typVyhid1_ZontOstrivnyyTyp1).SelectionChanged += new SelectionChangedEventHandler(ZontOstrivnyyTyp1_TypVyhid1Cbox_SelectionChanged);
		((Selector)comboBox_typVyhid2_ZontOstrivnyyTyp1).SelectionChanged += new SelectionChangedEventHandler(ZontOstrivnyyTyp1_TypVyhid2Cbox_SelectionChanged);
		((Selector)comboBox_typVyhid3_ZontOstrivnyyTyp1).SelectionChanged += new SelectionChangedEventHandler(ZontOstrivnyyTyp1_TypVyhid3Cbox_SelectionChanged);
	}

	private void ZontOstrivnyyTyp1_Vyhid1Cbox_SelectionChanged(object sender, RoutedEventArgs e)
	{
		string text = comboBox_Vyhid1_ZontOstrivnyyTyp1?.GetValue();
		if (string.IsNullOrEmpty(text))
		{
			ParentWindow.ZontOstrivnyyTyp1_SetFirstImage();
			return;
		}
		if (text == "круглий")
		{
			((UIElement)textBox_d1_ZontOstrivnyyTyp1).Visibility = (Visibility)0;
			((UIElement)label_d1_ZontOstrivnyyTyp1).Visibility = (Visibility)0;
			textBox_a1_ZontOstrivnyyTyp1.Clear();
			((UIElement)textBox_a1_ZontOstrivnyyTyp1).Visibility = (Visibility)2;
			((UIElement)label_a1_ZontOstrivnyyTyp1).Visibility = (Visibility)2;
			textBox_b1_ZontOstrivnyyTyp1.Clear();
			((UIElement)textBox_b1_ZontOstrivnyyTyp1).Visibility = (Visibility)2;
			((UIElement)label_b1_ZontOstrivnyyTyp1).Visibility = (Visibility)2;
		}
		else if (text == "прямокутний")
		{
			((UIElement)textBox_a1_ZontOstrivnyyTyp1).Visibility = (Visibility)0;
			((UIElement)label_a1_ZontOstrivnyyTyp1).Visibility = (Visibility)0;
			((UIElement)textBox_b1_ZontOstrivnyyTyp1).Visibility = (Visibility)0;
			((UIElement)label_b1_ZontOstrivnyyTyp1).Visibility = (Visibility)0;
			textBox_d1_ZontOstrivnyyTyp1.Clear();
			((UIElement)textBox_d1_ZontOstrivnyyTyp1).Visibility = (Visibility)2;
			((UIElement)label_d1_ZontOstrivnyyTyp1).Visibility = (Visibility)2;
		}
		textBox_p1_ZontOstrivnyyTyp1.Text = "50";
		((UIElement)textBox_p1_ZontOstrivnyyTyp1).Visibility = (Visibility)0;
		((UIElement)label_p1_ZontOstrivnyyTyp1).Visibility = (Visibility)0;
		((UIElement)textBox_f1_ZontOstrivnyyTyp1).Visibility = (Visibility)0;
		((UIElement)label_f1_ZontOstrivnyyTyp1).Visibility = (Visibility)0;
		((UIElement)textBox_g1_ZontOstrivnyyTyp1).Visibility = (Visibility)0;
		((UIElement)label_g1_ZontOstrivnyyTyp1).Visibility = (Visibility)0;
		((Selector)comboBox_typVyhid1_ZontOstrivnyyTyp1).SelectedIndex = 0;
		((UIElement)comboBox_typVyhid1_ZontOstrivnyyTyp1).Visibility = (Visibility)0;
		((UIElement)label_typVyhid1_ZontOstrivnyyTyp1).Visibility = (Visibility)0;
		((UIElement)inputDataZontOstrivnyyTyp1_Vyhid2).Visibility = (Visibility)0;
		ParentWindow.ZontOstrivnyyTyp1_SetFirstImage();
	}

	private void ZontOstrivnyyTyp1_TypVyhid1Cbox_SelectionChanged(object sender, RoutedEventArgs e)
	{
		ZontVytiajniyHelper.ZontVytiajniy_TypVyhidCbox_SelectionChanged((ComboBox)((sender is ComboBox) ? sender : null), comboBox_Vyhid1_ZontOstrivnyyTyp1, comboBox_profilType1_ZontOstrivnyyTyp1, label_profilType1_ZontOstrivnyyTyp1);
	}

	public void ZontOstrivnyyTyp1_TextBox_d1_LostFocus(object sender, RoutedEventArgs e)
	{
		//IL_0071: Unknown result type (might be due to invalid IL or missing references)
		TextBox val = textBox_d1_ZontOstrivnyyTyp1;
		if (int.TryParse(val.Text, out var result) && int.TryParse(ParentWindow.textBox_b_ZontOstrivnyyTyp1.Text, out var result2))
		{
			int num = result2;
			if (result < 50 || result > num)
			{
				val.Text = "";
				MessageBox.Show($"Діаметр вихода 1 має бути в межах {50} - {num} мм");
				return;
			}
		}
		if (sender != null)
		{
			ParentWindow.ZontOstrivnyyTyp1_TextBox_LostFocus(sender, e);
		}
	}

	public void ZontOstrivnyyTyp1_TextBox_a1_LostFocus(object sender, RoutedEventArgs e)
	{
		//IL_006c: Unknown result type (might be due to invalid IL or missing references)
		TextBox val = textBox_a1_ZontOstrivnyyTyp1;
		if (int.TryParse(val.Text, out var result) && int.TryParse(ParentWindow.textBox_L_ZontOstrivnyyTyp1.Text, out var result2) && (result < 50 || result > result2))
		{
			val.Text = "";
			MessageBox.Show($"Довжина вихода 1 має бути в межах {50} - {result2} мм");
		}
		else if (sender != null)
		{
			ZontOstrivnyyTyp1_TextBox_Base_LostFocus(sender, e);
		}
	}

	public void ZontOstrivnyyTyp1_TextBox_b1_LostFocus(object sender, RoutedEventArgs e)
	{
		//IL_0071: Unknown result type (might be due to invalid IL or missing references)
		TextBox val = textBox_b1_ZontOstrivnyyTyp1;
		if (int.TryParse(val.Text, out var result) && int.TryParse(ParentWindow.textBox_b_ZontOstrivnyyTyp1.Text, out var result2))
		{
			int num = result2;
			if (result < 50 || result > num)
			{
				val.Text = "";
				MessageBox.Show($"Ширина вихода 1 має бути в межах {50} - {num} мм");
				return;
			}
		}
		if (sender != null)
		{
			ZontOstrivnyyTyp1_TextBox_Base_LostFocus(sender, e);
		}
	}

	public void ZontOstrivnyyTyp1_TextBox_p1_LostFocus(object sender, RoutedEventArgs e)
	{
		//IL_0090: Unknown result type (might be due to invalid IL or missing references)
		string text = comboBox_Vyhid1_ZontOstrivnyyTyp1?.GetValue();
		if (!string.IsNullOrEmpty(text))
		{
			int num = ((text == "круглий") ? 50 : 30);
			TextBox val = textBox_p1_ZontOstrivnyyTyp1;
			if (int.TryParse(val.Text, out var result) && (result < num || result > 600))
			{
				val.Text = "";
				MessageBox.Show($"Висота вихода 1 має бути в межах {num} - {600} мм");
			}
			else if (sender != null)
			{
				ParentWindow.ZontOstrivnyyTyp1_TextBox_LostFocus(sender, e);
			}
		}
	}

	private void ZontOstrivnyyTyp1_TextBox_p1_PreviewMouseLeftButtonUp(object sender, MouseButtonEventArgs e)
	{
		ParentWindow.ZontOstrivnyyTyp1_SetImage("p1");
	}

	private void ZontOstrivnyyTyp1_TextBox_g1_PreviewMouseLeftButtonUp(object sender, MouseButtonEventArgs e)
	{
		ZontOstrivnyyTyp1_SetInnerImage("g1");
	}

	private void ZontOstrivnyyTyp1_TextBox_f1_PreviewMouseLeftButtonUp(object sender, MouseButtonEventArgs e)
	{
		ZontOstrivnyyTyp1_SetInnerImage("f1");
	}

	private void ZontOstrivnyyTyp1_Vyhid2Cbox_SelectionChanged(object sender, RoutedEventArgs e)
	{
		string text = comboBox_Vyhid2_ZontOstrivnyyTyp1?.GetValue();
		if (string.IsNullOrEmpty(text))
		{
			textBox_a2_ZontOstrivnyyTyp1.Clear();
			textBox_b2_ZontOstrivnyyTyp1.Clear();
			textBox_d2_ZontOstrivnyyTyp1.Clear();
			textBox_p2_ZontOstrivnyyTyp1.Clear();
			textBox_f2_ZontOstrivnyyTyp1.Clear();
			textBox_g2_ZontOstrivnyyTyp1.Clear();
			((Selector)comboBox_typVyhid2_ZontOstrivnyyTyp1).SelectedItem = null;
			((UIElement)textBox_d2_ZontOstrivnyyTyp1).Visibility = (Visibility)2;
			((UIElement)label_d2_ZontOstrivnyyTyp1).Visibility = (Visibility)2;
			((UIElement)textBox_a2_ZontOstrivnyyTyp1).Visibility = (Visibility)2;
			((UIElement)label_a2_ZontOstrivnyyTyp1).Visibility = (Visibility)2;
			((UIElement)textBox_b2_ZontOstrivnyyTyp1).Visibility = (Visibility)2;
			((UIElement)label_b2_ZontOstrivnyyTyp1).Visibility = (Visibility)2;
			((UIElement)textBox_p2_ZontOstrivnyyTyp1).Visibility = (Visibility)2;
			((UIElement)label_p2_ZontOstrivnyyTyp1).Visibility = (Visibility)2;
			((UIElement)textBox_f2_ZontOstrivnyyTyp1).Visibility = (Visibility)2;
			((UIElement)label_f2_ZontOstrivnyyTyp1).Visibility = (Visibility)2;
			((UIElement)textBox_g2_ZontOstrivnyyTyp1).Visibility = (Visibility)2;
			((UIElement)label_g2_ZontOstrivnyyTyp1).Visibility = (Visibility)2;
			((UIElement)comboBox_typVyhid2_ZontOstrivnyyTyp1).Visibility = (Visibility)2;
			((UIElement)label_typVyhid2_ZontOstrivnyyTyp1).Visibility = (Visibility)2;
			((UIElement)comboBox_profilType2_ZontOstrivnyyTyp1).Visibility = (Visibility)2;
			((UIElement)label_profilType2_ZontOstrivnyyTyp1).Visibility = (Visibility)2;
			((Selector)comboBox_Vyhid3_ZontOstrivnyyTyp1).SelectedItem = null;
			((UIElement)inputDataZontOstrivnyyTyp1_Vyhid3).Visibility = (Visibility)2;
			ParentWindow.ZontOstrivnyyTyp1_SetFirstImage();
			return;
		}
		if (text == "круглий")
		{
			((UIElement)textBox_d2_ZontOstrivnyyTyp1).Visibility = (Visibility)0;
			((UIElement)label_d2_ZontOstrivnyyTyp1).Visibility = (Visibility)0;
			textBox_a2_ZontOstrivnyyTyp1.Clear();
			((UIElement)textBox_a2_ZontOstrivnyyTyp1).Visibility = (Visibility)2;
			((UIElement)label_a2_ZontOstrivnyyTyp1).Visibility = (Visibility)2;
			textBox_b2_ZontOstrivnyyTyp1.Clear();
			((UIElement)textBox_b2_ZontOstrivnyyTyp1).Visibility = (Visibility)2;
			((UIElement)label_b2_ZontOstrivnyyTyp1).Visibility = (Visibility)2;
		}
		else if (text == "прямокутний")
		{
			((UIElement)textBox_a2_ZontOstrivnyyTyp1).Visibility = (Visibility)0;
			((UIElement)label_a2_ZontOstrivnyyTyp1).Visibility = (Visibility)0;
			((UIElement)textBox_b2_ZontOstrivnyyTyp1).Visibility = (Visibility)0;
			((UIElement)label_b2_ZontOstrivnyyTyp1).Visibility = (Visibility)0;
			textBox_d2_ZontOstrivnyyTyp1.Clear();
			((UIElement)textBox_d2_ZontOstrivnyyTyp1).Visibility = (Visibility)2;
			((UIElement)label_d2_ZontOstrivnyyTyp1).Visibility = (Visibility)2;
		}
		textBox_p2_ZontOstrivnyyTyp1.Text = "50";
		((UIElement)textBox_p2_ZontOstrivnyyTyp1).Visibility = (Visibility)0;
		((UIElement)label_p2_ZontOstrivnyyTyp1).Visibility = (Visibility)0;
		((UIElement)textBox_f2_ZontOstrivnyyTyp1).Visibility = (Visibility)0;
		((UIElement)label_f2_ZontOstrivnyyTyp1).Visibility = (Visibility)0;
		((UIElement)textBox_g2_ZontOstrivnyyTyp1).Visibility = (Visibility)0;
		((UIElement)label_g2_ZontOstrivnyyTyp1).Visibility = (Visibility)0;
		((Selector)comboBox_typVyhid2_ZontOstrivnyyTyp1).SelectedIndex = 0;
		((UIElement)comboBox_typVyhid2_ZontOstrivnyyTyp1).Visibility = (Visibility)0;
		((UIElement)label_typVyhid2_ZontOstrivnyyTyp1).Visibility = (Visibility)0;
		((UIElement)inputDataZontOstrivnyyTyp1_Vyhid3).Visibility = (Visibility)0;
		ParentWindow.ZontOstrivnyyTyp1_SetFirstImage();
	}

	private void ZontOstrivnyyTyp1_TypVyhid2Cbox_SelectionChanged(object sender, RoutedEventArgs e)
	{
		ZontVytiajniyHelper.ZontVytiajniy_TypVyhidCbox_SelectionChanged((ComboBox)((sender is ComboBox) ? sender : null), comboBox_Vyhid2_ZontOstrivnyyTyp1, comboBox_profilType2_ZontOstrivnyyTyp1, label_profilType2_ZontOstrivnyyTyp1);
	}

	public void ZontOstrivnyyTyp1_TextBox_d2_LostFocus(object sender, RoutedEventArgs e)
	{
		//IL_0071: Unknown result type (might be due to invalid IL or missing references)
		TextBox val = textBox_d2_ZontOstrivnyyTyp1;
		if (int.TryParse(val.Text, out var result) && int.TryParse(ParentWindow.textBox_b_ZontOstrivnyyTyp1.Text, out var result2))
		{
			int num = result2;
			if (result < 50 || result > num)
			{
				val.Text = "";
				MessageBox.Show($"Діаметр вихода 2 має бути в межах {50} - {num} мм");
				return;
			}
		}
		if (sender != null)
		{
			ParentWindow.ZontOstrivnyyTyp1_TextBox_LostFocus(sender, e);
		}
	}

	public void ZontOstrivnyyTyp1_TextBox_a2_LostFocus(object sender, RoutedEventArgs e)
	{
		//IL_00a0: Unknown result type (might be due to invalid IL or missing references)
		TextBox val = textBox_a2_ZontOstrivnyyTyp1;
		if (int.TryParse(val.Text, out var result) && int.TryParse(ParentWindow.textBox_L_ZontOstrivnyyTyp1.Text, out var result2) && int.TryParse(textBox_d1_ZontOstrivnyyTyp1.Text, out var result3) && int.TryParse(textBox_a1_ZontOstrivnyyTyp1.Text, out var result4))
		{
			int num = result2 - result3 - result4;
			if (result < 50 || result > num)
			{
				val.Text = "";
				MessageBox.Show($"Довжина вихода 2 має бути в межах {50} - {num} мм");
				return;
			}
		}
		if (sender != null)
		{
			ZontOstrivnyyTyp1_TextBox_Base_LostFocus(sender, e);
		}
	}

	public void ZontOstrivnyyTyp1_TextBox_b2_LostFocus(object sender, RoutedEventArgs e)
	{
		//IL_006c: Unknown result type (might be due to invalid IL or missing references)
		TextBox val = textBox_b2_ZontOstrivnyyTyp1;
		if (int.TryParse(val.Text, out var result) && int.TryParse(ParentWindow.textBox_b_ZontOstrivnyyTyp1.Text, out var result2) && (result < 50 || result > result2))
		{
			val.Text = "";
			MessageBox.Show($"Ширина вихода 2 має бути в межах {50} - {result2} мм");
		}
		else if (sender != null)
		{
			ZontOstrivnyyTyp1_TextBox_Base_LostFocus(sender, e);
		}
	}

	public void ZontOstrivnyyTyp1_TextBox_p2_LostFocus(object sender, RoutedEventArgs e)
	{
		//IL_0090: Unknown result type (might be due to invalid IL or missing references)
		string text = comboBox_Vyhid2_ZontOstrivnyyTyp1?.GetValue();
		if (!string.IsNullOrEmpty(text))
		{
			int num = ((text == "круглий") ? 50 : 30);
			TextBox val = textBox_p2_ZontOstrivnyyTyp1;
			if (int.TryParse(val.Text, out var result) && (result < num || result > 600))
			{
				val.Text = "";
				MessageBox.Show($"Висота вихода 2 має бути в межах {num} - {600} мм");
			}
			else if (sender != null)
			{
				ParentWindow.ZontOstrivnyyTyp1_TextBox_LostFocus(sender, e);
			}
		}
	}

	private void ZontOstrivnyyTyp1_TextBox_p2_PreviewMouseLeftButtonUp(object sender, MouseButtonEventArgs e)
	{
		ParentWindow.ZontOstrivnyyTyp1_SetImage("p2");
	}

	private void ZontOstrivnyyTyp1_TextBox_g2_PreviewMouseLeftButtonUp(object sender, MouseButtonEventArgs e)
	{
		ZontOstrivnyyTyp1_SetInnerImage("g2");
	}

	private void ZontOstrivnyyTyp1_TextBox_f2_PreviewMouseLeftButtonUp(object sender, MouseButtonEventArgs e)
	{
		ZontOstrivnyyTyp1_SetInnerImage("f2");
	}

	private void ZontOstrivnyyTyp1_Vyhid3Cbox_SelectionChanged(object sender, RoutedEventArgs e)
	{
		string text = comboBox_Vyhid3_ZontOstrivnyyTyp1?.GetValue();
		if (string.IsNullOrEmpty(text))
		{
			textBox_a3_ZontOstrivnyyTyp1.Clear();
			textBox_b3_ZontOstrivnyyTyp1.Clear();
			textBox_d3_ZontOstrivnyyTyp1.Clear();
			textBox_p3_ZontOstrivnyyTyp1.Clear();
			textBox_f3_ZontOstrivnyyTyp1.Clear();
			textBox_g3_ZontOstrivnyyTyp1.Clear();
			((Selector)comboBox_typVyhid3_ZontOstrivnyyTyp1).SelectedItem = null;
			((UIElement)textBox_d3_ZontOstrivnyyTyp1).Visibility = (Visibility)2;
			((UIElement)label_d3_ZontOstrivnyyTyp1).Visibility = (Visibility)2;
			((UIElement)textBox_a3_ZontOstrivnyyTyp1).Visibility = (Visibility)2;
			((UIElement)label_a3_ZontOstrivnyyTyp1).Visibility = (Visibility)2;
			((UIElement)textBox_b3_ZontOstrivnyyTyp1).Visibility = (Visibility)2;
			((UIElement)label_b3_ZontOstrivnyyTyp1).Visibility = (Visibility)2;
			((UIElement)textBox_p3_ZontOstrivnyyTyp1).Visibility = (Visibility)2;
			((UIElement)label_p3_ZontOstrivnyyTyp1).Visibility = (Visibility)2;
			((UIElement)textBox_f3_ZontOstrivnyyTyp1).Visibility = (Visibility)2;
			((UIElement)label_f3_ZontOstrivnyyTyp1).Visibility = (Visibility)2;
			((UIElement)textBox_g3_ZontOstrivnyyTyp1).Visibility = (Visibility)2;
			((UIElement)label_g3_ZontOstrivnyyTyp1).Visibility = (Visibility)2;
			((UIElement)comboBox_typVyhid3_ZontOstrivnyyTyp1).Visibility = (Visibility)2;
			((UIElement)label_typVyhid3_ZontOstrivnyyTyp1).Visibility = (Visibility)2;
			((UIElement)comboBox_profilType3_ZontOstrivnyyTyp1).Visibility = (Visibility)2;
			((UIElement)label_profilType3_ZontOstrivnyyTyp1).Visibility = (Visibility)2;
			ParentWindow.ZontOstrivnyyTyp1_SetFirstImage();
			return;
		}
		if (text == "круглий")
		{
			((UIElement)textBox_d3_ZontOstrivnyyTyp1).Visibility = (Visibility)0;
			((UIElement)label_d3_ZontOstrivnyyTyp1).Visibility = (Visibility)0;
			textBox_a3_ZontOstrivnyyTyp1.Clear();
			((UIElement)textBox_a3_ZontOstrivnyyTyp1).Visibility = (Visibility)2;
			((UIElement)label_a3_ZontOstrivnyyTyp1).Visibility = (Visibility)2;
			textBox_b3_ZontOstrivnyyTyp1.Clear();
			((UIElement)textBox_b3_ZontOstrivnyyTyp1).Visibility = (Visibility)2;
			((UIElement)label_b3_ZontOstrivnyyTyp1).Visibility = (Visibility)2;
		}
		else if (text == "прямокутний")
		{
			((UIElement)textBox_a3_ZontOstrivnyyTyp1).Visibility = (Visibility)0;
			((UIElement)label_a3_ZontOstrivnyyTyp1).Visibility = (Visibility)0;
			((UIElement)textBox_b3_ZontOstrivnyyTyp1).Visibility = (Visibility)0;
			((UIElement)label_b3_ZontOstrivnyyTyp1).Visibility = (Visibility)0;
			textBox_d3_ZontOstrivnyyTyp1.Clear();
			((UIElement)textBox_d3_ZontOstrivnyyTyp1).Visibility = (Visibility)2;
			((UIElement)label_d3_ZontOstrivnyyTyp1).Visibility = (Visibility)2;
		}
		textBox_p3_ZontOstrivnyyTyp1.Text = "50";
		((UIElement)textBox_p3_ZontOstrivnyyTyp1).Visibility = (Visibility)0;
		((UIElement)label_p3_ZontOstrivnyyTyp1).Visibility = (Visibility)0;
		((UIElement)textBox_f3_ZontOstrivnyyTyp1).Visibility = (Visibility)0;
		((UIElement)label_f3_ZontOstrivnyyTyp1).Visibility = (Visibility)0;
		((UIElement)textBox_g3_ZontOstrivnyyTyp1).Visibility = (Visibility)0;
		((UIElement)label_g3_ZontOstrivnyyTyp1).Visibility = (Visibility)0;
		((Selector)comboBox_typVyhid3_ZontOstrivnyyTyp1).SelectedIndex = 0;
		((UIElement)comboBox_typVyhid3_ZontOstrivnyyTyp1).Visibility = (Visibility)0;
		((UIElement)label_typVyhid3_ZontOstrivnyyTyp1).Visibility = (Visibility)0;
		((UIElement)inputDataZontOstrivnyyTyp1_Vyhid3).Visibility = (Visibility)0;
		ParentWindow.ZontOstrivnyyTyp1_SetFirstImage();
	}

	private void ZontOstrivnyyTyp1_TypVyhid3Cbox_SelectionChanged(object sender, RoutedEventArgs e)
	{
		ZontVytiajniyHelper.ZontVytiajniy_TypVyhidCbox_SelectionChanged((ComboBox)((sender is ComboBox) ? sender : null), comboBox_Vyhid3_ZontOstrivnyyTyp1, comboBox_profilType3_ZontOstrivnyyTyp1, label_profilType3_ZontOstrivnyyTyp1);
	}

	public void ZontOstrivnyyTyp1_TextBox_d3_LostFocus(object sender, RoutedEventArgs e)
	{
		//IL_0071: Unknown result type (might be due to invalid IL or missing references)
		TextBox val = textBox_d3_ZontOstrivnyyTyp1;
		if (int.TryParse(val.Text, out var result) && int.TryParse(ParentWindow.textBox_b_ZontOstrivnyyTyp1.Text, out var result2))
		{
			int num = result2;
			if (result < 50 || result > num)
			{
				val.Text = "";
				MessageBox.Show($"Діаметр вихода 3 має бути в межах {50} - {num} мм");
				return;
			}
		}
		if (sender != null)
		{
			ParentWindow.ZontOstrivnyyTyp1_TextBox_LostFocus(sender, e);
		}
	}

	public void ZontOstrivnyyTyp1_TextBox_a3_LostFocus(object sender, RoutedEventArgs e)
	{
		//IL_00ce: Unknown result type (might be due to invalid IL or missing references)
		TextBox val = textBox_a3_ZontOstrivnyyTyp1;
		if (int.TryParse(val.Text, out var result) && int.TryParse(ParentWindow.textBox_L_ZontOstrivnyyTyp1.Text, out var result2) && int.TryParse(textBox_d1_ZontOstrivnyyTyp1.Text, out var result3) && int.TryParse(textBox_a1_ZontOstrivnyyTyp1.Text, out var result4) && int.TryParse(textBox_d2_ZontOstrivnyyTyp1.Text, out var result5) && int.TryParse(textBox_a2_ZontOstrivnyyTyp1.Text, out var result6))
		{
			int num = result2 - result3 - result4 - result5 - result6;
			if (result < 50 || result > num)
			{
				val.Text = "";
				MessageBox.Show($"Довжина вихода 3 має бути в межах {50} - {num} мм");
				return;
			}
		}
		if (sender != null)
		{
			ZontOstrivnyyTyp1_TextBox_Base_LostFocus(sender, e);
		}
	}

	public void ZontOstrivnyyTyp1_TextBox_b3_LostFocus(object sender, RoutedEventArgs e)
	{
		//IL_006c: Unknown result type (might be due to invalid IL or missing references)
		TextBox val = textBox_b3_ZontOstrivnyyTyp1;
		if (int.TryParse(val.Text, out var result) && int.TryParse(ParentWindow.textBox_b_ZontOstrivnyyTyp1.Text, out var result2) && (result < 50 || result > result2))
		{
			val.Text = "";
			MessageBox.Show($"Ширина вихода 3 має бути в межах {50} - {result2} мм");
		}
		else if (sender != null)
		{
			ZontOstrivnyyTyp1_TextBox_Base_LostFocus(sender, e);
		}
	}

	public void ZontOstrivnyyTyp1_TextBox_p3_LostFocus(object sender, RoutedEventArgs e)
	{
		//IL_0090: Unknown result type (might be due to invalid IL or missing references)
		string text = comboBox_Vyhid3_ZontOstrivnyyTyp1?.GetValue();
		if (!string.IsNullOrEmpty(text))
		{
			int num = ((text == "круглий") ? 50 : 30);
			TextBox val = textBox_p3_ZontOstrivnyyTyp1;
			if (int.TryParse(val.Text, out var result) && (result < num || result > 600))
			{
				val.Text = "";
				MessageBox.Show($"Висота вихода 3 має бути в межах {num} - {600} мм");
			}
			else if (sender != null)
			{
				ParentWindow.ZontOstrivnyyTyp1_TextBox_LostFocus(sender, e);
			}
		}
	}

	private void ZontOstrivnyyTyp1_TextBox_p3_PreviewMouseLeftButtonUp(object sender, MouseButtonEventArgs e)
	{
		ParentWindow.ZontOstrivnyyTyp1_SetImage("p3");
	}

	private void ZontOstrivnyyTyp1_TextBox_g3_PreviewMouseLeftButtonUp(object sender, MouseButtonEventArgs e)
	{
		ZontOstrivnyyTyp1_SetInnerImage("g3");
	}

	private void ZontOstrivnyyTyp1_TextBox_f3_PreviewMouseLeftButtonUp(object sender, MouseButtonEventArgs e)
	{
		ZontOstrivnyyTyp1_SetInnerImage("f3");
	}

	private void TextBox_GotFocus(object sender, RoutedEventArgs e)
	{
		ParentWindow.TextBox_GotFocus(sender, e);
	}

	public void ZontOstrivnyyTyp1_TextBox_LostFocus(object sender, RoutedEventArgs e)
	{
		ParentWindow.ZontOstrivnyyTyp1_TextBox_LostFocus(sender, e);
	}

	public void ZontOstrivnyyTyp1_TextBox_Base_LostFocus(object sender, RoutedEventArgs e)
	{
		ZontOstrivnyyTyp1_Img.Source = null;
		((UIElement)ZontOstrivnyyTyp1_Img).Visibility = (Visibility)2;
		if (ParentWindow.TextBoxHasValue(sender))
		{
		}
	}

	public void ZontOstrivnyyTyp1_SetInnerImage(string parameter)
	{
		string text = "ZontOstrivnyyTyp1_Top_100";
		switch (ParentWindow.ZontOstrivnyyTyp1_GetImageType())
		{
		case ZontVytyazhnyyComplex_ImageType.V100:
		case ZontVytyazhnyyComplex_ImageType.V100ZF:
		case ZontVytyazhnyyComplex_ImageType.V100ZF2:
			text = "ZontOstrivnyyTyp1_Top_100";
			break;
		case ZontVytyazhnyyComplex_ImageType.V110:
		case ZontVytyazhnyyComplex_ImageType.V110ZF:
		case ZontVytyazhnyyComplex_ImageType.V110ZF2:
			text = "ZontOstrivnyyTyp1_Top_110";
			break;
		case ZontVytyazhnyyComplex_ImageType.V111:
		case ZontVytyazhnyyComplex_ImageType.V111ZF:
		case ZontVytyazhnyyComplex_ImageType.V111ZF2:
			text = "ZontOstrivnyyTyp1_Top_111";
			break;
		case ZontVytyazhnyyComplex_ImageType.V112:
		case ZontVytyazhnyyComplex_ImageType.V112ZF:
		case ZontVytyazhnyyComplex_ImageType.V112ZF2:
			text = "ZontOstrivnyyTyp1_Top_112";
			break;
		case ZontVytyazhnyyComplex_ImageType.V120:
		case ZontVytyazhnyyComplex_ImageType.V120ZF:
		case ZontVytyazhnyyComplex_ImageType.V120ZF2:
			text = "ZontOstrivnyyTyp1_Top_120";
			break;
		case ZontVytyazhnyyComplex_ImageType.V121:
		case ZontVytyazhnyyComplex_ImageType.V121ZF:
		case ZontVytyazhnyyComplex_ImageType.V121ZF2:
			text = "ZontOstrivnyyTyp1_Top_121";
			break;
		case ZontVytyazhnyyComplex_ImageType.V122:
		case ZontVytyazhnyyComplex_ImageType.V122ZF:
		case ZontVytyazhnyyComplex_ImageType.V122ZF2:
			text = "ZontOstrivnyyTyp1_Top_122";
			break;
		case ZontVytyazhnyyComplex_ImageType.V200:
		case ZontVytyazhnyyComplex_ImageType.V200ZF:
		case ZontVytyazhnyyComplex_ImageType.V200ZF2:
			text = "ZontOstrivnyyTyp1_Top_200";
			break;
		case ZontVytyazhnyyComplex_ImageType.V210:
		case ZontVytyazhnyyComplex_ImageType.V210ZF:
		case ZontVytyazhnyyComplex_ImageType.V210ZF2:
			text = "ZontOstrivnyyTyp1_Top_210";
			break;
		case ZontVytyazhnyyComplex_ImageType.V211:
		case ZontVytyazhnyyComplex_ImageType.V211ZF:
		case ZontVytyazhnyyComplex_ImageType.V211ZF2:
			text = "ZontOstrivnyyTyp1_Top_211";
			break;
		case ZontVytyazhnyyComplex_ImageType.V212:
		case ZontVytyazhnyyComplex_ImageType.V212ZF:
		case ZontVytyazhnyyComplex_ImageType.V212ZF2:
			text = "ZontOstrivnyyTyp1_Top_212";
			break;
		case ZontVytyazhnyyComplex_ImageType.V220:
		case ZontVytyazhnyyComplex_ImageType.V220ZF:
		case ZontVytyazhnyyComplex_ImageType.V220ZF2:
			text = "ZontOstrivnyyTyp1_Top_220";
			break;
		case ZontVytyazhnyyComplex_ImageType.V221:
		case ZontVytyazhnyyComplex_ImageType.V221ZF:
		case ZontVytyazhnyyComplex_ImageType.V221ZF2:
			text = "ZontOstrivnyyTyp1_Top_221";
			break;
		case ZontVytyazhnyyComplex_ImageType.V222:
		case ZontVytyazhnyyComplex_ImageType.V222ZF:
		case ZontVytyazhnyyComplex_ImageType.V222ZF2:
			text = "ZontOstrivnyyTyp1_Top_222";
			break;
		}
		string imagePath = "/Images/Zonty/ZontOstrivnyyType1/" + text + "_" + parameter + ".jpg";
		ZontOstrivnyyTyp1_SetImages(imagePath);
	}

	private void ZontOstrivnyyTyp1_SetImages(string imagePath)
	{
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0035: Expected O, but got Unknown
		ParentWindow.shapeImg.Source = (ImageSource)new BitmapImage(new Uri(imagePath, UriKind.Relative));
		ZontOstrivnyyTyp1_Img.Source = (ImageSource)new BitmapImage(new Uri(imagePath, UriKind.Relative));
		((UIElement)ZontOstrivnyyTyp1_Img).Visibility = (Visibility)0;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	public void InitializeComponent()
	{
		if (!_contentLoaded)
		{
			_contentLoaded = true;
			Uri uri = new Uri("/TEZ_Project;component/productwindows/zontostrivnyytyp1window.xaml", UriKind.Relative);
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
			ZontOstrivnyyTyp1_Img = (Image)target;
			break;
		case 2:
			inputDataZontOstrivnyyTyp1_Vyhid1 = (GroupBox)target;
			break;
		case 3:
			inputDataInnerGridZontOstrivnyyTyp1_Vyhid1 = (Grid)target;
			break;
		case 4:
			textBox_d1_ZontOstrivnyyTyp1 = (TextBox)target;
			((UIElement)textBox_d1_ZontOstrivnyyTyp1).LostFocus += new RoutedEventHandler(ZontOstrivnyyTyp1_TextBox_d1_LostFocus);
			((UIElement)textBox_d1_ZontOstrivnyyTyp1).GotFocus += new RoutedEventHandler(TextBox_GotFocus);
			break;
		case 5:
			textBox_a1_ZontOstrivnyyTyp1 = (TextBox)target;
			((UIElement)textBox_a1_ZontOstrivnyyTyp1).LostFocus += new RoutedEventHandler(ZontOstrivnyyTyp1_TextBox_a1_LostFocus);
			((UIElement)textBox_a1_ZontOstrivnyyTyp1).GotFocus += new RoutedEventHandler(TextBox_GotFocus);
			break;
		case 6:
			textBox_b1_ZontOstrivnyyTyp1 = (TextBox)target;
			((UIElement)textBox_b1_ZontOstrivnyyTyp1).LostFocus += new RoutedEventHandler(ZontOstrivnyyTyp1_TextBox_b1_LostFocus);
			((UIElement)textBox_b1_ZontOstrivnyyTyp1).GotFocus += new RoutedEventHandler(TextBox_GotFocus);
			break;
		case 7:
			textBox_p1_ZontOstrivnyyTyp1 = (TextBox)target;
			((UIElement)textBox_p1_ZontOstrivnyyTyp1).LostFocus += new RoutedEventHandler(ZontOstrivnyyTyp1_TextBox_p1_LostFocus);
			((UIElement)textBox_p1_ZontOstrivnyyTyp1).PreviewMouseLeftButtonUp += new MouseButtonEventHandler(ZontOstrivnyyTyp1_TextBox_p1_PreviewMouseLeftButtonUp);
			((UIElement)textBox_p1_ZontOstrivnyyTyp1).GotFocus += new RoutedEventHandler(TextBox_GotFocus);
			break;
		case 8:
			textBox_f1_ZontOstrivnyyTyp1 = (TextBox)target;
			((UIElement)textBox_f1_ZontOstrivnyyTyp1).LostFocus += new RoutedEventHandler(ZontOstrivnyyTyp1_TextBox_Base_LostFocus);
			((UIElement)textBox_f1_ZontOstrivnyyTyp1).PreviewMouseLeftButtonUp += new MouseButtonEventHandler(ZontOstrivnyyTyp1_TextBox_f1_PreviewMouseLeftButtonUp);
			((UIElement)textBox_f1_ZontOstrivnyyTyp1).GotFocus += new RoutedEventHandler(TextBox_GotFocus);
			break;
		case 9:
			textBox_g1_ZontOstrivnyyTyp1 = (TextBox)target;
			((UIElement)textBox_g1_ZontOstrivnyyTyp1).LostFocus += new RoutedEventHandler(ZontOstrivnyyTyp1_TextBox_Base_LostFocus);
			((UIElement)textBox_g1_ZontOstrivnyyTyp1).PreviewMouseLeftButtonUp += new MouseButtonEventHandler(ZontOstrivnyyTyp1_TextBox_g1_PreviewMouseLeftButtonUp);
			((UIElement)textBox_g1_ZontOstrivnyyTyp1).GotFocus += new RoutedEventHandler(TextBox_GotFocus);
			break;
		case 10:
			comboBox_Vyhid1_ZontOstrivnyyTyp1 = (ComboBox)target;
			((Selector)comboBox_Vyhid1_ZontOstrivnyyTyp1).SelectionChanged += new SelectionChangedEventHandler(ZontOstrivnyyTyp1_Vyhid1Cbox_SelectionChanged);
			break;
		case 11:
			comboBox_typVyhid1_ZontOstrivnyyTyp1 = (ComboBox)target;
			break;
		case 12:
			comboBox_profilType1_ZontOstrivnyyTyp1 = (ComboBox)target;
			break;
		case 13:
			label_d1_ZontOstrivnyyTyp1 = (Label)target;
			break;
		case 14:
			label_p1_ZontOstrivnyyTyp1 = (Label)target;
			break;
		case 15:
			label_f1_ZontOstrivnyyTyp1 = (Label)target;
			break;
		case 16:
			label_g1_ZontOstrivnyyTyp1 = (Label)target;
			break;
		case 17:
			label_a1_ZontOstrivnyyTyp1 = (Label)target;
			break;
		case 18:
			label_b1_ZontOstrivnyyTyp1 = (Label)target;
			break;
		case 19:
			label_typVyhid1_ZontOstrivnyyTyp1 = (Label)target;
			break;
		case 20:
			label_Vyhid1_ZontOstrivnyyTyp1 = (Label)target;
			break;
		case 21:
			label_profilType1_ZontOstrivnyyTyp1 = (Label)target;
			break;
		case 22:
			inputDataZontOstrivnyyTyp1_Vyhid2 = (GroupBox)target;
			break;
		case 23:
			inputDataInnerGridZontOstrivnyyTyp1_Vyhid2 = (Grid)target;
			break;
		case 24:
			textBox_d2_ZontOstrivnyyTyp1 = (TextBox)target;
			((UIElement)textBox_d2_ZontOstrivnyyTyp1).LostFocus += new RoutedEventHandler(ZontOstrivnyyTyp1_TextBox_d2_LostFocus);
			((UIElement)textBox_d2_ZontOstrivnyyTyp1).GotFocus += new RoutedEventHandler(TextBox_GotFocus);
			break;
		case 25:
			textBox_a2_ZontOstrivnyyTyp1 = (TextBox)target;
			((UIElement)textBox_a2_ZontOstrivnyyTyp1).LostFocus += new RoutedEventHandler(ZontOstrivnyyTyp1_TextBox_a2_LostFocus);
			((UIElement)textBox_a2_ZontOstrivnyyTyp1).GotFocus += new RoutedEventHandler(TextBox_GotFocus);
			break;
		case 26:
			textBox_b2_ZontOstrivnyyTyp1 = (TextBox)target;
			((UIElement)textBox_b2_ZontOstrivnyyTyp1).LostFocus += new RoutedEventHandler(ZontOstrivnyyTyp1_TextBox_b2_LostFocus);
			((UIElement)textBox_b2_ZontOstrivnyyTyp1).GotFocus += new RoutedEventHandler(TextBox_GotFocus);
			break;
		case 27:
			textBox_p2_ZontOstrivnyyTyp1 = (TextBox)target;
			((UIElement)textBox_p2_ZontOstrivnyyTyp1).LostFocus += new RoutedEventHandler(ZontOstrivnyyTyp1_TextBox_p2_LostFocus);
			((UIElement)textBox_p2_ZontOstrivnyyTyp1).PreviewMouseLeftButtonUp += new MouseButtonEventHandler(ZontOstrivnyyTyp1_TextBox_p2_PreviewMouseLeftButtonUp);
			((UIElement)textBox_p2_ZontOstrivnyyTyp1).GotFocus += new RoutedEventHandler(TextBox_GotFocus);
			break;
		case 28:
			textBox_f2_ZontOstrivnyyTyp1 = (TextBox)target;
			((UIElement)textBox_f2_ZontOstrivnyyTyp1).LostFocus += new RoutedEventHandler(ZontOstrivnyyTyp1_TextBox_Base_LostFocus);
			((UIElement)textBox_f2_ZontOstrivnyyTyp1).PreviewMouseLeftButtonUp += new MouseButtonEventHandler(ZontOstrivnyyTyp1_TextBox_f2_PreviewMouseLeftButtonUp);
			((UIElement)textBox_f2_ZontOstrivnyyTyp1).GotFocus += new RoutedEventHandler(TextBox_GotFocus);
			break;
		case 29:
			textBox_g2_ZontOstrivnyyTyp1 = (TextBox)target;
			((UIElement)textBox_g2_ZontOstrivnyyTyp1).LostFocus += new RoutedEventHandler(ZontOstrivnyyTyp1_TextBox_Base_LostFocus);
			((UIElement)textBox_g2_ZontOstrivnyyTyp1).PreviewMouseLeftButtonUp += new MouseButtonEventHandler(ZontOstrivnyyTyp1_TextBox_g2_PreviewMouseLeftButtonUp);
			((UIElement)textBox_g2_ZontOstrivnyyTyp1).GotFocus += new RoutedEventHandler(TextBox_GotFocus);
			break;
		case 30:
			comboBox_Vyhid2_ZontOstrivnyyTyp1 = (ComboBox)target;
			break;
		case 31:
			comboBox_typVyhid2_ZontOstrivnyyTyp1 = (ComboBox)target;
			break;
		case 32:
			comboBox_profilType2_ZontOstrivnyyTyp1 = (ComboBox)target;
			break;
		case 33:
			label_d2_ZontOstrivnyyTyp1 = (Label)target;
			break;
		case 34:
			label_p2_ZontOstrivnyyTyp1 = (Label)target;
			break;
		case 35:
			label_f2_ZontOstrivnyyTyp1 = (Label)target;
			break;
		case 36:
			label_g2_ZontOstrivnyyTyp1 = (Label)target;
			break;
		case 37:
			label_a2_ZontOstrivnyyTyp1 = (Label)target;
			break;
		case 38:
			label_b2_ZontOstrivnyyTyp1 = (Label)target;
			break;
		case 39:
			label_typVyhid2_ZontOstrivnyyTyp1 = (Label)target;
			break;
		case 40:
			label_Vyhid2_ZontOstrivnyyTyp1 = (Label)target;
			break;
		case 41:
			label_profilType2_ZontOstrivnyyTyp1 = (Label)target;
			break;
		case 42:
			inputDataZontOstrivnyyTyp1_Vyhid3 = (GroupBox)target;
			break;
		case 43:
			inputDataInnerGridZontOstrivnyyTyp1_Vyhid3 = (Grid)target;
			break;
		case 44:
			textBox_d3_ZontOstrivnyyTyp1 = (TextBox)target;
			((UIElement)textBox_d3_ZontOstrivnyyTyp1).LostFocus += new RoutedEventHandler(ZontOstrivnyyTyp1_TextBox_d3_LostFocus);
			((UIElement)textBox_d3_ZontOstrivnyyTyp1).GotFocus += new RoutedEventHandler(TextBox_GotFocus);
			break;
		case 45:
			textBox_a3_ZontOstrivnyyTyp1 = (TextBox)target;
			((UIElement)textBox_a3_ZontOstrivnyyTyp1).LostFocus += new RoutedEventHandler(ZontOstrivnyyTyp1_TextBox_a3_LostFocus);
			((UIElement)textBox_a3_ZontOstrivnyyTyp1).GotFocus += new RoutedEventHandler(TextBox_GotFocus);
			break;
		case 46:
			textBox_b3_ZontOstrivnyyTyp1 = (TextBox)target;
			((UIElement)textBox_b3_ZontOstrivnyyTyp1).LostFocus += new RoutedEventHandler(ZontOstrivnyyTyp1_TextBox_b3_LostFocus);
			((UIElement)textBox_b3_ZontOstrivnyyTyp1).GotFocus += new RoutedEventHandler(TextBox_GotFocus);
			break;
		case 47:
			textBox_p3_ZontOstrivnyyTyp1 = (TextBox)target;
			((UIElement)textBox_p3_ZontOstrivnyyTyp1).LostFocus += new RoutedEventHandler(ZontOstrivnyyTyp1_TextBox_p3_LostFocus);
			((UIElement)textBox_p3_ZontOstrivnyyTyp1).PreviewMouseLeftButtonUp += new MouseButtonEventHandler(ZontOstrivnyyTyp1_TextBox_p3_PreviewMouseLeftButtonUp);
			((UIElement)textBox_p3_ZontOstrivnyyTyp1).GotFocus += new RoutedEventHandler(TextBox_GotFocus);
			break;
		case 48:
			textBox_f3_ZontOstrivnyyTyp1 = (TextBox)target;
			((UIElement)textBox_f3_ZontOstrivnyyTyp1).LostFocus += new RoutedEventHandler(ZontOstrivnyyTyp1_TextBox_Base_LostFocus);
			((UIElement)textBox_f3_ZontOstrivnyyTyp1).PreviewMouseLeftButtonUp += new MouseButtonEventHandler(ZontOstrivnyyTyp1_TextBox_f3_PreviewMouseLeftButtonUp);
			((UIElement)textBox_f3_ZontOstrivnyyTyp1).GotFocus += new RoutedEventHandler(TextBox_GotFocus);
			break;
		case 49:
			textBox_g3_ZontOstrivnyyTyp1 = (TextBox)target;
			((UIElement)textBox_g3_ZontOstrivnyyTyp1).LostFocus += new RoutedEventHandler(ZontOstrivnyyTyp1_TextBox_Base_LostFocus);
			((UIElement)textBox_g3_ZontOstrivnyyTyp1).PreviewMouseLeftButtonUp += new MouseButtonEventHandler(ZontOstrivnyyTyp1_TextBox_g3_PreviewMouseLeftButtonUp);
			((UIElement)textBox_g3_ZontOstrivnyyTyp1).GotFocus += new RoutedEventHandler(TextBox_GotFocus);
			break;
		case 50:
			comboBox_Vyhid3_ZontOstrivnyyTyp1 = (ComboBox)target;
			break;
		case 51:
			comboBox_typVyhid3_ZontOstrivnyyTyp1 = (ComboBox)target;
			break;
		case 52:
			comboBox_profilType3_ZontOstrivnyyTyp1 = (ComboBox)target;
			break;
		case 53:
			label_d3_ZontOstrivnyyTyp1 = (Label)target;
			break;
		case 54:
			label_p3_ZontOstrivnyyTyp1 = (Label)target;
			break;
		case 55:
			label_f3_ZontOstrivnyyTyp1 = (Label)target;
			break;
		case 56:
			label_g3_ZontOstrivnyyTyp1 = (Label)target;
			break;
		case 57:
			label_a3_ZontOstrivnyyTyp1 = (Label)target;
			break;
		case 58:
			label_b3_ZontOstrivnyyTyp1 = (Label)target;
			break;
		case 59:
			label_typVyhid3_ZontOstrivnyyTyp1 = (Label)target;
			break;
		case 60:
			label_Vyhid3_ZontOstrivnyyTyp1 = (Label)target;
			break;
		case 61:
			label_profilType3_ZontOstrivnyyTyp1 = (Label)target;
			break;
		default:
			_contentLoaded = true;
			break;
		}
	}
}
