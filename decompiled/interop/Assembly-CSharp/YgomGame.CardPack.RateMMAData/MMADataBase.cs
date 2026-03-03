using System.Collections.Generic;
using Il2CppDummyDll;
using YgomGame.MDMarkup;

namespace YgomGame.CardPack.RateMMAData;

[Token(Token = "0x2001530")]
public abstract class MMADataBase : IMMAData
{
	[Token(Token = "0x400CB95")]
	[FieldOffset(Offset = "0x10")]
	public int indent;

	[Token(Token = "0x600830A")]
	[Address(RVA = "0x670FF0", Offset = "0x6701F0", VA = "0x180670FF0")]
	public MMADataBase()
	{
	}

	[Token(Token = "0x600830B")]
	[Address(RVA = "0xCBF4B0", Offset = "0xCBE6B0", VA = "0x180CBF4B0")]
	public MMADataBase(Dictionary<string, object> sourceDic)
	{
	}

	[Token(Token = "0x600830C")]
	public abstract IMDMarkupContent OutputContent();
}
