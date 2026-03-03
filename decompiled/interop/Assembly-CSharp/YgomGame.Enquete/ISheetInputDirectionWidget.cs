using System;
using Il2CppDummyDll;
using YgomSystem.UI;

namespace YgomGame.Enquete;

[Token(Token = "0x2000E22")]
public interface ISheetInputDirectionWidget
{
	[Token(Token = "0x17000CC5")]
	Func<SelectionItem, PadInputDirection, bool> onInputDirectionFunc
	{
		[Token(Token = "0x600559B")]
		set;
	}
}
