using System;
using Il2CppDummyDll;

namespace YgomGame.MDMarkup;

[Token(Token = "0x2000D1C")]
public interface IMDMarkupGraphWidget
{
	[Token(Token = "0x6004F14")]
	void OutputMarkupGraph(IMDMarkupContent mdMarkupContent, MDMarkupGraphFactory markupGraphFactory, Action onComplete);
}
