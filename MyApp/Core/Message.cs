namespace MyApp.Core;

public abstract record Message
{
	public sealed record Increment : Message;
	
	// prevent external inheritance
	private Message() {}
}
