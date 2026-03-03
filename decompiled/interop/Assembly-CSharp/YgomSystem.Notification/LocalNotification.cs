using System.Diagnostics;
using Il2CppDummyDll;

namespace YgomSystem.Notification;

[Token(Token = "0x200023E")]
public static class LocalNotification
{
	[Token(Token = "0x4000B76")]
	[FieldOffset(Offset = "0x0")]
	private static ILocalNotification instance;

	[Token(Token = "0x6000D46")]
	[Address(RVA = "0xD393D0", Offset = "0xD385D0", VA = "0x180D393D0")]
	static LocalNotification()
	{
	}

	[Token(Token = "0x6000D47")]
	[Address(RVA = "0xD39350", Offset = "0xD38550", VA = "0x180D39350")]
	[Conditional("UNUSED_NOTIFICATION_METHOD")]
	public static void Initialize()
	{
	}

	[Token(Token = "0x6000D48")]
	[Address(RVA = "0xD392D0", Offset = "0xD384D0", VA = "0x180D392D0")]
	[Conditional("UNUSED_NOTIFICATION_METHOD")]
	public static void AllClear()
	{
	}
}
