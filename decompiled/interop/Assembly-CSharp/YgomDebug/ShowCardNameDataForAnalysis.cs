using System;
using Il2CppDummyDll;
using YgomGame.Duel;

namespace YgomDebug;

[Serializable]
[Token(Token = "0x200012E")]
public struct ShowCardNameDataForAnalysis
{
	[Token(Token = "0x400075A")]
	[FieldOffset(Offset = "0x0")]
	public short cardid;

	[Token(Token = "0x400075B")]
	[FieldOffset(Offset = "0x2")]
	public bool team;

	[Token(Token = "0x400075C")]
	[FieldOffset(Offset = "0x3")]
	public bool indent;

	[Token(Token = "0x60007D6")]
	[Address(RVA = "0x9E5500", Offset = "0x9E4700", VA = "0x1809E5500")]
	public ShowCardNameDataForAnalysis(ShowCardNameData showCardNameData)
	{
	}
}
