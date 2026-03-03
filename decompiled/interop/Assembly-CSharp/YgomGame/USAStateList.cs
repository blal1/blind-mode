using System.Collections.Generic;
using Il2CppDummyDll;

namespace YgomGame;

[Token(Token = "0x200070B")]
public class USAStateList
{
	[Token(Token = "0x4002333")]
	[FieldOffset(Offset = "0x10")]
	private List<USAStateData> m_list;

	[Token(Token = "0x6002E95")]
	[Address(RVA = "0x3C7110", Offset = "0x3C6310", VA = "0x1803C7110")]
	private USAStateList()
	{
	}

	[Token(Token = "0x6002E96")]
	[Address(RVA = "0x727E20", Offset = "0x727020", VA = "0x180727E20")]
	private void initialize(string lang, string[] exclusionCodes)
	{
	}

	[Token(Token = "0x6002E97")]
	[Address(RVA = "0x727B70", Offset = "0x726D70", VA = "0x180727B70")]
	public USAStateData GetDataByNumeric(int numeric)
	{
		return null;
	}

	[Token(Token = "0x6002E98")]
	[Address(RVA = "0x727D40", Offset = "0x726F40", VA = "0x180727D40")]
	public int[] GetNumericList()
	{
		return null;
	}

	[Token(Token = "0x6002E99")]
	[Address(RVA = "0x727C40", Offset = "0x726E40", VA = "0x180727C40")]
	public string[] GetDisplayList()
	{
		return null;
	}

	[Token(Token = "0x6002E9A")]
	[Address(RVA = "0x727B00", Offset = "0x726D00", VA = "0x180727B00")]
	public static USAStateList Create(string lang)
	{
		return null;
	}

	[Token(Token = "0x6002E9B")]
	[Address(RVA = "0x727A80", Offset = "0x726C80", VA = "0x180727A80")]
	public static USAStateList CreateWithExclusions(string lang, string[] exclusions)
	{
		return null;
	}
}
