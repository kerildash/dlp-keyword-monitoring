namespace DlpSecurity;

internal class Repository
{
	private readonly string[] _words;
	internal Repository()
	{
		_words = [
			"тайна",
			"шанс",
			"секрет"
		];
	}
	internal bool Contains(string message) => _words.Any(message.Contains);
}
