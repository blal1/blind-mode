using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace YgomSystem.Utility;

[Token(Token = "0x200039B")]
public class AppInfo
{
	[Token(Token = "0x200039C")]
	public enum BootType
	{
		[Token(Token = "0x4001269")]
		StartUp,
		[Token(Token = "0x400126A")]
		ExitReboot,
		[Token(Token = "0x400126B")]
		TitleLoopReboot
	}

	[Token(Token = "0x200039D")]
	public enum AutoStartType
	{
		[Token(Token = "0x400126D")]
		Off,
		[Token(Token = "0x400126E")]
		GotoBoot,
		[Token(Token = "0x400126F")]
		GotoHome
	}

	[Token(Token = "0x4001263")]
	public const string AppIdentifier = "AMAA";

	[Token(Token = "0x4001264")]
	public const string SaveKeyPrefix = "YGOMD";

	[Token(Token = "0x4001265")]
	[FieldOffset(Offset = "0x0")]
	public static BootType bootType;

	[Token(Token = "0x4001267")]
	[FieldOffset(Offset = "0x5")]
	private static bool s_requestSafeMode;

	[Token(Token = "0x17000241")]
	public static bool isSafeMode
	{
		[Token(Token = "0x6001607")]
		[Address(RVA = "0x59FE20", Offset = "0x59F020", VA = "0x18059FE20")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6001608")]
		[Address(RVA = "0x59FE60", Offset = "0x59F060", VA = "0x18059FE60")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Token(Token = "0x6001606")]
	[Address(RVA = "0x59FDA0", Offset = "0x59EFA0", VA = "0x18059FDA0")]
	public static string GetSaveKey(string subkey)
	{
		return null;
	}

	[Token(Token = "0x6001609")]
	[Address(RVA = "0x59FDE0", Offset = "0x59EFE0", VA = "0x18059FDE0")]
	public static void RequestSafeMode()
	{
	}

	[Token(Token = "0x600160A")]
	[Address(RVA = "0x59FCF0", Offset = "0x59EEF0", VA = "0x18059FCF0")]
	public static void ApplySafeMode()
	{
	}

	[Token(Token = "0x600160B")]
	[Address(RVA = "0x3C7110", Offset = "0x3C6310", VA = "0x1803C7110")]
	public AppInfo()
	{
	}
}
