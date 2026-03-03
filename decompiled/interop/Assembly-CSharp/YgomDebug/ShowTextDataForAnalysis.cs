using System;
using Il2CppDummyDll;
using YgomGame.Duel;

namespace YgomDebug;

[Serializable]
[Token(Token = "0x2000137")]
public struct ShowTextDataForAnalysis
{
	[Token(Token = "0x4000779")]
	[FieldOffset(Offset = "0x0")]
	public short textid;

	[Token(Token = "0x400077A")]
	[FieldOffset(Offset = "0x2")]
	public bool indent;

	[Token(Token = "0x60007E9")]
	[Address(RVA = "0x9E5550", Offset = "0x9E4750", VA = "0x1809E5550")]
	public ShowTextDataForAnalysis(ShowTextData showTextData)
	{
	}
}
