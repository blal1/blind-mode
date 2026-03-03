using System;
using Il2CppDummyDll;

namespace YgomGame.Dialog.CommonDialog;

[Token(Token = "0x2000FDE")]
public interface IContentWidgetAsyncLoader
{
	[Token(Token = "0x6006021")]
	void AsyncBinding(IEntryData entryData, Action onComplete);
}
