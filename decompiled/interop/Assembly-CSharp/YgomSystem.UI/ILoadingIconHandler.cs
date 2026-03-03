using System;
using Il2CppDummyDll;

namespace YgomSystem.UI;

[Token(Token = "0x2000536")]
public interface ILoadingIconHandler
{
	[Token(Token = "0x1700038B")]
	bool visible
	{
		[Token(Token = "0x60021DF")]
		get;
	}

	[Token(Token = "0x1400002F")]
	event Action onReloadEvent;

	[Token(Token = "0x60021E0")]
	bool IsDone();
}
