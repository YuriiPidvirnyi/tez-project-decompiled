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
using System.Windows.Input;
using System.Windows.Markup;
using ListView = System.Windows.Controls.ListView;
using ComboBox = System.Windows.Controls.ComboBox;
using TEZ_Project.Common.Data;
using TEZ_Project.Common.Data.Entities;
using static TEZ_Project.Common.Data.OrderAction;
using log4net;
using TEZ_Project.Common.Data.Repositories;

namespace TEZ_Project;

public class Order : Window, IComponentConnector, IStyleConnector
{
	private bool isUserInteraction;

	private static readonly ILog log = LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);

	internal DatePicker datePicker_OrdersDateFrom;

	internal DatePicker datePicker_OrdersDateTo;

	internal TextBox textBox_Orders_OrderCode_Filter;

	internal ListView ordersList;

	private bool _contentLoaded;

	public int? SelectedOrderId { get; private set; }

	public List<int> SelectedOrderIds { get; private set; }

	public OrderAction OrderAction { get; set; }

	public ListView List { get; set; }

	public User CurentUser { get; set; }

	private ICollection<OrderModel> Orders { get; set; }

	public Order()
	{
		InitializeComponent();
		List = ordersList;
		datePicker_OrdersDateFrom.SelectedDate = DateTime.Now.AddMonths(-1);
		datePicker_OrdersDateTo.SelectedDate = DateTime.Now;
		datePicker_OrdersDateFrom.SelectedDateChanged += DatePicker_OrdersDateFromTo_SelectedDateChanged;
		datePicker_OrdersDateTo.SelectedDateChanged += DatePicker_OrdersDateFromTo_SelectedDateChanged;
	}

	public async Task LoadOrdersAsync()
	{
		try
		{
			DateTime? dateFrom = datePicker_OrdersDateFrom.SelectedDate;
			DateTime? dateTo = (datePicker_OrdersDateTo.SelectedDate.HasValue ? new DateTime?(datePicker_OrdersDateTo.SelectedDate.Value.AddDays(1.0)) : datePicker_OrdersDateTo.SelectedDate);
			using (var unitOfWork = new UnitOfWork())
			{
				Orders = await unitOfWork.OrderRepository.GetOrdersAsync(dateFrom, dateTo);
			}
			PopulateListView();
		}
		catch (Exception ex2)
		{
			Exception ex = ex2;
			((Window)this).Close();
			log.Error("Database error", ex);
		}
	}

	private void OrderList_SelectionChanged(object sender, MouseButtonEventArgs e)
	{
		//IL_005e: Unknown result type (might be due to invalid IL or missing references)
		ListView val = (ListView)((sender is ListView) ? sender : null);
		if (val != null)
		{
			OrderModel orderModel = ((Selector)val).SelectedItem as OrderModel;
			if (orderModel.ManagerId != CurentUser.Id && CurentUser.Role != 0 && CurentUser.Role != Role.Administrator)
			{
				MessageBox.Show("Не достатньо прав для редагування");
			}
			else if (orderModel != null)
			{
				SelectedOrderId = orderModel.OrderId;
			OrderAction = TEZ_Project.Common.Data.OrderAction.Edit;
				((Window)this).Close();
			}
		}
	}

	private void Event_ComboBox_DropDownOpened(object sender, EventArgs e)
	{
		isUserInteraction = true;
	}

	private void Event_ComboBox_DropDownClosed(object sender, EventArgs e)
	{
		isUserInteraction = false;
	}

	private void comboBox_status_SelectionChanged(object sender, SelectionChangedEventArgs e)
	{
		//IL_00bb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0050: Unknown result type (might be due to invalid IL or missing references)
		if (!isUserInteraction)
		{
			return;
		}
		ComboBox val = (ComboBox)((sender is ComboBox) ? sender : null);
		OrderModel orderModel = ((FrameworkElement)val).DataContext as OrderModel;
		if (orderModel.ManagerId != CurentUser.Id && CurentUser.Role != 0)
		{
			MessageBox.Show("Не достатньо прав для редагування");
			return;
		}
		try
		{
			using UnitOfWork unitOfWork = new UnitOfWork();
			TEZ_Project.Common.Data.Entities.Order byId = unitOfWork.OrderRepository.GetById(int.Parse(((UIElement)val).Uid));
			byId.Status = ((Selector)val).SelectedIndex;
			unitOfWork.OrderRepository.Update(byId);
			unitOfWork.Save();
		}
		catch (Exception exception)
		{
			MessageBox.Show("Проблема з базою даних");
			log.Error("Database error", exception);
		}
	}

	private void comboBox_priority_SelectionChanged(object sender, SelectionChangedEventArgs e)
	{
		//IL_00bb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0050: Unknown result type (might be due to invalid IL or missing references)
		if (!isUserInteraction)
		{
			return;
		}
		ComboBox val = (ComboBox)((sender is ComboBox) ? sender : null);
		OrderModel orderModel = ((FrameworkElement)val).DataContext as OrderModel;
		if (orderModel.ManagerId != CurentUser.Id && CurentUser.Role != 0)
		{
			MessageBox.Show("Не достатньо прав для редагування");
			return;
		}
		try
		{
			using UnitOfWork unitOfWork = new UnitOfWork();
			TEZ_Project.Common.Data.Entities.Order byId = unitOfWork.OrderRepository.GetById(int.Parse(((UIElement)val).Uid));
			byId.Priority = ((Selector)val).SelectedIndex;
			unitOfWork.OrderRepository.Update(byId);
			unitOfWork.Save();
		}
		catch (Exception exception)
		{
			MessageBox.Show("Проблема з базою даних");
			log.Error("Database error", exception);
		}
	}

	private void NewOrder_Click(object sender, RoutedEventArgs e)
	{
		OrderAction = TEZ_Project.Common.Data.OrderAction.New;
		((Window)this).Close();
	}

	private void DeleteOrder_Click(object sender, RoutedEventArgs e)
	{
		//IL_00dd: Unknown result type (might be due to invalid IL or missing references)
		//IL_0068: Unknown result type (might be due to invalid IL or missing references)
		//IL_006d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0052: Unknown result type (might be due to invalid IL or missing references)
		Button val = (Button)((sender is Button) ? sender : null);
		OrderModel orderModel = ((FrameworkElement)val).DataContext as OrderModel;
		if (orderModel.ManagerId != CurentUser.Id && CurentUser.Role != 0 && CurentUser.Role != Role.Administrator)
		{
			MessageBox.Show("Не достатньо прав для видалення");
			return;
		}
		MessageBoxResult val2 = MessageBox.Show("Ви дійсно хочете видалити замовлення?", "Підтвердження видалення", (MessageBoxButton)4);
		if (!(val2.ToString() == "Yes"))
		{
			return;
		}
		try
		{
			using UnitOfWork unitOfWork = new UnitOfWork();
			unitOfWork.OrderRepository.Delete(orderModel.OrderId);
			unitOfWork.Save();
			((ItemsControl)List).Items.Remove((object)orderModel);
		}
		catch (Exception exception)
		{
			MessageBox.Show("Не вдалося видалити замовлення");
			log.Error("Database error", exception);
		}
	}

	private void EditOrder_Click(object sender, RoutedEventArgs e)
	{
		//IL_0052: Unknown result type (might be due to invalid IL or missing references)
		Button val = (Button)((sender is Button) ? sender : null);
		OrderModel orderModel = ((FrameworkElement)val).DataContext as OrderModel;
		if (orderModel.ManagerId != CurentUser.Id && CurentUser.Role != 0 && CurentUser.Role != Role.Administrator)
		{
			MessageBox.Show("Не достатньо прав для редагування");
		}
		else if (orderModel != null)
		{
			SelectedOrderId = orderModel.OrderId;
			OrderAction = TEZ_Project.Common.Data.OrderAction.Edit;
			((Window)this).Close();
		}
	}

	private void TemplateOrder_Click(object sender, RoutedEventArgs e)
	{
		Button val = (Button)((sender is Button) ? sender : null);
		if (((FrameworkElement)val).DataContext is OrderModel orderModel)
		{
			SelectedOrderId = orderModel.OrderId;
			OrderAction = TEZ_Project.Common.Data.OrderAction.Template;
			((Window)this).Close();
		}
	}

	private void TemplateOrdersBulk_Click(object sender, RoutedEventArgs e)
	{
		//IL_0083: Unknown result type (might be due to invalid IL or missing references)
		SelectedOrderIds = Enumerable.ToList<int>(Enumerable.Select<OrderModel, int>(Enumerable.Where<OrderModel>((IEnumerable<OrderModel>)Orders, (Func<OrderModel, bool>)((OrderModel o) => o.IsSelected)), (Func<OrderModel, int>)((OrderModel o) => o.OrderId)));
		if (Enumerable.Any<int>((IEnumerable<int>)SelectedOrderIds))
		{
			OrderAction = TEZ_Project.Common.Data.OrderAction.TemplatesBulk;
			((Window)this).Close();
		}
		else
		{
			MessageBox.Show("Жодне замовлення не вибрано!");
		}
	}

	private async void DatePicker_OrdersDateFromTo_SelectedDateChanged(object sender, SelectionChangedEventArgs e)
	{
		await LoadOrdersAsync();
	}

	private void TextBox_Orders_OrderCode_Filter_TextChanged(object sender, TextChangedEventArgs e)
	{
		PopulateListView();
	}

	private void PopulateListView(Func<OrderModel, string> orderSelector = null)
	{
		TextBox textBox = textBox_Orders_OrderCode_Filter;
		((ItemsControl)List).Items.Clear();
		foreach (OrderModel order in Orders)
		{
			order.IsSelected = false;
		}
		TextBox obj = textBox;
		ICollection<OrderModel> collection2;
		if (!string.IsNullOrEmpty((obj != null) ? obj.Text : null))
		{
			ICollection<OrderModel> collection = Enumerable.ToList<OrderModel>((IEnumerable<OrderModel>)Enumerable.OrderBy<OrderModel, string>(Enumerable.Where<OrderModel>((IEnumerable<OrderModel>)Orders, (Func<OrderModel, bool>)((OrderModel o) => o.Code.Contains(textBox.Text))), (Func<OrderModel, string>)((OrderModel o) => o.Code)));
			collection2 = collection;
		}
		else
		{
			collection2 = Orders;
		}
		ICollection<OrderModel> collection3 = collection2;
		if (orderSelector != null)
		{
			collection3 = Enumerable.ToList<OrderModel>((IEnumerable<OrderModel>)Enumerable.OrderBy<OrderModel, string>((IEnumerable<OrderModel>)collection3, orderSelector));
		}
		foreach (OrderModel item in collection3)
		{
			((ItemsControl)List).Items.Add((object)item);
		}
	}

	private void GridViewColumnHeaderClickedHandler(object sender, RoutedEventArgs e)
	{
		if (!(e.OriginalSource is GridViewColumnHeader header))
		{
			return;
		}

		var columnText = header.Column.Header?.ToString();
		if (string.IsNullOrEmpty(columnText))
		{
			return;
		}

		Func<OrderModel, string> keySelector = columnText switch
		{
			"Код замовлення" => o => o.Code,
			"Контрагент" => o => o.Contragent,
			_ => null
		};

		if (keySelector != null)
		{
			PopulateListView(keySelector);
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	public void InitializeComponent()
	{
		if (!_contentLoaded)
		{
			_contentLoaded = true;
			Uri uri = new Uri("/TEZ_Project;component/order.xaml", UriKind.Relative);
			Application.LoadComponent((object)this, uri);
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	[EditorBrowsable(EditorBrowsableState.Never)]
	void IComponentConnector.Connect(int connectionId, object target)
	{
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_0041: Expected O, but got Unknown
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		//IL_0054: Unknown result type (might be due to invalid IL or missing references)
		//IL_005e: Expected O, but got Unknown
		//IL_0063: Unknown result type (might be due to invalid IL or missing references)
		//IL_006d: Expected O, but got Unknown
		//IL_0071: Unknown result type (might be due to invalid IL or missing references)
		//IL_007b: Expected O, but got Unknown
		//IL_007f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0089: Expected O, but got Unknown
		//IL_0096: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a0: Expected O, but got Unknown
		//IL_00a5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00af: Expected O, but got Unknown
		//IL_00c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cb: Expected O, but got Unknown
		switch (connectionId)
		{
		case 1:
			((ButtonBase)(Button)target).Click += new RoutedEventHandler(NewOrder_Click);
			break;
		case 2:
			((ButtonBase)(Button)target).Click += new RoutedEventHandler(TemplateOrdersBulk_Click);
			break;
		case 3:
			datePicker_OrdersDateFrom = (DatePicker)target;
			break;
		case 4:
			datePicker_OrdersDateTo = (DatePicker)target;
			break;
		case 5:
			textBox_Orders_OrderCode_Filter = (TextBox)target;
			((TextBoxBase)textBox_Orders_OrderCode_Filter).TextChanged += new TextChangedEventHandler(TextBox_Orders_OrderCode_Filter_TextChanged);
			break;
		case 6:
			ordersList = (ListView)target;
			((UIElement)ordersList).AddHandler(ButtonBase.ClickEvent, (Delegate)new RoutedEventHandler(GridViewColumnHeaderClickedHandler));
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
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_003f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0057: Unknown result type (might be due to invalid IL or missing references)
		//IL_0063: Unknown result type (might be due to invalid IL or missing references)
		//IL_006d: Expected O, but got Unknown
		//IL_0074: Unknown result type (might be due to invalid IL or missing references)
		//IL_008c: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ba: Expected O, but got Unknown
		//IL_00be: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ca: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d4: Expected O, but got Unknown
		//IL_00d8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ee: Expected O, but got Unknown
		//IL_00f2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fe: Unknown result type (might be due to invalid IL or missing references)
		//IL_0108: Expected O, but got Unknown
		switch (connectionId)
		{
		case 7:
			((ComboBox)target).DropDownOpened += Event_ComboBox_DropDownOpened;
			((ComboBox)target).DropDownClosed += Event_ComboBox_DropDownClosed;
			((Selector)(ComboBox)target).SelectionChanged += new SelectionChangedEventHandler(comboBox_status_SelectionChanged);
			break;
		case 8:
			((ComboBox)target).DropDownOpened += Event_ComboBox_DropDownOpened;
			((ComboBox)target).DropDownClosed += Event_ComboBox_DropDownClosed;
			((Selector)(ComboBox)target).SelectionChanged += new SelectionChangedEventHandler(comboBox_priority_SelectionChanged);
			break;
		case 9:
			((ButtonBase)(Button)target).Click += new RoutedEventHandler(DeleteOrder_Click);
			break;
		case 10:
			((ButtonBase)(Button)target).Click += new RoutedEventHandler(EditOrder_Click);
			break;
		case 11:
			((ButtonBase)(Button)target).Click += new RoutedEventHandler(TemplateOrder_Click);
			break;
		}
	}
}
