using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Markup;
using TEZ_Project.Common.Data;
using TEZ_Project.Common.Data.Entities;
using TEZ_Project.Common.Helpers;

namespace TEZ_Project.Users;

public class CreateUser : Window, IComponentConnector
{
	internal TextBox login;

	internal TextBox password;

	internal ComboBox role;

	private bool _contentLoaded;

	public User NewUser { get; set; }

	public CreateUser()
	{
		InitializeComponent();
	}

	private void Save_Click(object sender, RoutedEventArgs e)
	{
		//IL_00de: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0040: Unknown result type (might be due to invalid IL or missing references)
		if (string.IsNullOrWhiteSpace(login.Text))
		{
			MessageBox.Show("Логін не може бути пустим");
			return;
		}
		if (string.IsNullOrWhiteSpace(password.Text))
		{
			MessageBox.Show("Пароль не може бути пустим");
			return;
		}
		try
		{
			using UnitOfWork unitOfWork = new UnitOfWork();
			User user = new User
			{
				Login = login.Text,
				Password = SecurePasswordHasher.Hash(login.Text),
				PasswordSetDate = DateTime.Now,
				Role = (Role)((Selector)role).SelectedIndex,
				IsPasswordReset = true
			};
			unitOfWork.UserRepository.Insert(user);
			unitOfWork.Save();
			NewUser = user;
		}
		catch (Exception)
		{
			MessageBox.Show("Проблема з базою даних");
		}
		((Window)this).Close();
	}

	private void Cancel_Click(object sender, RoutedEventArgs e)
	{
		((Window)this).Close();
	}

	[DebuggerNonUserCode]
	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	public void InitializeComponent()
	{
		if (!_contentLoaded)
		{
			_contentLoaded = true;
			Uri uri = new Uri("/TEZ_Project;component/users/createuser.xaml", UriKind.Relative);
			Application.LoadComponent((object)this, uri);
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	[EditorBrowsable(EditorBrowsableState.Never)]
	void IComponentConnector.Connect(int connectionId, object target)
	{
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		//IL_003a: Expected O, but got Unknown
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_004a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0054: Expected O, but got Unknown
		//IL_0059: Unknown result type (might be due to invalid IL or missing references)
		//IL_0063: Expected O, but got Unknown
		//IL_0067: Unknown result type (might be due to invalid IL or missing references)
		//IL_0071: Expected O, but got Unknown
		//IL_0075: Unknown result type (might be due to invalid IL or missing references)
		//IL_007f: Expected O, but got Unknown
		switch (connectionId)
		{
		case 1:
			((ButtonBase)(Button)target).Click += new RoutedEventHandler(Save_Click);
			break;
		case 2:
			((ButtonBase)(Button)target).Click += new RoutedEventHandler(Cancel_Click);
			break;
		case 3:
			login = (TextBox)target;
			break;
		case 4:
			password = (TextBox)target;
			break;
		case 5:
			role = (ComboBox)target;
			break;
		default:
			_contentLoaded = true;
			break;
		}
	}
}
