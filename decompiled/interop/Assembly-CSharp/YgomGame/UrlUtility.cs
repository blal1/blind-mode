using System.Diagnostics;
using Il2CppDummyDll;
using YgomSystem.Utility;

namespace YgomGame;

[Token(Token = "0x2000709")]
public static class UrlUtility
{
	[Token(Token = "0x400232B")]
	[FieldOffset(Offset = "0x0")]
	private static string s_enquiryUrl;

	[Token(Token = "0x400232C")]
	[FieldOffset(Offset = "0x8")]
	private static string s_tokushouhouUrl;

	[Token(Token = "0x400232D")]
	[FieldOffset(Offset = "0x10")]
	private static LanguageStringSet s_androidAdUrl;

	[Token(Token = "0x400232E")]
	[FieldOffset(Offset = "0x18")]
	private static string s_helpUrl;

	[Token(Token = "0x6002E8C")]
	[Address(RVA = "0x728760", Offset = "0x727960", VA = "0x180728760")]
	public static string GetKonamiComUrl()
	{
		return null;
	}

	[Token(Token = "0x6002E8D")]
	[Address(RVA = "0x7286C0", Offset = "0x7278C0", VA = "0x1807286C0")]
	public static string GetEnquiryUrl()
	{
		return null;
	}

	[Token(Token = "0x6002E8E")]
	[Address(RVA = "0x728790", Offset = "0x727990", VA = "0x180728790")]
	public static string GetTokushouhouUrl()
	{
		return null;
	}

	[Token(Token = "0x6002E8F")]
	[Address(RVA = "0x7285D0", Offset = "0x7277D0", VA = "0x1807285D0")]
	public static string GetAndroidAdAttentionUrl()
	{
		return null;
	}

	[Token(Token = "0x6002E90")]
	[Address(RVA = "0x728710", Offset = "0x727910", VA = "0x180728710")]
	public static string GetHelpUrl()
	{
		return null;
	}

	[Token(Token = "0x6002E91")]
	[Address(RVA = "0x7287E0", Offset = "0x7279E0", VA = "0x1807287E0")]
	public static void ImportUrls(object value)
	{
	}

	[Token(Token = "0x6002E92")]
	[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60")]
	[Conditional("ENABLE_DEBUG_LOG")]
	private static void debugLog(string msg)
	{
	}
}
