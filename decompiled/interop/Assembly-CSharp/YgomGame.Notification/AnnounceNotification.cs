using Il2CppDummyDll;

namespace YgomGame.Notification;

[Token(Token = "0x2000C36")]
public class AnnounceNotification : HomeAnnounceBehaviourBase
{
	[Token(Token = "0x4009A93")]
	private const string FORCE_NOTIFY_SAVE_PATH = "LastForceNotify";

	[Token(Token = "0x6004A99")]
	[Address(RVA = "0x930B90", Offset = "0x92FD90", VA = "0x180930B90", Slot = "5")]
	public override bool IsOpen()
	{
		return default(bool);
	}

	[Token(Token = "0x6004A9A")]
	[Address(RVA = "0x930BE0", Offset = "0x92FDE0", VA = "0x180930BE0", Slot = "4")]
	public override void Open()
	{
	}

	[Token(Token = "0x6004A9B")]
	[Address(RVA = "0x3C7110", Offset = "0x3C6310", VA = "0x1803C7110")]
	public AnnounceNotification()
	{
	}
}
