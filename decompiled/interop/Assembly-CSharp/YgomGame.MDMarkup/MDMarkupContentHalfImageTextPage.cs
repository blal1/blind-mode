using System;
using Il2CppDummyDll;
using UnityEngine;

namespace YgomGame.MDMarkup;

[Serializable]
[Token(Token = "0x2000C8B")]
public class MDMarkupContentHalfImageTextPage : MDMarkupContentFullTextPage
{
	[Token(Token = "0x4009B6C")]
	[FieldOffset(Offset = "0x48")]
	[SerializeField]
	public string resourcePath;

	[Token(Token = "0x17000A71")]
	public override MDMarkupDef.MarkupType markupType
	{
		[Token(Token = "0x6004C04")]
		[Address(RVA = "0x577DA0", Offset = "0x576FA0", VA = "0x180577DA0", Slot = "15")]
		get
		{
			return default(MDMarkupDef.MarkupType);
		}
	}

	[Token(Token = "0x6004C05")]
	[Address(RVA = "0x93AB60", Offset = "0x939D60", VA = "0x18093AB60", Slot = "22")]
	protected override object OnExportJsonObj(object jsonObj)
	{
		return null;
	}

	[Token(Token = "0x6004C06")]
	[Address(RVA = "0x93ACE0", Offset = "0x939EE0", VA = "0x18093ACE0", Slot = "23")]
	protected override void OnImportJsonObj(object jsonObj)
	{
	}

	[Token(Token = "0x6004C07")]
	[Address(RVA = "0x93AE90", Offset = "0x93A090", VA = "0x18093AE90")]
	public MDMarkupContentHalfImageTextPage()
	{
	}
}
