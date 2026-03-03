using System;
using Il2CppDummyDll;
using UnityEngine;
using YgomGame.Utility;

namespace YgomGame.MDMarkup;

[Serializable]
[Token(Token = "0x2000C85")]
public class MDMarkupContentH1 : MDMarkupContentBase, IMDMarkupSourceRequireTextData, IMDMarkupSupportedStrFormatByArgsModifier
{
	[Token(Token = "0x4009B54")]
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	public GlobalTextData text;

	[Token(Token = "0x17000A66")]
	public override MDMarkupDef.MarkupType markupType
	{
		[Token(Token = "0x6004BD9")]
		[Address(RVA = "0x4B8E10", Offset = "0x4B8010", VA = "0x1804B8E10", Slot = "15")]
		get
		{
			return default(MDMarkupDef.MarkupType);
		}
	}

	[Token(Token = "0x17000A67")]
	public override int contentIndent
	{
		[Token(Token = "0x6004BDA")]
		[Address(RVA = "0x4B8E10", Offset = "0x4B8010", VA = "0x1804B8E10", Slot = "16")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x6004BDB")]
	[Address(RVA = "0x9388B0", Offset = "0x937AB0", VA = "0x1809388B0")]
	public MDMarkupContentH1()
	{
	}

	[Token(Token = "0x6004BDC")]
	[Address(RVA = "0x9387F0", Offset = "0x9379F0", VA = "0x1809387F0")]
	public MDMarkupContentH1(string rawText)
	{
	}

	[Token(Token = "0x6004BDD")]
	[Address(RVA = "0x938720", Offset = "0x937920", VA = "0x180938720", Slot = "25")]
	public void OnFormatByArgsModifier(object[] formatParams)
	{
	}

	[Token(Token = "0x6004BDE")]
	[Address(RVA = "0x9387D0", Offset = "0x9379D0", VA = "0x1809387D0", Slot = "24")]
	public void OnSetupTextGroupLoadHolder(TextGroupLoadHolder textGroupLoadHolder)
	{
	}

	[Token(Token = "0x6004BDF")]
	[Address(RVA = "0x938690", Offset = "0x937890", VA = "0x180938690", Slot = "22")]
	protected override object OnExportJsonObj(object jsonObj)
	{
		return null;
	}

	[Token(Token = "0x6004BE0")]
	[Address(RVA = "0x938740", Offset = "0x937940", VA = "0x180938740", Slot = "23")]
	protected override void OnImportJsonObj(object jsonObj)
	{
	}
}
