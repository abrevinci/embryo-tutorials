using MyApp.Core;
using MyApp.ViewModels;

namespace MyApp;

public class ViewModelFactory
{
	private readonly IObservable<State> _state;
	private readonly Action<Message> _dispatch;

	public ViewModelFactory(IObservable<State> state, Action<Message> dispatch)
	{
		_state = state;
		_dispatch = dispatch;
	}

	public MainWindowViewModel CreateMainWindowViewModel()
	{
		var counter = _state.Select(s => s.Counter);

		return new MainWindowViewModel(counter, _dispatch);
	}
}
