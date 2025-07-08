using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Markup;

namespace TEZ_Project;

public class Prompt : Window, IComponentConnector
{
	internal TextBox TextBox1;

	private bool _contentLoaded;

	public string Value => TextBox1.Text;

	public Prompt()
	{
		InitializeComponent();
	}

	private void Button_Click(object sender, RoutedEventArgs e)
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
			Uri uri = new Uri("/TEZ_Project;component/prompt.xaml", UriKind.Relative);
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
			TextBox1 = (TextBox)target;
			break;
		case 2:
			((ButtonBase)(Button)target).Click += new RoutedEventHandler(Button_Click);
			break;
		default:
			_contentLoaded = true;
			break;
		}
	}
}
