using AbreVinci.Embryo.ReactiveUI;
using MyApp.Core;

namespace MyApp.ViewModels;

public class MainWindowViewModel : ReactiveViewModel
{
    private readonly IReactiveOneWayBinding<int> _counter;

    public MainWindowViewModel(IObservable<int> counter, Action<Message> dispatch)
    {
        _counter = CreateOneWayBinding(counter, nameof(Counter));
        Increment = BindCommand(() => dispatch(new Message.Increment()));
    }

    public int Counter => _counter.Value;
    public ICommand Increment { get; }
}
