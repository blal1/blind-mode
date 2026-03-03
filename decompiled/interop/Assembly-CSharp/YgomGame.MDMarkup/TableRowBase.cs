using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using TMPro;
using UnityEngine;
using YgomGame.Utility;
using YgomSystem.Utility;

namespace YgomGame.MDMarkup;

[Serializable]
[Token(Token = "0x2000CA3")]
public abstract class TableRowBase<TableCellType> : IMDMarkupTableRowContent, IMDMarkupTableContent, IMDMarkupSourceRequireTextData, IMDMarkupId, IMDMarkupOwnedId where TableCellType : class, IMDMarkupTableCellContent, new()
{
	[Token(Token = "0x4009BBC")]
	[FieldOffset(Offset = "0x0")]
	[SerializeField]
	public string id;

	[Token(Token = "0x4009BBD")]
	[FieldOffset(Offset = "0x0")]
	[SerializeField]
	[EnumString(typeof(MDMarkupDef.TableRowStyle))]
	public string style;

	[Token(Token = "0x4009BBE")]
	[FieldOffset(Offset = "0x0")]
	[SerializeField]
	public bool border;

	[Token(Token = "0x4009BBF")]
	[FieldOffset(Offset = "0x0")]
	[SerializeField]
	public string layout;

	[Token(Token = "0x4009BC0")]
	[FieldOffset(Offset = "0x0")]
	[SerializeField]
	public bool fillCells;

	[Token(Token = "0x4009BC1")]
	[FieldOffset(Offset = "0x0")]
	[SerializeField]
	public TextAlignmentOptions alignment;

	[Token(Token = "0x4009BC2")]
	[FieldOffset(Offset = "0x0")]
	[SerializeField]
	public List<TableCellType> cells;

	[Token(Token = "0x17000ADC")]
	private MDMarkupDef.TableRowStyle YgomGame_002EMDMarkup_002EIMDMarkupTableRowContent_002EstyleType
	{
		[Token(Token = "0x6004CC1")]
		get
		{
			return default(MDMarkupDef.TableRowStyle);
		}
	}

	[Token(Token = "0x17000ADD")]
	private bool YgomGame_002EMDMarkup_002EIMDMarkupTableRowContent_002Eborder
	{
		[Token(Token = "0x6004CC2")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17000ADE")]
	private string YgomGame_002EMDMarkup_002EIMDMarkupTableRowContent_002Elayout
	{
		[Token(Token = "0x6004CC3")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000ADF")]
	private bool YgomGame_002EMDMarkup_002EIMDMarkupTableRowContent_002EfillCells
	{
		[Token(Token = "0x6004CC4")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17000AE0")]
	private TextAlignmentOptions YgomGame_002EMDMarkup_002EIMDMarkupTableRowContent_002Ealignment
	{
		[Token(Token = "0x6004CC5")]
		get
		{
			return default(TextAlignmentOptions);
		}
	}

	[Token(Token = "0x17000AE1")]
	private IEnumerable<IMDMarkupTableCellContent> YgomGame_002EMDMarkup_002EIMDMarkupTableRowContent_002Ecells
	{
		[Token(Token = "0x6004CC6")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000AE2")]
	private string YgomGame_002EMDMarkup_002EIMDMarkupId_002Eid
	{
		[Token(Token = "0x6004CC7")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000AE3")]
	public MDMarkupDef.TableRowStyle styleType
	{
		[Token(Token = "0x6004CC8")]
		get
		{
			return default(MDMarkupDef.TableRowStyle);
		}
		[Token(Token = "0x6004CC9")]
		set
		{
		}
	}

	[Token(Token = "0x6004CCA")]
	public object ExportJsonObj()
	{
		return null;
	}

	[Token(Token = "0x6004CCB")]
	public void ImportJsonObj(object jsonObj)
	{
	}

	[Token(Token = "0x6004CCC")]
	public void CollectContentsIdMap(Dictionary<string, IMDMarkupId> destMap)
	{
	}

	[Token(Token = "0x6004CCD")]
	public void OnSetupTextGroupLoadHolder(TextGroupLoadHolder textGroupLoadHolder)
	{
	}

	[Token(Token = "0x6004CCE")]
	protected TableRowBase()
	{
	}
}
