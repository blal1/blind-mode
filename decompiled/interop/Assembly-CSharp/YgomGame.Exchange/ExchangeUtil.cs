using System.Collections.Generic;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace YgomGame.Exchange;

[Token(Token = "0x2000DDC")]
public static class ExchangeUtil
{
	[Token(Token = "0x6005399")]
	[Address(RVA = "0x9A3FB0", Offset = "0x9A31B0", VA = "0x1809A3FB0")]
	public static bool ExistsCardPoolList(int exchangeId)
	{
		return default(bool);
	}

	[Token(Token = "0x600539A")]
	[Address(RVA = "0x9A4020", Offset = "0x9A3220", VA = "0x1809A4020")]
	public static bool OpenCardPoolList(int exchangeId, [Optional] Dictionary<string, object> args, [Optional] string title)
	{
		return default(bool);
	}

	[Token(Token = "0x600539B")]
	[Address(RVA = "0x9A47B0", Offset = "0x9A39B0", VA = "0x1809A47B0")]
	public static void OpenNotice(int exchangeId)
	{
	}
}
