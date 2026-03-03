using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace YgomSystem;

[Token(Token = "0x200015A")]
public static class DataLinkUtil
{
	[Token(Token = "0x6000895")]
	[Address(RVA = "0xAF2840", Offset = "0xAF1A40", VA = "0x180AF2840")]
	private static string getInheritLimitTextFromCW(string key)
	{
		return null;
	}

	[Token(Token = "0x6000896")]
	[Address(RVA = "0xAF2800", Offset = "0xAF1A00", VA = "0x180AF2800")]
	public static string GetLimitNoticeText()
	{
		return null;
	}

	[Token(Token = "0x6000897")]
	[Address(RVA = "0xAF2690", Offset = "0xAF1890", VA = "0x180AF2690")]
	public static string GetInheritSuccessText([Optional] Func<string> getDefaultText)
	{
		return null;
	}

	[Token(Token = "0x6000898")]
	[Address(RVA = "0xAF2600", Offset = "0xAF1800", VA = "0x180AF2600")]
	public static string GetInheritLimitErrorText()
	{
		return null;
	}
}
