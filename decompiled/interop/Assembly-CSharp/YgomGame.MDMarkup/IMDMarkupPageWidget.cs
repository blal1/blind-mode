using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using YgomSystem.UI;

namespace YgomGame.MDMarkup;

[Token(Token = "0x2000CFC")]
public interface IMDMarkupPageWidget
{
	[Token(Token = "0x17000B17")]
	List<SelectionButton> buttons
	{
		[Token(Token = "0x6004E65")]
		get;
	}

	[Token(Token = "0x14000071")]
	event Action<bool> onFocusPageEvent;
}
