using System.Collections.Generic;
using Il2CppDummyDll;
using TMPro;

namespace YgomGame.MDMarkup;

[Token(Token = "0x2000CA2")]
public interface IMDMarkupTableRowContent : IMDMarkupTableContent, IMDMarkupSourceRequireTextData, IMDMarkupId, IMDMarkupOwnedId
{
	[Token(Token = "0x17000AD6")]
	MDMarkupDef.TableRowStyle styleType
	{
		[Token(Token = "0x6004CBB")]
		get;
	}

	[Token(Token = "0x17000AD7")]
	bool border
	{
		[Token(Token = "0x6004CBC")]
		get;
	}

	[Token(Token = "0x17000AD8")]
	string layout
	{
		[Token(Token = "0x6004CBD")]
		get;
	}

	[Token(Token = "0x17000AD9")]
	bool fillCells
	{
		[Token(Token = "0x6004CBE")]
		get;
	}

	[Token(Token = "0x17000ADA")]
	TextAlignmentOptions alignment
	{
		[Token(Token = "0x6004CBF")]
		get;
	}

	[Token(Token = "0x17000ADB")]
	IEnumerable<IMDMarkupTableCellContent> cells
	{
		[Token(Token = "0x6004CC0")]
		get;
	}
}
