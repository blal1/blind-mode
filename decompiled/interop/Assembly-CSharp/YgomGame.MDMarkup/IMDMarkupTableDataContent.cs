using System.Collections.Generic;
using Il2CppDummyDll;

namespace YgomGame.MDMarkup;

[Token(Token = "0x2000C96")]
public interface IMDMarkupTableDataContent : IMDMarkupContent, IMDMarkupSource, IMDMarkupId, IMDMarkupOwnedId, IMDMarkupSourceRequireTextData
{
	[Token(Token = "0x17000A85")]
	bool ignorePadding
	{
		[Token(Token = "0x6004C48")]
		get;
	}

	[Token(Token = "0x17000A86")]
	IEnumerable<IMDMarkupTableRowContent> rows
	{
		[Token(Token = "0x6004C49")]
		get;
	}

	[Token(Token = "0x17000A87")]
	TableSizeSetting sizeSetting
	{
		[Token(Token = "0x6004C4A")]
		get;
	}
}
