using Il2CppDummyDll;

namespace YgomGame.Notification;

[Token(Token = "0x2000C3A")]
public abstract class HomeAnnounceBehaviourBase
{
	[Token(Token = "0x6004AA1")]
	public abstract void Open();

	[Token(Token = "0x6004AA2")]
	public abstract bool IsOpen();

	[Token(Token = "0x6004AA3")]
	[Address(RVA = "0x3C7110", Offset = "0x3C6310", VA = "0x1803C7110")]
	protected HomeAnnounceBehaviourBase()
	{
	}
}
