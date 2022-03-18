namespace MyApp.Core;

public static class Reducer
{
	public static State Init() => State.InitialState;

	public static State Update(this State state, Message message)
	{
		return message switch
		{
			// Todo: Add your switch cases here
			_ => state
		};
	}
}
