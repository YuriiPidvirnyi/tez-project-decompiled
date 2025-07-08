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
using ListView = System.Windows.Controls.ListView;
using ComboBox = System.Windows.Controls.ComboBox;
using TEZ_Project.Common.Data;
using TEZ_Project.Common.Data.Entities;
using log4net;

namespace TEZ_Project;

public class ConstManager : Window, IComponentConnector, IStyleConnector
{
	private bool isUserInteraction;

	private static readonly ILog log = LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);

	internal ListView constsList;

	private bool _contentLoaded;

	public ListView List { get; set; }

	public ConstManager()
	{
		InitializeComponent();
		List = constsList;
		LoadOrders();
	}

	private void LoadOrders()
	{
		//IL_00a1: Unknown result type (might be due to invalid IL or missing references)
		try
		{
			IEnumerable<Const> all = new UnitOfWork().ConstRepository.GetAll();
			IOrderedEnumerable<CustomConst> val = Enumerable.OrderBy<CustomConst, string>(Enumerable.Select<Const, CustomConst>(all, (Func<Const, CustomConst>)((Const c) => new CustomConst(c.Id, c.MaterialName, c.Price, c.MaterialNameFlight, c.Code1, c.MaterialName1C, c.Code2, c.OdVym1, c.OdVym2, c.NameInApp))), (Func<CustomConst, string>)((CustomConst c) => c.MaterialName));
			foreach (CustomConst item in (IEnumerable<CustomConst>)val)
			{
				((ItemsControl)List).Items.Add((object)item);
			}
		}
		catch (Exception exception)
		{
			MessageBox.Show("Зараз неможливо редагувати константи!");
			((Window)this).Close();
			log.Error("Database error", exception);
		}
	}

	private void const_TextChanged(object sender, TextChangedEventArgs e)
	{
		SetIsEdited(sender);
	}

	private void SetIsEdited(object sender)
	{
		TextBox val = (TextBox)((sender is TextBox) ? sender : null);
		CustomConst customConst = ((FrameworkElement)val).DataContext as CustomConst;
		customConst.IsEdited = true;
	}

	private void Save_Click(object sender, RoutedEventArgs e)
	{
		using (UnitOfWork unitOfWork = new UnitOfWork())
		{
			foreach (object item in (IEnumerable)((ItemsControl)List).Items)
			{
				CustomConst customConst = item as CustomConst;
				if (customConst.IsEdited)
				{
					unitOfWork.ConstRepository.Update(new Const
					{
						Id = customConst.Id,
						NameInApp = customConst.NameInApp,
						MaterialName = customConst.MaterialName,
						MaterialName1C = customConst.MaterialName1C,
						MaterialNameFlight = customConst.MaterialNameFlight,
						Price = customConst.Price,
						Code1 = customConst.Code1,
						Code2 = customConst.Code2,
						OdVym1 = customConst.OdVym1,
						OdVym2 = customConst.OdVym2
					});
				}
			}
			unitOfWork.Save();
		}
		Consts2.LoadConstsFromDb();
	}

	private void Event_ComboBox_DropDownOpened(object sender, EventArgs e)
	{
		isUserInteraction = true;
	}

	private void Event_ComboBox_DropDownClosed(object sender, EventArgs e)
	{
		isUserInteraction = false;
	}

	private void const_SelectionChanged(object sender, SelectionChangedEventArgs e)
	{
		if (isUserInteraction)
		{
			ComboBox val = (ComboBox)((sender is ComboBox) ? sender : null);
			CustomConst customConst = ((FrameworkElement)val).DataContext as CustomConst;
			customConst.IsEdited = true;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	public void InitializeComponent()
	{
		if (!_contentLoaded)
		{
			_contentLoaded = true;
			Uri uri = new Uri("/TEZ_Project;component/constmanager.xaml", UriKind.Relative);
			Application.LoadComponent((object)this, uri);
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	[EditorBrowsable(EditorBrowsableState.Never)]
	void IComponentConnector.Connect(int connectionId, object target)
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_001e: Expected O, but got Unknown
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Expected O, but got Unknown
		switch (connectionId)
		{
		case 1:
			constsList = (ListView)target;
			break;
		case 10:
			((ButtonBase)(Button)target).Click += new RoutedEventHandler(Save_Click);
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
		//IL_0033: Unknown result type (might be due to invalid IL or missing references)
		//IL_003f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0049: Expected O, but got Unknown
		//IL_0050: Unknown result type (might be due to invalid IL or missing references)
		//IL_005c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0066: Expected O, but got Unknown
		//IL_006d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0079: Unknown result type (might be due to invalid IL or missing references)
		//IL_0083: Expected O, but got Unknown
		//IL_008a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0096: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a0: Expected O, but got Unknown
		//IL_00a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bd: Expected O, but got Unknown
		//IL_00c4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00da: Expected O, but got Unknown
		//IL_00e1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f9: Unknown result type (might be due to invalid IL or missing references)
		//IL_0111: Unknown result type (might be due to invalid IL or missing references)
		//IL_011d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0127: Expected O, but got Unknown
		//IL_012b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0143: Unknown result type (might be due to invalid IL or missing references)
		//IL_015b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0167: Unknown result type (might be due to invalid IL or missing references)
		//IL_0171: Expected O, but got Unknown
		switch (connectionId)
		{
		case 2:
			((TextBoxBase)(TextBox)target).TextChanged += new TextChangedEventHandler(const_TextChanged);
			break;
		case 3:
			((TextBoxBase)(TextBox)target).TextChanged += new TextChangedEventHandler(const_TextChanged);
			break;
		case 4:
			((TextBoxBase)(TextBox)target).TextChanged += new TextChangedEventHandler(const_TextChanged);
			break;
		case 5:
			((TextBoxBase)(TextBox)target).TextChanged += new TextChangedEventHandler(const_TextChanged);
			break;
		case 6:
			((TextBoxBase)(TextBox)target).TextChanged += new TextChangedEventHandler(const_TextChanged);
			break;
		case 7:
			((TextBoxBase)(TextBox)target).TextChanged += new TextChangedEventHandler(const_TextChanged);
			break;
		case 8:
			((ComboBox)target).DropDownOpened += Event_ComboBox_DropDownOpened;
			((ComboBox)target).DropDownClosed += Event_ComboBox_DropDownClosed;
			((Selector)(ComboBox)target).SelectionChanged += new SelectionChangedEventHandler(const_SelectionChanged);
			break;
		case 9:
			((ComboBox)target).DropDownOpened += Event_ComboBox_DropDownOpened;
			((ComboBox)target).DropDownClosed += Event_ComboBox_DropDownClosed;
			((Selector)(ComboBox)target).SelectionChanged += new SelectionChangedEventHandler(const_SelectionChanged);
			break;
		}
	}
}
