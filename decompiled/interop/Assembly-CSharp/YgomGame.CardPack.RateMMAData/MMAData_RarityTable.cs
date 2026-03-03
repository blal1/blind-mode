using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using YgomGame.MDMarkup;

namespace YgomGame.CardPack.RateMMAData;

[Token(Token = "0x2001534")]
public class MMAData_RarityTable : MMADataBase
{
	[Serializable]
	[Token(Token = "0x2001535")]
	public class Data
	{
		[Token(Token = "0x400CB9D")]
		[FieldOffset(Offset = "0x10")]
		public int rare;

		[Token(Token = "0x400CB9E")]
		[FieldOffset(Offset = "0x18")]
		public string rate;

		[Token(Token = "0x400CB9F")]
		[FieldOffset(Offset = "0x20")]
		public int num;

		[Token(Token = "0x400CBA0")]
		[FieldOffset(Offset = "0x28")]
		public string perpiece;

		[Token(Token = "0x6008317")]
		[Address(RVA = "0x3C7110", Offset = "0x3C6310", VA = "0x1803C7110")]
		public Data()
		{
		}
	}

	[Token(Token = "0x400CB9B")]
	internal const string k_TP = "rarityTable";

	[Token(Token = "0x400CB9C")]
	[FieldOffset(Offset = "0x18")]
	public Data[] datas;

	[Token(Token = "0x6008314")]
	[Address(RVA = "0x670FF0", Offset = "0x6701F0", VA = "0x180670FF0")]
	public MMAData_RarityTable()
	{
	}

	[Token(Token = "0x6008315")]
	[Address(RVA = "0xCC16A0", Offset = "0xCC08A0", VA = "0x180CC16A0")]
	public MMAData_RarityTable(Dictionary<string, object> sourceDic)
	{
	}

	[Token(Token = "0x6008316")]
	[Address(RVA = "0xCC0530", Offset = "0xCBF730", VA = "0x180CC0530", Slot = "5")]
	public override IMDMarkupContent OutputContent()
	{
		return null;
	}
}
