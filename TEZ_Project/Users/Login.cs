using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Markup;
using Newtonsoft.Json;
using TEZ_Project.Common.Data;
using TEZ_Project.Common.Data.Entities;
using TEZ_Project.Common.Helpers;
using log4net;

namespace TEZ_Project.Users;

public class Login : Window, IComponentConnector
{
	private static readonly ILog log = LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);

	internal ComboBox loginBox;

	internal Button login;

	internal CheckBox rememberMe;

	internal PasswordBox passwordBox;

	private bool _contentLoaded;

	public bool ShouldResetPassword { get; set; }

	public bool IsAuthenticated { get; set; }

	public User AuthenticatedUser { get; set; }

	public IEnumerable<User> Users { get; set; }

	public Login()
	{
		InitializeComponent();
		LoadUsers();
	}

	private void LoadUsers()
	{
		try
		{
			Users = GetUsers();
			((ItemsControl)loginBox).ItemsSource = Enumerable.Select<User, string>(Users, (Func<User, string>)((User u) => u.Login));
			CheckRememberMe();
		}
		catch (Exception)
		{
			((Window)this).Close();
		}
	}

	private IEnumerable<User> GetUsers()
	{
		try
		{
			IEnumerable<User> all = new UnitOfWork().UserRepository.GetAll();
			SaveUsersToFile(all);
		}
		catch (Exception exception)
		{
			log.Error("Database error", exception);
		}
		return GetUsersFromFile();
	}

	private IEnumerable<User> GetUsersFromFile()
	{
		return JsonConvert.DeserializeObject<IEnumerable<User>>(File.ReadAllText("Users.json"));
	}

	private void SaveUsersToFile(IEnumerable<User> users)
	{
		File.WriteAllText("Users.json", JsonConvert.SerializeObject(users));
	}

	private void Button_Click(object sender, RoutedEventArgs e)
	{
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_0073: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ee: Unknown result type (might be due to invalid IL or missing references)
		string login = ((Selector)loginBox).SelectedItem as string;
		if (string.IsNullOrWhiteSpace(login))
		{
			MessageBox.Show("Виберіть користувача");
			return;
		}
		string password = passwordBox.Password;
		User user = Enumerable.FirstOrDefault<User>(Users, (Func<User, bool>)((User u) => u.Login == login));
		if (user.IsPasswordReset)
		{
			MessageBox.Show("Вам необхідно змінити пароль");
		}
		else if (SecurePasswordHasher.Verify(password, user.Password) || user.Password == password)
		{
			IsAuthenticated = true;
			AuthenticatedUser = user;
			if (((ToggleButton)rememberMe).IsChecked.Value)
			{
				WriteRememberMeFile(user);
			}
			else
			{
				RemoveRememberMeFile();
			}
			((Window)this).Close();
		}
		else
		{
			MessageBox.Show("Неправильний пароль");
		}
	}

	private void WriteRememberMeFile(User user)
	{
		File.WriteAllText("RememberMe.json", JsonConvert.SerializeObject(user));
	}

	private void RemoveRememberMeFile()
	{
		File.Delete("RememberMe.json");
	}

	private void CheckRememberMe()
	{
		if (File.Exists("RememberMe.json"))
		{
			User user = JsonConvert.DeserializeObject<User>(File.ReadAllText("RememberMe.json"));
			passwordBox.Password = user.Password;
			((Selector)loginBox).SelectedItem = user.Login;
			((ToggleButton)rememberMe).IsChecked = true;
		}
	}

	private void ChangePassword_Click(object sender, RoutedEventArgs e)
	{
		//IL_004a: Unknown result type (might be due to invalid IL or missing references)
		string login = ((Selector)loginBox).SelectedItem as string;
		User user = Enumerable.FirstOrDefault<User>(Users, (Func<User, bool>)((User u) => u.Login == login));
		if (string.IsNullOrWhiteSpace(login))
		{
			MessageBox.Show("Виберіть користувача");
			return;
		}
		ChangePassword changePassword = new ChangePassword();
		((Window)changePassword).WindowStartupLocation = (WindowStartupLocation)1;
		changePassword.User = user;
		ChangePassword changePassword2 = changePassword;
		try
		{
			((Window)changePassword2).ShowDialog();
			IsAuthenticated = changePassword2.IsPasswordChangedSuccessful;
			AuthenticatedUser = changePassword2.User;
			if (changePassword2.IsPasswordChangedSuccessful)
			{
				if (((ToggleButton)rememberMe).IsChecked.Value)
				{
					WriteRememberMeFile(changePassword2.User);
				}
				else
				{
					RemoveRememberMeFile();
				}
				((Window)this).Close();
			}
		}
		catch (Exception exception)
		{
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
			Uri uri = new Uri("/TEZ_Project;component/users/login.xaml", UriKind.Relative);
			Application.LoadComponent((object)this, uri);
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	[EditorBrowsable(EditorBrowsableState.Never)]
	void IComponentConnector.Connect(int connectionId, object target)
	{
		//IL_0025: Unknown result type (might be due to invalid IL or missing references)
		//IL_002f: Expected O, but got Unknown
		//IL_0033: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Expected O, but got Unknown
		//IL_004a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0054: Expected O, but got Unknown
		//IL_0059: Unknown result type (might be due to invalid IL or missing references)
		//IL_0063: Expected O, but got Unknown
		//IL_0067: Unknown result type (might be due to invalid IL or missing references)
		//IL_0071: Expected O, but got Unknown
		//IL_0074: Unknown result type (might be due to invalid IL or missing references)
		//IL_0080: Unknown result type (might be due to invalid IL or missing references)
		//IL_008a: Expected O, but got Unknown
		switch (connectionId)
		{
		case 1:
			loginBox = (ComboBox)target;
			break;
		case 2:
			login = (Button)target;
			((ButtonBase)login).Click += new RoutedEventHandler(Button_Click);
			break;
		case 3:
			rememberMe = (CheckBox)target;
			break;
		case 4:
			passwordBox = (PasswordBox)target;
			break;
		case 5:
			((ButtonBase)(Button)target).Click += new RoutedEventHandler(ChangePassword_Click);
			break;
		default:
			_contentLoaded = true;
			break;
		}
	}
}
