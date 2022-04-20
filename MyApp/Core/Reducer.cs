namespace MyApp.Core;

public static class Reducer
{
	public static State Init() => State.InitialState;

	public static State Update(this State state, Message message)
	{
		return message switch
		{
			Message.Increment => state.Increment(),
			_ => state
		};
	}
}
