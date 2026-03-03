using System.Collections.Generic;
using Il2CppDummyDll;

namespace YgomGame;

[Token(Token = "0x20006FC")]
public class CountryList
{
	[Token(Token = "0x4002310")]
	[FieldOffset(Offset = "0x10")]
	private List<CountryData> m_list;

	[Token(Token = "0x4002311")]
	[FieldOffset(Offset = "0x18")]
	private CountryData m_otherData;

	[Token(Token = "0x4002312")]
	[FieldOffset(Offset = "0x20")]
	private CountryData m_defaultData;

	[Token(Token = "0x6002E54")]
	[Address(RVA = "0x3C7110", Offset = "0x3C6310", VA = "0x1803C7110")]
	private CountryList()
	{
	}

	[Token(Token = "0x6002E55")]
	[Address(RVA = "0x71A090", Offset = "0x719290", VA = "0x18071A090")]
	private void initialize(string lang)
	{
	}

	[Token(Token = "0x6002E56")]
	[Address(RVA = "0x3D8370", Offset = "0x3D7570", VA = "0x1803D8370")]
	public CountryData GetDefault()
	{
		return null;
	}

	[Token(Token = "0x6002E57")]
	[Address(RVA = "0x719DD0", Offset = "0x718FD0", VA = "0x180719DD0")]
	public CountryData GetDataByNumeric(int numeric)
	{
		return null;
	}

	[Token(Token = "0x6002E58")]
	[Address(RVA = "0x719CD0", Offset = "0x718ED0", VA = "0x180719CD0")]
	public CountryData GetDataByAlpha2(string alpha2)
	{
		return null;
	}

	[Token(Token = "0x6002E59")]
	[Address(RVA = "0x719FB0", Offset = "0x7191B0", VA = "0x180719FB0")]
	public int[] GetNumericList()
	{
		return null;
	}

	[Token(Token = "0x6002E5A")]
	[Address(RVA = "0x719BD0", Offset = "0x718DD0", VA = "0x180719BD0")]
	public string[] GetAlpha2List()
	{
		return null;
	}

	[Token(Token = "0x6002E5B")]
	[Address(RVA = "0x719EB0", Offset = "0x7190B0", VA = "0x180719EB0")]
	public string[] GetDisplayList()
	{
		return null;
	}

	[Token(Token = "0x6002E5C")]
	[Address(RVA = "0x719B60", Offset = "0x718D60", VA = "0x180719B60")]
	public static CountryList Create(string lang)
	{
		return null;
	}
}
