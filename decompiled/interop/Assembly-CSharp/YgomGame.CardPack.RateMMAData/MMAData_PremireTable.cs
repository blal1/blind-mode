using System.Collections.Generic;
using Il2CppDummyDll;
using YgomGame.MDMarkup;

namespace YgomGame.CardPack.RateMMAData;

[Token(Token = "0x2001532")]
public class MMAData_PremireTable : MMADataBase
{
	[Token(Token = "0x2001533")]
	public class Data
	{
		[Token(Token = "0x400CB99")]
		[FieldOffset(Offset = "0x10")]
		public int premire;

		[Token(Token = "0x400CB9A")]
		[FieldOffset(Offset = "0x18")]
		public string rate;

		[Token(Token = "0x6008313")]
		[Address(RVA = "0x3C7110", Offset = "0x3C6310", VA = "0x1803C7110")]
		public Data()
		{
		}
	}

	[Token(Token = "0x400CB97")]
	internal const string k_TP = "premiereTable";

	[Token(Token = "0x400CB98")]
	[FieldOffset(Offset = "0x18")]
	public Data[] datas;

	[Token(Token = "0x6008310")]
	[Address(RVA = "0x670FF0", Offset = "0x6701F0", VA = "0x180670FF0")]
	public MMAData_PremireTable()
	{
	}

	[Token(Token = "0x6008311")]
	[Address(RVA = "0xCC02B0", Offset = "0xCBF4B0", VA = "0x180CC02B0")]
	public MMAData_PremireTable(Dictionary<string, object> sourceDic)
	{
	}

	[Token(Token = "0x6008312")]
	[Address(RVA = "0xCBF5E0", Offset = "0xCBE7E0", VA = "0x180CBF5E0", Slot = "5")]
	public override IMDMarkupContent OutputContent()
	{
		return null;
	}
}
