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

public class ChangePassword : Window, IComponentConnector
{
	private User user;

	internal PasswordBox currentPasswordBox;

	internal PasswordBox newPasswordBox;

	internal PasswordBox newPasswordRepeatedBox;

	internal Label currentPasswordLabel;

	private bool _contentLoaded;

	public User User
	{
		get
		{
			return user;
		}
		set
		{
			if (value.IsPasswordReset)
			{
				((UIElement)currentPasswordBox).Visibility = (Visibility)2;
				((UIElement)currentPasswordLabel).Visibility = (Visibility)2;
			}
			user = value;
		}
	}

	public bool IsPasswordChangedSuccessful { get; set; }

	public ChangePassword()
	{
		InitializeComponent();
	}

	private void Button_Click(object sender, RoutedEventArgs e)
	{
		//IL_008c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0103: Unknown result type (might be due to invalid IL or missing references)
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		//IL_0053: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00de: Unknown result type (might be due to invalid IL or missing references)
		string password = currentPasswordBox.Password;
		string password2 = newPasswordBox.Password;
		string password3 = newPasswordRepeatedBox.Password;
		if (string.IsNullOrWhiteSpace(password2))
		{
			MessageBox.Show("Пароль надто простий");
			return;
		}
		if (password2 != password3)
		{
			MessageBox.Show("Новий пароль не співпадає");
			return;
		}
		if (User.IsPasswordReset)
		{
			try
			{
				UpdatePasword(password2);
				IsPasswordChangedSuccessful = true;
			}
			catch (Exception)
			{
				MessageBox.Show("Проблема з базою даних");
			}
		}
		else
		{
			if (!SecurePasswordHasher.Verify(password, User.Password))
			{
				MessageBox.Show("Неправильний пароль");
				return;
			}
			if (SecurePasswordHasher.Verify(password2, User.Password))
			{
				MessageBox.Show("Вкажіть новий пароль");
				return;
			}
			try
			{
				UpdatePasword(password2);
				IsPasswordChangedSuccessful = true;
			}
			catch (Exception)
			{
				MessageBox.Show("Проблема з базою даних");
			}
		}
		((Window)this).Close();
	}

	private void UpdatePasword(string newpassword)
	{
		using UnitOfWork unitOfWork = new UnitOfWork();
		User byId = unitOfWork.UserRepository.GetById(User.Id);
		byId.Password = SecurePasswordHasher.Hash(newpassword);
		byId.IsPasswordReset = false;
		unitOfWork.UserRepository.Update(byId);
		unitOfWork.Save();
		User = byId;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	public void InitializeComponent()
	{
		if (!_contentLoaded)
		{
			_contentLoaded = true;
			Uri uri = new Uri("/TEZ_Project;component/users/changepassword.xaml", UriKind.Relative);
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
		//IL_0041: Unknown result type (might be due to invalid IL or missing references)
		//IL_004b: Expected O, but got Unknown
		//IL_004e: Unknown result type (might be due to invalid IL or missing references)
		//IL_005a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0064: Expected O, but got Unknown
		//IL_0069: Unknown result type (might be due to invalid IL or missing references)
		//IL_0073: Expected O, but got Unknown
		switch (connectionId)
		{
		case 1:
			currentPasswordBox = (PasswordBox)target;
			break;
		case 2:
			newPasswordBox = (PasswordBox)target;
			break;
		case 3:
			newPasswordRepeatedBox = (PasswordBox)target;
			break;
		case 4:
			((ButtonBase)(Button)target).Click += new RoutedEventHandler(Button_Click);
			break;
		case 5:
			currentPasswordLabel = (Label)target;
			break;
		default:
			_contentLoaded = true;
			break;
		}
	}
}
