using System.Collections.Generic;
using Il2CppDummyDll;

namespace YgomGame.MDMarkup;

[Token(Token = "0x2000C75")]
public interface IMDMarkupContent : IMDMarkupSource, IMDMarkupId, IMDMarkupOwnedId
{
	[Token(Token = "0x17000A44")]
	MDMarkupDef.MarkupType markupType
	{
		[Token(Token = "0x6004B6E")]
		get;
	}

	[Token(Token = "0x17000A45")]
	int contentIndent
	{
		[Token(Token = "0x6004B6F")]
		get;
	}

	[Token(Token = "0x6004B70")]
	string ToJson();

	[Token(Token = "0x6004B71")]
	object ExportJsonObj();

	[Token(Token = "0x6004B72")]
	void ImportJsonObj(object jsonObj);

	[Token(Token = "0x6004B73")]
	void SetArgs(Dictionary<string, object> args);
}
