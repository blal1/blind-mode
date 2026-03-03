using Il2CppDummyDll;

namespace Unity.Collections;

[Token(Token = "0x2000062")]
[GenerateTestsForBurstCompatibility]
public struct Unicode
{
	[Token(Token = "0x2000063")]
	[GenerateTestsForBurstCompatibility]
	public struct Rune
	{
		[Token(Token = "0x40001C6")]
		[FieldOffset(Offset = "0x0")]
		public int value;

		[Token(Token = "0x6000168")]
		[Address(RVA = "0x22FCEE0", Offset = "0x22FC0E0", VA = "0x1822FCEE0", Slot = "0")]
		[ExcludeFromBurstCompatTesting("Takes managed object")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Token(Token = "0x6000169")]
		[Address(RVA = "0x8C8B50", Offset = "0x8C7D50", VA = "0x1808C8B50", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}
	}

	[Token(Token = "0x17000040")]
	public static Rune ReplacementCharacter
	{
		[Token(Token = "0x6000164")]
		[Address(RVA = "0x22FD410", Offset = "0x22FC610", VA = "0x1822FD410")]
		get
		{
			return default(Rune);
		}
	}

	[Token(Token = "0x6000162")]
	[Address(RVA = "0x22FD000", Offset = "0x22FC200", VA = "0x1822FD000")]
	public static bool IsValidCodePoint(int codepoint)
	{
		return default(bool);
	}

	[Token(Token = "0x6000163")]
	[Address(RVA = "0x22FD010", Offset = "0x22FC210", VA = "0x1822FD010")]
	public static bool NotTrailer(byte b)
	{
		return default(bool);
	}

	[Token(Token = "0x6000165")]
	[Address(RVA = "0x22FD0C0", Offset = "0x22FC2C0", VA = "0x1822FD0C0")]
	public unsafe static ConversionError Utf8ToUcs(out Rune rune, byte* buffer, ref int index, int capacity)
	{
		return default(ConversionError);
	}

	[Token(Token = "0x6000166")]
	[Address(RVA = "0x22FD020", Offset = "0x22FC220", VA = "0x1822FD020")]
	public unsafe static ConversionError UcsToUtf16(char* buffer, ref int index, int capacity, Rune rune)
	{
		return default(ConversionError);
	}

	[Token(Token = "0x6000167")]
	[Address(RVA = "0x22FD310", Offset = "0x22FC510", VA = "0x1822FD310")]
	public unsafe static ConversionError Utf8ToUtf16(byte* utf8Buffer, int utf8Length, char* utf16Buffer, out int utf16Length, int utf16Capacity)
	{
		return default(ConversionError);
	}
}
