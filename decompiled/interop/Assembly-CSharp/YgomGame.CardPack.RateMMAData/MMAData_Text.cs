using System.Collections.Generic;
using Il2CppDummyDll;
using YgomGame.MDMarkup;

namespace YgomGame.CardPack.RateMMAData;

[Token(Token = "0x2001536")]
public class MMAData_Text : MMADataBase
{
	[Token(Token = "0x2001537")]
	public class Data
	{
		[Token(Token = "0x400CBA3")]
		[FieldOffset(Offset = "0x10")]
		public string textId;

		[Token(Token = "0x400CBA4")]
		[FieldOffset(Offset = "0x18")]
		public object[] args;

		[Token(Token = "0x600831C")]
		[Address(RVA = "0x3C7110", Offset = "0x3C6310", VA = "0x1803C7110")]
		public Data()
		{
		}

		[Token(Token = "0x600831D")]
		[Address(RVA = "0xCBDAB0", Offset = "0xCBCCB0", VA = "0x180CBDAB0")]
		public Data(Dictionary<string, object> sourceDic)
		{
		}

		[Token(Token = "0x600831E")]
		[Address(RVA = "0xCBD790", Offset = "0xCBC990", VA = "0x180CBD790")]
		public string OutputText()
		{
			return null;
		}
	}

	[Token(Token = "0x400CBA1")]
	internal const string k_TP = "text";

	[Token(Token = "0x400CBA2")]
	[FieldOffset(Offset = "0x18")]
	public Data[] datas;

	[Token(Token = "0x6008318")]
	[Address(RVA = "0x670FF0", Offset = "0x6701F0", VA = "0x180670FF0")]
	public MMAData_Text()
	{
	}

	[Token(Token = "0x6008319")]
	[Address(RVA = "0xCC1B20", Offset = "0xCC0D20", VA = "0x180CC1B20")]
	public MMAData_Text(Dictionary<string, object> sourceDic)
	{
	}

	[Token(Token = "0x600831A")]
	[Address(RVA = "0xCC1960", Offset = "0xCC0B60", VA = "0x180CC1960", Slot = "5")]
	public override IMDMarkupContent OutputContent()
	{
		return null;
	}

	[Token(Token = "0x600831B")]
	[Address(RVA = "0xCC19E0", Offset = "0xCC0BE0", VA = "0x180CC19E0")]
	protected string OutputText()
	{
		return null;
	}
}
