using System;
using Il2CppDummyDll;

namespace YgomGame.MDMarkup;

[Token(Token = "0x2000C78")]
public interface IMDMarkupContentAsyncLoader
{
	[Token(Token = "0x6004B78")]
	void LoadAsync(Action onComplete);
}
