using System;
using Il2CppDummyDll;

namespace YgomGame.Dialog.CommonDialog;

[Token(Token = "0x2000FE2")]
public interface IConentWidgetSendableClose
{
	[Token(Token = "0x17000F23")]
	Action onSendCloseCallback
	{
		[Token(Token = "0x600602B")]
		set;
	}
}
