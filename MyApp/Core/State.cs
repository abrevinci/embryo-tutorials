namespace MyApp.Core;

public record State(int Counter)
{
	public static readonly State InitialState = new(0);
}
