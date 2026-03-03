using Il2CppDummyDll;

namespace YgomGame.MDMarkup;

[Token(Token = "0x2000C9A")]
public interface IMDMarkupTableCellContent : IMDMarkupTableContent, IMDMarkupSourceRequireTextData, IMDMarkupId, IMDMarkupOwnedId
{
	[Token(Token = "0x17000A8E")]
	bool border
	{
		[Token(Token = "0x6004C58")]
		get;
	}

	[Token(Token = "0x17000A8F")]
	bool ignorePadding
	{
		[Token(Token = "0x6004C59")]
		get;
	}

	[Token(Token = "0x17000A90")]
	bool ignoreRowLayout
	{
		[Token(Token = "0x6004C5A")]
		get;
	}

	[Token(Token = "0x17000A91")]
	bool childForceExpand
	{
		[Token(Token = "0x6004C5B")]
		get;
	}

	[Token(Token = "0x17000A92")]
	IMDMarkupTableCellValueContent value
	{
		[Token(Token = "0x6004C5C")]
		get;
	}
}
