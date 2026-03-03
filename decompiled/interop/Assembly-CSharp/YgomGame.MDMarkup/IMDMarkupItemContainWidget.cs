using System.Collections.Generic;
using Il2CppDummyDll;

namespace YgomGame.MDMarkup;

[Token(Token = "0x2000D13")]
public interface IMDMarkupItemContainWidget
{
	[Token(Token = "0x17000B44")]
	IReadOnlyList<IMDMarkupItemWidget> itemWidgets
	{
		[Token(Token = "0x6004F00")]
		get;
	}
}
