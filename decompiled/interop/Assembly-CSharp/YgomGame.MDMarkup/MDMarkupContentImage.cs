using System;
using Il2CppDummyDll;
using TMPro;
using UnityEngine;

namespace YgomGame.MDMarkup;

[Serializable]
[Token(Token = "0x2000C8C")]
public class MDMarkupContentImage : MDMarkupContentBase, IMDMarkupSupportedStrFormatByArgsModifier
{
	[Token(Token = "0x4009B6D")]
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	[MDMarkupIndent]
	private int indent;

	[Token(Token = "0x4009B6E")]
	[FieldOffset(Offset = "0x2C")]
	[SerializeField]
	public TextAlignmentOptions alignment;

	[Token(Token = "0x4009B6F")]
	[FieldOffset(Offset = "0x30")]
	[SerializeField]
	public string imagePath;

	[Token(Token = "0x4009B70")]
	[FieldOffset(Offset = "0x38")]
	[SerializeField]
	public float overrideHeight;

	[Token(Token = "0x4009B71")]
	[FieldOffset(Offset = "0x3C")]
	[SerializeField]
	public bool ignorePadding;

	[Token(Token = "0x4009B72")]
	[FieldOffset(Offset = "0x3D")]
	[SerializeField]
	public bool usePrefferedSize;

	[Token(Token = "0x17000A72")]
	public override MDMarkupDef.MarkupType markupType
	{
		[Token(Token = "0x6004C08")]
		[Address(RVA = "0x452710", Offset = "0x451910", VA = "0x180452710", Slot = "15")]
		get
		{
			return default(MDMarkupDef.MarkupType);
		}
	}

	[Token(Token = "0x17000A73")]
	public override int contentIndent
	{
		[Token(Token = "0x6004C09")]
		[Address(RVA = "0x62E210", Offset = "0x62D410", VA = "0x18062E210", Slot = "16")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x6004C0A")]
	[Address(RVA = "0x93AED0", Offset = "0x93A0D0", VA = "0x18093AED0", Slot = "22")]
	protected override object OnExportJsonObj(object jsonObj)
	{
		return null;
	}

	[Token(Token = "0x6004C0B")]
	[Address(RVA = "0x93B0B0", Offset = "0x93A2B0", VA = "0x18093B0B0", Slot = "23")]
	protected override void OnImportJsonObj(object jsonObj)
	{
	}

	[Token(Token = "0x6004C0C")]
	[Address(RVA = "0x93B080", Offset = "0x93A280", VA = "0x18093B080", Slot = "24")]
	public void OnFormatByArgsModifier(object[] formatParams)
	{
	}

	[Token(Token = "0x6004C0D")]
	[Address(RVA = "0x93B210", Offset = "0x93A410", VA = "0x18093B210")]
	public MDMarkupContentImage()
	{
	}
}
