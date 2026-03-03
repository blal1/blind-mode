using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace YgomGame.Help;

[Serializable]
[Token(Token = "0x2000D92")]
public class HelpSectionGroupData
{
	[Token(Token = "0x4009F42")]
	[FieldOffset(Offset = "0x10")]
	public string label;

	[Token(Token = "0x4009F43")]
	[FieldOffset(Offset = "0x18")]
	public string titleTid;

	[Token(Token = "0x4009F44")]
	[FieldOffset(Offset = "0x20")]
	public bool visibleFromHelp;

	[Token(Token = "0x4009F45")]
	[FieldOffset(Offset = "0x28")]
	public List<HelpSectionData> sections;

	[Token(Token = "0x4009F46")]
	[FieldOffset(Offset = "0x30")]
	private Dictionary<string, HelpSectionData> m_SectionMap;

	[Token(Token = "0x6005190")]
	[Address(RVA = "0x990860", Offset = "0x98FA60", VA = "0x180990860")]
	public HelpSectionData GetSectionData(string sectionLabel)
	{
		return null;
	}

	[Token(Token = "0x6005191")]
	[Address(RVA = "0x990A50", Offset = "0x98FC50", VA = "0x180990A50")]
	public HelpSectionGroupData()
	{
	}
}
