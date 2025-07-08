using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Reflection;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Markup;
using TEZ_Project.Common.Data;
using TEZ_Project.Common.Data.Entities;
using log4net;

namespace TEZ_Project.Users;

public class UserManagment : Window, IComponentConnector, IStyleConnector
{
	private static readonly ILog log = LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);

	internal ListView usersList;

	private bool _contentLoaded;

	public ListView List { get; set; }

	public UserManagment()
	{
		InitializeComponent();
		List = usersList;
		LoadUsers();
	}

	private void LoadUsers()
	{
		//IL_0056: Unknown result type (might be due to invalid IL or missing references)
		try
		{
			IEnumerable<User> all = new UnitOfWork().UserRepository.GetAll();
			foreach (User item in all)
			{
				((ItemsControl)List).Items.Add((object)item);
			}
		}
		catch (Exception exception)
		{
			MessageBox.Show("Зараз неможливо редагувати користувачів!");
			((Window)this).Close();
			log.Error("Database error", exception);
		}
	}

	private void Create_Click(object sender, RoutedEventArgs e)
	{
		CreateUser createUser = new CreateUser();
		((Window)createUser).WindowStartupLocation = (WindowStartupLocation)1;
		CreateUser createUser2 = createUser;
		try
		{
			((Window)createUser2).ShowDialog();
			if (createUser2.NewUser != null)
			{
				((ItemsControl)List).Items.Add((object)createUser2.NewUser);
			}
		}
		catch (Exception)
		{
			throw;
		}
	}

	private void comboBox_Role_SelectionChanged(object sender, SelectionChangedEventArgs e)
	{
		//IL_0060: Unknown result type (might be due to invalid IL or missing references)
		ComboBox val = (ComboBox)((sender is ComboBox) ? sender : null);
		try
		{
			using UnitOfWork unitOfWork = new UnitOfWork();
			User byId = unitOfWork.UserRepository.GetById(int.Parse(((UIElement)val).Uid));
			byId.Role = (Role)((Selector)val).SelectedIndex;
			unitOfWork.UserRepository.Update(byId);
			unitOfWork.Save();
		}
		catch (Exception exception)
		{
			MessageBox.Show("Проблема з базою даних");
			log.Error("Database error", exception);
		}
	}

	private void DeleteUser_Click(object sender, RoutedEventArgs e)
	{
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		//IL_0095: Unknown result type (might be due to invalid IL or missing references)
		MessageBoxResult val = MessageBox.Show("Ви дійсно хочете видалити користувача?", "Підтвердження видалення", (MessageBoxButton)4);
		if (!(((object)(MessageBoxResult)(ref val)).ToString() == "Yes"))
		{
			return;
		}
		Button val2 = (Button)((sender is Button) ? sender : null);
		User user = ((FrameworkElement)val2).DataContext as User;
		try
		{
			using UnitOfWork unitOfWork = new UnitOfWork();
			unitOfWork.UserRepository.Delete(user.Id);
			unitOfWork.Save();
			((ItemsControl)List).Items.Remove((object)user);
		}
		catch (Exception exception)
		{
			MessageBox.Show("Не вдалося видалити користувача");
			log.Error("Database error", exception);
		}
	}

	private void ResetPassword_Click(object sender, RoutedEventArgs e)
	{
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		//IL_009c: Unknown result type (might be due to invalid IL or missing references)
		MessageBoxResult val = MessageBox.Show("Ви дійсно хочете скинути пароль?", "Підтвердження скидання", (MessageBoxButton)4);
		if (!(((object)(MessageBoxResult)(ref val)).ToString() == "Yes"))
		{
			return;
		}
		Button val2 = (Button)((sender is Button) ? sender : null);
		User user = ((FrameworkElement)val2).DataContext as User;
		try
		{
			using UnitOfWork unitOfWork = new UnitOfWork();
			User byId = unitOfWork.UserRepository.GetById(user.Id);
			byId.IsPasswordReset = true;
			unitOfWork.UserRepository.Update(byId);
			unitOfWork.Save();
		}
		catch (Exception exception)
		{
			MessageBox.Show("Не вдалося скинути пароль");
			log.Error("Database error", exception);
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	public void InitializeComponent()
	{
		if (!_contentLoaded)
		{
			_contentLoaded = true;
			Uri uri = new Uri("/TEZ_Project;component/users/usermanagment.xaml", UriKind.Relative);
			Application.LoadComponent((object)this, uri);
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	[EditorBrowsable(EditorBrowsableState.Never)]
	void IComponentConnector.Connect(int connectionId, object target)
	{
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0036: Expected O, but got Unknown
		switch (connectionId)
		{
		case 1:
			usersList = (ListView)target;
			break;
		case 5:
			((ButtonBase)(Button)target).Click += new RoutedEventHandler(Create_Click);
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
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Expected O, but got Unknown
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		//IL_004c: Expected O, but got Unknown
		//IL_0050: Unknown result type (might be due to invalid IL or missing references)
		//IL_005c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0066: Expected O, but got Unknown
		switch (connectionId)
		{
		case 2:
			((Selector)(ComboBox)target).SelectionChanged += new SelectionChangedEventHandler(comboBox_Role_SelectionChanged);
			break;
		case 3:
			((ButtonBase)(Button)target).Click += new RoutedEventHandler(DeleteUser_Click);
			break;
		case 4:
			((ButtonBase)(Button)target).Click += new RoutedEventHandler(ResetPassword_Click);
			break;
		}
	}
}
