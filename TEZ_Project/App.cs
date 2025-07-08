using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Windows;
using log4net;
using log4net.Config;

namespace TEZ_Project;

public class App : Application
{
	private static readonly ILog log = LogManager.GetLogger(typeof(App));

	protected override void OnStartup(StartupEventArgs e)
	{
		XmlConfigurator.Configure();
		log.Info("        =============  Started Logging  =============        ");
		base.OnStartup(e);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	public void InitializeComponent()
	{
		((Application)this).StartupUri = new Uri("MainWindow.xaml", UriKind.Relative);
	}

	[STAThread]
	[DebuggerNonUserCode]
	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	public static void Main()
	{
		App app = new App();
		app.InitializeComponent();
		((Application)app).Run();
	}
}
