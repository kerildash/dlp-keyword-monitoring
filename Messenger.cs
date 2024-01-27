namespace DlpSecurity;

internal class Messenger(Security security)
{
	/// <returns>true if message sent, false if failed to send message</returns>
	internal bool Send(string? message)
	{
		if (message is null)
		{
			return false;
		}
		if (security.Filter(message))
		{
			return false;
		}
		// send message code here
		return true;
	} 
}