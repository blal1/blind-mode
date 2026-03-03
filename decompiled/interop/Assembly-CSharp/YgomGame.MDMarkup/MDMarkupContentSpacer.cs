using System;
using Il2CppDummyDll;
using UnityEngine;

namespace YgomGame.MDMarkup;

[Serializable]
[Token(Token = "0x2000C93")]
public class MDMarkupContentSpacer : MDMarkupContentBase, IMDMarkupPrefabContent
{
	[Token(Token = "0x4009B8B")]
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	[MDMarkupIndent]
	public int indent;

	[Token(Token = "0x4009B8C")]
	[FieldOffset(Offset = "0x2C")]
	[SerializeField]
	public MDMarkupDef.SpacerSize size;

	[Token(Token = "0x17000A81")]
	public override MDMarkupDef.MarkupType markupType
	{
		[Token(Token = "0x6004C38")]
		[Address(RVA = "0x549EC0", Offset = "0x5490C0", VA = "0x180549EC0", Slot = "15")]
		get
		{
			return default(MDMarkupDef.MarkupType);
		}
	}

	[Token(Token = "0x17000A82")]
	public override int contentIndent
	{
		[Token(Token = "0x6004C39")]
		[Address(RVA = "0x62E210", Offset = "0x62D410", VA = "0x18062E210", Slot = "16")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x6004C3A")]
	[Address(RVA = "0x93CA60", Offset = "0x93BC60", VA = "0x18093CA60", Slot = "22")]
	protected override object OnExportJsonObj(object jsonObj)
	{
		return null;
	}

	[Token(Token = "0x6004C3B")]
	[Address(RVA = "0x93CB50", Offset = "0x93BD50", VA = "0x18093CB50", Slot = "23")]
	protected override void OnImportJsonObj(object jsonObj)
	{
	}

	[Token(Token = "0x6004C3C")]
	[Address(RVA = "0x93CA00", Offset = "0x93BC00", VA = "0x18093CA00", Slot = "24")]
	public string GetPrefabLabel()
	{
		return null;
	}

	[Token(Token = "0x6004C3D")]
	[Address(RVA = "0x93CC00", Offset = "0x93BE00", VA = "0x18093CC00")]
	public MDMarkupContentSpacer()
	{
	}
}
