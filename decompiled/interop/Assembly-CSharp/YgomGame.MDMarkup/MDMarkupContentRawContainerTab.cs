using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using YgomGame.Utility;

namespace YgomGame.MDMarkup;

[Serializable]
[Token(Token = "0x2000C8D")]
public class MDMarkupContentRawContainerTab : MDMarkupContentBase, IMDMarkupSourceRequireTextData, IMDMarkupContentAsyncLoader, IMDMarkupSourceSupportedInvalidMessage
{
	[Token(Token = "0x4009B73")]
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	public GlobalTextData title;

	[Token(Token = "0x4009B74")]
	[FieldOffset(Offset = "0x30")]
	public List<IMDMarkupContent> contents;

	[Token(Token = "0x4009B75")]
	[FieldOffset(Offset = "0x38")]
	private Action m_LoadAsyncOnComplete;

	[Token(Token = "0x4009B76")]
	[FieldOffset(Offset = "0x40")]
	private int m_LoadingCnt;

	[Token(Token = "0x4009B77")]
	[FieldOffset(Offset = "0x44")]
	private int m_InvalidMessagePriority;

	[Token(Token = "0x4009B78")]
	[FieldOffset(Offset = "0x48")]
	private string m_InvalidMessageText;

	[Token(Token = "0x17000A74")]
	public override MDMarkupDef.MarkupType markupType
	{
		[Token(Token = "0x6004C0E")]
		[Address(RVA = "0x575E00", Offset = "0x575000", VA = "0x180575E00", Slot = "15")]
		get
		{
			return default(MDMarkupDef.MarkupType);
		}
	}

	[Token(Token = "0x17000A75")]
	public override int contentIndent
	{
		[Token(Token = "0x6004C0F")]
		[Address(RVA = "0x4C9EF0", Offset = "0x4C90F0", VA = "0x1804C9EF0", Slot = "16")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x17000A76")]
	public int invalidMessagePriority
	{
		[Token(Token = "0x6004C10")]
		[Address(RVA = "0x5FA7A0", Offset = "0x5F99A0", VA = "0x1805FA7A0", Slot = "26")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x17000A77")]
	public string invalidMessageText
	{
		[Token(Token = "0x6004C11")]
		[Address(RVA = "0x414E80", Offset = "0x414080", VA = "0x180414E80", Slot = "27")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6004C12")]
	[Address(RVA = "0x93B400", Offset = "0x93A600", VA = "0x18093B400", Slot = "19")]
	public override void CollectContentsIdMap(Dictionary<string, IMDMarkupId> destMap)
	{
	}

	[Token(Token = "0x6004C13")]
	[Address(RVA = "0x93C090", Offset = "0x93B290", VA = "0x18093C090", Slot = "24")]
	public void OnSetupTextGroupLoadHolder(TextGroupLoadHolder textGroupLoadHolder)
	{
	}

	[Token(Token = "0x6004C14")]
	[Address(RVA = "0x93B870", Offset = "0x93AA70", VA = "0x18093B870", Slot = "25")]
	public void LoadAsync(Action onComplete)
	{
	}

	[Token(Token = "0x6004C15")]
	[Address(RVA = "0x93B600", Offset = "0x93A800", VA = "0x18093B600")]
	private void LoadAsyncCompleteCheck()
	{
	}

	[Token(Token = "0x6004C16")]
	[Address(RVA = "0x93BAE0", Offset = "0x93ACE0", VA = "0x18093BAE0", Slot = "22")]
	protected override object OnExportJsonObj(object jsonObj)
	{
		return null;
	}

	[Token(Token = "0x6004C17")]
	[Address(RVA = "0x93BE00", Offset = "0x93B000", VA = "0x18093BE00", Slot = "23")]
	protected override void OnImportJsonObj(object jsonObj)
	{
	}

	[Token(Token = "0x6004C18")]
	[Address(RVA = "0x93C220", Offset = "0x93B420", VA = "0x18093C220")]
	public MDMarkupContentRawContainerTab()
	{
	}
}
