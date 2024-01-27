namespace DlpSecurity;

internal class Security(Repository repo)
{
	internal bool Filter(string message) => repo.Contains(message);
}
