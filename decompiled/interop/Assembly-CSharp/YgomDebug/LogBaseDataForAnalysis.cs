using System;
using Il2CppDummyDll;
using YgomGame.Duel;

namespace YgomDebug;

[Serializable]
[Token(Token = "0x2000128")]
public struct LogBaseDataForAnalysis
{
	[Token(Token = "0x4000717")]
	[FieldOffset(Offset = "0x0")]
	public string loglabel;

	[Token(Token = "0x4000718")]
	[FieldOffset(Offset = "0x8")]
	public int dataindex;

	[Token(Token = "0x6000787")]
	[Address(RVA = "0x9D5320", Offset = "0x9D4520", VA = "0x1809D5320")]
	public LogBaseDataForAnalysis(LogBaseData logBaseData)
	{
	}
}
