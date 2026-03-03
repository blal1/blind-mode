using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using YgomGame.Utility;

namespace YgomGame.MDMarkup;

[Serializable]
[Token(Token = "0x2000C88")]
public class MDMarkupContentHalfBannerMarkupPage : MDMarkupContentPageBase, IMDMarkupSourceRequireTextData, IMDMarkupContentAsyncLoader, IMDMarkupSourceSupportedInvalidMessage
{
	[Token(Token = "0x4009B5A")]
	[FieldOffset(Offset = "0x30")]
	[SerializeField]
	public MDMarkupBannerContext banner;

	[Token(Token = "0x4009B5B")]
	[FieldOffset(Offset = "0x38")]
	[SerializeField]
	public List<URLSchemeButton> buttons;

	[Token(Token = "0x4009B5C")]
	[FieldOffset(Offset = "0x40")]
	public List<IMDMarkupContent> contents;

	[Token(Token = "0x4009B5D")]
	[FieldOffset(Offset = "0x48")]
	private int m_LoadingCnt;

	[Token(Token = "0x4009B5E")]
	[FieldOffset(Offset = "0x4C")]
	private int m_InvalidMessagePriority;

	[Token(Token = "0x4009B5F")]
	[FieldOffset(Offset = "0x50")]
	private string m_InvalidMessageText;

	[Token(Token = "0x4009B60")]
	[FieldOffset(Offset = "0x58")]
	private Action m_LoadAsyncOnComplete;

	[Token(Token = "0x17000A6B")]
	public override MDMarkupDef.MarkupType markupType
	{
		[Token(Token = "0x6004BEA")]
		[Address(RVA = "0x578DC0", Offset = "0x577FC0", VA = "0x180578DC0", Slot = "15")]
		get
		{
			return default(MDMarkupDef.MarkupType);
		}
	}

	[Token(Token = "0x17000A6C")]
	public int invalidMessagePriority
	{
		[Token(Token = "0x6004BEB")]
		[Address(RVA = "0x49BD80", Offset = "0x49AF80", VA = "0x18049BD80", Slot = "29")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x17000A6D")]
	public string invalidMessageText
	{
		[Token(Token = "0x6004BEC")]
		[Address(RVA = "0x580700", Offset = "0x57F900", VA = "0x180580700", Slot = "30")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6004BED")]
	[Address(RVA = "0x9389A0", Offset = "0x937BA0", VA = "0x1809389A0", Slot = "19")]
	public override void CollectContentsIdMap(Dictionary<string, IMDMarkupId> destMap)
	{
	}

	[Token(Token = "0x6004BEE")]
	[Address(RVA = "0x9396E0", Offset = "0x9388E0", VA = "0x1809396E0", Slot = "27")]
	public void OnSetupTextGroupLoadHolder(TextGroupLoadHolder textGroupLoadHolder)
	{
	}

	[Token(Token = "0x6004BEF")]
	[Address(RVA = "0x938E10", Offset = "0x938010", VA = "0x180938E10", Slot = "28")]
	public void LoadAsync(Action onComplete)
	{
	}

	[Token(Token = "0x6004BF0")]
	[Address(RVA = "0x938BA0", Offset = "0x937DA0", VA = "0x180938BA0")]
	private void LoadAsyncCompleteCheck()
	{
	}

	[Token(Token = "0x6004BF1")]
	[Address(RVA = "0x939080", Offset = "0x938280", VA = "0x180939080", Slot = "22")]
	protected override object OnExportJsonObj(object jsonObj)
	{
		return null;
	}

	[Token(Token = "0x6004BF2")]
	[Address(RVA = "0x9393D0", Offset = "0x9385D0", VA = "0x1809393D0", Slot = "23")]
	protected override void OnImportJsonObj(object jsonObj)
	{
	}

	[Token(Token = "0x6004BF3")]
	[Address(RVA = "0x939980", Offset = "0x938B80", VA = "0x180939980")]
	public MDMarkupContentHalfBannerMarkupPage()
	{
	}
}
