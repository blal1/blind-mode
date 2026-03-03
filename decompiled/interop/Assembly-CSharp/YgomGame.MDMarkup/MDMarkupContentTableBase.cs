using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using YgomGame.Utility;

namespace YgomGame.MDMarkup;

[Serializable]
[Token(Token = "0x2000C97")]
public abstract class MDMarkupContentTableBase<TableRowType> : MDMarkupContentBase, IMDMarkupTableDataContent, IMDMarkupContent, IMDMarkupSource, IMDMarkupId, IMDMarkupOwnedId, IMDMarkupSourceRequireTextData where TableRowType : class, IMDMarkupTableRowContent, new()
{
	[Token(Token = "0x4009B91")]
	[FieldOffset(Offset = "0x0")]
	[SerializeField]
	[MDMarkupIndent]
	public int indent;

	[Token(Token = "0x4009B92")]
	[FieldOffset(Offset = "0x0")]
	[SerializeField]
	public bool ignorePadding;

	[Token(Token = "0x4009B93")]
	[FieldOffset(Offset = "0x0")]
	[SerializeField]
	private TableSizeSetting setting;

	[Token(Token = "0x4009B94")]
	[FieldOffset(Offset = "0x0")]
	[SerializeField]
	public List<TableRowType> rows;

	[Token(Token = "0x17000A88")]
	public override MDMarkupDef.MarkupType markupType
	{
		[Token(Token = "0x6004C4B")]
		get
		{
			return default(MDMarkupDef.MarkupType);
		}
	}

	[Token(Token = "0x17000A89")]
	public override int contentIndent
	{
		[Token(Token = "0x6004C4C")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x17000A8A")]
	public TableSizeSetting sizeSetting
	{
		[Token(Token = "0x6004C4D")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000A8B")]
	private bool YgomGame_002EMDMarkup_002EIMDMarkupTableDataContent_002EignorePadding
	{
		[Token(Token = "0x6004C4E")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17000A8C")]
	private IEnumerable<IMDMarkupTableRowContent> YgomGame_002EMDMarkup_002EIMDMarkupTableDataContent_002Erows
	{
		[Token(Token = "0x6004C4F")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000A8D")]
	private TableSizeSetting YgomGame_002EMDMarkup_002EIMDMarkupTableDataContent_002EsizeSetting
	{
		[Token(Token = "0x6004C50")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6004C51")]
	protected override object OnExportJsonObj(object jsonObj)
	{
		return null;
	}

	[Token(Token = "0x6004C52")]
	protected override void OnImportJsonObj(object jsonObj)
	{
	}

	[Token(Token = "0x6004C53")]
	public override void CollectContentsIdMap(Dictionary<string, IMDMarkupId> destMap)
	{
	}

	[Token(Token = "0x6004C54")]
	public void OnSetupTextGroupLoadHolder(TextGroupLoadHolder textGroupLoadHolder)
	{
	}

	[Token(Token = "0x6004C55")]
	protected MDMarkupContentTableBase()
	{
	}
}
