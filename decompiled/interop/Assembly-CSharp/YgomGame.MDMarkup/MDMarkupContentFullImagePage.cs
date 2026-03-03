using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;
using YgomGame.Utility;

namespace YgomGame.MDMarkup;

[Serializable]
[Token(Token = "0x2000C80")]
public class MDMarkupContentFullImagePage : MDMarkupContentPageBase, IMDMarkupSourceRequireTextData, IMDMarkupSupportedStrFormatByArgsModifier
{
	[Token(Token = "0x4009B3C")]
	[FieldOffset(Offset = "0x30")]
	[SerializeField]
	public GlobalTextData caption;

	[Token(Token = "0x4009B3D")]
	[FieldOffset(Offset = "0x38")]
	[SerializeField]
	public string resourcePath;

	[Token(Token = "0x4009B3E")]
	[FieldOffset(Offset = "0x40")]
	[SerializeField]
	public List<URLSchemeButton> buttons;

	[Token(Token = "0x4009B41")]
	[FieldOffset(Offset = "0x58")]
	public bool isCreatedSprite;

	[Token(Token = "0x17000A5B")]
	public override MDMarkupDef.MarkupType markupType
	{
		[Token(Token = "0x6004BB4")]
		[Address(RVA = "0x3FC090", Offset = "0x3FB290", VA = "0x1803FC090", Slot = "15")]
		get
		{
			return default(MDMarkupDef.MarkupType);
		}
	}

	[Token(Token = "0x17000A5C")]
	public Sprite imageSprite
	{
		[Token(Token = "0x6004BB5")]
		[Address(RVA = "0x414E80", Offset = "0x414080", VA = "0x180414E80")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Token(Token = "0x6004BB6")]
		[Address(RVA = "0x414E90", Offset = "0x414090", VA = "0x180414E90")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Token(Token = "0x17000A5D")]
	public GameObject prefab
	{
		[Token(Token = "0x6004BB7")]
		[Address(RVA = "0x580700", Offset = "0x57F900", VA = "0x180580700")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Token(Token = "0x6004BB8")]
		[Address(RVA = "0x580760", Offset = "0x57F960", VA = "0x180580760")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Token(Token = "0x6004BB9")]
	[Address(RVA = "0x9379E0", Offset = "0x936BE0", VA = "0x1809379E0", Slot = "27")]
	public void OnSetupTextGroupLoadHolder(TextGroupLoadHolder textGroupLoadHolder)
	{
	}

	[Token(Token = "0x6004BBA")]
	[Address(RVA = "0x937780", Offset = "0x936980", VA = "0x180937780", Slot = "28")]
	public void OnFormatByArgsModifier(object[] formatParams)
	{
	}

	[Token(Token = "0x6004BBB")]
	[Address(RVA = "0x937690", Offset = "0x936890", VA = "0x180937690", Slot = "22")]
	protected override object OnExportJsonObj(object jsonObj)
	{
		return null;
	}

	[Token(Token = "0x6004BBC")]
	[Address(RVA = "0x9378D0", Offset = "0x936AD0", VA = "0x1809378D0", Slot = "23")]
	protected override void OnImportJsonObj(object jsonObj)
	{
	}

	[Token(Token = "0x6004BBD")]
	[Address(RVA = "0x937B20", Offset = "0x936D20", VA = "0x180937B20")]
	public MDMarkupContentFullImagePage()
	{
	}
}
