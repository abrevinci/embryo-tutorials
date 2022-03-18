using AbreVinci.Embryo.App;
using AbreVinci.Embryo.ReactiveUI;
using AbreVinci.Embryo.WPF;
using MyApp.Core;

namespace MyApp;

public static class EntryPoint
{
	[STAThread]
	public static void Main(string[] commandLineArguments)
	{
		var application = new Application();
		var scheduler = new UiScheduler(application.Dispatcher);

		var program = Program.Create<State, Message>(Reducer.Init, Reducer.Update, scheduler);

		var viewModelFactory = new ViewModelFactory(program.States, program.DispatchMessage);
		var viewModelHost = new ReactiveViewModelHost(scheduler, false);
		var windowFactory = new WindowFactory();
		using var userInterface = new UserInterface(viewModelFactory, viewModelHost, windowFactory);

		application.Run();
	}
}
