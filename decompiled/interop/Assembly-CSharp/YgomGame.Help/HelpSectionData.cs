using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace YgomGame.Help;

[Serializable]
[Token(Token = "0x2000D91")]
public class HelpSectionData
{
	[Token(Token = "0x4009F3E")]
	[FieldOffset(Offset = "0x10")]
	public string label;

	[Token(Token = "0x4009F3F")]
	[FieldOffset(Offset = "0x18")]
	public string titleTid;

	[Token(Token = "0x4009F40")]
	[FieldOffset(Offset = "0x20")]
	public List<HelpRecordData> records;

	[Token(Token = "0x4009F41")]
	[FieldOffset(Offset = "0x28")]
	private Dictionary<string, HelpRecordData> m_RecordMap;

	[Token(Token = "0x600518E")]
	[Address(RVA = "0x990560", Offset = "0x98F760", VA = "0x180990560")]
	public HelpRecordData GetRecordData(string recordLabel)
	{
		return null;
	}

	[Token(Token = "0x600518F")]
	[Address(RVA = "0x990760", Offset = "0x98F960", VA = "0x180990760")]
	public HelpSectionData()
	{
	}
}
