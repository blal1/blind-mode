using Il2CppDummyDll;

namespace UnityEngine.UIElements;

[Token(Token = "0x20001E9")]
public interface IKeyboardEvent
{
	[Token(Token = "0x1700026C")]
	EventModifiers modifiers
	{
		[Token(Token = "0x6000DD0")]
		get;
	}

	[Token(Token = "0x1700026D")]
	char character
	{
		[Token(Token = "0x6000DD1")]
		get;
	}

	[Token(Token = "0x1700026E")]
	KeyCode keyCode
	{
		[Token(Token = "0x6000DD2")]
		get;
	}
}
