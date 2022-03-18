using AbreVinci.Embryo.WPF;

namespace MyApp;

public class WindowFactory : ReactiveWindowFactory
{
	public WindowFactory()
	{
		RegisterWindow(nameof(UserInterface.MainWindow), "MainWindowView", CreateMainWindow);
	}

	public ReactiveWindow CreateMainWindow()
	{
		return new ReactiveWindow
		{
			Title = "Hello Embryo!",
			Width = 600,
			Height = 400,
			WindowStartupLocation = WindowStartupLocation.CenterScreen
		};
	}
}
