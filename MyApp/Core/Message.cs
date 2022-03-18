namespace MyApp.Core;

public abstract record Message
{
	// prevent external inheritance
	private Message() {}
}
