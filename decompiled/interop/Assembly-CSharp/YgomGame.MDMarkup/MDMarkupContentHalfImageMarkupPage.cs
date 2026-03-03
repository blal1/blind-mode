using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using YgomGame.Utility;

namespace YgomGame.MDMarkup;

[Serializable]
[Token(Token = "0x2000C8A")]
public class MDMarkupContentHalfImageMarkupPage : MDMarkupContentPageBase, IMDMarkupSourceRequireTextData, IMDMarkupContentAsyncLoader, IMDMarkupSourceSupportedInvalidMessage
{
	[Token(Token = "0x4009B65")]
	[FieldOffset(Offset = "0x30")]
	[SerializeField]
	public string resourcePath;

	[Token(Token = "0x4009B66")]
	[FieldOffset(Offset = "0x38")]
	[SerializeField]
	public List<URLSchemeButton> buttons;

	[Token(Token = "0x4009B67")]
	[FieldOffset(Offset = "0x40")]
	public List<IMDMarkupContent> contents;

	[Token(Token = "0x4009B68")]
	[FieldOffset(Offset = "0x48")]
	private int m_LoadingCnt;

	[Token(Token = "0x4009B69")]
	[FieldOffset(Offset = "0x4C")]
	private int m_InvalidMessagePriority;

	[Token(Token = "0x4009B6A")]
	[FieldOffset(Offset = "0x50")]
	private string m_InvalidMessageText;

	[Token(Token = "0x4009B6B")]
	[FieldOffset(Offset = "0x58")]
	private Action m_LoadAsyncOnComplete;

	[Token(Token = "0x17000A6E")]
	public override MDMarkupDef.MarkupType markupType
	{
		[Token(Token = "0x6004BF9")]
		[Address(RVA = "0x573650", Offset = "0x572850", VA = "0x180573650", Slot = "15")]
		get
		{
			return default(MDMarkupDef.MarkupType);
		}
	}

	[Token(Token = "0x17000A6F")]
	public int invalidMessagePriority
	{
		[Token(Token = "0x6004BFA")]
		[Address(RVA = "0x49BD80", Offset = "0x49AF80", VA = "0x18049BD80", Slot = "29")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x17000A70")]
	public string invalidMessageText
	{
		[Token(Token = "0x6004BFB")]
		[Address(RVA = "0x580700", Offset = "0x57F900", VA = "0x180580700", Slot = "30")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6004BFC")]
	[Address(RVA = "0x939AA0", Offset = "0x938CA0", VA = "0x180939AA0", Slot = "19")]
	public override void CollectContentsIdMap(Dictionary<string, IMDMarkupId> destMap)
	{
	}

	[Token(Token = "0x6004BFD")]
	[Address(RVA = "0x93A7B0", Offset = "0x9399B0", VA = "0x18093A7B0", Slot = "27")]
	public void OnSetupTextGroupLoadHolder(TextGroupLoadHolder textGroupLoadHolder)
	{
	}

	[Token(Token = "0x6004BFE")]
	[Address(RVA = "0x939F10", Offset = "0x939110", VA = "0x180939F10", Slot = "28")]
	public void LoadAsync(Action onComplete)
	{
	}

	[Token(Token = "0x6004BFF")]
	[Address(RVA = "0x939CA0", Offset = "0x938EA0", VA = "0x180939CA0")]
	private void LoadAsyncCompleteCheck()
	{
	}

	[Token(Token = "0x6004C00")]
	[Address(RVA = "0x93A180", Offset = "0x939380", VA = "0x18093A180", Slot = "22")]
	protected override object OnExportJsonObj(object jsonObj)
	{
		return null;
	}

	[Token(Token = "0x6004C01")]
	[Address(RVA = "0x93A4B0", Offset = "0x9396B0", VA = "0x18093A4B0", Slot = "23")]
	protected override void OnImportJsonObj(object jsonObj)
	{
	}

	[Token(Token = "0x6004C02")]
	[Address(RVA = "0x93AA50", Offset = "0x939C50", VA = "0x18093AA50")]
	public MDMarkupContentHalfImageMarkupPage()
	{
	}
}
