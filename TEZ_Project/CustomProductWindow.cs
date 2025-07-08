using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Markup;
using ListView = System.Windows.Controls.ListView;
using ComboBox = System.Windows.Controls.ComboBox;
using TEZ_Project.Common.Data;
using TEZ_Project.Common.Data.Entities;
using TEZ_Project.Common.Helpers;
using log4net;

namespace TEZ_Project;

public class CustomProductWindow : Window, IComponentConnector, IStyleConnector
{
	private static readonly ILog log = LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);

	internal TextBox textBox_CustomProducts_Name_Filter;

	internal ListView customProductsList;

	internal GridView customProducts_Grid;

	private bool _contentLoaded;

	public OrderAction OrderAction { get; set; }

	public ListView List { get; set; }

	public User CurentUser { get; set; }

	private ICollection<CustomProductModel> CustomProducts { get; set; }

	public CustomProductWindow()
	{
		InitializeComponent();
		List = customProductsList;
	}

	public async Task LoadCustomProductsAsync()
	{
		try
		{
			CustomProducts = await CustomProductHelper.GetAllCustomProductsAsync();
			PopulateListView();
		}
		catch (Exception ex2)
		{
			Exception ex = ex2;
			((Window)this).Close();
			log.Error("Database error", ex);
		}
	}

	private async void NewCustomProduct_Click(object sender, RoutedEventArgs e)
	{
		NewCustomProductWindow newCustomProductWindow2 = new NewCustomProductWindow();
		((Window)newCustomProductWindow2).WindowStartupLocation = (WindowStartupLocation)1;
		newCustomProductWindow2.CurentUser = CurentUser;
		NewCustomProductWindow newCustomProductWindow = newCustomProductWindow2;
		newCustomProductWindow.LoadCustomProductsNameAndCosts();
		try
		{
			((Window)newCustomProductWindow).ShowDialog();
			if (newCustomProductWindow.RefreshCustomProductGrid)
			{
				await LoadCustomProductsAsync();
			}
		}
		catch (Exception ex2)
		{
			Exception ex = ex2;
			log.Error("Database error", ex);
		}
	}

	private async void EditCustomProduct_Click(object sender, RoutedEventArgs e)
	{
		Button button = (Button)((sender is Button) ? sender : null);
		CustomProductModel customProduct = ((FrameworkElement)button).DataContext as CustomProductModel;
		if (string.IsNullOrEmpty(customProduct?.Name))
		{
			return;
		}
		NewCustomProductWindow newCustomProductWindow2 = new NewCustomProductWindow();
		((Window)newCustomProductWindow2).WindowStartupLocation = (WindowStartupLocation)1;
		newCustomProductWindow2.SelectedCustomProductKey = customProduct.Name;
		newCustomProductWindow2.CurentUser = CurentUser;
		NewCustomProductWindow newCustomProductWindow = newCustomProductWindow2;
		newCustomProductWindow.LoadCustomProductsNameAndCosts();
		try
		{
			((Window)newCustomProductWindow).ShowDialog();
			if (newCustomProductWindow.RefreshCustomProductGrid)
			{
				await LoadCustomProductsAsync();
			}
		}
		catch (Exception ex2)
		{
			Exception ex = ex2;
			log.Error("Database error", ex);
		}
	}

	private void DeleteCustomProduct_Click(object sender, RoutedEventArgs e)
	{
		//IL_0090: Unknown result type (might be due to invalid IL or missing references)
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		//IL_0047: Unknown result type (might be due to invalid IL or missing references)
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		Button val = (Button)((sender is Button) ? sender : null);
		CustomProductModel customProductModel = ((FrameworkElement)val).DataContext as CustomProductModel;
		if (CurentUser.Role != Role.Administrator)
		{
			MessageBox.Show("Не достатньо прав для видалення");
			return;
		}
		MessageBoxResult val2 = MessageBox.Show("Ви дійсно хочете видалити нестандартний виріб?", "Підтвердження видалення", (MessageBoxButton)4);
		if (!(val2.ToString() == "Yes"))
		{
			return;
		}
		try
		{
			CustomProductHelper.DeleteCustomProduct(customProductModel.CustomProductId);
			((ItemsControl)List).Items.Remove((object)customProductModel);
		}
		catch (Exception exception)
		{
			MessageBox.Show("Не вдалося видалити нестандартний виріб");
			log.Error("Database error", exception);
		}
	}

	private void TextBox_CustomProducts_Name_Filter_TextChanged(object sender, TextChangedEventArgs e)
	{
		PopulateListView();
	}

	private void PopulateListView(Func<CustomProductModel, string> orderSelector = null)
	{
		TextBox textBox = textBox_CustomProducts_Name_Filter;
		((ItemsControl)List).Items.Clear();
		TextBox obj = textBox;
		ICollection<CustomProductModel> collection2;
		if (!string.IsNullOrEmpty((obj != null) ? obj.Text : null))
		{
			ICollection<CustomProductModel> collection = Enumerable.ToList<CustomProductModel>((IEnumerable<CustomProductModel>)Enumerable.OrderBy<CustomProductModel, string>(Enumerable.Where<CustomProductModel>((IEnumerable<CustomProductModel>)CustomProducts, (Func<CustomProductModel, bool>)((CustomProductModel cp) => cp.Name.Contains(textBox.Text))), (Func<CustomProductModel, string>)((CustomProductModel cp) => cp.Name)));
			collection2 = collection;
		}
		else
		{
			collection2 = CustomProducts;
		}
		ICollection<CustomProductModel> collection3 = collection2;
		if (orderSelector != null)
		{
			collection3 = Enumerable.ToList<CustomProductModel>((IEnumerable<CustomProductModel>)Enumerable.OrderBy<CustomProductModel, string>((IEnumerable<CustomProductModel>)collection3, orderSelector));
		}
		foreach (CustomProductModel item in collection3)
		{
			((ItemsControl)List).Items.Add((object)item);
		}
	}

	private void GridViewColumnHeaderClickedHandler(object sender, RoutedEventArgs e)
	{
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		if (!(e.OriginalSource is GridViewColumnHeader))
		{
			return;
		}
		GridViewColumnHeader val = (GridViewColumnHeader)e.OriginalSource;
		object obj;
		if ((int)val == 0)
		{
			obj = null;
		}
		else
		{
			GridViewColumn column = val.Column;
			obj = ((column == null) ? null : column.Header?.ToString());
		}
		string text = (string)obj;
		if (string.IsNullOrEmpty(text))
		{
			return;
		}
		Func<CustomProductModel, string> func = null;
		string text2 = text;
		string text3 = text2;
		if (!(text3 == "Назва"))
		{
			if (text3 == "Дата створення\\зміни")
			{
				func = (CustomProductModel cp) => cp.DisplayDate;
			}
		}
		else
		{
			func = (CustomProductModel cp) => cp.Name;
		}
		if (func != null)
		{
			PopulateListView(func);
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	public void InitializeComponent()
	{
		if (!_contentLoaded)
		{
			_contentLoaded = true;
			Uri uri = new Uri("/TEZ_Project;component/customproductwindows/customproductwindow.xaml", UriKind.Relative);
			Application.LoadComponent((object)this, uri);
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	[EditorBrowsable(EditorBrowsableState.Never)]
	void IComponentConnector.Connect(int connectionId, object target)
	{
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0036: Expected O, but got Unknown
		//IL_003b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0045: Expected O, but got Unknown
		//IL_0052: Unknown result type (might be due to invalid IL or missing references)
		//IL_005c: Expected O, but got Unknown
		//IL_0061: Unknown result type (might be due to invalid IL or missing references)
		//IL_006b: Expected O, but got Unknown
		//IL_007d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0087: Expected O, but got Unknown
		//IL_008c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0096: Expected O, but got Unknown
		switch (connectionId)
		{
		case 1:
			((ButtonBase)(Button)target).Click += new RoutedEventHandler(NewCustomProduct_Click);
			break;
		case 2:
			textBox_CustomProducts_Name_Filter = (TextBox)target;
			((TextBoxBase)textBox_CustomProducts_Name_Filter).TextChanged += new TextChangedEventHandler(TextBox_CustomProducts_Name_Filter_TextChanged);
			break;
		case 3:
			customProductsList = (ListView)target;
			((UIElement)customProductsList).AddHandler(ButtonBase.ClickEvent, (Delegate)new RoutedEventHandler(GridViewColumnHeaderClickedHandler));
			break;
		case 4:
			customProducts_Grid = (GridView)target;
			break;
		default:
			_contentLoaded = true;
			break;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	[EditorBrowsable(EditorBrowsableState.Never)]
	void IStyleConnector.Connect(int connectionId, object target)
	{
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Expected O, but got Unknown
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		//IL_0042: Expected O, but got Unknown
		switch (connectionId)
		{
		case 5:
			((ButtonBase)(Button)target).Click += new RoutedEventHandler(EditCustomProduct_Click);
			break;
		case 6:
			((ButtonBase)(Button)target).Click += new RoutedEventHandler(DeleteCustomProduct_Click);
			break;
		}
	}
}
