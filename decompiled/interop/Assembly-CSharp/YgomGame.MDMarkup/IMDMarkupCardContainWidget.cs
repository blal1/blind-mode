using System.Collections.Generic;
using Il2CppDummyDll;

namespace YgomGame.MDMarkup;

[Token(Token = "0x2000D15")]
public interface IMDMarkupCardContainWidget
{
	[Token(Token = "0x17000B4D")]
	IReadOnlyList<IMDMarkupCardWidget> cardWidgets
	{
		[Token(Token = "0x6004F09")]
		get;
	}
}
