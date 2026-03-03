using System;
using Il2CppDummyDll;

namespace YgomGame.MDMarkup;

[Token(Token = "0x2000C76")]
public interface IMDMarkupPageContent : IMDMarkupContent, IMDMarkupSource, IMDMarkupId, IMDMarkupOwnedId
{
	[Token(Token = "0x1400006C")]
	event Action<bool> onFocusPageEvent;

	[Token(Token = "0x6004B76")]
	void InvokeOnFocusPageEvent(bool isFirst);
}
