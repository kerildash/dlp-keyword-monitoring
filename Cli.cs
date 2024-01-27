namespace DlpSecurity;

internal class Cli(Messenger messenger)
{
	internal void Run()
	{
		Console.WriteLine("Write a message:");
		string? message = Console.ReadLine();
		Console.WriteLine(Send(message));
		Console.ReadKey();
	}
	internal string Send(string? message) =>
		messenger.Send(message) ? "Message has been sent" : "Failed to send message";
}