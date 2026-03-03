using System;
using Il2CppDummyDll;
using TMPro;
using UnityEngine;
using YgomGame.Utility;

namespace YgomGame.MDMarkup;

[Serializable]
[Token(Token = "0x2000C94")]
public class MDMarkupContentText : MDMarkupContentBase, IMDMarkupSourceRequireTextData, IMDMarkupSupportedStrFormatByArgsModifier
{
	[Token(Token = "0x4009B8D")]
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	[MDMarkupIndent]
	public int indent;

	[Token(Token = "0x4009B8E")]
	[FieldOffset(Offset = "0x2C")]
	[SerializeField]
	public TextAlignmentOptions alignment;

	[Token(Token = "0x4009B8F")]
	[FieldOffset(Offset = "0x30")]
	[SerializeField]
	public GlobalTextData text;

	[Token(Token = "0x4009B90")]
	[FieldOffset(Offset = "0x38")]
	[SerializeField]
	public bool ignorePadding;

	[Token(Token = "0x17000A83")]
	public override MDMarkupDef.MarkupType markupType
	{
		[Token(Token = "0x6004C3E")]
		[Address(RVA = "0x4465B0", Offset = "0x4457B0", VA = "0x1804465B0", Slot = "15")]
		get
		{
			return default(MDMarkupDef.MarkupType);
		}
	}

	[Token(Token = "0x17000A84")]
	public override int contentIndent
	{
		[Token(Token = "0x6004C3F")]
		[Address(RVA = "0x62E210", Offset = "0x62D410", VA = "0x18062E210", Slot = "16")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x6004C40")]
	[Address(RVA = "0x93CF80", Offset = "0x93C180", VA = "0x18093CF80")]
	public MDMarkupContentText()
	{
	}

	[Token(Token = "0x6004C41")]
	[Address(RVA = "0x93D020", Offset = "0x93C220", VA = "0x18093D020")]
	public MDMarkupContentText(string rawText)
	{
	}

	[Token(Token = "0x6004C42")]
	[Address(RVA = "0x93CE30", Offset = "0x93C030", VA = "0x18093CE30", Slot = "25")]
	public void OnFormatByArgsModifier(object[] formatParams)
	{
	}

	[Token(Token = "0x6004C43")]
	[Address(RVA = "0x93CF60", Offset = "0x93C160", VA = "0x18093CF60", Slot = "24")]
	public void OnSetupTextGroupLoadHolder(TextGroupLoadHolder textGroupLoadHolder)
	{
	}

	[Token(Token = "0x6004C44")]
	[Address(RVA = "0x93CCD0", Offset = "0x93BED0", VA = "0x18093CCD0", Slot = "22")]
	protected override object OnExportJsonObj(object jsonObj)
	{
		return null;
	}

	[Token(Token = "0x6004C45")]
	[Address(RVA = "0x93CE50", Offset = "0x93C050", VA = "0x18093CE50", Slot = "23")]
	protected override void OnImportJsonObj(object jsonObj)
	{
	}
}
