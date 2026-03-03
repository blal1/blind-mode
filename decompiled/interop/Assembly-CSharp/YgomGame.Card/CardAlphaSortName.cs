using System.Collections.Generic;
using Il2CppDummyDll;

namespace YgomGame.Card;

[Token(Token = "0x20015E2")]
public class CardAlphaSortName
{
	[Token(Token = "0x20015E3")]
	private class SortNameInfo
	{
		[Token(Token = "0x400D00B")]
		[FieldOffset(Offset = "0x10")]
		public int mrk;

		[Token(Token = "0x400D00C")]
		[FieldOffset(Offset = "0x18")]
		public string sortName;

		[Token(Token = "0x400D00D")]
		[FieldOffset(Offset = "0x20")]
		public string fixedSortName;

		[Token(Token = "0x60087E6")]
		[Address(RVA = "0x3C7110", Offset = "0x3C6310", VA = "0x1803C7110")]
		public SortNameInfo()
		{
		}
	}

	[Token(Token = "0x400D00A")]
	[FieldOffset(Offset = "0x10")]
	private Dictionary<int, SortNameInfo> m_sortNameInfos;

	[Token(Token = "0x60087E2")]
	[Address(RVA = "0xCFC740", Offset = "0xCFB940", VA = "0x180CFC740")]
	public CardAlphaSortName(string assetPath)
	{
	}

	[Token(Token = "0x60087E3")]
	[Address(RVA = "0xCFC2E0", Offset = "0xCFB4E0", VA = "0x180CFC2E0")]
	public void SetSortName(byte[] bindata)
	{
	}

	[Token(Token = "0x60087E4")]
	[Address(RVA = "0xCFC230", Offset = "0xCFB430", VA = "0x180CFC230")]
	public string GetSortName(int mrk)
	{
		return null;
	}

	[Token(Token = "0x60087E5")]
	[Address(RVA = "0xCFC180", Offset = "0xCFB380", VA = "0x180CFC180")]
	public string GetFixedSortName(int mrk)
	{
		return null;
	}
}
