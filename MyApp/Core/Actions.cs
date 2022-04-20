namespace MyApp.Core;

public static class Actions
{
    public static State Increment(this State state)
    {
        return state with
        {
            Counter = state.Counter + 1
        };
    }
}
