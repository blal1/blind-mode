using Il2CppDummyDll;

namespace YgomSystem;

[Token(Token = "0x200017D")]
public class SteamAchievement
{
	[Token(Token = "0x200017E")]
	public enum ID
	{
		[Token(Token = "0x400090F")]
		jp_konami_masterduel_ach_001,
		[Token(Token = "0x4000910")]
		jp_konami_masterduel_ach_002,
		[Token(Token = "0x4000911")]
		jp_konami_masterduel_ach_003,
		[Token(Token = "0x4000912")]
		jp_konami_masterduel_ach_004,
		[Token(Token = "0x4000913")]
		jp_konami_masterduel_ach_005,
		[Token(Token = "0x4000914")]
		jp_konami_masterduel_ach_006,
		[Token(Token = "0x4000915")]
		jp_konami_masterduel_ach_007,
		[Token(Token = "0x4000916")]
		jp_konami_masterduel_ach_008,
		[Token(Token = "0x4000917")]
		jp_konami_masterduel_ach_009,
		[Token(Token = "0x4000918")]
		jp_konami_masterduel_ach_010,
		[Token(Token = "0x4000919")]
		jp_konami_masterduel_ach_011
	}

	[Token(Token = "0x400090C")]
	[FieldOffset(Offset = "0x0")]
	private static bool enable_notificator;

	[Token(Token = "0x400090D")]
	[FieldOffset(Offset = "0x8")]
	private static readonly string id_convert_format;

	[Token(Token = "0x60009A7")]
	[Address(RVA = "0xB080B0", Offset = "0xB072B0", VA = "0x180B080B0")]
	public static void SetNotificator()
	{
	}

	[Token(Token = "0x60009A8")]
	[Address(RVA = "0xB07FB0", Offset = "0xB071B0", VA = "0x180B07FB0")]
	public static void ReleaseNotificator()
	{
	}

	[Token(Token = "0x60009A9")]
	[Address(RVA = "0xB07D40", Offset = "0xB06F40", VA = "0x180B07D40")]
	public static void OnAchievementDone(object value)
	{
	}

	[Token(Token = "0x60009AA")]
	[Address(RVA = "0xB08200", Offset = "0xB07400", VA = "0x180B08200")]
	public static void Store()
	{
	}

	[Token(Token = "0x60009AB")]
	[Address(RVA = "0xB081B0", Offset = "0xB073B0", VA = "0x180B081B0")]
	public static void ShowUI()
	{
	}

	[Token(Token = "0x60009AC")]
	[Address(RVA = "0xB07F50", Offset = "0xB07150", VA = "0x180B07F50")]
	public static void Progress(string param, string id, uint cursor, uint max)
	{
	}

	[Token(Token = "0x60009AD")]
	[Address(RVA = "0xB082D0", Offset = "0xB074D0", VA = "0x180B082D0")]
	public static void Unlock(string id)
	{
	}

	[Token(Token = "0x60009AE")]
	[Address(RVA = "0xB08220", Offset = "0xB07420", VA = "0x180B08220")]
	public static void Unlock(ID id)
	{
	}

	[Token(Token = "0x60009AF")]
	[Address(RVA = "0x3C7110", Offset = "0x3C6310", VA = "0x1803C7110")]
	public SteamAchievement()
	{
	}
}
