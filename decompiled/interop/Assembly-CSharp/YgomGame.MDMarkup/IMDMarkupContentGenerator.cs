using System.Collections.Generic;
using Il2CppDummyDll;

namespace YgomGame.MDMarkup;

[Token(Token = "0x2000C77")]
public interface IMDMarkupContentGenerator : IMDMarkupContent, IMDMarkupSource, IMDMarkupId, IMDMarkupOwnedId
{
	[Token(Token = "0x17000A46")]
	List<IMDMarkupContent> outputContents
	{
		[Token(Token = "0x6004B77")]
		get;
	}
}
