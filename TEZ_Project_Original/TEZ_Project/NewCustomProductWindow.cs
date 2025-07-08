using System;
using System.CodeDom.Compiler;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Markup;
using TEZ_Project.Common.Data;
using TEZ_Project.Common.Data.Entities;
using TEZ_Project.Common.Helpers;
using log4net;

namespace TEZ_Project;

public class NewCustomProductWindow : Window, IComponentConnector
{
	private const int MaxCustomProductMaterial = 40;

	private static readonly ILog log = LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);

	internal TextBox textBox_NewCustomProduct_Name;

	internal Button newCustomProductSaveButton;

	internal StackPanel stackPanel;

	internal Grid customProductMaterialRow_Row1;

	internal TextBox textBox_customProductMaterialSpending_Row1;

	internal ComboBox comboBox_customProductMaterial_Row1;

	internal Button customProductDeleteButton_Row1;

	internal Grid customProductMaterialRow_Row2;

	internal TextBox textBox_customProductMaterialSpending_Row2;

	internal ComboBox comboBox_customProductMaterial_Row2;

	internal Button customProductDeleteButton_Row2;

	internal Grid customProductMaterialRow_Row3;

	internal TextBox textBox_customProductMaterialSpending_Row3;

	internal ComboBox comboBox_customProductMaterial_Row3;

	internal Button customProductDeleteButton_Row3;

	internal Grid customProductMaterialRow_Row4;

	internal TextBox textBox_customProductMaterialSpending_Row4;

	internal ComboBox comboBox_customProductMaterial_Row4;

	internal Button customProductDeleteButton_Row4;

	internal Grid customProductMaterialRow_Row5;

	internal TextBox textBox_customProductMaterialSpending_Row5;

	internal ComboBox comboBox_customProductMaterial_Row5;

	internal Button customProductDeleteButton_Row5;

	internal Grid customProductMaterialRow_Row6;

	internal TextBox textBox_customProductMaterialSpending_Row6;

	internal ComboBox comboBox_customProductMaterial_Row6;

	internal Button customProductDeleteButton_Row6;

	internal Grid customProductMaterialRow_Row7;

	internal TextBox textBox_customProductMaterialSpending_Row7;

	internal ComboBox comboBox_customProductMaterial_Row7;

	internal Button customProductDeleteButton_Row7;

	internal Grid customProductMaterialRow_Row8;

	internal TextBox textBox_customProductMaterialSpending_Row8;

	internal ComboBox comboBox_customProductMaterial_Row8;

	internal Button customProductDeleteButton_Row8;

	internal Grid customProductMaterialRow_Row9;

	internal TextBox textBox_customProductMaterialSpending_Row9;

	internal ComboBox comboBox_customProductMaterial_Row9;

	internal Button customProductDeleteButton_Row9;

	internal Grid customProductMaterialRow_Row10;

	internal TextBox textBox_customProductMaterialSpending_Row10;

	internal ComboBox comboBox_customProductMaterial_Row10;

	internal Button customProductDeleteButton_Row10;

	internal Grid customProductMaterialRow_Row11;

	internal TextBox textBox_customProductMaterialSpending_Row11;

	internal ComboBox comboBox_customProductMaterial_Row11;

	internal Button customProductDeleteButton_Row11;

	internal Grid customProductMaterialRow_Row12;

	internal TextBox textBox_customProductMaterialSpending_Row12;

	internal ComboBox comboBox_customProductMaterial_Row12;

	internal Button customProductDeleteButton_Row12;

	internal Grid customProductMaterialRow_Row13;

	internal TextBox textBox_customProductMaterialSpending_Row13;

	internal ComboBox comboBox_customProductMaterial_Row13;

	internal Button customProductDeleteButton_Row13;

	internal Grid customProductMaterialRow_Row14;

	internal TextBox textBox_customProductMaterialSpending_Row14;

	internal ComboBox comboBox_customProductMaterial_Row14;

	internal Button customProductDeleteButton_Row14;

	internal Grid customProductMaterialRow_Row15;

	internal TextBox textBox_customProductMaterialSpending_Row15;

	internal ComboBox comboBox_customProductMaterial_Row15;

	internal Button customProductDeleteButton_Row15;

	internal Grid customProductMaterialRow_Row16;

	internal TextBox textBox_customProductMaterialSpending_Row16;

	internal ComboBox comboBox_customProductMaterial_Row16;

	internal Button customProductDeleteButton_Row16;

	internal Grid customProductMaterialRow_Row17;

	internal TextBox textBox_customProductMaterialSpending_Row17;

	internal ComboBox comboBox_customProductMaterial_Row17;

	internal Button customProductDeleteButton_Row17;

	internal Grid customProductMaterialRow_Row18;

	internal TextBox textBox_customProductMaterialSpending_Row18;

	internal ComboBox comboBox_customProductMaterial_Row18;

	internal Button customProductDeleteButton_Row18;

	internal Grid customProductMaterialRow_Row19;

	internal TextBox textBox_customProductMaterialSpending_Row19;

	internal ComboBox comboBox_customProductMaterial_Row19;

	internal Button customProductDeleteButton_Row19;

	internal Grid customProductMaterialRow_Row20;

	internal TextBox textBox_customProductMaterialSpending_Row20;

	internal ComboBox comboBox_customProductMaterial_Row20;

	internal Button customProductDeleteButton_Row20;

	internal Grid customProductMaterialRow_Row21;

	internal TextBox textBox_customProductMaterialSpending_Row21;

	internal ComboBox comboBox_customProductMaterial_Row21;

	internal Button customProductDeleteButton_Row21;

	internal Grid customProductMaterialRow_Row22;

	internal TextBox textBox_customProductMaterialSpending_Row22;

	internal ComboBox comboBox_customProductMaterial_Row22;

	internal Button customProductDeleteButton_Row22;

	internal Grid customProductMaterialRow_Row23;

	internal TextBox textBox_customProductMaterialSpending_Row23;

	internal ComboBox comboBox_customProductMaterial_Row23;

	internal Button customProductDeleteButton_Row23;

	internal Grid customProductMaterialRow_Row24;

	internal TextBox textBox_customProductMaterialSpending_Row24;

	internal ComboBox comboBox_customProductMaterial_Row24;

	internal Button customProductDeleteButton_Row24;

	internal Grid customProductMaterialRow_Row25;

	internal TextBox textBox_customProductMaterialSpending_Row25;

	internal ComboBox comboBox_customProductMaterial_Row25;

	internal Button customProductDeleteButton_Row25;

	internal Grid customProductMaterialRow_Row26;

	internal TextBox textBox_customProductMaterialSpending_Row26;

	internal ComboBox comboBox_customProductMaterial_Row26;

	internal Button customProductDeleteButton_Row26;

	internal Grid customProductMaterialRow_Row27;

	internal TextBox textBox_customProductMaterialSpending_Row27;

	internal ComboBox comboBox_customProductMaterial_Row27;

	internal Button customProductDeleteButton_Row27;

	internal Grid customProductMaterialRow_Row28;

	internal TextBox textBox_customProductMaterialSpending_Row28;

	internal ComboBox comboBox_customProductMaterial_Row28;

	internal Button customProductDeleteButton_Row28;

	internal Grid customProductMaterialRow_Row29;

	internal TextBox textBox_customProductMaterialSpending_Row29;

	internal ComboBox comboBox_customProductMaterial_Row29;

	internal Button customProductDeleteButton_Row29;

	internal Grid customProductMaterialRow_Row30;

	internal TextBox textBox_customProductMaterialSpending_Row30;

	internal ComboBox comboBox_customProductMaterial_Row30;

	internal Button customProductDeleteButton_Row30;

	internal Grid customProductMaterialRow_Row31;

	internal TextBox textBox_customProductMaterialSpending_Row31;

	internal ComboBox comboBox_customProductMaterial_Row31;

	internal Button customProductDeleteButton_Row31;

	internal Grid customProductMaterialRow_Row32;

	internal TextBox textBox_customProductMaterialSpending_Row32;

	internal ComboBox comboBox_customProductMaterial_Row32;

	internal Button customProductDeleteButton_Row32;

	internal Grid customProductMaterialRow_Row33;

	internal TextBox textBox_customProductMaterialSpending_Row33;

	internal ComboBox comboBox_customProductMaterial_Row33;

	internal Button customProductDeleteButton_Row33;

	internal Grid customProductMaterialRow_Row34;

	internal TextBox textBox_customProductMaterialSpending_Row34;

	internal ComboBox comboBox_customProductMaterial_Row34;

	internal Button customProductDeleteButton_Row34;

	internal Grid customProductMaterialRow_Row35;

	internal TextBox textBox_customProductMaterialSpending_Row35;

	internal ComboBox comboBox_customProductMaterial_Row35;

	internal Button customProductDeleteButton_Row35;

	internal Grid customProductMaterialRow_Row36;

	internal TextBox textBox_customProductMaterialSpending_Row36;

	internal ComboBox comboBox_customProductMaterial_Row36;

	internal Button customProductDeleteButton_Row36;

	internal Grid customProductMaterialRow_Row37;

	internal TextBox textBox_customProductMaterialSpending_Row37;

	internal ComboBox comboBox_customProductMaterial_Row37;

	internal Button customProductDeleteButton_Row37;

	internal Grid customProductMaterialRow_Row38;

	internal TextBox textBox_customProductMaterialSpending_Row38;

	internal ComboBox comboBox_customProductMaterial_Row38;

	internal Button customProductDeleteButton_Row38;

	internal Grid customProductMaterialRow_Row39;

	internal TextBox textBox_customProductMaterialSpending_Row39;

	internal ComboBox comboBox_customProductMaterial_Row39;

	internal Button customProductDeleteButton_Row39;

	internal Grid customProductMaterialRow_Row40;

	internal TextBox textBox_customProductMaterialSpending_Row40;

	internal ComboBox comboBox_customProductMaterial_Row40;

	internal Button customProductDeleteButton_Row40;

	private bool _contentLoaded;

	public string SelectedCustomProductKey { get; set; }

	private ICollection<string> CustomProductNames { get; set; }

	private ICollection<BaseNameDto> ConstsInfo { get; set; }

	public User CurentUser { get; set; }

	public bool RefreshCustomProductGrid { get; set; }

	public NewCustomProductWindow()
	{
		InitializeComponent();
		RefreshCustomProductGrid = false;
	}

	public void LoadCustomProductsNameAndCosts()
	{
		try
		{
			CustomProductNames = CustomProductHelper.GetCustomProductNames();
			ConstsInfo = CustomProductHelper.GetConstsBaseInfo();
			SetMaterialComboBoxes();
			if (!string.IsNullOrEmpty(SelectedCustomProductKey))
			{
				CustomProductNames.Remove(SelectedCustomProductKey);
				((ContentControl)newCustomProductSaveButton).Content = "Редагувати";
				((Window)this).Title = "Редагування нестандартного виробу";
				SetDataFromCurrentCustomProduct(SelectedCustomProductKey);
			}
		}
		catch (Exception exception)
		{
			((Window)this).Close();
			log.Error("Database error", exception);
		}
	}

	private void NewCustomProductSaveButton_Click(object sender, RoutedEventArgs e)
	{
		//IL_0175: Unknown result type (might be due to invalid IL or missing references)
		//IL_0195: Unknown result type (might be due to invalid IL or missing references)
		if (!IsNewCustomProductNameValid())
		{
			return;
		}
		string text = "comboBox_customProductMaterial_Row";
		string text2 = "textBox_customProductMaterialSpending_Row";
		List<int> list = new List<int>();
		List<double> list2 = new List<double>();
		string text3 = textBox_NewCustomProduct_Name.Text;
		ComboBox materialComboBox = default(ComboBox);
		for (int i = 0; i < 40; i++)
		{
			int num = i + 1;
			ref ComboBox reference = ref materialComboBox;
			object obj = ((FrameworkElement)this).FindName(text + num);
			reference = (ComboBox)((obj is ComboBox) ? obj : null);
			object obj2 = ((FrameworkElement)this).FindName(text2 + num);
			TextBox val = (TextBox)((obj2 is TextBox) ? obj2 : null);
			ComboBox obj3 = materialComboBox;
			if (!string.IsNullOrEmpty((obj3 != null) ? obj3.Text : null))
			{
				int num2 = Enumerable.FirstOrDefault<int>(Enumerable.Select<BaseNameDto, int>(Enumerable.Where<BaseNameDto>((IEnumerable<BaseNameDto>)ConstsInfo, (Func<BaseNameDto, bool>)((BaseNameDto x) => x.Name == materialComboBox.Text)), (Func<BaseNameDto, int>)((BaseNameDto x) => x.Id)));
				if (num2 != 0)
				{
					list.Add(num2);
				}
			}
			if (!string.IsNullOrEmpty((val != null) ? val.Text : null))
			{
				list2.Add(Convert.ToDouble(val.Text.Replace(",", ".")));
			}
		}
		if (list.Count != list2.Count)
		{
			MessageBox.Show("Введіть розхід для кожного з вибраних матеріалів!");
			return;
		}
		if (list.Count == 0)
		{
			MessageBox.Show("Виберіть хоча б один матеріал!");
			return;
		}
		if (((ContentControl)newCustomProductSaveButton).Content.ToString() == "Зберегти")
		{
			CustomProductHelper.AddNewCustomProduct(text3, CurentUser.Login, list.ToArray(), list2.ToArray());
		}
		else
		{
			CustomProductHelper.UpdateCustomProduct(SelectedCustomProductKey, text3, CurentUser.Login, list.ToArray(), list2.ToArray());
		}
		((Window)this).Close();
		RefreshCustomProductGrid = true;
	}

	private void CustomProductDeleteButton_Row_Click(object sender, RoutedEventArgs e)
	{
		Button val = (Button)((sender is Button) ? sender : null);
		if (val != null)
		{
			TextBox customProductMaterialSpendingTextBoxByRowElement = GetCustomProductMaterialSpendingTextBoxByRowElement((FrameworkElement)(object)val);
			ComboBox customProductMaterialComboBoxByRowElement = GetCustomProductMaterialComboBoxByRowElement((FrameworkElement)(object)val);
			customProductMaterialSpendingTextBoxByRowElement.Text = string.Empty;
			customProductMaterialComboBoxByRowElement.Text = string.Empty;
		}
	}

	private void TextBox_CustomProductMaterialSpending_LostFocus(object sender, RoutedEventArgs e)
	{
		//IL_005b: Unknown result type (might be due to invalid IL or missing references)
		//IL_008b: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b7: Unknown result type (might be due to invalid IL or missing references)
		TextBox val = (TextBox)((sender is TextBox) ? sender : null);
		if (string.IsNullOrEmpty((val != null) ? val.Text : null))
		{
			return;
		}
		if (!double.TryParse(val.Text.Replace(",", "."), out var result))
		{
			val.Text = string.Empty;
			MessageBox.Show("Це поле повинне містити число!");
			return;
		}
		if (result <= 0.0)
		{
			val.Text = string.Empty;
			MessageBox.Show("Число повинно бути додатнім!");
			return;
		}
		ComboBox customProductMaterialComboBoxByRowElement = GetCustomProductMaterialComboBoxByRowElement((FrameworkElement)(object)val);
		if (customProductMaterialComboBoxByRowElement != null && ((Selector)customProductMaterialComboBoxByRowElement).SelectedItem == null)
		{
			MessageBox.Show("Виберіть матеріал!");
			val.Text = string.Empty;
		}
	}

	private void ComboBox_CustomProductMaterial_SelectionChanged(object sender, SelectionChangedEventArgs e)
	{
		ComboBox val = (ComboBox)((sender is ComboBox) ? sender : null);
		if (((Selector)val).SelectedItem != null)
		{
			TextBox customProductMaterialSpendingTextBoxByRowElement = GetCustomProductMaterialSpendingTextBoxByRowElement((FrameworkElement)(object)val);
			if (customProductMaterialSpendingTextBoxByRowElement != null && string.IsNullOrEmpty(customProductMaterialSpendingTextBoxByRowElement.Text))
			{
				customProductMaterialSpendingTextBoxByRowElement.Text = "1";
			}
		}
	}

	private void TextBox_NewCustomProduct_Name_LostFocus(object sender, RoutedEventArgs e)
	{
		IsNewCustomProductNameValid(validateEmptyName: false);
	}

	private void SetDataFromCurrentCustomProduct(string customProductName)
	{
		textBox_NewCustomProduct_Name.Text = customProductName;
		string text = "comboBox_customProductMaterial_Row";
		string text2 = "textBox_customProductMaterialSpending_Row";
		(string[], double[]) customProductMaterialNamesAndSpendings = CustomProductHelper.GetCustomProductMaterialNamesAndSpendings(customProductName);
		string[] item = customProductMaterialNamesAndSpendings.Item1;
		double[] item2 = customProductMaterialNamesAndSpendings.Item2;
		for (int i = 0; i < item.Length; i++)
		{
			int num = i + 1;
			object obj = ((FrameworkElement)this).FindName(text + num);
			ComboBox val = (ComboBox)((obj is ComboBox) ? obj : null);
			object obj2 = ((FrameworkElement)this).FindName(text2 + num);
			TextBox val2 = (TextBox)((obj2 is TextBox) ? obj2 : null);
			foreach (object item3 in (IEnumerable)((ItemsControl)val).Items)
			{
				if (item3.ToString() == item[i])
				{
					((Selector)val).SelectedItem = item3;
					val2.Text = ((i < item2.Length) ? item2[i].ToString() : "0");
					break;
				}
			}
		}
	}

	private void SetMaterialComboBoxes()
	{
		string text = "comboBox_customProductMaterial_Row";
		List<string> list = Enumerable.ToList<string>((IEnumerable<string>)Enumerable.OrderBy<string, string>(Enumerable.Select<BaseNameDto, string>((IEnumerable<BaseNameDto>)ConstsInfo, (Func<BaseNameDto, string>)((BaseNameDto x) => x.Name)), (Func<string, string>)((string x) => x)));
		ComboBox materialComboBox = default(ComboBox);
		for (int i = 0; i < 40; i++)
		{
			ref ComboBox reference = ref materialComboBox;
			object obj = ((FrameworkElement)this).FindName(text + (i + 1));
			reference = (ComboBox)((obj is ComboBox) ? obj : null);
			if (materialComboBox != null)
			{
				list.ForEach(delegate(string n)
				{
					((ItemsControl)materialComboBox).Items.Add((object)n);
				});
			}
		}
	}

	private ComboBox GetCustomProductMaterialComboBoxByRowElement(FrameworkElement element)
	{
		string text = Enumerable.LastOrDefault<string>((IEnumerable<string>)element.Name.Split(new char[1] { '_' }));
		object obj = ((FrameworkElement)this).FindName("comboBox_customProductMaterial_" + text);
		return (ComboBox)((obj is ComboBox) ? obj : null);
	}

	private TextBox GetCustomProductMaterialSpendingTextBoxByRowElement(FrameworkElement element)
	{
		string text = Enumerable.LastOrDefault<string>((IEnumerable<string>)element.Name.Split(new char[1] { '_' }));
		object obj = ((FrameworkElement)this).FindName("textBox_customProductMaterialSpending_" + text);
		return (TextBox)((obj is TextBox) ? obj : null);
	}

	private bool IsNewCustomProductNameValid(bool validateEmptyName = true)
	{
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_004b: Unknown result type (might be due to invalid IL or missing references)
		if (validateEmptyName && string.IsNullOrEmpty(textBox_NewCustomProduct_Name.Text))
		{
			MessageBox.Show("Вкажіть назву виробу!");
			return false;
		}
		if (CustomProductNames.Contains(textBox_NewCustomProduct_Name.Text))
		{
			MessageBox.Show("Вже існує нестандартний виріб з такою назвую. Змініть назву!");
			textBox_NewCustomProduct_Name.Text = string.Empty;
			return false;
		}
		return true;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	public void InitializeComponent()
	{
		if (!_contentLoaded)
		{
			_contentLoaded = true;
			Uri uri = new Uri("/TEZ_Project;component/customproductwindows/newcustomproductwingow.xaml", UriKind.Relative);
			Application.LoadComponent((object)this, uri);
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	[EditorBrowsable(EditorBrowsableState.Never)]
	void IComponentConnector.Connect(int connectionId, object target)
	{
		//IL_02a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_02aa: Expected O, but got Unknown
		//IL_02b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_02c1: Expected O, but got Unknown
		//IL_02c9: Unknown result type (might be due to invalid IL or missing references)
		//IL_02d3: Expected O, but got Unknown
		//IL_02e0: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ea: Expected O, but got Unknown
		//IL_02f2: Unknown result type (might be due to invalid IL or missing references)
		//IL_02fc: Expected O, but got Unknown
		//IL_0303: Unknown result type (might be due to invalid IL or missing references)
		//IL_030d: Expected O, but got Unknown
		//IL_0314: Unknown result type (might be due to invalid IL or missing references)
		//IL_031e: Expected O, but got Unknown
		//IL_032b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0335: Expected O, but got Unknown
		//IL_033d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0347: Expected O, but got Unknown
		//IL_0354: Unknown result type (might be due to invalid IL or missing references)
		//IL_035e: Expected O, but got Unknown
		//IL_0366: Unknown result type (might be due to invalid IL or missing references)
		//IL_0370: Expected O, but got Unknown
		//IL_037d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0387: Expected O, but got Unknown
		//IL_038f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0399: Expected O, but got Unknown
		//IL_03a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_03aa: Expected O, but got Unknown
		//IL_03b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_03c1: Expected O, but got Unknown
		//IL_03c9: Unknown result type (might be due to invalid IL or missing references)
		//IL_03d3: Expected O, but got Unknown
		//IL_03e0: Unknown result type (might be due to invalid IL or missing references)
		//IL_03ea: Expected O, but got Unknown
		//IL_03f2: Unknown result type (might be due to invalid IL or missing references)
		//IL_03fc: Expected O, but got Unknown
		//IL_0409: Unknown result type (might be due to invalid IL or missing references)
		//IL_0413: Expected O, but got Unknown
		//IL_041b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0425: Expected O, but got Unknown
		//IL_042c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0436: Expected O, but got Unknown
		//IL_0443: Unknown result type (might be due to invalid IL or missing references)
		//IL_044d: Expected O, but got Unknown
		//IL_0455: Unknown result type (might be due to invalid IL or missing references)
		//IL_045f: Expected O, but got Unknown
		//IL_046c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0476: Expected O, but got Unknown
		//IL_047e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0488: Expected O, but got Unknown
		//IL_0495: Unknown result type (might be due to invalid IL or missing references)
		//IL_049f: Expected O, but got Unknown
		//IL_04a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_04b1: Expected O, but got Unknown
		//IL_04b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_04c2: Expected O, but got Unknown
		//IL_04cf: Unknown result type (might be due to invalid IL or missing references)
		//IL_04d9: Expected O, but got Unknown
		//IL_04e1: Unknown result type (might be due to invalid IL or missing references)
		//IL_04eb: Expected O, but got Unknown
		//IL_04f8: Unknown result type (might be due to invalid IL or missing references)
		//IL_0502: Expected O, but got Unknown
		//IL_050a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0514: Expected O, but got Unknown
		//IL_0521: Unknown result type (might be due to invalid IL or missing references)
		//IL_052b: Expected O, but got Unknown
		//IL_0533: Unknown result type (might be due to invalid IL or missing references)
		//IL_053d: Expected O, but got Unknown
		//IL_0544: Unknown result type (might be due to invalid IL or missing references)
		//IL_054e: Expected O, but got Unknown
		//IL_055b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0565: Expected O, but got Unknown
		//IL_056d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0577: Expected O, but got Unknown
		//IL_0584: Unknown result type (might be due to invalid IL or missing references)
		//IL_058e: Expected O, but got Unknown
		//IL_0596: Unknown result type (might be due to invalid IL or missing references)
		//IL_05a0: Expected O, but got Unknown
		//IL_05ad: Unknown result type (might be due to invalid IL or missing references)
		//IL_05b7: Expected O, but got Unknown
		//IL_05bf: Unknown result type (might be due to invalid IL or missing references)
		//IL_05c9: Expected O, but got Unknown
		//IL_05d0: Unknown result type (might be due to invalid IL or missing references)
		//IL_05da: Expected O, but got Unknown
		//IL_05e7: Unknown result type (might be due to invalid IL or missing references)
		//IL_05f1: Expected O, but got Unknown
		//IL_05f9: Unknown result type (might be due to invalid IL or missing references)
		//IL_0603: Expected O, but got Unknown
		//IL_0610: Unknown result type (might be due to invalid IL or missing references)
		//IL_061a: Expected O, but got Unknown
		//IL_0622: Unknown result type (might be due to invalid IL or missing references)
		//IL_062c: Expected O, but got Unknown
		//IL_0639: Unknown result type (might be due to invalid IL or missing references)
		//IL_0643: Expected O, but got Unknown
		//IL_064b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0655: Expected O, but got Unknown
		//IL_065c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0666: Expected O, but got Unknown
		//IL_0673: Unknown result type (might be due to invalid IL or missing references)
		//IL_067d: Expected O, but got Unknown
		//IL_0685: Unknown result type (might be due to invalid IL or missing references)
		//IL_068f: Expected O, but got Unknown
		//IL_069c: Unknown result type (might be due to invalid IL or missing references)
		//IL_06a6: Expected O, but got Unknown
		//IL_06ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_06b8: Expected O, but got Unknown
		//IL_06c5: Unknown result type (might be due to invalid IL or missing references)
		//IL_06cf: Expected O, but got Unknown
		//IL_06d7: Unknown result type (might be due to invalid IL or missing references)
		//IL_06e1: Expected O, but got Unknown
		//IL_06e8: Unknown result type (might be due to invalid IL or missing references)
		//IL_06f2: Expected O, but got Unknown
		//IL_06ff: Unknown result type (might be due to invalid IL or missing references)
		//IL_0709: Expected O, but got Unknown
		//IL_0711: Unknown result type (might be due to invalid IL or missing references)
		//IL_071b: Expected O, but got Unknown
		//IL_0728: Unknown result type (might be due to invalid IL or missing references)
		//IL_0732: Expected O, but got Unknown
		//IL_073a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0744: Expected O, but got Unknown
		//IL_0751: Unknown result type (might be due to invalid IL or missing references)
		//IL_075b: Expected O, but got Unknown
		//IL_0763: Unknown result type (might be due to invalid IL or missing references)
		//IL_076d: Expected O, but got Unknown
		//IL_0774: Unknown result type (might be due to invalid IL or missing references)
		//IL_077e: Expected O, but got Unknown
		//IL_078b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0795: Expected O, but got Unknown
		//IL_079d: Unknown result type (might be due to invalid IL or missing references)
		//IL_07a7: Expected O, but got Unknown
		//IL_07b4: Unknown result type (might be due to invalid IL or missing references)
		//IL_07be: Expected O, but got Unknown
		//IL_07c6: Unknown result type (might be due to invalid IL or missing references)
		//IL_07d0: Expected O, but got Unknown
		//IL_07dd: Unknown result type (might be due to invalid IL or missing references)
		//IL_07e7: Expected O, but got Unknown
		//IL_07ef: Unknown result type (might be due to invalid IL or missing references)
		//IL_07f9: Expected O, but got Unknown
		//IL_0800: Unknown result type (might be due to invalid IL or missing references)
		//IL_080a: Expected O, but got Unknown
		//IL_0817: Unknown result type (might be due to invalid IL or missing references)
		//IL_0821: Expected O, but got Unknown
		//IL_0829: Unknown result type (might be due to invalid IL or missing references)
		//IL_0833: Expected O, but got Unknown
		//IL_0840: Unknown result type (might be due to invalid IL or missing references)
		//IL_084a: Expected O, but got Unknown
		//IL_0852: Unknown result type (might be due to invalid IL or missing references)
		//IL_085c: Expected O, but got Unknown
		//IL_0869: Unknown result type (might be due to invalid IL or missing references)
		//IL_0873: Expected O, but got Unknown
		//IL_087b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0885: Expected O, but got Unknown
		//IL_088c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0896: Expected O, but got Unknown
		//IL_08a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_08ad: Expected O, but got Unknown
		//IL_08b5: Unknown result type (might be due to invalid IL or missing references)
		//IL_08bf: Expected O, but got Unknown
		//IL_08cc: Unknown result type (might be due to invalid IL or missing references)
		//IL_08d6: Expected O, but got Unknown
		//IL_08de: Unknown result type (might be due to invalid IL or missing references)
		//IL_08e8: Expected O, but got Unknown
		//IL_08f5: Unknown result type (might be due to invalid IL or missing references)
		//IL_08ff: Expected O, but got Unknown
		//IL_0907: Unknown result type (might be due to invalid IL or missing references)
		//IL_0911: Expected O, but got Unknown
		//IL_0918: Unknown result type (might be due to invalid IL or missing references)
		//IL_0922: Expected O, but got Unknown
		//IL_092f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0939: Expected O, but got Unknown
		//IL_0941: Unknown result type (might be due to invalid IL or missing references)
		//IL_094b: Expected O, but got Unknown
		//IL_0958: Unknown result type (might be due to invalid IL or missing references)
		//IL_0962: Expected O, but got Unknown
		//IL_096a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0974: Expected O, but got Unknown
		//IL_0981: Unknown result type (might be due to invalid IL or missing references)
		//IL_098b: Expected O, but got Unknown
		//IL_0993: Unknown result type (might be due to invalid IL or missing references)
		//IL_099d: Expected O, but got Unknown
		//IL_09a4: Unknown result type (might be due to invalid IL or missing references)
		//IL_09ae: Expected O, but got Unknown
		//IL_09bb: Unknown result type (might be due to invalid IL or missing references)
		//IL_09c5: Expected O, but got Unknown
		//IL_09cd: Unknown result type (might be due to invalid IL or missing references)
		//IL_09d7: Expected O, but got Unknown
		//IL_09e4: Unknown result type (might be due to invalid IL or missing references)
		//IL_09ee: Expected O, but got Unknown
		//IL_09f6: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a00: Expected O, but got Unknown
		//IL_0a0d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a17: Expected O, but got Unknown
		//IL_0a1f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a29: Expected O, but got Unknown
		//IL_0a30: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a3a: Expected O, but got Unknown
		//IL_0a47: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a51: Expected O, but got Unknown
		//IL_0a59: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a63: Expected O, but got Unknown
		//IL_0a70: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a7a: Expected O, but got Unknown
		//IL_0a82: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a8c: Expected O, but got Unknown
		//IL_0a99: Unknown result type (might be due to invalid IL or missing references)
		//IL_0aa3: Expected O, but got Unknown
		//IL_0aab: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ab5: Expected O, but got Unknown
		//IL_0abc: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ac6: Expected O, but got Unknown
		//IL_0ad3: Unknown result type (might be due to invalid IL or missing references)
		//IL_0add: Expected O, but got Unknown
		//IL_0ae5: Unknown result type (might be due to invalid IL or missing references)
		//IL_0aef: Expected O, but got Unknown
		//IL_0afc: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b06: Expected O, but got Unknown
		//IL_0b0e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b18: Expected O, but got Unknown
		//IL_0b25: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b2f: Expected O, but got Unknown
		//IL_0b37: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b41: Expected O, but got Unknown
		//IL_0b48: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b52: Expected O, but got Unknown
		//IL_0b5f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b69: Expected O, but got Unknown
		//IL_0b71: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b7b: Expected O, but got Unknown
		//IL_0b88: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b92: Expected O, but got Unknown
		//IL_0b9a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ba4: Expected O, but got Unknown
		//IL_0bb1: Unknown result type (might be due to invalid IL or missing references)
		//IL_0bbb: Expected O, but got Unknown
		//IL_0bc3: Unknown result type (might be due to invalid IL or missing references)
		//IL_0bcd: Expected O, but got Unknown
		//IL_0bd4: Unknown result type (might be due to invalid IL or missing references)
		//IL_0bde: Expected O, but got Unknown
		//IL_0beb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0bf5: Expected O, but got Unknown
		//IL_0bfd: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c07: Expected O, but got Unknown
		//IL_0c14: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c1e: Expected O, but got Unknown
		//IL_0c26: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c30: Expected O, but got Unknown
		//IL_0c3d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c47: Expected O, but got Unknown
		//IL_0c4f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c59: Expected O, but got Unknown
		//IL_0c60: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c6a: Expected O, but got Unknown
		//IL_0c77: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c81: Expected O, but got Unknown
		//IL_0c89: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c93: Expected O, but got Unknown
		//IL_0ca0: Unknown result type (might be due to invalid IL or missing references)
		//IL_0caa: Expected O, but got Unknown
		//IL_0cb2: Unknown result type (might be due to invalid IL or missing references)
		//IL_0cbc: Expected O, but got Unknown
		//IL_0cc9: Unknown result type (might be due to invalid IL or missing references)
		//IL_0cd3: Expected O, but got Unknown
		//IL_0cdb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ce5: Expected O, but got Unknown
		//IL_0cec: Unknown result type (might be due to invalid IL or missing references)
		//IL_0cf6: Expected O, but got Unknown
		//IL_0d03: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d0d: Expected O, but got Unknown
		//IL_0d15: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d1f: Expected O, but got Unknown
		//IL_0d2c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d36: Expected O, but got Unknown
		//IL_0d3e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d48: Expected O, but got Unknown
		//IL_0d55: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d5f: Expected O, but got Unknown
		//IL_0d67: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d71: Expected O, but got Unknown
		//IL_0d78: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d82: Expected O, but got Unknown
		//IL_0d8f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d99: Expected O, but got Unknown
		//IL_0da1: Unknown result type (might be due to invalid IL or missing references)
		//IL_0dab: Expected O, but got Unknown
		//IL_0db8: Unknown result type (might be due to invalid IL or missing references)
		//IL_0dc2: Expected O, but got Unknown
		//IL_0dca: Unknown result type (might be due to invalid IL or missing references)
		//IL_0dd4: Expected O, but got Unknown
		//IL_0de1: Unknown result type (might be due to invalid IL or missing references)
		//IL_0deb: Expected O, but got Unknown
		//IL_0df3: Unknown result type (might be due to invalid IL or missing references)
		//IL_0dfd: Expected O, but got Unknown
		//IL_0e04: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e0e: Expected O, but got Unknown
		//IL_0e1b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e25: Expected O, but got Unknown
		//IL_0e2d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e37: Expected O, but got Unknown
		//IL_0e44: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e4e: Expected O, but got Unknown
		//IL_0e56: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e60: Expected O, but got Unknown
		//IL_0e6d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e77: Expected O, but got Unknown
		//IL_0e7f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e89: Expected O, but got Unknown
		//IL_0e90: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e9a: Expected O, but got Unknown
		//IL_0ea7: Unknown result type (might be due to invalid IL or missing references)
		//IL_0eb1: Expected O, but got Unknown
		//IL_0eb9: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ec3: Expected O, but got Unknown
		//IL_0ed0: Unknown result type (might be due to invalid IL or missing references)
		//IL_0eda: Expected O, but got Unknown
		//IL_0ee2: Unknown result type (might be due to invalid IL or missing references)
		//IL_0eec: Expected O, but got Unknown
		//IL_0ef9: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f03: Expected O, but got Unknown
		//IL_0f0b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f15: Expected O, but got Unknown
		//IL_0f1c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f26: Expected O, but got Unknown
		//IL_0f33: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f3d: Expected O, but got Unknown
		//IL_0f45: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f4f: Expected O, but got Unknown
		//IL_0f5c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f66: Expected O, but got Unknown
		//IL_0f6e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f78: Expected O, but got Unknown
		//IL_0f85: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f8f: Expected O, but got Unknown
		//IL_0f97: Unknown result type (might be due to invalid IL or missing references)
		//IL_0fa1: Expected O, but got Unknown
		//IL_0fa8: Unknown result type (might be due to invalid IL or missing references)
		//IL_0fb2: Expected O, but got Unknown
		//IL_0fbf: Unknown result type (might be due to invalid IL or missing references)
		//IL_0fc9: Expected O, but got Unknown
		//IL_0fd1: Unknown result type (might be due to invalid IL or missing references)
		//IL_0fdb: Expected O, but got Unknown
		//IL_0fe8: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ff2: Expected O, but got Unknown
		//IL_0ffa: Unknown result type (might be due to invalid IL or missing references)
		//IL_1004: Expected O, but got Unknown
		//IL_1011: Unknown result type (might be due to invalid IL or missing references)
		//IL_101b: Expected O, but got Unknown
		//IL_1023: Unknown result type (might be due to invalid IL or missing references)
		//IL_102d: Expected O, but got Unknown
		//IL_1034: Unknown result type (might be due to invalid IL or missing references)
		//IL_103e: Expected O, but got Unknown
		//IL_104b: Unknown result type (might be due to invalid IL or missing references)
		//IL_1055: Expected O, but got Unknown
		//IL_105d: Unknown result type (might be due to invalid IL or missing references)
		//IL_1067: Expected O, but got Unknown
		//IL_1074: Unknown result type (might be due to invalid IL or missing references)
		//IL_107e: Expected O, but got Unknown
		//IL_1086: Unknown result type (might be due to invalid IL or missing references)
		//IL_1090: Expected O, but got Unknown
		//IL_109d: Unknown result type (might be due to invalid IL or missing references)
		//IL_10a7: Expected O, but got Unknown
		//IL_10af: Unknown result type (might be due to invalid IL or missing references)
		//IL_10b9: Expected O, but got Unknown
		//IL_10c0: Unknown result type (might be due to invalid IL or missing references)
		//IL_10ca: Expected O, but got Unknown
		//IL_10d7: Unknown result type (might be due to invalid IL or missing references)
		//IL_10e1: Expected O, but got Unknown
		//IL_10e9: Unknown result type (might be due to invalid IL or missing references)
		//IL_10f3: Expected O, but got Unknown
		//IL_1100: Unknown result type (might be due to invalid IL or missing references)
		//IL_110a: Expected O, but got Unknown
		//IL_1112: Unknown result type (might be due to invalid IL or missing references)
		//IL_111c: Expected O, but got Unknown
		//IL_1129: Unknown result type (might be due to invalid IL or missing references)
		//IL_1133: Expected O, but got Unknown
		//IL_113b: Unknown result type (might be due to invalid IL or missing references)
		//IL_1145: Expected O, but got Unknown
		//IL_114c: Unknown result type (might be due to invalid IL or missing references)
		//IL_1156: Expected O, but got Unknown
		//IL_1163: Unknown result type (might be due to invalid IL or missing references)
		//IL_116d: Expected O, but got Unknown
		//IL_1175: Unknown result type (might be due to invalid IL or missing references)
		//IL_117f: Expected O, but got Unknown
		//IL_118c: Unknown result type (might be due to invalid IL or missing references)
		//IL_1196: Expected O, but got Unknown
		//IL_119e: Unknown result type (might be due to invalid IL or missing references)
		//IL_11a8: Expected O, but got Unknown
		//IL_11b5: Unknown result type (might be due to invalid IL or missing references)
		//IL_11bf: Expected O, but got Unknown
		//IL_11c7: Unknown result type (might be due to invalid IL or missing references)
		//IL_11d1: Expected O, but got Unknown
		//IL_11d8: Unknown result type (might be due to invalid IL or missing references)
		//IL_11e2: Expected O, but got Unknown
		//IL_11ef: Unknown result type (might be due to invalid IL or missing references)
		//IL_11f9: Expected O, but got Unknown
		//IL_1201: Unknown result type (might be due to invalid IL or missing references)
		//IL_120b: Expected O, but got Unknown
		//IL_1218: Unknown result type (might be due to invalid IL or missing references)
		//IL_1222: Expected O, but got Unknown
		//IL_122a: Unknown result type (might be due to invalid IL or missing references)
		//IL_1234: Expected O, but got Unknown
		//IL_1241: Unknown result type (might be due to invalid IL or missing references)
		//IL_124b: Expected O, but got Unknown
		//IL_1253: Unknown result type (might be due to invalid IL or missing references)
		//IL_125d: Expected O, but got Unknown
		//IL_1264: Unknown result type (might be due to invalid IL or missing references)
		//IL_126e: Expected O, but got Unknown
		//IL_127b: Unknown result type (might be due to invalid IL or missing references)
		//IL_1285: Expected O, but got Unknown
		//IL_128d: Unknown result type (might be due to invalid IL or missing references)
		//IL_1297: Expected O, but got Unknown
		//IL_12a4: Unknown result type (might be due to invalid IL or missing references)
		//IL_12ae: Expected O, but got Unknown
		//IL_12b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_12c0: Expected O, but got Unknown
		//IL_12cd: Unknown result type (might be due to invalid IL or missing references)
		//IL_12d7: Expected O, but got Unknown
		//IL_12df: Unknown result type (might be due to invalid IL or missing references)
		//IL_12e9: Expected O, but got Unknown
		//IL_12f0: Unknown result type (might be due to invalid IL or missing references)
		//IL_12fa: Expected O, but got Unknown
		//IL_1307: Unknown result type (might be due to invalid IL or missing references)
		//IL_1311: Expected O, but got Unknown
		//IL_1319: Unknown result type (might be due to invalid IL or missing references)
		//IL_1323: Expected O, but got Unknown
		//IL_1330: Unknown result type (might be due to invalid IL or missing references)
		//IL_133a: Expected O, but got Unknown
		//IL_1342: Unknown result type (might be due to invalid IL or missing references)
		//IL_134c: Expected O, but got Unknown
		//IL_1359: Unknown result type (might be due to invalid IL or missing references)
		//IL_1363: Expected O, but got Unknown
		//IL_136b: Unknown result type (might be due to invalid IL or missing references)
		//IL_1375: Expected O, but got Unknown
		//IL_137c: Unknown result type (might be due to invalid IL or missing references)
		//IL_1386: Expected O, but got Unknown
		//IL_1393: Unknown result type (might be due to invalid IL or missing references)
		//IL_139d: Expected O, but got Unknown
		//IL_13a5: Unknown result type (might be due to invalid IL or missing references)
		//IL_13af: Expected O, but got Unknown
		//IL_13bc: Unknown result type (might be due to invalid IL or missing references)
		//IL_13c6: Expected O, but got Unknown
		//IL_13ce: Unknown result type (might be due to invalid IL or missing references)
		//IL_13d8: Expected O, but got Unknown
		//IL_13e5: Unknown result type (might be due to invalid IL or missing references)
		//IL_13ef: Expected O, but got Unknown
		//IL_13f7: Unknown result type (might be due to invalid IL or missing references)
		//IL_1401: Expected O, but got Unknown
		//IL_1408: Unknown result type (might be due to invalid IL or missing references)
		//IL_1412: Expected O, but got Unknown
		//IL_141f: Unknown result type (might be due to invalid IL or missing references)
		//IL_1429: Expected O, but got Unknown
		//IL_1431: Unknown result type (might be due to invalid IL or missing references)
		//IL_143b: Expected O, but got Unknown
		//IL_1448: Unknown result type (might be due to invalid IL or missing references)
		//IL_1452: Expected O, but got Unknown
		//IL_145a: Unknown result type (might be due to invalid IL or missing references)
		//IL_1464: Expected O, but got Unknown
		//IL_1471: Unknown result type (might be due to invalid IL or missing references)
		//IL_147b: Expected O, but got Unknown
		//IL_1483: Unknown result type (might be due to invalid IL or missing references)
		//IL_148d: Expected O, but got Unknown
		//IL_1494: Unknown result type (might be due to invalid IL or missing references)
		//IL_149e: Expected O, but got Unknown
		//IL_14ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_14b5: Expected O, but got Unknown
		//IL_14bd: Unknown result type (might be due to invalid IL or missing references)
		//IL_14c7: Expected O, but got Unknown
		//IL_14d4: Unknown result type (might be due to invalid IL or missing references)
		//IL_14de: Expected O, but got Unknown
		//IL_14e6: Unknown result type (might be due to invalid IL or missing references)
		//IL_14f0: Expected O, but got Unknown
		//IL_14fd: Unknown result type (might be due to invalid IL or missing references)
		//IL_1507: Expected O, but got Unknown
		//IL_150f: Unknown result type (might be due to invalid IL or missing references)
		//IL_1519: Expected O, but got Unknown
		//IL_1520: Unknown result type (might be due to invalid IL or missing references)
		//IL_152a: Expected O, but got Unknown
		//IL_1537: Unknown result type (might be due to invalid IL or missing references)
		//IL_1541: Expected O, but got Unknown
		//IL_1549: Unknown result type (might be due to invalid IL or missing references)
		//IL_1553: Expected O, but got Unknown
		//IL_1560: Unknown result type (might be due to invalid IL or missing references)
		//IL_156a: Expected O, but got Unknown
		//IL_1572: Unknown result type (might be due to invalid IL or missing references)
		//IL_157c: Expected O, but got Unknown
		//IL_1589: Unknown result type (might be due to invalid IL or missing references)
		//IL_1593: Expected O, but got Unknown
		//IL_159b: Unknown result type (might be due to invalid IL or missing references)
		//IL_15a5: Expected O, but got Unknown
		//IL_15ac: Unknown result type (might be due to invalid IL or missing references)
		//IL_15b6: Expected O, but got Unknown
		//IL_15c3: Unknown result type (might be due to invalid IL or missing references)
		//IL_15cd: Expected O, but got Unknown
		//IL_15d5: Unknown result type (might be due to invalid IL or missing references)
		//IL_15df: Expected O, but got Unknown
		//IL_15ec: Unknown result type (might be due to invalid IL or missing references)
		//IL_15f6: Expected O, but got Unknown
		//IL_15fe: Unknown result type (might be due to invalid IL or missing references)
		//IL_1608: Expected O, but got Unknown
		//IL_1615: Unknown result type (might be due to invalid IL or missing references)
		//IL_161f: Expected O, but got Unknown
		//IL_1627: Unknown result type (might be due to invalid IL or missing references)
		//IL_1631: Expected O, but got Unknown
		//IL_1638: Unknown result type (might be due to invalid IL or missing references)
		//IL_1642: Expected O, but got Unknown
		//IL_164f: Unknown result type (might be due to invalid IL or missing references)
		//IL_1659: Expected O, but got Unknown
		//IL_1661: Unknown result type (might be due to invalid IL or missing references)
		//IL_166b: Expected O, but got Unknown
		//IL_1678: Unknown result type (might be due to invalid IL or missing references)
		//IL_1682: Expected O, but got Unknown
		//IL_168a: Unknown result type (might be due to invalid IL or missing references)
		//IL_1694: Expected O, but got Unknown
		//IL_16a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_16ab: Expected O, but got Unknown
		//IL_16b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_16bd: Expected O, but got Unknown
		//IL_16c4: Unknown result type (might be due to invalid IL or missing references)
		//IL_16ce: Expected O, but got Unknown
		//IL_16db: Unknown result type (might be due to invalid IL or missing references)
		//IL_16e5: Expected O, but got Unknown
		//IL_16ed: Unknown result type (might be due to invalid IL or missing references)
		//IL_16f7: Expected O, but got Unknown
		//IL_1704: Unknown result type (might be due to invalid IL or missing references)
		//IL_170e: Expected O, but got Unknown
		//IL_1716: Unknown result type (might be due to invalid IL or missing references)
		//IL_1720: Expected O, but got Unknown
		//IL_172d: Unknown result type (might be due to invalid IL or missing references)
		//IL_1737: Expected O, but got Unknown
		//IL_173f: Unknown result type (might be due to invalid IL or missing references)
		//IL_1749: Expected O, but got Unknown
		//IL_1750: Unknown result type (might be due to invalid IL or missing references)
		//IL_175a: Expected O, but got Unknown
		//IL_1767: Unknown result type (might be due to invalid IL or missing references)
		//IL_1771: Expected O, but got Unknown
		//IL_1779: Unknown result type (might be due to invalid IL or missing references)
		//IL_1783: Expected O, but got Unknown
		//IL_1790: Unknown result type (might be due to invalid IL or missing references)
		//IL_179a: Expected O, but got Unknown
		//IL_17a2: Unknown result type (might be due to invalid IL or missing references)
		//IL_17ac: Expected O, but got Unknown
		//IL_17b9: Unknown result type (might be due to invalid IL or missing references)
		//IL_17c3: Expected O, but got Unknown
		//IL_17cb: Unknown result type (might be due to invalid IL or missing references)
		//IL_17d5: Expected O, but got Unknown
		//IL_17dc: Unknown result type (might be due to invalid IL or missing references)
		//IL_17e6: Expected O, but got Unknown
		//IL_17f3: Unknown result type (might be due to invalid IL or missing references)
		//IL_17fd: Expected O, but got Unknown
		//IL_1805: Unknown result type (might be due to invalid IL or missing references)
		//IL_180f: Expected O, but got Unknown
		//IL_181c: Unknown result type (might be due to invalid IL or missing references)
		//IL_1826: Expected O, but got Unknown
		//IL_182e: Unknown result type (might be due to invalid IL or missing references)
		//IL_1838: Expected O, but got Unknown
		//IL_1845: Unknown result type (might be due to invalid IL or missing references)
		//IL_184f: Expected O, but got Unknown
		//IL_1857: Unknown result type (might be due to invalid IL or missing references)
		//IL_1861: Expected O, but got Unknown
		//IL_1865: Unknown result type (might be due to invalid IL or missing references)
		//IL_186f: Expected O, but got Unknown
		//IL_187c: Unknown result type (might be due to invalid IL or missing references)
		//IL_1886: Expected O, but got Unknown
		//IL_188b: Unknown result type (might be due to invalid IL or missing references)
		//IL_1895: Expected O, but got Unknown
		//IL_18a2: Unknown result type (might be due to invalid IL or missing references)
		//IL_18ac: Expected O, but got Unknown
		//IL_18b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_18bb: Expected O, but got Unknown
		//IL_18c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_18d2: Expected O, but got Unknown
		switch (connectionId)
		{
		case 1:
			textBox_NewCustomProduct_Name = (TextBox)target;
			((UIElement)textBox_NewCustomProduct_Name).LostFocus += new RoutedEventHandler(TextBox_NewCustomProduct_Name_LostFocus);
			break;
		case 2:
			newCustomProductSaveButton = (Button)target;
			((ButtonBase)newCustomProductSaveButton).Click += new RoutedEventHandler(NewCustomProductSaveButton_Click);
			break;
		case 3:
			stackPanel = (StackPanel)target;
			break;
		case 4:
			customProductMaterialRow_Row1 = (Grid)target;
			break;
		case 5:
			textBox_customProductMaterialSpending_Row1 = (TextBox)target;
			((UIElement)textBox_customProductMaterialSpending_Row1).LostFocus += new RoutedEventHandler(TextBox_CustomProductMaterialSpending_LostFocus);
			break;
		case 6:
			comboBox_customProductMaterial_Row1 = (ComboBox)target;
			((Selector)comboBox_customProductMaterial_Row1).SelectionChanged += new SelectionChangedEventHandler(ComboBox_CustomProductMaterial_SelectionChanged);
			break;
		case 7:
			customProductDeleteButton_Row1 = (Button)target;
			((ButtonBase)customProductDeleteButton_Row1).Click += new RoutedEventHandler(CustomProductDeleteButton_Row_Click);
			break;
		case 8:
			customProductMaterialRow_Row2 = (Grid)target;
			break;
		case 9:
			textBox_customProductMaterialSpending_Row2 = (TextBox)target;
			((UIElement)textBox_customProductMaterialSpending_Row2).LostFocus += new RoutedEventHandler(TextBox_CustomProductMaterialSpending_LostFocus);
			break;
		case 10:
			comboBox_customProductMaterial_Row2 = (ComboBox)target;
			((Selector)comboBox_customProductMaterial_Row2).SelectionChanged += new SelectionChangedEventHandler(ComboBox_CustomProductMaterial_SelectionChanged);
			break;
		case 11:
			customProductDeleteButton_Row2 = (Button)target;
			((ButtonBase)customProductDeleteButton_Row2).Click += new RoutedEventHandler(CustomProductDeleteButton_Row_Click);
			break;
		case 12:
			customProductMaterialRow_Row3 = (Grid)target;
			break;
		case 13:
			textBox_customProductMaterialSpending_Row3 = (TextBox)target;
			((UIElement)textBox_customProductMaterialSpending_Row3).LostFocus += new RoutedEventHandler(TextBox_CustomProductMaterialSpending_LostFocus);
			break;
		case 14:
			comboBox_customProductMaterial_Row3 = (ComboBox)target;
			((Selector)comboBox_customProductMaterial_Row3).SelectionChanged += new SelectionChangedEventHandler(ComboBox_CustomProductMaterial_SelectionChanged);
			break;
		case 15:
			customProductDeleteButton_Row3 = (Button)target;
			((ButtonBase)customProductDeleteButton_Row3).Click += new RoutedEventHandler(CustomProductDeleteButton_Row_Click);
			break;
		case 16:
			customProductMaterialRow_Row4 = (Grid)target;
			break;
		case 17:
			textBox_customProductMaterialSpending_Row4 = (TextBox)target;
			((UIElement)textBox_customProductMaterialSpending_Row4).LostFocus += new RoutedEventHandler(TextBox_CustomProductMaterialSpending_LostFocus);
			break;
		case 18:
			comboBox_customProductMaterial_Row4 = (ComboBox)target;
			((Selector)comboBox_customProductMaterial_Row4).SelectionChanged += new SelectionChangedEventHandler(ComboBox_CustomProductMaterial_SelectionChanged);
			break;
		case 19:
			customProductDeleteButton_Row4 = (Button)target;
			((ButtonBase)customProductDeleteButton_Row4).Click += new RoutedEventHandler(CustomProductDeleteButton_Row_Click);
			break;
		case 20:
			customProductMaterialRow_Row5 = (Grid)target;
			break;
		case 21:
			textBox_customProductMaterialSpending_Row5 = (TextBox)target;
			((UIElement)textBox_customProductMaterialSpending_Row5).LostFocus += new RoutedEventHandler(TextBox_CustomProductMaterialSpending_LostFocus);
			break;
		case 22:
			comboBox_customProductMaterial_Row5 = (ComboBox)target;
			((Selector)comboBox_customProductMaterial_Row5).SelectionChanged += new SelectionChangedEventHandler(ComboBox_CustomProductMaterial_SelectionChanged);
			break;
		case 23:
			customProductDeleteButton_Row5 = (Button)target;
			((ButtonBase)customProductDeleteButton_Row5).Click += new RoutedEventHandler(CustomProductDeleteButton_Row_Click);
			break;
		case 24:
			customProductMaterialRow_Row6 = (Grid)target;
			break;
		case 25:
			textBox_customProductMaterialSpending_Row6 = (TextBox)target;
			((UIElement)textBox_customProductMaterialSpending_Row6).LostFocus += new RoutedEventHandler(TextBox_CustomProductMaterialSpending_LostFocus);
			break;
		case 26:
			comboBox_customProductMaterial_Row6 = (ComboBox)target;
			((Selector)comboBox_customProductMaterial_Row6).SelectionChanged += new SelectionChangedEventHandler(ComboBox_CustomProductMaterial_SelectionChanged);
			break;
		case 27:
			customProductDeleteButton_Row6 = (Button)target;
			((ButtonBase)customProductDeleteButton_Row6).Click += new RoutedEventHandler(CustomProductDeleteButton_Row_Click);
			break;
		case 28:
			customProductMaterialRow_Row7 = (Grid)target;
			break;
		case 29:
			textBox_customProductMaterialSpending_Row7 = (TextBox)target;
			((UIElement)textBox_customProductMaterialSpending_Row7).LostFocus += new RoutedEventHandler(TextBox_CustomProductMaterialSpending_LostFocus);
			break;
		case 30:
			comboBox_customProductMaterial_Row7 = (ComboBox)target;
			((Selector)comboBox_customProductMaterial_Row7).SelectionChanged += new SelectionChangedEventHandler(ComboBox_CustomProductMaterial_SelectionChanged);
			break;
		case 31:
			customProductDeleteButton_Row7 = (Button)target;
			((ButtonBase)customProductDeleteButton_Row7).Click += new RoutedEventHandler(CustomProductDeleteButton_Row_Click);
			break;
		case 32:
			customProductMaterialRow_Row8 = (Grid)target;
			break;
		case 33:
			textBox_customProductMaterialSpending_Row8 = (TextBox)target;
			((UIElement)textBox_customProductMaterialSpending_Row8).LostFocus += new RoutedEventHandler(TextBox_CustomProductMaterialSpending_LostFocus);
			break;
		case 34:
			comboBox_customProductMaterial_Row8 = (ComboBox)target;
			((Selector)comboBox_customProductMaterial_Row8).SelectionChanged += new SelectionChangedEventHandler(ComboBox_CustomProductMaterial_SelectionChanged);
			break;
		case 35:
			customProductDeleteButton_Row8 = (Button)target;
			((ButtonBase)customProductDeleteButton_Row8).Click += new RoutedEventHandler(CustomProductDeleteButton_Row_Click);
			break;
		case 36:
			customProductMaterialRow_Row9 = (Grid)target;
			break;
		case 37:
			textBox_customProductMaterialSpending_Row9 = (TextBox)target;
			((UIElement)textBox_customProductMaterialSpending_Row9).LostFocus += new RoutedEventHandler(TextBox_CustomProductMaterialSpending_LostFocus);
			break;
		case 38:
			comboBox_customProductMaterial_Row9 = (ComboBox)target;
			((Selector)comboBox_customProductMaterial_Row9).SelectionChanged += new SelectionChangedEventHandler(ComboBox_CustomProductMaterial_SelectionChanged);
			break;
		case 39:
			customProductDeleteButton_Row9 = (Button)target;
			((ButtonBase)customProductDeleteButton_Row9).Click += new RoutedEventHandler(CustomProductDeleteButton_Row_Click);
			break;
		case 40:
			customProductMaterialRow_Row10 = (Grid)target;
			break;
		case 41:
			textBox_customProductMaterialSpending_Row10 = (TextBox)target;
			((UIElement)textBox_customProductMaterialSpending_Row10).LostFocus += new RoutedEventHandler(TextBox_CustomProductMaterialSpending_LostFocus);
			break;
		case 42:
			comboBox_customProductMaterial_Row10 = (ComboBox)target;
			((Selector)comboBox_customProductMaterial_Row10).SelectionChanged += new SelectionChangedEventHandler(ComboBox_CustomProductMaterial_SelectionChanged);
			break;
		case 43:
			customProductDeleteButton_Row10 = (Button)target;
			((ButtonBase)customProductDeleteButton_Row10).Click += new RoutedEventHandler(CustomProductDeleteButton_Row_Click);
			break;
		case 44:
			customProductMaterialRow_Row11 = (Grid)target;
			break;
		case 45:
			textBox_customProductMaterialSpending_Row11 = (TextBox)target;
			((UIElement)textBox_customProductMaterialSpending_Row11).LostFocus += new RoutedEventHandler(TextBox_CustomProductMaterialSpending_LostFocus);
			break;
		case 46:
			comboBox_customProductMaterial_Row11 = (ComboBox)target;
			((Selector)comboBox_customProductMaterial_Row11).SelectionChanged += new SelectionChangedEventHandler(ComboBox_CustomProductMaterial_SelectionChanged);
			break;
		case 47:
			customProductDeleteButton_Row11 = (Button)target;
			((ButtonBase)customProductDeleteButton_Row11).Click += new RoutedEventHandler(CustomProductDeleteButton_Row_Click);
			break;
		case 48:
			customProductMaterialRow_Row12 = (Grid)target;
			break;
		case 49:
			textBox_customProductMaterialSpending_Row12 = (TextBox)target;
			((UIElement)textBox_customProductMaterialSpending_Row12).LostFocus += new RoutedEventHandler(TextBox_CustomProductMaterialSpending_LostFocus);
			break;
		case 50:
			comboBox_customProductMaterial_Row12 = (ComboBox)target;
			((Selector)comboBox_customProductMaterial_Row12).SelectionChanged += new SelectionChangedEventHandler(ComboBox_CustomProductMaterial_SelectionChanged);
			break;
		case 51:
			customProductDeleteButton_Row12 = (Button)target;
			((ButtonBase)customProductDeleteButton_Row12).Click += new RoutedEventHandler(CustomProductDeleteButton_Row_Click);
			break;
		case 52:
			customProductMaterialRow_Row13 = (Grid)target;
			break;
		case 53:
			textBox_customProductMaterialSpending_Row13 = (TextBox)target;
			((UIElement)textBox_customProductMaterialSpending_Row13).LostFocus += new RoutedEventHandler(TextBox_CustomProductMaterialSpending_LostFocus);
			break;
		case 54:
			comboBox_customProductMaterial_Row13 = (ComboBox)target;
			((Selector)comboBox_customProductMaterial_Row13).SelectionChanged += new SelectionChangedEventHandler(ComboBox_CustomProductMaterial_SelectionChanged);
			break;
		case 55:
			customProductDeleteButton_Row13 = (Button)target;
			((ButtonBase)customProductDeleteButton_Row13).Click += new RoutedEventHandler(CustomProductDeleteButton_Row_Click);
			break;
		case 56:
			customProductMaterialRow_Row14 = (Grid)target;
			break;
		case 57:
			textBox_customProductMaterialSpending_Row14 = (TextBox)target;
			((UIElement)textBox_customProductMaterialSpending_Row14).LostFocus += new RoutedEventHandler(TextBox_CustomProductMaterialSpending_LostFocus);
			break;
		case 58:
			comboBox_customProductMaterial_Row14 = (ComboBox)target;
			((Selector)comboBox_customProductMaterial_Row14).SelectionChanged += new SelectionChangedEventHandler(ComboBox_CustomProductMaterial_SelectionChanged);
			break;
		case 59:
			customProductDeleteButton_Row14 = (Button)target;
			((ButtonBase)customProductDeleteButton_Row14).Click += new RoutedEventHandler(CustomProductDeleteButton_Row_Click);
			break;
		case 60:
			customProductMaterialRow_Row15 = (Grid)target;
			break;
		case 61:
			textBox_customProductMaterialSpending_Row15 = (TextBox)target;
			((UIElement)textBox_customProductMaterialSpending_Row15).LostFocus += new RoutedEventHandler(TextBox_CustomProductMaterialSpending_LostFocus);
			break;
		case 62:
			comboBox_customProductMaterial_Row15 = (ComboBox)target;
			((Selector)comboBox_customProductMaterial_Row15).SelectionChanged += new SelectionChangedEventHandler(ComboBox_CustomProductMaterial_SelectionChanged);
			break;
		case 63:
			customProductDeleteButton_Row15 = (Button)target;
			((ButtonBase)customProductDeleteButton_Row15).Click += new RoutedEventHandler(CustomProductDeleteButton_Row_Click);
			break;
		case 64:
			customProductMaterialRow_Row16 = (Grid)target;
			break;
		case 65:
			textBox_customProductMaterialSpending_Row16 = (TextBox)target;
			((UIElement)textBox_customProductMaterialSpending_Row16).LostFocus += new RoutedEventHandler(TextBox_CustomProductMaterialSpending_LostFocus);
			break;
		case 66:
			comboBox_customProductMaterial_Row16 = (ComboBox)target;
			((Selector)comboBox_customProductMaterial_Row16).SelectionChanged += new SelectionChangedEventHandler(ComboBox_CustomProductMaterial_SelectionChanged);
			break;
		case 67:
			customProductDeleteButton_Row16 = (Button)target;
			((ButtonBase)customProductDeleteButton_Row16).Click += new RoutedEventHandler(CustomProductDeleteButton_Row_Click);
			break;
		case 68:
			customProductMaterialRow_Row17 = (Grid)target;
			break;
		case 69:
			textBox_customProductMaterialSpending_Row17 = (TextBox)target;
			((UIElement)textBox_customProductMaterialSpending_Row17).LostFocus += new RoutedEventHandler(TextBox_CustomProductMaterialSpending_LostFocus);
			break;
		case 70:
			comboBox_customProductMaterial_Row17 = (ComboBox)target;
			((Selector)comboBox_customProductMaterial_Row17).SelectionChanged += new SelectionChangedEventHandler(ComboBox_CustomProductMaterial_SelectionChanged);
			break;
		case 71:
			customProductDeleteButton_Row17 = (Button)target;
			((ButtonBase)customProductDeleteButton_Row17).Click += new RoutedEventHandler(CustomProductDeleteButton_Row_Click);
			break;
		case 72:
			customProductMaterialRow_Row18 = (Grid)target;
			break;
		case 73:
			textBox_customProductMaterialSpending_Row18 = (TextBox)target;
			((UIElement)textBox_customProductMaterialSpending_Row18).LostFocus += new RoutedEventHandler(TextBox_CustomProductMaterialSpending_LostFocus);
			break;
		case 74:
			comboBox_customProductMaterial_Row18 = (ComboBox)target;
			((Selector)comboBox_customProductMaterial_Row18).SelectionChanged += new SelectionChangedEventHandler(ComboBox_CustomProductMaterial_SelectionChanged);
			break;
		case 75:
			customProductDeleteButton_Row18 = (Button)target;
			((ButtonBase)customProductDeleteButton_Row18).Click += new RoutedEventHandler(CustomProductDeleteButton_Row_Click);
			break;
		case 76:
			customProductMaterialRow_Row19 = (Grid)target;
			break;
		case 77:
			textBox_customProductMaterialSpending_Row19 = (TextBox)target;
			((UIElement)textBox_customProductMaterialSpending_Row19).LostFocus += new RoutedEventHandler(TextBox_CustomProductMaterialSpending_LostFocus);
			break;
		case 78:
			comboBox_customProductMaterial_Row19 = (ComboBox)target;
			((Selector)comboBox_customProductMaterial_Row19).SelectionChanged += new SelectionChangedEventHandler(ComboBox_CustomProductMaterial_SelectionChanged);
			break;
		case 79:
			customProductDeleteButton_Row19 = (Button)target;
			((ButtonBase)customProductDeleteButton_Row19).Click += new RoutedEventHandler(CustomProductDeleteButton_Row_Click);
			break;
		case 80:
			customProductMaterialRow_Row20 = (Grid)target;
			break;
		case 81:
			textBox_customProductMaterialSpending_Row20 = (TextBox)target;
			((UIElement)textBox_customProductMaterialSpending_Row20).LostFocus += new RoutedEventHandler(TextBox_CustomProductMaterialSpending_LostFocus);
			break;
		case 82:
			comboBox_customProductMaterial_Row20 = (ComboBox)target;
			((Selector)comboBox_customProductMaterial_Row20).SelectionChanged += new SelectionChangedEventHandler(ComboBox_CustomProductMaterial_SelectionChanged);
			break;
		case 83:
			customProductDeleteButton_Row20 = (Button)target;
			((ButtonBase)customProductDeleteButton_Row20).Click += new RoutedEventHandler(CustomProductDeleteButton_Row_Click);
			break;
		case 84:
			customProductMaterialRow_Row21 = (Grid)target;
			break;
		case 85:
			textBox_customProductMaterialSpending_Row21 = (TextBox)target;
			((UIElement)textBox_customProductMaterialSpending_Row21).LostFocus += new RoutedEventHandler(TextBox_CustomProductMaterialSpending_LostFocus);
			break;
		case 86:
			comboBox_customProductMaterial_Row21 = (ComboBox)target;
			((Selector)comboBox_customProductMaterial_Row21).SelectionChanged += new SelectionChangedEventHandler(ComboBox_CustomProductMaterial_SelectionChanged);
			break;
		case 87:
			customProductDeleteButton_Row21 = (Button)target;
			((ButtonBase)customProductDeleteButton_Row21).Click += new RoutedEventHandler(CustomProductDeleteButton_Row_Click);
			break;
		case 88:
			customProductMaterialRow_Row22 = (Grid)target;
			break;
		case 89:
			textBox_customProductMaterialSpending_Row22 = (TextBox)target;
			((UIElement)textBox_customProductMaterialSpending_Row22).LostFocus += new RoutedEventHandler(TextBox_CustomProductMaterialSpending_LostFocus);
			break;
		case 90:
			comboBox_customProductMaterial_Row22 = (ComboBox)target;
			((Selector)comboBox_customProductMaterial_Row22).SelectionChanged += new SelectionChangedEventHandler(ComboBox_CustomProductMaterial_SelectionChanged);
			break;
		case 91:
			customProductDeleteButton_Row22 = (Button)target;
			((ButtonBase)customProductDeleteButton_Row22).Click += new RoutedEventHandler(CustomProductDeleteButton_Row_Click);
			break;
		case 92:
			customProductMaterialRow_Row23 = (Grid)target;
			break;
		case 93:
			textBox_customProductMaterialSpending_Row23 = (TextBox)target;
			((UIElement)textBox_customProductMaterialSpending_Row23).LostFocus += new RoutedEventHandler(TextBox_CustomProductMaterialSpending_LostFocus);
			break;
		case 94:
			comboBox_customProductMaterial_Row23 = (ComboBox)target;
			((Selector)comboBox_customProductMaterial_Row23).SelectionChanged += new SelectionChangedEventHandler(ComboBox_CustomProductMaterial_SelectionChanged);
			break;
		case 95:
			customProductDeleteButton_Row23 = (Button)target;
			((ButtonBase)customProductDeleteButton_Row23).Click += new RoutedEventHandler(CustomProductDeleteButton_Row_Click);
			break;
		case 96:
			customProductMaterialRow_Row24 = (Grid)target;
			break;
		case 97:
			textBox_customProductMaterialSpending_Row24 = (TextBox)target;
			((UIElement)textBox_customProductMaterialSpending_Row24).LostFocus += new RoutedEventHandler(TextBox_CustomProductMaterialSpending_LostFocus);
			break;
		case 98:
			comboBox_customProductMaterial_Row24 = (ComboBox)target;
			((Selector)comboBox_customProductMaterial_Row24).SelectionChanged += new SelectionChangedEventHandler(ComboBox_CustomProductMaterial_SelectionChanged);
			break;
		case 99:
			customProductDeleteButton_Row24 = (Button)target;
			((ButtonBase)customProductDeleteButton_Row24).Click += new RoutedEventHandler(CustomProductDeleteButton_Row_Click);
			break;
		case 100:
			customProductMaterialRow_Row25 = (Grid)target;
			break;
		case 101:
			textBox_customProductMaterialSpending_Row25 = (TextBox)target;
			((UIElement)textBox_customProductMaterialSpending_Row25).LostFocus += new RoutedEventHandler(TextBox_CustomProductMaterialSpending_LostFocus);
			break;
		case 102:
			comboBox_customProductMaterial_Row25 = (ComboBox)target;
			((Selector)comboBox_customProductMaterial_Row25).SelectionChanged += new SelectionChangedEventHandler(ComboBox_CustomProductMaterial_SelectionChanged);
			break;
		case 103:
			customProductDeleteButton_Row25 = (Button)target;
			((ButtonBase)customProductDeleteButton_Row25).Click += new RoutedEventHandler(CustomProductDeleteButton_Row_Click);
			break;
		case 104:
			customProductMaterialRow_Row26 = (Grid)target;
			break;
		case 105:
			textBox_customProductMaterialSpending_Row26 = (TextBox)target;
			((UIElement)textBox_customProductMaterialSpending_Row26).LostFocus += new RoutedEventHandler(TextBox_CustomProductMaterialSpending_LostFocus);
			break;
		case 106:
			comboBox_customProductMaterial_Row26 = (ComboBox)target;
			((Selector)comboBox_customProductMaterial_Row26).SelectionChanged += new SelectionChangedEventHandler(ComboBox_CustomProductMaterial_SelectionChanged);
			break;
		case 107:
			customProductDeleteButton_Row26 = (Button)target;
			((ButtonBase)customProductDeleteButton_Row26).Click += new RoutedEventHandler(CustomProductDeleteButton_Row_Click);
			break;
		case 108:
			customProductMaterialRow_Row27 = (Grid)target;
			break;
		case 109:
			textBox_customProductMaterialSpending_Row27 = (TextBox)target;
			((UIElement)textBox_customProductMaterialSpending_Row27).LostFocus += new RoutedEventHandler(TextBox_CustomProductMaterialSpending_LostFocus);
			break;
		case 110:
			comboBox_customProductMaterial_Row27 = (ComboBox)target;
			((Selector)comboBox_customProductMaterial_Row27).SelectionChanged += new SelectionChangedEventHandler(ComboBox_CustomProductMaterial_SelectionChanged);
			break;
		case 111:
			customProductDeleteButton_Row27 = (Button)target;
			((ButtonBase)customProductDeleteButton_Row27).Click += new RoutedEventHandler(CustomProductDeleteButton_Row_Click);
			break;
		case 112:
			customProductMaterialRow_Row28 = (Grid)target;
			break;
		case 113:
			textBox_customProductMaterialSpending_Row28 = (TextBox)target;
			((UIElement)textBox_customProductMaterialSpending_Row28).LostFocus += new RoutedEventHandler(TextBox_CustomProductMaterialSpending_LostFocus);
			break;
		case 114:
			comboBox_customProductMaterial_Row28 = (ComboBox)target;
			((Selector)comboBox_customProductMaterial_Row28).SelectionChanged += new SelectionChangedEventHandler(ComboBox_CustomProductMaterial_SelectionChanged);
			break;
		case 115:
			customProductDeleteButton_Row28 = (Button)target;
			((ButtonBase)customProductDeleteButton_Row28).Click += new RoutedEventHandler(CustomProductDeleteButton_Row_Click);
			break;
		case 116:
			customProductMaterialRow_Row29 = (Grid)target;
			break;
		case 117:
			textBox_customProductMaterialSpending_Row29 = (TextBox)target;
			((UIElement)textBox_customProductMaterialSpending_Row29).LostFocus += new RoutedEventHandler(TextBox_CustomProductMaterialSpending_LostFocus);
			break;
		case 118:
			comboBox_customProductMaterial_Row29 = (ComboBox)target;
			((Selector)comboBox_customProductMaterial_Row29).SelectionChanged += new SelectionChangedEventHandler(ComboBox_CustomProductMaterial_SelectionChanged);
			break;
		case 119:
			customProductDeleteButton_Row29 = (Button)target;
			((ButtonBase)customProductDeleteButton_Row29).Click += new RoutedEventHandler(CustomProductDeleteButton_Row_Click);
			break;
		case 120:
			customProductMaterialRow_Row30 = (Grid)target;
			break;
		case 121:
			textBox_customProductMaterialSpending_Row30 = (TextBox)target;
			((UIElement)textBox_customProductMaterialSpending_Row30).LostFocus += new RoutedEventHandler(TextBox_CustomProductMaterialSpending_LostFocus);
			break;
		case 122:
			comboBox_customProductMaterial_Row30 = (ComboBox)target;
			((Selector)comboBox_customProductMaterial_Row30).SelectionChanged += new SelectionChangedEventHandler(ComboBox_CustomProductMaterial_SelectionChanged);
			break;
		case 123:
			customProductDeleteButton_Row30 = (Button)target;
			((ButtonBase)customProductDeleteButton_Row30).Click += new RoutedEventHandler(CustomProductDeleteButton_Row_Click);
			break;
		case 124:
			customProductMaterialRow_Row31 = (Grid)target;
			break;
		case 125:
			textBox_customProductMaterialSpending_Row31 = (TextBox)target;
			((UIElement)textBox_customProductMaterialSpending_Row31).LostFocus += new RoutedEventHandler(TextBox_CustomProductMaterialSpending_LostFocus);
			break;
		case 126:
			comboBox_customProductMaterial_Row31 = (ComboBox)target;
			((Selector)comboBox_customProductMaterial_Row31).SelectionChanged += new SelectionChangedEventHandler(ComboBox_CustomProductMaterial_SelectionChanged);
			break;
		case 127:
			customProductDeleteButton_Row31 = (Button)target;
			((ButtonBase)customProductDeleteButton_Row31).Click += new RoutedEventHandler(CustomProductDeleteButton_Row_Click);
			break;
		case 128:
			customProductMaterialRow_Row32 = (Grid)target;
			break;
		case 129:
			textBox_customProductMaterialSpending_Row32 = (TextBox)target;
			((UIElement)textBox_customProductMaterialSpending_Row32).LostFocus += new RoutedEventHandler(TextBox_CustomProductMaterialSpending_LostFocus);
			break;
		case 130:
			comboBox_customProductMaterial_Row32 = (ComboBox)target;
			((Selector)comboBox_customProductMaterial_Row32).SelectionChanged += new SelectionChangedEventHandler(ComboBox_CustomProductMaterial_SelectionChanged);
			break;
		case 131:
			customProductDeleteButton_Row32 = (Button)target;
			((ButtonBase)customProductDeleteButton_Row32).Click += new RoutedEventHandler(CustomProductDeleteButton_Row_Click);
			break;
		case 132:
			customProductMaterialRow_Row33 = (Grid)target;
			break;
		case 133:
			textBox_customProductMaterialSpending_Row33 = (TextBox)target;
			((UIElement)textBox_customProductMaterialSpending_Row33).LostFocus += new RoutedEventHandler(TextBox_CustomProductMaterialSpending_LostFocus);
			break;
		case 134:
			comboBox_customProductMaterial_Row33 = (ComboBox)target;
			((Selector)comboBox_customProductMaterial_Row33).SelectionChanged += new SelectionChangedEventHandler(ComboBox_CustomProductMaterial_SelectionChanged);
			break;
		case 135:
			customProductDeleteButton_Row33 = (Button)target;
			((ButtonBase)customProductDeleteButton_Row33).Click += new RoutedEventHandler(CustomProductDeleteButton_Row_Click);
			break;
		case 136:
			customProductMaterialRow_Row34 = (Grid)target;
			break;
		case 137:
			textBox_customProductMaterialSpending_Row34 = (TextBox)target;
			((UIElement)textBox_customProductMaterialSpending_Row34).LostFocus += new RoutedEventHandler(TextBox_CustomProductMaterialSpending_LostFocus);
			break;
		case 138:
			comboBox_customProductMaterial_Row34 = (ComboBox)target;
			((Selector)comboBox_customProductMaterial_Row34).SelectionChanged += new SelectionChangedEventHandler(ComboBox_CustomProductMaterial_SelectionChanged);
			break;
		case 139:
			customProductDeleteButton_Row34 = (Button)target;
			((ButtonBase)customProductDeleteButton_Row34).Click += new RoutedEventHandler(CustomProductDeleteButton_Row_Click);
			break;
		case 140:
			customProductMaterialRow_Row35 = (Grid)target;
			break;
		case 141:
			textBox_customProductMaterialSpending_Row35 = (TextBox)target;
			((UIElement)textBox_customProductMaterialSpending_Row35).LostFocus += new RoutedEventHandler(TextBox_CustomProductMaterialSpending_LostFocus);
			break;
		case 142:
			comboBox_customProductMaterial_Row35 = (ComboBox)target;
			((Selector)comboBox_customProductMaterial_Row35).SelectionChanged += new SelectionChangedEventHandler(ComboBox_CustomProductMaterial_SelectionChanged);
			break;
		case 143:
			customProductDeleteButton_Row35 = (Button)target;
			((ButtonBase)customProductDeleteButton_Row35).Click += new RoutedEventHandler(CustomProductDeleteButton_Row_Click);
			break;
		case 144:
			customProductMaterialRow_Row36 = (Grid)target;
			break;
		case 145:
			textBox_customProductMaterialSpending_Row36 = (TextBox)target;
			((UIElement)textBox_customProductMaterialSpending_Row36).LostFocus += new RoutedEventHandler(TextBox_CustomProductMaterialSpending_LostFocus);
			break;
		case 146:
			comboBox_customProductMaterial_Row36 = (ComboBox)target;
			((Selector)comboBox_customProductMaterial_Row36).SelectionChanged += new SelectionChangedEventHandler(ComboBox_CustomProductMaterial_SelectionChanged);
			break;
		case 147:
			customProductDeleteButton_Row36 = (Button)target;
			((ButtonBase)customProductDeleteButton_Row36).Click += new RoutedEventHandler(CustomProductDeleteButton_Row_Click);
			break;
		case 148:
			customProductMaterialRow_Row37 = (Grid)target;
			break;
		case 149:
			textBox_customProductMaterialSpending_Row37 = (TextBox)target;
			((UIElement)textBox_customProductMaterialSpending_Row37).LostFocus += new RoutedEventHandler(TextBox_CustomProductMaterialSpending_LostFocus);
			break;
		case 150:
			comboBox_customProductMaterial_Row37 = (ComboBox)target;
			((Selector)comboBox_customProductMaterial_Row37).SelectionChanged += new SelectionChangedEventHandler(ComboBox_CustomProductMaterial_SelectionChanged);
			break;
		case 151:
			customProductDeleteButton_Row37 = (Button)target;
			((ButtonBase)customProductDeleteButton_Row37).Click += new RoutedEventHandler(CustomProductDeleteButton_Row_Click);
			break;
		case 152:
			customProductMaterialRow_Row38 = (Grid)target;
			break;
		case 153:
			textBox_customProductMaterialSpending_Row38 = (TextBox)target;
			((UIElement)textBox_customProductMaterialSpending_Row38).LostFocus += new RoutedEventHandler(TextBox_CustomProductMaterialSpending_LostFocus);
			break;
		case 154:
			comboBox_customProductMaterial_Row38 = (ComboBox)target;
			((Selector)comboBox_customProductMaterial_Row38).SelectionChanged += new SelectionChangedEventHandler(ComboBox_CustomProductMaterial_SelectionChanged);
			break;
		case 155:
			customProductDeleteButton_Row38 = (Button)target;
			((ButtonBase)customProductDeleteButton_Row38).Click += new RoutedEventHandler(CustomProductDeleteButton_Row_Click);
			break;
		case 156:
			customProductMaterialRow_Row39 = (Grid)target;
			break;
		case 157:
			textBox_customProductMaterialSpending_Row39 = (TextBox)target;
			((UIElement)textBox_customProductMaterialSpending_Row39).LostFocus += new RoutedEventHandler(TextBox_CustomProductMaterialSpending_LostFocus);
			break;
		case 158:
			comboBox_customProductMaterial_Row39 = (ComboBox)target;
			((Selector)comboBox_customProductMaterial_Row39).SelectionChanged += new SelectionChangedEventHandler(ComboBox_CustomProductMaterial_SelectionChanged);
			break;
		case 159:
			customProductDeleteButton_Row39 = (Button)target;
			((ButtonBase)customProductDeleteButton_Row39).Click += new RoutedEventHandler(CustomProductDeleteButton_Row_Click);
			break;
		case 160:
			customProductMaterialRow_Row40 = (Grid)target;
			break;
		case 161:
			textBox_customProductMaterialSpending_Row40 = (TextBox)target;
			((UIElement)textBox_customProductMaterialSpending_Row40).LostFocus += new RoutedEventHandler(TextBox_CustomProductMaterialSpending_LostFocus);
			break;
		case 162:
			comboBox_customProductMaterial_Row40 = (ComboBox)target;
			((Selector)comboBox_customProductMaterial_Row40).SelectionChanged += new SelectionChangedEventHandler(ComboBox_CustomProductMaterial_SelectionChanged);
			break;
		case 163:
			customProductDeleteButton_Row40 = (Button)target;
			((ButtonBase)customProductDeleteButton_Row40).Click += new RoutedEventHandler(CustomProductDeleteButton_Row_Click);
			break;
		default:
			_contentLoaded = true;
			break;
		}
	}
}
