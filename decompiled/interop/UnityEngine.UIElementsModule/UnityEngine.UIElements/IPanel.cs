using System;
using Il2CppDummyDll;

namespace UnityEngine.UIElements;

[Token(Token = "0x200028D")]
public interface IPanel : IDisposable
{
	[Token(Token = "0x17000339")]
	VisualElement visualTree
	{
		[Token(Token = "0x6001166")]
		get;
	}

	[Token(Token = "0x1700033A")]
	EventDispatcher dispatcher
	{
		[Token(Token = "0x6001167")]
		get;
	}

	[Token(Token = "0x1700033B")]
	ContextType contextType
	{
		[Token(Token = "0x6001168")]
		get;
	}

	[Token(Token = "0x1700033C")]
	FocusController focusController
	{
		[Token(Token = "0x6001169")]
		get;
	}
}
