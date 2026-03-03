using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using YgomGame.Utility;

namespace YgomGame.MDMarkup;

[Serializable]
[Token(Token = "0x2000C9B")]
public abstract class TableCellBase<TableCellValueType> : IMDMarkupTableCellContent, IMDMarkupTableContent, IMDMarkupSourceRequireTextData, IMDMarkupId, IMDMarkupOwnedId, IMDMarkupSupportedStrFormatByArgsModifier where TableCellValueType : IMDMarkupTableCellValueContent, new()
{
	[Token(Token = "0x4009B95")]
	[FieldOffset(Offset = "0x0")]
	[SerializeField]
	public string id;

	[Token(Token = "0x4009B96")]
	[FieldOffset(Offset = "0x0")]
	[SerializeField]
	public bool border;

	[Token(Token = "0x4009B97")]
	[FieldOffset(Offset = "0x0")]
	[SerializeField]
	public bool ignorePadding;

	[Token(Token = "0x4009B98")]
	[FieldOffset(Offset = "0x0")]
	[SerializeField]
	public bool ignoreRowLayout;

	[Token(Token = "0x4009B99")]
	[FieldOffset(Offset = "0x0")]
	[SerializeField]
	public bool childForceExpand;

	[Token(Token = "0x4009B9A")]
	[FieldOffset(Offset = "0x0")]
	[SerializeField]
	private TableCellValueType cellValue;

	[Token(Token = "0x17000A93")]
	private string YgomGame_002EMDMarkup_002EIMDMarkupId_002Eid
	{
		[Token(Token = "0x6004C5D")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000A94")]
	private bool YgomGame_002EMDMarkup_002EIMDMarkupTableCellContent_002Eborder
	{
		[Token(Token = "0x6004C5E")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17000A95")]
	private bool YgomGame_002EMDMarkup_002EIMDMarkupTableCellContent_002EignorePadding
	{
		[Token(Token = "0x6004C5F")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17000A96")]
	private bool YgomGame_002EMDMarkup_002EIMDMarkupTableCellContent_002EignoreRowLayout
	{
		[Token(Token = "0x6004C60")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17000A97")]
	private bool YgomGame_002EMDMarkup_002EIMDMarkupTableCellContent_002EchildForceExpand
	{
		[Token(Token = "0x6004C61")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17000A98")]
	public IMDMarkupTableCellValueContent value
	{
		[Token(Token = "0x6004C62")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6004C63")]
	public object ExportJsonObj()
	{
		return null;
	}

	[Token(Token = "0x6004C64")]
	public void ImportJsonObj(object jsonObj)
	{
	}

	[Token(Token = "0x6004C65")]
	public void CollectContentsIdMap(Dictionary<string, IMDMarkupId> destMap)
	{
	}

	[Token(Token = "0x6004C66")]
	public void OnSetupTextGroupLoadHolder(TextGroupLoadHolder textGroupLoadHolder)
	{
	}

	[Token(Token = "0x6004C67")]
	public void OnFormatByArgsModifier(object[] formatParams)
	{
	}

	[Token(Token = "0x6004C68")]
	protected TableCellBase()
	{
	}
}
