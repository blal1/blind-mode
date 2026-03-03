using System.Collections.Generic;
using Il2CppDummyDll;

namespace YgomGame.MDMarkup;

[Token(Token = "0x2000D17")]
public interface IMDMarkupLinkContainWidget
{
	[Token(Token = "0x17000B4F")]
	IReadOnlyList<IMDMarkupLinkWidget> linkWidgets
	{
		[Token(Token = "0x6004F0B")]
		get;
	}
}
