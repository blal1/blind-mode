using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace YgomGame.Card;

[Token(Token = "0x20015E4")]
public class CardCategoryData
{
	[Token(Token = "0x20015E5")]
	public class Category
	{
		[Token(Token = "0x400D010")]
		[FieldOffset(Offset = "0x10")]
		public readonly int id;

		[Token(Token = "0x400D011")]
		[FieldOffset(Offset = "0x18")]
		public readonly Dictionary<string, string> globalNameMap;

		[Token(Token = "0x60087EB")]
		[Address(RVA = "0x500960", Offset = "0x4FFB60", VA = "0x180500960")]
		public Category(int id, Dictionary<string, string> globalNameMap)
		{
		}

		[Token(Token = "0x60087EC")]
		[Address(RVA = "0xD0DE10", Offset = "0xD0D010", VA = "0x180D0DE10")]
		public string GetName()
		{
			return null;
		}
	}

	[Token(Token = "0x400D00E")]
	private const string k_SnapshotPath = "External/CardCategory/CardCategory";

	[Token(Token = "0x400D00F")]
	[FieldOffset(Offset = "0x10")]
	private Dictionary<int, Category> m_CategoryMap;

	[Token(Token = "0x170014E6")]
	public IReadOnlyDictionary<int, Category> categoryMap
	{
		[Token(Token = "0x60087E7")]
		[Address(RVA = "0x40C440", Offset = "0x40B640", VA = "0x18040C440")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x60087E8")]
	[Address(RVA = "0xCFCC70", Offset = "0xCFBE70", VA = "0x180CFCC70")]
	public static void LoadAsync(Action<CardCategoryData> onComplete)
	{
	}

	[Token(Token = "0x60087E9")]
	[Address(RVA = "0xCFC7C0", Offset = "0xCFB9C0", VA = "0x180CFC7C0")]
	public void Import(List<object> snapshotDatas)
	{
	}

	[Token(Token = "0x60087EA")]
	[Address(RVA = "0xCFCD70", Offset = "0xCFBF70", VA = "0x180CFCD70")]
	public CardCategoryData()
	{
	}
}
