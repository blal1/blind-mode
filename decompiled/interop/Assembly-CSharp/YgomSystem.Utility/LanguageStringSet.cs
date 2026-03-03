using System.Collections.Generic;
using Il2CppDummyDll;

namespace YgomSystem.Utility;

[Token(Token = "0x20003E7")]
internal class LanguageStringSet
{
	[Token(Token = "0x400138B")]
	[FieldOffset(Offset = "0x10")]
	private Dictionary<string, string> m_strs;

	[Token(Token = "0x6001908")]
	[Address(RVA = "0x5CEDD0", Offset = "0x5CDFD0", VA = "0x1805CEDD0")]
	public LanguageStringSet()
	{
	}

	[Token(Token = "0x6001909")]
	[Address(RVA = "0x5CEA30", Offset = "0x5CDC30", VA = "0x1805CEA30")]
	public void Clear()
	{
	}

	[Token(Token = "0x600190A")]
	[Address(RVA = "0x5CEB40", Offset = "0x5CDD40", VA = "0x1805CEB40")]
	public string GetString(string lang)
	{
		return null;
	}

	[Token(Token = "0x600190B")]
	[Address(RVA = "0x5CEBE0", Offset = "0x5CDDE0", VA = "0x1805CEBE0")]
	public void Import(Dictionary<string, object> KeyValue)
	{
	}

	[Token(Token = "0x600190C")]
	[Address(RVA = "0x5CEA80", Offset = "0x5CDC80", VA = "0x1805CEA80")]
	public static LanguageStringSet Create(Dictionary<string, object> KeyValue)
	{
		return null;
	}
}
