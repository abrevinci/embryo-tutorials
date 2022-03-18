using AbreVinci.Embryo.ReactiveUI;
using MyApp.ViewModels;

namespace MyApp;

public class UserInterface : ReactiveUserInterface
{
	public UserInterface(
		ViewModelFactory viewModelFactory,
		IReactiveViewModelHost viewModelHost,
		IReactiveWindowFactory windowFactory) : base(viewModelHost, windowFactory)
	{
		MainWindow = AddWindow(nameof(MainWindow), viewModelFactory.CreateMainWindowViewModel);
	}

	public IReactiveWindowController<MainWindowViewModel> MainWindow { get; }
}
