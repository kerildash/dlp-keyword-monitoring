namespace DlpSecurity;

internal static class Program
{
	private static readonly Cli _cli = new Cli(new Messenger(new Security(new Repository())));
	internal static void Main()
	{
		_cli.Run();
	}
}
