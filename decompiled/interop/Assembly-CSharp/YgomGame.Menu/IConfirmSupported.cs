using System;
using Il2CppDummyDll;

namespace YgomGame.Menu;

[Token(Token = "0x20012BB")]
public interface IConfirmSupported
{
	[Token(Token = "0x6007448")]
	void ConfirmDialog(Action action, bool isback);
}
