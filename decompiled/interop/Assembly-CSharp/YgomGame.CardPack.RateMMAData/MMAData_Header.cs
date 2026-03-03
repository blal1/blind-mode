using System.Collections.Generic;
using Il2CppDummyDll;
using YgomGame.MDMarkup;

namespace YgomGame.CardPack.RateMMAData;

[Token(Token = "0x2001531")]
public class MMAData_Header : MMAData_Text
{
	[Token(Token = "0x400CB96")]
	internal new const string k_TP = "header";

	[Token(Token = "0x600830D")]
	[Address(RVA = "0x670FF0", Offset = "0x6701F0", VA = "0x180670FF0")]
	public MMAData_Header()
	{
	}

	[Token(Token = "0x600830E")]
	[Address(RVA = "0xCBF5D0", Offset = "0xCBE7D0", VA = "0x180CBF5D0")]
	public MMAData_Header(Dictionary<string, object> sourceDic)
	{
	}

	[Token(Token = "0x600830F")]
	[Address(RVA = "0xCBF520", Offset = "0xCBE720", VA = "0x180CBF520", Slot = "5")]
	public override IMDMarkupContent OutputContent()
	{
		return null;
	}
}
