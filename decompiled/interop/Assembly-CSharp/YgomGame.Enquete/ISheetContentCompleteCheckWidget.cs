using System;
using Il2CppDummyDll;

namespace YgomGame.Enquete;

[Token(Token = "0x2000E23")]
public interface ISheetContentCompleteCheckWidget
{
	[Token(Token = "0x17000CC6")]
	bool isInputComplete
	{
		[Token(Token = "0x600559C")]
		get;
	}

	[Token(Token = "0x14000087")]
	event Action onChangeComplete;
}
