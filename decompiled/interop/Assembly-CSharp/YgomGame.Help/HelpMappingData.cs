using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace YgomGame.Help;

[Serializable]
[Token(Token = "0x2000D8E")]
public class HelpMappingData
{
	[Token(Token = "0x4009F36")]
	public const string k_JsonPath = "Help/HelpMapping";

	[Token(Token = "0x4009F37")]
	[FieldOffset(Offset = "0x10")]
	[SerializeField]
	public List<HelpSectionGroupData> groups;

	[Token(Token = "0x4009F38")]
	[FieldOffset(Offset = "0x18")]
	private Dictionary<string, HelpSectionGroupData> m_SectionGroupMap;

	[Token(Token = "0x6005184")]
	[Address(RVA = "0x98FBE0", Offset = "0x98EDE0", VA = "0x18098FBE0")]
	public static void GetAsync(Action<HelpMappingData> onComplete)
	{
	}

	[Token(Token = "0x6005185")]
	[Address(RVA = "0x98FBA0", Offset = "0x98EDA0", VA = "0x18098FBA0")]
	public static HelpMappingData FromJson(string json)
	{
		return null;
	}

	[Token(Token = "0x6005186")]
	[Address(RVA = "0x936FA0", Offset = "0x9361A0", VA = "0x180936FA0")]
	public string ToJson()
	{
		return null;
	}

	[Token(Token = "0x6005187")]
	[Address(RVA = "0x98FF30", Offset = "0x98F130", VA = "0x18098FF30")]
	public bool ValidHelpPath(string fullPath)
	{
		return default(bool);
	}

	[Token(Token = "0x6005188")]
	[Address(RVA = "0x98FD30", Offset = "0x98EF30", VA = "0x18098FD30")]
	public HelpSectionData GetSectionData(string groupLabel, string sectionLabel)
	{
		return null;
	}

	[Token(Token = "0x6005189")]
	[Address(RVA = "0x9903A0", Offset = "0x98F5A0", VA = "0x1809903A0")]
	public HelpMappingData()
	{
	}
}
