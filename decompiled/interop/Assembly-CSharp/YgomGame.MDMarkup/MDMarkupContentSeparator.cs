using System;
using Il2CppDummyDll;
using UnityEngine;

namespace YgomGame.MDMarkup;

[Serializable]
[Token(Token = "0x2000C91")]
public class MDMarkupContentSeparator : MDMarkupContentBase, IMDMarkupPrefabContent
{
	[Token(Token = "0x4009B87")]
	public const string k_PrefKey = "separator";

	[Token(Token = "0x4009B88")]
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	[MDMarkupIndent]
	public int indent;

	[Token(Token = "0x17000A7F")]
	public override MDMarkupDef.MarkupType markupType
	{
		[Token(Token = "0x6004C2F")]
		[Address(RVA = "0x443230", Offset = "0x442430", VA = "0x180443230", Slot = "15")]
		get
		{
			return default(MDMarkupDef.MarkupType);
		}
	}

	[Token(Token = "0x17000A80")]
	public override int contentIndent
	{
		[Token(Token = "0x6004C30")]
		[Address(RVA = "0x62E210", Offset = "0x62D410", VA = "0x18062E210", Slot = "16")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x6004C31")]
	[Address(RVA = "0x93C770", Offset = "0x93B970", VA = "0x18093C770", Slot = "22")]
	protected override object OnExportJsonObj(object jsonObj)
	{
		return null;
	}

	[Token(Token = "0x6004C32")]
	[Address(RVA = "0x93C800", Offset = "0x93BA00", VA = "0x18093C800", Slot = "23")]
	protected override void OnImportJsonObj(object jsonObj)
	{
	}

	[Token(Token = "0x6004C33")]
	[Address(RVA = "0x93C740", Offset = "0x93B940", VA = "0x18093C740", Slot = "24")]
	public string GetPrefabLabel()
	{
		return null;
	}

	[Token(Token = "0x6004C34")]
	[Address(RVA = "0x93C870", Offset = "0x93BA70", VA = "0x18093C870")]
	public MDMarkupContentSeparator()
	{
	}
}
