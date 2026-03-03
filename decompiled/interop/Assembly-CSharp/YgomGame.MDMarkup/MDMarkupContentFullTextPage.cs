using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using YgomGame.Utility;

namespace YgomGame.MDMarkup;

[Serializable]
[Token(Token = "0x2000C81")]
public class MDMarkupContentFullTextPage : MDMarkupContentPageBase, IMDMarkupSourceRequireTextData, IMDMarkupSupportedStrFormatByArgsModifier
{
	[Token(Token = "0x4009B42")]
	[FieldOffset(Offset = "0x30")]
	[SerializeField]
	public GlobalTextData caption;

	[Token(Token = "0x4009B43")]
	[FieldOffset(Offset = "0x38")]
	[SerializeField]
	public GlobalTextData text;

	[Token(Token = "0x4009B44")]
	[FieldOffset(Offset = "0x40")]
	[SerializeField]
	public List<URLSchemeButton> buttons;

	[Token(Token = "0x17000A5E")]
	public override MDMarkupDef.MarkupType markupType
	{
		[Token(Token = "0x6004BBE")]
		[Address(RVA = "0x9381F0", Offset = "0x9373F0", VA = "0x1809381F0", Slot = "15")]
		get
		{
			return default(MDMarkupDef.MarkupType);
		}
	}

	[Token(Token = "0x6004BBF")]
	[Address(RVA = "0x937F70", Offset = "0x937170", VA = "0x180937F70", Slot = "27")]
	public void OnSetupTextGroupLoadHolder(TextGroupLoadHolder textGroupLoadHolder)
	{
	}

	[Token(Token = "0x6004BC0")]
	[Address(RVA = "0x937D10", Offset = "0x936F10", VA = "0x180937D10", Slot = "28")]
	public void OnFormatByArgsModifier(object[] formatParams)
	{
	}

	[Token(Token = "0x6004BC1")]
	[Address(RVA = "0x937C10", Offset = "0x936E10", VA = "0x180937C10", Slot = "22")]
	protected override object OnExportJsonObj(object jsonObj)
	{
		return null;
	}

	[Token(Token = "0x6004BC2")]
	[Address(RVA = "0x937E70", Offset = "0x937070", VA = "0x180937E70", Slot = "23")]
	protected override void OnImportJsonObj(object jsonObj)
	{
	}

	[Token(Token = "0x6004BC3")]
	[Address(RVA = "0x9380F0", Offset = "0x9372F0", VA = "0x1809380F0")]
	public MDMarkupContentFullTextPage()
	{
	}
}
